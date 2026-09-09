using System.Web;
using OutSystems.Application.Abstractions.Emails;
using OutSystems.Application.Emails;
using OutSystems.Application.Core.Email;
using OutSystems.Application.Models.Emails;
using OutSystems.ObjectKeys;
using IterativeTemplateData = System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>>;
using TemplateData = System.Collections.Generic.Dictionary<string, object>;

namespace ssConectaProveedores.Flows.Flowj_FoliosSAE_Emails {

    public class j_FoliosSAE_Emails_FolioInvoiceRejected : EmailScreen {

        public j_FoliosSAE_Emails_FolioInvoiceRejected(
            ISettingsProvider settingsProvider,
            IApplicationLogger applicationLogger,
            ICssFlatteningService cssFlatteningService) : base(settingsProvider, applicationLogger, cssFlatteningService) { }

        private static string inlineCss;

        

        private static string _template;
        internal virtual string Template {
            get { return _template ?? (_template = GetTemplateContent("j_FoliosSAE_Emails.FolioInvoiceRejected.html.resources")); }
        }

        protected static readonly IEnumerable<string> CssFiles = new List<string> {
"css/ConectaProveedores.EmailTheme.css",
"css/ConectaProveedores.j_FoliosSAE_Emails.FolioInvoiceRejected.css",
"css/ConectaProveedores.EmailTheme.extra.css",

        };

        public async Task<string> GetEmailContentAsync(IRequestContext requestContext, string inParami_ApplicationName,string inParami_FolioNumber,string inParami_UserName,string inParami_RejectMotive,string inParami_Enviroment,string inParamRealEmailList,string inParamRealEmailCCList,bool inParamIsPROD, CancellationToken cancellationToken) {
            if (string.IsNullOrEmpty(inlineCss)) {
                inlineCss = await GetInlineStyleSheetIncludeAsync(CssFiles, cancellationToken);
            }
            binaryImages = new Dictionary<string, Image>();
            var expressions = new TemplateData();

            expressions.Add("KgRBlJbe07UyAEt_1K_ePXQ_Subject", HtmlEncode((("Folios - Folio "+inParami_FolioNumber)+" factura rechazada").ToString()));
            expressions.Add("STYLE", inlineCss);
            expressions.Add("v3_Style", MergeStyles("text-align: right;"));
            expressions.Add("v8_Style", MergeStyles("text-align: left;"));
            expressions.Add("v9_Style", MergeStyles("margin-left: 0"));
            expressions.Add("v12_Style", MergeStyles("color: #ae0000; font-size: 16px;"));
            expressions.Add("v18_Style", MergeStyles("margin-left: 0"));
            expressions.Add("v21_Style", MergeStyles("margin-left: 0px"));
            expressions["KJGQAZPwDMEqUI_utmsJRQw_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", "img/ConectaProveedores.Logo.jpg")).ToString());
            expressions["KkQC5uZc61Ual_lqAAmdINA_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["KvltaykVHWkOM6_Hqny02Rg_Value"] = HtmlEncode(inParami_FolioNumber.ToString());
            expressions["KrI4DFgl1_UOO3xoiyCSXcQ_Value"] = HtmlEncode(inParami_RejectMotive.ToString());
            expressions["KZkthIUEWrUCk_BslcNflRQ_Value"] = HtmlEncode(("Por favor, accede al enlace"+" ").ToString());
            expressions["KEgiIXBjDW0G_48pvlwmr6g_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", (((((string)AppUtils.SiteProperties[SitePropertiesModel.spCurrentDomain])))+"ConectaProveedores"))).ToString());
            expressions["KCX2qkLTjSk61vkRU1LA37A_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["KnVewdvPYBUaLzV9psWQ4Pw_Value"] = HtmlEncode(BuiltInFunction.Year (BuiltInFunction.CurrDate ()).ToString());
            expressions["KiN4ZkkuP9EmQW7aFqFVtug_Value"] = HtmlEncode(inParami_ApplicationName.ToString());

            var condition_KlZGdAcPefUi45WMhpb88dA_ = (inParami_Enviroment=="PROD");
            expressions["KlZGdAcPefUi45WMhpb88dA_"] = condition_KlZGdAcPefUi45WMhpb88dA_;
            if (condition_KlZGdAcPefUi45WMhpb88dA_) {
            } else {

            var condition_K48dYR5tmCUyyMReiBFFpTg_ = (inParami_Enviroment=="DEV");
            expressions["K48dYR5tmCUyyMReiBFFpTg_"] = condition_K48dYR5tmCUyyMReiBFFpTg_;
            if (condition_K48dYR5tmCUyyMReiBFFpTg_) {
            } else {

            var condition_KX7K2AIzrA0KzRl3yODi4RA_ = (inParami_Enviroment=="QA");
            expressions["KX7K2AIzrA0KzRl3yODi4RA_"] = condition_KX7K2AIzrA0KzRl3yODi4RA_;
            if (condition_KX7K2AIzrA0KzRl3yODi4RA_) {
            } else {
            }

            }

            }


            var condition_KriM7RqL25kWOIsxuG5iwZw_ = (inParami_UserName!="");
            expressions["KriM7RqL25kWOIsxuG5iwZw_"] = condition_KriM7RqL25kWOIsxuG5iwZw_;
            if (condition_KriM7RqL25kWOIsxuG5iwZw_) {
            expressions["KPrq7MF9nT0qI0PZCV55GXA_Value"] = HtmlEncode((("Hola "+inParami_UserName)+"!").ToString());
            } else {
            }


            var condition_KtMiIjG4uGE__HxIPnQIGzQ_ = inParamIsPROD;
            expressions["KtMiIjG4uGE__HxIPnQIGzQ_"] = condition_KtMiIjG4uGE__HxIPnQIGzQ_;
            if (condition_KtMiIjG4uGE__HxIPnQIGzQ_) {
            } else {

            var condition_KtW_Vgo8WVE65RHvuIQGwkg_ = (inParamRealEmailList!="");
            expressions["KtW_Vgo8WVE65RHvuIQGwkg_"] = condition_KtW_Vgo8WVE65RHvuIQGwkg_;
            if (condition_KtW_Vgo8WVE65RHvuIQGwkg_) {
            expressions["KpjVV9XKP40iPKlR_BqgpVQ_Value"] = HtmlEncode(("Se enviará a: "+inParamRealEmailList).ToString());
            } else {
            }


            var condition_K_hEL8YQFVUCA996Z3KH5tQ_ = (inParamRealEmailCCList!="");
            expressions["K_hEL8YQFVUCA996Z3KH5tQ_"] = condition_K_hEL8YQFVUCA996Z3KH5tQ_;
            if (condition_K_hEL8YQFVUCA996Z3KH5tQ_) {
            expressions["KYSg2i6DQF0a90l2TwZYNuQ_Value"] = HtmlEncode(("En CC: "+inParamRealEmailCCList).ToString());
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
