using System.Web;
using OutSystems.Application.Abstractions.Emails;
using OutSystems.Application.Emails;
using OutSystems.Application.Core.Email;
using OutSystems.Application.Models.Emails;
using OutSystems.ObjectKeys;
using IterativeTemplateData = System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>>;
using TemplateData = System.Collections.Generic.Dictionary<string, object>;

namespace ssConectaProveedores.Flows.Flowc_Req_Emails {

    public class c_Req_Emails_CanceledRequisition : EmailScreen {

        public c_Req_Emails_CanceledRequisition(
            ISettingsProvider settingsProvider,
            IApplicationLogger applicationLogger,
            ICssFlatteningService cssFlatteningService) : base(settingsProvider, applicationLogger, cssFlatteningService) { }

        private static string inlineCss;

        

        private static string _template;
        internal virtual string Template {
            get { return _template ?? (_template = GetTemplateContent("c_Req_Emails.CanceledRequisition.html.resources")); }
        }

        protected static readonly IEnumerable<string> CssFiles = new List<string> {
"css/ConectaProveedores.EmailTheme.css",
"css/ConectaProveedores.c_Req_Emails.CanceledRequisition.css",
"css/ConectaProveedores.EmailTheme.extra.css",

        };

        public async Task<string> GetEmailContentAsync(IRequestContext requestContext, string inParami_ApplicationName,string inParami_RequisitionName,string inParami_UserName,string inParami_CanceledReason,string inParami_Enviroment,bool inParamIsPROD,string inParamRealEmailList,string inParamRealEmailCCList, CancellationToken cancellationToken) {
            if (string.IsNullOrEmpty(inlineCss)) {
                inlineCss = await GetInlineStyleSheetIncludeAsync(CssFiles, cancellationToken);
            }
            binaryImages = new Dictionary<string, Image>();
            var expressions = new TemplateData();

            expressions.Add("Kw8TdLXr46U29Qogwjs8Fkg_Subject", HtmlEncode(("Requisiciones - Cancelación de la Requisición "+inParami_RequisitionName).ToString()));
            expressions.Add("STYLE", inlineCss);
            expressions.Add("v3_Style", MergeStyles("text-align: right;"));
            expressions.Add("v8_Style", MergeStyles("text-align: left;"));
            expressions.Add("v9_Style", MergeStyles("margin-left: 0"));
            expressions.Add("v11_Style", MergeStyles("color: #ae0000; font-size: 16px;"));
            expressions.Add("v17_Style", MergeStyles("margin-left: 0"));
            expressions.Add("v20_Style", MergeStyles("margin-left: 0px"));
            expressions["KJGQAZPwDMEqUI_utmsJRQw_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", "img/ConectaProveedores.Logo.jpg")).ToString());
            expressions["KEA7Rksx7XkSaR3UMZFX0hw_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["K5ylY1MALEku4WudaSG941Q_Value"] = HtmlEncode(inParami_RequisitionName.ToString());
            expressions["KnqaCaxavdkOs3F8nELcnNg_Value"] = HtmlEncode(inParami_CanceledReason.ToString());
            expressions["KcfWPzstPhE2sBtvcl58Nnw_Value"] = HtmlEncode(("Por favor, accede al enlace"+" ").ToString());
            expressions["KPProoLLBKUqVn7EvF_8R4A_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", (((((string)AppUtils.SiteProperties[SitePropertiesModel.spCurrentDomain])))+"ConectaProveedores"))).ToString());
            expressions["KSlOJF_qtpkqNf6B0jpaMsQ_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["KaylOPyo_tUuMTDCQxEYDrQ_Value"] = HtmlEncode(BuiltInFunction.Year (BuiltInFunction.CurrDate ()).ToString());
            expressions["KQKzHik5nn06In1C_eE6B8w_Value"] = HtmlEncode(inParami_ApplicationName.ToString());

            var condition_KAD5dJEqtC0KX8zmFFSjtHw_ = (inParami_Enviroment=="PROD");
            expressions["KAD5dJEqtC0KX8zmFFSjtHw_"] = condition_KAD5dJEqtC0KX8zmFFSjtHw_;
            if (condition_KAD5dJEqtC0KX8zmFFSjtHw_) {
            } else {

            var condition_KMjPpU4KBMEeSDyZIUji1Mg_ = (inParami_Enviroment=="DEV");
            expressions["KMjPpU4KBMEeSDyZIUji1Mg_"] = condition_KMjPpU4KBMEeSDyZIUji1Mg_;
            if (condition_KMjPpU4KBMEeSDyZIUji1Mg_) {
            } else {

            var condition_KUK9ny9Ni90CWXvDAexgq0A_ = (inParami_Enviroment=="QA");
            expressions["KUK9ny9Ni90CWXvDAexgq0A_"] = condition_KUK9ny9Ni90CWXvDAexgq0A_;
            if (condition_KUK9ny9Ni90CWXvDAexgq0A_) {
            } else {
            }

            }

            }


            var condition_KEN3qorejoEWdaKiHjz1hbQ_ = (inParami_UserName!="");
            expressions["KEN3qorejoEWdaKiHjz1hbQ_"] = condition_KEN3qorejoEWdaKiHjz1hbQ_;
            if (condition_KEN3qorejoEWdaKiHjz1hbQ_) {
            expressions["K0nJIkb8fB0yJouPvwETxZw_Value"] = HtmlEncode((("Hola "+inParami_UserName)+"!").ToString());
            } else {
            }


            var condition_KkmoQZMpR0EiCqz9TmWTgEA_ = inParamIsPROD;
            expressions["KkmoQZMpR0EiCqz9TmWTgEA_"] = condition_KkmoQZMpR0EiCqz9TmWTgEA_;
            if (condition_KkmoQZMpR0EiCqz9TmWTgEA_) {
            } else {

            var condition_KxYDZ4jXSw06cLtcjICrhJw_ = (inParamRealEmailList!="");
            expressions["KxYDZ4jXSw06cLtcjICrhJw_"] = condition_KxYDZ4jXSw06cLtcjICrhJw_;
            if (condition_KxYDZ4jXSw06cLtcjICrhJw_) {
            expressions["K0stMDz5o_EGG1Gykr8MxYw_Value"] = HtmlEncode(("Se enviará a: "+inParamRealEmailList).ToString());
            } else {
            }


            var condition_KWbQhBVkydUWwXgC5w2aQoA_ = (inParamRealEmailCCList!="");
            expressions["KWbQhBVkydUWwXgC5w2aQoA_"] = condition_KWbQhBVkydUWwXgC5w2aQoA_;
            if (condition_KWbQhBVkydUWwXgC5w2aQoA_) {
            expressions["K6DWUiw_9YUantJRjCBThpQ_Value"] = HtmlEncode(("En CC: "+inParamRealEmailCCList).ToString());
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
