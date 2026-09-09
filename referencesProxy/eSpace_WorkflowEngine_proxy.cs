// Proxy for reference eSpace with name WorkflowEngine and key Hb+dInM0_UeHpMwtKm3org
using System.Diagnostics;
using OutSystems.Application.ManifestGeneration;
using ssConectaProveedores;
using ssConectaProveedores.ReferencesProxy;
namespace ssConectaProveedores.ReferencesProxy {
// empty namespace to ensure the namespace always exists
}
namespace ssConectaProveedores {
/// <summary>
/// Class: RsseSpaceWorkflowEngine
/// </summary>
public partial class RsseSpaceWorkflowEngine {
private static readonly ActivitySource source = new("ssConectaProveedores.RsseSpaceWorkflowEngine");
   public static ObjectKey eSpaceId {
       get {
           return ObjectKey.Parse("1760d0f4-0a67-4950-83db-6692da4d3a3e");
       }
   }
public sealed partial class ENApprovalProcessLevelEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ApprovalProcessLevel, "appro_62995wmjvxo_p3hxvv3nqin4"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("1760d0f4-0a67-4950-83db-6692da4d3a3e");
} // ENApprovalProcessLevelEntity
public sealed partial class ENApprovalProcessEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ApprovalProcess, "appro_62995wmjvxonlx3imudgj4c5"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("1760d0f4-0a67-4950-83db-6692da4d3a3e");
} // ENApprovalProcessEntity
public sealed partial class ENSpecialWorkflowUploadPuestosEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@SpecialWorkflowUploadPuestos, "speci_62995wmjvxoshx0mmg80hfc5"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("1760d0f4-0a67-4950-83db-6692da4d3a3e");
} // ENSpecialWorkflowUploadPuestosEntity
public sealed partial class ENProcessTypeEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ProcessType, "proce_62995wmjvxotd5rkl8zui1p2"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("1760d0f4-0a67-4950-83db-6692da4d3a3e");
} // ENProcessTypeEntity
public sealed partial class ENSpecialWorkflowsEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@SpecialWorkflows, "speci_62995wmjvxoowcfe_5le6og4"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("1760d0f4-0a67-4950-83db-6692da4d3a3e");
} // ENSpecialWorkflowsEntity
public sealed partial class ENApprovalProcessMatrixEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@WorkflowEngine, _EntityKeyConstants._WorkflowEngineEntityKeys.@ApprovalProcessMatrix, "appro_62995wmjvxoxityy3n0l_yb7"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("1760d0f4-0a67-4950-83db-6692da4d3a3e");
} // ENApprovalProcessMatrixEntity

public class DefaultValues {
}
}
}
