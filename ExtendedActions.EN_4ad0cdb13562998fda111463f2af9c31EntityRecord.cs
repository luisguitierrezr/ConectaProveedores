using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateOrderDistributionConfig
/// </summary>

public static async Task<long> CreateOrderDistributionConfig(IRequestContext requestContext,RC_9fc59bda41db740ae87f91f135d24811 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrderDistributionConfig", "01fcf30b-f254-4516-ae45-70f39509dc63.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrderDistributionConfig", "01fcf30b-f254-4516-ae45-70f39509dc63.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_4ad0cdb13562998fda111463f2af9c31EntityRecord ssENOrderDistributionConfig = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENOrderDistributionConfigEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@RegionId, "regionid") ?? "regionid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@Applicant, "applicant") ?? "applicant") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@ApplicantDescription, "applicantdescription") ?? "applicantdescription") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@DirectionId, "directionid") ?? "directionid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@FirstContact_EntraRoleId, "firstcontact_entraroleid") ?? "firstcontact_entraroleid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@SecondContact_EntraRoleId, "secondcontact_entraroleid") ?? "secondcontact_entraroleid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@FirstApprover_EntraRoleId, "firstapprover_entraroleid") ?? "firstapprover_entraroleid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@SecondApprover_EntraRoleId, "secondapprover_entraroleid") ?? "secondapprover_entraroleid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon") + "" +
" ) VALUES (" +
" @ssRegionId" +
", @ssApplicant" +
", @ssApplicantDescription" +
", @ssDirectionId" +
", @ssFirstContact_EntraRoleId" +
", @ssSecondContact_EntraRoleId" +
", @ssFirstApprover_EntraRoleId" +
", @ssSecondApprover_EntraRoleId" +
", @ssCreatedBy" +
", @ssCreatedOn" +
", @ssUpdatedBy" +
", @ssUpdatedOn" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENOrderDistributionConfig.ssRegionId==0L)) {
insertSqlCmd.CreateParameter("@ssRegionId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssRegionId", DbType.Int64, ssENOrderDistributionConfig.ssRegionId);

}
insertSqlCmd.CreateParameter("@ssApplicant", DbType.String, ssENOrderDistributionConfig.ssApplicant);
insertSqlCmd.CreateParameter("@ssApplicantDescription", DbType.String, ssENOrderDistributionConfig.ssApplicantDescription);
if ((ssENOrderDistributionConfig.ssDirectionId==0L)) {
insertSqlCmd.CreateParameter("@ssDirectionId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssDirectionId", DbType.Int64, ssENOrderDistributionConfig.ssDirectionId);

}
if ((ssENOrderDistributionConfig.ssFirstContact_EntraRoleId==0L)) {
insertSqlCmd.CreateParameter("@ssFirstContact_EntraRoleId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssFirstContact_EntraRoleId", DbType.Int64, ssENOrderDistributionConfig.ssFirstContact_EntraRoleId);

}
if ((ssENOrderDistributionConfig.ssSecondContact_EntraRoleId==0L)) {
insertSqlCmd.CreateParameter("@ssSecondContact_EntraRoleId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssSecondContact_EntraRoleId", DbType.Int64, ssENOrderDistributionConfig.ssSecondContact_EntraRoleId);

}
if ((ssENOrderDistributionConfig.ssFirstApprover_EntraRoleId==0L)) {
insertSqlCmd.CreateParameter("@ssFirstApprover_EntraRoleId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssFirstApprover_EntraRoleId", DbType.Int64, ssENOrderDistributionConfig.ssFirstApprover_EntraRoleId);

}
if ((ssENOrderDistributionConfig.ssSecondApprover_EntraRoleId==0L)) {
insertSqlCmd.CreateParameter("@ssSecondApprover_EntraRoleId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssSecondApprover_EntraRoleId", DbType.Int64, ssENOrderDistributionConfig.ssSecondApprover_EntraRoleId);

}
if ((ssENOrderDistributionConfig.ssCreatedBy=="")) {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENOrderDistributionConfig.ssCreatedBy);

}
insertSqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENOrderDistributionConfig.ssCreatedOn);
if ((ssENOrderDistributionConfig.ssUpdatedBy=="")) {
insertSqlCmd.CreateParameter("@ssUpdatedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssUpdatedBy", DbType.String, ssENOrderDistributionConfig.ssUpdatedBy);

}
insertSqlCmd.CreateParameter("@ssUpdatedOn", DbType.DateTime, ssENOrderDistributionConfig.ssUpdatedOn);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrderDistributionConfig", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateOrderDistributionConfig
/// </summary>

