namespace ssConectaProveedores;

public partial class Actions {
public class lcvRequisitionLogAdd : VarsBag {
public EN_fca813b8ca96d6759e00225744caa7d4EntityRecord inParamSource;
public long resCreateOrUpdateRequisitionLogs_outParamId = 0L;

public lcvRequisitionLogAdd(EN_fca813b8ca96d6759e00225744caa7d4EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoRequisitionLogAdd : VarsBag {
public long outParamId = 0L;

public lcoRequisitionLogAdd() {
}
}
/// <summary>
/// Action <code>RequisitionLogAdd</code> that represents the Service Studio action
///  <code>RequisitionLogAdd</code> <p> Description: Encapsulates the CreateOrUpdate entity action
/// , enabling logic to run consistently before and after a record is created or modified.</p>
/// </summary>
public static async Task<long> ActionRequisitionLogAdd(IRequestContext requestContext,EN_fca813b8ca96d6759e00225744caa7d4EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoRequisitionLogAdd result = new lcoRequisitionLogAdd();
lcvRequisitionLogAdd localVars = new lcvRequisitionLogAdd(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("RequisitionLogAdd", "d7cadd5d-c00b-4bb2-a62e-0e3c2908ae79"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("RequisitionLogAdd", "d7cadd5d-c00b-4bb2-a62e-0e3c2908ae79", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Is new record?
if(((localVars.inParamSource.ssId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// Set basic audit attributes
// Source.CreatedOn = CurrDateTime
localVars.inParamSource.ssCreatedOn = BuiltInFunction.CurrDateTime ();
}

// CreateOrUpdateRequisitionLogs
localVars.resCreateOrUpdateRequisitionLogs_outParamId = await ExtendedActions.CreateOrUpdateRequisitionLogs(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_da02352775767d2a57ea4cd35cd18496)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateOrUpdateRequisitionLogs.Id
result.outParamId=localVars.resCreateOrUpdateRequisitionLogs_outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionRequisitionLogAdd {



}


}
