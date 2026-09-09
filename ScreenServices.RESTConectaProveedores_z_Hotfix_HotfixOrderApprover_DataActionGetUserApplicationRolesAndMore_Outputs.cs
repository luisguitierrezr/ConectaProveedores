using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_z_Hotfix_HotfixOrderApprover_DataActionGetUserApplicationRolesAndMore_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("UserRolesList")]
public RestList<ssConectaProveedores.RestRecords.RESTST_e39617f0f094a322d4157f34fe424dadStructure> outParamUserRolesList;
[JsonProperty("AppRolesListText")]
public string outParamAppRolesListText;
[JsonProperty("IsCorporativoCxP")]
public bool? outParamIsCorporativoCxP;
[JsonProperty("o_CanUploadInvoices")]
public bool? outParamo_CanUploadInvoices;
[JsonProperty("TelcelDirectionsListText")]
public string outParamTelcelDirectionsListText;
[JsonProperty("CorporativoRegionId")]
public long? outParamCorporativoRegionId;
[JsonProperty("UserRegion")]
public long? outParamUserRegion;


    public static RESTConectaProveedores_z_Hotfix_HotfixOrderApprover_DataActionGetUserApplicationRolesAndMore_Outputs FromOutputs(IBehaviorsConfiguration conf, RL_97ac86b141c7934fd96d3cf71793066e outParamUserRolesList, string outParamAppRolesListText, bool outParamIsCorporativoCxP, bool outParamo_CanUploadInvoices, string outParamTelcelDirectionsListText, long outParamCorporativoRegionId, long outParamUserRegion) {RESTConectaProveedores_z_Hotfix_HotfixOrderApprover_DataActionGetUserApplicationRolesAndMore_Outputs result = new RESTConectaProveedores_z_Hotfix_HotfixOrderApprover_DataActionGetUserApplicationRolesAndMore_Outputs();
// Write optimized result.outParamUserRolesList
result.outParamUserRolesList = new RL_97ac86b141c7934fd96d3cf71793066e().ToRestList<ssConectaProveedores.RestRecords.RESTST_e39617f0f094a322d4157f34fe424dadStructure>(ssConectaProveedores.RestRecords.RESTST_e39617f0f094a322d4157f34fe424dadStructure.FromStructureDelegate(conf));
// Write optimized result.outParamAppRolesListText
result.outParamAppRolesListText = "";
// Write optimized result.outParamIsCorporativoCxP
result.outParamIsCorporativoCxP = (bool?) false;
// Write optimized result.outParamo_CanUploadInvoices
result.outParamo_CanUploadInvoices = (bool?) false;
// Write optimized result.outParamTelcelDirectionsListText
result.outParamTelcelDirectionsListText = "";
// Write optimized result.outParamCorporativoRegionId
result.outParamCorporativoRegionId = (long?) 0L;
// Write optimized result.outParamUserRegion
result.outParamUserRegion = (long?) 0L;
return result;
}


    public static ConectaProveedores_z_Hotfix_HotfixOrderApprover_DataActionGetUserApplicationRolesAndMore_Model ToModel(RESTConectaProveedores_z_Hotfix_HotfixOrderApprover_DataActionGetUserApplicationRolesAndMore_Outputs variables) {ConectaProveedores_z_Hotfix_HotfixOrderApprover_DataActionGetUserApplicationRolesAndMore_Model result = new ConectaProveedores_z_Hotfix_HotfixOrderApprover_DataActionGetUserApplicationRolesAndMore_Model();
result.outParamUserRolesList = variables == null ? new RL_97ac86b141c7934fd96d3cf71793066e() : RL_97ac86b141c7934fd96d3cf71793066e.FromRestList(variables.outParamUserRolesList, ssConectaProveedores.RestRecords.RESTST_e39617f0f094a322d4157f34fe424dadStructure.ToStructure);
result.outParamAppRolesListText = variables == null || variables.outParamAppRolesListText == null ? "" : variables.outParamAppRolesListText;
result.outParamIsCorporativoCxP = variables == null || variables.outParamIsCorporativoCxP == null ? false : variables.outParamIsCorporativoCxP.Value;
result.outParamo_CanUploadInvoices = variables == null || variables.outParamo_CanUploadInvoices == null ? false : variables.outParamo_CanUploadInvoices.Value;
result.outParamTelcelDirectionsListText = variables == null || variables.outParamTelcelDirectionsListText == null ? "" : variables.outParamTelcelDirectionsListText;
result.outParamCorporativoRegionId = variables == null || variables.outParamCorporativoRegionId == null ? 0L : variables.outParamCorporativoRegionId.Value;
result.outParamUserRegion = variables == null || variables.outParamUserRegion == null ? 0L : variables.outParamUserRegion.Value;
return result;
}


    public static RESTConectaProveedores_z_Hotfix_HotfixOrderApprover_DataActionGetUserApplicationRolesAndMore_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_z_Hotfix_HotfixOrderApprover_DataActionGetUserApplicationRolesAndMore_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_z_Hotfix_HotfixOrderApprover_DataActionGetUserApplicationRolesAndMore_Outputs result = new RESTConectaProveedores_z_Hotfix_HotfixOrderApprover_DataActionGetUserApplicationRolesAndMore_Outputs();
result.outParamUserRolesList = screenModel.outParamUserRolesList.ToRestList<ssConectaProveedores.RestRecords.RESTST_e39617f0f094a322d4157f34fe424dadStructure>(ssConectaProveedores.RestRecords.RESTST_e39617f0f094a322d4157f34fe424dadStructure.FromStructureDelegate(conf));
result.outParamAppRolesListText = screenModel.outParamAppRolesListText;
result.outParamIsCorporativoCxP = (bool?) screenModel.outParamIsCorporativoCxP;
result.outParamo_CanUploadInvoices = (bool?) screenModel.outParamo_CanUploadInvoices;
result.outParamTelcelDirectionsListText = screenModel.outParamTelcelDirectionsListText;
result.outParamCorporativoRegionId = (long?) screenModel.outParamCorporativoRegionId;
result.outParamUserRegion = (long?) screenModel.outParamUserRegion;
return result;
}

}
