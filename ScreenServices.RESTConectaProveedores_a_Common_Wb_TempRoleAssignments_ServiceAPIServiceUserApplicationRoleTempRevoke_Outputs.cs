using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_a_Common_Wb_TempRoleAssignments_ServiceAPIServiceUserApplicationRoleTempRevoke_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("Id")]
public long? outParamId;
[JsonProperty("Output")]
public ssConectaProveedores.RestRecords.RESTST_346a76e47f982dbf41625f8a893affccStructure outParamOutput;


    public static RESTConectaProveedores_a_Common_Wb_TempRoleAssignments_ServiceAPIServiceUserApplicationRoleTempRevoke_Outputs FromOutputs(IBehaviorsConfiguration conf, long outParamId, ST_346a76e47f982dbf41625f8a893affccStructure outParamOutput) {RESTConectaProveedores_a_Common_Wb_TempRoleAssignments_ServiceAPIServiceUserApplicationRoleTempRevoke_Outputs result = new RESTConectaProveedores_a_Common_Wb_TempRoleAssignments_ServiceAPIServiceUserApplicationRoleTempRevoke_Outputs();
conf.IncludeBinariesURL = false;
// Write optimized result.outParamId
result.outParamId = (long?) 0L;
// Write optimized result.outParamOutput
result.outParamOutput = ssConectaProveedores.RestRecords.RESTST_346a76e47f982dbf41625f8a893affccStructure.FromStructure(new ST_346a76e47f982dbf41625f8a893affccStructure(), conf);
return result;
}


    

    
}
