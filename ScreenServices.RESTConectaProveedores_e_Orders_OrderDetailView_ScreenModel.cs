using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_e_Orders_OrderDetailView_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("i_OrderId")]
public long? inParami_OrderId;
[JsonProperty("GetSettings")]
public RESTConectaProveedores_e_Orders_OrderDetailView_DataActionGetSettings_Outputs varLcGetSettings;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_e_Orders_OrderDetailView_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_e_Orders_OrderDetailView_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_e_Orders_OrderDetailView_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_e_Orders_OrderDetailView_ScreenModel ToModel() {long inParami_OrderId = variables.inParami_OrderId == null ? 0L : variables.inParami_OrderId.Value;
ConectaProveedores_e_Orders_OrderDetailView_DataActionGetSettings_Model _varLcGetSettings = (variables.varLcGetSettings != null) ? RESTConectaProveedores_e_Orders_OrderDetailView_DataActionGetSettings_Outputs.ToModel(variables.varLcGetSettings) : null;
ConectaProveedores_e_Orders_OrderDetailView_ScreenModel screenModel = new ConectaProveedores_e_Orders_OrderDetailView_ScreenModel(inParami_OrderId, _varLcGetSettings, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
