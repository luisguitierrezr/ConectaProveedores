using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateFolioSAPData
/// </summary>

public static async Task<long> CreateFolioSAPData(IRequestContext requestContext,RC_7fd286c48691331601c5027580ae5af5 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateFolioSAPData", "03162d61-5383-4bd0-bc24-41c67fa609c9.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateFolioSAPData", "03162d61-5383-4bd0-bc24-41c67fa609c9.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord ssENFolioSAPData = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENFolioSAPDataEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@FolioId, "folioid") ?? "folioid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@Service, "service") ?? "service") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_DOCUMENTO_MATERIAL_EM, "po_documento_material_em") ?? "po_documento_material_em") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_DOCUMENTO_MATERIAL_SM, "po_documento_material_sm") ?? "po_documento_material_sm") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_DOCUMENTO_MATERIAL_221, "po_documento_material_221") ?? "po_documento_material_221") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_DOCUMENTO_MATERIAL_415, "po_documento_material_415") ?? "po_documento_material_415") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_EJERCICIO_EM, "po_ejercicio_em") ?? "po_ejercicio_em") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_EJERCICIO_SM, "po_ejercicio_sm") ?? "po_ejercicio_sm") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_EJERCICIO_221, "po_ejercicio_221") ?? "po_ejercicio_221") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_EJERCICIO_415, "po_ejercicio_415") ?? "po_ejercicio_415") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_FOLIO_AGRUPADOS, "po_folio_agrupados") ?? "po_folio_agrupados") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_RESULTADO, "po_resultado") ?? "po_resultado") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + "" +
" ) VALUES (" +
" @ssFolioId" +
", @ssService" +
", @ssPO_DOCUMENTO_MATERIAL_EM" +
", @ssPO_DOCUMENTO_MATERIAL_SM" +
", @ssPO_DOCUMENTO_MATERIAL_221" +
", @ssPO_DOCUMENTO_MATERIAL_415" +
", @ssPO_EJERCICIO_EM" +
", @ssPO_EJERCICIO_SM" +
", @ssPO_EJERCICIO_221" +
", @ssPO_EJERCICIO_415" +
", @ssPO_FOLIO_AGRUPADOS" +
", @ssPO_RESULTADO" +
", @ssCreatedBy" +
", @ssCreatedOn" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENFolioSAPData.ssFolioId==0L)) {
insertSqlCmd.CreateParameter("@ssFolioId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssFolioId", DbType.Int64, ssENFolioSAPData.ssFolioId);

}
insertSqlCmd.CreateParameter("@ssService", DbType.String, ssENFolioSAPData.ssService);
insertSqlCmd.CreateParameter("@ssPO_DOCUMENTO_MATERIAL_EM", DbType.String, ssENFolioSAPData.ssPO_DOCUMENTO_MATERIAL_EM);
insertSqlCmd.CreateParameter("@ssPO_DOCUMENTO_MATERIAL_SM", DbType.String, ssENFolioSAPData.ssPO_DOCUMENTO_MATERIAL_SM);
insertSqlCmd.CreateParameter("@ssPO_DOCUMENTO_MATERIAL_221", DbType.String, ssENFolioSAPData.ssPO_DOCUMENTO_MATERIAL_221);
insertSqlCmd.CreateParameter("@ssPO_DOCUMENTO_MATERIAL_415", DbType.String, ssENFolioSAPData.ssPO_DOCUMENTO_MATERIAL_415);
insertSqlCmd.CreateParameter("@ssPO_EJERCICIO_EM", DbType.String, ssENFolioSAPData.ssPO_EJERCICIO_EM);
insertSqlCmd.CreateParameter("@ssPO_EJERCICIO_SM", DbType.String, ssENFolioSAPData.ssPO_EJERCICIO_SM);
insertSqlCmd.CreateParameter("@ssPO_EJERCICIO_221", DbType.String, ssENFolioSAPData.ssPO_EJERCICIO_221);
insertSqlCmd.CreateParameter("@ssPO_EJERCICIO_415", DbType.String, ssENFolioSAPData.ssPO_EJERCICIO_415);
insertSqlCmd.CreateParameter("@ssPO_FOLIO_AGRUPADOS", DbType.String, ssENFolioSAPData.ssPO_FOLIO_AGRUPADOS);
insertSqlCmd.CreateParameter("@ssPO_RESULTADO", DbType.String, ssENFolioSAPData.ssPO_RESULTADO);
if ((ssENFolioSAPData.ssCreatedBy=="")) {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENFolioSAPData.ssCreatedBy);

}
insertSqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENFolioSAPData.ssCreatedOn);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateFolioSAPData", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateFolioSAPData
/// </summary>

