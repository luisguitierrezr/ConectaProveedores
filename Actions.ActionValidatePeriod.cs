namespace ssConectaProveedores;

public partial class Actions {
public class lcvValidatePeriod : VarsBag {
public string inParamText;
public bool resRegex_Search_outParamFound = false;
public string resRegex_Search_outParamPatternResult = "";
public int resRegex_Search_outParamFirstIndex = 0;

public lcvValidatePeriod(string inParamText) {
this.inParamText = inParamText;
}
}
public class lcoValidatePeriod : VarsBag {
public bool outParamIsValid = false;

public lcoValidatePeriod() {
}
}
/// <summary>
/// Action <code>ValidatePeriod</code> that represents the Service Studio action
///  <code>ValidatePeriod</code> <p> Description: </p>
/// </summary>
public static async Task<bool> ActionValidatePeriod(IRequestContext requestContext,string inParamText,CancellationToken cancellationToken) {
bool outParamIsValid = default;
lcoValidatePeriod result = new lcoValidatePeriod();
lcvValidatePeriod localVars = new lcvValidatePeriod(inParamText);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("ValidatePeriod", "d4587325-acc4-407e-aa7c-0c371835c5e3"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("ValidatePeriod", "d4587325-acc4-407e-aa7c-0c371835c5e3", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Regex_Search
(localVars.resRegex_Search_outParamFound,localVars.resRegex_Search_outParamPatternResult,localVars.resRegex_Search_outParamFirstIndex) = await Actions.ActionRegex_Search(requestContext,localVars.inParamText,"^(19|20)\\d{2}$",true,false,false,cancellationToken);

// IsValid = Regex_Search.Found
result.outParamIsValid=localVars.resRegex_Search_outParamFound;
} //close CreateActionActivity using block
} // try

finally {
outParamIsValid = result.outParamIsValid;
} // inner-finally
RETURN_STATEMENT:
return outParamIsValid;
}

public static class FuncActionValidatePeriod {



}


}
