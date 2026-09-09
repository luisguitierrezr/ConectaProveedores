using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_j_FoliosSAE_FolioSAE_Details_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_j_FoliosSAE_FolioSAE_Details_ScreenModel).Namespace);

    public long inParami_FolioId;
public bool inParami_IsDirectReport;
public DateTime varLcl_RefreshOrderEntra_Historic;
public int varLcStartIndex;
public int varLcMaxRecords;
public string varLcTableSort;
public bool varLcShowCancelPopup;
public AggregateRecord<RL_a968cf9f63475dc9358672149b11245a> ScreenDataSetGetFolioItemsByFolioId;
public AggregateRecord<RL_52e01c48f1745de5266c16d6fe2c0564> ScreenDataSetGetFolioApprovalRejectReason;
public AggregateRecord<RL_994583bfe1c92160ce9fe58b4f4e0d70> ScreenDataSetGetFolioComments;
public AggregateRecord<RL_c4a88225f641d9bcf04728601a4668b7> ScreenDataSetGetFirstApproval;
public AggregateRecord<RL_a73c6a3c39840602048be2cd6d699c01> ScreenDataSetGetFolioById;
public ConectaProveedores_j_FoliosSAE_FolioSAE_Details_DataActionGetUserApplicationRoles_Model varLcGetUserApplicationRoles;
public ConectaProveedores_j_FoliosSAE_FolioSAE_Details_DataActionGetRejectComment_Model varLcGetRejectComment;
public ConectaProveedores_j_FoliosSAE_FolioSAE_Details_DataActionGetFolioApprovalDisplay_Model varLcGetFolioApprovalDisplay;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_j_FoliosSAE_FolioSAE_Details_ScreenModel() {
}



    public ConectaProveedores_j_FoliosSAE_FolioSAE_Details_ScreenModel(long inParami_FolioId, bool inParami_IsDirectReport, DateTime varLcl_RefreshOrderEntra_Historic, int varLcStartIndex, int varLcMaxRecords, string varLcTableSort, bool varLcShowCancelPopup, AggregateRecord<RL_a968cf9f63475dc9358672149b11245a> ScreenDataSetGetFolioItemsByFolioId, AggregateRecord<RL_52e01c48f1745de5266c16d6fe2c0564> ScreenDataSetGetFolioApprovalRejectReason, AggregateRecord<RL_994583bfe1c92160ce9fe58b4f4e0d70> ScreenDataSetGetFolioComments, AggregateRecord<RL_c4a88225f641d9bcf04728601a4668b7> ScreenDataSetGetFirstApproval, AggregateRecord<RL_a73c6a3c39840602048be2cd6d699c01> ScreenDataSetGetFolioById, ConectaProveedores_j_FoliosSAE_FolioSAE_Details_DataActionGetUserApplicationRoles_Model varLcGetUserApplicationRoles, ConectaProveedores_j_FoliosSAE_FolioSAE_Details_DataActionGetRejectComment_Model varLcGetRejectComment, ConectaProveedores_j_FoliosSAE_FolioSAE_Details_DataActionGetFolioApprovalDisplay_Model varLcGetFolioApprovalDisplay, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"i_FolioId", "i_IsDirectReport", "l_RefreshOrderEntra_Historic", "StartIndex", "MaxRecords", "TableSort", "ShowCancelPopup", "GetFolioItemsByFolioId", "GetFolioApprovalRejectReason", "GetFolioComments", "GetFirstApproval", "GetFolioById", "GetUserApplicationRoles", "GetRejectComment", "GetFolioApprovalDisplay", "ClientVars"}, new string[] {"inParami_FolioId", "inParami_IsDirectReport", "varLcl_RefreshOrderEntra_Historic", "varLcStartIndex", "varLcMaxRecords", "varLcTableSort", "varLcShowCancelPopup", "ScreenDataSetGetFolioItemsByFolioId", "ScreenDataSetGetFolioApprovalRejectReason", "ScreenDataSetGetFolioComments", "ScreenDataSetGetFirstApproval", "ScreenDataSetGetFolioById", "varLcGetUserApplicationRoles", "varLcGetRejectComment", "varLcGetFolioApprovalDisplay", "clientVariables"});
