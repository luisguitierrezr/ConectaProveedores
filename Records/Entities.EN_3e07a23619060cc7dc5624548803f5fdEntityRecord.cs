using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENOrderAccConceptsEntity {
private static readonly ActivitySource activitySource = new(typeof(ENOrderAccConceptsEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@Id, "id") ?? "id"},
{"orderaccountingid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@OrderAccountingId, "orderaccountingid") ?? "orderaccountingid"},
{"accountingdatatypeid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@AccountingDataTypeId, "accountingdatatypeid") ?? "accountingdatatypeid"},
{"numberofpayments", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@NumberOfPayments, "numberofpayments") ?? "numberofpayments"},
{"amount", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@Amount, "amount") ?? "amount"},
{"currencyid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid"},
{"orderaccconceptsid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@OrderAccConceptsId, "orderaccconceptsid") ?? "orderaccconceptsid"},
{"applyforrequestproject", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@ApplyForRequestProject, "applyforrequestproject") ?? "applyforrequestproject"},
{"paymenttermid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@PaymentTermId, "paymenttermid") ?? "paymenttermid"},
{"paymenttermcustomdays", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@PaymentTermCustomDays, "paymenttermcustomdays") ?? "paymenttermcustomdays"},
{"isactive", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@IsActive, "isactive") ?? "isactive"},
{"advancepaymenttypeid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@AdvancePaymentTypeId, "advancepaymenttypeid") ?? "advancepaymenttypeid"},
{"paymentdate", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@PaymentDate, "paymentdate") ?? "paymentdate"},
{"paymentmethodsidtodelete", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderAccConceptsAttributeKeys.@PaymentMethodsIdToDelete, "paymentmethodsidtodelete") ?? "paymentmethodsidtodelete"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderAccConcepts, "order_u8aqr95gpfe02ysl1ro2h6s5"));
}
} // ENOrderAccConceptsEntity

}

