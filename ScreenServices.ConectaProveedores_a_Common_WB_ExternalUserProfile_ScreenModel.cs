using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_a_Common_WB_ExternalUserProfile_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_a_Common_WB_ExternalUserProfile_ScreenModel).Namespace);

    public bool varLcl_IsOpenPopUp;
public AggregateRecord<RL_d5c1b2482ff109e80580d8b5fb920193> ScreenDataSetGetSupplierById;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_a_Common_WB_ExternalUserProfile_ScreenModel() {
}



    public ConectaProveedores_a_Common_WB_ExternalUserProfile_ScreenModel(bool varLcl_IsOpenPopUp, AggregateRecord<RL_d5c1b2482ff109e80580d8b5fb920193> ScreenDataSetGetSupplierById, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"l_IsOpenPopUp", "GetSupplierById", "ClientVars"}, new string[] {"varLcl_IsOpenPopUp", "ScreenDataSetGetSupplierById", "clientVariables"});
this.varLcl_IsOpenPopUp = varLcl_IsOpenPopUp;
this.ScreenDataSetGetSupplierById = ScreenDataSetGetSupplierById;
this.clientVariables = clientVariables;
}



    
// Query Function "GetSupplierById" 8xJV13nn50CHIhGpJWQ2Rg of Action "WB_ExternalUserProfile"
public static async Task<(RL_d5c1b2482ff109e80580d8b5fb920193,long)> datasetGetSupplierById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpsuId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("a_Common.WB_ExternalUserProfile.GetSupplierById", "d75512f3-e779-40e7-8722-11a925643646");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("WB_ExternalUserProfile","a_Common.WB_ExternalUserProfile.GetSupplierById");
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
selectBuilder.Append("/* /NRWebFlows.B4kRGvrnOEmQonA8ir4Pyg/NodesShownInESpaceTree.tC38Js_CL0GL8rIe4kTvFA/ScreenDataSets.8xJV13nn50CHIhGpJWQ2Rg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"ensupplier68\".\"name\" o2, \"ensupplier68\".\"number\" o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, \"ensupplier68\".\"region_\" o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, \"ensupplier68\".\"n_ident_fis_1\" o17, NULL o18, \"ensupplier68\".\"ramo\" o19, \"ensupplier68\".\"grupodeporte\" o20, \"ensupplier68\".\"email\" o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27");
fromBuilder.Append(" FROM {Supplier} \"ensupplier68\"");
whereBuilder.Append(" WHERE ");
if (qpsuId != 0) {
whereBuilder.Append("((\"ensupplier68\".\"id\" = @qpsuId) AND (\"ensupplier68\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuId", DbType.Int64, qpsuId);
} else {
whereBuilder.Append("(\"ensupplier68\".\"id\" IS NULL)");
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
RL_d5c1b2482ff109e80580d8b5fb920193 outParamList = new RL_d5c1b2482ff109e80580d8b5fb920193();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, false, false, true, true, true, true, true, false, true, true, true, true, true, true, true, false, true, false, false, false, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query a_Common.WB_ExternalUserProfile.GetSupplierById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_d5c1b2482ff109e80580d8b5fb920193 _tmp = new RL_d5c1b2482ff109e80580d8b5fb920193();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query a_Common.WB_ExternalUserProfile.GetSupplierById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_d5c1b2482ff109e80580d8b5fb920193)_tmp;
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
