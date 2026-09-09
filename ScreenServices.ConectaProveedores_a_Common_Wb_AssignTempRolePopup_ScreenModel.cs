using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_a_Common_Wb_AssignTempRolePopup_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_a_Common_Wb_AssignTempRolePopup_ScreenModel).Namespace);

    public EN_20bdea9cf8f17569719f414a83b584b6EntityRecord inParaml_UserApplicationRoleTemp;
public bool varLcl_UserDropdownValid;
public string varLcl_UserDropdownValidationMessage;
public AggregateRecord<RL_edcb7e1d218607fc80645a6019e669d1> ScreenDataSetGetLoggedUserInfo;
public AggregateRecord<RL_752c66ffcb633a1081093541635464e7> ScreenDataSetGetUsersFromSameRegion;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_a_Common_Wb_AssignTempRolePopup_ScreenModel() {
}



    public ConectaProveedores_a_Common_Wb_AssignTempRolePopup_ScreenModel(EN_20bdea9cf8f17569719f414a83b584b6EntityRecord inParaml_UserApplicationRoleTemp, bool varLcl_UserDropdownValid, string varLcl_UserDropdownValidationMessage, AggregateRecord<RL_edcb7e1d218607fc80645a6019e669d1> ScreenDataSetGetLoggedUserInfo, AggregateRecord<RL_752c66ffcb633a1081093541635464e7> ScreenDataSetGetUsersFromSameRegion, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"l_UserApplicationRoleTemp", "l_UserDropdownValid", "l_UserDropdownValidationMessage", "GetLoggedUserInfo", "GetUsersFromSameRegion", "ClientVars"}, new string[] {"inParaml_UserApplicationRoleTemp", "varLcl_UserDropdownValid", "varLcl_UserDropdownValidationMessage", "ScreenDataSetGetLoggedUserInfo", "ScreenDataSetGetUsersFromSameRegion", "clientVariables"});
this.inParaml_UserApplicationRoleTemp = inParaml_UserApplicationRoleTemp;
this.varLcl_UserDropdownValid = varLcl_UserDropdownValid;
this.varLcl_UserDropdownValidationMessage = varLcl_UserDropdownValidationMessage;
this.ScreenDataSetGetLoggedUserInfo = ScreenDataSetGetLoggedUserInfo;
this.ScreenDataSetGetUsersFromSameRegion = ScreenDataSetGetUsersFromSameRegion;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_d4fdf5fe986f15577c3a6610348f52f6> datasetGetLoggedUserInfoReadDbAsync(RC_d4fdf5fe986f15577c3a6610348f52f6 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
rec.ssENUserApplicationRole.Read( r, ref index);
return rec;
}
// Query Function "GetLoggedUserInfo" L3xQGcaVHEauU3UsmwZkkg of Action "Wb_AssignTempRolePopup"
public static async Task<(RL_edcb7e1d218607fc80645a6019e669d1,long)> datasetGetLoggedUserInfo(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("a_Common.Wb_AssignTempRolePopup.GetLoggedUserInfo", "19507c2f-95c6-461c-ae53-752c9b066492");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_AssignTempRolePopup","a_Common.Wb_AssignTempRolePopup.GetLoggedUserInfo");
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
selectBuilder.Append("/* /NRWebFlows.B4kRGvrnOEmQonA8ir4Pyg/NodesShownInESpaceTree.8dHKgkv6FEy0YudCF8wJow/ScreenDataSets.L3xQGcaVHEauU3UsmwZkkg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, \"enuser_extended_internal95\".\"regionid\" o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, \"enuserapplicationrole22\".\"applicationroleid\" o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34");
fromBuilder.Append(" FROM (({User} \"enuser159\" Left JOIN {UserApplicationRole} \"enuserapplicationrole22\" ON ((\"enuser159\".\"id\" = \"enuserapplicationrole22\".\"userid\") AND (\"enuserapplicationrole22\".\"rolestatusid\" = ");
fromBuilder.Append(2
);
fromBuilder.Append(")))  Left JOIN {User_Extended_Internal} \"enuser_extended_internal95\" ON (\"enuser159\".\"id\" = \"enuser_extended_internal95\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser159\".\"id\" = @qpusUser_Id) AND (\"enuser159\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser159\".\"id\" IS NULL)");
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
RL_edcb7e1d218607fc80645a6019e669d1 outParamList = new RL_edcb7e1d218607fc80645a6019e669d1();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetLoggedUserInfoReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, false, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query a_Common.Wb_AssignTempRolePopup.GetLoggedUserInfo.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_edcb7e1d218607fc80645a6019e669d1 _tmp = new RL_edcb7e1d218607fc80645a6019e669d1();
_tmp.AlternateReadDbMethodAsync = datasetGetLoggedUserInfoReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query a_Common.Wb_AssignTempRolePopup.GetLoggedUserInfo.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_edcb7e1d218607fc80645a6019e669d1)_tmp;
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

private static async Task<RC_34272dae45b4de5e1332f46c6e8700b9> datasetGetUsersFromSameRegionReadDbAsync(RC_34272dae45b4de5e1332f46c6e8700b9 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
return rec;
}
// Query Function "GetUsersFromSameRegion" noKHhSo5qkOeaWsLfKobXA of Action "Wb_AssignTempRolePopup"
public static async Task<(RL_752c66ffcb633a1081093541635464e7,long)> datasetGetUsersFromSameRegion(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreUser_Extended_Internal_RegionId,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("a_Common.Wb_AssignTempRolePopup.GetUsersFromSameRegion", "8587829e-392a-43aa-9e69-6b0b7caa1b5c");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_AssignTempRolePopup","a_Common.Wb_AssignTempRolePopup.GetUsersFromSameRegion");
// Query Iterations: Multiple
// Refresh Query 9DsE245vS0+Y29k88vHKBg Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.B4kRGvrnOEmQonA8ir4Pyg/NodesShownInESpaceTree.8dHKgkv6FEy0YudCF8wJow/ScreenDataSets.noKHhSo5qkOeaWsLfKobXA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enuser160\".\"id\" o0, \"enuser160\".\"name\" o1, \"enuser160\".\"email\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24");
fromBuilder.Append(" FROM ({User} \"enuser160\" Left JOIN {User_Extended_Internal} \"enuser_extended_internal96\" ON (\"enuser160\".\"id\" = \"enuser_extended_internal96\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpreUser_Extended_Internal_RegionId != 0) {
whereBuilder.Append("((\"enuser_extended_internal96\".\"regionid\" = @qpreUser_Extended_Internal_RegionId) AND (\"enuser_extended_internal96\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreUser_Extended_Internal_RegionId", DbType.Int64, qpreUser_Extended_Internal_RegionId);
} else {
whereBuilder.Append("(\"enuser_extended_internal96\".\"regionid\" IS NULL)");
}
whereBuilder.Append(" AND ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser160\".\"id\" <> @qpusUser_Id) OR (\"enuser160\".\"id\" IS NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser160\".\"id\" IS NOT NULL)");
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
RL_752c66ffcb633a1081093541635464e7 outParamList = new RL_752c66ffcb633a1081093541635464e7();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetUsersFromSameRegionReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, false, false, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query a_Common.Wb_AssignTempRolePopup.GetUsersFromSameRegion.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_752c66ffcb633a1081093541635464e7 _tmp = new RL_752c66ffcb633a1081093541635464e7();
_tmp.AlternateReadDbMethodAsync = datasetGetUsersFromSameRegionReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query a_Common.Wb_AssignTempRolePopup.GetUsersFromSameRegion.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_752c66ffcb633a1081093541635464e7)_tmp;
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
