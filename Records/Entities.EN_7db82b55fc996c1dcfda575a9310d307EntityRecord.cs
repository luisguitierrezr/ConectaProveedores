using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENProposalCommentFileEntity {
private static readonly ActivitySource activitySource = new(typeof(ENProposalCommentFileEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalCommentFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentFileAttributeKeys.@Id, "id") ?? "id"},
{"commentid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalCommentFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentFileAttributeKeys.@CommentId, "commentid") ?? "commentid"},
{"filename", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalCommentFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentFileAttributeKeys.@Filename, "filename") ?? "filename"},
{"binary", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalCommentFile, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentFileAttributeKeys.@Binary, "binary") ?? "binary"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalCommentFile, "comme_u8aqr95gpfe2mv50lyi36u65"));
}
} // ENProposalCommentFileEntity

}

