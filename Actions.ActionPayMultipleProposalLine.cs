namespace ssConectaProveedores;

public partial class Actions {
public class lcvPayMultipleProposalLine : VarsBag {
public BasicTypeList<long> inParami_ProposalLinelIdList;
public Actions.lcoPayUnpaySingleProposalLine resPayUnpaySingleProposalLine =  new Actions.lcoPayUnpaySingleProposalLine();
public lcvPayMultipleProposalLine(BasicTypeList<long> inParami_ProposalLinelIdList) {
this.inParami_ProposalLinelIdList = inParami_ProposalLinelIdList;
}
}
public class lcoPayMultipleProposalLine : VarsBag {
public bool outParamo_HasProposalChangedStatus = false;

public lcoPayMultipleProposalLine() {
}
}
/// <summary>
/// Action <code>PayMultipleProposalLine</code> that represents the Service Studio action
///  <code>PayMultipleProposalLine</code> <p> Description: Action to approve or reject 
/// a ProposalLine.</p>
/// </summary>
public static async Task<bool> ActionPayMultipleProposalLine(IRequestContext requestContext,BasicTypeList<long> inParami_ProposalLinelIdList,CancellationToken cancellationToken) {
bool outParamo_HasProposalChangedStatus = default;
lcoPayMultipleProposalLine result = new lcoPayMultipleProposalLine();
lcvPayMultipleProposalLine localVars = new lcvPayMultipleProposalLine(inParami_ProposalLinelIdList);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("PayMultipleProposalLine", "3f2653ce-66b1-4b10-a8d7-628680cde41e"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("PayMultipleProposalLine", "3f2653ce-66b1-4b10-a8d7-628680cde41e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Foreach i_ProposalLinelIdList
localVars.inParami_ProposalLinelIdList.StartIteration();
try {while (!((localVars.inParami_ProposalLinelIdList.Eof))) {
// PayUnpaySingleProposalLine
(localVars.resPayUnpaySingleProposalLine.outParamo_HasProposalChangedStatus,localVars.resPayUnpaySingleProposalLine.outParamo_Output) = await Actions.ActionPayUnpaySingleProposalLine(requestContext,localVars.inParami_ProposalLinelIdList.CurrentRec,true,"",new byte[] {},"",cancellationToken);

// o_HasProposalChangedStatus = If
result.outParamo_HasProposalChangedStatus=((result.outParamo_HasProposalChangedStatus) ? (true) : (localVars.resPayUnpaySingleProposalLine.outParamo_HasProposalChangedStatus));
localVars.inParami_ProposalLinelIdList.Advance();
}

} finally {
localVars.inParami_ProposalLinelIdList.EndIteration();
}

} //close CreateActionActivity using block
} // try

finally {
outParamo_HasProposalChangedStatus = result.outParamo_HasProposalChangedStatus;
} // inner-finally
RETURN_STATEMENT:
return outParamo_HasProposalChangedStatus;
}

public static class FuncActionPayMultipleProposalLine {



}


}
