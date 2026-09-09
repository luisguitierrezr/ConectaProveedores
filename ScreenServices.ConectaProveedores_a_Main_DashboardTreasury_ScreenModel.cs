using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_a_Main_DashboardTreasury_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_a_Main_DashboardTreasury_ScreenModel).Namespace);

    public AggregateRecord<RL_f8f660cba6c51b3d6579cc8426c3f972> ScreenDataSetGetLast10Proposals;
public ConectaProveedores_a_Main_DashboardTreasury_DataActionGetPartiallyPaidProposals_Model varLcGetPartiallyPaidProposals;
public ConectaProveedores_a_Main_DashboardTreasury_DataActionGetPaidProposals_Model varLcGetPaidProposals;
public ConectaProveedores_a_Main_DashboardTreasury_DataActionGetActiveProposals_Model varLcGetActiveProposals;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_a_Main_DashboardTreasury_ScreenModel() {
}



    public ConectaProveedores_a_Main_DashboardTreasury_ScreenModel(AggregateRecord<RL_f8f660cba6c51b3d6579cc8426c3f972> ScreenDataSetGetLast10Proposals, ConectaProveedores_a_Main_DashboardTreasury_DataActionGetPartiallyPaidProposals_Model varLcGetPartiallyPaidProposals, ConectaProveedores_a_Main_DashboardTreasury_DataActionGetPaidProposals_Model varLcGetPaidProposals, ConectaProveedores_a_Main_DashboardTreasury_DataActionGetActiveProposals_Model varLcGetActiveProposals, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"GetLast10Proposals", "GetPartiallyPaidProposals", "GetPaidProposals", "GetActiveProposals", "ClientVars"}, new string[] {"ScreenDataSetGetLast10Proposals", "varLcGetPartiallyPaidProposals", "varLcGetPaidProposals", "varLcGetActiveProposals", "clientVariables"});
