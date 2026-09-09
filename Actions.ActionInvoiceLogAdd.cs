namespace ssConectaProveedores;

public partial class Actions {
public class lcvInvoiceLogAdd : VarsBag {
public EN_bf34270fdd0f7785895f41a998e724e8EntityRecord inParamSource;
public long resCreateOrUpdateInvoiceLog_outParamId = 0L;

public lcvInvoiceLogAdd(EN_bf34270fdd0f7785895f41a998e724e8EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoInvoiceLogAdd : VarsBag {
public long outParamId = 0L;

public lcoInvoiceLogAdd() {
}
}
/// <summary>
/// Action <code>InvoiceLogAdd</code> that represents the Service Studio action
///  <code>InvoiceLogAdd</code> <p> Description: Encapsulates the CreateOrUpdate entity action, enablin
/// g logic to run consistently before and after a record is created or modified.</p>
/// </summary>
public static async Task<long> ActionInvoiceLogAdd(IRequestContext requestContext,EN_bf34270fdd0f7785895f41a998e724e8EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoInvoiceLogAdd result = new lcoInvoiceLogAdd();
lcvInvoiceLogAdd localVars = new lcvInvoiceLogAdd(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InvoiceLogAdd", "74556326-5625-450c-bde1-7b857785d67d"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InvoiceLogAdd", "74556326-5625-450c-bde1-7b857785d67d", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Is new record?
if(((localVars.inParamSource.ssId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// Set basic audit attributes
// Source.CreatedOn = CurrDateTime
localVars.inParamSource.ssCreatedOn = BuiltInFunction.CurrDateTime ();
}

// CreateOrUpdateInvoiceLog
localVars.resCreateOrUpdateInvoiceLog_outParamId = await ExtendedActions.CreateOrUpdateInvoiceLog(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_deaf8695933be1bd95c8a487c5df0dc4)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateOrUpdateInvoiceLog.Id
result.outParamId=localVars.resCreateOrUpdateInvoiceLog_outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionInvoiceLogAdd {



}


}
