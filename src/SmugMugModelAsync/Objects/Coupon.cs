using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmugMugModel
{
    public class Coupon : SmugMugObject
    {
        #region Properties
        /// <summary>
        /// The id for this coupon
        /// </summary>
        public long id { get; set; }
        /// <summary>
        /// The total amount (in dollars) discounted using this coupon
        /// </summary>
        public float Amount { get; set; }
        /// <summary>
        /// The code for this coupon
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// The description for this coupon
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// The discount (in dollars or percent) for this coupon. Amount, Credit & Percent coupons only!
        /// </summary>
        public float? Discount { get; set; }
        /// <summary>
        /// Toggle the enable/disable state of the coupon
        /// </summary>
        public bool Enabled { get; set; }
        /// <summary>
        /// Allow this coupon to cover international shipping costs. Shipping coupons only!
        /// </summary>
        public bool? International { get; set; }
        /// <summary>
        /// The maximum discount (in dollars) allowed for this coupon. Percent coupons only!
        /// </summary>
        public float? MaxDiscount { get; set; }
        /// <summary>
        /// The maximum number of uses allowed for this coupon. Amount, Cost, Percent & Shipping coupons only!
        /// </summary>
        public int? MaxUses { get; set; }
        /// <summary>
        /// The minimum purchase (in dollars) required for this coupon. Amount, Percent & Shipping coupons only!
        /// </summary>
        public float? MinPurchase { get; set; }
        public Restrictions Restrictions { get; set; }
        /// <summary>
        /// Allow this coupon to cover shipping costs. Amount, Credit & Percent coupons only!
        /// </summary>
        public bool? Shipping { get; set; }
        /// <summary>
        /// The status for this coupon. Values: Active, Consumed, Disabled, Expired, Inactive
        /// </summary>
        public CouponStatusEnum Status { get; set; }
        /// <summary>
        /// The title for this coupon
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// The type of coupon. Values: Amount, Cost, Credit, Percent, Shipping
        /// </summary>
        public CouponTypeEnum Type { get; set; }
        /// <summary>
        /// The number of times this coupon has been used
        /// </summary>
        public int Uses { get; set; }
        /// <summary>
        /// The date this coupon is valid from
        /// </summary>
        public string ValidFrom { get; set; }
        /// <summary>
        /// The date this coupon is valid to
        /// </summary>
        public string ValidTo { get; set; }
        #endregion

        public Coupon()
        {
            Restrictions = new Restrictions();
        }

        #region Sync
        /// <summary>
        /// Retrieve information for a coupon
        /// </summary>
        public bool GetInfo()
        {
            return GetInfoAsync().Result;
        }

        /// <summary>
        /// Create a coupon
        /// </summary>
        /// <returns>Coupon</returns>
        internal Coupon CreateCoupon()
        {
            return CreateCouponAsync().Result;
        }

        /// <summary>
        /// Create a coupon
        /// </summary>
        /// <param name="AlbumIDs">A comma separated string of AlbumIDs to restrict the coupon</param>
        /// <param name="Extras">A comma separated string of additional attributes to return in the response</param>
        /// <returns>Coupon</returns>
        internal Coupon CreateCoupon(string AlbumIDs, string Extras)
        {
            return CreateCouponAsync(AlbumIDs, Extras).Result;
        }

        /// <summary>
        /// Modify an existing coupon (the coupon must be modified locally first).
        /// </summary>
        /// <returns>True if the request completed successfully</returns>
        public bool Modify()
        {
            return ModifyAsync("", "").Result;
        }

        /// <summary>
        /// Modify an existing coupon 
        /// (the coupon must be modified locally first - except if the only change is in Restrictions).
        /// </summary>
        /// <returns>True if the request completed successfully</returns>
        public bool Modify(string AlbumIDs)
        {
            return ModifyAsync(AlbumIDs, "").Result;
        }

        /// <summary>
        /// Modify an existing coupon and request the return of certain attributes
        /// (the coupon must be modified locally first - except if the only change is in Restrictions).
        /// </summary>
        /// <param name="AlbumIDs">A comma separated string of AlbumIDs to restrict the coupon</param>
        /// <param name="Extras">A comma separated string of additional attributes to return in the response. (can be empty)</param>
        /// <returns>True if the request completed successfully</returns>
        public bool Modify(string AlbumIDs, string Extras)
        {
            return ModifyAsync(AlbumIDs, Extras).Result;
        }

        /// <summary>
        /// Add an album restriction to a coupon
        /// </summary>
        /// <param name="CouponAlbum">A specific album</param>
        public bool AddRestriction(Album CouponAlbum)
        {
            return AddRestriction(CouponAlbum, "");
        }

        /// <summary>
        /// Add an album restriction to a coupon
        /// </summary>
        /// <param name="CouponAlbum">A specific album</param>
        /// <param name="Extras">A comma separated string of additional attributes to return in the response</param>
        public bool AddRestriction(Album CouponAlbum, string Extras)
        {
            return AddRestrictionAsync(CouponAlbum, Extras).Result;
        }

        /// <summary>
        /// Remove an album restriction to a coupon
        /// </summary>
        /// <param name="CouponAlbum">A specific album</param>
        public bool RemoveRestriction(Album CouponAlbum)
        {
            return RemoveRestriction(CouponAlbum, "");
        }

        /// <summary>
        /// Remove an album restriction to a coupon
        /// </summary>
        /// <param name="CouponAlbum">A specific album</param>
        /// <param name="Extras">A comma separated string of additional attributes to return in the response</param>
        public bool RemoveRestriction(Album CouponAlbum, string Extras)
        {
            return RemoveRestrictionAsync(CouponAlbum, Extras).Result;
        }
        #endregion

        #region Async
        /// <summary>
        /// Retrieve information for a coupon
        /// </summary>
        public async Task<bool> GetInfoAsync()
        {
            CommunicationHelper ch = new CommunicationHelper();
            // SessionID [required], CouponID [required], Callback, Pretty, Strict
            var resp = await ch.ExecuteMethod<CouponResponse>("smugmug.coupons.getInfo", basic, "CouponID", this.id);
            if (resp.stat == "ok")
            {
                if (resp.Coupon != null)
                {
                    resp.Coupon.basic = basic;
                    PopulateWithResponse(resp.Coupon, this);
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
        /// Create a coupon
        /// </summary>
        /// <returns>Coupon</returns>
        internal async Task<Coupon> CreateCouponAsync()
        {
            return await CreateCouponAsync("", "");
        }

        /// <summary>
        /// Create a coupon
        /// </summary>
        /// <param name="AlbumIDs">A comma separated string of AlbumIDs to restrict the coupon</param>
        /// <param name="Extras">A comma separated string of additional attributes to return in the response</param>
        /// <returns>Coupon</returns>
        internal async Task<Coupon> CreateCouponAsync(string AlbumIDs, string Extras)
        {
            CommunicationHelper ch = new CommunicationHelper();
            // SessionID [required], CouponID [required], AlbumIDs (string), Callback, Code, Description, Discount, Extras, 
            // International, MaxDiscount, MaxUses, MinPurchase, Pretty, Shipping, Strict, Title, Type, ValidFrom, ValidTo
            var ls = BuildPropertiesValueList(this, "id", "Restrictions", "Status", "Uses");
            ls.Add("AlbumIDs"); ls.Add(AlbumIDs);
            ls.Add("Extras"); ls.Add(Extras);
            var resp = await ch.ExecuteMethod<CouponResponse>("smugmug.coupons.create", basic, ls.ToArray());
            if (resp.stat == "ok")
            {
                var tempCoupon = resp.Coupon;
                if (tempCoupon != null)
                {
                    this.id = tempCoupon.id;
                    tempCoupon.basic = this.basic;
                }
                return tempCoupon;
            }
            else
            {
                Console.WriteLine(resp.message);
                throw new SmugMugException(resp.code, resp.message, resp.method);
            }
        }

        /// <summary>
        /// Modify an existing coupon (the coupon must be modified locally first).
        /// </summary>
        /// <returns>True if the request completed successfully</returns>
        public async Task<bool> ModifyAsync()
        {
            return await ModifyAsync("", "");
        }

        /// <summary>
        /// Modify an existing coupon 
        /// (the coupon must be modified locally first - except if the only change is in Restrictions).
        /// </summary>
        /// <returns>True if the request completed successfully</returns>
        public async Task<bool> ModifyAsync(string AlbumIDs)
        {
            return await ModifyAsync(AlbumIDs, "");
        }

        /// <summary>
        /// Modify an existing coupon and request the return of certain attributes
        /// (the coupon must be modified locally first - except if the only change is in Restrictions).
        /// </summary>
        /// <param name="AlbumIDs">A comma separated string of AlbumIDs to restrict the coupon</param>
        /// <param name="Extras">A comma separated string of additional attributes to return in the response. (can be empty)</param>
        /// <returns>True if the request completed successfully</returns>
        public async Task<bool> ModifyAsync(string AlbumIDs, string Extras)
        {
            CommunicationHelper ch = new CommunicationHelper();
            // SessionID [required], CouponID [required], AlbumIDs (string), Callback, Code, Description, Discount, Enabled, Extras, 
            // International, MaxDiscount, MaxUses, MinPurchase, Pretty, Shipping, Strict, Title, ValidFrom, ValidTo
            var ls = BuildPropertiesValueList(this, "Restrictions", "Status", "Type", "Uses");
            var resp = await ch.ExecuteMethod<CouponResponse>("smugmug.coupons.modify", basic, "AlbumIDs", AlbumIDs, ls.ToArray());
            if (resp.stat == "ok")
            {
                var tempCoupon = resp.Coupon;
                if (tempCoupon != null)
                {
                    if (this.id != tempCoupon.id)
                        this.id = tempCoupon.id;
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
        /// Add an album restriction to a coupon
        /// </summary>
        /// <param name="CouponAlbum">A specific album</param>
        public async Task<bool> AddRestrictionAsync(Album CouponAlbum)
        {
            return await AddRestrictionAsync(CouponAlbum, "");
        }

        /// <summary>
        /// Add an album restriction to a coupon
        /// </summary>
        /// <param name="CouponAlbum">A specific album</param>
        /// <param name="Extras">A comma separated string of additional attributes to return in the response</param>
        public async Task<bool> AddRestrictionAsync(Album CouponAlbum, string Extras)
        {
            CommunicationHelper ch = new CommunicationHelper();
            // SessionID [required], CouponID [required], AlbumID [required], Callback, Extras, Pretty, Strict
            var resp = await ch.ExecuteMethod<CouponResponse>("smugmug.coupons.restrictions.albums.add", basic, "CouponID", this.id, "AlbumID", CouponAlbum.id, "Extras", Extras);
            if (resp.stat == "ok")
            {
                if (this.Restrictions == null)
                    this.Restrictions = new Restrictions();
                if (this.Restrictions.Albums == null)
                    this.Restrictions.Albums = new List<Album>();
                this.Restrictions.Albums.Add(CouponAlbum);
                return true;
            }
            else
            {
                Console.WriteLine(resp.message);
                throw new SmugMugException(resp.code, resp.message, resp.method);
            }
        }

        /// <summary>
        /// Remove an album restriction to a coupon
        /// </summary>
        /// <param name="CouponAlbum">A specific album</param>
        public async Task<bool> RemoveRestrictionAsync(Album CouponAlbum)
        {
            return await RemoveRestrictionAsync(CouponAlbum, "");
        }

        /// <summary>
        /// Remove an album restriction to a coupon
        /// </summary>
        /// <param name="CouponAlbum">A specific album</param>
        /// <param name="Extras">A comma separated string of additional attributes to return in the response</param>
        public async Task<bool> RemoveRestrictionAsync(Album CouponAlbum, string Extras)
        {
            CommunicationHelper ch = new CommunicationHelper();
            // SessionID [required], CouponID [required], AlbumID [required], Callback, Extras, Pretty, Strict
            var resp = await ch.ExecuteMethod<CouponResponse>("smugmug.coupons.restrictions.albums.remove", basic, "CouponID", this.id, "AlbumID", CouponAlbum.id, "Extras", Extras);
            if (resp.stat == "ok")
            {
                if (this.Restrictions != null)
                {
                    if (this.Restrictions.Albums != null)
                        this.Restrictions.Albums.Remove(CouponAlbum);
                }
                return true;
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
