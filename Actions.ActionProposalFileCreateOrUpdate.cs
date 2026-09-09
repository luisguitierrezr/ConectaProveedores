namespace ssConectaProveedores;

public partial class Actions {
public class lcvProposalFileCreateOrUpdate : VarsBag {
public EN_1d38c6a5bdfe9befe9c6396896ed360eEntityRecord inParamSource;
public long resCreateOrUpdateFile3_outParamId = 0L;

public lcvProposalFileCreateOrUpdate(EN_1d38c6a5bdfe9befe9c6396896ed360eEntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoProposalFileCreateOrUpdate : VarsBag {
public long outParamId = 0L;

public lcoProposalFileCreateOrUpdate() {
}
}
/// <summary>
/// Action <code>ProposalFileCreateOrUpdate</code> that represents the Service Studio action
///  <code>ProposalFileCreateOrUpdate</code> <p> Description: Encapsulates the CreateOrUpdate entit
/// y action, enabling logic to run consistently before and after a record is created or modified.</p>
/// </summary>
public static async Task<long> ActionProposalFileCreateOrUpdate(IRequestContext requestContext,EN_1d38c6a5bdfe9befe9c6396896ed360eEntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoProposalFileCreateOrUpdate result = new lcoProposalFileCreateOrUpdate();
lcvProposalFileCreateOrUpdate localVars = new lcvProposalFileCreateOrUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("ProposalFileCreateOrUpdate", "511a5b4d-2418-473f-8eee-468d08a81722"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("ProposalFileCreateOrUpdate", "511a5b4d-2418-473f-8eee-468d08a81722", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Mandatory attributes validation
if((!(BinaryContentUtils.AreBothBinariesNull(localVars.inParamSource.ssBinary, BuiltInFunction.NullBinary ())))) {
// Is new record?
if(((localVars.inParamSource.ssId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// Set basic audit attributes
// Source.CreatedBy = GetUserId
localVars.inParamSource.ssCreatedBy = BuiltInFunction.GetUserId ();

// Source.CreatedOn = CurrDateTime
localVars.inParamSource.ssCreatedOn = BuiltInFunction.CurrDateTime ();
}

// CreateOrUpdateFile3
localVars.resCreateOrUpdateFile3_outParamId = await ExtendedActions.CreateOrUpdateFile3(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_e5232dda8695a6b53d7aafcc3b6d847f)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateOrUpdateFile3.Id
result.outParamId=localVars.resCreateOrUpdateFile3_outParamId;
} else {
// RaiseError EntityException
throw new Ex_EntityExceptionUserException (AppUtils.GetStringResource("rd5RuhwRrkOpKMBQmjNzzA#Message.1103836427.1", "Mandatory fields are required"));

}

} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionProposalFileCreateOrUpdate {



}


}
