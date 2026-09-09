namespace ssConectaProveedores;

public partial class Actions {
public class lcvGetReqApprovalProcess : VarsBag {
public string inParamProcessTypeCode;
public long inParami_RegionId;
public string inParami_Area;
public RL_50f86c7badf933578e482e000d347a03 queryResGetProcessTypeByCode_outParamList = new RL_50f86c7badf933578e482e000d347a03();
public long queryResGetProcessTypeByCode_outParamCount = 0L;

public RL_21d5457a1d34649ed7b58b58f1d048d5 queryResGetApprovalProcessMatrix_outParamList = new RL_21d5457a1d34649ed7b58b58f1d048d5();
public long queryResGetApprovalProcessMatrix_outParamCount = 0L;

public RL_21d5457a1d34649ed7b58b58f1d048d5 queryResGetApprovalProcessMatrix2_outParamList = new RL_21d5457a1d34649ed7b58b58f1d048d5();
public long queryResGetApprovalProcessMatrix2_outParamCount = 0L;

public RL_acd66b694d90eb775616e6c6e3f83477 queryResGetApprovalProcessByProcessTypeCode_outParamList = new RL_acd66b694d90eb775616e6c6e3f83477();
public long queryResGetApprovalProcessByProcessTypeCode_outParamCount = 0L;

public lcvGetReqApprovalProcess(string inParamProcessTypeCode, long inParami_RegionId, string inParami_Area) {
this.inParamProcessTypeCode = inParamProcessTypeCode;
this.inParami_RegionId = inParami_RegionId;
this.inParami_Area = inParami_Area;
}
}
public class lcoGetReqApprovalProcess : VarsBag {
public EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord outParamo_ApprovalProcess = new EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord();

public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public lcoGetReqApprovalProcess() {
}
}
/// <summary>
/// Action <code>GetReqApprovalProcess</code> that represents the Service Studio action
///  <code>GetReqApprovalProcess</code> <p> Description: </p>
/// </summary>
public static async Task<(EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord,ST_046fb53ebbe142526d95e87ef1ae9711Structure)> ActionGetReqApprovalProcess(IRequestContext requestContext,string inParamProcessTypeCode,long inParami_RegionId,string inParami_Area,CancellationToken cancellationToken) {
EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord outParamo_ApprovalProcess = default;
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
lcoGetReqApprovalProcess result = new lcoGetReqApprovalProcess();
lcvGetReqApprovalProcess localVars = new lcvGetReqApprovalProcess(inParamProcessTypeCode, inParami_RegionId, inParami_Area);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GetReqApprovalProcess", "e776cf99-fb19-45ca-8159-32b99b065ccd"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetReqApprovalProcess", "e776cf99-fb19-45ca-8159-32b99b065ccd", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetProcessTypeByCode
cancellationToken.ThrowIfCancellationRequested();
int datasetGetProcessTypeByCode_maxRecords = 1;
if (datasetGetProcessTypeByCode_maxRecords < 1) datasetGetProcessTypeByCode_maxRecords = 1;
int datasetGetProcessTypeByCode_startIndex = 0;(localVars.queryResGetProcessTypeByCode_outParamList,localVars.queryResGetProcessTypeByCode_outParamCount) = await FuncActionGetReqApprovalProcess.datasetGetProcessTypeByCode(requestContext,datasetGetProcessTypeByCode_maxRecords,datasetGetProcessTypeByCode_startIndex,IterationMultiplicity.Never,localVars.inParamProcessTypeCode,cancellationToken);

// Empty
if((localVars.queryResGetProcessTypeByCode_outParamList.Empty)) {
// o_Output
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "Process type not found!"
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("zVwSellJYEmRQKpX1xmKpg#Value.502048673.1", "Process type not found!");
} else {
// Query datasetGetApprovalProcessMatrix
cancellationToken.ThrowIfCancellationRequested();
int datasetGetApprovalProcessMatrix_maxRecords = 1;
if (datasetGetApprovalProcessMatrix_maxRecords < 1) datasetGetApprovalProcessMatrix_maxRecords = 1;
int datasetGetApprovalProcessMatrix_startIndex = 0;(localVars.queryResGetApprovalProcessMatrix_outParamList,localVars.queryResGetApprovalProcessMatrix_outParamCount) = await FuncActionGetReqApprovalProcess.datasetGetApprovalProcessMatrix(requestContext,datasetGetApprovalProcessMatrix_maxRecords,datasetGetApprovalProcessMatrix_startIndex,IterationMultiplicity.Never,localVars.queryResGetProcessTypeByCode_outParamList.CurrentRec.ssENProcessType.ssId,localVars.inParami_Area,localVars.inParami_RegionId,cancellationToken);

// Empty
if((localVars.queryResGetApprovalProcessMatrix_outParamList.Empty)) {
// Query datasetGetApprovalProcessMatrix2
cancellationToken.ThrowIfCancellationRequested();
int datasetGetApprovalProcessMatrix2_maxRecords = 1;
if (datasetGetApprovalProcessMatrix2_maxRecords < 1) datasetGetApprovalProcessMatrix2_maxRecords = 1;
int datasetGetApprovalProcessMatrix2_startIndex = 0;(localVars.queryResGetApprovalProcessMatrix2_outParamList,localVars.queryResGetApprovalProcessMatrix2_outParamCount) = await FuncActionGetReqApprovalProcess.datasetGetApprovalProcessMatrix2(requestContext,datasetGetApprovalProcessMatrix2_maxRecords,datasetGetApprovalProcessMatrix2_startIndex,IterationMultiplicity.Never,localVars.queryResGetProcessTypeByCode_outParamList.CurrentRec.ssENProcessType.ssId,localVars.inParami_RegionId,cancellationToken);

// Empty
if((localVars.queryResGetApprovalProcessMatrix2_outParamList.Empty)) {
// Query datasetGetApprovalProcessByProcessTypeCode
cancellationToken.ThrowIfCancellationRequested();
int datasetGetApprovalProcessByProcessTypeCode_maxRecords = 1;
if (datasetGetApprovalProcessByProcessTypeCode_maxRecords < 1) datasetGetApprovalProcessByProcessTypeCode_maxRecords = 1;
int datasetGetApprovalProcessByProcessTypeCode_startIndex = 0;(localVars.queryResGetApprovalProcessByProcessTypeCode_outParamList,localVars.queryResGetApprovalProcessByProcessTypeCode_outParamCount) = await FuncActionGetReqApprovalProcess.datasetGetApprovalProcessByProcessTypeCode(requestContext,datasetGetApprovalProcessByProcessTypeCode_maxRecords,datasetGetApprovalProcessByProcessTypeCode_startIndex,IterationMultiplicity.Never,localVars.inParamProcessTypeCode,cancellationToken);

// Empty
if((localVars.queryResGetApprovalProcessByProcessTypeCode_outParamList.Empty)) {
// o_Output
// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;

// o_Output.Message = "No approval workflow defined or configured for this scenario!"
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("YkxEAvymqUGyDsK58KWP_Q#Value.9822949.1", "No approval workflow defined or configured for this scenario!");
} else {
// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;

// o_ApprovalProcess = GetApprovalProcessByProcessTypeCode.List.Current.ApprovalProcess
result.outParamo_ApprovalProcess=localVars.queryResGetApprovalProcessByProcessTypeCode_outParamList.CurrentRec.ssENApprovalProcess;
}

} else {
// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;

// o_ApprovalProcess = GetApprovalProcessMatrix2.List.Current.ApprovalProcess
result.outParamo_ApprovalProcess=localVars.queryResGetApprovalProcessMatrix2_outParamList.CurrentRec.ssENApprovalProcess;
}

} else {
// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;

// o_ApprovalProcess = GetApprovalProcessMatrix.List.Current.ApprovalProcess
result.outParamo_ApprovalProcess=localVars.queryResGetApprovalProcessMatrix_outParamList.CurrentRec.ssENApprovalProcess;
}

}

} //close CreateActionActivity using block
} // try

