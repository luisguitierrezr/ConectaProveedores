namespace ssConectaProveedores;

public partial class Actions {
public class lcvInitFolioWF_FromApprovProcId : VarsBag {
public long inParami_FolioId;
public long inParami_ApprovalProcessId;
public int inParami_ApprovalProcessTypeId;
public string inParami_ProcessTypeCode;
/// <summary>
/// Variable <code>l_FolioApprovalLevelsList</code> that represents the Service Studio
///  FolioApprovalLevelList <code>l_FolioApprovalLevelsList</code> <p>Description: </p>
/// </summary>
public RL_4391d3239f28e5f33772aaade6de0b0d varLcl_FolioApprovalLevelsList = new RL_4391d3239f28e5f33772aaade6de0b0d();

/// <summary>
/// Variable <code>l_FolioApproval</code> that represents the Service Studio FolioApproval
///  <code>l_FolioApproval</code> <p>Description: FolioApproval</p>
/// </summary>
public EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord varLcl_FolioApproval = new EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord();

/// <summary>
/// Variable <code>l_ApprovalProcess</code> that represents the Service Studio ApprovalProcess
///  <code>l_ApprovalProcess</code> <p>Description: ApprovalProcess</p>
/// </summary>
public EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord varLcl_ApprovalProcess = new EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord();

public RL_ae429f8c6a2bb90441c9fdf2cffe0a0b queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList = new RL_ae429f8c6a2bb90441c9fdf2cffe0a0b();
public long queryResGetApprovalProcessLevelsByApprovalProcessId_outParamCount = 0L;

public RL_50f86c7badf933578e482e000d347a03 queryResGetProcessTypeByCode_outParamList = new RL_50f86c7badf933578e482e000d347a03();
public long queryResGetProcessTypeByCode_outParamCount = 0L;

public RL_5e0ca6ca9da3af4b1d8149758c39c2cf queryResGetApprovalProcessById_outParamList = new RL_5e0ca6ca9da3af4b1d8149758c39c2cf();
public long queryResGetApprovalProcessById_outParamCount = 0L;

public Actions.lcoFolioApprovalCreateOrUpdate resFolioApprovalCreateOrUpdate =  new Actions.lcoFolioApprovalCreateOrUpdate();
public RL_5e0ca6ca9da3af4b1d8149758c39c2cf queryResGetApprovalProcessByApprovalProcessTypeId_outParamList = new RL_5e0ca6ca9da3af4b1d8149758c39c2cf();
public long queryResGetApprovalProcessByApprovalProcessTypeId_outParamCount = 0L;

public lcvInitFolioWF_FromApprovProcId(long inParami_FolioId, long inParami_ApprovalProcessId, int inParami_ApprovalProcessTypeId, string inParami_ProcessTypeCode) {
this.inParami_FolioId = inParami_FolioId;
this.inParami_ApprovalProcessId = inParami_ApprovalProcessId;
this.inParami_ApprovalProcessTypeId = inParami_ApprovalProcessTypeId;
this.inParami_ProcessTypeCode = inParami_ProcessTypeCode;
}
}
public class lcoInitFolioWF_FromApprovProcId : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public lcoInitFolioWF_FromApprovProcId() {
}
}
/// <summary>
/// Action <code>InitFolioWF_FromApprovProcId</code> that represents the Service Studio action
///  <code>InitFolioWF_FromApprovProcId</code> <p> Description: </p>
/// </summary>
public static async Task<ST_046fb53ebbe142526d95e87ef1ae9711Structure> ActionInitFolioWF_FromApprovProcId(IRequestContext requestContext,long inParami_FolioId,long inParami_ApprovalProcessId,int inParami_ApprovalProcessTypeId,string inParami_ProcessTypeCode,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
lcoInitFolioWF_FromApprovProcId result = new lcoInitFolioWF_FromApprovProcId();
lcvInitFolioWF_FromApprovProcId localVars = new lcvInitFolioWF_FromApprovProcId(inParami_FolioId, inParami_ApprovalProcessId, inParami_ApprovalProcessTypeId, inParami_ProcessTypeCode);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InitFolioWF_FromApprovProcId", "13a96a3c-dac2-4786-997d-ed9ac75d4c1e"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InitFolioWF_FromApprovProcId", "13a96a3c-dac2-4786-997d-ed9ac75d4c1e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetProcessTypeByCode
cancellationToken.ThrowIfCancellationRequested();
int datasetGetProcessTypeByCode_maxRecords = 1;
if (datasetGetProcessTypeByCode_maxRecords < 1) datasetGetProcessTypeByCode_maxRecords = 1;
int datasetGetProcessTypeByCode_startIndex = 0;(localVars.queryResGetProcessTypeByCode_outParamList,localVars.queryResGetProcessTypeByCode_outParamCount) = await FuncActionInitFolioWF_FromApprovProcId.datasetGetProcessTypeByCode(requestContext,datasetGetProcessTypeByCode_maxRecords,datasetGetProcessTypeByCode_startIndex,IterationMultiplicity.Never,localVars.inParami_ProcessTypeCode,cancellationToken);

// Empty
if((localVars.queryResGetProcessTypeByCode_outParamList.Empty)) {
// o_Output
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "Process type not found!"
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("ew529cxRx06VHrCvwOzhfw#Value.502048673.1", "Process type not found!");
} else {
if(((localVars.inParami_ApprovalProcessId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// Query datasetGetApprovalProcessByApprovalProcessTypeId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetApprovalProcessByApprovalProcessTypeId_maxRecords = 1;
if (datasetGetApprovalProcessByApprovalProcessTypeId_maxRecords < 1) datasetGetApprovalProcessByApprovalProcessTypeId_maxRecords = 1;
int datasetGetApprovalProcessByApprovalProcessTypeId_startIndex = 0;(localVars.queryResGetApprovalProcessByApprovalProcessTypeId_outParamList,localVars.queryResGetApprovalProcessByApprovalProcessTypeId_outParamCount) = await FuncActionInitFolioWF_FromApprovProcId.datasetGetApprovalProcessByApprovalProcessTypeId(requestContext,datasetGetApprovalProcessByApprovalProcessTypeId_maxRecords,datasetGetApprovalProcessByApprovalProcessTypeId_startIndex,IterationMultiplicity.Never,localVars.queryResGetProcessTypeByCode_outParamList.CurrentRec.ssENProcessType.ssId,localVars.inParami_ApprovalProcessTypeId,cancellationToken);

// Not found?
if((localVars.queryResGetApprovalProcessByApprovalProcessTypeId_outParamList.Empty)) {
// o_Output
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "Approval workflow not found!"
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("TkHXO8rVw0GmU+1589P8LQ#Value.-108209008.1", "Approval workflow not found!");
goto RETURN_STATEMENT;

} else {
// l_ApprovalProcess = GetApprovalProcessByApprovalProcessTypeId.List.Current.ApprovalProcess
localVars.varLcl_ApprovalProcess=localVars.queryResGetApprovalProcessByApprovalProcessTypeId_outParamList.CurrentRec.ssENApprovalProcess;
}

} else {
// Query datasetGetApprovalProcessById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetApprovalProcessById_maxRecords = 1;
if (datasetGetApprovalProcessById_maxRecords < 1) datasetGetApprovalProcessById_maxRecords = 1;
int datasetGetApprovalProcessById_startIndex = 0;(localVars.queryResGetApprovalProcessById_outParamList,localVars.queryResGetApprovalProcessById_outParamCount) = await FuncActionInitFolioWF_FromApprovProcId.datasetGetApprovalProcessById(requestContext,datasetGetApprovalProcessById_maxRecords,datasetGetApprovalProcessById_startIndex,IterationMultiplicity.Never,localVars.inParami_ApprovalProcessId,cancellationToken);

// Not found?
if((localVars.queryResGetApprovalProcessById_outParamList.Empty)) {
// o_Output
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "Approval workflow selected not found!"
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("IKfnExf0Fk6GtlnIh2z1cA#Value.-386675667.1", "Approval workflow selected not found!");
goto RETURN_STATEMENT;

} else {
// l_ApprovalProcess = GetApprovalProcessById.List.Current.ApprovalProcess
localVars.varLcl_ApprovalProcess=localVars.queryResGetApprovalProcessById_outParamList.CurrentRec.ssENApprovalProcess;
}

}

// Query datasetGetApprovalProcessLevelsByApprovalProcessId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetApprovalProcessLevelsByApprovalProcessId_maxRecords = 0;
int datasetGetApprovalProcessLevelsByApprovalProcessId_startIndex = 0;(localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList,localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamCount) = await FuncActionInitFolioWF_FromApprovProcId.datasetGetApprovalProcessLevelsByApprovalProcessId(requestContext,datasetGetApprovalProcessLevelsByApprovalProcessId_maxRecords,datasetGetApprovalProcessLevelsByApprovalProcessId_startIndex,IterationMultiplicity.Single,localVars.varLcl_ApprovalProcess.ssId,cancellationToken);

// l_FolioApproval
// l_FolioApproval.Id = NullIdentifier
localVars.varLcl_FolioApproval.ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ());

// l_FolioApproval.FolioId = i_FolioId
localVars.varLcl_FolioApproval.ssFolioId = localVars.inParami_FolioId;

// l_FolioApproval.ProcessTypeCode = GetProcessTypeByCode.List.Current.ProcessType.Code
localVars.varLcl_FolioApproval.ssProcessTypeCode = localVars.queryResGetProcessTypeByCode_outParamList.CurrentRec.ssENProcessType.ssCode;

// l_FolioApproval.ApprovalProcessVersion = l_ApprovalProcess.Version
localVars.varLcl_FolioApproval.ssApprovalProcessVersion = Convert.ToString(localVars.varLcl_ApprovalProcess.ssVersion);

// l_FolioApproval.CurrentLevel = 1
localVars.varLcl_FolioApproval.ssCurrentLevel = 1;

// l_FolioApproval.StartedOn = CurrDateTime
localVars.varLcl_FolioApproval.ssStartedOn = BuiltInFunction.CurrDateTime ();

// l_FolioApproval.ApprovalProcessId = l_ApprovalProcess.Id
localVars.varLcl_FolioApproval.ssApprovalProcessId = localVars.varLcl_ApprovalProcess.ssId;

// l_FolioApproval.RegionId = If
localVars.varLcl_FolioApproval.ssRegionId = (((localVars.varLcl_ApprovalProcess.ssRegionId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ()))) ? (localVars.varLcl_ApprovalProcess.ssRegionId) : (Convert.ToInt64(BuiltInFunction.NullIdentifier ())));
// FolioApprovalCreateOrUpdate
localVars.resFolioApprovalCreateOrUpdate.outParamId = await Actions.ActionFolioApprovalCreateOrUpdate(requestContext,localVars.varLcl_FolioApproval,cancellationToken);

// Foreach GetApprovalProcessLevelsByApprovalProcessId.List
localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.StartIteration();
try {while (!((localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.Eof))) {
// ListAppend
await ExtendedActions.ListAppend(requestContext,localVars.varLcl_FolioApprovalLevelsList,new EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssFolioApprovalId = localVars.resFolioApprovalCreateOrUpdate.outParamId, ssLevelNumber = localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.CurrentRec.ssENApprovalProcessLevel.ssLevelNumber, ssApplicationRoleId = localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.CurrentRec.ssENApprovalProcessLevel.ssApplicationRoleId, ssEntraJobTitle = localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.CurrentRec.ssENEntraRole.ssRoleName, ssEntraRoleId = localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.CurrentRec.ssENApprovalProcessLevel.ssEntraRoleId, ssDepartmentId = localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.CurrentRec.ssENApprovalProcessLevel.ssDepartmentId, ssApprovalStatusId = (((localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.CurrentRec.ssENApprovalProcessLevel.ssLevelNumber==1)) ? ((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId) : ((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("fEmjvBqEH0eHrf5_YVeo0g"))).ssId)) },cancellationToken);

localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.Advance();
}

} finally {
localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.EndIteration();
}

// CreateOrUpdateSomeFolioApprovalLevel
await ExtendedActions.CreateOrUpdateSomeFolioApprovalLevel(requestContext,(await RL_ecaf6a267327a661b83be973ba99d46b.ConvertAsync(localVars.varLcl_FolioApprovalLevelsList, new RL_ecaf6a267327a661b83be973ba99d46b(), async (EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord source, RC_0be8bae4cc285c0288822b663818cb6c target, CancellationToken cancellationToken) => {
target = source;
return target;
}, cancellationToken)),cancellationToken);

// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
}

} //close CreateActionActivity using block
} // try

