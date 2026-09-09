using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_a_Main_DashboardAdmin_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_a_Main_DashboardAdmin_ScreenModel).Namespace);

    public AggregateRecord<RL_f4591be205d3928a9fe22daf19d979cd> ScreenDataSetGetLast10Proposals;
public ConectaProveedores_a_Main_DashboardAdmin_DataActionGetErrorAPIProposals_Model varLcGetErrorAPIProposals;
public ConectaProveedores_a_Main_DashboardAdmin_DataActionGetActiveProposals_Model varLcGetActiveProposals;
public ConectaProveedores_a_Main_DashboardAdmin_DataActionGetProcessedProposals_Model varLcGetProcessedProposals;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_a_Main_DashboardAdmin_ScreenModel() {
}



    public ConectaProveedores_a_Main_DashboardAdmin_ScreenModel(AggregateRecord<RL_f4591be205d3928a9fe22daf19d979cd> ScreenDataSetGetLast10Proposals, ConectaProveedores_a_Main_DashboardAdmin_DataActionGetErrorAPIProposals_Model varLcGetErrorAPIProposals, ConectaProveedores_a_Main_DashboardAdmin_DataActionGetActiveProposals_Model varLcGetActiveProposals, ConectaProveedores_a_Main_DashboardAdmin_DataActionGetProcessedProposals_Model varLcGetProcessedProposals, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"GetLast10Proposals", "GetErrorAPIProposals", "GetActiveProposals", "GetProcessedProposals", "ClientVars"}, new string[] {"ScreenDataSetGetLast10Proposals", "varLcGetErrorAPIProposals", "varLcGetActiveProposals", "varLcGetProcessedProposals", "clientVariables"});
