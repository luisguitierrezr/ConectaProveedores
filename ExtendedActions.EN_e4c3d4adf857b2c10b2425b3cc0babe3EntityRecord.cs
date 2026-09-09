using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateOrderRequestFile
/// </summary>

public static async Task<long> CreateOrderRequestFile(IRequestContext requestContext,RC_73d8126c722e2b4dd662dab2bf1a72d1 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrderRequestFile", "733fd335-abe5-424f-9355-89e553d08310.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrderRequestFile", "733fd335-abe5-424f-9355-89e553d08310.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord ssENOrderRequestFile = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENOrderRequestFileEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@OrderId, "orderid") ?? "orderid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@Filename, "filename") ?? "filename") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@StorageId, "storageid") ?? "storageid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@Description, "description") ?? "description") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@NeedsApproval, "needsapproval") ?? "needsapproval") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@IsApproved, "isapproved") ?? "isapproved") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@IsRejected, "isrejected") ?? "isrejected") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@OrderAccConceptId, "orderaccconceptid") ?? "orderaccconceptid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@IsFinancialFile, "isfinancialfile") ?? "isfinancialfile") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@OrderContractFile, "ordercontractfile") ?? "ordercontractfile") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@NeedAccounting, "needaccounting") ?? "needaccounting") + "" +
" ) VALUES (" +
" @ssOrderId" +
", @ssInvoiceId" +
", @ssFilename" +
", @ssStorageId" +
", @ssDescription" +
", @ssNeedsApproval" +
", @ssIsApproved" +
", @ssIsRejected" +
", @ssCreatedBy" +
", @ssCreatedOn" +
", @ssUpdatedBy" +
", @ssUpdatedOn" +
", @ssOrderAccConceptId" +
", @ssIsFinancialFile" +
", @ssOrderContractFile" +
", @ssNeedAccounting" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssOrderId", DbType.Int64, ssENOrderRequestFile.ssOrderId);
if ((ssENOrderRequestFile.ssInvoiceId==0L)) {
insertSqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, ssENOrderRequestFile.ssInvoiceId);

}
insertSqlCmd.CreateParameter("@ssFilename", DbType.String, ssENOrderRequestFile.ssFilename);
if ((ssENOrderRequestFile.ssStorageId==0L)) {
insertSqlCmd.CreateParameter("@ssStorageId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssStorageId", DbType.Int64, ssENOrderRequestFile.ssStorageId);

}
insertSqlCmd.CreateParameter("@ssDescription", DbType.String, ssENOrderRequestFile.ssDescription);
insertSqlCmd.CreateParameter("@ssNeedsApproval", DbType.Boolean, ssENOrderRequestFile.ssNeedsApproval);
insertSqlCmd.CreateParameter("@ssIsApproved", DbType.Boolean, ssENOrderRequestFile.ssIsApproved);
insertSqlCmd.CreateParameter("@ssIsRejected", DbType.Boolean, ssENOrderRequestFile.ssIsRejected);
if ((ssENOrderRequestFile.ssCreatedBy=="")) {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENOrderRequestFile.ssCreatedBy);

}
insertSqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENOrderRequestFile.ssCreatedOn);
if ((ssENOrderRequestFile.ssUpdatedBy=="")) {
insertSqlCmd.CreateParameter("@ssUpdatedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssUpdatedBy", DbType.String, ssENOrderRequestFile.ssUpdatedBy);

}
insertSqlCmd.CreateParameter("@ssUpdatedOn", DbType.DateTime, ssENOrderRequestFile.ssUpdatedOn);
if ((ssENOrderRequestFile.ssOrderAccConceptId==0L)) {
insertSqlCmd.CreateParameter("@ssOrderAccConceptId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssOrderAccConceptId", DbType.Int64, ssENOrderRequestFile.ssOrderAccConceptId);

}
insertSqlCmd.CreateParameter("@ssIsFinancialFile", DbType.Boolean, ssENOrderRequestFile.ssIsFinancialFile);
if ((ssENOrderRequestFile.ssOrderContractFile==0L)) {
insertSqlCmd.CreateParameter("@ssOrderContractFile", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssOrderContractFile", DbType.Int64, ssENOrderRequestFile.ssOrderContractFile);

}
insertSqlCmd.CreateParameter("@ssNeedAccounting", DbType.Boolean, ssENOrderRequestFile.ssNeedAccounting);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrderRequestFile", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateOrderRequestFile
/// </summary>

public static async Task<long> CreateOrUpdateOrderRequestFile(IRequestContext requestContext,BitArray usedFields,RC_73d8126c722e2b4dd662dab2bf1a72d1 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateOrderRequestFile", "733fd335-abe5-424f-9355-89e553d08310.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateOrderRequestFile", "733fd335-abe5-424f-9355-89e553d08310.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord ssENOrderRequestFile = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(17,true);
}
string updateSet = "UPDATE " + ENOrderRequestFileEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@OrderId, "orderid") ?? "orderid") + " = @ssOrderId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + " = @ssInvoiceId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@Filename, "filename") ?? "filename") + " = @ssFilename"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@StorageId, "storageid") ?? "storageid") + " = @ssStorageId"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@Description, "description") ?? "description") + " = @ssDescription"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@NeedsApproval, "needsapproval") ?? "needsapproval") + " = @ssNeedsApproval"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@IsApproved, "isapproved") ?? "isapproved") + " = @ssIsApproved"): parameters);
parameters = (usedFields[8] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@IsRejected, "isrejected") ?? "isrejected") + " = @ssIsRejected"): parameters);
parameters = (usedFields[9] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = @ssCreatedBy"): parameters);
parameters = (usedFields[10] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = @ssCreatedOn"): parameters);
parameters = (usedFields[11] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby") + " = @ssUpdatedBy"): parameters);
parameters = (usedFields[12] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon") + " = @ssUpdatedOn"): parameters);
parameters = (usedFields[13] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@OrderAccConceptId, "orderaccconceptid") ?? "orderaccconceptid") + " = @ssOrderAccConceptId"): parameters);
parameters = (usedFields[14] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@IsFinancialFile, "isfinancialfile") ?? "isfinancialfile") + " = @ssIsFinancialFile"): parameters);
parameters = (usedFields[15] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@OrderContractFile, "ordercontractfile") ?? "ordercontractfile") + " = @ssOrderContractFile"): parameters);
parameters = (usedFields[16] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@NeedAccounting, "needaccounting") ?? "needaccounting") + " = @ssNeedAccounting"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENOrderRequestFile_ssId_OrderRequestFile";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@NeedsApproval, "needsapproval") ?? "needsapproval") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@NeedsApproval, "needsapproval") ?? "needsapproval") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssOrderId", DbType.Int64, ssENOrderRequestFile.ssOrderId);
}
if(usedFields[2]) {
if ((ssENOrderRequestFile.ssInvoiceId==0L)) {
sqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, ssENOrderRequestFile.ssInvoiceId);

}
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssFilename", DbType.String, ssENOrderRequestFile.ssFilename);
}
if(usedFields[4]) {
if ((ssENOrderRequestFile.ssStorageId==0L)) {
sqlCmd.CreateParameter("@ssStorageId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssStorageId", DbType.Int64, ssENOrderRequestFile.ssStorageId);

}
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssDescription", DbType.String, ssENOrderRequestFile.ssDescription);
}
if(usedFields[6]) {
sqlCmd.CreateParameter("@ssNeedsApproval", DbType.Boolean, ssENOrderRequestFile.ssNeedsApproval);
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssIsApproved", DbType.Boolean, ssENOrderRequestFile.ssIsApproved);
}
if(usedFields[8]) {
sqlCmd.CreateParameter("@ssIsRejected", DbType.Boolean, ssENOrderRequestFile.ssIsRejected);
}
if(usedFields[9]) {
if ((ssENOrderRequestFile.ssCreatedBy=="")) {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENOrderRequestFile.ssCreatedBy);

}
}
if(usedFields[10]) {
sqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENOrderRequestFile.ssCreatedOn);
}
if(usedFields[11]) {
if ((ssENOrderRequestFile.ssUpdatedBy=="")) {
sqlCmd.CreateParameter("@ssUpdatedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssUpdatedBy", DbType.String, ssENOrderRequestFile.ssUpdatedBy);

}
}
if(usedFields[12]) {
sqlCmd.CreateParameter("@ssUpdatedOn", DbType.DateTime, ssENOrderRequestFile.ssUpdatedOn);
}
if(usedFields[13]) {
if ((ssENOrderRequestFile.ssOrderAccConceptId==0L)) {
sqlCmd.CreateParameter("@ssOrderAccConceptId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssOrderAccConceptId", DbType.Int64, ssENOrderRequestFile.ssOrderAccConceptId);

}
}
if(usedFields[14]) {
sqlCmd.CreateParameter("@ssIsFinancialFile", DbType.Boolean, ssENOrderRequestFile.ssIsFinancialFile);
}
if(usedFields[15]) {
if ((ssENOrderRequestFile.ssOrderContractFile==0L)) {
sqlCmd.CreateParameter("@ssOrderContractFile", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssOrderContractFile", DbType.Int64, ssENOrderRequestFile.ssOrderContractFile);

}
}
if(usedFields[16]) {
sqlCmd.CreateParameter("@ssNeedAccounting", DbType.Boolean, ssENOrderRequestFile.ssNeedAccounting);
}
sqlCmd.CreateParameter("@idparam_ssENOrderRequestFile_ssId_OrderRequestFile", DbType.Int64, ssENOrderRequestFile.ssId);
int counter = 0;
if(ssENOrderRequestFile.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateOrderRequestFile (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENOrderRequestFileEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@OrderId, "orderid") ?? "orderid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@Filename, "filename") ?? "filename") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@StorageId, "storageid") ?? "storageid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@Description, "description") ?? "description") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@NeedsApproval, "needsapproval") ?? "needsapproval") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@IsApproved, "isapproved") ?? "isapproved") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@IsRejected, "isrejected") ?? "isrejected") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@OrderAccConceptId, "orderaccconceptid") ?? "orderaccconceptid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@IsFinancialFile, "isfinancialfile") ?? "isfinancialfile") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@OrderContractFile, "ordercontractfile") ?? "ordercontractfile") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@NeedAccounting, "needaccounting") ?? "needaccounting") + "" +
" ) VALUES (" +
" @ssOrderId" +
", @ssInvoiceId" +
", @ssFilename" +
", @ssStorageId" +
", @ssDescription" +
", @ssNeedsApproval" +
", @ssIsApproved" +
", @ssIsRejected" +
", @ssCreatedBy" +
", @ssCreatedOn" +
", @ssUpdatedBy" +
", @ssUpdatedOn" +
", @ssOrderAccConceptId" +
", @ssIsFinancialFile" +
", @ssOrderContractFile" +
", @ssNeedAccounting" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssOrderId", DbType.Int64, ssENOrderRequestFile.ssOrderId);
if ((ssENOrderRequestFile.ssInvoiceId==0L)) {
insertSqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, ssENOrderRequestFile.ssInvoiceId);

}
insertSqlCmd.CreateParameter("@ssFilename", DbType.String, ssENOrderRequestFile.ssFilename);
if ((ssENOrderRequestFile.ssStorageId==0L)) {
insertSqlCmd.CreateParameter("@ssStorageId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssStorageId", DbType.Int64, ssENOrderRequestFile.ssStorageId);

}
insertSqlCmd.CreateParameter("@ssDescription", DbType.String, ssENOrderRequestFile.ssDescription);
insertSqlCmd.CreateParameter("@ssNeedsApproval", DbType.Boolean, ssENOrderRequestFile.ssNeedsApproval);
insertSqlCmd.CreateParameter("@ssIsApproved", DbType.Boolean, ssENOrderRequestFile.ssIsApproved);
insertSqlCmd.CreateParameter("@ssIsRejected", DbType.Boolean, ssENOrderRequestFile.ssIsRejected);
if ((ssENOrderRequestFile.ssCreatedBy=="")) {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENOrderRequestFile.ssCreatedBy);

}
insertSqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENOrderRequestFile.ssCreatedOn);
if ((ssENOrderRequestFile.ssUpdatedBy=="")) {
insertSqlCmd.CreateParameter("@ssUpdatedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssUpdatedBy", DbType.String, ssENOrderRequestFile.ssUpdatedBy);

}
insertSqlCmd.CreateParameter("@ssUpdatedOn", DbType.DateTime, ssENOrderRequestFile.ssUpdatedOn);
if ((ssENOrderRequestFile.ssOrderAccConceptId==0L)) {
insertSqlCmd.CreateParameter("@ssOrderAccConceptId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssOrderAccConceptId", DbType.Int64, ssENOrderRequestFile.ssOrderAccConceptId);

}
insertSqlCmd.CreateParameter("@ssIsFinancialFile", DbType.Boolean, ssENOrderRequestFile.ssIsFinancialFile);
if ((ssENOrderRequestFile.ssOrderContractFile==0L)) {
insertSqlCmd.CreateParameter("@ssOrderContractFile", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssOrderContractFile", DbType.Int64, ssENOrderRequestFile.ssOrderContractFile);

}
insertSqlCmd.CreateParameter("@ssNeedAccounting", DbType.Boolean, ssENOrderRequestFile.ssNeedAccounting);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateOrderRequestFile", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENOrderRequestFile.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeOrderRequestFile
/// </summary>

public static async Task CreateOrUpdateSomeOrderRequestFile(IRequestContext requestContext,RL_d258c3d50d870257794347fdeb7cc218 inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeOrderRequestFile", "733fd335-abe5-424f-9355-89e553d08310.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeOrderRequestFile", "733fd335-abe5-424f-9355-89e553d08310.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENOrderRequestFileEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@OrderId, "orderid") ?? "orderid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@Filename, "filename") ?? "filename") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@StorageId, "storageid") ?? "storageid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@Description, "description") ?? "description") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@NeedsApproval, "needsapproval") ?? "needsapproval") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@IsApproved, "isapproved") ?? "isapproved") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@IsRejected, "isrejected") ?? "isrejected") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@OrderAccConceptId, "orderaccconceptid") ?? "orderaccconceptid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@IsFinancialFile, "isfinancialfile") ?? "isfinancialfile") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@OrderContractFile, "ordercontractfile") ?? "ordercontractfile") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@NeedAccounting, "needaccounting") ?? "needaccounting") + ") VALUES ( unnest(@ssOrderId),  unnest(@ssInvoiceId),  unnest(@ssFilename),  unnest(@ssStorageId),  unnest(@ssDescription),  unnest(@ssNeedsApproval),  unnest(@ssIsApproved),  unnest(@ssIsRejected),  unnest(@ssCreatedBy),  unnest(@ssCreatedOn),  unnest(@ssUpdatedBy),  unnest(@ssUpdatedOn),  unnest(@ssOrderAccConceptId),  unnest(@ssIsFinancialFile),  unnest(@ssOrderContractFile),  unnest(@ssNeedAccounting)) ";
insertSql += "";

