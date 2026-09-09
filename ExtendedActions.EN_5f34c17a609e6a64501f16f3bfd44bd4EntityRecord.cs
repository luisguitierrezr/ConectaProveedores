using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateLogsAccounting
/// </summary>

public static async Task<long> CreateLogsAccounting(IRequestContext requestContext,RC_404aa878a81887880a35de683904d643 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateLogsAccounting", "35623c7c-e685-4bb8-a2aa-63af70401874.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateLogsAccounting", "35623c7c-e685-4bb8-a2aa-63af70401874.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord ssENLogsAccounting = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENLogsAccountingEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@Title, "title") ?? "title") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@AssociatedId, "associatedid") ?? "associatedid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@Description, "description") ?? "description") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@LogsAccountingSubjectId, "logsaccountingsubjectid") ?? "logsaccountingsubjectid") + "" +
" ) VALUES (" +
" @ssTitle" +
", @ssAssociatedId" +
", @ssDescription" +
", @ssCreatedBy" +
", @ssCreatedOn" +
", @ssLogsAccountingSubjectId" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssTitle", DbType.String, ssENLogsAccounting.ssTitle);
insertSqlCmd.CreateParameter("@ssAssociatedId", DbType.String, ssENLogsAccounting.ssAssociatedId);
insertSqlCmd.CreateParameter("@ssDescription", DbType.String, ssENLogsAccounting.ssDescription);
if ((ssENLogsAccounting.ssCreatedBy=="")) {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENLogsAccounting.ssCreatedBy);

}
insertSqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENLogsAccounting.ssCreatedOn);
if ((ssENLogsAccounting.ssLogsAccountingSubjectId==0)) {
insertSqlCmd.CreateParameter("@ssLogsAccountingSubjectId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssLogsAccountingSubjectId", DbType.Int32, ssENLogsAccounting.ssLogsAccountingSubjectId);

}
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateLogsAccounting", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateLogsAccounting
/// </summary>

public static async Task<long> CreateOrUpdateLogsAccounting(IRequestContext requestContext,BitArray usedFields,RC_404aa878a81887880a35de683904d643 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateLogsAccounting", "35623c7c-e685-4bb8-a2aa-63af70401874.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateLogsAccounting", "35623c7c-e685-4bb8-a2aa-63af70401874.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord ssENLogsAccounting = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(7,true);
}
string updateSet = "UPDATE " + ENLogsAccountingEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@Title, "title") ?? "title") + " = @ssTitle"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@AssociatedId, "associatedid") ?? "associatedid") + " = @ssAssociatedId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@Description, "description") ?? "description") + " = @ssDescription"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = @ssCreatedBy"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = @ssCreatedOn"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@LogsAccountingSubjectId, "logsaccountingsubjectid") ?? "logsaccountingsubjectid") + " = @ssLogsAccountingSubjectId"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENLogsAccounting_ssId_LogsAccounting";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssTitle", DbType.String, ssENLogsAccounting.ssTitle);
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssAssociatedId", DbType.String, ssENLogsAccounting.ssAssociatedId);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssDescription", DbType.String, ssENLogsAccounting.ssDescription);
}
if(usedFields[4]) {
if ((ssENLogsAccounting.ssCreatedBy=="")) {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENLogsAccounting.ssCreatedBy);

}
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENLogsAccounting.ssCreatedOn);
}
if(usedFields[6]) {
if ((ssENLogsAccounting.ssLogsAccountingSubjectId==0)) {
sqlCmd.CreateParameter("@ssLogsAccountingSubjectId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssLogsAccountingSubjectId", DbType.Int32, ssENLogsAccounting.ssLogsAccountingSubjectId);

}
}
sqlCmd.CreateParameter("@idparam_ssENLogsAccounting_ssId_LogsAccounting", DbType.Int64, ssENLogsAccounting.ssId);
int counter = 0;
if(ssENLogsAccounting.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateLogsAccounting (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENLogsAccountingEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@Title, "title") ?? "title") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@AssociatedId, "associatedid") ?? "associatedid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@Description, "description") ?? "description") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@LogsAccountingSubjectId, "logsaccountingsubjectid") ?? "logsaccountingsubjectid") + "" +
" ) VALUES (" +
" @ssTitle" +
", @ssAssociatedId" +
", @ssDescription" +
", @ssCreatedBy" +
", @ssCreatedOn" +
", @ssLogsAccountingSubjectId" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssTitle", DbType.String, ssENLogsAccounting.ssTitle);
insertSqlCmd.CreateParameter("@ssAssociatedId", DbType.String, ssENLogsAccounting.ssAssociatedId);
insertSqlCmd.CreateParameter("@ssDescription", DbType.String, ssENLogsAccounting.ssDescription);
if ((ssENLogsAccounting.ssCreatedBy=="")) {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENLogsAccounting.ssCreatedBy);

}
insertSqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENLogsAccounting.ssCreatedOn);
if ((ssENLogsAccounting.ssLogsAccountingSubjectId==0)) {
insertSqlCmd.CreateParameter("@ssLogsAccountingSubjectId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssLogsAccountingSubjectId", DbType.Int32, ssENLogsAccounting.ssLogsAccountingSubjectId);

}
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateLogsAccounting", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENLogsAccounting.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeLogsAccounting
/// </summary>

