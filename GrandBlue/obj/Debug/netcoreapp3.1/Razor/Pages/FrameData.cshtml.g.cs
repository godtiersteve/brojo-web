#pragma checksum "C:\Users\godti\source\repos\GrandBlue\GrandBlue\Pages\FrameData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9db4e044e828f793b35319933a8f01e6b07bcdd5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(GrandBlue.Pages.Pages_FrameData), @"mvc.1.0.razor-page", @"/Pages/FrameData.cshtml")]
namespace GrandBlue.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\godti\source\repos\GrandBlue\GrandBlue\Pages\_ViewImports.cshtml"
using GrandBlue;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{chara}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9db4e044e828f793b35319933a8f01e6b07bcdd5", @"/Pages/FrameData.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90f0c2bf4e15c4391fd265f0f427094546c3c7fc", @"/Pages/_ViewImports.cshtml")]
    public class Pages_FrameData : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\godti\source\repos\GrandBlue\GrandBlue\Pages\FrameData.cshtml"
  
    ViewData["Title"] = "Frame Data";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"framedata\">\r\n");
#nullable restore
#line 8 "C:\Users\godti\source\repos\GrandBlue\GrandBlue\Pages\FrameData.cshtml"
     foreach(var list in Model.FrameDataLists) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"frame-table\">\r\n        <tr>\r\n            <th colspan=\"10\" class=\"table-heading\">");
