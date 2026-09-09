using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_j_FoliosSAE_Wb_FoliosContabilizationInvoiceSAPStatus_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_j_FoliosSAE_Wb_FoliosContabilizationInvoiceSAPStatus_ScreenModel).Namespace);

    public long inParami_FolioId;
public bool varLcl_CanUploadInvoice;
public bool varLcl_IsInvoiceRetryAccountingRefresh;
public AggregateRecord<RL_4c91727910427c345e342c96f50fbfbf> ScreenDataSetGetInvoicesByFolioId;
public AggregateRecord<RL_66bb1349260f72f9d01bbe22c0aaf421> ScreenDataSetGetFolioById;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_j_FoliosSAE_Wb_FoliosContabilizationInvoiceSAPStatus_ScreenModel() {
}



    public ConectaProveedores_j_FoliosSAE_Wb_FoliosContabilizationInvoiceSAPStatus_ScreenModel(long inParami_FolioId, bool varLcl_CanUploadInvoice, bool varLcl_IsInvoiceRetryAccountingRefresh, AggregateRecord<RL_4c91727910427c345e342c96f50fbfbf> ScreenDataSetGetInvoicesByFolioId, AggregateRecord<RL_66bb1349260f72f9d01bbe22c0aaf421> ScreenDataSetGetFolioById, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"i_FolioId", "l_CanUploadInvoice", "l_IsInvoiceRetryAccountingRefresh", "GetInvoicesByFolioId", "GetFolioById", "ClientVars"}, new string[] {"inParami_FolioId", "varLcl_CanUploadInvoice", "varLcl_IsInvoiceRetryAccountingRefresh", "ScreenDataSetGetInvoicesByFolioId", "ScreenDataSetGetFolioById", "clientVariables"});
