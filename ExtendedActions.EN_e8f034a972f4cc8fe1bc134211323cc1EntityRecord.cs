using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateReassignments
/// </summary>

public static async Task<long> CreateReassignments(IRequestContext requestContext,RC_c9394e1c31772209550f46c7f600d6ee inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateReassignments", "2fffdf5c-bd87-4d60-9ef0-6eeebc228bde.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateReassignments", "2fffdf5c-bd87-4d60-9ef0-6eeebc228bde.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord ssENReassignments = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENReassignmentsEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@SourceUserId, "sourceuserid") ?? "sourceuserid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@TargetUserId, "targetuserid") ?? "targetuserid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@RequisitionApprovalLevelId, "requisitionapprovallevelid") ?? "requisitionapprovallevelid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@InvoiceApprovalLevelId, "invoiceapprovallevelid") ?? "invoiceapprovallevelid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@Reason, "reason") ?? "reason") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@RevokedBy, "revokedby") ?? "revokedby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@RevokedOn, "revokedon") ?? "revokedon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@FolioId, "folioid") ?? "folioid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@FolioApprovalLevelId, "folioapprovallevelid") ?? "folioapprovallevelid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@SourceEntraRoleId, "sourceentraroleid") ?? "sourceentraroleid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@TargetEntraRoleId, "targetentraroleid") ?? "targetentraroleid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@IsFolioApprovalLevelInvoice, "isfolioapprovallevelinvoice") ?? "isfolioapprovallevelinvoice") + "" +
" ) VALUES (" +
" @ssSourceUserId" +
", @ssTargetUserId" +
", @ssRequisitionId" +
", @ssRequisitionApprovalLevelId" +
", @ssInvoiceId" +
", @ssInvoiceApprovalLevelId" +
", @ssReason" +
", @ssCreatedBy" +
", @ssCreatedOn" +
", @ssRevokedBy" +
", @ssRevokedOn" +
", @ssFolioId" +
", @ssFolioApprovalLevelId" +
", @ssSourceEntraRoleId" +
", @ssTargetEntraRoleId" +
", @ssIsFolioApprovalLevelInvoice" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENReassignments.ssSourceUserId=="")) {
insertSqlCmd.CreateParameter("@ssSourceUserId", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssSourceUserId", DbType.String, ssENReassignments.ssSourceUserId);

}
if ((ssENReassignments.ssTargetUserId=="")) {
insertSqlCmd.CreateParameter("@ssTargetUserId", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssTargetUserId", DbType.String, ssENReassignments.ssTargetUserId);

}
if ((ssENReassignments.ssRequisitionId==0L)) {
insertSqlCmd.CreateParameter("@ssRequisitionId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssRequisitionId", DbType.Int64, ssENReassignments.ssRequisitionId);

}
if ((ssENReassignments.ssRequisitionApprovalLevelId==0L)) {
insertSqlCmd.CreateParameter("@ssRequisitionApprovalLevelId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssRequisitionApprovalLevelId", DbType.Int64, ssENReassignments.ssRequisitionApprovalLevelId);

}
if ((ssENReassignments.ssInvoiceId==0L)) {
insertSqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, ssENReassignments.ssInvoiceId);

}
if ((ssENReassignments.ssInvoiceApprovalLevelId==0L)) {
insertSqlCmd.CreateParameter("@ssInvoiceApprovalLevelId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssInvoiceApprovalLevelId", DbType.Int64, ssENReassignments.ssInvoiceApprovalLevelId);

}
insertSqlCmd.CreateParameter("@ssReason", DbType.String, ssENReassignments.ssReason);
if ((ssENReassignments.ssCreatedBy=="")) {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENReassignments.ssCreatedBy);

}
insertSqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENReassignments.ssCreatedOn);
if ((ssENReassignments.ssRevokedBy=="")) {
insertSqlCmd.CreateParameter("@ssRevokedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssRevokedBy", DbType.String, ssENReassignments.ssRevokedBy);

}
insertSqlCmd.CreateParameter("@ssRevokedOn", DbType.DateTime, ssENReassignments.ssRevokedOn);
if ((ssENReassignments.ssFolioId==0L)) {
insertSqlCmd.CreateParameter("@ssFolioId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssFolioId", DbType.Int64, ssENReassignments.ssFolioId);

}
if ((ssENReassignments.ssFolioApprovalLevelId==0L)) {
insertSqlCmd.CreateParameter("@ssFolioApprovalLevelId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssFolioApprovalLevelId", DbType.Int64, ssENReassignments.ssFolioApprovalLevelId);

}
if ((ssENReassignments.ssSourceEntraRoleId==0L)) {
insertSqlCmd.CreateParameter("@ssSourceEntraRoleId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssSourceEntraRoleId", DbType.Int64, ssENReassignments.ssSourceEntraRoleId);

}
if ((ssENReassignments.ssTargetEntraRoleId==0L)) {
insertSqlCmd.CreateParameter("@ssTargetEntraRoleId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssTargetEntraRoleId", DbType.Int64, ssENReassignments.ssTargetEntraRoleId);

}
insertSqlCmd.CreateParameter("@ssIsFolioApprovalLevelInvoice", DbType.Boolean, ssENReassignments.ssIsFolioApprovalLevelInvoice);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateReassignments", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateReassignments
/// </summary>

