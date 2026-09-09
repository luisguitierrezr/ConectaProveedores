namespace ssConectaProveedores;

public partial class Actions {
public class lcvInvoiceTaxesRetentionRulesReset : VarsBag {
public long inParamInvoiceId;
public RL_725bda958021cd78431a036d1def2d7e inParamRetentionsConsultList;
public RL_725bda958021cd78431a036d1def2d7e resListFilter_outParamFilteredList = new RL_725bda958021cd78431a036d1def2d7e();

public RL_725bda958021cd78431a036d1def2d7e resListFilter2_outParamFilteredList = new RL_725bda958021cd78431a036d1def2d7e();

public Actions.lcoInvoiceTaxesRetentionRules_ByInvoiceId resInvoiceTaxesRetentionRules_ByInvoiceId =  new Actions.lcoInvoiceTaxesRetentionRules_ByInvoiceId();
public lcvInvoiceTaxesRetentionRulesReset(long inParamInvoiceId, RL_725bda958021cd78431a036d1def2d7e inParamRetentionsConsultList) {
this.inParamInvoiceId = inParamInvoiceId;
this.inParamRetentionsConsultList = inParamRetentionsConsultList;
}
}
public class lcoInvoiceTaxesRetentionRulesReset : VarsBag {
public RL_725bda958021cd78431a036d1def2d7e outParamRetentionsCall1List = new RL_725bda958021cd78431a036d1def2d7e();

public RL_725bda958021cd78431a036d1def2d7e outParamRetentionsCall2List = new RL_725bda958021cd78431a036d1def2d7e();

public bool outParamIsToCancel = false;

public lcoInvoiceTaxesRetentionRulesReset() {
}
}
/// <summary>
/// Action <code>InvoiceTaxesRetentionRulesReset</code> that represents the Service Studio action
///  <code>InvoiceTaxesRetentionRulesReset</code> <p> Description: </p>
/// </summary>
public static async Task<(RL_725bda958021cd78431a036d1def2d7e,RL_725bda958021cd78431a036d1def2d7e,bool)> ActionInvoiceTaxesRetentionRulesReset(IRequestContext requestContext,long inParamInvoiceId,RL_725bda958021cd78431a036d1def2d7e inParamRetentionsConsultList,CancellationToken cancellationToken) {
RL_725bda958021cd78431a036d1def2d7e outParamRetentionsCall1List = default;
RL_725bda958021cd78431a036d1def2d7e outParamRetentionsCall2List = default;
bool outParamIsToCancel = default;
lcoInvoiceTaxesRetentionRulesReset result = new lcoInvoiceTaxesRetentionRulesReset();
lcvInvoiceTaxesRetentionRulesReset localVars = new lcvInvoiceTaxesRetentionRulesReset(inParamInvoiceId, inParamRetentionsConsultList);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InvoiceTaxesRetentionRulesReset", "52751620-ea4e-4065-bc1a-8698246dccb1"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InvoiceTaxesRetentionRulesReset", "52751620-ea4e-4065-bc1a-8698246dccb1", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// InvoiceTaxesRetentionRules_ByInvoiceId
(localVars.resInvoiceTaxesRetentionRules_ByInvoiceId.outParamRetentionsActivationList,localVars.resInvoiceTaxesRetentionRules_ByInvoiceId.outParamIsToCancel) = await Actions.ActionInvoiceTaxesRetentionRules_ByInvoiceId(requestContext,localVars.inParamInvoiceId,cancellationToken);

// cancel
if((localVars.resInvoiceTaxesRetentionRules_ByInvoiceId.outParamIsToCancel)) {
// IsToCancel = True
result.outParamIsToCancel=true;
} else {
// RetentionsCall1List = InvoiceTaxesRetentionRules_ByInvoiceId.RetentionsActivationList
result.outParamRetentionsCall1List=localVars.resInvoiceTaxesRetentionRules_ByInvoiceId.outParamRetentionsActivationList;
// Foreach RetentionsConsultList
localVars.inParamRetentionsConsultList.StartIteration();
try {while (!((localVars.inParamRetentionsConsultList.Eof))) {
// ListFilter
localVars.resListFilter_outParamFilteredList = (((RL_725bda958021cd78431a036d1def2d7e)await  localVars.resInvoiceTaxesRetentionRules_ByInvoiceId.outParamRetentionsActivationList.FilterAsync(async (p, cancellationToken) => (p.ssWITHT==localVars.inParamRetentionsConsultList.CurrentRec.ssWITHT), cancellationToken)));

// exists?
if((!((!localVars.resListFilter_outParamFilteredList.Empty)))) {
// ListAppend
await ExtendedActions.ListAppend(requestContext,result.outParamRetentionsCall1List,new ST_57edec30140ebe846267970253841d11Structure(){ ssWITHT = localVars.inParamRetentionsConsultList.CurrentRec.ssWITHT, ssWT_WITHCD = localVars.inParamRetentionsConsultList.CurrentRec.ssWT_WITHCD, ssWT_SUBJCT = "" },cancellationToken);

// ListAppend3
await ExtendedActions.ListAppend(requestContext,result.outParamRetentionsCall2List,localVars.inParamRetentionsConsultList.CurrentRec,cancellationToken);

}

localVars.inParamRetentionsConsultList.Advance();
}

} finally {
localVars.inParamRetentionsConsultList.EndIteration();
}

// Foreach InvoiceTaxesRetentionRules_ByInvoiceId.RetentionsActivationList
localVars.resInvoiceTaxesRetentionRules_ByInvoiceId.outParamRetentionsActivationList.StartIteration();
try {while (!((localVars.resInvoiceTaxesRetentionRules_ByInvoiceId.outParamRetentionsActivationList.Eof))) {
// ListFilter2
localVars.resListFilter2_outParamFilteredList = (((RL_725bda958021cd78431a036d1def2d7e)await  localVars.inParamRetentionsConsultList.FilterAsync(async (p, cancellationToken) => (p.ssWITHT==localVars.resInvoiceTaxesRetentionRules_ByInvoiceId.outParamRetentionsActivationList.CurrentRec.ssWITHT), cancellationToken)));

// ListAppend2
await ExtendedActions.ListAppend(requestContext,result.outParamRetentionsCall2List,new ST_57edec30140ebe846267970253841d11Structure(){ ssWITHT = localVars.resInvoiceTaxesRetentionRules_ByInvoiceId.outParamRetentionsActivationList.CurrentRec.ssWITHT, ssWT_WITHCD = localVars.resInvoiceTaxesRetentionRules_ByInvoiceId.outParamRetentionsActivationList.CurrentRec.ssWT_WITHCD, ssWT_SUBJCT = ((localVars.resListFilter2_outParamFilteredList.Empty) ? ("") : (localVars.resListFilter2_outParamFilteredList.CurrentRec.ssWT_SUBJCT)) },cancellationToken);

localVars.resInvoiceTaxesRetentionRules_ByInvoiceId.outParamRetentionsActivationList.Advance();
}

} finally {
localVars.resInvoiceTaxesRetentionRules_ByInvoiceId.outParamRetentionsActivationList.EndIteration();
}

}

} //close CreateActionActivity using block
} // try

finally {
outParamRetentionsCall1List = result.outParamRetentionsCall1List;
outParamRetentionsCall2List = result.outParamRetentionsCall2List;
outParamIsToCancel = result.outParamIsToCancel;
} // inner-finally
RETURN_STATEMENT:
return (outParamRetentionsCall1List,outParamRetentionsCall2List,outParamIsToCancel);
}

public static class FuncActionInvoiceTaxesRetentionRulesReset {



}


}
