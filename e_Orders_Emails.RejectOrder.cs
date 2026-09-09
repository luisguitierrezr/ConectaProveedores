using System.Web;
using OutSystems.Application.Abstractions.Emails;
using OutSystems.Application.Emails;
using OutSystems.Application.Core.Email;
using OutSystems.Application.Models.Emails;
using OutSystems.ObjectKeys;
using IterativeTemplateData = System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>>;
using TemplateData = System.Collections.Generic.Dictionary<string, object>;

namespace ssConectaProveedores.Flows.Flowe_Orders_Emails {

    public class e_Orders_Emails_RejectOrder : EmailScreen {

        public e_Orders_Emails_RejectOrder(
            ISettingsProvider settingsProvider,
            IApplicationLogger applicationLogger,
            ICssFlatteningService cssFlatteningService) : base(settingsProvider, applicationLogger, cssFlatteningService) { }

        private static string inlineCss;

        

        private static string _template;
        internal virtual string Template {
            get { return _template ?? (_template = GetTemplateContent("e_Orders_Emails.RejectOrder.html.resources")); }
        }

        protected static readonly IEnumerable<string> CssFiles = new List<string> {
"css/ConectaProveedores.EmailTheme.css",
"css/ConectaProveedores.e_Orders_Emails.RejectOrder.css",
"css/ConectaProveedores.EmailTheme.extra.css",

        };

        public async Task<string> GetEmailContentAsync(IRequestContext requestContext, string inParami_ApplicationName,string inParami_Environment,string inParami_OrderNumber,string inParami_UserName,string inParami_RealEmailList,string inParami_RealEmailCCList,bool inParami_IsPROD, CancellationToken cancellationToken) {
            if (string.IsNullOrEmpty(inlineCss)) {
                inlineCss = await GetInlineStyleSheetIncludeAsync(CssFiles, cancellationToken);
            }
            binaryImages = new Dictionary<string, Image>();
            var expressions = new TemplateData();

            expressions.Add("KEvon_MLkMU2VZ5etgtjBzA_Subject", HtmlEncode(("Pedidos - Rechazo del Pedido "+inParami_OrderNumber).ToString()));
            expressions.Add("STYLE", inlineCss);
            expressions.Add("v3_Style", MergeStyles("text-align: right;"));
            expressions.Add("v8_Style", MergeStyles("text-align: left;"));
            expressions.Add("v9_Style", MergeStyles("margin-left: 0"));
            expressions.Add("v15_Style", MergeStyles("margin-left: 0"));
            expressions.Add("v18_Style", MergeStyles("margin-left: 0px"));
            expressions["KJGQAZPwDMEqUI_utmsJRQw_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", "img/ConectaProveedores.Logo.jpg")).ToString());
            expressions["KSLtPGbtZeEWi_QFNShJw5g_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["KIEco5nZb30ajGXWXx94K6w_Value"] = HtmlEncode(inParami_OrderNumber.ToString());
            expressions["KEmvG84F_wkS9dm5_Yd7MCA_Value"] = HtmlEncode(("Por favor, accede al enlace"+" ").ToString());
            expressions["Kq9B8RwM1fk_I1ItBHkfYKg_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", (((((string)AppUtils.SiteProperties[SitePropertiesModel.spCurrentDomain])))+"ConectaProveedores"))).ToString());
            expressions["KiBvtp0h7hkS7_XCP9_b4AA_Value"] = HtmlEncode(inParami_ApplicationName.ToString());
            expressions["KGiBQuGeNUEioJ81IF_gk2g_Value"] = HtmlEncode(BuiltInFunction.Year (BuiltInFunction.CurrDate ()).ToString());
            expressions["K_a4C6rHi2kq663ErEQhp0w_Value"] = HtmlEncode(inParami_ApplicationName.ToString());

            var condition_KXI9NRSQfJUWvdanxAZVFrQ_ = (inParami_Environment=="PROD");
            expressions["KXI9NRSQfJUWvdanxAZVFrQ_"] = condition_KXI9NRSQfJUWvdanxAZVFrQ_;
            if (condition_KXI9NRSQfJUWvdanxAZVFrQ_) {
            } else {

            var condition_KAOhIltel_0W_WmcnhLkCgg_ = (inParami_Environment=="DEV");
            expressions["KAOhIltel_0W_WmcnhLkCgg_"] = condition_KAOhIltel_0W_WmcnhLkCgg_;
            if (condition_KAOhIltel_0W_WmcnhLkCgg_) {
            } else {

            var condition_K_E53uR3ClUCG4gxipQ_1Lg_ = (inParami_Environment=="QA");
            expressions["K_E53uR3ClUCG4gxipQ_1Lg_"] = condition_K_E53uR3ClUCG4gxipQ_1Lg_;
            if (condition_K_E53uR3ClUCG4gxipQ_1Lg_) {
            } else {
            }

            }

            }


            var condition_KutpzhGPu1EqLNnvOa8bY1Q_ = (inParami_UserName!="");
            expressions["KutpzhGPu1EqLNnvOa8bY1Q_"] = condition_KutpzhGPu1EqLNnvOa8bY1Q_;
            if (condition_KutpzhGPu1EqLNnvOa8bY1Q_) {
            expressions["KvOe5nkHkGkKuV7_FSxqprw_Value"] = HtmlEncode((("Hola "+inParami_UserName)+"!").ToString());
            } else {
            }


            var condition_KoPbtikXBp0mNTR7Y_9PPsw_ = inParami_IsPROD;
            expressions["KoPbtikXBp0mNTR7Y_9PPsw_"] = condition_KoPbtikXBp0mNTR7Y_9PPsw_;
            if (condition_KoPbtikXBp0mNTR7Y_9PPsw_) {
            } else {

            var condition_K1Es_aTdSsUq6etE71ceSBQ_ = (inParami_RealEmailList!="");
            expressions["K1Es_aTdSsUq6etE71ceSBQ_"] = condition_K1Es_aTdSsUq6etE71ceSBQ_;
            if (condition_K1Es_aTdSsUq6etE71ceSBQ_) {
            expressions["KUtG0lb1En0Wr_NXW39OmmQ_Value"] = HtmlEncode(("Se enviará a: "+inParami_RealEmailList).ToString());
            } else {
            }


            var condition_KxdpqPMiPZEukXzh6pfqoyg_ = (inParami_RealEmailCCList!="");
            expressions["KxdpqPMiPZEukXzh6pfqoyg_"] = condition_KxdpqPMiPZEukXzh6pfqoyg_;
            if (condition_KxdpqPMiPZEukXzh6pfqoyg_) {
            expressions["K3MBen0WPC0mOwhA_PTZRnQ_Value"] = HtmlEncode(("En CC: "+inParami_RealEmailCCList).ToString());
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
