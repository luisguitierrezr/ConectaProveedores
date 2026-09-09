using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_j_FoliosSAE_ForeignInvoicesForReassignment_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_j_FoliosSAE_ForeignInvoicesForReassignment_ScreenModel).Namespace);

    public bool varLcl_IsSidebarOpen;
public ST_6fc999fa8f6e0055c73f2f167c4bad19Structure varLcNotifContent;
public string varLcTableSort;
public int varLcStartIndex;
public string varLcl_ColumnJSONVar;
public int varLcl_CountAfterFetch;
public bool varLcl_ReInvokeToggler;
public AggregateRecord<RL_4d1a87a21136b2184fa5a9ef787f7fd6> ScreenDataSetGetReassignments;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_j_FoliosSAE_ForeignInvoicesForReassignment_ScreenModel() {
}



    public ConectaProveedores_j_FoliosSAE_ForeignInvoicesForReassignment_ScreenModel(bool varLcl_IsSidebarOpen, ST_6fc999fa8f6e0055c73f2f167c4bad19Structure varLcNotifContent, string varLcTableSort, int varLcStartIndex, string varLcl_ColumnJSONVar, int varLcl_CountAfterFetch, bool varLcl_ReInvokeToggler, AggregateRecord<RL_4d1a87a21136b2184fa5a9ef787f7fd6> ScreenDataSetGetReassignments, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"l_IsSidebarOpen", "NotifContent", "TableSort", "StartIndex", "l_ColumnJSONVar", "l_CountAfterFetch", "l_ReInvokeToggler", "GetReassignments", "ClientVars"}, new string[] {"varLcl_IsSidebarOpen", "varLcNotifContent", "varLcTableSort", "varLcStartIndex", "varLcl_ColumnJSONVar", "varLcl_CountAfterFetch", "varLcl_ReInvokeToggler", "ScreenDataSetGetReassignments", "clientVariables"});