this.ScreenDataSetGetLast10Proposals = ScreenDataSetGetLast10Proposals;
this.varLcGetErrorAPIProposals = varLcGetErrorAPIProposals;
this.varLcGetActiveProposals = varLcGetActiveProposals;
this.varLcGetProcessedProposals = varLcGetProcessedProposals;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_931c5818c70fb94c867f1591b8f8bd0d> datasetGetLast10ProposalsReadDbAsync(RC_931c5818c70fb94c867f1591b8f8bd0d rec, DbDataReader r, CancellationToken cancellationToken) {
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
// Query Function "GetLast10Proposals" vgcKVJroX0GKvgwAAmkwfg of Action "DashboardAdmin"
public static async Task<(RL_f4591be205d3928a9fe22daf19d979cd,long)> datasetGetLast10Proposals(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("a_Main.DashboardAdmin.GetLast10Proposals", "540a07be-e89a-415f-8abe-0c000269307e");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("DashboardAdmin","a_Main.DashboardAdmin.GetLast10Proposals");
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
selectBuilder.Append("/* /NRWebFlows.DXvJuqeTzUGsVyrZCiDRvQ/NodesShownInESpaceTree.5LKAVOldH02vl_t9XtrH3Q/ScreenDataSets.vgcKVJroX0GKvgwAAmkwfg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enbank9\".\"name\" o1, NULL o2, NULL o3, NULL o4, NULL o5, \"encurrency34\".\"code\" o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, \"enfileextended7\".\"filename\" o12, \"enfileextended7\".\"isprocessed\" o13, \"enfileextended7\".\"haserror\" o14, NULL o15, NULL o16, NULL o17, \"enproposal22\".\"id\" o18, \"enproposal22\".\"name\" o19, \"enproposal22\".\"paymentdate\" o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, trim_scale(\"enproposal22\".\"totalvalueml\"::numeric) o27, NULL o28, NULL o29, NULL o30, NULL o31, \"enproposal22\".\"createdon\" o32, NULL o33, NULL o34, NULL o35, NULL o36, \"enproposalstatus8\".\"label\" o37, \"enproposalstatus8\".\"class\" o38, NULL o39, NULL o40, NULL o41, \"enproposaltype7\".\"label\" o42, NULL o43, NULL o44, NULL o45, NULL o46, \"enregion165\".\"name\" o47, NULL o48, NULL o49, \"enregion165\".\"commissionregion\" o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57");
fromBuilder.Append(" FROM (((((({Proposal} \"enproposal22\" Left JOIN {ProposalType} \"enproposaltype7\" ON (\"enproposal22\".\"proposaltypeid\" = \"enproposaltype7\".\"id\"))  Left JOIN {Bank} \"enbank9\" ON (\"enproposal22\".\"bankid\" = \"enbank9\".\"id\"))  Left JOIN {Region} \"enregion165\" ON (\"enproposal22\".\"regionid\" = \"enregion165\".\"id\"))  Left JOIN {Currency} \"encurrency34\" ON (\"enproposal22\".\"currencyid\" = \"encurrency34\".\"code\"))  Left JOIN {ProposalStatus} \"enproposalstatus8\" ON (\"enproposal22\".\"proposalstatusid\" = \"enproposalstatus8\".\"id\"))  Right JOIN {FileExtended} \"enfileextended7\" ON (\"enfileextended7\".\"id\" = \"enproposal22\".\"fileid\")) ");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND (((extract(month from \"enproposal22\".\"createdon\"::timestamptz)) = (extract(month from (to_date(@qepCurrdate, 'YYYY-MM-DD'))::timestamptz))) AND ((extract(year from \"enproposal22\".\"createdon\"::timestamptz)) = (extract(year from (to_date(@qepCurrdate, 'YYYY-MM-DD'))::timestamptz)))) AND (\"enfileextended7\".\"isprocessed\" = 1)");
orderByBuilder.Append(" ORDER BY \"enproposal22\".\"id\" DESC ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
sqlCmd.CreateParameterWithoutReplacements("@qepCurrdate", DbType.String, System.DateTime.UtcNow.ToString("yyyy-MM-dd"));
sqlCmd.CreateParameterWithoutReplacements("@qepCurrdate", DbType.String, System.DateTime.UtcNow.ToString("yyyy-MM-dd"));
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
outParamList.AlternateReadDbMethodAsync = datasetGetLast10ProposalsReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[7];
opt[0] = new BitArray(new bool[] {false, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true, true});
opt[2] = new BitArray(new bool[] {false, false, false, true, true, true, true, true, true, false, true, true, true, true, false, true, true, true});
opt[3] = new BitArray(new bool[] {true, false, false, false, true, true, true});
opt[4] = new BitArray(new bool[] {true, false, true, true});
opt[5] = new BitArray(new bool[] {true, false, false, true, true});
opt[6] = new BitArray(new bool[] {true, true, false, true, true, false, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query a_Main.DashboardAdmin.GetLast10Proposals.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_f4591be205d3928a9fe22daf19d979cd _tmp = new RL_f4591be205d3928a9fe22daf19d979cd();
_tmp.AlternateReadDbMethodAsync = datasetGetLast10ProposalsReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query a_Main.DashboardAdmin.GetLast10Proposals.List", cancellationToken: cancellationToken);
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


    public class lcvGetErrorAPIProposals : VarsBag {
public RL_5c41e853b96e612f21c832865afaaa1f queryResGetErrorAPIProposalsQuery_outParamList = new RL_5c41e853b96e612f21c832865afaaa1f();
public long queryResGetErrorAPIProposalsQuery_outParamCount = 0L;

public lcvGetErrorAPIProposals() {
}
}
public class lcoGetErrorAPIProposals : VarsBag {
public RL_496abaeba4975b81a1a9b391230e8099 outParamErrorAPIProposals = new RL_496abaeba4975b81a1a9b391230e8099();

public lcoGetErrorAPIProposals() {
}
}
/// <summary>
/// Action <code>GetErrorAPIProposals</code> that represents the Service Studio action
///  <code>GetErrorAPIProposals</code> <p> Description: </p>
/// </summary>
public async Task<RL_496abaeba4975b81a1a9b391230e8099> DataActionGetErrorAPIProposals(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_496abaeba4975b81a1a9b391230e8099 outParamErrorAPIProposals = default;
lcoGetErrorAPIProposals result = new lcoGetErrorAPIProposals();
lcvGetErrorAPIProposals localVars = new lcvGetErrorAPIProposals();
ConectaProveedores_a_Main_DashboardAdmin_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetErrorAPIProposals", "150678a0-727a-4ff8-89e2-f7c53670a820"))
using (activitySource.CreateScreenDataActionActivity("DashboardAdmin", "GetErrorAPIProposals")){
// Query QueryGetErrorAPIProposalsQuery
cancellationToken.ThrowIfCancellationRequested();
int QueryGetErrorAPIProposalsQuery_maxRecords = 0;
int QueryGetErrorAPIProposalsQuery_startIndex = 0;(localVars.queryResGetErrorAPIProposalsQuery_outParamList,localVars.queryResGetErrorAPIProposalsQuery_outParamCount) = await FuncDataActionGetErrorAPIProposals.QueryGetErrorAPIProposalsQuery(requestContext,QueryGetErrorAPIProposalsQuery_maxRecords,QueryGetErrorAPIProposalsQuery_startIndex,IterationMultiplicity.Never,BuiltInFunction.NewDate (BuiltInFunction.Year (BuiltInFunction.CurrDate ()), BuiltInFunction.Month (BuiltInFunction.CurrDate ()), 1),BuiltInFunction.DateTimeToDate(BuiltInFunction.AddDays (BuiltInFunction.AddMonths (BuiltInFunction.NewDate (BuiltInFunction.Year (BuiltInFunction.CurrDate ()), BuiltInFunction.Month (BuiltInFunction.CurrDate ()), 1), 1), (-1))),(ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("OSpEADv8F0q4Sge4sU9mWA"))).ssId,cancellationToken);

// ErrorAPIProposals = GetErrorAPIProposalsQuery.List
result.outParamErrorAPIProposals=(await RL_496abaeba4975b81a1a9b391230e8099.ConvertAsync(localVars.queryResGetErrorAPIProposalsQuery_outParamList, new RL_496abaeba4975b81a1a9b391230e8099(), async (RC_6dc2ea62d515aadb2abe8127d022eca8 source, ST_bfed96b4bd29e9b06f0b06e901b1508bStructure target, CancellationToken cancellationToken) => {
target = source;
return target;
}, cancellationToken));
} //close CreateActionActivity using block
} // try

finally {
outParamErrorAPIProposals = result.outParamErrorAPIProposals;
} // inner-finally
RETURN_STATEMENT:
return outParamErrorAPIProposals;
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
///  <code>GetActiveProposals</code> <p> Description: </p>
/// </summary>
public async Task<(RL_496abaeba4975b81a1a9b391230e8099,int)> DataActionGetActiveProposals(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_496abaeba4975b81a1a9b391230e8099 outParamActiveProposals = default;
int outParamo_TotalCount = default;
lcoGetActiveProposals result = new lcoGetActiveProposals();
lcvGetActiveProposals localVars = new lcvGetActiveProposals();
ConectaProveedores_a_Main_DashboardAdmin_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetActiveProposals", "2baaa74f-d6aa-4d3d-aaf6-3d0e41db542a"))
using (activitySource.CreateScreenDataActionActivity("DashboardAdmin", "GetActiveProposals")){
// Query QueryGetActiveProposalsQuery
cancellationToken.ThrowIfCancellationRequested();
int QueryGetActiveProposalsQuery_maxRecords = 0;
int QueryGetActiveProposalsQuery_startIndex = 0;(localVars.queryResGetActiveProposalsQuery_outParamList,localVars.queryResGetActiveProposalsQuery_outParamCount) = await FuncDataActionGetActiveProposals.QueryGetActiveProposalsQuery(requestContext,QueryGetActiveProposalsQuery_maxRecords,QueryGetActiveProposalsQuery_startIndex,IterationMultiplicity.Multiple,BuiltInFunction.NewDate (BuiltInFunction.Year (BuiltInFunction.CurrDate ()), BuiltInFunction.Month (BuiltInFunction.CurrDate ()), 1),BuiltInFunction.DateTimeToDate(BuiltInFunction.AddDays (BuiltInFunction.AddMonths (BuiltInFunction.NewDate (BuiltInFunction.Year (BuiltInFunction.CurrDate ()), BuiltInFunction.Month (BuiltInFunction.CurrDate ()), 1), 1), (-1))),(ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("t1jXoCYmMkuMIabV4nC9iA"))).ssId,(ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("uL8+MGLLsUGnVkTyfH8gIw"))).ssId,(ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("OSpEADv8F0q4Sge4sU9mWA"))).ssId,(ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("Abvh784e3UuM2GyF6VWeNw"))).ssId,cancellationToken);

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
public class lcvGetProcessedProposals : VarsBag {
public RL_5c41e853b96e612f21c832865afaaa1f queryResGetProcessedProposalsQuery_outParamList = new RL_5c41e853b96e612f21c832865afaaa1f();
public long queryResGetProcessedProposalsQuery_outParamCount = 0L;

public lcvGetProcessedProposals() {
}
}
public class lcoGetProcessedProposals : VarsBag {
public RL_496abaeba4975b81a1a9b391230e8099 outParamProcessedProposals = new RL_496abaeba4975b81a1a9b391230e8099();

public int outParamo_TotalCount = 0;

public lcoGetProcessedProposals() {
}
}
/// <summary>
/// Action <code>GetProcessedProposals</code> that represents the Service Studio action
///  <code>GetProcessedProposals</code> <p> Description: </p>
/// </summary>
public async Task<(RL_496abaeba4975b81a1a9b391230e8099,int)> DataActionGetProcessedProposals(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_496abaeba4975b81a1a9b391230e8099 outParamProcessedProposals = default;
int outParamo_TotalCount = default;
lcoGetProcessedProposals result = new lcoGetProcessedProposals();
lcvGetProcessedProposals localVars = new lcvGetProcessedProposals();
ConectaProveedores_a_Main_DashboardAdmin_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetProcessedProposals", "61161a4a-c4fc-42f5-a4f2-6b6fb4b9a3f4"))
using (activitySource.CreateScreenDataActionActivity("DashboardAdmin", "GetProcessedProposals")){
// Query QueryGetProcessedProposalsQuery
cancellationToken.ThrowIfCancellationRequested();
int QueryGetProcessedProposalsQuery_maxRecords = 0;
int QueryGetProcessedProposalsQuery_startIndex = 0;(localVars.queryResGetProcessedProposalsQuery_outParamList,localVars.queryResGetProcessedProposalsQuery_outParamCount) = await FuncDataActionGetProcessedProposals.QueryGetProcessedProposalsQuery(requestContext,QueryGetProcessedProposalsQuery_maxRecords,QueryGetProcessedProposalsQuery_startIndex,IterationMultiplicity.Multiple,BuiltInFunction.NewDate (BuiltInFunction.Year (BuiltInFunction.CurrDate ()), BuiltInFunction.Month (BuiltInFunction.CurrDate ()), 1),BuiltInFunction.DateTimeToDate(BuiltInFunction.AddDays (BuiltInFunction.AddMonths (BuiltInFunction.NewDate (BuiltInFunction.Year (BuiltInFunction.CurrDate ()), BuiltInFunction.Month (BuiltInFunction.CurrDate ()), 1), 1), (-1))),(ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("t1jXoCYmMkuMIabV4nC9iA"))).ssId,(ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("uL8+MGLLsUGnVkTyfH8gIw"))).ssId,(ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("Abvh784e3UuM2GyF6VWeNw"))).ssId,cancellationToken);

// ProcessedProposals = GetProcessedProposalsQuery.List
result.outParamProcessedProposals=(await RL_496abaeba4975b81a1a9b391230e8099.ConvertAsync(localVars.queryResGetProcessedProposalsQuery_outParamList, new RL_496abaeba4975b81a1a9b391230e8099(), async (RC_6dc2ea62d515aadb2abe8127d022eca8 source, ST_bfed96b4bd29e9b06f0b06e901b1508bStructure target, CancellationToken cancellationToken) => {
target = source;
return target;
}, cancellationToken));
// Foreach GetProcessedProposalsQuery.List
localVars.queryResGetProcessedProposalsQuery_outParamList.StartIteration();
try {while (!((localVars.queryResGetProcessedProposalsQuery_outParamList.Eof))) {
// o_TotalCount = o_TotalCount + GetProcessedProposalsQuery.List.Current.Counter.Count
result.outParamo_TotalCount=(result.outParamo_TotalCount+localVars.queryResGetProcessedProposalsQuery_outParamList.CurrentRec.ssSTCounter.ssCount);
localVars.queryResGetProcessedProposalsQuery_outParamList.Advance();
}

} finally {
localVars.queryResGetProcessedProposalsQuery_outParamList.EndIteration();
}

} //close CreateActionActivity using block
} // try

finally {
outParamProcessedProposals = result.outParamProcessedProposals;
outParamo_TotalCount = result.outParamo_TotalCount;
} // inner-finally
RETURN_STATEMENT:
return (outParamProcessedProposals,outParamo_TotalCount);
}


    public static class FuncDataActionGetErrorAPIProposals {

// Query Function "GetErrorAPIProposalsQuery" vwNDaArD8UiEiaWMe0+RIw of Action "GetErrorAPIProposals"
public static async Task<(RL_5c41e853b96e612f21c832865afaaa1f,long)> QueryGetErrorAPIProposalsQuery(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,DateTime qpdaMinDate,DateTime qpdaMaxDate,int qpprErrorAPIStatus,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("a_Main.DashboardAdmin.GetErrorAPIProposals.GetErrorAPIProposalsQuery", "684303bf-c30a-48f1-8489-a58c7b4f9123");
using var queryActivity = activitySource.CreateSqlQueryActivity("a_Main.DashboardAdmin.GetErrorAPIProposals.GetErrorAPIProposalsQuery", "684303bf-c30a-48f1-8489-a58c7b4f9123", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
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
sqlCmd.CreateParameter("@qpprErrorAPIStatus", DbType.Int32, qpprErrorAPIStatus);
string sql = "";
string advSql = "SELECT \n    ps.label, \n    COUNT(*) AS proposal_count \nFROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,"") + " p \nJOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalStatus,"") + " ps \n    ON ps.Id = p.ProposalStatusId \n    AND p.CreatedOn BETWEEN @qpdaMinDate and @qpdaMaxDate \n    AND p.ProposalStatusId = @qpprErrorAPIStatus \nGROUP BY \n    ps.label";
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query a_Main.DashboardAdmin.GetErrorAPIProposals.GetErrorAPIProposalsQuery.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query a_Main.DashboardAdmin.GetErrorAPIProposals.GetErrorAPIProposalsQuery.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_5c41e853b96e612f21c832865afaaa1f)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetErrorAPIProposalsQuery in GetErrorAPIProposals in DashboardAdmin in a_Main in ConectaProveedores (SELECT      ps.label,      COUNT(*) AS proposal_count  FROM {Proposal} p  JOIN {ProposalStatus} ps      ON ps.Id = p.ProposalStatusId      AND p.CreatedOn BETWEEN @MinDate and @MaxDate      AND p.ProposalStatusId = @ErrorAPIStatus  GROUP BY      ps.label): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetErrorAPIProposalsQuery in GetErrorAPIProposals in DashboardAdmin in a_Main in ConectaProveedores (SELECT      ps.label,      COUNT(*) AS proposal_count  FROM {Proposal} p  JOIN {ProposalStatus} ps      ON ps.Id = p.ProposalStatusId      AND p.CreatedOn BETWEEN @MinDate and @MaxDate      AND p.ProposalStatusId = @ErrorAPIStatus  GROUP BY      ps.label): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetErrorAPIProposalsQuery in GetErrorAPIProposals in DashboardAdmin in a_Main in ConectaProveedores (SELECT      ps.label,      COUNT(*) AS proposal_count  FROM {Proposal} p  JOIN {ProposalStatus} ps      ON ps.Id = p.ProposalStatusId      AND p.CreatedOn BETWEEN @MinDate and @MaxDate      AND p.ProposalStatusId = @ErrorAPIStatus  GROUP BY      ps.label): " + aqExcep.Message));
}
}
}
}
public static class FuncDataActionGetActiveProposals {

// Query Function "GetActiveProposalsQuery" _wDPvKNX+UGDN_D2TJ+EPg of Action "GetActiveProposals"
public static async Task<(RL_5c41e853b96e612f21c832865afaaa1f,long)> QueryGetActiveProposalsQuery(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,DateTime qpdaMinDate,DateTime qpdaMaxDate,int qpprPaidStatus,int qpprCanceledStatus,int qpprErrorAPIStatus,int qpprPartiallyPaidStatus,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("a_Main.DashboardAdmin.GetActiveProposals.GetActiveProposalsQuery", "bccf00ff-57a3-41f9-8337-f0f64c9f843e");
using var queryActivity = activitySource.CreateSqlQueryActivity("a_Main.DashboardAdmin.GetActiveProposals.GetActiveProposalsQuery", "bccf00ff-57a3-41f9-8337-f0f64c9f843e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Multiple
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
sqlCmd.CreateParameter("@qpprCanceledStatus", DbType.Int32, qpprCanceledStatus);
sqlCmd.CreateParameter("@qpprErrorAPIStatus", DbType.Int32, qpprErrorAPIStatus);
sqlCmd.CreateParameter("@qpprPartiallyPaidStatus", DbType.Int32, qpprPartiallyPaidStatus);
string sql = "";
string advSql = "SELECT \n    ps.label, \n    COUNT(*) AS proposal_count \nFROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,"") + " p \nJOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalStatus,"") + " ps \n    ON ps.Id = p.ProposalStatusId \n    AND p.CreatedOn BETWEEN @qpdaMinDate and @qpdaMaxDate \n    AND p.ProposalStatusId <> @qpprPaidStatus \n    AND p.ProposalStatusId <> @qpprCanceledStatus \n    AND p.ProposalStatusId <> @qpprErrorAPIStatus \n    AND p.ProposalStatusId <> @qpprPartiallyPaidStatus \nGROUP BY \n    ps.label";
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query a_Main.DashboardAdmin.GetActiveProposals.GetActiveProposalsQuery.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query a_Main.DashboardAdmin.GetActiveProposals.GetActiveProposalsQuery.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_5c41e853b96e612f21c832865afaaa1f)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetActiveProposalsQuery in GetActiveProposals in DashboardAdmin in a_Main in ConectaProveedores (SELECT      ps.label,      COUNT(*) AS proposal_count  FROM {Proposal} p  JOIN {ProposalStatus} ps      ON ps.Id = p.ProposalStatusId      AND p.CreatedOn BETWEEN @MinDate and @MaxDate      AND p.ProposalStatusId <> @PaidStatus      AND p.ProposalStatusId <> @CanceledStatus      AND p.ProposalStatusId <> @ErrorAPIStatus      AND p.ProposalStatusId <> @PartiallyPaidStatus  GROUP BY      ps.label): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetActiveProposalsQuery in GetActiveProposals in DashboardAdmin in a_Main in ConectaProveedores (SELECT      ps.label,      COUNT(*) AS proposal_count  FROM {Proposal} p  JOIN {ProposalStatus} ps      ON ps.Id = p.ProposalStatusId      AND p.CreatedOn BETWEEN @MinDate and @MaxDate      AND p.ProposalStatusId <> @PaidStatus      AND p.ProposalStatusId <> @CanceledStatus      AND p.ProposalStatusId <> @ErrorAPIStatus      AND p.ProposalStatusId <> @PartiallyPaidStatus  GROUP BY      ps.label): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetActiveProposalsQuery in GetActiveProposals in DashboardAdmin in a_Main in ConectaProveedores (SELECT      ps.label,      COUNT(*) AS proposal_count  FROM {Proposal} p  JOIN {ProposalStatus} ps      ON ps.Id = p.ProposalStatusId      AND p.CreatedOn BETWEEN @MinDate and @MaxDate      AND p.ProposalStatusId <> @PaidStatus      AND p.ProposalStatusId <> @CanceledStatus      AND p.ProposalStatusId <> @ErrorAPIStatus      AND p.ProposalStatusId <> @PartiallyPaidStatus  GROUP BY      ps.label): " + aqExcep.Message));
}
}
}
}
public static class FuncDataActionGetProcessedProposals {

// Query Function "GetProcessedProposalsQuery" mQLWldOY4kC8pi2FqDFRig of Action "GetProcessedProposals"
public static async Task<(RL_5c41e853b96e612f21c832865afaaa1f,long)> QueryGetProcessedProposalsQuery(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,DateTime qpdaMinDate,DateTime qpdaMaxDate,int qpprPaidStatus,int qpprCanceledStatus,int qpprPartiallyPaidStatus,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("a_Main.DashboardAdmin.GetProcessedProposals.GetProcessedProposalsQuery", "95d60299-98d3-40e2-bca6-2d85a831518a");
using var queryActivity = activitySource.CreateSqlQueryActivity("a_Main.DashboardAdmin.GetProcessedProposals.GetProcessedProposalsQuery", "95d60299-98d3-40e2-bca6-2d85a831518a", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Multiple
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
sqlCmd.CreateParameter("@qpprPartiallyPaidStatus", DbType.Int32, qpprPartiallyPaidStatus);
sqlCmd.CreateParameter("@qpprCanceledStatus", DbType.Int32, qpprCanceledStatus);
string sql = "";
string advSql = "SELECT \n    ps.label, \n    COUNT(*) AS proposal_count \nFROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,"") + " p \nJOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalStatus,"") + " ps \n    ON ps.Id = p.ProposalStatusId \n    AND p.CreatedOn BETWEEN @qpdaMinDate and @qpdaMaxDate \n    AND (p.ProposalStatusId = @qpprPaidStatus OR p.ProposalStatusId = @qpprPartiallyPaidStatus OR p.ProposalStatusId = @qpprCanceledStatus) \nGROUP BY \n    ps.label";
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query a_Main.DashboardAdmin.GetProcessedProposals.GetProcessedProposalsQuery.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query a_Main.DashboardAdmin.GetProcessedProposals.GetProcessedProposalsQuery.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_5c41e853b96e612f21c832865afaaa1f)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetProcessedProposalsQuery in GetProcessedProposals in DashboardAdmin in a_Main in ConectaProveedores (SELECT      ps.label,      COUNT(*) AS proposal_count  FROM {Proposal} p  JOIN {ProposalStatus} ps      ON ps.Id = p.ProposalStatusId      AND p.CreatedOn BETWEEN @MinDate and @MaxDate      AND (p.ProposalStatusId = @PaidStatus OR p.ProposalStatusId = @PartiallyPaidStatus OR p.ProposalStatusId = @CanceledStatus)  GROUP BY      ps.label): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetProcessedProposalsQuery in GetProcessedProposals in DashboardAdmin in a_Main in ConectaProveedores (SELECT      ps.label,      COUNT(*) AS proposal_count  FROM {Proposal} p  JOIN {ProposalStatus} ps      ON ps.Id = p.ProposalStatusId      AND p.CreatedOn BETWEEN @MinDate and @MaxDate      AND (p.ProposalStatusId = @PaidStatus OR p.ProposalStatusId = @PartiallyPaidStatus OR p.ProposalStatusId = @CanceledStatus)  GROUP BY      ps.label): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetProcessedProposalsQuery in GetProcessedProposals in DashboardAdmin in a_Main in ConectaProveedores (SELECT      ps.label,      COUNT(*) AS proposal_count  FROM {Proposal} p  JOIN {ProposalStatus} ps      ON ps.Id = p.ProposalStatusId      AND p.CreatedOn BETWEEN @MinDate and @MaxDate      AND (p.ProposalStatusId = @PaidStatus OR p.ProposalStatusId = @PartiallyPaidStatus OR p.ProposalStatusId = @CanceledStatus)  GROUP BY      ps.label): " + aqExcep.Message));
}
}
}
}


}
