using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmugMugModel
{
    public class Watermark : SmugMugObject
    {
        #region Properties
        /// <summary>
        /// The id for the watermark
        /// </summary>
        public long id { get; set; }
        /// <summary>
        /// The name for this watermark
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The location of the watermark on the target image. Values: "Bottom" "BottomLeft" "BottomRight" "Center" "Left" "Right" "Tile" "Top" "TopLeft" "TopRight"
        /// </summary>
        public PinnedEnum Pinned { get; set; }
        /// <summary>
        /// The opacity of the watermark on the target image. Min: 0  Max: 100
        /// </summary>
        public int Dissolve { get; set; }
        /// <summary>
        /// This watermark is applied to thumbnail image sizes
        /// </summary>
        public bool Thumbs { get; set; }
        /// <summary>
        /// The image from which it's created
        /// </summary>
        public Image Image { get; set; }
        #endregion

        public Watermark()
        {
            Image = new Image();
        }


        #region Sync
        /// <summary>
        /// Deletes an existing watermark
        /// </summary>
        /// <returns></returns>
        public bool Delete()
        {
            return DeleteAsync().Result;
        }

        /// <summary>
        /// Retrieves the information for a watermark (Name, Dissolve, Image (id, Key), Pinned, Thumbs)
        /// </summary>
        /// <returns>Watermark with id, Name, Dissolve, Image (id, Key), Pinned, Thumbs</returns>
        public Watermark GetInfo()
        {
            return GetInfoAsync().Result;
        }

        /// <summary>
        /// Populates the current watermark with information from the site
        /// </summary>
        /// <returns></returns>
        public void PopulateWatermarkWithInfoFromSite()
        {
            PopulateWatermarkWithInfoFromSiteAsync().Wait();
        }

        /// <summary>
        /// Changes the settings of a watermark (Callback, Dissolve, ImageID, Name, Pinned, Pretty, Strict, Thumbs)
        /// </summary>
        /// <returns></returns>
        public bool ChangeSettings()
        {
            return ChangeSettings("");
        }

        /// <summary>
        /// Changes the settings of a watermark (Callback, Dissolve, ImageID, Name, Pinned, Pretty, Strict, Thumbs)
        /// </summary>
        /// <param name="Extras">A comma seperated string of additional attributes to return in the response.</param>
        /// <returns></returns>
        public bool ChangeSettings(string Extras)
        {
            return ChangeSettingsAsync(Extras).Result;
        }
        #endregion


        #region Async
        /// <summary>
        /// Deletes an existing watermark
        /// </summary>
        /// <returns></returns>
        public async Task<bool> DeleteAsync()
        {
            CommunicationHelper ch = new CommunicationHelper();
            // SessionID [required], WatermarkID [required], Callback, Pretty, Strict
            var resp = await ch.ExecuteMethod<SmugMugResponse>("smugmug.watermarks.delete", basic, "WatermarkID", id);
            if (resp.stat == "ok")
                return true;
            else
            {
                Console.WriteLine(resp.message);
                throw new SmugMugException(resp.code, resp.message, resp.method);
            }
        }

        /// <summary>
        /// Retrieves the information for a watermark (Name, Dissolve, Image (id, Key), Pinned, Thumbs)
        /// </summary>
        /// <returns>Watermark with id, Name, Dissolve, Image (id, Key), Pinned, Thumbs</returns>
        public async Task<Watermark> GetInfoAsync()
        {
            CommunicationHelper ch = new CommunicationHelper();
            // SessionID [required], WatermarkID [required], Callback, Pretty, Strict
            var resp = await ch.ExecuteMethod<WatermarkResponse>("smugmug.watermarks.getInfo", basic, "WatermarkID", id);
            if (resp.stat == "ok")
            {
                var myWatermark = resp.Watermark;
                myWatermark.basic = basic;
                return myWatermark;
            }
            else
            {
                Console.WriteLine(resp.message);
                throw new SmugMugException(resp.code, resp.message, resp.method);
            }
        }

        /// <summary>
        /// Populates the current watermark with information from the site
        /// </summary>
        /// <returns></returns>
        public async Task PopulateWatermarkWithInfoFromSiteAsync()
        {
            CommunicationHelper ch = new CommunicationHelper();
            // SessionID [required], WatermarkID [required], Callback, Pretty, Strict
            var resp = await ch.ExecuteMethod<WatermarkResponse>("smugmug.watermarks.getInfo", basic, "WatermarkID", id);
            if (resp.stat == "ok")
                PopulateWithResponse(resp.Watermark, this);
            else
            {
                Console.WriteLine(resp.message);
                throw new SmugMugException(resp.code, resp.message, resp.method);
            }
        }

        /// <summary>
        /// Changes the settings of a watermark (Callback, Dissolve, ImageID, Name, Pinned, Pretty, Strict, Thumbs)
        /// </summary>
        /// <returns></returns>
        public async Task<bool> ChangeSettingsAsync()
        {
            return await ChangeSettingsAsync("");
        }

        /// <summary>
        /// Changes the settings of a watermark (Callback, Dissolve, ImageID, Name, Pinned, Pretty, Strict, Thumbs)
        /// </summary>
        /// <param name="Extras">A comma seperated string of additional attributes to return in the response.</param>
        /// <returns></returns>
        public async Task<bool> ChangeSettingsAsync(string Extras)
        {
            CommunicationHelper ch = new CommunicationHelper();
            // SessionID [required], WatermarkID [required], Callback, Dissolve, Extras, ImageID, Name, Pinned, Pretty, Strict, Thumbs
            var ls = BuildPropertiesValueList(this, "Image");
            ls.Add("WatermarkID"); ls.Add(this.id.ToString());
            ls.Add("Extras"); ls.Add(Extras);
            var resp = await ch.ExecuteMethod<SmugMugResponse>("smugmug.watermarks.changeSettings", basic, ls.ToArray());
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
