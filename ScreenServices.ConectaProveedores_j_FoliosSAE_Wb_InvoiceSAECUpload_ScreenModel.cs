using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUpload_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUpload_ScreenModel).Namespace);

    public bool inParamShowTitle;
public long inParamOrderId;
public bool inParamIsFromFolio;
public decimal inParamImportAnticipo;
public bool inParami_IsEnable;
public string varLcErrorMsg;
public RL_1501ee54ff868a67eff67465502ee3d9 varLcFilesList;
public RL_1501ee54ff868a67eff67465502ee3d9 varLcCreditNoteFilesList;
public bool varLcIsOpenPopupForeigner;
public ST_6f620840109ac6f721328b723ec0152cStructure varLcInvoiceForeign;
public ST_6dc39d329f4b959722daa75bc2f62c1fStructure varLcAccData;
public bool varLcIsUploadCreditNote;
public EN_d1d0320db36efbb094ad0082361435a0EntityRecord varLcToStore_Invoice;
public EN_f81a3d226103fd013068b8763798067aEntityRecord varLcToStore_InvoiceExtended;
public string varLcToStore_ClaveProdServ;
public string varLcToStore_TipoDeComprobante;
public ConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUpload_DataActionGetSupplier_Model varLcGetSupplier;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUpload_ScreenModel() {
}



    public ConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUpload_ScreenModel(bool inParamShowTitle, long inParamOrderId, bool inParamIsFromFolio, decimal inParamImportAnticipo, bool inParami_IsEnable, string varLcErrorMsg, RL_1501ee54ff868a67eff67465502ee3d9 varLcFilesList, RL_1501ee54ff868a67eff67465502ee3d9 varLcCreditNoteFilesList, bool varLcIsOpenPopupForeigner, ST_6f620840109ac6f721328b723ec0152cStructure varLcInvoiceForeign, ST_6dc39d329f4b959722daa75bc2f62c1fStructure varLcAccData, bool varLcIsUploadCreditNote, EN_d1d0320db36efbb094ad0082361435a0EntityRecord varLcToStore_Invoice, EN_f81a3d226103fd013068b8763798067aEntityRecord varLcToStore_InvoiceExtended, string varLcToStore_ClaveProdServ, string varLcToStore_TipoDeComprobante, ConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUpload_DataActionGetSupplier_Model varLcGetSupplier, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"ShowTitle", "OrderId", "IsFromFolio", "ImportAnticipo", "i_IsEnable", "ErrorMsg", "FilesList", "CreditNoteFilesList", "IsOpenPopupForeigner", "InvoiceForeign", "AccData", "IsUploadCreditNote", "ToStore_Invoice", "ToStore_InvoiceExtended", "ToStore_ClaveProdServ", "ToStore_TipoDeComprobante", "GetSupplier", "ClientVars"}, new string[] {"inParamShowTitle", "inParamOrderId", "inParamIsFromFolio", "inParamImportAnticipo", "inParami_IsEnable", "varLcErrorMsg", "varLcFilesList", "varLcCreditNoteFilesList", "varLcIsOpenPopupForeigner", "varLcInvoiceForeign", "varLcAccData", "varLcIsUploadCreditNote", "varLcToStore_Invoice", "varLcToStore_InvoiceExtended", "varLcToStore_ClaveProdServ", "varLcToStore_TipoDeComprobante", "varLcGetSupplier", "clientVariables"});
this.inParamShowTitle = inParamShowTitle;
this.inParamOrderId = inParamOrderId;
this.inParamIsFromFolio = inParamIsFromFolio;
this.inParamImportAnticipo = inParamImportAnticipo;
this.inParami_IsEnable = inParami_IsEnable;
this.varLcErrorMsg = varLcErrorMsg;
this.varLcFilesList = varLcFilesList;
this.varLcCreditNoteFilesList = varLcCreditNoteFilesList;
this.varLcIsOpenPopupForeigner = varLcIsOpenPopupForeigner;
this.varLcInvoiceForeign = varLcInvoiceForeign;
this.varLcAccData = varLcAccData;
this.varLcIsUploadCreditNote = varLcIsUploadCreditNote;
this.varLcToStore_Invoice = varLcToStore_Invoice;
this.varLcToStore_InvoiceExtended = varLcToStore_InvoiceExtended;
this.varLcToStore_ClaveProdServ = varLcToStore_ClaveProdServ;
this.varLcToStore_TipoDeComprobante = varLcToStore_TipoDeComprobante;
this.varLcGetSupplier = varLcGetSupplier;
this.clientVariables = clientVariables;
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

