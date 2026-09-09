namespace ssConectaProveedores;

public partial class Actions {
public class lcvValidateDate : VarsBag {
public string inParamDateInText;
public bool resRegex_Search_outParamFound = false;
public string resRegex_Search_outParamPatternResult = "";
public int resRegex_Search_outParamFirstIndex = 0;

public lcvValidateDate(string inParamDateInText) {
this.inParamDateInText = inParamDateInText;
}
}
public class lcoValidateDate : VarsBag {
public bool outParamIsValid = false;

public lcoValidateDate() {
}
}
/// <summary>
/// Action <code>ValidateDate</code> that represents the Service Studio action
///  <code>ValidateDate</code> <p> Description: </p>
/// </summary>
public static async Task<bool> ActionValidateDate(IRequestContext requestContext,string inParamDateInText,CancellationToken cancellationToken) {
bool outParamIsValid = default;
lcoValidateDate result = new lcoValidateDate();
lcvValidateDate localVars = new lcvValidateDate(inParamDateInText);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("ValidateDate", "f344fc7f-016f-40c7-a265-f01c0e3a1942"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("ValidateDate", "f344fc7f-016f-40c7-a265-f01c0e3a1942", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Regex_Search
(localVars.resRegex_Search_outParamFound,localVars.resRegex_Search_outParamPatternResult,localVars.resRegex_Search_outParamFirstIndex) = await Actions.ActionRegex_Search(requestContext,localVars.inParamDateInText,"^(0[1-9]|[12][0-9]|3[01])\\/(0[1-9]|1[0-2])\\/\\d{4}$",true,false,false,cancellationToken);

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

public static class FuncActionValidateDate {



}


}
