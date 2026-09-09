using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_a_Common_RecoverPasswordRequest_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_a_Common_RecoverPasswordRequest_ScreenModel).Namespace);

    public bool varLcIsExecuting;
public string varLcEmail;
public bool varLcIsButtonEnabled;
public ConectaProveedores_a_Common_RecoverPasswordRequest_DataActionGetSettingsEnviroment_Model varLcGetSettingsEnviroment;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_a_Common_RecoverPasswordRequest_ScreenModel() {
}



    public ConectaProveedores_a_Common_RecoverPasswordRequest_ScreenModel(bool varLcIsExecuting, string varLcEmail, bool varLcIsButtonEnabled, ConectaProveedores_a_Common_RecoverPasswordRequest_DataActionGetSettingsEnviroment_Model varLcGetSettingsEnviroment, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"IsExecuting", "Email", "IsButtonEnabled", "GetSettingsEnviroment", "ClientVars"}, new string[] {"varLcIsExecuting", "varLcEmail", "varLcIsButtonEnabled", "varLcGetSettingsEnviroment", "clientVariables"});
this.varLcIsExecuting = varLcIsExecuting;
this.varLcEmail = varLcEmail;
this.varLcIsButtonEnabled = varLcIsButtonEnabled;
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
ConectaProveedores_a_Common_RecoverPasswordRequest_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetSettingsEnviroment", "2f7fb024-80ed-4c8f-ac60-7e31b39271ba"))
using (activitySource.CreateScreenDataActionActivity("RecoverPasswordRequest", "GetSettingsEnviroment")){
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
