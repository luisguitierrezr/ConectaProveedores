using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewIcons_ActionCheckFiles_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("O_ErrorMessage")]
public string outParamO_ErrorMessage;


    public static RESTConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewIcons_ActionCheckFiles_Outputs FromOutputs(IBehaviorsConfiguration conf, string outParamO_ErrorMessage) {RESTConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewIcons_ActionCheckFiles_Outputs result = new RESTConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewIcons_ActionCheckFiles_Outputs();
conf.IncludeBinariesURL = false;
result.outParamO_ErrorMessage = outParamO_ErrorMessage;
return result;
}


    

    
}
