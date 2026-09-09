using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_ScreenModel).Namespace);

    public long inParamFolioId;
public long inParami_OrderId;
public RL_123aa03224ec08dab8cbe26021987012 inParami_LocalSelectedLines;
public RL_1501ee54ff868a67eff67465502ee3d9 inParamFilesList;
public bool varLcl_IsApplyToAll;
public DateTime varLcDeliveryDate;
public RC_0b2176705fa164c9531eb643caf0e9d4 varLcl_SummaryRec;
public bool varLcWithDatesError;
public bool varLcWithQuantityError;
public bool varLcWithPaymentError;
public bool varLcWithFilesError;
public bool varLcWithConceptMinutesError;
public bool varLcWithApprovalProcessError;
public bool varLcDatesQuantityPEPError;
public bool varLcWithprorata;
public string varLcComments;
public RL_1501ee54ff868a67eff67465502ee3d9 varLcFilesListExtra;
public int varLcMinuteSelected;
public RC_1c2482ce6cd4b83ca44ec0510b231d44 varLcConstructionStruct;
public RL_f4c5cb6ef02fae333513cbd4dafd500c varLcMinuteDocumentTypeList;
public bool varLcMaxAmountError;
public RL_123aa03224ec08dab8cbe26021987012 varLcLocalSelectedLines;
public bool varLcl_IsOpenPopup;
public string varLcl_IsOpenPopupComment;
public bool varLcHaveNewFiles;
public string varLcNewFileNamesUploaded;
public AggregateRecord<RL_5fec0894721bcc83c763c610a52bfbfd> ScreenDataSetGetFolioCommentsByFolioId;
public AggregateRecord<RL_994583bfe1c92160ce9fe58b4f4e0d70> ScreenDataSetGetFolioObservationsByFolioId;
public AggregateRecord<RL_398a2e7b47dcd31617b8f6499aea0bce> ScreenDataSetGetOrderDetail;
public AggregateRecord<RL_4d304652a66e6de5c7b4ce65fcc7c50b> ScreenDataSetGetApprovalList;
public AggregateRecord<RL_abf5dc59037dde79c92447e12cf9bfc9> ScreenDataSetGetFolioExtendedById;
public AggregateRecord<RL_a968cf9f63475dc9358672149b11245a> ScreenDataSetGetFolioItemsByFolioId;
public AggregateRecord<RL_4f8b259bdd04db22be8fb771f1ad1d4f> ScreenDataSetGetFolioById;
public ConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_DataActionGetOrderMainItems_Model varLcGetOrderMainItems;
public ConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_DataActionGetMinutes_Model varLcGetMinutes;
public ConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_DataActionGetSummary_Model varLcGetSummary;
public ConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_DataActionGetMinutesDocuments_Model varLcGetMinutesDocuments;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_ScreenModel() {
}



    public ConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_ScreenModel(long inParamFolioId, long inParami_OrderId, RL_123aa03224ec08dab8cbe26021987012 inParami_LocalSelectedLines, RL_1501ee54ff868a67eff67465502ee3d9 inParamFilesList, bool varLcl_IsApplyToAll, DateTime varLcDeliveryDate, RC_0b2176705fa164c9531eb643caf0e9d4 varLcl_SummaryRec, bool varLcWithDatesError, bool varLcWithQuantityError, bool varLcWithPaymentError, bool varLcWithFilesError, bool varLcWithConceptMinutesError, bool varLcWithApprovalProcessError, bool varLcDatesQuantityPEPError, bool varLcWithprorata, string varLcComments, RL_1501ee54ff868a67eff67465502ee3d9 varLcFilesListExtra, int varLcMinuteSelected, RC_1c2482ce6cd4b83ca44ec0510b231d44 varLcConstructionStruct, RL_f4c5cb6ef02fae333513cbd4dafd500c varLcMinuteDocumentTypeList, bool varLcMaxAmountError, RL_123aa03224ec08dab8cbe26021987012 varLcLocalSelectedLines, bool varLcl_IsOpenPopup, string varLcl_IsOpenPopupComment, bool varLcHaveNewFiles, string varLcNewFileNamesUploaded, AggregateRecord<RL_5fec0894721bcc83c763c610a52bfbfd> ScreenDataSetGetFolioCommentsByFolioId, AggregateRecord<RL_994583bfe1c92160ce9fe58b4f4e0d70> ScreenDataSetGetFolioObservationsByFolioId, AggregateRecord<RL_398a2e7b47dcd31617b8f6499aea0bce> ScreenDataSetGetOrderDetail, AggregateRecord<RL_4d304652a66e6de5c7b4ce65fcc7c50b> ScreenDataSetGetApprovalList, AggregateRecord<RL_abf5dc59037dde79c92447e12cf9bfc9> ScreenDataSetGetFolioExtendedById, AggregateRecord<RL_a968cf9f63475dc9358672149b11245a> ScreenDataSetGetFolioItemsByFolioId, AggregateRecord<RL_4f8b259bdd04db22be8fb771f1ad1d4f> ScreenDataSetGetFolioById, ConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_DataActionGetOrderMainItems_Model varLcGetOrderMainItems, ConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_DataActionGetMinutes_Model varLcGetMinutes, ConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_DataActionGetSummary_Model varLcGetSummary, ConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_DataActionGetMinutesDocuments_Model varLcGetMinutesDocuments, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"FolioId", "i_OrderId", "i_LocalSelectedLines", "FilesList", "l_IsApplyToAll", "DeliveryDate", "l_SummaryRec", "WithDatesError", "WithQuantityError", "WithPaymentError", "WithFilesError", "WithConceptMinutesError", "WithApprovalProcessError", "DatesQuantityPEPError", "Withprorata", "Comments", "FilesListExtra", "MinuteSelected", "ConstructionStruct", "MinuteDocumentTypeList", "MaxAmountError", "LocalSelectedLines", "l_IsOpenPopup", "l_IsOpenPopupComment", "HaveNewFiles", "NewFileNamesUploaded", "GetFolioCommentsByFolioId", "GetFolioObservationsByFolioId", "GetOrderDetail", "GetApprovalList", "GetFolioExtendedById", "GetFolioItemsByFolioId", "GetFolioById", "GetOrderMainItems", "GetMinutes", "GetSummary", "GetMinutesDocuments", "ClientVars"}, new string[] {"inParamFolioId", "inParami_OrderId", "inParami_LocalSelectedLines", "inParamFilesList", "varLcl_IsApplyToAll", "varLcDeliveryDate", "varLcl_SummaryRec", "varLcWithDatesError", "varLcWithQuantityError", "varLcWithPaymentError", "varLcWithFilesError", "varLcWithConceptMinutesError", "varLcWithApprovalProcessError", "varLcDatesQuantityPEPError", "varLcWithprorata", "varLcComments", "varLcFilesListExtra", "varLcMinuteSelected", "varLcConstructionStruct", "varLcMinuteDocumentTypeList", "varLcMaxAmountError", "varLcLocalSelectedLines", "varLcl_IsOpenPopup", "varLcl_IsOpenPopupComment", "varLcHaveNewFiles", "varLcNewFileNamesUploaded", "ScreenDataSetGetFolioCommentsByFolioId", "ScreenDataSetGetFolioObservationsByFolioId", "ScreenDataSetGetOrderDetail", "ScreenDataSetGetApprovalList", "ScreenDataSetGetFolioExtendedById", "ScreenDataSetGetFolioItemsByFolioId", "ScreenDataSetGetFolioById", "varLcGetOrderMainItems", "varLcGetMinutes", "varLcGetSummary", "varLcGetMinutesDocuments", "clientVariables"});
