using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_y_Utils_Wb_FolioEntra_Historic_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_y_Utils_Wb_FolioEntra_Historic_ScreenModel).Namespace);

    public long inParami_OrderMainId;
public DateTime inParami_RefreshWB;
public RL_4af3045b114dbc57d1481fed5aceb93a varLcList;
public AggregateRecord<RL_339e5fbd74448809f3620bf1c8c54b9a> ScreenDataSetGetOrderMainById;
public AggregateRecord<RL_e7b917e1824eb68e8cf92fc307d1415d> ScreenDataSetGetOrderMainApprovalLevels;
public ConectaProveedores_y_Utils_Wb_FolioEntra_Historic_DataActionGetEntraUserManagerList_Model varLcGetEntraUserManagerList;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_y_Utils_Wb_FolioEntra_Historic_ScreenModel() {
}



    public ConectaProveedores_y_Utils_Wb_FolioEntra_Historic_ScreenModel(long inParami_OrderMainId, DateTime inParami_RefreshWB, RL_4af3045b114dbc57d1481fed5aceb93a varLcList, AggregateRecord<RL_339e5fbd74448809f3620bf1c8c54b9a> ScreenDataSetGetOrderMainById, AggregateRecord<RL_e7b917e1824eb68e8cf92fc307d1415d> ScreenDataSetGetOrderMainApprovalLevels, ConectaProveedores_y_Utils_Wb_FolioEntra_Historic_DataActionGetEntraUserManagerList_Model varLcGetEntraUserManagerList, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"i_OrderMainId", "i_RefreshWB", "List", "GetOrderMainById", "GetOrderMainApprovalLevels", "GetEntraUserManagerList", "ClientVars"}, new string[] {"inParami_OrderMainId", "inParami_RefreshWB", "varLcList", "ScreenDataSetGetOrderMainById", "ScreenDataSetGetOrderMainApprovalLevels", "varLcGetEntraUserManagerList", "clientVariables"});
