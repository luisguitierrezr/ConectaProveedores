using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_NewMassiveFolioSAE_ActionFolioMassCreate_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("ErrorMsg")]
public string outParamErrorMsg;


    public static RESTConectaProveedores_j_FoliosSAE_NewMassiveFolioSAE_ActionFolioMassCreate_Outputs FromOutputs(IBehaviorsConfiguration conf, string outParamErrorMsg) {RESTConectaProveedores_j_FoliosSAE_NewMassiveFolioSAE_ActionFolioMassCreate_Outputs result = new RESTConectaProveedores_j_FoliosSAE_NewMassiveFolioSAE_ActionFolioMassCreate_Outputs();
conf.IncludeBinariesURL = false;
result.outParamErrorMsg = outParamErrorMsg;
return result;
}


    

    
}
