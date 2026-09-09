using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_h_OrderDistributionConfig_OrderDistributionConfig_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("l_FileContent")]
public byte[] varLcl_FileContent;
[JsonProperty("l_FileName")]
public string varLcl_FileName;
[JsonProperty("l_TabNumber")]
public int? varLcl_TabNumber;
[JsonProperty("l_TableSort")]
public string varLcl_TableSort;
[JsonProperty("GetSettings")]
public RESTConectaProveedores_h_OrderDistributionConfig_OrderDistributionConfig_DataActionGetSettings_Outputs varLcGetSettings;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_h_OrderDistributionConfig_OrderDistributionConfig_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_h_OrderDistributionConfig_OrderDistributionConfig_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_h_OrderDistributionConfig_OrderDistributionConfig_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_h_OrderDistributionConfig_OrderDistributionConfig_ScreenModel ToModel() {byte[] varLcl_FileContent = variables.varLcl_FileContent == null ? new byte[] {} : variables.varLcl_FileContent;
string varLcl_FileName = variables.varLcl_FileName == null ? "" : variables.varLcl_FileName;
int varLcl_TabNumber = variables.varLcl_TabNumber == null ? 0 : variables.varLcl_TabNumber.Value;
string varLcl_TableSort = variables.varLcl_TableSort == null ? "" : variables.varLcl_TableSort;
ConectaProveedores_h_OrderDistributionConfig_OrderDistributionConfig_DataActionGetSettings_Model _varLcGetSettings = (variables.varLcGetSettings != null) ? RESTConectaProveedores_h_OrderDistributionConfig_OrderDistributionConfig_DataActionGetSettings_Outputs.ToModel(variables.varLcGetSettings) : null;
ConectaProveedores_h_OrderDistributionConfig_OrderDistributionConfig_ScreenModel screenModel = new ConectaProveedores_h_OrderDistributionConfig_OrderDistributionConfig_ScreenModel(varLcl_FileContent, varLcl_FileName, varLcl_TabNumber, varLcl_TableSort, _varLcGetSettings, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
