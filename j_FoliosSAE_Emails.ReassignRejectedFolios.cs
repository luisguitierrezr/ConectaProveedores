using System.Web;
using OutSystems.Application.Abstractions.Emails;
using OutSystems.Application.Emails;
using OutSystems.Application.Core.Email;
using OutSystems.Application.Models.Emails;
using OutSystems.ObjectKeys;
using IterativeTemplateData = System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>>;
using TemplateData = System.Collections.Generic.Dictionary<string, object>;

namespace ssConectaProveedores.Flows.Flowj_FoliosSAE_Emails {

    public class j_FoliosSAE_Emails_ReassignRejectedFolios : EmailScreen {

        public j_FoliosSAE_Emails_ReassignRejectedFolios(
            ISettingsProvider settingsProvider,
            IApplicationLogger applicationLogger,
            ICssFlatteningService cssFlatteningService) : base(settingsProvider, applicationLogger, cssFlatteningService) { }

        private static string inlineCss;

        

        private static string _template;
        internal virtual string Template {
            get { return _template ?? (_template = GetTemplateContent("j_FoliosSAE_Emails.ReassignRejectedFolios.html.resources")); }
        }

        protected static readonly IEnumerable<string> CssFiles = new List<string> {
"css/ConectaProveedores.EmailTheme.css",
"css/ConectaProveedores.j_FoliosSAE_Emails.ReassignRejectedFolios.css",
"css/ConectaProveedores.EmailTheme.extra.css",

        };

        public async Task<string> GetEmailContentAsync(IRequestContext requestContext, string inParami_ApplicationName,string inParami_UserName,long inParami_FolioCount,string inParami_Environment,string inParamRealEmailList,string inParamRealEmailCCList,bool inParamIsPROD, CancellationToken cancellationToken) {
            if (string.IsNullOrEmpty(inlineCss)) {
                inlineCss = await GetInlineStyleSheetIncludeAsync(CssFiles, cancellationToken);
            }
            binaryImages = new Dictionary<string, Image>();
            var expressions = new TemplateData();

            expressions.Add("STYLE", inlineCss);
            expressions.Add("v3_Style", MergeStyles("text-align: right;"));
            expressions.Add("v8_Style", MergeStyles("text-align: left;"));
            expressions.Add("v14_Style", MergeStyles("margin-left: 0"));
            expressions.Add("v17_Style", MergeStyles("margin-left: 0px"));
            expressions["KJGQAZPwDMEqUI_utmsJRQw_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", "img/ConectaProveedores.Logo.jpg")).ToString());
            expressions["KtZa38yZSQ0_ULggE_hQeYQ_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["KQzfGDXQ_TEOOpZWlWCdcHQ_Value"] = HtmlEncode(inParami_FolioCount.ToString());
            expressions["Ko5pu_BBHJUe86XalK7hEcQ_Value"] = HtmlEncode(("Por favor, accede al enlace"+" ").ToString());
            expressions["KdfEU4UZk5kWL9v9D8RiDhQ_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", (((((string)AppUtils.SiteProperties[SitePropertiesModel.spCurrentDomain])))+"ConectaProveedores"))).ToString());
            expressions["KuIiABf4jeUu_vGN7D99dTA_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["KEceE39zTxkSrB4WI8XbJ3w_Value"] = HtmlEncode(BuiltInFunction.Year (BuiltInFunction.CurrDate ()).ToString());
            expressions["KU0fRnfmQdEuJtdECl41ogw_Value"] = HtmlEncode(inParami_ApplicationName.ToString());

            var condition_KAY5odH_RrEagUw3L0DkBMw_ = (inParami_Environment=="PROD");
            expressions["KAY5odH_RrEagUw3L0DkBMw_"] = condition_KAY5odH_RrEagUw3L0DkBMw_;
            if (condition_KAY5odH_RrEagUw3L0DkBMw_) {
            } else {

            var condition_KfH_6XgW1WE2uMK_KixevSA_ = (inParami_Environment=="DEV");
            expressions["KfH_6XgW1WE2uMK_KixevSA_"] = condition_KfH_6XgW1WE2uMK_KixevSA_;
            if (condition_KfH_6XgW1WE2uMK_KixevSA_) {
            } else {

            var condition_Kdw569rTZykaWheJxixMnHA_ = (inParami_Environment=="QA");
            expressions["Kdw569rTZykaWheJxixMnHA_"] = condition_Kdw569rTZykaWheJxixMnHA_;
            if (condition_Kdw569rTZykaWheJxixMnHA_) {
            } else {
            }

            }

            }


            var condition_K8o5exhgEH0iplwHXECrmuQ_ = (inParami_UserName!="");
            expressions["K8o5exhgEH0iplwHXECrmuQ_"] = condition_K8o5exhgEH0iplwHXECrmuQ_;
            if (condition_K8o5exhgEH0iplwHXECrmuQ_) {
            expressions["KE8bOONIOEUCVoBigojcu6g_Value"] = HtmlEncode((("Hola "+inParami_UserName)+"!").ToString());
            } else {
            }


            var condition_KGEO_WGyp4EazXwRGpkXCvw_ = inParamIsPROD;
            expressions["KGEO_WGyp4EazXwRGpkXCvw_"] = condition_KGEO_WGyp4EazXwRGpkXCvw_;
            if (condition_KGEO_WGyp4EazXwRGpkXCvw_) {
            } else {

            var condition_KSjsuclkkj0Oik5vUuFXV3g_ = (inParamRealEmailList!="");
            expressions["KSjsuclkkj0Oik5vUuFXV3g_"] = condition_KSjsuclkkj0Oik5vUuFXV3g_;
            if (condition_KSjsuclkkj0Oik5vUuFXV3g_) {
            expressions["Keo0HgNA2EUSUqYIcszb9jg_Value"] = HtmlEncode(("Se enviará a: "+inParamRealEmailList).ToString());
            } else {
            }


            var condition_Kn6gNlByQHUCpqpvel8zJKg_ = (inParamRealEmailCCList!="");
            expressions["Kn6gNlByQHUCpqpvel8zJKg_"] = condition_Kn6gNlByQHUCpqpvel8zJKg_;
            if (condition_Kn6gNlByQHUCpqpvel8zJKg_) {
            expressions["KWtQkz_fILUO7SeHPE_QX9A_Value"] = HtmlEncode(("En CC: "+inParamRealEmailCCList).ToString());
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
