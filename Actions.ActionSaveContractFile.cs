namespace ssConectaProveedores;

public partial class Actions {
public class lcvSaveContractFile : VarsBag {
public long inParami_OrderId;
public ST_c3df6a1f053620bf8d50da58ff4e41bcStructure inParami_ContractFile;
public long resServiceStorageCreateOrUpdate_outParamId = 0L;

public RL_7954da8b922f4cb9722c2ebf9e20dca0 queryResGetOrderById_outParamList = new RL_7954da8b922f4cb9722c2ebf9e20dca0();
public long queryResGetOrderById_outParamCount = 0L;

public Actions.lcoOrderFileCreateOrUpdate resOrderFileCreateOrUpdate =  new Actions.lcoOrderFileCreateOrUpdate();
public Actions.lcoOrderLogAdd resOrderLogAdd =  new Actions.lcoOrderLogAdd();
public Actions.lcoOrderContractFileCreateOrUpdate resOrderContractFileCreateOrUpdate =  new Actions.lcoOrderContractFileCreateOrUpdate();
public lcvSaveContractFile(long inParami_OrderId, ST_c3df6a1f053620bf8d50da58ff4e41bcStructure inParami_ContractFile) {
this.inParami_OrderId = inParami_OrderId;
this.inParami_ContractFile = inParami_ContractFile;
}
}
/// <summary>
/// Action <code>SaveContractFile</code> that represents the Service Studio action
///  <code>SaveContractFile</code> <p> Description: </p>
/// </summary>
public static async Task ActionSaveContractFile(IRequestContext requestContext,long inParami_OrderId,ST_c3df6a1f053620bf8d50da58ff4e41bcStructure inParami_ContractFile,CancellationToken cancellationToken) {
lcvSaveContractFile localVars = new lcvSaveContractFile(inParami_OrderId, inParami_ContractFile);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("SaveContractFile", "3a2b13e2-28c3-4322-8365-95f6a9941c23"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("SaveContractFile", "3a2b13e2-28c3-4322-8365-95f6a9941c23", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetOrderById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderById_maxRecords = 0;
int datasetGetOrderById_startIndex = 0;(localVars.queryResGetOrderById_outParamList,localVars.queryResGetOrderById_outParamCount) = await FuncActionSaveContractFile.datasetGetOrderById(requestContext,datasetGetOrderById_maxRecords,datasetGetOrderById_startIndex,IterationMultiplicity.Never,localVars.inParami_OrderId,cancellationToken);

// ServiceStorageCreateOrUpdate
localVars.resServiceStorageCreateOrUpdate_outParamId = await ServiceAPIs.ServiceAPIServiceStorageCreateOrUpdate(requestContext,(await RecordUtils.ConvertAsync(localVars.inParami_ContractFile, new EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord(), async (ST_c3df6a1f053620bf8d50da58ff4e41bcStructure source, EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord target, CancellationToken cancellationToken) => {
target.ssId = source.ssOrderFile.ssStorageId;
target.ssConcept = localVars.queryResGetOrderById_outParamList.CurrentRec.ssENOrderMain.ssOrderNumber;
target.ssInternalConceptId = 1;
target.ssFile = source.ssBinary;
target.ssFilename = source.ssOrderFile.ssFilename;
target.ssVendor = localVars.queryResGetOrderById_outParamList.CurrentRec.ssENSupplier.ssNumber;
target.ssDoc_Type = (((BuiltInFunction.IndexSC (BuiltInFunction.ToLower (source.ssOrderFile.ssFilename), ".pdf", 0, false, false)!=(-1))) ? (((((string)AppUtils.SiteProperties[SitePropertiesModel.spPurchaseOrderPDF])))) : ((((BuiltInFunction.IndexSC (BuiltInFunction.ToLower (source.ssOrderFile.ssFilename), ".xml", 0, false, false)!=(-1))) ? (((((string)AppUtils.SiteProperties[SitePropertiesModel.spPurchaseOrderXML])))) : (((((string)AppUtils.SiteProperties[SitePropertiesModel.spPurchaseOrderOther])))))));
target.ssObject_type = ((((string)AppUtils.SiteProperties[SitePropertiesModel.spPurchaseOrderTable])));
target.ssIstoSendToExternal = true;
return target;
}, cancellationToken)),false,cancellationToken);

// SetStorageId
// i_ContractFile.OrderFile.StorageId = ServiceStorageCreateOrUpdate.Id
localVars.inParami_ContractFile.ssOrderFile.ssStorageId = localVars.resServiceStorageCreateOrUpdate_outParamId;
// OrderFileCreateOrUpdate
localVars.resOrderFileCreateOrUpdate.outParamId = await Actions.ActionOrderFileCreateOrUpdate(requestContext,localVars.inParami_ContractFile.ssOrderFile,cancellationToken);

// OrderId
// i_ContractFile.OrderContractFile.OrderId = i_OrderId
localVars.inParami_ContractFile.ssOrderContractFile.ssOrderId = localVars.inParami_OrderId;
// OrderContractFileCreateOrUpdate
localVars.resOrderContractFileCreateOrUpdate.outParamId = await Actions.ActionOrderContractFileCreateOrUpdate(requestContext,new EN_17538b35348920159ed0ee43b3fb2b50EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssOrderId = localVars.inParami_OrderId, ssOrderFileId = localVars.resOrderFileCreateOrUpdate.outParamId, ssContractFileTypeId = localVars.inParami_ContractFile.ssOrderContractFile.ssContractFileTypeId, ssAmount = localVars.inParami_ContractFile.ssOrderContractFile.ssAmount, ssCurrencyId = localVars.inParami_ContractFile.ssOrderContractFile.ssCurrencyId, ssDepositTypeId = localVars.inParami_ContractFile.ssOrderContractFile.ssDepositTypeId, ssInsuranceTypeId = localVars.inParami_ContractFile.ssOrderContractFile.ssInsuranceTypeId, ssAdvancePaymentTypeId = localVars.inParami_ContractFile.ssOrderContractFile.ssAdvancePaymentTypeId, ssIsForVendorUpload = localVars.inParami_ContractFile.ssOrderContractFile.ssIsForVendorUpload },cancellationToken);

// OrderLogAdd
localVars.resOrderLogAdd.outParamId = await Actions.ActionOrderLogAdd(requestContext,new EN_a8e484428097204171df8a1feecb2534EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssOrderId = localVars.inParami_OrderId, ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssMessage = AppUtils.GetStringResource("9iuTL3N3GkOG4yY1l2aCEg#Value.1371365718.1", "Contract file has been uploaded.") },cancellationToken);

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionSaveContractFile {

private static async Task<RC_1f350886772613b21997a3d775fb549d> datasetGetOrderByIdReadDbAsync(RC_1f350886772613b21997a3d775fb549d rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENOrderMain.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetOrderById" vXXkPP5EjU+jaJyQHm0Mjg of Action "SaveContractFile"
public static async Task<(RL_7954da8b922f4cb9722c2ebf9e20dca0,long)> datasetGetOrderById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderMain_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SaveContractFile.GetOrderById", "3ce475bd-44fe-4f8d-a368-9c901e6d0c8e");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SaveContractFile.GetOrderById", "3ce475bd-44fe-4f8d-a368-9c901e6d0c8e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.4hMrOsMoIkODZZX2qZQcIw/NodesNotShownInESpaceTree.vXXkPP5EjU+jaJyQHm0Mjg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enordermain15\".\"ordernumber\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, \"ensupplier8\".\"number\" o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56");
fromBuilder.Append(" FROM ({Supplier} \"ensupplier8\" Inner JOIN {OrderMain} \"enordermain15\" ON (\"ensupplier8\".\"id\" = \"enordermain15\".\"supplierid\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderMain_Id != 0) {
whereBuilder.Append("((\"enordermain15\".\"id\" = @qporOrderMain_Id) AND (\"enordermain15\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderMain_Id", DbType.Int64, qporOrderMain_Id);
} else {
whereBuilder.Append("(\"enordermain15\".\"id\" IS NULL)");
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
RL_7954da8b922f4cb9722c2ebf9e20dca0 outParamList = new RL_7954da8b922f4cb9722c2ebf9e20dca0();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SaveContractFile.GetOrderById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_7954da8b922f4cb9722c2ebf9e20dca0 _tmp = new RL_7954da8b922f4cb9722c2ebf9e20dca0();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SaveContractFile.GetOrderById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_7954da8b922f4cb9722c2ebf9e20dca0)_tmp;
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
