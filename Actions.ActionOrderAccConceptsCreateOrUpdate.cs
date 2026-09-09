namespace ssConectaProveedores;

public partial class Actions {
public class lcvOrderAccConceptsCreateOrUpdate : VarsBag {
public EN_3e07a23619060cc7dc5624548803f5fdEntityRecord inParamSource;
public long resCreateOrUpdateOrderAccConcepts_outParamId = 0L;

public lcvOrderAccConceptsCreateOrUpdate(EN_3e07a23619060cc7dc5624548803f5fdEntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoOrderAccConceptsCreateOrUpdate : VarsBag {
public long outParamId = 0L;

public lcoOrderAccConceptsCreateOrUpdate() {
}
}
/// <summary>
/// Action <code>OrderAccConceptsCreateOrUpdate</code> that represents the Service Studio action
///  <code>OrderAccConceptsCreateOrUpdate</code> <p> Description: Encapsulates the CreateOrUpdate entit
/// y action, enabling logic to run consistently before and after a record is created or modified.</p>
/// </summary>
public static async Task<long> ActionOrderAccConceptsCreateOrUpdate(IRequestContext requestContext,EN_3e07a23619060cc7dc5624548803f5fdEntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoOrderAccConceptsCreateOrUpdate result = new lcoOrderAccConceptsCreateOrUpdate();
lcvOrderAccConceptsCreateOrUpdate localVars = new lcvOrderAccConceptsCreateOrUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("OrderAccConceptsCreateOrUpdate", "b9a1cf67-fc1e-4cd6-87c6-8da407fe9f4b"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("OrderAccConceptsCreateOrUpdate", "b9a1cf67-fc1e-4cd6-87c6-8da407fe9f4b", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// CreateOrUpdateOrderAccConcepts
localVars.resCreateOrUpdateOrderAccConcepts_outParamId = await ExtendedActions.CreateOrUpdateOrderAccConcepts(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_dc9a6819825fee88eba01192ae9b1890)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateOrUpdateOrderAccConcepts.Id
result.outParamId=localVars.resCreateOrUpdateOrderAccConcepts_outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionOrderAccConceptsCreateOrUpdate {



}


}
