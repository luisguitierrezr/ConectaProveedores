using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_Wb_UnpaidCommentTooltip_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_Wb_UnpaidCommentTooltip_ScreenModel).Namespace);

    public long inParami_ProposalLineId;
public AggregateRecord<RL_6f7a73531f09191ac235a09fbbea38a5> ScreenDataSetGetCommentsByProposalLineId;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_Wb_UnpaidCommentTooltip_ScreenModel() {
}



    public ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_Wb_UnpaidCommentTooltip_ScreenModel(long inParami_ProposalLineId, AggregateRecord<RL_6f7a73531f09191ac235a09fbbea38a5> ScreenDataSetGetCommentsByProposalLineId, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"i_ProposalLineId", "GetCommentsByProposalLineId", "ClientVars"}, new string[] {"inParami_ProposalLineId", "ScreenDataSetGetCommentsByProposalLineId", "clientVariables"});
this.inParami_ProposalLineId = inParami_ProposalLineId;
this.ScreenDataSetGetCommentsByProposalLineId = ScreenDataSetGetCommentsByProposalLineId;
this.clientVariables = clientVariables;
}



    
// Query Function "GetCommentsByProposalLineId" 6WRxtZQ4gUu0_mbb5x8OyA of Action "Wb_UnpaidCommentTooltip"
public static async Task<(RL_6f7a73531f09191ac235a09fbbea38a5,long)> datasetGetCommentsByProposalLineId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpprProposalLineId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("b_CyA_TreasuryCommissionsLeasing.Wb_UnpaidCommentTooltip.GetCommentsByProposalLineId", "b57164e9-3894-4b81-b4fe-66dbe71f0ec8");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_UnpaidCommentTooltip","b_CyA_TreasuryCommissionsLeasing.Wb_UnpaidCommentTooltip.GetCommentsByProposalLineId");
// Query Iterations: Never
// Refresh Query kEBG+rZcB0igUIZIF_WG8Q Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.sBq8pxDfr0GAxtE80fQu3g/NodesShownInESpaceTree.iQtK6HkLKEymyz_gYXOp_A/ScreenDataSets.6WRxtZQ4gUu0_mbb5x8OyA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, \"enproposalcomment2\".\"message\" o7");
fromBuilder.Append(" FROM {ProposalComment} \"enproposalcomment2\"");
whereBuilder.Append(" WHERE ");
if (qpprProposalLineId != 0) {
whereBuilder.Append("((\"enproposalcomment2\".\"proposallineid\" = @qpprProposalLineId) AND (\"enproposalcomment2\".\"proposallineid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprProposalLineId", DbType.Int64, qpprProposalLineId);
} else {
whereBuilder.Append("(\"enproposalcomment2\".\"proposallineid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enproposalcomment2\".\"commenttypeid\" = ");
whereBuilder.Append((ENCommentTypeEntity.GetRecordByKey(ObjectKey.Parse("Yb_2rORMO0CiONuueCSezA"))).ssId);
whereBuilder.Append(")");
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
RL_6f7a73531f09191ac235a09fbbea38a5 outParamList = new RL_6f7a73531f09191ac235a09fbbea38a5();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query b_CyA_TreasuryCommissionsLeasing.Wb_UnpaidCommentTooltip.GetCommentsByProposalLineId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_6f7a73531f09191ac235a09fbbea38a5 _tmp = new RL_6f7a73531f09191ac235a09fbbea38a5();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query b_CyA_TreasuryCommissionsLeasing.Wb_UnpaidCommentTooltip.GetCommentsByProposalLineId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_6f7a73531f09191ac235a09fbbea38a5)_tmp;
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
