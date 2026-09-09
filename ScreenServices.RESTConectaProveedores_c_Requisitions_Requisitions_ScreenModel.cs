using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_c_Requisitions_Requisitions_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetSettings")]
public RESTConectaProveedores_c_Requisitions_Requisitions_DataActionGetSettings_Outputs varLcGetSettings;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_c_Requisitions_Requisitions_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_c_Requisitions_Requisitions_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_c_Requisitions_Requisitions_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_c_Requisitions_Requisitions_ScreenModel ToModel() {ConectaProveedores_c_Requisitions_Requisitions_DataActionGetSettings_Model _varLcGetSettings = (variables.varLcGetSettings != null) ? RESTConectaProveedores_c_Requisitions_Requisitions_DataActionGetSettings_Outputs.ToModel(variables.varLcGetSettings) : null;
ConectaProveedores_c_Requisitions_Requisitions_ScreenModel screenModel = new ConectaProveedores_c_Requisitions_Requisitions_ScreenModel(_varLcGetSettings, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
