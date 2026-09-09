using System.Web;
using OutSystems.Application.Abstractions.Emails;
using OutSystems.Application.Emails;
using OutSystems.Application.Core.Email;
using OutSystems.Application.Models.Emails;
using OutSystems.ObjectKeys;
using IterativeTemplateData = System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>>;
using TemplateData = System.Collections.Generic.Dictionary<string, object>;

namespace ssConectaProveedores.Flows.Flowh_OrderDistribution_Emails {

    public class h_OrderDistribution_Emails_RejectOrderDistribution : EmailScreen {

        public h_OrderDistribution_Emails_RejectOrderDistribution(
            ISettingsProvider settingsProvider,
            IApplicationLogger applicationLogger,
            ICssFlatteningService cssFlatteningService) : base(settingsProvider, applicationLogger, cssFlatteningService) { }

        private static string inlineCss;

        

        private static string _template;
        internal virtual string Template {
            get { return _template ?? (_template = GetTemplateContent("h_OrderDistribution_Emails.RejectOrderDistribution.html.resources")); }
        }

        protected static readonly IEnumerable<string> CssFiles = new List<string> {
"css/ConectaProveedores.EmailTheme.css",
"css/ConectaProveedores.h_OrderDistribution_Emails.RejectOrderDistribution.css",
"css/ConectaProveedores.EmailTheme.extra.css",

        };

        public async Task<string> GetEmailContentAsync(IRequestContext requestContext, string inParami_ApplicationName,string inParami_OrderNumber,string inParami_UserName,string inParami_Environment,string inParamRealEmailList,string inParamRealEmailCCList,bool inParamIsPROD, CancellationToken cancellationToken) {
            if (string.IsNullOrEmpty(inlineCss)) {
                inlineCss = await GetInlineStyleSheetIncludeAsync(CssFiles, cancellationToken);
            }
            binaryImages = new Dictionary<string, Image>();
            var expressions = new TemplateData();

            expressions.Add("KFNhOl0MV2kSGVhRk2Mrafw_Subject", HtmlEncode(("Pedido - Rechazo del Pedido "+inParami_OrderNumber).ToString()));
            expressions.Add("STYLE", inlineCss);
            expressions.Add("v3_Style", MergeStyles("text-align: right;"));
            expressions.Add("v8_Style", MergeStyles("text-align: left;"));
            expressions.Add("v9_Style", MergeStyles("margin-left: 0"));
            expressions.Add("v15_Style", MergeStyles("margin-left: 0"));
            expressions.Add("v18_Style", MergeStyles("margin-left: 0px"));
            expressions["KJGQAZPwDMEqUI_utmsJRQw_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", "img/ConectaProveedores.Logo.jpg")).ToString());
            expressions["KS_PxF7nHsUqD_ZqOicIO2A_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["KJBN_TqhPjUukuU0VaP5Ofg_Value"] = HtmlEncode(inParami_OrderNumber.ToString());
            expressions["KbTk2MFMl3EGjyw_4g_lycA_Value"] = HtmlEncode(("Por favor, accede al enlace"+" ").ToString());
            expressions["KVdWyFk7Vb0eKNtdeYrkDCw_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", (((((string)AppUtils.SiteProperties[SitePropertiesModel.spCurrentDomain])))+"ConectaProveedores"))).ToString());
            expressions["KaDb4QoeCg0_waxItcU2pcw_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["KU3Zl25ewgECFZx_EYcZgkg_Value"] = HtmlEncode(BuiltInFunction.Year (BuiltInFunction.CurrDate ()).ToString());
            expressions["KvSd3b9VCsUeFwWIWYXusoA_Value"] = HtmlEncode(inParami_ApplicationName.ToString());

            var condition_K7gphAMLqqUaD_tD9NmpNcA_ = (inParami_Environment=="PROD");
            expressions["K7gphAMLqqUaD_tD9NmpNcA_"] = condition_K7gphAMLqqUaD_tD9NmpNcA_;
            if (condition_K7gphAMLqqUaD_tD9NmpNcA_) {
            } else {

            var condition_KZfOYpM9BA0y9T_r6RfATCQ_ = (inParami_Environment=="DEV");
            expressions["KZfOYpM9BA0y9T_r6RfATCQ_"] = condition_KZfOYpM9BA0y9T_r6RfATCQ_;
            if (condition_KZfOYpM9BA0y9T_r6RfATCQ_) {
            } else {

            var condition_KbcNfbXUm1EKrcGj9GEdT0Q_ = (inParami_Environment=="QA");
            expressions["KbcNfbXUm1EKrcGj9GEdT0Q_"] = condition_KbcNfbXUm1EKrcGj9GEdT0Q_;
            if (condition_KbcNfbXUm1EKrcGj9GEdT0Q_) {
            } else {
            }

            }

            }


            var condition_KWsFuk2lPzkuGXaBdR_KOsg_ = (inParami_UserName!="");
            expressions["KWsFuk2lPzkuGXaBdR_KOsg_"] = condition_KWsFuk2lPzkuGXaBdR_KOsg_;
            if (condition_KWsFuk2lPzkuGXaBdR_KOsg_) {
            expressions["KG2EBi_yBmEK7jqwuH2xezQ_Value"] = HtmlEncode((("Hola "+inParami_UserName)+"!").ToString());
            } else {
            }


            var condition_K_zkA4SbpfkWY4zCmzF2BIQ_ = inParamIsPROD;
            expressions["K_zkA4SbpfkWY4zCmzF2BIQ_"] = condition_K_zkA4SbpfkWY4zCmzF2BIQ_;
            if (condition_K_zkA4SbpfkWY4zCmzF2BIQ_) {
            } else {

            var condition_KN89Q3FHVmkC_fdUQrkb46w_ = (inParamRealEmailList!="");
            expressions["KN89Q3FHVmkC_fdUQrkb46w_"] = condition_KN89Q3FHVmkC_fdUQrkb46w_;
            if (condition_KN89Q3FHVmkC_fdUQrkb46w_) {
            expressions["KHchu6BKEeUyuEUF6a3CB3g_Value"] = HtmlEncode(("Se enviará a: "+inParamRealEmailList).ToString());
            } else {
            }


            var condition_KtvSsSiikiUChccjki_0urw_ = (inParamRealEmailCCList!="");
            expressions["KtvSsSiikiUChccjki_0urw_"] = condition_KtvSsSiikiUChccjki_0urw_;
            if (condition_KtvSsSiikiUChccjki_0urw_) {
            expressions["KuT7D_gjBKkC5w3I19A3RQg_Value"] = HtmlEncode(("En CC: "+inParamRealEmailCCList).ToString());
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
