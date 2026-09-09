namespace ssConectaProveedores;

public partial class Actions {
public class lcvEntryAccountingInvProcess_ValidCFDI : VarsBag {
public long inParamInvoiceId;
public string inParamInvoiceName;
public EN_d21666375df829d28ffce8e5e0a3400dEntityRecord inParamInvoiceAccountingProcess;
public string inParamSupplierNr;
public string inParamDivisionFI;
public string inParamCompanyExtId;
/// <summary>
/// Variable <code>l_StartedOn</code> that represents the Service Studio DateTime
///  <code>l_StartedOn</code> <p>Description: </p>
/// </summary>
public DateTime varLcl_StartedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);

public Actions.lcoActionTimestampsCreateOrUpdate resActionTimestampsCreateOrUpdate2 =  new Actions.lcoActionTimestampsCreateOrUpdate();
public Actions.lcoActionTimestampsCreateOrUpdate resActionTimestampsCreateOrUpdate =  new Actions.lcoActionTimestampsCreateOrUpdate();
public Actions.lcoUploadInvoiceFiles_ValidationServices resUploadInvoiceFiles_XMLValidationsPAC =  new Actions.lcoUploadInvoiceFiles_ValidationServices();
public byte[] resServiceStorageGetFile_outParamo_File = new byte[] {};
public string resServiceStorageGetFile_outParamo_filename = "";

public RL_00a03f803f0d49826089181417370afb queryResGetXMLInvoiceFileById_outParamList = new RL_00a03f803f0d49826089181417370afb();
public long queryResGetXMLInvoiceFileById_outParamCount = 0L;

public Actions.lcoActionTimestampsCreateOrUpdate resActionTimestampsCreateOrUpdate3 =  new Actions.lcoActionTimestampsCreateOrUpdate();
public lcvEntryAccountingInvProcess_ValidCFDI(long inParamInvoiceId, string inParamInvoiceName, EN_d21666375df829d28ffce8e5e0a3400dEntityRecord inParamInvoiceAccountingProcess, string inParamSupplierNr, string inParamDivisionFI, string inParamCompanyExtId) {
this.inParamInvoiceId = inParamInvoiceId;
this.inParamInvoiceName = inParamInvoiceName;
this.inParamInvoiceAccountingProcess = inParamInvoiceAccountingProcess;
this.inParamSupplierNr = inParamSupplierNr;
this.inParamDivisionFI = inParamDivisionFI;
this.inParamCompanyExtId = inParamCompanyExtId;
}
}
public class lcoEntryAccountingInvProcess_ValidCFDI : VarsBag {
public bool outParamIsSuccess = true;

public string outParamMessage = "";

public bool outParamCanTryAgain = false;

public lcoEntryAccountingInvProcess_ValidCFDI() {
}
}
/// <summary>
/// Action <code>EntryAccountingInvProcess_ValidCFDI</code> that represents the Service Studio action
///  <code>EntryAccountingInvProcess_ValidCFDI</code> <p> Description: </p>
/// </summary>
public static async Task<(bool,string,bool)> ActionEntryAccountingInvProcess_ValidCFDI(IRequestContext requestContext,long inParamInvoiceId,string inParamInvoiceName,EN_d21666375df829d28ffce8e5e0a3400dEntityRecord inParamInvoiceAccountingProcess,string inParamSupplierNr,string inParamDivisionFI,string inParamCompanyExtId,CancellationToken cancellationToken) {
bool outParamIsSuccess = default;
string outParamMessage = default;
bool outParamCanTryAgain = default;
lcoEntryAccountingInvProcess_ValidCFDI result = new lcoEntryAccountingInvProcess_ValidCFDI();
lcvEntryAccountingInvProcess_ValidCFDI localVars = new lcvEntryAccountingInvProcess_ValidCFDI(inParamInvoiceId, inParamInvoiceName, inParamInvoiceAccountingProcess, inParamSupplierNr, inParamDivisionFI, inParamCompanyExtId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("EntryAccountingInvProcess_ValidCFDI", "90c383b2-96e4-48f9-ab8e-582106f8e1c3"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("EntryAccountingInvProcess_ValidCFDI", "90c383b2-96e4-48f9-ab8e-582106f8e1c3", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// ActionTimestampsCreateOrUpdate
localVars.resActionTimestampsCreateOrUpdate.outParamId = await Actions.ActionActionTimestampsCreateOrUpdate(requestContext,new EN_b22d64c90281d09a316b6f4502a74326EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssDescription = ((("FCP ProcessId: "+BuiltInFunction.LongIntegerToText(localVars.inParamInvoiceAccountingProcess.ssId))+" | Invoice: ")+localVars.inParamInvoiceName), ssStartedOn = localVars.varLcl_StartedOn, ssFinishedOn = BuiltInFunction.CurrDateTime () },cancellationToken);

// Query datasetGetXMLInvoiceFileById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetXMLInvoiceFileById_maxRecords = 1;
if (datasetGetXMLInvoiceFileById_maxRecords < 1) datasetGetXMLInvoiceFileById_maxRecords = 1;
int datasetGetXMLInvoiceFileById_startIndex = 0;(localVars.queryResGetXMLInvoiceFileById_outParamList,localVars.queryResGetXMLInvoiceFileById_outParamCount) = await FuncActionEntryAccountingInvProcess_ValidCFDI.datasetGetXMLInvoiceFileById(requestContext,datasetGetXMLInvoiceFileById_maxRecords,datasetGetXMLInvoiceFileById_startIndex,IterationMultiplicity.Never,localVars.inParamInvoiceId,cancellationToken);

// l_StartedOn = CurrDateTime
localVars.varLcl_StartedOn=BuiltInFunction.CurrDateTime ();
// ServiceStorageGetFile
(localVars.resServiceStorageGetFile_outParamo_File,localVars.resServiceStorageGetFile_outParamo_filename) = await ServiceAPIs.ServiceAPIServiceStorageGetFile(requestContext,localVars.queryResGetXMLInvoiceFileById_outParamList.CurrentRec.ssENInvoiceFile.ssStorageId,cancellationToken);

// file error?
if((BinaryContentUtils.AreBothBinariesNull(localVars.resServiceStorageGetFile_outParamo_File, BuiltInFunction.NullBinary ()))) {
// IsSuccess = False
result.outParamIsSuccess=false;

// Message = "ERROR FETCHING INVOICE FILE"
result.outParamMessage=AppUtils.GetStringResource("S61B7DQFI0SFoCULUYgxDw#Value.-1310476113.1", "ERROR FETCHING INVOICE FILE");

// CanTryAgain = False
result.outParamCanTryAgain=false;
} else {
// ActionTimestampsCreateOrUpdate2
localVars.resActionTimestampsCreateOrUpdate2.outParamId = await Actions.ActionActionTimestampsCreateOrUpdate(requestContext,new EN_b22d64c90281d09a316b6f4502a74326EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssDescription = (("FCP ProcessId: "+BuiltInFunction.LongIntegerToText(localVars.inParamInvoiceAccountingProcess.ssId))+" - Get xml from storage"), ssStartedOn = localVars.varLcl_StartedOn, ssFinishedOn = BuiltInFunction.CurrDateTime () },cancellationToken);

// l_StartedOn = CurrDateTime
localVars.varLcl_StartedOn=BuiltInFunction.CurrDateTime ();
// UploadInvoiceFiles_XMLValidationsPAC
localVars.resUploadInvoiceFiles_XMLValidationsPAC.outParamErrorMsg = await Actions.ActionUploadInvoiceFiles_ValidationServices(requestContext,false,localVars.resServiceStorageGetFile_outParamo_File,localVars.resServiceStorageGetFile_outParamo_filename,localVars.inParamSupplierNr,localVars.inParamDivisionFI,localVars.inParamCompanyExtId,cancellationToken);

// ActionTimestampsCreateOrUpdate3
localVars.resActionTimestampsCreateOrUpdate3.outParamId = await Actions.ActionActionTimestampsCreateOrUpdate(requestContext,new EN_b22d64c90281d09a316b6f4502a74326EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssDescription = (("FCP ProcessId: "+BuiltInFunction.LongIntegerToText(localVars.inParamInvoiceAccountingProcess.ssId))+" - PAC validations"), ssStartedOn = localVars.varLcl_StartedOn, ssFinishedOn = BuiltInFunction.CurrDateTime () },cancellationToken);

// cfdi error?
if((((localVars.resUploadInvoiceFiles_XMLValidationsPAC.outParamErrorMsg!="")&&(!((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveSkipAccountingError]))))))) {
// IsSuccess = False
result.outParamIsSuccess=false;

// Message = UploadInvoiceFiles_XMLValidationsPAC.ErrorMsg
result.outParamMessage=localVars.resUploadInvoiceFiles_XMLValidationsPAC.outParamErrorMsg;
}

}

} //close CreateActionActivity using block
} // try

