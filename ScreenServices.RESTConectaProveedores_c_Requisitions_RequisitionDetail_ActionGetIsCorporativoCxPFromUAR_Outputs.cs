using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_c_Requisitions_RequisitionDetail_ActionGetIsCorporativoCxPFromUAR_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("o_IsFromCorporativo")]
public bool? outParamo_IsFromCorporativo;


    public static RESTConectaProveedores_c_Requisitions_RequisitionDetail_ActionGetIsCorporativoCxPFromUAR_Outputs FromOutputs(IBehaviorsConfiguration conf, bool outParamo_IsFromCorporativo) {RESTConectaProveedores_c_Requisitions_RequisitionDetail_ActionGetIsCorporativoCxPFromUAR_Outputs result = new RESTConectaProveedores_c_Requisitions_RequisitionDetail_ActionGetIsCorporativoCxPFromUAR_Outputs();
conf.IncludeBinariesURL = false;
result.outParamo_IsFromCorporativo = (bool?) outParamo_IsFromCorporativo;
return result;
}


    

    
}
