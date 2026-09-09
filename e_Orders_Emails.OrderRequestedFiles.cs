using System.Web;
using OutSystems.Application.Abstractions.Emails;
using OutSystems.Application.Emails;
using OutSystems.Application.Core.Email;
using OutSystems.Application.Models.Emails;
using OutSystems.ObjectKeys;
using IterativeTemplateData = System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>>;
using TemplateData = System.Collections.Generic.Dictionary<string, object>;

namespace ssConectaProveedores.Flows.Flowe_Orders_Emails {

    public class e_Orders_Emails_OrderRequestedFiles : EmailScreen {

        public e_Orders_Emails_OrderRequestedFiles(
            ISettingsProvider settingsProvider,
            IApplicationLogger applicationLogger,
            ICssFlatteningService cssFlatteningService) : base(settingsProvider, applicationLogger, cssFlatteningService) { }

        private static string inlineCss;

        

        private static string _template;
        internal virtual string Template {
            get { return _template ?? (_template = GetTemplateContent("e_Orders_Emails.OrderRequestedFiles.html.resources")); }
        }

        protected static readonly IEnumerable<string> CssFiles = new List<string> {
"css/ConectaProveedores.EmailTheme.css",
"css/ConectaProveedores.e_Orders_Emails.OrderRequestedFiles.css",
"css/ConectaProveedores.EmailTheme.extra.css",

        };

        public async Task<string> GetEmailContentAsync(IRequestContext requestContext, string inParami_ApplicationName,string inParami_Environment,string inParami_OrderNumber,string inParami_UserName,string inParami_FilesList,string inParami_RealEmailList,string inParami_RealEmailCCList,bool inParami_IsPROD, CancellationToken cancellationToken) {
            if (string.IsNullOrEmpty(inlineCss)) {
                inlineCss = await GetInlineStyleSheetIncludeAsync(CssFiles, cancellationToken);
            }
            binaryImages = new Dictionary<string, Image>();
            var expressions = new TemplateData();

            expressions.Add("KvBAZslAj6kqZBXqGqOqFmQ_Subject", HtmlEncode(("Pedidos - Documentos Requeridos  "+inParami_OrderNumber).ToString()));
            expressions.Add("STYLE", inlineCss);
            expressions.Add("v3_Style", MergeStyles("text-align: right;"));
            expressions.Add("v8_Style", MergeStyles("text-align: left;"));
            expressions.Add("v16_Style", MergeStyles("margin-left: 0"));
            expressions.Add("v19_Style", MergeStyles("margin-left: 0px"));
            expressions["KJGQAZPwDMEqUI_utmsJRQw_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", "img/ConectaProveedores.Logo.jpg")).ToString());
            expressions["KYpXvqg5s2UO7NxZXDfOHKg_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["K4CJOVqISgk6l7u09akQS9A_Value"] = HtmlEncode(inParami_OrderNumber.ToString());
            expressions["KB8MH_DIFjE_XgiL9oxRdNg_Value"] = HtmlEncode(inParami_FilesList.ToString());
            expressions["KiQOui8dB_0ye9uh0pbZ9QA_Value"] = HtmlEncode(("Por favor, accede al enlace"+" ").ToString());
            expressions["Kw8FY4KXT5UilT_4iFHw9VQ_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", (((((string)AppUtils.SiteProperties[SitePropertiesModel.spCurrentDomain])))+"ConectaProveedores"))).ToString());
            expressions["KKQ_lwcPz3066rJ_YIGu0Pw_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["KOV7gBdRdUkWmuCoz7uzYpg_Value"] = HtmlEncode(BuiltInFunction.Year (BuiltInFunction.CurrDate ()).ToString());
            expressions["KGBj3AJkPxkCB8FOSWkJv9A_Value"] = HtmlEncode(inParami_ApplicationName.ToString());

            var condition_KSjwZDswxAkSnfGrT4CfHog_ = (inParami_Environment=="PROD");
            expressions["KSjwZDswxAkSnfGrT4CfHog_"] = condition_KSjwZDswxAkSnfGrT4CfHog_;
            if (condition_KSjwZDswxAkSnfGrT4CfHog_) {
            } else {

            var condition_KSJqSQUkskUuOufCO_0cwxg_ = (inParami_Environment=="DEV");
            expressions["KSJqSQUkskUuOufCO_0cwxg_"] = condition_KSJqSQUkskUuOufCO_0cwxg_;
            if (condition_KSJqSQUkskUuOufCO_0cwxg_) {
            } else {

            var condition_KqxJw0G_WzkKqlr5FO_aZ3w_ = (inParami_Environment=="QA");
            expressions["KqxJw0G_WzkKqlr5FO_aZ3w_"] = condition_KqxJw0G_WzkKqlr5FO_aZ3w_;
            if (condition_KqxJw0G_WzkKqlr5FO_aZ3w_) {
            } else {
            }

            }

            }


            var condition_KbXVtggTjLEuCoF4Y9Mldxw_ = (inParami_UserName!="");
            expressions["KbXVtggTjLEuCoF4Y9Mldxw_"] = condition_KbXVtggTjLEuCoF4Y9Mldxw_;
            if (condition_KbXVtggTjLEuCoF4Y9Mldxw_) {
            expressions["KegfhBocO4UCRrYE_qFukCw_Value"] = HtmlEncode((("Hola "+inParami_UserName)+"!").ToString());
            } else {
            }


            var condition_K713r_9VaOU6UuvTB2_skeA_ = inParami_IsPROD;
            expressions["K713r_9VaOU6UuvTB2_skeA_"] = condition_K713r_9VaOU6UuvTB2_skeA_;
            if (condition_K713r_9VaOU6UuvTB2_skeA_) {
            } else {

            var condition_K79KQi7KZdUi692kgPHmlcA_ = (inParami_RealEmailList!="");
            expressions["K79KQi7KZdUi692kgPHmlcA_"] = condition_K79KQi7KZdUi692kgPHmlcA_;
            if (condition_K79KQi7KZdUi692kgPHmlcA_) {
            expressions["Kn3lEo4X7f0CzXRvOBXTfcA_Value"] = HtmlEncode(("Se enviará a: "+inParami_RealEmailList).ToString());
            } else {
            }


            var condition_K1vBAawp4Qk2ejByw9dYhNA_ = (inParami_RealEmailCCList!="");
            expressions["K1vBAawp4Qk2ejByw9dYhNA_"] = condition_K1vBAawp4Qk2ejByw9dYhNA_;
            if (condition_K1vBAawp4Qk2ejByw9dYhNA_) {
            expressions["KBDPzt367FEODCa57BqZlpQ_Value"] = HtmlEncode(("En CC: "+inParami_RealEmailCCList).ToString());
            } else {
            }

            }



            return Render(Template, expressions);
        }

        internal async Task IterateAsync(IOSList list, Func<Task> action) {
            list.StartIteration();
            try {
                while (!list.Eof) {
                    await action();
                    list.Advance();
                }
            }
            finally {
                list.EndIteration();
            }
        }
    }
}
