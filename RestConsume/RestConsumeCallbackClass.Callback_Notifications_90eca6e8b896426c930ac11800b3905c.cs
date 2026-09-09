using System.Diagnostics;

namespace ssConectaProveedores;

public class Callback_Notifications_90eca6e8b896426c930ac11800b3905c : ICallback_Notifications_90eca6e8b896426c930ac11800b3905c {
    private static readonly ActivitySource activitySource = new(typeof(Callback_Notifications_90eca6e8b896426c930ac11800b3905c).FullName!);

    public static Callback_Notifications_90eca6e8b896426c930ac11800b3905c NewInstance() {
        return new Callback_Notifications_90eca6e8b896426c930ac11800b3905c();
    }

    public class lcvOnBeforeRequest : VarsBag {
public ST_ea2141f4206e3eb2cd0fdd847e008166Structure inParamRequest;
public lcvOnBeforeRequest(ST_ea2141f4206e3eb2cd0fdd847e008166Structure inParamRequest) {
this.inParamRequest = inParamRequest;
}
}
public class lcoOnBeforeRequest : VarsBag {
public ST_ea2141f4206e3eb2cd0fdd847e008166Structure outParamCustomizedRequest = new ST_ea2141f4206e3eb2cd0fdd847e008166Structure();

public lcoOnBeforeRequest() {
}
}
/// <summary>
/// Action <code>OnBeforeRequest</code> that represents the Service Studio action
///  <code>OnBeforeRequest</code> <p> Description: </p>
/// </summary>
public async Task<ST_ea2141f4206e3eb2cd0fdd847e008166Structure> FlowNotificationsActionOnBeforeRequest(IRequestContext requestContext,ST_ea2141f4206e3eb2cd0fdd847e008166Structure inParamRequest,CancellationToken cancellationToken) {
ST_ea2141f4206e3eb2cd0fdd847e008166Structure outParamCustomizedRequest = default;
lcoOnBeforeRequest result = new lcoOnBeforeRequest();
lcvOnBeforeRequest localVars = new lcvOnBeforeRequest(inParamRequest);
try {
cancellationToken.ThrowIfCancellationRequested();
using (null)
using (activitySource.CreateCustomActionActivity("REST (Consume)", "OnBeforeRequest", "fa76baee-0528-4744-a16f-0821e068332b", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828")){
// CustomizedRequest = Request
// CustomizedRequest = Request
result.outParamCustomizedRequest=localVars.inParamRequest;
// ListAppend
await ExtendedActions.ListAppend(requestContext,result.outParamCustomizedRequest.ssHeaders,new ST_3cf3b984041595af1703070620d6367bStructure(){ ssName = "x-api-key", ssValue = ((((string)AppUtils.SiteProperties[SitePropertiesModel.spNotificationsApiKey]))) },cancellationToken);

} //close CreateActionActivity using block
} // try

finally {
outParamCustomizedRequest = result.outParamCustomizedRequest;
} // inner-finally
RETURN_STATEMENT:
return outParamCustomizedRequest;
}

public static class FuncFlowNotificationsActionOnBeforeRequest {



}


}