namespace ssConectaProveedores;

public partial class Actions {
public class lcvUploadInvoiceFiles_0AddData : VarsBag {
public long inParamRequisitionId;
public long inParamFolioId;
public long inParamOrderMainId;
public RL_25486e09ba20acde3d8ef9d3e8a6e625 queryResGetRequisitionContractFilesByRequisitionId_outParamList = new RL_25486e09ba20acde3d8ef9d3e8a6e625();
public long queryResGetRequisitionContractFilesByRequisitionId_outParamCount = 0L;

public RL_1d7ef2a250417492ea51e18cdf076639 queryResGetRequisitionById_outParamList = new RL_1d7ef2a250417492ea51e18cdf076639();
public long queryResGetRequisitionById_outParamCount = 0L;

public RL_a84836cbe605db9f376d25b795a14e12 queryResGetOrderMainItemsByOrderMainId_outParamList = new RL_a84836cbe605db9f376d25b795a14e12();
public long queryResGetOrderMainItemsByOrderMainId_outParamCount = 0L;

public RL_ac28f3fb72f03b677713af175e2c8613 queryResGetRequisitionServicesByRequisitionId_outParamList = new RL_ac28f3fb72f03b677713af175e2c8613();
public long queryResGetRequisitionServicesByRequisitionId_outParamCount = 0L;

public RL_5a56ddde595e36ca6dc14e1cbb3984cb queryResGetFolioById_outParamList = new RL_5a56ddde595e36ca6dc14e1cbb3984cb();
public long queryResGetFolioById_outParamCount = 0L;

public RL_9399cd7e3fe138caf31a0e1fae937d4b queryResGetOrderById_outParamList = new RL_9399cd7e3fe138caf31a0e1fae937d4b();
public long queryResGetOrderById_outParamCount = 0L;

public RL_a84836cbe605db9f376d25b795a14e12 queryResGetOrderMainItemsByOrderMainId2_outParamList = new RL_a84836cbe605db9f376d25b795a14e12();
public long queryResGetOrderMainItemsByOrderMainId2_outParamCount = 0L;

public lcvUploadInvoiceFiles_0AddData(long inParamRequisitionId, long inParamFolioId, long inParamOrderMainId) {
this.inParamRequisitionId = inParamRequisitionId;
this.inParamFolioId = inParamFolioId;
this.inParamOrderMainId = inParamOrderMainId;
}
}
public class lcoUploadInvoiceFiles_0AddData : VarsBag {
public ST_452088c4ad7c6718df20290248661783Structure outParamUploadValidationData = new ST_452088c4ad7c6718df20290248661783Structure();

public lcoUploadInvoiceFiles_0AddData() {
}
}
/// <summary>
/// Action <code>UploadInvoiceFiles_0AddData</code> that represents the Service Studio action
///  <code>UploadInvoiceFiles_0AddData</code> <p> Description: </p>
/// </summary>
public static async Task<ST_452088c4ad7c6718df20290248661783Structure> ActionUploadInvoiceFiles_0AddData(IRequestContext requestContext,long inParamRequisitionId,long inParamFolioId,long inParamOrderMainId,CancellationToken cancellationToken) {
ST_452088c4ad7c6718df20290248661783Structure outParamUploadValidationData = default;
lcoUploadInvoiceFiles_0AddData result = new lcoUploadInvoiceFiles_0AddData();
lcvUploadInvoiceFiles_0AddData localVars = new lcvUploadInvoiceFiles_0AddData(inParamRequisitionId, inParamFolioId, inParamOrderMainId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("UploadInvoiceFiles_0AddData", "be9395a4-335f-43b1-a741-dc92ea2f12ce"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("UploadInvoiceFiles_0AddData", "be9395a4-335f-43b1-a741-dc92ea2f12ce", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
if(((localVars.inParamRequisitionId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// Query datasetGetRequisitionById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionById_maxRecords = 0;
int datasetGetRequisitionById_startIndex = 0;(localVars.queryResGetRequisitionById_outParamList,localVars.queryResGetRequisitionById_outParamCount) = await FuncActionUploadInvoiceFiles_0AddData.datasetGetRequisitionById(requestContext,datasetGetRequisitionById_maxRecords,datasetGetRequisitionById_startIndex,IterationMultiplicity.Never,localVars.inParamRequisitionId,cancellationToken);

// Query datasetGetRequisitionServicesByRequisitionId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionServicesByRequisitionId_maxRecords = 0;
int datasetGetRequisitionServicesByRequisitionId_startIndex = 0;(localVars.queryResGetRequisitionServicesByRequisitionId_outParamList,localVars.queryResGetRequisitionServicesByRequisitionId_outParamCount) = await FuncActionUploadInvoiceFiles_0AddData.datasetGetRequisitionServicesByRequisitionId(requestContext,datasetGetRequisitionServicesByRequisitionId_maxRecords,datasetGetRequisitionServicesByRequisitionId_startIndex,IterationMultiplicity.Single,localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssWasAdvWithoutInvoice,localVars.inParamRequisitionId,cancellationToken);

// Query datasetGetRequisitionContractFilesByRequisitionId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionContractFilesByRequisitionId_maxRecords = 1;
if (datasetGetRequisitionContractFilesByRequisitionId_maxRecords < 1) datasetGetRequisitionContractFilesByRequisitionId_maxRecords = 1;
int datasetGetRequisitionContractFilesByRequisitionId_startIndex = 0;(localVars.queryResGetRequisitionContractFilesByRequisitionId_outParamList,localVars.queryResGetRequisitionContractFilesByRequisitionId_outParamCount) = await FuncActionUploadInvoiceFiles_0AddData.datasetGetRequisitionContractFilesByRequisitionId(requestContext,datasetGetRequisitionContractFilesByRequisitionId_maxRecords,datasetGetRequisitionContractFilesByRequisitionId_startIndex,IterationMultiplicity.Never,localVars.inParamRequisitionId,cancellationToken);

// UploadValidationData.CostCenterId = GetRequisitionById.List.Current.Requisition.CostCenterId
result.outParamUploadValidationData.ssCostCenterId = localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssCostCenterId;

// UploadValidationData.Currency = GetRequisitionById.List.Current.Requisition.CurrencyId
result.outParamUploadValidationData.ssCurrency = localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssCurrencyId;

// UploadValidationData.Project = GetRequisitionById.List.Current.Requisition.ProjectDescription
result.outParamUploadValidationData.ssProject = localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssProjectDescription;

// UploadValidationData.PaymentMethodId = GetRequisitionById.List.Current.Requisition.PaymentMethodId
result.outParamUploadValidationData.ssPaymentMethodId = localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssPaymentMethodId;

// UploadValidationData.PaymentTermsId = GetRequisitionById.List.Current.Requisition.PaymentTermsId
result.outParamUploadValidationData.ssPaymentTermsId = localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssPaymentTermsId;

// UploadValidationData.RegionFI = GetRequisitionById.List.Current.Region.DivisionFI
result.outParamUploadValidationData.ssRegionFI = localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRegion.ssDivisionFI;

// UploadValidationData.TotalAmount = If
result.outParamUploadValidationData.ssTotalAmount = BuiltInFunction.DecimalToText(((localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssWasAdvWithoutInvoice) ? (localVars.queryResGetRequisitionContractFilesByRequisitionId_outParamList.CurrentRec.ssENRequisitionContractFile.ssAmount) : (localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssTotalAmount)));

// UploadValidationData.SupplierIsForeigner = GetRequisitionById.List.Current.Supplier.Pais <> "MX"
result.outParamUploadValidationData.ssSupplierIsForeigner = (localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENSupplier.ssPais!="MX");

// UploadValidationData.SupplierLugarExpedicion = GetRequisitionById.List.Current.Supplier.Codigopostal_Pobl_
result.outParamUploadValidationData.ssSupplierLugarExpedicion = localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENSupplier.ssCodigopostal_Pobl_;

// UploadValidationData.SupplierNr = GetRequisitionById.List.Current.Supplier.Number
result.outParamUploadValidationData.ssSupplierNr = localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENSupplier.ssNumber;

// UploadValidationData.SupplierRFC = GetRequisitionById.List.Current.Supplier.N_ident_fis_1
result.outParamUploadValidationData.ssSupplierRFC = localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENSupplier.ssN_ident_fis_1;

// UploadValidationData.SupplierSociety = GetRequisitionById.List.Current.Company.ExternalId
result.outParamUploadValidationData.ssSupplierSociety = localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENCompany.ssExternalId;

// UploadValidationData.InvoiceUsageKeyList = GetRequisitionServicesByRequisitionId.List
result.outParamUploadValidationData.ssInvoiceUsageKeyList = (await BasicTypeList<string>.ConvertAsync(localVars.queryResGetRequisitionServicesByRequisitionId_outParamList, new BasicTypeList<string>(), async (RC_6dd7b29a235be8701ea943f35694df35 source, string target, CancellationToken cancellationToken) => {
target = source.ssENInvoiceUsage.ssKey;
return target;
}, cancellationToken));

// UploadValidationData.IsAnticipoWithoutInv = GetRequisitionById.List.Current.Requisition.WasAdvWithoutInvoice
result.outParamUploadValidationData.ssIsAnticipoWithoutInv = localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssWasAdvWithoutInvoice;

// UploadValidationData.IsAnticipoWithInv = GetRequisitionById.List.Current.Requisition.IsAdvanced and notGetRequisitionById.List.Current.Requisition.WasAdvWithoutInvoice
result.outParamUploadValidationData.ssIsAnticipoWithInv = (localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssIsAdvanced&&(!localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssWasAdvWithoutInvoice));
} else {
if((localVars.inParamOrderMainId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ()))) {
// Query datasetGetOrderById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderById_maxRecords = 0;
int datasetGetOrderById_startIndex = 0;(localVars.queryResGetOrderById_outParamList,localVars.queryResGetOrderById_outParamCount) = await FuncActionUploadInvoiceFiles_0AddData.datasetGetOrderById(requestContext,datasetGetOrderById_maxRecords,datasetGetOrderById_startIndex,IterationMultiplicity.Never,localVars.inParamOrderMainId,cancellationToken);

// Query datasetGetOrderMainItemsByOrderMainId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderMainItemsByOrderMainId_maxRecords = 0;
int datasetGetOrderMainItemsByOrderMainId_startIndex = 0;(localVars.queryResGetOrderMainItemsByOrderMainId_outParamList,localVars.queryResGetOrderMainItemsByOrderMainId_outParamCount) = await FuncActionUploadInvoiceFiles_0AddData.datasetGetOrderMainItemsByOrderMainId(requestContext,datasetGetOrderMainItemsByOrderMainId_maxRecords,datasetGetOrderMainItemsByOrderMainId_startIndex,IterationMultiplicity.Single,localVars.inParamOrderMainId,cancellationToken);

// UploadValidationData.CostCenterId = NullIdentifier
result.outParamUploadValidationData.ssCostCenterId = Convert.ToInt64(BuiltInFunction.NullIdentifier ());

// UploadValidationData.Currency = GetOrderById.List.Current.OrderMain.CurrencyId
result.outParamUploadValidationData.ssCurrency = localVars.queryResGetOrderById_outParamList.CurrentRec.ssENOrderMain.ssCurrencyId;

// UploadValidationData.Project = GetOrderById.List.Current.OrderDetail.ProjectDescription
result.outParamUploadValidationData.ssProject = localVars.queryResGetOrderById_outParamList.CurrentRec.ssENOrderDetail.ssProjectDescription;

// UploadValidationData.PaymentMethodId = GetOrderById.List.Current.OrderDetail.PaymentMethodId
result.outParamUploadValidationData.ssPaymentMethodId = localVars.queryResGetOrderById_outParamList.CurrentRec.ssENOrderDetail.ssPaymentMethodId;

// UploadValidationData.PaymentTermsId = GetOrderById.List.Current.OrderDetail.PaymentTermsId
result.outParamUploadValidationData.ssPaymentTermsId = localVars.queryResGetOrderById_outParamList.CurrentRec.ssENOrderDetail.ssPaymentTermsId;

// UploadValidationData.RegionFI = GetOrderById.List.Current.Region.DivisionFI
result.outParamUploadValidationData.ssRegionFI = localVars.queryResGetOrderById_outParamList.CurrentRec.ssENRegion.ssDivisionFI;

// UploadValidationData.TotalAmount = FormatDecimal
result.outParamUploadValidationData.ssTotalAmount = BuiltInFunction.FormatDecimal (localVars.queryResGetOrderById_outParamList.CurrentRec.ssENOrderMain.ssTotalAmount, 2, ".", "");

// UploadValidationData.SupplierIsForeigner = GetOrderById.List.Current.Supplier.Pais <> "MX"
result.outParamUploadValidationData.ssSupplierIsForeigner = (localVars.queryResGetOrderById_outParamList.CurrentRec.ssENSupplier.ssPais!="MX");

// UploadValidationData.SupplierLugarExpedicion = GetOrderById.List.Current.Supplier.Codigopostal_Pobl_
result.outParamUploadValidationData.ssSupplierLugarExpedicion = localVars.queryResGetOrderById_outParamList.CurrentRec.ssENSupplier.ssCodigopostal_Pobl_;

// UploadValidationData.SupplierNr = GetOrderById.List.Current.Supplier.Number
result.outParamUploadValidationData.ssSupplierNr = localVars.queryResGetOrderById_outParamList.CurrentRec.ssENSupplier.ssNumber;

// UploadValidationData.SupplierRFC = GetOrderById.List.Current.Supplier.N_ident_fis_1
result.outParamUploadValidationData.ssSupplierRFC = localVars.queryResGetOrderById_outParamList.CurrentRec.ssENSupplier.ssN_ident_fis_1;

// UploadValidationData.SupplierSociety = GetOrderById.List.Current.Company.ExternalId
result.outParamUploadValidationData.ssSupplierSociety = localVars.queryResGetOrderById_outParamList.CurrentRec.ssENCompany.ssExternalId;

// UploadValidationData.InvoiceUsageKeyList = GetOrderMainItemsByOrderMainId.List
result.outParamUploadValidationData.ssInvoiceUsageKeyList = (await BasicTypeList<string>.ConvertAsync(localVars.queryResGetOrderMainItemsByOrderMainId_outParamList, new BasicTypeList<string>(), async (RC_d2afc71b0d41323d7c4b380eedf435e1 source, string target, CancellationToken cancellationToken) => {
target = source.ssENInvoiceUsage.ssKey;
return target;
}, cancellationToken));

// UploadValidationData.IsAnticipoWithoutInv = False
result.outParamUploadValidationData.ssIsAnticipoWithoutInv = false;
} else {
if((localVars.inParamFolioId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ()))) {
// Query datasetGetFolioById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioById_maxRecords = 0;
int datasetGetFolioById_startIndex = 0;(localVars.queryResGetFolioById_outParamList,localVars.queryResGetFolioById_outParamCount) = await FuncActionUploadInvoiceFiles_0AddData.datasetGetFolioById(requestContext,datasetGetFolioById_maxRecords,datasetGetFolioById_startIndex,IterationMultiplicity.Never,localVars.inParamFolioId,cancellationToken);

// Query datasetGetOrderMainItemsByOrderMainId2
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderMainItemsByOrderMainId2_maxRecords = 0;
int datasetGetOrderMainItemsByOrderMainId2_startIndex = 0;(localVars.queryResGetOrderMainItemsByOrderMainId2_outParamList,localVars.queryResGetOrderMainItemsByOrderMainId2_outParamCount) = await FuncActionUploadInvoiceFiles_0AddData.datasetGetOrderMainItemsByOrderMainId2(requestContext,datasetGetOrderMainItemsByOrderMainId2_maxRecords,datasetGetOrderMainItemsByOrderMainId2_startIndex,IterationMultiplicity.Single,localVars.queryResGetFolioById_outParamList.CurrentRec.ssENOrderMain.ssId,cancellationToken);

// UploadValidationData.CostCenterId = NullIdentifier
result.outParamUploadValidationData.ssCostCenterId = Convert.ToInt64(BuiltInFunction.NullIdentifier ());

// UploadValidationData.Currency = GetFolioById.List.Current.OrderMain.CurrencyId
result.outParamUploadValidationData.ssCurrency = localVars.queryResGetFolioById_outParamList.CurrentRec.ssENOrderMain.ssCurrencyId;

// UploadValidationData.Project = GetFolioById.List.Current.OrderDetail.ProjectDescription
result.outParamUploadValidationData.ssProject = localVars.queryResGetFolioById_outParamList.CurrentRec.ssENOrderDetail.ssProjectDescription;

// UploadValidationData.PaymentMethodId = GetFolioById.List.Current.OrderDetail.PaymentMethodId
result.outParamUploadValidationData.ssPaymentMethodId = localVars.queryResGetFolioById_outParamList.CurrentRec.ssENOrderDetail.ssPaymentMethodId;

// UploadValidationData.PaymentTermsId = GetFolioById.List.Current.OrderDetail.PaymentTermsId
result.outParamUploadValidationData.ssPaymentTermsId = localVars.queryResGetFolioById_outParamList.CurrentRec.ssENOrderDetail.ssPaymentTermsId;

// UploadValidationData.RegionFI = GetFolioById.List.Current.Region.DivisionFI
result.outParamUploadValidationData.ssRegionFI = localVars.queryResGetFolioById_outParamList.CurrentRec.ssENRegion.ssDivisionFI;

// UploadValidationData.TotalAmount = FormatDecimal
result.outParamUploadValidationData.ssTotalAmount = BuiltInFunction.FormatDecimal (localVars.queryResGetFolioById_outParamList.CurrentRec.ssENOrderMain.ssTotalAmount, 2, ".", "");

// UploadValidationData.SupplierIsForeigner = GetFolioById.List.Current.Supplier.Pais <> "MX"
result.outParamUploadValidationData.ssSupplierIsForeigner = (localVars.queryResGetFolioById_outParamList.CurrentRec.ssENSupplier.ssPais!="MX");

// UploadValidationData.SupplierLugarExpedicion = GetFolioById.List.Current.Supplier.Codigopostal_Pobl_
result.outParamUploadValidationData.ssSupplierLugarExpedicion = localVars.queryResGetFolioById_outParamList.CurrentRec.ssENSupplier.ssCodigopostal_Pobl_;

// UploadValidationData.SupplierNr = GetFolioById.List.Current.Supplier.Number
result.outParamUploadValidationData.ssSupplierNr = localVars.queryResGetFolioById_outParamList.CurrentRec.ssENSupplier.ssNumber;

// UploadValidationData.SupplierRFC = GetFolioById.List.Current.Supplier.N_ident_fis_1
result.outParamUploadValidationData.ssSupplierRFC = localVars.queryResGetFolioById_outParamList.CurrentRec.ssENSupplier.ssN_ident_fis_1;

// UploadValidationData.SupplierSociety = GetFolioById.List.Current.Company.ExternalId
result.outParamUploadValidationData.ssSupplierSociety = localVars.queryResGetFolioById_outParamList.CurrentRec.ssENCompany.ssExternalId;

// UploadValidationData.InvoiceUsageKeyList = GetOrderMainItemsByOrderMainId2.List
result.outParamUploadValidationData.ssInvoiceUsageKeyList = (await BasicTypeList<string>.ConvertAsync(localVars.queryResGetOrderMainItemsByOrderMainId2_outParamList, new BasicTypeList<string>(), async (RC_d2afc71b0d41323d7c4b380eedf435e1 source, string target, CancellationToken cancellationToken) => {
target = source.ssENInvoiceUsage.ssKey;
return target;
}, cancellationToken));

// UploadValidationData.IsAnticipoWithoutInv = False
result.outParamUploadValidationData.ssIsAnticipoWithoutInv = false;
} else {
goto RETURN_STATEMENT;

}

}

}

// force foreigner
if((((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveForceForeignerSupplier]))))) {
// set foreigner
// UploadValidationData.SupplierIsForeigner = True
result.outParamUploadValidationData.ssSupplierIsForeigner = true;
}

} //close CreateActionActivity using block
} // try

finally {
outParamUploadValidationData = result.outParamUploadValidationData;
} // inner-finally
RETURN_STATEMENT:
return outParamUploadValidationData;
}

