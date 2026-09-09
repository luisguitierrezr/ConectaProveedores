using System.Web;
using OutSystems.Application.Abstractions.Emails;
using OutSystems.Application.Emails;
using OutSystems.Application.Core.Email;
using OutSystems.Application.Models.Emails;
using OutSystems.ObjectKeys;
using IterativeTemplateData = System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>>;
using TemplateData = System.Collections.Generic.Dictionary<string, object>;

namespace ssConectaProveedores.Flows.Flowb_CyA_Emails {

    public class b_CyA_Emails_TreasuryReminder : EmailScreen {

        public b_CyA_Emails_TreasuryReminder(
            ISettingsProvider settingsProvider,
            IApplicationLogger applicationLogger,
            ICssFlatteningService cssFlatteningService) : base(settingsProvider, applicationLogger, cssFlatteningService) { }

        private static string inlineCss;

        

        private static string _template;
        internal virtual string Template {
            get { return _template ?? (_template = GetTemplateContent("b_CyA_Emails.TreasuryReminder.html.resources")); }
        }

        protected static readonly IEnumerable<string> CssFiles = new List<string> {
"css/ConectaProveedores.EmailTheme.css",
"css/ConectaProveedores.b_CyA_Emails.TreasuryReminder.css",
"css/ConectaProveedores.EmailTheme.extra.css",

        };

