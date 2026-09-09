using System.Web;
using OutSystems.Application.Abstractions.Emails;
using OutSystems.Application.Emails;
using OutSystems.Application.Core.Email;
using OutSystems.Application.Models.Emails;
using OutSystems.ObjectKeys;
using IterativeTemplateData = System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>>;
using TemplateData = System.Collections.Generic.Dictionary<string, object>;

namespace ssConectaProveedores.Flows.Flowc_Req_Emails {

    public class c_Req_Emails_ApprovedRequisition : EmailScreen {

        public c_Req_Emails_ApprovedRequisition(
            ISettingsProvider settingsProvider,
            IApplicationLogger applicationLogger,
            ICssFlatteningService cssFlatteningService) : base(settingsProvider, applicationLogger, cssFlatteningService) { }

        private static string inlineCss;

        

        private static string _template;
        internal virtual string Template {
            get { return _template ?? (_template = GetTemplateContent("c_Req_Emails.ApprovedRequisition.html.resources")); }
        }

        protected static readonly IEnumerable<string> CssFiles = new List<string> {
"css/ConectaProveedores.EmailTheme.css",
"css/ConectaProveedores.c_Req_Emails.ApprovedRequisition.css",
"css/ConectaProveedores.EmailTheme.extra.css",

        };

        public async Task<string> GetEmailContentAsync(IRequestContext requestContext, string inParami_ApplicationName,string inParami_RequisitionName,string inParami_UserName,string inParami_Enviroment,bool inParamIsPROD,string inParamRealEmailList,string inParamRealEmailCCList, CancellationToken cancellationToken) {
            if (string.IsNullOrEmpty(inlineCss)) {
                inlineCss = await GetInlineStyleSheetIncludeAsync(CssFiles, cancellationToken);
            }
            binaryImages = new Dictionary<string, Image>();
            var expressions = new TemplateData();

            expressions.Add("KKlGti9tdD0Ke1_9jOhiePQ_Subject", HtmlEncode((("Requisiciones - Requisición "+inParami_RequisitionName)+" Aprobada").ToString()));
            expressions.Add("STYLE", inlineCss);
            expressions.Add("v3_Style", MergeStyles("text-align: right;"));
            expressions.Add("v8_Style", MergeStyles("text-align: left;"));
            expressions.Add("v14_Style", MergeStyles("margin-left: 0"));
            expressions.Add("v17_Style", MergeStyles("margin-left: 0px"));
            expressions["KJGQAZPwDMEqUI_utmsJRQw_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", "img/ConectaProveedores.Logo.jpg")).ToString());
            expressions["KA_Fb4p0qZ0SABuT0_0sMEw_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["KrP_qIO_AM0mYE1eigo09CQ_Value"] = HtmlEncode(inParami_RequisitionName.ToString());
            expressions["KnTi0cPEFqEaF0N2WqlmnwA_Value"] = HtmlEncode(("Por favor, accede al enlace"+" ").ToString());
            expressions["KO0EIHhYKNkOCbMNt5lTiWA_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", (((((string)AppUtils.SiteProperties[SitePropertiesModel.spCurrentDomain])))+"ConectaProveedores"))).ToString());
            expressions["K9P8kB0Lu1EGDBa0fn3j2mw_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["Kf4bvIBAf0kaO0jj6NfH6xQ_Value"] = HtmlEncode(BuiltInFunction.Year (BuiltInFunction.CurrDate ()).ToString());
            expressions["KZ0o0ntfb70aoFYTnfT_hlw_Value"] = HtmlEncode(inParami_ApplicationName.ToString());

            var condition_Kmz6wo_kTrkKKi75__6NoEQ_ = (inParami_Enviroment=="PROD");
            expressions["Kmz6wo_kTrkKKi75__6NoEQ_"] = condition_Kmz6wo_kTrkKKi75__6NoEQ_;
            if (condition_Kmz6wo_kTrkKKi75__6NoEQ_) {
            } else {

            var condition_KDyv7Avx_NECr8Xvmm9KMBg_ = (inParami_Enviroment=="DEV");
            expressions["KDyv7Avx_NECr8Xvmm9KMBg_"] = condition_KDyv7Avx_NECr8Xvmm9KMBg_;
            if (condition_KDyv7Avx_NECr8Xvmm9KMBg_) {
            } else {

            var condition_KcmC8JbGXWE_pHdQpjEaSiQ_ = (inParami_Enviroment=="QA");
            expressions["KcmC8JbGXWE_pHdQpjEaSiQ_"] = condition_KcmC8JbGXWE_pHdQpjEaSiQ_;
            if (condition_KcmC8JbGXWE_pHdQpjEaSiQ_) {
            } else {
            }

            }

            }


            var condition_K7GiOy0cUgU6hnsiNDqWMMw_ = (inParami_UserName!="");
            expressions["K7GiOy0cUgU6hnsiNDqWMMw_"] = condition_K7GiOy0cUgU6hnsiNDqWMMw_;
            if (condition_K7GiOy0cUgU6hnsiNDqWMMw_) {
            expressions["KaioFt6Y_GEebgffGq3ZMKQ_Value"] = HtmlEncode((("Hola "+inParami_UserName)+"!").ToString());
            } else {
            }


            var condition_KA4ZugSC2CU_og_90e_qemw_ = inParamIsPROD;
            expressions["KA4ZugSC2CU_og_90e_qemw_"] = condition_KA4ZugSC2CU_og_90e_qemw_;
            if (condition_KA4ZugSC2CU_og_90e_qemw_) {
            } else {

            var condition_KQIR12N5qgk6mdslGi64S8A_ = (inParamRealEmailList!="");
            expressions["KQIR12N5qgk6mdslGi64S8A_"] = condition_KQIR12N5qgk6mdslGi64S8A_;
            if (condition_KQIR12N5qgk6mdslGi64S8A_) {
            expressions["KUG382_DzuEqs7efLgqpoBA_Value"] = HtmlEncode(("Se enviará a: "+inParamRealEmailList).ToString());
            } else {
            }


            var condition_KdXvCwFst5keRW_QFv9zNQA_ = (inParamRealEmailCCList!="");
            expressions["KdXvCwFst5keRW_QFv9zNQA_"] = condition_KdXvCwFst5keRW_QFv9zNQA_;
            if (condition_KdXvCwFst5keRW_QFv9zNQA_) {
            expressions["KlUBj2rjDy0OItVdbZKiv9g_Value"] = HtmlEncode(("En CC: "+inParamRealEmailCCList).ToString());
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