this.inParamFolioId = inParamFolioId;
this.inParami_OrderId = inParami_OrderId;
this.inParami_LocalSelectedLines = inParami_LocalSelectedLines;
this.inParamFilesList = inParamFilesList;
this.varLcl_IsApplyToAll = varLcl_IsApplyToAll;
this.varLcDeliveryDate = varLcDeliveryDate;
this.varLcl_SummaryRec = varLcl_SummaryRec;
this.varLcWithDatesError = varLcWithDatesError;
this.varLcWithQuantityError = varLcWithQuantityError;
this.varLcWithPaymentError = varLcWithPaymentError;
this.varLcWithFilesError = varLcWithFilesError;
this.varLcWithConceptMinutesError = varLcWithConceptMinutesError;
this.varLcWithApprovalProcessError = varLcWithApprovalProcessError;
this.varLcDatesQuantityPEPError = varLcDatesQuantityPEPError;
this.varLcWithprorata = varLcWithprorata;
this.varLcComments = varLcComments;
this.varLcFilesListExtra = varLcFilesListExtra;
this.varLcMinuteSelected = varLcMinuteSelected;
this.varLcConstructionStruct = varLcConstructionStruct;
this.varLcMinuteDocumentTypeList = varLcMinuteDocumentTypeList;
this.varLcMaxAmountError = varLcMaxAmountError;
this.varLcLocalSelectedLines = varLcLocalSelectedLines;
this.varLcl_IsOpenPopup = varLcl_IsOpenPopup;
this.varLcl_IsOpenPopupComment = varLcl_IsOpenPopupComment;
this.varLcHaveNewFiles = varLcHaveNewFiles;
this.varLcNewFileNamesUploaded = varLcNewFileNamesUploaded;
this.ScreenDataSetGetFolioCommentsByFolioId = ScreenDataSetGetFolioCommentsByFolioId;
this.ScreenDataSetGetFolioObservationsByFolioId = ScreenDataSetGetFolioObservationsByFolioId;
this.ScreenDataSetGetOrderDetail = ScreenDataSetGetOrderDetail;
this.ScreenDataSetGetApprovalList = ScreenDataSetGetApprovalList;
this.ScreenDataSetGetFolioExtendedById = ScreenDataSetGetFolioExtendedById;
this.ScreenDataSetGetFolioItemsByFolioId = ScreenDataSetGetFolioItemsByFolioId;
this.ScreenDataSetGetFolioById = ScreenDataSetGetFolioById;
this.varLcGetOrderMainItems = varLcGetOrderMainItems;
this.varLcGetMinutes = varLcGetMinutes;
this.varLcGetSummary = varLcGetSummary;
this.varLcGetMinutesDocuments = varLcGetMinutesDocuments;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_03baaf9011c29c7810216c701048afb6> datasetGetFolioCommentsByFolioIdReadDbAsync(RC_03baaf9011c29c7810216c701048afb6 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENCommentType.Read( r, ref index);
rec.ssENFolioComment.Read( r, ref index);
return rec;
}
// Query Function "GetFolioCommentsByFolioId" raBnETN0o02esNe9v_oucA of Action "Wb_FolioEditConstruction"
public static async Task<(RL_5fec0894721bcc83c763c610a52bfbfd,long)> datasetGetFolioCommentsByFolioId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolioComment_FolioId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.Wb_FolioEditConstruction.GetFolioCommentsByFolioId", "1167a0ad-7433-4da3-9eb0-d7bdbffa2e70");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_FolioEditConstruction","j_FoliosSAE.Wb_FolioEditConstruction.GetFolioCommentsByFolioId");
// Query Iterations: Never
// Refresh Query T7MxZo3T9E2oJDsnh9BqBA Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.3k7KeMC4GECt_82hyM8+jQ/ScreenDataSets.raBnETN0o02esNe9v_oucA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, \"enfoliocomment3\".\"message\" o12, NULL o13");
fromBuilder.Append(" FROM ({FolioComment} \"enfoliocomment3\" Left JOIN {CommentType} \"encommenttype3\" ON (\"enfoliocomment3\".\"commenttypeid\" = \"encommenttype3\".\"id\")) ");
whereBuilder.Append(" WHERE (\"encommenttype3\".\"id\" = ");
whereBuilder.Append((ENCommentTypeEntity.GetRecordByKey(ObjectKey.Parse("fWPpinJz1EuuskuhosoYJA"))).ssId);
whereBuilder.Append(") AND ");
if (qpfoFolioComment_FolioId != 0) {
whereBuilder.Append("((\"enfoliocomment3\".\"folioid\" = @qpfoFolioComment_FolioId) AND (\"enfoliocomment3\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioComment_FolioId", DbType.Int64, qpfoFolioComment_FolioId);
} else {
whereBuilder.Append("(\"enfoliocomment3\".\"folioid\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"enfoliocomment3\".\"id\" DESC ");
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
RL_5fec0894721bcc83c763c610a52bfbfd outParamList = new RL_5fec0894721bcc83c763c610a52bfbfd();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFolioCommentsByFolioIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, false, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_FolioEditConstruction.GetFolioCommentsByFolioId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_5fec0894721bcc83c763c610a52bfbfd _tmp = new RL_5fec0894721bcc83c763c610a52bfbfd();
_tmp.AlternateReadDbMethodAsync = datasetGetFolioCommentsByFolioIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_FolioEditConstruction.GetFolioCommentsByFolioId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_5fec0894721bcc83c763c610a52bfbfd)_tmp;
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

