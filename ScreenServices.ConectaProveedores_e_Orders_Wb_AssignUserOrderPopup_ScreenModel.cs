using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_e_Orders_Wb_AssignUserOrderPopup_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_e_Orders_Wb_AssignUserOrderPopup_ScreenModel).Namespace);

    public bool inParami_IsBulkAssign;
public RL_e86d03b22fb6d164e868d40e92a28f1a inParami_OrderList;
public bool varLcl_IsExecuting;
public string varLcl_AssignUserId;
public ConectaProveedores_e_Orders_Wb_AssignUserOrderPopup_DataActionGetUsersList_Model varLcGetUsersList;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_e_Orders_Wb_AssignUserOrderPopup_ScreenModel() {
}



    public ConectaProveedores_e_Orders_Wb_AssignUserOrderPopup_ScreenModel(bool inParami_IsBulkAssign, RL_e86d03b22fb6d164e868d40e92a28f1a inParami_OrderList, bool varLcl_IsExecuting, string varLcl_AssignUserId, ConectaProveedores_e_Orders_Wb_AssignUserOrderPopup_DataActionGetUsersList_Model varLcGetUsersList, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"i_IsBulkAssign", "i_OrderList", "l_IsExecuting", "l_AssignUserId", "GetUsersList", "ClientVars"}, new string[] {"inParami_IsBulkAssign", "inParami_OrderList", "varLcl_IsExecuting", "varLcl_AssignUserId", "varLcGetUsersList", "clientVariables"});
this.inParami_IsBulkAssign = inParami_IsBulkAssign;
this.inParami_OrderList = inParami_OrderList;
this.varLcl_IsExecuting = varLcl_IsExecuting;
this.varLcl_AssignUserId = varLcl_AssignUserId;
this.varLcGetUsersList = varLcGetUsersList;
this.clientVariables = clientVariables;
}



    

    public class lcvGetUsersList : VarsBag {
public RL_3c2483fef931c35c62e6128a52ac9903 queryResGetNextLevelByOrderId_outParamList = new RL_3c2483fef931c35c62e6128a52ac9903();
public long queryResGetNextLevelByOrderId_outParamCount = 0L;

public RL_c4047060b1b0f8ddbb57b083b33d7c64 queryResGetUsers_outParamList = new RL_c4047060b1b0f8ddbb57b083b33d7c64();
public long queryResGetUsers_outParamCount = 0L;

public RL_339e5fbd74448809f3620bf1c8c54b9a queryResGetOrderMain_outParamList = new RL_339e5fbd74448809f3620bf1c8c54b9a();
public long queryResGetOrderMain_outParamCount = 0L;

public lcvGetUsersList() {
}
}
public class lcoGetUsersList : VarsBag {
public RL_4c313dd08c2e051e0c0310a6d05109b0 outParamo_UsersList = new RL_4c313dd08c2e051e0c0310a6d05109b0();

public lcoGetUsersList() {
}
}
/// <summary>
/// Action <code>GetUsersList</code> that represents the Service Studio action
///  <code>GetUsersList</code> <p> Description: Query to fetch Users List.</p>
/// </summary>
public async Task<RL_4c313dd08c2e051e0c0310a6d05109b0> DataActionGetUsersList(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_4c313dd08c2e051e0c0310a6d05109b0 outParamo_UsersList = default;
lcoGetUsersList result = new lcoGetUsersList();
lcvGetUsersList localVars = new lcvGetUsersList();
ConectaProveedores_e_Orders_Wb_AssignUserOrderPopup_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetUsersList", "acc372c1-8a8c-44b7-90ed-711e4fbd5776"))
using (activitySource.CreateScreenDataActionActivity("Wb_AssignUserOrderPopup", "GetUsersList")){
// Query datasetGetNextLevelByOrderId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetNextLevelByOrderId_maxRecords = 1;
if (datasetGetNextLevelByOrderId_maxRecords < 1) datasetGetNextLevelByOrderId_maxRecords = 1;
int datasetGetNextLevelByOrderId_startIndex = 0;(localVars.queryResGetNextLevelByOrderId_outParamList,localVars.queryResGetNextLevelByOrderId_outParamCount) = await FuncDataActionGetUsersList.datasetGetNextLevelByOrderId(requestContext,datasetGetNextLevelByOrderId_maxRecords,datasetGetNextLevelByOrderId_startIndex,IterationMultiplicity.Never,inParami_OrderList.CurrentRec.ssENOrderMain.ssId,cancellationToken);

// Query datasetGetOrderMain
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderMain_maxRecords = 1;
if (datasetGetOrderMain_maxRecords < 1) datasetGetOrderMain_maxRecords = 1;
int datasetGetOrderMain_startIndex = 0;(localVars.queryResGetOrderMain_outParamList,localVars.queryResGetOrderMain_outParamCount) = await FuncDataActionGetUsersList.datasetGetOrderMain(requestContext,datasetGetOrderMain_maxRecords,datasetGetOrderMain_startIndex,IterationMultiplicity.Never,inParami_OrderList.CurrentRec.ssENOrderMain.ssId,cancellationToken);

// Query datasetGetUsers
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUsers_maxRecords = 999999999;
if (datasetGetUsers_maxRecords < 1) datasetGetUsers_maxRecords = 1;
int datasetGetUsers_startIndex = 0;(localVars.queryResGetUsers_outParamList,localVars.queryResGetUsers_outParamCount) = await FuncDataActionGetUsersList.datasetGetUsers(requestContext,datasetGetUsers_maxRecords,datasetGetUsers_startIndex,IterationMultiplicity.Single,localVars.queryResGetNextLevelByOrderId_outParamList.CurrentRec.ssENOrderApprovalLevel.ssEntraRoleId,localVars.queryResGetOrderMain_outParamList.CurrentRec.ssENOrderMain.ssDivisionId,((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsDevEnvironment]))),cancellationToken);

