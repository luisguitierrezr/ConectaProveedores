namespace ssConectaProveedores;

public partial class Actions {
public class lcvUTCToLocalTime : VarsBag {
public DateTime inParamDateTimeUTC;
public int inParamOffset;
public lcvUTCToLocalTime(DateTime inParamDateTimeUTC, int inParamOffset) {
this.inParamDateTimeUTC = inParamDateTimeUTC;
this.inParamOffset = inParamOffset;
}
}
public class lcoUTCToLocalTime : VarsBag {
public DateTime outParamDateTimeLocal = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);

public lcoUTCToLocalTime() {
}
}
/// <summary>
/// Action <code>UTCToLocalTime</code> that represents the Service Studio action
///  <code>UTCToLocalTime</code> <p> Description: </p>
/// </summary>
public static async Task<DateTime> ActionUTCToLocalTime(IRequestContext requestContext,DateTime inParamDateTimeUTC,int inParamOffset,CancellationToken cancellationToken) {
DateTime outParamDateTimeLocal = default;
lcoUTCToLocalTime result = new lcoUTCToLocalTime();
lcvUTCToLocalTime localVars = new lcvUTCToLocalTime(inParamDateTimeUTC, inParamOffset);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("UTCToLocalTime", "d0ead301-2df9-4009-b34f-56946efb6ddc"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("UTCToLocalTime", "d0ead301-2df9-4009-b34f-56946efb6ddc", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// DateTimeLocal = AddHours
result.outParamDateTimeLocal=BuiltInFunction.AddHours (localVars.inParamDateTimeUTC, (localVars.inParamOffset*(-1)));
} //close CreateActionActivity using block
} // try

finally {
outParamDateTimeLocal = result.outParamDateTimeLocal;
} // inner-finally
RETURN_STATEMENT:
return outParamDateTimeLocal;
}

public static class FuncActionUTCToLocalTime {



}


}
