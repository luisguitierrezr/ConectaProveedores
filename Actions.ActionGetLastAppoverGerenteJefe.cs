namespace ssConectaProveedores;

public partial class Actions {
public class lcvGetLastAppoverGerenteJefe : VarsBag {
public long inParami_OrderId;
public RL_83566cec88e769363a30dc5e5b6a86f1 queryResFindUserByEmail_outParamList = new RL_83566cec88e769363a30dc5e5b6a86f1();
public long queryResFindUserByEmail_outParamCount = 0L;

public ST_d32097d2629a99529d77b865dae9fb0cStructure resGetUserManagerGerente_outParamResponse = new ST_d32097d2629a99529d77b865dae9fb0cStructure();
public ST_38509e9fbd36a9b928c2f4e34a1342aeStructure resGetUserManagerGerente_outParamResult = new ST_38509e9fbd36a9b928c2f4e34a1342aeStructure();

public RL_a351086105893ea080eb7f2ace0f714d queryResGetLastApprover_outParamList = new RL_a351086105893ea080eb7f2ace0f714d();
public long queryResGetLastApprover_outParamCount = 0L;

public ST_d32097d2629a99529d77b865dae9fb0cStructure resGetUserManagerJefe_outParamResponse = new ST_d32097d2629a99529d77b865dae9fb0cStructure();
public ST_38509e9fbd36a9b928c2f4e34a1342aeStructure resGetUserManagerJefe_outParamResult = new ST_38509e9fbd36a9b928c2f4e34a1342aeStructure();

public lcvGetLastAppoverGerenteJefe(long inParami_OrderId) {
this.inParami_OrderId = inParami_OrderId;
}
}
public class lcoGetLastAppoverGerenteJefe : VarsBag {
public string outParamo_LastApproverPuestodelGerente_CxP = "";

public string outParamo_LastApproverPuestodelJefe_CxP = "";

public lcoGetLastAppoverGerenteJefe() {
}
}
/// <summary>
/// Action <code>GetLastAppoverGerenteJefe</code> that represents the Service Studio action
///  <code>GetLastAppoverGerenteJefe</code> <p> Description: Action to get last approver managers.</p>
/// </summary>
public static async Task<(string,string)> ActionGetLastAppoverGerenteJefe(IRequestContext requestContext,long inParami_OrderId,CancellationToken cancellationToken) {
string outParamo_LastApproverPuestodelGerente_CxP = default;
string outParamo_LastApproverPuestodelJefe_CxP = default;
lcoGetLastAppoverGerenteJefe result = new lcoGetLastAppoverGerenteJefe();
lcvGetLastAppoverGerenteJefe localVars = new lcvGetLastAppoverGerenteJefe(inParami_OrderId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GetLastAppoverGerenteJefe", "359dfe6e-66d9-48c2-8729-feb568741bcf"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetLastAppoverGerenteJefe", "359dfe6e-66d9-48c2-8729-feb568741bcf", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetLastApprover
cancellationToken.ThrowIfCancellationRequested();
int datasetGetLastApprover_maxRecords = 1;
if (datasetGetLastApprover_maxRecords < 1) datasetGetLastApprover_maxRecords = 1;
int datasetGetLastApprover_startIndex = 0;(localVars.queryResGetLastApprover_outParamList,localVars.queryResGetLastApprover_outParamCount) = await FuncActionGetLastAppoverGerenteJefe.datasetGetLastApprover(requestContext,datasetGetLastApprover_maxRecords,datasetGetLastApprover_startIndex,IterationMultiplicity.Never,localVars.inParami_OrderId,cancellationToken);

// GetUserManagerGerente
(localVars.resGetUserManagerGerente_outParamResponse,localVars.resGetUserManagerGerente_outParamResult) = await Actions.ActionGetUserManager(requestContext,(((localVars.queryResGetLastApprover_outParamList.CurrentRec.ssENUserExtension.ssCorrespondentExternalEmail!="")) ? (localVars.queryResGetLastApprover_outParamList.CurrentRec.ssENUserExtension.ssCorrespondentExternalEmail) : (localVars.queryResGetLastApprover_outParamList.CurrentRec.ssENApprover.ssEmail)),cancellationToken);

// Query QueryFindUserByEmail
cancellationToken.ThrowIfCancellationRequested();
int QueryFindUserByEmail_maxRecords = 0;
int QueryFindUserByEmail_startIndex = 0;(localVars.queryResFindUserByEmail_outParamList,localVars.queryResFindUserByEmail_outParamCount) = await FuncActionGetLastAppoverGerenteJefe.QueryFindUserByEmail(requestContext,QueryFindUserByEmail_maxRecords,QueryFindUserByEmail_startIndex,IterationMultiplicity.Never,localVars.resGetUserManagerGerente_outParamResponse.ssMail,cancellationToken);

if(((localVars.resGetUserManagerGerente_outParamResponse.ssMail!=""))) {
// GetUserManagerJefe
(localVars.resGetUserManagerJefe_outParamResponse,localVars.resGetUserManagerJefe_outParamResult) = await Actions.ActionGetUserManager(requestContext,(((localVars.queryResFindUserByEmail_outParamList.CurrentRec.ssSTFindUserByEmail.ssExtensionEmail!="")) ? (localVars.queryResFindUserByEmail_outParamList.CurrentRec.ssSTFindUserByEmail.ssExtensionEmail) : (localVars.queryResFindUserByEmail_outParamList.CurrentRec.ssSTFindUserByEmail.ssUserEmail)),cancellationToken);

// o_LastApproverPuestodelJefe_CxP = GetUserManagerJefe.Response.JobTitle
result.outParamo_LastApproverPuestodelJefe_CxP=localVars.resGetUserManagerJefe_outParamResponse.ssJobTitle;
}

// LastApproverGerenteJefe
// o_LastApproverPuestodelGerente_CxP = GetUserManagerGerente.Response.JobTitle
result.outParamo_LastApproverPuestodelGerente_CxP=localVars.resGetUserManagerGerente_outParamResponse.ssJobTitle;
} //close CreateActionActivity using block
} // try

finally {
outParamo_LastApproverPuestodelGerente_CxP = result.outParamo_LastApproverPuestodelGerente_CxP;
outParamo_LastApproverPuestodelJefe_CxP = result.outParamo_LastApproverPuestodelJefe_CxP;
} // inner-finally
RETURN_STATEMENT:
return (outParamo_LastApproverPuestodelGerente_CxP,outParamo_LastApproverPuestodelJefe_CxP);
}

