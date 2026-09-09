namespace ssConectaProveedores;

public partial class Actions {
public class lcvGenerateFolioSAECReport : VarsBag {
public int inParami_OffsetUtc;
public bool inParamIsToEmpty;
public long inParamSupplierId;
public long inParamUserRegion;
public bool inParamIsAllRegions;
public string inParamReport60_OrderNumber;
public long inParamReport60_SupplierId;
public DateTime inParamReport60_StartDate;
public DateTime inParamReport60_EndDate;
public long inParamReport60_RegionId;
public int inParamReport60_StatusId;
public long inParamReport60_SociedadId;
public string inParamReport60_Applicant;
public long inParamReport60_AreaId;
public Actions.lcoLogsAccountingCreate resLogsAccountingCreate =  new Actions.lcoLogsAccountingCreate();
public byte[] resRecordListToExcel_outParamOut = new byte[] {};
public RL_5a216f9f46f02cbbd2515f4bd8546fd0 queryResGetFolioSAECItems_outParamList = new RL_5a216f9f46f02cbbd2515f4bd8546fd0();
public long queryResGetFolioSAECItems_outParamCount = 0L;

public lcvGenerateFolioSAECReport(int inParami_OffsetUtc, bool inParamIsToEmpty, long inParamSupplierId, long inParamUserRegion, bool inParamIsAllRegions, string inParamReport60_OrderNumber, long inParamReport60_SupplierId, DateTime inParamReport60_StartDate, DateTime inParamReport60_EndDate, long inParamReport60_RegionId, int inParamReport60_StatusId, long inParamReport60_SociedadId, string inParamReport60_Applicant, long inParamReport60_AreaId) {
this.inParami_OffsetUtc = inParami_OffsetUtc;
this.inParamIsToEmpty = inParamIsToEmpty;
this.inParamSupplierId = inParamSupplierId;
this.inParamUserRegion = inParamUserRegion;
this.inParamIsAllRegions = inParamIsAllRegions;
this.inParamReport60_OrderNumber = inParamReport60_OrderNumber;
this.inParamReport60_SupplierId = inParamReport60_SupplierId;
this.inParamReport60_StartDate = inParamReport60_StartDate;
this.inParamReport60_EndDate = inParamReport60_EndDate;
this.inParamReport60_RegionId = inParamReport60_RegionId;
this.inParamReport60_StatusId = inParamReport60_StatusId;
this.inParamReport60_SociedadId = inParamReport60_SociedadId;
this.inParamReport60_Applicant = inParamReport60_Applicant;
this.inParamReport60_AreaId = inParamReport60_AreaId;
}
}
public class lcoGenerateFolioSAECReport : VarsBag {
public ST_a158c76eb93396680623c04244f48b6cStructure outParamFile = new ST_a158c76eb93396680623c04244f48b6cStructure();

public lcoGenerateFolioSAECReport() {
}
}
/// <summary>
/// Action <code>GenerateFolioSAECReport</code> that represents the Service Studio action
///  <code>GenerateFolioSAECReport</code> <p> Description: </p>
/// </summary>
public static async Task<ST_a158c76eb93396680623c04244f48b6cStructure> ActionGenerateFolioSAECReport(IRequestContext requestContext,int inParami_OffsetUtc,bool inParamIsToEmpty,long inParamSupplierId,long inParamUserRegion,bool inParamIsAllRegions,string inParamReport60_OrderNumber,long inParamReport60_SupplierId,DateTime inParamReport60_StartDate,DateTime inParamReport60_EndDate,long inParamReport60_RegionId,int inParamReport60_StatusId,long inParamReport60_SociedadId,string inParamReport60_Applicant,long inParamReport60_AreaId,CancellationToken cancellationToken) {
ST_a158c76eb93396680623c04244f48b6cStructure outParamFile = default;
lcoGenerateFolioSAECReport result = new lcoGenerateFolioSAECReport();
lcvGenerateFolioSAECReport localVars = new lcvGenerateFolioSAECReport(inParami_OffsetUtc, inParamIsToEmpty, inParamSupplierId, inParamUserRegion, inParamIsAllRegions, inParamReport60_OrderNumber, inParamReport60_SupplierId, inParamReport60_StartDate, inParamReport60_EndDate, inParamReport60_RegionId, inParamReport60_StatusId, inParamReport60_SociedadId, inParamReport60_Applicant, inParamReport60_AreaId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GenerateFolioSAECReport", "1c4bd3ac-9f0d-4bd8-9cdf-5e06d88b4e8a"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GenerateFolioSAECReport", "1c4bd3ac-9f0d-4bd8-9cdf-5e06d88b4e8a", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// LogsAccountingCreate
localVars.resLogsAccountingCreate.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "OffsetUTC", ssDescription = ((((("OffsetUtc: "+Convert.ToString(localVars.inParami_OffsetUtc))+" // CurrDateTime UTC: ")+BuiltInFunction.DateTimeToText(BuiltInFunction.CurrDateTime ()))+" // CurrDateTime: ")+BuiltInFunction.DateTimeToText(BuiltInFunction.AddHours (BuiltInFunction.CurrDateTime (), localVars.inParami_OffsetUtc))), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("kIHkICg1hEmLRBFb0mHx0g"))).ssId },cancellationToken);

// Query QueryGetFolioSAECItems
cancellationToken.ThrowIfCancellationRequested();
int QueryGetFolioSAECItems_maxRecords = 999999999;
if (QueryGetFolioSAECItems_maxRecords < 1) QueryGetFolioSAECItems_maxRecords = 1;
int QueryGetFolioSAECItems_startIndex = 0;(localVars.queryResGetFolioSAECItems_outParamList,localVars.queryResGetFolioSAECItems_outParamCount) = await FuncActionGenerateFolioSAECReport.QueryGetFolioSAECItems(requestContext,QueryGetFolioSAECItems_maxRecords,QueryGetFolioSAECItems_startIndex,IterationMultiplicity.Single,(localVars.inParami_OffsetUtc*(-1)),localVars.inParamIsToEmpty,localVars.inParamSupplierId,localVars.inParamUserRegion,localVars.inParamIsAllRegions,localVars.inParamReport60_OrderNumber,localVars.inParamReport60_SupplierId,localVars.inParamReport60_StartDate,localVars.inParamReport60_EndDate,localVars.inParamReport60_RegionId,localVars.inParamReport60_StatusId,localVars.inParamReport60_SociedadId,localVars.inParamReport60_Applicant,localVars.inParamReport60_AreaId,BuiltInFunction.GetUserId (),(ENInvoiceTaxTypeEntity.GetRecordByKey(ObjectKey.Parse("jP_W+pSpRESLV3Fw0NPgPQ"))).ssId,2,(ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId,(ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("85A3EYx6OkWpq0CAyB7XJw"))).ssId,BuiltInFunction.NullDate (),Convert.ToInt64(BuiltInFunction.NullIdentifier ()),BuiltInFunction.NullTextIdentifier (),cancellationToken);

