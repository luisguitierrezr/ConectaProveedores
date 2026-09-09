using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateInvoiceAccounting
/// </summary>

public static async Task<long> CreateInvoiceAccounting(IRequestContext requestContext,RC_c398a83ea7d109886e6be693f6d07867 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateInvoiceAccounting", "f85bd9f0-68c8-4bc7-ba8f-e4f2883a8c01.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateInvoiceAccounting", "f85bd9f0-68c8-4bc7-ba8f-e4f2883a8c01.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord ssENInvoiceAccounting = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENInvoiceAccountingEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@SupplierNumber, "suppliernumber") ?? "suppliernumber") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@ServiceTypeId, "servicetypeid") ?? "servicetypeid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@FreeText, "freetext") ?? "freetext") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@Division, "division") ?? "division") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@IvaAmount, "ivaamount") ?? "ivaamount") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@Iva_Old, "iva_old") ?? "iva_old") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@IvaIndicatorId, "ivaindicatorid") ?? "ivaindicatorid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@TotalAmount, "totalamount") ?? "totalamount") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@PaymentMethodId, "paymentmethodid") ?? "paymentmethodid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@PaymentTermsId, "paymenttermsid") ?? "paymenttermsid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@ICMEIndicator, "icmeindicator") ?? "icmeindicator") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@SubmissionBy, "submissionby") ?? "submissionby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@SubmissionOn, "submissionon") ?? "submissionon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@ServiceCalledBy, "servicecalledby") ?? "servicecalledby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@ServiceCalledOn, "servicecalledon") ?? "servicecalledon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@BuyDocNumber, "buydocnumber") ?? "buydocnumber") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@BuyDocPosition, "buydocposition") ?? "buydocposition") + "" +
" ) VALUES (" +
" @ssInvoiceId" +
", @ssSupplierNumber" +
", @ssServiceTypeId" +
", @ssFreeText" +
", @ssDivision" +
", @ssIvaAmount" +
", @ssIva_Old" +
", @ssIvaIndicatorId" +
", @ssTotalAmount" +
", @ssPaymentMethodId" +
", @ssPaymentTermsId" +
", @ssICMEIndicator" +
", @ssCreatedBy" +
", @ssCreatedOn" +
", @ssSubmissionBy" +
", @ssSubmissionOn" +
", @ssServiceCalledBy" +
", @ssServiceCalledOn" +
", @ssBuyDocNumber" +
", @ssBuyDocPosition" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENInvoiceAccounting.ssInvoiceId==0L)) {
insertSqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, ssENInvoiceAccounting.ssInvoiceId);

}
insertSqlCmd.CreateParameter("@ssSupplierNumber", DbType.String, ssENInvoiceAccounting.ssSupplierNumber);
if ((ssENInvoiceAccounting.ssServiceTypeId==0L)) {
insertSqlCmd.CreateParameter("@ssServiceTypeId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssServiceTypeId", DbType.Int64, ssENInvoiceAccounting.ssServiceTypeId);

}
insertSqlCmd.CreateParameter("@ssFreeText", DbType.String, ssENInvoiceAccounting.ssFreeText);
insertSqlCmd.CreateParameter("@ssDivision", DbType.String, ssENInvoiceAccounting.ssDivision);
var IvaAmountParameter = insertSqlCmd.CreateParameter("@ssIvaAmount", DbType.Decimal, ssENInvoiceAccounting.ssIvaAmount);
{
    string decimalAsStr = ssENInvoiceAccounting.ssIvaAmount.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {IvaAmountParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
insertSqlCmd.CreateParameter("@ssIva_Old", DbType.String, ssENInvoiceAccounting.ssIva_Old);
if ((ssENInvoiceAccounting.ssIvaIndicatorId==0L)) {
insertSqlCmd.CreateParameter("@ssIvaIndicatorId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssIvaIndicatorId", DbType.Int64, ssENInvoiceAccounting.ssIvaIndicatorId);

}
var TotalAmountParameter = insertSqlCmd.CreateParameter("@ssTotalAmount", DbType.Decimal, ssENInvoiceAccounting.ssTotalAmount);
{
    string decimalAsStr = ssENInvoiceAccounting.ssTotalAmount.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {TotalAmountParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
if ((ssENInvoiceAccounting.ssPaymentMethodId==0L)) {
insertSqlCmd.CreateParameter("@ssPaymentMethodId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssPaymentMethodId", DbType.Int64, ssENInvoiceAccounting.ssPaymentMethodId);

}
if ((ssENInvoiceAccounting.ssPaymentTermsId==0L)) {
insertSqlCmd.CreateParameter("@ssPaymentTermsId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssPaymentTermsId", DbType.Int64, ssENInvoiceAccounting.ssPaymentTermsId);

}
insertSqlCmd.CreateParameter("@ssICMEIndicator", DbType.String, ssENInvoiceAccounting.ssICMEIndicator);
if ((ssENInvoiceAccounting.ssCreatedBy=="")) {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENInvoiceAccounting.ssCreatedBy);

}
insertSqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENInvoiceAccounting.ssCreatedOn);
if ((ssENInvoiceAccounting.ssSubmissionBy=="")) {
insertSqlCmd.CreateParameter("@ssSubmissionBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssSubmissionBy", DbType.String, ssENInvoiceAccounting.ssSubmissionBy);

}
insertSqlCmd.CreateParameter("@ssSubmissionOn", DbType.DateTime, ssENInvoiceAccounting.ssSubmissionOn);
if ((ssENInvoiceAccounting.ssServiceCalledBy=="")) {
insertSqlCmd.CreateParameter("@ssServiceCalledBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssServiceCalledBy", DbType.String, ssENInvoiceAccounting.ssServiceCalledBy);

}
insertSqlCmd.CreateParameter("@ssServiceCalledOn", DbType.DateTime, ssENInvoiceAccounting.ssServiceCalledOn);
insertSqlCmd.CreateParameter("@ssBuyDocNumber", DbType.String, ssENInvoiceAccounting.ssBuyDocNumber);
insertSqlCmd.CreateParameter("@ssBuyDocPosition", DbType.String, ssENInvoiceAccounting.ssBuyDocPosition);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateInvoiceAccounting", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateInvoiceAccounting
/// </summary>

public static async Task<long> CreateOrUpdateInvoiceAccounting(IRequestContext requestContext,BitArray usedFields,RC_c398a83ea7d109886e6be693f6d07867 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateInvoiceAccounting", "f85bd9f0-68c8-4bc7-ba8f-e4f2883a8c01.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateInvoiceAccounting", "f85bd9f0-68c8-4bc7-ba8f-e4f2883a8c01.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord ssENInvoiceAccounting = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(21,true);
}
string updateSet = "UPDATE " + ENInvoiceAccountingEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + " = @ssInvoiceId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@SupplierNumber, "suppliernumber") ?? "suppliernumber") + " = @ssSupplierNumber"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@ServiceTypeId, "servicetypeid") ?? "servicetypeid") + " = @ssServiceTypeId"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@FreeText, "freetext") ?? "freetext") + " = @ssFreeText"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@Division, "division") ?? "division") + " = @ssDivision"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@IvaAmount, "ivaamount") ?? "ivaamount") + " = @ssIvaAmount"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@Iva_Old, "iva_old") ?? "iva_old") + " = @ssIva_Old"): parameters);
parameters = (usedFields[8] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@IvaIndicatorId, "ivaindicatorid") ?? "ivaindicatorid") + " = @ssIvaIndicatorId"): parameters);
parameters = (usedFields[9] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@TotalAmount, "totalamount") ?? "totalamount") + " = @ssTotalAmount"): parameters);
parameters = (usedFields[10] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@PaymentMethodId, "paymentmethodid") ?? "paymentmethodid") + " = @ssPaymentMethodId"): parameters);
parameters = (usedFields[11] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@PaymentTermsId, "paymenttermsid") ?? "paymenttermsid") + " = @ssPaymentTermsId"): parameters);
parameters = (usedFields[12] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@ICMEIndicator, "icmeindicator") ?? "icmeindicator") + " = @ssICMEIndicator"): parameters);
parameters = (usedFields[13] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = @ssCreatedBy"): parameters);
parameters = (usedFields[14] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = @ssCreatedOn"): parameters);
parameters = (usedFields[15] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@SubmissionBy, "submissionby") ?? "submissionby") + " = @ssSubmissionBy"): parameters);
parameters = (usedFields[16] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@SubmissionOn, "submissionon") ?? "submissionon") + " = @ssSubmissionOn"): parameters);
parameters = (usedFields[17] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@ServiceCalledBy, "servicecalledby") ?? "servicecalledby") + " = @ssServiceCalledBy"): parameters);
parameters = (usedFields[18] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@ServiceCalledOn, "servicecalledon") ?? "servicecalledon") + " = @ssServiceCalledOn"): parameters);
parameters = (usedFields[19] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@BuyDocNumber, "buydocnumber") ?? "buydocnumber") + " = @ssBuyDocNumber"): parameters);
parameters = (usedFields[20] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@BuyDocPosition, "buydocposition") ?? "buydocposition") + " = @ssBuyDocPosition"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENInvoiceAccounting_ssId_InvoiceAccounting";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@IvaAmount, "ivaamount") ?? "ivaamount") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@IvaAmount, "ivaamount") ?? "ivaamount") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENInvoiceAccounting.ssInvoiceId==0L)) {
sqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, ssENInvoiceAccounting.ssInvoiceId);

}
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssSupplierNumber", DbType.String, ssENInvoiceAccounting.ssSupplierNumber);
}
if(usedFields[3]) {
if ((ssENInvoiceAccounting.ssServiceTypeId==0L)) {
sqlCmd.CreateParameter("@ssServiceTypeId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssServiceTypeId", DbType.Int64, ssENInvoiceAccounting.ssServiceTypeId);

}
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssFreeText", DbType.String, ssENInvoiceAccounting.ssFreeText);
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssDivision", DbType.String, ssENInvoiceAccounting.ssDivision);
}
if(usedFields[6]) {
var IvaAmountParameter = sqlCmd.CreateParameter("@ssIvaAmount", DbType.Decimal, ssENInvoiceAccounting.ssIvaAmount);
{
    string decimalAsStr = ssENInvoiceAccounting.ssIvaAmount.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {IvaAmountParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssIva_Old", DbType.String, ssENInvoiceAccounting.ssIva_Old);
}
if(usedFields[8]) {
if ((ssENInvoiceAccounting.ssIvaIndicatorId==0L)) {
sqlCmd.CreateParameter("@ssIvaIndicatorId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssIvaIndicatorId", DbType.Int64, ssENInvoiceAccounting.ssIvaIndicatorId);

}
}
if(usedFields[9]) {
var TotalAmountParameter = sqlCmd.CreateParameter("@ssTotalAmount", DbType.Decimal, ssENInvoiceAccounting.ssTotalAmount);
{
    string decimalAsStr = ssENInvoiceAccounting.ssTotalAmount.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {TotalAmountParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[10]) {
if ((ssENInvoiceAccounting.ssPaymentMethodId==0L)) {
sqlCmd.CreateParameter("@ssPaymentMethodId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssPaymentMethodId", DbType.Int64, ssENInvoiceAccounting.ssPaymentMethodId);

}
}
if(usedFields[11]) {
if ((ssENInvoiceAccounting.ssPaymentTermsId==0L)) {
sqlCmd.CreateParameter("@ssPaymentTermsId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssPaymentTermsId", DbType.Int64, ssENInvoiceAccounting.ssPaymentTermsId);

}
}
if(usedFields[12]) {
sqlCmd.CreateParameter("@ssICMEIndicator", DbType.String, ssENInvoiceAccounting.ssICMEIndicator);
}
if(usedFields[13]) {
if ((ssENInvoiceAccounting.ssCreatedBy=="")) {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENInvoiceAccounting.ssCreatedBy);

}
}
if(usedFields[14]) {
sqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENInvoiceAccounting.ssCreatedOn);
}
if(usedFields[15]) {
if ((ssENInvoiceAccounting.ssSubmissionBy=="")) {
sqlCmd.CreateParameter("@ssSubmissionBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssSubmissionBy", DbType.String, ssENInvoiceAccounting.ssSubmissionBy);

}
}
if(usedFields[16]) {
sqlCmd.CreateParameter("@ssSubmissionOn", DbType.DateTime, ssENInvoiceAccounting.ssSubmissionOn);
}
if(usedFields[17]) {
if ((ssENInvoiceAccounting.ssServiceCalledBy=="")) {
sqlCmd.CreateParameter("@ssServiceCalledBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssServiceCalledBy", DbType.String, ssENInvoiceAccounting.ssServiceCalledBy);

}
}
if(usedFields[18]) {
sqlCmd.CreateParameter("@ssServiceCalledOn", DbType.DateTime, ssENInvoiceAccounting.ssServiceCalledOn);
}
if(usedFields[19]) {
sqlCmd.CreateParameter("@ssBuyDocNumber", DbType.String, ssENInvoiceAccounting.ssBuyDocNumber);
}
if(usedFields[20]) {
sqlCmd.CreateParameter("@ssBuyDocPosition", DbType.String, ssENInvoiceAccounting.ssBuyDocPosition);
}
sqlCmd.CreateParameter("@idparam_ssENInvoiceAccounting_ssId_InvoiceAccounting", DbType.Int64, ssENInvoiceAccounting.ssId);
int counter = 0;
if(ssENInvoiceAccounting.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateInvoiceAccounting (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENInvoiceAccountingEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@SupplierNumber, "suppliernumber") ?? "suppliernumber") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@ServiceTypeId, "servicetypeid") ?? "servicetypeid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@FreeText, "freetext") ?? "freetext") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@Division, "division") ?? "division") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@IvaAmount, "ivaamount") ?? "ivaamount") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@Iva_Old, "iva_old") ?? "iva_old") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@IvaIndicatorId, "ivaindicatorid") ?? "ivaindicatorid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@TotalAmount, "totalamount") ?? "totalamount") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@PaymentMethodId, "paymentmethodid") ?? "paymentmethodid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@PaymentTermsId, "paymenttermsid") ?? "paymenttermsid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@ICMEIndicator, "icmeindicator") ?? "icmeindicator") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@SubmissionBy, "submissionby") ?? "submissionby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@SubmissionOn, "submissionon") ?? "submissionon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@ServiceCalledBy, "servicecalledby") ?? "servicecalledby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@ServiceCalledOn, "servicecalledon") ?? "servicecalledon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@BuyDocNumber, "buydocnumber") ?? "buydocnumber") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@BuyDocPosition, "buydocposition") ?? "buydocposition") + "" +
" ) VALUES (" +
" @ssInvoiceId" +
", @ssSupplierNumber" +
", @ssServiceTypeId" +
", @ssFreeText" +
", @ssDivision" +
", @ssIvaAmount" +
", @ssIva_Old" +
", @ssIvaIndicatorId" +
", @ssTotalAmount" +
", @ssPaymentMethodId" +
", @ssPaymentTermsId" +
", @ssICMEIndicator" +
", @ssCreatedBy" +
", @ssCreatedOn" +
", @ssSubmissionBy" +
", @ssSubmissionOn" +
", @ssServiceCalledBy" +
", @ssServiceCalledOn" +
", @ssBuyDocNumber" +
", @ssBuyDocPosition" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENInvoiceAccounting.ssInvoiceId==0L)) {
insertSqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, ssENInvoiceAccounting.ssInvoiceId);

}
insertSqlCmd.CreateParameter("@ssSupplierNumber", DbType.String, ssENInvoiceAccounting.ssSupplierNumber);
if ((ssENInvoiceAccounting.ssServiceTypeId==0L)) {
insertSqlCmd.CreateParameter("@ssServiceTypeId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssServiceTypeId", DbType.Int64, ssENInvoiceAccounting.ssServiceTypeId);

}
insertSqlCmd.CreateParameter("@ssFreeText", DbType.String, ssENInvoiceAccounting.ssFreeText);
insertSqlCmd.CreateParameter("@ssDivision", DbType.String, ssENInvoiceAccounting.ssDivision);
var IvaAmountParameter = insertSqlCmd.CreateParameter("@ssIvaAmount", DbType.Decimal, ssENInvoiceAccounting.ssIvaAmount);
{
    string decimalAsStr = ssENInvoiceAccounting.ssIvaAmount.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {IvaAmountParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
insertSqlCmd.CreateParameter("@ssIva_Old", DbType.String, ssENInvoiceAccounting.ssIva_Old);
if ((ssENInvoiceAccounting.ssIvaIndicatorId==0L)) {
insertSqlCmd.CreateParameter("@ssIvaIndicatorId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssIvaIndicatorId", DbType.Int64, ssENInvoiceAccounting.ssIvaIndicatorId);

}
var TotalAmountParameter = insertSqlCmd.CreateParameter("@ssTotalAmount", DbType.Decimal, ssENInvoiceAccounting.ssTotalAmount);
{
    string decimalAsStr = ssENInvoiceAccounting.ssTotalAmount.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {TotalAmountParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
if ((ssENInvoiceAccounting.ssPaymentMethodId==0L)) {
insertSqlCmd.CreateParameter("@ssPaymentMethodId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssPaymentMethodId", DbType.Int64, ssENInvoiceAccounting.ssPaymentMethodId);

}
if ((ssENInvoiceAccounting.ssPaymentTermsId==0L)) {
insertSqlCmd.CreateParameter("@ssPaymentTermsId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssPaymentTermsId", DbType.Int64, ssENInvoiceAccounting.ssPaymentTermsId);

}
insertSqlCmd.CreateParameter("@ssICMEIndicator", DbType.String, ssENInvoiceAccounting.ssICMEIndicator);
if ((ssENInvoiceAccounting.ssCreatedBy=="")) {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENInvoiceAccounting.ssCreatedBy);

}
insertSqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENInvoiceAccounting.ssCreatedOn);
if ((ssENInvoiceAccounting.ssSubmissionBy=="")) {
insertSqlCmd.CreateParameter("@ssSubmissionBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssSubmissionBy", DbType.String, ssENInvoiceAccounting.ssSubmissionBy);

}
insertSqlCmd.CreateParameter("@ssSubmissionOn", DbType.DateTime, ssENInvoiceAccounting.ssSubmissionOn);
if ((ssENInvoiceAccounting.ssServiceCalledBy=="")) {
insertSqlCmd.CreateParameter("@ssServiceCalledBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssServiceCalledBy", DbType.String, ssENInvoiceAccounting.ssServiceCalledBy);

}
insertSqlCmd.CreateParameter("@ssServiceCalledOn", DbType.DateTime, ssENInvoiceAccounting.ssServiceCalledOn);
insertSqlCmd.CreateParameter("@ssBuyDocNumber", DbType.String, ssENInvoiceAccounting.ssBuyDocNumber);
insertSqlCmd.CreateParameter("@ssBuyDocPosition", DbType.String, ssENInvoiceAccounting.ssBuyDocPosition);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateInvoiceAccounting", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENInvoiceAccounting.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeInvoiceAccounting
/// </summary>

public static async Task CreateOrUpdateSomeInvoiceAccounting(IRequestContext requestContext,RL_ccf70f600f06def33a14ca10a1120a68 inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeInvoiceAccounting", "f85bd9f0-68c8-4bc7-ba8f-e4f2883a8c01.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeInvoiceAccounting", "f85bd9f0-68c8-4bc7-ba8f-e4f2883a8c01.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENInvoiceAccountingEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@SupplierNumber, "suppliernumber") ?? "suppliernumber") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@ServiceTypeId, "servicetypeid") ?? "servicetypeid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@FreeText, "freetext") ?? "freetext") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@Division, "division") ?? "division") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@IvaAmount, "ivaamount") ?? "ivaamount") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@Iva_Old, "iva_old") ?? "iva_old") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@IvaIndicatorId, "ivaindicatorid") ?? "ivaindicatorid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@TotalAmount, "totalamount") ?? "totalamount") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@PaymentMethodId, "paymentmethodid") ?? "paymentmethodid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@PaymentTermsId, "paymenttermsid") ?? "paymenttermsid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@ICMEIndicator, "icmeindicator") ?? "icmeindicator") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@SubmissionBy, "submissionby") ?? "submissionby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@SubmissionOn, "submissionon") ?? "submissionon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@ServiceCalledBy, "servicecalledby") ?? "servicecalledby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@ServiceCalledOn, "servicecalledon") ?? "servicecalledon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@BuyDocNumber, "buydocnumber") ?? "buydocnumber") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@BuyDocPosition, "buydocposition") ?? "buydocposition") + ") VALUES ( unnest(@ssInvoiceId),  unnest(@ssSupplierNumber),  unnest(@ssServiceTypeId),  unnest(@ssFreeText),  unnest(@ssDivision),  unnest(@ssIvaAmount),  unnest(@ssIva_Old),  unnest(@ssIvaIndicatorId),  unnest(@ssTotalAmount),  unnest(@ssPaymentMethodId),  unnest(@ssPaymentTermsId),  unnest(@ssICMEIndicator),  unnest(@ssCreatedBy),  unnest(@ssCreatedOn),  unnest(@ssSubmissionBy),  unnest(@ssSubmissionOn),  unnest(@ssServiceCalledBy),  unnest(@ssServiceCalledOn),  unnest(@ssBuyDocNumber),  unnest(@ssBuyDocPosition)) ";
insertSql += "";

