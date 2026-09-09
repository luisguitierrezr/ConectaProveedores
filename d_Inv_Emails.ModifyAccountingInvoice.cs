using System.Web;
using OutSystems.Application.Abstractions.Emails;
using OutSystems.Application.Emails;
using OutSystems.Application.Core.Email;
using OutSystems.Application.Models.Emails;
using OutSystems.ObjectKeys;
using IterativeTemplateData = System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>>;
using TemplateData = System.Collections.Generic.Dictionary<string, object>;

namespace ssConectaProveedores.Flows.Flowd_Inv_Emails {

    public class d_Inv_Emails_ModifyAccountingInvoice : EmailScreen {

        public d_Inv_Emails_ModifyAccountingInvoice(
            ISettingsProvider settingsProvider,
            IApplicationLogger applicationLogger,
            ICssFlatteningService cssFlatteningService) : base(settingsProvider, applicationLogger, cssFlatteningService) { }

        private static string inlineCss;

        

        private static string _template;
        internal virtual string Template {
            get { return _template ?? (_template = GetTemplateContent("d_Inv_Emails.ModifyAccountingInvoice.html.resources")); }
        }

        protected static readonly IEnumerable<string> CssFiles = new List<string> {
"css/ConectaProveedores.EmailTheme.css",
"css/ConectaProveedores.d_Inv_Emails.ModifyAccountingInvoice.css",
"css/ConectaProveedores.EmailTheme.extra.css",

        };

        public async Task<string> GetEmailContentAsync(IRequestContext requestContext, string inParamApplicationName,string inParami_InvoiceName,string inParami_UserName,string inParami_ModifyReason,string inParami_Enviroment,string inParami_UserNameRequestModification,string inParamRealEmailList,string inParamRealEmailCCList,bool inParamIsPROD, CancellationToken cancellationToken) {
            if (string.IsNullOrEmpty(inlineCss)) {
                inlineCss = await GetInlineStyleSheetIncludeAsync(CssFiles, cancellationToken);
            }
            binaryImages = new Dictionary<string, Image>();
            var expressions = new TemplateData();

            expressions.Add("K0Oy2f_Eb7kSb2D8wfc2sKg_Subject", HtmlEncode(("Facturas - Pedido de Modificación de la Factura "+inParami_InvoiceName).ToString()));
            expressions.Add("STYLE", inlineCss);
            expressions.Add("v3_Style", MergeStyles("text-align: right;"));
            expressions.Add("v8_Style", MergeStyles("text-align: left;"));
            expressions.Add("v9_Style", MergeStyles("margin-left: 0"));
            expressions.Add("v13_Style", MergeStyles("color: #ae0000; font-size: 16px;"));
            expressions.Add("v19_Style", MergeStyles("margin-left: 0"));
            expressions.Add("v22_Style", MergeStyles("margin-left: 0px"));
            expressions["KJGQAZPwDMEqUI_utmsJRQw_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", "img/ConectaProveedores.Logo.jpg")).ToString());
            expressions["KmePrHdBcOUS3sC0rNZELIw_Value"] = HtmlEncode(inParamApplicationName.ToString());
            expressions["K8Q3OqhjND062z7bxgm6CLw_Value"] = HtmlEncode(inParami_InvoiceName.ToString());
            expressions["Kwf0TTqix1E2ghiScw1UmpQ_Value"] = HtmlEncode(inParami_UserNameRequestModification.ToString());
            expressions["Kr0uoo4kb2EeaGK8NLpI_WQ_Value"] = HtmlEncode(inParami_ModifyReason.ToString());
            expressions["KZ1nUb9spZk20pqcQB7qkbQ_Value"] = HtmlEncode(("Por favor, accede al enlace"+" ").ToString());
            expressions["KNqYE7D1l_kmxvw__owXb0A_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", (((((string)AppUtils.SiteProperties[SitePropertiesModel.spCurrentDomain])))+"ConectaProveedores"))).ToString());
            expressions["KpDjIBTF5L0ifAGp9xhXOcA_Value"] = HtmlEncode(inParamApplicationName.ToString());
            expressions["KD1uNzNr4p0CFKYYHcor_9Q_Value"] = HtmlEncode(BuiltInFunction.Year (BuiltInFunction.CurrDate ()).ToString());
            expressions["KvSbJW_KxTUeZpN8cVHp9tw_Value"] = HtmlEncode(inParamApplicationName.ToString());

            var condition_KeL56NsoBTEWTOvMwUyS1_Q_ = (inParami_Enviroment=="PROD");
            expressions["KeL56NsoBTEWTOvMwUyS1_Q_"] = condition_KeL56NsoBTEWTOvMwUyS1_Q_;
            if (condition_KeL56NsoBTEWTOvMwUyS1_Q_) {
            } else {

            var condition_K4f6SBOTIpkaPZi8DMi0YMw_ = (inParami_Enviroment=="DEV");
            expressions["K4f6SBOTIpkaPZi8DMi0YMw_"] = condition_K4f6SBOTIpkaPZi8DMi0YMw_;
            if (condition_K4f6SBOTIpkaPZi8DMi0YMw_) {
            } else {

            var condition_KZOKY8VpwpkiKAMKcxCmciw_ = (inParami_Enviroment=="QA");
            expressions["KZOKY8VpwpkiKAMKcxCmciw_"] = condition_KZOKY8VpwpkiKAMKcxCmciw_;
            if (condition_KZOKY8VpwpkiKAMKcxCmciw_) {
            } else {
            }

            }

            }


            var condition_KyP9sV923k0Kw2YJaKibMSQ_ = (inParami_UserName!="");
            expressions["KyP9sV923k0Kw2YJaKibMSQ_"] = condition_KyP9sV923k0Kw2YJaKibMSQ_;
            if (condition_KyP9sV923k0Kw2YJaKibMSQ_) {
            expressions["Kao6ZNxjMhkC2rW1TeJ77TA_Value"] = HtmlEncode((("Hola "+inParami_UserName)+"!").ToString());
            } else {
            }


            var condition_KWL_UGm40TESQba9xO7shJg_ = inParamIsPROD;
            expressions["KWL_UGm40TESQba9xO7shJg_"] = condition_KWL_UGm40TESQba9xO7shJg_;
            if (condition_KWL_UGm40TESQba9xO7shJg_) {
            } else {

            var condition_KALddgEzA7kiomqCOve_vvw_ = (inParamRealEmailList!="");
            expressions["KALddgEzA7kiomqCOve_vvw_"] = condition_KALddgEzA7kiomqCOve_vvw_;
            if (condition_KALddgEzA7kiomqCOve_vvw_) {
            expressions["KztKqcmGgTEW1kUb8YU_hTQ_Value"] = HtmlEncode(("Se enviará a: "+inParamRealEmailList).ToString());
            } else {
            }


            var condition_KBro_KNOQqU_ZpZX03w_l9A_ = (inParamRealEmailCCList!="");
            expressions["KBro_KNOQqU_ZpZX03w_l9A_"] = condition_KBro_KNOQqU_ZpZX03w_l9A_;
            if (condition_KBro_KNOQqU_ZpZX03w_l9A_) {
            expressions["KhE3_5JQtrUyFNyzLj47pBA_Value"] = HtmlEncode(("En CC: "+inParamRealEmailCCList).ToString());
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
