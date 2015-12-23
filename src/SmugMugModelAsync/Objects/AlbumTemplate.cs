using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SmugMugModel
{
    public class AlbumTemplate : SmugMugObject
    {
        #region Properties
        /// <summary>
        /// The id for this album template
        /// </summary>
        public long id { get; set; }
        /// <summary>
        /// The name for this album template
        /// </summary>
        public string AlbumTemplateName { get; set; }

        //BUG: There should only be one - either AlbumTemplateName or Name
        /// <summary>
        /// The name for this album template
        /// </summary>
        public string Name { get { return AlbumTemplateName; } set { AlbumTemplateName = value; } }
        /// <summary>
        /// The text to be printed on the back of prints purchased from this album. Pro accounts only!
        /// </summary>
        public string Backprinting { get; set; }
        /// <summary>
        /// Allow images from this album to be ranked using PhotoRank (default: true)
        /// </summary>
        public bool CanRank { get; set; }
        /// <summary>
        /// Hide the Description and LastUpdated for this album on the homepage and category pages (default: false)
        /// </summary>
        public bool Clean { get; set; }
        /// <summary>
        /// 0=No, 1=Yes, 2=Inherit(default)
        /// </summary>
        public ColorCorrection ColorCorrection { get; set; }
        /// <summary>
        /// Allow visitors to leave comments on this album (default: true)
        /// </summary>
        public bool Comments { get; set; }
        /// <summary>
        /// The community that this album belongs to
        /// </summary>
        public Community Community { get; set; }
        [Obsolete("Deprecated and replaced by ColorCorrection on January 27th 2009")]
        /// <summary>
        /// Pro only. Values: false-Auto Color (default), true-TrueColor
        /// </summary>
        public bool? DefaultColor { get; set; }
        /// <summary>
        /// Allow EXIF data to be viewed for images from this album (default: true)
        /// </summary>
        public bool EXIF { get; set; }
        /// <summary>
        /// Allow images from this album to be linked externally outside SmugMug (default: true)
        /// </summary>
        public bool External { get; set; }
        /// <summary>
        /// Allow family to edit the captions and keywords of the images in this album (default: false)
        /// </summary>
        public bool FamilyEdit { get; set; }
        /// <summary>
        /// Show filename for images uploaded with no caption to this album
        /// </summary>
        public bool Filenames { get; set; }
        /// <summary>
        /// Allow friends to edit the captions and keywords of the images in this album (default: false)
        /// </summary>
        public bool FriendEdit { get; set; }
        /// <summary>
        /// Enable mapping features for this album (default: true)
        /// </summary>
        public bool Geography { get; set; }
        /// <summary>
        /// Default this album to the standard SmugMug appearance. Values: false - Custom = default, true - SmugMug. Power & Pro accounts only!
        /// </summary>
        public bool? Header { get; set; }
        /// <summary>
        /// (default: false)
        /// </summary>
        public bool HideOwner { get; set; }
        /// <summary>
        /// Enable intercept shipping (personal delivery) for orders from this album. Values: 0=No, 1=Yes, 2=Inherit. Pro accounts only!
        /// </summary>
        public InterceptShipping? InterceptShipping { get; set; }
        /// <summary>
        /// Allow viewing of Large images for this album (default: true). Pro accounts only!
        /// </summary>
        public bool? Larges { get; set; }
        /// <summary>
        /// Allow viewing of original images for this album (default: true)
        /// </summary>
        public bool Originals { get; set; }
        /// <summary>
        /// Enable packaging branding for orders from this album. Pro accounts only!
        /// </summary>
        public bool? PackagingBranding { get; set; }
        /// <summary>
        /// The password for this album
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// The password hint for this album
        /// </summary>
        public string PasswordHint { get; set; }
        /// <summary>
        /// The position of this album within the site
        /// </summary>
        public int Position { get; set; }
        /// <summary>
        /// Allow images from this album to purchased as a print, merchandise or digital download (default: true)
        /// </summary>
        public bool Printable { get; set; }
        /// <summary>
        /// The printmark applied to images of this album. Pro accounts only!
        /// </summary>
        public Printmark Printmark { get; set; }
        /// <summary>
        /// The number of days an order is held for a pro to proof prior to being sent to print (default: 0, min: 0, max: 7). Pro accounts only!
        /// </summary>
        public int? ProofDays { get; set; }
        /// <summary>
        /// Enable right-click protection for this album (default: false). Power and Pro accounts only!
        /// </summary>
        public bool? Protected { get; set; }
        /// <summary>
        /// Display this album publicly (default: true)
        /// </summary>
        public bool Public { get; set; }
        /// <summary>
        /// Display the Share button for this album (default: true)
        /// </summary>
        public bool Share { get; set; }
        /// <summary>
        /// Allow SmugMug to index images from this album (default: true)
        /// </summary>
        public bool SmugSearchable { get; set; }
        /// <summary>
        /// The direction used for sorting images within this album. Values: false - Ascending=default, true - Descending
        /// </summary>
        public bool SortDirection { get; set; }
        /// <summary>
        /// The method used for sorting images within this album
        /// </summary>
        public SortMethod SortMethod { get; set; }
        /// <summary>
        /// Enable automatic square cropping of thumbnails for this album (default: true)
        /// </summary>
        public bool SquareThumbs { get; set; }
        /// <summary>
        /// The style template applied to this album
        /// </summary>
        public Template Template { get; set; }
        /// <summary>
        /// The Amount setting used for sharpening display copies of images in this album (default: 0.2, min: 0, max: 5). Power and Pro accounts only!
        /// </summary>
        public float? UnsharpAmount { get; set; }
        /// <summary>
        /// The Radius setting used for sharpening display copies of images in this album (default: 1, min: 0.1, max: 120). Power and Pro accounts only!
        /// </summary>
        public float? UnsharpRadius { get; set; }
        /// <summary>
        /// The Sigma setting used for sharpening display copies of images in this album (default: 0.05). Power and Pro accounts only!
        /// </summary>
        public float? UnsharpSigma { get; set; }
        /// <summary>
        /// The Threshold setting used for sharpening display copies of images in this album (default: 1, min: 0, max: 255). Power and Pro accounts only!
        /// </summary>
        public float? UnsharpThreshold { get; set; }
        /// <summary>
        /// The watermark applied to images of this album. Pro accounts only!
        /// </summary>
        public Watermark Watermark { get; set; }
        /// <summary>
        /// Enable automatic watermarking of images for this album (default: false). Pro accounts only!
        /// </summary>
        public bool? Watermarking { get; set; }
        /// <summary>
        /// Allow search engines to index images from this album (default: true)
        /// </summary>
        public bool WorldSearchable { get; set; }
        /// <summary>
        /// Allow viewing of X2Large images for this album (default: true)
        /// </summary>
        public bool X2Larges { get; set; }
        /// <summary>
        /// Allow viewing of X3Large images for this album (default: true)
        /// </summary>
        public bool X3Larges { get; set; }
        /// <summary>
        /// Allow viewing of XLarge images for this album (default: true). Pro accounts only!
        /// </summary>
        public bool? XLarges { get; set; }

        #endregion


        #region Sync
        /// <summary>
        /// Creates a new album template with the specified parameters (SessionID [required], AlbumTemplateName [required], Callback, Pretty, Strict, Backprinting, CanRank, Clean, ColorCorrection, Comments, CommunityID, DefaultColor, EXIF, External, FamilyEdit, FriendEdit, Geography, Header, HideOwner, InterceptShipping, Larges, Originals, PackagingBranding, Password, PasswordHint, Printable, ProofDays, Protected, Public, Share, SmugSearchable, SortDirection, SquareThumbs, UnsharpAmount, UnsharpRadius, UnsharpSigma, UnsharpThreshold, WatermarkID, Watermarking, WordSearchable, X2Larges, X3Larges, XLarges)
        /// </summary>
        /// <returns>AlbumTemplate (id and AlbumTemplateName)</returns>
        internal AlbumTemplate Create()
        {
            return CreateAsync().Result;
        }

        /// <summary>
        /// Modifies an existing album template
        /// </summary>
        /// <returns></returns>
        public bool ChangeSettings()
        {
            return ChangeSettingsAsync().Result;
        }

        /// <summary>
        /// Delete an existing album template
        /// </summary>
        /// <returns></returns>
        public bool Delete()
        {
            return DeleteAsync().Result;
        }
        #endregion

        #region Async
        /// <summary>
        /// Creates a new album template with the specified parameters (SessionID [required], AlbumTemplateName [required], Callback, Pretty, Strict, Backprinting, CanRank, Clean, ColorCorrection, Comments, CommunityID, DefaultColor, EXIF, External, FamilyEdit, FriendEdit, Geography, Header, HideOwner, InterceptShipping, Larges, Originals, PackagingBranding, Password, PasswordHint, Printable, ProofDays, Protected, Public, Share, SmugSearchable, SortDirection, SquareThumbs, UnsharpAmount, UnsharpRadius, UnsharpSigma, UnsharpThreshold, WatermarkID, Watermarking, WordSearchable, X2Larges, X3Larges, XLarges)
        /// </summary>
        /// <returns>AlbumTemplate (id and AlbumTemplateName)</returns>
        internal async Task<AlbumTemplate> CreateAsync()
        {
            CommunicationHelper ch = new CommunicationHelper();
            // SessionID [required], AlbumTemplateName [required], Callback, Pretty, Strict, Backprinting, CanRank, Clean, ColorCorrection, Comments, CommunityID, DefaultColor, EXIF, External, FamilyEdit, FriendEdit, Geography, Header, HideOwner, Larges, Originals, Password, PasswordHint, Printable, ProofDays, Protected, Public, Share, SmugSearchable, SortDirection, SortMethod, SquareThumbs, UnsharpAmount, UnsharpRadius, UnsharpSigma, UnsharpThreshold, WatermarkID, Watermarking, WordSearchable, X2Larges, X3Larges, XLarges
            var ls = BuildPropertiesValueList(this, "id", "Filenames", "Position");
            var resp = await ch.ExecuteMethod<AlbumTemplateResponse>("smugmug.albumtemplates.create", basic, ls.ToArray());
            if (resp.stat == "ok")
            {
                var myAlbumTemplate = resp.AlbumTemplate;
                myAlbumTemplate.basic = basic;
                myAlbumTemplate.AlbumTemplateName = this.AlbumTemplateName;
                return myAlbumTemplate;
            }
            else
            {
                Console.WriteLine(resp.message);
                throw new SmugMugException(resp.code, resp.message, resp.method);
            }
        }

        /// <summary>
        /// Modifies an existing album template
        /// </summary>
        /// <returns></returns>
        public async Task<bool> ChangeSettingsAsync()
        {
            CommunicationHelper ch = new CommunicationHelper();
            // SessionID [required], AlbumTemplateID [required], Callback, Pretty, Strict, AlbumTemplateName, Backprinting, CanRank, Clean, Comments, CommunityID, DefaultColor (deprecated), EXIF, External, FamilyEdit, FriendEdit, Geography, Header, HideOwner, InterceptShipping, Larges, Originals, PackagingBranding, Password, PasswordHint, Printable, ProofDays, Protected, Public, Share, SmugSearchable, SortDirection, SortMethod, SquareThumbs, UnsharpAmount, UnsharpRadius, UnsharpSigma, UnsharpThreshold, WatermarkID, Watermarking, WordSearchable, X2Larges, X3Larges, XLarges
            var ls = BuildPropertiesValueList(this);
            ls.Add("AlbumTemplateID"); ls.Add(this.id.ToString());
            var resp = await ch.ExecuteMethod<SmugMugResponse>("smugmug.albumtemplates.changeSettings", basic, ls.ToArray());
            if (resp.stat == "ok")
                return true;
            else
            {
                Console.WriteLine(resp.message);
                throw new SmugMugException(resp.code, resp.message, resp.method);
            }
        }

        /// <summary>
        /// Delete an existing album template
        /// </summary>
        /// <returns></returns>
        public async Task<bool> DeleteAsync()
        {
            CommunicationHelper ch = new CommunicationHelper();
            // SessionID [required], AlbumTemplateID [required], Callback, Pretty, Strict
            var resp = await ch.ExecuteMethod<SmugMugResponse>("smugmug.albumtemplates.delete", basic, "AlbumTemplateID", id);
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
