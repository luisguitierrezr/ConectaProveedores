using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: GetUserApplicationRoleTemp
/// </summary>

public static async Task<RC_66c67d926e518c0b673d9119f62da193> GetUserApplicationRoleTemp(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_66c67d926e518c0b673d9119f62da193 outParamRecord = default;
outParamRecord = new RC_66c67d926e518c0b673d9119f62da193();

var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ENUserApplicationRoleTempEntity.eSpaceKey;
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetUserApplicationRoleTemp", "f340a009-c8f4-4ca0-bf32-19029d32d14f.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetUserApplicationRoleTemp", "f340a009-c8f4-4ca0-bf32-19029d32d14f.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@UserApplicationRoleTemp, _EntityKeyConstants._SecurityAuthEntityKeys._UserApplicationRoleTempAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@UserApplicationRoleTemp, _EntityKeyConstants._SecurityAuthEntityKeys._UserApplicationRoleTempAttributeKeys.@UserId, "userid") ?? "userid", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@UserApplicationRoleTemp, _EntityKeyConstants._SecurityAuthEntityKeys._UserApplicationRoleTempAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@UserApplicationRoleTemp, _EntityKeyConstants._SecurityAuthEntityKeys._UserApplicationRoleTempAttributeKeys.@EntraRoleId, "entraroleid") ?? "entraroleid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@UserApplicationRoleTemp, _EntityKeyConstants._SecurityAuthEntityKeys._UserApplicationRoleTempAttributeKeys.@AssignedBy, "assignedby") ?? "assignedby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@UserApplicationRoleTemp, _EntityKeyConstants._SecurityAuthEntityKeys._UserApplicationRoleTempAttributeKeys.@AssignedDate, "assigneddate") ?? "assigneddate", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@UserApplicationRoleTemp, _EntityKeyConstants._SecurityAuthEntityKeys._UserApplicationRoleTempAttributeKeys.@RoleStatusId, "rolestatusid") ?? "rolestatusid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@UserApplicationRoleTemp, _EntityKeyConstants._SecurityAuthEntityKeys._UserApplicationRoleTempAttributeKeys.@RevokedBy, "revokedby") ?? "revokedby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@UserApplicationRoleTemp, _EntityKeyConstants._SecurityAuthEntityKeys._UserApplicationRoleTempAttributeKeys.@RevokedDate, "revokeddate") ?? "revokeddate", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@UserApplicationRoleTemp, _EntityKeyConstants._SecurityAuthEntityKeys._UserApplicationRoleTempAttributeKeys.@DateFrom, "datefrom") ?? "datefrom", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@UserApplicationRoleTemp, _EntityKeyConstants._SecurityAuthEntityKeys._UserApplicationRoleTempAttributeKeys.@DateTo, "dateto") ?? "dateto", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@UserApplicationRoleTemp, _EntityKeyConstants._SecurityAuthEntityKeys._UserApplicationRoleTempAttributeKeys.@LastUpdatedOn, "lastupdatedon") ?? "lastupdatedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@UserApplicationRoleTemp, _EntityKeyConstants._SecurityAuthEntityKeys._UserApplicationRoleTempAttributeKeys.@ConceptId, "conceptid") ?? "conceptid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@UserApplicationRoleTemp, _EntityKeyConstants._SecurityAuthEntityKeys._UserApplicationRoleTempAttributeKeys.@RegionToBeAssign, "regiontobeassign") ?? "regiontobeassign", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
" FROM " + ENUserApplicationRoleTempEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@UserApplicationRoleTemp, _EntityKeyConstants._SecurityAuthEntityKeys._UserApplicationRoleTempAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetUserApplicationRoleTemp", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(14,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENUserApplicationRoleTempEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
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
