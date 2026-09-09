using System.Web;
using OutSystems.Application.Abstractions.Emails;
using OutSystems.Application.Emails;
using OutSystems.Application.Core.Email;
using OutSystems.Application.Models.Emails;
using OutSystems.ObjectKeys;
using IterativeTemplateData = System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>>;
using TemplateData = System.Collections.Generic.Dictionary<string, object>;

namespace ssConectaProveedores.Flows.Flowh_OrderDistribution_Emails {

    public class h_OrderDistribution_Emails_OrderChangeNotification : EmailScreen {

        public h_OrderDistribution_Emails_OrderChangeNotification(
            ISettingsProvider settingsProvider,
            IApplicationLogger applicationLogger,
            ICssFlatteningService cssFlatteningService) : base(settingsProvider, applicationLogger, cssFlatteningService) { }

        private static string inlineCss;

        

        private static string _template;
        internal virtual string Template {
            get { return _template ?? (_template = GetTemplateContent("h_OrderDistribution_Emails.OrderChangeNotification.html.resources")); }
        }

        protected static readonly IEnumerable<string> CssFiles = new List<string> {
"css/ConectaProveedores.EmailTheme.css",
"css/ConectaProveedores.h_OrderDistribution_Emails.OrderChangeNotification.css",
"css/ConectaProveedores.EmailTheme.extra.css",

        };

        public async Task<string> GetEmailContentAsync(IRequestContext requestContext, string inParami_ApplicationName,string inParami_UserName,string inParami_Environment,string inParami_OrderNumber,string inParamRealEmailList,string inParamRealEmailCCList,string inParami_CancelationMotive, CancellationToken cancellationToken) {
            if (string.IsNullOrEmpty(inlineCss)) {
                inlineCss = await GetInlineStyleSheetIncludeAsync(CssFiles, cancellationToken);
            }
            binaryImages = new Dictionary<string, Image>();
            var expressions = new TemplateData();

            expressions.Add("STYLE", inlineCss);
            expressions.Add("v3_Style", MergeStyles("text-align: right;"));
            expressions.Add("v8_Style", MergeStyles("text-align: left;"));
            expressions.Add("v11_Style", MergeStyles("color: #ae0000; font-size: 16px;"));
            expressions.Add("v17_Style", MergeStyles("margin-left: 0"));
            expressions.Add("v20_Style", MergeStyles("margin-left: 0px"));
            expressions["KJGQAZPwDMEqUI_utmsJRQw_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", "img/ConectaProveedores.Logo.jpg")).ToString());
            expressions["KHqrmrj3c80ixZHMJpyLJeQ_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["Ka6Ni2D0Ut0Cru6CrcASkPg_Value"] = HtmlEncode((("Está recibiendo este correo electrónico porque el pedido número "+inParami_OrderNumber)+" ha sido modificado y, por esa razón, es necesario que el área de Cuentas por Pagar y Egresos vuelva a realizar el análisis correspondiente.").ToString());
            expressions["K_LcH_e4HdU__vj6jTpCPyA_Value"] = HtmlEncode(("Por favor, accede a la plataforma"+" ").ToString());
            expressions["KQx_EoGz54UyWLGuMJZmtSA_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", (((((string)AppUtils.SiteProperties[SitePropertiesModel.spCurrentDomain])))+"ConectaProveedores/"))).ToString());
            expressions["KcRkHNhhqf0uoOVhrZGsJkQ_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["KTLRgKCLlZUumFQkwZVaByg_Value"] = HtmlEncode(BuiltInFunction.Year (BuiltInFunction.CurrDate ()).ToString());
            expressions["KxAtKK3mU3ES8RyIjH9W0OA_Value"] = HtmlEncode(inParami_ApplicationName.ToString());

            var condition_KCmecIeaYjE6N1ZyqXf4wFA_ = (inParami_Environment=="PROD");
            expressions["KCmecIeaYjE6N1ZyqXf4wFA_"] = condition_KCmecIeaYjE6N1ZyqXf4wFA_;
            if (condition_KCmecIeaYjE6N1ZyqXf4wFA_) {
            } else {

            var condition_KOU_WEuxnZE6wz10SS92tNg_ = (inParami_Environment=="DEV");
            expressions["KOU_WEuxnZE6wz10SS92tNg_"] = condition_KOU_WEuxnZE6wz10SS92tNg_;
            if (condition_KOU_WEuxnZE6wz10SS92tNg_) {
            } else {

            var condition_KI_v7Z9zRPEGjSJoYpmuY1w_ = (inParami_Environment=="QA");
            expressions["KI_v7Z9zRPEGjSJoYpmuY1w_"] = condition_KI_v7Z9zRPEGjSJoYpmuY1w_;
            if (condition_KI_v7Z9zRPEGjSJoYpmuY1w_) {
            } else {
            }

            }

            }


            var condition_KOQFe1u_xwUSwvKdgT4lhmA_ = (inParami_UserName!="");
            expressions["KOQFe1u_xwUSwvKdgT4lhmA_"] = condition_KOQFe1u_xwUSwvKdgT4lhmA_;
            if (condition_KOQFe1u_xwUSwvKdgT4lhmA_) {
            expressions["KFVzUgKYsE0uSmBv0rvcpYg_Value"] = HtmlEncode((("Hola "+inParami_UserName)+"!").ToString());
            } else {
            }


            var condition_KJwYQfNeXNESap_GzdBI8iQ_ = (inParami_CancelationMotive!="");
            expressions["KJwYQfNeXNESap_GzdBI8iQ_"] = condition_KJwYQfNeXNESap_GzdBI8iQ_;
            if (condition_KJwYQfNeXNESap_GzdBI8iQ_) {
            expressions["KvLNv5EkXGk_BzGSKeemDsw_Value"] = HtmlEncode(inParami_CancelationMotive.ToString());
            } else {
            }


            var condition_KpGZeEy8QXEK_9AWNm6XJCA_ = (inParami_Environment=="PROD");
            expressions["KpGZeEy8QXEK_9AWNm6XJCA_"] = condition_KpGZeEy8QXEK_9AWNm6XJCA_;
            if (condition_KpGZeEy8QXEK_9AWNm6XJCA_) {
            } else {

            var condition_KmgjMVSLVnEmM3ZoJOdTpRw_ = (inParamRealEmailList!="");
            expressions["KmgjMVSLVnEmM3ZoJOdTpRw_"] = condition_KmgjMVSLVnEmM3ZoJOdTpRw_;
            if (condition_KmgjMVSLVnEmM3ZoJOdTpRw_) {
            expressions["KHUhbGLTc_Eeg3Yc2X3dvhA_Value"] = HtmlEncode(("Se enviará a: "+inParamRealEmailList).ToString());
            } else {
            }


            var condition_KbRvfxJ2ajEiNpFS0qrOrlA_ = (inParamRealEmailCCList!="");
            expressions["KbRvfxJ2ajEiNpFS0qrOrlA_"] = condition_KbRvfxJ2ajEiNpFS0qrOrlA_;
            if (condition_KbRvfxJ2ajEiNpFS0qrOrlA_) {
            expressions["KT_2tSitT6kWk1Ji8JK_9dQ_Value"] = HtmlEncode(("En CC: "+inParamRealEmailCCList).ToString());
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
