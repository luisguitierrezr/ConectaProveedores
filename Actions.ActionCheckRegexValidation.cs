namespace ssConectaProveedores;

public partial class Actions {
public class lcvCheckRegexValidation : VarsBag {
public string inParamText;
public bool resRegex_Search_outParamFound = false;
public string resRegex_Search_outParamPatternResult = "";
public int resRegex_Search_outParamFirstIndex = 0;

public lcvCheckRegexValidation(string inParamText) {
this.inParamText = inParamText;
}
}
public class lcoCheckRegexValidation : VarsBag {
public ST_b453bea0930035904f55a74692afd3a8Structure outParamValid = new ST_b453bea0930035904f55a74692afd3a8Structure();

public lcoCheckRegexValidation() {
}
}
/// <summary>
/// Action <code>CheckRegexValidation</code> that represents the Service Studio action
///  <code>CheckRegexValidation</code> <p> Description: </p>
/// </summary>
public static async Task<ST_b453bea0930035904f55a74692afd3a8Structure> ActionCheckRegexValidation(IRequestContext requestContext,string inParamText,CancellationToken cancellationToken) {
ST_b453bea0930035904f55a74692afd3a8Structure outParamValid = default;
lcoCheckRegexValidation result = new lcoCheckRegexValidation();
lcvCheckRegexValidation localVars = new lcvCheckRegexValidation(inParamText);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("CheckRegexValidation", "fec0da39-a8fd-476f-ac67-bd0d0917bf92"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("CheckRegexValidation", "fec0da39-a8fd-476f-ac67-bd0d0917bf92", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Regex_Search
(localVars.resRegex_Search_outParamFound,localVars.resRegex_Search_outParamPatternResult,localVars.resRegex_Search_outParamFirstIndex) = await Actions.ActionRegex_Search(requestContext,localVars.inParamText,"^[A-Za-z\\u00D1\\u00F1\\u00C1\\u00C9\\u00CD\\u00D3\\u00DA\\u00E1\\u00E9\\u00ED\\u00F3\\u00FA ]+(?:/[A-Za-z\\u00D1\\u00F1\\u00C1\\u00C9\\u00CD\\u00D3\\u00DA\\u00E1\\u00E9\\u00ED\\u00F3\\u00FA ]+)*$",true,false,false,cancellationToken);

if((localVars.resRegex_Search_outParamFound)) {
// Valid = True
// Valid.IsValid = True
result.outParamValid.ssIsValid = true;
} else {
// Valid = False
// Valid.IsValid = False
result.outParamValid.ssIsValid = false;

// Valid.ValidationMessage = "No se permiten caracteres especiales."
result.outParamValid.ssValidationMessage = "No se permiten caracteres especiales.";
}

} //close CreateActionActivity using block
} // try

finally {
outParamValid = result.outParamValid;
} // inner-finally
RETURN_STATEMENT:
return outParamValid;
}

public static class FuncActionCheckRegexValidation {



}


}
