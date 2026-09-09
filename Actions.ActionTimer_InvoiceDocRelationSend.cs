namespace ssConectaProveedores;

public partial class Actions {
public class lcvTimer_InvoiceDocRelationSend : VarsBag {
/// <summary>
/// Variable <code>IT_ATTACHMENT</code> that represents the Service Studio IT_ATTACHMENTList
///  <code>IT_ATTACHMENT</code> <p>Description: </p>
/// </summary>
public RL_cff0038616a202f621fb7082f988995f varLcIT_ATTACHMENT = new RL_cff0038616a202f621fb7082f988995f();

/// <summary>
/// Variable <code>IT_ATTACHMENTAux</code> that represents the Service Studio IT_ATTACHMENTList
///  <code>IT_ATTACHMENTAux</code> <p>Description: </p>
/// </summary>
public RL_cff0038616a202f621fb7082f988995f varLcIT_ATTACHMENTAux = new RL_cff0038616a202f621fb7082f988995f();

public ST_31a464e509d55210f80b735594283423Structure resCall_ZMXFFIMF_0250_FI_CREATE_RELAT_outParamResponse = new ST_31a464e509d55210f80b735594283423Structure();

public RC_14fd6714905cc16780383cc2da86ee0d resGetInvoicePoliza2_outParamRecord = new RC_14fd6714905cc16780383cc2da86ee0d();

public RL_e40371698c3bd2f83f525cf47c117634 queryResGetInvoiceFilesByInvoiceId_outParamList = new RL_e40371698c3bd2f83f525cf47c117634();
public long queryResGetInvoiceFilesByInvoiceId_outParamCount = 0L;

public RL_e40371698c3bd2f83f525cf47c117634 resListFilter2_outParamFilteredList = new RL_e40371698c3bd2f83f525cf47c117634();

public RL_599a55f2ca551e3817b27381ea3fcd80 queryResGetFolioFilesByFolioId_outParamList = new RL_599a55f2ca551e3817b27381ea3fcd80();
public long queryResGetFolioFilesByFolioId_outParamCount = 0L;

public RL_599a55f2ca551e3817b27381ea3fcd80 resListFilter3_outParamFilteredList = new RL_599a55f2ca551e3817b27381ea3fcd80();

public RL_e40371698c3bd2f83f525cf47c117634 resListFilter_outParamFilteredList = new RL_e40371698c3bd2f83f525cf47c117634();

public RL_031b891075d450fa5dc6dea0047d0fa4 queryResGetInvoicePolizaFlows_outParamList = new RL_031b891075d450fa5dc6dea0047d0fa4();
public long queryResGetInvoicePolizaFlows_outParamCount = 0L;

public lcvTimer_InvoiceDocRelationSend() {
}
}
/// <summary>
/// Action <code>Timer_InvoiceDocRelationSend</code> that represents the Service Studio action
///  <code>Timer_InvoiceDocRelationSend</code> <p> Description: </p>
/// </summary>
public static async Task ActionTimer_InvoiceDocRelationSend(IRequestContext requestContext,CancellationToken cancellationToken) {
lcvTimer_InvoiceDocRelationSend localVars = new lcvTimer_InvoiceDocRelationSend();
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("Timer_InvoiceDocRelationSend", "cf088ed6-9c2a-4703-861b-ee87277734cb"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("Timer_InvoiceDocRelationSend", "cf088ed6-9c2a-4703-861b-ee87277734cb", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetInvoicePolizaFlows
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoicePolizaFlows_maxRecords = 999999999;
if (datasetGetInvoicePolizaFlows_maxRecords < 1) datasetGetInvoicePolizaFlows_maxRecords = 1;
int datasetGetInvoicePolizaFlows_startIndex = 0;(localVars.queryResGetInvoicePolizaFlows_outParamList,localVars.queryResGetInvoicePolizaFlows_outParamCount) = await FuncActionTimer_InvoiceDocRelationSend.datasetGetInvoicePolizaFlows(requestContext,datasetGetInvoicePolizaFlows_maxRecords,datasetGetInvoicePolizaFlows_startIndex,IterationMultiplicity.Single,cancellationToken);

// LogMessage
await ExtendedActions.LogMessage(requestContext,("Total lines of Invoice Poliza:"+BuiltInFunction.LongIntegerToText(localVars.queryResGetInvoicePolizaFlows_outParamCount)),"Poliza Send Files",cancellationToken);

// Foreach GetInvoicePolizaFlows.List
localVars.queryResGetInvoicePolizaFlows_outParamList.StartIteration();
try {while (!((localVars.queryResGetInvoicePolizaFlows_outParamList.Eof))) {
// Query datasetGetInvoiceFilesByInvoiceId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceFilesByInvoiceId_maxRecords = 0;
int datasetGetInvoiceFilesByInvoiceId_startIndex = 0;(localVars.queryResGetInvoiceFilesByInvoiceId_outParamList,localVars.queryResGetInvoiceFilesByInvoiceId_outParamCount) = await FuncActionTimer_InvoiceDocRelationSend.datasetGetInvoiceFilesByInvoiceId(requestContext,datasetGetInvoiceFilesByInvoiceId_maxRecords,datasetGetInvoiceFilesByInvoiceId_startIndex,IterationMultiplicity.Multiple,localVars.queryResGetInvoicePolizaFlows_outParamList.CurrentRec.ssENInvoice.ssId,cancellationToken);

// ListFilter
localVars.resListFilter_outParamFilteredList = (((RL_e40371698c3bd2f83f525cf47c117634)await  localVars.queryResGetInvoiceFilesByInvoiceId_outParamList.FilterAsync(async (p, cancellationToken) => p.ssENInvoiceFile.ssIsReport, cancellationToken)));

// No Report File
if((!(localVars.resListFilter_outParamFilteredList.Empty))) {
// ListFilter2
localVars.resListFilter2_outParamFilteredList = (((RL_e40371698c3bd2f83f525cf47c117634)await  localVars.queryResGetInvoiceFilesByInvoiceId_outParamList.FilterAsync(async (p, cancellationToken) => ((!p.ssENStorage.ssIsExternal)&&p.ssENStorage.ssIstoSendToExternal), cancellationToken)));

// IsFolio?
if(((localVars.queryResGetInvoicePolizaFlows_outParamList.CurrentRec.ssENInvoice.ssFolioId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// Query datasetGetFolioFilesByFolioId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioFilesByFolioId_maxRecords = 0;
int datasetGetFolioFilesByFolioId_startIndex = 0;(localVars.queryResGetFolioFilesByFolioId_outParamList,localVars.queryResGetFolioFilesByFolioId_outParamCount) = await FuncActionTimer_InvoiceDocRelationSend.datasetGetFolioFilesByFolioId(requestContext,datasetGetFolioFilesByFolioId_maxRecords,datasetGetFolioFilesByFolioId_startIndex,IterationMultiplicity.Multiple,localVars.queryResGetInvoicePolizaFlows_outParamList.CurrentRec.ssENInvoice.ssFolioId,cancellationToken);

// No ConstructionFiles
if((!(localVars.queryResGetFolioFilesByFolioId_outParamList.Empty))) {
// ListFilter3
localVars.resListFilter3_outParamFilteredList = (((RL_599a55f2ca551e3817b27381ea3fcd80)await  localVars.queryResGetFolioFilesByFolioId_outParamList.FilterAsync(async (p, cancellationToken) => ((!p.ssENStorage.ssIsExternal)&&p.ssENStorage.ssIstoSendToExternal), cancellationToken)));

if(((!localVars.resListFilter3_outParamFilteredList.Empty))) {
// ly
// ly
localVars.queryResGetInvoicePolizaFlows_outParamList.Advance();
continue;
} else {
// ListClearAUX
await ExtendedActions.ListClear(requestContext,localVars.varLcIT_ATTACHMENTAux,cancellationToken);

// ListAppendAllAUX
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcIT_ATTACHMENTAux,(await RL_cff0038616a202f621fb7082f988995f.ConvertAsync(localVars.queryResGetFolioFilesByFolioId_outParamList, new RL_cff0038616a202f621fb7082f988995f(), async (RC_db98be0f77f582e2a41dd64bb6a4005e source, ST_7816c3c943d129234de46d39c32a618eStructure target, CancellationToken cancellationToken) => {
target.ssARC_DOC_ID = source.ssENStorage.ssArc_Doc_ID;
target.ssARCHIV_ID = source.ssENStorage.ssArchive_ID;
return target;
}, cancellationToken)),cancellationToken);

}

}

}

if((!((!localVars.resListFilter2_outParamFilteredList.Empty)))) {
// ListClear
await ExtendedActions.ListClear(requestContext,localVars.varLcIT_ATTACHMENT,cancellationToken);

// ListAppendAll
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcIT_ATTACHMENT,(await RL_cff0038616a202f621fb7082f988995f.ConvertAsync(localVars.queryResGetInvoiceFilesByInvoiceId_outParamList, new RL_cff0038616a202f621fb7082f988995f(), async (RC_7cb091de697d14a1ce465208aa77fcb0 source, ST_7816c3c943d129234de46d39c32a618eStructure target, CancellationToken cancellationToken) => {
target.ssARC_DOC_ID = source.ssENStorage.ssArc_Doc_ID;
target.ssARCHIV_ID = source.ssENStorage.ssArchive_ID;
return target;
}, cancellationToken)),cancellationToken);

// ListAppendAllAux2
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcIT_ATTACHMENT,localVars.varLcIT_ATTACHMENTAux,cancellationToken);

if(!((localVars.varLcIT_ATTACHMENT.Empty))) {
// Call_ZMXFFIMF_0250_FI_CREATE_RELAT
localVars.resCall_ZMXFFIMF_0250_FI_CREATE_RELAT_outParamResponse = await ServiceAPIs.ServiceAPICall_ZMXFFIMF_0250_FI_CREATE_RELAT(requestContext,new ST_b9515582922fdbd4d217706a5c5c0f3fStructure(){ ssIT_ATTACHMENT = localVars.varLcIT_ATTACHMENT, ssIV_ID = (((localVars.queryResGetInvoicePolizaFlows_outParamList.CurrentRec.ssENInvoice.ssRequisitionId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ()))) ? (localVars.queryResGetInvoicePolizaFlows_outParamList.CurrentRec.ssENRequisition.ssName) : ((((localVars.queryResGetInvoicePolizaFlows_outParamList.CurrentRec.ssENInvoice.ssFolioId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ()))) ? (localVars.queryResGetInvoicePolizaFlows_outParamList.CurrentRec.ssENFolio.ssFolioNumber) : ((((localVars.queryResGetInvoicePolizaFlows_outParamList.CurrentRec.ssENInvoice.ssOrderMainId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ()))) ? (localVars.queryResGetInvoicePolizaFlows_outParamList.CurrentRec.ssENOrderMain.ssOrderNumber) : ("")))))), ssIV_SAP_OBJECT = (((localVars.queryResGetInvoicePolizaFlows_outParamList.CurrentRec.ssENInvoice.ssRequisitionId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ()))) ? (((((string)AppUtils.SiteProperties[SitePropertiesModel.spInvoiceWithNoContractTable])))) : ((((localVars.queryResGetInvoicePolizaFlows_outParamList.CurrentRec.ssENInvoice.ssFolioId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ()))) ? (((((string)AppUtils.SiteProperties[SitePropertiesModel.spInvoiceWithNoContractTable])))) : ((((localVars.queryResGetInvoicePolizaFlows_outParamList.CurrentRec.ssENInvoice.ssOrderMainId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ()))) ? (((((string)AppUtils.SiteProperties[SitePropertiesModel.spPurchaseOrderTable])))) : ("")))))), ssIV_SAP_OBJECT_ID = (((((localVars.queryResGetInvoicePolizaFlows_outParamList.CurrentRec.ssENInvoice.ssRequisitionId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ()))) ? (localVars.queryResGetInvoicePolizaFlows_outParamList.CurrentRec.ssENReqSociety.ssExternalId) : ((((localVars.queryResGetInvoicePolizaFlows_outParamList.CurrentRec.ssENInvoice.ssFolioId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ()))) ? (localVars.queryResGetInvoicePolizaFlows_outParamList.CurrentRec.ssENFolioSociety.ssExternalId) : ((((localVars.queryResGetInvoicePolizaFlows_outParamList.CurrentRec.ssENInvoice.ssOrderMainId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ()))) ? (localVars.queryResGetInvoicePolizaFlows_outParamList.CurrentRec.ssENOrderSociety.ssExternalId) : (""))))))+localVars.queryResGetInvoicePolizaFlows_outParamList.CurrentRec.ssENInvoice.ssID_POLIZA_SAP)+Convert.ToString(BuiltInFunction.Year (BuiltInFunction.CurrDate ()))) },cancellationToken);

