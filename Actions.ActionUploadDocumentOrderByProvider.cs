namespace ssConectaProveedores;

public partial class Actions {
public class lcvUploadDocumentOrderByProvider : VarsBag {
public long inParami_RequestFileId;
public long inParami_OrderMainId;
public RL_1501ee54ff868a67eff67465502ee3d9 inParamI_FilesList;
public RL_1501ee54ff868a67eff67465502ee3d9 inParami_FilesListExtra;
public ST_6f620840109ac6f721328b723ec0152cStructure inParami_InvoiceForeign;
public long inParami_OrderAccConceptsId;
public bool inParami_CreateRequestFile;
public int inParamOffsetUtc;
public Actions.lcoOrderLogAdd resOrderLogAdd =  new Actions.lcoOrderLogAdd();
public long resServiceStorageCreate_outParamId = 0L;

public Actions.lcoOrderLogAdd resOrderLogAdd2 =  new Actions.lcoOrderLogAdd();
public Actions.lcoInitOrderRequestFileApproval resInitOrderRequestFileApproval2 =  new Actions.lcoInitOrderRequestFileApproval();
public RC_73d8126c722e2b4dd662dab2bf1a72d1 resGetOrderRequestFile2_outParamRecord = new RC_73d8126c722e2b4dd662dab2bf1a72d1();

public long resCreateOrderRequestFile_outParamId = 0L;

public RL_95d1f6e611a5505299d1e9919fa0d9e6 queryResGetOrderAccConceptById_outParamList = new RL_95d1f6e611a5505299d1e9919fa0d9e6();
public long queryResGetOrderAccConceptById_outParamCount = 0L;

public RL_95d1f6e611a5505299d1e9919fa0d9e6 queryResGetOrderAccConceptById2_outParamList = new RL_95d1f6e611a5505299d1e9919fa0d9e6();
public long queryResGetOrderAccConceptById2_outParamCount = 0L;

public RC_73d8126c722e2b4dd662dab2bf1a72d1 resGetOrderRequestFile_outParamRecord = new RC_73d8126c722e2b4dd662dab2bf1a72d1();

public RL_7954da8b922f4cb9722c2ebf9e20dca0 queryResGetOrderMainById_outParamList = new RL_7954da8b922f4cb9722c2ebf9e20dca0();
public long queryResGetOrderMainById_outParamCount = 0L;

public Actions.lcoUploadInvoiceFiles resUploadInvoiceFiles =  new Actions.lcoUploadInvoiceFiles();
public string resString_Join_outParamText = "";

public Actions.lcoInitOrderRequestFileApproval resInitOrderRequestFileApproval =  new Actions.lcoInitOrderRequestFileApproval();
public lcvUploadDocumentOrderByProvider(long inParami_RequestFileId, long inParami_OrderMainId, RL_1501ee54ff868a67eff67465502ee3d9 inParamI_FilesList, RL_1501ee54ff868a67eff67465502ee3d9 inParami_FilesListExtra, ST_6f620840109ac6f721328b723ec0152cStructure inParami_InvoiceForeign, long inParami_OrderAccConceptsId, bool inParami_CreateRequestFile, int inParamOffsetUtc) {
this.inParami_RequestFileId = inParami_RequestFileId;
this.inParami_OrderMainId = inParami_OrderMainId;
this.inParamI_FilesList = inParamI_FilesList;
this.inParami_FilesListExtra = inParami_FilesListExtra;
this.inParami_InvoiceForeign = inParami_InvoiceForeign;
this.inParami_OrderAccConceptsId = inParami_OrderAccConceptsId;
this.inParami_CreateRequestFile = inParami_CreateRequestFile;
this.inParamOffsetUtc = inParamOffsetUtc;
}
}
public class lcoUploadDocumentOrderByProvider : VarsBag {
public long outParamInvoiceId = 0L;

public long outParamStorageId = 0L;

public lcoUploadDocumentOrderByProvider() {
}
}
/// <summary>
/// Action <code>UploadDocumentOrderByProvider</code> that represents the Service Studio action
///  <code>UploadDocumentOrderByProvider</code> <p> Description: </p>
/// </summary>
public static async Task<(long,long)> ActionUploadDocumentOrderByProvider(IRequestContext requestContext,long inParami_RequestFileId,long inParami_OrderMainId,RL_1501ee54ff868a67eff67465502ee3d9 inParamI_FilesList,RL_1501ee54ff868a67eff67465502ee3d9 inParami_FilesListExtra,ST_6f620840109ac6f721328b723ec0152cStructure inParami_InvoiceForeign,long inParami_OrderAccConceptsId,bool inParami_CreateRequestFile,int inParamOffsetUtc,CancellationToken cancellationToken) {
long outParamInvoiceId = default;
long outParamStorageId = default;
lcoUploadDocumentOrderByProvider result = new lcoUploadDocumentOrderByProvider();
lcvUploadDocumentOrderByProvider localVars = new lcvUploadDocumentOrderByProvider(inParami_RequestFileId, inParami_OrderMainId, inParamI_FilesList, inParami_FilesListExtra, inParami_InvoiceForeign, inParami_OrderAccConceptsId, inParami_CreateRequestFile, inParamOffsetUtc);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("UploadDocumentOrderByProvider", "8a6b72a5-1217-432a-a378-1edbd363a30f"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("UploadDocumentOrderByProvider", "8a6b72a5-1217-432a-a378-1edbd363a30f", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
if(((localVars.inParami_OrderAccConceptsId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// UploadInvoiceFiles
(localVars.resUploadInvoiceFiles.outParamErrorMsg,localVars.resUploadInvoiceFiles.outParamo_Invoice,localVars.resUploadInvoiceFiles.outParamo_InvoiceExtended,localVars.resUploadInvoiceFiles.outParamClaveProdServ,localVars.resUploadInvoiceFiles.outParamTipoComprobante,localVars.resUploadInvoiceFiles.outParamIsMissingCreditNote) = await Actions.ActionUploadInvoiceFiles(requestContext,Convert.ToInt64(BuiltInFunction.NullIdentifier ()),0L,localVars.inParami_OrderMainId,0L,(await RL_7b4ceb84b6a1255d3a42c8932279bc3c.ConvertAsync(localVars.inParamI_FilesList, new RL_7b4ceb84b6a1255d3a42c8932279bc3c(), async (ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure source, ST_7837994e68174a4794f15e4233b48555Structure target, CancellationToken cancellationToken) => {
target.ssName = source.ssName;
target.ssBinaryData = source.ssBinaryData;
return target;
}, cancellationToken)),new RL_7b4ceb84b6a1255d3a42c8932279bc3c(),false,localVars.inParami_InvoiceForeign,(((decimal)0)),false,false,0,localVars.inParami_OrderAccConceptsId,0.0M,0L,localVars.inParamOffsetUtc,cancellationToken);

// error?
if(((localVars.resUploadInvoiceFiles.outParamErrorMsg!=""))) {
// RaiseError FileInvalid
throw new Ex_FileInvalidUserException (localVars.resUploadInvoiceFiles.outParamErrorMsg);

} else {
// InvoiceId = UploadInvoiceFiles.o_Invoice.Id
result.outParamInvoiceId=localVars.resUploadInvoiceFiles.outParamo_Invoice.ssId;
if(((localVars.inParami_CreateRequestFile&&(localVars.inParami_RequestFileId==Convert.ToInt64(BuiltInFunction.NullIdentifier ()))))) {
// Query datasetGetOrderAccConceptById2
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderAccConceptById2_maxRecords = 1;
if (datasetGetOrderAccConceptById2_maxRecords < 1) datasetGetOrderAccConceptById2_maxRecords = 1;
int datasetGetOrderAccConceptById2_startIndex = 0;(localVars.queryResGetOrderAccConceptById2_outParamList,localVars.queryResGetOrderAccConceptById2_outParamCount) = await FuncActionUploadDocumentOrderByProvider.datasetGetOrderAccConceptById2(requestContext,datasetGetOrderAccConceptById2_maxRecords,datasetGetOrderAccConceptById2_startIndex,IterationMultiplicity.Never,localVars.inParami_OrderAccConceptsId,cancellationToken);

// CreateOrderRequestFile
localVars.resCreateOrderRequestFile_outParamId = await ExtendedActions.CreateOrderRequestFile(requestContext,new RC_73d8126c722e2b4dd662dab2bf1a72d1(){ ssENOrderRequestFile = new EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord(){ ssOrderId = localVars.inParami_OrderMainId, ssDescription = localVars.queryResGetOrderAccConceptById2_outParamList.CurrentRec.ssENAccountingDataType.ssLabel, ssOrderAccConceptId = localVars.inParami_OrderAccConceptsId, ssIsFinancialFile = true } },cancellationToken);

// i_RequestFileId = CreateOrderRequestFile.Id
localVars.inParami_RequestFileId=localVars.resCreateOrderRequestFile_outParamId;
}

// GetOrderRequestFile
localVars.resGetOrderRequestFile_outParamRecord = await ExtendedActions.GetOrderRequestFile(requestContext,localVars.inParami_RequestFileId,cancellationToken);

// With old InvoiceId?
if(((localVars.resGetOrderRequestFile_outParamRecord.ssENOrderRequestFile.ssInvoiceId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// DeleteInvoiceAndFiles
await Actions.ActionDeleteInvoiceAndFiles(requestContext,localVars.resGetOrderRequestFile_outParamRecord.ssENOrderRequestFile.ssInvoiceId,cancellationToken);

}

// With old StorageId?
if(((localVars.resGetOrderRequestFile_outParamRecord.ssENOrderRequestFile.ssStorageId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// ServiceStorageDelete
await ServiceAPIs.ServiceAPIServiceStorageDelete(requestContext,localVars.resGetOrderRequestFile_outParamRecord.ssENOrderRequestFile.ssStorageId,cancellationToken);

}

// Query datasetGetOrderAccConceptById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderAccConceptById_maxRecords = 0;
int datasetGetOrderAccConceptById_startIndex = 0;(localVars.queryResGetOrderAccConceptById_outParamList,localVars.queryResGetOrderAccConceptById_outParamCount) = await FuncActionUploadDocumentOrderByProvider.datasetGetOrderAccConceptById(requestContext,datasetGetOrderAccConceptById_maxRecords,datasetGetOrderAccConceptById_startIndex,IterationMultiplicity.Never,localVars.inParami_OrderAccConceptsId,cancellationToken);

// String_Join
localVars.resString_Join_outParamText = await Actions.ActionString_Join(requestContext,(await RLTextRecordList.ConvertAsync(localVars.inParamI_FilesList, new RLTextRecordList(), async (ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure source, RCTextRecord target, CancellationToken cancellationToken) => {
target.ssSTText2.ssValue = source.ssName;
return target;
}, cancellationToken)),", ",cancellationToken);

// GetOrderRequestFile.Record.OrderRequestFile.InvoiceId = UploadInvoiceFiles.o_Invoice.Id
localVars.resGetOrderRequestFile_outParamRecord.ssENOrderRequestFile.ssInvoiceId = localVars.resUploadInvoiceFiles.outParamo_Invoice.ssId;

// GetOrderRequestFile.Record.OrderRequestFile.StorageId = NullIdentifier
localVars.resGetOrderRequestFile_outParamRecord.ssENOrderRequestFile.ssStorageId = Convert.ToInt64(BuiltInFunction.NullIdentifier ());

// GetOrderRequestFile.Record.OrderRequestFile.NeedsApproval = True
localVars.resGetOrderRequestFile_outParamRecord.ssENOrderRequestFile.ssNeedsApproval = true;

// GetOrderRequestFile.Record.OrderRequestFile.IsRejected = False
localVars.resGetOrderRequestFile_outParamRecord.ssENOrderRequestFile.ssIsRejected = false;

// GetOrderRequestFile.Record.OrderRequestFile.IsApproved = False
localVars.resGetOrderRequestFile_outParamRecord.ssENOrderRequestFile.ssIsApproved = false;

// GetOrderRequestFile.Record.OrderRequestFile.Filename = String_Join.Text
localVars.resGetOrderRequestFile_outParamRecord.ssENOrderRequestFile.ssFilename = localVars.resString_Join_outParamText;

// GetOrderRequestFile.Record.OrderRequestFile.NeedAccounting = True
localVars.resGetOrderRequestFile_outParamRecord.ssENOrderRequestFile.ssNeedAccounting = true;

// GetOrderRequestFile.Record.OrderRequestFile.Description = GetOrderAccConceptById.List.Current.AccountingDataType.Label
localVars.resGetOrderRequestFile_outParamRecord.ssENOrderRequestFile.ssDescription = localVars.queryResGetOrderAccConceptById_outParamList.CurrentRec.ssENAccountingDataType.ssLabel;
// UpdateOrderRequestFile
await ExtendedActions.UpdateOrderRequestFile(requestContext,localVars.resGetOrderRequestFile_outParamRecord.ChangedAttributes,localVars.resGetOrderRequestFile_outParamRecord,cancellationToken);

// OrderLogAdd
localVars.resOrderLogAdd.outParamId = await Actions.ActionOrderLogAdd(requestContext,new EN_a8e484428097204171df8a1feecb2534EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssOrderId = localVars.inParami_OrderMainId, ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssMessage = ((((AppUtils.GetStringResource("1tLCdGpmOUW94Pq+mb0grQ#Value.-1129171793.1", "The supplier added the requested file(s) to the document:")+" ")+localVars.resGetOrderRequestFile_outParamRecord.ssENOrderRequestFile.ssDescription)+" ")+AppUtils.GetStringResource("1tLCdGpmOUW94Pq+mb0grQ#Value.1163073159.1", "and since it's a CFDI file, the approval process has begun.")) },cancellationToken);

// InitOrderRequestFileApproval
localVars.resInitOrderRequestFileApproval.outParamOutput = await Actions.ActionInitOrderRequestFileApproval(requestContext,localVars.inParami_RequestFileId,cancellationToken);

}

} else {
// Query datasetGetOrderMainById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderMainById_maxRecords = 1;
if (datasetGetOrderMainById_maxRecords < 1) datasetGetOrderMainById_maxRecords = 1;
int datasetGetOrderMainById_startIndex = 0;(localVars.queryResGetOrderMainById_outParamList,localVars.queryResGetOrderMainById_outParamCount) = await FuncActionUploadDocumentOrderByProvider.datasetGetOrderMainById(requestContext,datasetGetOrderMainById_maxRecords,datasetGetOrderMainById_startIndex,IterationMultiplicity.Never,localVars.inParami_OrderMainId,cancellationToken);

// ServiceStorageCreate
localVars.resServiceStorageCreate_outParamId = await ServiceAPIs.ServiceAPIServiceStorageCreate(requestContext,new EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssConcept = localVars.queryResGetOrderMainById_outParamList.CurrentRec.ssENOrderMain.ssOrderNumber, ssInternalConceptId = 1, ssFile = localVars.inParami_FilesListExtra.CurrentRec.ssBinaryData, ssFilename = localVars.inParami_FilesListExtra.CurrentRec.ssName, ssVendor = localVars.queryResGetOrderMainById_outParamList.CurrentRec.ssENSupplier.ssNumber, ssDoc_Type = (((BuiltInFunction.IndexSC (BuiltInFunction.ToLower (localVars.inParami_FilesListExtra.CurrentRec.ssName), ".pdf", 0, false, false)!=(-1))) ? (((((string)AppUtils.SiteProperties[SitePropertiesModel.spPurchaseOrderPDF])))) : ((((BuiltInFunction.IndexSC (BuiltInFunction.ToLower (localVars.inParami_FilesListExtra.CurrentRec.ssName), ".xml", 0, false, false)!=(-1))) ? (((((string)AppUtils.SiteProperties[SitePropertiesModel.spPurchaseOrderXML])))) : (((((string)AppUtils.SiteProperties[SitePropertiesModel.spPurchaseOrderOther]))))))), ssObject_type = ((((string)AppUtils.SiteProperties[SitePropertiesModel.spPurchaseOrderTable]))), ssIstoSendToExternal = true },false,cancellationToken);

// StorageId = ServiceStorageCreate.Id
result.outParamStorageId=localVars.resServiceStorageCreate_outParamId;
// GetOrderRequestFile2
localVars.resGetOrderRequestFile2_outParamRecord = await ExtendedActions.GetOrderRequestFile(requestContext,localVars.inParami_RequestFileId,cancellationToken);

// With old InvoiceId?
if(((localVars.resGetOrderRequestFile2_outParamRecord.ssENOrderRequestFile.ssInvoiceId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// DeleteInvoiceAndFiles2
await Actions.ActionDeleteInvoiceAndFiles(requestContext,localVars.resGetOrderRequestFile2_outParamRecord.ssENOrderRequestFile.ssInvoiceId,cancellationToken);

}

// With old StorageId?
if(((localVars.resGetOrderRequestFile2_outParamRecord.ssENOrderRequestFile.ssStorageId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// ServiceStorageDelete2
await ServiceAPIs.ServiceAPIServiceStorageDelete(requestContext,localVars.resGetOrderRequestFile2_outParamRecord.ssENOrderRequestFile.ssStorageId,cancellationToken);

}

// GetOrderRequestFile2.Record.OrderRequestFile.InvoiceId = NullIdentifier
localVars.resGetOrderRequestFile2_outParamRecord.ssENOrderRequestFile.ssInvoiceId = Convert.ToInt64(BuiltInFunction.NullIdentifier ());

// GetOrderRequestFile2.Record.OrderRequestFile.StorageId = ServiceStorageCreate.Id
localVars.resGetOrderRequestFile2_outParamRecord.ssENOrderRequestFile.ssStorageId = localVars.resServiceStorageCreate_outParamId;

// GetOrderRequestFile2.Record.OrderRequestFile.NeedsApproval = True
localVars.resGetOrderRequestFile2_outParamRecord.ssENOrderRequestFile.ssNeedsApproval = true;

// GetOrderRequestFile2.Record.OrderRequestFile.Filename = i_FilesListExtra.Current.Name
localVars.resGetOrderRequestFile2_outParamRecord.ssENOrderRequestFile.ssFilename = localVars.inParami_FilesListExtra.CurrentRec.ssName;

// GetOrderRequestFile2.Record.OrderRequestFile.IsRejected = False
localVars.resGetOrderRequestFile2_outParamRecord.ssENOrderRequestFile.ssIsRejected = false;

// GetOrderRequestFile2.Record.OrderRequestFile.IsApproved = False
localVars.resGetOrderRequestFile2_outParamRecord.ssENOrderRequestFile.ssIsApproved = false;

// GetOrderRequestFile2.Record.OrderRequestFile.NeedAccounting = False
localVars.resGetOrderRequestFile2_outParamRecord.ssENOrderRequestFile.ssNeedAccounting = false;
// UpdateOrderRequestFile2
await ExtendedActions.UpdateOrderRequestFile(requestContext,localVars.resGetOrderRequestFile2_outParamRecord.ChangedAttributes,localVars.resGetOrderRequestFile2_outParamRecord,cancellationToken);

// OrderLogAdd2
localVars.resOrderLogAdd2.outParamId = await Actions.ActionOrderLogAdd(requestContext,new EN_a8e484428097204171df8a1feecb2534EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssOrderId = localVars.inParami_OrderMainId, ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssMessage = ((((AppUtils.GetStringResource("K1HGZ+55_keYs5SjUia+Gw#Value.-1129171793.1", "The supplier added the requested file(s) to the document:")+" ")+localVars.resGetOrderRequestFile2_outParamRecord.ssENOrderRequestFile.ssDescription)+" ")+AppUtils.GetStringResource("K1HGZ+55_keYs5SjUia+Gw#Value.1163073159.1", "and since it's a CFDI file, the approval process has begun.")) },cancellationToken);

// InitOrderRequestFileApproval2
localVars.resInitOrderRequestFileApproval2.outParamOutput = await Actions.ActionInitOrderRequestFileApproval(requestContext,localVars.inParami_RequestFileId,cancellationToken);

}

} //close CreateActionActivity using block
} // try

finally {
outParamInvoiceId = result.outParamInvoiceId;
outParamStorageId = result.outParamStorageId;
} // inner-finally
RETURN_STATEMENT:
return (outParamInvoiceId,outParamStorageId);
}

public static class FuncActionUploadDocumentOrderByProvider {

private static async Task<RC_ea3a117956fd50e1901759909d3fbc2f> datasetGetOrderAccConceptByIdReadDbAsync(RC_ea3a117956fd50e1901759909d3fbc2f rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENAccountingDataType.Read( r, ref index);
rec.ssENOrderAccConcepts.Read( r, ref index);
return rec;
}
// Query Function "GetOrderAccConceptById" Tk8JfOkihU28cVrL5TGVtA of Action "UploadDocumentOrderByProvider"
public static async Task<(RL_95d1f6e611a5505299d1e9919fa0d9e6,long)> datasetGetOrderAccConceptById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderAccConcepts_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("UploadDocumentOrderByProvider.GetOrderAccConceptById", "7c094f4e-22e9-4d85-bc71-5acbe53195b4");
using var queryActivity = activitySource.CreateAggregateQueryActivity("UploadDocumentOrderByProvider.GetOrderAccConceptById", "7c094f4e-22e9-4d85-bc71-5acbe53195b4", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.pXJrihcSKkOjeB7b02OjDw/NodesNotShownInESpaceTree.Tk8JfOkihU28cVrL5TGVtA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enaccountingdatatype3\".\"label\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18");
fromBuilder.Append(" FROM ({OrderAccConcepts} \"enorderaccconcepts4\" Left JOIN {AccountingDataType} \"enaccountingdatatype3\" ON (\"enorderaccconcepts4\".\"accountingdatatypeid\" = \"enaccountingdatatype3\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderAccConcepts_Id != 0) {
whereBuilder.Append("((\"enorderaccconcepts4\".\"id\" = @qporOrderAccConcepts_Id) AND (\"enorderaccconcepts4\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderAccConcepts_Id", DbType.Int64, qporOrderAccConcepts_Id);
} else {
whereBuilder.Append("(\"enorderaccconcepts4\".\"id\" IS NULL)");
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
RL_95d1f6e611a5505299d1e9919fa0d9e6 outParamList = new RL_95d1f6e611a5505299d1e9919fa0d9e6();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderAccConceptByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query UploadDocumentOrderByProvider.GetOrderAccConceptById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_95d1f6e611a5505299d1e9919fa0d9e6 _tmp = new RL_95d1f6e611a5505299d1e9919fa0d9e6();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderAccConceptByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query UploadDocumentOrderByProvider.GetOrderAccConceptById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_95d1f6e611a5505299d1e9919fa0d9e6)_tmp;
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

private static async Task<RC_ea3a117956fd50e1901759909d3fbc2f> datasetGetOrderAccConceptById2ReadDbAsync(RC_ea3a117956fd50e1901759909d3fbc2f rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENAccountingDataType.Read( r, ref index);
rec.ssENOrderAccConcepts.Read( r, ref index);
return rec;
}
// Query Function "GetOrderAccConceptById2" ETs2j5QQS0aD8O_VoFbL7Q of Action "UploadDocumentOrderByProvider"
public static async Task<(RL_95d1f6e611a5505299d1e9919fa0d9e6,long)> datasetGetOrderAccConceptById2(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderAccConcepts_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("UploadDocumentOrderByProvider.GetOrderAccConceptById2", "8f363b11-1094-464b-83f0-efd5a056cbed");
using var queryActivity = activitySource.CreateAggregateQueryActivity("UploadDocumentOrderByProvider.GetOrderAccConceptById2", "8f363b11-1094-464b-83f0-efd5a056cbed", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.pXJrihcSKkOjeB7b02OjDw/NodesNotShownInESpaceTree.ETs2j5QQS0aD8O_VoFbL7Q, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enaccountingdatatype4\".\"label\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18");
fromBuilder.Append(" FROM ({OrderAccConcepts} \"enorderaccconcepts5\" Left JOIN {AccountingDataType} \"enaccountingdatatype4\" ON (\"enorderaccconcepts5\".\"accountingdatatypeid\" = \"enaccountingdatatype4\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderAccConcepts_Id != 0) {
whereBuilder.Append("((\"enorderaccconcepts5\".\"id\" = @qporOrderAccConcepts_Id) AND (\"enorderaccconcepts5\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderAccConcepts_Id", DbType.Int64, qporOrderAccConcepts_Id);
} else {
whereBuilder.Append("(\"enorderaccconcepts5\".\"id\" IS NULL)");
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
RL_95d1f6e611a5505299d1e9919fa0d9e6 outParamList = new RL_95d1f6e611a5505299d1e9919fa0d9e6();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderAccConceptById2ReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query UploadDocumentOrderByProvider.GetOrderAccConceptById2.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_95d1f6e611a5505299d1e9919fa0d9e6 _tmp = new RL_95d1f6e611a5505299d1e9919fa0d9e6();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderAccConceptById2ReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query UploadDocumentOrderByProvider.GetOrderAccConceptById2.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_95d1f6e611a5505299d1e9919fa0d9e6)_tmp;
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

private static async Task<RC_1f350886772613b21997a3d775fb549d> datasetGetOrderMainByIdReadDbAsync(RC_1f350886772613b21997a3d775fb549d rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENOrderMain.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetOrderMainById" aE0TnYZipkSAJKN2yXlrPw of Action "UploadDocumentOrderByProvider"
public static async Task<(RL_7954da8b922f4cb9722c2ebf9e20dca0,long)> datasetGetOrderMainById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderMain_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("UploadDocumentOrderByProvider.GetOrderMainById", "9d134d68-6286-44a6-8024-a376c9796b3f");
using var queryActivity = activitySource.CreateAggregateQueryActivity("UploadDocumentOrderByProvider.GetOrderMainById", "9d134d68-6286-44a6-8024-a376c9796b3f", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.pXJrihcSKkOjeB7b02OjDw/NodesNotShownInESpaceTree.aE0TnYZipkSAJKN2yXlrPw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enordermain41\".\"ordernumber\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, \"ensupplier24\".\"number\" o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56");
fromBuilder.Append(" FROM ({OrderMain} \"enordermain41\" Inner JOIN {Supplier} \"ensupplier24\" ON (\"enordermain41\".\"supplierid\" = \"ensupplier24\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderMain_Id != 0) {
whereBuilder.Append("((\"enordermain41\".\"id\" = @qporOrderMain_Id) AND (\"enordermain41\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderMain_Id", DbType.Int64, qporOrderMain_Id);
} else {
whereBuilder.Append("(\"enordermain41\".\"id\" IS NULL)");
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
outParamList.AlternateReadDbMethodAsync = datasetGetOrderMainByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query UploadDocumentOrderByProvider.GetOrderMainById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_7954da8b922f4cb9722c2ebf9e20dca0 _tmp = new RL_7954da8b922f4cb9722c2ebf9e20dca0();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderMainByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query UploadDocumentOrderByProvider.GetOrderMainById.List", cancellationToken: cancellationToken);
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
