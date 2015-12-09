using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmugMugModel
{
    public class ShareGroup : SmugMugObject
    {
        #region Properties
        /// <summary>
        /// The id for this sharegroup.
        /// </summary>
        public long id { get; set; }
        /// <summary>
        /// The tag (public id) for this sharegroup
        /// </summary>
        public string Tag { get; set; }
        /// <summary>
        /// Allow access to password protected albums from this sharegroup without the password.
        /// </summary>
        public bool AccessPassworded { get; set; }
        /// <summary>
        /// The number of albums in this sharegroup
        /// </summary>
        public int AlbumCount { get; set; }
        /// <summary>
        /// List of albums contained in the sharegroup
        /// </summary>
        public List<Album> Albums { get; set; }
        /// <summary>
        /// The description for this sharegroup.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// The name for this sharegroup.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The password for this sharegroup
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Indicates whether this sharegroup is password protected
        /// </summary>
        public bool Passworded { get; set; }
        /// <summary>
        /// The password hint for this sharegroup
        /// </summary>
        public string PasswordHint { get; set; }
        /// <summary>
        /// The URL for this sharegroup
        /// </summary>
        public string URL { get; set; }     
        #endregion

        public ShareGroup()
        {
            Albums = new List<Album>();
        }

        #region Sync
        /// <summary>
        /// Deletes  a specified sharegroup
        /// </summary>
        /// <returns>Returns an empty successful response, if it completes without error</returns>
        public bool Delete()
        {
            return DeleteAsync().Result;
        }

        /// <summary>
        /// Get the info for a specified sharegroup 
        /// </summary>
        /// <returns>New Sharegroup object(id, Tag, AccessPassworded, AlbumCount, Albums array - id, key, Title; Description, Name, Password, PasswordHint, Passworded, URL)</returns>
        public ShareGroup GetInfo()
        {
            return GetInfo("", "");
        }

        /// <summary>
        /// Get the info for a specified sharegroup
        /// </summary>
        /// <param name="Password">The password for the sharegroup</param>
        /// <returns>New Sharegroup object(id, Tag, AccessPassworded, AlbumCount, Albums array - id, key, Title; Description, Name, Password, PasswordHint, Passworded, URL)</returns>
        public ShareGroup GetInfo(string Password)
        {
            return GetInfo(Password, "");
        }

        /// <summary>
        /// Get the info for a specified sharegroup
        /// </summary>
        /// <param name="Password">The password for the sharegroup</param>
        /// <param name="ShareGroupTag">The tag (public id) for the sharegroup</param>
        /// <param name="Extras">A comma separated string of additional attributes to return in the response</param>
        /// <returns>New Sharegroup object(id, Tag, AccessPassworded, AlbumCount, Albums array - id, key, Title; Description, Name, Password, PasswordHint, Passworded, URL)</returns>
        public ShareGroup GetInfo(string Password, string Extras)
        {
            return GetInfoAsync(Password, Extras).Result;
        }

        /// <summary>
        /// Populate the current sharegroup with info from the site  (id, Tag, AccessPassworded, AlbumCount, Albums array - id, key, Title; Description, Name, Password, PasswordHint, Passworded, URL)
        /// </summary>        
        public void PopulateShareGroupWithInfoFromSite()
        {
            PopulateShareGroupWithInfoFromSite("", "");
        }

        /// <summary>
        /// Populate the current sharegroup with info from the site  (id, Tag, AccessPassworded, AlbumCount, Albums array - id, key, Title; Description, Name, Password, PasswordHint, Passworded, URL)
        /// </summary>        
        /// <param name="Password">The password for the sharegroup</param>
        public void PopulateShareGroupWithInfoFromSite(string Password)
        {
            PopulateShareGroupWithInfoFromSite(Password, "");
        }

        /// <summary>
        /// Populate the current sharegroup with info from the site  (id, Tag, AccessPassworded, AlbumCount, Albums array - id, key, Title; Description, Name, Password, PasswordHint, Passworded, URL)
        /// </summary>        
        /// <param name="Password">The password for the sharegroup</param>
        /// <param name="ShareGroupTag">The tag (public id) for the sharegroup</param>
        /// <param name="Extras">A comma separated string of additional attributes to return in the response</param>
        public void PopulateShareGroupWithInfoFromSite(string Password, string Extras)
        {
            PopulateShareGroupWithInfoFromSiteAsync(Password, Extras).Wait();
        }

        /// <summary>
        /// Update on SmugMug a sharegroup modified locally (AccessPassworded, Description, Name, Password, PasswordHint). If any of the parameters are missing or are empty strings "", they're ignored and the current settings are preserved. Otherwise, they're updated with the new settings.
        /// </summary>
        /// <param name="Extras">A comma separated string of additional attributes to return in the response</param>
        /// <returns></returns>
        public bool Modify()
        {
            return Modify("");
        }

        /// <summary>
        /// Update on SmugMug a sharegroup modified locally (AccessPassworded, Description, Name, Password, PasswordHint). If any of the parameters are missing or are empty strings "", they're ignored and the current settings are preserved. Otherwise, they're updated with the new settings.
        /// </summary>
        public bool Modify(string Extras)
        {
            return ModifyAsync(Extras).Result;
        }


        /// <summary>
        /// Updates specific settings (Dissolve, ImageID, Location, Name) for a the current sharegroup. If any of the parameters are missing or are empty strings "", they're ignored and the current settings are preserved. Otherwise, they're updated with the new settings.
        /// </summary>
        /// <param name="AccessPassworded">Allow access to password protected albums from the sharegroup without the password. Default: false.</param>
        /// <param name="Description">The description for the sharegroup</param>
        /// <param name="Name">The name for the sharegroup</param>
        /// <param name="Password">The password for the sharegroup</param>
        /// <param name="PasswordHint">The password hint for the sharegroup</param>
        /// <param name="Extras">A comma separated string of additional attributes to return in the response</param>
        /// <returns>Returns an empty successful response, if it completes without error</returns>
        public bool Modify(bool AccessPassworded, string Description, string Name, string Password, string PasswordHint, string Extras)
        {
            return ModifyAsync(AccessPassworded, Description, Name, Password, PasswordHint, Extras).Result;
        }


        /// <summary>
        /// Adds an album to a specified sharegroup 
        /// </summary>
        /// <param name="AlbumToAdd">Album to be added to the sharegroup.</param>
        /// <returns></returns>
        public bool AddAlbum(Album AlbumToAdd)
        {
            return AddAlbumAsync(AlbumToAdd).Result;
        }

        /// <summary>
        /// Removes an album from a specified sharegroup 
        /// </summary>
        /// <param name="AlbumToRemove">Album to be removed from the sharegroup</param>
        /// <returns></returns>
        public bool RemoveAlbum(Album AlbumToRemove)
        {
            return RemoveAlbumAsync(AlbumToRemove).Result;
        }

        /// <summary>
        /// Retrieves a list of albums for a sharegroup (also populates the current sharegroup with this list)
        /// </summary>
        /// <returns>List of Albums (id, Key, Title)</returns>
        public List<Album> GetAlbums()
        {
            return GetAlbums(false, "", "");
        }

        /// <summary>
        /// Retrieves a list of albums for a sharegroup (also populates the current sharegroup with this list)
        /// </summary>
        /// <param name="Password">The password for the sharegroup</param>
        /// <returns>List of Albums (id, Key, Title)</returns>
        public List<Album> GetAlbums(string Password)
        {
            return GetAlbums(false, Password, "");
        }

        /// <summary>
        /// Retrieves a list of albums for a sharegroup (also populates the current sharegroup with this list)
        /// </summary>
        /// <param name="Associative">Returns an associative array. Default: false.</param>
        /// <param name="Password">The password for the sharegroup</param>
        /// <param name="Extras">A comma separated string of additional attributes to return in the response</param>
        /// <returns></returns>
        public List<Album> GetAlbums(bool Associative, string Password, string Extras)
        {
            return GetAlbumsAsync(Associative, Password, Extras).Result;
        }
        #endregion

        #region Async
        /// <summary>
        /// Deletes  a specified sharegroup
        /// </summary>
        /// <returns>Returns an empty successful response, if it completes without error</returns>
        public async Task<bool> DeleteAsync()
        {
            CommunicationHelper ch = new CommunicationHelper();
            // SessionID [required], ShareGroupID [required], Callback, Pretty, Strict
            var resp = await ch.ExecuteMethod<SmugMugResponse>("smugmug.sharegroups.delete", basic, "ShareGroupID", id);
            if (resp.stat == "ok")
                return true;
            else
            {
                Console.WriteLine(resp.message);
                throw new SmugMugException(resp.code, resp.message, resp.method);
            }
        }

        /// <summary>
        /// Get the info for a specified sharegroup 
        /// </summary>
        /// <returns>New Sharegroup object(id, Tag, AccessPassworded, AlbumCount, Albums array - id, key, Title; Description, Name, Password, PasswordHint, Passworded, URL)</returns>
        public async Task<ShareGroup> GetInfoAsync()
        {
            return await GetInfoAsync("", "");
        }

        /// <summary>
        /// Get the info for a specified sharegroup
        /// </summary>
        /// <param name="Password">The password for the sharegroup</param>
        /// <returns>New Sharegroup object(id, Tag, AccessPassworded, AlbumCount, Albums array - id, key, Title; Description, Name, Password, PasswordHint, Passworded, URL)</returns>
        public async Task<ShareGroup> GetInfoAsync(string Password)
        {
            return await GetInfoAsync(Password, "");
        }

        /// <summary>
        /// Get the info for a specified sharegroup
        /// </summary>
        /// <param name="Password">The password for the sharegroup</param>
        /// <param name="ShareGroupTag">The tag (public id) for the sharegroup</param>
        /// <param name="Extras">A comma separated string of additional attributes to return in the response</param>
        /// <returns>New Sharegroup object(id, Tag, AccessPassworded, AlbumCount, Albums array - id, key, Title; Description, Name, Password, PasswordHint, Passworded, URL)</returns>
        public async Task<ShareGroup> GetInfoAsync(string Password, string Extras)
        {
            CommunicationHelper ch = new CommunicationHelper();
            // SessionID [required], ShareGroupID [required], Callback, Extras, Password, Pretty, SharegroupTag, Strict
            var resp = await ch.ExecuteMethod<ShareGroupResponse>("smugmug.sharegroups.getInfo", basic, "ShareGroupID", id, "Password", Password, "ShareGroupTag", this.Tag, "Extras", Extras);
            if (resp.stat == "ok")
            {
                var temp = resp.ShareGroup;
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
        /// Populate the current sharegroup with info from the site  (id, Tag, AccessPassworded, AlbumCount, Albums array - id, key, Title; Description, Name, Password, PasswordHint, Passworded, URL)
        /// </summary>        
        public async Task PopulateShareGroupWithInfoFromSiteAsync()
        {
            await PopulateShareGroupWithInfoFromSiteAsync("", "");
        }

        /// <summary>
        /// Populate the current sharegroup with info from the site  (id, Tag, AccessPassworded, AlbumCount, Albums array - id, key, Title; Description, Name, Password, PasswordHint, Passworded, URL)
        /// </summary>        
        /// <param name="Password">The password for the sharegroup</param>
        public async Task PopulateShareGroupWithInfoFromSiteAsync(string Password)
        {
            await PopulateShareGroupWithInfoFromSiteAsync(Password, "");
        }

        /// <summary>
        /// Populate the current sharegroup with info from the site  (id, Tag, AccessPassworded, AlbumCount, Albums array - id, key, Title; Description, Name, Password, PasswordHint, Passworded, URL)
        /// </summary>        
        /// <param name="Password">The password for the sharegroup</param>
        /// <param name="ShareGroupTag">The tag (public id) for the sharegroup</param>
        /// <param name="Extras">A comma separated string of additional attributes to return in the response</param>
        public async Task PopulateShareGroupWithInfoFromSiteAsync(string Password, string Extras)
        {
            CommunicationHelper ch = new CommunicationHelper();
            // SessionID [required], ShareGroupID [required], Callback, Extras, Password, Pretty, SharegroupTag, Strict
            var resp = await ch.ExecuteMethod<ShareGroupResponse>("smugmug.sharegroups.getInfo", basic, "ShareGroupID", id, "Password", Password, "ShareGroupTag", this.Tag, "Extras", Extras);
            if (resp.stat == "ok")
                PopulateWithResponse(resp.ShareGroup, this);
            else
            {
                Console.WriteLine(resp.message);
                throw new SmugMugException(resp.code, resp.message, resp.method);
            }
        }

        /// <summary>
        /// Update on SmugMug a sharegroup modified locally (AccessPassworded, Description, Name, Password, PasswordHint). If any of the parameters are missing or are empty strings "", they're ignored and the current settings are preserved. Otherwise, they're updated with the new settings.
        /// </summary>
        /// <param name="Extras">A comma separated string of additional attributes to return in the response</param>
        /// <returns></returns>
        public async Task<bool> ModifyAsync()
        {
            return await ModifyAsync("");
        }

        /// <summary>
        /// Update on SmugMug a sharegroup modified locally (AccessPassworded, Description, Name, Password, PasswordHint). If any of the parameters are missing or are empty strings "", they're ignored and the current settings are preserved. Otherwise, they're updated with the new settings.
        /// </summary>
        public async Task<bool> ModifyAsync(string Extras)
        {
            CommunicationHelper ch = new CommunicationHelper();
            // SessionID [required], ShareGroupID [required], AccessPassworded, Callback, Description, Extras, Name, Password, PasswordHint, Pretty, Strict
            var ls = BuildPropertiesValueList(this, "id", "Tag", "AlbumCount", "Albums", "Passworded", "URL");
            ls.Add("ShareGroupID"); ls.Add(this.id.ToString());
            ls.Add("Extras"); ls.Add(Extras);
            var resp = await ch.ExecuteMethod<SmugMugResponse>("smugmug.sharegroups.modify", basic, ls.ToArray());
            if (resp.stat == "ok")
                return true;
            else
            {
                Console.WriteLine(resp.message);
                throw new SmugMugException(resp.code, resp.message, resp.method);
            }
        }


        /// <summary>
        /// Updates specific settings (Dissolve, ImageID, Location, Name) for a the current sharegroup. If any of the parameters are missing or are empty strings "", they're ignored and the current settings are preserved. Otherwise, they're updated with the new settings.
        /// </summary>
        /// <param name="AccessPassworded">Allow access to password protected albums from the sharegroup without the password. Default: false.</param>
        /// <param name="Description">The description for the sharegroup</param>
        /// <param name="Name">The name for the sharegroup</param>
        /// <param name="Password">The password for the sharegroup</param>
        /// <param name="PasswordHint">The password hint for the sharegroup</param>
        /// <param name="Extras">A comma separated string of additional attributes to return in the response</param>
        /// <returns>Returns an empty successful response, if it completes without error</returns>
        public async Task<bool> ModifyAsync(bool AccessPassworded, string Description, string Name, string Password, string PasswordHint, string Extras)
        {
            CommunicationHelper ch = new CommunicationHelper();
            // SessionID [required], ShareGroupID [required], AccessPassworded, Callback, Description, Extras, Name, Password, PasswordHint, Pretty, Strict
            var resp = await ch.ExecuteMethod<SmugMugResponse>("smugmug.sharegroups.modify", basic, "AccessPassworded", AccessPassworded, "Description", Description, "Extras", Extras, "Name", Name, "Password", Password, "PasswordHint", PasswordHint);
            if (resp.stat == "ok")
                return true;
            else
            {
                Console.WriteLine(resp.message);
                throw new SmugMugException(resp.code, resp.message, resp.method);
            }
        }


        /// <summary>
        /// Adds an album to a specified sharegroup 
        /// </summary>
        /// <param name="AlbumToAdd">Album to be added to the sharegroup.</param>
        /// <returns></returns>
        public async Task<bool> AddAlbumAsync(Album AlbumToAdd)
        {
            CommunicationHelper ch = new CommunicationHelper();
            // SessionID [required], ShareGroupID [required], AlbumID [required], Callback, Pretty, Strict 
            var resp = await ch.ExecuteMethod<SmugMugResponse>("smugmug.sharegroups.albums.add", basic, "ShareGroupID", this.id, "AlbumID", AlbumToAdd.id);
            if (resp.stat == "ok")
            {
                if (this.Albums == null)
                    this.Albums = new List<Album>();
                // Add the album to the current object
                this.Albums.Add(AlbumToAdd);
                // Increase the no of albums this sharegroup has
                this.AlbumCount++;
                return true;
            }
            else
            {
                Console.WriteLine(resp.message);
                throw new SmugMugException(resp.code, resp.message, resp.method);
            }
        }

        /// <summary>
        /// Removes an album from a specified sharegroup 
        /// </summary>
        /// <param name="AlbumToRemove">Album to be removed from the sharegroup</param>
        /// <returns></returns>
        public async Task<bool> RemoveAlbumAsync(Album AlbumToRemove)
        {
            CommunicationHelper ch = new CommunicationHelper();
            // SessionID [required], ShareGroupID [required], AlbumID [required], Callback, Pretty, Strict 
            var resp = await ch.ExecuteMethod<SmugMugResponse>("smugmug.sharegroups.albums.remove", basic, "ShareGroupID", id, "AlbumID", AlbumToRemove.id);
            if (resp.stat == "ok")
            {
                if (this.Albums != null)
                {
                    // Remove the album from this sharegroup
                    this.Albums.Remove(AlbumToRemove);
                    // Decrease the no of albums this sharegroup has
                    this.AlbumCount--;
                }
                return true;
            }
            else
            {
                Console.WriteLine(resp.message);
                throw new SmugMugException(resp.code, resp.message, resp.method);
            }
        }

        /// <summary>
        /// Retrieves a list of albums for a sharegroup (also populates the current sharegroup with this list)
        /// </summary>
        /// <returns>List of Albums (id, Key, Title)</returns>
        public async Task<List<Album>> GetAlbumsAsync()
        {
            return await GetAlbumsAsync(false, "", "");
        }

        /// <summary>
        /// Retrieves a list of albums for a sharegroup (also populates the current sharegroup with this list)
        /// </summary>
        /// <param name="Password">The password for the sharegroup</param>
        /// <returns>List of Albums (id, Key, Title)</returns>
        public async Task<List<Album>> GetAlbumsAsync(string Password)
        {
            return await GetAlbumsAsync(false, Password, "");
        }

        /// <summary>
        /// Retrieves a list of albums for a sharegroup (also populates the current sharegroup with this list)
        /// </summary>
        /// <param name="Associative">Returns an associative array. Default: false.</param>
        /// <param name="Password">The password for the sharegroup</param>
        /// <param name="Extras">A comma separated string of additional attributes to return in the response</param>
        /// <returns></returns>
        public async Task<List<Album>> GetAlbumsAsync(bool Associative, string Password, string Extras)
        {
            CommunicationHelper ch = new CommunicationHelper();
            // SessionID [required], ShareGroupTag [required], Associative, Callback, Extras, Password, Pretty, Strict
            var resp = await ch.ExecuteMethod<ShareGroupResponse>("smugmug.sharegroups.albums.get", basic, "ShareGroupTag", Tag, "Associative", Associative, "Password", Password, "Extras", Extras);
            if (resp.stat == "ok")
            {
                var shareGroupAlbums = resp.ShareGroup.Albums;
                if (shareGroupAlbums != null)
                {
                    foreach (var item in shareGroupAlbums)
                    {
                        bool flag = true;
                        item.basic = basic;
                        foreach (var myAlbum in this.Albums)
                        {
                            if (item.id == myAlbum.id)
                            {
                                flag = false;
                                break;
                            }
                        }
                        // Populate the current sharegroup with its albums from the site
                        if (flag)
                        {
                            if (this.Albums == null)
                                this.Albums = new List<Album>();
                            this.Albums.AddRange(shareGroupAlbums);
                        }
                    }
                    this.AlbumCount = shareGroupAlbums.Count;
                }

                return shareGroupAlbums;
            }
            else
            {
                Console.WriteLine(resp.message);
                throw new SmugMugException(resp.code, resp.message, resp.method);
            }
        } 
        #endregion
    }
}
