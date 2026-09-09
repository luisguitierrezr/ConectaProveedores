using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_y_Utils_InvoiceReportPdf_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_y_Utils_InvoiceReportPdf_ScreenModel).Namespace);

    public long inParamInvoiceId;
public int varLcOffset;
public ConectaProveedores_y_Utils_InvoiceReportPdf_DataActionGetMainData_Model varLcGetMainData;
public ConectaProveedores_y_Utils_InvoiceReportPdf_DataActionGetTableItems_Model varLcGetTableItems;
public ConectaProveedores_y_Utils_InvoiceReportPdf_DataActionGetInvoiceFiles_Model varLcGetInvoiceFiles;
public ConectaProveedores_y_Utils_InvoiceReportPdf_DataActionGetEletronicAuthorizations_Model varLcGetEletronicAuthorizations;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_y_Utils_InvoiceReportPdf_ScreenModel() {
}



    public ConectaProveedores_y_Utils_InvoiceReportPdf_ScreenModel(long inParamInvoiceId, int varLcOffset, ConectaProveedores_y_Utils_InvoiceReportPdf_DataActionGetMainData_Model varLcGetMainData, ConectaProveedores_y_Utils_InvoiceReportPdf_DataActionGetTableItems_Model varLcGetTableItems, ConectaProveedores_y_Utils_InvoiceReportPdf_DataActionGetInvoiceFiles_Model varLcGetInvoiceFiles, ConectaProveedores_y_Utils_InvoiceReportPdf_DataActionGetEletronicAuthorizations_Model varLcGetEletronicAuthorizations, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"InvoiceId", "Offset", "GetMainData", "GetTableItems", "GetInvoiceFiles", "GetEletronicAuthorizations", "ClientVars"}, new string[] {"inParamInvoiceId", "varLcOffset", "varLcGetMainData", "varLcGetTableItems", "varLcGetInvoiceFiles", "varLcGetEletronicAuthorizations", "clientVariables"});
