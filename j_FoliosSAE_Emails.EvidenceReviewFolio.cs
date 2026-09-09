using System.Web;
using OutSystems.Application.Abstractions.Emails;
using OutSystems.Application.Emails;
using OutSystems.Application.Core.Email;
using OutSystems.Application.Models.Emails;
using OutSystems.ObjectKeys;
using IterativeTemplateData = System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>>;
using TemplateData = System.Collections.Generic.Dictionary<string, object>;

namespace ssConectaProveedores.Flows.Flowj_FoliosSAE_Emails {

    public class j_FoliosSAE_Emails_EvidenceReviewFolio : EmailScreen {

        public j_FoliosSAE_Emails_EvidenceReviewFolio(
            ISettingsProvider settingsProvider,
            IApplicationLogger applicationLogger,
            ICssFlatteningService cssFlatteningService) : base(settingsProvider, applicationLogger, cssFlatteningService) { }

        private static string inlineCss;

        

        private static string _template;
        internal virtual string Template {
            get { return _template ?? (_template = GetTemplateContent("j_FoliosSAE_Emails.EvidenceReviewFolio.html.resources")); }
        }

        protected static readonly IEnumerable<string> CssFiles = new List<string> {
"css/ConectaProveedores.EmailTheme.css",
"css/ConectaProveedores.j_FoliosSAE_Emails.EvidenceReviewFolio.css",
"css/ConectaProveedores.EmailTheme.extra.css",

        };

        public async Task<string> GetEmailContentAsync(IRequestContext requestContext, string inParami_ApplicationName,string inParami_FolioNumber,string inParami_UserName,string inParami_Enviroment,string inParamRealEmailList,string inParamRealEmailCCList,bool inParamIsPROD, CancellationToken cancellationToken) {
            if (string.IsNullOrEmpty(inlineCss)) {
                inlineCss = await GetInlineStyleSheetIncludeAsync(CssFiles, cancellationToken);
            }
            binaryImages = new Dictionary<string, Image>();
            var expressions = new TemplateData();

            expressions.Add("KvTTg_zkDKEufwBQrGBVs_Q_Subject", HtmlEncode(("Folios - Revisar evidencia del folio "+inParami_FolioNumber).ToString()));
            expressions.Add("STYLE", inlineCss);
            expressions.Add("v3_Style", MergeStyles("text-align: right;"));
            expressions.Add("v8_Style", MergeStyles("text-align: left;"));
            expressions.Add("v9_Style", MergeStyles("margin-left: 0"));
            expressions.Add("v14_Style", MergeStyles("margin-left: 0"));
            expressions.Add("v17_Style", MergeStyles("margin-left: 0px"));
            expressions["KJGQAZPwDMEqUI_utmsJRQw_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", "img/ConectaProveedores.Logo.jpg")).ToString());
            expressions["KDLN4ZUV8f0KUL_mTlj_J7g_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["KMpFH8oBWnk_yovdUJIDGkA_Value"] = HtmlEncode(inParami_FolioNumber.ToString());
            expressions["K0l36yh8KDUqP1YYhts53FQ_Value"] = HtmlEncode(("Por favor, accede al enlace"+" ").ToString());
            expressions["KnfksdrfGqEGtLRAoTKHUDQ_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", (((((string)AppUtils.SiteProperties[SitePropertiesModel.spCurrentDomain])))+"ConectaProveedores"))).ToString());
            expressions["Kk5Gc5KqDw0SdkwD_8fNW5A_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["KUQfsvfGDbkCrWOSp68kDaA_Value"] = HtmlEncode(BuiltInFunction.Year (BuiltInFunction.CurrDate ()).ToString());
            expressions["KXZqJ7XW0YEahk3o669ZiJg_Value"] = HtmlEncode(inParami_ApplicationName.ToString());

            var condition_KWjCYj5LCcEicf_bNWVEedw_ = (inParami_Enviroment=="PROD");
            expressions["KWjCYj5LCcEicf_bNWVEedw_"] = condition_KWjCYj5LCcEicf_bNWVEedw_;
            if (condition_KWjCYj5LCcEicf_bNWVEedw_) {
            } else {

            var condition_K5HL_CrIZrUKNj3MBRGeD7g_ = (inParami_Enviroment=="DEV");
            expressions["K5HL_CrIZrUKNj3MBRGeD7g_"] = condition_K5HL_CrIZrUKNj3MBRGeD7g_;
            if (condition_K5HL_CrIZrUKNj3MBRGeD7g_) {
            } else {

            var condition_KkeNtyNUOWkK7fPrTp7Gbug_ = (inParami_Enviroment=="QA");
            expressions["KkeNtyNUOWkK7fPrTp7Gbug_"] = condition_KkeNtyNUOWkK7fPrTp7Gbug_;
            if (condition_KkeNtyNUOWkK7fPrTp7Gbug_) {
            } else {
            }

            }

            }


            var condition_KhH5RWeiW1EmcDk_uFFKL2w_ = (inParami_UserName!="");
            expressions["KhH5RWeiW1EmcDk_uFFKL2w_"] = condition_KhH5RWeiW1EmcDk_uFFKL2w_;
            if (condition_KhH5RWeiW1EmcDk_uFFKL2w_) {
            expressions["KqPZ_0XZR_kyMS2DDy_ygIg_Value"] = HtmlEncode((("Hola "+inParami_UserName)+"!").ToString());
            } else {
            }


            var condition_Kq3N_Plqd20m8PjJF4jGH7g_ = inParamIsPROD;
            expressions["Kq3N_Plqd20m8PjJF4jGH7g_"] = condition_Kq3N_Plqd20m8PjJF4jGH7g_;
            if (condition_Kq3N_Plqd20m8PjJF4jGH7g_) {
            } else {

            var condition_KX27KxPv4CUW4dWOaiv9smQ_ = (inParamRealEmailList!="");
            expressions["KX27KxPv4CUW4dWOaiv9smQ_"] = condition_KX27KxPv4CUW4dWOaiv9smQ_;
            if (condition_KX27KxPv4CUW4dWOaiv9smQ_) {
            expressions["KUIkKzlYXjUuPNtNHkPrgHw_Value"] = HtmlEncode(("Se enviará a: "+inParamRealEmailList).ToString());
            } else {
            }


            var condition_KmYDkvFurYEaNDXGob45bCQ_ = (inParamRealEmailCCList!="");
            expressions["KmYDkvFurYEaNDXGob45bCQ_"] = condition_KmYDkvFurYEaNDXGob45bCQ_;
            if (condition_KmYDkvFurYEaNDXGob45bCQ_) {
            expressions["KjgT19eJnTkSS_dZIPNTGLw_Value"] = HtmlEncode(("En CC: "+inParamRealEmailCCList).ToString());
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
