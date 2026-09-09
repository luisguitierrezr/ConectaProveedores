using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewIcons_ActionCheckFiles_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("RequisitionId")]
public long? inParamRequisitionId;


    public static RESTConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewIcons_ActionCheckFiles_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewIcons_ActionCheckFiles_Inputs result = inputParameters.ToObject<RESTConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewIcons_ActionCheckFiles_Inputs>(settings);
return result;
}


    public ConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewIcons_ActionCheckFiles_Model ToModel() {ConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewIcons_ActionCheckFiles_Model result = new ConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewIcons_ActionCheckFiles_Model();
result.inParamRequisitionId = inParamRequisitionId == null ? 0L : inParamRequisitionId.Value;
return result;
}

}
