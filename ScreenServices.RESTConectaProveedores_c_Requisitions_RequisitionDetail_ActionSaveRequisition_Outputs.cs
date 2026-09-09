using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_c_Requisitions_RequisitionDetail_ActionSaveRequisition_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("o_Output")]
public ssConectaProveedores.RestRecords.RESTST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output;
[JsonProperty("o_RequisitionId")]
public long? outParamo_RequisitionId;
[JsonProperty("o_HasChangedStatus")]
public bool? outParamo_HasChangedStatus;


    public static RESTConectaProveedores_c_Requisitions_RequisitionDetail_ActionSaveRequisition_Outputs FromOutputs(IBehaviorsConfiguration conf, ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output, long outParamo_RequisitionId, bool outParamo_HasChangedStatus) {RESTConectaProveedores_c_Requisitions_RequisitionDetail_ActionSaveRequisition_Outputs result = new RESTConectaProveedores_c_Requisitions_RequisitionDetail_ActionSaveRequisition_Outputs();
conf.IncludeBinariesURL = false;
// Write the needed fields of the record outParamo_Output to the result.outParamo_Output
result.outParamo_Output = new ssConectaProveedores.RestRecords.RESTST_046fb53ebbe142526d95e87ef1ae9711Structure();
result.outParamo_Output.AttrIsSuccess = (bool?) outParamo_Output.ssIsSuccess;
result.outParamo_Output.AttrMessage = outParamo_Output.ssMessage;
// Write optimized result.outParamo_Output.AttrLines
result.outParamo_Output.AttrLines = (int?) 0;
result.outParamo_RequisitionId = (long?) outParamo_RequisitionId;
// Write optimized result.outParamo_HasChangedStatus
result.outParamo_HasChangedStatus = (bool?) false;
return result;
}


    

    
}
