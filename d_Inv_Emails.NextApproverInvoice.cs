using System.Web;
using OutSystems.Application.Abstractions.Emails;
using OutSystems.Application.Emails;
using OutSystems.Application.Core.Email;
using OutSystems.Application.Models.Emails;
using OutSystems.ObjectKeys;
using IterativeTemplateData = System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>>;
using TemplateData = System.Collections.Generic.Dictionary<string, object>;

namespace ssConectaProveedores.Flows.Flowd_Inv_Emails {

    public class d_Inv_Emails_NextApproverInvoice : EmailScreen {

        public d_Inv_Emails_NextApproverInvoice(
            ISettingsProvider settingsProvider,
            IApplicationLogger applicationLogger,
            ICssFlatteningService cssFlatteningService) : base(settingsProvider, applicationLogger, cssFlatteningService) { }

        private static string inlineCss;

        

        private static string _template;
        internal virtual string Template {
            get { return _template ?? (_template = GetTemplateContent("d_Inv_Emails.NextApproverInvoice.html.resources")); }
        }

        protected static readonly IEnumerable<string> CssFiles = new List<string> {
"css/ConectaProveedores.EmailTheme.css",
"css/ConectaProveedores.d_Inv_Emails.NextApproverInvoice.css",
"css/ConectaProveedores.EmailTheme.extra.css",

        };

        public async Task<string> GetEmailContentAsync(IRequestContext requestContext, string inParami_ApplicationName,string inParami_InvoiceName,string inParami_UserName,string inParami_Environment,string inParamRealEmailList,string inParamRealEmailCCList,bool inParamIsPROD, CancellationToken cancellationToken) {
            if (string.IsNullOrEmpty(inlineCss)) {
                inlineCss = await GetInlineStyleSheetIncludeAsync(CssFiles, cancellationToken);
            }
            binaryImages = new Dictionary<string, Image>();
            var expressions = new TemplateData();

            expressions.Add("KXHFpMPZImESBUyErluzgmw_Subject", HtmlEncode(("Facturas - Aprobar Factura "+inParami_InvoiceName).ToString()));
            expressions.Add("STYLE", inlineCss);
            expressions.Add("v3_Style", MergeStyles("text-align: right;"));
            expressions.Add("v8_Style", MergeStyles("text-align: left;"));
            expressions.Add("v14_Style", MergeStyles("margin-left: 0"));
            expressions.Add("v17_Style", MergeStyles("margin-left: 0px"));
            expressions["KJGQAZPwDMEqUI_utmsJRQw_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", "img/ConectaProveedores.Logo.jpg")).ToString());
            expressions["KdB1RFdAl40_4bXNX1VRQEA_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["KpFu8uvnh_0_o8tdupY9xNA_Value"] = HtmlEncode(inParami_InvoiceName.ToString());
            expressions["KcEcpWdpQvUCCfzjGWhhZig_Value"] = HtmlEncode(("Por favor, accede al enlace"+" ").ToString());
            expressions["Kj0F_0Zd4o0yV_GyynzGA4g_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", (((((string)AppUtils.SiteProperties[SitePropertiesModel.spCurrentDomain])))+"ConectaProveedores"))).ToString());
            expressions["KnTdV7g6Sv0SlfhBYAfd67A_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["Kl9c1YSVrn0Or_rvgCvi8IA_Value"] = HtmlEncode(BuiltInFunction.Year (BuiltInFunction.CurrDate ()).ToString());
            expressions["Kw_aMJaatQUW2KBOy0kvYOg_Value"] = HtmlEncode(inParami_ApplicationName.ToString());

            var condition_KqheJR9lttUeRefpp2jeFQg_ = (inParami_Environment=="PROD");
            expressions["KqheJR9lttUeRefpp2jeFQg_"] = condition_KqheJR9lttUeRefpp2jeFQg_;
            if (condition_KqheJR9lttUeRefpp2jeFQg_) {
            } else {

            var condition_KKINwjGCFcEObEEJORguhmQ_ = (inParami_Environment=="DEV");
            expressions["KKINwjGCFcEObEEJORguhmQ_"] = condition_KKINwjGCFcEObEEJORguhmQ_;
            if (condition_KKINwjGCFcEObEEJORguhmQ_) {
            } else {

            var condition_K8gkNq6IPBkOT5zlEwVw_8Q_ = (inParami_Environment=="QA");
            expressions["K8gkNq6IPBkOT5zlEwVw_8Q_"] = condition_K8gkNq6IPBkOT5zlEwVw_8Q_;
            if (condition_K8gkNq6IPBkOT5zlEwVw_8Q_) {
            } else {
            }

            }

            }


            var condition_K7RedulKMcEahxV_7l6_mVg_ = (inParami_UserName!="");
            expressions["K7RedulKMcEahxV_7l6_mVg_"] = condition_K7RedulKMcEahxV_7l6_mVg_;
            if (condition_K7RedulKMcEahxV_7l6_mVg_) {
            expressions["KSvZaImCZikeVXKxgSNFqYQ_Value"] = HtmlEncode((("Hola "+inParami_UserName)+"!").ToString());
            } else {
            }


            var condition_Kp6RhOxTng02l7aOh5aSwhw_ = inParamIsPROD;
            expressions["Kp6RhOxTng02l7aOh5aSwhw_"] = condition_Kp6RhOxTng02l7aOh5aSwhw_;
            if (condition_Kp6RhOxTng02l7aOh5aSwhw_) {
            } else {

            var condition_KM65zptdNVUq_q2stYUjJPQ_ = (inParamRealEmailList!="");
            expressions["KM65zptdNVUq_q2stYUjJPQ_"] = condition_KM65zptdNVUq_q2stYUjJPQ_;
            if (condition_KM65zptdNVUq_q2stYUjJPQ_) {
            expressions["KZFgfuMTyck2nxHZIDml2jw_Value"] = HtmlEncode(("Se enviará a: "+inParamRealEmailList).ToString());
            } else {
            }


            var condition_KW6m2QUk8fkKz_3W0rLRlIg_ = (inParamRealEmailCCList!="");
            expressions["KW6m2QUk8fkKz_3W0rLRlIg_"] = condition_KW6m2QUk8fkKz_3W0rLRlIg_;
            if (condition_KW6m2QUk8fkKz_3W0rLRlIg_) {
            expressions["KsaaLyo_kbkGdRpMXOKqdCg_Value"] = HtmlEncode(("En CC: "+inParamRealEmailCCList).ToString());
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
