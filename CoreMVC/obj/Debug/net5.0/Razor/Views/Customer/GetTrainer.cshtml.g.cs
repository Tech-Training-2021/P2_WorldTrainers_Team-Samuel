#pragma checksum "C:\Users\Kajal Padhiyar\Documents\CCL\Try\CoreMVC\CoreMVC\Views\Customer\GetTrainer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "861a325fdff60027f951cfb3c4d60b5e8635646a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_GetTrainer), @"mvc.1.0.view", @"/Views/Customer/GetTrainer.cshtml")]
namespace AspNetCore
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
#line 1 "C:\Users\Kajal Padhiyar\Documents\CCL\Try\CoreMVC\CoreMVC\Views\_ViewImports.cshtml"
using CoreMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kajal Padhiyar\Documents\CCL\Try\CoreMVC\CoreMVC\Views\_ViewImports.cshtml"
using CoreMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"861a325fdff60027f951cfb3c4d60b5e8635646a", @"/Views/Customer/GetTrainer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e49ef1b62a3bca90a51ee9002da6167d250edae6", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_GetTrainer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CoreMVC.Models.Skillsett>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Kajal Padhiyar\Documents\CCL\Try\CoreMVC\CoreMVC\Views\Customer\GetTrainer.cshtml"
  
    ViewData["Title"] = "GetTrainer";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Get Trainer</h1>
<br />
<br />
<input type=""text"" id=""myInput"" onkeyup=""myFunction()"" placeholder=""Search for Trainer name.."" title=""Type in a name"">
<br /><br />

<table class=""table table-bordered"" id=""myTable"">
    <thead>
        <tr>
            <th>
                ");
#nullable restore
#line 17 "C:\Users\Kajal Padhiyar\Documents\CCL\Try\CoreMVC\CoreMVC\Views\Customer\GetTrainer.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\Kajal Padhiyar\Documents\CCL\Try\CoreMVC\CoreMVC\Views\Customer\GetTrainer.cshtml"
           Write(Html.DisplayNameFor(model => model.Education));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\Kajal Padhiyar\Documents\CCL\Try\CoreMVC\CoreMVC\Views\Customer\GetTrainer.cshtml"
           Write(Html.DisplayNameFor(model => model.Experience));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\Kajal Padhiyar\Documents\CCL\Try\CoreMVC\CoreMVC\Views\Customer\GetTrainer.cshtml"
           Write(Html.DisplayNameFor(model => model.Skill));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\Users\Kajal Padhiyar\Documents\CCL\Try\CoreMVC\CoreMVC\Views\Customer\GetTrainer.cshtml"
           Write(Html.DisplayNameFor(model => model.Domain));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "C:\Users\Kajal Padhiyar\Documents\CCL\Try\CoreMVC\CoreMVC\Views\Customer\GetTrainer.cshtml"
           Write(Html.DisplayNameFor(model => model.F_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "C:\Users\Kajal Padhiyar\Documents\CCL\Try\CoreMVC\CoreMVC\Views\Customer\GetTrainer.cshtml"
           Write(Html.DisplayNameFor(model => model.L_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 38 "C:\Users\Kajal Padhiyar\Documents\CCL\Try\CoreMVC\CoreMVC\Views\Customer\GetTrainer.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 44 "C:\Users\Kajal Padhiyar\Documents\CCL\Try\CoreMVC\CoreMVC\Views\Customer\GetTrainer.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr class=\"prod\">\r\n                <td>\r\n                    ");
#nullable restore
#line 48 "C:\Users\Kajal Padhiyar\Documents\CCL\Try\CoreMVC\CoreMVC\Views\Customer\GetTrainer.cshtml"
               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 51 "C:\Users\Kajal Padhiyar\Documents\CCL\Try\CoreMVC\CoreMVC\Views\Customer\GetTrainer.cshtml"
               Write(Html.DisplayFor(modelItem => item.Education));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 54 "C:\Users\Kajal Padhiyar\Documents\CCL\Try\CoreMVC\CoreMVC\Views\Customer\GetTrainer.cshtml"
               Write(Html.DisplayFor(modelItem => item.Experience));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 57 "C:\Users\Kajal Padhiyar\Documents\CCL\Try\CoreMVC\CoreMVC\Views\Customer\GetTrainer.cshtml"
               Write(Html.DisplayFor(modelItem => item.Skill));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 60 "C:\Users\Kajal Padhiyar\Documents\CCL\Try\CoreMVC\CoreMVC\Views\Customer\GetTrainer.cshtml"
               Write(Html.DisplayFor(modelItem => item.Domain));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 63 "C:\Users\Kajal Padhiyar\Documents\CCL\Try\CoreMVC\CoreMVC\Views\Customer\GetTrainer.cshtml"
               Write(Html.DisplayFor(modelItem => item.F_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 66 "C:\Users\Kajal Padhiyar\Documents\CCL\Try\CoreMVC\CoreMVC\Views\Customer\GetTrainer.cshtml"
               Write(Html.DisplayFor(modelItem => item.L_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 69 "C:\Users\Kajal Padhiyar\Documents\CCL\Try\CoreMVC\CoreMVC\Views\Customer\GetTrainer.cshtml"
               Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 72 "C:\Users\Kajal Padhiyar\Documents\CCL\Try\CoreMVC\CoreMVC\Views\Customer\GetTrainer.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>
<h3 id=""hidd"" hidden style=""text-align:center;"">No Trainer found</h3>
<script>

    function myFunction() {
        var input, filter, table, tr, td, i, txtValue, id, cl, c = 0;
        input = document.getElementById(""myInput"");
        id = document.getElementById(""hidd"");
        cl = document.getElementsByClassName(""prod"");
        cl = cl.length;
        filter = input.value.toUpperCase();
        table = document.getElementById(""myTable"");
        tr = table.getElementsByTagName(""tr"");
        for (i = 0; i < tr.length; i++) {
            td = tr[i].getElementsByTagName(""td"")[5];
            if (td) {
                txtValue = td.textContent || td.innerText;
                if (txtValue.toUpperCase().indexOf(filter) > -1) {
                    id.style.display = ""none"";
                    tr[i].style.display = """";
                } else {
                    tr[i].style.display = ""none"";
                    c += 1;
                }
            }
       ");
            WriteLiteral(" }\r\n        if (c == cl) {\r\n            id.style.display = \"block\";\r\n        }\r\n    }\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CoreMVC.Models.Skillsett>> Html { get; private set; }
    }
}
#pragma warning restore 1591
