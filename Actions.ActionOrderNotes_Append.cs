namespace ssConectaProveedores;

public partial class Actions {
public class lcvOrderNotes_Append : VarsBag {
public string inParamOrderNumber;
public lcvOrderNotes_Append(string inParamOrderNumber) {
this.inParamOrderNumber = inParamOrderNumber;
}
}
public class lcoOrderNotes_Append : VarsBag {
public string outParamNotes = "";

public lcoOrderNotes_Append() {
}
}
/// <summary>
/// Action <code>OrderNotes_Append</code> that represents the Service Studio action
///  <code>OrderNotes_Append</code> <p> Description: </p>
/// </summary>
public static async Task<string> ActionOrderNotes_Append(IRequestContext requestContext,string inParamOrderNumber,CancellationToken cancellationToken) {
string outParamNotes = default;
lcoOrderNotes_Append result = new lcoOrderNotes_Append();
lcvOrderNotes_Append localVars = new lcvOrderNotes_Append(inParamOrderNumber);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("OrderNotes_Append", "eb9a0a10-45c8-4056-8597-aa5a6efeca6d"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("OrderNotes_Append", "eb9a0a10-45c8-4056-8597-aa5a6efeca6d", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// ControledLogMessage
await Actions.ActionControledLogMessage(requestContext,((((bool)AppUtils.SiteProperties[SitePropertiesModel.spOrdersImportLog_IsActive]))),"OrderNotes_Append » TODO » Get Notes and Append","OrderNotes_Append",cancellationToken);

if((false)) {
// Notes = ReadOrderNotes(OrderNumber)
result.outParamNotes=(await Functions.ActionReadOrderNotes(requestContext,localVars.inParamOrderNumber,cancellationToken));
}

} //close CreateActionActivity using block
} // try

finally {
outParamNotes = result.outParamNotes;
} // inner-finally
RETURN_STATEMENT:
return outParamNotes;
}

public static class FuncActionOrderNotes_Append {



}


}
