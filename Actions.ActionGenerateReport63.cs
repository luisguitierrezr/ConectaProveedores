namespace ssConectaProveedores;

public partial class Actions {
public class lcvGenerateReport63 : VarsBag {
public DateTime inParamReport63_StartDate;
public DateTime inParamReport63_EndDate;
public string inParamReport63_OrderNumber;
public long inParamReport63_SociedadId;
public long inParamUserRegionId;
public bool inParamIsAllRegions;
public long inParamReport63_SupplierId;
public string inParamReport63_Applicant;
public bool inParamIsToEmpty;
public long inParamReport63_RegionId;
public long inParamSupplierId;
public bool inParamInExcel;
public RL_bb9bd65cc6ab3438e4038ecd50363e6c queryResGetOrderRequests2_outParamList = new RL_bb9bd65cc6ab3438e4038ecd50363e6c();
public long queryResGetOrderRequests2_outParamCount = 0L;

public Actions.lcoGenerateLinesReport63 resGenerateLinesReport63 =  new Actions.lcoGenerateLinesReport63();
public lcvGenerateReport63(DateTime inParamReport63_StartDate, DateTime inParamReport63_EndDate, string inParamReport63_OrderNumber, long inParamReport63_SociedadId, long inParamUserRegionId, bool inParamIsAllRegions, long inParamReport63_SupplierId, string inParamReport63_Applicant, bool inParamIsToEmpty, long inParamReport63_RegionId, long inParamSupplierId, bool inParamInExcel) {
this.inParamReport63_StartDate = inParamReport63_StartDate;
this.inParamReport63_EndDate = inParamReport63_EndDate;
this.inParamReport63_OrderNumber = inParamReport63_OrderNumber;
this.inParamReport63_SociedadId = inParamReport63_SociedadId;
this.inParamUserRegionId = inParamUserRegionId;
this.inParamIsAllRegions = inParamIsAllRegions;
this.inParamReport63_SupplierId = inParamReport63_SupplierId;
this.inParamReport63_Applicant = inParamReport63_Applicant;
this.inParamIsToEmpty = inParamIsToEmpty;
this.inParamReport63_RegionId = inParamReport63_RegionId;
this.inParamSupplierId = inParamSupplierId;
this.inParamInExcel = inParamInExcel;
}
}
public class lcoGenerateReport63 : VarsBag {
public byte[] outParamFile = new byte[] {};

public string outParamFilename = "";

public lcoGenerateReport63() {
}
}
/// <summary>
/// Action <code>GenerateReport63</code> that represents the Service Studio action
///  <code>GenerateReport63</code> <p> Description: </p>
/// </summary>
public static async Task<(byte[],string)> ActionGenerateReport63(IRequestContext requestContext,DateTime inParamReport63_StartDate,DateTime inParamReport63_EndDate,string inParamReport63_OrderNumber,long inParamReport63_SociedadId,long inParamUserRegionId,bool inParamIsAllRegions,long inParamReport63_SupplierId,string inParamReport63_Applicant,bool inParamIsToEmpty,long inParamReport63_RegionId,long inParamSupplierId,bool inParamInExcel,CancellationToken cancellationToken) {
byte[] outParamFile = default;
string outParamFilename = default;
lcoGenerateReport63 result = new lcoGenerateReport63();
lcvGenerateReport63 localVars = new lcvGenerateReport63(inParamReport63_StartDate, inParamReport63_EndDate, inParamReport63_OrderNumber, inParamReport63_SociedadId, inParamUserRegionId, inParamIsAllRegions, inParamReport63_SupplierId, inParamReport63_Applicant, inParamIsToEmpty, inParamReport63_RegionId, inParamSupplierId, inParamInExcel);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GenerateReport63", "4e4399d0-9793-4a07-bf19-81aee893f49a"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GenerateReport63", "4e4399d0-9793-4a07-bf19-81aee893f49a", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query QueryGetOrderRequests2
cancellationToken.ThrowIfCancellationRequested();
int QueryGetOrderRequests2_maxRecords = 999999999;
if (QueryGetOrderRequests2_maxRecords < 1) QueryGetOrderRequests2_maxRecords = 1;
int QueryGetOrderRequests2_startIndex = 0;(localVars.queryResGetOrderRequests2_outParamList,localVars.queryResGetOrderRequests2_outParamCount) = await FuncActionGenerateReport63.QueryGetOrderRequests2(requestContext,QueryGetOrderRequests2_maxRecords,QueryGetOrderRequests2_startIndex,IterationMultiplicity.Multiple,BuiltInFunction.NullDate (),Convert.ToInt64(BuiltInFunction.NullIdentifier ()),BuiltInFunction.NullTextIdentifier (),localVars.inParamReport63_StartDate,localVars.inParamReport63_EndDate,localVars.inParamReport63_OrderNumber,localVars.inParamUserRegionId,localVars.inParamIsAllRegions,localVars.inParamReport63_SociedadId,localVars.inParamReport63_SupplierId,localVars.inParamReport63_Applicant,localVars.inParamIsToEmpty,localVars.inParamReport63_RegionId,localVars.inParamSupplierId,(ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("cklscJNc0UyOgKXGwg51TQ"))).ssId,(ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("l5OG661dZEe+gAZwnNLhSA"))).ssId,cancellationToken);

