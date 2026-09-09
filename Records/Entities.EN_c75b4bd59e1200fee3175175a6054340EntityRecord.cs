using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENProposalCommentEntity {
private static readonly ActivitySource activitySource = new(typeof(ENProposalCommentEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@Id, "id") ?? "id"},
{"commenttypeid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@CommentTypeId, "commenttypeid") ?? "commenttypeid"},
{"proposalid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@ProposalId, "proposalid") ?? "proposalid"},
{"proposallineid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@ProposalLineId, "proposallineid") ?? "proposallineid"},
{"proposallineapprovallevelid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@ProposalLineApprovalLevelId, "proposallineapprovallevelid") ?? "proposallineapprovallevelid"},
{"applicationroleid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid"},
{"createdby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@CreatedBy, "createdby") ?? "createdby"},
{"message", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalCommentAttributeKeys.@Message, "message") ?? "message"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalComment, "comme_u8aqr95gpfe1br30zvit5cq0"));
}
} // ENProposalCommentEntity

}

