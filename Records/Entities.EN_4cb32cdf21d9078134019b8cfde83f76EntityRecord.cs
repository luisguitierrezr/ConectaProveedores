using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENOrderRequestFileCommentEntity {
private static readonly ActivitySource activitySource = new(typeof(ENOrderRequestFileCommentEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileCommentAttributeKeys.@Id, "id") ?? "id"},
{"orderrequestfileid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileCommentAttributeKeys.@OrderRequestFileId, "orderrequestfileid") ?? "orderrequestfileid"},
{"commenttypeid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileCommentAttributeKeys.@CommentTypeId, "commenttypeid") ?? "commenttypeid"},
{"createdby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby"},
{"message", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileCommentAttributeKeys.@Message, "message") ?? "message"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileComment, "order_u8aqr95gpfewvpvxmjh81wk4"));
}
} // ENOrderRequestFileCommentEntity

}

