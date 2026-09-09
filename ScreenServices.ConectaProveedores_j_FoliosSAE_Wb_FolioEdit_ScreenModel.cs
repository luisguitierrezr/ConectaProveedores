using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_j_FoliosSAE_Wb_FolioEdit_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_j_FoliosSAE_Wb_FolioEdit_ScreenModel).Namespace);

    public long inParamFolioId;
public long inParami_OrderId;
public RL_123aa03224ec08dab8cbe26021987012 inParami_LocalSelectedLines;
public RC_0b2176705fa164c9531eb643caf0e9d4 varLcl_SummaryRec;
public bool varLcWithDatesError;
public bool varLcWithQuantityError;
public bool varLcWithFilesError;
public bool varLcDatesQuantityPEPError;
public bool varLcWithprorata;
public string varLcfirstUserIdentifier;
public string varLcComments;
public EN_d1d0320db36efbb094ad0082361435a0EntityRecord varLcInvoiceToCreate;
public ST_6f620840109ac6f721328b723ec0152cStructure varLcInvoiceForeignToCreate;
public RL_1501ee54ff868a67eff67465502ee3d9 varLcFilesList;
public RL_1501ee54ff868a67eff67465502ee3d9 varLcFilesListExtra;
public bool varLcApproverValid;
public string varLcApproverErrorMessage;
public bool varLcMaxAmountError;
public RL_123aa03224ec08dab8cbe26021987012 varLcLocalSelectedLines;
public decimal varLcl_ImportAnticipo;
public RL_1501ee54ff868a67eff67465502ee3d9 varLcCreditNoteFilesList;
public bool varLcl_IsOpenPopup;
public string varLcl_IsOpenPopupComment;
public bool varLcHaveNewFiles;
public string varLcNewFileNamesUploaded;
public bool varLcL_IsNational;
public EN_d1d0320db36efbb094ad0082361435a0EntityRecord varLcCreditNoteInvoiceToCreate;
public bool varLcCreditNote_IsNeeded;
public EN_f81a3d226103fd013068b8763798067aEntityRecord varLcInvoiceExtendedToCreate;
public long varLcOrderAccConceptsIdToCreate;
public AggregateRecord<RL_5fec0894721bcc83c763c610a52bfbfd> ScreenDataSetGetFolioCommentsByFolioId;
public AggregateRecord<RL_4d304652a66e6de5c7b4ce65fcc7c50b> ScreenDataSetGetApprovalList;
public AggregateRecord<RL_4f8b259bdd04db22be8fb771f1ad1d4f> ScreenDataSetGetFolioById;
public AggregateRecord<RL_a968cf9f63475dc9358672149b11245a> ScreenDataSetGetFolioItemsByFolioId;
public AggregateRecord<RL_994583bfe1c92160ce9fe58b4f4e0d70> ScreenDataSetGetFolioObservationsByFolioId;
public AggregateRecord<RL_398a2e7b47dcd31617b8f6499aea0bce> ScreenDataSetGetOrderDetail;
public ConectaProveedores_j_FoliosSAE_Wb_FolioEdit_DataActionGetOrderMainItems_Model varLcGetOrderMainItems;
public ConectaProveedores_j_FoliosSAE_Wb_FolioEdit_DataActionGetSummary_Model varLcGetSummary;
public ConectaProveedores_j_FoliosSAE_Wb_FolioEdit_DataActionGetSettings_Model varLcGetSettings;
public ConectaProveedores_j_FoliosSAE_Wb_FolioEdit_DataActionGetFolioFiles_Model varLcGetFolioFiles;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_j_FoliosSAE_Wb_FolioEdit_ScreenModel() {
}



    public ConectaProveedores_j_FoliosSAE_Wb_FolioEdit_ScreenModel(long inParamFolioId, long inParami_OrderId, RL_123aa03224ec08dab8cbe26021987012 inParami_LocalSelectedLines, RC_0b2176705fa164c9531eb643caf0e9d4 varLcl_SummaryRec, bool varLcWithDatesError, bool varLcWithQuantityError, bool varLcWithFilesError, bool varLcDatesQuantityPEPError, bool varLcWithprorata, string varLcfirstUserIdentifier, string varLcComments, EN_d1d0320db36efbb094ad0082361435a0EntityRecord varLcInvoiceToCreate, ST_6f620840109ac6f721328b723ec0152cStructure varLcInvoiceForeignToCreate, RL_1501ee54ff868a67eff67465502ee3d9 varLcFilesList, RL_1501ee54ff868a67eff67465502ee3d9 varLcFilesListExtra, bool varLcApproverValid, string varLcApproverErrorMessage, bool varLcMaxAmountError, RL_123aa03224ec08dab8cbe26021987012 varLcLocalSelectedLines, decimal varLcl_ImportAnticipo, RL_1501ee54ff868a67eff67465502ee3d9 varLcCreditNoteFilesList, bool varLcl_IsOpenPopup, string varLcl_IsOpenPopupComment, bool varLcHaveNewFiles, string varLcNewFileNamesUploaded, bool varLcL_IsNational, EN_d1d0320db36efbb094ad0082361435a0EntityRecord varLcCreditNoteInvoiceToCreate, bool varLcCreditNote_IsNeeded, EN_f81a3d226103fd013068b8763798067aEntityRecord varLcInvoiceExtendedToCreate, long varLcOrderAccConceptsIdToCreate, AggregateRecord<RL_5fec0894721bcc83c763c610a52bfbfd> ScreenDataSetGetFolioCommentsByFolioId, AggregateRecord<RL_4d304652a66e6de5c7b4ce65fcc7c50b> ScreenDataSetGetApprovalList, AggregateRecord<RL_4f8b259bdd04db22be8fb771f1ad1d4f> ScreenDataSetGetFolioById, AggregateRecord<RL_a968cf9f63475dc9358672149b11245a> ScreenDataSetGetFolioItemsByFolioId, AggregateRecord<RL_994583bfe1c92160ce9fe58b4f4e0d70> ScreenDataSetGetFolioObservationsByFolioId, AggregateRecord<RL_398a2e7b47dcd31617b8f6499aea0bce> ScreenDataSetGetOrderDetail, ConectaProveedores_j_FoliosSAE_Wb_FolioEdit_DataActionGetOrderMainItems_Model varLcGetOrderMainItems, ConectaProveedores_j_FoliosSAE_Wb_FolioEdit_DataActionGetSummary_Model varLcGetSummary, ConectaProveedores_j_FoliosSAE_Wb_FolioEdit_DataActionGetSettings_Model varLcGetSettings, ConectaProveedores_j_FoliosSAE_Wb_FolioEdit_DataActionGetFolioFiles_Model varLcGetFolioFiles, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"FolioId", "i_OrderId", "i_LocalSelectedLines", "l_SummaryRec", "WithDatesError", "WithQuantityError", "WithFilesError", "DatesQuantityPEPError", "Withprorata", "firstUserIdentifier", "Comments", "InvoiceToCreate", "InvoiceForeignToCreate", "FilesList", "FilesListExtra", "ApproverValid", "ApproverErrorMessage", "MaxAmountError", "LocalSelectedLines", "l_ImportAnticipo", "CreditNoteFilesList", "l_IsOpenPopup", "l_IsOpenPopupComment", "HaveNewFiles", "NewFileNamesUploaded", "L_IsNational", "CreditNoteInvoiceToCreate", "CreditNote_IsNeeded", "InvoiceExtendedToCreate", "OrderAccConceptsIdToCreate", "GetFolioCommentsByFolioId", "GetApprovalList", "GetFolioById", "GetFolioItemsByFolioId", "GetFolioObservationsByFolioId", "GetOrderDetail", "GetOrderMainItems", "GetSummary", "GetSettings", "GetFolioFiles", "ClientVars"}, new string[] {"inParamFolioId", "inParami_OrderId", "inParami_LocalSelectedLines", "varLcl_SummaryRec", "varLcWithDatesError", "varLcWithQuantityError", "varLcWithFilesError", "varLcDatesQuantityPEPError", "varLcWithprorata", "varLcfirstUserIdentifier", "varLcComments", "varLcInvoiceToCreate", "varLcInvoiceForeignToCreate", "varLcFilesList", "varLcFilesListExtra", "varLcApproverValid", "varLcApproverErrorMessage", "varLcMaxAmountError", "varLcLocalSelectedLines", "varLcl_ImportAnticipo", "varLcCreditNoteFilesList", "varLcl_IsOpenPopup", "varLcl_IsOpenPopupComment", "varLcHaveNewFiles", "varLcNewFileNamesUploaded", "varLcL_IsNational", "varLcCreditNoteInvoiceToCreate", "varLcCreditNote_IsNeeded", "varLcInvoiceExtendedToCreate", "varLcOrderAccConceptsIdToCreate", "ScreenDataSetGetFolioCommentsByFolioId", "ScreenDataSetGetApprovalList", "ScreenDataSetGetFolioById", "ScreenDataSetGetFolioItemsByFolioId", "ScreenDataSetGetFolioObservationsByFolioId", "ScreenDataSetGetOrderDetail", "varLcGetOrderMainItems", "varLcGetSummary", "varLcGetSettings", "varLcGetFolioFiles", "clientVariables"});
