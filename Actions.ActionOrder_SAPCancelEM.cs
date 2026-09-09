namespace ssConectaProveedores;

public partial class Actions {
public class lcvOrder_SAPCancelEM : VarsBag {
public ST_ed201ff180bb2dd4a51ad889e8debcfaStructure inParamRequest;
public bool inParamIsCancel;
public int inParamOffsetUtc;
public RL_7b3475883ca90ad6eb7fc983e868c456 queryResGetInvoicesByFolioId_outParamList = new RL_7b3475883ca90ad6eb7fc983e868c456();
public long queryResGetInvoicesByFolioId_outParamCount = 0L;

public Actions.lcoFolioLogAdd resFolioLogAddApprove3 =  new Actions.lcoFolioLogAdd();
public Actions.lcoFolioSAPData_CreateOrUpdate resFolioSAPData_CreateOrUpdate =  new Actions.lcoFolioSAPData_CreateOrUpdate();
public Actions.lcoFolioLogAdd resFolioLogAdd =  new Actions.lcoFolioLogAdd();
public Actions.lcoFolioCreateOrUpdate resFolioCreateOrUpdate =  new Actions.lcoFolioCreateOrUpdate();
public RL_4782a431d7ec3ad4790982e6e1512a86 queryResGetFolioSAPDataByFolioId_outParamList = new RL_4782a431d7ec3ad4790982e6e1512a86();
public long queryResGetFolioSAPDataByFolioId_outParamCount = 0L;

public lcvOrder_SAPCancelEM(ST_ed201ff180bb2dd4a51ad889e8debcfaStructure inParamRequest, bool inParamIsCancel, int inParamOffsetUtc) {
this.inParamRequest = inParamRequest;
this.inParamIsCancel = inParamIsCancel;
this.inParamOffsetUtc = inParamOffsetUtc;
}
}
public class lcoOrder_SAPCancelEM : VarsBag {
public ST_5a17d82af8397abda9cf3915ce9c082fStructure outParamResponse = new ST_5a17d82af8397abda9cf3915ce9c082fStructure();

public lcoOrder_SAPCancelEM() {
}
}
/// <summary>
/// Action <code>Order_SAPCancelEM</code> that represents the Service Studio action
///  <code>Order_SAPCancelEM</code> <p> Description: </p>
/// </summary>
public static async Task<ST_5a17d82af8397abda9cf3915ce9c082fStructure> ActionOrder_SAPCancelEM(IRequestContext requestContext,ST_ed201ff180bb2dd4a51ad889e8debcfaStructure inParamRequest,bool inParamIsCancel,int inParamOffsetUtc,CancellationToken cancellationToken) {
ST_5a17d82af8397abda9cf3915ce9c082fStructure outParamResponse = default;
lcoOrder_SAPCancelEM result = new lcoOrder_SAPCancelEM();
lcvOrder_SAPCancelEM localVars = new lcvOrder_SAPCancelEM(inParamRequest, inParamIsCancel, inParamOffsetUtc);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("Order_SAPCancelEM", "7670b0bd-6189-4da0-9849-ab731b168c93"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("Order_SAPCancelEM", "7670b0bd-6189-4da0-9849-ab731b168c93", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetFolioSAPDataByFolioId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioSAPDataByFolioId_maxRecords = 1;
if (datasetGetFolioSAPDataByFolioId_maxRecords < 1) datasetGetFolioSAPDataByFolioId_maxRecords = 1;
int datasetGetFolioSAPDataByFolioId_startIndex = 0;(localVars.queryResGetFolioSAPDataByFolioId_outParamList,localVars.queryResGetFolioSAPDataByFolioId_outParamCount) = await FuncActionOrder_SAPCancelEM.datasetGetFolioSAPDataByFolioId(requestContext,datasetGetFolioSAPDataByFolioId_maxRecords,datasetGetFolioSAPDataByFolioId_startIndex,IterationMultiplicity.Never,localVars.inParamRequest.ssEMDocMaterial,localVars.inParamRequest.ssGroupFolio,localVars.inParamRequest.ssOrderNumber,cancellationToken);

// error
if((localVars.queryResGetFolioSAPDataByFolioId_outParamList.Empty)) {
// Response.ErrorMessage = "Folio not found"
result.outParamResponse.ssErrorMessage = AppUtils.GetStringResource("FgnMbDsAK0mBt5ruj9Jddw#Value.1433296286.1", "Folio not found");

// Response.HasSuccess = False
result.outParamResponse.ssHasSuccess = false;

// Response.OrderNumber = GetFolioSAPDataByFolioId.List.Current.OrderMain.OrderNumber
result.outParamResponse.ssOrderNumber = localVars.queryResGetFolioSAPDataByFolioId_outParamList.CurrentRec.ssENOrderMain.ssOrderNumber;
} else {
// Success
// Response.HasSuccess = True
result.outParamResponse.ssHasSuccess = true;

// Response.OrderNumber = GetFolioSAPDataByFolioId.List.Current.OrderMain.OrderNumber
result.outParamResponse.ssOrderNumber = localVars.queryResGetFolioSAPDataByFolioId_outParamList.CurrentRec.ssENOrderMain.ssOrderNumber;
// FolioSAPData
// GetFolioSAPDataByFolioId.List.Current.FolioSAPData.PO_DOCUMENTO_MATERIAL_EM = Request.EMDocMaterial
localVars.queryResGetFolioSAPDataByFolioId_outParamList.CurrentRec.ssENFolioSAPData.ssPO_DOCUMENTO_MATERIAL_EM = localVars.inParamRequest.ssEMDocMaterial;

// GetFolioSAPDataByFolioId.List.Current.FolioSAPData.PO_EJERCICIO_EM = Request.EMDocYear
localVars.queryResGetFolioSAPDataByFolioId_outParamList.CurrentRec.ssENFolioSAPData.ssPO_EJERCICIO_EM = localVars.inParamRequest.ssEMDocYear;

// GetFolioSAPDataByFolioId.List.Current.FolioSAPData.PO_DOCUMENTO_MATERIAL_SM = Request.SMDocMaterial
localVars.queryResGetFolioSAPDataByFolioId_outParamList.CurrentRec.ssENFolioSAPData.ssPO_DOCUMENTO_MATERIAL_SM = localVars.inParamRequest.ssSMDocMaterial;

// GetFolioSAPDataByFolioId.List.Current.FolioSAPData.PO_EJERCICIO_SM = Request.SMDocYear
localVars.queryResGetFolioSAPDataByFolioId_outParamList.CurrentRec.ssENFolioSAPData.ssPO_EJERCICIO_SM = localVars.inParamRequest.ssSMDocYear;

// GetFolioSAPDataByFolioId.List.Current.FolioSAPData.PO_FOLIO_AGRUPADOS = Request.GroupFolio
localVars.queryResGetFolioSAPDataByFolioId_outParamList.CurrentRec.ssENFolioSAPData.ssPO_FOLIO_AGRUPADOS = localVars.inParamRequest.ssGroupFolio;

// GetFolioSAPDataByFolioId.List.Current.FolioSAPData.Service = GetFolioSAPDataByFolioId.List.Current.FolioSAPData.Service + " | Modify from SAP"
localVars.queryResGetFolioSAPDataByFolioId_outParamList.CurrentRec.ssENFolioSAPData.ssService = (localVars.queryResGetFolioSAPDataByFolioId_outParamList.CurrentRec.ssENFolioSAPData.ssService+" | Modify from SAP");
// FolioSAPData_CreateOrUpdate
localVars.resFolioSAPData_CreateOrUpdate.outParamId = await Actions.ActionFolioSAPData_CreateOrUpdate(requestContext,localVars.queryResGetFolioSAPDataByFolioId_outParamList.CurrentRec.ssENFolioSAPData,cancellationToken);

// FolioLogAddApprove3
localVars.resFolioLogAddApprove3.outParamId = await Actions.ActionFolioLogAdd(requestContext,new EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssFolioId = localVars.queryResGetFolioSAPDataByFolioId_outParamList.CurrentRec.ssENFolio.ssId, ssMessage = ((((((AppUtils.GetStringResource("GF0_h8tnE0e5i3SAJp8JbQ#Value.68060425.1", "Folio")+" ")+localVars.queryResGetFolioSAPDataByFolioId_outParamList.CurrentRec.ssENFolio.ssFolioNumber)+" ")+AppUtils.GetStringResource("GF0_h8tnE0e5i3SAJp8JbQ#Value.-1531694730.1", "notified with group folio"))+" ")+localVars.queryResGetFolioSAPDataByFolioId_outParamList.CurrentRec.ssENFolioSAPData.ssPO_FOLIO_AGRUPADOS), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime () },cancellationToken);

// cancel
if((localVars.inParamIsCancel)) {
// Folio_Status_Error
// GetFolioSAPDataByFolioId.List.Current.Folio.FolioStatusId = Canceled
localVars.queryResGetFolioSAPDataByFolioId_outParamList.CurrentRec.ssENFolio.ssFolioStatusId = (ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("cklscJNc0UyOgKXGwg51TQ"))).ssId;
// FolioCreateOrUpdate
localVars.resFolioCreateOrUpdate.outParamId = await Actions.ActionFolioCreateOrUpdate(requestContext,localVars.queryResGetFolioSAPDataByFolioId_outParamList.CurrentRec.ssENFolio,cancellationToken);

// CancelInvoiceByFolioId
await Actions.ActionCancelInvoiceByFolioId(requestContext,localVars.resFolioCreateOrUpdate.outParamId,cancellationToken);

// FolioLogAdd
localVars.resFolioLogAdd.outParamId = await Actions.ActionFolioLogAdd(requestContext,new EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssFolioId = localVars.queryResGetFolioSAPDataByFolioId_outParamList.CurrentRec.ssENFolio.ssId, ssMessage = ((((((AppUtils.GetStringResource("7THlofSJIkOZQx3AVab7LQ#Value.68060425.1", "Folio")+" ")+localVars.queryResGetFolioSAPDataByFolioId_outParamList.CurrentRec.ssENFolio.ssFolioNumber)+" ")+AppUtils.GetStringResource("7THlofSJIkOZQx3AVab7LQ#Value.-953405950.1", "has been updated to Failed Entry Request status"))+".")+""), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssIsError = false },cancellationToken);

} else {
// Query datasetGetInvoicesByFolioId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoicesByFolioId_maxRecords = 0;
int datasetGetInvoicesByFolioId_startIndex = 0;(localVars.queryResGetInvoicesByFolioId_outParamList,localVars.queryResGetInvoicesByFolioId_outParamCount) = await FuncActionOrder_SAPCancelEM.datasetGetInvoicesByFolioId(requestContext,datasetGetInvoicesByFolioId_maxRecords,datasetGetInvoicesByFolioId_startIndex,IterationMultiplicity.Never,localVars.queryResGetFolioSAPDataByFolioId_outParamList.CurrentRec.ssENFolio.ssId,cancellationToken);

// InvoiceAccountingProcess_Create
await Actions.ActionInvoiceAccountingProcess_Create(requestContext,localVars.queryResGetInvoicesByFolioId_outParamList.CurrentRec.ssENInvoice.ssId,"",true,Convert.ToInt64(BuiltInFunction.NullIdentifier ()),localVars.inParamOffsetUtc,cancellationToken);

}

}

} //close CreateActionActivity using block
} // try

