namespace ssConectaProveedores;

public partial class Actions {
public class lcvLogFolioSAPErrors : VarsBag {
public long inParamFolioId;
public string inParamMessage;
public bool inParamLogAnonymously;
public long resCreateFolioLog_outParamId = 0L;

public lcvLogFolioSAPErrors(long inParamFolioId, string inParamMessage, bool inParamLogAnonymously) {
this.inParamFolioId = inParamFolioId;
this.inParamMessage = inParamMessage;
this.inParamLogAnonymously = inParamLogAnonymously;
}
}
public class lcoLogFolioSAPErrors : VarsBag {
public long outParamId = 0L;

public lcoLogFolioSAPErrors() {
}
}
/// <summary>
/// Action <code>LogFolioSAPErrors</code> that represents the Service Studio action
///  <code>LogFolioSAPErrors</code> <p> Description: </p>
/// </summary>
public static async Task<long> ActionLogFolioSAPErrors(IRequestContext requestContext,long inParamFolioId,string inParamMessage,bool inParamLogAnonymously,CancellationToken cancellationToken) {
long outParamId = default;
lcoLogFolioSAPErrors result = new lcoLogFolioSAPErrors();
lcvLogFolioSAPErrors localVars = new lcvLogFolioSAPErrors(inParamFolioId, inParamMessage, inParamLogAnonymously);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("LogFolioSAPErrors", "48efd008-4c95-48e5-afe4-1ae3ca54a846"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("LogFolioSAPErrors", "48efd008-4c95-48e5-afe4-1ae3ca54a846", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// CreateFolioLog
localVars.resCreateFolioLog_outParamId = await ExtendedActions.CreateFolioLog(requestContext,new RC_d1c5afe2a83250ad8e254ef5d2a29b01(){ ssENFolioLog = new EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord(){ ssFolioId = localVars.inParamFolioId, ssMessage = localVars.inParamMessage, ssCreatedBy = ((localVars.inParamLogAnonymously) ? (BuiltInFunction.NullTextIdentifier ()) : (BuiltInFunction.GetUserId ())), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssIsError = true } },cancellationToken);

// Id = CreateFolioLog.Id
result.outParamId=localVars.resCreateFolioLog_outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionLogFolioSAPErrors {



}


}
