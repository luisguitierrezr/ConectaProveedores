using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: GetApplicationRole
/// </summary>

public static async Task<RC_ceec47435de563c2690b605ecca69a94> GetApplicationRole(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_ceec47435de563c2690b605ecca69a94 outParamRecord = default;
outParamRecord = new RC_ceec47435de563c2690b605ecca69a94();

var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ENApplicationRoleEntity.eSpaceKey;
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetApplicationRole", "9580fb93-5927-4d1e-b99a-c4cb57c3aa94.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetApplicationRole", "9580fb93-5927-4d1e-b99a-c4cb57c3aa94.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@ApplicationRole, _EntityKeyConstants._SecurityAuthEntityKeys._ApplicationRoleAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@ApplicationRole, _EntityKeyConstants._SecurityAuthEntityKeys._ApplicationRoleAttributeKeys.@Code, "code") ?? "code", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@ApplicationRole, _EntityKeyConstants._SecurityAuthEntityKeys._ApplicationRoleAttributeKeys.@Name, "name") ?? "name", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@ApplicationRole, _EntityKeyConstants._SecurityAuthEntityKeys._ApplicationRoleAttributeKeys.@IsActive, "isactive") ?? "isactive", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@ApplicationRole, _EntityKeyConstants._SecurityAuthEntityKeys._ApplicationRoleAttributeKeys.@IsAreaUsuaria, "isareausuaria") ?? "isareausuaria", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@ApplicationRole, _EntityKeyConstants._SecurityAuthEntityKeys._ApplicationRoleAttributeKeys.@IsAreaCxP, "isareacxp") ?? "isareacxp", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@ApplicationRole, _EntityKeyConstants._SecurityAuthEntityKeys._ApplicationRoleAttributeKeys.@CanBulkApproveFolios, "canbulkapprovefolios") ?? "canbulkapprovefolios", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
" FROM " + ENApplicationRoleEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@ApplicationRole, _EntityKeyConstants._SecurityAuthEntityKeys._ApplicationRoleAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetApplicationRole", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(7,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENApplicationRoleEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
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
