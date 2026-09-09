using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_ActionString_Join_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("List")]
public RestList<ssConectaProveedores.RestRecords.RESTRCTextRecord> inParamList;
[JsonProperty("Separator")]
public string inParamSeparator;


    public static RESTConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_ActionString_Join_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_ActionString_Join_Inputs result = inputParameters.ToObject<RESTConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_ActionString_Join_Inputs>(settings);
return result;
}


    public ConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_ActionString_Join_Model ToModel() {ConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_ActionString_Join_Model result = new ConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_ActionString_Join_Model();
result.inParamList = RLTextRecordList.FromRestList(inParamList, ssConectaProveedores.RestRecords.RESTRCTextRecord.ToStructure);
result.inParamSeparator = inParamSeparator == null ? "" : inParamSeparator;
return result;
}

}