// Query Function "GetFolioObservationsByFolioId" wGD_N7Ec3UeswDoIcM474Q of Action "Wb_FolioEditConstruction"
public static async Task<(RL_994583bfe1c92160ce9fe58b4f4e0d70,long)> datasetGetFolioObservationsByFolioId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolioId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.Wb_FolioEditConstruction.GetFolioObservationsByFolioId", "37ff60c0-1cb1-47dd-acc0-3a0870ce3be1");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_FolioEditConstruction","j_FoliosSAE.Wb_FolioEditConstruction.GetFolioObservationsByFolioId");
// Query Iterations: Multiple
// Refresh Query zYn96RBxm0GECwp4DWpNcA Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.3k7KeMC4GECt_82hyM8+jQ/ScreenDataSets.wGD_N7Ec3UeswDoIcM474Q, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"enfolioobservations3\".\"observation\" o2, NULL o3, \"enfolioobservations3\".\"createdon\" o4");
fromBuilder.Append(" FROM {FolioObservations} \"enfolioobservations3\"");
whereBuilder.Append(" WHERE ");
if (qpfoFolioId != 0) {
whereBuilder.Append("((\"enfolioobservations3\".\"folioid\" = @qpfoFolioId) AND (\"enfolioobservations3\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioId", DbType.Int64, qpfoFolioId);
} else {
whereBuilder.Append("(\"enfolioobservations3\".\"folioid\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"enfolioobservations3\".\"createdon\" DESC ");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_FolioEditConstruction.GetFolioObservationsByFolioId.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_FolioEditConstruction.GetFolioObservationsByFolioId.List", cancellationToken: cancellationToken);
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

private static async Task<RC_03b2a2565369f3088e5267bce38cfba9> datasetGetOrderDetailReadDbAsync(RC_03b2a2565369f3088e5267bce38cfba9 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENOrderDetail.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssENPaymentMethods.Read( r, ref index);
rec.ssENPaymentTerms.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetOrderDetail" mTVrPoOQOEuGE5ghMtH8Yg of Action "Wb_FolioEditConstruction"
public static async Task<(RL_398a2e7b47dcd31617b8f6499aea0bce,long)> datasetGetOrderDetail(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderMain_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.Wb_FolioEditConstruction.GetOrderDetail", "3e6b3599-9083-4b38-8613-982132d1fc62");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_FolioEditConstruction","j_FoliosSAE.Wb_FolioEditConstruction.GetOrderDetail");
// Query Iterations: Never
// Refresh Query JrZXqK+OrUK6rliRXgjgZg Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.3k7KeMC4GECt_82hyM8+jQ/ScreenDataSets.mTVrPoOQOEuGE5ghMtH8Yg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, \"enordermain146\".\"ordernumber\" o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, \"enordermain146\".\"telceldirectionid\" o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, NULL o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, NULL o118, NULL o119, NULL o120, NULL o121, NULL o122, NULL o123, NULL o124, NULL o125, NULL o126, NULL o127, NULL o128");
fromBuilder.Append(" FROM ((((({OrderMain} \"enordermain146\" Inner JOIN {Supplier} \"ensupplier146\" ON (\"enordermain146\".\"supplierid\" = \"ensupplier146\".\"id\"))  Left JOIN {OrderDetail} \"enorderdetail25\" ON (\"enordermain146\".\"id\" = \"enorderdetail25\".\"orderid\"))  Left JOIN {PaymentMethods} \"enpaymentmethods16\" ON (\"enorderdetail25\".\"paymentmethodid\" = \"enpaymentmethods16\".\"id\"))  Left JOIN {PaymentTerms} \"enpaymentterms36\" ON (\"enorderdetail25\".\"paymenttermsid\" = \"enpaymentterms36\".\"id\"))  Left JOIN {Region} \"enregion192\" ON (\"enordermain146\".\"regionid\" = \"enregion192\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderMain_Id != 0) {
whereBuilder.Append("((\"enordermain146\".\"id\" = @qporOrderMain_Id) AND (\"enordermain146\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderMain_Id", DbType.Int64, qporOrderMain_Id);
} else {
whereBuilder.Append("(\"enordermain146\".\"id\" IS NULL)");
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
RL_398a2e7b47dcd31617b8f6499aea0bce outParamList = new RL_398a2e7b47dcd31617b8f6499aea0bce();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderDetailReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[6];
opt[0] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_FolioEditConstruction.GetOrderDetail.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_398a2e7b47dcd31617b8f6499aea0bce _tmp = new RL_398a2e7b47dcd31617b8f6499aea0bce();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderDetailReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_FolioEditConstruction.GetOrderDetail.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_398a2e7b47dcd31617b8f6499aea0bce)_tmp;
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

private static async Task<RC_79a64780c4264a7ff3588d1347b5f259> datasetGetApprovalListReadDbAsync(RC_79a64780c4264a7ff3588d1347b5f259 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENEntraRole.Read( r, ref index);
rec.ssENTelcelDirection.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
return rec;
}
// Query Function "GetApprovalList" x3PmZycsskG+8DWN1aAGmg of Action "Wb_FolioEditConstruction"
public static async Task<(RL_4d304652a66e6de5c7b4ce65fcc7c50b,long)> datasetGetApprovalList(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpteTelcelDirection_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.Wb_FolioEditConstruction.GetApprovalList", "67e673c7-2c27-41b2-bef0-358dd5a0069a");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_FolioEditConstruction","j_FoliosSAE.Wb_FolioEditConstruction.GetApprovalList");
// Query Iterations: Never
// Refresh Query FkRCy2xyMU+DzpN22SX8bQ Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.3k7KeMC4GECt_82hyM8+jQ/ScreenDataSets.x3PmZycsskG+8DWN1aAGmg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37");
fromBuilder.Append(" FROM ((({TelcelDirection} \"entelceldirection19\" Inner JOIN {User_Extended_Internal} \"enuser_extended_internal142\" ON (\"entelceldirection19\".\"id\" = \"enuser_extended_internal142\".\"telceldirectionid\"))  Left JOIN {User} \"enuser244\" ON (\"enuser_extended_internal142\".\"id\" = \"enuser244\".\"id\"))  Inner JOIN {EntraRole} \"enentrarole87\" ON (\"enuser_extended_internal142\".\"entraroleid\" = \"enentrarole87\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpteTelcelDirection_Id != 0) {
whereBuilder.Append("((\"entelceldirection19\".\"id\" = @qpteTelcelDirection_Id) AND (\"entelceldirection19\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpteTelcelDirection_Id", DbType.Int64, qpteTelcelDirection_Id);
} else {
whereBuilder.Append("(\"entelceldirection19\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (\"enentrarole87\".\"isareausuaria\" = 1)");
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
RL_4d304652a66e6de5c7b4ce65fcc7c50b outParamList = new RL_4d304652a66e6de5c7b4ce65fcc7c50b();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetApprovalListReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[4];
opt[0] = new BitArray(new bool[] {true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_FolioEditConstruction.GetApprovalList.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_4d304652a66e6de5c7b4ce65fcc7c50b _tmp = new RL_4d304652a66e6de5c7b4ce65fcc7c50b();
_tmp.AlternateReadDbMethodAsync = datasetGetApprovalListReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_FolioEditConstruction.GetApprovalList.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_4d304652a66e6de5c7b4ce65fcc7c50b)_tmp;
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

// Query Function "GetFolioExtendedById" aoDTa37Jm0y1d6y1VfFe6Q of Action "Wb_FolioEditConstruction"
public static async Task<(RL_abf5dc59037dde79c92447e12cf9bfc9,long)> datasetGetFolioExtendedById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.Wb_FolioEditConstruction.GetFolioExtendedById", "6bd3806a-c97e-4c9b-b577-acb555f15ee9");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_FolioEditConstruction","j_FoliosSAE.Wb_FolioEditConstruction.GetFolioExtendedById");
// Query Iterations: Never
// Refresh Query CXrV7xwONEqeDQuRuH6DcQ Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.3k7KeMC4GECt_82hyM8+jQ/ScreenDataSets.aoDTa37Jm0y1d6y1VfFe6Q, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enfolioextended2\".\"isadvpayment\" o1, trim_scale(\"enfolioextended2\".\"advpaymentvalue\"::numeric) o2, \"enfolioextended2\".\"iscreditnote\" o3, trim_scale(\"enfolioextended2\".\"creditnotevalue\"::numeric) o4, \"enfolioextended2\".\"isvoucher\" o5, trim_scale(\"enfolioextended2\".\"vouchervalue\"::numeric) o6, \"enfolioextended2\".\"isna\" o7");
fromBuilder.Append(" FROM {FolioExtended} \"enfolioextended2\"");
whereBuilder.Append(" WHERE ");
if (qpfoId != 0) {
whereBuilder.Append("((\"enfolioextended2\".\"id\" = @qpfoId) AND (\"enfolioextended2\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoId", DbType.Int64, qpfoId);
} else {
whereBuilder.Append("(\"enfolioextended2\".\"id\" IS NULL)");
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
RL_abf5dc59037dde79c92447e12cf9bfc9 outParamList = new RL_abf5dc59037dde79c92447e12cf9bfc9();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_FolioEditConstruction.GetFolioExtendedById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_abf5dc59037dde79c92447e12cf9bfc9 _tmp = new RL_abf5dc59037dde79c92447e12cf9bfc9();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_FolioEditConstruction.GetFolioExtendedById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_abf5dc59037dde79c92447e12cf9bfc9)_tmp;
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

private static async Task<RC_95110bc97f34f4c1561c8cbf2b5015b2> datasetGetFolioItemsByFolioIdReadDbAsync(RC_95110bc97f34f4c1561c8cbf2b5015b2 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolio.Read( r, ref index);
rec.ssENFolioItems.Read( r, ref index);
rec.ssENOrderMainItem.Read( r, ref index);
return rec;
}
// Query Function "GetFolioItemsByFolioId" D4QeudrCRE+9og6h2xdmMQ of Action "Wb_FolioEditConstruction"
public static async Task<(RL_a968cf9f63475dc9358672149b11245a,long)> datasetGetFolioItemsByFolioId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolioItems_FolioId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.Wb_FolioEditConstruction.GetFolioItemsByFolioId", "b91e840f-c2da-4f44-bda2-0ea1db176631");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_FolioEditConstruction","j_FoliosSAE.Wb_FolioEditConstruction.GetFolioItemsByFolioId");
// Query Iterations: Multiple
// Refresh Query jG9TRLxlgUSzxy1wj1_jkQ Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.3k7KeMC4GECt_82hyM8+jQ/ScreenDataSets.D4QeudrCRE+9og6h2xdmMQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enfolio103\".\"id\" o0, \"enfolio103\".\"isdraft\" o1, \"enfolio103\".\"folionumber\" o2, \"enfolio103\".\"canproveedorcancel\" o3, \"enfolio103\".\"orderid\" o4, \"enfolio103\".\"supplierid\" o5, \"enfolio103\".\"companyid\" o6, \"enfolio103\".\"foliostatusid\" o7, trim_scale(\"enfolio103\".\"totalamount\"::numeric) o8, trim_scale(\"enfolio103\".\"totaliva_amount\"::numeric) o9, trim_scale(\"enfolio103\".\"partialamount\"::numeric) o10, \"enfolio103\".\"currencyid\" o11, \"enfolio103\".\"firstapproveruserid\" o12, \"enfolio103\".\"approvalprocesstypeid\" o13, \"enfolio103\".\"sapentryerror\" o14, \"enfolio103\".\"createdby\" o15, \"enfolio103\".\"createdon\" o16, \"enfolio103\".\"updatedby\" o17, \"enfolio103\".\"updatedon\" o18, \"enfolio103\".\"minuteselected\" o19, \"enfolioitems19\".\"id\" o20, \"enfolioitems19\".\"folioid\" o21, \"enfolioitems19\".\"ordermainitemid\" o22, \"enfolioitems19\".\"ordernumber\" o23, \"enfolioitems19\".\"articlenumber\" o24, \"enfolioitems19\".\"description\" o25, \"enfolioitems19\".\"inputationcode\" o26, \"enfolioitems19\".\"deliverydate\" o27, trim_scale(\"enfolioitems19\".\"invoiceqtt\"::numeric) o28, trim_scale(\"enfolioitems19\".\"remainingqtt\"::numeric) o29, trim_scale(\"enfolioitems19\".\"unitprice\"::numeric) o30, trim_scale(\"enfolioitems19\".\"totalprice\"::numeric) o31, trim_scale(\"enfolioitems19\".\"quantity\"::numeric) o32, \"enfolioitems19\".\"deliveryqtt\" o33, \"enfolioitems19\".\"importdelivery\" o34, \"enfolioitems19\".\"pep\" o35, \"enfolioitems19\".\"placeid\" o36, \"enfolioitems19\".\"placename\" o37, \"enordermainitem36\".\"id\" o38, \"enordermainitem36\".\"ordermainid\" o39, \"enordermainitem36\".\"position\" o40, \"enordermainitem36\".\"materialcode\" o41, \"enordermainitem36\".\"materialdescription\" o42, \"enordermainitem36\".\"assigmnentcode\" o43, \"enordermainitem36\".\"documentclassid\" o44, \"enordermainitem36\".\"deliverydate\" o45, trim_scale(\"enordermainitem36\".\"quantity\"::numeric) o46, \"enordermainitem36\".\"unittype\" o47, trim_scale(\"enordermainitem36\".\"unitprice\"::numeric) o48, \"enordermainitem36\".\"basequantity\" o49, \"enordermainitem36\".\"isdeleted\" o50, \"enordermainitem36\".\"isblocked\" o51, \"enordermainitem36\".\"isfinaldelivery\" o52, \"enordermainitem36\".\"glaccountid\" o53, \"enordermainitem36\".\"costcenterid\" o54, \"enordermainitem36\".\"fundscenter\" o55, \"enordermainitem36\".\"fund\" o56, \"enordermainitem36\".\"commitmentitem\" o57, \"enordermainitem36\".\"vatindicator\" o58, \"enordermainitem36\".\"vatprocedure\" o59, trim_scale(\"enordermainitem36\".\"vatrate\"::numeric) o60, \"enordermainitem36\".\"purchaserequisitionnumber\" o61, \"enordermainitem36\".\"purchaserequisitionitemnr\" o62, \"enordermainitem36\".\"regionid\" o63, \"enordermainitem36\".\"center\" o64, \"enordermainitem36\".\"pepelement\" o65, trim_scale(\"enordermainitem36\".\"quantitydelivered\"::numeric) o66, \"enordermainitem36\".\"orderunitofmeasure\" o67, \"enordermainitem36\".\"applicant\" o68, \"enordermainitem36\".\"direction\" o69, \"enordermainitem36\".\"contractnumber\" o70, \"enordermainitem36\".\"contractposition\" o71, \"enordermainitem36\".\"contractstartdate\" o72, \"enordermainitem36\".\"contractenddate\" o73, trim_scale(\"enordermainitem36\".\"contractplannedvalue\"::numeric) o74, \"enordermainitem36\".\"positiontype\" o75, \"enordermainitem36\".\"serialnumberprofile\" o76, \"enordermainitem36\".\"batchmanaged\" o77, \"enordermainitem36\".\"materialtype\" o78, \"enordermainitem36\".\"itemgroup\" o79, \"enordermainitem36\".\"orderrequestcreatorsapnumber\" o80, \"enordermainitem36\".\"ismultipleimputation\" o81, \"enordermainitem36\".\"invoiceusageid\" o82, \"enordermainitem36\".\"ordermainitemstatusid\" o83, \"enordermainitem36\".\"divisionid\" o84, \"enordermainitem36\".\"createdby\" o85, \"enordermainitem36\".\"createdon\" o86, \"enordermainitem36\".\"updatedby\" o87, \"enordermainitem36\".\"updatedon\" o88");
fromBuilder.Append(" FROM (({FolioItems} \"enfolioitems19\" Inner JOIN {OrderMainItem} \"enordermainitem36\" ON (\"enfolioitems19\".\"ordermainitemid\" = \"enordermainitem36\".\"id\"))  Left JOIN {Folio} \"enfolio103\" ON (\"enfolioitems19\".\"folioid\" = \"enfolio103\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoFolioItems_FolioId != 0) {
whereBuilder.Append("((\"enfolioitems19\".\"folioid\" = @qpfoFolioItems_FolioId) AND (\"enfolioitems19\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioItems_FolioId", DbType.Int64, qpfoFolioItems_FolioId);
} else {
whereBuilder.Append("(\"enfolioitems19\".\"folioid\" IS NULL)");
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
RL_a968cf9f63475dc9358672149b11245a outParamList = new RL_a968cf9f63475dc9358672149b11245a();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFolioItemsByFolioIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[2] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_FolioEditConstruction.GetFolioItemsByFolioId.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_FolioEditConstruction.GetFolioItemsByFolioId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_a968cf9f63475dc9358672149b11245a)_tmp;
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

// Query Function "GetFolioById" wmNF7P0yi0y4JDv9Y_jGzA of Action "Wb_FolioEditConstruction"
public static async Task<(RL_4f8b259bdd04db22be8fb771f1ad1d4f,long)> datasetGetFolioById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.Wb_FolioEditConstruction.GetFolioById", "ec4563c2-32fd-4c8b-b824-3bfd63f8c6cc");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_FolioEditConstruction","j_FoliosSAE.Wb_FolioEditConstruction.GetFolioById");
// Query Iterations: Never
// Refresh Query MFNgwbUkPk6VyRLflClWAg Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.3k7KeMC4GECt_82hyM8+jQ/ScreenDataSets.wmNF7P0yi0y4JDv9Y_jGzA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, \"enfolio104\".\"minuteselected\" o19");
fromBuilder.Append(" FROM {Folio} \"enfolio104\"");
whereBuilder.Append(" WHERE ");
if (qpfoId != 0) {
whereBuilder.Append("((\"enfolio104\".\"id\" = @qpfoId) AND (\"enfolio104\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoId", DbType.Int64, qpfoId);
} else {
whereBuilder.Append("(\"enfolio104\".\"id\" IS NULL)");
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
RL_4f8b259bdd04db22be8fb771f1ad1d4f outParamList = new RL_4f8b259bdd04db22be8fb771f1ad1d4f();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_FolioEditConstruction.GetFolioById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_4f8b259bdd04db22be8fb771f1ad1d4f _tmp = new RL_4f8b259bdd04db22be8fb771f1ad1d4f();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_FolioEditConstruction.GetFolioById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_4f8b259bdd04db22be8fb771f1ad1d4f)_tmp;
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


    public class lcvGetOrderMainItems : VarsBag {
public RL_bab3397f952f07af0f0aa229e6f2b36e queryResGetOrdersItems_outParamList = new RL_bab3397f952f07af0f0aa229e6f2b36e();
public long queryResGetOrdersItems_outParamCount = 0L;

public lcvGetOrderMainItems() {
}
}
public class lcoGetOrderMainItems : VarsBag {
public RL_4e1292c876d12cf32f3c04367498157e outParamList = new RL_4e1292c876d12cf32f3c04367498157e();

public lcoGetOrderMainItems() {
}
}
/// <summary>
/// Action <code>GetOrderMainItems</code> that represents the Service Studio action
///  <code>GetOrderMainItems</code> <p> Description: </p>
/// </summary>
public async Task<RL_4e1292c876d12cf32f3c04367498157e> DataActionGetOrderMainItems(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_4e1292c876d12cf32f3c04367498157e outParamList = default;
lcoGetOrderMainItems result = new lcoGetOrderMainItems();
lcvGetOrderMainItems localVars = new lcvGetOrderMainItems();
ConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetOrderMainItems", "66b7f5a9-361b-4218-ad92-2e1476635c62"))
using (activitySource.CreateScreenDataActionActivity("Wb_FolioEditConstruction", "GetOrderMainItems")){
// Query QueryGetOrdersItems
cancellationToken.ThrowIfCancellationRequested();
int QueryGetOrdersItems_maxRecords = 999999999;
if (QueryGetOrdersItems_maxRecords < 1) QueryGetOrdersItems_maxRecords = 1;
int QueryGetOrdersItems_startIndex = 0;(localVars.queryResGetOrdersItems_outParamList,localVars.queryResGetOrdersItems_outParamCount) = await FuncDataActionGetOrderMainItems.QueryGetOrdersItems(requestContext,QueryGetOrdersItems_maxRecords,QueryGetOrdersItems_startIndex,IterationMultiplicity.Never,inParami_OrderId,(ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("cklscJNc0UyOgKXGwg51TQ"))).ssId,(ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("l5OG661dZEe+gAZwnNLhSA"))).ssId,inParamFolioId,cancellationToken);

// List = GetOrdersItems.List
result.outParamList=(await RL_4e1292c876d12cf32f3c04367498157e.ConvertAsync(localVars.queryResGetOrdersItems_outParamList, new RL_4e1292c876d12cf32f3c04367498157e(), async (RC_447a4f014542f360a86edbc89025680b source, ST_1bddfac19e9b0cef65924aa7568fd106Structure target, CancellationToken cancellationToken) => {
target = source;
return target;
}, cancellationToken));
} //close CreateActionActivity using block
} // try