catch (Exception ex) {
ApplicationLogger.Error(ex, "Error executing action");
requestContext.LastException = ex;

// Error Handler

// IsSuccess = False
result.outParamIsSuccess=false;

// Message = "Error in SAP service. Please contact an administrator."
result.outParamMessage=AppUtils.GetStringResource("RWDMsvS4rkudUUUt8Aml2g#Value.-1562166652.1", "Error in SAP service. Please contact an administrator.");
goto RETURN_STATEMENT;

} // Catch
finally {
outParamIsSuccess = result.outParamIsSuccess;
outParamMessage = result.outParamMessage;
outParamCanTryAgain = result.outParamCanTryAgain;
cancellationToken.ThrowIfCancellationRequested();
} // inner-finally
RETURN_STATEMENT:
return (outParamIsSuccess,outParamMessage,outParamCanTryAgain);
}

public static class FuncActionEntryAccountingInvProcess_ValidCFDI {

// Query Function "GetXMLInvoiceFileById" yH_Rt1327UysYY7oGH12vQ of Action "EntryAccountingInvProcess_ValidCFDI"
public static async Task<(RL_00a03f803f0d49826089181417370afb,long)> datasetGetXMLInvoiceFileById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("EntryAccountingInvProcess_ValidCFDI.GetXMLInvoiceFileById", "b7d17fc8-f65d-4ced-ac61-8ee8187d76bd");
using var queryActivity = activitySource.CreateAggregateQueryActivity("EntryAccountingInvProcess_ValidCFDI.GetXMLInvoiceFileById", "b7d17fc8-f65d-4ced-ac61-8ee8187d76bd", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.soPDkOSW+UirjlghBvjhww/NodesNotShownInESpaceTree.yH_Rt1327UysYY7oGH12vQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, \"eninvoicefile12\".\"storageid\" o5, NULL o6, NULL o7");
fromBuilder.Append(" FROM {InvoiceFile} \"eninvoicefile12\"");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceId != 0) {
whereBuilder.Append("((\"eninvoicefile12\".\"invoiceid\" = @qpinInvoiceId) AND (\"eninvoicefile12\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceId", DbType.Int64, qpinInvoiceId);
} else {
whereBuilder.Append("(\"eninvoicefile12\".\"invoiceid\" IS NULL)");
}
whereBuilder.Append(" AND (NOT (\"eninvoicefile12\".\"isextra\" = 1)) AND (((CASE WHEN char_length(caseaccent_normalize('.xml' collate \"default\"))=0 THEN -1 ELSE (position(caseaccent_normalize('.xml' collate \"default\") in caseaccent_normalize((Lower(\"eninvoicefile12\".\"filename\")) collate \"default\"))-1) END)) <> (-1))");
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
RL_00a03f803f0d49826089181417370afb outParamList = new RL_00a03f803f0d49826089181417370afb();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, false, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query EntryAccountingInvProcess_ValidCFDI.GetXMLInvoiceFileById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_00a03f803f0d49826089181417370afb _tmp = new RL_00a03f803f0d49826089181417370afb();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query EntryAccountingInvProcess_ValidCFDI.GetXMLInvoiceFileById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_00a03f803f0d49826089181417370afb)_tmp;
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
