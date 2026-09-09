namespace ssConectaProveedores;

public partial class Actions {
public class lcvFolioApprovalLevelCreateOrUpdate : VarsBag {
public EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord inParamSource;
public long resCreateOrUpdateFolioApprovalLevel_outParamId = 0L;

public lcvFolioApprovalLevelCreateOrUpdate(EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoFolioApprovalLevelCreateOrUpdate : VarsBag {
public long outParamId = 0L;

public lcoFolioApprovalLevelCreateOrUpdate() {
}
}
/// <summary>
/// Action <code>FolioApprovalLevelCreateOrUpdate</code> that represents the Service Studio action
///  <code>FolioApprovalLevelCreateOrUpdate</code> <p> Description: Encapsulates the CreateOrUpdat
/// e entity action, enabling logic to run consistently before and after a record is created or
///  modified.</p>
/// </summary>
public static async Task<long> ActionFolioApprovalLevelCreateOrUpdate(IRequestContext requestContext,EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoFolioApprovalLevelCreateOrUpdate result = new lcoFolioApprovalLevelCreateOrUpdate();
lcvFolioApprovalLevelCreateOrUpdate localVars = new lcvFolioApprovalLevelCreateOrUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("FolioApprovalLevelCreateOrUpdate", "d21cd6e4-2f64-4d7c-b14f-df39f24515cc"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("FolioApprovalLevelCreateOrUpdate", "d21cd6e4-2f64-4d7c-b14f-df39f24515cc", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// CreateOrUpdateFolioApprovalLevel
localVars.resCreateOrUpdateFolioApprovalLevel_outParamId = await ExtendedActions.CreateOrUpdateFolioApprovalLevel(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_0be8bae4cc285c0288822b663818cb6c)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateOrUpdateFolioApprovalLevel.Id
result.outParamId=localVars.resCreateOrUpdateFolioApprovalLevel_outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionFolioApprovalLevelCreateOrUpdate {



}


}
