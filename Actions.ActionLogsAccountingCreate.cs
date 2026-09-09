namespace ssConectaProveedores;

public partial class Actions {
public class lcvLogsAccountingCreate : VarsBag {
public EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord inParamSource;
public long resCreateLogsAccounting_outParamId = 0L;

public lcvLogsAccountingCreate(EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoLogsAccountingCreate : VarsBag {
public long outParamId = 0L;

public lcoLogsAccountingCreate() {
}
}
/// <summary>
/// Action <code>LogsAccountingCreate</code> that represents the Service Studio action
///  <code>LogsAccountingCreate</code> <p> Description: Encapsulates the Create entity action, enablin
/// g logic to run consistently before and after a record is created.</p>
/// </summary>
public static async Task<long> ActionLogsAccountingCreate(IRequestContext requestContext,EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoLogsAccountingCreate result = new lcoLogsAccountingCreate();
lcvLogsAccountingCreate localVars = new lcvLogsAccountingCreate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("LogsAccountingCreate", "ffbc40af-9f19-4760-ac35-ad3c4dd241da"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("LogsAccountingCreate", "ffbc40af-9f19-4760-ac35-ad3c4dd241da", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Source.Description = Substr
localVars.inParamSource.ssDescription = BuiltInFunction.SubstrSC (localVars.inParamSource.ssDescription, 0, 600);

// Source.CreatedOn = CurrDateTime
localVars.inParamSource.ssCreatedOn = BuiltInFunction.CurrDateTime ();

// Source.CreatedBy = GetUserId
localVars.inParamSource.ssCreatedBy = BuiltInFunction.GetUserId ();
// CreateLogsAccounting
localVars.resCreateLogsAccounting_outParamId = await ExtendedActions.CreateLogsAccounting(requestContext,(((RC_404aa878a81887880a35de683904d643)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateLogsAccounting.Id
result.outParamId=localVars.resCreateLogsAccounting_outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionLogsAccountingCreate {



}


}
