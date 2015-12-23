using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using SmugMugModel;
using SmugMugModel.Utility;



namespace SmugMugTest
{
    class Program
    {

        static void img_UploadProgress(object sender, UploadEventArgs e)
        {
            Console.WriteLine("{1} - {0,5:N}", e.PercentComplete * 100, e.FileName);
        }

        static void img_UploadCompleted(object sender, EventArgs e)
        {
            Console.WriteLine("Upload complete");
        }

        static string apiKey = null, secret = null, token = null, tokenSecret = null;

        /// <summary>
        /// If the secrets are in a file, get them from there. Otherwise, request them (apikey, secret) from the user
        /// </summary>
        private static void GetSmugMugSecrets()
        {
            SmugMugSecretsAccess.ReadSecretsFromFile(out apiKey, out secret, out token, out tokenSecret);

            // Do we have the secret/apikey?
            if (string.IsNullOrEmpty(apiKey) || string.IsNullOrEmpty(secret))
            {
                Console.WriteLine("Please enter your API Key and press [Enter]:");
                apiKey = Console.ReadLine();
                Console.WriteLine("Please enter your Application Secret and press [Enter]:");
                secret = Console.ReadLine();
            }

            Console.WriteLine("Using APIKey={0}", apiKey);
            Console.WriteLine("Using AppSecret={0}", secret);
            Console.WriteLine("Using token={0}", token);
            Console.WriteLine("Using tokenSecret={0}", tokenSecret);
        }

        /// <summary>
        /// If we have a valid access token, "login" to smugmug.
        /// Otherwise authorize the application to smugmug.
        /// </summary>
        /// <param name="mySite"></param>
        /// <param name="accessTok"></param>
        /// <returns></returns>
        private static MyUser AuthorizeToSmugMug(Site mySite)
        {
            //These values should have already been populated
            if (string.IsNullOrEmpty(apiKey) || string.IsNullOrEmpty(secret))
            {
                return null;
            }

            Token accessTok = new Token() { id = token, Secret = tokenSecret };

            MyUser user = null;
            //if we have a token
            if (!(string.IsNullOrEmpty(token) || string.IsNullOrEmpty(tokenSecret)))
            {
                user = mySite.Login(accessTok);
            }

            // If the token was valid
            if (user == null)
            {
                do
                {
                    // reauthorize
                    accessTok = SmugMugAuthorize.AuthorizeSmugMug(mySite);

                    user = mySite.Login(accessTok);

                    if (user == null)
                    {
                        Console.WriteLine("Authorizing the user failed. Try authorizing again? (hit Y to continue)");
                        if (Console.ReadKey().Key == ConsoleKey.Y)
                        {
                            continue;
                        }
                        else
                        {
                            return null;
                        }
                    }
                    else
                    {
                        //save the secrets to the file
                        SmugMugSecretsAccess.SaveSecretsToFile(apiKey, secret, accessTok.id, accessTok.Secret);
                    }
                } while (user == null);
            }

            return user;
        }

