using System.Web;
using OutSystems.Application.Abstractions.Emails;
using OutSystems.Application.Emails;
using OutSystems.Application.Core.Email;
using OutSystems.Application.Models.Emails;
using OutSystems.ObjectKeys;
using IterativeTemplateData = System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>>;
using TemplateData = System.Collections.Generic.Dictionary<string, object>;

namespace ssConectaProveedores.Flows.Flowa_Emails {

    public class a_Emails_ChangeEmail : EmailScreen {

        public a_Emails_ChangeEmail(
            ISettingsProvider settingsProvider,
            IApplicationLogger applicationLogger,
            ICssFlatteningService cssFlatteningService) : base(settingsProvider, applicationLogger, cssFlatteningService) { }

        private static string inlineCss;

        

        private static string _template;
        internal virtual string Template {
            get { return _template ?? (_template = GetTemplateContent("a_Emails.ChangeEmail.html.resources")); }
        }

        protected static readonly IEnumerable<string> CssFiles = new List<string> {
"css/ConectaProveedores.EmailTheme.css",
"css/ConectaProveedores.a_Emails.ChangeEmail.css",
"css/ConectaProveedores.EmailTheme.extra.css",

        };

        public async Task<string> GetEmailContentAsync(IRequestContext requestContext, string inParamApplicationName,string inParamCustomerName,string inParamCustomerEmail,string inParamVerificationCode,bool inParamIsPROD, CancellationToken cancellationToken) {
            if (string.IsNullOrEmpty(inlineCss)) {
                inlineCss = await GetInlineStyleSheetIncludeAsync(CssFiles, cancellationToken);
            }
            binaryImages = new Dictionary<string, Image>();
            var expressions = new TemplateData();

            expressions.Add("KKJaCKn90CkeeRAbUxfM5CQ_Subject", HtmlEncode(((inParamApplicationName+": código de verificación ")+inParamVerificationCode).ToString()));
            expressions.Add("STYLE", inlineCss);
            expressions.Add("v5_Style", MergeStyles("text-align: left;"));
            expressions.Add("v8_Style", MergeStyles("text-align: center;"));
            expressions.Add("v9_Style", MergeStyles("text-align: center;"));
            expressions.Add("v16_Style", MergeStyles("margin-left: 0px"));
            expressions["KJGQAZPwDMEqUI_utmsJRQw_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", "img/ConectaProveedores.Logo.jpg")).ToString());
            expressions["Kj5m2Wq_gRkGuZbLWCm_ung_Value"] = HtmlEncode(inParamApplicationName.ToString());
            expressions["K3Ljcpm4YoEaYU6mJIFWXqw_Value"] = HtmlEncode(inParamVerificationCode.ToString());
            expressions["KBPRczYYgeka6h4OHchx9Vw_Value"] = HtmlEncode(inParamApplicationName.ToString());
            expressions["KwkD9C4AikES9wmTQFWo__g_Value"] = HtmlEncode(BuiltInFunction.Year (BuiltInFunction.CurrDate ()).ToString());
            expressions["Ktx1h4baZSU6DEgisBevOHA_Value"] = HtmlEncode(inParamApplicationName.ToString());

            var condition_K4ybOQNyE5EOPNN_Hi8r77g_ = (inParamCustomerName!="");
            expressions["K4ybOQNyE5EOPNN_Hi8r77g_"] = condition_K4ybOQNyE5EOPNN_Hi8r77g_;
            if (condition_K4ybOQNyE5EOPNN_Hi8r77g_) {
            expressions["KYS8Wm0GbS0SXfpsPw3c1Cg_Value"] = HtmlEncode((("Hola "+inParamCustomerName)+"!").ToString());
            } else {
            }


            var condition_Kwfhswart5E2nMIiToz8Vrw_ = inParamIsPROD;
            expressions["Kwfhswart5E2nMIiToz8Vrw_"] = condition_Kwfhswart5E2nMIiToz8Vrw_;
            if (condition_Kwfhswart5E2nMIiToz8Vrw_) {
            } else {
            expressions["KO_Dtnkm7_kucsBZ6wOMxEQ_Value"] = HtmlEncode(((("Se enviará a: "+inParamCustomerEmail)+" / ")+(((inParamCustomerName!="")) ? (inParamCustomerName) : ("Nome no encontrado o vacio"))).ToString());
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