// GetInvoicePoliza2
localVars.resGetInvoicePoliza2_outParamRecord = await ExtendedActions.GetInvoicePoliza(requestContext,localVars.queryResGetInvoicePolizaFlows_outParamList.CurrentRec.ssENInvoicePoliza.ssId,cancellationToken);

// no Error
if(((localVars.resCall_ZMXFFIMF_0250_FI_CREATE_RELAT_outParamResponse.ssEV_ERROR_MESSAGE==""))) {
// GetInvoicePoliza2.Record.InvoicePoliza.Sent = True
localVars.resGetInvoicePoliza2_outParamRecord.ssENInvoicePoliza.ssSent = true;

// GetInvoicePoliza2.Record.InvoicePoliza.SentWhen = CurrDateTime
localVars.resGetInvoicePoliza2_outParamRecord.ssENInvoicePoliza.ssSentWhen = BuiltInFunction.CurrDateTime ();

// GetInvoicePoliza2.Record.InvoicePoliza.WithError = False
localVars.resGetInvoicePoliza2_outParamRecord.ssENInvoicePoliza.ssWithError = false;

// GetInvoicePoliza2.Record.InvoicePoliza.Error_Message = ""
localVars.resGetInvoicePoliza2_outParamRecord.ssENInvoicePoliza.ssError_Message = "";
} else {
// GetInvoicePoliza2.Record.InvoicePoliza.Sent = True
localVars.resGetInvoicePoliza2_outParamRecord.ssENInvoicePoliza.ssSent = true;

// GetInvoicePoliza2.Record.InvoicePoliza.SentWhen = CurrDateTime
localVars.resGetInvoicePoliza2_outParamRecord.ssENInvoicePoliza.ssSentWhen = BuiltInFunction.CurrDateTime ();

// GetInvoicePoliza2.Record.InvoicePoliza.WithError = True
localVars.resGetInvoicePoliza2_outParamRecord.ssENInvoicePoliza.ssWithError = true;

// GetInvoicePoliza2.Record.InvoicePoliza.Error_Message = Call_ZMXFFIMF_0250_FI_CREATE_RELAT.Response.EV_ERROR_MESSAGE
localVars.resGetInvoicePoliza2_outParamRecord.ssENInvoicePoliza.ssError_Message = localVars.resCall_ZMXFFIMF_0250_FI_CREATE_RELAT_outParamResponse.ssEV_ERROR_MESSAGE;
}

