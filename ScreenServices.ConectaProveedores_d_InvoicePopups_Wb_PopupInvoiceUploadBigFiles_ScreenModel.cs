using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_ScreenModel).Namespace);

    public long inParamInvoiceId;
public int inParamInvoiceStatusId;
public long inParamRequisitionId;
public long inParamFolioId;
public bool inParami_ShowOtherEvidences;
public string varLcErrorMsg;
public RL_7b4ceb84b6a1255d3a42c8932279bc3c varLcExtraFilesList;
public RL_7b4ceb84b6a1255d3a42c8932279bc3c varLcFilesList;
public bool varLcHasChanged;
public bool varLcIsExecuting;
public bool varLcIsLoading;
public bool varLcIsSaving;
public bool varLcIsShowForeignInvoice;
public ST_6f620840109ac6f721328b723ec0152cStructure varLcInvoiceForeign;
public AggregateRecord<RL_00a03f803f0d49826089181417370afb> ScreenDataSetGetInvoiceFilesByInvoiceId;
public AggregateRecord<RL_5198a019df57be180483639cd138aad4> ScreenDataSetGetInvoiceExtendedForeignerById;
public ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_DataActionGetInvoicesByRequisitionOrFolio_Model varLcGetInvoicesByRequisitionOrFolio;
public ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_DataActionGetSupplier_Model varLcGetSupplier;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_ScreenModel() {
}



    public ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_ScreenModel(long inParamInvoiceId, int inParamInvoiceStatusId, long inParamRequisitionId, long inParamFolioId, bool inParami_ShowOtherEvidences, string varLcErrorMsg, RL_7b4ceb84b6a1255d3a42c8932279bc3c varLcExtraFilesList, RL_7b4ceb84b6a1255d3a42c8932279bc3c varLcFilesList, bool varLcHasChanged, bool varLcIsExecuting, bool varLcIsLoading, bool varLcIsSaving, bool varLcIsShowForeignInvoice, ST_6f620840109ac6f721328b723ec0152cStructure varLcInvoiceForeign, AggregateRecord<RL_00a03f803f0d49826089181417370afb> ScreenDataSetGetInvoiceFilesByInvoiceId, AggregateRecord<RL_5198a019df57be180483639cd138aad4> ScreenDataSetGetInvoiceExtendedForeignerById, ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_DataActionGetInvoicesByRequisitionOrFolio_Model varLcGetInvoicesByRequisitionOrFolio, ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_DataActionGetSupplier_Model varLcGetSupplier, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"InvoiceId", "InvoiceStatusId", "RequisitionId", "FolioId", "i_ShowOtherEvidences", "ErrorMsg", "ExtraFilesList", "FilesList", "HasChanged", "IsExecuting", "IsLoading", "IsSaving", "IsShowForeignInvoice", "InvoiceForeign", "GetInvoiceFilesByInvoiceId", "GetInvoiceExtendedForeignerById", "GetInvoicesByRequisitionOrFolio", "GetSupplier", "ClientVars"}, new string[] {"inParamInvoiceId", "inParamInvoiceStatusId", "inParamRequisitionId", "inParamFolioId", "inParami_ShowOtherEvidences", "varLcErrorMsg", "varLcExtraFilesList", "varLcFilesList", "varLcHasChanged", "varLcIsExecuting", "varLcIsLoading", "varLcIsSaving", "varLcIsShowForeignInvoice", "varLcInvoiceForeign", "ScreenDataSetGetInvoiceFilesByInvoiceId", "ScreenDataSetGetInvoiceExtendedForeignerById", "varLcGetInvoicesByRequisitionOrFolio", "varLcGetSupplier", "clientVariables"});
