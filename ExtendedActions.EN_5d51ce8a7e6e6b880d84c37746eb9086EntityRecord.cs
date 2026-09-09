using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateInvoiceExtendedForeigner
/// </summary>

public static async Task<long> CreateInvoiceExtendedForeigner(IRequestContext requestContext,RC_decbed55750bb4030b04e46c0306e56b inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateInvoiceExtendedForeigner", "35affc27-4b67-48b1-8907-c99b340dc755.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateInvoiceExtendedForeigner", "35affc27-4b67-48b1-8907-c99b340dc755.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_5d51ce8a7e6e6b880d84c37746eb9086EntityRecord ssENInvoiceExtendedForeigner = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENInvoiceExtendedForeignerEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@Id, "id") ?? "id") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@InvoiceNumber, "invoicenumber") ?? "invoicenumber") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@Direction, "direction") ?? "direction") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@ReceiverSocialReason, "receiversocialreason") ?? "receiversocialreason") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@ReceiverRFC, "receiverrfc") ?? "receiverrfc") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@IssuerSocialReason, "issuersocialreason") ?? "issuersocialreason") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@IssuerTaxId, "issuertaxid") ?? "issuertaxid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@InvoiceDate, "invoicedate") ?? "invoicedate") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@TotalAmount, "totalamount") ?? "totalamount") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@Currency, "currency") ?? "currency") + "" +
" ) VALUES (" +
" @ssId" +
", @ssInvoiceNumber" +
", @ssDirection" +
", @ssReceiverSocialReason" +
", @ssReceiverRFC" +
", @ssIssuerSocialReason" +
", @ssIssuerTaxId" +
", @ssInvoiceDate" +
", @ssTotalAmount" +
", @ssCurrency" +
" )";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssId", DbType.Int64, ssENInvoiceExtendedForeigner.ssId);
insertSqlCmd.CreateParameter("@ssInvoiceNumber", DbType.String, ssENInvoiceExtendedForeigner.ssInvoiceNumber);
insertSqlCmd.CreateParameter("@ssDirection", DbType.String, ssENInvoiceExtendedForeigner.ssDirection);
insertSqlCmd.CreateParameter("@ssReceiverSocialReason", DbType.String, ssENInvoiceExtendedForeigner.ssReceiverSocialReason);
insertSqlCmd.CreateParameter("@ssReceiverRFC", DbType.String, ssENInvoiceExtendedForeigner.ssReceiverRFC);
insertSqlCmd.CreateParameter("@ssIssuerSocialReason", DbType.String, ssENInvoiceExtendedForeigner.ssIssuerSocialReason);
insertSqlCmd.CreateParameter("@ssIssuerTaxId", DbType.String, ssENInvoiceExtendedForeigner.ssIssuerTaxId);
insertSqlCmd.CreateParameter("@ssInvoiceDate", DbType.DateTime, ssENInvoiceExtendedForeigner.ssInvoiceDate);
var TotalAmountParameter = insertSqlCmd.CreateParameter("@ssTotalAmount", DbType.Decimal, ssENInvoiceExtendedForeigner.ssTotalAmount);
{
    string decimalAsStr = ssENInvoiceExtendedForeigner.ssTotalAmount.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {TotalAmountParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
if ((ssENInvoiceExtendedForeigner.ssCurrency=="")) {
insertSqlCmd.CreateParameter("@ssCurrency", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCurrency", DbType.String, ssENInvoiceExtendedForeigner.ssCurrency);

}
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateInvoiceExtendedForeigner", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
outParamId = ssENInvoiceExtendedForeigner.ssId;
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateInvoiceExtendedForeigner
/// </summary>

public static async Task<long> CreateOrUpdateInvoiceExtendedForeigner(IRequestContext requestContext,BitArray usedFields,RC_decbed55750bb4030b04e46c0306e56b inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateInvoiceExtendedForeigner", "35affc27-4b67-48b1-8907-c99b340dc755.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateInvoiceExtendedForeigner", "35affc27-4b67-48b1-8907-c99b340dc755.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_5d51ce8a7e6e6b880d84c37746eb9086EntityRecord ssENInvoiceExtendedForeigner = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(10,true);
}
string updateSet = "UPDATE " + ENInvoiceExtendedForeignerEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@InvoiceNumber, "invoicenumber") ?? "invoicenumber") + " = @ssInvoiceNumber"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@Direction, "direction") ?? "direction") + " = @ssDirection"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@ReceiverSocialReason, "receiversocialreason") ?? "receiversocialreason") + " = @ssReceiverSocialReason"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@ReceiverRFC, "receiverrfc") ?? "receiverrfc") + " = @ssReceiverRFC"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@IssuerSocialReason, "issuersocialreason") ?? "issuersocialreason") + " = @ssIssuerSocialReason"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@IssuerTaxId, "issuertaxid") ?? "issuertaxid") + " = @ssIssuerTaxId"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@InvoiceDate, "invoicedate") ?? "invoicedate") + " = @ssInvoiceDate"): parameters);
parameters = (usedFields[8] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@TotalAmount, "totalamount") ?? "totalamount") + " = @ssTotalAmount"): parameters);
parameters = (usedFields[9] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@Currency, "currency") ?? "currency") + " = @ssCurrency"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENInvoiceExtndedForeigner_ssd_InvoiceExtenedForeigner";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@TotalAmount, "totalamount") ?? "totalamount") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@TotalAmount, "totalamount") ?? "totalamount") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssInvoiceNumber", DbType.String, ssENInvoiceExtendedForeigner.ssInvoiceNumber);
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssDirection", DbType.String, ssENInvoiceExtendedForeigner.ssDirection);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssReceiverSocialReason", DbType.String, ssENInvoiceExtendedForeigner.ssReceiverSocialReason);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssReceiverRFC", DbType.String, ssENInvoiceExtendedForeigner.ssReceiverRFC);
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssIssuerSocialReason", DbType.String, ssENInvoiceExtendedForeigner.ssIssuerSocialReason);
}
if(usedFields[6]) {
sqlCmd.CreateParameter("@ssIssuerTaxId", DbType.String, ssENInvoiceExtendedForeigner.ssIssuerTaxId);
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssInvoiceDate", DbType.DateTime, ssENInvoiceExtendedForeigner.ssInvoiceDate);
}
if(usedFields[8]) {
var TotalAmountParameter = sqlCmd.CreateParameter("@ssTotalAmount", DbType.Decimal, ssENInvoiceExtendedForeigner.ssTotalAmount);
{
    string decimalAsStr = ssENInvoiceExtendedForeigner.ssTotalAmount.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {TotalAmountParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[9]) {
if ((ssENInvoiceExtendedForeigner.ssCurrency=="")) {
sqlCmd.CreateParameter("@ssCurrency", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCurrency", DbType.String, ssENInvoiceExtendedForeigner.ssCurrency);

}
}
sqlCmd.CreateParameter("@idparam_ssENInvoiceExtndedForeigner_ssd_InvoiceExtenedForeigner", DbType.Int64, ssENInvoiceExtendedForeigner.ssId);
int counter = 0;
if(ssENInvoiceExtendedForeigner.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateInvoiceExtendedForeigner (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENInvoiceExtendedForeignerEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@Id, "id") ?? "id") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@InvoiceNumber, "invoicenumber") ?? "invoicenumber") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@Direction, "direction") ?? "direction") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@ReceiverSocialReason, "receiversocialreason") ?? "receiversocialreason") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@ReceiverRFC, "receiverrfc") ?? "receiverrfc") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@IssuerSocialReason, "issuersocialreason") ?? "issuersocialreason") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@IssuerTaxId, "issuertaxid") ?? "issuertaxid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@InvoiceDate, "invoicedate") ?? "invoicedate") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@TotalAmount, "totalamount") ?? "totalamount") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@Currency, "currency") ?? "currency") + "" +
" ) VALUES (" +
" @ssId" +
", @ssInvoiceNumber" +
", @ssDirection" +
", @ssReceiverSocialReason" +
", @ssReceiverRFC" +
", @ssIssuerSocialReason" +
", @ssIssuerTaxId" +
", @ssInvoiceDate" +
", @ssTotalAmount" +
", @ssCurrency" +
" )";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssId", DbType.Int64, ssENInvoiceExtendedForeigner.ssId);
insertSqlCmd.CreateParameter("@ssInvoiceNumber", DbType.String, ssENInvoiceExtendedForeigner.ssInvoiceNumber);
insertSqlCmd.CreateParameter("@ssDirection", DbType.String, ssENInvoiceExtendedForeigner.ssDirection);
insertSqlCmd.CreateParameter("@ssReceiverSocialReason", DbType.String, ssENInvoiceExtendedForeigner.ssReceiverSocialReason);
insertSqlCmd.CreateParameter("@ssReceiverRFC", DbType.String, ssENInvoiceExtendedForeigner.ssReceiverRFC);
insertSqlCmd.CreateParameter("@ssIssuerSocialReason", DbType.String, ssENInvoiceExtendedForeigner.ssIssuerSocialReason);
insertSqlCmd.CreateParameter("@ssIssuerTaxId", DbType.String, ssENInvoiceExtendedForeigner.ssIssuerTaxId);
insertSqlCmd.CreateParameter("@ssInvoiceDate", DbType.DateTime, ssENInvoiceExtendedForeigner.ssInvoiceDate);
var TotalAmountParameter = insertSqlCmd.CreateParameter("@ssTotalAmount", DbType.Decimal, ssENInvoiceExtendedForeigner.ssTotalAmount);
{
    string decimalAsStr = ssENInvoiceExtendedForeigner.ssTotalAmount.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {TotalAmountParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
if ((ssENInvoiceExtendedForeigner.ssCurrency=="")) {
insertSqlCmd.CreateParameter("@ssCurrency", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCurrency", DbType.String, ssENInvoiceExtendedForeigner.ssCurrency);

}
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateInvoiceExtendedForeigner", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
outParamId = ssENInvoiceExtendedForeigner.ssId;
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENInvoiceExtendedForeigner.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeInvoiceExtendedForeigner
/// </summary>

public static async Task CreateOrUpdateSomeInvoiceExtendedForeigner(IRequestContext requestContext,RL_5198a019df57be180483639cd138aad4 inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeInvoiceExtendedForeigner", "35affc27-4b67-48b1-8907-c99b340dc755.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeInvoiceExtendedForeigner", "35affc27-4b67-48b1-8907-c99b340dc755.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENInvoiceExtendedForeignerEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@Id, "id") ?? "id") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@InvoiceNumber, "invoicenumber") ?? "invoicenumber") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@Direction, "direction") ?? "direction") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@ReceiverSocialReason, "receiversocialreason") ?? "receiversocialreason") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@ReceiverRFC, "receiverrfc") ?? "receiverrfc") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@IssuerSocialReason, "issuersocialreason") ?? "issuersocialreason") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@IssuerTaxId, "issuertaxid") ?? "issuertaxid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@InvoiceDate, "invoicedate") ?? "invoicedate") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@TotalAmount, "totalamount") ?? "totalamount") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@Currency, "currency") ?? "currency") + ") VALUES ( unnest(@ssId),  unnest(@ssInvoiceNumber),  unnest(@ssDirection),  unnest(@ssReceiverSocialReason),  unnest(@ssReceiverRFC),  unnest(@ssIssuerSocialReason),  unnest(@ssIssuerTaxId),  unnest(@ssInvoiceDate),  unnest(@ssTotalAmount),  unnest(@ssCurrency)) ON CONFLICT(" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@Id, "id") ?? "id") + ") do update set " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@InvoiceNumber, "invoicenumber") ?? "invoicenumber") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@InvoiceNumber, "invoicenumber") ?? "invoicenumber") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@Direction, "direction") ?? "direction") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@Direction, "direction") ?? "direction") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@ReceiverSocialReason, "receiversocialreason") ?? "receiversocialreason") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@ReceiverSocialReason, "receiversocialreason") ?? "receiversocialreason") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@ReceiverRFC, "receiverrfc") ?? "receiverrfc") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@ReceiverRFC, "receiverrfc") ?? "receiverrfc") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@IssuerSocialReason, "issuersocialreason") ?? "issuersocialreason") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@IssuerSocialReason, "issuersocialreason") ?? "issuersocialreason") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@IssuerTaxId, "issuertaxid") ?? "issuertaxid") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@IssuerTaxId, "issuertaxid") ?? "issuertaxid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@InvoiceDate, "invoicedate") ?? "invoicedate") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@InvoiceDate, "invoicedate") ?? "invoicedate") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@TotalAmount, "totalamount") ?? "totalamount") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@TotalAmount, "totalamount") ?? "totalamount") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@Currency, "currency") ?? "currency") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@Currency, "currency") ?? "currency") + " ";
insertSql += "";