string updateSql = "UPDATE " + entityTableName + " SET " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@OrderId, "orderid") ?? "orderid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@OrderId, "orderid") ?? "orderid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@Filename, "filename") ?? "filename") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@Filename, "filename") ?? "filename") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@StorageId, "storageid") ?? "storageid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@StorageId, "storageid") ?? "storageid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@Description, "description") ?? "description") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@Description, "description") ?? "description") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@NeedsApproval, "needsapproval") ?? "needsapproval") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@NeedsApproval, "needsapproval") ?? "needsapproval") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@IsApproved, "isapproved") ?? "isapproved") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@IsApproved, "isapproved") ?? "isapproved") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@IsRejected, "isrejected") ?? "isrejected") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@IsRejected, "isrejected") ?? "isrejected") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@OrderAccConceptId, "orderaccconceptid") ?? "orderaccconceptid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@OrderAccConceptId, "orderaccconceptid") ?? "orderaccconceptid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@IsFinancialFile, "isfinancialfile") ?? "isfinancialfile") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@IsFinancialFile, "isfinancialfile") ?? "isfinancialfile") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@OrderContractFile, "ordercontractfile") ?? "ordercontractfile") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@OrderContractFile, "ordercontractfile") ?? "ordercontractfile") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@NeedAccounting, "needaccounting") ?? "needaccounting") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@NeedAccounting, "needaccounting") ?? "needaccounting") + " from ( select  unnest(@ssId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@Id, "id") ?? "id") + ",  unnest(@ssOrderId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@OrderId, "orderid") ?? "orderid") + ",  unnest(@ssInvoiceId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + ",  unnest(@ssFilename) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@Filename, "filename") ?? "filename") + ",  unnest(@ssStorageId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@StorageId, "storageid") ?? "storageid") + ",  unnest(@ssDescription) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@Description, "description") ?? "description") + ",  unnest(@ssNeedsApproval) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@NeedsApproval, "needsapproval") ?? "needsapproval") + ",  unnest(@ssIsApproved) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@IsApproved, "isapproved") ?? "isapproved") + ",  unnest(@ssIsRejected) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@IsRejected, "isrejected") ?? "isrejected") + ",  unnest(@ssCreatedBy) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ",  unnest(@ssCreatedOn) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + ",  unnest(@ssUpdatedBy) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby") + ",  unnest(@ssUpdatedOn) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon") + ",  unnest(@ssOrderAccConceptId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@OrderAccConceptId, "orderaccconceptid") ?? "orderaccconceptid") + ",  unnest(@ssIsFinancialFile) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@IsFinancialFile, "isfinancialfile") ?? "isfinancialfile") + ",  unnest(@ssOrderContractFile) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@OrderContractFile, "ordercontractfile") ?? "ordercontractfile") + ",  unnest(@ssNeedAccounting) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@NeedAccounting, "needaccounting") ?? "needaccounting") + " ) as updateTable where " + entityTableName + "." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@Id, "id") ?? "id") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@Id, "id") ?? "id") + " ";
updateSql += "";

