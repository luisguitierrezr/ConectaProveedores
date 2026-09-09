namespace ssConectaProveedores;

public partial class Actions {
public class lcvSubstituteFolioFiles_v2 : VarsBag {
public long inParamFolioId;
public bool inParamIsconstruction;
public RL_1501ee54ff868a67eff67465502ee3d9 inParamFilesList;
public RL_1501ee54ff868a67eff67465502ee3d9 inParamFilesListExtra;
public RL_1501ee54ff868a67eff67465502ee3d9 inParamCreditNoteFilesList;
public long inParami_OrderAccConceptID;
public ST_6f620840109ac6f721328b723ec0152cStructure inParamInvoiceForeignToCreate;
public decimal inParamImportAnticipo;
public int inParamOffsetUtc;
public RL_1501ee54ff868a67eff67465502ee3d9 resListFilter_outParamFilteredList = new RL_1501ee54ff868a67eff67465502ee3d9();

public RL_ff28012de5324af3e81e5ace09ecb1f0 queryResGetInvoiceFiles_outParamList = new RL_ff28012de5324af3e81e5ace09ecb1f0();
public long queryResGetInvoiceFiles_outParamCount = 0L;

public Actions.lcoUploadInvoiceFiles_WithCN resUploadInvoiceFiles_WithCN =  new Actions.lcoUploadInvoiceFiles_WithCN();
public lcvSubstituteFolioFiles_v2(long inParamFolioId, bool inParamIsconstruction, RL_1501ee54ff868a67eff67465502ee3d9 inParamFilesList, RL_1501ee54ff868a67eff67465502ee3d9 inParamFilesListExtra, RL_1501ee54ff868a67eff67465502ee3d9 inParamCreditNoteFilesList, long inParami_OrderAccConceptID, ST_6f620840109ac6f721328b723ec0152cStructure inParamInvoiceForeignToCreate, decimal inParamImportAnticipo, int inParamOffsetUtc) {
this.inParamFolioId = inParamFolioId;
this.inParamIsconstruction = inParamIsconstruction;
this.inParamFilesList = inParamFilesList;
this.inParamFilesListExtra = inParamFilesListExtra;
this.inParamCreditNoteFilesList = inParamCreditNoteFilesList;
this.inParami_OrderAccConceptID = inParami_OrderAccConceptID;
this.inParamInvoiceForeignToCreate = inParamInvoiceForeignToCreate;
this.inParamImportAnticipo = inParamImportAnticipo;
this.inParamOffsetUtc = inParamOffsetUtc;
}
}
public class lcoSubstituteFolioFiles_v2 : VarsBag {
public string outParamErrorMsg = "";

public lcoSubstituteFolioFiles_v2() {
}
}
/// <summary>
/// Action <code>SubstituteFolioFiles_v2</code> that represents the Service Studio action
///  <code>SubstituteFolioFiles_v2</code> <p> Description: </p>
/// </summary>
public static async Task<string> ActionSubstituteFolioFiles_v2(IRequestContext requestContext,long inParamFolioId,bool inParamIsconstruction,RL_1501ee54ff868a67eff67465502ee3d9 inParamFilesList,RL_1501ee54ff868a67eff67465502ee3d9 inParamFilesListExtra,RL_1501ee54ff868a67eff67465502ee3d9 inParamCreditNoteFilesList,long inParami_OrderAccConceptID,ST_6f620840109ac6f721328b723ec0152cStructure inParamInvoiceForeignToCreate,decimal inParamImportAnticipo,int inParamOffsetUtc,CancellationToken cancellationToken) {
string outParamErrorMsg = default;
lcoSubstituteFolioFiles_v2 result = new lcoSubstituteFolioFiles_v2();
lcvSubstituteFolioFiles_v2 localVars = new lcvSubstituteFolioFiles_v2(inParamFolioId, inParamIsconstruction, inParamFilesList, inParamFilesListExtra, inParamCreditNoteFilesList, inParami_OrderAccConceptID, inParamInvoiceForeignToCreate, inParamImportAnticipo, inParamOffsetUtc);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("SubstituteFolioFiles_v2", "5cf4bf91-e6b2-4cd6-b36a-5733d79c7d2c"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("SubstituteFolioFiles_v2", "5cf4bf91-e6b2-4cd6-b36a-5733d79c7d2c", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
if((localVars.inParamIsconstruction)) {
// SubstituteFolioFiles_v2_Construction
await Actions.ActionSubstituteFolioFiles_v2_Construction(requestContext,localVars.inParamFolioId,localVars.inParamFilesListExtra,cancellationToken);

} else {
// Query datasetGetInvoiceFiles
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceFiles_maxRecords = 0;
int datasetGetInvoiceFiles_startIndex = 0;(localVars.queryResGetInvoiceFiles_outParamList,localVars.queryResGetInvoiceFiles_outParamCount) = await FuncActionSubstituteFolioFiles_v2.datasetGetInvoiceFiles(requestContext,datasetGetInvoiceFiles_maxRecords,datasetGetInvoiceFiles_startIndex,IterationMultiplicity.Never,localVars.inParamFolioId,cancellationToken);

// empty
if((localVars.queryResGetInvoiceFiles_outParamList.Empty)) {
// RaiseError FileInvalid
throw new Ex_FileInvalidUserException (((AppUtils.GetStringResource("LXQKs9NzNEyCbLoB9sA4sw#Message.-1617437822.1", "No Invoice found for Folio")+": ")+BuiltInFunction.LongIntegerToText(localVars.inParamFolioId)));

} else {
// ListFilter
localVars.resListFilter_outParamFilteredList = (((RL_1501ee54ff868a67eff67465502ee3d9)await  localVars.inParamFilesList.FilterAsync(async (p, cancellationToken) => (p.ssStorageId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())), cancellationToken)));

// No Main Files Changed
if((localVars.resListFilter_outParamFilteredList.Empty)) {
// SubstitutoFolioFiles_v2_Extra
await Actions.ActionSubstitutoFolioFiles_v2_Extra(requestContext,localVars.inParamFolioId,localVars.inParamFilesListExtra,localVars.queryResGetInvoiceFiles_outParamList.CurrentRec.ssENInvoice.ssId,cancellationToken);

} else {
// UploadInvoiceFiles_WithCN
(localVars.resUploadInvoiceFiles_WithCN.outParamErrorMsg,localVars.resUploadInvoiceFiles_WithCN.outParamo_Invoice,localVars.resUploadInvoiceFiles_WithCN.outParamo_InvoiceExtended,localVars.resUploadInvoiceFiles_WithCN.outParamClaveProdServ,localVars.resUploadInvoiceFiles_WithCN.outParamTipoComprobante,localVars.resUploadInvoiceFiles_WithCN.outParamIsMissingCreditNote) = await Actions.ActionUploadInvoiceFiles_WithCN(requestContext,localVars.queryResGetInvoiceFiles_outParamList.CurrentRec.ssENInvoice.ssId,Convert.ToInt64(BuiltInFunction.NullIdentifier ()),localVars.queryResGetInvoiceFiles_outParamList.CurrentRec.ssENInvoice.ssOrderMainId,localVars.inParamFolioId,(await RL_7b4ceb84b6a1255d3a42c8932279bc3c.ConvertAsync(localVars.inParamFilesList, new RL_7b4ceb84b6a1255d3a42c8932279bc3c(), async (ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure source, ST_7837994e68174a4794f15e4233b48555Structure target, CancellationToken cancellationToken) => {
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
}, cancellationToken)),false,localVars.inParamInvoiceForeignToCreate,(((decimal)0)),false,false,0,localVars.inParami_OrderAccConceptID,localVars.inParamImportAnticipo,0L,localVars.inParamOffsetUtc,localVars.inParamIsconstruction,cancellationToken);

// error?
if(((localVars.resUploadInvoiceFiles_WithCN.outParamErrorMsg!=""))) {
// ErrorMsg = UploadInvoiceFiles_WithCN.ErrorMsg
result.outParamErrorMsg=localVars.resUploadInvoiceFiles_WithCN.outParamErrorMsg;
// RaiseError FileInvalid
throw new Ex_FileInvalidUserException (localVars.resUploadInvoiceFiles_WithCN.outParamErrorMsg);

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
cancellationToken.ThrowIfCancellationRequested();
} // inner-finally
RETURN_STATEMENT:
return outParamErrorMsg;
}

public static class FuncActionSubstituteFolioFiles_v2 {

private static async Task<RC_2b77a78552d1dad3876c3ebd8f5c8ec1> datasetGetInvoiceFilesReadDbAsync(RC_2b77a78552d1dad3876c3ebd8f5c8ec1 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceFile.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceFiles" QIPnc0z5ikqP77UB2bbGvQ of Action "SubstituteFolioFiles_v2"
public static async Task<(RL_ff28012de5324af3e81e5ace09ecb1f0,long)> datasetGetInvoiceFiles(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoInvoice_FolioId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SubstituteFolioFiles_v2.GetInvoiceFiles", "73e78340-f94c-4a8a-8fef-b501d9b6c6bd");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SubstituteFolioFiles_v2.GetInvoiceFiles", "73e78340-f94c-4a8a-8fef-b501d9b6c6bd", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.kb_0XLLm1kyzalcz15x9LA/NodesNotShownInESpaceTree.QIPnc0z5ikqP77UB2bbGvQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoice21\".\"id\" o0, NULL o1, NULL o2, NULL o3, \"eninvoice21\".\"ordermainid\" o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31");
fromBuilder.Append(" FROM ({Invoice} \"eninvoice21\" Inner JOIN {InvoiceFile} \"eninvoicefile5\" ON (\"eninvoice21\".\"id\" = \"eninvoicefile5\".\"invoiceid\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoInvoice_FolioId != 0) {
whereBuilder.Append("((\"eninvoice21\".\"folioid\" = @qpfoInvoice_FolioId) AND (\"eninvoice21\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoInvoice_FolioId", DbType.Int64, qpfoInvoice_FolioId);
} else {
whereBuilder.Append("(\"eninvoice21\".\"folioid\" IS NULL)");
}
whereBuilder.Append(" AND (\"eninvoicefile5\".\"isextra\" = 0)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SubstituteFolioFiles_v2.GetInvoiceFiles.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SubstituteFolioFiles_v2.GetInvoiceFiles.List", cancellationToken: cancellationToken);
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
