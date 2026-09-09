using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENRequisitionLogsEntity {
private static readonly ActivitySource activitySource = new(typeof(ENRequisitionLogsEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionLogsAttributeKeys.@Id, "id") ?? "id"},
{"requisitionid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionLogsAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid"},
{"createdby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionLogsAttributeKeys.@CreatedBy, "createdby") ?? "createdby"},
{"createdon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionLogsAttributeKeys.@CreatedOn, "createdon") ?? "createdon"},
{"message", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionLogsAttributeKeys.@Message, "message") ?? "message"},
{"iserror", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionLogs, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionLogsAttributeKeys.@IsError, "iserror") ?? "iserror"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionLogs, "requi_u8aqr95gpfe0c7xo4ib8z5q7"));
}
} // ENRequisitionLogsEntity

}

