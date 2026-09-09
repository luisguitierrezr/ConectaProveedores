using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUploadUpdate_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUploadUpdate_ScreenModel).Namespace);

    public long inParamOrderMainId;
public bool inParamShowTitle;
public long inParamFolioId;
public decimal inParamImportAnticipo;
public bool inParami_IsEnable;
public string varLcErrorMsg;
public RL_1501ee54ff868a67eff67465502ee3d9 varLcFilesList;
public RL_1501ee54ff868a67eff67465502ee3d9 varLcCreditNoteFilesList;
public bool varLcIsOpenPopupForeigner;
public ST_6f620840109ac6f721328b723ec0152cStructure varLcInvoiceForeign;
public bool varLcIsUploadCreditNote;
public EN_d1d0320db36efbb094ad0082361435a0EntityRecord varLcToStore_Invoice;
public string varLcToStore_ClaveProdServ;
public string varLcToStore_TipoDeComprobante;
public bool varLcl_IsEnable;
public AggregateRecord<RL_ff28012de5324af3e81e5ace09ecb1f0> ScreenDataSetGetInvoiceFiles;
public AggregateRecord<RL_ff28012de5324af3e81e5ace09ecb1f0> ScreenDataSetGetCreditNoteInvoiceFiles;
public ConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUploadUpdate_DataActionGetSupplier_Model varLcGetSupplier;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUploadUpdate_ScreenModel() {
}



    public ConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUploadUpdate_ScreenModel(long inParamOrderMainId, bool inParamShowTitle, long inParamFolioId, decimal inParamImportAnticipo, bool inParami_IsEnable, string varLcErrorMsg, RL_1501ee54ff868a67eff67465502ee3d9 varLcFilesList, RL_1501ee54ff868a67eff67465502ee3d9 varLcCreditNoteFilesList, bool varLcIsOpenPopupForeigner, ST_6f620840109ac6f721328b723ec0152cStructure varLcInvoiceForeign, bool varLcIsUploadCreditNote, EN_d1d0320db36efbb094ad0082361435a0EntityRecord varLcToStore_Invoice, string varLcToStore_ClaveProdServ, string varLcToStore_TipoDeComprobante, bool varLcl_IsEnable, AggregateRecord<RL_ff28012de5324af3e81e5ace09ecb1f0> ScreenDataSetGetInvoiceFiles, AggregateRecord<RL_ff28012de5324af3e81e5ace09ecb1f0> ScreenDataSetGetCreditNoteInvoiceFiles, ConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUploadUpdate_DataActionGetSupplier_Model varLcGetSupplier, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"OrderMainId", "ShowTitle", "FolioId", "ImportAnticipo", "i_IsEnable", "ErrorMsg", "FilesList", "CreditNoteFilesList", "IsOpenPopupForeigner", "InvoiceForeign", "IsUploadCreditNote", "ToStore_Invoice", "ToStore_ClaveProdServ", "ToStore_TipoDeComprobante", "l_IsEnable", "GetInvoiceFiles", "GetCreditNoteInvoiceFiles", "GetSupplier", "ClientVars"}, new string[] {"inParamOrderMainId", "inParamShowTitle", "inParamFolioId", "inParamImportAnticipo", "inParami_IsEnable", "varLcErrorMsg", "varLcFilesList", "varLcCreditNoteFilesList", "varLcIsOpenPopupForeigner", "varLcInvoiceForeign", "varLcIsUploadCreditNote", "varLcToStore_Invoice", "varLcToStore_ClaveProdServ", "varLcToStore_TipoDeComprobante", "varLcl_IsEnable", "ScreenDataSetGetInvoiceFiles", "ScreenDataSetGetCreditNoteInvoiceFiles", "varLcGetSupplier", "clientVariables"});
