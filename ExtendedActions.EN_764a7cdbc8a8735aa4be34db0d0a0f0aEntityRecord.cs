using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateFolio
/// </summary>

public static async Task<long> CreateFolio(IRequestContext requestContext,RC_cfeb2cf80ab683e7d9a9b5d02d9c9526 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateFolio", "278ad874-ac3c-4fbf-b332-0f512809d5f8.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateFolio", "278ad874-ac3c-4fbf-b332-0f512809d5f8.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord ssENFolio = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENFolioEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@IsDraft, "isdraft") ?? "isdraft") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@FolioNumber, "folionumber") ?? "folionumber") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@CanProveedorCancel, "canproveedorcancel") ?? "canproveedorcancel") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@OrderId, "orderid") ?? "orderid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@SupplierId, "supplierid") ?? "supplierid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@CompanyId, "companyid") ?? "companyid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@FolioStatusId, "foliostatusid") ?? "foliostatusid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@TotalAmount, "totalamount") ?? "totalamount") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@TotalIVA_Amount, "totaliva_amount") ?? "totaliva_amount") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@PartialAmount, "partialamount") ?? "partialamount") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@FirstApproverUserId, "firstapproveruserid") ?? "firstapproveruserid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@ApprovalProcessTypeId, "approvalprocesstypeid") ?? "approvalprocesstypeid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@SAPEntryError, "sapentryerror") ?? "sapentryerror") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@MinuteSelected, "minuteselected") ?? "minuteselected") + "" +
" ) VALUES (" +
" @ssIsDraft" +
", @ssFolioNumber" +
", @ssCanProveedorCancel" +
", @ssOrderId" +
", @ssSupplierId" +
", @ssCompanyId" +
", @ssFolioStatusId" +
", @ssTotalAmount" +
", @ssTotalIVA_Amount" +
", @ssPartialAmount" +
", @ssCurrencyId" +
", @ssFirstApproverUserId" +
", @ssApprovalProcessTypeId" +
", @ssSAPEntryError" +
", @ssCreatedBy" +
", @ssCreatedOn" +
", @ssUpdatedBy" +
", @ssUpdatedOn" +
", @ssMinuteSelected" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssIsDraft", DbType.Boolean, ssENFolio.ssIsDraft);
insertSqlCmd.CreateParameter("@ssFolioNumber", DbType.String, ssENFolio.ssFolioNumber);
insertSqlCmd.CreateParameter("@ssCanProveedorCancel", DbType.Boolean, ssENFolio.ssCanProveedorCancel);
if ((ssENFolio.ssOrderId==0L)) {
insertSqlCmd.CreateParameter("@ssOrderId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssOrderId", DbType.Int64, ssENFolio.ssOrderId);

}
if ((ssENFolio.ssSupplierId==0L)) {
insertSqlCmd.CreateParameter("@ssSupplierId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssSupplierId", DbType.Int64, ssENFolio.ssSupplierId);

}
if ((ssENFolio.ssCompanyId==0L)) {
insertSqlCmd.CreateParameter("@ssCompanyId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCompanyId", DbType.Int64, ssENFolio.ssCompanyId);

}
if ((ssENFolio.ssFolioStatusId==0)) {
insertSqlCmd.CreateParameter("@ssFolioStatusId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssFolioStatusId", DbType.Int32, ssENFolio.ssFolioStatusId);

}
var TotalAmountParameter = insertSqlCmd.CreateParameter("@ssTotalAmount", DbType.Decimal, ssENFolio.ssTotalAmount);
{
    string decimalAsStr = ssENFolio.ssTotalAmount.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {TotalAmountParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
var TotalIVA_AmountParameter = insertSqlCmd.CreateParameter("@ssTotalIVA_Amount", DbType.Decimal, ssENFolio.ssTotalIVA_Amount);
{
    string decimalAsStr = ssENFolio.ssTotalIVA_Amount.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {TotalIVA_AmountParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
var PartialAmountParameter = insertSqlCmd.CreateParameter("@ssPartialAmount", DbType.Decimal, ssENFolio.ssPartialAmount);
{
    string decimalAsStr = ssENFolio.ssPartialAmount.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {PartialAmountParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
if ((ssENFolio.ssCurrencyId=="")) {
insertSqlCmd.CreateParameter("@ssCurrencyId", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCurrencyId", DbType.String, ssENFolio.ssCurrencyId);

}
if ((ssENFolio.ssFirstApproverUserId=="")) {
insertSqlCmd.CreateParameter("@ssFirstApproverUserId", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssFirstApproverUserId", DbType.String, ssENFolio.ssFirstApproverUserId);

}
if ((ssENFolio.ssApprovalProcessTypeId==0)) {
insertSqlCmd.CreateParameter("@ssApprovalProcessTypeId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssApprovalProcessTypeId", DbType.Int32, ssENFolio.ssApprovalProcessTypeId);

}
insertSqlCmd.CreateParameter("@ssSAPEntryError", DbType.String, ssENFolio.ssSAPEntryError);
if ((ssENFolio.ssCreatedBy=="")) {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENFolio.ssCreatedBy);

}
insertSqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENFolio.ssCreatedOn);
if ((ssENFolio.ssUpdatedBy=="")) {
insertSqlCmd.CreateParameter("@ssUpdatedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssUpdatedBy", DbType.String, ssENFolio.ssUpdatedBy);

}
insertSqlCmd.CreateParameter("@ssUpdatedOn", DbType.DateTime, ssENFolio.ssUpdatedOn);
insertSqlCmd.CreateParameter("@ssMinuteSelected", DbType.Int32, ssENFolio.ssMinuteSelected);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateFolio", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateFolio
/// </summary>

public static async Task<long> CreateOrUpdateFolio(IRequestContext requestContext,BitArray usedFields,RC_cfeb2cf80ab683e7d9a9b5d02d9c9526 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateFolio", "278ad874-ac3c-4fbf-b332-0f512809d5f8.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateFolio", "278ad874-ac3c-4fbf-b332-0f512809d5f8.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord ssENFolio = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(20,true);
}
string updateSet = "UPDATE " + ENFolioEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@IsDraft, "isdraft") ?? "isdraft") + " = @ssIsDraft"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@FolioNumber, "folionumber") ?? "folionumber") + " = @ssFolioNumber"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@CanProveedorCancel, "canproveedorcancel") ?? "canproveedorcancel") + " = @ssCanProveedorCancel"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@OrderId, "orderid") ?? "orderid") + " = @ssOrderId"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@SupplierId, "supplierid") ?? "supplierid") + " = @ssSupplierId"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@CompanyId, "companyid") ?? "companyid") + " = @ssCompanyId"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@FolioStatusId, "foliostatusid") ?? "foliostatusid") + " = @ssFolioStatusId"): parameters);
parameters = (usedFields[8] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@TotalAmount, "totalamount") ?? "totalamount") + " = @ssTotalAmount"): parameters);
parameters = (usedFields[9] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@TotalIVA_Amount, "totaliva_amount") ?? "totaliva_amount") + " = @ssTotalIVA_Amount"): parameters);
parameters = (usedFields[10] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@PartialAmount, "partialamount") ?? "partialamount") + " = @ssPartialAmount"): parameters);
parameters = (usedFields[11] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid") + " = @ssCurrencyId"): parameters);
parameters = (usedFields[12] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@FirstApproverUserId, "firstapproveruserid") ?? "firstapproveruserid") + " = @ssFirstApproverUserId"): parameters);
parameters = (usedFields[13] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@ApprovalProcessTypeId, "approvalprocesstypeid") ?? "approvalprocesstypeid") + " = @ssApprovalProcessTypeId"): parameters);
parameters = (usedFields[14] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@SAPEntryError, "sapentryerror") ?? "sapentryerror") + " = @ssSAPEntryError"): parameters);
parameters = (usedFields[15] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = @ssCreatedBy"): parameters);
parameters = (usedFields[16] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = @ssCreatedOn"): parameters);
parameters = (usedFields[17] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby") + " = @ssUpdatedBy"): parameters);
parameters = (usedFields[18] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon") + " = @ssUpdatedOn"): parameters);
parameters = (usedFields[19] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@MinuteSelected, "minuteselected") ?? "minuteselected") + " = @ssMinuteSelected"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENFolio_ssId_Folio";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@IsDraft, "isdraft") ?? "isdraft") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@IsDraft, "isdraft") ?? "isdraft") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssIsDraft", DbType.Boolean, ssENFolio.ssIsDraft);
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssFolioNumber", DbType.String, ssENFolio.ssFolioNumber);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssCanProveedorCancel", DbType.Boolean, ssENFolio.ssCanProveedorCancel);
}
if(usedFields[4]) {
if ((ssENFolio.ssOrderId==0L)) {
sqlCmd.CreateParameter("@ssOrderId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssOrderId", DbType.Int64, ssENFolio.ssOrderId);

}
}
if(usedFields[5]) {
if ((ssENFolio.ssSupplierId==0L)) {
sqlCmd.CreateParameter("@ssSupplierId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssSupplierId", DbType.Int64, ssENFolio.ssSupplierId);

}
}
if(usedFields[6]) {
if ((ssENFolio.ssCompanyId==0L)) {
sqlCmd.CreateParameter("@ssCompanyId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCompanyId", DbType.Int64, ssENFolio.ssCompanyId);

}
}
if(usedFields[7]) {
if ((ssENFolio.ssFolioStatusId==0)) {
sqlCmd.CreateParameter("@ssFolioStatusId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssFolioStatusId", DbType.Int32, ssENFolio.ssFolioStatusId);

}
}
if(usedFields[8]) {
var TotalAmountParameter = sqlCmd.CreateParameter("@ssTotalAmount", DbType.Decimal, ssENFolio.ssTotalAmount);
{
    string decimalAsStr = ssENFolio.ssTotalAmount.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {TotalAmountParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[9]) {
var TotalIVA_AmountParameter = sqlCmd.CreateParameter("@ssTotalIVA_Amount", DbType.Decimal, ssENFolio.ssTotalIVA_Amount);
{
    string decimalAsStr = ssENFolio.ssTotalIVA_Amount.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {TotalIVA_AmountParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[10]) {
var PartialAmountParameter = sqlCmd.CreateParameter("@ssPartialAmount", DbType.Decimal, ssENFolio.ssPartialAmount);
{
    string decimalAsStr = ssENFolio.ssPartialAmount.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {PartialAmountParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[11]) {
if ((ssENFolio.ssCurrencyId=="")) {
sqlCmd.CreateParameter("@ssCurrencyId", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCurrencyId", DbType.String, ssENFolio.ssCurrencyId);

}
}
if(usedFields[12]) {
if ((ssENFolio.ssFirstApproverUserId=="")) {
sqlCmd.CreateParameter("@ssFirstApproverUserId", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssFirstApproverUserId", DbType.String, ssENFolio.ssFirstApproverUserId);

}
}
if(usedFields[13]) {
if ((ssENFolio.ssApprovalProcessTypeId==0)) {
sqlCmd.CreateParameter("@ssApprovalProcessTypeId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssApprovalProcessTypeId", DbType.Int32, ssENFolio.ssApprovalProcessTypeId);

}
}
if(usedFields[14]) {
sqlCmd.CreateParameter("@ssSAPEntryError", DbType.String, ssENFolio.ssSAPEntryError);
}
if(usedFields[15]) {
if ((ssENFolio.ssCreatedBy=="")) {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENFolio.ssCreatedBy);

}
}
if(usedFields[16]) {
sqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENFolio.ssCreatedOn);
}
if(usedFields[17]) {
if ((ssENFolio.ssUpdatedBy=="")) {
sqlCmd.CreateParameter("@ssUpdatedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssUpdatedBy", DbType.String, ssENFolio.ssUpdatedBy);

}
}
if(usedFields[18]) {
sqlCmd.CreateParameter("@ssUpdatedOn", DbType.DateTime, ssENFolio.ssUpdatedOn);
}
if(usedFields[19]) {
sqlCmd.CreateParameter("@ssMinuteSelected", DbType.Int32, ssENFolio.ssMinuteSelected);
}
sqlCmd.CreateParameter("@idparam_ssENFolio_ssId_Folio", DbType.Int64, ssENFolio.ssId);
int counter = 0;
if(ssENFolio.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateFolio (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENFolioEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@IsDraft, "isdraft") ?? "isdraft") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@FolioNumber, "folionumber") ?? "folionumber") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@CanProveedorCancel, "canproveedorcancel") ?? "canproveedorcancel") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@OrderId, "orderid") ?? "orderid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@SupplierId, "supplierid") ?? "supplierid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@CompanyId, "companyid") ?? "companyid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@FolioStatusId, "foliostatusid") ?? "foliostatusid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@TotalAmount, "totalamount") ?? "totalamount") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@TotalIVA_Amount, "totaliva_amount") ?? "totaliva_amount") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@PartialAmount, "partialamount") ?? "partialamount") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@FirstApproverUserId, "firstapproveruserid") ?? "firstapproveruserid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@ApprovalProcessTypeId, "approvalprocesstypeid") ?? "approvalprocesstypeid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@SAPEntryError, "sapentryerror") ?? "sapentryerror") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@MinuteSelected, "minuteselected") ?? "minuteselected") + "" +
" ) VALUES (" +
" @ssIsDraft" +
", @ssFolioNumber" +
", @ssCanProveedorCancel" +
", @ssOrderId" +
", @ssSupplierId" +
", @ssCompanyId" +
", @ssFolioStatusId" +
", @ssTotalAmount" +
", @ssTotalIVA_Amount" +
", @ssPartialAmount" +
", @ssCurrencyId" +
", @ssFirstApproverUserId" +
", @ssApprovalProcessTypeId" +
", @ssSAPEntryError" +
", @ssCreatedBy" +
", @ssCreatedOn" +
", @ssUpdatedBy" +
", @ssUpdatedOn" +
", @ssMinuteSelected" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssIsDraft", DbType.Boolean, ssENFolio.ssIsDraft);
insertSqlCmd.CreateParameter("@ssFolioNumber", DbType.String, ssENFolio.ssFolioNumber);
insertSqlCmd.CreateParameter("@ssCanProveedorCancel", DbType.Boolean, ssENFolio.ssCanProveedorCancel);
if ((ssENFolio.ssOrderId==0L)) {
insertSqlCmd.CreateParameter("@ssOrderId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssOrderId", DbType.Int64, ssENFolio.ssOrderId);

}
if ((ssENFolio.ssSupplierId==0L)) {
insertSqlCmd.CreateParameter("@ssSupplierId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssSupplierId", DbType.Int64, ssENFolio.ssSupplierId);

}
if ((ssENFolio.ssCompanyId==0L)) {
insertSqlCmd.CreateParameter("@ssCompanyId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCompanyId", DbType.Int64, ssENFolio.ssCompanyId);

}
if ((ssENFolio.ssFolioStatusId==0)) {
insertSqlCmd.CreateParameter("@ssFolioStatusId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssFolioStatusId", DbType.Int32, ssENFolio.ssFolioStatusId);

}
var TotalAmountParameter = insertSqlCmd.CreateParameter("@ssTotalAmount", DbType.Decimal, ssENFolio.ssTotalAmount);
{
    string decimalAsStr = ssENFolio.ssTotalAmount.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {TotalAmountParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
var TotalIVA_AmountParameter = insertSqlCmd.CreateParameter("@ssTotalIVA_Amount", DbType.Decimal, ssENFolio.ssTotalIVA_Amount);
{
    string decimalAsStr = ssENFolio.ssTotalIVA_Amount.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {TotalIVA_AmountParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
var PartialAmountParameter = insertSqlCmd.CreateParameter("@ssPartialAmount", DbType.Decimal, ssENFolio.ssPartialAmount);
{
    string decimalAsStr = ssENFolio.ssPartialAmount.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {PartialAmountParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
if ((ssENFolio.ssCurrencyId=="")) {
insertSqlCmd.CreateParameter("@ssCurrencyId", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCurrencyId", DbType.String, ssENFolio.ssCurrencyId);

}
if ((ssENFolio.ssFirstApproverUserId=="")) {
insertSqlCmd.CreateParameter("@ssFirstApproverUserId", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssFirstApproverUserId", DbType.String, ssENFolio.ssFirstApproverUserId);

}
if ((ssENFolio.ssApprovalProcessTypeId==0)) {
insertSqlCmd.CreateParameter("@ssApprovalProcessTypeId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssApprovalProcessTypeId", DbType.Int32, ssENFolio.ssApprovalProcessTypeId);

}
insertSqlCmd.CreateParameter("@ssSAPEntryError", DbType.String, ssENFolio.ssSAPEntryError);
if ((ssENFolio.ssCreatedBy=="")) {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENFolio.ssCreatedBy);

}
insertSqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENFolio.ssCreatedOn);
if ((ssENFolio.ssUpdatedBy=="")) {
insertSqlCmd.CreateParameter("@ssUpdatedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssUpdatedBy", DbType.String, ssENFolio.ssUpdatedBy);

}
insertSqlCmd.CreateParameter("@ssUpdatedOn", DbType.DateTime, ssENFolio.ssUpdatedOn);
insertSqlCmd.CreateParameter("@ssMinuteSelected", DbType.Int32, ssENFolio.ssMinuteSelected);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateFolio", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENFolio.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeFolio
/// </summary>

public static async Task CreateOrUpdateSomeFolio(IRequestContext requestContext,RL_4f8b259bdd04db22be8fb771f1ad1d4f inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeFolio", "278ad874-ac3c-4fbf-b332-0f512809d5f8.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeFolio", "278ad874-ac3c-4fbf-b332-0f512809d5f8.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENFolioEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@IsDraft, "isdraft") ?? "isdraft") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@FolioNumber, "folionumber") ?? "folionumber") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@CanProveedorCancel, "canproveedorcancel") ?? "canproveedorcancel") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@OrderId, "orderid") ?? "orderid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@SupplierId, "supplierid") ?? "supplierid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@CompanyId, "companyid") ?? "companyid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@FolioStatusId, "foliostatusid") ?? "foliostatusid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@TotalAmount, "totalamount") ?? "totalamount") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@TotalIVA_Amount, "totaliva_amount") ?? "totaliva_amount") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@PartialAmount, "partialamount") ?? "partialamount") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@FirstApproverUserId, "firstapproveruserid") ?? "firstapproveruserid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@ApprovalProcessTypeId, "approvalprocesstypeid") ?? "approvalprocesstypeid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@SAPEntryError, "sapentryerror") ?? "sapentryerror") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@MinuteSelected, "minuteselected") ?? "minuteselected") + ") VALUES ( unnest(@ssIsDraft),  unnest(@ssFolioNumber),  unnest(@ssCanProveedorCancel),  unnest(@ssOrderId),  unnest(@ssSupplierId),  unnest(@ssCompanyId),  unnest(@ssFolioStatusId),  unnest(@ssTotalAmount),  unnest(@ssTotalIVA_Amount),  unnest(@ssPartialAmount),  unnest(@ssCurrencyId),  unnest(@ssFirstApproverUserId),  unnest(@ssApprovalProcessTypeId),  unnest(@ssSAPEntryError),  unnest(@ssCreatedBy),  unnest(@ssCreatedOn),  unnest(@ssUpdatedBy),  unnest(@ssUpdatedOn),  unnest(@ssMinuteSelected)) ";
insertSql += "";