public static async Task<long> CreateOrUpdateOrderDistributionConfig(IRequestContext requestContext,BitArray usedFields,RC_9fc59bda41db740ae87f91f135d24811 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateOrderDistributionConfig", "01fcf30b-f254-4516-ae45-70f39509dc63.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateOrderDistributionConfig", "01fcf30b-f254-4516-ae45-70f39509dc63.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_4ad0cdb13562998fda111463f2af9c31EntityRecord ssENOrderDistributionConfig = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(13,true);
}
string updateSet = "UPDATE " + ENOrderDistributionConfigEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@RegionId, "regionid") ?? "regionid") + " = @ssRegionId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@Applicant, "applicant") ?? "applicant") + " = @ssApplicant"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@ApplicantDescription, "applicantdescription") ?? "applicantdescription") + " = @ssApplicantDescription"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@DirectionId, "directionid") ?? "directionid") + " = @ssDirectionId"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@FirstContact_EntraRoleId, "firstcontact_entraroleid") ?? "firstcontact_entraroleid") + " = @ssFirstContact_EntraRoleId"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@SecondContact_EntraRoleId, "secondcontact_entraroleid") ?? "secondcontact_entraroleid") + " = @ssSecondContact_EntraRoleId"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@FirstApprover_EntraRoleId, "firstapprover_entraroleid") ?? "firstapprover_entraroleid") + " = @ssFirstApprover_EntraRoleId"): parameters);
parameters = (usedFields[8] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@SecondApprover_EntraRoleId, "secondapprover_entraroleid") ?? "secondapprover_entraroleid") + " = @ssSecondApprover_EntraRoleId"): parameters);
parameters = (usedFields[9] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = @ssCreatedBy"): parameters);
parameters = (usedFields[10] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = @ssCreatedOn"): parameters);
parameters = (usedFields[11] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby") + " = @ssUpdatedBy"): parameters);
parameters = (usedFields[12] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon") + " = @ssUpdatedOn"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENOrderDistibutionConfig_ssId_OrderDistributionConfig";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENOrderDistributionConfig.ssRegionId==0L)) {
sqlCmd.CreateParameter("@ssRegionId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssRegionId", DbType.Int64, ssENOrderDistributionConfig.ssRegionId);

}
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssApplicant", DbType.String, ssENOrderDistributionConfig.ssApplicant);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssApplicantDescription", DbType.String, ssENOrderDistributionConfig.ssApplicantDescription);
}
if(usedFields[4]) {
if ((ssENOrderDistributionConfig.ssDirectionId==0L)) {
sqlCmd.CreateParameter("@ssDirectionId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssDirectionId", DbType.Int64, ssENOrderDistributionConfig.ssDirectionId);

}
}
if(usedFields[5]) {
if ((ssENOrderDistributionConfig.ssFirstContact_EntraRoleId==0L)) {
sqlCmd.CreateParameter("@ssFirstContact_EntraRoleId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssFirstContact_EntraRoleId", DbType.Int64, ssENOrderDistributionConfig.ssFirstContact_EntraRoleId);

}
}
if(usedFields[6]) {
if ((ssENOrderDistributionConfig.ssSecondContact_EntraRoleId==0L)) {
sqlCmd.CreateParameter("@ssSecondContact_EntraRoleId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssSecondContact_EntraRoleId", DbType.Int64, ssENOrderDistributionConfig.ssSecondContact_EntraRoleId);

}
}
if(usedFields[7]) {
if ((ssENOrderDistributionConfig.ssFirstApprover_EntraRoleId==0L)) {
sqlCmd.CreateParameter("@ssFirstApprover_EntraRoleId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssFirstApprover_EntraRoleId", DbType.Int64, ssENOrderDistributionConfig.ssFirstApprover_EntraRoleId);

}
}
if(usedFields[8]) {
if ((ssENOrderDistributionConfig.ssSecondApprover_EntraRoleId==0L)) {
sqlCmd.CreateParameter("@ssSecondApprover_EntraRoleId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssSecondApprover_EntraRoleId", DbType.Int64, ssENOrderDistributionConfig.ssSecondApprover_EntraRoleId);

}
}
if(usedFields[9]) {
if ((ssENOrderDistributionConfig.ssCreatedBy=="")) {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENOrderDistributionConfig.ssCreatedBy);

}
}
if(usedFields[10]) {
sqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENOrderDistributionConfig.ssCreatedOn);
}
if(usedFields[11]) {
if ((ssENOrderDistributionConfig.ssUpdatedBy=="")) {
sqlCmd.CreateParameter("@ssUpdatedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssUpdatedBy", DbType.String, ssENOrderDistributionConfig.ssUpdatedBy);

}
}
if(usedFields[12]) {
sqlCmd.CreateParameter("@ssUpdatedOn", DbType.DateTime, ssENOrderDistributionConfig.ssUpdatedOn);
}
sqlCmd.CreateParameter("@idparam_ssENOrderDistibutionConfig_ssId_OrderDistributionConfig", DbType.Int64, ssENOrderDistributionConfig.ssId);
int counter = 0;
if(ssENOrderDistributionConfig.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateOrderDistributionConfig (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENOrderDistributionConfigEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@RegionId, "regionid") ?? "regionid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@Applicant, "applicant") ?? "applicant") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@ApplicantDescription, "applicantdescription") ?? "applicantdescription") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@DirectionId, "directionid") ?? "directionid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@FirstContact_EntraRoleId, "firstcontact_entraroleid") ?? "firstcontact_entraroleid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@SecondContact_EntraRoleId, "secondcontact_entraroleid") ?? "secondcontact_entraroleid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@FirstApprover_EntraRoleId, "firstapprover_entraroleid") ?? "firstapprover_entraroleid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@SecondApprover_EntraRoleId, "secondapprover_entraroleid") ?? "secondapprover_entraroleid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon") + "" +
" ) VALUES (" +
" @ssRegionId" +
", @ssApplicant" +
", @ssApplicantDescription" +
", @ssDirectionId" +
", @ssFirstContact_EntraRoleId" +
", @ssSecondContact_EntraRoleId" +
", @ssFirstApprover_EntraRoleId" +
", @ssSecondApprover_EntraRoleId" +
", @ssCreatedBy" +
", @ssCreatedOn" +
", @ssUpdatedBy" +
", @ssUpdatedOn" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENOrderDistributionConfig.ssRegionId==0L)) {
insertSqlCmd.CreateParameter("@ssRegionId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssRegionId", DbType.Int64, ssENOrderDistributionConfig.ssRegionId);

}
insertSqlCmd.CreateParameter("@ssApplicant", DbType.String, ssENOrderDistributionConfig.ssApplicant);
insertSqlCmd.CreateParameter("@ssApplicantDescription", DbType.String, ssENOrderDistributionConfig.ssApplicantDescription);
if ((ssENOrderDistributionConfig.ssDirectionId==0L)) {
insertSqlCmd.CreateParameter("@ssDirectionId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssDirectionId", DbType.Int64, ssENOrderDistributionConfig.ssDirectionId);

}
if ((ssENOrderDistributionConfig.ssFirstContact_EntraRoleId==0L)) {
insertSqlCmd.CreateParameter("@ssFirstContact_EntraRoleId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssFirstContact_EntraRoleId", DbType.Int64, ssENOrderDistributionConfig.ssFirstContact_EntraRoleId);

}
if ((ssENOrderDistributionConfig.ssSecondContact_EntraRoleId==0L)) {
insertSqlCmd.CreateParameter("@ssSecondContact_EntraRoleId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssSecondContact_EntraRoleId", DbType.Int64, ssENOrderDistributionConfig.ssSecondContact_EntraRoleId);

}
if ((ssENOrderDistributionConfig.ssFirstApprover_EntraRoleId==0L)) {
insertSqlCmd.CreateParameter("@ssFirstApprover_EntraRoleId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssFirstApprover_EntraRoleId", DbType.Int64, ssENOrderDistributionConfig.ssFirstApprover_EntraRoleId);

}
if ((ssENOrderDistributionConfig.ssSecondApprover_EntraRoleId==0L)) {
insertSqlCmd.CreateParameter("@ssSecondApprover_EntraRoleId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssSecondApprover_EntraRoleId", DbType.Int64, ssENOrderDistributionConfig.ssSecondApprover_EntraRoleId);

}
if ((ssENOrderDistributionConfig.ssCreatedBy=="")) {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENOrderDistributionConfig.ssCreatedBy);

}
insertSqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENOrderDistributionConfig.ssCreatedOn);
if ((ssENOrderDistributionConfig.ssUpdatedBy=="")) {
insertSqlCmd.CreateParameter("@ssUpdatedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssUpdatedBy", DbType.String, ssENOrderDistributionConfig.ssUpdatedBy);

}
insertSqlCmd.CreateParameter("@ssUpdatedOn", DbType.DateTime, ssENOrderDistributionConfig.ssUpdatedOn);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateOrderDistributionConfig", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENOrderDistributionConfig.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeOrderDistributionConfig
/// </summary>