this.inParamFolioId = inParamFolioId;
this.inParami_OrderId = inParami_OrderId;
this.inParami_LocalSelectedLines = inParami_LocalSelectedLines;
this.varLcl_SummaryRec = varLcl_SummaryRec;
this.varLcWithDatesError = varLcWithDatesError;
this.varLcWithQuantityError = varLcWithQuantityError;
this.varLcWithFilesError = varLcWithFilesError;
this.varLcDatesQuantityPEPError = varLcDatesQuantityPEPError;
this.varLcWithprorata = varLcWithprorata;
this.varLcfirstUserIdentifier = varLcfirstUserIdentifier;
this.varLcComments = varLcComments;
this.varLcInvoiceToCreate = varLcInvoiceToCreate;
this.varLcInvoiceForeignToCreate = varLcInvoiceForeignToCreate;
this.varLcFilesList = varLcFilesList;
this.varLcFilesListExtra = varLcFilesListExtra;
this.varLcApproverValid = varLcApproverValid;
this.varLcApproverErrorMessage = varLcApproverErrorMessage;
this.varLcMaxAmountError = varLcMaxAmountError;
this.varLcLocalSelectedLines = varLcLocalSelectedLines;
this.varLcl_ImportAnticipo = varLcl_ImportAnticipo;
this.varLcCreditNoteFilesList = varLcCreditNoteFilesList;
this.varLcl_IsOpenPopup = varLcl_IsOpenPopup;
this.varLcl_IsOpenPopupComment = varLcl_IsOpenPopupComment;
this.varLcHaveNewFiles = varLcHaveNewFiles;
this.varLcNewFileNamesUploaded = varLcNewFileNamesUploaded;
this.varLcL_IsNational = varLcL_IsNational;
this.varLcCreditNoteInvoiceToCreate = varLcCreditNoteInvoiceToCreate;
this.varLcCreditNote_IsNeeded = varLcCreditNote_IsNeeded;
this.varLcInvoiceExtendedToCreate = varLcInvoiceExtendedToCreate;
this.varLcOrderAccConceptsIdToCreate = varLcOrderAccConceptsIdToCreate;
this.ScreenDataSetGetFolioCommentsByFolioId = ScreenDataSetGetFolioCommentsByFolioId;
this.ScreenDataSetGetApprovalList = ScreenDataSetGetApprovalList;
this.ScreenDataSetGetFolioById = ScreenDataSetGetFolioById;
this.ScreenDataSetGetFolioItemsByFolioId = ScreenDataSetGetFolioItemsByFolioId;
this.ScreenDataSetGetFolioObservationsByFolioId = ScreenDataSetGetFolioObservationsByFolioId;
this.ScreenDataSetGetOrderDetail = ScreenDataSetGetOrderDetail;
this.varLcGetOrderMainItems = varLcGetOrderMainItems;
this.varLcGetSummary = varLcGetSummary;
this.varLcGetSettings = varLcGetSettings;
this.varLcGetFolioFiles = varLcGetFolioFiles;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_03baaf9011c29c7810216c701048afb6> datasetGetFolioCommentsByFolioIdReadDbAsync(RC_03baaf9011c29c7810216c701048afb6 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENCommentType.Read( r, ref index);
rec.ssENFolioComment.Read( r, ref index);
return rec;
}
// Query Function "GetFolioCommentsByFolioId" DGkpHTrixEW_gqrsnyw8MQ of Action "Wb_FolioEdit"
public static async Task<(RL_5fec0894721bcc83c763c610a52bfbfd,long)> datasetGetFolioCommentsByFolioId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolioComment_FolioId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.Wb_FolioEdit.GetFolioCommentsByFolioId", "1d29690c-e23a-45c4-bf82-aaec9f2c3c31");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_FolioEdit","j_FoliosSAE.Wb_FolioEdit.GetFolioCommentsByFolioId");
// Query Iterations: Never
// Refresh Query jXw5lgoI6USvMHTFBb+EUw Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.mdpkayXiA0u0IlWRNf05ew/ScreenDataSets.DGkpHTrixEW_gqrsnyw8MQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, \"enfoliocomment2\".\"message\" o12, NULL o13");
fromBuilder.Append(" FROM ({FolioComment} \"enfoliocomment2\" Left JOIN {CommentType} \"encommenttype2\" ON (\"enfoliocomment2\".\"commenttypeid\" = \"encommenttype2\".\"id\")) ");
whereBuilder.Append(" WHERE (\"encommenttype2\".\"id\" = ");
whereBuilder.Append((ENCommentTypeEntity.GetRecordByKey(ObjectKey.Parse("fWPpinJz1EuuskuhosoYJA"))).ssId);
whereBuilder.Append(") AND ");
if (qpfoFolioComment_FolioId != 0) {
whereBuilder.Append("((\"enfoliocomment2\".\"folioid\" = @qpfoFolioComment_FolioId) AND (\"enfoliocomment2\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioComment_FolioId", DbType.Int64, qpfoFolioComment_FolioId);
} else {
whereBuilder.Append("(\"enfoliocomment2\".\"folioid\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"enfoliocomment2\".\"id\" DESC ");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_FolioEdit.GetFolioCommentsByFolioId.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_FolioEdit.GetFolioCommentsByFolioId.List", cancellationToken: cancellationToken);
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

private static async Task<RC_79a64780c4264a7ff3588d1347b5f259> datasetGetApprovalListReadDbAsync(RC_79a64780c4264a7ff3588d1347b5f259 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENEntraRole.Read( r, ref index);
rec.ssENTelcelDirection.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
return rec;
}
// Query Function "GetApprovalList" GJLmLVzHiUS5smk49DFrAA of Action "Wb_FolioEdit"
public static async Task<(RL_4d304652a66e6de5c7b4ce65fcc7c50b,long)> datasetGetApprovalList(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpteTelcelDirection_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.Wb_FolioEdit.GetApprovalList", "2de69218-c75c-4489-b9b2-6938f4316b00");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_FolioEdit","j_FoliosSAE.Wb_FolioEdit.GetApprovalList");
// Query Iterations: Never
// Refresh Query k_Y3S9Da1EGWo+54SJmtOQ Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.mdpkayXiA0u0IlWRNf05ew/ScreenDataSets.GJLmLVzHiUS5smk49DFrAA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37");
fromBuilder.Append(" FROM ((({TelcelDirection} \"entelceldirection16\" Inner JOIN {User_Extended_Internal} \"enuser_extended_internal139\" ON (\"entelceldirection16\".\"id\" = \"enuser_extended_internal139\".\"telceldirectionid\"))  Left JOIN {User} \"enuser240\" ON (\"enuser_extended_internal139\".\"id\" = \"enuser240\".\"id\"))  Inner JOIN {EntraRole} \"enentrarole84\" ON (\"enuser_extended_internal139\".\"entraroleid\" = \"enentrarole84\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpteTelcelDirection_Id != 0) {
whereBuilder.Append("((\"entelceldirection16\".\"id\" = @qpteTelcelDirection_Id) AND (\"entelceldirection16\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpteTelcelDirection_Id", DbType.Int64, qpteTelcelDirection_Id);
} else {
whereBuilder.Append("(\"entelceldirection16\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (\"enentrarole84\".\"isareausuaria\" = 1)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_FolioEdit.GetApprovalList.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_FolioEdit.GetApprovalList.List", cancellationToken: cancellationToken);
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

// Query Function "GetFolioById" xFDHOQXOL0ihh7ZH8Rk5Wg of Action "Wb_FolioEdit"
public static async Task<(RL_4f8b259bdd04db22be8fb771f1ad1d4f,long)> datasetGetFolioById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.Wb_FolioEdit.GetFolioById", "39c750c4-ce05-482f-a187-b647f119395a");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_FolioEdit","j_FoliosSAE.Wb_FolioEdit.GetFolioById");
// Query Iterations: Never
// Refresh Query dGa9cRpP90iIyLK82rpmsg Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.mdpkayXiA0u0IlWRNf05ew/ScreenDataSets.xFDHOQXOL0ihh7ZH8Rk5Wg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, \"enfolio98\".\"foliostatusid\" o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19");
fromBuilder.Append(" FROM {Folio} \"enfolio98\"");
whereBuilder.Append(" WHERE ");
if (qpfoId != 0) {
whereBuilder.Append("((\"enfolio98\".\"id\" = @qpfoId) AND (\"enfolio98\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoId", DbType.Int64, qpfoId);
} else {
whereBuilder.Append("(\"enfolio98\".\"id\" IS NULL)");
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
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_FolioEdit.GetFolioById.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_FolioEdit.GetFolioById.List", cancellationToken: cancellationToken);
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

private static async Task<RC_95110bc97f34f4c1561c8cbf2b5015b2> datasetGetFolioItemsByFolioIdReadDbAsync(RC_95110bc97f34f4c1561c8cbf2b5015b2 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolio.Read( r, ref index);
rec.ssENFolioItems.Read( r, ref index);
rec.ssENOrderMainItem.Read( r, ref index);
return rec;
}
// Query Function "GetFolioItemsByFolioId" QXb9j1SD7UCanA_xmMzqww of Action "Wb_FolioEdit"
public static async Task<(RL_a968cf9f63475dc9358672149b11245a,long)> datasetGetFolioItemsByFolioId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolioItems_FolioId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.Wb_FolioEdit.GetFolioItemsByFolioId", "8ffd7641-8354-40ed-9a9c-0ff198cceac3");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_FolioEdit","j_FoliosSAE.Wb_FolioEdit.GetFolioItemsByFolioId");
// Query Iterations: Multiple
// Refresh Query weniXRv8HESmmN7RDHYqKw Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.mdpkayXiA0u0IlWRNf05ew/ScreenDataSets.QXb9j1SD7UCanA_xmMzqww, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enfolio99\".\"id\" o0, \"enfolio99\".\"isdraft\" o1, \"enfolio99\".\"folionumber\" o2, \"enfolio99\".\"canproveedorcancel\" o3, \"enfolio99\".\"orderid\" o4, \"enfolio99\".\"supplierid\" o5, \"enfolio99\".\"companyid\" o6, \"enfolio99\".\"foliostatusid\" o7, trim_scale(\"enfolio99\".\"totalamount\"::numeric) o8, trim_scale(\"enfolio99\".\"totaliva_amount\"::numeric) o9, trim_scale(\"enfolio99\".\"partialamount\"::numeric) o10, \"enfolio99\".\"currencyid\" o11, \"enfolio99\".\"firstapproveruserid\" o12, \"enfolio99\".\"approvalprocesstypeid\" o13, \"enfolio99\".\"sapentryerror\" o14, \"enfolio99\".\"createdby\" o15, \"enfolio99\".\"createdon\" o16, \"enfolio99\".\"updatedby\" o17, \"enfolio99\".\"updatedon\" o18, \"enfolio99\".\"minuteselected\" o19, \"enfolioitems16\".\"id\" o20, \"enfolioitems16\".\"folioid\" o21, \"enfolioitems16\".\"ordermainitemid\" o22, \"enfolioitems16\".\"ordernumber\" o23, \"enfolioitems16\".\"articlenumber\" o24, \"enfolioitems16\".\"description\" o25, \"enfolioitems16\".\"inputationcode\" o26, \"enfolioitems16\".\"deliverydate\" o27, trim_scale(\"enfolioitems16\".\"invoiceqtt\"::numeric) o28, trim_scale(\"enfolioitems16\".\"remainingqtt\"::numeric) o29, trim_scale(\"enfolioitems16\".\"unitprice\"::numeric) o30, trim_scale(\"enfolioitems16\".\"totalprice\"::numeric) o31, trim_scale(\"enfolioitems16\".\"quantity\"::numeric) o32, \"enfolioitems16\".\"deliveryqtt\" o33, \"enfolioitems16\".\"importdelivery\" o34, \"enfolioitems16\".\"pep\" o35, \"enfolioitems16\".\"placeid\" o36, \"enfolioitems16\".\"placename\" o37, \"enordermainitem31\".\"id\" o38, \"enordermainitem31\".\"ordermainid\" o39, \"enordermainitem31\".\"position\" o40, \"enordermainitem31\".\"materialcode\" o41, \"enordermainitem31\".\"materialdescription\" o42, \"enordermainitem31\".\"assigmnentcode\" o43, \"enordermainitem31\".\"documentclassid\" o44, \"enordermainitem31\".\"deliverydate\" o45, trim_scale(\"enordermainitem31\".\"quantity\"::numeric) o46, \"enordermainitem31\".\"unittype\" o47, trim_scale(\"enordermainitem31\".\"unitprice\"::numeric) o48, \"enordermainitem31\".\"basequantity\" o49, \"enordermainitem31\".\"isdeleted\" o50, \"enordermainitem31\".\"isblocked\" o51, \"enordermainitem31\".\"isfinaldelivery\" o52, \"enordermainitem31\".\"glaccountid\" o53, \"enordermainitem31\".\"costcenterid\" o54, \"enordermainitem31\".\"fundscenter\" o55, \"enordermainitem31\".\"fund\" o56, \"enordermainitem31\".\"commitmentitem\" o57, \"enordermainitem31\".\"vatindicator\" o58, \"enordermainitem31\".\"vatprocedure\" o59, trim_scale(\"enordermainitem31\".\"vatrate\"::numeric) o60, \"enordermainitem31\".\"purchaserequisitionnumber\" o61, \"enordermainitem31\".\"purchaserequisitionitemnr\" o62, \"enordermainitem31\".\"regionid\" o63, \"enordermainitem31\".\"center\" o64, \"enordermainitem31\".\"pepelement\" o65, trim_scale(\"enordermainitem31\".\"quantitydelivered\"::numeric) o66, \"enordermainitem31\".\"orderunitofmeasure\" o67, \"enordermainitem31\".\"applicant\" o68, \"enordermainitem31\".\"direction\" o69, \"enordermainitem31\".\"contractnumber\" o70, \"enordermainitem31\".\"contractposition\" o71, \"enordermainitem31\".\"contractstartdate\" o72, \"enordermainitem31\".\"contractenddate\" o73, trim_scale(\"enordermainitem31\".\"contractplannedvalue\"::numeric) o74, \"enordermainitem31\".\"positiontype\" o75, \"enordermainitem31\".\"serialnumberprofile\" o76, \"enordermainitem31\".\"batchmanaged\" o77, \"enordermainitem31\".\"materialtype\" o78, \"enordermainitem31\".\"itemgroup\" o79, \"enordermainitem31\".\"orderrequestcreatorsapnumber\" o80, \"enordermainitem31\".\"ismultipleimputation\" o81, \"enordermainitem31\".\"invoiceusageid\" o82, \"enordermainitem31\".\"ordermainitemstatusid\" o83, \"enordermainitem31\".\"divisionid\" o84, \"enordermainitem31\".\"createdby\" o85, \"enordermainitem31\".\"createdon\" o86, \"enordermainitem31\".\"updatedby\" o87, \"enordermainitem31\".\"updatedon\" o88");
fromBuilder.Append(" FROM (({FolioItems} \"enfolioitems16\" Inner JOIN {OrderMainItem} \"enordermainitem31\" ON (\"enfolioitems16\".\"ordermainitemid\" = \"enordermainitem31\".\"id\"))  Left JOIN {Folio} \"enfolio99\" ON (\"enfolioitems16\".\"folioid\" = \"enfolio99\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoFolioItems_FolioId != 0) {
whereBuilder.Append("((\"enfolioitems16\".\"folioid\" = @qpfoFolioItems_FolioId) AND (\"enfolioitems16\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioItems_FolioId", DbType.Int64, qpfoFolioItems_FolioId);
} else {
whereBuilder.Append("(\"enfolioitems16\".\"folioid\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_FolioEdit.GetFolioItemsByFolioId.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_FolioEdit.GetFolioItemsByFolioId.List", cancellationToken: cancellationToken);
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

// Query Function "GetFolioObservationsByFolioId" gjeV3Bgzb02gnBsjmjEqIA of Action "Wb_FolioEdit"
public static async Task<(RL_994583bfe1c92160ce9fe58b4f4e0d70,long)> datasetGetFolioObservationsByFolioId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolioId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.Wb_FolioEdit.GetFolioObservationsByFolioId", "dc953782-3318-4d6f-a09c-1b239a312a20");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_FolioEdit","j_FoliosSAE.Wb_FolioEdit.GetFolioObservationsByFolioId");
// Query Iterations: Multiple
// Refresh Query IO5vOGvv0EiQefK14tdlJA Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.mdpkayXiA0u0IlWRNf05ew/ScreenDataSets.gjeV3Bgzb02gnBsjmjEqIA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"enfolioobservations2\".\"observation\" o2, NULL o3, \"enfolioobservations2\".\"createdon\" o4");
fromBuilder.Append(" FROM {FolioObservations} \"enfolioobservations2\"");
whereBuilder.Append(" WHERE ");
if (qpfoFolioId != 0) {
whereBuilder.Append("((\"enfolioobservations2\".\"folioid\" = @qpfoFolioId) AND (\"enfolioobservations2\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioId", DbType.Int64, qpfoFolioId);
} else {
whereBuilder.Append("(\"enfolioobservations2\".\"folioid\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"enfolioobservations2\".\"createdon\" DESC ");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_FolioEdit.GetFolioObservationsByFolioId.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_FolioEdit.GetFolioObservationsByFolioId.List", cancellationToken: cancellationToken);
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
// Query Function "GetOrderDetail" wJQW6CHM_kO7bM5lvgzahw of Action "Wb_FolioEdit"
public static async Task<(RL_398a2e7b47dcd31617b8f6499aea0bce,long)> datasetGetOrderDetail(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderMain_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.Wb_FolioEdit.GetOrderDetail", "e81694c0-cc21-43fe-bb6c-ce65be0cda87");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_FolioEdit","j_FoliosSAE.Wb_FolioEdit.GetOrderDetail");
// Query Iterations: Never
// Refresh Query Dc1MqsIw40aGmAXvMqsGMA Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.mdpkayXiA0u0IlWRNf05ew/ScreenDataSets.wJQW6CHM_kO7bM5lvgzahw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, \"enordermain139\".\"ordernumber\" o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, \"enordermain139\".\"telceldirectionid\" o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, NULL o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, NULL o118, NULL o119, NULL o120, NULL o121, NULL o122, NULL o123, NULL o124, NULL o125, NULL o126, NULL o127, NULL o128");
fromBuilder.Append(" FROM ((((({OrderMain} \"enordermain139\" Inner JOIN {Supplier} \"ensupplier142\" ON (\"enordermain139\".\"supplierid\" = \"ensupplier142\".\"id\"))  Left JOIN {OrderDetail} \"enorderdetail22\" ON (\"enordermain139\".\"id\" = \"enorderdetail22\".\"orderid\"))  Left JOIN {PaymentMethods} \"enpaymentmethods14\" ON (\"enorderdetail22\".\"paymentmethodid\" = \"enpaymentmethods14\".\"id\"))  Left JOIN {PaymentTerms} \"enpaymentterms34\" ON (\"enorderdetail22\".\"paymenttermsid\" = \"enpaymentterms34\".\"id\"))  Left JOIN {Region} \"enregion189\" ON (\"enordermain139\".\"regionid\" = \"enregion189\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderMain_Id != 0) {
whereBuilder.Append("((\"enordermain139\".\"id\" = @qporOrderMain_Id) AND (\"enordermain139\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderMain_Id", DbType.Int64, qporOrderMain_Id);
} else {
whereBuilder.Append("(\"enordermain139\".\"id\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_FolioEdit.GetOrderDetail.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_FolioEdit.GetOrderDetail.List", cancellationToken: cancellationToken);
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
ConectaProveedores_j_FoliosSAE_Wb_FolioEdit_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetOrderMainItems", "2e7f8d38-5631-4924-8dd8-3e2ed90f42ca"))
using (activitySource.CreateScreenDataActionActivity("Wb_FolioEdit", "GetOrderMainItems")){
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
public class lcvGetSummary : VarsBag {
public RL_164e5439119ae8b31002cd319dbe8413 queryResGetOrderMainById_outParamList = new RL_164e5439119ae8b31002cd319dbe8413();
public long queryResGetOrderMainById_outParamCount = 0L;

public RL_d3c140b81b16482eac14fd0448f33de5 queryResGetTotalAmountDelivered_outParamList = new RL_d3c140b81b16482eac14fd0448f33de5();
public long queryResGetTotalAmountDelivered_outParamCount = 0L;

public RL_ecf075efbdf79b05fa564fa6ba80a9c6 queryResGetOrderItemEntries_outParamList = new RL_ecf075efbdf79b05fa564fa6ba80a9c6();
public long queryResGetOrderItemEntries_outParamCount = 0L;

public RL_312927afcf3eb9d5fa3bc02bbc91d978 queryResGetTotalFromOriginal_outParamList = new RL_312927afcf3eb9d5fa3bc02bbc91d978();
public long queryResGetTotalFromOriginal_outParamCount = 0L;

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
ConectaProveedores_j_FoliosSAE_Wb_FolioEdit_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetSummary", "3d93549c-ea4d-48fb-8e46-e36d113bf694"))
using (activitySource.CreateScreenDataActionActivity("Wb_FolioEdit", "GetSummary")){
// Query datasetGetOrderMainById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderMainById_maxRecords = 0;
int datasetGetOrderMainById_startIndex = 0;(localVars.queryResGetOrderMainById_outParamList,localVars.queryResGetOrderMainById_outParamCount) = await FuncDataActionGetSummary.datasetGetOrderMainById(requestContext,datasetGetOrderMainById_maxRecords,datasetGetOrderMainById_startIndex,IterationMultiplicity.Never,inParami_OrderId,cancellationToken);

// Query datasetGetTotalAmountDelivered
cancellationToken.ThrowIfCancellationRequested();
int datasetGetTotalAmountDelivered_maxRecords = 0;
int datasetGetTotalAmountDelivered_startIndex = 0;(localVars.queryResGetTotalAmountDelivered_outParamList,localVars.queryResGetTotalAmountDelivered_outParamCount) = await FuncDataActionGetSummary.datasetGetTotalAmountDelivered(requestContext,datasetGetTotalAmountDelivered_maxRecords,datasetGetTotalAmountDelivered_startIndex,IterationMultiplicity.Never,inParamFolioId,inParami_OrderId,cancellationToken);

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

// o_SummaryRec.PercentageDelivered = Round
result.outParamo_SummaryRec.ssPercentageDelivered = BuiltInFunction.Round ((((((localVars.queryResGetOrderMainById_outParamList.CurrentRec.ssENOrderMain.ssTotalAmount+localVars.queryResGetTotalFromOriginal_outParamList.CurrentRec.ssTotalSAPSum)+localVars.queryResGetOrderItemEntries_outParamList.CurrentRec.ssTotalSum)==(((decimal)0)))) ? ((((decimal)0))) : ((((decimal)((localVars.queryResGetTotalAmountDelivered_outParamList.CurrentRec.ssTotalPriceSum+localVars.queryResGetTotalFromOriginal_outParamList.CurrentRec.ssTotalSAPSum)+localVars.queryResGetOrderItemEntries_outParamList.CurrentRec.ssTotalSum)/
(decimal)localVars.queryResGetOrderMainById_outParamList.CurrentRec.ssENOrderMain.ssTotalAmount)*(((decimal)100))))), 3);

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
public class lcvGetSettings : VarsBag {
public Actions.lcoGetSettingsMargins resGetSettingsMargins =  new Actions.lcoGetSettingsMargins();
public lcvGetSettings() {
}
}
public class lcoGetSettings : VarsBag {
public bool outParamIsActiveAmountValidation = false;

public bool outParamIsForceForeigner = false;

public decimal outParamo_ForeignCurrencyMargin = (((decimal)10));

public decimal outParamo_NationalCurrencyMargin = (((decimal)10));

public bool outParamo_IsActiveDEV_HU13008_Complement = false;

public bool outParamo_IsActiveDEV_HU13046 = false;

public lcoGetSettings() {
}
}
/// <summary>
/// Action <code>GetSettings</code> that represents the Service Studio action <code>GetSettings</code>
///  <p> Description: </p>
/// </summary>
public async Task<(bool,bool,decimal,decimal,bool,bool)> DataActionGetSettings(IRequestContext requestContext,CancellationToken cancellationToken) {
bool outParamIsActiveAmountValidation = default;
bool outParamIsForceForeigner = default;
decimal outParamo_ForeignCurrencyMargin = default;
decimal outParamo_NationalCurrencyMargin = default;
bool outParamo_IsActiveDEV_HU13008_Complement = default;
bool outParamo_IsActiveDEV_HU13046 = default;
lcoGetSettings result = new lcoGetSettings();
lcvGetSettings localVars = new lcvGetSettings();
ConectaProveedores_j_FoliosSAE_Wb_FolioEdit_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetSettings", "b6461436-778c-46ea-837f-2c9133ffad07"))
using (activitySource.CreateScreenDataActionActivity("Wb_FolioEdit", "GetSettings")){
// GetSettingsMargins
(localVars.resGetSettingsMargins.outParamNationalMargin,localVars.resGetSettingsMargins.outParamForeignMargin) = await Actions.ActionGetSettingsMargins(requestContext,cancellationToken);

// IsActiveAmountValidation = IsActiveXMLValidation_Amount
result.outParamIsActiveAmountValidation=((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveXMLValidation_Amount])));

// IsForceForeigner = IsActiveForceForeignerSupplier
result.outParamIsForceForeigner=((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveForceForeignerSupplier])));

// o_ForeignCurrencyMargin = GetSettingsMargins.ForeignMargin
result.outParamo_ForeignCurrencyMargin=localVars.resGetSettingsMargins.outParamForeignMargin;

// o_NationalCurrencyMargin = GetSettingsMargins.NationalMargin
result.outParamo_NationalCurrencyMargin=localVars.resGetSettingsMargins.outParamNationalMargin;

// o_IsActiveDEV_HU13008_Complement = IsActiveDEV_HU13008_Complement
result.outParamo_IsActiveDEV_HU13008_Complement=((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveDEV_HU13008_Complement])));

// o_IsActiveDEV_HU13046 = IsActiveDEV_HU13046
result.outParamo_IsActiveDEV_HU13046=((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveDEV_HU13046])));
} //close CreateActionActivity using block
} // try