public static async Task<long> CreateOrUpdateReassignments(IRequestContext requestContext,BitArray usedFields,RC_c9394e1c31772209550f46c7f600d6ee inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateReassignments", "2fffdf5c-bd87-4d60-9ef0-6eeebc228bde.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateReassignments", "2fffdf5c-bd87-4d60-9ef0-6eeebc228bde.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord ssENReassignments = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(17,true);
}
string updateSet = "UPDATE " + ENReassignmentsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@SourceUserId, "sourceuserid") ?? "sourceuserid") + " = @ssSourceUserId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@TargetUserId, "targetuserid") ?? "targetuserid") + " = @ssTargetUserId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid") + " = @ssRequisitionId"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@RequisitionApprovalLevelId, "requisitionapprovallevelid") ?? "requisitionapprovallevelid") + " = @ssRequisitionApprovalLevelId"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + " = @ssInvoiceId"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@InvoiceApprovalLevelId, "invoiceapprovallevelid") ?? "invoiceapprovallevelid") + " = @ssInvoiceApprovalLevelId"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@Reason, "reason") ?? "reason") + " = @ssReason"): parameters);
parameters = (usedFields[8] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = @ssCreatedBy"): parameters);
parameters = (usedFields[9] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = @ssCreatedOn"): parameters);
parameters = (usedFields[10] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@RevokedBy, "revokedby") ?? "revokedby") + " = @ssRevokedBy"): parameters);
parameters = (usedFields[11] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@RevokedOn, "revokedon") ?? "revokedon") + " = @ssRevokedOn"): parameters);
parameters = (usedFields[12] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@FolioId, "folioid") ?? "folioid") + " = @ssFolioId"): parameters);
parameters = (usedFields[13] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@FolioApprovalLevelId, "folioapprovallevelid") ?? "folioapprovallevelid") + " = @ssFolioApprovalLevelId"): parameters);
parameters = (usedFields[14] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@SourceEntraRoleId, "sourceentraroleid") ?? "sourceentraroleid") + " = @ssSourceEntraRoleId"): parameters);
parameters = (usedFields[15] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@TargetEntraRoleId, "targetentraroleid") ?? "targetentraroleid") + " = @ssTargetEntraRoleId"): parameters);
parameters = (usedFields[16] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@IsFolioApprovalLevelInvoice, "isfolioapprovallevelinvoice") ?? "isfolioapprovallevelinvoice") + " = @ssIsFolioApprovalLevelInvoice"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENReassignments_ssId_Reassignments";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@IsFolioApprovalLevelInvoice, "isfolioapprovallevelinvoice") ?? "isfolioapprovallevelinvoice") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@IsFolioApprovalLevelInvoice, "isfolioapprovallevelinvoice") ?? "isfolioapprovallevelinvoice") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENReassignments.ssSourceUserId=="")) {
sqlCmd.CreateParameter("@ssSourceUserId", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssSourceUserId", DbType.String, ssENReassignments.ssSourceUserId);

}
}
if(usedFields[2]) {
if ((ssENReassignments.ssTargetUserId=="")) {
sqlCmd.CreateParameter("@ssTargetUserId", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssTargetUserId", DbType.String, ssENReassignments.ssTargetUserId);

}
}
if(usedFields[3]) {
if ((ssENReassignments.ssRequisitionId==0L)) {
sqlCmd.CreateParameter("@ssRequisitionId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssRequisitionId", DbType.Int64, ssENReassignments.ssRequisitionId);

}
}
if(usedFields[4]) {
if ((ssENReassignments.ssRequisitionApprovalLevelId==0L)) {
sqlCmd.CreateParameter("@ssRequisitionApprovalLevelId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssRequisitionApprovalLevelId", DbType.Int64, ssENReassignments.ssRequisitionApprovalLevelId);

}
}
if(usedFields[5]) {
if ((ssENReassignments.ssInvoiceId==0L)) {
sqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, ssENReassignments.ssInvoiceId);

}
}
if(usedFields[6]) {
if ((ssENReassignments.ssInvoiceApprovalLevelId==0L)) {
sqlCmd.CreateParameter("@ssInvoiceApprovalLevelId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssInvoiceApprovalLevelId", DbType.Int64, ssENReassignments.ssInvoiceApprovalLevelId);

}
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssReason", DbType.String, ssENReassignments.ssReason);
}
if(usedFields[8]) {
if ((ssENReassignments.ssCreatedBy=="")) {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENReassignments.ssCreatedBy);

}
}
if(usedFields[9]) {
sqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENReassignments.ssCreatedOn);
}
if(usedFields[10]) {
if ((ssENReassignments.ssRevokedBy=="")) {
sqlCmd.CreateParameter("@ssRevokedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssRevokedBy", DbType.String, ssENReassignments.ssRevokedBy);

}
}
if(usedFields[11]) {
sqlCmd.CreateParameter("@ssRevokedOn", DbType.DateTime, ssENReassignments.ssRevokedOn);
}
if(usedFields[12]) {
if ((ssENReassignments.ssFolioId==0L)) {
sqlCmd.CreateParameter("@ssFolioId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssFolioId", DbType.Int64, ssENReassignments.ssFolioId);

}
}
if(usedFields[13]) {
if ((ssENReassignments.ssFolioApprovalLevelId==0L)) {
sqlCmd.CreateParameter("@ssFolioApprovalLevelId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssFolioApprovalLevelId", DbType.Int64, ssENReassignments.ssFolioApprovalLevelId);

}
}
if(usedFields[14]) {
if ((ssENReassignments.ssSourceEntraRoleId==0L)) {
sqlCmd.CreateParameter("@ssSourceEntraRoleId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssSourceEntraRoleId", DbType.Int64, ssENReassignments.ssSourceEntraRoleId);

}
}
if(usedFields[15]) {
if ((ssENReassignments.ssTargetEntraRoleId==0L)) {
sqlCmd.CreateParameter("@ssTargetEntraRoleId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssTargetEntraRoleId", DbType.Int64, ssENReassignments.ssTargetEntraRoleId);

}
}
if(usedFields[16]) {
sqlCmd.CreateParameter("@ssIsFolioApprovalLevelInvoice", DbType.Boolean, ssENReassignments.ssIsFolioApprovalLevelInvoice);
}
sqlCmd.CreateParameter("@idparam_ssENReassignments_ssId_Reassignments", DbType.Int64, ssENReassignments.ssId);
int counter = 0;
if(ssENReassignments.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateReassignments (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENReassignmentsEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@SourceUserId, "sourceuserid") ?? "sourceuserid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@TargetUserId, "targetuserid") ?? "targetuserid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@RequisitionApprovalLevelId, "requisitionapprovallevelid") ?? "requisitionapprovallevelid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@InvoiceApprovalLevelId, "invoiceapprovallevelid") ?? "invoiceapprovallevelid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@Reason, "reason") ?? "reason") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@RevokedBy, "revokedby") ?? "revokedby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@RevokedOn, "revokedon") ?? "revokedon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@FolioId, "folioid") ?? "folioid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@FolioApprovalLevelId, "folioapprovallevelid") ?? "folioapprovallevelid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@SourceEntraRoleId, "sourceentraroleid") ?? "sourceentraroleid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@TargetEntraRoleId, "targetentraroleid") ?? "targetentraroleid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@IsFolioApprovalLevelInvoice, "isfolioapprovallevelinvoice") ?? "isfolioapprovallevelinvoice") + "" +
" ) VALUES (" +
" @ssSourceUserId" +
", @ssTargetUserId" +
", @ssRequisitionId" +
", @ssRequisitionApprovalLevelId" +
", @ssInvoiceId" +
", @ssInvoiceApprovalLevelId" +
", @ssReason" +
", @ssCreatedBy" +
", @ssCreatedOn" +
", @ssRevokedBy" +
", @ssRevokedOn" +
", @ssFolioId" +
", @ssFolioApprovalLevelId" +
", @ssSourceEntraRoleId" +
", @ssTargetEntraRoleId" +
", @ssIsFolioApprovalLevelInvoice" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENReassignments.ssSourceUserId=="")) {
insertSqlCmd.CreateParameter("@ssSourceUserId", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssSourceUserId", DbType.String, ssENReassignments.ssSourceUserId);

}
if ((ssENReassignments.ssTargetUserId=="")) {
insertSqlCmd.CreateParameter("@ssTargetUserId", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssTargetUserId", DbType.String, ssENReassignments.ssTargetUserId);

}
if ((ssENReassignments.ssRequisitionId==0L)) {
insertSqlCmd.CreateParameter("@ssRequisitionId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssRequisitionId", DbType.Int64, ssENReassignments.ssRequisitionId);

}
if ((ssENReassignments.ssRequisitionApprovalLevelId==0L)) {
insertSqlCmd.CreateParameter("@ssRequisitionApprovalLevelId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssRequisitionApprovalLevelId", DbType.Int64, ssENReassignments.ssRequisitionApprovalLevelId);

}
if ((ssENReassignments.ssInvoiceId==0L)) {
insertSqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, ssENReassignments.ssInvoiceId);

}
if ((ssENReassignments.ssInvoiceApprovalLevelId==0L)) {
insertSqlCmd.CreateParameter("@ssInvoiceApprovalLevelId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssInvoiceApprovalLevelId", DbType.Int64, ssENReassignments.ssInvoiceApprovalLevelId);

}
insertSqlCmd.CreateParameter("@ssReason", DbType.String, ssENReassignments.ssReason);
if ((ssENReassignments.ssCreatedBy=="")) {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENReassignments.ssCreatedBy);

}
insertSqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENReassignments.ssCreatedOn);
if ((ssENReassignments.ssRevokedBy=="")) {
insertSqlCmd.CreateParameter("@ssRevokedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssRevokedBy", DbType.String, ssENReassignments.ssRevokedBy);

}
insertSqlCmd.CreateParameter("@ssRevokedOn", DbType.DateTime, ssENReassignments.ssRevokedOn);
if ((ssENReassignments.ssFolioId==0L)) {
insertSqlCmd.CreateParameter("@ssFolioId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssFolioId", DbType.Int64, ssENReassignments.ssFolioId);

}
if ((ssENReassignments.ssFolioApprovalLevelId==0L)) {
insertSqlCmd.CreateParameter("@ssFolioApprovalLevelId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssFolioApprovalLevelId", DbType.Int64, ssENReassignments.ssFolioApprovalLevelId);

}
if ((ssENReassignments.ssSourceEntraRoleId==0L)) {
insertSqlCmd.CreateParameter("@ssSourceEntraRoleId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssSourceEntraRoleId", DbType.Int64, ssENReassignments.ssSourceEntraRoleId);

}
if ((ssENReassignments.ssTargetEntraRoleId==0L)) {
insertSqlCmd.CreateParameter("@ssTargetEntraRoleId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssTargetEntraRoleId", DbType.Int64, ssENReassignments.ssTargetEntraRoleId);

}
insertSqlCmd.CreateParameter("@ssIsFolioApprovalLevelInvoice", DbType.Boolean, ssENReassignments.ssIsFolioApprovalLevelInvoice);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateReassignments", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENReassignments.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeReassignments
/// </summary>

