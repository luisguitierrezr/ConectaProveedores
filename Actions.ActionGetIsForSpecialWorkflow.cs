namespace ssConectaProveedores;

public partial class Actions {
public class lcvGetIsForSpecialWorkflow : VarsBag {
public string inParamUserId;
public bool inParamIsDonation;
public string inParamProcessTypeCode;
public RL_8dbe9b3349c28479d314d27fe2f03197 queryResGetApprovProcPuestoGer_outParamList = new RL_8dbe9b3349c28479d314d27fe2f03197();
public long queryResGetApprovProcPuestoGer_outParamCount = 0L;

public RL_8dbe9b3349c28479d314d27fe2f03197 queryResGetApprovProcPuestoGerSubdir_outParamList = new RL_8dbe9b3349c28479d314d27fe2f03197();
public long queryResGetApprovProcPuestoGerSubdir_outParamCount = 0L;

public RL_8dbe9b3349c28479d314d27fe2f03197 queryResGetApprovProcPuestoSubdir_outParamList = new RL_8dbe9b3349c28479d314d27fe2f03197();
public long queryResGetApprovProcPuestoSubdir_outParamCount = 0L;

public RL_a37f5f153582e24adaea3ae8b54b3101 queryResGetUserExtendedInternalJobTitle_outParamList = new RL_a37f5f153582e24adaea3ae8b54b3101();
public long queryResGetUserExtendedInternalJobTitle_outParamCount = 0L;

public RL_50f86c7badf933578e482e000d347a03 queryResGetProcessTypeByCode_outParamList = new RL_50f86c7badf933578e482e000d347a03();
public long queryResGetProcessTypeByCode_outParamCount = 0L;

public RL_8dbe9b3349c28479d314d27fe2f03197 queryResGetApprovalProcess_outParamList = new RL_8dbe9b3349c28479d314d27fe2f03197();
public long queryResGetApprovalProcess_outParamCount = 0L;

public lcvGetIsForSpecialWorkflow(string inParamUserId, bool inParamIsDonation, string inParamProcessTypeCode) {
this.inParamUserId = inParamUserId;
this.inParamIsDonation = inParamIsDonation;
this.inParamProcessTypeCode = inParamProcessTypeCode;
}
}
public class lcoGetIsForSpecialWorkflow : VarsBag {
public bool outParamIsForSpecialWorkflow = false;

public lcoGetIsForSpecialWorkflow() {
}
}
/// <summary>
/// Action <code>GetIsForSpecialWorkflow</code> that represents the Service Studio action
///  <code>GetIsForSpecialWorkflow</code> <p> Description: </p>
/// </summary>
public static async Task<bool> ActionGetIsForSpecialWorkflow(IRequestContext requestContext,string inParamUserId,bool inParamIsDonation,string inParamProcessTypeCode,CancellationToken cancellationToken) {
bool outParamIsForSpecialWorkflow = default;
lcoGetIsForSpecialWorkflow result = new lcoGetIsForSpecialWorkflow();
lcvGetIsForSpecialWorkflow localVars = new lcvGetIsForSpecialWorkflow(inParamUserId, inParamIsDonation, inParamProcessTypeCode);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GetIsForSpecialWorkflow", "74839c6c-2dda-4cf9-9e55-40d335b298a1"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetIsForSpecialWorkflow", "74839c6c-2dda-4cf9-9e55-40d335b298a1", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetUserExtendedInternalJobTitle
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserExtendedInternalJobTitle_maxRecords = 1;
if (datasetGetUserExtendedInternalJobTitle_maxRecords < 1) datasetGetUserExtendedInternalJobTitle_maxRecords = 1;
int datasetGetUserExtendedInternalJobTitle_startIndex = 0;(localVars.queryResGetUserExtendedInternalJobTitle_outParamList,localVars.queryResGetUserExtendedInternalJobTitle_outParamCount) = await FuncActionGetIsForSpecialWorkflow.datasetGetUserExtendedInternalJobTitle(requestContext,datasetGetUserExtendedInternalJobTitle_maxRecords,datasetGetUserExtendedInternalJobTitle_startIndex,IterationMultiplicity.Never,localVars.inParamUserId,cancellationToken);

// Query datasetGetProcessTypeByCode
cancellationToken.ThrowIfCancellationRequested();
int datasetGetProcessTypeByCode_maxRecords = 1;
if (datasetGetProcessTypeByCode_maxRecords < 1) datasetGetProcessTypeByCode_maxRecords = 1;
int datasetGetProcessTypeByCode_startIndex = 0;(localVars.queryResGetProcessTypeByCode_outParamList,localVars.queryResGetProcessTypeByCode_outParamCount) = await FuncActionGetIsForSpecialWorkflow.datasetGetProcessTypeByCode(requestContext,datasetGetProcessTypeByCode_maxRecords,datasetGetProcessTypeByCode_startIndex,IterationMultiplicity.Never,localVars.inParamProcessTypeCode,cancellationToken);

// Empty
if((localVars.queryResGetProcessTypeByCode_outParamList.Empty)) {
// IsForSpecialWorkflow = False
result.outParamIsForSpecialWorkflow=false;
} else {
// Query datasetGetApprovProcPuestoGerSubdir
cancellationToken.ThrowIfCancellationRequested();
int datasetGetApprovProcPuestoGerSubdir_maxRecords = 1;
if (datasetGetApprovProcPuestoGerSubdir_maxRecords < 1) datasetGetApprovProcPuestoGerSubdir_maxRecords = 1;
int datasetGetApprovProcPuestoGerSubdir_startIndex = 0;(localVars.queryResGetApprovProcPuestoGerSubdir_outParamList,localVars.queryResGetApprovProcPuestoGerSubdir_outParamCount) = await FuncActionGetIsForSpecialWorkflow.datasetGetApprovProcPuestoGerSubdir(requestContext,datasetGetApprovProcPuestoGerSubdir_maxRecords,datasetGetApprovProcPuestoGerSubdir_startIndex,IterationMultiplicity.Never,localVars.queryResGetProcessTypeByCode_outParamList.CurrentRec.ssENProcessType.ssId,localVars.queryResGetUserExtendedInternalJobTitle_outParamList.CurrentRec.ssENEntraRole.ssId,localVars.queryResGetUserExtendedInternalJobTitle_outParamList.CurrentRec.ssENUser_Extended_Internal.ssManagementId,localVars.queryResGetUserExtendedInternalJobTitle_outParamList.CurrentRec.ssENUser_Extended_Internal.ssSubdirectionId,localVars.inParamIsDonation,cancellationToken);

// Empty?
if((localVars.queryResGetApprovProcPuestoGerSubdir_outParamList.Empty)) {
// Query datasetGetApprovProcPuestoGer
cancellationToken.ThrowIfCancellationRequested();
int datasetGetApprovProcPuestoGer_maxRecords = 1;
if (datasetGetApprovProcPuestoGer_maxRecords < 1) datasetGetApprovProcPuestoGer_maxRecords = 1;
int datasetGetApprovProcPuestoGer_startIndex = 0;(localVars.queryResGetApprovProcPuestoGer_outParamList,localVars.queryResGetApprovProcPuestoGer_outParamCount) = await FuncActionGetIsForSpecialWorkflow.datasetGetApprovProcPuestoGer(requestContext,datasetGetApprovProcPuestoGer_maxRecords,datasetGetApprovProcPuestoGer_startIndex,IterationMultiplicity.Never,localVars.queryResGetProcessTypeByCode_outParamList.CurrentRec.ssENProcessType.ssId,localVars.queryResGetUserExtendedInternalJobTitle_outParamList.CurrentRec.ssENEntraRole.ssId,localVars.queryResGetUserExtendedInternalJobTitle_outParamList.CurrentRec.ssENUser_Extended_Internal.ssManagementId,localVars.inParamIsDonation,cancellationToken);

// Empty?
if((localVars.queryResGetApprovProcPuestoGer_outParamList.Empty)) {
// Query datasetGetApprovProcPuestoSubdir
cancellationToken.ThrowIfCancellationRequested();
int datasetGetApprovProcPuestoSubdir_maxRecords = 1;
if (datasetGetApprovProcPuestoSubdir_maxRecords < 1) datasetGetApprovProcPuestoSubdir_maxRecords = 1;
int datasetGetApprovProcPuestoSubdir_startIndex = 0;(localVars.queryResGetApprovProcPuestoSubdir_outParamList,localVars.queryResGetApprovProcPuestoSubdir_outParamCount) = await FuncActionGetIsForSpecialWorkflow.datasetGetApprovProcPuestoSubdir(requestContext,datasetGetApprovProcPuestoSubdir_maxRecords,datasetGetApprovProcPuestoSubdir_startIndex,IterationMultiplicity.Never,localVars.queryResGetProcessTypeByCode_outParamList.CurrentRec.ssENProcessType.ssId,localVars.queryResGetUserExtendedInternalJobTitle_outParamList.CurrentRec.ssENEntraRole.ssId,localVars.queryResGetUserExtendedInternalJobTitle_outParamList.CurrentRec.ssENUser_Extended_Internal.ssSubdirectionId,localVars.inParamIsDonation,cancellationToken);

// Empty?
if((localVars.queryResGetApprovProcPuestoSubdir_outParamList.Empty)) {
// Query datasetGetApprovalProcess
cancellationToken.ThrowIfCancellationRequested();
int datasetGetApprovalProcess_maxRecords = 1;
if (datasetGetApprovalProcess_maxRecords < 1) datasetGetApprovalProcess_maxRecords = 1;
int datasetGetApprovalProcess_startIndex = 0;(localVars.queryResGetApprovalProcess_outParamList,localVars.queryResGetApprovalProcess_outParamCount) = await FuncActionGetIsForSpecialWorkflow.datasetGetApprovalProcess(requestContext,datasetGetApprovalProcess_maxRecords,datasetGetApprovalProcess_startIndex,IterationMultiplicity.Never,localVars.queryResGetProcessTypeByCode_outParamList.CurrentRec.ssENProcessType.ssId,localVars.queryResGetUserExtendedInternalJobTitle_outParamList.CurrentRec.ssENEntraRole.ssId,localVars.inParamIsDonation,cancellationToken);

// Empty?
if((localVars.queryResGetApprovalProcess_outParamList.Empty)) {
// IsForSpecialWorkflow = False
result.outParamIsForSpecialWorkflow=false;
} else {
// IsForSpecialWorkflow = True
result.outParamIsForSpecialWorkflow=true;
}

} else {
// IsForSpecialWorkflow = True
result.outParamIsForSpecialWorkflow=true;
}

} else {
// IsForSpecialWorkflow = True
result.outParamIsForSpecialWorkflow=true;
}

} else {
// IsForSpecialWorkflow = True
result.outParamIsForSpecialWorkflow=true;
}

}

} //close CreateActionActivity using block
} // try

