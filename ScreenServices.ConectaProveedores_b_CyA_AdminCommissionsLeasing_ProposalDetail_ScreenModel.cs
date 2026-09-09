using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetail_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetail_ScreenModel).Namespace);

    public long inParami_ProposalId;
public string varLcl_TableSort;
public int varLcl_StartIndex;
public string varLcl_DateTextFormatted;
public DateTime varLcl_RefeshSideBar;
public bool varLcl_ShowCancelPopup;
public long varLcl_ProposalApprovalLevelId;
public bool varLcl_ShowUnpaidDetailPopup;
public long varLcl_ProposalLineId;
public bool varLcl_ReInvokeToggler;
public string varLcl_ColumnJSONVarGetProposalLinesB;
public int varLcl_CountAfterFetchGetProposalLinesB;
public bool varLcl_Loading;
public RL_1de096a2cd5bc9c1d57a6496eba081e9 varLcl_ListForApprovalLevelDropdown;
public DateTime varLcl_RefeshDocumentSideBar;
public long varLcl_SelectdLogDocumentId;
public string varLcl_SelectdLogDocumentNumber;
public AggregateRecord<RL_f4591be205d3928a9fe22daf19d979cd> ScreenDataSetGetProposalById;
public AggregateRecord<RL_edf26e482e095588ed6d5cbd5313bc7f> ScreenDataSetGetProposalStatuses;
public AggregateRecord<RL_5c3f0f159a56c705e2e8b813bae3e604> ScreenDataSetGetProposalApprovalLevels;
public AggregateRecord<RL_fdf11fa7a74406ff2a80f555d1ce34a5> ScreenDataSetGetProposalLinesByProposalId;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetail_ScreenModel() {
}



    public ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalDetail_ScreenModel(long inParami_ProposalId, string varLcl_TableSort, int varLcl_StartIndex, string varLcl_DateTextFormatted, DateTime varLcl_RefeshSideBar, bool varLcl_ShowCancelPopup, long varLcl_ProposalApprovalLevelId, bool varLcl_ShowUnpaidDetailPopup, long varLcl_ProposalLineId, bool varLcl_ReInvokeToggler, string varLcl_ColumnJSONVarGetProposalLinesB, int varLcl_CountAfterFetchGetProposalLinesB, bool varLcl_Loading, RL_1de096a2cd5bc9c1d57a6496eba081e9 varLcl_ListForApprovalLevelDropdown, DateTime varLcl_RefeshDocumentSideBar, long varLcl_SelectdLogDocumentId, string varLcl_SelectdLogDocumentNumber, AggregateRecord<RL_f4591be205d3928a9fe22daf19d979cd> ScreenDataSetGetProposalById, AggregateRecord<RL_edf26e482e095588ed6d5cbd5313bc7f> ScreenDataSetGetProposalStatuses, AggregateRecord<RL_5c3f0f159a56c705e2e8b813bae3e604> ScreenDataSetGetProposalApprovalLevels, AggregateRecord<RL_fdf11fa7a74406ff2a80f555d1ce34a5> ScreenDataSetGetProposalLinesByProposalId, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"i_ProposalId", "l_TableSort", "l_StartIndex", "l_DateTextFormatted", "l_RefeshSideBar", "l_ShowCancelPopup", "l_ProposalApprovalLevelId", "l_ShowUnpaidDetailPopup", "l_ProposalLineId", "l_ReInvokeToggler", "l_ColumnJSONVarGetProposalLinesB", "l_CountAfterFetchGetProposalLinesB", "l_Loading", "l_ListForApprovalLevelDropdown", "l_RefeshDocumentSideBar", "l_SelectdLogDocumentId", "l_SelectdLogDocumentNumber", "GetProposalById", "GetProposalStatuses", "GetProposalApprovalLevels", "GetProposalLinesByProposalId", "ClientVars"}, new string[] {"inParami_ProposalId", "varLcl_TableSort", "varLcl_StartIndex", "varLcl_DateTextFormatted", "varLcl_RefeshSideBar", "varLcl_ShowCancelPopup", "varLcl_ProposalApprovalLevelId", "varLcl_ShowUnpaidDetailPopup", "varLcl_ProposalLineId", "varLcl_ReInvokeToggler", "varLcl_ColumnJSONVarGetProposalLinesB", "varLcl_CountAfterFetchGetProposalLinesB", "varLcl_Loading", "varLcl_ListForApprovalLevelDropdown", "varLcl_RefeshDocumentSideBar", "varLcl_SelectdLogDocumentId", "varLcl_SelectdLogDocumentNumber", "ScreenDataSetGetProposalById", "ScreenDataSetGetProposalStatuses", "ScreenDataSetGetProposalApprovalLevels", "ScreenDataSetGetProposalLinesByProposalId", "clientVariables"});