List<object> insertOrderIdList = new List<object>();
List<object> insertInvoiceIdList = new List<object>();
List<string> insertFilenameList = new List<string>();
List<object> insertStorageIdList = new List<object>();
List<string> insertDescriptionList = new List<string>();
List<bool> insertNeedsApprovalList = new List<bool>();
List<bool> insertIsApprovedList = new List<bool>();
List<bool> insertIsRejectedList = new List<bool>();
List<object> insertCreatedByList = new List<object>();
List<DateTime> insertCreatedOnList = new List<DateTime>();
List<object> insertUpdatedByList = new List<object>();
List<DateTime> insertUpdatedOnList = new List<DateTime>();
List<object> insertOrderAccConceptIdList = new List<object>();
List<bool> insertIsFinancialFileList = new List<bool>();
List<object> insertOrderContractFileList = new List<object>();
List<bool> insertNeedAccountingList = new List<bool>();

List<long> updateIdList = new List<long>();
List<object> updateOrderIdList = new List<object>();
List<object> updateInvoiceIdList = new List<object>();
List<string> updateFilenameList = new List<string>();
List<object> updateStorageIdList = new List<object>();
List<string> updateDescriptionList = new List<string>();
List<bool> updateNeedsApprovalList = new List<bool>();
List<bool> updateIsApprovedList = new List<bool>();
List<bool> updateIsRejectedList = new List<bool>();
List<object> updateCreatedByList = new List<object>();
List<DateTime> updateCreatedOnList = new List<DateTime>();
List<object> updateUpdatedByList = new List<object>();
List<DateTime> updateUpdatedOnList = new List<DateTime>();
List<object> updateOrderAccConceptIdList = new List<object>();
List<bool> updateIsFinancialFileList = new List<bool>();
List<object> updateOrderContractFileList = new List<object>();
List<bool> updateNeedAccountingList = new List<bool>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_73d8126c722e2b4dd662dab2bf1a72d1)inParamSourceList.Current).ssENOrderRequestFile;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
updateOrderIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssOrderId));
if ((record.ssInvoiceId==0L)) {
updateInvoiceIdList.Add(null);
} else {
updateInvoiceIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssInvoiceId));
}
updateFilenameList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssFilename));
if ((record.ssStorageId==0L)) {
updateStorageIdList.Add(null);
} else {
updateStorageIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssStorageId));
}
updateDescriptionList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssDescription));
updateNeedsApprovalList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssNeedsApproval));
updateIsApprovedList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsApproved));
updateIsRejectedList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsRejected));
if ((record.ssCreatedBy=="")) {
updateCreatedByList.Add(null);
} else {
updateCreatedByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCreatedBy));
}
updateCreatedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssCreatedOn));
if ((record.ssUpdatedBy=="")) {
updateUpdatedByList.Add(null);
} else {
updateUpdatedByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssUpdatedBy));
}
updateUpdatedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssUpdatedOn));
if ((record.ssOrderAccConceptId==0L)) {
updateOrderAccConceptIdList.Add(null);
} else {
updateOrderAccConceptIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssOrderAccConceptId));
}
updateIsFinancialFileList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsFinancialFile));
if ((record.ssOrderContractFile==0L)) {
updateOrderContractFileList.Add(null);
} else {
updateOrderContractFileList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssOrderContractFile));
}
updateNeedAccountingList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssNeedAccounting));
} else {
insertOrderIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssOrderId));
if ((record.ssInvoiceId==0L)) {
insertInvoiceIdList.Add(null);
} else {
insertInvoiceIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssInvoiceId));
}
insertFilenameList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssFilename));
if ((record.ssStorageId==0L)) {
insertStorageIdList.Add(null);
} else {
insertStorageIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssStorageId));
}
insertDescriptionList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssDescription));
insertNeedsApprovalList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssNeedsApproval));
insertIsApprovedList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsApproved));
insertIsRejectedList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsRejected));
if ((record.ssCreatedBy=="")) {
insertCreatedByList.Add(null);
} else {
insertCreatedByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCreatedBy));
}
insertCreatedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssCreatedOn));
if ((record.ssUpdatedBy=="")) {
insertUpdatedByList.Add(null);
} else {
insertUpdatedByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssUpdatedBy));
}
insertUpdatedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssUpdatedOn));
if ((record.ssOrderAccConceptId==0L)) {
insertOrderAccConceptIdList.Add(null);
} else {
insertOrderAccConceptIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssOrderAccConceptId));
}
insertIsFinancialFileList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsFinancialFile));
if ((record.ssOrderContractFile==0L)) {
insertOrderContractFileList.Add(null);
} else {
insertOrderContractFileList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssOrderContractFile));
}
insertNeedAccountingList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssNeedAccounting));
}
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertOrderIdList.IsEmpty() || !insertInvoiceIdList.IsEmpty() || !insertFilenameList.IsEmpty() || !insertStorageIdList.IsEmpty() || !insertDescriptionList.IsEmpty() || !insertNeedsApprovalList.IsEmpty() || !insertIsApprovedList.IsEmpty() || !insertIsRejectedList.IsEmpty() || !insertCreatedByList.IsEmpty() || !insertCreatedOnList.IsEmpty() || !insertUpdatedByList.IsEmpty() || !insertUpdatedOnList.IsEmpty() || !insertOrderAccConceptIdList.IsEmpty() || !insertIsFinancialFileList.IsEmpty() || !insertOrderContractFileList.IsEmpty() || !insertNeedAccountingList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssOrderId",DbType.Int64,insertOrderIdList);
executionService.CreateParameter(insertSqlCmd,"@ssInvoiceId",DbType.Int64,insertInvoiceIdList);
executionService.CreateParameter(insertSqlCmd,"@ssFilename",DbType.String,insertFilenameList);
executionService.CreateParameter(insertSqlCmd,"@ssStorageId",DbType.Int64,insertStorageIdList);
executionService.CreateParameter(insertSqlCmd,"@ssDescription",DbType.String,insertDescriptionList);
executionService.CreateParameter(insertSqlCmd,"@ssNeedsApproval",DbType.Boolean,insertNeedsApprovalList);
executionService.CreateParameter(insertSqlCmd,"@ssIsApproved",DbType.Boolean,insertIsApprovedList);
executionService.CreateParameter(insertSqlCmd,"@ssIsRejected",DbType.Boolean,insertIsRejectedList);
executionService.CreateParameter(insertSqlCmd,"@ssCreatedBy",DbType.String,insertCreatedByList);
executionService.CreateParameter(insertSqlCmd,"@ssCreatedOn",DbType.DateTime,insertCreatedOnList);
executionService.CreateParameter(insertSqlCmd,"@ssUpdatedBy",DbType.String,insertUpdatedByList);
executionService.CreateParameter(insertSqlCmd,"@ssUpdatedOn",DbType.DateTime,insertUpdatedOnList);
executionService.CreateParameter(insertSqlCmd,"@ssOrderAccConceptId",DbType.Int64,insertOrderAccConceptIdList);
executionService.CreateParameter(insertSqlCmd,"@ssIsFinancialFile",DbType.Boolean,insertIsFinancialFileList);
executionService.CreateParameter(insertSqlCmd,"@ssOrderContractFile",DbType.Int64,insertOrderContractFileList);
executionService.CreateParameter(insertSqlCmd,"@ssNeedAccounting",DbType.Boolean,insertNeedAccountingList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeOrderRequestFile (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateOrderIdList.IsEmpty() || !updateInvoiceIdList.IsEmpty() || !updateFilenameList.IsEmpty() || !updateStorageIdList.IsEmpty() || !updateDescriptionList.IsEmpty() || !updateNeedsApprovalList.IsEmpty() || !updateIsApprovedList.IsEmpty() || !updateIsRejectedList.IsEmpty() || !updateCreatedByList.IsEmpty() || !updateCreatedOnList.IsEmpty() || !updateUpdatedByList.IsEmpty() || !updateUpdatedOnList.IsEmpty() || !updateOrderAccConceptIdList.IsEmpty() || !updateIsFinancialFileList.IsEmpty() || !updateOrderContractFileList.IsEmpty() || !updateNeedAccountingList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssOrderId",DbType.Int64,updateOrderIdList);
executionService.CreateParameter(updateSqlCmd,"@ssInvoiceId",DbType.Int64,updateInvoiceIdList);
executionService.CreateParameter(updateSqlCmd,"@ssFilename",DbType.String,updateFilenameList);
executionService.CreateParameter(updateSqlCmd,"@ssStorageId",DbType.Int64,updateStorageIdList);
executionService.CreateParameter(updateSqlCmd,"@ssDescription",DbType.String,updateDescriptionList);
executionService.CreateParameter(updateSqlCmd,"@ssNeedsApproval",DbType.Boolean,updateNeedsApprovalList);
executionService.CreateParameter(updateSqlCmd,"@ssIsApproved",DbType.Boolean,updateIsApprovedList);
executionService.CreateParameter(updateSqlCmd,"@ssIsRejected",DbType.Boolean,updateIsRejectedList);
executionService.CreateParameter(updateSqlCmd,"@ssCreatedBy",DbType.String,updateCreatedByList);
executionService.CreateParameter(updateSqlCmd,"@ssCreatedOn",DbType.DateTime,updateCreatedOnList);
executionService.CreateParameter(updateSqlCmd,"@ssUpdatedBy",DbType.String,updateUpdatedByList);
executionService.CreateParameter(updateSqlCmd,"@ssUpdatedOn",DbType.DateTime,updateUpdatedOnList);
executionService.CreateParameter(updateSqlCmd,"@ssOrderAccConceptId",DbType.Int64,updateOrderAccConceptIdList);
executionService.CreateParameter(updateSqlCmd,"@ssIsFinancialFile",DbType.Boolean,updateIsFinancialFileList);
executionService.CreateParameter(updateSqlCmd,"@ssOrderContractFile",DbType.Int64,updateOrderContractFileList);
executionService.CreateParameter(updateSqlCmd,"@ssNeedAccounting",DbType.Boolean,updateNeedAccountingList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeOrderRequestFile (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteOrderRequestFile
/// </summary>

public static async Task DeleteOrderRequestFile(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteOrderRequestFile", "733fd335-abe5-424f-9355-89e553d08310.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteOrderRequestFile", "733fd335-abe5-424f-9355-89e553d08310.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENOrderRequestFileEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteOrderRequestFile", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllOrderRequestFile
/// </summary>

public static async Task DeleteAllOrderRequestFile(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllOrderRequestFile", "733fd335-abe5-424f-9355-89e553d08310.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllOrderRequestFile", "733fd335-abe5-424f-9355-89e553d08310.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENOrderRequestFileEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteOrderRequestFile", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetOrderRequestFile
/// </summary>

public static async Task<RC_73d8126c722e2b4dd662dab2bf1a72d1> GetOrderRequestFile(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_73d8126c722e2b4dd662dab2bf1a72d1 outParamRecord = default;
outParamRecord = new RC_73d8126c722e2b4dd662dab2bf1a72d1();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetOrderRequestFile", "733fd335-abe5-424f-9355-89e553d08310.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetOrderRequestFile", "733fd335-abe5-424f-9355-89e553d08310.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@OrderId, "orderid") ?? "orderid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@Filename, "filename") ?? "filename", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@StorageId, "storageid") ?? "storageid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@Description, "description") ?? "description", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@NeedsApproval, "needsapproval") ?? "needsapproval", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@IsApproved, "isapproved") ?? "isapproved", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@IsRejected, "isrejected") ?? "isrejected", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@CreatedBy, "createdby") ?? "createdby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@CreatedOn, "createdon") ?? "createdon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@OrderAccConceptId, "orderaccconceptid") ?? "orderaccconceptid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@IsFinancialFile, "isfinancialfile") ?? "isfinancialfile", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@OrderContractFile, "ordercontractfile") ?? "ordercontractfile", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@NeedAccounting, "needaccounting") ?? "needaccounting", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
" FROM " + ENOrderRequestFileEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetOrderRequestFile", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(17,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENOrderRequestFileEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetOrderRequestFileForUpdate
/// </summary>

