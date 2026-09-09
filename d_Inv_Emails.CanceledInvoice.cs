using System.Web;
using OutSystems.Application.Abstractions.Emails;
using OutSystems.Application.Emails;
using OutSystems.Application.Core.Email;
using OutSystems.Application.Models.Emails;
using OutSystems.ObjectKeys;
using IterativeTemplateData = System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>>;
using TemplateData = System.Collections.Generic.Dictionary<string, object>;

namespace ssConectaProveedores.Flows.Flowd_Inv_Emails {

    public class d_Inv_Emails_CanceledInvoice : EmailScreen {

        public d_Inv_Emails_CanceledInvoice(
            ISettingsProvider settingsProvider,
            IApplicationLogger applicationLogger,
            ICssFlatteningService cssFlatteningService) : base(settingsProvider, applicationLogger, cssFlatteningService) { }

        private static string inlineCss;

        

        private static string _template;
        internal virtual string Template {
            get { return _template ?? (_template = GetTemplateContent("d_Inv_Emails.CanceledInvoice.html.resources")); }
        }

        protected static readonly IEnumerable<string> CssFiles = new List<string> {
"css/ConectaProveedores.EmailTheme.css",
"css/ConectaProveedores.d_Inv_Emails.CanceledInvoice.css",
"css/ConectaProveedores.EmailTheme.extra.css",

        };

        public async Task<string> GetEmailContentAsync(IRequestContext requestContext, string inParami_ApplicationName,string inParami_InvoiceName,string inParami_UserName,string inParami_CanceledReason,string inParami_Enviroment,string inParamRealEmailList,string inParamRealEmailCCList,bool inParamIsPROD, CancellationToken cancellationToken) {
            if (string.IsNullOrEmpty(inlineCss)) {
                inlineCss = await GetInlineStyleSheetIncludeAsync(CssFiles, cancellationToken);
            }
            binaryImages = new Dictionary<string, Image>();
            var expressions = new TemplateData();

            expressions.Add("KPRKgoOpmrUivtlJLprjuHA_Subject", HtmlEncode(("Facturas - Cancelación de la Factura "+inParami_InvoiceName).ToString()));
            expressions.Add("STYLE", inlineCss);
            expressions.Add("v3_Style", MergeStyles("text-align: right;"));
            expressions.Add("v8_Style", MergeStyles("text-align: left;"));
            expressions.Add("v9_Style", MergeStyles("margin-left: 0"));
            expressions.Add("v11_Style", MergeStyles("color: #ae0000; font-size: 16px;"));
            expressions.Add("v17_Style", MergeStyles("margin-left: 0"));
            expressions.Add("v20_Style", MergeStyles("margin-left: 0px"));
            expressions["KJGQAZPwDMEqUI_utmsJRQw_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", "img/ConectaProveedores.Logo.jpg")).ToString());
            expressions["KK79xQtfCpUaRDztS0VDmkQ_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["KsAxHHODofE6GgnuC_DfxYg_Value"] = HtmlEncode(inParami_InvoiceName.ToString());
            expressions["KIhZNuaozekaloi0_5w6PDQ_Value"] = HtmlEncode(inParami_CanceledReason.ToString());
            expressions["KCshPtpqZl0yQ6GXg5qHUdQ_Value"] = HtmlEncode(("Por favor, accede al enlace"+" ").ToString());
            expressions["Kf2vfhs1KW0OMzeGkCBe9ag_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", (((((string)AppUtils.SiteProperties[SitePropertiesModel.spCurrentDomain])))+"ConectaProveedores"))).ToString());
            expressions["Kl1A_eGIHJ0iuJ_a95BMe_Q_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["KY2MHjyGD6kKPhTcyE_Y6Zg_Value"] = HtmlEncode(BuiltInFunction.Year (BuiltInFunction.CurrDate ()).ToString());
            expressions["K7XyFJdKX4kOB_e8v5SjF1A_Value"] = HtmlEncode(inParami_ApplicationName.ToString());

            var condition_KgQrun9EfAUGkCQAODSpx_A_ = (inParami_Enviroment=="PROD");
            expressions["KgQrun9EfAUGkCQAODSpx_A_"] = condition_KgQrun9EfAUGkCQAODSpx_A_;
            if (condition_KgQrun9EfAUGkCQAODSpx_A_) {
            } else {

            var condition_KO9_DNJgC30CA1yleYFcVeg_ = (inParami_Enviroment=="DEV");
            expressions["KO9_DNJgC30CA1yleYFcVeg_"] = condition_KO9_DNJgC30CA1yleYFcVeg_;
            if (condition_KO9_DNJgC30CA1yleYFcVeg_) {
            } else {

            var condition_KDBLgShUAj0O4wt0MUtq8_A_ = (inParami_Enviroment=="QA");
            expressions["KDBLgShUAj0O4wt0MUtq8_A_"] = condition_KDBLgShUAj0O4wt0MUtq8_A_;
            if (condition_KDBLgShUAj0O4wt0MUtq8_A_) {
            } else {
            }

            }

            }


            var condition_KtZJYA_JfyU273RNgzrpB7g_ = (inParami_UserName!="");
            expressions["KtZJYA_JfyU273RNgzrpB7g_"] = condition_KtZJYA_JfyU273RNgzrpB7g_;
            if (condition_KtZJYA_JfyU273RNgzrpB7g_) {
            expressions["KGCcuNywJe0OnCLR4QIacgA_Value"] = HtmlEncode((("Hola "+inParami_UserName)+"!").ToString());
            } else {
            }


            var condition_KNJr7Bw4uWkCTza62Hd__bw_ = inParamIsPROD;
            expressions["KNJr7Bw4uWkCTza62Hd__bw_"] = condition_KNJr7Bw4uWkCTza62Hd__bw_;
            if (condition_KNJr7Bw4uWkCTza62Hd__bw_) {
            } else {

            var condition_KGw9oIauFVEmV8mWJVAbnhQ_ = (inParamRealEmailList!="");
            expressions["KGw9oIauFVEmV8mWJVAbnhQ_"] = condition_KGw9oIauFVEmV8mWJVAbnhQ_;
            if (condition_KGw9oIauFVEmV8mWJVAbnhQ_) {
            expressions["KVCGrmd9cNEGKLHJEwc9LbA_Value"] = HtmlEncode(("Se enviará a: "+inParamRealEmailList).ToString());
            } else {
            }


            var condition_KsHQ2iYfP6UqJW5o4e7vzuQ_ = (inParamRealEmailCCList!="");
            expressions["KsHQ2iYfP6UqJW5o4e7vzuQ_"] = condition_KsHQ2iYfP6UqJW5o4e7vzuQ_;
            if (condition_KsHQ2iYfP6UqJW5o4e7vzuQ_) {
            expressions["Km2r9byGOFUKkdX00vqH3gA_Value"] = HtmlEncode(("En CC: "+inParamRealEmailCCList).ToString());
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
