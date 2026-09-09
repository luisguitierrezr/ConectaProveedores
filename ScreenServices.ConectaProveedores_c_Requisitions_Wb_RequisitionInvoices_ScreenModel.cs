using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_c_Requisitions_Wb_RequisitionInvoices_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_c_Requisitions_Wb_RequisitionInvoices_ScreenModel).Namespace);

    public long inParami_RequisitionId;
public bool varLcl_CanUploadInvoice;
public bool varLcl_IsOpenPopupInvoices;
public long varLcl_InvoiceIdToPopup;
public int varLcl_InvoiceStatusIdToPopup;
public bool varLcl_IsOpenPopupMultiupload;
public AggregateRecord<RL_9f948f770ba4600f86dd29332a1a7e00> ScreenDataSetGetInvoicesByRequisitionId;
public ConectaProveedores_c_Requisitions_Wb_RequisitionInvoices_DataActionGetRequisitionData_Model varLcGetRequisitionData;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_c_Requisitions_Wb_RequisitionInvoices_ScreenModel() {
}



    public ConectaProveedores_c_Requisitions_Wb_RequisitionInvoices_ScreenModel(long inParami_RequisitionId, bool varLcl_CanUploadInvoice, bool varLcl_IsOpenPopupInvoices, long varLcl_InvoiceIdToPopup, int varLcl_InvoiceStatusIdToPopup, bool varLcl_IsOpenPopupMultiupload, AggregateRecord<RL_9f948f770ba4600f86dd29332a1a7e00> ScreenDataSetGetInvoicesByRequisitionId, ConectaProveedores_c_Requisitions_Wb_RequisitionInvoices_DataActionGetRequisitionData_Model varLcGetRequisitionData, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"i_RequisitionId", "l_CanUploadInvoice", "l_IsOpenPopupInvoices", "l_InvoiceIdToPopup", "l_InvoiceStatusIdToPopup", "l_IsOpenPopupMultiupload", "GetInvoicesByRequisitionId", "GetRequisitionData", "ClientVars"}, new string[] {"inParami_RequisitionId", "varLcl_CanUploadInvoice", "varLcl_IsOpenPopupInvoices", "varLcl_InvoiceIdToPopup", "varLcl_InvoiceStatusIdToPopup", "varLcl_IsOpenPopupMultiupload", "ScreenDataSetGetInvoicesByRequisitionId", "varLcGetRequisitionData", "clientVariables"});
