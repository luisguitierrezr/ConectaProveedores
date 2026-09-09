using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENInvoiceApprovalLevelEntity {
private static readonly ActivitySource activitySource = new(typeof(ENInvoiceApprovalLevelEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@Id, "id") ?? "id"},
{"invoiceapprovalid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@InvoiceApprovalId, "invoiceapprovalid") ?? "invoiceapprovalid"},
{"levelnumber", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@LevelNumber, "levelnumber") ?? "levelnumber"},
{"assignedto", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@AssignedTo, "assignedto") ?? "assignedto"},
{"applicationroleid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@ApplicationRoleId, "applicationroleid") ?? "applicationroleid"},
{"entrajobtitle", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@EntraJobTitle, "entrajobtitle") ?? "entrajobtitle"},
{"departmentid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@DepartmentId, "departmentid") ?? "departmentid"},
{"managementid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@ManagementId, "managementid") ?? "managementid"},
{"subdirectionid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@SubdirectionId, "subdirectionid") ?? "subdirectionid"},
{"entraroleid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@EntraRoleId, "entraroleid") ?? "entraroleid"},
{"approvalstatusid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@ApprovalStatusId, "approvalstatusid") ?? "approvalstatusid"},
{"canbefirstapprover", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@CanBeFirstApprover, "canbefirstapprover") ?? "canbefirstapprover"},
{"selectsnextapprover", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@SelectsNextApprover, "selectsnextapprover") ?? "selectsnextapprover"},
{"selectsfirstapprover", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@SelectsFirstApprover, "selectsfirstapprover") ?? "selectsfirstapprover"},
{"isaccounting", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@IsAccounting, "isaccounting") ?? "isaccounting"},
{"isstartaccounting", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@IsStartAccounting, "isstartaccounting") ?? "isstartaccounting"},
{"approvedby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@ApprovedBy, "approvedby") ?? "approvedby"},
{"approvedon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@ApprovedOn, "approvedon") ?? "approvedon"},
{"requesttomodifyby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@RequestToModifyBy, "requesttomodifyby") ?? "requesttomodifyby"},
{"requesttomodifyon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@RequestToModifyOn, "requesttomodifyon") ?? "requesttomodifyon"},
{"canceledby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@CanceledBy, "canceledby") ?? "canceledby"},
{"canceledon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@CanceledOn, "canceledon") ?? "canceledon"},
{"needscontract_deprec", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@NeedsContract_DEPREC, "needscontract_deprec") ?? "needscontract_deprec"},
{"isreassigned", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@IsReassigned, "isreassigned") ?? "isreassigned"},
{"issubstitutefor", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceApprovalLevelAttributeKeys.@IsSubstituteFor, "issubstitutefor") ?? "issubstitutefor"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceApprovalLevel, "invoi_u8aqr95gpfet8xs6qv6yhpj6"));
}
} // ENInvoiceApprovalLevelEntity

}

