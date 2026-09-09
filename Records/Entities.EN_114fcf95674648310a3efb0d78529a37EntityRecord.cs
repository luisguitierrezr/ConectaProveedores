using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENRequisitionCostCenterEntity {
private static readonly ActivitySource activitySource = new(typeof(ENRequisitionCostCenterEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCostCenterAttributeKeys.@Id, "id") ?? "id"},
{"requisitionid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCostCenterAttributeKeys.@RequisitionId, "requisitionid") ?? "requisitionid"},
{"costcentersap", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionCostCenterAttributeKeys.@CostcenterSAP, "costcentersap") ?? "costcentersap"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@RequisitionCostCenter, "requi_u8aqr95gpfewe6vne931deh2"));
}
} // ENRequisitionCostCenterEntity

}

