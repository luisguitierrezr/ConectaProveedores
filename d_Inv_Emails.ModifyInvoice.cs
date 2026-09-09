using System.Web;
using OutSystems.Application.Abstractions.Emails;
using OutSystems.Application.Emails;
using OutSystems.Application.Core.Email;
using OutSystems.Application.Models.Emails;
using OutSystems.ObjectKeys;
using IterativeTemplateData = System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>>;
using TemplateData = System.Collections.Generic.Dictionary<string, object>;

namespace ssConectaProveedores.Flows.Flowd_Inv_Emails {

    public class d_Inv_Emails_ModifyInvoice : EmailScreen {

        public d_Inv_Emails_ModifyInvoice(
            ISettingsProvider settingsProvider,
            IApplicationLogger applicationLogger,
            ICssFlatteningService cssFlatteningService) : base(settingsProvider, applicationLogger, cssFlatteningService) { }

        private static string inlineCss;

        

        private static string _template;
        internal virtual string Template {
            get { return _template ?? (_template = GetTemplateContent("d_Inv_Emails.ModifyInvoice.html.resources")); }
        }

        protected static readonly IEnumerable<string> CssFiles = new List<string> {
"css/ConectaProveedores.EmailTheme.css",
"css/ConectaProveedores.d_Inv_Emails.ModifyInvoice.css",
"css/ConectaProveedores.EmailTheme.extra.css",

        };

        public async Task<string> GetEmailContentAsync(IRequestContext requestContext, string inParamApplicationName,string inParami_InvoiceName,string inParami_UserName,string inParami_ModifyReason,string inParami_Enviroment,string inParami_UserNameRequestModification,string inParamRealEmailList,string inParamRealEmailCCList,bool inParamIsPROD, CancellationToken cancellationToken) {
            if (string.IsNullOrEmpty(inlineCss)) {
                inlineCss = await GetInlineStyleSheetIncludeAsync(CssFiles, cancellationToken);
            }
            binaryImages = new Dictionary<string, Image>();
            var expressions = new TemplateData();

            expressions.Add("K_BzRs5HGwkmdH0oyN5wSTQ_Subject", HtmlEncode(("Facturas - Pedido de Modificación de la Factura "+inParami_InvoiceName).ToString()));
            expressions.Add("STYLE", inlineCss);
            expressions.Add("v3_Style", MergeStyles("text-align: right;"));
            expressions.Add("v8_Style", MergeStyles("text-align: left;"));
            expressions.Add("v9_Style", MergeStyles("margin-left: 0"));
            expressions.Add("v13_Style", MergeStyles("color: #ae0000; font-size: 16px;"));
            expressions.Add("v19_Style", MergeStyles("margin-left: 0"));
            expressions.Add("v22_Style", MergeStyles("margin-left: 0px"));
            expressions["KJGQAZPwDMEqUI_utmsJRQw_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", "img/ConectaProveedores.Logo.jpg")).ToString());
            expressions["KxXALiq85OUyMmccjSK8Gpg_Value"] = HtmlEncode(inParamApplicationName.ToString());
            expressions["KTgvtxxt540euNg5jpoVMCw_Value"] = HtmlEncode(inParami_InvoiceName.ToString());
            expressions["KNEuB2DvDgkCZuXjDQoANbQ_Value"] = HtmlEncode(inParami_UserNameRequestModification.ToString());
            expressions["Kh5samhouZEW8nCKU3ibhfA_Value"] = HtmlEncode(inParami_ModifyReason.ToString());
            expressions["KBKTcPvQZdEeOG_6PBTmVfw_Value"] = HtmlEncode(("Por favor, accede al enlace"+" ").ToString());
            expressions["KHiC95Cen2E_DfvDkDzn4QA_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", (((((string)AppUtils.SiteProperties[SitePropertiesModel.spCurrentDomain])))+"ConectaProveedores"))).ToString());
            expressions["KUXyC2uS4hESSygCe6TQn7A_Value"] = HtmlEncode(inParamApplicationName.ToString());
            expressions["KW8rSsjfMxU6etkkC20DB7g_Value"] = HtmlEncode(BuiltInFunction.Year (BuiltInFunction.CurrDate ()).ToString());
            expressions["KURD06dIAr0SZ5zXdoxVCcg_Value"] = HtmlEncode(inParamApplicationName.ToString());

            var condition_K6Hr6Pu7hbkGjb_yQJ02muQ_ = (inParami_Enviroment=="PROD");
            expressions["K6Hr6Pu7hbkGjb_yQJ02muQ_"] = condition_K6Hr6Pu7hbkGjb_yQJ02muQ_;
            if (condition_K6Hr6Pu7hbkGjb_yQJ02muQ_) {
            } else {

            var condition_K_aNgmWqhLUe8DEqR_FimrQ_ = (inParami_Enviroment=="DEV");
            expressions["K_aNgmWqhLUe8DEqR_FimrQ_"] = condition_K_aNgmWqhLUe8DEqR_FimrQ_;
            if (condition_K_aNgmWqhLUe8DEqR_FimrQ_) {
            } else {

            var condition_KvwGbQ0JX2EWhnvrTT_S_dw_ = (inParami_Enviroment=="QA");
            expressions["KvwGbQ0JX2EWhnvrTT_S_dw_"] = condition_KvwGbQ0JX2EWhnvrTT_S_dw_;
            if (condition_KvwGbQ0JX2EWhnvrTT_S_dw_) {
            } else {
            }

            }

            }


            var condition_KvdtDXsej0EWYRTe9_tlDyA_ = (inParami_UserName!="");
            expressions["KvdtDXsej0EWYRTe9_tlDyA_"] = condition_KvdtDXsej0EWYRTe9_tlDyA_;
            if (condition_KvdtDXsej0EWYRTe9_tlDyA_) {
            expressions["KL_ss_5rDP0SbhuYMu2BL0A_Value"] = HtmlEncode((("Hola "+inParami_UserName)+"!").ToString());
            } else {
            }


            var condition_KadpEFZYRb0O2tORPhXjlLg_ = inParamIsPROD;
            expressions["KadpEFZYRb0O2tORPhXjlLg_"] = condition_KadpEFZYRb0O2tORPhXjlLg_;
            if (condition_KadpEFZYRb0O2tORPhXjlLg_) {
            } else {

            var condition_KIjJzZ6Xc00SwJVABot_TPQ_ = (inParamRealEmailList!="");
            expressions["KIjJzZ6Xc00SwJVABot_TPQ_"] = condition_KIjJzZ6Xc00SwJVABot_TPQ_;
            if (condition_KIjJzZ6Xc00SwJVABot_TPQ_) {
            expressions["Kcp8Iv8V_Ekmk18kUOkHPoQ_Value"] = HtmlEncode(("Se enviará a: "+inParamRealEmailList).ToString());
            } else {
            }


            var condition_K7aXZMYzenEKZXs_JvlDKPQ_ = (inParamRealEmailCCList!="");
            expressions["K7aXZMYzenEKZXs_JvlDKPQ_"] = condition_K7aXZMYzenEKZXs_JvlDKPQ_;
            if (condition_K7aXZMYzenEKZXs_JvlDKPQ_) {
            expressions["KcMuL8rCKAkKM_dBqAVX6MA_Value"] = HtmlEncode(("En CC: "+inParamRealEmailCCList).ToString());
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
