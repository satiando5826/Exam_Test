#pragma checksum "C:\Users\SathianpornKhamdee\source\repos\Exam_Test\ExamTest_DevExtreme\Areas\Admin\Views\Questions\old_Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d98c64f89ef9416e55c7977f0ed0ba40ffbd407d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Questions_old_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Questions/old_Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Questions/old_Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Questions_old_Index))]
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
#line 5 "C:\Users\SathianpornKhamdee\source\repos\Exam_Test\ExamTest_DevExtreme\Areas\Admin\Views\Questions\old_Index.cshtml"
using Exam_Test.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d98c64f89ef9416e55c7977f0ed0ba40ffbd407d", @"/Areas/Admin/Views/Questions/old_Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3e6a5df3b39464caabaf45bef63b451b5a0f2e8", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Questions_old_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Question>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Questions", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateQuestion", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(23, 130, true);
            WriteLiteral("\r\n<link rel=\"stylesheet\" type=\"text/css\" href=\"https://maxcdn.bootstrapcdn.com/font-awesome/4.6.3/css/font-awesome.min.css\" />\r\n\r\n");
            EndContext();
            BeginContext(178, 70, true);
            WriteLiteral("<h2>Questions</h2>\r\n<br /><br />\r\n      <div class=\"left\">\r\n          ");
            EndContext();
            BeginContext(248, 114, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d98c64f89ef9416e55c7977f0ed0ba40ffbd407d4895", async() => {
                BeginContext(330, 28, true);
                WriteLiteral("<i class=\"dx-icon-plus\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(362, 12, true);
            WriteLiteral("\r\n          ");
            EndContext();
            BeginContext(376, 1016, false);
#line 10 "C:\Users\SathianpornKhamdee\source\repos\Exam_Test\ExamTest_DevExtreme\Areas\Admin\Views\Questions\old_Index.cshtml"
      Write(Html.DevExtreme().List()
          .ID("list")
          .Grouped(true)
          .Visible(true)
          .SearchEnabled(true)
          .SelectionMode(ListSelectionMode.Single)
          .DataSource(d => d.Mvc().Controller("Questions").Key("questionId")
          .LoadAction("GetQuestions"))
          .DataSourceOptions(o => o.Group("Section.name")
          .SearchExpr(new string[] { "questionStr", "Section.name" }))
          .SelectedItems(new[] { Model.FirstOrDefault() })
          .ItemTemplate(item => new global::Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_template_writer) => {
    PushWriter(__razor_template_writer);
    BeginContext(901, 444, true);
    WriteLiteral(@"
                      <div>
                          <div class=""hotel"">
                              <div class=""name""><%= questionStr %></div>
                          </div>

                          <div class=""price-container"">
                              <div class=""price""><10></div>
                              <div class=""caption"">Point</div>
                          </div>
                      </div>
          ");
    EndContext();
    PopWriter();
}
))
.OnSelectionChanged("selectionChanged")
          );

#line default
#line hidden
            EndContext();
            BeginContext(1407, 433, true);
            WriteLiteral(@"



      </div>
<div class=""right"">
    <div class=""header"">
        <div class=""name-container"">
            <div class=""name""></div>
            <div class=""type""></div>
        </div>

        <div class=""price-container"">
            <div class=""price""></div>
            <div class=""caption"">Point</div>
        </div>
    </div>


    <div class=""address""></div>
    <div class=""description""></div>

    ");
            EndContext();
            BeginContext(1842, 124, false);
#line 56 "C:\Users\SathianpornKhamdee\source\repos\Exam_Test\ExamTest_DevExtreme\Areas\Admin\Views\Questions\old_Index.cshtml"
Write(Html.DevExtreme().SpeedDialAction()
          .ID("action-add")
          .Icon("add")
          .OnClick("addRow")
    );

#line default
#line hidden
            EndContext();
            BeginContext(1967, 4017, true);
            WriteLiteral(@"
    <div id=""action-remove""></div>
    <div id=""action-edit""></div>

</div>

<script>
    
    function selectionChanged(e) {
        var question = e.addedItems[0];
        var tile = $(""#tile"").dxTileView(""instance"");
        //tile.option(""dataSource"", hotel.Images);
        $("".header .name"").text(question.questionStr);
        $("".header .price"").text(""10"");// $("".header .price"").text(""$"" + hotel.Price);
        //$("".header .type"").removeClass(""diamond platinum gold"");
        //$("".header .type"").addClass(question.type.toLowerCase());
        $("".right .description"").text(""Description"");//$("".right .description"").text(hotel.Description);
        // $("".right .address"").text(hotel.Postal_Code + "", "" + hotel.Address);
    }

</script>

<style>

    .left {
        float: left;
        width: 330px;
        height: 470px;
        padding: 20px;
        background: rgba(191, 191, 191, 0.15);
        margin-right: 30px;
    }

    .right {
        overflow: hidden;
    }");
            WriteLiteral(@"

    .left #list .dx-list-group-header {
        color: #f05b41;
        font-weight: normal;
        font-size: 18px;
    }

    .left #list .hotel {
        float: left;
    }

        .left #list .hotel .name {
            font-weight: bold;
        }

    .right .header {
        height: 70px;
    }

        .right .header .name-container {
            float: left;
        }

        .right .header .name {
            font-size: 30px;
            font-weight: bold;
        }

        .right .header .price-container {
            padding-top: 27px;
        }

    .right .name-container .type {
        margin-top: 0;
    }

    .right #tile {
        margin: 0 -12px 0 -12px;
    }

    .right .tile-image {
        height: 100%;
        width: 100%;
        background-size: cover;
    }

    .right .address {
        padding-top: 30px;
        font-size: 18px;
        opacity: 0.7;
    }

    .right .description {
        margin: 10px 0;
    }

    .pr");
            WriteLiteral(@"ice-container {
        float: right;
        padding-top: 13px;
    }

        .price-container > div {
            display: inline-block;
        }

        .price-container .price {
            font-size: 25px;
        }

        .price-container .caption {
            font-size: 11px;
            line-height: 12px;
            padding-left: 2px;
            opacity: 0.7;
        }


    .price-container {
        float: right;
        padding-top: 13px;
    }

        .price-container > div {
            display: inline-block;
        }

        .price-container .price {
            font-size: 25px;
        }

        .price-container .caption {
            font-size: 11px;
            line-height: 12px;
            padding-left: 2px;
            opacity: 0.7;
        }




    .demo-container {
        display: flex;
        justify-content: center;
        height: 450px;
    }

    .buttons-demo {
        width: 600px;
        align-self: center;
    ");
            WriteLiteral(@"}

    .buttons-header {
        display: flex;
        flex-wrap: nowrap;
    }

        .buttons-header > div {
            flex-grow: 0;
            flex-basis: 120px;
            height: 30px;
        }

    .types {
        width: 120px;
        display: flex;
        flex-direction: column;
        float: left;
    }

        .types > div {
            flex-grow: 1;
            padding: 10px;
            height: 30px;
            line-height: 20px;
            font-weight: bold;
            opacity: 0.7;
        }

    .buttons {
        display: flex;
        flex-wrap: wrap;
        margin-left: 120px;
    }

        .buttons > div {
            flex-basis: 120px;
            height: 50px;
        }




    /*form*/

    .first-group,
    .second-group {
        padding: 20px;
    }

    .second-group {
        background-color: rgba(191, 191, 191, 0.15);
    }
</style>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Question>> Html { get; private set; }
    }
}
#pragma warning restore 1591
