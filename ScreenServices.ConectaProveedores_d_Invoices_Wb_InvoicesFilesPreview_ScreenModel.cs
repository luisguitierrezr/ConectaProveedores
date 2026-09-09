using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_d_Invoices_Wb_InvoicesFilesPreview_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_d_Invoices_Wb_InvoicesFilesPreview_ScreenModel).Namespace);

    public long inParamInvoiceId;
public bool varLcIsOpenPopupOtherFiles;
public ConectaProveedores_d_Invoices_Wb_InvoicesFilesPreview_DataActionGetInvoiceFiles_Model varLcGetInvoiceFiles;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_d_Invoices_Wb_InvoicesFilesPreview_ScreenModel() {
}



    public ConectaProveedores_d_Invoices_Wb_InvoicesFilesPreview_ScreenModel(long inParamInvoiceId, bool varLcIsOpenPopupOtherFiles, ConectaProveedores_d_Invoices_Wb_InvoicesFilesPreview_DataActionGetInvoiceFiles_Model varLcGetInvoiceFiles, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"InvoiceId", "IsOpenPopupOtherFiles", "GetInvoiceFiles", "ClientVars"}, new string[] {"inParamInvoiceId", "varLcIsOpenPopupOtherFiles", "varLcGetInvoiceFiles", "clientVariables"});
