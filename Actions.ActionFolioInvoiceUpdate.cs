namespace ssConectaProveedores;

public partial class Actions {
public class lcvFolioInvoiceUpdate : VarsBag {
public long inParami_FolioId;
public string inParami_Comments;
public RL_1501ee54ff868a67eff67465502ee3d9 inParamFilesListExtra;
public RL_1501ee54ff868a67eff67465502ee3d9 inParamFilesList;
public RL_1501ee54ff868a67eff67465502ee3d9 inParamCreditNoteFilesList;
public EN_d1d0320db36efbb094ad0082361435a0EntityRecord inParamInvoiceToCreate;
public ST_6f620840109ac6f721328b723ec0152cStructure inParamInvoiceForeignToCreate;
public decimal inParamImportAnticipo;
public int inParamOffsetUtc;
public string inParami_UpdateComment;
public bool inParami_HaveNewFiles;
public string inParami_NewFileNamesUploaded;
public RL_897c95bca5499c293930e47bf793d0d9 queryResGetFolioFilesByFolioId_outParamList = new RL_897c95bca5499c293930e47bf793d0d9();
public long queryResGetFolioFilesByFolioId_outParamCount = 0L;

public RL_4f8b259bdd04db22be8fb771f1ad1d4f queryResGetFolioById_outParamList = new RL_4f8b259bdd04db22be8fb771f1ad1d4f();
public long queryResGetFolioById_outParamCount = 0L;

public Actions.lcoOrderLogAdd resOrderLogAdd =  new Actions.lcoOrderLogAdd();
public Actions.lcoFolioLogAdd resFolioLogAdd =  new Actions.lcoFolioLogAdd();
public RL_ff28012de5324af3e81e5ace09ecb1f0 queryResGetInvoiceFiles_outParamList = new RL_ff28012de5324af3e81e5ace09ecb1f0();
public long queryResGetInvoiceFiles_outParamCount = 0L;

public Actions.lcoUploadInvoiceFiles_WithCN resUploadInvoiceFiles_WithCN =  new Actions.lcoUploadInvoiceFiles_WithCN();
public long resCreateFolioObservations_outParamId = 0L;

public lcvFolioInvoiceUpdate(long inParami_FolioId, string inParami_Comments, RL_1501ee54ff868a67eff67465502ee3d9 inParamFilesListExtra, RL_1501ee54ff868a67eff67465502ee3d9 inParamFilesList, RL_1501ee54ff868a67eff67465502ee3d9 inParamCreditNoteFilesList, EN_d1d0320db36efbb094ad0082361435a0EntityRecord inParamInvoiceToCreate, ST_6f620840109ac6f721328b723ec0152cStructure inParamInvoiceForeignToCreate, decimal inParamImportAnticipo, int inParamOffsetUtc, string inParami_UpdateComment, bool inParami_HaveNewFiles, string inParami_NewFileNamesUploaded) {
this.inParami_FolioId = inParami_FolioId;
this.inParami_Comments = inParami_Comments;
this.inParamFilesListExtra = inParamFilesListExtra;
this.inParamFilesList = inParamFilesList;
this.inParamCreditNoteFilesList = inParamCreditNoteFilesList;
this.inParamInvoiceToCreate = inParamInvoiceToCreate;
this.inParamInvoiceForeignToCreate = inParamInvoiceForeignToCreate;
this.inParamImportAnticipo = inParamImportAnticipo;
this.inParamOffsetUtc = inParamOffsetUtc;
this.inParami_UpdateComment = inParami_UpdateComment;
this.inParami_HaveNewFiles = inParami_HaveNewFiles;
this.inParami_NewFileNamesUploaded = inParami_NewFileNamesUploaded;
}
}
public class lcoFolioInvoiceUpdate : VarsBag {
public string outParamErrorMsg = "";

public string outParamo_FolioName = "";

public bool outParamIsMissingCreditNote = false;

public lcoFolioInvoiceUpdate() {
}
}
/// <summary>
/// Action <code>FolioInvoiceUpdate</code> that represents the Service Studio action
///  <code>FolioInvoiceUpdate</code> <p> Description: </p>
/// </summary>
public static async Task<(string,string,bool)> ActionFolioInvoiceUpdate(IRequestContext requestContext,long inParami_FolioId,string inParami_Comments,RL_1501ee54ff868a67eff67465502ee3d9 inParamFilesListExtra,RL_1501ee54ff868a67eff67465502ee3d9 inParamFilesList,RL_1501ee54ff868a67eff67465502ee3d9 inParamCreditNoteFilesList,EN_d1d0320db36efbb094ad0082361435a0EntityRecord inParamInvoiceToCreate,ST_6f620840109ac6f721328b723ec0152cStructure inParamInvoiceForeignToCreate,decimal inParamImportAnticipo,int inParamOffsetUtc,string inParami_UpdateComment,bool inParami_HaveNewFiles,string inParami_NewFileNamesUploaded,CancellationToken cancellationToken) {
string outParamErrorMsg = default;
string outParamo_FolioName = default;
bool outParamIsMissingCreditNote = default;
lcoFolioInvoiceUpdate result = new lcoFolioInvoiceUpdate();
lcvFolioInvoiceUpdate localVars = new lcvFolioInvoiceUpdate(inParami_FolioId, inParami_Comments, inParamFilesListExtra, inParamFilesList, inParamCreditNoteFilesList, inParamInvoiceToCreate, inParamInvoiceForeignToCreate, inParamImportAnticipo, inParamOffsetUtc, inParami_UpdateComment, inParami_HaveNewFiles, inParami_NewFileNamesUploaded);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("FolioInvoiceUpdate", "7d259969-175b-4999-b864-42022ea3a022"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("FolioInvoiceUpdate", "7d259969-175b-4999-b864-42022ea3a022", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetFolioById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioById_maxRecords = 0;
int datasetGetFolioById_startIndex = 0;(localVars.queryResGetFolioById_outParamList,localVars.queryResGetFolioById_outParamCount) = await FuncActionFolioInvoiceUpdate.datasetGetFolioById(requestContext,datasetGetFolioById_maxRecords,datasetGetFolioById_startIndex,IterationMultiplicity.Never,localVars.inParami_FolioId,(await Functions.ActionGetUserSupplier(requestContext,"",cancellationToken)),cancellationToken);

if(((localVars.queryResGetFolioById_outParamList.Empty||(localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssFolioStatusId!=(ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("OvBzn51W8EyWJHs2cALRmQ"))).ssId)))) {
// RaiseError FileInvalid
throw new Ex_FileInvalidUserException (AppUtils.GetStringResource("KT+9QeurnkGDBzBcMzqLIw#Message.1911675613.1", "Folio cannot be updated!"));

} else {
if(((BuiltInFunction.Trim (localVars.inParami_Comments)!=""))) {
// CreateFolioObservations
localVars.resCreateFolioObservations_outParamId = await ExtendedActions.CreateFolioObservations(requestContext,new RC_017cba02e4fd7f684606081b7269a26b(){ ssENFolioObservations = new EN_171b22187ea6e4b12c9f086502740307EntityRecord(){ ssFolioId = localVars.inParami_FolioId, ssObservation = localVars.inParami_Comments, ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime () } },cancellationToken);

}

// o_FolioName = GetFolioById.List.Current.Folio.FolioNumber
result.outParamo_FolioName=localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssFolioNumber;
// Query datasetGetInvoiceFiles
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceFiles_maxRecords = 0;
int datasetGetInvoiceFiles_startIndex = 0;(localVars.queryResGetInvoiceFiles_outParamList,localVars.queryResGetInvoiceFiles_outParamCount) = await FuncActionFolioInvoiceUpdate.datasetGetInvoiceFiles(requestContext,datasetGetInvoiceFiles_maxRecords,datasetGetInvoiceFiles_startIndex,IterationMultiplicity.Never,localVars.inParami_FolioId,cancellationToken);

// empty
if((localVars.queryResGetInvoiceFiles_outParamList.Empty)) {
// RaiseError FileInvalid
throw new Ex_FileInvalidUserException (((AppUtils.GetStringResource("973nf7cIgE6tiygUo6RYXw#Message.-1617437822.1", "No Invoice found for Folio")+": ")+BuiltInFunction.LongIntegerToText(localVars.inParami_FolioId)));

} else {
// Is construction?
if(((localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssApprovalProcessTypeId==1))) {
// Query datasetGetFolioFilesByFolioId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioFilesByFolioId_maxRecords = 0;
int datasetGetFolioFilesByFolioId_startIndex = 0;(localVars.queryResGetFolioFilesByFolioId_outParamList,localVars.queryResGetFolioFilesByFolioId_outParamCount) = await FuncActionFolioInvoiceUpdate.datasetGetFolioFilesByFolioId(requestContext,datasetGetFolioFilesByFolioId_maxRecords,datasetGetFolioFilesByFolioId_startIndex,IterationMultiplicity.Multiple,localVars.inParami_FolioId,cancellationToken);

// ListClear
await ExtendedActions.ListClear(requestContext,localVars.inParamFilesListExtra,cancellationToken);

// ListAppendAll
await ExtendedActions.ListAppendAll(requestContext,localVars.inParamFilesListExtra,(await RL_1501ee54ff868a67eff67465502ee3d9.ConvertAsync(localVars.queryResGetFolioFilesByFolioId_outParamList, new RL_1501ee54ff868a67eff67465502ee3d9(), async (RC_28fdb7a8aef891dc921c5fe34393a569 source, ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure target, CancellationToken cancellationToken) => {
target.ssName = source.ssENFolioFiles.ssFilename;
target.ssBinaryData = BuiltInFunction.NullBinary ();
target.ssIsExtra = source.ssENFolioFiles.ssIsExtra;
target.ssStorageId = source.ssENFolioFiles.ssStorageId;
return target;
}, cancellationToken)),cancellationToken);

}

// UploadInvoiceFiles_WithCN
(localVars.resUploadInvoiceFiles_WithCN.outParamErrorMsg,localVars.resUploadInvoiceFiles_WithCN.outParamo_Invoice,localVars.resUploadInvoiceFiles_WithCN.outParamo_InvoiceExtended,localVars.resUploadInvoiceFiles_WithCN.outParamClaveProdServ,localVars.resUploadInvoiceFiles_WithCN.outParamTipoComprobante,localVars.resUploadInvoiceFiles_WithCN.outParamIsMissingCreditNote) = await Actions.ActionUploadInvoiceFiles_WithCN(requestContext,localVars.queryResGetInvoiceFiles_outParamList.CurrentRec.ssENInvoice.ssId,Convert.ToInt64(BuiltInFunction.NullIdentifier ()),localVars.queryResGetInvoiceFiles_outParamList.CurrentRec.ssENInvoice.ssOrderMainId,localVars.inParami_FolioId,(await RL_7b4ceb84b6a1255d3a42c8932279bc3c.ConvertAsync(localVars.inParamFilesList, new RL_7b4ceb84b6a1255d3a42c8932279bc3c(), async (ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure source, ST_7837994e68174a4794f15e4233b48555Structure target, CancellationToken cancellationToken) => {
target.ssName = source.ssName;
target.ssBinaryData = source.ssBinaryData;
target.ssStorageId = source.ssStorageId;
return target;
}, cancellationToken)),(await RL_7b4ceb84b6a1255d3a42c8932279bc3c.ConvertAsync(localVars.inParamFilesListExtra, new RL_7b4ceb84b6a1255d3a42c8932279bc3c(), async (ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure source, ST_7837994e68174a4794f15e4233b48555Structure target, CancellationToken cancellationToken) => {
target.ssName = source.ssName;
target.ssBinaryData = source.ssBinaryData;
target.ssStorageId = source.ssStorageId;
return target;
}, cancellationToken)),(await RL_7b4ceb84b6a1255d3a42c8932279bc3c.ConvertAsync(localVars.inParamCreditNoteFilesList, new RL_7b4ceb84b6a1255d3a42c8932279bc3c(), async (ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure source, ST_7837994e68174a4794f15e4233b48555Structure target, CancellationToken cancellationToken) => {
target.ssName = source.ssName;
target.ssBinaryData = source.ssBinaryData;
target.ssStorageId = source.ssStorageId;
return target;
}, cancellationToken)),false,localVars.inParamInvoiceForeignToCreate,(((decimal)0)),false,false,(((localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssApprovalProcessTypeId==1)) ? (3) : (BuiltInFunction.NullIdentifier ())),localVars.inParamInvoiceToCreate.ssOrderAccConceptsID,localVars.inParamImportAnticipo,0L,localVars.inParamOffsetUtc,(localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssApprovalProcessTypeId==1),cancellationToken);

// Error?
if((((localVars.resUploadInvoiceFiles_WithCN.outParamErrorMsg!="")||localVars.resUploadInvoiceFiles_WithCN.outParamIsMissingCreditNote))) {
// IsMissingCreditNote = UploadInvoiceFiles_WithCN.IsMissingCreditNote
result.outParamIsMissingCreditNote=localVars.resUploadInvoiceFiles_WithCN.outParamIsMissingCreditNote;
// RaiseError FileInvalid
throw new Ex_FileInvalidUserException ((((localVars.resUploadInvoiceFiles_WithCN.outParamErrorMsg!="")) ? (localVars.resUploadInvoiceFiles_WithCN.outParamErrorMsg) : ("This request requires a credit note to proceed.")));

} else {
// OrderLogAdd
localVars.resOrderLogAdd.outParamId = await Actions.ActionOrderLogAdd(requestContext,new EN_a8e484428097204171df8a1feecb2534EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssOrderId = localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssOrderId, ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssMessage = ((((AppUtils.GetStringResource("0d_fKS2n4kqFCx+SdhGApA#Value.-1106119175.1", "The supplier updated the folio number")+": ")+localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssFolioNumber)+".")+(((localVars.inParami_UpdateComment!="")) ? ((((" "+AppUtils.GetStringResource("0d_fKS2n4kqFCx+SdhGApA#Value.-1679915457.1", "Comment"))+": ")+localVars.inParami_UpdateComment)) : (""))) },cancellationToken);

// FolioLogAdd
localVars.resFolioLogAdd.outParamId = await Actions.ActionFolioLogAdd(requestContext,new EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssFolioId = localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssId, ssMessage = (((((AppUtils.GetStringResource("U2rNshU88UO7fUQ9+bvwJA#Value.-1106119175.1", "The supplier updated the folio number")+": ")+localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssFolioNumber)+".")+((localVars.inParami_HaveNewFiles) ? (((((" "+AppUtils.GetStringResource("U2rNshU88UO7fUQ9+bvwJA#Value.-94572617.1", "New Files"))+": ")+localVars.inParami_NewFileNamesUploaded)+".")) : ("")))+(((localVars.inParami_UpdateComment!="")) ? (((((" "+AppUtils.GetStringResource("U2rNshU88UO7fUQ9+bvwJA#Value.-1679915457.1", "Comment"))+": ")+localVars.inParami_UpdateComment)+".")) : (""))), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssIsForSupplier = true },cancellationToken);

// FolioResetApprovProcess
await Actions.ActionFolioResetApprovProcess(requestContext,localVars.inParami_FolioId,cancellationToken);

{
    using (AppHealthProvider.CreateGlobalEventTriggerMetric("OnSendFolioNextApproverEmail", "029a8006-0e98-4d71-85bf-50d9332e5c18"))
    using (activitySource.CreateTriggerEventActivity("OnSendFolioNextApproverEmail", "029a8006-0e98-4d71-85bf-50d9332e5c18", "a3d02dd1-e313-409d-837e-fd413ba4d509", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828")) {
        var input = new EventPayloads.GlobalEventOnSendFolioNextApproverEmailPayload() {inParami_FolioId = localVars.inParami_FolioId};

        var eventPublisher = ServiceLocator.GetService<IEventPublisher>();
        await eventPublisher.PublishEventAsync("OnSendFolioNextApproverEmail", "a3d02dd1-e313-409d-837e-fd413ba4d509", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828", input, cancellationToken);
    }
}

}

}

}

} //close CreateActionActivity using block
} // try

catch (Ex_FileInvalidUserException ex) {
ApplicationLogger.Error(ex, "Error executing action");
requestContext.LastException = ex;

// Error Handler
await DatabaseAccess.RollbackAllTransactionsAsync(cancellationToken);

// ErrorMsg = FileInvalid.ExceptionMessage
result.outParamErrorMsg=ex.Message;
goto RETURN_STATEMENT;

} // Catch
finally {
outParamErrorMsg = result.outParamErrorMsg;
outParamo_FolioName = result.outParamo_FolioName;
outParamIsMissingCreditNote = result.outParamIsMissingCreditNote;
cancellationToken.ThrowIfCancellationRequested();
} // inner-finally
RETURN_STATEMENT:
return (outParamErrorMsg,outParamo_FolioName,outParamIsMissingCreditNote);
}

