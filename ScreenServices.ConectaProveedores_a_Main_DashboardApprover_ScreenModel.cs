using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_a_Main_DashboardApprover_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_a_Main_DashboardApprover_ScreenModel).Namespace);

    public AggregateRecord<RL_90a833a7c67bd4e28d2034b8adc2432b> ScreenDataSetGetProposalLines;
public ConectaProveedores_a_Main_DashboardApprover_DataActionGetApprovedProposalLines_Model varLcGetApprovedProposalLines;
public ConectaProveedores_a_Main_DashboardApprover_DataActionGetNotApprovedProposalLines_Model varLcGetNotApprovedProposalLines;
public ConectaProveedores_a_Main_DashboardApprover_DataActionGetRejectedProposalLines_Model varLcGetRejectedProposalLines;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_a_Main_DashboardApprover_ScreenModel() {
}



    public ConectaProveedores_a_Main_DashboardApprover_ScreenModel(AggregateRecord<RL_90a833a7c67bd4e28d2034b8adc2432b> ScreenDataSetGetProposalLines, ConectaProveedores_a_Main_DashboardApprover_DataActionGetApprovedProposalLines_Model varLcGetApprovedProposalLines, ConectaProveedores_a_Main_DashboardApprover_DataActionGetNotApprovedProposalLines_Model varLcGetNotApprovedProposalLines, ConectaProveedores_a_Main_DashboardApprover_DataActionGetRejectedProposalLines_Model varLcGetRejectedProposalLines, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"GetProposalLines", "GetApprovedProposalLines", "GetNotApprovedProposalLines", "GetRejectedProposalLines", "ClientVars"}, new string[] {"ScreenDataSetGetProposalLines", "varLcGetApprovedProposalLines", "varLcGetNotApprovedProposalLines", "varLcGetRejectedProposalLines", "clientVariables"});
