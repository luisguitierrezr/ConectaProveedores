using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_j_FoliosSAE_Wb_SAECDetailPositions_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_j_FoliosSAE_Wb_SAECDetailPositions_ScreenModel).Namespace);

    public long inParami_FolioId;
public string inParami_CurrencyCode;
public decimal inParami_TotalAmount;
public int varLcStartIndex;
public int varLcMaxRecords;
public string varLcTableSort;
public AggregateRecord<RL_a968cf9f63475dc9358672149b11245a> ScreenDataSetGetFolioItemsByFolioId;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_j_FoliosSAE_Wb_SAECDetailPositions_ScreenModel() {
}



    public ConectaProveedores_j_FoliosSAE_Wb_SAECDetailPositions_ScreenModel(long inParami_FolioId, string inParami_CurrencyCode, decimal inParami_TotalAmount, int varLcStartIndex, int varLcMaxRecords, string varLcTableSort, AggregateRecord<RL_a968cf9f63475dc9358672149b11245a> ScreenDataSetGetFolioItemsByFolioId, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"i_FolioId", "i_CurrencyCode", "i_TotalAmount", "StartIndex", "MaxRecords", "TableSort", "GetFolioItemsByFolioId", "ClientVars"}, new string[] {"inParami_FolioId", "inParami_CurrencyCode", "inParami_TotalAmount", "varLcStartIndex", "varLcMaxRecords", "varLcTableSort", "ScreenDataSetGetFolioItemsByFolioId", "clientVariables"});
this.inParami_FolioId = inParami_FolioId;
this.inParami_CurrencyCode = inParami_CurrencyCode;
this.inParami_TotalAmount = inParami_TotalAmount;
this.varLcStartIndex = varLcStartIndex;
this.varLcMaxRecords = varLcMaxRecords;
this.varLcTableSort = varLcTableSort;
this.ScreenDataSetGetFolioItemsByFolioId = ScreenDataSetGetFolioItemsByFolioId;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_95110bc97f34f4c1561c8cbf2b5015b2> datasetGetFolioItemsByFolioIdReadDbAsync(RC_95110bc97f34f4c1561c8cbf2b5015b2 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolio.Read( r, ref index);
rec.ssENFolioItems.Read( r, ref index);
rec.ssENOrderMainItem.Read( r, ref index);
return rec;
}
// Query Function "GetFolioItemsByFolioId" jC3OxmdzO0ibYMFXX96C9A of Action "Wb_SAECDetailPositions"
public static async Task<(RL_a968cf9f63475dc9358672149b11245a,long)> datasetGetFolioItemsByFolioId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolioItems_FolioId,string qpteTableSort,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.Wb_SAECDetailPositions.GetFolioItemsByFolioId", "c6ce2d8c-7367-483b-9b60-c1575fde82f4");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_SAECDetailPositions","j_FoliosSAE.Wb_SAECDetailPositions.GetFolioItemsByFolioId");
// Query Iterations: Multiple
// Refresh Query pJlbhDj3d0eAmzDrLrbxqg Iterations: Multiple
// Refresh Query hZCJw+o+lU2OFyAkrJab5w Iterations: Multiple
// Refresh Query 2uQBDjajLUSRTiV6vdYzXg Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.GckEidHqu0aADILK17R3xQ/ScreenDataSets.jC3OxmdzO0ibYMFXX96C9A, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, \"enfolioitems21\".\"ordernumber\" o23, \"enfolioitems21\".\"articlenumber\" o24, \"enfolioitems21\".\"description\" o25, \"enfolioitems21\".\"inputationcode\" o26, \"enfolioitems21\".\"deliverydate\" o27, trim_scale(\"enfolioitems21\".\"invoiceqtt\"::numeric) o28, NULL o29, trim_scale(\"enfolioitems21\".\"unitprice\"::numeric) o30, trim_scale(\"enfolioitems21\".\"totalprice\"::numeric) o31, NULL o32, NULL o33, NULL o34, \"enfolioitems21\".\"pep\" o35, NULL o36, NULL o37, NULL o38, NULL o39, \"enordermainitem39\".\"position\" o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, \"enordermainitem39\".\"ismultipleimputation\" o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88");
fromBuilder.Append(" FROM (({FolioItems} \"enfolioitems21\" Left JOIN {Folio} \"enfolio107\" ON (\"enfolioitems21\".\"folioid\" = \"enfolio107\".\"id\"))  Left JOIN {OrderMainItem} \"enordermainitem39\" ON (\"enfolioitems21\".\"ordermainitemid\" = \"enordermainitem39\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoFolioItems_FolioId != 0) {
whereBuilder.Append("((\"enfolioitems21\".\"folioid\" = @qpfoFolioItems_FolioId) AND (\"enfolioitems21\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioItems_FolioId", DbType.Int64, qpfoFolioItems_FolioId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpfoFolioItems_FolioId", DbType.Int64, qpfoFolioItems_FolioId);
} else {
whereBuilder.Append("(\"enfolioitems21\".\"folioid\" IS NULL)");
}
if ((qpteTableSort.Trim()!="")) {
orderByBuilder.Append(" ORDER BY ");
List<string> orderByColumns = new List<string>();
orderByColumns.AddRange(BaseAppUtils.ReplaceEntityReferencesAndAttributesInOrderBy(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, qpteTableSort, new string[] { "Folio", "OrderMainItem", "FolioItems" }, new string[] { "ENFolio107", "ENOrderMainItem39", "ENFolioItems21" }, new System.Collections.Generic.Dictionary<string, string>[] { ENFolioEntity.AttributesToDatabaseNamesMap(), ENOrderMainItemEntity.AttributesToDatabaseNamesMap(), ENFolioItemsEntity.AttributesToDatabaseNamesMap() }).Split(','));
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
RL_a968cf9f63475dc9358672149b11245a outParamList = new RL_a968cf9f63475dc9358672149b11245a();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFolioItemsByFolioIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, false, false, false, false, false, false, true, false, false, true, true, true, false, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query j_FoliosSAE.Wb_SAECDetailPositions.GetFolioItemsByFolioId.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_SAECDetailPositions.GetFolioItemsByFolioId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_a968cf9f63475dc9358672149b11245a _tmp = new RL_a968cf9f63475dc9358672149b11245a();
_tmp.AlternateReadDbMethodAsync = datasetGetFolioItemsByFolioIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_SAECDetailPositions.GetFolioItemsByFolioId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_a968cf9f63475dc9358672149b11245a)_tmp;
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query j_FoliosSAE.Wb_SAECDetailPositions.GetFolioItemsByFolioId.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
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