public static async Task CreateOrUpdateSomeOrderDistributionConfig(IRequestContext requestContext,RL_44cb753cf22fd0b01aa78a5ab2f30079 inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeOrderDistributionConfig", "01fcf30b-f254-4516-ae45-70f39509dc63.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeOrderDistributionConfig", "01fcf30b-f254-4516-ae45-70f39509dc63.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENOrderDistributionConfigEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@RegionId, "regionid") ?? "regionid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@Applicant, "applicant") ?? "applicant") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@ApplicantDescription, "applicantdescription") ?? "applicantdescription") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@DirectionId, "directionid") ?? "directionid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@FirstContact_EntraRoleId, "firstcontact_entraroleid") ?? "firstcontact_entraroleid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@SecondContact_EntraRoleId, "secondcontact_entraroleid") ?? "secondcontact_entraroleid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@FirstApprover_EntraRoleId, "firstapprover_entraroleid") ?? "firstapprover_entraroleid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@SecondApprover_EntraRoleId, "secondapprover_entraroleid") ?? "secondapprover_entraroleid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon") + ") VALUES ( unnest(@ssRegionId),  unnest(@ssApplicant),  unnest(@ssApplicantDescription),  unnest(@ssDirectionId),  unnest(@ssFirstContact_EntraRoleId),  unnest(@ssSecondContact_EntraRoleId),  unnest(@ssFirstApprover_EntraRoleId),  unnest(@ssSecondApprover_EntraRoleId),  unnest(@ssCreatedBy),  unnest(@ssCreatedOn),  unnest(@ssUpdatedBy),  unnest(@ssUpdatedOn)) ";
insertSql += "";

