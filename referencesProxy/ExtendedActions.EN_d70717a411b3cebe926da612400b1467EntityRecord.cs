using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {
public partial class ExtendedActions {
/// <summary>
/// Action: GetUserApplicationRole
/// </summary>

public static async Task<RC_44a1416c6a0b117b6b7e5164f9d5147f> GetUserApplicationRole(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_44a1416c6a0b117b6b7e5164f9d5147f outParamRecord = default;
outParamRecord = new RC_44a1416c6a0b117b6b7e5164f9d5147f();

var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ENUserApplicationRoleEntity.eSpaceKey;
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetUserApplicationRole", "390ba35d-808c-43c1-86b8-5c56419c05a2.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetUserApplicationRole", "390ba35d-808c-43c1-86b8-5c56419c05a2.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@UserApplicationRole, _EntityKeyConstants._SecurityAuthEntityKeys._UserApplicationRoleAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@UserApplicationRole, _EntityKeyConstants._SecurityAuthEntityKeys._UserApplicationRoleAttributeKeys.@UserId, "userid") ?? "userid", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@UserApplicationRole, _EntityKeyConstants._SecurityAuthEntityKeys._UserApplicationRoleAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@UserApplicationRole, _EntityKeyConstants._SecurityAuthEntityKeys._UserApplicationRoleAttributeKeys.@RegionToBeAssign, "regiontobeassign") ?? "regiontobeassign", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@UserApplicationRole, _EntityKeyConstants._SecurityAuthEntityKeys._UserApplicationRoleAttributeKeys.@AssignedBy, "assignedby") ?? "assignedby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@UserApplicationRole, _EntityKeyConstants._SecurityAuthEntityKeys._UserApplicationRoleAttributeKeys.@AssignedDate, "assigneddate") ?? "assigneddate", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@UserApplicationRole, _EntityKeyConstants._SecurityAuthEntityKeys._UserApplicationRoleAttributeKeys.@RoleStatusId, "rolestatusid") ?? "rolestatusid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@UserApplicationRole, _EntityKeyConstants._SecurityAuthEntityKeys._UserApplicationRoleAttributeKeys.@RevokedBy, "revokedby") ?? "revokedby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@UserApplicationRole, _EntityKeyConstants._SecurityAuthEntityKeys._UserApplicationRoleAttributeKeys.@RevokedDate, "revokeddate") ?? "revokeddate", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@UserApplicationRole, _EntityKeyConstants._SecurityAuthEntityKeys._UserApplicationRoleAttributeKeys.@ConceptId, "conceptid") ?? "conceptid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
" FROM " + ENUserApplicationRoleEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@UserApplicationRole, _EntityKeyConstants._SecurityAuthEntityKeys._UserApplicationRoleAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetUserApplicationRole", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(10,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENUserApplicationRoleEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
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
