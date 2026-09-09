using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: GetAccordionIconType
/// </summary>

public static async Task<RC_73fae6920f82113320dccc89ef073c01> GetAccordionIconType(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_73fae6920f82113320dccc89ef073c01 outParamRecord = default;
outParamRecord = new RC_73fae6920f82113320dccc89ef073c01();

var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ENAccordionIconTypeEntity.eSpaceKey;
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetAccordionIconType", "5744e674-e4d0-40e8-9df1-96240989f5b6.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetAccordionIconType", "5744e674-e4d0-40e8-9df1-96240989f5b6.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
try {
outParamRecord = ENAccordionIconTypeEntity.GetRecordById(inParamId);
} catch {
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName("id", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
" FROM " + ENAccordionIconTypeEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier("id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.String, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetAccordionIconType", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENAccordionIconTypeEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
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