public static async Task<long> CreateOrUpdateFolioSAPData(IRequestContext requestContext,BitArray usedFields,RC_7fd286c48691331601c5027580ae5af5 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateFolioSAPData", "03162d61-5383-4bd0-bc24-41c67fa609c9.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateFolioSAPData", "03162d61-5383-4bd0-bc24-41c67fa609c9.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord ssENFolioSAPData = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(15,true);
}
string updateSet = "UPDATE " + ENFolioSAPDataEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@FolioId, "folioid") ?? "folioid") + " = @ssFolioId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@Service, "service") ?? "service") + " = @ssService"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_DOCUMENTO_MATERIAL_EM, "po_documento_material_em") ?? "po_documento_material_em") + " = @ssPO_DOCUMENTO_MATERIAL_EM"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_DOCUMENTO_MATERIAL_SM, "po_documento_material_sm") ?? "po_documento_material_sm") + " = @ssPO_DOCUMENTO_MATERIAL_SM"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_DOCUMENTO_MATERIAL_221, "po_documento_material_221") ?? "po_documento_material_221") + " = @ssPO_DOCUMENTO_MATERIAL_221"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_DOCUMENTO_MATERIAL_415, "po_documento_material_415") ?? "po_documento_material_415") + " = @ssPO_DOCUMENTO_MATERIAL_415"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_EJERCICIO_EM, "po_ejercicio_em") ?? "po_ejercicio_em") + " = @ssPO_EJERCICIO_EM"): parameters);
parameters = (usedFields[8] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_EJERCICIO_SM, "po_ejercicio_sm") ?? "po_ejercicio_sm") + " = @ssPO_EJERCICIO_SM"): parameters);
parameters = (usedFields[9] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_EJERCICIO_221, "po_ejercicio_221") ?? "po_ejercicio_221") + " = @ssPO_EJERCICIO_221"): parameters);
parameters = (usedFields[10] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_EJERCICIO_415, "po_ejercicio_415") ?? "po_ejercicio_415") + " = @ssPO_EJERCICIO_415"): parameters);
parameters = (usedFields[11] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_FOLIO_AGRUPADOS, "po_folio_agrupados") ?? "po_folio_agrupados") + " = @ssPO_FOLIO_AGRUPADOS"): parameters);
parameters = (usedFields[12] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_RESULTADO, "po_resultado") ?? "po_resultado") + " = @ssPO_RESULTADO"): parameters);
parameters = (usedFields[13] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = @ssCreatedBy"): parameters);
parameters = (usedFields[14] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = @ssCreatedOn"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENFolioSAPData_ssId_FolioSAPData";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENFolioSAPData.ssFolioId==0L)) {
sqlCmd.CreateParameter("@ssFolioId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssFolioId", DbType.Int64, ssENFolioSAPData.ssFolioId);

}
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssService", DbType.String, ssENFolioSAPData.ssService);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssPO_DOCUMENTO_MATERIAL_EM", DbType.String, ssENFolioSAPData.ssPO_DOCUMENTO_MATERIAL_EM);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssPO_DOCUMENTO_MATERIAL_SM", DbType.String, ssENFolioSAPData.ssPO_DOCUMENTO_MATERIAL_SM);
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssPO_DOCUMENTO_MATERIAL_221", DbType.String, ssENFolioSAPData.ssPO_DOCUMENTO_MATERIAL_221);
}
if(usedFields[6]) {
sqlCmd.CreateParameter("@ssPO_DOCUMENTO_MATERIAL_415", DbType.String, ssENFolioSAPData.ssPO_DOCUMENTO_MATERIAL_415);
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssPO_EJERCICIO_EM", DbType.String, ssENFolioSAPData.ssPO_EJERCICIO_EM);
}
if(usedFields[8]) {
sqlCmd.CreateParameter("@ssPO_EJERCICIO_SM", DbType.String, ssENFolioSAPData.ssPO_EJERCICIO_SM);
}
if(usedFields[9]) {
sqlCmd.CreateParameter("@ssPO_EJERCICIO_221", DbType.String, ssENFolioSAPData.ssPO_EJERCICIO_221);
}
if(usedFields[10]) {
sqlCmd.CreateParameter("@ssPO_EJERCICIO_415", DbType.String, ssENFolioSAPData.ssPO_EJERCICIO_415);
}
if(usedFields[11]) {
sqlCmd.CreateParameter("@ssPO_FOLIO_AGRUPADOS", DbType.String, ssENFolioSAPData.ssPO_FOLIO_AGRUPADOS);
}
if(usedFields[12]) {
sqlCmd.CreateParameter("@ssPO_RESULTADO", DbType.String, ssENFolioSAPData.ssPO_RESULTADO);
}
if(usedFields[13]) {
if ((ssENFolioSAPData.ssCreatedBy=="")) {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENFolioSAPData.ssCreatedBy);

}
}
if(usedFields[14]) {
sqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENFolioSAPData.ssCreatedOn);
}
sqlCmd.CreateParameter("@idparam_ssENFolioSAPData_ssId_FolioSAPData", DbType.Int64, ssENFolioSAPData.ssId);
int counter = 0;
if(ssENFolioSAPData.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateFolioSAPData (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENFolioSAPDataEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@FolioId, "folioid") ?? "folioid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@Service, "service") ?? "service") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_DOCUMENTO_MATERIAL_EM, "po_documento_material_em") ?? "po_documento_material_em") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_DOCUMENTO_MATERIAL_SM, "po_documento_material_sm") ?? "po_documento_material_sm") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_DOCUMENTO_MATERIAL_221, "po_documento_material_221") ?? "po_documento_material_221") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_DOCUMENTO_MATERIAL_415, "po_documento_material_415") ?? "po_documento_material_415") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_EJERCICIO_EM, "po_ejercicio_em") ?? "po_ejercicio_em") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_EJERCICIO_SM, "po_ejercicio_sm") ?? "po_ejercicio_sm") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_EJERCICIO_221, "po_ejercicio_221") ?? "po_ejercicio_221") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_EJERCICIO_415, "po_ejercicio_415") ?? "po_ejercicio_415") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_FOLIO_AGRUPADOS, "po_folio_agrupados") ?? "po_folio_agrupados") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_RESULTADO, "po_resultado") ?? "po_resultado") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + "" +
" ) VALUES (" +
" @ssFolioId" +
", @ssService" +
", @ssPO_DOCUMENTO_MATERIAL_EM" +
", @ssPO_DOCUMENTO_MATERIAL_SM" +
", @ssPO_DOCUMENTO_MATERIAL_221" +
", @ssPO_DOCUMENTO_MATERIAL_415" +
", @ssPO_EJERCICIO_EM" +
", @ssPO_EJERCICIO_SM" +
", @ssPO_EJERCICIO_221" +
", @ssPO_EJERCICIO_415" +
", @ssPO_FOLIO_AGRUPADOS" +
", @ssPO_RESULTADO" +
", @ssCreatedBy" +
", @ssCreatedOn" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENFolioSAPData.ssFolioId==0L)) {
insertSqlCmd.CreateParameter("@ssFolioId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssFolioId", DbType.Int64, ssENFolioSAPData.ssFolioId);

}
insertSqlCmd.CreateParameter("@ssService", DbType.String, ssENFolioSAPData.ssService);
insertSqlCmd.CreateParameter("@ssPO_DOCUMENTO_MATERIAL_EM", DbType.String, ssENFolioSAPData.ssPO_DOCUMENTO_MATERIAL_EM);
insertSqlCmd.CreateParameter("@ssPO_DOCUMENTO_MATERIAL_SM", DbType.String, ssENFolioSAPData.ssPO_DOCUMENTO_MATERIAL_SM);
insertSqlCmd.CreateParameter("@ssPO_DOCUMENTO_MATERIAL_221", DbType.String, ssENFolioSAPData.ssPO_DOCUMENTO_MATERIAL_221);
insertSqlCmd.CreateParameter("@ssPO_DOCUMENTO_MATERIAL_415", DbType.String, ssENFolioSAPData.ssPO_DOCUMENTO_MATERIAL_415);
insertSqlCmd.CreateParameter("@ssPO_EJERCICIO_EM", DbType.String, ssENFolioSAPData.ssPO_EJERCICIO_EM);
insertSqlCmd.CreateParameter("@ssPO_EJERCICIO_SM", DbType.String, ssENFolioSAPData.ssPO_EJERCICIO_SM);
insertSqlCmd.CreateParameter("@ssPO_EJERCICIO_221", DbType.String, ssENFolioSAPData.ssPO_EJERCICIO_221);
insertSqlCmd.CreateParameter("@ssPO_EJERCICIO_415", DbType.String, ssENFolioSAPData.ssPO_EJERCICIO_415);
insertSqlCmd.CreateParameter("@ssPO_FOLIO_AGRUPADOS", DbType.String, ssENFolioSAPData.ssPO_FOLIO_AGRUPADOS);
insertSqlCmd.CreateParameter("@ssPO_RESULTADO", DbType.String, ssENFolioSAPData.ssPO_RESULTADO);
if ((ssENFolioSAPData.ssCreatedBy=="")) {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENFolioSAPData.ssCreatedBy);

}
insertSqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENFolioSAPData.ssCreatedOn);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateFolioSAPData", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENFolioSAPData.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeFolioSAPData
/// </summary>

