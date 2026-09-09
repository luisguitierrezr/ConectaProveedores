using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_e_Orders_Wb_DocumentsToRequest_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_e_Orders_Wb_DocumentsToRequest_ScreenModel).Namespace);

    public long inParami_SupplierId;
public long inParami_OrderId;
public bool inParami_CanEditUserArea;
public bool inParami_HasError;
public bool inParami_HasntRequestDocuments;
public bool varLcl_HasError;
public bool varLcl_IsValidList;
public bool varLcl_IsBusy;
public AggregateRecord<RL_84bdfe424d1eb0223fc2b8cfa9bb96be> ScreenDataSetGetSupplierUsersBySupplierId;
public ConectaProveedores_e_Orders_Wb_DocumentsToRequest_DataActionGetOrderRequestFiles_Model varLcGetOrderRequestFiles;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_e_Orders_Wb_DocumentsToRequest_ScreenModel() {
}



    public ConectaProveedores_e_Orders_Wb_DocumentsToRequest_ScreenModel(long inParami_SupplierId, long inParami_OrderId, bool inParami_CanEditUserArea, bool inParami_HasError, bool inParami_HasntRequestDocuments, bool varLcl_HasError, bool varLcl_IsValidList, bool varLcl_IsBusy, AggregateRecord<RL_84bdfe424d1eb0223fc2b8cfa9bb96be> ScreenDataSetGetSupplierUsersBySupplierId, ConectaProveedores_e_Orders_Wb_DocumentsToRequest_DataActionGetOrderRequestFiles_Model varLcGetOrderRequestFiles, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"i_SupplierId", "i_OrderId", "i_CanEditUserArea", "i_HasError", "i_HasntRequestDocuments", "l_HasError", "l_IsValidList", "l_IsBusy", "GetSupplierUsersBySupplierId", "GetOrderRequestFiles", "ClientVars"}, new string[] {"inParami_SupplierId", "inParami_OrderId", "inParami_CanEditUserArea", "inParami_HasError", "inParami_HasntRequestDocuments", "varLcl_HasError", "varLcl_IsValidList", "varLcl_IsBusy", "ScreenDataSetGetSupplierUsersBySupplierId", "varLcGetOrderRequestFiles", "clientVariables"});
