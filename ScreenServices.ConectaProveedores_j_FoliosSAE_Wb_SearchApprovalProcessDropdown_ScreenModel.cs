using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_j_FoliosSAE_Wb_SearchApprovalProcessDropdown_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_j_FoliosSAE_Wb_SearchApprovalProcessDropdown_ScreenModel).Namespace);

    public bool inParami_IsDisable;
public long inParami_ApprovalProcessId;
public bool inParami_IsValid;
public bool inParami_IsMandatory;
public bool inParami_IsFilter;
public int inParami_ApprovalProcessTypeId;
public string varLcl_ApprovalProcessSearchText;
public int varLcl_ApprovalProcessMaxRecord;
public bool varLcl_IsValid;
public AggregateRecord<RL_5c614a706e3e33b4caf55ba997e805be> ScreenDataSetGetApprovalProcesss;
public AggregateRecord<RL_5e0ca6ca9da3af4b1d8149758c39c2cf> ScreenDataSetGetApprovalProcessById;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_j_FoliosSAE_Wb_SearchApprovalProcessDropdown_ScreenModel() {
}



    public ConectaProveedores_j_FoliosSAE_Wb_SearchApprovalProcessDropdown_ScreenModel(bool inParami_IsDisable, long inParami_ApprovalProcessId, bool inParami_IsValid, bool inParami_IsMandatory, bool inParami_IsFilter, int inParami_ApprovalProcessTypeId, string varLcl_ApprovalProcessSearchText, int varLcl_ApprovalProcessMaxRecord, bool varLcl_IsValid, AggregateRecord<RL_5c614a706e3e33b4caf55ba997e805be> ScreenDataSetGetApprovalProcesss, AggregateRecord<RL_5e0ca6ca9da3af4b1d8149758c39c2cf> ScreenDataSetGetApprovalProcessById, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"i_IsDisable", "i_ApprovalProcessId", "i_IsValid", "i_IsMandatory", "i_IsFilter", "i_ApprovalProcessTypeId", "l_ApprovalProcessSearchText", "l_ApprovalProcessMaxRecord", "l_IsValid", "GetApprovalProcesss", "GetApprovalProcessById", "ClientVars"}, new string[] {"inParami_IsDisable", "inParami_ApprovalProcessId", "inParami_IsValid", "inParami_IsMandatory", "inParami_IsFilter", "inParami_ApprovalProcessTypeId", "varLcl_ApprovalProcessSearchText", "varLcl_ApprovalProcessMaxRecord", "varLcl_IsValid", "ScreenDataSetGetApprovalProcesss", "ScreenDataSetGetApprovalProcessById", "clientVariables"});
