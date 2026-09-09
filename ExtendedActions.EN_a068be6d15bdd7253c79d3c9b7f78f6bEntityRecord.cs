using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateFolioExtended
/// </summary>

public static async Task<long> CreateFolioExtended(IRequestContext requestContext,RC_ad92b2c217228db10c71baf90a615ea5 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateFolioExtended", "3adfc393-76f4-4ca5-b94e-e1429c56600b.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateFolioExtended", "3adfc393-76f4-4ca5-b94e-e1429c56600b.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_a068be6d15bdd7253c79d3c9b7f78f6bEntityRecord ssENFolioExtended = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENFolioExtendedEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@Id, "id") ?? "id") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@IsAdvPayment, "isadvpayment") ?? "isadvpayment") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@AdvPaymentValue, "advpaymentvalue") ?? "advpaymentvalue") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@IsCreditNote, "iscreditnote") ?? "iscreditnote") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@CreditNoteValue, "creditnotevalue") ?? "creditnotevalue") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@IsVoucher, "isvoucher") ?? "isvoucher") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@VoucherValue, "vouchervalue") ?? "vouchervalue") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@IsNa, "isna") ?? "isna") + "" +
" ) VALUES (" +
" @ssId" +
", @ssIsAdvPayment" +
", @ssAdvPaymentValue" +
", @ssIsCreditNote" +
", @ssCreditNoteValue" +
", @ssIsVoucher" +
", @ssVoucherValue" +
", @ssIsNa" +
" )";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssId", DbType.Int64, ssENFolioExtended.ssId);
insertSqlCmd.CreateParameter("@ssIsAdvPayment", DbType.Boolean, ssENFolioExtended.ssIsAdvPayment);
var AdvPaymentValueParameter = insertSqlCmd.CreateParameter("@ssAdvPaymentValue", DbType.Decimal, ssENFolioExtended.ssAdvPaymentValue);
{
    string decimalAsStr = ssENFolioExtended.ssAdvPaymentValue.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {AdvPaymentValueParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
insertSqlCmd.CreateParameter("@ssIsCreditNote", DbType.Boolean, ssENFolioExtended.ssIsCreditNote);
var CreditNoteValueParameter = insertSqlCmd.CreateParameter("@ssCreditNoteValue", DbType.Decimal, ssENFolioExtended.ssCreditNoteValue);
{
    string decimalAsStr = ssENFolioExtended.ssCreditNoteValue.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {CreditNoteValueParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
insertSqlCmd.CreateParameter("@ssIsVoucher", DbType.Boolean, ssENFolioExtended.ssIsVoucher);
var VoucherValueParameter = insertSqlCmd.CreateParameter("@ssVoucherValue", DbType.Decimal, ssENFolioExtended.ssVoucherValue);
{
    string decimalAsStr = ssENFolioExtended.ssVoucherValue.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {VoucherValueParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
insertSqlCmd.CreateParameter("@ssIsNa", DbType.Boolean, ssENFolioExtended.ssIsNa);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateFolioExtended", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
outParamId = ssENFolioExtended.ssId;
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateFolioExtended
/// </summary>

public static async Task<long> CreateOrUpdateFolioExtended(IRequestContext requestContext,BitArray usedFields,RC_ad92b2c217228db10c71baf90a615ea5 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateFolioExtended", "3adfc393-76f4-4ca5-b94e-e1429c56600b.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateFolioExtended", "3adfc393-76f4-4ca5-b94e-e1429c56600b.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_a068be6d15bdd7253c79d3c9b7f78f6bEntityRecord ssENFolioExtended = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(8,true);
}
string updateSet = "UPDATE " + ENFolioExtendedEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@IsAdvPayment, "isadvpayment") ?? "isadvpayment") + " = @ssIsAdvPayment"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@AdvPaymentValue, "advpaymentvalue") ?? "advpaymentvalue") + " = @ssAdvPaymentValue"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@IsCreditNote, "iscreditnote") ?? "iscreditnote") + " = @ssIsCreditNote"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@CreditNoteValue, "creditnotevalue") ?? "creditnotevalue") + " = @ssCreditNoteValue"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@IsVoucher, "isvoucher") ?? "isvoucher") + " = @ssIsVoucher"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@VoucherValue, "vouchervalue") ?? "vouchervalue") + " = @ssVoucherValue"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@IsNa, "isna") ?? "isna") + " = @ssIsNa"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENFolioExtended_ssId_FolioExtended";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@IsAdvPayment, "isadvpayment") ?? "isadvpayment") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@IsAdvPayment, "isadvpayment") ?? "isadvpayment") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssIsAdvPayment", DbType.Boolean, ssENFolioExtended.ssIsAdvPayment);
}
if(usedFields[2]) {
var AdvPaymentValueParameter = sqlCmd.CreateParameter("@ssAdvPaymentValue", DbType.Decimal, ssENFolioExtended.ssAdvPaymentValue);
{
    string decimalAsStr = ssENFolioExtended.ssAdvPaymentValue.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {AdvPaymentValueParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssIsCreditNote", DbType.Boolean, ssENFolioExtended.ssIsCreditNote);
}
if(usedFields[4]) {
var CreditNoteValueParameter = sqlCmd.CreateParameter("@ssCreditNoteValue", DbType.Decimal, ssENFolioExtended.ssCreditNoteValue);
{
    string decimalAsStr = ssENFolioExtended.ssCreditNoteValue.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {CreditNoteValueParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssIsVoucher", DbType.Boolean, ssENFolioExtended.ssIsVoucher);
}
if(usedFields[6]) {
var VoucherValueParameter = sqlCmd.CreateParameter("@ssVoucherValue", DbType.Decimal, ssENFolioExtended.ssVoucherValue);
{
    string decimalAsStr = ssENFolioExtended.ssVoucherValue.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {VoucherValueParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssIsNa", DbType.Boolean, ssENFolioExtended.ssIsNa);
}
sqlCmd.CreateParameter("@idparam_ssENFolioExtended_ssId_FolioExtended", DbType.Int64, ssENFolioExtended.ssId);
int counter = 0;
if(ssENFolioExtended.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateFolioExtended (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENFolioExtendedEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@Id, "id") ?? "id") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@IsAdvPayment, "isadvpayment") ?? "isadvpayment") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@AdvPaymentValue, "advpaymentvalue") ?? "advpaymentvalue") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@IsCreditNote, "iscreditnote") ?? "iscreditnote") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@CreditNoteValue, "creditnotevalue") ?? "creditnotevalue") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@IsVoucher, "isvoucher") ?? "isvoucher") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@VoucherValue, "vouchervalue") ?? "vouchervalue") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@IsNa, "isna") ?? "isna") + "" +
" ) VALUES (" +
" @ssId" +
", @ssIsAdvPayment" +
", @ssAdvPaymentValue" +
", @ssIsCreditNote" +
", @ssCreditNoteValue" +
", @ssIsVoucher" +
", @ssVoucherValue" +
", @ssIsNa" +
" )";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssId", DbType.Int64, ssENFolioExtended.ssId);
insertSqlCmd.CreateParameter("@ssIsAdvPayment", DbType.Boolean, ssENFolioExtended.ssIsAdvPayment);
var AdvPaymentValueParameter = insertSqlCmd.CreateParameter("@ssAdvPaymentValue", DbType.Decimal, ssENFolioExtended.ssAdvPaymentValue);
{
    string decimalAsStr = ssENFolioExtended.ssAdvPaymentValue.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {AdvPaymentValueParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
insertSqlCmd.CreateParameter("@ssIsCreditNote", DbType.Boolean, ssENFolioExtended.ssIsCreditNote);
var CreditNoteValueParameter = insertSqlCmd.CreateParameter("@ssCreditNoteValue", DbType.Decimal, ssENFolioExtended.ssCreditNoteValue);
{
    string decimalAsStr = ssENFolioExtended.ssCreditNoteValue.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {CreditNoteValueParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
insertSqlCmd.CreateParameter("@ssIsVoucher", DbType.Boolean, ssENFolioExtended.ssIsVoucher);
var VoucherValueParameter = insertSqlCmd.CreateParameter("@ssVoucherValue", DbType.Decimal, ssENFolioExtended.ssVoucherValue);
{
    string decimalAsStr = ssENFolioExtended.ssVoucherValue.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {VoucherValueParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
insertSqlCmd.CreateParameter("@ssIsNa", DbType.Boolean, ssENFolioExtended.ssIsNa);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateFolioExtended", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
outParamId = ssENFolioExtended.ssId;
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENFolioExtended.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeFolioExtended
/// </summary>

public static async Task CreateOrUpdateSomeFolioExtended(IRequestContext requestContext,RL_abf5dc59037dde79c92447e12cf9bfc9 inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeFolioExtended", "3adfc393-76f4-4ca5-b94e-e1429c56600b.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeFolioExtended", "3adfc393-76f4-4ca5-b94e-e1429c56600b.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENFolioExtendedEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@Id, "id") ?? "id") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@IsAdvPayment, "isadvpayment") ?? "isadvpayment") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@AdvPaymentValue, "advpaymentvalue") ?? "advpaymentvalue") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@IsCreditNote, "iscreditnote") ?? "iscreditnote") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@CreditNoteValue, "creditnotevalue") ?? "creditnotevalue") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@IsVoucher, "isvoucher") ?? "isvoucher") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@VoucherValue, "vouchervalue") ?? "vouchervalue") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@IsNa, "isna") ?? "isna") + ") VALUES ( unnest(@ssId),  unnest(@ssIsAdvPayment),  unnest(@ssAdvPaymentValue),  unnest(@ssIsCreditNote),  unnest(@ssCreditNoteValue),  unnest(@ssIsVoucher),  unnest(@ssVoucherValue),  unnest(@ssIsNa)) ON CONFLICT(" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@Id, "id") ?? "id") + ") do update set " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@IsAdvPayment, "isadvpayment") ?? "isadvpayment") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@IsAdvPayment, "isadvpayment") ?? "isadvpayment") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@AdvPaymentValue, "advpaymentvalue") ?? "advpaymentvalue") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@AdvPaymentValue, "advpaymentvalue") ?? "advpaymentvalue") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@IsCreditNote, "iscreditnote") ?? "iscreditnote") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@IsCreditNote, "iscreditnote") ?? "iscreditnote") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@CreditNoteValue, "creditnotevalue") ?? "creditnotevalue") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@CreditNoteValue, "creditnotevalue") ?? "creditnotevalue") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@IsVoucher, "isvoucher") ?? "isvoucher") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@IsVoucher, "isvoucher") ?? "isvoucher") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@VoucherValue, "vouchervalue") ?? "vouchervalue") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@VoucherValue, "vouchervalue") ?? "vouchervalue") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@IsNa, "isna") ?? "isna") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@IsNa, "isna") ?? "isna") + " ";
insertSql += "";