// Set List
// o_UsersList = GetUsers.List
result.outParamo_UsersList=(await RL_4c313dd08c2e051e0c0310a6d05109b0.ConvertAsync(localVars.queryResGetUsers_outParamList, new RL_4c313dd08c2e051e0c0310a6d05109b0(), async (RC_9cbf5b9e3053e98b4baee6de45b62a16 source, RC_a32d2d6effb998fa5a8e4b01f03a15ca target, CancellationToken cancellationToken) => {
target.ssENEntraRole = source.ssENEntraRole;
target.ssENRegion = source.ssENRegion;
target.ssENUser = source.ssENUser;
target.ssENUser_Extended_Internal = source.ssENUser_Extended_Internal;
return target;
}, cancellationToken));
} //close CreateActionActivity using block
} // try

finally {
outParamo_UsersList = result.outParamo_UsersList;
} // inner-finally
RETURN_STATEMENT:
return outParamo_UsersList;
}


    public static class FuncDataActionGetUsersList {

private static async Task<RC_2929b54077988f623db253f22a62f498> datasetGetNextLevelByOrderIdReadDbAsync(RC_2929b54077988f623db253f22a62f498 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENOrderApproval.Read( r, ref index);
rec.ssENOrderApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetNextLevelByOrderId" iuJcEisMWUqOVkmzbPGQ8A of Action "GetUsersList"
public static async Task<(RL_3c2483fef931c35c62e6128a52ac9903,long)> datasetGetNextLevelByOrderId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderApproval_OrderId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("e_Orders.Wb_AssignUserOrderPopup.GetUsersList.GetNextLevelByOrderId", "125ce28a-0c2b-4a59-8e56-49b36cf190f0");
using var queryActivity = activitySource.CreateAggregateQueryActivity("e_Orders.Wb_AssignUserOrderPopup.GetUsersList.GetNextLevelByOrderId", "125ce28a-0c2b-4a59-8e56-49b36cf190f0", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.cyUWEC6qAUuIALnt7g7PqA/DataActions.wXLDrIyKt0SQ7XEeT71Xdg/NodesNotShownInESpaceTree.iuJcEisMWUqOVkmzbPGQ8A, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, \"enorderapprovallevel22\".\"entraroleid\" o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24");
fromBuilder.Append(" FROM ({OrderApproval} \"enorderapproval22\" Left JOIN {OrderApprovalLevel} \"enorderapprovallevel22\" ON (\"enorderapproval22\".\"id\" = \"enorderapprovallevel22\".\"orderapprovalid\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderApproval_OrderId != 0) {
whereBuilder.Append("((\"enorderapproval22\".\"orderid\" = @qporOrderApproval_OrderId) AND (\"enorderapproval22\".\"orderid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderApproval_OrderId", DbType.Int64, qporOrderApproval_OrderId);
} else {
whereBuilder.Append("(\"enorderapproval22\".\"orderid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enorderapprovallevel22\".\"approvalstatusid\" = ");
whereBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("fEmjvBqEH0eHrf5_YVeo0g"))).ssId);
whereBuilder.Append(")");
orderByBuilder.Append(" ORDER BY \"enorderapprovallevel22\".\"levelnumber\" ASC ");
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
RL_3c2483fef931c35c62e6128a52ac9903 outParamList = new RL_3c2483fef931c35c62e6128a52ac9903();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetNextLevelByOrderIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_AssignUserOrderPopup.GetUsersList.GetNextLevelByOrderId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_3c2483fef931c35c62e6128a52ac9903 _tmp = new RL_3c2483fef931c35c62e6128a52ac9903();
_tmp.AlternateReadDbMethodAsync = datasetGetNextLevelByOrderIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_AssignUserOrderPopup.GetUsersList.GetNextLevelByOrderId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_3c2483fef931c35c62e6128a52ac9903)_tmp;
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

