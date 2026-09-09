using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUpload_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUpload_ScreenModel).Namespace);

    public long inParamInvoiceId;
public long inParamRequisitionId;
public long inParamOrderId;
public long inParamFolioId;
public bool inParami_ShowOtherEvidences;
public decimal inParamImportAnticipo;
public long inParamCreditNoteInvoiceId;
public ST_6dc39d329f4b959722daa75bc2f62c1fStructure varLcAccData;
public string varLcErrorMsg;
public RL_7b4ceb84b6a1255d3a42c8932279bc3c varLcFilesList;
public RL_7b4ceb84b6a1255d3a42c8932279bc3c varLcExtraFilesList;
public RL_7b4ceb84b6a1255d3a42c8932279bc3c varLcCreditNoteFilesList;
public bool varLcHasChanged;
public ST_6f620840109ac6f721328b723ec0152cStructure varLcInvoiceForeign;
public bool varLcIsExecuting;
public bool varLcIsLoading;
public bool varLcIsSaving;
public bool varLcIsShowForeignInvoice;
public bool varLcIsUploadCreditNote;
public AggregateRecord<RL_ff28012de5324af3e81e5ace09ecb1f0> ScreenDataSetGetInvoiceCreditNoteById;
public AggregateRecord<RL_00a03f803f0d49826089181417370afb> ScreenDataSetGetInvoiceFilesByInvoiceId;
public AggregateRecord<RL_5198a019df57be180483639cd138aad4> ScreenDataSetGetInvoiceExtendedForeignerById;
public AggregateRecord<RL_4f8b259bdd04db22be8fb771f1ad1d4f> ScreenDataSetGetFolioById;
public ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUpload_DataActionGetInvoicesByRequisitionOrFolio_Model varLcGetInvoicesByRequisitionOrFolio;
public ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUpload_DataActionGetSupplier_Model varLcGetSupplier;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUpload_ScreenModel() {
}



    public ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUpload_ScreenModel(long inParamInvoiceId, long inParamRequisitionId, long inParamOrderId, long inParamFolioId, bool inParami_ShowOtherEvidences, decimal inParamImportAnticipo, long inParamCreditNoteInvoiceId, ST_6dc39d329f4b959722daa75bc2f62c1fStructure varLcAccData, string varLcErrorMsg, RL_7b4ceb84b6a1255d3a42c8932279bc3c varLcFilesList, RL_7b4ceb84b6a1255d3a42c8932279bc3c varLcExtraFilesList, RL_7b4ceb84b6a1255d3a42c8932279bc3c varLcCreditNoteFilesList, bool varLcHasChanged, ST_6f620840109ac6f721328b723ec0152cStructure varLcInvoiceForeign, bool varLcIsExecuting, bool varLcIsLoading, bool varLcIsSaving, bool varLcIsShowForeignInvoice, bool varLcIsUploadCreditNote, AggregateRecord<RL_ff28012de5324af3e81e5ace09ecb1f0> ScreenDataSetGetInvoiceCreditNoteById, AggregateRecord<RL_00a03f803f0d49826089181417370afb> ScreenDataSetGetInvoiceFilesByInvoiceId, AggregateRecord<RL_5198a019df57be180483639cd138aad4> ScreenDataSetGetInvoiceExtendedForeignerById, AggregateRecord<RL_4f8b259bdd04db22be8fb771f1ad1d4f> ScreenDataSetGetFolioById, ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUpload_DataActionGetInvoicesByRequisitionOrFolio_Model varLcGetInvoicesByRequisitionOrFolio, ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUpload_DataActionGetSupplier_Model varLcGetSupplier, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"InvoiceId", "RequisitionId", "OrderId", "FolioId", "i_ShowOtherEvidences", "ImportAnticipo", "CreditNoteInvoiceId", "AccData", "ErrorMsg", "FilesList", "ExtraFilesList", "CreditNoteFilesList", "HasChanged", "InvoiceForeign", "IsExecuting", "IsLoading", "IsSaving", "IsShowForeignInvoice", "IsUploadCreditNote", "GetInvoiceCreditNoteById", "GetInvoiceFilesByInvoiceId", "GetInvoiceExtendedForeignerById", "GetFolioById", "GetInvoicesByRequisitionOrFolio", "GetSupplier", "ClientVars"}, new string[] {"inParamInvoiceId", "inParamRequisitionId", "inParamOrderId", "inParamFolioId", "inParami_ShowOtherEvidences", "inParamImportAnticipo", "inParamCreditNoteInvoiceId", "varLcAccData", "varLcErrorMsg", "varLcFilesList", "varLcExtraFilesList", "varLcCreditNoteFilesList", "varLcHasChanged", "varLcInvoiceForeign", "varLcIsExecuting", "varLcIsLoading", "varLcIsSaving", "varLcIsShowForeignInvoice", "varLcIsUploadCreditNote", "ScreenDataSetGetInvoiceCreditNoteById", "ScreenDataSetGetInvoiceFilesByInvoiceId", "ScreenDataSetGetInvoiceExtendedForeignerById", "ScreenDataSetGetFolioById", "varLcGetInvoicesByRequisitionOrFolio", "varLcGetSupplier", "clientVariables"});