        public async Task<string> GetEmailContentAsync(IRequestContext requestContext, string inParamApplicationName,string inParamApprovedCount,string inParami_Enviroment,int inParamBeingPaidCount,string inParamApprovedNames,string inParamBeingPaidNames,string inParamUserName,string inParamRealEmailList,string inParamRealEmailCCList,bool inParamIsPROD, CancellationToken cancellationToken) {
            if (string.IsNullOrEmpty(inlineCss)) {
                inlineCss = await GetInlineStyleSheetIncludeAsync(CssFiles, cancellationToken);
            }
            binaryImages = new Dictionary<string, Image>();
            var expressions = new TemplateData();

            expressions.Add("KWf_gBjGyA0GbuCPPFaVFbQ_Subject", HtmlEncode(((((inParami_Enviroment=="DEV")) ? ("(DEV)") : ((((inParami_Enviroment=="QA")) ? ("(QA)") : (""))))+"Se le han asignado pagos del Proceso de “Comisiones y/o Arrendamientos”, para ser pagas.").ToString()));
            expressions.Add("STYLE", inlineCss);
            expressions.Add("v3_Style", MergeStyles("text-align: right;"));
            expressions.Add("v8_Style", MergeStyles("text-align: left;"));
            expressions.Add("v19_Style", MergeStyles("margin-left: 0"));
            expressions.Add("v22_Style", MergeStyles("margin-left: 0px"));
            expressions["KJGQAZPwDMEqUI_utmsJRQw_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", "img/ConectaProveedores.Logo.jpg")).ToString());
            expressions["Kne1nOVMKN0G_ORzDv16Wgw_Value"] = HtmlEncode(inParamApplicationName.ToString());
            expressions["KxyFSrqCy7EiCEVQQ9oqmIg_Value"] = HtmlEncode((("Hola!,"+" ")+inParamUserName).ToString());
            expressions["Kz_Zcas_w0U6NY5tSTD4HXg_Value"] = HtmlEncode(((((inParamBeingPaidCount!=0)&&(inParamApprovedCount!=Convert.ToString(0)))) ? ((((((((((("Tienes"+" ")+Convert.ToString(inParamBeingPaidCount))+" ")+"propuestas que actualmente se están pagando")+" ")+"y")+" ")+inParamApprovedCount)+" ")+"propuestas actualmente aprobadas que requieren su atención.")) : ((((inParamBeingPaidCount!=0)) ? ((((("Tienes"+" ")+Convert.ToString(inParamBeingPaidCount))+" ")+"propuestas que actualmente se están pagando y requieren su atención.")) : ((((inParamApprovedCount!=Convert.ToString(0))) ? ((((("Tienes"+" ")+inParamApprovedCount)+" ")+"propuestas actualmente aprobadas que requieren su atención.")) : ("")))))).ToString());
            expressions["KkNPQMWF9REyy6nBeE_MDwQ_Value"] = HtmlEncode(("Por favor, accede al enlace"+" ").ToString());
            expressions["KUY7g6PH4A0W92x_h24_TsA_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", (((((string)AppUtils.SiteProperties[SitePropertiesModel.spCurrentDomain])))+"ConectaProveedores"))).ToString());
            expressions["Kc3I_vv0dKEOo3WB__szLrQ_Value"] = HtmlEncode(inParamApplicationName.ToString());
            expressions["K9Rq32fNo3UyH82B6p3Vvdw_Value"] = HtmlEncode(BuiltInFunction.Year (BuiltInFunction.CurrDate ()).ToString());
            expressions["KjmpXQmN_CEKATYdDSmJHTw_Value"] = HtmlEncode(inParamApplicationName.ToString());

            var condition_KauxyfrH8jEefQFYYWTJVfg_ = (inParami_Enviroment=="PROD");
            expressions["KauxyfrH8jEefQFYYWTJVfg_"] = condition_KauxyfrH8jEefQFYYWTJVfg_;
            if (condition_KauxyfrH8jEefQFYYWTJVfg_) {
            } else {

            var condition_KquHGd_TK_EGf0Y9RPMQZPQ_ = (inParami_Enviroment=="DEV");
            expressions["KquHGd_TK_EGf0Y9RPMQZPQ_"] = condition_KquHGd_TK_EGf0Y9RPMQZPQ_;
            if (condition_KquHGd_TK_EGf0Y9RPMQZPQ_) {
            } else {

            var condition_Kcfc4JtwnGUeZ_PY288DTOA_ = (inParami_Enviroment=="QA");
            expressions["Kcfc4JtwnGUeZ_PY288DTOA_"] = condition_Kcfc4JtwnGUeZ_PY288DTOA_;
            if (condition_Kcfc4JtwnGUeZ_PY288DTOA_) {
            } else {
            }

            }

            }


            var condition_KOtEe6_o1P0yOdpBepdpj0A_ = (inParamBeingPaidCount!=0);
            expressions["KOtEe6_o1P0yOdpBepdpj0A_"] = condition_KOtEe6_o1P0yOdpBepdpj0A_;
            if (condition_KOtEe6_o1P0yOdpBepdpj0A_) {
            expressions["KCfex9WGbl06rCCKdUH_EyQ_Value"] = HtmlEncode((("En proceso de pago:"+" ")+inParamBeingPaidNames).ToString());
            } else {
            }


            var condition_KCsHuMcYdg0aRNNrLql6h2Q_ = (inParamApprovedCount!=Convert.ToString(0));
            expressions["KCsHuMcYdg0aRNNrLql6h2Q_"] = condition_KCsHuMcYdg0aRNNrLql6h2Q_;
            if (condition_KCsHuMcYdg0aRNNrLql6h2Q_) {
            expressions["KWvRfbK1HcEeB4wv7JNy4aw_Value"] = HtmlEncode((("Aprobado:"+" ")+inParamApprovedNames).ToString());
            } else {
            }


            var condition_KTUoa1tp5O0GUsxzuRDzF3Q_ = inParamIsPROD;
            expressions["KTUoa1tp5O0GUsxzuRDzF3Q_"] = condition_KTUoa1tp5O0GUsxzuRDzF3Q_;
            if (condition_KTUoa1tp5O0GUsxzuRDzF3Q_) {
            } else {

            var condition_K0MolWiTRi0aOztYJTqqe6A_ = (inParamRealEmailList!="");
            expressions["K0MolWiTRi0aOztYJTqqe6A_"] = condition_K0MolWiTRi0aOztYJTqqe6A_;
            if (condition_K0MolWiTRi0aOztYJTqqe6A_) {
            expressions["KOIkHMCLZJka4DQ6OZPR_3A_Value"] = HtmlEncode(("Se enviará a: "+inParamRealEmailList).ToString());
            } else {
            }


            var condition_KAYJYIriO30KQ6kmS_s21xQ_ = (inParamRealEmailCCList!="");
            expressions["KAYJYIriO30KQ6kmS_s21xQ_"] = condition_KAYJYIriO30KQ6kmS_s21xQ_;
            if (condition_KAYJYIriO30KQ6kmS_s21xQ_) {
            expressions["KDhImzL9YeUaYC9qDn0K0YQ_Value"] = HtmlEncode(("En CC: "+inParamRealEmailCCList).ToString());
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
