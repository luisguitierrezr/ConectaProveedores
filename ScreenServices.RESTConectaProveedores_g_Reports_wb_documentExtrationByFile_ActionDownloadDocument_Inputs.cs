using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_g_Reports_wb_documentExtrationByFile_ActionDownloadDocument_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("i_Type")]
public int? inParami_Type;


    public static RESTConectaProveedores_g_Reports_wb_documentExtrationByFile_ActionDownloadDocument_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_g_Reports_wb_documentExtrationByFile_ActionDownloadDocument_Inputs result = inputParameters.ToObject<RESTConectaProveedores_g_Reports_wb_documentExtrationByFile_ActionDownloadDocument_Inputs>(settings);
return result;
}


    public ConectaProveedores_g_Reports_wb_documentExtrationByFile_ActionDownloadDocument_Model ToModel() {ConectaProveedores_g_Reports_wb_documentExtrationByFile_ActionDownloadDocument_Model result = new ConectaProveedores_g_Reports_wb_documentExtrationByFile_ActionDownloadDocument_Model();
result.inParami_Type = inParami_Type == null ? 0 : inParami_Type.Value;
return result;
}

}