this.inParami_ProposalId = inParami_ProposalId;
this.varLcl_TableSort = varLcl_TableSort;
this.varLcl_StartIndex = varLcl_StartIndex;
this.varLcl_DateTextFormatted = varLcl_DateTextFormatted;
this.varLcl_RefeshSideBar = varLcl_RefeshSideBar;
this.varLcl_ShowCancelPopup = varLcl_ShowCancelPopup;
this.varLcl_ProposalApprovalLevelId = varLcl_ProposalApprovalLevelId;
this.varLcl_ShowUnpaidDetailPopup = varLcl_ShowUnpaidDetailPopup;
this.varLcl_ProposalLineId = varLcl_ProposalLineId;
this.varLcl_ReInvokeToggler = varLcl_ReInvokeToggler;
this.varLcl_ColumnJSONVarGetProposalLinesB = varLcl_ColumnJSONVarGetProposalLinesB;
this.varLcl_CountAfterFetchGetProposalLinesB = varLcl_CountAfterFetchGetProposalLinesB;
this.varLcl_Loading = varLcl_Loading;
this.varLcl_ListForApprovalLevelDropdown = varLcl_ListForApprovalLevelDropdown;
this.varLcl_RefeshDocumentSideBar = varLcl_RefeshDocumentSideBar;
this.varLcl_SelectdLogDocumentId = varLcl_SelectdLogDocumentId;
this.varLcl_SelectdLogDocumentNumber = varLcl_SelectdLogDocumentNumber;
this.ScreenDataSetGetProposalById = ScreenDataSetGetProposalById;
this.ScreenDataSetGetProposalStatuses = ScreenDataSetGetProposalStatuses;
this.ScreenDataSetGetProposalApprovalLevels = ScreenDataSetGetProposalApprovalLevels;
this.ScreenDataSetGetProposalLinesByProposalId = ScreenDataSetGetProposalLinesByProposalId;
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
// Query Function "GetProposalById" qI23AGM_T025GUIi2dL_JA of Action "ProposalDetail"
public static async Task<(RL_f4591be205d3928a9fe22daf19d979cd,long)> datasetGetProposalById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckComissionesArrendamientosViewerRole,bool qpboCheckUserSession,long qpreProposal_RegionId,long qpprProposal_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("b_CyA_AdminCommissionsLeasing.ProposalDetail.GetProposalById", "00b78da8-3f63-4d4f-b919-4222d9d2ff24");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("ProposalDetail","b_CyA_AdminCommissionsLeasing.ProposalDetail.GetProposalById");
// Query Iterations: Never
// Refresh Query GPqUFRZUFE+msYaHedqdfQ Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.Qwoh9BhTeEOXvq3lBDkhrg/NodesShownInESpaceTree._T925b+WyEe86kpPlF+Y+g/ScreenDataSets.qI23AGM_T025GUIi2dL_JA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, \"enbank15\".\"code\" o3, NULL o4, NULL o5, \"encurrency40\".\"code\" o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, \"enfileextended10\".\"filename\" o12, NULL o13, NULL o14, NULL o15, \"enfileextended10\".\"uploadedby\" o16, \"enfileextended10\".\"uploadedon\" o17, \"enproposal27\".\"id\" o18, \"enproposal27\".\"name\" o19, \"enproposal27\".\"paymentdate\" o20, NULL o21, NULL o22, NULL o23, \"enproposal27\".\"proposalstatusid\" o24, NULL o25, \"enproposal27\".\"totalproposallines\" o26, trim_scale(\"enproposal27\".\"totalvalueml\"::numeric) o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, \"enproposalstatus14\".\"id\" o36, \"enproposalstatus14\".\"label\" o37, \"enproposalstatus14\".\"class\" o38, \"enproposalstatus14\".\"order\" o39, NULL o40, NULL o41, \"enproposaltype13\".\"label\" o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57");
fromBuilder.Append(" FROM (((((({FileExtended} \"enfileextended10\" Inner JOIN {Proposal} \"enproposal27\" ON (\"enfileextended10\".\"id\" = \"enproposal27\".\"fileid\"))  Left JOIN {Bank} \"enbank15\" ON (\"enproposal27\".\"bankid\" = \"enbank15\".\"id\"))  Left JOIN {Region} \"enregion173\" ON (\"enproposal27\".\"regionid\" = \"enregion173\".\"id\"))  Left JOIN {ProposalType} \"enproposaltype13\" ON (\"enproposal27\".\"proposaltypeid\" = \"enproposaltype13\".\"id\"))  Left JOIN {ProposalStatus} \"enproposalstatus14\" ON (\"enproposal27\".\"proposalstatusid\" = \"enproposalstatus14\".\"id\"))  Left JOIN {Currency} \"encurrency40\" ON (\"enproposal27\".\"currencyid\" = \"encurrency40\".\"code\")) ");
whereBuilder.Append(" WHERE ");
if (qpprProposal_Id != 0) {
whereBuilder.Append("((\"enproposal27\".\"id\" = @qpprProposal_Id) AND (\"enproposal27\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprProposal_Id", DbType.Int64, qpprProposal_Id);
} else {
whereBuilder.Append("(\"enproposal27\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (@qpboCheckUserSession = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qpboCheckComissionesArrendamientosViewerRole) {
if (qpreProposal_RegionId != 0) {
whereBuilder.Append("((\"enproposal27\".\"regionid\" = @qpreProposal_RegionId) AND (\"enproposal27\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreProposal_RegionId", DbType.Int64, qpreProposal_RegionId);
} else {
whereBuilder.Append("(\"enproposal27\".\"regionid\" IS NULL)");
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
opt[2] = new BitArray(new bool[] {false, false, false, true, true, true, false, true, false, false, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, false, true, true, true, false, false});
opt[4] = new BitArray(new bool[] {true, false, true, true});
opt[5] = new BitArray(new bool[] {false, false, false, false, true});
opt[6] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query b_CyA_AdminCommissionsLeasing.ProposalDetail.GetProposalById.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query b_CyA_AdminCommissionsLeasing.ProposalDetail.GetProposalById.List", cancellationToken: cancellationToken);
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

// Query Function "GetProposalStatuses" 4SBQAbn9XkaTQ36yH55iKg of Action "ProposalDetail"
public static async Task<(RL_edf26e482e095588ed6d5cbd5313bc7f,long)> datasetGetProposalStatuses(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,int qpprId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("b_CyA_AdminCommissionsLeasing.ProposalDetail.GetProposalStatuses", "015020e1-fdb9-465e-9343-7eb21f9e622a");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("ProposalDetail","b_CyA_AdminCommissionsLeasing.ProposalDetail.GetProposalStatuses");
// Query Iterations: Multiple
// Refresh Query kN0c4rt0Uk+hZtiUFtFP7Q Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.Qwoh9BhTeEOXvq3lBDkhrg/NodesShownInESpaceTree._T925b+WyEe86kpPlF+Y+g/ScreenDataSets.4SBQAbn9XkaTQ36yH55iKg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enproposalstatus15\".\"label\" o1, \"enproposalstatus15\".\"class\" o2, \"enproposalstatus15\".\"order\" o3, NULL o4");
fromBuilder.Append(" FROM {ProposalStatus} \"enproposalstatus15\"");
whereBuilder.Append(" WHERE (\"enproposalstatus15\".\"is_active\" = 1) AND (\"enproposalstatus15\".\"id\" <> ");
whereBuilder.Append((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("OSpEADv8F0q4Sge4sU9mWA"))).ssId);
whereBuilder.Append(") AND ((");
if (qpprId != 0) {
whereBuilder.Append("((");
whereBuilder.Append((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("Abvh784e3UuM2GyF6VWeNw"))).ssId);
whereBuilder.Append(" <> @qpprId) OR (");
whereBuilder.Append((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("Abvh784e3UuM2GyF6VWeNw"))).ssId);
whereBuilder.Append(" IS NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprId", DbType.Int32, qpprId);
} else {
whereBuilder.Append("(");
whereBuilder.Append((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("Abvh784e3UuM2GyF6VWeNw"))).ssId);
whereBuilder.Append(" IS NOT NULL)");
}
whereBuilder.Append(" AND (\"enproposalstatus15\".\"id\" <> ");
whereBuilder.Append((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("Abvh784e3UuM2GyF6VWeNw"))).ssId);
whereBuilder.Append(")) OR (");
if (qpprId != 0) {
whereBuilder.Append("((");
whereBuilder.Append((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("Abvh784e3UuM2GyF6VWeNw"))).ssId);
whereBuilder.Append(" = @qpprId) AND (");
whereBuilder.Append((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("Abvh784e3UuM2GyF6VWeNw"))).ssId);
whereBuilder.Append(" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprId", DbType.Int32, qpprId);
} else {
whereBuilder.Append("(");
whereBuilder.Append((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("Abvh784e3UuM2GyF6VWeNw"))).ssId);
whereBuilder.Append(" IS NULL)");
}
whereBuilder.Append(" AND (\"enproposalstatus15\".\"id\" <> ");
whereBuilder.Append((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("t1jXoCYmMkuMIabV4nC9iA"))).ssId);
whereBuilder.Append("))) AND (((");
if (qpprId != 0) {
whereBuilder.Append("((");
whereBuilder.Append((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("uL8+MGLLsUGnVkTyfH8gIw"))).ssId);
whereBuilder.Append(" = @qpprId) AND (");
whereBuilder.Append((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("uL8+MGLLsUGnVkTyfH8gIw"))).ssId);
whereBuilder.Append(" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprId", DbType.Int32, qpprId);
} else {
whereBuilder.Append("(");
whereBuilder.Append((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("uL8+MGLLsUGnVkTyfH8gIw"))).ssId);
whereBuilder.Append(" IS NULL)");
}
whereBuilder.Append(" AND ((\"enproposalstatus15\".\"id\" <> ");
whereBuilder.Append((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("Ld4WSOtSaECFNAZ+2etxQA"))).ssId);
whereBuilder.Append(") AND (\"enproposalstatus15\".\"id\" <> ");
whereBuilder.Append((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("tR_Y9rNyuUWKp4_z6ZegWQ"))).ssId);
whereBuilder.Append("))) OR (");
if (qpprId != 0) {
whereBuilder.Append("((");
whereBuilder.Append((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("tR_Y9rNyuUWKp4_z6ZegWQ"))).ssId);
whereBuilder.Append(" = @qpprId) AND (");
whereBuilder.Append((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("tR_Y9rNyuUWKp4_z6ZegWQ"))).ssId);
whereBuilder.Append(" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprId", DbType.Int32, qpprId);
} else {
whereBuilder.Append("(");
whereBuilder.Append((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("tR_Y9rNyuUWKp4_z6ZegWQ"))).ssId);
whereBuilder.Append(" IS NULL)");
}
whereBuilder.Append(" AND ((\"enproposalstatus15\".\"id\" <> ");
whereBuilder.Append((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("uL8+MGLLsUGnVkTyfH8gIw"))).ssId);
whereBuilder.Append(") AND (\"enproposalstatus15\".\"id\" <> ");
whereBuilder.Append((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("Ld4WSOtSaECFNAZ+2etxQA"))).ssId);
whereBuilder.Append(")))) OR ((");
if (qpprId != 0) {
whereBuilder.Append("((");
whereBuilder.Append((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("tR_Y9rNyuUWKp4_z6ZegWQ"))).ssId);
whereBuilder.Append(" <> @qpprId) OR (");
whereBuilder.Append((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("tR_Y9rNyuUWKp4_z6ZegWQ"))).ssId);
whereBuilder.Append(" IS NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprId", DbType.Int32, qpprId);
} else {
whereBuilder.Append("(");
whereBuilder.Append((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("tR_Y9rNyuUWKp4_z6ZegWQ"))).ssId);
whereBuilder.Append(" IS NOT NULL)");
}
whereBuilder.Append(" AND ");
if (qpprId != 0) {
whereBuilder.Append("((");
whereBuilder.Append((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("uL8+MGLLsUGnVkTyfH8gIw"))).ssId);
whereBuilder.Append(" <> @qpprId) OR (");
whereBuilder.Append((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("uL8+MGLLsUGnVkTyfH8gIw"))).ssId);
whereBuilder.Append(" IS NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprId", DbType.Int32, qpprId);
} else {
whereBuilder.Append("(");
whereBuilder.Append((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("uL8+MGLLsUGnVkTyfH8gIw"))).ssId);
whereBuilder.Append(" IS NOT NULL)");
}
whereBuilder.Append(") AND ((\"enproposalstatus15\".\"id\" <> ");
whereBuilder.Append((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("tR_Y9rNyuUWKp4_z6ZegWQ"))).ssId);
whereBuilder.Append(") AND (\"enproposalstatus15\".\"id\" <> ");
whereBuilder.Append((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("uL8+MGLLsUGnVkTyfH8gIw"))).ssId);
whereBuilder.Append("))))");
orderByBuilder.Append(" ORDER BY \"enproposalstatus15\".\"order\" ASC ");
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
opt[0] = new BitArray(new bool[] {true, false, false, false, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query b_CyA_AdminCommissionsLeasing.ProposalDetail.GetProposalStatuses.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query b_CyA_AdminCommissionsLeasing.ProposalDetail.GetProposalStatuses.List", cancellationToken: cancellationToken);
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

private static async Task<RC_37b2ba4d72ceb89cfb30009990025b2f> datasetGetProposalApprovalLevelsReadDbAsync(RC_37b2ba4d72ceb89cfb30009990025b2f rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApplicationRole.Read( r, ref index);
rec.ssENProposal.Read( r, ref index);
rec.ssENProposalApproval.Read( r, ref index);
rec.ssENProposalApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetProposalApprovalLevels" sNXscEjOS0KwQTX2ujvC2w of Action "ProposalDetail"
public static async Task<(RL_5c3f0f159a56c705e2e8b813bae3e604,long)> datasetGetProposalApprovalLevels(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,long qpprProposalApproval_ProposalId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("b_CyA_AdminCommissionsLeasing.ProposalDetail.GetProposalApprovalLevels", "70ecd5b0-ce48-424b-b041-35f6ba3bc2db");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("ProposalDetail","b_CyA_AdminCommissionsLeasing.ProposalDetail.GetProposalApprovalLevels");
// Query Iterations: Multiple
// Refresh Query uKc0+T+xw02dP7OweszzzA Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.Qwoh9BhTeEOXvq3lBDkhrg/NodesShownInESpaceTree._T925b+WyEe86kpPlF+Y+g/ScreenDataSets.sNXscEjOS0KwQTX2ujvC2w, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"enapplicationrole79\".\"name\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, \"enproposalapprovallevel11\".\"id\" o33, NULL o34, \"enproposalapprovallevel11\".\"levelnumber\" o35, NULL o36, \"enproposalapprovallevel11\".\"approvalstatusid\" o37, \"enproposalapprovallevel11\".\"hasstarted\" o38, \"enproposalapprovallevel11\".\"hasfinished\" o39");
fromBuilder.Append(" FROM ((({ProposalApprovalLevel} \"enproposalapprovallevel11\" Left JOIN {ProposalApproval} \"enproposalapproval9\" ON (\"enproposalapprovallevel11\".\"proposalapprovalid\" = \"enproposalapproval9\".\"id\"))  Left JOIN {ApplicationRole} \"enapplicationrole79\" ON (\"enproposalapprovallevel11\".\"applicationroleid\" = \"enapplicationrole79\".\"id\"))  Left JOIN {Proposal} \"enproposal28\" ON (\"enproposalapproval9\".\"proposalid\" = \"enproposal28\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpprProposalApproval_ProposalId != 0) {
whereBuilder.Append("((\"enproposalapproval9\".\"proposalid\" = @qpprProposalApproval_ProposalId) AND (\"enproposalapproval9\".\"proposalid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprProposalApproval_ProposalId", DbType.Int64, qpprProposalApproval_ProposalId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpprProposalApproval_ProposalId", DbType.Int64, qpprProposalApproval_ProposalId);
} else {
whereBuilder.Append("(\"enproposalapproval9\".\"proposalid\" IS NULL)");
}
whereBuilder.Append(" AND (@qpboCheckUserSession = 1)");
orderByBuilder.Append(" ORDER BY \"enproposalapprovallevel11\".\"levelnumber\" ASC ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
sqlCountCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
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
RL_5c3f0f159a56c705e2e8b813bae3e604 outParamList = new RL_5c3f0f159a56c705e2e8b813bae3e604();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetProposalApprovalLevelsReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[4];
opt[0] = new BitArray(new bool[] {false, true, false, true, false, false, false});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, false, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query b_CyA_AdminCommissionsLeasing.ProposalDetail.GetProposalApprovalLevels.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query b_CyA_AdminCommissionsLeasing.ProposalDetail.GetProposalApprovalLevels.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_5c3f0f159a56c705e2e8b813bae3e604 _tmp = new RL_5c3f0f159a56c705e2e8b813bae3e604();
_tmp.AlternateReadDbMethodAsync = datasetGetProposalApprovalLevelsReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query b_CyA_AdminCommissionsLeasing.ProposalDetail.GetProposalApprovalLevels.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_5c3f0f159a56c705e2e8b813bae3e604)_tmp;
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query b_CyA_AdminCommissionsLeasing.ProposalDetail.GetProposalApprovalLevels.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
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

private static async Task<RC_1d9708453e759844315b6b93812afa56> datasetGetProposalLinesByProposalIdReadDbAsync(RC_1d9708453e759844315b6b93812afa56 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENProposalApproval.Read( r, ref index);
rec.ssENProposalApprovalLevel.Read( r, ref index);
rec.ssENProposalLine.Read( r, ref index);
rec.ssENProposalLineApprovalLevel.Read( r, ref index);
rec.ssENUser_Paid.Read( r, ref index);
rec.ssENUser_Unpaid.Read( r, ref index);
rec.ssIsSelected = r.ReadBoolean(index++, "User_PaidUser_UnpaidProposalApprovalLevelProposalLineApprovalLevelProposalApprovalProposalLineIsSelectedRecord.IsSelected", false);
return rec;
}
// Query Function "GetProposalLinesByProposalId" SSTVh8sVCEKgZ5qKq5okjw of Action "ProposalDetail"
public static async Task<(RL_fdf11fa7a74406ff2a80f555d1ce34a5,long)> datasetGetProposalLinesByProposalId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,int qpprProposalStatusId,long qpprProposalLine_ProposalId,long qpprProposalLineApprovalLevel_ProposalApprovalLevelId,string qptel_TableSort,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("b_CyA_AdminCommissionsLeasing.ProposalDetail.GetProposalLinesByProposalId", "87d52449-15cb-4208-a067-9a8aab9a248f");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("ProposalDetail","b_CyA_AdminCommissionsLeasing.ProposalDetail.GetProposalLinesByProposalId");
// Query Iterations: Multiple
// Refresh Query atfAQqb4HUOejK3dziLa1w Iterations: Multiple
// Refresh Query jhoXXOEvVkm2RRDZxKYd+Q Iterations: Multiple
// Refresh Query KZdKtPceJE22fXT2MjDkvQ Iterations: Multiple
// Refresh Query jseEjUYXxEeo1VgUHVAzew Iterations: Multiple
// Refresh Query 5zQ0DIZJT0CFWnkhmWTthg Iterations: Multiple
// Refresh Query fnv10wQcBU6d3G19avwpOg Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.Qwoh9BhTeEOXvq3lBDkhrg/NodesShownInESpaceTree._T925b+WyEe86kpPlF+Y+g/ScreenDataSets.SSTVh8sVCEKgZ5qKq5okjw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, \"enproposalline16\".\"id\" o15, NULL o16, \"enproposalline16\".\"approvalstatusid\" o17, NULL o18, NULL o19, NULL o20, NULL o21, \"enproposalline16\".\"cuenta\" o22, \"enproposalline16\".\"referencia\" o23, \"enproposalline16\".\"nombre1\" o24, NULL o25, \"enproposalline16\".\"n_doc_\" o26, NULL o27, trim_scale(\"enproposalline16\".\"importeenml\"::numeric) o28, \"enproposalline16\".\"ml\" o29, trim_scale(\"enproposalline16\".\"importeenmd\"::numeric) o30, \"enproposalline16\".\"mon_\" o31, \"enproposalline16\".\"soc_\" o32, \"enproposalline16\".\"div_\" o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, \"enproposallineapprovallevel8\".\"id\" o43, NULL o44, NULL o45, NULL o46, \"enproposallineapprovallevel8\".\"approvalstatusid\" o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, \"enuser_paid1\".\"name\" o53, NULL o54, NULL o55, NULL o56, NULL o57, \"enuser_unpaid1\".\"name\" o58, NULL o59, NULL o60, NULL o61, 0 \"isselected\"");
fromBuilder.Append(" FROM ((((({ProposalLine} \"enproposalline16\" Left JOIN {ProposalLineApprovalLevel} \"enproposallineapprovallevel8\" ON (((@qpprProposalLineApprovalLevel_ProposalApprovalLevelId <> 0) AND (\"enproposalline16\".\"id\" = \"enproposallineapprovallevel8\".\"proposallineid\")) AND ((@qpprProposalLineApprovalLevel_ProposalApprovalLevelId = 0) OR (");
sqlCmd.CreateParameterWithoutReplacements("@qpprProposalLineApprovalLevel_ProposalApprovalLevelId", DbType.Int64, qpprProposalLineApprovalLevel_ProposalApprovalLevelId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpprProposalLineApprovalLevel_ProposalApprovalLevelId", DbType.Int64, qpprProposalLineApprovalLevel_ProposalApprovalLevelId);
if (qpprProposalStatusId != 0) {
fromBuilder.Append("((");
fromBuilder.Append((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("7agdijeyhUC3qdG5GpOcAg"))).ssId);
fromBuilder.Append(" = @qpprProposalStatusId) AND (");
fromBuilder.Append((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("7agdijeyhUC3qdG5GpOcAg"))).ssId);
fromBuilder.Append(" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprProposalStatusId", DbType.Int32, qpprProposalStatusId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpprProposalStatusId", DbType.Int32, qpprProposalStatusId);
} else {
fromBuilder.Append("(");
fromBuilder.Append((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("7agdijeyhUC3qdG5GpOcAg"))).ssId);
fromBuilder.Append(" IS NULL)");
}
fromBuilder.Append(" OR ");
if (qpprProposalStatusId != 0) {
fromBuilder.Append("((");
fromBuilder.Append((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("tR_Y9rNyuUWKp4_z6ZegWQ"))).ssId);
fromBuilder.Append(" = @qpprProposalStatusId) AND (");
fromBuilder.Append((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("tR_Y9rNyuUWKp4_z6ZegWQ"))).ssId);
fromBuilder.Append(" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprProposalStatusId", DbType.Int32, qpprProposalStatusId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpprProposalStatusId", DbType.Int32, qpprProposalStatusId);
} else {
fromBuilder.Append("(");
fromBuilder.Append((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("tR_Y9rNyuUWKp4_z6ZegWQ"))).ssId);
fromBuilder.Append(" IS NULL)");
}
fromBuilder.Append("))))  Left JOIN {ProposalApprovalLevel} \"enproposalapprovallevel12\" ON (\"enproposallineapprovallevel8\".\"proposalapprovallevelid\" = \"enproposalapprovallevel12\".\"id\"))  Left JOIN {ProposalApproval} \"enproposalapproval10\" ON (\"enproposalapprovallevel12\".\"proposalapprovalid\" = \"enproposalapproval10\".\"id\"))  Left JOIN {User} \"enuser_paid1\" ON ((\"enproposalline16\".\"paidby\" = \"enuser_paid1\".\"id\") AND (\"enproposalline16\".\"paidby\" IS NOT NULL)))  Left JOIN {User} \"enuser_unpaid1\" ON ((\"enproposalline16\".\"unpaidby\" = \"enuser_unpaid1\".\"id\") AND (\"enproposalline16\".\"unpaidby\" IS NOT NULL))) ");
whereBuilder.Append(" WHERE ");
if (qpprProposalLine_ProposalId != 0) {
whereBuilder.Append("((\"enproposalline16\".\"proposalid\" = @qpprProposalLine_ProposalId) AND (\"enproposalline16\".\"proposalid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprProposalLine_ProposalId", DbType.Int64, qpprProposalLine_ProposalId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpprProposalLine_ProposalId", DbType.Int64, qpprProposalLine_ProposalId);
} else {
whereBuilder.Append("(\"enproposalline16\".\"proposalid\" IS NULL)");
}
whereBuilder.Append(" AND ");
if (qpprProposalLineApprovalLevel_ProposalApprovalLevelId != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpprProposalLineApprovalLevel_ProposalApprovalLevelId != 0) {
whereBuilder.Append("((\"enproposallineapprovallevel8\".\"proposalapprovallevelid\" = @qpprProposalLineApprovalLevel_ProposalApprovalLevelId) AND (\"enproposallineapprovallevel8\".\"proposalapprovallevelid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprProposalLineApprovalLevel_ProposalApprovalLevelId", DbType.Int64, qpprProposalLineApprovalLevel_ProposalApprovalLevelId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpprProposalLineApprovalLevel_ProposalApprovalLevelId", DbType.Int64, qpprProposalLineApprovalLevel_ProposalApprovalLevelId);
} else {
whereBuilder.Append("(\"enproposallineapprovallevel8\".\"proposalapprovallevelid\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
whereBuilder.Append("(@qpboCheckUserSession = 1) AND ((CASE WHEN (@qpprProposalLineApprovalLevel_ProposalApprovalLevelId <> 0) THEN (CASE WHEN (\"enproposallineapprovallevel8\".\"approvalstatusid\" <> ");
whereBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("fEmjvBqEH0eHrf5_YVeo0g"))).ssId);
whereBuilder.Append(") THEN 1 ELSE 0 END) ELSE 1 END) = 1)");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
sqlCountCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
sqlCmd.CreateParameterWithoutReplacements("@qpprProposalLineApprovalLevel_ProposalApprovalLevelId", DbType.Int64, qpprProposalLineApprovalLevel_ProposalApprovalLevelId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpprProposalLineApprovalLevel_ProposalApprovalLevelId", DbType.Int64, qpprProposalLineApprovalLevel_ProposalApprovalLevelId);
if ((qptel_TableSort.Trim()!="")) {
orderByBuilder.Append(" ORDER BY ");
List<string> orderByColumns = new List<string>();
orderByColumns.AddRange(BaseAppUtils.ReplaceEntityReferencesAndAttributesInOrderBy(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, qptel_TableSort, new string[] { "ProposalLine", "User_Unpaid", "User_Paid", "ProposalApprovalLevel", "ProposalLineApprovalLevel", "ProposalApproval" }, new string[] { "ENProposalLine16", "ENUser_Unpaid1", "ENUser_Paid1", "ENProposalApprovalLevel12", "ENProposalLineApprovalLevel8", "ENProposalApproval10" }, new System.Collections.Generic.Dictionary<string, string>[] { ENProposalLineEntity.AttributesToDatabaseNamesMap(), ENUserEntity.AttributesToDatabaseNamesMap(), ENUserEntity.AttributesToDatabaseNamesMap(), ENProposalApprovalLevelEntity.AttributesToDatabaseNamesMap(), ENProposalLineApprovalLevelEntity.AttributesToDatabaseNamesMap(), ENProposalApprovalEntity.AttributesToDatabaseNamesMap() }).Split(','));
orderByBuilder.Append(BaseAppUtils.GetOrderByColumnsWithoutDuplicates(orderByColumns));
} else {
orderByBuilder.Append(" ORDER BY 1 ASC");
}
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
RL_fdf11fa7a74406ff2a80f555d1ce34a5 outParamList = new RL_fdf11fa7a74406ff2a80f555d1ce34a5();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetProposalLinesByProposalIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[6];
opt[0] = new BitArray(new bool[] {true, false, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {false, true, true, true, false, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {false, true, false, true, true, true, true, false, false, false, true, false, true, false, false, false, false, false, false, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query b_CyA_AdminCommissionsLeasing.ProposalDetail.GetProposalLinesByProposalId.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query b_CyA_AdminCommissionsLeasing.ProposalDetail.GetProposalLinesByProposalId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_fdf11fa7a74406ff2a80f555d1ce34a5 _tmp = new RL_fdf11fa7a74406ff2a80f555d1ce34a5();
_tmp.AlternateReadDbMethodAsync = datasetGetProposalLinesByProposalIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query b_CyA_AdminCommissionsLeasing.ProposalDetail.GetProposalLinesByProposalId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_fdf11fa7a74406ff2a80f555d1ce34a5)_tmp;
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query b_CyA_AdminCommissionsLeasing.ProposalDetail.GetProposalLinesByProposalId.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
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
