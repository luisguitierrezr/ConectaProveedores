using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateOrderAccounting
/// </summary>

public static async Task<long> CreateOrderAccounting(IRequestContext requestContext,RC_2dc2cf38bcc16a8b338dc5ea9a5c6446 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrderAccounting", "8d58a902-fc36-4939-b4ce-d8d2b9f315b3.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrderAccounting", "8d58a902-fc36-4939-b4ce-d8d2b9f315b3.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord ssENOrderAccounting = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENOrderAccountingEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@OrderId, "orderid") ?? "orderid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasEstim_Equal_AgrePaym_DEPR, "hasestim_equal_agrepaym_depr") ?? "hasestim_equal_agrepaym_depr") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasSettlement_DEPR, "hassettlement_depr") ?? "hassettlement_depr") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasCreditNote_DEPR, "hascreditnote_depr") ?? "hascreditnote_depr") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasVoucher_DEPR, "hasvoucher_depr") ?? "hasvoucher_depr") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasSpecialPostDeliveryAuth, "hasspecialpostdeliveryauth") ?? "hasspecialpostdeliveryauth") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@SpecialPostDeliveryAuthId, "specialpostdeliveryauthid") ?? "specialpostdeliveryauthid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@Amount_DEPREC, "amount_deprec") ?? "amount_deprec") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@CurrencyId_DEPREC, "currencyid_deprec") ?? "currencyid_deprec") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@PaymentMethodId_DEPREC, "paymentmethodid_deprec") ?? "paymentmethodid_deprec") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@PaymentTermId_DEPREC, "paymenttermid_deprec") ?? "paymenttermid_deprec") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@NegociatedExchangeRateAcc, "negociatedexchangerateacc") ?? "negociatedexchangerateacc") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@ExchangeRateComment, "exchangeratecomment") ?? "exchangeratecomment") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@EvidenceFileId, "evidencefileid") ?? "evidencefileid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasContract, "hascontract") ?? "hascontract") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasREPSE, "hasrepse") ?? "hasrepse") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasPaymentSupplement, "haspaymentsupplement") ?? "haspaymentsupplement") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasNoticeOfPaymentSuspension, "hasnoticeofpaymentsuspension") ?? "hasnoticeofpaymentsuspension") + "" +
" ) VALUES (" +
" @ssOrderId" +
", @ssHasEstim_Equal_AgrePaym_DEPR" +
", @ssHasSettlement_DEPR" +
", @ssHasCreditNote_DEPR" +
", @ssHasVoucher_DEPR" +
", @ssHasSpecialPostDeliveryAuth" +
", @ssSpecialPostDeliveryAuthId" +
", @ssAmount_DEPREC" +
", @ssCurrencyId_DEPREC" +
", @ssPaymentMethodId_DEPREC" +
", @ssPaymentTermId_DEPREC" +
", @ssNegociatedExchangeRateAcc" +
", @ssExchangeRateComment" +
", @ssEvidenceFileId" +
", @ssHasContract" +
", @ssHasREPSE" +
", @ssHasPaymentSupplement" +
", @ssHasNoticeOfPaymentSuspension" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENOrderAccounting.ssOrderId==0L)) {
insertSqlCmd.CreateParameter("@ssOrderId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssOrderId", DbType.Int64, ssENOrderAccounting.ssOrderId);

}
insertSqlCmd.CreateParameter("@ssHasEstim_Equal_AgrePaym_DEPR", DbType.Boolean, ssENOrderAccounting.ssHasEstim_Equal_AgrePaym_DEPR);
insertSqlCmd.CreateParameter("@ssHasSettlement_DEPR", DbType.Boolean, ssENOrderAccounting.ssHasSettlement_DEPR);
insertSqlCmd.CreateParameter("@ssHasCreditNote_DEPR", DbType.Boolean, ssENOrderAccounting.ssHasCreditNote_DEPR);
insertSqlCmd.CreateParameter("@ssHasVoucher_DEPR", DbType.Boolean, ssENOrderAccounting.ssHasVoucher_DEPR);
insertSqlCmd.CreateParameter("@ssHasSpecialPostDeliveryAuth", DbType.Boolean, ssENOrderAccounting.ssHasSpecialPostDeliveryAuth);
if ((ssENOrderAccounting.ssSpecialPostDeliveryAuthId==0)) {
insertSqlCmd.CreateParameter("@ssSpecialPostDeliveryAuthId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssSpecialPostDeliveryAuthId", DbType.Int32, ssENOrderAccounting.ssSpecialPostDeliveryAuthId);

}
var Amount_DEPRECParameter = insertSqlCmd.CreateParameter("@ssAmount_DEPREC", DbType.Decimal, ssENOrderAccounting.ssAmount_DEPREC);
{
    string decimalAsStr = ssENOrderAccounting.ssAmount_DEPREC.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {Amount_DEPRECParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
if ((ssENOrderAccounting.ssCurrencyId_DEPREC=="")) {
insertSqlCmd.CreateParameter("@ssCurrencyId_DEPREC", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCurrencyId_DEPREC", DbType.String, ssENOrderAccounting.ssCurrencyId_DEPREC);

}
if ((ssENOrderAccounting.ssPaymentMethodId_DEPREC==0L)) {
insertSqlCmd.CreateParameter("@ssPaymentMethodId_DEPREC", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssPaymentMethodId_DEPREC", DbType.Int64, ssENOrderAccounting.ssPaymentMethodId_DEPREC);

}
if ((ssENOrderAccounting.ssPaymentTermId_DEPREC==0L)) {
insertSqlCmd.CreateParameter("@ssPaymentTermId_DEPREC", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssPaymentTermId_DEPREC", DbType.Int64, ssENOrderAccounting.ssPaymentTermId_DEPREC);

}
var NegociatedExchangeRateAccParameter = insertSqlCmd.CreateParameter("@ssNegociatedExchangeRateAcc", DbType.Decimal, ssENOrderAccounting.ssNegociatedExchangeRateAcc);
{
    string decimalAsStr = ssENOrderAccounting.ssNegociatedExchangeRateAcc.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {NegociatedExchangeRateAccParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
insertSqlCmd.CreateParameter("@ssExchangeRateComment", DbType.String, ssENOrderAccounting.ssExchangeRateComment);
if ((ssENOrderAccounting.ssEvidenceFileId==0L)) {
insertSqlCmd.CreateParameter("@ssEvidenceFileId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssEvidenceFileId", DbType.Int64, ssENOrderAccounting.ssEvidenceFileId);

}
insertSqlCmd.CreateParameter("@ssHasContract", DbType.Boolean, ssENOrderAccounting.ssHasContract);
insertSqlCmd.CreateParameter("@ssHasREPSE", DbType.Boolean, ssENOrderAccounting.ssHasREPSE);
insertSqlCmd.CreateParameter("@ssHasPaymentSupplement", DbType.Boolean, ssENOrderAccounting.ssHasPaymentSupplement);
insertSqlCmd.CreateParameter("@ssHasNoticeOfPaymentSuspension", DbType.Boolean, ssENOrderAccounting.ssHasNoticeOfPaymentSuspension);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrderAccounting", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateOrderAccounting
/// </summary>

public static async Task<long> CreateOrUpdateOrderAccounting(IRequestContext requestContext,BitArray usedFields,RC_2dc2cf38bcc16a8b338dc5ea9a5c6446 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateOrderAccounting", "8d58a902-fc36-4939-b4ce-d8d2b9f315b3.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateOrderAccounting", "8d58a902-fc36-4939-b4ce-d8d2b9f315b3.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord ssENOrderAccounting = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(19,true);
}
string updateSet = "UPDATE " + ENOrderAccountingEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@OrderId, "orderid") ?? "orderid") + " = @ssOrderId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasEstim_Equal_AgrePaym_DEPR, "hasestim_equal_agrepaym_depr") ?? "hasestim_equal_agrepaym_depr") + " = @ssHasEstim_Equal_AgrePaym_DEPR"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasSettlement_DEPR, "hassettlement_depr") ?? "hassettlement_depr") + " = @ssHasSettlement_DEPR"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasCreditNote_DEPR, "hascreditnote_depr") ?? "hascreditnote_depr") + " = @ssHasCreditNote_DEPR"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasVoucher_DEPR, "hasvoucher_depr") ?? "hasvoucher_depr") + " = @ssHasVoucher_DEPR"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasSpecialPostDeliveryAuth, "hasspecialpostdeliveryauth") ?? "hasspecialpostdeliveryauth") + " = @ssHasSpecialPostDeliveryAuth"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@SpecialPostDeliveryAuthId, "specialpostdeliveryauthid") ?? "specialpostdeliveryauthid") + " = @ssSpecialPostDeliveryAuthId"): parameters);
parameters = (usedFields[8] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@Amount_DEPREC, "amount_deprec") ?? "amount_deprec") + " = @ssAmount_DEPREC"): parameters);
parameters = (usedFields[9] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@CurrencyId_DEPREC, "currencyid_deprec") ?? "currencyid_deprec") + " = @ssCurrencyId_DEPREC"): parameters);
parameters = (usedFields[10] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@PaymentMethodId_DEPREC, "paymentmethodid_deprec") ?? "paymentmethodid_deprec") + " = @ssPaymentMethodId_DEPREC"): parameters);
parameters = (usedFields[11] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@PaymentTermId_DEPREC, "paymenttermid_deprec") ?? "paymenttermid_deprec") + " = @ssPaymentTermId_DEPREC"): parameters);
parameters = (usedFields[12] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@NegociatedExchangeRateAcc, "negociatedexchangerateacc") ?? "negociatedexchangerateacc") + " = @ssNegociatedExchangeRateAcc"): parameters);
parameters = (usedFields[13] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@ExchangeRateComment, "exchangeratecomment") ?? "exchangeratecomment") + " = @ssExchangeRateComment"): parameters);
parameters = (usedFields[14] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@EvidenceFileId, "evidencefileid") ?? "evidencefileid") + " = @ssEvidenceFileId"): parameters);
parameters = (usedFields[15] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasContract, "hascontract") ?? "hascontract") + " = @ssHasContract"): parameters);
parameters = (usedFields[16] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasREPSE, "hasrepse") ?? "hasrepse") + " = @ssHasREPSE"): parameters);
parameters = (usedFields[17] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasPaymentSupplement, "haspaymentsupplement") ?? "haspaymentsupplement") + " = @ssHasPaymentSupplement"): parameters);
parameters = (usedFields[18] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasNoticeOfPaymentSuspension, "hasnoticeofpaymentsuspension") ?? "hasnoticeofpaymentsuspension") + " = @ssHasNoticeOfPaymentSuspension"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENOrderAccounting_ssId_OrderAccounting";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasEstim_Equal_AgrePaym_DEPR, "hasestim_equal_agrepaym_depr") ?? "hasestim_equal_agrepaym_depr") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasEstim_Equal_AgrePaym_DEPR, "hasestim_equal_agrepaym_depr") ?? "hasestim_equal_agrepaym_depr") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENOrderAccounting.ssOrderId==0L)) {
sqlCmd.CreateParameter("@ssOrderId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssOrderId", DbType.Int64, ssENOrderAccounting.ssOrderId);

}
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssHasEstim_Equal_AgrePaym_DEPR", DbType.Boolean, ssENOrderAccounting.ssHasEstim_Equal_AgrePaym_DEPR);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssHasSettlement_DEPR", DbType.Boolean, ssENOrderAccounting.ssHasSettlement_DEPR);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssHasCreditNote_DEPR", DbType.Boolean, ssENOrderAccounting.ssHasCreditNote_DEPR);
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssHasVoucher_DEPR", DbType.Boolean, ssENOrderAccounting.ssHasVoucher_DEPR);
}
if(usedFields[6]) {
sqlCmd.CreateParameter("@ssHasSpecialPostDeliveryAuth", DbType.Boolean, ssENOrderAccounting.ssHasSpecialPostDeliveryAuth);
}
if(usedFields[7]) {
if ((ssENOrderAccounting.ssSpecialPostDeliveryAuthId==0)) {
sqlCmd.CreateParameter("@ssSpecialPostDeliveryAuthId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssSpecialPostDeliveryAuthId", DbType.Int32, ssENOrderAccounting.ssSpecialPostDeliveryAuthId);

}
}
if(usedFields[8]) {
var Amount_DEPRECParameter = sqlCmd.CreateParameter("@ssAmount_DEPREC", DbType.Decimal, ssENOrderAccounting.ssAmount_DEPREC);
{
    string decimalAsStr = ssENOrderAccounting.ssAmount_DEPREC.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {Amount_DEPRECParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[9]) {
if ((ssENOrderAccounting.ssCurrencyId_DEPREC=="")) {
sqlCmd.CreateParameter("@ssCurrencyId_DEPREC", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCurrencyId_DEPREC", DbType.String, ssENOrderAccounting.ssCurrencyId_DEPREC);

}
}
if(usedFields[10]) {
if ((ssENOrderAccounting.ssPaymentMethodId_DEPREC==0L)) {
sqlCmd.CreateParameter("@ssPaymentMethodId_DEPREC", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssPaymentMethodId_DEPREC", DbType.Int64, ssENOrderAccounting.ssPaymentMethodId_DEPREC);

}
}
if(usedFields[11]) {
if ((ssENOrderAccounting.ssPaymentTermId_DEPREC==0L)) {
sqlCmd.CreateParameter("@ssPaymentTermId_DEPREC", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssPaymentTermId_DEPREC", DbType.Int64, ssENOrderAccounting.ssPaymentTermId_DEPREC);

}
}
if(usedFields[12]) {
var NegociatedExchangeRateAccParameter = sqlCmd.CreateParameter("@ssNegociatedExchangeRateAcc", DbType.Decimal, ssENOrderAccounting.ssNegociatedExchangeRateAcc);
{
    string decimalAsStr = ssENOrderAccounting.ssNegociatedExchangeRateAcc.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {NegociatedExchangeRateAccParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[13]) {
sqlCmd.CreateParameter("@ssExchangeRateComment", DbType.String, ssENOrderAccounting.ssExchangeRateComment);
}
if(usedFields[14]) {
if ((ssENOrderAccounting.ssEvidenceFileId==0L)) {
sqlCmd.CreateParameter("@ssEvidenceFileId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssEvidenceFileId", DbType.Int64, ssENOrderAccounting.ssEvidenceFileId);

}
}
if(usedFields[15]) {
sqlCmd.CreateParameter("@ssHasContract", DbType.Boolean, ssENOrderAccounting.ssHasContract);
}
if(usedFields[16]) {
sqlCmd.CreateParameter("@ssHasREPSE", DbType.Boolean, ssENOrderAccounting.ssHasREPSE);
}
if(usedFields[17]) {
sqlCmd.CreateParameter("@ssHasPaymentSupplement", DbType.Boolean, ssENOrderAccounting.ssHasPaymentSupplement);
}
if(usedFields[18]) {
sqlCmd.CreateParameter("@ssHasNoticeOfPaymentSuspension", DbType.Boolean, ssENOrderAccounting.ssHasNoticeOfPaymentSuspension);
}
sqlCmd.CreateParameter("@idparam_ssENOrderAccounting_ssId_OrderAccounting", DbType.Int64, ssENOrderAccounting.ssId);
int counter = 0;
if(ssENOrderAccounting.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateOrderAccounting (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENOrderAccountingEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@OrderId, "orderid") ?? "orderid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasEstim_Equal_AgrePaym_DEPR, "hasestim_equal_agrepaym_depr") ?? "hasestim_equal_agrepaym_depr") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasSettlement_DEPR, "hassettlement_depr") ?? "hassettlement_depr") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasCreditNote_DEPR, "hascreditnote_depr") ?? "hascreditnote_depr") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasVoucher_DEPR, "hasvoucher_depr") ?? "hasvoucher_depr") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasSpecialPostDeliveryAuth, "hasspecialpostdeliveryauth") ?? "hasspecialpostdeliveryauth") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@SpecialPostDeliveryAuthId, "specialpostdeliveryauthid") ?? "specialpostdeliveryauthid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@Amount_DEPREC, "amount_deprec") ?? "amount_deprec") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@CurrencyId_DEPREC, "currencyid_deprec") ?? "currencyid_deprec") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@PaymentMethodId_DEPREC, "paymentmethodid_deprec") ?? "paymentmethodid_deprec") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@PaymentTermId_DEPREC, "paymenttermid_deprec") ?? "paymenttermid_deprec") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@NegociatedExchangeRateAcc, "negociatedexchangerateacc") ?? "negociatedexchangerateacc") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@ExchangeRateComment, "exchangeratecomment") ?? "exchangeratecomment") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@EvidenceFileId, "evidencefileid") ?? "evidencefileid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasContract, "hascontract") ?? "hascontract") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasREPSE, "hasrepse") ?? "hasrepse") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasPaymentSupplement, "haspaymentsupplement") ?? "haspaymentsupplement") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasNoticeOfPaymentSuspension, "hasnoticeofpaymentsuspension") ?? "hasnoticeofpaymentsuspension") + "" +
" ) VALUES (" +
" @ssOrderId" +
", @ssHasEstim_Equal_AgrePaym_DEPR" +
", @ssHasSettlement_DEPR" +
", @ssHasCreditNote_DEPR" +
", @ssHasVoucher_DEPR" +
", @ssHasSpecialPostDeliveryAuth" +
", @ssSpecialPostDeliveryAuthId" +
", @ssAmount_DEPREC" +
", @ssCurrencyId_DEPREC" +
", @ssPaymentMethodId_DEPREC" +
", @ssPaymentTermId_DEPREC" +
", @ssNegociatedExchangeRateAcc" +
", @ssExchangeRateComment" +
", @ssEvidenceFileId" +
", @ssHasContract" +
", @ssHasREPSE" +
", @ssHasPaymentSupplement" +
", @ssHasNoticeOfPaymentSuspension" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENOrderAccounting.ssOrderId==0L)) {
insertSqlCmd.CreateParameter("@ssOrderId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssOrderId", DbType.Int64, ssENOrderAccounting.ssOrderId);

}
insertSqlCmd.CreateParameter("@ssHasEstim_Equal_AgrePaym_DEPR", DbType.Boolean, ssENOrderAccounting.ssHasEstim_Equal_AgrePaym_DEPR);
insertSqlCmd.CreateParameter("@ssHasSettlement_DEPR", DbType.Boolean, ssENOrderAccounting.ssHasSettlement_DEPR);
insertSqlCmd.CreateParameter("@ssHasCreditNote_DEPR", DbType.Boolean, ssENOrderAccounting.ssHasCreditNote_DEPR);
insertSqlCmd.CreateParameter("@ssHasVoucher_DEPR", DbType.Boolean, ssENOrderAccounting.ssHasVoucher_DEPR);
insertSqlCmd.CreateParameter("@ssHasSpecialPostDeliveryAuth", DbType.Boolean, ssENOrderAccounting.ssHasSpecialPostDeliveryAuth);
if ((ssENOrderAccounting.ssSpecialPostDeliveryAuthId==0)) {
insertSqlCmd.CreateParameter("@ssSpecialPostDeliveryAuthId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssSpecialPostDeliveryAuthId", DbType.Int32, ssENOrderAccounting.ssSpecialPostDeliveryAuthId);

}
var Amount_DEPRECParameter = insertSqlCmd.CreateParameter("@ssAmount_DEPREC", DbType.Decimal, ssENOrderAccounting.ssAmount_DEPREC);
{
    string decimalAsStr = ssENOrderAccounting.ssAmount_DEPREC.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {Amount_DEPRECParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
if ((ssENOrderAccounting.ssCurrencyId_DEPREC=="")) {
insertSqlCmd.CreateParameter("@ssCurrencyId_DEPREC", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCurrencyId_DEPREC", DbType.String, ssENOrderAccounting.ssCurrencyId_DEPREC);

}
if ((ssENOrderAccounting.ssPaymentMethodId_DEPREC==0L)) {
insertSqlCmd.CreateParameter("@ssPaymentMethodId_DEPREC", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssPaymentMethodId_DEPREC", DbType.Int64, ssENOrderAccounting.ssPaymentMethodId_DEPREC);

}
if ((ssENOrderAccounting.ssPaymentTermId_DEPREC==0L)) {
insertSqlCmd.CreateParameter("@ssPaymentTermId_DEPREC", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssPaymentTermId_DEPREC", DbType.Int64, ssENOrderAccounting.ssPaymentTermId_DEPREC);

}
var NegociatedExchangeRateAccParameter = insertSqlCmd.CreateParameter("@ssNegociatedExchangeRateAcc", DbType.Decimal, ssENOrderAccounting.ssNegociatedExchangeRateAcc);
{
    string decimalAsStr = ssENOrderAccounting.ssNegociatedExchangeRateAcc.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {NegociatedExchangeRateAccParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
insertSqlCmd.CreateParameter("@ssExchangeRateComment", DbType.String, ssENOrderAccounting.ssExchangeRateComment);
if ((ssENOrderAccounting.ssEvidenceFileId==0L)) {
insertSqlCmd.CreateParameter("@ssEvidenceFileId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssEvidenceFileId", DbType.Int64, ssENOrderAccounting.ssEvidenceFileId);

}
insertSqlCmd.CreateParameter("@ssHasContract", DbType.Boolean, ssENOrderAccounting.ssHasContract);
insertSqlCmd.CreateParameter("@ssHasREPSE", DbType.Boolean, ssENOrderAccounting.ssHasREPSE);
insertSqlCmd.CreateParameter("@ssHasPaymentSupplement", DbType.Boolean, ssENOrderAccounting.ssHasPaymentSupplement);
insertSqlCmd.CreateParameter("@ssHasNoticeOfPaymentSuspension", DbType.Boolean, ssENOrderAccounting.ssHasNoticeOfPaymentSuspension);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateOrderAccounting", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENOrderAccounting.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeOrderAccounting
/// </summary>

public static async Task CreateOrUpdateSomeOrderAccounting(IRequestContext requestContext,RL_aedf606f6413243cfacf43ac13db404f inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeOrderAccounting", "8d58a902-fc36-4939-b4ce-d8d2b9f315b3.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeOrderAccounting", "8d58a902-fc36-4939-b4ce-d8d2b9f315b3.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENOrderAccountingEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@OrderId, "orderid") ?? "orderid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasEstim_Equal_AgrePaym_DEPR, "hasestim_equal_agrepaym_depr") ?? "hasestim_equal_agrepaym_depr") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasSettlement_DEPR, "hassettlement_depr") ?? "hassettlement_depr") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasCreditNote_DEPR, "hascreditnote_depr") ?? "hascreditnote_depr") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasVoucher_DEPR, "hasvoucher_depr") ?? "hasvoucher_depr") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasSpecialPostDeliveryAuth, "hasspecialpostdeliveryauth") ?? "hasspecialpostdeliveryauth") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@SpecialPostDeliveryAuthId, "specialpostdeliveryauthid") ?? "specialpostdeliveryauthid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@Amount_DEPREC, "amount_deprec") ?? "amount_deprec") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@CurrencyId_DEPREC, "currencyid_deprec") ?? "currencyid_deprec") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@PaymentMethodId_DEPREC, "paymentmethodid_deprec") ?? "paymentmethodid_deprec") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@PaymentTermId_DEPREC, "paymenttermid_deprec") ?? "paymenttermid_deprec") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@NegociatedExchangeRateAcc, "negociatedexchangerateacc") ?? "negociatedexchangerateacc") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@ExchangeRateComment, "exchangeratecomment") ?? "exchangeratecomment") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@EvidenceFileId, "evidencefileid") ?? "evidencefileid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasContract, "hascontract") ?? "hascontract") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasREPSE, "hasrepse") ?? "hasrepse") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasPaymentSupplement, "haspaymentsupplement") ?? "haspaymentsupplement") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasNoticeOfPaymentSuspension, "hasnoticeofpaymentsuspension") ?? "hasnoticeofpaymentsuspension") + ") VALUES ( unnest(@ssOrderId),  unnest(@ssHasEstim_Equal_AgrePaym_DEPR),  unnest(@ssHasSettlement_DEPR),  unnest(@ssHasCreditNote_DEPR),  unnest(@ssHasVoucher_DEPR),  unnest(@ssHasSpecialPostDeliveryAuth),  unnest(@ssSpecialPostDeliveryAuthId),  unnest(@ssAmount_DEPREC),  unnest(@ssCurrencyId_DEPREC),  unnest(@ssPaymentMethodId_DEPREC),  unnest(@ssPaymentTermId_DEPREC),  unnest(@ssNegociatedExchangeRateAcc),  unnest(@ssExchangeRateComment),  unnest(@ssEvidenceFileId),  unnest(@ssHasContract),  unnest(@ssHasREPSE),  unnest(@ssHasPaymentSupplement),  unnest(@ssHasNoticeOfPaymentSuspension)) ";
insertSql += "";

