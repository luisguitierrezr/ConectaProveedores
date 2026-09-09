using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_a_Main_Homepage_DataActionGetUserApplicationRolesAndMore_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("UserRolesList")]
public RestList<ssConectaProveedores.RestRecords.RESTST_e39617f0f094a322d4157f34fe424dadStructure> outParamUserRolesList;
[JsonProperty("IsCorporativoCxP")]
public bool? outParamIsCorporativoCxP;
[JsonProperty("AppRolesListText")]
public string outParamAppRolesListText;
[JsonProperty("TelcelDirectionsListText")]
public string outParamTelcelDirectionsListText;
[JsonProperty("IsAreaCxP")]
public bool? outParamIsAreaCxP;
[JsonProperty("IsActiveDEV_Dashboard")]
public bool? outParamIsActiveDEV_Dashboard;


    public static RESTConectaProveedores_a_Main_Homepage_DataActionGetUserApplicationRolesAndMore_Outputs FromOutputs(IBehaviorsConfiguration conf, RL_97ac86b141c7934fd96d3cf71793066e outParamUserRolesList, bool outParamIsCorporativoCxP, string outParamAppRolesListText, string outParamTelcelDirectionsListText, bool outParamIsAreaCxP, bool outParamIsActiveDEV_Dashboard) {RESTConectaProveedores_a_Main_Homepage_DataActionGetUserApplicationRolesAndMore_Outputs result = new RESTConectaProveedores_a_Main_Homepage_DataActionGetUserApplicationRolesAndMore_Outputs();
// Write optimized result.outParamUserRolesList
result.outParamUserRolesList = new RL_97ac86b141c7934fd96d3cf71793066e().ToRestList<ssConectaProveedores.RestRecords.RESTST_e39617f0f094a322d4157f34fe424dadStructure>(ssConectaProveedores.RestRecords.RESTST_e39617f0f094a322d4157f34fe424dadStructure.FromStructureDelegate(conf));
// Write optimized result.outParamIsCorporativoCxP
result.outParamIsCorporativoCxP = (bool?) false;
result.outParamAppRolesListText = outParamAppRolesListText;
// Write optimized result.outParamTelcelDirectionsListText
result.outParamTelcelDirectionsListText = "";
result.outParamIsAreaCxP = (bool?) outParamIsAreaCxP;
result.outParamIsActiveDEV_Dashboard = (bool?) outParamIsActiveDEV_Dashboard;
return result;
}


    public static ConectaProveedores_a_Main_Homepage_DataActionGetUserApplicationRolesAndMore_Model ToModel(RESTConectaProveedores_a_Main_Homepage_DataActionGetUserApplicationRolesAndMore_Outputs variables) {ConectaProveedores_a_Main_Homepage_DataActionGetUserApplicationRolesAndMore_Model result = new ConectaProveedores_a_Main_Homepage_DataActionGetUserApplicationRolesAndMore_Model();
result.outParamUserRolesList = variables == null ? new RL_97ac86b141c7934fd96d3cf71793066e() : RL_97ac86b141c7934fd96d3cf71793066e.FromRestList(variables.outParamUserRolesList, ssConectaProveedores.RestRecords.RESTST_e39617f0f094a322d4157f34fe424dadStructure.ToStructure);
result.outParamIsCorporativoCxP = variables == null || variables.outParamIsCorporativoCxP == null ? false : variables.outParamIsCorporativoCxP.Value;
result.outParamAppRolesListText = variables == null || variables.outParamAppRolesListText == null ? "" : variables.outParamAppRolesListText;
result.outParamTelcelDirectionsListText = variables == null || variables.outParamTelcelDirectionsListText == null ? "" : variables.outParamTelcelDirectionsListText;
result.outParamIsAreaCxP = variables == null || variables.outParamIsAreaCxP == null ? false : variables.outParamIsAreaCxP.Value;
result.outParamIsActiveDEV_Dashboard = variables == null || variables.outParamIsActiveDEV_Dashboard == null ? false : variables.outParamIsActiveDEV_Dashboard.Value;
return result;
}


    public static RESTConectaProveedores_a_Main_Homepage_DataActionGetUserApplicationRolesAndMore_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_a_Main_Homepage_DataActionGetUserApplicationRolesAndMore_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_a_Main_Homepage_DataActionGetUserApplicationRolesAndMore_Outputs result = new RESTConectaProveedores_a_Main_Homepage_DataActionGetUserApplicationRolesAndMore_Outputs();
result.outParamUserRolesList = screenModel.outParamUserRolesList.ToRestList<ssConectaProveedores.RestRecords.RESTST_e39617f0f094a322d4157f34fe424dadStructure>(ssConectaProveedores.RestRecords.RESTST_e39617f0f094a322d4157f34fe424dadStructure.FromStructureDelegate(conf));
result.outParamIsCorporativoCxP = (bool?) screenModel.outParamIsCorporativoCxP;
result.outParamAppRolesListText = screenModel.outParamAppRolesListText;
result.outParamTelcelDirectionsListText = screenModel.outParamTelcelDirectionsListText;
result.outParamIsAreaCxP = (bool?) screenModel.outParamIsAreaCxP;
result.outParamIsActiveDEV_Dashboard = (bool?) screenModel.outParamIsActiveDEV_Dashboard;
return result;
}

}
