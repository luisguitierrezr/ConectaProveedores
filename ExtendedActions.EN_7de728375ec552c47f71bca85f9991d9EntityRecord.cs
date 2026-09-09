using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: GetProposalType
/// </summary>

public static async Task<RC_d6a77c530b0e1f2687ee6b3214e237ef> GetProposalType(IRequestContext requestContext,int inParamId,CancellationToken cancellationToken) {
RC_d6a77c530b0e1f2687ee6b3214e237ef outParamRecord = default;
outParamRecord = new RC_d6a77c530b0e1f2687ee6b3214e237ef();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetProposalType", "4670f05d-9252-41be-87ac-ada50bae3b3d.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetProposalType", "4670f05d-9252-41be-87ac-ada50bae3b3d.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
try {
outParamRecord = ENProposalTypeEntity.GetRecordById(inParamId);
} catch {
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalType, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalTypeAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalType, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalTypeAttributeKeys.@Label, "label") ?? "label", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalType, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalTypeAttributeKeys.@Order, "order") ?? "order", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalType, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalTypeAttributeKeys.@Is_Active, "is_active") ?? "is_active", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
" FROM " + ENProposalTypeEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalType, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalTypeAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int32, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetProposalType", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENProposalTypeEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
}
return outParamRecord;
}

}
}
