using System.Web;
using OutSystems.Application.Abstractions.Emails;
using OutSystems.Application.Emails;
using OutSystems.Application.Core.Email;
using OutSystems.Application.Models.Emails;
using OutSystems.ObjectKeys;
using IterativeTemplateData = System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>>;
using TemplateData = System.Collections.Generic.Dictionary<string, object>;

namespace ssConectaProveedores.Flows.Flowj_FoliosSAE_Emails {

    public class j_FoliosSAE_Emails_CanceledFolio : EmailScreen {

        public j_FoliosSAE_Emails_CanceledFolio(
            ISettingsProvider settingsProvider,
            IApplicationLogger applicationLogger,
            ICssFlatteningService cssFlatteningService) : base(settingsProvider, applicationLogger, cssFlatteningService) { }

        private static string inlineCss;

        

        private static string _template;
        internal virtual string Template {
            get { return _template ?? (_template = GetTemplateContent("j_FoliosSAE_Emails.CanceledFolio.html.resources")); }
        }

        protected static readonly IEnumerable<string> CssFiles = new List<string> {
"css/ConectaProveedores.EmailTheme.css",
"css/ConectaProveedores.j_FoliosSAE_Emails.CanceledFolio.css",
"css/ConectaProveedores.EmailTheme.extra.css",

        };

