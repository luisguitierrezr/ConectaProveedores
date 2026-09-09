namespace ssConectaProveedores;

public partial class Actions {
public class lcvCreateOrUpdateOrderDistribution : VarsBag {
public EN_4ad0cdb13562998fda111463f2af9c31EntityRecord inParamSource;
public long resCreateOrUpdateOrderDistributionConfig_outParamId = 0L;

public lcvCreateOrUpdateOrderDistribution(EN_4ad0cdb13562998fda111463f2af9c31EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoCreateOrUpdateOrderDistribution : VarsBag {
public long outParamId = 0L;

public lcoCreateOrUpdateOrderDistribution() {
}
}
/// <summary>
/// Action <code>CreateOrUpdateOrderDistribution</code> that represents the Service Studio action
///  <code>CreateOrUpdateOrderDistribution</code> <p> Description: </p>
/// </summary>
public static async Task<long> ActionCreateOrUpdateOrderDistribution(IRequestContext requestContext,EN_4ad0cdb13562998fda111463f2af9c31EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoCreateOrUpdateOrderDistribution result = new lcoCreateOrUpdateOrderDistribution();
lcvCreateOrUpdateOrderDistribution localVars = new lcvCreateOrUpdateOrderDistribution(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("CreateOrUpdateOrderDistribution", "31e560ca-66ab-42c6-ace3-562857e8df1a"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("CreateOrUpdateOrderDistribution", "31e560ca-66ab-42c6-ace3-562857e8df1a", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Set basic audit attributes
// Source.CreatedBy = If
localVars.inParamSource.ssCreatedBy = (((localVars.inParamSource.ssId==Convert.ToInt64(BuiltInFunction.NullIdentifier ()))) ? (BuiltInFunction.GetUserId ()) : (localVars.inParamSource.ssCreatedBy));

// Source.CreatedOn = If
localVars.inParamSource.ssCreatedOn = (((localVars.inParamSource.ssId==Convert.ToInt64(BuiltInFunction.NullIdentifier ()))) ? (BuiltInFunction.CurrDateTime ()) : (localVars.inParamSource.ssCreatedOn));

// Source.UpdatedBy = If
localVars.inParamSource.ssUpdatedBy = (((localVars.inParamSource.ssId==Convert.ToInt64(BuiltInFunction.NullIdentifier ()))) ? (localVars.inParamSource.ssCreatedBy) : (BuiltInFunction.GetUserId ()));

// Source.UpdatedOn = If
localVars.inParamSource.ssUpdatedOn = (((localVars.inParamSource.ssId==Convert.ToInt64(BuiltInFunction.NullIdentifier ()))) ? (localVars.inParamSource.ssCreatedOn) : (BuiltInFunction.CurrDateTime ()));
// CreateOrUpdateOrderDistributionConfig
localVars.resCreateOrUpdateOrderDistributionConfig_outParamId = await ExtendedActions.CreateOrUpdateOrderDistributionConfig(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_9fc59bda41db740ae87f91f135d24811)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateOrUpdateOrderDistributionConfig.Id
result.outParamId=localVars.resCreateOrUpdateOrderDistributionConfig_outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionCreateOrUpdateOrderDistribution {



}


}