public static async Task CreateOrUpdateSomeReassignments(IRequestContext requestContext,RL_462b16c1ddedb19ce2dbad5e94ccb4ef inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeReassignments", "2fffdf5c-bd87-4d60-9ef0-6eeebc228bde.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeReassignments", "2fffdf5c-bd87-4d60-9ef0-6eeebc228bde.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENReassignmentsEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@SourceUserId, "sourceuserid") ?? "sourceuserid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@TargetUserId, "targetuserid") ?? "targetuserid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@RequisitionApprovalLevelId, "requisitionapprovallevelid") ?? "requisitionapprovallevelid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@InvoiceApprovalLevelId, "invoiceapprovallevelid") ?? "invoiceapprovallevelid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@Reason, "reason") ?? "reason") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@RevokedBy, "revokedby") ?? "revokedby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@RevokedOn, "revokedon") ?? "revokedon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@FolioId, "folioid") ?? "folioid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@FolioApprovalLevelId, "folioapprovallevelid") ?? "folioapprovallevelid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@SourceEntraRoleId, "sourceentraroleid") ?? "sourceentraroleid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@TargetEntraRoleId, "targetentraroleid") ?? "targetentraroleid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@IsFolioApprovalLevelInvoice, "isfolioapprovallevelinvoice") ?? "isfolioapprovallevelinvoice") + ") VALUES ( unnest(@ssSourceUserId),  unnest(@ssTargetUserId),  unnest(@ssRequisitionId),  unnest(@ssRequisitionApprovalLevelId),  unnest(@ssInvoiceId),  unnest(@ssInvoiceApprovalLevelId),  unnest(@ssReason),  unnest(@ssCreatedBy),  unnest(@ssCreatedOn),  unnest(@ssRevokedBy),  unnest(@ssRevokedOn),  unnest(@ssFolioId),  unnest(@ssFolioApprovalLevelId),  unnest(@ssSourceEntraRoleId),  unnest(@ssTargetEntraRoleId),  unnest(@ssIsFolioApprovalLevelInvoice)) ";
insertSql += "";

