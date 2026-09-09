using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENOrderServiceEntity {
private static readonly ActivitySource activitySource = new(typeof(ENOrderServiceEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@Id, "id") ?? "id"},
{"orderid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@OrderId, "orderid") ?? "orderid"},
{"accountingservicetypeid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@AccountingServiceTypeId, "accountingservicetypeid") ?? "accountingservicetypeid"},
{"frequencyid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@FrequencyId, "frequencyid") ?? "frequencyid"},
{"amount", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@Amount, "amount") ?? "amount"},
{"description", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@Description, "description") ?? "description"},
{"invoiceusageid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderServiceAttributeKeys.@InvoiceUsageId, "invoiceusageid") ?? "invoiceusageid"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderService, "order_u8aqr95gpfe1c9rmqrp670l3"));
}
} // ENOrderServiceEntity

}

