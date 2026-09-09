namespace ssConectaProveedores;

public partial class Actions {
public class lcvActionTimestampsCreateOrUpdate : VarsBag {
public EN_b22d64c90281d09a316b6f4502a74326EntityRecord inParamSource;
public long resCreateOrUpdateActionTimestamps_outParamId = 0L;

public lcvActionTimestampsCreateOrUpdate(EN_b22d64c90281d09a316b6f4502a74326EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoActionTimestampsCreateOrUpdate : VarsBag {
public long outParamId = 0L;

public lcoActionTimestampsCreateOrUpdate() {
}
}
/// <summary>
/// Action <code>ActionTimestampsCreateOrUpdate</code> that represents the Service Studio action
///  <code>ActionTimestampsCreateOrUpdate</code> <p> Description: Encapsulates the CreateOrUpdate entit
/// y action, enabling logic to run consistently before and after a record is created or modified.</p>
/// </summary>
public static async Task<long> ActionActionTimestampsCreateOrUpdate(IRequestContext requestContext,EN_b22d64c90281d09a316b6f4502a74326EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoActionTimestampsCreateOrUpdate result = new lcoActionTimestampsCreateOrUpdate();
lcvActionTimestampsCreateOrUpdate localVars = new lcvActionTimestampsCreateOrUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("ActionTimestampsCreateOrUpdate", "4aadf8f2-2f3a-4507-9793-7154e30386e5"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("ActionTimestampsCreateOrUpdate", "4aadf8f2-2f3a-4507-9793-7154e30386e5", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// CreateOrUpdateActionTimestamps
localVars.resCreateOrUpdateActionTimestamps_outParamId = await ExtendedActions.CreateOrUpdateActionTimestamps(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_00310a262abd8758c59d6849f2a2be40)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateOrUpdateActionTimestamps.Id
result.outParamId=localVars.resCreateOrUpdateActionTimestamps_outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionActionTimestampsCreateOrUpdate {



}


}
