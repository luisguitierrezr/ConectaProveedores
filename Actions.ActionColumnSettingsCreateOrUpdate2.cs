namespace ssConectaProveedores;

public partial class Actions {
public class lcvColumnSettingsCreateOrUpdate2 : VarsBag {
public EN_b8682919578ddd4d17f9eb185aad3c49EntityRecord inParamSource;
public long resCreateOrUpdateColumnSettings_outParamId = 0L;

public lcvColumnSettingsCreateOrUpdate2(EN_b8682919578ddd4d17f9eb185aad3c49EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoColumnSettingsCreateOrUpdate2 : VarsBag {
public long outParamId = 0L;

public lcoColumnSettingsCreateOrUpdate2() {
}
}
/// <summary>
/// Action <code>ColumnSettingsCreateOrUpdate2</code> that represents the Service Studio action
///  <code>ColumnSettingsCreateOrUpdate2</code> <p> Description: Encapsulates the CreateOrUpdate entit
/// y action, enabling logic to run consistently before and after a record is created or modified.</p>
/// </summary>
public static async Task<long> ActionColumnSettingsCreateOrUpdate2(IRequestContext requestContext,EN_b8682919578ddd4d17f9eb185aad3c49EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoColumnSettingsCreateOrUpdate2 result = new lcoColumnSettingsCreateOrUpdate2();
lcvColumnSettingsCreateOrUpdate2 localVars = new lcvColumnSettingsCreateOrUpdate2(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("ColumnSettingsCreateOrUpdate2", "54e2e0d0-dee5-443e-a31b-2ebc1d85b696"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("ColumnSettingsCreateOrUpdate2", "54e2e0d0-dee5-443e-a31b-2ebc1d85b696", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// CreateOrUpdateColumnSettings
localVars.resCreateOrUpdateColumnSettings_outParamId = await ExtendedActions.CreateOrUpdateColumnSettings(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_25c6d4ad26c50e9400baa0d709166594)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateOrUpdateColumnSettings.Id
result.outParamId=localVars.resCreateOrUpdateColumnSettings_outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionColumnSettingsCreateOrUpdate2 {



}


}