finally {
outParamIsForSpecialWorkflow = result.outParamIsForSpecialWorkflow;
} // inner-finally
RETURN_STATEMENT:
return outParamIsForSpecialWorkflow;
}

public static class FuncActionGetIsForSpecialWorkflow {

private static async Task<RC_1c307c6ba13b1609f542644719b6e56b> datasetGetApprovProcPuestoGerReadDbAsync(RC_1c307c6ba13b1609f542644719b6e56b rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApprovalProcess.Read( r, ref index);
rec.ssENApprovalProcessLevel.Read( r, ref index);
return rec;
}
// Query Function "GetApprovProcPuestoGer" oeIWQE2q+kiRPaX0lA8Rlw of Action "GetIsForSpecialWorkflow"
public static async Task<(RL_8dbe9b3349c28479d314d27fe2f03197,long)> datasetGetApprovProcPuestoGer(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpprApprovalProcess_ProcessTypeId,long qpenApprovalProcessLevel_EntraRoleId,long qpmaApprovalProcessLevel_ManagementId,bool qpboApprovalProcess_IsDonation,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetIsForSpecialWorkflow.GetApprovProcPuestoGer", "4016e2a1-aa4d-48fa-913d-a5f4940f1197");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetIsForSpecialWorkflow.GetApprovProcPuestoGer", "4016e2a1-aa4d-48fa-913d-a5f4940f1197", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.bJyDdNot+UyeVUDTNbKYoQ/NodesNotShownInESpaceTree.oeIWQE2q+kiRPaX0lA8Rlw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44");
fromBuilder.Append(" FROM ({ApprovalProcess} \"enapprovalprocess17\" Left JOIN {ApprovalProcessLevel} \"enapprovalprocesslevel5\" ON (\"enapprovalprocess17\".\"id\" = \"enapprovalprocesslevel5\".\"approvalprocessid\")) ");
whereBuilder.Append(" WHERE ");
if (qpprApprovalProcess_ProcessTypeId != 0) {
whereBuilder.Append("((\"enapprovalprocess17\".\"processtypeid\" = @qpprApprovalProcess_ProcessTypeId) AND (\"enapprovalprocess17\".\"processtypeid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprApprovalProcess_ProcessTypeId", DbType.Int64, qpprApprovalProcess_ProcessTypeId);
} else {
whereBuilder.Append("(\"enapprovalprocess17\".\"processtypeid\" IS NULL)");
}
whereBuilder.Append(" AND ");
if (qpenApprovalProcessLevel_EntraRoleId != 0) {
whereBuilder.Append("((\"enapprovalprocesslevel5\".\"entraroleid\" = @qpenApprovalProcessLevel_EntraRoleId) AND (\"enapprovalprocesslevel5\".\"entraroleid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpenApprovalProcessLevel_EntraRoleId", DbType.Int64, qpenApprovalProcessLevel_EntraRoleId);
} else {
whereBuilder.Append("(\"enapprovalprocesslevel5\".\"entraroleid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enapprovalprocess17\".\"isdonation\" = @qpboApprovalProcess_IsDonation) AND (\"enapprovalprocess17\".\"isactive\" = 1) AND (\"enapprovalprocess17\".\"isspecial\" = 1) AND (\"enapprovalprocesslevel5\".\"isapplicant\" = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboApprovalProcess_IsDonation", DbType.Boolean, qpboApprovalProcess_IsDonation);
if (qpmaApprovalProcessLevel_ManagementId != 0) {
whereBuilder.Append("((\"enapprovalprocesslevel5\".\"managementid\" = @qpmaApprovalProcessLevel_ManagementId) AND (\"enapprovalprocesslevel5\".\"managementid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpmaApprovalProcessLevel_ManagementId", DbType.Int64, qpmaApprovalProcessLevel_ManagementId);
} else {
whereBuilder.Append("(\"enapprovalprocesslevel5\".\"managementid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enapprovalprocesslevel5\".\"subdirectionid\" IS NULL)");
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
RL_8dbe9b3349c28479d314d27fe2f03197 outParamList = new RL_8dbe9b3349c28479d314d27fe2f03197();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetApprovProcPuestoGerReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetIsForSpecialWorkflow.GetApprovProcPuestoGer.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_8dbe9b3349c28479d314d27fe2f03197 _tmp = new RL_8dbe9b3349c28479d314d27fe2f03197();
_tmp.AlternateReadDbMethodAsync = datasetGetApprovProcPuestoGerReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetIsForSpecialWorkflow.GetApprovProcPuestoGer.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_8dbe9b3349c28479d314d27fe2f03197)_tmp;
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

private static async Task<RC_1c307c6ba13b1609f542644719b6e56b> datasetGetApprovProcPuestoGerSubdirReadDbAsync(RC_1c307c6ba13b1609f542644719b6e56b rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApprovalProcess.Read( r, ref index);
rec.ssENApprovalProcessLevel.Read( r, ref index);
return rec;
}
// Query Function "GetApprovProcPuestoGerSubdir" n7TaeGUZFE+3vGHD2ktaRw of Action "GetIsForSpecialWorkflow"
public static async Task<(RL_8dbe9b3349c28479d314d27fe2f03197,long)> datasetGetApprovProcPuestoGerSubdir(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpprApprovalProcess_ProcessTypeId,long qpenApprovalProcessLevel_EntraRoleId,long qpmaApprovalProcessLevel_ManagementId,long qpsuApprovalProcessLevel_SubdirectionId,bool qpboApprovalProcess_IsDonation,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetIsForSpecialWorkflow.GetApprovProcPuestoGerSubdir", "78dab49f-1965-4f14-b7bc-61c3da4b5a47");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetIsForSpecialWorkflow.GetApprovProcPuestoGerSubdir", "78dab49f-1965-4f14-b7bc-61c3da4b5a47", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.bJyDdNot+UyeVUDTNbKYoQ/NodesNotShownInESpaceTree.n7TaeGUZFE+3vGHD2ktaRw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44");
fromBuilder.Append(" FROM ({ApprovalProcess} \"enapprovalprocess18\" Left JOIN {ApprovalProcessLevel} \"enapprovalprocesslevel6\" ON (\"enapprovalprocess18\".\"id\" = \"enapprovalprocesslevel6\".\"approvalprocessid\")) ");
whereBuilder.Append(" WHERE ");
if (qpprApprovalProcess_ProcessTypeId != 0) {
whereBuilder.Append("((\"enapprovalprocess18\".\"processtypeid\" = @qpprApprovalProcess_ProcessTypeId) AND (\"enapprovalprocess18\".\"processtypeid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprApprovalProcess_ProcessTypeId", DbType.Int64, qpprApprovalProcess_ProcessTypeId);
} else {
whereBuilder.Append("(\"enapprovalprocess18\".\"processtypeid\" IS NULL)");
}
whereBuilder.Append(" AND ");
if (qpenApprovalProcessLevel_EntraRoleId != 0) {
whereBuilder.Append("((\"enapprovalprocesslevel6\".\"entraroleid\" = @qpenApprovalProcessLevel_EntraRoleId) AND (\"enapprovalprocesslevel6\".\"entraroleid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpenApprovalProcessLevel_EntraRoleId", DbType.Int64, qpenApprovalProcessLevel_EntraRoleId);
} else {
whereBuilder.Append("(\"enapprovalprocesslevel6\".\"entraroleid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enapprovalprocess18\".\"isdonation\" = @qpboApprovalProcess_IsDonation) AND (\"enapprovalprocess18\".\"isactive\" = 1) AND (\"enapprovalprocess18\".\"isspecial\" = 1) AND (\"enapprovalprocesslevel6\".\"isapplicant\" = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboApprovalProcess_IsDonation", DbType.Boolean, qpboApprovalProcess_IsDonation);
if (qpmaApprovalProcessLevel_ManagementId != 0) {
whereBuilder.Append("((\"enapprovalprocesslevel6\".\"managementid\" = @qpmaApprovalProcessLevel_ManagementId) AND (\"enapprovalprocesslevel6\".\"managementid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpmaApprovalProcessLevel_ManagementId", DbType.Int64, qpmaApprovalProcessLevel_ManagementId);
} else {
whereBuilder.Append("(\"enapprovalprocesslevel6\".\"managementid\" IS NULL)");
}
whereBuilder.Append(" AND ");
if (qpsuApprovalProcessLevel_SubdirectionId != 0) {
whereBuilder.Append("((\"enapprovalprocesslevel6\".\"subdirectionid\" = @qpsuApprovalProcessLevel_SubdirectionId) AND (\"enapprovalprocesslevel6\".\"subdirectionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuApprovalProcessLevel_SubdirectionId", DbType.Int64, qpsuApprovalProcessLevel_SubdirectionId);
} else {
whereBuilder.Append("(\"enapprovalprocesslevel6\".\"subdirectionid\" IS NULL)");
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
RL_8dbe9b3349c28479d314d27fe2f03197 outParamList = new RL_8dbe9b3349c28479d314d27fe2f03197();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetApprovProcPuestoGerSubdirReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetIsForSpecialWorkflow.GetApprovProcPuestoGerSubdir.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_8dbe9b3349c28479d314d27fe2f03197 _tmp = new RL_8dbe9b3349c28479d314d27fe2f03197();
_tmp.AlternateReadDbMethodAsync = datasetGetApprovProcPuestoGerSubdirReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetIsForSpecialWorkflow.GetApprovProcPuestoGerSubdir.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_8dbe9b3349c28479d314d27fe2f03197)_tmp;
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

private static async Task<RC_1c307c6ba13b1609f542644719b6e56b> datasetGetApprovProcPuestoSubdirReadDbAsync(RC_1c307c6ba13b1609f542644719b6e56b rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApprovalProcess.Read( r, ref index);
rec.ssENApprovalProcessLevel.Read( r, ref index);
return rec;
}
// Query Function "GetApprovProcPuestoSubdir" 8rwvm+fHpkiQ3beMSgTPvQ of Action "GetIsForSpecialWorkflow"
public static async Task<(RL_8dbe9b3349c28479d314d27fe2f03197,long)> datasetGetApprovProcPuestoSubdir(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpprApprovalProcess_ProcessTypeId,long qpenApprovalProcessLevel_EntraRoleId,long qpsuApprovalProcessLevel_SubdirectionId,bool qpboApprovalProcess_IsDonation,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetIsForSpecialWorkflow.GetApprovProcPuestoSubdir", "9b2fbcf2-c7e7-48a6-90dd-b78c4a04cfbd");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetIsForSpecialWorkflow.GetApprovProcPuestoSubdir", "9b2fbcf2-c7e7-48a6-90dd-b78c4a04cfbd", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.bJyDdNot+UyeVUDTNbKYoQ/NodesNotShownInESpaceTree.8rwvm+fHpkiQ3beMSgTPvQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44");
fromBuilder.Append(" FROM ({ApprovalProcess} \"enapprovalprocess19\" Left JOIN {ApprovalProcessLevel} \"enapprovalprocesslevel7\" ON (\"enapprovalprocess19\".\"id\" = \"enapprovalprocesslevel7\".\"approvalprocessid\")) ");
whereBuilder.Append(" WHERE ");
if (qpprApprovalProcess_ProcessTypeId != 0) {
whereBuilder.Append("((\"enapprovalprocess19\".\"processtypeid\" = @qpprApprovalProcess_ProcessTypeId) AND (\"enapprovalprocess19\".\"processtypeid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprApprovalProcess_ProcessTypeId", DbType.Int64, qpprApprovalProcess_ProcessTypeId);
} else {
whereBuilder.Append("(\"enapprovalprocess19\".\"processtypeid\" IS NULL)");
}
whereBuilder.Append(" AND ");
if (qpenApprovalProcessLevel_EntraRoleId != 0) {
whereBuilder.Append("((\"enapprovalprocesslevel7\".\"entraroleid\" = @qpenApprovalProcessLevel_EntraRoleId) AND (\"enapprovalprocesslevel7\".\"entraroleid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpenApprovalProcessLevel_EntraRoleId", DbType.Int64, qpenApprovalProcessLevel_EntraRoleId);
} else {
whereBuilder.Append("(\"enapprovalprocesslevel7\".\"entraroleid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enapprovalprocess19\".\"isdonation\" = @qpboApprovalProcess_IsDonation) AND (\"enapprovalprocess19\".\"isactive\" = 1) AND (\"enapprovalprocess19\".\"isspecial\" = 1) AND (\"enapprovalprocesslevel7\".\"isapplicant\" = 1) AND (\"enapprovalprocesslevel7\".\"managementid\" IS NULL) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboApprovalProcess_IsDonation", DbType.Boolean, qpboApprovalProcess_IsDonation);
if (qpsuApprovalProcessLevel_SubdirectionId != 0) {
whereBuilder.Append("((\"enapprovalprocesslevel7\".\"subdirectionid\" = @qpsuApprovalProcessLevel_SubdirectionId) AND (\"enapprovalprocesslevel7\".\"subdirectionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuApprovalProcessLevel_SubdirectionId", DbType.Int64, qpsuApprovalProcessLevel_SubdirectionId);
} else {
whereBuilder.Append("(\"enapprovalprocesslevel7\".\"subdirectionid\" IS NULL)");
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
RL_8dbe9b3349c28479d314d27fe2f03197 outParamList = new RL_8dbe9b3349c28479d314d27fe2f03197();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetApprovProcPuestoSubdirReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetIsForSpecialWorkflow.GetApprovProcPuestoSubdir.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_8dbe9b3349c28479d314d27fe2f03197 _tmp = new RL_8dbe9b3349c28479d314d27fe2f03197();
_tmp.AlternateReadDbMethodAsync = datasetGetApprovProcPuestoSubdirReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetIsForSpecialWorkflow.GetApprovProcPuestoSubdir.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_8dbe9b3349c28479d314d27fe2f03197)_tmp;
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

private static async Task<RC_aad5e0f2e56c05eeddd020d008f4b3d7> datasetGetUserExtendedInternalJobTitleReadDbAsync(RC_aad5e0f2e56c05eeddd020d008f4b3d7 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENEntraRole.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
return rec;
}
// Query Function "GetUserExtendedInternalJobTitle" SrHRpRGMzki7vbCtJ9EbOQ of Action "GetIsForSpecialWorkflow"
public static async Task<(RL_a37f5f153582e24adaea3ae8b54b3101,long)> datasetGetUserExtendedInternalJobTitle(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetIsForSpecialWorkflow.GetUserExtendedInternalJobTitle", "a5d1b14a-8c11-48ce-bbbd-b0ad27d11b39");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetIsForSpecialWorkflow.GetUserExtendedInternalJobTitle", "a5d1b14a-8c11-48ce-bbbd-b0ad27d11b39", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.bJyDdNot+UyeVUDTNbKYoQ/NodesNotShownInESpaceTree.SrHRpRGMzki7vbCtJ9EbOQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enentrarole17\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, \"enuser_extended_internal45\".\"managementid\" o16, \"enuser_extended_internal45\".\"subdirectionid\" o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30");
fromBuilder.Append(" FROM (({User_Extended_Internal} \"enuser_extended_internal45\" Inner JOIN {User} \"enuser75\" ON (\"enuser_extended_internal45\".\"id\" = \"enuser75\".\"id\"))  Left JOIN {EntraRole} \"enentrarole17\" ON (\"enuser_extended_internal45\".\"entraroleid\" = \"enentrarole17\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser75\".\"id\" = @qpusUser_Id) AND (\"enuser75\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser75\".\"id\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"enuser75\".\"name\" ASC ");
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
RL_a37f5f153582e24adaea3ae8b54b3101 outParamList = new RL_a37f5f153582e24adaea3ae8b54b3101();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetUserExtendedInternalJobTitleReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, true, true, true, true});
opt[1] = new BitArray(new bool[] {false, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetIsForSpecialWorkflow.GetUserExtendedInternalJobTitle.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_a37f5f153582e24adaea3ae8b54b3101 _tmp = new RL_a37f5f153582e24adaea3ae8b54b3101();
_tmp.AlternateReadDbMethodAsync = datasetGetUserExtendedInternalJobTitleReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetIsForSpecialWorkflow.GetUserExtendedInternalJobTitle.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_a37f5f153582e24adaea3ae8b54b3101)_tmp;
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

// Query Function "GetProcessTypeByCode" AeQe8lmWVEy4WTrNBzN_Yg of Action "GetIsForSpecialWorkflow"
public static async Task<(RL_50f86c7badf933578e482e000d347a03,long)> datasetGetProcessTypeByCode(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteCode,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetIsForSpecialWorkflow.GetProcessTypeByCode", "f21ee401-9659-4c54-b859-3acd07337f62");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetIsForSpecialWorkflow.GetProcessTypeByCode", "f21ee401-9659-4c54-b859-3acd07337f62", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.bJyDdNot+UyeVUDTNbKYoQ/NodesNotShownInESpaceTree.AeQe8lmWVEy4WTrNBzN_Yg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enprocesstype6\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4");
fromBuilder.Append(" FROM {ProcessType} \"enprocesstype6\"");
whereBuilder.Append(" WHERE (\"enprocesstype6\".\"is_active\" = 1) AND (\"enprocesstype6\".\"code\" = @qpteCode)");
sqlCmd.CreateParameterWithoutReplacements("@qpteCode", DbType.String, qpteCode);
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
RL_50f86c7badf933578e482e000d347a03 outParamList = new RL_50f86c7badf933578e482e000d347a03();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetIsForSpecialWorkflow.GetProcessTypeByCode.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_50f86c7badf933578e482e000d347a03 _tmp = new RL_50f86c7badf933578e482e000d347a03();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetIsForSpecialWorkflow.GetProcessTypeByCode.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_50f86c7badf933578e482e000d347a03)_tmp;
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

private static async Task<RC_1c307c6ba13b1609f542644719b6e56b> datasetGetApprovalProcessReadDbAsync(RC_1c307c6ba13b1609f542644719b6e56b rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApprovalProcess.Read( r, ref index);
rec.ssENApprovalProcessLevel.Read( r, ref index);
return rec;
}
// Query Function "GetApprovalProcess" fmDO8haFyEWC4C8Wpvzauw of Action "GetIsForSpecialWorkflow"
public static async Task<(RL_8dbe9b3349c28479d314d27fe2f03197,long)> datasetGetApprovalProcess(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpprApprovalProcess_ProcessTypeId,long qpenApprovalProcessLevel_EntraRoleId,bool qpboApprovalProcess_IsDonation,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetIsForSpecialWorkflow.GetApprovalProcess", "f2ce607e-8516-45c8-82e0-2f16a6fcdabb");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetIsForSpecialWorkflow.GetApprovalProcess", "f2ce607e-8516-45c8-82e0-2f16a6fcdabb", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.bJyDdNot+UyeVUDTNbKYoQ/NodesNotShownInESpaceTree.fmDO8haFyEWC4C8Wpvzauw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44");
fromBuilder.Append(" FROM ({ApprovalProcess} \"enapprovalprocess20\" Left JOIN {ApprovalProcessLevel} \"enapprovalprocesslevel8\" ON (\"enapprovalprocess20\".\"id\" = \"enapprovalprocesslevel8\".\"approvalprocessid\")) ");
whereBuilder.Append(" WHERE ");
if (qpprApprovalProcess_ProcessTypeId != 0) {
whereBuilder.Append("((\"enapprovalprocess20\".\"processtypeid\" = @qpprApprovalProcess_ProcessTypeId) AND (\"enapprovalprocess20\".\"processtypeid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprApprovalProcess_ProcessTypeId", DbType.Int64, qpprApprovalProcess_ProcessTypeId);
} else {
whereBuilder.Append("(\"enapprovalprocess20\".\"processtypeid\" IS NULL)");
}
whereBuilder.Append(" AND ");
if (qpenApprovalProcessLevel_EntraRoleId != 0) {
whereBuilder.Append("((\"enapprovalprocesslevel8\".\"entraroleid\" = @qpenApprovalProcessLevel_EntraRoleId) AND (\"enapprovalprocesslevel8\".\"entraroleid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpenApprovalProcessLevel_EntraRoleId", DbType.Int64, qpenApprovalProcessLevel_EntraRoleId);
} else {
whereBuilder.Append("(\"enapprovalprocesslevel8\".\"entraroleid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enapprovalprocess20\".\"isdonation\" = @qpboApprovalProcess_IsDonation) AND (\"enapprovalprocess20\".\"isactive\" = 1) AND (\"enapprovalprocess20\".\"isspecial\" = 1) AND (\"enapprovalprocesslevel8\".\"isapplicant\" = 1)");
sqlCmd.CreateParameterWithoutReplacements("@qpboApprovalProcess_IsDonation", DbType.Boolean, qpboApprovalProcess_IsDonation);
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
RL_8dbe9b3349c28479d314d27fe2f03197 outParamList = new RL_8dbe9b3349c28479d314d27fe2f03197();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetApprovalProcessReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetIsForSpecialWorkflow.GetApprovalProcess.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_8dbe9b3349c28479d314d27fe2f03197 _tmp = new RL_8dbe9b3349c28479d314d27fe2f03197();
_tmp.AlternateReadDbMethodAsync = datasetGetApprovalProcessReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetIsForSpecialWorkflow.GetApprovalProcess.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_8dbe9b3349c28479d314d27fe2f03197)_tmp;
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
