namespace ssConectaProveedores;

public partial class Actions {
public class lcvGetMaxDateFinishCapture : VarsBag {
/// <summary>
/// Variable <code>l_Counter</code> that represents the Service Studio Integer <code>l_Counter</code>
///  <p>Description: Counter</p>
/// </summary>
public int varLcl_Counter = 0;

public lcvGetMaxDateFinishCapture() {
}
}
public class lcoGetMaxDateFinishCapture : VarsBag {
public DateTime outParamo_MaxDateTime = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);

public lcoGetMaxDateFinishCapture() {
}
}
/// <summary>
/// Action <code>GetMaxDateFinishCapture</code> that represents the Service Studio action
///  <code>GetMaxDateFinishCapture</code> <p> Description: </p>
/// </summary>
public static async Task<DateTime> ActionGetMaxDateFinishCapture(IRequestContext requestContext,CancellationToken cancellationToken) {
DateTime outParamo_MaxDateTime = default;
lcoGetMaxDateFinishCapture result = new lcoGetMaxDateFinishCapture();
lcvGetMaxDateFinishCapture localVars = new lcvGetMaxDateFinishCapture();
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GetMaxDateFinishCapture", "2e4bc737-8002-48af-a8e7-98b3194a4510"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetMaxDateFinishCapture", "2e4bc737-8002-48af-a8e7-98b3194a4510", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// o_MaxDateTime = CurrDateTime
result.outParamo_MaxDateTime=BuiltInFunction.CurrDateTime ();
while (((localVars.varLcl_Counter<72))) {
// o_MaxDateTime = AddHours
result.outParamo_MaxDateTime=BuiltInFunction.AddHours (result.outParamo_MaxDateTime, 1);
if((!(((BuiltInFunction.DayOfWeek (result.outParamo_MaxDateTime)==0)||(BuiltInFunction.DayOfWeek (result.outParamo_MaxDateTime)==6))))) {
// l_Counter = l_Counter + 1
localVars.varLcl_Counter=(localVars.varLcl_Counter+1);
}

}

} //close CreateActionActivity using block
} // try

finally {
outParamo_MaxDateTime = result.outParamo_MaxDateTime;
} // inner-finally
RETURN_STATEMENT:
return outParamo_MaxDateTime;
}

public static class FuncActionGetMaxDateFinishCapture {



}


}