this.varLcl_IsSidebarOpen = varLcl_IsSidebarOpen;
this.varLcNotifContent = varLcNotifContent;
this.varLcTableSort = varLcTableSort;
this.varLcStartIndex = varLcStartIndex;
this.varLcl_ColumnJSONVar = varLcl_ColumnJSONVar;
this.varLcl_CountAfterFetch = varLcl_CountAfterFetch;
this.varLcl_ReInvokeToggler = varLcl_ReInvokeToggler;
this.ScreenDataSetGetReassignments = ScreenDataSetGetReassignments;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_234ff55477e8affa6c928b8c8c03aedb> datasetGetReassignmentsReadDbAsync(RC_234ff55477e8affa6c928b8c8c03aedb rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENCreatedBy.Read( r, ref index);
rec.ssENFolio.Read( r, ref index);
rec.ssENFolioApprovalLevel.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssENReassignments.Read( r, ref index);
rec.ssENRevokedBy.Read( r, ref index);
rec.ssENSourceUser.Read( r, ref index);
rec.ssENTargetUser.Read( r, ref index);
return rec;
}
// Query Function "GetReassignments" SZv0VQTfcEOlpAqyGnLkww of Action "ForeignInvoicesForReassignment"
public static async Task<(RL_4d1a87a21136b2184fa5a9ef787f7fd6,long)> datasetGetReassignments(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteForeignInvoicesForReassignment_FolioNumber,string qpteForeignInvoicesForReassignment_OrderNumber,string qpusReassignments_SourceUserId,string qpusReassignments_TargetUserId,string qpteTableSort,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.ForeignInvoicesForReassignment.GetReassignments", "55f49b49-df04-4370-a5a4-0ab21a72e4c3");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("ForeignInvoicesForReassignment","j_FoliosSAE.ForeignInvoicesForReassignment.GetReassignments");
// Query Iterations: Multiple
// Refresh Query Krula57gVkC3mTWsFym9QA Iterations: Multiple
// Refresh Query CYrryHNv+E2FepVfwNwwuQ Iterations: Multiple
// Refresh Query X8PTqb5TaESfN7iZqsK7Wg Iterations: Multiple
// Refresh Query YdkPQQGACkKfFgL+2WF0bw Iterations: Multiple
// Refresh Query N8fQ5uynm0a0zQgHAYvrNg Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.ik+tvFKAh0aEYg7MMDEkAQ/ScreenDataSets.SZv0VQTfcEOlpAqyGnLkww, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"encreatedby1\".\"name\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, \"enfolio116\".\"folionumber\" o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, \"enfolioapprovallevel56\".\"id\" o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, \"enfolioapprovallevel56\".\"approvalstatusid\" o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, \"enordermain156\".\"ordernumber\" o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, \"enreassignments4\".\"id\" o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, \"enreassignments4\".\"reason\" o81, NULL o82, \"enreassignments4\".\"createdon\" o83, \"enreassignments4\".\"revokedby\" o84, \"enreassignments4\".\"revokedon\" o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, \"enrevokedby1\".\"name\" o92, NULL o93, NULL o94, NULL o95, NULL o96, \"ensourceuser1\".\"name\" o97, NULL o98, NULL o99, NULL o100, NULL o101, \"entargetuser1\".\"name\" o102, NULL o103, NULL o104, NULL o105");
fromBuilder.Append(" FROM ((((((({Reassignments} \"enreassignments4\" Left JOIN {Folio} \"enfolio116\" ON (\"enreassignments4\".\"folioid\" = \"enfolio116\".\"id\"))  Left JOIN {FolioApprovalLevel} \"enfolioapprovallevel56\" ON (\"enreassignments4\".\"folioapprovallevelid\" = \"enfolioapprovallevel56\".\"id\"))  Left JOIN {User} \"ensourceuser1\" ON (\"enreassignments4\".\"sourceuserid\" = \"ensourceuser1\".\"id\"))  Left JOIN {User} \"entargetuser1\" ON (\"enreassignments4\".\"targetuserid\" = \"entargetuser1\".\"id\"))  Left JOIN {OrderMain} \"enordermain156\" ON (\"enfolio116\".\"orderid\" = \"enordermain156\".\"id\"))  Left JOIN {User} \"encreatedby1\" ON (\"enreassignments4\".\"createdby\" = \"encreatedby1\".\"id\"))  Left JOIN {User} \"enrevokedby1\" ON (\"enreassignments4\".\"revokedby\" = \"enrevokedby1\".\"id\")) ");
whereBuilder.Append(" WHERE (\"enreassignments4\".\"folioid\" IS NOT NULL) AND ");
if (qpteForeignInvoicesForReassignment_FolioNumber != "") {
whereBuilder.Append("(((trim(@qpteForeignInvoicesForReassignment_FolioNumber)) = '') OR (caseaccent_normalize(\"enfolio116\".\"folionumber\" collate \"default\") like caseaccent_normalize((('%' || @qpteForeignInvoicesForReassignment_FolioNumber) || '%') collate \"default\"))) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteForeignInvoicesForReassignment_FolioNumber", DbType.String, qpteForeignInvoicesForReassignment_FolioNumber);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteForeignInvoicesForReassignment_FolioNumber", DbType.String, qpteForeignInvoicesForReassignment_FolioNumber);
}
if (qpteForeignInvoicesForReassignment_OrderNumber != "") {
whereBuilder.Append("(((trim(@qpteForeignInvoicesForReassignment_OrderNumber)) = '') OR (caseaccent_normalize(\"enordermain156\".\"ordernumber\" collate \"default\") like caseaccent_normalize((('%' || @qpteForeignInvoicesForReassignment_OrderNumber) || '%') collate \"default\"))) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteForeignInvoicesForReassignment_OrderNumber", DbType.String, qpteForeignInvoicesForReassignment_OrderNumber);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteForeignInvoicesForReassignment_OrderNumber", DbType.String, qpteForeignInvoicesForReassignment_OrderNumber);
}
if (qpusReassignments_SourceUserId != BuiltInFunction.NullTextIdentifier()) {
if ((qpusReassignments_SourceUserId.Trim()!="")) {
whereBuilder.Append("((\"enreassignments4\".\"sourceuserid\" = @qpusReassignments_SourceUserId) AND (\"enreassignments4\".\"sourceuserid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusReassignments_SourceUserId", DbType.String, qpusReassignments_SourceUserId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpusReassignments_SourceUserId", DbType.String, qpusReassignments_SourceUserId);
} else {
whereBuilder.Append("(\"enreassignments4\".\"sourceuserid\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpusReassignments_TargetUserId != BuiltInFunction.NullTextIdentifier()) {
if ((qpusReassignments_TargetUserId.Trim()!="")) {
whereBuilder.Append("((\"enreassignments4\".\"targetuserid\" = @qpusReassignments_TargetUserId) AND (\"enreassignments4\".\"targetuserid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusReassignments_TargetUserId", DbType.String, qpusReassignments_TargetUserId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpusReassignments_TargetUserId", DbType.String, qpusReassignments_TargetUserId);
} else {
whereBuilder.Append("(\"enreassignments4\".\"targetuserid\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
whereBuilder.Append("(\"enreassignments4\".\"isfolioapprovallevelinvoice\" = 1)");
orderByBuilder.Append(" ORDER BY ");
List<string> orderByColumns = new List<string>();
orderByColumns.AddRange(BaseAppUtils.ReplaceEntityReferencesAndAttributesInOrderBy(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, qpteTableSort, new string[] { "OrderMain", "SourceUser", "TargetUser", "Reassignments", "RevokedBy", "FolioApprovalLevel", "CreatedBy", "Folio" }, new string[] { "ENOrderMain156", "ENSourceUser1", "ENTargetUser1", "ENReassignments4", "ENRevokedBy1", "ENFolioApprovalLevel56", "ENCreatedBy1", "ENFolio116" }, new System.Collections.Generic.Dictionary<string, string>[] { ENOrderMainEntity.AttributesToDatabaseNamesMap(), ENUserEntity.AttributesToDatabaseNamesMap(), ENUserEntity.AttributesToDatabaseNamesMap(), ENReassignmentsEntity.AttributesToDatabaseNamesMap(), ENUserEntity.AttributesToDatabaseNamesMap(), ENFolioApprovalLevelEntity.AttributesToDatabaseNamesMap(), ENUserEntity.AttributesToDatabaseNamesMap(), ENFolioEntity.AttributesToDatabaseNamesMap() }).Split(','));
orderByColumns.Add("\"enreassignments4\".\"id\" DESC ");
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
RL_4d1a87a21136b2184fa5a9ef787f7fd6 outParamList = new RL_4d1a87a21136b2184fa5a9ef787f7fd6();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetReassignmentsReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[8];
opt[0] = new BitArray(new bool[] {true, false, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true});
opt[2] = new BitArray(new bool[] {true, false, true, true, true});
opt[3] = new BitArray(new bool[] {true, false, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {false, true, true, true, true, true, true, false, true, false, false, false, true, true, true, true, true});
opt[6] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true});
opt[7] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query j_FoliosSAE.ForeignInvoicesForReassignment.GetReassignments.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.ForeignInvoicesForReassignment.GetReassignments.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_4d1a87a21136b2184fa5a9ef787f7fd6 _tmp = new RL_4d1a87a21136b2184fa5a9ef787f7fd6();
_tmp.AlternateReadDbMethodAsync = datasetGetReassignmentsReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.ForeignInvoicesForReassignment.GetReassignments.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_4d1a87a21136b2184fa5a9ef787f7fd6)_tmp;
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query j_FoliosSAE.ForeignInvoicesForReassignment.GetReassignments.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
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
