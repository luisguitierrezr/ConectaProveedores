using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetailError_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetailError_ScreenModel).Namespace);

    public long inParami_ProposalId;
public string varLcTableSort;
public int varLcStartIndex;
public string varLcDateTextFormatted;
public DateTime varLcl_RefeshSideBar;
public bool varLcl_ReInvokeToggler;
public string varLcl_ColumnJSONVarGetProposalDetailError;
public int varLcl_CountAfterFetchGetProposalDetailError;
public bool varLcl_Loading;
public AggregateRecord<RL_f4591be205d3928a9fe22daf19d979cd> ScreenDataSetGetProposalById;
public AggregateRecord<RL_5a265eacaa987aecd8ded8a7c13b9b2d> ScreenDataSetGetProposalLinesByProposalId;
public AggregateRecord<RL_0a29febe5e5b3c22dc11930cd3be5c9e> ScreenDataSetGetFileImportLogsByFileId;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetailError_ScreenModel() {
}



    public ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetailError_ScreenModel(long inParami_ProposalId, string varLcTableSort, int varLcStartIndex, string varLcDateTextFormatted, DateTime varLcl_RefeshSideBar, bool varLcl_ReInvokeToggler, string varLcl_ColumnJSONVarGetProposalDetailError, int varLcl_CountAfterFetchGetProposalDetailError, bool varLcl_Loading, AggregateRecord<RL_f4591be205d3928a9fe22daf19d979cd> ScreenDataSetGetProposalById, AggregateRecord<RL_5a265eacaa987aecd8ded8a7c13b9b2d> ScreenDataSetGetProposalLinesByProposalId, AggregateRecord<RL_0a29febe5e5b3c22dc11930cd3be5c9e> ScreenDataSetGetFileImportLogsByFileId, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"i_ProposalId", "TableSort", "StartIndex", "DateTextFormatted", "l_RefeshSideBar", "l_ReInvokeToggler", "l_ColumnJSONVarGetProposalDetailError", "l_CountAfterFetchGetProposalDetailError", "l_Loading", "GetProposalById", "GetProposalLinesByProposalId", "GetFileImportLogsByFileId", "ClientVars"}, new string[] {"inParami_ProposalId", "varLcTableSort", "varLcStartIndex", "varLcDateTextFormatted", "varLcl_RefeshSideBar", "varLcl_ReInvokeToggler", "varLcl_ColumnJSONVarGetProposalDetailError", "varLcl_CountAfterFetchGetProposalDetailError", "varLcl_Loading", "ScreenDataSetGetProposalById", "ScreenDataSetGetProposalLinesByProposalId", "ScreenDataSetGetFileImportLogsByFileId", "clientVariables"});