this.ScreenDataSetGetProposalLines = ScreenDataSetGetProposalLines;
this.varLcGetApprovedProposalLines = varLcGetApprovedProposalLines;
this.varLcGetNotApprovedProposalLines = varLcGetNotApprovedProposalLines;
this.varLcGetRejectedProposalLines = varLcGetRejectedProposalLines;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_2a967ca085a7d7066ca851285c363d53> datasetGetProposalLinesReadDbAsync(RC_2a967ca085a7d7066ca851285c363d53 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApplicationRole.Read( r, ref index);
rec.ssENApprovalStatus.Read( r, ref index);
rec.ssENBank.Read( r, ref index);
rec.ssENCompany.Read( r, ref index);
rec.ssENProposal.Read( r, ref index);
rec.ssENProposalApproval.Read( r, ref index);
rec.ssENProposalApprovalLevel.Read( r, ref index);
rec.ssENProposalLine.Read( r, ref index);
rec.ssENProposalLineApprovalLevel.Read( r, ref index);
rec.ssENProposalType.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
return rec;
}
// Query Function "GetProposalLines" aiLt71UosUOE1ZHT45IDPg of Action "DashboardApprover"
public static async Task<(RL_90a833a7c67bd4e28d2034b8adc2432b,long)> datasetGetProposalLines(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,long qpapProposalLineApprovalLevel_ApplicationRoleId,long qpreProposal_RegionId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("a_Main.DashboardApprover.GetProposalLines", "efed226a-2855-43b1-84d5-91d3e392033e");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("DashboardApprover","a_Main.DashboardApprover.GetProposalLines");
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
selectBuilder.Append("/* /NRWebFlows.DXvJuqeTzUGsVyrZCiDRvQ/NodesShownInESpaceTree.VOZGcrKPmU+y0rTqOr0ZWw/ScreenDataSets.aiLt71UosUOE1ZHT45IDPg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"enapplicationrole75\".\"name\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, \"enapprovalstatus27\".\"label\" o8, \"enapprovalstatus27\".\"class\" o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, \"enbank10\".\"name\" o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, \"enproposal23\".\"name\" o35, \"enproposal23\".\"paymentdate\" o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, \"enproposalline14\".\"nombre1\" o76, NULL o77, NULL o78, \"enproposalline14\".\"n_doctype\" o79, trim_scale(\"enproposalline14\".\"importeenml\"::numeric) o80, NULL o81, NULL o82, NULL o83, \"enproposalline14\".\"soc_\" o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, NULL o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, \"enregion166\".\"divisionfi\" o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, NULL o118, NULL o119, NULL o120");
fromBuilder.Append(" FROM (((((((((({ProposalLineApprovalLevel} \"enproposallineapprovallevel7\" Left JOIN {ProposalApprovalLevel} \"enproposalapprovallevel10\" ON (\"enproposallineapprovallevel7\".\"proposalapprovallevelid\" = \"enproposalapprovallevel10\".\"id\"))  Left JOIN {ProposalApproval} \"enproposalapproval8\" ON (\"enproposalapprovallevel10\".\"proposalapprovalid\" = \"enproposalapproval8\".\"id\"))  Left JOIN {Proposal} \"enproposal23\" ON (\"enproposalapproval8\".\"proposalid\" = \"enproposal23\".\"id\"))  Left JOIN {ProposalLine} \"enproposalline14\" ON (\"enproposallineapprovallevel7\".\"proposallineid\" = \"enproposalline14\".\"id\"))  Left JOIN {Region} \"enregion166\" ON (\"enproposal23\".\"regionid\" = \"enregion166\".\"id\"))  Left JOIN {Company} \"encompany60\" ON (\"enproposalline14\".\"soc_\" = \"encompany60\".\"externalid\"))  Left JOIN {Bank} \"enbank10\" ON (\"enproposal23\".\"bankid\" = \"enbank10\".\"id\"))  Inner JOIN {ApplicationRole} \"enapplicationrole75\" ON (\"enproposallineapprovallevel7\".\"applicationroleid\" = \"enapplicationrole75\".\"id\"))  Left JOIN {ProposalType} \"enproposaltype8\" ON (\"enproposal23\".\"proposaltypeid\" = \"enproposaltype8\".\"id\"))  Left JOIN {ApprovalStatus} \"enapprovalstatus27\" ON (\"enproposallineapprovallevel7\".\"approvalstatusid\" = \"enapprovalstatus27\".\"id\")) ");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qpreProposal_RegionId != 0) {
whereBuilder.Append("((\"enproposal23\".\"regionid\" = @qpreProposal_RegionId) AND (\"enproposal23\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreProposal_RegionId", DbType.Int64, qpreProposal_RegionId);
} else {
whereBuilder.Append("(\"enproposal23\".\"regionid\" IS NULL)");
}
whereBuilder.Append(" AND ");
if (qpapProposalLineApprovalLevel_ApplicationRoleId != 0) {
whereBuilder.Append("((\"enproposallineapprovallevel7\".\"applicationroleid\" = @qpapProposalLineApprovalLevel_ApplicationRoleId) AND (\"enproposallineapprovallevel7\".\"applicationroleid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpapProposalLineApprovalLevel_ApplicationRoleId", DbType.Int64, qpapProposalLineApprovalLevel_ApplicationRoleId);
} else {
whereBuilder.Append("(\"enproposallineapprovallevel7\".\"applicationroleid\" IS NULL)");
}
whereBuilder.Append(" AND (((\"enproposal23\".\"proposalstatusid\" <> ");
whereBuilder.Append((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("uL8+MGLLsUGnVkTyfH8gIw"))).ssId);
whereBuilder.Append(") AND (\"enproposal23\".\"proposalstatusid\" <> ");
whereBuilder.Append((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("OSpEADv8F0q4Sge4sU9mWA"))).ssId);
whereBuilder.Append(")) AND (\"enproposal23\".\"proposalstatusid\" <> ");
whereBuilder.Append((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("tR_Y9rNyuUWKp4_z6ZegWQ"))).ssId);
whereBuilder.Append(")) AND (\"enproposallineapprovallevel7\".\"approvalstatusid\" = ");
whereBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId);
whereBuilder.Append(")");
orderByBuilder.Append(" ORDER BY \"enproposal23\".\"id\" DESC ");
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
RL_90a833a7c67bd4e28d2034b8adc2432b outParamList = new RL_90a833a7c67bd4e28d2034b8adc2432b();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetProposalLinesReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[11];
opt[0] = new BitArray(new bool[] {true, false, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true});
opt[4] = new BitArray(new bool[] {true, false, false, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true});
opt[6] = new BitArray(new bool[] {true, true, true, true, true, true, true, true});
opt[7] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, false, true, true, false, false, true, true, true, false, true, true, true, true, true, true, true, true, true, true});
opt[8] = new BitArray(new bool[] {true, true, false, true, true, true, true});
opt[9] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true});
opt[10] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query a_Main.DashboardApprover.GetProposalLines.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_90a833a7c67bd4e28d2034b8adc2432b _tmp = new RL_90a833a7c67bd4e28d2034b8adc2432b();
_tmp.AlternateReadDbMethodAsync = datasetGetProposalLinesReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query a_Main.DashboardApprover.GetProposalLines.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_90a833a7c67bd4e28d2034b8adc2432b)_tmp;
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


    public class lcvGetApprovedProposalLines : VarsBag {
public RL_5c41e853b96e612f21c832865afaaa1f queryResGetApprovedProposalLinesQuery_outParamList = new RL_5c41e853b96e612f21c832865afaaa1f();
public long queryResGetApprovedProposalLinesQuery_outParamCount = 0L;

public lcvGetApprovedProposalLines() {
}
}
public class lcoGetApprovedProposalLines : VarsBag {
public RL_496abaeba4975b81a1a9b391230e8099 outParamApprovedProposalLines = new RL_496abaeba4975b81a1a9b391230e8099();

public int outParamo_TotalCount = 0;

public lcoGetApprovedProposalLines() {
}
}
/// <summary>
/// Action <code>GetApprovedProposalLines</code> that represents the Service Studio action
///  <code>GetApprovedProposalLines</code> <p> Description: Get Approved Proposals Lines Count.</p>
/// </summary>
public async Task<(RL_496abaeba4975b81a1a9b391230e8099,int)> DataActionGetApprovedProposalLines(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_496abaeba4975b81a1a9b391230e8099 outParamApprovedProposalLines = default;
int outParamo_TotalCount = default;
lcoGetApprovedProposalLines result = new lcoGetApprovedProposalLines();
lcvGetApprovedProposalLines localVars = new lcvGetApprovedProposalLines();
ConectaProveedores_a_Main_DashboardApprover_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetApprovedProposalLines", "19ec9d90-4821-4986-aadc-505a69a90eb3"))
using (activitySource.CreateScreenDataActionActivity("DashboardApprover", "GetApprovedProposalLines")){
// Query QueryGetApprovedProposalLinesQuery
cancellationToken.ThrowIfCancellationRequested();
int QueryGetApprovedProposalLinesQuery_maxRecords = 99999;
if (QueryGetApprovedProposalLinesQuery_maxRecords < 1) QueryGetApprovedProposalLinesQuery_maxRecords = 1;
int QueryGetApprovedProposalLinesQuery_startIndex = 0;(localVars.queryResGetApprovedProposalLinesQuery_outParamList,localVars.queryResGetApprovedProposalLinesQuery_outParamCount) = await FuncDataActionGetApprovedProposalLines.QueryGetApprovedProposalLinesQuery(requestContext,QueryGetApprovedProposalLinesQuery_maxRecords,QueryGetApprovedProposalLinesQuery_startIndex,IterationMultiplicity.Single,BuiltInFunction.NewDate (BuiltInFunction.Year (BuiltInFunction.CurrDate ()), BuiltInFunction.Month (BuiltInFunction.CurrDate ()), 1),BuiltInFunction.DateTimeToDate(BuiltInFunction.AddDays (BuiltInFunction.AddMonths (BuiltInFunction.NewDate (BuiltInFunction.Year (BuiltInFunction.CurrDate ()), BuiltInFunction.Month (BuiltInFunction.CurrDate ()), 1), 1), (-1))),(ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("rkrV30n0cEiW8dttOKG0gw"))).ssId,(await Functions.ActionGetUserRegionId(requestContext,"",cancellationToken)),(await Functions.ActionGetUserApplicationRoleCyA(requestContext,cancellationToken)),(ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("uL8+MGLLsUGnVkTyfH8gIw"))).ssId,cancellationToken);

