using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SmugMugModel
{
    public class Printmark:SmugMugObject
    {
        #region Properties
        /// <summary>
        /// The id for this printmark
        /// </summary>
        public long id { get; set; }
        /// <summary>
        /// The name for this printmark
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The opacity of this printmark on the target image
        /// </summary>
        public int Dissolve { get; set; }
        /// <summary>
        /// Image struct
        /// </summary>
        public Image Image { get; set; }
        /// <summary>
        /// The location of this printmark on the target image. Values: TopLeft, TopRight, BottomLeft, BottomRight, Top, Bottom
        /// </summary>
        public string Location { get; set; }
        #endregion

        public Printmark()
        {
            Image = new Image();
        }

        #region Sync
        /// <summary>
        /// Deletes an existing printmark
        /// </summary>
        /// <returns></returns>
        public bool Delete()
        {
            return DeleteAsync().Result;
        }

        /// <summary>
        /// Retrieve information for a printmark. 
        /// </summary>
        /// <returns>New printmark object (id, Name, Dissolve, Image struct - id, key; Location)</returns>
        public Printmark GetInfo()
        {
            return GetInfoAsync().Result;
        }

        /// <summary>
        /// Populate the current printmark with info from the site  (id, Name, Dissolve, Image struct - id, key; Location)
        /// </summary>
        /// <returns></returns>
        public void PopulatePrintmarkWithInfoFromSite()
        {
            PopulatePrintmarkWithInfoFromSiteAsync().Wait();
        }

        /// <summary>
        /// Update on SmugMug a printmark modified locally (Dissolve, ImageID, Location, Name). If any of the parameters are missing or are empty strings "", they're ignored and the current settings are preserved. Otherwise, they're updated with the new settings.
        /// </summary>
        /// <returns></returns>
        public bool Modify()
        {
            return Modify("");
        }


        /// <summary>
        /// Update on SmugMug a printmark modified locally (Dissolve, ImageID, Location, Name). If any of the parameters are missing or are empty strings "", they're ignored and the current settings are preserved. Otherwise, they're updated with the new settings.
        /// </summary>
        /// <param name="Extras">A comma separated string of additional attributes to return in the response.</param>
        /// <returns></returns>
        public bool Modify(string Extras)
        {
            return ModifyAsync(Extras).Result;
        }

        /// <summary>
        /// Updates specific settings (Dissolve, ImageID, Location, Name) for the current printmark. If any of the parameters are missing or are empty strings "", they're ignored and the current settings are preserved. Otherwise, they're updated with the new settings.
        /// </summary>
        /// <param name="Name">The name for the printmark</param>
        /// <param name="Location">The location of the printmark on the target image. Values: TopLeft, TopRight, BottomLeft, BottomRight, Top, Bottom</param>
        /// <param name="Dissolve">The opacity of the printmark on the target image. Min: 0. Max: 100</param>
        /// <param name="ImageID">The id for a specific image</param>
        /// <param name="Extras">A comma separated string of additional attributes to return in the response.</param>
        /// <returns>Returns an empty successful response, if it completes without error</returns>
        public bool Modify(string Dissolve, string ImageID, string Location, string Name, string Extras)
        {
            return ModifyAsync(Dissolve, ImageID, Location, Name, Extras).Result;
        }
        #endregion


        #region Async
        /// <summary>
        /// Deletes an existing printmark
        /// </summary>
        /// <returns></returns>
        public async Task<bool> DeleteAsync()
        {
            CommunicationHelper ch = new CommunicationHelper();
            // SessionID [required], PrintmarkID [required], Callback, Pretty, Strict
            var resp = await ch.ExecuteMethod<SmugMugResponse>("smugmug.printmarks.delete", basic, "PrintmarkID", id);
            if (resp.stat == "ok")
                return true;
            else
            {
                Console.WriteLine(resp.message);
                throw new SmugMugException(resp.code, resp.message, resp.method);
            }
        }

        /// <summary>
        /// Retrieve information for a printmark. 
        /// </summary>
        /// <returns>New printmark object (id, Name, Dissolve, Image struct - id, key; Location)</returns>
        public async Task<Printmark> GetInfoAsync()
        {
            CommunicationHelper ch = new CommunicationHelper();
            // SessionID [required], PrintmarkID [required], Callback, Pretty, Strict
            var resp = await ch.ExecuteMethod<PrintmarkResponse>("smugmug.printmarks.getInfo", basic, "PrintmarkID", id);
            if (resp.stat == "ok")
            {
                var myPrintmark = resp.Printmark;
                myPrintmark.basic = basic;
                return myPrintmark;
            }
            else
            {
                Console.WriteLine(resp.message);
                throw new SmugMugException(resp.code, resp.message, resp.method);
            }
        }

        /// <summary>
        /// Populate the current printmark with info from the site  (id, Name, Dissolve, Image struct - id, key; Location)
        /// </summary>
        /// <returns></returns>
        public async Task PopulatePrintmarkWithInfoFromSiteAsync()
        {
            CommunicationHelper ch = new CommunicationHelper();
            // SessionID [required], PrintmarkID [required], Callback, Pretty, Strict
            var resp = await ch.ExecuteMethod<PrintmarkResponse>("smugmug.printmarks.getInfo", basic, "PrintmarkID", id);
            if (resp.stat == "ok")
                PopulateWithResponse(resp.Printmark, this);
            else
            {
                Console.WriteLine(resp.message);
                throw new SmugMugException(resp.code, resp.message, resp.method);
            }
        }

        /// <summary>
        /// Update on SmugMug a printmark modified locally (Dissolve, ImageID, Location, Name). If any of the parameters are missing or are empty strings "", they're ignored and the current settings are preserved. Otherwise, they're updated with the new settings.
        /// </summary>
        /// <returns></returns>
        public async Task<bool> ModifyAsync()
        {
            return await ModifyAsync("");
        }


        /// <summary>
        /// Update on SmugMug a printmark modified locally (Dissolve, ImageID, Location, Name). If any of the parameters are missing or are empty strings "", they're ignored and the current settings are preserved. Otherwise, they're updated with the new settings.
        /// </summary>
        /// <param name="Extras">A comma separated string of additional attributes to return in the response.</param>
        /// <returns></returns>
        public async Task<bool> ModifyAsync(string Extras)
        {
            CommunicationHelper ch = new CommunicationHelper();
            // SessionID [required], PrintmarkID [required], Callback, Dissolve, Extras, ImageID, Location, Name, Pretty, Strict
            var ls = BuildPropertiesValueList(this, "id", "Image");
            ls.Add("PrintmarkID"); ls.Add(this.id.ToString());
            ls.Add("ImageID"); ls.Add(this.Image.id.ToString());
            ls.Add("Extras"); ls.Add(Extras);
            var resp = await ch.ExecuteMethod<SmugMugResponse>("smugmug.printmarks.modify", basic, ls.ToArray());
            if (resp.stat == "ok")
                return true;
            else
            {
                Console.WriteLine(resp.message);
                throw new SmugMugException(resp.code, resp.message, resp.method);
            }
        }

        /// <summary>
        /// Updates specific settings (Dissolve, ImageID, Location, Name) for the current printmark. If any of the parameters are missing or are empty strings "", they're ignored and the current settings are preserved. Otherwise, they're updated with the new settings.
        /// </summary>
        /// <param name="Name">The name for the printmark</param>
        /// <param name="Location">The location of the printmark on the target image. Values: TopLeft, TopRight, BottomLeft, BottomRight, Top, Bottom</param>
        /// <param name="Dissolve">The opacity of the printmark on the target image. Min: 0. Max: 100</param>
        /// <param name="ImageID">The id for a specific image</param>
        /// <param name="Extras">A comma separated string of additional attributes to return in the response.</param>
        /// <returns>Returns an empty successful response, if it completes without error</returns>
        public async Task<bool> ModifyAsync(string Dissolve, string ImageID, string Location, string Name, string Extras)
        {
            CommunicationHelper ch = new CommunicationHelper();
            // SessionID [required], PrintmarkID [required], Callback, Dissolve, Extras, ImageID, Location, Name, Pretty, Strict
            var resp = await ch.ExecuteMethod<SmugMugResponse>("smugmug.printmarks.modify", basic, "PrintmarkID", this.id, "Dissolve", Dissolve, "Extras", Extras, "ImageID", ImageID, "Location", Location, "Name", Name);
            if (resp.stat == "ok")
                return true;
            else
            {
                Console.WriteLine(resp.message);
                throw new SmugMugException(resp.code, resp.message, resp.method);
            }
        } 
        #endregion
    }
}
