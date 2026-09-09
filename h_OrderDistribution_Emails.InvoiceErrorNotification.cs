using System.Web;
using OutSystems.Application.Abstractions.Emails;
using OutSystems.Application.Emails;
using OutSystems.Application.Core.Email;
using OutSystems.Application.Models.Emails;
using OutSystems.ObjectKeys;
using IterativeTemplateData = System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>>;
using TemplateData = System.Collections.Generic.Dictionary<string, object>;

namespace ssConectaProveedores.Flows.Flowh_OrderDistribution_Emails {

    public class h_OrderDistribution_Emails_InvoiceErrorNotification : EmailScreen {

        public h_OrderDistribution_Emails_InvoiceErrorNotification(
            ISettingsProvider settingsProvider,
            IApplicationLogger applicationLogger,
            ICssFlatteningService cssFlatteningService) : base(settingsProvider, applicationLogger, cssFlatteningService) { }

        private static string inlineCss;

        

        private static string _template;
        internal virtual string Template {
            get { return _template ?? (_template = GetTemplateContent("h_OrderDistribution_Emails.InvoiceErrorNotification.html.resources")); }
        }

        protected static readonly IEnumerable<string> CssFiles = new List<string> {
"css/ConectaProveedores.EmailTheme.css",
"css/ConectaProveedores.h_OrderDistribution_Emails.InvoiceErrorNotification.css",
"css/ConectaProveedores.EmailTheme.extra.css",

        };

        public async Task<string> GetEmailContentAsync(IRequestContext requestContext, string inParami_ApplicationName,string inParami_UserName,string inParami_Environment,string inParamRealEmailList,string inParamRealEmailCCList,string inParami_InvoiceNumber,string inParamReason,bool inParamIsPROD, CancellationToken cancellationToken) {
            if (string.IsNullOrEmpty(inlineCss)) {
                inlineCss = await GetInlineStyleSheetIncludeAsync(CssFiles, cancellationToken);
            }
            binaryImages = new Dictionary<string, Image>();
            var expressions = new TemplateData();

            expressions.Add("STYLE", inlineCss);
            expressions.Add("v3_Style", MergeStyles("text-align: right;"));
            expressions.Add("v8_Style", MergeStyles("text-align: left;"));
            expressions.Add("v14_Style", MergeStyles("margin-left: 0"));
            expressions.Add("v17_Style", MergeStyles("margin-left: 0px"));
            expressions["KJGQAZPwDMEqUI_utmsJRQw_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", "img/ConectaProveedores.Logo.jpg")).ToString());
            expressions["KRoPOszqw30u50qAHjZjcJg_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["KVxQRFA0NVkicy9t_8LLGyA_Value"] = HtmlEncode((((((("Recibe este correo electrónico porque se ha detectado un error en la factura "+inParami_InvoiceNumber)+" durante la contabilización de SAP.")+"\r\n\r\n")+"Respuesta SAP:")+" ")+inParamReason).ToString());
            expressions["Kz_Ginv5UK06HJ2Vephg8LA_Value"] = HtmlEncode(("Por favor, accede a la plataforma"+" ").ToString());
            expressions["KlZbzUhXx4UyafUY7b_ilHg_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", (((((string)AppUtils.SiteProperties[SitePropertiesModel.spCurrentDomain])))+"ConectaProveedores/"))).ToString());
            expressions["Kzv3TgGsQr0OyZw6MNnvM8g_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["K9fW3PknVkkeN2zvUPqU5vA_Value"] = HtmlEncode(BuiltInFunction.Year (BuiltInFunction.CurrDate ()).ToString());
            expressions["K7DNhNBkgm0_6VLvt90wv4A_Value"] = HtmlEncode(inParami_ApplicationName.ToString());

            var condition_K2mVQKe5wr02H56YA0rlWIA_ = (inParami_Environment=="PROD");
            expressions["K2mVQKe5wr02H56YA0rlWIA_"] = condition_K2mVQKe5wr02H56YA0rlWIA_;
            if (condition_K2mVQKe5wr02H56YA0rlWIA_) {
            } else {

            var condition_KlfnUt22sN0K9QO_oEFBFLQ_ = (inParami_Environment=="DEV");
            expressions["KlfnUt22sN0K9QO_oEFBFLQ_"] = condition_KlfnUt22sN0K9QO_oEFBFLQ_;
            if (condition_KlfnUt22sN0K9QO_oEFBFLQ_) {
            } else {

            var condition_KbAPI_sLXjUCHXYWuPytamg_ = (inParami_Environment=="QA");
            expressions["KbAPI_sLXjUCHXYWuPytamg_"] = condition_KbAPI_sLXjUCHXYWuPytamg_;
            if (condition_KbAPI_sLXjUCHXYWuPytamg_) {
            } else {
            }

            }

            }


            var condition_KDabPnB0C0UKCcGtYqrP9nA_ = (inParami_UserName!="");
            expressions["KDabPnB0C0UKCcGtYqrP9nA_"] = condition_KDabPnB0C0UKCcGtYqrP9nA_;
            if (condition_KDabPnB0C0UKCcGtYqrP9nA_) {
            expressions["K8dsPsh3x7EmERXInYC28Kg_Value"] = HtmlEncode((("Hola "+inParami_UserName)+"!").ToString());
            } else {
            }


            var condition_KYA_28zBLkkiLdKaucwGTxQ_ = inParamIsPROD;
            expressions["KYA_28zBLkkiLdKaucwGTxQ_"] = condition_KYA_28zBLkkiLdKaucwGTxQ_;
            if (condition_KYA_28zBLkkiLdKaucwGTxQ_) {
            } else {

            var condition_KAmM2_uUgoEGU6Ylsc7Ujow_ = (inParamRealEmailList!="");
            expressions["KAmM2_uUgoEGU6Ylsc7Ujow_"] = condition_KAmM2_uUgoEGU6Ylsc7Ujow_;
            if (condition_KAmM2_uUgoEGU6Ylsc7Ujow_) {
            expressions["KDspOLsWqKEu1yIkhbbYPWw_Value"] = HtmlEncode(("Se enviará a: "+inParamRealEmailList).ToString());
            } else {
            }


            var condition_KH_rqelvH7EanQo_0XRUAwA_ = (inParamRealEmailCCList!="");
            expressions["KH_rqelvH7EanQo_0XRUAwA_"] = condition_KH_rqelvH7EanQo_0XRUAwA_;
            if (condition_KH_rqelvH7EanQo_0XRUAwA_) {
            expressions["KoEWMnXQm1068QBjlSFBcUQ_Value"] = HtmlEncode(("En CC: "+inParamRealEmailCCList).ToString());
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
