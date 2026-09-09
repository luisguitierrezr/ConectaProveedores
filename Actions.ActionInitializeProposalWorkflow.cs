namespace ssConectaProveedores;

public partial class Actions {
public class lcvInitializeProposalWorkflow : VarsBag {
public string inParami_ProcessTypeCode;
public long inParami_ProposalId;
public RL_5a265eacaa987aecd8ded8a7c13b9b2d queryResGetProposalLinesByProposalId_outParamList = new RL_5a265eacaa987aecd8ded8a7c13b9b2d();
public long queryResGetProposalLinesByProposalId_outParamCount = 0L;

public RL_acd66b694d90eb775616e6c6e3f83477 queryResGetApprovalProcessByProcessTypeCode_outParamList = new RL_acd66b694d90eb775616e6c6e3f83477();
public long queryResGetApprovalProcessByProcessTypeCode_outParamCount = 0L;

public Actions.lcoGetApprovalProcessLevels resGetApprovalProcessLevels =  new Actions.lcoGetApprovalProcessLevels();
public lcvInitializeProposalWorkflow(string inParami_ProcessTypeCode, long inParami_ProposalId) {
this.inParami_ProcessTypeCode = inParami_ProcessTypeCode;
this.inParami_ProposalId = inParami_ProposalId;
}
}
public class lcoInitializeProposalWorkflow : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public lcoInitializeProposalWorkflow() {
}
}
/// <summary>
/// Action <code>InitializeProposalWorkflow</code> that represents the Service Studio action
///  <code>InitializeProposalWorkflow</code> <p> Description: Action to initialize workflow</p>
/// </summary>
public static async Task<ST_046fb53ebbe142526d95e87ef1ae9711Structure> ActionInitializeProposalWorkflow(IRequestContext requestContext,string inParami_ProcessTypeCode,long inParami_ProposalId,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
lcoInitializeProposalWorkflow result = new lcoInitializeProposalWorkflow();
lcvInitializeProposalWorkflow localVars = new lcvInitializeProposalWorkflow(inParami_ProcessTypeCode, inParami_ProposalId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InitializeProposalWorkflow", "8e1d6772-5b38-4af0-bbb8-2bd4649ef882"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InitializeProposalWorkflow", "8e1d6772-5b38-4af0-bbb8-2bd4649ef882", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetApprovalProcessByProcessTypeCode
cancellationToken.ThrowIfCancellationRequested();
int datasetGetApprovalProcessByProcessTypeCode_maxRecords = 1;
if (datasetGetApprovalProcessByProcessTypeCode_maxRecords < 1) datasetGetApprovalProcessByProcessTypeCode_maxRecords = 1;
int datasetGetApprovalProcessByProcessTypeCode_startIndex = 0;(localVars.queryResGetApprovalProcessByProcessTypeCode_outParamList,localVars.queryResGetApprovalProcessByProcessTypeCode_outParamCount) = await FuncActionInitializeProposalWorkflow.datasetGetApprovalProcessByProcessTypeCode(requestContext,datasetGetApprovalProcessByProcessTypeCode_maxRecords,datasetGetApprovalProcessByProcessTypeCode_startIndex,IterationMultiplicity.Never,localVars.inParami_ProcessTypeCode,cancellationToken);

// ApprovalProcess not found?
if((localVars.queryResGetApprovalProcessByProcessTypeCode_outParamList.Empty)) {
// o_Output
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "Approval Process not configured!"
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("EXNvDSCHbkaWtL2HIOaFuA#Value.-777494200.1", "Approval Process not configured!");
} else {
// Query datasetGetProposalLinesByProposalId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetProposalLinesByProposalId_maxRecords = 0;
int datasetGetProposalLinesByProposalId_startIndex = 0;(localVars.queryResGetProposalLinesByProposalId_outParamList,localVars.queryResGetProposalLinesByProposalId_outParamCount) = await FuncActionInitializeProposalWorkflow.datasetGetProposalLinesByProposalId(requestContext,datasetGetProposalLinesByProposalId_maxRecords,datasetGetProposalLinesByProposalId_startIndex,IterationMultiplicity.Multiple,localVars.inParami_ProposalId,cancellationToken);

// GetApprovalProcessLevels
localVars.resGetApprovalProcessLevels.outParamo_Output = await Actions.ActionGetApprovalProcessLevels(requestContext,localVars.inParami_ProposalId,localVars.queryResGetApprovalProcessByProcessTypeCode_outParamList.CurrentRec.ssENApprovalProcess,(await RL_aa6d551b6d5a88ffd31c1dc552b78a0a.ConvertAsync(localVars.queryResGetProposalLinesByProposalId_outParamList, new RL_aa6d551b6d5a88ffd31c1dc552b78a0a(), async (RC_cbff39127609a0f830b2d34948d1c019 source, EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord target, CancellationToken cancellationToken) => {
target = source;
return target;
}, cancellationToken)),cancellationToken);

// ApprovalProcessLevels not found?
if((localVars.resGetApprovalProcessLevels.outParamo_Output.ssIsSuccess)) {
// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
} else {
// o_Output
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = GetApprovalProcessLevels.o_Output.Message
result.outParamo_Output.ssMessage = localVars.resGetApprovalProcessLevels.outParamo_Output.ssMessage;
}

}

} //close CreateActionActivity using block
} // try

finally {
outParamo_Output = result.outParamo_Output;
} // inner-finally
RETURN_STATEMENT:
return outParamo_Output;
}

