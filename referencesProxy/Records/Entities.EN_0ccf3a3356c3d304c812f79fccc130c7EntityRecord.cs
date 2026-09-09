using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

public sealed partial class ENProcessTypeEntity {
private static readonly ActivitySource activitySource = new(typeof(ENProcessTypeEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ProcessType, _EntityKeyConstants._WorkflowEngineEntityKeys._ProcessTypeAttributeKeys.@Id, "id") ?? "id"},
{"code", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ProcessType, _EntityKeyConstants._WorkflowEngineEntityKeys._ProcessTypeAttributeKeys.@Code, "code") ?? "code"},
{"label", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ProcessType, _EntityKeyConstants._WorkflowEngineEntityKeys._ProcessTypeAttributeKeys.@Label, "label") ?? "label"},
{"order", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ProcessType, _EntityKeyConstants._WorkflowEngineEntityKeys._ProcessTypeAttributeKeys.@Order, "order") ?? "order"},
{"is_active", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ProcessType, _EntityKeyConstants._WorkflowEngineEntityKeys._ProcessTypeAttributeKeys.@Is_Active, "is_active") ?? "is_active"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ProcessType, "proce_62995wmjvxotd5rkl8zui1p2"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("1760d0f4-0a67-4950-83db-6692da4d3a3e");
} // ENProcessTypeEntity

}

