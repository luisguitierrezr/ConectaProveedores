namespace ssConectaProveedores;

public partial class Actions {
public class lcvUploadInvoiceFiles_XML : VarsBag {
public long inParamInvoiceId;
public byte[] inParamBinary;
public long inParamStorageId;
public string inParamFilename;
public bool inParamIsCallService;
public string inParamSystemTotalAmount;
public string inParamSupplierLugarExpedicion;
public string inParamSupplierNumber;
public string inParamSupplierRegion;
public string inParamSupplierRFC;
public string inParamSupplierSociety;
public BasicTypeList<string> inParamInvoiceUsageKeyList;
public bool inParamIsAnticipoWithoutInv;
public bool inParamIsAnticipoWithInv;
public decimal inParamInvoicesSum;
public int inParamAccountingDataTypeId;
public decimal inParamImportAnticipo;
public long inParamOrderAccConceptsID;
public int inParamOffsetUtc;
public bool inParamIsConstruction;
public int inParamFolioAmount;
/// <summary>
/// Variable <code>l_StartedOn</code> that represents the Service Studio DateTime
///  <code>l_StartedOn</code> <p>Description: </p>
/// </summary>
public DateTime varLcl_StartedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);

public Actions.lcoActionTimestampsCreateOrUpdate resActionTimestampsCreateOrUpdate9 =  new Actions.lcoActionTimestampsCreateOrUpdate();
public byte[] resServiceStorageGetFile_outParamo_File = new byte[] {};
public string resServiceStorageGetFile_outParamo_filename = "";

public Actions.lcoXML0_Validations resXML0_Validations =  new Actions.lcoXML0_Validations();
public Actions.lcoUploadInvoiceFiles_ValidationServices resUploadInvoiceFiles_XMLValidationsPAC =  new Actions.lcoUploadInvoiceFiles_ValidationServices();
public Actions.lcoActionTimestampsCreateOrUpdate resActionTimestampsCreateOrUpdate10 =  new Actions.lcoActionTimestampsCreateOrUpdate();
public lcvUploadInvoiceFiles_XML(long inParamInvoiceId, byte[] inParamBinary, long inParamStorageId, string inParamFilename, bool inParamIsCallService, string inParamSystemTotalAmount, string inParamSupplierLugarExpedicion, string inParamSupplierNumber, string inParamSupplierRegion, string inParamSupplierRFC, string inParamSupplierSociety, BasicTypeList<string> inParamInvoiceUsageKeyList, bool inParamIsAnticipoWithoutInv, bool inParamIsAnticipoWithInv, decimal inParamInvoicesSum, int inParamAccountingDataTypeId, decimal inParamImportAnticipo, long inParamOrderAccConceptsID, int inParamOffsetUtc, bool inParamIsConstruction, int inParamFolioAmount) {
this.inParamInvoiceId = inParamInvoiceId;
this.inParamBinary = inParamBinary;
this.inParamStorageId = inParamStorageId;
this.inParamFilename = inParamFilename;
this.inParamIsCallService = inParamIsCallService;
this.inParamSystemTotalAmount = inParamSystemTotalAmount;
this.inParamSupplierLugarExpedicion = inParamSupplierLugarExpedicion;
this.inParamSupplierNumber = inParamSupplierNumber;
this.inParamSupplierRegion = inParamSupplierRegion;
this.inParamSupplierRFC = inParamSupplierRFC;
this.inParamSupplierSociety = inParamSupplierSociety;
this.inParamInvoiceUsageKeyList = inParamInvoiceUsageKeyList;
this.inParamIsAnticipoWithoutInv = inParamIsAnticipoWithoutInv;
this.inParamIsAnticipoWithInv = inParamIsAnticipoWithInv;
this.inParamInvoicesSum = inParamInvoicesSum;
this.inParamAccountingDataTypeId = inParamAccountingDataTypeId;
this.inParamImportAnticipo = inParamImportAnticipo;
this.inParamOrderAccConceptsID = inParamOrderAccConceptsID;
this.inParamOffsetUtc = inParamOffsetUtc;
this.inParamIsConstruction = inParamIsConstruction;
this.inParamFolioAmount = inParamFolioAmount;
}
}
public class lcoUploadInvoiceFiles_XML : VarsBag {
public string outParamErrorMsg = "";

public EN_f81a3d226103fd013068b8763798067aEntityRecord outParamInvoiceExtended = new EN_f81a3d226103fd013068b8763798067aEntityRecord();

public EN_1ca446167f1a5fee035306f622895668EntityRecord outParamInvoiceExtendedIssuer = new EN_1ca446167f1a5fee035306f622895668EntityRecord();

public EN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord outParamInvoiceExtendedReceiver = new EN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord();

public RL_698fc6adea2f9e4df8f68df6dcd5ea9d outParamInvoiceExtendedItemList = new RL_698fc6adea2f9e4df8f68df6dcd5ea9d();

public RL_18908f1ccb5f6631454d810d9be77594 outParamInvoiceExtendedTaxList = new RL_18908f1ccb5f6631454d810d9be77594();

public RL_1801d41568a41cf6282486c389726e17 outParamInvoiceExtendedRelationsList = new RL_1801d41568a41cf6282486c389726e17();

public RL_4d4dc9b85c4a7d6bf03b676c2530ea4f outParamInvoiceExtendedMoreChargesList = new RL_4d4dc9b85c4a7d6bf03b676c2530ea4f();

public EN_9bd576a05df3846c52ce88a606aff414EntityRecord outParamInvoiceExtendedCartaPorte = new EN_9bd576a05df3846c52ce88a606aff414EntityRecord();

public byte[] outParamSelloDigital = new byte[] {};

public bool outParamIsMissingCreditNote = false;

public lcoUploadInvoiceFiles_XML() {
}
}
/// <summary>
/// Action <code>UploadInvoiceFiles_XML</code> that represents the Service Studio action
///  <code>UploadInvoiceFiles_XML</code> <p> Description: </p>
/// </summary>
public static async Task<(string,EN_f81a3d226103fd013068b8763798067aEntityRecord,EN_1ca446167f1a5fee035306f622895668EntityRecord,EN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord,RL_698fc6adea2f9e4df8f68df6dcd5ea9d,RL_18908f1ccb5f6631454d810d9be77594,RL_1801d41568a41cf6282486c389726e17,RL_4d4dc9b85c4a7d6bf03b676c2530ea4f,EN_9bd576a05df3846c52ce88a606aff414EntityRecord,byte[],bool)> ActionUploadInvoiceFiles_XML(IRequestContext requestContext,long inParamInvoiceId,byte[] inParamBinary,long inParamStorageId,string inParamFilename,bool inParamIsCallService,string inParamSystemTotalAmount,string inParamSupplierLugarExpedicion,string inParamSupplierNumber,string inParamSupplierRegion,string inParamSupplierRFC,string inParamSupplierSociety,BasicTypeList<string> inParamInvoiceUsageKeyList,bool inParamIsAnticipoWithoutInv,bool inParamIsAnticipoWithInv,decimal inParamInvoicesSum,int inParamAccountingDataTypeId,decimal inParamImportAnticipo,long inParamOrderAccConceptsID,int inParamOffsetUtc,bool inParamIsConstruction,int inParamFolioAmount,CancellationToken cancellationToken) {
string outParamErrorMsg = default;
EN_f81a3d226103fd013068b8763798067aEntityRecord outParamInvoiceExtended = default;
EN_1ca446167f1a5fee035306f622895668EntityRecord outParamInvoiceExtendedIssuer = default;
EN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord outParamInvoiceExtendedReceiver = default;
RL_698fc6adea2f9e4df8f68df6dcd5ea9d outParamInvoiceExtendedItemList = default;
RL_18908f1ccb5f6631454d810d9be77594 outParamInvoiceExtendedTaxList = default;
RL_1801d41568a41cf6282486c389726e17 outParamInvoiceExtendedRelationsList = default;
RL_4d4dc9b85c4a7d6bf03b676c2530ea4f outParamInvoiceExtendedMoreChargesList = default;
EN_9bd576a05df3846c52ce88a606aff414EntityRecord outParamInvoiceExtendedCartaPorte = default;
byte[] outParamSelloDigital = default;
bool outParamIsMissingCreditNote = default;
lcoUploadInvoiceFiles_XML result = new lcoUploadInvoiceFiles_XML();
lcvUploadInvoiceFiles_XML localVars = new lcvUploadInvoiceFiles_XML(inParamInvoiceId, inParamBinary, inParamStorageId, inParamFilename, inParamIsCallService, inParamSystemTotalAmount, inParamSupplierLugarExpedicion, inParamSupplierNumber, inParamSupplierRegion, inParamSupplierRFC, inParamSupplierSociety, inParamInvoiceUsageKeyList, inParamIsAnticipoWithoutInv, inParamIsAnticipoWithInv, inParamInvoicesSum, inParamAccountingDataTypeId, inParamImportAnticipo, inParamOrderAccConceptsID, inParamOffsetUtc, inParamIsConstruction, inParamFolioAmount);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("UploadInvoiceFiles_XML", "b4b14d91-9b98-47fa-8cfd-3f7753d3ba57"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("UploadInvoiceFiles_XML", "b4b14d91-9b98-47fa-8cfd-3f7753d3ba57", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// null binary
if((BinaryContentUtils.AreBothBinariesNull(localVars.inParamBinary, BuiltInFunction.NullBinary ()))) {
// ServiceStorageGetFile
(localVars.resServiceStorageGetFile_outParamo_File,localVars.resServiceStorageGetFile_outParamo_filename) = await ServiceAPIs.ServiceAPIServiceStorageGetFile(requestContext,localVars.inParamStorageId,cancellationToken);

// Binary = ServiceStorageGetFile.o_File
localVars.inParamBinary=localVars.resServiceStorageGetFile_outParamo_File;
}

// l_StartedOn = CurrDateTime
localVars.varLcl_StartedOn=BuiltInFunction.CurrDateTime ();
// XML0_Validations
(localVars.resXML0_Validations.outParamErrorMsg,localVars.resXML0_Validations.outParamInvoiceExtended,localVars.resXML0_Validations.outParamInvoiceExtendedIssuer,localVars.resXML0_Validations.outParamInvoiceExtendedReceiver,localVars.resXML0_Validations.outParamInvoiceExtendedItemList,localVars.resXML0_Validations.outParamInvoiceExtendedTaxList,localVars.resXML0_Validations.outParamInvoiceExtendedRelationsList,localVars.resXML0_Validations.outParamInvoiceExtendedMoreChargesList,localVars.resXML0_Validations.outParamInvoiceExtendedCartaPorte,localVars.resXML0_Validations.outParamSelloDigital,localVars.resXML0_Validations.outParamIsMissingCreditNote) = await Actions.ActionXML0_Validations(requestContext,localVars.inParamInvoiceId,localVars.inParamBinary,localVars.inParamSystemTotalAmount,localVars.inParamSupplierLugarExpedicion,localVars.inParamSupplierRFC,localVars.inParamInvoiceUsageKeyList,localVars.inParamIsAnticipoWithoutInv,localVars.inParamIsAnticipoWithInv,localVars.inParamInvoicesSum,localVars.inParamAccountingDataTypeId,localVars.inParamImportAnticipo,localVars.inParamOrderAccConceptsID,localVars.inParamOffsetUtc,localVars.inParamIsConstruction,localVars.inParamFolioAmount,cancellationToken);

// ActionTimestampsCreateOrUpdate9
localVars.resActionTimestampsCreateOrUpdate9.outParamId = await Actions.ActionActionTimestampsCreateOrUpdate(requestContext,new EN_b22d64c90281d09a316b6f4502a74326EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssDescription = (("InvoiceId: "+BuiltInFunction.LongIntegerToText(localVars.inParamInvoiceId))+" - XML Validations"), ssStartedOn = localVars.varLcl_StartedOn, ssFinishedOn = BuiltInFunction.CurrDateTime () },cancellationToken);

// error?
if(((localVars.resXML0_Validations.outParamErrorMsg!=""))) {
// ErrorMsg = XML0_Validations.ErrorMsg
result.outParamErrorMsg=localVars.resXML0_Validations.outParamErrorMsg;
} else {
// InvoiceExtended = XML0_Validations.InvoiceExtended
result.outParamInvoiceExtended=localVars.resXML0_Validations.outParamInvoiceExtended;

// InvoiceExtendedIssuer = XML0_Validations.InvoiceExtendedIssuer
result.outParamInvoiceExtendedIssuer=localVars.resXML0_Validations.outParamInvoiceExtendedIssuer;

// InvoiceExtendedReceiver = XML0_Validations.InvoiceExtendedReceiver
result.outParamInvoiceExtendedReceiver=localVars.resXML0_Validations.outParamInvoiceExtendedReceiver;

// InvoiceExtendedItemList = XML0_Validations.InvoiceExtendedItemList
result.outParamInvoiceExtendedItemList=localVars.resXML0_Validations.outParamInvoiceExtendedItemList;

// InvoiceExtendedTaxList = XML0_Validations.InvoiceExtendedTaxList
result.outParamInvoiceExtendedTaxList=localVars.resXML0_Validations.outParamInvoiceExtendedTaxList;

// InvoiceExtendedRelationsList = XML0_Validations.InvoiceExtendedRelationsList
result.outParamInvoiceExtendedRelationsList=localVars.resXML0_Validations.outParamInvoiceExtendedRelationsList;

// InvoiceExtendedMoreChargesList = XML0_Validations.InvoiceExtendedMoreChargesList
result.outParamInvoiceExtendedMoreChargesList=localVars.resXML0_Validations.outParamInvoiceExtendedMoreChargesList;

// InvoiceExtendedCartaPorte = XML0_Validations.InvoiceExtendedCartaPorte
result.outParamInvoiceExtendedCartaPorte=localVars.resXML0_Validations.outParamInvoiceExtendedCartaPorte;

// SelloDigital = XML0_Validations.SelloDigital
result.outParamSelloDigital=localVars.resXML0_Validations.outParamSelloDigital;

// IsMissingCreditNote = XML0_Validations.IsMissingCreditNote
result.outParamIsMissingCreditNote=localVars.resXML0_Validations.outParamIsMissingCreditNote;
// skip service?
if((!(((!localVars.inParamIsCallService)||(!((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveContabilizationServices])))))))) {
// l_StartedOn = CurrDateTime
localVars.varLcl_StartedOn=BuiltInFunction.CurrDateTime ();
// UploadInvoiceFiles_XMLValidationsPAC
localVars.resUploadInvoiceFiles_XMLValidationsPAC.outParamErrorMsg = await Actions.ActionUploadInvoiceFiles_ValidationServices(requestContext,false,localVars.inParamBinary,localVars.inParamFilename,localVars.inParamSupplierNumber,localVars.inParamSupplierRegion,localVars.inParamSupplierSociety,cancellationToken);

// ActionTimestampsCreateOrUpdate10
localVars.resActionTimestampsCreateOrUpdate10.outParamId = await Actions.ActionActionTimestampsCreateOrUpdate(requestContext,new EN_b22d64c90281d09a316b6f4502a74326EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssDescription = (("InvoiceId: "+BuiltInFunction.LongIntegerToText(localVars.inParamInvoiceId))+" - PAC Validations"), ssStartedOn = localVars.varLcl_StartedOn, ssFinishedOn = BuiltInFunction.CurrDateTime () },cancellationToken);

// ErrorMsg = UploadInvoiceFiles_XMLValidationsPAC.ErrorMsg
result.outParamErrorMsg=localVars.resUploadInvoiceFiles_XMLValidationsPAC.outParamErrorMsg;
}

}

} //close CreateActionActivity using block
} // try