List<object> insertIdList = new List<object>();
List<string> insertInvoiceNumberList = new List<string>();
List<string> insertDirectionList = new List<string>();
List<string> insertReceiverSocialReasonList = new List<string>();
List<string> insertReceiverRFCList = new List<string>();
List<string> insertIssuerSocialReasonList = new List<string>();
List<string> insertIssuerTaxIdList = new List<string>();
List<DateTime> insertInvoiceDateList = new List<DateTime>();
List<decimal> insertTotalAmountList = new List<decimal>();
List<object> insertCurrencyList = new List<object>();


var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_decbed55750bb4030b04e46c0306e56b)inParamSourceList.Current).ssENInvoiceExtendedForeigner;
insertIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
insertInvoiceNumberList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssInvoiceNumber));
insertDirectionList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssDirection));
insertReceiverSocialReasonList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssReceiverSocialReason));
insertReceiverRFCList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssReceiverRFC));
insertIssuerSocialReasonList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssIssuerSocialReason));
insertIssuerTaxIdList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssIssuerTaxId));
insertInvoiceDateList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssInvoiceDate));
insertTotalAmountList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssTotalAmount));
if ((record.ssCurrency=="")) {
insertCurrencyList.Add(null);
} else {
insertCurrencyList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCurrency));
}
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertIdList.IsEmpty() || !insertInvoiceNumberList.IsEmpty() || !insertDirectionList.IsEmpty() || !insertReceiverSocialReasonList.IsEmpty() || !insertReceiverRFCList.IsEmpty() || !insertIssuerSocialReasonList.IsEmpty() || !insertIssuerTaxIdList.IsEmpty() || !insertInvoiceDateList.IsEmpty() || !insertTotalAmountList.IsEmpty() || !insertCurrencyList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssId",DbType.Int64,insertIdList);
executionService.CreateParameter(insertSqlCmd,"@ssInvoiceNumber",DbType.String,insertInvoiceNumberList);
executionService.CreateParameter(insertSqlCmd,"@ssDirection",DbType.String,insertDirectionList);
executionService.CreateParameter(insertSqlCmd,"@ssReceiverSocialReason",DbType.String,insertReceiverSocialReasonList);
executionService.CreateParameter(insertSqlCmd,"@ssReceiverRFC",DbType.String,insertReceiverRFCList);
executionService.CreateParameter(insertSqlCmd,"@ssIssuerSocialReason",DbType.String,insertIssuerSocialReasonList);
executionService.CreateParameter(insertSqlCmd,"@ssIssuerTaxId",DbType.String,insertIssuerTaxIdList);
executionService.CreateParameter(insertSqlCmd,"@ssInvoiceDate",DbType.DateTime,insertInvoiceDateList);
executionService.CreateParameter(insertSqlCmd,"@ssTotalAmount",DbType.Decimal,insertTotalAmountList);
executionService.CreateParameter(insertSqlCmd,"@ssCurrency",DbType.String,insertCurrencyList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeInvoiceExtendedForeigner (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteInvoiceExtendedForeigner
/// </summary>

public static async Task DeleteInvoiceExtendedForeigner(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteInvoiceExtendedForeigner", "35affc27-4b67-48b1-8907-c99b340dc755.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteInvoiceExtendedForeigner", "35affc27-4b67-48b1-8907-c99b340dc755.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENInvoiceExtendedForeignerEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteInvoiceExtendedForeigner", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllInvoiceExtendedForeigner
/// </summary>

public static async Task DeleteAllInvoiceExtendedForeigner(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllInvoiceExtendedForeigner", "35affc27-4b67-48b1-8907-c99b340dc755.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllInvoiceExtendedForeigner", "35affc27-4b67-48b1-8907-c99b340dc755.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENInvoiceExtendedForeignerEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteInvoiceExtendedForeigner", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetInvoiceExtendedForeigner
/// </summary>

public static async Task<RC_decbed55750bb4030b04e46c0306e56b> GetInvoiceExtendedForeigner(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_decbed55750bb4030b04e46c0306e56b outParamRecord = default;
outParamRecord = new RC_decbed55750bb4030b04e46c0306e56b();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetInvoiceExtendedForeigner", "35affc27-4b67-48b1-8907-c99b340dc755.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetInvoiceExtendedForeigner", "35affc27-4b67-48b1-8907-c99b340dc755.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@InvoiceNumber, "invoicenumber") ?? "invoicenumber", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@Direction, "direction") ?? "direction", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@ReceiverSocialReason, "receiversocialreason") ?? "receiversocialreason", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@ReceiverRFC, "receiverrfc") ?? "receiverrfc", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@IssuerSocialReason, "issuersocialreason") ?? "issuersocialreason", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@IssuerTaxId, "issuertaxid") ?? "issuertaxid", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@InvoiceDate, "invoicedate") ?? "invoicedate", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@TotalAmount, "totalamount") ?? "totalamount", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@Currency, "currency") ?? "currency", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
" FROM " + ENInvoiceExtendedForeignerEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetInvoiceExtendedForeigner", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(10,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENInvoiceExtendedForeignerEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetInvoiceExtendedForeignerForUpdate
/// </summary>

