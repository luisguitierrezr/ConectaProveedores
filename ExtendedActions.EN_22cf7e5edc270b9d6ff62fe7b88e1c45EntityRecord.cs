using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: GetUserApplicationRoleTempByConcept
/// </summary>

public static async Task<RC_0ac1b5c675d1742c0ea797802ee62592> GetUserApplicationRoleTempByConcept(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_0ac1b5c675d1742c0ea797802ee62592 outParamRecord = default;
outParamRecord = new RC_0ac1b5c675d1742c0ea797802ee62592();

var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ENUserApplicationRoleTempByConceptEntity.eSpaceKey;
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetUserApplicationRoleTempByConcept", "202a9d3b-86a3-41d2-a9e8-4df159f4770f.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetUserApplicationRoleTempByConcept", "202a9d3b-86a3-41d2-a9e8-4df159f4770f.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@UserApplicationRoleTempByConcept, _EntityKeyConstants._SecurityAuthEntityKeys._UserApplicationRoleTempByConceptAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@UserApplicationRoleTempByConcept, _EntityKeyConstants._SecurityAuthEntityKeys._UserApplicationRoleTempByConceptAttributeKeys.@UserApplicationRoleTempId, "userapplicationroletempid") ?? "userapplicationroletempid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@UserApplicationRoleTempByConcept, _EntityKeyConstants._SecurityAuthEntityKeys._UserApplicationRoleTempByConceptAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@UserApplicationRoleTempByConcept, _EntityKeyConstants._SecurityAuthEntityKeys._UserApplicationRoleTempByConceptAttributeKeys.@ConceptId, "conceptid") ?? "conceptid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
" FROM " + ENUserApplicationRoleTempByConceptEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@UserApplicationRoleTempByConcept, _EntityKeyConstants._SecurityAuthEntityKeys._UserApplicationRoleTempByConceptAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetUserApplicationRoleTempByConcept", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(4,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENUserApplicationRoleTempByConceptEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
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