finally {
outParamo_Output = result.outParamo_Output;
} // inner-finally
RETURN_STATEMENT:
return outParamo_Output;
}

public static class FuncActionInitFolioWF_FromApprovProcId {

private static async Task<RC_06974d55bca345bb983c839ad25aa487> datasetGetApprovalProcessLevelsByApprovalProcessIdReadDbAsync(RC_06974d55bca345bb983c839ad25aa487 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApprovalProcessLevel.Read( r, ref index);
rec.ssENEntraRole.Read( r, ref index);
return rec;
}
// Query Function "GetApprovalProcessLevelsByApprovalProcessId" FwvtDgYPMUqCloptr6nMRw of Action "InitFolioWF_FromApprovProcId"
public static async Task<(RL_ae429f8c6a2bb90441c9fdf2cffe0a0b,long)> datasetGetApprovalProcessLevelsByApprovalProcessId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpapApprovalProcessLevel_ApprovalProcessId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InitFolioWF_FromApprovProcId.GetApprovalProcessLevelsByApprovalProcessId", "0eed0b17-0f06-4a31-8296-8a6dafa9cc47");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InitFolioWF_FromApprovProcId.GetApprovalProcessLevelsByApprovalProcessId", "0eed0b17-0f06-4a31-8296-8a6dafa9cc47", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.PGqpE8LahkeZfe2ax11MHg/NodesNotShownInESpaceTree.FwvtDgYPMUqCloptr6nMRw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"enapprovalprocesslevel\".\"levelnumber\" o2, \"enapprovalprocesslevel\".\"applicationroleid\" o3, NULL o4, NULL o5, NULL o6, \"enapprovalprocesslevel\".\"entraroleid\" o7, \"enapprovalprocesslevel\".\"departmentid\" o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, \"enentrarole2\".\"rolename\" o27, NULL o28, NULL o29, NULL o30, NULL o31");
fromBuilder.Append(" FROM ({ApprovalProcessLevel} \"enapprovalprocesslevel\" Left JOIN {EntraRole} \"enentrarole2\" ON (\"enapprovalprocesslevel\".\"entraroleid\" = \"enentrarole2\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpapApprovalProcessLevel_ApprovalProcessId != 0) {
whereBuilder.Append("((\"enapprovalprocesslevel\".\"approvalprocessid\" = @qpapApprovalProcessLevel_ApprovalProcessId) AND (\"enapprovalprocesslevel\".\"approvalprocessid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpapApprovalProcessLevel_ApprovalProcessId", DbType.Int64, qpapApprovalProcessLevel_ApprovalProcessId);
} else {
whereBuilder.Append("(\"enapprovalprocesslevel\".\"approvalprocessid\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"enapprovalprocesslevel\".\"levelnumber\" ASC ");
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
RL_ae429f8c6a2bb90441c9fdf2cffe0a0b outParamList = new RL_ae429f8c6a2bb90441c9fdf2cffe0a0b();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetApprovalProcessLevelsByApprovalProcessIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, false, false, true, true, true, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InitFolioWF_FromApprovProcId.GetApprovalProcessLevelsByApprovalProcessId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_ae429f8c6a2bb90441c9fdf2cffe0a0b _tmp = new RL_ae429f8c6a2bb90441c9fdf2cffe0a0b();
_tmp.AlternateReadDbMethodAsync = datasetGetApprovalProcessLevelsByApprovalProcessIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InitFolioWF_FromApprovProcId.GetApprovalProcessLevelsByApprovalProcessId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_ae429f8c6a2bb90441c9fdf2cffe0a0b)_tmp;
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

