using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_s_Storage_StorageDeleted_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_s_Storage_StorageDeleted_ScreenModel).Namespace);

    public string varLcKeyword;
public string varLcTableSort;
public int varLcStartIndex;
public int varLcMaxRecords;
public AggregateRecord<RL_860298826198654ea08dbde054bb1413> ScreenDataSetStorageList;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_s_Storage_StorageDeleted_ScreenModel() {
}



    public ConectaProveedores_s_Storage_StorageDeleted_ScreenModel(string varLcKeyword, string varLcTableSort, int varLcStartIndex, int varLcMaxRecords, AggregateRecord<RL_860298826198654ea08dbde054bb1413> ScreenDataSetStorageList, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"Keyword", "TableSort", "StartIndex", "MaxRecords", "StorageList", "ClientVars"}, new string[] {"varLcKeyword", "varLcTableSort", "varLcStartIndex", "varLcMaxRecords", "ScreenDataSetStorageList", "clientVariables"});
this.varLcKeyword = varLcKeyword;
this.varLcTableSort = varLcTableSort;
this.varLcStartIndex = varLcStartIndex;
this.varLcMaxRecords = varLcMaxRecords;
this.ScreenDataSetStorageList = ScreenDataSetStorageList;
this.clientVariables = clientVariables;
}



    
// Query Function "StorageList" NAT+VIbhgUqaLstz3fZS6w of Action "StorageDeleted"
public static async Task<(RL_860298826198654ea08dbde054bb1413,long)> datasetStorageList(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteKeyword,string qpteTableSort,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("s_Storage.StorageDeleted.StorageList", "54fe0434-e186-4a81-9a2e-cb73ddf652eb");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("StorageDeleted","s_Storage.StorageDeleted.StorageList");
// Query Iterations: Multiple
// Refresh Query sOegi6_IykuKK_wcC4D8yg Iterations: Multiple
// Refresh Query 6tNugzdhq0uW5fTnjkc3Ew Iterations: Multiple
// Refresh Query rN5xc71afkC3RtB+0Hp_2w Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.2U30RcCSoUG+QhQMrCUZgA/NodesShownInESpaceTree.nOlLD8d+u0iSYCW7kZvtng/ScreenDataSets.NAT+VIbhgUqaLstz3fZS6w, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"endeletedstorage\".\"id\" o0, NULL o1, \"endeletedstorage\".\"concept\" o2, \"endeletedstorage\".\"filename\" o3, \"endeletedstorage\".\"vendor\" o4, \"endeletedstorage\".\"doc_type\" o5, \"endeletedstorage\".\"object_type\" o6, NULL o7, \"endeletedstorage\".\"arc_doc_id\" o8");
fromBuilder.Append(" FROM {DeletedStorage} \"endeletedstorage\"");
whereBuilder.Append(" WHERE (\"endeletedstorage\".\"internalconceptid\" = ");
whereBuilder.Append(1
);
whereBuilder.Append(") AND ");
if (qpteKeyword != "" && qpteKeyword != "" && qpteKeyword != "" && qpteKeyword != "" && qpteKeyword != "") {
whereBuilder.Append("((((caseaccent_normalize(\"endeletedstorage\".\"filename\" collate \"default\") like caseaccent_normalize((('%' || @qpteKeyword) || '%') collate \"default\")) OR (caseaccent_normalize(\"endeletedstorage\".\"vendor\" collate \"default\") like caseaccent_normalize((('%' || @qpteKeyword) || '%') collate \"default\"))) OR (caseaccent_normalize(\"endeletedstorage\".\"concept\" collate \"default\") like caseaccent_normalize((('%' || @qpteKeyword) || '%') collate \"default\"))) OR (caseaccent_normalize(\"endeletedstorage\".\"arc_doc_id\" collate \"default\") like caseaccent_normalize((('%' || @qpteKeyword) || '%') collate \"default\")))");
sqlCmd.CreateParameterWithoutReplacements("@qpteKeyword", DbType.String, qpteKeyword);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteKeyword", DbType.String, qpteKeyword);
}
string whereBuilderString = whereBuilder.ToString();
if (whereBuilderString.EndsWith(" AND ")) {
whereBuilder.Remove(whereBuilderString.Length - 5, 5);
}
if ((qpteTableSort.Trim()!="")) {
orderByBuilder.Append(" ORDER BY ");
List<string> orderByColumns = new List<string>();
orderByColumns.AddRange(BaseAppUtils.ReplaceEntityReferencesAndAttributesInOrderBy(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, qpteTableSort, new string[] { "DeletedStorage" }, new string[] { "ENDeletedStorage" }, new System.Collections.Generic.Dictionary<string, string>[] { ENDeletedStorageEntity.AttributesToDatabaseNamesMap() }).Split(','));
orderByBuilder.Append(BaseAppUtils.GetOrderByColumnsWithoutDuplicates(orderByColumns));
} else {
orderByBuilder.Append(" ORDER BY 1 ASC");
}
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
RL_860298826198654ea08dbde054bb1413 outParamList = new RL_860298826198654ea08dbde054bb1413();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, false, false, false, false, false, true, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query s_Storage.StorageDeleted.StorageList.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query s_Storage.StorageDeleted.StorageList.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_860298826198654ea08dbde054bb1413 _tmp = new RL_860298826198654ea08dbde054bb1413();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query s_Storage.StorageDeleted.StorageList.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_860298826198654ea08dbde054bb1413)_tmp;
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query s_Storage.StorageDeleted.StorageList.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
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