// ApprovedProposalLines = GetApprovedProposalLinesQuery.List
result.outParamApprovedProposalLines=(await RL_496abaeba4975b81a1a9b391230e8099.ConvertAsync(localVars.queryResGetApprovedProposalLinesQuery_outParamList, new RL_496abaeba4975b81a1a9b391230e8099(), async (RC_6dc2ea62d515aadb2abe8127d022eca8 source, ST_bfed96b4bd29e9b06f0b06e901b1508bStructure target, CancellationToken cancellationToken) => {
target = source;
return target;
}, cancellationToken));
// Foreach GetApprovedProposalLinesQuery.List
localVars.queryResGetApprovedProposalLinesQuery_outParamList.StartIteration();
try {while (!((localVars.queryResGetApprovedProposalLinesQuery_outParamList.Eof))) {
// o_TotalCount = o_TotalCount + GetApprovedProposalLinesQuery.List.Current.Counter.Count
result.outParamo_TotalCount=(result.outParamo_TotalCount+localVars.queryResGetApprovedProposalLinesQuery_outParamList.CurrentRec.ssSTCounter.ssCount);
localVars.queryResGetApprovedProposalLinesQuery_outParamList.Advance();
}

} finally {
localVars.queryResGetApprovedProposalLinesQuery_outParamList.EndIteration();
}

} //close CreateActionActivity using block
} // try

finally {
outParamApprovedProposalLines = result.outParamApprovedProposalLines;
outParamo_TotalCount = result.outParamo_TotalCount;
} // inner-finally
RETURN_STATEMENT:
return (outParamApprovedProposalLines,outParamo_TotalCount);
}
public class lcvGetNotApprovedProposalLines : VarsBag {
public RL_5c41e853b96e612f21c832865afaaa1f queryResGetNotApprovedProposalLinesQuery_outParamList = new RL_5c41e853b96e612f21c832865afaaa1f();
public long queryResGetNotApprovedProposalLinesQuery_outParamCount = 0L;

public lcvGetNotApprovedProposalLines() {
}
}
public class lcoGetNotApprovedProposalLines : VarsBag {
public RL_496abaeba4975b81a1a9b391230e8099 outParamNotApprovedProposalLines = new RL_496abaeba4975b81a1a9b391230e8099();

public int outParamo_TotalCount = 0;

public lcoGetNotApprovedProposalLines() {
}
}
/// <summary>
/// Action <code>GetNotApprovedProposalLines</code> that represents the Service Studio action
///  <code>GetNotApprovedProposalLines</code> <p> Description: Get Not Approved Proposal Line
/// s count.</p>
/// </summary>
public async Task<(RL_496abaeba4975b81a1a9b391230e8099,int)> DataActionGetNotApprovedProposalLines(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_496abaeba4975b81a1a9b391230e8099 outParamNotApprovedProposalLines = default;
int outParamo_TotalCount = default;
lcoGetNotApprovedProposalLines result = new lcoGetNotApprovedProposalLines();
lcvGetNotApprovedProposalLines localVars = new lcvGetNotApprovedProposalLines();
ConectaProveedores_a_Main_DashboardApprover_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetNotApprovedProposalLines", "26de17e7-764a-49c9-bfce-ebb359918a2f"))
using (activitySource.CreateScreenDataActionActivity("DashboardApprover", "GetNotApprovedProposalLines")){
// Query QueryGetNotApprovedProposalLinesQuery
cancellationToken.ThrowIfCancellationRequested();
int QueryGetNotApprovedProposalLinesQuery_maxRecords = 0;
int QueryGetNotApprovedProposalLinesQuery_startIndex = 0;(localVars.queryResGetNotApprovedProposalLinesQuery_outParamList,localVars.queryResGetNotApprovedProposalLinesQuery_outParamCount) = await FuncDataActionGetNotApprovedProposalLines.QueryGetNotApprovedProposalLinesQuery(requestContext,QueryGetNotApprovedProposalLinesQuery_maxRecords,QueryGetNotApprovedProposalLinesQuery_startIndex,IterationMultiplicity.Single,(ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId,(await Functions.ActionGetUserRegionId(requestContext,"",cancellationToken)),(await Functions.ActionGetUserApplicationRoleCyA(requestContext,cancellationToken)),(ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("uL8+MGLLsUGnVkTyfH8gIw"))).ssId,(ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("OSpEADv8F0q4Sge4sU9mWA"))).ssId,(ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("tR_Y9rNyuUWKp4_z6ZegWQ"))).ssId,cancellationToken);