this.inParami_FolioId = inParami_FolioId;
this.varLcl_CanUploadInvoice = varLcl_CanUploadInvoice;
this.varLcl_IsInvoiceRetryAccountingRefresh = varLcl_IsInvoiceRetryAccountingRefresh;
this.ScreenDataSetGetInvoicesByFolioId = ScreenDataSetGetInvoicesByFolioId;
this.ScreenDataSetGetFolioById = ScreenDataSetGetFolioById;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_cad676a01e44d775889bfdee9f2eda1f> datasetGetInvoicesByFolioIdReadDbAsync(RC_cad676a01e44d775889bfdee9f2eda1f rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceStatus.Read( r, ref index);
return rec;
}
// Query Function "GetInvoicesByFolioId" KWFTU8VMfUei90M+jcaI_g of Action "Wb_FoliosContabilizationInvoiceSAPStatus"
public static async Task<(RL_4c91727910427c345e342c96f50fbfbf,long)> datasetGetInvoicesByFolioId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckProveedorRole,long qpfoInvoice_FolioId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.Wb_FoliosContabilizationInvoiceSAPStatus.GetInvoicesByFolioId", "53536129-4cc5-477d-a2f7-433e8dc688fe");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_FoliosContabilizationInvoiceSAPStatus","j_FoliosSAE.Wb_FoliosContabilizationInvoiceSAPStatus.GetInvoicesByFolioId");
// Query Iterations: Multiple
// Refresh Query F6cGYEAAoUW6WGzimsqx5A Iterations: Multiple
// Refresh Query rBCMSVx25kCWXL0wKKP7TQ Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.vq5jq58eAkKrgznAloONng/ScreenDataSets.KWFTU8VMfUei90M+jcaI_g, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoice160\".\"id\" o0, \"eninvoice160\".\"name\" o1, NULL o2, NULL o3, NULL o4, NULL o5, trim_scale(\"eninvoice160\".\"totalamount\"::numeric) o6, \"eninvoice160\".\"currency\" o7, \"eninvoice160\".\"invoicestatusid\" o8, NULL o9, NULL o10, \"eninvoice160\".\"createdon\" o11, NULL o12, \"eninvoice160\".\"updatedon\" o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, \"eninvoice160\".\"accountingerror\" o20, NULL o21, NULL o22, NULL o23, \"eninvoicestatus24\".\"id\" o24, \"eninvoicestatus24\".\"label\" o25, \"eninvoicestatus24\".\"class\" o26, NULL o27, NULL o28, NULL o29, NULL o30");
fromBuilder.Append(" FROM ({Invoice} \"eninvoice160\" Left JOIN {InvoiceStatus} \"eninvoicestatus24\" ON (\"eninvoice160\".\"invoicestatusid\" = \"eninvoicestatus24\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoInvoice_FolioId != 0) {
whereBuilder.Append("((\"eninvoice160\".\"folioid\" = @qpfoInvoice_FolioId) AND (\"eninvoice160\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoInvoice_FolioId", DbType.Int64, qpfoInvoice_FolioId);
} else {
whereBuilder.Append("(\"eninvoice160\".\"folioid\" IS NULL)");
}
whereBuilder.Append(" AND ((@qpboCheckProveedorRole = 1) OR (\"eninvoice160\".\"invoicestatusid\" <> ");
whereBuilder.Append((ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("Wo+LRDF_n0O7Fo8ikSEsSA"))).ssId);
whereBuilder.Append("))");
orderByBuilder.Append(" ORDER BY \"eninvoice160\".\"createdon\" ASC ");
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
RL_4c91727910427c345e342c96f50fbfbf outParamList = new RL_4c91727910427c345e342c96f50fbfbf();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoicesByFolioIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, false, true, true, true, true, false, false, false, true, true, false, true, false, true, true, true, true, true, true, false, true, true, true});
opt[1] = new BitArray(new bool[] {false, false, false, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_FoliosContabilizationInvoiceSAPStatus.GetInvoicesByFolioId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_4c91727910427c345e342c96f50fbfbf _tmp = new RL_4c91727910427c345e342c96f50fbfbf();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoicesByFolioIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_FoliosContabilizationInvoiceSAPStatus.GetInvoicesByFolioId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_4c91727910427c345e342c96f50fbfbf)_tmp;
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
// Query Function "GetFolioById" tiGGnXDiQ0uzlqZwI7s8Jw of Action "Wb_FoliosContabilizationInvoiceSAPStatus"
public static async Task<(RL_66bb1349260f72f9d01bbe22c0aaf421,long)> datasetGetFolioById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolio_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.Wb_FoliosContabilizationInvoiceSAPStatus.GetFolioById", "9d8621b6-e270-4b43-b396-a67023bb3c27");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_FoliosContabilizationInvoiceSAPStatus","j_FoliosSAE.Wb_FoliosContabilizationInvoiceSAPStatus.GetFolioById");
// Query Iterations: Never
// Refresh Query o0H5gEt2M0akVzogctQ2Zg Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.vq5jq58eAkKrgznAloONng/ScreenDataSets.tiGGnXDiQ0uzlqZwI7s8Jw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, NULL o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, NULL o118, NULL o119, NULL o120, NULL o121, NULL o122, NULL o123, NULL o124, NULL o125, NULL o126, NULL o127, NULL o128, NULL o129, NULL o130, NULL o131, NULL o132, NULL o133, NULL o134, NULL o135, NULL o136, NULL o137, NULL o138, NULL o139, NULL o140, NULL o141, NULL o142, NULL o143, NULL o144, NULL o145, NULL o146, NULL o147, NULL o148, NULL o149, NULL o150");
fromBuilder.Append(" FROM (((((({Folio} \"enfolio115\" Left JOIN {Supplier} \"ensupplier155\" ON (\"enfolio115\".\"supplierid\" = \"ensupplier155\".\"id\"))  Left JOIN {OrderMain} \"enordermain155\" ON (\"enfolio115\".\"orderid\" = \"enordermain155\".\"id\"))  Left JOIN {OrderDetail} \"enorderdetail26\" ON (\"enordermain155\".\"id\" = \"enorderdetail26\".\"orderid\"))  Left JOIN {OrderAccounting} \"enorderaccounting8\" ON (\"enordermain155\".\"id\" = \"enorderaccounting8\".\"orderid\"))  Left JOIN {OrderCostCenter} \"enordercostcenter2\" ON (\"enordermain155\".\"id\" = \"enordercostcenter2\".\"orderid\"))  Left JOIN {Region} \"enregion202\" ON (\"enordermain155\".\"regionid\" = \"enregion202\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoFolio_Id != 0) {
whereBuilder.Append("((\"enfolio115\".\"id\" = @qpfoFolio_Id) AND (\"enfolio115\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolio_Id", DbType.Int64, qpfoFolio_Id);
} else {
whereBuilder.Append("(\"enfolio115\".\"id\" IS NULL)");
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
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[6] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_FoliosContabilizationInvoiceSAPStatus.GetFolioById.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_FoliosContabilizationInvoiceSAPStatus.GetFolioById.List", cancellationToken: cancellationToken);
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