// Query Function "GetProcessTypeByCode" lOfHE9gnQE2lUK_5Gqujww of Action "InitFolioWF_FromApprovProcId"
public static async Task<(RL_50f86c7badf933578e482e000d347a03,long)> datasetGetProcessTypeByCode(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteCode,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InitFolioWF_FromApprovProcId.GetProcessTypeByCode", "13c7e794-27d8-4d40-a550-aff91aaba3c3");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InitFolioWF_FromApprovProcId.GetProcessTypeByCode", "13c7e794-27d8-4d40-a550-aff91aaba3c3", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.PGqpE8LahkeZfe2ax11MHg/NodesNotShownInESpaceTree.lOfHE9gnQE2lUK_5Gqujww, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enprocesstype\".\"id\" o0, \"enprocesstype\".\"code\" o1, NULL o2, NULL o3, NULL o4");
fromBuilder.Append(" FROM {ProcessType} \"enprocesstype\"");
whereBuilder.Append(" WHERE (\"enprocesstype\".\"is_active\" = 1) AND (\"enprocesstype\".\"code\" = @qpteCode)");
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
opt[0] = new BitArray(new bool[] {false, false, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InitFolioWF_FromApprovProcId.GetProcessTypeByCode.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InitFolioWF_FromApprovProcId.GetProcessTypeByCode.List", cancellationToken: cancellationToken);
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

// Query Function "GetApprovalProcessById" itvpUQexSEeiz466k6T__A of Action "InitFolioWF_FromApprovProcId"
public static async Task<(RL_5e0ca6ca9da3af4b1d8149758c39c2cf,long)> datasetGetApprovalProcessById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpapId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InitFolioWF_FromApprovProcId.GetApprovalProcessById", "51e9db8a-b107-4748-a2cf-8eba93a4fffc");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InitFolioWF_FromApprovProcId.GetApprovalProcessById", "51e9db8a-b107-4748-a2cf-8eba93a4fffc", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.PGqpE8LahkeZfe2ax11MHg/NodesNotShownInESpaceTree.itvpUQexSEeiz466k6T__A, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enapprovalprocess\".\"id\" o0, NULL o1, NULL o2, NULL o3, \"enapprovalprocess\".\"regionid\" o4, NULL o5, NULL o6, NULL o7, \"enapprovalprocess\".\"version\" o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18");
fromBuilder.Append(" FROM {ApprovalProcess} \"enapprovalprocess\"");
whereBuilder.Append(" WHERE ");
if (qpapId != 0) {
whereBuilder.Append("((\"enapprovalprocess\".\"id\" = @qpapId) AND (\"enapprovalprocess\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpapId", DbType.Int64, qpapId);
} else {
whereBuilder.Append("(\"enapprovalprocess\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (\"enapprovalprocess\".\"isactive\" = 1)");
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
RL_5e0ca6ca9da3af4b1d8149758c39c2cf outParamList = new RL_5e0ca6ca9da3af4b1d8149758c39c2cf();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, false, true, true, true, false, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InitFolioWF_FromApprovProcId.GetApprovalProcessById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_5e0ca6ca9da3af4b1d8149758c39c2cf _tmp = new RL_5e0ca6ca9da3af4b1d8149758c39c2cf();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InitFolioWF_FromApprovProcId.GetApprovalProcessById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_5e0ca6ca9da3af4b1d8149758c39c2cf)_tmp;
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

// Query Function "GetApprovalProcessByApprovalProcessTypeId" Uczm2ty2wUirt2+BsS1q1Q of Action "InitFolioWF_FromApprovProcId"
public static async Task<(RL_5e0ca6ca9da3af4b1d8149758c39c2cf,long)> datasetGetApprovalProcessByApprovalProcessTypeId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpprProcessTypeId,int qpapApprovalProcessTypeId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InitFolioWF_FromApprovProcId.GetApprovalProcessByApprovalProcessTypeId", "dae6cc51-b6dc-48c1-abb7-6f81b12d6ad5");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InitFolioWF_FromApprovProcId.GetApprovalProcessByApprovalProcessTypeId", "dae6cc51-b6dc-48c1-abb7-6f81b12d6ad5", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.PGqpE8LahkeZfe2ax11MHg/NodesNotShownInESpaceTree.Uczm2ty2wUirt2+BsS1q1Q, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enapprovalprocess1\".\"id\" o0, NULL o1, NULL o2, NULL o3, \"enapprovalprocess1\".\"regionid\" o4, NULL o5, NULL o6, NULL o7, \"enapprovalprocess1\".\"version\" o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18");
fromBuilder.Append(" FROM {ApprovalProcess} \"enapprovalprocess1\"");
whereBuilder.Append(" WHERE ");
if (qpapApprovalProcessTypeId != 0) {
whereBuilder.Append("((\"enapprovalprocess1\".\"approvalprocesstypeid\" = @qpapApprovalProcessTypeId) AND (\"enapprovalprocess1\".\"approvalprocesstypeid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpapApprovalProcessTypeId", DbType.Int32, qpapApprovalProcessTypeId);
} else {
whereBuilder.Append("(\"enapprovalprocess1\".\"approvalprocesstypeid\" IS NULL)");
}
whereBuilder.Append(" AND ");
if (qpprProcessTypeId != 0) {
whereBuilder.Append("((\"enapprovalprocess1\".\"processtypeid\" = @qpprProcessTypeId) AND (\"enapprovalprocess1\".\"processtypeid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprProcessTypeId", DbType.Int64, qpprProcessTypeId);
} else {
whereBuilder.Append("(\"enapprovalprocess1\".\"processtypeid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enapprovalprocess1\".\"isactive\" = 1)");
orderByBuilder.Append(" ORDER BY \"enapprovalprocess1\".\"id\" DESC ");
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
RL_5e0ca6ca9da3af4b1d8149758c39c2cf outParamList = new RL_5e0ca6ca9da3af4b1d8149758c39c2cf();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, false, true, true, true, false, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InitFolioWF_FromApprovProcId.GetApprovalProcessByApprovalProcessTypeId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_5e0ca6ca9da3af4b1d8149758c39c2cf _tmp = new RL_5e0ca6ca9da3af4b1d8149758c39c2cf();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InitFolioWF_FromApprovProcId.GetApprovalProcessByApprovalProcessTypeId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_5e0ca6ca9da3af4b1d8149758c39c2cf)_tmp;
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
