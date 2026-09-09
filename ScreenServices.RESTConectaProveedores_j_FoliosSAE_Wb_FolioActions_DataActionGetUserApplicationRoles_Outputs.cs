using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_Wb_FolioActions_DataActionGetUserApplicationRoles_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("UserRolesList")]
public RestList<ssConectaProveedores.RestRecords.RESTST_e39617f0f094a322d4157f34fe424dadStructure> outParamUserRolesList;
[JsonProperty("AppRoleListText")]
public string outParamAppRoleListText;
[JsonProperty("EntraRolesListText")]
public string outParamEntraRolesListText;


    public static RESTConectaProveedores_j_FoliosSAE_Wb_FolioActions_DataActionGetUserApplicationRoles_Outputs FromOutputs(IBehaviorsConfiguration conf, RL_97ac86b141c7934fd96d3cf71793066e outParamUserRolesList, string outParamAppRoleListText, string outParamEntraRolesListText) {RESTConectaProveedores_j_FoliosSAE_Wb_FolioActions_DataActionGetUserApplicationRoles_Outputs result = new RESTConectaProveedores_j_FoliosSAE_Wb_FolioActions_DataActionGetUserApplicationRoles_Outputs();
// Write optimized result.outParamUserRolesList
result.outParamUserRolesList = new RL_97ac86b141c7934fd96d3cf71793066e().ToRestList<ssConectaProveedores.RestRecords.RESTST_e39617f0f094a322d4157f34fe424dadStructure>(ssConectaProveedores.RestRecords.RESTST_e39617f0f094a322d4157f34fe424dadStructure.FromStructureDelegate(conf));
// Write optimized result.outParamAppRoleListText
result.outParamAppRoleListText = "";
result.outParamEntraRolesListText = outParamEntraRolesListText;
return result;
}


    public static ConectaProveedores_j_FoliosSAE_Wb_FolioActions_DataActionGetUserApplicationRoles_Model ToModel(RESTConectaProveedores_j_FoliosSAE_Wb_FolioActions_DataActionGetUserApplicationRoles_Outputs variables) {ConectaProveedores_j_FoliosSAE_Wb_FolioActions_DataActionGetUserApplicationRoles_Model result = new ConectaProveedores_j_FoliosSAE_Wb_FolioActions_DataActionGetUserApplicationRoles_Model();
result.outParamUserRolesList = variables == null ? new RL_97ac86b141c7934fd96d3cf71793066e() : RL_97ac86b141c7934fd96d3cf71793066e.FromRestList(variables.outParamUserRolesList, ssConectaProveedores.RestRecords.RESTST_e39617f0f094a322d4157f34fe424dadStructure.ToStructure);
result.outParamAppRoleListText = variables == null || variables.outParamAppRoleListText == null ? "" : variables.outParamAppRoleListText;
result.outParamEntraRolesListText = variables == null || variables.outParamEntraRolesListText == null ? "" : variables.outParamEntraRolesListText;
return result;
}


    public static RESTConectaProveedores_j_FoliosSAE_Wb_FolioActions_DataActionGetUserApplicationRoles_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_j_FoliosSAE_Wb_FolioActions_DataActionGetUserApplicationRoles_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_j_FoliosSAE_Wb_FolioActions_DataActionGetUserApplicationRoles_Outputs result = new RESTConectaProveedores_j_FoliosSAE_Wb_FolioActions_DataActionGetUserApplicationRoles_Outputs();
result.outParamUserRolesList = screenModel.outParamUserRolesList.ToRestList<ssConectaProveedores.RestRecords.RESTST_e39617f0f094a322d4157f34fe424dadStructure>(ssConectaProveedores.RestRecords.RESTST_e39617f0f094a322d4157f34fe424dadStructure.FromStructureDelegate(conf));
result.outParamAppRoleListText = screenModel.outParamAppRoleListText;
result.outParamEntraRolesListText = screenModel.outParamEntraRolesListText;
return result;
}

}
