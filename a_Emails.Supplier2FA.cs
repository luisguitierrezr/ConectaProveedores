using System.Web;
using OutSystems.Application.Abstractions.Emails;
using OutSystems.Application.Emails;
using OutSystems.Application.Core.Email;
using OutSystems.Application.Models.Emails;
using OutSystems.ObjectKeys;
using IterativeTemplateData = System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>>;
using TemplateData = System.Collections.Generic.Dictionary<string, object>;

namespace ssConectaProveedores.Flows.Flowa_Emails {

    public class a_Emails_Supplier2FA : EmailScreen {

        public a_Emails_Supplier2FA(
            ISettingsProvider settingsProvider,
            IApplicationLogger applicationLogger,
            ICssFlatteningService cssFlatteningService) : base(settingsProvider, applicationLogger, cssFlatteningService) { }

        private static string inlineCss;

        

        private static string _template;
        internal virtual string Template {
            get { return _template ?? (_template = GetTemplateContent("a_Emails.Supplier2FA.html.resources")); }
        }

        protected static readonly IEnumerable<string> CssFiles = new List<string> {
"css/ConectaProveedores.EmailTheme.css",
"css/ConectaProveedores.a_Emails.Supplier2FA.css",
"css/ConectaProveedores.EmailTheme.extra.css",

        };

        public async Task<string> GetEmailContentAsync(IRequestContext requestContext, string inParamApplicationName,string inParamCustomerName,string inParamCustomerEmail,string inParamVerificationCode,string inParami_Environment, CancellationToken cancellationToken) {
            if (string.IsNullOrEmpty(inlineCss)) {
                inlineCss = await GetInlineStyleSheetIncludeAsync(CssFiles, cancellationToken);
            }
            binaryImages = new Dictionary<string, Image>();
            var expressions = new TemplateData();

            expressions.Add("Km0rzJz5GlU_WX44FdQ_U_Q_Subject", HtmlEncode(("Código para "+inParamApplicationName).ToString()));
            expressions.Add("STYLE", inlineCss);
            expressions.Add("v5_Style", MergeStyles("text-align: left;"));
            expressions.Add("v13_Style", MergeStyles("margin-left: 0"));
            expressions.Add("v16_Style", MergeStyles("margin-left: 0px"));
            expressions["KJGQAZPwDMEqUI_utmsJRQw_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", "img/ConectaProveedores.Logo.jpg")).ToString());
            expressions["KMQX6L07Tgk2DXEOIUVRk9Q_Value"] = HtmlEncode(inParamApplicationName.ToString());
            expressions["KUfcfIYuHv0CSvV5DTvZLqA_Value"] = HtmlEncode(inParamVerificationCode.ToString());
            expressions["KZAOFBMc7Wki6rTXt_Lrv8g_Value"] = HtmlEncode(inParamApplicationName.ToString());
            expressions["KjLHW_V_efUGbZb2iSVAwww_Value"] = HtmlEncode(BuiltInFunction.Year (BuiltInFunction.CurrDate ()).ToString());
            expressions["KomkJqkNnJUKoED7BbxOOgw_Value"] = HtmlEncode(inParamApplicationName.ToString());

            var condition_KQl4xuKQxkEmIg6dzguzM8g_ = (inParamCustomerEmail!="");
            expressions["KQl4xuKQxkEmIg6dzguzM8g_"] = condition_KQl4xuKQxkEmIg6dzguzM8g_;
            if (condition_KQl4xuKQxkEmIg6dzguzM8g_) {
            expressions["KDjoMPhL1oUGwae6hVkuF_A_Value"] = HtmlEncode((("Hola "+inParamCustomerEmail)+"!").ToString());
            } else {
            }


            var condition_KS23Sb6_Za02WBmOk_cZJOw_ = (inParami_Environment=="PROD");
            expressions["KS23Sb6_Za02WBmOk_cZJOw_"] = condition_KS23Sb6_Za02WBmOk_cZJOw_;
            if (condition_KS23Sb6_Za02WBmOk_cZJOw_) {
            } else {
            expressions["Kch2U9Xgy4E6Z4Y3HE8_qlA_Value"] = HtmlEncode(((("Se enviará a: "+inParamCustomerEmail)+" / ")+(((inParamCustomerName!="")) ? (inParamCustomerName) : ("Nome no encontrado o vacio"))).ToString());
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