finally {
outParamList = result.outParamList;
} // inner-finally
RETURN_STATEMENT:
return outParamList;
}
public class lcvGetMinutes : VarsBag {
public Actions.lcoGetMinuteType resGetMinuteType =  new Actions.lcoGetMinuteType();
public lcvGetMinutes() {
}
}
public class lcoGetMinutes : VarsBag {
public RL_a579a1a05eaaba551100ea61f4cb3f6b outParamKeyValueList = new RL_a579a1a05eaaba551100ea61f4cb3f6b();

public lcoGetMinutes() {
}
}
/// <summary>
/// Action <code>GetMinutes</code> that represents the Service Studio action <code>GetMinutes</code>
///  <p> Description: </p>
/// </summary>
public async Task<RL_a579a1a05eaaba551100ea61f4cb3f6b> DataActionGetMinutes(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_a579a1a05eaaba551100ea61f4cb3f6b outParamKeyValueList = default;
lcoGetMinutes result = new lcoGetMinutes();
lcvGetMinutes localVars = new lcvGetMinutes();
ConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetMinutes", "6767add7-711d-4d96-b1dd-9a0e45b590a1"))
using (activitySource.CreateScreenDataActionActivity("Wb_FolioEditConstruction", "GetMinutes")){
// GetMinuteType
localVars.resGetMinuteType.outParamList = await Actions.ActionGetMinuteType(requestContext,cancellationToken);

// KeyValueList = GetMinuteType.List
result.outParamKeyValueList=localVars.resGetMinuteType.outParamList;
} //close CreateActionActivity using block
} // try

