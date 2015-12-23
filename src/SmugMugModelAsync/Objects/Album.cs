using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmugMugModel
{
    public abstract class AlbumBase : SmugMugObject
    {
        #region Properties
        // essentials
        public long id { get; set; }
        public string Key { get; set; }
        public string Title { get; set; }

        public AlbumTemplate AlbumTemplate { get; set; }
        /// <summary>
        /// pro only (text to be printed on the back of prints purchased
        /// </summary>
        public string Backprinting { get; set; }
        /// <summary>
        /// The bytes transferred for this user for a given month
        /// </summary>
        public long Bytes { get; set; }
        /// <summary>
        /// Enable boutique packaging for orders from this album (owner, pro accounts only). Values: 0=No, 1=Yes, 2=Inherit
        /// </summary>
        public BoutiquePackaging BoutiquePackaging { get; set; }
        //it wasn't in the description
        public bool? CameraInfo { get; set; }
        /// <summary>
        /// Allow images from the album to be ranked using PhotoRank
        /// </summary>
        public bool? CanRank { get; set; }
        public Category Category { get; set; }
        /// <summary>
        /// Hide the Description and LastUpdated for the album on the homepage and category pages
        /// </summary>
        public bool? Clean { get; set; }
        /// <summary>
        /// 0=No, 1=Yes, 2=Inherit(default)
        /// </summary>
        public ColorCorrection ColorCorrection { get; set; }
        /// <summary>
        /// The community that this album belongs to.
        /// </summary>
        public Community Community { get; set; }
        /// <summary>
        /// Hack: The class has 2 properties with the same name - Comments. I've separated them in 2 different properties (HasComments and CommentsList)
        /// </summary>
        [Obsolete("Deprecated and replaced by ColorCorrection on January 27th 2009")]
        /// <summary>
        /// pro only (deprecated). Values: false-Auto Color (default), true-TrueColor
        /// </summary>
        public bool? DefaultColor { get; set; }
        /// <summary>
        /// The description for this album.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Allow EXIF data to be viewd for images from this album (default - true)
        /// </summary>
        public bool? EXIF { get; set; }
        /// <summary>
        /// Allow images from this album to be linked externally outside SmugMug (default - true)
        /// </summary>
        public bool? External { get; set; }
        /// <summary>
        /// Allow family to edit the captions and keywords of the images in this album (default - false)
        /// </summary>
        public bool? FamilyEdit { get; set; }
        /// <summary>
        /// Show filenm,e for images uploaded with no caption to this album
        /// </summary>
        public bool? Filenames { get; set; }
        /// <summary>
        /// Allow friends to edit the captions and keywords of the images in this album (default - false)
        /// </summary>
        public bool? FriendEdit { get; set; }
        /// <summary>
        /// Enable mapping features for this album (default - true)
        /// </summary>
        public bool? Geography { get; set; }
        /// The URL to allow guests to upload to this gallery.
        /// </summary>
        public string GuestUploadURL { get; set; }
        /// <summary>
        /// Default this album to the standard smugmug appearance (false-Custom =default, true-Smugmug)
        /// </summary>
        public bool? Header { get; set; }
        /// <summary>
        /// (default - false)
        /// </summary>
        public bool? HideOwner { get; set; }
        /// <summary>
        /// The highlight image for this album.
        /// </summary>
        public Highlight Highlight { get; set; }
        /// <summary>
        /// The total hits for this user for a given month
        /// </summary>
        public long Hits { get; set; }
        /// <summary>
        /// The number of images in this album
        /// </summary>
        public int? ImageCount { get; set; }
        public Image[] Images { get; set; }
        /// <summary>
        /// Enable intercept shipping (personal delivery) for orders from this album. Values: 0=No, 1=Yes, 2=Inherit
        /// </summary>
        public InterceptShipping InterceptShipping { get; set; }
        /// <summary>
        /// The meta keyword string for this album.
        /// </summary>
        public string Keywords { get; set; }
        /// <summary>
        /// The number of Large hits for this user for a given month
        /// </summary>
        public long Large { get; set; }
        /// <summary>
        /// Allow viewing of Large images for this album (default - true)
        /// </summary>
        public bool? Larges { get; set; }
        /// <summary>
        /// The date that this album was last updated
        /// </summary>
        public string LastUpdated { get; set; }
        /// <summary>
        /// The number of Medium hits for this user for a given month
        /// </summary>
        public long Medium { get; set; }
        /// <summary>
        /// The nicename for this album. (owner)
        /// </summary>
        public string NiceName { get; set; }
        /// <summary>
        /// The number of Original hits for this user for a given month
        /// </summary>
        public long Original { get; set; }
        /// <summary>
        /// Allow viewing of original images for this album (default - true)
        /// </summary>
        public bool? Originals { get; set; }
        /// <summary>
        /// Enable packaging branding for orders from this album (owner, pro accounts only)
        /// </summary>
        public bool PackagingBranding { get; set; }
        /// <summary>
        /// The password for this album.
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// The password hint for this album
        /// </summary>
        public string PasswordHint { get; set; }
        /// <summary>
        /// Indicates whether this album is password protected.
        /// </summary>
        public bool? Passworded { get; set; }
        /// <summary>
        /// The position of this album within the site
        /// </summary>
        public int? Position { get; set; }
        /// <summary>
        /// The printmark applied to images of this album (id and Name) (owner, Pro accounts only)
        /// </summary>
        public Printmark Printmark { get; set; }
        // Not in the API
        public string PrintVendor { get; set; }
        /// <summary>
        /// Allow images from this album to purchased as a print, merchandise or digital download (default - true)
        /// </summary>
        public bool? Printable { get; set; }
        /// <summary>
        /// pro only. The number of days an order is held for a pro to proof prior to being sent to print (default: 0, min: 0, max: 7)
        /// </summary>
        public long? ProofDays { get; set; }
        /// <summary>
        /// Enable right-click protection for this album (default - false)
        /// </summary>
        public bool? Protected { get; set; }
        /// <summary>
        /// Display this album publicly (default - true)
        /// </summary>
        public bool? Public { get; set; }
        /// <summary>
        /// The number of Small hits for this user for a given month
        /// </summary>
        public long Small { get; set; }
        /// <summary>
        /// Allow smugmug to index images from this album (default - true)
        /// </summary>
        public bool? SmugSearchable { get; set; }
        /// <summary>
        /// The direction used for sorting images from this album (values: false-Ascending default, true-Descending)
        /// </summary>
        public bool? SortDirection { get; set; }
        /// <summary>
        /// The method used for sorting images within the album (values: "Position" - None, "Caption" - By caption, "FileName" - By filenames, "Date" - By date uploaded, "DateTime" - By date modified (if available), "DateTimeOriginal" - By date taken (if available))
        /// </summary>
        public SortMethod SortMethod { get; set; }
        /// <summary>
        /// Display the Share button for this album (default - true)
        /// </summary>
        public bool? Share { get; set; }
        /// <summary>
        /// Enable automatic square cropping of thumbnails for this album (default - true)
        /// </summary>
        public bool? SquareThumbs { get; set; }
        /// <summary>
        /// The subcategory that this album belongs to (id and Name)
        /// </summary>
        public SubCategory SubCategory { get; set; }
        /// <summary>
        /// The style template applied to this album
        /// </summary>
        public Template Template { get; set; }
        /// <summary>
        /// The theme applied to this album.
        /// </summary>
        public Theme Theme { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long Thumb { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long Tiny { get; set; }
        /// <summary>
        /// Create an album if one of the same name doesn't already exist in the current hierarchy. Default: false
        /// </summary>
        public bool? Unique { get; set; }
        /// <summary>
        /// The Amount setting used for sharpening display copies of images in this album (default: 0.2, min: 0, max: 5)
        /// (power and pro only)
        /// </summary>
        public float? UnsharpAmount { get; set; }
        /// <summary>
        /// The Radius setting used for sharpening display copies of images in this album (default: 1, min: 0.1, max: 120)
        /// (power and pro only)
        /// </summary>
        public float? UnsharpRadius { get; set; }
        /// <summary>
        /// The Threshold setting used for sharpening display copies of images in this album (default: 1, min: 0, max: 255)
        /// (power and pro only)
        /// </summary>
        public float? UnsharpThreshold { get; set; }
        /// <summary>
        /// The Sigma setting used for sharpening display copies of images in this album (default: 0.05)
        /// (power and pro only)
        /// </summary>
        public float? UnsharpSigma { get; set; }
        /// <summary>
        /// The key to allow guest uploading to this album.
        /// </summary>
        public string UploadKey { get; set; }
        /// <summary>
        /// The URL for this album.
        /// </summary>
        public string URL { get; set; }
        /// <summary>
        /// The number of Video1280 hits for this user for a given month (pro accounts only)
        /// </summary>
        public int? Video1280 { get; set; }
        /// <summary>
        /// The number of Video1920 hits for this user for a given month (pro accounts only)
        /// </summary>
        public int? Video1920 { get; set; }
        /// <summary>
        /// The number of Video320 hits for this user for a given month (power and pro accounts only)
        /// </summary>
        public int? Video320 { get; set; }
        /// <summary>
        /// The number of Video640 hits for this user for a given month (power and pro accounts only)
        /// </summary>
        public int? Video640 { get; set; }
        /// <summary>
        /// The number of Video960 hits for this user for a given month (pro accounts only)
        /// </summary>
        public int? Video960 { get; set; }
        /// <summary>
        /// Enable automatic watermarking for this album (default - false)
        /// </summary>
        public bool? Watermarking { get; set; }
        /// <summary>
        /// The watermark applied to images of this album. (id and Name)
        /// </summary>
        public Watermark Watermark { get; set; }
        /// <summary>
        /// Allow search engines to index images from this album (default - true)
        /// </summary>
        public bool? WorldSearchable { get; set; }
        /// <summary>
        /// The number of X2Large hits for this user for a given month
        /// </summary>
        public long X2Large { get; set; }
        /// <summary>
        /// Allow viewing of X2Large images for this album (default - true)
        /// </summary>
        public bool? X2Larges { get; set; }
        /// <summary>
        /// The number of X3Large hits for this user for a given month
        /// </summary>
        public long X3Large { get; set; }
        /// <summary>
        /// Allow viewing of X3Large images for this album (default - true)
        /// </summary>
        public bool? X3Larges { get; set; }
        /// <summary>
        /// The number of XLarge hits for this user for a given month
        /// </summary>
        public long XLarge { get; set; }
        /// <summary>
        /// Allow viewing of XLarge images for this album (default - true)
        /// </summary>
        public bool? XLarges { get; set; }
        #endregion
    }

    public class Album : AlbumBase
    {

        #region Properties
        public object Comments;
        /// <summary>
        /// Allow visitors to leave comments (default = true)
        /// </summary>
        public bool HasComments
        {
            get
            {
                if ((Comments != null) && (Comments.GetType() == typeof(bool)))
                    return (bool)Comments;
                return false;
            }
            set
            {
                if ((Comments != null) && (Comments.GetType() == typeof(bool)))
                    Comments = value;
            }
        }
        /// <summary>
        /// A list of comments on the gallery
        /// </summary>
        public List<Comment> CommentsList
        {
            get
            {
                if ((Comments != null) && (Comments.GetType() == typeof(List<Comment>)))
                    return (List<Comment>)Comments;
                return new List<Comment>();
            }
            set
            {
                if ((Comments != null) && (Comments.GetType() == typeof(List<Comment>)))
                    Comments = value;
            }
        }
        #endregion

        public override string ToString()
        {
            return Title;
        }

        #region Sync
        /// <summary>
        /// Creates a new album with the specified parameters - Title [required], AlbumTemplateID, Backprinting (pro only), CanRank, CategoryID, Clean, ColorCorrection, Comments, CommunityID, DefaultColor (pro only), Description, EXIF, External, FamilyEdit, FriendEdit, Geography, Header (power, pro only), HideOwner, HighlightID, Keywords, Larges (pro only), Originals, Password, PasswordHint, Position, Printable, ProofDays (pro only), Protected (power, pro only), Public, Share, SmumugSearchable, SortDirection, SortMethod, SquareThumbs, SubCategoryID, TemplateID, ThemeID, Unique, UnsharpAmount (power, pro only), UnsharpRadius (power, pro only), UnsharpSigma (power, pro only), UnsharpThreshold (power, pro only), WatermarkID (pro only), Watermarking (pro only), WorldSearchable, X2Larges, X3Larges, XLarges (pro only)
        /// </summary>
        /// <returns>Album (id and Key)</returns>
        internal Album Create()
        {
            return Create(false, "");
        }

        /// <summary>
        /// Creates a new album with the specified parameters - Title [required], AlbumTemplateID, Backprinting (pro only), CanRank, CategoryID, Clean, ColorCorrection, Comments, CommunityID, DefaultColor (pro only), Description, EXIF, External, FamilyEdit, FriendEdit, Geography, Header (power, pro only), HideOwner, HighlightID, Keywords, Larges (pro only), Originals, Password, PasswordHint, Position, Printable, ProofDays (pro only), Protected (power, pro only), Public, Share, SmumugSearchable, SortDirection, SortMethod, SquareThumbs, SubCategoryID, TemplateID, ThemeID, Unique, UnsharpAmount (power, pro only), UnsharpRadius (power, pro only), UnsharpSigma (power, pro only), UnsharpThreshold (power, pro only), WatermarkID (pro only), Watermarking (pro only), WorldSearchable, X2Larges, X3Larges, XLarges (pro only)
        /// </summary>
        /// <param name="Unique">Create an album if one of the same name doesn't already exist in the current hierarchy. Default: false.</param>
        /// <param name="Extras">A comma seperated string of additional attributes to return in the response.</param>
        /// <returns>Album (id and Key)</returns>
        internal Album Create(bool Unique, string Extras)
        {
            return CreateAsync(Unique, Extras).Result;
        }

        /// <summary>
        /// Change the settings of an existing album - AlbumTemplateID, Backprinting (pro), CanRank, CategoryID, Clean, ColorCorrection, Comments, CommunityID, DefaultColor  (pro), Description, EXIF, External, FamilyEdit, FriendEdit, Geography, Header (power, pro), HideOwner, HighlightID, Keywords, Larges, NiceName, Originals, Password, PasswordHint, Position, Printable, ProofDays, Protected (power, pro), Public, Share, SmumugSearchable, SortDirection, SortMethod, SquareThumbs, SubCategoryID, TemplateID, ThemeID, UnsharpAmount (power, pro), UnsharpRadius (power, pro), UnsharpSigma (power, pro), UnsharpThreshold (power, pro), WatermarkID (pro), Watermarking (pro), WorldSearchable, X2Larges, X3Larges, XLarges (pro)
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public bool ChangeSettings()
        {
            return ChangeSettingsAsync().Result;
        }

        /// <summary>
        /// This method will re-sort all the photos inside of the album specified by AlbumID. Note that this is a one-time event, and doesn't apply directly to images added in the future by other means.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public bool ReSort(By b, Direction d)
        {
            return ReSortAsync(b, d).Result;
        }

        /// <summary>
        /// Retrieves the details for a specified album (id, Key, Backprinting, CanRank, CategoryID and Name, Clean, ColorCorrection, Comments, CommunityID and Name, Description, EXIF, External, FamilyEdit, FriendEdit, Geography, Header, HideOwner, HighlightID and Key, ImageCount, Larges, LastUpdated, NiceName, Originals, Password, PasswordHint, Position, Printable, ProofDays, Protected, Public, Share, SmumugSearchable, SortDirection, SortMethod, SquareThumbs, SubCategoryID and Name, TemplateID, ThemeID and Name and Type, Title, Unique, UnsharpAmount, UnsharpRadius, UnsharpSigma, UnsharpThreshold, WatermarkID and Name, Watermarking, WorldSearchable, X2Larges, X3Larges, XLarges)
        /// </summary>
        /// <returns>Album</returns>
        public Album GetInfo()
        {
            return GetInfo("");
        }

        /// <summary>
        /// Retrieves the details for a specified album (id, Key, Backprinting, CanRank, CategoryID and Name, Clean, ColorCorrection, Comments, CommunityID and Name, Description, EXIF, External, FamilyEdit, FriendEdit, Geography, Header, HideOwner, HighlightID and Key, ImageCount, Larges, LastUpdated, NiceName, Originals, Password, PasswordHint, Position, Printable, ProofDays, Protected, Public, Share, SmumugSearchable, SortDirection, SortMethod, SquareThumbs, SubCategoryID and Name, TemplateID, ThemeID and Name and Type, Title, Unique, UnsharpAmount, UnsharpRadius, UnsharpSigma, UnsharpThreshold, WatermarkID and Name, Watermarking, WorldSearchable, X2Larges, X3Larges, XLarges)
        /// </summary>
        /// <param name="SitePassword">The site password for a specific user</param>
        /// <returns></returns>
        public Album GetInfo(string SitePassword)
        {
            return GetInfoAsync(SitePassword).Result;
        }

        /// <summary>
        /// Populate the current album with info from the site (id, Key, Backprinting, CanRank, CategoryID and Name, Clean, ColorCorrection, Comments, CommunityID and Name, Description, EXIF, External, FamilyEdit, FriendEdit, Geography, Header, HideOwner, HighlightID and Key, ImageCoutn, Larges, Originals, Password, PasswordHint, Position, Printable, ProofDays, Protected, Public, Share, SmumugSearchable, SortDirection, SortMethod, SquareThumbs, SubCategoryID and Name, TemplateID, ThemeID and Name and Type, Title, Unique, UnsharpAmount, UnsharpRadius, UnsharpSigma, UnsharpThreshold, WatermarkID and Name, Watermarking, WorldSearchable, X2Larges, X3Larges, XLarges)
        /// </summary>
        public void PopulateAlbumWithInfoFromSite()
        {
            PopulateAlbumWithInfoFromSite("");
        }

        /// <summary>
        /// Populate the current album with info from the site (id, Key, Backprinting, CanRank, CategoryID and Name, Clean, ColorCorrection, Comments, CommunityID and Name, Description, EXIF, External, FamilyEdit, FriendEdit, Geography, Header, HideOwner, HighlightID and Key, ImageCoutn, Larges, Originals, Password, PasswordHint, Position, Printable, ProofDays, Protected, Public, Share, SmumugSearchable, SortDirection, SortMethod, SquareThumbs, SubCategoryID and Name, TemplateID, ThemeID and Name and Type, Title, Unique, UnsharpAmount, UnsharpRadius, UnsharpSigma, UnsharpThreshold, WatermarkID and Name, Watermarking, WorldSearchable, X2Larges, X3Larges, XLarges)
        /// </summary>
        public void PopulateAlbumWithInfoFromSite(string SitePassword)
        {
            PopulateAlbumWithInfoFromSiteAsync(SitePassword).Wait();
        }

        /// <summary>
        /// Deletes an existing album
        /// </summary>
        /// <returns></returns>
        public bool Delete()
        {
            return DeleteAsync().Result;
        }

        /// <summary>
        /// Gets the standard transfer statistics for the given Album during the given Month and Year (id, Key, Bytes, Hits, Large, Medium, original, Small, Thumb, Tiny, X2Large, X3Large, XLarge, Video320, Video640, Video960, Video1280, Video1960). SmugMug only keeps the last few months of traffic on file, so requesting farther back then 2 months may not return valid results. A float is provided for Original and video sizes because it's possible to watch only a portion of a video
        /// </summary>
        /// <param name="Month"></param>
        /// <param name="Year"></param>
        /// <returns>Album</returns>
        public Album GetStats(int Month, int Year)
        {
            return GetStats(Month, Year, false);
        }

        /// <summary>
        /// Gets the extended transfer statistics for the given Album and all its images during the given Month and Year (id, Key, Bytes, Hits, Large, Medium, original, Small, Thumb, Tiny, X2Large, X3Large, XLarge, Video320, Video640, Video960, Video1280, Video1960, Images array with the same kind of stats). SmugMug only keeps the last few months of traffic on file, so requesting farther back then 2 months may not return valid results. A float is provided for Original and video sizes because it's possible to watch only a portion of a video
        /// </summary>
        /// <param name="Month"></param>
        /// <param name="Year"></param>
        /// <param name="Heavy">If Heavy is set to "1", transfer statistics for each image in each album will be returned as well</param>
        /// <returns></returns>
        public Album GetStats(int Month, int Year, bool Heavy)
        {
            return GetStatsAsync(Month, Year, Heavy).Result;
        }

        /// <summary>
        /// Populate the current album with standard transfer statistics during the given Month and Year (id, Key, Bytes, Hits, Large, Medium, original, Small, Thumb, Tiny, X2Large, X3Large, XLarge, Video320, Video640, Video960, Video1280, Video1960). SmugMug only keeps the last few months of traffic on file, so requesting farther back then 2 months may not return valid results. A float is provided for Original and video sizes because it's possible to watch only a portion of a video
        /// </summary>
        /// <param name="Month"></param>
        /// <param name="Year"></param>
        /// <returns></returns>
        public void PopulateAlbumWithStatsFromSite(int Month, int Year)
        {
            PopulateAlbumWithStatsFromSite(Month, Year, false);
        }

        /// <summary>
        /// Populate the current album and its images with transfer statistics during the given Month and Year (id, Key, Bytes, Hits, Large, Medium, original, Small, Thumb, Tiny, X2Large, X3Large, XLarge, Video320, Video640, Video960, Video1280, Video1960). SmugMug only keeps the last few months of traffic on file, so requesting farther back then 2 months may not return valid results. A float is provided for Original and video sizes because it's possible to watch only a portion of a video
        /// </summary>
        /// <param name="Month"></param>
        /// <param name="Year"></param>
        /// <param name="Heavy">If Heavy is set to "1", transfer statistics for each image in each album will be returned as well</param>
        /// <returns></returns>
        public void PopulateAlbumWithStatsFromSite(int Month, int Year, bool Heavy)
        {
            PopulateAlbumWithStatsFromSiteAsync(Month, Year, Heavy).Wait();
        }




        /// <summary>
        /// Applies a watermark to the images of an album
        /// </summary>
        /// <param name="w">The id for a specific watermark</param>
        /// <returns></returns>
        public bool ApplyWatermark(Watermark w)
        {
            return ApplyWatermarkAsync(w).Result;
        }

        /// <summary>
        /// Removes a watermark from the images of an album
        /// </summary>
        /// <returns></returns>
        public bool RemoveWatermark()
        {
            return RemoveWatermarkAsync().Result;
        }


        /// <summary>
        /// Uploads an image from a URL to an album - Image with id, Key and URL
        /// </summary>
        /// <param name="URL">The URL for the image</param>
        /// <returns>Image (id, Key, URL)</returns>
        public Image UploadImageFromURL(string URL)
        {
            return UploadImageFromURLAsync(URL).Result;
        }
        /// <summary>
        /// Uploads an image from a URL to an album - Image with id, Key and URL
        /// </summary>
        /// <param name="URL">The URL for the image</param>
        /// <param name="Altitude">The altitude at which the image (or video) was taken</param>
        /// <param name="ByteCount">The size of the image (or video) in bytes</param>
        /// <param name="Caption">The caption for the image (or video)</param>
        /// <param name="Filename">The filename of the image (or video)</param>
        /// <param name="Keywords">The keyword string for the image (or video)</param>
        /// <param name="Latitude">The latitude at which the image (or video) was taken</param>
        /// <param name="Longitude">The longitude at which the image (or video) was taken</param>
        /// <param name="MD5Sum">The MD5 sum for the image (or video)</param>
        /// <returns>Image (id, Key, URL)</returns>
        public Image UploadImageFromURL(string URL, int Altitude, int ByteCount, string Caption, string Filename, string Keywords, float Latitude, float Longitude, string MD5Sum)
        {
            return UploadImageFromURL(URL, Altitude, ByteCount, Caption, Filename, Keywords, Latitude, Longitude, MD5Sum, "");
        }

        /// <summary>
        /// Uploads an image from a URL to an album - Image with id, Key and URL
        /// </summary>
        /// <param name="URL">The URL for the image</param>
        /// <param name="Altitude">The altitude at which the image (or video) was taken</param>
        /// <param name="ByteCount">The size of the image (or video) in bytes</param>
        /// <param name="Caption">The caption for the image (or video)</param>
        /// <param name="Filename">The filename of the image (or video)</param>
        /// <param name="Keywords">The keyword string for the image (or video)</param>
        /// <param name="Latitude">The latitude at which the image (or video) was taken</param>
        /// <param name="Longitude">The longitude at which the image (or video) was taken</param>
        /// <param name="MD5Sum">The MD5 sum for the image (or video)</param>
        /// <param name="Extras">A comma seperated string of additional attributes to return in the response.</param>
        /// <returns>Image (id, Key, URL)</returns>
        public Image UploadImageFromURL(string URL, int Altitude, int ByteCount, string Caption, string Filename, string Keywords, float Latitude, float Longitude, string MD5Sum, string Extras)
        {
            return UploadImageFromURLAsync(URL, Altitude, ByteCount, Caption, Filename, Keywords, Latitude, Longitude, MD5Sum, Extras).Result;
        }


        /// <summary>
        /// Retrieves a list of images for a given album (standard response) - Album with id, Key, ImageCount, and Image array with id and Key
        /// </summary>
        /// <returns>List of Images (id and Key)</returns>
        public List<Image> GetImages()
        {
            return GetImages(false, "", false, 0, false, "");
        }

        /// <summary>
        /// Retrieves a list of images for a given album (Album with id, Key, ImageCount, and Image array with id, Key, Altitude, Caption, Date, FileName, Duration, Format, Heaight, Hidden, Keywords, LargeURL, LastUpdated, Latitude, Longitude, MD5Sum, MediumURL, OriginalURL, Position, Serial, Size, SmallURL, ThumbURL, TinyURL, Video320URL, Video640URL, Video960URL, Video1280URL, Video1920URL, Width, X2LardeURL, X3LargeURL, XLargeURL)
        /// </summary>
        /// <param name="Heavy">If true, returns a heavy response</param>
        /// <returns></returns>
        public List<Image> GetImages(bool Heavy)
        {
            return GetImages(false, "", Heavy, 0, false, "");
        }

        /// <summary>
        /// Retrieves a list of images for a given album (Album with id, Key, ImageCount, and Image array with id, Key, Altitude, Caption, Date, FileName, Duration, Format, Heaight, Hidden, Keywords, LargeURL, LastUpdated, Latitude, Longitude, MD5Sum, MediumURL, OriginalURL, Position, Serial, Size, SmallURL, ThumbURL, TinyURL, Video320URL, Video640URL, Video960URL, Video1280URL, Video1920URL, Width, X2LardeURL, X3LargeURL, XLargeURL)
        /// </summary>
        /// <param name="Associative">boolean, returns an associative array. Default: false</param>
        /// <param name="Extras">A comma seperated string of additional attributes to return in the response.</param>
        /// <param name="Heavy">heavy response. Default : false</param>
        /// <param name="LastUpdated">Return results where LastUpdated is after the epoch time provided</param>
        /// <param name="Sandboxed">Forces URLs to a location with a crossdomain.xml file. Default: false  </param>
        /// <param name="SitePassword">The site password for a specific user</param>
        /// <returns>List of Images</returns>
        public List<Image> GetImages(bool Associative, string Extras, bool Heavy, int LastUpdated, bool Sandboxed, string SitePassword)
        {
            return GetImagesAsync(Associative, Extras, Heavy, LastUpdated, Sandboxed, SitePassword).Result;
        }


        /// <summary>
        /// Retrieves a list of comments for an album
        /// </summary>
        public void GetComments()
        {
            GetComments("");
        }

        /// <summary>
        /// Retrieves a list of comments for an album
        /// </summary>
        /// <param name="SitePassword">The site password for a specific user</param>
        public void GetComments(string SitePassword)
        {
            GetComments(false, 0, SitePassword);
        }

        /// <summary>
        /// Retrieves a list of comments for an album
        /// </summary>
        /// <param name="Associative">Returns an associative array</param>
        /// <param name="LastUpdated">Return results where LastUpdated is after the epoch time provided</param>
        /// <param name="SitePassword">The site password for a specific user</param>
        public void GetComments(bool Associative, int LastUpdated, string SitePassword)
        {
            GetCommentsAsync(Associative, LastUpdated, SitePassword).Wait();
        }

        /// <summary>
        /// Add a comment to an album
        /// </summary>
        /// <param name="Text">The text for the comment</param>
        /// <returns></returns>
        public Comment AddComment(string Text)
        {
            return AddComment(Text, 0, "");
        }

        /// <summary>
        /// Add a comment to an album
        /// </summary>
        /// <param name="Text">The text for the comment</param>
        /// <param name="Rating">The rating for this comment. Values:  0 - No Rating (Default), 1 - 1 Star Rating, 2 - 2 Star Rating, 3 - 3 Star Rating, 4 - 4 Star Rating, 5 - 5 Star Rating</param>
        /// <returns></returns>
        public Comment AddComment(string Text, int Rating)
        {
            return AddComment(Text, Rating, "");
        }

        /// <summary>
        /// Add a comment to an album
        /// </summary>
        /// <param name="Text">The text for the comment</param>
        /// <param name="Rating">The rating for this comment. Values:  0 - No Rating (Default), 1 - 1 Star Rating, 2 - 2 Star Rating, 3 - 3 Star Rating, 4 - 4 Star Rating, 5 - 5 Star Rating</param>
        /// <param name="Extras">A comma separated string of additional attributes to return in the response</param>
        /// <returns></returns>
        public Comment AddComment(string Text, int Rating, string Extras)
        {
            return AddCommentAsync(Text, Rating, Extras).Result;
        }
        #endregion

        #region Async
        /// <summary>
        /// Creates a new album with the specified parameters - Title [required], AlbumTemplateID, Backprinting (pro only), CanRank, CategoryID, Clean, ColorCorrection, Comments, CommunityID, DefaultColor (pro only), Description, EXIF, External, FamilyEdit, FriendEdit, Geography, Header (power, pro only), HideOwner, HighlightID, Keywords, Larges (pro only), Originals, Password, PasswordHint, Position, Printable, ProofDays (pro only), Protected (power, pro only), Public, Share, SmumugSearchable, SortDirection, SortMethod, SquareThumbs, SubCategoryID, TemplateID, ThemeID, Unique, UnsharpAmount (power, pro only), UnsharpRadius (power, pro only), UnsharpSigma (power, pro only), UnsharpThreshold (power, pro only), WatermarkID (pro only), Watermarking (pro only), WorldSearchable, X2Larges, X3Larges, XLarges (pro only)
        /// </summary>
        /// <returns>Album (id and Key)</returns>
        internal async Task<Album> CreateAsync()
        {
            return await CreateAsync(false, "");
        }

        /// <summary>
        /// Creates a new album with the specified parameters - Title [required], AlbumTemplateID, Backprinting (pro only), BoutiquePackaging (pro only), CanRank, CategoryID, Clean, ColorCorrection, Comments, CommunityID, DefaultColor (pro only), Description, EXIF, External, FamilyEdit, FriendEdit, Geography, Header (power&pro only), HideOwner, InterceptShipping, Keywords, Larges (pro only), Originals, PackagingBranding (pro only), Password, PasswordHint, Position, Printable, PrintMarkID (pro only), ProofDays (pro only), Protected (power&pro only), Public, Share, SmumugSearchable, SortDirection, SortMethod, SquareThumbs, SubCategoryID, TemplateID, ThemeID, Unique, UnsharpAmount (power&pro only), UnsharpRadius (power&pro only), UnsharpSigma (power&pro only), UnsharpThreshold (power&pro only), WatermarkID (pro only), Watermarking (pro only), WorldSearchable, X2Larges, X3Larges, XLarges (pro only)
        /// </summary>
        /// <param name="Unique">Create an album if one of the same name doesn't already exist in the current hierarchy. Default: false.</param>
        /// <param name="Extras">A comma seperated string of additional attributes to return in the response.</param>
        /// <returns>Album (id and Key)</returns>
        internal async Task<Album> CreateAsync(bool Unique, string Extras)
        {
            CommunicationHelper ch = new CommunicationHelper();
            // SessionID [required], Title [required], Callback, Pretty, Strict, AlbumTemplateID, Backprinting (pro only), BoutiquePackaging (pro only), CanRank, 
            // CategoryID, Clean, ColorCorrection, Comments, CommunityID, DefaultColor (pro only), Description, EXIF, External, FamilyEdit, FriendEdit, 
            // Geography, Header (power&pro only), HideOwner, InterceptShipping, Keywords, Larges (pro only), Originals, PackagingBranding (pro only), Password, 
            // PasswordHint, Position, Printable, PrintMarkID (pro only), ProofDays (pro only), Protected (power&pro only), Public, Share, SmumugSearchable, 
            // SortDirection, SortMethod, SquareThumbs, SubCategoryID, TemplateID, ThemeID, Unique, UnsharpAmount (power&pro only), UnsharpRadius (power&pro only),
            // UnsharpSigma (power&pro only), UnsharpThreshold (power&pro only), WatermarkID (pro only), Watermarking (pro only), WorldSearchable,
            // X2Larges, X3Larges, XLarges (pro only)
            this.Unique = Unique;
            // Hack: The class has 2 properties with the same name - Comments. I've separated them in 2 different properties (HasComments and CommentsList)
            var ls = BuildPropertiesValueList(this, "Category", "SubCategory", "HasComments", "CommentsList", "Comments");
            ls.Add("Comments"); ls.Add("false");
            ls.Add("Extras"); ls.Add(Extras);
            if (this.Category != null)
            {
                ls.Add("CategoryID"); ls.Add(this.Category.id.ToString());
            }
            if (this.SubCategory != null)
            {
                ls.Add("SubCategoryID"); ls.Add(this.SubCategory.id.ToString());
            }
            var resp = await ch.ExecuteMethod<AlbumResponse>("smugmug.albums.create", basic, ls.ToArray());
            if (resp.stat == "ok")
            {
                var temp = resp.Album;
                temp.basic = basic;
                temp.Title = this.Title;
                if (this.SubCategory != null)
                {
                    temp.SubCategory = this.SubCategory;
                    temp.Category = this.Category;
                    if (this.SubCategory.Albums == null)
                        this.SubCategory.Albums = new List<Album>();
                    this.SubCategory.Albums.Add(temp);
                }
                else
                {
                    if (this.Category != null)
                    {
                        temp.Category = this.Category;
                        if (this.Category.Albums == null)
                            this.Category.Albums = new List<Album>();
                        this.Category.Albums.Add(temp);
                    }
                }
                return temp;
            }
            else
            {
                Console.WriteLine(resp.message);
                throw new SmugMugException(resp.code, resp.message, resp.method);
            }
        }

        /// <summary>
        /// Change the settings of an existing album - AlbumTemplateID, Backprinting (pro), BoutiquePackaging (pro), CanRank, CategoryID, Clean, ColorCorrection, Comments, CommunityID, DefaultColor  (pro), Description, EXIF, External, FamilyEdit, FriendEdit, Geography, Header (power, pro), HideOwner, HighlightID, Keywords, Larges, NiceName, Originals, PackagingBranding (pro), Password, PasswordHint, Position, Printable, PrintmarkID (pro), ProofDays, Protected (power, pro), Public, Share, SmumugSearchable, SortDirection, SortMethod, SquareThumbs, SubCategoryID, TemplateID, ThemeID, UnsharpAmount (power, pro), UnsharpRadius (power, pro), UnsharpSigma (power, pro), UnsharpThreshold (power, pro), WatermarkID (pro), Watermarking (pro), WorldSearchable, X2Larges, X3Larges, XLarges (pro)
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public async Task<bool> ChangeSettingsAsync()
        {
            CommunicationHelper ch = new CommunicationHelper();
            // SessionID [required], AlbumID [required], Callback, Pretty, Strict, AlbumTemplateID, Backprinting (pro), BoutiquePackaging, CanRank, 
            // CategoryID, Clean, ColorCorrection, Comments, CommunityID, DefaultColor  (pro), Description, EXIF, External, FamilyEdit, 
            // FriendEdit, Geography, Header (power&pro), HideOwner, HighlightID, Keywords, Larges, NiceName, Originals, PackagingBranding, Password, 
            // PasswordHint, Position, Printable, PrintmarkID, ProofDays, Protected (power&pro), Public, Share, SmumugSearchable, SortDirection, 
            // SortMethod, SquareThumbs, SubCategoryID, TemplateID, ThemeID, UnsharpAmount (power&pro), UnsharpRadius (power&pro), UnsharpSigma (power&pro), 
            // UnsharpThreshold (power&pro), WatermarkID (pro), Watermarking (pro), WorldSearchable, X2Larges, X3Larges, XLarges (pro)            // Hack: The class has 2 properties with the same name - Comments. I've separated them in 2 different properties (HasComments and CommentsList)
            var ls = BuildPropertiesValueList(this, "HasComments", "CommentsList", "Comments", "Watermark");
            ls.Add("Comments"); ls.Add(this.HasComments.ToString());
            ls.Add("AlbumID"); ls.Add(this.id.ToString());

            //If we have a watermark we add the id.
            if (this.Watermark != null)
            {
                ls.Add("Watermark");
                ls.Add(this.Watermark.id.ToString());
            }
            var resp = await ch.ExecuteMethod<AlbumResponse>("smugmug.albums.changeSettings", basic, ls.ToArray());
            if (resp.stat == "ok")
                return true;
            else
            {
                Console.WriteLine(resp.message);
                throw new SmugMugException(resp.code, resp.message, resp.method);
            }
        }

        /// <summary>
        /// This method will re-sort all the photos inside of the album specified by AlbumID. Note that this is a one-time event, and doesn't apply directly to images added in the future by other means.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public async Task<bool> ReSortAsync(By b, Direction d)
        {
            CommunicationHelper ch = new CommunicationHelper();
            // SessionID [required], AlbumID [required], By [required], Direction [required], Callback, Pretty, Strict
            var resp = await ch.ExecuteMethod<SmugMugResponse>("smugmug.albums.reSort", basic, "AlbumID", id, "By", b.ToString(), "Direction", d.ToString());
            if (resp.stat == "ok")
                return true;
            else
            {
                Console.WriteLine(resp.message);
                throw new SmugMugException(resp.code, resp.message, resp.method);
            }
        }

        /// <summary>
        /// Retrieves the details for a specified album (id, Key, Backprinting, CanRank, CategoryID and Name, Clean, ColorCorrection, Comments, CommunityID and Name, Description, EXIF, External, FamilyEdit, FriendEdit, Geography, Header, HideOwner, HighlightID and Key, ImageCount, Larges, LastUpdated, NiceName, Originals, Password, PasswordHint, Position, Printable, ProofDays, Protected, Public, Share, SmumugSearchable, SortDirection, SortMethod, SquareThumbs, SubCategoryID and Name, TemplateID, ThemeID and Name and Type, Title, Unique, UnsharpAmount, UnsharpRadius, UnsharpSigma, UnsharpThreshold, WatermarkID and Name, Watermarking, WorldSearchable, X2Larges, X3Larges, XLarges)
        /// </summary>
        /// <returns>Album</returns>
        public async Task<Album> GetInfoAsync()
        {
            return await GetInfoAsync("");
        }

        /// <summary>
        /// Retrieves the details for a specified album (id, Key, Backprinting, CanRank, CategoryID and Name, Clean, ColorCorrection, Comments, CommunityID and Name, Description, EXIF, External, FamilyEdit, FriendEdit, Geography, Header, HideOwner, HighlightID and Key, ImageCount, Larges, LastUpdated, NiceName, Originals, Password, PasswordHint, Position, Printable, ProofDays, Protected, Public, Share, SmumugSearchable, SortDirection, SortMethod, SquareThumbs, SubCategoryID and Name, TemplateID, ThemeID and Name and Type, Title, Unique, UnsharpAmount, UnsharpRadius, UnsharpSigma, UnsharpThreshold, WatermarkID and Name, Watermarking, WorldSearchable, X2Larges, X3Larges, XLarges)
        /// </summary>
        /// <param name="SitePassword">The site password for a specific user</param>
        /// <returns></returns>
        public async Task<Album> GetInfoAsync(string SitePassword)
        {
            CommunicationHelper ch = new CommunicationHelper();
            // SessionID [required], AlbumID [required], AlbumKey [required], Callback, Password, Pretty, SitePassword, Strict
            AlbumResponse resp = new AlbumResponse();
            if (!String.IsNullOrEmpty(this.Password))
                resp = await ch.ExecuteMethod<AlbumResponse>("smugmug.albums.getInfo", basic, "AlbumID", id, "AlbumKey", Key, "SitePassword", SitePassword, "Password", Password);
            else
                resp = await ch.ExecuteMethod<AlbumResponse>("smugmug.albums.getInfo", basic, "AlbumID", id, "AlbumKey", Key, "SitePassword", SitePassword);
            if (resp.stat == "ok")
            {
                var myAlbum = resp.Album;
                myAlbum.basic = basic;
                //Hack: The class has 2 properties with the same name - Comments. I've separated them in 2 different properties (HasComments and CommentsList)
                if (myAlbum.Comments != null)
                    myAlbum.HasComments = (bool)myAlbum.Comments;
                return myAlbum;
            }
            else
            {
                Console.WriteLine(resp.message);
                throw new SmugMugException(resp.code, resp.message, resp.method);
            }
        }

        /// <summary>
        /// Populate the current album with info from the site (id, Key, Backprinting, CanRank, CategoryID and Name, Clean, ColorCorrection, Comments, CommunityID and Name, Description, EXIF, External, FamilyEdit, FriendEdit, Geography, Header, HideOwner, HighlightID and Key, ImageCoutn, Larges, Originals, Password, PasswordHint, Position, Printable, ProofDays, Protected, Public, Share, SmumugSearchable, SortDirection, SortMethod, SquareThumbs, SubCategoryID and Name, TemplateID, ThemeID and Name and Type, Title, Unique, UnsharpAmount, UnsharpRadius, UnsharpSigma, UnsharpThreshold, WatermarkID and Name, Watermarking, WorldSearchable, X2Larges, X3Larges, XLarges)
        /// </summary>
        public async Task PopulateAlbumWithInfoFromSiteAsync()
        {
            await PopulateAlbumWithInfoFromSiteAsync("");
        }

        /// <summary>
        /// Populate the current album with info from the site (id, Key, Backprinting, CanRank, CategoryID and Name, Clean, ColorCorrection, Comments, CommunityID and Name, Description, EXIF, External, FamilyEdit, FriendEdit, Geography, Header, HideOwner, HighlightID and Key, ImageCoutn, Larges, Originals, Password, PasswordHint, Position, Printable, ProofDays, Protected, Public, Share, SmumugSearchable, SortDirection, SortMethod, SquareThumbs, SubCategoryID and Name, TemplateID, ThemeID and Name and Type, Title, Unique, UnsharpAmount, UnsharpRadius, UnsharpSigma, UnsharpThreshold, WatermarkID and Name, Watermarking, WorldSearchable, X2Larges, X3Larges, XLarges)
        /// </summary>
        public async Task PopulateAlbumWithInfoFromSiteAsync(string SitePassword)
        {
            CommunicationHelper ch = new CommunicationHelper();
            // SessionID [required], AlbumID [required], AlbumKey [required], Callback, Password, Pretty, SitePassword, Strict
            AlbumResponse resp = new AlbumResponse();
            if (!String.IsNullOrEmpty(this.Password))
                resp = await ch.ExecuteMethod<AlbumResponse>("smugmug.albums.getInfo", basic, "AlbumID", id, "AlbumKey", Key, "SitePassword", SitePassword, "Password", Password);
            else
                resp = await ch.ExecuteMethod<AlbumResponse>("smugmug.albums.getInfo", basic, "AlbumID", id, "AlbumKey", Key, "SitePassword", SitePassword);
            if (resp.stat == "ok")
            {
                PopulateWithResponse(resp.Album, this, "HasComments", "CommentsList", "Comments");
                //Hack: The class has 2 properties with the same name - Comments. I've separated them in 2 different properties (HasComments and CommentsList)
                if (resp.Album.Comments != null)
                    this.HasComments = (bool)resp.Album.Comments;
            }
            else
            {
                Console.WriteLine(resp.message);
                throw new SmugMugException(resp.code, resp.message, resp.method);
            }
        }

        /// <summary>
        /// Deletes an existing album
        /// </summary>
        /// <returns></returns>
        public async Task<bool> DeleteAsync()
        {
            CommunicationHelper ch = new CommunicationHelper();
            // SessionID [required], AlbumID [required], Callback, Pretty, Strict
            var resp = await ch.ExecuteMethod<SmugMugResponse>("smugmug.albums.delete", basic, "AlbumID", id);
            if (resp.stat == "ok")
                return true;
            else
            {
                Console.WriteLine(resp.message);
                throw new SmugMugException(resp.code, resp.message, resp.method);
            }
        }

        /// <summary>
        /// Gets the standard transfer statistics for the given Album during the given Month and Year (id, Key, Bytes, Hits, Large, Medium, original, Small, Thumb, Tiny, X2Large, X3Large, XLarge, Video320, Video640, Video960, Video1280, Video1960). SmugMug only keeps the last few months of traffic on file, so requesting farther back then 2 months may not return valid results. A float is provided for Original and video sizes because it's possible to watch only a portion of a video
        /// </summary>
        /// <param name="Month"></param>
        /// <param name="Year"></param>
        /// <returns>Album</returns>
        public async Task<Album> GetStatsAsync(int Month, int Year)
        {
            return await GetStatsAsync(Month, Year, false);
        }

        /// <summary>
        /// Gets the extended transfer statistics for the given Album and all its images during the given Month and Year (id, Key, Bytes, Hits, Large, Medium, original, Small, Thumb, Tiny, X2Large, X3Large, XLarge, Video320, Video640, Video960, Video1280, Video1960, Images array with the same kind of stats). SmugMug only keeps the last few months of traffic on file, so requesting farther back then 2 months may not return valid results. A float is provided for Original and video sizes because it's possible to watch only a portion of a video
        /// </summary>
        /// <param name="Month"></param>
        /// <param name="Year"></param>
        /// <param name="Heavy">If Heavy is set to "1", transfer statistics for each image in each album will be returned as well</param>
        /// <returns></returns>
        public async Task<Album> GetStatsAsync(int Month, int Year, bool Heavy)
        {
            CommunicationHelper ch = new CommunicationHelper();
            // SessionID [required], AlbumID [required], Month [required], Year [required], Associative, Callback, Heavy, Pretty, Strict
            var resp = await ch.ExecuteMethod<AlbumResponse>("smugmug.albums.getStats", basic, "AlbumID", id, "Month", Month, "Year", Year, "Heavy", Heavy);
            if (resp.stat == "ok")
            {
                var myAlbum = resp.Album;
                myAlbum.basic = basic;
                //Hack: The class has 2 properties with the same name - Comments. I've separated them in 2 different properties (HasComments and CommentsList)
                if (myAlbum.Comments != null)
                    myAlbum.HasComments = (bool)myAlbum.Comments;
                return myAlbum;
            }
            else
            {
                Console.WriteLine(resp.message);
                throw new SmugMugException(resp.code, resp.message, resp.method);
            }
        }

        /// <summary>
        /// Populate the current album with standard transfer statistics during the given Month and Year (id, Key, Bytes, Hits, Large, Medium, original, Small, Thumb, Tiny, X2Large, X3Large, XLarge, Video320, Video640, Video960, Video1280, Video1960). SmugMug only keeps the last few months of traffic on file, so requesting farther back then 2 months may not return valid results. A float is provided for Original and video sizes because it's possible to watch only a portion of a video
        /// </summary>
        /// <param name="Month"></param>
        /// <param name="Year"></param>
        /// <returns></returns>
        public async Task PopulateAlbumWithStatsFromSiteAsync(int Month, int Year)
        {
            await PopulateAlbumWithStatsFromSiteAsync(Month, Year, false);
        }

        /// <summary>
        /// Populate the current album and its images with transfer statistics during the given Month and Year (id, Key, Bytes, Hits, Large, Medium, original, Small, Thumb, Tiny, X2Large, X3Large, XLarge, Video320, Video640, Video960, Video1280, Video1960). SmugMug only keeps the last few months of traffic on file, so requesting farther back then 2 months may not return valid results. A float is provided for Original and video sizes because it's possible to watch only a portion of a video
        /// </summary>
        /// <param name="Month"></param>
        /// <param name="Year"></param>
        /// <param name="Heavy">If Heavy is set to "1", transfer statistics for each image in each album will be returned as well</param>
        /// <returns></returns>
        public async Task PopulateAlbumWithStatsFromSiteAsync(int Month, int Year, bool Heavy)
        {
            CommunicationHelper ch = new CommunicationHelper();
            var resp = await ch.ExecuteMethod<AlbumResponse>("smugmug.albums.getStats", basic, "AlbumID", id, "Month", Month, "Year", Year, "Heavy", Heavy);
            if (resp.stat == "ok")
            {
                PopulateWithResponse(resp.Album, this, "HasComments", "CommentsList", "Comments");
                //Hack: The class has 2 properties with the same name - Comments. I've separated them in 2 different properties (HasComments and CommentsList)
                if (resp.Album.Comments != null)
                    this.HasComments = (bool)resp.Album.Comments;
            }
            else
            {
                Console.WriteLine(resp.message);
                throw new SmugMugException(resp.code, resp.message, resp.method);
            }
        }




        /// <summary>
        /// Applies a watermark to the images of an album
        /// </summary>
        /// <param name="w">The id for a specific watermark</param>
        /// <returns></returns>
        public async Task<bool> ApplyWatermarkAsync(Watermark w)
        {
            CommunicationHelper ch = new CommunicationHelper();
            // SessionID [required], AlbumID [required], WatermarkID [required], Callback, Pretty, Strict
            var resp = await ch.ExecuteMethod<SmugMugResponse>("smugmug.albums.applyWatermark", basic, "AlbumID", id, "WatermarkID", w.id);
            if (resp.stat == "ok")
                return true;
            else
            {
                Console.WriteLine(resp.message);
                throw new SmugMugException(resp.code, resp.message, resp.method);
            }
        }

        /// <summary>
        /// Removes a watermark from the images of an album
        /// </summary>
        /// <returns></returns>
        public async Task<bool> RemoveWatermarkAsync()
        {
            CommunicationHelper ch = new CommunicationHelper();
            // SessionID [required], AlbumID [required], Callback, Pretty, Strict
            var resp = await ch.ExecuteMethod<SmugMugResponse>("smugmug.albums.removeWatermark", basic, "AlbumID", id);
            if (resp.stat == "ok")
                return true;
            else
            {
                Console.WriteLine(resp.message);
                throw new SmugMugException(resp.code, resp.message, resp.method);
            }
        }


        /// <summary>
        /// Uploads an image from a URL to an album - Image with id, Key and URL
        /// </summary>
        /// <param name="URL">The URL for the image</param>
        /// <returns>Image (id, Key, URL)</returns>
        public async Task<Image> UploadImageFromURLAsync(string URL)
        {
            CommunicationHelper ch = new CommunicationHelper();
            // SessionID [required], AlbumID [required], URL [required], Altitude, ByteCount, Caption, Filename, Keywords, Latitude, Longitude, MD5Sum, Callback, Pretty, Strict
            var resp = await ch.ExecuteMethod<ImageResponse>("smugmug.images.uploadFromURL", basic, "AlbumID", id, "URL", URL);
            if (resp.stat == "ok")
            {
                var temp = new Image();
                temp.basic = basic;
                return temp;
            }
            else
            {
                Console.WriteLine(resp.message);
                throw new SmugMugException(resp.code, resp.message, resp.method);
            }
        }
        /// <summary>
        /// Uploads an image from a URL to an album - Image with id, Key and URL
        /// </summary>
        /// <param name="URL">The URL for the image</param>
        /// <param name="Altitude">The altitude at which the image (or video) was taken</param>
        /// <param name="ByteCount">The size of the image (or video) in bytes</param>
        /// <param name="Caption">The caption for the image (or video)</param>
        /// <param name="Filename">The filename of the image (or video)</param>
        /// <param name="Keywords">The keyword string for the image (or video)</param>
        /// <param name="Latitude">The latitude at which the image (or video) was taken</param>
        /// <param name="Longitude">The longitude at which the image (or video) was taken</param>
        /// <param name="MD5Sum">The MD5 sum for the image (or video)</param>
        /// <returns>Image (id, Key, URL)</returns>
        public async Task<Image> UploadImageFromURLAsync(string URL, int Altitude, int ByteCount, string Caption, string Filename, string Keywords, float Latitude, float Longitude, string MD5Sum)
        {
            return await UploadImageFromURLAsync(URL, Altitude, ByteCount, Caption, Filename, Keywords, Latitude, Longitude, MD5Sum, "");
        }

        /// <summary>
        /// Uploads an image from a URL to an album - Image with id, Key and URL
        /// </summary>
        /// <param name="URL">The URL for the image</param>
        /// <param name="Altitude">The altitude at which the image (or video) was taken</param>
        /// <param name="ByteCount">The size of the image (or video) in bytes</param>
        /// <param name="Caption">The caption for the image (or video)</param>
        /// <param name="Filename">The filename of the image (or video)</param>
        /// <param name="Keywords">The keyword string for the image (or video)</param>
        /// <param name="Latitude">The latitude at which the image (or video) was taken</param>
        /// <param name="Longitude">The longitude at which the image (or video) was taken</param>
        /// <param name="MD5Sum">The MD5 sum for the image (or video)</param>
        /// <param name="Extras">A comma seperated string of additional attributes to return in the response.</param>
        /// <returns>Image (id, Key, URL)</returns>
        public async Task<Image> UploadImageFromURLAsync(string URL, int Altitude, int ByteCount, string Caption, string Filename, string Keywords, float Latitude, float Longitude, string MD5Sum, string Extras)
        {
            CommunicationHelper ch = new CommunicationHelper();
            // SessionID [required], AlbumID [required], URL [required], Altitude, ByteCount, Caption, Filename, Keywords, Latitude, Longitude, MD5Sum, Callback, Pretty, Strict
            var resp = await ch.ExecuteMethod<ImageResponse>("smugmug.images.uploadFromURL", basic, "AlbumID", id, "URL", URL, "Altitude", Altitude, "ByteCount", ByteCount, "Caption", Caption, "Filename", Filename, "Keywords", Keywords, "Latitude", Latitude, "Longitude", Longitude, "MD5Sum", MD5Sum, "Extras", Extras);
            if (resp.stat == "ok")
            {
                var temp = new Image();
                temp.basic = basic;
                return temp;
            }
            else
            {
                Console.WriteLine(resp.message);
                throw new SmugMugException(resp.code, resp.message, resp.method);
            }
        }


        /// <summary>
        /// Retrieves a list of images for a given album (standard response) - Album with id, Key, ImageCount, and Image array with id and Key
        /// </summary>
        /// <returns>List of Images (id and Key)</returns>
        public async Task<List<Image>> GetImagesAsync()
        {
            return await GetImagesAsync(false, "", false, 0, false, "");
        }

        /// <summary>
        /// Retrieves a list of images for a given album (Album with id, Key, ImageCount, and Image array with id, Key, Altitude, Caption, Date, FileName, Duration, Format, Heaight, Hidden, Keywords, LargeURL, LastUpdated, Latitude, Longitude, MD5Sum, MediumURL, OriginalURL, Position, Serial, Size, SmallURL, ThumbURL, TinyURL, Video320URL, Video640URL, Video960URL, Video1280URL, Video1920URL, Width, X2LardeURL, X3LargeURL, XLargeURL)
        /// </summary>
        /// <param name="Heavy">If true, returns a heavy response</param>
        /// <returns></returns>
        public async Task<List<Image>> GetImagesAsync(bool Heavy)
        {
            return await GetImagesAsync(false, "", Heavy, 0, false, "");
        }

        /// <summary>
        /// Retrieves a list of images for a given album (Album with id, Key, ImageCount, and Image array with id, Key, Altitude, Caption, Date, FileName, Duration, Format, Heaight, Hidden, Keywords, LargeURL, LastUpdated, Latitude, Longitude, MD5Sum, MediumURL, OriginalURL, Position, Serial, Size, SmallURL, ThumbURL, TinyURL, Video320URL, Video640URL, Video960URL, Video1280URL, Video1920URL, Width, X2LardeURL, X3LargeURL, XLargeURL)
        /// </summary>
        /// <param name="Associative">boolean, returns an associative array. Default: false</param>
        /// <param name="Extras">A comma seperated string of additional attributes to return in the response.</param>
        /// <param name="Heavy">heavy response. Default : false</param>
        /// <param name="LastUpdated">Return results where LastUpdated is after the epoch time provided</param>
        /// <param name="Sandboxed">Forces URLs to a location with a crossdomain.xml file. Default: false  </param>
        /// <param name="SitePassword">The site password for a specific user</param>
        /// <returns>List of Images</returns>
        public async Task<List<Image>> GetImagesAsync(bool Associative, string Extras, bool Heavy, int LastUpdated, bool Sandboxed, string SitePassword)
        {
            CommunicationHelper ch = new CommunicationHelper();
            // SessionID [required], AlbumID [required], AlbumKey [required], Callback, Extras, Heavy, LastUpdated, Password, Pretty, Sandboxed (boolean. Forces URLs to a location with a crossdomain.xml file. Default: false), SitePassword, Strict
            ImageResponse resp = new ImageResponse();
            if ((Password != null) && (Password != String.Empty))
                resp = await ch.ExecuteMethod<ImageResponse>("smugmug.images.get", basic, "AlbumID", id, "AlbumKey", Key, "Associative", Associative, "Extras", Extras, "Heavy", Heavy, "LastUpdated", LastUpdated, "Sandboxed", Sandboxed, "SitePassword", SitePassword, "Password", Password);
            else
                resp = await ch.ExecuteMethod<ImageResponse>("smugmug.images.get", basic, "AlbumID", id, "AlbumKey", Key, "Associative", Associative, "Extras", Extras, "Heavy", Heavy, "LastUpdated", LastUpdated, "Sandboxed", Sandboxed, "SitePassword", SitePassword);

            if (resp.stat == "ok")
            {
                var imageList = new List<Image>();
                imageList.AddRange(resp.Album.Images);
                this.ImageCount = resp.Album.ImageCount;
                if (imageList != null)
                {
                    foreach (var item in imageList)
                    {
                        item.basic = basic;
                        item.Album = this;
                    }
                }
                return imageList;
            }
            else
            {
                Console.WriteLine(resp.message);
                throw new SmugMugException(resp.code, resp.message, resp.method);
            }
        }


        /// <summary>
        /// Retrieves a list of comments for an album
        /// </summary>
        public async Task GetCommentsAsync()
        {
            await GetCommentsAsync("");
        }

        /// <summary>
        /// Retrieves a list of comments for an album
        /// </summary>
        /// <param name="SitePassword">The site password for a specific user</param>
        public async Task GetCommentsAsync(string SitePassword)
        {
            await GetCommentsAsync(false, 0, SitePassword);
        }

        /// <summary>
        /// Retrieves a list of comments for an album
        /// </summary>
        /// <param name="Associative">Returns an associative array</param>
        /// <param name="LastUpdated">Return results where LastUpdated is after the epoch time provided</param>
        /// <param name="SitePassword">The site password for a specific user</param>
        public async Task GetCommentsAsync(bool Associative, int LastUpdated, string SitePassword)
        {
            CommunicationHelper ch = new CommunicationHelper();
            // SessionID [required], AlbumID [required], Key [required], Password, Associative, Callback, LastUpdated, Pretty, SitePassword, Strict 
            AlbumResponseWithComments resp = new AlbumResponseWithComments();
            if ((this != null) && !(string.IsNullOrEmpty(this.Password)))
                resp = await ch.ExecuteMethod<AlbumResponseWithComments>("smugmug.albums.comments.get", basic, "AlbumID", id, "AlbumKey", Key, "SitePassword", SitePassword, "Password", Password, "LastUpdated", LastUpdated, "Associative", Associative);
            else
                resp = await ch.ExecuteMethod<AlbumResponseWithComments>("smugmug.albums.comments.get", basic, "AlbumID", id, "AlbumKey", Key, "SitePassword", SitePassword, "LastUpdated", LastUpdated, "Associative", Associative);
            if (resp.stat == "ok")
            {
                //Hack: The class has 2 properties with the same name - Comments. I've separated them in 2 different properties (HasComments and CommentsList)
                this.CommentsList = new List<Comment>(resp.Album.Comments);
            }
            else
            {
                Console.WriteLine(resp.message);
                throw new SmugMugException(resp.code, resp.message, resp.method);
            }
        }

        /// <summary>
        /// Add a comment to an album
        /// </summary>
        /// <param name="Text">The text for the comment</param>
        /// <returns></returns>
        public async Task<Comment> AddCommentAsync(string Text)
        {
            return await AddCommentAsync(Text, 0, "");
        }

        /// <summary>
        /// Add a comment to an album
        /// </summary>
        /// <param name="Text">The text for the comment</param>
        /// <param name="Rating">The rating for this comment. Values:  0 - No Rating (Default), 1 - 1 Star Rating, 2 - 2 Star Rating, 3 - 3 Star Rating, 4 - 4 Star Rating, 5 - 5 Star Rating</param>
        /// <returns></returns>
        public async Task<Comment> AddCommentAsync(string Text, int Rating)
        {
            return await AddCommentAsync(Text, Rating, "");
        }

        /// <summary>
        /// Add a comment to an album
        /// </summary>
        /// <param name="Text">The text for the comment</param>
        /// <param name="Rating">The rating for this comment. Values:  0 - No Rating (Default), 1 - 1 Star Rating, 2 - 2 Star Rating, 3 - 3 Star Rating, 4 - 4 Star Rating, 5 - 5 Star Rating</param>
        /// <param name="Extras">A comma separated string of additional attributes to return in the response</param>
        /// <returns></returns>
        public async Task<Comment> AddCommentAsync(string Text, int Rating, string Extras)
        {
            CommunicationHelper ch = new CommunicationHelper();
            // SessionID [required], AlbumID [required], AlbumKey [required], Text [required], Callback, Extras, Pretty, Rating, Strict
            var resp = await ch.ExecuteMethod<CommentResponse>("smugmug.albums.comments.add", basic, "AlbumID", id, "AlbumKey", Key, "Text", Text, "Rating", Rating, "Extras", Extras);
            if (resp.stat == "ok")
            {
                var myComment = resp.Comment;
                if (myComment != null)
                {
                    if (string.IsNullOrEmpty(myComment.Text))
                        myComment.Text = Text;
                    if (myComment.Rating == 0)
                        myComment.Rating = Rating;
                    //Hack: The class has 2 properties with the same name - Comments. I've separated them in 2 different properties (HasComments and CommentsList)
                    if (this.CommentsList == null)
                        this.CommentsList = new List<Comment>();
                    this.CommentsList.Add(myComment);
                }
                return myComment;
            }
            else
            {
                Console.WriteLine(resp.message);
                throw new SmugMugException(resp.code, resp.message, resp.method);
            }
        }
        #endregion


        /// <summary>
        /// This method will create an ImageUpload object that will be used to upload images to an album
        /// </summary>
        /// <param name="SessionID">The session ID to use when uploading</param>
        /// <param name="AlbumID">The album ID for which we are uploading the images</param>
        /// <returns>An ImageUpload object to use for uploading images</returns>
        public ImageUpload CreateUploader()
        {
            return new ImageUpload(basic, this);
        }
    }

    public class AlbumWithComments : AlbumBase
    {
        #region Properties
        /// <summary>
        /// Hack: The class has 2 properties with the same name - Comments. I've separated them in 2 different properties (HasComments and CommentsList)
        /// </summary>
        public Comment[] Comments;
        #endregion

        public override string ToString()
        {
            return Title;
        }
    }
}
