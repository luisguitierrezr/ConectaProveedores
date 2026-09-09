namespace ssConectaProveedores;

public partial class Actions {
public class lcvGenerateReportOrders : VarsBag {
public string inParamOrders_Number;
public int inParamOrders_OrderStatusId;
public long inParamOrders_SupplierId;
public DateTime inParamOrders_DateFrom;
public DateTime inParamOrders_DateTo;
public long inParamOrders_RegionId;
public long inParamUserRegion;
public bool inParamIsAllRegions;
public string inParamSortClause;
public int inParamOffsetUtc;
/// <summary>
/// Variable <code>l_OrdersList</code> that represents the Service Studio OrdersToConsultReportList
///  <code>l_OrdersList</code> <p>Description: </p>
/// </summary>
public RL_56e4627e83bd01097b2e39e8d7867dce varLcl_OrdersList = new RL_56e4627e83bd01097b2e39e8d7867dce();

public RL_ba8a6fa9497761be975dfc71dab6b632 queryResGetOrders_outParamList = new RL_ba8a6fa9497761be975dfc71dab6b632();
public long queryResGetOrders_outParamCount = 0L;

public byte[] resRecordListToExcel1_outParamOut = new byte[] {};
public lcvGenerateReportOrders(string inParamOrders_Number, int inParamOrders_OrderStatusId, long inParamOrders_SupplierId, DateTime inParamOrders_DateFrom, DateTime inParamOrders_DateTo, long inParamOrders_RegionId, long inParamUserRegion, bool inParamIsAllRegions, string inParamSortClause, int inParamOffsetUtc) {
this.inParamOrders_Number = inParamOrders_Number;
this.inParamOrders_OrderStatusId = inParamOrders_OrderStatusId;
this.inParamOrders_SupplierId = inParamOrders_SupplierId;
this.inParamOrders_DateFrom = inParamOrders_DateFrom;
this.inParamOrders_DateTo = inParamOrders_DateTo;
this.inParamOrders_RegionId = inParamOrders_RegionId;
this.inParamUserRegion = inParamUserRegion;
this.inParamIsAllRegions = inParamIsAllRegions;
this.inParamSortClause = inParamSortClause;
this.inParamOffsetUtc = inParamOffsetUtc;
}
}
public class lcoGenerateReportOrders : VarsBag {
public byte[] outParamFile = new byte[] {};

public string outParamFilename = "";

public lcoGenerateReportOrders() {
}
}
/// <summary>
/// Action <code>GenerateReportOrders</code> that represents the Service Studio action
///  <code>GenerateReportOrders</code> <p> Description: Report Orders Screen.</p>
/// </summary>
public static async Task<(byte[],string)> ActionGenerateReportOrders(IRequestContext requestContext,string inParamOrders_Number,int inParamOrders_OrderStatusId,long inParamOrders_SupplierId,DateTime inParamOrders_DateFrom,DateTime inParamOrders_DateTo,long inParamOrders_RegionId,long inParamUserRegion,bool inParamIsAllRegions,string inParamSortClause,int inParamOffsetUtc,CancellationToken cancellationToken) {
byte[] outParamFile = default;
string outParamFilename = default;
lcoGenerateReportOrders result = new lcoGenerateReportOrders();
lcvGenerateReportOrders localVars = new lcvGenerateReportOrders(inParamOrders_Number, inParamOrders_OrderStatusId, inParamOrders_SupplierId, inParamOrders_DateFrom, inParamOrders_DateTo, inParamOrders_RegionId, inParamUserRegion, inParamIsAllRegions, inParamSortClause, inParamOffsetUtc);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GenerateReportOrders", "ed3ea331-d213-41d4-bf41-479837a33df5"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GenerateReportOrders", "ed3ea331-d213-41d4-bf41-479837a33df5", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query QueryGetOrders
cancellationToken.ThrowIfCancellationRequested();
int QueryGetOrders_maxRecords = 999999999;
if (QueryGetOrders_maxRecords < 1) QueryGetOrders_maxRecords = 1;
int QueryGetOrders_startIndex = 0;(localVars.queryResGetOrders_outParamList,localVars.queryResGetOrders_outParamCount) = await FuncActionGenerateReportOrders.QueryGetOrders(requestContext,QueryGetOrders_maxRecords,QueryGetOrders_startIndex,IterationMultiplicity.Multiple,localVars.inParamOrders_Number,localVars.inParamOrders_OrderStatusId,localVars.inParamOrders_SupplierId,localVars.inParamOrders_DateFrom,localVars.inParamOrders_DateTo,localVars.inParamOrders_RegionId,localVars.inParamUserRegion,localVars.inParamIsAllRegions,BuiltInFunction.NullDate (),BuiltInFunction.NullIdentifier (),localVars.inParamSortClause,0,999999999,(localVars.inParamOffsetUtc*(-1)),cancellationToken);

// ListAppendAll
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcl_OrdersList,(await RL_56e4627e83bd01097b2e39e8d7867dce.ConvertAsync(localVars.queryResGetOrders_outParamList, new RL_56e4627e83bd01097b2e39e8d7867dce(), async (RC_d0bb3f44a292c80efaf69b83c1f1cc02 source, ST_dd2f99ddb27fc3276d14217f47cde22fStructure target, CancellationToken cancellationToken) => {
target.ssOrderNumber = source.ssSTOrdersToConsult.ssOrderNumber;
target.ssOrderDate = source.ssSTOrdersToConsult.ssOrderDate;
target.ssOrderStatus = source.ssSTOrdersToConsult.ssOrderStatus;
target.ssOrderImportDate = BuiltInFunction.DateTimeToDate(source.ssSTOrdersToConsult.ssOrderImportDateTime);
target.ssRegion = source.ssSTOrdersToConsult.ssRegion;
target.ssTelcelDirection = source.ssSTOrdersToConsult.ssTelcelDirection;
target.ssSupplierName = source.ssSTOrdersToConsult.ssSupplierName;
target.ssSupplierNumber = source.ssSTOrdersToConsult.ssSupplierNumber;
target.ssFirstLevelUserName = source.ssSTOrdersToConsult.ssFirstLevelUserName;
target.ssFirstLevelJobTitle_EntraRoleName = (((localVars.queryResGetOrders_outParamList.CurrentRec.ssSTOrdersToConsult.ssFirstLevelJobTitle!="")) ? (localVars.queryResGetOrders_outParamList.CurrentRec.ssSTOrdersToConsult.ssFirstLevelJobTitle) : (localVars.queryResGetOrders_outParamList.CurrentRec.ssSTOrdersToConsult.ssFirstEntraRoleName));
target.ssCurrLevelUserName = source.ssSTOrdersToConsult.ssCurrLevelUserName;
target.ssCurrLevelJobTitle = (((source.ssSTOrdersToConsult.ssCurrLevelJobTitle=="")) ? (source.ssSTOrdersToConsult.ssCurrEntraRoleName) : (source.ssSTOrdersToConsult.ssCurrLevelJobTitle));
target.ssAssignedOn = BuiltInFunction.DateTimeToDate(source.ssSTOrdersToConsult.ssAssignedOn);
target.ssAssignedOnTime = BuiltInFunction.DateTimeToTime(source.ssSTOrdersToConsult.ssAssignedOn);
return target;
}, cancellationToken)),cancellationToken);

// RecordListToExcel RLToExcelGenerateReportOrdersRecordListToExcel1
localVars.resRecordListToExcel1_outParamOut = await FuncActionGenerateReportOrders.RLToExcelGenerateReportOrdersRecordListToExcel1(requestContext,localVars.varLcl_OrdersList,cancellationToken);

// File = RecordListToExcel1
result.outParamFile=localVars.resRecordListToExcel1_outParamOut;

// Filename = "Orders" + FormatDateTime + ".xlsx"
result.outParamFilename=((AppUtils.GetStringResource("ECMdp9ES6kySGWW_P1wUOQ#Value.-1924903163.1", "Orders")+BuiltInFunction.FormatDateTime (BuiltInFunction.CurrDate (), "ddMMyy"))+".xlsx");
} //close CreateActionActivity using block
} // try

