using System.Web;
using OutSystems.Application.Abstractions.Emails;
using OutSystems.Application.Emails;
using OutSystems.Application.Core.Email;
using OutSystems.Application.Models.Emails;
using OutSystems.ObjectKeys;
using IterativeTemplateData = System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>>;
using TemplateData = System.Collections.Generic.Dictionary<string, object>;

namespace ssConectaProveedores.Flows.Flowe_Orders_Emails {

    public class e_Orders_Emails_ApprovalRejectOrder : EmailScreen {

        public e_Orders_Emails_ApprovalRejectOrder(
            ISettingsProvider settingsProvider,
            IApplicationLogger applicationLogger,
            ICssFlatteningService cssFlatteningService) : base(settingsProvider, applicationLogger, cssFlatteningService) { }

        private static string inlineCss;

        

        private static string _template;
        internal virtual string Template {
            get { return _template ?? (_template = GetTemplateContent("e_Orders_Emails.ApprovalRejectOrder.html.resources")); }
        }

        protected static readonly IEnumerable<string> CssFiles = new List<string> {
"css/ConectaProveedores.EmailTheme.css",
"css/ConectaProveedores.e_Orders_Emails.ApprovalRejectOrder.css",
"css/ConectaProveedores.EmailTheme.extra.css",

        };

        public async Task<string> GetEmailContentAsync(IRequestContext requestContext, string inParami_ApplicationName,string inParami_Environment,string inParami_OrderNumber,string inParami_Reason,string inParami_UserName,string inParami_RealEmailList,string inParami_RealEmailCCList,bool inParami_IsPROD, CancellationToken cancellationToken) {
            if (string.IsNullOrEmpty(inlineCss)) {
                inlineCss = await GetInlineStyleSheetIncludeAsync(CssFiles, cancellationToken);
            }
            binaryImages = new Dictionary<string, Image>();
            var expressions = new TemplateData();

            expressions.Add("K18V_LjRcjUCnWQAzIfQsjg_Subject", HtmlEncode(("Pedidos - Rechazo del Pedido "+inParami_OrderNumber).ToString()));
            expressions.Add("STYLE", inlineCss);
            expressions.Add("v3_Style", MergeStyles("text-align: right;"));
            expressions.Add("v8_Style", MergeStyles("text-align: left;"));
            expressions.Add("v9_Style", MergeStyles("margin-left: 0"));
            expressions.Add("v10_Style", MergeStyles("font-style: italic;"));
            expressions.Add("v16_Style", MergeStyles("margin-left: 0"));
            expressions.Add("v19_Style", MergeStyles("margin-left: 0px"));
            expressions["KJGQAZPwDMEqUI_utmsJRQw_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", "img/ConectaProveedores.Logo.jpg")).ToString());
            expressions["KgfmbO8gHd0uXCUTW7hEUWQ_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["KdomsI_vQlUqgo0bxI2TSKA_Value"] = HtmlEncode(inParami_OrderNumber.ToString());
            expressions["KsI9ViwRSlESa9DJgtc_uHw_Value"] = HtmlEncode(inParami_Reason.ToString());
            expressions["KRlimXJ_HzE6rRR3qaN5cyQ_Value"] = HtmlEncode(("Por favor, accede al enlace"+" ").ToString());
            expressions["KmlTTynicvki8LyIILI5uZQ_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", (((((string)AppUtils.SiteProperties[SitePropertiesModel.spCurrentDomain])))+"ConectaProveedores"))).ToString());
            expressions["KT3481XwOmUqT63jLeFwYqg_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["KCnymhHLgB024XjLtF3CVzA_Value"] = HtmlEncode(BuiltInFunction.Year (BuiltInFunction.CurrDate ()).ToString());
            expressions["KAty_YcTztEa54LOtqBOpqg_Value"] = HtmlEncode(inParami_ApplicationName.ToString());

            var condition_KB72_QVFdekSIOQiiI_XReg_ = (inParami_Environment=="PROD");
            expressions["KB72_QVFdekSIOQiiI_XReg_"] = condition_KB72_QVFdekSIOQiiI_XReg_;
            if (condition_KB72_QVFdekSIOQiiI_XReg_) {
            } else {

            var condition_KPYIWsvRF8ECPFILPCZTypA_ = (inParami_Environment=="DEV");
            expressions["KPYIWsvRF8ECPFILPCZTypA_"] = condition_KPYIWsvRF8ECPFILPCZTypA_;
            if (condition_KPYIWsvRF8ECPFILPCZTypA_) {
            } else {

            var condition_K93NBepiye0ORbH8pjjQSRA_ = (inParami_Environment=="QA");
            expressions["K93NBepiye0ORbH8pjjQSRA_"] = condition_K93NBepiye0ORbH8pjjQSRA_;
            if (condition_K93NBepiye0ORbH8pjjQSRA_) {
            } else {
            }

            }

            }


            var condition_KJ0tWmXaX5EG2lpTrio3t2Q_ = (inParami_UserName!="");
            expressions["KJ0tWmXaX5EG2lpTrio3t2Q_"] = condition_KJ0tWmXaX5EG2lpTrio3t2Q_;
            if (condition_KJ0tWmXaX5EG2lpTrio3t2Q_) {
            expressions["KZVdfkKyCEEKZak_tFpCyKg_Value"] = HtmlEncode((("Hola "+inParami_UserName)+"!").ToString());
            } else {
            }


            var condition_KH965d6nxgkexjQ9CHKAW7A_ = inParami_IsPROD;
            expressions["KH965d6nxgkexjQ9CHKAW7A_"] = condition_KH965d6nxgkexjQ9CHKAW7A_;
            if (condition_KH965d6nxgkexjQ9CHKAW7A_) {
            } else {

            var condition_KOJZIM9v0l0amn0_IIOGKiQ_ = (inParami_RealEmailList!="");
            expressions["KOJZIM9v0l0amn0_IIOGKiQ_"] = condition_KOJZIM9v0l0amn0_IIOGKiQ_;
            if (condition_KOJZIM9v0l0amn0_IIOGKiQ_) {
            expressions["K6T6ccOZs8kWAShBg7WftVA_Value"] = HtmlEncode(("Se enviará a: "+inParami_RealEmailList).ToString());
            } else {
            }


            var condition_K6tHCmUMBzkCcAOQwfFiZeg_ = (inParami_RealEmailCCList!="");
            expressions["K6tHCmUMBzkCcAOQwfFiZeg_"] = condition_K6tHCmUMBzkCcAOQwfFiZeg_;
            if (condition_K6tHCmUMBzkCcAOQwfFiZeg_) {
            expressions["Kg0VOHGRjWE2bKCU1y_S5wg_Value"] = HtmlEncode(("En CC: "+inParami_RealEmailCCList).ToString());
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
