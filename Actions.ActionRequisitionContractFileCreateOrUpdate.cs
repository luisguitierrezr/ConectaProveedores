namespace ssConectaProveedores;

public partial class Actions {
public class lcvRequisitionContractFileCreateOrUpdate : VarsBag {
public EN_aeab0089a9236dfc6c684ea98f650647EntityRecord inParamSource;
public long resCreateOrUpdateRequisitionContractFile_outParamId = 0L;

public lcvRequisitionContractFileCreateOrUpdate(EN_aeab0089a9236dfc6c684ea98f650647EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoRequisitionContractFileCreateOrUpdate : VarsBag {
public long outParamId = 0L;

public lcoRequisitionContractFileCreateOrUpdate() {
}
}
/// <summary>
/// Action <code>RequisitionContractFileCreateOrUpdate</code> that represents the Service Studio action
///  <code>RequisitionContractFileCreateOrUpdate</code> <p> Description: Encapsulates the CreateOrUpdat
/// e entity action, enabling logic to run consistently before and after a record is created or
///  modified.</p>
/// </summary>
public static async Task<long> ActionRequisitionContractFileCreateOrUpdate(IRequestContext requestContext,EN_aeab0089a9236dfc6c684ea98f650647EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoRequisitionContractFileCreateOrUpdate result = new lcoRequisitionContractFileCreateOrUpdate();
lcvRequisitionContractFileCreateOrUpdate localVars = new lcvRequisitionContractFileCreateOrUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("RequisitionContractFileCreateOrUpdate", "7a975f80-6a8f-475d-a29c-a4d44c16abba"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("RequisitionContractFileCreateOrUpdate", "7a975f80-6a8f-475d-a29c-a4d44c16abba", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// CreateOrUpdateRequisitionContractFile
localVars.resCreateOrUpdateRequisitionContractFile_outParamId = await ExtendedActions.CreateOrUpdateRequisitionContractFile(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_471ec64149613ec0a9f3525fc2d9e11c)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateOrUpdateRequisitionContractFile.Id
result.outParamId=localVars.resCreateOrUpdateRequisitionContractFile_outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionRequisitionContractFileCreateOrUpdate {



}


}
