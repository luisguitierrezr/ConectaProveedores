using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateOrdersImportRequest
/// </summary>

public static async Task<long> CreateOrdersImportRequest(IRequestContext requestContext,RC_2407b5abb2cbfeaeaa8da6cdea4ccf12 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrdersImportRequest", "2040b973-c22e-4d96-9834-1cf3249afcae.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrdersImportRequest", "2040b973-c22e-4d96-9834-1cf3249afcae.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_8c3668a93870461b8ea1216c2848f298EntityRecord ssENOrdersImportRequest = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENOrdersImportRequestEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@Origin, "origin") ?? "origin") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@ImportedData, "importeddata") ?? "importeddata") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@OrderMainId, "ordermainid") ?? "ordermainid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@Status, "status") ?? "status") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@LastRowNumberRead, "lastrownumberread") ?? "lastrownumberread") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@RowsWithError, "rowswitherror") ?? "rowswitherror") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon") + "" +
" ) VALUES (" +
" @ssOrigin" +
", @ssImportedData" +
", @ssOrderMainId" +
", @ssStatus" +
", @ssLastRowNumberRead" +
", @ssRowsWithError" +
", @ssCreatedBy" +
", @ssCreatedOn" +
", @ssUpdatedOn" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssOrigin", DbType.String, ssENOrdersImportRequest.ssOrigin);
insertSqlCmd.CreateParameter("@ssImportedData", DbType.Binary, ssENOrdersImportRequest.ssImportedData);
if ((ssENOrdersImportRequest.ssOrderMainId==0L)) {
insertSqlCmd.CreateParameter("@ssOrderMainId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssOrderMainId", DbType.Int64, ssENOrdersImportRequest.ssOrderMainId);

}
insertSqlCmd.CreateParameter("@ssStatus", DbType.Int32, ssENOrdersImportRequest.ssStatus);
insertSqlCmd.CreateParameter("@ssLastRowNumberRead", DbType.Int32, ssENOrdersImportRequest.ssLastRowNumberRead);
insertSqlCmd.CreateParameter("@ssRowsWithError", DbType.String, ssENOrdersImportRequest.ssRowsWithError);
if ((ssENOrdersImportRequest.ssCreatedBy=="")) {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENOrdersImportRequest.ssCreatedBy);

}
insertSqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENOrdersImportRequest.ssCreatedOn);
insertSqlCmd.CreateParameter("@ssUpdatedOn", DbType.DateTime, ssENOrdersImportRequest.ssUpdatedOn);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrdersImportRequest", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateOrdersImportRequest
/// </summary>

