using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsListViewer_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsListViewer_ScreenModel).Namespace);

    public string varLcl_TableSort;
public int varLcl_StartIndex;
public bool varLcl_ShowFilters;
public bool varLcl_ReInvokeToggler;
public string varLcl_ColumnJSONVarGetProposal;
public int varLcl_CountAfterFetchGetProposal;
public bool varLcl_Loading;
public bool varLcl_IsAutoRefresh;
public string varLcl_AmountFromText;
public string varLcl_AmountToText;
public AggregateRecord<RL_1353a59e0688582d82bbddc41b47193e> ScreenDataSetGetCurrencies;
public AggregateRecord<RL_f03e17396f660361b67a45f0e1101893> ScreenDataSetGetOperators;
public AggregateRecord<RL_edf26e482e095588ed6d5cbd5313bc7f> ScreenDataSetGetProposalStatus;
public AggregateRecord<RL_0fc5fa92a15115f6e97a1071c9876bcd> ScreenDataSetGetBanks;
public AggregateRecord<RL_75c16c4807d1a3963546d53942756918> ScreenDataSetGetProposalTypes;
public AggregateRecord<RL_8ba5b56e8055656db873b3771bf59d3c> ScreenDataSetGetProposals;
public ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsListViewer_DataActionGetUploadType_Model varLcGetUploadType;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsListViewer_ScreenModel() {
}



    public ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsListViewer_ScreenModel(string varLcl_TableSort, int varLcl_StartIndex, bool varLcl_ShowFilters, bool varLcl_ReInvokeToggler, string varLcl_ColumnJSONVarGetProposal, int varLcl_CountAfterFetchGetProposal, bool varLcl_Loading, bool varLcl_IsAutoRefresh, string varLcl_AmountFromText, string varLcl_AmountToText, AggregateRecord<RL_1353a59e0688582d82bbddc41b47193e> ScreenDataSetGetCurrencies, AggregateRecord<RL_f03e17396f660361b67a45f0e1101893> ScreenDataSetGetOperators, AggregateRecord<RL_edf26e482e095588ed6d5cbd5313bc7f> ScreenDataSetGetProposalStatus, AggregateRecord<RL_0fc5fa92a15115f6e97a1071c9876bcd> ScreenDataSetGetBanks, AggregateRecord<RL_75c16c4807d1a3963546d53942756918> ScreenDataSetGetProposalTypes, AggregateRecord<RL_8ba5b56e8055656db873b3771bf59d3c> ScreenDataSetGetProposals, ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsListViewer_DataActionGetUploadType_Model varLcGetUploadType, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"l_TableSort", "l_StartIndex", "l_ShowFilters", "l_ReInvokeToggler", "l_ColumnJSONVarGetProposal", "l_CountAfterFetchGetProposal", "l_Loading", "l_IsAutoRefresh", "l_AmountFromText", "l_AmountToText", "GetCurrencies", "GetOperators", "GetProposalStatus", "GetBanks", "GetProposalTypes", "GetProposals", "GetUploadType", "ClientVars"}, new string[] {"varLcl_TableSort", "varLcl_StartIndex", "varLcl_ShowFilters", "varLcl_ReInvokeToggler", "varLcl_ColumnJSONVarGetProposal", "varLcl_CountAfterFetchGetProposal", "varLcl_Loading", "varLcl_IsAutoRefresh", "varLcl_AmountFromText", "varLcl_AmountToText", "ScreenDataSetGetCurrencies", "ScreenDataSetGetOperators", "ScreenDataSetGetProposalStatus", "ScreenDataSetGetBanks", "ScreenDataSetGetProposalTypes", "ScreenDataSetGetProposals", "varLcGetUploadType", "clientVariables"});
