using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENRequisitionApprovalEntity {
private static readonly ActivitySource activitySource = new(typeof(ENRequisitionApprovalEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@Id, "id") ?? "id"},
{"requisitionid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid"},
{"aprovalprocessid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@AprovalProcessId, "aprovalprocessid") ?? "aprovalprocessid"},
{"processtypecode", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@ProcessTypeCode, "processtypecode") ?? "processtypecode"},
{"approvalprocessversion", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@ApprovalProcessVersion, "approvalprocessversion") ?? "approvalprocessversion"},
{"currentlevel", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@CurrentLevel, "currentlevel") ?? "currentlevel"},
{"maxlevel", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@MaxLevel, "maxlevel") ?? "maxlevel"},
{"startedon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@StartedOn, "startedon") ?? "startedon"},
{"finishedon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@FinishedOn, "finishedon") ?? "finishedon"},
{"hasstartedaccounting", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionApprovalAttributeKeys.@HasStartedAccounting, "hasstartedaccounting") ?? "hasstartedaccounting"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionApproval, "requi_u8aqr95gpfetqccwg1rjk4o1"));
}
} // ENRequisitionApprovalEntity

}

