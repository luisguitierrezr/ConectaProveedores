using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_c_Proveedor_RegionSpecificDetail_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_c_Proveedor_RegionSpecificDetail_ScreenModel).Namespace);

    public long inParami_RegionId;
public long inParami_SupplierId;
public int inParami_CurrentRowNumber;
public string varLcTableSort;
public int varLcStartIndex;
public int varLcMaxRecords;
public AggregateRecord<RL_a0d7b43e9ac13e97d2ade731b2b4eb81> ScreenDataSetGetInvoiceApprovalLevels;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_c_Proveedor_RegionSpecificDetail_ScreenModel() {
}



    public ConectaProveedores_c_Proveedor_RegionSpecificDetail_ScreenModel(long inParami_RegionId, long inParami_SupplierId, int inParami_CurrentRowNumber, string varLcTableSort, int varLcStartIndex, int varLcMaxRecords, AggregateRecord<RL_a0d7b43e9ac13e97d2ade731b2b4eb81> ScreenDataSetGetInvoiceApprovalLevels, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"i_RegionId", "i_SupplierId", "i_CurrentRowNumber", "TableSort", "StartIndex", "MaxRecords", "GetInvoiceApprovalLevels", "ClientVars"}, new string[] {"inParami_RegionId", "inParami_SupplierId", "inParami_CurrentRowNumber", "varLcTableSort", "varLcStartIndex", "varLcMaxRecords", "ScreenDataSetGetInvoiceApprovalLevels", "clientVariables"});
