namespace ssConectaProveedores;

public partial class Actions {
public class lcvFolioLogAdd : VarsBag {
public EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord inParamSource;
public long resCreateOrUpdateFolioLog_outParamId = 0L;

public lcvFolioLogAdd(EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoFolioLogAdd : VarsBag {
public long outParamId = 0L;

public lcoFolioLogAdd() {
}
}
/// <summary>
/// Action <code>FolioLogAdd</code> that represents the Service Studio action <code>FolioLogAdd</code>
///  <p> Description: Encapsulates the CreateOrUpdate entity action, enabling logic to run consistentl
/// y before and after a record is created or modified.</p>
/// </summary>
public static async Task<long> ActionFolioLogAdd(IRequestContext requestContext,EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoFolioLogAdd result = new lcoFolioLogAdd();
lcvFolioLogAdd localVars = new lcvFolioLogAdd(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("FolioLogAdd", "180b757f-1fd8-4c2c-868c-ab3792ba838d"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("FolioLogAdd", "180b757f-1fd8-4c2c-868c-ab3792ba838d", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Source.Message = Substr
localVars.inParamSource.ssMessage = BuiltInFunction.SubstrSC (localVars.inParamSource.ssMessage, 0, 499);
// CreateOrUpdateFolioLog
localVars.resCreateOrUpdateFolioLog_outParamId = await ExtendedActions.CreateOrUpdateFolioLog(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_d1c5afe2a83250ad8e254ef5d2a29b01)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateOrUpdateFolioLog.Id
result.outParamId=localVars.resCreateOrUpdateFolioLog_outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionFolioLogAdd {



}


}
