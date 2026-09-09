namespace ssConectaProveedores;

public partial class Actions {
public class lcvAddNewRole : VarsBag {
public string inParamRoleName;
public ST_346a76e47f982dbf41625f8a893affccStructure resServiceEntraRoleCreate_outParamo_output = new ST_346a76e47f982dbf41625f8a893affccStructure();
public bool resServiceEntraRoleCreate_outParamHasBeenCreated = false;
public long resServiceEntraRoleCreate_outParamEntraRoleId = 0L;

public lcvAddNewRole(string inParamRoleName) {
this.inParamRoleName = inParamRoleName;
}
}
public class lcoAddNewRole : VarsBag {
public bool outParamIsSuccess = false;

public lcoAddNewRole() {
}
}
/// <summary>
/// Action <code>AddNewRole</code> that represents the Service Studio action <code>AddNewRole</code>
///  <p> Description: </p>
/// </summary>
public static async Task<bool> ActionAddNewRole(IRequestContext requestContext,string inParamRoleName,CancellationToken cancellationToken) {
bool outParamIsSuccess = default;
lcoAddNewRole result = new lcoAddNewRole();
lcvAddNewRole localVars = new lcvAddNewRole(inParamRoleName);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("AddNewRole", "9559385d-1f95-4a36-915b-e243cc38f8d1"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("AddNewRole", "9559385d-1f95-4a36-915b-e243cc38f8d1", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// ServiceEntraRoleCreate
(localVars.resServiceEntraRoleCreate_outParamo_output,localVars.resServiceEntraRoleCreate_outParamHasBeenCreated,localVars.resServiceEntraRoleCreate_outParamEntraRoleId) = await ServiceAPIs.ServiceAPIServiceEntraRoleCreate(requestContext,BuiltInFunction.Trim (BuiltInFunction.ToUpper (localVars.inParamRoleName)),cancellationToken);

// Output Variables
// IsSuccess = ServiceEntraRoleCreate.o_output.IsSuccess
result.outParamIsSuccess=localVars.resServiceEntraRoleCreate_outParamo_output.ssIsSuccess;
} //close CreateActionActivity using block
} // try

finally {
outParamIsSuccess = result.outParamIsSuccess;
} // inner-finally
RETURN_STATEMENT:
return outParamIsSuccess;
}

public static class FuncActionAddNewRole {



}


}