this.inParami_RegionId = inParami_RegionId;
this.inParami_SupplierId = inParami_SupplierId;
this.inParami_CurrentRowNumber = inParami_CurrentRowNumber;
this.varLcTableSort = varLcTableSort;
this.varLcStartIndex = varLcStartIndex;
this.varLcMaxRecords = varLcMaxRecords;
this.ScreenDataSetGetInvoiceApprovalLevels = ScreenDataSetGetInvoiceApprovalLevels;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_8fe6259afe1f49269695fecf5b2d7937> datasetGetInvoiceApprovalLevelsReadDbAsync(RC_8fe6259afe1f49269695fecf5b2d7937 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceStatus.Read( r, ref index);
rec.ssENPaymentTerms.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
rec.ssENRequisitionAccounting.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceApprovalLevels" 45wv5dy+I02DGSefU6wsXw of Action "RegionSpecificDetail"
public static async Task<(RL_a0d7b43e9ac13e97d2ade731b2b4eb81,long)> datasetGetInvoiceApprovalLevels(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,DateTime qpdaAccountStatus_DateFrom,DateTime qpdaAccountStatus_DateTo,string qpteAccountStatus_InvoiceName,int qpinInvoice_InvoiceStatusId,long qpreRequisition_RegionId,long qpsuRequisition_SupplierId,string qpteTableSort,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("c_Proveedor.RegionSpecificDetail.GetInvoiceApprovalLevels", "e52f9ce3-bedc-4d23-8319-279f53ac2c5f");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("RegionSpecificDetail","c_Proveedor.RegionSpecificDetail.GetInvoiceApprovalLevels");
// Query Iterations: Multiple
// Refresh Query TT+vrMz8LEmN_tX4aoEvCg Iterations: Multiple
// Refresh Query CW_aI2OTmUy1KiqLflSz8A Iterations: Multiple
// Refresh Query NXEYxs1FuUae55gGakBLBA Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
await using(var sqlCountCmd = trans.CreateCommand()){
string sql = "";
string sqlCount = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /NRWebFlows.C1VQREl4LUakdtWZ9kDRuQ/NodesShownInESpaceTree.U4eZQoMhYUeNvsUGjHyTWA/ScreenDataSets.45wv5dy+I02DGSefU6wsXw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"eninvoice132\".\"name\" o1, NULL o2, NULL o3, NULL o4, NULL o5, trim_scale(\"eninvoice132\".\"totalamount\"::numeric) o6, NULL o7, NULL o8, \"eninvoice132\".\"accountingdatetime\" o9, \"eninvoice132\".\"paymentdatetime\" o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, \"eninvoicestatus14\".\"label\" o25, \"eninvoicestatus14\".\"class\" o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, \"enpaymentterms27\".\"description\" o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, NULL o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, NULL o111, trim_scale(\"enrequisitionaccounting6\".\"negociatedexchangerateacc\"::numeric) o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, NULL o118");
fromBuilder.Append(" FROM (((({Invoice} \"eninvoice132\" Left JOIN {Requisition} \"enrequisition106\" ON (\"eninvoice132\".\"requisitionid\" = \"enrequisition106\".\"id\"))  Left JOIN {PaymentTerms} \"enpaymentterms27\" ON (\"enrequisition106\".\"paymenttermsid\" = \"enpaymentterms27\".\"id\"))  Left JOIN {RequisitionAccounting} \"enrequisitionaccounting6\" ON (\"enpaymentterms27\".\"id\" = \"enrequisitionaccounting6\".\"paymenttermid_deprec\"))  Left JOIN {InvoiceStatus} \"eninvoicestatus14\" ON (\"eninvoice132\".\"invoicestatusid\" = \"eninvoicestatus14\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpreRequisition_RegionId != 0) {
whereBuilder.Append("((\"enrequisition106\".\"regionid\" = @qpreRequisition_RegionId) AND (\"enrequisition106\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisition_RegionId", DbType.Int64, qpreRequisition_RegionId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpreRequisition_RegionId", DbType.Int64, qpreRequisition_RegionId);
} else {
whereBuilder.Append("(\"enrequisition106\".\"regionid\" IS NULL)");
}
whereBuilder.Append(" AND ");
if (qpsuRequisition_SupplierId != 0) {
whereBuilder.Append("((\"enrequisition106\".\"supplierid\" = @qpsuRequisition_SupplierId) AND (\"enrequisition106\".\"supplierid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuRequisition_SupplierId", DbType.Int64, qpsuRequisition_SupplierId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpsuRequisition_SupplierId", DbType.Int64, qpsuRequisition_SupplierId);
} else {
whereBuilder.Append("(\"enrequisition106\".\"supplierid\" IS NULL)");
}
whereBuilder.Append(" AND ((CASE WHEN (@qpinInvoice_InvoiceStatusId <> 0) THEN (CASE WHEN ");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoice_InvoiceStatusId", DbType.Int32, qpinInvoice_InvoiceStatusId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpinInvoice_InvoiceStatusId", DbType.Int32, qpinInvoice_InvoiceStatusId);
if (qpinInvoice_InvoiceStatusId != 0) {
whereBuilder.Append("((\"eninvoice132\".\"invoicestatusid\" = @qpinInvoice_InvoiceStatusId) AND (\"eninvoice132\".\"invoicestatusid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoice_InvoiceStatusId", DbType.Int32, qpinInvoice_InvoiceStatusId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpinInvoice_InvoiceStatusId", DbType.Int32, qpinInvoice_InvoiceStatusId);
} else {
whereBuilder.Append("(\"eninvoice132\".\"invoicestatusid\" IS NULL)");
}
whereBuilder.Append(" THEN 1 ELSE 0 END) ELSE (CASE WHEN ((\"eninvoice132\".\"invoicestatusid\" = ");
whereBuilder.Append((ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("clB7Cs6DQ0ebdBjstV8soA"))).ssId);
whereBuilder.Append(") OR (\"eninvoice132\".\"invoicestatusid\" = ");
whereBuilder.Append((ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("pWUau3x8lku6cvimchlK7g"))).ssId);
whereBuilder.Append(")) THEN 1 ELSE 0 END) END) = 1) AND ((CASE WHEN ((trim(@qpteAccountStatus_InvoiceName)) <> '') THEN (CASE WHEN (caseaccent_normalize(\"eninvoice132\".\"name\" collate \"default\") like caseaccent_normalize((('%' || @qpteAccountStatus_InvoiceName) || '%') collate \"default\")) THEN 1 ELSE 0 END) ELSE 1 END) = 1) AND ((CASE WHEN ");
sqlCmd.CreateParameterWithoutReplacements("@qpteAccountStatus_InvoiceName", DbType.String, qpteAccountStatus_InvoiceName);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteAccountStatus_InvoiceName", DbType.String, qpteAccountStatus_InvoiceName);
if (qpinInvoice_InvoiceStatusId != 0) {
whereBuilder.Append("((");
whereBuilder.Append((ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("pWUau3x8lku6cvimchlK7g"))).ssId);
whereBuilder.Append(" = @qpinInvoice_InvoiceStatusId) AND (");
whereBuilder.Append((ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("pWUau3x8lku6cvimchlK7g"))).ssId);
whereBuilder.Append(" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoice_InvoiceStatusId", DbType.Int32, qpinInvoice_InvoiceStatusId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpinInvoice_InvoiceStatusId", DbType.Int32, qpinInvoice_InvoiceStatusId);
} else {
whereBuilder.Append("(");
whereBuilder.Append((ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("pWUau3x8lku6cvimchlK7g"))).ssId);
whereBuilder.Append(" IS NULL)");
}
whereBuilder.Append(" THEN (CASE WHEN (@qpdaAccountStatus_DateFrom <> (date '1900-01-01')) THEN (CASE WHEN ((cast(\"eninvoice132\".\"paymentdatetime\" as date)::timestamptz) >= @qpdaAccountStatus_DateFrom) THEN 1 ELSE 0 END) ELSE 1 END) ELSE 1 END) = 1) AND ((CASE WHEN ");
sqlCmd.CreateParameterWithoutReplacements("@qpdaAccountStatus_DateFrom", DbType.DateTime, qpdaAccountStatus_DateFrom);
sqlCountCmd.CreateParameterWithoutReplacements("@qpdaAccountStatus_DateFrom", DbType.DateTime, qpdaAccountStatus_DateFrom);
if (qpinInvoice_InvoiceStatusId != 0) {
whereBuilder.Append("((");
whereBuilder.Append((ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("pWUau3x8lku6cvimchlK7g"))).ssId);
whereBuilder.Append(" = @qpinInvoice_InvoiceStatusId) AND (");
whereBuilder.Append((ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("pWUau3x8lku6cvimchlK7g"))).ssId);
whereBuilder.Append(" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoice_InvoiceStatusId", DbType.Int32, qpinInvoice_InvoiceStatusId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpinInvoice_InvoiceStatusId", DbType.Int32, qpinInvoice_InvoiceStatusId);
} else {
whereBuilder.Append("(");
whereBuilder.Append((ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("pWUau3x8lku6cvimchlK7g"))).ssId);
whereBuilder.Append(" IS NULL)");
}
whereBuilder.Append(" THEN (CASE WHEN (@qpdaAccountStatus_DateTo <> (date '1900-01-01')) THEN (CASE WHEN ((cast(\"eninvoice132\".\"paymentdatetime\" as date)::timestamptz) <= @qpdaAccountStatus_DateTo) THEN 1 ELSE 0 END) ELSE 1 END) ELSE 1 END) = 1)");
orderByBuilder.Append(" ORDER BY ");
List<string> orderByColumns = new List<string>();
orderByColumns.AddRange(BaseAppUtils.ReplaceEntityReferencesAndAttributesInOrderBy(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, qpteTableSort, new string[] { "RequisitionAccounting", "Invoice", "Requisition", "PaymentTerms", "InvoiceStatus" }, new string[] { "ENRequisitionAccounting6", "ENInvoice132", "ENRequisition106", "ENPaymentTerms27", "ENInvoiceStatus14" }, new System.Collections.Generic.Dictionary<string, string>[] { ENRequisitionAccountingEntity.AttributesToDatabaseNamesMap(), ENInvoiceEntity.AttributesToDatabaseNamesMap(), ENRequisitionEntity.AttributesToDatabaseNamesMap(), ENPaymentTermsEntity.AttributesToDatabaseNamesMap(), ENInvoiceStatusEntity.AttributesToDatabaseNamesMap() }).Split(','));
orderByColumns.Add("\"eninvoice132\".\"id\" ASC ");
orderByBuilder.Append(BaseAppUtils.GetOrderByColumnsWithoutDuplicates(orderByColumns));
sqlCmd.CreateParameterWithoutReplacements("@qpdaAccountStatus_DateTo", DbType.DateTime, qpdaAccountStatus_DateTo);
sqlCountCmd.CreateParameterWithoutReplacements("@qpdaAccountStatus_DateTo", DbType.DateTime, qpdaAccountStatus_DateTo);
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
if (startIndex > 0) {
orderByBuilder.Append(" OFFSET ");
orderByBuilder.Append(startIndex);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCount = "SELECT COUNT(1) " + fromBuilder.ToString() + whereBuilder.ToString() + groupByBuilder.ToString() + havingBuilder.ToString();
sqlCount = AppUtils.Instance.ReplaceEntityReferences(requestContext, sqlCount);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
sqlCountCmd.CommandText = sqlCount;
try {
RL_a0d7b43e9ac13e97d2ade731b2b4eb81 outParamList = new RL_a0d7b43e9ac13e97d2ade731b2b4eb81();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoiceApprovalLevelsReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[5];
opt[0] = new BitArray(new bool[] {true, false, true, true, true, true, false, true, true, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, false, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query c_Proveedor.RegionSpecificDetail.GetInvoiceApprovalLevels.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Proveedor.RegionSpecificDetail.GetInvoiceApprovalLevels.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_a0d7b43e9ac13e97d2ade731b2b4eb81 _tmp = new RL_a0d7b43e9ac13e97d2ade731b2b4eb81();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoiceApprovalLevelsReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Proveedor.RegionSpecificDetail.GetInvoiceApprovalLevels.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_a0d7b43e9ac13e97d2ade731b2b4eb81)_tmp;
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query c_Proveedor.RegionSpecificDetail.GetInvoiceApprovalLevels.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
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