public static class FuncActionFolioInvoiceUpdate {

// Query Function "GetFolioFilesByFolioId" PP7gEs2Id0KHe+Xs0Ktaww of Action "FolioInvoiceUpdate"
public static async Task<(RL_897c95bca5499c293930e47bf793d0d9,long)> datasetGetFolioFilesByFolioId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolioId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("FolioInvoiceUpdate.GetFolioFilesByFolioId", "12e0fe3c-88cd-4277-877b-e5ecd0ab5ac3");
using var queryActivity = activitySource.CreateAggregateQueryActivity("FolioInvoiceUpdate.GetFolioFilesByFolioId", "12e0fe3c-88cd-4277-877b-e5ecd0ab5ac3", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Multiple
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
selectBuilder.Append("/* /UserActions.aZklfVsXmUm4ZEICLqOgIg/NodesNotShownInESpaceTree.PP7gEs2Id0KHe+Xs0Ktaww, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enfoliofiles3\".\"filename\" o1, NULL o2, \"enfoliofiles3\".\"isextra\" o3, \"enfoliofiles3\".\"storageid\" o4, NULL o5, NULL o6, NULL o7");
fromBuilder.Append(" FROM {FolioFiles} \"enfoliofiles3\"");
whereBuilder.Append(" WHERE ");
if (qpfoFolioId != 0) {
whereBuilder.Append("((\"enfoliofiles3\".\"folioid\" = @qpfoFolioId) AND (\"enfoliofiles3\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioId", DbType.Int64, qpfoFolioId);
} else {
whereBuilder.Append("(\"enfoliofiles3\".\"folioid\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"enfoliofiles3\".\"filename\" ASC ");
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
RL_897c95bca5499c293930e47bf793d0d9 outParamList = new RL_897c95bca5499c293930e47bf793d0d9();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, false, true, false, false, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query FolioInvoiceUpdate.GetFolioFilesByFolioId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_897c95bca5499c293930e47bf793d0d9 _tmp = new RL_897c95bca5499c293930e47bf793d0d9();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query FolioInvoiceUpdate.GetFolioFilesByFolioId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_897c95bca5499c293930e47bf793d0d9)_tmp;
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

// Query Function "GetFolioById" +0jrF79YKk6YjpHbl_TkKA of Action "FolioInvoiceUpdate"
public static async Task<(RL_4f8b259bdd04db22be8fb771f1ad1d4f,long)> datasetGetFolioById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoId,long qpsuSupplierId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("FolioInvoiceUpdate.GetFolioById", "17eb48fb-58bf-4e2a-988e-91db97f4e428");
using var queryActivity = activitySource.CreateAggregateQueryActivity("FolioInvoiceUpdate.GetFolioById", "17eb48fb-58bf-4e2a-988e-91db97f4e428", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.aZklfVsXmUm4ZEICLqOgIg/NodesNotShownInESpaceTree.+0jrF79YKk6YjpHbl_TkKA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enfolio25\".\"id\" o0, NULL o1, \"enfolio25\".\"folionumber\" o2, NULL o3, \"enfolio25\".\"orderid\" o4, NULL o5, NULL o6, \"enfolio25\".\"foliostatusid\" o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, \"enfolio25\".\"approvalprocesstypeid\" o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19");
fromBuilder.Append(" FROM {Folio} \"enfolio25\"");
whereBuilder.Append(" WHERE ");
if (qpfoId != 0) {
whereBuilder.Append("((\"enfolio25\".\"id\" = @qpfoId) AND (\"enfolio25\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoId", DbType.Int64, qpfoId);
} else {
whereBuilder.Append("(\"enfolio25\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ");
if (qpsuSupplierId != 0) {
whereBuilder.Append("((\"enfolio25\".\"supplierid\" = @qpsuSupplierId) AND (\"enfolio25\".\"supplierid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuSupplierId", DbType.Int64, qpsuSupplierId);
} else {
whereBuilder.Append("(\"enfolio25\".\"supplierid\" IS NULL)");
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
RL_4f8b259bdd04db22be8fb771f1ad1d4f outParamList = new RL_4f8b259bdd04db22be8fb771f1ad1d4f();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, false, true, false, true, true, false, true, true, true, true, true, false, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query FolioInvoiceUpdate.GetFolioById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_4f8b259bdd04db22be8fb771f1ad1d4f _tmp = new RL_4f8b259bdd04db22be8fb771f1ad1d4f();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query FolioInvoiceUpdate.GetFolioById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_4f8b259bdd04db22be8fb771f1ad1d4f)_tmp;
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

private static async Task<RC_2b77a78552d1dad3876c3ebd8f5c8ec1> datasetGetInvoiceFilesReadDbAsync(RC_2b77a78552d1dad3876c3ebd8f5c8ec1 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceFile.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceFiles" QGxWh2wjxk+n5Pb9_9Pjyg of Action "FolioInvoiceUpdate"
public static async Task<(RL_ff28012de5324af3e81e5ace09ecb1f0,long)> datasetGetInvoiceFiles(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoInvoice_FolioId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("FolioInvoiceUpdate.GetInvoiceFiles", "87566c40-236c-4fc6-a7e4-f6fdffd3e3ca");
using var queryActivity = activitySource.CreateAggregateQueryActivity("FolioInvoiceUpdate.GetInvoiceFiles", "87566c40-236c-4fc6-a7e4-f6fdffd3e3ca", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.aZklfVsXmUm4ZEICLqOgIg/NodesNotShownInESpaceTree.QGxWh2wjxk+n5Pb9_9Pjyg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoice31\".\"id\" o0, NULL o1, NULL o2, NULL o3, \"eninvoice31\".\"ordermainid\" o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31");
fromBuilder.Append(" FROM ({Invoice} \"eninvoice31\" Inner JOIN {InvoiceFile} \"eninvoicefile9\" ON (\"eninvoice31\".\"id\" = \"eninvoicefile9\".\"invoiceid\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoInvoice_FolioId != 0) {
whereBuilder.Append("((\"eninvoice31\".\"folioid\" = @qpfoInvoice_FolioId) AND (\"eninvoice31\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoInvoice_FolioId", DbType.Int64, qpfoInvoice_FolioId);
} else {
whereBuilder.Append("(\"eninvoice31\".\"folioid\" IS NULL)");
}
whereBuilder.Append(" AND (\"eninvoicefile9\".\"isextra\" = 0)");
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
RL_ff28012de5324af3e81e5ace09ecb1f0 outParamList = new RL_ff28012de5324af3e81e5ace09ecb1f0();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoiceFilesReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query FolioInvoiceUpdate.GetInvoiceFiles.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_ff28012de5324af3e81e5ace09ecb1f0 _tmp = new RL_ff28012de5324af3e81e5ace09ecb1f0();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoiceFilesReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query FolioInvoiceUpdate.GetInvoiceFiles.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_ff28012de5324af3e81e5ace09ecb1f0)_tmp;
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
