using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_ScreenModel).Namespace);

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
public AggregateRecord<RL_52e01c48f1745de5266c16d6fe2c0564> ScreenDataSetGetFolioApprovalRejectReason;
public AggregateRecord<RL_4f8b259bdd04db22be8fb771f1ad1d4f> ScreenDataSetGetFolioById;
public AggregateRecord<RL_5fec0894721bcc83c763c610a52bfbfd> ScreenDataSetGetFolioCommentsByFolioId;
public AggregateRecord<RL_a968cf9f63475dc9358672149b11245a> ScreenDataSetGetFolioItemsByFolioId;
public AggregateRecord<RL_398a2e7b47dcd31617b8f6499aea0bce> ScreenDataSetGetOrderDetail;
public AggregateRecord<RL_994583bfe1c92160ce9fe58b4f4e0d70> ScreenDataSetGetFolioObservationsByFolioId;
public ConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_DataActionGetSettings_Model varLcGetSettings;
public ConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_DataActionGetFolioFiles_Model varLcGetFolioFiles;
public ConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_DataActionGetOrderMainItems_Model varLcGetOrderMainItems;
public ConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_DataActionGetSummary_Model varLcGetSummary;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_ScreenModel() {
}



    public ConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_ScreenModel(long inParamFolioId, long inParami_OrderId, RL_123aa03224ec08dab8cbe26021987012 inParami_LocalSelectedLines, RC_0b2176705fa164c9531eb643caf0e9d4 varLcl_SummaryRec, bool varLcWithDatesError, bool varLcWithQuantityError, bool varLcWithFilesError, bool varLcDatesQuantityPEPError, bool varLcWithprorata, string varLcfirstUserIdentifier, string varLcComments, EN_d1d0320db36efbb094ad0082361435a0EntityRecord varLcInvoiceToCreate, ST_6f620840109ac6f721328b723ec0152cStructure varLcInvoiceForeignToCreate, RL_1501ee54ff868a67eff67465502ee3d9 varLcFilesList, RL_1501ee54ff868a67eff67465502ee3d9 varLcFilesListExtra, bool varLcApproverValid, string varLcApproverErrorMessage, bool varLcMaxAmountError, RL_123aa03224ec08dab8cbe26021987012 varLcLocalSelectedLines, decimal varLcl_ImportAnticipo, RL_1501ee54ff868a67eff67465502ee3d9 varLcCreditNoteFilesList, bool varLcl_IsOpenPopup, string varLcl_IsOpenPopupComment, bool varLcHaveNewFiles, string varLcNewFileNamesUploaded, bool varLcL_IsNational, EN_d1d0320db36efbb094ad0082361435a0EntityRecord varLcCreditNoteInvoiceToCreate, bool varLcCreditNote_IsNeeded, EN_f81a3d226103fd013068b8763798067aEntityRecord varLcInvoiceExtendedToCreate, long varLcOrderAccConceptsIdToCreate, AggregateRecord<RL_52e01c48f1745de5266c16d6fe2c0564> ScreenDataSetGetFolioApprovalRejectReason, AggregateRecord<RL_4f8b259bdd04db22be8fb771f1ad1d4f> ScreenDataSetGetFolioById, AggregateRecord<RL_5fec0894721bcc83c763c610a52bfbfd> ScreenDataSetGetFolioCommentsByFolioId, AggregateRecord<RL_a968cf9f63475dc9358672149b11245a> ScreenDataSetGetFolioItemsByFolioId, AggregateRecord<RL_398a2e7b47dcd31617b8f6499aea0bce> ScreenDataSetGetOrderDetail, AggregateRecord<RL_994583bfe1c92160ce9fe58b4f4e0d70> ScreenDataSetGetFolioObservationsByFolioId, ConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_DataActionGetSettings_Model varLcGetSettings, ConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_DataActionGetFolioFiles_Model varLcGetFolioFiles, ConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_DataActionGetOrderMainItems_Model varLcGetOrderMainItems, ConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_DataActionGetSummary_Model varLcGetSummary, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"FolioId", "i_OrderId", "i_LocalSelectedLines", "l_SummaryRec", "WithDatesError", "WithQuantityError", "WithFilesError", "DatesQuantityPEPError", "Withprorata", "firstUserIdentifier", "Comments", "InvoiceToCreate", "InvoiceForeignToCreate", "FilesList", "FilesListExtra", "ApproverValid", "ApproverErrorMessage", "MaxAmountError", "LocalSelectedLines", "l_ImportAnticipo", "CreditNoteFilesList", "l_IsOpenPopup", "l_IsOpenPopupComment", "HaveNewFiles", "NewFileNamesUploaded", "L_IsNational", "CreditNoteInvoiceToCreate", "CreditNote_IsNeeded", "InvoiceExtendedToCreate", "OrderAccConceptsIdToCreate", "GetFolioApprovalRejectReason", "GetFolioById", "GetFolioCommentsByFolioId", "GetFolioItemsByFolioId", "GetOrderDetail", "GetFolioObservationsByFolioId", "GetSettings", "GetFolioFiles", "GetOrderMainItems", "GetSummary", "ClientVars"}, new string[] {"inParamFolioId", "inParami_OrderId", "inParami_LocalSelectedLines", "varLcl_SummaryRec", "varLcWithDatesError", "varLcWithQuantityError", "varLcWithFilesError", "varLcDatesQuantityPEPError", "varLcWithprorata", "varLcfirstUserIdentifier", "varLcComments", "varLcInvoiceToCreate", "varLcInvoiceForeignToCreate", "varLcFilesList", "varLcFilesListExtra", "varLcApproverValid", "varLcApproverErrorMessage", "varLcMaxAmountError", "varLcLocalSelectedLines", "varLcl_ImportAnticipo", "varLcCreditNoteFilesList", "varLcl_IsOpenPopup", "varLcl_IsOpenPopupComment", "varLcHaveNewFiles", "varLcNewFileNamesUploaded", "varLcL_IsNational", "varLcCreditNoteInvoiceToCreate", "varLcCreditNote_IsNeeded", "varLcInvoiceExtendedToCreate", "varLcOrderAccConceptsIdToCreate", "ScreenDataSetGetFolioApprovalRejectReason", "ScreenDataSetGetFolioById", "ScreenDataSetGetFolioCommentsByFolioId", "ScreenDataSetGetFolioItemsByFolioId", "ScreenDataSetGetOrderDetail", "ScreenDataSetGetFolioObservationsByFolioId", "varLcGetSettings", "varLcGetFolioFiles", "varLcGetOrderMainItems", "varLcGetSummary", "clientVariables"});
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
this.ScreenDataSetGetFolioApprovalRejectReason = ScreenDataSetGetFolioApprovalRejectReason;
this.ScreenDataSetGetFolioById = ScreenDataSetGetFolioById;
this.ScreenDataSetGetFolioCommentsByFolioId = ScreenDataSetGetFolioCommentsByFolioId;
this.ScreenDataSetGetFolioItemsByFolioId = ScreenDataSetGetFolioItemsByFolioId;
this.ScreenDataSetGetOrderDetail = ScreenDataSetGetOrderDetail;
this.ScreenDataSetGetFolioObservationsByFolioId = ScreenDataSetGetFolioObservationsByFolioId;
this.varLcGetSettings = varLcGetSettings;
this.varLcGetFolioFiles = varLcGetFolioFiles;
this.varLcGetOrderMainItems = varLcGetOrderMainItems;
this.varLcGetSummary = varLcGetSummary;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_131b941598d8581e5466dbb966f5f0a8> datasetGetFolioApprovalRejectReasonReadDbAsync(RC_131b941598d8581e5466dbb966f5f0a8 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolioApproval.Read( r, ref index);
rec.ssENFolioApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetFolioApprovalRejectReason" IgBUJLd3CEGKZUq7Wcf8vA of Action "Wb_FolioEditIncorrectInvoice"
public static async Task<(RL_52e01c48f1745de5266c16d6fe2c0564,long)> datasetGetFolioApprovalRejectReason(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolioApproval_FolioId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.Wb_FolioEditIncorrectInvoice.GetFolioApprovalRejectReason", "24540022-77b7-4108-8a65-4abb59c7fcbc");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_FolioEditIncorrectInvoice","j_FoliosSAE.Wb_FolioEditIncorrectInvoice.GetFolioApprovalRejectReason");
// Query Iterations: Never
// Refresh Query E9+q9DuxfEKygRC_54pxJA Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.BFvPY+s2IEqFd5ZaHcI0qA/ScreenDataSets.IgBUJLd3CEGKZUq7Wcf8vA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, \"enfolioapprovallevel50\".\"rejectreason\" o28, NULL o29");
fromBuilder.Append(" FROM ({FolioApproval} \"enfolioapproval53\" Left JOIN {FolioApprovalLevel} \"enfolioapprovallevel50\" ON (\"enfolioapproval53\".\"id\" = \"enfolioapprovallevel50\".\"folioapprovalid\")) ");
whereBuilder.Append(" WHERE (\"enfolioapprovallevel50\".\"isinvoiceapproval\" = 1) AND ");
if (qpfoFolioApproval_FolioId != 0) {
whereBuilder.Append("((\"enfolioapproval53\".\"folioid\" = @qpfoFolioApproval_FolioId) AND (\"enfolioapproval53\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioApproval_FolioId", DbType.Int64, qpfoFolioApproval_FolioId);
} else {
whereBuilder.Append("(\"enfolioapproval53\".\"folioid\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"enfolioapprovallevel50\".\"levelnumber\" ASC ");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_FolioEditIncorrectInvoice.GetFolioApprovalRejectReason.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_FolioEditIncorrectInvoice.GetFolioApprovalRejectReason.List", cancellationToken: cancellationToken);
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

// Query Function "GetFolioById" P0FlKHINxUSH95HezmEdOw of Action "Wb_FolioEditIncorrectInvoice"
public static async Task<(RL_4f8b259bdd04db22be8fb771f1ad1d4f,long)> datasetGetFolioById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.Wb_FolioEditIncorrectInvoice.GetFolioById", "2865413f-0d72-44c5-87f7-91dece611d3b");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_FolioEditIncorrectInvoice","j_FoliosSAE.Wb_FolioEditIncorrectInvoice.GetFolioById");
// Query Iterations: Never
// Refresh Query Xno2WctW40eV6W4bn5Rl7g Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.BFvPY+s2IEqFd5ZaHcI0qA/ScreenDataSets.P0FlKHINxUSH95HezmEdOw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, \"enfolio94\".\"foliostatusid\" o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19");
fromBuilder.Append(" FROM {Folio} \"enfolio94\"");
whereBuilder.Append(" WHERE ");
if (qpfoId != 0) {
whereBuilder.Append("((\"enfolio94\".\"id\" = @qpfoId) AND (\"enfolio94\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoId", DbType.Int64, qpfoId);
} else {
whereBuilder.Append("(\"enfolio94\".\"id\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_FolioEditIncorrectInvoice.GetFolioById.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_FolioEditIncorrectInvoice.GetFolioById.List", cancellationToken: cancellationToken);
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

private static async Task<RC_03baaf9011c29c7810216c701048afb6> datasetGetFolioCommentsByFolioIdReadDbAsync(RC_03baaf9011c29c7810216c701048afb6 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENCommentType.Read( r, ref index);
rec.ssENFolioComment.Read( r, ref index);
return rec;
}
// Query Function "GetFolioCommentsByFolioId" Y+1lMpi+HkSd2WkH+EwSxQ of Action "Wb_FolioEditIncorrectInvoice"
public static async Task<(RL_5fec0894721bcc83c763c610a52bfbfd,long)> datasetGetFolioCommentsByFolioId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolioComment_FolioId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.Wb_FolioEditIncorrectInvoice.GetFolioCommentsByFolioId", "3265ed63-be98-441e-9dd9-6907f84c12c5");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_FolioEditIncorrectInvoice","j_FoliosSAE.Wb_FolioEditIncorrectInvoice.GetFolioCommentsByFolioId");
// Query Iterations: Never
// Refresh Query XU_H7kKRx0GWY1xo2ks5sw Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.BFvPY+s2IEqFd5ZaHcI0qA/ScreenDataSets.Y+1lMpi+HkSd2WkH+EwSxQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, \"enfoliocomment1\".\"message\" o12, NULL o13");
fromBuilder.Append(" FROM ({FolioComment} \"enfoliocomment1\" Left JOIN {CommentType} \"encommenttype1\" ON (\"enfoliocomment1\".\"commenttypeid\" = \"encommenttype1\".\"id\")) ");
whereBuilder.Append(" WHERE (\"encommenttype1\".\"id\" = ");
whereBuilder.Append((ENCommentTypeEntity.GetRecordByKey(ObjectKey.Parse("fWPpinJz1EuuskuhosoYJA"))).ssId);
whereBuilder.Append(") AND ");
if (qpfoFolioComment_FolioId != 0) {
whereBuilder.Append("((\"enfoliocomment1\".\"folioid\" = @qpfoFolioComment_FolioId) AND (\"enfoliocomment1\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioComment_FolioId", DbType.Int64, qpfoFolioComment_FolioId);
} else {
whereBuilder.Append("(\"enfoliocomment1\".\"folioid\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"enfoliocomment1\".\"id\" DESC ");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_FolioEditIncorrectInvoice.GetFolioCommentsByFolioId.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_FolioEditIncorrectInvoice.GetFolioCommentsByFolioId.List", cancellationToken: cancellationToken);
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

private static async Task<RC_95110bc97f34f4c1561c8cbf2b5015b2> datasetGetFolioItemsByFolioIdReadDbAsync(RC_95110bc97f34f4c1561c8cbf2b5015b2 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolio.Read( r, ref index);
rec.ssENFolioItems.Read( r, ref index);
rec.ssENOrderMainItem.Read( r, ref index);
return rec;
}
// Query Function "GetFolioItemsByFolioId" zZ4uWkzEckOWNZgkyaRxYw of Action "Wb_FolioEditIncorrectInvoice"
public static async Task<(RL_a968cf9f63475dc9358672149b11245a,long)> datasetGetFolioItemsByFolioId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolioItems_FolioId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.Wb_FolioEditIncorrectInvoice.GetFolioItemsByFolioId", "5a2e9ecd-c44c-4372-9635-9824c9a47163");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_FolioEditIncorrectInvoice","j_FoliosSAE.Wb_FolioEditIncorrectInvoice.GetFolioItemsByFolioId");
// Query Iterations: Multiple
// Refresh Query wYJzQ0LcaEO9fnpNrb4uVw Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.BFvPY+s2IEqFd5ZaHcI0qA/ScreenDataSets.zZ4uWkzEckOWNZgkyaRxYw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enfolio95\".\"id\" o0, \"enfolio95\".\"isdraft\" o1, \"enfolio95\".\"folionumber\" o2, \"enfolio95\".\"canproveedorcancel\" o3, \"enfolio95\".\"orderid\" o4, \"enfolio95\".\"supplierid\" o5, \"enfolio95\".\"companyid\" o6, \"enfolio95\".\"foliostatusid\" o7, trim_scale(\"enfolio95\".\"totalamount\"::numeric) o8, trim_scale(\"enfolio95\".\"totaliva_amount\"::numeric) o9, trim_scale(\"enfolio95\".\"partialamount\"::numeric) o10, \"enfolio95\".\"currencyid\" o11, \"enfolio95\".\"firstapproveruserid\" o12, \"enfolio95\".\"approvalprocesstypeid\" o13, \"enfolio95\".\"sapentryerror\" o14, \"enfolio95\".\"createdby\" o15, \"enfolio95\".\"createdon\" o16, \"enfolio95\".\"updatedby\" o17, \"enfolio95\".\"updatedon\" o18, \"enfolio95\".\"minuteselected\" o19, \"enfolioitems14\".\"id\" o20, \"enfolioitems14\".\"folioid\" o21, \"enfolioitems14\".\"ordermainitemid\" o22, \"enfolioitems14\".\"ordernumber\" o23, \"enfolioitems14\".\"articlenumber\" o24, \"enfolioitems14\".\"description\" o25, \"enfolioitems14\".\"inputationcode\" o26, \"enfolioitems14\".\"deliverydate\" o27, trim_scale(\"enfolioitems14\".\"invoiceqtt\"::numeric) o28, trim_scale(\"enfolioitems14\".\"remainingqtt\"::numeric) o29, trim_scale(\"enfolioitems14\".\"unitprice\"::numeric) o30, trim_scale(\"enfolioitems14\".\"totalprice\"::numeric) o31, trim_scale(\"enfolioitems14\".\"quantity\"::numeric) o32, \"enfolioitems14\".\"deliveryqtt\" o33, \"enfolioitems14\".\"importdelivery\" o34, \"enfolioitems14\".\"pep\" o35, \"enfolioitems14\".\"placeid\" o36, \"enfolioitems14\".\"placename\" o37, \"enordermainitem28\".\"id\" o38, \"enordermainitem28\".\"ordermainid\" o39, \"enordermainitem28\".\"position\" o40, \"enordermainitem28\".\"materialcode\" o41, \"enordermainitem28\".\"materialdescription\" o42, \"enordermainitem28\".\"assigmnentcode\" o43, \"enordermainitem28\".\"documentclassid\" o44, \"enordermainitem28\".\"deliverydate\" o45, trim_scale(\"enordermainitem28\".\"quantity\"::numeric) o46, \"enordermainitem28\".\"unittype\" o47, trim_scale(\"enordermainitem28\".\"unitprice\"::numeric) o48, \"enordermainitem28\".\"basequantity\" o49, \"enordermainitem28\".\"isdeleted\" o50, \"enordermainitem28\".\"isblocked\" o51, \"enordermainitem28\".\"isfinaldelivery\" o52, \"enordermainitem28\".\"glaccountid\" o53, \"enordermainitem28\".\"costcenterid\" o54, \"enordermainitem28\".\"fundscenter\" o55, \"enordermainitem28\".\"fund\" o56, \"enordermainitem28\".\"commitmentitem\" o57, \"enordermainitem28\".\"vatindicator\" o58, \"enordermainitem28\".\"vatprocedure\" o59, trim_scale(\"enordermainitem28\".\"vatrate\"::numeric) o60, \"enordermainitem28\".\"purchaserequisitionnumber\" o61, \"enordermainitem28\".\"purchaserequisitionitemnr\" o62, \"enordermainitem28\".\"regionid\" o63, \"enordermainitem28\".\"center\" o64, \"enordermainitem28\".\"pepelement\" o65, trim_scale(\"enordermainitem28\".\"quantitydelivered\"::numeric) o66, \"enordermainitem28\".\"orderunitofmeasure\" o67, \"enordermainitem28\".\"applicant\" o68, \"enordermainitem28\".\"direction\" o69, \"enordermainitem28\".\"contractnumber\" o70, \"enordermainitem28\".\"contractposition\" o71, \"enordermainitem28\".\"contractstartdate\" o72, \"enordermainitem28\".\"contractenddate\" o73, trim_scale(\"enordermainitem28\".\"contractplannedvalue\"::numeric) o74, \"enordermainitem28\".\"positiontype\" o75, \"enordermainitem28\".\"serialnumberprofile\" o76, \"enordermainitem28\".\"batchmanaged\" o77, \"enordermainitem28\".\"materialtype\" o78, \"enordermainitem28\".\"itemgroup\" o79, \"enordermainitem28\".\"orderrequestcreatorsapnumber\" o80, \"enordermainitem28\".\"ismultipleimputation\" o81, \"enordermainitem28\".\"invoiceusageid\" o82, \"enordermainitem28\".\"ordermainitemstatusid\" o83, \"enordermainitem28\".\"divisionid\" o84, \"enordermainitem28\".\"createdby\" o85, \"enordermainitem28\".\"createdon\" o86, \"enordermainitem28\".\"updatedby\" o87, \"enordermainitem28\".\"updatedon\" o88");
fromBuilder.Append(" FROM (({FolioItems} \"enfolioitems14\" Inner JOIN {OrderMainItem} \"enordermainitem28\" ON (\"enfolioitems14\".\"ordermainitemid\" = \"enordermainitem28\".\"id\"))  Left JOIN {Folio} \"enfolio95\" ON (\"enfolioitems14\".\"folioid\" = \"enfolio95\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoFolioItems_FolioId != 0) {
whereBuilder.Append("((\"enfolioitems14\".\"folioid\" = @qpfoFolioItems_FolioId) AND (\"enfolioitems14\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioItems_FolioId", DbType.Int64, qpfoFolioItems_FolioId);
} else {
whereBuilder.Append("(\"enfolioitems14\".\"folioid\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_FolioEditIncorrectInvoice.GetFolioItemsByFolioId.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_FolioEditIncorrectInvoice.GetFolioItemsByFolioId.List", cancellationToken: cancellationToken);
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
// Query Function "GetOrderDetail" JV1Ya0m0wk6bFCga1GMiXA of Action "Wb_FolioEditIncorrectInvoice"
public static async Task<(RL_398a2e7b47dcd31617b8f6499aea0bce,long)> datasetGetOrderDetail(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderMain_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.Wb_FolioEditIncorrectInvoice.GetOrderDetail", "6b585d25-b449-4ec2-9b14-281ad463225c");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_FolioEditIncorrectInvoice","j_FoliosSAE.Wb_FolioEditIncorrectInvoice.GetOrderDetail");
// Query Iterations: Never
// Refresh Query 3QvttbBTSUKgWXmWT4k4zg Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.BFvPY+s2IEqFd5ZaHcI0qA/ScreenDataSets.JV1Ya0m0wk6bFCga1GMiXA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, \"enordermain135\".\"ordernumber\" o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, \"enordermain135\".\"currencyid\" o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, NULL o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, NULL o118, NULL o119, NULL o120, NULL o121, NULL o122, NULL o123, NULL o124, NULL o125, NULL o126, NULL o127, NULL o128");
fromBuilder.Append(" FROM ((((({OrderMain} \"enordermain135\" Inner JOIN {Supplier} \"ensupplier141\" ON (\"enordermain135\".\"supplierid\" = \"ensupplier141\".\"id\"))  Left JOIN {OrderDetail} \"enorderdetail21\" ON (\"enordermain135\".\"id\" = \"enorderdetail21\".\"orderid\"))  Left JOIN {PaymentMethods} \"enpaymentmethods13\" ON (\"enorderdetail21\".\"paymentmethodid\" = \"enpaymentmethods13\".\"id\"))  Left JOIN {PaymentTerms} \"enpaymentterms33\" ON (\"enorderdetail21\".\"paymenttermsid\" = \"enpaymentterms33\".\"id\"))  Left JOIN {Region} \"enregion188\" ON (\"enordermain135\".\"regionid\" = \"enregion188\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderMain_Id != 0) {
whereBuilder.Append("((\"enordermain135\".\"id\" = @qporOrderMain_Id) AND (\"enordermain135\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderMain_Id", DbType.Int64, qporOrderMain_Id);
} else {
whereBuilder.Append("(\"enordermain135\".\"id\" IS NULL)");
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
opt[0] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_FolioEditIncorrectInvoice.GetOrderDetail.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_FolioEditIncorrectInvoice.GetOrderDetail.List", cancellationToken: cancellationToken);
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

// Query Function "GetFolioObservationsByFolioId" VmBr5dv2jU6eJFCRWCQSgw of Action "Wb_FolioEditIncorrectInvoice"
public static async Task<(RL_994583bfe1c92160ce9fe58b4f4e0d70,long)> datasetGetFolioObservationsByFolioId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolioId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.Wb_FolioEditIncorrectInvoice.GetFolioObservationsByFolioId", "e56b6056-f6db-4e8d-9e24-509158241283");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_FolioEditIncorrectInvoice","j_FoliosSAE.Wb_FolioEditIncorrectInvoice.GetFolioObservationsByFolioId");
// Query Iterations: Multiple
// Refresh Query 5NfJNBQc5EuMat59ysx7fQ Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.BFvPY+s2IEqFd5ZaHcI0qA/ScreenDataSets.VmBr5dv2jU6eJFCRWCQSgw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"enfolioobservations1\".\"observation\" o2, NULL o3, \"enfolioobservations1\".\"createdon\" o4");
fromBuilder.Append(" FROM {FolioObservations} \"enfolioobservations1\"");
whereBuilder.Append(" WHERE ");
if (qpfoFolioId != 0) {
whereBuilder.Append("((\"enfolioobservations1\".\"folioid\" = @qpfoFolioId) AND (\"enfolioobservations1\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioId", DbType.Int64, qpfoFolioId);
} else {
whereBuilder.Append("(\"enfolioobservations1\".\"folioid\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"enfolioobservations1\".\"createdon\" DESC ");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_FolioEditIncorrectInvoice.GetFolioObservationsByFolioId.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_FolioEditIncorrectInvoice.GetFolioObservationsByFolioId.List", cancellationToken: cancellationToken);
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
ConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetSettings", "5b6e4d78-7f20-402c-b4a0-294865300bc9"))
using (activitySource.CreateScreenDataActionActivity("Wb_FolioEditIncorrectInvoice", "GetSettings")){
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
public RL_f3a656d1fdc6bd4ad6371c5743799e57 queryResGetInvoicesByFolioId_outParamList = new RL_f3a656d1fdc6bd4ad6371c5743799e57();
public long queryResGetInvoicesByFolioId_outParamCount = 0L;

public RL_f3a656d1fdc6bd4ad6371c5743799e57 resListFilterMain_outParamFilteredList = new RL_f3a656d1fdc6bd4ad6371c5743799e57();

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
ConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetFolioFiles", "83f941e9-0e9c-4db9-82bb-18b0aba42675"))
using (activitySource.CreateScreenDataActionActivity("Wb_FolioEditIncorrectInvoice", "GetFolioFiles")){
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
ConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetOrderMainItems", "d68c8e82-6b35-4dbf-b085-ecf6fd508b13"))
using (activitySource.CreateScreenDataActionActivity("Wb_FolioEditIncorrectInvoice", "GetOrderMainItems")){
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
public RL_312927afcf3eb9d5fa3bc02bbc91d978 queryResGetTotalFromOriginal_outParamList = new RL_312927afcf3eb9d5fa3bc02bbc91d978();
public long queryResGetTotalFromOriginal_outParamCount = 0L;

public RL_d3c140b81b16482eac14fd0448f33de5 queryResGetTotalAmountDelivered_outParamList = new RL_d3c140b81b16482eac14fd0448f33de5();
public long queryResGetTotalAmountDelivered_outParamCount = 0L;

public RL_ecf075efbdf79b05fa564fa6ba80a9c6 queryResGetOrderItemEntries_outParamList = new RL_ecf075efbdf79b05fa564fa6ba80a9c6();
public long queryResGetOrderItemEntries_outParamCount = 0L;

public RL_164e5439119ae8b31002cd319dbe8413 queryResGetOrderMainById_outParamList = new RL_164e5439119ae8b31002cd319dbe8413();
public long queryResGetOrderMainById_outParamCount = 0L;

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
ConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetSummary", "ec6b1256-fec2-44b9-b614-21d5bbfc17d8"))
using (activitySource.CreateScreenDataActionActivity("Wb_FolioEditIncorrectInvoice", "GetSummary")){
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
// Query Function "GetInvoicesByFolioId" GgRZB2Ugn0mdyRjRovN72Q of Action "GetFolioFiles"
public static async Task<(RL_f3a656d1fdc6bd4ad6371c5743799e57,long)> datasetGetInvoicesByFolioId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoInvoice_FolioId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("j_FoliosSAE.Wb_FolioEditIncorrectInvoice.GetFolioFiles.GetInvoicesByFolioId", "0759041a-2065-499f-9dc9-18d1a2f37bd9");
using var queryActivity = activitySource.CreateAggregateQueryActivity("j_FoliosSAE.Wb_FolioEditIncorrectInvoice.GetFolioFiles.GetInvoicesByFolioId", "0759041a-2065-499f-9dc9-18d1a2f37bd9", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.BFvPY+s2IEqFd5ZaHcI0qA/DataActions.6UH5g5wOuU2Cuxiwq6QmdQ/NodesNotShownInESpaceTree.GgRZB2Ugn0mdyRjRovN72Q, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, \"eninvoice155\".\"createdby\" o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, \"eninvoicefile58\".\"id\" o24, \"eninvoicefile58\".\"invoiceid\" o25, \"eninvoicefile58\".\"filename\" o26, \"eninvoicefile58\".\"isextra\" o27, NULL o28, \"eninvoicefile58\".\"storageid\" o29, NULL o30, \"eninvoicefile58\".\"createdon\" o31, NULL o32, \"enuser239\".\"name\" o33, NULL o34, NULL o35, NULL o36");
fromBuilder.Append(" FROM (({Invoice} \"eninvoice155\" Inner JOIN {InvoiceFile} \"eninvoicefile58\" ON (\"eninvoice155\".\"id\" = \"eninvoicefile58\".\"invoiceid\"))  Left JOIN {User} \"enuser239\" ON (\"eninvoicefile58\".\"createdby\" = \"enuser239\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoInvoice_FolioId != 0) {
whereBuilder.Append("((\"eninvoice155\".\"folioid\" = @qpfoInvoice_FolioId) AND (\"eninvoice155\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoInvoice_FolioId", DbType.Int64, qpfoInvoice_FolioId);
} else {
whereBuilder.Append("(\"eninvoice155\".\"folioid\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"eninvoice155\".\"name\" ASC ");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_FolioEditIncorrectInvoice.GetFolioFiles.GetInvoicesByFolioId.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_FolioEditIncorrectInvoice.GetFolioFiles.GetInvoicesByFolioId.List", cancellationToken: cancellationToken);
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
public static class FuncDataActionGetOrderMainItems {

// Query Function "GetOrdersItems" 8ByfHxfh9UCBK+uo7+OPFA of Action "GetOrderMainItems"
public static async Task<(RL_bab3397f952f07af0f0aa229e6f2b36e,long)> QueryGetOrdersItems(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporl_OrderIdSelected,int qpfoi_folioStatusIdCanceled,int qpfoi_folioStatusIdCanceledByProvider,long qpfoi_FolioId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("j_FoliosSAE.Wb_FolioEditIncorrectInvoice.GetOrderMainItems.GetOrdersItems", "1f9f1cf0-e117-40f5-812b-eba8efe38f14");
using var queryActivity = activitySource.CreateSqlQueryActivity("j_FoliosSAE.Wb_FolioEditIncorrectInvoice.GetOrderMainItems.GetOrdersItems", "1f9f1cf0-e117-40f5-812b-eba8efe38f14", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_FolioEditIncorrectInvoice.GetOrderMainItems.GetOrdersItems.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_FolioEditIncorrectInvoice.GetOrderMainItems.GetOrdersItems.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_bab3397f952f07af0f0aa229e6f2b36e)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetOrdersItems in GetOrderMainItems in Wb_FolioEditIncorrectInvoice in j_FoliosSAE in ConectaProveedores (SELECT       0,      {OrderMainItem}.Id,      {OrderMain}.[OrderNumber],      {OrderMainItem}.[Position],      {OrderMainItem}.[MaterialCode],      {OrderMainItem}.[MaterialDescription],      {OrderMainItem}.[Quantity],        {OrderMainItem}.[QuantityDelivered] + COALESCE((          SELECT SUM(CAST({FolioItems}.[InvoiceQtt] AS DECIMAL(18,3)))          FROM {FolioItems}          inner join {Folio} on {Folio}.[Id] = {FolioItems}.[FolioId]          WHERE {FolioItems}.[OrderMainItemId] = {OrderMainItem}.[Id]          and ({Folio}.[FolioStatusId] <> @i_folioStatusIdCanceled and {Folio}.[FolioStatusId] <> @i_folioStatusIdCanceledByProvider)          and {Folio}.[Id] <> @i_FolioId      ), 0),        {OrderMainItem}.[Quantity] - {OrderMainItem}.[QuantityDelivered] - COALESCE((          SELECT SUM(CAST({FolioItems}.[InvoiceQtt] AS DECIMAL(18,3)))          FROM {FolioItems}          inner join {Folio} on {Folio}.[Id] = {FolioItems}.[FolioId]          WHERE {FolioItems}.[OrderMainItemId] = {Orde ...): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetOrdersItems in GetOrderMainItems in Wb_FolioEditIncorrectInvoice in j_FoliosSAE in ConectaProveedores (SELECT       0,      {OrderMainItem}.Id,      {OrderMain}.[OrderNumber],      {OrderMainItem}.[Position],      {OrderMainItem}.[MaterialCode],      {OrderMainItem}.[MaterialDescription],      {OrderMainItem}.[Quantity],        {OrderMainItem}.[QuantityDelivered] + COALESCE((          SELECT SUM(CAST({FolioItems}.[InvoiceQtt] AS DECIMAL(18,3)))          FROM {FolioItems}          inner join {Folio} on {Folio}.[Id] = {FolioItems}.[FolioId]          WHERE {FolioItems}.[OrderMainItemId] = {OrderMainItem}.[Id]          and ({Folio}.[FolioStatusId] <> @i_folioStatusIdCanceled and {Folio}.[FolioStatusId] <> @i_folioStatusIdCanceledByProvider)          and {Folio}.[Id] <> @i_FolioId      ), 0),        {OrderMainItem}.[Quantity] - {OrderMainItem}.[QuantityDelivered] - COALESCE((          SELECT SUM(CAST({FolioItems}.[InvoiceQtt] AS DECIMAL(18,3)))          FROM {FolioItems}          inner join {Folio} on {Folio}.[Id] = {FolioItems}.[FolioId]          WHERE {FolioItems}.[OrderMainItemId] = {Orde ...): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetOrdersItems in GetOrderMainItems in Wb_FolioEditIncorrectInvoice in j_FoliosSAE in ConectaProveedores (SELECT       0,      {OrderMainItem}.Id,      {OrderMain}.[OrderNumber],      {OrderMainItem}.[Position],      {OrderMainItem}.[MaterialCode],      {OrderMainItem}.[MaterialDescription],      {OrderMainItem}.[Quantity],        {OrderMainItem}.[QuantityDelivered] + COALESCE((          SELECT SUM(CAST({FolioItems}.[InvoiceQtt] AS DECIMAL(18,3)))          FROM {FolioItems}          inner join {Folio} on {Folio}.[Id] = {FolioItems}.[FolioId]          WHERE {FolioItems}.[OrderMainItemId] = {OrderMainItem}.[Id]          and ({Folio}.[FolioStatusId] <> @i_folioStatusIdCanceled and {Folio}.[FolioStatusId] <> @i_folioStatusIdCanceledByProvider)          and {Folio}.[Id] <> @i_FolioId      ), 0),        {OrderMainItem}.[Quantity] - {OrderMainItem}.[QuantityDelivered] - COALESCE((          SELECT SUM(CAST({FolioItems}.[InvoiceQtt] AS DECIMAL(18,3)))          FROM {FolioItems}          inner join {Folio} on {Folio}.[Id] = {FolioItems}.[FolioId]          WHERE {FolioItems}.[OrderMainItemId] = {Orde ...): " + aqExcep.Message));
}
}
}
}
public static class FuncDataActionGetSummary {

// Query Function "GetTotalFromOriginal" 4Jl2dauJfUqZLX1Znl+z7w of Action "GetSummary"
public static async Task<(RL_312927afcf3eb9d5fa3bc02bbc91d978,long)> datasetGetTotalFromOriginal(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderMainId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("j_FoliosSAE.Wb_FolioEditIncorrectInvoice.GetSummary.GetTotalFromOriginal", "757699e0-89ab-4a7d-992d-7d599e5fb3ef");
using var queryActivity = activitySource.CreateAggregateQueryActivity("j_FoliosSAE.Wb_FolioEditIncorrectInvoice.GetSummary.GetTotalFromOriginal", "757699e0-89ab-4a7d-992d-7d599e5fb3ef", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.BFvPY+s2IEqFd5ZaHcI0qA/DataActions.VhJr7ML+uUS2FCHVu_wX2A/NodesNotShownInESpaceTree.4Jl2dauJfUqZLX1Znl+z7w, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT Sum((\"enordermainitem29\".\"quantitydelivered\" * (\"enordermainitem29\".\"unitprice\" / cast(\"enordermainitem29\".\"basequantity\" as decimal)))) \"totalsapsum\"");
fromBuilder.Append(" FROM {OrderMainItem} \"enordermainitem29\"");
whereBuilder.Append(" WHERE ");
if (qporOrderMainId != 0) {
whereBuilder.Append("((\"enordermainitem29\".\"ordermainid\" = @qporOrderMainId) AND (\"enordermainitem29\".\"ordermainid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderMainId", DbType.Int64, qporOrderMainId);
} else {
whereBuilder.Append("(\"enordermainitem29\".\"ordermainid\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_FolioEditIncorrectInvoice.GetSummary.GetTotalFromOriginal.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_FolioEditIncorrectInvoice.GetSummary.GetTotalFromOriginal.List", cancellationToken: cancellationToken);
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

// Query Function "GetTotalAmountDelivered" _Yjpd5Mn40COhHHlJwJIVQ of Action "GetSummary"
public static async Task<(RL_d3c140b81b16482eac14fd0448f33de5,long)> datasetGetTotalAmountDelivered(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolio_Id,long qporFolio_OrderId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("j_FoliosSAE.Wb_FolioEditIncorrectInvoice.GetSummary.GetTotalAmountDelivered", "77e988fd-2793-40e3-8e84-71e527024855");
using var queryActivity = activitySource.CreateAggregateQueryActivity("j_FoliosSAE.Wb_FolioEditIncorrectInvoice.GetSummary.GetTotalAmountDelivered", "77e988fd-2793-40e3-8e84-71e527024855", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.BFvPY+s2IEqFd5ZaHcI0qA/DataActions.VhJr7ML+uUS2FCHVu_wX2A/NodesNotShownInESpaceTree._Yjpd5Mn40COhHHlJwJIVQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT Sum(\"enfolioitems15\".\"totalprice\") \"totalpricesum\"");
fromBuilder.Append(" FROM ({Folio} \"enfolio96\" Left JOIN {FolioItems} \"enfolioitems15\" ON (\"enfolio96\".\"id\" = \"enfolioitems15\".\"folioid\")) ");
whereBuilder.Append(" WHERE ");
if (qporFolio_OrderId != 0) {
whereBuilder.Append("((\"enfolio96\".\"orderid\" = @qporFolio_OrderId) AND (\"enfolio96\".\"orderid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporFolio_OrderId", DbType.Int64, qporFolio_OrderId);
} else {
whereBuilder.Append("(\"enfolio96\".\"orderid\" IS NULL)");
}
whereBuilder.Append(" AND ((\"enfolio96\".\"foliostatusid\" <> ");
whereBuilder.Append((ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("cklscJNc0UyOgKXGwg51TQ"))).ssId);
whereBuilder.Append(") AND (\"enfolio96\".\"foliostatusid\" <> ");
whereBuilder.Append((ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("l5OG661dZEe+gAZwnNLhSA"))).ssId);
whereBuilder.Append(")) AND ");
if (qpfoFolio_Id != 0) {
whereBuilder.Append("((\"enfolio96\".\"id\" <> @qpfoFolio_Id) OR (\"enfolio96\".\"id\" IS NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolio_Id", DbType.Int64, qpfoFolio_Id);
} else {
whereBuilder.Append("(\"enfolio96\".\"id\" IS NOT NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_FolioEditIncorrectInvoice.GetSummary.GetTotalAmountDelivered.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_FolioEditIncorrectInvoice.GetSummary.GetTotalAmountDelivered.List", cancellationToken: cancellationToken);
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

// Query Function "GetOrderItemEntries" p8XWl7HGsU+3NEQTLE5KRA of Action "GetSummary"
public static async Task<(RL_ecf075efbdf79b05fa564fa6ba80a9c6,long)> datasetGetOrderItemEntries(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderMain_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("j_FoliosSAE.Wb_FolioEditIncorrectInvoice.GetSummary.GetOrderItemEntries", "97d6c5a7-c6b1-4fb1-b734-44132c4e4a44");
using var queryActivity = activitySource.CreateAggregateQueryActivity("j_FoliosSAE.Wb_FolioEditIncorrectInvoice.GetSummary.GetOrderItemEntries", "97d6c5a7-c6b1-4fb1-b734-44132c4e4a44", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.BFvPY+s2IEqFd5ZaHcI0qA/DataActions.VhJr7ML+uUS2FCHVu_wX2A/NodesNotShownInESpaceTree.p8XWl7HGsU+3NEQTLE5KRA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT Sum((\"enorderitementries6\".\"quantity_\" * (\"enordermainitem30\".\"unitprice\" / cast(\"enordermainitem30\".\"basequantity\" as decimal)))) \"totalsum\"");
fromBuilder.Append(" FROM (({OrderItemEntries} \"enorderitementries6\" Inner JOIN {OrderMainItem} \"enordermainitem30\" ON (\"enorderitementries6\".\"ordermainitemid\" = \"enordermainitem30\".\"id\"))  Inner JOIN {OrderMain} \"enordermain136\" ON (\"enordermainitem30\".\"ordermainid\" = \"enordermain136\".\"id\")) ");
whereBuilder.Append(" WHERE (\"enorderitementries6\".\"quantity_\" > cast(0 as decimal)) AND ");
if (qporOrderMain_Id != 0) {
whereBuilder.Append("((\"enordermain136\".\"id\" = @qporOrderMain_Id) AND (\"enordermain136\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderMain_Id", DbType.Int64, qporOrderMain_Id);
} else {
whereBuilder.Append("(\"enordermain136\".\"id\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_FolioEditIncorrectInvoice.GetSummary.GetOrderItemEntries.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_FolioEditIncorrectInvoice.GetSummary.GetOrderItemEntries.List", cancellationToken: cancellationToken);
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

private static async Task<RC_a074711a91fd2441798a860685e4898b> datasetGetOrderMainByIdReadDbAsync(RC_a074711a91fd2441798a860685e4898b rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENCurrency.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
return rec;
}
// Query Function "GetOrderMainById" CEXy7OgqaUeIxAnSwn8QHw of Action "GetSummary"
public static async Task<(RL_164e5439119ae8b31002cd319dbe8413,long)> datasetGetOrderMainById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderMain_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("j_FoliosSAE.Wb_FolioEditIncorrectInvoice.GetSummary.GetOrderMainById", "ecf24508-2ae8-4769-88c4-09d2c27f101f");
using var queryActivity = activitySource.CreateAggregateQueryActivity("j_FoliosSAE.Wb_FolioEditIncorrectInvoice.GetSummary.GetOrderMainById", "ecf24508-2ae8-4769-88c4-09d2c27f101f", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.BFvPY+s2IEqFd5ZaHcI0qA/DataActions.VhJr7ML+uUS2FCHVu_wX2A/NodesNotShownInESpaceTree.CEXy7OgqaUeIxAnSwn8QHw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"encurrency47\".\"code\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, trim_scale(\"enordermain137\".\"totalamount\"::numeric) o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33");
fromBuilder.Append(" FROM ({OrderMain} \"enordermain137\" Left JOIN {Currency} \"encurrency47\" ON (\"enordermain137\".\"currencyid\" = \"encurrency47\".\"code\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderMain_Id != 0) {
whereBuilder.Append("((\"enordermain137\".\"id\" = @qporOrderMain_Id) AND (\"enordermain137\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderMain_Id", DbType.Int64, qporOrderMain_Id);
} else {
whereBuilder.Append("(\"enordermain137\".\"id\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_FolioEditIncorrectInvoice.GetSummary.GetOrderMainById.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_FolioEditIncorrectInvoice.GetSummary.GetOrderMainById.List", cancellationToken: cancellationToken);
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
}


}
