using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalDetailTreasury_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalDetailTreasury_ScreenModel).Namespace);

    public long inParami_ProposalId;
public string varLcTableSort;
public int varLcStartIndex;
public bool varLcl_IsSelected;
public bool varLcl_IsSelectAll;
public bool varLci_IsShowSelectAll;
public string varLcDateTextFormatted;
public DateTime varLcl_RefeshSideBar;
public bool varLcl_ShowUnpayPopup;
public long varLcl_ProposalLineIdForPopup;
public int varLcl_PaymentStatus;
public bool varLcl_ShowUnpaidDetailPopup;
public long varLcl_ProposalLinelIdUnpaidDetail;
public bool varLcl_ReInvokeToggler;
public string varLcl_ColumnJSONVarGetProposalDetailTreasury;
public int varLcl_CountAfterFetchGetProposalDetailTreasury;
public bool varLcl_Loading;
public long varLcl_SelectdLogDocumentId;
public string varLcl_SelectdLogDocumentNumber;
public DateTime varLcl_RefeshDocumentSideBar;
public bool varLcl_ClaimEnable;
public AggregateRecord<RL_51a4e63e168a01408e3f55c611518e13> ScreenDataSetGetApprovalStatuses;
public AggregateRecord<RL_db80b9f839f0b93373297ec2051fc003> ScreenDataSetGetProposalLinesByProposalId;
public AggregateRecord<RL_f4591be205d3928a9fe22daf19d979cd> ScreenDataSetGetProposalById;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalDetailTreasury_ScreenModel() {
}



    public ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalDetailTreasury_ScreenModel(long inParami_ProposalId, string varLcTableSort, int varLcStartIndex, bool varLcl_IsSelected, bool varLcl_IsSelectAll, bool varLci_IsShowSelectAll, string varLcDateTextFormatted, DateTime varLcl_RefeshSideBar, bool varLcl_ShowUnpayPopup, long varLcl_ProposalLineIdForPopup, int varLcl_PaymentStatus, bool varLcl_ShowUnpaidDetailPopup, long varLcl_ProposalLinelIdUnpaidDetail, bool varLcl_ReInvokeToggler, string varLcl_ColumnJSONVarGetProposalDetailTreasury, int varLcl_CountAfterFetchGetProposalDetailTreasury, bool varLcl_Loading, long varLcl_SelectdLogDocumentId, string varLcl_SelectdLogDocumentNumber, DateTime varLcl_RefeshDocumentSideBar, bool varLcl_ClaimEnable, AggregateRecord<RL_51a4e63e168a01408e3f55c611518e13> ScreenDataSetGetApprovalStatuses, AggregateRecord<RL_db80b9f839f0b93373297ec2051fc003> ScreenDataSetGetProposalLinesByProposalId, AggregateRecord<RL_f4591be205d3928a9fe22daf19d979cd> ScreenDataSetGetProposalById, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"i_ProposalId", "TableSort", "StartIndex", "l_IsSelected", "l_IsSelectAll", "i_IsShowSelectAll", "DateTextFormatted", "l_RefeshSideBar", "l_ShowUnpayPopup", "l_ProposalLineIdForPopup", "l_PaymentStatus", "l_ShowUnpaidDetailPopup", "l_ProposalLinelIdUnpaidDetail", "l_ReInvokeToggler", "l_ColumnJSONVarGetProposalDetailTreasury", "l_CountAfterFetchGetProposalDetailTreasury", "l_Loading", "l_SelectdLogDocumentId", "l_SelectdLogDocumentNumber", "l_RefeshDocumentSideBar", "l_ClaimEnable", "GetApprovalStatuses", "GetProposalLinesByProposalId", "GetProposalById", "ClientVars"}, new string[] {"inParami_ProposalId", "varLcTableSort", "varLcStartIndex", "varLcl_IsSelected", "varLcl_IsSelectAll", "varLci_IsShowSelectAll", "varLcDateTextFormatted", "varLcl_RefeshSideBar", "varLcl_ShowUnpayPopup", "varLcl_ProposalLineIdForPopup", "varLcl_PaymentStatus", "varLcl_ShowUnpaidDetailPopup", "varLcl_ProposalLinelIdUnpaidDetail", "varLcl_ReInvokeToggler", "varLcl_ColumnJSONVarGetProposalDetailTreasury", "varLcl_CountAfterFetchGetProposalDetailTreasury", "varLcl_Loading", "varLcl_SelectdLogDocumentId", "varLcl_SelectdLogDocumentNumber", "varLcl_RefeshDocumentSideBar", "varLcl_ClaimEnable", "ScreenDataSetGetApprovalStatuses", "ScreenDataSetGetProposalLinesByProposalId", "ScreenDataSetGetProposalById", "clientVariables"});
