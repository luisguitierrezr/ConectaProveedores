using System.Web;
using OutSystems.Application.Abstractions.Emails;
using OutSystems.Application.Emails;
using OutSystems.Application.Core.Email;
using OutSystems.Application.Models.Emails;
using OutSystems.ObjectKeys;
using IterativeTemplateData = System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>>;
using TemplateData = System.Collections.Generic.Dictionary<string, object>;

namespace ssConectaProveedores.Flows.Flowj_FoliosSAE_Emails {

    public class j_FoliosSAE_Emails_PreApprovalCanceledFolio : EmailScreen {

        public j_FoliosSAE_Emails_PreApprovalCanceledFolio(
            ISettingsProvider settingsProvider,
            IApplicationLogger applicationLogger,
            ICssFlatteningService cssFlatteningService) : base(settingsProvider, applicationLogger, cssFlatteningService) { }

        private static string inlineCss;

        

        private static string _template;
        internal virtual string Template {
            get { return _template ?? (_template = GetTemplateContent("j_FoliosSAE_Emails.PreApprovalCanceledFolio.html.resources")); }
        }

        protected static readonly IEnumerable<string> CssFiles = new List<string> {
"css/ConectaProveedores.EmailTheme.css",
"css/ConectaProveedores.j_FoliosSAE_Emails.PreApprovalCanceledFolio.css",
"css/ConectaProveedores.EmailTheme.extra.css",

        };

        public async Task<string> GetEmailContentAsync(IRequestContext requestContext, string inParamSubject,string inParamInvoiceNumber,string inParamFolioNumber,bool inParamIsInvoiceCancel,string inParami_ApplicationName,string inParami_Enviroment,string inParamReason,bool inParamIsEntryCancel, CancellationToken cancellationToken) {
            if (string.IsNullOrEmpty(inlineCss)) {
                inlineCss = await GetInlineStyleSheetIncludeAsync(CssFiles, cancellationToken);
            }
            binaryImages = new Dictionary<string, Image>();
            var expressions = new TemplateData();

            expressions.Add("KhAMBJTenTEqFndkVJ5YXlQ_Subject", HtmlEncode(inParamSubject.ToString()));
            expressions.Add("STYLE", inlineCss);
            expressions.Add("v3_Style", MergeStyles("text-align: right;"));
            expressions.Add("v7_Style", MergeStyles("text-align: left;"));
            expressions.Add("v9_Style", MergeStyles("margin-left: 0"));
            expressions.Add("v11_Style", MergeStyles("margin-left: 0"));
            expressions.Add("v13_Style", MergeStyles("margin-left: 0"));
            expressions.Add("v16_Style", MergeStyles("color: #ae0000; font-size: 16px;"));
            expressions.Add("v22_Style", MergeStyles("margin-left: 0"));
            expressions.Add("v25_Style", MergeStyles("margin-left: 0px"));
            expressions["KJGQAZPwDMEqUI_utmsJRQw_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", "img/ConectaProveedores.Logo.jpg")).ToString());
            expressions["KffgOMHdCb0es7T0NQ2V_jg_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["Kt5X9X9XdTUCyEbj42ib2Aw_Value"] = HtmlEncode(inParamReason.ToString());
            expressions["KCqf1NHGMWEqmp5D1aZ6UiA_Value"] = HtmlEncode(("Por favor, accede al enlace"+" ").ToString());
            expressions["K5zi5Zzop60eCMcKehW2g1g_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", (((((string)AppUtils.SiteProperties[SitePropertiesModel.spCurrentDomain])))+"ConectaProveedores"))).ToString());
            expressions["KgMRirvsgl0SVIpwOq7gWHQ_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["K4fQ1VwP_2EKvE_283xjG_Q_Value"] = HtmlEncode(BuiltInFunction.Year (BuiltInFunction.CurrDate ()).ToString());
            expressions["K7M8tu32s7Ui684CBrfS4Qg_Value"] = HtmlEncode(inParami_ApplicationName.ToString());

            var condition_Kg__0Huthw0_rgKBTwlUWkA_ = (inParami_Enviroment=="PROD");
            expressions["Kg__0Huthw0_rgKBTwlUWkA_"] = condition_Kg__0Huthw0_rgKBTwlUWkA_;
            if (condition_Kg__0Huthw0_rgKBTwlUWkA_) {
            } else {

            var condition_KAOtzGqlxr0SEYr3W661bUQ_ = (inParami_Enviroment=="DEV");
            expressions["KAOtzGqlxr0SEYr3W661bUQ_"] = condition_KAOtzGqlxr0SEYr3W661bUQ_;
            if (condition_KAOtzGqlxr0SEYr3W661bUQ_) {
            } else {

            var condition_KHTcajeNklUeVBnIvmeNbpQ_ = (inParami_Enviroment=="QA");
            expressions["KHTcajeNklUeVBnIvmeNbpQ_"] = condition_KHTcajeNklUeVBnIvmeNbpQ_;
            if (condition_KHTcajeNklUeVBnIvmeNbpQ_) {
            } else {
            }

            }

            }


            var condition_K_tuQfinHrkCaqPPkxxD9qg_ = inParamIsEntryCancel;
            expressions["K_tuQfinHrkCaqPPkxxD9qg_"] = condition_K_tuQfinHrkCaqPPkxxD9qg_;
            if (condition_K_tuQfinHrkCaqPPkxxD9qg_) {
            expressions["KsJefgOA5Rk6Buc5LZMinog_Value"] = HtmlEncode((("La entrada correspondiente al folio número "+inParamFolioNumber)+" ha sido cancelada.").ToString());
            } else {
            }


            var condition_KfyzSaIRdOEeCKHIqGypl_w_ = (inParamInvoiceNumber!="");
            expressions["KfyzSaIRdOEeCKHIqGypl_w_"] = condition_KfyzSaIRdOEeCKHIqGypl_w_;
            if (condition_KfyzSaIRdOEeCKHIqGypl_w_) {
            expressions["KDx5Hn77fE0SmnsZmxcjMCg_Value"] = HtmlEncode((((("La factura número "+inParamInvoiceNumber)+" ha sido ")+((inParamIsInvoiceCancel) ? ("cancelada") : ("rechazada")))+".").ToString());
            } else {
            }


            var condition_KDN0U4JHed0eCqdU_i1n_xQ_ = (inParamFolioNumber!="");
            expressions["KDN0U4JHed0eCqdU_i1n_xQ_"] = condition_KDN0U4JHed0eCqdU_i1n_xQ_;
            if (condition_KDN0U4JHed0eCqdU_i1n_xQ_) {
            expressions["KXQRmdv6nakCbalinmpAGqQ_Value"] = HtmlEncode((("El folio número SAEC"+inParamFolioNumber)+" ha sido cancelado.").ToString());
            } else {
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