this.inParami_RequisitionId = inParami_RequisitionId;
this.varLcl_CanUploadInvoice = varLcl_CanUploadInvoice;
this.varLcl_IsOpenPopupInvoices = varLcl_IsOpenPopupInvoices;
this.varLcl_InvoiceIdToPopup = varLcl_InvoiceIdToPopup;
this.varLcl_InvoiceStatusIdToPopup = varLcl_InvoiceStatusIdToPopup;
this.varLcl_IsOpenPopupMultiupload = varLcl_IsOpenPopupMultiupload;
this.ScreenDataSetGetInvoicesByRequisitionId = ScreenDataSetGetInvoicesByRequisitionId;
this.varLcGetRequisitionData = varLcGetRequisitionData;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_0034cf2433ba52d290961e6b42045a29> datasetGetInvoicesByRequisitionIdReadDbAsync(RC_0034cf2433ba52d290961e6b42045a29 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceApproval.Read( r, ref index);
rec.ssENInvoiceStatus.Read( r, ref index);
rec.ssCanUpload = r.ReadBoolean(index++, "InvoiceInvoiceApprovalInvoiceStatusCanUploadRecord.CanUpload", false);
return rec;
}
// Query Function "GetInvoicesByRequisitionId" 7EfBKRphHkmz_B0oyjPwhg of Action "Wb_RequisitionInvoices"
public static async Task<(RL_9f948f770ba4600f86dd29332a1a7e00,long)> datasetGetInvoicesByRequisitionId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckProveedorRole,long qpreInvoice_RequisitionId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("c_Requisitions.Wb_RequisitionInvoices.GetInvoicesByRequisitionId", "29c147ec-611a-491e-b3fc-1d28ca33f086");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_RequisitionInvoices","c_Requisitions.Wb_RequisitionInvoices.GetInvoicesByRequisitionId");
// Query Iterations: Multiple
// Refresh Query lOtjbMYUYE+pW8IOS0l4tw Iterations: Multiple
// Refresh Query bNSoO23rw0m79eWKt0XdTA Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.NqM8b7xvgE6iEV43Re0jUg/ScreenDataSets.7EfBKRphHkmz_B0oyjPwhg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoice134\".\"id\" o0, \"eninvoice134\".\"name\" o1, NULL o2, NULL o3, NULL o4, NULL o5, trim_scale(\"eninvoice134\".\"totalamount\"::numeric) o6, \"eninvoice134\".\"currency\" o7, NULL o8, NULL o9, NULL o10, \"eninvoice134\".\"createdon\" o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, \"eninvoicestatus15\".\"id\" o34, \"eninvoicestatus15\".\"label\" o35, \"eninvoicestatus15\".\"class\" o36, NULL o37, NULL o38, NULL o39, NULL o40, (CASE WHEN ((\"eninvoice134\".\"invoicestatusid\" = ");
selectBuilder.Append((ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("Wo+LRDF_n0O7Fo8ikSEsSA"))).ssId);
selectBuilder.Append(") OR ((\"eninvoice134\".\"invoicestatusid\" = ");
selectBuilder.Append((ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("ASvPCAkuaEyQ8YlZNO_ZcQ"))).ssId);
selectBuilder.Append(") AND (NOT (\"eninvoiceapproval41\".\"hasstartedaccounting\" = 1)))) THEN 1 ELSE 0 END) \"canupload\"");
fromBuilder.Append(" FROM (({Invoice} \"eninvoice134\" Left JOIN {InvoiceStatus} \"eninvoicestatus15\" ON (\"eninvoice134\".\"invoicestatusid\" = \"eninvoicestatus15\".\"id\"))  Left JOIN {InvoiceApproval} \"eninvoiceapproval41\" ON (\"eninvoice134\".\"id\" = \"eninvoiceapproval41\".\"invoiceid\")) ");
whereBuilder.Append(" WHERE (");
if (qpreInvoice_RequisitionId != 0) {
whereBuilder.Append("((\"eninvoice134\".\"requisitionid\" = @qpreInvoice_RequisitionId) AND (\"eninvoice134\".\"requisitionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreInvoice_RequisitionId", DbType.Int64, qpreInvoice_RequisitionId);
} else {
whereBuilder.Append("(\"eninvoice134\".\"requisitionid\" IS NULL)");
}
whereBuilder.Append(" AND (\"eninvoice134\".\"requisitionid\" IS NOT NULL)) AND ((@qpboCheckProveedorRole = 1) OR (\"eninvoice134\".\"invoicestatusid\" <> ");
whereBuilder.Append((ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("Wo+LRDF_n0O7Fo8ikSEsSA"))).ssId);
whereBuilder.Append("))");
orderByBuilder.Append(" ORDER BY \"eninvoice134\".\"createdon\" ASC ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckProveedorRole", DbType.Boolean, qpboCheckProveedorRole);
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
RL_9f948f770ba4600f86dd29332a1a7e00 outParamList = new RL_9f948f770ba4600f86dd29332a1a7e00();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoicesByRequisitionIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {false, false, true, true, true, true, false, false, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {false, false, false, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.Wb_RequisitionInvoices.GetInvoicesByRequisitionId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_9f948f770ba4600f86dd29332a1a7e00 _tmp = new RL_9f948f770ba4600f86dd29332a1a7e00();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoicesByRequisitionIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.Wb_RequisitionInvoices.GetInvoicesByRequisitionId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_9f948f770ba4600f86dd29332a1a7e00)_tmp;
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


    public class lcvGetRequisitionData : VarsBag {
public RL_fb447cbe50933c4990bdca146fda9078 queryResGetRequisitionById_outParamList = new RL_fb447cbe50933c4990bdca146fda9078();
public long queryResGetRequisitionById_outParamCount = 0L;

public lcvGetRequisitionData() {
}
}
public class lcoGetRequisitionData : VarsBag {
public bool outParamAdvWithoutInvoice = false;

public bool outParamAllowMultiUpload = false;

public bool outParamWasAdvWithoutInvoice = false;

public long outParamCostCenterSAPId = 0L;

public string outParamCurrencyId = "";

public string outParamDivisionFI = "";

public string outParamProject = "";

public long outParamPaymentMethodsId = 0L;

public long outParamPaymentTermsId = 0L;

public string outParamSupplierNr = "";

public decimal outParamTotalAmount = 0.0M;

public lcoGetRequisitionData() {
}
}
/// <summary>
/// Action <code>GetRequisitionData</code> that represents the Service Studio action
///  <code>GetRequisitionData</code> <p> Description: </p>
/// </summary>
public async Task<(bool,bool,bool,long,string,string,string,long,long,string,decimal)> DataActionGetRequisitionData(IRequestContext requestContext,CancellationToken cancellationToken) {
bool outParamAdvWithoutInvoice = default;
bool outParamAllowMultiUpload = default;
bool outParamWasAdvWithoutInvoice = default;
long outParamCostCenterSAPId = default;
string outParamCurrencyId = default;
string outParamDivisionFI = default;
string outParamProject = default;
long outParamPaymentMethodsId = default;
long outParamPaymentTermsId = default;
string outParamSupplierNr = default;
decimal outParamTotalAmount = default;
lcoGetRequisitionData result = new lcoGetRequisitionData();
lcvGetRequisitionData localVars = new lcvGetRequisitionData();
ConectaProveedores_c_Requisitions_Wb_RequisitionInvoices_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetRequisitionData", "c03bfa88-06a6-4109-a440-f847a6975a00"))
using (activitySource.CreateScreenDataActionActivity("Wb_RequisitionInvoices", "GetRequisitionData")){
// Query datasetGetRequisitionById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionById_maxRecords = 0;
int datasetGetRequisitionById_startIndex = 0;(localVars.queryResGetRequisitionById_outParamList,localVars.queryResGetRequisitionById_outParamCount) = await FuncDataActionGetRequisitionData.datasetGetRequisitionById(requestContext,datasetGetRequisitionById_maxRecords,datasetGetRequisitionById_startIndex,IterationMultiplicity.Never,inParami_RequisitionId,cancellationToken);

// AdvWithoutInvoice = GetRequisitionById.List.Current.Requisition.AdvWithoutInvoice
result.outParamAdvWithoutInvoice=localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssAdvWithoutInvoice;

// WasAdvWithoutInvoice = GetRequisitionById.List.Current.Requisition.WasAdvWithoutInvoice
result.outParamWasAdvWithoutInvoice=localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssWasAdvWithoutInvoice;

// CostCenterSAPId = GetRequisitionById.List.Current.Requisition.CostCenterId
result.outParamCostCenterSAPId=localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssCostCenterId;

// CurrencyId = GetRequisitionById.List.Current.Requisition.CurrencyId
result.outParamCurrencyId=localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssCurrencyId;

// DivisionFI = GetRequisitionById.List.Current.Region.DivisionFI
result.outParamDivisionFI=localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRegion.ssDivisionFI;

// Project = GetRequisitionById.List.Current.Requisition.ProjectDescription
result.outParamProject=localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssProjectDescription;

// PaymentMethodsId = GetRequisitionById.List.Current.Requisition.PaymentMethodId
result.outParamPaymentMethodsId=localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssPaymentMethodId;

// PaymentTermsId = GetRequisitionById.List.Current.Requisition.PaymentTermsId
result.outParamPaymentTermsId=localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssPaymentTermsId;

// SupplierNr = GetRequisitionById.List.Current.Supplier.Number
result.outParamSupplierNr=localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENSupplier.ssNumber;

// TotalAmount = GetRequisitionById.List.Current.Requisition.TotalAmount
result.outParamTotalAmount=localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssTotalAmount;

// AllowMultiUpload = GetRequisitionById.List.Current.Requisition.HasMultiUpload
result.outParamAllowMultiUpload=localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssHasMultiUpload;
} //close CreateActionActivity using block
} // try

finally {
outParamAdvWithoutInvoice = result.outParamAdvWithoutInvoice;
outParamAllowMultiUpload = result.outParamAllowMultiUpload;
outParamWasAdvWithoutInvoice = result.outParamWasAdvWithoutInvoice;
outParamCostCenterSAPId = result.outParamCostCenterSAPId;
outParamCurrencyId = result.outParamCurrencyId;
outParamDivisionFI = result.outParamDivisionFI;
outParamProject = result.outParamProject;
outParamPaymentMethodsId = result.outParamPaymentMethodsId;
outParamPaymentTermsId = result.outParamPaymentTermsId;
outParamSupplierNr = result.outParamSupplierNr;
outParamTotalAmount = result.outParamTotalAmount;
} // inner-finally
RETURN_STATEMENT:
return (outParamAdvWithoutInvoice,outParamAllowMultiUpload,outParamWasAdvWithoutInvoice,outParamCostCenterSAPId,outParamCurrencyId,outParamDivisionFI,outParamProject,outParamPaymentMethodsId,outParamPaymentTermsId,outParamSupplierNr,outParamTotalAmount);
}


    public static class FuncDataActionGetRequisitionData {

private static async Task<RC_9b8bde366f0fe61cf64fff2adf2f6e88> datasetGetRequisitionByIdReadDbAsync(RC_9b8bde366f0fe61cf64fff2adf2f6e88 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENRegion.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetRequisitionById" xxs8UCGcRk6gsJjoYe2MHg of Action "GetRequisitionData"
public static async Task<(RL_fb447cbe50933c4990bdca146fda9078,long)> datasetGetRequisitionById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisition_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("c_Requisitions.Wb_RequisitionInvoices.GetRequisitionData.GetRequisitionById", "503c1bc7-9c21-4e46-a0b0-98e861ed8c1e");
using var queryActivity = activitySource.CreateAggregateQueryActivity("c_Requisitions.Wb_RequisitionInvoices.GetRequisitionData.GetRequisitionById", "503c1bc7-9c21-4e46-a0b0-98e861ed8c1e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.NqM8b7xvgE6iEV43Re0jUg/DataActions.iPo7wKYGCUGkQPhHppdaAA/NodesNotShownInESpaceTree.xxs8UCGcRk6gsJjoYe2MHg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, \"enrequisition108\".\"wasadvwithoutinvoice\" o60, NULL o61, NULL o62, NULL o63, NULL o64, \"enrequisition108\".\"hasmultiupload\" o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98");
fromBuilder.Append(" FROM (({Requisition} \"enrequisition108\" Left JOIN {Supplier} \"ensupplier109\" ON (\"enrequisition108\".\"supplierid\" = \"ensupplier109\".\"id\"))  Left JOIN {Region} \"enregion138\" ON (\"enrequisition108\".\"regionid\" = \"enregion138\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpreRequisition_Id != 0) {
whereBuilder.Append("((\"enrequisition108\".\"id\" = @qpreRequisition_Id) AND (\"enrequisition108\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisition_Id", DbType.Int64, qpreRequisition_Id);
} else {
whereBuilder.Append("(\"enrequisition108\".\"id\" IS NULL)");
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
RL_fb447cbe50933c4990bdca146fda9078 outParamList = new RL_fb447cbe50933c4990bdca146fda9078();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetRequisitionByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, false, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.Wb_RequisitionInvoices.GetRequisitionData.GetRequisitionById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_fb447cbe50933c4990bdca146fda9078 _tmp = new RL_fb447cbe50933c4990bdca146fda9078();
_tmp.AlternateReadDbMethodAsync = datasetGetRequisitionByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.Wb_RequisitionInvoices.GetRequisitionData.GetRequisitionById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_fb447cbe50933c4990bdca146fda9078)_tmp;
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
