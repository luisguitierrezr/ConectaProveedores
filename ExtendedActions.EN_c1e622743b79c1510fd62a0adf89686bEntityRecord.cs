using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: GetSideMenuBehavior
/// </summary>

public static async Task<RC_e3607d6b92545e5793fbeb99fc16b7e7> GetSideMenuBehavior(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_e3607d6b92545e5793fbeb99fc16b7e7 outParamRecord = default;
outParamRecord = new RC_e3607d6b92545e5793fbeb99fc16b7e7();

var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ENSideMenuBehaviorEntity.eSpaceKey;
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetSideMenuBehavior", "1d88da43-b8ea-4f00-9a96-589b3cf85f8b.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetSideMenuBehavior", "1d88da43-b8ea-4f00-9a96-589b3cf85f8b.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
try {
outParamRecord = ENSideMenuBehaviorEntity.GetRecordById(inParamId);
} catch {
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName("sidemenubehavior", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
" FROM " + ENSideMenuBehaviorEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier("sidemenubehavior") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.String, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetSideMenuBehavior", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENSideMenuBehaviorEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
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
