using System.Web;
using OutSystems.Application.Abstractions.Emails;
using OutSystems.Application.Emails;
using OutSystems.Application.Core.Email;
using OutSystems.Application.Models.Emails;
using OutSystems.ObjectKeys;
using IterativeTemplateData = System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>>;
using TemplateData = System.Collections.Generic.Dictionary<string, object>;

namespace ssConectaProveedores.Flows.Flowj_FoliosSAE_Emails {

    public class j_FoliosSAE_Emails_FolioIncorrectAssignment : EmailScreen {

        public j_FoliosSAE_Emails_FolioIncorrectAssignment(
            ISettingsProvider settingsProvider,
            IApplicationLogger applicationLogger,
            ICssFlatteningService cssFlatteningService) : base(settingsProvider, applicationLogger, cssFlatteningService) { }

        private static string inlineCss;

        

        private static string _template;
        internal virtual string Template {
            get { return _template ?? (_template = GetTemplateContent("j_FoliosSAE_Emails.FolioIncorrectAssignment.html.resources")); }
        }

        protected static readonly IEnumerable<string> CssFiles = new List<string> {
"css/ConectaProveedores.EmailTheme.css",
"css/ConectaProveedores.j_FoliosSAE_Emails.FolioIncorrectAssignment.css",
"css/ConectaProveedores.EmailTheme.extra.css",

        };

        public async Task<string> GetEmailContentAsync(IRequestContext requestContext, string inParami_ApplicationName,string inParami_FolioNumber,string inParami_UserName,string inParami_RejectMotive,string inParami_Enviroment,string inParamRealEmailList,string inParamRealEmailCCList,bool inParamIsPROD, CancellationToken cancellationToken) {
            if (string.IsNullOrEmpty(inlineCss)) {
                inlineCss = await GetInlineStyleSheetIncludeAsync(CssFiles, cancellationToken);
            }
            binaryImages = new Dictionary<string, Image>();
            var expressions = new TemplateData();

            expressions.Add("KuHoXBrDSTkWVDh_ClD2oFQ_Subject", HtmlEncode((("Folios - Folio "+inParami_FolioNumber)+" rechazado por asignación errónea").ToString()));
            expressions.Add("STYLE", inlineCss);
            expressions.Add("v3_Style", MergeStyles("text-align: right;"));
            expressions.Add("v8_Style", MergeStyles("text-align: left;"));
            expressions.Add("v9_Style", MergeStyles("margin-left: 0"));
            expressions.Add("v12_Style", MergeStyles("color: #ae0000; font-size: 16px;"));
            expressions.Add("v18_Style", MergeStyles("margin-left: 0"));
            expressions.Add("v21_Style", MergeStyles("margin-left: 0px"));
            expressions["KJGQAZPwDMEqUI_utmsJRQw_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", "img/ConectaProveedores.Logo.jpg")).ToString());
            expressions["Kmy_USJUxXEqV6QVDM9pNhg_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["Kjq0_zL2iFEySxZv5Eyz_GA_Value"] = HtmlEncode(inParami_FolioNumber.ToString());
            expressions["KBmhfl4L5a0i5JD4klvz3mQ_Value"] = HtmlEncode(inParami_RejectMotive.ToString());
            expressions["KiXOV0RYGzECdVcNFCneH2A_Value"] = HtmlEncode(("Por favor, accede al enlace"+" ").ToString());
            expressions["KXp4u4cq_K0yhu32O8Rq2SQ_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", (((((string)AppUtils.SiteProperties[SitePropertiesModel.spCurrentDomain])))+"ConectaProveedores"))).ToString());
            expressions["KF1dJ8s9_Qk2F3vFusgeBpw_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["KzlOE7DEIKkmz9fjIgj1cVg_Value"] = HtmlEncode(BuiltInFunction.Year (BuiltInFunction.CurrDate ()).ToString());
            expressions["KqKcYvRmhK0iCqLtz4ISeog_Value"] = HtmlEncode(inParami_ApplicationName.ToString());

            var condition_KPG2F8gM7ykunbiGK_YIAeg_ = (inParami_Enviroment=="PROD");
            expressions["KPG2F8gM7ykunbiGK_YIAeg_"] = condition_KPG2F8gM7ykunbiGK_YIAeg_;
            if (condition_KPG2F8gM7ykunbiGK_YIAeg_) {
            } else {

            var condition_KYVzG7Q0EaUuT_u719YxyKg_ = (inParami_Enviroment=="DEV");
            expressions["KYVzG7Q0EaUuT_u719YxyKg_"] = condition_KYVzG7Q0EaUuT_u719YxyKg_;
            if (condition_KYVzG7Q0EaUuT_u719YxyKg_) {
            } else {

            var condition_Kqobf9M1380mF1BfqJEwDcg_ = (inParami_Enviroment=="QA");
            expressions["Kqobf9M1380mF1BfqJEwDcg_"] = condition_Kqobf9M1380mF1BfqJEwDcg_;
            if (condition_Kqobf9M1380mF1BfqJEwDcg_) {
            } else {
            }

            }

            }


            var condition_KfnDF5ipTEkC_KrVF0HwqFA_ = (inParami_UserName!="");
            expressions["KfnDF5ipTEkC_KrVF0HwqFA_"] = condition_KfnDF5ipTEkC_KrVF0HwqFA_;
            if (condition_KfnDF5ipTEkC_KrVF0HwqFA_) {
            expressions["K9tISMD3TPk66cqVoShz9Yg_Value"] = HtmlEncode((("Hola "+inParami_UserName)+"!").ToString());
            } else {
            }


            var condition_K_B5_nXqLsEGxQmxYEuzn1g_ = inParamIsPROD;
            expressions["K_B5_nXqLsEGxQmxYEuzn1g_"] = condition_K_B5_nXqLsEGxQmxYEuzn1g_;
            if (condition_K_B5_nXqLsEGxQmxYEuzn1g_) {
            } else {

            var condition_KofzW8Cmkz0ejBC11xjzfzQ_ = (inParamRealEmailList!="");
            expressions["KofzW8Cmkz0ejBC11xjzfzQ_"] = condition_KofzW8Cmkz0ejBC11xjzfzQ_;
            if (condition_KofzW8Cmkz0ejBC11xjzfzQ_) {
            expressions["KCRSpGjU6RUOt5dP856IItg_Value"] = HtmlEncode(("Se enviará a: "+inParamRealEmailList).ToString());
            } else {
            }


            var condition_KKuRWr_58HUqpIv9WD7S0Cg_ = (inParamRealEmailCCList!="");
            expressions["KKuRWr_58HUqpIv9WD7S0Cg_"] = condition_KKuRWr_58HUqpIv9WD7S0Cg_;
            if (condition_KKuRWr_58HUqpIv9WD7S0Cg_) {
            expressions["Kfzy5AVbyjUmq0sG2sbGBqg_Value"] = HtmlEncode(("En CC: "+inParamRealEmailCCList).ToString());
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