private static async Task<RC_9cbf5b9e3053e98b4baee6de45b62a16> datasetGetUsersReadDbAsync(RC_9cbf5b9e3053e98b4baee6de45b62a16 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENEntraRole.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
rec.ssENUserExtension.Read( r, ref index);
return rec;
}
// Query Function "GetUsers" m9kGHCqpEEWlbzMvNyGIKQ of Action "GetUsersList"
public static async Task<(RL_c4047060b1b0f8ddbb57b083b33d7c64,long)> datasetGetUsers(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpenUser_Extended_Internal_EntraRoleId,long qpreUser_Extended_Internal_RegionId,bool qpboIsDevEnvironment,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("e_Orders.Wb_AssignUserOrderPopup.GetUsersList.GetUsers", "1c06d99b-a92a-4510-a56f-332f37218829");
using var queryActivity = activitySource.CreateAggregateQueryActivity("e_Orders.Wb_AssignUserOrderPopup.GetUsersList.GetUsers", "1c06d99b-a92a-4510-a56f-332f37218829", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.cyUWEC6qAUuIALnt7g7PqA/DataActions.wXLDrIyKt0SQ7XEeT71Xdg/NodesNotShownInESpaceTree.m9kGHCqpEEWlbzMvNyGIKQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enentrarole53\".\"id\" o0, \"enentrarole53\".\"rolename\" o1, \"enentrarole53\".\"isareausuaria\" o2, \"enentrarole53\".\"isareacxp\" o3, \"enentrarole53\".\"issolicitante\" o4, \"enentrarole53\".\"isassistant\" o5, \"enregion116\".\"id\" o6, \"enregion116\".\"code\" o7, \"enregion116\".\"name\" o8, \"enregion116\".\"divisionfi\" o9, \"enregion116\".\"centrortp\" o10, \"enregion116\".\"commissionregion\" o11, \"enregion116\".\"isactive\" o12, \"enregion116\".\"createdon\" o13, \"enregion116\".\"createdby\" o14, \"enregion116\".\"updatedon\" o15, \"enregion116\".\"updatedby\" o16, \"enregion116\".\"isfsp\" o17, \"enregion116\".\"isfcp\" o18, \"enuser175\".\"id\" o19, \"enuser175\".\"name\" o20, \"enuser175\".\"email\" o21, \"enuser175\".\"photourl\" o22, \"enuser175\".\"username\" o23, \"enuser_extended_internal106\".\"id\" o24, \"enuser_extended_internal106\".\"employeenumber\" o25, \"enuser_extended_internal106\".\"managedby\" o26, \"enuser_extended_internal106\".\"regionid\" o27, \"enuser_extended_internal106\".\"departmentid\" o28, \"enuser_extended_internal106\".\"managementid\" o29, \"enuser_extended_internal106\".\"subdirectionid\" o30, \"enuser_extended_internal106\".\"telceldirectionid\" o31, \"enuser_extended_internal106\".\"city\" o32, \"enuser_extended_internal106\".\"jobtitle\" o33, \"enuser_extended_internal106\".\"entraroleid\" o34, \"enuser_extended_internal106\".\"onpremisesdistinguishedname\" o35, \"enuser_extended_internal106\".\"hasrolesassigned\" o36, \"enuser_extended_internal106\".\"lastsync\" o37, \"enuser_extended_internal106\".\"createdby\" o38, \"enuser_extended_internal106\".\"createdon\" o39, \"enuser_extended_internal106\".\"updatedby\" o40, \"enuser_extended_internal106\".\"updatedon\" o41, \"enuser_extended_internal106\".\"entraid\" o42, \"enuser_extended_internal106\".\"telceldireccion\" o43, NULL o44, NULL o45, NULL o46");
fromBuilder.Append(" FROM (((({User_Extended_Internal} \"enuser_extended_internal106\" Left JOIN {Region} \"enregion116\" ON (\"enuser_extended_internal106\".\"regionid\" = \"enregion116\".\"id\"))  Right JOIN {User} \"enuser175\" ON (\"enuser175\".\"id\" = \"enuser_extended_internal106\".\"id\"))  Left JOIN {EntraRole} \"enentrarole53\" ON (\"enuser_extended_internal106\".\"entraroleid\" = \"enentrarole53\".\"id\"))  Left JOIN {UserExtension} \"enuserextension72\" ON (\"enuser175\".\"id\" = \"enuserextension72\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpenUser_Extended_Internal_EntraRoleId != 0) {
whereBuilder.Append("((\"enuser_extended_internal106\".\"entraroleid\" = @qpenUser_Extended_Internal_EntraRoleId) AND (\"enuser_extended_internal106\".\"entraroleid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpenUser_Extended_Internal_EntraRoleId", DbType.Int64, qpenUser_Extended_Internal_EntraRoleId);
} else {
whereBuilder.Append("(\"enuser_extended_internal106\".\"entraroleid\" IS NULL)");
}
whereBuilder.Append(" AND ");
if (qpreUser_Extended_Internal_RegionId != 0) {
whereBuilder.Append("((\"enuser_extended_internal106\".\"regionid\" = @qpreUser_Extended_Internal_RegionId) AND (\"enuser_extended_internal106\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreUser_Extended_Internal_RegionId", DbType.Int64, qpreUser_Extended_Internal_RegionId);
} else {
whereBuilder.Append("(\"enuser_extended_internal106\".\"regionid\" IS NULL)");
}
whereBuilder.Append(" AND ((CASE WHEN (@qpboIsDevEnvironment = 1) THEN (CASE WHEN ((trim(\"enuserextension72\".\"correspondentexternalemail\")) <> '') THEN 1 ELSE 0 END) ELSE 1 END) = 1)");
sqlCmd.CreateParameterWithoutReplacements("@qpboIsDevEnvironment", DbType.Boolean, qpboIsDevEnvironment);
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
RL_c4047060b1b0f8ddbb57b083b33d7c64 outParamList = new RL_c4047060b1b0f8ddbb57b083b33d7c64();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetUsersReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[5];
opt[0] = new BitArray(new bool[] {false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false});
opt[2] = new BitArray(new bool[] {true, true, true});
opt[3] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[4] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_AssignUserOrderPopup.GetUsersList.GetUsers.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_c4047060b1b0f8ddbb57b083b33d7c64 _tmp = new RL_c4047060b1b0f8ddbb57b083b33d7c64();
_tmp.AlternateReadDbMethodAsync = datasetGetUsersReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_AssignUserOrderPopup.GetUsersList.GetUsers.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_c4047060b1b0f8ddbb57b083b33d7c64)_tmp;
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

