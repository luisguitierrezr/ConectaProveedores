using System.Web;
using OutSystems.Application.Abstractions.Emails;
using OutSystems.Application.Emails;
using OutSystems.Application.Core.Email;
using OutSystems.Application.Models.Emails;
using OutSystems.ObjectKeys;
using IterativeTemplateData = System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>>;
using TemplateData = System.Collections.Generic.Dictionary<string, object>;

namespace ssConectaProveedores.Flows.Flowa_Emails {

    public class a_Emails_ReassignmentNotifyTargetUser : EmailScreen {

        public a_Emails_ReassignmentNotifyTargetUser(
            ISettingsProvider settingsProvider,
            IApplicationLogger applicationLogger,
            ICssFlatteningService cssFlatteningService) : base(settingsProvider, applicationLogger, cssFlatteningService) { }

        private static string inlineCss;

        

        private static string _template;
        internal virtual string Template {
            get { return _template ?? (_template = GetTemplateContent("a_Emails.ReassignmentNotifyTargetUser.html.resources")); }
        }

        protected static readonly IEnumerable<string> CssFiles = new List<string> {
"css/ConectaProveedores.EmailTheme.css",
"css/ConectaProveedores.a_Emails.ReassignmentNotifyTargetUser.css",
"css/ConectaProveedores.EmailTheme.extra.css",

        };

        public async Task<string> GetEmailContentAsync(IRequestContext requestContext, string inParami_ApplicationName,string inParami_UserName,string inParami_Environment,string inParami_CreatedByUsername,string inParami_ReqInvList,string inParamCustomerName,string inParamCustomerEmail, CancellationToken cancellationToken) {
            if (string.IsNullOrEmpty(inlineCss)) {
                inlineCss = await GetInlineStyleSheetIncludeAsync(CssFiles, cancellationToken);
            }
            binaryImages = new Dictionary<string, Image>();
            var expressions = new TemplateData();

            expressions.Add("STYLE", inlineCss);
            expressions.Add("v3_Style", MergeStyles("text-align: right;"));
            expressions.Add("v8_Style", MergeStyles("text-align: left;"));
            expressions.Add("v15_Style", MergeStyles("margin-left: 0"));
            expressions.Add("v18_Style", MergeStyles("margin-left: 0px"));
            expressions["KJGQAZPwDMEqUI_utmsJRQw_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", "img/ConectaProveedores.Logo.jpg")).ToString());
            expressions["K6I8Z7sLL3UygspOkMFBtfg_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["K_4lw5FGkjk_iSfrfUpwcXw_Value"] = HtmlEncode(inParami_ReqInvList.ToString());
            expressions["KS_PGkdovh0iJFvaVd_0ctg_Value"] = HtmlEncode(("Por favor, accede al enlace"+" ").ToString());
            expressions["KjgNd_ufVhkaL9erpHBPCpg_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", (((((string)AppUtils.SiteProperties[SitePropertiesModel.spCurrentDomain])))+"ConectaProveedores/"))).ToString());
            expressions["K62szlKQwZ0SW4_yT_5BKnQ_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["K7FEe8dqPlEWf6xe_PH6a_Q_Value"] = HtmlEncode(BuiltInFunction.Year (BuiltInFunction.CurrDate ()).ToString());
            expressions["KzG_sTqtl0E2pofA_Z5I6eQ_Value"] = HtmlEncode(inParami_ApplicationName.ToString());

            var condition_KsbDWtEWlBEOPMhkTkhNQAw_ = (inParami_Environment=="PROD");
            expressions["KsbDWtEWlBEOPMhkTkhNQAw_"] = condition_KsbDWtEWlBEOPMhkTkhNQAw_;
            if (condition_KsbDWtEWlBEOPMhkTkhNQAw_) {
            } else {

            var condition_KBUXWzx5_5USg_CM0_nWfhQ_ = (inParami_Environment=="DEV");
            expressions["KBUXWzx5_5USg_CM0_nWfhQ_"] = condition_KBUXWzx5_5USg_CM0_nWfhQ_;
            if (condition_KBUXWzx5_5USg_CM0_nWfhQ_) {
            } else {

            var condition_KNu5PPIjI3kOZ3c43qXPMiA_ = (inParami_Environment=="QA");
            expressions["KNu5PPIjI3kOZ3c43qXPMiA_"] = condition_KNu5PPIjI3kOZ3c43qXPMiA_;
            if (condition_KNu5PPIjI3kOZ3c43qXPMiA_) {
            } else {
            }

            }

            }


            var condition_Kxl2t23o1BUSfFchFC3wicw_ = (inParami_UserName!="");
            expressions["Kxl2t23o1BUSfFchFC3wicw_"] = condition_Kxl2t23o1BUSfFchFC3wicw_;
            if (condition_Kxl2t23o1BUSfFchFC3wicw_) {
            expressions["KTv2FUmH7XU6SH9olKZldkQ_Value"] = HtmlEncode((("Hola "+inParami_UserName)+"!").ToString());
            } else {
            }


            var condition_KNUuveRXqPUGrRkBly5fgpg_ = (inParami_Environment=="PROD");
            expressions["KNUuveRXqPUGrRkBly5fgpg_"] = condition_KNUuveRXqPUGrRkBly5fgpg_;
            if (condition_KNUuveRXqPUGrRkBly5fgpg_) {
            } else {
            expressions["K5ZEjcy87qEGRFXCmbBNgoA_Value"] = HtmlEncode(((("Se enviará a: "+inParamCustomerEmail)+" / ")+(((inParamCustomerName!="")) ? (inParamCustomerName) : ("Nome no encontrado o vacio"))).ToString());
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