// GenerateLinesReport63
localVars.resGenerateLinesReport63.outParamFile = await Actions.ActionGenerateLinesReport63(requestContext,(await RL_5c9c2f90b5c4a20f64fc5db975393a5e.ConvertAsync(localVars.queryResGetOrderRequests2_outParamList, new RL_5c9c2f90b5c4a20f64fc5db975393a5e(), async (RC_c39f3c10ad99d866d1fba066291cd7c9 source, ST_4d9dc458054302bbc44781a77ddc1e39Structure target, CancellationToken cancellationToken) => {
target = source;
return target;
}, cancellationToken)),localVars.inParamInExcel,cancellationToken);

// File = GenerateLinesReport63.File.BinaryData
result.outParamFile=localVars.resGenerateLinesReport63.outParamFile.ssBinaryData;

// Filename = GenerateLinesReport63.File.Name
result.outParamFilename=localVars.resGenerateLinesReport63.outParamFile.ssName;
} //close CreateActionActivity using block
} // try

finally {
outParamFile = result.outParamFile;
outParamFilename = result.outParamFilename;
} // inner-finally
RETURN_STATEMENT:
return (outParamFile,outParamFilename);
}

public static class FuncActionGenerateReport63 {

// Query Function "GetOrderRequests2" VnOobFSdckmB0DJ4Bvsr9A of Action "GenerateReport63"
public static async Task<(RL_bb9bd65cc6ab3438e4038ecd50363e6c,long)> QueryGetOrderRequests2(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,DateTime qpdaNulldate,long qploNullIdentifier,string qpteNullTextIdentifier,DateTime qpdaReport63_StartDate,DateTime qpdaReport63_EndDate,string qpteReport63_OrderNumber,long qpreUserRegion,bool qpboIsAllRegions,long qpcoReport63_SociedadId,long qpsuReport63_SupplierId,string qpteReport63_Applicant,bool qpboIsToEmpty,long qpreReport63_RegionId,long qpsuSupplierId,int qpfoFolioStatusIdCanceled,int qpfoFolioStatusIdCanceledByProvider,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("GenerateReport63.GetOrderRequests2", "6ca87356-9d54-4972-81d0-327806fb2bf4");
using var queryActivity = activitySource.CreateSqlQueryActivity("GenerateReport63.GetOrderRequests2", "6ca87356-9d54-4972-81d0-327806fb2bf4", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
sqlCmd.CommandTimeout = 1500;
string entityOrderMain = AppUtils.Instance.RuntimeEntityReplace("OrderMain");
string entitySupplier = AppUtils.Instance.RuntimeEntityReplace("Supplier");
string entityOrderMainItem = AppUtils.Instance.RuntimeEntityReplace("OrderMainItem");
string entityCompany = AppUtils.Instance.RuntimeEntityReplace("Company");
string entityFolioItems = AppUtils.Instance.RuntimeEntityReplace("FolioItems");
string entityFolio = AppUtils.Instance.RuntimeEntityReplace("Folio");
string entityOrderItemEntries = AppUtils.Instance.RuntimeEntityReplace("OrderItemEntries");
string entityCurrency = AppUtils.Instance.RuntimeEntityReplace("Currency");
string entityOrderMainItemStatus = AppUtils.Instance.RuntimeEntityReplace("OrderMainItemStatus");
string entityOrderStatus = AppUtils.Instance.RuntimeEntityReplace("OrderStatus");
string entityOrderDetail = AppUtils.Instance.RuntimeEntityReplace("OrderDetail");
string entityOrderApproval = AppUtils.Instance.RuntimeEntityReplace("OrderApproval");
string entityOrderApprovalLevel = AppUtils.Instance.RuntimeEntityReplace("OrderApprovalLevel");
string entityUser = AppUtils.Instance.RuntimeEntityReplace("User");
string entityUser_Extended_Internal = AppUtils.Instance.RuntimeEntityReplace("User_Extended_Internal");
string entityEntraRole = AppUtils.Instance.RuntimeEntityReplace("EntraRole");
sqlCmd.CreateParameter("@qpfoFolioStatusIdCanceled", DbType.Int32, qpfoFolioStatusIdCanceled);
sqlCmd.CreateParameter("@qpfoFolioStatusIdCanceledByProvider", DbType.Int32, qpfoFolioStatusIdCanceledByProvider);
sqlCmd.CreateParameter("@qpdaReport63_StartDate", DbType.DateTime, qpdaReport63_StartDate);
sqlCmd.CreateParameter("@qpdaNulldate", DbType.DateTime, qpdaNulldate);
sqlCmd.CreateParameter("@qpdaReport63_EndDate", DbType.DateTime, qpdaReport63_EndDate);
sqlCmd.CreateParameter("@qpteReport63_OrderNumber", DbType.String, qpteReport63_OrderNumber);
sqlCmd.CreateParameter("@qpreUserRegion", DbType.Int64, qpreUserRegion);
sqlCmd.CreateParameter("@qpboIsAllRegions", DbType.Boolean, qpboIsAllRegions);
sqlCmd.CreateParameter("@qpcoReport63_SociedadId", DbType.Int64, qpcoReport63_SociedadId);
sqlCmd.CreateParameter("@qploNullIdentifier", DbType.Int64, qploNullIdentifier);
sqlCmd.CreateParameter("@qpsuReport63_SupplierId", DbType.Int64, qpsuReport63_SupplierId);
sqlCmd.CreateParameter("@qpteReport63_Applicant", DbType.String, qpteReport63_Applicant);
sqlCmd.CreateParameter("@qpteNullTextIdentifier", DbType.String, qpteNullTextIdentifier);
sqlCmd.CreateParameter("@qpboIsToEmpty", DbType.Boolean, qpboIsToEmpty);
sqlCmd.CreateParameter("@qpreReport63_RegionId", DbType.Int64, qpreReport63_RegionId);
sqlCmd.CreateParameter("@qpsuSupplierId", DbType.Int64, qpsuSupplierId);
string sql = "";
string advSql = "SELECT  \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"ordernumber\"") + "                              AS OrderNumber, \n    TO_CHAR( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"orderdate\"") + ", 'DD/MM/YYYY')        AS CreatedOn, \n \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"number\"") + "                                   AS SupplierNumber, \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"name\"") + "                                     AS SupplierName, \n \n    CASE  \n        WHEN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"isdeleted\"") + " = TRUE THEN 'X' \n        ELSE '' \n    END                                                   AS IsDeleted, \n \n    CASE  \n        WHEN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"isblocked\"") + " = TRUE THEN 'X' \n        ELSE '' \n    END                                                   AS IsReleased, \n \n    CASE  \n        WHEN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"isfinaldelivery\"") + " = TRUE THEN 'X' \n        ELSE '' \n    END                                                   AS IsFinalDelivery, \n \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"applicant\"") + "                               AS Applicant, \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"assigmnentcode\"") + "                      AS AssignmentCode, \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"description\"") + "                               AS Sociedad, \n \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"position\"") + "                            AS Position, \n    CASE \n        WHEN TRIM( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"materialcode\"") + " COLLATE \"default\") ~ '^[0-9]+$' \n        THEN CAST(CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"materialcode\"") + " AS BIGINT) AS TEXT) \n        ELSE '' \n    END                                                   AS MaterialCode, \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"materialdescription\"") + "                 AS MaterialDescription, \n \n    TO_CHAR( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"quantity\"") + ",'FM999,999,999,999,990.000')  \n                                                          AS Quantity, \n \n    TO_CHAR( \n         " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"quantitydelivered\"") + " \n        + COALESCE(( \n            SELECT SUM(CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"invoiceqtt\"") + " AS DECIMAL(18,3))) \n            FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,"") + " \n            INNER JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,"") + " \n                ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"folioid\"") + " \n            WHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"ordermainitemid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"id\"") + " \n                AND ( \n                     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"foliostatusid\"") + " <> @qpfoFolioStatusIdCanceled \n                    AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"foliostatusid\"") + " <> @qpfoFolioStatusIdCanceledByProvider \n                ) \n        ), 0) \n        + COALESCE(( \n            SELECT SUM(CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"quantity_\"") + " AS DECIMAL(18,3))) \n            FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,"") + " \n            WHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"ordermainitemid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"id\"") + " \n            AND ( \n         " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"quantity_\"") + " > 0 \n        OR ( \n             " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"quantity_\"") + " < 0 \n            AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"rejectfolio\"") + " = 0 \n        )) \n        ), 0) \n    ,'FM999,999,999,999,990.000')                         AS QuantityDelivered, \n \n    TO_CHAR( \n         " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"quantity\"") + " \n        -  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"quantitydelivered\"") + " \n        - ( \n            COALESCE(( \n                SELECT SUM(CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"invoiceqtt\"") + " AS DECIMAL(18,3))) \n                FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,"") + " \n                INNER JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,"") + " \n                    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"folioid\"") + " \n                WHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"ordermainitemid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"id\"") + " \n                    AND ( \n                         " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"foliostatusid\"") + " <> @qpfoFolioStatusIdCanceled \n                        AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"foliostatusid\"") + " <> @qpfoFolioStatusIdCanceledByProvider \n                    ) \n            ), 0) \n            + COALESCE(( \n                SELECT SUM(CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"quantity_\"") + " AS DECIMAL(18,3))) \n                FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,"") + " \n                WHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"ordermainitemid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"id\"") + " \n                AND ( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"quantity_\"") + " > 0 \n                OR ( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"quantity_\"") + " < 0  AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"rejectfolio\"") + " = 0)) \n            ), 0) \n        ) \n    ,'FM999,999,999,999,990.000')                         AS QuantityAvailable, \n \n    TO_CHAR( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"unitprice\"") + ",'FM999,999,999,999,990.00')                            \n                                                          AS UnitPrice, \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"name\"") + "                                     AS Currency, \n \n    TO_CHAR( \n         " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"quantity\"") + " * ( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"unitprice\"") + " /  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"basequantity\"") + ") \n    ,'FM999,999,999,999,990.00')                          AS Total, \n \n    CASE \n        WHEN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"quantity\"") + " = ( \n             " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"quantitydelivered\"") + " + COALESCE(( \n                SELECT SUM(CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"invoiceqtt\"") + " AS DECIMAL(18,3))) \n                FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,"") + " \n                inner join  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,"") + " on  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"folioid\"") + " \n                WHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"ordermainitemid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"id\"") + " \n                and ( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"foliostatusid\"") + " <> @qpfoFolioStatusIdCanceled and  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"foliostatusid\"") + " <> @qpfoFolioStatusIdCanceledByProvider) \n            ), 0) + COALESCE(( \n                SELECT SUM(CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"quantity_\"") + " AS DECIMAL(18,2))) \n                FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,"") + " \n                WHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"ordermainitemid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"id\"") + " \n            ), 0) \n        ) \n            THEN 'Entregada' \n        WHEN ( \n             " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"quantitydelivered\"") + " + COALESCE(( \n                SELECT SUM(CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"invoiceqtt\"") + " AS DECIMAL(18,3))) \n                FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,"") + " \n                inner join  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,"") + " on  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"folioid\"") + " \n                WHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"ordermainitemid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"id\"") + " \n                and ( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"foliostatusid\"") + " <> @qpfoFolioStatusIdCanceled and  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"foliostatusid\"") + " <> @qpfoFolioStatusIdCanceledByProvider) \n            ), 0) + COALESCE(( \n                SELECT SUM(CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"quantity_\"") + " AS DECIMAL(18,3))) \n                FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,"") + " \n                WHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"ordermainitemid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"id\"") + " \n            ), 0) \n        ) > 0 \n            THEN 'Entrega parcial' \n        ELSE 'Disponible' \n    END                                                     AS DeliveryStatus, \n \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItemStatus,".\"label\"") + "                         AS OrderStatus, \n     \n     \n    User_Curr.\"name\"                                      AS CurrLevelUserName, \n    UserExt_Curr.\"jobtitle\"                               AS CurrLevelJobTitle \n \nFROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,"") + " \n \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderStatus,"") + " \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"orderstatusid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderStatus,".\"id\"") + " \n \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,"") + " \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"companyid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"id\"") + " \n \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,"") + " \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"supplierid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"id\"") + " \n \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderDetail,"") + " \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderDetail,".\"orderid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"id\"") + " \n \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,"") + " \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"ordermainid\"") + " \n \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,"") + " \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"currencyid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"code\"") + " \n \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItemStatus,"") + " \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItemStatus,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"ordermainitemstatusid\"") + " \n \n \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApproval,"") + " \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApproval,".\"orderid\"") + " \n \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApprovalLevel,"") + " OrderApprovalLevel_Curr  \n    ON ( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApproval,".\"id\"") + " = OrderApprovalLevel_Curr.\"orderapprovalid\"  \n    AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApproval,".\"currentlevel\"") + " = OrderApprovalLevel_Curr.\"levelnumber\") \n \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,"") + " User_Curr  \n    ON OrderApprovalLevel_Curr.\"assignedto\" = User_Curr.\"id\" \n \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser_Extended_Internal,"") + " UserExt_Curr  \n    ON User_Curr.\"id\" = UserExt_Curr.\"id\" \n \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityEntraRole,"") + " EntraRole_Curr  \n    ON OrderApprovalLevel_Curr.\"entraroleid\" = EntraRole_Curr.\"id\" \n \nWHERE \n    ( \n        @qpdaReport63_StartDate = @qpdaNulldate \n        OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"orderdate\"") + " >= @qpdaReport63_StartDate \n    ) \n \n    AND ( \n        @qpdaReport63_EndDate = @qpdaNulldate \n        OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"orderdate\"") + " <= @qpdaReport63_EndDate \n    ) \n \n    AND ( \n        TRIM(@qpteReport63_OrderNumber) = '' \n        OR caseaccent_normalize( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"ordernumber\"") + " collate \"default\") \n            ILIKE '%' || @qpteReport63_OrderNumber || '%' \n    ) \n \n    AND ( \n         " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"regionid\"") + " = @qpreUserRegion \n        OR @qpboIsAllRegions = 1 \n    ) \n \n    AND ( \n        @qpcoReport63_SociedadId = @qploNullIdentifier \n        OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"companyid\"") + " = @qpcoReport63_SociedadId \n    ) \n \n    AND ( \n        @qpsuReport63_SupplierId = @qploNullIdentifier \n        OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"supplierid\"") + " = @qpsuReport63_SupplierId \n    ) \n \n    AND ( \n        @qpteReport63_Applicant = @qpteNullTextIdentifier \n        OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"applicant\"") + " = @qpteReport63_Applicant \n    ) \n \n    AND ( \n        @qpboIsToEmpty = 0 \n    ) \n \n    AND ( \n        @qpreReport63_RegionId = @qploNullIdentifier \n        OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"regionid\"") + " = @qpreReport63_RegionId \n    ) \n \n    AND ( \n        @qpsuSupplierId = @qploNullIdentifier \n        OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"supplierid\"") + " = @qpsuSupplierId \n    ) \n \nORDER BY  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"orderdate\"") + " DESC";
sql = advSql;
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_bb9bd65cc6ab3438e4038ecd50363e6c outParamList = new RL_bb9bd65cc6ab3438e4038ecd50363e6c();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GenerateReport63.GetOrderRequests2.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_bb9bd65cc6ab3438e4038ecd50363e6c _tmp = new RL_bb9bd65cc6ab3438e4038ecd50363e6c();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GenerateReport63.GetOrderRequests2.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_bb9bd65cc6ab3438e4038ecd50363e6c)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetOrderRequests2 in GenerateReport63 in ConectaProveedores (SELECT       {OrderMain}.[OrderNumber]                              AS OrderNumber,      TO_CHAR({OrderMain}.[OrderDate], 'DD/MM/YYYY')        AS CreatedOn,        {Supplier}.[Number]                                   AS SupplierNumber,      {Supplier}.[Name]                                     AS SupplierName,        CASE           WHEN {OrderMainItem}.[IsDeleted] = TRUE THEN 'X'          ELSE ''      END                                                   AS IsDeleted,        CASE           WHEN {OrderMainItem}.[IsBlocked] = TRUE THEN 'X'          ELSE ''      END                                                   AS IsReleased,        CASE           WHEN {OrderMainItem}.[IsFinalDelivery] = TRUE THEN 'X'          ELSE ''      END                                                   AS IsFinalDelivery,        {OrderMain}.[Applicant]                               AS Applicant,      {OrderMainItem}.[AssigmnentCode]                      AS AssignmentCode,      {Company}.[Description]           ...): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetOrderRequests2 in GenerateReport63 in ConectaProveedores (SELECT       {OrderMain}.[OrderNumber]                              AS OrderNumber,      TO_CHAR({OrderMain}.[OrderDate], 'DD/MM/YYYY')        AS CreatedOn,        {Supplier}.[Number]                                   AS SupplierNumber,      {Supplier}.[Name]                                     AS SupplierName,        CASE           WHEN {OrderMainItem}.[IsDeleted] = TRUE THEN 'X'          ELSE ''      END                                                   AS IsDeleted,        CASE           WHEN {OrderMainItem}.[IsBlocked] = TRUE THEN 'X'          ELSE ''      END                                                   AS IsReleased,        CASE           WHEN {OrderMainItem}.[IsFinalDelivery] = TRUE THEN 'X'          ELSE ''      END                                                   AS IsFinalDelivery,        {OrderMain}.[Applicant]                               AS Applicant,      {OrderMainItem}.[AssigmnentCode]                      AS AssignmentCode,      {Company}.[Description]           ...): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetOrderRequests2 in GenerateReport63 in ConectaProveedores (SELECT       {OrderMain}.[OrderNumber]                              AS OrderNumber,      TO_CHAR({OrderMain}.[OrderDate], 'DD/MM/YYYY')        AS CreatedOn,        {Supplier}.[Number]                                   AS SupplierNumber,      {Supplier}.[Name]                                     AS SupplierName,        CASE           WHEN {OrderMainItem}.[IsDeleted] = TRUE THEN 'X'          ELSE ''      END                                                   AS IsDeleted,        CASE           WHEN {OrderMainItem}.[IsBlocked] = TRUE THEN 'X'          ELSE ''      END                                                   AS IsReleased,        CASE           WHEN {OrderMainItem}.[IsFinalDelivery] = TRUE THEN 'X'          ELSE ''      END                                                   AS IsFinalDelivery,        {OrderMain}.[Applicant]                               AS Applicant,      {OrderMainItem}.[AssigmnentCode]                      AS AssignmentCode,      {Company}.[Description]           ...): " + aqExcep.Message));
}
}
}



}


}
