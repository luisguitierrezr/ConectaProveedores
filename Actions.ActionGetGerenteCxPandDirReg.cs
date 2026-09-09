namespace ssConectaProveedores;

public partial class Actions {
public class lcvGetGerenteCxPandDirReg : VarsBag {
public EN_98680591dcf3728e0877a90eb5e1e552EntityRecord inParami_Requisition;
public long inParami_ApprovalProcessId;
/// <summary>
/// Variable <code>l_Count</code> that represents the Service Studio Integer <code>l_Count</code>
///  <p>Description: Count</p>
/// </summary>
public int varLcl_Count = 0;

public RL_4248243a08e8c50cd9576752f087e472 queryResGetApprovalProcessById_outParamList = new RL_4248243a08e8c50cd9576752f087e472();
public long queryResGetApprovalProcessById_outParamCount = 0L;

public Actions.lcoHasRoleNeeded resHasRoleNeeded =  new Actions.lcoHasRoleNeeded();
public Actions.lcoReqRoleIsNeeded resReqRoleIsNeeded =  new Actions.lcoReqRoleIsNeeded();
public lcvGetGerenteCxPandDirReg(EN_98680591dcf3728e0877a90eb5e1e552EntityRecord inParami_Requisition, long inParami_ApprovalProcessId) {
this.inParami_Requisition = inParami_Requisition;
this.inParami_ApprovalProcessId = inParami_ApprovalProcessId;
}
}
public class lcoGetGerenteCxPandDirReg : VarsBag {
public RL_75b7c1c818327cb126543d6d6a18a3c3 outParaml_RequisitionApprovalLevels = new RL_75b7c1c818327cb126543d6d6a18a3c3();

public lcoGetGerenteCxPandDirReg() {
}
}
/// <summary>
/// Action <code>GetGerenteCxPandDirReg</code> that represents the Service Studio action
///  <code>GetGerenteCxPandDirReg</code> <p> Description: </p>
/// </summary>
public static async Task<RL_75b7c1c818327cb126543d6d6a18a3c3> ActionGetGerenteCxPandDirReg(IRequestContext requestContext,EN_98680591dcf3728e0877a90eb5e1e552EntityRecord inParami_Requisition,long inParami_ApprovalProcessId,CancellationToken cancellationToken) {
RL_75b7c1c818327cb126543d6d6a18a3c3 outParaml_RequisitionApprovalLevels = default;
lcoGetGerenteCxPandDirReg result = new lcoGetGerenteCxPandDirReg();
lcvGetGerenteCxPandDirReg localVars = new lcvGetGerenteCxPandDirReg(inParami_Requisition, inParami_ApprovalProcessId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GetGerenteCxPandDirReg", "92910200-e16b-40eb-8dad-8d5166435f7c"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetGerenteCxPandDirReg", "92910200-e16b-40eb-8dad-8d5166435f7c", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetApprovalProcessById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetApprovalProcessById_maxRecords = 0;
int datasetGetApprovalProcessById_startIndex = 0;(localVars.queryResGetApprovalProcessById_outParamList,localVars.queryResGetApprovalProcessById_outParamCount) = await FuncActionGetGerenteCxPandDirReg.datasetGetApprovalProcessById(requestContext,datasetGetApprovalProcessById_maxRecords,datasetGetApprovalProcessById_startIndex,IterationMultiplicity.Single,localVars.inParami_ApprovalProcessId,cancellationToken);

// Foreach GetApprovalProcessById.List
localVars.queryResGetApprovalProcessById_outParamList.StartIteration();
try {while (!((localVars.queryResGetApprovalProcessById_outParamList.Eof))) {
// ReqRoleIsNeeded
(localVars.resReqRoleIsNeeded.outParamo_IsNeeded,localVars.resReqRoleIsNeeded.outParamo_ApprovalProcessLevel) = await Actions.ActionReqRoleIsNeeded(requestContext,localVars.inParami_Requisition,localVars.inParami_ApprovalProcessId,localVars.queryResGetApprovalProcessById_outParamList.CurrentRec.ssENApplicationRole.ssId,false,true,cancellationToken);

if((localVars.resReqRoleIsNeeded.outParamo_IsNeeded)) {
// HasRoleNeeded
(localVars.resHasRoleNeeded.outParamo_Output,localVars.resHasRoleNeeded.outParamo_UserId) = await Actions.ActionHasRoleNeeded(requestContext,localVars.queryResGetApprovalProcessById_outParamList.CurrentRec.ssENApplicationRole.ssId,localVars.queryResGetApprovalProcessById_outParamList.CurrentRec.ssENApplicationRole.ssName,"",localVars.inParami_Requisition.ssRegionId,3,cancellationToken);

// IsSuccess?
if((localVars.resHasRoleNeeded.outParamo_Output.ssIsSuccess)) {
// ListAppend
await ExtendedActions.ListAppend(requestContext,result.outParaml_RequisitionApprovalLevels,(await RecordUtils.ConvertAsync(localVars.resReqRoleIsNeeded.outParamo_ApprovalProcessLevel, new EN_27b1469f497d364a764a1359956ef9adEntityRecord(), async (EN_1d28318723f39133c60733b3cce8955eEntityRecord source, EN_27b1469f497d364a764a1359956ef9adEntityRecord target, CancellationToken cancellationToken) => {
target.ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ());
target.ssLevelNumber = localVars.varLcl_Count;
target.ssApplicationRoleId = source.ssApplicationRoleId;
target.ssDepartmentId = source.ssDepartmentId;
target.ssEntraRoleId = source.ssEntraRoleId;
target.ssAssignedTo = localVars.resHasRoleNeeded.outParamo_UserId;
target.ssNeedsContract = source.ssNeedsContract;
target.ssIsAccounting = source.ssIsAccounting_DEPREC;
target.ssIsStartAccounting = source.ssIsStartAccounting;
target.ssApproveAsAreaUsuaria = (localVars.resReqRoleIsNeeded.outParamo_ApprovalProcessLevel.ssNeedsContract||(localVars.resReqRoleIsNeeded.outParamo_ApprovalProcessLevel.ssNeedsProofOfForeignResidence&&(!localVars.resReqRoleIsNeeded.outParamo_ApprovalProcessLevel.ssIsAccounting_DEPREC)));
target.ssIsMandatory = localVars.queryResGetApprovalProcessById_outParamList.CurrentRec.ssENApprovalProcessLevel.ssIsMandatory;
return target;
}, cancellationToken)),cancellationToken);

// l_Count = l_Count + 1
localVars.varLcl_Count=(localVars.varLcl_Count+1);
} else {
// RaiseError InitializeWF
throw new Ex_InitializeWFUserException (localVars.resHasRoleNeeded.outParamo_Output.ssMessage);

}

}

localVars.queryResGetApprovalProcessById_outParamList.Advance();
}

} finally {
localVars.queryResGetApprovalProcessById_outParamList.EndIteration();
}

} //close CreateActionActivity using block
} // try

