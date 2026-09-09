using System.Web;
using OutSystems.Application.Abstractions.Emails;
using OutSystems.Application.Emails;
using OutSystems.Application.Core.Email;
using OutSystems.Application.Models.Emails;
using OutSystems.ObjectKeys;
using IterativeTemplateData = System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>>;
using TemplateData = System.Collections.Generic.Dictionary<string, object>;

namespace ssConectaProveedores.Flows.Flowc_Req_Emails {

    public class c_Req_Emails_FirstApproverRequisition : EmailScreen {

        public c_Req_Emails_FirstApproverRequisition(
            ISettingsProvider settingsProvider,
            IApplicationLogger applicationLogger,
            ICssFlatteningService cssFlatteningService) : base(settingsProvider, applicationLogger, cssFlatteningService) { }

        private static string inlineCss;

        

        private static string _template;
        internal virtual string Template {
            get { return _template ?? (_template = GetTemplateContent("c_Req_Emails.FirstApproverRequisition.html.resources")); }
        }

        protected static readonly IEnumerable<string> CssFiles = new List<string> {
"css/ConectaProveedores.EmailTheme.css",
"css/ConectaProveedores.c_Req_Emails.FirstApproverRequisition.css",
"css/ConectaProveedores.EmailTheme.extra.css",

        };

        public async Task<string> GetEmailContentAsync(IRequestContext requestContext, string inParami_ApplicationName,string inParami_RequisitionName,string inParami_UserName,string inParami_Enviroment,string inParami_UserNameCreatedRequisition,bool inParami_IsReqNewVersion,bool inParamIsPROD,string inParamRealEmailList,string inParamRealEmailCCList, CancellationToken cancellationToken) {
            if (string.IsNullOrEmpty(inlineCss)) {
                inlineCss = await GetInlineStyleSheetIncludeAsync(CssFiles, cancellationToken);
            }
            binaryImages = new Dictionary<string, Image>();
            var expressions = new TemplateData();

            expressions.Add("Kq3RA4hKgm0OLbAWLF_6S4Q_Subject", HtmlEncode((("Requisiciones -"+((inParami_IsReqNewVersion) ? (" Requisición Modificada ") : (" Nueva Requisición ")))+inParami_RequisitionName).ToString()));
            expressions.Add("STYLE", inlineCss);
            expressions.Add("v3_Style", MergeStyles("text-align: right;"));
            expressions.Add("v8_Style", MergeStyles("text-align: left;"));
            expressions.Add("v16_Style", MergeStyles("margin-left: 0"));
            expressions.Add("v19_Style", MergeStyles("margin-left: 0px"));
            expressions["KJGQAZPwDMEqUI_utmsJRQw_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", "img/ConectaProveedores.Logo.jpg")).ToString());
            expressions["Kqp7mEl92SkSX20XugNI9ig_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["KBP88KNjUw0iq_uedaSa0Dw_Value"] = HtmlEncode(inParami_RequisitionName.ToString());
            expressions["KuyTjZZtg3UuAxTnS71nt0A_Value"] = HtmlEncode(((" acaba de ser "+((inParami_IsReqNewVersion) ? ("modificada") : ("creada")))+" por ").ToString());
            expressions["KQ3dvRJ9dgESLqq1cuAK0cw_Value"] = HtmlEncode(inParami_UserNameCreatedRequisition.ToString());
            expressions["Kbq_HCgEOtU24A7YMLxro2g_Value"] = HtmlEncode(("Por favor, accede al enlace"+" ").ToString());
            expressions["KTFSGGetFC0WFYMPTNtvN8A_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", (((((string)AppUtils.SiteProperties[SitePropertiesModel.spCurrentDomain])))+"ConectaProveedores"))).ToString());
            expressions["KO5TbcCbiykqhwIAjKDpmqA_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["K2wvVwQwIzUSY7bMbLhS8TQ_Value"] = HtmlEncode(BuiltInFunction.Year (BuiltInFunction.CurrDate ()).ToString());
            expressions["KZ0lc1eDMjEWK_sHKCIeKPw_Value"] = HtmlEncode(inParami_ApplicationName.ToString());

            var condition_KwgJ1uwK7fEa5Wy3wnoLS8w_ = (inParami_Enviroment=="PROD");
            expressions["KwgJ1uwK7fEa5Wy3wnoLS8w_"] = condition_KwgJ1uwK7fEa5Wy3wnoLS8w_;
            if (condition_KwgJ1uwK7fEa5Wy3wnoLS8w_) {
            } else {

            var condition_KmASpeSZXw0_PjuVxJPCcsg_ = (inParami_Enviroment=="DEV");
            expressions["KmASpeSZXw0_PjuVxJPCcsg_"] = condition_KmASpeSZXw0_PjuVxJPCcsg_;
            if (condition_KmASpeSZXw0_PjuVxJPCcsg_) {
            } else {

            var condition_KBURk_F8VZUS_55ouGq_Fjw_ = (inParami_Enviroment=="QA");
            expressions["KBURk_F8VZUS_55ouGq_Fjw_"] = condition_KBURk_F8VZUS_55ouGq_Fjw_;
            if (condition_KBURk_F8VZUS_55ouGq_Fjw_) {
            } else {
            }

            }

            }


            var condition_K2Qfpuo_k7k6N1DZQJeyXXw_ = (inParami_UserName!="");
            expressions["K2Qfpuo_k7k6N1DZQJeyXXw_"] = condition_K2Qfpuo_k7k6N1DZQJeyXXw_;
            if (condition_K2Qfpuo_k7k6N1DZQJeyXXw_) {
            expressions["KpCYrCGw4UU6SaG0QWeamBg_Value"] = HtmlEncode((("Hola "+inParami_UserName)+"!").ToString());
            } else {
            }


            var condition_KVvOz8J9wcUSUK_G6R7dajg_ = inParamIsPROD;
            expressions["KVvOz8J9wcUSUK_G6R7dajg_"] = condition_KVvOz8J9wcUSUK_G6R7dajg_;
            if (condition_KVvOz8J9wcUSUK_G6R7dajg_) {
            } else {

            var condition_KU7D_jXO7mke_5qO7A_X3GQ_ = (inParamRealEmailList!="");
            expressions["KU7D_jXO7mke_5qO7A_X3GQ_"] = condition_KU7D_jXO7mke_5qO7A_X3GQ_;
            if (condition_KU7D_jXO7mke_5qO7A_X3GQ_) {
            expressions["KoH1icK7WzEuMA1hrOeNO3g_Value"] = HtmlEncode(("Se enviará a: "+inParamRealEmailList).ToString());
            } else {
            }


            var condition_Kt28TYPbRzEeIUEuqYrXXfQ_ = (inParamRealEmailCCList!="");
            expressions["Kt28TYPbRzEeIUEuqYrXXfQ_"] = condition_Kt28TYPbRzEeIUEuqYrXXfQ_;
            if (condition_Kt28TYPbRzEeIUEuqYrXXfQ_) {
            expressions["KN0ZNldjSk0O75UTRMjouBw_Value"] = HtmlEncode(("En CC: "+inParamRealEmailCCList).ToString());
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