List<object> insertIdList = new List<object>();
List<bool> insertIsAdvPaymentList = new List<bool>();
List<decimal> insertAdvPaymentValueList = new List<decimal>();
List<bool> insertIsCreditNoteList = new List<bool>();
List<decimal> insertCreditNoteValueList = new List<decimal>();
List<bool> insertIsVoucherList = new List<bool>();
List<decimal> insertVoucherValueList = new List<decimal>();
List<bool> insertIsNaList = new List<bool>();


var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_ad92b2c217228db10c71baf90a615ea5)inParamSourceList.Current).ssENFolioExtended;
insertIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
insertIsAdvPaymentList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsAdvPayment));
insertAdvPaymentValueList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssAdvPaymentValue));
insertIsCreditNoteList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsCreditNote));
insertCreditNoteValueList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssCreditNoteValue));
insertIsVoucherList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsVoucher));
insertVoucherValueList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssVoucherValue));
insertIsNaList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsNa));
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertIdList.IsEmpty() || !insertIsAdvPaymentList.IsEmpty() || !insertAdvPaymentValueList.IsEmpty() || !insertIsCreditNoteList.IsEmpty() || !insertCreditNoteValueList.IsEmpty() || !insertIsVoucherList.IsEmpty() || !insertVoucherValueList.IsEmpty() || !insertIsNaList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssId",DbType.Int64,insertIdList);
executionService.CreateParameter(insertSqlCmd,"@ssIsAdvPayment",DbType.Boolean,insertIsAdvPaymentList);
executionService.CreateParameter(insertSqlCmd,"@ssAdvPaymentValue",DbType.Decimal,insertAdvPaymentValueList);
executionService.CreateParameter(insertSqlCmd,"@ssIsCreditNote",DbType.Boolean,insertIsCreditNoteList);
executionService.CreateParameter(insertSqlCmd,"@ssCreditNoteValue",DbType.Decimal,insertCreditNoteValueList);
executionService.CreateParameter(insertSqlCmd,"@ssIsVoucher",DbType.Boolean,insertIsVoucherList);
executionService.CreateParameter(insertSqlCmd,"@ssVoucherValue",DbType.Decimal,insertVoucherValueList);
executionService.CreateParameter(insertSqlCmd,"@ssIsNa",DbType.Boolean,insertIsNaList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeFolioExtended (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteFolioExtended
/// </summary>

public static async Task DeleteFolioExtended(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteFolioExtended", "3adfc393-76f4-4ca5-b94e-e1429c56600b.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteFolioExtended", "3adfc393-76f4-4ca5-b94e-e1429c56600b.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENFolioExtendedEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteFolioExtended", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllFolioExtended
/// </summary>

public static async Task DeleteAllFolioExtended(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllFolioExtended", "3adfc393-76f4-4ca5-b94e-e1429c56600b.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllFolioExtended", "3adfc393-76f4-4ca5-b94e-e1429c56600b.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENFolioExtendedEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteFolioExtended", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetFolioExtended
/// </summary>

public static async Task<RC_ad92b2c217228db10c71baf90a615ea5> GetFolioExtended(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_ad92b2c217228db10c71baf90a615ea5 outParamRecord = default;
outParamRecord = new RC_ad92b2c217228db10c71baf90a615ea5();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetFolioExtended", "3adfc393-76f4-4ca5-b94e-e1429c56600b.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetFolioExtended", "3adfc393-76f4-4ca5-b94e-e1429c56600b.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@IsAdvPayment, "isadvpayment") ?? "isadvpayment", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@AdvPaymentValue, "advpaymentvalue") ?? "advpaymentvalue", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@IsCreditNote, "iscreditnote") ?? "iscreditnote", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@CreditNoteValue, "creditnotevalue") ?? "creditnotevalue", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@IsVoucher, "isvoucher") ?? "isvoucher", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@VoucherValue, "vouchervalue") ?? "vouchervalue", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@IsNa, "isna") ?? "isna", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
" FROM " + ENFolioExtendedEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetFolioExtended", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(8,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENFolioExtendedEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetFolioExtendedForUpdate
/// </summary>

