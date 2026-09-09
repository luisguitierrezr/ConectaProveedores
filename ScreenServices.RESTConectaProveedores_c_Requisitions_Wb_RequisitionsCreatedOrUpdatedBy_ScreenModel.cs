using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_c_Requisitions_Wb_RequisitionsCreatedOrUpdatedBy_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("RequisitionId")]
public long? inParamRequisitionId;
[JsonProperty("GetsRequisitionsData")]
public RESTConectaProveedores_c_Requisitions_Wb_RequisitionsCreatedOrUpdatedBy_DataActionGetsRequisitionsData_Outputs varLcGetsRequisitionsData;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_c_Requisitions_Wb_RequisitionsCreatedOrUpdatedBy_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_c_Requisitions_Wb_RequisitionsCreatedOrUpdatedBy_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_c_Requisitions_Wb_RequisitionsCreatedOrUpdatedBy_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_c_Requisitions_Wb_RequisitionsCreatedOrUpdatedBy_ScreenModel ToModel() {long inParamRequisitionId = variables.inParamRequisitionId == null ? 0L : variables.inParamRequisitionId.Value;
ConectaProveedores_c_Requisitions_Wb_RequisitionsCreatedOrUpdatedBy_DataActionGetsRequisitionsData_Model _varLcGetsRequisitionsData = (variables.varLcGetsRequisitionsData != null) ? RESTConectaProveedores_c_Requisitions_Wb_RequisitionsCreatedOrUpdatedBy_DataActionGetsRequisitionsData_Outputs.ToModel(variables.varLcGetsRequisitionsData) : null;
ConectaProveedores_c_Requisitions_Wb_RequisitionsCreatedOrUpdatedBy_ScreenModel screenModel = new ConectaProveedores_c_Requisitions_Wb_RequisitionsCreatedOrUpdatedBy_ScreenModel(inParamRequisitionId, _varLcGetsRequisitionsData, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
