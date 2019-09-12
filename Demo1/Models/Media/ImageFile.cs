using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Framework.DataAnnotations;

namespace Demo1.Models.Media
{
    [ContentType(DisplayName = "Image", 
        GUID = "db5b106e-124f-4988-be20-f027ba1a3c5c", 
        Description = "")]
    [MediaDescriptor(ExtensionString = "png,gif,jpg,jpeg")]
    public class ImageFile : ImageData
    {

    }
}