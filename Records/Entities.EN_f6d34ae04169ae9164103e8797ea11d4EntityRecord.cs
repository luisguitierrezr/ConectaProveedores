using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENProposalStatusHistoryEntity {
private static readonly ActivitySource activitySource = new(typeof(ENProposalStatusHistoryEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalStatusHistoryAttributeKeys.@Id, "id") ?? "id"},
{"proposalid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalStatusHistoryAttributeKeys.@ProposalId, "proposalid") ?? "proposalid"},
{"proposalstatusid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalStatusHistoryAttributeKeys.@ProposalStatusId, "proposalstatusid") ?? "proposalstatusid"},
{"timestamp", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalStatusHistoryAttributeKeys.@TimeStamp, "timestamp") ?? "timestamp"},
{"createdby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalStatusHistoryAttributeKeys.@CreatedBy, "createdby") ?? "createdby"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalStatusHistory, "propo_u8aqr95gpfexsz56ydf8bzt4"));
}
} // ENProposalStatusHistoryEntity

}