finally {
outParamFile = result.outParamFile;
outParamFilename = result.outParamFilename;
} // inner-finally
RETURN_STATEMENT:
return (outParamFile,outParamFilename);
}

public static class FuncActionGenerateReportOrders {

// Query Function "GetOrders" 3NLCDIt2zU+vtt8akOqzow of Action "GenerateReportOrders"
public static async Task<(RL_ba8a6fa9497761be975dfc71dab6b632,long)> QueryGetOrders(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteOrders_Number,int qporOrders_OrderStatusId,long qpsuOrders_SupplierId,DateTime qpdaOrders_DateFrom,DateTime qpdaOrders_DateTo,long qpreOrders_RegionId,long qpreUserRegion,bool qpboIsAllRegions,DateTime qpdaNullDate,int qpinNullIdentifier,string qpteSortClause,int qpinStartIndex,int qpinMaxRecords,int qpinOffsetUtc,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("GenerateReportOrders.GetOrders", "0cc2d2dc-768b-4fcd-afb6-df1a90eab3a3");
using var queryActivity = activitySource.CreateSqlQueryActivity("GenerateReportOrders.GetOrders", "0cc2d2dc-768b-4fcd-afb6-df1a90eab3a3", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string entityOrderMain = AppUtils.Instance.RuntimeEntityReplace("OrderMain");
string entityOrderStatus = AppUtils.Instance.RuntimeEntityReplace("OrderStatus");
string entityOrdersImportRequest = AppUtils.Instance.RuntimeEntityReplace("OrdersImportRequest");
string entityRegion = AppUtils.Instance.RuntimeEntityReplace("Region");
string entitySupplier = AppUtils.Instance.RuntimeEntityReplace("Supplier");
string entityOrderApproval = AppUtils.Instance.RuntimeEntityReplace("OrderApproval");
string entityOrderApprovalLevel = AppUtils.Instance.RuntimeEntityReplace("OrderApprovalLevel");
string entityUser = AppUtils.Instance.RuntimeEntityReplace("User");
string entityUser_Extended_Internal = AppUtils.Instance.RuntimeEntityReplace("User_Extended_Internal");
string entityEntraRole = AppUtils.Instance.RuntimeEntityReplace("EntraRole");
string entityTelcelDirection = AppUtils.Instance.RuntimeEntityReplace("TelcelDirection");
sqlCmd.CreateParameter("@qpdaNullDate", DbType.DateTime, qpdaNullDate);
sqlCmd.CreateParameter("@qpteOrders_Number", DbType.String, qpteOrders_Number);
sqlCmd.CreateParameter("@qporOrders_OrderStatusId", DbType.Int32, qporOrders_OrderStatusId);
sqlCmd.CreateParameter("@qpinNullIdentifier", DbType.Int32, qpinNullIdentifier);
sqlCmd.CreateParameter("@qpsuOrders_SupplierId", DbType.Int64, qpsuOrders_SupplierId);
sqlCmd.CreateParameter("@qpdaOrders_DateFrom", DbType.DateTime, qpdaOrders_DateFrom);
sqlCmd.CreateParameter("@qpinOffsetUtc", DbType.Int32, qpinOffsetUtc);
sqlCmd.CreateParameter("@qpdaOrders_DateTo", DbType.DateTime, qpdaOrders_DateTo);
sqlCmd.CreateParameter("@qpreUserRegion", DbType.Int64, qpreUserRegion);
sqlCmd.CreateParameter("@qpboIsAllRegions", DbType.Boolean, qpboIsAllRegions);
sqlCmd.CreateParameter("@qpreOrders_RegionId", DbType.Int64, qpreOrders_RegionId);
sqlCmd.CreateParameter("@qpinMaxRecords", DbType.Int32, qpinMaxRecords);
sqlCmd.CreateParameter("@qpinStartIndex", DbType.Int32, qpinStartIndex);
string sql = "";
string advSql = "SELECT \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"id\"") + "                        AS OrderMainId, \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"ordernumber\"") + "               AS OrderNumber, \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"orderdate\"") + "                 AS OrderDate, \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderStatus,".\"label\"") + "                   AS OrderStatus, \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderStatus,".\"class\"") + "                   AS OrderStatusClass, \n     \n    ( \n        SELECT MAX(MaxReq.\"createdon\") \n        FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrdersImportRequest,"") + " MaxReq \n        WHERE MaxReq.\"ordermainid\" =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"id\"") + " \n    ) AS OrderImportDateTime, \n     \n     \n     \n     \n     \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"code\"") + "                         AS Region, \n    TelcelD.\"name\"                          AS TelcelDirection, \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"name\"") + "                       AS SupplierName, \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"number\"") + "                     AS SupplierNumber, \n    User_First.\"name\"                       AS FirstLevelUserName, \n    UserExt_First.\"jobtitle\"                AS FirstLevelJobTitle, \n    EntraRole_First.\"rolename\"              AS FirstEntraRoleName,  \n    User_Curr.\"name\"                        AS CurrLevelUserName, \n    UserExt_Curr.\"jobtitle\"                 AS CurrLevelJobTitle, \n    EntraRole_Curr.\"rolename\"               AS CurrEntraRoleName,  \n    CASE \n        WHEN OrderApprovalLevel_Curr.\"approvedon\" <> @qpdaNullDate \n        THEN OrderApprovalLevel_Curr.\"approvedon\" \n        WHEN OrderApprovalLevel_Curr.\"assignedon\" = @qpdaNullDate \n        THEN ( \n            SELECT MAX(MaxReq.\"createdon\") \n            FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrdersImportRequest,"") + " MaxReq \n            WHERE MaxReq.\"ordermainid\" =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"id\"") + " \n        ) \n        ELSE OrderApprovalLevel_Curr.\"assignedon\" \n    END AS AssignedOn \nFROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApproval,"") + " \nINNER JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApproval,".\"orderid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderStatus,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"orderstatusid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderStatus,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"supplierid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"divisionid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApprovalLevel,"") + " OrderApprovalLevel_Curr ON ( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApproval,".\"id\"") + " = OrderApprovalLevel_Curr.\"orderapprovalid\" AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApproval,".\"currentlevel\"") + " = OrderApprovalLevel_Curr.\"levelnumber\") \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,"") + " User_Curr ON OrderApprovalLevel_Curr.\"assignedto\" = User_Curr.\"id\" \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser_Extended_Internal,"") + " UserExt_Curr ON User_Curr.\"id\" = UserExt_Curr.\"id\" \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityEntraRole,"") + " EntraRole_Curr ON OrderApprovalLevel_Curr.\"entraroleid\" = EntraRole_Curr.\"id\" \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApprovalLevel,"") + " OrderApprovalLevel_First \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApproval,".\"id\"") + " = OrderApprovalLevel_First.\"orderapprovalid\" AND \n        OrderApprovalLevel_First.\"iscomplement\" = True \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,"") + " User_First ON OrderApprovalLevel_First.\"assignedto\" = User_First.\"id\" \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser_Extended_Internal,"") + " UserExt_First ON User_First.\"id\" = UserExt_First.\"id\" \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityEntraRole,"") + " EntraRole_First ON OrderApprovalLevel_First.\"entraroleid\" = EntraRole_First.\"id\" \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityTelcelDirection,"") + " TelcelD ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"telceldirectionid\"") + " = TelcelD.\"id\" \nWHERE \n( \n    COALESCE(CAST(@qpteOrders_Number AS text), '') = '' \n    OR caseaccent_normalize( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"ordernumber\"") + ") \n    LIKE caseaccent_normalize(CONCAT('%', CAST(@qpteOrders_Number AS text), '%')) COLLATE \"C\" \n) \nAND \n( \n    @qporOrders_OrderStatusId = @qpinNullIdentifier \n    OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"orderstatusid\"") + " = @qporOrders_OrderStatusId \n) \nAND \n( \n    @qpsuOrders_SupplierId = @qpinNullIdentifier \n    OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"supplierid\"") + " = @qpsuOrders_SupplierId \n) \nAND \n( \n    @qpdaOrders_DateFrom = @qpdaNullDate \n    OR \n    CAST( \n        CASE \n            WHEN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"orderdate\"") + " = @qpdaNullDate \n                THEN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"createdon\"") + " + (@qpinOffsetUtc * INTERVAL '1 hour') \n            ELSE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"orderdate\"") + " \n        END \n        AS DATE \n    ) >= CAST(@qpdaOrders_DateFrom AS DATE) \n) \nAND ( \n    @qpdaOrders_DateTo = @qpdaNullDate \n    OR \n    CAST( \n        CASE \n            WHEN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"orderdate\"") + " = @qpdaNullDate \n                THEN ( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"createdon\"") + " + (@qpinOffsetUtc * INTERVAL '1 hour')) \n            ELSE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"orderdate\"") + " \n        END \n        AS DATE \n    ) <= CAST(@qpdaOrders_DateTo AS DATE) \n) \nAND  \n( \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"divisionid\"") + " = @qpreUserRegion  \n    OR @qpboIsAllRegions = TRUE \n) \nAND  \n( \n    @qpreOrders_RegionId = @qpinNullIdentifier  \n    OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"divisionid\"") + " = @qpreOrders_RegionId \n) \n " + BaseAppUtils.ReplaceEntityReferencesInParameter(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, AppUtils.Instance.ReplaceAttributeReferences(requestContext,qpteSortClause)) + " \nLIMIT @qpinMaxRecords \nOFFSET @qpinStartIndex";
advSql = BaseAppUtils.ReplaceEntityIdentifiers(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers,advSql);
advSql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
AppUtils.Instance.CheckReadOnlyEntityReferences(advSql);
sql = advSql;
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_ba8a6fa9497761be975dfc71dab6b632 outParamList = new RL_ba8a6fa9497761be975dfc71dab6b632();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GenerateReportOrders.GetOrders.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_ba8a6fa9497761be975dfc71dab6b632 _tmp = new RL_ba8a6fa9497761be975dfc71dab6b632();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GenerateReportOrders.GetOrders.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_ba8a6fa9497761be975dfc71dab6b632)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetOrders in GenerateReportOrders in ConectaProveedores (SELECT      {OrderMain}.[Id]                        AS OrderMainId,      {OrderMain}.[OrderNumber]               AS OrderNumber,      {OrderMain}.[OrderDate]                 AS OrderDate,      {OrderStatus}.[Label]                   AS OrderStatus,      {OrderStatus}.[Class]                   AS OrderStatusClass,        /* Direct maximum CreatedOn lookup */      (          SELECT MAX(MaxReq.[CreatedOn])          FROM {OrdersImportRequest} MaxReq          WHERE MaxReq.[OrderMainId] = {OrderMain}.[Id]      ) AS OrderImportDateTime,        -- CASE          --     WHEN {OrdersImportRequest}.[UpdatedOn] = @NullDate      --     THEN {OrdersImportRequest}.[CreatedOn]      --     ELSE {OrdersImportRequest}.[UpdatedOn]      -- END AS OrderImportDate,      {Region}.[Code]                         AS Region,      TelcelD.[Name]                          AS TelcelDirection,      {Supplier}.[Name]                       AS SupplierName,      {Supplier}.[Number]                     AS SupplierNumber,   ...): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetOrders in GenerateReportOrders in ConectaProveedores (SELECT      {OrderMain}.[Id]                        AS OrderMainId,      {OrderMain}.[OrderNumber]               AS OrderNumber,      {OrderMain}.[OrderDate]                 AS OrderDate,      {OrderStatus}.[Label]                   AS OrderStatus,      {OrderStatus}.[Class]                   AS OrderStatusClass,        /* Direct maximum CreatedOn lookup */      (          SELECT MAX(MaxReq.[CreatedOn])          FROM {OrdersImportRequest} MaxReq          WHERE MaxReq.[OrderMainId] = {OrderMain}.[Id]      ) AS OrderImportDateTime,        -- CASE          --     WHEN {OrdersImportRequest}.[UpdatedOn] = @NullDate      --     THEN {OrdersImportRequest}.[CreatedOn]      --     ELSE {OrdersImportRequest}.[UpdatedOn]      -- END AS OrderImportDate,      {Region}.[Code]                         AS Region,      TelcelD.[Name]                          AS TelcelDirection,      {Supplier}.[Name]                       AS SupplierName,      {Supplier}.[Number]                     AS SupplierNumber,   ...): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetOrders in GenerateReportOrders in ConectaProveedores (SELECT      {OrderMain}.[Id]                        AS OrderMainId,      {OrderMain}.[OrderNumber]               AS OrderNumber,      {OrderMain}.[OrderDate]                 AS OrderDate,      {OrderStatus}.[Label]                   AS OrderStatus,      {OrderStatus}.[Class]                   AS OrderStatusClass,        /* Direct maximum CreatedOn lookup */      (          SELECT MAX(MaxReq.[CreatedOn])          FROM {OrdersImportRequest} MaxReq          WHERE MaxReq.[OrderMainId] = {OrderMain}.[Id]      ) AS OrderImportDateTime,        -- CASE          --     WHEN {OrdersImportRequest}.[UpdatedOn] = @NullDate      --     THEN {OrdersImportRequest}.[CreatedOn]      --     ELSE {OrdersImportRequest}.[UpdatedOn]      -- END AS OrderImportDate,      {Region}.[Code]                         AS Region,      TelcelD.[Name]                          AS TelcelDirection,      {Supplier}.[Name]                       AS SupplierName,      {Supplier}.[Number]                     AS SupplierNumber,   ...): " + aqExcep.Message));
}
}
}