public static async Task<long> CreateOrUpdateOrdersImportRequest(IRequestContext requestContext,BitArray usedFields,RC_2407b5abb2cbfeaeaa8da6cdea4ccf12 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateOrdersImportRequest", "2040b973-c22e-4d96-9834-1cf3249afcae.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateOrdersImportRequest", "2040b973-c22e-4d96-9834-1cf3249afcae.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_8c3668a93870461b8ea1216c2848f298EntityRecord ssENOrdersImportRequest = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(10,true);
}
string updateSet = "UPDATE " + ENOrdersImportRequestEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@Origin, "origin") ?? "origin") + " = @ssOrigin"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@ImportedData, "importeddata") ?? "importeddata") + " = @ssImportedData"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@OrderMainId, "ordermainid") ?? "ordermainid") + " = @ssOrderMainId"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@Status, "status") ?? "status") + " = @ssStatus"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@LastRowNumberRead, "lastrownumberread") ?? "lastrownumberread") + " = @ssLastRowNumberRead"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@RowsWithError, "rowswitherror") ?? "rowswitherror") + " = @ssRowsWithError"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = @ssCreatedBy"): parameters);
parameters = (usedFields[8] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = @ssCreatedOn"): parameters);
parameters = (usedFields[9] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon") + " = @ssUpdatedOn"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENOrdersImportRequest_ssId_OrdersImportRequest";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@LastRowNumberRead, "lastrownumberread") ?? "lastrownumberread") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@LastRowNumberRead, "lastrownumberread") ?? "lastrownumberread") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssOrigin", DbType.String, ssENOrdersImportRequest.ssOrigin);
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssImportedData", DbType.Binary, ssENOrdersImportRequest.ssImportedData);
}
if(usedFields[3]) {
if ((ssENOrdersImportRequest.ssOrderMainId==0L)) {
sqlCmd.CreateParameter("@ssOrderMainId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssOrderMainId", DbType.Int64, ssENOrdersImportRequest.ssOrderMainId);

}
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssStatus", DbType.Int32, ssENOrdersImportRequest.ssStatus);
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssLastRowNumberRead", DbType.Int32, ssENOrdersImportRequest.ssLastRowNumberRead);
}
if(usedFields[6]) {
sqlCmd.CreateParameter("@ssRowsWithError", DbType.String, ssENOrdersImportRequest.ssRowsWithError);
}
if(usedFields[7]) {
if ((ssENOrdersImportRequest.ssCreatedBy=="")) {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENOrdersImportRequest.ssCreatedBy);

}
}
if(usedFields[8]) {
sqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENOrdersImportRequest.ssCreatedOn);
}
if(usedFields[9]) {
sqlCmd.CreateParameter("@ssUpdatedOn", DbType.DateTime, ssENOrdersImportRequest.ssUpdatedOn);
}
sqlCmd.CreateParameter("@idparam_ssENOrdersImportRequest_ssId_OrdersImportRequest", DbType.Int64, ssENOrdersImportRequest.ssId);
int counter = 0;
if(ssENOrdersImportRequest.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateOrdersImportRequest (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENOrdersImportRequestEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@Origin, "origin") ?? "origin") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@ImportedData, "importeddata") ?? "importeddata") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@OrderMainId, "ordermainid") ?? "ordermainid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@Status, "status") ?? "status") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@LastRowNumberRead, "lastrownumberread") ?? "lastrownumberread") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@RowsWithError, "rowswitherror") ?? "rowswitherror") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon") + "" +
" ) VALUES (" +
" @ssOrigin" +
", @ssImportedData" +
", @ssOrderMainId" +
", @ssStatus" +
", @ssLastRowNumberRead" +
", @ssRowsWithError" +
", @ssCreatedBy" +
", @ssCreatedOn" +
", @ssUpdatedOn" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssOrigin", DbType.String, ssENOrdersImportRequest.ssOrigin);
insertSqlCmd.CreateParameter("@ssImportedData", DbType.Binary, ssENOrdersImportRequest.ssImportedData);
if ((ssENOrdersImportRequest.ssOrderMainId==0L)) {
insertSqlCmd.CreateParameter("@ssOrderMainId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssOrderMainId", DbType.Int64, ssENOrdersImportRequest.ssOrderMainId);

}
insertSqlCmd.CreateParameter("@ssStatus", DbType.Int32, ssENOrdersImportRequest.ssStatus);
insertSqlCmd.CreateParameter("@ssLastRowNumberRead", DbType.Int32, ssENOrdersImportRequest.ssLastRowNumberRead);
insertSqlCmd.CreateParameter("@ssRowsWithError", DbType.String, ssENOrdersImportRequest.ssRowsWithError);
if ((ssENOrdersImportRequest.ssCreatedBy=="")) {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENOrdersImportRequest.ssCreatedBy);

}
insertSqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENOrdersImportRequest.ssCreatedOn);
insertSqlCmd.CreateParameter("@ssUpdatedOn", DbType.DateTime, ssENOrdersImportRequest.ssUpdatedOn);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateOrdersImportRequest", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENOrdersImportRequest.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeOrdersImportRequest
/// </summary>

public static async Task CreateOrUpdateSomeOrdersImportRequest(IRequestContext requestContext,RL_40391f6554740b0683ce6790af83e1c0 inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeOrdersImportRequest", "2040b973-c22e-4d96-9834-1cf3249afcae.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeOrdersImportRequest", "2040b973-c22e-4d96-9834-1cf3249afcae.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENOrdersImportRequestEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@Origin, "origin") ?? "origin") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@ImportedData, "importeddata") ?? "importeddata") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@OrderMainId, "ordermainid") ?? "ordermainid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@Status, "status") ?? "status") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@LastRowNumberRead, "lastrownumberread") ?? "lastrownumberread") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@RowsWithError, "rowswitherror") ?? "rowswitherror") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon") + ") VALUES ( unnest(@ssOrigin),  unnest(@ssImportedData),  unnest(@ssOrderMainId),  unnest(@ssStatus),  unnest(@ssLastRowNumberRead),  unnest(@ssRowsWithError),  unnest(@ssCreatedBy),  unnest(@ssCreatedOn),  unnest(@ssUpdatedOn)) ";
insertSql += "";

