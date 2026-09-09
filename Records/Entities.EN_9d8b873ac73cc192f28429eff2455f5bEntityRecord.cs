using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENProposalApprovalLevelEntity {
private static readonly ActivitySource activitySource = new(typeof(ENProposalApprovalLevelEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalLevelAttributeKeys.@Id, "id") ?? "id"},
{"proposalapprovalid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalLevelAttributeKeys.@ProposalApprovalId, "proposalapprovalid") ?? "proposalapprovalid"},
{"levelnumber", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalLevelAttributeKeys.@LevelNumber, "levelnumber") ?? "levelnumber"},
{"applicationroleid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalLevelAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid"},
{"approvalstatusid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalLevelAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid"},
{"hasstarted", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalLevelAttributeKeys.@HasStarted, "hasstarted") ?? "hasstarted"},
{"hasfinished", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalLevelAttributeKeys.@HasFinished, "hasfinished") ?? "hasfinished"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApprovalLevel, "propo_u8aqr95gpfesmv9xy2f5f3p3"));
}
} // ENProposalApprovalLevelEntity

}