public static async Task CreateOrUpdateSomeLogsAccounting(IRequestContext requestContext,RL_cc0d70d0b18881d11cf5321352207bb5 inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeLogsAccounting", "35623c7c-e685-4bb8-a2aa-63af70401874.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeLogsAccounting", "35623c7c-e685-4bb8-a2aa-63af70401874.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENLogsAccountingEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@Title, "title") ?? "title") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@AssociatedId, "associatedid") ?? "associatedid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@Description, "description") ?? "description") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@LogsAccountingSubjectId, "logsaccountingsubjectid") ?? "logsaccountingsubjectid") + ") VALUES ( unnest(@ssTitle),  unnest(@ssAssociatedId),  unnest(@ssDescription),  unnest(@ssCreatedBy),  unnest(@ssCreatedOn),  unnest(@ssLogsAccountingSubjectId)) ";
insertSql += "";

string updateSql = "UPDATE " + entityTableName + " SET " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@Title, "title") ?? "title") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@Title, "title") ?? "title") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@AssociatedId, "associatedid") ?? "associatedid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@AssociatedId, "associatedid") ?? "associatedid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@Description, "description") ?? "description") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@Description, "description") ?? "description") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@LogsAccountingSubjectId, "logsaccountingsubjectid") ?? "logsaccountingsubjectid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@LogsAccountingSubjectId, "logsaccountingsubjectid") ?? "logsaccountingsubjectid") + " from ( select  unnest(@ssId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@Id, "id") ?? "id") + ",  unnest(@ssTitle) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@Title, "title") ?? "title") + ",  unnest(@ssAssociatedId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@AssociatedId, "associatedid") ?? "associatedid") + ",  unnest(@ssDescription) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@Description, "description") ?? "description") + ",  unnest(@ssCreatedBy) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ",  unnest(@ssCreatedOn) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + ",  unnest(@ssLogsAccountingSubjectId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@LogsAccountingSubjectId, "logsaccountingsubjectid") ?? "logsaccountingsubjectid") + " ) as updateTable where " + entityTableName + "." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@Id, "id") ?? "id") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@Id, "id") ?? "id") + " ";
updateSql += "";

List<string> insertTitleList = new List<string>();
List<string> insertAssociatedIdList = new List<string>();
List<string> insertDescriptionList = new List<string>();
List<object> insertCreatedByList = new List<object>();
List<DateTime> insertCreatedOnList = new List<DateTime>();
List<object> insertLogsAccountingSubjectIdList = new List<object>();

