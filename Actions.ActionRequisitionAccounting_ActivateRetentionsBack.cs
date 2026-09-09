namespace ssConectaProveedores;

public partial class Actions {
public class lcvRequisitionAccounting_ActivateRetentionsBack : VarsBag {
public string inParamCompanyExternalId;
public string inParamSupplierNr;
public RL_725bda958021cd78431a036d1def2d7e inParamRetentionsToActivate;
public Actions.lcoLogsAccountingCreate resLogsAccountingCreate =  new Actions.lcoLogsAccountingCreate();
public Actions.lcoLogsAccountingCreate resLogsAccountingCreate3 =  new Actions.lcoLogsAccountingCreate();
public ST_b29967856499aeaa8c796dc87fe4c6e8Structure resCall_ZMXFFIMF_INSERT_UPDROV_outParamResponse = new ST_b29967856499aeaa8c796dc87fe4c6e8Structure();

public lcvRequisitionAccounting_ActivateRetentionsBack(string inParamCompanyExternalId, string inParamSupplierNr, RL_725bda958021cd78431a036d1def2d7e inParamRetentionsToActivate) {
this.inParamCompanyExternalId = inParamCompanyExternalId;
this.inParamSupplierNr = inParamSupplierNr;
this.inParamRetentionsToActivate = inParamRetentionsToActivate;
}
}
public class lcoRequisitionAccounting_ActivateRetentionsBack : VarsBag {
public bool outParamIsSuccess = true;

public string outParamMessage = "";

public lcoRequisitionAccounting_ActivateRetentionsBack() {
}
}
/// <summary>
/// Action <code>RequisitionAccounting_ActivateRetentionsBack</code> that represents the Service Studio
///  action <code>RequisitionAccounting_ActivateRetentionsBack</code> <p> Description: </p>
/// </summary>
public static async Task<(bool,string)> ActionRequisitionAccounting_ActivateRetentionsBack(IRequestContext requestContext,string inParamCompanyExternalId,string inParamSupplierNr,RL_725bda958021cd78431a036d1def2d7e inParamRetentionsToActivate,CancellationToken cancellationToken) {
bool outParamIsSuccess = default;
string outParamMessage = default;
lcoRequisitionAccounting_ActivateRetentionsBack result = new lcoRequisitionAccounting_ActivateRetentionsBack();
lcvRequisitionAccounting_ActivateRetentionsBack localVars = new lcvRequisitionAccounting_ActivateRetentionsBack(inParamCompanyExternalId, inParamSupplierNr, inParamRetentionsToActivate);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("RequisitionAccounting_ActivateRetentionsBack", "d214963b-b865-4c89-af98-86f931b81e25"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("RequisitionAccounting_ActivateRetentionsBack", "d214963b-b865-4c89-af98-86f931b81e25", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// no retentions
if((!(localVars.inParamRetentionsToActivate.Empty))) {
// LogsAccountingCreate3
localVars.resLogsAccountingCreate3.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = ("Before Contab - Retentions Req Supplier"+localVars.inParamSupplierNr), ssDescription = ((((("PI_BUKRS "+localVars.inParamSupplierNr)+" // PI_VENDORNO ")+localVars.inParamSupplierNr)+"// RETENCION 1 ")+localVars.inParamRetentionsToActivate.CurrentRec.ssWITHT), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("MrwNippcb0yd3p9+9UP4UQ"))).ssId },cancellationToken);

// Call_ZMXFFIMF_INSERT_UPDROV
localVars.resCall_ZMXFFIMF_INSERT_UPDROV_outParamResponse = await ServiceAPIs.ServiceAPICall_ZMXFFIMF_INSERT_UPDROV(requestContext,new ST_90ad61a7b6c3b8dc6db7b1d64798236bStructure(){ ssPI_BUKRS = localVars.inParamCompanyExternalId, ssPI_VENDORNO = localVars.inParamSupplierNr, ssTI_RETENCIONES_In = localVars.inParamRetentionsToActivate },cancellationToken);

// IsSuccess = Index <> -1
result.outParamIsSuccess=(BuiltInFunction.IndexSC (localVars.resCall_ZMXFFIMF_INSERT_UPDROV_outParamResponse.ssPO_RESPUESTA, "S -", 0, false, false)!=(-1));

// Message = Call_ZMXFFIMF_INSERT_UPDROV.Response.PO_RESPUESTA
result.outParamMessage=localVars.resCall_ZMXFFIMF_INSERT_UPDROV_outParamResponse.ssPO_RESPUESTA;
// LogsAccountingCreate
localVars.resLogsAccountingCreate.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = ("Before Contab - Retentions Req Supplier"+localVars.inParamSupplierNr), ssDescription = ("RESPUESTA "+BuiltInFunction.SubstrSC (localVars.resCall_ZMXFFIMF_INSERT_UPDROV_outParamResponse.ssPO_RESPUESTA, 0, 50)), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("MrwNippcb0yd3p9+9UP4UQ"))).ssId },cancellationToken);

}

} //close CreateActionActivity using block
} // try

finally {
outParamIsSuccess = result.outParamIsSuccess;
outParamMessage = result.outParamMessage;
} // inner-finally
RETURN_STATEMENT:
return (outParamIsSuccess,outParamMessage);
}

public static class FuncActionRequisitionAccounting_ActivateRetentionsBack {



}


}