// NotApprovedProposalLines = GetNotApprovedProposalLinesQuery.List
result.outParamNotApprovedProposalLines=(await RL_496abaeba4975b81a1a9b391230e8099.ConvertAsync(localVars.queryResGetNotApprovedProposalLinesQuery_outParamList, new RL_496abaeba4975b81a1a9b391230e8099(), async (RC_6dc2ea62d515aadb2abe8127d022eca8 source, ST_bfed96b4bd29e9b06f0b06e901b1508bStructure target, CancellationToken cancellationToken) => {
target = source;
return target;
}, cancellationToken));
// Foreach GetNotApprovedProposalLinesQuery.List
localVars.queryResGetNotApprovedProposalLinesQuery_outParamList.StartIteration();
try {while (!((localVars.queryResGetNotApprovedProposalLinesQuery_outParamList.Eof))) {
// o_TotalCount = o_TotalCount + GetNotApprovedProposalLinesQuery.List.Current.Counter.Count
result.outParamo_TotalCount=(result.outParamo_TotalCount+localVars.queryResGetNotApprovedProposalLinesQuery_outParamList.CurrentRec.ssSTCounter.ssCount);
localVars.queryResGetNotApprovedProposalLinesQuery_outParamList.Advance();
}

} finally {
localVars.queryResGetNotApprovedProposalLinesQuery_outParamList.EndIteration();
}

} //close CreateActionActivity using block
} // try

finally {
outParamNotApprovedProposalLines = result.outParamNotApprovedProposalLines;
outParamo_TotalCount = result.outParamo_TotalCount;
} // inner-finally
RETURN_STATEMENT:
return (outParamNotApprovedProposalLines,outParamo_TotalCount);
}
public class lcvGetRejectedProposalLines : VarsBag {
public RL_5c41e853b96e612f21c832865afaaa1f queryResGetRejectedProposalLinesQuery_outParamList = new RL_5c41e853b96e612f21c832865afaaa1f();
public long queryResGetRejectedProposalLinesQuery_outParamCount = 0L;

public lcvGetRejectedProposalLines() {
}
}
public class lcoGetRejectedProposalLines : VarsBag {
public RL_496abaeba4975b81a1a9b391230e8099 outParamRejectedProposalLines = new RL_496abaeba4975b81a1a9b391230e8099();

public int outParamo_TotalCount = 0;

public lcoGetRejectedProposalLines() {
}
}
/// <summary>
/// Action <code>GetRejectedProposalLines</code> that represents the Service Studio action
///  <code>GetRejectedProposalLines</code> <p> Description: Get Rejected Proposal Lines Count.</p>
/// </summary>
public async Task<(RL_496abaeba4975b81a1a9b391230e8099,int)> DataActionGetRejectedProposalLines(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_496abaeba4975b81a1a9b391230e8099 outParamRejectedProposalLines = default;
int outParamo_TotalCount = default;
lcoGetRejectedProposalLines result = new lcoGetRejectedProposalLines();
lcvGetRejectedProposalLines localVars = new lcvGetRejectedProposalLines();
ConectaProveedores_a_Main_DashboardApprover_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetRejectedProposalLines", "fdda5711-f0f9-449b-8797-ef319e8f1ccf"))
using (activitySource.CreateScreenDataActionActivity("DashboardApprover", "GetRejectedProposalLines")){
// Query QueryGetRejectedProposalLinesQuery
cancellationToken.ThrowIfCancellationRequested();
int QueryGetRejectedProposalLinesQuery_maxRecords = 0;
int QueryGetRejectedProposalLinesQuery_startIndex = 0;(localVars.queryResGetRejectedProposalLinesQuery_outParamList,localVars.queryResGetRejectedProposalLinesQuery_outParamCount) = await FuncDataActionGetRejectedProposalLines.QueryGetRejectedProposalLinesQuery(requestContext,QueryGetRejectedProposalLinesQuery_maxRecords,QueryGetRejectedProposalLinesQuery_startIndex,IterationMultiplicity.Single,BuiltInFunction.NewDate (BuiltInFunction.Year (BuiltInFunction.CurrDate ()), BuiltInFunction.Month (BuiltInFunction.CurrDate ()), 1),BuiltInFunction.DateTimeToDate(BuiltInFunction.AddDays (BuiltInFunction.AddMonths (BuiltInFunction.NewDate (BuiltInFunction.Year (BuiltInFunction.CurrDate ()), BuiltInFunction.Month (BuiltInFunction.CurrDate ()), 1), 1), (-1))),(ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("rm4bAZ7dOEqgMcZKM9wLxg"))).ssId,(await Functions.ActionGetUserRegionId(requestContext,"",cancellationToken)),(await Functions.ActionGetUserApplicationRoleCyA(requestContext,cancellationToken)),(ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("uL8+MGLLsUGnVkTyfH8gIw"))).ssId,cancellationToken);

