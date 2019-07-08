#pragma checksum "C:\Users\SathianpornKhamdee\source\repos\Exam_Test\ExamTest_DevExtreme\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e403931a50779f51fc539c91699c5e11eb3f2621"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\SathianpornKhamdee\source\repos\Exam_Test\ExamTest_DevExtreme\Views\_ViewImports.cshtml"
using ExamTest_DevExtreme;

#line default
#line hidden
#line 3 "C:\Users\SathianpornKhamdee\source\repos\Exam_Test\ExamTest_DevExtreme\Views\_ViewImports.cshtml"
using DevExtreme.AspNet.Mvc;

#line default
#line hidden
#line 1 "C:\Users\SathianpornKhamdee\source\repos\Exam_Test\ExamTest_DevExtreme\Views\Home\Index.cshtml"
using ExamTest_DevExtreme.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e403931a50779f51fc539c91699c5e11eb3f2621", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3e6a5df3b39464caabaf45bef63b451b5a0f2e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 19, true);
            WriteLiteral("\r\n<h2>Home</h2>\r\n\r\n");
            EndContext();
            BeginContext(56, 891, false);
#line 5 "C:\Users\SathianpornKhamdee\source\repos\Exam_Test\ExamTest_DevExtreme\Views\Home\Index.cshtml"
Write(Html.DevExtreme().DataGrid<Order>()
    .ShowBorders(true)
    .DataSource(d => d.Mvc().Controller("Orders").LoadAction("Get").Key("OrderID"))
    .Columns(columns => {
        columns.AddFor(m => m.OrderID);
        columns.AddFor(m => m.OrderDate);
        columns.AddFor(m => m.CustomerName);
        columns.AddFor(m => m.ShipCountry);
        columns.AddFor(m => m.ShipCity);
    })
    .Paging(p => p.PageSize(10))
    .FilterRow(f => f.Visible(true))
    .HeaderFilter(f => f.Visible(true))
    .GroupPanel(p => p.Visible(true))
    .Grouping(g => g.AutoExpandAll(false))
    .RemoteOperations(true)
    .Summary(s => s
        .TotalItems(totalItems => {
            totalItems.AddFor(m => m.ShipCity).SummaryType(SummaryType.Count);
        })
        .GroupItems(groupItems => {
            groupItems.Add().SummaryType(SummaryType.Count);
        })
    )
);

#line default
#line hidden
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591