#pragma checksum "C:\Users\User\Desktop\C # UYGULAMA\CoreDemo\CoreDemo\Views\Register\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "554a834fc69dcffef70136ed540c6528159be666e1d2cb23bc11868d230aa4f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Register_Index), @"mvc.1.0.view", @"/Views/Register/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\User\Desktop\C # UYGULAMA\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\C # UYGULAMA\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"554a834fc69dcffef70136ed540c6528159be666e1d2cb23bc11868d230aa4f9", @"/Views/Register/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"28e9796c92c1d16a3954ba6ba0aa2474261584969ce6f7ea25d023e9241fc234", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Register_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Writer>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\Desktop\C # UYGULAMA\CoreDemo\CoreDemo\Views\Register\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<script src=\"https://unpkg.com/sweetalert/dist/sweetalert.min.js\"></script>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "554a834fc69dcffef70136ed540c6528159be666e1d2cb23bc11868d230aa4f93989", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<section class=\"main-content-w3layouts-agileits\">\r\n\t<div class=\"container\">\r\n\t\t<h3 class=\"tittle\">Yazar Kayıt Sayfası</h3>\r\n\t\t<div class=\"inner-sec\">\r\n\t\t\t<div class=\"login p-5 bg-light mx-auto mw-100\">\r\n");
#nullable restore
#line 14 "C:\Users\User\Desktop\C # UYGULAMA\CoreDemo\CoreDemo\Views\Register\Index.cshtml"
      using(Html.BeginForm("Index","Register",FormMethod.Post))
				 {

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<div class=\"form-row\">\r\n\t\t\t\t\t\t<div class=\"col-md-6 mb-3\">\r\n\t\t\t\t\t\t\t<label for=\"validationCustom01\">Adınız Soyadınız</label>\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 19 "C:\Users\User\Desktop\C # UYGULAMA\CoreDemo\CoreDemo\Views\Register\Index.cshtml"
  Write(Html.TextBoxFor(x=>x.WriterName, new {@class = "form control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 20 "C:\Users\User\Desktop\C # UYGULAMA\CoreDemo\CoreDemo\Views\Register\Index.cshtml"
  Write(Html.ValidationMessageFor(x=>x.WriterName,"" ,new {@class="text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<div class=\"col-md-6 mb-3\">\r\n\t\t\t\t\t\t\t<label for=\"validationCustom02\">Mail Adresi</label>\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 25 "C:\Users\User\Desktop\C # UYGULAMA\CoreDemo\CoreDemo\Views\Register\Index.cshtml"
  Write(Html.TextBoxFor(x=>x.WriterMail,new {@class = "form control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 26 "C:\Users\User\Desktop\C # UYGULAMA\CoreDemo\CoreDemo\Views\Register\Index.cshtml"
  Write(Html.ValidationMessageFor(x=>x.WriterMail,"" ,new {@class="text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"form-row\">\r\n\t\t\t\t\t\t<div class=\"form-group col-md-6\">\r\n\t\t\t\t\t\t\t<label for=\"exampleInputPassword1 mb-2\">Şifre</label>\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 33 "C:\Users\User\Desktop\C # UYGULAMA\CoreDemo\CoreDemo\Views\Register\Index.cshtml"
  Write(Html.TextBoxFor(x=>x.WriterPassword,new {@class = "form control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 34 "C:\Users\User\Desktop\C # UYGULAMA\CoreDemo\CoreDemo\Views\Register\Index.cshtml"
  Write(Html.ValidationMessageFor(x=>x.WriterPassword,"" ,new {@class="text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<div class=\"form-group col-md-6\">\r\n\t\t\t\t\t\t\t<label for=\"exampleInputPassword2 mb-2\">Görsel Dosya Yolla</label>\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 39 "C:\Users\User\Desktop\C # UYGULAMA\CoreDemo\CoreDemo\Views\Register\Index.cshtml"
  Write(Html.TextBoxFor(x=>x.WriterImage,new {@class = "form control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 40 "C:\Users\User\Desktop\C # UYGULAMA\CoreDemo\CoreDemo\Views\Register\Index.cshtml"
  Write(Html.ValidationMessageFor(x=>x.WriterImage,"" ,new {@class="text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\t\t\t\t\t\t</div>\r\n\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<button type=\"submit\" class=\"btn btn-primary submit mb-4\">Kayıt Ol</button>\r\n\t\t\t\t\t<p>\r\n\t\t\t\t\t\t<a href=\"#\" id=\"btn1\">Tüm şartları okudum, kabul ediyorum</a>\r\n\t\t\t\t\t</p>\r\n");
#nullable restore
#line 49 "C:\Users\User\Desktop\C # UYGULAMA\CoreDemo\CoreDemo\Views\Register\Index.cshtml"
				}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
			</div>
		</div>
	</div>
	<br/>
	<script>
		$('#btn1').click(function () {
			swal(""Site Kabul Şartları"",""Sitemizde verdiğiniz mail adresi üzerinden bilgi ve haber e-postaları spam ölçüsüne varmadan gönderilmeye devam edilecektir.Eğer e-posta bülteninden çıkmak isterseniz mail ileti dizisini durdurabilirsiniz, şifre ve mail adresleriniz şifrelenmiş formatta hernagi bir kullanıcının görmeyeceği şekilde veritabanımızda saklanmaktadır."");
		});
	</script>
</section>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Writer> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
