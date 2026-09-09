using System.Web;
using OutSystems.Application.Abstractions.Emails;
using OutSystems.Application.Emails;
using OutSystems.Application.Core.Email;
using OutSystems.Application.Models.Emails;
using OutSystems.ObjectKeys;
using IterativeTemplateData = System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>>;
using TemplateData = System.Collections.Generic.Dictionary<string, object>;

namespace ssConectaProveedores.Flows.Flowb_CyA_Emails {

    public class b_CyA_Emails_LoginAlert : EmailScreen {

        public b_CyA_Emails_LoginAlert(
            ISettingsProvider settingsProvider,
            IApplicationLogger applicationLogger,
            ICssFlatteningService cssFlatteningService) : base(settingsProvider, applicationLogger, cssFlatteningService) { }

        private static string inlineCss;

        

        private static string _template;
        internal virtual string Template {
            get { return _template ?? (_template = GetTemplateContent("b_CyA_Emails.LoginAlert.html.resources")); }
        }

        protected static readonly IEnumerable<string> CssFiles = new List<string> {
"css/ConectaProveedores.EmailTheme.css",
"css/ConectaProveedores.b_CyA_Emails.LoginAlert.css",
"css/ConectaProveedores.EmailTheme.extra.css",

        };

        public async Task<string> GetEmailContentAsync(IRequestContext requestContext, string inParamApplicationName,string inParami_Enviroment,string inParamUsername,string inParamIPaddress,bool inParamIsPROD,string inParamRealEmailList,string inParamRealEmailCCList, CancellationToken cancellationToken) {
            if (string.IsNullOrEmpty(inlineCss)) {
                inlineCss = await GetInlineStyleSheetIncludeAsync(CssFiles, cancellationToken);
            }
            binaryImages = new Dictionary<string, Image>();
            var expressions = new TemplateData();

            expressions.Add("KxBWDZbBERUCbh92jYFPNDQ_Subject", HtmlEncode(((((inParami_Enviroment=="DEV")) ? ("(DEV)") : ((((inParami_Enviroment=="QA")) ? ("(QA)") : (""))))+" Alerta de login").ToString()));
            expressions.Add("STYLE", inlineCss);
            expressions.Add("v3_Style", MergeStyles("text-align: right;"));
            expressions.Add("v9_Style", MergeStyles("color: #ae0000; font-size: 16px;"));
            expressions.Add("v11_Style", MergeStyles("color: #ae0000; font-size: 16px;"));
            expressions.Add("v13_Style", MergeStyles("margin-left: 0px"));
            expressions["KJGQAZPwDMEqUI_utmsJRQw_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", "img/ConectaProveedores.Logo.jpg")).ToString());
            expressions["KK9macxsOCEOt_CfLb82Xug_Value"] = HtmlEncode(inParamApplicationName.ToString());
            expressions["KEkj9JxqWykSWXYvtbpS01A_Value"] = HtmlEncode(("Usuario: "+inParamUsername).ToString());
            expressions["KaPk7fDOS4kGvhPeUybbb8g_Value"] = HtmlEncode(("IP address: "+inParamIPaddress).ToString());
            expressions["K5GWyCroShkWnY4p7ynT6lw_Value"] = HtmlEncode(BuiltInFunction.Year (BuiltInFunction.CurrDate ()).ToString());
            expressions["K_sJurApfSUKzHL9ERd1Fig_Value"] = HtmlEncode(inParamApplicationName.ToString());

            var condition_K8EPllJrBKUWW3Rlz5jG_Jw_ = (inParami_Enviroment=="PROD");
            expressions["K8EPllJrBKUWW3Rlz5jG_Jw_"] = condition_K8EPllJrBKUWW3Rlz5jG_Jw_;
            if (condition_K8EPllJrBKUWW3Rlz5jG_Jw_) {
            } else {

            var condition_KHdCZlmQbzEaLhwzNWYjCXA_ = (inParami_Enviroment=="DEV");
            expressions["KHdCZlmQbzEaLhwzNWYjCXA_"] = condition_KHdCZlmQbzEaLhwzNWYjCXA_;
            if (condition_KHdCZlmQbzEaLhwzNWYjCXA_) {
            } else {

            var condition_K6pso6EdU70K3wrfV5cjTrg_ = (inParami_Enviroment=="QA");
            expressions["K6pso6EdU70K3wrfV5cjTrg_"] = condition_K6pso6EdU70K3wrfV5cjTrg_;
            if (condition_K6pso6EdU70K3wrfV5cjTrg_) {
            } else {
            }

            }

            }


            var condition_K2trG1auWREGnxoAC_fSgRg_ = inParamIsPROD;
            expressions["K2trG1auWREGnxoAC_fSgRg_"] = condition_K2trG1auWREGnxoAC_fSgRg_;
            if (condition_K2trG1auWREGnxoAC_fSgRg_) {
            } else {

            var condition_Kr0YLQFUVKkOpe3r3a_h_IQ_ = (inParamRealEmailList!="");
            expressions["Kr0YLQFUVKkOpe3r3a_h_IQ_"] = condition_Kr0YLQFUVKkOpe3r3a_h_IQ_;
            if (condition_Kr0YLQFUVKkOpe3r3a_h_IQ_) {
            expressions["KAwAnQrcmFEGeV3D_DkcPeQ_Value"] = HtmlEncode(("Se enviará a: "+inParamRealEmailList).ToString());
            } else {
            }


            var condition_K_dqmw5tfYECTpAesJv9WGA_ = (inParamRealEmailCCList!="");
            expressions["K_dqmw5tfYECTpAesJv9WGA_"] = condition_K_dqmw5tfYECTpAesJv9WGA_;
            if (condition_K_dqmw5tfYECTpAesJv9WGA_) {
            expressions["KC90JUxHziUmJLTqMkot8Yg_Value"] = HtmlEncode(("En CC: "+inParamRealEmailCCList).ToString());
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
