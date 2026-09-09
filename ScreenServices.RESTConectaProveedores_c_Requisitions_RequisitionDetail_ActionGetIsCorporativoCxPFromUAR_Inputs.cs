using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_c_Requisitions_RequisitionDetail_ActionGetIsCorporativoCxPFromUAR_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("i_ConceptId")]
public int? inParami_ConceptId;
[JsonProperty("i_GetUserId")]
public string inParami_GetUserId;


    public static RESTConectaProveedores_c_Requisitions_RequisitionDetail_ActionGetIsCorporativoCxPFromUAR_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_c_Requisitions_RequisitionDetail_ActionGetIsCorporativoCxPFromUAR_Inputs result = inputParameters.ToObject<RESTConectaProveedores_c_Requisitions_RequisitionDetail_ActionGetIsCorporativoCxPFromUAR_Inputs>(settings);
return result;
}


    public ConectaProveedores_c_Requisitions_RequisitionDetail_ActionGetIsCorporativoCxPFromUAR_Model ToModel() {ConectaProveedores_c_Requisitions_RequisitionDetail_ActionGetIsCorporativoCxPFromUAR_Model result = new ConectaProveedores_c_Requisitions_RequisitionDetail_ActionGetIsCorporativoCxPFromUAR_Model();
result.inParami_ConceptId = inParami_ConceptId == null ? 0 : inParami_ConceptId.Value;
result.inParami_GetUserId = inParami_GetUserId == null ? "" : inParami_GetUserId;
return result;
}

}