this.inParamInvoiceId = inParamInvoiceId;
this.varLcOffset = varLcOffset;
this.varLcGetMainData = varLcGetMainData;
this.varLcGetTableItems = varLcGetTableItems;
this.varLcGetInvoiceFiles = varLcGetInvoiceFiles;
this.varLcGetEletronicAuthorizations = varLcGetEletronicAuthorizations;
this.clientVariables = clientVariables;
}



    

    public class lcvGetMainData : VarsBag {
public RL_7da4463726b1a0efdce09801de464da8 queryResGetFolioById_outParamList = new RL_7da4463726b1a0efdce09801de464da8();
public long queryResGetFolioById_outParamCount = 0L;

public RL_897c95bca5499c293930e47bf793d0d9 queryResGetFolioFilesByFolioId_outParamList = new RL_897c95bca5499c293930e47bf793d0d9();
public long queryResGetFolioFilesByFolioId_outParamCount = 0L;

public RL_361bfb1983e170050cb9d371d001b386 queryResGetOrderMainItemsByOrderMainId_outParamList = new RL_361bfb1983e170050cb9d371d001b386();
public long queryResGetOrderMainItemsByOrderMainId_outParamCount = 0L;

public RL_1f9a243d40703326d9bf7c63586316cd queryResGetInvoiceById_outParamList = new RL_1f9a243d40703326d9bf7c63586316cd();
public long queryResGetInvoiceById_outParamCount = 0L;

public RL_d37c3599312f2bd85c82314399f4e20e queryResGetRequisitionById_outParamList = new RL_d37c3599312f2bd85c82314399f4e20e();
public long queryResGetRequisitionById_outParamCount = 0L;

public lcvGetMainData() {
}
}
public class lcoGetMainData : VarsBag {
public ST_f54c1d1bac41c2667837ac97bb484830Structure outParamValidationReport = new ST_f54c1d1bac41c2667837ac97bb484830Structure();

public RC_b6257dfb536e679f8b7be7b4b56f189b outParamInvoiceExtended = new RC_b6257dfb536e679f8b7be7b4b56f189b();

public long outParamFolioId = 0L;

public bool outParamIsFromRequisition = false;

public lcoGetMainData() {
}
}
/// <summary>
/// Action <code>GetMainData</code> that represents the Service Studio action <code>GetMainData</code>
///  <p> Description: </p>
/// </summary>
public async Task<(ST_f54c1d1bac41c2667837ac97bb484830Structure,RC_b6257dfb536e679f8b7be7b4b56f189b,long,bool)> DataActionGetMainData(IRequestContext requestContext,CancellationToken cancellationToken) {
ST_f54c1d1bac41c2667837ac97bb484830Structure outParamValidationReport = default;
RC_b6257dfb536e679f8b7be7b4b56f189b outParamInvoiceExtended = default;
long outParamFolioId = default;
bool outParamIsFromRequisition = default;
lcoGetMainData result = new lcoGetMainData();
lcvGetMainData localVars = new lcvGetMainData();
ConectaProveedores_y_Utils_InvoiceReportPdf_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetMainData", "8df569d4-43a4-4226-93ed-831fbb2a3b89"))
using (activitySource.CreateScreenDataActionActivity("InvoiceReportPdf", "GetMainData")){
// Query datasetGetInvoiceById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceById_maxRecords = 1;
if (datasetGetInvoiceById_maxRecords < 1) datasetGetInvoiceById_maxRecords = 1;
int datasetGetInvoiceById_startIndex = 0;(localVars.queryResGetInvoiceById_outParamList,localVars.queryResGetInvoiceById_outParamCount) = await FuncDataActionGetMainData.datasetGetInvoiceById(requestContext,datasetGetInvoiceById_maxRecords,datasetGetInvoiceById_startIndex,IterationMultiplicity.Never,inParamInvoiceId,cancellationToken);

// InvoiceExtended = GetInvoiceById.List.Current
result.outParamInvoiceExtended=localVars.queryResGetInvoiceById_outParamList.CurrentRec;

// FolioId = GetInvoiceById.List.Current.Invoice.FolioId
result.outParamFolioId=localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssFolioId;
// requisition
if(((localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssRequisitionId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// Query datasetGetRequisitionById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionById_maxRecords = 1;
if (datasetGetRequisitionById_maxRecords < 1) datasetGetRequisitionById_maxRecords = 1;
int datasetGetRequisitionById_startIndex = 0;(localVars.queryResGetRequisitionById_outParamList,localVars.queryResGetRequisitionById_outParamCount) = await FuncDataActionGetMainData.datasetGetRequisitionById(requestContext,datasetGetRequisitionById_maxRecords,datasetGetRequisitionById_startIndex,IterationMultiplicity.Never,localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssRequisitionId,cancellationToken);

// ValidationReport.Supplier = GetRequisitionById.List.Current.Supplier.Name + " " + "(" + GetRequisitionById.List.Current.Supplier.N_ident_fis_1 + ")" + " " + "(" + GetRequisitionById.List.Current.Supplier.Number + ")"
result.outParamValidationReport.ssSupplier = ((((((((localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENSupplier.ssName+" ")+"(")+localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENSupplier.ssN_ident_fis_1)+")")+" ")+"(")+localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENSupplier.ssNumber)+")");

// ValidationReport.Project = GetRequisitionById.List.Current.Project_Asset_Service.Description
result.outParamValidationReport.ssProject = localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENProject_Asset_Service.ssDescription;

// ValidationReport.ReservePeriod = ""
result.outParamValidationReport.ssReservePeriod = "";

// ValidationReport.InvoiceNumber = GetInvoiceById.List.Current.Invoice.Name
result.outParamValidationReport.ssInvoiceNumber = localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssName;

// ValidationReport.Frequency = GetRequisitionById.List.Current.Frequency.Label
result.outParamValidationReport.ssFrequency = localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENFrequency.ssLabel;

// ValidationReport.RequisitionNumber = GetRequisitionById.List.Current.Requisition.Name
result.outParamValidationReport.ssRequisitionNumber = localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssName;

// ValidationReport.DeliveryDate = UTCToLocalTime(TextToDateTime, OffsetUtc)
result.outParamValidationReport.ssDeliveryDate = BuiltInFunction.DateTimeToText((await Functions.ActionUTCToLocalTime(requestContext,BuiltInFunction.TextToDateTime (localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoiceExtended.ssFechaEmision),model.clientVariables.ssOffsetUtc,cancellationToken)));

// ValidationReport.BusinessCat = GetRequisitionById.List.Current.BusinessValueCategory.Description
result.outParamValidationReport.ssBusinessCat = localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENBusinessValueCategory.ssDescription;

// ValidationReport.BusinessSubcat = GetRequisitionById.List.Current.BusinessValueSubcategory.Description
result.outParamValidationReport.ssBusinessSubcat = localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENBusinessValueSubcategory.ssDescription;

// ValidationReport.Characteristics = GetRequisitionById.List.Current.Requisition.ProjectDescription
result.outParamValidationReport.ssCharacteristics = localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssProjectDescription;

// IsFromRequisition = True
result.outParamIsFromRequisition=true;
} else {
// Query datasetGetFolioById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioById_maxRecords = 1;
if (datasetGetFolioById_maxRecords < 1) datasetGetFolioById_maxRecords = 1;
int datasetGetFolioById_startIndex = 0;(localVars.queryResGetFolioById_outParamList,localVars.queryResGetFolioById_outParamCount) = await FuncDataActionGetMainData.datasetGetFolioById(requestContext,datasetGetFolioById_maxRecords,datasetGetFolioById_startIndex,IterationMultiplicity.Never,localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssFolioId,cancellationToken);

// Query datasetGetFolioFilesByFolioId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioFilesByFolioId_maxRecords = 100;
if (datasetGetFolioFilesByFolioId_maxRecords < 1) datasetGetFolioFilesByFolioId_maxRecords = 1;
int datasetGetFolioFilesByFolioId_startIndex = 0;(localVars.queryResGetFolioFilesByFolioId_outParamList,localVars.queryResGetFolioFilesByFolioId_outParamCount) = await FuncDataActionGetMainData.datasetGetFolioFilesByFolioId(requestContext,datasetGetFolioFilesByFolioId_maxRecords,datasetGetFolioFilesByFolioId_startIndex,IterationMultiplicity.Multiple,localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssId,cancellationToken);

// Foreach GetFolioFilesByFolioId.List
localVars.queryResGetFolioFilesByFolioId_outParamList.StartIteration();
try {while (!((localVars.queryResGetFolioFilesByFolioId_outParamList.Eof))) {
// ValidationReport.Attachments = ValidationReport.Attachments + GetFolioFilesByFolioId.List.Current.FolioFiles.Filename + If
result.outParamValidationReport.ssAttachments = ((result.outParamValidationReport.ssAttachments+localVars.queryResGetFolioFilesByFolioId_outParamList.CurrentRec.ssENFolioFiles.ssFilename)+(((localVars.queryResGetFolioFilesByFolioId_outParamList.CurrentRowNumber<(localVars.queryResGetFolioFilesByFolioId_outParamList.Length-1))) ? (", ") : ("")));
localVars.queryResGetFolioFilesByFolioId_outParamList.Advance();
}

} finally {
localVars.queryResGetFolioFilesByFolioId_outParamList.EndIteration();
}

// Query datasetGetOrderMainItemsByOrderMainId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderMainItemsByOrderMainId_maxRecords = 1;
if (datasetGetOrderMainItemsByOrderMainId_maxRecords < 1) datasetGetOrderMainItemsByOrderMainId_maxRecords = 1;
int datasetGetOrderMainItemsByOrderMainId_startIndex = 0;(localVars.queryResGetOrderMainItemsByOrderMainId_outParamList,localVars.queryResGetOrderMainItemsByOrderMainId_outParamCount) = await FuncDataActionGetMainData.datasetGetOrderMainItemsByOrderMainId(requestContext,datasetGetOrderMainItemsByOrderMainId_maxRecords,datasetGetOrderMainItemsByOrderMainId_startIndex,IterationMultiplicity.Never,localVars.queryResGetFolioById_outParamList.CurrentRec.ssENOrderMain.ssId,cancellationToken);

// ValidationReport.Supplier = GetFolioById.List.Current.Supplier.Name + " " + "(" + GetFolioById.List.Current.Supplier.N_ident_fis_1 + ")" + " " + "(" + GetFolioById.List.Current.Supplier.Number + ")"
result.outParamValidationReport.ssSupplier = ((((((((localVars.queryResGetFolioById_outParamList.CurrentRec.ssENSupplier.ssName+" ")+"(")+localVars.queryResGetFolioById_outParamList.CurrentRec.ssENSupplier.ssN_ident_fis_1)+")")+" ")+"(")+localVars.queryResGetFolioById_outParamList.CurrentRec.ssENSupplier.ssNumber)+")");

// ValidationReport.Project = GetFolioById.List.Current.Project_Asset_Service.Description
result.outParamValidationReport.ssProject = localVars.queryResGetFolioById_outParamList.CurrentRec.ssENProject_Asset_Service.ssDescription;

// ValidationReport.ReservePeriod = GetFolioById.List.Current.OrderDetail.Period
result.outParamValidationReport.ssReservePeriod = localVars.queryResGetFolioById_outParamList.CurrentRec.ssENOrderDetail.ssPeriod;

// ValidationReport.InvoiceNumber = GetInvoiceById.List.Current.Invoice.Name
result.outParamValidationReport.ssInvoiceNumber = localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssName;

// ValidationReport.Frequency = GetFolioById.List.Current.Frequency.Label
result.outParamValidationReport.ssFrequency = localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFrequency.ssLabel;

// ValidationReport.RequisitionNumber = GetFolioById.List.Current.Folio.FolioNumber
result.outParamValidationReport.ssRequisitionNumber = localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssFolioNumber;

// ValidationReport.DeliveryDate = GetFolioById.List.Current.FolioSAPData.CreatedOn
result.outParamValidationReport.ssDeliveryDate = BuiltInFunction.DateTimeToText(localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioSAPData.ssCreatedOn);

// ValidationReport.BusinessCat = GetFolioById.List.Current.BusinessValueCategory.Description
result.outParamValidationReport.ssBusinessCat = localVars.queryResGetFolioById_outParamList.CurrentRec.ssENBusinessValueCategory.ssDescription;

// ValidationReport.BusinessSubcat = GetFolioById.List.Current.BusinessValueSubcategory.Description
result.outParamValidationReport.ssBusinessSubcat = localVars.queryResGetFolioById_outParamList.CurrentRec.ssENBusinessValueSubcategory.ssDescription;

// ValidationReport.Characteristics = GetFolioById.List.Current.OrderDetail.ProjectDescription
result.outParamValidationReport.ssCharacteristics = localVars.queryResGetFolioById_outParamList.CurrentRec.ssENOrderDetail.ssProjectDescription;

// IsFromRequisition = False
result.outParamIsFromRequisition=false;

// ValidationReport.OrderNumber = GetFolioById.List.Current.OrderMain.OrderNumber
result.outParamValidationReport.ssOrderNumber = localVars.queryResGetFolioById_outParamList.CurrentRec.ssENOrderMain.ssOrderNumber;

// ValidationReport.FolioCreationDate = UTCToLocalTime(GetFolioById.List.Current.Folio.CreatedOn, OffsetUtc)
result.outParamValidationReport.ssFolioCreationDate = BuiltInFunction.DateTimeToDate((await Functions.ActionUTCToLocalTime(requestContext,localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssCreatedOn,model.clientVariables.ssOffsetUtc,cancellationToken)));

// ValidationReport.Society = GetFolioById.List.Current.Company.ExternalId
result.outParamValidationReport.ssSociety = localVars.queryResGetFolioById_outParamList.CurrentRec.ssENCompany.ssExternalId;

// ValidationReport.PEPElement = GetOrderMainItemsByOrderMainId.List.Current.OrderMainItem.PEPElement
result.outParamValidationReport.ssPEPElement = localVars.queryResGetOrderMainItemsByOrderMainId_outParamList.CurrentRec.ssENOrderMainItem.ssPEPElement;

// ValidationReport.DeliverySite = "Entrega en Sitio"
result.outParamValidationReport.ssDeliverySite = "Entrega en Sitio";

// ValidationReport.EntryNumber = GetFolioById.List.Current.FolioSAPData.PO_DOCUMENTO_MATERIAL_EM
result.outParamValidationReport.ssEntryNumber = localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioSAPData.ssPO_DOCUMENTO_MATERIAL_EM;

// ValidationReport.EntryDate = GetFolioById.List.Current.FolioSAPData.CreatedOn
result.outParamValidationReport.ssEntryDate = localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioSAPData.ssCreatedOn;
}

} //close CreateActionActivity using block
} // try

finally {
outParamValidationReport = result.outParamValidationReport;
outParamInvoiceExtended = result.outParamInvoiceExtended;
outParamFolioId = result.outParamFolioId;
outParamIsFromRequisition = result.outParamIsFromRequisition;
} // inner-finally
RETURN_STATEMENT:
return (outParamValidationReport,outParamInvoiceExtended,outParamFolioId,outParamIsFromRequisition);
}
public class lcvGetTableItems : VarsBag {
public RL_772f048f6ee632348101044a1e0eef2f queryResGetInvoiceItems_outParamList = new RL_772f048f6ee632348101044a1e0eef2f();
public long queryResGetInvoiceItems_outParamCount = 0L;

public lcvGetTableItems() {
}
}
public class lcoGetTableItems : VarsBag {
public RL_f0441ae281d3bacc0d1d0acaed8c2549 outParamTableLine = new RL_f0441ae281d3bacc0d1d0acaed8c2549();

public lcoGetTableItems() {
}
}
/// <summary>
/// Action <code>GetTableItems</code> that represents the Service Studio action
///  <code>GetTableItems</code> <p> Description: </p>
/// </summary>
public async Task<RL_f0441ae281d3bacc0d1d0acaed8c2549> DataActionGetTableItems(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_f0441ae281d3bacc0d1d0acaed8c2549 outParamTableLine = default;
lcoGetTableItems result = new lcoGetTableItems();
lcvGetTableItems localVars = new lcvGetTableItems();
ConectaProveedores_y_Utils_InvoiceReportPdf_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetTableItems", "a602e3fc-47d6-4525-8f74-cba4fcfc7ae8"))
using (activitySource.CreateScreenDataActionActivity("InvoiceReportPdf", "GetTableItems")){
// Query datasetGetInvoiceItems
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceItems_maxRecords = 50;
if (datasetGetInvoiceItems_maxRecords < 1) datasetGetInvoiceItems_maxRecords = 1;
int datasetGetInvoiceItems_startIndex = 0;(localVars.queryResGetInvoiceItems_outParamList,localVars.queryResGetInvoiceItems_outParamCount) = await FuncDataActionGetTableItems.datasetGetInvoiceItems(requestContext,datasetGetInvoiceItems_maxRecords,datasetGetInvoiceItems_startIndex,IterationMultiplicity.Multiple,inParamInvoiceId,cancellationToken);

// ListAppendAll
await ExtendedActions.ListAppendAll(requestContext,result.outParamTableLine,(await RL_f0441ae281d3bacc0d1d0acaed8c2549.ConvertAsync(localVars.queryResGetInvoiceItems_outParamList, new RL_f0441ae281d3bacc0d1d0acaed8c2549(), async (RC_7f2610cf0c5fadd86ba78c902c31effa source, ST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure target, CancellationToken cancellationToken) => {
target.ssArticle = source.ssENInvoiceExtendedItem.ssProductNumber;
target.ssDescription = source.ssENInvoiceExtendedItem.ssDescription;
target.ssMaterialCode = source.ssENInvoiceExtendedItem.ssMaterialCode;
target.ssQuantity = source.ssENInvoiceExtendedItem.ssQuantity;
target.ssUnitPrice = BuiltInFunction.FormatDecimal (BuiltInFunction.TextToDecimal (BuiltInFunction.DecimalToText(source.ssENInvoiceExtendedItem.ssUnityPrice)), 2, ".", ",");
target.ssTotalAmount = BuiltInFunction.FormatDecimal (BuiltInFunction.Round (((((decimal)source.ssENInvoiceExtendedItem.ssQuantity))*source.ssENInvoiceExtendedItem.ssUnityPrice), 2), 2, ".", ",");
target.ssCurrency = source.ssENInvoiceExtendedItem.ssCurrency;
return target;
}, cancellationToken)),cancellationToken);

// ListAppendEmpty
await ExtendedActions.ListAppend(requestContext,result.outParamTableLine,new ST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure(){  },cancellationToken);

// ListAppendEmpty2
await ExtendedActions.ListAppend(requestContext,result.outParamTableLine,new ST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure(){  },cancellationToken);

// ListAppendEmpty3
await ExtendedActions.ListAppend(requestContext,result.outParamTableLine,new ST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure(){  },cancellationToken);

// ListAppendSubtotal
await ExtendedActions.ListAppend(requestContext,result.outParamTableLine,new ST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure(){ ssUnitPrice = "Subtotal", ssTotalAmount = BuiltInFunction.FormatDecimal (varLcGetMainData.outParamInvoiceExtended.ssENInvoiceExtended.ssSubtotal, 2, ".", ","), ssCurrency = varLcGetMainData.outParamInvoiceExtended.ssENInvoiceExtended.ssMoneda },cancellationToken);

// ListAppendIVA
await ExtendedActions.ListAppend(requestContext,result.outParamTableLine,new ST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure(){ ssUnitPrice = "IVA", ssTotalAmount = BuiltInFunction.FormatDecimal (varLcGetMainData.outParamInvoiceExtended.ssENInvoiceExtended.ssTotalIVA, 2, ".", ","), ssCurrency = varLcGetMainData.outParamInvoiceExtended.ssENInvoiceExtended.ssMoneda },cancellationToken);

// has retention?
if(((varLcGetMainData.outParamInvoiceExtended.ssENInvoiceExtended.ssRetenciones!=(((decimal)0))))) {
// ListAppendRetentions
await ExtendedActions.ListAppend(requestContext,result.outParamTableLine,new ST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure(){ ssUnitPrice = AppUtils.GetStringResource("6nQ7sgg3_kqx9kYNSuCkCA#Value.1907155253.1", "Retentions"), ssTotalAmount = BuiltInFunction.FormatDecimal (varLcGetMainData.outParamInvoiceExtended.ssENInvoiceExtended.ssRetenciones, 2, ".", ","), ssCurrency = varLcGetMainData.outParamInvoiceExtended.ssENInvoiceExtended.ssMoneda },cancellationToken);

}

// ListAppendTotal
await ExtendedActions.ListAppend(requestContext,result.outParamTableLine,new ST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure(){ ssUnitPrice = "Total", ssTotalAmount = BuiltInFunction.FormatDecimal (varLcGetMainData.outParamInvoiceExtended.ssENInvoiceExtended.ssTotal, 2, ".", ","), ssCurrency = varLcGetMainData.outParamInvoiceExtended.ssENInvoiceExtended.ssMoneda },cancellationToken);

} //close CreateActionActivity using block
} // try

finally {
outParamTableLine = result.outParamTableLine;
} // inner-finally
RETURN_STATEMENT:
return outParamTableLine;
}
public class lcvGetInvoiceFiles : VarsBag {
public RL_00a03f803f0d49826089181417370afb queryResGetInvoiceFilesByInvoiceId_outParamList = new RL_00a03f803f0d49826089181417370afb();
public long queryResGetInvoiceFilesByInvoiceId_outParamCount = 0L;

public lcvGetInvoiceFiles() {
}
}
public class lcoGetInvoiceFiles : VarsBag {
public string outParamFilesString = "";

public lcoGetInvoiceFiles() {
}
}
/// <summary>
/// Action <code>GetInvoiceFiles</code> that represents the Service Studio action
///  <code>GetInvoiceFiles</code> <p> Description: </p>
/// </summary>
public async Task<string> DataActionGetInvoiceFiles(IRequestContext requestContext,CancellationToken cancellationToken) {
string outParamFilesString = default;
lcoGetInvoiceFiles result = new lcoGetInvoiceFiles();
lcvGetInvoiceFiles localVars = new lcvGetInvoiceFiles();
ConectaProveedores_y_Utils_InvoiceReportPdf_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetInvoiceFiles", "bd3bc710-2bc2-49ce-aa5e-76707c50d8ba"))
using (activitySource.CreateScreenDataActionActivity("InvoiceReportPdf", "GetInvoiceFiles")){
// Query datasetGetInvoiceFilesByInvoiceId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceFilesByInvoiceId_maxRecords = 50;
if (datasetGetInvoiceFilesByInvoiceId_maxRecords < 1) datasetGetInvoiceFilesByInvoiceId_maxRecords = 1;
int datasetGetInvoiceFilesByInvoiceId_startIndex = 0;(localVars.queryResGetInvoiceFilesByInvoiceId_outParamList,localVars.queryResGetInvoiceFilesByInvoiceId_outParamCount) = await FuncDataActionGetInvoiceFiles.datasetGetInvoiceFilesByInvoiceId(requestContext,datasetGetInvoiceFilesByInvoiceId_maxRecords,datasetGetInvoiceFilesByInvoiceId_startIndex,IterationMultiplicity.Multiple,inParamInvoiceId,cancellationToken);

// Foreach GetInvoiceFilesByInvoiceId.List
localVars.queryResGetInvoiceFilesByInvoiceId_outParamList.StartIteration();
try {while (!((localVars.queryResGetInvoiceFilesByInvoiceId_outParamList.Eof))) {
// FilesString = FilesString + GetInvoiceFilesByInvoiceId.List.Current.InvoiceFile.Filename + If
result.outParamFilesString=((result.outParamFilesString+localVars.queryResGetInvoiceFilesByInvoiceId_outParamList.CurrentRec.ssENInvoiceFile.ssFilename)+(((localVars.queryResGetInvoiceFilesByInvoiceId_outParamList.CurrentRowNumber<(localVars.queryResGetInvoiceFilesByInvoiceId_outParamList.Length-1))) ? (", ") : ("")));
localVars.queryResGetInvoiceFilesByInvoiceId_outParamList.Advance();
}

} finally {
localVars.queryResGetInvoiceFilesByInvoiceId_outParamList.EndIteration();
}

} //close CreateActionActivity using block
} // try