this.inParamInvoiceId = inParamInvoiceId;
this.inParamInvoiceStatusId = inParamInvoiceStatusId;
this.inParamRequisitionId = inParamRequisitionId;
this.inParamFolioId = inParamFolioId;
this.inParami_ShowOtherEvidences = inParami_ShowOtherEvidences;
this.varLcErrorMsg = varLcErrorMsg;
this.varLcExtraFilesList = varLcExtraFilesList;
this.varLcFilesList = varLcFilesList;
this.varLcHasChanged = varLcHasChanged;
this.varLcIsExecuting = varLcIsExecuting;
this.varLcIsLoading = varLcIsLoading;
this.varLcIsSaving = varLcIsSaving;
this.varLcIsShowForeignInvoice = varLcIsShowForeignInvoice;
this.varLcInvoiceForeign = varLcInvoiceForeign;
this.ScreenDataSetGetInvoiceFilesByInvoiceId = ScreenDataSetGetInvoiceFilesByInvoiceId;
this.ScreenDataSetGetInvoiceExtendedForeignerById = ScreenDataSetGetInvoiceExtendedForeignerById;
this.varLcGetInvoicesByRequisitionOrFolio = varLcGetInvoicesByRequisitionOrFolio;
this.varLcGetSupplier = varLcGetSupplier;
this.clientVariables = clientVariables;
}



    
// Query Function "GetInvoiceFilesByInvoiceId" WVdaaw5shkyypt0rgIpSWw of Action "Wb_PopupInvoiceUploadBigFiles"
public static async Task<(RL_00a03f803f0d49826089181417370afb,long)> datasetGetInvoiceFilesByInvoiceId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("d_InvoicePopups.Wb_PopupInvoiceUploadBigFiles.GetInvoiceFilesByInvoiceId", "6b5a5759-6c0e-4c86-b2a6-dd2b808a525b");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_PopupInvoiceUploadBigFiles","d_InvoicePopups.Wb_PopupInvoiceUploadBigFiles.GetInvoiceFilesByInvoiceId");
// Query Iterations: Multiple
// Refresh Query bmGemvh49kGExRo8xLqnHA Iterations: Multiple
// Refresh Query m5vN7_aRx0+STJOHMWC1hg Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.mak5F1HCzk2BbukH+WQStA/NodesShownInESpaceTree.m2KDAPbjgkWBi4VjdoThSg/ScreenDataSets.WVdaaw5shkyypt0rgIpSWw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoicefile30\".\"id\" o0, NULL o1, \"eninvoicefile30\".\"filename\" o2, \"eninvoicefile30\".\"isextra\" o3, NULL o4, \"eninvoicefile30\".\"storageid\" o5, NULL o6, NULL o7");
fromBuilder.Append(" FROM {InvoiceFile} \"eninvoicefile30\"");
whereBuilder.Append(" WHERE (");
if (qpinInvoiceId != 0) {
whereBuilder.Append("((\"eninvoicefile30\".\"invoiceid\" = @qpinInvoiceId) AND (\"eninvoicefile30\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceId", DbType.Int64, qpinInvoiceId);
} else {
whereBuilder.Append("(\"eninvoicefile30\".\"invoiceid\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_InvoicePopups.Wb_PopupInvoiceUploadBigFiles.GetInvoiceFilesByInvoiceId.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_InvoicePopups.Wb_PopupInvoiceUploadBigFiles.GetInvoiceFilesByInvoiceId.List", cancellationToken: cancellationToken);
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

// Query Function "GetInvoiceExtendedForeignerById" rFu059yuw0eWjlPnvVXfdA of Action "Wb_PopupInvoiceUploadBigFiles"
public static async Task<(RL_5198a019df57be180483639cd138aad4,long)> datasetGetInvoiceExtendedForeignerById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("d_InvoicePopups.Wb_PopupInvoiceUploadBigFiles.GetInvoiceExtendedForeignerById", "e7b45bac-aedc-47c3-968e-53e7bd55df74");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_PopupInvoiceUploadBigFiles","d_InvoicePopups.Wb_PopupInvoiceUploadBigFiles.GetInvoiceExtendedForeignerById");
// Query Iterations: Never
// Refresh Query 7PA_ABFrCkKVAj1KRkeljA Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.mak5F1HCzk2BbukH+WQStA/NodesShownInESpaceTree.m2KDAPbjgkWBi4VjdoThSg/ScreenDataSets.rFu059yuw0eWjlPnvVXfdA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"eninvoiceextendedforeigner\".\"invoicenumber\" o1, \"eninvoiceextendedforeigner\".\"direction\" o2, \"eninvoiceextendedforeigner\".\"receiversocialreason\" o3, \"eninvoiceextendedforeigner\".\"receiverrfc\" o4, \"eninvoiceextendedforeigner\".\"issuersocialreason\" o5, \"eninvoiceextendedforeigner\".\"issuertaxid\" o6, \"eninvoiceextendedforeigner\".\"invoicedate\" o7, trim_scale(\"eninvoiceextendedforeigner\".\"totalamount\"::numeric) o8, \"eninvoiceextendedforeigner\".\"currency\" o9");
fromBuilder.Append(" FROM {InvoiceExtendedForeigner} \"eninvoiceextendedforeigner\"");
whereBuilder.Append(" WHERE ");
if (qpinId != 0) {
whereBuilder.Append("((\"eninvoiceextendedforeigner\".\"id\" = @qpinId) AND (\"eninvoiceextendedforeigner\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinId", DbType.Int64, qpinId);
} else {
whereBuilder.Append("(\"eninvoiceextendedforeigner\".\"id\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_InvoicePopups.Wb_PopupInvoiceUploadBigFiles.GetInvoiceExtendedForeignerById.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_InvoicePopups.Wb_PopupInvoiceUploadBigFiles.GetInvoiceExtendedForeignerById.List", cancellationToken: cancellationToken);
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


    public class lcvGetInvoicesByRequisitionOrFolio : VarsBag {
public RL_7b3475883ca90ad6eb7fc983e868c456 queryResGetInvoicesByFolioId_outParamList = new RL_7b3475883ca90ad6eb7fc983e868c456();
public long queryResGetInvoicesByFolioId_outParamCount = 0L;

public RL_1f9a243d40703326d9bf7c63586316cd queryResGetInvoicesByRequisitionId_outParamList = new RL_1f9a243d40703326d9bf7c63586316cd();
public long queryResGetInvoicesByRequisitionId_outParamCount = 0L;

public lcvGetInvoicesByRequisitionOrFolio() {
}
}
public class lcoGetInvoicesByRequisitionOrFolio : VarsBag {
public RL_2d16aaaf46aa59a96936af8c3c3547a0 outParamInvoicesList = new RL_2d16aaaf46aa59a96936af8c3c3547a0();

public decimal outParamInvoicesSum = 0.0M;

public lcoGetInvoicesByRequisitionOrFolio() {
}
}
/// <summary>
/// Action <code>GetInvoicesByRequisitionOrFolio</code> that represents the Service Studio action
///  <code>GetInvoicesByRequisitionOrFolio</code> <p> Description: </p>
/// </summary>
public async Task<(RL_2d16aaaf46aa59a96936af8c3c3547a0,decimal)> DataActionGetInvoicesByRequisitionOrFolio(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_2d16aaaf46aa59a96936af8c3c3547a0 outParamInvoicesList = default;
decimal outParamInvoicesSum = default;
lcoGetInvoicesByRequisitionOrFolio result = new lcoGetInvoicesByRequisitionOrFolio();
lcvGetInvoicesByRequisitionOrFolio localVars = new lcvGetInvoicesByRequisitionOrFolio();
ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetInvoicesByRequisitionOrFolio", "6d385976-3e43-4781-b18e-b270c69c284f"))
using (activitySource.CreateScreenDataActionActivity("Wb_PopupInvoiceUploadBigFiles", "GetInvoicesByRequisitionOrFolio")){
// no req
if(((inParamRequisitionId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// Query datasetGetInvoicesByFolioId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoicesByFolioId_maxRecords = 200;
if (datasetGetInvoicesByFolioId_maxRecords < 1) datasetGetInvoicesByFolioId_maxRecords = 1;
int datasetGetInvoicesByFolioId_startIndex = 0;(localVars.queryResGetInvoicesByFolioId_outParamList,localVars.queryResGetInvoicesByFolioId_outParamCount) = await FuncDataActionGetInvoicesByRequisitionOrFolio.datasetGetInvoicesByFolioId(requestContext,datasetGetInvoicesByFolioId_maxRecords,datasetGetInvoicesByFolioId_startIndex,IterationMultiplicity.Multiple,inParamFolioId,inParamInvoiceId,cancellationToken);

// InvoicesList = GetInvoicesByFolioId.List
result.outParamInvoicesList=(await RL_2d16aaaf46aa59a96936af8c3c3547a0.ConvertAsync(localVars.queryResGetInvoicesByFolioId_outParamList, new RL_2d16aaaf46aa59a96936af8c3c3547a0(), async (RC_04c5986b32c7822f033c933cf71b96bd source, EN_d1d0320db36efbb094ad0082361435a0EntityRecord target, CancellationToken cancellationToken) => {
target = source;
return target;
}, cancellationToken));
} else {
// Query datasetGetInvoicesByRequisitionId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoicesByRequisitionId_maxRecords = 0;
int datasetGetInvoicesByRequisitionId_startIndex = 0;(localVars.queryResGetInvoicesByRequisitionId_outParamList,localVars.queryResGetInvoicesByRequisitionId_outParamCount) = await FuncDataActionGetInvoicesByRequisitionOrFolio.datasetGetInvoicesByRequisitionId(requestContext,datasetGetInvoicesByRequisitionId_maxRecords,datasetGetInvoicesByRequisitionId_startIndex,IterationMultiplicity.Multiple,inParamInvoiceId,inParamRequisitionId,cancellationToken);

// Foreach GetInvoicesByRequisitionId.List
localVars.queryResGetInvoicesByRequisitionId_outParamList.StartIteration();
try {while (!((localVars.queryResGetInvoicesByRequisitionId_outParamList.Eof))) {
// InvoicesSum = InvoicesSum + GetInvoicesByRequisitionId.List.Current.InvoiceExtended.Subtotal
result.outParamInvoicesSum=(result.outParamInvoicesSum+localVars.queryResGetInvoicesByRequisitionId_outParamList.CurrentRec.ssENInvoiceExtended.ssSubtotal);
localVars.queryResGetInvoicesByRequisitionId_outParamList.Advance();
}

} finally {
localVars.queryResGetInvoicesByRequisitionId_outParamList.EndIteration();
}

// InvoicesList = GetInvoicesByRequisitionId.List
result.outParamInvoicesList=(await RL_2d16aaaf46aa59a96936af8c3c3547a0.ConvertAsync(localVars.queryResGetInvoicesByRequisitionId_outParamList, new RL_2d16aaaf46aa59a96936af8c3c3547a0(), async (RC_b6257dfb536e679f8b7be7b4b56f189b source, EN_d1d0320db36efbb094ad0082361435a0EntityRecord target, CancellationToken cancellationToken) => {
target = source.ssENInvoice;
return target;
}, cancellationToken));
}

} //close CreateActionActivity using block
} // try

finally {
outParamInvoicesList = result.outParamInvoicesList;
outParamInvoicesSum = result.outParamInvoicesSum;
} // inner-finally
RETURN_STATEMENT:
return (outParamInvoicesList,outParamInvoicesSum);
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
ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetSupplier", "ef5c2e14-d501-4fee-988e-94ac1355f602"))
using (activitySource.CreateScreenDataActionActivity("Wb_PopupInvoiceUploadBigFiles", "GetSupplier")){
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

// Query Function "GetInvoicesByFolioId" rdXHcExn1k68VKNV_EdVnQ of Action "GetInvoicesByRequisitionOrFolio"
public static async Task<(RL_7b3475883ca90ad6eb7fc983e868c456,long)> datasetGetInvoicesByFolioId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolioId,long qpinId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("d_InvoicePopups.Wb_PopupInvoiceUploadBigFiles.GetInvoicesByRequisitionOrFolio.GetInvoicesByFolioId", "70c7d5ad-674c-4ed6-bc54-a355fc47559d");
using var queryActivity = activitySource.CreateAggregateQueryActivity("d_InvoicePopups.Wb_PopupInvoiceUploadBigFiles.GetInvoicesByRequisitionOrFolio.GetInvoicesByFolioId", "70c7d5ad-674c-4ed6-bc54-a355fc47559d", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.mak5F1HCzk2BbukH+WQStA/NodesShownInESpaceTree.m2KDAPbjgkWBi4VjdoThSg/DataActions.dlk4bUM+gUexjrJwxpwoTw/NodesNotShownInESpaceTree.rdXHcExn1k68VKNV_EdVnQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"eninvoice95\".\"name\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23");
fromBuilder.Append(" FROM {Invoice} \"eninvoice95\"");
whereBuilder.Append(" WHERE (@qpfoFolioId <> 0) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioId", DbType.Int64, qpfoFolioId);
if (qpfoFolioId != 0) {
whereBuilder.Append("((\"eninvoice95\".\"folioid\" = @qpfoFolioId) AND (\"eninvoice95\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioId", DbType.Int64, qpfoFolioId);
} else {
whereBuilder.Append("(\"eninvoice95\".\"folioid\" IS NULL)");
}
whereBuilder.Append(" AND (\"eninvoice95\".\"invoicestatusid\" <> ");
whereBuilder.Append((ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("RteygpK6NkexqZHONe6zkg"))).ssId);
whereBuilder.Append(") AND ");
if (qpinId != 0) {
whereBuilder.Append("((\"eninvoice95\".\"id\" <> @qpinId) OR (\"eninvoice95\".\"id\" IS NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinId", DbType.Int64, qpinId);
} else {
whereBuilder.Append("(\"eninvoice95\".\"id\" IS NOT NULL)");
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
RL_7b3475883ca90ad6eb7fc983e868c456 outParamList = new RL_7b3475883ca90ad6eb7fc983e868c456();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_InvoicePopups.Wb_PopupInvoiceUploadBigFiles.GetInvoicesByRequisitionOrFolio.GetInvoicesByFolioId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_7b3475883ca90ad6eb7fc983e868c456 _tmp = new RL_7b3475883ca90ad6eb7fc983e868c456();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_InvoicePopups.Wb_PopupInvoiceUploadBigFiles.GetInvoicesByRequisitionOrFolio.GetInvoicesByFolioId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_7b3475883ca90ad6eb7fc983e868c456)_tmp;
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

private static async Task<RC_b6257dfb536e679f8b7be7b4b56f189b> datasetGetInvoicesByRequisitionIdReadDbAsync(RC_b6257dfb536e679f8b7be7b4b56f189b rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceExtended.Read( r, ref index);
return rec;
}
// Query Function "GetInvoicesByRequisitionId" EmeOxN1TxkKcHY2wNT81kg of Action "GetInvoicesByRequisitionOrFolio"
public static async Task<(RL_1f9a243d40703326d9bf7c63586316cd,long)> datasetGetInvoicesByRequisitionId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoice_Id,long qpreInvoice_RequisitionId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("d_InvoicePopups.Wb_PopupInvoiceUploadBigFiles.GetInvoicesByRequisitionOrFolio.GetInvoicesByRequisitionId", "c48e6712-53dd-42c6-9c1d-8db0353f3592");
using var queryActivity = activitySource.CreateAggregateQueryActivity("d_InvoicePopups.Wb_PopupInvoiceUploadBigFiles.GetInvoicesByRequisitionOrFolio.GetInvoicesByRequisitionId", "c48e6712-53dd-42c6-9c1d-8db0353f3592", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.mak5F1HCzk2BbukH+WQStA/NodesShownInESpaceTree.m2KDAPbjgkWBi4VjdoThSg/DataActions.dlk4bUM+gUexjrJwxpwoTw/NodesNotShownInESpaceTree.EmeOxN1TxkKcHY2wNT81kg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoice96\".\"id\" o0, \"eninvoice96\".\"name\" o1, \"eninvoice96\".\"requisitionid\" o2, \"eninvoice96\".\"folioid\" o3, \"eninvoice96\".\"ordermainid\" o4, \"eninvoice96\".\"cfditypeid\" o5, trim_scale(\"eninvoice96\".\"totalamount\"::numeric) o6, \"eninvoice96\".\"currency\" o7, \"eninvoice96\".\"invoicestatusid\" o8, \"eninvoice96\".\"accountingdatetime\" o9, \"eninvoice96\".\"paymentdatetime\" o10, \"eninvoice96\".\"createdon\" o11, \"eninvoice96\".\"createdby\" o12, \"eninvoice96\".\"updatedon\" o13, \"eninvoice96\".\"updatedby\" o14, \"eninvoice96\".\"submittedon\" o15, \"eninvoice96\".\"isnewversion\" o16, \"eninvoice96\".\"id_poliza\" o17, \"eninvoice96\".\"id_poliza_sap\" o18, \"eninvoice96\".\"doc51\" o19, \"eninvoice96\".\"accountingerror\" o20, \"eninvoice96\".\"orderaccconceptsid\" o21, trim_scale(\"eninvoice96\".\"amortization\"::numeric) o22, \"eninvoice96\".\"creditnoteinvoiceid\" o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, trim_scale(\"eninvoiceextended22\".\"subtotal\"::numeric) o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42");
fromBuilder.Append(" FROM ({Invoice} \"eninvoice96\" Left JOIN {InvoiceExtended} \"eninvoiceextended22\" ON (\"eninvoice96\".\"id\" = \"eninvoiceextended22\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpreInvoice_RequisitionId != 0) {
whereBuilder.Append("((\"eninvoice96\".\"requisitionid\" = @qpreInvoice_RequisitionId) AND (\"eninvoice96\".\"requisitionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreInvoice_RequisitionId", DbType.Int64, qpreInvoice_RequisitionId);
} else {
whereBuilder.Append("(\"eninvoice96\".\"requisitionid\" IS NULL)");
}
whereBuilder.Append(" AND (\"eninvoice96\".\"invoicestatusid\" <> ");
whereBuilder.Append((ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("RteygpK6NkexqZHONe6zkg"))).ssId);
whereBuilder.Append(") AND ");
if (qpinInvoice_Id != 0) {
whereBuilder.Append("((\"eninvoice96\".\"id\" <> @qpinInvoice_Id) OR (\"eninvoice96\".\"id\" IS NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoice_Id", DbType.Int64, qpinInvoice_Id);
} else {
whereBuilder.Append("(\"eninvoice96\".\"id\" IS NOT NULL)");
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
RL_1f9a243d40703326d9bf7c63586316cd outParamList = new RL_1f9a243d40703326d9bf7c63586316cd();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoicesByRequisitionIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_InvoicePopups.Wb_PopupInvoiceUploadBigFiles.GetInvoicesByRequisitionOrFolio.GetInvoicesByRequisitionId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_1f9a243d40703326d9bf7c63586316cd _tmp = new RL_1f9a243d40703326d9bf7c63586316cd();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoicesByRequisitionIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_InvoicePopups.Wb_PopupInvoiceUploadBigFiles.GetInvoicesByRequisitionOrFolio.GetInvoicesByRequisitionId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_1f9a243d40703326d9bf7c63586316cd)_tmp;
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
// Query Function "GetSupplierById" ULNBhyxdnUO+rRhovkealg of Action "GetSupplier"
public static async Task<(RL_39c65c63eb449ac42634373c1cc7f81a,long)> datasetGetSupplierById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpsuSupplier_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("d_InvoicePopups.Wb_PopupInvoiceUploadBigFiles.GetSupplier.GetSupplierById", "8741b350-5d2c-439d-bead-1868be479a96");
using var queryActivity = activitySource.CreateAggregateQueryActivity("d_InvoicePopups.Wb_PopupInvoiceUploadBigFiles.GetSupplier.GetSupplierById", "8741b350-5d2c-439d-bead-1868be479a96", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.mak5F1HCzk2BbukH+WQStA/NodesShownInESpaceTree.m2KDAPbjgkWBi4VjdoThSg/DataActions.FC5c7wHV7k+YjpSsE1X2Ag/NodesNotShownInESpaceTree.ULNBhyxdnUO+rRhovkealg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, \"ensupplier61\".\"pais\" o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77");
fromBuilder.Append(" FROM ((({Supplier} \"ensupplier61\" Left JOIN {SupplierDetail} \"ensupplierdetail\" ON (\"ensupplier61\".\"id\" = \"ensupplierdetail\".\"supplierid\"))  Left JOIN {Company} \"encompany23\" ON (\"ensupplierdetail\".\"sociedadeid\" = \"encompany23\".\"id\"))  Left JOIN {Region} \"enregion78\" ON (\"ensupplier61\".\"regionid\" = \"enregion78\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpsuSupplier_Id != 0) {
whereBuilder.Append("((\"ensupplier61\".\"id\" = @qpsuSupplier_Id) AND (\"ensupplier61\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuSupplier_Id", DbType.Int64, qpsuSupplier_Id);
} else {
whereBuilder.Append("(\"ensupplier61\".\"id\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_InvoicePopups.Wb_PopupInvoiceUploadBigFiles.GetSupplier.GetSupplierById.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_InvoicePopups.Wb_PopupInvoiceUploadBigFiles.GetSupplier.GetSupplierById.List", cancellationToken: cancellationToken);
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
