using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: GetProcessTypeDatesAllowed
/// </summary>

public static async Task<RC_c808f777f2a76c70ea9a3f0e560c6a3b> GetProcessTypeDatesAllowed(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_c808f777f2a76c70ea9a3f0e560c6a3b outParamRecord = default;
outParamRecord = new RC_c808f777f2a76c70ea9a3f0e560c6a3b();

var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ENProcessTypeDatesAllowedEntity.eSpaceKey;
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetProcessTypeDatesAllowed", "68076632-4c01-4840-9e31-07df0de25b38.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetProcessTypeDatesAllowed", "68076632-4c01-4840-9e31-07df0de25b38.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@ProcessTypeDatesAllowed, _EntityKeyConstants._OrganizationEntityKeys._ProcessTypeDatesAllowedAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@ProcessTypeDatesAllowed, _EntityKeyConstants._OrganizationEntityKeys._ProcessTypeDatesAllowedAttributeKeys.@ProcessTypeCode, "processtypecode") ?? "processtypecode", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@ProcessTypeDatesAllowed, _EntityKeyConstants._OrganizationEntityKeys._ProcessTypeDatesAllowedAttributeKeys.@DayOfWeekId, "dayofweekid") ?? "dayofweekid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@ProcessTypeDatesAllowed, _EntityKeyConstants._OrganizationEntityKeys._ProcessTypeDatesAllowedAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@ProcessTypeDatesAllowed, _EntityKeyConstants._OrganizationEntityKeys._ProcessTypeDatesAllowedAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
" FROM " + ENProcessTypeDatesAllowedEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@ProcessTypeDatesAllowed, _EntityKeyConstants._OrganizationEntityKeys._ProcessTypeDatesAllowedAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetProcessTypeDatesAllowed", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(5,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENProcessTypeDatesAllowedEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
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
