using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SmugMugModel
{
    public class Category : SmugMugObject
    {
        #region Properties
        /// <summary>
        /// The id for this category.
        /// </summary>
        public long id { get; set; }
        /// <summary>
        /// The name for this category
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Indicates if the category was created by SmugMug or by the user. Possible values: SmugMug or User 
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// The nicename for this category
        /// </summary>
        public string NiceName { get; set; }
        /// <summary>
        /// The Subcategories for this category
        /// </summary>
        public List<SubCategory> SubCategories { get; set; }
        /// <summary>
        /// The Albums contained by this category
        /// </summary>
        public List<Album> Albums { get; set; }
        #endregion

        public Category()
        {
            SubCategories = new List<SubCategory>();
            Albums = new List<Album>();
        }

        /// <summary>
        /// Override the ToString method to easily return the name of the category
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Name;
        }

        #region Sync
        /// <summary>
        /// Renames an existing category with the given name
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public bool Rename(string Name)
        {
            return Rename(Name, "");
        }

        /// <summary>
        /// Renames an existing category with the given name
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Extras">A comma seperated string of additional attributes to return in the response.</param>
        /// <returns></returns>
        public bool Rename(string Name, string Extras)
        {
            return RenameAsync(Name, Extras).Result;
        }


        /// <summary>
        /// Deletes an existing category
        /// </summary>
        /// <returns></returns>
        public bool Delete()
        {
            return DeleteAsync().Result;
        }



        /// <summary>
        /// Retrieves a list of subcategories within a specified category for a given user
        /// </summary>
        /// <returns>List of SubCategories (id, Name, NiceName)</returns>
        public List<SubCategory> GetSubCategories()
        {
            return GetSubCategories(false, "");
        }

        /// <summary>
        /// Retrieves a list of subcategories within a specified category for a given user
        /// </summary>
        /// <param name="SitePassword">The site password for a specific user</param>
        /// <returns>List of SubCategories (id, Name, NiceName)</returns>
        public List<SubCategory> GetSubCategories(string SitePassword)
        {
            return GetSubCategories(false, SitePassword);
        }

        /// <summary>
        /// Retrieves a list of subcategories within a specified category for a given user
        /// </summary>
        /// <param name="Associative">Returns an associative array.Default: false.</param>
        /// <param name="SitePassword">The site password for a specific user</param>
        /// <returns>List of SubCategories (id, Name, NiceName)</returns>
        public List<SubCategory> GetSubCategories(bool Associative, string SitePassword)
        {
            return GetSubCategoriesAsync(Associative, SitePassword).Result;
        }

        /// <summary>
        /// Given a certain name, it finds a subcategory or returns null
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public SubCategory FindSubCategory(string Name)
        {
            return FindSubCategoryAsync(Name).Result;
        }

        /// <summary>
        /// Creates a new subcategory with the given name for the specified category (also adds it as a subcategory to the current object)
        /// </summary>
        /// <param name="Name"></param>
        /// <returns>SubCategory (id)</returns>
        public SubCategory CreateSubCategory(string Name)
        {
            return CreateSubCategory(Name, true, "");
        }

        /// <summary>
        /// Creates a new subcategory with the given name for the specified category (also adds it as a subcategory to the current object)
        /// </summary>
        /// <param name="Name">The name for the subcategory</param>
        /// <param name="Extras">A comma seperated string of additional attributes to return in the response.</param>
        /// <returns>SubCategory (id)</returns>
        public SubCategory CreateSubCategory(string Name, string Extras)
        {
            return CreateSubCategory(Name, true, Extras);
        }

        /// <summary>
        /// Creates a new subcategory with the given name for the specified category (also adds it as a subcategory to the current object)
        /// </summary>
        /// <param name="Name">The name for the subcategory</param>
        /// <param name="Unique">Create a subcategory if one of the same name doesn't already exist in the current hierarchy. Default: false</param>
        /// <param name="Extras">A comma seperated string of additional attributes to return in the response.</param>
        /// <returns>SubCategory (id)</returns>
        public SubCategory CreateSubCategory(string Name, bool Unique, string Extras)
        {
            return CreateSubCategoryAsync(Name, Unique, Extras).Result;
        }



        /// <summary>
        /// Creates a new album with the specified title in the current category
        /// </summary>
        /// <param name="Title"></param>
        /// <returns>Album (id and Key)</returns>
        public Album CreateAlbum(string Title)
        {
            return CreateAlbum(Title, false);
        }

        /// <summary>
        /// Creates a new album with the specified title in the current category
        /// </summary>
        /// <param name="Title"></param>
        /// <param name="Unique">Create an album if one of the same name doesn't already exist in the current hierarchy.</param>
        /// <returns>Album (id and Key)</returns>
        public Album CreateAlbum(string Title, bool Unique)
        {
            return CreateAlbum(Title, Unique, string.Empty);
        }

        /// <summary>
        /// Creates a new album with the specified title in the current category
        /// </summary>
        /// <param name="Title"></param>
        /// <param name="Unique">Create an album if one of the same name doesn't already exist in the current hierarchy.</param>
        /// <param name="Extras">A comma seperated string of additional attributes to return in the response.</param>
        /// <returns>Album (id and Key)</returns>
        public Album CreateAlbum(string Title, bool Unique, string Extras)
        {
            Album a = new Album();
            a.Title = Title;
            a.basic = basic;
            a.Category = this;
            return a.CreateAsync(Unique, Extras).Result;
        }
        #endregion


        #region Async
        /// <summary>
        /// Renames an existing category with the given name
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public async Task<bool> RenameAsync(string Name)
        {
            return await RenameAsync(Name, "");
        }

        /// <summary>
        /// Renames an existing category with the given name
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Extras">A comma seperated string of additional attributes to return in the response.</param>
        /// <returns></returns>
        public async Task<bool> RenameAsync(string Name, string Extras)
        {
            CommunicationHelper ch = new CommunicationHelper();
            // SessionID [required], CategoryID [required], Callback, Extras, Pretty, Strict, Name
            var resp = await ch.ExecuteMethod<SmugMugResponse>("smugmug.categories.rename", basic, "CategoryID", id, "Name", Name, "Extras", Extras);
            if (resp.stat == "ok")
            {
                this.Name = Name;
                return true;
            }
            else
            {
                Console.WriteLine(resp.message);
                throw new SmugMugException(resp.code, resp.message, resp.method);
            }
        }


        /// <summary>
        /// Deletes an existing category
        /// </summary>
        /// <returns></returns>
        public async Task<bool> DeleteAsync()
        {
            CommunicationHelper ch = new CommunicationHelper();
            // SessionID [required], CategoryID [required], Callback, Pretty, Strict
            var resp = await ch.ExecuteMethod<SmugMugResponse>("smugmug.categories.delete", basic, "CategoryID", id);
            if (resp.stat == "ok")
                return true;
            else
            {
                Console.WriteLine(resp.message);
                throw new SmugMugException(resp.code, resp.message, resp.method);
            }
        }



        /// <summary>
        /// Retrieves a list of subcategories within a specified category for a given user
        /// </summary>
        /// <returns>List of SubCategories (id, Name, NiceName)</returns>
        public async Task<List<SubCategory>> GetSubCategoriesAsync()
        {
            return await GetSubCategoriesAsync(false, "");
        }

        /// <summary>
        /// Retrieves a list of subcategories within a specified category for a given user
        /// </summary>
        /// <param name="SitePassword">The site password for a specific user</param>
        /// <returns>List of SubCategories (id, Name, NiceName)</returns>
        public async Task<List<SubCategory>> GetSubCategoriesAsync(string SitePassword)
        {
            return await GetSubCategoriesAsync(false, SitePassword);
        }

        /// <summary>
        /// Retrieves a list of subcategories within a specified category for a given user
        /// </summary>
        /// <param name="Associative">Returns an associative array.Default: false.</param>
        /// <param name="SitePassword">The site password for a specific user</param>
        /// <returns>List of SubCategories (id, Name, NiceName)</returns>
        public async Task<List<SubCategory>> GetSubCategoriesAsync(bool Associative, string SitePassword)
        {
            CommunicationHelper ch = new CommunicationHelper();
            // SessionID [required], CategoryID [required], Associative, Callback, NickName, Pretty, SitePassword, Strict
            var resp = await ch.ExecuteMethod<SubCategoryResponse>("smugmug.subcategories.get", basic, "NickName", basic.NickName, "CategoryID", id, "Associative", Associative, "SitePassword", SitePassword);
            if (resp.stat == "ok")
            {
                var subCategoryList = new List<SubCategory>();
                subCategoryList.AddRange(resp.SubCategories);
                if (subCategoryList != null)
                {
                    foreach (var item in subCategoryList)
                    {
                        item.basic = basic;
                        // Add the Category for this Subcategory, as it's not returned
                        item.Category = this;
                    }
                }
                return subCategoryList;
            }
            else
            {
                Console.WriteLine(resp.message);
                throw new SmugMugException(resp.code, resp.message, resp.method);
            }
        }

        /// <summary>
        /// Given a certain name, it finds a subcategory or returns null
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public async Task<SubCategory> FindSubCategoryAsync(string Name)
        {
            List<SubCategory> subCategoryList = new List<SubCategory>();
            SubCategory mySubCategory = null;
            try
            {
                subCategoryList = await this.GetSubCategoriesAsync();
            }
            catch (SmugMugException sme)
            {
                throw new SmugMugException(sme.code, sme.Message, sme.method);
            }
            if (subCategoryList != null)
            {
                foreach (var item in subCategoryList)
                {
                    if (item.Name == Name)
                    {
                        // SubCategories are unique in name
                        mySubCategory = item;
                        break;
                    }
                }
            }

            //var rez = (from subc in myCategoryList
            //          where subc.Name == Name
            //          select subc).SingleOrDefault();
            //return rez;

            return mySubCategory;
        }

        /// <summary>
        /// Creates a new subcategory with the given name for the specified category (also adds it as a subcategory to the current object)
        /// </summary>
        /// <param name="Name"></param>
        /// <returns>SubCategory (id)</returns>
        public async Task<SubCategory> CreateSubCategoryAsync(string Name)
        {
            return await CreateSubCategoryAsync(Name, true, "");
        }

        /// <summary>
        /// Creates a new subcategory with the given name for the specified category (also adds it as a subcategory to the current object)
        /// </summary>
        /// <param name="Name">The name for the subcategory</param>
        /// <param name="Extras">A comma seperated string of additional attributes to return in the response.</param>
        /// <returns>SubCategory (id)</returns>
        public async Task<SubCategory> CreateSubCategoryAsync(string Name, string Extras)
        {
            return await CreateSubCategoryAsync(Name, true, Extras);
        }

        /// <summary>
        /// Creates a new subcategory with the given name for the specified category (also adds it as a subcategory to the current object)
        /// </summary>
        /// <param name="Name">The name for the subcategory</param>
        /// <param name="Unique">Create a subcategory if one of the same name doesn't already exist in the current hierarchy. Default: false</param>
        /// <param name="Extras">A comma seperated string of additional attributes to return in the response.</param>
        /// <returns>SubCategory (id)</returns>
        public async Task<SubCategory> CreateSubCategoryAsync(string Name, bool Unique, string Extras)
        {
            var mySubCategory = await this.FindSubCategoryAsync(Name);
            if (mySubCategory == null)
            {
                CommunicationHelper ch = new CommunicationHelper();
                // SessionID [required], CategoryID [required], Name [required], Callback, Extras, Pretty, Strict, Unique
                var resp = await ch.ExecuteMethod<SubCategoryResponse>("smugmug.subcategories.create", basic, "Name", Name, "CategoryID", this.id, "Unique", Unique, "Extras", Extras);
                if (resp.stat == "ok")
                {
                    var returnedSubCategory = resp.SubCategory;
                    if (returnedSubCategory != null)
                    {
                        returnedSubCategory.basic = basic;
                        returnedSubCategory.Name = Name;
                        returnedSubCategory.Category = this;
                        if (this.SubCategories == null)
                            this.SubCategories = new List<SubCategory>();
                        this.SubCategories.Add(returnedSubCategory);
                    }
                    return returnedSubCategory;
                }
                else
                {
                    Console.WriteLine(resp.message);
                    throw new SmugMugException(resp.code, resp.message, resp.method);
                }
            }
            else
                return mySubCategory;
        }



        /// <summary>
        /// Creates a new album with the specified title in the current category
        /// </summary>
        /// <param name="Title"></param>
        /// <returns>Album (id and Key)</returns>
        public async Task<Album> CreateAlbumAsync(string Title)
        {
            return await CreateAlbumAsync(Title, false);
        }

        /// <summary>
        /// Creates a new album with the specified title in the current category
        /// </summary>
        /// <param name="Title"></param>
        /// <param name="Unique">Create an album if one of the same name doesn't already exist in the current hierarchy.</param>
        /// <returns>Album (id and Key)</returns>
        public async Task<Album> CreateAlbumAsync(string Title, bool Unique)
        {
            return await CreateAlbumAsync(Title, Unique, string.Empty);
        }

        /// <summary>
        /// Creates a new album with the specified title in the current category
        /// </summary>
        /// <param name="Title"></param>
        /// <param name="Unique">Create an album if one of the same name doesn't already exist in the current hierarchy.</param>
        /// <param name="Extras">A comma seperated string of additional attributes to return in the response.</param>
        /// <returns>Album (id and Key)</returns>
        public async Task<Album> CreateAlbumAsync(string Title, bool Unique, string Extras)
        {
            Album a = new Album();
            a.Title = Title;
            a.basic = basic;
            a.Category = this;
            return await a.CreateAsync(Unique, Extras);
        }
        #endregion
    }
}
