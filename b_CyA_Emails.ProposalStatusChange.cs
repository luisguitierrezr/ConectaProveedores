using System.Web;
using OutSystems.Application.Abstractions.Emails;
using OutSystems.Application.Emails;
using OutSystems.Application.Core.Email;
using OutSystems.Application.Models.Emails;
using OutSystems.ObjectKeys;
using IterativeTemplateData = System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>>;
using TemplateData = System.Collections.Generic.Dictionary<string, object>;

namespace ssConectaProveedores.Flows.Flowb_CyA_Emails {

    public class b_CyA_Emails_ProposalStatusChange : EmailScreen {

        public b_CyA_Emails_ProposalStatusChange(
            ISettingsProvider settingsProvider,
            IApplicationLogger applicationLogger,
            ICssFlatteningService cssFlatteningService) : base(settingsProvider, applicationLogger, cssFlatteningService) { }

        private static string inlineCss;

        

        private static string _template;
        internal virtual string Template {
            get { return _template ?? (_template = GetTemplateContent("b_CyA_Emails.ProposalStatusChange.html.resources")); }
        }

        protected static readonly IEnumerable<string> CssFiles = new List<string> {
"css/ConectaProveedores.EmailTheme.css",
"css/ConectaProveedores.b_CyA_Emails.ProposalStatusChange.css",
"css/ConectaProveedores.EmailTheme.extra.css",

        };

