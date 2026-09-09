using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENOrderCostCenterEntity {
private static readonly ActivitySource activitySource = new(typeof(ENOrderCostCenterEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCostCenterAttributeKeys.@Id, "id") ?? "id"},
{"orderid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCostCenterAttributeKeys.@OrderId, "orderid") ?? "orderid"},
{"costcentersap", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderCostCenter, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderCostCenterAttributeKeys.@CostcenterSAP, "costcentersap") ?? "costcentersap"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderCostCenter, "order_u8aqr95gpfe0zefyn7hou0v6"));
}
} // ENOrderCostCenterEntity

}

