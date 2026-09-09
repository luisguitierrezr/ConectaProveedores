using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENRequisitionStatusHistoryEntity {
private static readonly ActivitySource activitySource = new(typeof(ENRequisitionStatusHistoryEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionStatusHistoryAttributeKeys.@Id, "id") ?? "id"},
{"requisitionid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionStatusHistoryAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid"},
{"requisitionstatusid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionStatusHistoryAttributeKeys.@RequisitionStatusId, "requisitionstatusid") ?? "requisitionstatusid"},
{"timestamp", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionStatusHistoryAttributeKeys.@TimeStamp, "timestamp") ?? "timestamp"},
{"createdby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionStatusHistory, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionStatusHistoryAttributeKeys.@CreatedBy, "createdby") ?? "createdby"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionStatusHistory, "requi_u8aqr95gpfev5lss_hzv8ip3"));
}
} // ENRequisitionStatusHistoryEntity

}

