using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: GetAccountingDataType
/// </summary>

public static async Task<RC_a222d17a2b10e551d257fa2f5892499c> GetAccountingDataType(IRequestContext requestContext,int inParamId,CancellationToken cancellationToken) {
RC_a222d17a2b10e551d257fa2f5892499c outParamRecord = default;
outParamRecord = new RC_a222d17a2b10e551d257fa2f5892499c();

var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ENAccountingDataTypeEntity.eSpaceKey;
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetAccountingDataType", "bd177bc3-68e7-48d4-b43b-be84370c8827.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetAccountingDataType", "bd177bc3-68e7-48d4-b43b-be84370c8827.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
try {
outParamRecord = ENAccountingDataTypeEntity.GetRecordById(inParamId);
} catch {
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@AccountingDataType, _EntityKeyConstants._OrganizationEntityKeys._AccountingDataTypeAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@AccountingDataType, _EntityKeyConstants._OrganizationEntityKeys._AccountingDataTypeAttributeKeys.@Label, "label") ?? "label", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@AccountingDataType, _EntityKeyConstants._OrganizationEntityKeys._AccountingDataTypeAttributeKeys.@Order, "order") ?? "order", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@AccountingDataType, _EntityKeyConstants._OrganizationEntityKeys._AccountingDataTypeAttributeKeys.@Is_Active, "is_active") ?? "is_active", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@AccountingDataType, _EntityKeyConstants._OrganizationEntityKeys._AccountingDataTypeAttributeKeys.@IsEstim_Equal_Agreed, "isestim_equal_agreed") ?? "isestim_equal_agreed", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
" FROM " + ENAccountingDataTypeEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@AccountingDataType, _EntityKeyConstants._OrganizationEntityKeys._AccountingDataTypeAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int32, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetAccountingDataType", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENAccountingDataTypeEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
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