string updateSql = "UPDATE " + entityTableName + " SET " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@SourceUserId, "sourceuserid") ?? "sourceuserid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@SourceUserId, "sourceuserid") ?? "sourceuserid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@TargetUserId, "targetuserid") ?? "targetuserid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@TargetUserId, "targetuserid") ?? "targetuserid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@RequisitionApprovalLevelId, "requisitionapprovallevelid") ?? "requisitionapprovallevelid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@RequisitionApprovalLevelId, "requisitionapprovallevelid") ?? "requisitionapprovallevelid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@InvoiceApprovalLevelId, "invoiceapprovallevelid") ?? "invoiceapprovallevelid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@InvoiceApprovalLevelId, "invoiceapprovallevelid") ?? "invoiceapprovallevelid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@Reason, "reason") ?? "reason") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@Reason, "reason") ?? "reason") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@RevokedBy, "revokedby") ?? "revokedby") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@RevokedBy, "revokedby") ?? "revokedby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@RevokedOn, "revokedon") ?? "revokedon") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@RevokedOn, "revokedon") ?? "revokedon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@FolioId, "folioid") ?? "folioid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@FolioId, "folioid") ?? "folioid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@FolioApprovalLevelId, "folioapprovallevelid") ?? "folioapprovallevelid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@FolioApprovalLevelId, "folioapprovallevelid") ?? "folioapprovallevelid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@SourceEntraRoleId, "sourceentraroleid") ?? "sourceentraroleid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@SourceEntraRoleId, "sourceentraroleid") ?? "sourceentraroleid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@TargetEntraRoleId, "targetentraroleid") ?? "targetentraroleid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@TargetEntraRoleId, "targetentraroleid") ?? "targetentraroleid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@IsFolioApprovalLevelInvoice, "isfolioapprovallevelinvoice") ?? "isfolioapprovallevelinvoice") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@IsFolioApprovalLevelInvoice, "isfolioapprovallevelinvoice") ?? "isfolioapprovallevelinvoice") + " from ( select  unnest(@ssId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@Id, "id") ?? "id") + ",  unnest(@ssSourceUserId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@SourceUserId, "sourceuserid") ?? "sourceuserid") + ",  unnest(@ssTargetUserId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@TargetUserId, "targetuserid") ?? "targetuserid") + ",  unnest(@ssRequisitionId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid") + ",  unnest(@ssRequisitionApprovalLevelId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@RequisitionApprovalLevelId, "requisitionapprovallevelid") ?? "requisitionapprovallevelid") + ",  unnest(@ssInvoiceId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + ",  unnest(@ssInvoiceApprovalLevelId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@InvoiceApprovalLevelId, "invoiceapprovallevelid") ?? "invoiceapprovallevelid") + ",  unnest(@ssReason) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@Reason, "reason") ?? "reason") + ",  unnest(@ssCreatedBy) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ",  unnest(@ssCreatedOn) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + ",  unnest(@ssRevokedBy) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@RevokedBy, "revokedby") ?? "revokedby") + ",  unnest(@ssRevokedOn) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@RevokedOn, "revokedon") ?? "revokedon") + ",  unnest(@ssFolioId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@FolioId, "folioid") ?? "folioid") + ",  unnest(@ssFolioApprovalLevelId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@FolioApprovalLevelId, "folioapprovallevelid") ?? "folioapprovallevelid") + ",  unnest(@ssSourceEntraRoleId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@SourceEntraRoleId, "sourceentraroleid") ?? "sourceentraroleid") + ",  unnest(@ssTargetEntraRoleId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@TargetEntraRoleId, "targetentraroleid") ?? "targetentraroleid") + ",  unnest(@ssIsFolioApprovalLevelInvoice) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@IsFolioApprovalLevelInvoice, "isfolioapprovallevelinvoice") ?? "isfolioapprovallevelinvoice") + " ) as updateTable where " + entityTableName + "." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@Id, "id") ?? "id") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@Id, "id") ?? "id") + " ";
updateSql += "";

