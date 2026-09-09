using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: GetLogsAccountingSubject
/// </summary>

public static async Task<RC_780ecab424bd911724518df74dd2298a> GetLogsAccountingSubject(IRequestContext requestContext,int inParamId,CancellationToken cancellationToken) {
RC_780ecab424bd911724518df74dd2298a outParamRecord = default;
outParamRecord = new RC_780ecab424bd911724518df74dd2298a();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetLogsAccountingSubject", "6be693dc-33bf-44a4-a531-ee94a8885d2d.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetLogsAccountingSubject", "6be693dc-33bf-44a4-a531-ee94a8885d2d.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
try {
outParamRecord = ENLogsAccountingSubjectEntity.GetRecordById(inParamId);
} catch {
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccountingSubject, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingSubjectAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccountingSubject, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingSubjectAttributeKeys.@Label, "label") ?? "label", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccountingSubject, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingSubjectAttributeKeys.@Order, "order") ?? "order", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccountingSubject, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingSubjectAttributeKeys.@Is_Active, "is_active") ?? "is_active", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
" FROM " + ENLogsAccountingSubjectEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccountingSubject, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingSubjectAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int32, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetLogsAccountingSubject", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENLogsAccountingSubjectEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
}
return outParamRecord;
}

}
}
