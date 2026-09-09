namespace ssConectaProveedores;

public partial class Actions {
public class lcvRequisitonStatusHistoryCreateOrUpdate : VarsBag {
public EN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord inParamSource;
public long resCreateOrUpdateRequisitionStatusHistory_outParamId = 0L;

public lcvRequisitonStatusHistoryCreateOrUpdate(EN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoRequisitonStatusHistoryCreateOrUpdate : VarsBag {
public long outParamId = 0L;

public lcoRequisitonStatusHistoryCreateOrUpdate() {
}
}
/// <summary>
/// Action <code>RequisitonStatusHistoryCreateOrUpdate</code> that represents the Service Studio action
///  <code>RequisitonStatusHistoryCreateOrUpdate</code> <p> Description: Encapsulates the CreateOrUpdat
/// e entity action, enabling logic to run consistently before and after a record is created or
///  modified.</p>
/// </summary>
public static async Task<long> ActionRequisitonStatusHistoryCreateOrUpdate(IRequestContext requestContext,EN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoRequisitonStatusHistoryCreateOrUpdate result = new lcoRequisitonStatusHistoryCreateOrUpdate();
lcvRequisitonStatusHistoryCreateOrUpdate localVars = new lcvRequisitonStatusHistoryCreateOrUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("RequisitonStatusHistoryCreateOrUpdate", "4703de89-0989-472b-9822-25faf149d9a6"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("RequisitonStatusHistoryCreateOrUpdate", "4703de89-0989-472b-9822-25faf149d9a6", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Is new record?
if(((localVars.inParamSource.ssId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// Set basic audit attributes
// Source.CreatedBy = GetUserId
localVars.inParamSource.ssCreatedBy = BuiltInFunction.GetUserId ();
}

// CreateOrUpdateRequisitionStatusHistory
localVars.resCreateOrUpdateRequisitionStatusHistory_outParamId = await ExtendedActions.CreateOrUpdateRequisitionStatusHistory(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_aa9fab59faf7c7de355dae43478ba7e5)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateOrUpdateRequisitionStatusHistory.Id
result.outParamId=localVars.resCreateOrUpdateRequisitionStatusHistory_outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionRequisitonStatusHistoryCreateOrUpdate {



}


}
