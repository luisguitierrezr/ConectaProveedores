using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsList_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsList_ScreenModel).Namespace);

    public string varLcl_TableSort;
public int varLcl_StartIndex;
public bool varLcl_ShowFilters;
public DateTime varLcl_RefeshSideBar;
public bool varLcl_ReInvokeToggler;
public string varLcl_ColumnJSONVarGetProposal;
public int varLcl_CountAfterFetchGetProposal;
public bool varLcl_Loading;
public bool varLcIsBusy;
public bool varLcl_IsAutoRefresh;
public string varLcl_AmountFromText;
public string varLcl_AmountToText;
public RL_c0f17d75c546075264f5d075e00ba65b varLcl_SelectedRegions;
public RL_c0f17d75c546075264f5d075e00ba65b varLcl_SelectedCurrency;
public RL_c0f17d75c546075264f5d075e00ba65b varLcl_SelectedStatus;
public AggregateRecord<RL_0fc5fa92a15115f6e97a1071c9876bcd> ScreenDataSetGetBanks;
public AggregateRecord<RL_75c16c4807d1a3963546d53942756918> ScreenDataSetGetProposalTypes;
public AggregateRecord<RL_1353a59e0688582d82bbddc41b47193e> ScreenDataSetGetCurrencies;
public AggregateRecord<RL_5d3a02aa993c7474297e33d992f39ad0> ScreenDataSetGetRegions;
public AggregateRecord<RL_f03e17396f660361b67a45f0e1101893> ScreenDataSetGetOperators;
public ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsList_DataActionGetUploadType_Model varLcGetUploadType;
public ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsList_DataActionGetProposalStatus_Model varLcGetProposalStatus;
public ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsList_DataActionGetProposal_Model varLcGetProposal;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsList_ScreenModel() {
}



    public ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsList_ScreenModel(string varLcl_TableSort, int varLcl_StartIndex, bool varLcl_ShowFilters, DateTime varLcl_RefeshSideBar, bool varLcl_ReInvokeToggler, string varLcl_ColumnJSONVarGetProposal, int varLcl_CountAfterFetchGetProposal, bool varLcl_Loading, bool varLcIsBusy, bool varLcl_IsAutoRefresh, string varLcl_AmountFromText, string varLcl_AmountToText, RL_c0f17d75c546075264f5d075e00ba65b varLcl_SelectedRegions, RL_c0f17d75c546075264f5d075e00ba65b varLcl_SelectedCurrency, RL_c0f17d75c546075264f5d075e00ba65b varLcl_SelectedStatus, AggregateRecord<RL_0fc5fa92a15115f6e97a1071c9876bcd> ScreenDataSetGetBanks, AggregateRecord<RL_75c16c4807d1a3963546d53942756918> ScreenDataSetGetProposalTypes, AggregateRecord<RL_1353a59e0688582d82bbddc41b47193e> ScreenDataSetGetCurrencies, AggregateRecord<RL_5d3a02aa993c7474297e33d992f39ad0> ScreenDataSetGetRegions, AggregateRecord<RL_f03e17396f660361b67a45f0e1101893> ScreenDataSetGetOperators, ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsList_DataActionGetUploadType_Model varLcGetUploadType, ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsList_DataActionGetProposalStatus_Model varLcGetProposalStatus, ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsList_DataActionGetProposal_Model varLcGetProposal, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"l_TableSort", "l_StartIndex", "l_ShowFilters", "l_RefeshSideBar", "l_ReInvokeToggler", "l_ColumnJSONVarGetProposal", "l_CountAfterFetchGetProposal", "l_Loading", "IsBusy", "l_IsAutoRefresh", "l_AmountFromText", "l_AmountToText", "l_SelectedRegions", "l_SelectedCurrency", "l_SelectedStatus", "GetBanks", "GetProposalTypes", "GetCurrencies", "GetRegions", "GetOperators", "GetUploadType", "GetProposalStatus", "GetProposal", "ClientVars"}, new string[] {"varLcl_TableSort", "varLcl_StartIndex", "varLcl_ShowFilters", "varLcl_RefeshSideBar", "varLcl_ReInvokeToggler", "varLcl_ColumnJSONVarGetProposal", "varLcl_CountAfterFetchGetProposal", "varLcl_Loading", "varLcIsBusy", "varLcl_IsAutoRefresh", "varLcl_AmountFromText", "varLcl_AmountToText", "varLcl_SelectedRegions", "varLcl_SelectedCurrency", "varLcl_SelectedStatus", "ScreenDataSetGetBanks", "ScreenDataSetGetProposalTypes", "ScreenDataSetGetCurrencies", "ScreenDataSetGetRegions", "ScreenDataSetGetOperators", "varLcGetUploadType", "varLcGetProposalStatus", "varLcGetProposal", "clientVariables"});