this.inParami_FolioId = inParami_FolioId;
this.inParami_IsDirectReport = inParami_IsDirectReport;
this.varLcl_RefreshOrderEntra_Historic = varLcl_RefreshOrderEntra_Historic;
this.varLcStartIndex = varLcStartIndex;
this.varLcMaxRecords = varLcMaxRecords;
this.varLcTableSort = varLcTableSort;
this.varLcShowCancelPopup = varLcShowCancelPopup;
this.ScreenDataSetGetFolioItemsByFolioId = ScreenDataSetGetFolioItemsByFolioId;
this.ScreenDataSetGetFolioApprovalRejectReason = ScreenDataSetGetFolioApprovalRejectReason;
this.ScreenDataSetGetFolioComments = ScreenDataSetGetFolioComments;
this.ScreenDataSetGetFirstApproval = ScreenDataSetGetFirstApproval;
this.ScreenDataSetGetFolioById = ScreenDataSetGetFolioById;
this.varLcGetUserApplicationRoles = varLcGetUserApplicationRoles;
this.varLcGetRejectComment = varLcGetRejectComment;
this.varLcGetFolioApprovalDisplay = varLcGetFolioApprovalDisplay;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_95110bc97f34f4c1561c8cbf2b5015b2> datasetGetFolioItemsByFolioIdReadDbAsync(RC_95110bc97f34f4c1561c8cbf2b5015b2 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolio.Read( r, ref index);
rec.ssENFolioItems.Read( r, ref index);
rec.ssENOrderMainItem.Read( r, ref index);
return rec;
}
// Query Function "GetFolioItemsByFolioId" wrvDDDelH0qLbP0yzocllQ of Action "FolioSAE_Details"
public static async Task<(RL_a968cf9f63475dc9358672149b11245a,long)> datasetGetFolioItemsByFolioId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolioItems_FolioId,string qpteTableSort,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.FolioSAE_Details.GetFolioItemsByFolioId", "0cc3bbc2-a537-4a1f-8b6c-fd32ce872595");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("FolioSAE_Details","j_FoliosSAE.FolioSAE_Details.GetFolioItemsByFolioId");
// Query Iterations: Multiple
// Refresh Query KGHziwuAwEi9Bh0vWpJ1DQ Iterations: Multiple
// Refresh Query K3UAMWbOxke_xGlqY2luFg Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree._HBBBoPGEEWB3rBNy9LnHg/ScreenDataSets.wrvDDDelH0qLbP0yzocllQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, \"enfolioitems11\".\"ordernumber\" o23, \"enfolioitems11\".\"articlenumber\" o24, \"enfolioitems11\".\"description\" o25, \"enfolioitems11\".\"inputationcode\" o26, \"enfolioitems11\".\"deliverydate\" o27, trim_scale(\"enfolioitems11\".\"invoiceqtt\"::numeric) o28, NULL o29, trim_scale(\"enfolioitems11\".\"unitprice\"::numeric) o30, trim_scale(\"enfolioitems11\".\"totalprice\"::numeric) o31, NULL o32, NULL o33, NULL o34, \"enfolioitems11\".\"pep\" o35, NULL o36, NULL o37, NULL o38, NULL o39, \"enordermainitem26\".\"position\" o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, \"enordermainitem26\".\"ismultipleimputation\" o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88");
fromBuilder.Append(" FROM (({FolioItems} \"enfolioitems11\" Left JOIN {Folio} \"enfolio78\" ON (\"enfolioitems11\".\"folioid\" = \"enfolio78\".\"id\"))  Left JOIN {OrderMainItem} \"enordermainitem26\" ON (\"enfolioitems11\".\"ordermainitemid\" = \"enordermainitem26\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoFolioItems_FolioId != 0) {
whereBuilder.Append("((\"enfolioitems11\".\"folioid\" = @qpfoFolioItems_FolioId) AND (\"enfolioitems11\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioItems_FolioId", DbType.Int64, qpfoFolioItems_FolioId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpfoFolioItems_FolioId", DbType.Int64, qpfoFolioItems_FolioId);
} else {
whereBuilder.Append("(\"enfolioitems11\".\"folioid\" IS NULL)");
}
if ((qpteTableSort.Trim()!="")) {
orderByBuilder.Append(" ORDER BY ");
List<string> orderByColumns = new List<string>();
orderByColumns.AddRange(BaseAppUtils.ReplaceEntityReferencesAndAttributesInOrderBy(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, qpteTableSort, new string[] { "Folio", "FolioItems", "OrderMainItem" }, new string[] { "ENFolio78", "ENFolioItems11", "ENOrderMainItem26" }, new System.Collections.Generic.Dictionary<string, string>[] { ENFolioEntity.AttributesToDatabaseNamesMap(), ENFolioItemsEntity.AttributesToDatabaseNamesMap(), ENOrderMainItemEntity.AttributesToDatabaseNamesMap() }).Split(','));
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
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query j_FoliosSAE.FolioSAE_Details.GetFolioItemsByFolioId.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.FolioSAE_Details.GetFolioItemsByFolioId.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.FolioSAE_Details.GetFolioItemsByFolioId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_a968cf9f63475dc9358672149b11245a)_tmp;
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query j_FoliosSAE.FolioSAE_Details.GetFolioItemsByFolioId.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
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

private static async Task<RC_131b941598d8581e5466dbb966f5f0a8> datasetGetFolioApprovalRejectReasonReadDbAsync(RC_131b941598d8581e5466dbb966f5f0a8 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolioApproval.Read( r, ref index);
rec.ssENFolioApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetFolioApprovalRejectReason" TtotQBlyr02wmx0ruh3XpQ of Action "FolioSAE_Details"
public static async Task<(RL_52e01c48f1745de5266c16d6fe2c0564,long)> datasetGetFolioApprovalRejectReason(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolioApproval_FolioId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.FolioSAE_Details.GetFolioApprovalRejectReason", "402dda4e-7219-4daf-b09b-1d2bba1dd7a5");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("FolioSAE_Details","j_FoliosSAE.FolioSAE_Details.GetFolioApprovalRejectReason");
// Query Iterations: Never
// Refresh Query 9lw1mvQn1UyhGGZt46p30g Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree._HBBBoPGEEWB3rBNy9LnHg/ScreenDataSets.TtotQBlyr02wmx0ruh3XpQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, \"enfolioapprovallevel37\".\"rejectreason\" o28, NULL o29");
fromBuilder.Append(" FROM ({FolioApproval} \"enfolioapproval41\" Left JOIN {FolioApprovalLevel} \"enfolioapprovallevel37\" ON (\"enfolioapproval41\".\"id\" = \"enfolioapprovallevel37\".\"folioapprovalid\")) ");
whereBuilder.Append(" WHERE (\"enfolioapprovallevel37\".\"isinvoiceapproval\" = 1) AND ");
if (qpfoFolioApproval_FolioId != 0) {
whereBuilder.Append("((\"enfolioapproval41\".\"folioid\" = @qpfoFolioApproval_FolioId) AND (\"enfolioapproval41\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioApproval_FolioId", DbType.Int64, qpfoFolioApproval_FolioId);
} else {
whereBuilder.Append("(\"enfolioapproval41\".\"folioid\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"enfolioapprovallevel37\".\"levelnumber\" ASC ");
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
RL_52e01c48f1745de5266c16d6fe2c0564 outParamList = new RL_52e01c48f1745de5266c16d6fe2c0564();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFolioApprovalRejectReasonReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.FolioSAE_Details.GetFolioApprovalRejectReason.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_52e01c48f1745de5266c16d6fe2c0564 _tmp = new RL_52e01c48f1745de5266c16d6fe2c0564();
_tmp.AlternateReadDbMethodAsync = datasetGetFolioApprovalRejectReasonReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.FolioSAE_Details.GetFolioApprovalRejectReason.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_52e01c48f1745de5266c16d6fe2c0564)_tmp;
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

// Query Function "GetFolioComments" prXbWsmKFUyGCrDKN0p+Mg of Action "FolioSAE_Details"
public static async Task<(RL_994583bfe1c92160ce9fe58b4f4e0d70,long)> datasetGetFolioComments(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolioId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.FolioSAE_Details.GetFolioComments", "5adbb5a6-8ac9-4c15-860a-b0ca374a7e32");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("FolioSAE_Details","j_FoliosSAE.FolioSAE_Details.GetFolioComments");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree._HBBBoPGEEWB3rBNy9LnHg/ScreenDataSets.prXbWsmKFUyGCrDKN0p+Mg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"enfolioobservations\".\"observation\" o2, NULL o3, \"enfolioobservations\".\"createdon\" o4");
fromBuilder.Append(" FROM {FolioObservations} \"enfolioobservations\"");
whereBuilder.Append(" WHERE ");
if (qpfoFolioId != 0) {
whereBuilder.Append("((\"enfolioobservations\".\"folioid\" = @qpfoFolioId) AND (\"enfolioobservations\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioId", DbType.Int64, qpfoFolioId);
} else {
whereBuilder.Append("(\"enfolioobservations\".\"folioid\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"enfolioobservations\".\"createdon\" DESC ");
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
RL_994583bfe1c92160ce9fe58b4f4e0d70 outParamList = new RL_994583bfe1c92160ce9fe58b4f4e0d70();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, false, true, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.FolioSAE_Details.GetFolioComments.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_994583bfe1c92160ce9fe58b4f4e0d70 _tmp = new RL_994583bfe1c92160ce9fe58b4f4e0d70();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.FolioSAE_Details.GetFolioComments.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_994583bfe1c92160ce9fe58b4f4e0d70)_tmp;
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

private static async Task<RC_d41d580f2f54d1ea8dfa839824757d81> datasetGetFirstApprovalReadDbAsync(RC_d41d580f2f54d1ea8dfa839824757d81 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENEntraRole.Read( r, ref index);
rec.ssENFolioApproval.Read( r, ref index);
rec.ssENFolioApprovalLevel.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
return rec;
}
// Query Function "GetFirstApproval" UbzCq50vp0uKzRNIo+YONA of Action "FolioSAE_Details"
public static async Task<(RL_c4a88225f641d9bcf04728601a4668b7,long)> datasetGetFirstApproval(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolioApproval_FolioId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.FolioSAE_Details.GetFirstApproval", "abc2bc51-2f9d-4ba7-8acd-1348a3e60e34");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("FolioSAE_Details","j_FoliosSAE.FolioSAE_Details.GetFirstApproval");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree._HBBBoPGEEWB3rBNy9LnHg/ScreenDataSets.UbzCq50vp0uKzRNIo+YONA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enentrarole78\".\"rolename\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, \"enuser224\".\"name\" o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60");
fromBuilder.Append(" FROM (((({FolioApproval} \"enfolioapproval42\" Inner JOIN {FolioApprovalLevel} \"enfolioapprovallevel38\" ON (\"enfolioapproval42\".\"id\" = \"enfolioapprovallevel38\".\"folioapprovalid\"))  Left JOIN {User} \"enuser224\" ON (\"enfolioapprovallevel38\".\"assignedto\" = \"enuser224\".\"id\"))  Left JOIN {User_Extended_Internal} \"enuser_extended_internal132\" ON (\"enuser224\".\"id\" = \"enuser_extended_internal132\".\"id\"))  Left JOIN {EntraRole} \"enentrarole78\" ON (\"enuser_extended_internal132\".\"entraroleid\" = \"enentrarole78\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoFolioApproval_FolioId != 0) {
whereBuilder.Append("((\"enfolioapproval42\".\"folioid\" = @qpfoFolioApproval_FolioId) AND (\"enfolioapproval42\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioApproval_FolioId", DbType.Int64, qpfoFolioApproval_FolioId);
} else {
whereBuilder.Append("(\"enfolioapproval42\".\"folioid\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"enfolioapprovallevel38\".\"levelnumber\" ASC ");
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
RL_c4a88225f641d9bcf04728601a4668b7 outParamList = new RL_c4a88225f641d9bcf04728601a4668b7();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFirstApprovalReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[5];
opt[0] = new BitArray(new bool[] {true, false, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, false, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.FolioSAE_Details.GetFirstApproval.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_c4a88225f641d9bcf04728601a4668b7 _tmp = new RL_c4a88225f641d9bcf04728601a4668b7();
_tmp.AlternateReadDbMethodAsync = datasetGetFirstApprovalReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.FolioSAE_Details.GetFirstApproval.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_c4a88225f641d9bcf04728601a4668b7)_tmp;
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

private static async Task<RC_619a3314c0f5e7503d1faa5bd2f55a41> datasetGetFolioByIdReadDbAsync(RC_619a3314c0f5e7503d1faa5bd2f55a41 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApprovalProcess.Read( r, ref index);
rec.ssENApprovalProcessType.Read( r, ref index);
rec.ssENCompany.Read( r, ref index);
rec.ssENCurrency.Read( r, ref index);
rec.ssENFolio.Read( r, ref index);
rec.ssENFolioApproval.Read( r, ref index);
rec.ssENFolioApprovalLevel.Read( r, ref index);
rec.ssENFolioStatus.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
rec.ssENUser_CreatedBy.Read( r, ref index);
rec.ssENUser_UpdatedBy.Read( r, ref index);
rec.ssDAYSOFCREATION = r.ReadInteger(index++, "ApprovalProcessCurrencyUser_CreatedByUser_UpdatedByFolioStatusFolioApprovalFolioFolioApprovalLevelOrderMainDAYSOFCREATIONCompanyApprovalProcessTypeSupplierRegionRecord.DAYSOFCREATION", 0);
return rec;
}
// Query Function "GetFolioById" Dgen709Vq0iviibAVeaJ3g of Action "FolioSAE_Details"
public static async Task<(RL_a73c6a3c39840602048be2cd6d699c01,long)> datasetGetFolioById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckAlmacenRole,bool qpboCheckDesviacionesRole,bool qpboCheckProveedorRole,bool qpboCheckUserSession,bool qpboGetIsCorporativo,string qpteEntraRolesListText,long qpenFolioApprovalLevel_EntraRoleId,string qpusGetUserId,long qpreGetUserRegionId,long qpapFolioApprovalLevel_ApplicationRoleId,long qpapFolioApprovalLevel_ApplicationRoleId1,long qpsuFolio_SupplierId,long qpfoFolio_Id,bool qpboi_IsDirectReport,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.FolioSAE_Details.GetFolioById", "efa7070e-554f-48ab-af8a-26c055e689de");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("FolioSAE_Details","j_FoliosSAE.FolioSAE_Details.GetFolioById");
// Query Iterations: Never
// Refresh Query DnYy5BFWzU6t7wR6PTXpbg Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree._HBBBoPGEEWB3rBNy9LnHg/ScreenDataSets.Dgen709Vq0iviibAVeaJ3g, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, \"enapprovalprocess51\".\"code\" o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, \"enapprovalprocesstype2\".\"id\" o19, NULL o20, \"enapprovalprocesstype2\".\"label_es\" o21, NULL o22, NULL o23, NULL o24, NULL o25, \"encompany62\".\"description\" o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, \"encurrency41\".\"code\" o35, \"encurrency41\".\"name\" o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, \"enfolio79\".\"folionumber\" o42, \"enfolio79\".\"canproveedorcancel\" o43, NULL o44, NULL o45, NULL o46, \"enfolio79\".\"foliostatusid\" o47, trim_scale(\"enfolio79\".\"totalamount\"::numeric) o48, trim_scale(\"enfolio79\".\"totaliva_amount\"::numeric) o49, NULL o50, NULL o51, NULL o52, \"enfolio79\".\"approvalprocesstypeid\" o53, NULL o54, NULL o55, \"enfolio79\".\"createdon\" o56, \"enfolio79\".\"updatedby\" o57, \"enfolio79\".\"updatedon\" o58, NULL o59, \"enfolioapproval43\".\"id\" o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, \"enfolioapprovallevel39\".\"id\" o70, NULL o71, \"enfolioapprovallevel39\".\"levelnumber\" o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, \"enfolioapprovallevel39\".\"isinvoiceapproval\" o89, \"enfoliostatus9\".\"id\" o90, \"enfoliostatus9\".\"label\" o91, \"enfoliostatus9\".\"class\" o92, NULL o93, NULL o94, NULL o95, NULL o96, \"enordermain122\".\"ordernumber\" o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, NULL o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, NULL o118, NULL o119, NULL o120, NULL o121, NULL o122, NULL o123, NULL o124, NULL o125, \"enregion174\".\"code\" o126, NULL o127, \"enregion174\".\"divisionfi\" o128, NULL o129, NULL o130, NULL o131, NULL o132, NULL o133, NULL o134, NULL o135, NULL o136, NULL o137, NULL o138, NULL o139, \"ensupplier127\".\"name\" o140, \"ensupplier127\".\"number\" o141, NULL o142, NULL o143, NULL o144, NULL o145, \"ensupplier127\".\"pais\" o146, NULL o147, NULL o148, NULL o149, NULL o150, NULL o151, NULL o152, NULL o153, NULL o154, \"ensupplier127\".\"n_ident_fis_1\" o155, NULL o156, NULL o157, NULL o158, NULL o159, NULL o160, NULL o161, NULL o162, NULL o163, NULL o164, NULL o165, NULL o166, \"enuser_createdby\".\"name\" o167, NULL o168, NULL o169, NULL o170, NULL o171, \"enuser_updatedby\".\"name\" o172, NULL o173, NULL o174, NULL o175, (date_part('day', cast((to_date(@qepCurrdate, 'YYYY-MM-DD')) as date)::timestamptz - cast(\"enfolio79\".\"createdon\" as date)::timestamptz)) \"daysofcreation\"");
fromBuilder.Append(" FROM (((((((((((({Folio} \"enfolio79\" Left JOIN {FolioStatus} \"enfoliostatus9\" ON (\"enfolio79\".\"foliostatusid\" = \"enfoliostatus9\".\"id\"))  Left JOIN {FolioApproval} \"enfolioapproval43\" ON (\"enfolio79\".\"id\" = \"enfolioapproval43\".\"folioid\"))  Left JOIN {FolioApprovalLevel} \"enfolioapprovallevel39\" ON (((\"enfolioapproval43\".\"id\" = \"enfolioapprovallevel39\".\"folioapprovalid\") AND ((CASE WHEN (\"enfolioapprovallevel39\".\"assignedto\" IS NOT NULL) THEN (CASE WHEN ");
sqlCmd.CreateParameterWithoutReplacements("@qepCurrdate", DbType.String, System.DateTime.UtcNow.ToString("yyyy-MM-dd"));
if ((qpusGetUserId.Trim()!="")) {
fromBuilder.Append("((\"enfolioapprovallevel39\".\"assignedto\" = @qpusGetUserId) AND (\"enfolioapprovallevel39\".\"assignedto\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
fromBuilder.Append("(\"enfolioapprovallevel39\".\"assignedto\" IS NULL)");
}
fromBuilder.Append(" THEN 1 ELSE 0 END) ELSE (CASE WHEN (((((");
if ((qpusGetUserId.Trim()!="")) {
fromBuilder.Append("((\"enfolioapprovallevel39\".\"approvedby\" = @qpusGetUserId) AND (\"enfolioapprovallevel39\".\"approvedby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
fromBuilder.Append("(\"enfolioapprovallevel39\".\"approvedby\" IS NULL)");
}
fromBuilder.Append(" OR ");
if ((qpusGetUserId.Trim()!="")) {
fromBuilder.Append("((\"enfolioapprovallevel39\".\"canceledby\" = @qpusGetUserId) AND (\"enfolioapprovallevel39\".\"canceledby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
fromBuilder.Append("(\"enfolioapprovallevel39\".\"canceledby\" IS NULL)");
}
fromBuilder.Append(") OR ");
if ((qpusGetUserId.Trim()!="")) {
fromBuilder.Append("((\"enfolioapprovallevel39\".\"rejectedby\" = @qpusGetUserId) AND (\"enfolioapprovallevel39\".\"rejectedby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
fromBuilder.Append("(\"enfolioapprovallevel39\".\"rejectedby\" IS NULL)");
}
fromBuilder.Append(") OR ");
if (qpapFolioApprovalLevel_ApplicationRoleId != 0) {
fromBuilder.Append("((\"enfolioapprovallevel39\".\"applicationroleid\" = @qpapFolioApprovalLevel_ApplicationRoleId) AND (\"enfolioapprovallevel39\".\"applicationroleid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpapFolioApprovalLevel_ApplicationRoleId", DbType.Int64, qpapFolioApprovalLevel_ApplicationRoleId);
} else {
fromBuilder.Append("(\"enfolioapprovallevel39\".\"applicationroleid\" IS NULL)");
}
fromBuilder.Append(") OR ");
if (qpenFolioApprovalLevel_EntraRoleId != 0) {
fromBuilder.Append("((\"enfolioapprovallevel39\".\"entraroleid\" = @qpenFolioApprovalLevel_EntraRoleId) AND (\"enfolioapprovallevel39\".\"entraroleid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpenFolioApprovalLevel_EntraRoleId", DbType.Int64, qpenFolioApprovalLevel_EntraRoleId);
} else {
fromBuilder.Append("(\"enfolioapprovallevel39\".\"entraroleid\" IS NULL)");
}
fromBuilder.Append(") OR (((CASE WHEN char_length(caseaccent_normalize(cast(\"enfolioapprovallevel39\".\"entraroleid\" as text) collate \"default\"))=0 THEN -1 ELSE (position(caseaccent_normalize(cast(\"enfolioapprovallevel39\".\"entraroleid\" as text) collate \"default\") in caseaccent_normalize(@qpteEntraRolesListText collate \"default\"))-1) END)) <> (-1))) THEN 1 ELSE 0 END) END) = 1)) AND ((((((\"enfolioapprovallevel39\".\"approvalstatusid\" = ");
fromBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId);
fromBuilder.Append(") OR (\"enfolioapprovallevel39\".\"approvalstatusid\" = ");
fromBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("rkrV30n0cEiW8dttOKG0gw"))).ssId);
fromBuilder.Append(")) OR (\"enfolioapprovallevel39\".\"approvalstatusid\" = ");
fromBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("YBJlnXS8SkKRSq9aruxhkg"))).ssId);
fromBuilder.Append(")) OR (\"enfolioapprovallevel39\".\"approvalstatusid\" = ");
fromBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("rm4bAZ7dOEqgMcZKM9wLxg"))).ssId);
fromBuilder.Append(")) OR (\"enfolioapprovallevel39\".\"approvalstatusid\" = ");
fromBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("w+wMayzP1kit5Zcgfd05+g"))).ssId);
fromBuilder.Append(")) OR (\"enfolioapprovallevel39\".\"approvalstatusid\" = ");
fromBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("RvhtMOVzUke_jX9z3pm9HA"))).ssId);
fromBuilder.Append("))))  Left JOIN {User} \"enuser_createdby\" ON (\"enfolio79\".\"createdby\" = \"enuser_createdby\".\"id\"))  Left JOIN {User} \"enuser_updatedby\" ON (\"enfolio79\".\"updatedby\" = \"enuser_updatedby\".\"id\"))  Left JOIN {OrderMain} \"enordermain122\" ON (\"enfolio79\".\"orderid\" = \"enordermain122\".\"id\"))  Left JOIN {Company} \"encompany62\" ON (\"enfolio79\".\"companyid\" = \"encompany62\".\"id\"))  Left JOIN {Supplier} \"ensupplier127\" ON (\"enfolio79\".\"supplierid\" = \"ensupplier127\".\"id\"))  Left JOIN {Currency} \"encurrency41\" ON (\"enfolio79\".\"currencyid\" = \"encurrency41\".\"code\"))  Left JOIN {Region} \"enregion174\" ON (\"enordermain122\".\"regionid\" = \"enregion174\".\"id\"))  Left JOIN {ApprovalProcessType} \"enapprovalprocesstype2\" ON (\"enfolio79\".\"approvalprocesstypeid\" = \"enapprovalprocesstype2\".\"id\"))  Left JOIN {ApprovalProcess} \"enapprovalprocess51\" ON (\"enfolioapproval43\".\"approvalprocessid\" = \"enapprovalprocess51\".\"id\")) ");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteEntraRolesListText", DbType.String, qpteEntraRolesListText);
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qpfoFolio_Id != 0) {
whereBuilder.Append("((\"enfolio79\".\"id\" = @qpfoFolio_Id) AND (\"enfolio79\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolio_Id", DbType.Int64, qpfoFolio_Id);
} else {
whereBuilder.Append("(\"enfolio79\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ((CASE WHEN (@qpboCheckProveedorRole = 1) THEN (CASE WHEN (");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckProveedorRole", DbType.Boolean, qpboCheckProveedorRole);
if (qpsuFolio_SupplierId != 0) {
whereBuilder.Append("((\"enfolio79\".\"supplierid\" = @qpsuFolio_SupplierId) AND (\"enfolio79\".\"supplierid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuFolio_SupplierId", DbType.Int64, qpsuFolio_SupplierId);
} else {
whereBuilder.Append("(\"enfolio79\".\"supplierid\" IS NULL)");
}
whereBuilder.Append(" AND (@qpsuFolio_SupplierId <> 0)) THEN 1 ELSE 0 END) ELSE (CASE WHEN (((@qpboCheckDesviacionesRole = 1) OR (@qpboi_IsDirectReport = 1)) OR (@qpboCheckAlmacenRole = 1)) THEN 1 ELSE (CASE WHEN ((\"enfolioapprovallevel39\".\"approvalstatusid\" <> ");
whereBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("fEmjvBqEH0eHrf5_YVeo0g"))).ssId);
whereBuilder.Append(") AND (((((CASE WHEN (\"enfolioapprovallevel39\".\"assignedto\" IS NOT NULL) THEN (CASE WHEN ");
sqlCmd.CreateParameterWithoutReplacements("@qpsuFolio_SupplierId", DbType.Int64, qpsuFolio_SupplierId);
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckDesviacionesRole", DbType.Boolean, qpboCheckDesviacionesRole);
sqlCmd.CreateParameterWithoutReplacements("@qpboi_IsDirectReport", DbType.Boolean, qpboi_IsDirectReport);
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckAlmacenRole", DbType.Boolean, qpboCheckAlmacenRole);
if ((qpusGetUserId.Trim()!="")) {
whereBuilder.Append("((\"enfolioapprovallevel39\".\"assignedto\" = @qpusGetUserId) AND (\"enfolioapprovallevel39\".\"assignedto\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
whereBuilder.Append("(\"enfolioapprovallevel39\".\"assignedto\" IS NULL)");
}
whereBuilder.Append(" THEN 1 ELSE 0 END) ELSE (CASE WHEN (((");
if (qpapFolioApprovalLevel_ApplicationRoleId1 != 0) {
whereBuilder.Append("((\"enfolioapprovallevel39\".\"applicationroleid\" = @qpapFolioApprovalLevel_ApplicationRoleId1) AND (\"enfolioapprovallevel39\".\"applicationroleid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpapFolioApprovalLevel_ApplicationRoleId1", DbType.Int64, qpapFolioApprovalLevel_ApplicationRoleId1);
} else {
whereBuilder.Append("(\"enfolioapprovallevel39\".\"applicationroleid\" IS NULL)");
}
whereBuilder.Append(" OR ");
if (qpenFolioApprovalLevel_EntraRoleId != 0) {
whereBuilder.Append("((\"enfolioapprovallevel39\".\"entraroleid\" = @qpenFolioApprovalLevel_EntraRoleId) AND (\"enfolioapprovallevel39\".\"entraroleid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpenFolioApprovalLevel_EntraRoleId", DbType.Int64, qpenFolioApprovalLevel_EntraRoleId);
} else {
whereBuilder.Append("(\"enfolioapprovallevel39\".\"entraroleid\" IS NULL)");
}
whereBuilder.Append(") OR (((CASE WHEN char_length(caseaccent_normalize(cast(\"enfolioapprovallevel39\".\"entraroleid\" as text) collate \"default\"))=0 THEN -1 ELSE (position(caseaccent_normalize(cast(\"enfolioapprovallevel39\".\"entraroleid\" as text) collate \"default\") in caseaccent_normalize(@qpteEntraRolesListText collate \"default\"))-1) END)) <> (-1))) AND ((");
sqlCmd.CreateParameterWithoutReplacements("@qpteEntraRolesListText", DbType.String, qpteEntraRolesListText);
if (qpreGetUserRegionId != 0) {
whereBuilder.Append("((\"enordermain122\".\"divisionid\" = @qpreGetUserRegionId) AND (\"enordermain122\".\"divisionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
} else {
whereBuilder.Append("(\"enordermain122\".\"divisionid\" IS NULL)");
}
whereBuilder.Append(" OR ");
if (qpreGetUserRegionId != 0) {
whereBuilder.Append("((\"enfolioapproval43\".\"regionid\" = @qpreGetUserRegionId) AND (\"enfolioapproval43\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
} else {
whereBuilder.Append("(\"enfolioapproval43\".\"regionid\" IS NULL)");
}
whereBuilder.Append(") OR (@qpboGetIsCorporativo = 1))) THEN 1 ELSE 0 END) END) = 1) OR ");
sqlCmd.CreateParameterWithoutReplacements("@qpboGetIsCorporativo", DbType.Boolean, qpboGetIsCorporativo);
if ((qpusGetUserId.Trim()!="")) {
whereBuilder.Append("((\"enfolioapprovallevel39\".\"approvedby\" = @qpusGetUserId) AND (\"enfolioapprovallevel39\".\"approvedby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
whereBuilder.Append("(\"enfolioapprovallevel39\".\"approvedby\" IS NULL)");
}
whereBuilder.Append(") OR ");
if ((qpusGetUserId.Trim()!="")) {
whereBuilder.Append("((\"enfolioapprovallevel39\".\"rejectedby\" = @qpusGetUserId) AND (\"enfolioapprovallevel39\".\"rejectedby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
whereBuilder.Append("(\"enfolioapprovallevel39\".\"rejectedby\" IS NULL)");
}
whereBuilder.Append(") OR ");
if ((qpusGetUserId.Trim()!="")) {
whereBuilder.Append("((\"enfolioapprovallevel39\".\"canceledby\" = @qpusGetUserId) AND (\"enfolioapprovallevel39\".\"canceledby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
whereBuilder.Append("(\"enfolioapprovallevel39\".\"canceledby\" IS NULL)");
}
whereBuilder.Append(")) THEN 1 ELSE 0 END) END) END) = 1)");
orderByBuilder.Append(" ORDER BY \"enfolioapprovallevel39\".\"levelnumber\" DESC ");
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
RL_a73c6a3c39840602048be2cd6d699c01 outParamList = new RL_a73c6a3c39840602048be2cd6d699c01();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFolioByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[13];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {false, false, true, true, true});
opt[2] = new BitArray(new bool[] {true, false, true, true, true});
opt[3] = new BitArray(new bool[] {true, false, true, true, true});
opt[4] = new BitArray(new bool[] {false, false, false, true, true, true});
opt[5] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true});
opt[6] = new BitArray(new bool[] {true, true, false, false, true, true, true, false, false, false, true, true, true, false, true, true, false, false, false, true});
opt[7] = new BitArray(new bool[] {false, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false});
opt[8] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[9] = new BitArray(new bool[] {true, true, false, true, true, true, true, true, true, true, true});
opt[10] = new BitArray(new bool[] {false, true, false, true, true});
opt[11] = new BitArray(new bool[] {true, true, false, false, true, true, true, true, false, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true});
opt[12] = new BitArray(new bool[] {true, false, true, false, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.FolioSAE_Details.GetFolioById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_a73c6a3c39840602048be2cd6d699c01 _tmp = new RL_a73c6a3c39840602048be2cd6d699c01();
_tmp.AlternateReadDbMethodAsync = datasetGetFolioByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.FolioSAE_Details.GetFolioById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_a73c6a3c39840602048be2cd6d699c01)_tmp;
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


    public class lcvGetUserApplicationRoles : VarsBag {
public RL_721bdfcca4a4edbce82baece8dfe837b queryResGetRoleConcept_outParamList = new RL_721bdfcca4a4edbce82baece8dfe837b();
public long queryResGetRoleConcept_outParamCount = 0L;

public RL_87311ea350338b4dcd53388d23fa3f86 queryResGetUserApplicationRoleTempActive_outParamList = new RL_87311ea350338b4dcd53388d23fa3f86();
public long queryResGetUserApplicationRoleTempActive_outParamCount = 0L;

public lcvGetUserApplicationRoles() {
}
}
public class lcoGetUserApplicationRoles : VarsBag {
public RL_97ac86b141c7934fd96d3cf71793066e outParamUserRolesList = new RL_97ac86b141c7934fd96d3cf71793066e();

public string outParamAppRoleListText = "";

public string outParamEntraRolesListText = "";

public bool outParamIsActiveDEV_DisenoUI = false;

public lcoGetUserApplicationRoles() {
}
}
/// <summary>
/// Action <code>GetUserApplicationRoles</code> that represents the Service Studio action
///  <code>GetUserApplicationRoles</code> <p> Description: </p>
/// </summary>
public async Task<(RL_97ac86b141c7934fd96d3cf71793066e,string,string,bool)> DataActionGetUserApplicationRoles(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_97ac86b141c7934fd96d3cf71793066e outParamUserRolesList = default;
string outParamAppRoleListText = default;
string outParamEntraRolesListText = default;
bool outParamIsActiveDEV_DisenoUI = default;
lcoGetUserApplicationRoles result = new lcoGetUserApplicationRoles();
lcvGetUserApplicationRoles localVars = new lcvGetUserApplicationRoles();
ConectaProveedores_j_FoliosSAE_FolioSAE_Details_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetUserApplicationRoles", "4dc77fdd-f11b-4e1e-a1f6-89cae004f70a"))
using (activitySource.CreateScreenDataActionActivity("FolioSAE_Details", "GetUserApplicationRoles")){
if((!((await Functions.ssCheckProveedorRole(requestContext,"",cancellationToken))))) {
// Query datasetGetRoleConcept
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRoleConcept_maxRecords = 0;
int datasetGetRoleConcept_startIndex = 0;(localVars.queryResGetRoleConcept_outParamList,localVars.queryResGetRoleConcept_outParamCount) = await FuncDataActionGetUserApplicationRoles.datasetGetRoleConcept(requestContext,datasetGetRoleConcept_maxRecords,datasetGetRoleConcept_startIndex,IterationMultiplicity.Multiple,BuiltInFunction.GetUserId (),cancellationToken);

// Query datasetGetUserApplicationRoleTempActive
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserApplicationRoleTempActive_maxRecords = 0;
int datasetGetUserApplicationRoleTempActive_startIndex = 0;(localVars.queryResGetUserApplicationRoleTempActive_outParamList,localVars.queryResGetUserApplicationRoleTempActive_outParamCount) = await FuncDataActionGetUserApplicationRoles.datasetGetUserApplicationRoleTempActive(requestContext,datasetGetUserApplicationRoleTempActive_maxRecords,datasetGetUserApplicationRoleTempActive_startIndex,IterationMultiplicity.Single,BuiltInFunction.GetUserId (),cancellationToken);

// UserRolesList = GetRoleConcept.List
result.outParamUserRolesList=(await RL_97ac86b141c7934fd96d3cf71793066e.ConvertAsync(localVars.queryResGetRoleConcept_outParamList, new RL_97ac86b141c7934fd96d3cf71793066e(), async (RC_6d4a92ad9e5239e9c12dd070f5b17d69 source, ST_e39617f0f094a322d4157f34fe424dadStructure target, CancellationToken cancellationToken) => {
target.ssApplicationRoleId = source.ssENRoleConcept.ssApplicationRoleId;
target.ssRoleName = source.ssENApplicationRole.ssName;
target.ssCode = source.ssENApplicationRole.ssCode;
target.ssIsSubstitute = false;
return target;
}, cancellationToken));
// Foreach GetRoleConcept.List
localVars.queryResGetRoleConcept_outParamList.StartIteration();
try {while (!((localVars.queryResGetRoleConcept_outParamList.Eof))) {
// AppRoleListText = AppRoleListText + "," + GetRoleConcept.List.Current.RoleConcept.ApplicationRoleId
result.outParamAppRoleListText=((result.outParamAppRoleListText+",")+BuiltInFunction.LongIntegerToText(localVars.queryResGetRoleConcept_outParamList.CurrentRec.ssENRoleConcept.ssApplicationRoleId));

// EntraRolesListText = EntraRolesListText + "," + GetRoleConcept.List.Current.User_Extended_Internal.EntraRoleId
result.outParamEntraRolesListText=((result.outParamEntraRolesListText+",")+BuiltInFunction.LongIntegerToText(localVars.queryResGetRoleConcept_outParamList.CurrentRec.ssENUser_Extended_Internal.ssEntraRoleId));
localVars.queryResGetRoleConcept_outParamList.Advance();
}

} finally {
localVars.queryResGetRoleConcept_outParamList.EndIteration();
}

// Foreach GetUserApplicationRoleTempActive.List
localVars.queryResGetUserApplicationRoleTempActive_outParamList.StartIteration();
try {while (!((localVars.queryResGetUserApplicationRoleTempActive_outParamList.Eof))) {
// EntraRolesListText = EntraRolesListText + "," + GetUserApplicationRoleTempActive.List.Current.UserApplicationRoleTemp.EntraRoleId
result.outParamEntraRolesListText=((result.outParamEntraRolesListText+",")+BuiltInFunction.LongIntegerToText(localVars.queryResGetUserApplicationRoleTempActive_outParamList.CurrentRec.ssENUserApplicationRoleTemp.ssEntraRoleId));
localVars.queryResGetUserApplicationRoleTempActive_outParamList.Advance();
}

} finally {
localVars.queryResGetUserApplicationRoleTempActive_outParamList.EndIteration();
}

// IsActiveDEV_DisenoUI = IsActiveDEV_DisenoUI
result.outParamIsActiveDEV_DisenoUI=((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveDEV_DisenoUI])));
}

} //close CreateActionActivity using block
} // try

finally {
outParamUserRolesList = result.outParamUserRolesList;
outParamAppRoleListText = result.outParamAppRoleListText;
outParamEntraRolesListText = result.outParamEntraRolesListText;
outParamIsActiveDEV_DisenoUI = result.outParamIsActiveDEV_DisenoUI;
} // inner-finally
RETURN_STATEMENT:
return (outParamUserRolesList,outParamAppRoleListText,outParamEntraRolesListText,outParamIsActiveDEV_DisenoUI);
}
public class lcvGetRejectComment : VarsBag {
public RL_29173c8e71b738f340ed8a29f378afba queryResGetFolioCommentReject_outParamList = new RL_29173c8e71b738f340ed8a29f378afba();
public long queryResGetFolioCommentReject_outParamCount = 0L;

public lcvGetRejectComment() {
}
}
public class lcoGetRejectComment : VarsBag {
public string outParamRejectCommentText = "";

public lcoGetRejectComment() {
}
}
/// <summary>
/// Action <code>GetRejectComment</code> that represents the Service Studio action
///  <code>GetRejectComment</code> <p> Description: </p>
/// </summary>
public async Task<string> DataActionGetRejectComment(IRequestContext requestContext,CancellationToken cancellationToken) {
string outParamRejectCommentText = default;
lcoGetRejectComment result = new lcoGetRejectComment();
lcvGetRejectComment localVars = new lcvGetRejectComment();
ConectaProveedores_j_FoliosSAE_FolioSAE_Details_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetRejectComment", "b00b2ce9-6aef-426a-9cca-badf6ad0cc53"))
using (activitySource.CreateScreenDataActionActivity("FolioSAE_Details", "GetRejectComment")){
// Query datasetGetFolioCommentReject
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioCommentReject_maxRecords = 1;
if (datasetGetFolioCommentReject_maxRecords < 1) datasetGetFolioCommentReject_maxRecords = 1;
int datasetGetFolioCommentReject_startIndex = 0;(localVars.queryResGetFolioCommentReject_outParamList,localVars.queryResGetFolioCommentReject_outParamCount) = await FuncDataActionGetRejectComment.datasetGetFolioCommentReject(requestContext,datasetGetFolioCommentReject_maxRecords,datasetGetFolioCommentReject_startIndex,IterationMultiplicity.Never,ScreenDataSetGetFolioById.List.CurrentRec.ssENFolioApproval.ssId,ScreenDataSetGetFolioById.List.CurrentRec.ssENFolioApprovalLevel.ssId,ScreenDataSetGetFolioById.List.CurrentRec.ssENFolioApprovalLevel.ssLevelNumber,cancellationToken);

// RejectCommentText = GetFolioCommentReject.List.Current.FolioComment.Message
result.outParamRejectCommentText=localVars.queryResGetFolioCommentReject_outParamList.CurrentRec.ssENFolioComment.ssMessage;
} //close CreateActionActivity using block
} // try

finally {
outParamRejectCommentText = result.outParamRejectCommentText;
} // inner-finally
RETURN_STATEMENT:
return outParamRejectCommentText;
}
public class lcvGetFolioApprovalDisplay : VarsBag {
public RL_be474dab9f20512d09fda3e1e99c2e25 queryResGetLevels_outParamList = new RL_be474dab9f20512d09fda3e1e99c2e25();
public long queryResGetLevels_outParamCount = 0L;

public lcvGetFolioApprovalDisplay() {
}
}
public class lcoGetFolioApprovalDisplay : VarsBag {
public RL_875afe918a46d044315dbe3410f1f2a7 outParamFolioApprovalDisplayList = new RL_875afe918a46d044315dbe3410f1f2a7();

public lcoGetFolioApprovalDisplay() {
}
}
/// <summary>
/// Action <code>GetFolioApprovalDisplay</code> that represents the Service Studio action
///  <code>GetFolioApprovalDisplay</code> <p> Description: </p>
/// </summary>
public async Task<RL_875afe918a46d044315dbe3410f1f2a7> DataActionGetFolioApprovalDisplay(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_875afe918a46d044315dbe3410f1f2a7 outParamFolioApprovalDisplayList = default;
lcoGetFolioApprovalDisplay result = new lcoGetFolioApprovalDisplay();
lcvGetFolioApprovalDisplay localVars = new lcvGetFolioApprovalDisplay();
ConectaProveedores_j_FoliosSAE_FolioSAE_Details_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetFolioApprovalDisplay", "c4bcd284-74ef-4e07-b256-27ec024d655a"))
using (activitySource.CreateScreenDataActionActivity("FolioSAE_Details", "GetFolioApprovalDisplay")){
// Query QueryGetLevels
cancellationToken.ThrowIfCancellationRequested();
int QueryGetLevels_maxRecords = 0;
int QueryGetLevels_startIndex = 0;(localVars.queryResGetLevels_outParamList,localVars.queryResGetLevels_outParamCount) = await FuncDataActionGetFolioApprovalDisplay.QueryGetLevels(requestContext,QueryGetLevels_maxRecords,QueryGetLevels_startIndex,IterationMultiplicity.Multiple,(ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("fEmjvBqEH0eHrf5_YVeo0g"))).ssId,ScreenDataSetGetFolioById.List.CurrentRec.ssENFolioApproval.ssId,cancellationToken);

// FolioApprovalDisplayList = GetLevels.List
result.outParamFolioApprovalDisplayList=(await RL_875afe918a46d044315dbe3410f1f2a7.ConvertAsync(localVars.queryResGetLevels_outParamList, new RL_875afe918a46d044315dbe3410f1f2a7(), async (RC_a7c2cd770dc9e2fc3e0bdfd2d99a38b8 source, ST_3c480a6d17a69eed60b057b7ed343a1dStructure target, CancellationToken cancellationToken) => {
target = source;
return target;
}, cancellationToken));
} //close CreateActionActivity using block
} // try

