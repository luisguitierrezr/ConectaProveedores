using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewIcons_ActionGetRequisitionFiles_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("BinaryZIP")]
public byte[] outParamBinaryZIP;
[JsonProperty("ErrorMsg")]
public string outParamErrorMsg;


    public static RESTConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewIcons_ActionGetRequisitionFiles_Outputs FromOutputs(IBehaviorsConfiguration conf, byte[] outParamBinaryZIP, string outParamErrorMsg) {RESTConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewIcons_ActionGetRequisitionFiles_Outputs result = new RESTConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewIcons_ActionGetRequisitionFiles_Outputs();
conf.IncludeBinariesURL = false;
result.outParamBinaryZIP = outParamBinaryZIP;
result.outParamErrorMsg = outParamErrorMsg;
return result;
}


    

    
}
