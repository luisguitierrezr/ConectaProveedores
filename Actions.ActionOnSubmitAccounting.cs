namespace ssConectaProveedores;

public partial class Actions {
public class lcvOnSubmitAccounting : VarsBag {
public long inParami_InvoiceId;
public long inParami_InvoiceApprovalLevelId;
public bool inParami_IsApprove;
public string inParami_Comment;
public EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord inParami_InvoiceAccounting;
public RL_4d4dc9b85c4a7d6bf03b676c2530ea4f inParami_InvoiceAddendumList;
public EN_f81a3d226103fd013068b8763798067aEntityRecord inParami_InvoiceExtended;
public RL_500d3f017443846ad96a3e45e41bf158 inParami_InvoiceAccountingServicesList;
public bool inParami_IsImport;
public RL_0704e14bc1b3305d76f59d709913c287 inParami_InvoiceAccountingEntries;
public int inParamOffsetUtc;
public Actions.lcoApprovModifInv resApprovModifInv =  new Actions.lcoApprovModifInv();
public Actions.lcoInvoiceAccountingSend resInvoiceAccountingSend =  new Actions.lcoInvoiceAccountingSend();
public lcvOnSubmitAccounting(long inParami_InvoiceId, long inParami_InvoiceApprovalLevelId, bool inParami_IsApprove, string inParami_Comment, EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord inParami_InvoiceAccounting, RL_4d4dc9b85c4a7d6bf03b676c2530ea4f inParami_InvoiceAddendumList, EN_f81a3d226103fd013068b8763798067aEntityRecord inParami_InvoiceExtended, RL_500d3f017443846ad96a3e45e41bf158 inParami_InvoiceAccountingServicesList, bool inParami_IsImport, RL_0704e14bc1b3305d76f59d709913c287 inParami_InvoiceAccountingEntries, int inParamOffsetUtc) {
this.inParami_InvoiceId = inParami_InvoiceId;
this.inParami_InvoiceApprovalLevelId = inParami_InvoiceApprovalLevelId;
this.inParami_IsApprove = inParami_IsApprove;
this.inParami_Comment = inParami_Comment;
this.inParami_InvoiceAccounting = inParami_InvoiceAccounting;
this.inParami_InvoiceAddendumList = inParami_InvoiceAddendumList;
this.inParami_InvoiceExtended = inParami_InvoiceExtended;
this.inParami_InvoiceAccountingServicesList = inParami_InvoiceAccountingServicesList;
this.inParami_IsImport = inParami_IsImport;
this.inParami_InvoiceAccountingEntries = inParami_InvoiceAccountingEntries;
this.inParamOffsetUtc = inParamOffsetUtc;
}
}
public class lcoOnSubmitAccounting : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public bool outParamIsToFinish = false;

public lcoOnSubmitAccounting() {
}
}
/// <summary>
/// Action <code>OnSubmitAccounting</code> that represents the Service Studio action
///  <code>OnSubmitAccounting</code> <p> Description: </p>
/// </summary>
public static async Task<(ST_046fb53ebbe142526d95e87ef1ae9711Structure,bool)> ActionOnSubmitAccounting(IRequestContext requestContext,long inParami_InvoiceId,long inParami_InvoiceApprovalLevelId,bool inParami_IsApprove,string inParami_Comment,EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord inParami_InvoiceAccounting,RL_4d4dc9b85c4a7d6bf03b676c2530ea4f inParami_InvoiceAddendumList,EN_f81a3d226103fd013068b8763798067aEntityRecord inParami_InvoiceExtended,RL_500d3f017443846ad96a3e45e41bf158 inParami_InvoiceAccountingServicesList,bool inParami_IsImport,RL_0704e14bc1b3305d76f59d709913c287 inParami_InvoiceAccountingEntries,int inParamOffsetUtc,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
bool outParamIsToFinish = default;
lcoOnSubmitAccounting result = new lcoOnSubmitAccounting();
lcvOnSubmitAccounting localVars = new lcvOnSubmitAccounting(inParami_InvoiceId, inParami_InvoiceApprovalLevelId, inParami_IsApprove, inParami_Comment, inParami_InvoiceAccounting, inParami_InvoiceAddendumList, inParami_InvoiceExtended, inParami_InvoiceAccountingServicesList, inParami_IsImport, inParami_InvoiceAccountingEntries, inParamOffsetUtc);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("OnSubmitAccounting", "d689569b-925a-4fd1-901e-b229a72a94e1"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("OnSubmitAccounting", "d689569b-925a-4fd1-901e-b229a72a94e1", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// submission?
if(((localVars.inParami_InvoiceAccounting.ssSubmissionBy==BuiltInFunction.NullTextIdentifier ()))) {
// InvoiceAccountingSend
localVars.resInvoiceAccountingSend.outParamErrorMsg = await Actions.ActionInvoiceAccountingSend(requestContext,localVars.inParami_InvoiceId,localVars.inParami_InvoiceAccounting,localVars.inParami_InvoiceAddendumList,localVars.inParami_InvoiceExtended,localVars.inParami_InvoiceAccountingServicesList,localVars.inParami_IsImport,localVars.inParami_InvoiceAccountingEntries,cancellationToken);

// error?
if(((localVars.resInvoiceAccountingSend.outParamErrorMsg!=""))) {
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = InvoiceAccountingSend.ErrorMsg
result.outParamo_Output.ssMessage = localVars.resInvoiceAccountingSend.outParamErrorMsg;
goto RETURN_STATEMENT;

}

}

// ApprovModifInv
(localVars.resApprovModifInv.outParamo_Output,localVars.resApprovModifInv.outParamIsFinish) = await Actions.ActionApprovModifInv(requestContext,localVars.inParami_InvoiceId,localVars.inParami_InvoiceApprovalLevelId,localVars.inParami_IsApprove,localVars.inParami_Comment,localVars.inParamOffsetUtc,"",cancellationToken);

// o_Output = ApprovModifInv.o_Output
result.outParamo_Output=localVars.resApprovModifInv.outParamo_Output;

// IsToFinish = ApprovModifInv.IsFinish
result.outParamIsToFinish=localVars.resApprovModifInv.outParamIsFinish;
} //close CreateActionActivity using block
} // try

finally {
outParamo_Output = result.outParamo_Output;
outParamIsToFinish = result.outParamIsToFinish;
} // inner-finally
RETURN_STATEMENT:
return (outParamo_Output,outParamIsToFinish);
}

public static class FuncActionOnSubmitAccounting {



}


}
