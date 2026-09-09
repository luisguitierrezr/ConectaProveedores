using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_Wb_FolioActions_DataActionGetFolioTypeDA_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("o_ShowOptions")]
public bool? outParamo_ShowOptions;
[JsonProperty("o_IsActiveDEV_HU13045")]
public bool? outParamo_IsActiveDEV_HU13045;


    public static RESTConectaProveedores_j_FoliosSAE_Wb_FolioActions_DataActionGetFolioTypeDA_Outputs FromOutputs(IBehaviorsConfiguration conf, bool outParamo_ShowOptions, bool outParamo_IsActiveDEV_HU13045) {RESTConectaProveedores_j_FoliosSAE_Wb_FolioActions_DataActionGetFolioTypeDA_Outputs result = new RESTConectaProveedores_j_FoliosSAE_Wb_FolioActions_DataActionGetFolioTypeDA_Outputs();
result.outParamo_ShowOptions = (bool?) outParamo_ShowOptions;
result.outParamo_IsActiveDEV_HU13045 = (bool?) outParamo_IsActiveDEV_HU13045;
return result;
}


    public static ConectaProveedores_j_FoliosSAE_Wb_FolioActions_DataActionGetFolioTypeDA_Model ToModel(RESTConectaProveedores_j_FoliosSAE_Wb_FolioActions_DataActionGetFolioTypeDA_Outputs variables) {ConectaProveedores_j_FoliosSAE_Wb_FolioActions_DataActionGetFolioTypeDA_Model result = new ConectaProveedores_j_FoliosSAE_Wb_FolioActions_DataActionGetFolioTypeDA_Model();
result.outParamo_ShowOptions = variables == null || variables.outParamo_ShowOptions == null ? false : variables.outParamo_ShowOptions.Value;
result.outParamo_IsActiveDEV_HU13045 = variables == null || variables.outParamo_IsActiveDEV_HU13045 == null ? false : variables.outParamo_IsActiveDEV_HU13045.Value;
return result;
}


    public static RESTConectaProveedores_j_FoliosSAE_Wb_FolioActions_DataActionGetFolioTypeDA_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_j_FoliosSAE_Wb_FolioActions_DataActionGetFolioTypeDA_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_j_FoliosSAE_Wb_FolioActions_DataActionGetFolioTypeDA_Outputs result = new RESTConectaProveedores_j_FoliosSAE_Wb_FolioActions_DataActionGetFolioTypeDA_Outputs();
result.outParamo_ShowOptions = (bool?) screenModel.outParamo_ShowOptions;
result.outParamo_IsActiveDEV_HU13045 = (bool?) screenModel.outParamo_IsActiveDEV_HU13045;
return result;
}

}
