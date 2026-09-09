using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENRequisitionServiceEntity {
private static readonly ActivitySource activitySource = new(typeof(ENRequisitionServiceEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@Id, "id") ?? "id"},
{"requisitionid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid"},
{"accountingservicetypeid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@AccountingServiceTypeId, "accountingservicetypeid") ?? "accountingservicetypeid"},
{"frequencyid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@FrequencyId, "frequencyid") ?? "frequencyid"},
{"amount", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@Amount, "amount") ?? "amount"},
{"description", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@Description, "description") ?? "description"},
{"invoiceusageid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionServiceAttributeKeys.@InvoiceUsageId, "invoiceusageid") ?? "invoiceusageid"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionService, "requi_u8aqr95gpfeuvl618o8l1yg3"));
}
} // ENRequisitionServiceEntity

}

