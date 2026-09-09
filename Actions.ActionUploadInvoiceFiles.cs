namespace ssConectaProveedores;

public partial class Actions {
public class lcvUploadInvoiceFiles : VarsBag {
public long inParamInvoiceId;
public long inParamRequisitionId;
public long inParamOrderMainId;
public long inParamFolioId;
public RL_7b4ceb84b6a1255d3a42c8932279bc3c inParamFilesList;
public RL_7b4ceb84b6a1255d3a42c8932279bc3c inParamExtraFilesList;
public bool inParamIgnoreCreation;
public ST_6f620840109ac6f721328b723ec0152cStructure inParamInvoiceForeign;
public decimal inParamInvoicesSum;
public bool inParamIsModify;
public bool inParamIsStartApproval;
public int inParamAccountingDataTypeId;
public long inParamOrderAccConceptsID;
public decimal inParamImportAnticipo;
public long inParamCreditNoteInvoiceId;
public int inParamOffsetUtc;
public Actions.lcoUploadInvoiceFiles_0AddData resUploadInvoiceFiles_0AddData =  new Actions.lcoUploadInvoiceFiles_0AddData();
public Actions.lcoUploadInvoiceFiles_1National resUploadInvoiceFiles_1National =  new Actions.lcoUploadInvoiceFiles_1National();
public Actions.lcoVerifyAnticipoConcept resVerifyAnticipoConcept =  new Actions.lcoVerifyAnticipoConcept();
public Actions.lcoUploadInvoiceFiles_2Foreigner resUploadInvoiceFiles_2Foreigner =  new Actions.lcoUploadInvoiceFiles_2Foreigner();
public RL_2cbca8577d8f7895afb5778093b67b34 queryResIsFolioConstruction_outParamList = new RL_2cbca8577d8f7895afb5778093b67b34();
public long queryResIsFolioConstruction_outParamCount = 0L;

public lcvUploadInvoiceFiles(long inParamInvoiceId, long inParamRequisitionId, long inParamOrderMainId, long inParamFolioId, RL_7b4ceb84b6a1255d3a42c8932279bc3c inParamFilesList, RL_7b4ceb84b6a1255d3a42c8932279bc3c inParamExtraFilesList, bool inParamIgnoreCreation, ST_6f620840109ac6f721328b723ec0152cStructure inParamInvoiceForeign, decimal inParamInvoicesSum, bool inParamIsModify, bool inParamIsStartApproval, int inParamAccountingDataTypeId, long inParamOrderAccConceptsID, decimal inParamImportAnticipo, long inParamCreditNoteInvoiceId, int inParamOffsetUtc) {
this.inParamInvoiceId = inParamInvoiceId;
this.inParamRequisitionId = inParamRequisitionId;
this.inParamOrderMainId = inParamOrderMainId;
this.inParamFolioId = inParamFolioId;
this.inParamFilesList = inParamFilesList;
this.inParamExtraFilesList = inParamExtraFilesList;
this.inParamIgnoreCreation = inParamIgnoreCreation;
this.inParamInvoiceForeign = inParamInvoiceForeign;
this.inParamInvoicesSum = inParamInvoicesSum;
this.inParamIsModify = inParamIsModify;
this.inParamIsStartApproval = inParamIsStartApproval;
this.inParamAccountingDataTypeId = inParamAccountingDataTypeId;
this.inParamOrderAccConceptsID = inParamOrderAccConceptsID;
this.inParamImportAnticipo = inParamImportAnticipo;
this.inParamCreditNoteInvoiceId = inParamCreditNoteInvoiceId;
this.inParamOffsetUtc = inParamOffsetUtc;
}
}
public class lcoUploadInvoiceFiles : VarsBag {
public string outParamErrorMsg = "";

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord outParamo_Invoice = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();

public EN_f81a3d226103fd013068b8763798067aEntityRecord outParamo_InvoiceExtended = new EN_f81a3d226103fd013068b8763798067aEntityRecord();

public string outParamClaveProdServ = "";

public string outParamTipoComprobante = "";

public bool outParamIsMissingCreditNote = false;

public lcoUploadInvoiceFiles() {
}
}
/// <summary>
/// Action <code>UploadInvoiceFiles</code> that represents the Service Studio action
///  <code>UploadInvoiceFiles</code> <p> Description: </p>
/// </summary>
public static async Task<(string,EN_d1d0320db36efbb094ad0082361435a0EntityRecord,EN_f81a3d226103fd013068b8763798067aEntityRecord,string,string,bool)> ActionUploadInvoiceFiles(IRequestContext requestContext,long inParamInvoiceId,long inParamRequisitionId,long inParamOrderMainId,long inParamFolioId,RL_7b4ceb84b6a1255d3a42c8932279bc3c inParamFilesList,RL_7b4ceb84b6a1255d3a42c8932279bc3c inParamExtraFilesList,bool inParamIgnoreCreation,ST_6f620840109ac6f721328b723ec0152cStructure inParamInvoiceForeign,decimal inParamInvoicesSum,bool inParamIsModify,bool inParamIsStartApproval,int inParamAccountingDataTypeId,long inParamOrderAccConceptsID,decimal inParamImportAnticipo,long inParamCreditNoteInvoiceId,int inParamOffsetUtc,CancellationToken cancellationToken) {
string outParamErrorMsg = default;
EN_d1d0320db36efbb094ad0082361435a0EntityRecord outParamo_Invoice = default;
EN_f81a3d226103fd013068b8763798067aEntityRecord outParamo_InvoiceExtended = default;
string outParamClaveProdServ = default;
string outParamTipoComprobante = default;
bool outParamIsMissingCreditNote = default;
lcoUploadInvoiceFiles result = new lcoUploadInvoiceFiles();
lcvUploadInvoiceFiles localVars = new lcvUploadInvoiceFiles(inParamInvoiceId, inParamRequisitionId, inParamOrderMainId, inParamFolioId, inParamFilesList, inParamExtraFilesList, inParamIgnoreCreation, inParamInvoiceForeign, inParamInvoicesSum, inParamIsModify, inParamIsStartApproval, inParamAccountingDataTypeId, inParamOrderAccConceptsID, inParamImportAnticipo, inParamCreditNoteInvoiceId, inParamOffsetUtc);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("UploadInvoiceFiles", "c2b9d2c3-0183-44c1-bfa5-8f77a41b98d2"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("UploadInvoiceFiles", "c2b9d2c3-0183-44c1-bfa5-8f77a41b98d2", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// VerifyAnticipoConcept
localVars.resVerifyAnticipoConcept.outParamErrorMsg = await Actions.ActionVerifyAnticipoConcept(requestContext,localVars.inParamOrderAccConceptsID,localVars.inParamImportAnticipo,cancellationToken);

// error
if(((localVars.resVerifyAnticipoConcept.outParamErrorMsg!=""))) {
// ErrorMsg = VerifyAnticipoConcept.ErrorMsg
result.outParamErrorMsg=localVars.resVerifyAnticipoConcept.outParamErrorMsg;
} else {
// UploadInvoiceFiles_0AddData
localVars.resUploadInvoiceFiles_0AddData.outParamUploadValidationData = await Actions.ActionUploadInvoiceFiles_0AddData(requestContext,localVars.inParamRequisitionId,localVars.inParamFolioId,localVars.inParamOrderMainId,cancellationToken);

// foreigner?
if((localVars.resUploadInvoiceFiles_0AddData.outParamUploadValidationData.ssSupplierIsForeigner)) {
// UploadInvoiceFiles_2Foreigner
(localVars.resUploadInvoiceFiles_2Foreigner.outParamErrorMsg,localVars.resUploadInvoiceFiles_2Foreigner.outParamInvoiceId_Out,localVars.resUploadInvoiceFiles_2Foreigner.outParamInvoice_Out) = await Actions.ActionUploadInvoiceFiles_2Foreigner(requestContext,localVars.inParamInvoiceId,localVars.inParamRequisitionId,localVars.inParamFolioId,localVars.inParamOrderMainId,localVars.inParamFilesList,localVars.inParamExtraFilesList,localVars.inParamIsStartApproval,localVars.inParamInvoiceForeign,localVars.resUploadInvoiceFiles_0AddData.outParamUploadValidationData,localVars.inParamOrderAccConceptsID,localVars.inParamOffsetUtc,cancellationToken);

// ErrorMsg = UploadInvoiceFiles_2Foreigner.ErrorMsg
result.outParamErrorMsg=localVars.resUploadInvoiceFiles_2Foreigner.outParamErrorMsg;

// o_Invoice = UploadInvoiceFiles_2Foreigner.Invoice_Out
result.outParamo_Invoice=localVars.resUploadInvoiceFiles_2Foreigner.outParamInvoice_Out;
} else {
// Query datasetIsFolioConstruction
cancellationToken.ThrowIfCancellationRequested();
int datasetIsFolioConstruction_maxRecords = 0;
int datasetIsFolioConstruction_startIndex = 0;(localVars.queryResIsFolioConstruction_outParamList,localVars.queryResIsFolioConstruction_outParamCount) = await FuncActionUploadInvoiceFiles.datasetIsFolioConstruction(requestContext,datasetIsFolioConstruction_maxRecords,datasetIsFolioConstruction_startIndex,IterationMultiplicity.Never,localVars.inParamFolioId,cancellationToken);

// UploadInvoiceFiles_1National
(localVars.resUploadInvoiceFiles_1National.outParamErrorMsg,localVars.resUploadInvoiceFiles_1National.outParamo_Invoice,localVars.resUploadInvoiceFiles_1National.outParamo_InvoiceExtended,localVars.resUploadInvoiceFiles_1National.outParamClaveProdServ,localVars.resUploadInvoiceFiles_1National.outParamTipoComprobante,localVars.resUploadInvoiceFiles_1National.outParamIsMissingCreditNote) = await Actions.ActionUploadInvoiceFiles_1National(requestContext,localVars.inParamInvoiceId,localVars.inParamRequisitionId,localVars.inParamOrderMainId,localVars.inParamFolioId,false,localVars.inParamFilesList,localVars.inParamExtraFilesList,localVars.inParamIsStartApproval,localVars.resUploadInvoiceFiles_0AddData.outParamUploadValidationData,localVars.inParamIgnoreCreation,localVars.inParamIsModify,localVars.inParamInvoicesSum,localVars.inParamOrderAccConceptsID,localVars.inParamAccountingDataTypeId,localVars.inParamImportAnticipo,localVars.inParamCreditNoteInvoiceId,localVars.inParamOffsetUtc,(!localVars.queryResIsFolioConstruction_outParamList.Empty),(((int)localVars.queryResIsFolioConstruction_outParamList.CurrentRec.ssENFolio.ssTotalAmount)),cancellationToken);

// ErrorMsg = UploadInvoiceFiles_1National.ErrorMsg
result.outParamErrorMsg=localVars.resUploadInvoiceFiles_1National.outParamErrorMsg;

// o_Invoice = UploadInvoiceFiles_1National.o_Invoice
result.outParamo_Invoice=localVars.resUploadInvoiceFiles_1National.outParamo_Invoice;

// o_InvoiceExtended = UploadInvoiceFiles_1National.o_InvoiceExtended
result.outParamo_InvoiceExtended=localVars.resUploadInvoiceFiles_1National.outParamo_InvoiceExtended;

// ClaveProdServ = UploadInvoiceFiles_1National.ClaveProdServ
result.outParamClaveProdServ=localVars.resUploadInvoiceFiles_1National.outParamClaveProdServ;

// TipoComprobante = UploadInvoiceFiles_1National.TipoComprobante
result.outParamTipoComprobante=localVars.resUploadInvoiceFiles_1National.outParamTipoComprobante;

// IsMissingCreditNote = UploadInvoiceFiles_1National.IsMissingCreditNote
result.outParamIsMissingCreditNote=localVars.resUploadInvoiceFiles_1National.outParamIsMissingCreditNote;
}

}

} //close CreateActionActivity using block
} // try

finally {
outParamErrorMsg = result.outParamErrorMsg;
outParamo_Invoice = result.outParamo_Invoice;
outParamo_InvoiceExtended = result.outParamo_InvoiceExtended;
outParamClaveProdServ = result.outParamClaveProdServ;
outParamTipoComprobante = result.outParamTipoComprobante;
outParamIsMissingCreditNote = result.outParamIsMissingCreditNote;
} // inner-finally
RETURN_STATEMENT:
return (outParamErrorMsg,outParamo_Invoice,outParamo_InvoiceExtended,outParamClaveProdServ,outParamTipoComprobante,outParamIsMissingCreditNote);
}

public static class FuncActionUploadInvoiceFiles {

private static async Task<RC_c72f9a44b3b624f179aa49efc0650682> datasetIsFolioConstructionReadDbAsync(RC_c72f9a44b3b624f179aa49efc0650682 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApprovalProcessType.Read( r, ref index);
rec.ssENFolio.Read( r, ref index);
return rec;
}
// Query Function "IsFolioConstruction" Xx4Qu8haqEy+uUALoQoUcw of Action "UploadInvoiceFiles"
public static async Task<(RL_2cbca8577d8f7895afb5778093b67b34,long)> datasetIsFolioConstruction(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolio_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("UploadInvoiceFiles.IsFolioConstruction", "bb101e5f-5ac8-4ca8-beb9-400ba10a1473");
using var queryActivity = activitySource.CreateAggregateQueryActivity("UploadInvoiceFiles.IsFolioConstruction", "bb101e5f-5ac8-4ca8-beb9-400ba10a1473", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.w9K5woMBwUS_pY93pBuY0g/NodesNotShownInESpaceTree.Xx4Qu8haqEy+uUALoQoUcw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, trim_scale(\"enfolio48\".\"totalamount\"::numeric) o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24");
fromBuilder.Append(" FROM ({Folio} \"enfolio48\" Left JOIN {ApprovalProcessType} \"enapprovalprocesstype\" ON (\"enfolio48\".\"approvalprocesstypeid\" = \"enapprovalprocesstype\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoFolio_Id != 0) {
whereBuilder.Append("((\"enfolio48\".\"id\" = @qpfoFolio_Id) AND (\"enfolio48\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolio_Id", DbType.Int64, qpfoFolio_Id);
} else {
whereBuilder.Append("(\"enfolio48\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (\"enapprovalprocesstype\".\"id\" = ");
whereBuilder.Append(1
);
whereBuilder.Append(")");
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
RL_2cbca8577d8f7895afb5778093b67b34 outParamList = new RL_2cbca8577d8f7895afb5778093b67b34();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetIsFolioConstructionReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query UploadInvoiceFiles.IsFolioConstruction.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_2cbca8577d8f7895afb5778093b67b34 _tmp = new RL_2cbca8577d8f7895afb5778093b67b34();
_tmp.AlternateReadDbMethodAsync = datasetIsFolioConstructionReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query UploadInvoiceFiles.IsFolioConstruction.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_2cbca8577d8f7895afb5778093b67b34)_tmp;
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
