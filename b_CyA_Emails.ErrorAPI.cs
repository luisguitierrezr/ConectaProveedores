using System.Web;
using OutSystems.Application.Abstractions.Emails;
using OutSystems.Application.Emails;
using OutSystems.Application.Core.Email;
using OutSystems.Application.Models.Emails;
using OutSystems.ObjectKeys;
using IterativeTemplateData = System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>>;
using TemplateData = System.Collections.Generic.Dictionary<string, object>;

namespace ssConectaProveedores.Flows.Flowb_CyA_Emails {

    public class b_CyA_Emails_ErrorAPI : EmailScreen {

        public b_CyA_Emails_ErrorAPI(
            ISettingsProvider settingsProvider,
            IApplicationLogger applicationLogger,
            ICssFlatteningService cssFlatteningService) : base(settingsProvider, applicationLogger, cssFlatteningService) { }

        private static string inlineCss;

        

        private static string _template;
        internal virtual string Template {
            get { return _template ?? (_template = GetTemplateContent("b_CyA_Emails.ErrorAPI.html.resources")); }
        }

        protected static readonly IEnumerable<string> CssFiles = new List<string> {
"css/ConectaProveedores.EmailTheme.css",
"css/ConectaProveedores.b_CyA_Emails.ErrorAPI.css",
"css/ConectaProveedores.EmailTheme.extra.css",

        };

