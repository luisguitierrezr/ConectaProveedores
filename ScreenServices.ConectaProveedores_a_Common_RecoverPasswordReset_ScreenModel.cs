using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_a_Common_RecoverPasswordReset_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_a_Common_RecoverPasswordReset_ScreenModel).Namespace);

    public string varLcNewPassword;
public string varLcConfirmPassword;
public bool varLcIsPasswordVisible;
public bool varLcIsConfirmPasswordVisible;
public bool varLcIsButtonEnabled;
public bool varLcIsExecuting;
public bool varLcIsNewPasswordCompliant;
public string varLcVerificationCode;
public string varLcEmail;
public ConectaProveedores_a_Common_RecoverPasswordReset_DataActionGetSettingsEnviroment_Model varLcGetSettingsEnviroment;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_a_Common_RecoverPasswordReset_ScreenModel() {
}



    public ConectaProveedores_a_Common_RecoverPasswordReset_ScreenModel(string varLcNewPassword, string varLcConfirmPassword, bool varLcIsPasswordVisible, bool varLcIsConfirmPasswordVisible, bool varLcIsButtonEnabled, bool varLcIsExecuting, bool varLcIsNewPasswordCompliant, string varLcVerificationCode, string varLcEmail, ConectaProveedores_a_Common_RecoverPasswordReset_DataActionGetSettingsEnviroment_Model varLcGetSettingsEnviroment, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"NewPassword", "ConfirmPassword", "IsPasswordVisible", "IsConfirmPasswordVisible", "IsButtonEnabled", "IsExecuting", "IsNewPasswordCompliant", "VerificationCode", "Email", "GetSettingsEnviroment", "ClientVars"}, new string[] {"varLcNewPassword", "varLcConfirmPassword", "varLcIsPasswordVisible", "varLcIsConfirmPasswordVisible", "varLcIsButtonEnabled", "varLcIsExecuting", "varLcIsNewPasswordCompliant", "varLcVerificationCode", "varLcEmail", "varLcGetSettingsEnviroment", "clientVariables"});
this.varLcNewPassword = varLcNewPassword;
this.varLcConfirmPassword = varLcConfirmPassword;
this.varLcIsPasswordVisible = varLcIsPasswordVisible;
this.varLcIsConfirmPasswordVisible = varLcIsConfirmPasswordVisible;
this.varLcIsButtonEnabled = varLcIsButtonEnabled;
this.varLcIsExecuting = varLcIsExecuting;
this.varLcIsNewPasswordCompliant = varLcIsNewPasswordCompliant;
this.varLcVerificationCode = varLcVerificationCode;
this.varLcEmail = varLcEmail;
this.varLcGetSettingsEnviroment = varLcGetSettingsEnviroment;
this.clientVariables = clientVariables;
}



    

    public class lcoGetSettingsEnviroment : VarsBag {
public bool outParamIsDevEnvironment = false;

public string outParamEnvironment = "";

public lcoGetSettingsEnviroment() {
}
}
/// <summary>
/// Action <code>GetSettingsEnviroment</code> that represents the Service Studio action
///  <code>GetSettingsEnviroment</code> <p> Description: </p>
/// </summary>
public async Task<(bool,string)> DataActionGetSettingsEnviroment(IRequestContext requestContext,CancellationToken cancellationToken) {
bool outParamIsDevEnvironment = default;
string outParamEnvironment = default;
lcoGetSettingsEnviroment result = new lcoGetSettingsEnviroment();
ConectaProveedores_a_Common_RecoverPasswordReset_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetSettingsEnviroment", "d40d67d0-1008-415a-9d41-7a68f2e40dd7"))
using (activitySource.CreateScreenDataActionActivity("RecoverPasswordReset", "GetSettingsEnviroment")){
// IsDevEnvironment = IsDevEnvironment
result.outParamIsDevEnvironment=((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsDevEnvironment])));
// SetEnviroment
// Environment = Environment
result.outParamEnvironment=((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])));
} //close CreateActionActivity using block
} // try

finally {
outParamIsDevEnvironment = result.outParamIsDevEnvironment;
outParamEnvironment = result.outParamEnvironment;
} // inner-finally
RETURN_STATEMENT:
return (outParamIsDevEnvironment,outParamEnvironment);
}


    public static class FuncDataActionGetSettingsEnviroment {
}


}
