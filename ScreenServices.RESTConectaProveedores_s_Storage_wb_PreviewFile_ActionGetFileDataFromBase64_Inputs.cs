using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_s_Storage_wb_PreviewFile_ActionGetFileDataFromBase64_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("i_Base64")]
public string inParami_Base64;
[JsonProperty("i_Filename")]
public string inParami_Filename;


    public static RESTConectaProveedores_s_Storage_wb_PreviewFile_ActionGetFileDataFromBase64_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_s_Storage_wb_PreviewFile_ActionGetFileDataFromBase64_Inputs result = inputParameters.ToObject<RESTConectaProveedores_s_Storage_wb_PreviewFile_ActionGetFileDataFromBase64_Inputs>(settings);
return result;
}


    public ConectaProveedores_s_Storage_wb_PreviewFile_ActionGetFileDataFromBase64_Model ToModel() {ConectaProveedores_s_Storage_wb_PreviewFile_ActionGetFileDataFromBase64_Model result = new ConectaProveedores_s_Storage_wb_PreviewFile_ActionGetFileDataFromBase64_Model();
result.inParami_Base64 = inParami_Base64 == null ? "" : inParami_Base64;
result.inParami_Filename = inParami_Filename == null ? "" : inParami_Filename;
return result;
}

}
