using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_j_FoliosSAE_Wb_FolioSAEFilesPreview_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_j_FoliosSAE_Wb_FolioSAEFilesPreview_ScreenModel).Namespace);

    public long inParamFolioId;
public bool varLcIsOpenPopupOtherFiles;
public ConectaProveedores_j_FoliosSAE_Wb_FolioSAEFilesPreview_DataActionGetFolioFiles_Model varLcGetFolioFiles;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_j_FoliosSAE_Wb_FolioSAEFilesPreview_ScreenModel() {
}



    public ConectaProveedores_j_FoliosSAE_Wb_FolioSAEFilesPreview_ScreenModel(long inParamFolioId, bool varLcIsOpenPopupOtherFiles, ConectaProveedores_j_FoliosSAE_Wb_FolioSAEFilesPreview_DataActionGetFolioFiles_Model varLcGetFolioFiles, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"FolioId", "IsOpenPopupOtherFiles", "GetFolioFiles", "ClientVars"}, new string[] {"inParamFolioId", "varLcIsOpenPopupOtherFiles", "varLcGetFolioFiles", "clientVariables"});
this.inParamFolioId = inParamFolioId;
this.varLcIsOpenPopupOtherFiles = varLcIsOpenPopupOtherFiles;
this.varLcGetFolioFiles = varLcGetFolioFiles;
this.clientVariables = clientVariables;
}



    

    public class lcvGetFolioFiles : VarsBag {
public RL_599a55f2ca551e3817b27381ea3fcd80 resListFilterXML_outParamFilteredList = new RL_599a55f2ca551e3817b27381ea3fcd80();

public RL_599a55f2ca551e3817b27381ea3fcd80 resListFilterOtherFiles_outParamFilteredList = new RL_599a55f2ca551e3817b27381ea3fcd80();

public RL_599a55f2ca551e3817b27381ea3fcd80 resListFilterPDF_outParamFilteredList = new RL_599a55f2ca551e3817b27381ea3fcd80();

public RL_599a55f2ca551e3817b27381ea3fcd80 queryResGetFolioFilesByFolioId_outParamList = new RL_599a55f2ca551e3817b27381ea3fcd80();
public long queryResGetFolioFilesByFolioId_outParamCount = 0L;

public lcvGetFolioFiles() {
}
}
public class lcoGetFolioFiles : VarsBag {
public long outParamFilePDF = 0L;

public long outParamFileSizePDF = 0L;

public long outParamFileXML = 0L;

public long outParamFileSizeXML = 0L;

public RL_b48e8aa5377b7b15faec0f07ad9facf2 outParamOtherFiles = new RL_b48e8aa5377b7b15faec0f07ad9facf2();

public lcoGetFolioFiles() {
}
}
/// <summary>
/// Action <code>GetFolioFiles</code> that represents the Service Studio action
///  <code>GetFolioFiles</code> <p> Description: </p>
/// </summary>
public async Task<(long,long,long,long,RL_b48e8aa5377b7b15faec0f07ad9facf2)> DataActionGetFolioFiles(IRequestContext requestContext,CancellationToken cancellationToken) {
long outParamFilePDF = default;
long outParamFileSizePDF = default;
long outParamFileXML = default;
long outParamFileSizeXML = default;
RL_b48e8aa5377b7b15faec0f07ad9facf2 outParamOtherFiles = default;
lcoGetFolioFiles result = new lcoGetFolioFiles();
lcvGetFolioFiles localVars = new lcvGetFolioFiles();
ConectaProveedores_j_FoliosSAE_Wb_FolioSAEFilesPreview_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetFolioFiles", "3a7b21a3-06cb-4961-a7c5-7ef09c5a38b2"))
using (activitySource.CreateScreenDataActionActivity("Wb_FolioSAEFilesPreview", "GetFolioFiles")){
// Query datasetGetFolioFilesByFolioId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioFilesByFolioId_maxRecords = 50;
if (datasetGetFolioFilesByFolioId_maxRecords < 1) datasetGetFolioFilesByFolioId_maxRecords = 1;
int datasetGetFolioFilesByFolioId_startIndex = 0;(localVars.queryResGetFolioFilesByFolioId_outParamList,localVars.queryResGetFolioFilesByFolioId_outParamCount) = await FuncDataActionGetFolioFiles.datasetGetFolioFilesByFolioId(requestContext,datasetGetFolioFilesByFolioId_maxRecords,datasetGetFolioFilesByFolioId_startIndex,IterationMultiplicity.Multiple,inParamFolioId,cancellationToken);

// ListFilterPDF
localVars.resListFilterPDF_outParamFilteredList = (((RL_599a55f2ca551e3817b27381ea3fcd80)await  localVars.queryResGetFolioFilesByFolioId_outParamList.FilterAsync(async (p, cancellationToken) => ((BuiltInFunction.IndexSC (BuiltInFunction.ToLower (p.ssENFolioFiles.ssFilename), ".pdf", 0, false, false)!=(-1))&&(!p.ssENFolioFiles.ssIsExtra)), cancellationToken)));

// ListFilterXML
localVars.resListFilterXML_outParamFilteredList = (((RL_599a55f2ca551e3817b27381ea3fcd80)await  localVars.queryResGetFolioFilesByFolioId_outParamList.FilterAsync(async (p, cancellationToken) => ((BuiltInFunction.IndexSC (BuiltInFunction.ToLower (p.ssENFolioFiles.ssFilename), ".xml", 0, false, false)!=(-1))&&(!p.ssENFolioFiles.ssIsExtra)), cancellationToken)));

// ListFilterOtherFiles
localVars.resListFilterOtherFiles_outParamFilteredList = (((RL_599a55f2ca551e3817b27381ea3fcd80)await  localVars.queryResGetFolioFilesByFolioId_outParamList.FilterAsync(async (p, cancellationToken) => p.ssENFolioFiles.ssIsExtra, cancellationToken)));

// FilePDF = ListFilterPDF.FilteredList.Current.FolioFiles.StorageId
result.outParamFilePDF=localVars.resListFilterPDF_outParamFilteredList.CurrentRec.ssENFolioFiles.ssStorageId;

// FileSizePDF = ListFilterPDF.FilteredList.Current.Storage.Size
result.outParamFileSizePDF=localVars.resListFilterPDF_outParamFilteredList.CurrentRec.ssENStorage.ssSize;

// FileXML = ListFilterXML.FilteredList.Current.FolioFiles.StorageId
result.outParamFileXML=localVars.resListFilterXML_outParamFilteredList.CurrentRec.ssENFolioFiles.ssStorageId;

// FileSizeXML = ListFilterXML.FilteredList.Current.Storage.Size
result.outParamFileSizeXML=localVars.resListFilterXML_outParamFilteredList.CurrentRec.ssENStorage.ssSize;

// OtherFiles = ListFilterOtherFiles.FilteredList
result.outParamOtherFiles=(await RL_b48e8aa5377b7b15faec0f07ad9facf2.ConvertAsync(localVars.resListFilterOtherFiles_outParamFilteredList, new RL_b48e8aa5377b7b15faec0f07ad9facf2(), async (RC_db98be0f77f582e2a41dd64bb6a4005e source, ST_8917d167cfa0f31ec1ed2a0d24e80bccStructure target, CancellationToken cancellationToken) => {
target.ssStorageId = source.ssENFolioFiles.ssStorageId;
target.ssFilename = source.ssENFolioFiles.ssFilename;
target.ssSize = source.ssENStorage.ssSize;
return target;
}, cancellationToken));
} //close CreateActionActivity using block
} // try