string updateSql = "UPDATE " + entityTableName + " SET " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@Origin, "origin") ?? "origin") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@Origin, "origin") ?? "origin") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@ImportedData, "importeddata") ?? "importeddata") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@ImportedData, "importeddata") ?? "importeddata") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@OrderMainId, "ordermainid") ?? "ordermainid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@OrderMainId, "ordermainid") ?? "ordermainid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@Status, "status") ?? "status") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@Status, "status") ?? "status") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@LastRowNumberRead, "lastrownumberread") ?? "lastrownumberread") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@LastRowNumberRead, "lastrownumberread") ?? "lastrownumberread") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@RowsWithError, "rowswitherror") ?? "rowswitherror") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@RowsWithError, "rowswitherror") ?? "rowswitherror") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon") + " from ( select  unnest(@ssId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@Id, "id") ?? "id") + ",  unnest(@ssOrigin) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@Origin, "origin") ?? "origin") + ",  unnest(@ssImportedData) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@ImportedData, "importeddata") ?? "importeddata") + ",  unnest(@ssOrderMainId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@OrderMainId, "ordermainid") ?? "ordermainid") + ",  unnest(@ssStatus) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@Status, "status") ?? "status") + ",  unnest(@ssLastRowNumberRead) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@LastRowNumberRead, "lastrownumberread") ?? "lastrownumberread") + ",  unnest(@ssRowsWithError) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@RowsWithError, "rowswitherror") ?? "rowswitherror") + ",  unnest(@ssCreatedBy) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ",  unnest(@ssCreatedOn) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + ",  unnest(@ssUpdatedOn) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon") + " ) as updateTable where " + entityTableName + "." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@Id, "id") ?? "id") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@Id, "id") ?? "id") + " ";
updateSql += "";

List<string> insertOriginList = new List<string>();
List<byte[]> insertImportedDataList = new List<byte[]>();
List<object> insertOrderMainIdList = new List<object>();
List<object> insertStatusList = new List<object>();
List<int> insertLastRowNumberReadList = new List<int>();
List<string> insertRowsWithErrorList = new List<string>();
List<object> insertCreatedByList = new List<object>();
List<DateTime> insertCreatedOnList = new List<DateTime>();
List<DateTime> insertUpdatedOnList = new List<DateTime>();

