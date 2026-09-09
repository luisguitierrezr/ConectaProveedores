using System.Web;
using OutSystems.Application.Abstractions.Emails;
using OutSystems.Application.Emails;
using OutSystems.Application.Core.Email;
using OutSystems.Application.Models.Emails;
using OutSystems.ObjectKeys;
using IterativeTemplateData = System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>>;
using TemplateData = System.Collections.Generic.Dictionary<string, object>;

namespace ssConectaProveedores.Flows.Flowa_Emails {

    public class a_Emails_ResetPassword : EmailScreen {

        public a_Emails_ResetPassword(
            ISettingsProvider settingsProvider,
            IApplicationLogger applicationLogger,
            ICssFlatteningService cssFlatteningService) : base(settingsProvider, applicationLogger, cssFlatteningService) { }

        private static string inlineCss;

        

        private static string _template;
        internal virtual string Template {
            get { return _template ?? (_template = GetTemplateContent("a_Emails.ResetPassword.html.resources")); }
        }

        protected static readonly IEnumerable<string> CssFiles = new List<string> {
"css/ConectaProveedores.EmailTheme.css",
"css/ConectaProveedores.a_Emails.ResetPassword.css",
"css/ConectaProveedores.EmailTheme.extra.css",

        };

        public async Task<string> GetEmailContentAsync(IRequestContext requestContext, string inParamApplicationName,string inParamCustomerName,string inParamCustomerEmail,string inParamVerificationCode,bool inParamIsPROD, CancellationToken cancellationToken) {
            if (string.IsNullOrEmpty(inlineCss)) {
                inlineCss = await GetInlineStyleSheetIncludeAsync(CssFiles, cancellationToken);
            }
            binaryImages = new Dictionary<string, Image>();
            var expressions = new TemplateData();

            expressions.Add("KOoBqdLmVF0yD5Ye2ebNzPg_Subject", HtmlEncode(("Restablecer contraseña para "+inParamApplicationName).ToString()));
            expressions.Add("STYLE", inlineCss);
            expressions.Add("v5_Style", MergeStyles("text-align: left;"));
            expressions.Add("v17_Style", MergeStyles("margin-left: 0"));
            expressions.Add("v20_Style", MergeStyles("margin-left: 0px"));
            expressions["Kc45mSqwyfUSeKooXgEVpBQ_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", "img/ConectaProveedores.EmailLogo.png")).ToString());
            expressions["KXOIsqQp0X0W5PhByNWVx7Q_Value"] = HtmlEncode(inParamApplicationName.ToString());
            expressions["KiCwb3Shl0Ey1F8lgXrGgmg_Value"] = HtmlEncode(inParamVerificationCode.ToString());
            expressions["KLgs98EhqvU6Lo_lWl9UXhg_HREF"] = HtmlAttributeEncode((GetUrl("ConectaProveedores", "RecoverPasswordReset")).ToString());
            expressions["KZ19k9itRmk6dzHo8SayB6Q_Value"] = HtmlEncode(inParamApplicationName.ToString());
            expressions["KtztJreH_xUSHwQ2riuX2Lw_Value"] = HtmlEncode(BuiltInFunction.Year (BuiltInFunction.CurrDate ()).ToString());
            expressions["KQ5YEFJzPJUSjR_63yRrTbg_Value"] = HtmlEncode(inParamApplicationName.ToString());

            var condition_KtpFH71aPfEqxzXf3QfiL1A_ = (inParamCustomerName!="");
            expressions["KtpFH71aPfEqxzXf3QfiL1A_"] = condition_KtpFH71aPfEqxzXf3QfiL1A_;
            if (condition_KtpFH71aPfEqxzXf3QfiL1A_) {
            expressions["Kl1dD2da_50ih2AMhtgvqyg_Value"] = HtmlEncode((("Hola "+inParamCustomerName)+"!").ToString());
            } else {
            }


            var condition_Kss0DIbbodkOcYz9bojWuew_ = inParamIsPROD;
            expressions["Kss0DIbbodkOcYz9bojWuew_"] = condition_Kss0DIbbodkOcYz9bojWuew_;
            if (condition_Kss0DIbbodkOcYz9bojWuew_) {
            } else {
            expressions["K_E8j8GE1M0SfzwzxFlESow_Value"] = HtmlEncode(((("Se enviará a: "+inParamCustomerEmail)+" / ")+(((inParamCustomerName!="")) ? (inParamCustomerName) : ("Nome no encontrado o vacio"))).ToString());
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