string updateSql = "UPDATE " + entityTableName + " SET " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@IsDraft, "isdraft") ?? "isdraft") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@IsDraft, "isdraft") ?? "isdraft") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@FolioNumber, "folionumber") ?? "folionumber") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@FolioNumber, "folionumber") ?? "folionumber") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@CanProveedorCancel, "canproveedorcancel") ?? "canproveedorcancel") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@CanProveedorCancel, "canproveedorcancel") ?? "canproveedorcancel") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@OrderId, "orderid") ?? "orderid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@OrderId, "orderid") ?? "orderid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@SupplierId, "supplierid") ?? "supplierid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@SupplierId, "supplierid") ?? "supplierid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@CompanyId, "companyid") ?? "companyid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@CompanyId, "companyid") ?? "companyid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@FolioStatusId, "foliostatusid") ?? "foliostatusid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@FolioStatusId, "foliostatusid") ?? "foliostatusid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@TotalAmount, "totalamount") ?? "totalamount") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@TotalAmount, "totalamount") ?? "totalamount") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@TotalIVA_Amount, "totaliva_amount") ?? "totaliva_amount") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@TotalIVA_Amount, "totaliva_amount") ?? "totaliva_amount") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@PartialAmount, "partialamount") ?? "partialamount") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@PartialAmount, "partialamount") ?? "partialamount") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@FirstApproverUserId, "firstapproveruserid") ?? "firstapproveruserid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@FirstApproverUserId, "firstapproveruserid") ?? "firstapproveruserid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@ApprovalProcessTypeId, "approvalprocesstypeid") ?? "approvalprocesstypeid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@ApprovalProcessTypeId, "approvalprocesstypeid") ?? "approvalprocesstypeid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@SAPEntryError, "sapentryerror") ?? "sapentryerror") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@SAPEntryError, "sapentryerror") ?? "sapentryerror") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@MinuteSelected, "minuteselected") ?? "minuteselected") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@MinuteSelected, "minuteselected") ?? "minuteselected") + " from ( select  unnest(@ssId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@Id, "id") ?? "id") + ",  unnest(@ssIsDraft) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@IsDraft, "isdraft") ?? "isdraft") + ",  unnest(@ssFolioNumber) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@FolioNumber, "folionumber") ?? "folionumber") + ",  unnest(@ssCanProveedorCancel) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@CanProveedorCancel, "canproveedorcancel") ?? "canproveedorcancel") + ",  unnest(@ssOrderId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@OrderId, "orderid") ?? "orderid") + ",  unnest(@ssSupplierId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@SupplierId, "supplierid") ?? "supplierid") + ",  unnest(@ssCompanyId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@CompanyId, "companyid") ?? "companyid") + ",  unnest(@ssFolioStatusId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@FolioStatusId, "foliostatusid") ?? "foliostatusid") + ",  unnest(@ssTotalAmount) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@TotalAmount, "totalamount") ?? "totalamount") + ",  unnest(@ssTotalIVA_Amount) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@TotalIVA_Amount, "totaliva_amount") ?? "totaliva_amount") + ",  unnest(@ssPartialAmount) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@PartialAmount, "partialamount") ?? "partialamount") + ",  unnest(@ssCurrencyId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid") + ",  unnest(@ssFirstApproverUserId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@FirstApproverUserId, "firstapproveruserid") ?? "firstapproveruserid") + ",  unnest(@ssApprovalProcessTypeId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@ApprovalProcessTypeId, "approvalprocesstypeid") ?? "approvalprocesstypeid") + ",  unnest(@ssSAPEntryError) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@SAPEntryError, "sapentryerror") ?? "sapentryerror") + ",  unnest(@ssCreatedBy) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ",  unnest(@ssCreatedOn) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + ",  unnest(@ssUpdatedBy) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby") + ",  unnest(@ssUpdatedOn) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon") + ",  unnest(@ssMinuteSelected) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@MinuteSelected, "minuteselected") ?? "minuteselected") + " ) as updateTable where " + entityTableName + "." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@Id, "id") ?? "id") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@Id, "id") ?? "id") + " ";
updateSql += "";

