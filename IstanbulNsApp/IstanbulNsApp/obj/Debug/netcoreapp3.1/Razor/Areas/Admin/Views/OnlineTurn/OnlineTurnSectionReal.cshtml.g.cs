#pragma checksum "C:\Users\Orxan\source\repos\istanbulns\IstanbulNsApp\IstanbulNsApp\Areas\Admin\Views\OnlineTurn\OnlineTurnSectionReal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76cdde8832bdd692a82d24aa699a28f7b7440983"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_OnlineTurn_OnlineTurnSectionReal), @"mvc.1.0.view", @"/Areas/Admin/Views/OnlineTurn/OnlineTurnSectionReal.cshtml")]
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
#line 1 "C:\Users\Orxan\source\repos\istanbulns\IstanbulNsApp\IstanbulNsApp\Areas\Admin\Views\_ViewImports.cshtml"
using IstanbulNsApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Orxan\source\repos\istanbulns\IstanbulNsApp\IstanbulNsApp\Areas\Admin\Views\_ViewImports.cshtml"
using IstanbulNsApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76cdde8832bdd692a82d24aa699a28f7b7440983", @"/Areas/Admin/Views/OnlineTurn/OnlineTurnSectionReal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1eb9afe3ab260dca182ff994749f923823ef24ae", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_OnlineTurn_OnlineTurnSectionReal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IstanbulNsApp.Areas.Admin.Models.OnlineTurnVm>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NewQuery", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "OnlineTurn", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DisableR", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("my_file"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddResultR", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EnableR", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-right:10px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EndSessionR", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Orxan\source\repos\istanbulns\IstanbulNsApp\IstanbulNsApp\Areas\Admin\Views\OnlineTurn\OnlineTurnSectionReal.cshtml"
  
    ViewData["Title"] = "OnlineTurnSection";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"<style>
    .table {
        position: relative;
    }

        .table .thd {
            position: sticky;
            top: 0px;
            z-index: 2;
        }

    .thd {
        background-color: #4e73df;
        color: white;
    }

    thead {
        border-radius: 20px;
    }

    tr {
        width: 100%;
    }

    tr, th {
        text-align: center;
    }

    .operations {
        display: flex;
        flex-direction: row;
        font-size: 20px;
    }

        .operations > form {
            margin-left: 10px;
            margin-top: 1px;
        }

    .td > a {
        margin-right: 10px;
    }
    /*table th:first-child {
        border-radius: 15px 0 0 15px;
    }

    table th:last-child {
        border-radius: 0 15px 15px 0;
    }*/
</style>
<div class=""row"">
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76cdde8832bdd692a82d24aa699a28f7b74409839778", async() => {
                WriteLiteral("Yeni n??vb??");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n<div class=\"row\" style=\"height:500px;overflow-y:scroll;\">\r\n    <h4>Aktiv N??vb??</h4>\r\n\r\n\r\n    <div class=\"col-12\">\r\n");
#nullable restore
#line 65 "C:\Users\Orxan\source\repos\istanbulns\IstanbulNsApp\IstanbulNsApp\Areas\Admin\Views\OnlineTurn\OnlineTurnSectionReal.cshtml"
         if (Model is { })
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <table class=""table"">
                <thead>
                    <tr>
                        <th class=""thd"" scope=""col"">Kod</th>
                        <th class=""thd"" scope=""col"">Xidm??t</th>
                        <th class=""thd"" scope=""col"">H??kim</th>
                        <th class=""thd"" scope=""col"">Qiym??t</th>
                        <th class=""thd"" scope=""col"">S??ra Tarixi</th>
                        <th class=""thd"" scope=""col"">Sifari?? Tarixi</th>
                        <th class=""thd"" scope=""col"">??laq??</th>
                        <th class=""thd"" scope=""col"">Cavab</th>
                        <th class=""thd"" scope=""col"">Prosesl??r</th>

                    </tr>
                </thead>
                <tbody class=""p-2"">
");
#nullable restore
#line 83 "C:\Users\Orxan\source\repos\istanbulns\IstanbulNsApp\IstanbulNsApp\Areas\Admin\Views\OnlineTurn\OnlineTurnSectionReal.cshtml"
                     foreach (var item in Model.queries.Where(a => a.IsSchedule == 1))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <th>");
#nullable restore
#line 86 "C:\Users\Orxan\source\repos\istanbulns\IstanbulNsApp\IstanbulNsApp\Areas\Admin\Views\OnlineTurn\OnlineTurnSectionReal.cshtml"
                           Write(item.Code);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <td>");