public static async Task CreateOrUpdateSomeFolioSAPData(IRequestContext requestContext,RL_c9f6aa71e71ab2513c8b708a5c8313ba inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeFolioSAPData", "03162d61-5383-4bd0-bc24-41c67fa609c9.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeFolioSAPData", "03162d61-5383-4bd0-bc24-41c67fa609c9.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENFolioSAPDataEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@FolioId, "folioid") ?? "folioid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@Service, "service") ?? "service") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_DOCUMENTO_MATERIAL_EM, "po_documento_material_em") ?? "po_documento_material_em") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_DOCUMENTO_MATERIAL_SM, "po_documento_material_sm") ?? "po_documento_material_sm") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_DOCUMENTO_MATERIAL_221, "po_documento_material_221") ?? "po_documento_material_221") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_DOCUMENTO_MATERIAL_415, "po_documento_material_415") ?? "po_documento_material_415") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_EJERCICIO_EM, "po_ejercicio_em") ?? "po_ejercicio_em") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_EJERCICIO_SM, "po_ejercicio_sm") ?? "po_ejercicio_sm") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_EJERCICIO_221, "po_ejercicio_221") ?? "po_ejercicio_221") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_EJERCICIO_415, "po_ejercicio_415") ?? "po_ejercicio_415") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_FOLIO_AGRUPADOS, "po_folio_agrupados") ?? "po_folio_agrupados") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_RESULTADO, "po_resultado") ?? "po_resultado") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + ") VALUES ( unnest(@ssFolioId),  unnest(@ssService),  unnest(@ssPO_DOCUMENTO_MATERIAL_EM),  unnest(@ssPO_DOCUMENTO_MATERIAL_SM),  unnest(@ssPO_DOCUMENTO_MATERIAL_221),  unnest(@ssPO_DOCUMENTO_MATERIAL_415),  unnest(@ssPO_EJERCICIO_EM),  unnest(@ssPO_EJERCICIO_SM),  unnest(@ssPO_EJERCICIO_221),  unnest(@ssPO_EJERCICIO_415),  unnest(@ssPO_FOLIO_AGRUPADOS),  unnest(@ssPO_RESULTADO),  unnest(@ssCreatedBy),  unnest(@ssCreatedOn)) ";
insertSql += "";