this.inParamInvoiceId = inParamInvoiceId;
this.varLcIsOpenPopupOtherFiles = varLcIsOpenPopupOtherFiles;
this.varLcGetInvoiceFiles = varLcGetInvoiceFiles;
this.clientVariables = clientVariables;
}



    

    public class lcvGetInvoiceFiles : VarsBag {
public RL_e40371698c3bd2f83f525cf47c117634 resListFilterXML_outParamFilteredList = new RL_e40371698c3bd2f83f525cf47c117634();

public RL_e40371698c3bd2f83f525cf47c117634 resListFilterPDF_outParamFilteredList = new RL_e40371698c3bd2f83f525cf47c117634();

public RL_e40371698c3bd2f83f525cf47c117634 resListFilterOtherFiles_outParamFilteredList = new RL_e40371698c3bd2f83f525cf47c117634();

public RL_e40371698c3bd2f83f525cf47c117634 queryResGetInvoiceFilesByInvoiceId_outParamList = new RL_e40371698c3bd2f83f525cf47c117634();
public long queryResGetInvoiceFilesByInvoiceId_outParamCount = 0L;

public lcvGetInvoiceFiles() {
}
}
public class lcoGetInvoiceFiles : VarsBag {
public long outParamFilePDF = 0L;

public long outParamFileSizePDF = 0L;

public long outParamFileXML = 0L;

public long outParamFileSizeXML = 0L;

public RL_b48e8aa5377b7b15faec0f07ad9facf2 outParamOtherFiles = new RL_b48e8aa5377b7b15faec0f07ad9facf2();

public lcoGetInvoiceFiles() {
}
}
/// <summary>
/// Action <code>GetInvoiceFiles</code> that represents the Service Studio action
///  <code>GetInvoiceFiles</code> <p> Description: </p>
/// </summary>
public async Task<(long,long,long,long,RL_b48e8aa5377b7b15faec0f07ad9facf2)> DataActionGetInvoiceFiles(IRequestContext requestContext,CancellationToken cancellationToken) {
long outParamFilePDF = default;
long outParamFileSizePDF = default;
long outParamFileXML = default;
long outParamFileSizeXML = default;
RL_b48e8aa5377b7b15faec0f07ad9facf2 outParamOtherFiles = default;
lcoGetInvoiceFiles result = new lcoGetInvoiceFiles();
lcvGetInvoiceFiles localVars = new lcvGetInvoiceFiles();
ConectaProveedores_d_Invoices_Wb_InvoicesFilesPreview_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetInvoiceFiles", "d3a28427-ce44-4ddc-9d5e-ca6384155ce9"))
using (activitySource.CreateScreenDataActionActivity("Wb_InvoicesFilesPreview", "GetInvoiceFiles")){
// Query datasetGetInvoiceFilesByInvoiceId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceFilesByInvoiceId_maxRecords = 50;
if (datasetGetInvoiceFilesByInvoiceId_maxRecords < 1) datasetGetInvoiceFilesByInvoiceId_maxRecords = 1;
int datasetGetInvoiceFilesByInvoiceId_startIndex = 0;(localVars.queryResGetInvoiceFilesByInvoiceId_outParamList,localVars.queryResGetInvoiceFilesByInvoiceId_outParamCount) = await FuncDataActionGetInvoiceFiles.datasetGetInvoiceFilesByInvoiceId(requestContext,datasetGetInvoiceFilesByInvoiceId_maxRecords,datasetGetInvoiceFilesByInvoiceId_startIndex,IterationMultiplicity.Multiple,inParamInvoiceId,cancellationToken);

// ListFilterPDF
localVars.resListFilterPDF_outParamFilteredList = (((RL_e40371698c3bd2f83f525cf47c117634)await  localVars.queryResGetInvoiceFilesByInvoiceId_outParamList.FilterAsync(async (p, cancellationToken) => ((BuiltInFunction.IndexSC (BuiltInFunction.ToLower (p.ssENInvoiceFile.ssFilename), ".pdf", 0, false, false)!=(-1))&&(!p.ssENInvoiceFile.ssIsExtra)), cancellationToken)));

// ListFilterXML
localVars.resListFilterXML_outParamFilteredList = (((RL_e40371698c3bd2f83f525cf47c117634)await  localVars.queryResGetInvoiceFilesByInvoiceId_outParamList.FilterAsync(async (p, cancellationToken) => ((BuiltInFunction.IndexSC (BuiltInFunction.ToLower (p.ssENInvoiceFile.ssFilename), ".xml", 0, false, false)!=(-1))&&(!p.ssENInvoiceFile.ssIsExtra)), cancellationToken)));

// ListFilterOtherFiles
localVars.resListFilterOtherFiles_outParamFilteredList = (((RL_e40371698c3bd2f83f525cf47c117634)await  localVars.queryResGetInvoiceFilesByInvoiceId_outParamList.FilterAsync(async (p, cancellationToken) => (((await Functions.ssCheckProveedorRole(requestContext,"",cancellationToken))) ? ((p.ssENInvoiceFile.ssIsExtra&&(!p.ssENInvoiceFile.ssIsReport))) : (p.ssENInvoiceFile.ssIsExtra)), cancellationToken)));

// FilePDF = ListFilterPDF.FilteredList.Current.InvoiceFile.StorageId
result.outParamFilePDF=localVars.resListFilterPDF_outParamFilteredList.CurrentRec.ssENInvoiceFile.ssStorageId;

// FileSizePDF = ListFilterPDF.FilteredList.Current.Storage.Size
result.outParamFileSizePDF=localVars.resListFilterPDF_outParamFilteredList.CurrentRec.ssENStorage.ssSize;

// FileXML = ListFilterXML.FilteredList.Current.InvoiceFile.StorageId
result.outParamFileXML=localVars.resListFilterXML_outParamFilteredList.CurrentRec.ssENInvoiceFile.ssStorageId;

// FileSizeXML = ListFilterXML.FilteredList.Current.Storage.Size
result.outParamFileSizeXML=localVars.resListFilterXML_outParamFilteredList.CurrentRec.ssENStorage.ssSize;

// OtherFiles = ListFilterOtherFiles.FilteredList
result.outParamOtherFiles=(await RL_b48e8aa5377b7b15faec0f07ad9facf2.ConvertAsync(localVars.resListFilterOtherFiles_outParamFilteredList, new RL_b48e8aa5377b7b15faec0f07ad9facf2(), async (RC_7cb091de697d14a1ce465208aa77fcb0 source, ST_8917d167cfa0f31ec1ed2a0d24e80bccStructure target, CancellationToken cancellationToken) => {
target.ssStorageId = source.ssENInvoiceFile.ssStorageId;
target.ssFilename = source.ssENInvoiceFile.ssFilename;
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


    public static class FuncDataActionGetInvoiceFiles {

private static async Task<RC_7cb091de697d14a1ce465208aa77fcb0> datasetGetInvoiceFilesByInvoiceIdReadDbAsync(RC_7cb091de697d14a1ce465208aa77fcb0 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoiceFile.Read( r, ref index);
rec.ssENStorage.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceFilesByInvoiceId" CF1b3wOJnES3WaTc5vYFAA of Action "GetInvoiceFiles"
public static async Task<(RL_e40371698c3bd2f83f525cf47c117634,long)> datasetGetInvoiceFilesByInvoiceId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceFile_InvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("d_Invoices.Wb_InvoicesFilesPreview.GetInvoiceFiles.GetInvoiceFilesByInvoiceId", "df5b5d08-8903-449c-b759-a4dce6f60500");
using var queryActivity = activitySource.CreateAggregateQueryActivity("d_Invoices.Wb_InvoicesFilesPreview.GetInvoiceFiles.GetInvoiceFilesByInvoiceId", "df5b5d08-8903-449c-b759-a4dce6f60500", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.22FlLU0LEUOaUFO_6iGXPQ/NodesShownInESpaceTree.lQ9sjK5_6EKO+0xl7vX+_Q/DataActions.J4Si00TO3E2dXspjhBVc6Q/NodesNotShownInESpaceTree.CF1b3wOJnES3WaTc5vYFAA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"eninvoicefile45\".\"filename\" o2, \"eninvoicefile45\".\"isextra\" o3, \"eninvoicefile45\".\"isreport\" o4, \"eninvoicefile45\".\"storageid\" o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, \"enstorage25\".\"size\" o26, NULL o27");
fromBuilder.Append(" FROM ({InvoiceFile} \"eninvoicefile45\" Left JOIN {Storage} \"enstorage25\" ON (\"eninvoicefile45\".\"storageid\" = \"enstorage25\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceFile_InvoiceId != 0) {
whereBuilder.Append("((\"eninvoicefile45\".\"invoiceid\" = @qpinInvoiceFile_InvoiceId) AND (\"eninvoicefile45\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceFile_InvoiceId", DbType.Int64, qpinInvoiceFile_InvoiceId);
} else {
whereBuilder.Append("(\"eninvoicefile45\".\"invoiceid\" IS NULL)");
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
RL_e40371698c3bd2f83f525cf47c117634 outParamList = new RL_e40371698c3bd2f83f525cf47c117634();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoiceFilesByInvoiceIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, false, false, false, false, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_Invoices.Wb_InvoicesFilesPreview.GetInvoiceFiles.GetInvoiceFilesByInvoiceId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_e40371698c3bd2f83f525cf47c117634 _tmp = new RL_e40371698c3bd2f83f525cf47c117634();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoiceFilesByInvoiceIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_Invoices.Wb_InvoicesFilesPreview.GetInvoiceFiles.GetInvoiceFilesByInvoiceId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_e40371698c3bd2f83f525cf47c117634)_tmp;
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
