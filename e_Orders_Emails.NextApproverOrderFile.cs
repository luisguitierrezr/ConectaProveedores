using System.Web;
using OutSystems.Application.Abstractions.Emails;
using OutSystems.Application.Emails;
using OutSystems.Application.Core.Email;
using OutSystems.Application.Models.Emails;
using OutSystems.ObjectKeys;
using IterativeTemplateData = System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>>;
using TemplateData = System.Collections.Generic.Dictionary<string, object>;

namespace ssConectaProveedores.Flows.Flowe_Orders_Emails {

    public class e_Orders_Emails_NextApproverOrderFile : EmailScreen {

        public e_Orders_Emails_NextApproverOrderFile(
            ISettingsProvider settingsProvider,
            IApplicationLogger applicationLogger,
            ICssFlatteningService cssFlatteningService) : base(settingsProvider, applicationLogger, cssFlatteningService) { }

        private static string inlineCss;

        

        private static string _template;
        internal virtual string Template {
            get { return _template ?? (_template = GetTemplateContent("e_Orders_Emails.NextApproverOrderFile.html.resources")); }
        }

        protected static readonly IEnumerable<string> CssFiles = new List<string> {
"css/ConectaProveedores.EmailTheme.css",
"css/ConectaProveedores.e_Orders_Emails.NextApproverOrderFile.css",
"css/ConectaProveedores.EmailTheme.extra.css",

        };

        public async Task<string> GetEmailContentAsync(IRequestContext requestContext, string inParami_ApplicationName,string inParami_Environment,string inParami_OrderNumber,string inParami_FileDescription,string inParami_UserName,string inParami_RealEmailList,string inParami_RealEmailCCList,bool inParami_IsPROD, CancellationToken cancellationToken) {
            if (string.IsNullOrEmpty(inlineCss)) {
                inlineCss = await GetInlineStyleSheetIncludeAsync(CssFiles, cancellationToken);
            }
            binaryImages = new Dictionary<string, Image>();
            var expressions = new TemplateData();

            expressions.Add("Kzu2ACT3_pESHskS3RvUeAA_Subject", HtmlEncode(("Pedidos - Archivo Cargado "+inParami_FileDescription).ToString()));
            expressions.Add("STYLE", inlineCss);
            expressions.Add("v3_Style", MergeStyles("text-align: right;"));
            expressions.Add("v8_Style", MergeStyles("text-align: left;"));
            expressions.Add("v15_Style", MergeStyles("margin-left: 0"));
            expressions.Add("v18_Style", MergeStyles("margin-left: 0px"));
            expressions["KJGQAZPwDMEqUI_utmsJRQw_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", "img/ConectaProveedores.Logo.jpg")).ToString());
            expressions["KdZWwSCopzE6aSZdIh_pBPA_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["K8iZI0lcOWUi6yLtIEH3wXA_Value"] = HtmlEncode((("("+inParami_FileDescription)+")").ToString());
            expressions["Kw23vxdOfh0CnyEnqi6LZ4w_Value"] = HtmlEncode(inParami_OrderNumber.ToString());
            expressions["KqG9nrMJJ9UmQYPB1a9c6wg_Value"] = HtmlEncode(("Por favor, accede al enlace"+" ").ToString());
            expressions["KWrq2A8qrq02i5DtPTZaa6g_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", (((((string)AppUtils.SiteProperties[SitePropertiesModel.spCurrentDomain])))+"ConectaProveedores"))).ToString());
            expressions["Kp6HwudsqbkesOLvuvZ4iVw_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["Kw0L23d_yu0_WyaLKq79ZUA_Value"] = HtmlEncode(BuiltInFunction.Year (BuiltInFunction.CurrDate ()).ToString());
            expressions["Kex1tiemjf0WLPsO1RaOwTg_Value"] = HtmlEncode(inParami_ApplicationName.ToString());

            var condition_KPDBsDJQeg0m633rtwAuLJA_ = (inParami_Environment=="PROD");
            expressions["KPDBsDJQeg0m633rtwAuLJA_"] = condition_KPDBsDJQeg0m633rtwAuLJA_;
            if (condition_KPDBsDJQeg0m633rtwAuLJA_) {
            } else {

            var condition_KRLyTFzoyW0GyO5zS9d_esg_ = (inParami_Environment=="DEV");
            expressions["KRLyTFzoyW0GyO5zS9d_esg_"] = condition_KRLyTFzoyW0GyO5zS9d_esg_;
            if (condition_KRLyTFzoyW0GyO5zS9d_esg_) {
            } else {

            var condition_KxKSItRiY6kuJKaUtSYuoag_ = (inParami_Environment=="QA");
            expressions["KxKSItRiY6kuJKaUtSYuoag_"] = condition_KxKSItRiY6kuJKaUtSYuoag_;
            if (condition_KxKSItRiY6kuJKaUtSYuoag_) {
            } else {
            }

            }

            }


            var condition_KB_DVLUppMUuyQdgvqowplQ_ = (inParami_UserName!="");
            expressions["KB_DVLUppMUuyQdgvqowplQ_"] = condition_KB_DVLUppMUuyQdgvqowplQ_;
            if (condition_KB_DVLUppMUuyQdgvqowplQ_) {
            expressions["KtSq_myQDLk_8fxOrMznwOw_Value"] = HtmlEncode((("Hola "+inParami_UserName)+"!").ToString());
            } else {
            }


            var condition_KY8KfMmBhjUi_7gkhtVJ3KA_ = inParami_IsPROD;
            expressions["KY8KfMmBhjUi_7gkhtVJ3KA_"] = condition_KY8KfMmBhjUi_7gkhtVJ3KA_;
            if (condition_KY8KfMmBhjUi_7gkhtVJ3KA_) {
            } else {

            var condition_KNkSMJk1ewkW__U6GwuOUyg_ = (inParami_RealEmailList!="");
            expressions["KNkSMJk1ewkW__U6GwuOUyg_"] = condition_KNkSMJk1ewkW__U6GwuOUyg_;
            if (condition_KNkSMJk1ewkW__U6GwuOUyg_) {
            expressions["KmdNaSEe_aEO6xOWKnMEwVQ_Value"] = HtmlEncode(("Se enviará a: "+inParami_RealEmailList).ToString());
            } else {
            }


            var condition_KIjmru0VoY0W0sxCvOejX1Q_ = (inParami_RealEmailCCList!="");
            expressions["KIjmru0VoY0W0sxCvOejX1Q_"] = condition_KIjmru0VoY0W0sxCvOejX1Q_;
            if (condition_KIjmru0VoY0W0sxCvOejX1Q_) {
            expressions["KBl0MdDjYFUK_XtnO6lLNrw_Value"] = HtmlEncode(("En CC: "+inParami_RealEmailCCList).ToString());
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