public static class FuncActionGetLastAppoverGerenteJefe {

// Query Function "FindUserByEmail" kB8ogp21x06BWd8ssy_+8g of Action "GetLastAppoverGerenteJefe"
public static async Task<(RL_83566cec88e769363a30dc5e5b6a86f1,long)> QueryFindUserByEmail(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qptei_Email,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("GetLastAppoverGerenteJefe.FindUserByEmail", "82281f90-b59d-4ec7-8159-df2cb32ffef2");
using var queryActivity = activitySource.CreateSqlQueryActivity("GetLastAppoverGerenteJefe.FindUserByEmail", "82281f90-b59d-4ec7-8159-df2cb32ffef2", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string entityUserExtension = AppUtils.Instance.RuntimeEntityReplace("UserExtension");
string entityUser = AppUtils.Instance.RuntimeEntityReplace("User");
sqlCmd.CreateParameter("@qptei_Email", DbType.String, qptei_Email);
string sql = "";
string advSql = "SELECT \n    u.\"id\" AS UserId, \n    u.\"email\" AS UserEmail, \n    ue.\"correspondentexternalemail\" AS ExtensionEmail \nFROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUserExtension,"") + " ue \nJOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,"") + " u ON u.\"id\" = ue.\"id\" \nWHERE ue.\"correspondentexternalemail\" = @qptei_Email \n \nUNION ALL \n \nSELECT \n    u.\"id\" AS UserId, \n    u.\"email\" AS UserEmail, \n    NULL AS ExtensionEmail \nFROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,"") + " u \nWHERE u.\"email\" = @qptei_Email \n \nLIMIT 1;";
sql = advSql;
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_83566cec88e769363a30dc5e5b6a86f1 outParamList = new RL_83566cec88e769363a30dc5e5b6a86f1();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetLastAppoverGerenteJefe.FindUserByEmail.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_83566cec88e769363a30dc5e5b6a86f1 _tmp = new RL_83566cec88e769363a30dc5e5b6a86f1();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetLastAppoverGerenteJefe.FindUserByEmail.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_83566cec88e769363a30dc5e5b6a86f1)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("FindUserByEmail in GetLastAppoverGerenteJefe in ConectaProveedores (SELECT      u.[Id] AS UserId,      u.[Email] AS UserEmail,      ue.[CorrespondentExternalEmail] AS ExtensionEmail  FROM {UserExtension} ue  JOIN {User} u ON u.[Id] = ue.[Id]  WHERE ue.[CorrespondentExternalEmail] = @i_Email    UNION ALL    SELECT      u.[Id] AS UserId,      u.[Email] AS UserEmail,      NULL AS ExtensionEmail  FROM {User} u  WHERE u.[Email] = @i_Email    LIMIT 1;): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("FindUserByEmail in GetLastAppoverGerenteJefe in ConectaProveedores (SELECT      u.[Id] AS UserId,      u.[Email] AS UserEmail,      ue.[CorrespondentExternalEmail] AS ExtensionEmail  FROM {UserExtension} ue  JOIN {User} u ON u.[Id] = ue.[Id]  WHERE ue.[CorrespondentExternalEmail] = @i_Email    UNION ALL    SELECT      u.[Id] AS UserId,      u.[Email] AS UserEmail,      NULL AS ExtensionEmail  FROM {User} u  WHERE u.[Email] = @i_Email    LIMIT 1;): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("FindUserByEmail in GetLastAppoverGerenteJefe in ConectaProveedores (SELECT      u.[Id] AS UserId,      u.[Email] AS UserEmail,      ue.[CorrespondentExternalEmail] AS ExtensionEmail  FROM {UserExtension} ue  JOIN {User} u ON u.[Id] = ue.[Id]  WHERE ue.[CorrespondentExternalEmail] = @i_Email    UNION ALL    SELECT      u.[Id] AS UserId,      u.[Email] AS UserEmail,      NULL AS ExtensionEmail  FROM {User} u  WHERE u.[Email] = @i_Email    LIMIT 1;): " + aqExcep.Message));
}
}
}

