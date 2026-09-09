using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENOrderApprovalEntity {
private static readonly ActivitySource activitySource = new(typeof(ENOrderApprovalEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@Id, "id") ?? "id"},
{"orderid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@OrderId, "orderid") ?? "orderid"},
{"currentlevel", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@CurrentLevel, "currentlevel") ?? "currentlevel"},
{"maxlevel", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@MaxLevel, "maxlevel") ?? "maxlevel"},
{"startedon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@StartedOn, "startedon") ?? "startedon"},
{"finishedon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon"},
{"lastapproverpuestodelgerente", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@LastApproverPuestodelGerente, "lastapproverpuestodelgerente") ?? "lastapproverpuestodelgerente"},
{"lastapproverpuestodeljefe", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalAttributeKeys.@LastApproverPuestodelJefe, "lastapproverpuestodeljefe") ?? "lastapproverpuestodeljefe"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApproval, "order_u8aqr95gpfeookaq8d3dex16"));
}
} // ENOrderApprovalEntity

}

