using System.Web;
using OutSystems.Application.Abstractions.Emails;
using OutSystems.Application.Emails;
using OutSystems.Application.Core.Email;
using OutSystems.Application.Models.Emails;
using OutSystems.ObjectKeys;
using IterativeTemplateData = System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>>;
using TemplateData = System.Collections.Generic.Dictionary<string, object>;

namespace ssConectaProveedores.Flows.Flowd_Inv_Emails {

    public class d_Inv_Emails_FirstApproverInvoice : EmailScreen {

        public d_Inv_Emails_FirstApproverInvoice(
            ISettingsProvider settingsProvider,
            IApplicationLogger applicationLogger,
            ICssFlatteningService cssFlatteningService) : base(settingsProvider, applicationLogger, cssFlatteningService) { }

        private static string inlineCss;

        

        private static string _template;
        internal virtual string Template {
            get { return _template ?? (_template = GetTemplateContent("d_Inv_Emails.FirstApproverInvoice.html.resources")); }
        }

        protected static readonly IEnumerable<string> CssFiles = new List<string> {
"css/ConectaProveedores.EmailTheme.css",
"css/ConectaProveedores.d_Inv_Emails.FirstApproverInvoice.css",
"css/ConectaProveedores.EmailTheme.extra.css",

        };

        public async Task<string> GetEmailContentAsync(IRequestContext requestContext, string inParami_ApplicationName,string inParami_InvoiceName,string inParami_UserName,string inParami_Environment,string inParami_UserNameCreatedInvoice,bool inParami_IsInvoiceNewVersion,string inParamRealEmailList,string inParamRealEmailCCList,bool inParamIsPROD, CancellationToken cancellationToken) {
            if (string.IsNullOrEmpty(inlineCss)) {
                inlineCss = await GetInlineStyleSheetIncludeAsync(CssFiles, cancellationToken);
            }
            binaryImages = new Dictionary<string, Image>();
            var expressions = new TemplateData();

            expressions.Add("KZriW5wrHY02AOD7eG32Euw_Subject", HtmlEncode((("Facturas -"+((inParami_IsInvoiceNewVersion) ? (" Factura Modificada ") : (" Nueva Factura ")))+inParami_InvoiceName).ToString()));
            expressions.Add("STYLE", inlineCss);
            expressions.Add("v3_Style", MergeStyles("text-align: right;"));
            expressions.Add("v8_Style", MergeStyles("text-align: left;"));
            expressions.Add("v16_Style", MergeStyles("margin-left: 0"));
            expressions.Add("v19_Style", MergeStyles("margin-left: 0px"));
            expressions["KJGQAZPwDMEqUI_utmsJRQw_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", "img/ConectaProveedores.Logo.jpg")).ToString());
            expressions["K_HMa9cTUOUOfMj8Ib_kjwA_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["KIPt_DBy2HESCYUr66EmkFw_Value"] = HtmlEncode(inParami_InvoiceName.ToString());
            expressions["K2ODnlUigzEucmTKjMYBGnQ_Value"] = HtmlEncode(((" acaba de ser "+((inParami_IsInvoiceNewVersion) ? ("modificada") : ("creada")))+" por ").ToString());
            expressions["KzieYjdfGF0K8P9TxUQiVqQ_Value"] = HtmlEncode(inParami_UserNameCreatedInvoice.ToString());
            expressions["KnhZw3pgOgUSoTQcGyuDZeg_Value"] = HtmlEncode(("Por favor, accede al enlace"+" ").ToString());
            expressions["KC8JdjLntakG9Fbi9Zb9tTA_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", (((((string)AppUtils.SiteProperties[SitePropertiesModel.spCurrentDomain])))+"ConectaProveedores"))).ToString());
            expressions["KEDkchR3ELkKtLPhLZSuDbg_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["KPiGRcoghd0itq2JihQP_PQ_Value"] = HtmlEncode(BuiltInFunction.Year (BuiltInFunction.CurrDate ()).ToString());
            expressions["KFilFFj87IUyDOlJEZMMRaQ_Value"] = HtmlEncode(inParami_ApplicationName.ToString());

            var condition_KFe87toKVgk__OiVp9If6nQ_ = (inParami_Environment=="PROD");
            expressions["KFe87toKVgk__OiVp9If6nQ_"] = condition_KFe87toKVgk__OiVp9If6nQ_;
            if (condition_KFe87toKVgk__OiVp9If6nQ_) {
            } else {

            var condition_K2Euakg8P7EK2ffup1arKXg_ = (inParami_Environment=="DEV");
            expressions["K2Euakg8P7EK2ffup1arKXg_"] = condition_K2Euakg8P7EK2ffup1arKXg_;
            if (condition_K2Euakg8P7EK2ffup1arKXg_) {
            } else {

            var condition_KZsyKkCBhdkK9ccL4mcW9jA_ = (inParami_Environment=="QA");
            expressions["KZsyKkCBhdkK9ccL4mcW9jA_"] = condition_KZsyKkCBhdkK9ccL4mcW9jA_;
            if (condition_KZsyKkCBhdkK9ccL4mcW9jA_) {
            } else {
            }

            }

            }


            var condition_KsoGWa6FD3kG7D5fNW1JRVA_ = (inParami_UserName!="");
            expressions["KsoGWa6FD3kG7D5fNW1JRVA_"] = condition_KsoGWa6FD3kG7D5fNW1JRVA_;
            if (condition_KsoGWa6FD3kG7D5fNW1JRVA_) {
            expressions["KWqT0mfn6s0mc6bAo92fftQ_Value"] = HtmlEncode((("Hola "+inParami_UserName)+"!").ToString());
            } else {
            }


            var condition_KXKicYTrIZk2EY6htywuQ2A_ = inParamIsPROD;
            expressions["KXKicYTrIZk2EY6htywuQ2A_"] = condition_KXKicYTrIZk2EY6htywuQ2A_;
            if (condition_KXKicYTrIZk2EY6htywuQ2A_) {
            } else {

            var condition_KLvX32zm4PEmePn13ZaUVCA_ = (inParamRealEmailList!="");
            expressions["KLvX32zm4PEmePn13ZaUVCA_"] = condition_KLvX32zm4PEmePn13ZaUVCA_;
            if (condition_KLvX32zm4PEmePn13ZaUVCA_) {
            expressions["KF5js6oopYUOa87ZzTMVafw_Value"] = HtmlEncode(("Se enviará a: "+inParamRealEmailList).ToString());
            } else {
            }


            var condition_KWzRylHI9O0W9YBxO29D3uA_ = (inParamRealEmailCCList!="");
            expressions["KWzRylHI9O0W9YBxO29D3uA_"] = condition_KWzRylHI9O0W9YBxO29D3uA_;
            if (condition_KWzRylHI9O0W9YBxO29D3uA_) {
            expressions["KejEja09Q50yTZFOfh12c_w_Value"] = HtmlEncode(("En CC: "+inParamRealEmailCCList).ToString());
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
