using System.Web;
using OutSystems.Application.Abstractions.Emails;
using OutSystems.Application.Emails;
using OutSystems.Application.Core.Email;
using OutSystems.Application.Models.Emails;
using OutSystems.ObjectKeys;
using IterativeTemplateData = System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>>;
using TemplateData = System.Collections.Generic.Dictionary<string, object>;

namespace ssConectaProveedores.Flows.Flowd_Inv_Emails {

    public class d_Inv_Emails_InvoiceAccountingFailed : EmailScreen {

        public d_Inv_Emails_InvoiceAccountingFailed(
            ISettingsProvider settingsProvider,
            IApplicationLogger applicationLogger,
            ICssFlatteningService cssFlatteningService) : base(settingsProvider, applicationLogger, cssFlatteningService) { }

        private static string inlineCss;

        

        private static string _template;
        internal virtual string Template {
            get { return _template ?? (_template = GetTemplateContent("d_Inv_Emails.InvoiceAccountingFailed.html.resources")); }
        }

        protected static readonly IEnumerable<string> CssFiles = new List<string> {
"css/ConectaProveedores.EmailTheme.css",
"css/ConectaProveedores.d_Inv_Emails.InvoiceAccountingFailed.css",
"css/ConectaProveedores.EmailTheme.extra.css",

        };

        public async Task<string> GetEmailContentAsync(IRequestContext requestContext, string inParami_ApplicationName,string inParami_InvoiceName,string inParami_UserName,string inParami_Environment,string inParamRealEmailList,string inParamRealEmailCCList,bool inParamIsPROD, CancellationToken cancellationToken) {
            if (string.IsNullOrEmpty(inlineCss)) {
                inlineCss = await GetInlineStyleSheetIncludeAsync(CssFiles, cancellationToken);
            }
            binaryImages = new Dictionary<string, Image>();
            var expressions = new TemplateData();

            expressions.Add("K6gGdwKG92U6IcLIe_BhagA_Subject", HtmlEncode(("Facturas - Aprobar Factura "+inParami_InvoiceName).ToString()));
            expressions.Add("STYLE", inlineCss);
            expressions.Add("v3_Style", MergeStyles("text-align: right;"));
            expressions.Add("v8_Style", MergeStyles("text-align: left;"));
            expressions.Add("v14_Style", MergeStyles("margin-left: 0"));
            expressions.Add("v17_Style", MergeStyles("margin-left: 0px"));
            expressions["KJGQAZPwDMEqUI_utmsJRQw_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", "img/ConectaProveedores.Logo.jpg")).ToString());
            expressions["KKrIZ6qXlEkuRHB_NTQ0t1A_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["KCC2PKu2PGkyoOc_6vrrDJA_Value"] = HtmlEncode(inParami_InvoiceName.ToString());
            expressions["K5__pLUfkH0Omr_2nmEUnyQ_Value"] = HtmlEncode(("Por favor, accede al enlace"+" ").ToString());
            expressions["K6s_vJJmpgE6E1CpRL_EJ6Q_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", (((((string)AppUtils.SiteProperties[SitePropertiesModel.spCurrentDomain])))+"ConectaProveedores"))).ToString());
            expressions["Kpt7r7_3ViUWVW6tHONJx_g_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["K1X_ImOpEJEurjPor2AnYyg_Value"] = HtmlEncode(BuiltInFunction.Year (BuiltInFunction.CurrDate ()).ToString());
            expressions["KpSW8SYbtE0OXNaTu0xktJw_Value"] = HtmlEncode(inParami_ApplicationName.ToString());

            var condition_Kqj_VB2tanUacW0LPs35Ibg_ = (inParami_Environment=="PROD");
            expressions["Kqj_VB2tanUacW0LPs35Ibg_"] = condition_Kqj_VB2tanUacW0LPs35Ibg_;
            if (condition_Kqj_VB2tanUacW0LPs35Ibg_) {
            } else {

            var condition_KDP7upNShW02rtFCpBKH3Sw_ = (inParami_Environment=="DEV");
            expressions["KDP7upNShW02rtFCpBKH3Sw_"] = condition_KDP7upNShW02rtFCpBKH3Sw_;
            if (condition_KDP7upNShW02rtFCpBKH3Sw_) {
            } else {

            var condition_K0OmgWxZHAkGpdxHXCZGDow_ = (inParami_Environment=="QA");
            expressions["K0OmgWxZHAkGpdxHXCZGDow_"] = condition_K0OmgWxZHAkGpdxHXCZGDow_;
            if (condition_K0OmgWxZHAkGpdxHXCZGDow_) {
            } else {
            }

            }

            }


            var condition_KE_aEERroI02Yby0obVNg4w_ = (inParami_UserName!="");
            expressions["KE_aEERroI02Yby0obVNg4w_"] = condition_KE_aEERroI02Yby0obVNg4w_;
            if (condition_KE_aEERroI02Yby0obVNg4w_) {
            expressions["KAPDnN0_rSUm2n9hTR8Y_DQ_Value"] = HtmlEncode((("Hola "+inParami_UserName)+"!").ToString());
            } else {
            }


            var condition_Ka0zK_O6Esk_F_WOeqfLGtQ_ = inParamIsPROD;
            expressions["Ka0zK_O6Esk_F_WOeqfLGtQ_"] = condition_Ka0zK_O6Esk_F_WOeqfLGtQ_;
            if (condition_Ka0zK_O6Esk_F_WOeqfLGtQ_) {
            } else {

            var condition_KJiy1k7FmXkG3j8fXpWH_uw_ = (inParamRealEmailList!="");
            expressions["KJiy1k7FmXkG3j8fXpWH_uw_"] = condition_KJiy1k7FmXkG3j8fXpWH_uw_;
            if (condition_KJiy1k7FmXkG3j8fXpWH_uw_) {
            expressions["KECdNVI7v9EKsHLKSZunLcQ_Value"] = HtmlEncode(("Se enviará a: "+inParamRealEmailList).ToString());
            } else {
            }


            var condition_KjdZOsDK0ZUCcHL6z4DE6BQ_ = (inParamRealEmailCCList!="");
            expressions["KjdZOsDK0ZUCcHL6z4DE6BQ_"] = condition_KjdZOsDK0ZUCcHL6z4DE6BQ_;
            if (condition_KjdZOsDK0ZUCcHL6z4DE6BQ_) {
            expressions["KUQ5vfbTQvUinRfVPy5R0VQ_Value"] = HtmlEncode(("En CC: "+inParamRealEmailCCList).ToString());
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