string updateSql = "UPDATE " + entityTableName + " SET " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@FolioId, "folioid") ?? "folioid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@FolioId, "folioid") ?? "folioid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@Service, "service") ?? "service") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@Service, "service") ?? "service") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_DOCUMENTO_MATERIAL_EM, "po_documento_material_em") ?? "po_documento_material_em") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_DOCUMENTO_MATERIAL_EM, "po_documento_material_em") ?? "po_documento_material_em") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_DOCUMENTO_MATERIAL_SM, "po_documento_material_sm") ?? "po_documento_material_sm") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_DOCUMENTO_MATERIAL_SM, "po_documento_material_sm") ?? "po_documento_material_sm") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_DOCUMENTO_MATERIAL_221, "po_documento_material_221") ?? "po_documento_material_221") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_DOCUMENTO_MATERIAL_221, "po_documento_material_221") ?? "po_documento_material_221") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_DOCUMENTO_MATERIAL_415, "po_documento_material_415") ?? "po_documento_material_415") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_DOCUMENTO_MATERIAL_415, "po_documento_material_415") ?? "po_documento_material_415") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_EJERCICIO_EM, "po_ejercicio_em") ?? "po_ejercicio_em") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_EJERCICIO_EM, "po_ejercicio_em") ?? "po_ejercicio_em") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_EJERCICIO_SM, "po_ejercicio_sm") ?? "po_ejercicio_sm") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_EJERCICIO_SM, "po_ejercicio_sm") ?? "po_ejercicio_sm") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_EJERCICIO_221, "po_ejercicio_221") ?? "po_ejercicio_221") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_EJERCICIO_221, "po_ejercicio_221") ?? "po_ejercicio_221") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_EJERCICIO_415, "po_ejercicio_415") ?? "po_ejercicio_415") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_EJERCICIO_415, "po_ejercicio_415") ?? "po_ejercicio_415") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_FOLIO_AGRUPADOS, "po_folio_agrupados") ?? "po_folio_agrupados") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_FOLIO_AGRUPADOS, "po_folio_agrupados") ?? "po_folio_agrupados") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_RESULTADO, "po_resultado") ?? "po_resultado") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_RESULTADO, "po_resultado") ?? "po_resultado") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " from ( select  unnest(@ssId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@Id, "id") ?? "id") + ",  unnest(@ssFolioId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@FolioId, "folioid") ?? "folioid") + ",  unnest(@ssService) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@Service, "service") ?? "service") + ",  unnest(@ssPO_DOCUMENTO_MATERIAL_EM) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_DOCUMENTO_MATERIAL_EM, "po_documento_material_em") ?? "po_documento_material_em") + ",  unnest(@ssPO_DOCUMENTO_MATERIAL_SM) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_DOCUMENTO_MATERIAL_SM, "po_documento_material_sm") ?? "po_documento_material_sm") + ",  unnest(@ssPO_DOCUMENTO_MATERIAL_221) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_DOCUMENTO_MATERIAL_221, "po_documento_material_221") ?? "po_documento_material_221") + ",  unnest(@ssPO_DOCUMENTO_MATERIAL_415) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_DOCUMENTO_MATERIAL_415, "po_documento_material_415") ?? "po_documento_material_415") + ",  unnest(@ssPO_EJERCICIO_EM) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_EJERCICIO_EM, "po_ejercicio_em") ?? "po_ejercicio_em") + ",  unnest(@ssPO_EJERCICIO_SM) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_EJERCICIO_SM, "po_ejercicio_sm") ?? "po_ejercicio_sm") + ",  unnest(@ssPO_EJERCICIO_221) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_EJERCICIO_221, "po_ejercicio_221") ?? "po_ejercicio_221") + ",  unnest(@ssPO_EJERCICIO_415) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_EJERCICIO_415, "po_ejercicio_415") ?? "po_ejercicio_415") + ",  unnest(@ssPO_FOLIO_AGRUPADOS) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_FOLIO_AGRUPADOS, "po_folio_agrupados") ?? "po_folio_agrupados") + ",  unnest(@ssPO_RESULTADO) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_RESULTADO, "po_resultado") ?? "po_resultado") + ",  unnest(@ssCreatedBy) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ",  unnest(@ssCreatedOn) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " ) as updateTable where " + entityTableName + "." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@Id, "id") ?? "id") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@Id, "id") ?? "id") + " ";
updateSql += "";

