namespace ssConectaProveedores;

public partial class Actions {
public class lcvGetNextMonday : VarsBag {
public DateTime inParamBaseDateTime;
public lcvGetNextMonday(DateTime inParamBaseDateTime) {
this.inParamBaseDateTime = inParamBaseDateTime;
}
}
public class lcoGetNextMonday : VarsBag {
public int outParamDays = 0;

public lcoGetNextMonday() {
}
}
/// <summary>
/// Action <code>GetNextMonday</code> that represents the Service Studio action
///  <code>GetNextMonday</code> <p> Description: </p>
/// </summary>
public static async Task<int> ActionGetNextMonday(IRequestContext requestContext,DateTime inParamBaseDateTime,CancellationToken cancellationToken) {
int outParamDays = default;
lcoGetNextMonday result = new lcoGetNextMonday();
lcvGetNextMonday localVars = new lcvGetNextMonday(inParamBaseDateTime);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GetNextMonday", "d6558fec-46d3-49a9-a60b-c6592e473ad5"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetNextMonday", "d6558fec-46d3-49a9-a60b-c6592e473ad5", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Days = Mod
result.outParamDays=(((int)BuiltInFunction.Mod ((((decimal)(8-BuiltInFunction.DayOfWeek (localVars.inParamBaseDateTime)))), (((decimal)7)))));
} //close CreateActionActivity using block
} // try

finally {
outParamDays = result.outParamDays;
} // inner-finally
RETURN_STATEMENT:
return outParamDays;
}

public static class FuncActionGetNextMonday {



}


}
