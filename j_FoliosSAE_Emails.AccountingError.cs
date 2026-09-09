using System.Web;
using OutSystems.Application.Abstractions.Emails;
using OutSystems.Application.Emails;
using OutSystems.Application.Core.Email;
using OutSystems.Application.Models.Emails;
using OutSystems.ObjectKeys;
using IterativeTemplateData = System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>>;
using TemplateData = System.Collections.Generic.Dictionary<string, object>;

namespace ssConectaProveedores.Flows.Flowj_FoliosSAE_Emails {

    public class j_FoliosSAE_Emails_AccountingError : EmailScreen {

        public j_FoliosSAE_Emails_AccountingError(
            ISettingsProvider settingsProvider,
            IApplicationLogger applicationLogger,
            ICssFlatteningService cssFlatteningService) : base(settingsProvider, applicationLogger, cssFlatteningService) { }

        private static string inlineCss;

        

        private static string _template;
        internal virtual string Template {
            get { return _template ?? (_template = GetTemplateContent("j_FoliosSAE_Emails.AccountingError.html.resources")); }
        }

        protected static readonly IEnumerable<string> CssFiles = new List<string> {
"css/ConectaProveedores.EmailTheme.css",
"css/ConectaProveedores.j_FoliosSAE_Emails.AccountingError.css",
"css/ConectaProveedores.EmailTheme.extra.css",

        };

        public async Task<string> GetEmailContentAsync(IRequestContext requestContext, string inParami_ApplicationName,string inParami_FolioNumber,string inParami_UserName,string inParami_Environment,string inParamRealEmailList,string inParamRealEmailCCList,bool inParamIsPROD, CancellationToken cancellationToken) {
            if (string.IsNullOrEmpty(inlineCss)) {
                inlineCss = await GetInlineStyleSheetIncludeAsync(CssFiles, cancellationToken);
            }
            binaryImages = new Dictionary<string, Image>();
            var expressions = new TemplateData();

            expressions.Add("KPnILKbm0IECZEWxWZZ1Mow_Subject", HtmlEncode(("Folios - Folio Error en Contabilización "+inParami_FolioNumber).ToString()));
            expressions.Add("STYLE", inlineCss);
            expressions.Add("v3_Style", MergeStyles("text-align: right;"));
            expressions.Add("v8_Style", MergeStyles("text-align: left;"));
            expressions.Add("v15_Style", MergeStyles("margin-left: 0"));
            expressions.Add("v18_Style", MergeStyles("margin-left: 0px"));
            expressions["KJGQAZPwDMEqUI_utmsJRQw_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", "img/ConectaProveedores.Logo.jpg")).ToString());
            expressions["Kl8UfoNQwukmHNSQ24Lm1zA_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["K3w6C9T5rr0_RwqJ6hg1tYg_Value"] = HtmlEncode(inParami_FolioNumber.ToString());
            expressions["KmjA6zPa5FE_Kx1InRj9yOg_Value"] = HtmlEncode(("Por favor, accede al enlace"+" ").ToString());
            expressions["KV970cyMdO0CrdHfFT30X_Q_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", (((((string)AppUtils.SiteProperties[SitePropertiesModel.spCurrentDomain])))+"ConectaProveedores"))).ToString());
            expressions["K2wrjglwRRk2cO6HV_FJmaw_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["Klt_bq3XXI0m9e8hN9RCI9A_Value"] = HtmlEncode(BuiltInFunction.Year (BuiltInFunction.CurrDate ()).ToString());
            expressions["KwgGPXbcbXUml6RFRm0KU3A_Value"] = HtmlEncode(inParami_ApplicationName.ToString());

            var condition_Kn6n6M62ZXk_rYL32El6xkA_ = (inParami_Environment=="PROD");
            expressions["Kn6n6M62ZXk_rYL32El6xkA_"] = condition_Kn6n6M62ZXk_rYL32El6xkA_;
            if (condition_Kn6n6M62ZXk_rYL32El6xkA_) {
            } else {

            var condition_KCJVv8vMS0kGbPpGCRdvXxg_ = (inParami_Environment=="DEV");
            expressions["KCJVv8vMS0kGbPpGCRdvXxg_"] = condition_KCJVv8vMS0kGbPpGCRdvXxg_;
            if (condition_KCJVv8vMS0kGbPpGCRdvXxg_) {
            } else {

            var condition_Kn_jbH1L8MUeddef9GIyjbQ_ = (inParami_Environment=="QA");
            expressions["Kn_jbH1L8MUeddef9GIyjbQ_"] = condition_Kn_jbH1L8MUeddef9GIyjbQ_;
            if (condition_Kn_jbH1L8MUeddef9GIyjbQ_) {
            } else {
            }

            }

            }


            var condition_KGMp_72FqskKtdySyh_bWxw_ = (inParami_UserName!="");
            expressions["KGMp_72FqskKtdySyh_bWxw_"] = condition_KGMp_72FqskKtdySyh_bWxw_;
            if (condition_KGMp_72FqskKtdySyh_bWxw_) {
            expressions["KyZkuov05mE6enc_TmXhJog_Value"] = HtmlEncode((("Hola "+inParami_UserName)+"!").ToString());
            } else {
            }


            var condition_KmUuPVbSI0Umv_5GY3qdgeg_ = inParamIsPROD;
            expressions["KmUuPVbSI0Umv_5GY3qdgeg_"] = condition_KmUuPVbSI0Umv_5GY3qdgeg_;
            if (condition_KmUuPVbSI0Umv_5GY3qdgeg_) {
            } else {

            var condition_Kb1AHYctt_kunpxllC9mySQ_ = (inParamRealEmailList!="");
            expressions["Kb1AHYctt_kunpxllC9mySQ_"] = condition_Kb1AHYctt_kunpxllC9mySQ_;
            if (condition_Kb1AHYctt_kunpxllC9mySQ_) {
            expressions["KkdpHfF7I30_2UKgX3GkEdA_Value"] = HtmlEncode(("Se enviará a: "+inParamRealEmailList).ToString());
            } else {
            }


            var condition_K2DUz54fDd0WzyA6RFr70ng_ = (inParamRealEmailCCList!="");
            expressions["K2DUz54fDd0WzyA6RFr70ng_"] = condition_K2DUz54fDd0WzyA6RFr70ng_;
            if (condition_K2DUz54fDd0WzyA6RFr70ng_) {
            expressions["KN_zVh48QtUGch151TLikow_Value"] = HtmlEncode(("En CC: "+inParamRealEmailCCList).ToString());
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
