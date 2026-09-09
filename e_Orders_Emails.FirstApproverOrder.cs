using System.Web;
using OutSystems.Application.Abstractions.Emails;
using OutSystems.Application.Emails;
using OutSystems.Application.Core.Email;
using OutSystems.Application.Models.Emails;
using OutSystems.ObjectKeys;
using IterativeTemplateData = System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>>;
using TemplateData = System.Collections.Generic.Dictionary<string, object>;

namespace ssConectaProveedores.Flows.Flowe_Orders_Emails {

    public class e_Orders_Emails_FirstApproverOrder : EmailScreen {

        public e_Orders_Emails_FirstApproverOrder(
            ISettingsProvider settingsProvider,
            IApplicationLogger applicationLogger,
            ICssFlatteningService cssFlatteningService) : base(settingsProvider, applicationLogger, cssFlatteningService) { }

        private static string inlineCss;

        

        private static string _template;
        internal virtual string Template {
            get { return _template ?? (_template = GetTemplateContent("e_Orders_Emails.FirstApproverOrder.html.resources")); }
        }

        protected static readonly IEnumerable<string> CssFiles = new List<string> {
"css/ConectaProveedores.EmailTheme.css",
"css/ConectaProveedores.e_Orders_Emails.FirstApproverOrder.css",
"css/ConectaProveedores.EmailTheme.extra.css",

        };

        public async Task<string> GetEmailContentAsync(IRequestContext requestContext, string inParami_ApplicationName,string inParami_Environment,string inParami_CustomerEmail,string inParami_OrderNumber,string inParami_UserName,string inParami_UserNameSubmission,string inParami_RealEmailList,string inParami_RealEmailCCList,bool inParami_IsPROD, CancellationToken cancellationToken) {
            if (string.IsNullOrEmpty(inlineCss)) {
                inlineCss = await GetInlineStyleSheetIncludeAsync(CssFiles, cancellationToken);
            }
            binaryImages = new Dictionary<string, Image>();
            var expressions = new TemplateData();

            expressions.Add("KVtePBV8KRU2DrL1cwLO_ZA_Subject", HtmlEncode(("Pedidos - Pedido Complementado "+inParami_OrderNumber).ToString()));
            expressions.Add("STYLE", inlineCss);
            expressions.Add("v3_Style", MergeStyles("text-align: right;"));
            expressions.Add("v8_Style", MergeStyles("text-align: left;"));
            expressions.Add("v16_Style", MergeStyles("margin-left: 0"));
            expressions.Add("v19_Style", MergeStyles("margin-left: 0px"));
            expressions["KJGQAZPwDMEqUI_utmsJRQw_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", "img/ConectaProveedores.Logo.jpg")).ToString());
            expressions["K7XZ8yAglTkegLADtszUO5A_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["K9UOXWK2ZHUqT09hr_Y5N5g_Value"] = HtmlEncode(inParami_OrderNumber.ToString());
            expressions["KmCrVVeh4uUazyEugDPT7Ng_Value"] = HtmlEncode(((" acaba de ser "+"conplementado")+" por ").ToString());
            expressions["Kst3qfa5vlU2DQ9pk5EGNlg_Value"] = HtmlEncode(inParami_UserNameSubmission.ToString());
            expressions["KKnvJ5kTHbkyfsbr0kgOsfw_Value"] = HtmlEncode(("Por favor, accede al enlace"+" ").ToString());
            expressions["Kuqf5_Cmi90aXg1ytwyfYyw_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", (((((string)AppUtils.SiteProperties[SitePropertiesModel.spCurrentDomain])))+"ConectaProveedores"))).ToString());
            expressions["KjvIyA_9RakSOn9S6g1Ihrg_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["KxQvjvXcB10qGubkT7iOFfQ_Value"] = HtmlEncode(BuiltInFunction.Year (BuiltInFunction.CurrDate ()).ToString());
            expressions["KYMLUk9_p4U_rri8wsiOF1A_Value"] = HtmlEncode(inParami_ApplicationName.ToString());

            var condition_KuOjgbvuHt0mWLdWO5vB6Sw_ = (inParami_Environment=="PROD");
            expressions["KuOjgbvuHt0mWLdWO5vB6Sw_"] = condition_KuOjgbvuHt0mWLdWO5vB6Sw_;
            if (condition_KuOjgbvuHt0mWLdWO5vB6Sw_) {
            } else {

            var condition_KTkvnNM2670_DecGrRz5olA_ = (inParami_Environment=="DEV");
            expressions["KTkvnNM2670_DecGrRz5olA_"] = condition_KTkvnNM2670_DecGrRz5olA_;
            if (condition_KTkvnNM2670_DecGrRz5olA_) {
            } else {

            var condition_KDc60yKMFU0CBI2_fqFqnuQ_ = (inParami_Environment=="QA");
            expressions["KDc60yKMFU0CBI2_fqFqnuQ_"] = condition_KDc60yKMFU0CBI2_fqFqnuQ_;
            if (condition_KDc60yKMFU0CBI2_fqFqnuQ_) {
            } else {
            }

            }

            }


            var condition_K0Ob9KG5Lr0CeZDhO2eX22A_ = (inParami_UserName!="");
            expressions["K0Ob9KG5Lr0CeZDhO2eX22A_"] = condition_K0Ob9KG5Lr0CeZDhO2eX22A_;
            if (condition_K0Ob9KG5Lr0CeZDhO2eX22A_) {
            expressions["KLbvKt3U_Qkq2hcJ2Welpew_Value"] = HtmlEncode((("Hola "+inParami_UserName)+"!").ToString());
            } else {
            }


            var condition_KKREsynFmxUm3wmrbEdva6g_ = inParami_IsPROD;
            expressions["KKREsynFmxUm3wmrbEdva6g_"] = condition_KKREsynFmxUm3wmrbEdva6g_;
            if (condition_KKREsynFmxUm3wmrbEdva6g_) {
            } else {

            var condition_Ka46_cxOdLEuTwZz_zEjXVw_ = (inParami_RealEmailList!="");
            expressions["Ka46_cxOdLEuTwZz_zEjXVw_"] = condition_Ka46_cxOdLEuTwZz_zEjXVw_;
            if (condition_Ka46_cxOdLEuTwZz_zEjXVw_) {
            expressions["KlitqSruqWECn4yQwSEAASQ_Value"] = HtmlEncode(("Se enviará a: "+inParami_RealEmailList).ToString());
            } else {
            }


            var condition_KT5_Bl5rTh0y5Aak40HVSzQ_ = (inParami_RealEmailCCList!="");
            expressions["KT5_Bl5rTh0y5Aak40HVSzQ_"] = condition_KT5_Bl5rTh0y5Aak40HVSzQ_;
            if (condition_KT5_Bl5rTh0y5Aak40HVSzQ_) {
            expressions["KX_gF8Ud2rEu27zRvpiD_SA_Value"] = HtmlEncode(("En CC: "+inParami_RealEmailCCList).ToString());
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
