using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalsTreasury_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalsTreasury_ScreenModel).Namespace);

    public string varLcTableSort;
public int varLcStartIndex;
public bool varLcl_ShowFilters;
public DateTime varLcl_RefeshSideBar;
public bool varLcl_ReInvokeToggler;
public string varLcl_ColumnJSONVarGetProposalsTreasury;
public int varLcl_CountAfterFetchGetProposalsTreasury;
public bool varLcl_Loading;
public long varLcl_proposalId;
public string varLcl_AmountFromText;
public string varLcl_AmountToText;
public AggregateRecord<RL_edf26e482e095588ed6d5cbd5313bc7f> ScreenDataSetGetProposalStatus;
public AggregateRecord<RL_f8f660cba6c51b3d6579cc8426c3f972> ScreenDataSetGetProposals;
public AggregateRecord<RL_c43fa070956fae30a46b9d776792d6cc> ScreenDataSetGetProposalsSum;
public AggregateRecord<RL_f03e17396f660361b67a45f0e1101893> ScreenDataSetGetOperators;
public AggregateRecord<RL_0fc5fa92a15115f6e97a1071c9876bcd> ScreenDataSetGetBanks;
public AggregateRecord<RL_999b467c81e0dee8574a63e95d64104c> ScreenDataSetGetProposalsAssign;
public AggregateRecord<RL_5d3a02aa993c7474297e33d992f39ad0> ScreenDataSetGetRegions;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalsTreasury_ScreenModel() {
}



    public ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalsTreasury_ScreenModel(string varLcTableSort, int varLcStartIndex, bool varLcl_ShowFilters, DateTime varLcl_RefeshSideBar, bool varLcl_ReInvokeToggler, string varLcl_ColumnJSONVarGetProposalsTreasury, int varLcl_CountAfterFetchGetProposalsTreasury, bool varLcl_Loading, long varLcl_proposalId, string varLcl_AmountFromText, string varLcl_AmountToText, AggregateRecord<RL_edf26e482e095588ed6d5cbd5313bc7f> ScreenDataSetGetProposalStatus, AggregateRecord<RL_f8f660cba6c51b3d6579cc8426c3f972> ScreenDataSetGetProposals, AggregateRecord<RL_c43fa070956fae30a46b9d776792d6cc> ScreenDataSetGetProposalsSum, AggregateRecord<RL_f03e17396f660361b67a45f0e1101893> ScreenDataSetGetOperators, AggregateRecord<RL_0fc5fa92a15115f6e97a1071c9876bcd> ScreenDataSetGetBanks, AggregateRecord<RL_999b467c81e0dee8574a63e95d64104c> ScreenDataSetGetProposalsAssign, AggregateRecord<RL_5d3a02aa993c7474297e33d992f39ad0> ScreenDataSetGetRegions, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"TableSort", "StartIndex", "l_ShowFilters", "l_RefeshSideBar", "l_ReInvokeToggler", "l_ColumnJSONVarGetProposalsTreasury", "l_CountAfterFetchGetProposalsTreasury", "l_Loading", "l_proposalId", "l_AmountFromText", "l_AmountToText", "GetProposalStatus", "GetProposals", "GetProposalsSum", "GetOperators", "GetBanks", "GetProposalsAssign", "GetRegions", "ClientVars"}, new string[] {"varLcTableSort", "varLcStartIndex", "varLcl_ShowFilters", "varLcl_RefeshSideBar", "varLcl_ReInvokeToggler", "varLcl_ColumnJSONVarGetProposalsTreasury", "varLcl_CountAfterFetchGetProposalsTreasury", "varLcl_Loading", "varLcl_proposalId", "varLcl_AmountFromText", "varLcl_AmountToText", "ScreenDataSetGetProposalStatus", "ScreenDataSetGetProposals", "ScreenDataSetGetProposalsSum", "ScreenDataSetGetOperators", "ScreenDataSetGetBanks", "ScreenDataSetGetProposalsAssign", "ScreenDataSetGetRegions", "clientVariables"});