public static async Task<RC_73d8126c722e2b4dd662dab2bf1a72d1> GetOrderRequestFileForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_73d8126c722e2b4dd662dab2bf1a72d1 outParamRecord = default;
outParamRecord = new RC_73d8126c722e2b4dd662dab2bf1a72d1();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetOrderRequestFileForUpdate", "733fd335-abe5-424f-9355-89e553d08310.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetOrderRequestFileForUpdate", "733fd335-abe5-424f-9355-89e553d08310.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@OrderId, "orderid") ?? "orderid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@Filename, "filename") ?? "filename", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@StorageId, "storageid") ?? "storageid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@Description, "description") ?? "description", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@NeedsApproval, "needsapproval") ?? "needsapproval", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@IsApproved, "isapproved") ?? "isapproved", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@IsRejected, "isrejected") ?? "isrejected", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@CreatedBy, "createdby") ?? "createdby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@CreatedOn, "createdon") ?? "createdon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@OrderAccConceptId, "orderaccconceptid") ?? "orderaccconceptid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@IsFinancialFile, "isfinancialfile") ?? "isfinancialfile", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@OrderContractFile, "ordercontractfile") ?? "ordercontractfile", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@NeedAccounting, "needaccounting") ?? "needaccounting", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
" FROM " + ENOrderRequestFileEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetOrderRequestFileForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(17,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENOrderRequestFileEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateOrderRequestFile
/// </summary>

public static async Task UpdateOrderRequestFile(IRequestContext requestContext,BitArray usedFields,RC_73d8126c722e2b4dd662dab2bf1a72d1 inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateOrderRequestFile", "733fd335-abe5-424f-9355-89e553d08310.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateOrderRequestFile", "733fd335-abe5-424f-9355-89e553d08310.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord ssENOrderRequestFile = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(17,true);
}
string updateSet = "UPDATE " + ENOrderRequestFileEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@OrderId, "orderid") ?? "orderid") + " = @ssOrderId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + " = @ssInvoiceId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@Filename, "filename") ?? "filename") + " = @ssFilename"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@StorageId, "storageid") ?? "storageid") + " = @ssStorageId"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@Description, "description") ?? "description") + " = @ssDescription"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@NeedsApproval, "needsapproval") ?? "needsapproval") + " = @ssNeedsApproval"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@IsApproved, "isapproved") ?? "isapproved") + " = @ssIsApproved"): parameters);
parameters = (usedFields[8] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@IsRejected, "isrejected") ?? "isrejected") + " = @ssIsRejected"): parameters);
parameters = (usedFields[9] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = @ssCreatedBy"): parameters);
parameters = (usedFields[10] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = @ssCreatedOn"): parameters);
parameters = (usedFields[11] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby") + " = @ssUpdatedBy"): parameters);
parameters = (usedFields[12] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon") + " = @ssUpdatedOn"): parameters);
parameters = (usedFields[13] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@OrderAccConceptId, "orderaccconceptid") ?? "orderaccconceptid") + " = @ssOrderAccConceptId"): parameters);
parameters = (usedFields[14] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@IsFinancialFile, "isfinancialfile") ?? "isfinancialfile") + " = @ssIsFinancialFile"): parameters);
parameters = (usedFields[15] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@OrderContractFile, "ordercontractfile") ?? "ordercontractfile") + " = @ssOrderContractFile"): parameters);
parameters = (usedFields[16] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@NeedAccounting, "needaccounting") ?? "needaccounting") + " = @ssNeedAccounting"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENOrderRequestFile_ssId_OrderRequestFile";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@NeedsApproval, "needsapproval") ?? "needsapproval") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@NeedsApproval, "needsapproval") ?? "needsapproval") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssOrderId", DbType.Int64, ssENOrderRequestFile.ssOrderId);
}
if(usedFields[2]) {
if ((ssENOrderRequestFile.ssInvoiceId==0L)) {
sqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, ssENOrderRequestFile.ssInvoiceId);

}
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssFilename", DbType.String, ssENOrderRequestFile.ssFilename);
}
if(usedFields[4]) {
if ((ssENOrderRequestFile.ssStorageId==0L)) {
sqlCmd.CreateParameter("@ssStorageId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssStorageId", DbType.Int64, ssENOrderRequestFile.ssStorageId);

}
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssDescription", DbType.String, ssENOrderRequestFile.ssDescription);
}
if(usedFields[6]) {
sqlCmd.CreateParameter("@ssNeedsApproval", DbType.Boolean, ssENOrderRequestFile.ssNeedsApproval);
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssIsApproved", DbType.Boolean, ssENOrderRequestFile.ssIsApproved);
}
if(usedFields[8]) {
sqlCmd.CreateParameter("@ssIsRejected", DbType.Boolean, ssENOrderRequestFile.ssIsRejected);
}
if(usedFields[9]) {
if ((ssENOrderRequestFile.ssCreatedBy=="")) {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENOrderRequestFile.ssCreatedBy);

}
}
if(usedFields[10]) {
sqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENOrderRequestFile.ssCreatedOn);
}
if(usedFields[11]) {
if ((ssENOrderRequestFile.ssUpdatedBy=="")) {
sqlCmd.CreateParameter("@ssUpdatedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssUpdatedBy", DbType.String, ssENOrderRequestFile.ssUpdatedBy);

}
}
if(usedFields[12]) {
sqlCmd.CreateParameter("@ssUpdatedOn", DbType.DateTime, ssENOrderRequestFile.ssUpdatedOn);
}
if(usedFields[13]) {
if ((ssENOrderRequestFile.ssOrderAccConceptId==0L)) {
sqlCmd.CreateParameter("@ssOrderAccConceptId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssOrderAccConceptId", DbType.Int64, ssENOrderRequestFile.ssOrderAccConceptId);

}
}
if(usedFields[14]) {
sqlCmd.CreateParameter("@ssIsFinancialFile", DbType.Boolean, ssENOrderRequestFile.ssIsFinancialFile);
}
if(usedFields[15]) {
if ((ssENOrderRequestFile.ssOrderContractFile==0L)) {
sqlCmd.CreateParameter("@ssOrderContractFile", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssOrderContractFile", DbType.Int64, ssENOrderRequestFile.ssOrderContractFile);

}
}
if(usedFields[16]) {
sqlCmd.CreateParameter("@ssNeedAccounting", DbType.Boolean, ssENOrderRequestFile.ssNeedAccounting);
}
sqlCmd.CreateParameter("@idparam_ssENOrderRequestFile_ssId_OrderRequestFile", DbType.Int64, ssENOrderRequestFile.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateOrderRequestFile", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("OrderRequestFile", ssENOrderRequestFile.ssId.ToString()); }}
}
return;
}

}
}
