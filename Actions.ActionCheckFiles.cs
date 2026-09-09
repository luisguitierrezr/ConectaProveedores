namespace ssConectaProveedores;

public partial class Actions {
public class lcvCheckFiles : VarsBag {
public long inParamRequisitionId;
public RL_8794daf8a03a814b6ca9e26cee0933c6 queryResGetRequisitionFilesById_outParamList = new RL_8794daf8a03a814b6ca9e26cee0933c6();
public long queryResGetRequisitionFilesById_outParamCount = 0L;

public lcvCheckFiles(long inParamRequisitionId) {
this.inParamRequisitionId = inParamRequisitionId;
}
}
public class lcoCheckFiles : VarsBag {
public string outParamO_ErrorMessage = "";

public lcoCheckFiles() {
}
}
/// <summary>
/// Action <code>CheckFiles</code> that represents the Service Studio action <code>CheckFiles</code>
///  <p> Description: </p>
/// </summary>
public static async Task<string> ActionCheckFiles(IRequestContext requestContext,long inParamRequisitionId,CancellationToken cancellationToken) {
string outParamO_ErrorMessage = default;
lcoCheckFiles result = new lcoCheckFiles();
lcvCheckFiles localVars = new lcvCheckFiles(inParamRequisitionId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("CheckFiles", "e4bc166a-393a-4f90-9a4b-99c08242efaa"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("CheckFiles", "e4bc166a-393a-4f90-9a4b-99c08242efaa", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetRequisitionFilesById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionFilesById_maxRecords = 1;
if (datasetGetRequisitionFilesById_maxRecords < 1) datasetGetRequisitionFilesById_maxRecords = 1;
int datasetGetRequisitionFilesById_startIndex = 0;(localVars.queryResGetRequisitionFilesById_outParamList,localVars.queryResGetRequisitionFilesById_outParamCount) = await FuncActionCheckFiles.datasetGetRequisitionFilesById(requestContext,datasetGetRequisitionFilesById_maxRecords,datasetGetRequisitionFilesById_startIndex,IterationMultiplicity.Never,localVars.inParamRequisitionId,cancellationToken);

// empty?
if((localVars.queryResGetRequisitionFilesById_outParamList.Empty)) {
// RaiseError NoFiles
throw new Ex_NoFilesUserException (AppUtils.GetStringResource("Q3DUFH5N10+_i3rPsA46bw#Message.-46618447.1", "This requisition has no files to download"));

}

} //close CreateActionActivity using block
} // try

catch (Ex_NoFilesUserException ex) {
ApplicationLogger.Error(ex, "Error executing action");
requestContext.LastException = ex;

// Error Handler
await DatabaseAccess.RollbackAllTransactionsAsync(cancellationToken);

// O_ErrorMessage = "This requisition has no files to download"
result.outParamO_ErrorMessage=AppUtils.GetStringResource("gC+p2uEQcE6uvDxmu7j8yw#Value.-46618447.1", "This requisition has no files to download");
goto RETURN_STATEMENT;

} // Catch
finally {
outParamO_ErrorMessage = result.outParamO_ErrorMessage;
cancellationToken.ThrowIfCancellationRequested();
} // inner-finally
RETURN_STATEMENT:
return outParamO_ErrorMessage;
}

public static class FuncActionCheckFiles {

private static async Task<RC_c3feeb794fa34d46adcdce2db9588d18> datasetGetRequisitionFilesByIdReadDbAsync(RC_c3feeb794fa34d46adcdce2db9588d18 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENRequisition.Read( r, ref index);
rec.ssENRequisitionContractFile.Read( r, ref index);
rec.ssENRequisitionFile2.Read( r, ref index);
return rec;
}
// Query Function "GetRequisitionFilesById" MxBqKVuia0e0SS94XtWtGg of Action "CheckFiles"
public static async Task<(RL_8794daf8a03a814b6ca9e26cee0933c6,long)> datasetGetRequisitionFilesById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisition_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("CheckFiles.GetRequisitionFilesById", "296a1033-a25b-476b-b449-2f785ed5ad1a");
using var queryActivity = activitySource.CreateAggregateQueryActivity("CheckFiles.GetRequisitionFilesById", "296a1033-a25b-476b-b449-2f785ed5ad1a", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.aha85Do5kE+aS5nAgkLvqg/NodesNotShownInESpaceTree.MxBqKVuia0e0SS94XtWtGg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74");
fromBuilder.Append(" FROM (({Requisition} \"enrequisition66\" Inner JOIN {RequisitionContractFile} \"enrequisitioncontractfile11\" ON (\"enrequisition66\".\"id\" = \"enrequisitioncontractfile11\".\"requisitionid\"))  Inner JOIN {RequisitionFile2} \"enrequisitionfile29\" ON (\"enrequisitioncontractfile11\".\"requisitionfileid\" = \"enrequisitionfile29\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpreRequisition_Id != 0) {
whereBuilder.Append("((\"enrequisition66\".\"id\" = @qpreRequisition_Id) AND (\"enrequisition66\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisition_Id", DbType.Int64, qpreRequisition_Id);
} else {
whereBuilder.Append("(\"enrequisition66\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (\"enrequisitionfile29\".\"storageid\" IS NOT NULL)");
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
RL_8794daf8a03a814b6ca9e26cee0933c6 outParamList = new RL_8794daf8a03a814b6ca9e26cee0933c6();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetRequisitionFilesByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query CheckFiles.GetRequisitionFilesById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_8794daf8a03a814b6ca9e26cee0933c6 _tmp = new RL_8794daf8a03a814b6ca9e26cee0933c6();
_tmp.AlternateReadDbMethodAsync = datasetGetRequisitionFilesByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query CheckFiles.GetRequisitionFilesById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_8794daf8a03a814b6ca9e26cee0933c6)_tmp;
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
