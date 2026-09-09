using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_Wb_FolioActions_DataActionGetUserInfo_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("IsAllowedCancelFolio")]
public bool? outParamIsAllowedCancelFolio;
[JsonProperty("IsAllowedReassign")]
public bool? outParamIsAllowedReassign;


    public static RESTConectaProveedores_j_FoliosSAE_Wb_FolioActions_DataActionGetUserInfo_Outputs FromOutputs(IBehaviorsConfiguration conf, bool outParamIsAllowedCancelFolio, bool outParamIsAllowedReassign) {RESTConectaProveedores_j_FoliosSAE_Wb_FolioActions_DataActionGetUserInfo_Outputs result = new RESTConectaProveedores_j_FoliosSAE_Wb_FolioActions_DataActionGetUserInfo_Outputs();
result.outParamIsAllowedCancelFolio = (bool?) outParamIsAllowedCancelFolio;
result.outParamIsAllowedReassign = (bool?) outParamIsAllowedReassign;
return result;
}


    public static ConectaProveedores_j_FoliosSAE_Wb_FolioActions_DataActionGetUserInfo_Model ToModel(RESTConectaProveedores_j_FoliosSAE_Wb_FolioActions_DataActionGetUserInfo_Outputs variables) {ConectaProveedores_j_FoliosSAE_Wb_FolioActions_DataActionGetUserInfo_Model result = new ConectaProveedores_j_FoliosSAE_Wb_FolioActions_DataActionGetUserInfo_Model();
result.outParamIsAllowedCancelFolio = variables == null || variables.outParamIsAllowedCancelFolio == null ? false : variables.outParamIsAllowedCancelFolio.Value;
result.outParamIsAllowedReassign = variables == null || variables.outParamIsAllowedReassign == null ? false : variables.outParamIsAllowedReassign.Value;
return result;
}


    public static RESTConectaProveedores_j_FoliosSAE_Wb_FolioActions_DataActionGetUserInfo_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_j_FoliosSAE_Wb_FolioActions_DataActionGetUserInfo_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_j_FoliosSAE_Wb_FolioActions_DataActionGetUserInfo_Outputs result = new RESTConectaProveedores_j_FoliosSAE_Wb_FolioActions_DataActionGetUserInfo_Outputs();
result.outParamIsAllowedCancelFolio = (bool?) screenModel.outParamIsAllowedCancelFolio;
result.outParamIsAllowedReassign = (bool?) screenModel.outParamIsAllowedReassign;
return result;
}

}