        public async Task<string> GetEmailContentAsync(IRequestContext requestContext, string inParamApplicationName,string inParamEnvironment,bool inParamIsPartiallyPaid,string inParamNewStatus,string inParamProposalName,string inParamPreviousStatus,string inParamSubject,RL_3de40603ae6c869db08c8514af3a6489 inParamUnpaidProposals,string inParamUserName,string inParamRealEmailList,string inParamRealEmailCCList,bool inParamIsPROD, CancellationToken cancellationToken) {
            if (string.IsNullOrEmpty(inlineCss)) {
                inlineCss = await GetInlineStyleSheetIncludeAsync(CssFiles, cancellationToken);
            }
            binaryImages = new Dictionary<string, Image>();
            var expressions = new TemplateData();

            expressions.Add("Kf_my0Hix5kqdvVIEzNkCcw_Subject", HtmlEncode(((((inParamEnvironment=="DEV")) ? ("(DEV)") : ((((inParamEnvironment=="QA")) ? ("(QA)") : (""))))+inParamSubject).ToString()));
            expressions.Add("STYLE", inlineCss);
            expressions.Add("v3_Style", MergeStyles("text-align: right;"));
            expressions.Add("v8_Style", MergeStyles("text-align: left;"));
            expressions.Add("v36_Style", MergeStyles("margin-left: 0"));
            expressions.Add("v39_Style", MergeStyles("margin-left: 0px"));
            expressions["KJGQAZPwDMEqUI_utmsJRQw_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", "img/ConectaProveedores.Logo.jpg")).ToString());
            expressions["KQm4K4PqzL0u9cRCgULQtmQ_Value"] = HtmlEncode(inParamApplicationName.ToString());
            expressions["KUEMZn5QrXUyAyyCHKYnP5A_Value"] = HtmlEncode((((inParamUserName!="")) ? ((("Hola "+inParamUserName)+"!")) : ("Hola!")).ToString());
            expressions["KYlXu1KDrSk6YbjZs8dQqIQ_Value"] = HtmlEncode(((" "+inParamProposalName)+" ").ToString());
            expressions["KGX7d9hL0I0_UvTgZ2chfKA_Value"] = HtmlEncode(((" "+inParamPreviousStatus)+" ").ToString());
            expressions["Khxxkg4on5EW917xn83Y4nw_Value"] = HtmlEncode(((" "+inParamNewStatus)+".").ToString());
            expressions["KZwBeJ7A9V0W5ndeON_cE_A_Value"] = HtmlEncode(("Por favor, accede al enlace"+" ").ToString());
            expressions["Kuf_siN6VyEWJMQK3mA_DSg_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", (((((string)AppUtils.SiteProperties[SitePropertiesModel.spCurrentDomain])))+"ConectaProveedores"))).ToString());
            expressions["KAThTTimDYUCIPFU2j3owoQ_Value"] = HtmlEncode(inParamApplicationName.ToString());
            expressions["Kh4dTmC_aFUSKnjSmwH90NQ_Value"] = HtmlEncode(BuiltInFunction.Year (BuiltInFunction.CurrDate ()).ToString());
            expressions["KTMQjVx30L0Sp0MDpAd18zA_Value"] = HtmlEncode(inParamApplicationName.ToString());

            var condition_KRxp7AHyatUuW_yfEmGfDag_ = (inParamEnvironment=="PROD");
            expressions["KRxp7AHyatUuW_yfEmGfDag_"] = condition_KRxp7AHyatUuW_yfEmGfDag_;
            if (condition_KRxp7AHyatUuW_yfEmGfDag_) {
            } else {

            var condition_KVqoVSzRTT0_JTbOEuOQOZw_ = (inParamEnvironment=="DEV");
            expressions["KVqoVSzRTT0_JTbOEuOQOZw_"] = condition_KVqoVSzRTT0_JTbOEuOQOZw_;
            if (condition_KVqoVSzRTT0_JTbOEuOQOZw_) {
            } else {

            var condition_KYY7PdyOvPUynlb1x2s4fPw_ = (inParamEnvironment=="QA");
            expressions["KYY7PdyOvPUynlb1x2s4fPw_"] = condition_KYY7PdyOvPUynlb1x2s4fPw_;
            if (condition_KYY7PdyOvPUynlb1x2s4fPw_) {
            } else {
            }

            }

            }


            var condition_Kvn0PJVPzeEqb1tMEJ_desw_ = inParamIsPartiallyPaid;
            expressions["Kvn0PJVPzeEqb1tMEJ_desw_"] = condition_Kvn0PJVPzeEqb1tMEJ_desw_;
            if (condition_Kvn0PJVPzeEqb1tMEJ_desw_) {

            var data_KKMr_yDGdJ0qnV1WkF8hV4A_Source = new IterativeTemplateData();
            await IterateAsync(inParamUnpaidProposals, async () => {
               var templateData_KKMr_yDGdJ0qnV1WkF8hV4A_Source = new TemplateData();
                           templateData_KKMr_yDGdJ0qnV1WkF8hV4A_Source["KF8FzpYDUH0O5fBPYjPpEAQ_Value"] = HtmlEncode(inParamUnpaidProposals.CurrentRec.ssAccount.ToString());
                           templateData_KKMr_yDGdJ0qnV1WkF8hV4A_Source["K5ImErC0oCUKz_WfFK2P8Gg_Value"] = HtmlEncode(inParamUnpaidProposals.CurrentRec.ssRef.ToString());
                           templateData_KKMr_yDGdJ0qnV1WkF8hV4A_Source["Kzh_YL3xCpE_SXgbBn92n7w_Value"] = HtmlEncode(inParamUnpaidProposals.CurrentRec.ssSupplierName.ToString());
                           templateData_KKMr_yDGdJ0qnV1WkF8hV4A_Source["KRvQj8Mfc_02bZ3_O8QqXow_Value"] = HtmlEncode(inParamUnpaidProposals.CurrentRec.ssSocietyName.ToString());
                           templateData_KKMr_yDGdJ0qnV1WkF8hV4A_Source["KoAVBeL1sJ0eNiMOpU4JWLQ_Value"] = HtmlEncode(inParamUnpaidProposals.CurrentRec.ssComment.ToString());
               data_KKMr_yDGdJ0qnV1WkF8hV4A_Source.Add(templateData_KKMr_yDGdJ0qnV1WkF8hV4A_Source);
            });
            expressions.Add("KKMr_yDGdJ0qnV1WkF8hV4A_Source", data_KKMr_yDGdJ0qnV1WkF8hV4A_Source);

            } else {
            }


            var condition_KYaeAWvYiY0KLql_J7b6Vog_ = inParamIsPROD;
            expressions["KYaeAWvYiY0KLql_J7b6Vog_"] = condition_KYaeAWvYiY0KLql_J7b6Vog_;
            if (condition_KYaeAWvYiY0KLql_J7b6Vog_) {
            } else {

            var condition_KyRwBjYoJMk6RGAF10OjAnw_ = (inParamRealEmailList!="");
            expressions["KyRwBjYoJMk6RGAF10OjAnw_"] = condition_KyRwBjYoJMk6RGAF10OjAnw_;
            if (condition_KyRwBjYoJMk6RGAF10OjAnw_) {
            expressions["Kt4D8AAupR0GHwhiDILnkOQ_Value"] = HtmlEncode(("Se enviará a: "+inParamRealEmailList).ToString());
            } else {
            }


            var condition_KdRQBWz6mn0i3gEOQhW7dxQ_ = (inParamRealEmailCCList!="");
            expressions["KdRQBWz6mn0i3gEOQhW7dxQ_"] = condition_KdRQBWz6mn0i3gEOQhW7dxQ_;
            if (condition_KdRQBWz6mn0i3gEOQhW7dxQ_) {
            expressions["KrVmj8tMYDUKrNfV__y4HIg_Value"] = HtmlEncode(("En CC: "+inParamRealEmailCCList).ToString());
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