finally {
outParamFilePDF = result.outParamFilePDF;
outParamFileSizePDF = result.outParamFileSizePDF;
outParamFileXML = result.outParamFileXML;
outParamFileSizeXML = result.outParamFileSizeXML;
outParamOtherFiles = result.outParamOtherFiles;
} // inner-finally
RETURN_STATEMENT:
return (outParamFilePDF,outParamFileSizePDF,outParamFileXML,outParamFileSizeXML,outParamOtherFiles);
}


    public static class FuncDataActionGetFolioFiles {

private static async Task<RC_db98be0f77f582e2a41dd64bb6a4005e> datasetGetFolioFilesByFolioIdReadDbAsync(RC_db98be0f77f582e2a41dd64bb6a4005e rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolioFiles.Read( r, ref index);
rec.ssENStorage.Read( r, ref index);
return rec;
}
// Query Function "GetFolioFilesByFolioId" GlNX0ZfmykqfDFwauW7u9g of Action "GetFolioFiles"
public static async Task<(RL_599a55f2ca551e3817b27381ea3fcd80,long)> datasetGetFolioFilesByFolioId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolioFiles_FolioId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("j_FoliosSAE.Wb_FolioSAEFilesPreview.GetFolioFiles.GetFolioFilesByFolioId", "d157531a-e697-4aca-9f0c-5c1ab96eeef6");
using var queryActivity = activitySource.CreateAggregateQueryActivity("j_FoliosSAE.Wb_FolioSAEFilesPreview.GetFolioFiles.GetFolioFilesByFolioId", "d157531a-e697-4aca-9f0c-5c1ab96eeef6", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.+b+jWINhpU62_L3+cVnP7w/DataActions.oyF7OssGYUmnxX7wnFo4sg/NodesNotShownInESpaceTree.GlNX0ZfmykqfDFwauW7u9g, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enfoliofiles9\".\"filename\" o1, NULL o2, \"enfoliofiles9\".\"isextra\" o3, \"enfoliofiles9\".\"storageid\" o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, \"enstorage36\".\"size\" o26, NULL o27");
fromBuilder.Append(" FROM ({FolioFiles} \"enfoliofiles9\" Left JOIN {Storage} \"enstorage36\" ON (\"enfoliofiles9\".\"storageid\" = \"enstorage36\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoFolioFiles_FolioId != 0) {
whereBuilder.Append("((\"enfoliofiles9\".\"folioid\" = @qpfoFolioFiles_FolioId) AND (\"enfoliofiles9\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioFiles_FolioId", DbType.Int64, qpfoFolioFiles_FolioId);
} else {
whereBuilder.Append("(\"enfoliofiles9\".\"folioid\" IS NULL)");
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
RL_599a55f2ca551e3817b27381ea3fcd80 outParamList = new RL_599a55f2ca551e3817b27381ea3fcd80();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFolioFilesByFolioIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, false, true, false, false, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_FolioSAEFilesPreview.GetFolioFiles.GetFolioFilesByFolioId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_599a55f2ca551e3817b27381ea3fcd80 _tmp = new RL_599a55f2ca551e3817b27381ea3fcd80();
_tmp.AlternateReadDbMethodAsync = datasetGetFolioFilesByFolioIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_FolioSAEFilesPreview.GetFolioFiles.GetFolioFilesByFolioId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_599a55f2ca551e3817b27381ea3fcd80)_tmp;
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
