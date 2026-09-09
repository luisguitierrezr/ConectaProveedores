namespace ssConectaProveedores;

public partial class Actions {
public class lcvValidateLineByDate : VarsBag {
public string inParami_YearMonth;
public lcvValidateLineByDate(string inParami_YearMonth) {
this.inParami_YearMonth = inParami_YearMonth;
}
}
public class lcoValidateLineByDate : VarsBag {
public bool outParamo_IsValid = false;

public lcoValidateLineByDate() {
}
}
/// <summary>
/// Action <code>ValidateLineByDate</code> that represents the Service Studio action
///  <code>ValidateLineByDate</code> <p> Description: </p>
/// </summary>
public static async Task<bool> ActionValidateLineByDate(IRequestContext requestContext,string inParami_YearMonth,CancellationToken cancellationToken) {
bool outParamo_IsValid = default;
lcoValidateLineByDate result = new lcoValidateLineByDate();
lcvValidateLineByDate localVars = new lcvValidateLineByDate(inParami_YearMonth);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("ValidateLineByDate", "5df9def3-8d76-4269-a8d0-9fbb9061bbaa"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("ValidateLineByDate", "5df9def3-8d76-4269-a8d0-9fbb9061bbaa", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
if((((BuiltInFunction.SubstrSC (localVars.inParami_YearMonth, 0, 4)==Convert.ToString(BuiltInFunction.Year (BuiltInFunction.CurrDate ())))&&(BuiltInFunction.TextToInteger (BuiltInFunction.SubstrSC (localVars.inParami_YearMonth, 5, 2))==BuiltInFunction.Month (BuiltInFunction.CurrDate ()))))) {
// o_IsValid = True
result.outParamo_IsValid=true;
} else {
// o_IsValid = False
result.outParamo_IsValid=false;
}

} //close CreateActionActivity using block
} // try

finally {
outParamo_IsValid = result.outParamo_IsValid;
} // inner-finally
RETURN_STATEMENT:
return outParamo_IsValid;
}

public static class FuncActionValidateLineByDate {



}


}