string updateSql = "UPDATE " + entityTableName + " SET " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@RegionId, "regionid") ?? "regionid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@RegionId, "regionid") ?? "regionid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@Applicant, "applicant") ?? "applicant") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@Applicant, "applicant") ?? "applicant") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@ApplicantDescription, "applicantdescription") ?? "applicantdescription") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@ApplicantDescription, "applicantdescription") ?? "applicantdescription") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@DirectionId, "directionid") ?? "directionid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@DirectionId, "directionid") ?? "directionid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@FirstContact_EntraRoleId, "firstcontact_entraroleid") ?? "firstcontact_entraroleid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@FirstContact_EntraRoleId, "firstcontact_entraroleid") ?? "firstcontact_entraroleid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@SecondContact_EntraRoleId, "secondcontact_entraroleid") ?? "secondcontact_entraroleid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@SecondContact_EntraRoleId, "secondcontact_entraroleid") ?? "secondcontact_entraroleid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@FirstApprover_EntraRoleId, "firstapprover_entraroleid") ?? "firstapprover_entraroleid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@FirstApprover_EntraRoleId, "firstapprover_entraroleid") ?? "firstapprover_entraroleid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@SecondApprover_EntraRoleId, "secondapprover_entraroleid") ?? "secondapprover_entraroleid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@SecondApprover_EntraRoleId, "secondapprover_entraroleid") ?? "secondapprover_entraroleid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon") + " from ( select  unnest(@ssId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@Id, "id") ?? "id") + ",  unnest(@ssRegionId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@RegionId, "regionid") ?? "regionid") + ",  unnest(@ssApplicant) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@Applicant, "applicant") ?? "applicant") + ",  unnest(@ssApplicantDescription) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@ApplicantDescription, "applicantdescription") ?? "applicantdescription") + ",  unnest(@ssDirectionId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@DirectionId, "directionid") ?? "directionid") + ",  unnest(@ssFirstContact_EntraRoleId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@FirstContact_EntraRoleId, "firstcontact_entraroleid") ?? "firstcontact_entraroleid") + ",  unnest(@ssSecondContact_EntraRoleId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@SecondContact_EntraRoleId, "secondcontact_entraroleid") ?? "secondcontact_entraroleid") + ",  unnest(@ssFirstApprover_EntraRoleId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@FirstApprover_EntraRoleId, "firstapprover_entraroleid") ?? "firstapprover_entraroleid") + ",  unnest(@ssSecondApprover_EntraRoleId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@SecondApprover_EntraRoleId, "secondapprover_entraroleid") ?? "secondapprover_entraroleid") + ",  unnest(@ssCreatedBy) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ",  unnest(@ssCreatedOn) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + ",  unnest(@ssUpdatedBy) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby") + ",  unnest(@ssUpdatedOn) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon") + " ) as updateTable where " + entityTableName + "." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@Id, "id") ?? "id") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@Id, "id") ?? "id") + " ";
updateSql += "";