finally {
outParamFilesString = result.outParamFilesString;
} // inner-finally
RETURN_STATEMENT:
return outParamFilesString;
}
public class lcvGetEletronicAuthorizations : VarsBag {
public RL_1abe1514d325a5123b34272c27068edf queryResGetInvoiceApprovalsByInvoiceId_outParamList = new RL_1abe1514d325a5123b34272c27068edf();
public long queryResGetInvoiceApprovalsByInvoiceId_outParamCount = 0L;

public RL_22c684c9a7250fc07aca158787cc388d queryResGetFolioApprovalsByFolioId_outParamList = new RL_22c684c9a7250fc07aca158787cc388d();
public long queryResGetFolioApprovalsByFolioId_outParamCount = 0L;

public lcvGetEletronicAuthorizations() {
}
}
public class lcoGetEletronicAuthorizations : VarsBag {
public RL_2d1a9f1ebd1dae77afe7dba56f4eb06c outParamValidationReportAuthorizationList = new RL_2d1a9f1ebd1dae77afe7dba56f4eb06c();

public lcoGetEletronicAuthorizations() {
}
}
/// <summary>
/// Action <code>GetEletronicAuthorizations</code> that represents the Service Studio action
///  <code>GetEletronicAuthorizations</code> <p> Description: </p>
/// </summary>
public async Task<RL_2d1a9f1ebd1dae77afe7dba56f4eb06c> DataActionGetEletronicAuthorizations(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_2d1a9f1ebd1dae77afe7dba56f4eb06c outParamValidationReportAuthorizationList = default;
lcoGetEletronicAuthorizations result = new lcoGetEletronicAuthorizations();
lcvGetEletronicAuthorizations localVars = new lcvGetEletronicAuthorizations();
ConectaProveedores_y_Utils_InvoiceReportPdf_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetEletronicAuthorizations", "ffd996c4-e1e0-49c4-aef5-82d3e5fbc67c"))
using (activitySource.CreateScreenDataActionActivity("InvoiceReportPdf", "GetEletronicAuthorizations")){
// requisition
if(((varLcGetMainData.outParamFolioId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// Query datasetGetInvoiceApprovalsByInvoiceId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceApprovalsByInvoiceId_maxRecords = 50;
if (datasetGetInvoiceApprovalsByInvoiceId_maxRecords < 1) datasetGetInvoiceApprovalsByInvoiceId_maxRecords = 1;
int datasetGetInvoiceApprovalsByInvoiceId_startIndex = 0;(localVars.queryResGetInvoiceApprovalsByInvoiceId_outParamList,localVars.queryResGetInvoiceApprovalsByInvoiceId_outParamCount) = await FuncDataActionGetEletronicAuthorizations.datasetGetInvoiceApprovalsByInvoiceId(requestContext,datasetGetInvoiceApprovalsByInvoiceId_maxRecords,datasetGetInvoiceApprovalsByInvoiceId_startIndex,IterationMultiplicity.Single,inParamInvoiceId,cancellationToken);

// ValidationReportAuthorizationList = GetInvoiceApprovalsByInvoiceId.List
result.outParamValidationReportAuthorizationList=(await RL_2d1a9f1ebd1dae77afe7dba56f4eb06c.ConvertAsync(localVars.queryResGetInvoiceApprovalsByInvoiceId_outParamList, new RL_2d1a9f1ebd1dae77afe7dba56f4eb06c(), async (RC_bc42b3285bc8089ad06a2c8ae4ee05e7 source, ST_2667ad63792f2349dc9e4a818559d9ecStructure target, CancellationToken cancellationToken) => {
target.ssName = source.ssENUser.ssName;
target.ssField = source.ssENEntraRole.ssRoleName;
target.ssDate = BuiltInFunction.FormatDateTime ((await Functions.ActionUTCToLocalTime(requestContext,source.ssENInvoiceApprovalLevel.ssApprovedOn,model.clientVariables.ssOffsetUtc,cancellationToken)), "d MMM yyyy");
target.ssHour = BuiltInFunction.DateTimeToText(BuiltInFunction.AddMinutes (source.ssENInvoiceApprovalLevel.ssApprovedOn, (-varLcOffset)));
return target;
}, cancellationToken));
} else {
// Query datasetGetFolioApprovalsByFolioId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioApprovalsByFolioId_maxRecords = 0;
int datasetGetFolioApprovalsByFolioId_startIndex = 0;(localVars.queryResGetFolioApprovalsByFolioId_outParamList,localVars.queryResGetFolioApprovalsByFolioId_outParamCount) = await FuncDataActionGetEletronicAuthorizations.datasetGetFolioApprovalsByFolioId(requestContext,datasetGetFolioApprovalsByFolioId_maxRecords,datasetGetFolioApprovalsByFolioId_startIndex,IterationMultiplicity.Single,varLcGetMainData.outParamFolioId,cancellationToken);

// ValidationReportAuthorizationList = GetFolioApprovalsByFolioId.List
result.outParamValidationReportAuthorizationList=(await RL_2d1a9f1ebd1dae77afe7dba56f4eb06c.ConvertAsync(localVars.queryResGetFolioApprovalsByFolioId_outParamList, new RL_2d1a9f1ebd1dae77afe7dba56f4eb06c(), async (RC_eecf597d9aac604956ae34e0eea91058 source, ST_2667ad63792f2349dc9e4a818559d9ecStructure target, CancellationToken cancellationToken) => {
target.ssName = source.ssENUser.ssName;
target.ssField = source.ssENFolioApprovalLevel.ssEntraJobTitle;
target.ssDate = BuiltInFunction.FormatDateTime ((await Functions.ActionUTCToLocalTime(requestContext,source.ssENFolioApprovalLevel.ssApprovedOn,model.clientVariables.ssOffsetUtc,cancellationToken)), "d MMM yyyy");
target.ssHour = BuiltInFunction.DateTimeToText(BuiltInFunction.AddMinutes (source.ssENFolioApprovalLevel.ssApprovedOn, (-varLcOffset)));
return target;
}, cancellationToken));
}

} //close CreateActionActivity using block
} // try

finally {
outParamValidationReportAuthorizationList = result.outParamValidationReportAuthorizationList;
} // inner-finally
RETURN_STATEMENT:
return outParamValidationReportAuthorizationList;
}


    public static class FuncDataActionGetMainData {

private static async Task<RC_a0ca9572f9e7d998d312de7b2a0a8fa0> datasetGetFolioByIdReadDbAsync(RC_a0ca9572f9e7d998d312de7b2a0a8fa0 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENBusinessValueCategory.Read( r, ref index);
rec.ssENBusinessValueSubcategory.Read( r, ref index);
rec.ssENCompany.Read( r, ref index);
rec.ssENFolio.Read( r, ref index);
rec.ssENFolioSAPData.Read( r, ref index);
rec.ssENFrequency.Read( r, ref index);
rec.ssENOrderDetail.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssENProject_Asset_Service.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetFolioById" 3LFsGThxQEWuMJ01JP_bvw of Action "GetMainData"
public static async Task<(RL_7da4463726b1a0efdce09801de464da8,long)> datasetGetFolioById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolio_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("y_Utils.InvoiceReportPdf.GetMainData.GetFolioById", "196cb1dc-7138-4540-ae30-9d3524ffdbbf");
using var queryActivity = activitySource.CreateAggregateQueryActivity("y_Utils.InvoiceReportPdf.GetMainData.GetFolioById", "196cb1dc-7138-4540-ae30-9d3524ffdbbf", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /NRWebFlows.JAcgewyqEkOMCfBjsT2WtQ/NodesShownInESpaceTree.7rpNb_jWDkCycCc+yoChag/DataActions.1Gn1jaRDJkKT7YMfuyo7iQ/NodesNotShownInESpaceTree.3LFsGThxQEWuMJ01JP_bvw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enbusinessvaluecategory5\".\"description\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, \"enbusinessvaluesubcategory5\".\"description\" o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, \"encompany59\".\"externalid\" o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, \"enfolio72\".\"id\" o24, NULL o25, \"enfolio72\".\"folionumber\" o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, \"enfolio72\".\"createdon\" o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, \"enfoliosapdata14\".\"po_documento_material_em\" o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, \"enfoliosapdata14\".\"createdon\" o58, NULL o59, \"enfrequency8\".\"label\" o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, \"enorderdetail19\".\"projectdescription\" o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, \"enorderdetail19\".\"period\" o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, \"enordermain114\".\"id\" o102, \"enordermain114\".\"ordernumber\" o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, NULL o118, NULL o119, NULL o120, NULL o121, NULL o122, NULL o123, NULL o124, NULL o125, NULL o126, NULL o127, NULL o128, NULL o129, NULL o130, NULL o131, \"enproject_asset_service26\".\"description\" o132, NULL o133, NULL o134, NULL o135, NULL o136, NULL o137, NULL o138, NULL o139, \"ensupplier121\".\"name\" o140, \"ensupplier121\".\"number\" o141, NULL o142, NULL o143, NULL o144, NULL o145, NULL o146, NULL o147, NULL o148, NULL o149, NULL o150, NULL o151, NULL o152, NULL o153, NULL o154, \"ensupplier121\".\"n_ident_fis_1\" o155, NULL o156, NULL o157, NULL o158, NULL o159, NULL o160, NULL o161, NULL o162, NULL o163, NULL o164, NULL o165");
fromBuilder.Append(" FROM ((((((((({Folio} \"enfolio72\" Left JOIN {Supplier} \"ensupplier121\" ON (\"enfolio72\".\"supplierid\" = \"ensupplier121\".\"id\"))  Left JOIN {OrderMain} \"enordermain114\" ON (\"enfolio72\".\"orderid\" = \"enordermain114\".\"id\"))  Left JOIN {OrderDetail} \"enorderdetail19\" ON (\"enorderdetail19\".\"orderid\" = \"enordermain114\".\"id\"))  Left JOIN {Project_Asset_Service} \"enproject_asset_service26\" ON (\"enorderdetail19\".\"projectassetserviceid\" = \"enproject_asset_service26\".\"id\"))  Left JOIN {Frequency} \"enfrequency8\" ON (\"enorderdetail19\".\"frequency\" = \"enfrequency8\".\"id\"))  Left JOIN {BusinessValueCategory} \"enbusinessvaluecategory5\" ON (\"enorderdetail19\".\"businessvaluecategoryid\" = \"enbusinessvaluecategory5\".\"id\"))  Left JOIN {BusinessValueSubcategory} \"enbusinessvaluesubcategory5\" ON (\"enorderdetail19\".\"businessvaluesubcategoryid\" = \"enbusinessvaluesubcategory5\".\"id\"))  Left JOIN {Company} \"encompany59\" ON (\"enordermain114\".\"companyid\" = \"encompany59\".\"id\"))  Left JOIN {FolioSAPData} \"enfoliosapdata14\" ON (\"enfolio72\".\"id\" = \"enfoliosapdata14\".\"folioid\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoFolio_Id != 0) {
whereBuilder.Append("((\"enfolio72\".\"id\" = @qpfoFolio_Id) AND (\"enfolio72\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolio_Id", DbType.Int64, qpfoFolio_Id);
} else {
whereBuilder.Append("(\"enfolio72\".\"id\" IS NULL)");
}
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_7da4463726b1a0efdce09801de464da8 outParamList = new RL_7da4463726b1a0efdce09801de464da8();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFolioByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[10];
opt[0] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, true, true, true, true, true, true, false});
opt[1] = new BitArray(new bool[] {false, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true});
opt[2] = new BitArray(new bool[] {false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, true, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true});
opt[6] = new BitArray(new bool[] {true, false, true, true});
opt[7] = new BitArray(new bool[] {true, false, true, true, true, true, true});
opt[8] = new BitArray(new bool[] {true, false, true, true, true, true});
opt[9] = new BitArray(new bool[] {true, false, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query y_Utils.InvoiceReportPdf.GetMainData.GetFolioById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_7da4463726b1a0efdce09801de464da8 _tmp = new RL_7da4463726b1a0efdce09801de464da8();
_tmp.AlternateReadDbMethodAsync = datasetGetFolioByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query y_Utils.InvoiceReportPdf.GetMainData.GetFolioById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_7da4463726b1a0efdce09801de464da8)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}

// Query Function "GetFolioFilesByFolioId" EEx_jExGcEesu9Ghlu124A of Action "GetMainData"
public static async Task<(RL_897c95bca5499c293930e47bf793d0d9,long)> datasetGetFolioFilesByFolioId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolioId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("y_Utils.InvoiceReportPdf.GetMainData.GetFolioFilesByFolioId", "8c7f4c10-464c-4770-acbb-d1a196ed76e0");
using var queryActivity = activitySource.CreateAggregateQueryActivity("y_Utils.InvoiceReportPdf.GetMainData.GetFolioFilesByFolioId", "8c7f4c10-464c-4770-acbb-d1a196ed76e0", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /NRWebFlows.JAcgewyqEkOMCfBjsT2WtQ/NodesShownInESpaceTree.7rpNb_jWDkCycCc+yoChag/DataActions.1Gn1jaRDJkKT7YMfuyo7iQ/NodesNotShownInESpaceTree.EEx_jExGcEesu9Ghlu124A, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enfoliofiles7\".\"filename\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7");
fromBuilder.Append(" FROM {FolioFiles} \"enfoliofiles7\"");
whereBuilder.Append(" WHERE ");
if (qpfoFolioId != 0) {
whereBuilder.Append("((\"enfoliofiles7\".\"folioid\" = @qpfoFolioId) AND (\"enfoliofiles7\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioId", DbType.Int64, qpfoFolioId);
} else {
whereBuilder.Append("(\"enfoliofiles7\".\"folioid\" IS NULL)");
}
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_897c95bca5499c293930e47bf793d0d9 outParamList = new RL_897c95bca5499c293930e47bf793d0d9();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, false, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query y_Utils.InvoiceReportPdf.GetMainData.GetFolioFilesByFolioId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_897c95bca5499c293930e47bf793d0d9 _tmp = new RL_897c95bca5499c293930e47bf793d0d9();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query y_Utils.InvoiceReportPdf.GetMainData.GetFolioFilesByFolioId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_897c95bca5499c293930e47bf793d0d9)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}

