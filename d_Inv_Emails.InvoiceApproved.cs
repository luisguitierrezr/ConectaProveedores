using System.Web;
using OutSystems.Application.Abstractions.Emails;
using OutSystems.Application.Emails;
using OutSystems.Application.Core.Email;
using OutSystems.Application.Models.Emails;
using OutSystems.ObjectKeys;
using IterativeTemplateData = System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>>;
using TemplateData = System.Collections.Generic.Dictionary<string, object>;

namespace ssConectaProveedores.Flows.Flowd_Inv_Emails {

    public class d_Inv_Emails_InvoiceApproved : EmailScreen {

        public d_Inv_Emails_InvoiceApproved(
            ISettingsProvider settingsProvider,
            IApplicationLogger applicationLogger,
            ICssFlatteningService cssFlatteningService) : base(settingsProvider, applicationLogger, cssFlatteningService) { }

        private static string inlineCss;

        

        private static string _template;
        internal virtual string Template {
            get { return _template ?? (_template = GetTemplateContent("d_Inv_Emails.InvoiceApproved.html.resources")); }
        }

        protected static readonly IEnumerable<string> CssFiles = new List<string> {
"css/ConectaProveedores.EmailTheme.css",
"css/ConectaProveedores.d_Inv_Emails.InvoiceApproved.css",
"css/ConectaProveedores.EmailTheme.extra.css",

        };

        public async Task<string> GetEmailContentAsync(IRequestContext requestContext, string inParami_ApplicationName,string inParami_InvoiceName,string inParami_UserName,string inParami_Enviroment,string inParamRealEmailList,string inParamRealEmailCCList,bool inParamIsPROD, CancellationToken cancellationToken) {
            if (string.IsNullOrEmpty(inlineCss)) {
                inlineCss = await GetInlineStyleSheetIncludeAsync(CssFiles, cancellationToken);
            }
            binaryImages = new Dictionary<string, Image>();
            var expressions = new TemplateData();

            expressions.Add("KDzIoH_eFPUSJjBb_oxj7SQ_Subject", HtmlEncode(("Facturas - Factura Aprobada "+inParami_InvoiceName).ToString()));
            expressions.Add("STYLE", inlineCss);
            expressions.Add("v3_Style", MergeStyles("text-align: right;"));
            expressions.Add("v8_Style", MergeStyles("text-align: left;"));
            expressions.Add("v15_Style", MergeStyles("margin-left: 0"));
            expressions.Add("v18_Style", MergeStyles("margin-left: 0px"));
            expressions["KJGQAZPwDMEqUI_utmsJRQw_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", "img/ConectaProveedores.Logo.jpg")).ToString());
            expressions["K9XdcSMktJU6bUQQbfdQdFA_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["Kz_feUqh8zEaRQKpFR_oN_w_Value"] = HtmlEncode(inParami_InvoiceName.ToString());
            expressions["K_DvFSHulckWZ7V_GWF9QDQ_Value"] = HtmlEncode(("Por favor, accede al enlace"+" ").ToString());
            expressions["KGwoOgyWbQEeer2o1jWXayg_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", (((((string)AppUtils.SiteProperties[SitePropertiesModel.spCurrentDomain])))+"ConectaProveedores"))).ToString());
            expressions["Ko_sV2ssEOEad7JeWpE44Hg_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["K2YTj7Ky1tUil1VJqM6lEjA_Value"] = HtmlEncode(BuiltInFunction.Year (BuiltInFunction.CurrDate ()).ToString());
            expressions["KVt6RDwM6YUKr_MfQwVJX_A_Value"] = HtmlEncode(inParami_ApplicationName.ToString());

            var condition_KiiehhJsy5kSf_QoiZp_vVg_ = (inParami_Enviroment=="PROD");
            expressions["KiiehhJsy5kSf_QoiZp_vVg_"] = condition_KiiehhJsy5kSf_QoiZp_vVg_;
            if (condition_KiiehhJsy5kSf_QoiZp_vVg_) {
            } else {

            var condition_KyjPV9LwSj0qzuW774CSD1g_ = (inParami_Enviroment=="DEV");
            expressions["KyjPV9LwSj0qzuW774CSD1g_"] = condition_KyjPV9LwSj0qzuW774CSD1g_;
            if (condition_KyjPV9LwSj0qzuW774CSD1g_) {
            } else {

            var condition_KhCbyFmgo80m5bLJyrKLffA_ = (inParami_Enviroment=="QA");
            expressions["KhCbyFmgo80m5bLJyrKLffA_"] = condition_KhCbyFmgo80m5bLJyrKLffA_;
            if (condition_KhCbyFmgo80m5bLJyrKLffA_) {
            } else {
            }

            }

            }


            var condition_K5vLlz6k4AUGger4zbfRYvg_ = (inParami_UserName!="");
            expressions["K5vLlz6k4AUGger4zbfRYvg_"] = condition_K5vLlz6k4AUGger4zbfRYvg_;
            if (condition_K5vLlz6k4AUGger4zbfRYvg_) {
            expressions["KWEOagWLDVkOcW3odDUwk5A_Value"] = HtmlEncode((("Hola "+inParami_UserName)+"!").ToString());
            } else {
            }


            var condition_K4oM6X84_QkOBoGHPPqMd_w_ = inParamIsPROD;
            expressions["K4oM6X84_QkOBoGHPPqMd_w_"] = condition_K4oM6X84_QkOBoGHPPqMd_w_;
            if (condition_K4oM6X84_QkOBoGHPPqMd_w_) {
            } else {

            var condition_K410uND_w2UKggwOkIzeIng_ = (inParamRealEmailList!="");
            expressions["K410uND_w2UKggwOkIzeIng_"] = condition_K410uND_w2UKggwOkIzeIng_;
            if (condition_K410uND_w2UKggwOkIzeIng_) {
            expressions["KiNGe9EhB80OQHDKD43pVAA_Value"] = HtmlEncode(("Se enviará a: "+inParamRealEmailList).ToString());
            } else {
            }


            var condition_KpS4Oe_0G4UelERHV2HfwVA_ = (inParamRealEmailCCList!="");
            expressions["KpS4Oe_0G4UelERHV2HfwVA_"] = condition_KpS4Oe_0G4UelERHV2HfwVA_;
            if (condition_KpS4Oe_0G4UelERHV2HfwVA_) {
            expressions["K5qaEq3ADukGBAiD0diPxtA_Value"] = HtmlEncode(("En CC: "+inParamRealEmailCCList).ToString());
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
