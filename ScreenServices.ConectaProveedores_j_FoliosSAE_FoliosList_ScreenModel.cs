using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_j_FoliosSAE_FoliosList_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_j_FoliosSAE_FoliosList_ScreenModel).Namespace);

    public string varLcTableSort;
public int varLcStartIndex;
public int varLcMaxRecords;
public AggregateRecord<RL_cb63d2f3bb3714fa686ba5a50757aacf> ScreenDataSetGetFolios;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_j_FoliosSAE_FoliosList_ScreenModel() {
}



    public ConectaProveedores_j_FoliosSAE_FoliosList_ScreenModel(string varLcTableSort, int varLcStartIndex, int varLcMaxRecords, AggregateRecord<RL_cb63d2f3bb3714fa686ba5a50757aacf> ScreenDataSetGetFolios, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"TableSort", "StartIndex", "MaxRecords", "GetFolios", "ClientVars"}, new string[] {"varLcTableSort", "varLcStartIndex", "varLcMaxRecords", "ScreenDataSetGetFolios", "clientVariables"});
this.varLcTableSort = varLcTableSort;
this.varLcStartIndex = varLcStartIndex;
this.varLcMaxRecords = varLcMaxRecords;
this.ScreenDataSetGetFolios = ScreenDataSetGetFolios;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_f520669a02d9f27d638b5ecc83782607> datasetGetFoliosReadDbAsync(RC_f520669a02d9f27d638b5ecc83782607 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolio.Read( r, ref index);
rec.ssENFolioStatus.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetFolios" n4Ag+HkCRU6PWtu6qK+v0w of Action "FoliosList"
public static async Task<(RL_cb63d2f3bb3714fa686ba5a50757aacf,long)> datasetGetFolios(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteTableSort,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.FoliosList.GetFolios", "f820809f-0279-4e45-8f5a-dbbaa8afafd3");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("FoliosList","j_FoliosSAE.FoliosList.GetFolios");
// Query Iterations: Multiple
// Refresh Query HOkACIkC9UmnZOqcJkusrg Iterations: Multiple
// Refresh Query qBQu+aX2okqs_l+7w6gq3w Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.9Euzeu9pYEWHhQGGxGTTQg/ScreenDataSets.n4Ag+HkCRU6PWtu6qK+v0w, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enfolio106\".\"isdraft\" o1, \"enfolio106\".\"folionumber\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, \"enordermain149\".\"ordernumber\" o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, \"ensupplier147\".\"tratamiento\" o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82");
fromBuilder.Append(" FROM ((({Folio} \"enfolio106\" Left JOIN {FolioStatus} \"enfoliostatus19\" ON (\"enfolio106\".\"foliostatusid\" = \"enfoliostatus19\".\"id\"))  Left JOIN {Supplier} \"ensupplier147\" ON (\"enfolio106\".\"supplierid\" = \"ensupplier147\".\"id\"))  Left JOIN {OrderMain} \"enordermain149\" ON (\"enfolio106\".\"orderid\" = \"enordermain149\".\"id\")) ");
if ((qpteTableSort.Trim()!="")) {
orderByBuilder.Append(" ORDER BY ");
List<string> orderByColumns = new List<string>();
orderByColumns.AddRange(BaseAppUtils.ReplaceEntityReferencesAndAttributesInOrderBy(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, qpteTableSort, new string[] { "FolioStatus", "Folio", "Supplier", "OrderMain" }, new string[] { "ENFolioStatus19", "ENFolio106", "ENSupplier147", "ENOrderMain149" }, new System.Collections.Generic.Dictionary<string, string>[] { ENFolioStatusEntity.AttributesToDatabaseNamesMap(), ENFolioEntity.AttributesToDatabaseNamesMap(), ENSupplierEntity.AttributesToDatabaseNamesMap(), ENOrderMainEntity.AttributesToDatabaseNamesMap() }).Split(','));
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
RL_cb63d2f3bb3714fa686ba5a50757aacf outParamList = new RL_cb63d2f3bb3714fa686ba5a50757aacf();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFoliosReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[4];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query j_FoliosSAE.FoliosList.GetFolios.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.FoliosList.GetFolios.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_cb63d2f3bb3714fa686ba5a50757aacf _tmp = new RL_cb63d2f3bb3714fa686ba5a50757aacf();
_tmp.AlternateReadDbMethodAsync = datasetGetFoliosReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.FoliosList.GetFolios.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_cb63d2f3bb3714fa686ba5a50757aacf)_tmp;
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query j_FoliosSAE.FoliosList.GetFolios.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
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
