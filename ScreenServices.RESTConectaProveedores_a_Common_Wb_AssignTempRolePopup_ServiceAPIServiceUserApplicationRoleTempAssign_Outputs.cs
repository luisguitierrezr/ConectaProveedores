using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_a_Common_Wb_AssignTempRolePopup_ServiceAPIServiceUserApplicationRoleTempAssign_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("Id")]
public long? outParamId;
[JsonProperty("Output")]
public ssConectaProveedores.RestRecords.RESTST_346a76e47f982dbf41625f8a893affccStructure outParamOutput;


    public static RESTConectaProveedores_a_Common_Wb_AssignTempRolePopup_ServiceAPIServiceUserApplicationRoleTempAssign_Outputs FromOutputs(IBehaviorsConfiguration conf, long outParamId, ST_346a76e47f982dbf41625f8a893affccStructure outParamOutput) {RESTConectaProveedores_a_Common_Wb_AssignTempRolePopup_ServiceAPIServiceUserApplicationRoleTempAssign_Outputs result = new RESTConectaProveedores_a_Common_Wb_AssignTempRolePopup_ServiceAPIServiceUserApplicationRoleTempAssign_Outputs();
conf.IncludeBinariesURL = false;
// Write optimized result.outParamId
result.outParamId = (long?) 0L;
// Write the needed fields of the record outParamOutput to the result.outParamOutput
result.outParamOutput = new ssConectaProveedores.RestRecords.RESTST_346a76e47f982dbf41625f8a893affccStructure();
result.outParamOutput.AttrIsSuccess = (bool?) outParamOutput.ssIsSuccess;
result.outParamOutput.AttrMessage = outParamOutput.ssMessage;
return result;
}


    

    
}
