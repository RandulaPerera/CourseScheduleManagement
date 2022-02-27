#pragma checksum "C:\Project\CourseScheduleManagement\CourseSheduleManagement\Views\LecturerView\Exams.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7218418a5c5f502a3d5d232cd58b73f968473c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LecturerView_Exams), @"mvc.1.0.view", @"/Views/LecturerView/Exams.cshtml")]
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
#line 1 "C:\Project\CourseScheduleManagement\CourseSheduleManagement\Views\_ViewImports.cshtml"
using CourseSheduleManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Project\CourseScheduleManagement\CourseSheduleManagement\Views\_ViewImports.cshtml"
using CourseSheduleManagement.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7218418a5c5f502a3d5d232cd58b73f968473c9", @"/Views/LecturerView/Exams.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a4f75f94cc84e508ba037ceaf6aba7222a6e4cf", @"/Views/_ViewImports.cshtml")]
    public class Views_LecturerView_Exams : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CourseSheduleManagement.Models.Exam>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onload", new global::Microsoft.AspNetCore.Html.HtmlString("AllExams()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("selectCourseId"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onchange", new global::Microsoft.AspNetCore.Html.HtmlString("GetModuleList();"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Project\CourseScheduleManagement\CourseSheduleManagement\Views\LecturerView\Exams.cshtml"
  
    ViewData["Title"] = "Exams";
     Layout = "~/Views/Shared/_LecturerLayout.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7218418a5c5f502a3d5d232cd58b73f968473c95102", async() => {
                WriteLiteral(" ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<h1>Exam Schedule</h1><br/>\r\n   \r\n       <div class=\"row\">\r\n                    <div class=\"col-6\">\r\n                        <label class=\"control-label\">Course</label>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7218418a5c5f502a3d5d232cd58b73f968473c96358", async() => {
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7218418a5c5f502a3d5d232cd58b73f968473c96646", async() => {
                    WriteLiteral("-- Select Course --");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 12 "C:\Project\CourseScheduleManagement\CourseSheduleManagement\Views\LecturerView\Exams.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.CourseList as SelectList;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                    </div>
         <div class=""row"">
                    <div class=""col-6"">
                        <label class=""control-label"">Module</label>    
                        <select id=""selectModuleId"" class=""form-control"" onchange=""GetModules();"">
                             ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7218418a5c5f502a3d5d232cd58b73f968473c99795", async() => {
                WriteLiteral("-- Select Module --");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </select>
                    </div>
        </div>
  

    <table id=""tblExams"" class=""table table-striped"">
        <tr>
            <th>Module Name</th>
            <th>Lecturer Name</th>
            <th>Course Name</th>
            <th>Batch Code</th>
            <th>Date</th>
            <th>Start Time</th>
            <th>End Time</th>
            <th>Hall Name</th>
        </tr>
    </table>
 
    <script type=""text/javascript"">
        
         function GetModuleList() {   
      
                $.get(""/LecturerView/GetModuleList"",{ courseId:$('#selectCourseId').val() },function(data){
                     $(""#selectModuleId"").empty();
                     $(""#selectModuleId"").append(""<option selected value=''>-- Select Module --</option>"");           
                     $.each(data,function(index,row){
                            $(""#selectModuleId"").append(""<option value='""+row.moduleId+""'>""+row.moduleName+""</option>"");
            });
      ");
            WriteLiteral(@"           });
        }
          function GetModules() {

             $.get(""/LecturerView/GetExamsByModule"",{ moduleId:$('#selectModuleId').val()},function(exams){
                 
                     var table = $(""#tblExams"");
                    table.find(""tr:not(:first)"").remove();
                    $.each(exams, function (i, exam) {
                        var table = $(""#tblExams"");
                        var row = table[0].insertRow(-1);

                        $(row).append(""<td />"");
                        $(row).find(""td"").eq(0).html(exam.moduleName);
                        $(row).append(""<td />"");
                        $(row).find(""td"").eq(1).html(exam.lecturerName);
                        $(row).append(""<td />"");
                        $(row).find(""td"").eq(2).html(exam.courseName);  
                        $(row).append(""<td />"");
                        $(row).find(""td"").eq(3).html(exam.batchCode);  
                        $(row).append(""<td />"");
         ");
            WriteLiteral(@"               $(row).find(""td"").eq(4).html(exam.retrieveDate);         
                        $(row).append(""<td />"");
                        $(row).find(""td"").eq(5).html(exam.retrieveStartTime);
                        $(row).append(""<td />"");
                        $(row).find(""td"").eq(6).html(exam.retrieveEndTime);
                        $(row).append(""<td />"");
                        $(row).find(""td"").eq(7).html(exam.hallName);
                    });          
            
            });
         
        }

         function AllExams() {

             $.get(""/LecturerView/GetAllExams"",{ },function(exams){
                    
                  
                    var table = $(""#tblExams"");
                    table.find(""tr:not(:first)"").remove();
                    $.each(exams, function (i, exam) {
                        var table = $(""#tblExams"");
                        var row = table[0].insertRow(-1);

                        $(row).append(""<td />"");
          ");
            WriteLiteral(@"              $(row).find(""td"").eq(0).html(exam.moduleName);
                        $(row).append(""<td />"");
                        $(row).find(""td"").eq(1).html(exam.lecturerName);
                        $(row).append(""<td />"");
                        $(row).find(""td"").eq(2).html(exam.courseName);  
                        $(row).append(""<td />"");
                        $(row).find(""td"").eq(3).html(exam.batchCode);  
                        $(row).append(""<td />"");
                        $(row).find(""td"").eq(4).html(exam.retrieveDate);         
                        $(row).append(""<td />"");
                        $(row).find(""td"").eq(5).html(exam.retrieveStartTime);
                        $(row).append(""<td />"");
                        $(row).find(""td"").eq(6).html(exam.retrieveEndTime);
                        $(row).append(""<td />"");
                        $(row).find(""td"").eq(7).html(exam.hallName);
                    });          
            
            });
            
  ");
            WriteLiteral("      }\r\n        \r\n    </script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CourseSheduleManagement.Models.Exam>> Html { get; private set; }
    }
}
#pragma warning restore 1591