finally {
outParamKeyValueList = result.outParamKeyValueList;
} // inner-finally
RETURN_STATEMENT:
return outParamKeyValueList;
}
public class lcvGetSummary : VarsBag {
public RL_d3c140b81b16482eac14fd0448f33de5 queryResGetTotalAmountDelivered_outParamList = new RL_d3c140b81b16482eac14fd0448f33de5();
public long queryResGetTotalAmountDelivered_outParamCount = 0L;

public RL_312927afcf3eb9d5fa3bc02bbc91d978 queryResGetTotalFromOriginal_outParamList = new RL_312927afcf3eb9d5fa3bc02bbc91d978();
public long queryResGetTotalFromOriginal_outParamCount = 0L;

public RL_164e5439119ae8b31002cd319dbe8413 queryResGetOrderMainById_outParamList = new RL_164e5439119ae8b31002cd319dbe8413();
public long queryResGetOrderMainById_outParamCount = 0L;

public RL_ecf075efbdf79b05fa564fa6ba80a9c6 queryResGetOrderItemEntries_outParamList = new RL_ecf075efbdf79b05fa564fa6ba80a9c6();
public long queryResGetOrderItemEntries_outParamCount = 0L;

public lcvGetSummary() {
}
}
public class lcoGetSummary : VarsBag {
public RC_0b2176705fa164c9531eb643caf0e9d4 outParamo_SummaryRec = new RC_0b2176705fa164c9531eb643caf0e9d4();

public lcoGetSummary() {
}
}
/// <summary>
/// Action <code>GetSummary</code> that represents the Service Studio action <code>GetSummary</code>
///  <p> Description: </p>
/// </summary>
public async Task<RC_0b2176705fa164c9531eb643caf0e9d4> DataActionGetSummary(IRequestContext requestContext,CancellationToken cancellationToken) {
RC_0b2176705fa164c9531eb643caf0e9d4 outParamo_SummaryRec = default;
lcoGetSummary result = new lcoGetSummary();
lcvGetSummary localVars = new lcvGetSummary();
ConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetSummary", "6c88d6ce-ddd4-411d-a9f7-c72b1fd64066"))
using (activitySource.CreateScreenDataActionActivity("Wb_FolioEditConstruction", "GetSummary")){
// Query datasetGetOrderMainById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderMainById_maxRecords = 0;
int datasetGetOrderMainById_startIndex = 0;(localVars.queryResGetOrderMainById_outParamList,localVars.queryResGetOrderMainById_outParamCount) = await FuncDataActionGetSummary.datasetGetOrderMainById(requestContext,datasetGetOrderMainById_maxRecords,datasetGetOrderMainById_startIndex,IterationMultiplicity.Never,inParami_OrderId,cancellationToken);

// Query datasetGetTotalAmountDelivered
cancellationToken.ThrowIfCancellationRequested();
int datasetGetTotalAmountDelivered_maxRecords = 0;
int datasetGetTotalAmountDelivered_startIndex = 0;(localVars.queryResGetTotalAmountDelivered_outParamList,localVars.queryResGetTotalAmountDelivered_outParamCount) = await FuncDataActionGetSummary.datasetGetTotalAmountDelivered(requestContext,datasetGetTotalAmountDelivered_maxRecords,datasetGetTotalAmountDelivered_startIndex,IterationMultiplicity.Never,inParami_OrderId,cancellationToken);

// Query datasetGetTotalFromOriginal
cancellationToken.ThrowIfCancellationRequested();
int datasetGetTotalFromOriginal_maxRecords = 0;
int datasetGetTotalFromOriginal_startIndex = 0;(localVars.queryResGetTotalFromOriginal_outParamList,localVars.queryResGetTotalFromOriginal_outParamCount) = await FuncDataActionGetSummary.datasetGetTotalFromOriginal(requestContext,datasetGetTotalFromOriginal_maxRecords,datasetGetTotalFromOriginal_startIndex,IterationMultiplicity.Never,inParami_OrderId,cancellationToken);

// Query datasetGetOrderItemEntries
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderItemEntries_maxRecords = 0;
int datasetGetOrderItemEntries_startIndex = 0;(localVars.queryResGetOrderItemEntries_outParamList,localVars.queryResGetOrderItemEntries_outParamCount) = await FuncDataActionGetSummary.datasetGetOrderItemEntries(requestContext,datasetGetOrderItemEntries_maxRecords,datasetGetOrderItemEntries_startIndex,IterationMultiplicity.Never,inParami_OrderId,cancellationToken);

// Foreach LocalSelectedLines
varLcLocalSelectedLines.StartIteration();
try {while (!((varLcLocalSelectedLines.Eof))) {
// o_SummaryRec.MaxAlowed = o_SummaryRec.MaxAlowed + LocalSelectedLines.Current.RemainingQttTotal / LocalSelectedLines.Current.BaseQuantity * LocalSelectedLines.Current.UnitPrice
result.outParamo_SummaryRec.ssMaxAlowed = (result.outParamo_SummaryRec.ssMaxAlowed+(((decimal)varLcLocalSelectedLines.CurrentRec.ssRemainingQttTotal/
(decimal)(((decimal)varLcLocalSelectedLines.CurrentRec.ssBaseQuantity)))*varLcLocalSelectedLines.CurrentRec.ssUnitPrice));
varLcLocalSelectedLines.Advance();
}

} finally {
varLcLocalSelectedLines.EndIteration();
}

// o_SummaryRec.TotalAmount = GetOrderMainById.List.Current.OrderMain.TotalAmount
result.outParamo_SummaryRec.ssTotalAmount = localVars.queryResGetOrderMainById_outParamList.CurrentRec.ssENOrderMain.ssTotalAmount;

// o_SummaryRec.PercentageDelivered = TextToDecimal
result.outParamo_SummaryRec.ssPercentageDelivered = BuiltInFunction.TextToDecimal (BuiltInFunction.FormatDecimal ((((((localVars.queryResGetTotalAmountDelivered_outParamList.CurrentRec.ssTotalPriceSum+localVars.queryResGetTotalFromOriginal_outParamList.CurrentRec.ssTotalSAPSum)+localVars.queryResGetOrderItemEntries_outParamList.CurrentRec.ssTotalSum)==(((decimal)0)))) ? ((((decimal)0))) : ((((decimal)((localVars.queryResGetTotalAmountDelivered_outParamList.CurrentRec.ssTotalPriceSum+localVars.queryResGetTotalFromOriginal_outParamList.CurrentRec.ssTotalSAPSum)+localVars.queryResGetOrderItemEntries_outParamList.CurrentRec.ssTotalSum)/
(decimal)localVars.queryResGetOrderMainById_outParamList.CurrentRec.ssENOrderMain.ssTotalAmount)*(((decimal)100))))), 2, ".", ","));

// o_SummaryRec.AmountLeft = GetOrderMainById.List.Current.OrderMain.TotalAmount - GetTotalAmountDelivered.List.Current.TotalPriceSum - GetTotalFromOriginal.List.Current.TotalSAPSum - GetOrderItemEntries.List.Current.TotalSum
result.outParamo_SummaryRec.ssAmountLeft = (((localVars.queryResGetOrderMainById_outParamList.CurrentRec.ssENOrderMain.ssTotalAmount-localVars.queryResGetTotalAmountDelivered_outParamList.CurrentRec.ssTotalPriceSum)-localVars.queryResGetTotalFromOriginal_outParamList.CurrentRec.ssTotalSAPSum)-localVars.queryResGetOrderItemEntries_outParamList.CurrentRec.ssTotalSum);

// o_SummaryRec.Currency = GetOrderMainById.List.Current.Currency.Code
result.outParamo_SummaryRec.ssCurrency = localVars.queryResGetOrderMainById_outParamList.CurrentRec.ssENCurrency.ssCode;

// o_SummaryRec.AmountDelivered = GetTotalAmountDelivered.List.Current.TotalPriceSum + GetTotalFromOriginal.List.Current.TotalSAPSum + GetOrderItemEntries.List.Current.TotalSum
result.outParamo_SummaryRec.ssAmountDelivered = ((localVars.queryResGetTotalAmountDelivered_outParamList.CurrentRec.ssTotalPriceSum+localVars.queryResGetTotalFromOriginal_outParamList.CurrentRec.ssTotalSAPSum)+localVars.queryResGetOrderItemEntries_outParamList.CurrentRec.ssTotalSum);

// o_SummaryRec.InvoicingAmount = 0
result.outParamo_SummaryRec.ssInvoicingAmount = (((decimal)0));

// o_SummaryRec.Difference_FormSAE_Invoice_Percent = If
result.outParamo_SummaryRec.ssDifference_FormSAE_Invoice_Percent = ((((localVars.queryResGetOrderMainById_outParamList.CurrentRec.ssENOrderMain.ssTotalAmount-localVars.queryResGetTotalAmountDelivered_outParamList.CurrentRec.ssTotalPriceSum)!=(((decimal)0)))) ? ((((decimal)result.outParamo_SummaryRec.ssInvoicingAmount/
(decimal)(localVars.queryResGetOrderMainById_outParamList.CurrentRec.ssENOrderMain.ssTotalAmount-localVars.queryResGetTotalAmountDelivered_outParamList.CurrentRec.ssTotalPriceSum))*(((decimal)100)))) : ((((decimal)0))));
} //close CreateActionActivity using block
} // try

