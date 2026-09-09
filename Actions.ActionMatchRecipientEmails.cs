namespace ssConectaProveedores;

public partial class Actions {
public class lcvMatchRecipientEmails : VarsBag {
public string inParamUserEmails;
public int inParamCategory;
public ST_8509a484f6b6eac99c83feddd35d5004Structure resUsersWithEmailActive_outParamResponse = new ST_8509a484f6b6eac99c83feddd35d5004Structure();

public lcvMatchRecipientEmails(string inParamUserEmails, int inParamCategory) {
this.inParamUserEmails = inParamUserEmails;
this.inParamCategory = inParamCategory;
}
}
public class lcoMatchRecipientEmails : VarsBag {
public string outParamResult = "";

public lcoMatchRecipientEmails() {
}
}
/// <summary>
/// Action <code>MatchRecipientEmails</code> that represents the Service Studio action
///  <code>MatchRecipientEmails</code> <p> Description: Return Recipient Emails witht activ
/// e notification</p>
/// </summary>
public static async Task<string> ActionMatchRecipientEmails(IRequestContext requestContext,string inParamUserEmails,int inParamCategory,CancellationToken cancellationToken) {
string outParamResult = default;
lcoMatchRecipientEmails result = new lcoMatchRecipientEmails();
lcvMatchRecipientEmails localVars = new lcvMatchRecipientEmails(inParamUserEmails, inParamCategory);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("MatchRecipientEmails", "1fc322a3-406a-4c20-816a-2a6d74dc2893"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("MatchRecipientEmails", "1fc322a3-406a-4c20-816a-2a6d74dc2893", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// UsersWithEmailActive
localVars.resUsersWithEmailActive_outParamResponse = await ssConectaProveedores.CcNotifications.ActionUsersWithEmailActive(requestContext,new ST_06cbd1286b150e2e79c91e9d1ed3d811Structure(){ ssliststring = localVars.inParamUserEmails, sscategoryclass = (((localVars.inParamCategory==2)) ? ("cancellation") : ((((localVars.inParamCategory==1)) ? ("rejection") : ("authorization")))) },cancellationToken);

// Result = UsersWithEmailActive.Response.data.checkedusers.liststring
result.outParamResult=localVars.resUsersWithEmailActive_outParamResponse.ssdata.sscheckedusers.ssliststring;
} //close CreateActionActivity using block
} // try

finally {
outParamResult = result.outParamResult;
} // inner-finally
RETURN_STATEMENT:
return outParamResult;
}

public static class FuncActionMatchRecipientEmails {



}


}