finally {
outParaml_RequisitionApprovalLevels = result.outParaml_RequisitionApprovalLevels;
} // inner-finally
RETURN_STATEMENT:
return outParaml_RequisitionApprovalLevels;
}

public static class FuncActionGetGerenteCxPandDirReg {

private static async Task<RC_3cc958ea69e2da94e66c1d6c79d0b67f> datasetGetApprovalProcessByIdReadDbAsync(RC_3cc958ea69e2da94e66c1d6c79d0b67f rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApplicationRole.Read( r, ref index);
rec.ssENApprovalProcess.Read( r, ref index);
rec.ssENApprovalProcessLevel.Read( r, ref index);
return rec;
}
// Query Function "GetApprovalProcessById" DJQxAD0lVUGXQLMyOdLnfw of Action "GetGerenteCxPandDirReg"
public static async Task<(RL_4248243a08e8c50cd9576752f087e472,long)> datasetGetApprovalProcessById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpapApprovalProcess_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetGerenteCxPandDirReg.GetApprovalProcessById", "0031940c-253d-4155-9740-b33239d2e77f");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetGerenteCxPandDirReg.GetApprovalProcessById", "0031940c-253d-4155-9740-b33239d2e77f", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.AAKRkmvh60CNrY1RZkNffA/NodesNotShownInESpaceTree.DJQxAD0lVUGXQLMyOdLnfw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enapplicationrole17\".\"id\" o0, NULL o1, \"enapplicationrole17\".\"name\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, \"enapprovalprocesslevel9\".\"ismandatory\" o51");
fromBuilder.Append(" FROM (({ApprovalProcess} \"enapprovalprocess23\" Left JOIN {ApprovalProcessLevel} \"enapprovalprocesslevel9\" ON (\"enapprovalprocess23\".\"id\" = \"enapprovalprocesslevel9\".\"approvalprocessid\"))  Left JOIN {ApplicationRole} \"enapplicationrole17\" ON (\"enapprovalprocesslevel9\".\"applicationroleid\" = \"enapplicationrole17\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpapApprovalProcess_Id != 0) {
whereBuilder.Append("((\"enapprovalprocess23\".\"id\" = @qpapApprovalProcess_Id) AND (\"enapprovalprocess23\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpapApprovalProcess_Id", DbType.Int64, qpapApprovalProcess_Id);
} else {
whereBuilder.Append("(\"enapprovalprocess23\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ((caseaccent_normalize((Upper(\"enapplicationrole17\".\"code\")) collate \"default\") like caseaccent_normalize('GERENTE_CXP' collate \"default\")) OR (caseaccent_normalize((Upper(\"enapplicationrole17\".\"code\")) collate \"default\") like caseaccent_normalize('DIRECTOR_REGIONAL' collate \"default\"))) AND (NOT (\"enapprovalprocesslevel9\".\"isaccounting_deprec\" = 1)) AND (\"enapprovalprocesslevel9\".\"ismandatory\" = 1)");
orderByBuilder.Append(" ORDER BY \"enapplicationrole17\".\"name\" DESC ");
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
RL_4248243a08e8c50cd9576752f087e472 outParamList = new RL_4248243a08e8c50cd9576752f087e472();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetApprovalProcessByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {false, true, false, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetGerenteCxPandDirReg.GetApprovalProcessById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_4248243a08e8c50cd9576752f087e472 _tmp = new RL_4248243a08e8c50cd9576752f087e472();
_tmp.AlternateReadDbMethodAsync = datasetGetApprovalProcessByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetGerenteCxPandDirReg.GetApprovalProcessById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_4248243a08e8c50cd9576752f087e472)_tmp;
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
