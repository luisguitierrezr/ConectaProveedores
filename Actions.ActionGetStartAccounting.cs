namespace ssConectaProveedores;

public partial class Actions {
public class lcvGetStartAccounting : VarsBag {
public long inParami_ApprovalProcessId;
public string inParami_CommissionRegion;
public long inParami_RegionId;
public RL_4248243a08e8c50cd9576752f087e472 queryResGetApprovalProcessById_outParamList = new RL_4248243a08e8c50cd9576752f087e472();
public long queryResGetApprovalProcessById_outParamCount = 0L;

public int resListIndexOf_outParamPosition = 0;

public lcvGetStartAccounting(long inParami_ApprovalProcessId, string inParami_CommissionRegion, long inParami_RegionId) {
this.inParami_ApprovalProcessId = inParami_ApprovalProcessId;
this.inParami_CommissionRegion = inParami_CommissionRegion;
this.inParami_RegionId = inParami_RegionId;
}
}
public class lcoGetStartAccounting : VarsBag {
public string outParami_AssignTo = "";

public EN_1d28318723f39133c60733b3cce8955eEntityRecord outParamo_ApprovalProcessLevel = new EN_1d28318723f39133c60733b3cce8955eEntityRecord();

public lcoGetStartAccounting() {
}
}
/// <summary>
/// Action <code>GetStartAccounting</code> that represents the Service Studio action
///  <code>GetStartAccounting</code> <p> Description: </p>
/// </summary>
public static async Task<(string,EN_1d28318723f39133c60733b3cce8955eEntityRecord)> ActionGetStartAccounting(IRequestContext requestContext,long inParami_ApprovalProcessId,string inParami_CommissionRegion,long inParami_RegionId,CancellationToken cancellationToken) {
string outParami_AssignTo = default;
EN_1d28318723f39133c60733b3cce8955eEntityRecord outParamo_ApprovalProcessLevel = default;
lcoGetStartAccounting result = new lcoGetStartAccounting();
lcvGetStartAccounting localVars = new lcvGetStartAccounting(inParami_ApprovalProcessId, inParami_CommissionRegion, inParami_RegionId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GetStartAccounting", "b7b85f09-01bd-4679-a7ca-b2817909e33d"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetStartAccounting", "b7b85f09-01bd-4679-a7ca-b2817909e33d", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetApprovalProcessById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetApprovalProcessById_maxRecords = 0;
int datasetGetApprovalProcessById_startIndex = 0;(localVars.queryResGetApprovalProcessById_outParamList,localVars.queryResGetApprovalProcessById_outParamCount) = await FuncActionGetStartAccounting.datasetGetApprovalProcessById(requestContext,datasetGetApprovalProcessById_maxRecords,datasetGetApprovalProcessById_startIndex,IterationMultiplicity.Multiple,localVars.inParami_ApprovalProcessId,cancellationToken);

// Empty?
if((!(localVars.queryResGetApprovalProcessById_outParamList.Empty))) {
// Foreach GetApprovalProcessById.List
localVars.queryResGetApprovalProcessById_outParamList.StartIteration();
try {while (!((localVars.queryResGetApprovalProcessById_outParamList.Eof))) {
if(((BuiltInFunction.IndexSC (localVars.queryResGetApprovalProcessById_outParamList.CurrentRec.ssENApprovalProcessLevel.ssOnlyRegion, localVars.inParami_CommissionRegion, 0, false, false)!=(-1)))) {
// o_ApprovalProcessLevel = GetApprovalProcessById.List.Current.ApprovalProcessLevel
result.outParamo_ApprovalProcessLevel=localVars.queryResGetApprovalProcessById_outParamList.CurrentRec.ssENApprovalProcessLevel;
goto RETURN_STATEMENT;

}

localVars.queryResGetApprovalProcessById_outParamList.Advance();
}

} finally {
localVars.queryResGetApprovalProcessById_outParamList.EndIteration();
}

// ListIndexOf
localVars.resListIndexOf_outParamPosition = await ExtendedActions.ListIndexOf(requestContext,localVars.queryResGetApprovalProcessById_outParamList,async (p, cancellationToken) => (BuiltInFunction.Trim (p.ssENApprovalProcessLevel.ssOnlyRegion)==""),cancellationToken);

if(((localVars.resListIndexOf_outParamPosition!=(-1)))) {
// o_ApprovalProcessLevel = GetApprovalProcessById.List[ListIndexOf.Position].ApprovalProcessLevel
result.outParamo_ApprovalProcessLevel=localVars.queryResGetApprovalProcessById_outParamList[localVars.resListIndexOf_outParamPosition].ssENApprovalProcessLevel;
}

}

} //close CreateActionActivity using block
} // try

finally {
outParami_AssignTo = result.outParami_AssignTo;
outParamo_ApprovalProcessLevel = result.outParamo_ApprovalProcessLevel;
} // inner-finally
RETURN_STATEMENT:
return (outParami_AssignTo,outParamo_ApprovalProcessLevel);
}