this.varLcl_TableSort = varLcl_TableSort;
this.varLcl_StartIndex = varLcl_StartIndex;
this.varLcl_ShowFilters = varLcl_ShowFilters;
this.varLcl_ReInvokeToggler = varLcl_ReInvokeToggler;
this.varLcl_ColumnJSONVarGetProposal = varLcl_ColumnJSONVarGetProposal;
this.varLcl_CountAfterFetchGetProposal = varLcl_CountAfterFetchGetProposal;
this.varLcl_Loading = varLcl_Loading;
this.varLcl_IsAutoRefresh = varLcl_IsAutoRefresh;
this.varLcl_AmountFromText = varLcl_AmountFromText;
this.varLcl_AmountToText = varLcl_AmountToText;
this.ScreenDataSetGetCurrencies = ScreenDataSetGetCurrencies;
this.ScreenDataSetGetOperators = ScreenDataSetGetOperators;
this.ScreenDataSetGetProposalStatus = ScreenDataSetGetProposalStatus;
this.ScreenDataSetGetBanks = ScreenDataSetGetBanks;
this.ScreenDataSetGetProposalTypes = ScreenDataSetGetProposalTypes;
this.ScreenDataSetGetProposals = ScreenDataSetGetProposals;
this.varLcGetUploadType = varLcGetUploadType;
this.clientVariables = clientVariables;
}



    
// Query Function "GetCurrencies" ujH6Y0fQfkmyicbjBwqWsQ of Action "ProposalsListViewer"
public static async Task<(RL_1353a59e0688582d82bbddc41b47193e,long)> datasetGetCurrencies(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("b_CyA_AdminCommissionsLeasing.ProposalsListViewer.GetCurrencies", "63fa31ba-d047-497e-b289-c6e3070a96b1");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("ProposalsListViewer","b_CyA_AdminCommissionsLeasing.ProposalsListViewer.GetCurrencies");
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
selectBuilder.Append("/* /NRWebFlows.Qwoh9BhTeEOXvq3lBDkhrg/NodesShownInESpaceTree.uPuycxfGVECtMNcfIiDjvQ/ScreenDataSets.ujH6Y0fQfkmyicbjBwqWsQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"encurrency38\".\"code\" o0, \"encurrency38\".\"name\" o1, NULL o2, NULL o3, NULL o4");
fromBuilder.Append(" FROM {Currency} \"encurrency38\"");
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
RL_1353a59e0688582d82bbddc41b47193e outParamList = new RL_1353a59e0688582d82bbddc41b47193e();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query b_CyA_AdminCommissionsLeasing.ProposalsListViewer.GetCurrencies.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_1353a59e0688582d82bbddc41b47193e _tmp = new RL_1353a59e0688582d82bbddc41b47193e();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query b_CyA_AdminCommissionsLeasing.ProposalsListViewer.GetCurrencies.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_1353a59e0688582d82bbddc41b47193e)_tmp;
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

// Query Function "GetOperators" 1zDhaW_V2U6do3mU7usdPA of Action "ProposalsListViewer"
public static async Task<(RL_f03e17396f660361b67a45f0e1101893,long)> datasetGetOperators(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("b_CyA_AdminCommissionsLeasing.ProposalsListViewer.GetOperators", "69e130d7-d56f-4ed9-9da3-7994eeeb1d3c");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("ProposalsListViewer","b_CyA_AdminCommissionsLeasing.ProposalsListViewer.GetOperators");
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
selectBuilder.Append("/* /NRWebFlows.Qwoh9BhTeEOXvq3lBDkhrg/NodesShownInESpaceTree.uPuycxfGVECtMNcfIiDjvQ/ScreenDataSets.1zDhaW_V2U6do3mU7usdPA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3");
fromBuilder.Append(" FROM {Operator} \"enoperator3\"");
whereBuilder.Append(" WHERE (\"enoperator3\".\"is_active\" = 1) AND (@qpboCheckUserSession = 1)");
orderByBuilder.Append(" ORDER BY 1 ASC");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
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
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_f03e17396f660361b67a45f0e1101893 outParamList = new RL_f03e17396f660361b67a45f0e1101893();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query b_CyA_AdminCommissionsLeasing.ProposalsListViewer.GetOperators.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_f03e17396f660361b67a45f0e1101893 _tmp = new RL_f03e17396f660361b67a45f0e1101893();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query b_CyA_AdminCommissionsLeasing.ProposalsListViewer.GetOperators.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_f03e17396f660361b67a45f0e1101893)_tmp;
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

