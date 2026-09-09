using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_ActionString_Join_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("Text")]
public string outParamText;


    public static RESTConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_ActionString_Join_Outputs FromOutputs(IBehaviorsConfiguration conf, string outParamText) {RESTConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_ActionString_Join_Outputs result = new RESTConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_ActionString_Join_Outputs();
conf.IncludeBinariesURL = false;
result.outParamText = outParamText;
return result;
}


    

    
}
