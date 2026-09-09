using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENReassignmentsEntity {
private static readonly ActivitySource activitySource = new(typeof(ENReassignmentsEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@Id, "id") ?? "id"},
{"sourceuserid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@SourceUserId, "sourceuserid") ?? "sourceuserid"},
{"targetuserid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@TargetUserId, "targetuserid") ?? "targetuserid"},
{"requisitionid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid"},
{"requisitionapprovallevelid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@RequisitionApprovalLevelId, "requisitionapprovallevelid") ?? "requisitionapprovallevelid"},
{"invoiceid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@InvoiceId, "invoiceid") ?? "invoiceid"},
{"invoiceapprovallevelid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@InvoiceApprovalLevelId, "invoiceapprovallevelid") ?? "invoiceapprovallevelid"},
{"reason", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@Reason, "reason") ?? "reason"},
{"createdby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@CreatedBy, "createdby") ?? "createdby"},
{"createdon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@CreatedOn, "createdon") ?? "createdon"},
{"revokedby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@RevokedBy, "revokedby") ?? "revokedby"},
{"revokedon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@RevokedOn, "revokedon") ?? "revokedon"},
{"folioid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@FolioId, "folioid") ?? "folioid"},
{"folioapprovallevelid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@FolioApprovalLevelId, "folioapprovallevelid") ?? "folioapprovallevelid"},
{"sourceentraroleid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@SourceEntraRoleId, "sourceentraroleid") ?? "sourceentraroleid"},
{"targetentraroleid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@TargetEntraRoleId, "targetentraroleid") ?? "targetentraroleid"},
{"isfolioapprovallevelinvoice", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, _EntityKeyConstants._ConectaProveedoresEntityKeys._ReassignmentsAttributeKeys.@IsFolioApprovalLevelInvoice, "isfolioapprovallevelinvoice") ?? "isfolioapprovallevelinvoice"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Reassignments, "reass_u8aqr95gpfer_cr1gzo81443"));
}
} // ENReassignmentsEntity

}

