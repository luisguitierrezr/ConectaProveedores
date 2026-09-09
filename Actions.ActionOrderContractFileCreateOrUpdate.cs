namespace ssConectaProveedores;

public partial class Actions {
public class lcvOrderContractFileCreateOrUpdate : VarsBag {
public EN_17538b35348920159ed0ee43b3fb2b50EntityRecord inParamSource;
public long resCreateOrUpdateOrderContractFile_outParamId = 0L;

public lcvOrderContractFileCreateOrUpdate(EN_17538b35348920159ed0ee43b3fb2b50EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoOrderContractFileCreateOrUpdate : VarsBag {
public long outParamId = 0L;

public lcoOrderContractFileCreateOrUpdate() {
}
}
/// <summary>
/// Action <code>OrderContractFileCreateOrUpdate</code> that represents the Service Studio action
///  <code>OrderContractFileCreateOrUpdate</code> <p> Description: Encapsulates the CreateOrUpdat
/// e entity action, enabling logic to run consistently before and after a record is created or
///  modified.</p>
/// </summary>
public static async Task<long> ActionOrderContractFileCreateOrUpdate(IRequestContext requestContext,EN_17538b35348920159ed0ee43b3fb2b50EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoOrderContractFileCreateOrUpdate result = new lcoOrderContractFileCreateOrUpdate();
lcvOrderContractFileCreateOrUpdate localVars = new lcvOrderContractFileCreateOrUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("OrderContractFileCreateOrUpdate", "5c0495bb-6bb5-4be6-a170-fe2c47f8a2b9"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("OrderContractFileCreateOrUpdate", "5c0495bb-6bb5-4be6-a170-fe2c47f8a2b9", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// CreateOrUpdateOrderContractFile
localVars.resCreateOrUpdateOrderContractFile_outParamId = await ExtendedActions.CreateOrUpdateOrderContractFile(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_bdb8cd2e0da3eae2f170942895f2a3ac)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateOrUpdateOrderContractFile.Id
result.outParamId=localVars.resCreateOrUpdateOrderContractFile_outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionOrderContractFileCreateOrUpdate {



}


}
