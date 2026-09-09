using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {
public partial class ExtendedActions {
/// <summary>
/// Action: GetPaperSize
/// </summary>

public static async Task<RC_6748c146370600806f2500c8b8a2cb25> GetPaperSize(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_6748c146370600806f2500c8b8a2cb25 outParamRecord = default;
outParamRecord = new RC_6748c146370600806f2500c8b8a2cb25();

var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ENPaperSizeEntity.eSpaceKey;
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetPaperSize", "b1a7c773-686f-4074-bb64-de0e07b586bf.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetPaperSize", "b1a7c773-686f-4074-bb64-de0e07b586bf.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
try {
outParamRecord = ENPaperSizeEntity.GetRecordById(inParamId);
} catch {
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName("size", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName("label", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName("order", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName("width", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName("height", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName("isinternational", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName("islandscape", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
" FROM " + ENPaperSizeEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier("size") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.String, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetPaperSize", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENPaperSizeEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
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