public static class FuncActionGetStartAccounting {

private static async Task<RC_3cc958ea69e2da94e66c1d6c79d0b67f> datasetGetApprovalProcessByIdReadDbAsync(RC_3cc958ea69e2da94e66c1d6c79d0b67f rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApplicationRole.Read( r, ref index);
rec.ssENApprovalProcess.Read( r, ref index);
rec.ssENApprovalProcessLevel.Read( r, ref index);
return rec;
}
// Query Function "GetApprovalProcessById" MZ_YU6FXY0SjGdhnnfXNHg of Action "GetStartAccounting"
public static async Task<(RL_4248243a08e8c50cd9576752f087e472,long)> datasetGetApprovalProcessById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpapApprovalProcess_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetStartAccounting.GetApprovalProcessById", "53d89f31-57a1-4463-a319-d8679df5cd1e");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetStartAccounting.GetApprovalProcessById", "53d89f31-57a1-4463-a319-d8679df5cd1e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Multiple
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
selectBuilder.Append("/* /UserActions.CV+4t70BeUanyrKBeQnjPQ/NodesNotShownInESpaceTree.MZ_YU6FXY0SjGdhnnfXNHg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, \"enapprovalprocesslevel10\".\"id\" o26, \"enapprovalprocesslevel10\".\"approvalprocessid\" o27, \"enapprovalprocesslevel10\".\"levelnumber\" o28, \"enapprovalprocesslevel10\".\"applicationroleid\" o29, \"enapprovalprocesslevel10\".\"isapplicant\" o30, \"enapprovalprocesslevel10\".\"isfirstapprover\" o31, \"enapprovalprocesslevel10\".\"jobtitle\" o32, \"enapprovalprocesslevel10\".\"entraroleid\" o33, \"enapprovalprocesslevel10\".\"departmentid\" o34, \"enapprovalprocesslevel10\".\"managementid\" o35, \"enapprovalprocesslevel10\".\"subdirectionid\" o36, trim_scale(\"enapprovalprocesslevel10\".\"minamount\"::numeric) o37, trim_scale(\"enapprovalprocesslevel10\".\"maxamount\"::numeric) o38, \"enapprovalprocesslevel10\".\"isactive\" o39, \"enapprovalprocesslevel10\".\"excluderegion_deprec\" o40, \"enapprovalprocesslevel10\".\"onlyregion\" o41, \"enapprovalprocesslevel10\".\"withoutcontract\" o42, \"enapprovalprocesslevel10\".\"needsproofofforeignresidence\" o43, \"enapprovalprocesslevel10\".\"needscontract\" o44, \"enapprovalprocesslevel10\".\"isaccounting_deprec\" o45, \"enapprovalprocesslevel10\".\"isstartaccounting\" o46, \"enapprovalprocesslevel10\".\"canbefirstapprover\" o47, \"enapprovalprocesslevel10\".\"selectsnextapprover\" o48, \"enapprovalprocesslevel10\".\"selectsfirstapprover\" o49, \"enapprovalprocesslevel10\".\"isexclude\" o50, \"enapprovalprocesslevel10\".\"ismandatory\" o51");
fromBuilder.Append(" FROM (({ApprovalProcess} \"enapprovalprocess26\" Left JOIN {ApprovalProcessLevel} \"enapprovalprocesslevel10\" ON (\"enapprovalprocess26\".\"id\" = \"enapprovalprocesslevel10\".\"approvalprocessid\"))  Left JOIN {ApplicationRole} \"enapplicationrole24\" ON (\"enapprovalprocesslevel10\".\"applicationroleid\" = \"enapplicationrole24\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpapApprovalProcess_Id != 0) {
whereBuilder.Append("((\"enapprovalprocess26\".\"id\" = @qpapApprovalProcess_Id) AND (\"enapprovalprocess26\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpapApprovalProcess_Id", DbType.Int64, qpapApprovalProcess_Id);
} else {
whereBuilder.Append("(\"enapprovalprocess26\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (\"enapprovalprocesslevel10\".\"isstartaccounting\" = 1)");
orderByBuilder.Append(" ORDER BY \"enapprovalprocesslevel10\".\"levelnumber\" ASC ");
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
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetStartAccounting.GetApprovalProcessById.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetStartAccounting.GetApprovalProcessById.List", cancellationToken: cancellationToken);
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
