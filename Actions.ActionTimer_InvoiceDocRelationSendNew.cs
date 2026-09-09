namespace ssConectaProveedores;

public partial class Actions {
public class lcvTimer_InvoiceDocRelationSendNew : VarsBag {
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

public RL_599a55f2ca551e3817b27381ea3fcd80 resListFilter3_outParamFilteredList = new RL_599a55f2ca551e3817b27381ea3fcd80();

public RL_031b891075d450fa5dc6dea0047d0fa4 queryResGetInvoicePolizaFlows_outParamList = new RL_031b891075d450fa5dc6dea0047d0fa4();
public long queryResGetInvoicePolizaFlows_outParamCount = 0L;

public RL_e40371698c3bd2f83f525cf47c117634 resListFilter_outParamFilteredList = new RL_e40371698c3bd2f83f525cf47c117634();

public RL_e240e727d6462f6e07612213b516cdd1 queryResGetRequisitionByIdContracFile2_outParamList = new RL_e240e727d6462f6e07612213b516cdd1();
public long queryResGetRequisitionByIdContracFile2_outParamCount = 0L;

public RL_4473325ccc2bbea6efef176371ffa07d queryResGetRequisitionByIdContracFile_outParamList = new RL_4473325ccc2bbea6efef176371ffa07d();
public long queryResGetRequisitionByIdContracFile_outParamCount = 0L;

public ST_31a464e509d55210f80b735594283423Structure resCall_ZMXFFIMF_0250_FI_CREATE_RELAT_outParamResponse = new ST_31a464e509d55210f80b735594283423Structure();

public RL_e40371698c3bd2f83f525cf47c117634 queryResGetInvoiceFilesByInvoiceId_outParamList = new RL_e40371698c3bd2f83f525cf47c117634();
public long queryResGetInvoiceFilesByInvoiceId_outParamCount = 0L;

public RC_14fd6714905cc16780383cc2da86ee0d resGetInvoicePoliza2_outParamRecord = new RC_14fd6714905cc16780383cc2da86ee0d();

public RL_599a55f2ca551e3817b27381ea3fcd80 queryResGetFolioFilesByFolioId_outParamList = new RL_599a55f2ca551e3817b27381ea3fcd80();
public long queryResGetFolioFilesByFolioId_outParamCount = 0L;

public RL_e40371698c3bd2f83f525cf47c117634 resListFilter2_outParamFilteredList = new RL_e40371698c3bd2f83f525cf47c117634();

public RL_e240e727d6462f6e07612213b516cdd1 resListFilter5_outParamFilteredList = new RL_e240e727d6462f6e07612213b516cdd1();

public RL_4473325ccc2bbea6efef176371ffa07d resListFilter4_outParamFilteredList = new RL_4473325ccc2bbea6efef176371ffa07d();

public lcvTimer_InvoiceDocRelationSendNew() {
}
}
/// <summary>
/// Action <code>Timer_InvoiceDocRelationSendNew</code> that represents the Service Studio action
///  <code>Timer_InvoiceDocRelationSendNew</code> <p> Description: </p>
/// </summary>
public static async Task ActionTimer_InvoiceDocRelationSendNew(IRequestContext requestContext,CancellationToken cancellationToken) {
lcvTimer_InvoiceDocRelationSendNew localVars = new lcvTimer_InvoiceDocRelationSendNew();
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("Timer_InvoiceDocRelationSendNew", "4a253209-3d4f-4d52-b2b9-ea1c3feb815a"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("Timer_InvoiceDocRelationSendNew", "4a253209-3d4f-4d52-b2b9-ea1c3feb815a", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
if((((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveDEV_TK411]))))) {
// Query datasetGetInvoicePolizaFlows
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoicePolizaFlows_maxRecords = 999999999;
if (datasetGetInvoicePolizaFlows_maxRecords < 1) datasetGetInvoicePolizaFlows_maxRecords = 1;
int datasetGetInvoicePolizaFlows_startIndex = 0;(localVars.queryResGetInvoicePolizaFlows_outParamList,localVars.queryResGetInvoicePolizaFlows_outParamCount) = await FuncActionTimer_InvoiceDocRelationSendNew.datasetGetInvoicePolizaFlows(requestContext,datasetGetInvoicePolizaFlows_maxRecords,datasetGetInvoicePolizaFlows_startIndex,IterationMultiplicity.Single,cancellationToken);

// LogMessage
await ExtendedActions.LogMessage(requestContext,("Total lines of Invoice Poliza:"+BuiltInFunction.LongIntegerToText(localVars.queryResGetInvoicePolizaFlows_outParamCount)),"Poliza Send Files",cancellationToken);

// Foreach GetInvoicePolizaFlows.List
localVars.queryResGetInvoicePolizaFlows_outParamList.StartIteration();
bool flagContinueTo_forEach = false;
bool flagContinueTo_forEach_1 = false;
bool flagContinueTo_forEach_2 = false;
try {while (!((localVars.queryResGetInvoicePolizaFlows_outParamList.Eof))) {
flagContinueTo_forEach = false;
flagContinueTo_forEach_1 = false;
flagContinueTo_forEach_2 = false;
// Query datasetGetInvoiceFilesByInvoiceId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceFilesByInvoiceId_maxRecords = 0;
int datasetGetInvoiceFilesByInvoiceId_startIndex = 0;(localVars.queryResGetInvoiceFilesByInvoiceId_outParamList,localVars.queryResGetInvoiceFilesByInvoiceId_outParamCount) = await FuncActionTimer_InvoiceDocRelationSendNew.datasetGetInvoiceFilesByInvoiceId(requestContext,datasetGetInvoiceFilesByInvoiceId_maxRecords,datasetGetInvoiceFilesByInvoiceId_startIndex,IterationMultiplicity.Multiple,localVars.queryResGetInvoicePolizaFlows_outParamList.CurrentRec.ssENInvoice.ssId,cancellationToken);

// ListFilter
localVars.resListFilter_outParamFilteredList = (((RL_e40371698c3bd2f83f525cf47c117634)await  localVars.queryResGetInvoiceFilesByInvoiceId_outParamList.FilterAsync(async (p, cancellationToken) => p.ssENInvoiceFile.ssIsReport, cancellationToken)));

// No Report File
if((!(localVars.resListFilter_outParamFilteredList.Empty))) {
bool block1 = false;
do {
block1 = false;
do {
// ListFilter2
localVars.resListFilter2_outParamFilteredList = (((RL_e40371698c3bd2f83f525cf47c117634)await  localVars.queryResGetInvoiceFilesByInvoiceId_outParamList.FilterAsync(async (p, cancellationToken) => ((!p.ssENStorage.ssIsExternal)&&p.ssENStorage.ssIstoSendToExternal), cancellationToken)));

// IsFolio?
if(((localVars.queryResGetInvoicePolizaFlows_outParamList.CurrentRec.ssENInvoice.ssFolioId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// Query datasetGetFolioFilesByFolioId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioFilesByFolioId_maxRecords = 0;
int datasetGetFolioFilesByFolioId_startIndex = 0;(localVars.queryResGetFolioFilesByFolioId_outParamList,localVars.queryResGetFolioFilesByFolioId_outParamCount) = await FuncActionTimer_InvoiceDocRelationSendNew.datasetGetFolioFilesByFolioId(requestContext,datasetGetFolioFilesByFolioId_maxRecords,datasetGetFolioFilesByFolioId_startIndex,IterationMultiplicity.Multiple,localVars.queryResGetInvoicePolizaFlows_outParamList.CurrentRec.ssENInvoice.ssFolioId,cancellationToken);

// No ConstructionFiles
if((!(localVars.queryResGetFolioFilesByFolioId_outParamList.Empty))) {
// ListFilter3
localVars.resListFilter3_outParamFilteredList = (((RL_599a55f2ca551e3817b27381ea3fcd80)await  localVars.queryResGetFolioFilesByFolioId_outParamList.FilterAsync(async (p, cancellationToken) => ((!p.ssENStorage.ssIsExternal)&&p.ssENStorage.ssIstoSendToExternal), cancellationToken)));

if(((!localVars.resListFilter3_outParamFilteredList.Empty))) {
// jump to block1
block1 = true;
break;
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

// Is Requisition
if(((localVars.queryResGetInvoicePolizaFlows_outParamList.CurrentRec.ssENInvoice.ssRequisitionId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// Query datasetGetRequisitionByIdContracFile
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionByIdContracFile_maxRecords = 0;
int datasetGetRequisitionByIdContracFile_startIndex = 0;(localVars.queryResGetRequisitionByIdContracFile_outParamList,localVars.queryResGetRequisitionByIdContracFile_outParamCount) = await FuncActionTimer_InvoiceDocRelationSendNew.datasetGetRequisitionByIdContracFile(requestContext,datasetGetRequisitionByIdContracFile_maxRecords,datasetGetRequisitionByIdContracFile_startIndex,IterationMultiplicity.Multiple,localVars.queryResGetInvoicePolizaFlows_outParamList.CurrentRec.ssENInvoice.ssRequisitionId,cancellationToken);

// ListFilter4
localVars.resListFilter4_outParamFilteredList = (((RL_4473325ccc2bbea6efef176371ffa07d)await  localVars.queryResGetRequisitionByIdContracFile_outParamList.FilterAsync(async (p, cancellationToken) => ((!p.ssENStorage.ssIsExternal)&&p.ssENStorage.ssIstoSendToExternal), cancellationToken)));

if((!((!localVars.resListFilter4_outParamFilteredList.Empty)))) {
// ListClearAUX2
await ExtendedActions.ListClear(requestContext,localVars.varLcIT_ATTACHMENTAux,cancellationToken);

// ListAppendAllAUX3
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcIT_ATTACHMENTAux,(await RL_cff0038616a202f621fb7082f988995f.ConvertAsync(localVars.queryResGetRequisitionByIdContracFile_outParamList, new RL_cff0038616a202f621fb7082f988995f(), async (RC_409326af30f6b67f1d011aa096c0a54e source, ST_7816c3c943d129234de46d39c32a618eStructure target, CancellationToken cancellationToken) => {
target.ssARC_DOC_ID = source.ssENStorage.ssArc_Doc_ID;
target.ssARCHIV_ID = source.ssENStorage.ssArchive_ID;
return target;
}, cancellationToken)),cancellationToken);

// Query datasetGetRequisitionByIdContracFile2
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionByIdContracFile2_maxRecords = 0;
int datasetGetRequisitionByIdContracFile2_startIndex = 0;(localVars.queryResGetRequisitionByIdContracFile2_outParamList,localVars.queryResGetRequisitionByIdContracFile2_outParamCount) = await FuncActionTimer_InvoiceDocRelationSendNew.datasetGetRequisitionByIdContracFile2(requestContext,datasetGetRequisitionByIdContracFile2_maxRecords,datasetGetRequisitionByIdContracFile2_startIndex,IterationMultiplicity.Multiple,localVars.queryResGetInvoicePolizaFlows_outParamList.CurrentRec.ssENInvoice.ssRequisitionId,cancellationToken);

// ListFilter5
localVars.resListFilter5_outParamFilteredList = (((RL_e240e727d6462f6e07612213b516cdd1)await  localVars.queryResGetRequisitionByIdContracFile2_outParamList.FilterAsync(async (p, cancellationToken) => ((!p.ssENStorage.ssIsExternal)&&p.ssENStorage.ssIstoSendToExternal), cancellationToken)));

if(((!localVars.resListFilter5_outParamFilteredList.Empty))) {
// ly
} else {
// ListAppendAllAUX4
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcIT_ATTACHMENTAux,(await RL_cff0038616a202f621fb7082f988995f.ConvertAsync(localVars.queryResGetRequisitionByIdContracFile2_outParamList, new RL_cff0038616a202f621fb7082f988995f(), async (RC_b9bb40a47bdab047afc7e2a4a1fde846 source, ST_7816c3c943d129234de46d39c32a618eStructure target, CancellationToken cancellationToken) => {
target.ssARC_DOC_ID = source.ssENStorage.ssArc_Doc_ID;
target.ssARCHIV_ID = source.ssENStorage.ssArchive_ID;
return target;
}, cancellationToken)),cancellationToken);

// ly
break;
}

}

// ly
// jump to block1
block1 = true;
break;
}

} while(false)
;
if(block1) {
break;
}

if(((!localVars.resListFilter2_outParamFilteredList.Empty))) {
localVars.queryResGetInvoicePolizaFlows_outParamList.Advance();
// continue to flagContinueTo_forEach
flagContinueTo_forEach = true;
break;
} else {
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

if((localVars.varLcIT_ATTACHMENT.Empty)) {
localVars.queryResGetInvoicePolizaFlows_outParamList.Advance();
// continue to flagContinueTo_forEach_2
flagContinueTo_forEach_2 = true;
break;
} else {
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

// ly
localVars.queryResGetInvoicePolizaFlows_outParamList.Advance();
// continue to flagContinueTo_forEach_1
flagContinueTo_forEach_1 = true;
break;
}

}

} while(false)
;
if((flagContinueTo_forEach || (flagContinueTo_forEach_1 || flagContinueTo_forEach_2))) {
continue;
}

// ly
// ly
}

localVars.queryResGetInvoicePolizaFlows_outParamList.Advance();
}

} finally {
localVars.queryResGetInvoicePolizaFlows_outParamList.EndIteration();
}

} else {
// Timer_InvoiceDocRelationSend
await Actions.ActionTimer_InvoiceDocRelationSend(requestContext,cancellationToken);

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

public static class FuncActionTimer_InvoiceDocRelationSendNew {

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
// Query Function "GetInvoicePolizaFlows" C_j5G7fKpUyBrpeI6DmGzg of Action "Timer_InvoiceDocRelationSendNew"
public static async Task<(RL_031b891075d450fa5dc6dea0047d0fa4,long)> datasetGetInvoicePolizaFlows(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("Timer_InvoiceDocRelationSendNew.GetInvoicePolizaFlows", "1bf9f80b-cab7-4ca5-81ae-9788e83986ce");
using var queryActivity = activitySource.CreateAggregateQueryActivity("Timer_InvoiceDocRelationSendNew.GetInvoicePolizaFlows", "1bf9f80b-cab7-4ca5-81ae-9788e83986ce", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.CTIlSk89Uk2yueocP+uBWg/NodesNotShownInESpaceTree.C_j5G7fKpUyBrpeI6DmGzg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"enfolio12\".\"folionumber\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, \"enfoliosociety\".\"externalid\" o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, \"eninvoice14\".\"id\" o31, NULL o32, \"eninvoice14\".\"requisitionid\" o33, \"eninvoice14\".\"folioid\" o34, \"eninvoice14\".\"ordermainid\" o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, \"eninvoice14\".\"id_poliza_sap\" o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, \"eninvoicepoliza\".\"id\" o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, \"enordermain20\".\"ordernumber\" o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, \"enordersociety\".\"externalid\" o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, NULL o103, NULL o104, \"enreqsociety\".\"externalid\" o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, \"enrequisition21\".\"name\" o116, NULL o117, NULL o118, NULL o119, NULL o120, NULL o121, NULL o122, NULL o123, NULL o124, NULL o125, NULL o126, NULL o127, NULL o128, NULL o129, NULL o130, NULL o131, NULL o132, NULL o133, NULL o134, NULL o135, NULL o136, NULL o137, NULL o138, NULL o139, NULL o140, NULL o141, NULL o142, NULL o143, NULL o144, NULL o145, NULL o146, NULL o147, NULL o148, NULL o149, NULL o150, NULL o151, NULL o152, NULL o153, NULL o154, NULL o155, NULL o156, NULL o157, NULL o158, NULL o159, NULL o160, NULL o161, NULL o162, NULL o163, NULL o164, NULL o165, NULL o166, NULL o167, NULL o168, NULL o169, NULL o170, NULL o171, NULL o172");
fromBuilder.Append(" FROM (((((({InvoicePoliza} \"eninvoicepoliza\" Inner JOIN {Invoice} \"eninvoice14\" ON (\"eninvoicepoliza\".\"id\" = \"eninvoice14\".\"id\"))  Left JOIN {Requisition} \"enrequisition21\" ON (\"eninvoice14\".\"requisitionid\" = \"enrequisition21\".\"id\"))  Left JOIN {Folio} \"enfolio12\" ON (\"eninvoice14\".\"folioid\" = \"enfolio12\".\"id\"))  Left JOIN ({OrderMain} \"enordermain20\" Inner JOIN {Company} \"enordersociety\" ON (\"enordermain20\".\"companyid\" = \"enordersociety\".\"id\"))  ON (\"enfolio12\".\"orderid\" = \"enordermain20\".\"id\"))  Left JOIN {Company} \"enfoliosociety\" ON (\"enfolio12\".\"companyid\" = \"enfoliosociety\".\"id\"))  Left JOIN {Company} \"enreqsociety\" ON (\"enrequisition21\".\"companyid\" = \"enreqsociety\".\"id\")) ");
whereBuilder.Append(" WHERE (\"eninvoicepoliza\".\"sent\" = 0) AND (\"eninvoicepoliza\".\"error_message\" = '') AND ((\"eninvoice14\".\"invoicestatusid\" <> ");
whereBuilder.Append((ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("rN7AdMIY8UCc6++CrM79jQ"))).ssId);
whereBuilder.Append(") AND (\"eninvoice14\".\"invoicestatusid\" <> ");
whereBuilder.Append((ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("RteygpK6NkexqZHONe6zkg"))).ssId);
whereBuilder.Append("))");
orderByBuilder.Append(" ORDER BY \"eninvoicepoliza\".\"polizaid\" ASC ");
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
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query Timer_InvoiceDocRelationSendNew.GetInvoicePolizaFlows.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query Timer_InvoiceDocRelationSendNew.GetInvoicePolizaFlows.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query Timer_InvoiceDocRelationSendNew.GetInvoicePolizaFlows.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_031b891075d450fa5dc6dea0047d0fa4)_tmp;
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query Timer_InvoiceDocRelationSendNew.GetInvoicePolizaFlows.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
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

private static async Task<RC_b9bb40a47bdab047afc7e2a4a1fde846> datasetGetRequisitionByIdContracFile2ReadDbAsync(RC_b9bb40a47bdab047afc7e2a4a1fde846 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENRequisition.Read( r, ref index);
rec.ssENRequisitionAccConcepts.Read( r, ref index);
rec.ssENRequisitionAccounting.Read( r, ref index);
rec.ssENRequisitionFile2.Read( r, ref index);
rec.ssENStorage.Read( r, ref index);
return rec;
}
// Query Function "GetRequisitionByIdContracFile2" FJEzM3gaS0m5WCnnMC8gDQ of Action "Timer_InvoiceDocRelationSendNew"
public static async Task<(RL_e240e727d6462f6e07612213b516cdd1,long)> datasetGetRequisitionByIdContracFile2(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisition_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("Timer_InvoiceDocRelationSendNew.GetRequisitionByIdContracFile2", "33339114-1a78-494b-b958-29e7302f200d");
using var queryActivity = activitySource.CreateAggregateQueryActivity("Timer_InvoiceDocRelationSendNew.GetRequisitionByIdContracFile2", "33339114-1a78-494b-b958-29e7302f200d", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.CTIlSk89Uk2yueocP+uBWg/NodesNotShownInESpaceTree.FJEzM3gaS0m5WCnnMC8gDQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, \"enstorage2\".\"istosendtoexternal\" o101, NULL o102, \"enstorage2\".\"isexternal\" o103, \"enstorage2\".\"archive_id\" o104, \"enstorage2\".\"arc_doc_id\" o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, NULL o111, NULL o112");
fromBuilder.Append(" FROM (((({Requisition} \"enrequisition22\" Inner JOIN {RequisitionAccounting} \"enrequisitionaccounting\" ON (\"enrequisition22\".\"id\" = \"enrequisitionaccounting\".\"requisitionid\"))  Inner JOIN {RequisitionAccConcepts} \"enrequisitionaccconcepts\" ON (\"enrequisitionaccounting\".\"id\" = \"enrequisitionaccconcepts\".\"requisitionaccountingid\"))  Inner JOIN {RequisitionFile2} \"enrequisitionfile22\" ON (\"enrequisitionaccounting\".\"evidencefileid\" = \"enrequisitionfile22\".\"id\"))  Inner JOIN {Storage} \"enstorage2\" ON (\"enrequisitionfile22\".\"storageid\" = \"enstorage2\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpreRequisition_Id != 0) {
whereBuilder.Append("((\"enrequisition22\".\"id\" = @qpreRequisition_Id) AND (\"enrequisition22\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisition_Id", DbType.Int64, qpreRequisition_Id);
} else {
whereBuilder.Append("(\"enrequisition22\".\"id\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"enrequisition22\".\"name\" ASC ");
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
RL_e240e727d6462f6e07612213b516cdd1 outParamList = new RL_e240e727d6462f6e07612213b516cdd1();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetRequisitionByIdContracFile2ReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[5];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, false, true, false, false, false, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query Timer_InvoiceDocRelationSendNew.GetRequisitionByIdContracFile2.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_e240e727d6462f6e07612213b516cdd1 _tmp = new RL_e240e727d6462f6e07612213b516cdd1();
_tmp.AlternateReadDbMethodAsync = datasetGetRequisitionByIdContracFile2ReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query Timer_InvoiceDocRelationSendNew.GetRequisitionByIdContracFile2.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_e240e727d6462f6e07612213b516cdd1)_tmp;
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

private static async Task<RC_409326af30f6b67f1d011aa096c0a54e> datasetGetRequisitionByIdContracFileReadDbAsync(RC_409326af30f6b67f1d011aa096c0a54e rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENRequisition.Read( r, ref index);
rec.ssENRequisitionContractFile.Read( r, ref index);
rec.ssENRequisitionFile2.Read( r, ref index);
rec.ssENStorage.Read( r, ref index);
return rec;
}
// Query Function "GetRequisitionByIdContracFile" fH00NSBj7EC2nDQolOKLkA of Action "Timer_InvoiceDocRelationSendNew"
public static async Task<(RL_4473325ccc2bbea6efef176371ffa07d,long)> datasetGetRequisitionByIdContracFile(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisition_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("Timer_InvoiceDocRelationSendNew.GetRequisitionByIdContracFile", "35347d7c-6320-40ec-b69c-342894e28b90");
using var queryActivity = activitySource.CreateAggregateQueryActivity("Timer_InvoiceDocRelationSendNew.GetRequisitionByIdContracFile", "35347d7c-6320-40ec-b69c-342894e28b90", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.CTIlSk89Uk2yueocP+uBWg/NodesNotShownInESpaceTree.fH00NSBj7EC2nDQolOKLkA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, \"enstorage3\".\"istosendtoexternal\" o83, NULL o84, \"enstorage3\".\"isexternal\" o85, \"enstorage3\".\"archive_id\" o86, \"enstorage3\".\"arc_doc_id\" o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94");
fromBuilder.Append(" FROM ((({Requisition} \"enrequisition23\" Inner JOIN {RequisitionContractFile} \"enrequisitioncontractfile3\" ON (\"enrequisition23\".\"id\" = \"enrequisitioncontractfile3\".\"requisitionid\"))  Inner JOIN {RequisitionFile2} \"enrequisitionfile23\" ON (\"enrequisitioncontractfile3\".\"requisitionfileid\" = \"enrequisitionfile23\".\"id\"))  Inner JOIN {Storage} \"enstorage3\" ON (\"enrequisitionfile23\".\"storageid\" = \"enstorage3\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpreRequisition_Id != 0) {
whereBuilder.Append("((\"enrequisition23\".\"id\" = @qpreRequisition_Id) AND (\"enrequisition23\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisition_Id", DbType.Int64, qpreRequisition_Id);
} else {
whereBuilder.Append("(\"enrequisition23\".\"id\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"enrequisition23\".\"name\" ASC ");
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
RL_4473325ccc2bbea6efef176371ffa07d outParamList = new RL_4473325ccc2bbea6efef176371ffa07d();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetRequisitionByIdContracFileReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[4];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, false, true, false, false, false, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query Timer_InvoiceDocRelationSendNew.GetRequisitionByIdContracFile.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_4473325ccc2bbea6efef176371ffa07d _tmp = new RL_4473325ccc2bbea6efef176371ffa07d();
_tmp.AlternateReadDbMethodAsync = datasetGetRequisitionByIdContracFileReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query Timer_InvoiceDocRelationSendNew.GetRequisitionByIdContracFile.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_4473325ccc2bbea6efef176371ffa07d)_tmp;
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

private static async Task<RC_7cb091de697d14a1ce465208aa77fcb0> datasetGetInvoiceFilesByInvoiceIdReadDbAsync(RC_7cb091de697d14a1ce465208aa77fcb0 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoiceFile.Read( r, ref index);
rec.ssENStorage.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceFilesByInvoiceId" MMiYTnIKiUCsZdRwGxn4aA of Action "Timer_InvoiceDocRelationSendNew"
public static async Task<(RL_e40371698c3bd2f83f525cf47c117634,long)> datasetGetInvoiceFilesByInvoiceId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceFile_InvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("Timer_InvoiceDocRelationSendNew.GetInvoiceFilesByInvoiceId", "4e98c830-0a72-4089-ac65-d4701b19f868");
using var queryActivity = activitySource.CreateAggregateQueryActivity("Timer_InvoiceDocRelationSendNew.GetInvoiceFilesByInvoiceId", "4e98c830-0a72-4089-ac65-d4701b19f868", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.CTIlSk89Uk2yueocP+uBWg/NodesNotShownInESpaceTree.MMiYTnIKiUCsZdRwGxn4aA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, \"eninvoicefile3\".\"isreport\" o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, \"enstorage4\".\"istosendtoexternal\" o16, NULL o17, \"enstorage4\".\"isexternal\" o18, \"enstorage4\".\"archive_id\" o19, \"enstorage4\".\"arc_doc_id\" o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27");
fromBuilder.Append(" FROM ({InvoiceFile} \"eninvoicefile3\" Inner JOIN {Storage} \"enstorage4\" ON (\"eninvoicefile3\".\"storageid\" = \"enstorage4\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceFile_InvoiceId != 0) {
whereBuilder.Append("((\"eninvoicefile3\".\"invoiceid\" = @qpinInvoiceFile_InvoiceId) AND (\"eninvoicefile3\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceFile_InvoiceId", DbType.Int64, qpinInvoiceFile_InvoiceId);
} else {
whereBuilder.Append("(\"eninvoicefile3\".\"invoiceid\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"eninvoicefile3\".\"filename\" ASC ");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query Timer_InvoiceDocRelationSendNew.GetInvoiceFilesByInvoiceId.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query Timer_InvoiceDocRelationSendNew.GetInvoiceFilesByInvoiceId.List", cancellationToken: cancellationToken);
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
// Query Function "GetFolioFilesByFolioId" zKLhecKoHE2MM+d3ucNjlA of Action "Timer_InvoiceDocRelationSendNew"
public static async Task<(RL_599a55f2ca551e3817b27381ea3fcd80,long)> datasetGetFolioFilesByFolioId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolioFiles_FolioId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("Timer_InvoiceDocRelationSendNew.GetFolioFilesByFolioId", "79e1a2cc-a8c2-4d1c-8c33-e777b9c36394");
using var queryActivity = activitySource.CreateAggregateQueryActivity("Timer_InvoiceDocRelationSendNew.GetFolioFilesByFolioId", "79e1a2cc-a8c2-4d1c-8c33-e777b9c36394", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.CTIlSk89Uk2yueocP+uBWg/NodesNotShownInESpaceTree.zKLhecKoHE2MM+d3ucNjlA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, \"enstorage5\".\"istosendtoexternal\" o16, NULL o17, \"enstorage5\".\"isexternal\" o18, \"enstorage5\".\"archive_id\" o19, \"enstorage5\".\"arc_doc_id\" o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27");
fromBuilder.Append(" FROM ({FolioFiles} \"enfoliofiles\" Inner JOIN {Storage} \"enstorage5\" ON (\"enfoliofiles\".\"storageid\" = \"enstorage5\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoFolioFiles_FolioId != 0) {
whereBuilder.Append("((\"enfoliofiles\".\"folioid\" = @qpfoFolioFiles_FolioId) AND (\"enfoliofiles\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioFiles_FolioId", DbType.Int64, qpfoFolioFiles_FolioId);
} else {
whereBuilder.Append("(\"enfoliofiles\".\"folioid\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"enfoliofiles\".\"id\" DESC ");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query Timer_InvoiceDocRelationSendNew.GetFolioFilesByFolioId.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query Timer_InvoiceDocRelationSendNew.GetFolioFilesByFolioId.List", cancellationToken: cancellationToken);
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
