#pragma checksum "C:\Users\SathianpornKhamdee\source\repos\Exam_Test\ExamTest_DevExtreme\Areas\Admin\Views\Exams\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d94ba97c801a3b15843c8ec4cf2c99a1f8e32e37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Exams_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Exams/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Exams/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Exams_Index))]
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
#line 1 "C:\Users\SathianpornKhamdee\source\repos\Exam_Test\ExamTest_DevExtreme\Areas\Admin\Views\_ViewImports.cshtml"
using ExamTest_DevExtreme;

#line default
#line hidden
#line 3 "C:\Users\SathianpornKhamdee\source\repos\Exam_Test\ExamTest_DevExtreme\Areas\Admin\Views\_ViewImports.cshtml"
using DevExtreme.AspNet.Mvc;

#line default
#line hidden
#line 1 "C:\Users\SathianpornKhamdee\source\repos\Exam_Test\ExamTest_DevExtreme\Areas\Admin\Views\Exams\Index.cshtml"
using Exam_Test.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d94ba97c801a3b15843c8ec4cf2c99a1f8e32e37", @"/Areas/Admin/Views/Exams/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3e6a5df3b39464caabaf45bef63b451b5a0f2e8", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Exams_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(25, 29, true);
            WriteLiteral("<h2>Exam</h2>\r\n<br /><br />\r\n");
            EndContext();
            BeginContext(56, 1428, false);
#line 4 "C:\Users\SathianpornKhamdee\source\repos\Exam_Test\ExamTest_DevExtreme\Areas\Admin\Views\Exams\Index.cshtml"
Write(Html.DevExtreme().DataGrid<Exam_Test.Models.Exam>()

    .ID("gridContainer")
    .ShowBorders(true)
    .Paging(paging => paging.Enabled(false))
    .Editing(editing =>
    {
        editing.Mode(GridEditMode.Row);
        editing.AllowAdding(true);
        editing.AllowDeleting(true);
        editing.AllowUpdating(true);
    })
    .Columns(columns =>
    {
        columns.AddFor(m => m.examName);
        columns.AddFor(m => m.subjectId)
            .Lookup(Lookup => Lookup
                .DataSource(d => d.Mvc().Controller("Exam").LoadAction("GetSubjects").Key("subjectId"))
                .DisplayExpr("name")
                .ValueExpr("subjectId")
            );

    })
    .DataSource(d => d.Mvc()
        .Controller("Exams")
        .LoadAction("GetExams")
        .UpdateAction("Put")
        .InsertAction("Post")
        .DeleteAction("Delete")
        .Key("examId")
        
        
    )
    .OnEditingStart(item => new global::Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_template_writer) => {
    PushWriter(__razor_template_writer);
    BeginContext(1029, 43, true);
    WriteLiteral(" function(e) { logEvent(\"EditingStart\"); } ");
    EndContext();
    PopWriter();
}
))
.OnInitNewRow(item => new global::Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_template_writer) => {
    PushWriter(__razor_template_writer);
    BeginContext(1103, 41, true);
    WriteLiteral(" function(e) { logEvent(\"InitNewRow\"); } ");
    EndContext();
    PopWriter();
}
))
.OnRowInserting(item => new global::Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_template_writer) => {
    PushWriter(__razor_template_writer);
    BeginContext(1177, 43, true);
    WriteLiteral(" function(e) { logEvent(\"RowInserting\"); } ");
    EndContext();
    PopWriter();
}
))
.OnRowInserted(item => new global::Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_template_writer) => {
    PushWriter(__razor_template_writer);
    BeginContext(1252, 42, true);
    WriteLiteral(" function(e) { logEvent(\"RowInserted\"); } ");
    EndContext();
    PopWriter();
}
))
.OnRowUpdating(item => new global::Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_template_writer) => {
    PushWriter(__razor_template_writer);
    BeginContext(1326, 42, true);
    WriteLiteral(" function(e) { logEvent(\"RowUpdating\"); } ");
    EndContext();
    PopWriter();
}
))
.OnRowUpdated(item => new global::Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_template_writer) => {
    PushWriter(__razor_template_writer);
    BeginContext(1399, 41, true);
    WriteLiteral(" function(e) { logEvent(\"RowUpdated\"); } ");
    EndContext();
    PopWriter();
}
))
.OnRowRemoving(item => new global::Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_template_writer) => {
    PushWriter(__razor_template_writer);
    BeginContext(1472, 42, true);
    WriteLiteral(" function(e) { logEvent(\"RowRemoving\"); } ");
    EndContext();
    PopWriter();
}
))
.OnRowRemoved(item => new global::Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_template_writer) => {
    PushWriter(__razor_template_writer);
    BeginContext(1545, 41, true);
    WriteLiteral(" function(e) { logEvent(\"RowRemoved\"); } ");
    EndContext();
    PopWriter();
}
))
);

#line default
#line hidden
            EndContext();
            BeginContext(1597, 115, true);
            WriteLiteral("\r\n\r\n<div id=\"events\">\r\n    <div>\r\n        <div class=\"caption\">\r\n            Fired events\r\n        </div>\r\n        ");
            EndContext();
            BeginContext(1714, 155, false);
#line 52 "C:\Users\SathianpornKhamdee\source\repos\Exam_Test\ExamTest_DevExtreme\Areas\Admin\Views\Exams\Index.cshtml"
    Write(Html.DevExtreme().Button()
            .ID("clear")
            .Text("Clear")
            .OnClick(item => new global::Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_template_writer) => {
    PushWriter(__razor_template_writer);
    BeginContext(1824, 41, true);
    WriteLiteral(" function() { $(\"#events ul\").empty(); } ");
    EndContext();
    PopWriter();
}
))
        );

#line default
#line hidden
            EndContext();
            BeginContext(1884, 233, true);
            WriteLiteral("\r\n    </div>\r\n    <ul></ul>\r\n</div>\r\n\r\n<script>\r\n    function logEvent(eventName) {\r\n        var logList = $(\"#events ul\"),\r\n            newItem = $(\"<li>\", { text: eventName });\r\n\r\n        logList.prepend(newItem);\r\n    }\r\n</script>");
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