finally {
outParamErrorMsg = result.outParamErrorMsg;
outParamInvoiceExtended = result.outParamInvoiceExtended;
outParamInvoiceExtendedIssuer = result.outParamInvoiceExtendedIssuer;
outParamInvoiceExtendedReceiver = result.outParamInvoiceExtendedReceiver;
outParamInvoiceExtendedItemList = result.outParamInvoiceExtendedItemList;
outParamInvoiceExtendedTaxList = result.outParamInvoiceExtendedTaxList;
outParamInvoiceExtendedRelationsList = result.outParamInvoiceExtendedRelationsList;
outParamInvoiceExtendedMoreChargesList = result.outParamInvoiceExtendedMoreChargesList;
outParamInvoiceExtendedCartaPorte = result.outParamInvoiceExtendedCartaPorte;
outParamSelloDigital = result.outParamSelloDigital;
outParamIsMissingCreditNote = result.outParamIsMissingCreditNote;
} // inner-finally
RETURN_STATEMENT:
return (outParamErrorMsg,outParamInvoiceExtended,outParamInvoiceExtendedIssuer,outParamInvoiceExtendedReceiver,outParamInvoiceExtendedItemList,outParamInvoiceExtendedTaxList,outParamInvoiceExtendedRelationsList,outParamInvoiceExtendedMoreChargesList,outParamInvoiceExtendedCartaPorte,outParamSelloDigital,outParamIsMissingCreditNote);
}

public static class FuncActionUploadInvoiceFiles_XML {



}


}
