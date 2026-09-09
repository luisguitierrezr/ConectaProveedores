namespace ssConectaProveedores;

public partial class Actions {
public class lcvUploadInvoiceFiles_1NationalCreate : VarsBag {
public long inParamInvoiceId;
public long inParamRequisitionId;
public long inParamOrderMainId;
public long inParamFolioId;
public bool inParamIsCreateCreditNote;
public EN_f81a3d226103fd013068b8763798067aEntityRecord inParamInvoiceExtended;
public EN_1ca446167f1a5fee035306f622895668EntityRecord inParamInvoiceExtendedIssuer;
public EN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord inParamInvoiceExtendedReceiver;
public RL_698fc6adea2f9e4df8f68df6dcd5ea9d inParamInvoiceExtendedItemList;
public RL_18908f1ccb5f6631454d810d9be77594 inParamInvoiceExtendedTaxList;
public RL_1801d41568a41cf6282486c389726e17 inParamInvoiceExtendedRelationsList;
public RL_4d4dc9b85c4a7d6bf03b676c2530ea4f inParamInvoiceExtendedMoreChargesList;
public EN_9bd576a05df3846c52ce88a606aff414EntityRecord inParamInvoiceExtendedCartaPorte;
public RL_7b4ceb84b6a1255d3a42c8932279bc3c inParamFilesList;
public RL_7b4ceb84b6a1255d3a42c8932279bc3c inParamExtraFilesList;
public bool inParamIsModify;
public bool inParamIsStartApproval;
public byte[] inParamSelloDigital;
public string inParamRegionFI;
public long inParamRequisitionCostCenterId;
public string inParamRequisitionProject;
public long inParamRequisitionPaymentMethodId;
public long inParamRequisitionPaymentTermsId;
public string inParamRequisitionSupplierNr;
public string inParamRequisitionTotalAmount;
public bool inParamIgnoreCreation;
public bool inParamIsAnticipoWithInv;
public long inParamOrderAccConceptsID;
public decimal inParamImportAnticipo;
public long inParamCreditNoteInvoiceId;
public Actions.lcoInitializeInvoiceWF_Concept resInitializeInvoiceWF_Concept =  new Actions.lcoInitializeInvoiceWF_Concept();
public RL_18908f1ccb5f6631454d810d9be77594 resListFilterIVA_outParamFilteredList = new RL_18908f1ccb5f6631454d810d9be77594();

public Actions.lcoInvoiceCreateOrUpdate resInvoiceCreateOrUpdate =  new Actions.lcoInvoiceCreateOrUpdate();
public lcvUploadInvoiceFiles_1NationalCreate(long inParamInvoiceId, long inParamRequisitionId, long inParamOrderMainId, long inParamFolioId, bool inParamIsCreateCreditNote, EN_f81a3d226103fd013068b8763798067aEntityRecord inParamInvoiceExtended, EN_1ca446167f1a5fee035306f622895668EntityRecord inParamInvoiceExtendedIssuer, EN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord inParamInvoiceExtendedReceiver, RL_698fc6adea2f9e4df8f68df6dcd5ea9d inParamInvoiceExtendedItemList, RL_18908f1ccb5f6631454d810d9be77594 inParamInvoiceExtendedTaxList, RL_1801d41568a41cf6282486c389726e17 inParamInvoiceExtendedRelationsList, RL_4d4dc9b85c4a7d6bf03b676c2530ea4f inParamInvoiceExtendedMoreChargesList, EN_9bd576a05df3846c52ce88a606aff414EntityRecord inParamInvoiceExtendedCartaPorte, RL_7b4ceb84b6a1255d3a42c8932279bc3c inParamFilesList, RL_7b4ceb84b6a1255d3a42c8932279bc3c inParamExtraFilesList, bool inParamIsModify, bool inParamIsStartApproval, byte[] inParamSelloDigital, string inParamRegionFI, long inParamRequisitionCostCenterId, string inParamRequisitionProject, long inParamRequisitionPaymentMethodId, long inParamRequisitionPaymentTermsId, string inParamRequisitionSupplierNr, string inParamRequisitionTotalAmount, bool inParamIgnoreCreation, bool inParamIsAnticipoWithInv, long inParamOrderAccConceptsID, decimal inParamImportAnticipo, long inParamCreditNoteInvoiceId) {
this.inParamInvoiceId = inParamInvoiceId;
this.inParamRequisitionId = inParamRequisitionId;
this.inParamOrderMainId = inParamOrderMainId;
this.inParamFolioId = inParamFolioId;
this.inParamIsCreateCreditNote = inParamIsCreateCreditNote;
this.inParamInvoiceExtended = inParamInvoiceExtended;
this.inParamInvoiceExtendedIssuer = inParamInvoiceExtendedIssuer;
this.inParamInvoiceExtendedReceiver = inParamInvoiceExtendedReceiver;
this.inParamInvoiceExtendedItemList = inParamInvoiceExtendedItemList;
this.inParamInvoiceExtendedTaxList = inParamInvoiceExtendedTaxList;
this.inParamInvoiceExtendedRelationsList = inParamInvoiceExtendedRelationsList;
this.inParamInvoiceExtendedMoreChargesList = inParamInvoiceExtendedMoreChargesList;
this.inParamInvoiceExtendedCartaPorte = inParamInvoiceExtendedCartaPorte;
this.inParamFilesList = inParamFilesList;
this.inParamExtraFilesList = inParamExtraFilesList;
this.inParamIsModify = inParamIsModify;
this.inParamIsStartApproval = inParamIsStartApproval;
this.inParamSelloDigital = inParamSelloDigital;
this.inParamRegionFI = inParamRegionFI;
this.inParamRequisitionCostCenterId = inParamRequisitionCostCenterId;
this.inParamRequisitionProject = inParamRequisitionProject;
this.inParamRequisitionPaymentMethodId = inParamRequisitionPaymentMethodId;
this.inParamRequisitionPaymentTermsId = inParamRequisitionPaymentTermsId;
this.inParamRequisitionSupplierNr = inParamRequisitionSupplierNr;
this.inParamRequisitionTotalAmount = inParamRequisitionTotalAmount;
this.inParamIgnoreCreation = inParamIgnoreCreation;
this.inParamIsAnticipoWithInv = inParamIsAnticipoWithInv;
this.inParamOrderAccConceptsID = inParamOrderAccConceptsID;
this.inParamImportAnticipo = inParamImportAnticipo;
this.inParamCreditNoteInvoiceId = inParamCreditNoteInvoiceId;
}
}
public class lcoUploadInvoiceFiles_1NationalCreate : VarsBag {
public string outParamErrorMsg = "";

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord outParamo_Invoice = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();

public lcoUploadInvoiceFiles_1NationalCreate() {
}
}
/// <summary>
/// Action <code>UploadInvoiceFiles_1NationalCreate</code> that represents the Service Studio action
///  <code>UploadInvoiceFiles_1NationalCreate</code> <p> Description: </p>
/// </summary>
public static async Task<(string,EN_d1d0320db36efbb094ad0082361435a0EntityRecord)> ActionUploadInvoiceFiles_1NationalCreate(IRequestContext requestContext,long inParamInvoiceId,long inParamRequisitionId,long inParamOrderMainId,long inParamFolioId,bool inParamIsCreateCreditNote,EN_f81a3d226103fd013068b8763798067aEntityRecord inParamInvoiceExtended,EN_1ca446167f1a5fee035306f622895668EntityRecord inParamInvoiceExtendedIssuer,EN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord inParamInvoiceExtendedReceiver,RL_698fc6adea2f9e4df8f68df6dcd5ea9d inParamInvoiceExtendedItemList,RL_18908f1ccb5f6631454d810d9be77594 inParamInvoiceExtendedTaxList,RL_1801d41568a41cf6282486c389726e17 inParamInvoiceExtendedRelationsList,RL_4d4dc9b85c4a7d6bf03b676c2530ea4f inParamInvoiceExtendedMoreChargesList,EN_9bd576a05df3846c52ce88a606aff414EntityRecord inParamInvoiceExtendedCartaPorte,RL_7b4ceb84b6a1255d3a42c8932279bc3c inParamFilesList,RL_7b4ceb84b6a1255d3a42c8932279bc3c inParamExtraFilesList,bool inParamIsModify,bool inParamIsStartApproval,byte[] inParamSelloDigital,string inParamRegionFI,long inParamRequisitionCostCenterId,string inParamRequisitionProject,long inParamRequisitionPaymentMethodId,long inParamRequisitionPaymentTermsId,string inParamRequisitionSupplierNr,string inParamRequisitionTotalAmount,bool inParamIgnoreCreation,bool inParamIsAnticipoWithInv,long inParamOrderAccConceptsID,decimal inParamImportAnticipo,long inParamCreditNoteInvoiceId,CancellationToken cancellationToken) {
string outParamErrorMsg = default;
EN_d1d0320db36efbb094ad0082361435a0EntityRecord outParamo_Invoice = default;
lcoUploadInvoiceFiles_1NationalCreate result = new lcoUploadInvoiceFiles_1NationalCreate();
lcvUploadInvoiceFiles_1NationalCreate localVars = new lcvUploadInvoiceFiles_1NationalCreate(inParamInvoiceId, inParamRequisitionId, inParamOrderMainId, inParamFolioId, inParamIsCreateCreditNote, inParamInvoiceExtended, inParamInvoiceExtendedIssuer, inParamInvoiceExtendedReceiver, inParamInvoiceExtendedItemList, inParamInvoiceExtendedTaxList, inParamInvoiceExtendedRelationsList, inParamInvoiceExtendedMoreChargesList, inParamInvoiceExtendedCartaPorte, inParamFilesList, inParamExtraFilesList, inParamIsModify, inParamIsStartApproval, inParamSelloDigital, inParamRegionFI, inParamRequisitionCostCenterId, inParamRequisitionProject, inParamRequisitionPaymentMethodId, inParamRequisitionPaymentTermsId, inParamRequisitionSupplierNr, inParamRequisitionTotalAmount, inParamIgnoreCreation, inParamIsAnticipoWithInv, inParamOrderAccConceptsID, inParamImportAnticipo, inParamCreditNoteInvoiceId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("UploadInvoiceFiles_1NationalCreate", "ace7005f-35f5-4782-8b63-48c4fd0fd3fa"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("UploadInvoiceFiles_1NationalCreate", "ace7005f-35f5-4782-8b63-48c4fd0fd3fa", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Ignore creation
if((((localVars.inParamIgnoreCreation&&(localVars.inParamRequisitionId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))||((((localVars.inParamRequisitionId==Convert.ToInt64(BuiltInFunction.NullIdentifier ()))&&(localVars.inParamFolioId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))&&(localVars.inParamOrderMainId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))&&(!localVars.inParamIsCreateCreditNote))))) {
// o_Invoice.Name = Substr
result.outParamo_Invoice.ssName = BuiltInFunction.SubstrSC (localVars.inParamFilesList.CurrentRec.ssName, 0, BuiltInFunction.IndexSC (localVars.inParamFilesList.CurrentRec.ssName, ".", 0, false, false));

// o_Invoice.Currency = InvoiceExtended.Moneda
result.outParamo_Invoice.ssCurrency = localVars.inParamInvoiceExtended.ssMoneda;

// o_Invoice.TotalAmount = InvoiceExtended.Total
result.outParamo_Invoice.ssTotalAmount = localVars.inParamInvoiceExtended.ssTotal;
} else {
// InvoiceCreateOrUpdate
localVars.resInvoiceCreateOrUpdate.outParamId = await Actions.ActionInvoiceCreateOrUpdate(requestContext,new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(){ ssId = localVars.inParamInvoiceId, ssName = BuiltInFunction.SubstrSC (localVars.inParamFilesList.CurrentRec.ssName, 0, BuiltInFunction.IndexSC (localVars.inParamFilesList.CurrentRec.ssName, ".", 0, false, false)), ssRequisitionId = localVars.inParamRequisitionId, ssFolioId = localVars.inParamFolioId, ssOrderMainId = localVars.inParamOrderMainId, ssCFDITypeId = BuiltInFunction.NullIdentifier (), ssTotalAmount = localVars.inParamInvoiceExtended.ssTotal, ssCurrency = localVars.inParamInvoiceExtended.ssMoneda, ssInvoiceStatusId = ((localVars.inParamIsStartApproval) ? ((ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("Q66zN8rsbUynn1JzTqzCFA"))).ssId) : (((localVars.inParamIsModify) ? ((ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("ASvPCAkuaEyQ8YlZNO_ZcQ"))).ssId) : ((ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("Wo+LRDF_n0O7Fo8ikSEsSA"))).ssId)))), ssOrderAccConceptsID = localVars.inParamOrderAccConceptsID, ssAmortization = localVars.inParamImportAnticipo, ssCreditNoteInvoiceId = localVars.inParamCreditNoteInvoiceId },localVars.inParamIsStartApproval,cancellationToken);

// UploadInvoiceFiles_1NationalCreateExtended
await Actions.ActionUploadInvoiceFiles_1NationalCreateExtended(requestContext,localVars.resInvoiceCreateOrUpdate.outParamId,localVars.inParamInvoiceExtended,localVars.inParamInvoiceExtendedIssuer,localVars.inParamInvoiceExtendedReceiver,localVars.inParamInvoiceExtendedItemList,localVars.inParamInvoiceExtendedTaxList,localVars.inParamInvoiceExtendedRelationsList,localVars.inParamInvoiceExtendedMoreChargesList,localVars.inParamInvoiceExtendedCartaPorte,localVars.inParamSelloDigital,(localVars.inParamIsStartApproval||(!localVars.inParamIgnoreCreation)),cancellationToken);

// UploadInvoiceFiles_CreateFiles
await Actions.ActionUploadInvoiceFiles_CreateFiles(requestContext,localVars.inParamFilesList,localVars.inParamExtraFilesList,localVars.resInvoiceCreateOrUpdate.outParamId,cancellationToken);

// not start approval
if(((!localVars.inParamIsStartApproval))) {
// o_Invoice.Id = InvoiceCreateOrUpdate.Id
result.outParamo_Invoice.ssId = localVars.resInvoiceCreateOrUpdate.outParamId;
} else {
// InitializeInvoiceWF_Concept
localVars.resInitializeInvoiceWF_Concept.outParamo_Output = await Actions.ActionInitializeInvoiceWF_Concept(requestContext,localVars.resInvoiceCreateOrUpdate.outParamId,"",(localVars.inParamRequisitionId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())),cancellationToken);

// error
if(((!localVars.resInitializeInvoiceWF_Concept.outParamo_Output.ssIsSuccess))) {
// ErrorMsg = InitializeInvoiceWF_Concept.o_Output.Message
result.outParamErrorMsg=localVars.resInitializeInvoiceWF_Concept.outParamo_Output.ssMessage;
} else {
// ListFilterIVA
localVars.resListFilterIVA_outParamFilteredList = (((RL_18908f1ccb5f6631454d810d9be77594)await  localVars.inParamInvoiceExtendedTaxList.FilterAsync(async (p, cancellationToken) => (((p.ssInvoiceTaxTypeId==(ENInvoiceTaxTypeEntity.GetRecordByKey(ObjectKey.Parse("jP_W+pSpRESLV3Fw0NPgPQ"))).ssId)&&(p.ssImpuesto=="002"))&&(p.ssTipoFactor=="Tasa")), cancellationToken)));

// InvoiceAccountingInitialCreate
await Actions.ActionInvoiceAccountingInitialCreate(requestContext,localVars.resInvoiceCreateOrUpdate.outParamId,localVars.inParamRequisitionId,localVars.inParamRegionFI,BuiltInFunction.DecimalToText(localVars.resListFilterIVA_outParamFilteredList.CurrentRec.ssTasaOCuota),BuiltInFunction.DecimalToText(localVars.resListFilterIVA_outParamFilteredList.CurrentRec.ssImporte),Convert.ToString(0),BuiltInFunction.DecimalToText(localVars.inParamInvoiceExtended.ssSubtotal),BuiltInFunction.DecimalToText(localVars.inParamInvoiceExtended.ssDescuento),(((localVars.inParamInvoiceExtendedItemList.Length<2)) ? (BuiltInFunction.SubstrSC (localVars.inParamInvoiceExtendedItemList.CurrentRec.ssENInvoiceExtendedItem.ssDescription, 0, 450)) : (localVars.inParamRequisitionProject)),localVars.inParamRequisitionCostCenterId,localVars.inParamRequisitionPaymentMethodId,localVars.inParamRequisitionPaymentTermsId,localVars.inParamRequisitionSupplierNr,localVars.inParamRequisitionTotalAmount,true,localVars.inParamIsAnticipoWithInv,cancellationToken);

// o_Invoice.Id = InvoiceCreateOrUpdate.Id
result.outParamo_Invoice.ssId = localVars.resInvoiceCreateOrUpdate.outParamId;
}

}

}

} //close CreateActionActivity using block
} // try

finally {
outParamErrorMsg = result.outParamErrorMsg;
outParamo_Invoice = result.outParamo_Invoice;
} // inner-finally
RETURN_STATEMENT:
return (outParamErrorMsg,outParamo_Invoice);
}

public static class FuncActionUploadInvoiceFiles_1NationalCreate {



}


}