this.inParamInvoiceId = inParamInvoiceId;
this.inParamRequisitionId = inParamRequisitionId;
this.inParamOrderId = inParamOrderId;
this.inParamFolioId = inParamFolioId;
this.inParami_ShowOtherEvidences = inParami_ShowOtherEvidences;
this.inParamImportAnticipo = inParamImportAnticipo;
this.inParamCreditNoteInvoiceId = inParamCreditNoteInvoiceId;
this.varLcAccData = varLcAccData;
this.varLcErrorMsg = varLcErrorMsg;
this.varLcFilesList = varLcFilesList;
this.varLcExtraFilesList = varLcExtraFilesList;
this.varLcCreditNoteFilesList = varLcCreditNoteFilesList;
this.varLcHasChanged = varLcHasChanged;
this.varLcInvoiceForeign = varLcInvoiceForeign;
this.varLcIsExecuting = varLcIsExecuting;
this.varLcIsLoading = varLcIsLoading;
this.varLcIsSaving = varLcIsSaving;
this.varLcIsShowForeignInvoice = varLcIsShowForeignInvoice;
this.varLcIsUploadCreditNote = varLcIsUploadCreditNote;
this.ScreenDataSetGetInvoiceCreditNoteById = ScreenDataSetGetInvoiceCreditNoteById;
this.ScreenDataSetGetInvoiceFilesByInvoiceId = ScreenDataSetGetInvoiceFilesByInvoiceId;
this.ScreenDataSetGetInvoiceExtendedForeignerById = ScreenDataSetGetInvoiceExtendedForeignerById;
this.ScreenDataSetGetFolioById = ScreenDataSetGetFolioById;
this.varLcGetInvoicesByRequisitionOrFolio = varLcGetInvoicesByRequisitionOrFolio;
this.varLcGetSupplier = varLcGetSupplier;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_2b77a78552d1dad3876c3ebd8f5c8ec1> datasetGetInvoiceCreditNoteByIdReadDbAsync(RC_2b77a78552d1dad3876c3ebd8f5c8ec1 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceFile.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceCreditNoteById" Wf7KFf0WBkuX0n7G5AdizQ of Action "Wb_PopupInvoiceUpload"
public static async Task<(RL_ff28012de5324af3e81e5ace09ecb1f0,long)> datasetGetInvoiceCreditNoteById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoice_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("d_InvoicePopups.Wb_PopupInvoiceUpload.GetInvoiceCreditNoteById", "15cafe59-16fd-4b06-97d2-7ec6e40762cd");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_PopupInvoiceUpload","d_InvoicePopups.Wb_PopupInvoiceUpload.GetInvoiceCreditNoteById");
// Query Iterations: Single
// Refresh Query TMQDWIU3_0aUGaM6cdcWxg Iterations: Single
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
selectBuilder.Append("/* /NRWebFlows.mak5F1HCzk2BbukH+WQStA/NodesShownInESpaceTree.y228tc+AfUGOAizS2wHBrA/ScreenDataSets.Wf7KFf0WBkuX0n7G5AdizQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, \"eninvoicefile33\".\"id\" o24, NULL o25, \"eninvoicefile33\".\"filename\" o26, NULL o27, NULL o28, \"eninvoicefile33\".\"storageid\" o29, NULL o30, NULL o31");
fromBuilder.Append(" FROM ({Invoice} \"eninvoice99\" Inner JOIN {InvoiceFile} \"eninvoicefile33\" ON (\"eninvoice99\".\"id\" = \"eninvoicefile33\".\"invoiceid\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoice_Id != 0) {
whereBuilder.Append("((\"eninvoice99\".\"id\" = @qpinInvoice_Id) AND (\"eninvoice99\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoice_Id", DbType.Int64, qpinInvoice_Id);
} else {
whereBuilder.Append("(\"eninvoice99\".\"id\" IS NULL)");
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
RL_ff28012de5324af3e81e5ace09ecb1f0 outParamList = new RL_ff28012de5324af3e81e5ace09ecb1f0();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoiceCreditNoteByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {false, true, false, true, true, false, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_InvoicePopups.Wb_PopupInvoiceUpload.GetInvoiceCreditNoteById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_ff28012de5324af3e81e5ace09ecb1f0 _tmp = new RL_ff28012de5324af3e81e5ace09ecb1f0();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoiceCreditNoteByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_InvoicePopups.Wb_PopupInvoiceUpload.GetInvoiceCreditNoteById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_ff28012de5324af3e81e5ace09ecb1f0)_tmp;
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

// Query Function "GetInvoiceFilesByInvoiceId" CJFxLkR2ekSSPjTAjPdQWA of Action "Wb_PopupInvoiceUpload"
public static async Task<(RL_00a03f803f0d49826089181417370afb,long)> datasetGetInvoiceFilesByInvoiceId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("d_InvoicePopups.Wb_PopupInvoiceUpload.GetInvoiceFilesByInvoiceId", "2e719108-7644-447a-923e-34c08cf75058");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_PopupInvoiceUpload","d_InvoicePopups.Wb_PopupInvoiceUpload.GetInvoiceFilesByInvoiceId");
// Query Iterations: Multiple
// Refresh Query qPW+weqdy0SUamxmuvcxJg Iterations: Multiple
// Refresh Query vF+0RGdbmEmfVXFhSIPt3A Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.mak5F1HCzk2BbukH+WQStA/NodesShownInESpaceTree.y228tc+AfUGOAizS2wHBrA/ScreenDataSets.CJFxLkR2ekSSPjTAjPdQWA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoicefile34\".\"id\" o0, NULL o1, \"eninvoicefile34\".\"filename\" o2, \"eninvoicefile34\".\"isextra\" o3, NULL o4, \"eninvoicefile34\".\"storageid\" o5, NULL o6, NULL o7");
fromBuilder.Append(" FROM {InvoiceFile} \"eninvoicefile34\"");
whereBuilder.Append(" WHERE (");
if (qpinInvoiceId != 0) {
whereBuilder.Append("((\"eninvoicefile34\".\"invoiceid\" = @qpinInvoiceId) AND (\"eninvoicefile34\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceId", DbType.Int64, qpinInvoiceId);
} else {
whereBuilder.Append("(\"eninvoicefile34\".\"invoiceid\" IS NULL)");
}
whereBuilder.Append(" AND (@qpinInvoiceId <> 0))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceId", DbType.Int64, qpinInvoiceId);
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
RL_00a03f803f0d49826089181417370afb outParamList = new RL_00a03f803f0d49826089181417370afb();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, false, false, true, false, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_InvoicePopups.Wb_PopupInvoiceUpload.GetInvoiceFilesByInvoiceId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_00a03f803f0d49826089181417370afb _tmp = new RL_00a03f803f0d49826089181417370afb();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_InvoicePopups.Wb_PopupInvoiceUpload.GetInvoiceFilesByInvoiceId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_00a03f803f0d49826089181417370afb)_tmp;
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

// Query Function "GetInvoiceExtendedForeignerById" rtyBqtjQ00mSxUAJI5xvrg of Action "Wb_PopupInvoiceUpload"
public static async Task<(RL_5198a019df57be180483639cd138aad4,long)> datasetGetInvoiceExtendedForeignerById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("d_InvoicePopups.Wb_PopupInvoiceUpload.GetInvoiceExtendedForeignerById", "aa81dcae-d0d8-49d3-92c5-4009239c6fae");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_PopupInvoiceUpload","d_InvoicePopups.Wb_PopupInvoiceUpload.GetInvoiceExtendedForeignerById");
// Query Iterations: Never
// Refresh Query 4sUB0CCEikWEeyZbipbeGA Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.mak5F1HCzk2BbukH+WQStA/NodesShownInESpaceTree.y228tc+AfUGOAizS2wHBrA/ScreenDataSets.rtyBqtjQ00mSxUAJI5xvrg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"eninvoiceextendedforeigner1\".\"invoicenumber\" o1, \"eninvoiceextendedforeigner1\".\"direction\" o2, \"eninvoiceextendedforeigner1\".\"receiversocialreason\" o3, \"eninvoiceextendedforeigner1\".\"receiverrfc\" o4, \"eninvoiceextendedforeigner1\".\"issuersocialreason\" o5, \"eninvoiceextendedforeigner1\".\"issuertaxid\" o6, \"eninvoiceextendedforeigner1\".\"invoicedate\" o7, trim_scale(\"eninvoiceextendedforeigner1\".\"totalamount\"::numeric) o8, \"eninvoiceextendedforeigner1\".\"currency\" o9");
fromBuilder.Append(" FROM {InvoiceExtendedForeigner} \"eninvoiceextendedforeigner1\"");
whereBuilder.Append(" WHERE ");
if (qpinId != 0) {
whereBuilder.Append("((\"eninvoiceextendedforeigner1\".\"id\" = @qpinId) AND (\"eninvoiceextendedforeigner1\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinId", DbType.Int64, qpinId);
} else {
whereBuilder.Append("(\"eninvoiceextendedforeigner1\".\"id\" IS NULL)");
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
RL_5198a019df57be180483639cd138aad4 outParamList = new RL_5198a019df57be180483639cd138aad4();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_InvoicePopups.Wb_PopupInvoiceUpload.GetInvoiceExtendedForeignerById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_5198a019df57be180483639cd138aad4 _tmp = new RL_5198a019df57be180483639cd138aad4();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_InvoicePopups.Wb_PopupInvoiceUpload.GetInvoiceExtendedForeignerById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_5198a019df57be180483639cd138aad4)_tmp;
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

// Query Function "GetFolioById" v6b80veLk02ZbBFd_bX1Cg of Action "Wb_PopupInvoiceUpload"
public static async Task<(RL_4f8b259bdd04db22be8fb771f1ad1d4f,long)> datasetGetFolioById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("d_InvoicePopups.Wb_PopupInvoiceUpload.GetFolioById", "d2fca6bf-8bf7-4d93-996c-115dfdb5f50a");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_PopupInvoiceUpload","d_InvoicePopups.Wb_PopupInvoiceUpload.GetFolioById");
// Query Iterations: Never
// Refresh Query TT4ACFzuCU6zO1q0ghV3mA Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.mak5F1HCzk2BbukH+WQStA/NodesShownInESpaceTree.y228tc+AfUGOAizS2wHBrA/ScreenDataSets.v6b80veLk02ZbBFd_bX1Cg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, \"enfolio65\".\"foliostatusid\" o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19");
fromBuilder.Append(" FROM {Folio} \"enfolio65\"");
whereBuilder.Append(" WHERE ");
if (qpfoId != 0) {
whereBuilder.Append("((\"enfolio65\".\"id\" = @qpfoId) AND (\"enfolio65\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoId", DbType.Int64, qpfoId);
} else {
whereBuilder.Append("(\"enfolio65\".\"id\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_InvoicePopups.Wb_PopupInvoiceUpload.GetFolioById.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_InvoicePopups.Wb_PopupInvoiceUpload.GetFolioById.List", cancellationToken: cancellationToken);
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


    public class lcvGetInvoicesByRequisitionOrFolio : VarsBag {
public RL_ff28012de5324af3e81e5ace09ecb1f0 queryResGetInvoicesByRequisitionId_outParamList = new RL_ff28012de5324af3e81e5ace09ecb1f0();
public long queryResGetInvoicesByRequisitionId_outParamCount = 0L;

public RL_ff28012de5324af3e81e5ace09ecb1f0 queryResGetInvoicesByFolioId_outParamList = new RL_ff28012de5324af3e81e5ace09ecb1f0();
public long queryResGetInvoicesByFolioId_outParamCount = 0L;

public lcvGetInvoicesByRequisitionOrFolio() {
}
}
public class lcoGetInvoicesByRequisitionOrFolio : VarsBag {
public RL_ff28012de5324af3e81e5ace09ecb1f0 outParamInvoicesList = new RL_ff28012de5324af3e81e5ace09ecb1f0();

public lcoGetInvoicesByRequisitionOrFolio() {
}
}
/// <summary>
/// Action <code>GetInvoicesByRequisitionOrFolio</code> that represents the Service Studio action
///  <code>GetInvoicesByRequisitionOrFolio</code> <p> Description: </p>
/// </summary>
public async Task<RL_ff28012de5324af3e81e5ace09ecb1f0> DataActionGetInvoicesByRequisitionOrFolio(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_ff28012de5324af3e81e5ace09ecb1f0 outParamInvoicesList = default;
lcoGetInvoicesByRequisitionOrFolio result = new lcoGetInvoicesByRequisitionOrFolio();
lcvGetInvoicesByRequisitionOrFolio localVars = new lcvGetInvoicesByRequisitionOrFolio();
ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUpload_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetInvoicesByRequisitionOrFolio", "b6448e95-648f-4f31-8f9f-e712565c4ca7"))
using (activitySource.CreateScreenDataActionActivity("Wb_PopupInvoiceUpload", "GetInvoicesByRequisitionOrFolio")){
// no req
if(((inParamRequisitionId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// Query datasetGetInvoicesByFolioId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoicesByFolioId_maxRecords = 200;
if (datasetGetInvoicesByFolioId_maxRecords < 1) datasetGetInvoicesByFolioId_maxRecords = 1;
int datasetGetInvoicesByFolioId_startIndex = 0;(localVars.queryResGetInvoicesByFolioId_outParamList,localVars.queryResGetInvoicesByFolioId_outParamCount) = await FuncDataActionGetInvoicesByRequisitionOrFolio.datasetGetInvoicesByFolioId(requestContext,datasetGetInvoicesByFolioId_maxRecords,datasetGetInvoicesByFolioId_startIndex,IterationMultiplicity.Multiple,inParamFolioId,cancellationToken);

// InvoicesList = GetInvoicesByFolioId.List
result.outParamInvoicesList=localVars.queryResGetInvoicesByFolioId_outParamList;
} else {
// Query datasetGetInvoicesByRequisitionId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoicesByRequisitionId_maxRecords = 200;
if (datasetGetInvoicesByRequisitionId_maxRecords < 1) datasetGetInvoicesByRequisitionId_maxRecords = 1;
int datasetGetInvoicesByRequisitionId_startIndex = 0;(localVars.queryResGetInvoicesByRequisitionId_outParamList,localVars.queryResGetInvoicesByRequisitionId_outParamCount) = await FuncDataActionGetInvoicesByRequisitionOrFolio.datasetGetInvoicesByRequisitionId(requestContext,datasetGetInvoicesByRequisitionId_maxRecords,datasetGetInvoicesByRequisitionId_startIndex,IterationMultiplicity.Multiple,inParamRequisitionId,cancellationToken);

// InvoicesList = GetInvoicesByRequisitionId.List
result.outParamInvoicesList=localVars.queryResGetInvoicesByRequisitionId_outParamList;
}

} //close CreateActionActivity using block
} // try

finally {
outParamInvoicesList = result.outParamInvoicesList;
} // inner-finally
RETURN_STATEMENT:
return outParamInvoicesList;
}
public class lcvGetSupplier : VarsBag {
public RL_39c65c63eb449ac42634373c1cc7f81a queryResGetSupplierById_outParamList = new RL_39c65c63eb449ac42634373c1cc7f81a();
public long queryResGetSupplierById_outParamCount = 0L;

public lcvGetSupplier() {
}
}
public class lcoGetSupplier : VarsBag {
public string outParamExpedicionFiscal = "";

public bool outParamIsNational = false;

public string outParamName = "";

public string outParamRFC = "";

public string outParamSociety = "";

public bool outParamIsActiveDEV_TK395 = false;

public lcoGetSupplier() {
}
}
/// <summary>
/// Action <code>GetSupplier</code> that represents the Service Studio action <code>GetSupplier</code>
///  <p> Description: </p>
/// </summary>
public async Task<(string,bool,string,string,string,bool)> DataActionGetSupplier(IRequestContext requestContext,CancellationToken cancellationToken) {
string outParamExpedicionFiscal = default;
bool outParamIsNational = default;
string outParamName = default;
string outParamRFC = default;
string outParamSociety = default;
bool outParamIsActiveDEV_TK395 = default;
lcoGetSupplier result = new lcoGetSupplier();
lcvGetSupplier localVars = new lcvGetSupplier();
ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUpload_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetSupplier", "e6a10248-e8d2-42a1-8ef3-fd103721c792"))
using (activitySource.CreateScreenDataActionActivity("Wb_PopupInvoiceUpload", "GetSupplier")){
// Query datasetGetSupplierById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetSupplierById_maxRecords = 1;
if (datasetGetSupplierById_maxRecords < 1) datasetGetSupplierById_maxRecords = 1;
int datasetGetSupplierById_startIndex = 0;(localVars.queryResGetSupplierById_outParamList,localVars.queryResGetSupplierById_outParamCount) = await FuncDataActionGetSupplier.datasetGetSupplierById(requestContext,datasetGetSupplierById_maxRecords,datasetGetSupplierById_startIndex,IterationMultiplicity.Never,(await Functions.ActionGetUserSupplier(requestContext,"",cancellationToken)),cancellationToken);

// IsNational = Trim = "MX"
result.outParamIsNational=(BuiltInFunction.Trim (BuiltInFunction.ToUpper (localVars.queryResGetSupplierById_outParamList.CurrentRec.ssENSupplier.ssPais))=="MX");

// Name = GetSupplierById.List.Current.Supplier.Name
result.outParamName=localVars.queryResGetSupplierById_outParamList.CurrentRec.ssENSupplier.ssName;

// RFC = GetSupplierById.List.Current.Supplier.N_ident_fis_1
result.outParamRFC=localVars.queryResGetSupplierById_outParamList.CurrentRec.ssENSupplier.ssN_ident_fis_1;

// ExpedicionFiscal = GetSupplierById.List.Current.Supplier.Codigopostal_Pobl_
result.outParamExpedicionFiscal=localVars.queryResGetSupplierById_outParamList.CurrentRec.ssENSupplier.ssCodigopostal_Pobl_;

// Society = GetSupplierById.List.Current.Company.ExternalId
result.outParamSociety=localVars.queryResGetSupplierById_outParamList.CurrentRec.ssENCompany.ssExternalId;
// force foreign?
if((((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveForceForeignerSupplier]))))) {
// IsNational = False
result.outParamIsNational=false;
}

// IsActiveDEV_TK395 = IsActiveDEV_TK395
result.outParamIsActiveDEV_TK395=((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveDEV_TK395])));
} //close CreateActionActivity using block
} // try

