namespace ssConectaProveedores;

public partial class Actions {
public class lcvSaveOrderFiles : VarsBag {
public long inParami_OrderId;
public RC_b64b49f04ca283a60f06aecf635b2100 inParami_Order;
public int resListIndexOf_outParamPosition = 0;

public Actions.lcoOrderFileCreateOrUpdate resOrderFileCreateOrUpdate =  new Actions.lcoOrderFileCreateOrUpdate();
public long resServiceStorageCreateOrUpdate_outParamId = 0L;

public Actions.lcoOrderContractFileCreateOrUpdate resOrderContractFileCreateOrUpdate =  new Actions.lcoOrderContractFileCreateOrUpdate();
public RL_7954da8b922f4cb9722c2ebf9e20dca0 queryResGetOrderById_outParamList = new RL_7954da8b922f4cb9722c2ebf9e20dca0();
public long queryResGetOrderById_outParamCount = 0L;

public Actions.lcoOrderContractFileCreateOrUpdate resOrderContractFileCreateOrUpdate2 =  new Actions.lcoOrderContractFileCreateOrUpdate();
public RL_16bc0f170c91ed9fd3ef42e01c4db2cf queryResGetOrderContractFilesByOrderId_outParamList = new RL_16bc0f170c91ed9fd3ef42e01c4db2cf();
public long queryResGetOrderContractFilesByOrderId_outParamCount = 0L;

public lcvSaveOrderFiles(long inParami_OrderId, RC_b64b49f04ca283a60f06aecf635b2100 inParami_Order) {
this.inParami_OrderId = inParami_OrderId;
this.inParami_Order = inParami_Order;
}
}
public class lcoSaveOrderFiles : VarsBag {
public string outParamErrorMsg = "";

public lcoSaveOrderFiles() {
}
}
/// <summary>
/// Action <code>SaveOrderFiles</code> that represents the Service Studio action
///  <code>SaveOrderFiles</code> <p> Description: Action that saves a Order Contract Files.</p>
/// </summary>
public static async Task<string> ActionSaveOrderFiles(IRequestContext requestContext,long inParami_OrderId,RC_b64b49f04ca283a60f06aecf635b2100 inParami_Order,CancellationToken cancellationToken) {
string outParamErrorMsg = default;
lcoSaveOrderFiles result = new lcoSaveOrderFiles();
lcvSaveOrderFiles localVars = new lcvSaveOrderFiles(inParami_OrderId, inParami_Order);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("SaveOrderFiles", "9f9953a8-b7cf-4fa8-9d5d-90b6e4d7c4f0"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("SaveOrderFiles", "9f9953a8-b7cf-4fa8-9d5d-90b6e4d7c4f0", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetOrderContractFilesByOrderId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderContractFilesByOrderId_maxRecords = 0;
int datasetGetOrderContractFilesByOrderId_startIndex = 0;(localVars.queryResGetOrderContractFilesByOrderId_outParamList,localVars.queryResGetOrderContractFilesByOrderId_outParamCount) = await FuncActionSaveOrderFiles.datasetGetOrderContractFilesByOrderId(requestContext,datasetGetOrderContractFilesByOrderId_maxRecords,datasetGetOrderContractFilesByOrderId_startIndex,IterationMultiplicity.Single,localVars.inParami_OrderId,cancellationToken);

// Foreach GetOrderContractFilesByOrderId.List
localVars.queryResGetOrderContractFilesByOrderId_outParamList.StartIteration();
try {while (!((localVars.queryResGetOrderContractFilesByOrderId_outParamList.Eof))) {
// ListIndexOf
localVars.resListIndexOf_outParamPosition = await ExtendedActions.ListIndexOf(requestContext,localVars.inParami_Order.ssRLAllFiles,async (p, cancellationToken) => (p.ssOrderContractFile.ssId==localVars.queryResGetOrderContractFilesByOrderId_outParamList.CurrentRec.ssENOrderContractFile.ssId),cancellationToken);

// Not Found?
if(((localVars.resListIndexOf_outParamPosition==(-1)))) {
// DeleteOrderContractFile
await ExtendedActions.DeleteOrderContractFile(requestContext,localVars.queryResGetOrderContractFilesByOrderId_outParamList.CurrentRec.ssENOrderContractFile.ssId,cancellationToken);

// DeleteOrderFile
await ExtendedActions.DeleteOrderFile(requestContext,localVars.queryResGetOrderContractFilesByOrderId_outParamList.CurrentRec.ssENOrderFile.ssId,cancellationToken);

// Check StorageId
if(((localVars.queryResGetOrderContractFilesByOrderId_outParamList.CurrentRec.ssENOrderFile.ssStorageId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// ServiceStorageDelete
await ServiceAPIs.ServiceAPIServiceStorageDelete(requestContext,localVars.queryResGetOrderContractFilesByOrderId_outParamList.CurrentRec.ssENOrderFile.ssStorageId,cancellationToken);

}

}

localVars.queryResGetOrderContractFilesByOrderId_outParamList.Advance();
}

} finally {
localVars.queryResGetOrderContractFilesByOrderId_outParamList.EndIteration();
}

// Query datasetGetOrderById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderById_maxRecords = 1;
if (datasetGetOrderById_maxRecords < 1) datasetGetOrderById_maxRecords = 1;
int datasetGetOrderById_startIndex = 0;(localVars.queryResGetOrderById_outParamList,localVars.queryResGetOrderById_outParamCount) = await FuncActionSaveOrderFiles.datasetGetOrderById(requestContext,datasetGetOrderById_maxRecords,datasetGetOrderById_startIndex,IterationMultiplicity.Never,localVars.inParami_OrderId,cancellationToken);

// Foreach i_Order.AllFiles
localVars.inParami_Order.ssRLAllFiles.StartIteration();
try {while (!((localVars.inParami_Order.ssRLAllFiles.Eof))) {
// No file
if((!(BinaryContentUtils.AreBothBinariesNull(localVars.inParami_Order.ssRLAllFiles.CurrentRec.ssBinary, BuiltInFunction.NullBinary ())))) {
// ServiceStorageCreateOrUpdate
localVars.resServiceStorageCreateOrUpdate_outParamId = await ServiceAPIs.ServiceAPIServiceStorageCreateOrUpdate(requestContext,(await RecordUtils.ConvertAsync(localVars.inParami_Order.ssRLAllFiles.CurrentRec, new EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord(), async (ST_c3df6a1f053620bf8d50da58ff4e41bcStructure source, EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord target, CancellationToken cancellationToken) => {
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
// i_Order.AllFiles.Current.OrderFile.StorageId = ServiceStorageCreateOrUpdate.Id
localVars.inParami_Order.ssRLAllFiles.CurrentRec.ssOrderFile.ssStorageId = localVars.resServiceStorageCreateOrUpdate_outParamId;
}

// OrderFileCreateOrUpdate
localVars.resOrderFileCreateOrUpdate.outParamId = await Actions.ActionOrderFileCreateOrUpdate(requestContext,localVars.inParami_Order.ssRLAllFiles.CurrentRec.ssOrderFile,cancellationToken);

// New?
if(((localVars.inParami_Order.ssRLAllFiles.CurrentRec.ssOrderContractFile.ssId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// OrderId
// i_Order.AllFiles.Current.OrderContractFile.OrderId = i_OrderId
localVars.inParami_Order.ssRLAllFiles.CurrentRec.ssOrderContractFile.ssOrderId = localVars.inParami_OrderId;
// OrderContractFileCreateOrUpdate
localVars.resOrderContractFileCreateOrUpdate.outParamId = await Actions.ActionOrderContractFileCreateOrUpdate(requestContext,new EN_17538b35348920159ed0ee43b3fb2b50EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssOrderId = localVars.inParami_OrderId, ssOrderFileId = localVars.resOrderFileCreateOrUpdate.outParamId, ssContractFileTypeId = localVars.inParami_Order.ssRLAllFiles.CurrentRec.ssOrderContractFile.ssContractFileTypeId, ssAmount = localVars.inParami_Order.ssRLAllFiles.CurrentRec.ssOrderContractFile.ssAmount, ssTarif = localVars.inParami_Order.ssRLAllFiles.CurrentRec.ssOrderContractFile.ssTarif, ssCurrencyId = localVars.inParami_Order.ssRLAllFiles.CurrentRec.ssOrderContractFile.ssCurrencyId, ssDepositTypeId = localVars.inParami_Order.ssRLAllFiles.CurrentRec.ssOrderContractFile.ssDepositTypeId, ssInsuranceTypeId = localVars.inParami_Order.ssRLAllFiles.CurrentRec.ssOrderContractFile.ssInsuranceTypeId, ssAdvancePaymentTypeId = localVars.inParami_Order.ssRLAllFiles.CurrentRec.ssOrderContractFile.ssAdvancePaymentTypeId, ssStartBaseDate = localVars.inParami_Order.ssRLAllFiles.CurrentRec.ssOrderContractFile.ssStartBaseDate, ssEndBaseDate = localVars.inParami_Order.ssRLAllFiles.CurrentRec.ssOrderContractFile.ssEndBaseDate, ssPaymentTermsId = localVars.inParami_Order.ssRLAllFiles.CurrentRec.ssOrderContractFile.ssPaymentTermsId, ssIsForVendorUpload = localVars.inParami_Order.ssRLAllFiles.CurrentRec.ssOrderContractFile.ssIsForVendorUpload },cancellationToken);

} else {
// OrderContractFileCreateOrUpdate2
localVars.resOrderContractFileCreateOrUpdate2.outParamId = await Actions.ActionOrderContractFileCreateOrUpdate(requestContext,localVars.inParami_Order.ssRLAllFiles.CurrentRec.ssOrderContractFile,cancellationToken);

}

localVars.inParami_Order.ssRLAllFiles.Advance();
}

} finally {
localVars.inParami_Order.ssRLAllFiles.EndIteration();
}

} //close CreateActionActivity using block
} // try

catch (Exception ex) {
ApplicationLogger.Error(ex, "Error executing action");
requestContext.LastException = ex;

// Error Handler

// ErrorMsg = "There was a problem saving one of the files. Please try again later."
result.outParamErrorMsg=AppUtils.GetStringResource("6Q3bOooPc02ykbyJl4ApJw#Value.1050410687.1", "There was a problem saving one of the files. Please try again later.");
goto RETURN_STATEMENT;

} // Catch
finally {
outParamErrorMsg = result.outParamErrorMsg;
cancellationToken.ThrowIfCancellationRequested();
} // inner-finally
RETURN_STATEMENT:
return outParamErrorMsg;
}

public static class FuncActionSaveOrderFiles {

private static async Task<RC_1f350886772613b21997a3d775fb549d> datasetGetOrderByIdReadDbAsync(RC_1f350886772613b21997a3d775fb549d rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENOrderMain.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetOrderById" AwJD2WM4wEeZfBQDKPZ3KQ of Action "SaveOrderFiles"
public static async Task<(RL_7954da8b922f4cb9722c2ebf9e20dca0,long)> datasetGetOrderById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderMain_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SaveOrderFiles.GetOrderById", "d9430203-3863-47c0-997c-140328f67729");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SaveOrderFiles.GetOrderById", "d9430203-3863-47c0-997c-140328f67729", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.qFOZn8+3qE+dXZC25NfE8A/NodesNotShownInESpaceTree.AwJD2WM4wEeZfBQDKPZ3KQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enordermain42\".\"ordernumber\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, \"ensupplier27\".\"number\" o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56");
fromBuilder.Append(" FROM ({Supplier} \"ensupplier27\" Inner JOIN {OrderMain} \"enordermain42\" ON (\"ensupplier27\".\"id\" = \"enordermain42\".\"supplierid\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderMain_Id != 0) {
whereBuilder.Append("((\"enordermain42\".\"id\" = @qporOrderMain_Id) AND (\"enordermain42\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderMain_Id", DbType.Int64, qporOrderMain_Id);
} else {
whereBuilder.Append("(\"enordermain42\".\"id\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SaveOrderFiles.GetOrderById.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SaveOrderFiles.GetOrderById.List", cancellationToken: cancellationToken);
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

private static async Task<RC_8171c5e0188443e9384b8f5492517b0e> datasetGetOrderContractFilesByOrderIdReadDbAsync(RC_8171c5e0188443e9384b8f5492517b0e rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENOrderContractFile.Read( r, ref index);
rec.ssENOrderFile.Read( r, ref index);
return rec;
}
// Query Function "GetOrderContractFilesByOrderId" d1rz8B3KfUyoXukmCFpgfw of Action "SaveOrderFiles"
public static async Task<(RL_16bc0f170c91ed9fd3ef42e01c4db2cf,long)> datasetGetOrderContractFilesByOrderId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderContractFile_OrderId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SaveOrderFiles.GetOrderContractFilesByOrderId", "f0f35a77-ca1d-4c7d-a85e-e926085a607f");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SaveOrderFiles.GetOrderContractFilesByOrderId", "f0f35a77-ca1d-4c7d-a85e-e926085a607f", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.qFOZn8+3qE+dXZC25NfE8A/NodesNotShownInESpaceTree.d1rz8B3KfUyoXukmCFpgfw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enordercontractfile2\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, \"enorderfile2\".\"id\" o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, \"enorderfile2\".\"storageid\" o21");
fromBuilder.Append(" FROM ({OrderContractFile} \"enordercontractfile2\" Left JOIN {OrderFile} \"enorderfile2\" ON (\"enordercontractfile2\".\"orderfileid\" = \"enorderfile2\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderContractFile_OrderId != 0) {
whereBuilder.Append("((\"enordercontractfile2\".\"orderid\" = @qporOrderContractFile_OrderId) AND (\"enordercontractfile2\".\"orderid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderContractFile_OrderId", DbType.Int64, qporOrderContractFile_OrderId);
} else {
whereBuilder.Append("(\"enordercontractfile2\".\"orderid\" IS NULL)");
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
RL_16bc0f170c91ed9fd3ef42e01c4db2cf outParamList = new RL_16bc0f170c91ed9fd3ef42e01c4db2cf();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderContractFilesByOrderIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {false, true, true, true, true, true, true, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SaveOrderFiles.GetOrderContractFilesByOrderId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_16bc0f170c91ed9fd3ef42e01c4db2cf _tmp = new RL_16bc0f170c91ed9fd3ef42e01c4db2cf();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderContractFilesByOrderIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SaveOrderFiles.GetOrderContractFilesByOrderId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_16bc0f170c91ed9fd3ef42e01c4db2cf)_tmp;
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
