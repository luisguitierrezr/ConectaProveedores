using System.Web;
using OutSystems.Application.Abstractions.Emails;
using OutSystems.Application.Emails;
using OutSystems.Application.Core.Email;
using OutSystems.Application.Models.Emails;
using OutSystems.ObjectKeys;
using IterativeTemplateData = System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>>;
using TemplateData = System.Collections.Generic.Dictionary<string, object>;

namespace ssConectaProveedores.Flows.Flowj_FoliosSAE_Emails {

    public class j_FoliosSAE_Emails_AccountingOrderError : EmailScreen {

        public j_FoliosSAE_Emails_AccountingOrderError(
            ISettingsProvider settingsProvider,
            IApplicationLogger applicationLogger,
            ICssFlatteningService cssFlatteningService) : base(settingsProvider, applicationLogger, cssFlatteningService) { }

        private static string inlineCss;

        

        private static string _template;
        internal virtual string Template {
            get { return _template ?? (_template = GetTemplateContent("j_FoliosSAE_Emails.AccountingOrderError.html.resources")); }
        }

        protected static readonly IEnumerable<string> CssFiles = new List<string> {
"css/ConectaProveedores.EmailTheme.css",
"css/ConectaProveedores.j_FoliosSAE_Emails.AccountingOrderError.css",
"css/ConectaProveedores.EmailTheme.extra.css",

        };

        public async Task<string> GetEmailContentAsync(IRequestContext requestContext, string inParami_ApplicationName,string inParami_OrderNumber,string inParami_UserName,string inParami_Environment,string inParamRealEmailList,string inParamRealEmailCCList,bool inParamIsPROD, CancellationToken cancellationToken) {
            if (string.IsNullOrEmpty(inlineCss)) {
                inlineCss = await GetInlineStyleSheetIncludeAsync(CssFiles, cancellationToken);
            }
            binaryImages = new Dictionary<string, Image>();
            var expressions = new TemplateData();

            expressions.Add("KDFx__Pu9t0m2C9faLtHAXw_Subject", HtmlEncode(("Pedido - Error en Contabilización "+inParami_OrderNumber).ToString()));
            expressions.Add("STYLE", inlineCss);
            expressions.Add("v3_Style", MergeStyles("text-align: right;"));
            expressions.Add("v8_Style", MergeStyles("text-align: left;"));
            expressions.Add("v15_Style", MergeStyles("margin-left: 0"));
            expressions.Add("v18_Style", MergeStyles("margin-left: 0px"));
            expressions["KJGQAZPwDMEqUI_utmsJRQw_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", "img/ConectaProveedores.Logo.jpg")).ToString());
            expressions["KtSmF1Ty8_UaHGKIOGpZN1Q_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["KyoPJFeA94kmzmKWDam33Ug_Value"] = HtmlEncode(inParami_OrderNumber.ToString());
            expressions["Kx69QKjGtjUu0YM_AOKEYyg_Value"] = HtmlEncode(("Por favor, accede al enlace"+" ").ToString());
            expressions["KaEaiJR67MUSGCo3ke5eglQ_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", (((((string)AppUtils.SiteProperties[SitePropertiesModel.spCurrentDomain])))+"ConectaProveedores"))).ToString());
            expressions["Ko857tMGnh0i0L1_5zPN7Tg_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["K92LT_cJ6T0_G6q1vgo7ToA_Value"] = HtmlEncode(BuiltInFunction.Year (BuiltInFunction.CurrDate ()).ToString());
            expressions["KrR561PtqSkSvprmc1JJ28A_Value"] = HtmlEncode(inParami_ApplicationName.ToString());

            var condition_K8HRKEl8wIUK0cxPIsVfIUQ_ = (inParami_Environment=="PROD");
            expressions["K8HRKEl8wIUK0cxPIsVfIUQ_"] = condition_K8HRKEl8wIUK0cxPIsVfIUQ_;
            if (condition_K8HRKEl8wIUK0cxPIsVfIUQ_) {
            } else {

            var condition_KNRQUn9cm0Eq_wi3lDs1WfQ_ = (inParami_Environment=="DEV");
            expressions["KNRQUn9cm0Eq_wi3lDs1WfQ_"] = condition_KNRQUn9cm0Eq_wi3lDs1WfQ_;
            if (condition_KNRQUn9cm0Eq_wi3lDs1WfQ_) {
            } else {

            var condition_KBasYABnNokuZXyDOcXXmUA_ = (inParami_Environment=="QA");
            expressions["KBasYABnNokuZXyDOcXXmUA_"] = condition_KBasYABnNokuZXyDOcXXmUA_;
            if (condition_KBasYABnNokuZXyDOcXXmUA_) {
            } else {
            }

            }

            }


            var condition_KSt1gZNYVlEGaRiHCEsMcoA_ = (inParami_UserName!="");
            expressions["KSt1gZNYVlEGaRiHCEsMcoA_"] = condition_KSt1gZNYVlEGaRiHCEsMcoA_;
            if (condition_KSt1gZNYVlEGaRiHCEsMcoA_) {
            expressions["K4cDu0QfntEiRYXUBHrIwew_Value"] = HtmlEncode((("Hola "+inParami_UserName)+"!").ToString());
            } else {
            }


            var condition_K4wuUnGqkyEiCBpuGO3P7gQ_ = inParamIsPROD;
            expressions["K4wuUnGqkyEiCBpuGO3P7gQ_"] = condition_K4wuUnGqkyEiCBpuGO3P7gQ_;
            if (condition_K4wuUnGqkyEiCBpuGO3P7gQ_) {
            } else {

            var condition_KhRgmy1N_O0mTTiK2F5Yd1Q_ = (inParamRealEmailList!="");
            expressions["KhRgmy1N_O0mTTiK2F5Yd1Q_"] = condition_KhRgmy1N_O0mTTiK2F5Yd1Q_;
            if (condition_KhRgmy1N_O0mTTiK2F5Yd1Q_) {
            expressions["KrkYmvdrjGkeDPweB4LFONQ_Value"] = HtmlEncode(("Se enviará a: "+inParamRealEmailList).ToString());
            } else {
            }


            var condition_Kz8JsvQNdWEaJ2MOaxfeLqw_ = (inParamRealEmailCCList!="");
            expressions["Kz8JsvQNdWEaJ2MOaxfeLqw_"] = condition_Kz8JsvQNdWEaJ2MOaxfeLqw_;
            if (condition_Kz8JsvQNdWEaJ2MOaxfeLqw_) {
            expressions["Kg0oLxem7H02opzdB3YIm_w_Value"] = HtmlEncode(("En CC: "+inParamRealEmailCCList).ToString());
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
