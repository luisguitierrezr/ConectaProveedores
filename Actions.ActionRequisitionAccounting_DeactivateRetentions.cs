namespace ssConectaProveedores;

public partial class Actions {
public class lcvRequisitionAccounting_DeactivateRetentions : VarsBag {
public string inParamCompanyExternalId;
public string inParamSupplierNr;
/// <summary>
/// Variable <code>RetentionsToDeactivate</code> that represents the Service Studio
///  TI_RETENCIONES_In3List <code>RetentionsToDeactivate</code> <p>Description: </p>
/// </summary>
public RL_725bda958021cd78431a036d1def2d7e varLcRetentionsToDeactivate = new RL_725bda958021cd78431a036d1def2d7e();

public Actions.lcoLogsAccountingCreate resLogsAccountingCreate =  new Actions.lcoLogsAccountingCreate();
public ST_24353ddcec93ac51b13ce9ab94fe4001Structure resCall_ZMXFAPMF_CONSUL_RETENPROV_outParamResponse = new ST_24353ddcec93ac51b13ce9ab94fe4001Structure();

public ST_b29967856499aeaa8c796dc87fe4c6e8Structure resCall_ZMXFFIMF_INSERT_UPDROV_outParamResponse = new ST_b29967856499aeaa8c796dc87fe4c6e8Structure();

public Actions.lcoLogsAccountingCreate resLogsAccountingCreate3 =  new Actions.lcoLogsAccountingCreate();
public lcvRequisitionAccounting_DeactivateRetentions(string inParamCompanyExternalId, string inParamSupplierNr) {
this.inParamCompanyExternalId = inParamCompanyExternalId;
this.inParamSupplierNr = inParamSupplierNr;
}
}
public class lcoRequisitionAccounting_DeactivateRetentions : VarsBag {
public bool outParamIsSuccess = true;

public string outParamMessage = "";

public RL_725bda958021cd78431a036d1def2d7e outParamRetentionsToActivate = new RL_725bda958021cd78431a036d1def2d7e();

public lcoRequisitionAccounting_DeactivateRetentions() {
}
}
/// <summary>
/// Action <code>RequisitionAccounting_DeactivateRetentions</code> that represents the Service Studio
///  action <code>RequisitionAccounting_DeactivateRetentions</code> <p> Description: </p>
/// </summary>
public static async Task<(bool,string,RL_725bda958021cd78431a036d1def2d7e)> ActionRequisitionAccounting_DeactivateRetentions(IRequestContext requestContext,string inParamCompanyExternalId,string inParamSupplierNr,CancellationToken cancellationToken) {
bool outParamIsSuccess = default;
string outParamMessage = default;
RL_725bda958021cd78431a036d1def2d7e outParamRetentionsToActivate = default;
lcoRequisitionAccounting_DeactivateRetentions result = new lcoRequisitionAccounting_DeactivateRetentions();
lcvRequisitionAccounting_DeactivateRetentions localVars = new lcvRequisitionAccounting_DeactivateRetentions(inParamCompanyExternalId, inParamSupplierNr);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("RequisitionAccounting_DeactivateRetentions", "62de55a5-3625-4234-b2f8-503d6ffb83b4"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("RequisitionAccounting_DeactivateRetentions", "62de55a5-3625-4234-b2f8-503d6ffb83b4", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Call_ZMXFAPMF_CONSUL_RETENPROV
localVars.resCall_ZMXFAPMF_CONSUL_RETENPROV_outParamResponse = await ServiceAPIs.ServiceAPICall_ZMXFAPMF_CONSUL_RETENPROV(requestContext,new ST_4a83d254a5f7ac76f9d0f873e58d9ba4Structure(){ ssPI_BUKRS = localVars.inParamCompanyExternalId, ssPI_VENDORNO = localVars.inParamSupplierNr },cancellationToken);

// consult error?
if((((localVars.resCall_ZMXFAPMF_CONSUL_RETENPROV_outParamResponse.ssPO_RESPUESTA=="")&&(!((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveSkipAccountingError]))))))) {
// IsSuccess = False
result.outParamIsSuccess=false;

// Message = Call_ZMXFAPMF_CONSUL_RETENPROV.Response.PO_RESPUESTA
result.outParamMessage=localVars.resCall_ZMXFAPMF_CONSUL_RETENPROV_outParamResponse.ssPO_RESPUESTA;
} else {
// no retentions
if((!(localVars.resCall_ZMXFAPMF_CONSUL_RETENPROV_outParamResponse.ssTI_RETENCIONES_Out.Empty))) {
// ListAppendAll
await ExtendedActions.ListAppendAll(requestContext,result.outParamRetentionsToActivate,(await RL_725bda958021cd78431a036d1def2d7e.ConvertAsync(localVars.resCall_ZMXFAPMF_CONSUL_RETENPROV_outParamResponse.ssTI_RETENCIONES_Out, new RL_725bda958021cd78431a036d1def2d7e(), async (ST_9e0fb2735a5b1c9875cbba9ab856e646Structure source, ST_57edec30140ebe846267970253841d11Structure target, CancellationToken cancellationToken) => {
target.ssWITHT = source.ssWITHT;
target.ssWT_WITHCD = source.ssWT_WITHCD;
target.ssWT_SUBJCT = source.ssWT_SUBJCT;
return target;
}, cancellationToken)),cancellationToken);

// Foreach Call_ZMXFAPMF_CONSUL_RETENPROV.Response.TI_RETENCIONES_Out
localVars.resCall_ZMXFAPMF_CONSUL_RETENPROV_outParamResponse.ssTI_RETENCIONES_Out.StartIteration();
try {while (!((localVars.resCall_ZMXFAPMF_CONSUL_RETENPROV_outParamResponse.ssTI_RETENCIONES_Out.Eof))) {
// ListAppend2
await ExtendedActions.ListAppend(requestContext,localVars.varLcRetentionsToDeactivate,new ST_57edec30140ebe846267970253841d11Structure(){ ssWITHT = localVars.resCall_ZMXFAPMF_CONSUL_RETENPROV_outParamResponse.ssTI_RETENCIONES_Out.CurrentRec.ssWITHT, ssWT_WITHCD = localVars.resCall_ZMXFAPMF_CONSUL_RETENPROV_outParamResponse.ssTI_RETENCIONES_Out.CurrentRec.ssWT_WITHCD, ssWT_SUBJCT = "" },cancellationToken);

localVars.resCall_ZMXFAPMF_CONSUL_RETENPROV_outParamResponse.ssTI_RETENCIONES_Out.Advance();
}

} finally {
localVars.resCall_ZMXFAPMF_CONSUL_RETENPROV_outParamResponse.ssTI_RETENCIONES_Out.EndIteration();
}

// LogsAccountingCreate3
localVars.resLogsAccountingCreate3.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = ("Before Contab - Retentions Req Supplier "+localVars.inParamSupplierNr), ssDescription = ((((("PI_BUKRS "+localVars.inParamCompanyExternalId)+" // PI_VENDORNO ")+localVars.inParamSupplierNr)+"// RETENCION 1 ")+localVars.varLcRetentionsToDeactivate.CurrentRec.ssWITHT), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("MrwNippcb0yd3p9+9UP4UQ"))).ssId },cancellationToken);

