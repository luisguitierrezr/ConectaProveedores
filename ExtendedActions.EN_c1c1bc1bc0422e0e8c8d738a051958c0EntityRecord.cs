using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: GetManualUserArea
/// </summary>

public static async Task<RC_53bfb6ba3a8f9433f06f269f872b84c8> GetManualUserArea(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_53bfb6ba3a8f9433f06f269f872b84c8 outParamRecord = default;
outParamRecord = new RC_53bfb6ba3a8f9433f06f269f872b84c8();

var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ENManualUserAreaEntity.eSpaceKey;
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetManualUserArea", "9f8b397a-6133-485e-a9c7-3203b02bf301.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetManualUserArea", "9f8b397a-6133-485e-a9c7-3203b02bf301.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@ManualUserArea, _EntityKeyConstants._OrganizationEntityKeys._ManualUserAreaAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@ManualUserArea, _EntityKeyConstants._OrganizationEntityKeys._ManualUserAreaAttributeKeys.@ManualId, "manualid") ?? "manualid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@ManualUserArea, _EntityKeyConstants._OrganizationEntityKeys._ManualUserAreaAttributeKeys.@UserAreaId, "userareaid") ?? "userareaid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
" FROM " + ENManualUserAreaEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@ManualUserArea, _EntityKeyConstants._OrganizationEntityKeys._ManualUserAreaAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetManualUserArea", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(3,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENManualUserAreaEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
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