this.ScreenDataSetGetLast10Proposals = ScreenDataSetGetLast10Proposals;
this.varLcGetPartiallyPaidProposals = varLcGetPartiallyPaidProposals;
this.varLcGetPaidProposals = varLcGetPaidProposals;
this.varLcGetActiveProposals = varLcGetActiveProposals;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_bb9053a6ea6eec7bc3ffbc5b5de7b452> datasetGetLast10ProposalsReadDbAsync(RC_bb9053a6ea6eec7bc3ffbc5b5de7b452 rec, DbDataReader r, CancellationToken cancellationToken) {
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
// Query Function "GetLast10Proposals" 8dGB8iTJkUqyCAZmCD12dQ of Action "DashboardTreasury"
public static async Task<(RL_f8f660cba6c51b3d6579cc8426c3f972,long)> datasetGetLast10Proposals(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,string qpusProposal_AssignedToId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("a_Main.DashboardTreasury.GetLast10Proposals", "f281d1f1-c924-4a91-b208-0666083d7675");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("DashboardTreasury","a_Main.DashboardTreasury.GetLast10Proposals");
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
selectBuilder.Append("/* /NRWebFlows.DXvJuqeTzUGsVyrZCiDRvQ/NodesShownInESpaceTree.TbUTAn9KRU2yR7I5dNwzlg/ScreenDataSets.8dGB8iTJkUqyCAZmCD12dQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enbank8\".\"name\" o1, NULL o2, NULL o3, NULL o4, NULL o5, \"encurrency33\".\"code\" o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, \"enproposal21\".\"id\" o18, \"enproposal21\".\"name\" o19, \"enproposal21\".\"paymentdate\" o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, trim_scale(\"enproposal21\".\"totalvalueml\"::numeric) o27, NULL o28, NULL o29, NULL o30, NULL o31, \"enproposal21\".\"createdon\" o32, NULL o33, NULL o34, \"enproposal21\".\"assignedtoid\" o35, NULL o36, \"enproposalstatus7\".\"label\" o37, \"enproposalstatus7\".\"class\" o38, NULL o39, NULL o40, NULL o41, \"enproposaltype6\".\"label\" o42, NULL o43, NULL o44, NULL o45, NULL o46, \"enregion164\".\"name\" o47, NULL o48, NULL o49, \"enregion164\".\"commissionregion\" o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, \"enuser201\".\"name\" o59, NULL o60, NULL o61, NULL o62");
fromBuilder.Append(" FROM ((((((({Proposal} \"enproposal21\" Left JOIN {User} \"enuser201\" ON (\"enproposal21\".\"assignedtoid\" = \"enuser201\".\"id\"))  Left JOIN {Bank} \"enbank8\" ON (\"enproposal21\".\"bankid\" = \"enbank8\".\"id\"))  Left JOIN {Region} \"enregion164\" ON (\"enproposal21\".\"regionid\" = \"enregion164\".\"id\"))  Left JOIN {Currency} \"encurrency33\" ON (\"enproposal21\".\"currencyid\" = \"encurrency33\".\"code\"))  Right JOIN {FileExtended} \"enfileextended6\" ON (\"enfileextended6\".\"id\" = \"enproposal21\".\"fileid\"))  Left JOIN {ProposalType} \"enproposaltype6\" ON (\"enproposal21\".\"proposaltypeid\" = \"enproposaltype6\".\"id\"))  Left JOIN {ProposalStatus} \"enproposalstatus7\" ON (\"enproposal21\".\"proposalstatusid\" = \"enproposalstatus7\".\"id\")) ");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND (((\"enproposal21\".\"proposalstatusid\" = ");
whereBuilder.Append((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("Ld4WSOtSaECFNAZ+2etxQA"))).ssId);
whereBuilder.Append(") OR (\"enproposal21\".\"proposalstatusid\" = ");
whereBuilder.Append((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("_E7iZT05VUKHIKtah6ZsmQ"))).ssId);
whereBuilder.Append(")) OR (\"enproposal21\".\"proposalstatusid\" = ");
whereBuilder.Append((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("Abvh784e3UuM2GyF6VWeNw"))).ssId);
whereBuilder.Append(")) AND ((\"enproposal21\".\"assignedtoid\" IS NULL) OR ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if ((qpusProposal_AssignedToId.Trim()!="")) {
whereBuilder.Append("((\"enproposal21\".\"assignedtoid\" = @qpusProposal_AssignedToId) AND (\"enproposal21\".\"assignedtoid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusProposal_AssignedToId", DbType.String, qpusProposal_AssignedToId);
} else {
whereBuilder.Append("(\"enproposal21\".\"assignedtoid\" IS NULL)");
}
whereBuilder.Append(")");
orderByBuilder.Append(" ORDER BY \"enproposal21\".\"id\" DESC ");
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
RL_f8f660cba6c51b3d6579cc8426c3f972 outParamList = new RL_f8f660cba6c51b3d6579cc8426c3f972();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetLast10ProposalsReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[8];
opt[0] = new BitArray(new bool[] {false, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, false, true, true, true});
opt[3] = new BitArray(new bool[] {false, false, false, true, true, true, true, true, true, false, true, true, true, true, false, true, true, false});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, false, true, true});
opt[6] = new BitArray(new bool[] {true, false, false, true, true});
opt[7] = new BitArray(new bool[] {true, true, false, true, true, false, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query a_Main.DashboardTreasury.GetLast10Proposals.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_f8f660cba6c51b3d6579cc8426c3f972 _tmp = new RL_f8f660cba6c51b3d6579cc8426c3f972();
_tmp.AlternateReadDbMethodAsync = datasetGetLast10ProposalsReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query a_Main.DashboardTreasury.GetLast10Proposals.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_f8f660cba6c51b3d6579cc8426c3f972)_tmp;
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


    public class lcvGetPartiallyPaidProposals : VarsBag {
public RL_5c41e853b96e612f21c832865afaaa1f queryResGetPartiallyPaidProposalsQuery_outParamList = new RL_5c41e853b96e612f21c832865afaaa1f();
public long queryResGetPartiallyPaidProposalsQuery_outParamCount = 0L;

public lcvGetPartiallyPaidProposals() {
}
}
public class lcoGetPartiallyPaidProposals : VarsBag {
public RL_496abaeba4975b81a1a9b391230e8099 outParamPartiallyPaidProposals = new RL_496abaeba4975b81a1a9b391230e8099();

public int outParamo_TotalCount = 0;

public lcoGetPartiallyPaidProposals() {
}
}
/// <summary>
/// Action <code>GetPartiallyPaidProposals</code> that represents the Service Studio action
///  <code>GetPartiallyPaidProposals</code> <p> Description: Get Partially Paid Proposals count.</p>
/// </summary>
public async Task<(RL_496abaeba4975b81a1a9b391230e8099,int)> DataActionGetPartiallyPaidProposals(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_496abaeba4975b81a1a9b391230e8099 outParamPartiallyPaidProposals = default;
int outParamo_TotalCount = default;
lcoGetPartiallyPaidProposals result = new lcoGetPartiallyPaidProposals();
lcvGetPartiallyPaidProposals localVars = new lcvGetPartiallyPaidProposals();
ConectaProveedores_a_Main_DashboardTreasury_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetPartiallyPaidProposals", "0be395ed-2b37-4515-a233-e4d7d06b73c5"))
using (activitySource.CreateScreenDataActionActivity("DashboardTreasury", "GetPartiallyPaidProposals")){
// Query QueryGetPartiallyPaidProposalsQuery
cancellationToken.ThrowIfCancellationRequested();
int QueryGetPartiallyPaidProposalsQuery_maxRecords = 0;
int QueryGetPartiallyPaidProposalsQuery_startIndex = 0;(localVars.queryResGetPartiallyPaidProposalsQuery_outParamList,localVars.queryResGetPartiallyPaidProposalsQuery_outParamCount) = await FuncDataActionGetPartiallyPaidProposals.QueryGetPartiallyPaidProposalsQuery(requestContext,QueryGetPartiallyPaidProposalsQuery_maxRecords,QueryGetPartiallyPaidProposalsQuery_startIndex,IterationMultiplicity.Single,BuiltInFunction.DateTimeToDate(BuiltInFunction.AddDays (BuiltInFunction.NewDate (BuiltInFunction.Year (BuiltInFunction.CurrDate ()), BuiltInFunction.Month (BuiltInFunction.CurrDate ()), 1), (-1))),BuiltInFunction.DateTimeToDate(BuiltInFunction.AddMonths (BuiltInFunction.NewDate (BuiltInFunction.Year (BuiltInFunction.CurrDate ()), BuiltInFunction.Month (BuiltInFunction.CurrDate ()), 1), 1)),(ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("Abvh784e3UuM2GyF6VWeNw"))).ssId,BuiltInFunction.CurrDate (),cancellationToken);

// PartiallyPaidProposals = GetPartiallyPaidProposalsQuery.List
result.outParamPartiallyPaidProposals=(await RL_496abaeba4975b81a1a9b391230e8099.ConvertAsync(localVars.queryResGetPartiallyPaidProposalsQuery_outParamList, new RL_496abaeba4975b81a1a9b391230e8099(), async (RC_6dc2ea62d515aadb2abe8127d022eca8 source, ST_bfed96b4bd29e9b06f0b06e901b1508bStructure target, CancellationToken cancellationToken) => {
target = source;
return target;
}, cancellationToken));
// Foreach GetPartiallyPaidProposalsQuery.List
localVars.queryResGetPartiallyPaidProposalsQuery_outParamList.StartIteration();
try {while (!((localVars.queryResGetPartiallyPaidProposalsQuery_outParamList.Eof))) {
// o_TotalCount = o_TotalCount + GetPartiallyPaidProposalsQuery.List.Current.Counter.Count
result.outParamo_TotalCount=(result.outParamo_TotalCount+localVars.queryResGetPartiallyPaidProposalsQuery_outParamList.CurrentRec.ssSTCounter.ssCount);
localVars.queryResGetPartiallyPaidProposalsQuery_outParamList.Advance();
}

} finally {
localVars.queryResGetPartiallyPaidProposalsQuery_outParamList.EndIteration();
}

} //close CreateActionActivity using block
} // try

