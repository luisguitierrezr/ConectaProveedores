using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_a_Common_Menu_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("ActiveItem")]
public int? inParamActiveItem;
[JsonProperty("ActiveSubItem")]
public int? inParamActiveSubItem;
[JsonProperty("GetSettings")]
public RESTConectaProveedores_a_Common_Menu_DataActionGetSettings_Outputs varLcGetSettings;
[JsonProperty("GetUserData")]
public RESTConectaProveedores_a_Common_Menu_DataActionGetUserData_Outputs varLcGetUserData;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_a_Common_Menu_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_a_Common_Menu_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_a_Common_Menu_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_a_Common_Menu_ScreenModel ToModel() {int inParamActiveItem = variables.inParamActiveItem == null ? (-1) : variables.inParamActiveItem.Value;
int inParamActiveSubItem = variables.inParamActiveSubItem == null ? (-1) : variables.inParamActiveSubItem.Value;
ConectaProveedores_a_Common_Menu_DataActionGetSettings_Model _varLcGetSettings = (variables.varLcGetSettings != null) ? RESTConectaProveedores_a_Common_Menu_DataActionGetSettings_Outputs.ToModel(variables.varLcGetSettings) : null;
ConectaProveedores_a_Common_Menu_DataActionGetUserData_Model _varLcGetUserData = (variables.varLcGetUserData != null) ? RESTConectaProveedores_a_Common_Menu_DataActionGetUserData_Outputs.ToModel(variables.varLcGetUserData) : null;
ConectaProveedores_a_Common_Menu_ScreenModel screenModel = new ConectaProveedores_a_Common_Menu_ScreenModel(inParamActiveItem, inParamActiveSubItem, _varLcGetSettings, _varLcGetUserData, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
