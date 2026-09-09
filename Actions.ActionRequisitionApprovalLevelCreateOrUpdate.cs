namespace ssConectaProveedores;

public partial class Actions {
public class lcvRequisitionApprovalLevelCreateOrUpdate : VarsBag {
public EN_27b1469f497d364a764a1359956ef9adEntityRecord inParamSource;
public long resCreateOrUpdateRequisitionApprovalLevel_outParamId = 0L;

public lcvRequisitionApprovalLevelCreateOrUpdate(EN_27b1469f497d364a764a1359956ef9adEntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoRequisitionApprovalLevelCreateOrUpdate : VarsBag {
public long outParamId = 0L;

public lcoRequisitionApprovalLevelCreateOrUpdate() {
}
}
/// <summary>
/// Action <code>RequisitionApprovalLevelCreateOrUpdate</code> that represents the Service Studio
///  action <code>RequisitionApprovalLevelCreateOrUpdate</code> <p> Description: Encapsulates th
/// e CreateOrUpdate entity action, enabling logic to run consistently before and after a record is
///  created or modified.</p>
/// </summary>
public static async Task<long> ActionRequisitionApprovalLevelCreateOrUpdate(IRequestContext requestContext,EN_27b1469f497d364a764a1359956ef9adEntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoRequisitionApprovalLevelCreateOrUpdate result = new lcoRequisitionApprovalLevelCreateOrUpdate();
lcvRequisitionApprovalLevelCreateOrUpdate localVars = new lcvRequisitionApprovalLevelCreateOrUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("RequisitionApprovalLevelCreateOrUpdate", "438a340a-c038-4558-a5f7-34d0479da556"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("RequisitionApprovalLevelCreateOrUpdate", "438a340a-c038-4558-a5f7-34d0479da556", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// CreateOrUpdateRequisitionApprovalLevel
localVars.resCreateOrUpdateRequisitionApprovalLevel_outParamId = await ExtendedActions.CreateOrUpdateRequisitionApprovalLevel(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_5404698ef74632f0bc59763509d95177)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateOrUpdateRequisitionApprovalLevel.Id
result.outParamId=localVars.resCreateOrUpdateRequisitionApprovalLevel_outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionRequisitionApprovalLevelCreateOrUpdate {



}


}