this.varLcTableSort = varLcTableSort;
this.varLcStartIndex = varLcStartIndex;
this.varLcl_ShowFilters = varLcl_ShowFilters;
this.varLcl_RefeshSideBar = varLcl_RefeshSideBar;
this.varLcl_ReInvokeToggler = varLcl_ReInvokeToggler;
this.varLcl_ColumnJSONVarGetProposalsTreasury = varLcl_ColumnJSONVarGetProposalsTreasury;
this.varLcl_CountAfterFetchGetProposalsTreasury = varLcl_CountAfterFetchGetProposalsTreasury;
this.varLcl_Loading = varLcl_Loading;
this.varLcl_proposalId = varLcl_proposalId;
this.varLcl_AmountFromText = varLcl_AmountFromText;
this.varLcl_AmountToText = varLcl_AmountToText;
this.ScreenDataSetGetProposalStatus = ScreenDataSetGetProposalStatus;
this.ScreenDataSetGetProposals = ScreenDataSetGetProposals;
this.ScreenDataSetGetProposalsSum = ScreenDataSetGetProposalsSum;
this.ScreenDataSetGetOperators = ScreenDataSetGetOperators;
this.ScreenDataSetGetBanks = ScreenDataSetGetBanks;
this.ScreenDataSetGetProposalsAssign = ScreenDataSetGetProposalsAssign;
this.ScreenDataSetGetRegions = ScreenDataSetGetRegions;
this.clientVariables = clientVariables;
}



    
// Query Function "GetProposalStatus" 4KumOcQWWE+0wtO8+O2s1w of Action "ProposalsTreasury"
public static async Task<(RL_edf26e482e095588ed6d5cbd5313bc7f,long)> datasetGetProposalStatus(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("b_CyA_TreasuryCommissionsLeasing.ProposalsTreasury.GetProposalStatus", "39a6abe0-16c4-4f58-b4c2-d3bcf8edacd7");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("ProposalsTreasury","b_CyA_TreasuryCommissionsLeasing.ProposalsTreasury.GetProposalStatus");
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
selectBuilder.Append("/* /NRWebFlows.sBq8pxDfr0GAxtE80fQu3g/NodesShownInESpaceTree.4uqcHnxIkUu8BPmnuO2Qgg/ScreenDataSets.4KumOcQWWE+0wtO8+O2s1w, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enproposalstatus2\".\"id\" o0, \"enproposalstatus2\".\"label\" o1, NULL o2, NULL o3, NULL o4");
fromBuilder.Append(" FROM {ProposalStatus} \"enproposalstatus2\"");
whereBuilder.Append(" WHERE (\"enproposalstatus2\".\"is_active\" = 1) AND (@qpboCheckUserSession = 1) AND ((((\"enproposalstatus2\".\"id\" = ");
whereBuilder.Append((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("_E7iZT05VUKHIKtah6ZsmQ"))).ssId);
whereBuilder.Append(") OR (\"enproposalstatus2\".\"id\" = ");
whereBuilder.Append((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("Ld4WSOtSaECFNAZ+2etxQA"))).ssId);
whereBuilder.Append(")) OR (\"enproposalstatus2\".\"id\" = ");
whereBuilder.Append((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("Abvh784e3UuM2GyF6VWeNw"))).ssId);
whereBuilder.Append(")) OR (\"enproposalstatus2\".\"id\" = ");
whereBuilder.Append((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("t1jXoCYmMkuMIabV4nC9iA"))).ssId);
whereBuilder.Append("))");
orderByBuilder.Append(" ORDER BY \"enproposalstatus2\".\"label\" ASC ");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query b_CyA_TreasuryCommissionsLeasing.ProposalsTreasury.GetProposalStatus.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query b_CyA_TreasuryCommissionsLeasing.ProposalsTreasury.GetProposalStatus.List", cancellationToken: cancellationToken);
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