// RejectedProposalLines = GetRejectedProposalLinesQuery.List
result.outParamRejectedProposalLines=(await RL_496abaeba4975b81a1a9b391230e8099.ConvertAsync(localVars.queryResGetRejectedProposalLinesQuery_outParamList, new RL_496abaeba4975b81a1a9b391230e8099(), async (RC_6dc2ea62d515aadb2abe8127d022eca8 source, ST_bfed96b4bd29e9b06f0b06e901b1508bStructure target, CancellationToken cancellationToken) => {
target = source;
return target;
}, cancellationToken));
// Foreach GetRejectedProposalLinesQuery.List
localVars.queryResGetRejectedProposalLinesQuery_outParamList.StartIteration();
try {while (!((localVars.queryResGetRejectedProposalLinesQuery_outParamList.Eof))) {
// o_TotalCount = o_TotalCount + GetRejectedProposalLinesQuery.List.Current.Counter.Count
result.outParamo_TotalCount=(result.outParamo_TotalCount+localVars.queryResGetRejectedProposalLinesQuery_outParamList.CurrentRec.ssSTCounter.ssCount);
localVars.queryResGetRejectedProposalLinesQuery_outParamList.Advance();
}

} finally {
localVars.queryResGetRejectedProposalLinesQuery_outParamList.EndIteration();
}

} //close CreateActionActivity using block
} // try

