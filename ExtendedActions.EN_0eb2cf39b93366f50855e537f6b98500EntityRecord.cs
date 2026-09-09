using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateOrderItemEntries
/// </summary>

public static async Task<long> CreateOrderItemEntries(IRequestContext requestContext,RC_27f9dcc2de814d2d04d4d18f5b8c424b inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrderItemEntries", "0fde4273-b040-4961-b291-62da107c4e19.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrderItemEntries", "0fde4273-b040-4961-b291-62da107c4e19.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_0eb2cf39b93366f50855e537f6b98500EntityRecord ssENOrderItemEntries = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENOrderItemEntriesEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@OrderMainItemid, "ordermainitemid") ?? "ordermainitemid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@Quantity_, "quantity_") ?? "quantity_") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@IsFromFirstImport, "isfromfirstimport") ?? "isfromfirstimport") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@EntryDocument, "entrydocument") ?? "entrydocument") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@RejectFolio, "rejectfolio") ?? "rejectfolio") + "" +
" ) VALUES (" +
" @ssOrderMainItemid" +
", @ssQuantity_" +
", @ssIsFromFirstImport" +
", @ssEntryDocument" +
", @ssCreatedOn" +
", @ssCreatedBy" +
", @ssRejectFolio" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENOrderItemEntries.ssOrderMainItemid==0L)) {
insertSqlCmd.CreateParameter("@ssOrderMainItemid", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssOrderMainItemid", DbType.Int64, ssENOrderItemEntries.ssOrderMainItemid);

}
var Quantity_Parameter = insertSqlCmd.CreateParameter("@ssQuantity_", DbType.Decimal, ssENOrderItemEntries.ssQuantity_);
{
    string decimalAsStr = ssENOrderItemEntries.ssQuantity_.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {Quantity_Parameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
insertSqlCmd.CreateParameter("@ssIsFromFirstImport", DbType.Boolean, ssENOrderItemEntries.ssIsFromFirstImport);
insertSqlCmd.CreateParameter("@ssEntryDocument", DbType.String, ssENOrderItemEntries.ssEntryDocument);
insertSqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENOrderItemEntries.ssCreatedOn);
if ((ssENOrderItemEntries.ssCreatedBy=="")) {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENOrderItemEntries.ssCreatedBy);

}
insertSqlCmd.CreateParameter("@ssRejectFolio", DbType.Boolean, ssENOrderItemEntries.ssRejectFolio);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrderItemEntries", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateOrderItemEntries
/// </summary>

public static async Task<long> CreateOrUpdateOrderItemEntries(IRequestContext requestContext,BitArray usedFields,RC_27f9dcc2de814d2d04d4d18f5b8c424b inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateOrderItemEntries", "0fde4273-b040-4961-b291-62da107c4e19.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateOrderItemEntries", "0fde4273-b040-4961-b291-62da107c4e19.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_0eb2cf39b93366f50855e537f6b98500EntityRecord ssENOrderItemEntries = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(8,true);
}
string updateSet = "UPDATE " + ENOrderItemEntriesEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@OrderMainItemid, "ordermainitemid") ?? "ordermainitemid") + " = @ssOrderMainItemid"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@Quantity_, "quantity_") ?? "quantity_") + " = @ssQuantity_"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@IsFromFirstImport, "isfromfirstimport") ?? "isfromfirstimport") + " = @ssIsFromFirstImport"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@EntryDocument, "entrydocument") ?? "entrydocument") + " = @ssEntryDocument"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = @ssCreatedOn"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = @ssCreatedBy"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@RejectFolio, "rejectfolio") ?? "rejectfolio") + " = @ssRejectFolio"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENOrderItemEntries_ssId_OrderItemEntries";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@IsFromFirstImport, "isfromfirstimport") ?? "isfromfirstimport") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@IsFromFirstImport, "isfromfirstimport") ?? "isfromfirstimport") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENOrderItemEntries.ssOrderMainItemid==0L)) {
sqlCmd.CreateParameter("@ssOrderMainItemid", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssOrderMainItemid", DbType.Int64, ssENOrderItemEntries.ssOrderMainItemid);

}
}
if(usedFields[2]) {
var Quantity_Parameter = sqlCmd.CreateParameter("@ssQuantity_", DbType.Decimal, ssENOrderItemEntries.ssQuantity_);
{
    string decimalAsStr = ssENOrderItemEntries.ssQuantity_.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {Quantity_Parameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssIsFromFirstImport", DbType.Boolean, ssENOrderItemEntries.ssIsFromFirstImport);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssEntryDocument", DbType.String, ssENOrderItemEntries.ssEntryDocument);
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENOrderItemEntries.ssCreatedOn);
}
if(usedFields[6]) {
if ((ssENOrderItemEntries.ssCreatedBy=="")) {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENOrderItemEntries.ssCreatedBy);

}
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssRejectFolio", DbType.Boolean, ssENOrderItemEntries.ssRejectFolio);
}
sqlCmd.CreateParameter("@idparam_ssENOrderItemEntries_ssId_OrderItemEntries", DbType.Int64, ssENOrderItemEntries.ssId);
int counter = 0;
if(ssENOrderItemEntries.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateOrderItemEntries (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENOrderItemEntriesEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@OrderMainItemid, "ordermainitemid") ?? "ordermainitemid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@Quantity_, "quantity_") ?? "quantity_") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@IsFromFirstImport, "isfromfirstimport") ?? "isfromfirstimport") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@EntryDocument, "entrydocument") ?? "entrydocument") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@RejectFolio, "rejectfolio") ?? "rejectfolio") + "" +
" ) VALUES (" +
" @ssOrderMainItemid" +
", @ssQuantity_" +
", @ssIsFromFirstImport" +
", @ssEntryDocument" +
", @ssCreatedOn" +
", @ssCreatedBy" +
", @ssRejectFolio" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENOrderItemEntries.ssOrderMainItemid==0L)) {
insertSqlCmd.CreateParameter("@ssOrderMainItemid", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssOrderMainItemid", DbType.Int64, ssENOrderItemEntries.ssOrderMainItemid);

}
var Quantity_Parameter = insertSqlCmd.CreateParameter("@ssQuantity_", DbType.Decimal, ssENOrderItemEntries.ssQuantity_);
{
    string decimalAsStr = ssENOrderItemEntries.ssQuantity_.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {Quantity_Parameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
insertSqlCmd.CreateParameter("@ssIsFromFirstImport", DbType.Boolean, ssENOrderItemEntries.ssIsFromFirstImport);
insertSqlCmd.CreateParameter("@ssEntryDocument", DbType.String, ssENOrderItemEntries.ssEntryDocument);
insertSqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENOrderItemEntries.ssCreatedOn);
if ((ssENOrderItemEntries.ssCreatedBy=="")) {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENOrderItemEntries.ssCreatedBy);

}
insertSqlCmd.CreateParameter("@ssRejectFolio", DbType.Boolean, ssENOrderItemEntries.ssRejectFolio);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateOrderItemEntries", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENOrderItemEntries.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeOrderItemEntries
/// </summary>

public static async Task CreateOrUpdateSomeOrderItemEntries(IRequestContext requestContext,RL_1560940f84afb17b822113e1812ea380 inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeOrderItemEntries", "0fde4273-b040-4961-b291-62da107c4e19.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeOrderItemEntries", "0fde4273-b040-4961-b291-62da107c4e19.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENOrderItemEntriesEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@OrderMainItemid, "ordermainitemid") ?? "ordermainitemid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@Quantity_, "quantity_") ?? "quantity_") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@IsFromFirstImport, "isfromfirstimport") ?? "isfromfirstimport") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@EntryDocument, "entrydocument") ?? "entrydocument") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@RejectFolio, "rejectfolio") ?? "rejectfolio") + ") VALUES ( unnest(@ssOrderMainItemid),  unnest(@ssQuantity_),  unnest(@ssIsFromFirstImport),  unnest(@ssEntryDocument),  unnest(@ssCreatedOn),  unnest(@ssCreatedBy),  unnest(@ssRejectFolio)) ";
insertSql += "";