private static async Task<RC_a5e9a82dc9980e7d5c34d4c26f706ace> datasetGetLastApproverReadDbAsync(RC_a5e9a82dc9980e7d5c34d4c26f706ace rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApprover.Read( r, ref index);
rec.ssENOrderApproval.Read( r, ref index);
rec.ssENOrderApprovalLevel.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
rec.ssENUserExtension.Read( r, ref index);
return rec;
}
// Query Function "GetLastApprover" LGx4kKmJtE6r+Dqu3oZjcg of Action "GetLastAppoverGerenteJefe"
public static async Task<(RL_a351086105893ea080eb7f2ace0f714d,long)> datasetGetLastApprover(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderMain_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetLastAppoverGerenteJefe.GetLastApprover", "90786c2c-89a9-4eb4-abf8-3aaede866372");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetLastAppoverGerenteJefe.GetLastApprover", "90786c2c-89a9-4eb4-abf8-3aaede866372", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.bv6dNdlmwkiHKf61aHQbzw/NodesNotShownInESpaceTree.LGx4kKmJtE6r+Dqu3oZjcg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"enapprover\".\"email\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, \"enuserextension18\".\"correspondentexternalemail\" o80, NULL o81");
fromBuilder.Append(" FROM ((((({OrderMain} \"enordermain13\" Left JOIN {OrderApproval} \"enorderapproval4\" ON (\"enordermain13\".\"id\" = \"enorderapproval4\".\"orderid\"))  Left JOIN {OrderApprovalLevel} \"enorderapprovallevel4\" ON (\"enorderapproval4\".\"id\" = \"enorderapprovallevel4\".\"orderapprovalid\"))  Left JOIN {User} \"enapprover\" ON (\"enorderapprovallevel4\".\"approvedby\" = \"enapprover\".\"id\"))  Left JOIN {User_Extended_Internal} \"enuser_extended_internal21\" ON (\"enapprover\".\"id\" = \"enuser_extended_internal21\".\"id\"))  Left JOIN {UserExtension} \"enuserextension18\" ON (\"enapprover\".\"id\" = \"enuserextension18\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderMain_Id != 0) {
whereBuilder.Append("((\"enordermain13\".\"id\" = @qporOrderMain_Id) AND (\"enordermain13\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderMain_Id", DbType.Int64, qporOrderMain_Id);
} else {
whereBuilder.Append("(\"enordermain13\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (\"enorderapprovallevel4\".\"approvalstatusid\" = ");
whereBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("rkrV30n0cEiW8dttOKG0gw"))).ssId);
whereBuilder.Append(")");
orderByBuilder.Append(" ORDER BY \"enorderapprovallevel4\".\"approvedon\" DESC ");
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
RL_a351086105893ea080eb7f2ace0f714d outParamList = new RL_a351086105893ea080eb7f2ace0f714d();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetLastApproverReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[6];
opt[0] = new BitArray(new bool[] {true, true, false, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, false, true});
opt[5] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetLastAppoverGerenteJefe.GetLastApprover.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_a351086105893ea080eb7f2ace0f714d _tmp = new RL_a351086105893ea080eb7f2ace0f714d();
_tmp.AlternateReadDbMethodAsync = datasetGetLastApproverReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetLastAppoverGerenteJefe.GetLastApprover.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_a351086105893ea080eb7f2ace0f714d)_tmp;
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
