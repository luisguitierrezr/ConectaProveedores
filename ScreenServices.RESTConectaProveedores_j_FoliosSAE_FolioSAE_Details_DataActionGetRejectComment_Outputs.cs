using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_FolioSAE_Details_DataActionGetRejectComment_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("RejectCommentText")]
public string outParamRejectCommentText;


    public static RESTConectaProveedores_j_FoliosSAE_FolioSAE_Details_DataActionGetRejectComment_Outputs FromOutputs(IBehaviorsConfiguration conf, string outParamRejectCommentText) {RESTConectaProveedores_j_FoliosSAE_FolioSAE_Details_DataActionGetRejectComment_Outputs result = new RESTConectaProveedores_j_FoliosSAE_FolioSAE_Details_DataActionGetRejectComment_Outputs();
// Write optimized result.outParamRejectCommentText
result.outParamRejectCommentText = "";
return result;
}


    public static ConectaProveedores_j_FoliosSAE_FolioSAE_Details_DataActionGetRejectComment_Model ToModel(RESTConectaProveedores_j_FoliosSAE_FolioSAE_Details_DataActionGetRejectComment_Outputs variables) {ConectaProveedores_j_FoliosSAE_FolioSAE_Details_DataActionGetRejectComment_Model result = new ConectaProveedores_j_FoliosSAE_FolioSAE_Details_DataActionGetRejectComment_Model();
result.outParamRejectCommentText = variables == null || variables.outParamRejectCommentText == null ? "" : variables.outParamRejectCommentText;
return result;
}


    public static RESTConectaProveedores_j_FoliosSAE_FolioSAE_Details_DataActionGetRejectComment_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_j_FoliosSAE_FolioSAE_Details_DataActionGetRejectComment_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_j_FoliosSAE_FolioSAE_Details_DataActionGetRejectComment_Outputs result = new RESTConectaProveedores_j_FoliosSAE_FolioSAE_Details_DataActionGetRejectComment_Outputs();
result.outParamRejectCommentText = screenModel.outParamRejectCommentText;
return result;
}

}
