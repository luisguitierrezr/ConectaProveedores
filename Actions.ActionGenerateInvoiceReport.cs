namespace ssConectaProveedores;

public partial class Actions {
public class lcvGenerateInvoiceReport : VarsBag {
public long inParamInvoiceId;
public string inParamInvoiceName;
/// <summary>
/// Variable <code>Vendor</code> that represents the Service Studio Text <code>Vendor</code>
///  <p>Description: </p>
/// </summary>
public string varLcVendor = "";

/// <summary>
/// Variable <code>Doc_Type</code> that represents the Service Studio Text <code>Doc_Type</code>
///  <p>Description: </p>
/// </summary>
public string varLcDoc_Type = "";

/// <summary>
/// Variable <code>Object_type</code> that represents the Service Studio Text <code>Object_type</code>
///  <p>Description: </p>
/// </summary>
public string varLcObject_type = "";

/// <summary>
/// Variable <code>StorageConcept</code> that represents the Service Studio Text
///  <code>StorageConcept</code> <p>Description: </p>
/// </summary>
public string varLcStorageConcept = "";

public RL_7b3475883ca90ad6eb7fc983e868c456 queryResGetInvoiceById_outParamList = new RL_7b3475883ca90ad6eb7fc983e868c456();
public long queryResGetInvoiceById_outParamCount = 0L;

public Actions.lcoInvoiceFileCreateOrUpdate resInvoiceFileCreateOrUpdate =  new Actions.lcoInvoiceFileCreateOrUpdate();
public byte[] resPrintToPDF_outParamPDF = new byte[] {};

public RL_c61f86b789e3e219b8eaddf345441d54 queryResGetRequisitionById_outParamList = new RL_c61f86b789e3e219b8eaddf345441d54();
public long queryResGetRequisitionById_outParamCount = 0L;

public long resServiceStorageCreate_outParamId = 0L;

public RL_8d8af94fcd9af501b3964ae58f9c81aa queryResGetFolioById_outParamList = new RL_8d8af94fcd9af501b3964ae58f9c81aa();
public long queryResGetFolioById_outParamCount = 0L;

public lcvGenerateInvoiceReport(long inParamInvoiceId, string inParamInvoiceName) {
this.inParamInvoiceId = inParamInvoiceId;
this.inParamInvoiceName = inParamInvoiceName;
}
}
/// <summary>
/// Action <code>GenerateInvoiceReport</code> that represents the Service Studio action
///  <code>GenerateInvoiceReport</code> <p> Description: Generate Pdf Report related to an Invoice</p>
/// </summary>
public static async Task ActionGenerateInvoiceReport(IRequestContext requestContext,long inParamInvoiceId,string inParamInvoiceName,CancellationToken cancellationToken) {
lcvGenerateInvoiceReport localVars = new lcvGenerateInvoiceReport(inParamInvoiceId, inParamInvoiceName);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GenerateInvoiceReport", "cb0f7196-3d0c-4e62-ad44-a10b4574f428"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GenerateInvoiceReport", "cb0f7196-3d0c-4e62-ad44-a10b4574f428", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// SetCurrentLocale
await ExtendedActions.SetCurrentLocale(requestContext,"es-MX",cancellationToken);

// Query datasetGetInvoiceById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceById_maxRecords = 1;
if (datasetGetInvoiceById_maxRecords < 1) datasetGetInvoiceById_maxRecords = 1;
int datasetGetInvoiceById_startIndex = 0;(localVars.queryResGetInvoiceById_outParamList,localVars.queryResGetInvoiceById_outParamCount) = await FuncActionGenerateInvoiceReport.datasetGetInvoiceById(requestContext,datasetGetInvoiceById_maxRecords,datasetGetInvoiceById_startIndex,IterationMultiplicity.Never,localVars.inParamInvoiceId,cancellationToken);

// requisition
if(((localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssRequisitionId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// Query datasetGetRequisitionById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionById_maxRecords = 1;
if (datasetGetRequisitionById_maxRecords < 1) datasetGetRequisitionById_maxRecords = 1;
int datasetGetRequisitionById_startIndex = 0;(localVars.queryResGetRequisitionById_outParamList,localVars.queryResGetRequisitionById_outParamCount) = await FuncActionGenerateInvoiceReport.datasetGetRequisitionById(requestContext,datasetGetRequisitionById_maxRecords,datasetGetRequisitionById_startIndex,IterationMultiplicity.Never,localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssRequisitionId,cancellationToken);

// Vendor = GetRequisitionById.List.Current.Supplier.Number
localVars.varLcVendor=localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENSupplier.ssNumber;

// Doc_Type = InvoiceWithNoContractPDF
localVars.varLcDoc_Type=((((string)AppUtils.SiteProperties[SitePropertiesModel.spInvoiceWithNoContractPDF])));

// Object_type = InvoiceWithNoContractTable
localVars.varLcObject_type=((((string)AppUtils.SiteProperties[SitePropertiesModel.spInvoiceWithNoContractTable])));

// StorageConcept = GetRequisitionById.List.Current.Requisition.Name
localVars.varLcStorageConcept=localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssName;
} else {
// Query datasetGetFolioById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioById_maxRecords = 1;
if (datasetGetFolioById_maxRecords < 1) datasetGetFolioById_maxRecords = 1;
int datasetGetFolioById_startIndex = 0;(localVars.queryResGetFolioById_outParamList,localVars.queryResGetFolioById_outParamCount) = await FuncActionGenerateInvoiceReport.datasetGetFolioById(requestContext,datasetGetFolioById_maxRecords,datasetGetFolioById_startIndex,IterationMultiplicity.Never,localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssFolioId,cancellationToken);

// Vendor = GetFolioById.List.Current.Supplier.Number
localVars.varLcVendor=localVars.queryResGetFolioById_outParamList.CurrentRec.ssENSupplier.ssNumber;

// Doc_Type = InvoiceWithNoContractPDF
localVars.varLcDoc_Type=((((string)AppUtils.SiteProperties[SitePropertiesModel.spInvoiceWithNoContractPDF])));

// Object_type = InvoiceWithNoContractTable
localVars.varLcObject_type=((((string)AppUtils.SiteProperties[SitePropertiesModel.spInvoiceWithNoContractTable])));

// StorageConcept = GetFolioById.List.Current.Folio.FolioNumber
localVars.varLcStorageConcept=localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssFolioNumber;
}

// PrintToPDF
localVars.resPrintToPDF_outParamPDF = await Actions.ActionPrintToPDF(requestContext,((((((string)AppUtils.SiteProperties[SitePropertiesModel.spCurrentDomain])))+"ConectaProveedores/InvoiceReportPdf?InvoiceId=")+BuiltInFunction.LongIntegerToText(localVars.inParamInvoiceId)),new ST_201dce7bb255178c132fec4d547942aeStructure(){ ssBaseURL = ((((string)AppUtils.SiteProperties[SitePropertiesModel.spCurrentDomain]))), ssLocale = "es-MX", ssTimezone = "America/Mexico_City" },cancellationToken);

// ServiceStorageCreate
localVars.resServiceStorageCreate_outParamId = await ServiceAPIs.ServiceAPIServiceStorageCreate(requestContext,new EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssConcept = localVars.varLcStorageConcept, ssInternalConceptId = 1, ssFile = localVars.resPrintToPDF_outParamPDF, ssFilename = ((((AppUtils.GetStringResource("jz5Ca8e+9UuG_gbULdJNSQ#Value.890818349.1", "ValidationReport")+localVars.inParamInvoiceName)+"-")+BuiltInFunction.DateToText(BuiltInFunction.CurrDate ()))+".pdf"), ssVendor = localVars.varLcVendor, ssDoc_Type = localVars.varLcDoc_Type, ssObject_type = localVars.varLcObject_type, ssIstoSendToExternal = true },false,cancellationToken);

// InvoiceFileCreateOrUpdate
localVars.resInvoiceFileCreateOrUpdate.outParamId = await Actions.ActionInvoiceFileCreateOrUpdate(requestContext,new EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssInvoiceId = localVars.inParamInvoiceId, ssFilename = ((((AppUtils.GetStringResource("V6Xkl40gI0mKDs0gW_lFLw#Value.890818349.1", "ValidationReport")+localVars.inParamInvoiceName)+"-")+BuiltInFunction.DateToText(BuiltInFunction.CurrDate ()))+".pdf"), ssIsExtra = true, ssIsReport = true, ssStorageId = localVars.resServiceStorageCreate_outParamId, ssCreatedBy = BuiltInFunction.NullTextIdentifier (), ssCreatedOn = BuiltInFunction.CurrDateTime () },cancellationToken);

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionGenerateInvoiceReport {

// Query Function "GetInvoiceById" TLoeGQHXX025+QqwnOtC_Q of Action "GenerateInvoiceReport"
public static async Task<(RL_7b3475883ca90ad6eb7fc983e868c456,long)> datasetGetInvoiceById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GenerateInvoiceReport.GetInvoiceById", "191eba4c-d701-4d5f-b9f9-0ab09ceb42fd");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GenerateInvoiceReport.GetInvoiceById", "191eba4c-d701-4d5f-b9f9-0ab09ceb42fd", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.lnEPyww9Yk6tRKELRXT0KA/NodesNotShownInESpaceTree.TLoeGQHXX025+QqwnOtC_Q, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"eninvoice60\".\"requisitionid\" o2, \"eninvoice60\".\"folioid\" o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23");
fromBuilder.Append(" FROM {Invoice} \"eninvoice60\"");
whereBuilder.Append(" WHERE ");
if (qpinId != 0) {
whereBuilder.Append("((\"eninvoice60\".\"id\" = @qpinId) AND (\"eninvoice60\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinId", DbType.Int64, qpinId);
} else {
whereBuilder.Append("(\"eninvoice60\".\"id\" IS NULL)");
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
opt[0] = new BitArray(new bool[] {true, true, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GenerateInvoiceReport.GetInvoiceById.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GenerateInvoiceReport.GetInvoiceById.List", cancellationToken: cancellationToken);
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

private static async Task<RC_78028cb3076672e5dc4e3606fbea5d54> datasetGetRequisitionByIdReadDbAsync(RC_78028cb3076672e5dc4e3606fbea5d54 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENRequisition.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetRequisitionById" log2ZJRSskW+IHleVBSu9w of Action "GenerateInvoiceReport"
public static async Task<(RL_c61f86b789e3e219b8eaddf345441d54,long)> datasetGetRequisitionById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisition_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GenerateInvoiceReport.GetRequisitionById", "64368896-5294-45b2-be20-795e5414aef7");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GenerateInvoiceReport.GetRequisitionById", "64368896-5294-45b2-be20-795e5414aef7", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.lnEPyww9Yk6tRKELRXT0KA/NodesNotShownInESpaceTree.log2ZJRSskW+IHleVBSu9w, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enrequisition56\".\"name\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, \"ensupplier41\".\"number\" o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85");
fromBuilder.Append(" FROM ({Requisition} \"enrequisition56\" Left JOIN {Supplier} \"ensupplier41\" ON (\"enrequisition56\".\"supplierid\" = \"ensupplier41\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpreRequisition_Id != 0) {
whereBuilder.Append("((\"enrequisition56\".\"id\" = @qpreRequisition_Id) AND (\"enrequisition56\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisition_Id", DbType.Int64, qpreRequisition_Id);
} else {
whereBuilder.Append("(\"enrequisition56\".\"id\" IS NULL)");
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
RL_c61f86b789e3e219b8eaddf345441d54 outParamList = new RL_c61f86b789e3e219b8eaddf345441d54();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetRequisitionByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GenerateInvoiceReport.GetRequisitionById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_c61f86b789e3e219b8eaddf345441d54 _tmp = new RL_c61f86b789e3e219b8eaddf345441d54();
_tmp.AlternateReadDbMethodAsync = datasetGetRequisitionByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GenerateInvoiceReport.GetRequisitionById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_c61f86b789e3e219b8eaddf345441d54)_tmp;
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

private static async Task<RC_d1d085a826d7afd1d542eed60c39554c> datasetGetFolioByIdReadDbAsync(RC_d1d085a826d7afd1d542eed60c39554c rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolio.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetFolioById" l7ZGnbJngUyzcUVPnKgdaw of Action "GenerateInvoiceReport"
public static async Task<(RL_8d8af94fcd9af501b3964ae58f9c81aa,long)> datasetGetFolioById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolio_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GenerateInvoiceReport.GetFolioById", "9d46b697-67b2-4c81-b371-454f9ca81d6b");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GenerateInvoiceReport.GetFolioById", "9d46b697-67b2-4c81-b371-454f9ca81d6b", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.lnEPyww9Yk6tRKELRXT0KA/NodesNotShownInESpaceTree.l7ZGnbJngUyzcUVPnKgdaw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"enfolio51\".\"folionumber\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, \"ensupplier42\".\"number\" o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47");
fromBuilder.Append(" FROM ({Folio} \"enfolio51\" Left JOIN {Supplier} \"ensupplier42\" ON (\"enfolio51\".\"supplierid\" = \"ensupplier42\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoFolio_Id != 0) {
whereBuilder.Append("((\"enfolio51\".\"id\" = @qpfoFolio_Id) AND (\"enfolio51\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolio_Id", DbType.Int64, qpfoFolio_Id);
} else {
whereBuilder.Append("(\"enfolio51\".\"id\" IS NULL)");
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
RL_8d8af94fcd9af501b3964ae58f9c81aa outParamList = new RL_8d8af94fcd9af501b3964ae58f9c81aa();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFolioByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GenerateInvoiceReport.GetFolioById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_8d8af94fcd9af501b3964ae58f9c81aa _tmp = new RL_8d8af94fcd9af501b3964ae58f9c81aa();
_tmp.AlternateReadDbMethodAsync = datasetGetFolioByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GenerateInvoiceReport.GetFolioById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_8d8af94fcd9af501b3964ae58f9c81aa)_tmp;
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
