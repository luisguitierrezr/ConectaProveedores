namespace ssConectaProveedores;

public partial class Actions {
public class lcvOrderMainUpdate : VarsBag {
public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord inParamSource;
public lcvOrderMainUpdate(EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoOrderMainUpdate : VarsBag {
public long outParamId = 0L;

public lcoOrderMainUpdate() {
}
}
/// <summary>
/// Action <code>OrderMainUpdate</code> that represents the Service Studio action
///  <code>OrderMainUpdate</code> <p> Description: Encapsulates the Update entity action, enabling logi
/// c to run consistently before and after a record is modified.</p>
/// </summary>
public static async Task<long> ActionOrderMainUpdate(IRequestContext requestContext,EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoOrderMainUpdate result = new lcoOrderMainUpdate();
lcvOrderMainUpdate localVars = new lcvOrderMainUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("OrderMainUpdate", "bd41d5b9-e8a9-401b-a3a0-71d392e12b17"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("OrderMainUpdate", "bd41d5b9-e8a9-401b-a3a0-71d392e12b17", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Has Identifier?
if(((localVars.inParamSource.ssId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// Mandatory attributes validation
if((((((((localVars.inParamSource.ssOrderNumber!="")&&(localVars.inParamSource.ssOrderDate!=BuiltInFunction.NullDate ()))&&(localVars.inParamSource.ssOrderStatusId!=BuiltInFunction.NullIdentifier ()))&&(localVars.inParamSource.ssSupplierId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))&&(localVars.inParamSource.ssCompanyId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))&&(localVars.inParamSource.ssCountry!="")))) {
// Set basic audit attributes
// Source.UpdatedBy = GetUserId
localVars.inParamSource.ssUpdatedBy = BuiltInFunction.GetUserId ();

// Source.UpdatedOn = CurrDateTime
localVars.inParamSource.ssUpdatedOn = BuiltInFunction.CurrDateTime ();
// UpdateOrderMain
await ExtendedActions.UpdateOrderMain(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_1583d548420c231ffb93458312800446)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = Source.Id
result.outParamId=localVars.inParamSource.ssId;
} else {
// RaiseError EntityException
throw new Ex_EntityExceptionUserException (AppUtils.GetStringResource("j3bNlMIQU0qZvCTR7ZpuWg#Message.1103836427.1", "Mandatory fields are required"));

}

} else {
// RaiseError EntityException
throw new Ex_EntityExceptionUserException (AppUtils.GetStringResource("RPQKywC5LEmj_u7R85v6Zg#Message.48399450.1", "Identifier is mandatory"));

}

} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionOrderMainUpdate {



}


}