        static void Main(string[] args)
        {
            GetSmugMugSecrets();
            Site.Proxy = WebRequest.DefaultWebProxy;
            Site mySite = new Site(ApiKey: apiKey, Secret: secret);

            MyUser user = AuthorizeToSmugMug(mySite);
            if (user == null)
            {
                Console.WriteLine("Authorization failed.");
                return;
            }

            //TestUser(user);

            TestImage(user);

            TestFamily(user);

            TestStyles(mySite);

            TestCommunity(user);

            TestFriends(user);

            TestFans(user);

            TestCategories(user);

            TestAlbumTemplate(user);

            Album myAlbumTitleOnly = TestAlbum(user);

            TestShareGroups(user, myAlbumTitleOnly);

            // ====  cleanup  ====
            try
            {
                myAlbumTitleOnly.Delete();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();

            Console.ReadKey();
        }

        private static void TestUser(MyUser user)
        {
            try
            {
                // Test featured albums - for the moment they only return an album with an id and key (heavy returns the same as basic)
                Console.WriteLine("Getting featured Albums.");
                var myFeatured = user.GetFeaturedAlbums();
                if ((myFeatured != null) && (myFeatured.Albums != null))
                {
                    Console.WriteLine("Found {0} featured albums", myFeatured.Albums.Count);
                    foreach (var item in myFeatured.Albums)
                    {
                        Console.WriteLine("Found features album '{0}'", item.Title);
                        Console.WriteLine(item.Key);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();

            try
            {
                // Get a list of themes for the user
                Console.WriteLine("Getting the list of themes for the user");
                var myThemesList = user.GetThemes();
                Console.WriteLine("Found '{0}' themes for the user", myThemesList.Count);
                foreach (var x in myThemesList)
                {
                    Console.WriteLine("Found theme: name:{0} - type:{1}", x.Name, x.Type);
                }
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            try
            {
                // Get a hierarchical album tree for the user
                Console.WriteLine("Getting the album tree for the user");
                var list = user.GetTree(true);
                foreach (Category x in list)
                {
                    var alb = x.Albums;
                    if (alb != null)
                    {
                        foreach (var y in alb)
                        {
                            Console.WriteLine("Found album {0} in category {1}", y.Title, x.Name);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();
        }

        private static void TestFamily(MyUser user)
        {
            try
            {
                List<string> families = new List<string>() { "baldy", "markabby", "beanland" };
                foreach (var family in families)
                {
                    Console.WriteLine("Adding family '{0}' to user.", family);
                    user.AddFamily(family);
                }

                List<Family> families_site = user.GetFamily();
                foreach (var family_site in families_site)
                {
                    Debug.Assert(families.Contains(family_site.NickName.ToLowerInvariant()));
                }

                //Remove a family
                Console.WriteLine("Remove family '{0}'", families[0]);
                user.RemoveFamily(families[0]);
                families.Remove(families[0]);

                //validate we have the right families
                families_site = user.GetFamily();
                foreach (var family_site in families_site)
                {
                    Debug.Assert(families.Contains(family_site.NickName.ToLowerInvariant()));
                }
            }
            finally
            {
                user.RemoveAllFamily();
            }

            Console.WriteLine("Test the family functions");
            // Adding three smugmug heroes as family (for test)
            try
            {
                user.AddFamily("baldy");
                user.AddFamily("markabby");
                user.AddFamily("beanland");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            // Get a list of your family and display it
            List<Family> myFamilyList = null;
            try
            {
                myFamilyList = user.GetFamily();
                foreach (var x in myFamilyList)
                {
                    Console.WriteLine(x.Name + ' ' + x.URL);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            try
            {
                // Removing someone from family
                user.RemoveFamily("baldy");
                // Remove all family
                user.RemoveAllFamily();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();
        }

        private static void TestImage(MyUser user)
        {
            string image = "images\\1.jpg";
            Album album = null;

            try
            {
                album = user.CreateAlbum("TestImageAlbum");

                var imageUploader = album.CreateUploader();

                try
                {
                    System.Threading.CancellationTokenSource cts = new System.Threading.CancellationTokenSource();
                    cts.CancelAfter(1000);
                    imageUploader.UploadProgress += img_UploadProgress;
                    imageUploader.UploadImageAsync(image, cts.Token).Wait();

                    Debug.Fail("Upload should have been cancelled.");
                }
                catch (AggregateException)
                {
                    Console.WriteLine("Upload canceled  ---  OK!");
                }
                finally
                {
                    imageUploader.UploadProgress -= img_UploadProgress;
                }

                Console.WriteLine("Re-uploading the image.");
                var img = imageUploader.UploadImage(image);
                Console.WriteLine("Image uploaded.");

                var c1 = img.AddComment("Test comment - no rating");
                var c2 = img.AddComment("Test comment - rating 1", 1);

                img.GetComments();
                Debug.Assert(img.Comments.Count == 2);

                // Watermark
                var watermark1 = img.CreateWatermark("Watermark 1");
                var watermark1_site = user.GetWatermarks().Where((w) => w.Name == "Watermark 1").FirstOrDefault();

                Debug.Assert(watermark1_site.id == watermark1.id);
                watermark1.Delete();

                watermark1_site = user.GetWatermarks().Where((w) => w.Name == "Watermark 1").FirstOrDefault();
                Debug.Assert(watermark1_site == null);

                // Printmark
                var printmark1 = img.CreatePrintmark("Printmark 1");
                var printmark1_site = user.GetPrintmarks().Where((w) => w.Name == "Printmark 1").FirstOrDefault();
                Debug.Assert(printmark1_site.id == printmark1.id);
                printmark1.Delete();
            }
            finally
            {
                if (album != null)
                    album.Delete();
            }
        }

        private static void TestStyles(Site mySite)
        {
            try
            {
                // Get the Styles from the site
                Console.WriteLine("Getting the styles for the site");
                var myTemplatesList = mySite.StylesGetTemplates();
                Console.WriteLine("Found '{0}' styles for the site", myTemplatesList.Count);
                foreach (var x in myTemplatesList)
                {
                    Console.WriteLine("Found template: {0}", x.Name);
                }
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private static void TestCommunity(MyUser user)
        {
            try
            {
                Console.WriteLine("Test the community functions");
                // View the communities you are joint to
                var myCommunitiesList = user.GetCommunities();
                if (myCommunitiesList != null)
                {
                    Console.WriteLine("Found {0} communities for the user", myCommunitiesList.Count);
                    foreach (var x in myCommunitiesList)
                    {
                        Console.WriteLine("Found community {0} with id {1}", x.Name, x.id);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();
        }

        private static void TestCategories(MyUser user)
        {
            Console.WriteLine("Test the category and subcategory methods");
            Album myAlbumInCategory = null;

            Category myCategory = null;
            SubCategory mySubCategory = null;
            SubCategory mySubCategoryNew = null;
            Album myAlbumInSubCategory = null;
            Album myAlbumInCategory2 = null;
            try
            {
                // Create a category
                myCategory = user.CreateCategory("TestCategory");
                Console.WriteLine("Created category {0}", myCategory.Name);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            try
            {
                // Create a subcategory in a category
                mySubCategory = myCategory.CreateSubCategory("TestSubCategory");
                Console.WriteLine("Created subcategoy {0} in category {1}", mySubCategory.Name, myCategory.Name);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            try
            {
                // Creating an album in a category
                myAlbumInCategory = myCategory.CreateAlbum("TestAlbumInCategory");
                Console.WriteLine("Created album {0} in category {1}", myAlbumInCategory.Title, myCategory.Name);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            try
            {
                // Creating an album in a subcategory
                myAlbumInSubCategory = mySubCategory.CreateAlbum("TestAlbumInSubCategory");
                Console.WriteLine("Created album {0} in the subcategory {1}", myAlbumInSubCategory.Title, mySubCategory.Name);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            try
            {
                List<Category> myCategoriesList = null;
                // Retrieves a list of categories for the user
                myCategoriesList = user.GetCategories();
                foreach (var x in myCategoriesList)
                {
                    Console.WriteLine(x.Name);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();

            try
            {
                // Renaming a category
                myCategory.Rename("TestCategoryRenamed");
                Console.WriteLine("TestCategory is renamed to " + myCategory.Name);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            // Create a subcategory within a category
            try
            {
                mySubCategoryNew = myCategory.CreateSubCategory("TestSubCategoryNew");
                Console.WriteLine(mySubCategoryNew.Name);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();

            // Get the subcategories for a category
            try
            {
                var mySubCategoriesList = myCategory.GetSubCategories();
                Console.WriteLine(myCategory.Name + " - " + myCategory.SubCategories.Count);
                foreach (var x in mySubCategoriesList)
                {
                    Console.WriteLine(x.Name);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();

            // Get all the subcategories that the user has
            try
            {
                var mySubCategoriesListAll = user.GetAllSubCategories();
                foreach (var x in mySubCategoriesListAll)
                {
                    Console.WriteLine(x.Name);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();

            // Rename a subcategory
            try
            {
                mySubCategoryNew.Rename("TestSubCategoryNewChangedName");
                Console.WriteLine("TestSubCategoryNew is renamed to " + mySubCategoryNew.Name);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();

            // Deleting a subcategory
            try
            {
                mySubCategoryNew.Delete();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            // Creating an album in a category
            try
            {
                Console.WriteLine(myCategory.Albums.Count);
                myAlbumInCategory2 = myCategory.CreateAlbum("TestAlbumInCategory2");
                Console.WriteLine();
                Console.WriteLine(myCategory.Albums.Count);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();

            try
            {
                // Deleting that album
                myAlbumInCategory2.Delete();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();
            try
            {
                myAlbumInCategory.Delete();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();

            try
            {
                myAlbumInSubCategory.Delete();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();

            try
            {
                myCategory.Delete();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();

            try
            {
                mySubCategory.Delete();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();
        }

        private static Album TestAlbum(MyUser user)
        {
            Console.WriteLine("Test the album functions: ");
            Album myAlbumTitleOnly = null;
            try
            {
                // Create an album only with title (if the category isn't specified, the default one is "Other")
                myAlbumTitleOnly = user.CreateAlbum("TestAlbumTitleOnly");
                Console.WriteLine("Created album {0}", myAlbumTitleOnly.Title);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            // Get all the albums from the site
            try
            {
                List<Album> myAlbumList = user.GetAlbums(true);
                foreach (var x in myAlbumList)
                {
                    Console.WriteLine("{0}-{1}-{2}", x.Title, x.Category, (x.SubCategory == null) ? "None" : x.SubCategory.Name);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();

            // Get info for an album from the site and return it in a new album (here I use the same object)
            try
            {
                var testAlbum = myAlbumTitleOnly.GetInfo();
                Console.WriteLine(testAlbum.Protected);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();

            // Populate the current album with info from the site
            try
            {
                myAlbumTitleOnly.PopulateAlbumWithInfoFromSite();
                Console.WriteLine(myAlbumTitleOnly.Protected);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();

            // Change the settings for an album
            try
            {
                Console.WriteLine(myAlbumTitleOnly.Protected);
                myAlbumTitleOnly.Protected = true;
                myAlbumTitleOnly.ChangeSettings();

                myAlbumTitleOnly.PopulateAlbumWithInfoFromSite();
                Console.WriteLine(myAlbumTitleOnly.Protected);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();

            // Comments
            try
            {
                myAlbumTitleOnly.AddComment("Comment for album");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();

            // Comments
            try
            {
                myAlbumTitleOnly.GetComments();
                if ((myAlbumTitleOnly.CommentsList != null) && (myAlbumTitleOnly.CommentsList.Count > 0))
                    Console.WriteLine(myAlbumTitleOnly.CommentsList[0].Text);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();

            // Upload piture to the album from an URL
            try
            {
                myAlbumTitleOnly.UploadImageFromURL("http://www.socialseo.com/files/images/best-free.jpg");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();

            // Upload pictures to the album
            try
            {
                var up = myAlbumTitleOnly.CreateUploader();
                up.UploadCompleted += new EventHandler<UploadEventArgs>(img_UploadCompleted);
                up.UploadProgress += new EventHandler<UploadEventArgs>(img_UploadProgress);
                Console.Write("Give picture with whole path (eg: " + @"C:\Users\Username\Pictures\IMG_1234.jpg): ");
                String img1 = "images\\1.jpg"; //  Console.ReadLine();
                Console.Write("Give picture with whole path (eg: " + @"C:\Users\Username\Pictures\IMG_1234.jpg): ");
                String img2 = "images\\2.jpg";  //Console.ReadLine();
                Console.Write("Give picture with whole path (eg: " + @"C:\Users\Username\Pictures\IMG_1234.jpg): ");
                String img3 = "images\\3.jpg"; //Console.ReadLine();
                up.UploadImage(img1);
                up.UploadImage(img2);
                up.UploadImage(img3);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();

            // Resort the album
            try
            {
                Console.WriteLine("Images before the sort");
                foreach (var x in myAlbumTitleOnly.GetImages(true))
                {
                    Console.WriteLine("{0} - {1}", x.FileName, x.Aperture);
                }
                myAlbumTitleOnly.ReSort(By.FileName, Direction.DESC);
                Console.WriteLine("Images after the sort");
                foreach (var x in myAlbumTitleOnly.GetImages(true))
                {
                    Console.WriteLine("{0} - {1}", x.FileName, x.Aperture);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();

            TestImage(user, myAlbumTitleOnly);

            return myAlbumTitleOnly;
        }

        private static void TestImage(MyUser user, Album myAlbumTitleOnly)
        {
            // Get all the images from the current album
            List<Image> myImageList = new List<Image>();
            Watermark myWatermark1 = null;
            Watermark myWatermark2 = null;
            Image myImage2 = null;
            Image myImage3 = null;
            try
            {
                myImageList = myAlbumTitleOnly.GetImages(true);
                foreach (var x in myImageList)
                {
                    Console.WriteLine("{0} - {1}", x.FileName, x.Date);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();

            // Comments
            try
            {
                myImageList[0].AddComment("Comment on image");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();




            Console.WriteLine("Test the image functions:");

            try
            {
                Image myImage = myImageList[0];
                myImage2 = myImageList[1];
                myImage3 = myImageList[2];
                // Change position
                myImage.ChangePosition(2);
                myImageList = myAlbumTitleOnly.GetImages(true);
                foreach (var x in myImageList)
                {
                    Console.WriteLine(x.FileName);
                }
                // Crop the picture
                myImage2.Crop(300, 300, 0, 10);
                // Change settings
                myImage.Caption = "Test image";
                myImage.ChangeSettings();
                Console.WriteLine("The new image caption is: " + myImage.Caption);
                // Get EXIF info from site
                myImage = myImage.GetEXIF();

                var imageWithStats = myImage.GetStats(12, 2011);

                myImage2.PopulateImageWithEXIFFromSite();
                Console.WriteLine("EXIF info: " + myImage.Model);
                Console.WriteLine("EXIF info: " + myImage2.Model);
                // Get info from site
                myImage = myImage.GetInfo();
                myImage2.PopulateImageWithInfoFromSite();
                Console.WriteLine("Info: " + myImage.FileName);
                Console.WriteLine("Info: " + myImage2.FileName);
                // Get the URLs
                myImage = myImage.GetURLs();
                myImage2.PopulateImageWithURLsFromSite();
                Console.WriteLine(myImage2.OriginalURL);
                // Rotate an image
                myImage.Rotate(DegreesEnum.Left, false);
                // Zoom the thumbnail
                myImage3.ZoomThumbnail(100, 100, 1, 1);
                myImage.Delete();
                Console.WriteLine("The remaining pictures after delete: ");
                myImageList = myAlbumTitleOnly.GetImages(true);
                foreach (var x in myImageList)
                {
                    Console.WriteLine(x.FileName);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();


            // Comments
            try
            {
                myImageList[0].GetComments();
                if (myImage2.Comments != null)
                    Console.WriteLine(myImage2.Comments[0].Text);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();


            Console.WriteLine("Test the watermarking functions:");
            // Create a watermark
            try
            {
                myWatermark1 = myImage2.CreateWatermark("TestWatermark1");
                myImage3.ApplyWatermark(myWatermark1);
                myWatermark2 = myImage3.CreateWatermark("TestWatermark2");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();

            // Display the existing watermarks
            try
            {
                var myWatermarksList = user.GetWatermarks(true);
                foreach (var x in myWatermarksList)
                {
                    Console.WriteLine(x.Name);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();

            // Change settings
            try
            {
                myWatermark1.Name = "TestWatermarkNameChanged";
                myWatermark1.Dissolve = 50;
                // Get info
                myWatermark1 = myWatermark1.GetInfo();
                Console.WriteLine(myWatermark1.Name);
                myWatermark2.PopulateWatermarkWithInfoFromSite();
                Console.WriteLine(myWatermark2.Name);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();

            try
            {
                myImage3.RemoveWatermark();
                myWatermark1.Delete();
                myWatermark2.Delete();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();
        }

        private static void TestAlbumTemplate(MyUser user)
        {
            Console.WriteLine("Test the album template methods:");
            AlbumTemplate myAlbumTemplate = null;
            AlbumTemplate at = null;
            try
            {
                // Create an album template
                myAlbumTemplate = user.CreateAlbumTemplate("TestAlbumTemplate");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();

            // Get the album templates for a user
            try
            {
                var myAlbumTemplatesList = user.GetAlbumTemplates();
                foreach (var x in myAlbumTemplatesList)
                {
                    Console.WriteLine(x.AlbumTemplateName);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();

            // Change the settings for an album template
            try
            {
                myAlbumTemplate.Comments = false;
                myAlbumTemplate.AlbumTemplateName = "AlbumTemplateChangedName";
                myAlbumTemplate.ChangeSettings();
                Console.WriteLine("{0} - {1}", myAlbumTemplate.AlbumTemplateName, myAlbumTemplate.Comments);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();

            // Delete an album template
            try
            {
                myAlbumTemplate.Delete();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();

            // Create an album template and save it to the site
            try
            {
                at = new AlbumTemplate();
                at.AlbumTemplateName = "AlbumTemplateNew";
                at.Public = false;
                at = user.CreateAlbumTemplate(at);
                Console.WriteLine(at.AlbumTemplateName);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();

            try
            {
                at.Delete();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();
        }

        private static void TestShareGroups(MyUser user, Album myAlbumTitleOnly)
        {
            Console.WriteLine("Test the sharegroup methods");
            ShareGroup myShareGroup = null;
            ShareGroup myShareGroupWithDescription = null;
            try
            {
                // Create a sharegroup without description
                myShareGroup = user.CreateShareGroup("TestShareGroup");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            try
            {
                // Create a sharegroup with description 
                myShareGroupWithDescription = user.CreateShareGroup("TestShareGroupWithDescription", "Something for testing");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            // Get a list of sharegroups and display it
            var myShareGroupsList = user.GetShareGroups(true);
            foreach (var x in myShareGroupsList)
            {
                Console.WriteLine(x.Name + ' ' + x.Description + ' ' + x.URL);
            }

            try
            {
                // Retrieving info about a sharegroup from the site by creating a new sharegroup in which it will be stored
                myShareGroup = myShareGroup.GetInfo();
                Console.WriteLine(myShareGroup.Name + ' ' + myShareGroup.Tag);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            try
            {
                // Retrieving info about a sharegroup from the site by populating the current object
                myShareGroupWithDescription.PopulateShareGroupWithInfoFromSite();
                Console.WriteLine(myShareGroupWithDescription.Name + ' ' + myShareGroupWithDescription.Tag);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            try
            {
                // Add an album to a sharegroup
                myShareGroup.AddAlbum(myAlbumTitleOnly);
                Console.WriteLine("Number of albums on sharegroup: " + myShareGroup.AlbumCount);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            // Get the albums that a sharegroup has
            var myShareGroupAlbums = myShareGroup.GetAlbums();
            foreach (var x in myShareGroupAlbums)
            {
                Console.WriteLine(x.Title);
            }

            try
            {
                // Remove an album from a sharegroup
                myShareGroup.RemoveAlbum(myAlbumTitleOnly);
                Console.WriteLine(myShareGroup.AlbumCount);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            try
            {
                //Deleting a sharegroup
                myShareGroup.Delete();
                myShareGroupWithDescription.Delete();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();
        }

        private static void TestFans(MyUser user)
        {

            Console.WriteLine("Test the fans functions");
            try
            {
                var myFans = user.GetFans();
                if ((myFans != null) && (myFans.Count > 0))
                {
                    foreach (var item in myFans)
                    {
                        Console.WriteLine(item.Name);
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();
        }

        private static void TestFriends(MyUser user)
        {
            Console.WriteLine("Test the friends functions");
            try
            { // Adding three smugmug heroes as friends
                user.AddFriend("baldy");
                user.AddFriend("markabby");
                user.AddFriend("beanland");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();
            try
            {
                // Get a list of your friends and display it
                var myFriendsList = user.GetFriends();
                if (myFriendsList != null)
                {
                    foreach (var x in myFriendsList)
                    {
                        Console.WriteLine(x.Name + ' ' + x.URL);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();
            try
            {
                // Removing someone from friends
                user.RemoveFriend("baldy");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();
            try
            {
                // Remove all friends
                user.RemoveAllFriends();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();
        }
    }
}
