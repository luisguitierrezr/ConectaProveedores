using System.Web;
using OutSystems.Application.Abstractions.Emails;
using OutSystems.Application.Emails;
using OutSystems.Application.Core.Email;
using OutSystems.Application.Models.Emails;
using OutSystems.ObjectKeys;
using IterativeTemplateData = System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>>;
using TemplateData = System.Collections.Generic.Dictionary<string, object>;

namespace ssConectaProveedores.Flows.Flowj_FoliosSAE_Emails {

    public class j_FoliosSAE_Emails_FirstApproverFolio : EmailScreen {

        public j_FoliosSAE_Emails_FirstApproverFolio(
            ISettingsProvider settingsProvider,
            IApplicationLogger applicationLogger,
            ICssFlatteningService cssFlatteningService) : base(settingsProvider, applicationLogger, cssFlatteningService) { }

        private static string inlineCss;

        

        private static string _template;
        internal virtual string Template {
            get { return _template ?? (_template = GetTemplateContent("j_FoliosSAE_Emails.FirstApproverFolio.html.resources")); }
        }

        protected static readonly IEnumerable<string> CssFiles = new List<string> {
"css/ConectaProveedores.EmailTheme.css",
"css/ConectaProveedores.j_FoliosSAE_Emails.FirstApproverFolio.css",
"css/ConectaProveedores.EmailTheme.extra.css",

        };

        public async Task<string> GetEmailContentAsync(IRequestContext requestContext, string inParami_ApplicationName,string inParami_Environment,string inParami_FolioNumber,string inParami_UserName,string inParami_ProveedorName,string inParamRealEmailList,string inParamRealEmailCCList,bool inParamIsPROD, CancellationToken cancellationToken) {
            if (string.IsNullOrEmpty(inlineCss)) {
                inlineCss = await GetInlineStyleSheetIncludeAsync(CssFiles, cancellationToken);
            }
            binaryImages = new Dictionary<string, Image>();
            var expressions = new TemplateData();

            expressions.Add("KprseZlEVsE2VsVHL_WCD8g_Subject", HtmlEncode(("Folios - Aprobar Folio "+inParami_FolioNumber).ToString()));
            expressions.Add("STYLE", inlineCss);
            expressions.Add("v3_Style", MergeStyles("text-align: right;"));
            expressions.Add("v8_Style", MergeStyles("text-align: left;"));
            expressions.Add("v16_Style", MergeStyles("margin-left: 0"));
            expressions.Add("v19_Style", MergeStyles("margin-left: 0px"));
            expressions["KJGQAZPwDMEqUI_utmsJRQw_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", "img/ConectaProveedores.Logo.jpg")).ToString());
            expressions["KXUsWdDLrUU_JM_HnOFVcTQ_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["Kfx1w1Nwimkytb6uPCDBU_w_Value"] = HtmlEncode(inParami_FolioNumber.ToString());
            expressions["K7O08vIUrJkGqa6_ZgjiYeA_Value"] = HtmlEncode(inParami_ProveedorName.ToString());
            expressions["KejSWoLznO0CQrUtIjabVpg_Value"] = HtmlEncode(("Por favor, accede al enlace"+" ").ToString());
            expressions["KlMUEkVMa5k_SMSrvdeGCtQ_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", (((((string)AppUtils.SiteProperties[SitePropertiesModel.spCurrentDomain])))+"ConectaProveedores"))).ToString());
            expressions["Kz8U4diBjW0CntP_tbWE6tw_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["KdugFqkUsJk_9sqL_Vsk3mw_Value"] = HtmlEncode(BuiltInFunction.Year (BuiltInFunction.CurrDate ()).ToString());
            expressions["K0VdSn2EQEkWW_CBSwICLDw_Value"] = HtmlEncode(inParami_ApplicationName.ToString());

            var condition_KsBDAWFzo20GOrs60kxJYPg_ = (inParami_Environment=="PROD");
            expressions["KsBDAWFzo20GOrs60kxJYPg_"] = condition_KsBDAWFzo20GOrs60kxJYPg_;
            if (condition_KsBDAWFzo20GOrs60kxJYPg_) {
            } else {

            var condition_KYau9CQQ3AEWgZof_8a7XiQ_ = (inParami_Environment=="DEV");
            expressions["KYau9CQQ3AEWgZof_8a7XiQ_"] = condition_KYau9CQQ3AEWgZof_8a7XiQ_;
            if (condition_KYau9CQQ3AEWgZof_8a7XiQ_) {
            } else {

            var condition_KB0m3JNTOTUuzqrWspaQVPg_ = (inParami_Environment=="QA");
            expressions["KB0m3JNTOTUuzqrWspaQVPg_"] = condition_KB0m3JNTOTUuzqrWspaQVPg_;
            if (condition_KB0m3JNTOTUuzqrWspaQVPg_) {
            } else {
            }

            }

            }


            var condition_KFwB2KpkRvUWSaGsHR2zNGQ_ = (inParami_UserName!="");
            expressions["KFwB2KpkRvUWSaGsHR2zNGQ_"] = condition_KFwB2KpkRvUWSaGsHR2zNGQ_;
            if (condition_KFwB2KpkRvUWSaGsHR2zNGQ_) {
            expressions["KFX_Z5cXtA022EP9xSJinIA_Value"] = HtmlEncode((("Hola "+inParami_UserName)+"!").ToString());
            } else {
            }


            var condition_KHmEINJvKR0Sf2eC7AAm4Hw_ = inParamIsPROD;
            expressions["KHmEINJvKR0Sf2eC7AAm4Hw_"] = condition_KHmEINJvKR0Sf2eC7AAm4Hw_;
            if (condition_KHmEINJvKR0Sf2eC7AAm4Hw_) {
            } else {

            var condition_K6aJ06KYAzU_t_sdRtpKtgA_ = (inParamRealEmailList!="");
            expressions["K6aJ06KYAzU_t_sdRtpKtgA_"] = condition_K6aJ06KYAzU_t_sdRtpKtgA_;
            if (condition_K6aJ06KYAzU_t_sdRtpKtgA_) {
            expressions["K6ilXndUbT0yxR71wENav_A_Value"] = HtmlEncode(("Se enviará a: "+inParamRealEmailList).ToString());
            } else {
            }


            var condition_KUcesLNcc8ESwne8pokHfQA_ = (inParamRealEmailCCList!="");
            expressions["KUcesLNcc8ESwne8pokHfQA_"] = condition_KUcesLNcc8ESwne8pokHfQA_;
            if (condition_KUcesLNcc8ESwne8pokHfQA_) {
            expressions["KCXIrwIqycE_VcUDrbY_Ryg_Value"] = HtmlEncode(("En CC: "+inParamRealEmailCCList).ToString());
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