List<object> insertSourceUserIdList = new List<object>();
List<object> insertTargetUserIdList = new List<object>();
List<object> insertRequisitionIdList = new List<object>();
List<object> insertRequisitionApprovalLevelIdList = new List<object>();
List<object> insertInvoiceIdList = new List<object>();
List<object> insertInvoiceApprovalLevelIdList = new List<object>();
List<string> insertReasonList = new List<string>();
List<object> insertCreatedByList = new List<object>();
List<DateTime> insertCreatedOnList = new List<DateTime>();
List<object> insertRevokedByList = new List<object>();
List<DateTime> insertRevokedOnList = new List<DateTime>();
List<object> insertFolioIdList = new List<object>();
List<object> insertFolioApprovalLevelIdList = new List<object>();
List<object> insertSourceEntraRoleIdList = new List<object>();
List<object> insertTargetEntraRoleIdList = new List<object>();
List<bool> insertIsFolioApprovalLevelInvoiceList = new List<bool>();

List<long> updateIdList = new List<long>();
List<object> updateSourceUserIdList = new List<object>();
List<object> updateTargetUserIdList = new List<object>();
List<object> updateRequisitionIdList = new List<object>();
List<object> updateRequisitionApprovalLevelIdList = new List<object>();
List<object> updateInvoiceIdList = new List<object>();
List<object> updateInvoiceApprovalLevelIdList = new List<object>();
List<string> updateReasonList = new List<string>();
List<object> updateCreatedByList = new List<object>();
List<DateTime> updateCreatedOnList = new List<DateTime>();
List<object> updateRevokedByList = new List<object>();
List<DateTime> updateRevokedOnList = new List<DateTime>();
List<object> updateFolioIdList = new List<object>();
List<object> updateFolioApprovalLevelIdList = new List<object>();
List<object> updateSourceEntraRoleIdList = new List<object>();
List<object> updateTargetEntraRoleIdList = new List<object>();
List<bool> updateIsFolioApprovalLevelInvoiceList = new List<bool>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_c9394e1c31772209550f46c7f600d6ee)inParamSourceList.Current).ssENReassignments;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
if ((record.ssSourceUserId=="")) {
updateSourceUserIdList.Add(null);
} else {
updateSourceUserIdList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssSourceUserId));
}
if ((record.ssTargetUserId=="")) {
updateTargetUserIdList.Add(null);
} else {
updateTargetUserIdList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssTargetUserId));
}
if ((record.ssRequisitionId==0L)) {
updateRequisitionIdList.Add(null);
} else {
updateRequisitionIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssRequisitionId));
}
if ((record.ssRequisitionApprovalLevelId==0L)) {
updateRequisitionApprovalLevelIdList.Add(null);
} else {
updateRequisitionApprovalLevelIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssRequisitionApprovalLevelId));
}
if ((record.ssInvoiceId==0L)) {
updateInvoiceIdList.Add(null);
} else {
updateInvoiceIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssInvoiceId));
}
if ((record.ssInvoiceApprovalLevelId==0L)) {
updateInvoiceApprovalLevelIdList.Add(null);
} else {
updateInvoiceApprovalLevelIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssInvoiceApprovalLevelId));
}
updateReasonList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssReason));
if ((record.ssCreatedBy=="")) {
updateCreatedByList.Add(null);
} else {
updateCreatedByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCreatedBy));
}
updateCreatedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssCreatedOn));
if ((record.ssRevokedBy=="")) {
updateRevokedByList.Add(null);
} else {
updateRevokedByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssRevokedBy));
}
updateRevokedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssRevokedOn));
if ((record.ssFolioId==0L)) {
updateFolioIdList.Add(null);
} else {
updateFolioIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssFolioId));
}
if ((record.ssFolioApprovalLevelId==0L)) {
updateFolioApprovalLevelIdList.Add(null);
} else {
updateFolioApprovalLevelIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssFolioApprovalLevelId));
}
if ((record.ssSourceEntraRoleId==0L)) {
updateSourceEntraRoleIdList.Add(null);
} else {
updateSourceEntraRoleIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssSourceEntraRoleId));
}
if ((record.ssTargetEntraRoleId==0L)) {
updateTargetEntraRoleIdList.Add(null);
} else {
updateTargetEntraRoleIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssTargetEntraRoleId));
}
updateIsFolioApprovalLevelInvoiceList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsFolioApprovalLevelInvoice));
} else {
if ((record.ssSourceUserId=="")) {
insertSourceUserIdList.Add(null);
} else {
insertSourceUserIdList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssSourceUserId));
}
if ((record.ssTargetUserId=="")) {
insertTargetUserIdList.Add(null);
} else {
insertTargetUserIdList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssTargetUserId));
}
if ((record.ssRequisitionId==0L)) {
insertRequisitionIdList.Add(null);
} else {
insertRequisitionIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssRequisitionId));
}
if ((record.ssRequisitionApprovalLevelId==0L)) {
insertRequisitionApprovalLevelIdList.Add(null);
} else {
insertRequisitionApprovalLevelIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssRequisitionApprovalLevelId));
}
if ((record.ssInvoiceId==0L)) {
insertInvoiceIdList.Add(null);
} else {
insertInvoiceIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssInvoiceId));
}
if ((record.ssInvoiceApprovalLevelId==0L)) {
insertInvoiceApprovalLevelIdList.Add(null);
} else {
insertInvoiceApprovalLevelIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssInvoiceApprovalLevelId));
}
insertReasonList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssReason));
if ((record.ssCreatedBy=="")) {
insertCreatedByList.Add(null);
} else {
insertCreatedByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCreatedBy));
}
insertCreatedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssCreatedOn));
if ((record.ssRevokedBy=="")) {
insertRevokedByList.Add(null);
} else {
insertRevokedByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssRevokedBy));
}
insertRevokedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssRevokedOn));
if ((record.ssFolioId==0L)) {
insertFolioIdList.Add(null);
} else {
insertFolioIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssFolioId));
}
if ((record.ssFolioApprovalLevelId==0L)) {
insertFolioApprovalLevelIdList.Add(null);
} else {
insertFolioApprovalLevelIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssFolioApprovalLevelId));
}
if ((record.ssSourceEntraRoleId==0L)) {
insertSourceEntraRoleIdList.Add(null);
} else {
insertSourceEntraRoleIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssSourceEntraRoleId));
}
if ((record.ssTargetEntraRoleId==0L)) {
insertTargetEntraRoleIdList.Add(null);
} else {
insertTargetEntraRoleIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssTargetEntraRoleId));
}
insertIsFolioApprovalLevelInvoiceList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsFolioApprovalLevelInvoice));
}
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertSourceUserIdList.IsEmpty() || !insertTargetUserIdList.IsEmpty() || !insertRequisitionIdList.IsEmpty() || !insertRequisitionApprovalLevelIdList.IsEmpty() || !insertInvoiceIdList.IsEmpty() || !insertInvoiceApprovalLevelIdList.IsEmpty() || !insertReasonList.IsEmpty() || !insertCreatedByList.IsEmpty() || !insertCreatedOnList.IsEmpty() || !insertRevokedByList.IsEmpty() || !insertRevokedOnList.IsEmpty() || !insertFolioIdList.IsEmpty() || !insertFolioApprovalLevelIdList.IsEmpty() || !insertSourceEntraRoleIdList.IsEmpty() || !insertTargetEntraRoleIdList.IsEmpty() || !insertIsFolioApprovalLevelInvoiceList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssSourceUserId",DbType.String,insertSourceUserIdList);
executionService.CreateParameter(insertSqlCmd,"@ssTargetUserId",DbType.String,insertTargetUserIdList);
executionService.CreateParameter(insertSqlCmd,"@ssRequisitionId",DbType.Int64,insertRequisitionIdList);
executionService.CreateParameter(insertSqlCmd,"@ssRequisitionApprovalLevelId",DbType.Int64,insertRequisitionApprovalLevelIdList);
executionService.CreateParameter(insertSqlCmd,"@ssInvoiceId",DbType.Int64,insertInvoiceIdList);
executionService.CreateParameter(insertSqlCmd,"@ssInvoiceApprovalLevelId",DbType.Int64,insertInvoiceApprovalLevelIdList);
executionService.CreateParameter(insertSqlCmd,"@ssReason",DbType.String,insertReasonList);
executionService.CreateParameter(insertSqlCmd,"@ssCreatedBy",DbType.String,insertCreatedByList);
executionService.CreateParameter(insertSqlCmd,"@ssCreatedOn",DbType.DateTime,insertCreatedOnList);
executionService.CreateParameter(insertSqlCmd,"@ssRevokedBy",DbType.String,insertRevokedByList);
executionService.CreateParameter(insertSqlCmd,"@ssRevokedOn",DbType.DateTime,insertRevokedOnList);
executionService.CreateParameter(insertSqlCmd,"@ssFolioId",DbType.Int64,insertFolioIdList);
executionService.CreateParameter(insertSqlCmd,"@ssFolioApprovalLevelId",DbType.Int64,insertFolioApprovalLevelIdList);
executionService.CreateParameter(insertSqlCmd,"@ssSourceEntraRoleId",DbType.Int64,insertSourceEntraRoleIdList);
executionService.CreateParameter(insertSqlCmd,"@ssTargetEntraRoleId",DbType.Int64,insertTargetEntraRoleIdList);
executionService.CreateParameter(insertSqlCmd,"@ssIsFolioApprovalLevelInvoice",DbType.Boolean,insertIsFolioApprovalLevelInvoiceList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeReassignments (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateSourceUserIdList.IsEmpty() || !updateTargetUserIdList.IsEmpty() || !updateRequisitionIdList.IsEmpty() || !updateRequisitionApprovalLevelIdList.IsEmpty() || !updateInvoiceIdList.IsEmpty() || !updateInvoiceApprovalLevelIdList.IsEmpty() || !updateReasonList.IsEmpty() || !updateCreatedByList.IsEmpty() || !updateCreatedOnList.IsEmpty() || !updateRevokedByList.IsEmpty() || !updateRevokedOnList.IsEmpty() || !updateFolioIdList.IsEmpty() || !updateFolioApprovalLevelIdList.IsEmpty() || !updateSourceEntraRoleIdList.IsEmpty() || !updateTargetEntraRoleIdList.IsEmpty() || !updateIsFolioApprovalLevelInvoiceList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssSourceUserId",DbType.String,updateSourceUserIdList);
executionService.CreateParameter(updateSqlCmd,"@ssTargetUserId",DbType.String,updateTargetUserIdList);
executionService.CreateParameter(updateSqlCmd,"@ssRequisitionId",DbType.Int64,updateRequisitionIdList);
executionService.CreateParameter(updateSqlCmd,"@ssRequisitionApprovalLevelId",DbType.Int64,updateRequisitionApprovalLevelIdList);
executionService.CreateParameter(updateSqlCmd,"@ssInvoiceId",DbType.Int64,updateInvoiceIdList);
executionService.CreateParameter(updateSqlCmd,"@ssInvoiceApprovalLevelId",DbType.Int64,updateInvoiceApprovalLevelIdList);
executionService.CreateParameter(updateSqlCmd,"@ssReason",DbType.String,updateReasonList);
executionService.CreateParameter(updateSqlCmd,"@ssCreatedBy",DbType.String,updateCreatedByList);
executionService.CreateParameter(updateSqlCmd,"@ssCreatedOn",DbType.DateTime,updateCreatedOnList);
executionService.CreateParameter(updateSqlCmd,"@ssRevokedBy",DbType.String,updateRevokedByList);
executionService.CreateParameter(updateSqlCmd,"@ssRevokedOn",DbType.DateTime,updateRevokedOnList);
executionService.CreateParameter(updateSqlCmd,"@ssFolioId",DbType.Int64,updateFolioIdList);
executionService.CreateParameter(updateSqlCmd,"@ssFolioApprovalLevelId",DbType.Int64,updateFolioApprovalLevelIdList);
executionService.CreateParameter(updateSqlCmd,"@ssSourceEntraRoleId",DbType.Int64,updateSourceEntraRoleIdList);
executionService.CreateParameter(updateSqlCmd,"@ssTargetEntraRoleId",DbType.Int64,updateTargetEntraRoleIdList);
executionService.CreateParameter(updateSqlCmd,"@ssIsFolioApprovalLevelInvoice",DbType.Boolean,updateIsFolioApprovalLevelInvoiceList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeReassignments (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteReassignments
/// </summary>

public static async Task DeleteReassignments(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteReassignments", "2fffdf5c-bd87-4d60-9ef0-6eeebc228bde.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteReassignments", "2fffdf5c-bd87-4d60-9ef0-6eeebc228bde.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENReassignmentsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteReassignments", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllReassignments
/// </summary>

public static async Task DeleteAllReassignments(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllReassignments", "2fffdf5c-bd87-4d60-9ef0-6eeebc228bde.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllReassignments", "2fffdf5c-bd87-4d60-9ef0-6eeebc228bde.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENReassignmentsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteReassignments", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetReassignments
/// </summary>

public static async Task<RC_c9394e1c31772209550f46c7f600d6ee> GetReassignments(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_c9394e1c31772209550f46c7f600d6ee outParamRecord = default;
outParamRecord = new RC_c9394e1c31772209550f46c7f600d6ee();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetReassignments", "2fffdf5c-bd87-4d60-9ef0-6eeebc228bde.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetReassignments", "2fffdf5c-bd87-4d60-9ef0-6eeebc228bde.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@SourceUserId, "sourceuserid") ?? "sourceuserid", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@TargetUserId, "targetuserid") ?? "targetuserid", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@RequisitionApprovalLevelId, "requisitionapprovallevelid") ?? "requisitionapprovallevelid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@InvoiceApprovalLevelId, "invoiceapprovallevelid") ?? "invoiceapprovallevelid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@Reason, "reason") ?? "reason", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@CreatedBy, "createdby") ?? "createdby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@CreatedOn, "createdon") ?? "createdon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@RevokedBy, "revokedby") ?? "revokedby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@RevokedOn, "revokedon") ?? "revokedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@FolioId, "folioid") ?? "folioid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@FolioApprovalLevelId, "folioapprovallevelid") ?? "folioapprovallevelid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@SourceEntraRoleId, "sourceentraroleid") ?? "sourceentraroleid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@TargetEntraRoleId, "targetentraroleid") ?? "targetentraroleid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@IsFolioApprovalLevelInvoice, "isfolioapprovallevelinvoice") ?? "isfolioapprovallevelinvoice", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
" FROM " + ENReassignmentsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetReassignments", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(17,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENReassignmentsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetReassignmentsForUpdate
/// </summary>