this.inParami_IsDisable = inParami_IsDisable;
this.inParami_ApprovalProcessId = inParami_ApprovalProcessId;
this.inParami_IsValid = inParami_IsValid;
this.inParami_IsMandatory = inParami_IsMandatory;
this.inParami_IsFilter = inParami_IsFilter;
this.inParami_ApprovalProcessTypeId = inParami_ApprovalProcessTypeId;
this.varLcl_ApprovalProcessSearchText = varLcl_ApprovalProcessSearchText;
this.varLcl_ApprovalProcessMaxRecord = varLcl_ApprovalProcessMaxRecord;
this.varLcl_IsValid = varLcl_IsValid;
this.ScreenDataSetGetApprovalProcesss = ScreenDataSetGetApprovalProcesss;
this.ScreenDataSetGetApprovalProcessById = ScreenDataSetGetApprovalProcessById;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_8cfc2af1075444d3070aa6269dcfdf32> datasetGetApprovalProcesssReadDbAsync(RC_8cfc2af1075444d3070aa6269dcfdf32 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApprovalProcess.Read( r, ref index);
rec.ssENApprovalProcessType.Read( r, ref index);
rec.ssENProcessType.Read( r, ref index);
return rec;
}
// Query Function "GetApprovalProcesss" NFi0AzT7C0GFbBdIa9WiBA of Action "Wb_SearchApprovalProcessDropdown"
public static async Task<(RL_5c614a706e3e33b4caf55ba997e805be,long)> datasetGetApprovalProcesss(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,int qpapApprovalProcess_ApprovalProcessTypeId,string qptel_ApprovalProcessSearchText,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.Wb_SearchApprovalProcessDropdown.GetApprovalProcesss", "03b45834-fb34-410b-856c-17486bd5a204");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_SearchApprovalProcessDropdown","j_FoliosSAE.Wb_SearchApprovalProcessDropdown.GetApprovalProcesss");
// Query Iterations: Multiple
// Refresh Query 9URDjfkblEmyl4RLxwP1VQ Iterations: Multiple
// Refresh Query eIJHX9U5o0a3XVy0YfJPkA Iterations: Multiple
// Refresh Query VkVo3s0_aEyXEjURGpu1Ig Iterations: Multiple
// Refresh Query ZJStjDOKe0WPx6WdO7ofJA Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.jto7zN8k3UuhL5guAYnnnQ/ScreenDataSets.NFi0AzT7C0GFbBdIa9WiBA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enapprovalprocess54\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, \"enapprovalprocess54\".\"group\" o6, \"enapprovalprocess54\".\"code\" o7, NULL o8, \"enapprovalprocess54\".\"description\" o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28");
fromBuilder.Append(" FROM (({ApprovalProcess} \"enapprovalprocess54\" Left JOIN {ApprovalProcessType} \"enapprovalprocesstype6\" ON (\"enapprovalprocess54\".\"approvalprocesstypeid\" = \"enapprovalprocesstype6\".\"id\"))  Left JOIN {ProcessType} \"enprocesstype17\" ON (\"enapprovalprocess54\".\"processtypeid\" = \"enprocesstype17\".\"id\")) ");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND (caseaccent_normalize(\"enprocesstype17\".\"code\" collate \"default\") like caseaccent_normalize('FolioSAE' collate \"default\")) AND (\"enapprovalprocess54\".\"isactive\" = 1) AND (\"enapprovalprocesstype6\".\"id\" <> ");
whereBuilder.Append(4
);
whereBuilder.Append(") AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qptel_ApprovalProcessSearchText != "" && qptel_ApprovalProcessSearchText != "" && qptel_ApprovalProcessSearchText != "" && qptel_ApprovalProcessSearchText != "" && qptel_ApprovalProcessSearchText != "") {
whereBuilder.Append("((((caseaccent_normalize(\"enapprovalprocess54\".\"code\" collate \"default\") like caseaccent_normalize((('%' || @qptel_ApprovalProcessSearchText) || '%') collate \"default\")) OR (caseaccent_normalize(\"enapprovalprocess54\".\"group\" collate \"default\") like caseaccent_normalize((('%' || @qptel_ApprovalProcessSearchText) || '%') collate \"default\"))) OR (caseaccent_normalize(\"enapprovalprocess54\".\"description\" collate \"default\") like caseaccent_normalize((('%' || @qptel_ApprovalProcessSearchText) || '%') collate \"default\"))) OR (caseaccent_normalize(\"enapprovalprocesstype6\".\"label_es\" collate \"default\") like caseaccent_normalize((('%' || @qptel_ApprovalProcessSearchText) || '%') collate \"default\"))) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qptel_ApprovalProcessSearchText", DbType.String, qptel_ApprovalProcessSearchText);
}
if (qpapApprovalProcess_ApprovalProcessTypeId != BuiltInFunction.NullIdentifier()) {
if (qpapApprovalProcess_ApprovalProcessTypeId != 0) {
whereBuilder.Append("((\"enapprovalprocess54\".\"approvalprocesstypeid\" = @qpapApprovalProcess_ApprovalProcessTypeId) AND (\"enapprovalprocess54\".\"approvalprocesstypeid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpapApprovalProcess_ApprovalProcessTypeId", DbType.Int32, qpapApprovalProcess_ApprovalProcessTypeId);
} else {
whereBuilder.Append("(\"enapprovalprocess54\".\"approvalprocesstypeid\" IS NULL)");
}
}
string whereBuilderString = whereBuilder.ToString();
if (whereBuilderString.EndsWith(" AND ")) {
whereBuilder.Remove(whereBuilderString.Length - 5, 5);
}
orderByBuilder.Append(" ORDER BY \"enapprovalprocesstype6\".\"id\" ASC , \"enapprovalprocess54\".\"code\" ASC ");
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
RL_5c614a706e3e33b4caf55ba997e805be outParamList = new RL_5c614a706e3e33b4caf55ba997e805be();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetApprovalProcesssReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, false, false, true, false, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_SearchApprovalProcessDropdown.GetApprovalProcesss.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_5c614a706e3e33b4caf55ba997e805be _tmp = new RL_5c614a706e3e33b4caf55ba997e805be();
_tmp.AlternateReadDbMethodAsync = datasetGetApprovalProcesssReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_SearchApprovalProcessDropdown.GetApprovalProcesss.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_5c614a706e3e33b4caf55ba997e805be)_tmp;
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

// Query Function "GetApprovalProcessById" ayfv9KmtaEy2XFzjeELhGw of Action "Wb_SearchApprovalProcessDropdown"
public static async Task<(RL_5e0ca6ca9da3af4b1d8149758c39c2cf,long)> datasetGetApprovalProcessById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,long qpapId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.Wb_SearchApprovalProcessDropdown.GetApprovalProcessById", "f4ef276b-ada9-4c68-b65c-5ce37842e11b");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_SearchApprovalProcessDropdown","j_FoliosSAE.Wb_SearchApprovalProcessDropdown.GetApprovalProcessById");
// Query Iterations: Never
// Refresh Query azPfmmZaa0K4omGM33Fx7g Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.jto7zN8k3UuhL5guAYnnnQ/ScreenDataSets.ayfv9KmtaEy2XFzjeELhGw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enapprovalprocess55\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, \"enapprovalprocess55\".\"code\" o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18");
fromBuilder.Append(" FROM {ApprovalProcess} \"enapprovalprocess55\"");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qpapId != 0) {
whereBuilder.Append("((\"enapprovalprocess55\".\"id\" = @qpapId) AND (\"enapprovalprocess55\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpapId", DbType.Int64, qpapId);
} else {
whereBuilder.Append("(\"enapprovalprocess55\".\"id\" IS NULL)");
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
RL_5e0ca6ca9da3af4b1d8149758c39c2cf outParamList = new RL_5e0ca6ca9da3af4b1d8149758c39c2cf();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_SearchApprovalProcessDropdown.GetApprovalProcessById.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_SearchApprovalProcessDropdown.GetApprovalProcessById.List", cancellationToken: cancellationToken);
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
