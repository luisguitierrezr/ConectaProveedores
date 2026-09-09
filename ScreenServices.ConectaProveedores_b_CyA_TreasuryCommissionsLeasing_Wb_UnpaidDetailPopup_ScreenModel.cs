using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_Wb_UnpaidDetailPopup_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_Wb_UnpaidDetailPopup_ScreenModel).Namespace);

    public long inParami_ProposalLineId;
public AggregateRecord<RL_64d6c39a28702aee27a7d75c307bc2c1> ScreenDataSetGetProposalLineById;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_Wb_UnpaidDetailPopup_ScreenModel() {
}



    public ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_Wb_UnpaidDetailPopup_ScreenModel(long inParami_ProposalLineId, AggregateRecord<RL_64d6c39a28702aee27a7d75c307bc2c1> ScreenDataSetGetProposalLineById, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"i_ProposalLineId", "GetProposalLineById", "ClientVars"}, new string[] {"inParami_ProposalLineId", "ScreenDataSetGetProposalLineById", "clientVariables"});
this.inParami_ProposalLineId = inParami_ProposalLineId;
this.ScreenDataSetGetProposalLineById = ScreenDataSetGetProposalLineById;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_781b0cc57cc94effbff3496f8da9c758> datasetGetProposalLineByIdReadDbAsync(RC_781b0cc57cc94effbff3496f8da9c758 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENProposalComment.Read( r, ref index);
rec.ssENProposalCommentFile.Read( r, ref index);
rec.ssENProposalLine.Read( r, ref index);
return rec;
}
// Query Function "GetProposalLineById" TrXSAYJWk0Kd6uGknxucbA of Action "Wb_UnpaidDetailPopup"
public static async Task<(RL_64d6c39a28702aee27a7d75c307bc2c1,long)> datasetGetProposalLineById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpprProposalLine_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("b_CyA_TreasuryCommissionsLeasing.Wb_UnpaidDetailPopup.GetProposalLineById", "01d2b54e-5682-4293-9dea-e1a49f1b9c6c");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_UnpaidDetailPopup","b_CyA_TreasuryCommissionsLeasing.Wb_UnpaidDetailPopup.GetProposalLineById");
// Query Iterations: Never
// Refresh Query CCCyqAiaBkSi8FI+S8knRw Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.sBq8pxDfr0GAxtE80fQu3g/NodesShownInESpaceTree.Nfb_0kWya0y9pVjvYJ4VCA/ScreenDataSets.TrXSAYJWk0Kd6uGknxucbA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, \"enproposalcomment1\".\"message\" o7, \"enproposalcommentfile\".\"id\" o8, NULL o9, \"enproposalcommentfile\".\"filename\" o10, \"enproposalcommentfile\".\"binary\" o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39");
fromBuilder.Append(" FROM (({ProposalLine} \"enproposalline12\" Left JOIN {ProposalComment} \"enproposalcomment1\" ON (\"enproposalline12\".\"id\" = \"enproposalcomment1\".\"proposallineid\"))  Left JOIN {ProposalCommentFile} \"enproposalcommentfile\" ON (\"enproposalcomment1\".\"id\" = \"enproposalcommentfile\".\"commentid\")) ");
whereBuilder.Append(" WHERE ");
if (qpprProposalLine_Id != 0) {
whereBuilder.Append("((\"enproposalline12\".\"id\" = @qpprProposalLine_Id) AND (\"enproposalline12\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprProposalLine_Id", DbType.Int64, qpprProposalLine_Id);
} else {
whereBuilder.Append("(\"enproposalline12\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (\"enproposalcomment1\".\"commenttypeid\" = ");
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
RL_64d6c39a28702aee27a7d75c307bc2c1 outParamList = new RL_64d6c39a28702aee27a7d75c307bc2c1();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetProposalLineByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, false});
opt[1] = new BitArray(new bool[] {false, true, false, false});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query b_CyA_TreasuryCommissionsLeasing.Wb_UnpaidDetailPopup.GetProposalLineById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_64d6c39a28702aee27a7d75c307bc2c1 _tmp = new RL_64d6c39a28702aee27a7d75c307bc2c1();
_tmp.AlternateReadDbMethodAsync = datasetGetProposalLineByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query b_CyA_TreasuryCommissionsLeasing.Wb_UnpaidDetailPopup.GetProposalLineById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_64d6c39a28702aee27a7d75c307bc2c1)_tmp;
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
