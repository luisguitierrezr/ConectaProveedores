using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_PreApprovalFolioDetail_DataActionGetUserData_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("o_Region")]
public string outParamo_Region;
[JsonProperty("o_IsCXP")]
public bool? outParamo_IsCXP;


    public static RESTConectaProveedores_j_FoliosSAE_PreApprovalFolioDetail_DataActionGetUserData_Outputs FromOutputs(IBehaviorsConfiguration conf, string outParamo_Region, bool outParamo_IsCXP) {RESTConectaProveedores_j_FoliosSAE_PreApprovalFolioDetail_DataActionGetUserData_Outputs result = new RESTConectaProveedores_j_FoliosSAE_PreApprovalFolioDetail_DataActionGetUserData_Outputs();
// Write optimized result.outParamo_Region
result.outParamo_Region = "";
result.outParamo_IsCXP = (bool?) outParamo_IsCXP;
return result;
}


    public static ConectaProveedores_j_FoliosSAE_PreApprovalFolioDetail_DataActionGetUserData_Model ToModel(RESTConectaProveedores_j_FoliosSAE_PreApprovalFolioDetail_DataActionGetUserData_Outputs variables) {ConectaProveedores_j_FoliosSAE_PreApprovalFolioDetail_DataActionGetUserData_Model result = new ConectaProveedores_j_FoliosSAE_PreApprovalFolioDetail_DataActionGetUserData_Model();
result.outParamo_Region = variables == null || variables.outParamo_Region == null ? "" : variables.outParamo_Region;
result.outParamo_IsCXP = variables == null || variables.outParamo_IsCXP == null ? false : variables.outParamo_IsCXP.Value;
return result;
}


    public static RESTConectaProveedores_j_FoliosSAE_PreApprovalFolioDetail_DataActionGetUserData_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_j_FoliosSAE_PreApprovalFolioDetail_DataActionGetUserData_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_j_FoliosSAE_PreApprovalFolioDetail_DataActionGetUserData_Outputs result = new RESTConectaProveedores_j_FoliosSAE_PreApprovalFolioDetail_DataActionGetUserData_Outputs();
result.outParamo_Region = screenModel.outParamo_Region;
result.outParamo_IsCXP = (bool?) screenModel.outParamo_IsCXP;
return result;
}

}