List<bool> insertIsDraftList = new List<bool>();
List<string> insertFolioNumberList = new List<string>();
List<bool> insertCanProveedorCancelList = new List<bool>();
List<object> insertOrderIdList = new List<object>();
List<object> insertSupplierIdList = new List<object>();
List<object> insertCompanyIdList = new List<object>();
List<object> insertFolioStatusIdList = new List<object>();
List<decimal> insertTotalAmountList = new List<decimal>();
List<decimal> insertTotalIVA_AmountList = new List<decimal>();
List<decimal> insertPartialAmountList = new List<decimal>();
List<object> insertCurrencyIdList = new List<object>();
List<object> insertFirstApproverUserIdList = new List<object>();
List<object> insertApprovalProcessTypeIdList = new List<object>();
List<string> insertSAPEntryErrorList = new List<string>();
List<object> insertCreatedByList = new List<object>();
List<DateTime> insertCreatedOnList = new List<DateTime>();
List<object> insertUpdatedByList = new List<object>();
List<DateTime> insertUpdatedOnList = new List<DateTime>();
List<int> insertMinuteSelectedList = new List<int>();

List<long> updateIdList = new List<long>();
List<bool> updateIsDraftList = new List<bool>();
List<string> updateFolioNumberList = new List<string>();
List<bool> updateCanProveedorCancelList = new List<bool>();
List<object> updateOrderIdList = new List<object>();
List<object> updateSupplierIdList = new List<object>();
List<object> updateCompanyIdList = new List<object>();
List<object> updateFolioStatusIdList = new List<object>();
List<decimal> updateTotalAmountList = new List<decimal>();
List<decimal> updateTotalIVA_AmountList = new List<decimal>();
List<decimal> updatePartialAmountList = new List<decimal>();
List<object> updateCurrencyIdList = new List<object>();
List<object> updateFirstApproverUserIdList = new List<object>();
List<object> updateApprovalProcessTypeIdList = new List<object>();
List<string> updateSAPEntryErrorList = new List<string>();
List<object> updateCreatedByList = new List<object>();
List<DateTime> updateCreatedOnList = new List<DateTime>();
List<object> updateUpdatedByList = new List<object>();
List<DateTime> updateUpdatedOnList = new List<DateTime>();
List<int> updateMinuteSelectedList = new List<int>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_cfeb2cf80ab683e7d9a9b5d02d9c9526)inParamSourceList.Current).ssENFolio;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
updateIsDraftList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsDraft));
updateFolioNumberList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssFolioNumber));
updateCanProveedorCancelList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssCanProveedorCancel));
if ((record.ssOrderId==0L)) {
updateOrderIdList.Add(null);
} else {
updateOrderIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssOrderId));
}
if ((record.ssSupplierId==0L)) {
updateSupplierIdList.Add(null);
} else {
updateSupplierIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssSupplierId));
}
if ((record.ssCompanyId==0L)) {
updateCompanyIdList.Add(null);
} else {
updateCompanyIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssCompanyId));
}
if ((record.ssFolioStatusId==0)) {
updateFolioStatusIdList.Add(null);
} else {
updateFolioStatusIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssFolioStatusId));
}
updateTotalAmountList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssTotalAmount));
updateTotalIVA_AmountList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssTotalIVA_Amount));
updatePartialAmountList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssPartialAmount));
if ((record.ssCurrencyId=="")) {
updateCurrencyIdList.Add(null);
} else {
updateCurrencyIdList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCurrencyId));
}
if ((record.ssFirstApproverUserId=="")) {
updateFirstApproverUserIdList.Add(null);
} else {
updateFirstApproverUserIdList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssFirstApproverUserId));
}
if ((record.ssApprovalProcessTypeId==0)) {
updateApprovalProcessTypeIdList.Add(null);
} else {
updateApprovalProcessTypeIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssApprovalProcessTypeId));
}
updateSAPEntryErrorList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssSAPEntryError));
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
updateMinuteSelectedList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssMinuteSelected));
} else {
insertIsDraftList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsDraft));
insertFolioNumberList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssFolioNumber));
insertCanProveedorCancelList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssCanProveedorCancel));
if ((record.ssOrderId==0L)) {
insertOrderIdList.Add(null);
} else {
insertOrderIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssOrderId));
}
if ((record.ssSupplierId==0L)) {
insertSupplierIdList.Add(null);
} else {
insertSupplierIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssSupplierId));
}
if ((record.ssCompanyId==0L)) {
insertCompanyIdList.Add(null);
} else {
insertCompanyIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssCompanyId));
}
if ((record.ssFolioStatusId==0)) {
insertFolioStatusIdList.Add(null);
} else {
insertFolioStatusIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssFolioStatusId));
}
insertTotalAmountList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssTotalAmount));
insertTotalIVA_AmountList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssTotalIVA_Amount));
insertPartialAmountList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssPartialAmount));
if ((record.ssCurrencyId=="")) {
insertCurrencyIdList.Add(null);
} else {
insertCurrencyIdList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCurrencyId));
}
if ((record.ssFirstApproverUserId=="")) {
insertFirstApproverUserIdList.Add(null);
} else {
insertFirstApproverUserIdList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssFirstApproverUserId));
}
if ((record.ssApprovalProcessTypeId==0)) {
insertApprovalProcessTypeIdList.Add(null);
} else {
insertApprovalProcessTypeIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssApprovalProcessTypeId));
}
insertSAPEntryErrorList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssSAPEntryError));
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
insertMinuteSelectedList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssMinuteSelected));
}
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertIsDraftList.IsEmpty() || !insertFolioNumberList.IsEmpty() || !insertCanProveedorCancelList.IsEmpty() || !insertOrderIdList.IsEmpty() || !insertSupplierIdList.IsEmpty() || !insertCompanyIdList.IsEmpty() || !insertFolioStatusIdList.IsEmpty() || !insertTotalAmountList.IsEmpty() || !insertTotalIVA_AmountList.IsEmpty() || !insertPartialAmountList.IsEmpty() || !insertCurrencyIdList.IsEmpty() || !insertFirstApproverUserIdList.IsEmpty() || !insertApprovalProcessTypeIdList.IsEmpty() || !insertSAPEntryErrorList.IsEmpty() || !insertCreatedByList.IsEmpty() || !insertCreatedOnList.IsEmpty() || !insertUpdatedByList.IsEmpty() || !insertUpdatedOnList.IsEmpty() || !insertMinuteSelectedList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssIsDraft",DbType.Boolean,insertIsDraftList);
executionService.CreateParameter(insertSqlCmd,"@ssFolioNumber",DbType.String,insertFolioNumberList);
executionService.CreateParameter(insertSqlCmd,"@ssCanProveedorCancel",DbType.Boolean,insertCanProveedorCancelList);
executionService.CreateParameter(insertSqlCmd,"@ssOrderId",DbType.Int64,insertOrderIdList);
executionService.CreateParameter(insertSqlCmd,"@ssSupplierId",DbType.Int64,insertSupplierIdList);
executionService.CreateParameter(insertSqlCmd,"@ssCompanyId",DbType.Int64,insertCompanyIdList);
executionService.CreateParameter(insertSqlCmd,"@ssFolioStatusId",DbType.Int32,insertFolioStatusIdList);
executionService.CreateParameter(insertSqlCmd,"@ssTotalAmount",DbType.Decimal,insertTotalAmountList);
executionService.CreateParameter(insertSqlCmd,"@ssTotalIVA_Amount",DbType.Decimal,insertTotalIVA_AmountList);
executionService.CreateParameter(insertSqlCmd,"@ssPartialAmount",DbType.Decimal,insertPartialAmountList);
executionService.CreateParameter(insertSqlCmd,"@ssCurrencyId",DbType.String,insertCurrencyIdList);
executionService.CreateParameter(insertSqlCmd,"@ssFirstApproverUserId",DbType.String,insertFirstApproverUserIdList);
executionService.CreateParameter(insertSqlCmd,"@ssApprovalProcessTypeId",DbType.Int32,insertApprovalProcessTypeIdList);
executionService.CreateParameter(insertSqlCmd,"@ssSAPEntryError",DbType.String,insertSAPEntryErrorList);
executionService.CreateParameter(insertSqlCmd,"@ssCreatedBy",DbType.String,insertCreatedByList);
executionService.CreateParameter(insertSqlCmd,"@ssCreatedOn",DbType.DateTime,insertCreatedOnList);
executionService.CreateParameter(insertSqlCmd,"@ssUpdatedBy",DbType.String,insertUpdatedByList);
executionService.CreateParameter(insertSqlCmd,"@ssUpdatedOn",DbType.DateTime,insertUpdatedOnList);
executionService.CreateParameter(insertSqlCmd,"@ssMinuteSelected",DbType.Int32,insertMinuteSelectedList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeFolio (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateIsDraftList.IsEmpty() || !updateFolioNumberList.IsEmpty() || !updateCanProveedorCancelList.IsEmpty() || !updateOrderIdList.IsEmpty() || !updateSupplierIdList.IsEmpty() || !updateCompanyIdList.IsEmpty() || !updateFolioStatusIdList.IsEmpty() || !updateTotalAmountList.IsEmpty() || !updateTotalIVA_AmountList.IsEmpty() || !updatePartialAmountList.IsEmpty() || !updateCurrencyIdList.IsEmpty() || !updateFirstApproverUserIdList.IsEmpty() || !updateApprovalProcessTypeIdList.IsEmpty() || !updateSAPEntryErrorList.IsEmpty() || !updateCreatedByList.IsEmpty() || !updateCreatedOnList.IsEmpty() || !updateUpdatedByList.IsEmpty() || !updateUpdatedOnList.IsEmpty() || !updateMinuteSelectedList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssIsDraft",DbType.Boolean,updateIsDraftList);
executionService.CreateParameter(updateSqlCmd,"@ssFolioNumber",DbType.String,updateFolioNumberList);
executionService.CreateParameter(updateSqlCmd,"@ssCanProveedorCancel",DbType.Boolean,updateCanProveedorCancelList);
executionService.CreateParameter(updateSqlCmd,"@ssOrderId",DbType.Int64,updateOrderIdList);
executionService.CreateParameter(updateSqlCmd,"@ssSupplierId",DbType.Int64,updateSupplierIdList);
executionService.CreateParameter(updateSqlCmd,"@ssCompanyId",DbType.Int64,updateCompanyIdList);
executionService.CreateParameter(updateSqlCmd,"@ssFolioStatusId",DbType.Int32,updateFolioStatusIdList);
executionService.CreateParameter(updateSqlCmd,"@ssTotalAmount",DbType.Decimal,updateTotalAmountList);
executionService.CreateParameter(updateSqlCmd,"@ssTotalIVA_Amount",DbType.Decimal,updateTotalIVA_AmountList);
executionService.CreateParameter(updateSqlCmd,"@ssPartialAmount",DbType.Decimal,updatePartialAmountList);
executionService.CreateParameter(updateSqlCmd,"@ssCurrencyId",DbType.String,updateCurrencyIdList);
executionService.CreateParameter(updateSqlCmd,"@ssFirstApproverUserId",DbType.String,updateFirstApproverUserIdList);
executionService.CreateParameter(updateSqlCmd,"@ssApprovalProcessTypeId",DbType.Int32,updateApprovalProcessTypeIdList);
executionService.CreateParameter(updateSqlCmd,"@ssSAPEntryError",DbType.String,updateSAPEntryErrorList);
executionService.CreateParameter(updateSqlCmd,"@ssCreatedBy",DbType.String,updateCreatedByList);
executionService.CreateParameter(updateSqlCmd,"@ssCreatedOn",DbType.DateTime,updateCreatedOnList);
executionService.CreateParameter(updateSqlCmd,"@ssUpdatedBy",DbType.String,updateUpdatedByList);
executionService.CreateParameter(updateSqlCmd,"@ssUpdatedOn",DbType.DateTime,updateUpdatedOnList);
executionService.CreateParameter(updateSqlCmd,"@ssMinuteSelected",DbType.Int32,updateMinuteSelectedList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeFolio (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteFolio
/// </summary>

public static async Task DeleteFolio(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteFolio", "278ad874-ac3c-4fbf-b332-0f512809d5f8.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteFolio", "278ad874-ac3c-4fbf-b332-0f512809d5f8.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENFolioEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteFolio", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllFolio
/// </summary>

public static async Task DeleteAllFolio(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllFolio", "278ad874-ac3c-4fbf-b332-0f512809d5f8.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllFolio", "278ad874-ac3c-4fbf-b332-0f512809d5f8.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENFolioEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteFolio", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetFolio
/// </summary>

public static async Task<RC_cfeb2cf80ab683e7d9a9b5d02d9c9526> GetFolio(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_cfeb2cf80ab683e7d9a9b5d02d9c9526 outParamRecord = default;
outParamRecord = new RC_cfeb2cf80ab683e7d9a9b5d02d9c9526();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetFolio", "278ad874-ac3c-4fbf-b332-0f512809d5f8.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetFolio", "278ad874-ac3c-4fbf-b332-0f512809d5f8.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@IsDraft, "isdraft") ?? "isdraft", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@FolioNumber, "folionumber") ?? "folionumber", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@CanProveedorCancel, "canproveedorcancel") ?? "canproveedorcancel", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@OrderId, "orderid") ?? "orderid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@SupplierId, "supplierid") ?? "supplierid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@CompanyId, "companyid") ?? "companyid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@FolioStatusId, "foliostatusid") ?? "foliostatusid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@TotalAmount, "totalamount") ?? "totalamount", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@TotalIVA_Amount, "totaliva_amount") ?? "totaliva_amount", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@PartialAmount, "partialamount") ?? "partialamount", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@FirstApproverUserId, "firstapproveruserid") ?? "firstapproveruserid", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@ApprovalProcessTypeId, "approvalprocesstypeid") ?? "approvalprocesstypeid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@SAPEntryError, "sapentryerror") ?? "sapentryerror", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@CreatedBy, "createdby") ?? "createdby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@CreatedOn, "createdon") ?? "createdon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@MinuteSelected, "minuteselected") ?? "minuteselected", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
" FROM " + ENFolioEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetFolio", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(20,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENFolioEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetFolioForUpdate
/// </summary>

