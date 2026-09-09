using System.Web;
using OutSystems.Application.Abstractions.Emails;
using OutSystems.Application.Emails;
using OutSystems.Application.Core.Email;
using OutSystems.Application.Models.Emails;
using OutSystems.ObjectKeys;
using IterativeTemplateData = System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>>;
using TemplateData = System.Collections.Generic.Dictionary<string, object>;

namespace ssConectaProveedores.Flows.Flowj_FoliosSAE_Emails {

    public class j_FoliosSAE_Emails_NextApproverFolio : EmailScreen {

        public j_FoliosSAE_Emails_NextApproverFolio(
            ISettingsProvider settingsProvider,
            IApplicationLogger applicationLogger,
            ICssFlatteningService cssFlatteningService) : base(settingsProvider, applicationLogger, cssFlatteningService) { }

        private static string inlineCss;

        

        private static string _template;
        internal virtual string Template {
            get { return _template ?? (_template = GetTemplateContent("j_FoliosSAE_Emails.NextApproverFolio.html.resources")); }
        }

        protected static readonly IEnumerable<string> CssFiles = new List<string> {
"css/ConectaProveedores.EmailTheme.css",
"css/ConectaProveedores.j_FoliosSAE_Emails.NextApproverFolio.css",
"css/ConectaProveedores.EmailTheme.extra.css",

        };

        public async Task<string> GetEmailContentAsync(IRequestContext requestContext, string inParami_ApplicationName,string inParami_FolioNumber,string inParami_UserName,string inParami_Environment,string inParamRealEmailList,string inParamRealEmailCCList,bool inParamIsPROD, CancellationToken cancellationToken) {
            if (string.IsNullOrEmpty(inlineCss)) {
                inlineCss = await GetInlineStyleSheetIncludeAsync(CssFiles, cancellationToken);
            }
            binaryImages = new Dictionary<string, Image>();
            var expressions = new TemplateData();

            expressions.Add("KtRIJB2dSzU_WZk2NEbbjug_Subject", HtmlEncode(("Folios - Aprobar Folio "+inParami_FolioNumber).ToString()));
            expressions.Add("STYLE", inlineCss);
            expressions.Add("v3_Style", MergeStyles("text-align: right;"));
            expressions.Add("v8_Style", MergeStyles("text-align: left;"));
            expressions.Add("v14_Style", MergeStyles("margin-left: 0"));
            expressions.Add("v17_Style", MergeStyles("margin-left: 0px"));
            expressions["KJGQAZPwDMEqUI_utmsJRQw_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", "img/ConectaProveedores.Logo.jpg")).ToString());
            expressions["KX9jE_TdSHkiBBqpLQfnfhw_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["KtluZnGKlJ0iWd1KfpQ5ZLw_Value"] = HtmlEncode(inParami_FolioNumber.ToString());
            expressions["K2cNlmz2m0Eujy73ZRBcqhA_Value"] = HtmlEncode(("Por favor, accede al enlace"+" ").ToString());
            expressions["KMcLZyQr3X0GAgWx2X7Itbg_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", (((((string)AppUtils.SiteProperties[SitePropertiesModel.spCurrentDomain])))+"ConectaProveedores"))).ToString());
            expressions["KZPoxk9Szl0KRKA2Koq2X6A_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["K8zLQ9UPNxkKPtGKL2hMjEg_Value"] = HtmlEncode(BuiltInFunction.Year (BuiltInFunction.CurrDate ()).ToString());
            expressions["KRO8zJoucZ0iHWnUqyBW4uw_Value"] = HtmlEncode(inParami_ApplicationName.ToString());

            var condition_K26IvJnFJCkCdwuSg5Zpryg_ = (inParami_Environment=="PROD");
            expressions["K26IvJnFJCkCdwuSg5Zpryg_"] = condition_K26IvJnFJCkCdwuSg5Zpryg_;
            if (condition_K26IvJnFJCkCdwuSg5Zpryg_) {
            } else {

            var condition_KIK2ZLaspUkCA7ByJrtCvlw_ = (inParami_Environment=="DEV");
            expressions["KIK2ZLaspUkCA7ByJrtCvlw_"] = condition_KIK2ZLaspUkCA7ByJrtCvlw_;
            if (condition_KIK2ZLaspUkCA7ByJrtCvlw_) {
            } else {

            var condition_K40YKwSlCJUSgQnfUitdbog_ = (inParami_Environment=="QA");
            expressions["K40YKwSlCJUSgQnfUitdbog_"] = condition_K40YKwSlCJUSgQnfUitdbog_;
            if (condition_K40YKwSlCJUSgQnfUitdbog_) {
            } else {
            }

            }

            }


            var condition_KNWC75DKGQ06s5hK4RZQTOA_ = (inParami_UserName!="");
            expressions["KNWC75DKGQ06s5hK4RZQTOA_"] = condition_KNWC75DKGQ06s5hK4RZQTOA_;
            if (condition_KNWC75DKGQ06s5hK4RZQTOA_) {
            expressions["KD_0390JZNkiP0aDKQpgHrA_Value"] = HtmlEncode((("Hola "+inParami_UserName)+"!").ToString());
            } else {
            }


            var condition_KJntBM3O5VUWlTtwDHTE6Ng_ = inParamIsPROD;
            expressions["KJntBM3O5VUWlTtwDHTE6Ng_"] = condition_KJntBM3O5VUWlTtwDHTE6Ng_;
            if (condition_KJntBM3O5VUWlTtwDHTE6Ng_) {
            } else {

            var condition_K3PMgIeXkMUqmO7XBxr54oA_ = (inParamRealEmailList!="");
            expressions["K3PMgIeXkMUqmO7XBxr54oA_"] = condition_K3PMgIeXkMUqmO7XBxr54oA_;
            if (condition_K3PMgIeXkMUqmO7XBxr54oA_) {
            expressions["Kd7yaKr3Wq0_Q8j9iZs6Daw_Value"] = HtmlEncode(("Se enviará a: "+inParamRealEmailList).ToString());
            } else {
            }


            var condition_KLRxB_MlkSE60t4JJoRqrMw_ = (inParamRealEmailCCList!="");
            expressions["KLRxB_MlkSE60t4JJoRqrMw_"] = condition_KLRxB_MlkSE60t4JJoRqrMw_;
            if (condition_KLRxB_MlkSE60t4JJoRqrMw_) {
            expressions["K36qH7Pabe0ezfcofkrToeg_Value"] = HtmlEncode(("En CC: "+inParamRealEmailCCList).ToString());
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
