namespace ssConectaProveedores;

public partial class Actions {
public class lcvAuditCreateWrapper : VarsBag {
public ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure inParamSource;
public long resServiceAuditCreate_outParamId = 0L;

public string resGetIP_outParamClientIP = "";
public string resGetIP_outParamAdditionalIP = "";

public lcvAuditCreateWrapper(ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure inParamSource) {
this.inParamSource = inParamSource;
}
}
/// <summary>
/// Action <code>AuditCreateWrapper</code> that represents the Service Studio action
///  <code>AuditCreateWrapper</code> <p> Description: </p>
/// </summary>
public static async Task ActionAuditCreateWrapper(IRequestContext requestContext,ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure inParamSource,CancellationToken cancellationToken) {
lcvAuditCreateWrapper localVars = new lcvAuditCreateWrapper(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("AuditCreateWrapper", "29ed484b-b7f1-432a-9518-6b19b3ff7cf9"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("AuditCreateWrapper", "29ed484b-b7f1-432a-9518-6b19b3ff7cf9", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// GetIP
(localVars.resGetIP_outParamClientIP,localVars.resGetIP_outParamAdditionalIP) = await Actions.ActionGetIP(requestContext,cancellationToken);

// ServiceAuditCreate
localVars.resServiceAuditCreate_outParamId = await ServiceAPIs.ServiceAPIServiceAuditCreate(requestContext,localVars.inParamSource,localVars.resGetIP_outParamClientIP,cancellationToken);

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionAuditCreateWrapper {



}


}
