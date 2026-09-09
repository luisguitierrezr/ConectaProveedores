using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENProposalApprovalEntity {
private static readonly ActivitySource activitySource = new(typeof(ENProposalApprovalEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@Id, "id") ?? "id"},
{"proposalid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@ProposalId, "proposalid") ?? "proposalid"},
{"processtypecode", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@ProcessTypeCode, "processtypecode") ?? "processtypecode"},
{"approvalprocessversion", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@ApprovalProcessVersion, "approvalprocessversion") ?? "approvalprocessversion"},
{"currentlevel_deprec", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@CurrentLevel_DEPREC, "currentlevel_deprec") ?? "currentlevel_deprec"},
{"maxlevel_deprec", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@MaxLevel_DEPREC, "maxlevel_deprec") ?? "maxlevel_deprec"},
{"startedon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@StartedOn, "startedon") ?? "startedon"},
{"finishedon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalApprovalAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalApproval, "propo_u8aqr95gpfe0nx9hftsrncu0"));
}
} // ENProposalApprovalEntity

}

