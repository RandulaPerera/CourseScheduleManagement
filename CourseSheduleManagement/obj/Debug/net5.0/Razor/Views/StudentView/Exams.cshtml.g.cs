#pragma checksum "C:\Project\CourseScheduleManagement\CourseSheduleManagement\Views\StudentView\Exams.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "874821ab0ce73b4600978cffc5e689ce93bef669"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_StudentView_Exams), @"mvc.1.0.view", @"/Views/StudentView/Exams.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"874821ab0ce73b4600978cffc5e689ce93bef669", @"/Views/StudentView/Exams.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a4f75f94cc84e508ba037ceaf6aba7222a6e4cf", @"/Views/_ViewImports.cshtml")]
    public class Views_StudentView_Exams : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CourseSheduleManagement.Models.Exam>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Project\CourseScheduleManagement\CourseSheduleManagement\Views\StudentView\Exams.cshtml"
  
    ViewData["Title"] = "Exams";
     Layout = "~/Views/Shared/_StudentLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Exam Schedule</h1><br/>
   
        <div class=""row"">
                    <div class=""col-3"">
                        <label class=""control-label"">Search By Date</label>    
                    </div>
                    <div class=""col-4"">
                        <input id=""date"" id=""date"" type=""date""  class=""form-control""/>
                    </div>
                     <div class=""col-3"">
                        <input type=""button"" value=""Search"" class=""btn btn-primary"" onclick=""GetExams();""/><br/><br/>
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
        
        function GetExams() {

  ");
            WriteLiteral(@"           $.get(""/StudentView/SearchExamsByDate"",{ date:$('#date').val()},function(exams){
                    
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
                        $(row).find(""td"").eq(4).html(exam.retrieveDate);         
    ");
            WriteLiteral(@"                    $(row).append(""<td />"");
                        $(row).find(""td"").eq(5).html(exam.retrieveStartTime);
                        $(row).append(""<td />"");
                        $(row).find(""td"").eq(6).html(exam.retrieveEndTime);
                        $(row).append(""<td />"");
                        $(row).find(""td"").eq(7).html(exam.hallName);
                    });          
            
            });
           
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CourseSheduleManagement.Models.Exam>> Html { get; private set; }
    }
}
#pragma warning restore 1591
