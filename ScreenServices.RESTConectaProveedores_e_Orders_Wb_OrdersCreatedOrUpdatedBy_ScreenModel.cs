using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_e_Orders_Wb_OrdersCreatedOrUpdatedBy_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("OrderMainId")]
public long? inParamOrderMainId;
[JsonProperty("GetsOrdersData")]
public RESTConectaProveedores_e_Orders_Wb_OrdersCreatedOrUpdatedBy_DataActionGetsOrdersData_Outputs varLcGetsOrdersData;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_e_Orders_Wb_OrdersCreatedOrUpdatedBy_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_e_Orders_Wb_OrdersCreatedOrUpdatedBy_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_e_Orders_Wb_OrdersCreatedOrUpdatedBy_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_e_Orders_Wb_OrdersCreatedOrUpdatedBy_ScreenModel ToModel() {long inParamOrderMainId = variables.inParamOrderMainId == null ? 0L : variables.inParamOrderMainId.Value;
ConectaProveedores_e_Orders_Wb_OrdersCreatedOrUpdatedBy_DataActionGetsOrdersData_Model _varLcGetsOrdersData = (variables.varLcGetsOrdersData != null) ? RESTConectaProveedores_e_Orders_Wb_OrdersCreatedOrUpdatedBy_DataActionGetsOrdersData_Outputs.ToModel(variables.varLcGetsOrdersData) : null;
ConectaProveedores_e_Orders_Wb_OrdersCreatedOrUpdatedBy_ScreenModel screenModel = new ConectaProveedores_e_Orders_Wb_OrdersCreatedOrUpdatedBy_ScreenModel(inParamOrderMainId, _varLcGetsOrdersData, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
