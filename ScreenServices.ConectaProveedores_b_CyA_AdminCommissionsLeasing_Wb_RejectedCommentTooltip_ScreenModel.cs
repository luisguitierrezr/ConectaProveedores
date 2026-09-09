using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_b_CyA_AdminCommissionsLeasing_Wb_RejectedCommentTooltip_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_b_CyA_AdminCommissionsLeasing_Wb_RejectedCommentTooltip_ScreenModel).Namespace);

    public long inParami_ProposalLineApprovalLevelId;
public AggregateRecord<RL_b1eac7b235569839fbbc9e410d978a26> ScreenDataSetGetCommentsByProposalLineApprovalLevelId;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_b_CyA_AdminCommissionsLeasing_Wb_RejectedCommentTooltip_ScreenModel() {
}



    public ConectaProveedores_b_CyA_AdminCommissionsLeasing_Wb_RejectedCommentTooltip_ScreenModel(long inParami_ProposalLineApprovalLevelId, AggregateRecord<RL_b1eac7b235569839fbbc9e410d978a26> ScreenDataSetGetCommentsByProposalLineApprovalLevelId, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"i_ProposalLineApprovalLevelId", "GetCommentsByProposalLineApprovalLevelId", "ClientVars"}, new string[] {"inParami_ProposalLineApprovalLevelId", "ScreenDataSetGetCommentsByProposalLineApprovalLevelId", "clientVariables"});
this.inParami_ProposalLineApprovalLevelId = inParami_ProposalLineApprovalLevelId;
this.ScreenDataSetGetCommentsByProposalLineApprovalLevelId = ScreenDataSetGetCommentsByProposalLineApprovalLevelId;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_eb264c698175fb3dfb268b531134340c> datasetGetCommentsByProposalLineApprovalLevelIdReadDbAsync(RC_eb264c698175fb3dfb268b531134340c rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApplicationRole.Read( r, ref index);
rec.ssENProposalComment.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
return rec;
}
// Query Function "GetCommentsByProposalLineApprovalLevelId" wMH3We8TrkCHYscFWQw3aQ of Action "Wb_RejectedCommentTooltip"
public static async Task<(RL_b1eac7b235569839fbbc9e410d978a26,long)> datasetGetCommentsByProposalLineApprovalLevelId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpprProposalComment_ProposalLineApprovalLevelId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("b_CyA_AdminCommissionsLeasing.Wb_RejectedCommentTooltip.GetCommentsByProposalLineApprovalLevelId", "59f7c1c0-13ef-40ae-8762-c705590c3769");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_RejectedCommentTooltip","b_CyA_AdminCommissionsLeasing.Wb_RejectedCommentTooltip.GetCommentsByProposalLineApprovalLevelId");
// Query Iterations: Never
// Refresh Query kdUUsVbEnEGfzezz+jWfRg Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.Qwoh9BhTeEOXvq3lBDkhrg/NodesShownInESpaceTree.PX6ssRMYqE6_Dai+8cv6PQ/ScreenDataSets.wMH3We8TrkCHYscFWQw3aQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, \"enproposalcomment5\".\"message\" o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19");
fromBuilder.Append(" FROM (({ProposalComment} \"enproposalcomment5\" Left JOIN {User} \"enuser216\" ON (\"enproposalcomment5\".\"createdby\" = \"enuser216\".\"id\"))  Left JOIN {ApplicationRole} \"enapplicationrole78\" ON (\"enproposalcomment5\".\"applicationroleid\" = \"enapplicationrole78\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpprProposalComment_ProposalLineApprovalLevelId != 0) {
whereBuilder.Append("((\"enproposalcomment5\".\"proposallineapprovallevelid\" = @qpprProposalComment_ProposalLineApprovalLevelId) AND (\"enproposalcomment5\".\"proposallineapprovallevelid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprProposalComment_ProposalLineApprovalLevelId", DbType.Int64, qpprProposalComment_ProposalLineApprovalLevelId);
} else {
whereBuilder.Append("(\"enproposalcomment5\".\"proposallineapprovallevelid\" IS NULL)");
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
RL_b1eac7b235569839fbbc9e410d978a26 outParamList = new RL_b1eac7b235569839fbbc9e410d978a26();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetCommentsByProposalLineApprovalLevelIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, false});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query b_CyA_AdminCommissionsLeasing.Wb_RejectedCommentTooltip.GetCommentsByProposalLineApprovalLevelId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_b1eac7b235569839fbbc9e410d978a26 _tmp = new RL_b1eac7b235569839fbbc9e410d978a26();
_tmp.AlternateReadDbMethodAsync = datasetGetCommentsByProposalLineApprovalLevelIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query b_CyA_AdminCommissionsLeasing.Wb_RejectedCommentTooltip.GetCommentsByProposalLineApprovalLevelId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_b1eac7b235569839fbbc9e410d978a26)_tmp;
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