public static async Task<RC_ad92b2c217228db10c71baf90a615ea5> GetFolioExtendedForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_ad92b2c217228db10c71baf90a615ea5 outParamRecord = default;
outParamRecord = new RC_ad92b2c217228db10c71baf90a615ea5();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetFolioExtendedForUpdate", "3adfc393-76f4-4ca5-b94e-e1429c56600b.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetFolioExtendedForUpdate", "3adfc393-76f4-4ca5-b94e-e1429c56600b.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@IsAdvPayment, "isadvpayment") ?? "isadvpayment", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@AdvPaymentValue, "advpaymentvalue") ?? "advpaymentvalue", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@IsCreditNote, "iscreditnote") ?? "iscreditnote", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@CreditNoteValue, "creditnotevalue") ?? "creditnotevalue", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@IsVoucher, "isvoucher") ?? "isvoucher", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@VoucherValue, "vouchervalue") ?? "vouchervalue", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@IsNa, "isna") ?? "isna", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
" FROM " + ENFolioExtendedEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetFolioExtendedForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(8,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENFolioExtendedEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateFolioExtended
/// </summary>

public static async Task UpdateFolioExtended(IRequestContext requestContext,BitArray usedFields,RC_ad92b2c217228db10c71baf90a615ea5 inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateFolioExtended", "3adfc393-76f4-4ca5-b94e-e1429c56600b.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateFolioExtended", "3adfc393-76f4-4ca5-b94e-e1429c56600b.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_a068be6d15bdd7253c79d3c9b7f78f6bEntityRecord ssENFolioExtended = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(8,true);
}
string updateSet = "UPDATE " + ENFolioExtendedEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@IsAdvPayment, "isadvpayment") ?? "isadvpayment") + " = @ssIsAdvPayment"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@AdvPaymentValue, "advpaymentvalue") ?? "advpaymentvalue") + " = @ssAdvPaymentValue"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@IsCreditNote, "iscreditnote") ?? "iscreditnote") + " = @ssIsCreditNote"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@CreditNoteValue, "creditnotevalue") ?? "creditnotevalue") + " = @ssCreditNoteValue"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@IsVoucher, "isvoucher") ?? "isvoucher") + " = @ssIsVoucher"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@VoucherValue, "vouchervalue") ?? "vouchervalue") + " = @ssVoucherValue"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@IsNa, "isna") ?? "isna") + " = @ssIsNa"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENFolioExtended_ssId_FolioExtended";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@IsAdvPayment, "isadvpayment") ?? "isadvpayment") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioExtended, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioExtendedAttributeKeys.@IsAdvPayment, "isadvpayment") ?? "isadvpayment") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssIsAdvPayment", DbType.Boolean, ssENFolioExtended.ssIsAdvPayment);
}
if(usedFields[2]) {
var AdvPaymentValueParameter = sqlCmd.CreateParameter("@ssAdvPaymentValue", DbType.Decimal, ssENFolioExtended.ssAdvPaymentValue);
{
    string decimalAsStr = ssENFolioExtended.ssAdvPaymentValue.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {AdvPaymentValueParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssIsCreditNote", DbType.Boolean, ssENFolioExtended.ssIsCreditNote);
}
if(usedFields[4]) {
var CreditNoteValueParameter = sqlCmd.CreateParameter("@ssCreditNoteValue", DbType.Decimal, ssENFolioExtended.ssCreditNoteValue);
{
    string decimalAsStr = ssENFolioExtended.ssCreditNoteValue.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {CreditNoteValueParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssIsVoucher", DbType.Boolean, ssENFolioExtended.ssIsVoucher);
}
if(usedFields[6]) {
var VoucherValueParameter = sqlCmd.CreateParameter("@ssVoucherValue", DbType.Decimal, ssENFolioExtended.ssVoucherValue);
{
    string decimalAsStr = ssENFolioExtended.ssVoucherValue.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {VoucherValueParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssIsNa", DbType.Boolean, ssENFolioExtended.ssIsNa);
}
sqlCmd.CreateParameter("@idparam_ssENFolioExtended_ssId_FolioExtended", DbType.Int64, ssENFolioExtended.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateFolioExtended", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("FolioExtended", ssENFolioExtended.ssId.ToString()); }}
}
return;
}

}
}
