using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_g_Reports_wb_documentExtrationByFile_ActionFindByDateRanges_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("file")]
public byte[] inParamfile;


    public static RESTConectaProveedores_g_Reports_wb_documentExtrationByFile_ActionFindByDateRanges_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_g_Reports_wb_documentExtrationByFile_ActionFindByDateRanges_Inputs result = inputParameters.ToObject<RESTConectaProveedores_g_Reports_wb_documentExtrationByFile_ActionFindByDateRanges_Inputs>(settings);
return result;
}


    public ConectaProveedores_g_Reports_wb_documentExtrationByFile_ActionFindByDateRanges_Model ToModel() {ConectaProveedores_g_Reports_wb_documentExtrationByFile_ActionFindByDateRanges_Model result = new ConectaProveedores_g_Reports_wb_documentExtrationByFile_ActionFindByDateRanges_Model();
result.inParamfile = inParamfile == null ? new byte[] {} : inParamfile;
return result;
}

}
