namespace ssConectaProveedores;

public partial class Actions {
public class lcvFolioApprovalCreateOrUpdate : VarsBag {
public EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord inParamSource;
public long resCreateOrUpdateFolioApproval_outParamId = 0L;

public lcvFolioApprovalCreateOrUpdate(EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoFolioApprovalCreateOrUpdate : VarsBag {
public long outParamId = 0L;

public lcoFolioApprovalCreateOrUpdate() {
}
}
/// <summary>
/// Action <code>FolioApprovalCreateOrUpdate</code> that represents the Service Studio action
///  <code>FolioApprovalCreateOrUpdate</code> <p> Description: Encapsulates the CreateOrUpdate entit
/// y action, enabling logic to run consistently before and after a record is created or modified.</p>
/// </summary>
public static async Task<long> ActionFolioApprovalCreateOrUpdate(IRequestContext requestContext,EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoFolioApprovalCreateOrUpdate result = new lcoFolioApprovalCreateOrUpdate();
lcvFolioApprovalCreateOrUpdate localVars = new lcvFolioApprovalCreateOrUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("FolioApprovalCreateOrUpdate", "95eab9a2-0d4b-4ae2-825d-10a083ad5ba9"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("FolioApprovalCreateOrUpdate", "95eab9a2-0d4b-4ae2-825d-10a083ad5ba9", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// CreateOrUpdateFolioApproval
localVars.resCreateOrUpdateFolioApproval_outParamId = await ExtendedActions.CreateOrUpdateFolioApproval(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_8f1c2b4902cba2d0c0cbb5fb1e978b50)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateOrUpdateFolioApproval.Id
result.outParamId=localVars.resCreateOrUpdateFolioApproval_outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionFolioApprovalCreateOrUpdate {



}


}
