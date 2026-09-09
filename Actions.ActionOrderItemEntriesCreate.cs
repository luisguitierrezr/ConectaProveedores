namespace ssConectaProveedores;

public partial class Actions {
public class lcvOrderItemEntriesCreate : VarsBag {
public EN_0eb2cf39b93366f50855e537f6b98500EntityRecord inParamSource;
public long resCreateOrderItemEntries_outParamId = 0L;

public lcvOrderItemEntriesCreate(EN_0eb2cf39b93366f50855e537f6b98500EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoOrderItemEntriesCreate : VarsBag {
public long outParamId = 0L;

public lcoOrderItemEntriesCreate() {
}
}
/// <summary>
/// Action <code>OrderItemEntriesCreate</code> that represents the Service Studio action
///  <code>OrderItemEntriesCreate</code> <p> Description: Encapsulates the Create entity action
/// , enabling logic to run consistently before and after a record is created.</p>
/// </summary>
public static async Task<long> ActionOrderItemEntriesCreate(IRequestContext requestContext,EN_0eb2cf39b93366f50855e537f6b98500EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoOrderItemEntriesCreate result = new lcoOrderItemEntriesCreate();
lcvOrderItemEntriesCreate localVars = new lcvOrderItemEntriesCreate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("OrderItemEntriesCreate", "0168427c-6fbe-4609-96b6-5bfeded86e9a"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("OrderItemEntriesCreate", "0168427c-6fbe-4609-96b6-5bfeded86e9a", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Set basic audit attributes
// Source.CreatedOn = CurrDateTime
localVars.inParamSource.ssCreatedOn = BuiltInFunction.CurrDateTime ();

// Source.CreatedBy = GetUserId
localVars.inParamSource.ssCreatedBy = BuiltInFunction.GetUserId ();
// CreateOrderItemEntries
localVars.resCreateOrderItemEntries_outParamId = await ExtendedActions.CreateOrderItemEntries(requestContext,(((RC_27f9dcc2de814d2d04d4d18f5b8c424b)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateOrderItemEntries.Id
result.outParamId=localVars.resCreateOrderItemEntries_outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionOrderItemEntriesCreate {



}


}
