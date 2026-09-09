namespace ssConectaProveedores;

public partial class Actions {
public class lcvColumnTogglerPassColumn : VarsBag {
public string inParami_ColumnJSON;
public string inParami_TableName;
public string inParami_UserId;
public byte[] resTextToBinaryData_outParamBinaryData = new byte[] {};

public Actions.lcoColumnSettingsCreateOrUpdate resColumnSettingsCreateOrUpdate =  new Actions.lcoColumnSettingsCreateOrUpdate();
public lcvColumnTogglerPassColumn(string inParami_ColumnJSON, string inParami_TableName, string inParami_UserId) {
this.inParami_ColumnJSON = inParami_ColumnJSON;
this.inParami_TableName = inParami_TableName;
this.inParami_UserId = inParami_UserId;
}
}
/// <summary>
/// Action <code>ColumnTogglerPassColumn</code> that represents the Service Studio action
///  <code>ColumnTogglerPassColumn</code> <p> Description: </p>
/// </summary>
public static async Task ActionColumnTogglerPassColumn(IRequestContext requestContext,string inParami_ColumnJSON,string inParami_TableName,string inParami_UserId,CancellationToken cancellationToken) {
lcvColumnTogglerPassColumn localVars = new lcvColumnTogglerPassColumn(inParami_ColumnJSON, inParami_TableName, inParami_UserId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("ColumnTogglerPassColumn", "68473301-c3d5-4d78-a652-7ce384c4cbd7"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("ColumnTogglerPassColumn", "68473301-c3d5-4d78-a652-7ce384c4cbd7", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// TextToBinaryData
localVars.resTextToBinaryData_outParamBinaryData = await Actions.ActionTextToBinaryData(requestContext,localVars.inParami_ColumnJSON,"",cancellationToken);

// ColumnSettingsCreateOrUpdate
localVars.resColumnSettingsCreateOrUpdate.outParamId = await Actions.ActionColumnSettingsCreateOrUpdate(requestContext,new EN_b8682919578ddd4d17f9eb185aad3c49EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTableName = localVars.inParami_TableName, ssJSONData = localVars.resTextToBinaryData_outParamBinaryData, ssUserId = localVars.inParami_UserId },cancellationToken);

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionColumnTogglerPassColumn {



}


}
