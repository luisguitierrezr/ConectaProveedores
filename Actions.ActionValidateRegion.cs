namespace ssConectaProveedores;

public partial class Actions {
public class lcvValidateRegion : VarsBag {
public string inParami_ProposalRegion;
public string inParami_Region;
public lcvValidateRegion(string inParami_ProposalRegion, string inParami_Region) {
this.inParami_ProposalRegion = inParami_ProposalRegion;
this.inParami_Region = inParami_Region;
}
}
public class lcoValidateRegion : VarsBag {
public bool outParamo_IsValid = true;

public lcoValidateRegion() {
}
}
/// <summary>
/// Action <code>ValidateRegion</code> that represents the Service Studio action
///  <code>ValidateRegion</code> <p> Description: </p>
/// </summary>
public static async Task<bool> ActionValidateRegion(IRequestContext requestContext,string inParami_ProposalRegion,string inParami_Region,CancellationToken cancellationToken) {
bool outParamo_IsValid = default;
lcoValidateRegion result = new lcoValidateRegion();
lcvValidateRegion localVars = new lcvValidateRegion(inParami_ProposalRegion, inParami_Region);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("ValidateRegion", "e7e5216d-44aa-40e3-a9a9-6ed9778baff8"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("ValidateRegion", "e7e5216d-44aa-40e3-a9a9-6ed9778baff8", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
if(((localVars.inParami_ProposalRegion==localVars.inParami_Region))) {
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

public static class FuncActionValidateRegion {



}


}