string updateSql = "UPDATE " + entityTableName + " SET " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@OrderMainItemid, "ordermainitemid") ?? "ordermainitemid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@OrderMainItemid, "ordermainitemid") ?? "ordermainitemid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@Quantity_, "quantity_") ?? "quantity_") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@Quantity_, "quantity_") ?? "quantity_") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@IsFromFirstImport, "isfromfirstimport") ?? "isfromfirstimport") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@IsFromFirstImport, "isfromfirstimport") ?? "isfromfirstimport") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@EntryDocument, "entrydocument") ?? "entrydocument") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@EntryDocument, "entrydocument") ?? "entrydocument") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@RejectFolio, "rejectfolio") ?? "rejectfolio") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@RejectFolio, "rejectfolio") ?? "rejectfolio") + " from ( select  unnest(@ssId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@Id, "id") ?? "id") + ",  unnest(@ssOrderMainItemid) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@OrderMainItemid, "ordermainitemid") ?? "ordermainitemid") + ",  unnest(@ssQuantity_) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@Quantity_, "quantity_") ?? "quantity_") + ",  unnest(@ssIsFromFirstImport) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@IsFromFirstImport, "isfromfirstimport") ?? "isfromfirstimport") + ",  unnest(@ssEntryDocument) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@EntryDocument, "entrydocument") ?? "entrydocument") + ",  unnest(@ssCreatedOn) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + ",  unnest(@ssCreatedBy) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ",  unnest(@ssRejectFolio) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@RejectFolio, "rejectfolio") ?? "rejectfolio") + " ) as updateTable where " + entityTableName + "." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@Id, "id") ?? "id") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@Id, "id") ?? "id") + " ";
updateSql += "";