finally {
outParamo_SummaryRec = result.outParamo_SummaryRec;
} // inner-finally
RETURN_STATEMENT:
return outParamo_SummaryRec;
}
public class lcvGetMinutesDocuments : VarsBag {
public Actions.lcoGetDocumentsListByMinuteType resGetDocumentsListByMinuteType =  new Actions.lcoGetDocumentsListByMinuteType();
public RL_897c95bca5499c293930e47bf793d0d9 resListFilter_outParamFilteredList = new RL_897c95bca5499c293930e47bf793d0d9();

public RL_897c95bca5499c293930e47bf793d0d9 queryResGetFolioFilesByFolioId_outParamList = new RL_897c95bca5499c293930e47bf793d0d9();
public long queryResGetFolioFilesByFolioId_outParamCount = 0L;

public lcvGetMinutesDocuments() {
}
}
public class lcoGetMinutesDocuments : VarsBag {
public RL_9fb5c5e988576f6c521a9ef779213183 outParamList = new RL_9fb5c5e988576f6c521a9ef779213183();

public RL_1501ee54ff868a67eff67465502ee3d9 outParamFilesList2 = new RL_1501ee54ff868a67eff67465502ee3d9();

public lcoGetMinutesDocuments() {
}
}
/// <summary>
/// Action <code>GetMinutesDocuments</code> that represents the Service Studio action
///  <code>GetMinutesDocuments</code> <p> Description: </p>
/// </summary>
public async Task<(RL_9fb5c5e988576f6c521a9ef779213183,RL_1501ee54ff868a67eff67465502ee3d9)> DataActionGetMinutesDocuments(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_9fb5c5e988576f6c521a9ef779213183 outParamList = default;
RL_1501ee54ff868a67eff67465502ee3d9 outParamFilesList2 = default;
lcoGetMinutesDocuments result = new lcoGetMinutesDocuments();
lcvGetMinutesDocuments localVars = new lcvGetMinutesDocuments();
ConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetMinutesDocuments", "9083a892-3e51-4110-a322-12ad8d0936de"))
using (activitySource.CreateScreenDataActionActivity("Wb_FolioEditConstruction", "GetMinutesDocuments")){
// GetDocumentsListByMinuteType
localVars.resGetDocumentsListByMinuteType.outParamList = await Actions.ActionGetDocumentsListByMinuteType(requestContext,varLcMinuteSelected,cancellationToken);

// Query datasetGetFolioFilesByFolioId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioFilesByFolioId_maxRecords = 0;
int datasetGetFolioFilesByFolioId_startIndex = 0;(localVars.queryResGetFolioFilesByFolioId_outParamList,localVars.queryResGetFolioFilesByFolioId_outParamCount) = await FuncDataActionGetMinutesDocuments.datasetGetFolioFilesByFolioId(requestContext,datasetGetFolioFilesByFolioId_maxRecords,datasetGetFolioFilesByFolioId_startIndex,IterationMultiplicity.Multiple,inParamFolioId,cancellationToken);

// Foreach GetDocumentsListByMinuteType.List
localVars.resGetDocumentsListByMinuteType.outParamList.StartIteration();
try {while (!((localVars.resGetDocumentsListByMinuteType.outParamList.Eof))) {
// ListFilter
localVars.resListFilter_outParamFilteredList = (((RL_897c95bca5499c293930e47bf793d0d9)await  localVars.queryResGetFolioFilesByFolioId_outParamList.FilterAsync(async (p, cancellationToken) => (BuiltInFunction.ToUpper (BuiltInFunction.SubstrSC (p.ssENFolioFiles.ssFilename, 0, BuiltInFunction.IndexSC (p.ssENFolioFiles.ssFilename, "_", 0, false, false)))==BuiltInFunction.ToUpper (localVars.resGetDocumentsListByMinuteType.outParamList.CurrentRec.ssFileName)), cancellationToken)));

// No Document?
if((!(localVars.resListFilter_outParamFilteredList.Empty))) {
// WithDocument
// GetDocumentsListByMinuteType.List.Current.WithDocument = True
localVars.resGetDocumentsListByMinuteType.outParamList.CurrentRec.ssWithDocument = true;

// GetDocumentsListByMinuteType.List.Current.StorageId = ListFilter.FilteredList.Current.FolioFiles.StorageId
localVars.resGetDocumentsListByMinuteType.outParamList.CurrentRec.ssStorageId = localVars.resListFilter_outParamFilteredList.CurrentRec.ssENFolioFiles.ssStorageId;
}

localVars.resGetDocumentsListByMinuteType.outParamList.Advance();
}

} finally {
localVars.resGetDocumentsListByMinuteType.outParamList.EndIteration();
}

// ListAppendAll
await ExtendedActions.ListAppendAll(requestContext,result.outParamFilesList2,(await RL_1501ee54ff868a67eff67465502ee3d9.ConvertAsync(localVars.queryResGetFolioFilesByFolioId_outParamList, new RL_1501ee54ff868a67eff67465502ee3d9(), async (RC_28fdb7a8aef891dc921c5fe34393a569 source, ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure target, CancellationToken cancellationToken) => {
target.ssName = source.ssENFolioFiles.ssFilename;
target.ssBinaryData = BuiltInFunction.NullBinary ();
target.ssIsExtra = source.ssENFolioFiles.ssIsExtra;
target.ssStorageId = source.ssENFolioFiles.ssStorageId;
return target;
}, cancellationToken)),cancellationToken);

// List = GetDocumentsListByMinuteType.List
result.outParamList=localVars.resGetDocumentsListByMinuteType.outParamList;
} //close CreateActionActivity using block
} // try

