using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementRequestedFiles_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementRequestedFiles_ScreenModel).Namespace);

    public long inParami_OrderId;
public long varLcl_RequestFileId;
public bool varLcShowPopup;
public ConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementRequestedFiles_DataActionGetOrderRequestFiles_Model varLcGetOrderRequestFiles;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementRequestedFiles_ScreenModel() {
}



    public ConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementRequestedFiles_ScreenModel(long inParami_OrderId, long varLcl_RequestFileId, bool varLcShowPopup, ConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementRequestedFiles_DataActionGetOrderRequestFiles_Model varLcGetOrderRequestFiles, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"i_OrderId", "l_RequestFileId", "ShowPopup", "GetOrderRequestFiles", "ClientVars"}, new string[] {"inParami_OrderId", "varLcl_RequestFileId", "varLcShowPopup", "varLcGetOrderRequestFiles", "clientVariables"});
this.inParami_OrderId = inParami_OrderId;
this.varLcl_RequestFileId = varLcl_RequestFileId;
this.varLcShowPopup = varLcShowPopup;
this.varLcGetOrderRequestFiles = varLcGetOrderRequestFiles;
this.clientVariables = clientVariables;
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
///  <code>GetOrderRequestFiles</code> <p> Description: </p>
/// </summary>
public async Task<RL_08794d38cc3e746db7e33443c648a0fa> DataActionGetOrderRequestFiles(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_08794d38cc3e746db7e33443c648a0fa outParamRequestFiles = default;
lcoGetOrderRequestFiles result = new lcoGetOrderRequestFiles();
lcvGetOrderRequestFiles localVars = new lcvGetOrderRequestFiles();
ConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementRequestedFiles_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetOrderRequestFiles", "ab6df4fa-cdcf-4df9-98b8-28f6620683ea"))
using (activitySource.CreateScreenDataActionActivity("Wb_UploadComplementRequestedFiles", "GetOrderRequestFiles")){
// Query datasetGetOrderRequestFilesByOrderId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderRequestFilesByOrderId_maxRecords = 999999999;
if (datasetGetOrderRequestFilesByOrderId_maxRecords < 1) datasetGetOrderRequestFilesByOrderId_maxRecords = 1;
int datasetGetOrderRequestFilesByOrderId_startIndex = 0;(localVars.queryResGetOrderRequestFilesByOrderId_outParamList,localVars.queryResGetOrderRequestFilesByOrderId_outParamCount) = await FuncDataActionGetOrderRequestFiles.datasetGetOrderRequestFilesByOrderId(requestContext,datasetGetOrderRequestFilesByOrderId_maxRecords,datasetGetOrderRequestFilesByOrderId_startIndex,IterationMultiplicity.Multiple,inParami_OrderId,cancellationToken);

// Output Variables
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

// Query Function "GetOrderRequestFilesByOrderId" 5StCiqeePUiLqy85B5CKrg of Action "GetOrderRequestFiles"
public static async Task<(RL_d258c3d50d870257794347fdeb7cc218,long)> datasetGetOrderRequestFilesByOrderId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("e_OrdersRequestFiles.Wb_UploadComplementRequestedFiles.GetOrderRequestFiles.GetOrderRequestFilesByOrderId", "8a422be5-9ea7-483d-8bab-2f3907908aae");
using var queryActivity = activitySource.CreateAggregateQueryActivity("e_OrdersRequestFiles.Wb_UploadComplementRequestedFiles.GetOrderRequestFiles.GetOrderRequestFilesByOrderId", "8a422be5-9ea7-483d-8bab-2f3907908aae", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.QVuy0_xq1k6uAfJb8WCO0A/NodesShownInESpaceTree.g2zCEFhWDEefq0gSS7K+KQ/DataActions.+vRtq8_N+U2YuCj2YgaD6g/NodesNotShownInESpaceTree.5StCiqeePUiLqy85B5CKrg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enorderrequestfile14\".\"id\" o0, NULL o1, \"enorderrequestfile14\".\"invoiceid\" o2, NULL o3, \"enorderrequestfile14\".\"storageid\" o4, \"enorderrequestfile14\".\"description\" o5, \"enorderrequestfile14\".\"needsapproval\" o6, \"enorderrequestfile14\".\"isapproved\" o7, \"enorderrequestfile14\".\"isrejected\" o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16");
fromBuilder.Append(" FROM {OrderRequestFile} \"enorderrequestfile14\"");
whereBuilder.Append(" WHERE ");
if (qporOrderId != 0) {
whereBuilder.Append("((\"enorderrequestfile14\".\"orderid\" = @qporOrderId) AND (\"enorderrequestfile14\".\"orderid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderId", DbType.Int64, qporOrderId);
} else {
whereBuilder.Append("(\"enorderrequestfile14\".\"orderid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enorderrequestfile14\".\"isfinancialfile\" = 0)");
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
opt[0] = new BitArray(new bool[] {false, true, false, true, false, false, false, false, false, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_OrdersRequestFiles.Wb_UploadComplementRequestedFiles.GetOrderRequestFiles.GetOrderRequestFilesByOrderId.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_OrdersRequestFiles.Wb_UploadComplementRequestedFiles.GetOrderRequestFiles.GetOrderRequestFilesByOrderId.List", cancellationToken: cancellationToken);
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
