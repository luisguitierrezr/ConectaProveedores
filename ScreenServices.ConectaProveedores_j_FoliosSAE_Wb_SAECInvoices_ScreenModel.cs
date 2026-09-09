using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_j_FoliosSAE_Wb_SAECInvoices_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_j_FoliosSAE_Wb_SAECInvoices_ScreenModel).Namespace);

    public long inParami_FolioId;
public bool inParamIsReadOnly;
public bool varLcl_CanUploadInvoice;
public bool varLcl_IsOpenPopupInvoices;
public long varLcl_InvoiceIdToPopup;
public int varLcl_InvoiceStatusIdToPopup;
public long varLcl_CreditNoteInvoiceIdToPopup;
public decimal varLcl_ImportAnticipo;
public AggregateRecord<RL_963435a7e2b76a25c650ba38c8633cf8> ScreenDataSetGetInvoicesByFolioId;
public AggregateRecord<RL_66bb1349260f72f9d01bbe22c0aaf421> ScreenDataSetGetFolioById;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_j_FoliosSAE_Wb_SAECInvoices_ScreenModel() {
}



    public ConectaProveedores_j_FoliosSAE_Wb_SAECInvoices_ScreenModel(long inParami_FolioId, bool inParamIsReadOnly, bool varLcl_CanUploadInvoice, bool varLcl_IsOpenPopupInvoices, long varLcl_InvoiceIdToPopup, int varLcl_InvoiceStatusIdToPopup, long varLcl_CreditNoteInvoiceIdToPopup, decimal varLcl_ImportAnticipo, AggregateRecord<RL_963435a7e2b76a25c650ba38c8633cf8> ScreenDataSetGetInvoicesByFolioId, AggregateRecord<RL_66bb1349260f72f9d01bbe22c0aaf421> ScreenDataSetGetFolioById, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"i_FolioId", "IsReadOnly", "l_CanUploadInvoice", "l_IsOpenPopupInvoices", "l_InvoiceIdToPopup", "l_InvoiceStatusIdToPopup", "l_CreditNoteInvoiceIdToPopup", "l_ImportAnticipo", "GetInvoicesByFolioId", "GetFolioById", "ClientVars"}, new string[] {"inParami_FolioId", "inParamIsReadOnly", "varLcl_CanUploadInvoice", "varLcl_IsOpenPopupInvoices", "varLcl_InvoiceIdToPopup", "varLcl_InvoiceStatusIdToPopup", "varLcl_CreditNoteInvoiceIdToPopup", "varLcl_ImportAnticipo", "ScreenDataSetGetInvoicesByFolioId", "ScreenDataSetGetFolioById", "clientVariables"});