// Call_ZMXFFIMF_INSERT_UPDROV
localVars.resCall_ZMXFFIMF_INSERT_UPDROV_outParamResponse = await ServiceAPIs.ServiceAPICall_ZMXFFIMF_INSERT_UPDROV(requestContext,new ST_90ad61a7b6c3b8dc6db7b1d64798236bStructure(){ ssPI_BUKRS = localVars.inParamCompanyExternalId, ssPI_VENDORNO = localVars.inParamSupplierNr, ssTI_RETENCIONES_In = localVars.varLcRetentionsToDeactivate },cancellationToken);

// IsSuccess = Index <> -1
result.outParamIsSuccess=(BuiltInFunction.IndexSC (localVars.resCall_ZMXFFIMF_INSERT_UPDROV_outParamResponse.ssPO_RESPUESTA, "S -", 0, false, false)!=(-1));

// Message = Call_ZMXFFIMF_INSERT_UPDROV.Response.PO_RESPUESTA
result.outParamMessage=localVars.resCall_ZMXFFIMF_INSERT_UPDROV_outParamResponse.ssPO_RESPUESTA;
// LogsAccountingCreate
localVars.resLogsAccountingCreate.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = ("Before Contab - Retentions Req Supplier "+localVars.inParamSupplierNr), ssDescription = ("RESPUESTA "+BuiltInFunction.SubstrSC (localVars.resCall_ZMXFFIMF_INSERT_UPDROV_outParamResponse.ssPO_RESPUESTA, 0, 50)), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("MrwNippcb0yd3p9+9UP4UQ"))).ssId },cancellationToken);

}

}

} //close CreateActionActivity using block
} // try

finally {
outParamIsSuccess = result.outParamIsSuccess;
outParamMessage = result.outParamMessage;
outParamRetentionsToActivate = result.outParamRetentionsToActivate;
} // inner-finally
RETURN_STATEMENT:
return (outParamIsSuccess,outParamMessage,outParamRetentionsToActivate);
}

public static class FuncActionRequisitionAccounting_DeactivateRetentions {



}


}
