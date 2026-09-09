using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateInvoiceAccountingProcess
/// </summary>

public static async Task<long> CreateInvoiceAccountingProcess(IRequestContext requestContext,RC_d01c9a070ebc097e32a128e1b4125cc2 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateInvoiceAccountingProcess", "bae5ca58-929c-43a3-b987-c8609be5f8ef.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateInvoiceAccountingProcess", "bae5ca58-929c-43a3-b987-c8609be5f8ef.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_d21666375df829d28ffce8e5e0a3400dEntityRecord ssENInvoiceAccountingProcess = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENInvoiceAccountingProcessEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@OffsetUtc, "offsetutc") ?? "offsetutc") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@Comment, "comment") ?? "comment") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@ProcessNumber, "processnumber") ?? "processnumber") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@NextTry, "nexttry") ?? "nexttry") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@InvoiceProcessStatusId, "invoiceprocessstatusid") ?? "invoiceprocessstatusid") + "" +
" ) VALUES (" +
" @ssInvoiceId" +
", @ssRequisitionId" +
", @ssOffsetUtc" +
", @ssComment" +
", @ssProcessNumber" +
", @ssCreatedOn" +
", @ssNextTry" +
", @ssInvoiceProcessStatusId" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENInvoiceAccountingProcess.ssInvoiceId==0L)) {
insertSqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, ssENInvoiceAccountingProcess.ssInvoiceId);

}
if ((ssENInvoiceAccountingProcess.ssRequisitionId==0L)) {
insertSqlCmd.CreateParameter("@ssRequisitionId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssRequisitionId", DbType.Int64, ssENInvoiceAccountingProcess.ssRequisitionId);

}
insertSqlCmd.CreateParameter("@ssOffsetUtc", DbType.Int32, ssENInvoiceAccountingProcess.ssOffsetUtc);
insertSqlCmd.CreateParameter("@ssComment", DbType.String, ssENInvoiceAccountingProcess.ssComment);
insertSqlCmd.CreateParameter("@ssProcessNumber", DbType.Int32, ssENInvoiceAccountingProcess.ssProcessNumber);
insertSqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENInvoiceAccountingProcess.ssCreatedOn);
insertSqlCmd.CreateParameter("@ssNextTry", DbType.Int32, ssENInvoiceAccountingProcess.ssNextTry);
if ((ssENInvoiceAccountingProcess.ssInvoiceProcessStatusId==0)) {
insertSqlCmd.CreateParameter("@ssInvoiceProcessStatusId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssInvoiceProcessStatusId", DbType.Int32, ssENInvoiceAccountingProcess.ssInvoiceProcessStatusId);

}
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateInvoiceAccountingProcess", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateInvoiceAccountingProcess
/// </summary>

