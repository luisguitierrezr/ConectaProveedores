using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_a_Layouts_LayoutHomepage_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("HasFixedHeader")]
public bool? inParamHasFixedHeader;
[JsonProperty("EnableAccessibilityFeatures")]
public bool? inParamEnableAccessibilityFeatures;
[JsonProperty("ExtendedClass")]
public string inParamExtendedClass;
[JsonProperty("GetSettings")]
public RESTConectaProveedores_a_Layouts_LayoutHomepage_DataActionGetSettings_Outputs varLcGetSettings;
[JsonProperty("GetUserData")]
public RESTConectaProveedores_a_Layouts_LayoutHomepage_DataActionGetUserData_Outputs varLcGetUserData;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_a_Layouts_LayoutHomepage_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_a_Layouts_LayoutHomepage_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_a_Layouts_LayoutHomepage_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_a_Layouts_LayoutHomepage_ScreenModel ToModel() {bool inParamHasFixedHeader = variables.inParamHasFixedHeader == null ? true : variables.inParamHasFixedHeader.Value;
bool inParamEnableAccessibilityFeatures = variables.inParamEnableAccessibilityFeatures == null ? false : variables.inParamEnableAccessibilityFeatures.Value;
string inParamExtendedClass = variables.inParamExtendedClass == null ? "" : variables.inParamExtendedClass;
ConectaProveedores_a_Layouts_LayoutHomepage_DataActionGetSettings_Model _varLcGetSettings = (variables.varLcGetSettings != null) ? RESTConectaProveedores_a_Layouts_LayoutHomepage_DataActionGetSettings_Outputs.ToModel(variables.varLcGetSettings) : null;
ConectaProveedores_a_Layouts_LayoutHomepage_DataActionGetUserData_Model _varLcGetUserData = (variables.varLcGetUserData != null) ? RESTConectaProveedores_a_Layouts_LayoutHomepage_DataActionGetUserData_Outputs.ToModel(variables.varLcGetUserData) : null;
ConectaProveedores_a_Layouts_LayoutHomepage_ScreenModel screenModel = new ConectaProveedores_a_Layouts_LayoutHomepage_ScreenModel(inParamHasFixedHeader, inParamEnableAccessibilityFeatures, inParamExtendedClass, _varLcGetSettings, _varLcGetUserData, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
