using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENProposalLineApprovalLevelEntity {
private static readonly ActivitySource activitySource = new(typeof(ENProposalLineApprovalLevelEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@Id, "id") ?? "id"},
{"proposallineid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@ProposalLineId, "proposallineid") ?? "proposallineid"},
{"proposalapprovallevelid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@ProposalApprovalLevelId, "proposalapprovallevelid") ?? "proposalapprovallevelid"},
{"applicationroleid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid"},
{"approvalstatusid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid"},
{"approvedby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@ApprovedBy, "approvedby") ?? "approvedby"},
{"approvedon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@ApprovedOn, "approvedon") ?? "approvedon"},
{"rejectedby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@RejectedBy, "rejectedby") ?? "rejectedby"},
{"rejectedon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalLineApprovalLevelAttributeKeys.@RejectedOn, "rejectedon") ?? "rejectedon"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalLineApprovalLevel, "propo_u8aqr95gpfe_jklzssk3jkv4"));
}
} // ENProposalLineApprovalLevelEntity

}

