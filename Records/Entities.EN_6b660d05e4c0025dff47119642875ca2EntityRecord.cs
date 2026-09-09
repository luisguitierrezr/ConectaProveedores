using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENOrderApprovalLevelEntity {
private static readonly ActivitySource activitySource = new(typeof(ENOrderApprovalLevelEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@Id, "id") ?? "id"},
{"orderapprovalid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@OrderApprovalId, "orderapprovalid") ?? "orderapprovalid"},
{"levelnumber", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@LevelNumber, "levelnumber") ?? "levelnumber"},
{"entraroleid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@EntraRoleId, "entraroleid") ?? "entraroleid"},
{"assignedto", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@AssignedTo, "assignedto") ?? "assignedto"},
{"assignedon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@AssignedOn, "assignedon") ?? "assignedon"},
{"approvalstatusid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid"},
{"approvedby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@ApprovedBy, "approvedby") ?? "approvedby"},
{"approvedon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@ApprovedOn, "approvedon") ?? "approvedon"},
{"rejectedby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@RejectedBy, "rejectedby") ?? "rejectedby"},
{"rejectedon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@RejectedOn, "rejectedon") ?? "rejectedon"},
{"iscomplement", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@IsComplement, "iscomplement") ?? "iscomplement"},
{"isreassigned", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@IsReassigned, "isreassigned") ?? "isreassigned"},
{"issubstitutefor", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@IsSubstituteFor, "issubstitutefor") ?? "issubstitutefor"},
{"tomodifyby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@ToModifyBy, "tomodifyby") ?? "tomodifyby"},
{"tomodifyon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@ToModifyOn, "tomodifyon") ?? "tomodifyon"},
{"wascanceledby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderApprovalLevelAttributeKeys.@WasCanceledBy, "wascanceledby") ?? "wascanceledby"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderApprovalLevel, "order_u8aqr95gpfe_mm1g6nn86471"));
}
} // ENOrderApprovalLevelEntity

}

