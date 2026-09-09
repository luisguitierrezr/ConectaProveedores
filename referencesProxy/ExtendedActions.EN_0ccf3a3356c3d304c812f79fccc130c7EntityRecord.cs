using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {
public partial class ExtendedActions {
/// <summary>
/// Action: GetProcessType
/// </summary>

public static async Task<RC_efc73b4c3b9559691917e7c2536af227> GetProcessType(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_efc73b4c3b9559691917e7c2536af227 outParamRecord = default;
outParamRecord = new RC_efc73b4c3b9559691917e7c2536af227();

var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ENProcessTypeEntity.eSpaceKey;
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetProcessType", "e28f57a4-1075-421b-afd4-0f776146777d.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetProcessType", "e28f57a4-1075-421b-afd4-0f776146777d.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ProcessType, _EntityKeyConstants._WorkflowEngineEntityKeys._ProcessTypeAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ProcessType, _EntityKeyConstants._WorkflowEngineEntityKeys._ProcessTypeAttributeKeys.@Code, "code") ?? "code", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ProcessType, _EntityKeyConstants._WorkflowEngineEntityKeys._ProcessTypeAttributeKeys.@Label, "label") ?? "label", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ProcessType, _EntityKeyConstants._WorkflowEngineEntityKeys._ProcessTypeAttributeKeys.@Order, "order") ?? "order", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ProcessType, _EntityKeyConstants._WorkflowEngineEntityKeys._ProcessTypeAttributeKeys.@Is_Active, "is_active") ?? "is_active", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
" FROM " + ENProcessTypeEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ProcessType, _EntityKeyConstants._WorkflowEngineEntityKeys._ProcessTypeAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetProcessType", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(5,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENProcessTypeEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
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
