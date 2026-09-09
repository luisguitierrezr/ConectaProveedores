using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_Wb_FolioEdit_ServiceAPICall_ZMXMIMMF_VISUALIZAR_SAL_ANT_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("Response")]
public ssConectaProveedores.RestRecords.RESTST_cbb2055cf19f871ed882642269bd43ceStructure outParamResponse;


    public static RESTConectaProveedores_j_FoliosSAE_Wb_FolioEdit_ServiceAPICall_ZMXMIMMF_VISUALIZAR_SAL_ANT_Outputs FromOutputs(IBehaviorsConfiguration conf, ST_cbb2055cf19f871ed882642269bd43ceStructure outParamResponse) {RESTConectaProveedores_j_FoliosSAE_Wb_FolioEdit_ServiceAPICall_ZMXMIMMF_VISUALIZAR_SAL_ANT_Outputs result = new RESTConectaProveedores_j_FoliosSAE_Wb_FolioEdit_ServiceAPICall_ZMXMIMMF_VISUALIZAR_SAL_ANT_Outputs();
conf.IncludeBinariesURL = false;
// Write the needed fields of the record outParamResponse to the result.outParamResponse
result.outParamResponse = new ssConectaProveedores.RestRecords.RESTST_cbb2055cf19f871ed882642269bd43ceStructure();
// Write optimized result.outParamResponse.AttrPO_EXITO_ERROR
result.outParamResponse.AttrPO_EXITO_ERROR = "";
result.outParamResponse.AttrPO_IMP_ANT = (decimal?) outParamResponse.ssPO_IMP_ANT;
// Write optimized result.outParamResponse.AttrPO_MENSAJE
result.outParamResponse.AttrPO_MENSAJE = "";
// Write optimized result.outParamResponse.AttrPO_NUM_ERROR
result.outParamResponse.AttrPO_NUM_ERROR = "";
// Write optimized result.outParamResponse.AttrPO_PEDIDO
result.outParamResponse.AttrPO_PEDIDO = "";
return result;
}


    

    
}
