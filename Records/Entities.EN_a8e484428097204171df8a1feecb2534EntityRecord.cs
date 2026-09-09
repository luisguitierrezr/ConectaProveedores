using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENOrderLogsEntity {
private static readonly ActivitySource activitySource = new(typeof(ENOrderLogsEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderLogsAttributeKeys.@Id, "id") ?? "id"},
{"orderid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderLogsAttributeKeys.@OrderId, "orderid") ?? "orderid"},
{"createdby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderLogsAttributeKeys.@CreatedBy, "createdby") ?? "createdby"},
{"createdon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderLogsAttributeKeys.@CreatedOn, "createdon") ?? "createdon"},
{"message", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderLogsAttributeKeys.@Message, "message") ?? "message"},
{"iserror", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderLogsAttributeKeys.@IsError, "iserror") ?? "iserror"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderLogs, "order_u8aqr95gpfe1v6hz5762jcz4"));
}
} // ENOrderLogsEntity

}