this.varLcl_TableSort = varLcl_TableSort;
this.varLcl_StartIndex = varLcl_StartIndex;
this.varLcl_ShowFilters = varLcl_ShowFilters;
this.varLcl_RefeshSideBar = varLcl_RefeshSideBar;
this.varLcl_ReInvokeToggler = varLcl_ReInvokeToggler;
this.varLcl_ColumnJSONVarGetProposal = varLcl_ColumnJSONVarGetProposal;
this.varLcl_CountAfterFetchGetProposal = varLcl_CountAfterFetchGetProposal;
this.varLcl_Loading = varLcl_Loading;
this.varLcIsBusy = varLcIsBusy;
this.varLcl_IsAutoRefresh = varLcl_IsAutoRefresh;
this.varLcl_AmountFromText = varLcl_AmountFromText;
this.varLcl_AmountToText = varLcl_AmountToText;
this.varLcl_SelectedRegions = varLcl_SelectedRegions;
this.varLcl_SelectedCurrency = varLcl_SelectedCurrency;
this.varLcl_SelectedStatus = varLcl_SelectedStatus;
this.ScreenDataSetGetBanks = ScreenDataSetGetBanks;
this.ScreenDataSetGetProposalTypes = ScreenDataSetGetProposalTypes;
this.ScreenDataSetGetCurrencies = ScreenDataSetGetCurrencies;
this.ScreenDataSetGetRegions = ScreenDataSetGetRegions;
this.ScreenDataSetGetOperators = ScreenDataSetGetOperators;
this.varLcGetUploadType = varLcGetUploadType;
this.varLcGetProposalStatus = varLcGetProposalStatus;
this.varLcGetProposal = varLcGetProposal;
this.clientVariables = clientVariables;
}



    
// Query Function "GetBanks" _8gML_nxREupHHJdFwrpKA of Action "ProposalsList"
public static async Task<(RL_0fc5fa92a15115f6e97a1071c9876bcd,long)> datasetGetBanks(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("b_CyA_AdminCommissionsLeasing.ProposalsList.GetBanks", "2f0cc8ff-f1f9-4b44-a91c-725d170ae928");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("ProposalsList","b_CyA_AdminCommissionsLeasing.ProposalsList.GetBanks");
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
selectBuilder.Append("/* /NRWebFlows.Qwoh9BhTeEOXvq3lBDkhrg/NodesShownInESpaceTree.bbcbKG1CQUmC8rrFaq7cvw/ScreenDataSets._8gML_nxREupHHJdFwrpKA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enbank11\".\"id\" o0, \"enbank11\".\"name\" o1, NULL o2, NULL o3, NULL o4, NULL o5");
fromBuilder.Append(" FROM {Bank} \"enbank11\"");
whereBuilder.Append(" WHERE (\"enbank11\".\"isactive\" = 1) AND (@qpboCheckUserSession = 1)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query b_CyA_AdminCommissionsLeasing.ProposalsList.GetBanks.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query b_CyA_AdminCommissionsLeasing.ProposalsList.GetBanks.List", cancellationToken: cancellationToken);
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

// Query Function "GetProposalTypes" LD2nWuqN40+EXJFXF40+XA of Action "ProposalsList"
public static async Task<(RL_75c16c4807d1a3963546d53942756918,long)> datasetGetProposalTypes(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("b_CyA_AdminCommissionsLeasing.ProposalsList.GetProposalTypes", "5aa73d2c-8dea-4fe3-845c-9157178d3e5c");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("ProposalsList","b_CyA_AdminCommissionsLeasing.ProposalsList.GetProposalTypes");
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
selectBuilder.Append("/* /NRWebFlows.Qwoh9BhTeEOXvq3lBDkhrg/NodesShownInESpaceTree.bbcbKG1CQUmC8rrFaq7cvw/ScreenDataSets.LD2nWuqN40+EXJFXF40+XA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enproposaltype9\".\"id\" o0, \"enproposaltype9\".\"label\" o1, NULL o2, NULL o3");
fromBuilder.Append(" FROM {ProposalType} \"enproposaltype9\"");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query b_CyA_AdminCommissionsLeasing.ProposalsList.GetProposalTypes.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query b_CyA_AdminCommissionsLeasing.ProposalsList.GetProposalTypes.List", cancellationToken: cancellationToken);
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

// Query Function "GetCurrencies" 15E2bK0mZUSnAZMeL9s4jw of Action "ProposalsList"
public static async Task<(RL_1353a59e0688582d82bbddc41b47193e,long)> datasetGetCurrencies(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("b_CyA_AdminCommissionsLeasing.ProposalsList.GetCurrencies", "6c3691d7-26ad-4465-a701-931e2fdb388f");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("ProposalsList","b_CyA_AdminCommissionsLeasing.ProposalsList.GetCurrencies");
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
selectBuilder.Append("/* /NRWebFlows.Qwoh9BhTeEOXvq3lBDkhrg/NodesShownInESpaceTree.bbcbKG1CQUmC8rrFaq7cvw/ScreenDataSets.15E2bK0mZUSnAZMeL9s4jw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"encurrency36\".\"code\" o0, \"encurrency36\".\"name\" o1, NULL o2, NULL o3, NULL o4");
fromBuilder.Append(" FROM {Currency} \"encurrency36\"");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query b_CyA_AdminCommissionsLeasing.ProposalsList.GetCurrencies.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query b_CyA_AdminCommissionsLeasing.ProposalsList.GetCurrencies.List", cancellationToken: cancellationToken);
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

// Query Function "GetRegions" VHsynCaYWkaWiM1GRMUjww of Action "ProposalsList"
public static async Task<(RL_5d3a02aa993c7474297e33d992f39ad0,long)> datasetGetRegions(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("b_CyA_AdminCommissionsLeasing.ProposalsList.GetRegions", "9c327b54-9826-465a-9688-cd4644c523c3");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("ProposalsList","b_CyA_AdminCommissionsLeasing.ProposalsList.GetRegions");
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
selectBuilder.Append("/* /NRWebFlows.Qwoh9BhTeEOXvq3lBDkhrg/NodesShownInESpaceTree.bbcbKG1CQUmC8rrFaq7cvw/ScreenDataSets.VHsynCaYWkaWiM1GRMUjww, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enregion170\".\"id\" o0, NULL o1, \"enregion170\".\"name\" o2, NULL o3, NULL o4, \"enregion170\".\"commissionregion\" o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12");
fromBuilder.Append(" FROM {Region} \"enregion170\"");
whereBuilder.Append(" WHERE (\"enregion170\".\"isactive\" = 1) AND (@qpboCheckUserSession = 1)");
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
RL_5d3a02aa993c7474297e33d992f39ad0 outParamList = new RL_5d3a02aa993c7474297e33d992f39ad0();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, false, true, true, false, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query b_CyA_AdminCommissionsLeasing.ProposalsList.GetRegions.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_5d3a02aa993c7474297e33d992f39ad0 _tmp = new RL_5d3a02aa993c7474297e33d992f39ad0();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query b_CyA_AdminCommissionsLeasing.ProposalsList.GetRegions.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_5d3a02aa993c7474297e33d992f39ad0)_tmp;
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

// Query Function "GetOperators" CtaprW+v0ku5lMHFiMV1tg of Action "ProposalsList"
public static async Task<(RL_f03e17396f660361b67a45f0e1101893,long)> datasetGetOperators(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("b_CyA_AdminCommissionsLeasing.ProposalsList.GetOperators", "ada9d60a-af6f-4bd2-b994-c1c588c575b6");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("ProposalsList","b_CyA_AdminCommissionsLeasing.ProposalsList.GetOperators");
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
selectBuilder.Append("/* /NRWebFlows.Qwoh9BhTeEOXvq3lBDkhrg/NodesShownInESpaceTree.bbcbKG1CQUmC8rrFaq7cvw/ScreenDataSets.CtaprW+v0ku5lMHFiMV1tg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3");
fromBuilder.Append(" FROM {Operator} \"enoperator2\"");
whereBuilder.Append(" WHERE (\"enoperator2\".\"is_active\" = 1) AND (@qpboCheckUserSession = 1)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query b_CyA_AdminCommissionsLeasing.ProposalsList.GetOperators.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query b_CyA_AdminCommissionsLeasing.ProposalsList.GetOperators.List", cancellationToken: cancellationToken);
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
ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsList_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetUploadType", "57bb37c3-3337-4615-9d65-1682dda5beb3"))
using (activitySource.CreateScreenDataActionActivity("ProposalsList", "GetUploadType")){
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
public class lcvGetProposalStatus : VarsBag {
public RL_edf26e482e095588ed6d5cbd5313bc7f queryResProposalStatus_outParamList = new RL_edf26e482e095588ed6d5cbd5313bc7f();
public long queryResProposalStatus_outParamCount = 0L;

public RL_edf26e482e095588ed6d5cbd5313bc7f queryResProposalPreSelectedStatus_outParamList = new RL_edf26e482e095588ed6d5cbd5313bc7f();
public long queryResProposalPreSelectedStatus_outParamCount = 0L;

public lcvGetProposalStatus() {
}
}
public class lcoGetProposalStatus : VarsBag {
public RL_04d8560c4ed76bbcba77135048f4ff7f outParamList = new RL_04d8560c4ed76bbcba77135048f4ff7f();

public RL_04d8560c4ed76bbcba77135048f4ff7f outParamPreSelected = new RL_04d8560c4ed76bbcba77135048f4ff7f();

public lcoGetProposalStatus() {
}
}
/// <summary>
/// Action <code>GetProposalStatus</code> that represents the Service Studio action
///  <code>GetProposalStatus</code> <p> Description: </p>
/// </summary>
public async Task<(RL_04d8560c4ed76bbcba77135048f4ff7f,RL_04d8560c4ed76bbcba77135048f4ff7f)> DataActionGetProposalStatus(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_04d8560c4ed76bbcba77135048f4ff7f outParamList = default;
RL_04d8560c4ed76bbcba77135048f4ff7f outParamPreSelected = default;
lcoGetProposalStatus result = new lcoGetProposalStatus();
lcvGetProposalStatus localVars = new lcvGetProposalStatus();
ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsList_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetProposalStatus", "818030a9-aeee-4107-9971-62e1dd2222ce"))
using (activitySource.CreateScreenDataActionActivity("ProposalsList", "GetProposalStatus")){
// Query datasetProposalStatus
cancellationToken.ThrowIfCancellationRequested();
int datasetProposalStatus_maxRecords = 999999;
if (datasetProposalStatus_maxRecords < 1) datasetProposalStatus_maxRecords = 1;
int datasetProposalStatus_startIndex = 0;(localVars.queryResProposalStatus_outParamList,localVars.queryResProposalStatus_outParamCount) = await FuncDataActionGetProposalStatus.datasetProposalStatus(requestContext,datasetProposalStatus_maxRecords,datasetProposalStatus_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),cancellationToken);

// Query datasetProposalPreSelectedStatus
cancellationToken.ThrowIfCancellationRequested();
int datasetProposalPreSelectedStatus_maxRecords = 999999;
if (datasetProposalPreSelectedStatus_maxRecords < 1) datasetProposalPreSelectedStatus_maxRecords = 1;
int datasetProposalPreSelectedStatus_startIndex = 0;(localVars.queryResProposalPreSelectedStatus_outParamList,localVars.queryResProposalPreSelectedStatus_outParamCount) = await FuncDataActionGetProposalStatus.datasetProposalPreSelectedStatus(requestContext,datasetProposalPreSelectedStatus_maxRecords,datasetProposalPreSelectedStatus_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),cancellationToken);

// List = ProposalStatus.List
result.outParamList=(await RL_04d8560c4ed76bbcba77135048f4ff7f.ConvertAsync(localVars.queryResProposalStatus_outParamList, new RL_04d8560c4ed76bbcba77135048f4ff7f(), async (RC_5627f7a3ec063e602863ee6b4dd816a2 source, EN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord target, CancellationToken cancellationToken) => {
target = source;
return target;
}, cancellationToken));

// PreSelected = ProposalPreSelectedStatus.List
result.outParamPreSelected=(await RL_04d8560c4ed76bbcba77135048f4ff7f.ConvertAsync(localVars.queryResProposalPreSelectedStatus_outParamList, new RL_04d8560c4ed76bbcba77135048f4ff7f(), async (RC_5627f7a3ec063e602863ee6b4dd816a2 source, EN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord target, CancellationToken cancellationToken) => {
target = source;
return target;
}, cancellationToken));
} //close CreateActionActivity using block
} // try

finally {
outParamList = result.outParamList;
outParamPreSelected = result.outParamPreSelected;
} // inner-finally
RETURN_STATEMENT:
return (outParamList,outParamPreSelected);
}
public class lcvGetProposal : VarsBag {
public RL_6fbd57060cf755f3c77e73cfe2e2b04c queryResGetProposals_outParamList = new RL_6fbd57060cf755f3c77e73cfe2e2b04c();
public long queryResGetProposals_outParamCount = 0L;

public RL_0b8b481397d3c2af696e2a2d3956b721 queryResGetProposalsSum_outParamList = new RL_0b8b481397d3c2af696e2a2d3956b721();
public long queryResGetProposalsSum_outParamCount = 0L;

public RLIntegerLiteralRecordList queryResGetProposalsCount_outParamList = new RLIntegerLiteralRecordList();
public long queryResGetProposalsCount_outParamCount = 0L;

public lcvGetProposal() {
}
}
public class lcoGetProposal : VarsBag {
public RL_6fbd57060cf755f3c77e73cfe2e2b04c outParamList = new RL_6fbd57060cf755f3c77e73cfe2e2b04c();

public int outParamCount = 0;

public decimal outParamSum = 0.0M;

public lcoGetProposal() {
}
}
/// <summary>
/// Action <code>GetProposal</code> that represents the Service Studio action <code>GetProposal</code>
///  <p> Description: </p>
/// </summary>
public async Task<(RL_6fbd57060cf755f3c77e73cfe2e2b04c,int,decimal)> DataActionGetProposal(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_6fbd57060cf755f3c77e73cfe2e2b04c outParamList = default;
int outParamCount = default;
decimal outParamSum = default;
lcoGetProposal result = new lcoGetProposal();
lcvGetProposal localVars = new lcvGetProposal();
ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsList_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetProposal", "b7b7c131-6d62-42f1-a2a7-e74694c247c5"))
using (activitySource.CreateScreenDataActionActivity("ProposalsList", "GetProposal")){
// Query QueryGetProposals
cancellationToken.ThrowIfCancellationRequested();
int QueryGetProposals_maxRecords = 0;
int QueryGetProposals_startIndex = 0;(localVars.queryResGetProposals_outParamList,localVars.queryResGetProposals_outParamCount) = await FuncDataActionGetProposal.QueryGetProposals(requestContext,QueryGetProposals_maxRecords,QueryGetProposals_startIndex,IterationMultiplicity.Multiple,(("("+model.clientVariables.ssProposals_Regions)+")"),model.clientVariables.ssProposals_Bank,model.clientVariables.ssProposals_AmountMLFrom,model.clientVariables.ssProposals_AmountMLTo,model.clientVariables.ssProposals_PaymentDateFrom,model.clientVariables.ssProposals_PaymentDateTo,(("("+model.clientVariables.ssProposals_Statuses)+")"),(("("+model.clientVariables.ssProposals_Currencies)+")"),model.clientVariables.ssProposals_ProposalSearch,model.clientVariables.ssProposals_UploadType,model.clientVariables.ssProposals_Type,BuiltInFunction.NullDate (),model.clientVariables.ssMaxRecords,varLcl_StartIndex,(await Functions.ActionEncodeSortForSQL(requestContext,varLcl_TableSort,cancellationToken)),cancellationToken);

// Query QueryGetProposalsCount
cancellationToken.ThrowIfCancellationRequested();
int QueryGetProposalsCount_maxRecords = 0;
int QueryGetProposalsCount_startIndex = 0;(localVars.queryResGetProposalsCount_outParamList,localVars.queryResGetProposalsCount_outParamCount) = await FuncDataActionGetProposal.QueryGetProposalsCount(requestContext,QueryGetProposalsCount_maxRecords,QueryGetProposalsCount_startIndex,IterationMultiplicity.Never,(("("+model.clientVariables.ssProposals_Regions)+")"),model.clientVariables.ssProposals_Bank,model.clientVariables.ssProposals_AmountMLFrom,model.clientVariables.ssProposals_AmountMLTo,model.clientVariables.ssProposals_PaymentDateFrom,model.clientVariables.ssProposals_PaymentDateTo,(("("+model.clientVariables.ssProposals_Statuses)+")"),(("("+model.clientVariables.ssProposals_Currencies)+")"),model.clientVariables.ssProposals_ProposalSearch,model.clientVariables.ssProposals_UploadType,model.clientVariables.ssProposals_Type,BuiltInFunction.NullDate (),cancellationToken);

// Query QueryGetProposalsSum
cancellationToken.ThrowIfCancellationRequested();
int QueryGetProposalsSum_maxRecords = 0;
int QueryGetProposalsSum_startIndex = 0;(localVars.queryResGetProposalsSum_outParamList,localVars.queryResGetProposalsSum_outParamCount) = await FuncDataActionGetProposal.QueryGetProposalsSum(requestContext,QueryGetProposalsSum_maxRecords,QueryGetProposalsSum_startIndex,IterationMultiplicity.Never,(("("+model.clientVariables.ssProposals_Regions)+")"),model.clientVariables.ssProposals_Bank,model.clientVariables.ssProposals_AmountMLFrom,model.clientVariables.ssProposals_AmountMLTo,model.clientVariables.ssProposals_PaymentDateFrom,model.clientVariables.ssProposals_PaymentDateTo,(("("+model.clientVariables.ssProposals_Statuses)+")"),(("("+model.clientVariables.ssProposals_Currencies)+")"),model.clientVariables.ssProposals_ProposalSearch,model.clientVariables.ssProposals_UploadType,model.clientVariables.ssProposals_Type,BuiltInFunction.NullDate (),cancellationToken);

// List = GetProposals.List
result.outParamList=localVars.queryResGetProposals_outParamList;

// Count = LongIntegerToInteger
result.outParamCount=BuiltInFunction.LongIntegerToInteger (localVars.queryResGetProposalsCount_outParamList.CurrentRec.ssSTIntegerLiteral.ssValue);

// Sum = GetProposalsSum.List.Current.Decimal.Value
result.outParamSum=localVars.queryResGetProposalsSum_outParamList.CurrentRec.ssSTDecimal.ssValue;
} //close CreateActionActivity using block
} // try

finally {
outParamList = result.outParamList;
outParamCount = result.outParamCount;
outParamSum = result.outParamSum;
} // inner-finally
RETURN_STATEMENT:
return (outParamList,outParamCount,outParamSum);
}


    public static class FuncDataActionGetUploadType {
}
public static class FuncDataActionGetProposalStatus {

// Query Function "ProposalStatus" Zh5uUneImECwxferZI05mg of Action "GetProposalStatus"
public static async Task<(RL_edf26e482e095588ed6d5cbd5313bc7f,long)> datasetProposalStatus(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("b_CyA_AdminCommissionsLeasing.ProposalsList.GetProposalStatus.ProposalStatus", "526e1e66-8877-4098-b0c5-f7ab648d399a");
using var queryActivity = activitySource.CreateAggregateQueryActivity("b_CyA_AdminCommissionsLeasing.ProposalsList.GetProposalStatus.ProposalStatus", "526e1e66-8877-4098-b0c5-f7ab648d399a", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.Qwoh9BhTeEOXvq3lBDkhrg/NodesShownInESpaceTree.bbcbKG1CQUmC8rrFaq7cvw/DataActions.qTCAge6uB0GZcWLh3SIizg/NodesNotShownInESpaceTree.Zh5uUneImECwxferZI05mg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enproposalstatus9\".\"id\" o0, \"enproposalstatus9\".\"label\" o1, NULL o2, NULL o3, NULL o4");
fromBuilder.Append(" FROM {ProposalStatus} \"enproposalstatus9\"");
whereBuilder.Append(" WHERE (\"enproposalstatus9\".\"is_active\" = 1) AND (@qpboCheckUserSession = 1)");
orderByBuilder.Append(" ORDER BY \"enproposalstatus9\".\"label\" ASC ");
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
RL_edf26e482e095588ed6d5cbd5313bc7f outParamList = new RL_edf26e482e095588ed6d5cbd5313bc7f();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query b_CyA_AdminCommissionsLeasing.ProposalsList.GetProposalStatus.ProposalStatus.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query b_CyA_AdminCommissionsLeasing.ProposalsList.GetProposalStatus.ProposalStatus.List", cancellationToken: cancellationToken);
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

// Query Function "ProposalPreSelectedStatus" mvlZXCV_lkCHsBBmvshsQQ of Action "GetProposalStatus"
public static async Task<(RL_edf26e482e095588ed6d5cbd5313bc7f,long)> datasetProposalPreSelectedStatus(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("b_CyA_AdminCommissionsLeasing.ProposalsList.GetProposalStatus.ProposalPreSelectedStatus", "5c59f99a-7f25-4096-87b0-1066bec86c41");
using var queryActivity = activitySource.CreateAggregateQueryActivity("b_CyA_AdminCommissionsLeasing.ProposalsList.GetProposalStatus.ProposalPreSelectedStatus", "5c59f99a-7f25-4096-87b0-1066bec86c41", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.Qwoh9BhTeEOXvq3lBDkhrg/NodesShownInESpaceTree.bbcbKG1CQUmC8rrFaq7cvw/DataActions.qTCAge6uB0GZcWLh3SIizg/NodesNotShownInESpaceTree.mvlZXCV_lkCHsBBmvshsQQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enproposalstatus10\".\"id\" o0, \"enproposalstatus10\".\"label\" o1, NULL o2, NULL o3, NULL o4");
fromBuilder.Append(" FROM {ProposalStatus} \"enproposalstatus10\"");
whereBuilder.Append(" WHERE (\"enproposalstatus10\".\"is_active\" = 1) AND (@qpboCheckUserSession = 1) AND ((\"enproposalstatus10\".\"id\" <> ");
whereBuilder.Append((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("OSpEADv8F0q4Sge4sU9mWA"))).ssId);
whereBuilder.Append(") AND (\"enproposalstatus10\".\"id\" <> ");
whereBuilder.Append((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("uL8+MGLLsUGnVkTyfH8gIw"))).ssId);
whereBuilder.Append("))");
orderByBuilder.Append(" ORDER BY \"enproposalstatus10\".\"label\" ASC ");
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
RL_edf26e482e095588ed6d5cbd5313bc7f outParamList = new RL_edf26e482e095588ed6d5cbd5313bc7f();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query b_CyA_AdminCommissionsLeasing.ProposalsList.GetProposalStatus.ProposalPreSelectedStatus.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query b_CyA_AdminCommissionsLeasing.ProposalsList.GetProposalStatus.ProposalPreSelectedStatus.List", cancellationToken: cancellationToken);
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
}
public static class FuncDataActionGetProposal {

private static async Task<RC_8d415889034a2c958f8f82d7128f2067> QueryGetProposalsReadDbAsync(RC_8d415889034a2c958f8f82d7128f2067 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFileExtended.Read(r, ref index);
rec.ssENBank.Read(r, ref index);
rec.ssENCurrency.Read(r, ref index);
rec.ssENProposal.Read(r, ref index);
rec.ssENProposalStatus.Read(r, ref index);
rec.ssENProposalType.Read(r, ref index);
rec.ssENRegion.Read(r, ref index);
rec.ssENUploadedBy.Read(r, ref index);
return rec;
}
// Query Function "GetProposals" KQ4gFmfrsEKrZtm5QnszMg of Action "GetProposal"
public static async Task<(RL_6fbd57060cf755f3c77e73cfe2e2b04c,long)> QueryGetProposals(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteProposals_Region,long qpbaProposals_Bank,decimal qpcuProposals_AmountMLFrom,decimal qpcuProposals_AmountMLTo,DateTime qpdaProposals_PaymentDateFrom,DateTime qpdaProposals_PaymentDateTo,string qpteProposals_Status,string qpteProposals_Currency,string qpteProposals_ProposalSearch,int qpinProposals_UploadType,int qpprProposals_Type,DateTime qpdaNulldate,int qpinMaxRecords,int qpinIndex,string qpteTableSort,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("b_CyA_AdminCommissionsLeasing.ProposalsList.GetProposal.GetProposals", "16200e29-eb67-42b0-ab66-d9b9427b3332");
using var queryActivity = activitySource.CreateSqlQueryActivity("b_CyA_AdminCommissionsLeasing.ProposalsList.GetProposal.GetProposals", "16200e29-eb67-42b0-ab66-d9b9427b3332", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string entityFileExtended = AppUtils.Instance.RuntimeEntityReplace("FileExtended");
string entityBank = AppUtils.Instance.RuntimeEntityReplace("Bank");
string entityCurrency = AppUtils.Instance.RuntimeEntityReplace("Currency");
string entityProposal = AppUtils.Instance.RuntimeEntityReplace("Proposal");
string entityProposalStatus = AppUtils.Instance.RuntimeEntityReplace("ProposalStatus");
string entityProposalType = AppUtils.Instance.RuntimeEntityReplace("ProposalType");
string entityRegion = AppUtils.Instance.RuntimeEntityReplace("Region");
string entityUser = AppUtils.Instance.RuntimeEntityReplace("User");
sqlCmd.CreateParameter("@qpteProposals_Region", DbType.String, qpteProposals_Region);
sqlCmd.CreateParameter("@qpbaProposals_Bank", DbType.Int64, qpbaProposals_Bank);
sqlCmd.CreateParameter("@qpcuProposals_AmountMLFrom", DbType.Decimal, qpcuProposals_AmountMLFrom);
sqlCmd.CreateParameter("@qpcuProposals_AmountMLTo", DbType.Decimal, qpcuProposals_AmountMLTo);
sqlCmd.CreateParameter("@qpdaProposals_PaymentDateFrom", DbType.DateTime, qpdaProposals_PaymentDateFrom);
sqlCmd.CreateParameter("@qpdaNulldate", DbType.DateTime, qpdaNulldate);
sqlCmd.CreateParameter("@qpdaProposals_PaymentDateTo", DbType.DateTime, qpdaProposals_PaymentDateTo);
sqlCmd.CreateParameter("@qpteProposals_Status", DbType.String, qpteProposals_Status);
sqlCmd.CreateParameter("@qpteProposals_Currency", DbType.String, qpteProposals_Currency);
sqlCmd.CreateParameter("@qpteProposals_ProposalSearch", DbType.String, qpteProposals_ProposalSearch);
sqlCmd.CreateParameter("@qpinProposals_UploadType", DbType.Int32, qpinProposals_UploadType);
sqlCmd.CreateParameter("@qpprProposals_Type", DbType.Int32, qpprProposals_Type);
sqlCmd.CreateParameter("@qpinMaxRecords", DbType.Int32, qpinMaxRecords);
sqlCmd.CreateParameter("@qpinIndex", DbType.Int32, qpinIndex);
string sql = "";
string advSql = "SELECT \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFileExtended,".\"id\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFileExtended,".\"filename\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFileExtended,".\"isprocessed\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFileExtended,".\"haserror\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFileExtended,".\"errormessage\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFileExtended,".\"uploadedby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFileExtended,".\"uploadedon\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityBank,".\"id\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityBank,".\"name\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityBank,".\"shortname\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityBank,".\"code\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityBank,".\"isactive\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityBank,".\"order\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"code\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"name\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"symbol\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"minorunitdecimals\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"isactive\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"id\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"name\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"paymentdate\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"proposaldate\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"proposaltypeid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"bankid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"proposalstatusid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"fileid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"totalproposallines\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"totalvalueml\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"totalvaluemd\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"currencyid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"regionid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"createdby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"createdon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"lastupdatedon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"maxdatepaymentchanges\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"assignedtoid\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalStatus,".\"id\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalStatus,".\"label\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalStatus,".\"class\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalStatus,".\"order\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalStatus,".\"is_active\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalType,".\"id\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalType,".\"label\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalType,".\"order\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalType,".\"is_active\"") + ",    \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"id\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"code\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"name\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"divisionfi\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"centrortp\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"commissionregion\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"isactive\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"createdon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"createdby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"updatedon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"updatedby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"isfsp\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"isfcp\"") + ", \n    UploadedBy.* \nFROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFileExtended,"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,"") + " AS UploadedBy \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFileExtended,".\"uploadedby\"") + " = UploadedBy.\"id\" \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,"") + " \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFileExtended,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"fileid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalType,"") + " \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"proposaltypeid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalType,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalStatus,"") + " \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"proposalstatusid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalStatus,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityBank,"") + " \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"bankid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityBank,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,"") + " \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"regionid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,"") + " \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"currencyid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"code\"") + " \nWHERE \n    ( \n      @qpteProposals_Region::text = '()' \n      OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"regionid\"") + " = ANY( \n            string_to_array(trim(both '()' from @qpteProposals_Region::text), ',')::int[] \n         ) \n    ) \n \n    AND ( \n      @qpbaProposals_Bank::int = 0 \n      OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"bankid\"") + " = @qpbaProposals_Bank::int \n    ) \n \n    AND ( \n      @qpcuProposals_AmountMLFrom::numeric = 0 \n      OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"totalvalueml\"") + " >= @qpcuProposals_AmountMLFrom::numeric \n    ) \n \n    AND ( \n      @qpcuProposals_AmountMLTo::numeric = 0 \n      OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"totalvalueml\"") + " <= @qpcuProposals_AmountMLTo::numeric \n    ) \n \n    AND ( \n      ( @qpdaProposals_PaymentDateFrom::timestamp = @qpdaNulldate::timestamp \n        OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"paymentdate\"") + " >= @qpdaProposals_PaymentDateFrom::timestamp ) \n      AND \n      ( @qpdaProposals_PaymentDateTo::timestamp =@qpdaNulldate::timestamp \n        OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"paymentdate\"") + " <= @qpdaProposals_PaymentDateTo::timestamp ) \n    ) \n \n    AND \n    ( \n      @qpteProposals_Status::text = '()' \n      OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"proposalstatusid\"") + " = ANY( \n            string_to_array(trim(both '()' from @qpteProposals_Status::text), ',')::int[] \n         ) \n    ) \n \n    AND  ( \n      @qpteProposals_Currency::text  = '()' \n      OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"currencyid\"") + " = ANY( \n            string_to_array(trim(both '()' from @qpteProposals_Currency::text), ',')::text[] \n         ) \n    ) \n \n    AND ( \n        @qpteProposals_ProposalSearch::text = '' \n        OR LOWER( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"name\"") + " COLLATE \"C\") LIKE LOWER(('%' || @qpteProposals_ProposalSearch::text || '%') COLLATE \"C\") \n    ) \n \n    AND ( \n      @qpinProposals_UploadType::int = 0 \n      OR ( @qpinProposals_UploadType::int = 2 AND COALESCE( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFileExtended,".\"uploadedby\"") + "::text, '') = '') \n      OR ( @qpinProposals_UploadType::int = 1 AND COALESCE( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFileExtended,".\"uploadedby\"") + "::text, '') <> '') \n    ) \n \n    AND ( \n      @qpprProposals_Type::int = 0 \n      OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"proposaltypeid\"") + " = @qpprProposals_Type::int \n    ) \n \n    ORDER BY  " + BaseAppUtils.ReplaceEntityReferencesInParameter(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, AppUtils.Instance.ReplaceAttributeReferences(requestContext,qpteTableSort)) + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalStatus,".\"order\"") + " ASC \n    LIMIT @qpinMaxRecords::int \n    OFFSET @qpinIndex::int;";
advSql = BaseAppUtils.ReplaceEntityIdentifiers(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers,advSql);
advSql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
AppUtils.Instance.CheckReadOnlyEntityReferences(advSql);
sql = advSql;
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_6fbd57060cf755f3c77e73cfe2e2b04c outParamList = new RL_6fbd57060cf755f3c77e73cfe2e2b04c();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = QueryGetProposalsReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[8];
opt[0] = new BitArray(new bool[] {false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false});
opt[2] = new BitArray(new bool[] {false, false, false, false, false});
opt[3] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[4] = new BitArray(new bool[] {false, false, false, false, false, false, false});
opt[5] = new BitArray(new bool[] {false, false, false, false});
opt[6] = new BitArray(new bool[] {false, false, false, false, false});
opt[7] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query b_CyA_AdminCommissionsLeasing.ProposalsList.GetProposal.GetProposals.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_6fbd57060cf755f3c77e73cfe2e2b04c _tmp = new RL_6fbd57060cf755f3c77e73cfe2e2b04c();
_tmp.AlternateReadDbMethodAsync = QueryGetProposalsReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query b_CyA_AdminCommissionsLeasing.ProposalsList.GetProposal.GetProposals.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_6fbd57060cf755f3c77e73cfe2e2b04c)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetProposals in GetProposal in ProposalsList in b_CyA_AdminCommissionsLeasing in ConectaProveedores (SELECT      {FileExtended}.*,      {Bank}.*,      {Currency}.*,      {Proposal}.*,      {ProposalStatus}.*,      {ProposalType}.*,         {Region}.*,      UploadedBy.*  FROM {FileExtended}  LEFT JOIN {User} AS UploadedBy      ON {FileExtended}.[UploadedBy] = UploadedBy.[Id]  LEFT JOIN {Proposal}      ON {FileExtended}.[Id] = {Proposal}.[FileId]  LEFT JOIN {ProposalType}      ON {Proposal}.[ProposalTypeId] = {ProposalType}.[Id]  LEFT JOIN {ProposalStatus}      ON {Proposal}.[ProposalStatusId] = {ProposalStatus}.[Id]  LEFT JOIN {Bank}      ON {Proposal}.[BankId] = {Bank}.[Id]  LEFT JOIN {Region}      ON {Proposal}.[RegionId] = {Region}.[Id]  LEFT JOIN {Currency}      ON {Proposal}.[CurrencyId] = {Currency}.[Code]  WHERE      (        @Proposals_Region::text = '()'        OR {Proposal}.[RegionId] = ANY(              string_to_array(trim(both '()' from @Proposals_Region::text), ',')::int[]           )      )        AND (        @Proposals_Bank::int = 0        OR {Proposal}.[BankId] = @Pro ...): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetProposals in GetProposal in ProposalsList in b_CyA_AdminCommissionsLeasing in ConectaProveedores (SELECT      {FileExtended}.*,      {Bank}.*,      {Currency}.*,      {Proposal}.*,      {ProposalStatus}.*,      {ProposalType}.*,         {Region}.*,      UploadedBy.*  FROM {FileExtended}  LEFT JOIN {User} AS UploadedBy      ON {FileExtended}.[UploadedBy] = UploadedBy.[Id]  LEFT JOIN {Proposal}      ON {FileExtended}.[Id] = {Proposal}.[FileId]  LEFT JOIN {ProposalType}      ON {Proposal}.[ProposalTypeId] = {ProposalType}.[Id]  LEFT JOIN {ProposalStatus}      ON {Proposal}.[ProposalStatusId] = {ProposalStatus}.[Id]  LEFT JOIN {Bank}      ON {Proposal}.[BankId] = {Bank}.[Id]  LEFT JOIN {Region}      ON {Proposal}.[RegionId] = {Region}.[Id]  LEFT JOIN {Currency}      ON {Proposal}.[CurrencyId] = {Currency}.[Code]  WHERE      (        @Proposals_Region::text = '()'        OR {Proposal}.[RegionId] = ANY(              string_to_array(trim(both '()' from @Proposals_Region::text), ',')::int[]           )      )        AND (        @Proposals_Bank::int = 0        OR {Proposal}.[BankId] = @Pro ...): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetProposals in GetProposal in ProposalsList in b_CyA_AdminCommissionsLeasing in ConectaProveedores (SELECT      {FileExtended}.*,      {Bank}.*,      {Currency}.*,      {Proposal}.*,      {ProposalStatus}.*,      {ProposalType}.*,         {Region}.*,      UploadedBy.*  FROM {FileExtended}  LEFT JOIN {User} AS UploadedBy      ON {FileExtended}.[UploadedBy] = UploadedBy.[Id]  LEFT JOIN {Proposal}      ON {FileExtended}.[Id] = {Proposal}.[FileId]  LEFT JOIN {ProposalType}      ON {Proposal}.[ProposalTypeId] = {ProposalType}.[Id]  LEFT JOIN {ProposalStatus}      ON {Proposal}.[ProposalStatusId] = {ProposalStatus}.[Id]  LEFT JOIN {Bank}      ON {Proposal}.[BankId] = {Bank}.[Id]  LEFT JOIN {Region}      ON {Proposal}.[RegionId] = {Region}.[Id]  LEFT JOIN {Currency}      ON {Proposal}.[CurrencyId] = {Currency}.[Code]  WHERE      (        @Proposals_Region::text = '()'        OR {Proposal}.[RegionId] = ANY(              string_to_array(trim(both '()' from @Proposals_Region::text), ',')::int[]           )      )        AND (        @Proposals_Bank::int = 0        OR {Proposal}.[BankId] = @Pro ...): " + aqExcep.Message));
}
}
}