        public async Task<string> GetEmailContentAsync(IRequestContext requestContext, string inParamApplicationName,string inParamFileName,string inParami_Enviroment,string inParamRealEmailList,string inParamRealEmailCCList,bool inParamIsPROD,RL_21421685308149cb9c93dd790730a8ac inParamErrorList, CancellationToken cancellationToken) {
            if (string.IsNullOrEmpty(inlineCss)) {
                inlineCss = await GetInlineStyleSheetIncludeAsync(CssFiles, cancellationToken);
            }
            binaryImages = new Dictionary<string, Image>();
            var expressions = new TemplateData();

            expressions.Add("K9Q6_SyXgj0GdAvr1zc9TAg_Subject", HtmlEncode(((((inParami_Enviroment=="DEV")) ? ("(DEV)") : ((((inParami_Enviroment=="QA")) ? ("(QA)") : (""))))+"Comissiones Y Arrendamientos - ERROR API").ToString()));
            expressions.Add("STYLE", inlineCss);
            expressions.Add("v3_Style", MergeStyles("text-align: right;"));
            expressions.Add("v8_Style", MergeStyles("text-align: left;"));
            expressions.Add("v11_Style", MergeStyles("color: #ae0000; font-size: 16px;"));
            expressions.Add("v13_Style", MergeStyles("font-size: 16px;"));
            expressions.Add("v14_Style", MergeStyles("color: #ff0d0d; font-size: 14px;"));
            expressions.Add("v21_Style", MergeStyles("margin-left: 0"));
            expressions.Add("v24_Style", MergeStyles("margin-left: 0px"));
            expressions["KJGQAZPwDMEqUI_utmsJRQw_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", "img/ConectaProveedores.Logo.jpg")).ToString());
            expressions["KTvWuU236Sk2n6yvWXZEc1w_Value"] = HtmlEncode(inParamApplicationName.ToString());
            expressions["KqJsunAz4EkOUb58XUida_A_Value"] = HtmlEncode(inParamFileName.ToString());
            expressions["KvtZl8lF4pkipiV1fE4Ikiw_Value"] = HtmlEncode(("Por favor, accede al enlace"+" ").ToString());
            expressions["Kimet_j8noUKViKvv4XuuAg_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", (((((string)AppUtils.SiteProperties[SitePropertiesModel.spCurrentDomain])))+"ConectaProveedores"))).ToString());
            expressions["KDVTvYAIG2UareDGa_HMr3w_Value"] = HtmlEncode(inParamApplicationName.ToString());
            expressions["KmH6bl6ZiS0iF8fMs3pdrcQ_Value"] = HtmlEncode(BuiltInFunction.Year (BuiltInFunction.CurrDate ()).ToString());
            expressions["KPJv4DR_0YkWKEXf6TiwPlA_Value"] = HtmlEncode(inParamApplicationName.ToString());

            var condition_K8UToNQdigU2jOaw2RE5fAg_ = (inParami_Enviroment=="PROD");
            expressions["K8UToNQdigU2jOaw2RE5fAg_"] = condition_K8UToNQdigU2jOaw2RE5fAg_;
            if (condition_K8UToNQdigU2jOaw2RE5fAg_) {
            } else {

            var condition_KVgI7TV15IEeolbzY2f1CYg_ = (inParami_Enviroment=="DEV");
            expressions["KVgI7TV15IEeolbzY2f1CYg_"] = condition_KVgI7TV15IEeolbzY2f1CYg_;
            if (condition_KVgI7TV15IEeolbzY2f1CYg_) {
            } else {

            var condition_KM0HBkANI706CciFM75GEZA_ = (inParami_Enviroment=="QA");
            expressions["KM0HBkANI706CciFM75GEZA_"] = condition_KM0HBkANI706CciFM75GEZA_;
            if (condition_KM0HBkANI706CciFM75GEZA_) {
            } else {
            }

            }

            }


            var condition_KB8MxkM5KdUC_q4kK1XwQgA_ = (!inParamErrorList.Empty);
            expressions["KB8MxkM5KdUC_q4kK1XwQgA_"] = condition_KB8MxkM5KdUC_q4kK1XwQgA_;
            if (condition_KB8MxkM5KdUC_q4kK1XwQgA_) {

            var data_KDILeaY64o0mb6DOylaf9fQ_Source = new IterativeTemplateData();
            await IterateAsync(inParamErrorList, async () => {
               var templateData_KDILeaY64o0mb6DOylaf9fQ_Source = new TemplateData();
                           templateData_KDILeaY64o0mb6DOylaf9fQ_Source["Kyt5q5lO9g06Wf4ZC1IW1ng_Value"] = HtmlEncode((inParamErrorList.CurrentRec.ssDocument+":").ToString());
                           templateData_KDILeaY64o0mb6DOylaf9fQ_Source["KQO8tCGAs_0eAuWiq25mg1A_Value"] = HtmlEncode(inParamErrorList.CurrentRec.ssError.ToString());
               data_KDILeaY64o0mb6DOylaf9fQ_Source.Add(templateData_KDILeaY64o0mb6DOylaf9fQ_Source);
            });
            expressions.Add("KDILeaY64o0mb6DOylaf9fQ_Source", data_KDILeaY64o0mb6DOylaf9fQ_Source);

            } else {
            }


            var condition_KWqjvO86OTUmMwx3pbcYYDA_ = inParamIsPROD;
            expressions["KWqjvO86OTUmMwx3pbcYYDA_"] = condition_KWqjvO86OTUmMwx3pbcYYDA_;
            if (condition_KWqjvO86OTUmMwx3pbcYYDA_) {
            } else {

            var condition_KW_NOHfGAn0yNEXL5poXY_Q_ = (inParamRealEmailList!="");
            expressions["KW_NOHfGAn0yNEXL5poXY_Q_"] = condition_KW_NOHfGAn0yNEXL5poXY_Q_;
            if (condition_KW_NOHfGAn0yNEXL5poXY_Q_) {
            expressions["K99xRVpPE_UeiZKOTmAeR0g_Value"] = HtmlEncode(("Se enviará a: "+inParamRealEmailList).ToString());
            } else {
            }


            var condition_KYvDF9Mom702ST1bt2NjC_g_ = (inParamRealEmailCCList!="");
            expressions["KYvDF9Mom702ST1bt2NjC_g_"] = condition_KYvDF9Mom702ST1bt2NjC_g_;
            if (condition_KYvDF9Mom702ST1bt2NjC_g_) {
            expressions["K0ruphNwlMU23ir1waZ7QLQ_Value"] = HtmlEncode(("En CC: "+inParamRealEmailCCList).ToString());
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