#nullable restore
#line 11 "C:\Users\godti\source\repos\GrandBlue\GrandBlue\Pages\FrameData.cshtml"
                                              Write(list.HeadingName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</th>
        </tr>
        <tr class=""frame-heading"">
            <th rowspan=""2"">Move Name</th>
            <th rowspan=""2"">Version</th>
            <th colspan=""3"">Frame</th>
            <th colspan=""2"">Recovery</th>
            <th rowspan=""2"">Damage</th>
            <th rowspan=""2"">Guard Type</th>
            <th rowspan=""2"">Notes</th>
        </tr>
        <tr class=""frame-heading"">
            <th>Startup</th>
            <th>Active</th>
            <th>Recovery</th>
            <th>On Block</th>
            <th>On Hit</th>
        </tr>
");
#nullable restore
#line 29 "C:\Users\godti\source\repos\GrandBlue\GrandBlue\Pages\FrameData.cshtml"
         foreach (var item in list.FrameData)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 33 "C:\Users\godti\source\repos\GrandBlue\GrandBlue\Pages\FrameData.cshtml"
               Write(Html.DisplayFor(modelItem => item.MoveName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <br />\r\n");
#nullable restore
#line 35 "C:\Users\godti\source\repos\GrandBlue\GrandBlue\Pages\FrameData.cshtml"
                     if (item.ButtonID != "")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <img");
            BeginWriteAttribute("src", " src=\"", 1147, "\"", 1213, 1);
#nullable restore
#line 37 "C:\Users\godti\source\repos\GrandBlue\GrandBlue\Pages\FrameData.cshtml"
WriteAttributeValue("", 1153, Href(GrandBlue.Data.Properties.GetButtonURL(item.ButtonID)), 1153, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"input-image\"/>\r\n");
#nullable restore
#line 38 "C:\Users\godti\source\repos\GrandBlue\GrandBlue\Pages\FrameData.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 41 "C:\Users\godti\source\repos\GrandBlue\GrandBlue\Pages\FrameData.cshtml"
               Write(Html.DisplayFor(modelItem => item.Version));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 44 "C:\Users\godti\source\repos\GrandBlue\GrandBlue\Pages\FrameData.cshtml"
               Write(Html.DisplayFor(modelItem => item.Startup));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 47 "C:\Users\godti\source\repos\GrandBlue\GrandBlue\Pages\FrameData.cshtml"
               Write(Html.DisplayFor(modelItem => item.Active));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 50 "C:\Users\godti\source\repos\GrandBlue\GrandBlue\Pages\FrameData.cshtml"
               Write(Html.DisplayFor(modelItem => item.Recovery));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n");
#nullable restore
#line 52 "C:\Users\godti\source\repos\GrandBlue\GrandBlue\Pages\FrameData.cshtml"
                  
                    int i;
                    Int32.TryParse(item.OnBlock, out i);
                    if (i < 0)
                    {
                        if (i < -5)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td class=\"negative\">\r\n                                ");
#nullable restore
#line 60 "C:\Users\godti\source\repos\GrandBlue\GrandBlue\Pages\FrameData.cshtml"
                           Write(Html.DisplayFor(modelItem => item.OnBlock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n");
#nullable restore
#line 62 "C:\Users\godti\source\repos\GrandBlue\GrandBlue\Pages\FrameData.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td class=\"even\">\r\n                                ");
#nullable restore
#line 66 "C:\Users\godti\source\repos\GrandBlue\GrandBlue\Pages\FrameData.cshtml"
                           Write(Html.DisplayFor(modelItem => item.OnBlock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n");
#nullable restore
#line 68 "C:\Users\godti\source\repos\GrandBlue\GrandBlue\Pages\FrameData.cshtml"
                        }
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n                            ");
#nullable restore
#line 73 "C:\Users\godti\source\repos\GrandBlue\GrandBlue\Pages\FrameData.cshtml"
                       Write(Html.DisplayFor(modelItem => item.OnBlock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n");
#nullable restore
#line 75 "C:\Users\godti\source\repos\GrandBlue\GrandBlue\Pages\FrameData.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "C:\Users\godti\source\repos\GrandBlue\GrandBlue\Pages\FrameData.cshtml"
                  
                    Int32.TryParse(item.OnHit, out i);
                    if (i < 0)
                    {
                        if (i < -5)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td class=\"negative\">\r\n                                ");
#nullable restore
#line 84 "C:\Users\godti\source\repos\GrandBlue\GrandBlue\Pages\FrameData.cshtml"
                           Write(Html.DisplayFor(modelItem => item.OnHit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n");
#nullable restore
#line 86 "C:\Users\godti\source\repos\GrandBlue\GrandBlue\Pages\FrameData.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td class=\"even\">\r\n                                ");
#nullable restore
#line 90 "C:\Users\godti\source\repos\GrandBlue\GrandBlue\Pages\FrameData.cshtml"
                           Write(Html.DisplayFor(modelItem => item.OnHit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n");
#nullable restore
#line 92 "C:\Users\godti\source\repos\GrandBlue\GrandBlue\Pages\FrameData.cshtml"
                        }
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n                            ");
#nullable restore
#line 97 "C:\Users\godti\source\repos\GrandBlue\GrandBlue\Pages\FrameData.cshtml"
                       Write(Html.DisplayFor(modelItem => item.OnHit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n");
#nullable restore
#line 99 "C:\Users\godti\source\repos\GrandBlue\GrandBlue\Pages\FrameData.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\r\n                    ");
#nullable restore
#line 102 "C:\Users\godti\source\repos\GrandBlue\GrandBlue\Pages\FrameData.cshtml"
               Write(Html.DisplayFor(modelItem => item.Damage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 105 "C:\Users\godti\source\repos\GrandBlue\GrandBlue\Pages\FrameData.cshtml"
               Write(Html.DisplayFor(modelItem => item.GuardType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 108 "C:\Users\godti\source\repos\GrandBlue\GrandBlue\Pages\FrameData.cshtml"
               Write(Html.DisplayFor(modelItem => item.Notes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 111 "C:\Users\godti\source\repos\GrandBlue\GrandBlue\Pages\FrameData.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n    <br /><br />\r\n");
#nullable restore
#line 114 "C:\Users\godti\source\repos\GrandBlue\GrandBlue\Pages\FrameData.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GrandBlue.FrameDataModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GrandBlue.FrameDataModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GrandBlue.FrameDataModel>)PageContext?.ViewData;
        public GrandBlue.FrameDataModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
