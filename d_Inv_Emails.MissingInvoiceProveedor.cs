using System.Web;
using OutSystems.Application.Abstractions.Emails;
using OutSystems.Application.Emails;
using OutSystems.Application.Core.Email;
using OutSystems.Application.Models.Emails;
using OutSystems.ObjectKeys;
using IterativeTemplateData = System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>>;
using TemplateData = System.Collections.Generic.Dictionary<string, object>;

namespace ssConectaProveedores.Flows.Flowd_Inv_Emails {

    public class d_Inv_Emails_MissingInvoiceProveedor : EmailScreen {

        public d_Inv_Emails_MissingInvoiceProveedor(
            ISettingsProvider settingsProvider,
            IApplicationLogger applicationLogger,
            ICssFlatteningService cssFlatteningService) : base(settingsProvider, applicationLogger, cssFlatteningService) { }

        private static string inlineCss;

        

        private static string _template;
        internal virtual string Template {
            get { return _template ?? (_template = GetTemplateContent("d_Inv_Emails.MissingInvoiceProveedor.html.resources")); }
        }

        protected static readonly IEnumerable<string> CssFiles = new List<string> {
"css/ConectaProveedores.EmailTheme.css",
"css/ConectaProveedores.d_Inv_Emails.MissingInvoiceProveedor.css",
"css/ConectaProveedores.EmailTheme.extra.css",

        };

        public async Task<string> GetEmailContentAsync(IRequestContext requestContext, string inParami_ApplicationName,string inParami_InvoiceName,string inParami_UserName,string inParami_Enviroment,string inParamRealEmailList,string inParamRealEmailCCList,bool inParamIsPROD, CancellationToken cancellationToken) {
            if (string.IsNullOrEmpty(inlineCss)) {
                inlineCss = await GetInlineStyleSheetIncludeAsync(CssFiles, cancellationToken);
            }
            binaryImages = new Dictionary<string, Image>();
            var expressions = new TemplateData();

            expressions.Add("KzHsPdxmq_kKvwDxAFDGLag_Subject", HtmlEncode(("Facturas - Aprobar Factura "+inParami_InvoiceName).ToString()));
            expressions.Add("STYLE", inlineCss);
            expressions.Add("v3_Style", MergeStyles("text-align: right;"));
            expressions.Add("v8_Style", MergeStyles("text-align: left;"));
            expressions.Add("v14_Style", MergeStyles("margin-left: 0"));
            expressions.Add("v17_Style", MergeStyles("margin-left: 0px"));
            expressions["KJGQAZPwDMEqUI_utmsJRQw_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", "img/ConectaProveedores.Logo.jpg")).ToString());
            expressions["KqBKj3keszEK6Uh08H6NOCw_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["KVnT_KzSXK0ap7uuxiY4Fcw_Value"] = HtmlEncode(inParami_InvoiceName.ToString());
            expressions["Khx5UResa0UWT__jhyOqWJg_Value"] = HtmlEncode(("Por favor, accede al enlace"+" ").ToString());
            expressions["Ky0KgUIpcWEWtovSbt3i3iA_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", (((((string)AppUtils.SiteProperties[SitePropertiesModel.spCurrentDomain])))+"ConectaProveedores"))).ToString());
            expressions["K065ApznAJEGaPHWyumXA_w_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["KzeDkCEKee0OFQtlTpLz_nw_Value"] = HtmlEncode(BuiltInFunction.Year (BuiltInFunction.CurrDate ()).ToString());
            expressions["K8nRuUTGkk0ynrcPHXtSlKg_Value"] = HtmlEncode(inParami_ApplicationName.ToString());

            var condition_KUnHAIzvFCUC0v4IjFUZyTQ_ = (inParami_Enviroment=="PROD");
            expressions["KUnHAIzvFCUC0v4IjFUZyTQ_"] = condition_KUnHAIzvFCUC0v4IjFUZyTQ_;
            if (condition_KUnHAIzvFCUC0v4IjFUZyTQ_) {
            } else {

            var condition_Kab44D2SwS02U4YPZRkPJDA_ = (inParami_Enviroment=="DEV");
            expressions["Kab44D2SwS02U4YPZRkPJDA_"] = condition_Kab44D2SwS02U4YPZRkPJDA_;
            if (condition_Kab44D2SwS02U4YPZRkPJDA_) {
            } else {

            var condition_K0ACVMVmpdkqJGrXNzHeDpg_ = (inParami_Enviroment=="QA");
            expressions["K0ACVMVmpdkqJGrXNzHeDpg_"] = condition_K0ACVMVmpdkqJGrXNzHeDpg_;
            if (condition_K0ACVMVmpdkqJGrXNzHeDpg_) {
            } else {
            }

            }

            }


            var condition_KR2zD4qKF3k6X_wkJ7EppMw_ = (inParami_UserName!="");
            expressions["KR2zD4qKF3k6X_wkJ7EppMw_"] = condition_KR2zD4qKF3k6X_wkJ7EppMw_;
            if (condition_KR2zD4qKF3k6X_wkJ7EppMw_) {
            expressions["KrksTjv2NJEKxTVDEh1qBTw_Value"] = HtmlEncode((("Hola "+inParami_UserName)+"!").ToString());
            } else {
            }


            var condition_K1ae9Lf3he0K2IpkbWrMBjA_ = inParamIsPROD;
            expressions["K1ae9Lf3he0K2IpkbWrMBjA_"] = condition_K1ae9Lf3he0K2IpkbWrMBjA_;
            if (condition_K1ae9Lf3he0K2IpkbWrMBjA_) {
            } else {

            var condition_KFpePnsqxtUSdEFZ0m_9Hsg_ = (inParamRealEmailList!="");
            expressions["KFpePnsqxtUSdEFZ0m_9Hsg_"] = condition_KFpePnsqxtUSdEFZ0m_9Hsg_;
            if (condition_KFpePnsqxtUSdEFZ0m_9Hsg_) {
            expressions["KjRXfeCRzPkWuFsJGKQzeXg_Value"] = HtmlEncode(("Se enviará a: "+inParamRealEmailList).ToString());
            } else {
            }


            var condition_KjeQ6FF7ADkWe82l3KV60Rw_ = (inParamRealEmailCCList!="");
            expressions["KjeQ6FF7ADkWe82l3KV60Rw_"] = condition_KjeQ6FF7ADkWe82l3KV60Rw_;
            if (condition_KjeQ6FF7ADkWe82l3KV60Rw_) {
            expressions["KjbAL8WuI1kaPSz44_CObZw_Value"] = HtmlEncode(("En CC: "+inParamRealEmailCCList).ToString());
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
