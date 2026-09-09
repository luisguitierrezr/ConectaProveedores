using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {
public partial class ExtendedActions {
/// <summary>
/// Action: GetAudit
/// </summary>

public static async Task<RC_1549014643485d6d2fd0ba657a6961ac> GetAudit(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_1549014643485d6d2fd0ba657a6961ac outParamRecord = default;
outParamRecord = new RC_1549014643485d6d2fd0ba657a6961ac();

var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ENAuditEntity.eSpaceKey;
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetAudit", "879d05c9-ec9a-4860-b194-bda332be1a46.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetAudit", "879d05c9-ec9a-4860-b194-bda332be1a46.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@AuditEngine, _EntityKeyConstants._AuditEngineEntityKeys.@Audit, _EntityKeyConstants._AuditEngineEntityKeys._AuditAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@AuditEngine, _EntityKeyConstants._AuditEngineEntityKeys.@Audit, _EntityKeyConstants._AuditEngineEntityKeys._AuditAttributeKeys.@Origin, "origin") ?? "origin", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@AuditEngine, _EntityKeyConstants._AuditEngineEntityKeys.@Audit, _EntityKeyConstants._AuditEngineEntityKeys._AuditAttributeKeys.@Identifier, "identifier") ?? "identifier", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@AuditEngine, _EntityKeyConstants._AuditEngineEntityKeys.@Audit, _EntityKeyConstants._AuditEngineEntityKeys._AuditAttributeKeys.@Message, "message") ?? "message", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@AuditEngine, _EntityKeyConstants._AuditEngineEntityKeys.@Audit, _EntityKeyConstants._AuditEngineEntityKeys._AuditAttributeKeys.@Screen, "screen") ?? "screen", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@AuditEngine, _EntityKeyConstants._AuditEngineEntityKeys.@Audit, _EntityKeyConstants._AuditEngineEntityKeys._AuditAttributeKeys.@Functionality, "functionality") ?? "functionality", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@AuditEngine, _EntityKeyConstants._AuditEngineEntityKeys.@Audit, _EntityKeyConstants._AuditEngineEntityKeys._AuditAttributeKeys.@OriginalJSON, "originaljson") ?? "originaljson", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@AuditEngine, _EntityKeyConstants._AuditEngineEntityKeys.@Audit, _EntityKeyConstants._AuditEngineEntityKeys._AuditAttributeKeys.@ChangeJSON, "changejson") ?? "changejson", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@AuditEngine, _EntityKeyConstants._AuditEngineEntityKeys.@Audit, _EntityKeyConstants._AuditEngineEntityKeys._AuditAttributeKeys.@OccurrenceDateTime, "occurrencedatetime") ?? "occurrencedatetime", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@AuditEngine, _EntityKeyConstants._AuditEngineEntityKeys.@Audit, _EntityKeyConstants._AuditEngineEntityKeys._AuditAttributeKeys.@OccurrenceUser, "occurrenceuser") ?? "occurrenceuser", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@AuditEngine, _EntityKeyConstants._AuditEngineEntityKeys.@Audit, _EntityKeyConstants._AuditEngineEntityKeys._AuditAttributeKeys.@OccurrenceRoleName, "occurrencerolename") ?? "occurrencerolename", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@AuditEngine, _EntityKeyConstants._AuditEngineEntityKeys.@Audit, _EntityKeyConstants._AuditEngineEntityKeys._AuditAttributeKeys.@AccessIP, "accessip") ?? "accessip", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@AuditEngine, _EntityKeyConstants._AuditEngineEntityKeys.@Audit, _EntityKeyConstants._AuditEngineEntityKeys._AuditAttributeKeys.@IsError, "iserror") ?? "iserror", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
" FROM " + ENAuditEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@AuditEngine, _EntityKeyConstants._AuditEngineEntityKeys.@Audit, _EntityKeyConstants._AuditEngineEntityKeys._AuditAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetAudit", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(13,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENAuditEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
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