finally {
outParamResponse = result.outParamResponse;
} // inner-finally
RETURN_STATEMENT:
return outParamResponse;
}

public static class FuncActionOrder_SAPCancelEM {

// Query Function "GetInvoicesByFolioId" M06JCfQmAkyz5LOQvFr1Qw of Action "Order_SAPCancelEM"
public static async Task<(RL_7b3475883ca90ad6eb7fc983e868c456,long)> datasetGetInvoicesByFolioId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolioId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("Order_SAPCancelEM.GetInvoicesByFolioId", "09894e33-26f4-4c02-b3e4-b390bc5af543");
using var queryActivity = activitySource.CreateAggregateQueryActivity("Order_SAPCancelEM.GetInvoicesByFolioId", "09894e33-26f4-4c02-b3e4-b390bc5af543", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.vbBwdolhoE2YSatzGxaMkw/NodesNotShownInESpaceTree.M06JCfQmAkyz5LOQvFr1Qw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoice29\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23");
fromBuilder.Append(" FROM {Invoice} \"eninvoice29\"");
whereBuilder.Append(" WHERE ");
if (qpfoFolioId != 0) {
whereBuilder.Append("((\"eninvoice29\".\"folioid\" = @qpfoFolioId) AND (\"eninvoice29\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioId", DbType.Int64, qpfoFolioId);
} else {
whereBuilder.Append("(\"eninvoice29\".\"folioid\" IS NULL)");
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
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query Order_SAPCancelEM.GetInvoicesByFolioId.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query Order_SAPCancelEM.GetInvoicesByFolioId.List", cancellationToken: cancellationToken);
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

private static async Task<RC_5777458deab7db32c7893b9baeff3dc9> datasetGetFolioSAPDataByFolioIdReadDbAsync(RC_5777458deab7db32c7893b9baeff3dc9 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolio.Read( r, ref index);
rec.ssENFolioSAPData.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
return rec;
}
// Query Function "GetFolioSAPDataByFolioId" 92k7_IFYY02DxHi4BBJLDA of Action "Order_SAPCancelEM"
public static async Task<(RL_4782a431d7ec3ad4790982e6e1512a86,long)> datasetGetFolioSAPDataByFolioId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteFolioSAPData_PO_DOCUMENTO_MATERIAL_EM,string qpteFolioSAPData_PO_FOLIO_AGRUPADOS,string qpteOrderMain_OrderNumber,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("Order_SAPCancelEM.GetFolioSAPDataByFolioId", "fc3b69f7-5881-4d63-83c4-78b804124b0c");
using var queryActivity = activitySource.CreateAggregateQueryActivity("Order_SAPCancelEM.GetFolioSAPDataByFolioId", "fc3b69f7-5881-4d63-83c4-78b804124b0c", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.vbBwdolhoE2YSatzGxaMkw/NodesNotShownInESpaceTree.92k7_IFYY02DxHi4BBJLDA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enfolio21\".\"id\" o0, \"enfolio21\".\"isdraft\" o1, \"enfolio21\".\"folionumber\" o2, \"enfolio21\".\"canproveedorcancel\" o3, \"enfolio21\".\"orderid\" o4, \"enfolio21\".\"supplierid\" o5, \"enfolio21\".\"companyid\" o6, \"enfolio21\".\"foliostatusid\" o7, trim_scale(\"enfolio21\".\"totalamount\"::numeric) o8, trim_scale(\"enfolio21\".\"totaliva_amount\"::numeric) o9, trim_scale(\"enfolio21\".\"partialamount\"::numeric) o10, \"enfolio21\".\"currencyid\" o11, \"enfolio21\".\"firstapproveruserid\" o12, \"enfolio21\".\"approvalprocesstypeid\" o13, \"enfolio21\".\"sapentryerror\" o14, \"enfolio21\".\"createdby\" o15, \"enfolio21\".\"createdon\" o16, \"enfolio21\".\"updatedby\" o17, \"enfolio21\".\"updatedon\" o18, \"enfolio21\".\"minuteselected\" o19, \"enfoliosapdata4\".\"id\" o20, \"enfoliosapdata4\".\"folioid\" o21, \"enfoliosapdata4\".\"service\" o22, \"enfoliosapdata4\".\"po_documento_material_em\" o23, \"enfoliosapdata4\".\"po_documento_material_sm\" o24, \"enfoliosapdata4\".\"po_documento_material_221\" o25, \"enfoliosapdata4\".\"po_documento_material_415\" o26, \"enfoliosapdata4\".\"po_ejercicio_em\" o27, \"enfoliosapdata4\".\"po_ejercicio_sm\" o28, \"enfoliosapdata4\".\"po_ejercicio_221\" o29, \"enfoliosapdata4\".\"po_ejercicio_415\" o30, \"enfoliosapdata4\".\"po_folio_agrupados\" o31, \"enfoliosapdata4\".\"po_resultado\" o32, \"enfoliosapdata4\".\"createdby\" o33, \"enfoliosapdata4\".\"createdon\" o34, NULL o35, \"enordermain35\".\"ordernumber\" o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63");
fromBuilder.Append(" FROM (({FolioSAPData} \"enfoliosapdata4\" Left JOIN {Folio} \"enfolio21\" ON (\"enfoliosapdata4\".\"folioid\" = \"enfolio21\".\"id\"))  Left JOIN {OrderMain} \"enordermain35\" ON (\"enfolio21\".\"orderid\" = \"enordermain35\".\"id\")) ");
whereBuilder.Append(" WHERE (\"enordermain35\".\"ordernumber\" = @qpteOrderMain_OrderNumber) AND ((@qpteFolioSAPData_PO_FOLIO_AGRUPADOS = \"enfoliosapdata4\".\"po_folio_agrupados\") OR (\"enfoliosapdata4\".\"po_documento_material_em\" = @qpteFolioSAPData_PO_DOCUMENTO_MATERIAL_EM)) AND ((\"enfolio21\".\"foliostatusid\" <> ");
whereBuilder.Append((ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("cklscJNc0UyOgKXGwg51TQ"))).ssId);
whereBuilder.Append(") AND (\"enfolio21\".\"foliostatusid\" <> ");
whereBuilder.Append((ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("l5OG661dZEe+gAZwnNLhSA"))).ssId);
whereBuilder.Append("))");
sqlCmd.CreateParameterWithoutReplacements("@qpteOrderMain_OrderNumber", DbType.String, qpteOrderMain_OrderNumber);
sqlCmd.CreateParameterWithoutReplacements("@qpteFolioSAPData_PO_FOLIO_AGRUPADOS", DbType.String, qpteFolioSAPData_PO_FOLIO_AGRUPADOS);
sqlCmd.CreateParameterWithoutReplacements("@qpteFolioSAPData_PO_DOCUMENTO_MATERIAL_EM", DbType.String, qpteFolioSAPData_PO_DOCUMENTO_MATERIAL_EM);
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
RL_4782a431d7ec3ad4790982e6e1512a86 outParamList = new RL_4782a431d7ec3ad4790982e6e1512a86();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFolioSAPDataByFolioIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[2] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query Order_SAPCancelEM.GetFolioSAPDataByFolioId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_4782a431d7ec3ad4790982e6e1512a86 _tmp = new RL_4782a431d7ec3ad4790982e6e1512a86();
_tmp.AlternateReadDbMethodAsync = datasetGetFolioSAPDataByFolioIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query Order_SAPCancelEM.GetFolioSAPDataByFolioId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_4782a431d7ec3ad4790982e6e1512a86)_tmp;
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
