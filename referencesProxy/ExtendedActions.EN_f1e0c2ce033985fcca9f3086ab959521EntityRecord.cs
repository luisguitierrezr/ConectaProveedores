using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {
public partial class ExtendedActions {
/// <summary>
/// Action: GetUserExtension
/// </summary>

public static async Task<RC_620c1ad5411dbb3ddbe0616529c19a2e> GetUserExtension(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_620c1ad5411dbb3ddbe0616529c19a2e outParamRecord = default;
outParamRecord = new RC_620c1ad5411dbb3ddbe0616529c19a2e();

var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ENUserExtensionEntity.eSpaceKey;
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetUserExtension", "79b0d6cd-9b55-4257-a704-0ddbb658eca0.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetUserExtension", "79b0d6cd-9b55-4257-a704-0ddbb658eca0.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@TelCelUsersManagement, _EntityKeyConstants._TelCelUsersManagementEntityKeys.@UserExtension, _EntityKeyConstants._TelCelUsersManagementEntityKeys._UserExtensionAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@TelCelUsersManagement, _EntityKeyConstants._TelCelUsersManagementEntityKeys.@UserExtension, _EntityKeyConstants._TelCelUsersManagementEntityKeys._UserExtensionAttributeKeys.@CorrespondentExternalEmail, "correspondentexternalemail") ?? "correspondentexternalemail", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@TelCelUsersManagement, _EntityKeyConstants._TelCelUsersManagementEntityKeys.@UserExtension, _EntityKeyConstants._TelCelUsersManagementEntityKeys._UserExtensionAttributeKeys.@Emailto, "emailto") ?? "emailto", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
" FROM " + ENUserExtensionEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@TelCelUsersManagement, _EntityKeyConstants._TelCelUsersManagementEntityKeys.@UserExtension, _EntityKeyConstants._TelCelUsersManagementEntityKeys._UserExtensionAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.String, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetUserExtension", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(3,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENUserExtensionEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
return outParamRecord;
}

}
}
