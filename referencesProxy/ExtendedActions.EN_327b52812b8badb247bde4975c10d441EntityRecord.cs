using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {
public partial class ExtendedActions {
/// <summary>
/// Action: GetCurrency
/// </summary>

public static async Task<RC_0468f02f35e6ccd6a092f321c5d8a88e> GetCurrency(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_0468f02f35e6ccd6a092f321c5d8a88e outParamRecord = default;
outParamRecord = new RC_0468f02f35e6ccd6a092f321c5d8a88e();

var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ENCurrencyEntity.eSpaceKey;
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetCurrency", "041b092e-8c1f-4e6c-a3fa-374d04d50edc.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetCurrency", "041b092e-8c1f-4e6c-a3fa-374d04d50edc.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
try {
outParamRecord = ENCurrencyEntity.GetRecordById(inParamId);
} catch {
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Common, _EntityKeyConstants._CommonEntityKeys.@Currency, _EntityKeyConstants._CommonEntityKeys._CurrencyAttributeKeys.@Code, "code") ?? "code", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Common, _EntityKeyConstants._CommonEntityKeys.@Currency, _EntityKeyConstants._CommonEntityKeys._CurrencyAttributeKeys.@Name, "name") ?? "name", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Common, _EntityKeyConstants._CommonEntityKeys.@Currency, _EntityKeyConstants._CommonEntityKeys._CurrencyAttributeKeys.@Symbol, "symbol") ?? "symbol", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Common, _EntityKeyConstants._CommonEntityKeys.@Currency, _EntityKeyConstants._CommonEntityKeys._CurrencyAttributeKeys.@MinorUnitDecimals, "minorunitdecimals") ?? "minorunitdecimals", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Common, _EntityKeyConstants._CommonEntityKeys.@Currency, _EntityKeyConstants._CommonEntityKeys._CurrencyAttributeKeys.@IsActive, "isactive") ?? "isactive", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
" FROM " + ENCurrencyEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Common, _EntityKeyConstants._CommonEntityKeys.@Currency, _EntityKeyConstants._CommonEntityKeys._CurrencyAttributeKeys.@Code, "code") ?? "code") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.String, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetCurrency", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENCurrencyEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
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
