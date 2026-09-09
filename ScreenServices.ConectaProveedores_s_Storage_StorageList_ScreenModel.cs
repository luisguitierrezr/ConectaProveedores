using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_s_Storage_StorageList_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_s_Storage_StorageList_ScreenModel).Namespace);

    public string varLcKeyword;
public string varLcTableSort;
public int varLcStartIndex;
public int varLcMaxRecords;
public AggregateRecord<RL_d3db3806acf82f8f2cc8b7a1ac07805b> ScreenDataSetStorageList;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_s_Storage_StorageList_ScreenModel() {
}



    public ConectaProveedores_s_Storage_StorageList_ScreenModel(string varLcKeyword, string varLcTableSort, int varLcStartIndex, int varLcMaxRecords, AggregateRecord<RL_d3db3806acf82f8f2cc8b7a1ac07805b> ScreenDataSetStorageList, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"Keyword", "TableSort", "StartIndex", "MaxRecords", "StorageList", "ClientVars"}, new string[] {"varLcKeyword", "varLcTableSort", "varLcStartIndex", "varLcMaxRecords", "ScreenDataSetStorageList", "clientVariables"});
this.varLcKeyword = varLcKeyword;
this.varLcTableSort = varLcTableSort;
this.varLcStartIndex = varLcStartIndex;
this.varLcMaxRecords = varLcMaxRecords;
this.ScreenDataSetStorageList = ScreenDataSetStorageList;
this.clientVariables = clientVariables;
}



    
// Query Function "StorageList" nd_0iLhXb0WCxXGr1i3Szg of Action "StorageList"
public static async Task<(RL_d3db3806acf82f8f2cc8b7a1ac07805b,long)> datasetStorageList(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteKeyword,string qpteTableSort,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("s_Storage.StorageList.StorageList", "88f4df9d-57b8-456f-82c5-71abd62dd2ce");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("StorageList","s_Storage.StorageList.StorageList");
// Query Iterations: Multiple
// Refresh Query 4pzevBJA3UqcMrx2FF3Ugg Iterations: Multiple
// Refresh Query ycFKnrvXUEmlEgp0Ec51Mw Iterations: Multiple
// Refresh Query zGDHmoYjZ0i3oQPLOeXU5g Iterations: Multiple
// Refresh Query Qrtmq9Eub0ePDUMFJ96MFw Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
await using(var sqlCountCmd = trans.CreateCommand()){
string sql = "";
string sqlCount = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /NRWebFlows.2U30RcCSoUG+QhQMrCUZgA/NodesShownInESpaceTree.Y8_SekButkCfJpPr6NPeuw/ScreenDataSets.nd_0iLhXb0WCxXGr1i3Szg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enstorage29\".\"id\" o0, \"enstorage29\".\"concept\" o1, NULL o2, NULL o3, \"enstorage29\".\"filename\" o4, \"enstorage29\".\"vendor\" o5, \"enstorage29\".\"doc_type\" o6, \"enstorage29\".\"object_type\" o7, \"enstorage29\".\"istosendtoexternal\" o8, \"enstorage29\".\"withentegrationerror\" o9, \"enstorage29\".\"isexternal\" o10, NULL o11, \"enstorage29\".\"arc_doc_id\" o12, NULL o13, \"enstorage29\".\"sentwhen\" o14, \"enstorage29\".\"istodelete\" o15, \"enstorage29\".\"istobig\" o16, \"enstorage29\".\"attempt\" o17, \"enstorage29\".\"size\" o18, NULL o19");
fromBuilder.Append(" FROM {Storage} \"enstorage29\"");
whereBuilder.Append(" WHERE (\"enstorage29\".\"internalconceptid\" = ");
whereBuilder.Append(1
);
whereBuilder.Append(") AND ");
if (qpteKeyword != "" && qpteKeyword != "" && qpteKeyword != "" && qpteKeyword != "" && qpteKeyword != "") {
whereBuilder.Append("((((caseaccent_normalize(\"enstorage29\".\"filename\" collate \"default\") like caseaccent_normalize((('%' || @qpteKeyword) || '%') collate \"default\")) OR (caseaccent_normalize(\"enstorage29\".\"vendor\" collate \"default\") like caseaccent_normalize((('%' || @qpteKeyword) || '%') collate \"default\"))) OR (caseaccent_normalize(\"enstorage29\".\"concept\" collate \"default\") like caseaccent_normalize((('%' || @qpteKeyword) || '%') collate \"default\"))) OR (caseaccent_normalize(\"enstorage29\".\"arc_doc_id\" collate \"default\") like caseaccent_normalize((('%' || @qpteKeyword) || '%') collate \"default\")))");
sqlCmd.CreateParameterWithoutReplacements("@qpteKeyword", DbType.String, qpteKeyword);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteKeyword", DbType.String, qpteKeyword);
}
string whereBuilderString = whereBuilder.ToString();
if (whereBuilderString.EndsWith(" AND ")) {
whereBuilder.Remove(whereBuilderString.Length - 5, 5);
}
orderByBuilder.Append(" ORDER BY ");
List<string> orderByColumns = new List<string>();
orderByColumns.AddRange(BaseAppUtils.ReplaceEntityReferencesAndAttributesInOrderBy(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, qpteTableSort, new string[] { "Storage" }, new string[] { "ENStorage29" }, new System.Collections.Generic.Dictionary<string, string>[] { ENStorageEntity.AttributesToDatabaseNamesMap() }).Split(','));
orderByColumns.Add("\"enstorage29\".\"id\" DESC ");
orderByBuilder.Append(BaseAppUtils.GetOrderByColumnsWithoutDuplicates(orderByColumns));
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
if (startIndex > 0) {
orderByBuilder.Append(" OFFSET ");
orderByBuilder.Append(startIndex);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCount = "SELECT COUNT(1) " + fromBuilder.ToString() + whereBuilder.ToString() + groupByBuilder.ToString() + havingBuilder.ToString();
sqlCount = AppUtils.Instance.ReplaceEntityReferences(requestContext, sqlCount);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
sqlCountCmd.CommandText = sqlCount;
try {
RL_d3db3806acf82f8f2cc8b7a1ac07805b outParamList = new RL_d3db3806acf82f8f2cc8b7a1ac07805b();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, true, true, false, false, false, false, false, false, false, true, false, true, false, false, false, false, false, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query s_Storage.StorageList.StorageList.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query s_Storage.StorageList.StorageList.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_d3db3806acf82f8f2cc8b7a1ac07805b _tmp = new RL_d3db3806acf82f8f2cc8b7a1ac07805b();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query s_Storage.StorageList.StorageList.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_d3db3806acf82f8f2cc8b7a1ac07805b)_tmp;
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query s_Storage.StorageList.StorageList.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
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


    

    

}
