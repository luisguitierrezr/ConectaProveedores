using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENOrderRequestFileApprovalLevelEntity {
private static readonly ActivitySource activitySource = new(typeof(ENOrderRequestFileApprovalLevelEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@Id, "id") ?? "id"},
{"orderrequestfileapprovalid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@OrderRequestFileApprovalId, "orderrequestfileapprovalid") ?? "orderrequestfileapprovalid"},
{"levelnumber", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@LevelNumber, "levelnumber") ?? "levelnumber"},
{"entraroleid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@EntraRoleId, "entraroleid") ?? "entraroleid"},
{"assignedto", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@AssignedTo, "assignedto") ?? "assignedto"},
{"approvalstatusid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid"},
{"approvedby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@ApprovedBy, "approvedby") ?? "approvedby"},
{"approvedon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@ApprovedOn, "approvedon") ?? "approvedon"},
{"rejectedby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@RejectedBy, "rejectedby") ?? "rejectedby"},
{"rejectedon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@RejectedOn, "rejectedon") ?? "rejectedon"},
{"isreassigned", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@IsReassigned, "isreassigned") ?? "isreassigned"},
{"issubstitutefor", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRequestFileApprovalLevelAttributeKeys.@IsSubstituteFor, "issubstitutefor") ?? "issubstitutefor"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRequestFileApprovalLevel, "order_u8aqr95gpfes5j1glwy8c602"));
}
} // ENOrderRequestFileApprovalLevelEntity

}