finally {
outParamo_ApprovalProcess = result.outParamo_ApprovalProcess;
outParamo_Output = result.outParamo_Output;
} // inner-finally
RETURN_STATEMENT:
return (outParamo_ApprovalProcess,outParamo_Output);
}

public static class FuncActionGetReqApprovalProcess {

// Query Function "GetProcessTypeByCode" BnMRNFfglUuAHhHQwWcQzA of Action "GetReqApprovalProcess"
public static async Task<(RL_50f86c7badf933578e482e000d347a03,long)> datasetGetProcessTypeByCode(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteCode,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetReqApprovalProcess.GetProcessTypeByCode", "34117306-e057-4b95-801e-11d0c16710cc");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetReqApprovalProcess.GetProcessTypeByCode", "34117306-e057-4b95-801e-11d0c16710cc", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.mc925xn7ykWBWTK5mwZczQ/NodesNotShownInESpaceTree.BnMRNFfglUuAHhHQwWcQzA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enprocesstype10\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4");
fromBuilder.Append(" FROM {ProcessType} \"enprocesstype10\"");
whereBuilder.Append(" WHERE (\"enprocesstype10\".\"is_active\" = 1) AND (\"enprocesstype10\".\"code\" = @qpteCode)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetReqApprovalProcess.GetProcessTypeByCode.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetReqApprovalProcess.GetProcessTypeByCode.List", cancellationToken: cancellationToken);
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

private static async Task<RC_01911a773916dfcf99bb546f23183cea> datasetGetApprovalProcessMatrixReadDbAsync(RC_01911a773916dfcf99bb546f23183cea rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApprovalProcess.Read( r, ref index);
rec.ssENApprovalProcessMatrix.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
return rec;
}
// Query Function "GetApprovalProcessMatrix" 2zrDXZBLrUqyggKTbQxTXw of Action "GetReqApprovalProcess"
public static async Task<(RL_21d5457a1d34649ed7b58b58f1d048d5,long)> datasetGetApprovalProcessMatrix(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpprApprovalProcessMatrix_ProcessTypeId,string qpteApprovalProcessMatrix_Area,long qpreRegion_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetReqApprovalProcess.GetApprovalProcessMatrix", "5dc33adb-4b90-4aad-b282-02936d0c535f");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetReqApprovalProcess.GetApprovalProcessMatrix", "5dc33adb-4b90-4aad-b282-02936d0c535f", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.mc925xn7ykWBWTK5mwZczQ/NodesNotShownInESpaceTree.2zrDXZBLrUqyggKTbQxTXw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enapprovalprocess33\".\"id\" o0, \"enapprovalprocess33\".\"processtypeid\" o1, \"enapprovalprocess33\".\"specialworkflowid\" o2, \"enapprovalprocess33\".\"approvalprocesstypeid\" o3, \"enapprovalprocess33\".\"regionid\" o4, \"enapprovalprocess33\".\"accountingregionid\" o5, \"enapprovalprocess33\".\"group\" o6, \"enapprovalprocess33\".\"code\" o7, \"enapprovalprocess33\".\"version\" o8, \"enapprovalprocess33\".\"description\" o9, \"enapprovalprocess33\".\"isactive\" o10, \"enapprovalprocess33\".\"isspecial\" o11, \"enapprovalprocess33\".\"isdonation\" o12, \"enapprovalprocess33\".\"iscxpcorporativo_deprec\" o13, \"enapprovalprocess33\".\"createdby\" o14, \"enapprovalprocess33\".\"createdon\" o15, \"enapprovalprocess33\".\"updatedby\" o16, \"enapprovalprocess33\".\"updatedon\" o17, \"enapprovalprocess33\".\"isselectfirstapprover\" o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43");
fromBuilder.Append(" FROM (({ApprovalProcessMatrix} \"enapprovalprocessmatrix3\" Left JOIN {Region} \"enregion56\" ON (\"enapprovalprocessmatrix3\".\"region\" = \"enregion56\".\"commissionregion\"))  Inner JOIN {ApprovalProcess} \"enapprovalprocess33\" ON (\"enapprovalprocessmatrix3\".\"approvalprocessid\" = \"enapprovalprocess33\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpprApprovalProcessMatrix_ProcessTypeId != 0) {
whereBuilder.Append("((\"enapprovalprocessmatrix3\".\"processtypeid\" = @qpprApprovalProcessMatrix_ProcessTypeId) AND (\"enapprovalprocessmatrix3\".\"processtypeid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprApprovalProcessMatrix_ProcessTypeId", DbType.Int64, qpprApprovalProcessMatrix_ProcessTypeId);
} else {
whereBuilder.Append("(\"enapprovalprocessmatrix3\".\"processtypeid\" IS NULL)");
}
whereBuilder.Append(" AND ((CASE WHEN (@qpreRegion_Id <> 0) THEN (CASE WHEN ");
sqlCmd.CreateParameterWithoutReplacements("@qpreRegion_Id", DbType.Int64, qpreRegion_Id);
if (qpreRegion_Id != 0) {
whereBuilder.Append("((\"enregion56\".\"id\" = @qpreRegion_Id) AND (\"enregion56\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRegion_Id", DbType.Int64, qpreRegion_Id);
} else {
whereBuilder.Append("(\"enregion56\".\"id\" IS NULL)");
}
whereBuilder.Append(" THEN 1 ELSE 0 END) ELSE 1 END) = 1) AND ((CASE WHEN (@qpteApprovalProcessMatrix_Area <> '') THEN (CASE WHEN (\"enapprovalprocessmatrix3\".\"area\" = @qpteApprovalProcessMatrix_Area) THEN 1 ELSE 0 END) ELSE 1 END) = 1)");
orderByBuilder.Append(" ORDER BY \"enapprovalprocessmatrix3\".\"region\" ASC ");
sqlCmd.CreateParameterWithoutReplacements("@qpteApprovalProcessMatrix_Area", DbType.String, qpteApprovalProcessMatrix_Area);
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
RL_21d5457a1d34649ed7b58b58f1d048d5 outParamList = new RL_21d5457a1d34649ed7b58b58f1d048d5();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetApprovalProcessMatrixReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetReqApprovalProcess.GetApprovalProcessMatrix.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_21d5457a1d34649ed7b58b58f1d048d5 _tmp = new RL_21d5457a1d34649ed7b58b58f1d048d5();
_tmp.AlternateReadDbMethodAsync = datasetGetApprovalProcessMatrixReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetReqApprovalProcess.GetApprovalProcessMatrix.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_21d5457a1d34649ed7b58b58f1d048d5)_tmp;
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

private static async Task<RC_01911a773916dfcf99bb546f23183cea> datasetGetApprovalProcessMatrix2ReadDbAsync(RC_01911a773916dfcf99bb546f23183cea rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApprovalProcess.Read( r, ref index);
rec.ssENApprovalProcessMatrix.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
return rec;
}
// Query Function "GetApprovalProcessMatrix2" yWcGdmXlnEq+PUYvMRlGxA of Action "GetReqApprovalProcess"
public static async Task<(RL_21d5457a1d34649ed7b58b58f1d048d5,long)> datasetGetApprovalProcessMatrix2(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpprApprovalProcessMatrix_ProcessTypeId,long qpreRegion_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetReqApprovalProcess.GetApprovalProcessMatrix2", "760667c9-e565-4a9c-be3d-462f311946c4");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetReqApprovalProcess.GetApprovalProcessMatrix2", "760667c9-e565-4a9c-be3d-462f311946c4", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.mc925xn7ykWBWTK5mwZczQ/NodesNotShownInESpaceTree.yWcGdmXlnEq+PUYvMRlGxA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enapprovalprocess34\".\"id\" o0, \"enapprovalprocess34\".\"processtypeid\" o1, \"enapprovalprocess34\".\"specialworkflowid\" o2, \"enapprovalprocess34\".\"approvalprocesstypeid\" o3, \"enapprovalprocess34\".\"regionid\" o4, \"enapprovalprocess34\".\"accountingregionid\" o5, \"enapprovalprocess34\".\"group\" o6, \"enapprovalprocess34\".\"code\" o7, \"enapprovalprocess34\".\"version\" o8, \"enapprovalprocess34\".\"description\" o9, \"enapprovalprocess34\".\"isactive\" o10, \"enapprovalprocess34\".\"isspecial\" o11, \"enapprovalprocess34\".\"isdonation\" o12, \"enapprovalprocess34\".\"iscxpcorporativo_deprec\" o13, \"enapprovalprocess34\".\"createdby\" o14, \"enapprovalprocess34\".\"createdon\" o15, \"enapprovalprocess34\".\"updatedby\" o16, \"enapprovalprocess34\".\"updatedon\" o17, \"enapprovalprocess34\".\"isselectfirstapprover\" o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43");
fromBuilder.Append(" FROM (({ApprovalProcessMatrix} \"enapprovalprocessmatrix4\" Left JOIN {Region} \"enregion57\" ON (\"enapprovalprocessmatrix4\".\"region\" = \"enregion57\".\"commissionregion\"))  Inner JOIN {ApprovalProcess} \"enapprovalprocess34\" ON (\"enapprovalprocessmatrix4\".\"approvalprocessid\" = \"enapprovalprocess34\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpprApprovalProcessMatrix_ProcessTypeId != 0) {
whereBuilder.Append("((\"enapprovalprocessmatrix4\".\"processtypeid\" = @qpprApprovalProcessMatrix_ProcessTypeId) AND (\"enapprovalprocessmatrix4\".\"processtypeid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprApprovalProcessMatrix_ProcessTypeId", DbType.Int64, qpprApprovalProcessMatrix_ProcessTypeId);
} else {
whereBuilder.Append("(\"enapprovalprocessmatrix4\".\"processtypeid\" IS NULL)");
}
whereBuilder.Append(" AND ((CASE WHEN (@qpreRegion_Id <> 0) THEN (CASE WHEN ");
sqlCmd.CreateParameterWithoutReplacements("@qpreRegion_Id", DbType.Int64, qpreRegion_Id);
if (qpreRegion_Id != 0) {
whereBuilder.Append("((\"enregion57\".\"id\" = @qpreRegion_Id) AND (\"enregion57\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRegion_Id", DbType.Int64, qpreRegion_Id);
} else {
whereBuilder.Append("(\"enregion57\".\"id\" IS NULL)");
}
whereBuilder.Append(" THEN 1 ELSE 0 END) ELSE 1 END) = 1)");
orderByBuilder.Append(" ORDER BY \"enapprovalprocessmatrix4\".\"region\" ASC ");
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
RL_21d5457a1d34649ed7b58b58f1d048d5 outParamList = new RL_21d5457a1d34649ed7b58b58f1d048d5();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetApprovalProcessMatrix2ReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetReqApprovalProcess.GetApprovalProcessMatrix2.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_21d5457a1d34649ed7b58b58f1d048d5 _tmp = new RL_21d5457a1d34649ed7b58b58f1d048d5();
_tmp.AlternateReadDbMethodAsync = datasetGetApprovalProcessMatrix2ReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetReqApprovalProcess.GetApprovalProcessMatrix2.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_21d5457a1d34649ed7b58b58f1d048d5)_tmp;
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

