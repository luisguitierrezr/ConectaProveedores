using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetShowIsDonation_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("o_Show")]
public bool? outParamo_Show;


    public static RESTConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetShowIsDonation_Outputs FromOutputs(IBehaviorsConfiguration conf, bool outParamo_Show) {RESTConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetShowIsDonation_Outputs result = new RESTConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetShowIsDonation_Outputs();
result.outParamo_Show = (bool?) outParamo_Show;
return result;
}


    public static ConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetShowIsDonation_Model ToModel(RESTConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetShowIsDonation_Outputs variables) {ConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetShowIsDonation_Model result = new ConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetShowIsDonation_Model();
result.outParamo_Show = variables == null || variables.outParamo_Show == null ? false : variables.outParamo_Show.Value;
return result;
}


    public static RESTConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetShowIsDonation_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetShowIsDonation_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetShowIsDonation_Outputs result = new RESTConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetShowIsDonation_Outputs();
result.outParamo_Show = (bool?) screenModel.outParamo_Show;
return result;
}

}
