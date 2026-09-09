namespace ssConectaProveedores;

public partial class Actions {
public class lcvApproveMultipleProposalLineApprovalLevel : VarsBag {
public RL_b8bc07441a220c1a5fc88aead339c457 inParami_ProposalLineApprovalLevelIdList;
public Actions.lcoApproveRejectSingleProposalLineApprovalLevel resApproveRejectSingleProposalLineApprovalLevel =  new Actions.lcoApproveRejectSingleProposalLineApprovalLevel();
public lcvApproveMultipleProposalLineApprovalLevel(RL_b8bc07441a220c1a5fc88aead339c457 inParami_ProposalLineApprovalLevelIdList) {
this.inParami_ProposalLineApprovalLevelIdList = inParami_ProposalLineApprovalLevelIdList;
}
}
/// <summary>
/// Action <code>ApproveMultipleProposalLineApprovalLevel</code> that represents the Service Studio
///  action <code>ApproveMultipleProposalLineApprovalLevel</code> <p> Description: Action to approve o
/// r reject ProposalLineApprovalLevels</p>
/// </summary>
public static async Task ActionApproveMultipleProposalLineApprovalLevel(IRequestContext requestContext,RL_b8bc07441a220c1a5fc88aead339c457 inParami_ProposalLineApprovalLevelIdList,CancellationToken cancellationToken) {
lcvApproveMultipleProposalLineApprovalLevel localVars = new lcvApproveMultipleProposalLineApprovalLevel(inParami_ProposalLineApprovalLevelIdList);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("ApproveMultipleProposalLineApprovalLevel", "e93ec8b5-40f3-422c-a112-66c1fb6aba47"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("ApproveMultipleProposalLineApprovalLevel", "e93ec8b5-40f3-422c-a112-66c1fb6aba47", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Foreach i_ProposalLineApprovalLevelIdList
localVars.inParami_ProposalLineApprovalLevelIdList.StartIteration();
try {while (!((localVars.inParami_ProposalLineApprovalLevelIdList.Eof))) {
// ApproveRejectSingleProposalLineApprovalLevel
localVars.resApproveRejectSingleProposalLineApprovalLevel.outParamo_Output = await Actions.ActionApproveRejectSingleProposalLineApprovalLevel(requestContext,localVars.inParami_ProposalLineApprovalLevelIdList.CurrentRec.ssProposalId,localVars.inParami_ProposalLineApprovalLevelIdList.CurrentRec.ssProposalLineApprovalLevelId,false,"",cancellationToken);

localVars.inParami_ProposalLineApprovalLevelIdList.Advance();
}

} finally {
localVars.inParami_ProposalLineApprovalLevelIdList.EndIteration();
}

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionApproveMultipleProposalLineApprovalLevel {



}


}
