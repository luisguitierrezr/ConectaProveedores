namespace ssConectaProveedores;

public partial class Actions {
public class lcvUploadInvoiceFiles_1National : VarsBag {
public long inParamInvoiceId;
public long inParamRequisitionId;
public long inParamOrderMainId;
public long inParamFolioId;
public bool inParamIsCreateCreditNote;
public RL_7b4ceb84b6a1255d3a42c8932279bc3c inParamFilesList;
public RL_7b4ceb84b6a1255d3a42c8932279bc3c inParamExtraFilesList;
public bool inParamIsStartApproval;
public ST_452088c4ad7c6718df20290248661783Structure inParamUploadValidationData;
public bool inParamIgnoreCreation;
public bool inParamIsModify;
public decimal inParamInvoicesSum;
public long inParamOrderAccConceptsID;
public int inParamAccountingDataTypeId;
public decimal inParamImportAnticipo;
public long inParamCreditNoteInvoiceId;
public int inParamOffsetUtc;
public bool inParamIsConstruction;
public int inParamFolioTotalAmount;
/// <summary>
/// Variable <code>InvoiceExtended</code> that represents the Service Studio InvoiceExtended
///  <code>InvoiceExtended</code> <p>Description: </p>
/// </summary>
public EN_f81a3d226103fd013068b8763798067aEntityRecord varLcInvoiceExtended = new EN_f81a3d226103fd013068b8763798067aEntityRecord();

/// <summary>
/// Variable <code>InvoiceExtendedIssuer</code> that represents the Service Studio
///  InvoiceExtendedIssuer <code>InvoiceExtendedIssuer</code> <p>Description: </p>
/// </summary>
public EN_1ca446167f1a5fee035306f622895668EntityRecord varLcInvoiceExtendedIssuer = new EN_1ca446167f1a5fee035306f622895668EntityRecord();

/// <summary>
/// Variable <code>InvoiceExtendedReceiver</code> that represents the Service Studio
///  InvoiceExtendedReceiver <code>InvoiceExtendedReceiver</code> <p>Description: </p>
/// </summary>
public EN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord varLcInvoiceExtendedReceiver = new EN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord();

/// <summary>
/// Variable <code>InvoiceExtendedItemList</code> that represents the Service Studio
///  InvoiceExtendedItemInvoiceExtendedItemTaxListRecordList <code>InvoiceExtendedItemList</code
/// > <p>Description: </p>
/// </summary>
public RL_698fc6adea2f9e4df8f68df6dcd5ea9d varLcInvoiceExtendedItemList = new RL_698fc6adea2f9e4df8f68df6dcd5ea9d();

/// <summary>
/// Variable <code>InvoiceExtendedTaxList</code> that represents the Service Studio
///  InvoiceExtendedTaxList <code>InvoiceExtendedTaxList</code> <p>Description: </p>
/// </summary>
public RL_18908f1ccb5f6631454d810d9be77594 varLcInvoiceExtendedTaxList = new RL_18908f1ccb5f6631454d810d9be77594();

/// <summary>
/// Variable <code>InvoiceExtendedRelationsList</code> that represents the Service Studio
///  InvoiceExtendedRelationsList <code>InvoiceExtendedRelationsList</code> <p>Description: </p>
/// </summary>
public RL_1801d41568a41cf6282486c389726e17 varLcInvoiceExtendedRelationsList = new RL_1801d41568a41cf6282486c389726e17();

/// <summary>
/// Variable <code>InvoiceExtendedMoreChargesList</code> that represents the Service Studio
///  InvoiceExtendedMoreChargesList <code>InvoiceExtendedMoreChargesList</code> <p>Description: </p>
/// </summary>
public RL_4d4dc9b85c4a7d6bf03b676c2530ea4f varLcInvoiceExtendedMoreChargesList = new RL_4d4dc9b85c4a7d6bf03b676c2530ea4f();

/// <summary>
/// Variable <code>InvoiceExtendedCartaPorte</code> that represents the Service Studio
///  InvoiceExtendedCartaPorte <code>InvoiceExtendedCartaPorte</code> <p>Description: </p>
/// </summary>
public EN_9bd576a05df3846c52ce88a606aff414EntityRecord varLcInvoiceExtendedCartaPorte = new EN_9bd576a05df3846c52ce88a606aff414EntityRecord();

/// <summary>
/// Variable <code>SelloDigital</code> that represents the Service Studio BinaryData
///  <code>SelloDigital</code> <p>Description: </p>
/// </summary>
public byte[] varLcSelloDigital = new byte[] {};

public Actions.lcoUploadInvoiceFiles_XML resUploadInvoiceFiles_XML =  new Actions.lcoUploadInvoiceFiles_XML();
public Actions.lcoUploadInvoiceFiles_1NationalCreate resUploadInvoiceFiles_1NationalCreate =  new Actions.lcoUploadInvoiceFiles_1NationalCreate();
public RL_7b4ceb84b6a1255d3a42c8932279bc3c resListFilter_xml_outParamFilteredList = new RL_7b4ceb84b6a1255d3a42c8932279bc3c();

public RL_7b4ceb84b6a1255d3a42c8932279bc3c resListFilter_pdf_outParamFilteredList = new RL_7b4ceb84b6a1255d3a42c8932279bc3c();

public lcvUploadInvoiceFiles_1National(long inParamInvoiceId, long inParamRequisitionId, long inParamOrderMainId, long inParamFolioId, bool inParamIsCreateCreditNote, RL_7b4ceb84b6a1255d3a42c8932279bc3c inParamFilesList, RL_7b4ceb84b6a1255d3a42c8932279bc3c inParamExtraFilesList, bool inParamIsStartApproval, ST_452088c4ad7c6718df20290248661783Structure inParamUploadValidationData, bool inParamIgnoreCreation, bool inParamIsModify, decimal inParamInvoicesSum, long inParamOrderAccConceptsID, int inParamAccountingDataTypeId, decimal inParamImportAnticipo, long inParamCreditNoteInvoiceId, int inParamOffsetUtc, bool inParamIsConstruction, int inParamFolioTotalAmount) {
this.inParamInvoiceId = inParamInvoiceId;
this.inParamRequisitionId = inParamRequisitionId;
this.inParamOrderMainId = inParamOrderMainId;
this.inParamFolioId = inParamFolioId;
this.inParamIsCreateCreditNote = inParamIsCreateCreditNote;
this.inParamFilesList = inParamFilesList;
this.inParamExtraFilesList = inParamExtraFilesList;
this.inParamIsStartApproval = inParamIsStartApproval;
this.inParamUploadValidationData = inParamUploadValidationData;
this.inParamIgnoreCreation = inParamIgnoreCreation;
this.inParamIsModify = inParamIsModify;
this.inParamInvoicesSum = inParamInvoicesSum;
this.inParamOrderAccConceptsID = inParamOrderAccConceptsID;
this.inParamAccountingDataTypeId = inParamAccountingDataTypeId;
this.inParamImportAnticipo = inParamImportAnticipo;
this.inParamCreditNoteInvoiceId = inParamCreditNoteInvoiceId;
this.inParamOffsetUtc = inParamOffsetUtc;
this.inParamIsConstruction = inParamIsConstruction;
this.inParamFolioTotalAmount = inParamFolioTotalAmount;
}
}
public class lcoUploadInvoiceFiles_1National : VarsBag {
public string outParamErrorMsg = "";

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord outParamo_Invoice = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();

public EN_f81a3d226103fd013068b8763798067aEntityRecord outParamo_InvoiceExtended = new EN_f81a3d226103fd013068b8763798067aEntityRecord();

public string outParamClaveProdServ = "";

public string outParamTipoComprobante = "";

public bool outParamIsMissingCreditNote = false;

public lcoUploadInvoiceFiles_1National() {
}
}
/// <summary>
/// Action <code>UploadInvoiceFiles_1National</code> that represents the Service Studio action
///  <code>UploadInvoiceFiles_1National</code> <p> Description: </p>
/// </summary>
public static async Task<(string,EN_d1d0320db36efbb094ad0082361435a0EntityRecord,EN_f81a3d226103fd013068b8763798067aEntityRecord,string,string,bool)> ActionUploadInvoiceFiles_1National(IRequestContext requestContext,long inParamInvoiceId,long inParamRequisitionId,long inParamOrderMainId,long inParamFolioId,bool inParamIsCreateCreditNote,RL_7b4ceb84b6a1255d3a42c8932279bc3c inParamFilesList,RL_7b4ceb84b6a1255d3a42c8932279bc3c inParamExtraFilesList,bool inParamIsStartApproval,ST_452088c4ad7c6718df20290248661783Structure inParamUploadValidationData,bool inParamIgnoreCreation,bool inParamIsModify,decimal inParamInvoicesSum,long inParamOrderAccConceptsID,int inParamAccountingDataTypeId,decimal inParamImportAnticipo,long inParamCreditNoteInvoiceId,int inParamOffsetUtc,bool inParamIsConstruction,int inParamFolioTotalAmount,CancellationToken cancellationToken) {
string outParamErrorMsg = default;
EN_d1d0320db36efbb094ad0082361435a0EntityRecord outParamo_Invoice = default;
EN_f81a3d226103fd013068b8763798067aEntityRecord outParamo_InvoiceExtended = default;
string outParamClaveProdServ = default;
string outParamTipoComprobante = default;
bool outParamIsMissingCreditNote = default;
lcoUploadInvoiceFiles_1National result = new lcoUploadInvoiceFiles_1National();
lcvUploadInvoiceFiles_1National localVars = new lcvUploadInvoiceFiles_1National(inParamInvoiceId, inParamRequisitionId, inParamOrderMainId, inParamFolioId, inParamIsCreateCreditNote, inParamFilesList, inParamExtraFilesList, inParamIsStartApproval, inParamUploadValidationData, inParamIgnoreCreation, inParamIsModify, inParamInvoicesSum, inParamOrderAccConceptsID, inParamAccountingDataTypeId, inParamImportAnticipo, inParamCreditNoteInvoiceId, inParamOffsetUtc, inParamIsConstruction, inParamFolioTotalAmount);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("UploadInvoiceFiles_1National", "b06f313f-6b75-47c4-87d3-bff542e07bc7"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("UploadInvoiceFiles_1National", "b06f313f-6b75-47c4-87d3-bff542e07bc7", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// ListFilter_xml
localVars.resListFilter_xml_outParamFilteredList = (((RL_7b4ceb84b6a1255d3a42c8932279bc3c)await  localVars.inParamFilesList.FilterAsync(async (p, cancellationToken) => (BuiltInFunction.IndexSC (BuiltInFunction.ToLower (p.ssName), ".xml", 0, false, false)!=(-1)), cancellationToken)));

// ListFilter_pdf
localVars.resListFilter_pdf_outParamFilteredList = (((RL_7b4ceb84b6a1255d3a42c8932279bc3c)await  localVars.inParamFilesList.FilterAsync(async (p, cancellationToken) => (BuiltInFunction.IndexSC (BuiltInFunction.ToLower (p.ssName), ".pdf", 0, false, false)!=(-1)), cancellationToken)));

// missing xml/pdf?
if(((localVars.resListFilter_xml_outParamFilteredList.Empty||localVars.resListFilter_pdf_outParamFilteredList.Empty))) {
// ErrorMsg = "xml & pdf files are obligatory for the invoice creation"
result.outParamErrorMsg=AppUtils.GetStringResource("TejrV6SXoEem0SjoS2a39A#Value.163726406.1", "xml & pdf files are obligatory for the invoice creation");
} else {
// UploadInvoiceFiles_XML
(localVars.resUploadInvoiceFiles_XML.outParamErrorMsg,localVars.resUploadInvoiceFiles_XML.outParamInvoiceExtended,localVars.resUploadInvoiceFiles_XML.outParamInvoiceExtendedIssuer,localVars.resUploadInvoiceFiles_XML.outParamInvoiceExtendedReceiver,localVars.resUploadInvoiceFiles_XML.outParamInvoiceExtendedItemList,localVars.resUploadInvoiceFiles_XML.outParamInvoiceExtendedTaxList,localVars.resUploadInvoiceFiles_XML.outParamInvoiceExtendedRelationsList,localVars.resUploadInvoiceFiles_XML.outParamInvoiceExtendedMoreChargesList,localVars.resUploadInvoiceFiles_XML.outParamInvoiceExtendedCartaPorte,localVars.resUploadInvoiceFiles_XML.outParamSelloDigital,localVars.resUploadInvoiceFiles_XML.outParamIsMissingCreditNote) = await Actions.ActionUploadInvoiceFiles_XML(requestContext,localVars.inParamInvoiceId,localVars.resListFilter_xml_outParamFilteredList.CurrentRec.ssBinaryData,localVars.resListFilter_xml_outParamFilteredList.CurrentRec.ssStorageId,localVars.resListFilter_xml_outParamFilteredList.CurrentRec.ssName,(localVars.inParamIsStartApproval||(localVars.inParamFolioId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ()))),localVars.inParamUploadValidationData.ssTotalAmount,localVars.inParamUploadValidationData.ssSupplierLugarExpedicion,localVars.inParamUploadValidationData.ssSupplierNr,localVars.inParamUploadValidationData.ssRegionFI,localVars.inParamUploadValidationData.ssSupplierRFC,localVars.inParamUploadValidationData.ssSupplierSociety,localVars.inParamUploadValidationData.ssInvoiceUsageKeyList,localVars.inParamUploadValidationData.ssIsAnticipoWithoutInv,localVars.inParamUploadValidationData.ssIsAnticipoWithInv,localVars.inParamInvoicesSum,localVars.inParamAccountingDataTypeId,localVars.inParamImportAnticipo,localVars.inParamOrderAccConceptsID,localVars.inParamOffsetUtc,localVars.inParamIsConstruction,localVars.inParamFolioTotalAmount,cancellationToken);

// InvoiceExtended = UploadInvoiceFiles_XML.InvoiceExtended
localVars.varLcInvoiceExtended=localVars.resUploadInvoiceFiles_XML.outParamInvoiceExtended;

// InvoiceExtendedIssuer = UploadInvoiceFiles_XML.InvoiceExtendedIssuer
localVars.varLcInvoiceExtendedIssuer=localVars.resUploadInvoiceFiles_XML.outParamInvoiceExtendedIssuer;

// InvoiceExtendedReceiver = UploadInvoiceFiles_XML.InvoiceExtendedReceiver
localVars.varLcInvoiceExtendedReceiver=localVars.resUploadInvoiceFiles_XML.outParamInvoiceExtendedReceiver;

// InvoiceExtendedItemList = UploadInvoiceFiles_XML.InvoiceExtendedItemList
localVars.varLcInvoiceExtendedItemList=localVars.resUploadInvoiceFiles_XML.outParamInvoiceExtendedItemList;

// InvoiceExtendedTaxList = UploadInvoiceFiles_XML.InvoiceExtendedTaxList
localVars.varLcInvoiceExtendedTaxList=localVars.resUploadInvoiceFiles_XML.outParamInvoiceExtendedTaxList;

// InvoiceExtendedRelationsList = UploadInvoiceFiles_XML.InvoiceExtendedRelationsList
localVars.varLcInvoiceExtendedRelationsList=localVars.resUploadInvoiceFiles_XML.outParamInvoiceExtendedRelationsList;

// InvoiceExtendedMoreChargesList = UploadInvoiceFiles_XML.InvoiceExtendedMoreChargesList
localVars.varLcInvoiceExtendedMoreChargesList=localVars.resUploadInvoiceFiles_XML.outParamInvoiceExtendedMoreChargesList;

// InvoiceExtendedCartaPorte = UploadInvoiceFiles_XML.InvoiceExtendedCartaPorte
localVars.varLcInvoiceExtendedCartaPorte=localVars.resUploadInvoiceFiles_XML.outParamInvoiceExtendedCartaPorte;

// SelloDigital = UploadInvoiceFiles_XML.SelloDigital
localVars.varLcSelloDigital=localVars.resUploadInvoiceFiles_XML.outParamSelloDigital;

// IsMissingCreditNote = UploadInvoiceFiles_XML.IsMissingCreditNote
result.outParamIsMissingCreditNote=localVars.resUploadInvoiceFiles_XML.outParamIsMissingCreditNote;
// error?
if((((localVars.resUploadInvoiceFiles_XML.outParamErrorMsg!="")||(localVars.resUploadInvoiceFiles_XML.outParamIsMissingCreditNote&&(localVars.inParamCreditNoteInvoiceId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))))) {
// ErrorMsg = UploadInvoiceFiles_XML.ErrorMsg
result.outParamErrorMsg=localVars.resUploadInvoiceFiles_XML.outParamErrorMsg;
} else {
// UploadInvoiceFiles_1NationalCreate
(localVars.resUploadInvoiceFiles_1NationalCreate.outParamErrorMsg,localVars.resUploadInvoiceFiles_1NationalCreate.outParamo_Invoice) = await Actions.ActionUploadInvoiceFiles_1NationalCreate(requestContext,localVars.inParamInvoiceId,localVars.inParamRequisitionId,localVars.inParamOrderMainId,localVars.inParamFolioId,localVars.inParamIsCreateCreditNote,localVars.varLcInvoiceExtended,localVars.varLcInvoiceExtendedIssuer,localVars.varLcInvoiceExtendedReceiver,localVars.varLcInvoiceExtendedItemList,localVars.varLcInvoiceExtendedTaxList,localVars.varLcInvoiceExtendedRelationsList,localVars.varLcInvoiceExtendedMoreChargesList,localVars.varLcInvoiceExtendedCartaPorte,localVars.inParamFilesList,localVars.inParamExtraFilesList,localVars.inParamIsModify,localVars.inParamIsStartApproval,localVars.varLcSelloDigital,localVars.inParamUploadValidationData.ssRegionFI,localVars.inParamUploadValidationData.ssCostCenterId,localVars.inParamUploadValidationData.ssProject,localVars.inParamUploadValidationData.ssPaymentMethodId,localVars.inParamUploadValidationData.ssPaymentTermsId,localVars.inParamUploadValidationData.ssSupplierNr,localVars.inParamUploadValidationData.ssTotalAmount,localVars.inParamIgnoreCreation,localVars.inParamUploadValidationData.ssIsAnticipoWithInv,localVars.inParamOrderAccConceptsID,localVars.inParamImportAnticipo,localVars.inParamCreditNoteInvoiceId,cancellationToken);

// ErrorMsg = UploadInvoiceFiles_1NationalCreate.ErrorMsg
result.outParamErrorMsg=localVars.resUploadInvoiceFiles_1NationalCreate.outParamErrorMsg;

// o_Invoice = UploadInvoiceFiles_1NationalCreate.o_Invoice
result.outParamo_Invoice=localVars.resUploadInvoiceFiles_1NationalCreate.outParamo_Invoice;

// o_InvoiceExtended = UploadInvoiceFiles_XML.InvoiceExtended
result.outParamo_InvoiceExtended=localVars.resUploadInvoiceFiles_XML.outParamInvoiceExtended;

// TipoComprobante = InvoiceExtended.TipoComprobante
result.outParamTipoComprobante=localVars.varLcInvoiceExtended.ssTipoComprobante;

// ClaveProdServ = InvoiceExtendedItemList.Current.InvoiceExtendedItem.ProductNumber
result.outParamClaveProdServ=localVars.varLcInvoiceExtendedItemList.CurrentRec.ssENInvoiceExtendedItem.ssProductNumber;
}

}

} //close CreateActionActivity using block
} // try

finally {
outParamErrorMsg = result.outParamErrorMsg;
outParamo_Invoice = result.outParamo_Invoice;
outParamo_InvoiceExtended = result.outParamo_InvoiceExtended;
outParamClaveProdServ = result.outParamClaveProdServ;
outParamTipoComprobante = result.outParamTipoComprobante;
outParamIsMissingCreditNote = result.outParamIsMissingCreditNote;
} // inner-finally
RETURN_STATEMENT:
return (outParamErrorMsg,outParamo_Invoice,outParamo_InvoiceExtended,outParamClaveProdServ,outParamTipoComprobante,outParamIsMissingCreditNote);
}

public static class FuncActionUploadInvoiceFiles_1National {



}


}
