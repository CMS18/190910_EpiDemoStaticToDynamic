using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace Demo1.Models.Media
{
    [ContentType(DisplayName = "Any File", 
        GUID = "2580d599-d434-4c49-85d7-26c9f15067e2", 
        Description = "")]
    public class AnyFile : MediaData
    {

    }
}