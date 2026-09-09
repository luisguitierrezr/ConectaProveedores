using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENRequisitionAccountingEntity {
private static readonly ActivitySource activitySource = new(typeof(ENRequisitionAccountingEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccountingAttributeKeys.@Id, "id") ?? "id"},
{"requisitionid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccountingAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid"},
{"hasestim_equal_agrepaym_depr", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccountingAttributeKeys.@HasEstim_Equal_AgrePaym_DEPR, "hasestim_equal_agrepaym_depr") ?? "hasestim_equal_agrepaym_depr"},
{"hassettlement_depr", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccountingAttributeKeys.@HasSettlement_DEPR, "hassettlement_depr") ?? "hassettlement_depr"},
{"hascreditnote_depr", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccountingAttributeKeys.@HasCreditNote_DEPR, "hascreditnote_depr") ?? "hascreditnote_depr"},
{"hasvoucher_depr", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccountingAttributeKeys.@HasVoucher_DEPR, "hasvoucher_depr") ?? "hasvoucher_depr"},
{"hasspecialpostdeliveryauth", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccountingAttributeKeys.@HasSpecialPostDeliveryAuth, "hasspecialpostdeliveryauth") ?? "hasspecialpostdeliveryauth"},
{"specialpostdeliveryauthid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccountingAttributeKeys.@SpecialPostDeliveryAuthId, "specialpostdeliveryauthid") ?? "specialpostdeliveryauthid"},
{"amount_deprec", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccountingAttributeKeys.@Amount_DEPREC, "amount_deprec") ?? "amount_deprec"},
{"currencyid_deprec", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccountingAttributeKeys.@CurrencyId_DEPREC, "currencyid_deprec") ?? "currencyid_deprec"},
{"paymentmethodid_deprec", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccountingAttributeKeys.@PaymentMethodId_DEPREC, "paymentmethodid_deprec") ?? "paymentmethodid_deprec"},
{"paymenttermid_deprec", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccountingAttributeKeys.@PaymentTermId_DEPREC, "paymenttermid_deprec") ?? "paymenttermid_deprec"},
{"negociatedexchangerateacc", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccountingAttributeKeys.@NegociatedExchangeRateAcc, "negociatedexchangerateacc") ?? "negociatedexchangerateacc"},
{"exchangeratecomment", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccountingAttributeKeys.@ExchangeRateComment, "exchangeratecomment") ?? "exchangeratecomment"},
{"evidencefileid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccountingAttributeKeys.@EvidenceFileId, "evidencefileid") ?? "evidencefileid"},
{"hascontract", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccountingAttributeKeys.@HasContract, "hascontract") ?? "hascontract"},
{"hasrepse", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccountingAttributeKeys.@HasREPSE, "hasrepse") ?? "hasrepse"},
{"haspaymentsupplement", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccountingAttributeKeys.@HasPaymentSupplement, "haspaymentsupplement") ?? "haspaymentsupplement"},
{"hasnoticeofpaymentsuspension", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccountingAttributeKeys.@HasNoticeOfPaymentSuspension, "hasnoticeofpaymentsuspension") ?? "hasnoticeofpaymentsuspension"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccounting, "requi_u8aqr95gpfeoidtku9zuqxk3"));
}
} // ENRequisitionAccountingEntity

}

