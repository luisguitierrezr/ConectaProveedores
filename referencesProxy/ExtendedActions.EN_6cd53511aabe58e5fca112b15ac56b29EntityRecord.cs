using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {
public partial class ExtendedActions {
/// <summary>
/// Action: GetSpecialWorkflowUploadPuestos
/// </summary>

public static async Task<RC_46f699009338b3c2298787ee4b6262ec> GetSpecialWorkflowUploadPuestos(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_46f699009338b3c2298787ee4b6262ec outParamRecord = default;
outParamRecord = new RC_46f699009338b3c2298787ee4b6262ec();

var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ENSpecialWorkflowUploadPuestosEntity.eSpaceKey;
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetSpecialWorkflowUploadPuestos", "f8f7588d-562d-4aaa-863d-6f3711d6a00d.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetSpecialWorkflowUploadPuestos", "f8f7588d-562d-4aaa-863d-6f3711d6a00d.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@SpecialWorkflowUploadPuestos, _EntityKeyConstants._WorkflowEngineEntityKeys._SpecialWorkflowUploadPuestosAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@SpecialWorkflowUploadPuestos, _EntityKeyConstants._WorkflowEngineEntityKeys._SpecialWorkflowUploadPuestosAttributeKeys.@SpecialWorkflowId, "specialworkflowid") ?? "specialworkflowid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@SpecialWorkflowUploadPuestos, _EntityKeyConstants._WorkflowEngineEntityKeys._SpecialWorkflowUploadPuestosAttributeKeys.@EntraRoleId, "entraroleid") ?? "entraroleid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
" FROM " + ENSpecialWorkflowUploadPuestosEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@SpecialWorkflowUploadPuestos, _EntityKeyConstants._WorkflowEngineEntityKeys._SpecialWorkflowUploadPuestosAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetSpecialWorkflowUploadPuestos", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(3,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENSpecialWorkflowUploadPuestosEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
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
