using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultipleBigFiles_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultipleBigFiles_ScreenModel).Namespace);

    public int inParamInvoiceStatusId;
public long inParamRequisitionId;
public long inParamFolioId;
public string varLcErrorMsg;
public RL_2e76d5be11218f97ffd872b5a7213337 varLcFilesList;
public bool varLcHasChanged;
public bool varLcIsExecuting;
public bool varLcIsSaving;
public ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultipleBigFiles_DataActionGetInvoicesByRequisitionOrFolio_Model varLcGetInvoicesByRequisitionOrFolio;
public ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultipleBigFiles_DataActionGetSupplier_Model varLcGetSupplier;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultipleBigFiles_ScreenModel() {
}



    public ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultipleBigFiles_ScreenModel(int inParamInvoiceStatusId, long inParamRequisitionId, long inParamFolioId, string varLcErrorMsg, RL_2e76d5be11218f97ffd872b5a7213337 varLcFilesList, bool varLcHasChanged, bool varLcIsExecuting, bool varLcIsSaving, ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultipleBigFiles_DataActionGetInvoicesByRequisitionOrFolio_Model varLcGetInvoicesByRequisitionOrFolio, ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultipleBigFiles_DataActionGetSupplier_Model varLcGetSupplier, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"InvoiceStatusId", "RequisitionId", "FolioId", "ErrorMsg", "FilesList", "HasChanged", "IsExecuting", "IsSaving", "GetInvoicesByRequisitionOrFolio", "GetSupplier", "ClientVars"}, new string[] {"inParamInvoiceStatusId", "inParamRequisitionId", "inParamFolioId", "varLcErrorMsg", "varLcFilesList", "varLcHasChanged", "varLcIsExecuting", "varLcIsSaving", "varLcGetInvoicesByRequisitionOrFolio", "varLcGetSupplier", "clientVariables"});
this.inParamInvoiceStatusId = inParamInvoiceStatusId;
this.inParamRequisitionId = inParamRequisitionId;
this.inParamFolioId = inParamFolioId;
this.varLcErrorMsg = varLcErrorMsg;
this.varLcFilesList = varLcFilesList;
this.varLcHasChanged = varLcHasChanged;
this.varLcIsExecuting = varLcIsExecuting;
this.varLcIsSaving = varLcIsSaving;
this.varLcGetInvoicesByRequisitionOrFolio = varLcGetInvoicesByRequisitionOrFolio;
this.varLcGetSupplier = varLcGetSupplier;
this.clientVariables = clientVariables;
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
ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultipleBigFiles_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetInvoicesByRequisitionOrFolio", "33a09a94-27a0-4d70-aee1-01126356474a"))
using (activitySource.CreateScreenDataActionActivity("Wb_PopupInvoiceUploadMultipleBigFiles", "GetInvoicesByRequisitionOrFolio")){
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

public lcoGetSupplier() {
}
}
/// <summary>
/// Action <code>GetSupplier</code> that represents the Service Studio action <code>GetSupplier</code>
///  <p> Description: </p>
/// </summary>
public async Task<(string,bool,string,string,string)> DataActionGetSupplier(IRequestContext requestContext,CancellationToken cancellationToken) {
string outParamExpedicionFiscal = default;
bool outParamIsNational = default;
string outParamName = default;
string outParamRFC = default;
string outParamSociety = default;
lcoGetSupplier result = new lcoGetSupplier();
lcvGetSupplier localVars = new lcvGetSupplier();
ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultipleBigFiles_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetSupplier", "a927739b-e112-412b-968d-2cff30155e2a"))
using (activitySource.CreateScreenDataActionActivity("Wb_PopupInvoiceUploadMultipleBigFiles", "GetSupplier")){
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
} //close CreateActionActivity using block
} // try