this.inParami_OrderMainId = inParami_OrderMainId;
this.inParami_RefreshWB = inParami_RefreshWB;
this.varLcList = varLcList;
this.ScreenDataSetGetOrderMainById = ScreenDataSetGetOrderMainById;
this.ScreenDataSetGetOrderMainApprovalLevels = ScreenDataSetGetOrderMainApprovalLevels;
this.varLcGetEntraUserManagerList = varLcGetEntraUserManagerList;
this.clientVariables = clientVariables;
}



    
// Query Function "GetOrderMainById" 2_lskdPVY0yP08y+TRCYnw of Action "Wb_FolioEntra_Historic"
public static async Task<(RL_339e5fbd74448809f3620bf1c8c54b9a,long)> datasetGetOrderMainById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("y_Utils.Wb_FolioEntra_Historic.GetOrderMainById", "916cf9db-d5d3-4c63-8fd3-ccbe4d10989f");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_FolioEntra_Historic","y_Utils.Wb_FolioEntra_Historic.GetOrderMainById");
// Query Iterations: Never
// Refresh Query 8IF4PbXwMEuNlII549+3+g Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.JAcgewyqEkOMCfBjsT2WtQ/NodesShownInESpaceTree.U4OTW52hE0uDgp_6gVtrqg/ScreenDataSets.2_lskdPVY0yP08y+TRCYnw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, \"enordermain112\".\"orderstatusid\" o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28");
fromBuilder.Append(" FROM {OrderMain} \"enordermain112\"");
whereBuilder.Append(" WHERE ");
if (qporId != 0) {
whereBuilder.Append("((\"enordermain112\".\"id\" = @qporId) AND (\"enordermain112\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporId", DbType.Int64, qporId);
} else {
whereBuilder.Append("(\"enordermain112\".\"id\" IS NULL)");
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
RL_339e5fbd74448809f3620bf1c8c54b9a outParamList = new RL_339e5fbd74448809f3620bf1c8c54b9a();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query y_Utils.Wb_FolioEntra_Historic.GetOrderMainById.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query y_Utils.Wb_FolioEntra_Historic.GetOrderMainById.List", cancellationToken: cancellationToken);
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

private static async Task<RC_12d88e24134057c9d8b3dfc84a66166f> datasetGetOrderMainApprovalLevelsReadDbAsync(RC_12d88e24134057c9d8b3dfc84a66166f rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENEntraRole.Read( r, ref index);
rec.ssENOrderApproval.Read( r, ref index);
rec.ssENOrderApprovalLevel.Read( r, ref index);
rec.ssENOrderComment_Cancel.Read( r, ref index);
rec.ssENOrderComment_Modify.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssENUser_Approved.Read( r, ref index);
rec.ssENUser_Assigned.Read( r, ref index);
return rec;
}
// Query Function "GetOrderMainApprovalLevels" WpSN9i8vHkuBEvZ179+uxw of Action "Wb_FolioEntra_Historic"
public static async Task<(RL_e7b917e1824eb68e8cf92fc307d1415d,long)> datasetGetOrderMainApprovalLevels(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,int qporOrderStatusId,long qporOrderApproval_OrderId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("y_Utils.Wb_FolioEntra_Historic.GetOrderMainApprovalLevels", "f68d945a-2f2f-4b1e-8112-f675efdfaec7");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_FolioEntra_Historic","y_Utils.Wb_FolioEntra_Historic.GetOrderMainApprovalLevels");
// Query Iterations: Never
// Refresh Query cRpJ2PNuzEyJSEVQzm2eQA Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.JAcgewyqEkOMCfBjsT2WtQ/NodesShownInESpaceTree.U4OTW52hE0uDgp_6gVtrqg/ScreenDataSets.WpSN9i8vHkuBEvZ179+uxw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83");
fromBuilder.Append(" FROM ((((((({OrderApproval} \"enorderapproval35\" Left JOIN {OrderApprovalLevel} \"enorderapprovallevel34\" ON (\"enorderapproval35\".\"id\" = \"enorderapprovallevel34\".\"orderapprovalid\"))  Left JOIN {EntraRole} \"enentrarole67\" ON (\"enorderapprovallevel34\".\"entraroleid\" = \"enentrarole67\".\"id\"))  Left JOIN {OrderComment} \"enordercomment_cancel\" ON ((\"enorderapprovallevel34\".\"id\" = \"enordercomment_cancel\".\"orderapprovallevelid\") AND ");
if (qporOrderStatusId != 0) {
fromBuilder.Append("((");
fromBuilder.Append((ENOrderStatusEntity.GetRecordByKey(ObjectKey.Parse("7Z08Vke3o0m5iptrgiGvaA"))).ssId);
fromBuilder.Append(" = @qporOrderStatusId) AND (");
fromBuilder.Append((ENOrderStatusEntity.GetRecordByKey(ObjectKey.Parse("7Z08Vke3o0m5iptrgiGvaA"))).ssId);
fromBuilder.Append(" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderStatusId", DbType.Int32, qporOrderStatusId);
} else {
fromBuilder.Append("(");
fromBuilder.Append((ENOrderStatusEntity.GetRecordByKey(ObjectKey.Parse("7Z08Vke3o0m5iptrgiGvaA"))).ssId);
fromBuilder.Append(" IS NULL)");
}
fromBuilder.Append("))  Left JOIN {OrderComment} \"enordercomment_modify\" ON ((\"enorderapprovallevel34\".\"id\" = \"enordercomment_modify\".\"orderapprovallevelid\") AND (\"enorderapprovallevel34\".\"approvalstatusid\" = ");
fromBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("A8ye9hhImUaVe0wa+Rtbjg"))).ssId);
fromBuilder.Append(")))  Left JOIN {User} \"enuser_assigned1\" ON ((\"enorderapprovallevel34\".\"assignedto\" IS NOT NULL) AND (\"enorderapprovallevel34\".\"assignedto\" = \"enuser_assigned1\".\"id\")))  Left JOIN {User} \"enuser_approved1\" ON (((CASE WHEN (\"enorderapprovallevel34\".\"approvedby\" IS NOT NULL) THEN (CASE WHEN (\"enorderapprovallevel34\".\"approvedby\" = \"enuser_approved1\".\"id\") THEN 1 ELSE 0 END) ELSE (CASE WHEN (\"enorderapprovallevel34\".\"wascanceledby\" IS NOT NULL) THEN (CASE WHEN (\"enorderapprovallevel34\".\"wascanceledby\" = \"enuser_approved1\".\"id\") THEN 1 ELSE 0 END) ELSE (CASE WHEN (\"enorderapprovallevel34\".\"tomodifyby\" IS NOT NULL) THEN (CASE WHEN (\"enorderapprovallevel34\".\"tomodifyby\" = \"enuser_approved1\".\"id\") THEN 1 ELSE 0 END) ELSE (CASE WHEN (\"enorderapprovallevel34\".\"assignedto\" = \"enuser_approved1\".\"id\") THEN 1 ELSE 0 END) END) END) END) = 1) AND (((\"enorderapprovallevel34\".\"approvalstatusid\" = ");
fromBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("rkrV30n0cEiW8dttOKG0gw"))).ssId);
fromBuilder.Append(") OR (\"enorderapprovallevel34\".\"approvalstatusid\" = ");
fromBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("YBJlnXS8SkKRSq9aruxhkg"))).ssId);
fromBuilder.Append(")) OR (\"enorderapprovallevel34\".\"approvalstatusid\" = ");
fromBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("A8ye9hhImUaVe0wa+Rtbjg"))).ssId);
fromBuilder.Append("))))  Left JOIN {OrderMain} \"enordermain113\" ON (\"enorderapproval35\".\"orderid\" = \"enordermain113\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderApproval_OrderId != 0) {
whereBuilder.Append("((\"enorderapproval35\".\"orderid\" = @qporOrderApproval_OrderId) AND (\"enorderapproval35\".\"orderid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderApproval_OrderId", DbType.Int64, qporOrderApproval_OrderId);
} else {
whereBuilder.Append("(\"enorderapproval35\".\"orderid\" IS NULL)");
}
whereBuilder.Append(" AND (@qpboCheckUserSession = 1)");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
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
RL_e7b917e1824eb68e8cf92fc307d1415d outParamList = new RL_e7b917e1824eb68e8cf92fc307d1415d();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderMainApprovalLevelsReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[8];
opt[0] = new BitArray(new bool[] {true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[6] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[7] = new BitArray(new bool[] {true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query y_Utils.Wb_FolioEntra_Historic.GetOrderMainApprovalLevels.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_e7b917e1824eb68e8cf92fc307d1415d _tmp = new RL_e7b917e1824eb68e8cf92fc307d1415d();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderMainApprovalLevelsReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query y_Utils.Wb_FolioEntra_Historic.GetOrderMainApprovalLevels.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_e7b917e1824eb68e8cf92fc307d1415d)_tmp;
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


    public class lcoGetEntraUserManagerList : VarsBag {
public RL_4af3045b114dbc57d1481fed5aceb93a outParamUserList = new RL_4af3045b114dbc57d1481fed5aceb93a();

public lcoGetEntraUserManagerList() {
}
}
/// <summary>
/// Action <code>GetEntraUserManagerList</code> that represents the Service Studio action
///  <code>GetEntraUserManagerList</code> <p> Description: </p>
/// </summary>
public async Task<RL_4af3045b114dbc57d1481fed5aceb93a> DataActionGetEntraUserManagerList(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_4af3045b114dbc57d1481fed5aceb93a outParamUserList = default;
lcoGetEntraUserManagerList result = new lcoGetEntraUserManagerList();
ConectaProveedores_y_Utils_Wb_FolioEntra_Historic_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetEntraUserManagerList", "df9b2f92-25ca-4d17-8066-f3c9a4db6e6b"))
using (activitySource.CreateScreenDataActionActivity("Wb_FolioEntra_Historic", "GetEntraUserManagerList")){
// UserList = List
result.outParamUserList=varLcList;
} //close CreateActionActivity using block
} // try

finally {
outParamUserList = result.outParamUserList;
} // inner-finally
RETURN_STATEMENT:
return outParamUserList;
}


    public static class FuncDataActionGetEntraUserManagerList {
}


}
