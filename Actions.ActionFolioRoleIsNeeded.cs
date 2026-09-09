namespace ssConectaProveedores;

public partial class Actions {
public class lcvFolioRoleIsNeeded : VarsBag {
public EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord inParami_Folio;
public long inParami_ApprovalProcessId;
public long inParami_ApplicationRoleId;
public bool inParami_IsAccounting;
public RL_36d34882aca7a5992acfb2360fb5208c queryResGetFolioById_outParamList = new RL_36d34882aca7a5992acfb2360fb5208c();
public long queryResGetFolioById_outParamCount = 0L;

public RL_52e01c48f1745de5266c16d6fe2c0564 queryResGetLevelWithNeededRole3_outParamList = new RL_52e01c48f1745de5266c16d6fe2c0564();
public long queryResGetLevelWithNeededRole3_outParamCount = 0L;

public RL_8dbe9b3349c28479d314d27fe2f03197 queryResGetApprovalProcessById_outParamList = new RL_8dbe9b3349c28479d314d27fe2f03197();
public long queryResGetApprovalProcessById_outParamCount = 0L;

public Actions.lcoFolioRoleIsNeeded_Configs resFolioRoleIsNeeded_Configs2 =  new Actions.lcoFolioRoleIsNeeded_Configs();
public Actions.lcoFolioRoleIsNeeded_Configs resFolioRoleIsNeeded_Configs =  new Actions.lcoFolioRoleIsNeeded_Configs();
public RL_8dbe9b3349c28479d314d27fe2f03197 queryResGetApprovalProcessByIdWithRegion_outParamList = new RL_8dbe9b3349c28479d314d27fe2f03197();
public long queryResGetApprovalProcessByIdWithRegion_outParamCount = 0L;

public RL_52e01c48f1745de5266c16d6fe2c0564 queryResGetLevelWithNeededRole_outParamList = new RL_52e01c48f1745de5266c16d6fe2c0564();
public long queryResGetLevelWithNeededRole_outParamCount = 0L;

public lcvFolioRoleIsNeeded(EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord inParami_Folio, long inParami_ApprovalProcessId, long inParami_ApplicationRoleId, bool inParami_IsAccounting) {
this.inParami_Folio = inParami_Folio;
this.inParami_ApprovalProcessId = inParami_ApprovalProcessId;
this.inParami_ApplicationRoleId = inParami_ApplicationRoleId;
this.inParami_IsAccounting = inParami_IsAccounting;
}
}
public class lcoFolioRoleIsNeeded : VarsBag {
public bool outParamo_IsNeeded = false;

public EN_1d28318723f39133c60733b3cce8955eEntityRecord outParamo_ApprovalProcessLevel = new EN_1d28318723f39133c60733b3cce8955eEntityRecord();

public lcoFolioRoleIsNeeded() {
}
}
/// <summary>
/// Action <code>FolioRoleIsNeeded</code> that represents the Service Studio action
///  <code>FolioRoleIsNeeded</code> <p> Description: </p>
/// </summary>
public static async Task<(bool,EN_1d28318723f39133c60733b3cce8955eEntityRecord)> ActionFolioRoleIsNeeded(IRequestContext requestContext,EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord inParami_Folio,long inParami_ApprovalProcessId,long inParami_ApplicationRoleId,bool inParami_IsAccounting,CancellationToken cancellationToken) {
bool outParamo_IsNeeded = default;
EN_1d28318723f39133c60733b3cce8955eEntityRecord outParamo_ApprovalProcessLevel = default;
lcoFolioRoleIsNeeded result = new lcoFolioRoleIsNeeded();
lcvFolioRoleIsNeeded localVars = new lcvFolioRoleIsNeeded(inParami_Folio, inParami_ApprovalProcessId, inParami_ApplicationRoleId, inParami_IsAccounting);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("FolioRoleIsNeeded", "fe240812-21f6-4e53-b514-18eb93e42c0d"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("FolioRoleIsNeeded", "fe240812-21f6-4e53-b514-18eb93e42c0d", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetFolioById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioById_maxRecords = 1;
if (datasetGetFolioById_maxRecords < 1) datasetGetFolioById_maxRecords = 1;
int datasetGetFolioById_startIndex = 0;(localVars.queryResGetFolioById_outParamList,localVars.queryResGetFolioById_outParamCount) = await FuncActionFolioRoleIsNeeded.datasetGetFolioById(requestContext,datasetGetFolioById_maxRecords,datasetGetFolioById_startIndex,IterationMultiplicity.Never,localVars.inParami_Folio.ssId,cancellationToken);

// Query datasetGetApprovalProcessByIdWithRegion
cancellationToken.ThrowIfCancellationRequested();
int datasetGetApprovalProcessByIdWithRegion_maxRecords = 1;
if (datasetGetApprovalProcessByIdWithRegion_maxRecords < 1) datasetGetApprovalProcessByIdWithRegion_maxRecords = 1;
int datasetGetApprovalProcessByIdWithRegion_startIndex = 0;(localVars.queryResGetApprovalProcessByIdWithRegion_outParamList,localVars.queryResGetApprovalProcessByIdWithRegion_outParamCount) = await FuncActionFolioRoleIsNeeded.datasetGetApprovalProcessByIdWithRegion(requestContext,datasetGetApprovalProcessByIdWithRegion_maxRecords,datasetGetApprovalProcessByIdWithRegion_startIndex,IterationMultiplicity.Never,localVars.queryResGetFolioById_outParamList.CurrentRec.ssENRegion.ssCommissionRegion,localVars.inParami_ApplicationRoleId,localVars.inParami_ApprovalProcessId,localVars.inParami_IsAccounting,cancellationToken);

// Empty?
if((localVars.queryResGetApprovalProcessByIdWithRegion_outParamList.Empty)) {
// Query datasetGetApprovalProcessById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetApprovalProcessById_maxRecords = 1;
if (datasetGetApprovalProcessById_maxRecords < 1) datasetGetApprovalProcessById_maxRecords = 1;
int datasetGetApprovalProcessById_startIndex = 0;(localVars.queryResGetApprovalProcessById_outParamList,localVars.queryResGetApprovalProcessById_outParamCount) = await FuncActionFolioRoleIsNeeded.datasetGetApprovalProcessById(requestContext,datasetGetApprovalProcessById_maxRecords,datasetGetApprovalProcessById_startIndex,IterationMultiplicity.Never,localVars.inParami_ApplicationRoleId,localVars.inParami_ApprovalProcessId,localVars.inParami_IsAccounting,cancellationToken);

// empty?
if((!(localVars.queryResGetApprovalProcessById_outParamList.Empty))) {
// exclude?
if((localVars.queryResGetApprovalProcessById_outParamList.CurrentRec.ssENApprovalProcessLevel.ssIsExclude)) {
// False
// o_IsNeeded = False
result.outParamo_IsNeeded=false;
goto RETURN_STATEMENT;

} else {
// conditions
if(((((((localVars.queryResGetApprovalProcessById_outParamList.CurrentRec.ssENApprovalProcessLevel.ssMinAmount!=(((decimal)0)))||(localVars.queryResGetApprovalProcessById_outParamList.CurrentRec.ssENApprovalProcessLevel.ssMaxAmount!=(((decimal)0))))||localVars.queryResGetApprovalProcessById_outParamList.CurrentRec.ssENApprovalProcessLevel.ssWithoutContract)||localVars.queryResGetApprovalProcessById_outParamList.CurrentRec.ssENApprovalProcessLevel.ssNeedsProofOfForeignResidence)||localVars.queryResGetApprovalProcessById_outParamList.CurrentRec.ssENApprovalProcessLevel.ssNeedsContract))) {
// FolioRoleIsNeeded_Configs
localVars.resFolioRoleIsNeeded_Configs.outParamIsOk = await Actions.ActionFolioRoleIsNeeded_Configs(requestContext,localVars.inParami_Folio,localVars.queryResGetApprovalProcessById_outParamList.CurrentRec.ssENApprovalProcessLevel,cancellationToken);

// not ok
if(((!localVars.resFolioRoleIsNeeded_Configs.outParamIsOk))) {
// False
// o_IsNeeded = False
result.outParamo_IsNeeded=false;
goto RETURN_STATEMENT;

}

}

// o_ApprovalProcessLevel = GetApprovalProcessById.List.Current.ApprovalProcessLevel
result.outParamo_ApprovalProcessLevel=localVars.queryResGetApprovalProcessById_outParamList.CurrentRec.ssENApprovalProcessLevel;
}

}

// Query datasetGetLevelWithNeededRole
cancellationToken.ThrowIfCancellationRequested();
int datasetGetLevelWithNeededRole_maxRecords = 1;
if (datasetGetLevelWithNeededRole_maxRecords < 1) datasetGetLevelWithNeededRole_maxRecords = 1;
int datasetGetLevelWithNeededRole_startIndex = 0;(localVars.queryResGetLevelWithNeededRole_outParamList,localVars.queryResGetLevelWithNeededRole_outParamCount) = await FuncActionFolioRoleIsNeeded.datasetGetLevelWithNeededRole(requestContext,datasetGetLevelWithNeededRole_maxRecords,datasetGetLevelWithNeededRole_startIndex,IterationMultiplicity.Never,localVars.inParami_ApplicationRoleId,localVars.inParami_Folio.ssId,cancellationToken);

// o_IsNeeded = GetLevelWithNeededRole.List.Empty
result.outParamo_IsNeeded=localVars.queryResGetLevelWithNeededRole_outParamList.Empty;
} else {
// exclude?
if((localVars.queryResGetApprovalProcessByIdWithRegion_outParamList.CurrentRec.ssENApprovalProcessLevel.ssIsExclude)) {
// False
// o_IsNeeded = False
result.outParamo_IsNeeded=false;
} else {
// conditions
if(((((((localVars.queryResGetApprovalProcessByIdWithRegion_outParamList.CurrentRec.ssENApprovalProcessLevel.ssMinAmount!=(((decimal)0)))||(localVars.queryResGetApprovalProcessByIdWithRegion_outParamList.CurrentRec.ssENApprovalProcessLevel.ssMaxAmount!=(((decimal)0))))||localVars.queryResGetApprovalProcessByIdWithRegion_outParamList.CurrentRec.ssENApprovalProcessLevel.ssWithoutContract)||localVars.queryResGetApprovalProcessByIdWithRegion_outParamList.CurrentRec.ssENApprovalProcessLevel.ssNeedsProofOfForeignResidence)||localVars.queryResGetApprovalProcessByIdWithRegion_outParamList.CurrentRec.ssENApprovalProcessLevel.ssNeedsContract))) {
// FolioRoleIsNeeded_Configs2
localVars.resFolioRoleIsNeeded_Configs2.outParamIsOk = await Actions.ActionFolioRoleIsNeeded_Configs(requestContext,localVars.inParami_Folio,localVars.queryResGetApprovalProcessByIdWithRegion_outParamList.CurrentRec.ssENApprovalProcessLevel,cancellationToken);

// not ok
if(((!localVars.resFolioRoleIsNeeded_Configs2.outParamIsOk))) {
// False
// o_IsNeeded = False
result.outParamo_IsNeeded=false;
goto RETURN_STATEMENT;

}

}

// o_ApprovalProcessLevel = GetApprovalProcessByIdWithRegion.List.Current.ApprovalProcessLevel
result.outParamo_ApprovalProcessLevel=localVars.queryResGetApprovalProcessByIdWithRegion_outParamList.CurrentRec.ssENApprovalProcessLevel;
// Query datasetGetLevelWithNeededRole3
cancellationToken.ThrowIfCancellationRequested();
int datasetGetLevelWithNeededRole3_maxRecords = 1;
if (datasetGetLevelWithNeededRole3_maxRecords < 1) datasetGetLevelWithNeededRole3_maxRecords = 1;
int datasetGetLevelWithNeededRole3_startIndex = 0;(localVars.queryResGetLevelWithNeededRole3_outParamList,localVars.queryResGetLevelWithNeededRole3_outParamCount) = await FuncActionFolioRoleIsNeeded.datasetGetLevelWithNeededRole3(requestContext,datasetGetLevelWithNeededRole3_maxRecords,datasetGetLevelWithNeededRole3_startIndex,IterationMultiplicity.Never,localVars.inParami_ApplicationRoleId,localVars.inParami_Folio.ssId,cancellationToken);

// o_IsNeeded = GetLevelWithNeededRole3.List.Empty
result.outParamo_IsNeeded=localVars.queryResGetLevelWithNeededRole3_outParamList.Empty;
}

}

} //close CreateActionActivity using block
} // try

finally {
outParamo_IsNeeded = result.outParamo_IsNeeded;
outParamo_ApprovalProcessLevel = result.outParamo_ApprovalProcessLevel;
} // inner-finally
RETURN_STATEMENT:
return (outParamo_IsNeeded,outParamo_ApprovalProcessLevel);
}

public static class FuncActionFolioRoleIsNeeded {

private static async Task<RC_bc05641ca90f5bed620129942456b69d> datasetGetFolioByIdReadDbAsync(RC_bc05641ca90f5bed620129942456b69d rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolio.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
return rec;
}
// Query Function "GetFolioById" 0deBGVRNJEqpWs8vVVx9hQ of Action "FolioRoleIsNeeded"
public static async Task<(RL_36d34882aca7a5992acfb2360fb5208c,long)> datasetGetFolioById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolio_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("FolioRoleIsNeeded.GetFolioById", "1981d7d1-4d54-4a24-a95a-cf2f555c7d85");
using var queryActivity = activitySource.CreateAggregateQueryActivity("FolioRoleIsNeeded.GetFolioById", "1981d7d1-4d54-4a24-a95a-cf2f555c7d85", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.Eggk_vYhU061FBjrk+QsDQ/NodesNotShownInESpaceTree.0deBGVRNJEqpWs8vVVx9hQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, \"enregion64\".\"commissionregion\" o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61");
fromBuilder.Append(" FROM (({Folio} \"enfolio59\" Left JOIN {OrderMain} \"enordermain67\" ON (\"enfolio59\".\"orderid\" = \"enordermain67\".\"id\"))  Left JOIN {Region} \"enregion64\" ON (\"enordermain67\".\"divisionid\" = \"enregion64\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoFolio_Id != 0) {
whereBuilder.Append("((\"enfolio59\".\"id\" = @qpfoFolio_Id) AND (\"enfolio59\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolio_Id", DbType.Int64, qpfoFolio_Id);
} else {
whereBuilder.Append("(\"enfolio59\".\"id\" IS NULL)");
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
RL_36d34882aca7a5992acfb2360fb5208c outParamList = new RL_36d34882aca7a5992acfb2360fb5208c();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFolioByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, false, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query FolioRoleIsNeeded.GetFolioById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_36d34882aca7a5992acfb2360fb5208c _tmp = new RL_36d34882aca7a5992acfb2360fb5208c();
_tmp.AlternateReadDbMethodAsync = datasetGetFolioByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query FolioRoleIsNeeded.GetFolioById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_36d34882aca7a5992acfb2360fb5208c)_tmp;
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

private static async Task<RC_131b941598d8581e5466dbb966f5f0a8> datasetGetLevelWithNeededRole3ReadDbAsync(RC_131b941598d8581e5466dbb966f5f0a8 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolioApproval.Read( r, ref index);
rec.ssENFolioApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetLevelWithNeededRole3" V_yYUYOLE0ShfKITTZH8Mg of Action "FolioRoleIsNeeded"
public static async Task<(RL_52e01c48f1745de5266c16d6fe2c0564,long)> datasetGetLevelWithNeededRole3(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpapFolioApprovalLevel_ApplicationRoleId,long qpfoFolioApproval_FolioId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("FolioRoleIsNeeded.GetLevelWithNeededRole3", "5198fc57-8b83-4413-a17c-a2134d91fc32");
using var queryActivity = activitySource.CreateAggregateQueryActivity("FolioRoleIsNeeded.GetLevelWithNeededRole3", "5198fc57-8b83-4413-a17c-a2134d91fc32", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.Eggk_vYhU061FBjrk+QsDQ/NodesNotShownInESpaceTree.V_yYUYOLE0ShfKITTZH8Mg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29");
fromBuilder.Append(" FROM ({FolioApproval} \"enfolioapproval32\" Left JOIN {FolioApprovalLevel} \"enfolioapprovallevel29\" ON (\"enfolioapproval32\".\"id\" = \"enfolioapprovallevel29\".\"folioapprovalid\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoFolioApproval_FolioId != 0) {
whereBuilder.Append("((\"enfolioapproval32\".\"folioid\" = @qpfoFolioApproval_FolioId) AND (\"enfolioapproval32\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioApproval_FolioId", DbType.Int64, qpfoFolioApproval_FolioId);
} else {
whereBuilder.Append("(\"enfolioapproval32\".\"folioid\" IS NULL)");
}
whereBuilder.Append(" AND ");
if (qpapFolioApprovalLevel_ApplicationRoleId != 0) {
whereBuilder.Append("((\"enfolioapprovallevel29\".\"applicationroleid\" = @qpapFolioApprovalLevel_ApplicationRoleId) AND (\"enfolioapprovallevel29\".\"applicationroleid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpapFolioApprovalLevel_ApplicationRoleId", DbType.Int64, qpapFolioApprovalLevel_ApplicationRoleId);
} else {
whereBuilder.Append("(\"enfolioapprovallevel29\".\"applicationroleid\" IS NULL)");
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
RL_52e01c48f1745de5266c16d6fe2c0564 outParamList = new RL_52e01c48f1745de5266c16d6fe2c0564();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetLevelWithNeededRole3ReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query FolioRoleIsNeeded.GetLevelWithNeededRole3.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_52e01c48f1745de5266c16d6fe2c0564 _tmp = new RL_52e01c48f1745de5266c16d6fe2c0564();
_tmp.AlternateReadDbMethodAsync = datasetGetLevelWithNeededRole3ReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query FolioRoleIsNeeded.GetLevelWithNeededRole3.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_52e01c48f1745de5266c16d6fe2c0564)_tmp;
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

private static async Task<RC_1c307c6ba13b1609f542644719b6e56b> datasetGetApprovalProcessByIdReadDbAsync(RC_1c307c6ba13b1609f542644719b6e56b rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApprovalProcess.Read( r, ref index);
rec.ssENApprovalProcessLevel.Read( r, ref index);
return rec;
}
// Query Function "GetApprovalProcessById" Def0UTk82kOjITTGe52Qsw of Action "FolioRoleIsNeeded"
public static async Task<(RL_8dbe9b3349c28479d314d27fe2f03197,long)> datasetGetApprovalProcessById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpapApprovalProcessLevel_ApplicationRoleId,long qpapApprovalProcess_Id,bool qpboApprovalProcessLevel_IsAccounting_DEPREC,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("FolioRoleIsNeeded.GetApprovalProcessById", "51f4e70d-3c39-43da-a321-34c67b9d90b3");
using var queryActivity = activitySource.CreateAggregateQueryActivity("FolioRoleIsNeeded.GetApprovalProcessById", "51f4e70d-3c39-43da-a321-34c67b9d90b3", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.Eggk_vYhU061FBjrk+QsDQ/NodesNotShownInESpaceTree.Def0UTk82kOjITTGe52Qsw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, \"enapprovalprocesslevel16\".\"id\" o19, \"enapprovalprocesslevel16\".\"approvalprocessid\" o20, \"enapprovalprocesslevel16\".\"levelnumber\" o21, \"enapprovalprocesslevel16\".\"applicationroleid\" o22, \"enapprovalprocesslevel16\".\"isapplicant\" o23, \"enapprovalprocesslevel16\".\"isfirstapprover\" o24, \"enapprovalprocesslevel16\".\"jobtitle\" o25, \"enapprovalprocesslevel16\".\"entraroleid\" o26, \"enapprovalprocesslevel16\".\"departmentid\" o27, \"enapprovalprocesslevel16\".\"managementid\" o28, \"enapprovalprocesslevel16\".\"subdirectionid\" o29, trim_scale(\"enapprovalprocesslevel16\".\"minamount\"::numeric) o30, trim_scale(\"enapprovalprocesslevel16\".\"maxamount\"::numeric) o31, \"enapprovalprocesslevel16\".\"isactive\" o32, \"enapprovalprocesslevel16\".\"excluderegion_deprec\" o33, \"enapprovalprocesslevel16\".\"onlyregion\" o34, \"enapprovalprocesslevel16\".\"withoutcontract\" o35, \"enapprovalprocesslevel16\".\"needsproofofforeignresidence\" o36, \"enapprovalprocesslevel16\".\"needscontract\" o37, \"enapprovalprocesslevel16\".\"isaccounting_deprec\" o38, \"enapprovalprocesslevel16\".\"isstartaccounting\" o39, \"enapprovalprocesslevel16\".\"canbefirstapprover\" o40, \"enapprovalprocesslevel16\".\"selectsnextapprover\" o41, \"enapprovalprocesslevel16\".\"selectsfirstapprover\" o42, \"enapprovalprocesslevel16\".\"isexclude\" o43, \"enapprovalprocesslevel16\".\"ismandatory\" o44");
fromBuilder.Append(" FROM ({ApprovalProcess} \"enapprovalprocess38\" Left JOIN {ApprovalProcessLevel} \"enapprovalprocesslevel16\" ON (\"enapprovalprocess38\".\"id\" = \"enapprovalprocesslevel16\".\"approvalprocessid\")) ");
whereBuilder.Append(" WHERE ");
if (qpapApprovalProcess_Id != 0) {
whereBuilder.Append("((\"enapprovalprocess38\".\"id\" = @qpapApprovalProcess_Id) AND (\"enapprovalprocess38\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpapApprovalProcess_Id", DbType.Int64, qpapApprovalProcess_Id);
} else {
whereBuilder.Append("(\"enapprovalprocess38\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ");
if (qpapApprovalProcessLevel_ApplicationRoleId != 0) {
whereBuilder.Append("((\"enapprovalprocesslevel16\".\"applicationroleid\" = @qpapApprovalProcessLevel_ApplicationRoleId) AND (\"enapprovalprocesslevel16\".\"applicationroleid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpapApprovalProcessLevel_ApplicationRoleId", DbType.Int64, qpapApprovalProcessLevel_ApplicationRoleId);
} else {
whereBuilder.Append("(\"enapprovalprocesslevel16\".\"applicationroleid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enapprovalprocesslevel16\".\"isaccounting_deprec\" = @qpboApprovalProcessLevel_IsAccounting_DEPREC) AND ((trim(\"enapprovalprocesslevel16\".\"onlyregion\")) = '')");
orderByBuilder.Append(" ORDER BY \"enapprovalprocesslevel16\".\"levelnumber\" ASC ");
sqlCmd.CreateParameterWithoutReplacements("@qpboApprovalProcessLevel_IsAccounting_DEPREC", DbType.Boolean, qpboApprovalProcessLevel_IsAccounting_DEPREC);
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
outParamList.AlternateReadDbMethodAsync = datasetGetApprovalProcessByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query FolioRoleIsNeeded.GetApprovalProcessById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_8dbe9b3349c28479d314d27fe2f03197 _tmp = new RL_8dbe9b3349c28479d314d27fe2f03197();
_tmp.AlternateReadDbMethodAsync = datasetGetApprovalProcessByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query FolioRoleIsNeeded.GetApprovalProcessById.List", cancellationToken: cancellationToken);
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

private static async Task<RC_1c307c6ba13b1609f542644719b6e56b> datasetGetApprovalProcessByIdWithRegionReadDbAsync(RC_1c307c6ba13b1609f542644719b6e56b rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApprovalProcess.Read( r, ref index);
rec.ssENApprovalProcessLevel.Read( r, ref index);
return rec;
}
// Query Function "GetApprovalProcessByIdWithRegion" GKQNftZ3IU+yunLuyIpGTw of Action "FolioRoleIsNeeded"
public static async Task<(RL_8dbe9b3349c28479d314d27fe2f03197,long)> datasetGetApprovalProcessByIdWithRegion(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteCommissionRegion,long qpapApprovalProcessLevel_ApplicationRoleId,long qpapApprovalProcess_Id,bool qpboApprovalProcessLevel_IsAccounting_DEPREC,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("FolioRoleIsNeeded.GetApprovalProcessByIdWithRegion", "7e0da418-77d6-4f21-b2ba-72eec88a464f");
using var queryActivity = activitySource.CreateAggregateQueryActivity("FolioRoleIsNeeded.GetApprovalProcessByIdWithRegion", "7e0da418-77d6-4f21-b2ba-72eec88a464f", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.Eggk_vYhU061FBjrk+QsDQ/NodesNotShownInESpaceTree.GKQNftZ3IU+yunLuyIpGTw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, \"enapprovalprocesslevel17\".\"id\" o19, \"enapprovalprocesslevel17\".\"approvalprocessid\" o20, \"enapprovalprocesslevel17\".\"levelnumber\" o21, \"enapprovalprocesslevel17\".\"applicationroleid\" o22, \"enapprovalprocesslevel17\".\"isapplicant\" o23, \"enapprovalprocesslevel17\".\"isfirstapprover\" o24, \"enapprovalprocesslevel17\".\"jobtitle\" o25, \"enapprovalprocesslevel17\".\"entraroleid\" o26, \"enapprovalprocesslevel17\".\"departmentid\" o27, \"enapprovalprocesslevel17\".\"managementid\" o28, \"enapprovalprocesslevel17\".\"subdirectionid\" o29, trim_scale(\"enapprovalprocesslevel17\".\"minamount\"::numeric) o30, trim_scale(\"enapprovalprocesslevel17\".\"maxamount\"::numeric) o31, \"enapprovalprocesslevel17\".\"isactive\" o32, \"enapprovalprocesslevel17\".\"excluderegion_deprec\" o33, \"enapprovalprocesslevel17\".\"onlyregion\" o34, \"enapprovalprocesslevel17\".\"withoutcontract\" o35, \"enapprovalprocesslevel17\".\"needsproofofforeignresidence\" o36, \"enapprovalprocesslevel17\".\"needscontract\" o37, \"enapprovalprocesslevel17\".\"isaccounting_deprec\" o38, \"enapprovalprocesslevel17\".\"isstartaccounting\" o39, \"enapprovalprocesslevel17\".\"canbefirstapprover\" o40, \"enapprovalprocesslevel17\".\"selectsnextapprover\" o41, \"enapprovalprocesslevel17\".\"selectsfirstapprover\" o42, \"enapprovalprocesslevel17\".\"isexclude\" o43, \"enapprovalprocesslevel17\".\"ismandatory\" o44");
fromBuilder.Append(" FROM ({ApprovalProcess} \"enapprovalprocess39\" Left JOIN {ApprovalProcessLevel} \"enapprovalprocesslevel17\" ON (\"enapprovalprocess39\".\"id\" = \"enapprovalprocesslevel17\".\"approvalprocessid\")) ");
whereBuilder.Append(" WHERE ");
if (qpapApprovalProcess_Id != 0) {
whereBuilder.Append("((\"enapprovalprocess39\".\"id\" = @qpapApprovalProcess_Id) AND (\"enapprovalprocess39\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpapApprovalProcess_Id", DbType.Int64, qpapApprovalProcess_Id);
} else {
whereBuilder.Append("(\"enapprovalprocess39\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ");
if (qpapApprovalProcessLevel_ApplicationRoleId != 0) {
whereBuilder.Append("((\"enapprovalprocesslevel17\".\"applicationroleid\" = @qpapApprovalProcessLevel_ApplicationRoleId) AND (\"enapprovalprocesslevel17\".\"applicationroleid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpapApprovalProcessLevel_ApplicationRoleId", DbType.Int64, qpapApprovalProcessLevel_ApplicationRoleId);
} else {
whereBuilder.Append("(\"enapprovalprocesslevel17\".\"applicationroleid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enapprovalprocesslevel17\".\"isaccounting_deprec\" = @qpboApprovalProcessLevel_IsAccounting_DEPREC) AND (((CASE WHEN char_length(caseaccent_normalize(@qpteCommissionRegion collate \"default\"))=0 THEN -1 ELSE (position(caseaccent_normalize(@qpteCommissionRegion collate \"default\") in caseaccent_normalize(\"enapprovalprocesslevel17\".\"onlyregion\" collate \"default\"))-1) END)) <> (-1))");
orderByBuilder.Append(" ORDER BY \"enapprovalprocesslevel17\".\"levelnumber\" ASC ");
sqlCmd.CreateParameterWithoutReplacements("@qpboApprovalProcessLevel_IsAccounting_DEPREC", DbType.Boolean, qpboApprovalProcessLevel_IsAccounting_DEPREC);
sqlCmd.CreateParameterWithoutReplacements("@qpteCommissionRegion", DbType.String, qpteCommissionRegion);
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
outParamList.AlternateReadDbMethodAsync = datasetGetApprovalProcessByIdWithRegionReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query FolioRoleIsNeeded.GetApprovalProcessByIdWithRegion.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_8dbe9b3349c28479d314d27fe2f03197 _tmp = new RL_8dbe9b3349c28479d314d27fe2f03197();
_tmp.AlternateReadDbMethodAsync = datasetGetApprovalProcessByIdWithRegionReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query FolioRoleIsNeeded.GetApprovalProcessByIdWithRegion.List", cancellationToken: cancellationToken);
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

private static async Task<RC_131b941598d8581e5466dbb966f5f0a8> datasetGetLevelWithNeededRoleReadDbAsync(RC_131b941598d8581e5466dbb966f5f0a8 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolioApproval.Read( r, ref index);
rec.ssENFolioApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetLevelWithNeededRole" rkl4u286DEOucm5iLGUWLg of Action "FolioRoleIsNeeded"
public static async Task<(RL_52e01c48f1745de5266c16d6fe2c0564,long)> datasetGetLevelWithNeededRole(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpapFolioApprovalLevel_ApplicationRoleId,long qpfoFolioApproval_FolioId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("FolioRoleIsNeeded.GetLevelWithNeededRole", "bb7849ae-3a6f-430c-ae72-6e622c65162e");
using var queryActivity = activitySource.CreateAggregateQueryActivity("FolioRoleIsNeeded.GetLevelWithNeededRole", "bb7849ae-3a6f-430c-ae72-6e622c65162e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.Eggk_vYhU061FBjrk+QsDQ/NodesNotShownInESpaceTree.rkl4u286DEOucm5iLGUWLg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29");
fromBuilder.Append(" FROM ({FolioApproval} \"enfolioapproval33\" Left JOIN {FolioApprovalLevel} \"enfolioapprovallevel30\" ON (\"enfolioapproval33\".\"id\" = \"enfolioapprovallevel30\".\"folioapprovalid\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoFolioApproval_FolioId != 0) {
whereBuilder.Append("((\"enfolioapproval33\".\"folioid\" = @qpfoFolioApproval_FolioId) AND (\"enfolioapproval33\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioApproval_FolioId", DbType.Int64, qpfoFolioApproval_FolioId);
} else {
whereBuilder.Append("(\"enfolioapproval33\".\"folioid\" IS NULL)");
}
whereBuilder.Append(" AND ");
if (qpapFolioApprovalLevel_ApplicationRoleId != 0) {
whereBuilder.Append("((\"enfolioapprovallevel30\".\"applicationroleid\" = @qpapFolioApprovalLevel_ApplicationRoleId) AND (\"enfolioapprovallevel30\".\"applicationroleid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpapFolioApprovalLevel_ApplicationRoleId", DbType.Int64, qpapFolioApprovalLevel_ApplicationRoleId);
} else {
whereBuilder.Append("(\"enfolioapprovallevel30\".\"applicationroleid\" IS NULL)");
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
RL_52e01c48f1745de5266c16d6fe2c0564 outParamList = new RL_52e01c48f1745de5266c16d6fe2c0564();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetLevelWithNeededRoleReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query FolioRoleIsNeeded.GetLevelWithNeededRole.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_52e01c48f1745de5266c16d6fe2c0564 _tmp = new RL_52e01c48f1745de5266c16d6fe2c0564();
_tmp.AlternateReadDbMethodAsync = datasetGetLevelWithNeededRoleReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query FolioRoleIsNeeded.GetLevelWithNeededRole.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_52e01c48f1745de5266c16d6fe2c0564)_tmp;
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
