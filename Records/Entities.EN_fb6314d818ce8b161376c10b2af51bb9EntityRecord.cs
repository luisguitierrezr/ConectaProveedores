using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENApprovalProcessMatrixEntity {
private static readonly ActivitySource activitySource = new(typeof(ENApprovalProcessMatrixEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ApprovalProcessMatrix, _EntityKeyConstants._WorkflowEngineEntityKeys._ApprovalProcessMatrixAttributeKeys.@Id, "id") ?? "id"},
{"processtypeid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ApprovalProcessMatrix, _EntityKeyConstants._WorkflowEngineEntityKeys._ApprovalProcessMatrixAttributeKeys.@ProcessTypeId, "processtypeid") ?? "processtypeid"},
{"region", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ApprovalProcessMatrix, _EntityKeyConstants._WorkflowEngineEntityKeys._ApprovalProcessMatrixAttributeKeys.@Region, "region") ?? "region"},
{"area", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ApprovalProcessMatrix, _EntityKeyConstants._WorkflowEngineEntityKeys._ApprovalProcessMatrixAttributeKeys.@Area, "area") ?? "area"},
{"telceldirection", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ApprovalProcessMatrix, _EntityKeyConstants._WorkflowEngineEntityKeys._ApprovalProcessMatrixAttributeKeys.@TelcelDirection, "telceldirection") ?? "telceldirection"},
{"approvalprocessid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ApprovalProcessMatrix, _EntityKeyConstants._WorkflowEngineEntityKeys._ApprovalProcessMatrixAttributeKeys.@ApprovalProcessId, "approvalprocessid") ?? "approvalprocessid"},
{"isactive", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ApprovalProcessMatrix, _EntityKeyConstants._WorkflowEngineEntityKeys._ApprovalProcessMatrixAttributeKeys.@IsActive, "isactive") ?? "isactive"},
{"isdonation_deprec", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ApprovalProcessMatrix, _EntityKeyConstants._WorkflowEngineEntityKeys._ApprovalProcessMatrixAttributeKeys.@IsDonation_DEPREC, "isdonation_deprec") ?? "isdonation_deprec"},
{"createdby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ApprovalProcessMatrix, _EntityKeyConstants._WorkflowEngineEntityKeys._ApprovalProcessMatrixAttributeKeys.@CreatedBy, "createdby") ?? "createdby"},
{"createdon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ApprovalProcessMatrix, _EntityKeyConstants._WorkflowEngineEntityKeys._ApprovalProcessMatrixAttributeKeys.@CreatedOn, "createdon") ?? "createdon"},
{"updatedby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ApprovalProcessMatrix, _EntityKeyConstants._WorkflowEngineEntityKeys._ApprovalProcessMatrixAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby"},
{"updatedon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ApprovalProcessMatrix, _EntityKeyConstants._WorkflowEngineEntityKeys._ApprovalProcessMatrixAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ApprovalProcessMatrix, "appro_62995wmjvxoxityy3n0l_yb7"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("1760d0f4-0a67-4950-83db-6692da4d3a3e");
} // ENApprovalProcessMatrixEntity

}

