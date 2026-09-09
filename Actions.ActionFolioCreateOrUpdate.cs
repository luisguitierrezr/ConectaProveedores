namespace ssConectaProveedores;

public partial class Actions {
public class lcvFolioCreateOrUpdate : VarsBag {
public EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord inParamSource;
public long resCreateOrUpdateFolio_outParamId = 0L;

public lcvFolioCreateOrUpdate(EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoFolioCreateOrUpdate : VarsBag {
public long outParamId = 0L;

public lcoFolioCreateOrUpdate() {
}
}
/// <summary>
/// Action <code>FolioCreateOrUpdate</code> that represents the Service Studio action
///  <code>FolioCreateOrUpdate</code> <p> Description: Encapsulates the CreateOrUpdate entity action
/// , enabling logic to run consistently before and after a record is created or modified.</p>
/// </summary>
public static async Task<long> ActionFolioCreateOrUpdate(IRequestContext requestContext,EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoFolioCreateOrUpdate result = new lcoFolioCreateOrUpdate();
lcvFolioCreateOrUpdate localVars = new lcvFolioCreateOrUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("FolioCreateOrUpdate", "dbf1323b-e5db-45b7-bd17-e98c491d85b6"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("FolioCreateOrUpdate", "dbf1323b-e5db-45b7-bd17-e98c491d85b6", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Is new record?
if(((localVars.inParamSource.ssId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// Set basic audit attributes
// Source.CreatedBy = GetUserId
localVars.inParamSource.ssCreatedBy = BuiltInFunction.GetUserId ();

// Source.CreatedOn = CurrDateTime
localVars.inParamSource.ssCreatedOn = BuiltInFunction.CurrDateTime ();
}

// CreateOrUpdateFolio
localVars.resCreateOrUpdateFolio_outParamId = await ExtendedActions.CreateOrUpdateFolio(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_cfeb2cf80ab683e7d9a9b5d02d9c9526)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateOrUpdateFolio.Id
result.outParamId=localVars.resCreateOrUpdateFolio_outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionFolioCreateOrUpdate {



}


}
