namespace ssConectaProveedores;

public partial class Actions {
public class lcvDownloadFileWithProposalId : VarsBag {
public long inParami_ProposalId;
public RL_d5919f61ef80d8f84623e1797c2e85cd queryResGetFileById_outParamList = new RL_d5919f61ef80d8f84623e1797c2e85cd();
public long queryResGetFileById_outParamCount = 0L;

public lcvDownloadFileWithProposalId(long inParami_ProposalId) {
this.inParami_ProposalId = inParami_ProposalId;
}
}
public class lcoDownloadFileWithProposalId : VarsBag {
public string outParamo_Filename = "";

public byte[] outParamo_BinaryData = new byte[] {};

public lcoDownloadFileWithProposalId() {
}
}
/// <summary>
/// Action <code>DownloadFileWithProposalId</code> that represents the Service Studio action
///  <code>DownloadFileWithProposalId</code> <p> Description: DownloadFileWithProposalId</p>
/// </summary>
public static async Task<(string,byte[])> ActionDownloadFileWithProposalId(IRequestContext requestContext,long inParami_ProposalId,CancellationToken cancellationToken) {
string outParamo_Filename = default;
byte[] outParamo_BinaryData = default;
lcoDownloadFileWithProposalId result = new lcoDownloadFileWithProposalId();
lcvDownloadFileWithProposalId localVars = new lcvDownloadFileWithProposalId(inParami_ProposalId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("DownloadFileWithProposalId", "957e4549-c87d-4963-a04d-c44a2965032d"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("DownloadFileWithProposalId", "957e4549-c87d-4963-a04d-c44a2965032d", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetFileById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFileById_maxRecords = 1;
if (datasetGetFileById_maxRecords < 1) datasetGetFileById_maxRecords = 1;
int datasetGetFileById_startIndex = 0;(localVars.queryResGetFileById_outParamList,localVars.queryResGetFileById_outParamCount) = await FuncActionDownloadFileWithProposalId.datasetGetFileById(requestContext,datasetGetFileById_maxRecords,datasetGetFileById_startIndex,IterationMultiplicity.Never,localVars.inParami_ProposalId,cancellationToken);

// o_Filename = GetFileById.List.Current.FileExtended.Filename
result.outParamo_Filename=localVars.queryResGetFileById_outParamList.CurrentRec.ssENFileExtended.ssFilename;

// o_BinaryData = GetFileById.List.Current.File3.Binary
result.outParamo_BinaryData=localVars.queryResGetFileById_outParamList.CurrentRec.ssENFile3.ssBinary;
} //close CreateActionActivity using block
} // try

finally {
outParamo_Filename = result.outParamo_Filename;
outParamo_BinaryData = result.outParamo_BinaryData;
} // inner-finally
RETURN_STATEMENT:
return (outParamo_Filename,outParamo_BinaryData);
}

public static class FuncActionDownloadFileWithProposalId {

private static async Task<RC_1ab3ef48680b2ecd9418ca5a547fee53> datasetGetFileByIdReadDbAsync(RC_1ab3ef48680b2ecd9418ca5a547fee53 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFile3.Read( r, ref index);
rec.ssENFileExtended.Read( r, ref index);
rec.ssENProposal.Read( r, ref index);
return rec;
}
// Query Function "GetFileById" p8Hy4fY6IUSbkARkXgngfQ of Action "DownloadFileWithProposalId"
public static async Task<(RL_d5919f61ef80d8f84623e1797c2e85cd,long)> datasetGetFileById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpprProposal_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("DownloadFileWithProposalId.GetFileById", "e1f2c1a7-3af6-4421-9b90-04645e09e07d");
using var queryActivity = activitySource.CreateAggregateQueryActivity("DownloadFileWithProposalId.GetFileById", "e1f2c1a7-3af6-4421-9b90-04645e09e07d", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.SUV+lX3IY0mgTcRKKWUDLQ/NodesNotShownInESpaceTree.p8Hy4fY6IUSbkARkXgngfQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enfile3\".\"binary\" o1, NULL o2, NULL o3, NULL o4, \"enfileextended\".\"filename\" o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28");
fromBuilder.Append(" FROM (({File3} \"enfile3\" Inner JOIN {FileExtended} \"enfileextended\" ON (\"enfile3\".\"id\" = \"enfileextended\".\"id\"))  Inner JOIN {Proposal} \"enproposal5\" ON (\"enfile3\".\"id\" = \"enproposal5\".\"fileid\")) ");
whereBuilder.Append(" WHERE ");
if (qpprProposal_Id != 0) {
whereBuilder.Append("((\"enproposal5\".\"id\" = @qpprProposal_Id) AND (\"enproposal5\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprProposal_Id", DbType.Int64, qpprProposal_Id);
} else {
whereBuilder.Append("(\"enproposal5\".\"id\" IS NULL)");
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
RL_d5919f61ef80d8f84623e1797c2e85cd outParamList = new RL_d5919f61ef80d8f84623e1797c2e85cd();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFileByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, false, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query DownloadFileWithProposalId.GetFileById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_d5919f61ef80d8f84623e1797c2e85cd _tmp = new RL_d5919f61ef80d8f84623e1797c2e85cd();
_tmp.AlternateReadDbMethodAsync = datasetGetFileByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query DownloadFileWithProposalId.GetFileById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_d5919f61ef80d8f84623e1797c2e85cd)_tmp;
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