finally {
outParamList = result.outParamList;
outParamFilesList2 = result.outParamFilesList2;
} // inner-finally
RETURN_STATEMENT:
return (outParamList,outParamFilesList2);
}


    public static class FuncDataActionGetOrderMainItems {

// Query Function "GetOrdersItems" ahDvMCMztEGH6ygVBrdQxg of Action "GetOrderMainItems"
public static async Task<(RL_bab3397f952f07af0f0aa229e6f2b36e,long)> QueryGetOrdersItems(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporl_OrderIdSelected,int qpfoi_folioStatusIdCanceled,int qpfoi_folioStatusIdCanceledByProvider,long qpfoi_FolioId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("j_FoliosSAE.Wb_FolioEditConstruction.GetOrderMainItems.GetOrdersItems", "30ef106a-3323-41b4-87eb-281506b750c6");
using var queryActivity = activitySource.CreateSqlQueryActivity("j_FoliosSAE.Wb_FolioEditConstruction.GetOrderMainItems.GetOrdersItems", "30ef106a-3323-41b4-87eb-281506b750c6", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string entityOrderMainItem = AppUtils.Instance.RuntimeEntityReplace("OrderMainItem");
string entityOrderMain = AppUtils.Instance.RuntimeEntityReplace("OrderMain");
string entityFolioItems = AppUtils.Instance.RuntimeEntityReplace("FolioItems");
string entityFolio = AppUtils.Instance.RuntimeEntityReplace("Folio");
string entityCurrency = AppUtils.Instance.RuntimeEntityReplace("Currency");
string entityOrderMainItemStatus = AppUtils.Instance.RuntimeEntityReplace("OrderMainItemStatus");
sqlCmd.CreateParameter("@qpfoi_folioStatusIdCanceled", DbType.Int32, qpfoi_folioStatusIdCanceled);
sqlCmd.CreateParameter("@qpfoi_folioStatusIdCanceledByProvider", DbType.Int32, qpfoi_folioStatusIdCanceledByProvider);
sqlCmd.CreateParameter("@qpfoi_FolioId", DbType.Int64, qpfoi_FolioId);
sqlCmd.CreateParameter("@qporl_OrderIdSelected", DbType.Int64, qporl_OrderIdSelected);
string sql = "";
string advSql = "SELECT  \n    0, \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".Id") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"ordernumber\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"position\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"materialcode\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"materialdescription\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"quantity\"") + ", \n \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"quantitydelivered\"") + " + COALESCE(( \n        SELECT SUM(CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"invoiceqtt\"") + " AS DECIMAL(18,3))) \n        FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,"") + " \n        inner join  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,"") + " on  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"folioid\"") + " \n        WHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"ordermainitemid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"id\"") + " \n        and ( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"foliostatusid\"") + " <> @qpfoi_folioStatusIdCanceled and  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"foliostatusid\"") + " <> @qpfoi_folioStatusIdCanceledByProvider) \n        and  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"id\"") + " <> @qpfoi_FolioId \n    ), 0), \n \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"quantity\"") + " -  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"quantitydelivered\"") + " - COALESCE(( \n        SELECT SUM(CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"invoiceqtt\"") + " AS DECIMAL(18,3))) \n        FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,"") + " \n        inner join  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,"") + " on  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"folioid\"") + " \n        WHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"ordermainitemid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"id\"") + " \n        and ( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"foliostatusid\"") + " <> @qpfoi_folioStatusIdCanceled and  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"foliostatusid\"") + " <> @qpfoi_folioStatusIdCanceledByProvider) \n        and  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"id\"") + " <> @qpfoi_FolioId \n    ), 0), \n \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"orderunitofmeasure\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"code\"") + ", \n \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"unitprice\"") + "* " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"quantity\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItemStatus,".\"label\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItemStatus,".\"class\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"deliverydate\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"unitprice\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"assigmnentcode\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"vatrate\"") + ", \n    COALESCE(( \n        SELECT SUM(CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"totalprice\"") + " AS DECIMAL(18,2))) \n        FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,"") + " \n        inner join  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,"") + " on  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"folioid\"") + " \n        WHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"ordermainitemid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"id\"") + " \n        and ( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"foliostatusid\"") + " <> @qpfoi_folioStatusIdCanceled and  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"foliostatusid\"") + " <> @qpfoi_folioStatusIdCanceledByProvider) \n        and  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"id\"") + " <> @qpfoi_FolioId \n    ), 0), \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"isdeleted\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"isblocked\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"basequantity\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"isfinaldelivery\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"pepelement\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"ismultipleimputation\"") + " \n \n \nFROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,"") + " \nINNER JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,"") + " \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"ordermainid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,"") + " \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"currencyid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"code\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItemStatus,"") + " \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"orderstatusid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItemStatus,".\"id\"") + " \n \nWHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"id\"") + " = @qporl_OrderIdSelected \nand  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"isblocked\"") + " = 0  \nand  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"isdeleted\"") + " = 0 \norder by  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"position\"") + " asc";
sql = advSql;
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_bab3397f952f07af0f0aa229e6f2b36e outParamList = new RL_bab3397f952f07af0f0aa229e6f2b36e();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_FolioEditConstruction.GetOrderMainItems.GetOrdersItems.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_bab3397f952f07af0f0aa229e6f2b36e _tmp = new RL_bab3397f952f07af0f0aa229e6f2b36e();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_FolioEditConstruction.GetOrderMainItems.GetOrdersItems.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_bab3397f952f07af0f0aa229e6f2b36e)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetOrdersItems in GetOrderMainItems in Wb_FolioEditConstruction in j_FoliosSAE in ConectaProveedores (SELECT       0,      {OrderMainItem}.Id,      {OrderMain}.[OrderNumber],      {OrderMainItem}.[Position],      {OrderMainItem}.[MaterialCode],      {OrderMainItem}.[MaterialDescription],      {OrderMainItem}.[Quantity],        {OrderMainItem}.[QuantityDelivered] + COALESCE((          SELECT SUM(CAST({FolioItems}.[InvoiceQtt] AS DECIMAL(18,3)))          FROM {FolioItems}          inner join {Folio} on {Folio}.[Id] = {FolioItems}.[FolioId]          WHERE {FolioItems}.[OrderMainItemId] = {OrderMainItem}.[Id]          and ({Folio}.[FolioStatusId] <> @i_folioStatusIdCanceled and {Folio}.[FolioStatusId] <> @i_folioStatusIdCanceledByProvider)          and {Folio}.[Id] <> @i_FolioId      ), 0),        {OrderMainItem}.[Quantity] - {OrderMainItem}.[QuantityDelivered] - COALESCE((          SELECT SUM(CAST({FolioItems}.[InvoiceQtt] AS DECIMAL(18,3)))          FROM {FolioItems}          inner join {Folio} on {Folio}.[Id] = {FolioItems}.[FolioId]          WHERE {FolioItems}.[OrderMainItemId] = {Orde ...): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetOrdersItems in GetOrderMainItems in Wb_FolioEditConstruction in j_FoliosSAE in ConectaProveedores (SELECT       0,      {OrderMainItem}.Id,      {OrderMain}.[OrderNumber],      {OrderMainItem}.[Position],      {OrderMainItem}.[MaterialCode],      {OrderMainItem}.[MaterialDescription],      {OrderMainItem}.[Quantity],        {OrderMainItem}.[QuantityDelivered] + COALESCE((          SELECT SUM(CAST({FolioItems}.[InvoiceQtt] AS DECIMAL(18,3)))          FROM {FolioItems}          inner join {Folio} on {Folio}.[Id] = {FolioItems}.[FolioId]          WHERE {FolioItems}.[OrderMainItemId] = {OrderMainItem}.[Id]          and ({Folio}.[FolioStatusId] <> @i_folioStatusIdCanceled and {Folio}.[FolioStatusId] <> @i_folioStatusIdCanceledByProvider)          and {Folio}.[Id] <> @i_FolioId      ), 0),        {OrderMainItem}.[Quantity] - {OrderMainItem}.[QuantityDelivered] - COALESCE((          SELECT SUM(CAST({FolioItems}.[InvoiceQtt] AS DECIMAL(18,3)))          FROM {FolioItems}          inner join {Folio} on {Folio}.[Id] = {FolioItems}.[FolioId]          WHERE {FolioItems}.[OrderMainItemId] = {Orde ...): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetOrdersItems in GetOrderMainItems in Wb_FolioEditConstruction in j_FoliosSAE in ConectaProveedores (SELECT       0,      {OrderMainItem}.Id,      {OrderMain}.[OrderNumber],      {OrderMainItem}.[Position],      {OrderMainItem}.[MaterialCode],      {OrderMainItem}.[MaterialDescription],      {OrderMainItem}.[Quantity],        {OrderMainItem}.[QuantityDelivered] + COALESCE((          SELECT SUM(CAST({FolioItems}.[InvoiceQtt] AS DECIMAL(18,3)))          FROM {FolioItems}          inner join {Folio} on {Folio}.[Id] = {FolioItems}.[FolioId]          WHERE {FolioItems}.[OrderMainItemId] = {OrderMainItem}.[Id]          and ({Folio}.[FolioStatusId] <> @i_folioStatusIdCanceled and {Folio}.[FolioStatusId] <> @i_folioStatusIdCanceledByProvider)          and {Folio}.[Id] <> @i_FolioId      ), 0),        {OrderMainItem}.[Quantity] - {OrderMainItem}.[QuantityDelivered] - COALESCE((          SELECT SUM(CAST({FolioItems}.[InvoiceQtt] AS DECIMAL(18,3)))          FROM {FolioItems}          inner join {Folio} on {Folio}.[Id] = {FolioItems}.[FolioId]          WHERE {FolioItems}.[OrderMainItemId] = {Orde ...): " + aqExcep.Message));
}
}
}
}
public static class FuncDataActionGetMinutes {
}
public static class FuncDataActionGetSummary {

// Query Function "GetTotalAmountDelivered" TIyqBcC8LkaBLtxh+DJdsg of Action "GetSummary"
public static async Task<(RL_d3c140b81b16482eac14fd0448f33de5,long)> datasetGetTotalAmountDelivered(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporFolio_OrderId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("j_FoliosSAE.Wb_FolioEditConstruction.GetSummary.GetTotalAmountDelivered", "05aa8c4c-bcc0-462e-812e-dc61f8325db2");
using var queryActivity = activitySource.CreateAggregateQueryActivity("j_FoliosSAE.Wb_FolioEditConstruction.GetSummary.GetTotalAmountDelivered", "05aa8c4c-bcc0-462e-812e-dc61f8325db2", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.3k7KeMC4GECt_82hyM8+jQ/DataActions.ztaIbNTdHUGp98crH9ZAZg/NodesNotShownInESpaceTree.TIyqBcC8LkaBLtxh+DJdsg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT Sum(\"enfolioitems20\".\"totalprice\") \"totalpricesum\"");
fromBuilder.Append(" FROM ({Folio} \"enfolio105\" Left JOIN {FolioItems} \"enfolioitems20\" ON (\"enfolio105\".\"id\" = \"enfolioitems20\".\"folioid\")) ");
whereBuilder.Append(" WHERE ");
if (qporFolio_OrderId != 0) {
whereBuilder.Append("((\"enfolio105\".\"orderid\" = @qporFolio_OrderId) AND (\"enfolio105\".\"orderid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporFolio_OrderId", DbType.Int64, qporFolio_OrderId);
} else {
whereBuilder.Append("(\"enfolio105\".\"orderid\" IS NULL)");
}
whereBuilder.Append(" AND ((\"enfolio105\".\"foliostatusid\" <> ");
whereBuilder.Append((ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("cklscJNc0UyOgKXGwg51TQ"))).ssId);
whereBuilder.Append(") AND (\"enfolio105\".\"foliostatusid\" <> ");
whereBuilder.Append((ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("l5OG661dZEe+gAZwnNLhSA"))).ssId);
whereBuilder.Append("))");
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
RL_d3c140b81b16482eac14fd0448f33de5 outParamList = new RL_d3c140b81b16482eac14fd0448f33de5();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[0];
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_FolioEditConstruction.GetSummary.GetTotalAmountDelivered.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_d3c140b81b16482eac14fd0448f33de5 _tmp = new RL_d3c140b81b16482eac14fd0448f33de5();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_FolioEditConstruction.GetSummary.GetTotalAmountDelivered.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_d3c140b81b16482eac14fd0448f33de5)_tmp;
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

// Query Function "GetTotalFromOriginal" 8chKQrmp+06xKwscJpHVQQ of Action "GetSummary"
public static async Task<(RL_312927afcf3eb9d5fa3bc02bbc91d978,long)> datasetGetTotalFromOriginal(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderMainId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("j_FoliosSAE.Wb_FolioEditConstruction.GetSummary.GetTotalFromOriginal", "424ac8f1-a9b9-4efb-b12b-0b1c2691d541");
using var queryActivity = activitySource.CreateAggregateQueryActivity("j_FoliosSAE.Wb_FolioEditConstruction.GetSummary.GetTotalFromOriginal", "424ac8f1-a9b9-4efb-b12b-0b1c2691d541", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.3k7KeMC4GECt_82hyM8+jQ/DataActions.ztaIbNTdHUGp98crH9ZAZg/NodesNotShownInESpaceTree.8chKQrmp+06xKwscJpHVQQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT Sum((\"enordermainitem37\".\"quantitydelivered\" * (\"enordermainitem37\".\"unitprice\" / cast(\"enordermainitem37\".\"basequantity\" as decimal)))) \"totalsapsum\"");
fromBuilder.Append(" FROM {OrderMainItem} \"enordermainitem37\"");
whereBuilder.Append(" WHERE ");
if (qporOrderMainId != 0) {
whereBuilder.Append("((\"enordermainitem37\".\"ordermainid\" = @qporOrderMainId) AND (\"enordermainitem37\".\"ordermainid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderMainId", DbType.Int64, qporOrderMainId);
} else {
whereBuilder.Append("(\"enordermainitem37\".\"ordermainid\" IS NULL)");
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
RL_312927afcf3eb9d5fa3bc02bbc91d978 outParamList = new RL_312927afcf3eb9d5fa3bc02bbc91d978();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[0];
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_FolioEditConstruction.GetSummary.GetTotalFromOriginal.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_312927afcf3eb9d5fa3bc02bbc91d978 _tmp = new RL_312927afcf3eb9d5fa3bc02bbc91d978();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_FolioEditConstruction.GetSummary.GetTotalFromOriginal.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_312927afcf3eb9d5fa3bc02bbc91d978)_tmp;
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

private static async Task<RC_a074711a91fd2441798a860685e4898b> datasetGetOrderMainByIdReadDbAsync(RC_a074711a91fd2441798a860685e4898b rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENCurrency.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
return rec;
}
// Query Function "GetOrderMainById" 95w0nuhg1kaeshGNacmxqg of Action "GetSummary"
public static async Task<(RL_164e5439119ae8b31002cd319dbe8413,long)> datasetGetOrderMainById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderMain_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("j_FoliosSAE.Wb_FolioEditConstruction.GetSummary.GetOrderMainById", "9e349cf7-60e8-46d6-9eb2-118d69c9b1aa");
using var queryActivity = activitySource.CreateAggregateQueryActivity("j_FoliosSAE.Wb_FolioEditConstruction.GetSummary.GetOrderMainById", "9e349cf7-60e8-46d6-9eb2-118d69c9b1aa", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.3k7KeMC4GECt_82hyM8+jQ/DataActions.ztaIbNTdHUGp98crH9ZAZg/NodesNotShownInESpaceTree.95w0nuhg1kaeshGNacmxqg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"encurrency50\".\"code\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, trim_scale(\"enordermain147\".\"totalamount\"::numeric) o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33");
fromBuilder.Append(" FROM ({OrderMain} \"enordermain147\" Left JOIN {Currency} \"encurrency50\" ON (\"enordermain147\".\"currencyid\" = \"encurrency50\".\"code\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderMain_Id != 0) {
whereBuilder.Append("((\"enordermain147\".\"id\" = @qporOrderMain_Id) AND (\"enordermain147\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderMain_Id", DbType.Int64, qporOrderMain_Id);
} else {
whereBuilder.Append("(\"enordermain147\".\"id\" IS NULL)");
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
RL_164e5439119ae8b31002cd319dbe8413 outParamList = new RL_164e5439119ae8b31002cd319dbe8413();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderMainByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_FolioEditConstruction.GetSummary.GetOrderMainById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_164e5439119ae8b31002cd319dbe8413 _tmp = new RL_164e5439119ae8b31002cd319dbe8413();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderMainByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_FolioEditConstruction.GetSummary.GetOrderMainById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_164e5439119ae8b31002cd319dbe8413)_tmp;
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

// Query Function "GetOrderItemEntries" bCWdw088QECH4dHr5POHKw of Action "GetSummary"
public static async Task<(RL_ecf075efbdf79b05fa564fa6ba80a9c6,long)> datasetGetOrderItemEntries(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderMain_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("j_FoliosSAE.Wb_FolioEditConstruction.GetSummary.GetOrderItemEntries", "c39d256c-3c4f-4040-87e1-d1ebe4f3872b");
using var queryActivity = activitySource.CreateAggregateQueryActivity("j_FoliosSAE.Wb_FolioEditConstruction.GetSummary.GetOrderItemEntries", "c39d256c-3c4f-4040-87e1-d1ebe4f3872b", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.3k7KeMC4GECt_82hyM8+jQ/DataActions.ztaIbNTdHUGp98crH9ZAZg/NodesNotShownInESpaceTree.bCWdw088QECH4dHr5POHKw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT Sum((\"enorderitementries9\".\"quantity_\" * (\"enordermainitem38\".\"unitprice\" / cast(\"enordermainitem38\".\"basequantity\" as decimal)))) \"totalsum\"");
fromBuilder.Append(" FROM (({OrderItemEntries} \"enorderitementries9\" Inner JOIN {OrderMainItem} \"enordermainitem38\" ON (\"enorderitementries9\".\"ordermainitemid\" = \"enordermainitem38\".\"id\"))  Inner JOIN {OrderMain} \"enordermain148\" ON (\"enordermainitem38\".\"ordermainid\" = \"enordermain148\".\"id\")) ");
whereBuilder.Append(" WHERE (\"enorderitementries9\".\"quantity_\" > cast(0 as decimal)) AND ");
if (qporOrderMain_Id != 0) {
whereBuilder.Append("((\"enordermain148\".\"id\" = @qporOrderMain_Id) AND (\"enordermain148\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderMain_Id", DbType.Int64, qporOrderMain_Id);
} else {
whereBuilder.Append("(\"enordermain148\".\"id\" IS NULL)");
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
RL_ecf075efbdf79b05fa564fa6ba80a9c6 outParamList = new RL_ecf075efbdf79b05fa564fa6ba80a9c6();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[0];
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_FolioEditConstruction.GetSummary.GetOrderItemEntries.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_ecf075efbdf79b05fa564fa6ba80a9c6 _tmp = new RL_ecf075efbdf79b05fa564fa6ba80a9c6();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_FolioEditConstruction.GetSummary.GetOrderItemEntries.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_ecf075efbdf79b05fa564fa6ba80a9c6)_tmp;
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
public static class FuncDataActionGetMinutesDocuments {

// Query Function "GetFolioFilesByFolioId" ZyhL7K30i06yh6mKXlUC3Q of Action "GetMinutesDocuments"
public static async Task<(RL_897c95bca5499c293930e47bf793d0d9,long)> datasetGetFolioFilesByFolioId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolioId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("j_FoliosSAE.Wb_FolioEditConstruction.GetMinutesDocuments.GetFolioFilesByFolioId", "ec4b2867-f4ad-4e8b-b287-a98a5e5502dd");
using var queryActivity = activitySource.CreateAggregateQueryActivity("j_FoliosSAE.Wb_FolioEditConstruction.GetMinutesDocuments.GetFolioFilesByFolioId", "ec4b2867-f4ad-4e8b-b287-a98a5e5502dd", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.3k7KeMC4GECt_82hyM8+jQ/DataActions.kqiDkFE+EEGjIhKtjQk23g/NodesNotShownInESpaceTree.ZyhL7K30i06yh6mKXlUC3Q, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enfoliofiles11\".\"filename\" o1, NULL o2, \"enfoliofiles11\".\"isextra\" o3, \"enfoliofiles11\".\"storageid\" o4, NULL o5, NULL o6, NULL o7");
fromBuilder.Append(" FROM {FolioFiles} \"enfoliofiles11\"");
whereBuilder.Append(" WHERE ");
if (qpfoFolioId != 0) {
whereBuilder.Append("((\"enfoliofiles11\".\"folioid\" = @qpfoFolioId) AND (\"enfoliofiles11\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioId", DbType.Int64, qpfoFolioId);
} else {
whereBuilder.Append("(\"enfoliofiles11\".\"folioid\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"enfoliofiles11\".\"filename\" ASC ");
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
RL_897c95bca5499c293930e47bf793d0d9 outParamList = new RL_897c95bca5499c293930e47bf793d0d9();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, false, true, false, false, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_FolioEditConstruction.GetMinutesDocuments.GetFolioFilesByFolioId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_897c95bca5499c293930e47bf793d0d9 _tmp = new RL_897c95bca5499c293930e47bf793d0d9();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_FolioEditConstruction.GetMinutesDocuments.GetFolioFilesByFolioId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_897c95bca5499c293930e47bf793d0d9)_tmp;
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
