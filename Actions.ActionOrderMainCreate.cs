namespace ssConectaProveedores;

public partial class Actions {
public class lcvOrderMainCreate : VarsBag {
public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord inParamSource;
public long resCreateOrderMain_outParamId = 0L;

public lcvOrderMainCreate(EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoOrderMainCreate : VarsBag {
public long outParamId = 0L;

public lcoOrderMainCreate() {
}
}
/// <summary>
/// Action <code>OrderMainCreate</code> that represents the Service Studio action
///  <code>OrderMainCreate</code> <p> Description: Encapsulates the Create entity action, enabling logi
/// c to run consistently before and after a record is created.</p>
/// </summary>
public static async Task<long> ActionOrderMainCreate(IRequestContext requestContext,EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoOrderMainCreate result = new lcoOrderMainCreate();
lcvOrderMainCreate localVars = new lcvOrderMainCreate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("OrderMainCreate", "57648e01-b277-4677-b995-fb6e62456426"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("OrderMainCreate", "57648e01-b277-4677-b995-fb6e62456426", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Mandatory attributes validation
if((((((((localVars.inParamSource.ssOrderNumber!="")&&(localVars.inParamSource.ssOrderDate!=BuiltInFunction.NullDate ()))&&(localVars.inParamSource.ssOrderStatusId!=BuiltInFunction.NullIdentifier ()))&&(localVars.inParamSource.ssSupplierId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))&&(localVars.inParamSource.ssCompanyId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))&&(localVars.inParamSource.ssCountry!="")))) {
// Set basic audit attributes
// Source.CreatedBy = GetUserId
localVars.inParamSource.ssCreatedBy = BuiltInFunction.GetUserId ();

// Source.CreatedOn = CurrDateTime
localVars.inParamSource.ssCreatedOn = BuiltInFunction.CurrDateTime ();

// Source.UpdatedBy = GetUserId
localVars.inParamSource.ssUpdatedBy = BuiltInFunction.GetUserId ();

// Source.UpdatedOn = CurrDateTime
localVars.inParamSource.ssUpdatedOn = BuiltInFunction.CurrDateTime ();
// CreateOrderMain
localVars.resCreateOrderMain_outParamId = await ExtendedActions.CreateOrderMain(requestContext,(((RC_1583d548420c231ffb93458312800446)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateOrderMain.Id
result.outParamId=localVars.resCreateOrderMain_outParamId;
} else {
// RaiseError EntityException
throw new Ex_EntityExceptionUserException ("Mandatory fields are required");

}

} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionOrderMainCreate {



}


}