finally {
outParamPartiallyPaidProposals = result.outParamPartiallyPaidProposals;
outParamo_TotalCount = result.outParamo_TotalCount;
} // inner-finally
RETURN_STATEMENT:
return (outParamPartiallyPaidProposals,outParamo_TotalCount);
}
public class lcvGetPaidProposals : VarsBag {
public RL_5c41e853b96e612f21c832865afaaa1f queryResGetPaidProposalsQuery_outParamList = new RL_5c41e853b96e612f21c832865afaaa1f();
public long queryResGetPaidProposalsQuery_outParamCount = 0L;

public lcvGetPaidProposals() {
}
}
public class lcoGetPaidProposals : VarsBag {
public RL_496abaeba4975b81a1a9b391230e8099 outParamPaidProposals = new RL_496abaeba4975b81a1a9b391230e8099();

public int outParamo_TotalCount = 0;

public lcoGetPaidProposals() {
}
}
/// <summary>
/// Action <code>GetPaidProposals</code> that represents the Service Studio action
///  <code>GetPaidProposals</code> <p> Description: Get Paid Proposals count.</p>
/// </summary>
public async Task<(RL_496abaeba4975b81a1a9b391230e8099,int)> DataActionGetPaidProposals(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_496abaeba4975b81a1a9b391230e8099 outParamPaidProposals = default;
int outParamo_TotalCount = default;
lcoGetPaidProposals result = new lcoGetPaidProposals();
lcvGetPaidProposals localVars = new lcvGetPaidProposals();
ConectaProveedores_a_Main_DashboardTreasury_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetPaidProposals", "b547afd4-06c8-48b8-8f55-444a7d30c62d"))
using (activitySource.CreateScreenDataActionActivity("DashboardTreasury", "GetPaidProposals")){
// Query QueryGetPaidProposalsQuery
cancellationToken.ThrowIfCancellationRequested();
int QueryGetPaidProposalsQuery_maxRecords = 99999;
if (QueryGetPaidProposalsQuery_maxRecords < 1) QueryGetPaidProposalsQuery_maxRecords = 1;
int QueryGetPaidProposalsQuery_startIndex = 0;(localVars.queryResGetPaidProposalsQuery_outParamList,localVars.queryResGetPaidProposalsQuery_outParamCount) = await FuncDataActionGetPaidProposals.QueryGetPaidProposalsQuery(requestContext,QueryGetPaidProposalsQuery_maxRecords,QueryGetPaidProposalsQuery_startIndex,IterationMultiplicity.Single,BuiltInFunction.DateTimeToDate(BuiltInFunction.AddDays (BuiltInFunction.NewDate (BuiltInFunction.Year (BuiltInFunction.CurrDate ()), BuiltInFunction.Month (BuiltInFunction.CurrDate ()), 1), (-1))),BuiltInFunction.DateTimeToDate(BuiltInFunction.AddMonths (BuiltInFunction.NewDate (BuiltInFunction.Year (BuiltInFunction.CurrDate ()), BuiltInFunction.Month (BuiltInFunction.CurrDate ()), 1), 1)),(ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("t1jXoCYmMkuMIabV4nC9iA"))).ssId,cancellationToken);

// PaidProposals = GetPaidProposalsQuery.List
result.outParamPaidProposals=(await RL_496abaeba4975b81a1a9b391230e8099.ConvertAsync(localVars.queryResGetPaidProposalsQuery_outParamList, new RL_496abaeba4975b81a1a9b391230e8099(), async (RC_6dc2ea62d515aadb2abe8127d022eca8 source, ST_bfed96b4bd29e9b06f0b06e901b1508bStructure target, CancellationToken cancellationToken) => {
target = source;
return target;
}, cancellationToken));
// Foreach GetPaidProposalsQuery.List
localVars.queryResGetPaidProposalsQuery_outParamList.StartIteration();
try {while (!((localVars.queryResGetPaidProposalsQuery_outParamList.Eof))) {
// o_TotalCount = o_TotalCount + GetPaidProposalsQuery.List.Current.Counter.Count
result.outParamo_TotalCount=(result.outParamo_TotalCount+localVars.queryResGetPaidProposalsQuery_outParamList.CurrentRec.ssSTCounter.ssCount);
localVars.queryResGetPaidProposalsQuery_outParamList.Advance();
}

} finally {
localVars.queryResGetPaidProposalsQuery_outParamList.EndIteration();
}

} //close CreateActionActivity using block
} // try

