using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmugMugModel
{
    public class SubCategory : SmugMugObject
    {
        #region Properties
        /// <summary>
        /// The id for this subcategory
        /// </summary>
        public long id { get; set; }
        /// <summary>
        /// The name for this subcategory
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The NiceName for this subcategory
        /// </summary>
        public string NiceName { get; set; }
        /// <summary>
        /// The Category to which it belongs
        /// </summary>
        public Category Category { get; set; }
        /// <summary>
        /// The albums it contains
        /// </summary>
        public List<Album> Albums { get; set; }
        #endregion

        public SubCategory()
        {
            Category = new Category();
            Albums = new List<Album>();
        }

        /// <summary>
        /// Override the ToString method to easily return the name of the subcategory
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Name;
        }

        #region Sync
        /// <summary>
        /// Renames an existing subcategory with the given name
        /// </summary>
        /// <param name="Name">The name for the subcategory</param>
        /// <returns>Bool (actually returns a SubCategory object with id)</returns>
        public bool Rename(string Name)
        {
            return Rename(Name, "");
        }

        /// <summary>
        /// Renames an existing subcategory with the given name
        /// </summary>
        /// <param name="Name">The name for the subcategory</param>
        /// <param name="Extras">A comma separated string of additional attributes to return in the response</param>
        /// <returns>Bool (actually returns a SubCategory object with id)</returns>
        public bool Rename(string Name, string Extras)
        {
            return RenameAsync(Name, Extras).Result;
        }

        /// <summary>
        /// Deletes an existing subcategory
        /// </summary>
        /// <returns></returns>
        public bool Delete()
        {
            return DeleteAsync().Result;
        }



        /// <summary>
        /// Creates a new album with the specified title in the current subcategory
        /// </summary>
        /// <param name="Title"></param>
        /// <returns>Album (id and Key)</returns>
        public Album CreateAlbum(string Title)
        {
            return CreateAlbum(Title, false);
        }

        /// <summary>
        /// Creates a new album with the specified title in the current subcategory
        /// </summary>
        /// <param name="Title"></param>
        /// <param name="Unique">Create an album if one of the same name doesn't already exist in the current hierarchy. Default: false  </param>
        /// <returns>Album (id and Key)</returns>
        public Album CreateAlbum(string Title, bool Unique)
        {
            return CreateAlbum(Title, Unique, "");
        }
        /// <summary>
        /// Creates a new album with the specified title in the current subcategory
        /// </summary>
        /// <param name="Title"></param>
        /// <param name="Unique">Create an album if one of the same name doesn't already exist in the current hierarchy. Default: false  </param>
        /// <param name="Extras">A comma seperated string of additional attributes to return in the response.</param>
        /// <returns>Album (id and Key)</returns>
        public Album CreateAlbum(string Title, bool Unique, string Extras)
        {
            Album a = new Album();
            a.Title = Title;
            a.basic = basic;
            a.Category = this.Category;
            a.SubCategory = this;
            return a.CreateAsync(Unique, Extras).Result;
        }
        #endregion

        #region Async
        /// <summary>
        /// Renames an existing subcategory with the given name
        /// </summary>
        /// <param name="Name">The name for the subcategory</param>
        /// <returns>Bool (actually returns a SubCategory object with id)</returns>
        public async Task<bool> RenameAsync(string Name)
        {
            return await RenameAsync(Name, "");
        }

        /// <summary>
        /// Renames an existing subcategory with the given name
        /// </summary>
        /// <param name="Name">The name for the subcategory</param>
        /// <param name="Extras">A comma separated string of additional attributes to return in the response</param>
        /// <returns>Bool (actually returns a SubCategory object with id)</returns>
        public async Task<bool> RenameAsync(string Name, string Extras)
        {
            CommunicationHelper ch = new CommunicationHelper();
            // SessionID [required], SubCategoryID [required], Name [required], Callback, Extras, Pretty, Strict
            var resp = await ch.ExecuteMethod<SubCategoryResponse>("smugmug.subcategories.rename", basic, "SubCategoryID", id, "Name", Name, "Extras", Extras);
            if (resp.stat == "ok")
            {
                // If the rename works, change the name of the current object as well
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
        /// Deletes an existing subcategory
        /// </summary>
        /// <returns></returns>
        public async Task<bool> DeleteAsync()
        {
            CommunicationHelper ch = new CommunicationHelper();
            // SessionID [required], SubCategoryID [required], Callback, Pretty, Strict 
            var resp = await ch.ExecuteMethod<SmugMugResponse>("smugmug.subcategories.delete", basic, "SubCategoryID", id);
            if (resp.stat == "ok")
                return true;
            else
            {
                Console.WriteLine(resp.message);
                throw new SmugMugException(resp.code, resp.message, resp.method);
            }
        }



        /// <summary>
        /// Creates a new album with the specified title in the current subcategory
        /// </summary>
        /// <param name="Title"></param>
        /// <returns>Album (id and Key)</returns>
        public async Task<Album> CreateAlbumAsync(string Title)
        {
            return await CreateAlbumAsync(Title, false);
        }

        /// <summary>
        /// Creates a new album with the specified title in the current subcategory
        /// </summary>
        /// <param name="Title"></param>
        /// <param name="Unique">Create an album if one of the same name doesn't already exist in the current hierarchy. Default: false  </param>
        /// <returns>Album (id and Key)</returns>
        public async Task<Album> CreateAlbumAsync(string Title, bool Unique)
        {
            return await CreateAlbumAsync(Title, Unique, "");
        }
        /// <summary>
        /// Creates a new album with the specified title in the current subcategory
        /// </summary>
        /// <param name="Title"></param>
        /// <param name="Unique">Create an album if one of the same name doesn't already exist in the current hierarchy. Default: false  </param>
        /// <param name="Extras">A comma seperated string of additional attributes to return in the response.</param>
        /// <returns>Album (id and Key)</returns>
        public async Task<Album> CreateAlbumAsync(string Title, bool Unique, string Extras)
        {
            Album a = new Album();
            a.Title = Title;
            a.basic = basic;
            a.Category = this.Category;
            a.SubCategory = this;
            return await a.CreateAsync(Unique, Extras);
        }
        #endregion
    }
}