// RecordListToExcel RLToExcelGenerateFolioSAECReportRecordListToExcel
localVars.resRecordListToExcel_outParamOut = await FuncActionGenerateFolioSAECReport.RLToExcelGenerateFolioSAECReportRecordListToExcel(requestContext,localVars.queryResGetFolioSAECItems_outParamList,cancellationToken);

// File.BinaryData = RecordListToExcel
result.outParamFile.ssBinaryData = localVars.resRecordListToExcel_outParamOut;

// File.Name = "FoliosSAEC" + FormatDateTime + ".xlsx"
result.outParamFile.ssName = (("FoliosSAEC"+BuiltInFunction.FormatDateTime (BuiltInFunction.CurrDate (), "ddMMyy"))+".xlsx");
} //close CreateActionActivity using block
} // try

finally {
outParamFile = result.outParamFile;
} // inner-finally
RETURN_STATEMENT:
return outParamFile;
}

public static class FuncActionGenerateFolioSAECReport {

// Query Function "GetFolioSAECItems" UK2W2MmPI0yS+5l_PsUgHA of Action "GenerateFolioSAECReport"
public static async Task<(RL_5a216f9f46f02cbbd2515f4bd8546fd0,long)> QueryGetFolioSAECItems(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,int qpinOffsetUtc,bool qpboIsToEmpty,long qpsuSupplierId,long qpreUserRegion,bool qpboIsAllRegions,string qpteReport60_OrderNumber,long qpsuReport60_SupplierId,DateTime qpdaReport60_StartDate,DateTime qpdaReport60_EndDate,long qpreReport60_RegionId,int qpfoReport60_StatusId,long qpcoReport60_SociedadId,string qpteReport60_Applicant,long qpteReport60_AreaId,string qpusUserId,int qpinInvoiceTaxTypeTranslado,int qpcoConceptFcP,int qpapApprovalStatusNotApproved,int qpapApprovalStatusAssigned,DateTime qpdaNullDate,long qploNullIdentifier,string qpteNullTextIdentifier,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("GenerateFolioSAECReport.GetFolioSAECItems", "d896ad50-8fc9-4c23-92fb-997f3ec5201c");
using var queryActivity = activitySource.CreateSqlQueryActivity("GenerateFolioSAECReport.GetFolioSAECItems", "d896ad50-8fc9-4c23-92fb-997f3ec5201c", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Single
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string entityFolio = AppUtils.Instance.RuntimeEntityReplace("Folio");
string entityFolioApprovalLevel = AppUtils.Instance.RuntimeEntityReplace("FolioApprovalLevel");
string entityApplicationRole = AppUtils.Instance.RuntimeEntityReplace("ApplicationRole");
string entityUser = AppUtils.Instance.RuntimeEntityReplace("User");
string entityFolioApproval = AppUtils.Instance.RuntimeEntityReplace("FolioApproval");
string entityUser_Extended_Internal = AppUtils.Instance.RuntimeEntityReplace("User_Extended_Internal");
string entityRoleConcept = AppUtils.Instance.RuntimeEntityReplace("RoleConcept");
string entityOrderApprovalLevel = AppUtils.Instance.RuntimeEntityReplace("OrderApprovalLevel");
string entityOrderMain = AppUtils.Instance.RuntimeEntityReplace("OrderMain");
string entityOrderApproval = AppUtils.Instance.RuntimeEntityReplace("OrderApproval");
string entityFolioItems = AppUtils.Instance.RuntimeEntityReplace("FolioItems");
string entityOrderItemEntries = AppUtils.Instance.RuntimeEntityReplace("OrderItemEntries");
string entityOrderMainItem = AppUtils.Instance.RuntimeEntityReplace("OrderMainItem");
string entityFolioFiles = AppUtils.Instance.RuntimeEntityReplace("FolioFiles");
string entityInvoice = AppUtils.Instance.RuntimeEntityReplace("Invoice");
string entityInvoiceFile = AppUtils.Instance.RuntimeEntityReplace("InvoiceFile");
string entityEntraRole = AppUtils.Instance.RuntimeEntityReplace("EntraRole");
string entityOrdersImportRequest = AppUtils.Instance.RuntimeEntityReplace("OrdersImportRequest");
string entityFolioStatus = AppUtils.Instance.RuntimeEntityReplace("FolioStatus");
string entityApprovalProcessType = AppUtils.Instance.RuntimeEntityReplace("ApprovalProcessType");
string entityApprovalProcess = AppUtils.Instance.RuntimeEntityReplace("ApprovalProcess");
string entitySpecialPostDeliveryAuthorization = AppUtils.Instance.RuntimeEntityReplace("SpecialPostDeliveryAuthorization");
string entitySupplier = AppUtils.Instance.RuntimeEntityReplace("Supplier");
string entityCompany = AppUtils.Instance.RuntimeEntityReplace("Company");
string entityRegion = AppUtils.Instance.RuntimeEntityReplace("Region");
string entityCurrency = AppUtils.Instance.RuntimeEntityReplace("Currency");
string entityFolioSAPData = AppUtils.Instance.RuntimeEntityReplace("FolioSAPData");
string entityInvoiceExtended = AppUtils.Instance.RuntimeEntityReplace("InvoiceExtended");
string entityInvoiceExtendedTax = AppUtils.Instance.RuntimeEntityReplace("InvoiceExtendedTax");
string entityInvoiceStatus = AppUtils.Instance.RuntimeEntityReplace("InvoiceStatus");
string entityPaymentTerms = AppUtils.Instance.RuntimeEntityReplace("PaymentTerms");
string entityOrderAccConcepts = AppUtils.Instance.RuntimeEntityReplace("OrderAccConcepts");
string entityCostCenterSAP = AppUtils.Instance.RuntimeEntityReplace("CostCenterSAP");
string entityOrderDetail = AppUtils.Instance.RuntimeEntityReplace("OrderDetail");
string entityProject_Asset_Service = AppUtils.Instance.RuntimeEntityReplace("Project_Asset_Service");
string entityFrequency = AppUtils.Instance.RuntimeEntityReplace("Frequency");
string entityInvoicePoliza = AppUtils.Instance.RuntimeEntityReplace("InvoicePoliza");
string entityFolioExtended = AppUtils.Instance.RuntimeEntityReplace("FolioExtended");
string entitySpecialWorkflows = AppUtils.Instance.RuntimeEntityReplace("SpecialWorkflows");
string entitySupplierUser = AppUtils.Instance.RuntimeEntityReplace("SupplierUser");
string entityOrderAccounting = AppUtils.Instance.RuntimeEntityReplace("OrderAccounting");
string entityApplicant = AppUtils.Instance.RuntimeEntityReplace("Applicant");
sqlCmd.CreateParameter("@qpcoConceptFcP", DbType.Int32, qpcoConceptFcP);
sqlCmd.CreateParameter("@qpteNullTextIdentifier", DbType.String, qpteNullTextIdentifier);
sqlCmd.CreateParameter("@qpapApprovalStatusAssigned", DbType.Int32, qpapApprovalStatusAssigned);
sqlCmd.CreateParameter("@qpinOffsetUtc", DbType.Int32, qpinOffsetUtc);
sqlCmd.CreateParameter("@qpapApprovalStatusNotApproved", DbType.Int32, qpapApprovalStatusNotApproved);
sqlCmd.CreateParameter("@qpdaNullDate", DbType.DateTime, qpdaNullDate);
sqlCmd.CreateParameter("@qploNullIdentifier", DbType.Int64, qploNullIdentifier);
sqlCmd.CreateParameter("@qpsuSupplierId", DbType.Int64, qpsuSupplierId);
sqlCmd.CreateParameter("@qpinInvoiceTaxTypeTranslado", DbType.Int32, qpinInvoiceTaxTypeTranslado);
sqlCmd.CreateParameter("@qpboIsToEmpty", DbType.Boolean, qpboIsToEmpty);
sqlCmd.CreateParameter("@qpusUserId", DbType.String, qpusUserId);
sqlCmd.CreateParameter("@qpreUserRegion", DbType.Int64, qpreUserRegion);
sqlCmd.CreateParameter("@qpboIsAllRegions", DbType.Boolean, qpboIsAllRegions);
sqlCmd.CreateParameter("@qpteReport60_OrderNumber", DbType.String, qpteReport60_OrderNumber);
sqlCmd.CreateParameter("@qpsuReport60_SupplierId", DbType.Int64, qpsuReport60_SupplierId);
sqlCmd.CreateParameter("@qpdaReport60_StartDate", DbType.DateTime, qpdaReport60_StartDate);
sqlCmd.CreateParameter("@qpdaReport60_EndDate", DbType.DateTime, qpdaReport60_EndDate);
sqlCmd.CreateParameter("@qpreReport60_RegionId", DbType.Int64, qpreReport60_RegionId);
sqlCmd.CreateParameter("@qpfoReport60_StatusId", DbType.Int32, qpfoReport60_StatusId);
sqlCmd.CreateParameter("@qpcoReport60_SociedadId", DbType.Int64, qpcoReport60_SociedadId);
sqlCmd.CreateParameter("@qpteReport60_Applicant", DbType.String, qpteReport60_Applicant);
sqlCmd.CreateParameter("@qpteReport60_AreaId", DbType.Int64, qpteReport60_AreaId);
string sql = "";
string advSql = "WITH Approvers AS ( \n    SELECT   " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"id\"") + " AS FolioId, \n             " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioApprovalLevel,".\"entrajobtitle\"") + " AS EntraJobTitle, \n             " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioApprovalLevel,".\"approvedon\"") + " AS ApprovedOn, \n             " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApplicationRole,".\"name\"") + " AS ApplicationRole, \n            CASE WHEN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApplicationRole,".\"isareausuaria\"") + " = 1 THEN 1 ELSE 0 END AS IsAreaUsuaria, \n             " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,".\"name\"") + " AS UserName \n    FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,"") + " \n    LEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioApproval,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioApproval,".\"folioid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"id\"") + " \n    LEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioApprovalLevel,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioApprovalLevel,".\"folioapprovalid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioApproval,".\"id\"") + " \n    LEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioApprovalLevel,".\"approvedby\"") + " \n    LEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser_Extended_Internal,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser_Extended_Internal,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,".\"id\"") + " \n    LEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRoleConcept,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRoleConcept,".\"entraroleid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser_Extended_Internal,".\"entraroleid\"") + " AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRoleConcept,".\"conceptid\"") + " = @qpcoConceptFcP \n    LEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApplicationRole,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApplicationRole,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRoleConcept,".\"applicationroleid\"") + " \n    WHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioApprovalLevel,".\"approvedby\"") + " <> @qpteNullTextIdentifier \n    ORDER BY  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioApprovalLevel,".\"levelnumber\"") + " ASC \n), \n \nComplementAssignedDate AS( \n    SELECT  \n         " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"id\"") + " AS FolioId, \n         " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApprovalLevel,".\"assignedon\"") + " AS AssignedOn,  \n         " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApprovalLevel,".\"approvedon\"") + " AS ApprovedOn \n    FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,"") + " \n    LEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"id\"") + "  =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"orderid\"") + " \n    LEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApproval,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApproval,".\"orderid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"id\"") + " \n    LEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApprovalLevel,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApprovalLevel,".\"orderapprovalid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApproval,".\"id\"") + " \n    WHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApprovalLevel,".\"approvalstatusid\"") + " = @qpapApprovalStatusAssigned \n    ORDER BY  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApprovalLevel,".\"approvedon\"") + " DESC \n), \n \nOrderItemEntries AS( \n        SELECT  \n            Entry.FolioItemsId as FolioItemsId, \n            Entry.EntryDocument as EntryDocument, \n            Entry.CreatedOn as CreatedOn \n        FROM ( \n            SELECT  \n                 " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"id\"") + " AS FolioItemsId, \n                 " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"entrydocument\"") + " AS EntryDocument, \n                 " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"createdon\"") + " AS CreatedOn, \n                ROW_NUMBER() OVER ( \n                PARTITION BY  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"id\"") + " \n                ORDER BY  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"createdon\"") + " DESC \n                ) AS RN \n            FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,"") + " \n            LEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"id\"") + "  =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"ordermainitemid\"") + " \n            LEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"ordermainitemid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"id\"") + " \n            WHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"quantity_\"") + " < 0 \n        ) Entry \n        WHERE Entry.RN = 1        \n), \n \nExtraFilesFolio AS ( \n    SELECT \n        Files.FolioId AS FolioId, \n        STRING_AGG(Files.Filename, '; ') AS FileNames \n    FROM ( \n            SELECT  \n                 " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioFiles,".\"folioid\"") + " AS FolioId, \n                 " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioFiles,".\"filename\"") + " AS FileName \n            FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioFiles,"") + " \n \n            UNION ALL \n \n            SELECT \n                 " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoice,".\"folioid\"") + " AS FolioId, \n                 " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoiceFile,".\"filename\"") + " AS FileName \n            FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoiceFile,"") + " \n            INNER JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoice,"") + "  \n                ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoice,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoiceFile,".\"invoiceid\"") + " \n            WHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoiceFile,".\"isextra\"") + " = 1 \n        ) Files \n    GROUP BY Files.FolioId \n), \n \nInvoicePDFFile AS ( \n    SELECT \n         " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoiceFile,".\"invoiceid\"") + " AS InvoiceId, \n         " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoiceFile,".\"filename\"") + " AS FileName \n    FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoiceFile,"") + " \n    WHERE \n         " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoiceFile,".\"isextra\"") + " = 0 AND caseaccent_normalize( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoiceFile,".\"filename\"") + " COLLATE \"default\") LIKE caseaccent_normalize('%.pdf%') \n), \n \nInvoiceXMLFile AS ( \n    SELECT \n         " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoiceFile,".\"invoiceid\"") + " AS InvoiceId, \n         " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoiceFile,".\"filename\"") + " AS FileName \n    FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoiceFile,"") + " \n    WHERE \n         " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoiceFile,".\"isextra\"") + " = 0 AND caseaccent_normalize( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoiceFile,".\"filename\"") + " COLLATE \"default\") LIKE caseaccent_normalize('%.xml%') \n), \n \nOrderApprovers AS ( \n     SELECT   \n         " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApproval,".\"orderid\"") + " AS OrderId, \n        STRING_AGG( \n            COALESCE( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityEntraRole,".\"rolename\"") + ", '') || '/ ' || \n            COALESCE( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApplicationRole,".\"name\"") + ", '') || '@ ' || \n            TO_CHAR( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApprovalLevel,".\"approvedon\"") + " + (@qpinOffsetUtc * INTERVAL '1 hour'), 'DD/MM/YYYY'), \n            '; ' \n            ORDER BY  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApprovalLevel,".\"levelnumber\"") + " \n            ) AS Approvers \n    FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApproval,"") + " \n    LEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApprovalLevel,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApprovalLevel,".\"orderapprovalid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApproval,".\"id\"") + " \n    LEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApprovalLevel,".\"approvedby\"") + " \n    LEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser_Extended_Internal,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser_Extended_Internal,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,".\"id\"") + " \n    LEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRoleConcept,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRoleConcept,".\"entraroleid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser_Extended_Internal,".\"entraroleid\"") + " and  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRoleConcept,".\"conceptid\"") + " = @qpcoConceptFcP \n    LEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApplicationRole,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApplicationRole,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRoleConcept,".\"applicationroleid\"") + " \n    LEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityEntraRole,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityEntraRole,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser_Extended_Internal,".\"entraroleid\"") + " \n    WHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApprovalLevel,".\"approvedby\"") + " <> @qpteNullTextIdentifier \n    GROUP BY  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApproval,".\"orderid\"") + " \n), \n \nCurrentApprover AS ( \n    SELECT   \n         " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioApproval,".\"folioid\"") + " AS FolioId, \n         " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,".\"name\"") + " || '; ' ||  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityEntraRole,".\"rolename\"") + " AS Approver \n    FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioApproval,"") + " \n    LEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioApprovalLevel,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioApprovalLevel,".\"folioapprovalid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioApproval,".\"id\"") + " AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioApproval,".\"currentlevel\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioApprovalLevel,".\"levelnumber\"") + " \n    LEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioApprovalLevel,".\"assignedto\"") + " \n    LEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser_Extended_Internal,"") + " on  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser_Extended_Internal,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,".\"id\"") + " \n    LEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityEntraRole,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityEntraRole,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser_Extended_Internal,".\"entraroleid\"") + " \n    WHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioApprovalLevel,".\"assignedto\"") + " <> @qpteNullTextIdentifier AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioApprovalLevel,".\"approvalstatusid\"") + " = @qpapApprovalStatusNotApproved \n), \n \nLastUpdateOrder AS( \n        SELECT  \n            OrdersImportRequest.OrderMainId as OrderMainId, \n            TO_CHAR(OrdersImportRequest.CreatedOn + (@qpinOffsetUtc * INTERVAL '1 hour'), 'DD/MM/YYYY') as CreatedOn \n        FROM ( \n            SELECT  \n                 " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrdersImportRequest,".\"ordermainid\"") + " AS OrderMainId, \n                 " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrdersImportRequest,".\"createdon\"") + " AS CreatedOn, \n                ROW_NUMBER() OVER ( \n                PARTITION BY  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrdersImportRequest,".\"ordermainid\"") + " \n                ORDER BY  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrdersImportRequest,".\"createdon\"") + " DESC \n            ) AS RN \n            FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrdersImportRequest,"") + " \n        ) OrdersImportRequest \n        WHERE OrdersImportRequest.RN = 1        \n) \n \nSELECT  \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioStatus,".\"label\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"id\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"id\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"folionumber\"") + ", \n    CASE \n        WHEN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"createdon\"") + " <> @qpdaNullDate \n        THEN TO_CHAR( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"createdon\"") + ", 'DD/MM/YYYY') \n        ELSE '' \n    END, \n    'Flujo ' ||  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalProcessType,".\"label_es\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalProcess,".\"code\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySpecialPostDeliveryAuthorization,".\"label\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"ordernumber\"") + ", \n    CASE \n        WHEN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"orderdate\"") + " <> @qpdaNullDate \n        THEN TO_CHAR( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"orderdate\"") + ", 'DD/MM/YYYY') \n        ELSE '' \n    END, \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"number\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"name\"") + " || '/ ' ||  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"n_ident_fis_1\"") + " || '/ ' ||  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"number\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"applicant\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"assigmnentcode\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"description\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"code\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"position\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"materialcode\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"materialdescription\"") + ", \n    TO_CHAR( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"quantity\"") + ",'FM999,999,999,999,990.000'), \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"orderunitofmeasure\"") + ", \n    TO_CHAR( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"unitprice\"") + ",'FM999,999,999,999,990.00'), \n    TO_CHAR( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"partialamount\"") + ",'FM999,999,999,999,990.00'), \n    TO_CHAR( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"totalamount\"") + ",'FM999,999,999,999,990.00'), \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"code\"") + ", \n    ( \n        SELECT STRING_AGG( \n        COALESCE(Approvers.EntraJobTitle, '') || '/ ' || \n        COALESCE(Approvers.ApplicationRole, '') || '@ ' || \n        TO_CHAR(Approvers.ApprovedOn + (@qpinOffsetUtc * INTERVAL '1 hour'), 'DD/MM/YYYY'), \n        '; ' \n        ) \n        FROM Approvers \n        WHERE Approvers.FolioId =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"id\"") + " \n        AND Approvers.IsAreaUsuaria = 1 \n    ) AreaUsuariaApprovers, \n    ( \n        SELECT Approvers.UserName || '; ' || Approvers.EntraJobTitle \n        FROM Approvers \n        WHERE Approvers.FolioId =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"id\"") + " \n        AND Approvers.IsAreaUsuaria = 1 \n        LIMIT 1 \n    ) FirstApprover, \n    CASE \n        WHEN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoice,".\"accountingdatetime\"") + " <> @qpdaNullDate \n        THEN ( \n            CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoice,".\"accountingdatetime\"") + " AS DATE) \n            - CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"createdon\"") + " AS DATE) \n        ) \n        ELSE ( \n            CURRENT_DATE \n            - CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"createdon\"") + " AS DATE) \n        ) \n    END, \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioSAPData,".\"po_documento_material_em\"") + ", \n    CASE \n        WHEN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioSAPData,".\"createdon\"") + " <> @qpdaNullDate \n        THEN TO_CHAR( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioSAPData,".\"createdon\"") + " + (@qpinOffsetUtc * INTERVAL '1 hour'), 'DD/MM/YYYY') \n        ELSE '' \n    END, \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoice,".\"name\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoiceExtended,".\"uuid\"") + ", \n    CASE \n        WHEN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoiceExtended,".\"fechaemision\"") + " <> '' \n        THEN TO_CHAR(CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoiceExtended,".\"fechaemision\"") + " AS DATE), 'DD/MM/YYYY') \n        ELSE '' \n    END, \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoiceExtended,".\"moneda\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"pep\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"placeid\"") + ", \n    OrderItemEntries.EntryDocument, \n    CASE \n        WHEN OrderItemEntries.CreatedOn <> @qpdaNullDate \n        THEN TO_CHAR( \n            OrderItemEntries.CreatedOn + (@qpinOffsetUtc * INTERVAL '1 hour'), \n            'DD/MM/YYYY' \n        ) \n        ELSE '' \n    END, \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"procurementgroup\"") + ", \n    CASE \n        WHEN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApproval,".\"finishedon\"") + " <> @qpdaNullDate \n        THEN TO_CHAR( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApproval,".\"finishedon\"") + ", 'DD/MM/YYYY') \n        ELSE '' \n    END,    \n    CASE \n        WHEN ComplementAssignedDate.AssignedOn <> @qpdaNullDate \n        AND ComplementAssignedDate.ApprovedOn <> @qpdaNullDate \n        THEN \n            CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApproval,".\"finishedon\"") + " + (@qpinOffsetUtc * INTERVAL '1 hour') AS DATE) \n            - \n            CAST(ComplementAssignedDate.AssignedOn + (@qpinOffsetUtc * INTERVAL '1 hour') AS DATE) \n        ELSE 0 \n    END, \n    '', \n    ExtraFilesFolio.FileNames, \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoiceExtended,".\"serie\"") + ", \n    TO_CHAR( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoiceExtended,".\"subtotal\"") + ",'FM999,999,999,999,990.00'), \n    TO_CHAR( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoiceExtendedTax,".\"importe\"") + ",'FM999,999,999,999,990.00'), \n    TO_CHAR( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoiceExtended,".\"retenciones\"") + ",'FM999,999,999,999,990.00'), \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoiceStatus,".\"label\"") + ", \n    ( \n        SELECT Approvers.EntraJobTitle || '; ' || Approvers.ApplicationRole \n        FROM Approvers \n        WHERE Approvers.FolioId =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"id\"") + " \n        AND Approvers.IsAreaUsuaria = 1 \n        LIMIT 1 \n    ) FirstApproverJobTitleRol, \n    CASE \n        WHEN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoice,".\"createdon\"") + " <> @qpdaNullDate \n        THEN TO_CHAR( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoice,".\"createdon\"") + " + (@qpinOffsetUtc * INTERVAL '1 hour'), 'DD/MM/YYYY') \n        ELSE '' \n    END, \n    CASE \n    WHEN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoice,".\"createdon\"") + " <> @qpdaNullDate \n    THEN TO_CHAR( \n        ( \n            CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoice,".\"createdon\"") + " + (@qpinOffsetUtc * INTERVAL '1 hour') AS DATE) \n            + \n            CASE \n                WHEN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityPaymentTerms,".\"isspecial\"") + " = TRUE \n                    THEN COALESCE( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderAccConcepts,".\"paymenttermcustomdays\"") + ", 0) \n                ELSE \n                    CAST(NULLIF( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityPaymentTerms,".\"ctd_dias\"") + ", '') AS INTEGER) \n            END \n        ) \n        + \n        MOD( \n            8 - EXTRACT( \n                    ISODOW FROM ( \n                        CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoice,".\"createdon\"") + " + (@qpinOffsetUtc * INTERVAL '1 hour') AS DATE) \n                        + \n                        CASE \n                            WHEN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityPaymentTerms,".\"isspecial\"") + " = TRUE \n                                THEN COALESCE( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderAccConcepts,".\"paymenttermcustomdays\"") + ", 0) \n                            ELSE \n                                CAST(NULLIF( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityPaymentTerms,".\"ctd_dias\"") + ", '') AS INTEGER) \n                        END \n                    ) \n                )::INTEGER, \n            7 \n        ), \n        'DD/MM/YYYY' \n    ) \n    END, \n    InvoicePDFFile.FileName, \n    InvoiceXMLFile.FileName, \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"denominacion\"") + ", \n    OrderApprovers.Approvers, \n    CASE \n        WHEN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderDetail,".\"projectassetserviceid\"") + " = @qploNullIdentifier \n        THEN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderDetail,".\"projectassetservice\"") + " \n        ELSE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProject_Asset_Service,".\"description\"") + " \n    END, \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderDetail,".\"period\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFrequency,".\"label\"") + ", \n    CASE \n        WHEN NULLIF( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoice,".\"doc51\"") + ", '') IS NOT NULL \n        THEN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoice,".\"doc51\"") + " || ' / ' ||  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoice,".\"id_poliza_sap\"") + " \n        ELSE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoice,".\"id_poliza_sap\"") + " \n    END AS Poliza, \n    TO_CHAR( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoicePoliza,".\"createdon\"") + " + (@qpinOffsetUtc * INTERVAL '1 hour'), 'DD/MM/YYYY'), \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApproval,".\"lastapproverpuestodelgerente\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApproval,".\"lastapproverpuestodeljefe\"") + ", \n    CurrentApprover.Approver, \n    LastUpdateOrder.CreatedOn \nFROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"folioid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioStatus,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioStatus,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"foliostatusid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioExtended,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioExtended,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioSAPData,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioSAPData,".\"folioid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioApproval,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioApproval,".\"folioid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalProcess,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalProcess,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioApproval,".\"approvalprocessid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySpecialWorkflows,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySpecialWorkflows,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalProcess,".\"specialworkflowid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalProcessType,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalProcessType,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"approvalprocesstypeid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"code\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"currencyid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"supplierid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplierUser,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplierUser,".\"supplierid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"id\"") + " and @qpsuSupplierId::int <> @qploNullIdentifier \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"companyid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"ordermainitemid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"costcenterid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"orderid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApproval,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApproval,".\"orderid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderDetail,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderDetail,".\"orderid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProject_Asset_Service,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProject_Asset_Service,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderDetail,".\"projectassetserviceid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFrequency,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFrequency,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderDetail,".\"frequency\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderAccounting,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderAccounting,".\"orderid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySpecialPostDeliveryAuthorization,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySpecialPostDeliveryAuthorization,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderAccounting,".\"specialpostdeliveryauthid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"divisionid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApplicant,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApplicant,".\"applicant\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"applicant\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoice,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoice,".\"folioid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderAccConcepts,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderAccConcepts,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoice,".\"orderaccconceptsid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityPaymentTerms,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityPaymentTerms,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderAccConcepts,".\"paymenttermid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoiceExtended,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoiceExtended,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoice,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoiceStatus,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoiceStatus,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoice,".\"invoicestatusid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoicePoliza,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoicePoliza,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoice,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoiceExtendedTax,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoiceExtendedTax,".\"invoiceid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoice,".\"id\"") + " and  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoiceExtendedTax,".\"invoicetaxtypeid\"") + " = @qpinInvoiceTaxTypeTranslado and  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoiceExtendedTax,".\"impuesto\"") + " = '002' and  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoiceExtendedTax,".\"tipofactor\"") + " = 'Tasa'     \nLEFT JOIN ComplementAssignedDate ON ComplementAssignedDate.FolioId =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"id\"") + " \nLEFT JOIN OrderItemEntries ON OrderItemEntries.FolioItemsId =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"id\"") + " \nLEFT JOIN ExtraFilesFolio ON ExtraFilesFolio.FolioId =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"id\"") + " \nLEFT JOIN InvoicePDFFile ON InvoicePDFFile.InvoiceId =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoice,".\"id\"") + " \nLEFT JOIN InvoiceXMLFile ON InvoiceXMLFile.InvoiceId =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoice,".\"id\"") + " \nLEFT JOIN OrderApprovers ON OrderApprovers.OrderId =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"id\"") + " \nLEFT JOIN CurrentApprover ON CurrentApprover.FolioId =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"id\"") + " \nLEFT JOIN LastUpdateOrder ON LastUpdateOrder.OrderMainId =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"id\"") + " \nWHERE \n    @qpboIsToEmpty = 0 \n    AND (@qpsuSupplierId::int = @qploNullIdentifier OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplierUser,".\"userid\"") + " = @qpusUserId::text) \n    AND ( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"divisionid\"") + " = @qpreUserRegion::int OR @qpboIsAllRegions = 1) \n    AND (@qpteReport60_OrderNumber::text = '' OR caseaccent_normalize( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"ordernumber\"") + " COLLATE \"default\") LIKE caseaccent_normalize('%' || @qpteReport60_OrderNumber::text || '%')) \n    AND (@qpsuReport60_SupplierId::int = @qploNullIdentifier OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"id\"") + " = @qpsuReport60_SupplierId::int) \n    AND (@qpdaReport60_StartDate::date = @qpdaNullDate OR CAST(( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"createdon\"") + " + (@qpinOffsetUtc * INTERVAL '1 hour')) AS DATE) >= @qpdaReport60_StartDate::date) \n    AND (@qpdaReport60_EndDate::date = @qpdaNullDate OR CAST(( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"createdon\"") + " + (@qpinOffsetUtc * INTERVAL '1 hour')) AS DATE) <= @qpdaReport60_EndDate::date) \n    AND (@qpreReport60_RegionId::int = @qploNullIdentifier OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"id\"") + " = @qpreReport60_RegionId::int) \n    AND (@qpfoReport60_StatusId::int = @qploNullIdentifier OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"foliostatusid\"") + " = @qpfoReport60_StatusId::int) \n    AND (@qpcoReport60_SociedadId::int = @qploNullIdentifier OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"companyid\"") + " = @qpcoReport60_SociedadId::int) \n    AND (@qpteReport60_Applicant::text = '' OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"applicant\"") + " = @qpteReport60_Applicant::text) \n    AND (@qpteReport60_AreaId::int = @qploNullIdentifier OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"telceldirectionid\"") + " = @qpteReport60_AreaId::int) \nORDER BY  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"ordernumber\"") + " ASC,  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"position\"") + " ASC";
sql = advSql;
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_5a216f9f46f02cbbd2515f4bd8546fd0 outParamList = new RL_5a216f9f46f02cbbd2515f4bd8546fd0();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GenerateFolioSAECReport.GetFolioSAECItems.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_5a216f9f46f02cbbd2515f4bd8546fd0 _tmp = new RL_5a216f9f46f02cbbd2515f4bd8546fd0();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GenerateFolioSAECReport.GetFolioSAECItems.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_5a216f9f46f02cbbd2515f4bd8546fd0)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetFolioSAECItems in GenerateFolioSAECReport in ConectaProveedores (WITH Approvers AS (      SELECT  {Folio}.[Id] AS FolioId,              {FolioApprovalLevel}.[EntraJobTitle] AS EntraJobTitle,              {FolioApprovalLevel}.[ApprovedOn] AS ApprovedOn,              {ApplicationRole}.[Name] AS ApplicationRole,              CASE WHEN {ApplicationRole}.[IsAreaUsuaria] = 1 THEN 1 ELSE 0 END AS IsAreaUsuaria,              {User}.[Name] AS UserName      FROM {Folio}      LEFT JOIN {FolioApproval} ON {FolioApproval}.[FolioId] = {Folio}.[Id]      LEFT JOIN {FolioApprovalLevel} ON {FolioApprovalLevel}.[FolioApprovalId] = {FolioApproval}.[Id]      LEFT JOIN {User} ON {User}.[Id] = {FolioApprovalLevel}.[ApprovedBy]      LEFT JOIN {User_Extended_Internal} ON {User_Extended_Internal}.[Id] = {User}.[Id]      LEFT JOIN {RoleConcept} ON {RoleConcept}.[EntraRoleId] = {User_Extended_Internal}.[EntraRoleId] AND {RoleConcept}.[ConceptId] = @ConceptFcP      LEFT JOIN {ApplicationRole} ON {ApplicationRole}.[Id] = {RoleConcept}.[ApplicationRoleId]      WHERE {FolioApprova ...): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetFolioSAECItems in GenerateFolioSAECReport in ConectaProveedores (WITH Approvers AS (      SELECT  {Folio}.[Id] AS FolioId,              {FolioApprovalLevel}.[EntraJobTitle] AS EntraJobTitle,              {FolioApprovalLevel}.[ApprovedOn] AS ApprovedOn,              {ApplicationRole}.[Name] AS ApplicationRole,              CASE WHEN {ApplicationRole}.[IsAreaUsuaria] = 1 THEN 1 ELSE 0 END AS IsAreaUsuaria,              {User}.[Name] AS UserName      FROM {Folio}      LEFT JOIN {FolioApproval} ON {FolioApproval}.[FolioId] = {Folio}.[Id]      LEFT JOIN {FolioApprovalLevel} ON {FolioApprovalLevel}.[FolioApprovalId] = {FolioApproval}.[Id]      LEFT JOIN {User} ON {User}.[Id] = {FolioApprovalLevel}.[ApprovedBy]      LEFT JOIN {User_Extended_Internal} ON {User_Extended_Internal}.[Id] = {User}.[Id]      LEFT JOIN {RoleConcept} ON {RoleConcept}.[EntraRoleId] = {User_Extended_Internal}.[EntraRoleId] AND {RoleConcept}.[ConceptId] = @ConceptFcP      LEFT JOIN {ApplicationRole} ON {ApplicationRole}.[Id] = {RoleConcept}.[ApplicationRoleId]      WHERE {FolioApprova ...): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetFolioSAECItems in GenerateFolioSAECReport in ConectaProveedores (WITH Approvers AS (      SELECT  {Folio}.[Id] AS FolioId,              {FolioApprovalLevel}.[EntraJobTitle] AS EntraJobTitle,              {FolioApprovalLevel}.[ApprovedOn] AS ApprovedOn,              {ApplicationRole}.[Name] AS ApplicationRole,              CASE WHEN {ApplicationRole}.[IsAreaUsuaria] = 1 THEN 1 ELSE 0 END AS IsAreaUsuaria,              {User}.[Name] AS UserName      FROM {Folio}      LEFT JOIN {FolioApproval} ON {FolioApproval}.[FolioId] = {Folio}.[Id]      LEFT JOIN {FolioApprovalLevel} ON {FolioApprovalLevel}.[FolioApprovalId] = {FolioApproval}.[Id]      LEFT JOIN {User} ON {User}.[Id] = {FolioApprovalLevel}.[ApprovedBy]      LEFT JOIN {User_Extended_Internal} ON {User_Extended_Internal}.[Id] = {User}.[Id]      LEFT JOIN {RoleConcept} ON {RoleConcept}.[EntraRoleId] = {User_Extended_Internal}.[EntraRoleId] AND {RoleConcept}.[ConceptId] = @ConceptFcP      LEFT JOIN {ApplicationRole} ON {ApplicationRole}.[Id] = {RoleConcept}.[ApplicationRoleId]      WHERE {FolioApprova ...): " + aqExcep.Message));
}
}
}


/// <summary>
/// RecordList To Excel: RLToExcelGenerateFolioSAECReportRecordListToExcel (KMHD3krF6tU6BroDBxJOEHA) of
///  Action "GenerateFolioSAECReport"
/// </summary>
public static async Task<byte[]> RLToExcelGenerateFolioSAECReportRecordListToExcel(IRequestContext requestContext,RL_5a216f9f46f02cbbd2515f4bd8546fd0 ssRecordList,CancellationToken cancellationToken) {
var service = ServiceLocator.GetService<ISpreadsheetService>();
await using var excel = await service.GetWriterAsync(62, cancellationToken);

//Column headers
await excel.CreateRowAsync(0, cancellationToken);
excel.CreateCell("Estatus");
excel.CreateCell("Número de Folio SAEC");
excel.CreateCell("Fecha de Creación de Folio SAEC");
excel.CreateCell("Tipo de Flujo");
excel.CreateCell("Nombre de Flujo");
excel.CreateCell("Asignado a usuarios");
excel.CreateCell("Número de pedido");
excel.CreateCell("Fecha de Pedido");
excel.CreateCell("Número de Proveedor");
excel.CreateCell("Nombre de Proveedor");
excel.CreateCell("Solicitante");
excel.CreateCell("Imputación");
excel.CreateCell("Sociedad");
excel.CreateCell("Centro");
excel.CreateCell("Posición del pedido");
excel.CreateCell("Código SAP");
excel.CreateCell("Descripción");
excel.CreateCell("Cantidad");
excel.CreateCell("UMP");
excel.CreateCell("Precio Unitario");
excel.CreateCell("Monto autorizado");
excel.CreateCell("Importe Folio SAEC");
excel.CreateCell("Moneda");
excel.CreateCell("Puesto / Rol usuario aprobador");
excel.CreateCell("Usuario Aprobador inicial");
excel.CreateCell("Días en proceso sin entrada");
excel.CreateCell("N.º de Entrada de Mercancía");
excel.CreateCell("Fecha de entrada");
excel.CreateCell("Número de factura");
excel.CreateCell("UUID");
excel.CreateCell("Fecha de la factura");
excel.CreateCell("Moneda de la factura");
excel.CreateCell("Número PEP");
excel.CreateCell("Id del sitio");
excel.CreateCell("Anulación Entrada");
excel.CreateCell("Fecha de anulación Entrada");
excel.CreateCell("Cliente");
excel.CreateCell("Fecha de liberación de pedido CXP");
excel.CreateCell("Días transcurridos para liberación de pedido CXP");
excel.CreateCell("Aprobador SISEA");
excel.CreateCell("Archivos adjuntos");
excel.CreateCell("Serie");
excel.CreateCell("Sub Total");
excel.CreateCell("IVA");
excel.CreateCell("Retención");
excel.CreateCell("Estado de la factura");
excel.CreateCell("Asignado a usuarios(2)");
excel.CreateCell("Fecha de la factura(2)");
excel.CreateCell("Fecha de vencimiento de la factura");
excel.CreateCell("Factura PDF");
excel.CreateCell("Factura XML");
excel.CreateCell("Centro de costos");
excel.CreateCell("Todos los aprobadores");
excel.CreateCell("Proyecto");
excel.CreateCell("Periodo");
excel.CreateCell("Frecuencia");
excel.CreateCell("Documento 51 y 56");
excel.CreateCell("Fecha de la póliza");
excel.CreateCell("Puesto del Gerente asociado al último aprobador");
excel.CreateCell("Puesto del Jefe asociado al último aprobador");
excel.CreateCell("Aprobador Actual");
excel.CreateCell("Fecha de Última Atualización");


if(!ssRecordList.Empty) {
	try {
		ssRecordList.StartIteration();
		for (int i = 1; !ssRecordList.Eof; i++) {
            await excel.CreateRowAsync(i, cancellationToken);
            excel.CreateCell(ssRecordList.CurrentRec.ssSTReport60_FolioItems.ssFolioStatus);
excel.CreateCell(ssRecordList.CurrentRec.ssSTReport60_FolioItems.ssFolioNumber);
excel.CreateCell(ssRecordList.CurrentRec.ssSTReport60_FolioItems.ssCreatedOn);
excel.CreateCell(ssRecordList.CurrentRec.ssSTReport60_FolioItems.ssApprovalFlowType);
excel.CreateCell(ssRecordList.CurrentRec.ssSTReport60_FolioItems.ssApprovalFlowName);
excel.CreateCell(ssRecordList.CurrentRec.ssSTReport60_FolioItems.ssAssignedUsers);
excel.CreateCell(ssRecordList.CurrentRec.ssSTReport60_FolioItems.ssOrderNumber);
excel.CreateCell(ssRecordList.CurrentRec.ssSTReport60_FolioItems.ssOrderDate);
excel.CreateCell(ssRecordList.CurrentRec.ssSTReport60_FolioItems.ssSupplierNumber);
excel.CreateCell(ssRecordList.CurrentRec.ssSTReport60_FolioItems.ssSupplierName);
excel.CreateCell(ssRecordList.CurrentRec.ssSTReport60_FolioItems.ssApplicant);
excel.CreateCell(ssRecordList.CurrentRec.ssSTReport60_FolioItems.ssInputation);
excel.CreateCell(ssRecordList.CurrentRec.ssSTReport60_FolioItems.ssCompany);
excel.CreateCell(ssRecordList.CurrentRec.ssSTReport60_FolioItems.ssRegion);
excel.CreateCell(ssRecordList.CurrentRec.ssSTReport60_FolioItems.ssOrderPosition);
excel.CreateCell(ssRecordList.CurrentRec.ssSTReport60_FolioItems.ssSAPCode);
excel.CreateCell(ssRecordList.CurrentRec.ssSTReport60_FolioItems.ssDescription);
excel.CreateCell(ssRecordList.CurrentRec.ssSTReport60_FolioItems.ssQuantity);
excel.CreateCell(ssRecordList.CurrentRec.ssSTReport60_FolioItems.ssUMP);
excel.CreateCell(ssRecordList.CurrentRec.ssSTReport60_FolioItems.ssUnitPrice);
excel.CreateCell(ssRecordList.CurrentRec.ssSTReport60_FolioItems.ssAuthorizedAmount);
excel.CreateCell(ssRecordList.CurrentRec.ssSTReport60_FolioItems.ssImporteFolioSAEC);
excel.CreateCell(ssRecordList.CurrentRec.ssSTReport60_FolioItems.ssCurrencyCode);
excel.CreateCell(ssRecordList.CurrentRec.ssSTReport60_FolioItems.ssApproversPositionRolesList_AreaUsuaria);
excel.CreateCell(ssRecordList.CurrentRec.ssSTReport60_FolioItems.ssFirstApprover_AreaUsuaria);
excel.CreateCell(ssRecordList.CurrentRec.ssSTReport60_FolioItems.ssDaysInProcess);
excel.CreateCell(ssRecordList.CurrentRec.ssSTReport60_FolioItems.ssEntryNumber);
excel.CreateCell(ssRecordList.CurrentRec.ssSTReport60_FolioItems.ssEntryDate);
excel.CreateCell(ssRecordList.CurrentRec.ssSTReport60_FolioItems.ssInvoiceNumber);
excel.CreateCell(ssRecordList.CurrentRec.ssSTReport60_FolioItems.ssUUID);
excel.CreateCell(ssRecordList.CurrentRec.ssSTReport60_FolioItems.ssInvoiceDate);
excel.CreateCell(ssRecordList.CurrentRec.ssSTReport60_FolioItems.ssInvoiceCurrency);
excel.CreateCell(ssRecordList.CurrentRec.ssSTReport60_FolioItems.ssPEP);
excel.CreateCell(ssRecordList.CurrentRec.ssSTReport60_FolioItems.ssIddelsitio);
excel.CreateCell(ssRecordList.CurrentRec.ssSTReport60_FolioItems.ssEntryCancelation);
excel.CreateCell(ssRecordList.CurrentRec.ssSTReport60_FolioItems.ssEntryCancelationDate);
excel.CreateCell(ssRecordList.CurrentRec.ssSTReport60_FolioItems.ssClient);
excel.CreateCell(ssRecordList.CurrentRec.ssSTReport60_FolioItems.ssCXPLiberationDate);
excel.CreateCell(ssRecordList.CurrentRec.ssSTReport60_FolioItems.ssDaysToCXPLiberation);
excel.CreateCell(ssRecordList.CurrentRec.ssSTReport60_FolioItems.ssSISEAApprover);
excel.CreateCell(ssRecordList.CurrentRec.ssSTReport60_FolioItems.ssAttachedFiles_Extra);
excel.CreateCell(ssRecordList.CurrentRec.ssSTReport60_FolioItems.ssInvoiceXMLSerie);
excel.CreateCell(ssRecordList.CurrentRec.ssSTReport60_FolioItems.ssSubTotal);
excel.CreateCell(ssRecordList.CurrentRec.ssSTReport60_FolioItems.ssIVA);
excel.CreateCell(ssRecordList.CurrentRec.ssSTReport60_FolioItems.ssRetention);
excel.CreateCell(ssRecordList.CurrentRec.ssSTReport60_FolioItems.ssInvoiceStatus);
excel.CreateCell(ssRecordList.CurrentRec.ssSTReport60_FolioItems.ssFolioFirstApproverPositionRole);
excel.CreateCell(ssRecordList.CurrentRec.ssSTReport60_FolioItems.ssInvoiceDate2);
excel.CreateCell(ssRecordList.CurrentRec.ssSTReport60_FolioItems.ssInvoiceDueDate);
excel.CreateCell(ssRecordList.CurrentRec.ssSTReport60_FolioItems.ssInvoicePDFName);
excel.CreateCell(ssRecordList.CurrentRec.ssSTReport60_FolioItems.ssInvoiceXMLName);
excel.CreateCell(ssRecordList.CurrentRec.ssSTReport60_FolioItems.ssCostCenter);
excel.CreateCell(ssRecordList.CurrentRec.ssSTReport60_FolioItems.ssApproversDetailedList_CxP);
excel.CreateCell(ssRecordList.CurrentRec.ssSTReport60_FolioItems.ssProject);
excel.CreateCell(ssRecordList.CurrentRec.ssSTReport60_FolioItems.ssPeriod);
excel.CreateCell(ssRecordList.CurrentRec.ssSTReport60_FolioItems.ssFrequency);
excel.CreateCell(ssRecordList.CurrentRec.ssSTReport60_FolioItems.ssDocument51y56);
excel.CreateCell(ssRecordList.CurrentRec.ssSTReport60_FolioItems.ssPolizaDate);
excel.CreateCell(ssRecordList.CurrentRec.ssSTReport60_FolioItems.ssLastApproverPuestodelGerente_CxP);
excel.CreateCell(ssRecordList.CurrentRec.ssSTReport60_FolioItems.ssLastApproverPuestodelJefe_CxP);
excel.CreateCell(ssRecordList.CurrentRec.ssSTReport60_FolioItems.ssCurrentApprover);
excel.CreateCell(ssRecordList.CurrentRec.ssSTReport60_FolioItems.ssLastUpdateOrderSAP);

            ssRecordList.Advance(); 
		}
	} finally {
		ssRecordList.EndIteration();
	}
}

return await excel.SaveAsync(cancellationToken);
}


}


}
