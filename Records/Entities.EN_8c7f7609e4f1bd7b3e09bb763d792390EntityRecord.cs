using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENOrderAccountingEntity {
private static readonly ActivitySource activitySource = new(typeof(ENOrderAccountingEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@Id, "id") ?? "id"},
{"orderid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@OrderId, "orderid") ?? "orderid"},
{"hasestim_equal_agrepaym_depr", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasEstim_Equal_AgrePaym_DEPR, "hasestim_equal_agrepaym_depr") ?? "hasestim_equal_agrepaym_depr"},
{"hassettlement_depr", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasSettlement_DEPR, "hassettlement_depr") ?? "hassettlement_depr"},
{"hascreditnote_depr", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasCreditNote_DEPR, "hascreditnote_depr") ?? "hascreditnote_depr"},
{"hasvoucher_depr", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasVoucher_DEPR, "hasvoucher_depr") ?? "hasvoucher_depr"},
{"hasspecialpostdeliveryauth", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasSpecialPostDeliveryAuth, "hasspecialpostdeliveryauth") ?? "hasspecialpostdeliveryauth"},
{"specialpostdeliveryauthid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@SpecialPostDeliveryAuthId, "specialpostdeliveryauthid") ?? "specialpostdeliveryauthid"},
{"amount_deprec", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@Amount_DEPREC, "amount_deprec") ?? "amount_deprec"},
{"currencyid_deprec", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@CurrencyId_DEPREC, "currencyid_deprec") ?? "currencyid_deprec"},
{"paymentmethodid_deprec", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@PaymentMethodId_DEPREC, "paymentmethodid_deprec") ?? "paymentmethodid_deprec"},
{"paymenttermid_deprec", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@PaymentTermId_DEPREC, "paymenttermid_deprec") ?? "paymenttermid_deprec"},
{"negociatedexchangerateacc", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@NegociatedExchangeRateAcc, "negociatedexchangerateacc") ?? "negociatedexchangerateacc"},
{"exchangeratecomment", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@ExchangeRateComment, "exchangeratecomment") ?? "exchangeratecomment"},
{"evidencefileid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@EvidenceFileId, "evidencefileid") ?? "evidencefileid"},
{"hascontract", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasContract, "hascontract") ?? "hascontract"},
{"hasrepse", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasREPSE, "hasrepse") ?? "hasrepse"},
{"haspaymentsupplement", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasPaymentSupplement, "haspaymentsupplement") ?? "haspaymentsupplement"},
{"hasnoticeofpaymentsuspension", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccountingAttributeKeys.@HasNoticeOfPaymentSuspension, "hasnoticeofpaymentsuspension") ?? "hasnoticeofpaymentsuspension"}
};
}
public static System.Collections.Generic.Dictionary<string,string> AttributesToDatabaseNamesMap() {
return EntityAttributes;
}
public static string AttributeDatabaseName(string attributeName) {
string databaseName;
EntityAttributes.TryGetValue(attributeName, out databaseName);
return databaseName;
}
public static string LocalViewName(string locale) {
return ViewName(locale);
}
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccounting, "order_u8aqr95gpfes0krevg2t64a5"));
}
} // ENOrderAccountingEntity

}