public static async Task<long> CreateOrUpdateInvoiceAccountingProcess(IRequestContext requestContext,BitArray usedFields,RC_d01c9a070ebc097e32a128e1b4125cc2 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateInvoiceAccountingProcess", "bae5ca58-929c-43a3-b987-c8609be5f8ef.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateInvoiceAccountingProcess", "bae5ca58-929c-43a3-b987-c8609be5f8ef.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_d21666375df829d28ffce8e5e0a3400dEntityRecord ssENInvoiceAccountingProcess = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(9,true);
}
string updateSet = "UPDATE " + ENInvoiceAccountingProcessEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + " = @ssInvoiceId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid") + " = @ssRequisitionId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@OffsetUtc, "offsetutc") ?? "offsetutc") + " = @ssOffsetUtc"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@Comment, "comment") ?? "comment") + " = @ssComment"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@ProcessNumber, "processnumber") ?? "processnumber") + " = @ssProcessNumber"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = @ssCreatedOn"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@NextTry, "nexttry") ?? "nexttry") + " = @ssNextTry"): parameters);
parameters = (usedFields[8] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@InvoiceProcessStatusId, "invoiceprocessstatusid") ?? "invoiceprocessstatusid") + " = @ssInvoiceProcessStatusId"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENInvoiceAccuntingProcess_ssd_InvoiceAccoutingProcess";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@OffsetUtc, "offsetutc") ?? "offsetutc") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@OffsetUtc, "offsetutc") ?? "offsetutc") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENInvoiceAccountingProcess.ssInvoiceId==0L)) {
sqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, ssENInvoiceAccountingProcess.ssInvoiceId);

}
}
if(usedFields[2]) {
if ((ssENInvoiceAccountingProcess.ssRequisitionId==0L)) {
sqlCmd.CreateParameter("@ssRequisitionId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssRequisitionId", DbType.Int64, ssENInvoiceAccountingProcess.ssRequisitionId);

}
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssOffsetUtc", DbType.Int32, ssENInvoiceAccountingProcess.ssOffsetUtc);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssComment", DbType.String, ssENInvoiceAccountingProcess.ssComment);
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssProcessNumber", DbType.Int32, ssENInvoiceAccountingProcess.ssProcessNumber);
}
if(usedFields[6]) {
sqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENInvoiceAccountingProcess.ssCreatedOn);
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssNextTry", DbType.Int32, ssENInvoiceAccountingProcess.ssNextTry);
}
if(usedFields[8]) {
if ((ssENInvoiceAccountingProcess.ssInvoiceProcessStatusId==0)) {
sqlCmd.CreateParameter("@ssInvoiceProcessStatusId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssInvoiceProcessStatusId", DbType.Int32, ssENInvoiceAccountingProcess.ssInvoiceProcessStatusId);

}
}
sqlCmd.CreateParameter("@idparam_ssENInvoiceAccuntingProcess_ssd_InvoiceAccoutingProcess", DbType.Int64, ssENInvoiceAccountingProcess.ssId);
int counter = 0;
if(ssENInvoiceAccountingProcess.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateInvoiceAccountingProcess (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENInvoiceAccountingProcessEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@OffsetUtc, "offsetutc") ?? "offsetutc") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@Comment, "comment") ?? "comment") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@ProcessNumber, "processnumber") ?? "processnumber") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@NextTry, "nexttry") ?? "nexttry") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@InvoiceProcessStatusId, "invoiceprocessstatusid") ?? "invoiceprocessstatusid") + "" +
" ) VALUES (" +
" @ssInvoiceId" +
", @ssRequisitionId" +
", @ssOffsetUtc" +
", @ssComment" +
", @ssProcessNumber" +
", @ssCreatedOn" +
", @ssNextTry" +
", @ssInvoiceProcessStatusId" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENInvoiceAccountingProcess.ssInvoiceId==0L)) {
insertSqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, ssENInvoiceAccountingProcess.ssInvoiceId);

}
if ((ssENInvoiceAccountingProcess.ssRequisitionId==0L)) {
insertSqlCmd.CreateParameter("@ssRequisitionId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssRequisitionId", DbType.Int64, ssENInvoiceAccountingProcess.ssRequisitionId);

}
insertSqlCmd.CreateParameter("@ssOffsetUtc", DbType.Int32, ssENInvoiceAccountingProcess.ssOffsetUtc);
insertSqlCmd.CreateParameter("@ssComment", DbType.String, ssENInvoiceAccountingProcess.ssComment);
insertSqlCmd.CreateParameter("@ssProcessNumber", DbType.Int32, ssENInvoiceAccountingProcess.ssProcessNumber);
insertSqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENInvoiceAccountingProcess.ssCreatedOn);
insertSqlCmd.CreateParameter("@ssNextTry", DbType.Int32, ssENInvoiceAccountingProcess.ssNextTry);
if ((ssENInvoiceAccountingProcess.ssInvoiceProcessStatusId==0)) {
insertSqlCmd.CreateParameter("@ssInvoiceProcessStatusId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssInvoiceProcessStatusId", DbType.Int32, ssENInvoiceAccountingProcess.ssInvoiceProcessStatusId);

}
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateInvoiceAccountingProcess", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENInvoiceAccountingProcess.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeInvoiceAccountingProcess
/// </summary>

public static async Task CreateOrUpdateSomeInvoiceAccountingProcess(IRequestContext requestContext,RL_4e909af3a15d1687c03c789af38db7ae inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeInvoiceAccountingProcess", "bae5ca58-929c-43a3-b987-c8609be5f8ef.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeInvoiceAccountingProcess", "bae5ca58-929c-43a3-b987-c8609be5f8ef.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENInvoiceAccountingProcessEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@OffsetUtc, "offsetutc") ?? "offsetutc") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@Comment, "comment") ?? "comment") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@ProcessNumber, "processnumber") ?? "processnumber") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@NextTry, "nexttry") ?? "nexttry") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@InvoiceProcessStatusId, "invoiceprocessstatusid") ?? "invoiceprocessstatusid") + ") VALUES ( unnest(@ssInvoiceId),  unnest(@ssRequisitionId),  unnest(@ssOffsetUtc),  unnest(@ssComment),  unnest(@ssProcessNumber),  unnest(@ssCreatedOn),  unnest(@ssNextTry),  unnest(@ssInvoiceProcessStatusId)) ";
insertSql += "";

