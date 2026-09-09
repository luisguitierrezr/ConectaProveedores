using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_e_Orders_Wb_OrdersCreatedOrUpdatedBy_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_e_Orders_Wb_OrdersCreatedOrUpdatedBy_ScreenModel).Namespace);

    public long inParamOrderMainId;
public ConectaProveedores_e_Orders_Wb_OrdersCreatedOrUpdatedBy_DataActionGetsOrdersData_Model varLcGetsOrdersData;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_e_Orders_Wb_OrdersCreatedOrUpdatedBy_ScreenModel() {
}



    public ConectaProveedores_e_Orders_Wb_OrdersCreatedOrUpdatedBy_ScreenModel(long inParamOrderMainId, ConectaProveedores_e_Orders_Wb_OrdersCreatedOrUpdatedBy_DataActionGetsOrdersData_Model varLcGetsOrdersData, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"OrderMainId", "GetsOrdersData", "ClientVars"}, new string[] {"inParamOrderMainId", "varLcGetsOrdersData", "clientVariables"});
this.inParamOrderMainId = inParamOrderMainId;
this.varLcGetsOrdersData = varLcGetsOrdersData;
this.clientVariables = clientVariables;
}



    

    public class lcvGetsOrdersData : VarsBag {
public RL_b167cbaf897de91a9e04d193862b7c81 queryResGetOrderByIdCreatedBy_outParamList = new RL_b167cbaf897de91a9e04d193862b7c81();
public long queryResGetOrderByIdCreatedBy_outParamCount = 0L;

public lcvGetsOrdersData() {
}
}
public class lcoGetsOrdersData : VarsBag {
public ST_26711e61541f079fb4510d8f9bfa1e3dStructure outParamo_OrderCreatedLog = new ST_26711e61541f079fb4510d8f9bfa1e3dStructure();

public lcoGetsOrdersData() {
}
}
/// <summary>
/// Action <code>GetsOrdersData</code> that represents the Service Studio action
///  <code>GetsOrdersData</code> <p> Description: </p>
/// </summary>
public async Task<ST_26711e61541f079fb4510d8f9bfa1e3dStructure> DataActionGetsOrdersData(IRequestContext requestContext,CancellationToken cancellationToken) {
ST_26711e61541f079fb4510d8f9bfa1e3dStructure outParamo_OrderCreatedLog = default;
lcoGetsOrdersData result = new lcoGetsOrdersData();
lcvGetsOrdersData localVars = new lcvGetsOrdersData();
ConectaProveedores_e_Orders_Wb_OrdersCreatedOrUpdatedBy_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetsOrdersData", "79832e31-9408-41fd-ade5-0e4e6938b802"))
using (activitySource.CreateScreenDataActionActivity("Wb_OrdersCreatedOrUpdatedBy", "GetsOrdersData")){
// Query datasetGetOrderByIdCreatedBy
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderByIdCreatedBy_maxRecords = 50;
if (datasetGetOrderByIdCreatedBy_maxRecords < 1) datasetGetOrderByIdCreatedBy_maxRecords = 1;
int datasetGetOrderByIdCreatedBy_startIndex = 0;(localVars.queryResGetOrderByIdCreatedBy_outParamList,localVars.queryResGetOrderByIdCreatedBy_outParamCount) = await FuncDataActionGetsOrdersData.datasetGetOrderByIdCreatedBy(requestContext,datasetGetOrderByIdCreatedBy_maxRecords,datasetGetOrderByIdCreatedBy_startIndex,IterationMultiplicity.Never,inParamOrderMainId,cancellationToken);

// o_OrderCreatedLog.CreatedBy = GetOrderByIdCreatedBy.List.Current.User_Created.Name
result.outParamo_OrderCreatedLog.ssCreatedBy = localVars.queryResGetOrderByIdCreatedBy_outParamList.CurrentRec.ssENUser_Created.ssName;

// o_OrderCreatedLog.CreatedOn = GetOrderByIdCreatedBy.List.Current.OrderMain.CreatedOn
result.outParamo_OrderCreatedLog.ssCreatedOn = localVars.queryResGetOrderByIdCreatedBy_outParamList.CurrentRec.ssENOrderMain.ssCreatedOn;

// o_OrderCreatedLog.UpdatedBy = GetOrderByIdCreatedBy.List.Current.User_Updated.Name
result.outParamo_OrderCreatedLog.ssUpdatedBy = localVars.queryResGetOrderByIdCreatedBy_outParamList.CurrentRec.ssENUser_Updated.ssName;

// o_OrderCreatedLog.UpdatedOn = GetOrderByIdCreatedBy.List.Current.OrderMain.UpdatedOn
result.outParamo_OrderCreatedLog.ssUpdatedOn = localVars.queryResGetOrderByIdCreatedBy_outParamList.CurrentRec.ssENOrderMain.ssUpdatedOn;
} //close CreateActionActivity using block
} // try

