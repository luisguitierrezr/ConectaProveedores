using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENFolioApprovalLevelEntity {
private static readonly ActivitySource activitySource = new(typeof(ENFolioApprovalLevelEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@Id, "id") ?? "id"},
{"folioapprovalid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@FolioApprovalId, "folioapprovalid") ?? "folioapprovalid"},
{"levelnumber", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@LevelNumber, "levelnumber") ?? "levelnumber"},
{"applicationroleid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid"},
{"entrajobtitle", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@EntraJobTitle, "entrajobtitle") ?? "entrajobtitle"},
{"entraroleid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@EntraRoleId, "entraroleid") ?? "entraroleid"},
{"departmentid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@DepartmentId, "departmentid") ?? "departmentid"},
{"assignedto", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@AssignedTo, "assignedto") ?? "assignedto"},
{"approvalstatusid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid"},
{"ismandatory", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@IsMandatory, "ismandatory") ?? "ismandatory"},
{"isreassigned", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@IsReassigned, "isreassigned") ?? "isreassigned"},
{"approvedby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@ApprovedBy, "approvedby") ?? "approvedby"},
{"approvedon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@ApprovedOn, "approvedon") ?? "approvedon"},
{"canceledby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@CanceledBy, "canceledby") ?? "canceledby"},
{"canceledon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@CanceledOn, "canceledon") ?? "canceledon"},
{"rejectedby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@RejectedBy, "rejectedby") ?? "rejectedby"},
{"rejectedon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@RejectedOn, "rejectedon") ?? "rejectedon"},
{"issubstitutefor", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@IsSubstituteFor, "issubstitutefor") ?? "issubstitutefor"},
{"rejectreason", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@RejectReason, "rejectreason") ?? "rejectreason"},
{"isinvoiceapproval", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioApprovalLevelAttributeKeys.@IsInvoiceApproval, "isinvoiceapproval") ?? "isinvoiceapproval"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioApprovalLevel, "folio_u8aqr95gpfeobgqk226s9_d0"));
}
} // ENFolioApprovalLevelEntity

}

