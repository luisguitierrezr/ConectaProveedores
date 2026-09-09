using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENFolioApprovalEntity {
private static readonly ActivitySource activitySource = new(typeof(ENFolioApprovalEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@Id, "id") ?? "id"},
{"folioid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@FolioId, "folioid") ?? "folioid"},
{"approvalprocessid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@ApprovalProcessId, "approvalprocessid") ?? "approvalprocessid"},
{"processtypecode", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@ProcessTypeCode, "processtypecode") ?? "processtypecode"},
{"approvalprocessversion", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@ApprovalProcessVersion, "approvalprocessversion") ?? "approvalprocessversion"},
{"currentlevel", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@CurrentLevel, "currentlevel") ?? "currentlevel"},
{"maxlevel", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@MaxLevel, "maxlevel") ?? "maxlevel"},
{"startedon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@StartedOn, "startedon") ?? "startedon"},
{"finishedon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon"},
{"regionid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalAttributeKeys.@RegionId, "regionid") ?? "regionid"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApproval, "folio_u8aqr95gpfe_ev5wxg98yg37"));
}
} // ENFolioApprovalEntity

}

