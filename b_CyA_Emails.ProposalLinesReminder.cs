using System.Web;
using OutSystems.Application.Abstractions.Emails;
using OutSystems.Application.Emails;
using OutSystems.Application.Core.Email;
using OutSystems.Application.Models.Emails;
using OutSystems.ObjectKeys;
using IterativeTemplateData = System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>>;
using TemplateData = System.Collections.Generic.Dictionary<string, object>;

namespace ssConectaProveedores.Flows.Flowb_CyA_Emails {

    public class b_CyA_Emails_ProposalLinesReminder : EmailScreen {

        public b_CyA_Emails_ProposalLinesReminder(
            ISettingsProvider settingsProvider,
            IApplicationLogger applicationLogger,
            ICssFlatteningService cssFlatteningService) : base(settingsProvider, applicationLogger, cssFlatteningService) { }

        private static string inlineCss;

        

        private static string _template;
        internal virtual string Template {
            get { return _template ?? (_template = GetTemplateContent("b_CyA_Emails.ProposalLinesReminder.html.resources")); }
        }

        protected static readonly IEnumerable<string> CssFiles = new List<string> {
"css/ConectaProveedores.EmailTheme.css",
"css/ConectaProveedores.b_CyA_Emails.ProposalLinesReminder.css",
"css/ConectaProveedores.EmailTheme.extra.css",

        };

        public async Task<string> GetEmailContentAsync(IRequestContext requestContext, string inParamApplicationName,string inParamProposalLinesCount,string inParami_Enviroment,string inParamRealEmailList,string inParamRealEmailCCList,bool inParamIsPROD, CancellationToken cancellationToken) {
            if (string.IsNullOrEmpty(inlineCss)) {
                inlineCss = await GetInlineStyleSheetIncludeAsync(CssFiles, cancellationToken);
            }
            binaryImages = new Dictionary<string, Image>();
            var expressions = new TemplateData();

            expressions.Add("Kx7xwfOgB_0ykPyhsLuKfTQ_Subject", HtmlEncode(((((inParami_Enviroment=="DEV")) ? ("(DEV)") : ((((inParami_Enviroment=="QA")) ? ("(QA)") : (""))))+"Se le han asignado pagos del Proceso de “Comisiones y/o Arrendamientos”, para ser aprobadas.").ToString()));
            expressions.Add("STYLE", inlineCss);
            expressions.Add("v3_Style", MergeStyles("text-align: right;"));
            expressions.Add("v8_Style", MergeStyles("text-align: left;"));
            expressions.Add("v15_Style", MergeStyles("margin-left: 0"));
            expressions.Add("v18_Style", MergeStyles("margin-left: 0px"));
            expressions["KJGQAZPwDMEqUI_utmsJRQw_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", "img/ConectaProveedores.Logo.jpg")).ToString());
            expressions["KJYG2rsn780aqF6jMH7CuBA_Value"] = HtmlEncode(inParamApplicationName.ToString());
            expressions["Kqv1mYYueJkSnrMMa4B6zwg_Value"] = HtmlEncode((((("Se le han asignado"+" ")+inParamProposalLinesCount)+" ")+"líneas de propuesta para su aprobación.").ToString());
            expressions["Ka6I574u8Y0KAHprdrJbsDg_Value"] = HtmlEncode(("Por favor, accede al enlace"+" ").ToString());
            expressions["KO7EPCEw7cEW8lt0CZOzbqw_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", (((((string)AppUtils.SiteProperties[SitePropertiesModel.spCurrentDomain])))+"ConectaProveedores"))).ToString());
            expressions["K_eRKtEBF90GuLg498WCfAg_Value"] = HtmlEncode(inParamApplicationName.ToString());
            expressions["KtaNz3_cPqk6_0J0_nOGNSQ_Value"] = HtmlEncode(BuiltInFunction.Year (BuiltInFunction.CurrDate ()).ToString());
            expressions["KpMGLV5VSxEiFsifsJ1N1Dw_Value"] = HtmlEncode(inParamApplicationName.ToString());

            var condition_Ko8VuX4K5n06RQY6Ovi2mYQ_ = (inParami_Enviroment=="PROD");
            expressions["Ko8VuX4K5n06RQY6Ovi2mYQ_"] = condition_Ko8VuX4K5n06RQY6Ovi2mYQ_;
            if (condition_Ko8VuX4K5n06RQY6Ovi2mYQ_) {
            } else {

            var condition_KOdrtfBn2Ek661w9pzu4VSw_ = (inParami_Enviroment=="DEV");
            expressions["KOdrtfBn2Ek661w9pzu4VSw_"] = condition_KOdrtfBn2Ek661w9pzu4VSw_;
            if (condition_KOdrtfBn2Ek661w9pzu4VSw_) {
            } else {

            var condition_KOpJgApWDMUCG7deTVgktMg_ = (inParami_Enviroment=="QA");
            expressions["KOpJgApWDMUCG7deTVgktMg_"] = condition_KOpJgApWDMUCG7deTVgktMg_;
            if (condition_KOpJgApWDMUCG7deTVgktMg_) {
            } else {
            }

            }

            }


            var condition_KTusjsv_zwEyF9Ti0W4qs6g_ = inParamIsPROD;
            expressions["KTusjsv_zwEyF9Ti0W4qs6g_"] = condition_KTusjsv_zwEyF9Ti0W4qs6g_;
            if (condition_KTusjsv_zwEyF9Ti0W4qs6g_) {
            } else {

            var condition_KcYMN0uRCWEq5A5u5j2aH_Q_ = (inParamRealEmailList!="");
            expressions["KcYMN0uRCWEq5A5u5j2aH_Q_"] = condition_KcYMN0uRCWEq5A5u5j2aH_Q_;
            if (condition_KcYMN0uRCWEq5A5u5j2aH_Q_) {
            expressions["KZlNRFsS3W0ihx6spYfH_UA_Value"] = HtmlEncode(("Se enviará a: "+inParamRealEmailList).ToString());
            } else {
            }


            var condition_KwZQ9tFuvs0uBt5f3rajFuw_ = (inParamRealEmailCCList!="");
            expressions["KwZQ9tFuvs0uBt5f3rajFuw_"] = condition_KwZQ9tFuvs0uBt5f3rajFuw_;
            if (condition_KwZQ9tFuvs0uBt5f3rajFuw_) {
            expressions["KRyCt4EgCikWQWaHwKRqW4g_Value"] = HtmlEncode(("En CC: "+inParamRealEmailCCList).ToString());
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
