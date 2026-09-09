using System.Web;
using OutSystems.Application.Abstractions.Emails;
using OutSystems.Application.Emails;
using OutSystems.Application.Core.Email;
using OutSystems.Application.Models.Emails;
using OutSystems.ObjectKeys;
using IterativeTemplateData = System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>>;
using TemplateData = System.Collections.Generic.Dictionary<string, object>;

namespace ssConectaProveedores.Flows.Flowj_FoliosSAE_Emails {

    public class j_FoliosSAE_Emails_FailedEntry : EmailScreen {

        public j_FoliosSAE_Emails_FailedEntry(
            ISettingsProvider settingsProvider,
            IApplicationLogger applicationLogger,
            ICssFlatteningService cssFlatteningService) : base(settingsProvider, applicationLogger, cssFlatteningService) { }

        private static string inlineCss;

        

        private static string _template;
        internal virtual string Template {
            get { return _template ?? (_template = GetTemplateContent("j_FoliosSAE_Emails.FailedEntry.html.resources")); }
        }

        protected static readonly IEnumerable<string> CssFiles = new List<string> {
"css/ConectaProveedores.EmailTheme.css",
"css/ConectaProveedores.j_FoliosSAE_Emails.FailedEntry.css",
"css/ConectaProveedores.EmailTheme.extra.css",

        };

        public async Task<string> GetEmailContentAsync(IRequestContext requestContext, string inParami_ApplicationName,string inParami_FolioNumber,string inParami_UserName,string inParami_Enviroment,string inParami_EntryNumber,string inParamRealEmailList,string inParamRealEmailCCList,bool inParamIsPROD, CancellationToken cancellationToken) {
            if (string.IsNullOrEmpty(inlineCss)) {
                inlineCss = await GetInlineStyleSheetIncludeAsync(CssFiles, cancellationToken);
            }
            binaryImages = new Dictionary<string, Image>();
            var expressions = new TemplateData();

            expressions.Add("K2neqkUQjskGcQu__8TI_rQ_Subject", HtmlEncode(("Folios - Folio Entrada Fallida"+inParami_FolioNumber).ToString()));
            expressions.Add("STYLE", inlineCss);
            expressions.Add("v3_Style", MergeStyles("text-align: right;"));
            expressions.Add("v8_Style", MergeStyles("text-align: left;"));
            expressions.Add("v15_Style", MergeStyles("margin-left: 0"));
            expressions.Add("v18_Style", MergeStyles("margin-left: 0px"));
            expressions["KJGQAZPwDMEqUI_utmsJRQw_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", "img/ConectaProveedores.Logo.jpg")).ToString());
            expressions["K9KuEfb2SaEymgIfKMpjgWg_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["KjOT1_poI002TxlRvP14JYg_Value"] = HtmlEncode(inParami_FolioNumber.ToString());
            expressions["KN9KWAoMamkqWMwBSSc03DA_Value"] = HtmlEncode((" acaba de tener entrada fallida"+(((inParami_EntryNumber!="")) ? (((" con el número: "+inParami_EntryNumber)+".")) : ("."))).ToString());
            expressions["Kh0fGM9gyzEimvs5fMrK68A_Value"] = HtmlEncode(("Por favor, accede al enlace"+" ").ToString());
            expressions["KUenmJGPIMUGCvIyabjxVJA_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", (((((string)AppUtils.SiteProperties[SitePropertiesModel.spCurrentDomain])))+"ConectaProveedores"))).ToString());
            expressions["K3cRs9Jco8EyK6ubhARc35w_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["KxoElJBcyKUmX5fAbbVgTbg_Value"] = HtmlEncode(BuiltInFunction.Year (BuiltInFunction.CurrDate ()).ToString());
            expressions["KnT_5XTNKHESowbaxvvZpbA_Value"] = HtmlEncode(inParami_ApplicationName.ToString());

            var condition_KQodiX0uq60Scx7r1OzhEew_ = (inParami_Enviroment=="PROD");
            expressions["KQodiX0uq60Scx7r1OzhEew_"] = condition_KQodiX0uq60Scx7r1OzhEew_;
            if (condition_KQodiX0uq60Scx7r1OzhEew_) {
            } else {

            var condition_KlIsfhTLglk_zOHzMIm1L5w_ = (inParami_Enviroment=="DEV");
            expressions["KlIsfhTLglk_zOHzMIm1L5w_"] = condition_KlIsfhTLglk_zOHzMIm1L5w_;
            if (condition_KlIsfhTLglk_zOHzMIm1L5w_) {
            } else {

            var condition_K1hvTxmo5BU2b_XEq0Gz_MQ_ = (inParami_Enviroment=="QA");
            expressions["K1hvTxmo5BU2b_XEq0Gz_MQ_"] = condition_K1hvTxmo5BU2b_XEq0Gz_MQ_;
            if (condition_K1hvTxmo5BU2b_XEq0Gz_MQ_) {
            } else {
            }

            }

            }


            var condition_KmZox5g5vHUi5JPEPjSh3_w_ = (inParami_UserName!="");
            expressions["KmZox5g5vHUi5JPEPjSh3_w_"] = condition_KmZox5g5vHUi5JPEPjSh3_w_;
            if (condition_KmZox5g5vHUi5JPEPjSh3_w_) {
            expressions["KwyeYWC5zh0GuNLhzKlXaVQ_Value"] = HtmlEncode((("Hola "+inParami_UserName)+"!").ToString());
            } else {
            }


            var condition_KuaVPA4MqhEGySVWUXL9mxQ_ = inParamIsPROD;
            expressions["KuaVPA4MqhEGySVWUXL9mxQ_"] = condition_KuaVPA4MqhEGySVWUXL9mxQ_;
            if (condition_KuaVPA4MqhEGySVWUXL9mxQ_) {
            } else {

            var condition_KnU5AutvXsUmGgZ7mIO4C5Q_ = (inParamRealEmailList!="");
            expressions["KnU5AutvXsUmGgZ7mIO4C5Q_"] = condition_KnU5AutvXsUmGgZ7mIO4C5Q_;
            if (condition_KnU5AutvXsUmGgZ7mIO4C5Q_) {
            expressions["K5ZwUaAcBd0KmH2_QF4xhww_Value"] = HtmlEncode(("Se enviará a: "+inParamRealEmailList).ToString());
            } else {
            }


            var condition_KkNkCIvngx0yLqGxEjR0qRQ_ = (inParamRealEmailCCList!="");
            expressions["KkNkCIvngx0yLqGxEjR0qRQ_"] = condition_KkNkCIvngx0yLqGxEjR0qRQ_;
            if (condition_KkNkCIvngx0yLqGxEjR0qRQ_) {
            expressions["KAoWRH78fj0CsJx6I0hj_0g_Value"] = HtmlEncode(("En CC: "+inParamRealEmailCCList).ToString());
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