this.inParami_SupplierId = inParami_SupplierId;
this.inParami_OrderId = inParami_OrderId;
this.inParami_CanEditUserArea = inParami_CanEditUserArea;
this.inParami_HasError = inParami_HasError;
this.inParami_HasntRequestDocuments = inParami_HasntRequestDocuments;
this.varLcl_HasError = varLcl_HasError;
this.varLcl_IsValidList = varLcl_IsValidList;
this.varLcl_IsBusy = varLcl_IsBusy;
this.ScreenDataSetGetSupplierUsersBySupplierId = ScreenDataSetGetSupplierUsersBySupplierId;
this.varLcGetOrderRequestFiles = varLcGetOrderRequestFiles;
this.clientVariables = clientVariables;
}



    
// Query Function "GetSupplierUsersBySupplierId" XrMgq8j_GkWXZpDS2EuN3A of Action "Wb_DocumentsToRequest"
public static async Task<(RL_84bdfe424d1eb0223fc2b8cfa9bb96be,long)> datasetGetSupplierUsersBySupplierId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpsuSupplierId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.Wb_DocumentsToRequest.GetSupplierUsersBySupplierId", "ab20b35e-ffc8-451a-9766-90d2d84b8ddc");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_DocumentsToRequest","e_Orders.Wb_DocumentsToRequest.GetSupplierUsersBySupplierId");
// Query Iterations: Multiple
// Refresh Query v1Rdpl_GoU+qN4s1SJuE+g Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.8rL1D0R8oU26V90izJvdjg/ScreenDataSets.XrMgq8j_GkWXZpDS2EuN3A, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"ensupplieruser20\".\"id\" o0, \"ensupplieruser20\".\"supplierid\" o1, \"ensupplieruser20\".\"userid\" o2, \"ensupplieruser20\".\"name\" o3, \"ensupplieruser20\".\"email\" o4, \"ensupplieruser20\".\"activationemailsentdate\" o5, \"ensupplieruser20\".\"isactive\" o6, \"ensupplieruser20\".\"isdeleted\" o7, \"ensupplieruser20\".\"isblocked\" o8, \"ensupplieruser20\".\"blockeduntil\" o9, \"ensupplieruser20\".\"lastlogindate\" o10, \"ensupplieruser20\".\"createdby\" o11, \"ensupplieruser20\".\"createdon\" o12, \"ensupplieruser20\".\"updatedby\" o13, \"ensupplieruser20\".\"updatedon\" o14");
fromBuilder.Append(" FROM {SupplierUser} \"ensupplieruser20\"");
whereBuilder.Append(" WHERE ");
if (qpsuSupplierId != 0) {
whereBuilder.Append("((\"ensupplieruser20\".\"supplierid\" = @qpsuSupplierId) AND (\"ensupplieruser20\".\"supplierid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuSupplierId", DbType.Int64, qpsuSupplierId);
} else {
whereBuilder.Append("(\"ensupplieruser20\".\"supplierid\" IS NULL)");
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
RL_84bdfe424d1eb0223fc2b8cfa9bb96be outParamList = new RL_84bdfe424d1eb0223fc2b8cfa9bb96be();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_DocumentsToRequest.GetSupplierUsersBySupplierId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_84bdfe424d1eb0223fc2b8cfa9bb96be _tmp = new RL_84bdfe424d1eb0223fc2b8cfa9bb96be();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_DocumentsToRequest.GetSupplierUsersBySupplierId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_84bdfe424d1eb0223fc2b8cfa9bb96be)_tmp;
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


    public class lcvGetOrderRequestFiles : VarsBag {
public RL_d258c3d50d870257794347fdeb7cc218 queryResGetOrderRequestFilesByOrderId_outParamList = new RL_d258c3d50d870257794347fdeb7cc218();
public long queryResGetOrderRequestFilesByOrderId_outParamCount = 0L;

public lcvGetOrderRequestFiles() {
}
}
public class lcoGetOrderRequestFiles : VarsBag {
public RL_08794d38cc3e746db7e33443c648a0fa outParamRequestFiles = new RL_08794d38cc3e746db7e33443c648a0fa();

public lcoGetOrderRequestFiles() {
}
}
/// <summary>
/// Action <code>GetOrderRequestFiles</code> that represents the Service Studio action
///  <code>GetOrderRequestFiles</code> <p> Description: Query to fetch Request Files.</p>
/// </summary>
public async Task<RL_08794d38cc3e746db7e33443c648a0fa> DataActionGetOrderRequestFiles(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_08794d38cc3e746db7e33443c648a0fa outParamRequestFiles = default;
lcoGetOrderRequestFiles result = new lcoGetOrderRequestFiles();
lcvGetOrderRequestFiles localVars = new lcvGetOrderRequestFiles();
ConectaProveedores_e_Orders_Wb_DocumentsToRequest_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetOrderRequestFiles", "7bf83dac-cd96-45e9-9e5e-4258e2c61c8a"))
using (activitySource.CreateScreenDataActionActivity("Wb_DocumentsToRequest", "GetOrderRequestFiles")){
// Query datasetGetOrderRequestFilesByOrderId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderRequestFilesByOrderId_maxRecords = 50;
if (datasetGetOrderRequestFilesByOrderId_maxRecords < 1) datasetGetOrderRequestFilesByOrderId_maxRecords = 1;
int datasetGetOrderRequestFilesByOrderId_startIndex = 0;(localVars.queryResGetOrderRequestFilesByOrderId_outParamList,localVars.queryResGetOrderRequestFilesByOrderId_outParamCount) = await FuncDataActionGetOrderRequestFiles.datasetGetOrderRequestFilesByOrderId(requestContext,datasetGetOrderRequestFilesByOrderId_maxRecords,datasetGetOrderRequestFilesByOrderId_startIndex,IterationMultiplicity.Multiple,inParami_OrderId,cancellationToken);

// RequestFiles = GetOrderRequestFilesByOrderId.List
result.outParamRequestFiles=(await RL_08794d38cc3e746db7e33443c648a0fa.ConvertAsync(localVars.queryResGetOrderRequestFilesByOrderId_outParamList, new RL_08794d38cc3e746db7e33443c648a0fa(), async (RC_73d8126c722e2b4dd662dab2bf1a72d1 source, EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord target, CancellationToken cancellationToken) => {
target = source;
return target;
}, cancellationToken));
} //close CreateActionActivity using block
} // try

