namespace ssConectaProveedores;

public partial class Actions {
public class lcvLoginEntra : VarsBag {
public string inParami_UserEmailTelcel;
public string inParami_NewRegion;
public bool resServiceCheckSupplierUserEmail_outParamo_NotExists = false;
public bool resServiceCheckSupplierUserEmail_outParamo_NotActive = false;
public bool resServiceCheckSupplierUserEmail_outParamo_IsDeleted = false;

public ST_b1b6df219277397c7c2be747d587880aStructure resServiceSetUserData_outParamo_Return = new ST_b1b6df219277397c7c2be747d587880aStructure();
public bool resServiceSetUserData_outParamo_HasChangedJobTitle = false;

public lcvLoginEntra(string inParami_UserEmailTelcel, string inParami_NewRegion) {
this.inParami_UserEmailTelcel = inParami_UserEmailTelcel;
this.inParami_NewRegion = inParami_NewRegion;
}
}
public class lcoLoginEntra : VarsBag {
public string outParamo_Message = "";

public bool outParamo_IsSuccess = false;

public lcoLoginEntra() {
}
}
/// <summary>
/// Action <code>LoginEntra</code> that represents the Service Studio action <code>LoginEntra</code>
///  <p> Description: Action to get data from Entra, assign Roles and set User Session.</p>
/// </summary>
public static async Task<(string,bool)> ActionLoginEntra(IRequestContext requestContext,string inParami_UserEmailTelcel,string inParami_NewRegion,CancellationToken cancellationToken) {
string outParamo_Message = default;
bool outParamo_IsSuccess = default;
lcoLoginEntra result = new lcoLoginEntra();
lcvLoginEntra localVars = new lcvLoginEntra(inParami_UserEmailTelcel, inParami_NewRegion);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("LoginEntra", "f76c7496-be04-493d-8304-d6311a22e35b"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("LoginEntra", "f76c7496-be04-493d-8304-d6311a22e35b", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// ServiceCheckSupplierUserEmail
(localVars.resServiceCheckSupplierUserEmail_outParamo_NotExists,localVars.resServiceCheckSupplierUserEmail_outParamo_NotActive,localVars.resServiceCheckSupplierUserEmail_outParamo_IsDeleted) = await ServiceAPIs.ServiceAPIServiceCheckSupplierUserEmail(requestContext,localVars.inParami_UserEmailTelcel,cancellationToken);

// ServiceSetUserData
(localVars.resServiceSetUserData_outParamo_Return,localVars.resServiceSetUserData_outParamo_HasChangedJobTitle) = await ServiceAPIs.ServiceAPIServiceSetUserData(requestContext,localVars.inParami_UserEmailTelcel,localVars.inParami_NewRegion,cancellationToken);

// o_Return.IsSuccess?
if((localVars.resServiceSetUserData_outParamo_Return.ssIsSuccess)) {
// Output Variables
// o_Message = ServiceSetUserData.o_Return.Message
result.outParamo_Message=localVars.resServiceSetUserData_outParamo_Return.ssMessage;

// o_IsSuccess = ServiceSetUserData.o_Return.IsSuccess
result.outParamo_IsSuccess=localVars.resServiceSetUserData_outParamo_Return.ssIsSuccess;
// CreateUserSession
await Actions.ActionCreateUserSession(requestContext,cancellationToken);

} else {
// Output Variables
// o_Message = ServiceSetUserData.o_Return.Message
result.outParamo_Message=localVars.resServiceSetUserData_outParamo_Return.ssMessage;

// o_IsSuccess = ServiceSetUserData.o_Return.IsSuccess
result.outParamo_IsSuccess=localVars.resServiceSetUserData_outParamo_Return.ssIsSuccess;
}

} //close CreateActionActivity using block
} // try

finally {
outParamo_Message = result.outParamo_Message;
outParamo_IsSuccess = result.outParamo_IsSuccess;
} // inner-finally
RETURN_STATEMENT:
return (outParamo_Message,outParamo_IsSuccess);
}

public static class FuncActionLoginEntra {



}


}
