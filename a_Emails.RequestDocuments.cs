using System.Web;
using OutSystems.Application.Abstractions.Emails;
using OutSystems.Application.Emails;
using OutSystems.Application.Core.Email;
using OutSystems.Application.Models.Emails;
using OutSystems.ObjectKeys;
using IterativeTemplateData = System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>>;
using TemplateData = System.Collections.Generic.Dictionary<string, object>;

namespace ssConectaProveedores.Flows.Flowa_Emails {

    public class a_Emails_RequestDocuments : EmailScreen {

        public a_Emails_RequestDocuments(
            ISettingsProvider settingsProvider,
            IApplicationLogger applicationLogger,
            ICssFlatteningService cssFlatteningService) : base(settingsProvider, applicationLogger, cssFlatteningService) { }

        private static string inlineCss;

        

        private static string _template;
        internal virtual string Template {
            get { return _template ?? (_template = GetTemplateContent("a_Emails.RequestDocuments.html.resources")); }
        }

        protected static readonly IEnumerable<string> CssFiles = new List<string> {
"css/ConectaProveedores.EmailTheme.css",
"css/ConectaProveedores.a_Emails.RequestDocuments.css",
"css/ConectaProveedores.EmailTheme.extra.css",

        };

        public async Task<string> GetEmailContentAsync(IRequestContext requestContext, string inParamApplicationName,string inParamDocuments,string inParami_Environment,string inParamCustomerName,string inParamCustomerEmail, CancellationToken cancellationToken) {
            if (string.IsNullOrEmpty(inlineCss)) {
                inlineCss = await GetInlineStyleSheetIncludeAsync(CssFiles, cancellationToken);
            }
            binaryImages = new Dictionary<string, Image>();
            var expressions = new TemplateData();

            expressions.Add("KGJg7aVSds0_qF7acofAOsg_Subject", HtmlEncode(("Código para "+inParamApplicationName).ToString()));
            expressions.Add("STYLE", inlineCss);
            expressions.Add("v4_Style", MergeStyles("text-align: left;"));
            expressions.Add("v7_Style", MergeStyles("height: 200px;"));
            expressions.Add("v10_Style", MergeStyles("margin-left: 0"));
            expressions.Add("v13_Style", MergeStyles("margin-left: 0px"));
            expressions["KJGQAZPwDMEqUI_utmsJRQw_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", "img/ConectaProveedores.Logo.jpg")).ToString());
            expressions["KsmqfUssAlEaOs7tFROdswg_Value"] = HtmlEncode(inParamApplicationName.ToString());
            expressions["KDEP1GXqlWkq77m8wFsungg_Value"] = HtmlEncode(inParamDocuments.ToString());
            expressions["KG74zMb49_E6Nn0TDGUnqKA_Value"] = HtmlEncode(inParamApplicationName.ToString());
            expressions["KmvQ5NSgUMUOxWdyNkQO28A_Value"] = HtmlEncode(BuiltInFunction.Year (BuiltInFunction.CurrDate ()).ToString());
            expressions["Kj21JT6buq0KnTwvKO_jxWA_Value"] = HtmlEncode(inParamApplicationName.ToString());

            var condition_KA0BP6Geav0eZDheiOhi5og_ = (inParami_Environment=="PROD");
            expressions["KA0BP6Geav0eZDheiOhi5og_"] = condition_KA0BP6Geav0eZDheiOhi5og_;
            if (condition_KA0BP6Geav0eZDheiOhi5og_) {
            } else {
            expressions["K_WeVb2btDUugzOi_p8x6rQ_Value"] = HtmlEncode(((("Se enviará a: "+inParamCustomerEmail)+" / ")+(((inParamCustomerName!="")) ? (inParamCustomerName) : ("Nome no encontrado o vacio"))).ToString());
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