public string outParamSupplierNr = "";

public bool outParamIsActiveDEV_TK395 = false;

public lcoGetSupplier() {
}
}
/// <summary>
/// Action <code>GetSupplier</code> that represents the Service Studio action <code>GetSupplier</code>
///  <p> Description: </p>
/// </summary>
public async Task<(string,bool,string,string,string,string,bool)> DataActionGetSupplier(IRequestContext requestContext,CancellationToken cancellationToken) {
string outParamExpedicionFiscal = default;
bool outParamIsNational = default;
string outParamName = default;
string outParamRFC = default;
string outParamSociety = default;
string outParamSupplierNr = default;
bool outParamIsActiveDEV_TK395 = default;
lcoGetSupplier result = new lcoGetSupplier();
lcvGetSupplier localVars = new lcvGetSupplier();
ConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUpload_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetSupplier", "72f20306-4d16-47df-ae95-bf989469fbbb"))
using (activitySource.CreateScreenDataActionActivity("Wb_InvoiceSAECUpload", "GetSupplier")){
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
outParamIsNational = result.outParamIsNational;
outParamName = result.outParamName;
outParamRFC = result.outParamRFC;
outParamSociety = result.outParamSociety;
outParamSupplierNr = result.outParamSupplierNr;
outParamIsActiveDEV_TK395 = result.outParamIsActiveDEV_TK395;
} // inner-finally
RETURN_STATEMENT:
return (outParamExpedicionFiscal,outParamIsNational,outParamName,outParamRFC,outParamSociety,outParamSupplierNr,outParamIsActiveDEV_TK395);
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
// Query Function "GetSupplierById" ApfkgNTD4U+ywaOZEpM0Rw of Action "GetSupplier"
public static async Task<(RL_39c65c63eb449ac42634373c1cc7f81a,long)> datasetGetSupplierById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpsuSupplier_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("j_FoliosSAE.Wb_InvoiceSAECUpload.GetSupplier.GetSupplierById", "80e49702-c3d4-4fe1-b2c1-a39912933447");
using var queryActivity = activitySource.CreateAggregateQueryActivity("j_FoliosSAE.Wb_InvoiceSAECUpload.GetSupplier.GetSupplierById", "80e49702-c3d4-4fe1-b2c1-a39912933447", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.okVAxdEmp0q6KzmlhFEndA/DataActions.BgPychZN30eulb+YlGn7uw/NodesNotShownInESpaceTree.ApfkgNTD4U+ywaOZEpM0Rw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, \"ensupplier156\".\"pais\" o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77");
fromBuilder.Append(" FROM ((({Supplier} \"ensupplier156\" Left JOIN {SupplierDetail} \"ensupplierdetail10\" ON (\"ensupplier156\".\"id\" = \"ensupplierdetail10\".\"supplierid\"))  Left JOIN {Company} \"encompany69\" ON (\"ensupplierdetail10\".\"sociedadeid\" = \"encompany69\".\"id\"))  Left JOIN {Region} \"enregion204\" ON (\"ensupplier156\".\"regionid\" = \"enregion204\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpsuSupplier_Id != 0) {
whereBuilder.Append("((\"ensupplier156\".\"id\" = @qpsuSupplier_Id) AND (\"ensupplier156\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuSupplier_Id", DbType.Int64, qpsuSupplier_Id);
} else {
whereBuilder.Append("(\"ensupplier156\".\"id\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_InvoiceSAECUpload.GetSupplier.GetSupplierById.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_InvoiceSAECUpload.GetSupplier.GetSupplierById.List", cancellationToken: cancellationToken);
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
