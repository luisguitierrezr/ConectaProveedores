using System.Diagnostics;
using ssConectaProveedores;

namespace ssConectaProveedores.CsRESTExpose.CsImportarArchivosAPI;

public class CsImportarArchivosAPIControllerFlows {
    private static readonly ActivitySource activitySource = new(typeof(CsImportarArchivosAPIControllerFlows).Namespace);
public class lcvComisionesArrendamientos : VarsBag {
public string inParami_APIKey;
public string inParami_Filename;
public string inParami_File;
public Actions.lcoImportFileBase64 resImportFileBase642 =  new Actions.lcoImportFileBase64();
public lcvComisionesArrendamientos(string inParami_APIKey, string inParami_Filename, string inParami_File) {
this.inParami_APIKey = inParami_APIKey;
this.inParami_Filename = inParami_Filename;
this.inParami_File = inParami_File;
}
}
public class lcoComisionesArrendamientos : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_API_Ouput = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public lcoComisionesArrendamientos() {
}
}
/// <summary>
/// Action <code>ComisionesArrendamientos</code> that represents the Service Studio action
///  <code>ComisionesArrendamientos</code> <p> Description: ComisionesArrendamientos</p>
/// </summary>
public static async Task<ST_046fb53ebbe142526d95e87ef1ae9711Structure> FlowImportarArchivosAPIActionComisionesArrendamientos(IRequestContext requestContext,string inParami_APIKey,string inParami_Filename,string inParami_File,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_API_Ouput = default;
lcoComisionesArrendamientos result = new lcoComisionesArrendamientos();
lcvComisionesArrendamientos localVars = new lcvComisionesArrendamientos(inParami_APIKey, inParami_Filename, inParami_File);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateRestExposeActionMetric("ComisionesArrendamientos", "44961d26-0f96-482c-a41c-8373d2756c73"))
using (activitySource.CreateCustomActionActivity("REST (Expose)", "ComisionesArrendamientos", "44961d26-0f96-482c-a41c-8373d2756c73", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828")){
// CheckAPIKey
if(((localVars.inParami_APIKey==((((string)AppUtils.SiteProperties[SitePropertiesModel.spAPIKey_RPA_CyA])))))) {
// ImportFileBase642
localVars.resImportFileBase642.outParamo_Ouput = await Actions.ActionImportFileBase64(requestContext,localVars.inParami_Filename,localVars.inParami_File,BuiltInFunction.NullTextIdentifier (),cancellationToken);

// o_API_Ouput = ImportFileBase642.o_Ouput
result.outParamo_API_Ouput=localVars.resImportFileBase642.outParamo_Ouput;
} else {
// RaiseError ApiKey
throw new Ex_ApiKeyUserException (AppUtils.GetStringResource("IALEmTPn_0WQ8Ln8xBsNyQ#Message.-1592369274.1", "Wrong API Key"));

}

} //close CreateActionActivity using block
} // try

catch (Exception ex) {
ApplicationLogger.Error(ex, "Error executing action");
requestContext.LastException = ex;

// Error Handler
await DatabaseAccess.RollbackAllTransactionsAsync(cancellationToken);

// o_API_Ouput.IsSuccess = False
result.outParamo_API_Ouput.ssIsSuccess = false;

// o_API_Ouput.Message = AllExceptions.ExceptionMessage
result.outParamo_API_Ouput.ssMessage = ex.Message;
goto RETURN_STATEMENT;

} // Catch
finally {
outParamo_API_Ouput = result.outParamo_API_Ouput;
cancellationToken.ThrowIfCancellationRequested();
} // inner-finally
RETURN_STATEMENT:
return outParamo_API_Ouput;
}

public static class FuncFlowImportarArchivosAPIActionComisionesArrendamientos {



}

/// <summary>
/// Action <code>OnAuthentication</code> that represents the Service Studio action
///  <code>OnAuthentication</code> <p> Description: </p>
/// </summary>
public static async Task FlowImportarArchivosAPIActionOnAuthentication(IRequestContext requestContext,CancellationToken cancellationToken) {
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateRestExposeActionMetric("OnAuthentication", "4fa9cdec-95d6-4c53-8139-a6664257100c"))
using (activitySource.CreateCustomActionActivity("REST (Expose)", "OnAuthentication", "4fa9cdec-95d6-4c53-8139-a6664257100c", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828")){
} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncFlowImportarArchivosAPIActionOnAuthentication {



}


}