public static class FuncActionInitializeProposalWorkflow {

// Query Function "GetProposalLinesByProposalId" Pu4fRtGeEUa+qfJBv+GByA of Action "InitializeProposalWorkflow"
public static async Task<(RL_5a265eacaa987aecd8ded8a7c13b9b2d,long)> datasetGetProposalLinesByProposalId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpprProposalId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InitializeProposalWorkflow.GetProposalLinesByProposalId", "461fee3e-9ed1-4611-bea9-f241bfe181c8");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InitializeProposalWorkflow.GetProposalLinesByProposalId", "461fee3e-9ed1-4611-bea9-f241bfe181c8", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.cmcdjjhb8Eq7uCvUZJ74gg/NodesNotShownInESpaceTree.Pu4fRtGeEUa+qfJBv+GByA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enproposalline6\".\"id\" o0, \"enproposalline6\".\"proposalid\" o1, \"enproposalline6\".\"approvalstatusid\" o2, \"enproposalline6\".\"companyid\" o3, \"enproposalline6\".\"supplierid\" o4, \"enproposalline6\".\"fe_contab_\" o5, \"enproposalline6\".\"ej__mes\" o6, \"enproposalline6\".\"cuenta\" o7, \"enproposalline6\".\"referencia\" o8, \"enproposalline6\".\"nombre1\" o9, \"enproposalline6\".\"nombre2\" o10, \"enproposalline6\".\"n_doc_\" o11, \"enproposalline6\".\"n_doctype\" o12, trim_scale(\"enproposalline6\".\"importeenml\"::numeric) o13, \"enproposalline6\".\"ml\" o14, trim_scale(\"enproposalline6\".\"importeenmd\"::numeric) o15, \"enproposalline6\".\"mon_\" o16, \"enproposalline6\".\"soc_\" o17, \"enproposalline6\".\"div_\" o18, \"enproposalline6\".\"lib_mayor\" o19, \"enproposalline6\".\"textocab_documento\" o20, \"enproposalline6\".\"doc_comp_\" o21, \"enproposalline6\".\"paidby\" o22, \"enproposalline6\".\"paidon\" o23, \"enproposalline6\".\"unpaidby\" o24, \"enproposalline6\".\"unpaidon\" o25, \"enproposalline6\".\"haserrors\" o26, \"enproposalline6\".\"errormessage\" o27");
fromBuilder.Append(" FROM {ProposalLine} \"enproposalline6\"");
whereBuilder.Append(" WHERE ");
if (qpprProposalId != 0) {
whereBuilder.Append("((\"enproposalline6\".\"proposalid\" = @qpprProposalId) AND (\"enproposalline6\".\"proposalid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprProposalId", DbType.Int64, qpprProposalId);
} else {
whereBuilder.Append("(\"enproposalline6\".\"proposalid\" IS NULL)");
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
RL_5a265eacaa987aecd8ded8a7c13b9b2d outParamList = new RL_5a265eacaa987aecd8ded8a7c13b9b2d();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InitializeProposalWorkflow.GetProposalLinesByProposalId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_5a265eacaa987aecd8ded8a7c13b9b2d _tmp = new RL_5a265eacaa987aecd8ded8a7c13b9b2d();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InitializeProposalWorkflow.GetProposalLinesByProposalId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_5a265eacaa987aecd8ded8a7c13b9b2d)_tmp;
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
// Query Function "GetApprovalProcessByProcessTypeCode" ixFGSjGFQkadoqHeWz1P7w of Action "InitializeProposalWorkflow"
public static async Task<(RL_acd66b694d90eb775616e6c6e3f83477,long)> datasetGetApprovalProcessByProcessTypeCode(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteProcessType_Code,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InitializeProposalWorkflow.GetApprovalProcessByProcessTypeCode", "4a46118b-8531-4642-9da2-a1de5b3d4fef");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InitializeProposalWorkflow.GetApprovalProcessByProcessTypeCode", "4a46118b-8531-4642-9da2-a1de5b3d4fef", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.cmcdjjhb8Eq7uCvUZJ74gg/NodesNotShownInESpaceTree.ixFGSjGFQkadoqHeWz1P7w, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enapprovalprocess22\".\"id\" o0, \"enapprovalprocess22\".\"processtypeid\" o1, \"enapprovalprocess22\".\"specialworkflowid\" o2, \"enapprovalprocess22\".\"approvalprocesstypeid\" o3, \"enapprovalprocess22\".\"regionid\" o4, \"enapprovalprocess22\".\"accountingregionid\" o5, \"enapprovalprocess22\".\"group\" o6, \"enapprovalprocess22\".\"code\" o7, \"enapprovalprocess22\".\"version\" o8, \"enapprovalprocess22\".\"description\" o9, \"enapprovalprocess22\".\"isactive\" o10, \"enapprovalprocess22\".\"isspecial\" o11, \"enapprovalprocess22\".\"isdonation\" o12, \"enapprovalprocess22\".\"iscxpcorporativo_deprec\" o13, \"enapprovalprocess22\".\"createdby\" o14, \"enapprovalprocess22\".\"createdon\" o15, \"enapprovalprocess22\".\"updatedby\" o16, \"enapprovalprocess22\".\"updatedon\" o17, \"enapprovalprocess22\".\"isselectfirstapprover\" o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23");
fromBuilder.Append(" FROM ({ApprovalProcess} \"enapprovalprocess22\" Inner JOIN {ProcessType} \"enprocesstype8\" ON (\"enapprovalprocess22\".\"processtypeid\" = \"enprocesstype8\".\"id\")) ");
whereBuilder.Append(" WHERE (\"enprocesstype8\".\"code\" = @qpteProcessType_Code) AND (\"enapprovalprocess22\".\"isactive\" = 1)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InitializeProposalWorkflow.GetApprovalProcessByProcessTypeCode.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InitializeProposalWorkflow.GetApprovalProcessByProcessTypeCode.List", cancellationToken: cancellationToken);
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