// UpdateInvoicePoliza
await ExtendedActions.UpdateInvoicePoliza(requestContext,localVars.resGetInvoicePoliza2_outParamRecord.ChangedAttributes,localVars.resGetInvoicePoliza2_outParamRecord,cancellationToken);

}

}

}

localVars.queryResGetInvoicePolizaFlows_outParamList.Advance();
}

} finally {
localVars.queryResGetInvoicePolizaFlows_outParamList.EndIteration();
}

} //close CreateActionActivity using block
} // try

catch (Exception ex) {
ApplicationLogger.Error(ex, "Error executing action");
requestContext.LastException = ex;

// Error Handler
await DatabaseAccess.RollbackAllTransactionsAsync(cancellationToken);

// LogMessage2
await ExtendedActions.LogMessage(requestContext,ex.Message,"Poliza Send Files",cancellationToken);

goto RETURN_STATEMENT;

} // Catch
finally {
cancellationToken.ThrowIfCancellationRequested();
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionTimer_InvoiceDocRelationSend {

private static async Task<RC_7cb091de697d14a1ce465208aa77fcb0> datasetGetInvoiceFilesByInvoiceIdReadDbAsync(RC_7cb091de697d14a1ce465208aa77fcb0 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoiceFile.Read( r, ref index);
rec.ssENStorage.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceFilesByInvoiceId" W9OoSlgOTEGEpIfvpvb3HQ of Action "Timer_InvoiceDocRelationSend"
public static async Task<(RL_e40371698c3bd2f83f525cf47c117634,long)> datasetGetInvoiceFilesByInvoiceId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceFile_InvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("Timer_InvoiceDocRelationSend.GetInvoiceFilesByInvoiceId", "4aa8d35b-0e58-414c-84a4-87efa6f6f71d");
using var queryActivity = activitySource.CreateAggregateQueryActivity("Timer_InvoiceDocRelationSend.GetInvoiceFilesByInvoiceId", "4aa8d35b-0e58-414c-84a4-87efa6f6f71d", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.1o4IzyqcA0eGG+6HJ3c0yw/NodesNotShownInESpaceTree.W9OoSlgOTEGEpIfvpvb3HQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, \"eninvoicefile22\".\"isreport\" o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, \"enstorage13\".\"istosendtoexternal\" o16, NULL o17, \"enstorage13\".\"isexternal\" o18, \"enstorage13\".\"archive_id\" o19, \"enstorage13\".\"arc_doc_id\" o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27");
fromBuilder.Append(" FROM ({InvoiceFile} \"eninvoicefile22\" Inner JOIN {Storage} \"enstorage13\" ON (\"eninvoicefile22\".\"storageid\" = \"enstorage13\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceFile_InvoiceId != 0) {
whereBuilder.Append("((\"eninvoicefile22\".\"invoiceid\" = @qpinInvoiceFile_InvoiceId) AND (\"eninvoicefile22\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceFile_InvoiceId", DbType.Int64, qpinInvoiceFile_InvoiceId);
} else {
whereBuilder.Append("(\"eninvoicefile22\".\"invoiceid\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"eninvoicefile22\".\"filename\" ASC ");
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
opt[0] = new BitArray(new bool[] {true, true, true, true, false, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, false, true, false, false, false, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query Timer_InvoiceDocRelationSend.GetInvoiceFilesByInvoiceId.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query Timer_InvoiceDocRelationSend.GetInvoiceFilesByInvoiceId.List", cancellationToken: cancellationToken);
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

private static async Task<RC_db98be0f77f582e2a41dd64bb6a4005e> datasetGetFolioFilesByFolioIdReadDbAsync(RC_db98be0f77f582e2a41dd64bb6a4005e rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolioFiles.Read( r, ref index);
rec.ssENStorage.Read( r, ref index);
return rec;
}
// Query Function "GetFolioFilesByFolioId" Cy3WuVGLAUuNcp0TEKUliQ of Action "Timer_InvoiceDocRelationSend"
public static async Task<(RL_599a55f2ca551e3817b27381ea3fcd80,long)> datasetGetFolioFilesByFolioId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolioFiles_FolioId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("Timer_InvoiceDocRelationSend.GetFolioFilesByFolioId", "b9d62d0b-8b51-4b01-8d72-9d1310a52589");
using var queryActivity = activitySource.CreateAggregateQueryActivity("Timer_InvoiceDocRelationSend.GetFolioFilesByFolioId", "b9d62d0b-8b51-4b01-8d72-9d1310a52589", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.1o4IzyqcA0eGG+6HJ3c0yw/NodesNotShownInESpaceTree.Cy3WuVGLAUuNcp0TEKUliQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, \"enstorage14\".\"istosendtoexternal\" o16, NULL o17, \"enstorage14\".\"isexternal\" o18, \"enstorage14\".\"archive_id\" o19, \"enstorage14\".\"arc_doc_id\" o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27");
fromBuilder.Append(" FROM ({FolioFiles} \"enfoliofiles4\" Inner JOIN {Storage} \"enstorage14\" ON (\"enfoliofiles4\".\"storageid\" = \"enstorage14\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoFolioFiles_FolioId != 0) {
whereBuilder.Append("((\"enfoliofiles4\".\"folioid\" = @qpfoFolioFiles_FolioId) AND (\"enfoliofiles4\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioFiles_FolioId", DbType.Int64, qpfoFolioFiles_FolioId);
} else {
whereBuilder.Append("(\"enfoliofiles4\".\"folioid\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"enfoliofiles4\".\"id\" DESC ");
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
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, false, true, false, false, false, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query Timer_InvoiceDocRelationSend.GetFolioFilesByFolioId.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query Timer_InvoiceDocRelationSend.GetFolioFilesByFolioId.List", cancellationToken: cancellationToken);
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

private static async Task<RC_60aeadfeb5acbf1f5997b0af030c3433> datasetGetInvoicePolizaFlowsReadDbAsync(RC_60aeadfeb5acbf1f5997b0af030c3433 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolio.Read( r, ref index);
rec.ssENFolioSociety.Read( r, ref index);
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoicePoliza.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssENOrderSociety.Read( r, ref index);
rec.ssENReqSociety.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
return rec;
}
// Query Function "GetInvoicePolizaFlows" LdAt_fixQk+9V8lOaS5f_w of Action "Timer_InvoiceDocRelationSend"
public static async Task<(RL_031b891075d450fa5dc6dea0047d0fa4,long)> datasetGetInvoicePolizaFlows(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("Timer_InvoiceDocRelationSend.GetInvoicePolizaFlows", "fd2dd02d-b1f8-4f42-bd57-c94e692e5fff");
using var queryActivity = activitySource.CreateAggregateQueryActivity("Timer_InvoiceDocRelationSend.GetInvoicePolizaFlows", "fd2dd02d-b1f8-4f42-bd57-c94e692e5fff", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Single
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
await using(var sqlCountCmd = trans.CreateCommand()){
string sql = "";
string sqlCount = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /UserActions.1o4IzyqcA0eGG+6HJ3c0yw/NodesNotShownInESpaceTree.LdAt_fixQk+9V8lOaS5f_w, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"enfolio53\".\"folionumber\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, \"enfoliosociety1\".\"externalid\" o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, \"eninvoice61\".\"id\" o31, NULL o32, \"eninvoice61\".\"requisitionid\" o33, \"eninvoice61\".\"folioid\" o34, \"eninvoice61\".\"ordermainid\" o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, \"eninvoice61\".\"id_poliza_sap\" o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, \"eninvoicepoliza2\".\"id\" o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, \"enordermain54\".\"ordernumber\" o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, \"enordersociety1\".\"externalid\" o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, NULL o103, NULL o104, \"enreqsociety1\".\"externalid\" o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, \"enrequisition57\".\"name\" o116, NULL o117, NULL o118, NULL o119, NULL o120, NULL o121, NULL o122, NULL o123, NULL o124, NULL o125, NULL o126, NULL o127, NULL o128, NULL o129, NULL o130, NULL o131, NULL o132, NULL o133, NULL o134, NULL o135, NULL o136, NULL o137, NULL o138, NULL o139, NULL o140, NULL o141, NULL o142, NULL o143, NULL o144, NULL o145, NULL o146, NULL o147, NULL o148, NULL o149, NULL o150, NULL o151, NULL o152, NULL o153, NULL o154, NULL o155, NULL o156, NULL o157, NULL o158, NULL o159, NULL o160, NULL o161, NULL o162, NULL o163, NULL o164, NULL o165, NULL o166, NULL o167, NULL o168, NULL o169, NULL o170, NULL o171, NULL o172");
fromBuilder.Append(" FROM (((((({InvoicePoliza} \"eninvoicepoliza2\" Inner JOIN {Invoice} \"eninvoice61\" ON (\"eninvoicepoliza2\".\"id\" = \"eninvoice61\".\"id\"))  Left JOIN {Requisition} \"enrequisition57\" ON (\"eninvoice61\".\"requisitionid\" = \"enrequisition57\".\"id\"))  Left JOIN {Folio} \"enfolio53\" ON (\"eninvoice61\".\"folioid\" = \"enfolio53\".\"id\"))  Left JOIN ({OrderMain} \"enordermain54\" Inner JOIN {Company} \"enordersociety1\" ON (\"enordermain54\".\"companyid\" = \"enordersociety1\".\"id\"))  ON (\"enfolio53\".\"orderid\" = \"enordermain54\".\"id\"))  Left JOIN {Company} \"enfoliosociety1\" ON (\"enfolio53\".\"companyid\" = \"enfoliosociety1\".\"id\"))  Left JOIN {Company} \"enreqsociety1\" ON (\"enrequisition57\".\"companyid\" = \"enreqsociety1\".\"id\")) ");
whereBuilder.Append(" WHERE (\"eninvoicepoliza2\".\"sent\" = 0) AND (\"eninvoicepoliza2\".\"error_message\" = '') AND ((\"eninvoice61\".\"invoicestatusid\" <> ");
whereBuilder.Append((ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("rN7AdMIY8UCc6++CrM79jQ"))).ssId);
whereBuilder.Append(") AND (\"eninvoice61\".\"invoicestatusid\" <> ");
whereBuilder.Append((ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("RteygpK6NkexqZHONe6zkg"))).ssId);
whereBuilder.Append("))");
orderByBuilder.Append(" ORDER BY \"eninvoicepoliza2\".\"polizaid\" ASC ");
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCount = "SELECT COUNT(1) " + fromBuilder.ToString() + whereBuilder.ToString() + groupByBuilder.ToString() + havingBuilder.ToString();
sqlCount = AppUtils.Instance.ReplaceEntityReferences(requestContext, sqlCount);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
sqlCountCmd.CommandText = sqlCount;
try {
RL_031b891075d450fa5dc6dea0047d0fa4 outParamList = new RL_031b891075d450fa5dc6dea0047d0fa4();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoicePolizaFlowsReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[8];
opt[0] = new BitArray(new bool[] {false, true, false, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true});
opt[6] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true});
opt[7] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query Timer_InvoiceDocRelationSend.GetInvoicePolizaFlows.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query Timer_InvoiceDocRelationSend.GetInvoicePolizaFlows.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_031b891075d450fa5dc6dea0047d0fa4 _tmp = new RL_031b891075d450fa5dc6dea0047d0fa4();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoicePolizaFlowsReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query Timer_InvoiceDocRelationSend.GetInvoicePolizaFlows.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_031b891075d450fa5dc6dea0047d0fa4)_tmp;
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query Timer_InvoiceDocRelationSend.GetInvoicePolizaFlows.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
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


}