string updateSql = "UPDATE " + entityTableName + " SET " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@OrderId, "orderid") ?? "orderid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@OrderId, "orderid") ?? "orderid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasEstim_Equal_AgrePaym_DEPR, "hasestim_equal_agrepaym_depr") ?? "hasestim_equal_agrepaym_depr") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasEstim_Equal_AgrePaym_DEPR, "hasestim_equal_agrepaym_depr") ?? "hasestim_equal_agrepaym_depr") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasSettlement_DEPR, "hassettlement_depr") ?? "hassettlement_depr") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasSettlement_DEPR, "hassettlement_depr") ?? "hassettlement_depr") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasCreditNote_DEPR, "hascreditnote_depr") ?? "hascreditnote_depr") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasCreditNote_DEPR, "hascreditnote_depr") ?? "hascreditnote_depr") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasVoucher_DEPR, "hasvoucher_depr") ?? "hasvoucher_depr") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasVoucher_DEPR, "hasvoucher_depr") ?? "hasvoucher_depr") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasSpecialPostDeliveryAuth, "hasspecialpostdeliveryauth") ?? "hasspecialpostdeliveryauth") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasSpecialPostDeliveryAuth, "hasspecialpostdeliveryauth") ?? "hasspecialpostdeliveryauth") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@SpecialPostDeliveryAuthId, "specialpostdeliveryauthid") ?? "specialpostdeliveryauthid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@SpecialPostDeliveryAuthId, "specialpostdeliveryauthid") ?? "specialpostdeliveryauthid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@Amount_DEPREC, "amount_deprec") ?? "amount_deprec") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@Amount_DEPREC, "amount_deprec") ?? "amount_deprec") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@CurrencyId_DEPREC, "currencyid_deprec") ?? "currencyid_deprec") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@CurrencyId_DEPREC, "currencyid_deprec") ?? "currencyid_deprec") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@PaymentMethodId_DEPREC, "paymentmethodid_deprec") ?? "paymentmethodid_deprec") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@PaymentMethodId_DEPREC, "paymentmethodid_deprec") ?? "paymentmethodid_deprec") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@PaymentTermId_DEPREC, "paymenttermid_deprec") ?? "paymenttermid_deprec") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@PaymentTermId_DEPREC, "paymenttermid_deprec") ?? "paymenttermid_deprec") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@NegociatedExchangeRateAcc, "negociatedexchangerateacc") ?? "negociatedexchangerateacc") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@NegociatedExchangeRateAcc, "negociatedexchangerateacc") ?? "negociatedexchangerateacc") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@ExchangeRateComment, "exchangeratecomment") ?? "exchangeratecomment") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@ExchangeRateComment, "exchangeratecomment") ?? "exchangeratecomment") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@EvidenceFileId, "evidencefileid") ?? "evidencefileid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@EvidenceFileId, "evidencefileid") ?? "evidencefileid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasContract, "hascontract") ?? "hascontract") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasContract, "hascontract") ?? "hascontract") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasREPSE, "hasrepse") ?? "hasrepse") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasREPSE, "hasrepse") ?? "hasrepse") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasPaymentSupplement, "haspaymentsupplement") ?? "haspaymentsupplement") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasPaymentSupplement, "haspaymentsupplement") ?? "haspaymentsupplement") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasNoticeOfPaymentSuspension, "hasnoticeofpaymentsuspension") ?? "hasnoticeofpaymentsuspension") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasNoticeOfPaymentSuspension, "hasnoticeofpaymentsuspension") ?? "hasnoticeofpaymentsuspension") + " from ( select  unnest(@ssId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@Id, "id") ?? "id") + ",  unnest(@ssOrderId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@OrderId, "orderid") ?? "orderid") + ",  unnest(@ssHasEstim_Equal_AgrePaym_DEPR) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasEstim_Equal_AgrePaym_DEPR, "hasestim_equal_agrepaym_depr") ?? "hasestim_equal_agrepaym_depr") + ",  unnest(@ssHasSettlement_DEPR) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasSettlement_DEPR, "hassettlement_depr") ?? "hassettlement_depr") + ",  unnest(@ssHasCreditNote_DEPR) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasCreditNote_DEPR, "hascreditnote_depr") ?? "hascreditnote_depr") + ",  unnest(@ssHasVoucher_DEPR) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasVoucher_DEPR, "hasvoucher_depr") ?? "hasvoucher_depr") + ",  unnest(@ssHasSpecialPostDeliveryAuth) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasSpecialPostDeliveryAuth, "hasspecialpostdeliveryauth") ?? "hasspecialpostdeliveryauth") + ",  unnest(@ssSpecialPostDeliveryAuthId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@SpecialPostDeliveryAuthId, "specialpostdeliveryauthid") ?? "specialpostdeliveryauthid") + ",  unnest(@ssAmount_DEPREC) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@Amount_DEPREC, "amount_deprec") ?? "amount_deprec") + ",  unnest(@ssCurrencyId_DEPREC) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@CurrencyId_DEPREC, "currencyid_deprec") ?? "currencyid_deprec") + ",  unnest(@ssPaymentMethodId_DEPREC) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@PaymentMethodId_DEPREC, "paymentmethodid_deprec") ?? "paymentmethodid_deprec") + ",  unnest(@ssPaymentTermId_DEPREC) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@PaymentTermId_DEPREC, "paymenttermid_deprec") ?? "paymenttermid_deprec") + ",  unnest(@ssNegociatedExchangeRateAcc) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@NegociatedExchangeRateAcc, "negociatedexchangerateacc") ?? "negociatedexchangerateacc") + ",  unnest(@ssExchangeRateComment) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@ExchangeRateComment, "exchangeratecomment") ?? "exchangeratecomment") + ",  unnest(@ssEvidenceFileId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@EvidenceFileId, "evidencefileid") ?? "evidencefileid") + ",  unnest(@ssHasContract) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasContract, "hascontract") ?? "hascontract") + ",  unnest(@ssHasREPSE) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasREPSE, "hasrepse") ?? "hasrepse") + ",  unnest(@ssHasPaymentSupplement) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasPaymentSupplement, "haspaymentsupplement") ?? "haspaymentsupplement") + ",  unnest(@ssHasNoticeOfPaymentSuspension) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasNoticeOfPaymentSuspension, "hasnoticeofpaymentsuspension") ?? "hasnoticeofpaymentsuspension") + " ) as updateTable where " + entityTableName + "." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@Id, "id") ?? "id") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@Id, "id") ?? "id") + " ";
updateSql += "";

