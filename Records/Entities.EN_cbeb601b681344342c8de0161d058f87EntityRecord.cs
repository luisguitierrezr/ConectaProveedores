using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENRequisitionCommentEntity {
private static readonly ActivitySource activitySource = new(typeof(ENRequisitionCommentEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@Id, "id") ?? "id"},
{"commenttypeid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@CommentTypeId, "commenttypeid") ?? "commenttypeid"},
{"requisitionid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid"},
{"requisitionapprovallevelid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@RequisitionApprovalLevelId, "requisitionapprovallevelid") ?? "requisitionapprovallevelid"},
{"applicationroleid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid"},
{"createdon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@CreatedOn, "createdon") ?? "createdon"},
{"createdby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby"},
{"message", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCommentAttributeKeys.@Message, "message") ?? "message"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionComment, "requi_u8aqr95gpfezzwbl0ltwczf4"));
}
} // ENRequisitionCommentEntity

}

