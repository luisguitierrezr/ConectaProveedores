namespace ssConectaProveedores;

public partial class Actions {
public class lcvUploadInvoiceFiles_2ForeignerCreate : VarsBag {
public long inParamInvoiceId;
public long inParamRequisitionId;
public long inParamFolioId;
public long inParamOrderMainId;
public RL_7b4ceb84b6a1255d3a42c8932279bc3c inParamFilesList;
public RL_7b4ceb84b6a1255d3a42c8932279bc3c inParamExtraFilesList;
public bool inParamIsStartApproval;
public ST_6f620840109ac6f721328b723ec0152cStructure inParamInvoiceForeign;
public ST_452088c4ad7c6718df20290248661783Structure inParamUploadValidationData;
public long inParamOrderAccConceptsID;
public Actions.lcoInvoiceCreateOrUpdate resInvoiceCreateOrUpdate =  new Actions.lcoInvoiceCreateOrUpdate();
public Actions.lcoInitializeInvoiceWF_Concept resInitializeInvoiceWF_Concept =  new Actions.lcoInitializeInvoiceWF_Concept();
public Actions.lcoInvoiceExtendedForeignerCreateOrUpdate resInvoiceExtendedForeignerCreateOrUpdate =  new Actions.lcoInvoiceExtendedForeignerCreateOrUpdate();
public lcvUploadInvoiceFiles_2ForeignerCreate(long inParamInvoiceId, long inParamRequisitionId, long inParamFolioId, long inParamOrderMainId, RL_7b4ceb84b6a1255d3a42c8932279bc3c inParamFilesList, RL_7b4ceb84b6a1255d3a42c8932279bc3c inParamExtraFilesList, bool inParamIsStartApproval, ST_6f620840109ac6f721328b723ec0152cStructure inParamInvoiceForeign, ST_452088c4ad7c6718df20290248661783Structure inParamUploadValidationData, long inParamOrderAccConceptsID) {
this.inParamInvoiceId = inParamInvoiceId;
this.inParamRequisitionId = inParamRequisitionId;
this.inParamFolioId = inParamFolioId;
this.inParamOrderMainId = inParamOrderMainId;
this.inParamFilesList = inParamFilesList;
this.inParamExtraFilesList = inParamExtraFilesList;
this.inParamIsStartApproval = inParamIsStartApproval;
this.inParamInvoiceForeign = inParamInvoiceForeign;
this.inParamUploadValidationData = inParamUploadValidationData;
this.inParamOrderAccConceptsID = inParamOrderAccConceptsID;
}
}
public class lcoUploadInvoiceFiles_2ForeignerCreate : VarsBag {
public string outParamErrorMsg = "";

public long outParamInvoiceId_Out = 0L;

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord outParamInvoice_Out = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();

public lcoUploadInvoiceFiles_2ForeignerCreate() {
}
}
/// <summary>
/// Action <code>UploadInvoiceFiles_2ForeignerCreate</code> that represents the Service Studio action
///  <code>UploadInvoiceFiles_2ForeignerCreate</code> <p> Description: </p>
/// </summary>
public static async Task<(string,long,EN_d1d0320db36efbb094ad0082361435a0EntityRecord)> ActionUploadInvoiceFiles_2ForeignerCreate(IRequestContext requestContext,long inParamInvoiceId,long inParamRequisitionId,long inParamFolioId,long inParamOrderMainId,RL_7b4ceb84b6a1255d3a42c8932279bc3c inParamFilesList,RL_7b4ceb84b6a1255d3a42c8932279bc3c inParamExtraFilesList,bool inParamIsStartApproval,ST_6f620840109ac6f721328b723ec0152cStructure inParamInvoiceForeign,ST_452088c4ad7c6718df20290248661783Structure inParamUploadValidationData,long inParamOrderAccConceptsID,CancellationToken cancellationToken) {
string outParamErrorMsg = default;
long outParamInvoiceId_Out = default;
EN_d1d0320db36efbb094ad0082361435a0EntityRecord outParamInvoice_Out = default;
lcoUploadInvoiceFiles_2ForeignerCreate result = new lcoUploadInvoiceFiles_2ForeignerCreate();
lcvUploadInvoiceFiles_2ForeignerCreate localVars = new lcvUploadInvoiceFiles_2ForeignerCreate(inParamInvoiceId, inParamRequisitionId, inParamFolioId, inParamOrderMainId, inParamFilesList, inParamExtraFilesList, inParamIsStartApproval, inParamInvoiceForeign, inParamUploadValidationData, inParamOrderAccConceptsID);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("UploadInvoiceFiles_2ForeignerCreate", "057a2b67-6bce-4c3b-9bb4-f7929dfb3e33"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("UploadInvoiceFiles_2ForeignerCreate", "057a2b67-6bce-4c3b-9bb4-f7929dfb3e33", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// no owner
if((((localVars.inParamRequisitionId==Convert.ToInt64(BuiltInFunction.NullIdentifier ()))&&(localVars.inParamFolioId==Convert.ToInt64(BuiltInFunction.NullIdentifier ()))))) {
// Invoice_Out.Name = Substr
result.outParamInvoice_Out.ssName = BuiltInFunction.SubstrSC (localVars.inParamFilesList.CurrentRec.ssName, 0, BuiltInFunction.IndexSC (localVars.inParamFilesList.CurrentRec.ssName, ".", 0, false, false));

// Invoice_Out.Currency = InvoiceForeign.Currency
result.outParamInvoice_Out.ssCurrency = localVars.inParamInvoiceForeign.ssCurrency;

// Invoice_Out.TotalAmount = TextToDecimal
result.outParamInvoice_Out.ssTotalAmount = BuiltInFunction.TextToDecimal (localVars.inParamInvoiceForeign.ssTotalAmount);
} else {
// InvoiceCreateOrUpdate
localVars.resInvoiceCreateOrUpdate.outParamId = await Actions.ActionInvoiceCreateOrUpdate(requestContext,new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(){ ssId = localVars.inParamInvoiceId, ssName = BuiltInFunction.SubstrSC (localVars.inParamFilesList.CurrentRec.ssName, 0, BuiltInFunction.IndexSC (localVars.inParamFilesList.CurrentRec.ssName, ".", 0, false, false)), ssRequisitionId = localVars.inParamRequisitionId, ssFolioId = localVars.inParamFolioId, ssOrderMainId = localVars.inParamOrderMainId, ssCFDITypeId = BuiltInFunction.NullIdentifier (), ssTotalAmount = BuiltInFunction.TextToDecimal (localVars.inParamInvoiceForeign.ssTotalAmount), ssCurrency = localVars.inParamInvoiceForeign.ssCurrency, ssInvoiceStatusId = ((localVars.inParamIsStartApproval) ? ((ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("Q66zN8rsbUynn1JzTqzCFA"))).ssId) : ((ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("Wo+LRDF_n0O7Fo8ikSEsSA"))).ssId)), ssSubmittedOn = BuiltInFunction.TextToDate (localVars.inParamInvoiceForeign.ssInvoiceDate), ssOrderAccConceptsID = localVars.inParamOrderAccConceptsID },localVars.inParamIsStartApproval,cancellationToken);

// InvoiceId_Out = InvoiceCreateOrUpdate.Id
result.outParamInvoiceId_Out=localVars.resInvoiceCreateOrUpdate.outParamId;
// UploadInvoiceFiles_CreateFiles
await Actions.ActionUploadInvoiceFiles_CreateFiles(requestContext,localVars.inParamFilesList,localVars.inParamExtraFilesList,localVars.resInvoiceCreateOrUpdate.outParamId,cancellationToken);

// InvoiceExtendedForeignerCreateOrUpdate
localVars.resInvoiceExtendedForeignerCreateOrUpdate.outParamId = await Actions.ActionInvoiceExtendedForeignerCreateOrUpdate(requestContext,new EN_5d51ce8a7e6e6b880d84c37746eb9086EntityRecord(){ ssId = localVars.resInvoiceCreateOrUpdate.outParamId, ssInvoiceNumber = localVars.inParamInvoiceForeign.ssInvoiceNumber, ssDirection = localVars.inParamInvoiceForeign.ssCustomerAddressDetected, ssReceiverSocialReason = localVars.inParamInvoiceForeign.ssCustomerNameDetected, ssReceiverRFC = localVars.inParamInvoiceForeign.ssCustomerTaxIdDetected, ssIssuerSocialReason = localVars.inParamInvoiceForeign.ssSupplierName, ssIssuerTaxId = localVars.inParamInvoiceForeign.ssSupplierTaxId, ssInvoiceDate = BuiltInFunction.TextToDate (localVars.inParamInvoiceForeign.ssInvoiceDate), ssTotalAmount = BuiltInFunction.TextToDecimal (localVars.inParamInvoiceForeign.ssTotalAmount), ssCurrency = localVars.inParamUploadValidationData.ssCurrency },cancellationToken);

// UploadInvoiceFiles_2ForeignerCreateExtended
await Actions.ActionUploadInvoiceFiles_2ForeignerCreateExtended(requestContext,localVars.resInvoiceCreateOrUpdate.outParamId,localVars.inParamInvoiceForeign,localVars.inParamIsStartApproval,cancellationToken);

if((localVars.inParamIsStartApproval)) {
// InitializeInvoiceWF_Concept
localVars.resInitializeInvoiceWF_Concept.outParamo_Output = await Actions.ActionInitializeInvoiceWF_Concept(requestContext,localVars.resInvoiceCreateOrUpdate.outParamId,"",(localVars.inParamRequisitionId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())),cancellationToken);

// IsSuccess
if((localVars.resInitializeInvoiceWF_Concept.outParamo_Output.ssIsSuccess)) {
// InvoiceAccountingInitialCreate
await Actions.ActionInvoiceAccountingInitialCreate(requestContext,localVars.resInvoiceCreateOrUpdate.outParamId,localVars.inParamRequisitionId,localVars.inParamUploadValidationData.ssRegionFI,"","","",BuiltInFunction.DecimalToText(BuiltInFunction.TextToDecimal (localVars.inParamInvoiceForeign.ssTotalAmount)),"",localVars.inParamUploadValidationData.ssProject,localVars.inParamUploadValidationData.ssCostCenterId,localVars.inParamUploadValidationData.ssPaymentMethodId,localVars.inParamUploadValidationData.ssPaymentTermsId,localVars.inParamUploadValidationData.ssSupplierNr,localVars.inParamUploadValidationData.ssTotalAmount,false,false,cancellationToken);

} else {
// ErrorMsg = InitializeInvoiceWF_Concept.o_Output.Message
result.outParamErrorMsg=localVars.resInitializeInvoiceWF_Concept.outParamo_Output.ssMessage;
}

}

}

} //close CreateActionActivity using block
} // try

finally {
outParamErrorMsg = result.outParamErrorMsg;
outParamInvoiceId_Out = result.outParamInvoiceId_Out;
outParamInvoice_Out = result.outParamInvoice_Out;
} // inner-finally
RETURN_STATEMENT:
return (outParamErrorMsg,outParamInvoiceId_Out,outParamInvoice_Out);
}

public static class FuncActionUploadInvoiceFiles_2ForeignerCreate {



}


}