this.inParami_FolioId = inParami_FolioId;
this.inParamIsReadOnly = inParamIsReadOnly;
this.varLcl_CanUploadInvoice = varLcl_CanUploadInvoice;
this.varLcl_IsOpenPopupInvoices = varLcl_IsOpenPopupInvoices;
this.varLcl_InvoiceIdToPopup = varLcl_InvoiceIdToPopup;
this.varLcl_InvoiceStatusIdToPopup = varLcl_InvoiceStatusIdToPopup;
this.varLcl_CreditNoteInvoiceIdToPopup = varLcl_CreditNoteInvoiceIdToPopup;
this.varLcl_ImportAnticipo = varLcl_ImportAnticipo;
this.ScreenDataSetGetInvoicesByFolioId = ScreenDataSetGetInvoicesByFolioId;
this.ScreenDataSetGetFolioById = ScreenDataSetGetFolioById;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_426e2c309e94de792ac54a8e3665e09a> datasetGetInvoicesByFolioIdReadDbAsync(RC_426e2c309e94de792ac54a8e3665e09a rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoice_CN.Read( r, ref index);
rec.ssENInvoiceStatus.Read( r, ref index);
return rec;
}
// Query Function "GetInvoicesByFolioId" 9P3IPVK3UEqe+4Mm8TdNrQ of Action "Wb_SAECInvoices"
public static async Task<(RL_963435a7e2b76a25c650ba38c8633cf8,long)> datasetGetInvoicesByFolioId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckProveedorRole,long qpfoInvoice_FolioId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.Wb_SAECInvoices.GetInvoicesByFolioId", "3dc8fdf4-b752-4a50-9efb-8326f1374dad");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_SAECInvoices","j_FoliosSAE.Wb_SAECInvoices.GetInvoicesByFolioId");
// Query Iterations: Multiple
// Refresh Query Lj+_Ye56EEmwg7ZfQN6w0g Iterations: Multiple
// Refresh Query ShGG0DjwakCZ3E9OCRvL7Q Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.zAsvbssQiUqJUKusxuo6jQ/ScreenDataSets.9P3IPVK3UEqe+4Mm8TdNrQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoice157\".\"id\" o0, \"eninvoice157\".\"name\" o1, NULL o2, NULL o3, NULL o4, NULL o5, trim_scale(\"eninvoice157\".\"totalamount\"::numeric) o6, \"eninvoice157\".\"currency\" o7, \"eninvoice157\".\"invoicestatusid\" o8, NULL o9, NULL o10, \"eninvoice157\".\"createdon\" o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, \"eninvoice157\".\"creditnoteinvoiceid\" o23, NULL o24, \"eninvoice_cn2\".\"name\" o25, NULL o26, NULL o27, NULL o28, NULL o29, trim_scale(\"eninvoice_cn2\".\"totalamount\"::numeric) o30, \"eninvoice_cn2\".\"currency\" o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, \"eninvoicestatus23\".\"id\" o48, \"eninvoicestatus23\".\"label\" o49, \"eninvoicestatus23\".\"class\" o50, NULL o51, NULL o52, NULL o53, NULL o54");
fromBuilder.Append(" FROM (({Invoice} \"eninvoice157\" Left JOIN {InvoiceStatus} \"eninvoicestatus23\" ON (\"eninvoice157\".\"invoicestatusid\" = \"eninvoicestatus23\".\"id\"))  Left JOIN {Invoice} \"eninvoice_cn2\" ON (\"eninvoice157\".\"creditnoteinvoiceid\" = \"eninvoice_cn2\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoInvoice_FolioId != 0) {
whereBuilder.Append("((\"eninvoice157\".\"folioid\" = @qpfoInvoice_FolioId) AND (\"eninvoice157\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoInvoice_FolioId", DbType.Int64, qpfoInvoice_FolioId);
} else {
whereBuilder.Append("(\"eninvoice157\".\"folioid\" IS NULL)");
}
whereBuilder.Append(" AND ((@qpboCheckProveedorRole = 1) OR (\"eninvoice157\".\"invoicestatusid\" <> ");
whereBuilder.Append((ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("Wo+LRDF_n0O7Fo8ikSEsSA"))).ssId);
whereBuilder.Append("))");
orderByBuilder.Append(" ORDER BY \"eninvoice157\".\"createdon\" ASC ");
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
RL_963435a7e2b76a25c650ba38c8633cf8 outParamList = new RL_963435a7e2b76a25c650ba38c8633cf8();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoicesByFolioIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {false, false, true, true, true, true, false, false, false, true, true, false, true, true, true, true, true, true, true, true, true, true, true, false});
opt[1] = new BitArray(new bool[] {true, false, true, true, true, true, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {false, false, false, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_SAECInvoices.GetInvoicesByFolioId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_963435a7e2b76a25c650ba38c8633cf8 _tmp = new RL_963435a7e2b76a25c650ba38c8633cf8();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoicesByFolioIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_SAECInvoices.GetInvoicesByFolioId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_963435a7e2b76a25c650ba38c8633cf8)_tmp;
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

private static async Task<RC_f049d8b2272822e744e04ef94d71a8ef> datasetGetFolioByIdReadDbAsync(RC_f049d8b2272822e744e04ef94d71a8ef rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolio.Read( r, ref index);
rec.ssENOrderAccounting.Read( r, ref index);
rec.ssENOrderCostCenter.Read( r, ref index);
rec.ssENOrderDetail.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetFolioById" GaCq0O2k5kmD9ZRxQ_yQEQ of Action "Wb_SAECInvoices"
public static async Task<(RL_66bb1349260f72f9d01bbe22c0aaf421,long)> datasetGetFolioById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolio_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.Wb_SAECInvoices.GetFolioById", "d0aaa019-a4ed-49e6-83f5-947143fc9011");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_SAECInvoices","j_FoliosSAE.Wb_SAECInvoices.GetFolioById");
// Query Iterations: Never
// Refresh Query jhgeBurrM0G1WlIa68ckYQ Iterations: Never
// Refresh Query 1YEo5MLXZkW4Awjf8Jy3tA Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.zAsvbssQiUqJUKusxuo6jQ/ScreenDataSets.GaCq0O2k5kmD9ZRxQ_yQEQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, \"enfolio101\".\"foliostatusid\" o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, \"enordermain142\".\"id\" o81, \"enordermain142\".\"ordernumber\" o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, NULL o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, NULL o118, NULL o119, NULL o120, NULL o121, NULL o122, NULL o123, NULL o124, NULL o125, NULL o126, NULL o127, NULL o128, NULL o129, NULL o130, NULL o131, NULL o132, NULL o133, NULL o134, NULL o135, NULL o136, NULL o137, NULL o138, NULL o139, NULL o140, NULL o141, NULL o142, NULL o143, NULL o144, NULL o145, NULL o146, NULL o147, NULL o148, NULL o149, NULL o150");
fromBuilder.Append(" FROM (((((({Folio} \"enfolio101\" Left JOIN {Supplier} \"ensupplier144\" ON (\"enfolio101\".\"supplierid\" = \"ensupplier144\".\"id\"))  Left JOIN {OrderMain} \"enordermain142\" ON (\"enfolio101\".\"orderid\" = \"enordermain142\".\"id\"))  Left JOIN {OrderDetail} \"enorderdetail23\" ON (\"enordermain142\".\"id\" = \"enorderdetail23\".\"orderid\"))  Left JOIN {OrderAccounting} \"enorderaccounting7\" ON (\"enordermain142\".\"id\" = \"enorderaccounting7\".\"orderid\"))  Left JOIN {OrderCostCenter} \"enordercostcenter1\" ON (\"enordermain142\".\"id\" = \"enordercostcenter1\".\"orderid\"))  Left JOIN {Region} \"enregion190\" ON (\"enordermain142\".\"regionid\" = \"enregion190\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoFolio_Id != 0) {
whereBuilder.Append("((\"enfolio101\".\"id\" = @qpfoFolio_Id) AND (\"enfolio101\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolio_Id", DbType.Int64, qpfoFolio_Id);
} else {
whereBuilder.Append("(\"enfolio101\".\"id\" IS NULL)");
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
RL_66bb1349260f72f9d01bbe22c0aaf421 outParamList = new RL_66bb1349260f72f9d01bbe22c0aaf421();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFolioByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[7];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[6] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_SAECInvoices.GetFolioById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_66bb1349260f72f9d01bbe22c0aaf421 _tmp = new RL_66bb1349260f72f9d01bbe22c0aaf421();
_tmp.AlternateReadDbMethodAsync = datasetGetFolioByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_SAECInvoices.GetFolioById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_66bb1349260f72f9d01bbe22c0aaf421)_tmp;
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
