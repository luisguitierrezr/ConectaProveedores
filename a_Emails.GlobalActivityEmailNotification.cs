using System.Web;
using OutSystems.Application.Abstractions.Emails;
using OutSystems.Application.Emails;
using OutSystems.Application.Core.Email;
using OutSystems.Application.Models.Emails;
using OutSystems.ObjectKeys;
using IterativeTemplateData = System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>>;
using TemplateData = System.Collections.Generic.Dictionary<string, object>;

namespace ssConectaProveedores.Flows.Flowa_Emails {

    public class a_Emails_GlobalActivityEmailNotification : EmailScreen {

        public a_Emails_GlobalActivityEmailNotification(
            ISettingsProvider settingsProvider,
            IApplicationLogger applicationLogger,
            ICssFlatteningService cssFlatteningService) : base(settingsProvider, applicationLogger, cssFlatteningService) { }

        private static string inlineCss;

        

        private static string _template;
        internal virtual string Template {
            get { return _template ?? (_template = GetTemplateContent("a_Emails.GlobalActivityEmailNotification.html.resources")); }
        }

        protected static readonly IEnumerable<string> CssFiles = new List<string> {
"css/ConectaProveedores.EmailTheme.css",
"css/ConectaProveedores.a_Emails.GlobalActivityEmailNotification.css",
"css/ConectaProveedores.EmailTheme.extra.css",

        };

        public async Task<string> GetEmailContentAsync(IRequestContext requestContext, string inParami_ApplicationName,string inParami_Environment, CancellationToken cancellationToken) {
            if (string.IsNullOrEmpty(inlineCss)) {
                inlineCss = await GetInlineStyleSheetIncludeAsync(CssFiles, cancellationToken);
            }
            binaryImages = new Dictionary<string, Image>();
            var expressions = new TemplateData();

            expressions.Add("STYLE", inlineCss);
            expressions.Add("v3_Style", MergeStyles("text-align: right;"));
            expressions.Add("v4_Style", MergeStyles("text-align: left;"));
            expressions.Add("v12_Style", MergeStyles("text-align: center;"));
            expressions.Add("v9_Style", MergeStyles("padding: 10px;"));
            expressions.Add("v14_Style", MergeStyles("margin-left: 0px"));
            expressions["KMpp02iJUn0WYbtrXBPr_zg_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", (((((string)AppUtils.SiteProperties[SitePropertiesModel.spCurrentDomain])))+"ConectaProveedores/"))).ToString());
            expressions["KBP0V9FgSqUmnqRD5s3P23Q_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", "img/Telcel_Theme.Light.svg")).ToString());
            expressions["KLPwAuP8J1U_lcsrk2FGo4Q_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", "img/ConectaProveedores.ConectaLogo.png")).ToString());
            expressions["K7EVw_h0cyU_gB5PRTaDHjg_Value"] = HtmlEncode(BuiltInFunction.Year (BuiltInFunction.CurrDate ()).ToString());
            expressions["KL34F6a2S006jjH07BFVvRA_Value"] = HtmlEncode(inParami_ApplicationName.ToString());

            var condition_K8bxNX08C2E6XBJD1z_knrQ_ = (inParami_Environment=="PROD");
            expressions["K8bxNX08C2E6XBJD1z_knrQ_"] = condition_K8bxNX08C2E6XBJD1z_knrQ_;
            if (condition_K8bxNX08C2E6XBJD1z_knrQ_) {
            } else {

            var condition_K_r71ghPGgUq8rq_7dpsVAw_ = (inParami_Environment=="DEV");
            expressions["K_r71ghPGgUq8rq_7dpsVAw_"] = condition_K_r71ghPGgUq8rq_7dpsVAw_;
            if (condition_K_r71ghPGgUq8rq_7dpsVAw_) {
            } else {

            var condition_KGQapOE0j_kuPRU7ZnKxuVA_ = (inParami_Environment=="QA");
            expressions["KGQapOE0j_kuPRU7ZnKxuVA_"] = condition_KGQapOE0j_kuPRU7ZnKxuVA_;
            if (condition_KGQapOE0j_kuPRU7ZnKxuVA_) {
            } else {
            }

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