private static async Task<RC_bb9053a6ea6eec7bc3ffbc5b5de7b452> datasetGetProposalsReadDbAsync(RC_bb9053a6ea6eec7bc3ffbc5b5de7b452 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENBank.Read( r, ref index);
rec.ssENCurrency.Read( r, ref index);
rec.ssENFileExtended.Read( r, ref index);
rec.ssENProposal.Read( r, ref index);
rec.ssENProposalStatus.Read( r, ref index);
rec.ssENProposalType.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
return rec;
}
// Query Function "GetProposals" 8Ns3PK0RKUOfFxDKNIkEUQ of Action "ProposalsTreasury"
public static async Task<(RL_f8f660cba6c51b3d6579cc8426c3f972,long)> datasetGetProposals(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,int qpinOffsetUtc,decimal qpdeTreasury_AmountMLFrom,decimal qpdeTreasury_AmountMLTo,string qpusProposal_AssignedToId,long qpbaProposal_BankId,DateTime qpdaTreasury_CreationDate,DateTime qpdaProposal_PaymentDate,string qpteTreasury_ProposalSearch,long qpreProposal_RegionId,int qpprProposal_ProposalStatusId,string qpteTableSort,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("b_CyA_TreasuryCommissionsLeasing.ProposalsTreasury.GetProposals", "3c37dbf0-11ad-4329-9f17-10ca34890451");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("ProposalsTreasury","b_CyA_TreasuryCommissionsLeasing.ProposalsTreasury.GetProposals");
// Query Iterations: Multiple
// Refresh Query 56h6xdOxWU+unkncyTSLnQ Iterations: Multiple
// Refresh Query h8j7ZoglrEW7CF7MpOz4Zg Iterations: Multiple
// Refresh Query jEnJP6zbmEi4KuP4ekfXrA Iterations: Multiple
// Refresh Query igwQWMgDHE6sj4GCG5RczA Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.sBq8pxDfr0GAxtE80fQu3g/NodesShownInESpaceTree.4uqcHnxIkUu8BPmnuO2Qgg/ScreenDataSets.8Ns3PK0RKUOfFxDKNIkEUQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enbank4\".\"name\" o1, NULL o2, NULL o3, NULL o4, NULL o5, \"encurrency30\".\"code\" o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, \"enproposal17\".\"id\" o18, \"enproposal17\".\"name\" o19, \"enproposal17\".\"paymentdate\" o20, \"enproposal17\".\"proposaldate\" o21, NULL o22, NULL o23, \"enproposal17\".\"proposalstatusid\" o24, NULL o25, NULL o26, trim_scale(\"enproposal17\".\"totalvalueml\"::numeric) o27, NULL o28, NULL o29, NULL o30, NULL o31, \"enproposal17\".\"createdon\" o32, NULL o33, \"enproposal17\".\"maxdatepaymentchanges\" o34, \"enproposal17\".\"assignedtoid\" o35, NULL o36, \"enproposalstatus3\".\"label\" o37, \"enproposalstatus3\".\"class\" o38, NULL o39, NULL o40, NULL o41, \"enproposaltype3\".\"label\" o42, NULL o43, NULL o44, NULL o45, NULL o46, \"enregion160\".\"name\" o47, NULL o48, NULL o49, \"enregion160\".\"commissionregion\" o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, \"enuser198\".\"name\" o59, NULL o60, NULL o61, NULL o62");
fromBuilder.Append(" FROM ((((((({FileExtended} \"enfileextended3\" Left JOIN {Proposal} \"enproposal17\" ON (\"enfileextended3\".\"id\" = \"enproposal17\".\"fileid\"))  Left JOIN {ProposalType} \"enproposaltype3\" ON (\"enproposal17\".\"proposaltypeid\" = \"enproposaltype3\".\"id\"))  Left JOIN {ProposalStatus} \"enproposalstatus3\" ON (\"enproposal17\".\"proposalstatusid\" = \"enproposalstatus3\".\"id\"))  Left JOIN {Bank} \"enbank4\" ON (\"enproposal17\".\"bankid\" = \"enbank4\".\"id\"))  Left JOIN {Region} \"enregion160\" ON (\"enproposal17\".\"regionid\" = \"enregion160\".\"id\"))  Left JOIN {Currency} \"encurrency30\" ON (\"enproposal17\".\"currencyid\" = \"encurrency30\".\"code\"))  Left JOIN {User} \"enuser198\" ON (\"enproposal17\".\"assignedtoid\" = \"enuser198\".\"id\")) ");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND ((((\"enproposal17\".\"proposalstatusid\" = ");
whereBuilder.Append((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("Ld4WSOtSaECFNAZ+2etxQA"))).ssId);
whereBuilder.Append(") OR (\"enproposal17\".\"proposalstatusid\" = ");
whereBuilder.Append((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("_E7iZT05VUKHIKtah6ZsmQ"))).ssId);
whereBuilder.Append(")) OR (\"enproposal17\".\"proposalstatusid\" = ");
whereBuilder.Append((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("Abvh784e3UuM2GyF6VWeNw"))).ssId);
whereBuilder.Append(")) OR (\"enproposal17\".\"proposalstatusid\" = ");
whereBuilder.Append((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("t1jXoCYmMkuMIabV4nC9iA"))).ssId);
whereBuilder.Append(")) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
sqlCountCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qpreProposal_RegionId != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpreProposal_RegionId != 0) {
whereBuilder.Append("((\"enproposal17\".\"regionid\" = @qpreProposal_RegionId) AND (\"enproposal17\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreProposal_RegionId", DbType.Int64, qpreProposal_RegionId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpreProposal_RegionId", DbType.Int64, qpreProposal_RegionId);
} else {
whereBuilder.Append("(\"enproposal17\".\"regionid\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpbaProposal_BankId != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpbaProposal_BankId != 0) {
whereBuilder.Append("((\"enproposal17\".\"bankid\" = @qpbaProposal_BankId) AND (\"enproposal17\".\"bankid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpbaProposal_BankId", DbType.Int64, qpbaProposal_BankId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpbaProposal_BankId", DbType.Int64, qpbaProposal_BankId);
} else {
whereBuilder.Append("(\"enproposal17\".\"bankid\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpdeTreasury_AmountMLFrom != (((decimal)0))) {
whereBuilder.Append("(\"enproposal17\".\"totalvalueml\" >= @qpdeTreasury_AmountMLFrom) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpdeTreasury_AmountMLFrom", DbType.Decimal, qpdeTreasury_AmountMLFrom);
sqlCountCmd.CreateParameterWithoutReplacements("@qpdeTreasury_AmountMLFrom", DbType.Decimal, qpdeTreasury_AmountMLFrom);
}
if (qpdeTreasury_AmountMLTo != (((decimal)0))) {
whereBuilder.Append("(\"enproposal17\".\"totalvalueml\" <= @qpdeTreasury_AmountMLTo) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpdeTreasury_AmountMLTo", DbType.Decimal, qpdeTreasury_AmountMLTo);
sqlCountCmd.CreateParameterWithoutReplacements("@qpdeTreasury_AmountMLTo", DbType.Decimal, qpdeTreasury_AmountMLTo);
}
if (qpdaProposal_PaymentDate != BuiltInFunction.NullDate()) {
whereBuilder.Append("(\"enproposal17\".\"paymentdate\"::date = @qpdaProposal_PaymentDate::date) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpdaProposal_PaymentDate", DbType.DateTime, qpdaProposal_PaymentDate);
sqlCountCmd.CreateParameterWithoutReplacements("@qpdaProposal_PaymentDate", DbType.DateTime, qpdaProposal_PaymentDate);
}
if (qpprProposal_ProposalStatusId != BuiltInFunction.NullIdentifier()) {
if (qpprProposal_ProposalStatusId != 0) {
whereBuilder.Append("((\"enproposal17\".\"proposalstatusid\" = @qpprProposal_ProposalStatusId) AND (\"enproposal17\".\"proposalstatusid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprProposal_ProposalStatusId", DbType.Int32, qpprProposal_ProposalStatusId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpprProposal_ProposalStatusId", DbType.Int32, qpprProposal_ProposalStatusId);
} else {
whereBuilder.Append("(\"enproposal17\".\"proposalstatusid\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpteTreasury_ProposalSearch != " " && qpteTreasury_ProposalSearch != "") {
whereBuilder.Append("(caseaccent_normalize(\"enproposal17\".\"name\" collate \"default\") like caseaccent_normalize((('%' || @qpteTreasury_ProposalSearch) || '%') collate \"default\")) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteTreasury_ProposalSearch", DbType.String, qpteTreasury_ProposalSearch);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteTreasury_ProposalSearch", DbType.String, qpteTreasury_ProposalSearch);
}
if (qpusProposal_AssignedToId != BuiltInFunction.NullTextIdentifier()) {
if ((qpusProposal_AssignedToId.Trim()!="")) {
whereBuilder.Append("((\"enproposal17\".\"assignedtoid\" = @qpusProposal_AssignedToId) AND (\"enproposal17\".\"assignedtoid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusProposal_AssignedToId", DbType.String, qpusProposal_AssignedToId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpusProposal_AssignedToId", DbType.String, qpusProposal_AssignedToId);
} else {
whereBuilder.Append("(\"enproposal17\".\"assignedtoid\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpdaTreasury_CreationDate != BuiltInFunction.NullDate()) {
whereBuilder.Append("((((\"enproposal17\".\"createdon\"::timestamptz + ((cast((@qpinOffsetUtc * (-1)) as integer)) * interval '1 hour'))) >= (@qpdaTreasury_CreationDate)) AND (((\"enproposal17\".\"createdon\"::timestamptz + ((cast((@qpinOffsetUtc * (-1)) as integer)) * interval '1 hour'))) < (((@qpdaTreasury_CreationDate)::timestamptz + ((cast(1 as integer)) * interval '1 day')))))");
sqlCmd.CreateParameterWithoutReplacements("@qpinOffsetUtc", DbType.Int32, qpinOffsetUtc);
sqlCountCmd.CreateParameterWithoutReplacements("@qpinOffsetUtc", DbType.Int32, qpinOffsetUtc);
sqlCmd.CreateParameterWithoutReplacements("@qpdaTreasury_CreationDate", DbType.DateTime, qpdaTreasury_CreationDate);
sqlCountCmd.CreateParameterWithoutReplacements("@qpdaTreasury_CreationDate", DbType.DateTime, qpdaTreasury_CreationDate);
}
string whereBuilderString = whereBuilder.ToString();
if (whereBuilderString.EndsWith(" AND ")) {
whereBuilder.Remove(whereBuilderString.Length - 5, 5);
}
orderByBuilder.Append(" ORDER BY ");
List<string> orderByColumns = new List<string>();
orderByColumns.AddRange(BaseAppUtils.ReplaceEntityReferencesAndAttributesInOrderBy(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, qpteTableSort, new string[] { "Bank", "ProposalType", "FileExtended", "Proposal", "User", "Region", "Currency", "ProposalStatus" }, new string[] { "ENBank4", "ENProposalType3", "ENFileExtended3", "ENProposal17", "ENUser198", "ENRegion160", "ENCurrency30", "ENProposalStatus3" }, new System.Collections.Generic.Dictionary<string, string>[] { ENBankEntity.AttributesToDatabaseNamesMap(), ENProposalTypeEntity.AttributesToDatabaseNamesMap(), ENFileExtendedEntity.AttributesToDatabaseNamesMap(), ENProposalEntity.AttributesToDatabaseNamesMap(), ENUserEntity.AttributesToDatabaseNamesMap(), ENRegionEntity.AttributesToDatabaseNamesMap(), ENCurrencyEntity.AttributesToDatabaseNamesMap(), ENProposalStatusEntity.AttributesToDatabaseNamesMap() }).Split(','));
orderByColumns.Add("\"enproposalstatus3\".\"order\" ASC ");
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
RL_f8f660cba6c51b3d6579cc8426c3f972 outParamList = new RL_f8f660cba6c51b3d6579cc8426c3f972();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetProposalsReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[8];
opt[0] = new BitArray(new bool[] {false, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, false, true, true, true});
opt[3] = new BitArray(new bool[] {false, false, false, false, true, true, false, true, true, false, true, true, true, true, false, true, false, false});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, false, true, true});
opt[6] = new BitArray(new bool[] {true, false, false, true, true});
opt[7] = new BitArray(new bool[] {true, true, false, true, true, false, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query b_CyA_TreasuryCommissionsLeasing.ProposalsTreasury.GetProposals.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query b_CyA_TreasuryCommissionsLeasing.ProposalsTreasury.GetProposals.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_f8f660cba6c51b3d6579cc8426c3f972 _tmp = new RL_f8f660cba6c51b3d6579cc8426c3f972();
_tmp.AlternateReadDbMethodAsync = datasetGetProposalsReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query b_CyA_TreasuryCommissionsLeasing.ProposalsTreasury.GetProposals.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_f8f660cba6c51b3d6579cc8426c3f972)_tmp;
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query b_CyA_TreasuryCommissionsLeasing.ProposalsTreasury.GetProposals.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
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

private static async Task<RC_24005b43e3f3ca8801049bcbbd68ea10> datasetGetProposalsSumReadDbAsync(RC_24005b43e3f3ca8801049bcbbd68ea10 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssSymbol = r.ReadText(index++, "SymbolTotalValueMLSumRecord.Symbol", "");
rec.ssTotalValueMLSum = r.ReadDecimal(index++, "SymbolTotalValueMLSumRecord.TotalValueMLSum", 0.0M);
return rec;
}
// Query Function "GetProposalsSum" N374RdFmDE2+wRxMfWm9bA of Action "ProposalsTreasury"
public static async Task<(RL_c43fa070956fae30a46b9d776792d6cc,long)> datasetGetProposalsSum(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,decimal qpdeTreasury_AmountMLFrom,decimal qpdeTreasury_AmountMLTo,string qpusProposal_AssignedToId,long qpbaProposal_BankId,DateTime qpdaTreasury_CreationDate,DateTime qpdaProposal_PaymentDate,string qpteTreasury_ProposalSearch,long qpreProposal_RegionId,int qpprProposal_ProposalStatusId,string qpteTableSort,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("b_CyA_TreasuryCommissionsLeasing.ProposalsTreasury.GetProposalsSum", "45f87e37-66d1-4d0c-bec1-1c4c7d69bd6c");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("ProposalsTreasury","b_CyA_TreasuryCommissionsLeasing.ProposalsTreasury.GetProposalsSum");
// Query Iterations: Never
// Refresh Query lt9dGUxFS0KUhTPWZd_EEA Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.sBq8pxDfr0GAxtE80fQu3g/NodesShownInESpaceTree.4uqcHnxIkUu8BPmnuO2Qgg/ScreenDataSets.N374RdFmDE2+wRxMfWm9bA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"encurrency31\".\"symbol\" \"symbol\", Sum(\"enproposal18\".\"totalvalueml\") \"totalvaluemlsum\"");
fromBuilder.Append(" FROM ((((((({FileExtended} \"enfileextended4\" Left JOIN {Proposal} \"enproposal18\" ON (\"enfileextended4\".\"id\" = \"enproposal18\".\"fileid\"))  Left JOIN {ProposalType} \"enproposaltype4\" ON (\"enproposal18\".\"proposaltypeid\" = \"enproposaltype4\".\"id\"))  Left JOIN {ProposalStatus} \"enproposalstatus4\" ON (\"enproposal18\".\"proposalstatusid\" = \"enproposalstatus4\".\"id\"))  Left JOIN {Bank} \"enbank5\" ON (\"enproposal18\".\"bankid\" = \"enbank5\".\"id\"))  Left JOIN {Region} \"enregion161\" ON (\"enproposal18\".\"regionid\" = \"enregion161\".\"id\"))  Left JOIN {Currency} \"encurrency31\" ON (\"enproposal18\".\"currencyid\" = \"encurrency31\".\"code\"))  Left JOIN {User} \"enuser199\" ON (\"enproposal18\".\"assignedtoid\" = \"enuser199\".\"id\")) ");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND ((((\"enproposal18\".\"proposalstatusid\" = ");
whereBuilder.Append((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("Ld4WSOtSaECFNAZ+2etxQA"))).ssId);
whereBuilder.Append(") OR (\"enproposal18\".\"proposalstatusid\" = ");
whereBuilder.Append((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("_E7iZT05VUKHIKtah6ZsmQ"))).ssId);
whereBuilder.Append(")) OR (\"enproposal18\".\"proposalstatusid\" = ");
whereBuilder.Append((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("Abvh784e3UuM2GyF6VWeNw"))).ssId);
whereBuilder.Append(")) OR (\"enproposal18\".\"proposalstatusid\" = ");
whereBuilder.Append((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("t1jXoCYmMkuMIabV4nC9iA"))).ssId);
whereBuilder.Append(")) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qpreProposal_RegionId != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpreProposal_RegionId != 0) {
whereBuilder.Append("((\"enproposal18\".\"regionid\" = @qpreProposal_RegionId) AND (\"enproposal18\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreProposal_RegionId", DbType.Int64, qpreProposal_RegionId);
} else {
whereBuilder.Append("(\"enproposal18\".\"regionid\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpbaProposal_BankId != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpbaProposal_BankId != 0) {
whereBuilder.Append("((\"enproposal18\".\"bankid\" = @qpbaProposal_BankId) AND (\"enproposal18\".\"bankid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpbaProposal_BankId", DbType.Int64, qpbaProposal_BankId);
} else {
whereBuilder.Append("(\"enproposal18\".\"bankid\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpdeTreasury_AmountMLFrom != (((decimal)0))) {
whereBuilder.Append("(\"enproposal18\".\"totalvalueml\" >= @qpdeTreasury_AmountMLFrom) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpdeTreasury_AmountMLFrom", DbType.Decimal, qpdeTreasury_AmountMLFrom);
}
if (qpdeTreasury_AmountMLTo != (((decimal)0))) {
whereBuilder.Append("(\"enproposal18\".\"totalvalueml\" <= @qpdeTreasury_AmountMLTo) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpdeTreasury_AmountMLTo", DbType.Decimal, qpdeTreasury_AmountMLTo);
}
if (qpdaProposal_PaymentDate != BuiltInFunction.NullDate()) {
whereBuilder.Append("(\"enproposal18\".\"paymentdate\"::date = @qpdaProposal_PaymentDate::date) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpdaProposal_PaymentDate", DbType.DateTime, qpdaProposal_PaymentDate);
}
if (qpprProposal_ProposalStatusId != BuiltInFunction.NullIdentifier()) {
if (qpprProposal_ProposalStatusId != 0) {
whereBuilder.Append("((\"enproposal18\".\"proposalstatusid\" = @qpprProposal_ProposalStatusId) AND (\"enproposal18\".\"proposalstatusid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprProposal_ProposalStatusId", DbType.Int32, qpprProposal_ProposalStatusId);
} else {
whereBuilder.Append("(\"enproposal18\".\"proposalstatusid\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpteTreasury_ProposalSearch != " " && qpteTreasury_ProposalSearch != "") {
whereBuilder.Append("(caseaccent_normalize(\"enproposal18\".\"name\" collate \"default\") like caseaccent_normalize((('%' || @qpteTreasury_ProposalSearch) || '%') collate \"default\")) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteTreasury_ProposalSearch", DbType.String, qpteTreasury_ProposalSearch);
}
if (qpusProposal_AssignedToId != BuiltInFunction.NullTextIdentifier()) {
if ((qpusProposal_AssignedToId.Trim()!="")) {
whereBuilder.Append("((\"enproposal18\".\"assignedtoid\" = @qpusProposal_AssignedToId) AND (\"enproposal18\".\"assignedtoid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusProposal_AssignedToId", DbType.String, qpusProposal_AssignedToId);
} else {
whereBuilder.Append("(\"enproposal18\".\"assignedtoid\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpdaTreasury_CreationDate != BuiltInFunction.NullDate()) {
whereBuilder.Append("((\"enproposal18\".\"createdon\" >= (@qpdaTreasury_CreationDate)) AND (\"enproposal18\".\"createdon\" < (((@qpdaTreasury_CreationDate)::timestamptz + ((cast(1 as integer)) * interval '1 day')))))");
sqlCmd.CreateParameterWithoutReplacements("@qpdaTreasury_CreationDate", DbType.DateTime, qpdaTreasury_CreationDate);
}
string whereBuilderString = whereBuilder.ToString();
if (whereBuilderString.EndsWith(" AND ")) {
whereBuilder.Remove(whereBuilderString.Length - 5, 5);
}
groupByBuilder.Append(" GROUP BY \"encurrency31\".\"symbol\"");
orderByBuilder.Append(" ORDER BY 1 ASC");
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
RL_c43fa070956fae30a46b9d776792d6cc outParamList = new RL_c43fa070956fae30a46b9d776792d6cc();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetProposalsSumReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[0];
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query b_CyA_TreasuryCommissionsLeasing.ProposalsTreasury.GetProposalsSum.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_c43fa070956fae30a46b9d776792d6cc _tmp = new RL_c43fa070956fae30a46b9d776792d6cc();
_tmp.AlternateReadDbMethodAsync = datasetGetProposalsSumReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query b_CyA_TreasuryCommissionsLeasing.ProposalsTreasury.GetProposalsSum.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_c43fa070956fae30a46b9d776792d6cc)_tmp;
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

// Query Function "GetOperators" sPicUtpipEeTrFla+cQxOQ of Action "ProposalsTreasury"
public static async Task<(RL_f03e17396f660361b67a45f0e1101893,long)> datasetGetOperators(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("b_CyA_TreasuryCommissionsLeasing.ProposalsTreasury.GetOperators", "529cf8b0-62da-47a4-93ac-595af9c43139");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("ProposalsTreasury","b_CyA_TreasuryCommissionsLeasing.ProposalsTreasury.GetOperators");
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
selectBuilder.Append("/* /NRWebFlows.sBq8pxDfr0GAxtE80fQu3g/NodesShownInESpaceTree.4uqcHnxIkUu8BPmnuO2Qgg/ScreenDataSets.sPicUtpipEeTrFla+cQxOQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3");
fromBuilder.Append(" FROM {Operator} \"enoperator1\"");
whereBuilder.Append(" WHERE (\"enoperator1\".\"is_active\" = 1) AND (@qpboCheckUserSession = 1)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query b_CyA_TreasuryCommissionsLeasing.ProposalsTreasury.GetOperators.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query b_CyA_TreasuryCommissionsLeasing.ProposalsTreasury.GetOperators.List", cancellationToken: cancellationToken);
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

// Query Function "GetBanks" iM+UhF6iAUutFMzAjGgMZA of Action "ProposalsTreasury"
public static async Task<(RL_0fc5fa92a15115f6e97a1071c9876bcd,long)> datasetGetBanks(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("b_CyA_TreasuryCommissionsLeasing.ProposalsTreasury.GetBanks", "8494cf88-a25e-4b01-ad14-ccc08c680c64");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("ProposalsTreasury","b_CyA_TreasuryCommissionsLeasing.ProposalsTreasury.GetBanks");
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
selectBuilder.Append("/* /NRWebFlows.sBq8pxDfr0GAxtE80fQu3g/NodesShownInESpaceTree.4uqcHnxIkUu8BPmnuO2Qgg/ScreenDataSets.iM+UhF6iAUutFMzAjGgMZA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enbank6\".\"id\" o0, \"enbank6\".\"name\" o1, NULL o2, NULL o3, NULL o4, NULL o5");
fromBuilder.Append(" FROM {Bank} \"enbank6\"");
whereBuilder.Append(" WHERE (\"enbank6\".\"isactive\" = 1) AND (@qpboCheckUserSession = 1)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query b_CyA_TreasuryCommissionsLeasing.ProposalsTreasury.GetBanks.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query b_CyA_TreasuryCommissionsLeasing.ProposalsTreasury.GetBanks.List", cancellationToken: cancellationToken);
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

private static async Task<RC_8129c2d9846bc83a20ef6f3e7b60c809> datasetGetProposalsAssignReadDbAsync(RC_8129c2d9846bc83a20ef6f3e7b60c809 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssId = r.ReadEntityReferenceText(index++, "IdNameRecord.Id", "");
rec.ssName = r.ReadText(index++, "IdNameRecord.Name", "");
return rec;
}
// Query Function "GetProposalsAssign" VAxgmyDzQ0+ZIj7q2q0lGQ of Action "ProposalsTreasury"
public static async Task<(RL_999b467c81e0dee8574a63e95d64104c,long)> datasetGetProposalsAssign(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,string qpteTableSort,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("b_CyA_TreasuryCommissionsLeasing.ProposalsTreasury.GetProposalsAssign", "9b600c54-f320-4f43-9922-3eeadaad2519");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("ProposalsTreasury","b_CyA_TreasuryCommissionsLeasing.ProposalsTreasury.GetProposalsAssign");
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
selectBuilder.Append("/* /NRWebFlows.sBq8pxDfr0GAxtE80fQu3g/NodesShownInESpaceTree.4uqcHnxIkUu8BPmnuO2Qgg/ScreenDataSets.VAxgmyDzQ0+ZIj7q2q0lGQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enuser200\".\"id\" \"id\", \"enuser200\".\"name\" \"name\"");
fromBuilder.Append(" FROM (({Proposal} \"enproposal19\" Left JOIN {ProposalStatus} \"enproposalstatus5\" ON (\"enproposal19\".\"proposalstatusid\" = \"enproposalstatus5\".\"id\"))  Inner JOIN {User} \"enuser200\" ON (\"enproposal19\".\"assignedtoid\" = \"enuser200\".\"id\")) ");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND ((((\"enproposal19\".\"proposalstatusid\" = ");
whereBuilder.Append((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("Ld4WSOtSaECFNAZ+2etxQA"))).ssId);
whereBuilder.Append(") OR (\"enproposal19\".\"proposalstatusid\" = ");
whereBuilder.Append((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("_E7iZT05VUKHIKtah6ZsmQ"))).ssId);
whereBuilder.Append(")) OR (\"enproposal19\".\"proposalstatusid\" = ");
whereBuilder.Append((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("Abvh784e3UuM2GyF6VWeNw"))).ssId);
whereBuilder.Append(")) OR (\"enproposal19\".\"proposalstatusid\" = ");
whereBuilder.Append((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("t1jXoCYmMkuMIabV4nC9iA"))).ssId);
whereBuilder.Append("))");
groupByBuilder.Append(" GROUP BY \"enuser200\".\"name\", \"enuser200\".\"id\"");
orderByBuilder.Append(" ORDER BY \"name\" ASC ");
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
RL_999b467c81e0dee8574a63e95d64104c outParamList = new RL_999b467c81e0dee8574a63e95d64104c();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetProposalsAssignReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[0];
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query b_CyA_TreasuryCommissionsLeasing.ProposalsTreasury.GetProposalsAssign.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_999b467c81e0dee8574a63e95d64104c _tmp = new RL_999b467c81e0dee8574a63e95d64104c();
_tmp.AlternateReadDbMethodAsync = datasetGetProposalsAssignReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query b_CyA_TreasuryCommissionsLeasing.ProposalsTreasury.GetProposalsAssign.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_999b467c81e0dee8574a63e95d64104c)_tmp;
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

// Query Function "GetRegions" 2M062BmOeUOr9UiYNQKE4Q of Action "ProposalsTreasury"
public static async Task<(RL_5d3a02aa993c7474297e33d992f39ad0,long)> datasetGetRegions(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("b_CyA_TreasuryCommissionsLeasing.ProposalsTreasury.GetRegions", "d83acdd8-8e19-4379-abf5-4898350284e1");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("ProposalsTreasury","b_CyA_TreasuryCommissionsLeasing.ProposalsTreasury.GetRegions");
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
selectBuilder.Append("/* /NRWebFlows.sBq8pxDfr0GAxtE80fQu3g/NodesShownInESpaceTree.4uqcHnxIkUu8BPmnuO2Qgg/ScreenDataSets.2M062BmOeUOr9UiYNQKE4Q, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enregion162\".\"id\" o0, NULL o1, \"enregion162\".\"name\" o2, NULL o3, NULL o4, \"enregion162\".\"commissionregion\" o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12");
fromBuilder.Append(" FROM {Region} \"enregion162\"");
whereBuilder.Append(" WHERE (\"enregion162\".\"isactive\" = 1) AND (@qpboCheckUserSession = 1)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query b_CyA_TreasuryCommissionsLeasing.ProposalsTreasury.GetRegions.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query b_CyA_TreasuryCommissionsLeasing.ProposalsTreasury.GetRegions.List", cancellationToken: cancellationToken);
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


    

    

}