// Query Function "GetOrderMainItemsByOrderMainId" Zol+uKn3A0KHrxGkF385xA of Action "GetMainData"
public static async Task<(RL_361bfb1983e170050cb9d371d001b386,long)> datasetGetOrderMainItemsByOrderMainId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderMainId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("y_Utils.InvoiceReportPdf.GetMainData.GetOrderMainItemsByOrderMainId", "b87e8966-f7a9-4203-87af-11a4177f39c4");
using var queryActivity = activitySource.CreateAggregateQueryActivity("y_Utils.InvoiceReportPdf.GetMainData.GetOrderMainItemsByOrderMainId", "b87e8966-f7a9-4203-87af-11a4177f39c4", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /NRWebFlows.JAcgewyqEkOMCfBjsT2WtQ/NodesShownInESpaceTree.7rpNb_jWDkCycCc+yoChag/DataActions.1Gn1jaRDJkKT7YMfuyo7iQ/NodesNotShownInESpaceTree.Zol+uKn3A0KHrxGkF385xA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, \"enordermainitem23\".\"pepelement\" o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50");
fromBuilder.Append(" FROM {OrderMainItem} \"enordermainitem23\"");
whereBuilder.Append(" WHERE ");
if (qporOrderMainId != 0) {
whereBuilder.Append("((\"enordermainitem23\".\"ordermainid\" = @qporOrderMainId) AND (\"enordermainitem23\".\"ordermainid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderMainId", DbType.Int64, qporOrderMainId);
} else {
whereBuilder.Append("(\"enordermainitem23\".\"ordermainid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enordermainitem23\".\"pepelement\" <> '')");
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_361bfb1983e170050cb9d371d001b386 outParamList = new RL_361bfb1983e170050cb9d371d001b386();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query y_Utils.InvoiceReportPdf.GetMainData.GetOrderMainItemsByOrderMainId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_361bfb1983e170050cb9d371d001b386 _tmp = new RL_361bfb1983e170050cb9d371d001b386();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query y_Utils.InvoiceReportPdf.GetMainData.GetOrderMainItemsByOrderMainId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_361bfb1983e170050cb9d371d001b386)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}

