using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENInvoiceCommentEntity {
private static readonly ActivitySource activitySource = new(typeof(ENInvoiceCommentEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@Id, "id") ?? "id"},
{"invoiceid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid"},
{"invoiceapprovallevelid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@InvoiceApprovalLevelId, "invoiceapprovallevelid") ?? "invoiceapprovallevelid"},
{"applicationroleid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid"},
{"createdon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@CreatedOn, "createdon") ?? "createdon"},
{"createdby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby"},
{"message", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@Message, "message") ?? "message"},
{"ispublic", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceCommentAttributeKeys.@IsPublic, "ispublic") ?? "ispublic"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceComment, "invoi_u8aqr95gpfey8fbmo9l9uu47"));
}
} // ENInvoiceCommentEntity

}