finally {
outParamExpedicionFiscal = result.outParamExpedicionFiscal;
outParamIsNational = result.outParamIsNational;
outParamName = result.outParamName;
outParamRFC = result.outParamRFC;
outParamSociety = result.outParamSociety;
} // inner-finally
RETURN_STATEMENT:
return (outParamExpedicionFiscal,outParamIsNational,outParamName,outParamRFC,outParamSociety);
}


    public static class FuncDataActionGetInvoicesByRequisitionOrFolio {

private static async Task<RC_2b77a78552d1dad3876c3ebd8f5c8ec1> datasetGetInvoicesByRequisitionIdReadDbAsync(RC_2b77a78552d1dad3876c3ebd8f5c8ec1 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceFile.Read( r, ref index);
return rec;
}
// Query Function "GetInvoicesByRequisitionId" PyOyZOq2gEiJhdazGIru6g of Action "GetInvoicesByRequisitionOrFolio"
public static async Task<(RL_ff28012de5324af3e81e5ace09ecb1f0,long)> datasetGetInvoicesByRequisitionId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreInvoice_RequisitionId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("d_InvoicePopups.Wb_PopupInvoiceUploadMultipleBigFiles.GetInvoicesByRequisitionOrFolio.GetInvoicesByRequisitionId", "64b2233f-b6ea-4880-8985-d6b3188aeeea");
using var queryActivity = activitySource.CreateAggregateQueryActivity("d_InvoicePopups.Wb_PopupInvoiceUploadMultipleBigFiles.GetInvoicesByRequisitionOrFolio.GetInvoicesByRequisitionId", "64b2233f-b6ea-4880-8985-d6b3188aeeea", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.mak5F1HCzk2BbukH+WQStA/NodesShownInESpaceTree.rYbZ4Ikrt0GOefdFAo_Q7Q/DataActions.lJqgM6AncE2u4QESY1ZHSg/NodesNotShownInESpaceTree.PyOyZOq2gEiJhdazGIru6g, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"eninvoice102\".\"name\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31");
fromBuilder.Append(" FROM ({Invoice} \"eninvoice102\" Inner JOIN {InvoiceFile} \"eninvoicefile37\" ON (\"eninvoice102\".\"id\" = \"eninvoicefile37\".\"invoiceid\")) ");
whereBuilder.Append(" WHERE ");
if (qpreInvoice_RequisitionId != 0) {
whereBuilder.Append("((\"eninvoice102\".\"requisitionid\" = @qpreInvoice_RequisitionId) AND (\"eninvoice102\".\"requisitionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreInvoice_RequisitionId", DbType.Int64, qpreInvoice_RequisitionId);
} else {
whereBuilder.Append("(\"eninvoice102\".\"requisitionid\" IS NULL)");
}
whereBuilder.Append(" AND (\"eninvoice102\".\"invoicestatusid\" <> ");
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
opt[0] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_InvoicePopups.Wb_PopupInvoiceUploadMultipleBigFiles.GetInvoicesByRequisitionOrFolio.GetInvoicesByRequisitionId.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_InvoicePopups.Wb_PopupInvoiceUploadMultipleBigFiles.GetInvoicesByRequisitionOrFolio.GetInvoicesByRequisitionId.List", cancellationToken: cancellationToken);
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
// Query Function "GetInvoicesByFolioId" v8QM68cEsUaqCE4pPuryTA of Action "GetInvoicesByRequisitionOrFolio"
public static async Task<(RL_ff28012de5324af3e81e5ace09ecb1f0,long)> datasetGetInvoicesByFolioId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoInvoice_FolioId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("d_InvoicePopups.Wb_PopupInvoiceUploadMultipleBigFiles.GetInvoicesByRequisitionOrFolio.GetInvoicesByFolioId", "eb0cc4bf-04c7-46b1-aa08-4e293eeaf24c");
using var queryActivity = activitySource.CreateAggregateQueryActivity("d_InvoicePopups.Wb_PopupInvoiceUploadMultipleBigFiles.GetInvoicesByRequisitionOrFolio.GetInvoicesByFolioId", "eb0cc4bf-04c7-46b1-aa08-4e293eeaf24c", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.mak5F1HCzk2BbukH+WQStA/NodesShownInESpaceTree.rYbZ4Ikrt0GOefdFAo_Q7Q/DataActions.lJqgM6AncE2u4QESY1ZHSg/NodesNotShownInESpaceTree.v8QM68cEsUaqCE4pPuryTA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"eninvoice103\".\"name\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31");
fromBuilder.Append(" FROM ({Invoice} \"eninvoice103\" Inner JOIN {InvoiceFile} \"eninvoicefile38\" ON (\"eninvoice103\".\"id\" = \"eninvoicefile38\".\"invoiceid\")) ");
whereBuilder.Append(" WHERE (@qpfoInvoice_FolioId <> 0) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpfoInvoice_FolioId", DbType.Int64, qpfoInvoice_FolioId);
if (qpfoInvoice_FolioId != 0) {
whereBuilder.Append("((\"eninvoice103\".\"folioid\" = @qpfoInvoice_FolioId) AND (\"eninvoice103\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoInvoice_FolioId", DbType.Int64, qpfoInvoice_FolioId);
} else {
whereBuilder.Append("(\"eninvoice103\".\"folioid\" IS NULL)");
}
whereBuilder.Append(" AND (\"eninvoice103\".\"invoicestatusid\" <> ");
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
opt[0] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_InvoicePopups.Wb_PopupInvoiceUploadMultipleBigFiles.GetInvoicesByRequisitionOrFolio.GetInvoicesByFolioId.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_InvoicePopups.Wb_PopupInvoiceUploadMultipleBigFiles.GetInvoicesByRequisitionOrFolio.GetInvoicesByFolioId.List", cancellationToken: cancellationToken);
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
// Query Function "GetSupplierById" D7gDYO8NmUqO8+0YUfdulg of Action "GetSupplier"
public static async Task<(RL_39c65c63eb449ac42634373c1cc7f81a,long)> datasetGetSupplierById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpsuSupplier_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("d_InvoicePopups.Wb_PopupInvoiceUploadMultipleBigFiles.GetSupplier.GetSupplierById", "6003b80f-0def-4a99-8ef3-ed1851f76e96");
using var queryActivity = activitySource.CreateAggregateQueryActivity("d_InvoicePopups.Wb_PopupInvoiceUploadMultipleBigFiles.GetSupplier.GetSupplierById", "6003b80f-0def-4a99-8ef3-ed1851f76e96", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.mak5F1HCzk2BbukH+WQStA/NodesShownInESpaceTree.rYbZ4Ikrt0GOefdFAo_Q7Q/DataActions.m3MnqRLhK0GWjSz_MBVeKg/NodesNotShownInESpaceTree.D7gDYO8NmUqO8+0YUfdulg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, \"ensupplier64\".\"name\" o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, \"ensupplier64\".\"pais\" o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77");
fromBuilder.Append(" FROM ((({Supplier} \"ensupplier64\" Left JOIN {SupplierDetail} \"ensupplierdetail3\" ON (\"ensupplier64\".\"id\" = \"ensupplierdetail3\".\"supplierid\"))  Left JOIN {Company} \"encompany26\" ON (\"ensupplierdetail3\".\"sociedadeid\" = \"encompany26\".\"id\"))  Left JOIN {Region} \"enregion81\" ON (\"ensupplier64\".\"regionid\" = \"enregion81\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpsuSupplier_Id != 0) {
whereBuilder.Append("((\"ensupplier64\".\"id\" = @qpsuSupplier_Id) AND (\"ensupplier64\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuSupplier_Id", DbType.Int64, qpsuSupplier_Id);
} else {
whereBuilder.Append("(\"ensupplier64\".\"id\" IS NULL)");
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
opt[1] = new BitArray(new bool[] {true, true, false, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_InvoicePopups.Wb_PopupInvoiceUploadMultipleBigFiles.GetSupplier.GetSupplierById.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_InvoicePopups.Wb_PopupInvoiceUploadMultipleBigFiles.GetSupplier.GetSupplierById.List", cancellationToken: cancellationToken);
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
