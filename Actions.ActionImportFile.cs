namespace ssConectaProveedores;

public partial class Actions {
public class lcvImportFile : VarsBag {
public string inParami_Filename;
public byte[] inParami_File;
public string inParami_CreatedBy;
/// <summary>
/// Variable <code>v_File</code> that represents the Service Studio File3 <code>v_File</code>
///  <p>Description: File</p>
/// </summary>
public EN_1d38c6a5bdfe9befe9c6396896ed360eEntityRecord varLcv_File = new EN_1d38c6a5bdfe9befe9c6396896ed360eEntityRecord();

/// <summary>
/// Variable <code>v_File_Extended</code> that represents the Service Studio FileExtended
///  <code>v_File_Extended</code> <p>Description: File_Extended</p>
/// </summary>
public EN_dcebdd8ba305133f41b1e1804925997fEntityRecord varLcv_File_Extended = new EN_dcebdd8ba305133f41b1e1804925997fEntityRecord();

/// <summary>
/// Variable <code>v_File_Import_Log</code> that represents the Service Studio FileImportLog
///  <code>v_File_Import_Log</code> <p>Description: File_Import_Log</p>
/// </summary>
public EN_57456f779b1d12573357da68381e59ceEntityRecord varLcv_File_Import_Log = new EN_57456f779b1d12573357da68381e59ceEntityRecord();

public Actions.lcoProposalFileImportLogCreateOrUpdate resProposalFileImportLogCreateOrUpdate =  new Actions.lcoProposalFileImportLogCreateOrUpdate();
public Actions.lcoProposalFileCreateOrUpdate resProposalFileCreateOrUpdate =  new Actions.lcoProposalFileCreateOrUpdate();
public Actions.lcoProposalFileExtendedCreateOrUpdate resProposalFileExtendedCreateOrUpdate =  new Actions.lcoProposalFileExtendedCreateOrUpdate();
public lcvImportFile(string inParami_Filename, byte[] inParami_File, string inParami_CreatedBy) {
this.inParami_Filename = inParami_Filename;
this.inParami_File = inParami_File;
this.inParami_CreatedBy = inParami_CreatedBy;
}
}
public class lcoImportFile : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Ouput = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public lcoImportFile() {
}
}
/// <summary>
/// Action <code>ImportFile</code> that represents the Service Studio action <code>ImportFile</code>
///  <p> Description: </p>
/// </summary>
public static async Task<ST_046fb53ebbe142526d95e87ef1ae9711Structure> ActionImportFile(IRequestContext requestContext,string inParami_Filename,byte[] inParami_File,string inParami_CreatedBy,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Ouput = default;
lcoImportFile result = new lcoImportFile();
lcvImportFile localVars = new lcvImportFile(inParami_Filename, inParami_File, inParami_CreatedBy);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("ImportFile", "6f26bf87-501f-4fca-9b10-18a5e8a7f3f6"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("ImportFile", "6f26bf87-501f-4fca-9b10-18a5e8a7f3f6", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// v_File.Binary = i_File
localVars.varLcv_File.ssBinary = localVars.inParami_File;

// v_File.CreatedBy = i_CreatedBy
localVars.varLcv_File.ssCreatedBy = localVars.inParami_CreatedBy;

// v_File.CreatedOn = CurrDateTime
localVars.varLcv_File.ssCreatedOn = BuiltInFunction.CurrDateTime ();
// ProposalFileCreateOrUpdate
localVars.resProposalFileCreateOrUpdate.outParamId = await Actions.ActionProposalFileCreateOrUpdate(requestContext,localVars.varLcv_File,cancellationToken);

// v_File_Extended.Id = ProposalFileCreateOrUpdate.Id
localVars.varLcv_File_Extended.ssId = localVars.resProposalFileCreateOrUpdate.outParamId;

// v_File_Extended.Filename = i_Filename
localVars.varLcv_File_Extended.ssFilename = localVars.inParami_Filename;

// v_File_Extended.IsProcessed = False
localVars.varLcv_File_Extended.ssIsProcessed = false;

// v_File_Extended.UploadedBy = i_CreatedBy
localVars.varLcv_File_Extended.ssUploadedBy = localVars.inParami_CreatedBy;

// v_File_Extended.UploadedOn = CurrDateTime
localVars.varLcv_File_Extended.ssUploadedOn = BuiltInFunction.CurrDateTime ();
// ProposalFileExtendedCreateOrUpdate
localVars.resProposalFileExtendedCreateOrUpdate.outParamId = await Actions.ActionProposalFileExtendedCreateOrUpdate(requestContext,localVars.varLcv_File_Extended,cancellationToken);

// v_File_Import_Log.FileId = ProposalFileCreateOrUpdate.Id
localVars.varLcv_File_Import_Log.ssFileId = localVars.resProposalFileCreateOrUpdate.outParamId;

// v_File_Import_Log.Timestamp = CurrDateTime
localVars.varLcv_File_Import_Log.ssTimestamp = BuiltInFunction.CurrDateTime ();

// v_File_Import_Log.ImportType = If
localVars.varLcv_File_Import_Log.ssImportType = (((localVars.inParami_CreatedBy==BuiltInFunction.NullTextIdentifier ())) ? (AppUtils.GetStringResource("GoeP7RyYr0KziEXnt05XlQ#Value.2052559.1", "Auto")) : (AppUtils.GetStringResource("GoeP7RyYr0KziEXnt05XlQ#Value.-1997548570.1", "Manual")));

// v_File_Import_Log.ImportedBy = i_CreatedBy
localVars.varLcv_File_Import_Log.ssImportedBy = localVars.inParami_CreatedBy;
// ProposalFileImportLogCreateOrUpdate
localVars.resProposalFileImportLogCreateOrUpdate.outParamId = await Actions.ActionProposalFileImportLogCreateOrUpdate(requestContext,localVars.varLcv_File_Import_Log,cancellationToken);

// o_Ouput
// o_Ouput.IsSuccess = True
result.outParamo_Ouput.ssIsSuccess = true;

// o_Ouput.Message = "File imported successfully!"
result.outParamo_Ouput.ssMessage = AppUtils.GetStringResource("1lGNcmacC0KfrkbZMj2NCA#Value.-1271188926.1", "File imported successfully!");

// o_Ouput.Lines = 0
result.outParamo_Ouput.ssLines = 0;
// WakeTimerProcessFileIntoProposal
await ExtendedActions.WakeTimerProcessFileIntoProposal(requestContext,cancellationToken);

} //close CreateActionActivity using block
} // try

catch (Exception ex) {
ApplicationLogger.Error(ex, "Error executing action");
requestContext.LastException = ex;

// Error Handler
await DatabaseAccess.RollbackAllTransactionsAsync(cancellationToken);

// o_Ouput.IsSuccess = False
result.outParamo_Ouput.ssIsSuccess = false;

// o_Ouput.Message = AllExceptions.ExceptionMessage
result.outParamo_Ouput.ssMessage = ex.Message;
goto RETURN_STATEMENT;

} // Catch
finally {
outParamo_Ouput = result.outParamo_Ouput;
cancellationToken.ThrowIfCancellationRequested();
} // inner-finally
RETURN_STATEMENT:
return outParamo_Ouput;
}

public static class FuncActionImportFile {



}


}
