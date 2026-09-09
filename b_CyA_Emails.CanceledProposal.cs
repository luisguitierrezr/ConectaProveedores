using System.Web;
using OutSystems.Application.Abstractions.Emails;
using OutSystems.Application.Emails;
using OutSystems.Application.Core.Email;
using OutSystems.Application.Models.Emails;
using OutSystems.ObjectKeys;
using IterativeTemplateData = System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>>;
using TemplateData = System.Collections.Generic.Dictionary<string, object>;

namespace ssConectaProveedores.Flows.Flowb_CyA_Emails {

    public class b_CyA_Emails_CanceledProposal : EmailScreen {

        public b_CyA_Emails_CanceledProposal(
            ISettingsProvider settingsProvider,
            IApplicationLogger applicationLogger,
            ICssFlatteningService cssFlatteningService) : base(settingsProvider, applicationLogger, cssFlatteningService) { }

        private static string inlineCss;

        

        private static string _template;
        internal virtual string Template {
            get { return _template ?? (_template = GetTemplateContent("b_CyA_Emails.CanceledProposal.html.resources")); }
        }

        protected static readonly IEnumerable<string> CssFiles = new List<string> {
"css/ConectaProveedores.EmailTheme.css",
"css/ConectaProveedores.b_CyA_Emails.CanceledProposal.css",
"css/ConectaProveedores.EmailTheme.extra.css",

        };

        public async Task<string> GetEmailContentAsync(IRequestContext requestContext, string inParamApplicationName,string inParamProposalNumber,string inParamUserName,string inParamCanceledReason,string inParami_Enviroment,string inParamRealEmailList,string inParamRealEmailCCList,bool inParamIsPROD, CancellationToken cancellationToken) {
            if (string.IsNullOrEmpty(inlineCss)) {
                inlineCss = await GetInlineStyleSheetIncludeAsync(CssFiles, cancellationToken);
            }
            binaryImages = new Dictionary<string, Image>();
            var expressions = new TemplateData();

            expressions.Add("KJDljoDaaTUK27JsoEaVOgA_Subject", HtmlEncode((((((inParami_Enviroment=="DEV")) ? ("(DEV)") : ((((inParami_Enviroment=="QA")) ? ("(QA)") : (""))))+"Comissiones Y Arrendamientos - Cancelación de la Propuesta ")+inParamProposalNumber).ToString()));
            expressions.Add("STYLE", inlineCss);
            expressions.Add("v3_Style", MergeStyles("text-align: right;"));
            expressions.Add("v8_Style", MergeStyles("text-align: left;"));
            expressions.Add("v9_Style", MergeStyles("margin-left: 0"));
            expressions.Add("v11_Style", MergeStyles("color: #ae0000; font-size: 16px;"));
            expressions.Add("v17_Style", MergeStyles("margin-left: 0"));
            expressions.Add("v20_Style", MergeStyles("margin-left: 0px"));
            expressions["KJGQAZPwDMEqUI_utmsJRQw_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", "img/ConectaProveedores.Logo.jpg")).ToString());
            expressions["KIOD0h_rBnk_Ayjz8tFHDpQ_Value"] = HtmlEncode(inParamApplicationName.ToString());
            expressions["KnjRea8Xc3Em90RXOE60VjA_Value"] = HtmlEncode(inParamProposalNumber.ToString());
            expressions["KX6XtH8TI60WD669qANYSpA_Value"] = HtmlEncode(inParamCanceledReason.ToString());
            expressions["KEIPMWSEtm0SCYUgTBvMDcQ_Value"] = HtmlEncode(("Por favor, accede al enlace"+" ").ToString());
            expressions["KdBSyrHa2OkaNVTlDD0acVQ_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", (((((string)AppUtils.SiteProperties[SitePropertiesModel.spCurrentDomain])))+"ConectaProveedores"))).ToString());
            expressions["KKtO1x2ZeK0mkT4wWCigouw_Value"] = HtmlEncode(inParamApplicationName.ToString());
            expressions["KeWRjYixHckyS2GbVaXPCIQ_Value"] = HtmlEncode(BuiltInFunction.Year (BuiltInFunction.CurrDate ()).ToString());
            expressions["KF47m6bHk80G2okgLtH4HHA_Value"] = HtmlEncode(inParamApplicationName.ToString());

            var condition_K0zrOFTjUWUehSmklFLsCnw_ = (inParami_Enviroment=="PROD");
            expressions["K0zrOFTjUWUehSmklFLsCnw_"] = condition_K0zrOFTjUWUehSmklFLsCnw_;
            if (condition_K0zrOFTjUWUehSmklFLsCnw_) {
            } else {

            var condition_KvLXF_xqMmkWrvM1_cmTJ3A_ = (inParami_Enviroment=="DEV");
            expressions["KvLXF_xqMmkWrvM1_cmTJ3A_"] = condition_KvLXF_xqMmkWrvM1_cmTJ3A_;
            if (condition_KvLXF_xqMmkWrvM1_cmTJ3A_) {
            } else {

            var condition_KMI4ACdowd0iJX_XEoZsbyA_ = (inParami_Enviroment=="QA");
            expressions["KMI4ACdowd0iJX_XEoZsbyA_"] = condition_KMI4ACdowd0iJX_XEoZsbyA_;
            if (condition_KMI4ACdowd0iJX_XEoZsbyA_) {
            } else {
            }

            }

            }


            var condition_KMMptt3PF3UKlRvJh7kdqOg_ = (inParamUserName!="");
            expressions["KMMptt3PF3UKlRvJh7kdqOg_"] = condition_KMMptt3PF3UKlRvJh7kdqOg_;
            if (condition_KMMptt3PF3UKlRvJh7kdqOg_) {
            expressions["KynlWF5cJyEiFDQ2mPsQFRA_Value"] = HtmlEncode((((inParamUserName!="")) ? ((("Hola "+inParamUserName)+"!")) : ("Hola!")).ToString());
            } else {
            }


            var condition_K2yJ84E_kckil5_Wy_4XtBQ_ = inParamIsPROD;
            expressions["K2yJ84E_kckil5_Wy_4XtBQ_"] = condition_K2yJ84E_kckil5_Wy_4XtBQ_;
            if (condition_K2yJ84E_kckil5_Wy_4XtBQ_) {
            } else {

            var condition_KuXDvNnl0jkSx_2HWh39sjw_ = (inParamRealEmailList!="");
            expressions["KuXDvNnl0jkSx_2HWh39sjw_"] = condition_KuXDvNnl0jkSx_2HWh39sjw_;
            if (condition_KuXDvNnl0jkSx_2HWh39sjw_) {
            expressions["KuAlpHiuBJ0ymLYB_4CcxQQ_Value"] = HtmlEncode(("Se enviará a: "+inParamRealEmailList).ToString());
            } else {
            }


            var condition_K7EikmuJIC0mkKHTlgrNi_A_ = (inParamRealEmailCCList!="");
            expressions["K7EikmuJIC0mkKHTlgrNi_A_"] = condition_K7EikmuJIC0mkKHTlgrNi_A_;
            if (condition_K7EikmuJIC0mkKHTlgrNi_A_) {
            expressions["KpsYbScNe40_7_rSnwOFgYA_Value"] = HtmlEncode(("En CC: "+inParamRealEmailCCList).ToString());
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
