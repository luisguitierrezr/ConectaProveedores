using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {
public partial class ExtendedActions {
/// <summary>
/// Action: GetRetentionTypes
/// </summary>

public static async Task<RC_d25c749e180f28d5d6211e73984f17d9> GetRetentionTypes(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_d25c749e180f28d5d6211e73984f17d9 outParamRecord = default;
outParamRecord = new RC_d25c749e180f28d5d6211e73984f17d9();

var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ENRetentionTypesEntity.eSpaceKey;
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetRetentionTypes", "1a663217-e60c-4110-969e-254fe534be78.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetRetentionTypes", "1a663217-e60c-4110-969e-254fe534be78.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@RetentionTypes, _EntityKeyConstants._OrganizationEntityKeys._RetentionTypesAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@RetentionTypes, _EntityKeyConstants._OrganizationEntityKeys._RetentionTypesAttributeKeys.@Indicator, "indicator") ?? "indicator", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@RetentionTypes, _EntityKeyConstants._OrganizationEntityKeys._RetentionTypesAttributeKeys.@Description, "description") ?? "description", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
" FROM " + ENRetentionTypesEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@RetentionTypes, _EntityKeyConstants._OrganizationEntityKeys._RetentionTypesAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetRetentionTypes", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(3,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENRetentionTypesEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
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
