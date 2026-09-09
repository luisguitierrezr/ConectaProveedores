using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_c_Requisitions_Wb_SelectReqRegion_Popup_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_c_Requisitions_Wb_SelectReqRegion_Popup_ScreenModel).Namespace);

    public long varLcl_RegionId;
public AggregateRecord<RL_5d3a02aa993c7474297e33d992f39ad0> ScreenDataSetGetRegions;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_c_Requisitions_Wb_SelectReqRegion_Popup_ScreenModel() {
}



    public ConectaProveedores_c_Requisitions_Wb_SelectReqRegion_Popup_ScreenModel(long varLcl_RegionId, AggregateRecord<RL_5d3a02aa993c7474297e33d992f39ad0> ScreenDataSetGetRegions, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"l_RegionId", "GetRegions", "ClientVars"}, new string[] {"varLcl_RegionId", "ScreenDataSetGetRegions", "clientVariables"});
this.varLcl_RegionId = varLcl_RegionId;
this.ScreenDataSetGetRegions = ScreenDataSetGetRegions;
this.clientVariables = clientVariables;
}



    
// Query Function "GetRegions" LY5rinzEX0GRQJKfUk7Q+A of Action "Wb_SelectReqRegion_Popup"
public static async Task<(RL_5d3a02aa993c7474297e33d992f39ad0,long)> datasetGetRegions(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("c_Requisitions.Wb_SelectReqRegion_Popup.GetRegions", "8a6b8e2d-c47c-415f-9140-929f524ed0f8");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_SelectReqRegion_Popup","c_Requisitions.Wb_SelectReqRegion_Popup.GetRegions");
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
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.4t5bx_prnkiXgY0uFb+S1Q/ScreenDataSets.LY5rinzEX0GRQJKfUk7Q+A, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enregion143\".\"id\" o0, NULL o1, \"enregion143\".\"name\" o2, NULL o3, NULL o4, \"enregion143\".\"commissionregion\" o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12");
fromBuilder.Append(" FROM {Region} \"enregion143\"");
whereBuilder.Append(" WHERE (\"enregion143\".\"isactive\" = 1)");
orderByBuilder.Append(" ORDER BY \"enregion143\".\"commissionregion\" ASC ");
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
RL_5d3a02aa993c7474297e33d992f39ad0 outParamList = new RL_5d3a02aa993c7474297e33d992f39ad0();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, false, true, true, false, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.Wb_SelectReqRegion_Popup.GetRegions.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.Wb_SelectReqRegion_Popup.GetRegions.List", cancellationToken: cancellationToken);
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
