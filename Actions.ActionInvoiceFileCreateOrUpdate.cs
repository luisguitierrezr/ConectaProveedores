namespace ssConectaProveedores;

public partial class Actions {
public class lcvInvoiceFileCreateOrUpdate : VarsBag {
public EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord inParamSource;
public long resCreateOrUpdateInvoiceFile_outParamId = 0L;

public lcvInvoiceFileCreateOrUpdate(EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoInvoiceFileCreateOrUpdate : VarsBag {
public long outParamId = 0L;

public lcoInvoiceFileCreateOrUpdate() {
}
}
/// <summary>
/// Action <code>InvoiceFileCreateOrUpdate</code> that represents the Service Studio action
///  <code>InvoiceFileCreateOrUpdate</code> <p> Description: Encapsulates the CreateOrUpdate entit
/// y action, enabling logic to run consistently before and after a record is created or modified.</p>
/// </summary>
public static async Task<long> ActionInvoiceFileCreateOrUpdate(IRequestContext requestContext,EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoInvoiceFileCreateOrUpdate result = new lcoInvoiceFileCreateOrUpdate();
lcvInvoiceFileCreateOrUpdate localVars = new lcvInvoiceFileCreateOrUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InvoiceFileCreateOrUpdate", "243bf408-fdae-46fc-87b1-c42b62fcbe55"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InvoiceFileCreateOrUpdate", "243bf408-fdae-46fc-87b1-c42b62fcbe55", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Is new record?
if(((localVars.inParamSource.ssId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// Set basic audit attributes
// Source.CreatedBy = GetUserId
localVars.inParamSource.ssCreatedBy = BuiltInFunction.GetUserId ();

// Source.CreatedOn = CurrDateTime
localVars.inParamSource.ssCreatedOn = BuiltInFunction.CurrDateTime ();
}

// CreateOrUpdateInvoiceFile
localVars.resCreateOrUpdateInvoiceFile_outParamId = await ExtendedActions.CreateOrUpdateInvoiceFile(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_18990af86f7169e92b712b468e13b947)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateOrUpdateInvoiceFile.Id
result.outParamId=localVars.resCreateOrUpdateInvoiceFile_outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionInvoiceFileCreateOrUpdate {



}


}
