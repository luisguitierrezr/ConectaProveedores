namespace ssConectaProveedores;

public partial class Actions {
public class lcvOrdersImport_Order : VarsBag {
public long inParamRequestId;
public ST_9c87dd52bd762501ef8a064794927f08Structure inParamOrdersRequest;
public Actions.lcoOrdersImport_OrderCreate resOrdersImport_OrderCreate =  new Actions.lcoOrdersImport_OrderCreate();
public RL_a90e7a0b0a356de6b75df3eee56614eb queryResGetIdentifiers_outParamList = new RL_a90e7a0b0a356de6b75df3eee56614eb();
public long queryResGetIdentifiers_outParamCount = 0L;

public Actions.lcoOrdersImport_OrderUpdate resOrdersImport_OrderUpdate =  new Actions.lcoOrdersImport_OrderUpdate();
public Actions.lcoGetSupplier_CreateIfNotExist resGetSupplier_CreateIfNotExist =  new Actions.lcoGetSupplier_CreateIfNotExist();
public RL_339e5fbd74448809f3620bf1c8c54b9a queryResGetOrdersByOrderNumber_outParamList = new RL_339e5fbd74448809f3620bf1c8c54b9a();
public long queryResGetOrdersByOrderNumber_outParamCount = 0L;

public lcvOrdersImport_Order(long inParamRequestId, ST_9c87dd52bd762501ef8a064794927f08Structure inParamOrdersRequest) {
this.inParamRequestId = inParamRequestId;
this.inParamOrdersRequest = inParamOrdersRequest;
}
}
public class lcoOrdersImport_Order : VarsBag {
public ST_9f3831cec6ebd34416b59b8df7a27893Structure outParamResult = new ST_9f3831cec6ebd34416b59b8df7a27893Structure();

public bool outParamIsNewOrder = false;

public lcoOrdersImport_Order() {
}
}
/// <summary>
/// Action <code>OrdersImport_Order</code> that represents the Service Studio action
///  <code>OrdersImport_Order</code> <p> Description: </p>
/// </summary>
public static async Task<(ST_9f3831cec6ebd34416b59b8df7a27893Structure,bool)> ActionOrdersImport_Order(IRequestContext requestContext,long inParamRequestId,ST_9c87dd52bd762501ef8a064794927f08Structure inParamOrdersRequest,CancellationToken cancellationToken) {
ST_9f3831cec6ebd34416b59b8df7a27893Structure outParamResult = default;
bool outParamIsNewOrder = default;
lcoOrdersImport_Order result = new lcoOrdersImport_Order();
lcvOrdersImport_Order localVars = new lcvOrdersImport_Order(inParamRequestId, inParamOrdersRequest);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("OrdersImport_Order", "ea72b69c-6e4d-4305-abf2-2a8175acb823"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("OrdersImport_Order", "ea72b69c-6e4d-4305-abf2-2a8175acb823", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// ControledLogMessage
await Actions.ActionControledLogMessage(requestContext,((((bool)AppUtils.SiteProperties[SitePropertiesModel.spOrdersImportLog_IsActive]))),((((("Request "+BuiltInFunction.LongIntegerToText (localVars.inParamRequestId))+" OrderNumber: ")+localVars.inParamOrdersRequest.ssOrderNumber)+" OrderItems: ")+BuiltInFunction.IntegerToText (localVars.inParamOrdersRequest.ssOrderItems.Length)),"OrdersImport_Order",cancellationToken);

// Query datasetGetOrdersByOrderNumber
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrdersByOrderNumber_maxRecords = 1;
if (datasetGetOrdersByOrderNumber_maxRecords < 1) datasetGetOrdersByOrderNumber_maxRecords = 1;
int datasetGetOrdersByOrderNumber_startIndex = 0;(localVars.queryResGetOrdersByOrderNumber_outParamList,localVars.queryResGetOrdersByOrderNumber_outParamCount) = await FuncActionOrdersImport_Order.datasetGetOrdersByOrderNumber(requestContext,datasetGetOrdersByOrderNumber_maxRecords,datasetGetOrdersByOrderNumber_startIndex,IterationMultiplicity.Never,localVars.inParamOrdersRequest.ssOrderNumber,cancellationToken);

// IsNewOrder = GetOrdersByOrderNumber.List.Empty
result.outParamIsNewOrder=localVars.queryResGetOrdersByOrderNumber_outParamList.Empty;
// already exists?
if(((!result.outParamIsNewOrder))) {
// OrdersImport_OrderUpdate
localVars.resOrdersImport_OrderUpdate.outParamResult = await Actions.ActionOrdersImport_OrderUpdate(requestContext,localVars.inParamOrdersRequest,localVars.queryResGetOrdersByOrderNumber_outParamList.CurrentRec.ssENOrderMain,cancellationToken);

// Result = OrdersImport_OrderUpdate.Result
result.outParamResult=localVars.resOrdersImport_OrderUpdate.outParamResult;
} else {
// Query QueryGetIdentifiers
cancellationToken.ThrowIfCancellationRequested();
int QueryGetIdentifiers_maxRecords = 1;
if (QueryGetIdentifiers_maxRecords < 1) QueryGetIdentifiers_maxRecords = 1;
int QueryGetIdentifiers_startIndex = 0;(localVars.queryResGetIdentifiers_outParamList,localVars.queryResGetIdentifiers_outParamCount) = await FuncActionOrdersImport_Order.QueryGetIdentifiers(requestContext,QueryGetIdentifiers_maxRecords,QueryGetIdentifiers_startIndex,IterationMultiplicity.Never,localVars.inParamOrdersRequest.ssCompanyCode,localVars.inParamOrdersRequest.ssClassDocument,localVars.inParamOrdersRequest.ssProcurementGroup,cancellationToken);

// GetSupplier_CreateIfNotExist
localVars.resGetSupplier_CreateIfNotExist.outParamSupplierId = await Actions.ActionGetSupplier_CreateIfNotExist(requestContext,BuiltInFunction.TextToInteger (BuiltInFunction.ToUpper (BuiltInFunction.Trim (localVars.inParamOrdersRequest.ssSupplierNumber))),BuiltInFunction.ToUpper (BuiltInFunction.Trim (localVars.inParamOrdersRequest.ssSupplierName)),cancellationToken);

// OrdersImport_OrderCreate
localVars.resOrdersImport_OrderCreate.outParamResult = await Actions.ActionOrdersImport_OrderCreate(requestContext,localVars.inParamOrdersRequest,BuiltInFunction.LongIntegerToIdentifier (localVars.queryResGetIdentifiers_outParamList.CurrentRec.ssSTCompanyId.ssValue),BuiltInFunction.LongIntegerToIdentifier (localVars.queryResGetIdentifiers_outParamList.CurrentRec.ssSTDocumentTypeId.ssValue),localVars.resGetSupplier_CreateIfNotExist.outParamSupplierId,BuiltInFunction.LongIntegerToIdentifier (localVars.queryResGetIdentifiers_outParamList.CurrentRec.ssSTRegionId.ssValue),cancellationToken);

// Result = OrdersImport_OrderCreate.Result
result.outParamResult=localVars.resOrdersImport_OrderCreate.outParamResult;
}

} //close CreateActionActivity using block
} // try

finally {
outParamResult = result.outParamResult;
outParamIsNewOrder = result.outParamIsNewOrder;
} // inner-finally
RETURN_STATEMENT:
return (outParamResult,outParamIsNewOrder);
}

public static class FuncActionOrdersImport_Order {

private static async Task<RC_4d57f99d5ffffde65e439e566311a35e> QueryGetIdentifiersReadDbAsync(RC_4d57f99d5ffffde65e439e566311a35e rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssSTCompanyId.Read(r, ref index);
rec.ssSTDocumentTypeId.Read(r, ref index);
rec.ssSTRegionId.Read(r, ref index);
return rec;
}
// Query Function "GetIdentifiers" 6aHLJoGniEOSbnQ1f63D8g of Action "OrdersImport_Order"
public static async Task<(RL_a90e7a0b0a356de6b75df3eee56614eb,long)> QueryGetIdentifiers(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qptei_Company,string qptei_DocumentClass,string qptei_PurchasingGroupCode,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("OrdersImport_Order.GetIdentifiers", "26cba1e9-a781-4388-926e-74357fadc3f2");
using var queryActivity = activitySource.CreateSqlQueryActivity("OrdersImport_Order.GetIdentifiers", "26cba1e9-a781-4388-926e-74357fadc3f2", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string entityCompany = AppUtils.Instance.RuntimeEntityReplace("Company");
string entityDocumentType = AppUtils.Instance.RuntimeEntityReplace("DocumentType");
string entityPurchasingGroup = AppUtils.Instance.RuntimeEntityReplace("PurchasingGroup");
sqlCmd.CreateParameter("@qptei_Company", DbType.String, qptei_Company);
sqlCmd.CreateParameter("@qptei_DocumentClass", DbType.String, qptei_DocumentClass);
sqlCmd.CreateParameter("@qptei_PurchasingGroupCode", DbType.String, qptei_PurchasingGroupCode);
string sql = "";
string advSql = "SELECT  \n    ((SELECT  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"id\"") + " FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,"") + " WHERE UPPER(TRIM( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"externalid\"") + ")) = UPPER(TRIM(@qptei_Company))) LIMIT 1) \"companyid\", \n    ((SELECT  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityDocumentType,".\"id\"") + " FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityDocumentType,"") + " WHERE UPPER(TRIM( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityDocumentType,".\"classe\"") + ")) = UPPER(TRIM(@qptei_DocumentClass))) LIMIT 1) \"documenttypeid\", \n    ((SELECT  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityPurchasingGroup,".\"regionid\"") + " FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityPurchasingGroup,"") + " WHERE UPPER(TRIM( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityPurchasingGroup,".\"code\"") + ")) = UPPER(TRIM(@qptei_PurchasingGroupCode))) LIMIT 1) \"regionid\"";
sql = advSql;
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_a90e7a0b0a356de6b75df3eee56614eb outParamList = new RL_a90e7a0b0a356de6b75df3eee56614eb();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = QueryGetIdentifiersReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {false});
opt[1] = new BitArray(new bool[] {false});
opt[2] = new BitArray(new bool[] {false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query OrdersImport_Order.GetIdentifiers.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_a90e7a0b0a356de6b75df3eee56614eb _tmp = new RL_a90e7a0b0a356de6b75df3eee56614eb();
_tmp.AlternateReadDbMethodAsync = QueryGetIdentifiersReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query OrdersImport_Order.GetIdentifiers.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_a90e7a0b0a356de6b75df3eee56614eb)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetIdentifiers in OrdersImport_Order in ConectaProveedores (SELECT       ((SELECT {Company}.[Id] FROM {Company} WHERE UPPER(TRIM({Company}.[ExternalId])) = UPPER(TRIM(@i_Company))) LIMIT 1) [CompanyId],      ((SELECT {DocumentType}.[Id] FROM {DocumentType} WHERE UPPER(TRIM({DocumentType}.[Classe])) = UPPER(TRIM(@i_DocumentClass))) LIMIT 1) [DocumentTypeId],      ((SELECT {PurchasingGroup}.[RegionId] FROM {PurchasingGroup} WHERE UPPER(TRIM({PurchasingGroup}.[Code])) = UPPER(TRIM(@i_PurchasingGroupCode))) LIMIT 1) [RegionId]      ): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetIdentifiers in OrdersImport_Order in ConectaProveedores (SELECT       ((SELECT {Company}.[Id] FROM {Company} WHERE UPPER(TRIM({Company}.[ExternalId])) = UPPER(TRIM(@i_Company))) LIMIT 1) [CompanyId],      ((SELECT {DocumentType}.[Id] FROM {DocumentType} WHERE UPPER(TRIM({DocumentType}.[Classe])) = UPPER(TRIM(@i_DocumentClass))) LIMIT 1) [DocumentTypeId],      ((SELECT {PurchasingGroup}.[RegionId] FROM {PurchasingGroup} WHERE UPPER(TRIM({PurchasingGroup}.[Code])) = UPPER(TRIM(@i_PurchasingGroupCode))) LIMIT 1) [RegionId]      ): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetIdentifiers in OrdersImport_Order in ConectaProveedores (SELECT       ((SELECT {Company}.[Id] FROM {Company} WHERE UPPER(TRIM({Company}.[ExternalId])) = UPPER(TRIM(@i_Company))) LIMIT 1) [CompanyId],      ((SELECT {DocumentType}.[Id] FROM {DocumentType} WHERE UPPER(TRIM({DocumentType}.[Classe])) = UPPER(TRIM(@i_DocumentClass))) LIMIT 1) [DocumentTypeId],      ((SELECT {PurchasingGroup}.[RegionId] FROM {PurchasingGroup} WHERE UPPER(TRIM({PurchasingGroup}.[Code])) = UPPER(TRIM(@i_PurchasingGroupCode))) LIMIT 1) [RegionId]      ): " + aqExcep.Message));
}
}
}

// Query Function "GetOrdersByOrderNumber" 0ZE29ezNwUu3sqvesIXPdA of Action "OrdersImport_Order"
public static async Task<(RL_339e5fbd74448809f3620bf1c8c54b9a,long)> datasetGetOrdersByOrderNumber(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteOrderNumber,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("OrdersImport_Order.GetOrdersByOrderNumber", "f53691d1-cdec-4bc1-b7b2-abdeb085cf74");
using var queryActivity = activitySource.CreateAggregateQueryActivity("OrdersImport_Order.GetOrdersByOrderNumber", "f53691d1-cdec-4bc1-b7b2-abdeb085cf74", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.nLZy6k1uBUOr8iqBday4Iw/NodesNotShownInESpaceTree.0ZE29ezNwUu3sqvesIXPdA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enordermain60\".\"id\" o0, \"enordermain60\".\"ordernumber\" o1, \"enordermain60\".\"orderdate\" o2, \"enordermain60\".\"orderstatusid\" o3, \"enordermain60\".\"previousorderstatusid\" o4, \"enordermain60\".\"assignmentcode\" o5, \"enordermain60\".\"supplierid\" o6, \"enordermain60\".\"companyid\" o7, \"enordermain60\".\"documenttypeid\" o8, \"enordermain60\".\"currencyid\" o9, \"enordermain60\".\"telceldirectionid\" o10, \"enordermain60\".\"procurementgroup\" o11, \"enordermain60\".\"creatorsapnumber\" o12, \"enordermain60\".\"creatorsapname\" o13, \"enordermain60\".\"country\" o14, \"enordermain60\".\"isdeleted\" o15, \"enordermain60\".\"isreleased\" o16, trim_scale(\"enordermain60\".\"exchangerate\"::numeric) o17, \"enordermain60\".\"sustainabilitycategory\" o18, \"enordermain60\".\"sustainabilitysubcategory\" o19, trim_scale(\"enordermain60\".\"totalamount\"::numeric) o20, \"enordermain60\".\"fromcosmoz\" o21, \"enordermain60\".\"regionid\" o22, \"enordermain60\".\"divisionid\" o23, \"enordermain60\".\"applicant\" o24, \"enordermain60\".\"createdby\" o25, \"enordermain60\".\"createdon\" o26, \"enordermain60\".\"updatedby\" o27, \"enordermain60\".\"updatedon\" o28");
fromBuilder.Append(" FROM {OrderMain} \"enordermain60\"");
whereBuilder.Append(" WHERE ((Upper((trim(\"enordermain60\".\"ordernumber\")))) = (Upper((trim(@qpteOrderNumber)))))");
sqlCmd.CreateParameterWithoutReplacements("@qpteOrderNumber", DbType.String, qpteOrderNumber);
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
RL_339e5fbd74448809f3620bf1c8c54b9a outParamList = new RL_339e5fbd74448809f3620bf1c8c54b9a();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query OrdersImport_Order.GetOrdersByOrderNumber.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_339e5fbd74448809f3620bf1c8c54b9a _tmp = new RL_339e5fbd74448809f3620bf1c8c54b9a();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query OrdersImport_Order.GetOrdersByOrderNumber.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_339e5fbd74448809f3620bf1c8c54b9a)_tmp;
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
