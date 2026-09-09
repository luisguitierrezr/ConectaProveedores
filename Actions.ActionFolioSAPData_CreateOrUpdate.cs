namespace ssConectaProveedores;

public partial class Actions {
public class lcvFolioSAPData_CreateOrUpdate : VarsBag {
public EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord inParamSource;
public long resCreateOrUpdateFolioSAPData_outParamId = 0L;

public lcvFolioSAPData_CreateOrUpdate(EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoFolioSAPData_CreateOrUpdate : VarsBag {
public long outParamId = 0L;

public lcoFolioSAPData_CreateOrUpdate() {
}
}
/// <summary>
/// Action <code>FolioSAPData_CreateOrUpdate</code> that represents the Service Studio action
///  <code>FolioSAPData_CreateOrUpdate</code> <p> Description: Encapsulates the Update entity action
/// , enabling logic to run consistently before and after a record is modified.</p>
/// </summary>
public static async Task<long> ActionFolioSAPData_CreateOrUpdate(IRequestContext requestContext,EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoFolioSAPData_CreateOrUpdate result = new lcoFolioSAPData_CreateOrUpdate();
lcvFolioSAPData_CreateOrUpdate localVars = new lcvFolioSAPData_CreateOrUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("FolioSAPData_CreateOrUpdate", "7afe9474-10e7-49df-9791-99effcac5367"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("FolioSAPData_CreateOrUpdate", "7afe9474-10e7-49df-9791-99effcac5367", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// CreateOrUpdateFolioSAPData
localVars.resCreateOrUpdateFolioSAPData_outParamId = await ExtendedActions.CreateOrUpdateFolioSAPData(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_7fd286c48691331601c5027580ae5af5)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = Source.Id
result.outParamId=localVars.inParamSource.ssId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionFolioSAPData_CreateOrUpdate {



}


}
