using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_g_Reports_Wb_PreviewFile_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("StorageId")]
public long? inParamStorageId;
[JsonProperty("ForceRefresh")]
public String inParamForceRefresh;
[JsonProperty("l_Binary")]
public byte[] varLcl_Binary;
[JsonProperty("l_xml")]
public string varLcl_xml;
[JsonProperty("l_Filename")]
public string varLcl_Filename;
[JsonProperty("l_PopupToggler")]
public bool? varLcl_PopupToggler;
[JsonProperty("GetData")]
public RESTConectaProveedores_g_Reports_Wb_PreviewFile_DataActionGetData_Outputs varLcGetData;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_g_Reports_Wb_PreviewFile_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_g_Reports_Wb_PreviewFile_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_g_Reports_Wb_PreviewFile_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_g_Reports_Wb_PreviewFile_ScreenModel ToModel() {long inParamStorageId = variables.inParamStorageId == null ? 0L : variables.inParamStorageId.Value;
DateTime inParamForceRefresh = variables.inParamForceRefresh == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(variables.inParamForceRefresh, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
byte[] varLcl_Binary = variables.varLcl_Binary == null ? new byte[] {} : variables.varLcl_Binary;
string varLcl_xml = variables.varLcl_xml == null ? "" : variables.varLcl_xml;
string varLcl_Filename = variables.varLcl_Filename == null ? "" : variables.varLcl_Filename;
bool varLcl_PopupToggler = variables.varLcl_PopupToggler == null ? false : variables.varLcl_PopupToggler.Value;
ConectaProveedores_g_Reports_Wb_PreviewFile_DataActionGetData_Model _varLcGetData = (variables.varLcGetData != null) ? RESTConectaProveedores_g_Reports_Wb_PreviewFile_DataActionGetData_Outputs.ToModel(variables.varLcGetData) : null;
ConectaProveedores_g_Reports_Wb_PreviewFile_ScreenModel screenModel = new ConectaProveedores_g_Reports_Wb_PreviewFile_ScreenModel(inParamStorageId, inParamForceRefresh, varLcl_Binary, varLcl_xml, varLcl_Filename, varLcl_PopupToggler, _varLcGetData, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