// Query Function "GetProposalsSum" 0495HhP4+UKDzBgMPGwy1Q of Action "GetProposal"
public static async Task<(RL_0b8b481397d3c2af696e2a2d3956b721,long)> QueryGetProposalsSum(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteProposals_Region,long qpbaProposals_Bank,decimal qpcuProposals_AmountMLFrom,decimal qpcuProposals_AmountMLTo,DateTime qpdaProposals_PaymentDateFrom,DateTime qpdaProposals_PaymentDateTo,string qpteProposals_Status,string qpteProposals_Currency,string qpteProposals_ProposalSearch,int qpinProposals_UploadType,int qpprProposals_Type,DateTime qpdaNulldate,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("b_CyA_AdminCommissionsLeasing.ProposalsList.GetProposal.GetProposalsSum", "1e798fd3-f813-42f9-83cc-180c3c6c32d5");
using var queryActivity = activitySource.CreateSqlQueryActivity("b_CyA_AdminCommissionsLeasing.ProposalsList.GetProposal.GetProposalsSum", "1e798fd3-f813-42f9-83cc-180c3c6c32d5", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string entityProposal = AppUtils.Instance.RuntimeEntityReplace("Proposal");
string entityFileExtended = AppUtils.Instance.RuntimeEntityReplace("FileExtended");
string entityUser = AppUtils.Instance.RuntimeEntityReplace("User");
string entityProposalType = AppUtils.Instance.RuntimeEntityReplace("ProposalType");
string entityProposalStatus = AppUtils.Instance.RuntimeEntityReplace("ProposalStatus");
string entityBank = AppUtils.Instance.RuntimeEntityReplace("Bank");
string entityRegion = AppUtils.Instance.RuntimeEntityReplace("Region");
string entityCurrency = AppUtils.Instance.RuntimeEntityReplace("Currency");
sqlCmd.CreateParameter("@qpteProposals_Region", DbType.String, qpteProposals_Region);
sqlCmd.CreateParameter("@qpbaProposals_Bank", DbType.Int64, qpbaProposals_Bank);
sqlCmd.CreateParameter("@qpcuProposals_AmountMLFrom", DbType.Decimal, qpcuProposals_AmountMLFrom);
sqlCmd.CreateParameter("@qpcuProposals_AmountMLTo", DbType.Decimal, qpcuProposals_AmountMLTo);
sqlCmd.CreateParameter("@qpdaProposals_PaymentDateFrom", DbType.DateTime, qpdaProposals_PaymentDateFrom);
sqlCmd.CreateParameter("@qpdaNulldate", DbType.DateTime, qpdaNulldate);
sqlCmd.CreateParameter("@qpdaProposals_PaymentDateTo", DbType.DateTime, qpdaProposals_PaymentDateTo);
sqlCmd.CreateParameter("@qpteProposals_Status", DbType.String, qpteProposals_Status);
sqlCmd.CreateParameter("@qpteProposals_Currency", DbType.String, qpteProposals_Currency);
sqlCmd.CreateParameter("@qpteProposals_ProposalSearch", DbType.String, qpteProposals_ProposalSearch);
sqlCmd.CreateParameter("@qpinProposals_UploadType", DbType.Int32, qpinProposals_UploadType);
sqlCmd.CreateParameter("@qpprProposals_Type", DbType.Int32, qpprProposals_Type);
string sql = "";
string advSql = "SELECT sum( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"totalvalueml\"") + ") \nFROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFileExtended,"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,"") + " AS UploadedBy \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFileExtended,".\"uploadedby\"") + " = UploadedBy.\"id\" \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,"") + " \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFileExtended,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"fileid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalType,"") + " \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"proposaltypeid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalType,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalStatus,"") + " \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"proposalstatusid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalStatus,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityBank,"") + " \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"bankid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityBank,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,"") + " \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"regionid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,"") + " \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"currencyid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"code\"") + " \nWHERE \n    ( \n      @qpteProposals_Region::text = '()' \n      OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"regionid\"") + " = ANY( \n            string_to_array(trim(both '()' from @qpteProposals_Region::text), ',')::int[] \n         ) \n    ) \n \n    AND ( \n      @qpbaProposals_Bank::int = 0 \n      OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"bankid\"") + " = @qpbaProposals_Bank::int \n    ) \n \n    AND ( \n      @qpcuProposals_AmountMLFrom::numeric = 0 \n      OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"totalvalueml\"") + " >= @qpcuProposals_AmountMLFrom::numeric \n    ) \n \n    AND ( \n      @qpcuProposals_AmountMLTo::numeric = 0 \n      OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"totalvalueml\"") + " <= @qpcuProposals_AmountMLTo::numeric \n    ) \n \n    AND ( \n      ( @qpdaProposals_PaymentDateFrom::timestamp = @qpdaNulldate::timestamp \n        OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"paymentdate\"") + " >= @qpdaProposals_PaymentDateFrom::timestamp ) \n      AND \n      ( @qpdaProposals_PaymentDateTo::timestamp =@qpdaNulldate::timestamp \n        OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"paymentdate\"") + " <= @qpdaProposals_PaymentDateTo::timestamp ) \n    ) \n \n    AND \n    ( \n      @qpteProposals_Status::text = '()' \n      OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"proposalstatusid\"") + " = ANY( \n            string_to_array(trim(both '()' from @qpteProposals_Status::text), ',')::int[] \n         ) \n    ) \n \n    AND  ( \n      @qpteProposals_Currency::text  = '()' \n      OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"currencyid\"") + " = ANY( \n            string_to_array(trim(both '()' from @qpteProposals_Currency::text), ',')::text[] \n         ) \n    ) \n \n    AND ( \n    @qpteProposals_ProposalSearch::text = '' \n    OR LOWER( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"name\"") + " COLLATE \"C\") LIKE LOWER(('%' || @qpteProposals_ProposalSearch::text || '%') COLLATE \"C\") \n    ) \n \n    AND ( \n      @qpinProposals_UploadType::int = 0 \n      OR ( @qpinProposals_UploadType::int = 2 AND COALESCE( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFileExtended,".\"uploadedby\"") + "::text, '') = '') \n      OR ( @qpinProposals_UploadType::int = 1 AND COALESCE( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFileExtended,".\"uploadedby\"") + "::text, '') <> '') \n    ) \n \n    AND ( \n      @qpprProposals_Type::int = 0 \n      OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"proposaltypeid\"") + " = @qpprProposals_Type::int \n    );";
sql = advSql;
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_0b8b481397d3c2af696e2a2d3956b721 outParamList = new RL_0b8b481397d3c2af696e2a2d3956b721();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query b_CyA_AdminCommissionsLeasing.ProposalsList.GetProposal.GetProposalsSum.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_0b8b481397d3c2af696e2a2d3956b721 _tmp = new RL_0b8b481397d3c2af696e2a2d3956b721();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query b_CyA_AdminCommissionsLeasing.ProposalsList.GetProposal.GetProposalsSum.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_0b8b481397d3c2af696e2a2d3956b721)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetProposalsSum in GetProposal in ProposalsList in b_CyA_AdminCommissionsLeasing in ConectaProveedores (SELECT sum({Proposal}.[TotalValueML])  FROM {FileExtended}  LEFT JOIN {User} AS UploadedBy      ON {FileExtended}.[UploadedBy] = UploadedBy.[Id]  LEFT JOIN {Proposal}      ON {FileExtended}.[Id] = {Proposal}.[FileId]  LEFT JOIN {ProposalType}      ON {Proposal}.[ProposalTypeId] = {ProposalType}.[Id]  LEFT JOIN {ProposalStatus}      ON {Proposal}.[ProposalStatusId] = {ProposalStatus}.[Id]  LEFT JOIN {Bank}      ON {Proposal}.[BankId] = {Bank}.[Id]  LEFT JOIN {Region}      ON {Proposal}.[RegionId] = {Region}.[Id]  LEFT JOIN {Currency}      ON {Proposal}.[CurrencyId] = {Currency}.[Code]  WHERE      (        @Proposals_Region::text = '()'        OR {Proposal}.[RegionId] = ANY(              string_to_array(trim(both '()' from @Proposals_Region::text), ',')::int[]           )      )        AND (        @Proposals_Bank::int = 0        OR {Proposal}.[BankId] = @Proposals_Bank::int      )        AND (        @Proposals_AmountMLFrom::numeric = 0        OR {Proposal}.[TotalValueML] >= @Proposals_ ...): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetProposalsSum in GetProposal in ProposalsList in b_CyA_AdminCommissionsLeasing in ConectaProveedores (SELECT sum({Proposal}.[TotalValueML])  FROM {FileExtended}  LEFT JOIN {User} AS UploadedBy      ON {FileExtended}.[UploadedBy] = UploadedBy.[Id]  LEFT JOIN {Proposal}      ON {FileExtended}.[Id] = {Proposal}.[FileId]  LEFT JOIN {ProposalType}      ON {Proposal}.[ProposalTypeId] = {ProposalType}.[Id]  LEFT JOIN {ProposalStatus}      ON {Proposal}.[ProposalStatusId] = {ProposalStatus}.[Id]  LEFT JOIN {Bank}      ON {Proposal}.[BankId] = {Bank}.[Id]  LEFT JOIN {Region}      ON {Proposal}.[RegionId] = {Region}.[Id]  LEFT JOIN {Currency}      ON {Proposal}.[CurrencyId] = {Currency}.[Code]  WHERE      (        @Proposals_Region::text = '()'        OR {Proposal}.[RegionId] = ANY(              string_to_array(trim(both '()' from @Proposals_Region::text), ',')::int[]           )      )        AND (        @Proposals_Bank::int = 0        OR {Proposal}.[BankId] = @Proposals_Bank::int      )        AND (        @Proposals_AmountMLFrom::numeric = 0        OR {Proposal}.[TotalValueML] >= @Proposals_ ...): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetProposalsSum in GetProposal in ProposalsList in b_CyA_AdminCommissionsLeasing in ConectaProveedores (SELECT sum({Proposal}.[TotalValueML])  FROM {FileExtended}  LEFT JOIN {User} AS UploadedBy      ON {FileExtended}.[UploadedBy] = UploadedBy.[Id]  LEFT JOIN {Proposal}      ON {FileExtended}.[Id] = {Proposal}.[FileId]  LEFT JOIN {ProposalType}      ON {Proposal}.[ProposalTypeId] = {ProposalType}.[Id]  LEFT JOIN {ProposalStatus}      ON {Proposal}.[ProposalStatusId] = {ProposalStatus}.[Id]  LEFT JOIN {Bank}      ON {Proposal}.[BankId] = {Bank}.[Id]  LEFT JOIN {Region}      ON {Proposal}.[RegionId] = {Region}.[Id]  LEFT JOIN {Currency}      ON {Proposal}.[CurrencyId] = {Currency}.[Code]  WHERE      (        @Proposals_Region::text = '()'        OR {Proposal}.[RegionId] = ANY(              string_to_array(trim(both '()' from @Proposals_Region::text), ',')::int[]           )      )        AND (        @Proposals_Bank::int = 0        OR {Proposal}.[BankId] = @Proposals_Bank::int      )        AND (        @Proposals_AmountMLFrom::numeric = 0        OR {Proposal}.[TotalValueML] >= @Proposals_ ...): " + aqExcep.Message));
}
}
}

