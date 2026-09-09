using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENOrderRequestFileApprovalEntity {
private static readonly ActivitySource activitySource = new(typeof(ENOrderRequestFileApprovalEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalAttributeKeys.@Id, "id") ?? "id"},
{"orderrequestfileid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalAttributeKeys.@OrderRequestFileId, "orderrequestfileid") ?? "orderrequestfileid"},
{"currentlevel", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalAttributeKeys.@CurrentLevel, "currentlevel") ?? "currentlevel"},
{"maxlevel", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalAttributeKeys.@MaxLevel, "maxlevel") ?? "maxlevel"},
{"startedon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalAttributeKeys.@StartedOn, "startedon") ?? "startedon"},
{"finishedon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApproval, "order_u8aqr95gpfe25lhmi_mlq5g2"));
}
} // ENOrderRequestFileApprovalEntity

}

