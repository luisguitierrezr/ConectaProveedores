using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_b_CyA_AdminCommissionsLeasing_Wb_ProposalCanceledMotive_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_b_CyA_AdminCommissionsLeasing_Wb_ProposalCanceledMotive_ScreenModel).Namespace);

    public long inParami_ProposalId;
public AggregateRecord<RL_6f7a73531f09191ac235a09fbbea38a5> ScreenDataSetGetCommentsByProposalId;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_b_CyA_AdminCommissionsLeasing_Wb_ProposalCanceledMotive_ScreenModel() {
}



    public ConectaProveedores_b_CyA_AdminCommissionsLeasing_Wb_ProposalCanceledMotive_ScreenModel(long inParami_ProposalId, AggregateRecord<RL_6f7a73531f09191ac235a09fbbea38a5> ScreenDataSetGetCommentsByProposalId, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"i_ProposalId", "GetCommentsByProposalId", "ClientVars"}, new string[] {"inParami_ProposalId", "ScreenDataSetGetCommentsByProposalId", "clientVariables"});
this.inParami_ProposalId = inParami_ProposalId;
this.ScreenDataSetGetCommentsByProposalId = ScreenDataSetGetCommentsByProposalId;
this.clientVariables = clientVariables;
}



    
// Query Function "GetCommentsByProposalId" X9CWsrQZFEyNHjKWMBbBbQ of Action "Wb_ProposalCanceledMotive"
public static async Task<(RL_6f7a73531f09191ac235a09fbbea38a5,long)> datasetGetCommentsByProposalId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpprProposalId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("b_CyA_AdminCommissionsLeasing.Wb_ProposalCanceledMotive.GetCommentsByProposalId", "b296d05f-19b4-4c14-8d1e-32963016c16d");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_ProposalCanceledMotive","b_CyA_AdminCommissionsLeasing.Wb_ProposalCanceledMotive.GetCommentsByProposalId");
// Query Iterations: Never
// Refresh Query gu2G5PTxtE27D8qhRx8L2A Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.Qwoh9BhTeEOXvq3lBDkhrg/NodesShownInESpaceTree.MgmcB8CD70miR+dhCTT5kA/ScreenDataSets.X9CWsrQZFEyNHjKWMBbBbQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, \"enproposalcomment4\".\"message\" o7");
fromBuilder.Append(" FROM {ProposalComment} \"enproposalcomment4\"");
whereBuilder.Append(" WHERE ");
if (qpprProposalId != 0) {
whereBuilder.Append("((\"enproposalcomment4\".\"proposalid\" = @qpprProposalId) AND (\"enproposalcomment4\".\"proposalid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprProposalId", DbType.Int64, qpprProposalId);
} else {
whereBuilder.Append("(\"enproposalcomment4\".\"proposalid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enproposalcomment4\".\"commenttypeid\" = ");
whereBuilder.Append((ENCommentTypeEntity.GetRecordByKey(ObjectKey.Parse("qajvy+SdnE6bqldjFZvPIg"))).ssId);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query b_CyA_AdminCommissionsLeasing.Wb_ProposalCanceledMotive.GetCommentsByProposalId.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query b_CyA_AdminCommissionsLeasing.Wb_ProposalCanceledMotive.GetCommentsByProposalId.List", cancellationToken: cancellationToken);
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
