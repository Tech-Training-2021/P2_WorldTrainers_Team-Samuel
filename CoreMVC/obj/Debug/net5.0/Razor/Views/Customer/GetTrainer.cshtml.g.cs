#pragma checksum "C:\Users\Kajal Padhiyar\Documents\CCL\Try\CoreMVC\CoreMVC\Views\Customer\GetTrainer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05175470b0270245823dcd4a329073cab9b11e4d"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05175470b0270245823dcd4a329073cab9b11e4d", @"/Views/Customer/GetTrainer.cshtml")]
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
<h1>Get Trainers</h1>
<br />
<br />
<input class=""form-control"" type=""text"" id=""myInput"" onkeyup=""myFunction()"" placeholder=""Search for Trainer Or Skill"" title=""Type in a name"">


<br />
<br />

<table class=""table table-bordered"" id=""myTable"">
    <thead>
        <tr>
            <th>
                ");
#nullable restore
#line 20 "C:\Users\Kajal Padhiyar\Documents\CCL\Try\CoreMVC\CoreMVC\Views\Customer\GetTrainer.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\Kajal Padhiyar\Documents\CCL\Try\CoreMVC\CoreMVC\Views\Customer\GetTrainer.cshtml"
           Write(Html.DisplayNameFor(model => model.Education));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\Kajal Padhiyar\Documents\CCL\Try\CoreMVC\CoreMVC\Views\Customer\GetTrainer.cshtml"
           Write(Html.DisplayNameFor(model => model.Experience));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\Users\Kajal Padhiyar\Documents\CCL\Try\CoreMVC\CoreMVC\Views\Customer\GetTrainer.cshtml"
           Write(Html.DisplayNameFor(model => model.Skill));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "C:\Users\Kajal Padhiyar\Documents\CCL\Try\CoreMVC\CoreMVC\Views\Customer\GetTrainer.cshtml"
           Write(Html.DisplayNameFor(model => model.Domain));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "C:\Users\Kajal Padhiyar\Documents\CCL\Try\CoreMVC\CoreMVC\Views\Customer\GetTrainer.cshtml"
           Write(Html.DisplayNameFor(model => model.F_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 38 "C:\Users\Kajal Padhiyar\Documents\CCL\Try\CoreMVC\CoreMVC\Views\Customer\GetTrainer.cshtml"
           Write(Html.DisplayNameFor(model => model.L_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 41 "C:\Users\Kajal Padhiyar\Documents\CCL\Try\CoreMVC\CoreMVC\Views\Customer\GetTrainer.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 46 "C:\Users\Kajal Padhiyar\Documents\CCL\Try\CoreMVC\CoreMVC\Views\Customer\GetTrainer.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr class=\"prod\">\r\n                <td>\r\n                    ");
#nullable restore
#line 50 "C:\Users\Kajal Padhiyar\Documents\CCL\Try\CoreMVC\CoreMVC\Views\Customer\GetTrainer.cshtml"
               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 53 "C:\Users\Kajal Padhiyar\Documents\CCL\Try\CoreMVC\CoreMVC\Views\Customer\GetTrainer.cshtml"
               Write(Html.DisplayFor(modelItem => item.Education));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 56 "C:\Users\Kajal Padhiyar\Documents\CCL\Try\CoreMVC\CoreMVC\Views\Customer\GetTrainer.cshtml"
               Write(Html.DisplayFor(modelItem => item.Experience));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 59 "C:\Users\Kajal Padhiyar\Documents\CCL\Try\CoreMVC\CoreMVC\Views\Customer\GetTrainer.cshtml"
               Write(Html.DisplayFor(modelItem => item.Skill));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 62 "C:\Users\Kajal Padhiyar\Documents\CCL\Try\CoreMVC\CoreMVC\Views\Customer\GetTrainer.cshtml"
               Write(Html.DisplayFor(modelItem => item.Domain));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 65 "C:\Users\Kajal Padhiyar\Documents\CCL\Try\CoreMVC\CoreMVC\Views\Customer\GetTrainer.cshtml"
               Write(Html.DisplayFor(modelItem => item.F_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 68 "C:\Users\Kajal Padhiyar\Documents\CCL\Try\CoreMVC\CoreMVC\Views\Customer\GetTrainer.cshtml"
               Write(Html.DisplayFor(modelItem => item.L_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 71 "C:\Users\Kajal Padhiyar\Documents\CCL\Try\CoreMVC\CoreMVC\Views\Customer\GetTrainer.cshtml"
               Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 74 "C:\Users\Kajal Padhiyar\Documents\CCL\Try\CoreMVC\CoreMVC\Views\Customer\GetTrainer.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>
<h3 id=""hidd"" style=""text-align:center;"" hidden>No Trainer found</h3>
<script>
    function myFunction() {
        var input, filter, table, tr, td, i, txtValue, id, cl, c = 0,ts;
        input = document.getElementById(""myInput"");
        id = document.getElementById(""hidd"");
        cl = document.getElementsByClassName(""prod"");
        cl = cl.length;
        console.log(cl);
        filter = input.value.toUpperCase();
        table = document.getElementById(""myTable"");
        tr = table.getElementsByTagName(""tr"");
        for (i = 0; i < tr.length; i++) {
            td = tr[i].getElementsByTagName(""td"")[5];
            ts = tr[i].getElementsByTagName(""td"")[3];
            if (td||ts) {
                txtValue = td.textContent || td.innerText;
                txtValue2 = ts.textContent || ts.innerText;
                if (txtValue.toUpperCase().indexOf(filter) > -1 || txtValue2.toUpperCase().indexOf(filter)>-1) {
                    id.style.display = ""none"";
 ");
            WriteLiteral(@"                   tr[i].style.display = """";
                } else {
                    tr[i].style.display = ""none"";
                    c += 1;
                    console.log(c);
                }
            }
        }
        console.log(c, cl);
        if (c == cl) {
            console.log(""inside if"");
            document.getElementById(""hidd"").style.display = ""block"";
            //id.style.display = ""block"";
        }
    }
</script>
");
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