finally {
outParamRejectedProposalLines = result.outParamRejectedProposalLines;
outParamo_TotalCount = result.outParamo_TotalCount;
} // inner-finally
RETURN_STATEMENT:
return (outParamRejectedProposalLines,outParamo_TotalCount);
}


    public static class FuncDataActionGetApprovedProposalLines {

// Query Function "GetApprovedProposalLinesQuery" I2OLRjTNmkiL7YwcX5VBHA of Action "GetApprovedProposalLines"
public static async Task<(RL_5c41e853b96e612f21c832865afaaa1f,long)> QueryGetApprovedProposalLinesQuery(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,DateTime qpdaMinDate,DateTime qpdaMaxDate,int qpapApprovedStatus,long qpreUserRegionId,long qpapUserApplicationRoleId,int qpprProposalStatusCanceled,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("a_Main.DashboardApprover.GetApprovedProposalLines.GetApprovedProposalLinesQuery", "468b6323-cd34-489a-8bed-8c1c5f95411c");
using var queryActivity = activitySource.CreateSqlQueryActivity("a_Main.DashboardApprover.GetApprovedProposalLines.GetApprovedProposalLinesQuery", "468b6323-cd34-489a-8bed-8c1c5f95411c", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Single
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string entityApprovalStatus = AppUtils.Instance.RuntimeEntityReplace("ApprovalStatus");
string entityProposal = AppUtils.Instance.RuntimeEntityReplace("Proposal");
string entityProposalLine = AppUtils.Instance.RuntimeEntityReplace("ProposalLine");
string entityProposalLineApprovalLevel = AppUtils.Instance.RuntimeEntityReplace("ProposalLineApprovalLevel");
sqlCmd.CreateParameter("@qpdaMinDate", DbType.DateTime, qpdaMinDate);
sqlCmd.CreateParameter("@qpdaMaxDate", DbType.DateTime, qpdaMaxDate);
sqlCmd.CreateParameter("@qpapApprovedStatus", DbType.Int32, qpapApprovedStatus);
sqlCmd.CreateParameter("@qpapUserApplicationRoleId", DbType.Int64, qpapUserApplicationRoleId);
sqlCmd.CreateParameter("@qpreUserRegionId", DbType.Int64, qpreUserRegionId);
sqlCmd.CreateParameter("@qpprProposalStatusCanceled", DbType.Int32, qpprProposalStatusCanceled);
string sql = "";
string advSql = "SELECT \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"label\"") + ", \n    COUNT(*) AS proposal_count \nFROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,"") + " \nJOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,"") + " \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,".\"proposalid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"id\"") + " \nJOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLineApprovalLevel,"") + "  \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLineApprovalLevel,".\"proposallineid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,".\"id\"") + " \nJOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,"") + " \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLineApprovalLevel,".\"approvalstatusid\"") + " \nWHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"createdon\"") + " BETWEEN @qpdaMinDate and @qpdaMaxDate \n    AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLineApprovalLevel,".\"approvalstatusid\"") + " = @qpapApprovedStatus \n    AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLineApprovalLevel,".\"applicationroleid\"") + " = @qpapUserApplicationRoleId \n    AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"regionid\"") + " = @qpreUserRegionId \n    AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"proposalstatusid\"") + " <> @qpprProposalStatusCanceled \nGROUP BY \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"label\"") + "";
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query a_Main.DashboardApprover.GetApprovedProposalLines.GetApprovedProposalLinesQuery.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query a_Main.DashboardApprover.GetApprovedProposalLines.GetApprovedProposalLinesQuery.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_5c41e853b96e612f21c832865afaaa1f)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetApprovedProposalLinesQuery in GetApprovedProposalLines in DashboardApprover in a_Main in ConectaProveedores (SELECT      {ApprovalStatus}.[Label],      COUNT(*) AS proposal_count  FROM {Proposal}  JOIN {ProposalLine}      ON {ProposalLine}.[ProposalId] = {Proposal}.[Id]  JOIN {ProposalLineApprovalLevel}       ON {ProposalLineApprovalLevel}.[ProposalLineId] = {ProposalLine}.[Id]  JOIN {ApprovalStatus}      ON {ApprovalStatus}.[Id] = {ProposalLineApprovalLevel}.[ApprovalStatusId]  WHERE {Proposal}.[CreatedOn] BETWEEN @MinDate and @MaxDate      AND {ProposalLineApprovalLevel}.[ApprovalStatusId] = @ApprovedStatus      AND {ProposalLineApprovalLevel}.[ApplicationRoleId] = @UserApplicationRoleId      AND {Proposal}.[RegionId] = @UserRegionId      AND {Proposal}.[ProposalStatusId] <> @ProposalStatusCanceled  GROUP BY      {ApprovalStatus}.[Label]): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetApprovedProposalLinesQuery in GetApprovedProposalLines in DashboardApprover in a_Main in ConectaProveedores (SELECT      {ApprovalStatus}.[Label],      COUNT(*) AS proposal_count  FROM {Proposal}  JOIN {ProposalLine}      ON {ProposalLine}.[ProposalId] = {Proposal}.[Id]  JOIN {ProposalLineApprovalLevel}       ON {ProposalLineApprovalLevel}.[ProposalLineId] = {ProposalLine}.[Id]  JOIN {ApprovalStatus}      ON {ApprovalStatus}.[Id] = {ProposalLineApprovalLevel}.[ApprovalStatusId]  WHERE {Proposal}.[CreatedOn] BETWEEN @MinDate and @MaxDate      AND {ProposalLineApprovalLevel}.[ApprovalStatusId] = @ApprovedStatus      AND {ProposalLineApprovalLevel}.[ApplicationRoleId] = @UserApplicationRoleId      AND {Proposal}.[RegionId] = @UserRegionId      AND {Proposal}.[ProposalStatusId] <> @ProposalStatusCanceled  GROUP BY      {ApprovalStatus}.[Label]): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetApprovedProposalLinesQuery in GetApprovedProposalLines in DashboardApprover in a_Main in ConectaProveedores (SELECT      {ApprovalStatus}.[Label],      COUNT(*) AS proposal_count  FROM {Proposal}  JOIN {ProposalLine}      ON {ProposalLine}.[ProposalId] = {Proposal}.[Id]  JOIN {ProposalLineApprovalLevel}       ON {ProposalLineApprovalLevel}.[ProposalLineId] = {ProposalLine}.[Id]  JOIN {ApprovalStatus}      ON {ApprovalStatus}.[Id] = {ProposalLineApprovalLevel}.[ApprovalStatusId]  WHERE {Proposal}.[CreatedOn] BETWEEN @MinDate and @MaxDate      AND {ProposalLineApprovalLevel}.[ApprovalStatusId] = @ApprovedStatus      AND {ProposalLineApprovalLevel}.[ApplicationRoleId] = @UserApplicationRoleId      AND {Proposal}.[RegionId] = @UserRegionId      AND {Proposal}.[ProposalStatusId] <> @ProposalStatusCanceled  GROUP BY      {ApprovalStatus}.[Label]): " + aqExcep.Message));
}
}
}
}
public static class FuncDataActionGetNotApprovedProposalLines {

// Query Function "GetNotApprovedProposalLinesQuery" 8HaRhlutUEmN2gnPj2NiEg of Action "GetNotApprovedProposalLines"
public static async Task<(RL_5c41e853b96e612f21c832865afaaa1f,long)> QueryGetNotApprovedProposalLinesQuery(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,int qpapNotApprovalStatus,long qpreUserRegionId,long qpapUserApplicationRoleId,int qpprProposalStatusCanceled,int qpprProposalStatusErrorAPI,int qpprProposalStatusRejected,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("a_Main.DashboardApprover.GetNotApprovedProposalLines.GetNotApprovedProposalLinesQuery", "869176f0-ad5b-4950-8dda-09cf8f636212");
using var queryActivity = activitySource.CreateSqlQueryActivity("a_Main.DashboardApprover.GetNotApprovedProposalLines.GetNotApprovedProposalLinesQuery", "869176f0-ad5b-4950-8dda-09cf8f636212", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Single
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string entityApprovalStatus = AppUtils.Instance.RuntimeEntityReplace("ApprovalStatus");
string entityProposal = AppUtils.Instance.RuntimeEntityReplace("Proposal");
string entityProposalLine = AppUtils.Instance.RuntimeEntityReplace("ProposalLine");
string entityProposalLineApprovalLevel = AppUtils.Instance.RuntimeEntityReplace("ProposalLineApprovalLevel");
sqlCmd.CreateParameter("@qpapNotApprovalStatus", DbType.Int32, qpapNotApprovalStatus);
sqlCmd.CreateParameter("@qpapUserApplicationRoleId", DbType.Int64, qpapUserApplicationRoleId);
sqlCmd.CreateParameter("@qpreUserRegionId", DbType.Int64, qpreUserRegionId);
sqlCmd.CreateParameter("@qpprProposalStatusCanceled", DbType.Int32, qpprProposalStatusCanceled);
sqlCmd.CreateParameter("@qpprProposalStatusErrorAPI", DbType.Int32, qpprProposalStatusErrorAPI);
sqlCmd.CreateParameter("@qpprProposalStatusRejected", DbType.Int32, qpprProposalStatusRejected);
string sql = "";
string advSql = "SELECT \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"label\"") + ", \n    COUNT(*) AS proposal_count \nFROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,"") + " \nJOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,"") + " \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,".\"proposalid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"id\"") + " \nJOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLineApprovalLevel,"") + "  \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLineApprovalLevel,".\"proposallineid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,".\"id\"") + " \nJOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,"") + " \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLineApprovalLevel,".\"approvalstatusid\"") + " \nWHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLineApprovalLevel,".\"approvalstatusid\"") + " = @qpapNotApprovalStatus \n    AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLineApprovalLevel,".\"applicationroleid\"") + " = @qpapUserApplicationRoleId \n    AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"regionid\"") + " = @qpreUserRegionId \n    AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"proposalstatusid\"") + " <> @qpprProposalStatusCanceled \n    AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"proposalstatusid\"") + " <> @qpprProposalStatusErrorAPI \n    AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"proposalstatusid\"") + " <> @qpprProposalStatusRejected \nGROUP BY \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"label\"") + "";
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query a_Main.DashboardApprover.GetNotApprovedProposalLines.GetNotApprovedProposalLinesQuery.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query a_Main.DashboardApprover.GetNotApprovedProposalLines.GetNotApprovedProposalLinesQuery.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_5c41e853b96e612f21c832865afaaa1f)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetNotApprovedProposalLinesQuery in GetNotApprovedProposalLines in DashboardApprover in a_Main in ConectaProveedores (SELECT      {ApprovalStatus}.[Label],      COUNT(*) AS proposal_count  FROM {Proposal}  JOIN {ProposalLine}      ON {ProposalLine}.[ProposalId] = {Proposal}.[Id]  JOIN {ProposalLineApprovalLevel}       ON {ProposalLineApprovalLevel}.[ProposalLineId] = {ProposalLine}.[Id]  JOIN {ApprovalStatus}      ON {ApprovalStatus}.[Id] = {ProposalLineApprovalLevel}.[ApprovalStatusId]  WHERE {ProposalLineApprovalLevel}.[ApprovalStatusId] = @NotApprovalStatus      AND {ProposalLineApprovalLevel}.[ApplicationRoleId] = @UserApplicationRoleId      AND {Proposal}.[RegionId] = @UserRegionId      AND {Proposal}.[ProposalStatusId] <> @ProposalStatusCanceled      AND {Proposal}.[ProposalStatusId] <> @ProposalStatusErrorAPI      AND {Proposal}.[ProposalStatusId] <> @ProposalStatusRejected  GROUP BY      {ApprovalStatus}.[Label]): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetNotApprovedProposalLinesQuery in GetNotApprovedProposalLines in DashboardApprover in a_Main in ConectaProveedores (SELECT      {ApprovalStatus}.[Label],      COUNT(*) AS proposal_count  FROM {Proposal}  JOIN {ProposalLine}      ON {ProposalLine}.[ProposalId] = {Proposal}.[Id]  JOIN {ProposalLineApprovalLevel}       ON {ProposalLineApprovalLevel}.[ProposalLineId] = {ProposalLine}.[Id]  JOIN {ApprovalStatus}      ON {ApprovalStatus}.[Id] = {ProposalLineApprovalLevel}.[ApprovalStatusId]  WHERE {ProposalLineApprovalLevel}.[ApprovalStatusId] = @NotApprovalStatus      AND {ProposalLineApprovalLevel}.[ApplicationRoleId] = @UserApplicationRoleId      AND {Proposal}.[RegionId] = @UserRegionId      AND {Proposal}.[ProposalStatusId] <> @ProposalStatusCanceled      AND {Proposal}.[ProposalStatusId] <> @ProposalStatusErrorAPI      AND {Proposal}.[ProposalStatusId] <> @ProposalStatusRejected  GROUP BY      {ApprovalStatus}.[Label]): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetNotApprovedProposalLinesQuery in GetNotApprovedProposalLines in DashboardApprover in a_Main in ConectaProveedores (SELECT      {ApprovalStatus}.[Label],      COUNT(*) AS proposal_count  FROM {Proposal}  JOIN {ProposalLine}      ON {ProposalLine}.[ProposalId] = {Proposal}.[Id]  JOIN {ProposalLineApprovalLevel}       ON {ProposalLineApprovalLevel}.[ProposalLineId] = {ProposalLine}.[Id]  JOIN {ApprovalStatus}      ON {ApprovalStatus}.[Id] = {ProposalLineApprovalLevel}.[ApprovalStatusId]  WHERE {ProposalLineApprovalLevel}.[ApprovalStatusId] = @NotApprovalStatus      AND {ProposalLineApprovalLevel}.[ApplicationRoleId] = @UserApplicationRoleId      AND {Proposal}.[RegionId] = @UserRegionId      AND {Proposal}.[ProposalStatusId] <> @ProposalStatusCanceled      AND {Proposal}.[ProposalStatusId] <> @ProposalStatusErrorAPI      AND {Proposal}.[ProposalStatusId] <> @ProposalStatusRejected  GROUP BY      {ApprovalStatus}.[Label]): " + aqExcep.Message));
}
}
}
}
public static class FuncDataActionGetRejectedProposalLines {

// Query Function "GetRejectedProposalLinesQuery" Rva4Swzfk0+bsoywgT6Udg of Action "GetRejectedProposalLines"
public static async Task<(RL_5c41e853b96e612f21c832865afaaa1f,long)> QueryGetRejectedProposalLinesQuery(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,DateTime qpdaMinDate,DateTime qpdaMaxDate,int qpapRejectedStatus,long qpreUserRegionId,long qpapUserApplicationRoleId,int qpprProposalStatusCanceled,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("a_Main.DashboardApprover.GetRejectedProposalLines.GetRejectedProposalLinesQuery", "4bb8f646-df0c-4f93-9bb2-8cb0813e9476");
using var queryActivity = activitySource.CreateSqlQueryActivity("a_Main.DashboardApprover.GetRejectedProposalLines.GetRejectedProposalLinesQuery", "4bb8f646-df0c-4f93-9bb2-8cb0813e9476", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Single
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string entityApprovalStatus = AppUtils.Instance.RuntimeEntityReplace("ApprovalStatus");
string entityProposal = AppUtils.Instance.RuntimeEntityReplace("Proposal");
string entityProposalLine = AppUtils.Instance.RuntimeEntityReplace("ProposalLine");
string entityProposalLineApprovalLevel = AppUtils.Instance.RuntimeEntityReplace("ProposalLineApprovalLevel");
sqlCmd.CreateParameter("@qpdaMinDate", DbType.DateTime, qpdaMinDate);
sqlCmd.CreateParameter("@qpdaMaxDate", DbType.DateTime, qpdaMaxDate);
sqlCmd.CreateParameter("@qpapRejectedStatus", DbType.Int32, qpapRejectedStatus);
sqlCmd.CreateParameter("@qpapUserApplicationRoleId", DbType.Int64, qpapUserApplicationRoleId);
sqlCmd.CreateParameter("@qpreUserRegionId", DbType.Int64, qpreUserRegionId);
sqlCmd.CreateParameter("@qpprProposalStatusCanceled", DbType.Int32, qpprProposalStatusCanceled);
string sql = "";
string advSql = "SELECT \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"label\"") + ", \n    COUNT(*) AS proposal_count \nFROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,"") + " \nJOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,"") + " \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,".\"proposalid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"id\"") + " \nJOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLineApprovalLevel,"") + "  \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLineApprovalLevel,".\"proposallineid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLine,".\"id\"") + " \nJOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,"") + " \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLineApprovalLevel,".\"approvalstatusid\"") + " \nWHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"createdon\"") + " BETWEEN @qpdaMinDate and @qpdaMaxDate \n    AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLineApprovalLevel,".\"approvalstatusid\"") + " = @qpapRejectedStatus \n    AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposalLineApprovalLevel,".\"applicationroleid\"") + " = @qpapUserApplicationRoleId \n    AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"regionid\"") + " = @qpreUserRegionId \n    AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProposal,".\"proposalstatusid\"") + " <> @qpprProposalStatusCanceled \nGROUP BY \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"label\"") + "";
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query a_Main.DashboardApprover.GetRejectedProposalLines.GetRejectedProposalLinesQuery.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query a_Main.DashboardApprover.GetRejectedProposalLines.GetRejectedProposalLinesQuery.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_5c41e853b96e612f21c832865afaaa1f)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetRejectedProposalLinesQuery in GetRejectedProposalLines in DashboardApprover in a_Main in ConectaProveedores (SELECT      {ApprovalStatus}.[Label],      COUNT(*) AS proposal_count  FROM {Proposal}  JOIN {ProposalLine}      ON {ProposalLine}.[ProposalId] = {Proposal}.[Id]  JOIN {ProposalLineApprovalLevel}       ON {ProposalLineApprovalLevel}.[ProposalLineId] = {ProposalLine}.[Id]  JOIN {ApprovalStatus}      ON {ApprovalStatus}.[Id] = {ProposalLineApprovalLevel}.[ApprovalStatusId]  WHERE {Proposal}.[CreatedOn] BETWEEN @MinDate and @MaxDate      AND {ProposalLineApprovalLevel}.[ApprovalStatusId] = @RejectedStatus      AND {ProposalLineApprovalLevel}.[ApplicationRoleId] = @UserApplicationRoleId      AND {Proposal}.[RegionId] = @UserRegionId      AND {Proposal}.[ProposalStatusId] <> @ProposalStatusCanceled  GROUP BY      {ApprovalStatus}.[Label]): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetRejectedProposalLinesQuery in GetRejectedProposalLines in DashboardApprover in a_Main in ConectaProveedores (SELECT      {ApprovalStatus}.[Label],      COUNT(*) AS proposal_count  FROM {Proposal}  JOIN {ProposalLine}      ON {ProposalLine}.[ProposalId] = {Proposal}.[Id]  JOIN {ProposalLineApprovalLevel}       ON {ProposalLineApprovalLevel}.[ProposalLineId] = {ProposalLine}.[Id]  JOIN {ApprovalStatus}      ON {ApprovalStatus}.[Id] = {ProposalLineApprovalLevel}.[ApprovalStatusId]  WHERE {Proposal}.[CreatedOn] BETWEEN @MinDate and @MaxDate      AND {ProposalLineApprovalLevel}.[ApprovalStatusId] = @RejectedStatus      AND {ProposalLineApprovalLevel}.[ApplicationRoleId] = @UserApplicationRoleId      AND {Proposal}.[RegionId] = @UserRegionId      AND {Proposal}.[ProposalStatusId] <> @ProposalStatusCanceled  GROUP BY      {ApprovalStatus}.[Label]): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetRejectedProposalLinesQuery in GetRejectedProposalLines in DashboardApprover in a_Main in ConectaProveedores (SELECT      {ApprovalStatus}.[Label],      COUNT(*) AS proposal_count  FROM {Proposal}  JOIN {ProposalLine}      ON {ProposalLine}.[ProposalId] = {Proposal}.[Id]  JOIN {ProposalLineApprovalLevel}       ON {ProposalLineApprovalLevel}.[ProposalLineId] = {ProposalLine}.[Id]  JOIN {ApprovalStatus}      ON {ApprovalStatus}.[Id] = {ProposalLineApprovalLevel}.[ApprovalStatusId]  WHERE {Proposal}.[CreatedOn] BETWEEN @MinDate and @MaxDate      AND {ProposalLineApprovalLevel}.[ApprovalStatusId] = @RejectedStatus      AND {ProposalLineApprovalLevel}.[ApplicationRoleId] = @UserApplicationRoleId      AND {Proposal}.[RegionId] = @UserRegionId      AND {Proposal}.[ProposalStatusId] <> @ProposalStatusCanceled  GROUP BY      {ApprovalStatus}.[Label]): " + aqExcep.Message));
}
}
}
}


}
