namespace ssConectaProveedores;

public partial class Actions {
public class lcvGetReqNextApprover : VarsBag {
public long inParami_RequisitionId;
public string inParami_UserId;
public bool inParami_IsFirstApprover;
public RL_e87aa4fcc2debbce04977171112902a4 queryResGetNextRequisitionApprovalLevel_outParamList = new RL_e87aa4fcc2debbce04977171112902a4();
public long queryResGetNextRequisitionApprovalLevel_outParamCount = 0L;

public Actions.lcoFindReqNextApprover resFindReqNextApprover =  new Actions.lcoFindReqNextApprover();
public RL_afae8d527b0040f7963527494bd77f34 queryResGetCurrentRequisitionApprovalLevel_outParamList = new RL_afae8d527b0040f7963527494bd77f34();
public long queryResGetCurrentRequisitionApprovalLevel_outParamCount = 0L;

public Actions.lcoFindReqNextApprover resFindReqNextApprover2 =  new Actions.lcoFindReqNextApprover();
public lcvGetReqNextApprover(long inParami_RequisitionId, string inParami_UserId, bool inParami_IsFirstApprover) {
this.inParami_RequisitionId = inParami_RequisitionId;
this.inParami_UserId = inParami_UserId;
this.inParami_IsFirstApprover = inParami_IsFirstApprover;
}
}
public class lcoGetReqNextApprover : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public string outParamo_UserId = "";

public lcoGetReqNextApprover() {
}
}
/// <summary>
/// Action <code>GetReqNextApprover</code> that represents the Service Studio action
///  <code>GetReqNextApprover</code> <p> Description: </p>
/// </summary>
public static async Task<(ST_046fb53ebbe142526d95e87ef1ae9711Structure,string)> ActionGetReqNextApprover(IRequestContext requestContext,long inParami_RequisitionId,string inParami_UserId,bool inParami_IsFirstApprover,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
string outParamo_UserId = default;
lcoGetReqNextApprover result = new lcoGetReqNextApprover();
lcvGetReqNextApprover localVars = new lcvGetReqNextApprover(inParami_RequisitionId, inParami_UserId, inParami_IsFirstApprover);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GetReqNextApprover", "d3f74d87-3973-47cc-956b-e0f1b865a4ba"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetReqNextApprover", "d3f74d87-3973-47cc-956b-e0f1b865a4ba", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetCurrentRequisitionApprovalLevel
cancellationToken.ThrowIfCancellationRequested();
int datasetGetCurrentRequisitionApprovalLevel_maxRecords = 1;
if (datasetGetCurrentRequisitionApprovalLevel_maxRecords < 1) datasetGetCurrentRequisitionApprovalLevel_maxRecords = 1;
int datasetGetCurrentRequisitionApprovalLevel_startIndex = 0;(localVars.queryResGetCurrentRequisitionApprovalLevel_outParamList,localVars.queryResGetCurrentRequisitionApprovalLevel_outParamCount) = await FuncActionGetReqNextApprover.datasetGetCurrentRequisitionApprovalLevel(requestContext,datasetGetCurrentRequisitionApprovalLevel_maxRecords,datasetGetCurrentRequisitionApprovalLevel_startIndex,IterationMultiplicity.Never,localVars.inParami_RequisitionId,cancellationToken);

// Query datasetGetNextRequisitionApprovalLevel
cancellationToken.ThrowIfCancellationRequested();
int datasetGetNextRequisitionApprovalLevel_maxRecords = 1;
if (datasetGetNextRequisitionApprovalLevel_maxRecords < 1) datasetGetNextRequisitionApprovalLevel_maxRecords = 1;
int datasetGetNextRequisitionApprovalLevel_startIndex = 0;(localVars.queryResGetNextRequisitionApprovalLevel_outParamList,localVars.queryResGetNextRequisitionApprovalLevel_outParamCount) = await FuncActionGetReqNextApprover.datasetGetNextRequisitionApprovalLevel(requestContext,datasetGetNextRequisitionApprovalLevel_maxRecords,datasetGetNextRequisitionApprovalLevel_startIndex,IterationMultiplicity.Never,localVars.inParami_IsFirstApprover,localVars.inParami_RequisitionId,cancellationToken);

// Gerente CxP -> DIR. REG.
if(((((localVars.queryResGetCurrentRequisitionApprovalLevel_outParamList.CurrentRec.ssENApplicationRole.ssCode=="GERENTE_CXP")&&(localVars.queryResGetNextRequisitionApprovalLevel_outParamList.CurrentRec.ssENApplicationRole.ssCode=="DIRECTOR_REGIONAL"))||((localVars.queryResGetCurrentRequisitionApprovalLevel_outParamList.CurrentRec.ssENApplicationRole.ssCode=="DIRECTOR_REGIONAL")&&(localVars.queryResGetNextRequisitionApprovalLevel_outParamList.CurrentRec.ssENApplicationRole.ssCode=="GERENTE_CXP"))))) {
// FindReqNextApprover
(localVars.resFindReqNextApprover.outParamo_Output,localVars.resFindReqNextApprover.outParamo_UserId) = await Actions.ActionFindReqNextApprover(requestContext,localVars.queryResGetNextRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssApplicationRoleId,localVars.queryResGetNextRequisitionApprovalLevel_outParamList.CurrentRec.ssENApplicationRole.ssName,"",localVars.queryResGetNextRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisition.ssRegionId,cancellationToken);

// IsSuccess
if((localVars.resFindReqNextApprover.outParamo_Output.ssIsSuccess)) {
// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;

// o_UserId = FindReqNextApprover.o_UserId
result.outParamo_UserId=localVars.resFindReqNextApprover.outParamo_UserId;
} else {
// o_Output
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = FindReqNextApprover.o_Output.Message
result.outParamo_Output.ssMessage = localVars.resFindReqNextApprover.outParamo_Output.ssMessage;
}

} else {
// IsStartAccounting
if((localVars.queryResGetNextRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssIsStartAccounting)) {
// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
} else {
// FindReqNextApprover2
(localVars.resFindReqNextApprover2.outParamo_Output,localVars.resFindReqNextApprover2.outParamo_UserId) = await Actions.ActionFindReqNextApprover(requestContext,localVars.queryResGetNextRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssApplicationRoleId,localVars.queryResGetNextRequisitionApprovalLevel_outParamList.CurrentRec.ssENApplicationRole.ssName,localVars.inParami_UserId,0L,cancellationToken);

// IsSuccess
if((localVars.resFindReqNextApprover2.outParamo_Output.ssIsSuccess)) {
// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;

// o_UserId = FindReqNextApprover2.o_UserId
result.outParamo_UserId=localVars.resFindReqNextApprover2.outParamo_UserId;
} else {
// o_Output
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = FindReqNextApprover2.o_Output.Message
result.outParamo_Output.ssMessage = localVars.resFindReqNextApprover2.outParamo_Output.ssMessage;
}

}

}

} //close CreateActionActivity using block
} // try

