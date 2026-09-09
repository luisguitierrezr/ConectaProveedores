using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENOrderRequestFileEntity {
private static readonly ActivitySource activitySource = new(typeof(ENOrderRequestFileEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@Id, "id") ?? "id"},
{"orderid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@OrderId, "orderid") ?? "orderid"},
{"invoiceid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid"},
{"filename", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@Filename, "filename") ?? "filename"},
{"storageid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@StorageId, "storageid") ?? "storageid"},
{"description", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@Description, "description") ?? "description"},
{"needsapproval", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@NeedsApproval, "needsapproval") ?? "needsapproval"},
{"isapproved", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@IsApproved, "isapproved") ?? "isapproved"},
{"isrejected", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@IsRejected, "isrejected") ?? "isrejected"},
{"createdby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@CreatedBy, "createdby") ?? "createdby"},
{"createdon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@CreatedOn, "createdon") ?? "createdon"},
{"updatedby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby"},
{"updatedon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon"},
{"orderaccconceptid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@OrderAccConceptId, "orderaccconceptid") ?? "orderaccconceptid"},
{"isfinancialfile", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@IsFinancialFile, "isfinancialfile") ?? "isfinancialfile"},
{"ordercontractfile", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@OrderContractFile, "ordercontractfile") ?? "ordercontractfile"},
{"needaccounting", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileAttributeKeys.@NeedAccounting, "needaccounting") ?? "needaccounting"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFile, "order_u8aqr95gpfey90o7eu2nzax0"));
}
} // ENOrderRequestFileEntity

}

