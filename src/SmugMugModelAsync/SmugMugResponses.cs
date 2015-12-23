using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmugMugModel
{
    public class SmugMugResponse
    {
        public string stat { get; set; }
        public string method { get; set; }
        public int code { get; set; }
        public string message { get; set; }
    }

    public class UserResponse : SmugMugResponse
    {
        public User User { get; set; }
    }

    /// <summary>
    /// allow secure API authentication
    /// </summary>
    public class Auth
    {
        public Token Token { get; set; }
        public oAuthUser User { get; set; }
    }

    public class oAuthUser
    {
        /// <summary>
        /// The account status for this user. Values: Active, Expired
        /// </summary>
        public AccountStatusEnum AccountStatus { get; set; }
        /// <summary>
        /// The account type for this user. Values: Pro, Power, Standard
        /// </summary>
        public AccountTypeEnum AccountType { get; set; }
        /// <summary>
        /// The file size limit for this user's account.
        /// </summary>
        public int FileSizeLimit { get; set; }

        /// <summary>
        /// The id for this user.
        /// </summary>
        public long id { get; set; }
        /// <summary>
        /// The NickName for this user.
        /// </summary>
        public string NickName { get; set; }
        /// <summary>
        /// The name for this user.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// SmugVault is enabled for this user's account.
        /// </summary>
        public bool SmugVault { get; set; }
        /// <summary>
        /// The homepage URL for this user.
        /// </summary>
        public string URL { get; set; }
    }

    public class GetTokenResponse : SmugMugResponse
    {
        public Auth Auth { get; set; }
    }

    public class Token
    {
        public string id { get; set; }
        public string Secret { get; set; }
        /// <summary>
        /// The access level for this OAuth access token ("Full", "Public")
        /// </summary>
        public AccessEnum? Access { get; set; }
        /// <summary>
        /// The permissions for this OAuth access token. ("Read" "Add" "Modify")
        /// </summary>
        public PermissionsEnum? Permissions { get; set; }
    }

    public class AuthResponse : SmugMugResponse
    {
        public Auth Auth { get; set; }
    }

    public class ThemeResponse : SmugMugResponse
    {
        public Theme Theme { get; set; }
        public Theme[] Themes { get; set; }
    }

    public class TemplateResponse : SmugMugResponse
    {
        public Template Template { get; set; }
        public Template[] Templates { get; set; }
    }

    public class CommunityResponse : SmugMugResponse
    {
        public Community Community { get; set; }
        public Community[] Communities { get; set; }
    }

    public class CouponResponse : SmugMugResponse
    {
        public Coupon Coupon { get; set; }
        public Coupon[] Coupons { get; set; }
    }

    public class FriendResponse : SmugMugResponse
    {
        public Friend[] Friends { get; set; }
    }

    public class FamilyResponse : SmugMugResponse
    {
        public Family[] Family { get; set; }
    }

    public class FansResponse : SmugMugResponse
    {
        public Fans[] Fans { get; set; }
    }

    public class FeaturedResponse : SmugMugResponse
    {
        public Featured Featured { get; set; }
    }

    public class CategoryResponse : SmugMugResponse
    {
        public Category Category { get; set; }
        public Category[] Categories { get; set; }
    }

    public class CommentResponse : SmugMugResponse
    {
        public Comment Comment { get; set; }
    }

    public class SubCategoryResponse : SmugMugResponse
    {
        public SubCategory SubCategory { get; set; }
        public SubCategory[] SubCategories { get; set; }
    }

    public class ShareGroupResponse : SmugMugResponse
    {
        public ShareGroup ShareGroup { get; set; }
        public ShareGroup[] ShareGroups { get; set; }
    }

    public class AlbumTemplateResponse : SmugMugResponse
    {
        public AlbumTemplate AlbumTemplate { get; set; }
        public AlbumTemplate[] AlbumTemplates { get; set; }
    }

    public class AlbumResponse : SmugMugResponse
    {
        public Album Album { get; set; }
        public Album[] Albums { get; set; }
    }

    public class AlbumResponseWithComments : SmugMugResponse
    {
        public AlbumWithComments Album { get; set; }
    }

    public class ImageResponse : SmugMugResponse
    {
        public Image Image { get; set; }
        public Image[] Images { get; set; }
        public Album Album { get; set; }

    }

    public class PrintmarkResponse : SmugMugResponse
    {
        public Printmark Printmark { get; set; }
        public Printmark[] Printmarks { get; set; }
    }

    public class WatermarkResponse : SmugMugResponse
    {
        public Watermark Watermark { get; set; }
        public Watermark[] Watermarks { get; set; }
    }
}