string updateSql = "UPDATE " + entityTableName + " SET " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@OffsetUtc, "offsetutc") ?? "offsetutc") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@OffsetUtc, "offsetutc") ?? "offsetutc") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@Comment, "comment") ?? "comment") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@Comment, "comment") ?? "comment") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@ProcessNumber, "processnumber") ?? "processnumber") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@ProcessNumber, "processnumber") ?? "processnumber") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@NextTry, "nexttry") ?? "nexttry") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@NextTry, "nexttry") ?? "nexttry") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@InvoiceProcessStatusId, "invoiceprocessstatusid") ?? "invoiceprocessstatusid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@InvoiceProcessStatusId, "invoiceprocessstatusid") ?? "invoiceprocessstatusid") + " from ( select  unnest(@ssId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@Id, "id") ?? "id") + ",  unnest(@ssInvoiceId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + ",  unnest(@ssRequisitionId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid") + ",  unnest(@ssOffsetUtc) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@OffsetUtc, "offsetutc") ?? "offsetutc") + ",  unnest(@ssComment) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@Comment, "comment") ?? "comment") + ",  unnest(@ssProcessNumber) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@ProcessNumber, "processnumber") ?? "processnumber") + ",  unnest(@ssCreatedOn) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + ",  unnest(@ssNextTry) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@NextTry, "nexttry") ?? "nexttry") + ",  unnest(@ssInvoiceProcessStatusId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@InvoiceProcessStatusId, "invoiceprocessstatusid") ?? "invoiceprocessstatusid") + " ) as updateTable where " + entityTableName + "." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@Id, "id") ?? "id") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@Id, "id") ?? "id") + " ";
updateSql += "";

List<object> insertInvoiceIdList = new List<object>();
List<object> insertRequisitionIdList = new List<object>();
List<int> insertOffsetUtcList = new List<int>();
List<string> insertCommentList = new List<string>();
List<int> insertProcessNumberList = new List<int>();
List<DateTime> insertCreatedOnList = new List<DateTime>();
List<int> insertNextTryList = new List<int>();
List<object> insertInvoiceProcessStatusIdList = new List<object>();