List<long> updateIdList = new List<long>();
List<string> updateOriginList = new List<string>();
List<byte[]> updateImportedDataList = new List<byte[]>();
List<object> updateOrderMainIdList = new List<object>();
List<object> updateStatusList = new List<object>();
List<int> updateLastRowNumberReadList = new List<int>();
List<string> updateRowsWithErrorList = new List<string>();
List<object> updateCreatedByList = new List<object>();
List<DateTime> updateCreatedOnList = new List<DateTime>();
List<DateTime> updateUpdatedOnList = new List<DateTime>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_2407b5abb2cbfeaeaa8da6cdea4ccf12)inParamSourceList.Current).ssENOrdersImportRequest;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
updateOriginList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssOrigin));
updateImportedDataList.Add((byte[])executionService.TransformRuntimeToDatabaseValue(DbType.Binary, record.ssImportedData));
if ((record.ssOrderMainId==0L)) {
updateOrderMainIdList.Add(null);
} else {
updateOrderMainIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssOrderMainId));
}
updateStatusList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssStatus));
updateLastRowNumberReadList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssLastRowNumberRead));
updateRowsWithErrorList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssRowsWithError));
if ((record.ssCreatedBy=="")) {
updateCreatedByList.Add(null);
} else {
updateCreatedByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCreatedBy));
}
updateCreatedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssCreatedOn));
updateUpdatedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssUpdatedOn));
} else {
insertOriginList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssOrigin));
insertImportedDataList.Add((byte[])executionService.TransformRuntimeToDatabaseValue(DbType.Binary, record.ssImportedData));
if ((record.ssOrderMainId==0L)) {
insertOrderMainIdList.Add(null);
} else {
insertOrderMainIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssOrderMainId));
}
insertStatusList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssStatus));
insertLastRowNumberReadList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssLastRowNumberRead));
insertRowsWithErrorList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssRowsWithError));
if ((record.ssCreatedBy=="")) {
insertCreatedByList.Add(null);
} else {
insertCreatedByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCreatedBy));
}
insertCreatedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssCreatedOn));
insertUpdatedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssUpdatedOn));
}
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertOriginList.IsEmpty() || !insertImportedDataList.IsEmpty() || !insertOrderMainIdList.IsEmpty() || !insertStatusList.IsEmpty() || !insertLastRowNumberReadList.IsEmpty() || !insertRowsWithErrorList.IsEmpty() || !insertCreatedByList.IsEmpty() || !insertCreatedOnList.IsEmpty() || !insertUpdatedOnList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssOrigin",DbType.String,insertOriginList);
executionService.CreateParameter(insertSqlCmd,"@ssImportedData",DbType.Binary,insertImportedDataList);
executionService.CreateParameter(insertSqlCmd,"@ssOrderMainId",DbType.Int64,insertOrderMainIdList);
executionService.CreateParameter(insertSqlCmd,"@ssStatus",DbType.Int32,insertStatusList);
executionService.CreateParameter(insertSqlCmd,"@ssLastRowNumberRead",DbType.Int32,insertLastRowNumberReadList);
executionService.CreateParameter(insertSqlCmd,"@ssRowsWithError",DbType.String,insertRowsWithErrorList);
executionService.CreateParameter(insertSqlCmd,"@ssCreatedBy",DbType.String,insertCreatedByList);
executionService.CreateParameter(insertSqlCmd,"@ssCreatedOn",DbType.DateTime,insertCreatedOnList);
executionService.CreateParameter(insertSqlCmd,"@ssUpdatedOn",DbType.DateTime,insertUpdatedOnList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeOrdersImportRequest (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateOriginList.IsEmpty() || !updateImportedDataList.IsEmpty() || !updateOrderMainIdList.IsEmpty() || !updateStatusList.IsEmpty() || !updateLastRowNumberReadList.IsEmpty() || !updateRowsWithErrorList.IsEmpty() || !updateCreatedByList.IsEmpty() || !updateCreatedOnList.IsEmpty() || !updateUpdatedOnList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssOrigin",DbType.String,updateOriginList);
executionService.CreateParameter(updateSqlCmd,"@ssImportedData",DbType.Binary,updateImportedDataList);
executionService.CreateParameter(updateSqlCmd,"@ssOrderMainId",DbType.Int64,updateOrderMainIdList);
executionService.CreateParameter(updateSqlCmd,"@ssStatus",DbType.Int32,updateStatusList);
executionService.CreateParameter(updateSqlCmd,"@ssLastRowNumberRead",DbType.Int32,updateLastRowNumberReadList);
executionService.CreateParameter(updateSqlCmd,"@ssRowsWithError",DbType.String,updateRowsWithErrorList);
executionService.CreateParameter(updateSqlCmd,"@ssCreatedBy",DbType.String,updateCreatedByList);
executionService.CreateParameter(updateSqlCmd,"@ssCreatedOn",DbType.DateTime,updateCreatedOnList);
executionService.CreateParameter(updateSqlCmd,"@ssUpdatedOn",DbType.DateTime,updateUpdatedOnList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeOrdersImportRequest (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteOrdersImportRequest
/// </summary>

public static async Task DeleteOrdersImportRequest(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteOrdersImportRequest", "2040b973-c22e-4d96-9834-1cf3249afcae.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteOrdersImportRequest", "2040b973-c22e-4d96-9834-1cf3249afcae.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENOrdersImportRequestEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteOrdersImportRequest", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllOrdersImportRequest
/// </summary>

public static async Task DeleteAllOrdersImportRequest(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllOrdersImportRequest", "2040b973-c22e-4d96-9834-1cf3249afcae.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllOrdersImportRequest", "2040b973-c22e-4d96-9834-1cf3249afcae.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENOrdersImportRequestEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteOrdersImportRequest", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetOrdersImportRequest
/// </summary>

public static async Task<RC_2407b5abb2cbfeaeaa8da6cdea4ccf12> GetOrdersImportRequest(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_2407b5abb2cbfeaeaa8da6cdea4ccf12 outParamRecord = default;
outParamRecord = new RC_2407b5abb2cbfeaeaa8da6cdea4ccf12();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetOrdersImportRequest", "2040b973-c22e-4d96-9834-1cf3249afcae.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetOrdersImportRequest", "2040b973-c22e-4d96-9834-1cf3249afcae.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@Origin, "origin") ?? "origin", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@ImportedData, "importeddata") ?? "importeddata", OutSystems.HubEdition.Extensibility.Data.DBDataType.BINARY_DATA) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@OrderMainId, "ordermainid") ?? "ordermainid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@Status, "status") ?? "status", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@LastRowNumberRead, "lastrownumberread") ?? "lastrownumberread", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@RowsWithError, "rowswitherror") ?? "rowswitherror", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@CreatedBy, "createdby") ?? "createdby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@CreatedOn, "createdon") ?? "createdon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
" FROM " + ENOrdersImportRequestEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetOrdersImportRequest", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(10,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENOrdersImportRequestEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetOrdersImportRequestForUpdate
/// </summary>

public static async Task<RC_2407b5abb2cbfeaeaa8da6cdea4ccf12> GetOrdersImportRequestForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_2407b5abb2cbfeaeaa8da6cdea4ccf12 outParamRecord = default;
outParamRecord = new RC_2407b5abb2cbfeaeaa8da6cdea4ccf12();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetOrdersImportRequestForUpdate", "2040b973-c22e-4d96-9834-1cf3249afcae.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetOrdersImportRequestForUpdate", "2040b973-c22e-4d96-9834-1cf3249afcae.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@Origin, "origin") ?? "origin", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@ImportedData, "importeddata") ?? "importeddata", OutSystems.HubEdition.Extensibility.Data.DBDataType.BINARY_DATA) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@OrderMainId, "ordermainid") ?? "ordermainid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@Status, "status") ?? "status", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@LastRowNumberRead, "lastrownumberread") ?? "lastrownumberread", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@RowsWithError, "rowswitherror") ?? "rowswitherror", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@CreatedBy, "createdby") ?? "createdby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@CreatedOn, "createdon") ?? "createdon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
" FROM " + ENOrdersImportRequestEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetOrdersImportRequestForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(10,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENOrdersImportRequestEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateOrdersImportRequest
/// </summary>

public static async Task UpdateOrdersImportRequest(IRequestContext requestContext,BitArray usedFields,RC_2407b5abb2cbfeaeaa8da6cdea4ccf12 inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateOrdersImportRequest", "2040b973-c22e-4d96-9834-1cf3249afcae.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateOrdersImportRequest", "2040b973-c22e-4d96-9834-1cf3249afcae.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_8c3668a93870461b8ea1216c2848f298EntityRecord ssENOrdersImportRequest = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(10,true);
}
string updateSet = "UPDATE " + ENOrdersImportRequestEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@Origin, "origin") ?? "origin") + " = @ssOrigin"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@ImportedData, "importeddata") ?? "importeddata") + " = @ssImportedData"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@OrderMainId, "ordermainid") ?? "ordermainid") + " = @ssOrderMainId"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@Status, "status") ?? "status") + " = @ssStatus"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@LastRowNumberRead, "lastrownumberread") ?? "lastrownumberread") + " = @ssLastRowNumberRead"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@RowsWithError, "rowswitherror") ?? "rowswitherror") + " = @ssRowsWithError"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = @ssCreatedBy"): parameters);
parameters = (usedFields[8] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = @ssCreatedOn"): parameters);
parameters = (usedFields[9] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon") + " = @ssUpdatedOn"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENOrdersImportRequest_ssId_OrdersImportRequest";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@LastRowNumberRead, "lastrownumberread") ?? "lastrownumberread") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrdersImportRequest, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrdersImportRequestAttributeKeys.@LastRowNumberRead, "lastrownumberread") ?? "lastrownumberread") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssOrigin", DbType.String, ssENOrdersImportRequest.ssOrigin);
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssImportedData", DbType.Binary, ssENOrdersImportRequest.ssImportedData);
}
if(usedFields[3]) {
if ((ssENOrdersImportRequest.ssOrderMainId==0L)) {
sqlCmd.CreateParameter("@ssOrderMainId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssOrderMainId", DbType.Int64, ssENOrdersImportRequest.ssOrderMainId);

}
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssStatus", DbType.Int32, ssENOrdersImportRequest.ssStatus);
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssLastRowNumberRead", DbType.Int32, ssENOrdersImportRequest.ssLastRowNumberRead);
}
if(usedFields[6]) {
sqlCmd.CreateParameter("@ssRowsWithError", DbType.String, ssENOrdersImportRequest.ssRowsWithError);
}
if(usedFields[7]) {
if ((ssENOrdersImportRequest.ssCreatedBy=="")) {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENOrdersImportRequest.ssCreatedBy);

}
}
if(usedFields[8]) {
sqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENOrdersImportRequest.ssCreatedOn);
}
if(usedFields[9]) {
sqlCmd.CreateParameter("@ssUpdatedOn", DbType.DateTime, ssENOrdersImportRequest.ssUpdatedOn);
}
sqlCmd.CreateParameter("@idparam_ssENOrdersImportRequest_ssId_OrdersImportRequest", DbType.Int64, ssENOrdersImportRequest.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateOrdersImportRequest", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("OrdersImportRequest", ssENOrdersImportRequest.ssId.ToString()); }}
}
return;
}

}
}
