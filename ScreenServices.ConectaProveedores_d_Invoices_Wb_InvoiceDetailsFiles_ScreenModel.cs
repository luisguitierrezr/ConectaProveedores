using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_d_Invoices_Wb_InvoiceDetailsFiles_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_d_Invoices_Wb_InvoiceDetailsFiles_ScreenModel).Namespace);

    public long inParami_InvoiceId;
public string inParami_InvoiceName;
public bool inParamIsProveedor;
public ConectaProveedores_d_Invoices_Wb_InvoiceDetailsFiles_DataActionGetInvoiceFiles_Model varLcGetInvoiceFiles;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_d_Invoices_Wb_InvoiceDetailsFiles_ScreenModel() {
}



    public ConectaProveedores_d_Invoices_Wb_InvoiceDetailsFiles_ScreenModel(long inParami_InvoiceId, string inParami_InvoiceName, bool inParamIsProveedor, ConectaProveedores_d_Invoices_Wb_InvoiceDetailsFiles_DataActionGetInvoiceFiles_Model varLcGetInvoiceFiles, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"i_InvoiceId", "i_InvoiceName", "IsProveedor", "GetInvoiceFiles", "ClientVars"}, new string[] {"inParami_InvoiceId", "inParami_InvoiceName", "inParamIsProveedor", "varLcGetInvoiceFiles", "clientVariables"});
this.inParami_InvoiceId = inParami_InvoiceId;
this.inParami_InvoiceName = inParami_InvoiceName;
this.inParamIsProveedor = inParamIsProveedor;
this.varLcGetInvoiceFiles = varLcGetInvoiceFiles;
this.clientVariables = clientVariables;
}



    

    public class lcvGetInvoiceFiles : VarsBag {
public RL_e40371698c3bd2f83f525cf47c117634 resListFilter2_outParamFilteredList = new RL_e40371698c3bd2f83f525cf47c117634();

public RL_e40371698c3bd2f83f525cf47c117634 queryResGetInvoiceFilesByInvoiceId_outParamList = new RL_e40371698c3bd2f83f525cf47c117634();
public long queryResGetInvoiceFilesByInvoiceId_outParamCount = 0L;

public RL_e40371698c3bd2f83f525cf47c117634 resListFilter_outParamFilteredList = new RL_e40371698c3bd2f83f525cf47c117634();

public lcvGetInvoiceFiles() {
}
}
public class lcoGetInvoiceFiles : VarsBag {
public RL_e40371698c3bd2f83f525cf47c117634 outParamMainFiles = new RL_e40371698c3bd2f83f525cf47c117634();

public RL_e40371698c3bd2f83f525cf47c117634 outParamExtraFiles = new RL_e40371698c3bd2f83f525cf47c117634();

public lcoGetInvoiceFiles() {
}
}
/// <summary>
/// Action <code>GetInvoiceFiles</code> that represents the Service Studio action
///  <code>GetInvoiceFiles</code> <p> Description: </p>
/// </summary>
public async Task<(RL_e40371698c3bd2f83f525cf47c117634,RL_e40371698c3bd2f83f525cf47c117634)> DataActionGetInvoiceFiles(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_e40371698c3bd2f83f525cf47c117634 outParamMainFiles = default;
RL_e40371698c3bd2f83f525cf47c117634 outParamExtraFiles = default;
lcoGetInvoiceFiles result = new lcoGetInvoiceFiles();
lcvGetInvoiceFiles localVars = new lcvGetInvoiceFiles();
ConectaProveedores_d_Invoices_Wb_InvoiceDetailsFiles_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetInvoiceFiles", "b062afb4-49b8-43e9-9b46-1b43455f5acc"))
using (activitySource.CreateScreenDataActionActivity("Wb_InvoiceDetailsFiles", "GetInvoiceFiles")){
// Query datasetGetInvoiceFilesByInvoiceId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceFilesByInvoiceId_maxRecords = 1000;
if (datasetGetInvoiceFilesByInvoiceId_maxRecords < 1) datasetGetInvoiceFilesByInvoiceId_maxRecords = 1;
int datasetGetInvoiceFilesByInvoiceId_startIndex = 0;(localVars.queryResGetInvoiceFilesByInvoiceId_outParamList,localVars.queryResGetInvoiceFilesByInvoiceId_outParamCount) = await FuncDataActionGetInvoiceFiles.datasetGetInvoiceFilesByInvoiceId(requestContext,datasetGetInvoiceFilesByInvoiceId_maxRecords,datasetGetInvoiceFilesByInvoiceId_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),inParami_InvoiceId,cancellationToken);

// ListFilter
localVars.resListFilter_outParamFilteredList = (((RL_e40371698c3bd2f83f525cf47c117634)await  localVars.queryResGetInvoiceFilesByInvoiceId_outParamList.FilterAsync(async (p, cancellationToken) => (!p.ssENInvoiceFile.ssIsExtra), cancellationToken)));

// ListFilter2
localVars.resListFilter2_outParamFilteredList = (((RL_e40371698c3bd2f83f525cf47c117634)await  localVars.queryResGetInvoiceFilesByInvoiceId_outParamList.FilterAsync(async (p, cancellationToken) => (((!inParamIsProveedor)) ? (p.ssENInvoiceFile.ssIsExtra) : ((p.ssENInvoiceFile.ssIsExtra&&(!p.ssENInvoiceFile.ssIsReport)))), cancellationToken)));

// MainFiles = ListFilter.FilteredList
result.outParamMainFiles=localVars.resListFilter_outParamFilteredList;

// ExtraFiles = ListFilter2.FilteredList
result.outParamExtraFiles=localVars.resListFilter2_outParamFilteredList;
} //close CreateActionActivity using block
} // try

