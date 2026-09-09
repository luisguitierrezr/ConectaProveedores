using System.Web;
using OutSystems.Application.Abstractions.Emails;
using OutSystems.Application.Emails;
using OutSystems.Application.Core.Email;
using OutSystems.Application.Models.Emails;
using OutSystems.ObjectKeys;
using IterativeTemplateData = System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>>;
using TemplateData = System.Collections.Generic.Dictionary<string, object>;

namespace ssConectaProveedores.Flows.Flowc_Req_Emails {

    public class c_Req_Emails_ModifyRequisition : EmailScreen {

        public c_Req_Emails_ModifyRequisition(
            ISettingsProvider settingsProvider,
            IApplicationLogger applicationLogger,
            ICssFlatteningService cssFlatteningService) : base(settingsProvider, applicationLogger, cssFlatteningService) { }

        private static string inlineCss;

        

        private static string _template;
        internal virtual string Template {
            get { return _template ?? (_template = GetTemplateContent("c_Req_Emails.ModifyRequisition.html.resources")); }
        }

        protected static readonly IEnumerable<string> CssFiles = new List<string> {
"css/ConectaProveedores.EmailTheme.css",
"css/ConectaProveedores.c_Req_Emails.ModifyRequisition.css",
"css/ConectaProveedores.EmailTheme.extra.css",

        };

        public async Task<string> GetEmailContentAsync(IRequestContext requestContext, string inParamApplicationName,string inParamRequisitionName,string inParami_UserName,string inParami_ModifyReason,string inParami_Enviroment,string inParami_UserNameRequestModification,bool inParamIsPROD,string inParamRealEmailList,string inParamRealEmailCCList, CancellationToken cancellationToken) {
            if (string.IsNullOrEmpty(inlineCss)) {
                inlineCss = await GetInlineStyleSheetIncludeAsync(CssFiles, cancellationToken);
            }
            binaryImages = new Dictionary<string, Image>();
            var expressions = new TemplateData();

            expressions.Add("Ko59YK_83uEOG1gYVAvGtyA_Subject", HtmlEncode(("Requisiciones - Pedido de Modificación de la Requisición "+inParamRequisitionName).ToString()));
            expressions.Add("STYLE", inlineCss);
            expressions.Add("v3_Style", MergeStyles("text-align: right;"));
            expressions.Add("v8_Style", MergeStyles("text-align: left;"));
            expressions.Add("v9_Style", MergeStyles("margin-left: 0"));
            expressions.Add("v13_Style", MergeStyles("color: #ae0000; font-size: 16px;"));
            expressions.Add("v19_Style", MergeStyles("margin-left: 0"));
            expressions.Add("v22_Style", MergeStyles("margin-left: 0px"));
            expressions["KJGQAZPwDMEqUI_utmsJRQw_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", "img/ConectaProveedores.Logo.jpg")).ToString());
            expressions["K5Z1rpEmjikSwbKt59Nk7SA_Value"] = HtmlEncode(inParamApplicationName.ToString());
            expressions["KRdc8DQg6hEm0XWCvq1_C3Q_Value"] = HtmlEncode(inParamRequisitionName.ToString());
            expressions["KaBtYLI7EfE6hUWTBXVt1Og_Value"] = HtmlEncode(inParami_UserNameRequestModification.ToString());
            expressions["Kb2m3Wl4fhkehOC88RoBGOQ_Value"] = HtmlEncode(inParami_ModifyReason.ToString());
            expressions["Kr68iWO8M8E6UbteyvNR21A_Value"] = HtmlEncode(("Por favor, accede al enlace"+" ").ToString());
            expressions["K7ZEvtw8S3UiQuNZAl6G0lA_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", (((((string)AppUtils.SiteProperties[SitePropertiesModel.spCurrentDomain])))+"ConectaProveedores"))).ToString());
            expressions["KabsgbcpsIEaGAzqLaePaTw_Value"] = HtmlEncode(inParamApplicationName.ToString());
            expressions["K7_b3D_kd00qr7_h18J8P7g_Value"] = HtmlEncode(BuiltInFunction.Year (BuiltInFunction.CurrDate ()).ToString());
            expressions["K8q0VPVflGEGzkFA2D8RWHA_Value"] = HtmlEncode(inParamApplicationName.ToString());

            var condition_KD_SSaiAnxka02KNd8M9sbQ_ = (inParami_Enviroment=="PROD");
            expressions["KD_SSaiAnxka02KNd8M9sbQ_"] = condition_KD_SSaiAnxka02KNd8M9sbQ_;
            if (condition_KD_SSaiAnxka02KNd8M9sbQ_) {
            } else {

            var condition_K6NQ8oP4_nU2MtM0RsG7bIw_ = (inParami_Enviroment=="DEV");
            expressions["K6NQ8oP4_nU2MtM0RsG7bIw_"] = condition_K6NQ8oP4_nU2MtM0RsG7bIw_;
            if (condition_K6NQ8oP4_nU2MtM0RsG7bIw_) {
            } else {

            var condition_KwOFgzJ3r6E2lMDyntDUEAA_ = (inParami_Enviroment=="QA");
            expressions["KwOFgzJ3r6E2lMDyntDUEAA_"] = condition_KwOFgzJ3r6E2lMDyntDUEAA_;
            if (condition_KwOFgzJ3r6E2lMDyntDUEAA_) {
            } else {
            }

            }

            }


            var condition_KPLEogibBd0uVuynw5QC56Q_ = (inParami_UserName!="");
            expressions["KPLEogibBd0uVuynw5QC56Q_"] = condition_KPLEogibBd0uVuynw5QC56Q_;
            if (condition_KPLEogibBd0uVuynw5QC56Q_) {
            expressions["K3XPo9B9ldEqNUhqkTSyuLw_Value"] = HtmlEncode((("Hola "+inParami_UserName)+"!").ToString());
            } else {
            }


            var condition_KNYsiO5n2akCAExqoHDYhxA_ = inParamIsPROD;
            expressions["KNYsiO5n2akCAExqoHDYhxA_"] = condition_KNYsiO5n2akCAExqoHDYhxA_;
            if (condition_KNYsiO5n2akCAExqoHDYhxA_) {
            } else {

            var condition_KL78g_Y12qk2xtVvscj41tw_ = (inParamRealEmailList!="");
            expressions["KL78g_Y12qk2xtVvscj41tw_"] = condition_KL78g_Y12qk2xtVvscj41tw_;
            if (condition_KL78g_Y12qk2xtVvscj41tw_) {
            expressions["KSZfr1tjdL0C2W8szVwsDAQ_Value"] = HtmlEncode(("Se enviará a: "+inParamRealEmailList).ToString());
            } else {
            }


            var condition_KBr_ppQ_4bk__g7VnvjfEDQ_ = (inParamRealEmailCCList!="");
            expressions["KBr_ppQ_4bk__g7VnvjfEDQ_"] = condition_KBr_ppQ_4bk__g7VnvjfEDQ_;
            if (condition_KBr_ppQ_4bk__g7VnvjfEDQ_) {
            expressions["KolqSNj2Xq0SefZKVPGgGeQ_Value"] = HtmlEncode(("En CC: "+inParamRealEmailCCList).ToString());
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