public static async Task<RC_cfeb2cf80ab683e7d9a9b5d02d9c9526> GetFolioForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_cfeb2cf80ab683e7d9a9b5d02d9c9526 outParamRecord = default;
outParamRecord = new RC_cfeb2cf80ab683e7d9a9b5d02d9c9526();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetFolioForUpdate", "278ad874-ac3c-4fbf-b332-0f512809d5f8.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetFolioForUpdate", "278ad874-ac3c-4fbf-b332-0f512809d5f8.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@IsDraft, "isdraft") ?? "isdraft", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@FolioNumber, "folionumber") ?? "folionumber", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@CanProveedorCancel, "canproveedorcancel") ?? "canproveedorcancel", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@OrderId, "orderid") ?? "orderid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@SupplierId, "supplierid") ?? "supplierid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@CompanyId, "companyid") ?? "companyid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@FolioStatusId, "foliostatusid") ?? "foliostatusid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@TotalAmount, "totalamount") ?? "totalamount", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@TotalIVA_Amount, "totaliva_amount") ?? "totaliva_amount", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@PartialAmount, "partialamount") ?? "partialamount", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@FirstApproverUserId, "firstapproveruserid") ?? "firstapproveruserid", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@ApprovalProcessTypeId, "approvalprocesstypeid") ?? "approvalprocesstypeid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@SAPEntryError, "sapentryerror") ?? "sapentryerror", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@CreatedBy, "createdby") ?? "createdby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@CreatedOn, "createdon") ?? "createdon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@MinuteSelected, "minuteselected") ?? "minuteselected", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
" FROM " + ENFolioEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetFolioForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(20,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENFolioEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateFolio
/// </summary>

public static async Task UpdateFolio(IRequestContext requestContext,BitArray usedFields,RC_cfeb2cf80ab683e7d9a9b5d02d9c9526 inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateFolio", "278ad874-ac3c-4fbf-b332-0f512809d5f8.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateFolio", "278ad874-ac3c-4fbf-b332-0f512809d5f8.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord ssENFolio = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(20,true);
}
string updateSet = "UPDATE " + ENFolioEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@IsDraft, "isdraft") ?? "isdraft") + " = @ssIsDraft"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@FolioNumber, "folionumber") ?? "folionumber") + " = @ssFolioNumber"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@CanProveedorCancel, "canproveedorcancel") ?? "canproveedorcancel") + " = @ssCanProveedorCancel"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@OrderId, "orderid") ?? "orderid") + " = @ssOrderId"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@SupplierId, "supplierid") ?? "supplierid") + " = @ssSupplierId"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@CompanyId, "companyid") ?? "companyid") + " = @ssCompanyId"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@FolioStatusId, "foliostatusid") ?? "foliostatusid") + " = @ssFolioStatusId"): parameters);
parameters = (usedFields[8] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@TotalAmount, "totalamount") ?? "totalamount") + " = @ssTotalAmount"): parameters);
parameters = (usedFields[9] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@TotalIVA_Amount, "totaliva_amount") ?? "totaliva_amount") + " = @ssTotalIVA_Amount"): parameters);
parameters = (usedFields[10] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@PartialAmount, "partialamount") ?? "partialamount") + " = @ssPartialAmount"): parameters);
parameters = (usedFields[11] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid") + " = @ssCurrencyId"): parameters);
parameters = (usedFields[12] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@FirstApproverUserId, "firstapproveruserid") ?? "firstapproveruserid") + " = @ssFirstApproverUserId"): parameters);
parameters = (usedFields[13] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@ApprovalProcessTypeId, "approvalprocesstypeid") ?? "approvalprocesstypeid") + " = @ssApprovalProcessTypeId"): parameters);
parameters = (usedFields[14] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@SAPEntryError, "sapentryerror") ?? "sapentryerror") + " = @ssSAPEntryError"): parameters);
parameters = (usedFields[15] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = @ssCreatedBy"): parameters);
parameters = (usedFields[16] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = @ssCreatedOn"): parameters);
parameters = (usedFields[17] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby") + " = @ssUpdatedBy"): parameters);
parameters = (usedFields[18] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon") + " = @ssUpdatedOn"): parameters);
parameters = (usedFields[19] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@MinuteSelected, "minuteselected") ?? "minuteselected") + " = @ssMinuteSelected"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENFolio_ssId_Folio";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@IsDraft, "isdraft") ?? "isdraft") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Folio, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioAttributeKeys.@IsDraft, "isdraft") ?? "isdraft") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssIsDraft", DbType.Boolean, ssENFolio.ssIsDraft);
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssFolioNumber", DbType.String, ssENFolio.ssFolioNumber);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssCanProveedorCancel", DbType.Boolean, ssENFolio.ssCanProveedorCancel);
}
if(usedFields[4]) {
if ((ssENFolio.ssOrderId==0L)) {
sqlCmd.CreateParameter("@ssOrderId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssOrderId", DbType.Int64, ssENFolio.ssOrderId);

}
}
if(usedFields[5]) {
if ((ssENFolio.ssSupplierId==0L)) {
sqlCmd.CreateParameter("@ssSupplierId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssSupplierId", DbType.Int64, ssENFolio.ssSupplierId);

}
}
if(usedFields[6]) {
if ((ssENFolio.ssCompanyId==0L)) {
sqlCmd.CreateParameter("@ssCompanyId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCompanyId", DbType.Int64, ssENFolio.ssCompanyId);

}
}
if(usedFields[7]) {
if ((ssENFolio.ssFolioStatusId==0)) {
sqlCmd.CreateParameter("@ssFolioStatusId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssFolioStatusId", DbType.Int32, ssENFolio.ssFolioStatusId);

}
}
if(usedFields[8]) {
var TotalAmountParameter = sqlCmd.CreateParameter("@ssTotalAmount", DbType.Decimal, ssENFolio.ssTotalAmount);
{
    string decimalAsStr = ssENFolio.ssTotalAmount.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {TotalAmountParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[9]) {
var TotalIVA_AmountParameter = sqlCmd.CreateParameter("@ssTotalIVA_Amount", DbType.Decimal, ssENFolio.ssTotalIVA_Amount);
{
    string decimalAsStr = ssENFolio.ssTotalIVA_Amount.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {TotalIVA_AmountParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[10]) {
var PartialAmountParameter = sqlCmd.CreateParameter("@ssPartialAmount", DbType.Decimal, ssENFolio.ssPartialAmount);
{
    string decimalAsStr = ssENFolio.ssPartialAmount.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {PartialAmountParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[11]) {
if ((ssENFolio.ssCurrencyId=="")) {
sqlCmd.CreateParameter("@ssCurrencyId", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCurrencyId", DbType.String, ssENFolio.ssCurrencyId);

}
}
if(usedFields[12]) {
if ((ssENFolio.ssFirstApproverUserId=="")) {
sqlCmd.CreateParameter("@ssFirstApproverUserId", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssFirstApproverUserId", DbType.String, ssENFolio.ssFirstApproverUserId);

}
}
if(usedFields[13]) {
if ((ssENFolio.ssApprovalProcessTypeId==0)) {
sqlCmd.CreateParameter("@ssApprovalProcessTypeId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssApprovalProcessTypeId", DbType.Int32, ssENFolio.ssApprovalProcessTypeId);

}
}
if(usedFields[14]) {
sqlCmd.CreateParameter("@ssSAPEntryError", DbType.String, ssENFolio.ssSAPEntryError);
}
if(usedFields[15]) {
if ((ssENFolio.ssCreatedBy=="")) {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENFolio.ssCreatedBy);

}
}
if(usedFields[16]) {
sqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENFolio.ssCreatedOn);
}
if(usedFields[17]) {
if ((ssENFolio.ssUpdatedBy=="")) {
sqlCmd.CreateParameter("@ssUpdatedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssUpdatedBy", DbType.String, ssENFolio.ssUpdatedBy);

}
}
if(usedFields[18]) {
sqlCmd.CreateParameter("@ssUpdatedOn", DbType.DateTime, ssENFolio.ssUpdatedOn);
}
if(usedFields[19]) {
sqlCmd.CreateParameter("@ssMinuteSelected", DbType.Int32, ssENFolio.ssMinuteSelected);
}
sqlCmd.CreateParameter("@idparam_ssENFolio_ssId_Folio", DbType.Int64, ssENFolio.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateFolio", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("Folio", ssENFolio.ssId.ToString()); }}
}
return;
}

}
}
