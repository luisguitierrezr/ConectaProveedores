using System.Web;
using OutSystems.Application.Abstractions.Emails;
using OutSystems.Application.Emails;
using OutSystems.Application.Core.Email;
using OutSystems.Application.Models.Emails;
using OutSystems.ObjectKeys;
using IterativeTemplateData = System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>>;
using TemplateData = System.Collections.Generic.Dictionary<string, object>;

namespace ssConectaProveedores.Flows.Flowh_OrderDistribution_Emails {

    public class h_OrderDistribution_Emails_OrderDestributionNotification : EmailScreen {

        public h_OrderDistribution_Emails_OrderDestributionNotification(
            ISettingsProvider settingsProvider,
            IApplicationLogger applicationLogger,
            ICssFlatteningService cssFlatteningService) : base(settingsProvider, applicationLogger, cssFlatteningService) { }

        private static string inlineCss;

        

        private static string _template;
        internal virtual string Template {
            get { return _template ?? (_template = GetTemplateContent("h_OrderDistribution_Emails.OrderDestributionNotification.html.resources")); }
        }

        protected static readonly IEnumerable<string> CssFiles = new List<string> {
"css/ConectaProveedores.EmailTheme.css",
"css/ConectaProveedores.h_OrderDistribution_Emails.OrderDestributionNotification.css",
"css/ConectaProveedores.EmailTheme.extra.css",

        };

        public async Task<string> GetEmailContentAsync(IRequestContext requestContext, string inParami_ApplicationName,string inParami_UserName,string inParami_Environment,string inParamRealEmailList,string inParamRealEmailCCList, CancellationToken cancellationToken) {
            if (string.IsNullOrEmpty(inlineCss)) {
                inlineCss = await GetInlineStyleSheetIncludeAsync(CssFiles, cancellationToken);
            }
            binaryImages = new Dictionary<string, Image>();
            var expressions = new TemplateData();

            expressions.Add("STYLE", inlineCss);
            expressions.Add("v3_Style", MergeStyles("text-align: right;"));
            expressions.Add("v8_Style", MergeStyles("text-align: left;"));
            expressions.Add("v13_Style", MergeStyles("margin-left: 0"));
            expressions.Add("v16_Style", MergeStyles("margin-left: 0px"));
            expressions["KJGQAZPwDMEqUI_utmsJRQw_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", "img/ConectaProveedores.Logo.jpg")).ToString());
            expressions["KJPV5jozEY0eeVn_DboxY5Q_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["KAiv1K4mPG0uSfnqZ8JeIyg_Value"] = HtmlEncode(("Por favor, accede a la plataforma"+" ").ToString());
            expressions["Kij0vn3xZ3EqPk_Xq8uVkEw_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", (((((string)AppUtils.SiteProperties[SitePropertiesModel.spCurrentDomain])))+"ConectaProveedores/"))).ToString());
            expressions["KDL2gVs7V60GU5pz5Qm0tFQ_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["KsTsUKAcyBEubzyo4hWoorg_Value"] = HtmlEncode(BuiltInFunction.Year (BuiltInFunction.CurrDate ()).ToString());
            expressions["KdRwJ8CGNL0mU1H1_DssmHQ_Value"] = HtmlEncode(inParami_ApplicationName.ToString());

            var condition_KNTl2r91t20iaJGQ7bKuflQ_ = (inParami_Environment=="PROD");
            expressions["KNTl2r91t20iaJGQ7bKuflQ_"] = condition_KNTl2r91t20iaJGQ7bKuflQ_;
            if (condition_KNTl2r91t20iaJGQ7bKuflQ_) {
            } else {

            var condition_KiHqyuS4BSkeX32A_mxiXxQ_ = (inParami_Environment=="DEV");
            expressions["KiHqyuS4BSkeX32A_mxiXxQ_"] = condition_KiHqyuS4BSkeX32A_mxiXxQ_;
            if (condition_KiHqyuS4BSkeX32A_mxiXxQ_) {
            } else {

            var condition_K93d6rZYf60qpsabvuWtrFg_ = (inParami_Environment=="QA");
            expressions["K93d6rZYf60qpsabvuWtrFg_"] = condition_K93d6rZYf60qpsabvuWtrFg_;
            if (condition_K93d6rZYf60qpsabvuWtrFg_) {
            } else {
            }

            }

            }


            var condition_Kvt_CSUXc2UWN6f7a1bhC7w_ = (inParami_UserName!="");
            expressions["Kvt_CSUXc2UWN6f7a1bhC7w_"] = condition_Kvt_CSUXc2UWN6f7a1bhC7w_;
            if (condition_Kvt_CSUXc2UWN6f7a1bhC7w_) {
            expressions["Ke6WmKp0eU02nQQj9g9864Q_Value"] = HtmlEncode((("Hola "+inParami_UserName)+"!").ToString());
            } else {
            }


            var condition_K5XUq2p9pw0iNz1HDYV48vg_ = (inParami_Environment=="PROD");
            expressions["K5XUq2p9pw0iNz1HDYV48vg_"] = condition_K5XUq2p9pw0iNz1HDYV48vg_;
            if (condition_K5XUq2p9pw0iNz1HDYV48vg_) {
            } else {

            var condition_Kw5QtSzHWg02aDH7MArM6tQ_ = (inParamRealEmailList!="");
            expressions["Kw5QtSzHWg02aDH7MArM6tQ_"] = condition_Kw5QtSzHWg02aDH7MArM6tQ_;
            if (condition_Kw5QtSzHWg02aDH7MArM6tQ_) {
            expressions["KTV_m_f_4xkWSoTy6rTR6dQ_Value"] = HtmlEncode(("Se enviará a: "+inParamRealEmailList).ToString());
            } else {
            }


            var condition_K9Ywf_WDccUOYL6Gpft5guQ_ = (inParamRealEmailCCList!="");
            expressions["K9Ywf_WDccUOYL6Gpft5guQ_"] = condition_K9Ywf_WDccUOYL6Gpft5guQ_;
            if (condition_K9Ywf_WDccUOYL6Gpft5guQ_) {
            expressions["Kgm550swKGUybO0aerT6b5w_Value"] = HtmlEncode(("En CC: "+inParamRealEmailCCList).ToString());
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
