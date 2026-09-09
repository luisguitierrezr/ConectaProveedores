namespace ssConectaProveedores;

public partial class Actions {
public class lcvRequisitionAccConceptsDelete : VarsBag {
public long inParamId;
public lcvRequisitionAccConceptsDelete(long inParamId) {
this.inParamId = inParamId;
}
}
/// <summary>
/// Action <code>RequisitionAccConceptsDelete</code> that represents the Service Studio action
///  <code>RequisitionAccConceptsDelete</code> <p> Description: Encapsulates the Delete entity action
/// , enabling logic to run consistently before and after a record is deleted.</p>
/// </summary>
public static async Task ActionRequisitionAccConceptsDelete(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
lcvRequisitionAccConceptsDelete localVars = new lcvRequisitionAccConceptsDelete(inParamId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("RequisitionAccConceptsDelete", "0e21afd6-9ac2-494d-af52-f0c90ce0af40"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("RequisitionAccConceptsDelete", "0e21afd6-9ac2-494d-af52-f0c90ce0af40", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Has Identifier?
if(((localVars.inParamId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// DeleteRequisitionAccConcepts
await ExtendedActions.DeleteRequisitionAccConcepts(requestContext,localVars.inParamId,cancellationToken);

} else {
// RaiseError EntityException
throw new Ex_EntityExceptionUserException (AppUtils.GetStringResource("5tZuY3zSv0msUzJdviYd4g#Message.48399450.1", "Identifier is mandatory"));

}

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionRequisitionAccConceptsDelete {



}


}
