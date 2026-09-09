using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENRequisitionAccConceptsEntity {
private static readonly ActivitySource activitySource = new(typeof(ENRequisitionAccConceptsEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@Id, "id") ?? "id"},
{"requisitionaccountingid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@RequisitionAccountingId, "requisitionaccountingid") ?? "requisitionaccountingid"},
{"accountingdatatypeid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@AccountingDataTypeId, "accountingdatatypeid") ?? "accountingdatatypeid"},
{"numberofpayments", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@NumberOfPayments, "numberofpayments") ?? "numberofpayments"},
{"amount", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@Amount, "amount") ?? "amount"},
{"currencyid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid"},
{"requisitionaccconceptsid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@RequisitionAccConceptsId, "requisitionaccconceptsid") ?? "requisitionaccconceptsid"},
{"isactive", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAccConceptsAttributeKeys.@IsActive, "isactive") ?? "isactive"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionAccConcepts, "requi_u8aqr95gpfexnu8z9hkevv_6"));
}
} // ENRequisitionAccConceptsEntity

}