// Query Function "GetProposalsCount" WbqnsROoPkOPTYpgF1dPNQ of Action "GetProposal"
public static async Task<(RLIntegerLiteralRecordList,long)> QueryGetProposalsCount(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteProposals_Region,long qpbaProposals_Bank,decimal qpcuProposals_AmountMLFrom,decimal qpcuProposals_AmountMLTo,DateTime qpdaProposals_PaymentDateFrom,DateTime qpdaProposals_PaymentDateTo,string qpteProposals_Status,string qpteProposals_Currency,string qpteProposals_ProposalSearch,int qpinProposals_UploadType,int qpprProposals_Type,DateTime qpdaNulldate,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("b_CyA_AdminCommissionsLeasing.ProposalsList.GetProposal.GetProposalsCount", "b1a7ba59-a813-433e-8f4d-8a6017574f35");
using var queryActivity = activitySource.CreateSqlQueryActivity("b_CyA_AdminCommissionsLeasing.ProposalsList.GetProposal.GetProposalsCount", "b1a7ba59-a813-433e-8f4d-8a6017574f35", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string entityFileExtended = AppUtils.Instance.RuntimeEntityReplace("FileExtended");
string entityUser = AppUtils.Instance.RuntimeEntityReplace("User");
string entityProposal = AppUtils.Instance.RuntimeEntityReplace("Proposal");
string entityProposalType = AppUtils.Instance.RuntimeEntityReplace("ProposalType");
string entityProposalStatus = AppUtils.Instance.RuntimeEntityReplace("ProposalStatus");
string entityBank = AppUtils.Instance.RuntimeEntityReplace("Bank");
string entityRegion = AppUtils.Instance.RuntimeEntityReplace("Region");
string entityCurrency = AppUtils.Instance.RuntimeEntityReplace("Currency");
sqlCmd.CreateParameter("@qpteProposals_Region", DbType.String, qpteProposals_Region);
sqlCmd.CreateParameter("@qpbaProposals_Bank", DbType.Int64, qpbaProposals_Bank);
sqlCmd.CreateParameter("@qpcuProposals_AmountMLFrom", DbType.Decimal, qpcuProposals_AmountMLFrom);
sqlCmd.CreateParameter("@qpcuProposals_AmountMLTo", DbType.Decimal, qpcuProposals_AmountMLTo);
sqlCmd.CreateParameter("@qpdaProposals_PaymentDateFrom", DbType.DateTime, qpdaProposals_PaymentDateFrom);
sqlCmd.CreateParameter("@qpdaNulldate", DbType.DateTime, qpdaNulldate);
sqlCmd.CreateParameter("@qpdaProposals_PaymentDateTo", DbType.DateTime, qpdaProposals_PaymentDateTo);
sqlCmd.CreateParameter("@qpteProposals_Status", DbType.String, qpteProposals_Status);
sqlCmd.CreateParameter("@qpteProposals_Currency", DbType.String, qpteProposals_Currency);
sqlCmd.CreateParameter("@qpteProposals_ProposalSearch", DbType.String, qpteProposals_ProposalSearch);
sqlCmd.CreateParameter("@qpinProposals_UploadType", DbType.Int32, qpinProposals_UploadType);
sqlCmd.CreateParameter("@qpprProposals_Type", DbType.Int32, qpprProposals_Type);
string sql = "";
string advSql = "SELECT count(1) \nFROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFileExtended,"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,"") + " AS UploadedBy \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFileExtended,".\"uploadedby\"") + " = UploadedBy.\"id\" \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,"") + " \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFileExtended,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"fileid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalType,"") + " \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"proposaltypeid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalType,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalStatus,"") + " \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"proposalstatusid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalStatus,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityBank,"") + " \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"bankid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityBank,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,"") + " \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"regionid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,"") + " \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"currencyid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"code\"") + " \nWHERE \n    ( \n      @qpteProposals_Region::text = '()' \n      OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"regionid\"") + " = ANY( \n            string_to_array(trim(both '()' from @qpteProposals_Region::text), ',')::int[] \n         ) \n    ) \n \n    AND ( \n      @qpbaProposals_Bank::int = 0 \n      OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"bankid\"") + " = @qpbaProposals_Bank::int \n    ) \n \n    AND ( \n      @qpcuProposals_AmountMLFrom::numeric = 0 \n      OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"totalvalueml\"") + " >= @qpcuProposals_AmountMLFrom::numeric \n    ) \n \n    AND ( \n      @qpcuProposals_AmountMLTo::numeric = 0 \n      OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"totalvalueml\"") + " <= @qpcuProposals_AmountMLTo::numeric \n    ) \n \n    AND ( \n      ( @qpdaProposals_PaymentDateFrom::timestamp = @qpdaNulldate::timestamp \n        OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"paymentdate\"") + " >= @qpdaProposals_PaymentDateFrom::timestamp ) \n      AND \n      ( @qpdaProposals_PaymentDateTo::timestamp =@qpdaNulldate::timestamp \n        OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"paymentdate\"") + " <= @qpdaProposals_PaymentDateTo::timestamp ) \n    ) \n \n    AND \n    ( \n      @qpteProposals_Status::text = '()' \n      OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"proposalstatusid\"") + " = ANY( \n            string_to_array(trim(both '()' from @qpteProposals_Status::text), ',')::int[] \n         ) \n    ) \n \n    AND  ( \n      @qpteProposals_Currency::text  = '()' \n      OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"currencyid\"") + " = ANY( \n            string_to_array(trim(both '()' from @qpteProposals_Currency::text), ',')::text[] \n         ) \n    ) \n \n    AND ( \n    @qpteProposals_ProposalSearch::text = '' \n    OR LOWER( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"name\"") + " COLLATE \"C\") LIKE LOWER(('%' || @qpteProposals_ProposalSearch::text || '%') COLLATE \"C\") \n    ) \n \n    AND ( \n      @qpinProposals_UploadType::int = 0 \n      OR ( @qpinProposals_UploadType::int = 2 AND COALESCE( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFileExtended,".\"uploadedby\"") + "::text, '') = '') \n      OR ( @qpinProposals_UploadType::int = 1 AND COALESCE( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFileExtended,".\"uploadedby\"") + "::text, '') <> '') \n    ) \n \n    AND ( \n      @qpprProposals_Type::int = 0 \n      OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"proposaltypeid\"") + " = @qpprProposals_Type::int \n    );";
sql = advSql;
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RLIntegerLiteralRecordList outParamList = new RLIntegerLiteralRecordList();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query b_CyA_AdminCommissionsLeasing.ProposalsList.GetProposal.GetProposalsCount.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RLIntegerLiteralRecordList _tmp = new RLIntegerLiteralRecordList();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query b_CyA_AdminCommissionsLeasing.ProposalsList.GetProposal.GetProposalsCount.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RLIntegerLiteralRecordList)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetProposalsCount in GetProposal in ProposalsList in b_CyA_AdminCommissionsLeasing in ConectaProveedores (SELECT count(1)  FROM {FileExtended}  LEFT JOIN {User} AS UploadedBy      ON {FileExtended}.[UploadedBy] = UploadedBy.[Id]  LEFT JOIN {Proposal}      ON {FileExtended}.[Id] = {Proposal}.[FileId]  LEFT JOIN {ProposalType}      ON {Proposal}.[ProposalTypeId] = {ProposalType}.[Id]  LEFT JOIN {ProposalStatus}      ON {Proposal}.[ProposalStatusId] = {ProposalStatus}.[Id]  LEFT JOIN {Bank}      ON {Proposal}.[BankId] = {Bank}.[Id]  LEFT JOIN {Region}      ON {Proposal}.[RegionId] = {Region}.[Id]  LEFT JOIN {Currency}      ON {Proposal}.[CurrencyId] = {Currency}.[Code]  WHERE      (        @Proposals_Region::text = '()'        OR {Proposal}.[RegionId] = ANY(              string_to_array(trim(both '()' from @Proposals_Region::text), ',')::int[]           )      )        AND (        @Proposals_Bank::int = 0        OR {Proposal}.[BankId] = @Proposals_Bank::int      )        AND (        @Proposals_AmountMLFrom::numeric = 0        OR {Proposal}.[TotalValueML] >= @Proposals_AmountMLFrom::numeric  ...): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetProposalsCount in GetProposal in ProposalsList in b_CyA_AdminCommissionsLeasing in ConectaProveedores (SELECT count(1)  FROM {FileExtended}  LEFT JOIN {User} AS UploadedBy      ON {FileExtended}.[UploadedBy] = UploadedBy.[Id]  LEFT JOIN {Proposal}      ON {FileExtended}.[Id] = {Proposal}.[FileId]  LEFT JOIN {ProposalType}      ON {Proposal}.[ProposalTypeId] = {ProposalType}.[Id]  LEFT JOIN {ProposalStatus}      ON {Proposal}.[ProposalStatusId] = {ProposalStatus}.[Id]  LEFT JOIN {Bank}      ON {Proposal}.[BankId] = {Bank}.[Id]  LEFT JOIN {Region}      ON {Proposal}.[RegionId] = {Region}.[Id]  LEFT JOIN {Currency}      ON {Proposal}.[CurrencyId] = {Currency}.[Code]  WHERE      (        @Proposals_Region::text = '()'        OR {Proposal}.[RegionId] = ANY(              string_to_array(trim(both '()' from @Proposals_Region::text), ',')::int[]           )      )        AND (        @Proposals_Bank::int = 0        OR {Proposal}.[BankId] = @Proposals_Bank::int      )        AND (        @Proposals_AmountMLFrom::numeric = 0        OR {Proposal}.[TotalValueML] >= @Proposals_AmountMLFrom::numeric  ...): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetProposalsCount in GetProposal in ProposalsList in b_CyA_AdminCommissionsLeasing in ConectaProveedores (SELECT count(1)  FROM {FileExtended}  LEFT JOIN {User} AS UploadedBy      ON {FileExtended}.[UploadedBy] = UploadedBy.[Id]  LEFT JOIN {Proposal}      ON {FileExtended}.[Id] = {Proposal}.[FileId]  LEFT JOIN {ProposalType}      ON {Proposal}.[ProposalTypeId] = {ProposalType}.[Id]  LEFT JOIN {ProposalStatus}      ON {Proposal}.[ProposalStatusId] = {ProposalStatus}.[Id]  LEFT JOIN {Bank}      ON {Proposal}.[BankId] = {Bank}.[Id]  LEFT JOIN {Region}      ON {Proposal}.[RegionId] = {Region}.[Id]  LEFT JOIN {Currency}      ON {Proposal}.[CurrencyId] = {Currency}.[Code]  WHERE      (        @Proposals_Region::text = '()'        OR {Proposal}.[RegionId] = ANY(              string_to_array(trim(both '()' from @Proposals_Region::text), ',')::int[]           )      )        AND (        @Proposals_Bank::int = 0        OR {Proposal}.[BankId] = @Proposals_Bank::int      )        AND (        @Proposals_AmountMLFrom::numeric = 0        OR {Proposal}.[TotalValueML] >= @Proposals_AmountMLFrom::numeric  ...): " + aqExcep.Message));
}
}
}
}


}
