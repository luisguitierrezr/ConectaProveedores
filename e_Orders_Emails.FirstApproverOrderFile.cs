using System.Web;
using OutSystems.Application.Abstractions.Emails;
using OutSystems.Application.Emails;
using OutSystems.Application.Core.Email;
using OutSystems.Application.Models.Emails;
using OutSystems.ObjectKeys;
using IterativeTemplateData = System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>>;
using TemplateData = System.Collections.Generic.Dictionary<string, object>;

namespace ssConectaProveedores.Flows.Flowe_Orders_Emails {

    public class e_Orders_Emails_FirstApproverOrderFile : EmailScreen {

        public e_Orders_Emails_FirstApproverOrderFile(
            ISettingsProvider settingsProvider,
            IApplicationLogger applicationLogger,
            ICssFlatteningService cssFlatteningService) : base(settingsProvider, applicationLogger, cssFlatteningService) { }

        private static string inlineCss;

        

        private static string _template;
        internal virtual string Template {
            get { return _template ?? (_template = GetTemplateContent("e_Orders_Emails.FirstApproverOrderFile.html.resources")); }
        }

        protected static readonly IEnumerable<string> CssFiles = new List<string> {
"css/ConectaProveedores.EmailTheme.css",
"css/ConectaProveedores.e_Orders_Emails.FirstApproverOrderFile.css",
"css/ConectaProveedores.EmailTheme.extra.css",

        };

        public async Task<string> GetEmailContentAsync(IRequestContext requestContext, string inParami_ApplicationName,string inParami_Environment,string inParami_OrderNumber,string inParami_FileDescription,string inParami_UserName,string inParami_RealEmailList,string inParami_RealEmailCCList,bool inParami_IsPROD, CancellationToken cancellationToken) {
            if (string.IsNullOrEmpty(inlineCss)) {
                inlineCss = await GetInlineStyleSheetIncludeAsync(CssFiles, cancellationToken);
            }
            binaryImages = new Dictionary<string, Image>();
            var expressions = new TemplateData();

            expressions.Add("K7VBv1TwsM0yVVZofLSat2Q_Subject", HtmlEncode(("Pedidos - Archivo Cargado "+inParami_FileDescription).ToString()));
            expressions.Add("STYLE", inlineCss);
            expressions.Add("v3_Style", MergeStyles("text-align: right;"));
            expressions.Add("v8_Style", MergeStyles("text-align: left;"));
            expressions.Add("v15_Style", MergeStyles("margin-left: 0"));
            expressions.Add("v18_Style", MergeStyles("margin-left: 0px"));
            expressions["KJGQAZPwDMEqUI_utmsJRQw_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", "img/ConectaProveedores.Logo.jpg")).ToString());
            expressions["K9vLN0zqjeE_9DKTNv3D7lA_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["KMWjQ1tEsqE6psaqtsRi3ew_Value"] = HtmlEncode((("("+inParami_FileDescription)+")").ToString());
            expressions["KjUw1kxjZmUGe03KyOkOeaQ_Value"] = HtmlEncode(inParami_OrderNumber.ToString());
            expressions["Kmucn1eUuI0amvv0MyLY4GA_Value"] = HtmlEncode(("Por favor, accede al enlace"+" ").ToString());
            expressions["KyiZxC3jqBUuDwoTXxub2bA_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", (((((string)AppUtils.SiteProperties[SitePropertiesModel.spCurrentDomain])))+"ConectaProveedores"))).ToString());
            expressions["KV1Q0PiNGLE2NjSu1ne6_zw_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["KLax2gL2T_UWXhPmEq2sHqg_Value"] = HtmlEncode(BuiltInFunction.Year (BuiltInFunction.CurrDate ()).ToString());
            expressions["KCtMNHZPcbEmAI7W31QL8Jg_Value"] = HtmlEncode(inParami_ApplicationName.ToString());

            var condition_KQw_ZFopXDUydN1cP6xT3FA_ = (inParami_Environment=="PROD");
            expressions["KQw_ZFopXDUydN1cP6xT3FA_"] = condition_KQw_ZFopXDUydN1cP6xT3FA_;
            if (condition_KQw_ZFopXDUydN1cP6xT3FA_) {
            } else {

            var condition_KbYFRgs0U4kK3WGlmeBPwAQ_ = (inParami_Environment=="DEV");
            expressions["KbYFRgs0U4kK3WGlmeBPwAQ_"] = condition_KbYFRgs0U4kK3WGlmeBPwAQ_;
            if (condition_KbYFRgs0U4kK3WGlmeBPwAQ_) {
            } else {

            var condition_KfOcR3sQHI0KuhfuY570oxQ_ = (inParami_Environment=="QA");
            expressions["KfOcR3sQHI0KuhfuY570oxQ_"] = condition_KfOcR3sQHI0KuhfuY570oxQ_;
            if (condition_KfOcR3sQHI0KuhfuY570oxQ_) {
            } else {
            }

            }

            }


            var condition_KabBrxuwj0kW6ryX9gdAmvg_ = (inParami_UserName!="");
            expressions["KabBrxuwj0kW6ryX9gdAmvg_"] = condition_KabBrxuwj0kW6ryX9gdAmvg_;
            if (condition_KabBrxuwj0kW6ryX9gdAmvg_) {
            expressions["KxNtvMBViy0GYb9EV_Vgq4A_Value"] = HtmlEncode((("Hola "+inParami_UserName)+"!").ToString());
            } else {
            }


            var condition_KYNlshdGgQkqNmBtob4KgRA_ = inParami_IsPROD;
            expressions["KYNlshdGgQkqNmBtob4KgRA_"] = condition_KYNlshdGgQkqNmBtob4KgRA_;
            if (condition_KYNlshdGgQkqNmBtob4KgRA_) {
            } else {

            var condition_KGP2H3k7vSkKKAOSLUg3HPg_ = (inParami_RealEmailList!="");
            expressions["KGP2H3k7vSkKKAOSLUg3HPg_"] = condition_KGP2H3k7vSkKKAOSLUg3HPg_;
            if (condition_KGP2H3k7vSkKKAOSLUg3HPg_) {
            expressions["KhiCvCyZAcEy6jVeumHYr7Q_Value"] = HtmlEncode(("Se enviará a: "+inParami_RealEmailList).ToString());
            } else {
            }


            var condition_KZad7VL8GEEGkuYAVfqb1fw_ = (inParami_RealEmailCCList!="");
            expressions["KZad7VL8GEEGkuYAVfqb1fw_"] = condition_KZad7VL8GEEGkuYAVfqb1fw_;
            if (condition_KZad7VL8GEEGkuYAVfqb1fw_) {
            expressions["Kn7PMFcwm80GCZtTOpOxpKA_Value"] = HtmlEncode(("En CC: "+inParami_RealEmailCCList).ToString());
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