private static async Task<RC_b6257dfb536e679f8b7be7b4b56f189b> datasetGetInvoiceByIdReadDbAsync(RC_b6257dfb536e679f8b7be7b4b56f189b rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceExtended.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceById" FFpc0A0zbU6cxPrv92DW+Q of Action "GetMainData"
public static async Task<(RL_1f9a243d40703326d9bf7c63586316cd,long)> datasetGetInvoiceById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoice_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("y_Utils.InvoiceReportPdf.GetMainData.GetInvoiceById", "d05c5a14-330d-4e6d-9cc4-faeff760d6f9");
using var queryActivity = activitySource.CreateAggregateQueryActivity("y_Utils.InvoiceReportPdf.GetMainData.GetInvoiceById", "d05c5a14-330d-4e6d-9cc4-faeff760d6f9", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /NRWebFlows.JAcgewyqEkOMCfBjsT2WtQ/NodesShownInESpaceTree.7rpNb_jWDkCycCc+yoChag/DataActions.1Gn1jaRDJkKT7YMfuyo7iQ/NodesNotShownInESpaceTree.FFpc0A0zbU6cxPrv92DW+Q, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"eninvoice138\".\"name\" o1, \"eninvoice138\".\"requisitionid\" o2, \"eninvoice138\".\"folioid\" o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, \"eninvoiceextended35\".\"fechaemision\" o28, NULL o29, NULL o30, NULL o31, trim_scale(\"eninvoiceextended35\".\"subtotal\"::numeric) o32, NULL o33, trim_scale(\"eninvoiceextended35\".\"totaliva\"::numeric) o34, trim_scale(\"eninvoiceextended35\".\"retenciones\"::numeric) o35, trim_scale(\"eninvoiceextended35\".\"total\"::numeric) o36, NULL o37, \"eninvoiceextended35\".\"moneda\" o38, NULL o39, NULL o40, NULL o41, NULL o42");
fromBuilder.Append(" FROM ({Invoice} \"eninvoice138\" Left JOIN {InvoiceExtended} \"eninvoiceextended35\" ON (\"eninvoice138\".\"id\" = \"eninvoiceextended35\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoice_Id != 0) {
whereBuilder.Append("((\"eninvoice138\".\"id\" = @qpinInvoice_Id) AND (\"eninvoice138\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoice_Id", DbType.Int64, qpinInvoice_Id);
} else {
whereBuilder.Append("(\"eninvoice138\".\"id\" IS NULL)");
}
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_1f9a243d40703326d9bf7c63586316cd outParamList = new RL_1f9a243d40703326d9bf7c63586316cd();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoiceByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, false, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, false, true, true, true, false, true, false, false, false, true, false, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query y_Utils.InvoiceReportPdf.GetMainData.GetInvoiceById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_1f9a243d40703326d9bf7c63586316cd _tmp = new RL_1f9a243d40703326d9bf7c63586316cd();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoiceByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query y_Utils.InvoiceReportPdf.GetMainData.GetInvoiceById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_1f9a243d40703326d9bf7c63586316cd)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}

