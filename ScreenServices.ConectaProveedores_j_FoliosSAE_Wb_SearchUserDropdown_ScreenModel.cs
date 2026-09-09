using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_j_FoliosSAE_Wb_SearchUserDropdown_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_j_FoliosSAE_Wb_SearchUserDropdown_ScreenModel).Namespace);

    public bool inParami_IsDisable;
public string inParami_UserId;
public bool inParami_IsValid;
public bool inParami_IsMandatory;
public bool inParami_IsFilter;
public string inParami_LabelText;
public string varLcl_UserSearchText;
public int varLcl_UserMaxRecord;
public bool varLcl_IsValid;
public AggregateRecord<RL_8430333e95ceffc00def96d8abb01f75> ScreenDataSetGetUserById;
public AggregateRecord<RL_f518d708e7bb15a03a65b75b9f603096> ScreenDataSetGetUsers;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_j_FoliosSAE_Wb_SearchUserDropdown_ScreenModel() {
}



    public ConectaProveedores_j_FoliosSAE_Wb_SearchUserDropdown_ScreenModel(bool inParami_IsDisable, string inParami_UserId, bool inParami_IsValid, bool inParami_IsMandatory, bool inParami_IsFilter, string inParami_LabelText, string varLcl_UserSearchText, int varLcl_UserMaxRecord, bool varLcl_IsValid, AggregateRecord<RL_8430333e95ceffc00def96d8abb01f75> ScreenDataSetGetUserById, AggregateRecord<RL_f518d708e7bb15a03a65b75b9f603096> ScreenDataSetGetUsers, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"i_IsDisable", "i_UserId", "i_IsValid", "i_IsMandatory", "i_IsFilter", "i_LabelText", "l_UserSearchText", "l_UserMaxRecord", "l_IsValid", "GetUserById", "GetUsers", "ClientVars"}, new string[] {"inParami_IsDisable", "inParami_UserId", "inParami_IsValid", "inParami_IsMandatory", "inParami_IsFilter", "inParami_LabelText", "varLcl_UserSearchText", "varLcl_UserMaxRecord", "varLcl_IsValid", "ScreenDataSetGetUserById", "ScreenDataSetGetUsers", "clientVariables"});
this.inParami_IsDisable = inParami_IsDisable;
this.inParami_UserId = inParami_UserId;
this.inParami_IsValid = inParami_IsValid;
this.inParami_IsMandatory = inParami_IsMandatory;
this.inParami_IsFilter = inParami_IsFilter;
this.inParami_LabelText = inParami_LabelText;
this.varLcl_UserSearchText = varLcl_UserSearchText;
this.varLcl_UserMaxRecord = varLcl_UserMaxRecord;
this.varLcl_IsValid = varLcl_IsValid;
this.ScreenDataSetGetUserById = ScreenDataSetGetUserById;
this.ScreenDataSetGetUsers = ScreenDataSetGetUsers;
this.clientVariables = clientVariables;
}



    
// Query Function "GetUserById" tFr5PoF++Ey15J1LfzFthw of Action "Wb_SearchUserDropdown"
public static async Task<(RL_8430333e95ceffc00def96d8abb01f75,long)> datasetGetUserById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,string qpusId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.Wb_SearchUserDropdown.GetUserById", "3ef95ab4-7e81-4cf8-b5e4-9d4b7f316d87");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_SearchUserDropdown","j_FoliosSAE.Wb_SearchUserDropdown.GetUserById");
// Query Iterations: Never
// Refresh Query 9QxcT3pvqU6tDx_YxtVYZg Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.3FBr4KcX9k69rTc0E8e+Yg/ScreenDataSets.tFr5PoF++Ey15J1LfzFthw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enuser251\".\"id\" o0, \"enuser251\".\"name\" o1, NULL o2, NULL o3, NULL o4");
fromBuilder.Append(" FROM {User} \"enuser251\"");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if ((qpusId.Trim()!="")) {
whereBuilder.Append("((\"enuser251\".\"id\" = @qpusId) AND (\"enuser251\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusId", DbType.String, qpusId);
} else {
whereBuilder.Append("(\"enuser251\".\"id\" IS NULL)");
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
RL_8430333e95ceffc00def96d8abb01f75 outParamList = new RL_8430333e95ceffc00def96d8abb01f75();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_SearchUserDropdown.GetUserById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_8430333e95ceffc00def96d8abb01f75 _tmp = new RL_8430333e95ceffc00def96d8abb01f75();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_SearchUserDropdown.GetUserById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_8430333e95ceffc00def96d8abb01f75)_tmp;
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

