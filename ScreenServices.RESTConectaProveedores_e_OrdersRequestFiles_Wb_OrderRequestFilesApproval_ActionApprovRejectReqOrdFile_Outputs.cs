using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_e_OrdersRequestFiles_Wb_OrderRequestFilesApproval_ActionApprovRejectReqOrdFile_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("Output")]
public ssConectaProveedores.RestRecords.RESTST_046fb53ebbe142526d95e87ef1ae9711Structure outParamOutput;


    public static RESTConectaProveedores_e_OrdersRequestFiles_Wb_OrderRequestFilesApproval_ActionApprovRejectReqOrdFile_Outputs FromOutputs(IBehaviorsConfiguration conf, ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamOutput) {RESTConectaProveedores_e_OrdersRequestFiles_Wb_OrderRequestFilesApproval_ActionApprovRejectReqOrdFile_Outputs result = new RESTConectaProveedores_e_OrdersRequestFiles_Wb_OrderRequestFilesApproval_ActionApprovRejectReqOrdFile_Outputs();
conf.IncludeBinariesURL = false;
// Write the needed fields of the record outParamOutput to the result.outParamOutput
result.outParamOutput = new ssConectaProveedores.RestRecords.RESTST_046fb53ebbe142526d95e87ef1ae9711Structure();
result.outParamOutput.AttrIsSuccess = (bool?) outParamOutput.ssIsSuccess;
result.outParamOutput.AttrMessage = outParamOutput.ssMessage;
// Write optimized result.outParamOutput.AttrLines
result.outParamOutput.AttrLines = (int?) 0;
return result;
}


    

    
}