public static class FuncActionUploadInvoiceFiles_0AddData {

// Query Function "GetRequisitionContractFilesByRequisitionId" vpGKQ_RoaEWugpgOMwwK8g of Action "UploadInvoiceFiles_0AddData"
public static async Task<(RL_25486e09ba20acde3d8ef9d3e8a6e625,long)> datasetGetRequisitionContractFilesByRequisitionId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisitionId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("UploadInvoiceFiles_0AddData.GetRequisitionContractFilesByRequisitionId", "438a91be-68f4-4568-ae82-980e330c0af2");
using var queryActivity = activitySource.CreateAggregateQueryActivity("UploadInvoiceFiles_0AddData.GetRequisitionContractFilesByRequisitionId", "438a91be-68f4-4568-ae82-980e330c0af2", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.pJWTvl8zsUOnQdyS6i8Szg/NodesNotShownInESpaceTree.vpGKQ_RoaEWugpgOMwwK8g, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, trim_scale(\"enrequisitioncontractfile8\".\"amount\"::numeric) o4, NULL o5, NULL o6, NULL o7, NULL o8");
fromBuilder.Append(" FROM {RequisitionContractFile} \"enrequisitioncontractfile8\"");
whereBuilder.Append(" WHERE ");
if (qpreRequisitionId != 0) {
whereBuilder.Append("((\"enrequisitioncontractfile8\".\"requisitionid\" = @qpreRequisitionId) AND (\"enrequisitioncontractfile8\".\"requisitionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisitionId", DbType.Int64, qpreRequisitionId);
} else {
whereBuilder.Append("(\"enrequisitioncontractfile8\".\"requisitionid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enrequisitioncontractfile8\".\"contractfiletypeid\" = ");
whereBuilder.Append((ENContractFileTypeEntity.GetRecordByKey(ObjectKey.Parse("O7ktjb0qHUO1JVHd3pyUOA"))).ssId);
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
RL_25486e09ba20acde3d8ef9d3e8a6e625 outParamList = new RL_25486e09ba20acde3d8ef9d3e8a6e625();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, true, false, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query UploadInvoiceFiles_0AddData.GetRequisitionContractFilesByRequisitionId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_25486e09ba20acde3d8ef9d3e8a6e625 _tmp = new RL_25486e09ba20acde3d8ef9d3e8a6e625();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query UploadInvoiceFiles_0AddData.GetRequisitionContractFilesByRequisitionId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_25486e09ba20acde3d8ef9d3e8a6e625)_tmp;
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

private static async Task<RC_b9271cf96626bd0e3a973b83f0436fc1> datasetGetRequisitionByIdReadDbAsync(RC_b9271cf96626bd0e3a973b83f0436fc1 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENCompany.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetRequisitionById" TBPKVN1AVEWWYZtZfRs9Rg of Action "UploadInvoiceFiles_0AddData"
public static async Task<(RL_1d7ef2a250417492ea51e18cdf076639,long)> datasetGetRequisitionById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisition_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("UploadInvoiceFiles_0AddData.GetRequisitionById", "54ca134c-40dd-4554-9661-9b597d1b3d46");
using var queryActivity = activitySource.CreateAggregateQueryActivity("UploadInvoiceFiles_0AddData.GetRequisitionById", "54ca134c-40dd-4554-9661-9b597d1b3d46", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.pJWTvl8zsUOnQdyS6i8Szg/NodesNotShownInESpaceTree.TBPKVN1AVEWWYZtZfRs9Rg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"encompany9\".\"externalid\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, \"enregion48\".\"divisionfi\" o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, \"enrequisition54\".\"projectdescription\" o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, trim_scale(\"enrequisition54\".\"totalamount\"::numeric) o41, \"enrequisition54\".\"currencyid\" o42, NULL o43, \"enrequisition54\".\"costcenterid\" o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, \"enrequisition54\".\"paymentmethodid\" o57, \"enrequisition54\".\"paymenttermsid\" o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, \"enrequisition54\".\"wasadvwithoutinvoice\" o71, \"enrequisition54\".\"isadvanced\" o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, \"ensupplier37\".\"number\" o85, NULL o86, NULL o87, NULL o88, \"ensupplier37\".\"codigopostal_pobl_\" o89, \"ensupplier37\".\"pais\" o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, \"ensupplier37\".\"n_ident_fis_1\" o99, NULL o100, NULL o101, NULL o102, NULL o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, NULL o109");
fromBuilder.Append(" FROM ((({Requisition} \"enrequisition54\" Left JOIN {Region} \"enregion48\" ON (\"enrequisition54\".\"regionid\" = \"enregion48\".\"id\"))  Left JOIN {Supplier} \"ensupplier37\" ON (\"enrequisition54\".\"supplierid\" = \"ensupplier37\".\"id\"))  Left JOIN {Company} \"encompany9\" ON (\"enrequisition54\".\"companyid\" = \"encompany9\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpreRequisition_Id != 0) {
whereBuilder.Append("((\"enrequisition54\".\"id\" = @qpreRequisition_Id) AND (\"enrequisition54\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisition_Id", DbType.Int64, qpreRequisition_Id);
} else {
whereBuilder.Append("(\"enrequisition54\".\"id\" IS NULL)");
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
RL_1d7ef2a250417492ea51e18cdf076639 outParamList = new RL_1d7ef2a250417492ea51e18cdf076639();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetRequisitionByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[4];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, false, false, true, false, true, true, true, true, true, true, true, true, true, true, true, true, false, false, true, true, true, true, true, true, true, true, true, true, true, true, false, false, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, false, true, true, true, false, false, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query UploadInvoiceFiles_0AddData.GetRequisitionById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_1d7ef2a250417492ea51e18cdf076639 _tmp = new RL_1d7ef2a250417492ea51e18cdf076639();
_tmp.AlternateReadDbMethodAsync = datasetGetRequisitionByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query UploadInvoiceFiles_0AddData.GetRequisitionById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_1d7ef2a250417492ea51e18cdf076639)_tmp;
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

private static async Task<RC_d2afc71b0d41323d7c4b380eedf435e1> datasetGetOrderMainItemsByOrderMainIdReadDbAsync(RC_d2afc71b0d41323d7c4b380eedf435e1 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoiceUsage.Read( r, ref index);
rec.ssENOrderMainItem.Read( r, ref index);
return rec;
}
// Query Function "GetOrderMainItemsByOrderMainId" jJEEWlxqFU2m_k4kOZb9GQ of Action "UploadInvoiceFiles_0AddData"
public static async Task<(RL_a84836cbe605db9f376d25b795a14e12,long)> datasetGetOrderMainItemsByOrderMainId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderMainItem_OrderMainId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("UploadInvoiceFiles_0AddData.GetOrderMainItemsByOrderMainId", "5a04918c-6a5c-4d15-a6fe-4e243996fd19");
using var queryActivity = activitySource.CreateAggregateQueryActivity("UploadInvoiceFiles_0AddData.GetOrderMainItemsByOrderMainId", "5a04918c-6a5c-4d15-a6fe-4e243996fd19", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Single
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
selectBuilder.Append("/* /UserActions.pJWTvl8zsUOnQdyS6i8Szg/NodesNotShownInESpaceTree.jJEEWlxqFU2m_k4kOZb9GQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"eninvoiceusage\".\"key\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60");
fromBuilder.Append(" FROM ({OrderMainItem} \"enordermainitem11\" Left JOIN {InvoiceUsage} \"eninvoiceusage\" ON (\"enordermainitem11\".\"invoiceusageid\" = \"eninvoiceusage\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderMainItem_OrderMainId != 0) {
whereBuilder.Append("((\"enordermainitem11\".\"ordermainid\" = @qporOrderMainItem_OrderMainId) AND (\"enordermainitem11\".\"ordermainid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderMainItem_OrderMainId", DbType.Int64, qporOrderMainItem_OrderMainId);
} else {
whereBuilder.Append("(\"enordermainitem11\".\"ordermainid\" IS NULL)");
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
RL_a84836cbe605db9f376d25b795a14e12 outParamList = new RL_a84836cbe605db9f376d25b795a14e12();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderMainItemsByOrderMainIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query UploadInvoiceFiles_0AddData.GetOrderMainItemsByOrderMainId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_a84836cbe605db9f376d25b795a14e12 _tmp = new RL_a84836cbe605db9f376d25b795a14e12();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderMainItemsByOrderMainIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query UploadInvoiceFiles_0AddData.GetOrderMainItemsByOrderMainId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_a84836cbe605db9f376d25b795a14e12)_tmp;
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

private static async Task<RC_6dd7b29a235be8701ea943f35694df35> datasetGetRequisitionServicesByRequisitionIdReadDbAsync(RC_6dd7b29a235be8701ea943f35694df35 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoiceUsage.Read( r, ref index);
rec.ssENRequisitionService.Read( r, ref index);
return rec;
}
// Query Function "GetRequisitionServicesByRequisitionId" ++CFX2W5jkmBHtxFT4hupQ of Action "UploadInvoiceFiles_0AddData"
public static async Task<(RL_ac28f3fb72f03b677713af175e2c8613,long)> datasetGetRequisitionServicesByRequisitionId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboWasAdvWithoutInvoice,long qpreRequisitionService_RequisitionId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("UploadInvoiceFiles_0AddData.GetRequisitionServicesByRequisitionId", "5f85e0fb-b965-498e-811e-dc454f886ea5");
using var queryActivity = activitySource.CreateAggregateQueryActivity("UploadInvoiceFiles_0AddData.GetRequisitionServicesByRequisitionId", "5f85e0fb-b965-498e-811e-dc454f886ea5", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Single
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
selectBuilder.Append("/* /UserActions.pJWTvl8zsUOnQdyS6i8Szg/NodesNotShownInESpaceTree.++CFX2W5jkmBHtxFT4hupQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"eninvoiceusage1\".\"key\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16");
fromBuilder.Append(" FROM ({RequisitionService} \"enrequisitionservice1\" Inner JOIN {InvoiceUsage} \"eninvoiceusage1\" ON (\"enrequisitionservice1\".\"invoiceusageid\" = \"eninvoiceusage1\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpreRequisitionService_RequisitionId != 0) {
whereBuilder.Append("((\"enrequisitionservice1\".\"requisitionid\" = @qpreRequisitionService_RequisitionId) AND (\"enrequisitionservice1\".\"requisitionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisitionService_RequisitionId", DbType.Int64, qpreRequisitionService_RequisitionId);
} else {
whereBuilder.Append("(\"enrequisitionservice1\".\"requisitionid\" IS NULL)");
}
whereBuilder.Append(" AND (NOT (@qpboWasAdvWithoutInvoice = 1))");
sqlCmd.CreateParameterWithoutReplacements("@qpboWasAdvWithoutInvoice", DbType.Boolean, qpboWasAdvWithoutInvoice);
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
RL_ac28f3fb72f03b677713af175e2c8613 outParamList = new RL_ac28f3fb72f03b677713af175e2c8613();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetRequisitionServicesByRequisitionIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query UploadInvoiceFiles_0AddData.GetRequisitionServicesByRequisitionId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_ac28f3fb72f03b677713af175e2c8613 _tmp = new RL_ac28f3fb72f03b677713af175e2c8613();
_tmp.AlternateReadDbMethodAsync = datasetGetRequisitionServicesByRequisitionIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query UploadInvoiceFiles_0AddData.GetRequisitionServicesByRequisitionId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_ac28f3fb72f03b677713af175e2c8613)_tmp;
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

private static async Task<RC_77723e71a17f336e440e3f9265cbd409> datasetGetFolioByIdReadDbAsync(RC_77723e71a17f336e440e3f9265cbd409 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENCompany.Read( r, ref index);
rec.ssENFolio.Read( r, ref index);
rec.ssENOrderDetail.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetFolioById" DtS9mGoKBEStj4bXZChO8g of Action "UploadInvoiceFiles_0AddData"
public static async Task<(RL_5a56ddde595e36ca6dc14e1cbb3984cb,long)> datasetGetFolioById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolio_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("UploadInvoiceFiles_0AddData.GetFolioById", "98bdd40e-0a6a-4404-ad8f-86d764284ef2");
using var queryActivity = activitySource.CreateAggregateQueryActivity("UploadInvoiceFiles_0AddData.GetFolioById", "98bdd40e-0a6a-4404-ad8f-86d764284ef2", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.pJWTvl8zsUOnQdyS6i8Szg/NodesNotShownInESpaceTree.DtS9mGoKBEStj4bXZChO8g, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"encompany10\".\"externalid\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, \"enorderdetail5\".\"projectdescription\" o35, NULL o36, NULL o37, \"enorderdetail5\".\"paymenttermsid\" o38, \"enorderdetail5\".\"paymentmethodid\" o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, \"enordermain49\".\"id\" o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, \"enordermain49\".\"currencyid\" o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, trim_scale(\"enordermain49\".\"totalamount\"::numeric) o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, \"enregion49\".\"divisionfi\" o102, NULL o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, \"ensupplier38\".\"number\" o115, NULL o116, NULL o117, NULL o118, \"ensupplier38\".\"codigopostal_pobl_\" o119, \"ensupplier38\".\"pais\" o120, NULL o121, NULL o122, NULL o123, NULL o124, NULL o125, NULL o126, NULL o127, NULL o128, \"ensupplier38\".\"n_ident_fis_1\" o129, NULL o130, NULL o131, NULL o132, NULL o133, NULL o134, NULL o135, NULL o136, NULL o137, NULL o138, NULL o139");
fromBuilder.Append(" FROM ((((({Folio} \"enfolio47\" Left JOIN {OrderMain} \"enordermain49\" ON (\"enfolio47\".\"orderid\" = \"enordermain49\".\"id\"))  Left JOIN {Region} \"enregion49\" ON (\"enordermain49\".\"regionid\" = \"enregion49\".\"id\"))  Left JOIN {Supplier} \"ensupplier38\" ON (\"enfolio47\".\"supplierid\" = \"ensupplier38\".\"id\"))  Left JOIN {OrderDetail} \"enorderdetail5\" ON (\"enordermain49\".\"id\" = \"enorderdetail5\".\"orderid\"))  Left JOIN {Company} \"encompany10\" ON (\"enfolio47\".\"companyid\" = \"encompany10\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoFolio_Id != 0) {
whereBuilder.Append("((\"enfolio47\".\"id\" = @qpfoFolio_Id) AND (\"enfolio47\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolio_Id", DbType.Int64, qpfoFolio_Id);
} else {
whereBuilder.Append("(\"enfolio47\".\"id\" IS NULL)");
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
RL_5a56ddde595e36ca6dc14e1cbb3984cb outParamList = new RL_5a56ddde595e36ca6dc14e1cbb3984cb();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFolioByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[6];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, false, true, true, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, false, true, true, true, false, false, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query UploadInvoiceFiles_0AddData.GetFolioById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_5a56ddde595e36ca6dc14e1cbb3984cb _tmp = new RL_5a56ddde595e36ca6dc14e1cbb3984cb();
_tmp.AlternateReadDbMethodAsync = datasetGetFolioByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query UploadInvoiceFiles_0AddData.GetFolioById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_5a56ddde595e36ca6dc14e1cbb3984cb)_tmp;
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

private static async Task<RC_77f38836e79eb884191ad814597e8589> datasetGetOrderByIdReadDbAsync(RC_77f38836e79eb884191ad814597e8589 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENCompany.Read( r, ref index);
rec.ssENOrderDetail.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetOrderById" JnWfoa1e9UKlD0sW55XggA of Action "UploadInvoiceFiles_0AddData"
public static async Task<(RL_9399cd7e3fe138caf31a0e1fae937d4b,long)> datasetGetOrderById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderMain_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("UploadInvoiceFiles_0AddData.GetOrderById", "a19f7526-5ead-42f5-a50f-4b16e795e080");
using var queryActivity = activitySource.CreateAggregateQueryActivity("UploadInvoiceFiles_0AddData.GetOrderById", "a19f7526-5ead-42f5-a50f-4b16e795e080", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.pJWTvl8zsUOnQdyS6i8Szg/NodesNotShownInESpaceTree.JnWfoa1e9UKlD0sW55XggA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"encompany11\".\"externalid\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, \"enorderdetail6\".\"projectdescription\" o15, NULL o16, NULL o17, \"enorderdetail6\".\"paymenttermsid\" o18, \"enorderdetail6\".\"paymentmethodid\" o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, \"enordermain50\".\"currencyid\" o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, trim_scale(\"enordermain50\".\"totalamount\"::numeric) o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, \"enregion50\".\"divisionfi\" o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, \"ensupplier39\".\"number\" o95, NULL o96, NULL o97, NULL o98, \"ensupplier39\".\"codigopostal_pobl_\" o99, \"ensupplier39\".\"pais\" o100, NULL o101, NULL o102, NULL o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, \"ensupplier39\".\"n_ident_fis_1\" o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, NULL o118, NULL o119");
fromBuilder.Append(" FROM (((({OrderMain} \"enordermain50\" Inner JOIN {Supplier} \"ensupplier39\" ON (\"enordermain50\".\"supplierid\" = \"ensupplier39\".\"id\"))  Inner JOIN {Company} \"encompany11\" ON (\"enordermain50\".\"companyid\" = \"encompany11\".\"id\"))  Left JOIN {OrderDetail} \"enorderdetail6\" ON (\"enordermain50\".\"id\" = \"enorderdetail6\".\"orderid\"))  Left JOIN {Region} \"enregion50\" ON (\"enordermain50\".\"regionid\" = \"enregion50\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderMain_Id != 0) {
whereBuilder.Append("((\"enordermain50\".\"id\" = @qporOrderMain_Id) AND (\"enordermain50\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderMain_Id", DbType.Int64, qporOrderMain_Id);
} else {
whereBuilder.Append("(\"enordermain50\".\"id\" IS NULL)");
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
RL_9399cd7e3fe138caf31a0e1fae937d4b outParamList = new RL_9399cd7e3fe138caf31a0e1fae937d4b();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[5];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, false, true, true, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, false, true, true, true, false, false, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query UploadInvoiceFiles_0AddData.GetOrderById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_9399cd7e3fe138caf31a0e1fae937d4b _tmp = new RL_9399cd7e3fe138caf31a0e1fae937d4b();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query UploadInvoiceFiles_0AddData.GetOrderById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_9399cd7e3fe138caf31a0e1fae937d4b)_tmp;
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

private static async Task<RC_d2afc71b0d41323d7c4b380eedf435e1> datasetGetOrderMainItemsByOrderMainId2ReadDbAsync(RC_d2afc71b0d41323d7c4b380eedf435e1 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoiceUsage.Read( r, ref index);
rec.ssENOrderMainItem.Read( r, ref index);
return rec;
}
// Query Function "GetOrderMainItemsByOrderMainId2" ornn+cZMh06J3qVCahiZHQ of Action "UploadInvoiceFiles_0AddData"
public static async Task<(RL_a84836cbe605db9f376d25b795a14e12,long)> datasetGetOrderMainItemsByOrderMainId2(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderMainItem_OrderMainId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("UploadInvoiceFiles_0AddData.GetOrderMainItemsByOrderMainId2", "f9e7b9a2-4cc6-4e87-89de-a5426a18991d");
using var queryActivity = activitySource.CreateAggregateQueryActivity("UploadInvoiceFiles_0AddData.GetOrderMainItemsByOrderMainId2", "f9e7b9a2-4cc6-4e87-89de-a5426a18991d", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Single
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
selectBuilder.Append("/* /UserActions.pJWTvl8zsUOnQdyS6i8Szg/NodesNotShownInESpaceTree.ornn+cZMh06J3qVCahiZHQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"eninvoiceusage2\".\"key\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60");
fromBuilder.Append(" FROM ({OrderMainItem} \"enordermainitem12\" Left JOIN {InvoiceUsage} \"eninvoiceusage2\" ON (\"enordermainitem12\".\"invoiceusageid\" = \"eninvoiceusage2\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderMainItem_OrderMainId != 0) {
whereBuilder.Append("((\"enordermainitem12\".\"ordermainid\" = @qporOrderMainItem_OrderMainId) AND (\"enordermainitem12\".\"ordermainid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderMainItem_OrderMainId", DbType.Int64, qporOrderMainItem_OrderMainId);
} else {
whereBuilder.Append("(\"enordermainitem12\".\"ordermainid\" IS NULL)");
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
RL_a84836cbe605db9f376d25b795a14e12 outParamList = new RL_a84836cbe605db9f376d25b795a14e12();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderMainItemsByOrderMainId2ReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query UploadInvoiceFiles_0AddData.GetOrderMainItemsByOrderMainId2.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_a84836cbe605db9f376d25b795a14e12 _tmp = new RL_a84836cbe605db9f376d25b795a14e12();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderMainItemsByOrderMainId2ReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query UploadInvoiceFiles_0AddData.GetOrderMainItemsByOrderMainId2.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_a84836cbe605db9f376d25b795a14e12)_tmp;
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