finally {
outParamPaidProposals = result.outParamPaidProposals;
outParamo_TotalCount = result.outParamo_TotalCount;
} // inner-finally
RETURN_STATEMENT:
return (outParamPaidProposals,outParamo_TotalCount);
}
public class lcvGetActiveProposals : VarsBag {
public RL_5c41e853b96e612f21c832865afaaa1f queryResGetActiveProposalsQuery_outParamList = new RL_5c41e853b96e612f21c832865afaaa1f();
public long queryResGetActiveProposalsQuery_outParamCount = 0L;

public lcvGetActiveProposals() {
}
}
public class lcoGetActiveProposals : VarsBag {
public RL_496abaeba4975b81a1a9b391230e8099 outParamActiveProposals = new RL_496abaeba4975b81a1a9b391230e8099();

public int outParamo_TotalCount = 0;

public lcoGetActiveProposals() {
}
}
/// <summary>
/// Action <code>GetActiveProposals</code> that represents the Service Studio action
///  <code>GetActiveProposals</code> <p> Description: Get Active Proposals Active for paymen
/// t count.</p>
/// </summary>
public async Task<(RL_496abaeba4975b81a1a9b391230e8099,int)> DataActionGetActiveProposals(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_496abaeba4975b81a1a9b391230e8099 outParamActiveProposals = default;
int outParamo_TotalCount = default;
lcoGetActiveProposals result = new lcoGetActiveProposals();
lcvGetActiveProposals localVars = new lcvGetActiveProposals();
ConectaProveedores_a_Main_DashboardTreasury_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetActiveProposals", "ba24b6cf-904e-4ec6-b5e2-5c558c01e6a7"))
using (activitySource.CreateScreenDataActionActivity("DashboardTreasury", "GetActiveProposals")){
// Query QueryGetActiveProposalsQuery
cancellationToken.ThrowIfCancellationRequested();
int QueryGetActiveProposalsQuery_maxRecords = 0;
int QueryGetActiveProposalsQuery_startIndex = 0;(localVars.queryResGetActiveProposalsQuery_outParamList,localVars.queryResGetActiveProposalsQuery_outParamCount) = await FuncDataActionGetActiveProposals.QueryGetActiveProposalsQuery(requestContext,QueryGetActiveProposalsQuery_maxRecords,QueryGetActiveProposalsQuery_startIndex,IterationMultiplicity.Multiple,(ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("Ld4WSOtSaECFNAZ+2etxQA"))).ssId,(ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("_E7iZT05VUKHIKtah6ZsmQ"))).ssId,(ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("Abvh784e3UuM2GyF6VWeNw"))).ssId,BuiltInFunction.GetUserId (),BuiltInFunction.CurrDate (),cancellationToken);

