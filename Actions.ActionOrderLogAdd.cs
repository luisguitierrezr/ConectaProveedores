namespace ssConectaProveedores;

public partial class Actions {
public class lcvOrderLogAdd : VarsBag {
public EN_a8e484428097204171df8a1feecb2534EntityRecord inParamSource;
public long resCreateOrUpdateOrderLogs_outParamId = 0L;

public lcvOrderLogAdd(EN_a8e484428097204171df8a1feecb2534EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoOrderLogAdd : VarsBag {
public long outParamId = 0L;

public lcoOrderLogAdd() {
}
}
/// <summary>
/// Action <code>OrderLogAdd</code> that represents the Service Studio action <code>OrderLogAdd</code>
///  <p> Description: Encapsulates the CreateOrUpdate entity action, enabling logic to run consistentl
/// y before and after a record is created or modified.</p>
/// </summary>
public static async Task<long> ActionOrderLogAdd(IRequestContext requestContext,EN_a8e484428097204171df8a1feecb2534EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoOrderLogAdd result = new lcoOrderLogAdd();
lcvOrderLogAdd localVars = new lcvOrderLogAdd(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("OrderLogAdd", "1175e777-61ed-469b-a2fe-d195e4a36078"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("OrderLogAdd", "1175e777-61ed-469b-a2fe-d195e4a36078", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Source.Message = Substr
localVars.inParamSource.ssMessage = BuiltInFunction.SubstrSC (localVars.inParamSource.ssMessage, 0, 1999);
// Is new record?
if(((localVars.inParamSource.ssId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// Set basic audit attributes
// Source.CreatedOn = CurrDateTime
localVars.inParamSource.ssCreatedOn = BuiltInFunction.CurrDateTime ();
}

// CreateOrUpdateOrderLogs
localVars.resCreateOrUpdateOrderLogs_outParamId = await ExtendedActions.CreateOrUpdateOrderLogs(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_aa950ad3dd0235488db9d65307673199)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateOrUpdateOrderLogs.Id
result.outParamId=localVars.resCreateOrUpdateOrderLogs_outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionOrderLogAdd {



}


}