#nullable restore
#line 87 "C:\Users\Orxan\source\repos\istanbulns\IstanbulNsApp\IstanbulNsApp\Areas\Admin\Views\OnlineTurn\OnlineTurnSectionReal.cshtml"
                           Write(item.Doctor.Service.ServiceNames.Where(a => a.LangId == 1).FirstOrDefault().Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 88 "C:\Users\Orxan\source\repos\istanbulns\IstanbulNsApp\IstanbulNsApp\Areas\Admin\Views\OnlineTurn\OnlineTurnSectionReal.cshtml"
                           Write(item.Doctor.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 89 "C:\Users\Orxan\source\repos\istanbulns\IstanbulNsApp\IstanbulNsApp\Areas\Admin\Views\OnlineTurn\OnlineTurnSectionReal.cshtml"
                           Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" AZN</td>\r\n                            <td>");
#nullable restore
#line 90 "C:\Users\Orxan\source\repos\istanbulns\IstanbulNsApp\IstanbulNsApp\Areas\Admin\Views\OnlineTurn\OnlineTurnSectionReal.cshtml"
                           Write(item.QueryDate.ToString("MM/dd/yyyy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 91 "C:\Users\Orxan\source\repos\istanbulns\IstanbulNsApp\IstanbulNsApp\Areas\Admin\Views\OnlineTurn\OnlineTurnSectionReal.cshtml"
                           Write(item.ServeDate.ToString("MM/dd/yyyy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 92 "C:\Users\Orxan\source\repos\istanbulns\IstanbulNsApp\IstanbulNsApp\Areas\Admin\Views\OnlineTurn\OnlineTurnSectionReal.cshtml"
                           Write(item.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 93 "C:\Users\Orxan\source\repos\istanbulns\IstanbulNsApp\IstanbulNsApp\Areas\Admin\Views\OnlineTurn\OnlineTurnSectionReal.cshtml"
                             if (item.Pdf is null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td style=\"color:red;\"><i class=\"fas fa-times-circle\"></i></td>\r\n");
#nullable restore
#line 96 "C:\Users\Orxan\source\repos\istanbulns\IstanbulNsApp\IstanbulNsApp\Areas\Admin\Views\OnlineTurn\OnlineTurnSectionReal.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td style=\"color:green;\"><i class=\"fas fa-check-circle\"></i></td>\r\n");
#nullable restore
#line 100 "C:\Users\Orxan\source\repos\istanbulns\IstanbulNsApp\IstanbulNsApp\Areas\Admin\Views\OnlineTurn\OnlineTurnSectionReal.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <td style=\"float:left;\" class=\"operations\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76cdde8832bdd692a82d24aa699a28f7b744098316708", async() => {
                WriteLiteral("<i class=\"fas fa-pause\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-query_id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 103 "C:\Users\Orxan\source\repos\istanbulns\IstanbulNsApp\IstanbulNsApp\Areas\Admin\Views\OnlineTurn\OnlineTurnSectionReal.cshtml"
                                                                                                                WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["query_id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-query_id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["query_id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76cdde8832bdd692a82d24aa699a28f7b744098319350", async() => {
                WriteLiteral("\r\n");
                WriteLiteral("                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "76cdde8832bdd692a82d24aa699a28f7b744098319680", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 107 "C:\Users\Orxan\source\repos\istanbulns\IstanbulNsApp\IstanbulNsApp\Areas\Admin\Views\OnlineTurn\OnlineTurnSectionReal.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.File);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "76cdde8832bdd692a82d24aa699a28f7b744098321333", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
#nullable restore
#line 108 "C:\Users\Orxan\source\repos\istanbulns\IstanbulNsApp\IstanbulNsApp\Areas\Admin\Views\OnlineTurn\OnlineTurnSectionReal.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.query_id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 108 "C:\Users\Orxan\source\repos\istanbulns\IstanbulNsApp\IstanbulNsApp\Areas\Admin\Views\OnlineTurn\OnlineTurnSectionReal.cshtml"
                                                                      WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    <button type=\"submit\" class=\"btn btn-outline-primary file-submit\">Y??kl??</button>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                            </td>\r\n\r\n                        </tr>\r\n");
#nullable restore
#line 115 "C:\Users\Orxan\source\repos\istanbulns\IstanbulNsApp\IstanbulNsApp\Areas\Admin\Views\OnlineTurn\OnlineTurnSectionReal.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </tbody>\r\n            </table>\r\n");
#nullable restore
#line 119 "C:\Users\Orxan\source\repos\istanbulns\IstanbulNsApp\IstanbulNsApp\Areas\Admin\Views\OnlineTurn\OnlineTurnSectionReal.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n<div class=\"row mt-2\" style=\"height:500px;overflow-y:scroll;\">\r\n    <h4>Deaktiv N??vb??</h4>\r\n    <div class=\"col-12\">\r\n");
#nullable restore
#line 125 "C:\Users\Orxan\source\repos\istanbulns\IstanbulNsApp\IstanbulNsApp\Areas\Admin\Views\OnlineTurn\OnlineTurnSectionReal.cshtml"
         if (Model is { })
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <table class=""table"">
                <thead>
                    <tr>
                        <th class=""thd"" scope=""col"">Kod</th>
                        <th class=""thd"" scope=""col"">Xidm??t</th>
                        <th class=""thd"" scope=""col"">H??kim</th>
                        <th class=""thd"" scope=""col"">Qiym??t</th>
                        <th class=""thd"" scope=""col"">S??ra Tarixi</th>
                        <th class=""thd"" scope=""col"">Sifari?? Tarixi</th>
                        <th class=""thd"" scope=""col"">??laq??</th>
                        <th class=""thd"" scope=""col"">Cavab</th>
                        <th class=""thd"" scope=""col"">Prosesl??r</th>

                    </tr>
                </thead>
                <tbody class=""p-2"">
");
#nullable restore
#line 143 "C:\Users\Orxan\source\repos\istanbulns\IstanbulNsApp\IstanbulNsApp\Areas\Admin\Views\OnlineTurn\OnlineTurnSectionReal.cshtml"
                     foreach (var item in Model.queries.Where(a => a.IsSchedule == 0))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <th>");
#nullable restore
#line 146 "C:\Users\Orxan\source\repos\istanbulns\IstanbulNsApp\IstanbulNsApp\Areas\Admin\Views\OnlineTurn\OnlineTurnSectionReal.cshtml"
                           Write(item.Code);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <td>");
#nullable restore
#line 147 "C:\Users\Orxan\source\repos\istanbulns\IstanbulNsApp\IstanbulNsApp\Areas\Admin\Views\OnlineTurn\OnlineTurnSectionReal.cshtml"
                           Write(item.Doctor.Service.ServiceNames.Where(a => a.LangId == 1).FirstOrDefault().Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 148 "C:\Users\Orxan\source\repos\istanbulns\IstanbulNsApp\IstanbulNsApp\Areas\Admin\Views\OnlineTurn\OnlineTurnSectionReal.cshtml"
                           Write(item.Doctor.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 149 "C:\Users\Orxan\source\repos\istanbulns\IstanbulNsApp\IstanbulNsApp\Areas\Admin\Views\OnlineTurn\OnlineTurnSectionReal.cshtml"
                           Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" AZN</td>\r\n                            <td>");
#nullable restore
#line 150 "C:\Users\Orxan\source\repos\istanbulns\IstanbulNsApp\IstanbulNsApp\Areas\Admin\Views\OnlineTurn\OnlineTurnSectionReal.cshtml"
                           Write(item.QueryDate.ToString("MM/dd/yyyy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 151 "C:\Users\Orxan\source\repos\istanbulns\IstanbulNsApp\IstanbulNsApp\Areas\Admin\Views\OnlineTurn\OnlineTurnSectionReal.cshtml"
                           Write(item.ServeDate.ToString("MM/dd/yyyy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 152 "C:\Users\Orxan\source\repos\istanbulns\IstanbulNsApp\IstanbulNsApp\Areas\Admin\Views\OnlineTurn\OnlineTurnSectionReal.cshtml"
                           Write(item.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 153 "C:\Users\Orxan\source\repos\istanbulns\IstanbulNsApp\IstanbulNsApp\Areas\Admin\Views\OnlineTurn\OnlineTurnSectionReal.cshtml"
                             if (item.Pdf is null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td style=\"color:red;\"><i class=\"fas fa-times-circle\"></i></td>\r\n");
#nullable restore
#line 156 "C:\Users\Orxan\source\repos\istanbulns\IstanbulNsApp\IstanbulNsApp\Areas\Admin\Views\OnlineTurn\OnlineTurnSectionReal.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td style=\"color:green;\"><i class=\"fas fa-check-circle\"></i></td>\r\n");
#nullable restore
#line 160 "C:\Users\Orxan\source\repos\istanbulns\IstanbulNsApp\IstanbulNsApp\Areas\Admin\Views\OnlineTurn\OnlineTurnSectionReal.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <td style=\"float:left;\" class=\"operations\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76cdde8832bdd692a82d24aa699a28f7b744098331403", async() => {
                WriteLiteral("<i class=\"fas fa-play\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-query_id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 163 "C:\Users\Orxan\source\repos\istanbulns\IstanbulNsApp\IstanbulNsApp\Areas\Admin\Views\OnlineTurn\OnlineTurnSectionReal.cshtml"
                                                                                           WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["query_id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-query_id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["query_id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76cdde8832bdd692a82d24aa699a28f7b744098334106", async() => {
                WriteLiteral("<i class=\"fas fa-trash-alt\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_14.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_14);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-query_id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 164 "C:\Users\Orxan\source\repos\istanbulns\IstanbulNsApp\IstanbulNsApp\Areas\Admin\Views\OnlineTurn\OnlineTurnSectionReal.cshtml"
                                                                                               WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["query_id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-query_id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["query_id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n                            </td>\r\n\r\n                        </tr>\r\n");
#nullable restore
#line 170 "C:\Users\Orxan\source\repos\istanbulns\IstanbulNsApp\IstanbulNsApp\Areas\Admin\Views\OnlineTurn\OnlineTurnSectionReal.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </tbody>\r\n            </table>\r\n");
#nullable restore
#line 174 "C:\Users\Orxan\source\repos\istanbulns\IstanbulNsApp\IstanbulNsApp\Areas\Admin\Views\OnlineTurn\OnlineTurnSectionReal.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        //$(\"input[type=\'image\']\").click(function () {\r\n        //    $(\"input[id=\'my_file\']\").click(function () {\r\n        //        $(\".file-submit\").show()\r\n        //    });\r\n        //});\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IstanbulNsApp.Areas.Admin.Models.OnlineTurnVm> Html { get; private set; }
    }
}
#pragma warning restore 1591