List<object> insertOrderIdList = new List<object>();
List<bool> insertHasEstim_Equal_AgrePaym_DEPRList = new List<bool>();
List<bool> insertHasSettlement_DEPRList = new List<bool>();
List<bool> insertHasCreditNote_DEPRList = new List<bool>();
List<bool> insertHasVoucher_DEPRList = new List<bool>();
List<bool> insertHasSpecialPostDeliveryAuthList = new List<bool>();
List<object> insertSpecialPostDeliveryAuthIdList = new List<object>();
List<decimal> insertAmount_DEPRECList = new List<decimal>();
List<object> insertCurrencyId_DEPRECList = new List<object>();
List<object> insertPaymentMethodId_DEPRECList = new List<object>();
List<object> insertPaymentTermId_DEPRECList = new List<object>();
List<decimal> insertNegociatedExchangeRateAccList = new List<decimal>();
List<string> insertExchangeRateCommentList = new List<string>();
List<object> insertEvidenceFileIdList = new List<object>();
List<bool> insertHasContractList = new List<bool>();
List<bool> insertHasREPSEList = new List<bool>();
List<bool> insertHasPaymentSupplementList = new List<bool>();
List<bool> insertHasNoticeOfPaymentSuspensionList = new List<bool>();

List<long> updateIdList = new List<long>();
List<object> updateOrderIdList = new List<object>();
List<bool> updateHasEstim_Equal_AgrePaym_DEPRList = new List<bool>();
List<bool> updateHasSettlement_DEPRList = new List<bool>();
List<bool> updateHasCreditNote_DEPRList = new List<bool>();
List<bool> updateHasVoucher_DEPRList = new List<bool>();
List<bool> updateHasSpecialPostDeliveryAuthList = new List<bool>();
List<object> updateSpecialPostDeliveryAuthIdList = new List<object>();
List<decimal> updateAmount_DEPRECList = new List<decimal>();
List<object> updateCurrencyId_DEPRECList = new List<object>();
List<object> updatePaymentMethodId_DEPRECList = new List<object>();
List<object> updatePaymentTermId_DEPRECList = new List<object>();
List<decimal> updateNegociatedExchangeRateAccList = new List<decimal>();
List<string> updateExchangeRateCommentList = new List<string>();
List<object> updateEvidenceFileIdList = new List<object>();
List<bool> updateHasContractList = new List<bool>();
List<bool> updateHasREPSEList = new List<bool>();
List<bool> updateHasPaymentSupplementList = new List<bool>();
List<bool> updateHasNoticeOfPaymentSuspensionList = new List<bool>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_2dc2cf38bcc16a8b338dc5ea9a5c6446)inParamSourceList.Current).ssENOrderAccounting;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
if ((record.ssOrderId==0L)) {
updateOrderIdList.Add(null);
} else {
updateOrderIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssOrderId));
}
updateHasEstim_Equal_AgrePaym_DEPRList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssHasEstim_Equal_AgrePaym_DEPR));
updateHasSettlement_DEPRList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssHasSettlement_DEPR));
updateHasCreditNote_DEPRList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssHasCreditNote_DEPR));
updateHasVoucher_DEPRList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssHasVoucher_DEPR));
updateHasSpecialPostDeliveryAuthList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssHasSpecialPostDeliveryAuth));
if ((record.ssSpecialPostDeliveryAuthId==0)) {
updateSpecialPostDeliveryAuthIdList.Add(null);
} else {
updateSpecialPostDeliveryAuthIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssSpecialPostDeliveryAuthId));
}
updateAmount_DEPRECList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssAmount_DEPREC));
if ((record.ssCurrencyId_DEPREC=="")) {
updateCurrencyId_DEPRECList.Add(null);
} else {
updateCurrencyId_DEPRECList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCurrencyId_DEPREC));
}
if ((record.ssPaymentMethodId_DEPREC==0L)) {
updatePaymentMethodId_DEPRECList.Add(null);
} else {
updatePaymentMethodId_DEPRECList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssPaymentMethodId_DEPREC));
}
if ((record.ssPaymentTermId_DEPREC==0L)) {
updatePaymentTermId_DEPRECList.Add(null);
} else {
updatePaymentTermId_DEPRECList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssPaymentTermId_DEPREC));
}
updateNegociatedExchangeRateAccList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssNegociatedExchangeRateAcc));
updateExchangeRateCommentList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssExchangeRateComment));
if ((record.ssEvidenceFileId==0L)) {
updateEvidenceFileIdList.Add(null);
} else {
updateEvidenceFileIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssEvidenceFileId));
}
updateHasContractList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssHasContract));
updateHasREPSEList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssHasREPSE));
updateHasPaymentSupplementList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssHasPaymentSupplement));
updateHasNoticeOfPaymentSuspensionList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssHasNoticeOfPaymentSuspension));
} else {
if ((record.ssOrderId==0L)) {
insertOrderIdList.Add(null);
} else {
insertOrderIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssOrderId));
}
insertHasEstim_Equal_AgrePaym_DEPRList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssHasEstim_Equal_AgrePaym_DEPR));
insertHasSettlement_DEPRList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssHasSettlement_DEPR));
insertHasCreditNote_DEPRList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssHasCreditNote_DEPR));
insertHasVoucher_DEPRList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssHasVoucher_DEPR));
insertHasSpecialPostDeliveryAuthList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssHasSpecialPostDeliveryAuth));
if ((record.ssSpecialPostDeliveryAuthId==0)) {
insertSpecialPostDeliveryAuthIdList.Add(null);
} else {
insertSpecialPostDeliveryAuthIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssSpecialPostDeliveryAuthId));
}
insertAmount_DEPRECList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssAmount_DEPREC));
if ((record.ssCurrencyId_DEPREC=="")) {
insertCurrencyId_DEPRECList.Add(null);
} else {
insertCurrencyId_DEPRECList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCurrencyId_DEPREC));
}
if ((record.ssPaymentMethodId_DEPREC==0L)) {
insertPaymentMethodId_DEPRECList.Add(null);
} else {
insertPaymentMethodId_DEPRECList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssPaymentMethodId_DEPREC));
}
if ((record.ssPaymentTermId_DEPREC==0L)) {
insertPaymentTermId_DEPRECList.Add(null);
} else {
insertPaymentTermId_DEPRECList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssPaymentTermId_DEPREC));
}
insertNegociatedExchangeRateAccList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssNegociatedExchangeRateAcc));
insertExchangeRateCommentList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssExchangeRateComment));
if ((record.ssEvidenceFileId==0L)) {
insertEvidenceFileIdList.Add(null);
} else {
insertEvidenceFileIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssEvidenceFileId));
}
insertHasContractList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssHasContract));
insertHasREPSEList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssHasREPSE));
insertHasPaymentSupplementList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssHasPaymentSupplement));
insertHasNoticeOfPaymentSuspensionList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssHasNoticeOfPaymentSuspension));
}
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertOrderIdList.IsEmpty() || !insertHasEstim_Equal_AgrePaym_DEPRList.IsEmpty() || !insertHasSettlement_DEPRList.IsEmpty() || !insertHasCreditNote_DEPRList.IsEmpty() || !insertHasVoucher_DEPRList.IsEmpty() || !insertHasSpecialPostDeliveryAuthList.IsEmpty() || !insertSpecialPostDeliveryAuthIdList.IsEmpty() || !insertAmount_DEPRECList.IsEmpty() || !insertCurrencyId_DEPRECList.IsEmpty() || !insertPaymentMethodId_DEPRECList.IsEmpty() || !insertPaymentTermId_DEPRECList.IsEmpty() || !insertNegociatedExchangeRateAccList.IsEmpty() || !insertExchangeRateCommentList.IsEmpty() || !insertEvidenceFileIdList.IsEmpty() || !insertHasContractList.IsEmpty() || !insertHasREPSEList.IsEmpty() || !insertHasPaymentSupplementList.IsEmpty() || !insertHasNoticeOfPaymentSuspensionList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssOrderId",DbType.Int64,insertOrderIdList);
executionService.CreateParameter(insertSqlCmd,"@ssHasEstim_Equal_AgrePaym_DEPR",DbType.Boolean,insertHasEstim_Equal_AgrePaym_DEPRList);
executionService.CreateParameter(insertSqlCmd,"@ssHasSettlement_DEPR",DbType.Boolean,insertHasSettlement_DEPRList);
executionService.CreateParameter(insertSqlCmd,"@ssHasCreditNote_DEPR",DbType.Boolean,insertHasCreditNote_DEPRList);
executionService.CreateParameter(insertSqlCmd,"@ssHasVoucher_DEPR",DbType.Boolean,insertHasVoucher_DEPRList);
executionService.CreateParameter(insertSqlCmd,"@ssHasSpecialPostDeliveryAuth",DbType.Boolean,insertHasSpecialPostDeliveryAuthList);
executionService.CreateParameter(insertSqlCmd,"@ssSpecialPostDeliveryAuthId",DbType.Int32,insertSpecialPostDeliveryAuthIdList);
executionService.CreateParameter(insertSqlCmd,"@ssAmount_DEPREC",DbType.Decimal,insertAmount_DEPRECList);
executionService.CreateParameter(insertSqlCmd,"@ssCurrencyId_DEPREC",DbType.String,insertCurrencyId_DEPRECList);
executionService.CreateParameter(insertSqlCmd,"@ssPaymentMethodId_DEPREC",DbType.Int64,insertPaymentMethodId_DEPRECList);
executionService.CreateParameter(insertSqlCmd,"@ssPaymentTermId_DEPREC",DbType.Int64,insertPaymentTermId_DEPRECList);
executionService.CreateParameter(insertSqlCmd,"@ssNegociatedExchangeRateAcc",DbType.Decimal,insertNegociatedExchangeRateAccList);
executionService.CreateParameter(insertSqlCmd,"@ssExchangeRateComment",DbType.String,insertExchangeRateCommentList);
executionService.CreateParameter(insertSqlCmd,"@ssEvidenceFileId",DbType.Int64,insertEvidenceFileIdList);
executionService.CreateParameter(insertSqlCmd,"@ssHasContract",DbType.Boolean,insertHasContractList);
executionService.CreateParameter(insertSqlCmd,"@ssHasREPSE",DbType.Boolean,insertHasREPSEList);
executionService.CreateParameter(insertSqlCmd,"@ssHasPaymentSupplement",DbType.Boolean,insertHasPaymentSupplementList);
executionService.CreateParameter(insertSqlCmd,"@ssHasNoticeOfPaymentSuspension",DbType.Boolean,insertHasNoticeOfPaymentSuspensionList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeOrderAccounting (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateOrderIdList.IsEmpty() || !updateHasEstim_Equal_AgrePaym_DEPRList.IsEmpty() || !updateHasSettlement_DEPRList.IsEmpty() || !updateHasCreditNote_DEPRList.IsEmpty() || !updateHasVoucher_DEPRList.IsEmpty() || !updateHasSpecialPostDeliveryAuthList.IsEmpty() || !updateSpecialPostDeliveryAuthIdList.IsEmpty() || !updateAmount_DEPRECList.IsEmpty() || !updateCurrencyId_DEPRECList.IsEmpty() || !updatePaymentMethodId_DEPRECList.IsEmpty() || !updatePaymentTermId_DEPRECList.IsEmpty() || !updateNegociatedExchangeRateAccList.IsEmpty() || !updateExchangeRateCommentList.IsEmpty() || !updateEvidenceFileIdList.IsEmpty() || !updateHasContractList.IsEmpty() || !updateHasREPSEList.IsEmpty() || !updateHasPaymentSupplementList.IsEmpty() || !updateHasNoticeOfPaymentSuspensionList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssOrderId",DbType.Int64,updateOrderIdList);
executionService.CreateParameter(updateSqlCmd,"@ssHasEstim_Equal_AgrePaym_DEPR",DbType.Boolean,updateHasEstim_Equal_AgrePaym_DEPRList);
executionService.CreateParameter(updateSqlCmd,"@ssHasSettlement_DEPR",DbType.Boolean,updateHasSettlement_DEPRList);
executionService.CreateParameter(updateSqlCmd,"@ssHasCreditNote_DEPR",DbType.Boolean,updateHasCreditNote_DEPRList);
executionService.CreateParameter(updateSqlCmd,"@ssHasVoucher_DEPR",DbType.Boolean,updateHasVoucher_DEPRList);
executionService.CreateParameter(updateSqlCmd,"@ssHasSpecialPostDeliveryAuth",DbType.Boolean,updateHasSpecialPostDeliveryAuthList);
executionService.CreateParameter(updateSqlCmd,"@ssSpecialPostDeliveryAuthId",DbType.Int32,updateSpecialPostDeliveryAuthIdList);
executionService.CreateParameter(updateSqlCmd,"@ssAmount_DEPREC",DbType.Decimal,updateAmount_DEPRECList);
executionService.CreateParameter(updateSqlCmd,"@ssCurrencyId_DEPREC",DbType.String,updateCurrencyId_DEPRECList);
executionService.CreateParameter(updateSqlCmd,"@ssPaymentMethodId_DEPREC",DbType.Int64,updatePaymentMethodId_DEPRECList);
executionService.CreateParameter(updateSqlCmd,"@ssPaymentTermId_DEPREC",DbType.Int64,updatePaymentTermId_DEPRECList);
executionService.CreateParameter(updateSqlCmd,"@ssNegociatedExchangeRateAcc",DbType.Decimal,updateNegociatedExchangeRateAccList);
executionService.CreateParameter(updateSqlCmd,"@ssExchangeRateComment",DbType.String,updateExchangeRateCommentList);
executionService.CreateParameter(updateSqlCmd,"@ssEvidenceFileId",DbType.Int64,updateEvidenceFileIdList);
executionService.CreateParameter(updateSqlCmd,"@ssHasContract",DbType.Boolean,updateHasContractList);
executionService.CreateParameter(updateSqlCmd,"@ssHasREPSE",DbType.Boolean,updateHasREPSEList);
executionService.CreateParameter(updateSqlCmd,"@ssHasPaymentSupplement",DbType.Boolean,updateHasPaymentSupplementList);
executionService.CreateParameter(updateSqlCmd,"@ssHasNoticeOfPaymentSuspension",DbType.Boolean,updateHasNoticeOfPaymentSuspensionList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeOrderAccounting (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteOrderAccounting
/// </summary>

public static async Task DeleteOrderAccounting(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteOrderAccounting", "8d58a902-fc36-4939-b4ce-d8d2b9f315b3.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteOrderAccounting", "8d58a902-fc36-4939-b4ce-d8d2b9f315b3.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENOrderAccountingEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteOrderAccounting", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllOrderAccounting
/// </summary>

public static async Task DeleteAllOrderAccounting(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllOrderAccounting", "8d58a902-fc36-4939-b4ce-d8d2b9f315b3.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllOrderAccounting", "8d58a902-fc36-4939-b4ce-d8d2b9f315b3.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENOrderAccountingEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteOrderAccounting", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetOrderAccounting
/// </summary>

public static async Task<RC_2dc2cf38bcc16a8b338dc5ea9a5c6446> GetOrderAccounting(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_2dc2cf38bcc16a8b338dc5ea9a5c6446 outParamRecord = default;
outParamRecord = new RC_2dc2cf38bcc16a8b338dc5ea9a5c6446();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetOrderAccounting", "8d58a902-fc36-4939-b4ce-d8d2b9f315b3.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetOrderAccounting", "8d58a902-fc36-4939-b4ce-d8d2b9f315b3.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@OrderId, "orderid") ?? "orderid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasEstim_Equal_AgrePaym_DEPR, "hasestim_equal_agrepaym_depr") ?? "hasestim_equal_agrepaym_depr", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasSettlement_DEPR, "hassettlement_depr") ?? "hassettlement_depr", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasCreditNote_DEPR, "hascreditnote_depr") ?? "hascreditnote_depr", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasVoucher_DEPR, "hasvoucher_depr") ?? "hasvoucher_depr", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasSpecialPostDeliveryAuth, "hasspecialpostdeliveryauth") ?? "hasspecialpostdeliveryauth", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@SpecialPostDeliveryAuthId, "specialpostdeliveryauthid") ?? "specialpostdeliveryauthid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@Amount_DEPREC, "amount_deprec") ?? "amount_deprec", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@CurrencyId_DEPREC, "currencyid_deprec") ?? "currencyid_deprec", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@PaymentMethodId_DEPREC, "paymentmethodid_deprec") ?? "paymentmethodid_deprec", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@PaymentTermId_DEPREC, "paymenttermid_deprec") ?? "paymenttermid_deprec", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@NegociatedExchangeRateAcc, "negociatedexchangerateacc") ?? "negociatedexchangerateacc", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@ExchangeRateComment, "exchangeratecomment") ?? "exchangeratecomment", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@EvidenceFileId, "evidencefileid") ?? "evidencefileid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasContract, "hascontract") ?? "hascontract", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasREPSE, "hasrepse") ?? "hasrepse", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasPaymentSupplement, "haspaymentsupplement") ?? "haspaymentsupplement", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasNoticeOfPaymentSuspension, "hasnoticeofpaymentsuspension") ?? "hasnoticeofpaymentsuspension", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
" FROM " + ENOrderAccountingEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetOrderAccounting", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(19,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENOrderAccountingEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetOrderAccountingForUpdate
/// </summary>

