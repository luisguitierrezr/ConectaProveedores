using System.Web;
using OutSystems.Application.Abstractions.Emails;
using OutSystems.Application.Emails;
using OutSystems.Application.Core.Email;
using OutSystems.Application.Models.Emails;
using OutSystems.ObjectKeys;
using IterativeTemplateData = System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>>;
using TemplateData = System.Collections.Generic.Dictionary<string, object>;

namespace ssConectaProveedores.Flows.Flowe_Orders_Emails {

    public class e_Orders_Emails_NextApproverOrder : EmailScreen {

        public e_Orders_Emails_NextApproverOrder(
            ISettingsProvider settingsProvider,
            IApplicationLogger applicationLogger,
            ICssFlatteningService cssFlatteningService) : base(settingsProvider, applicationLogger, cssFlatteningService) { }

        private static string inlineCss;

        

        private static string _template;
        internal virtual string Template {
            get { return _template ?? (_template = GetTemplateContent("e_Orders_Emails.NextApproverOrder.html.resources")); }
        }

        protected static readonly IEnumerable<string> CssFiles = new List<string> {
"css/ConectaProveedores.EmailTheme.css",
"css/ConectaProveedores.e_Orders_Emails.NextApproverOrder.css",
"css/ConectaProveedores.EmailTheme.extra.css",

        };

        public async Task<string> GetEmailContentAsync(IRequestContext requestContext, string inParami_ApplicationName,string inParami_Environment,string inParami_OrderNumber,string inParami_UserName,string inParami_RealEmailList,string inParami_RealEmailCCList,bool inParami_IsPROD, CancellationToken cancellationToken) {
            if (string.IsNullOrEmpty(inlineCss)) {
                inlineCss = await GetInlineStyleSheetIncludeAsync(CssFiles, cancellationToken);
            }
            binaryImages = new Dictionary<string, Image>();
            var expressions = new TemplateData();

            expressions.Add("K2z4YFvc5dU2Gyv8QMW_ZXg_Subject", HtmlEncode(("Pedidos - Aprobar Pedido "+inParami_OrderNumber).ToString()));
            expressions.Add("STYLE", inlineCss);
            expressions.Add("v3_Style", MergeStyles("text-align: right;"));
            expressions.Add("v8_Style", MergeStyles("text-align: left;"));
            expressions.Add("v14_Style", MergeStyles("margin-left: 0"));
            expressions.Add("v17_Style", MergeStyles("margin-left: 0px"));
            expressions["KJGQAZPwDMEqUI_utmsJRQw_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", "img/ConectaProveedores.Logo.jpg")).ToString());
            expressions["K2KZZnVrJhkOtWRLLoBUn1g_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["Kn4RVJbCwx0yhe8Qf93UiEg_Value"] = HtmlEncode(inParami_OrderNumber.ToString());
            expressions["K9YAkBXEFxUesOdr30YjSNw_Value"] = HtmlEncode(("Por favor, accede al enlace"+" ").ToString());
            expressions["K7FIUc8KBMUaWoGLE0pTBGw_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", (((((string)AppUtils.SiteProperties[SitePropertiesModel.spCurrentDomain])))+"ConectaProveedores"))).ToString());
            expressions["KnBnm8IW_EEuv4ef0BHgPRg_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["KW2_KAjW_i0CsAr9CzJs9fQ_Value"] = HtmlEncode(BuiltInFunction.Year (BuiltInFunction.CurrDate ()).ToString());
            expressions["KmkCbWgLU_kGmgNq9rt5ZiA_Value"] = HtmlEncode(inParami_ApplicationName.ToString());

            var condition_KArQdzePW40yYrli_xmic7g_ = (inParami_Environment=="PROD");
            expressions["KArQdzePW40yYrli_xmic7g_"] = condition_KArQdzePW40yYrli_xmic7g_;
            if (condition_KArQdzePW40yYrli_xmic7g_) {
            } else {

            var condition_K_8sbJSLNv0_uxxVfOifBAw_ = (inParami_Environment=="DEV");
            expressions["K_8sbJSLNv0_uxxVfOifBAw_"] = condition_K_8sbJSLNv0_uxxVfOifBAw_;
            if (condition_K_8sbJSLNv0_uxxVfOifBAw_) {
            } else {

            var condition_KA8FfIiA_R0aMVECy9uQgWg_ = (inParami_Environment=="QA");
            expressions["KA8FfIiA_R0aMVECy9uQgWg_"] = condition_KA8FfIiA_R0aMVECy9uQgWg_;
            if (condition_KA8FfIiA_R0aMVECy9uQgWg_) {
            } else {
            }

            }

            }


            var condition_KOItQ3kFQQE2QUNcT6c3qug_ = (inParami_UserName!="");
            expressions["KOItQ3kFQQE2QUNcT6c3qug_"] = condition_KOItQ3kFQQE2QUNcT6c3qug_;
            if (condition_KOItQ3kFQQE2QUNcT6c3qug_) {
            expressions["KQyPZSLN2PES83mRlnkxVrA_Value"] = HtmlEncode((("Hola "+inParami_UserName)+"!").ToString());
            } else {
            }


            var condition_KXgdDp_4pe0GXOxPpU6WWkw_ = inParami_IsPROD;
            expressions["KXgdDp_4pe0GXOxPpU6WWkw_"] = condition_KXgdDp_4pe0GXOxPpU6WWkw_;
            if (condition_KXgdDp_4pe0GXOxPpU6WWkw_) {
            } else {

            var condition_KSI6u4snEmEelG3uoOUDIUw_ = (inParami_RealEmailList!="");
            expressions["KSI6u4snEmEelG3uoOUDIUw_"] = condition_KSI6u4snEmEelG3uoOUDIUw_;
            if (condition_KSI6u4snEmEelG3uoOUDIUw_) {
            expressions["KQQyVHxNG40Krgt4xvt7cqA_Value"] = HtmlEncode(("Se enviará a: "+inParami_RealEmailList).ToString());
            } else {
            }


            var condition_KK_rtQBXbykeAR1CUnq90UQ_ = (inParami_RealEmailCCList!="");
            expressions["KK_rtQBXbykeAR1CUnq90UQ_"] = condition_KK_rtQBXbykeAR1CUnq90UQ_;
            if (condition_KK_rtQBXbykeAR1CUnq90UQ_) {
            expressions["K_GSmM4LjoUCWvN8LIOEgHQ_Value"] = HtmlEncode(("En CC: "+inParami_RealEmailCCList).ToString());
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