this.inParami_ProposalId = inParami_ProposalId;
this.varLcTableSort = varLcTableSort;
this.varLcStartIndex = varLcStartIndex;
this.varLcDateTextFormatted = varLcDateTextFormatted;
this.varLcl_RefeshSideBar = varLcl_RefeshSideBar;
this.varLcl_ReInvokeToggler = varLcl_ReInvokeToggler;
this.varLcl_ColumnJSONVarGetProposalDetailError = varLcl_ColumnJSONVarGetProposalDetailError;
this.varLcl_CountAfterFetchGetProposalDetailError = varLcl_CountAfterFetchGetProposalDetailError;
this.varLcl_Loading = varLcl_Loading;
this.ScreenDataSetGetProposalById = ScreenDataSetGetProposalById;
this.ScreenDataSetGetProposalLinesByProposalId = ScreenDataSetGetProposalLinesByProposalId;
this.ScreenDataSetGetFileImportLogsByFileId = ScreenDataSetGetFileImportLogsByFileId;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_931c5818c70fb94c867f1591b8f8bd0d> datasetGetProposalByIdReadDbAsync(RC_931c5818c70fb94c867f1591b8f8bd0d rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENBank.Read( r, ref index);
rec.ssENCurrency.Read( r, ref index);
rec.ssENFileExtended.Read( r, ref index);
rec.ssENProposal.Read( r, ref index);
rec.ssENProposalStatus.Read( r, ref index);
rec.ssENProposalType.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
return rec;
}
// Query Function "GetProposalById" I2s9ge0qdk6FWcWOEJcTAg of Action "ProposalDetailError"
public static async Task<(RL_f4591be205d3928a9fe22daf19d979cd,long)> datasetGetProposalById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckComissionesArrendamientosViewerRole,bool qpboCheckUserSession,long qpreProposal_RegionId,long qpprProposal_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("b_CyA_AdminCommissionsLeasing.ProposalDetailError.GetProposalById", "813d6b23-2aed-4e76-8559-c58e10971302");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("ProposalDetailError","b_CyA_AdminCommissionsLeasing.ProposalDetailError.GetProposalById");
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
selectBuilder.Append("/* /NRWebFlows.Qwoh9BhTeEOXvq3lBDkhrg/NodesShownInESpaceTree.rByVV3oaPUS9VxBK3FXSOQ/ScreenDataSets.I2s9ge0qdk6FWcWOEJcTAg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, \"enbank12\".\"code\" o3, NULL o4, NULL o5, \"encurrency37\".\"code\" o6, NULL o7, NULL o8, NULL o9, NULL o10, \"enfileextended8\".\"id\" o11, \"enfileextended8\".\"filename\" o12, NULL o13, \"enfileextended8\".\"haserror\" o14, \"enfileextended8\".\"errormessage\" o15, \"enfileextended8\".\"uploadedby\" o16, \"enfileextended8\".\"uploadedon\" o17, NULL o18, \"enproposal25\".\"name\" o19, \"enproposal25\".\"paymentdate\" o20, NULL o21, NULL o22, NULL o23, \"enproposal25\".\"proposalstatusid\" o24, NULL o25, \"enproposal25\".\"totalproposallines\" o26, trim_scale(\"enproposal25\".\"totalvalueml\"::numeric) o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, \"enproposalstatus11\".\"label\" o37, \"enproposalstatus11\".\"class\" o38, NULL o39, NULL o40, NULL o41, \"enproposaltype10\".\"label\" o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57");
fromBuilder.Append(" FROM (((((({FileExtended} \"enfileextended8\" Inner JOIN {Proposal} \"enproposal25\" ON (\"enfileextended8\".\"id\" = \"enproposal25\".\"fileid\"))  Left JOIN {Bank} \"enbank12\" ON (\"enproposal25\".\"bankid\" = \"enbank12\".\"id\"))  Left JOIN {Region} \"enregion171\" ON (\"enproposal25\".\"regionid\" = \"enregion171\".\"id\"))  Left JOIN {ProposalType} \"enproposaltype10\" ON (\"enproposal25\".\"proposaltypeid\" = \"enproposaltype10\".\"id\"))  Left JOIN {ProposalStatus} \"enproposalstatus11\" ON (\"enproposal25\".\"proposalstatusid\" = \"enproposalstatus11\".\"id\"))  Left JOIN {Currency} \"encurrency37\" ON (\"enproposal25\".\"currencyid\" = \"encurrency37\".\"code\")) ");
whereBuilder.Append(" WHERE ");
if (qpprProposal_Id != 0) {
whereBuilder.Append("((\"enproposal25\".\"id\" = @qpprProposal_Id) AND (\"enproposal25\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprProposal_Id", DbType.Int64, qpprProposal_Id);
} else {
whereBuilder.Append("(\"enproposal25\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (@qpboCheckUserSession = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qpboCheckComissionesArrendamientosViewerRole) {
if (qpreProposal_RegionId != 0) {
whereBuilder.Append("((\"enproposal25\".\"regionid\" = @qpreProposal_RegionId) AND (\"enproposal25\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreProposal_RegionId", DbType.Int64, qpreProposal_RegionId);
} else {
whereBuilder.Append("(\"enproposal25\".\"regionid\" IS NULL)");
}
}
string whereBuilderString = whereBuilder.ToString();
if (whereBuilderString.EndsWith(" AND ")) {
whereBuilder.Remove(whereBuilderString.Length - 5, 5);
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
RL_f4591be205d3928a9fe22daf19d979cd outParamList = new RL_f4591be205d3928a9fe22daf19d979cd();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetProposalByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[7];
opt[0] = new BitArray(new bool[] {false, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, false, true, true});
opt[2] = new BitArray(new bool[] {true, false, false, true, true, true, false, true, false, false, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {false, false, true, false, false, false, false});
opt[4] = new BitArray(new bool[] {true, false, true, true});
opt[5] = new BitArray(new bool[] {true, false, false, true, true});
opt[6] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query b_CyA_AdminCommissionsLeasing.ProposalDetailError.GetProposalById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_f4591be205d3928a9fe22daf19d979cd _tmp = new RL_f4591be205d3928a9fe22daf19d979cd();
_tmp.AlternateReadDbMethodAsync = datasetGetProposalByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query b_CyA_AdminCommissionsLeasing.ProposalDetailError.GetProposalById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_f4591be205d3928a9fe22daf19d979cd)_tmp;
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

// Query Function "GetProposalLinesByProposalId" kHZgmlCdPU6EWCHvohgl4w of Action "ProposalDetailError"
public static async Task<(RL_5a265eacaa987aecd8ded8a7c13b9b2d,long)> datasetGetProposalLinesByProposalId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,long qpprProposalId,string qpteTableSort,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("b_CyA_AdminCommissionsLeasing.ProposalDetailError.GetProposalLinesByProposalId", "9a607690-9d50-4e3d-8458-21efa21825e3");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("ProposalDetailError","b_CyA_AdminCommissionsLeasing.ProposalDetailError.GetProposalLinesByProposalId");
// Query Iterations: Multiple
// Refresh Query Gc8_pVyYKkWBqGsMir8dEg Iterations: Multiple
// Refresh Query cCQfzqM6ZkKw9H0Dx+fMoA Iterations: Multiple
// Refresh Query YlCjKYOoxUyZ7twp8fNGMA Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
await using(var sqlCountCmd = trans.CreateCommand()){
string sql = "";
string sqlCount = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /NRWebFlows.Qwoh9BhTeEOXvq3lBDkhrg/NodesShownInESpaceTree.rByVV3oaPUS9VxBK3FXSOQ/ScreenDataSets.kHZgmlCdPU6EWCHvohgl4w, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, \"enproposalline15\".\"fe_contab_\" o5, NULL o6, \"enproposalline15\".\"cuenta\" o7, \"enproposalline15\".\"referencia\" o8, \"enproposalline15\".\"nombre1\" o9, NULL o10, \"enproposalline15\".\"n_doc_\" o11, NULL o12, trim_scale(\"enproposalline15\".\"importeenml\"::numeric) o13, \"enproposalline15\".\"ml\" o14, trim_scale(\"enproposalline15\".\"importeenmd\"::numeric) o15, \"enproposalline15\".\"mon_\" o16, \"enproposalline15\".\"soc_\" o17, \"enproposalline15\".\"div_\" o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, \"enproposalline15\".\"haserrors\" o26, \"enproposalline15\".\"errormessage\" o27");
fromBuilder.Append(" FROM {ProposalLine} \"enproposalline15\"");
whereBuilder.Append(" WHERE ");
if (qpprProposalId != 0) {
whereBuilder.Append("((\"enproposalline15\".\"proposalid\" = @qpprProposalId) AND (\"enproposalline15\".\"proposalid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprProposalId", DbType.Int64, qpprProposalId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpprProposalId", DbType.Int64, qpprProposalId);
} else {
whereBuilder.Append("(\"enproposalline15\".\"proposalid\" IS NULL)");
}
whereBuilder.Append(" AND (@qpboCheckUserSession = 1)");
orderByBuilder.Append(" ORDER BY ");
List<string> orderByColumns = new List<string>();
orderByColumns.Add("\"enproposalline15\".\"haserrors\" DESC ");
orderByColumns.AddRange(BaseAppUtils.ReplaceEntityReferencesAndAttributesInOrderBy(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, qpteTableSort, new string[] { "ProposalLine" }, new string[] { "ENProposalLine15" }, new System.Collections.Generic.Dictionary<string, string>[] { ENProposalLineEntity.AttributesToDatabaseNamesMap() }).Split(','));
orderByBuilder.Append(BaseAppUtils.GetOrderByColumnsWithoutDuplicates(orderByColumns));
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
sqlCountCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
if (startIndex > 0) {
orderByBuilder.Append(" OFFSET ");
orderByBuilder.Append(startIndex);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCount = "SELECT COUNT(1) " + fromBuilder.ToString() + whereBuilder.ToString() + groupByBuilder.ToString() + havingBuilder.ToString();
sqlCount = AppUtils.Instance.ReplaceEntityReferences(requestContext, sqlCount);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
sqlCountCmd.CommandText = sqlCount;
try {
RL_5a265eacaa987aecd8ded8a7c13b9b2d outParamList = new RL_5a265eacaa987aecd8ded8a7c13b9b2d();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, false, true, false, false, false, true, false, true, false, false, false, false, false, false, true, true, true, true, true, true, true, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query b_CyA_AdminCommissionsLeasing.ProposalDetailError.GetProposalLinesByProposalId.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query b_CyA_AdminCommissionsLeasing.ProposalDetailError.GetProposalLinesByProposalId.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query b_CyA_AdminCommissionsLeasing.ProposalDetailError.GetProposalLinesByProposalId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_5a265eacaa987aecd8ded8a7c13b9b2d)_tmp;
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query b_CyA_AdminCommissionsLeasing.ProposalDetailError.GetProposalLinesByProposalId.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
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

private static async Task<RC_30fde7bd8b6b69ef09faede048f7361d> datasetGetFileImportLogsByFileIdReadDbAsync(RC_30fde7bd8b6b69ef09faede048f7361d rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFileImportLog.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
return rec;
}
// Query Function "GetFileImportLogsByFileId" BruZ0GbkVUqWTDu+cXGA6Q of Action "ProposalDetailError"
public static async Task<(RL_0a29febe5e5b3c22dc11930cd3be5c9e,long)> datasetGetFileImportLogsByFileId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,long qpfiFileImportLog_FileId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("b_CyA_AdminCommissionsLeasing.ProposalDetailError.GetFileImportLogsByFileId", "d099bb06-e466-4a55-964c-3bbe717180e9");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("ProposalDetailError","b_CyA_AdminCommissionsLeasing.ProposalDetailError.GetFileImportLogsByFileId");
// Query Iterations: Never
// Refresh Query scHV1rF3KEmcRYOsqb668w Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.Qwoh9BhTeEOXvq3lBDkhrg/NodesShownInESpaceTree.rByVV3oaPUS9VxBK3FXSOQ/ScreenDataSets.BruZ0GbkVUqWTDu+cXGA6Q, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9");
fromBuilder.Append(" FROM ({FileImportLog} \"enfileimportlog\" Left JOIN {User} \"enuser214\" ON (\"enfileimportlog\".\"importedby\" = \"enuser214\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpfiFileImportLog_FileId != 0) {
whereBuilder.Append("((\"enfileimportlog\".\"fileid\" = @qpfiFileImportLog_FileId) AND (\"enfileimportlog\".\"fileid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfiFileImportLog_FileId", DbType.Int64, qpfiFileImportLog_FileId);
} else {
whereBuilder.Append("(\"enfileimportlog\".\"fileid\" IS NULL)");
}
whereBuilder.Append(" AND (@qpboCheckUserSession = 1)");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
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
RL_0a29febe5e5b3c22dc11930cd3be5c9e outParamList = new RL_0a29febe5e5b3c22dc11930cd3be5c9e();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFileImportLogsByFileIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query b_CyA_AdminCommissionsLeasing.ProposalDetailError.GetFileImportLogsByFileId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_0a29febe5e5b3c22dc11930cd3be5c9e _tmp = new RL_0a29febe5e5b3c22dc11930cd3be5c9e();
_tmp.AlternateReadDbMethodAsync = datasetGetFileImportLogsByFileIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query b_CyA_AdminCommissionsLeasing.ProposalDetailError.GetFileImportLogsByFileId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_0a29febe5e5b3c22dc11930cd3be5c9e)_tmp;
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