finally {
outParamFolioApprovalDisplayList = result.outParamFolioApprovalDisplayList;
} // inner-finally
RETURN_STATEMENT:
return outParamFolioApprovalDisplayList;
}


    public static class FuncDataActionGetUserApplicationRoles {

private static async Task<RC_6d4a92ad9e5239e9c12dd070f5b17d69> datasetGetRoleConceptReadDbAsync(RC_6d4a92ad9e5239e9c12dd070f5b17d69 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApplicationRole.Read( r, ref index);
rec.ssENEntraRole.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENRoleConcept.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
return rec;
}
// Query Function "GetRoleConcept" Kf47VtJZCU2Qlv+4zi8ssw of Action "GetUserApplicationRoles"
public static async Task<(RL_721bdfcca4a4edbce82baece8dfe837b,long)> datasetGetRoleConcept(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("j_FoliosSAE.FolioSAE_Details.GetUserApplicationRoles.GetRoleConcept", "563bfe29-59d2-4d09-9096-ffb8ce2f2cb3");
using var queryActivity = activitySource.CreateAggregateQueryActivity("j_FoliosSAE.FolioSAE_Details.GetUserApplicationRoles.GetRoleConcept", "563bfe29-59d2-4d09-9096-ffb8ce2f2cb3", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree._HBBBoPGEEWB3rBNy9LnHg/DataActions.3X_HTRvxHk6h9onK4AT3Cg/NodesNotShownInESpaceTree.Kf47VtJZCU2Qlv+4zi8ssw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enapplicationrole85\".\"code\" o1, \"enapplicationrole85\".\"name\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, \"enroleconcept33\".\"applicationroleid\" o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, \"enuser_extended_internal133\".\"entraroleid\" o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54");
fromBuilder.Append(" FROM ((((({User_Extended_Internal} \"enuser_extended_internal133\" Inner JOIN {User} \"enuser225\" ON (\"enuser_extended_internal133\".\"id\" = \"enuser225\".\"id\"))  Inner JOIN {EntraRole} \"enentrarole79\" ON (\"enuser_extended_internal133\".\"jobtitle\" = \"enentrarole79\".\"rolename\"))  Left JOIN {Region} \"enregion175\" ON (\"enuser_extended_internal133\".\"regionid\" = \"enregion175\".\"id\"))  Left JOIN {RoleConcept} \"enroleconcept33\" ON (\"enentrarole79\".\"id\" = \"enroleconcept33\".\"entraroleid\"))  Left JOIN {ApplicationRole} \"enapplicationrole85\" ON (\"enroleconcept33\".\"applicationroleid\" = \"enapplicationrole85\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser225\".\"id\" = @qpusUser_Id) AND (\"enuser225\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser225\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (\"enroleconcept33\".\"conceptid\" = ");
whereBuilder.Append(2
);
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
RL_721bdfcca4a4edbce82baece8dfe837b outParamList = new RL_721bdfcca4a4edbce82baece8dfe837b();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetRoleConceptReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[6];
opt[0] = new BitArray(new bool[] {true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true});
opt[2] = new BitArray(new bool[] {true, false, false, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.FolioSAE_Details.GetUserApplicationRoles.GetRoleConcept.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_721bdfcca4a4edbce82baece8dfe837b _tmp = new RL_721bdfcca4a4edbce82baece8dfe837b();
_tmp.AlternateReadDbMethodAsync = datasetGetRoleConceptReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.FolioSAE_Details.GetUserApplicationRoles.GetRoleConcept.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_721bdfcca4a4edbce82baece8dfe837b)_tmp;
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

// Query Function "GetUserApplicationRoleTempActive" By9Qo1Z0s0KJcNYmGo_JeQ of Action "GetUserApplicationRoles"
public static async Task<(RL_87311ea350338b4dcd53388d23fa3f86,long)> datasetGetUserApplicationRoleTempActive(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUserId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("j_FoliosSAE.FolioSAE_Details.GetUserApplicationRoles.GetUserApplicationRoleTempActive", "a3502f07-7456-42b3-8970-d6261a8fc979");
using var queryActivity = activitySource.CreateAggregateQueryActivity("j_FoliosSAE.FolioSAE_Details.GetUserApplicationRoles.GetUserApplicationRoleTempActive", "a3502f07-7456-42b3-8970-d6261a8fc979", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Single
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree._HBBBoPGEEWB3rBNy9LnHg/DataActions.3X_HTRvxHk6h9onK4AT3Cg/NodesNotShownInESpaceTree.By9Qo1Z0s0KJcNYmGo_JeQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, \"enuserapplicationroletemp13\".\"entraroleid\" o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13");
fromBuilder.Append(" FROM {UserApplicationRoleTemp} \"enuserapplicationroletemp13\"");
whereBuilder.Append(" WHERE ");
if ((qpusUserId.Trim()!="")) {
whereBuilder.Append("((\"enuserapplicationroletemp13\".\"userid\" = @qpusUserId) AND (\"enuserapplicationroletemp13\".\"userid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUserId", DbType.String, qpusUserId);
} else {
whereBuilder.Append("(\"enuserapplicationroletemp13\".\"userid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enuserapplicationroletemp13\".\"rolestatusid\" = ");
whereBuilder.Append(2
);
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
RL_87311ea350338b4dcd53388d23fa3f86 outParamList = new RL_87311ea350338b4dcd53388d23fa3f86();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.FolioSAE_Details.GetUserApplicationRoles.GetUserApplicationRoleTempActive.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_87311ea350338b4dcd53388d23fa3f86 _tmp = new RL_87311ea350338b4dcd53388d23fa3f86();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.FolioSAE_Details.GetUserApplicationRoles.GetUserApplicationRoleTempActive.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_87311ea350338b4dcd53388d23fa3f86)_tmp;
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
public static class FuncDataActionGetRejectComment {

private static async Task<RC_9af5a4e48bf7682fd78edcb92b1adec9> datasetGetFolioCommentRejectReadDbAsync(RC_9af5a4e48bf7682fd78edcb92b1adec9 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolioApproval.Read( r, ref index);
rec.ssENFolioApprovalLevel.Read( r, ref index);
rec.ssENFolioComment.Read( r, ref index);
return rec;
}
// Query Function "GetFolioCommentReject" kcpxInASd0CBzKvfmM_NoA of Action "GetRejectComment"
public static async Task<(RL_29173c8e71b738f340ed8a29f378afba,long)> datasetGetFolioCommentReject(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolioApproval_Id,long qpfoFolioComment_FolioApprovalLevelId,int qpinLevelNumber,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("j_FoliosSAE.FolioSAE_Details.GetRejectComment.GetFolioCommentReject", "2271ca91-1270-4077-81cc-abdf98cfcda0");
using var queryActivity = activitySource.CreateAggregateQueryActivity("j_FoliosSAE.FolioSAE_Details.GetRejectComment.GetFolioCommentReject", "2271ca91-1270-4077-81cc-abdf98cfcda0", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree._HBBBoPGEEWB3rBNy9LnHg/DataActions.6SwLsO9qakKcyrrfatDMUw/NodesNotShownInESpaceTree.kcpxInASd0CBzKvfmM_NoA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38");
fromBuilder.Append(" FROM (({FolioApprovalLevel} \"enfolioapprovallevel40\" Left JOIN {FolioApproval} \"enfolioapproval44\" ON (\"enfolioapprovallevel40\".\"folioapprovalid\" = \"enfolioapproval44\".\"id\"))  Left JOIN {FolioComment} \"enfoliocomment\" ON (\"enfolioapprovallevel40\".\"id\" = \"enfoliocomment\".\"folioapprovallevelid\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoFolioApproval_Id != 0) {
whereBuilder.Append("((\"enfolioapproval44\".\"id\" = @qpfoFolioApproval_Id) AND (\"enfolioapproval44\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioApproval_Id", DbType.Int64, qpfoFolioApproval_Id);
} else {
whereBuilder.Append("(\"enfolioapproval44\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ((\"enfolioapprovallevel40\".\"levelnumber\" > @qpinLevelNumber) OR (");
sqlCmd.CreateParameterWithoutReplacements("@qpinLevelNumber", DbType.Int32, qpinLevelNumber);
if (qpfoFolioComment_FolioApprovalLevelId != 0) {
whereBuilder.Append("((\"enfoliocomment\".\"folioapprovallevelid\" = @qpfoFolioComment_FolioApprovalLevelId) AND (\"enfoliocomment\".\"folioapprovallevelid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioComment_FolioApprovalLevelId", DbType.Int64, qpfoFolioComment_FolioApprovalLevelId);
} else {
whereBuilder.Append("(\"enfoliocomment\".\"folioapprovallevelid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enfolioapprovallevel40\".\"approvalstatusid\" = ");
whereBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("rm4bAZ7dOEqgMcZKM9wLxg"))).ssId);
whereBuilder.Append(")))");
orderByBuilder.Append(" ORDER BY \"enfolioapprovallevel40\".\"levelnumber\" ASC , \"enfoliocomment\".\"id\" DESC ");
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
RL_29173c8e71b738f340ed8a29f378afba outParamList = new RL_29173c8e71b738f340ed8a29f378afba();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFolioCommentRejectReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.FolioSAE_Details.GetRejectComment.GetFolioCommentReject.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_29173c8e71b738f340ed8a29f378afba _tmp = new RL_29173c8e71b738f340ed8a29f378afba();
_tmp.AlternateReadDbMethodAsync = datasetGetFolioCommentRejectReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.FolioSAE_Details.GetRejectComment.GetFolioCommentReject.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_29173c8e71b738f340ed8a29f378afba)_tmp;
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
public static class FuncDataActionGetFolioApprovalDisplay {

// Query Function "GetLevels" 77Yqq1kCvE+cRgSNNEpDEQ of Action "GetFolioApprovalDisplay"
public static async Task<(RL_be474dab9f20512d09fda3e1e99c2e25,long)> QueryGetLevels(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,int qpapPendingApprovalStatus,long qpfoFolioApprovalId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("j_FoliosSAE.FolioSAE_Details.GetFolioApprovalDisplay.GetLevels", "ab2ab6ef-0259-4fbc-9c46-048d344a4311");
using var queryActivity = activitySource.CreateSqlQueryActivity("j_FoliosSAE.FolioSAE_Details.GetFolioApprovalDisplay.GetLevels", "ab2ab6ef-0259-4fbc-9c46-048d344a4311", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string entityFolioApprovalLevel = AppUtils.Instance.RuntimeEntityReplace("FolioApprovalLevel");
string entityUser = AppUtils.Instance.RuntimeEntityReplace("User");
sqlCmd.CreateParameter("@qpfoFolioApprovalId", DbType.Int64, qpfoFolioApprovalId);
sqlCmd.CreateParameter("@qpapPendingApprovalStatus", DbType.Int32, qpapPendingApprovalStatus);
string sql = "";
string advSql = "SELECT  \n    FAL.\"levelnumber\", \n    FAL.\"approvalstatusid\", \n    COALESCE(U.\"name\", 'Sin asignación') AS \"name\", \n    STRING_AGG( \n        COALESCE(NULLIF(FAL.\"entrajobtitle\", ''), 'Sin puesto'),  \n        ' | '  \n        ORDER BY FAL.\"entrajobtitle\" \n    ) AS \"combinedjobtitles\", \n    '', \n    0, \n    FAL.\"issubstitutefor\" \nFROM  \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioApprovalLevel,"") + " AS FAL \nLEFT JOIN  \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,"") + " AS U ON FAL.\"assignedto\" = U.\"id\" \nWHERE  \n    FAL.\"folioapprovalid\" = @qpfoFolioApprovalId AND \n    FAL.\"approvalstatusid\" <> @qpapPendingApprovalStatus \nGROUP BY  \n    FAL.\"levelnumber\",  \n    FAL.\"approvalstatusid\", \n    U.\"name\", \n    FAL.\"issubstitutefor\" \nORDER BY  \n    FAL.\"levelnumber\" ASC;";
sql = advSql;
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_be474dab9f20512d09fda3e1e99c2e25 outParamList = new RL_be474dab9f20512d09fda3e1e99c2e25();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.FolioSAE_Details.GetFolioApprovalDisplay.GetLevels.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_be474dab9f20512d09fda3e1e99c2e25 _tmp = new RL_be474dab9f20512d09fda3e1e99c2e25();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.FolioSAE_Details.GetFolioApprovalDisplay.GetLevels.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_be474dab9f20512d09fda3e1e99c2e25)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetLevels in GetFolioApprovalDisplay in FolioSAE_Details in j_FoliosSAE in ConectaProveedores (SELECT       FAL.[LevelNumber],      FAL.[ApprovalStatusId],      COALESCE(U.[Name], 'Sin asignación') AS [Name],      STRING_AGG(          COALESCE(NULLIF(FAL.[EntraJobTitle], ''), 'Sin puesto'),           ' | '           ORDER BY FAL.[EntraJobTitle]      ) AS [CombinedJobTitles],      '',      0,      FAL.[IsSubstituteFor]  FROM       {FolioApprovalLevel} AS FAL  LEFT JOIN       {User} AS U ON FAL.[AssignedTo] = U.[Id]  WHERE       FAL.[FolioApprovalId] = @FolioApprovalId AND      FAL.[ApprovalStatusId] <> @PendingApprovalStatus  GROUP BY       FAL.[LevelNumber],       FAL.[ApprovalStatusId],      U.[Name],      FAL.[IsSubstituteFor]  ORDER BY       FAL.[LevelNumber] ASC;): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetLevels in GetFolioApprovalDisplay in FolioSAE_Details in j_FoliosSAE in ConectaProveedores (SELECT       FAL.[LevelNumber],      FAL.[ApprovalStatusId],      COALESCE(U.[Name], 'Sin asignación') AS [Name],      STRING_AGG(          COALESCE(NULLIF(FAL.[EntraJobTitle], ''), 'Sin puesto'),           ' | '           ORDER BY FAL.[EntraJobTitle]      ) AS [CombinedJobTitles],      '',      0,      FAL.[IsSubstituteFor]  FROM       {FolioApprovalLevel} AS FAL  LEFT JOIN       {User} AS U ON FAL.[AssignedTo] = U.[Id]  WHERE       FAL.[FolioApprovalId] = @FolioApprovalId AND      FAL.[ApprovalStatusId] <> @PendingApprovalStatus  GROUP BY       FAL.[LevelNumber],       FAL.[ApprovalStatusId],      U.[Name],      FAL.[IsSubstituteFor]  ORDER BY       FAL.[LevelNumber] ASC;): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetLevels in GetFolioApprovalDisplay in FolioSAE_Details in j_FoliosSAE in ConectaProveedores (SELECT       FAL.[LevelNumber],      FAL.[ApprovalStatusId],      COALESCE(U.[Name], 'Sin asignación') AS [Name],      STRING_AGG(          COALESCE(NULLIF(FAL.[EntraJobTitle], ''), 'Sin puesto'),           ' | '           ORDER BY FAL.[EntraJobTitle]      ) AS [CombinedJobTitles],      '',      0,      FAL.[IsSubstituteFor]  FROM       {FolioApprovalLevel} AS FAL  LEFT JOIN       {User} AS U ON FAL.[AssignedTo] = U.[Id]  WHERE       FAL.[FolioApprovalId] = @FolioApprovalId AND      FAL.[ApprovalStatusId] <> @PendingApprovalStatus  GROUP BY       FAL.[LevelNumber],       FAL.[ApprovalStatusId],      U.[Name],      FAL.[IsSubstituteFor]  ORDER BY       FAL.[LevelNumber] ASC;): " + aqExcep.Message));
}
}
}
}


}
