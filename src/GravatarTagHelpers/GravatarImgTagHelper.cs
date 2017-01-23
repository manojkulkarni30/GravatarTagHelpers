using GravatarHelper.NetStandard;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Threading.Tasks;

namespace GravatarTagHelpers
{
    /// <summary>
    /// Gravatar Image Tag Helper
    /// </summary>
    public class GravatarImgTagHelper : TagHelper
    {
        /// <summary>
        /// Email Address
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// File Extension (optional)
        /// </summary>
        public ImageExtension Extension { get; set; }

        /// <summary>
        /// Image Size (Optional)
        /// Default Image Size is 80
        /// </summary>
        public int Size { get; set; }

        /// <summary>
        /// Default Image Url (Supported extensions are jpg, jpeg, gif, png)
        /// </summary>
        public string DefaultImageUrl { get; set; }

        /// <summary>
        /// Default Image like 404, mm, identicon, monsterid, wavatar, retro and blank
        /// </summary>
        public GravatarDefaultImageType DefaultImageType { get; set; }

        /// <summary>
        /// Force Default Image
        /// </summary>
        public bool ForceDefaultImage { get; set; }

        /// <summary>
        /// Rating (Available rating options are g, pg, r or x. Default is g)
        /// </summary>
        public GravatarRating Rating { get; set; }

        /// <summary>
        /// Use Secure Url
        /// </summary>
        public bool UseSecureUrl { get; set; }

        public override Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "img";

            output.TagMode = TagMode.SelfClosing;

            var gravatarImageUrl = Gravatar
                .GetGravatarImageUrl(email: Email,
                imageSize: Size,
                imageExtension: Extension,
                defaultImageUrl: DefaultImageUrl,
                forceDefaultImage: ForceDefaultImage,
                gravatarDefaultImageType: DefaultImageType,
                rating: Rating,
                useSecureUrl: UseSecureUrl);

            output.Attributes.Add("src", gravatarImageUrl);

            return base.ProcessAsync(context, output);
        }
    }
}