// ActiveProposals = GetActiveProposalsQuery.List
result.outParamActiveProposals=(await RL_496abaeba4975b81a1a9b391230e8099.ConvertAsync(localVars.queryResGetActiveProposalsQuery_outParamList, new RL_496abaeba4975b81a1a9b391230e8099(), async (RC_6dc2ea62d515aadb2abe8127d022eca8 source, ST_bfed96b4bd29e9b06f0b06e901b1508bStructure target, CancellationToken cancellationToken) => {
target = source;
return target;
}, cancellationToken));
// Foreach GetActiveProposalsQuery.List
localVars.queryResGetActiveProposalsQuery_outParamList.StartIteration();
try {while (!((localVars.queryResGetActiveProposalsQuery_outParamList.Eof))) {
// o_TotalCount = o_TotalCount + GetActiveProposalsQuery.List.Current.Counter.Count
result.outParamo_TotalCount=(result.outParamo_TotalCount+localVars.queryResGetActiveProposalsQuery_outParamList.CurrentRec.ssSTCounter.ssCount);
localVars.queryResGetActiveProposalsQuery_outParamList.Advance();
}

} finally {
localVars.queryResGetActiveProposalsQuery_outParamList.EndIteration();
}

} //close CreateActionActivity using block
} // try

finally {
outParamActiveProposals = result.outParamActiveProposals;
outParamo_TotalCount = result.outParamo_TotalCount;
} // inner-finally
RETURN_STATEMENT:
return (outParamActiveProposals,outParamo_TotalCount);
}


    public static class FuncDataActionGetPartiallyPaidProposals {

// Query Function "GetPartiallyPaidProposalsQuery" kf0PKhtke0an9zw7Se1OiA of Action "GetPartiallyPaidProposals"
public static async Task<(RL_5c41e853b96e612f21c832865afaaa1f,long)> QueryGetPartiallyPaidProposalsQuery(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,DateTime qpdaMinDate,DateTime qpdaMaxDate,int qpprPartiallyPaidStatus,DateTime qpdaCurrDate,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("a_Main.DashboardTreasury.GetPartiallyPaidProposals.GetPartiallyPaidProposalsQuery", "2a0ffd91-641b-467b-a7f7-3c3b49ed4e88");
using var queryActivity = activitySource.CreateSqlQueryActivity("a_Main.DashboardTreasury.GetPartiallyPaidProposals.GetPartiallyPaidProposalsQuery", "2a0ffd91-641b-467b-a7f7-3c3b49ed4e88", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Single
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string entityProposal = AppUtils.Instance.RuntimeEntityReplace("Proposal");
string entityProposalStatus = AppUtils.Instance.RuntimeEntityReplace("ProposalStatus");
sqlCmd.CreateParameter("@qpdaMinDate", DbType.DateTime, qpdaMinDate);
sqlCmd.CreateParameter("@qpdaMaxDate", DbType.DateTime, qpdaMaxDate);
sqlCmd.CreateParameter("@qpprPartiallyPaidStatus", DbType.Int32, qpprPartiallyPaidStatus);
sqlCmd.CreateParameter("@qpdaCurrDate", DbType.DateTime, qpdaCurrDate);
string sql = "";
string advSql = "SELECT \n    ps.label, \n    COUNT(*) AS proposal_count \nFROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,"") + " p \nJOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalStatus,"") + " ps \n    ON ps.Id = p.ProposalStatusId \n    AND p.CreatedOn BETWEEN @qpdaMinDate and @qpdaMaxDate \n    AND p.ProposalStatusId = @qpprPartiallyPaidStatus \n    AND p.MaxDatePaymentChanges > @qpdaCurrDate \nGROUP BY \n    ps.label";
sql = advSql;
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_5c41e853b96e612f21c832865afaaa1f outParamList = new RL_5c41e853b96e612f21c832865afaaa1f();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query a_Main.DashboardTreasury.GetPartiallyPaidProposals.GetPartiallyPaidProposalsQuery.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_5c41e853b96e612f21c832865afaaa1f _tmp = new RL_5c41e853b96e612f21c832865afaaa1f();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query a_Main.DashboardTreasury.GetPartiallyPaidProposals.GetPartiallyPaidProposalsQuery.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_5c41e853b96e612f21c832865afaaa1f)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetPartiallyPaidProposalsQuery in GetPartiallyPaidProposals in DashboardTreasury in a_Main in ConectaProveedores (SELECT      ps.label,      COUNT(*) AS proposal_count  FROM {Proposal} p  JOIN {ProposalStatus} ps      ON ps.Id = p.ProposalStatusId      AND p.CreatedOn BETWEEN @MinDate and @MaxDate      AND p.ProposalStatusId = @PartiallyPaidStatus      AND p.MaxDatePaymentChanges > @CurrDate  GROUP BY      ps.label): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetPartiallyPaidProposalsQuery in GetPartiallyPaidProposals in DashboardTreasury in a_Main in ConectaProveedores (SELECT      ps.label,      COUNT(*) AS proposal_count  FROM {Proposal} p  JOIN {ProposalStatus} ps      ON ps.Id = p.ProposalStatusId      AND p.CreatedOn BETWEEN @MinDate and @MaxDate      AND p.ProposalStatusId = @PartiallyPaidStatus      AND p.MaxDatePaymentChanges > @CurrDate  GROUP BY      ps.label): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetPartiallyPaidProposalsQuery in GetPartiallyPaidProposals in DashboardTreasury in a_Main in ConectaProveedores (SELECT      ps.label,      COUNT(*) AS proposal_count  FROM {Proposal} p  JOIN {ProposalStatus} ps      ON ps.Id = p.ProposalStatusId      AND p.CreatedOn BETWEEN @MinDate and @MaxDate      AND p.ProposalStatusId = @PartiallyPaidStatus      AND p.MaxDatePaymentChanges > @CurrDate  GROUP BY      ps.label): " + aqExcep.Message));
}
}
}
}
public static class FuncDataActionGetPaidProposals {

// Query Function "GetPaidProposalsQuery" Odpov42GP0K_dNTkxTcWRw of Action "GetPaidProposals"
public static async Task<(RL_5c41e853b96e612f21c832865afaaa1f,long)> QueryGetPaidProposalsQuery(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,DateTime qpdaMinDate,DateTime qpdaMaxDate,int qpprPaidStatus,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("a_Main.DashboardTreasury.GetPaidProposals.GetPaidProposalsQuery", "bf68da39-868d-423f-bf74-d4e4c5371647");
using var queryActivity = activitySource.CreateSqlQueryActivity("a_Main.DashboardTreasury.GetPaidProposals.GetPaidProposalsQuery", "bf68da39-868d-423f-bf74-d4e4c5371647", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Single
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string entityProposal = AppUtils.Instance.RuntimeEntityReplace("Proposal");
string entityProposalStatus = AppUtils.Instance.RuntimeEntityReplace("ProposalStatus");
sqlCmd.CreateParameter("@qpdaMinDate", DbType.DateTime, qpdaMinDate);
sqlCmd.CreateParameter("@qpdaMaxDate", DbType.DateTime, qpdaMaxDate);
sqlCmd.CreateParameter("@qpprPaidStatus", DbType.Int32, qpprPaidStatus);
string sql = "";
string advSql = "SELECT \n    ps.label, \n    COUNT(*) AS proposal_count \nFROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,"") + " p \nJOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalStatus,"") + " ps \n    ON ps.Id = p.ProposalStatusId \n    AND p.CreatedOn BETWEEN @qpdaMinDate and @qpdaMaxDate \n    AND p.ProposalStatusId = @qpprPaidStatus \nGROUP BY \n    ps.label";
sql = advSql;
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_5c41e853b96e612f21c832865afaaa1f outParamList = new RL_5c41e853b96e612f21c832865afaaa1f();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query a_Main.DashboardTreasury.GetPaidProposals.GetPaidProposalsQuery.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_5c41e853b96e612f21c832865afaaa1f _tmp = new RL_5c41e853b96e612f21c832865afaaa1f();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query a_Main.DashboardTreasury.GetPaidProposals.GetPaidProposalsQuery.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_5c41e853b96e612f21c832865afaaa1f)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetPaidProposalsQuery in GetPaidProposals in DashboardTreasury in a_Main in ConectaProveedores (SELECT      ps.label,      COUNT(*) AS proposal_count  FROM {Proposal} p  JOIN {ProposalStatus} ps      ON ps.Id = p.ProposalStatusId      AND p.CreatedOn BETWEEN @MinDate and @MaxDate      AND p.ProposalStatusId = @PaidStatus  GROUP BY      ps.label): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetPaidProposalsQuery in GetPaidProposals in DashboardTreasury in a_Main in ConectaProveedores (SELECT      ps.label,      COUNT(*) AS proposal_count  FROM {Proposal} p  JOIN {ProposalStatus} ps      ON ps.Id = p.ProposalStatusId      AND p.CreatedOn BETWEEN @MinDate and @MaxDate      AND p.ProposalStatusId = @PaidStatus  GROUP BY      ps.label): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetPaidProposalsQuery in GetPaidProposals in DashboardTreasury in a_Main in ConectaProveedores (SELECT      ps.label,      COUNT(*) AS proposal_count  FROM {Proposal} p  JOIN {ProposalStatus} ps      ON ps.Id = p.ProposalStatusId      AND p.CreatedOn BETWEEN @MinDate and @MaxDate      AND p.ProposalStatusId = @PaidStatus  GROUP BY      ps.label): " + aqExcep.Message));
}
}
}
}
public static class FuncDataActionGetActiveProposals {

// Query Function "GetActiveProposalsQuery" w5TWRWcTL0WYroh_Of4Cgw of Action "GetActiveProposals"
public static async Task<(RL_5c41e853b96e612f21c832865afaaa1f,long)> QueryGetActiveProposalsQuery(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,int qpprApprovedStatus,int qpprBeingPaid,int qpprPartiallyPaid,string qpusUserId,DateTime qpdaCurrDate,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("a_Main.DashboardTreasury.GetActiveProposals.GetActiveProposalsQuery", "45d694c3-1367-452f-98ae-887f39fe0283");
using var queryActivity = activitySource.CreateSqlQueryActivity("a_Main.DashboardTreasury.GetActiveProposals.GetActiveProposalsQuery", "45d694c3-1367-452f-98ae-887f39fe0283", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string entityProposal = AppUtils.Instance.RuntimeEntityReplace("Proposal");
string entityProposalStatus = AppUtils.Instance.RuntimeEntityReplace("ProposalStatus");
sqlCmd.CreateParameter("@qpprApprovedStatus", DbType.Int32, qpprApprovedStatus);
sqlCmd.CreateParameter("@qpusUserId", DbType.String, qpusUserId);
sqlCmd.CreateParameter("@qpprBeingPaid", DbType.Int32, qpprBeingPaid);
sqlCmd.CreateParameter("@qpprPartiallyPaid", DbType.Int32, qpprPartiallyPaid);
sqlCmd.CreateParameter("@qpdaCurrDate", DbType.DateTime, qpdaCurrDate);
string sql = "";
string advSql = "SELECT \n    ps.label, \n    COUNT(*) AS proposal_count \nFROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,"") + " p \nJOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalStatus,"") + " ps \n    ON ps.Id = p.ProposalStatusId \n    AND p.ProposalStatusId = @qpprApprovedStatus \n    AND (p.AssignedToId IS NULL OR p.AssignedToId = @qpusUserId) \nGROUP BY \n    ps.label \n \nUNION ALL \n \nSELECT \n    ps.label, \n    COUNT(*) AS proposal_count \nFROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,"") + " p \nJOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalStatus,"") + " ps \n    ON ps.Id = p.ProposalStatusId \n    AND p.ProposalStatusId = @qpprBeingPaid \n    AND (p.AssignedToId IS NULL OR p.AssignedToId = @qpusUserId) \nGROUP BY \n    ps.label \n \nUNION ALL \n \nSELECT \n    ps.label, \n    COUNT(*) AS proposal_count \nFROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,"") + " p \nJOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalStatus,"") + " ps \n    ON ps.Id = p.ProposalStatusId \n    AND p.ProposalStatusId = @qpprPartiallyPaid \n    AND p.MaxDatePaymentChanges <= @qpdaCurrDate \n    AND (p.AssignedToId IS NULL OR p.AssignedToId = @qpusUserId) \nGROUP BY \n    ps.label";
sql = advSql;
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_5c41e853b96e612f21c832865afaaa1f outParamList = new RL_5c41e853b96e612f21c832865afaaa1f();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query a_Main.DashboardTreasury.GetActiveProposals.GetActiveProposalsQuery.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_5c41e853b96e612f21c832865afaaa1f _tmp = new RL_5c41e853b96e612f21c832865afaaa1f();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query a_Main.DashboardTreasury.GetActiveProposals.GetActiveProposalsQuery.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_5c41e853b96e612f21c832865afaaa1f)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetActiveProposalsQuery in GetActiveProposals in DashboardTreasury in a_Main in ConectaProveedores (SELECT      ps.label,      COUNT(*) AS proposal_count  FROM {Proposal} p  JOIN {ProposalStatus} ps      ON ps.Id = p.ProposalStatusId      AND p.ProposalStatusId = @ApprovedStatus      AND (p.AssignedToId IS NULL OR p.AssignedToId = @UserId)  GROUP BY      ps.label    UNION ALL    SELECT      ps.label,      COUNT(*) AS proposal_count  FROM {Proposal} p  JOIN {ProposalStatus} ps      ON ps.Id = p.ProposalStatusId      AND p.ProposalStatusId = @BeingPaid      AND (p.AssignedToId IS NULL OR p.AssignedToId = @UserId)  GROUP BY      ps.label    UNION ALL    SELECT      ps.label,      COUNT(*) AS proposal_count  FROM {Proposal} p  JOIN {ProposalStatus} ps      ON ps.Id = p.ProposalStatusId      AND p.ProposalStatusId = @PartiallyPaid      AND p.MaxDatePaymentChanges <= @CurrDate      AND (p.AssignedToId IS NULL OR p.AssignedToId = @UserId)  GROUP BY      ps.label): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetActiveProposalsQuery in GetActiveProposals in DashboardTreasury in a_Main in ConectaProveedores (SELECT      ps.label,      COUNT(*) AS proposal_count  FROM {Proposal} p  JOIN {ProposalStatus} ps      ON ps.Id = p.ProposalStatusId      AND p.ProposalStatusId = @ApprovedStatus      AND (p.AssignedToId IS NULL OR p.AssignedToId = @UserId)  GROUP BY      ps.label    UNION ALL    SELECT      ps.label,      COUNT(*) AS proposal_count  FROM {Proposal} p  JOIN {ProposalStatus} ps      ON ps.Id = p.ProposalStatusId      AND p.ProposalStatusId = @BeingPaid      AND (p.AssignedToId IS NULL OR p.AssignedToId = @UserId)  GROUP BY      ps.label    UNION ALL    SELECT      ps.label,      COUNT(*) AS proposal_count  FROM {Proposal} p  JOIN {ProposalStatus} ps      ON ps.Id = p.ProposalStatusId      AND p.ProposalStatusId = @PartiallyPaid      AND p.MaxDatePaymentChanges <= @CurrDate      AND (p.AssignedToId IS NULL OR p.AssignedToId = @UserId)  GROUP BY      ps.label): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetActiveProposalsQuery in GetActiveProposals in DashboardTreasury in a_Main in ConectaProveedores (SELECT      ps.label,      COUNT(*) AS proposal_count  FROM {Proposal} p  JOIN {ProposalStatus} ps      ON ps.Id = p.ProposalStatusId      AND p.ProposalStatusId = @ApprovedStatus      AND (p.AssignedToId IS NULL OR p.AssignedToId = @UserId)  GROUP BY      ps.label    UNION ALL    SELECT      ps.label,      COUNT(*) AS proposal_count  FROM {Proposal} p  JOIN {ProposalStatus} ps      ON ps.Id = p.ProposalStatusId      AND p.ProposalStatusId = @BeingPaid      AND (p.AssignedToId IS NULL OR p.AssignedToId = @UserId)  GROUP BY      ps.label    UNION ALL    SELECT      ps.label,      COUNT(*) AS proposal_count  FROM {Proposal} p  JOIN {ProposalStatus} ps      ON ps.Id = p.ProposalStatusId      AND p.ProposalStatusId = @PartiallyPaid      AND p.MaxDatePaymentChanges <= @CurrDate      AND (p.AssignedToId IS NULL OR p.AssignedToId = @UserId)  GROUP BY      ps.label): " + aqExcep.Message));
}
}
}
}


}