finally {
outParamIsActiveAmountValidation = result.outParamIsActiveAmountValidation;
outParamIsForceForeigner = result.outParamIsForceForeigner;
outParamo_ForeignCurrencyMargin = result.outParamo_ForeignCurrencyMargin;
outParamo_NationalCurrencyMargin = result.outParamo_NationalCurrencyMargin;
outParamo_IsActiveDEV_HU13008_Complement = result.outParamo_IsActiveDEV_HU13008_Complement;
outParamo_IsActiveDEV_HU13046 = result.outParamo_IsActiveDEV_HU13046;
} // inner-finally
RETURN_STATEMENT:
return (outParamIsActiveAmountValidation,outParamIsForceForeigner,outParamo_ForeignCurrencyMargin,outParamo_NationalCurrencyMargin,outParamo_IsActiveDEV_HU13008_Complement,outParamo_IsActiveDEV_HU13046);
}
public class lcvGetFolioFiles : VarsBag {
public RL_f3a656d1fdc6bd4ad6371c5743799e57 resListFilterMain_outParamFilteredList = new RL_f3a656d1fdc6bd4ad6371c5743799e57();

public RL_f3a656d1fdc6bd4ad6371c5743799e57 queryResGetInvoicesByFolioId_outParamList = new RL_f3a656d1fdc6bd4ad6371c5743799e57();
public long queryResGetInvoicesByFolioId_outParamCount = 0L;

public lcvGetFolioFiles() {
}
}
public class lcoGetFolioFiles : VarsBag {
public RL_cc11123f1ba1bfd417e2f33be28138e9 outParamInvoiceMainFiles = new RL_cc11123f1ba1bfd417e2f33be28138e9();

public lcoGetFolioFiles() {
}
}
/// <summary>
/// Action <code>GetFolioFiles</code> that represents the Service Studio action
///  <code>GetFolioFiles</code> <p> Description: </p>
/// </summary>
public async Task<RL_cc11123f1ba1bfd417e2f33be28138e9> DataActionGetFolioFiles(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_cc11123f1ba1bfd417e2f33be28138e9 outParamInvoiceMainFiles = default;
lcoGetFolioFiles result = new lcoGetFolioFiles();
lcvGetFolioFiles localVars = new lcvGetFolioFiles();
ConectaProveedores_j_FoliosSAE_Wb_FolioEdit_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetFolioFiles", "f93ca6af-2e08-40cd-be04-f6f88f5de776"))
using (activitySource.CreateScreenDataActionActivity("Wb_FolioEdit", "GetFolioFiles")){
// Query datasetGetInvoicesByFolioId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoicesByFolioId_maxRecords = 999999999;
if (datasetGetInvoicesByFolioId_maxRecords < 1) datasetGetInvoicesByFolioId_maxRecords = 1;
int datasetGetInvoicesByFolioId_startIndex = 0;(localVars.queryResGetInvoicesByFolioId_outParamList,localVars.queryResGetInvoicesByFolioId_outParamCount) = await FuncDataActionGetFolioFiles.datasetGetInvoicesByFolioId(requestContext,datasetGetInvoicesByFolioId_maxRecords,datasetGetInvoicesByFolioId_startIndex,IterationMultiplicity.Multiple,inParamFolioId,cancellationToken);

// ListFilterMain
localVars.resListFilterMain_outParamFilteredList = (((RL_f3a656d1fdc6bd4ad6371c5743799e57)await  localVars.queryResGetInvoicesByFolioId_outParamList.FilterAsync(async (p, cancellationToken) => (!p.ssENInvoiceFile.ssIsExtra), cancellationToken)));

// InvoiceMainFiles = ListFilterMain.FilteredList
result.outParamInvoiceMainFiles=(await RL_cc11123f1ba1bfd417e2f33be28138e9.ConvertAsync(localVars.resListFilterMain_outParamFilteredList, new RL_cc11123f1ba1bfd417e2f33be28138e9(), async (RC_f5e20bd4e0a7c754f3e99b7ff28d38d9 source, ST_d381fba44897ce4382b17d5149465d51Structure target, CancellationToken cancellationToken) => {
target.ssId = source.ssENInvoiceFile.ssId;
target.ssInvoiceId = source.ssENInvoiceFile.ssInvoiceId;
target.ssFilename = source.ssENInvoiceFile.ssFilename;
target.ssIsExtra = source.ssENInvoiceFile.ssIsExtra;
target.ssStorageId = source.ssENInvoiceFile.ssStorageId;
target.ssCreatedByName = source.ssENUser.ssName;
target.ssCreatedBy = source.ssENInvoice.ssCreatedBy;
target.ssCreatedOn = source.ssENInvoiceFile.ssCreatedOn;
return target;
}, cancellationToken));
} //close CreateActionActivity using block
} // try