List<long> updateIdList = new List<long>();
List<object> updateInvoiceIdList = new List<object>();
List<object> updateRequisitionIdList = new List<object>();
List<int> updateOffsetUtcList = new List<int>();
List<string> updateCommentList = new List<string>();
List<int> updateProcessNumberList = new List<int>();
List<DateTime> updateCreatedOnList = new List<DateTime>();
List<int> updateNextTryList = new List<int>();
List<object> updateInvoiceProcessStatusIdList = new List<object>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_d01c9a070ebc097e32a128e1b4125cc2)inParamSourceList.Current).ssENInvoiceAccountingProcess;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
if ((record.ssInvoiceId==0L)) {
updateInvoiceIdList.Add(null);
} else {
updateInvoiceIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssInvoiceId));
}
if ((record.ssRequisitionId==0L)) {
updateRequisitionIdList.Add(null);
} else {
updateRequisitionIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssRequisitionId));
}
updateOffsetUtcList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssOffsetUtc));
updateCommentList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssComment));
updateProcessNumberList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssProcessNumber));
updateCreatedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssCreatedOn));
updateNextTryList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssNextTry));
if ((record.ssInvoiceProcessStatusId==0)) {
updateInvoiceProcessStatusIdList.Add(null);
} else {
updateInvoiceProcessStatusIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssInvoiceProcessStatusId));
}
} else {
if ((record.ssInvoiceId==0L)) {
insertInvoiceIdList.Add(null);
} else {
insertInvoiceIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssInvoiceId));
}
if ((record.ssRequisitionId==0L)) {
insertRequisitionIdList.Add(null);
} else {
insertRequisitionIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssRequisitionId));
}
insertOffsetUtcList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssOffsetUtc));
insertCommentList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssComment));
insertProcessNumberList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssProcessNumber));
insertCreatedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssCreatedOn));
insertNextTryList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssNextTry));
if ((record.ssInvoiceProcessStatusId==0)) {
insertInvoiceProcessStatusIdList.Add(null);
} else {
insertInvoiceProcessStatusIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssInvoiceProcessStatusId));
}
}
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertInvoiceIdList.IsEmpty() || !insertRequisitionIdList.IsEmpty() || !insertOffsetUtcList.IsEmpty() || !insertCommentList.IsEmpty() || !insertProcessNumberList.IsEmpty() || !insertCreatedOnList.IsEmpty() || !insertNextTryList.IsEmpty() || !insertInvoiceProcessStatusIdList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssInvoiceId",DbType.Int64,insertInvoiceIdList);
executionService.CreateParameter(insertSqlCmd,"@ssRequisitionId",DbType.Int64,insertRequisitionIdList);
executionService.CreateParameter(insertSqlCmd,"@ssOffsetUtc",DbType.Int32,insertOffsetUtcList);
executionService.CreateParameter(insertSqlCmd,"@ssComment",DbType.String,insertCommentList);
executionService.CreateParameter(insertSqlCmd,"@ssProcessNumber",DbType.Int32,insertProcessNumberList);
executionService.CreateParameter(insertSqlCmd,"@ssCreatedOn",DbType.DateTime,insertCreatedOnList);
executionService.CreateParameter(insertSqlCmd,"@ssNextTry",DbType.Int32,insertNextTryList);
executionService.CreateParameter(insertSqlCmd,"@ssInvoiceProcessStatusId",DbType.Int32,insertInvoiceProcessStatusIdList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeInvoiceAccountingProcess (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateInvoiceIdList.IsEmpty() || !updateRequisitionIdList.IsEmpty() || !updateOffsetUtcList.IsEmpty() || !updateCommentList.IsEmpty() || !updateProcessNumberList.IsEmpty() || !updateCreatedOnList.IsEmpty() || !updateNextTryList.IsEmpty() || !updateInvoiceProcessStatusIdList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssInvoiceId",DbType.Int64,updateInvoiceIdList);
executionService.CreateParameter(updateSqlCmd,"@ssRequisitionId",DbType.Int64,updateRequisitionIdList);
executionService.CreateParameter(updateSqlCmd,"@ssOffsetUtc",DbType.Int32,updateOffsetUtcList);
executionService.CreateParameter(updateSqlCmd,"@ssComment",DbType.String,updateCommentList);
executionService.CreateParameter(updateSqlCmd,"@ssProcessNumber",DbType.Int32,updateProcessNumberList);
executionService.CreateParameter(updateSqlCmd,"@ssCreatedOn",DbType.DateTime,updateCreatedOnList);
executionService.CreateParameter(updateSqlCmd,"@ssNextTry",DbType.Int32,updateNextTryList);
executionService.CreateParameter(updateSqlCmd,"@ssInvoiceProcessStatusId",DbType.Int32,updateInvoiceProcessStatusIdList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeInvoiceAccountingProcess (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteInvoiceAccountingProcess
/// </summary>

public static async Task DeleteInvoiceAccountingProcess(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteInvoiceAccountingProcess", "bae5ca58-929c-43a3-b987-c8609be5f8ef.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteInvoiceAccountingProcess", "bae5ca58-929c-43a3-b987-c8609be5f8ef.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENInvoiceAccountingProcessEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteInvoiceAccountingProcess", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllInvoiceAccountingProcess
/// </summary>

public static async Task DeleteAllInvoiceAccountingProcess(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllInvoiceAccountingProcess", "bae5ca58-929c-43a3-b987-c8609be5f8ef.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllInvoiceAccountingProcess", "bae5ca58-929c-43a3-b987-c8609be5f8ef.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENInvoiceAccountingProcessEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteInvoiceAccountingProcess", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetInvoiceAccountingProcess
/// </summary>

public static async Task<RC_d01c9a070ebc097e32a128e1b4125cc2> GetInvoiceAccountingProcess(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_d01c9a070ebc097e32a128e1b4125cc2 outParamRecord = default;
outParamRecord = new RC_d01c9a070ebc097e32a128e1b4125cc2();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetInvoiceAccountingProcess", "bae5ca58-929c-43a3-b987-c8609be5f8ef.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetInvoiceAccountingProcess", "bae5ca58-929c-43a3-b987-c8609be5f8ef.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@OffsetUtc, "offsetutc") ?? "offsetutc", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@Comment, "comment") ?? "comment", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@ProcessNumber, "processnumber") ?? "processnumber", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@CreatedOn, "createdon") ?? "createdon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@NextTry, "nexttry") ?? "nexttry", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@InvoiceProcessStatusId, "invoiceprocessstatusid") ?? "invoiceprocessstatusid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
" FROM " + ENInvoiceAccountingProcessEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetInvoiceAccountingProcess", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(9,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENInvoiceAccountingProcessEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetInvoiceAccountingProcessForUpdate
/// </summary>

public static async Task<RC_d01c9a070ebc097e32a128e1b4125cc2> GetInvoiceAccountingProcessForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_d01c9a070ebc097e32a128e1b4125cc2 outParamRecord = default;
outParamRecord = new RC_d01c9a070ebc097e32a128e1b4125cc2();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetInvoiceAccountingProcessForUpdate", "bae5ca58-929c-43a3-b987-c8609be5f8ef.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetInvoiceAccountingProcessForUpdate", "bae5ca58-929c-43a3-b987-c8609be5f8ef.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@OffsetUtc, "offsetutc") ?? "offsetutc", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@Comment, "comment") ?? "comment", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@ProcessNumber, "processnumber") ?? "processnumber", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@CreatedOn, "createdon") ?? "createdon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@NextTry, "nexttry") ?? "nexttry", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@InvoiceProcessStatusId, "invoiceprocessstatusid") ?? "invoiceprocessstatusid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
" FROM " + ENInvoiceAccountingProcessEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetInvoiceAccountingProcessForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(9,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENInvoiceAccountingProcessEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateInvoiceAccountingProcess
/// </summary>

public static async Task UpdateInvoiceAccountingProcess(IRequestContext requestContext,BitArray usedFields,RC_d01c9a070ebc097e32a128e1b4125cc2 inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateInvoiceAccountingProcess", "bae5ca58-929c-43a3-b987-c8609be5f8ef.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateInvoiceAccountingProcess", "bae5ca58-929c-43a3-b987-c8609be5f8ef.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_d21666375df829d28ffce8e5e0a3400dEntityRecord ssENInvoiceAccountingProcess = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(9,true);
}
string updateSet = "UPDATE " + ENInvoiceAccountingProcessEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + " = @ssInvoiceId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid") + " = @ssRequisitionId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@OffsetUtc, "offsetutc") ?? "offsetutc") + " = @ssOffsetUtc"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@Comment, "comment") ?? "comment") + " = @ssComment"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@ProcessNumber, "processnumber") ?? "processnumber") + " = @ssProcessNumber"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = @ssCreatedOn"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@NextTry, "nexttry") ?? "nexttry") + " = @ssNextTry"): parameters);
parameters = (usedFields[8] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@InvoiceProcessStatusId, "invoiceprocessstatusid") ?? "invoiceprocessstatusid") + " = @ssInvoiceProcessStatusId"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENInvoiceAccuntingProcess_ssd_InvoiceAccoutingProcess";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@OffsetUtc, "offsetutc") ?? "offsetutc") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcess, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessAttributeKeys.@OffsetUtc, "offsetutc") ?? "offsetutc") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENInvoiceAccountingProcess.ssInvoiceId==0L)) {
sqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, ssENInvoiceAccountingProcess.ssInvoiceId);

}
}
if(usedFields[2]) {
if ((ssENInvoiceAccountingProcess.ssRequisitionId==0L)) {
sqlCmd.CreateParameter("@ssRequisitionId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssRequisitionId", DbType.Int64, ssENInvoiceAccountingProcess.ssRequisitionId);

}
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssOffsetUtc", DbType.Int32, ssENInvoiceAccountingProcess.ssOffsetUtc);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssComment", DbType.String, ssENInvoiceAccountingProcess.ssComment);
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssProcessNumber", DbType.Int32, ssENInvoiceAccountingProcess.ssProcessNumber);
}
if(usedFields[6]) {
sqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENInvoiceAccountingProcess.ssCreatedOn);
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssNextTry", DbType.Int32, ssENInvoiceAccountingProcess.ssNextTry);
}
if(usedFields[8]) {
if ((ssENInvoiceAccountingProcess.ssInvoiceProcessStatusId==0)) {
sqlCmd.CreateParameter("@ssInvoiceProcessStatusId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssInvoiceProcessStatusId", DbType.Int32, ssENInvoiceAccountingProcess.ssInvoiceProcessStatusId);

}
}
sqlCmd.CreateParameter("@idparam_ssENInvoiceAccuntingProcess_ssd_InvoiceAccoutingProcess", DbType.Int64, ssENInvoiceAccountingProcess.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateInvoiceAccountingProcess", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("InvoiceAccountingProcess", ssENInvoiceAccountingProcess.ssId.ToString()); }}
}
return;
}

}
}