string updateSql = "UPDATE " + entityTableName + " SET " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@SupplierNumber, "suppliernumber") ?? "suppliernumber") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@SupplierNumber, "suppliernumber") ?? "suppliernumber") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@ServiceTypeId, "servicetypeid") ?? "servicetypeid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@ServiceTypeId, "servicetypeid") ?? "servicetypeid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@FreeText, "freetext") ?? "freetext") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@FreeText, "freetext") ?? "freetext") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@Division, "division") ?? "division") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@Division, "division") ?? "division") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@IvaAmount, "ivaamount") ?? "ivaamount") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@IvaAmount, "ivaamount") ?? "ivaamount") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@Iva_Old, "iva_old") ?? "iva_old") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@Iva_Old, "iva_old") ?? "iva_old") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@IvaIndicatorId, "ivaindicatorid") ?? "ivaindicatorid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@IvaIndicatorId, "ivaindicatorid") ?? "ivaindicatorid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@TotalAmount, "totalamount") ?? "totalamount") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@TotalAmount, "totalamount") ?? "totalamount") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@PaymentMethodId, "paymentmethodid") ?? "paymentmethodid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@PaymentMethodId, "paymentmethodid") ?? "paymentmethodid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@PaymentTermsId, "paymenttermsid") ?? "paymenttermsid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@PaymentTermsId, "paymenttermsid") ?? "paymenttermsid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@ICMEIndicator, "icmeindicator") ?? "icmeindicator") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@ICMEIndicator, "icmeindicator") ?? "icmeindicator") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@SubmissionBy, "submissionby") ?? "submissionby") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@SubmissionBy, "submissionby") ?? "submissionby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@SubmissionOn, "submissionon") ?? "submissionon") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@SubmissionOn, "submissionon") ?? "submissionon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@ServiceCalledBy, "servicecalledby") ?? "servicecalledby") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@ServiceCalledBy, "servicecalledby") ?? "servicecalledby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@ServiceCalledOn, "servicecalledon") ?? "servicecalledon") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@ServiceCalledOn, "servicecalledon") ?? "servicecalledon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@BuyDocNumber, "buydocnumber") ?? "buydocnumber") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@BuyDocNumber, "buydocnumber") ?? "buydocnumber") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@BuyDocPosition, "buydocposition") ?? "buydocposition") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@BuyDocPosition, "buydocposition") ?? "buydocposition") + " from ( select  unnest(@ssId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@Id, "id") ?? "id") + ",  unnest(@ssInvoiceId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + ",  unnest(@ssSupplierNumber) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@SupplierNumber, "suppliernumber") ?? "suppliernumber") + ",  unnest(@ssServiceTypeId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@ServiceTypeId, "servicetypeid") ?? "servicetypeid") + ",  unnest(@ssFreeText) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@FreeText, "freetext") ?? "freetext") + ",  unnest(@ssDivision) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@Division, "division") ?? "division") + ",  unnest(@ssIvaAmount) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@IvaAmount, "ivaamount") ?? "ivaamount") + ",  unnest(@ssIva_Old) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@Iva_Old, "iva_old") ?? "iva_old") + ",  unnest(@ssIvaIndicatorId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@IvaIndicatorId, "ivaindicatorid") ?? "ivaindicatorid") + ",  unnest(@ssTotalAmount) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@TotalAmount, "totalamount") ?? "totalamount") + ",  unnest(@ssPaymentMethodId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@PaymentMethodId, "paymentmethodid") ?? "paymentmethodid") + ",  unnest(@ssPaymentTermsId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@PaymentTermsId, "paymenttermsid") ?? "paymenttermsid") + ",  unnest(@ssICMEIndicator) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@ICMEIndicator, "icmeindicator") ?? "icmeindicator") + ",  unnest(@ssCreatedBy) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ",  unnest(@ssCreatedOn) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + ",  unnest(@ssSubmissionBy) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@SubmissionBy, "submissionby") ?? "submissionby") + ",  unnest(@ssSubmissionOn) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@SubmissionOn, "submissionon") ?? "submissionon") + ",  unnest(@ssServiceCalledBy) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@ServiceCalledBy, "servicecalledby") ?? "servicecalledby") + ",  unnest(@ssServiceCalledOn) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@ServiceCalledOn, "servicecalledon") ?? "servicecalledon") + ",  unnest(@ssBuyDocNumber) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@BuyDocNumber, "buydocnumber") ?? "buydocnumber") + ",  unnest(@ssBuyDocPosition) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@BuyDocPosition, "buydocposition") ?? "buydocposition") + " ) as updateTable where " + entityTableName + "." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@Id, "id") ?? "id") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@Id, "id") ?? "id") + " ";
updateSql += "";