List<object> insertOrderMainItemidList = new List<object>();
List<decimal> insertQuantity_List = new List<decimal>();
List<bool> insertIsFromFirstImportList = new List<bool>();
List<string> insertEntryDocumentList = new List<string>();
List<DateTime> insertCreatedOnList = new List<DateTime>();
List<object> insertCreatedByList = new List<object>();
List<bool> insertRejectFolioList = new List<bool>();

List<long> updateIdList = new List<long>();
List<object> updateOrderMainItemidList = new List<object>();
List<decimal> updateQuantity_List = new List<decimal>();
List<bool> updateIsFromFirstImportList = new List<bool>();
List<string> updateEntryDocumentList = new List<string>();
List<DateTime> updateCreatedOnList = new List<DateTime>();
List<object> updateCreatedByList = new List<object>();
List<bool> updateRejectFolioList = new List<bool>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_27f9dcc2de814d2d04d4d18f5b8c424b)inParamSourceList.Current).ssENOrderItemEntries;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
if ((record.ssOrderMainItemid==0L)) {
updateOrderMainItemidList.Add(null);
} else {
updateOrderMainItemidList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssOrderMainItemid));
}
updateQuantity_List.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssQuantity_));
updateIsFromFirstImportList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsFromFirstImport));
updateEntryDocumentList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssEntryDocument));
updateCreatedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssCreatedOn));
if ((record.ssCreatedBy=="")) {
updateCreatedByList.Add(null);
} else {
updateCreatedByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCreatedBy));
}
updateRejectFolioList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssRejectFolio));
} else {
if ((record.ssOrderMainItemid==0L)) {
insertOrderMainItemidList.Add(null);
} else {
insertOrderMainItemidList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssOrderMainItemid));
}
insertQuantity_List.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssQuantity_));
insertIsFromFirstImportList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsFromFirstImport));
insertEntryDocumentList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssEntryDocument));
insertCreatedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssCreatedOn));
if ((record.ssCreatedBy=="")) {
insertCreatedByList.Add(null);
} else {
insertCreatedByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCreatedBy));
}
insertRejectFolioList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssRejectFolio));
}
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertOrderMainItemidList.IsEmpty() || !insertQuantity_List.IsEmpty() || !insertIsFromFirstImportList.IsEmpty() || !insertEntryDocumentList.IsEmpty() || !insertCreatedOnList.IsEmpty() || !insertCreatedByList.IsEmpty() || !insertRejectFolioList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssOrderMainItemid",DbType.Int64,insertOrderMainItemidList);
executionService.CreateParameter(insertSqlCmd,"@ssQuantity_",DbType.Decimal,insertQuantity_List);
executionService.CreateParameter(insertSqlCmd,"@ssIsFromFirstImport",DbType.Boolean,insertIsFromFirstImportList);
executionService.CreateParameter(insertSqlCmd,"@ssEntryDocument",DbType.String,insertEntryDocumentList);
executionService.CreateParameter(insertSqlCmd,"@ssCreatedOn",DbType.DateTime,insertCreatedOnList);
executionService.CreateParameter(insertSqlCmd,"@ssCreatedBy",DbType.String,insertCreatedByList);
executionService.CreateParameter(insertSqlCmd,"@ssRejectFolio",DbType.Boolean,insertRejectFolioList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeOrderItemEntries (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateOrderMainItemidList.IsEmpty() || !updateQuantity_List.IsEmpty() || !updateIsFromFirstImportList.IsEmpty() || !updateEntryDocumentList.IsEmpty() || !updateCreatedOnList.IsEmpty() || !updateCreatedByList.IsEmpty() || !updateRejectFolioList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssOrderMainItemid",DbType.Int64,updateOrderMainItemidList);
executionService.CreateParameter(updateSqlCmd,"@ssQuantity_",DbType.Decimal,updateQuantity_List);
executionService.CreateParameter(updateSqlCmd,"@ssIsFromFirstImport",DbType.Boolean,updateIsFromFirstImportList);
executionService.CreateParameter(updateSqlCmd,"@ssEntryDocument",DbType.String,updateEntryDocumentList);
executionService.CreateParameter(updateSqlCmd,"@ssCreatedOn",DbType.DateTime,updateCreatedOnList);
executionService.CreateParameter(updateSqlCmd,"@ssCreatedBy",DbType.String,updateCreatedByList);
executionService.CreateParameter(updateSqlCmd,"@ssRejectFolio",DbType.Boolean,updateRejectFolioList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeOrderItemEntries (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteOrderItemEntries
/// </summary>

public static async Task DeleteOrderItemEntries(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteOrderItemEntries", "0fde4273-b040-4961-b291-62da107c4e19.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteOrderItemEntries", "0fde4273-b040-4961-b291-62da107c4e19.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENOrderItemEntriesEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteOrderItemEntries", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllOrderItemEntries
/// </summary>

public static async Task DeleteAllOrderItemEntries(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllOrderItemEntries", "0fde4273-b040-4961-b291-62da107c4e19.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllOrderItemEntries", "0fde4273-b040-4961-b291-62da107c4e19.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENOrderItemEntriesEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteOrderItemEntries", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetOrderItemEntries
/// </summary>

public static async Task<RC_27f9dcc2de814d2d04d4d18f5b8c424b> GetOrderItemEntries(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_27f9dcc2de814d2d04d4d18f5b8c424b outParamRecord = default;
outParamRecord = new RC_27f9dcc2de814d2d04d4d18f5b8c424b();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetOrderItemEntries", "0fde4273-b040-4961-b291-62da107c4e19.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetOrderItemEntries", "0fde4273-b040-4961-b291-62da107c4e19.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@OrderMainItemid, "ordermainitemid") ?? "ordermainitemid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@Quantity_, "quantity_") ?? "quantity_", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@IsFromFirstImport, "isfromfirstimport") ?? "isfromfirstimport", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@EntryDocument, "entrydocument") ?? "entrydocument", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@CreatedOn, "createdon") ?? "createdon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@CreatedBy, "createdby") ?? "createdby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@RejectFolio, "rejectfolio") ?? "rejectfolio", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
" FROM " + ENOrderItemEntriesEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetOrderItemEntries", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(8,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENOrderItemEntriesEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetOrderItemEntriesForUpdate
/// </summary>

public static async Task<RC_27f9dcc2de814d2d04d4d18f5b8c424b> GetOrderItemEntriesForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_27f9dcc2de814d2d04d4d18f5b8c424b outParamRecord = default;
outParamRecord = new RC_27f9dcc2de814d2d04d4d18f5b8c424b();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetOrderItemEntriesForUpdate", "0fde4273-b040-4961-b291-62da107c4e19.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetOrderItemEntriesForUpdate", "0fde4273-b040-4961-b291-62da107c4e19.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@OrderMainItemid, "ordermainitemid") ?? "ordermainitemid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@Quantity_, "quantity_") ?? "quantity_", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@IsFromFirstImport, "isfromfirstimport") ?? "isfromfirstimport", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@EntryDocument, "entrydocument") ?? "entrydocument", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@CreatedOn, "createdon") ?? "createdon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@CreatedBy, "createdby") ?? "createdby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@RejectFolio, "rejectfolio") ?? "rejectfolio", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
" FROM " + ENOrderItemEntriesEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetOrderItemEntriesForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(8,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENOrderItemEntriesEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateOrderItemEntries
/// </summary>

public static async Task UpdateOrderItemEntries(IRequestContext requestContext,BitArray usedFields,RC_27f9dcc2de814d2d04d4d18f5b8c424b inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateOrderItemEntries", "0fde4273-b040-4961-b291-62da107c4e19.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateOrderItemEntries", "0fde4273-b040-4961-b291-62da107c4e19.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_0eb2cf39b93366f50855e537f6b98500EntityRecord ssENOrderItemEntries = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(8,true);
}
string updateSet = "UPDATE " + ENOrderItemEntriesEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@OrderMainItemid, "ordermainitemid") ?? "ordermainitemid") + " = @ssOrderMainItemid"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@Quantity_, "quantity_") ?? "quantity_") + " = @ssQuantity_"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@IsFromFirstImport, "isfromfirstimport") ?? "isfromfirstimport") + " = @ssIsFromFirstImport"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@EntryDocument, "entrydocument") ?? "entrydocument") + " = @ssEntryDocument"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = @ssCreatedOn"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = @ssCreatedBy"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@RejectFolio, "rejectfolio") ?? "rejectfolio") + " = @ssRejectFolio"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENOrderItemEntries_ssId_OrderItemEntries";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@IsFromFirstImport, "isfromfirstimport") ?? "isfromfirstimport") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderItemEntries, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderItemEntriesAttributeKeys.@IsFromFirstImport, "isfromfirstimport") ?? "isfromfirstimport") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENOrderItemEntries.ssOrderMainItemid==0L)) {
sqlCmd.CreateParameter("@ssOrderMainItemid", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssOrderMainItemid", DbType.Int64, ssENOrderItemEntries.ssOrderMainItemid);

}
}
if(usedFields[2]) {
var Quantity_Parameter = sqlCmd.CreateParameter("@ssQuantity_", DbType.Decimal, ssENOrderItemEntries.ssQuantity_);
{
    string decimalAsStr = ssENOrderItemEntries.ssQuantity_.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {Quantity_Parameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssIsFromFirstImport", DbType.Boolean, ssENOrderItemEntries.ssIsFromFirstImport);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssEntryDocument", DbType.String, ssENOrderItemEntries.ssEntryDocument);
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENOrderItemEntries.ssCreatedOn);
}
if(usedFields[6]) {
if ((ssENOrderItemEntries.ssCreatedBy=="")) {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENOrderItemEntries.ssCreatedBy);

}
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssRejectFolio", DbType.Boolean, ssENOrderItemEntries.ssRejectFolio);
}
sqlCmd.CreateParameter("@idparam_ssENOrderItemEntries_ssId_OrderItemEntries", DbType.Int64, ssENOrderItemEntries.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateOrderItemEntries", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("OrderItemEntries", ssENOrderItemEntries.ssId.ToString()); }}
}
return;
}

}
}
