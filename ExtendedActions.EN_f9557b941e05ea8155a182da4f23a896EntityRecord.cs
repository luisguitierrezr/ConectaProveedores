using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: GetManuals
/// </summary>

public static async Task<RC_5a839548c2b6676209dad9fb179bc76c> GetManuals(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_5a839548c2b6676209dad9fb179bc76c outParamRecord = default;
outParamRecord = new RC_5a839548c2b6676209dad9fb179bc76c();

var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ENManualsEntity.eSpaceKey;
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetManuals", "cb348ba3-5ffa-4033-a153-112c544d7bb1.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetManuals", "cb348ba3-5ffa-4033-a153-112c544d7bb1.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Manuals, _EntityKeyConstants._OrganizationEntityKeys._ManualsAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Manuals, _EntityKeyConstants._OrganizationEntityKeys._ManualsAttributeKeys.@Title, "title") ?? "title", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Manuals, _EntityKeyConstants._OrganizationEntityKeys._ManualsAttributeKeys.@AppConceptId, "appconceptid") ?? "appconceptid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Manuals, _EntityKeyConstants._OrganizationEntityKeys._ManualsAttributeKeys.@ConceptId, "conceptid") ?? "conceptid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Manuals, _EntityKeyConstants._OrganizationEntityKeys._ManualsAttributeKeys.@ShortDescription, "shortdescription") ?? "shortdescription", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Manuals, _EntityKeyConstants._OrganizationEntityKeys._ManualsAttributeKeys.@Description, "description") ?? "description", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Manuals, _EntityKeyConstants._OrganizationEntityKeys._ManualsAttributeKeys.@Star, "star") ?? "star", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Manuals, _EntityKeyConstants._OrganizationEntityKeys._ManualsAttributeKeys.@ForProveedor, "forproveedor") ?? "forproveedor", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Manuals, _EntityKeyConstants._OrganizationEntityKeys._ManualsAttributeKeys.@IsVideo, "isvideo") ?? "isvideo", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Manuals, _EntityKeyConstants._OrganizationEntityKeys._ManualsAttributeKeys.@IsActive, "isactive") ?? "isactive", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Manuals, _EntityKeyConstants._OrganizationEntityKeys._ManualsAttributeKeys.@CreatedOn, "createdon") ?? "createdon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Manuals, _EntityKeyConstants._OrganizationEntityKeys._ManualsAttributeKeys.@CreatedBy, "createdby") ?? "createdby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
" FROM " + ENManualsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Manuals, _EntityKeyConstants._OrganizationEntityKeys._ManualsAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetManuals", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(12,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENManualsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
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