List<long> updateIdList = new List<long>();
List<string> updateTitleList = new List<string>();
List<string> updateAssociatedIdList = new List<string>();
List<string> updateDescriptionList = new List<string>();
List<object> updateCreatedByList = new List<object>();
List<DateTime> updateCreatedOnList = new List<DateTime>();
List<object> updateLogsAccountingSubjectIdList = new List<object>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_404aa878a81887880a35de683904d643)inParamSourceList.Current).ssENLogsAccounting;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
updateTitleList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssTitle));
updateAssociatedIdList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssAssociatedId));
updateDescriptionList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssDescription));
if ((record.ssCreatedBy=="")) {
updateCreatedByList.Add(null);
} else {
updateCreatedByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCreatedBy));
}
updateCreatedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssCreatedOn));
if ((record.ssLogsAccountingSubjectId==0)) {
updateLogsAccountingSubjectIdList.Add(null);
} else {
updateLogsAccountingSubjectIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssLogsAccountingSubjectId));
}
} else {
insertTitleList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssTitle));
insertAssociatedIdList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssAssociatedId));
insertDescriptionList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssDescription));
if ((record.ssCreatedBy=="")) {
insertCreatedByList.Add(null);
} else {
insertCreatedByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCreatedBy));
}
insertCreatedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssCreatedOn));
if ((record.ssLogsAccountingSubjectId==0)) {
insertLogsAccountingSubjectIdList.Add(null);
} else {
insertLogsAccountingSubjectIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssLogsAccountingSubjectId));
}
}
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertTitleList.IsEmpty() || !insertAssociatedIdList.IsEmpty() || !insertDescriptionList.IsEmpty() || !insertCreatedByList.IsEmpty() || !insertCreatedOnList.IsEmpty() || !insertLogsAccountingSubjectIdList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssTitle",DbType.String,insertTitleList);
executionService.CreateParameter(insertSqlCmd,"@ssAssociatedId",DbType.String,insertAssociatedIdList);
executionService.CreateParameter(insertSqlCmd,"@ssDescription",DbType.String,insertDescriptionList);
executionService.CreateParameter(insertSqlCmd,"@ssCreatedBy",DbType.String,insertCreatedByList);
executionService.CreateParameter(insertSqlCmd,"@ssCreatedOn",DbType.DateTime,insertCreatedOnList);
executionService.CreateParameter(insertSqlCmd,"@ssLogsAccountingSubjectId",DbType.Int32,insertLogsAccountingSubjectIdList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeLogsAccounting (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateTitleList.IsEmpty() || !updateAssociatedIdList.IsEmpty() || !updateDescriptionList.IsEmpty() || !updateCreatedByList.IsEmpty() || !updateCreatedOnList.IsEmpty() || !updateLogsAccountingSubjectIdList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssTitle",DbType.String,updateTitleList);
executionService.CreateParameter(updateSqlCmd,"@ssAssociatedId",DbType.String,updateAssociatedIdList);
executionService.CreateParameter(updateSqlCmd,"@ssDescription",DbType.String,updateDescriptionList);
executionService.CreateParameter(updateSqlCmd,"@ssCreatedBy",DbType.String,updateCreatedByList);
executionService.CreateParameter(updateSqlCmd,"@ssCreatedOn",DbType.DateTime,updateCreatedOnList);
executionService.CreateParameter(updateSqlCmd,"@ssLogsAccountingSubjectId",DbType.Int32,updateLogsAccountingSubjectIdList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeLogsAccounting (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteLogsAccounting
/// </summary>

public static async Task DeleteLogsAccounting(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteLogsAccounting", "35623c7c-e685-4bb8-a2aa-63af70401874.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteLogsAccounting", "35623c7c-e685-4bb8-a2aa-63af70401874.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENLogsAccountingEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteLogsAccounting", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllLogsAccounting
/// </summary>

public static async Task DeleteAllLogsAccounting(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllLogsAccounting", "35623c7c-e685-4bb8-a2aa-63af70401874.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllLogsAccounting", "35623c7c-e685-4bb8-a2aa-63af70401874.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENLogsAccountingEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteLogsAccounting", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetLogsAccounting
/// </summary>

public static async Task<RC_404aa878a81887880a35de683904d643> GetLogsAccounting(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_404aa878a81887880a35de683904d643 outParamRecord = default;
outParamRecord = new RC_404aa878a81887880a35de683904d643();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetLogsAccounting", "35623c7c-e685-4bb8-a2aa-63af70401874.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetLogsAccounting", "35623c7c-e685-4bb8-a2aa-63af70401874.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@Title, "title") ?? "title", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@AssociatedId, "associatedid") ?? "associatedid", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@Description, "description") ?? "description", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@CreatedBy, "createdby") ?? "createdby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@CreatedOn, "createdon") ?? "createdon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@LogsAccountingSubjectId, "logsaccountingsubjectid") ?? "logsaccountingsubjectid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
" FROM " + ENLogsAccountingEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetLogsAccounting", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(7,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENLogsAccountingEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetLogsAccountingForUpdate
/// </summary>

public static async Task<RC_404aa878a81887880a35de683904d643> GetLogsAccountingForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_404aa878a81887880a35de683904d643 outParamRecord = default;
outParamRecord = new RC_404aa878a81887880a35de683904d643();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetLogsAccountingForUpdate", "35623c7c-e685-4bb8-a2aa-63af70401874.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetLogsAccountingForUpdate", "35623c7c-e685-4bb8-a2aa-63af70401874.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@Title, "title") ?? "title", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@AssociatedId, "associatedid") ?? "associatedid", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@Description, "description") ?? "description", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@CreatedBy, "createdby") ?? "createdby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@CreatedOn, "createdon") ?? "createdon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@LogsAccountingSubjectId, "logsaccountingsubjectid") ?? "logsaccountingsubjectid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
" FROM " + ENLogsAccountingEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetLogsAccountingForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(7,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENLogsAccountingEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateLogsAccounting
/// </summary>

public static async Task UpdateLogsAccounting(IRequestContext requestContext,BitArray usedFields,RC_404aa878a81887880a35de683904d643 inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateLogsAccounting", "35623c7c-e685-4bb8-a2aa-63af70401874.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateLogsAccounting", "35623c7c-e685-4bb8-a2aa-63af70401874.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord ssENLogsAccounting = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(7,true);
}
string updateSet = "UPDATE " + ENLogsAccountingEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@Title, "title") ?? "title") + " = @ssTitle"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@AssociatedId, "associatedid") ?? "associatedid") + " = @ssAssociatedId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@Description, "description") ?? "description") + " = @ssDescription"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = @ssCreatedBy"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = @ssCreatedOn"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@LogsAccountingSubjectId, "logsaccountingsubjectid") ?? "logsaccountingsubjectid") + " = @ssLogsAccountingSubjectId"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENLogsAccounting_ssId_LogsAccounting";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssTitle", DbType.String, ssENLogsAccounting.ssTitle);
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssAssociatedId", DbType.String, ssENLogsAccounting.ssAssociatedId);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssDescription", DbType.String, ssENLogsAccounting.ssDescription);
}
if(usedFields[4]) {
if ((ssENLogsAccounting.ssCreatedBy=="")) {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENLogsAccounting.ssCreatedBy);

}
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENLogsAccounting.ssCreatedOn);
}
if(usedFields[6]) {
if ((ssENLogsAccounting.ssLogsAccountingSubjectId==0)) {
sqlCmd.CreateParameter("@ssLogsAccountingSubjectId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssLogsAccountingSubjectId", DbType.Int32, ssENLogsAccounting.ssLogsAccountingSubjectId);

}
}
sqlCmd.CreateParameter("@idparam_ssENLogsAccounting_ssId_LogsAccounting", DbType.Int64, ssENLogsAccounting.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateLogsAccounting", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("LogsAccounting", ssENLogsAccounting.ssId.ToString()); }}
}
return;
}

}
}
