using System.Web;
using OutSystems.Application.Abstractions.Emails;
using OutSystems.Application.Emails;
using OutSystems.Application.Core.Email;
using OutSystems.Application.Models.Emails;
using OutSystems.ObjectKeys;
using IterativeTemplateData = System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>>;
using TemplateData = System.Collections.Generic.Dictionary<string, object>;

namespace ssConectaProveedores.Flows.Flowe_Orders_Emails {

    public class e_Orders_Emails_OrderApproved : EmailScreen {

        public e_Orders_Emails_OrderApproved(
            ISettingsProvider settingsProvider,
            IApplicationLogger applicationLogger,
            ICssFlatteningService cssFlatteningService) : base(settingsProvider, applicationLogger, cssFlatteningService) { }

        private static string inlineCss;

        

        private static string _template;
        internal virtual string Template {
            get { return _template ?? (_template = GetTemplateContent("e_Orders_Emails.OrderApproved.html.resources")); }
        }

        protected static readonly IEnumerable<string> CssFiles = new List<string> {
"css/ConectaProveedores.EmailTheme.css",
"css/ConectaProveedores.e_Orders_Emails.OrderApproved.css",
"css/ConectaProveedores.EmailTheme.extra.css",

        };

        public async Task<string> GetEmailContentAsync(IRequestContext requestContext, string inParami_ApplicationName,string inParami_Environment,string inParami_OrderNumber,string inParami_UserName,string inParami_RealEmailList,string inParami_RealEmailCCList,bool inParami_IsPROD, CancellationToken cancellationToken) {
            if (string.IsNullOrEmpty(inlineCss)) {
                inlineCss = await GetInlineStyleSheetIncludeAsync(CssFiles, cancellationToken);
            }
            binaryImages = new Dictionary<string, Image>();
            var expressions = new TemplateData();

            expressions.Add("KZ_v7g5n74EqhupGV8ojJuA_Subject", HtmlEncode(("Pedidos - Pedido Aprobado "+inParami_OrderNumber).ToString()));
            expressions.Add("STYLE", inlineCss);
            expressions.Add("v3_Style", MergeStyles("text-align: right;"));
            expressions.Add("v8_Style", MergeStyles("text-align: left;"));
            expressions.Add("v15_Style", MergeStyles("margin-left: 0"));
            expressions.Add("v18_Style", MergeStyles("margin-left: 0px"));
            expressions["KJGQAZPwDMEqUI_utmsJRQw_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", "img/ConectaProveedores.Logo.jpg")).ToString());
            expressions["KIau6AdNmVUSCAMWM3stjYA_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["Kp9K_dwPygkehy24c5UUc7w_Value"] = HtmlEncode(inParami_OrderNumber.ToString());
            expressions["KR800wJfZME_sM5sATGYBMg_Value"] = HtmlEncode(("Por favor, accede al enlace"+" ").ToString());
            expressions["KVmCj4GQ_w0ix8QBf21Nm2w_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", (((((string)AppUtils.SiteProperties[SitePropertiesModel.spCurrentDomain])))+"ConectaProveedores"))).ToString());
            expressions["K8cZHn_Q5UU6RCqwZo0iQig_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["KX2L3IEqqlEqE6TsIFSA1vQ_Value"] = HtmlEncode(BuiltInFunction.Year (BuiltInFunction.CurrDate ()).ToString());
            expressions["KQ6_LVLfNw0Kt5QKAxHG0Lw_Value"] = HtmlEncode(inParami_ApplicationName.ToString());

            var condition_KPyFJSWh1a0CItg62OKBNoQ_ = (inParami_Environment=="PROD");
            expressions["KPyFJSWh1a0CItg62OKBNoQ_"] = condition_KPyFJSWh1a0CItg62OKBNoQ_;
            if (condition_KPyFJSWh1a0CItg62OKBNoQ_) {
            } else {

            var condition_KzfwOt5vYA0a2oJyMSwfSrg_ = (inParami_Environment=="DEV");
            expressions["KzfwOt5vYA0a2oJyMSwfSrg_"] = condition_KzfwOt5vYA0a2oJyMSwfSrg_;
            if (condition_KzfwOt5vYA0a2oJyMSwfSrg_) {
            } else {

            var condition_KpBEkcvSd0kS1oGKajAObXw_ = (inParami_Environment=="QA");
            expressions["KpBEkcvSd0kS1oGKajAObXw_"] = condition_KpBEkcvSd0kS1oGKajAObXw_;
            if (condition_KpBEkcvSd0kS1oGKajAObXw_) {
            } else {
            }

            }

            }


            var condition_K2xNVGaKQlkSWaWyV52MXAw_ = (inParami_UserName!="");
            expressions["K2xNVGaKQlkSWaWyV52MXAw_"] = condition_K2xNVGaKQlkSWaWyV52MXAw_;
            if (condition_K2xNVGaKQlkSWaWyV52MXAw_) {
            expressions["K6X_c3Zg3BUiP_wqg3PWmEg_Value"] = HtmlEncode((("Hola "+inParami_UserName)+"!").ToString());
            } else {
            }


            var condition_Kz1QGny1qN0aRo_qz2Ek21A_ = inParami_IsPROD;
            expressions["Kz1QGny1qN0aRo_qz2Ek21A_"] = condition_Kz1QGny1qN0aRo_qz2Ek21A_;
            if (condition_Kz1QGny1qN0aRo_qz2Ek21A_) {
            } else {

            var condition_K9ZvNzV0WPk6wzFREkhKdsA_ = (inParami_RealEmailList!="");
            expressions["K9ZvNzV0WPk6wzFREkhKdsA_"] = condition_K9ZvNzV0WPk6wzFREkhKdsA_;
            if (condition_K9ZvNzV0WPk6wzFREkhKdsA_) {
            expressions["KfkP1yZDITk_RHdhQfmuRJQ_Value"] = HtmlEncode(("Se enviará a: "+inParami_RealEmailList).ToString());
            } else {
            }


            var condition_KYSUCDUuUSk__qo0lMg6dzg_ = (inParami_RealEmailCCList!="");
            expressions["KYSUCDUuUSk__qo0lMg6dzg_"] = condition_KYSUCDUuUSk__qo0lMg6dzg_;
            if (condition_KYSUCDUuUSk__qo0lMg6dzg_) {
            expressions["KAejodlhx6EOiymV2xZdywA_Value"] = HtmlEncode(("En CC: "+inParami_RealEmailCCList).ToString());
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
