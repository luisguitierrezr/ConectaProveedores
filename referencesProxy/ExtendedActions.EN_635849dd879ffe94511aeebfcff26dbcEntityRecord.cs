using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {
public partial class ExtendedActions {
/// <summary>
/// Action: GetEntraDomain
/// </summary>

public static async Task<RC_46822aff680dcd6a1139ef31b620e73d> GetEntraDomain(IRequestContext requestContext,int inParamId,CancellationToken cancellationToken) {
RC_46822aff680dcd6a1139ef31b620e73d outParamRecord = default;
outParamRecord = new RC_46822aff680dcd6a1139ef31b620e73d();

var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ENEntraDomainEntity.eSpaceKey;
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetEntraDomain", "8f082e63-ccf0-48d7-a279-8177fd00ba21.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetEntraDomain", "8f082e63-ccf0-48d7-a279-8177fd00ba21.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
try {
outParamRecord = ENEntraDomainEntity.GetRecordById(inParamId);
} catch {
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName("id", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName("label", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName("order", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName("is_active", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName("sufix", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
" FROM " + ENEntraDomainEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier("id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int32, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetEntraDomain", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENEntraDomainEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
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
