using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENLogsAccountingEntity {
private static readonly ActivitySource activitySource = new(typeof(ENLogsAccountingEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@Id, "id") ?? "id"},
{"title", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@Title, "title") ?? "title"},
{"associatedid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@AssociatedId, "associatedid") ?? "associatedid"},
{"description", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@Description, "description") ?? "description"},
{"createdby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@CreatedBy, "createdby") ?? "createdby"},
{"createdon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@CreatedOn, "createdon") ?? "createdon"},
{"logsaccountingsubjectid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, _EntityKeyConstants._ConectaProveedoresEntityKeys._LogsAccountingAttributeKeys.@LogsAccountingSubjectId, "logsaccountingsubjectid") ?? "logsaccountingsubjectid"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@LogsAccounting, "logsx_u8aqr95gpfer9nmqgmhpi8x6"));
}
} // ENLogsAccountingEntity

}

