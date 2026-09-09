using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {
public partial class ExtendedActions {
/// <summary>
/// Action: GetGutterSize
/// </summary>

public static async Task<RC_a5018402fa6c90c5e826e54b2748cedc> GetGutterSize(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_a5018402fa6c90c5e826e54b2748cedc outParamRecord = default;
outParamRecord = new RC_a5018402fa6c90c5e826e54b2748cedc();

var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ENGutterSizeEntity.eSpaceKey;
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetGutterSize", "4fc68d17-055e-4537-bcc2-514b09567ae7.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetGutterSize", "4fc68d17-055e-4537-bcc2-514b09567ae7.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
try {
outParamRecord = ENGutterSizeEntity.GetRecordById(inParamId);
} catch {
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName("guttersize", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName("order", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
" FROM " + ENGutterSizeEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier("guttersize") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.String, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetGutterSize", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENGutterSizeEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
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