this.inParamOrderMainId = inParamOrderMainId;
this.inParamShowTitle = inParamShowTitle;
this.inParamFolioId = inParamFolioId;
this.inParamImportAnticipo = inParamImportAnticipo;
this.inParami_IsEnable = inParami_IsEnable;
this.varLcErrorMsg = varLcErrorMsg;
this.varLcFilesList = varLcFilesList;
this.varLcCreditNoteFilesList = varLcCreditNoteFilesList;
this.varLcIsOpenPopupForeigner = varLcIsOpenPopupForeigner;
this.varLcInvoiceForeign = varLcInvoiceForeign;
this.varLcIsUploadCreditNote = varLcIsUploadCreditNote;
this.varLcToStore_Invoice = varLcToStore_Invoice;
this.varLcToStore_ClaveProdServ = varLcToStore_ClaveProdServ;
this.varLcToStore_TipoDeComprobante = varLcToStore_TipoDeComprobante;
this.varLcl_IsEnable = varLcl_IsEnable;
this.ScreenDataSetGetInvoiceFiles = ScreenDataSetGetInvoiceFiles;
this.ScreenDataSetGetCreditNoteInvoiceFiles = ScreenDataSetGetCreditNoteInvoiceFiles;
this.varLcGetSupplier = varLcGetSupplier;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_2b77a78552d1dad3876c3ebd8f5c8ec1> datasetGetInvoiceFilesReadDbAsync(RC_2b77a78552d1dad3876c3ebd8f5c8ec1 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceFile.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceFiles" VmFeByaY3EGOT5uIbW53ig of Action "Wb_InvoiceSAECUploadUpdate"
public static async Task<(RL_ff28012de5324af3e81e5ace09ecb1f0,long)> datasetGetInvoiceFiles(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoInvoice_FolioId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.Wb_InvoiceSAECUploadUpdate.GetInvoiceFiles", "075e6156-9826-41dc-8e4f-9b886d6e778a");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_InvoiceSAECUploadUpdate","j_FoliosSAE.Wb_InvoiceSAECUploadUpdate.GetInvoiceFiles");
// Query Iterations: Multiple
// Refresh Query UeDMMPlH_E6GMr56tccyNQ Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.OvHCK31uZUebjDrapXT4WA/ScreenDataSets.VmFeByaY3EGOT5uIbW53ig, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, \"eninvoice146\".\"creditnoteinvoiceid\" o23, NULL o24, NULL o25, \"eninvoicefile51\".\"filename\" o26, \"eninvoicefile51\".\"isextra\" o27, NULL o28, \"eninvoicefile51\".\"storageid\" o29, NULL o30, NULL o31");
fromBuilder.Append(" FROM ({InvoiceFile} \"eninvoicefile51\" Inner JOIN {Invoice} \"eninvoice146\" ON (\"eninvoicefile51\".\"invoiceid\" = \"eninvoice146\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoInvoice_FolioId != 0) {
whereBuilder.Append("((\"eninvoice146\".\"folioid\" = @qpfoInvoice_FolioId) AND (\"eninvoice146\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoInvoice_FolioId", DbType.Int64, qpfoInvoice_FolioId);
} else {
whereBuilder.Append("(\"eninvoice146\".\"folioid\" IS NULL)");
}
whereBuilder.Append(" AND (\"eninvoicefile51\".\"isextra\" = 0)");
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
outParamList.AlternateReadDbMethodAsync = datasetGetInvoiceFilesReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false});
opt[1] = new BitArray(new bool[] {true, true, false, false, true, false, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_InvoiceSAECUploadUpdate.GetInvoiceFiles.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_ff28012de5324af3e81e5ace09ecb1f0 _tmp = new RL_ff28012de5324af3e81e5ace09ecb1f0();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoiceFilesReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_InvoiceSAECUploadUpdate.GetInvoiceFiles.List", cancellationToken: cancellationToken);
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

private static async Task<RC_2b77a78552d1dad3876c3ebd8f5c8ec1> datasetGetCreditNoteInvoiceFilesReadDbAsync(RC_2b77a78552d1dad3876c3ebd8f5c8ec1 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceFile.Read( r, ref index);
return rec;
}
// Query Function "GetCreditNoteInvoiceFiles" OCPZeJPb0U28tffxhlr6CQ of Action "Wb_InvoiceSAECUploadUpdate"
public static async Task<(RL_ff28012de5324af3e81e5ace09ecb1f0,long)> datasetGetCreditNoteInvoiceFiles(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceFile_InvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.Wb_InvoiceSAECUploadUpdate.GetCreditNoteInvoiceFiles", "78d92338-db93-4dd1-bcb5-f7f1865afa09");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_InvoiceSAECUploadUpdate","j_FoliosSAE.Wb_InvoiceSAECUploadUpdate.GetCreditNoteInvoiceFiles");
// Query Iterations: Multiple
// Refresh Query mfT_GyDV402z_xc6umsacw Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.OvHCK31uZUebjDrapXT4WA/ScreenDataSets.OCPZeJPb0U28tffxhlr6CQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoice147\".\"id\" o0, \"eninvoice147\".\"name\" o1, \"eninvoice147\".\"requisitionid\" o2, \"eninvoice147\".\"folioid\" o3, \"eninvoice147\".\"ordermainid\" o4, \"eninvoice147\".\"cfditypeid\" o5, trim_scale(\"eninvoice147\".\"totalamount\"::numeric) o6, \"eninvoice147\".\"currency\" o7, \"eninvoice147\".\"invoicestatusid\" o8, \"eninvoice147\".\"accountingdatetime\" o9, \"eninvoice147\".\"paymentdatetime\" o10, \"eninvoice147\".\"createdon\" o11, \"eninvoice147\".\"createdby\" o12, \"eninvoice147\".\"updatedon\" o13, \"eninvoice147\".\"updatedby\" o14, \"eninvoice147\".\"submittedon\" o15, \"eninvoice147\".\"isnewversion\" o16, \"eninvoice147\".\"id_poliza\" o17, \"eninvoice147\".\"id_poliza_sap\" o18, \"eninvoice147\".\"doc51\" o19, \"eninvoice147\".\"accountingerror\" o20, \"eninvoice147\".\"orderaccconceptsid\" o21, trim_scale(\"eninvoice147\".\"amortization\"::numeric) o22, \"eninvoice147\".\"creditnoteinvoiceid\" o23, NULL o24, NULL o25, \"eninvoicefile52\".\"filename\" o26, \"eninvoicefile52\".\"isextra\" o27, NULL o28, \"eninvoicefile52\".\"storageid\" o29, NULL o30, NULL o31");
fromBuilder.Append(" FROM ({InvoiceFile} \"eninvoicefile52\" Inner JOIN {Invoice} \"eninvoice147\" ON (\"eninvoicefile52\".\"invoiceid\" = \"eninvoice147\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceFile_InvoiceId != 0) {
whereBuilder.Append("((\"eninvoicefile52\".\"invoiceid\" = @qpinInvoiceFile_InvoiceId) AND (\"eninvoicefile52\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceFile_InvoiceId", DbType.Int64, qpinInvoiceFile_InvoiceId);
} else {
whereBuilder.Append("(\"eninvoicefile52\".\"invoiceid\" IS NULL)");
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
outParamList.AlternateReadDbMethodAsync = datasetGetCreditNoteInvoiceFilesReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {true, true, false, false, true, false, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_InvoiceSAECUploadUpdate.GetCreditNoteInvoiceFiles.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_ff28012de5324af3e81e5ace09ecb1f0 _tmp = new RL_ff28012de5324af3e81e5ace09ecb1f0();
_tmp.AlternateReadDbMethodAsync = datasetGetCreditNoteInvoiceFilesReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_InvoiceSAECUploadUpdate.GetCreditNoteInvoiceFiles.List", cancellationToken: cancellationToken);
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


    public class lcvGetSupplier : VarsBag {
public RL_39c65c63eb449ac42634373c1cc7f81a queryResGetSupplierById_outParamList = new RL_39c65c63eb449ac42634373c1cc7f81a();
public long queryResGetSupplierById_outParamCount = 0L;

public lcvGetSupplier() {
}
}
public class lcoGetSupplier : VarsBag {
public string outParamExpedicionFiscal = "";

public string outParamName = "";

public string outParamRFC = "";

public string outParamSociety = "";

public string outParamSupplierNr = "";

public bool outParamIsNational = false;

public bool outParamIsActiveDEV_TK395 = false;

public lcoGetSupplier() {
}
}
/// <summary>
/// Action <code>GetSupplier</code> that represents the Service Studio action <code>GetSupplier</code>
///  <p> Description: </p>
/// </summary>
public async Task<(string,string,string,string,string,bool,bool)> DataActionGetSupplier(IRequestContext requestContext,CancellationToken cancellationToken) {
string outParamExpedicionFiscal = default;
string outParamName = default;
string outParamRFC = default;
string outParamSociety = default;
string outParamSupplierNr = default;
bool outParamIsNational = default;
bool outParamIsActiveDEV_TK395 = default;
lcoGetSupplier result = new lcoGetSupplier();
lcvGetSupplier localVars = new lcvGetSupplier();
ConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUploadUpdate_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetSupplier", "0d97e263-8569-46b5-88d2-77cea011c6fa"))
using (activitySource.CreateScreenDataActionActivity("Wb_InvoiceSAECUploadUpdate", "GetSupplier")){
// Query datasetGetSupplierById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetSupplierById_maxRecords = 1;
if (datasetGetSupplierById_maxRecords < 1) datasetGetSupplierById_maxRecords = 1;
int datasetGetSupplierById_startIndex = 0;(localVars.queryResGetSupplierById_outParamList,localVars.queryResGetSupplierById_outParamCount) = await FuncDataActionGetSupplier.datasetGetSupplierById(requestContext,datasetGetSupplierById_maxRecords,datasetGetSupplierById_startIndex,IterationMultiplicity.Never,(await Functions.ActionGetUserSupplier(requestContext,"",cancellationToken)),cancellationToken);

// IsNational = GetSupplierById.List.Current.Supplier.Pais = "MX"
result.outParamIsNational=(localVars.queryResGetSupplierById_outParamList.CurrentRec.ssENSupplier.ssPais=="MX");

// Name = GetSupplierById.List.Current.Supplier.Name
result.outParamName=localVars.queryResGetSupplierById_outParamList.CurrentRec.ssENSupplier.ssName;

// RFC = GetSupplierById.List.Current.Supplier.N_ident_fis_1
result.outParamRFC=localVars.queryResGetSupplierById_outParamList.CurrentRec.ssENSupplier.ssN_ident_fis_1;

// ExpedicionFiscal = GetSupplierById.List.Current.Supplier.Codigopostal_Pobl_
result.outParamExpedicionFiscal=localVars.queryResGetSupplierById_outParamList.CurrentRec.ssENSupplier.ssCodigopostal_Pobl_;

// Society = GetSupplierById.List.Current.Company.ExternalId
result.outParamSociety=localVars.queryResGetSupplierById_outParamList.CurrentRec.ssENCompany.ssExternalId;

// SupplierNr = GetSupplierById.List.Current.Supplier.Number
result.outParamSupplierNr=localVars.queryResGetSupplierById_outParamList.CurrentRec.ssENSupplier.ssNumber;
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
outParamName = result.outParamName;
outParamRFC = result.outParamRFC;
outParamSociety = result.outParamSociety;
outParamSupplierNr = result.outParamSupplierNr;
outParamIsNational = result.outParamIsNational;
outParamIsActiveDEV_TK395 = result.outParamIsActiveDEV_TK395;
} // inner-finally
RETURN_STATEMENT:
return (outParamExpedicionFiscal,outParamName,outParamRFC,outParamSociety,outParamSupplierNr,outParamIsNational,outParamIsActiveDEV_TK395);
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
// Query Function "GetSupplierById" w5WkzZZsn0C5UJNqv34VPA of Action "GetSupplier"
public static async Task<(RL_39c65c63eb449ac42634373c1cc7f81a,long)> datasetGetSupplierById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpsuSupplier_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("j_FoliosSAE.Wb_InvoiceSAECUploadUpdate.GetSupplier.GetSupplierById", "cda495c3-6c96-409f-b950-936abf7e153c");
using var queryActivity = activitySource.CreateAggregateQueryActivity("j_FoliosSAE.Wb_InvoiceSAECUploadUpdate.GetSupplier.GetSupplierById", "cda495c3-6c96-409f-b950-936abf7e153c", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.OvHCK31uZUebjDrapXT4WA/DataActions.Y+KXDWmFtUaI0nfOoBHG+g/NodesNotShownInESpaceTree.w5WkzZZsn0C5UJNqv34VPA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, \"ensupplier132\".\"pais\" o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77");
fromBuilder.Append(" FROM ((({Supplier} \"ensupplier132\" Left JOIN {SupplierDetail} \"ensupplierdetail8\" ON (\"ensupplier132\".\"id\" = \"ensupplierdetail8\".\"supplierid\"))  Left JOIN {Company} \"encompany64\" ON (\"ensupplierdetail8\".\"sociedadeid\" = \"encompany64\".\"id\"))  Left JOIN {Region} \"enregion181\" ON (\"ensupplier132\".\"regionid\" = \"enregion181\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpsuSupplier_Id != 0) {
whereBuilder.Append("((\"ensupplier132\".\"id\" = @qpsuSupplier_Id) AND (\"ensupplier132\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuSupplier_Id", DbType.Int64, qpsuSupplier_Id);
} else {
whereBuilder.Append("(\"ensupplier132\".\"id\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_InvoiceSAECUploadUpdate.GetSupplier.GetSupplierById.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_InvoiceSAECUploadUpdate.GetSupplier.GetSupplierById.List", cancellationToken: cancellationToken);
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