public static async Task<RC_decbed55750bb4030b04e46c0306e56b> GetInvoiceExtendedForeignerForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_decbed55750bb4030b04e46c0306e56b outParamRecord = default;
outParamRecord = new RC_decbed55750bb4030b04e46c0306e56b();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetInvoiceExtendedForeignerForUpdate", "35affc27-4b67-48b1-8907-c99b340dc755.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetInvoiceExtendedForeignerForUpdate", "35affc27-4b67-48b1-8907-c99b340dc755.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@InvoiceNumber, "invoicenumber") ?? "invoicenumber", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@Direction, "direction") ?? "direction", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@ReceiverSocialReason, "receiversocialreason") ?? "receiversocialreason", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@ReceiverRFC, "receiverrfc") ?? "receiverrfc", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@IssuerSocialReason, "issuersocialreason") ?? "issuersocialreason", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@IssuerTaxId, "issuertaxid") ?? "issuertaxid", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@InvoiceDate, "invoicedate") ?? "invoicedate", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@TotalAmount, "totalamount") ?? "totalamount", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@Currency, "currency") ?? "currency", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
" FROM " + ENInvoiceExtendedForeignerEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetInvoiceExtendedForeignerForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(10,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENInvoiceExtendedForeignerEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateInvoiceExtendedForeigner
/// </summary>

public static async Task UpdateInvoiceExtendedForeigner(IRequestContext requestContext,BitArray usedFields,RC_decbed55750bb4030b04e46c0306e56b inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateInvoiceExtendedForeigner", "35affc27-4b67-48b1-8907-c99b340dc755.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateInvoiceExtendedForeigner", "35affc27-4b67-48b1-8907-c99b340dc755.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_5d51ce8a7e6e6b880d84c37746eb9086EntityRecord ssENInvoiceExtendedForeigner = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(10,true);
}
string updateSet = "UPDATE " + ENInvoiceExtendedForeignerEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@InvoiceNumber, "invoicenumber") ?? "invoicenumber") + " = @ssInvoiceNumber"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@Direction, "direction") ?? "direction") + " = @ssDirection"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@ReceiverSocialReason, "receiversocialreason") ?? "receiversocialreason") + " = @ssReceiverSocialReason"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@ReceiverRFC, "receiverrfc") ?? "receiverrfc") + " = @ssReceiverRFC"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@IssuerSocialReason, "issuersocialreason") ?? "issuersocialreason") + " = @ssIssuerSocialReason"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@IssuerTaxId, "issuertaxid") ?? "issuertaxid") + " = @ssIssuerTaxId"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@InvoiceDate, "invoicedate") ?? "invoicedate") + " = @ssInvoiceDate"): parameters);
parameters = (usedFields[8] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@TotalAmount, "totalamount") ?? "totalamount") + " = @ssTotalAmount"): parameters);
parameters = (usedFields[9] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@Currency, "currency") ?? "currency") + " = @ssCurrency"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENInvoiceExtndedForeigner_ssd_InvoiceExtenedForeigner";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@TotalAmount, "totalamount") ?? "totalamount") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceExtendedForeigner, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceExtendedForeignerAttributeKeys.@TotalAmount, "totalamount") ?? "totalamount") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssInvoiceNumber", DbType.String, ssENInvoiceExtendedForeigner.ssInvoiceNumber);
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssDirection", DbType.String, ssENInvoiceExtendedForeigner.ssDirection);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssReceiverSocialReason", DbType.String, ssENInvoiceExtendedForeigner.ssReceiverSocialReason);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssReceiverRFC", DbType.String, ssENInvoiceExtendedForeigner.ssReceiverRFC);
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssIssuerSocialReason", DbType.String, ssENInvoiceExtendedForeigner.ssIssuerSocialReason);
}
if(usedFields[6]) {
sqlCmd.CreateParameter("@ssIssuerTaxId", DbType.String, ssENInvoiceExtendedForeigner.ssIssuerTaxId);
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssInvoiceDate", DbType.DateTime, ssENInvoiceExtendedForeigner.ssInvoiceDate);
}
if(usedFields[8]) {
var TotalAmountParameter = sqlCmd.CreateParameter("@ssTotalAmount", DbType.Decimal, ssENInvoiceExtendedForeigner.ssTotalAmount);
{
    string decimalAsStr = ssENInvoiceExtendedForeigner.ssTotalAmount.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {TotalAmountParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[9]) {
if ((ssENInvoiceExtendedForeigner.ssCurrency=="")) {
sqlCmd.CreateParameter("@ssCurrency", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCurrency", DbType.String, ssENInvoiceExtendedForeigner.ssCurrency);

}
}
sqlCmd.CreateParameter("@idparam_ssENInvoiceExtndedForeigner_ssd_InvoiceExtenedForeigner", DbType.Int64, ssENInvoiceExtendedForeigner.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateInvoiceExtendedForeigner", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("InvoiceExtendedForeigner", ssENInvoiceExtendedForeigner.ssId.ToString()); }}
}
return;
}

}
}