List<object> insertInvoiceIdList = new List<object>();
List<string> insertSupplierNumberList = new List<string>();
List<object> insertServiceTypeIdList = new List<object>();
List<string> insertFreeTextList = new List<string>();
List<string> insertDivisionList = new List<string>();
List<decimal> insertIvaAmountList = new List<decimal>();
List<string> insertIva_OldList = new List<string>();
List<object> insertIvaIndicatorIdList = new List<object>();
List<decimal> insertTotalAmountList = new List<decimal>();
List<object> insertPaymentMethodIdList = new List<object>();
List<object> insertPaymentTermsIdList = new List<object>();
List<string> insertICMEIndicatorList = new List<string>();
List<object> insertCreatedByList = new List<object>();
List<DateTime> insertCreatedOnList = new List<DateTime>();
List<object> insertSubmissionByList = new List<object>();
List<DateTime> insertSubmissionOnList = new List<DateTime>();
List<object> insertServiceCalledByList = new List<object>();
List<DateTime> insertServiceCalledOnList = new List<DateTime>();
List<string> insertBuyDocNumberList = new List<string>();
List<string> insertBuyDocPositionList = new List<string>();

List<long> updateIdList = new List<long>();
List<object> updateInvoiceIdList = new List<object>();
List<string> updateSupplierNumberList = new List<string>();
List<object> updateServiceTypeIdList = new List<object>();
List<string> updateFreeTextList = new List<string>();
List<string> updateDivisionList = new List<string>();
List<decimal> updateIvaAmountList = new List<decimal>();
List<string> updateIva_OldList = new List<string>();
List<object> updateIvaIndicatorIdList = new List<object>();
List<decimal> updateTotalAmountList = new List<decimal>();
List<object> updatePaymentMethodIdList = new List<object>();
List<object> updatePaymentTermsIdList = new List<object>();
List<string> updateICMEIndicatorList = new List<string>();
List<object> updateCreatedByList = new List<object>();
List<DateTime> updateCreatedOnList = new List<DateTime>();
List<object> updateSubmissionByList = new List<object>();
List<DateTime> updateSubmissionOnList = new List<DateTime>();
List<object> updateServiceCalledByList = new List<object>();
List<DateTime> updateServiceCalledOnList = new List<DateTime>();
List<string> updateBuyDocNumberList = new List<string>();
List<string> updateBuyDocPositionList = new List<string>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_c398a83ea7d109886e6be693f6d07867)inParamSourceList.Current).ssENInvoiceAccounting;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
if ((record.ssInvoiceId==0L)) {
updateInvoiceIdList.Add(null);
} else {
updateInvoiceIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssInvoiceId));
}
updateSupplierNumberList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssSupplierNumber));
if ((record.ssServiceTypeId==0L)) {
updateServiceTypeIdList.Add(null);
} else {
updateServiceTypeIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssServiceTypeId));
}
updateFreeTextList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssFreeText));
updateDivisionList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssDivision));
updateIvaAmountList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssIvaAmount));
updateIva_OldList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssIva_Old));
if ((record.ssIvaIndicatorId==0L)) {
updateIvaIndicatorIdList.Add(null);
} else {
updateIvaIndicatorIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssIvaIndicatorId));
}
updateTotalAmountList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssTotalAmount));
if ((record.ssPaymentMethodId==0L)) {
updatePaymentMethodIdList.Add(null);
} else {
updatePaymentMethodIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssPaymentMethodId));
}
if ((record.ssPaymentTermsId==0L)) {
updatePaymentTermsIdList.Add(null);
} else {
updatePaymentTermsIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssPaymentTermsId));
}
updateICMEIndicatorList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssICMEIndicator));
if ((record.ssCreatedBy=="")) {
updateCreatedByList.Add(null);
} else {
updateCreatedByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCreatedBy));
}
updateCreatedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssCreatedOn));
if ((record.ssSubmissionBy=="")) {
updateSubmissionByList.Add(null);
} else {
updateSubmissionByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssSubmissionBy));
}
updateSubmissionOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssSubmissionOn));
if ((record.ssServiceCalledBy=="")) {
updateServiceCalledByList.Add(null);
} else {
updateServiceCalledByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssServiceCalledBy));
}
updateServiceCalledOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssServiceCalledOn));
updateBuyDocNumberList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssBuyDocNumber));
updateBuyDocPositionList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssBuyDocPosition));
} else {
if ((record.ssInvoiceId==0L)) {
insertInvoiceIdList.Add(null);
} else {
insertInvoiceIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssInvoiceId));
}
insertSupplierNumberList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssSupplierNumber));
if ((record.ssServiceTypeId==0L)) {
insertServiceTypeIdList.Add(null);
} else {
insertServiceTypeIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssServiceTypeId));
}
insertFreeTextList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssFreeText));
insertDivisionList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssDivision));
insertIvaAmountList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssIvaAmount));
insertIva_OldList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssIva_Old));
if ((record.ssIvaIndicatorId==0L)) {
insertIvaIndicatorIdList.Add(null);
} else {
insertIvaIndicatorIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssIvaIndicatorId));
}
insertTotalAmountList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssTotalAmount));
if ((record.ssPaymentMethodId==0L)) {
insertPaymentMethodIdList.Add(null);
} else {
insertPaymentMethodIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssPaymentMethodId));
}
if ((record.ssPaymentTermsId==0L)) {
insertPaymentTermsIdList.Add(null);
} else {
insertPaymentTermsIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssPaymentTermsId));
}
insertICMEIndicatorList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssICMEIndicator));
if ((record.ssCreatedBy=="")) {
insertCreatedByList.Add(null);
} else {
insertCreatedByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCreatedBy));
}
insertCreatedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssCreatedOn));
if ((record.ssSubmissionBy=="")) {
insertSubmissionByList.Add(null);
} else {
insertSubmissionByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssSubmissionBy));
}
insertSubmissionOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssSubmissionOn));
if ((record.ssServiceCalledBy=="")) {
insertServiceCalledByList.Add(null);
} else {
insertServiceCalledByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssServiceCalledBy));
}
insertServiceCalledOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssServiceCalledOn));
insertBuyDocNumberList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssBuyDocNumber));
insertBuyDocPositionList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssBuyDocPosition));
}
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertInvoiceIdList.IsEmpty() || !insertSupplierNumberList.IsEmpty() || !insertServiceTypeIdList.IsEmpty() || !insertFreeTextList.IsEmpty() || !insertDivisionList.IsEmpty() || !insertIvaAmountList.IsEmpty() || !insertIva_OldList.IsEmpty() || !insertIvaIndicatorIdList.IsEmpty() || !insertTotalAmountList.IsEmpty() || !insertPaymentMethodIdList.IsEmpty() || !insertPaymentTermsIdList.IsEmpty() || !insertICMEIndicatorList.IsEmpty() || !insertCreatedByList.IsEmpty() || !insertCreatedOnList.IsEmpty() || !insertSubmissionByList.IsEmpty() || !insertSubmissionOnList.IsEmpty() || !insertServiceCalledByList.IsEmpty() || !insertServiceCalledOnList.IsEmpty() || !insertBuyDocNumberList.IsEmpty() || !insertBuyDocPositionList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssInvoiceId",DbType.Int64,insertInvoiceIdList);
executionService.CreateParameter(insertSqlCmd,"@ssSupplierNumber",DbType.String,insertSupplierNumberList);
executionService.CreateParameter(insertSqlCmd,"@ssServiceTypeId",DbType.Int64,insertServiceTypeIdList);
executionService.CreateParameter(insertSqlCmd,"@ssFreeText",DbType.String,insertFreeTextList);
executionService.CreateParameter(insertSqlCmd,"@ssDivision",DbType.String,insertDivisionList);
executionService.CreateParameter(insertSqlCmd,"@ssIvaAmount",DbType.Decimal,insertIvaAmountList);
executionService.CreateParameter(insertSqlCmd,"@ssIva_Old",DbType.String,insertIva_OldList);
executionService.CreateParameter(insertSqlCmd,"@ssIvaIndicatorId",DbType.Int64,insertIvaIndicatorIdList);
executionService.CreateParameter(insertSqlCmd,"@ssTotalAmount",DbType.Decimal,insertTotalAmountList);
executionService.CreateParameter(insertSqlCmd,"@ssPaymentMethodId",DbType.Int64,insertPaymentMethodIdList);
executionService.CreateParameter(insertSqlCmd,"@ssPaymentTermsId",DbType.Int64,insertPaymentTermsIdList);
executionService.CreateParameter(insertSqlCmd,"@ssICMEIndicator",DbType.String,insertICMEIndicatorList);
executionService.CreateParameter(insertSqlCmd,"@ssCreatedBy",DbType.String,insertCreatedByList);
executionService.CreateParameter(insertSqlCmd,"@ssCreatedOn",DbType.DateTime,insertCreatedOnList);
executionService.CreateParameter(insertSqlCmd,"@ssSubmissionBy",DbType.String,insertSubmissionByList);
executionService.CreateParameter(insertSqlCmd,"@ssSubmissionOn",DbType.DateTime,insertSubmissionOnList);
executionService.CreateParameter(insertSqlCmd,"@ssServiceCalledBy",DbType.String,insertServiceCalledByList);
executionService.CreateParameter(insertSqlCmd,"@ssServiceCalledOn",DbType.DateTime,insertServiceCalledOnList);
executionService.CreateParameter(insertSqlCmd,"@ssBuyDocNumber",DbType.String,insertBuyDocNumberList);
executionService.CreateParameter(insertSqlCmd,"@ssBuyDocPosition",DbType.String,insertBuyDocPositionList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeInvoiceAccounting (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateInvoiceIdList.IsEmpty() || !updateSupplierNumberList.IsEmpty() || !updateServiceTypeIdList.IsEmpty() || !updateFreeTextList.IsEmpty() || !updateDivisionList.IsEmpty() || !updateIvaAmountList.IsEmpty() || !updateIva_OldList.IsEmpty() || !updateIvaIndicatorIdList.IsEmpty() || !updateTotalAmountList.IsEmpty() || !updatePaymentMethodIdList.IsEmpty() || !updatePaymentTermsIdList.IsEmpty() || !updateICMEIndicatorList.IsEmpty() || !updateCreatedByList.IsEmpty() || !updateCreatedOnList.IsEmpty() || !updateSubmissionByList.IsEmpty() || !updateSubmissionOnList.IsEmpty() || !updateServiceCalledByList.IsEmpty() || !updateServiceCalledOnList.IsEmpty() || !updateBuyDocNumberList.IsEmpty() || !updateBuyDocPositionList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssInvoiceId",DbType.Int64,updateInvoiceIdList);
executionService.CreateParameter(updateSqlCmd,"@ssSupplierNumber",DbType.String,updateSupplierNumberList);
executionService.CreateParameter(updateSqlCmd,"@ssServiceTypeId",DbType.Int64,updateServiceTypeIdList);
executionService.CreateParameter(updateSqlCmd,"@ssFreeText",DbType.String,updateFreeTextList);
executionService.CreateParameter(updateSqlCmd,"@ssDivision",DbType.String,updateDivisionList);
executionService.CreateParameter(updateSqlCmd,"@ssIvaAmount",DbType.Decimal,updateIvaAmountList);
executionService.CreateParameter(updateSqlCmd,"@ssIva_Old",DbType.String,updateIva_OldList);
executionService.CreateParameter(updateSqlCmd,"@ssIvaIndicatorId",DbType.Int64,updateIvaIndicatorIdList);
executionService.CreateParameter(updateSqlCmd,"@ssTotalAmount",DbType.Decimal,updateTotalAmountList);
executionService.CreateParameter(updateSqlCmd,"@ssPaymentMethodId",DbType.Int64,updatePaymentMethodIdList);
executionService.CreateParameter(updateSqlCmd,"@ssPaymentTermsId",DbType.Int64,updatePaymentTermsIdList);
executionService.CreateParameter(updateSqlCmd,"@ssICMEIndicator",DbType.String,updateICMEIndicatorList);
executionService.CreateParameter(updateSqlCmd,"@ssCreatedBy",DbType.String,updateCreatedByList);
executionService.CreateParameter(updateSqlCmd,"@ssCreatedOn",DbType.DateTime,updateCreatedOnList);
executionService.CreateParameter(updateSqlCmd,"@ssSubmissionBy",DbType.String,updateSubmissionByList);
executionService.CreateParameter(updateSqlCmd,"@ssSubmissionOn",DbType.DateTime,updateSubmissionOnList);
executionService.CreateParameter(updateSqlCmd,"@ssServiceCalledBy",DbType.String,updateServiceCalledByList);
executionService.CreateParameter(updateSqlCmd,"@ssServiceCalledOn",DbType.DateTime,updateServiceCalledOnList);
executionService.CreateParameter(updateSqlCmd,"@ssBuyDocNumber",DbType.String,updateBuyDocNumberList);
executionService.CreateParameter(updateSqlCmd,"@ssBuyDocPosition",DbType.String,updateBuyDocPositionList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeInvoiceAccounting (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteInvoiceAccounting
/// </summary>

public static async Task DeleteInvoiceAccounting(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteInvoiceAccounting", "f85bd9f0-68c8-4bc7-ba8f-e4f2883a8c01.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteInvoiceAccounting", "f85bd9f0-68c8-4bc7-ba8f-e4f2883a8c01.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENInvoiceAccountingEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteInvoiceAccounting", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllInvoiceAccounting
/// </summary>

public static async Task DeleteAllInvoiceAccounting(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllInvoiceAccounting", "f85bd9f0-68c8-4bc7-ba8f-e4f2883a8c01.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllInvoiceAccounting", "f85bd9f0-68c8-4bc7-ba8f-e4f2883a8c01.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENInvoiceAccountingEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteInvoiceAccounting", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetInvoiceAccounting
/// </summary>

public static async Task<RC_c398a83ea7d109886e6be693f6d07867> GetInvoiceAccounting(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_c398a83ea7d109886e6be693f6d07867 outParamRecord = default;
outParamRecord = new RC_c398a83ea7d109886e6be693f6d07867();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetInvoiceAccounting", "f85bd9f0-68c8-4bc7-ba8f-e4f2883a8c01.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetInvoiceAccounting", "f85bd9f0-68c8-4bc7-ba8f-e4f2883a8c01.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@SupplierNumber, "suppliernumber") ?? "suppliernumber", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@ServiceTypeId, "servicetypeid") ?? "servicetypeid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@FreeText, "freetext") ?? "freetext", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@Division, "division") ?? "division", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@IvaAmount, "ivaamount") ?? "ivaamount", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@Iva_Old, "iva_old") ?? "iva_old", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@IvaIndicatorId, "ivaindicatorid") ?? "ivaindicatorid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@TotalAmount, "totalamount") ?? "totalamount", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@PaymentMethodId, "paymentmethodid") ?? "paymentmethodid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@PaymentTermsId, "paymenttermsid") ?? "paymenttermsid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@ICMEIndicator, "icmeindicator") ?? "icmeindicator", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@CreatedBy, "createdby") ?? "createdby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@CreatedOn, "createdon") ?? "createdon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@SubmissionBy, "submissionby") ?? "submissionby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@SubmissionOn, "submissionon") ?? "submissionon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@ServiceCalledBy, "servicecalledby") ?? "servicecalledby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@ServiceCalledOn, "servicecalledon") ?? "servicecalledon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@BuyDocNumber, "buydocnumber") ?? "buydocnumber", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@BuyDocPosition, "buydocposition") ?? "buydocposition", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
" FROM " + ENInvoiceAccountingEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetInvoiceAccounting", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(21,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENInvoiceAccountingEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetInvoiceAccountingForUpdate
/// </summary>

