using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace Demo1.Models.Pages
{
    [ContentType(DisplayName = "Start Page",
        Description = "Template for start page of site",
        GUID = "29c1f7d0-7bbb-45cd-95f1-1092051a2fa9")]
    public class StartPage : PageData
    {

    }
}