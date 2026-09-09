namespace ssConectaProveedores;

public partial class Actions {
public class lcvOrderAccConceptsDelete : VarsBag {
public long inParamId;
public lcvOrderAccConceptsDelete(long inParamId) {
this.inParamId = inParamId;
}
}
/// <summary>
/// Action <code>OrderAccConceptsDelete</code> that represents the Service Studio action
///  <code>OrderAccConceptsDelete</code> <p> Description: Encapsulates the Delete entity action
/// , enabling logic to run consistently before and after a record is deleted.</p>
/// </summary>
public static async Task ActionOrderAccConceptsDelete(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
lcvOrderAccConceptsDelete localVars = new lcvOrderAccConceptsDelete(inParamId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("OrderAccConceptsDelete", "658e46ee-dfb9-4061-9438-76f638ae4d29"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("OrderAccConceptsDelete", "658e46ee-dfb9-4061-9438-76f638ae4d29", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Has Identifier?
if(((localVars.inParamId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// DeleteOrderAccConcepts
await ExtendedActions.DeleteOrderAccConcepts(requestContext,localVars.inParamId,cancellationToken);

} else {
// RaiseError EntityException
throw new Ex_EntityExceptionUserException ("Identifier is mandatory");

}

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionOrderAccConceptsDelete {



}


}
