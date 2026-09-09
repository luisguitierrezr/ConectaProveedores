using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_d_InvoiceAudit_InvoicesAudit_DataActionGetUserRegion_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("RegionId")]
public long? outParamRegionId;
[JsonProperty("IsCorp")]
public bool? outParamIsCorp;


    public static RESTConectaProveedores_d_InvoiceAudit_InvoicesAudit_DataActionGetUserRegion_Outputs FromOutputs(IBehaviorsConfiguration conf, long outParamRegionId, bool outParamIsCorp) {RESTConectaProveedores_d_InvoiceAudit_InvoicesAudit_DataActionGetUserRegion_Outputs result = new RESTConectaProveedores_d_InvoiceAudit_InvoicesAudit_DataActionGetUserRegion_Outputs();
result.outParamRegionId = (long?) outParamRegionId;
result.outParamIsCorp = (bool?) outParamIsCorp;
return result;
}


    public static ConectaProveedores_d_InvoiceAudit_InvoicesAudit_DataActionGetUserRegion_Model ToModel(RESTConectaProveedores_d_InvoiceAudit_InvoicesAudit_DataActionGetUserRegion_Outputs variables) {ConectaProveedores_d_InvoiceAudit_InvoicesAudit_DataActionGetUserRegion_Model result = new ConectaProveedores_d_InvoiceAudit_InvoicesAudit_DataActionGetUserRegion_Model();
result.outParamRegionId = variables == null || variables.outParamRegionId == null ? 0L : variables.outParamRegionId.Value;
result.outParamIsCorp = variables == null || variables.outParamIsCorp == null ? false : variables.outParamIsCorp.Value;
return result;
}


    public static RESTConectaProveedores_d_InvoiceAudit_InvoicesAudit_DataActionGetUserRegion_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_d_InvoiceAudit_InvoicesAudit_DataActionGetUserRegion_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_d_InvoiceAudit_InvoicesAudit_DataActionGetUserRegion_Outputs result = new RESTConectaProveedores_d_InvoiceAudit_InvoicesAudit_DataActionGetUserRegion_Outputs();
result.outParamRegionId = (long?) screenModel.outParamRegionId;
result.outParamIsCorp = (bool?) screenModel.outParamIsCorp;
return result;
}

}