this.inParami_ProposalId = inParami_ProposalId;
this.varLcTableSort = varLcTableSort;
this.varLcStartIndex = varLcStartIndex;
this.varLcl_IsSelected = varLcl_IsSelected;
this.varLcl_IsSelectAll = varLcl_IsSelectAll;
this.varLci_IsShowSelectAll = varLci_IsShowSelectAll;
this.varLcDateTextFormatted = varLcDateTextFormatted;
this.varLcl_RefeshSideBar = varLcl_RefeshSideBar;
this.varLcl_ShowUnpayPopup = varLcl_ShowUnpayPopup;
this.varLcl_ProposalLineIdForPopup = varLcl_ProposalLineIdForPopup;
this.varLcl_PaymentStatus = varLcl_PaymentStatus;
this.varLcl_ShowUnpaidDetailPopup = varLcl_ShowUnpaidDetailPopup;
this.varLcl_ProposalLinelIdUnpaidDetail = varLcl_ProposalLinelIdUnpaidDetail;
this.varLcl_ReInvokeToggler = varLcl_ReInvokeToggler;
this.varLcl_ColumnJSONVarGetProposalDetailTreasury = varLcl_ColumnJSONVarGetProposalDetailTreasury;
this.varLcl_CountAfterFetchGetProposalDetailTreasury = varLcl_CountAfterFetchGetProposalDetailTreasury;
this.varLcl_Loading = varLcl_Loading;
this.varLcl_SelectdLogDocumentId = varLcl_SelectdLogDocumentId;
this.varLcl_SelectdLogDocumentNumber = varLcl_SelectdLogDocumentNumber;
this.varLcl_RefeshDocumentSideBar = varLcl_RefeshDocumentSideBar;
this.varLcl_ClaimEnable = varLcl_ClaimEnable;
this.ScreenDataSetGetApprovalStatuses = ScreenDataSetGetApprovalStatuses;
this.ScreenDataSetGetProposalLinesByProposalId = ScreenDataSetGetProposalLinesByProposalId;
this.ScreenDataSetGetProposalById = ScreenDataSetGetProposalById;
this.clientVariables = clientVariables;
}



    
// Query Function "GetApprovalStatuses" 06cfYhvbfUuxw4YKLnW7gw of Action "ProposalDetailTreasury"
public static async Task<(RL_51a4e63e168a01408e3f55c611518e13,long)> datasetGetApprovalStatuses(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("b_CyA_TreasuryCommissionsLeasing.ProposalDetailTreasury.GetApprovalStatuses", "621fa7d3-db1b-4b7d-b1c3-860a2e75bb83");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("ProposalDetailTreasury","b_CyA_TreasuryCommissionsLeasing.ProposalDetailTreasury.GetApprovalStatuses");
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
selectBuilder.Append("/* /NRWebFlows.sBq8pxDfr0GAxtE80fQu3g/NodesShownInESpaceTree._cUP9THgJky2nS01TBbrcQ/ScreenDataSets.06cfYhvbfUuxw4YKLnW7gw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enapprovalstatus26\".\"id\" o0, \"enapprovalstatus26\".\"label\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9");
fromBuilder.Append(" FROM {ApprovalStatus} \"enapprovalstatus26\"");
whereBuilder.Append(" WHERE (\"enapprovalstatus26\".\"is_active\" = 1) AND (((\"enapprovalstatus26\".\"id\" = ");
whereBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("rkrV30n0cEiW8dttOKG0gw"))).ssId);
whereBuilder.Append(") OR (\"enapprovalstatus26\".\"id\" = ");
whereBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("WSrbHwGzvEKPytCj7doVWw"))).ssId);
whereBuilder.Append(")) OR (\"enapprovalstatus26\".\"id\" = ");
whereBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("bkD8ux0JT02InXZZfkOUsA"))).ssId);
whereBuilder.Append("))");
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
RL_51a4e63e168a01408e3f55c611518e13 outParamList = new RL_51a4e63e168a01408e3f55c611518e13();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query b_CyA_TreasuryCommissionsLeasing.ProposalDetailTreasury.GetApprovalStatuses.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_51a4e63e168a01408e3f55c611518e13 _tmp = new RL_51a4e63e168a01408e3f55c611518e13();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query b_CyA_TreasuryCommissionsLeasing.ProposalDetailTreasury.GetApprovalStatuses.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_51a4e63e168a01408e3f55c611518e13)_tmp;
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

