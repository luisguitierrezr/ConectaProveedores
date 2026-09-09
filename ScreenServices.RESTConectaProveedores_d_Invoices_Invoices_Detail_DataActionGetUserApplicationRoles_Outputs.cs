using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_d_Invoices_Invoices_Detail_DataActionGetUserApplicationRoles_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("UserRolesList")]
public RestList<ssConectaProveedores.RestRecords.RESTST_e39617f0f094a322d4157f34fe424dadStructure> outParamUserRolesList;
[JsonProperty("ListText")]
public string outParamListText;
[JsonProperty("IsCorporativoCxP")]
public bool? outParamIsCorporativoCxP;


    public static RESTConectaProveedores_d_Invoices_Invoices_Detail_DataActionGetUserApplicationRoles_Outputs FromOutputs(IBehaviorsConfiguration conf, RL_97ac86b141c7934fd96d3cf71793066e outParamUserRolesList, string outParamListText, bool outParamIsCorporativoCxP) {RESTConectaProveedores_d_Invoices_Invoices_Detail_DataActionGetUserApplicationRoles_Outputs result = new RESTConectaProveedores_d_Invoices_Invoices_Detail_DataActionGetUserApplicationRoles_Outputs();
// Write optimized result.outParamUserRolesList
result.outParamUserRolesList = new RL_97ac86b141c7934fd96d3cf71793066e().ToRestList<ssConectaProveedores.RestRecords.RESTST_e39617f0f094a322d4157f34fe424dadStructure>(ssConectaProveedores.RestRecords.RESTST_e39617f0f094a322d4157f34fe424dadStructure.FromStructureDelegate(conf));
result.outParamListText = outParamListText;
result.outParamIsCorporativoCxP = (bool?) outParamIsCorporativoCxP;
return result;
}


    public static ConectaProveedores_d_Invoices_Invoices_Detail_DataActionGetUserApplicationRoles_Model ToModel(RESTConectaProveedores_d_Invoices_Invoices_Detail_DataActionGetUserApplicationRoles_Outputs variables) {ConectaProveedores_d_Invoices_Invoices_Detail_DataActionGetUserApplicationRoles_Model result = new ConectaProveedores_d_Invoices_Invoices_Detail_DataActionGetUserApplicationRoles_Model();
result.outParamUserRolesList = variables == null ? new RL_97ac86b141c7934fd96d3cf71793066e() : RL_97ac86b141c7934fd96d3cf71793066e.FromRestList(variables.outParamUserRolesList, ssConectaProveedores.RestRecords.RESTST_e39617f0f094a322d4157f34fe424dadStructure.ToStructure);
result.outParamListText = variables == null || variables.outParamListText == null ? "" : variables.outParamListText;
result.outParamIsCorporativoCxP = variables == null || variables.outParamIsCorporativoCxP == null ? false : variables.outParamIsCorporativoCxP.Value;
return result;
}


    public static RESTConectaProveedores_d_Invoices_Invoices_Detail_DataActionGetUserApplicationRoles_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_d_Invoices_Invoices_Detail_DataActionGetUserApplicationRoles_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_d_Invoices_Invoices_Detail_DataActionGetUserApplicationRoles_Outputs result = new RESTConectaProveedores_d_Invoices_Invoices_Detail_DataActionGetUserApplicationRoles_Outputs();
result.outParamUserRolesList = screenModel.outParamUserRolesList.ToRestList<ssConectaProveedores.RestRecords.RESTST_e39617f0f094a322d4157f34fe424dadStructure>(ssConectaProveedores.RestRecords.RESTST_e39617f0f094a322d4157f34fe424dadStructure.FromStructureDelegate(conf));
result.outParamListText = screenModel.outParamListText;
result.outParamIsCorporativoCxP = (bool?) screenModel.outParamIsCorporativoCxP;
return result;
}

}