finally {
outParamo_OrderCreatedLog = result.outParamo_OrderCreatedLog;
} // inner-finally
RETURN_STATEMENT:
return outParamo_OrderCreatedLog;
}


    public static class FuncDataActionGetsOrdersData {

private static async Task<RC_af9a716157092fb65ec15387ef146a90> datasetGetOrderByIdCreatedByReadDbAsync(RC_af9a716157092fb65ec15387ef146a90 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENOrderMain.Read( r, ref index);
rec.ssENUser_Created.Read( r, ref index);
rec.ssENUser_Updated.Read( r, ref index);
return rec;
}
// Query Function "GetOrderByIdCreatedBy" f_+9FVes0Ui2+cOuFx2fQQ of Action "GetsOrdersData"
public static async Task<(RL_b167cbaf897de91a9e04d193862b7c81,long)> datasetGetOrderByIdCreatedBy(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderMain_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("e_Orders.Wb_OrdersCreatedOrUpdatedBy.GetsOrdersData.GetOrderByIdCreatedBy", "15bdff7f-ac57-48d1-b6f9-c3ae171d9f41");
using var queryActivity = activitySource.CreateAggregateQueryActivity("e_Orders.Wb_OrdersCreatedOrUpdatedBy.GetsOrdersData.GetOrderByIdCreatedBy", "15bdff7f-ac57-48d1-b6f9-c3ae171d9f41", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.SnnJ_p2Wc0SbRK2lClpmow/DataActions.MS6DeQiU_UGt5Q5OaTi4Ag/NodesNotShownInESpaceTree.f_+9FVes0Ui2+cOuFx2fQQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, \"enordermain107\".\"createdon\" o26, NULL o27, \"enordermain107\".\"updatedon\" o28, NULL o29, \"enuser_created\".\"name\" o30, NULL o31, NULL o32, NULL o33, NULL o34, \"enuser_updated\".\"name\" o35, NULL o36, NULL o37, NULL o38");
fromBuilder.Append(" FROM (({OrderMain} \"enordermain107\" Left JOIN {User} \"enuser_created\" ON (\"enordermain107\".\"createdby\" = \"enuser_created\".\"id\"))  Left JOIN {User} \"enuser_updated\" ON (\"enordermain107\".\"updatedby\" = \"enuser_updated\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderMain_Id != 0) {
whereBuilder.Append("((\"enordermain107\".\"id\" = @qporOrderMain_Id) AND (\"enordermain107\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderMain_Id", DbType.Int64, qporOrderMain_Id);
} else {
whereBuilder.Append("(\"enordermain107\".\"id\" IS NULL)");
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
RL_b167cbaf897de91a9e04d193862b7c81 outParamList = new RL_b167cbaf897de91a9e04d193862b7c81();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderByIdCreatedByReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, false, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrdersCreatedOrUpdatedBy.GetsOrdersData.GetOrderByIdCreatedBy.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_b167cbaf897de91a9e04d193862b7c81 _tmp = new RL_b167cbaf897de91a9e04d193862b7c81();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderByIdCreatedByReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrdersCreatedOrUpdatedBy.GetsOrdersData.GetOrderByIdCreatedBy.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_b167cbaf897de91a9e04d193862b7c81)_tmp;
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