finally {
outParamMainFiles = result.outParamMainFiles;
outParamExtraFiles = result.outParamExtraFiles;
} // inner-finally
RETURN_STATEMENT:
return (outParamMainFiles,outParamExtraFiles);
}


    public static class FuncDataActionGetInvoiceFiles {

private static async Task<RC_7cb091de697d14a1ce465208aa77fcb0> datasetGetInvoiceFilesByInvoiceIdReadDbAsync(RC_7cb091de697d14a1ce465208aa77fcb0 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoiceFile.Read( r, ref index);
rec.ssENStorage.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceFilesByInvoiceId" R2hrUXSFZECtgpx3h3x5Xg of Action "GetInvoiceFiles"
public static async Task<(RL_e40371698c3bd2f83f525cf47c117634,long)> datasetGetInvoiceFilesByInvoiceId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,long qpinInvoiceFile_InvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("d_Invoices.Wb_InvoiceDetailsFiles.GetInvoiceFiles.GetInvoiceFilesByInvoiceId", "516b6847-8574-4064-ad82-9c77877c795e");
using var queryActivity = activitySource.CreateAggregateQueryActivity("d_Invoices.Wb_InvoiceDetailsFiles.GetInvoiceFiles.GetInvoiceFilesByInvoiceId", "516b6847-8574-4064-ad82-9c77877c795e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.22FlLU0LEUOaUFO_6iGXPQ/NodesShownInESpaceTree.I062uiUlGkO9JjaxdWMthA/DataActions.tK9isLhJ6UObRhtDRV9azA/NodesNotShownInESpaceTree.R2hrUXSFZECtgpx3h3x5Xg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"eninvoicefile46\".\"filename\" o2, \"eninvoicefile46\".\"isextra\" o3, \"eninvoicefile46\".\"isreport\" o4, \"eninvoicefile46\".\"storageid\" o5, NULL o6, NULL o7, \"enstorage26\".\"id\" o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, \"enstorage26\".\"size\" o26, NULL o27");
fromBuilder.Append(" FROM ({InvoiceFile} \"eninvoicefile46\" Inner JOIN {Storage} \"enstorage26\" ON (\"eninvoicefile46\".\"storageid\" = \"enstorage26\".\"id\")) ");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qpinInvoiceFile_InvoiceId != 0) {
whereBuilder.Append("((\"eninvoicefile46\".\"invoiceid\" = @qpinInvoiceFile_InvoiceId) AND (\"eninvoicefile46\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceFile_InvoiceId", DbType.Int64, qpinInvoiceFile_InvoiceId);
} else {
whereBuilder.Append("(\"eninvoicefile46\".\"invoiceid\" IS NULL)");
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
opt[1] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_Invoices.Wb_InvoiceDetailsFiles.GetInvoiceFiles.GetInvoiceFilesByInvoiceId.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_Invoices.Wb_InvoiceDetailsFiles.GetInvoiceFiles.GetInvoiceFilesByInvoiceId.List", cancellationToken: cancellationToken);
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
