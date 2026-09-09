using System.Web;
using OutSystems.Application.Abstractions.Emails;
using OutSystems.Application.Emails;
using OutSystems.Application.Core.Email;
using OutSystems.Application.Models.Emails;
using OutSystems.ObjectKeys;
using IterativeTemplateData = System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>>;
using TemplateData = System.Collections.Generic.Dictionary<string, object>;

namespace ssConectaProveedores.Flows.Flowj_FoliosSAE_Emails {

    public class j_FoliosSAE_Emails_EvidenceRequestFolio : EmailScreen {

        public j_FoliosSAE_Emails_EvidenceRequestFolio(
            ISettingsProvider settingsProvider,
            IApplicationLogger applicationLogger,
            ICssFlatteningService cssFlatteningService) : base(settingsProvider, applicationLogger, cssFlatteningService) { }

        private static string inlineCss;

        

        private static string _template;
        internal virtual string Template {
            get { return _template ?? (_template = GetTemplateContent("j_FoliosSAE_Emails.EvidenceRequestFolio.html.resources")); }
        }

        protected static readonly IEnumerable<string> CssFiles = new List<string> {
"css/ConectaProveedores.EmailTheme.css",
"css/ConectaProveedores.j_FoliosSAE_Emails.EvidenceRequestFolio.css",
"css/ConectaProveedores.EmailTheme.extra.css",

        };

        public async Task<string> GetEmailContentAsync(IRequestContext requestContext, string inParami_ApplicationName,string inParami_FolioNumber,string inParami_UserName,string inParami_EvidenceRequestReason,string inParami_Enviroment,string inParami_UserNameEvidenceRequest,string inParamRealEmailList,string inParamRealEmailCCList,bool inParamIsPROD, CancellationToken cancellationToken) {
            if (string.IsNullOrEmpty(inlineCss)) {
                inlineCss = await GetInlineStyleSheetIncludeAsync(CssFiles, cancellationToken);
            }
            binaryImages = new Dictionary<string, Image>();
            var expressions = new TemplateData();

            expressions.Add("Kesix9enCKU2gkneuSviFog_Subject", HtmlEncode(("Folios - Solicitar evidencia del folio "+inParami_FolioNumber).ToString()));
            expressions.Add("STYLE", inlineCss);
            expressions.Add("v3_Style", MergeStyles("text-align: right;"));
            expressions.Add("v8_Style", MergeStyles("text-align: left;"));
            expressions.Add("v9_Style", MergeStyles("margin-left: 0"));
            expressions.Add("v13_Style", MergeStyles("color: #ae0000; font-size: 16px;"));
            expressions.Add("v19_Style", MergeStyles("margin-left: 0"));
            expressions.Add("v22_Style", MergeStyles("margin-left: 0px"));
            expressions["KJGQAZPwDMEqUI_utmsJRQw_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", "img/ConectaProveedores.Logo.jpg")).ToString());
            expressions["K94vDavHlZka4l7caxW4vUQ_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["Kxhqy4hfpRU_1Wy709qzfIw_Value"] = HtmlEncode(inParami_FolioNumber.ToString());
            expressions["K8oO6LFYQqEmSnte0bTAYOw_Value"] = HtmlEncode(inParami_UserNameEvidenceRequest.ToString());
            expressions["KApkxP1mmD0W_jNMBdy3TnQ_Value"] = HtmlEncode(inParami_EvidenceRequestReason.ToString());
            expressions["Ko1CqDBG_4kWflhcPZkfm_A_Value"] = HtmlEncode(("Por favor, accede al enlace"+" ").ToString());
            expressions["KNJf9_cObt02HoW8vSeEcng_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", (((((string)AppUtils.SiteProperties[SitePropertiesModel.spCurrentDomain])))+"ConectaProveedores"))).ToString());
            expressions["KwmO_xbKu00yjj3gqrF2RsA_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["Kf2Nroc5WzkGvUfl2ptoFwA_Value"] = HtmlEncode(BuiltInFunction.Year (BuiltInFunction.CurrDate ()).ToString());
            expressions["K8tE71pjuIE_FLlLcwcqYow_Value"] = HtmlEncode(inParami_ApplicationName.ToString());

            var condition_KtA4trcPsVkiUb1d56wEUhw_ = (inParami_Enviroment=="PROD");
            expressions["KtA4trcPsVkiUb1d56wEUhw_"] = condition_KtA4trcPsVkiUb1d56wEUhw_;
            if (condition_KtA4trcPsVkiUb1d56wEUhw_) {
            } else {

            var condition_K36nynpkJX0aO4PBrjxVLFw_ = (inParami_Enviroment=="DEV");
            expressions["K36nynpkJX0aO4PBrjxVLFw_"] = condition_K36nynpkJX0aO4PBrjxVLFw_;
            if (condition_K36nynpkJX0aO4PBrjxVLFw_) {
            } else {

            var condition_KZvpYp4VVQECnruJycM_dFA_ = (inParami_Enviroment=="QA");
            expressions["KZvpYp4VVQECnruJycM_dFA_"] = condition_KZvpYp4VVQECnruJycM_dFA_;
            if (condition_KZvpYp4VVQECnruJycM_dFA_) {
            } else {
            }

            }

            }


            var condition_KRu5j2ZT_WUOkPa0u_IqvOw_ = (inParami_UserName!="");
            expressions["KRu5j2ZT_WUOkPa0u_IqvOw_"] = condition_KRu5j2ZT_WUOkPa0u_IqvOw_;
            if (condition_KRu5j2ZT_WUOkPa0u_IqvOw_) {
            expressions["Kj741p9c5TUqpnASFY5KqVg_Value"] = HtmlEncode((("Hola "+inParami_UserName)+"!").ToString());
            } else {
            }


            var condition_KzjdwnKOrl0yUQPIyXrJ5Mw_ = inParamIsPROD;
            expressions["KzjdwnKOrl0yUQPIyXrJ5Mw_"] = condition_KzjdwnKOrl0yUQPIyXrJ5Mw_;
            if (condition_KzjdwnKOrl0yUQPIyXrJ5Mw_) {
            } else {

            var condition_KCjJpMeLuH0uoCeCiG2G33Q_ = (inParamRealEmailList!="");
            expressions["KCjJpMeLuH0uoCeCiG2G33Q_"] = condition_KCjJpMeLuH0uoCeCiG2G33Q_;
            if (condition_KCjJpMeLuH0uoCeCiG2G33Q_) {
            expressions["KZ0FduG2lgkWK0ho5NsktaA_Value"] = HtmlEncode(("Se enviará a: "+inParamRealEmailList).ToString());
            } else {
            }


            var condition_KqacjHFSEa02rbRnqVESHlw_ = (inParamRealEmailCCList!="");
            expressions["KqacjHFSEa02rbRnqVESHlw_"] = condition_KqacjHFSEa02rbRnqVESHlw_;
            if (condition_KqacjHFSEa02rbRnqVESHlw_) {
            expressions["KVGPVC7Muf0yuGJsm6SeMNQ_Value"] = HtmlEncode(("En CC: "+inParamRealEmailCCList).ToString());
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
