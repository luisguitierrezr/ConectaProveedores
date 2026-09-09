using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewIcons_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewIcons_ScreenModel).Namespace);

    public long inParamRequisitionId;
public string inParamRequisitionName;
public bool varLcl_PreviewFilesToggler;
public AggregateRecord<RL_dcf9165e080aea63f7a9b95efcf09ef4> ScreenDataSetRequisitionFilesById;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewIcons_ScreenModel() {
}



    public ConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewIcons_ScreenModel(long inParamRequisitionId, string inParamRequisitionName, bool varLcl_PreviewFilesToggler, AggregateRecord<RL_dcf9165e080aea63f7a9b95efcf09ef4> ScreenDataSetRequisitionFilesById, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"RequisitionId", "RequisitionName", "l_PreviewFilesToggler", "RequisitionFilesById", "ClientVars"}, new string[] {"inParamRequisitionId", "inParamRequisitionName", "varLcl_PreviewFilesToggler", "ScreenDataSetRequisitionFilesById", "clientVariables"});
this.inParamRequisitionId = inParamRequisitionId;
this.inParamRequisitionName = inParamRequisitionName;
this.varLcl_PreviewFilesToggler = varLcl_PreviewFilesToggler;
this.ScreenDataSetRequisitionFilesById = ScreenDataSetRequisitionFilesById;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_dc345357879dcb92e41eacae4ac8926c> datasetRequisitionFilesByIdReadDbAsync(RC_dc345357879dcb92e41eacae4ac8926c rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENRequisitionContractFile.Read( r, ref index);
rec.ssENRequisitionFile2.Read( r, ref index);
return rec;
}
// Query Function "RequisitionFilesById" UDPOImHPyk6215elbVVKiQ of Action "Wb_RequisitionsPreviewIcons"
public static async Task<(RL_dcf9165e080aea63f7a9b95efcf09ef4,long)> datasetRequisitionFilesById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisitionContractFile_RequisitionId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("c_Requisitions.Wb_RequisitionsPreviewIcons.RequisitionFilesById", "22ce3350-cf61-4eca-b6d7-97a56d554a89");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_RequisitionsPreviewIcons","c_Requisitions.Wb_RequisitionsPreviewIcons.RequisitionFilesById");
// Query Iterations: Never
// Refresh Query OMksRXX4hUCgU2P1tqP7KA Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.mcfyxP6FpkOtchpohAG6Hg/ScreenDataSets.UDPOImHPyk6215elbVVKiQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16");
fromBuilder.Append(" FROM ({RequisitionContractFile} \"enrequisitioncontractfile15\" Left JOIN {RequisitionFile2} \"enrequisitionfile212\" ON (\"enrequisitioncontractfile15\".\"requisitionfileid\" = \"enrequisitionfile212\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpreRequisitionContractFile_RequisitionId != 0) {
whereBuilder.Append("((\"enrequisitioncontractfile15\".\"requisitionid\" = @qpreRequisitionContractFile_RequisitionId) AND (\"enrequisitioncontractfile15\".\"requisitionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisitionContractFile_RequisitionId", DbType.Int64, qpreRequisitionContractFile_RequisitionId);
} else {
whereBuilder.Append("(\"enrequisitioncontractfile15\".\"requisitionid\" IS NULL)");
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
RL_dcf9165e080aea63f7a9b95efcf09ef4 outParamList = new RL_dcf9165e080aea63f7a9b95efcf09ef4();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetRequisitionFilesByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.Wb_RequisitionsPreviewIcons.RequisitionFilesById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_dcf9165e080aea63f7a9b95efcf09ef4 _tmp = new RL_dcf9165e080aea63f7a9b95efcf09ef4();
_tmp.AlternateReadDbMethodAsync = datasetRequisitionFilesByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.Wb_RequisitionsPreviewIcons.RequisitionFilesById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_dcf9165e080aea63f7a9b95efcf09ef4)_tmp;
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
