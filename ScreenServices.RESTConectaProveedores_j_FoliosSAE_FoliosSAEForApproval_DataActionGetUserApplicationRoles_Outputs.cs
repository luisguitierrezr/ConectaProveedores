using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_FoliosSAEForApproval_DataActionGetUserApplicationRoles_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("UserRolesList")]
public RestList<ssConectaProveedores.RestRecords.RESTST_e39617f0f094a322d4157f34fe424dadStructure> outParamUserRolesList;
[JsonProperty("AppRoleListText")]
public string outParamAppRoleListText;
[JsonProperty("EntraRolesListText")]
public string outParamEntraRolesListText;
[JsonProperty("CanBulkApprove")]
public bool? outParamCanBulkApprove;


    public static RESTConectaProveedores_j_FoliosSAE_FoliosSAEForApproval_DataActionGetUserApplicationRoles_Outputs FromOutputs(IBehaviorsConfiguration conf, RL_97ac86b141c7934fd96d3cf71793066e outParamUserRolesList, string outParamAppRoleListText, string outParamEntraRolesListText, bool outParamCanBulkApprove) {RESTConectaProveedores_j_FoliosSAE_FoliosSAEForApproval_DataActionGetUserApplicationRoles_Outputs result = new RESTConectaProveedores_j_FoliosSAE_FoliosSAEForApproval_DataActionGetUserApplicationRoles_Outputs();
// Write the needed fields of the list outParamUserRolesList to the result.outParamUserRolesList
ssConectaProveedores.RestRecords.RESTST_e39617f0f094a322d4157f34fe424dadStructure tmpoutParamUserRolesListElement;
if(outParamUserRolesList.Empty) {
// Write the needed fields of the record outParamUserRolesList.CurrentRec to the tmpoutParamUserRolesListElement
tmpoutParamUserRolesListElement = new ssConectaProveedores.RestRecords.RESTST_e39617f0f094a322d4157f34fe424dadStructure();
tmpoutParamUserRolesListElement.AttrApplicationRoleId = (long?) outParamUserRolesList.CurrentRec.ssApplicationRoleId;
tmpoutParamUserRolesListElement.AttrRoleName = outParamUserRolesList.CurrentRec.ssRoleName;
// Write optimized tmpoutParamUserRolesListElement.AttrCode
tmpoutParamUserRolesListElement.AttrCode = "";
// Write optimized tmpoutParamUserRolesListElement.AttrIsSubstitute
tmpoutParamUserRolesListElement.AttrIsSubstitute = (bool?) false;
result.outParamUserRolesList = new RestList<ssConectaProveedores.RestRecords.RESTST_e39617f0f094a322d4157f34fe424dadStructure>(new ssConectaProveedores.RestRecords.RESTST_e39617f0f094a322d4157f34fe424dadStructure[] {}, tmpoutParamUserRolesListElement);
} else {
List<ssConectaProveedores.RestRecords.RESTST_e39617f0f094a322d4157f34fe424dadStructure>
 tmpoutParamUserRolesList1List = new List<ssConectaProveedores.RestRecords.RESTST_e39617f0f094a322d4157f34fe424dadStructure>
();
try {outParamUserRolesList.StartIteration();
while (!(outParamUserRolesList.Eof)) {
// Write the needed fields of the record outParamUserRolesList.CurrentRec to the tmpoutParamUserRolesListElement
tmpoutParamUserRolesListElement = new ssConectaProveedores.RestRecords.RESTST_e39617f0f094a322d4157f34fe424dadStructure();
tmpoutParamUserRolesListElement.AttrApplicationRoleId = (long?) outParamUserRolesList.CurrentRec.ssApplicationRoleId;
tmpoutParamUserRolesListElement.AttrRoleName = outParamUserRolesList.CurrentRec.ssRoleName;
// Write optimized tmpoutParamUserRolesListElement.AttrCode
tmpoutParamUserRolesListElement.AttrCode = "";
// Write optimized tmpoutParamUserRolesListElement.AttrIsSubstitute
tmpoutParamUserRolesListElement.AttrIsSubstitute = (bool?) false;
tmpoutParamUserRolesList1List.Add(tmpoutParamUserRolesListElement);
outParamUserRolesList.Advance();
}

} finally {
outParamUserRolesList.EndIteration();
}

result.outParamUserRolesList = new RestList<ssConectaProveedores.RestRecords.RESTST_e39617f0f094a322d4157f34fe424dadStructure>(tmpoutParamUserRolesList1List.ToArray(), default(ssConectaProveedores.RestRecords.RESTST_e39617f0f094a322d4157f34fe424dadStructure));
}

result.outParamAppRoleListText = outParamAppRoleListText;
result.outParamEntraRolesListText = outParamEntraRolesListText;
result.outParamCanBulkApprove = (bool?) outParamCanBulkApprove;
return result;
}


    public static ConectaProveedores_j_FoliosSAE_FoliosSAEForApproval_DataActionGetUserApplicationRoles_Model ToModel(RESTConectaProveedores_j_FoliosSAE_FoliosSAEForApproval_DataActionGetUserApplicationRoles_Outputs variables) {ConectaProveedores_j_FoliosSAE_FoliosSAEForApproval_DataActionGetUserApplicationRoles_Model result = new ConectaProveedores_j_FoliosSAE_FoliosSAEForApproval_DataActionGetUserApplicationRoles_Model();
result.outParamUserRolesList = variables == null ? new RL_97ac86b141c7934fd96d3cf71793066e() : RL_97ac86b141c7934fd96d3cf71793066e.FromRestList(variables.outParamUserRolesList, ssConectaProveedores.RestRecords.RESTST_e39617f0f094a322d4157f34fe424dadStructure.ToStructure);
result.outParamAppRoleListText = variables == null || variables.outParamAppRoleListText == null ? "" : variables.outParamAppRoleListText;
result.outParamEntraRolesListText = variables == null || variables.outParamEntraRolesListText == null ? "" : variables.outParamEntraRolesListText;
result.outParamCanBulkApprove = variables == null || variables.outParamCanBulkApprove == null ? false : variables.outParamCanBulkApprove.Value;
return result;
}


    public static RESTConectaProveedores_j_FoliosSAE_FoliosSAEForApproval_DataActionGetUserApplicationRoles_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_j_FoliosSAE_FoliosSAEForApproval_DataActionGetUserApplicationRoles_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_j_FoliosSAE_FoliosSAEForApproval_DataActionGetUserApplicationRoles_Outputs result = new RESTConectaProveedores_j_FoliosSAE_FoliosSAEForApproval_DataActionGetUserApplicationRoles_Outputs();
result.outParamUserRolesList = screenModel.outParamUserRolesList.ToRestList<ssConectaProveedores.RestRecords.RESTST_e39617f0f094a322d4157f34fe424dadStructure>(ssConectaProveedores.RestRecords.RESTST_e39617f0f094a322d4157f34fe424dadStructure.FromStructureDelegate(conf));
result.outParamAppRoleListText = screenModel.outParamAppRoleListText;
result.outParamEntraRolesListText = screenModel.outParamEntraRolesListText;
result.outParamCanBulkApprove = (bool?) screenModel.outParamCanBulkApprove;
return result;
}

}