finally {
outParamInvoiceMainFiles = result.outParamInvoiceMainFiles;
} // inner-finally
RETURN_STATEMENT:
return outParamInvoiceMainFiles;
}


    public static class FuncDataActionGetOrderMainItems {

// Query Function "GetOrdersItems" XVaNEBlMAEWksujU_Dvyyw of Action "GetOrderMainItems"
public static async Task<(RL_bab3397f952f07af0f0aa229e6f2b36e,long)> QueryGetOrdersItems(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporl_OrderIdSelected,int qpfoi_folioStatusIdCanceled,int qpfoi_folioStatusIdCanceledByProvider,long qpfoi_FolioId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("j_FoliosSAE.Wb_FolioEdit.GetOrderMainItems.GetOrdersItems", "108d565d-4c19-4500-a4b2-e8d4fc3bf2cb");
using var queryActivity = activitySource.CreateSqlQueryActivity("j_FoliosSAE.Wb_FolioEdit.GetOrderMainItems.GetOrdersItems", "108d565d-4c19-4500-a4b2-e8d4fc3bf2cb", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
string advSql = "SELECT  \n    0, \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".Id") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"ordernumber\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"position\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"materialcode\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"materialdescription\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"quantity\"") + ", \n \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"quantitydelivered\"") + " + COALESCE(( \n        SELECT SUM(CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"invoiceqtt\"") + " AS DECIMAL(18,3))) \n        FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,"") + " \n        inner join  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,"") + " on  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"folioid\"") + " \n        WHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"ordermainitemid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"id\"") + " \n        and ( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"foliostatusid\"") + " <> @qpfoi_folioStatusIdCanceled and  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"foliostatusid\"") + " <> @qpfoi_folioStatusIdCanceledByProvider) \n        and  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"id\"") + " <> @qpfoi_FolioId \n    ), 0), \n \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"quantity\"") + " -  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"quantitydelivered\"") + " - COALESCE(( \n        SELECT SUM(CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"invoiceqtt\"") + " AS DECIMAL(18,3))) \n        FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,"") + " \n        inner join  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,"") + " on  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"folioid\"") + " \n        WHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"ordermainitemid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"id\"") + " \n        and ( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"foliostatusid\"") + " <> @qpfoi_folioStatusIdCanceled and  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"foliostatusid\"") + " <> @qpfoi_folioStatusIdCanceledByProvider) \n        and  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"id\"") + " <> @qpfoi_FolioId \n    ), 0), \n \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"orderunitofmeasure\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"code\"") + ", \n \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"unitprice\"") + "* " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"quantity\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItemStatus,".\"label\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItemStatus,".\"class\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"deliverydate\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"unitprice\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"assigmnentcode\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"vatrate\"") + ", \n    COALESCE(( \n        SELECT SUM(CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"totalprice\"") + " AS DECIMAL(18,2))) \n        FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,"") + " \n        inner join  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,"") + " on  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"folioid\"") + " \n        WHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"ordermainitemid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"id\"") + " \n        and ( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"foliostatusid\"") + " <> @qpfoi_folioStatusIdCanceled and  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"foliostatusid\"") + " <> @qpfoi_folioStatusIdCanceledByProvider) \n        and  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"id\"") + " <> @qpfoi_FolioId \n    ), 0), \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"isdeleted\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"isblocked\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"basequantity\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"isfinaldelivery\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"pepelement\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"ismultipleimputation\"") + " \n     \nFROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,"") + " \nINNER JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,"") + " \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"ordermainid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,"") + " \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"currencyid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"code\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItemStatus,"") + " \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"orderstatusid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItemStatus,".\"id\"") + " \n \nWHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"id\"") + " = @qporl_OrderIdSelected \nand  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"isblocked\"") + " = 0  \nand  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"isdeleted\"") + " = 0 \norder by  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"position\"") + " asc";
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_FolioEdit.GetOrderMainItems.GetOrdersItems.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_FolioEdit.GetOrderMainItems.GetOrdersItems.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_bab3397f952f07af0f0aa229e6f2b36e)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetOrdersItems in GetOrderMainItems in Wb_FolioEdit in j_FoliosSAE in ConectaProveedores (SELECT       0,      {OrderMainItem}.Id,      {OrderMain}.[OrderNumber],      {OrderMainItem}.[Position],      {OrderMainItem}.[MaterialCode],      {OrderMainItem}.[MaterialDescription],      {OrderMainItem}.[Quantity],        {OrderMainItem}.[QuantityDelivered] + COALESCE((          SELECT SUM(CAST({FolioItems}.[InvoiceQtt] AS DECIMAL(18,3)))          FROM {FolioItems}          inner join {Folio} on {Folio}.[Id] = {FolioItems}.[FolioId]          WHERE {FolioItems}.[OrderMainItemId] = {OrderMainItem}.[Id]          and ({Folio}.[FolioStatusId] <> @i_folioStatusIdCanceled and {Folio}.[FolioStatusId] <> @i_folioStatusIdCanceledByProvider)          and {Folio}.[Id] <> @i_FolioId      ), 0),        {OrderMainItem}.[Quantity] - {OrderMainItem}.[QuantityDelivered] - COALESCE((          SELECT SUM(CAST({FolioItems}.[InvoiceQtt] AS DECIMAL(18,3)))          FROM {FolioItems}          inner join {Folio} on {Folio}.[Id] = {FolioItems}.[FolioId]          WHERE {FolioItems}.[OrderMainItemId] = {Orde ...): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetOrdersItems in GetOrderMainItems in Wb_FolioEdit in j_FoliosSAE in ConectaProveedores (SELECT       0,      {OrderMainItem}.Id,      {OrderMain}.[OrderNumber],      {OrderMainItem}.[Position],      {OrderMainItem}.[MaterialCode],      {OrderMainItem}.[MaterialDescription],      {OrderMainItem}.[Quantity],        {OrderMainItem}.[QuantityDelivered] + COALESCE((          SELECT SUM(CAST({FolioItems}.[InvoiceQtt] AS DECIMAL(18,3)))          FROM {FolioItems}          inner join {Folio} on {Folio}.[Id] = {FolioItems}.[FolioId]          WHERE {FolioItems}.[OrderMainItemId] = {OrderMainItem}.[Id]          and ({Folio}.[FolioStatusId] <> @i_folioStatusIdCanceled and {Folio}.[FolioStatusId] <> @i_folioStatusIdCanceledByProvider)          and {Folio}.[Id] <> @i_FolioId      ), 0),        {OrderMainItem}.[Quantity] - {OrderMainItem}.[QuantityDelivered] - COALESCE((          SELECT SUM(CAST({FolioItems}.[InvoiceQtt] AS DECIMAL(18,3)))          FROM {FolioItems}          inner join {Folio} on {Folio}.[Id] = {FolioItems}.[FolioId]          WHERE {FolioItems}.[OrderMainItemId] = {Orde ...): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetOrdersItems in GetOrderMainItems in Wb_FolioEdit in j_FoliosSAE in ConectaProveedores (SELECT       0,      {OrderMainItem}.Id,      {OrderMain}.[OrderNumber],      {OrderMainItem}.[Position],      {OrderMainItem}.[MaterialCode],      {OrderMainItem}.[MaterialDescription],      {OrderMainItem}.[Quantity],        {OrderMainItem}.[QuantityDelivered] + COALESCE((          SELECT SUM(CAST({FolioItems}.[InvoiceQtt] AS DECIMAL(18,3)))          FROM {FolioItems}          inner join {Folio} on {Folio}.[Id] = {FolioItems}.[FolioId]          WHERE {FolioItems}.[OrderMainItemId] = {OrderMainItem}.[Id]          and ({Folio}.[FolioStatusId] <> @i_folioStatusIdCanceled and {Folio}.[FolioStatusId] <> @i_folioStatusIdCanceledByProvider)          and {Folio}.[Id] <> @i_FolioId      ), 0),        {OrderMainItem}.[Quantity] - {OrderMainItem}.[QuantityDelivered] - COALESCE((          SELECT SUM(CAST({FolioItems}.[InvoiceQtt] AS DECIMAL(18,3)))          FROM {FolioItems}          inner join {Folio} on {Folio}.[Id] = {FolioItems}.[FolioId]          WHERE {FolioItems}.[OrderMainItemId] = {Orde ...): " + aqExcep.Message));
}
}
}
}
public static class FuncDataActionGetSummary {

private static async Task<RC_a074711a91fd2441798a860685e4898b> datasetGetOrderMainByIdReadDbAsync(RC_a074711a91fd2441798a860685e4898b rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENCurrency.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
return rec;
}
// Query Function "GetOrderMainById" eUIwAEBUv06xhPkp+J0_Vg of Action "GetSummary"
public static async Task<(RL_164e5439119ae8b31002cd319dbe8413,long)> datasetGetOrderMainById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderMain_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("j_FoliosSAE.Wb_FolioEdit.GetSummary.GetOrderMainById", "00304279-5440-4ebf-b184-f929f89d3f56");
using var queryActivity = activitySource.CreateAggregateQueryActivity("j_FoliosSAE.Wb_FolioEdit.GetSummary.GetOrderMainById", "00304279-5440-4ebf-b184-f929f89d3f56", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.mdpkayXiA0u0IlWRNf05ew/DataActions.nFSTPU3q+0iORuNtETv2lA/NodesNotShownInESpaceTree.eUIwAEBUv06xhPkp+J0_Vg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"encurrency48\".\"code\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, trim_scale(\"enordermain140\".\"totalamount\"::numeric) o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33");
fromBuilder.Append(" FROM ({OrderMain} \"enordermain140\" Left JOIN {Currency} \"encurrency48\" ON (\"enordermain140\".\"currencyid\" = \"encurrency48\".\"code\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderMain_Id != 0) {
whereBuilder.Append("((\"enordermain140\".\"id\" = @qporOrderMain_Id) AND (\"enordermain140\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderMain_Id", DbType.Int64, qporOrderMain_Id);
} else {
whereBuilder.Append("(\"enordermain140\".\"id\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_FolioEdit.GetSummary.GetOrderMainById.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_FolioEdit.GetSummary.GetOrderMainById.List", cancellationToken: cancellationToken);
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

// Query Function "GetTotalAmountDelivered" qmziYMQIUEu8nJOmFjaHZQ of Action "GetSummary"
public static async Task<(RL_d3c140b81b16482eac14fd0448f33de5,long)> datasetGetTotalAmountDelivered(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolio_Id,long qporFolio_OrderId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("j_FoliosSAE.Wb_FolioEdit.GetSummary.GetTotalAmountDelivered", "60e26caa-08c4-4b50-bc9c-93a616368765");
using var queryActivity = activitySource.CreateAggregateQueryActivity("j_FoliosSAE.Wb_FolioEdit.GetSummary.GetTotalAmountDelivered", "60e26caa-08c4-4b50-bc9c-93a616368765", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.mdpkayXiA0u0IlWRNf05ew/DataActions.nFSTPU3q+0iORuNtETv2lA/NodesNotShownInESpaceTree.qmziYMQIUEu8nJOmFjaHZQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT Sum(\"enfolioitems17\".\"totalprice\") \"totalpricesum\"");
fromBuilder.Append(" FROM ({Folio} \"enfolio100\" Left JOIN {FolioItems} \"enfolioitems17\" ON (\"enfolio100\".\"id\" = \"enfolioitems17\".\"folioid\")) ");
whereBuilder.Append(" WHERE ");
if (qporFolio_OrderId != 0) {
whereBuilder.Append("((\"enfolio100\".\"orderid\" = @qporFolio_OrderId) AND (\"enfolio100\".\"orderid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporFolio_OrderId", DbType.Int64, qporFolio_OrderId);
} else {
whereBuilder.Append("(\"enfolio100\".\"orderid\" IS NULL)");
}
whereBuilder.Append(" AND ((\"enfolio100\".\"foliostatusid\" <> ");
whereBuilder.Append((ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("cklscJNc0UyOgKXGwg51TQ"))).ssId);
whereBuilder.Append(") AND (\"enfolio100\".\"foliostatusid\" <> ");
whereBuilder.Append((ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("l5OG661dZEe+gAZwnNLhSA"))).ssId);
whereBuilder.Append(")) AND ");
if (qpfoFolio_Id != 0) {
whereBuilder.Append("((\"enfolio100\".\"id\" <> @qpfoFolio_Id) OR (\"enfolio100\".\"id\" IS NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolio_Id", DbType.Int64, qpfoFolio_Id);
} else {
whereBuilder.Append("(\"enfolio100\".\"id\" IS NOT NULL)");
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
RL_d3c140b81b16482eac14fd0448f33de5 outParamList = new RL_d3c140b81b16482eac14fd0448f33de5();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[0];
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_FolioEdit.GetSummary.GetTotalAmountDelivered.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_FolioEdit.GetSummary.GetTotalAmountDelivered.List", cancellationToken: cancellationToken);
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

// Query Function "GetOrderItemEntries" l6BrhWPUoUmuL7bSnpR3rw of Action "GetSummary"
public static async Task<(RL_ecf075efbdf79b05fa564fa6ba80a9c6,long)> datasetGetOrderItemEntries(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderMain_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("j_FoliosSAE.Wb_FolioEdit.GetSummary.GetOrderItemEntries", "856ba097-d463-49a1-ae2f-b6d29e9477af");
using var queryActivity = activitySource.CreateAggregateQueryActivity("j_FoliosSAE.Wb_FolioEdit.GetSummary.GetOrderItemEntries", "856ba097-d463-49a1-ae2f-b6d29e9477af", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.mdpkayXiA0u0IlWRNf05ew/DataActions.nFSTPU3q+0iORuNtETv2lA/NodesNotShownInESpaceTree.l6BrhWPUoUmuL7bSnpR3rw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT Sum((\"enorderitementries7\".\"quantity_\" * (\"enordermainitem32\".\"unitprice\" / cast(\"enordermainitem32\".\"basequantity\" as decimal)))) \"totalsum\"");
fromBuilder.Append(" FROM (({OrderItemEntries} \"enorderitementries7\" Inner JOIN {OrderMainItem} \"enordermainitem32\" ON (\"enorderitementries7\".\"ordermainitemid\" = \"enordermainitem32\".\"id\"))  Inner JOIN {OrderMain} \"enordermain141\" ON (\"enordermainitem32\".\"ordermainid\" = \"enordermain141\".\"id\")) ");
whereBuilder.Append(" WHERE (\"enorderitementries7\".\"quantity_\" > cast(0 as decimal)) AND ");
if (qporOrderMain_Id != 0) {
whereBuilder.Append("((\"enordermain141\".\"id\" = @qporOrderMain_Id) AND (\"enordermain141\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderMain_Id", DbType.Int64, qporOrderMain_Id);
} else {
whereBuilder.Append("(\"enordermain141\".\"id\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_FolioEdit.GetSummary.GetOrderItemEntries.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_FolioEdit.GetSummary.GetOrderItemEntries.List", cancellationToken: cancellationToken);
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

// Query Function "GetTotalFromOriginal" fGJDzY3sVUyhUJ9awLNuFQ of Action "GetSummary"
public static async Task<(RL_312927afcf3eb9d5fa3bc02bbc91d978,long)> datasetGetTotalFromOriginal(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderMainId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("j_FoliosSAE.Wb_FolioEdit.GetSummary.GetTotalFromOriginal", "cd43627c-ec8d-4c55-a150-9f5ac0b36e15");
using var queryActivity = activitySource.CreateAggregateQueryActivity("j_FoliosSAE.Wb_FolioEdit.GetSummary.GetTotalFromOriginal", "cd43627c-ec8d-4c55-a150-9f5ac0b36e15", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.mdpkayXiA0u0IlWRNf05ew/DataActions.nFSTPU3q+0iORuNtETv2lA/NodesNotShownInESpaceTree.fGJDzY3sVUyhUJ9awLNuFQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT Sum((\"enordermainitem33\".\"quantitydelivered\" * (\"enordermainitem33\".\"unitprice\" / cast(\"enordermainitem33\".\"basequantity\" as decimal)))) \"totalsapsum\"");
fromBuilder.Append(" FROM {OrderMainItem} \"enordermainitem33\"");
whereBuilder.Append(" WHERE ");
if (qporOrderMainId != 0) {
whereBuilder.Append("((\"enordermainitem33\".\"ordermainid\" = @qporOrderMainId) AND (\"enordermainitem33\".\"ordermainid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderMainId", DbType.Int64, qporOrderMainId);
} else {
whereBuilder.Append("(\"enordermainitem33\".\"ordermainid\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_FolioEdit.GetSummary.GetTotalFromOriginal.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_FolioEdit.GetSummary.GetTotalFromOriginal.List", cancellationToken: cancellationToken);
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
}
public static class FuncDataActionGetSettings {
}
public static class FuncDataActionGetFolioFiles {

private static async Task<RC_f5e20bd4e0a7c754f3e99b7ff28d38d9> datasetGetInvoicesByFolioIdReadDbAsync(RC_f5e20bd4e0a7c754f3e99b7ff28d38d9 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceFile.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
return rec;
}
// Query Function "GetInvoicesByFolioId" Lw3LsQydqU6E4dTJd1C4MQ of Action "GetFolioFiles"
public static async Task<(RL_f3a656d1fdc6bd4ad6371c5743799e57,long)> datasetGetInvoicesByFolioId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoInvoice_FolioId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("j_FoliosSAE.Wb_FolioEdit.GetFolioFiles.GetInvoicesByFolioId", "b1cb0d2f-9d0c-4ea9-84e1-d4c97750b831");
using var queryActivity = activitySource.CreateAggregateQueryActivity("j_FoliosSAE.Wb_FolioEdit.GetFolioFiles.GetInvoicesByFolioId", "b1cb0d2f-9d0c-4ea9-84e1-d4c97750b831", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.mdpkayXiA0u0IlWRNf05ew/DataActions.r6Y8+QguzUC+BPb4j13ndg/NodesNotShownInESpaceTree.Lw3LsQydqU6E4dTJd1C4MQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, \"eninvoice156\".\"createdby\" o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, \"eninvoicefile59\".\"id\" o24, \"eninvoicefile59\".\"invoiceid\" o25, \"eninvoicefile59\".\"filename\" o26, \"eninvoicefile59\".\"isextra\" o27, NULL o28, \"eninvoicefile59\".\"storageid\" o29, NULL o30, \"eninvoicefile59\".\"createdon\" o31, NULL o32, \"enuser241\".\"name\" o33, NULL o34, NULL o35, NULL o36");
fromBuilder.Append(" FROM (({Invoice} \"eninvoice156\" Inner JOIN {InvoiceFile} \"eninvoicefile59\" ON (\"eninvoice156\".\"id\" = \"eninvoicefile59\".\"invoiceid\"))  Left JOIN {User} \"enuser241\" ON (\"eninvoicefile59\".\"createdby\" = \"enuser241\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoInvoice_FolioId != 0) {
whereBuilder.Append("((\"eninvoice156\".\"folioid\" = @qpfoInvoice_FolioId) AND (\"eninvoice156\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoInvoice_FolioId", DbType.Int64, qpfoInvoice_FolioId);
} else {
whereBuilder.Append("(\"eninvoice156\".\"folioid\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"eninvoice156\".\"name\" ASC ");
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
RL_f3a656d1fdc6bd4ad6371c5743799e57 outParamList = new RL_f3a656d1fdc6bd4ad6371c5743799e57();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoicesByFolioIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, false, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {false, false, false, false, true, false, true, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_FolioEdit.GetFolioFiles.GetInvoicesByFolioId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_f3a656d1fdc6bd4ad6371c5743799e57 _tmp = new RL_f3a656d1fdc6bd4ad6371c5743799e57();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoicesByFolioIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_FolioEdit.GetFolioFiles.GetInvoicesByFolioId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_f3a656d1fdc6bd4ad6371c5743799e57)_tmp;
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
