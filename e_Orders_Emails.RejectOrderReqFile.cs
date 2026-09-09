using System.Web;
using OutSystems.Application.Abstractions.Emails;
using OutSystems.Application.Emails;
using OutSystems.Application.Core.Email;
using OutSystems.Application.Models.Emails;
using OutSystems.ObjectKeys;
using IterativeTemplateData = System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>>;
using TemplateData = System.Collections.Generic.Dictionary<string, object>;

namespace ssConectaProveedores.Flows.Flowe_Orders_Emails {

    public class e_Orders_Emails_RejectOrderReqFile : EmailScreen {

        public e_Orders_Emails_RejectOrderReqFile(
            ISettingsProvider settingsProvider,
            IApplicationLogger applicationLogger,
            ICssFlatteningService cssFlatteningService) : base(settingsProvider, applicationLogger, cssFlatteningService) { }

        private static string inlineCss;

        

        private static string _template;
        internal virtual string Template {
            get { return _template ?? (_template = GetTemplateContent("e_Orders_Emails.RejectOrderReqFile.html.resources")); }
        }

        protected static readonly IEnumerable<string> CssFiles = new List<string> {
"css/ConectaProveedores.EmailTheme.css",
"css/ConectaProveedores.e_Orders_Emails.RejectOrderReqFile.css",
"css/ConectaProveedores.EmailTheme.extra.css",

        };

        public async Task<string> GetEmailContentAsync(IRequestContext requestContext, string inParami_ApplicationName,string inParami_Environment,string inParami_Filename,string inParami_OrderNumber,string inParami_RejectReason,string inParami_UserName,string inParami_RealEmailList,string inParami_RealEmailCCList,bool inParami_IsPROD, CancellationToken cancellationToken) {
            if (string.IsNullOrEmpty(inlineCss)) {
                inlineCss = await GetInlineStyleSheetIncludeAsync(CssFiles, cancellationToken);
            }
            binaryImages = new Dictionary<string, Image>();
            var expressions = new TemplateData();

            expressions.Add("KgFWgdzb9a0SvSf8KkQ0wlw_Subject", HtmlEncode(("Pedidos - Rechazo del Archivo del Pedido "+inParami_Filename).ToString()));
            expressions.Add("STYLE", inlineCss);
            expressions.Add("v3_Style", MergeStyles("text-align: right;"));
            expressions.Add("v8_Style", MergeStyles("text-align: left;"));
            expressions.Add("v9_Style", MergeStyles("margin-left: 0"));
            expressions.Add("v18_Style", MergeStyles("margin-left: 0"));
            expressions.Add("v21_Style", MergeStyles("margin-left: 0px"));
            expressions["KJGQAZPwDMEqUI_utmsJRQw_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", "img/ConectaProveedores.Logo.jpg")).ToString());
            expressions["KnXSv0k8hhUSJSBhIe2IhSA_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["KHRzCCXHM_UuGWxIHu7vBfQ_Value"] = HtmlEncode((("("+inParami_Filename)+")").ToString());
            expressions["KjpDcFqLDiE6SMhWjXGHR_Q_Value"] = HtmlEncode(inParami_OrderNumber.ToString());
            expressions["KA0cISdz0WUimLhRbX23uUQ_Value"] = HtmlEncode(inParami_RejectReason.ToString());
            expressions["KuiSjA9gO3kmP6RvTCW423g_Value"] = HtmlEncode(("Por favor, accede al enlace"+" ").ToString());
            expressions["KaFKBBvGwA0yOWzYH1t0KBQ_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", (((((string)AppUtils.SiteProperties[SitePropertiesModel.spCurrentDomain])))+"ConectaProveedores"))).ToString());
            expressions["KXyCtiwuG1k2_5NYShszpkA_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["KLNR2FuofuUeuHg_ra7xLxA_Value"] = HtmlEncode(BuiltInFunction.Year (BuiltInFunction.CurrDate ()).ToString());
            expressions["KiMUZkVT6kkyG20NbgGMfmQ_Value"] = HtmlEncode(inParami_ApplicationName.ToString());

            var condition_KuRNkPYQEmUiRrzYeEyUqpg_ = (inParami_Environment=="PROD");
            expressions["KuRNkPYQEmUiRrzYeEyUqpg_"] = condition_KuRNkPYQEmUiRrzYeEyUqpg_;
            if (condition_KuRNkPYQEmUiRrzYeEyUqpg_) {
            } else {

            var condition_KCW8Jo5_TRE2o6CgPNDAxcg_ = (inParami_Environment=="DEV");
            expressions["KCW8Jo5_TRE2o6CgPNDAxcg_"] = condition_KCW8Jo5_TRE2o6CgPNDAxcg_;
            if (condition_KCW8Jo5_TRE2o6CgPNDAxcg_) {
            } else {

            var condition_K51pab3v_0kuLnJBBkzMTMg_ = (inParami_Environment=="QA");
            expressions["K51pab3v_0kuLnJBBkzMTMg_"] = condition_K51pab3v_0kuLnJBBkzMTMg_;
            if (condition_K51pab3v_0kuLnJBBkzMTMg_) {
            } else {
            }

            }

            }


            var condition_KJyYyRVkICkKexZ38_yDIbQ_ = (inParami_UserName!="");
            expressions["KJyYyRVkICkKexZ38_yDIbQ_"] = condition_KJyYyRVkICkKexZ38_yDIbQ_;
            if (condition_KJyYyRVkICkKexZ38_yDIbQ_) {
            expressions["KrxtPkFvufUiaYuvfv44Vdg_Value"] = HtmlEncode((("Hola "+inParami_UserName)+"!").ToString());
            } else {
            }


            var condition_KvObJsvsqgkqQ0DeX1ueBMw_ = inParami_IsPROD;
            expressions["KvObJsvsqgkqQ0DeX1ueBMw_"] = condition_KvObJsvsqgkqQ0DeX1ueBMw_;
            if (condition_KvObJsvsqgkqQ0DeX1ueBMw_) {
            } else {

            var condition_KTB5xFHnsoUOsJy9E57wuiA_ = (inParami_RealEmailList!="");
            expressions["KTB5xFHnsoUOsJy9E57wuiA_"] = condition_KTB5xFHnsoUOsJy9E57wuiA_;
            if (condition_KTB5xFHnsoUOsJy9E57wuiA_) {
            expressions["KltlBwt3VgUWKa1jqB2OWEw_Value"] = HtmlEncode(("Se enviará a: "+inParami_RealEmailList).ToString());
            } else {
            }


            var condition_Kgt0enxnZRkaY9ZRUuUALLg_ = (inParami_RealEmailCCList!="");
            expressions["Kgt0enxnZRkaY9ZRUuUALLg_"] = condition_Kgt0enxnZRkaY9ZRUuUALLg_;
            if (condition_Kgt0enxnZRkaY9ZRUuUALLg_) {
            expressions["K4mlikcSnYk6s_gp5JI4KHw_Value"] = HtmlEncode(("En CC: "+inParami_RealEmailCCList).ToString());
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
