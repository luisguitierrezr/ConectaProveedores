namespace ssConectaProveedores;

public partial class Actions {
public class lcvApproveRequisitionAccounting : VarsBag {
public RC_cc86cc41f7a6d52842bfa86c15f13d61 inParami_Requisition;
public long inParami_RequisitionApprovalLevelId;
public int inParamOffsetUtc;
public Actions.lcoRequisitionAccountingCreateOrUpdate resRequisitionAccountingCreateOrUpdate =  new Actions.lcoRequisitionAccountingCreateOrUpdate();
public Actions.lcoRequisitionCreateOrUpdate resRequisitionCreateOrUpdate =  new Actions.lcoRequisitionCreateOrUpdate();
public Actions.lcoApprovModifReq resApprovModifReq =  new Actions.lcoApprovModifReq();
public lcvApproveRequisitionAccounting(RC_cc86cc41f7a6d52842bfa86c15f13d61 inParami_Requisition, long inParami_RequisitionApprovalLevelId, int inParamOffsetUtc) {
this.inParami_Requisition = inParami_Requisition;
this.inParami_RequisitionApprovalLevelId = inParami_RequisitionApprovalLevelId;
this.inParamOffsetUtc = inParamOffsetUtc;
}
}
public class lcoApproveRequisitionAccounting : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public lcoApproveRequisitionAccounting() {
}
}
/// <summary>
/// Action <code>ApproveRequisitionAccounting</code> that represents the Service Studio action
///  <code>ApproveRequisitionAccounting</code> <p> Description: </p>
/// </summary>
public static async Task<ST_046fb53ebbe142526d95e87ef1ae9711Structure> ActionApproveRequisitionAccounting(IRequestContext requestContext,RC_cc86cc41f7a6d52842bfa86c15f13d61 inParami_Requisition,long inParami_RequisitionApprovalLevelId,int inParamOffsetUtc,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
lcoApproveRequisitionAccounting result = new lcoApproveRequisitionAccounting();
lcvApproveRequisitionAccounting localVars = new lcvApproveRequisitionAccounting(inParami_Requisition, inParami_RequisitionApprovalLevelId, inParamOffsetUtc);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("ApproveRequisitionAccounting", "e32ff10c-c525-4d46-9d1c-74cfd1f04bd8"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("ApproveRequisitionAccounting", "e32ff10c-c525-4d46-9d1c-74cfd1f04bd8", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// RequisitionCreateOrUpdate
localVars.resRequisitionCreateOrUpdate.outParamId = await Actions.ActionRequisitionCreateOrUpdate(requestContext,localVars.inParami_Requisition.ssENRequisition,cancellationToken);

// SaveRequisitionFiles
await Actions.ActionSaveRequisitionFiles(requestContext,localVars.inParami_Requisition.ssENRequisition.ssId,new RC_d66b0b09097e5f0bc1ec31076e9aa762(){ ssRLAllFiles = localVars.inParami_Requisition.ssRLAllFiles, ssENRequisition = localVars.inParami_Requisition.ssENRequisition },cancellationToken);

// RequisitionAccountingCreateOrUpdate
localVars.resRequisitionAccountingCreateOrUpdate.outParamId = await Actions.ActionRequisitionAccountingCreateOrUpdate(requestContext,localVars.inParami_Requisition.ssENRequisitionAccounting,cancellationToken);

// SaveRequisitionAccConcepts
await Actions.ActionSaveRequisitionAccConcepts(requestContext,localVars.inParami_Requisition.ssENRequisition.ssId,(await RL_eb1e4f883a237aab70c23418de71281c.ConvertAsync(localVars.inParami_Requisition.ssRLRequisitionAccConcepts, new RL_eb1e4f883a237aab70c23418de71281c(), async (RC_f80fde4acf9a7dc465a1d535c05dfb8e source, EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord target, CancellationToken cancellationToken) => {
target = source.ssENRequisitionAccConcepts;
return target;
}, cancellationToken)),(await RecordUtils.ConvertAsync(localVars.inParami_Requisition.ssRCi_RequisitionAccConcept_EstimEqualAg, new RC_baf165956df9a5eebdc813b129b5fb73(), async (RC_cdb29de40f41bea5403aac7edb2d6159 source, RC_baf165956df9a5eebdc813b129b5fb73 target, CancellationToken cancellationToken) => {
target.ssENMainAccConcepts = source.ssENMainAccConcept;
target.ssRLSubAccConcepts = source.ssRLSubAccConcepts;
return target;
}, cancellationToken)),cancellationToken);

// ApprovModifReq
localVars.resApprovModifReq.outParamo_Output = await Actions.ActionApprovModifReq(requestContext,localVars.inParami_Requisition.ssENRequisition.ssId,localVars.inParami_RequisitionApprovalLevelId,true,"",localVars.inParamOffsetUtc,"",cancellationToken);

if(((!localVars.resApprovModifReq.outParamo_Output.ssIsSuccess))) {
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = ApprovModifReq.o_Output.Message
result.outParamo_Output.ssMessage = localVars.resApprovModifReq.outParamo_Output.ssMessage;
} else {
// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
}

} //close CreateActionActivity using block
} // try

finally {
outParamo_Output = result.outParamo_Output;
} // inner-finally
RETURN_STATEMENT:
return outParamo_Output;
}

public static class FuncActionApproveRequisitionAccounting {



}


}
