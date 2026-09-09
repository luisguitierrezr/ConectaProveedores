using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_FoliosSAEforReassignment_ActionFolioReassignGeneralRevoke_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("ErrorMessage")]
public string outParamErrorMessage;


    public static RESTConectaProveedores_j_FoliosSAE_FoliosSAEforReassignment_ActionFolioReassignGeneralRevoke_Outputs FromOutputs(IBehaviorsConfiguration conf, string outParamErrorMessage) {RESTConectaProveedores_j_FoliosSAE_FoliosSAEforReassignment_ActionFolioReassignGeneralRevoke_Outputs result = new RESTConectaProveedores_j_FoliosSAE_FoliosSAEforReassignment_ActionFolioReassignGeneralRevoke_Outputs();
conf.IncludeBinariesURL = false;
result.outParamErrorMessage = outParamErrorMessage;
return result;
}


    

    
}
