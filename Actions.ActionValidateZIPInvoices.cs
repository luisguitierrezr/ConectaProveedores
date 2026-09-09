namespace ssConectaProveedores;

public partial class Actions {
public class lcvValidateZIPInvoices : VarsBag {
public ST_1d6498da9105fbe815a7f766352917c0Structure inParami_File;
public object resLoadZIP_outParamZIPHandle = null;

public RLFileRecordList resListFilterPDF_outParamFilteredList = new RLFileRecordList();

public RLFileRecordList resListFilterXML_outParamFilteredList = new RLFileRecordList();

public RL_08f794aa2125354ca78c75fb19e7e496 queryResGetFiles2_outParamList = new RL_08f794aa2125354ca78c75fb19e7e496();
public long queryResGetFiles2_outParamCount = 0L;

public RLFileRecordList resGetFiles_outParamFileList = new RLFileRecordList();

public lcvValidateZIPInvoices(ST_1d6498da9105fbe815a7f766352917c0Structure inParami_File) {
this.inParami_File = inParami_File;
}
}
public class lcoValidateZIPInvoices : VarsBag {
public ST_5478c3bb197e3019856d4a634c17d91dStructure outParamMultiUploadInvoiceFileStruct = new ST_5478c3bb197e3019856d4a634c17d91dStructure();

public lcoValidateZIPInvoices() {
}
}
/// <summary>
/// Action <code>ValidateZIPInvoices</code> that represents the Service Studio action
///  <code>ValidateZIPInvoices</code> <p> Description: </p>
/// </summary>
public static async Task<ST_5478c3bb197e3019856d4a634c17d91dStructure> ActionValidateZIPInvoices(IRequestContext requestContext,ST_1d6498da9105fbe815a7f766352917c0Structure inParami_File,CancellationToken cancellationToken) {
ST_5478c3bb197e3019856d4a634c17d91dStructure outParamMultiUploadInvoiceFileStruct = default;
lcoValidateZIPInvoices result = new lcoValidateZIPInvoices();
lcvValidateZIPInvoices localVars = new lcvValidateZIPInvoices(inParami_File);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("ValidateZIPInvoices", "f42db43b-4785-4a2a-83be-436d039a08bd"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("ValidateZIPInvoices", "f42db43b-4785-4a2a-83be-436d039a08bd", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// MultiUploadInvoiceFileStruct.Name = i_File.FileName
result.outParamMultiUploadInvoiceFileStruct.ssName = localVars.inParami_File.ssFileName;

// MultiUploadInvoiceFileStruct.BinaryDataZIP = i_File.FileContent
result.outParamMultiUploadInvoiceFileStruct.ssBinaryDataZIP = localVars.inParami_File.ssFileContent;
// dif mimetype?
if((((((localVars.inParami_File.ssFileMimeType!="application/zip")&&(localVars.inParami_File.ssFileMimeType!="application/vnd.rar"))&&(localVars.inParami_File.ssFileMimeType!="application/x-rar-compressed"))&&(localVars.inParami_File.ssFileMimeType!="application/x-zip-compressed")))) {
// MultiUploadInvoiceFileStruct.ErrorMsg = "only .zip and .rar files are allowed" + "- mimetype"
result.outParamMultiUploadInvoiceFileStruct.ssErrorMsg = (AppUtils.GetStringResource("L_7Xm472oUCq9LbEIJKOJg#Value.-1699112566.1", "only .zip and .rar files are allowed")+"- mimetype");
} else {
if(((localVars.inParami_File.ssFileBigFileId!=Convert.ToInt64(0)))) {
// Query datasetGetFiles2
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFiles2_maxRecords = 0;
int datasetGetFiles2_startIndex = 0;(localVars.queryResGetFiles2_outParamList,localVars.queryResGetFiles2_outParamCount) = await FuncActionValidateZIPInvoices.datasetGetFiles2(requestContext,datasetGetFiles2_maxRecords,datasetGetFiles2_startIndex,IterationMultiplicity.Never,localVars.inParami_File.ssFileBigFileId,cancellationToken);

// i_File.FileContent = GetFiles2.List.Current.File3.Binary
localVars.inParami_File.ssFileContent = localVars.queryResGetFiles2_outParamList.CurrentRec.ssENFile3.ssBinary;
}

// LoadZIP
localVars.resLoadZIP_outParamZIPHandle = await Actions.ActionLoadZIP(requestContext,localVars.inParami_File.ssFileContent,"",cancellationToken);

// GetFiles
localVars.resGetFiles_outParamFileList = await Actions.ActionGetFiles(requestContext,localVars.resLoadZIP_outParamZIPHandle,cancellationToken);

// more than 2?
if(((localVars.resGetFiles_outParamFileList.Length>2))) {
// MultiUploadInvoiceFileStruct.ErrorMsg = "only 2 files are allowed" + "- file nr"
result.outParamMultiUploadInvoiceFileStruct.ssErrorMsg = (AppUtils.GetStringResource("fJWqz_DB10a+gunLCnKpQQ#Value.-851072815.1", "only 2 files are allowed")+"- file nr");
} else {
// ListFilterXML
localVars.resListFilterXML_outParamFilteredList = (((RLFileRecordList)await  localVars.resGetFiles_outParamFileList.FilterAsync(async (p, cancellationToken) => (BuiltInFunction.IndexSC (BuiltInFunction.ToUpper (p.ssSTFile2.ssName), ".XML", 0, false, false)!=(-1)), cancellationToken)));

// no xml?
if((localVars.resListFilterXML_outParamFilteredList.Empty)) {
// MultiUploadInvoiceFileStruct.ErrorMsg = "xml not found" + "- xml miss"
result.outParamMultiUploadInvoiceFileStruct.ssErrorMsg = (AppUtils.GetStringResource("ACCzl9YJ4Eet8RLL_pY5FA#Value.1652666156.1", "xml not found")+"- xml miss");
} else {
// ListFilterPDF
localVars.resListFilterPDF_outParamFilteredList = (((RLFileRecordList)await  localVars.resGetFiles_outParamFileList.FilterAsync(async (p, cancellationToken) => (BuiltInFunction.IndexSC (BuiltInFunction.ToUpper (p.ssSTFile2.ssName), ".PDF", 0, false, false)!=(-1)), cancellationToken)));

// no pdf?
if((localVars.resListFilterPDF_outParamFilteredList.Empty)) {
// MultiUploadInvoiceFileStruct.ErrorMsg = "pdf not found" + "- pdf miss"
result.outParamMultiUploadInvoiceFileStruct.ssErrorMsg = (AppUtils.GetStringResource("lchEYmKosEehUujTP8Wg_g#Value.734952007.1", "pdf not found")+"- pdf miss");
} else {
// dif names?
if((((BuiltInFunction.SubstrSC (localVars.resListFilterXML_outParamFilteredList.CurrentRec.ssSTFile2.ssName, 0, BuiltInFunction.IndexSC (localVars.resListFilterXML_outParamFilteredList.CurrentRec.ssSTFile2.ssName, ".", 0, false, false))!=BuiltInFunction.SubstrSC (localVars.resListFilterPDF_outParamFilteredList.CurrentRec.ssSTFile2.ssName, 0, BuiltInFunction.IndexSC (localVars.resListFilterXML_outParamFilteredList.CurrentRec.ssSTFile2.ssName, ".", 0, false, false)))||(BuiltInFunction.SubstrSC (localVars.inParami_File.ssFileName, 0, BuiltInFunction.IndexSC (localVars.inParami_File.ssFileName, ".", 0, false, false))!=BuiltInFunction.SubstrSC (localVars.resListFilterPDF_outParamFilteredList.CurrentRec.ssSTFile2.ssName, 0, BuiltInFunction.IndexSC (localVars.resListFilterXML_outParamFilteredList.CurrentRec.ssSTFile2.ssName, ".", 0, false, false)))))) {
// MultiUploadInvoiceFileStruct.ErrorMsg = "file names should correspond" + "- filenames"
result.outParamMultiUploadInvoiceFileStruct.ssErrorMsg = (AppUtils.GetStringResource("D0nAux8_9EOCwTmnsLKN7Q#Value.122197856.1", "file names should correspond")+"- filenames");
} else {
// not file name 20?
if(((BuiltInFunction.LengthSC (BuiltInFunction.SubstrSC (localVars.inParami_File.ssFileName, 0, BuiltInFunction.IndexSC (localVars.inParami_File.ssFileName, ".", 0, false, false)))>20))) {
// MultiUploadInvoiceFileStruct.ErrorMsg = "File name should have 10 digits after F" + "- digits"
result.outParamMultiUploadInvoiceFileStruct.ssErrorMsg = (AppUtils.GetStringResource("Aq8AJJ1YRU++If5fTa+5gQ#Value.-652235667.1", "File name should have 10 digits after F")+"- digits");
} else {
// MultiUploadInvoiceFileStruct.BinaryDataXML = ListFilterXML.FilteredList.Current.File2.Content
result.outParamMultiUploadInvoiceFileStruct.ssBinaryDataXML = localVars.resListFilterXML_outParamFilteredList.CurrentRec.ssSTFile2.ssContent;

// MultiUploadInvoiceFileStruct.BinaryDataPDF = ListFilterPDF.FilteredList.Current.File2.Content
result.outParamMultiUploadInvoiceFileStruct.ssBinaryDataPDF = localVars.resListFilterPDF_outParamFilteredList.CurrentRec.ssSTFile2.ssContent;
}

}

}

}

}

}

} //close CreateActionActivity using block
} // try

finally {
outParamMultiUploadInvoiceFileStruct = result.outParamMultiUploadInvoiceFileStruct;
} // inner-finally
RETURN_STATEMENT:
return outParamMultiUploadInvoiceFileStruct;
}

public static class FuncActionValidateZIPInvoices {

// Query Function "GetFiles2" CGjTyZS2x0KTtPNKdOlhFg of Action "ValidateZIPInvoices"
public static async Task<(RL_08f794aa2125354ca78c75fb19e7e496,long)> datasetGetFiles2(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qploId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ValidateZIPInvoices.GetFiles2", "c9d36808-b694-42c7-93b4-f34a74e96116");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ValidateZIPInvoices.GetFiles2", "c9d36808-b694-42c7-93b4-f34a74e96116", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.O7Qt9IVHKkqDvkNtA5oIvQ/NodesNotShownInESpaceTree.CGjTyZS2x0KTtPNKdOlhFg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enfile32\".\"binary\" o1, NULL o2, NULL o3");
fromBuilder.Append(" FROM {File3} \"enfile32\"");
whereBuilder.Append(" WHERE (\"enfile32\".\"id\" = (@qploId))");
sqlCmd.CreateParameterWithoutReplacements("@qploId", DbType.Int64, qploId);
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
RL_08f794aa2125354ca78c75fb19e7e496 outParamList = new RL_08f794aa2125354ca78c75fb19e7e496();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, false, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ValidateZIPInvoices.GetFiles2.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_08f794aa2125354ca78c75fb19e7e496 _tmp = new RL_08f794aa2125354ca78c75fb19e7e496();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ValidateZIPInvoices.GetFiles2.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_08f794aa2125354ca78c75fb19e7e496)_tmp;
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