// Query Function "GetOrderMain" Sb+lROVjl0yBijIT3dQ0LA of Action "GetUsersList"
public static async Task<(RL_339e5fbd74448809f3620bf1c8c54b9a,long)> datasetGetOrderMain(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("e_Orders.Wb_AssignUserOrderPopup.GetUsersList.GetOrderMain", "44a5bf49-63e5-4c97-818a-3213ddd4342c");
using var queryActivity = activitySource.CreateAggregateQueryActivity("e_Orders.Wb_AssignUserOrderPopup.GetUsersList.GetOrderMain", "44a5bf49-63e5-4c97-818a-3213ddd4342c", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.cyUWEC6qAUuIALnt7g7PqA/DataActions.wXLDrIyKt0SQ7XEeT71Xdg/NodesNotShownInESpaceTree.Sb+lROVjl0yBijIT3dQ0LA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, \"enordermain88\".\"divisionid\" o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28");
fromBuilder.Append(" FROM {OrderMain} \"enordermain88\"");
whereBuilder.Append(" WHERE ");
if (qporId != 0) {
whereBuilder.Append("((\"enordermain88\".\"id\" = @qporId) AND (\"enordermain88\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporId", DbType.Int64, qporId);
} else {
whereBuilder.Append("(\"enordermain88\".\"id\" IS NULL)");
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
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_AssignUserOrderPopup.GetUsersList.GetOrderMain.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_AssignUserOrderPopup.GetUsersList.GetOrderMain.List", cancellationToken: cancellationToken);
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
