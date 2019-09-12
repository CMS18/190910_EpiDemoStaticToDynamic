using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Core;
using EPiServer.DataAnnotations;

namespace Demo1.Models.Pages
{

    [ContentType(DisplayName = "Standard Page",
        Description = "Use this for articles on the site.",
        GUID = "3ead3834-ebff-4c65-9073-e2530f739bc9")]
    public class StandardPage : PageData
    {

        [AllowedTypes(new [] {typeof(ImageData)})]
        public virtual ContentReference MainImage { get; set; }

        public virtual string MainIntro { get; set; }
        public virtual XhtmlString MainBody { get; set; }
    }
}