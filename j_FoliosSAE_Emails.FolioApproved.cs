using System.Web;
using OutSystems.Application.Abstractions.Emails;
using OutSystems.Application.Emails;
using OutSystems.Application.Core.Email;
using OutSystems.Application.Models.Emails;
using OutSystems.ObjectKeys;
using IterativeTemplateData = System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>>;
using TemplateData = System.Collections.Generic.Dictionary<string, object>;

namespace ssConectaProveedores.Flows.Flowj_FoliosSAE_Emails {

    public class j_FoliosSAE_Emails_FolioApproved : EmailScreen {

        public j_FoliosSAE_Emails_FolioApproved(
            ISettingsProvider settingsProvider,
            IApplicationLogger applicationLogger,
            ICssFlatteningService cssFlatteningService) : base(settingsProvider, applicationLogger, cssFlatteningService) { }

        private static string inlineCss;

        

        private static string _template;
        internal virtual string Template {
            get { return _template ?? (_template = GetTemplateContent("j_FoliosSAE_Emails.FolioApproved.html.resources")); }
        }

        protected static readonly IEnumerable<string> CssFiles = new List<string> {
"css/ConectaProveedores.EmailTheme.css",
"css/ConectaProveedores.j_FoliosSAE_Emails.FolioApproved.css",
"css/ConectaProveedores.EmailTheme.extra.css",

        };

        public async Task<string> GetEmailContentAsync(IRequestContext requestContext, string inParami_ApplicationName,string inParami_FolioNumber,string inParami_UserName,string inParami_Enviroment,string inParami_EntryNumber,string inParamRealEmailList,string inParamRealEmailCCList,bool inParamIsPROD,bool inParami_IsConstruction, CancellationToken cancellationToken) {
            if (string.IsNullOrEmpty(inlineCss)) {
                inlineCss = await GetInlineStyleSheetIncludeAsync(CssFiles, cancellationToken);
            }
            binaryImages = new Dictionary<string, Image>();
            var expressions = new TemplateData();

            expressions.Add("KWygPARkmAUyvyZVxRIF4rg_Subject", HtmlEncode(("Folios - Folio Aprobado "+inParami_FolioNumber).ToString()));
            expressions.Add("STYLE", inlineCss);
            expressions.Add("v3_Style", MergeStyles("text-align: right;"));
            expressions.Add("v8_Style", MergeStyles("text-align: left;"));
            expressions.Add("v15_Style", MergeStyles("margin-left: 0"));
            expressions.Add("v18_Style", MergeStyles("margin-left: 0px"));
            expressions["KJGQAZPwDMEqUI_utmsJRQw_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", "img/ConectaProveedores.Logo.jpg")).ToString());
            expressions["Krqn1wJlP00uckGJ8OFg4CQ_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["KpFFqtVDzlkeHzp4aygrihg_Value"] = HtmlEncode(inParami_FolioNumber.ToString());
            expressions["KWasw7c3rq0mk70hIM036Qw_Value"] = HtmlEncode((((" acaba de ser aprobado"+(((inParami_EntryNumber!="")) ? ((" con el número de entrada: "+inParami_EntryNumber)) : (" ")))+((inParami_IsConstruction) ? (" y está esperando a que se cargue la factura") : ("")))+".").ToString());
            expressions["KzY_WDUOSq0W4FtKWOfjqtg_Value"] = HtmlEncode(("Por favor, accede al enlace"+" ").ToString());
            expressions["K_8UCvaA9g06al6sRr5XJvg_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", (((((string)AppUtils.SiteProperties[SitePropertiesModel.spCurrentDomain])))+"ConectaProveedores"))).ToString());
            expressions["KIAT8vwwj2U2k8p3ycG0tiQ_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["K4SU9jFRWEEK8mfH85pvvYw_Value"] = HtmlEncode(BuiltInFunction.Year (BuiltInFunction.CurrDate ()).ToString());
            expressions["KErQq6MP1HECbRFIUwgH18Q_Value"] = HtmlEncode(inParami_ApplicationName.ToString());

            var condition_KWf6p5rj6l0W5L1WkCgMiwA_ = (inParami_Enviroment=="PROD");
            expressions["KWf6p5rj6l0W5L1WkCgMiwA_"] = condition_KWf6p5rj6l0W5L1WkCgMiwA_;
            if (condition_KWf6p5rj6l0W5L1WkCgMiwA_) {
            } else {

            var condition_K9EmyNGCUK0_j8EWQuWevCg_ = (inParami_Enviroment=="DEV");
            expressions["K9EmyNGCUK0_j8EWQuWevCg_"] = condition_K9EmyNGCUK0_j8EWQuWevCg_;
            if (condition_K9EmyNGCUK0_j8EWQuWevCg_) {
            } else {

            var condition_KJvQtgRMNeUqizfQ9PgVeWg_ = (inParami_Enviroment=="QA");
            expressions["KJvQtgRMNeUqizfQ9PgVeWg_"] = condition_KJvQtgRMNeUqizfQ9PgVeWg_;
            if (condition_KJvQtgRMNeUqizfQ9PgVeWg_) {
            } else {
            }

            }

            }


            var condition_K4hEqas3YJ0S06ktGLj1fyg_ = (inParami_UserName!="");
            expressions["K4hEqas3YJ0S06ktGLj1fyg_"] = condition_K4hEqas3YJ0S06ktGLj1fyg_;
            if (condition_K4hEqas3YJ0S06ktGLj1fyg_) {
            expressions["KdZSS44mYt0elhuOgdomZqQ_Value"] = HtmlEncode((("Hola "+inParami_UserName)+"!").ToString());
            } else {
            }


            var condition_Kw0KfJG68ek6cunGhdBnWdA_ = inParamIsPROD;
            expressions["Kw0KfJG68ek6cunGhdBnWdA_"] = condition_Kw0KfJG68ek6cunGhdBnWdA_;
            if (condition_Kw0KfJG68ek6cunGhdBnWdA_) {
            } else {

            var condition_KzraS6HOSqU2lbU5qs98XWA_ = (inParamRealEmailList!="");
            expressions["KzraS6HOSqU2lbU5qs98XWA_"] = condition_KzraS6HOSqU2lbU5qs98XWA_;
            if (condition_KzraS6HOSqU2lbU5qs98XWA_) {
            expressions["K0zY3T5G6vU_aCwNBx9gwiA_Value"] = HtmlEncode(("Se enviará a: "+inParamRealEmailList).ToString());
            } else {
            }


            var condition_KIHLSs3pi2kGgkWGXPGJSEw_ = (inParamRealEmailCCList!="");
            expressions["KIHLSs3pi2kGgkWGXPGJSEw_"] = condition_KIHLSs3pi2kGgkWGXPGJSEw_;
            if (condition_KIHLSs3pi2kGgkWGXPGJSEw_) {
            expressions["K_S1I0hxbqkiXJi4Lu2yjbw_Value"] = HtmlEncode(("En CC: "+inParamRealEmailCCList).ToString());
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