// Query Function "GetProposalStatus" OP1SnvMKbEqj4EHduWN+Fg of Action "ProposalsListViewer"
public static async Task<(RL_edf26e482e095588ed6d5cbd5313bc7f,long)> datasetGetProposalStatus(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("b_CyA_AdminCommissionsLeasing.ProposalsListViewer.GetProposalStatus", "9e52fd38-0af3-4a6c-a3e0-41ddb9637e16");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("ProposalsListViewer","b_CyA_AdminCommissionsLeasing.ProposalsListViewer.GetProposalStatus");
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
selectBuilder.Append("/* /NRWebFlows.Qwoh9BhTeEOXvq3lBDkhrg/NodesShownInESpaceTree.uPuycxfGVECtMNcfIiDjvQ/ScreenDataSets.OP1SnvMKbEqj4EHduWN+Fg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enproposalstatus12\".\"id\" o0, \"enproposalstatus12\".\"label\" o1, NULL o2, NULL o3, NULL o4");
fromBuilder.Append(" FROM {ProposalStatus} \"enproposalstatus12\"");
whereBuilder.Append(" WHERE (\"enproposalstatus12\".\"is_active\" = 1) AND (@qpboCheckUserSession = 1)");
orderByBuilder.Append(" ORDER BY \"enproposalstatus12\".\"label\" ASC ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
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
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_edf26e482e095588ed6d5cbd5313bc7f outParamList = new RL_edf26e482e095588ed6d5cbd5313bc7f();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query b_CyA_AdminCommissionsLeasing.ProposalsListViewer.GetProposalStatus.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_edf26e482e095588ed6d5cbd5313bc7f _tmp = new RL_edf26e482e095588ed6d5cbd5313bc7f();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query b_CyA_AdminCommissionsLeasing.ProposalsListViewer.GetProposalStatus.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_edf26e482e095588ed6d5cbd5313bc7f)_tmp;
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

// Query Function "GetBanks" 326Wpv7JS0ShAE92iV8PSg of Action "ProposalsListViewer"
public static async Task<(RL_0fc5fa92a15115f6e97a1071c9876bcd,long)> datasetGetBanks(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("b_CyA_AdminCommissionsLeasing.ProposalsListViewer.GetBanks", "a6966edf-c9fe-444b-a100-4f76895f0f4a");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("ProposalsListViewer","b_CyA_AdminCommissionsLeasing.ProposalsListViewer.GetBanks");
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
selectBuilder.Append("/* /NRWebFlows.Qwoh9BhTeEOXvq3lBDkhrg/NodesShownInESpaceTree.uPuycxfGVECtMNcfIiDjvQ/ScreenDataSets.326Wpv7JS0ShAE92iV8PSg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enbank13\".\"id\" o0, \"enbank13\".\"name\" o1, NULL o2, NULL o3, NULL o4, NULL o5");
fromBuilder.Append(" FROM {Bank} \"enbank13\"");
whereBuilder.Append(" WHERE (\"enbank13\".\"isactive\" = 1) AND (@qpboCheckUserSession = 1)");
orderByBuilder.Append(" ORDER BY 1 ASC");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
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
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_0fc5fa92a15115f6e97a1071c9876bcd outParamList = new RL_0fc5fa92a15115f6e97a1071c9876bcd();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query b_CyA_AdminCommissionsLeasing.ProposalsListViewer.GetBanks.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_0fc5fa92a15115f6e97a1071c9876bcd _tmp = new RL_0fc5fa92a15115f6e97a1071c9876bcd();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query b_CyA_AdminCommissionsLeasing.ProposalsListViewer.GetBanks.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_0fc5fa92a15115f6e97a1071c9876bcd)_tmp;
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

// Query Function "GetProposalTypes" mke9ybhXlkKMaTa3fivH+w of Action "ProposalsListViewer"
public static async Task<(RL_75c16c4807d1a3963546d53942756918,long)> datasetGetProposalTypes(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("b_CyA_AdminCommissionsLeasing.ProposalsListViewer.GetProposalTypes", "c9bd479a-57b8-4296-8c69-36b77e2bc7fb");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("ProposalsListViewer","b_CyA_AdminCommissionsLeasing.ProposalsListViewer.GetProposalTypes");
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
selectBuilder.Append("/* /NRWebFlows.Qwoh9BhTeEOXvq3lBDkhrg/NodesShownInESpaceTree.uPuycxfGVECtMNcfIiDjvQ/ScreenDataSets.mke9ybhXlkKMaTa3fivH+w, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enproposaltype11\".\"id\" o0, \"enproposaltype11\".\"label\" o1, NULL o2, NULL o3");
fromBuilder.Append(" FROM {ProposalType} \"enproposaltype11\"");
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
RL_75c16c4807d1a3963546d53942756918 outParamList = new RL_75c16c4807d1a3963546d53942756918();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query b_CyA_AdminCommissionsLeasing.ProposalsListViewer.GetProposalTypes.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_75c16c4807d1a3963546d53942756918 _tmp = new RL_75c16c4807d1a3963546d53942756918();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query b_CyA_AdminCommissionsLeasing.ProposalsListViewer.GetProposalTypes.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_75c16c4807d1a3963546d53942756918)_tmp;
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

private static async Task<RC_ce0b7a0d9784faac9b31d2f092421318> datasetGetProposalsReadDbAsync(RC_ce0b7a0d9784faac9b31d2f092421318 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENBank.Read( r, ref index);
rec.ssENCurrency.Read( r, ref index);
rec.ssENFileExtended.Read( r, ref index);
rec.ssENProposal.Read( r, ref index);
rec.ssENProposalStatus.Read( r, ref index);
rec.ssENProposalType.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENUploadedBy.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
return rec;
}
// Query Function "GetProposals" UfJB_KMQt0a4rz99TXRVMQ of Action "ProposalsListViewer"
public static async Task<(RL_8ba5b56e8055656db873b3771bf59d3c,long)> datasetGetProposals(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,decimal qpdeProposals_AmountMLFrom,decimal qpdeProposals_AmountMLTo,long qpbaProposal_BankId,string qpcuCurrency_Code,DateTime qpdaProposals_PaymentDateFrom,DateTime qpdaProposals_PaymentDateTo,string qpteProposals_ProposalSearch,int qpprProposal_ProposalStatusId,int qpprProposal_ProposalTypeId,int qpinProposals_UploadType,string qpusUser_Extended_Internal_Id,string qptel_TableSort,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("b_CyA_AdminCommissionsLeasing.ProposalsListViewer.GetProposals", "fc41f251-10a3-46b7-b8af-3f7d4d745531");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("ProposalsListViewer","b_CyA_AdminCommissionsLeasing.ProposalsListViewer.GetProposals");
// Query Iterations: Multiple
// Refresh Query AXXF6HVLq0eLgJLzd8wbyw Iterations: Multiple
// Refresh Query NtcfkWztO0KLsiHpJpVdxg Iterations: Multiple
// Refresh Query 4X3aXgLxl0CraB5fwxB1FQ Iterations: Multiple
// Refresh Query OfKao3QmHE6xGX95Ai2TEw Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.Qwoh9BhTeEOXvq3lBDkhrg/NodesShownInESpaceTree.uPuycxfGVECtMNcfIiDjvQ/ScreenDataSets.UfJB_KMQt0a4rz99TXRVMQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enbank14\".\"name\" o1, NULL o2, NULL o3, NULL o4, NULL o5, \"encurrency39\".\"code\" o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, \"enfileextended9\".\"filename\" o12, \"enfileextended9\".\"isprocessed\" o13, \"enfileextended9\".\"haserror\" o14, NULL o15, \"enfileextended9\".\"uploadedby\" o16, NULL o17, \"enproposal26\".\"id\" o18, \"enproposal26\".\"name\" o19, \"enproposal26\".\"paymentdate\" o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, trim_scale(\"enproposal26\".\"totalvalueml\"::numeric) o27, NULL o28, NULL o29, NULL o30, NULL o31, \"enproposal26\".\"createdon\" o32, NULL o33, NULL o34, NULL o35, NULL o36, \"enproposalstatus13\".\"label\" o37, \"enproposalstatus13\".\"class\" o38, NULL o39, NULL o40, NULL o41, \"enproposaltype12\".\"label\" o42, NULL o43, NULL o44, NULL o45, NULL o46, \"enregion172\".\"name\" o47, NULL o48, NULL o49, \"enregion172\".\"commissionregion\" o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, \"enuploadedby\".\"name\" o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87");
fromBuilder.Append(" FROM ((((((((({FileExtended} \"enfileextended9\" Left JOIN {User} \"enuploadedby\" ON (\"enfileextended9\".\"uploadedby\" = \"enuploadedby\".\"id\"))  Left JOIN {Proposal} \"enproposal26\" ON (\"enfileextended9\".\"id\" = \"enproposal26\".\"fileid\"))  Left JOIN {User} \"enuser215\" ON (\"enfileextended9\".\"uploadedby\" = \"enuser215\".\"id\"))  Left JOIN {ProposalType} \"enproposaltype12\" ON (\"enproposal26\".\"proposaltypeid\" = \"enproposaltype12\".\"id\"))  Left JOIN {ProposalStatus} \"enproposalstatus13\" ON (\"enproposal26\".\"proposalstatusid\" = \"enproposalstatus13\".\"id\"))  Left JOIN {Bank} \"enbank14\" ON (\"enproposal26\".\"bankid\" = \"enbank14\".\"id\"))  Full JOIN {Region} \"enregion172\" ON (\"enproposal26\".\"regionid\" = \"enregion172\".\"id\"))  Inner JOIN {User_Extended_Internal} \"enuser_extended_internal126\" ON ((\"enregion172\".\"id\" = \"enuser_extended_internal126\".\"regionid\") AND ");
if ((qpusUser_Extended_Internal_Id.Trim()!="")) {
fromBuilder.Append("((\"enuser_extended_internal126\".\"id\" = @qpusUser_Extended_Internal_Id) AND (\"enuser_extended_internal126\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Extended_Internal_Id", DbType.String, qpusUser_Extended_Internal_Id);
sqlCountCmd.CreateParameterWithoutReplacements("@qpusUser_Extended_Internal_Id", DbType.String, qpusUser_Extended_Internal_Id);
} else {
fromBuilder.Append("(\"enuser_extended_internal126\".\"id\" IS NULL)");
}
fromBuilder.Append("))  Left JOIN {Currency} \"encurrency39\" ON (\"enproposal26\".\"currencyid\" = \"encurrency39\".\"code\")) ");
whereBuilder.Append(" WHERE ");
if (qpbaProposal_BankId != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpbaProposal_BankId != 0) {
whereBuilder.Append("((\"enproposal26\".\"bankid\" = @qpbaProposal_BankId) AND (\"enproposal26\".\"bankid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpbaProposal_BankId", DbType.Int64, qpbaProposal_BankId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpbaProposal_BankId", DbType.Int64, qpbaProposal_BankId);
} else {
whereBuilder.Append("(\"enproposal26\".\"bankid\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpdeProposals_AmountMLFrom != (((decimal)0))) {
whereBuilder.Append("(\"enproposal26\".\"totalvalueml\" >= @qpdeProposals_AmountMLFrom) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpdeProposals_AmountMLFrom", DbType.Decimal, qpdeProposals_AmountMLFrom);
sqlCountCmd.CreateParameterWithoutReplacements("@qpdeProposals_AmountMLFrom", DbType.Decimal, qpdeProposals_AmountMLFrom);
}
if (qpdeProposals_AmountMLTo != (((decimal)0))) {
whereBuilder.Append("(\"enproposal26\".\"totalvalueml\" <= @qpdeProposals_AmountMLTo) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpdeProposals_AmountMLTo", DbType.Decimal, qpdeProposals_AmountMLTo);
sqlCountCmd.CreateParameterWithoutReplacements("@qpdeProposals_AmountMLTo", DbType.Decimal, qpdeProposals_AmountMLTo);
}
whereBuilder.Append("(((@qpdaProposals_PaymentDateFrom = (date '1900-01-01')) OR (\"enproposal26\".\"paymentdate\"::date >= @qpdaProposals_PaymentDateFrom::date)) AND ((@qpdaProposals_PaymentDateTo = (date '1900-01-01')) OR (\"enproposal26\".\"paymentdate\"::date <= @qpdaProposals_PaymentDateTo::date))) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpdaProposals_PaymentDateFrom", DbType.DateTime, qpdaProposals_PaymentDateFrom);
sqlCountCmd.CreateParameterWithoutReplacements("@qpdaProposals_PaymentDateFrom", DbType.DateTime, qpdaProposals_PaymentDateFrom);
sqlCmd.CreateParameterWithoutReplacements("@qpdaProposals_PaymentDateTo", DbType.DateTime, qpdaProposals_PaymentDateTo);
sqlCountCmd.CreateParameterWithoutReplacements("@qpdaProposals_PaymentDateTo", DbType.DateTime, qpdaProposals_PaymentDateTo);
if (qpprProposal_ProposalStatusId != BuiltInFunction.NullIdentifier()) {
if (qpprProposal_ProposalStatusId != 0) {
whereBuilder.Append("((\"enproposal26\".\"proposalstatusid\" = @qpprProposal_ProposalStatusId) AND (\"enproposal26\".\"proposalstatusid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprProposal_ProposalStatusId", DbType.Int32, qpprProposal_ProposalStatusId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpprProposal_ProposalStatusId", DbType.Int32, qpprProposal_ProposalStatusId);
} else {
whereBuilder.Append("(\"enproposal26\".\"proposalstatusid\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
whereBuilder.Append("(@qpboCheckUserSession = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
sqlCountCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qpcuCurrency_Code != BuiltInFunction.NullTextIdentifier()) {
if ((qpcuCurrency_Code.Trim()!="")) {
whereBuilder.Append("((\"encurrency39\".\"code\" = @qpcuCurrency_Code) AND (\"encurrency39\".\"code\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpcuCurrency_Code", DbType.String, qpcuCurrency_Code);
sqlCountCmd.CreateParameterWithoutReplacements("@qpcuCurrency_Code", DbType.String, qpcuCurrency_Code);
} else {
whereBuilder.Append("(\"encurrency39\".\"code\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpteProposals_ProposalSearch != " " && qpteProposals_ProposalSearch != "") {
whereBuilder.Append("(caseaccent_normalize(\"enproposal26\".\"name\" collate \"default\") like caseaccent_normalize((('%' || @qpteProposals_ProposalSearch) || '%') collate \"default\")) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteProposals_ProposalSearch", DbType.String, qpteProposals_ProposalSearch);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteProposals_ProposalSearch", DbType.String, qpteProposals_ProposalSearch);
}
if (qpinProposals_UploadType != 0) {
whereBuilder.Append("(((@qpinProposals_UploadType = 2) AND (\"enfileextended9\".\"uploadedby\" IS NULL)) OR ((@qpinProposals_UploadType = 1) AND (\"enfileextended9\".\"uploadedby\" IS NOT NULL))) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpinProposals_UploadType", DbType.Int32, qpinProposals_UploadType);
sqlCountCmd.CreateParameterWithoutReplacements("@qpinProposals_UploadType", DbType.Int32, qpinProposals_UploadType);
}
if (qpprProposal_ProposalTypeId != BuiltInFunction.NullIdentifier()) {
if (qpprProposal_ProposalTypeId != 0) {
whereBuilder.Append("((\"enproposal26\".\"proposaltypeid\" = @qpprProposal_ProposalTypeId) AND (\"enproposal26\".\"proposaltypeid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprProposal_ProposalTypeId", DbType.Int32, qpprProposal_ProposalTypeId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpprProposal_ProposalTypeId", DbType.Int32, qpprProposal_ProposalTypeId);
} else {
whereBuilder.Append("(\"enproposal26\".\"proposaltypeid\" IS NULL)");
}
}
string whereBuilderString = whereBuilder.ToString();
if (whereBuilderString.EndsWith(" AND ")) {
whereBuilder.Remove(whereBuilderString.Length - 5, 5);
}
orderByBuilder.Append(" ORDER BY ");
List<string> orderByColumns = new List<string>();
orderByColumns.AddRange(BaseAppUtils.ReplaceEntityReferencesAndAttributesInOrderBy(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, qptel_TableSort, new string[] { "User_Extended_Internal", "Currency", "ProposalType", "User", "FileExtended", "Proposal", "UploadedBy", "Bank", "ProposalStatus", "Region" }, new string[] { "ENUser_Extended_Internal126", "ENCurrency39", "ENProposalType12", "ENUser215", "ENFileExtended9", "ENProposal26", "ENUploadedBy", "ENBank14", "ENProposalStatus13", "ENRegion172" }, new System.Collections.Generic.Dictionary<string, string>[] { ENUser_Extended_InternalEntity.AttributesToDatabaseNamesMap(), ENCurrencyEntity.AttributesToDatabaseNamesMap(), ENProposalTypeEntity.AttributesToDatabaseNamesMap(), ENUserEntity.AttributesToDatabaseNamesMap(), ENFileExtendedEntity.AttributesToDatabaseNamesMap(), ENProposalEntity.AttributesToDatabaseNamesMap(), ENUserEntity.AttributesToDatabaseNamesMap(), ENBankEntity.AttributesToDatabaseNamesMap(), ENProposalStatusEntity.AttributesToDatabaseNamesMap(), ENRegionEntity.AttributesToDatabaseNamesMap() }).Split(','));
orderByColumns.Add("\"enproposalstatus13\".\"order\" ASC ");
orderByBuilder.Append(BaseAppUtils.GetOrderByColumnsWithoutDuplicates(orderByColumns));
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
RL_8ba5b56e8055656db873b3771bf59d3c outParamList = new RL_8ba5b56e8055656db873b3771bf59d3c();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetProposalsReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[10];
opt[0] = new BitArray(new bool[] {false, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, false, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true});
opt[4] = new BitArray(new bool[] {false, false, false, true, true, true, true, true, true, false, true, true, true, true, false, true, true, true});
opt[5] = new BitArray(new bool[] {true, false, false, false, true, false, true});
opt[6] = new BitArray(new bool[] {true, false, true, true});
opt[7] = new BitArray(new bool[] {true, false, false, true, true});
opt[8] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[9] = new BitArray(new bool[] {true, true, false, true, true, false, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query b_CyA_AdminCommissionsLeasing.ProposalsListViewer.GetProposals.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query b_CyA_AdminCommissionsLeasing.ProposalsListViewer.GetProposals.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_8ba5b56e8055656db873b3771bf59d3c _tmp = new RL_8ba5b56e8055656db873b3771bf59d3c();
_tmp.AlternateReadDbMethodAsync = datasetGetProposalsReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query b_CyA_AdminCommissionsLeasing.ProposalsListViewer.GetProposals.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_8ba5b56e8055656db873b3771bf59d3c)_tmp;
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query b_CyA_AdminCommissionsLeasing.ProposalsListViewer.GetProposals.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
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


    public class lcvGetUploadType : VarsBag {
public Actions.lcoGetUploadType resGetUploadType =  new Actions.lcoGetUploadType();
public lcvGetUploadType() {
}
}
public class lcoGetUploadType : VarsBag {
public RL_a579a1a05eaaba551100ea61f4cb3f6b outParamList = new RL_a579a1a05eaaba551100ea61f4cb3f6b();

public lcoGetUploadType() {
}
}
/// <summary>
/// Action <code>GetUploadType</code> that represents the Service Studio action
///  <code>GetUploadType</code> <p> Description: </p>
/// </summary>
public async Task<RL_a579a1a05eaaba551100ea61f4cb3f6b> DataActionGetUploadType(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_a579a1a05eaaba551100ea61f4cb3f6b outParamList = default;
lcoGetUploadType result = new lcoGetUploadType();
lcvGetUploadType localVars = new lcvGetUploadType();
ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsListViewer_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetUploadType", "176f69f8-dc8f-4dca-9732-661ab99658c9"))
using (activitySource.CreateScreenDataActionActivity("ProposalsListViewer", "GetUploadType")){
// GetUploadType
localVars.resGetUploadType.outParamKeyvaluelist = await Actions.ActionGetUploadType(requestContext,cancellationToken);

// List = GetUploadType.Keyvaluelist
result.outParamList=localVars.resGetUploadType.outParamKeyvaluelist;
} //close CreateActionActivity using block
} // try

finally {
outParamList = result.outParamList;
} // inner-finally
RETURN_STATEMENT:
return outParamList;
}


    public static class FuncDataActionGetUploadType {
}


}
