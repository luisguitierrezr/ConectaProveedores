namespace ssConectaProveedores;

public partial class Actions {
public class lcvNotificationCategory : VarsBag {
public int inParamCategory;
public lcvNotificationCategory(int inParamCategory) {
this.inParamCategory = inParamCategory;
}
}
public class lcoNotificationCategory : VarsBag {
public string outParamOutput = "";

public lcoNotificationCategory() {
}
}
/// <summary>
/// Action <code>NotificationCategory</code> that represents the Service Studio action
///  <code>NotificationCategory</code> <p> Description: </p>
/// </summary>
public static async Task<string> ActionNotificationCategory(IRequestContext requestContext,int inParamCategory,CancellationToken cancellationToken) {
string outParamOutput = default;
lcoNotificationCategory result = new lcoNotificationCategory();
lcvNotificationCategory localVars = new lcvNotificationCategory(inParamCategory);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("NotificationCategory", "cd5c2c0b-f686-4154-b01e-2168766fa5f5"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("NotificationCategory", "cd5c2c0b-f686-4154-b01e-2168766fa5f5", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Output = If
result.outParamOutput=(((localVars.inParamCategory==2)) ? ("cancellation") : ((((localVars.inParamCategory==1)) ? ("rejection") : ("authorization"))));
} //close CreateActionActivity using block
} // try

finally {
outParamOutput = result.outParamOutput;
} // inner-finally
RETURN_STATEMENT:
return outParamOutput;
}

public static class FuncActionNotificationCategory {



}


}