finally {
outParamExpedicionFiscal = result.outParamExpedicionFiscal;
outParamIsNational = result.outParamIsNational;
outParamName = result.outParamName;
outParamRFC = result.outParamRFC;
outParamSociety = result.outParamSociety;
outParamIsActiveDEV_TK395 = result.outParamIsActiveDEV_TK395;
} // inner-finally
RETURN_STATEMENT:
return (outParamExpedicionFiscal,outParamIsNational,outParamName,outParamRFC,outParamSociety,outParamIsActiveDEV_TK395);
}


    public static class FuncDataActionGetInvoicesByRequisitionOrFolio {

private static async Task<RC_2b77a78552d1dad3876c3ebd8f5c8ec1> datasetGetInvoicesByRequisitionIdReadDbAsync(RC_2b77a78552d1dad3876c3ebd8f5c8ec1 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceFile.Read( r, ref index);
return rec;
}
// Query Function "GetInvoicesByRequisitionId" HUWEfT2QwEugAaghf4xZ3A of Action "GetInvoicesByRequisitionOrFolio"
public static async Task<(RL_ff28012de5324af3e81e5ace09ecb1f0,long)> datasetGetInvoicesByRequisitionId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreInvoice_RequisitionId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("d_InvoicePopups.Wb_PopupInvoiceUpload.GetInvoicesByRequisitionOrFolio.GetInvoicesByRequisitionId", "7d84451d-903d-4bc0-a001-a8217f8c59dc");
using var queryActivity = activitySource.CreateAggregateQueryActivity("d_InvoicePopups.Wb_PopupInvoiceUpload.GetInvoicesByRequisitionOrFolio.GetInvoicesByRequisitionId", "7d84451d-903d-4bc0-a001-a8217f8c59dc", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.mak5F1HCzk2BbukH+WQStA/NodesShownInESpaceTree.y228tc+AfUGOAizS2wHBrA/DataActions.lY5Eto9kMU+Pn+cSVlxMpw/NodesNotShownInESpaceTree.HUWEfT2QwEugAaghf4xZ3A, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoice100\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, \"eninvoicefile35\".\"filename\" o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31");
fromBuilder.Append(" FROM ({Invoice} \"eninvoice100\" Inner JOIN {InvoiceFile} \"eninvoicefile35\" ON (\"eninvoice100\".\"id\" = \"eninvoicefile35\".\"invoiceid\")) ");
whereBuilder.Append(" WHERE ");
if (qpreInvoice_RequisitionId != 0) {
whereBuilder.Append("((\"eninvoice100\".\"requisitionid\" = @qpreInvoice_RequisitionId) AND (\"eninvoice100\".\"requisitionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreInvoice_RequisitionId", DbType.Int64, qpreInvoice_RequisitionId);
} else {
whereBuilder.Append("(\"eninvoice100\".\"requisitionid\" IS NULL)");
}
whereBuilder.Append(" AND (\"eninvoice100\".\"invoicestatusid\" <> ");
whereBuilder.Append((ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("RteygpK6NkexqZHONe6zkg"))).ssId);
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
RL_ff28012de5324af3e81e5ace09ecb1f0 outParamList = new RL_ff28012de5324af3e81e5ace09ecb1f0();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoicesByRequisitionIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, false, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_InvoicePopups.Wb_PopupInvoiceUpload.GetInvoicesByRequisitionOrFolio.GetInvoicesByRequisitionId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_ff28012de5324af3e81e5ace09ecb1f0 _tmp = new RL_ff28012de5324af3e81e5ace09ecb1f0();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoicesByRequisitionIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_InvoicePopups.Wb_PopupInvoiceUpload.GetInvoicesByRequisitionOrFolio.GetInvoicesByRequisitionId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_ff28012de5324af3e81e5ace09ecb1f0)_tmp;
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