        public async Task<string> GetEmailContentAsync(IRequestContext requestContext, string inParami_ApplicationName,string inParami_FolioNumber,string inParami_UserName,string inParami_CancelationMotive,string inParami_GeneralCancelationMotive,string inParami_Enviroment,string inParamRealEmailList,string inParamRealEmailCCList,bool inParamIsPROD, CancellationToken cancellationToken) {
            if (string.IsNullOrEmpty(inlineCss)) {
                inlineCss = await GetInlineStyleSheetIncludeAsync(CssFiles, cancellationToken);
            }
            binaryImages = new Dictionary<string, Image>();
            var expressions = new TemplateData();

            expressions.Add("KqEjDDSZ_MkSAJZgtmh5NKA_Subject", HtmlEncode(("Folios - Cancelación de Folio "+inParami_FolioNumber).ToString()));
            expressions.Add("STYLE", inlineCss);
            expressions.Add("v3_Style", MergeStyles("text-align: right;"));
            expressions.Add("v8_Style", MergeStyles("text-align: left;"));
            expressions.Add("v9_Style", MergeStyles("margin-left: 0"));
            expressions.Add("v12_Style", MergeStyles("color: #ae0000; font-size: 16px;"));
            expressions.Add("v14_Style", MergeStyles("color: #ae0000; font-size: 16px;"));
            expressions.Add("v21_Style", MergeStyles("margin-left: 0"));
            expressions.Add("v24_Style", MergeStyles("margin-left: 0px"));
            expressions["KJGQAZPwDMEqUI_utmsJRQw_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", "img/ConectaProveedores.Logo.jpg")).ToString());
            expressions["KhvoqcnewXE25qAxvZTK5JA_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["KziZM1jy4SEmv1iCg9NFY8A_Value"] = HtmlEncode(inParami_FolioNumber.ToString());
            expressions["Kwrt9LTmndEOjTg9QF2ZUng_Value"] = HtmlEncode(("Por favor, accede al enlace"+" ").ToString());
            expressions["KkACTUEqrSk_H6nf56YrP5g_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", (((((string)AppUtils.SiteProperties[SitePropertiesModel.spCurrentDomain])))+"ConectaProveedores"))).ToString());
            expressions["KWkFMLplThkmCxSqr_nL2ug_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["KNfMnmkVCYkWi9X3zZCk37Q_Value"] = HtmlEncode(BuiltInFunction.Year (BuiltInFunction.CurrDate ()).ToString());
            expressions["KW6YJQBpOd0_blL4FLAnDpg_Value"] = HtmlEncode(inParami_ApplicationName.ToString());

            var condition_KIx0_gv_3AUWBse2w5Tedwg_ = (inParami_Enviroment=="PROD");
            expressions["KIx0_gv_3AUWBse2w5Tedwg_"] = condition_KIx0_gv_3AUWBse2w5Tedwg_;
            if (condition_KIx0_gv_3AUWBse2w5Tedwg_) {
            } else {

            var condition_KA91kN28fcU2jS4p_Q49Iag_ = (inParami_Enviroment=="DEV");
            expressions["KA91kN28fcU2jS4p_Q49Iag_"] = condition_KA91kN28fcU2jS4p_Q49Iag_;
            if (condition_KA91kN28fcU2jS4p_Q49Iag_) {
            } else {

            var condition_K0hs_88pEXU_cox_yX_mugg_ = (inParami_Enviroment=="QA");
            expressions["K0hs_88pEXU_cox_yX_mugg_"] = condition_K0hs_88pEXU_cox_yX_mugg_;
            if (condition_K0hs_88pEXU_cox_yX_mugg_) {
            } else {
            }

            }

            }


            var condition_Ks50Qt45O10iGRoVw2HwafQ_ = (inParami_UserName!="");
            expressions["Ks50Qt45O10iGRoVw2HwafQ_"] = condition_Ks50Qt45O10iGRoVw2HwafQ_;
            if (condition_Ks50Qt45O10iGRoVw2HwafQ_) {
            expressions["KeMp0JpZY3EyPSxHtlWakXA_Value"] = HtmlEncode((("Hola "+inParami_UserName)+"!").ToString());
            } else {
            }


            var condition_KeEyKeesLY0iiUanIPVYFqw_ = (inParami_GeneralCancelationMotive!="");
            expressions["KeEyKeesLY0iiUanIPVYFqw_"] = condition_KeEyKeesLY0iiUanIPVYFqw_;
            if (condition_KeEyKeesLY0iiUanIPVYFqw_) {
            expressions["KPiX_bBfj9kqDFMoFbUXGCQ_Value"] = HtmlEncode(inParami_GeneralCancelationMotive.ToString());
            } else {
            }


            var condition_K2vh_6vn7s0q3wBIzfV5_AA_ = (inParami_CancelationMotive!="");
            expressions["K2vh_6vn7s0q3wBIzfV5_AA_"] = condition_K2vh_6vn7s0q3wBIzfV5_AA_;
            if (condition_K2vh_6vn7s0q3wBIzfV5_AA_) {
            expressions["KB9qK3YvW6EKM2zT90ANFMA_Value"] = HtmlEncode(inParami_CancelationMotive.ToString());
            } else {
            }


            var condition_K99HmGt6o9k_h2XDK5OoEdw_ = inParamIsPROD;
            expressions["K99HmGt6o9k_h2XDK5OoEdw_"] = condition_K99HmGt6o9k_h2XDK5OoEdw_;
            if (condition_K99HmGt6o9k_h2XDK5OoEdw_) {
            } else {

            var condition_KxKxpKJDAIUGcn9fpz69KpA_ = (inParamRealEmailList!="");
            expressions["KxKxpKJDAIUGcn9fpz69KpA_"] = condition_KxKxpKJDAIUGcn9fpz69KpA_;
            if (condition_KxKxpKJDAIUGcn9fpz69KpA_) {
            expressions["KtoF6iWCbzkWeM1ssd5IUag_Value"] = HtmlEncode(("Se enviará a: "+inParamRealEmailList).ToString());
            } else {
            }


            var condition_KhYAVSQOq1EeDShHRQ_sV0A_ = (inParamRealEmailCCList!="");
            expressions["KhYAVSQOq1EeDShHRQ_sV0A_"] = condition_KhYAVSQOq1EeDShHRQ_sV0A_;
            if (condition_KhYAVSQOq1EeDShHRQ_sV0A_) {
            expressions["Kz_fFyPxPE0OzrI6b1rkZxg_Value"] = HtmlEncode(("En CC: "+inParamRealEmailCCList).ToString());
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
