using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: GetInvoiceAccountingProcessStatus
/// </summary>

public static async Task<RC_88759af0096e690bb0b27652d93642e4> GetInvoiceAccountingProcessStatus(IRequestContext requestContext,int inParamId,CancellationToken cancellationToken) {
RC_88759af0096e690bb0b27652d93642e4 outParamRecord = default;
outParamRecord = new RC_88759af0096e690bb0b27652d93642e4();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetInvoiceAccountingProcessStatus", "952c8e00-2ded-4506-b921-102b9ebe8b69.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetInvoiceAccountingProcessStatus", "952c8e00-2ded-4506-b921-102b9ebe8b69.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
try {
outParamRecord = ENInvoiceAccountingProcessStatusEntity.GetRecordById(inParamId);
} catch {
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessStatus, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessStatusAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessStatus, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessStatusAttributeKeys.@Label, "label") ?? "label", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessStatus, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessStatusAttributeKeys.@Order, "order") ?? "order", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessStatus, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessStatusAttributeKeys.@Is_Active, "is_active") ?? "is_active", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
" FROM " + ENInvoiceAccountingProcessStatusEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessStatus, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessStatusAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int32, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetInvoiceAccountingProcessStatus", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENInvoiceAccountingProcessStatusEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
}
return outParamRecord;
}

}
}
