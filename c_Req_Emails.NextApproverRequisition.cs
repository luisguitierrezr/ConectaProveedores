using System.Web;
using OutSystems.Application.Abstractions.Emails;
using OutSystems.Application.Emails;
using OutSystems.Application.Core.Email;
using OutSystems.Application.Models.Emails;
using OutSystems.ObjectKeys;
using IterativeTemplateData = System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>>;
using TemplateData = System.Collections.Generic.Dictionary<string, object>;

namespace ssConectaProveedores.Flows.Flowc_Req_Emails {

    public class c_Req_Emails_NextApproverRequisition : EmailScreen {

        public c_Req_Emails_NextApproverRequisition(
            ISettingsProvider settingsProvider,
            IApplicationLogger applicationLogger,
            ICssFlatteningService cssFlatteningService) : base(settingsProvider, applicationLogger, cssFlatteningService) { }

        private static string inlineCss;

        

        private static string _template;
        internal virtual string Template {
            get { return _template ?? (_template = GetTemplateContent("c_Req_Emails.NextApproverRequisition.html.resources")); }
        }

        protected static readonly IEnumerable<string> CssFiles = new List<string> {
"css/ConectaProveedores.EmailTheme.css",
"css/ConectaProveedores.c_Req_Emails.NextApproverRequisition.css",
"css/ConectaProveedores.EmailTheme.extra.css",

        };

        public async Task<string> GetEmailContentAsync(IRequestContext requestContext, string inParami_ApplicationName,string inParami_RequisitionName,string inParami_UserName,string inParami_Enviroment,bool inParamIsPROD,string inParamRealEmailList,string inParamRealEmailCCList, CancellationToken cancellationToken) {
            if (string.IsNullOrEmpty(inlineCss)) {
                inlineCss = await GetInlineStyleSheetIncludeAsync(CssFiles, cancellationToken);
            }
            binaryImages = new Dictionary<string, Image>();
            var expressions = new TemplateData();

            expressions.Add("KDmgNRWl5Kk2foQ_ctFimWA_Subject", HtmlEncode(("Requisiciones - Aprobar Requisición "+inParami_RequisitionName).ToString()));
            expressions.Add("STYLE", inlineCss);
            expressions.Add("v3_Style", MergeStyles("text-align: right;"));
            expressions.Add("v8_Style", MergeStyles("text-align: left;"));
            expressions.Add("v14_Style", MergeStyles("margin-left: 0"));
            expressions.Add("v17_Style", MergeStyles("margin-left: 0px"));
            expressions["KJGQAZPwDMEqUI_utmsJRQw_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", "img/ConectaProveedores.Logo.jpg")).ToString());
            expressions["KsnO66_G620CR8cbcu5XmSQ_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["K7bZoM79WfUOQhBMfNIB6Qg_Value"] = HtmlEncode(inParami_RequisitionName.ToString());
            expressions["KeyAoRtuZwEyGuOxeAVjkuA_Value"] = HtmlEncode(("Por favor, accede al enlace"+" ").ToString());
            expressions["KTE1ARs_oQ02VpE2sCQUoGg_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", (((((string)AppUtils.SiteProperties[SitePropertiesModel.spCurrentDomain])))+"ConectaProveedores"))).ToString());
            expressions["Kdyj9loRflE6Mwki1QZdOoQ_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["KaqSV_DT9jkyqQaJJZvGHIw_Value"] = HtmlEncode(BuiltInFunction.Year (BuiltInFunction.CurrDate ()).ToString());
            expressions["KSlcbMdqmVkeAMn_arfu6LQ_Value"] = HtmlEncode(inParami_ApplicationName.ToString());

            var condition_KxmjhwqmgQkuHYwJVKeyPaA_ = (inParami_Enviroment=="PROD");
            expressions["KxmjhwqmgQkuHYwJVKeyPaA_"] = condition_KxmjhwqmgQkuHYwJVKeyPaA_;
            if (condition_KxmjhwqmgQkuHYwJVKeyPaA_) {
            } else {

            var condition_KKvPboKS_O0aQ_OWXY4PMcA_ = (inParami_Enviroment=="DEV");
            expressions["KKvPboKS_O0aQ_OWXY4PMcA_"] = condition_KKvPboKS_O0aQ_OWXY4PMcA_;
            if (condition_KKvPboKS_O0aQ_OWXY4PMcA_) {
            } else {

            var condition_KnevRQB_A40i2cs849sSy0A_ = (inParami_Enviroment=="QA");
            expressions["KnevRQB_A40i2cs849sSy0A_"] = condition_KnevRQB_A40i2cs849sSy0A_;
            if (condition_KnevRQB_A40i2cs849sSy0A_) {
            } else {
            }

            }

            }


            var condition_KIFpVhlF_g0CT3pPqkDEyGQ_ = (inParami_UserName!="");
            expressions["KIFpVhlF_g0CT3pPqkDEyGQ_"] = condition_KIFpVhlF_g0CT3pPqkDEyGQ_;
            if (condition_KIFpVhlF_g0CT3pPqkDEyGQ_) {
            expressions["Kih7a21QmCUOMx2QawkDqtQ_Value"] = HtmlEncode((("Hola "+inParami_UserName)+"!").ToString());
            } else {
            }


            var condition_KuQMO1G190E_V9VJ5gZbWZQ_ = inParamIsPROD;
            expressions["KuQMO1G190E_V9VJ5gZbWZQ_"] = condition_KuQMO1G190E_V9VJ5gZbWZQ_;
            if (condition_KuQMO1G190E_V9VJ5gZbWZQ_) {
            } else {

            var condition_K8xePdayVMkq0_HjH_qWLsA_ = (inParamRealEmailList!="");
            expressions["K8xePdayVMkq0_HjH_qWLsA_"] = condition_K8xePdayVMkq0_HjH_qWLsA_;
            if (condition_K8xePdayVMkq0_HjH_qWLsA_) {
            expressions["KwtEmRbYf_UmkpD7pL8yYLA_Value"] = HtmlEncode(("Se enviará a: "+inParamRealEmailList).ToString());
            } else {
            }


            var condition_Ki0bIFMnD4EyDgRftwN8BNg_ = (inParamRealEmailCCList!="");
            expressions["Ki0bIFMnD4EyDgRftwN8BNg_"] = condition_Ki0bIFMnD4EyDgRftwN8BNg_;
            if (condition_Ki0bIFMnD4EyDgRftwN8BNg_) {
            expressions["K58Q8f1o8u0W_XrtwiJhp0A_Value"] = HtmlEncode(("En CC: "+inParamRealEmailCCList).ToString());
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