finally {
outParamo_Output = result.outParamo_Output;
outParamo_UserId = result.outParamo_UserId;
} // inner-finally
RETURN_STATEMENT:
return (outParamo_Output,outParamo_UserId);
}

public static class FuncActionGetReqNextApprover {

private static async Task<RC_3010654f80c827b760b6758b9f15acbb> datasetGetNextRequisitionApprovalLevelReadDbAsync(RC_3010654f80c827b760b6758b9f15acbb rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApplicationRole.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
rec.ssENRequisitionApproval.Read( r, ref index);
rec.ssENRequisitionApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetNextRequisitionApprovalLevel" cs8HCK3wiUuhoZ1k3kizBA of Action "GetReqNextApprover"
public static async Task<(RL_e87aa4fcc2debbce04977171112902a4,long)> datasetGetNextRequisitionApprovalLevel(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboi_IsFirstApprover,long qpreRequisitionApproval_RequisitionId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetReqNextApprover.GetNextRequisitionApprovalLevel", "0807cf72-f0ad-4b89-a1a1-9d64de48b304");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetReqNextApprover.GetNextRequisitionApprovalLevel", "0807cf72-f0ad-4b89-a1a1-9d64de48b304", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.h03303M5zEeVa+DxuGWkug/NodesNotShownInESpaceTree.cs8HCK3wiUuhoZ1k3kizBA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enapplicationrole28\".\"code\" o1, \"enapplicationrole28\".\"name\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, \"enrequisition61\".\"regionid\" o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, \"enrequisitionapprovallevel15\".\"applicationroleid\" o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, \"enrequisitionapprovallevel15\".\"isstartaccounting\" o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100");
fromBuilder.Append(" FROM ((({RequisitionApproval} \"enrequisitionapproval17\" Left JOIN {RequisitionApprovalLevel} \"enrequisitionapprovallevel15\" ON (\"enrequisitionapproval17\".\"id\" = \"enrequisitionapprovallevel15\".\"requisitionapprovalid\"))  Left JOIN {ApplicationRole} \"enapplicationrole28\" ON (\"enrequisitionapprovallevel15\".\"applicationroleid\" = \"enapplicationrole28\".\"id\"))  Left JOIN {Requisition} \"enrequisition61\" ON (\"enrequisitionapproval17\".\"requisitionid\" = \"enrequisition61\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpreRequisitionApproval_RequisitionId != 0) {
whereBuilder.Append("((\"enrequisitionapproval17\".\"requisitionid\" = @qpreRequisitionApproval_RequisitionId) AND (\"enrequisitionapproval17\".\"requisitionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisitionApproval_RequisitionId", DbType.Int64, qpreRequisitionApproval_RequisitionId);
} else {
whereBuilder.Append("(\"enrequisitionapproval17\".\"requisitionid\" IS NULL)");
}
whereBuilder.Append(" AND ((CASE WHEN (@qpboi_IsFirstApprover = 1) THEN (CASE WHEN (\"enrequisitionapprovallevel15\".\"levelnumber\" = \"enrequisitionapproval17\".\"currentlevel\") THEN 1 ELSE 0 END) ELSE (CASE WHEN (\"enrequisitionapprovallevel15\".\"levelnumber\" > \"enrequisitionapproval17\".\"currentlevel\") THEN 1 ELSE 0 END) END) = 1)");
orderByBuilder.Append(" ORDER BY \"enrequisitionapprovallevel15\".\"levelnumber\" ASC ");
sqlCmd.CreateParameterWithoutReplacements("@qpboi_IsFirstApprover", DbType.Boolean, qpboi_IsFirstApprover);
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
RL_e87aa4fcc2debbce04977171112902a4 outParamList = new RL_e87aa4fcc2debbce04977171112902a4();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetNextRequisitionApprovalLevelReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[4];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, false, false, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetReqNextApprover.GetNextRequisitionApprovalLevel.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_e87aa4fcc2debbce04977171112902a4 _tmp = new RL_e87aa4fcc2debbce04977171112902a4();
_tmp.AlternateReadDbMethodAsync = datasetGetNextRequisitionApprovalLevelReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetReqNextApprover.GetNextRequisitionApprovalLevel.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_e87aa4fcc2debbce04977171112902a4)_tmp;
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

private static async Task<RC_ba1b673fb7796808ead75722c028b587> datasetGetCurrentRequisitionApprovalLevelReadDbAsync(RC_ba1b673fb7796808ead75722c028b587 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApplicationRole.Read( r, ref index);
rec.ssENRequisitionApproval.Read( r, ref index);
rec.ssENRequisitionApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetCurrentRequisitionApprovalLevel" BnfjiOGKMkOZHFtmovMZoA of Action "GetReqNextApprover"
public static async Task<(RL_afae8d527b0040f7963527494bd77f34,long)> datasetGetCurrentRequisitionApprovalLevel(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisitionApproval_RequisitionId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetReqNextApprover.GetCurrentRequisitionApprovalLevel", "88e37706-8ae1-4332-991c-5b66a2f319a0");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetReqNextApprover.GetCurrentRequisitionApprovalLevel", "88e37706-8ae1-4332-991c-5b66a2f319a0", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.h03303M5zEeVa+DxuGWkug/NodesNotShownInESpaceTree.BnfjiOGKMkOZHFtmovMZoA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enapplicationrole29\".\"code\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42");
fromBuilder.Append(" FROM (({RequisitionApproval} \"enrequisitionapproval18\" Left JOIN {RequisitionApprovalLevel} \"enrequisitionapprovallevel16\" ON (\"enrequisitionapproval18\".\"id\" = \"enrequisitionapprovallevel16\".\"requisitionapprovalid\"))  Left JOIN {ApplicationRole} \"enapplicationrole29\" ON (\"enrequisitionapprovallevel16\".\"applicationroleid\" = \"enapplicationrole29\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpreRequisitionApproval_RequisitionId != 0) {
whereBuilder.Append("((\"enrequisitionapproval18\".\"requisitionid\" = @qpreRequisitionApproval_RequisitionId) AND (\"enrequisitionapproval18\".\"requisitionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisitionApproval_RequisitionId", DbType.Int64, qpreRequisitionApproval_RequisitionId);
} else {
whereBuilder.Append("(\"enrequisitionapproval18\".\"requisitionid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enrequisitionapproval18\".\"currentlevel\" = \"enrequisitionapprovallevel16\".\"levelnumber\")");
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
RL_afae8d527b0040f7963527494bd77f34 outParamList = new RL_afae8d527b0040f7963527494bd77f34();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetCurrentRequisitionApprovalLevelReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, false, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetReqNextApprover.GetCurrentRequisitionApprovalLevel.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_afae8d527b0040f7963527494bd77f34 _tmp = new RL_afae8d527b0040f7963527494bd77f34();
_tmp.AlternateReadDbMethodAsync = datasetGetCurrentRequisitionApprovalLevelReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetReqNextApprover.GetCurrentRequisitionApprovalLevel.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_afae8d527b0040f7963527494bd77f34)_tmp;
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
