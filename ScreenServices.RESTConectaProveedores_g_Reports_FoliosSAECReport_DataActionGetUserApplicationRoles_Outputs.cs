using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_g_Reports_FoliosSAECReport_DataActionGetUserApplicationRoles_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("UserRegion")]
public long? outParamUserRegion;
[JsonProperty("SupplierId")]
public long? outParamSupplierId;
[JsonProperty("IsAllRegions")]
public bool? outParamIsAllRegions;


    public static RESTConectaProveedores_g_Reports_FoliosSAECReport_DataActionGetUserApplicationRoles_Outputs FromOutputs(IBehaviorsConfiguration conf, long outParamUserRegion, long outParamSupplierId, bool outParamIsAllRegions) {RESTConectaProveedores_g_Reports_FoliosSAECReport_DataActionGetUserApplicationRoles_Outputs result = new RESTConectaProveedores_g_Reports_FoliosSAECReport_DataActionGetUserApplicationRoles_Outputs();
result.outParamUserRegion = (long?) outParamUserRegion;
result.outParamSupplierId = (long?) outParamSupplierId;
result.outParamIsAllRegions = (bool?) outParamIsAllRegions;
return result;
}


    public static ConectaProveedores_g_Reports_FoliosSAECReport_DataActionGetUserApplicationRoles_Model ToModel(RESTConectaProveedores_g_Reports_FoliosSAECReport_DataActionGetUserApplicationRoles_Outputs variables) {ConectaProveedores_g_Reports_FoliosSAECReport_DataActionGetUserApplicationRoles_Model result = new ConectaProveedores_g_Reports_FoliosSAECReport_DataActionGetUserApplicationRoles_Model();
result.outParamUserRegion = variables == null || variables.outParamUserRegion == null ? 0L : variables.outParamUserRegion.Value;
result.outParamSupplierId = variables == null || variables.outParamSupplierId == null ? 0L : variables.outParamSupplierId.Value;
result.outParamIsAllRegions = variables == null || variables.outParamIsAllRegions == null ? false : variables.outParamIsAllRegions.Value;
return result;
}


    public static RESTConectaProveedores_g_Reports_FoliosSAECReport_DataActionGetUserApplicationRoles_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_g_Reports_FoliosSAECReport_DataActionGetUserApplicationRoles_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_g_Reports_FoliosSAECReport_DataActionGetUserApplicationRoles_Outputs result = new RESTConectaProveedores_g_Reports_FoliosSAECReport_DataActionGetUserApplicationRoles_Outputs();
result.outParamUserRegion = (long?) screenModel.outParamUserRegion;
result.outParamSupplierId = (long?) screenModel.outParamSupplierId;
result.outParamIsAllRegions = (bool?) screenModel.outParamIsAllRegions;
return result;
}

}