private static async Task<RC_9c2c2f8777df5db915ea9753325ce8dd> datasetGetApprovalProcessByProcessTypeCodeReadDbAsync(RC_9c2c2f8777df5db915ea9753325ce8dd rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApprovalProcess.Read( r, ref index);
rec.ssENProcessType.Read( r, ref index);
return rec;
}
// Query Function "GetApprovalProcessByProcessTypeCode" AoapihnfjUOAO5_BsKPvJg of Action "GetReqApprovalProcess"
public static async Task<(RL_acd66b694d90eb775616e6c6e3f83477,long)> datasetGetApprovalProcessByProcessTypeCode(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteProcessType_Code,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetReqApprovalProcess.GetApprovalProcessByProcessTypeCode", "8aa98602-df19-438d-803b-9fc1b0a3ef26");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetReqApprovalProcess.GetApprovalProcessByProcessTypeCode", "8aa98602-df19-438d-803b-9fc1b0a3ef26", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.mc925xn7ykWBWTK5mwZczQ/NodesNotShownInESpaceTree.AoapihnfjUOAO5_BsKPvJg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enapprovalprocess35\".\"id\" o0, \"enapprovalprocess35\".\"processtypeid\" o1, \"enapprovalprocess35\".\"specialworkflowid\" o2, \"enapprovalprocess35\".\"approvalprocesstypeid\" o3, \"enapprovalprocess35\".\"regionid\" o4, \"enapprovalprocess35\".\"accountingregionid\" o5, \"enapprovalprocess35\".\"group\" o6, \"enapprovalprocess35\".\"code\" o7, \"enapprovalprocess35\".\"version\" o8, \"enapprovalprocess35\".\"description\" o9, \"enapprovalprocess35\".\"isactive\" o10, \"enapprovalprocess35\".\"isspecial\" o11, \"enapprovalprocess35\".\"isdonation\" o12, \"enapprovalprocess35\".\"iscxpcorporativo_deprec\" o13, \"enapprovalprocess35\".\"createdby\" o14, \"enapprovalprocess35\".\"createdon\" o15, \"enapprovalprocess35\".\"updatedby\" o16, \"enapprovalprocess35\".\"updatedon\" o17, \"enapprovalprocess35\".\"isselectfirstapprover\" o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23");
fromBuilder.Append(" FROM ({ApprovalProcess} \"enapprovalprocess35\" Inner JOIN {ProcessType} \"enprocesstype11\" ON (\"enapprovalprocess35\".\"processtypeid\" = \"enprocesstype11\".\"id\")) ");
whereBuilder.Append(" WHERE (\"enprocesstype11\".\"code\" = @qpteProcessType_Code) AND (\"enapprovalprocess35\".\"isactive\" = 1)");
sqlCmd.CreateParameterWithoutReplacements("@qpteProcessType_Code", DbType.String, qpteProcessType_Code);
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
RL_acd66b694d90eb775616e6c6e3f83477 outParamList = new RL_acd66b694d90eb775616e6c6e3f83477();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetApprovalProcessByProcessTypeCodeReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetReqApprovalProcess.GetApprovalProcessByProcessTypeCode.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_acd66b694d90eb775616e6c6e3f83477 _tmp = new RL_acd66b694d90eb775616e6c6e3f83477();
_tmp.AlternateReadDbMethodAsync = datasetGetApprovalProcessByProcessTypeCodeReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetReqApprovalProcess.GetApprovalProcessByProcessTypeCode.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_acd66b694d90eb775616e6c6e3f83477)_tmp;
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