private static async Task<RC_8f1f5794477fd248ce426e958892e780> datasetGetRequisitionByIdReadDbAsync(RC_8f1f5794477fd248ce426e958892e780 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENBusinessValueCategory.Read( r, ref index);
rec.ssENBusinessValueSubcategory.Read( r, ref index);
rec.ssENFrequency.Read( r, ref index);
rec.ssENProject_Asset_Service.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetRequisitionById" 4tqQ5fcEMke2Sw5v4vkE_w of Action "GetMainData"
public static async Task<(RL_d37c3599312f2bd85c82314399f4e20e,long)> datasetGetRequisitionById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisition_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("y_Utils.InvoiceReportPdf.GetMainData.GetRequisitionById", "e590dae2-04f7-4732-b64b-0e6fe2f904ff");
using var queryActivity = activitySource.CreateAggregateQueryActivity("y_Utils.InvoiceReportPdf.GetMainData.GetRequisitionById", "e590dae2-04f7-4732-b64b-0e6fe2f904ff", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /NRWebFlows.JAcgewyqEkOMCfBjsT2WtQ/NodesShownInESpaceTree.7rpNb_jWDkCycCc+yoChag/DataActions.1Gn1jaRDJkKT7YMfuyo7iQ/NodesNotShownInESpaceTree.4tqQ5fcEMke2Sw5v4vkE_w, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enbusinessvaluecategory6\".\"description\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, \"enbusinessvaluesubcategory6\".\"description\" o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, \"enfrequency9\".\"label\" o14, NULL o15, NULL o16, NULL o17, \"enproject_asset_service27\".\"description\" o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, \"enrequisition122\".\"name\" o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, \"enrequisition122\".\"projectdescription\" o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, \"ensupplier122\".\"name\" o84, \"ensupplier122\".\"number\" o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, \"ensupplier122\".\"n_ident_fis_1\" o99, NULL o100, NULL o101, NULL o102, NULL o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, NULL o109");
fromBuilder.Append(" FROM ((((({Requisition} \"enrequisition122\" Left JOIN {Supplier} \"ensupplier122\" ON (\"enrequisition122\".\"supplierid\" = \"ensupplier122\".\"id\"))  Left JOIN {Project_Asset_Service} \"enproject_asset_service27\" ON (\"enrequisition122\".\"projectassetserviceid\" = \"enproject_asset_service27\".\"id\"))  Left JOIN {Frequency} \"enfrequency9\" ON (\"enrequisition122\".\"frequencyid\" = \"enfrequency9\".\"id\"))  Left JOIN {BusinessValueCategory} \"enbusinessvaluecategory6\" ON (\"enrequisition122\".\"businessvaluecategoryid\" = \"enbusinessvaluecategory6\".\"id\"))  Left JOIN {BusinessValueSubcategory} \"enbusinessvaluesubcategory6\" ON (\"enrequisition122\".\"businessvaluesubcategoryid\" = \"enbusinessvaluesubcategory6\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpreRequisition_Id != 0) {
whereBuilder.Append("((\"enrequisition122\".\"id\" = @qpreRequisition_Id) AND (\"enrequisition122\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisition_Id", DbType.Int64, qpreRequisition_Id);
} else {
whereBuilder.Append("(\"enrequisition122\".\"id\" IS NULL)");
}
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_d37c3599312f2bd85c82314399f4e20e outParamList = new RL_d37c3599312f2bd85c82314399f4e20e();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetRequisitionByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[6];
opt[0] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, false, true, true});
opt[3] = new BitArray(new bool[] {true, false, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, false, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, false, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query y_Utils.InvoiceReportPdf.GetMainData.GetRequisitionById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_d37c3599312f2bd85c82314399f4e20e _tmp = new RL_d37c3599312f2bd85c82314399f4e20e();
_tmp.AlternateReadDbMethodAsync = datasetGetRequisitionByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query y_Utils.InvoiceReportPdf.GetMainData.GetRequisitionById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_d37c3599312f2bd85c82314399f4e20e)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}
}
public static class FuncDataActionGetTableItems {

// Query Function "GetInvoiceItems" ABiB_qiCokClZol8xmnqCg of Action "GetTableItems"
public static async Task<(RL_772f048f6ee632348101044a1e0eef2f,long)> datasetGetInvoiceItems(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("y_Utils.InvoiceReportPdf.GetTableItems.GetInvoiceItems", "fe811800-82a8-40a2-a566-897cc669ea0a");
using var queryActivity = activitySource.CreateAggregateQueryActivity("y_Utils.InvoiceReportPdf.GetTableItems.GetInvoiceItems", "fe811800-82a8-40a2-a566-897cc669ea0a", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /NRWebFlows.JAcgewyqEkOMCfBjsT2WtQ/NodesShownInESpaceTree.7rpNb_jWDkCycCc+yoChag/DataActions._OMCptZHJUWPdMuk_Px66A/NodesNotShownInESpaceTree.ABiB_qiCokClZol8xmnqCg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"eninvoiceextendeditem11\".\"productnumber\" o2, \"eninvoiceextendeditem11\".\"description\" o3, \"eninvoiceextendeditem11\".\"materialcode\" o4, \"eninvoiceextendeditem11\".\"quantity\" o5, trim_scale(\"eninvoiceextendeditem11\".\"unityprice\"::numeric) o6, \"eninvoiceextendeditem11\".\"currency\" o7");
fromBuilder.Append(" FROM {InvoiceExtendedItem} \"eninvoiceextendeditem11\"");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceId != 0) {
whereBuilder.Append("((\"eninvoiceextendeditem11\".\"invoiceid\" = @qpinInvoiceId) AND (\"eninvoiceextendeditem11\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceId", DbType.Int64, qpinInvoiceId);
} else {
whereBuilder.Append("(\"eninvoiceextendeditem11\".\"invoiceid\" IS NULL)");
}
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_772f048f6ee632348101044a1e0eef2f outParamList = new RL_772f048f6ee632348101044a1e0eef2f();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query y_Utils.InvoiceReportPdf.GetTableItems.GetInvoiceItems.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_772f048f6ee632348101044a1e0eef2f _tmp = new RL_772f048f6ee632348101044a1e0eef2f();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query y_Utils.InvoiceReportPdf.GetTableItems.GetInvoiceItems.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_772f048f6ee632348101044a1e0eef2f)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}
}
public static class FuncDataActionGetInvoiceFiles {

// Query Function "GetInvoiceFilesByInvoiceId" Z8kc7psV3UOe0LTjsJbCwQ of Action "GetInvoiceFiles"
public static async Task<(RL_00a03f803f0d49826089181417370afb,long)> datasetGetInvoiceFilesByInvoiceId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("y_Utils.InvoiceReportPdf.GetInvoiceFiles.GetInvoiceFilesByInvoiceId", "ee1cc967-159b-43dd-9ed0-b4e3b096c2c1");
using var queryActivity = activitySource.CreateAggregateQueryActivity("y_Utils.InvoiceReportPdf.GetInvoiceFiles.GetInvoiceFilesByInvoiceId", "ee1cc967-159b-43dd-9ed0-b4e3b096c2c1", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /NRWebFlows.JAcgewyqEkOMCfBjsT2WtQ/NodesShownInESpaceTree.7rpNb_jWDkCycCc+yoChag/DataActions.EMc7vcIrzkmqXnZwfFDYug/NodesNotShownInESpaceTree.Z8kc7psV3UOe0LTjsJbCwQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"eninvoicefile48\".\"filename\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7");
fromBuilder.Append(" FROM {InvoiceFile} \"eninvoicefile48\"");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceId != 0) {
whereBuilder.Append("((\"eninvoicefile48\".\"invoiceid\" = @qpinInvoiceId) AND (\"eninvoicefile48\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceId", DbType.Int64, qpinInvoiceId);
} else {
whereBuilder.Append("(\"eninvoicefile48\".\"invoiceid\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"eninvoicefile48\".\"isextra\" ASC , \"eninvoicefile48\".\"createdon\" ASC ");
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_00a03f803f0d49826089181417370afb outParamList = new RL_00a03f803f0d49826089181417370afb();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, false, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query y_Utils.InvoiceReportPdf.GetInvoiceFiles.GetInvoiceFilesByInvoiceId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_00a03f803f0d49826089181417370afb _tmp = new RL_00a03f803f0d49826089181417370afb();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query y_Utils.InvoiceReportPdf.GetInvoiceFiles.GetInvoiceFilesByInvoiceId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_00a03f803f0d49826089181417370afb)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}
}
public static class FuncDataActionGetEletronicAuthorizations {

private static async Task<RC_bc42b3285bc8089ad06a2c8ae4ee05e7> datasetGetInvoiceApprovalsByInvoiceIdReadDbAsync(RC_bc42b3285bc8089ad06a2c8ae4ee05e7 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENEntraRole.Read( r, ref index);
rec.ssENInvoiceApproval.Read( r, ref index);
rec.ssENInvoiceApprovalLevel.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceApprovalsByInvoiceId" oDs0om+EAESzjyHcUMZqmw of Action "GetEletronicAuthorizations"
public static async Task<(RL_1abe1514d325a5123b34272c27068edf,long)> datasetGetInvoiceApprovalsByInvoiceId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceApproval_InvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("y_Utils.InvoiceReportPdf.GetEletronicAuthorizations.GetInvoiceApprovalsByInvoiceId", "a2343ba0-846f-4400-b38f-21dc50c66a9b");
using var queryActivity = activitySource.CreateAggregateQueryActivity("y_Utils.InvoiceReportPdf.GetEletronicAuthorizations.GetInvoiceApprovalsByInvoiceId", "a2343ba0-846f-4400-b38f-21dc50c66a9b", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Single
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /NRWebFlows.JAcgewyqEkOMCfBjsT2WtQ/NodesShownInESpaceTree.7rpNb_jWDkCycCc+yoChag/DataActions.xJbZ_+DhxEmu9YLT5fvGfA/NodesNotShownInESpaceTree.oDs0om+EAESzjyHcUMZqmw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enentrarole68\".\"rolename\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, \"eninvoiceapprovallevel42\".\"approvedon\" o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, \"enuser195\".\"name\" o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65");
fromBuilder.Append(" FROM (((({InvoiceApproval} \"eninvoiceapproval44\" Left JOIN {InvoiceApprovalLevel} \"eninvoiceapprovallevel42\" ON (\"eninvoiceapproval44\".\"id\" = \"eninvoiceapprovallevel42\".\"invoiceapprovalid\"))  Left JOIN {User} \"enuser195\" ON (\"eninvoiceapprovallevel42\".\"approvedby\" = \"enuser195\".\"id\"))  Left JOIN {User_Extended_Internal} \"enuser_extended_internal123\" ON (\"enuser195\".\"id\" = \"enuser_extended_internal123\".\"id\"))  Left JOIN {EntraRole} \"enentrarole68\" ON (\"enuser_extended_internal123\".\"entraroleid\" = \"enentrarole68\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceApproval_InvoiceId != 0) {
whereBuilder.Append("((\"eninvoiceapproval44\".\"invoiceid\" = @qpinInvoiceApproval_InvoiceId) AND (\"eninvoiceapproval44\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceApproval_InvoiceId", DbType.Int64, qpinInvoiceApproval_InvoiceId);
} else {
whereBuilder.Append("(\"eninvoiceapproval44\".\"invoiceid\" IS NULL)");
}
whereBuilder.Append(" AND (\"eninvoiceapprovallevel42\".\"approvedby\" IS NOT NULL)");
orderByBuilder.Append(" ORDER BY \"eninvoiceapprovallevel42\".\"approvedon\" ASC ");
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_1abe1514d325a5123b34272c27068edf outParamList = new RL_1abe1514d325a5123b34272c27068edf();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoiceApprovalsByInvoiceIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[5];
opt[0] = new BitArray(new bool[] {true, false, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, false, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query y_Utils.InvoiceReportPdf.GetEletronicAuthorizations.GetInvoiceApprovalsByInvoiceId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_1abe1514d325a5123b34272c27068edf _tmp = new RL_1abe1514d325a5123b34272c27068edf();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoiceApprovalsByInvoiceIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query y_Utils.InvoiceReportPdf.GetEletronicAuthorizations.GetInvoiceApprovalsByInvoiceId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_1abe1514d325a5123b34272c27068edf)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}

private static async Task<RC_eecf597d9aac604956ae34e0eea91058> datasetGetFolioApprovalsByFolioIdReadDbAsync(RC_eecf597d9aac604956ae34e0eea91058 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolioApproval.Read( r, ref index);
rec.ssENFolioApprovalLevel.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
return rec;
}
// Query Function "GetFolioApprovalsByFolioId" VY67tE1DcUyon7EvvHBNKg of Action "GetEletronicAuthorizations"
public static async Task<(RL_22c684c9a7250fc07aca158787cc388d,long)> datasetGetFolioApprovalsByFolioId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolioApproval_FolioId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("y_Utils.InvoiceReportPdf.GetEletronicAuthorizations.GetFolioApprovalsByFolioId", "b4bb8e55-434d-4c71-a89f-b12fbc704d2a");
using var queryActivity = activitySource.CreateAggregateQueryActivity("y_Utils.InvoiceReportPdf.GetEletronicAuthorizations.GetFolioApprovalsByFolioId", "b4bb8e55-434d-4c71-a89f-b12fbc704d2a", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Single
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /NRWebFlows.JAcgewyqEkOMCfBjsT2WtQ/NodesShownInESpaceTree.7rpNb_jWDkCycCc+yoChag/DataActions.xJbZ_+DhxEmu9YLT5fvGfA/NodesNotShownInESpaceTree.VY67tE1DcUyon7EvvHBNKg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, \"enfolioapprovallevel35\".\"entrajobtitle\" o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, \"enfolioapprovallevel35\".\"approvedon\" o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, \"enuser196\".\"name\" o31, NULL o32, NULL o33, NULL o34");
fromBuilder.Append(" FROM (({FolioApproval} \"enfolioapproval39\" Left JOIN {FolioApprovalLevel} \"enfolioapprovallevel35\" ON (\"enfolioapproval39\".\"id\" = \"enfolioapprovallevel35\".\"folioapprovalid\"))  Left JOIN {User} \"enuser196\" ON (\"enfolioapprovallevel35\".\"approvedby\" = \"enuser196\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoFolioApproval_FolioId != 0) {
whereBuilder.Append("((\"enfolioapproval39\".\"folioid\" = @qpfoFolioApproval_FolioId) AND (\"enfolioapproval39\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioApproval_FolioId", DbType.Int64, qpfoFolioApproval_FolioId);
} else {
whereBuilder.Append("(\"enfolioapproval39\".\"folioid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enfolioapprovallevel35\".\"approvedby\" IS NOT NULL)");
orderByBuilder.Append(" ORDER BY \"enfolioapprovallevel35\".\"approvedon\" ASC ");
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_22c684c9a7250fc07aca158787cc388d outParamList = new RL_22c684c9a7250fc07aca158787cc388d();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFolioApprovalsByFolioIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, false, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, false, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query y_Utils.InvoiceReportPdf.GetEletronicAuthorizations.GetFolioApprovalsByFolioId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_22c684c9a7250fc07aca158787cc388d _tmp = new RL_22c684c9a7250fc07aca158787cc388d();
_tmp.AlternateReadDbMethodAsync = datasetGetFolioApprovalsByFolioIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query y_Utils.InvoiceReportPdf.GetEletronicAuthorizations.GetFolioApprovalsByFolioId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_22c684c9a7250fc07aca158787cc388d)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}
}


}
