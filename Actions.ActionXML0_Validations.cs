namespace ssConectaProveedores;

public partial class Actions {
public class lcvXML0_Validations : VarsBag {
public long inParamInvoiceId;
public byte[] inParamBinary;
public string inParamRequisitionTotalAmount;
public string inParamSupplierLugarExpedicion;
public string inParamSupplierRFC;
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
public Actions.lcoXML01_Comprobante resXML01_Comprobante =  new Actions.lcoXML01_Comprobante();
public Actions.lcoXML09_UUID resXML09_UUID =  new Actions.lcoXML09_UUID();
public Actions.lcoXML08A_CartaPorte resXML08_CartaPorte =  new Actions.lcoXML08A_CartaPorte();
public Actions.lcoXML05A_CFDIRelacionados resXML05A_CFDIRelacionados =  new Actions.lcoXML05A_CFDIRelacionados();
public Actions.lcoXML03_Receptor resXML03_Receptor =  new Actions.lcoXML03_Receptor();
public Actions.lcoXML06A_Impuestos resXML06A_Impuestos2 =  new Actions.lcoXML06A_Impuestos();
public Actions.lcoXML02_Emisor resXML02_Emisor2 =  new Actions.lcoXML02_Emisor();
public Actions.lcoXML07_Otros resXML07_Otros2 =  new Actions.lcoXML07_Otros();
public Actions.lcoXML01_ComprobanteTK195 resXML01_ComprobanteTK195 =  new Actions.lcoXML01_ComprobanteTK195();
public object resXMLDocument_Load_outParamXMLDocument = null;
public bool resXMLDocument_Load_outParamIsValid = false;
public RLXmlErrorRecordList resXMLDocument_Load_outParamErrors = new RLXmlErrorRecordList();

public Actions.lcoLogsAccountingCreate resLogsXMLValidationCreate6 =  new Actions.lcoLogsAccountingCreate();
public Actions.lcoXML08A_CartaPorte resXML08_CartaPorte2 =  new Actions.lcoXML08A_CartaPorte();
public Actions.lcoLogsAccountingCreate resLogsXMLValidationCreate9 =  new Actions.lcoLogsAccountingCreate();
public Actions.lcoLogsAccountingCreate resLogsXMLValidationCreate8 =  new Actions.lcoLogsAccountingCreate();
public Actions.lcoXML05A_CFDIRelacionados resXML05A_CFDIRelacionados2 =  new Actions.lcoXML05A_CFDIRelacionados();
public Actions.lcoLogsAccountingCreate resLogsXMLValidationCreate7 =  new Actions.lcoLogsAccountingCreate();
public Actions.lcoLogsAccountingCreate resLogsXMLValidationCreate5 =  new Actions.lcoLogsAccountingCreate();
public RL_698fc6adea2f9e4df8f68df6dcd5ea9d resListFilter2_outParamFilteredList = new RL_698fc6adea2f9e4df8f68df6dcd5ea9d();

public Actions.lcoXML04A_Conceptos resXML04A_Conceptos2 =  new Actions.lcoXML04A_Conceptos();
public Actions.lcoXML06A_Impuestos resXML06A_Impuestos =  new Actions.lcoXML06A_Impuestos();
public Actions.lcoXML07_Otros resXML07_Otros =  new Actions.lcoXML07_Otros();
public Actions.lcoXML03_Receptor resXML03_Receptor2 =  new Actions.lcoXML03_Receptor();
public RL_698fc6adea2f9e4df8f68df6dcd5ea9d resListFilter_outParamFilteredList = new RL_698fc6adea2f9e4df8f68df6dcd5ea9d();

public Actions.lcoLogsAccountingCreate resLogsXMLValidationCreate4 =  new Actions.lcoLogsAccountingCreate();
public Actions.lcoXML02_Emisor resXML02_Emisor =  new Actions.lcoXML02_Emisor();
public Actions.lcoXML04A_Conceptos resXML04A_Conceptos =  new Actions.lcoXML04A_Conceptos();
public string resBinaryDataToText_outParamText = "";

public lcvXML0_Validations(long inParamInvoiceId, byte[] inParamBinary, string inParamRequisitionTotalAmount, string inParamSupplierLugarExpedicion, string inParamSupplierRFC, BasicTypeList<string> inParamInvoiceUsageKeyList, bool inParamIsAnticipoWithoutInv, bool inParamIsAnticipoWithInv, decimal inParamInvoicesSum, int inParamAccountingDataTypeId, decimal inParamImportAnticipo, long inParamOrderAccConceptsID, int inParamOffsetUtc, bool inParamIsConstruction, int inParamFolioAmount) {
this.inParamInvoiceId = inParamInvoiceId;
this.inParamBinary = inParamBinary;
this.inParamRequisitionTotalAmount = inParamRequisitionTotalAmount;
this.inParamSupplierLugarExpedicion = inParamSupplierLugarExpedicion;
this.inParamSupplierRFC = inParamSupplierRFC;
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
public class lcoXML0_Validations : VarsBag {
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

public lcoXML0_Validations() {
}
}
/// <summary>
/// Action <code>XML0_Validations</code> that represents the Service Studio action
///  <code>XML0_Validations</code> <p> Description: </p>
/// </summary>
public static async Task<(string,EN_f81a3d226103fd013068b8763798067aEntityRecord,EN_1ca446167f1a5fee035306f622895668EntityRecord,EN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord,RL_698fc6adea2f9e4df8f68df6dcd5ea9d,RL_18908f1ccb5f6631454d810d9be77594,RL_1801d41568a41cf6282486c389726e17,RL_4d4dc9b85c4a7d6bf03b676c2530ea4f,EN_9bd576a05df3846c52ce88a606aff414EntityRecord,byte[],bool)> ActionXML0_Validations(IRequestContext requestContext,long inParamInvoiceId,byte[] inParamBinary,string inParamRequisitionTotalAmount,string inParamSupplierLugarExpedicion,string inParamSupplierRFC,BasicTypeList<string> inParamInvoiceUsageKeyList,bool inParamIsAnticipoWithoutInv,bool inParamIsAnticipoWithInv,decimal inParamInvoicesSum,int inParamAccountingDataTypeId,decimal inParamImportAnticipo,long inParamOrderAccConceptsID,int inParamOffsetUtc,bool inParamIsConstruction,int inParamFolioAmount,CancellationToken cancellationToken) {
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
lcoXML0_Validations result = new lcoXML0_Validations();
lcvXML0_Validations localVars = new lcvXML0_Validations(inParamInvoiceId, inParamBinary, inParamRequisitionTotalAmount, inParamSupplierLugarExpedicion, inParamSupplierRFC, inParamInvoiceUsageKeyList, inParamIsAnticipoWithoutInv, inParamIsAnticipoWithInv, inParamInvoicesSum, inParamAccountingDataTypeId, inParamImportAnticipo, inParamOrderAccConceptsID, inParamOffsetUtc, inParamIsConstruction, inParamFolioAmount);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("XML0_Validations", "a64a75ba-aa1a-463e-9000-21e3799cd7e8"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("XML0_Validations", "a64a75ba-aa1a-463e-9000-21e3799cd7e8", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// BinaryDataToText
localVars.resBinaryDataToText_outParamText = await Actions.ActionBinaryDataToText(requestContext,localVars.inParamBinary,"",cancellationToken);

// XMLDocument_Load
(localVars.resXMLDocument_Load_outParamXMLDocument,localVars.resXMLDocument_Load_outParamIsValid,localVars.resXMLDocument_Load_outParamErrors) = await Actions.ActionXMLDocument_Load(requestContext,localVars.resBinaryDataToText_outParamText,"",cancellationToken);

// XML09_UUID
(localVars.resXML09_UUID.outParamUUID,localVars.resXML09_UUID.outParamErrorMsg) = await Actions.ActionXML09_UUID(requestContext,localVars.inParamInvoiceId,localVars.resXMLDocument_Load_outParamXMLDocument,cancellationToken);

// error?
if(((localVars.resXML09_UUID.outParamErrorMsg!=""))) {
// ErrorMsg = XML09_UUID.ErrorMsg
result.outParamErrorMsg=localVars.resXML09_UUID.outParamErrorMsg;
} else {
if((((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveDEV_TK195]))))) {
// XML01_ComprobanteTK195
(localVars.resXML01_ComprobanteTK195.outParamInvoiceExtended,localVars.resXML01_ComprobanteTK195.outParamXMLNode,localVars.resXML01_ComprobanteTK195.outParamErrorMsg,localVars.resXML01_ComprobanteTK195.outParamSelloDigital) = await Actions.ActionXML01_ComprobanteTK195(requestContext,localVars.resXMLDocument_Load_outParamXMLDocument,localVars.inParamSupplierLugarExpedicion,localVars.inParamRequisitionTotalAmount,localVars.inParamIsAnticipoWithoutInv,localVars.inParamInvoicesSum,localVars.inParamOrderAccConceptsID,localVars.resXML09_UUID.outParamUUID,localVars.inParamOffsetUtc,localVars.inParamIsConstruction,localVars.inParamFolioAmount,cancellationToken);

// error?
if(((localVars.resXML01_ComprobanteTK195.outParamErrorMsg!=""))) {
// ErrorMsg = XML01_ComprobanteTK195.ErrorMsg
result.outParamErrorMsg=localVars.resXML01_ComprobanteTK195.outParamErrorMsg;
} else {
// XML02_Emisor2
(localVars.resXML02_Emisor2.outParamErrorMsg,localVars.resXML02_Emisor2.outParamInvoiceExtendedIssuer) = await Actions.ActionXML02_Emisor(requestContext,localVars.resXMLDocument_Load_outParamXMLDocument,localVars.resXML01_ComprobanteTK195.outParamInvoiceExtended.ssLugarExpedicion,localVars.inParamSupplierRFC,cancellationToken);

// error?
if(((localVars.resXML02_Emisor2.outParamErrorMsg!=""))) {
// ErrorMsg = XML02_Emisor2.ErrorMsg
result.outParamErrorMsg=localVars.resXML02_Emisor2.outParamErrorMsg;
} else {
// XML03_Receptor2
(localVars.resXML03_Receptor2.outParamInvoiceExtendedReceiver,localVars.resXML03_Receptor2.outParamUsoCFDI,localVars.resXML03_Receptor2.outParamErrorMsg) = await Actions.ActionXML03_Receptor(requestContext,localVars.resXMLDocument_Load_outParamXMLDocument,localVars.inParamInvoiceUsageKeyList,(localVars.resXML01_ComprobanteTK195.outParamInvoiceExtended.ssTipoComprobante=="E"),cancellationToken);

// error?
if(((localVars.resXML03_Receptor2.outParamErrorMsg!=""))) {
// ErrorMsg = XML03_Receptor2.ErrorMsg
result.outParamErrorMsg=localVars.resXML03_Receptor2.outParamErrorMsg;
} else {
// XML04A_Conceptos2
(localVars.resXML04A_Conceptos2.outParamInvoiceExtendedItemList,localVars.resXML04A_Conceptos2.outParamErrorMsg) = await Actions.ActionXML04A_Conceptos(requestContext,localVars.resXML01_ComprobanteTK195.outParamXMLNode,localVars.resXMLDocument_Load_outParamXMLDocument,cancellationToken);

// error?
if(((localVars.resXML04A_Conceptos2.outParamErrorMsg!=""))) {
// ErrorMsg = XML04A_Conceptos2.ErrorMsg
result.outParamErrorMsg=localVars.resXML04A_Conceptos2.outParamErrorMsg;
} else {
// ListFilter2
localVars.resListFilter2_outParamFilteredList = (((RL_698fc6adea2f9e4df8f68df6dcd5ea9d)await  localVars.resXML04A_Conceptos2.outParamInvoiceExtendedItemList.FilterAsync(async (p, cancellationToken) => (p.ssENInvoiceExtendedItem.ssProductNumber=="84111506"), cancellationToken)));

// anticipo error fcp
if((((localVars.inParamAccountingDataTypeId==8)&&(((BuiltInFunction.ToUpper (localVars.resXML01_ComprobanteTK195.outParamInvoiceExtended.ssTipoComprobante)!="I")||(localVars.resListFilter2_outParamFilteredList.Length!=localVars.resXML04A_Conceptos2.outParamInvoiceExtendedItemList.Length))||localVars.resXML04A_Conceptos2.outParamInvoiceExtendedItemList.Empty)))) {
// ErrorMsg = "Error in Tipo de Comprobante field"
result.outParamErrorMsg=AppUtils.GetStringResource("ONOAwa7_vEialgJSsg7iyg#Value.-1707586088.1", "Error in Tipo de Comprobante field");
// LogsXMLValidationCreate6
localVars.resLogsXMLValidationCreate6.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = AppUtils.GetStringResource("BKlNu_GDu0ykOb8SpyHQmg#Value.-1707586088.1", "Error in Tipo de Comprobante field"), ssDescription = (((((((Convert.ToString(localVars.inParamAccountingDataTypeId)+" is Anticipo and (")+localVars.resXML01_ComprobanteTK195.outParamInvoiceExtended.ssTipoComprobante)+" <> I or List of conceptos with product number 84111506 =")+Convert.ToString(localVars.resListFilter2_outParamFilteredList.Length))+" <> List of all conceptos = ")+Convert.ToString(localVars.resXML04A_Conceptos2.outParamInvoiceExtendedItemList.Length))+" or List of conceptos empty"), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("DeuxnejeQkCHc_yHj_40kQ"))).ssId },cancellationToken);

} else {
// anticipo error fsp
if(((localVars.inParamIsAnticipoWithInv&&((localVars.resListFilter2_outParamFilteredList.Length!=localVars.resXML04A_Conceptos2.outParamInvoiceExtendedItemList.Length)||localVars.resXML04A_Conceptos2.outParamInvoiceExtendedItemList.Empty)))) {
// ErrorMsg = "Error in Concepts Product Number"
result.outParamErrorMsg=AppUtils.GetStringResource("NFZOO_Ma9EKYYoLnBI5stw#Value.811096236.1", "Error in Concepts Product Number");
// LogsXMLValidationCreate9
localVars.resLogsXMLValidationCreate9.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "Error in Concepts Product Number", ssDescription = ((((((localVars.inParamIsAnticipoWithInv ? "True" : "False")+" is Anticipo and (List of conceptos with product number 84111506 =")+Convert.ToString(localVars.resListFilter2_outParamFilteredList.Length))+" <> List of all conceptos = ")+Convert.ToString(localVars.resXML04A_Conceptos2.outParamInvoiceExtendedItemList.Length))+" or List of conceptos empty"), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("DeuxnejeQkCHc_yHj_40kQ"))).ssId },cancellationToken);

} else {
// XML06A_Impuestos2
(localVars.resXML06A_Impuestos2.outParamInvoiceExtendedTaxList,localVars.resXML06A_Impuestos2.outParamErrorMsg) = await Actions.ActionXML06A_Impuestos(requestContext,localVars.resXML01_ComprobanteTK195.outParamXMLNode,localVars.resXMLDocument_Load_outParamXMLDocument,false,cancellationToken);

// error?
if(((localVars.resXML06A_Impuestos2.outParamErrorMsg!=""))) {
// ErrorMsg = XML06A_Impuestos2.ErrorMsg
result.outParamErrorMsg=localVars.resXML06A_Impuestos2.outParamErrorMsg;
} else {
// XML05A_CFDIRelacionados2
localVars.resXML05A_CFDIRelacionados2.outParamInvoiceExtendedRelationsList = await Actions.ActionXML05A_CFDIRelacionados(requestContext,localVars.resXML01_ComprobanteTK195.outParamXMLNode,cancellationToken);

// IsMissingCreditNote = ImportAnticipo > 0 and XML05A_CFDIRelacionados2.InvoiceExtendedRelationsList.Current.TipoRelacion <> "07"
result.outParamIsMissingCreditNote=((localVars.inParamImportAnticipo>(((decimal)0)))&&(localVars.resXML05A_CFDIRelacionados2.outParamInvoiceExtendedRelationsList.CurrentRec.ssTipoRelacion!="07"));
// anticipo imp error
if(((((localVars.inParamImportAnticipo>(((decimal)0)))&&(localVars.inParamImportAnticipo<=result.outParamInvoiceExtended.ssTotalIVA))&&(!result.outParamIsMissingCreditNote)))) {
// ErrorMsg = "Error in Amortization amount"
result.outParamErrorMsg=AppUtils.GetStringResource("18jsv9vH2UO8KSRhdyvL_Q#Value.-1045708874.1", "Error in Amortization amount");
// LogsXMLValidationCreate8
localVars.resLogsXMLValidationCreate8.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = AppUtils.GetStringResource("847_Eu9oOkqiOa+WjNSRSQ#Value.-1045708874.1", "Error in Amortization amount"), ssDescription = ((("Anticipo Saldo: "+BuiltInFunction.DecimalToText(localVars.inParamImportAnticipo))+" no es mayor que // Amortization: ")+BuiltInFunction.DecimalToText(result.outParamInvoiceExtended.ssTotalIVA)), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("DeuxnejeQkCHc_yHj_40kQ"))).ssId },cancellationToken);

} else {
// XML07_Otros2
(localVars.resXML07_Otros2.outParamInvoiceExtendedMoreChargesList,localVars.resXML07_Otros2.outParamErrorMsg) = await Actions.ActionXML07_Otros(requestContext,localVars.resXMLDocument_Load_outParamXMLDocument,cancellationToken);

// error?
if(((localVars.resXML07_Otros2.outParamErrorMsg!=""))) {
// ErrorMsg = XML07_Otros2.ErrorMsg
result.outParamErrorMsg=localVars.resXML07_Otros2.outParamErrorMsg;
} else {
// XML08_CartaPorte2
localVars.resXML08_CartaPorte2.outParamInvoiceExtendedCartaPorte = await Actions.ActionXML08A_CartaPorte(requestContext,localVars.resXMLDocument_Load_outParamXMLDocument,cancellationToken);

// InvoiceExtended = XML01_ComprobanteTK195.InvoiceExtended
result.outParamInvoiceExtended=localVars.resXML01_ComprobanteTK195.outParamInvoiceExtended;

// InvoiceExtended.UsoCFDI = XML03_Receptor2.UsoCFDI
result.outParamInvoiceExtended.ssUsoCFDI = localVars.resXML03_Receptor2.outParamUsoCFDI;

// InvoiceExtendedIssuer = XML02_Emisor2.InvoiceExtendedIssuer
result.outParamInvoiceExtendedIssuer=localVars.resXML02_Emisor2.outParamInvoiceExtendedIssuer;

// InvoiceExtendedReceiver = XML03_Receptor2.InvoiceExtendedReceiver
result.outParamInvoiceExtendedReceiver=localVars.resXML03_Receptor2.outParamInvoiceExtendedReceiver;

// InvoiceExtendedItemList = XML04A_Conceptos2.InvoiceExtendedItemList
result.outParamInvoiceExtendedItemList=localVars.resXML04A_Conceptos2.outParamInvoiceExtendedItemList;

// InvoiceExtendedRelationsList = XML05A_CFDIRelacionados2.InvoiceExtendedRelationsList
result.outParamInvoiceExtendedRelationsList=localVars.resXML05A_CFDIRelacionados2.outParamInvoiceExtendedRelationsList;

// InvoiceExtendedTaxList = XML06A_Impuestos2.InvoiceExtendedTaxList
result.outParamInvoiceExtendedTaxList=localVars.resXML06A_Impuestos2.outParamInvoiceExtendedTaxList;

// InvoiceExtendedMoreChargesList = XML07_Otros2.InvoiceExtendedMoreChargesList
result.outParamInvoiceExtendedMoreChargesList=localVars.resXML07_Otros2.outParamInvoiceExtendedMoreChargesList;

// InvoiceExtendedCartaPorte = XML08_CartaPorte2.InvoiceExtendedCartaPorte
result.outParamInvoiceExtendedCartaPorte=localVars.resXML08_CartaPorte2.outParamInvoiceExtendedCartaPorte;

// SelloDigital = XML01_ComprobanteTK195.SelloDigital
result.outParamSelloDigital=localVars.resXML01_ComprobanteTK195.outParamSelloDigital;

// InvoiceExtended.UUID = XML09_UUID.UUID
result.outParamInvoiceExtended.ssUUID = localVars.resXML09_UUID.outParamUUID;

// InvoiceExtended.Folio = If
result.outParamInvoiceExtended.ssFolio = (((result.outParamInvoiceExtended.ssFolio!="")) ? (result.outParamInvoiceExtended.ssFolio) : (BuiltInFunction.SubstrSC (localVars.resXML09_UUID.outParamUUID, (BuiltInFunction.LengthSC (localVars.resXML09_UUID.outParamUUID)-4), 4)));
}

}

}

}

}

}

}

}

}

} else {
// XML01_Comprobante
(localVars.resXML01_Comprobante.outParamInvoiceExtended,localVars.resXML01_Comprobante.outParamXMLNode,localVars.resXML01_Comprobante.outParamErrorMsg,localVars.resXML01_Comprobante.outParamSelloDigital) = await Actions.ActionXML01_Comprobante(requestContext,localVars.resXMLDocument_Load_outParamXMLDocument,localVars.inParamSupplierLugarExpedicion,localVars.inParamRequisitionTotalAmount,localVars.inParamIsAnticipoWithoutInv,localVars.inParamInvoicesSum,localVars.inParamOrderAccConceptsID,localVars.resXML09_UUID.outParamUUID,localVars.inParamOffsetUtc,cancellationToken);

// error?
if(((localVars.resXML01_Comprobante.outParamErrorMsg!=""))) {
// ErrorMsg = XML01_Comprobante.ErrorMsg
result.outParamErrorMsg=localVars.resXML01_Comprobante.outParamErrorMsg;
} else {
// XML02_Emisor
(localVars.resXML02_Emisor.outParamErrorMsg,localVars.resXML02_Emisor.outParamInvoiceExtendedIssuer) = await Actions.ActionXML02_Emisor(requestContext,localVars.resXMLDocument_Load_outParamXMLDocument,localVars.resXML01_Comprobante.outParamInvoiceExtended.ssLugarExpedicion,localVars.inParamSupplierRFC,cancellationToken);

// error?
if(((localVars.resXML02_Emisor.outParamErrorMsg!=""))) {
// ErrorMsg = XML02_Emisor.ErrorMsg
result.outParamErrorMsg=localVars.resXML02_Emisor.outParamErrorMsg;
} else {
// XML03_Receptor
(localVars.resXML03_Receptor.outParamInvoiceExtendedReceiver,localVars.resXML03_Receptor.outParamUsoCFDI,localVars.resXML03_Receptor.outParamErrorMsg) = await Actions.ActionXML03_Receptor(requestContext,localVars.resXMLDocument_Load_outParamXMLDocument,localVars.inParamInvoiceUsageKeyList,(localVars.resXML01_Comprobante.outParamInvoiceExtended.ssTipoComprobante=="E"),cancellationToken);

// error?
if(((localVars.resXML03_Receptor.outParamErrorMsg!=""))) {
// ErrorMsg = XML03_Receptor.ErrorMsg
result.outParamErrorMsg=localVars.resXML03_Receptor.outParamErrorMsg;
} else {
// XML04A_Conceptos
(localVars.resXML04A_Conceptos.outParamInvoiceExtendedItemList,localVars.resXML04A_Conceptos.outParamErrorMsg) = await Actions.ActionXML04A_Conceptos(requestContext,localVars.resXML01_Comprobante.outParamXMLNode,localVars.resXMLDocument_Load_outParamXMLDocument,cancellationToken);

// error?
if(((localVars.resXML04A_Conceptos.outParamErrorMsg!=""))) {
// ErrorMsg = XML04A_Conceptos.ErrorMsg
result.outParamErrorMsg=localVars.resXML04A_Conceptos.outParamErrorMsg;
} else {
// ListFilter
localVars.resListFilter_outParamFilteredList = (((RL_698fc6adea2f9e4df8f68df6dcd5ea9d)await  localVars.resXML04A_Conceptos.outParamInvoiceExtendedItemList.FilterAsync(async (p, cancellationToken) => (p.ssENInvoiceExtendedItem.ssProductNumber=="84111506"), cancellationToken)));

// anticipo error fcp
if((((localVars.inParamAccountingDataTypeId==8)&&(((BuiltInFunction.ToUpper (localVars.resXML01_Comprobante.outParamInvoiceExtended.ssTipoComprobante)!="I")||(localVars.resListFilter_outParamFilteredList.Length!=localVars.resXML04A_Conceptos.outParamInvoiceExtendedItemList.Length))||localVars.resXML04A_Conceptos.outParamInvoiceExtendedItemList.Empty)))) {
// ErrorMsg = "Error in Tipo de Comprobante field"
result.outParamErrorMsg=AppUtils.GetStringResource("MyQu7vI9KE2r+m29Cy55bw#Value.-1707586088.1", "Error in Tipo de Comprobante field");
// LogsXMLValidationCreate4
localVars.resLogsXMLValidationCreate4.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = AppUtils.GetStringResource("402iz1qKLU6mCN2aLmTGtw#Value.-1707586088.1", "Error in Tipo de Comprobante field"), ssDescription = (((((((Convert.ToString(localVars.inParamAccountingDataTypeId)+" is Anticipo and (")+localVars.resXML01_Comprobante.outParamInvoiceExtended.ssTipoComprobante)+" <> I or List of conceptos with product number 84111506 =")+Convert.ToString(localVars.resListFilter_outParamFilteredList.Length))+" <> List of all conceptos = ")+Convert.ToString(localVars.resXML04A_Conceptos.outParamInvoiceExtendedItemList.Length))+" or List of conceptos empty"), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("DeuxnejeQkCHc_yHj_40kQ"))).ssId },cancellationToken);

} else {
// anticipo error fsp
if(((localVars.inParamIsAnticipoWithInv&&((localVars.resListFilter_outParamFilteredList.Length!=localVars.resXML04A_Conceptos.outParamInvoiceExtendedItemList.Length)||localVars.resXML04A_Conceptos.outParamInvoiceExtendedItemList.Empty)))) {
// ErrorMsg = "Error in Concepts Product Number"
result.outParamErrorMsg=AppUtils.GetStringResource("iEwaytlh+EOXRzro0mgCRQ#Value.811096236.1", "Error in Concepts Product Number");
// LogsXMLValidationCreate5
localVars.resLogsXMLValidationCreate5.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "Error in Concepts Product Number", ssDescription = ((((((localVars.inParamIsAnticipoWithInv ? "True" : "False")+" is Anticipo and (List of conceptos with product number 84111506 =")+Convert.ToString(localVars.resListFilter_outParamFilteredList.Length))+" <> List of all conceptos = ")+Convert.ToString(localVars.resXML04A_Conceptos.outParamInvoiceExtendedItemList.Length))+" or List of conceptos empty"), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("DeuxnejeQkCHc_yHj_40kQ"))).ssId },cancellationToken);

} else {
// XML06A_Impuestos
(localVars.resXML06A_Impuestos.outParamInvoiceExtendedTaxList,localVars.resXML06A_Impuestos.outParamErrorMsg) = await Actions.ActionXML06A_Impuestos(requestContext,localVars.resXML01_Comprobante.outParamXMLNode,localVars.resXMLDocument_Load_outParamXMLDocument,false,cancellationToken);

// error?
if(((localVars.resXML06A_Impuestos.outParamErrorMsg!=""))) {
// ErrorMsg = XML06A_Impuestos.ErrorMsg
result.outParamErrorMsg=localVars.resXML06A_Impuestos.outParamErrorMsg;
} else {
// XML05A_CFDIRelacionados
localVars.resXML05A_CFDIRelacionados.outParamInvoiceExtendedRelationsList = await Actions.ActionXML05A_CFDIRelacionados(requestContext,localVars.resXML01_Comprobante.outParamXMLNode,cancellationToken);

// IsMissingCreditNote = ImportAnticipo > 0 and XML05A_CFDIRelacionados.InvoiceExtendedRelationsList.Current.TipoRelacion <> "07"
result.outParamIsMissingCreditNote=((localVars.inParamImportAnticipo>(((decimal)0)))&&(localVars.resXML05A_CFDIRelacionados.outParamInvoiceExtendedRelationsList.CurrentRec.ssTipoRelacion!="07"));
// anticipo imp error
if(((((localVars.inParamImportAnticipo>(((decimal)0)))&&(localVars.inParamImportAnticipo<=result.outParamInvoiceExtended.ssTotalIVA))&&(!result.outParamIsMissingCreditNote)))) {
// ErrorMsg = "Error in Amortization amount"
result.outParamErrorMsg=AppUtils.GetStringResource("3WyNpjACm0iGfZEQ3xqy2A#Value.-1045708874.1", "Error in Amortization amount");
// LogsXMLValidationCreate7
localVars.resLogsXMLValidationCreate7.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = AppUtils.GetStringResource("unLIS9IWdEukbloPABsifg#Value.-1045708874.1", "Error in Amortization amount"), ssDescription = ((("Anticipo Saldo: "+BuiltInFunction.DecimalToText(localVars.inParamImportAnticipo))+" no es mayor que // Amortization: ")+BuiltInFunction.DecimalToText(result.outParamInvoiceExtended.ssTotalIVA)), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("DeuxnejeQkCHc_yHj_40kQ"))).ssId },cancellationToken);

} else {
// XML07_Otros
(localVars.resXML07_Otros.outParamInvoiceExtendedMoreChargesList,localVars.resXML07_Otros.outParamErrorMsg) = await Actions.ActionXML07_Otros(requestContext,localVars.resXMLDocument_Load_outParamXMLDocument,cancellationToken);

// error?
if(((localVars.resXML07_Otros.outParamErrorMsg!=""))) {
// ErrorMsg = XML07_Otros.ErrorMsg
result.outParamErrorMsg=localVars.resXML07_Otros.outParamErrorMsg;
} else {
// XML08_CartaPorte
localVars.resXML08_CartaPorte.outParamInvoiceExtendedCartaPorte = await Actions.ActionXML08A_CartaPorte(requestContext,localVars.resXMLDocument_Load_outParamXMLDocument,cancellationToken);

// InvoiceExtended = XML01_Comprobante.InvoiceExtended
result.outParamInvoiceExtended=localVars.resXML01_Comprobante.outParamInvoiceExtended;

// InvoiceExtended.UsoCFDI = XML03_Receptor.UsoCFDI
result.outParamInvoiceExtended.ssUsoCFDI = localVars.resXML03_Receptor.outParamUsoCFDI;

// InvoiceExtendedIssuer = XML02_Emisor.InvoiceExtendedIssuer
result.outParamInvoiceExtendedIssuer=localVars.resXML02_Emisor.outParamInvoiceExtendedIssuer;

// InvoiceExtendedReceiver = XML03_Receptor.InvoiceExtendedReceiver
result.outParamInvoiceExtendedReceiver=localVars.resXML03_Receptor.outParamInvoiceExtendedReceiver;

// InvoiceExtendedItemList = XML04A_Conceptos.InvoiceExtendedItemList
result.outParamInvoiceExtendedItemList=localVars.resXML04A_Conceptos.outParamInvoiceExtendedItemList;

// InvoiceExtendedRelationsList = XML05A_CFDIRelacionados.InvoiceExtendedRelationsList
result.outParamInvoiceExtendedRelationsList=localVars.resXML05A_CFDIRelacionados.outParamInvoiceExtendedRelationsList;

// InvoiceExtendedTaxList = XML06A_Impuestos.InvoiceExtendedTaxList
result.outParamInvoiceExtendedTaxList=localVars.resXML06A_Impuestos.outParamInvoiceExtendedTaxList;

// InvoiceExtendedMoreChargesList = XML07_Otros.InvoiceExtendedMoreChargesList
result.outParamInvoiceExtendedMoreChargesList=localVars.resXML07_Otros.outParamInvoiceExtendedMoreChargesList;

// InvoiceExtendedCartaPorte = XML08_CartaPorte.InvoiceExtendedCartaPorte
result.outParamInvoiceExtendedCartaPorte=localVars.resXML08_CartaPorte.outParamInvoiceExtendedCartaPorte;

// SelloDigital = XML01_Comprobante.SelloDigital
result.outParamSelloDigital=localVars.resXML01_Comprobante.outParamSelloDigital;

// InvoiceExtended.UUID = XML09_UUID.UUID
result.outParamInvoiceExtended.ssUUID = localVars.resXML09_UUID.outParamUUID;

// InvoiceExtended.Folio = If
result.outParamInvoiceExtended.ssFolio = (((result.outParamInvoiceExtended.ssFolio!="")) ? (result.outParamInvoiceExtended.ssFolio) : (BuiltInFunction.SubstrSC (localVars.resXML09_UUID.outParamUUID, (BuiltInFunction.LengthSC (localVars.resXML09_UUID.outParamUUID)-4), 4)));
}

}

}

}

}

}

}

}

}

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

public static class FuncActionXML0_Validations {



}


}