private static async Task<RC_b34001d496bee16bcec019df0c313eb6> datasetGetProposalLinesByProposalIdReadDbAsync(RC_b34001d496bee16bcec019df0c313eb6 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENProposalComment.Read( r, ref index);
rec.ssENProposalLine.Read( r, ref index);
rec.ssENUser_Paid.Read( r, ref index);
rec.ssENUser_Unpaid.Read( r, ref index);
rec.ssIsSelected = r.ReadBoolean(index++, "User_PaidUser_UnpaidProposalCommentProposalLineIsSelectedRecord.IsSelected", false);
return rec;
}
// Query Function "GetProposalLinesByProposalId" 3zGdZ_t62EqH7j0JIiYSag of Action "ProposalDetailTreasury"
public static async Task<(RL_db80b9f839f0b93373297ec2051fc003,long)> datasetGetProposalLinesByProposalId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,long qpprProposalLine_ProposalId,int qpapProposalLine_ApprovalStatusId,string qpteTableSort,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("b_CyA_TreasuryCommissionsLeasing.ProposalDetailTreasury.GetProposalLinesByProposalId", "679d31df-7afb-4ad8-87ee-3d092226126a");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("ProposalDetailTreasury","b_CyA_TreasuryCommissionsLeasing.ProposalDetailTreasury.GetProposalLinesByProposalId");
// Query Iterations: Multiple
// Refresh Query j2jqdZJ9VU62HnUcePoDmg Iterations: Multiple
// Refresh Query +PVyBWV4Mk+BotG+YxNW2Q Iterations: Multiple
// Refresh Query ZEtAhzdxGkyTII29X8pm8g Iterations: Multiple
// Refresh Query 4KsIrZ+OVkOfqOrLHNoR3A Iterations: Multiple
// Refresh Query aXXmyMivZ0KEAvK6NeI8yQ Iterations: Multiple
// Refresh Query nB0R1y7c50evECwimBXM3w Iterations: Multiple
// Refresh Query ZJ4QrPezrECRkorvOV1ffQ Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.sBq8pxDfr0GAxtE80fQu3g/NodesShownInESpaceTree._cUP9THgJky2nS01TBbrcQ/ScreenDataSets.3zGdZ_t62EqH7j0JIiYSag, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enproposalcomment3\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, \"enproposalline13\".\"id\" o8, NULL o9, \"enproposalline13\".\"approvalstatusid\" o10, NULL o11, NULL o12, NULL o13, NULL o14, \"enproposalline13\".\"cuenta\" o15, \"enproposalline13\".\"referencia\" o16, \"enproposalline13\".\"nombre1\" o17, NULL o18, \"enproposalline13\".\"n_doc_\" o19, NULL o20, trim_scale(\"enproposalline13\".\"importeenml\"::numeric) o21, \"enproposalline13\".\"ml\" o22, trim_scale(\"enproposalline13\".\"importeenmd\"::numeric) o23, \"enproposalline13\".\"mon_\" o24, \"enproposalline13\".\"soc_\" o25, \"enproposalline13\".\"div_\" o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, \"enuser_paid\".\"name\" o37, NULL o38, NULL o39, NULL o40, NULL o41, \"enuser_unpaid\".\"name\" o42, NULL o43, NULL o44, NULL o45, 0 \"isselected\"");
fromBuilder.Append(" FROM ((({ProposalLine} \"enproposalline13\" Left JOIN {ProposalComment} \"enproposalcomment3\" ON ((\"enproposalline13\".\"id\" = \"enproposalcomment3\".\"proposallineid\") AND (\"enproposalcomment3\".\"commenttypeid\" = ");
fromBuilder.Append((ENCommentTypeEntity.GetRecordByKey(ObjectKey.Parse("Yb_2rORMO0CiONuueCSezA"))).ssId);
fromBuilder.Append(")))  Left JOIN {User} \"enuser_paid\" ON (\"enproposalline13\".\"paidby\" = \"enuser_paid\".\"id\"))  Left JOIN {User} \"enuser_unpaid\" ON (\"enproposalline13\".\"unpaidby\" = \"enuser_unpaid\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpprProposalLine_ProposalId != 0) {
whereBuilder.Append("((\"enproposalline13\".\"proposalid\" = @qpprProposalLine_ProposalId) AND (\"enproposalline13\".\"proposalid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprProposalLine_ProposalId", DbType.Int64, qpprProposalLine_ProposalId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpprProposalLine_ProposalId", DbType.Int64, qpprProposalLine_ProposalId);
} else {
whereBuilder.Append("(\"enproposalline13\".\"proposalid\" IS NULL)");
}
whereBuilder.Append(" AND (@qpboCheckUserSession = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
sqlCountCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qpapProposalLine_ApprovalStatusId != BuiltInFunction.NullIdentifier()) {
if (qpapProposalLine_ApprovalStatusId != 0) {
whereBuilder.Append("((\"enproposalline13\".\"approvalstatusid\" = @qpapProposalLine_ApprovalStatusId) AND (\"enproposalline13\".\"approvalstatusid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpapProposalLine_ApprovalStatusId", DbType.Int32, qpapProposalLine_ApprovalStatusId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpapProposalLine_ApprovalStatusId", DbType.Int32, qpapProposalLine_ApprovalStatusId);
} else {
whereBuilder.Append("(\"enproposalline13\".\"approvalstatusid\" IS NULL)");
}
}
string whereBuilderString = whereBuilder.ToString();
if (whereBuilderString.EndsWith(" AND ")) {
whereBuilder.Remove(whereBuilderString.Length - 5, 5);
}
if ((qpteTableSort.Trim()!="")) {
orderByBuilder.Append(" ORDER BY ");
List<string> orderByColumns = new List<string>();
orderByColumns.AddRange(BaseAppUtils.ReplaceEntityReferencesAndAttributesInOrderBy(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, qpteTableSort, new string[] { "ProposalComment", "User_Paid", "User_Unpaid", "ProposalLine" }, new string[] { "ENProposalComment3", "ENUser_Paid", "ENUser_Unpaid", "ENProposalLine13" }, new System.Collections.Generic.Dictionary<string, string>[] { ENProposalCommentEntity.AttributesToDatabaseNamesMap(), ENUserEntity.AttributesToDatabaseNamesMap(), ENUserEntity.AttributesToDatabaseNamesMap(), ENProposalLineEntity.AttributesToDatabaseNamesMap() }).Split(','));
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
RL_db80b9f839f0b93373297ec2051fc003 outParamList = new RL_db80b9f839f0b93373297ec2051fc003();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetProposalLinesByProposalIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[4];
opt[0] = new BitArray(new bool[] {true, false, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true});
opt[2] = new BitArray(new bool[] {false, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {false, true, false, true, true, true, true, false, false, false, true, false, true, false, false, false, false, false, false, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query b_CyA_TreasuryCommissionsLeasing.ProposalDetailTreasury.GetProposalLinesByProposalId.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query b_CyA_TreasuryCommissionsLeasing.ProposalDetailTreasury.GetProposalLinesByProposalId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_db80b9f839f0b93373297ec2051fc003 _tmp = new RL_db80b9f839f0b93373297ec2051fc003();
_tmp.AlternateReadDbMethodAsync = datasetGetProposalLinesByProposalIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query b_CyA_TreasuryCommissionsLeasing.ProposalDetailTreasury.GetProposalLinesByProposalId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_db80b9f839f0b93373297ec2051fc003)_tmp;
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query b_CyA_TreasuryCommissionsLeasing.ProposalDetailTreasury.GetProposalLinesByProposalId.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
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
// Query Function "GetProposalById" yTTC4_Gdq0a52YjcmtrEkw of Action "ProposalDetailTreasury"
public static async Task<(RL_f4591be205d3928a9fe22daf19d979cd,long)> datasetGetProposalById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,long qpprProposal_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("b_CyA_TreasuryCommissionsLeasing.ProposalDetailTreasury.GetProposalById", "e3c234c9-9df1-46ab-b9d9-88dc9adac493");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("ProposalDetailTreasury","b_CyA_TreasuryCommissionsLeasing.ProposalDetailTreasury.GetProposalById");
// Query Iterations: Never
// Refresh Query 8ChjY1dzOk2JI4knpsaRaQ Iterations: Never
// Refresh Query F_b52ugJKUGF3vk7LZ+fQw Iterations: Never
// Refresh Query _nNo3MkQJ0O_a+HuCRBHCA Iterations: Never
// Refresh Query 7KZUeuePRkG5VmfGBuCNSQ Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.sBq8pxDfr0GAxtE80fQu3g/NodesShownInESpaceTree._cUP9THgJky2nS01TBbrcQ/ScreenDataSets.yTTC4_Gdq0a52YjcmtrEkw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, \"enbank7\".\"code\" o3, NULL o4, NULL o5, \"encurrency32\".\"code\" o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, \"enfileextended5\".\"filename\" o12, NULL o13, NULL o14, NULL o15, \"enfileextended5\".\"uploadedby\" o16, \"enfileextended5\".\"uploadedon\" o17, NULL o18, \"enproposal20\".\"name\" o19, \"enproposal20\".\"paymentdate\" o20, NULL o21, NULL o22, NULL o23, \"enproposal20\".\"proposalstatusid\" o24, NULL o25, \"enproposal20\".\"totalproposallines\" o26, trim_scale(\"enproposal20\".\"totalvalueml\"::numeric) o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, \"enproposal20\".\"maxdatepaymentchanges\" o34, \"enproposal20\".\"assignedtoid\" o35, NULL o36, \"enproposalstatus6\".\"label\" o37, \"enproposalstatus6\".\"class\" o38, NULL o39, NULL o40, NULL o41, \"enproposaltype5\".\"label\" o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57");
fromBuilder.Append(" FROM (((((({FileExtended} \"enfileextended5\" Inner JOIN {Proposal} \"enproposal20\" ON (\"enfileextended5\".\"id\" = \"enproposal20\".\"fileid\"))  Left JOIN {Bank} \"enbank7\" ON (\"enproposal20\".\"bankid\" = \"enbank7\".\"id\"))  Left JOIN {Region} \"enregion163\" ON (\"enproposal20\".\"regionid\" = \"enregion163\".\"id\"))  Left JOIN {ProposalType} \"enproposaltype5\" ON (\"enproposal20\".\"proposaltypeid\" = \"enproposaltype5\".\"id\"))  Left JOIN {ProposalStatus} \"enproposalstatus6\" ON (\"enproposal20\".\"proposalstatusid\" = \"enproposalstatus6\".\"id\"))  Left JOIN {Currency} \"encurrency32\" ON (\"enproposal20\".\"currencyid\" = \"encurrency32\".\"code\")) ");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qpprProposal_Id != 0) {
whereBuilder.Append("((\"enproposal20\".\"id\" = @qpprProposal_Id) AND (\"enproposal20\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprProposal_Id", DbType.Int64, qpprProposal_Id);
} else {
whereBuilder.Append("(\"enproposal20\".\"id\" IS NULL)");
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
opt[2] = new BitArray(new bool[] {true, false, false, true, true, true, false, true, false, false, true, true, true, true, true, true, false, false});
opt[3] = new BitArray(new bool[] {true, false, true, true, true, false, false});
opt[4] = new BitArray(new bool[] {true, false, true, true});
opt[5] = new BitArray(new bool[] {true, false, false, true, true});
opt[6] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query b_CyA_TreasuryCommissionsLeasing.ProposalDetailTreasury.GetProposalById.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query b_CyA_TreasuryCommissionsLeasing.ProposalDetailTreasury.GetProposalById.List", cancellationToken: cancellationToken);
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


    

    

}
