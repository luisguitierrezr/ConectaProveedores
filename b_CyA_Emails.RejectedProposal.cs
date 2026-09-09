using System.Web;
using OutSystems.Application.Abstractions.Emails;
using OutSystems.Application.Emails;
using OutSystems.Application.Core.Email;
using OutSystems.Application.Models.Emails;
using OutSystems.ObjectKeys;
using IterativeTemplateData = System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>>;
using TemplateData = System.Collections.Generic.Dictionary<string, object>;

namespace ssConectaProveedores.Flows.Flowb_CyA_Emails {

    public class b_CyA_Emails_RejectedProposal : EmailScreen {

        public b_CyA_Emails_RejectedProposal(
            ISettingsProvider settingsProvider,
            IApplicationLogger applicationLogger,
            ICssFlatteningService cssFlatteningService) : base(settingsProvider, applicationLogger, cssFlatteningService) { }

        private static string inlineCss;

        

        private static string _template;
        internal virtual string Template {
            get { return _template ?? (_template = GetTemplateContent("b_CyA_Emails.RejectedProposal.html.resources")); }
        }

        protected static readonly IEnumerable<string> CssFiles = new List<string> {
"css/ConectaProveedores.EmailTheme.css",
"css/ConectaProveedores.b_CyA_Emails.RejectedProposal.css",
"css/ConectaProveedores.EmailTheme.extra.css",

        };

        public async Task<string> GetEmailContentAsync(IRequestContext requestContext, string inParamApplicationName,string inParamProposalNumber,string inParamUserName,string inParamRejectionReason,string inParami_Enviroment,string inParamRealEmailList,string inParamRealEmailCCList,bool inParamIsPROD, CancellationToken cancellationToken) {
            if (string.IsNullOrEmpty(inlineCss)) {
                inlineCss = await GetInlineStyleSheetIncludeAsync(CssFiles, cancellationToken);
            }
            binaryImages = new Dictionary<string, Image>();
            var expressions = new TemplateData();

            expressions.Add("KMqA7imS2pE_Qh60ztjbPeg_Subject", HtmlEncode((((((inParami_Enviroment=="DEV")) ? ("(DEV)") : ((((inParami_Enviroment=="QA")) ? ("(QA)") : (""))))+"Comissiones Y Arrendamientos - Rechazo de la Propuesta ")+inParamProposalNumber).ToString()));
            expressions.Add("STYLE", inlineCss);
            expressions.Add("v3_Style", MergeStyles("text-align: right;"));
            expressions.Add("v8_Style", MergeStyles("text-align: left;"));
            expressions.Add("v9_Style", MergeStyles("margin-left: 0"));
            expressions.Add("v11_Style", MergeStyles("color: #ae0000; font-size: 16px;"));
            expressions.Add("v17_Style", MergeStyles("margin-left: 0"));
            expressions.Add("v20_Style", MergeStyles("margin-left: 0px"));
            expressions["KJGQAZPwDMEqUI_utmsJRQw_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", "img/ConectaProveedores.Logo.jpg")).ToString());
            expressions["KE1spRtJSsEer_IEGh4JzZg_Value"] = HtmlEncode(inParamApplicationName.ToString());
            expressions["KKiLQgnPW4USJa_ZNMemWsA_Value"] = HtmlEncode(inParamProposalNumber.ToString());
            expressions["Kd27R7uXf0E2IiEKI8egnmA_Value"] = HtmlEncode(inParamRejectionReason.ToString());
            expressions["KIgeckk223kqiXvh8YeIU8w_Value"] = HtmlEncode(("Por favor, accede al enlace"+" ").ToString());
            expressions["KrtDfQy6AW0ybIeRWw4zGEg_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", (((((string)AppUtils.SiteProperties[SitePropertiesModel.spCurrentDomain])))+"ConectaProveedores"))).ToString());
            expressions["Kk9QXZOZmJU2yBgMLqvc81Q_Value"] = HtmlEncode(inParamApplicationName.ToString());
            expressions["KxE4tWRn2QEWcCqfW_Tcb_A_Value"] = HtmlEncode(BuiltInFunction.Year (BuiltInFunction.CurrDate ()).ToString());
            expressions["KnwemV3eChka7VMTuI6Iq_Q_Value"] = HtmlEncode(inParamApplicationName.ToString());

            var condition_KCvluUn1gaUyYzHOwmoH3LA_ = (inParami_Enviroment=="PROD");
            expressions["KCvluUn1gaUyYzHOwmoH3LA_"] = condition_KCvluUn1gaUyYzHOwmoH3LA_;
            if (condition_KCvluUn1gaUyYzHOwmoH3LA_) {
            } else {

            var condition_K1KrBuhgz60Wd64y_r_RiAw_ = (inParami_Enviroment=="DEV");
            expressions["K1KrBuhgz60Wd64y_r_RiAw_"] = condition_K1KrBuhgz60Wd64y_r_RiAw_;
            if (condition_K1KrBuhgz60Wd64y_r_RiAw_) {
            } else {

            var condition_KED9UsKc50EOg5rPNe9y42Q_ = (inParami_Enviroment=="QA");
            expressions["KED9UsKc50EOg5rPNe9y42Q_"] = condition_KED9UsKc50EOg5rPNe9y42Q_;
            if (condition_KED9UsKc50EOg5rPNe9y42Q_) {
            } else {
            }

            }

            }


            var condition_KS93CFB3uRECiblIypKVv8w_ = (inParamUserName!="");
            expressions["KS93CFB3uRECiblIypKVv8w_"] = condition_KS93CFB3uRECiblIypKVv8w_;
            if (condition_KS93CFB3uRECiblIypKVv8w_) {
            expressions["KyeH8jLfL3UeLP0avA_3waQ_Value"] = HtmlEncode((((inParamUserName!="")) ? ((("Hola "+inParamUserName)+"!")) : ("Hola!")).ToString());
            } else {
            }


            var condition_K0ErUXplOSUe1ORll5od9yA_ = inParamIsPROD;
            expressions["K0ErUXplOSUe1ORll5od9yA_"] = condition_K0ErUXplOSUe1ORll5od9yA_;
            if (condition_K0ErUXplOSUe1ORll5od9yA_) {
            } else {

            var condition_Kw6zwwb6ZxEa1BlQCB8hcOw_ = (inParamRealEmailList!="");
            expressions["Kw6zwwb6ZxEa1BlQCB8hcOw_"] = condition_Kw6zwwb6ZxEa1BlQCB8hcOw_;
            if (condition_Kw6zwwb6ZxEa1BlQCB8hcOw_) {
            expressions["KS8H5cE0VGE66ithPcfa69A_Value"] = HtmlEncode(("Se enviará a: "+inParamRealEmailList).ToString());
            } else {
            }


            var condition_KmssEDxtk_0ysTjtoyQnexQ_ = (inParamRealEmailCCList!="");
            expressions["KmssEDxtk_0ysTjtoyQnexQ_"] = condition_KmssEDxtk_0ysTjtoyQnexQ_;
            if (condition_KmssEDxtk_0ysTjtoyQnexQ_) {
            expressions["KhprIox0ERk6FSZMgDQohuA_Value"] = HtmlEncode(("En CC: "+inParamRealEmailCCList).ToString());
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