List<object> insertRegionIdList = new List<object>();
List<string> insertApplicantList = new List<string>();
List<string> insertApplicantDescriptionList = new List<string>();
List<object> insertDirectionIdList = new List<object>();
List<object> insertFirstContact_EntraRoleIdList = new List<object>();
List<object> insertSecondContact_EntraRoleIdList = new List<object>();
List<object> insertFirstApprover_EntraRoleIdList = new List<object>();
List<object> insertSecondApprover_EntraRoleIdList = new List<object>();
List<object> insertCreatedByList = new List<object>();
List<DateTime> insertCreatedOnList = new List<DateTime>();
List<object> insertUpdatedByList = new List<object>();
List<DateTime> insertUpdatedOnList = new List<DateTime>();

List<long> updateIdList = new List<long>();
List<object> updateRegionIdList = new List<object>();
List<string> updateApplicantList = new List<string>();
List<string> updateApplicantDescriptionList = new List<string>();
List<object> updateDirectionIdList = new List<object>();
List<object> updateFirstContact_EntraRoleIdList = new List<object>();
List<object> updateSecondContact_EntraRoleIdList = new List<object>();
List<object> updateFirstApprover_EntraRoleIdList = new List<object>();
List<object> updateSecondApprover_EntraRoleIdList = new List<object>();
List<object> updateCreatedByList = new List<object>();
List<DateTime> updateCreatedOnList = new List<DateTime>();
List<object> updateUpdatedByList = new List<object>();
List<DateTime> updateUpdatedOnList = new List<DateTime>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_9fc59bda41db740ae87f91f135d24811)inParamSourceList.Current).ssENOrderDistributionConfig;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
if ((record.ssRegionId==0L)) {
updateRegionIdList.Add(null);
} else {
updateRegionIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssRegionId));
}
updateApplicantList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssApplicant));
updateApplicantDescriptionList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssApplicantDescription));
if ((record.ssDirectionId==0L)) {
updateDirectionIdList.Add(null);
} else {
updateDirectionIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssDirectionId));
}
if ((record.ssFirstContact_EntraRoleId==0L)) {
updateFirstContact_EntraRoleIdList.Add(null);
} else {
updateFirstContact_EntraRoleIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssFirstContact_EntraRoleId));
}
if ((record.ssSecondContact_EntraRoleId==0L)) {
updateSecondContact_EntraRoleIdList.Add(null);
} else {
updateSecondContact_EntraRoleIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssSecondContact_EntraRoleId));
}
if ((record.ssFirstApprover_EntraRoleId==0L)) {
updateFirstApprover_EntraRoleIdList.Add(null);
} else {
updateFirstApprover_EntraRoleIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssFirstApprover_EntraRoleId));
}
if ((record.ssSecondApprover_EntraRoleId==0L)) {
updateSecondApprover_EntraRoleIdList.Add(null);
} else {
updateSecondApprover_EntraRoleIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssSecondApprover_EntraRoleId));
}
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
} else {
if ((record.ssRegionId==0L)) {
insertRegionIdList.Add(null);
} else {
insertRegionIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssRegionId));
}
insertApplicantList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssApplicant));
insertApplicantDescriptionList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssApplicantDescription));
if ((record.ssDirectionId==0L)) {
insertDirectionIdList.Add(null);
} else {
insertDirectionIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssDirectionId));
}
if ((record.ssFirstContact_EntraRoleId==0L)) {
insertFirstContact_EntraRoleIdList.Add(null);
} else {
insertFirstContact_EntraRoleIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssFirstContact_EntraRoleId));
}
if ((record.ssSecondContact_EntraRoleId==0L)) {
insertSecondContact_EntraRoleIdList.Add(null);
} else {
insertSecondContact_EntraRoleIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssSecondContact_EntraRoleId));
}
if ((record.ssFirstApprover_EntraRoleId==0L)) {
insertFirstApprover_EntraRoleIdList.Add(null);
} else {
insertFirstApprover_EntraRoleIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssFirstApprover_EntraRoleId));
}
if ((record.ssSecondApprover_EntraRoleId==0L)) {
insertSecondApprover_EntraRoleIdList.Add(null);
} else {
insertSecondApprover_EntraRoleIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssSecondApprover_EntraRoleId));
}
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
}
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertRegionIdList.IsEmpty() || !insertApplicantList.IsEmpty() || !insertApplicantDescriptionList.IsEmpty() || !insertDirectionIdList.IsEmpty() || !insertFirstContact_EntraRoleIdList.IsEmpty() || !insertSecondContact_EntraRoleIdList.IsEmpty() || !insertFirstApprover_EntraRoleIdList.IsEmpty() || !insertSecondApprover_EntraRoleIdList.IsEmpty() || !insertCreatedByList.IsEmpty() || !insertCreatedOnList.IsEmpty() || !insertUpdatedByList.IsEmpty() || !insertUpdatedOnList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssRegionId",DbType.Int64,insertRegionIdList);
executionService.CreateParameter(insertSqlCmd,"@ssApplicant",DbType.String,insertApplicantList);
executionService.CreateParameter(insertSqlCmd,"@ssApplicantDescription",DbType.String,insertApplicantDescriptionList);
executionService.CreateParameter(insertSqlCmd,"@ssDirectionId",DbType.Int64,insertDirectionIdList);
executionService.CreateParameter(insertSqlCmd,"@ssFirstContact_EntraRoleId",DbType.Int64,insertFirstContact_EntraRoleIdList);
executionService.CreateParameter(insertSqlCmd,"@ssSecondContact_EntraRoleId",DbType.Int64,insertSecondContact_EntraRoleIdList);
executionService.CreateParameter(insertSqlCmd,"@ssFirstApprover_EntraRoleId",DbType.Int64,insertFirstApprover_EntraRoleIdList);
executionService.CreateParameter(insertSqlCmd,"@ssSecondApprover_EntraRoleId",DbType.Int64,insertSecondApprover_EntraRoleIdList);
executionService.CreateParameter(insertSqlCmd,"@ssCreatedBy",DbType.String,insertCreatedByList);
executionService.CreateParameter(insertSqlCmd,"@ssCreatedOn",DbType.DateTime,insertCreatedOnList);
executionService.CreateParameter(insertSqlCmd,"@ssUpdatedBy",DbType.String,insertUpdatedByList);
executionService.CreateParameter(insertSqlCmd,"@ssUpdatedOn",DbType.DateTime,insertUpdatedOnList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeOrderDistributionConfig (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateRegionIdList.IsEmpty() || !updateApplicantList.IsEmpty() || !updateApplicantDescriptionList.IsEmpty() || !updateDirectionIdList.IsEmpty() || !updateFirstContact_EntraRoleIdList.IsEmpty() || !updateSecondContact_EntraRoleIdList.IsEmpty() || !updateFirstApprover_EntraRoleIdList.IsEmpty() || !updateSecondApprover_EntraRoleIdList.IsEmpty() || !updateCreatedByList.IsEmpty() || !updateCreatedOnList.IsEmpty() || !updateUpdatedByList.IsEmpty() || !updateUpdatedOnList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssRegionId",DbType.Int64,updateRegionIdList);
executionService.CreateParameter(updateSqlCmd,"@ssApplicant",DbType.String,updateApplicantList);
executionService.CreateParameter(updateSqlCmd,"@ssApplicantDescription",DbType.String,updateApplicantDescriptionList);
executionService.CreateParameter(updateSqlCmd,"@ssDirectionId",DbType.Int64,updateDirectionIdList);
executionService.CreateParameter(updateSqlCmd,"@ssFirstContact_EntraRoleId",DbType.Int64,updateFirstContact_EntraRoleIdList);
executionService.CreateParameter(updateSqlCmd,"@ssSecondContact_EntraRoleId",DbType.Int64,updateSecondContact_EntraRoleIdList);
executionService.CreateParameter(updateSqlCmd,"@ssFirstApprover_EntraRoleId",DbType.Int64,updateFirstApprover_EntraRoleIdList);
executionService.CreateParameter(updateSqlCmd,"@ssSecondApprover_EntraRoleId",DbType.Int64,updateSecondApprover_EntraRoleIdList);
executionService.CreateParameter(updateSqlCmd,"@ssCreatedBy",DbType.String,updateCreatedByList);
executionService.CreateParameter(updateSqlCmd,"@ssCreatedOn",DbType.DateTime,updateCreatedOnList);
executionService.CreateParameter(updateSqlCmd,"@ssUpdatedBy",DbType.String,updateUpdatedByList);
executionService.CreateParameter(updateSqlCmd,"@ssUpdatedOn",DbType.DateTime,updateUpdatedOnList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeOrderDistributionConfig (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteOrderDistributionConfig
/// </summary>

public static async Task DeleteOrderDistributionConfig(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteOrderDistributionConfig", "01fcf30b-f254-4516-ae45-70f39509dc63.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteOrderDistributionConfig", "01fcf30b-f254-4516-ae45-70f39509dc63.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENOrderDistributionConfigEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteOrderDistributionConfig", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllOrderDistributionConfig
/// </summary>

public static async Task DeleteAllOrderDistributionConfig(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllOrderDistributionConfig", "01fcf30b-f254-4516-ae45-70f39509dc63.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllOrderDistributionConfig", "01fcf30b-f254-4516-ae45-70f39509dc63.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENOrderDistributionConfigEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteOrderDistributionConfig", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetOrderDistributionConfig
/// </summary>

public static async Task<RC_9fc59bda41db740ae87f91f135d24811> GetOrderDistributionConfig(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_9fc59bda41db740ae87f91f135d24811 outParamRecord = default;
outParamRecord = new RC_9fc59bda41db740ae87f91f135d24811();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetOrderDistributionConfig", "01fcf30b-f254-4516-ae45-70f39509dc63.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetOrderDistributionConfig", "01fcf30b-f254-4516-ae45-70f39509dc63.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@RegionId, "regionid") ?? "regionid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@Applicant, "applicant") ?? "applicant", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@ApplicantDescription, "applicantdescription") ?? "applicantdescription", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@DirectionId, "directionid") ?? "directionid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@FirstContact_EntraRoleId, "firstcontact_entraroleid") ?? "firstcontact_entraroleid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@SecondContact_EntraRoleId, "secondcontact_entraroleid") ?? "secondcontact_entraroleid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@FirstApprover_EntraRoleId, "firstapprover_entraroleid") ?? "firstapprover_entraroleid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@SecondApprover_EntraRoleId, "secondapprover_entraroleid") ?? "secondapprover_entraroleid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@CreatedBy, "createdby") ?? "createdby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@CreatedOn, "createdon") ?? "createdon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
" FROM " + ENOrderDistributionConfigEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetOrderDistributionConfig", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(13,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENOrderDistributionConfigEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetOrderDistributionConfigForUpdate
/// </summary>

public static async Task<RC_9fc59bda41db740ae87f91f135d24811> GetOrderDistributionConfigForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_9fc59bda41db740ae87f91f135d24811 outParamRecord = default;
outParamRecord = new RC_9fc59bda41db740ae87f91f135d24811();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetOrderDistributionConfigForUpdate", "01fcf30b-f254-4516-ae45-70f39509dc63.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetOrderDistributionConfigForUpdate", "01fcf30b-f254-4516-ae45-70f39509dc63.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@RegionId, "regionid") ?? "regionid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@Applicant, "applicant") ?? "applicant", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@ApplicantDescription, "applicantdescription") ?? "applicantdescription", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@DirectionId, "directionid") ?? "directionid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@FirstContact_EntraRoleId, "firstcontact_entraroleid") ?? "firstcontact_entraroleid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@SecondContact_EntraRoleId, "secondcontact_entraroleid") ?? "secondcontact_entraroleid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@FirstApprover_EntraRoleId, "firstapprover_entraroleid") ?? "firstapprover_entraroleid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@SecondApprover_EntraRoleId, "secondapprover_entraroleid") ?? "secondapprover_entraroleid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@CreatedBy, "createdby") ?? "createdby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@CreatedOn, "createdon") ?? "createdon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
" FROM " + ENOrderDistributionConfigEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetOrderDistributionConfigForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(13,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENOrderDistributionConfigEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateOrderDistributionConfig
/// </summary>

public static async Task UpdateOrderDistributionConfig(IRequestContext requestContext,BitArray usedFields,RC_9fc59bda41db740ae87f91f135d24811 inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateOrderDistributionConfig", "01fcf30b-f254-4516-ae45-70f39509dc63.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateOrderDistributionConfig", "01fcf30b-f254-4516-ae45-70f39509dc63.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_4ad0cdb13562998fda111463f2af9c31EntityRecord ssENOrderDistributionConfig = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(13,true);
}
string updateSet = "UPDATE " + ENOrderDistributionConfigEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@RegionId, "regionid") ?? "regionid") + " = @ssRegionId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@Applicant, "applicant") ?? "applicant") + " = @ssApplicant"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@ApplicantDescription, "applicantdescription") ?? "applicantdescription") + " = @ssApplicantDescription"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@DirectionId, "directionid") ?? "directionid") + " = @ssDirectionId"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@FirstContact_EntraRoleId, "firstcontact_entraroleid") ?? "firstcontact_entraroleid") + " = @ssFirstContact_EntraRoleId"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@SecondContact_EntraRoleId, "secondcontact_entraroleid") ?? "secondcontact_entraroleid") + " = @ssSecondContact_EntraRoleId"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@FirstApprover_EntraRoleId, "firstapprover_entraroleid") ?? "firstapprover_entraroleid") + " = @ssFirstApprover_EntraRoleId"): parameters);
parameters = (usedFields[8] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@SecondApprover_EntraRoleId, "secondapprover_entraroleid") ?? "secondapprover_entraroleid") + " = @ssSecondApprover_EntraRoleId"): parameters);
parameters = (usedFields[9] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = @ssCreatedBy"): parameters);
parameters = (usedFields[10] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = @ssCreatedOn"): parameters);
parameters = (usedFields[11] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby") + " = @ssUpdatedBy"): parameters);
parameters = (usedFields[12] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon") + " = @ssUpdatedOn"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENOrderDistibutionConfig_ssId_OrderDistributionConfig";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDistributionConfig, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDistributionConfigAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENOrderDistributionConfig.ssRegionId==0L)) {
sqlCmd.CreateParameter("@ssRegionId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssRegionId", DbType.Int64, ssENOrderDistributionConfig.ssRegionId);

}
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssApplicant", DbType.String, ssENOrderDistributionConfig.ssApplicant);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssApplicantDescription", DbType.String, ssENOrderDistributionConfig.ssApplicantDescription);
}
if(usedFields[4]) {
if ((ssENOrderDistributionConfig.ssDirectionId==0L)) {
sqlCmd.CreateParameter("@ssDirectionId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssDirectionId", DbType.Int64, ssENOrderDistributionConfig.ssDirectionId);

}
}
if(usedFields[5]) {
if ((ssENOrderDistributionConfig.ssFirstContact_EntraRoleId==0L)) {
sqlCmd.CreateParameter("@ssFirstContact_EntraRoleId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssFirstContact_EntraRoleId", DbType.Int64, ssENOrderDistributionConfig.ssFirstContact_EntraRoleId);

}
}
if(usedFields[6]) {
if ((ssENOrderDistributionConfig.ssSecondContact_EntraRoleId==0L)) {
sqlCmd.CreateParameter("@ssSecondContact_EntraRoleId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssSecondContact_EntraRoleId", DbType.Int64, ssENOrderDistributionConfig.ssSecondContact_EntraRoleId);

}
}
if(usedFields[7]) {
if ((ssENOrderDistributionConfig.ssFirstApprover_EntraRoleId==0L)) {
sqlCmd.CreateParameter("@ssFirstApprover_EntraRoleId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssFirstApprover_EntraRoleId", DbType.Int64, ssENOrderDistributionConfig.ssFirstApprover_EntraRoleId);

}
}
if(usedFields[8]) {
if ((ssENOrderDistributionConfig.ssSecondApprover_EntraRoleId==0L)) {
sqlCmd.CreateParameter("@ssSecondApprover_EntraRoleId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssSecondApprover_EntraRoleId", DbType.Int64, ssENOrderDistributionConfig.ssSecondApprover_EntraRoleId);

}
}
if(usedFields[9]) {
if ((ssENOrderDistributionConfig.ssCreatedBy=="")) {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENOrderDistributionConfig.ssCreatedBy);

}
}
if(usedFields[10]) {
sqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENOrderDistributionConfig.ssCreatedOn);
}
if(usedFields[11]) {
if ((ssENOrderDistributionConfig.ssUpdatedBy=="")) {
sqlCmd.CreateParameter("@ssUpdatedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssUpdatedBy", DbType.String, ssENOrderDistributionConfig.ssUpdatedBy);

}
}
if(usedFields[12]) {
sqlCmd.CreateParameter("@ssUpdatedOn", DbType.DateTime, ssENOrderDistributionConfig.ssUpdatedOn);
}
sqlCmd.CreateParameter("@idparam_ssENOrderDistibutionConfig_ssId_OrderDistributionConfig", DbType.Int64, ssENOrderDistributionConfig.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateOrderDistributionConfig", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("OrderDistributionConfig", ssENOrderDistributionConfig.ssId.ToString()); }}
}
return;
}

}
}
