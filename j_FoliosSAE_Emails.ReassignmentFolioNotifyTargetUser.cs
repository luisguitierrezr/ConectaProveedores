using System.Web;
using OutSystems.Application.Abstractions.Emails;
using OutSystems.Application.Emails;
using OutSystems.Application.Core.Email;
using OutSystems.Application.Models.Emails;
using OutSystems.ObjectKeys;
using IterativeTemplateData = System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>>;
using TemplateData = System.Collections.Generic.Dictionary<string, object>;

namespace ssConectaProveedores.Flows.Flowj_FoliosSAE_Emails {

    public class j_FoliosSAE_Emails_ReassignmentFolioNotifyTargetUser : EmailScreen {

        public j_FoliosSAE_Emails_ReassignmentFolioNotifyTargetUser(
            ISettingsProvider settingsProvider,
            IApplicationLogger applicationLogger,
            ICssFlatteningService cssFlatteningService) : base(settingsProvider, applicationLogger, cssFlatteningService) { }

        private static string inlineCss;

        

        private static string _template;
        internal virtual string Template {
            get { return _template ?? (_template = GetTemplateContent("j_FoliosSAE_Emails.ReassignmentFolioNotifyTargetUser.html.resources")); }
        }

        protected static readonly IEnumerable<string> CssFiles = new List<string> {
"css/ConectaProveedores.EmailTheme.css",
"css/ConectaProveedores.j_FoliosSAE_Emails.ReassignmentFolioNotifyTargetUser.css",
"css/ConectaProveedores.EmailTheme.extra.css",

        };

        public async Task<string> GetEmailContentAsync(IRequestContext requestContext, string inParami_ApplicationName,string inParami_UserName,string inParami_Environment,string inParami_CreatedByUsername,string inParami_FolioList,string inParamCustomerName,string inParamCustomerEmail,string inParami_Motive, CancellationToken cancellationToken) {
            if (string.IsNullOrEmpty(inlineCss)) {
                inlineCss = await GetInlineStyleSheetIncludeAsync(CssFiles, cancellationToken);
            }
            binaryImages = new Dictionary<string, Image>();
            var expressions = new TemplateData();

            expressions.Add("STYLE", inlineCss);
            expressions.Add("v3_Style", MergeStyles("text-align: right;"));
            expressions.Add("v8_Style", MergeStyles("text-align: left;"));
            expressions.Add("v13_Style", MergeStyles("color: #ae0000; font-size: 16px;"));
            expressions.Add("v19_Style", MergeStyles("margin-left: 0"));
            expressions.Add("v22_Style", MergeStyles("margin-left: 0px"));
            expressions["KJGQAZPwDMEqUI_utmsJRQw_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", "img/ConectaProveedores.Logo.jpg")).ToString());
            expressions["K2NfGF4bjSE_pqKKggeCDIA_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["KPzl2mNUlc0qjtJTcb2I_Cg_Value"] = HtmlEncode(inParami_FolioList.ToString());
            expressions["K7EXDu4QzE0GSC0yG47rQuA_Value"] = HtmlEncode(inParami_Motive.ToString());
            expressions["KicPc6E3RGUKLrFZlz3TnZQ_Value"] = HtmlEncode(("Por favor, accede al enlace"+" ").ToString());
            expressions["KDsVd4FeQc0qUpGwDgH9ngw_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", (((((string)AppUtils.SiteProperties[SitePropertiesModel.spCurrentDomain])))+"ConectaProveedores/"))).ToString());
            expressions["KLkmCETBUcUGp2_3BLWhx9g_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["K6vfNsjnpikugssV1zFrv2Q_Value"] = HtmlEncode(BuiltInFunction.Year (BuiltInFunction.CurrDate ()).ToString());
            expressions["KmIJDVI7ezEaTTm3uZ3Amuw_Value"] = HtmlEncode(inParami_ApplicationName.ToString());

            var condition_KigsrG178ik6_1JzWhROg4w_ = (inParami_Environment=="PROD");
            expressions["KigsrG178ik6_1JzWhROg4w_"] = condition_KigsrG178ik6_1JzWhROg4w_;
            if (condition_KigsrG178ik6_1JzWhROg4w_) {
            } else {

            var condition_KNSPtgPkSo029sfMA4Uj8XQ_ = (inParami_Environment=="DEV");
            expressions["KNSPtgPkSo029sfMA4Uj8XQ_"] = condition_KNSPtgPkSo029sfMA4Uj8XQ_;
            if (condition_KNSPtgPkSo029sfMA4Uj8XQ_) {
            } else {

            var condition_Kx7czcqwN_UWU_vDEBxegow_ = (inParami_Environment=="QA");
            expressions["Kx7czcqwN_UWU_vDEBxegow_"] = condition_Kx7czcqwN_UWU_vDEBxegow_;
            if (condition_Kx7czcqwN_UWU_vDEBxegow_) {
            } else {
            }

            }

            }


            var condition_KZwT_Kx_JDkG7VCebjMj0zQ_ = (inParami_UserName!="");
            expressions["KZwT_Kx_JDkG7VCebjMj0zQ_"] = condition_KZwT_Kx_JDkG7VCebjMj0zQ_;
            if (condition_KZwT_Kx_JDkG7VCebjMj0zQ_) {
            expressions["KtwuS8rwn5ku94g82ofIRmg_Value"] = HtmlEncode((("Hola "+inParami_UserName)+"!").ToString());
            } else {
            }


            var condition_KqE8Q8jTHhE2fMRyHXE5_yg_ = (inParami_Environment=="PROD");
            expressions["KqE8Q8jTHhE2fMRyHXE5_yg_"] = condition_KqE8Q8jTHhE2fMRyHXE5_yg_;
            if (condition_KqE8Q8jTHhE2fMRyHXE5_yg_) {
            } else {
            expressions["K_tMgMZ23SUqVf0JMvXtjRw_Value"] = HtmlEncode(((("Se enviará a: "+inParamCustomerEmail)+" / ")+(((inParamCustomerName!="")) ? (inParamCustomerName) : ("Nome no encontrado o vacio"))).ToString());
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