public static async Task<RC_c398a83ea7d109886e6be693f6d07867> GetInvoiceAccountingForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_c398a83ea7d109886e6be693f6d07867 outParamRecord = default;
outParamRecord = new RC_c398a83ea7d109886e6be693f6d07867();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetInvoiceAccountingForUpdate", "f85bd9f0-68c8-4bc7-ba8f-e4f2883a8c01.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetInvoiceAccountingForUpdate", "f85bd9f0-68c8-4bc7-ba8f-e4f2883a8c01.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@SupplierNumber, "suppliernumber") ?? "suppliernumber", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@ServiceTypeId, "servicetypeid") ?? "servicetypeid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@FreeText, "freetext") ?? "freetext", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@Division, "division") ?? "division", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@IvaAmount, "ivaamount") ?? "ivaamount", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@Iva_Old, "iva_old") ?? "iva_old", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@IvaIndicatorId, "ivaindicatorid") ?? "ivaindicatorid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@TotalAmount, "totalamount") ?? "totalamount", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@PaymentMethodId, "paymentmethodid") ?? "paymentmethodid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@PaymentTermsId, "paymenttermsid") ?? "paymenttermsid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@ICMEIndicator, "icmeindicator") ?? "icmeindicator", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@CreatedBy, "createdby") ?? "createdby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@CreatedOn, "createdon") ?? "createdon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@SubmissionBy, "submissionby") ?? "submissionby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@SubmissionOn, "submissionon") ?? "submissionon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@ServiceCalledBy, "servicecalledby") ?? "servicecalledby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@ServiceCalledOn, "servicecalledon") ?? "servicecalledon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@BuyDocNumber, "buydocnumber") ?? "buydocnumber", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@BuyDocPosition, "buydocposition") ?? "buydocposition", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
" FROM " + ENInvoiceAccountingEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetInvoiceAccountingForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(21,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENInvoiceAccountingEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateInvoiceAccounting
/// </summary>

public static async Task UpdateInvoiceAccounting(IRequestContext requestContext,BitArray usedFields,RC_c398a83ea7d109886e6be693f6d07867 inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateInvoiceAccounting", "f85bd9f0-68c8-4bc7-ba8f-e4f2883a8c01.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateInvoiceAccounting", "f85bd9f0-68c8-4bc7-ba8f-e4f2883a8c01.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord ssENInvoiceAccounting = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(21,true);
}
string updateSet = "UPDATE " + ENInvoiceAccountingEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid") + " = @ssInvoiceId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@SupplierNumber, "suppliernumber") ?? "suppliernumber") + " = @ssSupplierNumber"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@ServiceTypeId, "servicetypeid") ?? "servicetypeid") + " = @ssServiceTypeId"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@FreeText, "freetext") ?? "freetext") + " = @ssFreeText"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@Division, "division") ?? "division") + " = @ssDivision"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@IvaAmount, "ivaamount") ?? "ivaamount") + " = @ssIvaAmount"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@Iva_Old, "iva_old") ?? "iva_old") + " = @ssIva_Old"): parameters);
parameters = (usedFields[8] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@IvaIndicatorId, "ivaindicatorid") ?? "ivaindicatorid") + " = @ssIvaIndicatorId"): parameters);
parameters = (usedFields[9] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@TotalAmount, "totalamount") ?? "totalamount") + " = @ssTotalAmount"): parameters);
parameters = (usedFields[10] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@PaymentMethodId, "paymentmethodid") ?? "paymentmethodid") + " = @ssPaymentMethodId"): parameters);
parameters = (usedFields[11] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@PaymentTermsId, "paymenttermsid") ?? "paymenttermsid") + " = @ssPaymentTermsId"): parameters);
parameters = (usedFields[12] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@ICMEIndicator, "icmeindicator") ?? "icmeindicator") + " = @ssICMEIndicator"): parameters);
parameters = (usedFields[13] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = @ssCreatedBy"): parameters);
parameters = (usedFields[14] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = @ssCreatedOn"): parameters);
parameters = (usedFields[15] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@SubmissionBy, "submissionby") ?? "submissionby") + " = @ssSubmissionBy"): parameters);
parameters = (usedFields[16] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@SubmissionOn, "submissionon") ?? "submissionon") + " = @ssSubmissionOn"): parameters);
parameters = (usedFields[17] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@ServiceCalledBy, "servicecalledby") ?? "servicecalledby") + " = @ssServiceCalledBy"): parameters);
parameters = (usedFields[18] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@ServiceCalledOn, "servicecalledon") ?? "servicecalledon") + " = @ssServiceCalledOn"): parameters);
parameters = (usedFields[19] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@BuyDocNumber, "buydocnumber") ?? "buydocnumber") + " = @ssBuyDocNumber"): parameters);
parameters = (usedFields[20] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@BuyDocPosition, "buydocposition") ?? "buydocposition") + " = @ssBuyDocPosition"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENInvoiceAccounting_ssId_InvoiceAccounting";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@IvaAmount, "ivaamount") ?? "ivaamount") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingAttributeKeys.@IvaAmount, "ivaamount") ?? "ivaamount") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENInvoiceAccounting.ssInvoiceId==0L)) {
sqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssInvoiceId", DbType.Int64, ssENInvoiceAccounting.ssInvoiceId);

}
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssSupplierNumber", DbType.String, ssENInvoiceAccounting.ssSupplierNumber);
}
if(usedFields[3]) {
if ((ssENInvoiceAccounting.ssServiceTypeId==0L)) {
sqlCmd.CreateParameter("@ssServiceTypeId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssServiceTypeId", DbType.Int64, ssENInvoiceAccounting.ssServiceTypeId);

}
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssFreeText", DbType.String, ssENInvoiceAccounting.ssFreeText);
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssDivision", DbType.String, ssENInvoiceAccounting.ssDivision);
}
if(usedFields[6]) {
var IvaAmountParameter = sqlCmd.CreateParameter("@ssIvaAmount", DbType.Decimal, ssENInvoiceAccounting.ssIvaAmount);
{
    string decimalAsStr = ssENInvoiceAccounting.ssIvaAmount.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {IvaAmountParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssIva_Old", DbType.String, ssENInvoiceAccounting.ssIva_Old);
}
if(usedFields[8]) {
if ((ssENInvoiceAccounting.ssIvaIndicatorId==0L)) {
sqlCmd.CreateParameter("@ssIvaIndicatorId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssIvaIndicatorId", DbType.Int64, ssENInvoiceAccounting.ssIvaIndicatorId);

}
}
if(usedFields[9]) {
var TotalAmountParameter = sqlCmd.CreateParameter("@ssTotalAmount", DbType.Decimal, ssENInvoiceAccounting.ssTotalAmount);
{
    string decimalAsStr = ssENInvoiceAccounting.ssTotalAmount.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {TotalAmountParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[10]) {
if ((ssENInvoiceAccounting.ssPaymentMethodId==0L)) {
sqlCmd.CreateParameter("@ssPaymentMethodId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssPaymentMethodId", DbType.Int64, ssENInvoiceAccounting.ssPaymentMethodId);

}
}
if(usedFields[11]) {
if ((ssENInvoiceAccounting.ssPaymentTermsId==0L)) {
sqlCmd.CreateParameter("@ssPaymentTermsId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssPaymentTermsId", DbType.Int64, ssENInvoiceAccounting.ssPaymentTermsId);

}
}
if(usedFields[12]) {
sqlCmd.CreateParameter("@ssICMEIndicator", DbType.String, ssENInvoiceAccounting.ssICMEIndicator);
}
if(usedFields[13]) {
if ((ssENInvoiceAccounting.ssCreatedBy=="")) {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENInvoiceAccounting.ssCreatedBy);

}
}
if(usedFields[14]) {
sqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENInvoiceAccounting.ssCreatedOn);
}
if(usedFields[15]) {
if ((ssENInvoiceAccounting.ssSubmissionBy=="")) {
sqlCmd.CreateParameter("@ssSubmissionBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssSubmissionBy", DbType.String, ssENInvoiceAccounting.ssSubmissionBy);

}
}
if(usedFields[16]) {
sqlCmd.CreateParameter("@ssSubmissionOn", DbType.DateTime, ssENInvoiceAccounting.ssSubmissionOn);
}
if(usedFields[17]) {
if ((ssENInvoiceAccounting.ssServiceCalledBy=="")) {
sqlCmd.CreateParameter("@ssServiceCalledBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssServiceCalledBy", DbType.String, ssENInvoiceAccounting.ssServiceCalledBy);

}
}
if(usedFields[18]) {
sqlCmd.CreateParameter("@ssServiceCalledOn", DbType.DateTime, ssENInvoiceAccounting.ssServiceCalledOn);
}
if(usedFields[19]) {
sqlCmd.CreateParameter("@ssBuyDocNumber", DbType.String, ssENInvoiceAccounting.ssBuyDocNumber);
}
if(usedFields[20]) {
sqlCmd.CreateParameter("@ssBuyDocPosition", DbType.String, ssENInvoiceAccounting.ssBuyDocPosition);
}
sqlCmd.CreateParameter("@idparam_ssENInvoiceAccounting_ssId_InvoiceAccounting", DbType.Int64, ssENInvoiceAccounting.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateInvoiceAccounting", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("InvoiceAccounting", ssENInvoiceAccounting.ssId.ToString()); }}
}
return;
}

}
}