List<object> insertFolioIdList = new List<object>();
List<string> insertServiceList = new List<string>();
List<string> insertPO_DOCUMENTO_MATERIAL_EMList = new List<string>();
List<string> insertPO_DOCUMENTO_MATERIAL_SMList = new List<string>();
List<string> insertPO_DOCUMENTO_MATERIAL_221List = new List<string>();
List<string> insertPO_DOCUMENTO_MATERIAL_415List = new List<string>();
List<string> insertPO_EJERCICIO_EMList = new List<string>();
List<string> insertPO_EJERCICIO_SMList = new List<string>();
List<string> insertPO_EJERCICIO_221List = new List<string>();
List<string> insertPO_EJERCICIO_415List = new List<string>();
List<string> insertPO_FOLIO_AGRUPADOSList = new List<string>();
List<string> insertPO_RESULTADOList = new List<string>();
List<object> insertCreatedByList = new List<object>();
List<DateTime> insertCreatedOnList = new List<DateTime>();

List<long> updateIdList = new List<long>();
List<object> updateFolioIdList = new List<object>();
List<string> updateServiceList = new List<string>();
List<string> updatePO_DOCUMENTO_MATERIAL_EMList = new List<string>();
List<string> updatePO_DOCUMENTO_MATERIAL_SMList = new List<string>();
List<string> updatePO_DOCUMENTO_MATERIAL_221List = new List<string>();
List<string> updatePO_DOCUMENTO_MATERIAL_415List = new List<string>();
List<string> updatePO_EJERCICIO_EMList = new List<string>();
List<string> updatePO_EJERCICIO_SMList = new List<string>();
List<string> updatePO_EJERCICIO_221List = new List<string>();
List<string> updatePO_EJERCICIO_415List = new List<string>();
List<string> updatePO_FOLIO_AGRUPADOSList = new List<string>();
List<string> updatePO_RESULTADOList = new List<string>();
List<object> updateCreatedByList = new List<object>();
List<DateTime> updateCreatedOnList = new List<DateTime>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_7fd286c48691331601c5027580ae5af5)inParamSourceList.Current).ssENFolioSAPData;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
if ((record.ssFolioId==0L)) {
updateFolioIdList.Add(null);
} else {
updateFolioIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssFolioId));
}
updateServiceList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssService));
updatePO_DOCUMENTO_MATERIAL_EMList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssPO_DOCUMENTO_MATERIAL_EM));
updatePO_DOCUMENTO_MATERIAL_SMList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssPO_DOCUMENTO_MATERIAL_SM));
updatePO_DOCUMENTO_MATERIAL_221List.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssPO_DOCUMENTO_MATERIAL_221));
updatePO_DOCUMENTO_MATERIAL_415List.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssPO_DOCUMENTO_MATERIAL_415));
updatePO_EJERCICIO_EMList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssPO_EJERCICIO_EM));
updatePO_EJERCICIO_SMList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssPO_EJERCICIO_SM));
updatePO_EJERCICIO_221List.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssPO_EJERCICIO_221));
updatePO_EJERCICIO_415List.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssPO_EJERCICIO_415));
updatePO_FOLIO_AGRUPADOSList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssPO_FOLIO_AGRUPADOS));
updatePO_RESULTADOList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssPO_RESULTADO));
if ((record.ssCreatedBy=="")) {
updateCreatedByList.Add(null);
} else {
updateCreatedByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCreatedBy));
}
updateCreatedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssCreatedOn));
} else {
if ((record.ssFolioId==0L)) {
insertFolioIdList.Add(null);
} else {
insertFolioIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssFolioId));
}
insertServiceList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssService));
insertPO_DOCUMENTO_MATERIAL_EMList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssPO_DOCUMENTO_MATERIAL_EM));
insertPO_DOCUMENTO_MATERIAL_SMList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssPO_DOCUMENTO_MATERIAL_SM));
insertPO_DOCUMENTO_MATERIAL_221List.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssPO_DOCUMENTO_MATERIAL_221));
insertPO_DOCUMENTO_MATERIAL_415List.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssPO_DOCUMENTO_MATERIAL_415));
insertPO_EJERCICIO_EMList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssPO_EJERCICIO_EM));
insertPO_EJERCICIO_SMList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssPO_EJERCICIO_SM));
insertPO_EJERCICIO_221List.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssPO_EJERCICIO_221));
insertPO_EJERCICIO_415List.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssPO_EJERCICIO_415));
insertPO_FOLIO_AGRUPADOSList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssPO_FOLIO_AGRUPADOS));
insertPO_RESULTADOList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssPO_RESULTADO));
if ((record.ssCreatedBy=="")) {
insertCreatedByList.Add(null);
} else {
insertCreatedByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCreatedBy));
}
insertCreatedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssCreatedOn));
}
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertFolioIdList.IsEmpty() || !insertServiceList.IsEmpty() || !insertPO_DOCUMENTO_MATERIAL_EMList.IsEmpty() || !insertPO_DOCUMENTO_MATERIAL_SMList.IsEmpty() || !insertPO_DOCUMENTO_MATERIAL_221List.IsEmpty() || !insertPO_DOCUMENTO_MATERIAL_415List.IsEmpty() || !insertPO_EJERCICIO_EMList.IsEmpty() || !insertPO_EJERCICIO_SMList.IsEmpty() || !insertPO_EJERCICIO_221List.IsEmpty() || !insertPO_EJERCICIO_415List.IsEmpty() || !insertPO_FOLIO_AGRUPADOSList.IsEmpty() || !insertPO_RESULTADOList.IsEmpty() || !insertCreatedByList.IsEmpty() || !insertCreatedOnList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssFolioId",DbType.Int64,insertFolioIdList);
executionService.CreateParameter(insertSqlCmd,"@ssService",DbType.String,insertServiceList);
executionService.CreateParameter(insertSqlCmd,"@ssPO_DOCUMENTO_MATERIAL_EM",DbType.String,insertPO_DOCUMENTO_MATERIAL_EMList);
executionService.CreateParameter(insertSqlCmd,"@ssPO_DOCUMENTO_MATERIAL_SM",DbType.String,insertPO_DOCUMENTO_MATERIAL_SMList);
executionService.CreateParameter(insertSqlCmd,"@ssPO_DOCUMENTO_MATERIAL_221",DbType.String,insertPO_DOCUMENTO_MATERIAL_221List);
executionService.CreateParameter(insertSqlCmd,"@ssPO_DOCUMENTO_MATERIAL_415",DbType.String,insertPO_DOCUMENTO_MATERIAL_415List);
executionService.CreateParameter(insertSqlCmd,"@ssPO_EJERCICIO_EM",DbType.String,insertPO_EJERCICIO_EMList);
executionService.CreateParameter(insertSqlCmd,"@ssPO_EJERCICIO_SM",DbType.String,insertPO_EJERCICIO_SMList);
executionService.CreateParameter(insertSqlCmd,"@ssPO_EJERCICIO_221",DbType.String,insertPO_EJERCICIO_221List);
executionService.CreateParameter(insertSqlCmd,"@ssPO_EJERCICIO_415",DbType.String,insertPO_EJERCICIO_415List);
executionService.CreateParameter(insertSqlCmd,"@ssPO_FOLIO_AGRUPADOS",DbType.String,insertPO_FOLIO_AGRUPADOSList);
executionService.CreateParameter(insertSqlCmd,"@ssPO_RESULTADO",DbType.String,insertPO_RESULTADOList);
executionService.CreateParameter(insertSqlCmd,"@ssCreatedBy",DbType.String,insertCreatedByList);
executionService.CreateParameter(insertSqlCmd,"@ssCreatedOn",DbType.DateTime,insertCreatedOnList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeFolioSAPData (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateFolioIdList.IsEmpty() || !updateServiceList.IsEmpty() || !updatePO_DOCUMENTO_MATERIAL_EMList.IsEmpty() || !updatePO_DOCUMENTO_MATERIAL_SMList.IsEmpty() || !updatePO_DOCUMENTO_MATERIAL_221List.IsEmpty() || !updatePO_DOCUMENTO_MATERIAL_415List.IsEmpty() || !updatePO_EJERCICIO_EMList.IsEmpty() || !updatePO_EJERCICIO_SMList.IsEmpty() || !updatePO_EJERCICIO_221List.IsEmpty() || !updatePO_EJERCICIO_415List.IsEmpty() || !updatePO_FOLIO_AGRUPADOSList.IsEmpty() || !updatePO_RESULTADOList.IsEmpty() || !updateCreatedByList.IsEmpty() || !updateCreatedOnList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssFolioId",DbType.Int64,updateFolioIdList);
executionService.CreateParameter(updateSqlCmd,"@ssService",DbType.String,updateServiceList);
executionService.CreateParameter(updateSqlCmd,"@ssPO_DOCUMENTO_MATERIAL_EM",DbType.String,updatePO_DOCUMENTO_MATERIAL_EMList);
executionService.CreateParameter(updateSqlCmd,"@ssPO_DOCUMENTO_MATERIAL_SM",DbType.String,updatePO_DOCUMENTO_MATERIAL_SMList);
executionService.CreateParameter(updateSqlCmd,"@ssPO_DOCUMENTO_MATERIAL_221",DbType.String,updatePO_DOCUMENTO_MATERIAL_221List);
executionService.CreateParameter(updateSqlCmd,"@ssPO_DOCUMENTO_MATERIAL_415",DbType.String,updatePO_DOCUMENTO_MATERIAL_415List);
executionService.CreateParameter(updateSqlCmd,"@ssPO_EJERCICIO_EM",DbType.String,updatePO_EJERCICIO_EMList);
executionService.CreateParameter(updateSqlCmd,"@ssPO_EJERCICIO_SM",DbType.String,updatePO_EJERCICIO_SMList);
executionService.CreateParameter(updateSqlCmd,"@ssPO_EJERCICIO_221",DbType.String,updatePO_EJERCICIO_221List);
executionService.CreateParameter(updateSqlCmd,"@ssPO_EJERCICIO_415",DbType.String,updatePO_EJERCICIO_415List);
executionService.CreateParameter(updateSqlCmd,"@ssPO_FOLIO_AGRUPADOS",DbType.String,updatePO_FOLIO_AGRUPADOSList);
executionService.CreateParameter(updateSqlCmd,"@ssPO_RESULTADO",DbType.String,updatePO_RESULTADOList);
executionService.CreateParameter(updateSqlCmd,"@ssCreatedBy",DbType.String,updateCreatedByList);
executionService.CreateParameter(updateSqlCmd,"@ssCreatedOn",DbType.DateTime,updateCreatedOnList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeFolioSAPData (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteFolioSAPData
/// </summary>

public static async Task DeleteFolioSAPData(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteFolioSAPData", "03162d61-5383-4bd0-bc24-41c67fa609c9.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteFolioSAPData", "03162d61-5383-4bd0-bc24-41c67fa609c9.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENFolioSAPDataEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteFolioSAPData", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllFolioSAPData
/// </summary>

public static async Task DeleteAllFolioSAPData(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllFolioSAPData", "03162d61-5383-4bd0-bc24-41c67fa609c9.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllFolioSAPData", "03162d61-5383-4bd0-bc24-41c67fa609c9.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENFolioSAPDataEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteFolioSAPData", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetFolioSAPData
/// </summary>

public static async Task<RC_7fd286c48691331601c5027580ae5af5> GetFolioSAPData(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_7fd286c48691331601c5027580ae5af5 outParamRecord = default;
outParamRecord = new RC_7fd286c48691331601c5027580ae5af5();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetFolioSAPData", "03162d61-5383-4bd0-bc24-41c67fa609c9.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetFolioSAPData", "03162d61-5383-4bd0-bc24-41c67fa609c9.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@FolioId, "folioid") ?? "folioid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@Service, "service") ?? "service", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_DOCUMENTO_MATERIAL_EM, "po_documento_material_em") ?? "po_documento_material_em", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_DOCUMENTO_MATERIAL_SM, "po_documento_material_sm") ?? "po_documento_material_sm", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_DOCUMENTO_MATERIAL_221, "po_documento_material_221") ?? "po_documento_material_221", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_DOCUMENTO_MATERIAL_415, "po_documento_material_415") ?? "po_documento_material_415", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_EJERCICIO_EM, "po_ejercicio_em") ?? "po_ejercicio_em", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_EJERCICIO_SM, "po_ejercicio_sm") ?? "po_ejercicio_sm", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_EJERCICIO_221, "po_ejercicio_221") ?? "po_ejercicio_221", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_EJERCICIO_415, "po_ejercicio_415") ?? "po_ejercicio_415", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_FOLIO_AGRUPADOS, "po_folio_agrupados") ?? "po_folio_agrupados", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_RESULTADO, "po_resultado") ?? "po_resultado", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@CreatedBy, "createdby") ?? "createdby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@CreatedOn, "createdon") ?? "createdon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
" FROM " + ENFolioSAPDataEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetFolioSAPData", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(15,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENFolioSAPDataEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetFolioSAPDataForUpdate
/// </summary>

public static async Task<RC_7fd286c48691331601c5027580ae5af5> GetFolioSAPDataForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_7fd286c48691331601c5027580ae5af5 outParamRecord = default;
outParamRecord = new RC_7fd286c48691331601c5027580ae5af5();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetFolioSAPDataForUpdate", "03162d61-5383-4bd0-bc24-41c67fa609c9.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetFolioSAPDataForUpdate", "03162d61-5383-4bd0-bc24-41c67fa609c9.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@FolioId, "folioid") ?? "folioid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@Service, "service") ?? "service", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_DOCUMENTO_MATERIAL_EM, "po_documento_material_em") ?? "po_documento_material_em", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_DOCUMENTO_MATERIAL_SM, "po_documento_material_sm") ?? "po_documento_material_sm", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_DOCUMENTO_MATERIAL_221, "po_documento_material_221") ?? "po_documento_material_221", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_DOCUMENTO_MATERIAL_415, "po_documento_material_415") ?? "po_documento_material_415", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_EJERCICIO_EM, "po_ejercicio_em") ?? "po_ejercicio_em", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_EJERCICIO_SM, "po_ejercicio_sm") ?? "po_ejercicio_sm", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_EJERCICIO_221, "po_ejercicio_221") ?? "po_ejercicio_221", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_EJERCICIO_415, "po_ejercicio_415") ?? "po_ejercicio_415", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_FOLIO_AGRUPADOS, "po_folio_agrupados") ?? "po_folio_agrupados", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_RESULTADO, "po_resultado") ?? "po_resultado", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@CreatedBy, "createdby") ?? "createdby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@CreatedOn, "createdon") ?? "createdon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
" FROM " + ENFolioSAPDataEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetFolioSAPDataForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(15,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENFolioSAPDataEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateFolioSAPData
/// </summary>

public static async Task UpdateFolioSAPData(IRequestContext requestContext,BitArray usedFields,RC_7fd286c48691331601c5027580ae5af5 inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateFolioSAPData", "03162d61-5383-4bd0-bc24-41c67fa609c9.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateFolioSAPData", "03162d61-5383-4bd0-bc24-41c67fa609c9.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord ssENFolioSAPData = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(15,true);
}
string updateSet = "UPDATE " + ENFolioSAPDataEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@FolioId, "folioid") ?? "folioid") + " = @ssFolioId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@Service, "service") ?? "service") + " = @ssService"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_DOCUMENTO_MATERIAL_EM, "po_documento_material_em") ?? "po_documento_material_em") + " = @ssPO_DOCUMENTO_MATERIAL_EM"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_DOCUMENTO_MATERIAL_SM, "po_documento_material_sm") ?? "po_documento_material_sm") + " = @ssPO_DOCUMENTO_MATERIAL_SM"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_DOCUMENTO_MATERIAL_221, "po_documento_material_221") ?? "po_documento_material_221") + " = @ssPO_DOCUMENTO_MATERIAL_221"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_DOCUMENTO_MATERIAL_415, "po_documento_material_415") ?? "po_documento_material_415") + " = @ssPO_DOCUMENTO_MATERIAL_415"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_EJERCICIO_EM, "po_ejercicio_em") ?? "po_ejercicio_em") + " = @ssPO_EJERCICIO_EM"): parameters);
parameters = (usedFields[8] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_EJERCICIO_SM, "po_ejercicio_sm") ?? "po_ejercicio_sm") + " = @ssPO_EJERCICIO_SM"): parameters);
parameters = (usedFields[9] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_EJERCICIO_221, "po_ejercicio_221") ?? "po_ejercicio_221") + " = @ssPO_EJERCICIO_221"): parameters);
parameters = (usedFields[10] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_EJERCICIO_415, "po_ejercicio_415") ?? "po_ejercicio_415") + " = @ssPO_EJERCICIO_415"): parameters);
parameters = (usedFields[11] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_FOLIO_AGRUPADOS, "po_folio_agrupados") ?? "po_folio_agrupados") + " = @ssPO_FOLIO_AGRUPADOS"): parameters);
parameters = (usedFields[12] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@PO_RESULTADO, "po_resultado") ?? "po_resultado") + " = @ssPO_RESULTADO"): parameters);
parameters = (usedFields[13] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = @ssCreatedBy"): parameters);
parameters = (usedFields[14] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = @ssCreatedOn"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENFolioSAPData_ssId_FolioSAPData";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioSAPData, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioSAPDataAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENFolioSAPData.ssFolioId==0L)) {
sqlCmd.CreateParameter("@ssFolioId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssFolioId", DbType.Int64, ssENFolioSAPData.ssFolioId);

}
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssService", DbType.String, ssENFolioSAPData.ssService);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssPO_DOCUMENTO_MATERIAL_EM", DbType.String, ssENFolioSAPData.ssPO_DOCUMENTO_MATERIAL_EM);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssPO_DOCUMENTO_MATERIAL_SM", DbType.String, ssENFolioSAPData.ssPO_DOCUMENTO_MATERIAL_SM);
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssPO_DOCUMENTO_MATERIAL_221", DbType.String, ssENFolioSAPData.ssPO_DOCUMENTO_MATERIAL_221);
}
if(usedFields[6]) {
sqlCmd.CreateParameter("@ssPO_DOCUMENTO_MATERIAL_415", DbType.String, ssENFolioSAPData.ssPO_DOCUMENTO_MATERIAL_415);
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssPO_EJERCICIO_EM", DbType.String, ssENFolioSAPData.ssPO_EJERCICIO_EM);
}
if(usedFields[8]) {
sqlCmd.CreateParameter("@ssPO_EJERCICIO_SM", DbType.String, ssENFolioSAPData.ssPO_EJERCICIO_SM);
}
if(usedFields[9]) {
sqlCmd.CreateParameter("@ssPO_EJERCICIO_221", DbType.String, ssENFolioSAPData.ssPO_EJERCICIO_221);
}
if(usedFields[10]) {
sqlCmd.CreateParameter("@ssPO_EJERCICIO_415", DbType.String, ssENFolioSAPData.ssPO_EJERCICIO_415);
}
if(usedFields[11]) {
sqlCmd.CreateParameter("@ssPO_FOLIO_AGRUPADOS", DbType.String, ssENFolioSAPData.ssPO_FOLIO_AGRUPADOS);
}
if(usedFields[12]) {
sqlCmd.CreateParameter("@ssPO_RESULTADO", DbType.String, ssENFolioSAPData.ssPO_RESULTADO);
}
if(usedFields[13]) {
if ((ssENFolioSAPData.ssCreatedBy=="")) {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENFolioSAPData.ssCreatedBy);

}
}
if(usedFields[14]) {
sqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENFolioSAPData.ssCreatedOn);
}
sqlCmd.CreateParameter("@idparam_ssENFolioSAPData_ssId_FolioSAPData", DbType.Int64, ssENFolioSAPData.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateFolioSAPData", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("FolioSAPData", ssENFolioSAPData.ssId.ToString()); }}
}
return;
}

}
}