finally {
outParamRequestFiles = result.outParamRequestFiles;
} // inner-finally
RETURN_STATEMENT:
return outParamRequestFiles;
}


    public static class FuncDataActionGetOrderRequestFiles {

// Query Function "GetOrderRequestFilesByOrderId" EqX4EBXjjE20Kebnff8Qpw of Action "GetOrderRequestFiles"
public static async Task<(RL_d258c3d50d870257794347fdeb7cc218,long)> datasetGetOrderRequestFilesByOrderId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("e_Orders.Wb_DocumentsToRequest.GetOrderRequestFiles.GetOrderRequestFilesByOrderId", "10f8a512-e315-4d8c-b429-e6e77dff10a7");
using var queryActivity = activitySource.CreateAggregateQueryActivity("e_Orders.Wb_DocumentsToRequest.GetOrderRequestFiles.GetOrderRequestFilesByOrderId", "10f8a512-e315-4d8c-b429-e6e77dff10a7", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.8rL1D0R8oU26V90izJvdjg/DataActions.rD34e5bN6UWeXkJY4sYcig/NodesNotShownInESpaceTree.EqX4EBXjjE20Kebnff8Qpw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enorderrequestfile10\".\"id\" o0, \"enorderrequestfile10\".\"orderid\" o1, \"enorderrequestfile10\".\"invoiceid\" o2, \"enorderrequestfile10\".\"filename\" o3, \"enorderrequestfile10\".\"storageid\" o4, \"enorderrequestfile10\".\"description\" o5, \"enorderrequestfile10\".\"needsapproval\" o6, \"enorderrequestfile10\".\"isapproved\" o7, \"enorderrequestfile10\".\"isrejected\" o8, \"enorderrequestfile10\".\"createdby\" o9, \"enorderrequestfile10\".\"createdon\" o10, \"enorderrequestfile10\".\"updatedby\" o11, \"enorderrequestfile10\".\"updatedon\" o12, \"enorderrequestfile10\".\"orderaccconceptid\" o13, \"enorderrequestfile10\".\"isfinancialfile\" o14, \"enorderrequestfile10\".\"ordercontractfile\" o15, \"enorderrequestfile10\".\"needaccounting\" o16");
fromBuilder.Append(" FROM {OrderRequestFile} \"enorderrequestfile10\"");
whereBuilder.Append(" WHERE ");
if (qporOrderId != 0) {
whereBuilder.Append("((\"enorderrequestfile10\".\"orderid\" = @qporOrderId) AND (\"enorderrequestfile10\".\"orderid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderId", DbType.Int64, qporOrderId);
} else {
whereBuilder.Append("(\"enorderrequestfile10\".\"orderid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enorderrequestfile10\".\"isfinancialfile\" = 0)");
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
RL_d258c3d50d870257794347fdeb7cc218 outParamList = new RL_d258c3d50d870257794347fdeb7cc218();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_DocumentsToRequest.GetOrderRequestFiles.GetOrderRequestFilesByOrderId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_d258c3d50d870257794347fdeb7cc218 _tmp = new RL_d258c3d50d870257794347fdeb7cc218();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_DocumentsToRequest.GetOrderRequestFiles.GetOrderRequestFilesByOrderId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_d258c3d50d870257794347fdeb7cc218)_tmp;
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
