namespace ssConectaProveedores;

public partial class Actions {
public class lcvValidateCompanyPermission : VarsBag {
public RL_c137814ac517b1e8679b0756ef62a588 inParami_CompanyList;
public string inParami_Soc;
public lcvValidateCompanyPermission(RL_c137814ac517b1e8679b0756ef62a588 inParami_CompanyList, string inParami_Soc) {
this.inParami_CompanyList = inParami_CompanyList;
this.inParami_Soc = inParami_Soc;
}
}
public class lcoValidateCompanyPermission : VarsBag {
public bool outParamo_IsAllowed = false;

public lcoValidateCompanyPermission() {
}
}
/// <summary>
/// Action <code>ValidateCompanyPermission</code> that represents the Service Studio action
///  <code>ValidateCompanyPermission</code> <p> Description: </p>
/// </summary>
public static async Task<bool> ActionValidateCompanyPermission(IRequestContext requestContext,RL_c137814ac517b1e8679b0756ef62a588 inParami_CompanyList,string inParami_Soc,CancellationToken cancellationToken) {
bool outParamo_IsAllowed = default;
lcoValidateCompanyPermission result = new lcoValidateCompanyPermission();
lcvValidateCompanyPermission localVars = new lcvValidateCompanyPermission(inParami_CompanyList, inParami_Soc);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("ValidateCompanyPermission", "c9f1749c-09ef-4dc7-9981-c7c8128b1fb0"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("ValidateCompanyPermission", "c9f1749c-09ef-4dc7-9981-c7c8128b1fb0", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// o_IsAllowed = False
result.outParamo_IsAllowed=false;
// Foreach i_CompanyList
localVars.inParami_CompanyList.StartIteration();
try {while (!((localVars.inParami_CompanyList.Eof))) {
// Is allowed?
if(((BuiltInFunction.ToUpper (BuiltInFunction.Trim (localVars.inParami_Soc))==BuiltInFunction.ToUpper (BuiltInFunction.Trim (localVars.inParami_CompanyList.CurrentRec.ssExternalId))))) {
// o_IsAllowed = True
result.outParamo_IsAllowed=true;
goto RETURN_STATEMENT;

}

localVars.inParami_CompanyList.Advance();
}

} finally {
localVars.inParami_CompanyList.EndIteration();
}

} //close CreateActionActivity using block
} // try

finally {
outParamo_IsAllowed = result.outParamo_IsAllowed;
} // inner-finally
RETURN_STATEMENT:
return outParamo_IsAllowed;
}

public static class FuncActionValidateCompanyPermission {



}


}