private static async Task<RC_77956dae907db5f208e8a848dc366336> datasetGetUsersReadDbAsync(RC_77956dae907db5f208e8a848dc366336 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENEntraRole.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
rec.ssENUserExtension.Read( r, ref index);
return rec;
}
// Query Function "GetUsers" aKR_ZcpeKEGBqKzZ5Jkd7w of Action "Wb_SearchUserDropdown"
public static async Task<(RL_f518d708e7bb15a03a65b75b9f603096,long)> datasetGetUsers(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,string qptel_UserSearchText,bool qpboIsDevEnvironment,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.Wb_SearchUserDropdown.GetUsers", "657fa468-5eca-4128-81a8-acd9e4991def");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_SearchUserDropdown","j_FoliosSAE.Wb_SearchUserDropdown.GetUsers");
// Query Iterations: Multiple
// Refresh Query gfMau+4c3kejFaB9UR1M3Q Iterations: Multiple
// Refresh Query N774LC3o0kWRqhKtWLbLOg Iterations: Multiple
// Refresh Query olVXPIfGV02+9CX4b5BwvA Iterations: Multiple
// Refresh Query iw2VV1wi90idLpnhpPzUyw Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.3FBr4KcX9k69rTc0E8e+Yg/ScreenDataSets.aKR_ZcpeKEGBqKzZ5Jkd7w, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enentrarole92\".\"rolename\" o1, NULL o2, NULL o3, NULL o4, NULL o5, \"enuser252\".\"id\" o6, \"enuser252\".\"name\" o7, \"enuser252\".\"email\" o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33");
fromBuilder.Append(" FROM ((({User} \"enuser252\" Left JOIN {User_Extended_Internal} \"enuser_extended_internal147\" ON (\"enuser252\".\"id\" = \"enuser_extended_internal147\".\"id\"))  Left JOIN {UserExtension} \"enuserextension85\" ON (\"enuser252\".\"id\" = \"enuserextension85\".\"id\"))  Left JOIN {EntraRole} \"enentrarole92\" ON (\"enuser_extended_internal147\".\"entraroleid\" = \"enentrarole92\".\"id\")) ");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qptel_UserSearchText != "" && qptel_UserSearchText != "" && qptel_UserSearchText != "") {
whereBuilder.Append("((caseaccent_normalize(\"enuser252\".\"name\" collate \"default\") like caseaccent_normalize((('%' || @qptel_UserSearchText) || '%') collate \"default\")) OR (caseaccent_normalize(\"enuser252\".\"email\" collate \"default\") like caseaccent_normalize((('%' || @qptel_UserSearchText) || '%') collate \"default\"))) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qptel_UserSearchText", DbType.String, qptel_UserSearchText);
}
whereBuilder.Append("((CASE WHEN (@qpboIsDevEnvironment = 1) THEN (CASE WHEN (\"enuserextension85\".\"correspondentexternalemail\" <> '') THEN 1 ELSE 0 END) ELSE 1 END) = 1)");
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
RL_f518d708e7bb15a03a65b75b9f603096 outParamList = new RL_f518d708e7bb15a03a65b75b9f603096();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetUsersReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[4];
opt[0] = new BitArray(new bool[] {false, false, false, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_SearchUserDropdown.GetUsers.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_f518d708e7bb15a03a65b75b9f603096 _tmp = new RL_f518d708e7bb15a03a65b75b9f603096();
_tmp.AlternateReadDbMethodAsync = datasetGetUsersReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_SearchUserDropdown.GetUsers.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_f518d708e7bb15a03a65b75b9f603096)_tmp;
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