public static async Task<RC_c9394e1c31772209550f46c7f600d6ee> GetReassignmentsForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_c9394e1c31772209550f46c7f600d6ee outParamRecord = default;
outParamRecord = new RC_c9394e1c31772209550f46c7f600d6ee();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetReassignmentsForUpdate", "2fffdf5c-bd87-4d60-9ef0-6eeebc228bde.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetReassignmentsForUpdate", "2fffdf5c-bd87-4d60-9ef0-6eeebc228bde.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@SourceUserId, "sourceuserid") ?? "sourceuserid", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@TargetUserId, "targetuserid") ?? "targetuserid", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@RequisitionApprovalLevelId, "requisitionapprovallevelid") ?? "requisitionapprovallevelid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@InvoiceApprovalLevelId, "invoiceapprovallevelid") ?? "invoiceapprovallevelid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@Reason, "reason") ?? "reason", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@CreatedBy, "createdby") ?? "createdby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@CreatedOn, "createdon") ?? "createdon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@RevokedBy, "revokedby") ?? "revokedby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@RevokedOn, "revokedon") ?? "revokedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@FolioId, "folioid") ?? "folioid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@FolioApprovalLevelId, "folioapprovallevelid") ?? "folioapprovallevelid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@SourceEntraRoleId, "sourceentraroleid") ?? "sourceentraroleid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@TargetEntraRoleId, "targetentraroleid") ?? "targetentraroleid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@IsFolioApprovalLevelInvoice, "isfolioapprovallevelinvoice") ?? "isfolioapprovallevelinvoice", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
" FROM " + ENReassignmentsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetReassignmentsForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(17,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENReassignmentsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateReassignments
/// </summary>

public static async Task UpdateReassignments(IRequestContext requestContext,BitArray usedFields,RC_c9394e1c31772209550f46c7f600d6ee inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateReassignments", "2fffdf5c-bd87-4d60-9ef0-6eeebc228bde.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateReassignments", "2fffdf5c-bd87-4d60-9ef0-6eeebc228bde.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord ssENReassignments = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(17,true);
}
string updateSet = "UPDATE " + ENReassignmentsEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@SourceUserId, "sourceuserid") ?? "sourceuserid") + " = @ssSourceUserId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@TargetUserId, "targetuserid") ?? "targetuserid") + " = @ssTargetUserId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid") + " = @ssRequisitionId"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@RequisitionApprovalLevelId, "requisitionapprovallevelid") ?? "requisitionapprovallevelid") + " = @ssRequisitionApprovalLevelId"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + " = @ssInvoiceId"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@InvoiceApprovalLevelId, "invoiceapprovallevelid") ?? "invoiceapprovallevelid") + " = @ssInvoiceApprovalLevelId"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@Reason, "reason") ?? "reason") + " = @ssReason"): parameters);
parameters = (usedFields[8] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = @ssCreatedBy"): parameters);
parameters = (usedFields[9] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = @ssCreatedOn"): parameters);
parameters = (usedFields[10] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@RevokedBy, "revokedby") ?? "revokedby") + " = @ssRevokedBy"): parameters);
parameters = (usedFields[11] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@RevokedOn, "revokedon") ?? "revokedon") + " = @ssRevokedOn"): parameters);
parameters = (usedFields[12] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@FolioId, "folioid") ?? "folioid") + " = @ssFolioId"): parameters);
parameters = (usedFields[13] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@FolioApprovalLevelId, "folioapprovallevelid") ?? "folioapprovallevelid") + " = @ssFolioApprovalLevelId"): parameters);
parameters = (usedFields[14] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@SourceEntraRoleId, "sourceentraroleid") ?? "sourceentraroleid") + " = @ssSourceEntraRoleId"): parameters);
parameters = (usedFields[15] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@TargetEntraRoleId, "targetentraroleid") ?? "targetentraroleid") + " = @ssTargetEntraRoleId"): parameters);
parameters = (usedFields[16] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@IsFolioApprovalLevelInvoice, "isfolioapprovallevelinvoice") ?? "isfolioapprovallevelinvoice") + " = @ssIsFolioApprovalLevelInvoice"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENReassignments_ssId_Reassignments";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@IsFolioApprovalLevelInvoice, "isfolioapprovallevelinvoice") ?? "isfolioapprovallevelinvoice") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@IsFolioApprovalLevelInvoice, "isfolioapprovallevelinvoice") ?? "isfolioapprovallevelinvoice") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENReassignments.ssSourceUserId=="")) {
sqlCmd.CreateParameter("@ssSourceUserId", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssSourceUserId", DbType.String, ssENReassignments.ssSourceUserId);

}
}
if(usedFields[2]) {
if ((ssENReassignments.ssTargetUserId=="")) {
sqlCmd.CreateParameter("@ssTargetUserId", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssTargetUserId", DbType.String, ssENReassignments.ssTargetUserId);

}
}
if(usedFields[3]) {
if ((ssENReassignments.ssRequisitionId==0L)) {
sqlCmd.CreateParameter("@ssRequisitionId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssRequisitionId", DbType.Int64, ssENReassignments.ssRequisitionId);

}
}
if(usedFields[4]) {
if ((ssENReassignments.ssRequisitionApprovalLevelId==0L)) {
sqlCmd.CreateParameter("@ssRequisitionApprovalLevelId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssRequisitionApprovalLevelId", DbType.Int64, ssENReassignments.ssRequisitionApprovalLevelId);

}
}
if(usedFields[5]) {
if ((ssENReassignments.ssInvoiceId==0L)) {
sqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, ssENReassignments.ssInvoiceId);

}
}
if(usedFields[6]) {
if ((ssENReassignments.ssInvoiceApprovalLevelId==0L)) {
sqlCmd.CreateParameter("@ssInvoiceApprovalLevelId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssInvoiceApprovalLevelId", DbType.Int64, ssENReassignments.ssInvoiceApprovalLevelId);

}
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssReason", DbType.String, ssENReassignments.ssReason);
}
if(usedFields[8]) {
if ((ssENReassignments.ssCreatedBy=="")) {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENReassignments.ssCreatedBy);

}
}
if(usedFields[9]) {
sqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENReassignments.ssCreatedOn);
}
if(usedFields[10]) {
if ((ssENReassignments.ssRevokedBy=="")) {
sqlCmd.CreateParameter("@ssRevokedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssRevokedBy", DbType.String, ssENReassignments.ssRevokedBy);

}
}
if(usedFields[11]) {
sqlCmd.CreateParameter("@ssRevokedOn", DbType.DateTime, ssENReassignments.ssRevokedOn);
}
if(usedFields[12]) {
if ((ssENReassignments.ssFolioId==0L)) {
sqlCmd.CreateParameter("@ssFolioId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssFolioId", DbType.Int64, ssENReassignments.ssFolioId);

}
}
if(usedFields[13]) {
if ((ssENReassignments.ssFolioApprovalLevelId==0L)) {
sqlCmd.CreateParameter("@ssFolioApprovalLevelId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssFolioApprovalLevelId", DbType.Int64, ssENReassignments.ssFolioApprovalLevelId);

}
}
if(usedFields[14]) {
if ((ssENReassignments.ssSourceEntraRoleId==0L)) {
sqlCmd.CreateParameter("@ssSourceEntraRoleId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssSourceEntraRoleId", DbType.Int64, ssENReassignments.ssSourceEntraRoleId);

}
}
if(usedFields[15]) {
if ((ssENReassignments.ssTargetEntraRoleId==0L)) {
sqlCmd.CreateParameter("@ssTargetEntraRoleId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssTargetEntraRoleId", DbType.Int64, ssENReassignments.ssTargetEntraRoleId);

}
}
if(usedFields[16]) {
sqlCmd.CreateParameter("@ssIsFolioApprovalLevelInvoice", DbType.Boolean, ssENReassignments.ssIsFolioApprovalLevelInvoice);
}
sqlCmd.CreateParameter("@idparam_ssENReassignments_ssId_Reassignments", DbType.Int64, ssENReassignments.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateReassignments", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("Reassignments", ssENReassignments.ssId.ToString()); }}
}
return;
}

}
}
