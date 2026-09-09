namespace ssConectaProveedores;

public partial class Actions {
public class lcvGetMaxDatePaymentChanges : VarsBag {
/// <summary>
/// Variable <code>l_Counter</code> that represents the Service Studio Integer <code>l_Counter</code>
///  <p>Description: Counter</p>
/// </summary>
public int varLcl_Counter = 0;

public lcvGetMaxDatePaymentChanges() {
}
}
public class lcoGetMaxDatePaymentChanges : VarsBag {
public DateTime outParamo_MaxDate = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);

public lcoGetMaxDatePaymentChanges() {
}
}
/// <summary>
/// Action <code>GetMaxDatePaymentChanges</code> that represents the Service Studio action
///  <code>GetMaxDatePaymentChanges</code> <p> Description: Get MaxDatePaymentChanges for Proposal</p>
/// </summary>
public static async Task<DateTime> ActionGetMaxDatePaymentChanges(IRequestContext requestContext,CancellationToken cancellationToken) {
DateTime outParamo_MaxDate = default;
lcoGetMaxDatePaymentChanges result = new lcoGetMaxDatePaymentChanges();
lcvGetMaxDatePaymentChanges localVars = new lcvGetMaxDatePaymentChanges();
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GetMaxDatePaymentChanges", "e3473806-b864-4d15-9ad1-8eab1963659b"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetMaxDatePaymentChanges", "e3473806-b864-4d15-9ad1-8eab1963659b", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// o_MaxDate = CurrDate
result.outParamo_MaxDate=BuiltInFunction.CurrDate ();
while (((localVars.varLcl_Counter<5))) {
// o_MaxDate = AddDays
result.outParamo_MaxDate=BuiltInFunction.DateTimeToDate(BuiltInFunction.AddDays (result.outParamo_MaxDate, 1));
if((!(((BuiltInFunction.DayOfWeek (result.outParamo_MaxDate)==0)||(BuiltInFunction.DayOfWeek (result.outParamo_MaxDate)==6))))) {
// l_Counter = l_Counter + 1
localVars.varLcl_Counter=(localVars.varLcl_Counter+1);
}

}

// MaxDate is in next month?
if(((BuiltInFunction.Month (result.outParamo_MaxDate)!=BuiltInFunction.Month (BuiltInFunction.CurrDate ())))) {
// o_MaxDate = AddDays
result.outParamo_MaxDate=BuiltInFunction.DateTimeToDate(BuiltInFunction.AddDays (BuiltInFunction.AddMonths (BuiltInFunction.NewDate (BuiltInFunction.Year (BuiltInFunction.CurrDate ()), BuiltInFunction.Month (BuiltInFunction.CurrDate ()), 1), 1), (-1)));
}

} //close CreateActionActivity using block
} // try

finally {
outParamo_MaxDate = result.outParamo_MaxDate;
} // inner-finally
RETURN_STATEMENT:
return outParamo_MaxDate;
}

public static class FuncActionGetMaxDatePaymentChanges {



}


}
