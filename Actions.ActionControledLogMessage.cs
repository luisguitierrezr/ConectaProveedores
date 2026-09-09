namespace ssConectaProveedores;

public partial class Actions {
public class lcvControledLogMessage : VarsBag {
public bool inParamIsLoggingActive;
public string inParamMessage;
public string inParamAction;
public lcvControledLogMessage(bool inParamIsLoggingActive, string inParamMessage, string inParamAction) {
this.inParamIsLoggingActive = inParamIsLoggingActive;
this.inParamMessage = inParamMessage;
this.inParamAction = inParamAction;
}
}
/// <summary>
/// Action <code>ControledLogMessage</code> that represents the Service Studio action
///  <code>ControledLogMessage</code> <p> Description: </p>
/// </summary>
public static async Task ActionControledLogMessage(IRequestContext requestContext,bool inParamIsLoggingActive,string inParamMessage,string inParamAction,CancellationToken cancellationToken) {
lcvControledLogMessage localVars = new lcvControledLogMessage(inParamIsLoggingActive, inParamMessage, inParamAction);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("ControledLogMessage", "c6a4d157-ac19-47de-a6f5-1ec47205aea9"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("ControledLogMessage", "c6a4d157-ac19-47de-a6f5-1ec47205aea9", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
if((localVars.inParamIsLoggingActive)) {
// LogMessage
await ExtendedActions.LogMessage(requestContext,localVars.inParamMessage,localVars.inParamAction,cancellationToken);

}

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionControledLogMessage {



}


}