/// <summary>
/// RecordList To Excel: RLToExcelGenerateReportOrdersRecordListToExcel1 (KGw_G6Hp0SE_cJjZrWtlSzQ) of
///  Action "GenerateReportOrders"
/// </summary>
public static async Task<byte[]> RLToExcelGenerateReportOrdersRecordListToExcel1(IRequestContext requestContext,RL_56e4627e83bd01097b2e39e8d7867dce ssRecordList,CancellationToken cancellationToken) {
var service = ServiceLocator.GetService<ISpreadsheetService>();
await using var excel = await service.GetWriterAsync(14, cancellationToken);

//Column headers
await excel.CreateRowAsync(0, cancellationToken);
excel.CreateCell("Número de Pedido");
excel.CreateCell("Fecha de Liberatión");
excel.CreateCell("Estado del Pedido");
excel.CreateCell("Fecha de Importación del Pedido");
excel.CreateCell("Región");
excel.CreateCell("Dirección");
excel.CreateCell("Proveedor");
excel.CreateCell("Número de Proveedor");
excel.CreateCell("Responsable del Complemento");
excel.CreateCell("Puesto del responsable del Complemento");
excel.CreateCell("Responsable actual");
excel.CreateCell("Puesto del responsable actual");
excel.CreateCell("Fecha de Asignación");
excel.CreateCell("Hora de Asignación");


if(!ssRecordList.Empty) {
	try {
		ssRecordList.StartIteration();
		for (int i = 1; !ssRecordList.Eof; i++) {
            await excel.CreateRowAsync(i, cancellationToken);
            excel.CreateCell(ssRecordList.CurrentRec.ssOrderNumber);
excel.CreateCellDate(ssRecordList.CurrentRec.ssOrderDate);
excel.CreateCell(ssRecordList.CurrentRec.ssOrderStatus);
excel.CreateCellDate(ssRecordList.CurrentRec.ssOrderImportDate);
excel.CreateCell(ssRecordList.CurrentRec.ssRegion);
excel.CreateCell(ssRecordList.CurrentRec.ssTelcelDirection);
excel.CreateCell(ssRecordList.CurrentRec.ssSupplierName);
excel.CreateCell(ssRecordList.CurrentRec.ssSupplierNumber);
excel.CreateCell(ssRecordList.CurrentRec.ssFirstLevelUserName);
excel.CreateCell(ssRecordList.CurrentRec.ssFirstLevelJobTitle_EntraRoleName);
excel.CreateCell(ssRecordList.CurrentRec.ssCurrLevelUserName);
excel.CreateCell(ssRecordList.CurrentRec.ssCurrLevelJobTitle);
excel.CreateCellDate(ssRecordList.CurrentRec.ssAssignedOn);
excel.CreateCellTime(ssRecordList.CurrentRec.ssAssignedOnTime);

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
