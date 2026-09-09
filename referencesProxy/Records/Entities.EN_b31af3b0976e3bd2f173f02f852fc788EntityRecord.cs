using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

public sealed partial class ENApprovalProcessEntity {
private static readonly ActivitySource activitySource = new(typeof(ENApprovalProcessEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ApprovalProcess, _EntityKeyConstants._WorkflowEngineEntityKeys._ApprovalProcessAttributeKeys.@Id, "id") ?? "id"},
{"processtypeid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ApprovalProcess, _EntityKeyConstants._WorkflowEngineEntityKeys._ApprovalProcessAttributeKeys.@ProcessTypeId, "processtypeid") ?? "processtypeid"},
{"specialworkflowid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ApprovalProcess, _EntityKeyConstants._WorkflowEngineEntityKeys._ApprovalProcessAttributeKeys.@SpecialWorkflowId, "specialworkflowid") ?? "specialworkflowid"},
{"approvalprocesstypeid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ApprovalProcess, _EntityKeyConstants._WorkflowEngineEntityKeys._ApprovalProcessAttributeKeys.@ApprovalProcessTypeId, "approvalprocesstypeid") ?? "approvalprocesstypeid"},
{"regionid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ApprovalProcess, _EntityKeyConstants._WorkflowEngineEntityKeys._ApprovalProcessAttributeKeys.@RegionId, "regionid") ?? "regionid"},
{"accountingregionid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ApprovalProcess, _EntityKeyConstants._WorkflowEngineEntityKeys._ApprovalProcessAttributeKeys.@AccountingRegionId, "accountingregionid") ?? "accountingregionid"},
{"group", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ApprovalProcess, _EntityKeyConstants._WorkflowEngineEntityKeys._ApprovalProcessAttributeKeys.@Group, "group") ?? "group"},
{"code", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ApprovalProcess, _EntityKeyConstants._WorkflowEngineEntityKeys._ApprovalProcessAttributeKeys.@Code, "code") ?? "code"},
{"version", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ApprovalProcess, _EntityKeyConstants._WorkflowEngineEntityKeys._ApprovalProcessAttributeKeys.@Version, "version") ?? "version"},
{"description", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ApprovalProcess, _EntityKeyConstants._WorkflowEngineEntityKeys._ApprovalProcessAttributeKeys.@Description, "description") ?? "description"},
{"isactive", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ApprovalProcess, _EntityKeyConstants._WorkflowEngineEntityKeys._ApprovalProcessAttributeKeys.@IsActive, "isactive") ?? "isactive"},
{"isspecial", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ApprovalProcess, _EntityKeyConstants._WorkflowEngineEntityKeys._ApprovalProcessAttributeKeys.@IsSpecial, "isspecial") ?? "isspecial"},
{"isdonation", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ApprovalProcess, _EntityKeyConstants._WorkflowEngineEntityKeys._ApprovalProcessAttributeKeys.@IsDonation, "isdonation") ?? "isdonation"},
{"iscxpcorporativo_deprec", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ApprovalProcess, _EntityKeyConstants._WorkflowEngineEntityKeys._ApprovalProcessAttributeKeys.@IsCxPCorporativo_DEPREC, "iscxpcorporativo_deprec") ?? "iscxpcorporativo_deprec"},
{"createdby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ApprovalProcess, _EntityKeyConstants._WorkflowEngineEntityKeys._ApprovalProcessAttributeKeys.@CreatedBy, "createdby") ?? "createdby"},
{"createdon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ApprovalProcess, _EntityKeyConstants._WorkflowEngineEntityKeys._ApprovalProcessAttributeKeys.@CreatedOn, "createdon") ?? "createdon"},
{"updatedby", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ApprovalProcess, _EntityKeyConstants._WorkflowEngineEntityKeys._ApprovalProcessAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby"},
{"updatedon", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ApprovalProcess, _EntityKeyConstants._WorkflowEngineEntityKeys._ApprovalProcessAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon"},
{"isselectfirstapprover", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ApprovalProcess, _EntityKeyConstants._WorkflowEngineEntityKeys._ApprovalProcessAttributeKeys.@IsSelectFirstApprover, "isselectfirstapprover") ?? "isselectfirstapprover"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ApprovalProcess, "appro_62995wmjvxonlx3imudgj4c5"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("1760d0f4-0a67-4950-83db-6692da4d3a3e");
} // ENApprovalProcessEntity

}