public static async Task<RC_2dc2cf38bcc16a8b338dc5ea9a5c6446> GetOrderAccountingForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_2dc2cf38bcc16a8b338dc5ea9a5c6446 outParamRecord = default;
outParamRecord = new RC_2dc2cf38bcc16a8b338dc5ea9a5c6446();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetOrderAccountingForUpdate", "8d58a902-fc36-4939-b4ce-d8d2b9f315b3.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetOrderAccountingForUpdate", "8d58a902-fc36-4939-b4ce-d8d2b9f315b3.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@OrderId, "orderid") ?? "orderid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasEstim_Equal_AgrePaym_DEPR, "hasestim_equal_agrepaym_depr") ?? "hasestim_equal_agrepaym_depr", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasSettlement_DEPR, "hassettlement_depr") ?? "hassettlement_depr", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasCreditNote_DEPR, "hascreditnote_depr") ?? "hascreditnote_depr", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasVoucher_DEPR, "hasvoucher_depr") ?? "hasvoucher_depr", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasSpecialPostDeliveryAuth, "hasspecialpostdeliveryauth") ?? "hasspecialpostdeliveryauth", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@SpecialPostDeliveryAuthId, "specialpostdeliveryauthid") ?? "specialpostdeliveryauthid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@Amount_DEPREC, "amount_deprec") ?? "amount_deprec", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@CurrencyId_DEPREC, "currencyid_deprec") ?? "currencyid_deprec", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@PaymentMethodId_DEPREC, "paymentmethodid_deprec") ?? "paymentmethodid_deprec", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@PaymentTermId_DEPREC, "paymenttermid_deprec") ?? "paymenttermid_deprec", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@NegociatedExchangeRateAcc, "negociatedexchangerateacc") ?? "negociatedexchangerateacc", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@ExchangeRateComment, "exchangeratecomment") ?? "exchangeratecomment", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@EvidenceFileId, "evidencefileid") ?? "evidencefileid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasContract, "hascontract") ?? "hascontract", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasREPSE, "hasrepse") ?? "hasrepse", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasPaymentSupplement, "haspaymentsupplement") ?? "haspaymentsupplement", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasNoticeOfPaymentSuspension, "hasnoticeofpaymentsuspension") ?? "hasnoticeofpaymentsuspension", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
" FROM " + ENOrderAccountingEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetOrderAccountingForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(19,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENOrderAccountingEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateOrderAccounting
/// </summary>

public static async Task UpdateOrderAccounting(IRequestContext requestContext,BitArray usedFields,RC_2dc2cf38bcc16a8b338dc5ea9a5c6446 inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateOrderAccounting", "8d58a902-fc36-4939-b4ce-d8d2b9f315b3.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateOrderAccounting", "8d58a902-fc36-4939-b4ce-d8d2b9f315b3.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord ssENOrderAccounting = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(19,true);
}
string updateSet = "UPDATE " + ENOrderAccountingEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@OrderId, "orderid") ?? "orderid") + " = @ssOrderId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasEstim_Equal_AgrePaym_DEPR, "hasestim_equal_agrepaym_depr") ?? "hasestim_equal_agrepaym_depr") + " = @ssHasEstim_Equal_AgrePaym_DEPR"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasSettlement_DEPR, "hassettlement_depr") ?? "hassettlement_depr") + " = @ssHasSettlement_DEPR"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasCreditNote_DEPR, "hascreditnote_depr") ?? "hascreditnote_depr") + " = @ssHasCreditNote_DEPR"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasVoucher_DEPR, "hasvoucher_depr") ?? "hasvoucher_depr") + " = @ssHasVoucher_DEPR"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasSpecialPostDeliveryAuth, "hasspecialpostdeliveryauth") ?? "hasspecialpostdeliveryauth") + " = @ssHasSpecialPostDeliveryAuth"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@SpecialPostDeliveryAuthId, "specialpostdeliveryauthid") ?? "specialpostdeliveryauthid") + " = @ssSpecialPostDeliveryAuthId"): parameters);
parameters = (usedFields[8] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@Amount_DEPREC, "amount_deprec") ?? "amount_deprec") + " = @ssAmount_DEPREC"): parameters);
parameters = (usedFields[9] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@CurrencyId_DEPREC, "currencyid_deprec") ?? "currencyid_deprec") + " = @ssCurrencyId_DEPREC"): parameters);
parameters = (usedFields[10] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@PaymentMethodId_DEPREC, "paymentmethodid_deprec") ?? "paymentmethodid_deprec") + " = @ssPaymentMethodId_DEPREC"): parameters);
parameters = (usedFields[11] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@PaymentTermId_DEPREC, "paymenttermid_deprec") ?? "paymenttermid_deprec") + " = @ssPaymentTermId_DEPREC"): parameters);
parameters = (usedFields[12] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@NegociatedExchangeRateAcc, "negociatedexchangerateacc") ?? "negociatedexchangerateacc") + " = @ssNegociatedExchangeRateAcc"): parameters);
parameters = (usedFields[13] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@ExchangeRateComment, "exchangeratecomment") ?? "exchangeratecomment") + " = @ssExchangeRateComment"): parameters);
parameters = (usedFields[14] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@EvidenceFileId, "evidencefileid") ?? "evidencefileid") + " = @ssEvidenceFileId"): parameters);
parameters = (usedFields[15] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasContract, "hascontract") ?? "hascontract") + " = @ssHasContract"): parameters);
parameters = (usedFields[16] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasREPSE, "hasrepse") ?? "hasrepse") + " = @ssHasREPSE"): parameters);
parameters = (usedFields[17] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasPaymentSupplement, "haspaymentsupplement") ?? "haspaymentsupplement") + " = @ssHasPaymentSupplement"): parameters);
parameters = (usedFields[18] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasNoticeOfPaymentSuspension, "hasnoticeofpaymentsuspension") ?? "hasnoticeofpaymentsuspension") + " = @ssHasNoticeOfPaymentSuspension"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENOrderAccounting_ssId_OrderAccounting";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasEstim_Equal_AgrePaym_DEPR, "hasestim_equal_agrepaym_depr") ?? "hasestim_equal_agrepaym_depr") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasEstim_Equal_AgrePaym_DEPR, "hasestim_equal_agrepaym_depr") ?? "hasestim_equal_agrepaym_depr") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENOrderAccounting.ssOrderId==0L)) {
sqlCmd.CreateParameter("@ssOrderId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssOrderId", DbType.Int64, ssENOrderAccounting.ssOrderId);

}
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssHasEstim_Equal_AgrePaym_DEPR", DbType.Boolean, ssENOrderAccounting.ssHasEstim_Equal_AgrePaym_DEPR);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssHasSettlement_DEPR", DbType.Boolean, ssENOrderAccounting.ssHasSettlement_DEPR);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssHasCreditNote_DEPR", DbType.Boolean, ssENOrderAccounting.ssHasCreditNote_DEPR);
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssHasVoucher_DEPR", DbType.Boolean, ssENOrderAccounting.ssHasVoucher_DEPR);
}
if(usedFields[6]) {
sqlCmd.CreateParameter("@ssHasSpecialPostDeliveryAuth", DbType.Boolean, ssENOrderAccounting.ssHasSpecialPostDeliveryAuth);
}
if(usedFields[7]) {
if ((ssENOrderAccounting.ssSpecialPostDeliveryAuthId==0)) {
sqlCmd.CreateParameter("@ssSpecialPostDeliveryAuthId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssSpecialPostDeliveryAuthId", DbType.Int32, ssENOrderAccounting.ssSpecialPostDeliveryAuthId);

}
}
if(usedFields[8]) {
var Amount_DEPRECParameter = sqlCmd.CreateParameter("@ssAmount_DEPREC", DbType.Decimal, ssENOrderAccounting.ssAmount_DEPREC);
{
    string decimalAsStr = ssENOrderAccounting.ssAmount_DEPREC.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {Amount_DEPRECParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[9]) {
if ((ssENOrderAccounting.ssCurrencyId_DEPREC=="")) {
sqlCmd.CreateParameter("@ssCurrencyId_DEPREC", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCurrencyId_DEPREC", DbType.String, ssENOrderAccounting.ssCurrencyId_DEPREC);

}
}
if(usedFields[10]) {
if ((ssENOrderAccounting.ssPaymentMethodId_DEPREC==0L)) {
sqlCmd.CreateParameter("@ssPaymentMethodId_DEPREC", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssPaymentMethodId_DEPREC", DbType.Int64, ssENOrderAccounting.ssPaymentMethodId_DEPREC);

}
}
if(usedFields[11]) {
if ((ssENOrderAccounting.ssPaymentTermId_DEPREC==0L)) {
sqlCmd.CreateParameter("@ssPaymentTermId_DEPREC", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssPaymentTermId_DEPREC", DbType.Int64, ssENOrderAccounting.ssPaymentTermId_DEPREC);

}
}
if(usedFields[12]) {
var NegociatedExchangeRateAccParameter = sqlCmd.CreateParameter("@ssNegociatedExchangeRateAcc", DbType.Decimal, ssENOrderAccounting.ssNegociatedExchangeRateAcc);
{
    string decimalAsStr = ssENOrderAccounting.ssNegociatedExchangeRateAcc.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {NegociatedExchangeRateAccParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[13]) {
sqlCmd.CreateParameter("@ssExchangeRateComment", DbType.String, ssENOrderAccounting.ssExchangeRateComment);
}
if(usedFields[14]) {
if ((ssENOrderAccounting.ssEvidenceFileId==0L)) {
sqlCmd.CreateParameter("@ssEvidenceFileId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssEvidenceFileId", DbType.Int64, ssENOrderAccounting.ssEvidenceFileId);

}
}
if(usedFields[15]) {
sqlCmd.CreateParameter("@ssHasContract", DbType.Boolean, ssENOrderAccounting.ssHasContract);
}
if(usedFields[16]) {
sqlCmd.CreateParameter("@ssHasREPSE", DbType.Boolean, ssENOrderAccounting.ssHasREPSE);
}
if(usedFields[17]) {
sqlCmd.CreateParameter("@ssHasPaymentSupplement", DbType.Boolean, ssENOrderAccounting.ssHasPaymentSupplement);
}
if(usedFields[18]) {
sqlCmd.CreateParameter("@ssHasNoticeOfPaymentSuspension", DbType.Boolean, ssENOrderAccounting.ssHasNoticeOfPaymentSuspension);
}
sqlCmd.CreateParameter("@idparam_ssENOrderAccounting_ssId_OrderAccounting", DbType.Int64, ssENOrderAccounting.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateOrderAccounting", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("OrderAccounting", ssENOrderAccounting.ssId.ToString()); }}
}
return;
}

}
}