private static async Task<RC_2b77a78552d1dad3876c3ebd8f5c8ec1> datasetGetInvoicesByFolioIdReadDbAsync(RC_2b77a78552d1dad3876c3ebd8f5c8ec1 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceFile.Read( r, ref index);
return rec;
}
// Query Function "GetInvoicesByFolioId" nEaFzlILAUS3kxMmOdC4+w of Action "GetInvoicesByRequisitionOrFolio"
public static async Task<(RL_ff28012de5324af3e81e5ace09ecb1f0,long)> datasetGetInvoicesByFolioId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoInvoice_FolioId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("d_InvoicePopups.Wb_PopupInvoiceUpload.GetInvoicesByRequisitionOrFolio.GetInvoicesByFolioId", "ce85469c-0b52-4401-b793-132639d0b8fb");
using var queryActivity = activitySource.CreateAggregateQueryActivity("d_InvoicePopups.Wb_PopupInvoiceUpload.GetInvoicesByRequisitionOrFolio.GetInvoicesByFolioId", "ce85469c-0b52-4401-b793-132639d0b8fb", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.mak5F1HCzk2BbukH+WQStA/NodesShownInESpaceTree.y228tc+AfUGOAizS2wHBrA/DataActions.lY5Eto9kMU+Pn+cSVlxMpw/NodesNotShownInESpaceTree.nEaFzlILAUS3kxMmOdC4+w, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoice101\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, \"eninvoicefile36\".\"filename\" o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31");
fromBuilder.Append(" FROM ({Invoice} \"eninvoice101\" Inner JOIN {InvoiceFile} \"eninvoicefile36\" ON (\"eninvoice101\".\"id\" = \"eninvoicefile36\".\"invoiceid\")) ");
whereBuilder.Append(" WHERE (@qpfoInvoice_FolioId <> 0) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpfoInvoice_FolioId", DbType.Int64, qpfoInvoice_FolioId);
if (qpfoInvoice_FolioId != 0) {
whereBuilder.Append("((\"eninvoice101\".\"folioid\" = @qpfoInvoice_FolioId) AND (\"eninvoice101\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoInvoice_FolioId", DbType.Int64, qpfoInvoice_FolioId);
} else {
whereBuilder.Append("(\"eninvoice101\".\"folioid\" IS NULL)");
}
whereBuilder.Append(" AND (\"eninvoice101\".\"invoicestatusid\" <> ");
whereBuilder.Append((ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("RteygpK6NkexqZHONe6zkg"))).ssId);
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
RL_ff28012de5324af3e81e5ace09ecb1f0 outParamList = new RL_ff28012de5324af3e81e5ace09ecb1f0();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoicesByFolioIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, false, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_InvoicePopups.Wb_PopupInvoiceUpload.GetInvoicesByRequisitionOrFolio.GetInvoicesByFolioId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_ff28012de5324af3e81e5ace09ecb1f0 _tmp = new RL_ff28012de5324af3e81e5ace09ecb1f0();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoicesByFolioIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_InvoicePopups.Wb_PopupInvoiceUpload.GetInvoicesByRequisitionOrFolio.GetInvoicesByFolioId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_ff28012de5324af3e81e5ace09ecb1f0)_tmp;
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
public static class FuncDataActionGetSupplier {

private static async Task<RC_631f64667ced05b3101507560ed0f622> datasetGetSupplierByIdReadDbAsync(RC_631f64667ced05b3101507560ed0f622 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENCompany.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
rec.ssENSupplierDetail.Read( r, ref index);
return rec;
}
// Query Function "GetSupplierById" dI4josK7rUKt9pLhho3fVw of Action "GetSupplier"
public static async Task<(RL_39c65c63eb449ac42634373c1cc7f81a,long)> datasetGetSupplierById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpsuSupplier_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("d_InvoicePopups.Wb_PopupInvoiceUpload.GetSupplier.GetSupplierById", "a2238e74-bbc2-42ad-adf6-92e1868ddf57");
using var queryActivity = activitySource.CreateAggregateQueryActivity("d_InvoicePopups.Wb_PopupInvoiceUpload.GetSupplier.GetSupplierById", "a2238e74-bbc2-42ad-adf6-92e1868ddf57", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.mak5F1HCzk2BbukH+WQStA/NodesShownInESpaceTree.y228tc+AfUGOAizS2wHBrA/DataActions.SAKh5tLooUKO8_0QNyHHkg/NodesNotShownInESpaceTree.dI4josK7rUKt9pLhho3fVw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, \"ensupplier63\".\"pais\" o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77");
fromBuilder.Append(" FROM ((({Supplier} \"ensupplier63\" Left JOIN {SupplierDetail} \"ensupplierdetail2\" ON (\"ensupplier63\".\"id\" = \"ensupplierdetail2\".\"supplierid\"))  Left JOIN {Company} \"encompany25\" ON (\"ensupplierdetail2\".\"sociedadeid\" = \"encompany25\".\"id\"))  Left JOIN {Region} \"enregion80\" ON (\"ensupplier63\".\"regionid\" = \"enregion80\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpsuSupplier_Id != 0) {
whereBuilder.Append("((\"ensupplier63\".\"id\" = @qpsuSupplier_Id) AND (\"ensupplier63\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuSupplier_Id", DbType.Int64, qpsuSupplier_Id);
} else {
whereBuilder.Append("(\"ensupplier63\".\"id\" IS NULL)");
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
RL_39c65c63eb449ac42634373c1cc7f81a outParamList = new RL_39c65c63eb449ac42634373c1cc7f81a();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetSupplierByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[4];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_InvoicePopups.Wb_PopupInvoiceUpload.GetSupplier.GetSupplierById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_39c65c63eb449ac42634373c1cc7f81a _tmp = new RL_39c65c63eb449ac42634373c1cc7f81a();
_tmp.AlternateReadDbMethodAsync = datasetGetSupplierByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_InvoicePopups.Wb_PopupInvoiceUpload.GetSupplier.GetSupplierById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_39c65c63eb449ac42634373c1cc7f81a)_tmp;
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
