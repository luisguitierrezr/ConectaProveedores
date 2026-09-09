using System.Web;
using OutSystems.Application.Abstractions.Emails;
using OutSystems.Application.Emails;
using OutSystems.Application.Core.Email;
using OutSystems.Application.Models.Emails;
using OutSystems.ObjectKeys;
using IterativeTemplateData = System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>>;
using TemplateData = System.Collections.Generic.Dictionary<string, object>;

namespace ssConectaProveedores.Flows.Flowd_Inv_Emails {

    public class d_Inv_Emails_AmortizationInvoice : EmailScreen {

        public d_Inv_Emails_AmortizationInvoice(
            ISettingsProvider settingsProvider,
            IApplicationLogger applicationLogger,
            ICssFlatteningService cssFlatteningService) : base(settingsProvider, applicationLogger, cssFlatteningService) { }

        private static string inlineCss;

        

        private static string _template;
        internal virtual string Template {
            get { return _template ?? (_template = GetTemplateContent("d_Inv_Emails.AmortizationInvoice.html.resources")); }
        }

        protected static readonly IEnumerable<string> CssFiles = new List<string> {
"css/ConectaProveedores.EmailTheme.css",
"css/ConectaProveedores.d_Inv_Emails.AmortizationInvoice.css",
"css/ConectaProveedores.EmailTheme.extra.css",

        };

        public async Task<string> GetEmailContentAsync(IRequestContext requestContext, string inParami_ApplicationName,string inParami_InvoiceName,string inParami_UserName,string inParami_Enviroment,string inParamRealEmailList,string inParamRealEmailCCList,bool inParamIsPROD, CancellationToken cancellationToken) {
            if (string.IsNullOrEmpty(inlineCss)) {
                inlineCss = await GetInlineStyleSheetIncludeAsync(CssFiles, cancellationToken);
            }
            binaryImages = new Dictionary<string, Image>();
            var expressions = new TemplateData();

            expressions.Add("Ksaeg11YX_Uy1KZOSfaKbSQ_Subject", HtmlEncode(("Facturas - Amortización de anticipo "+inParami_InvoiceName).ToString()));
            expressions.Add("STYLE", inlineCss);
            expressions.Add("v3_Style", MergeStyles("text-align: right;"));
            expressions.Add("v8_Style", MergeStyles("text-align: left;"));
            expressions.Add("v9_Style", MergeStyles("margin-left: 0"));
            expressions.Add("v15_Style", MergeStyles("margin-left: 0"));
            expressions.Add("v18_Style", MergeStyles("margin-left: 0px"));
            expressions["KJGQAZPwDMEqUI_utmsJRQw_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", "img/ConectaProveedores.Logo.jpg")).ToString());
            expressions["KHDrpJ406p02trolnHazGfA_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["KlmuPJ6TYtUiyq26__LGCRQ_Value"] = HtmlEncode(inParami_InvoiceName.ToString());
            expressions["KKUb6lf6kPEStYlctVDdBQQ_Value"] = HtmlEncode(("Por favor, accede al enlace"+" ").ToString());
            expressions["KKgBF6cLShkiPL7ZYqQsBMA_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", (((((string)AppUtils.SiteProperties[SitePropertiesModel.spCurrentDomain])))+"ConectaProveedores"))).ToString());
            expressions["KOAtvBVV7MEyoSBuwj_LJtQ_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["KrfSxvx4FgUa0XfmwoFremQ_Value"] = HtmlEncode(BuiltInFunction.Year (BuiltInFunction.CurrDate ()).ToString());
            expressions["Kn7fQBsE25UaYA8wXp__1IQ_Value"] = HtmlEncode(inParami_ApplicationName.ToString());

            var condition_KzCgzSIAqFU_lrsaYv8f0Ww_ = (inParami_Enviroment=="PROD");
            expressions["KzCgzSIAqFU_lrsaYv8f0Ww_"] = condition_KzCgzSIAqFU_lrsaYv8f0Ww_;
            if (condition_KzCgzSIAqFU_lrsaYv8f0Ww_) {
            } else {

            var condition_K4rQ93V9_iEqWqr8DbNALoA_ = (inParami_Enviroment=="DEV");
            expressions["K4rQ93V9_iEqWqr8DbNALoA_"] = condition_K4rQ93V9_iEqWqr8DbNALoA_;
            if (condition_K4rQ93V9_iEqWqr8DbNALoA_) {
            } else {

            var condition_K44tifQ6vcEukfK6TjOa9vg_ = (inParami_Enviroment=="QA");
            expressions["K44tifQ6vcEukfK6TjOa9vg_"] = condition_K44tifQ6vcEukfK6TjOa9vg_;
            if (condition_K44tifQ6vcEukfK6TjOa9vg_) {
            } else {
            }

            }

            }


            var condition_K3umAarZo5USYQk7LV_h4iQ_ = (inParami_UserName!="");
            expressions["K3umAarZo5USYQk7LV_h4iQ_"] = condition_K3umAarZo5USYQk7LV_h4iQ_;
            if (condition_K3umAarZo5USYQk7LV_h4iQ_) {
            expressions["KQcQaJDZSw0OE5P4c6G0b1w_Value"] = HtmlEncode((("Hola "+inParami_UserName)+"!").ToString());
            } else {
            }


            var condition_KcOag9oV7z0CDrB6pc8bfFA_ = inParamIsPROD;
            expressions["KcOag9oV7z0CDrB6pc8bfFA_"] = condition_KcOag9oV7z0CDrB6pc8bfFA_;
            if (condition_KcOag9oV7z0CDrB6pc8bfFA_) {
            } else {

            var condition_K0k0OsgYLrEKUOYn22_Nk9w_ = (inParamRealEmailList!="");
            expressions["K0k0OsgYLrEKUOYn22_Nk9w_"] = condition_K0k0OsgYLrEKUOYn22_Nk9w_;
            if (condition_K0k0OsgYLrEKUOYn22_Nk9w_) {
            expressions["KprfLDVkzt0WY582zpvHZIQ_Value"] = HtmlEncode(("Se enviará a: "+inParamRealEmailList).ToString());
            } else {
            }


            var condition_KwN8ae7YBBkKBHiOgPIF2WA_ = (inParamRealEmailCCList!="");
            expressions["KwN8ae7YBBkKBHiOgPIF2WA_"] = condition_KwN8ae7YBBkKBHiOgPIF2WA_;
            if (condition_KwN8ae7YBBkKBHiOgPIF2WA_) {
            expressions["K80LfGiWRh02uztjIAzV_gg_Value"] = HtmlEncode(("En CC: "+inParamRealEmailCCList).ToString());
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
