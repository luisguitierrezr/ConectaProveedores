using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENSpecialWorkflowUploadPuestosEntity {
private static readonly ActivitySource activitySource = new(typeof(ENSpecialWorkflowUploadPuestosEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@SpecialWorkflowUploadPuestos, _EntityKeyConstants._WorkflowEngineEntityKeys._SpecialWorkflowUploadPuestosAttributeKeys.@Id, "id") ?? "id"},
{"specialworkflowid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@SpecialWorkflowUploadPuestos, _EntityKeyConstants._WorkflowEngineEntityKeys._SpecialWorkflowUploadPuestosAttributeKeys.@SpecialWorkflowId, "specialworkflowid") ?? "specialworkflowid"},
{"entraroleid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@SpecialWorkflowUploadPuestos, _EntityKeyConstants._WorkflowEngineEntityKeys._SpecialWorkflowUploadPuestosAttributeKeys.@EntraRoleId, "entraroleid") ?? "entraroleid"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@SpecialWorkflowUploadPuestos, "speci_62995wmjvxoshx0mmg80hfc5"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("1760d0f4-0a67-4950-83db-6692da4d3a3e");
} // ENSpecialWorkflowUploadPuestosEntity

}

