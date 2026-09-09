namespace ssConectaProveedores;

public partial class Actions {
public class lcvProposalLogAdd : VarsBag {
public long inParami_ProposalId;
public long inParami_ProposalLineId;
public string inParami_UserId;
public string inParami_Message;
public bool inParami_IsError;
public long resCreateProposalLogs_outParamId = 0L;

public lcvProposalLogAdd(long inParami_ProposalId, long inParami_ProposalLineId, string inParami_UserId, string inParami_Message, bool inParami_IsError) {
this.inParami_ProposalId = inParami_ProposalId;
this.inParami_ProposalLineId = inParami_ProposalLineId;
this.inParami_UserId = inParami_UserId;
this.inParami_Message = inParami_Message;
this.inParami_IsError = inParami_IsError;
}
}
public class lcoProposalLogAdd : VarsBag {
public long outParamo_ProposalLogId = 0L;

public lcoProposalLogAdd() {
}
}
/// <summary>
/// Action <code>ProposalLogAdd</code> that represents the Service Studio action
///  <code>ProposalLogAdd</code> <p> Description: Action to add a log refering the proposal</p>
/// </summary>
public static async Task<long> ActionProposalLogAdd(IRequestContext requestContext,long inParami_ProposalId,long inParami_ProposalLineId,string inParami_UserId,string inParami_Message,bool inParami_IsError,CancellationToken cancellationToken) {
long outParamo_ProposalLogId = default;
lcoProposalLogAdd result = new lcoProposalLogAdd();
lcvProposalLogAdd localVars = new lcvProposalLogAdd(inParami_ProposalId, inParami_ProposalLineId, inParami_UserId, inParami_Message, inParami_IsError);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("ProposalLogAdd", "fe04a52b-1f9f-490d-9e39-36aadb43d807"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("ProposalLogAdd", "fe04a52b-1f9f-490d-9e39-36aadb43d807", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// CreateProposalLogs
localVars.resCreateProposalLogs_outParamId = await ExtendedActions.CreateProposalLogs(requestContext,new RC_42d297db5356ec5acb8465e0977849c0(){ ssENProposalLogs = new EN_013f76cfa3062515b73935963b1697b0EntityRecord(){ ssProposalId = localVars.inParami_ProposalId, ssProposalLineId = localVars.inParami_ProposalLineId, ssCreatedBy = localVars.inParami_UserId, ssCreatedOn = BuiltInFunction.CurrDateTime (), ssMessage = localVars.inParami_Message, ssIsError = localVars.inParami_IsError } },cancellationToken);

// o_ProposalLogId = CreateProposalLogs.Id
result.outParamo_ProposalLogId=localVars.resCreateProposalLogs_outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamo_ProposalLogId = result.outParamo_ProposalLogId;
} // inner-finally
RETURN_STATEMENT:
return outParamo_ProposalLogId;
}

public static class FuncActionProposalLogAdd {



}


}
