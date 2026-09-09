using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_FoliosSAEApproved_ActionScreenTableDownloadFoliosSAEScreen_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("i_IsCSV")]
public bool? inParami_IsCSV;
[JsonProperty("i_IsPDF")]
public bool? inParami_IsPDF;
[JsonProperty("i_IsXLS")]
public bool? inParami_IsXLS;
[JsonProperty("i_FolioScreenTableStructure")]
public RestList<ssConectaProveedores.RestRecords.RESTST_3dc7a528e6a1e146b195db5c3edb006aStructure> inParami_FolioScreenTableStructure;


    public static RESTConectaProveedores_j_FoliosSAE_FoliosSAEApproved_ActionScreenTableDownloadFoliosSAEScreen_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_j_FoliosSAE_FoliosSAEApproved_ActionScreenTableDownloadFoliosSAEScreen_Inputs result = inputParameters.ToObject<RESTConectaProveedores_j_FoliosSAE_FoliosSAEApproved_ActionScreenTableDownloadFoliosSAEScreen_Inputs>(settings);
return result;
}


    public ConectaProveedores_j_FoliosSAE_FoliosSAEApproved_ActionScreenTableDownloadFoliosSAEScreen_Model ToModel() {ConectaProveedores_j_FoliosSAE_FoliosSAEApproved_ActionScreenTableDownloadFoliosSAEScreen_Model result = new ConectaProveedores_j_FoliosSAE_FoliosSAEApproved_ActionScreenTableDownloadFoliosSAEScreen_Model();
result.inParami_IsCSV = inParami_IsCSV == null ? false : inParami_IsCSV.Value;
result.inParami_IsPDF = inParami_IsPDF == null ? false : inParami_IsPDF.Value;
result.inParami_IsXLS = inParami_IsXLS == null ? false : inParami_IsXLS.Value;
result.inParami_FolioScreenTableStructure = RL_9046748205310553b4766e7b1bf0c997.FromRestList(inParami_FolioScreenTableStructure, ssConectaProveedores.RestRecords.RESTST_3dc7a528e6a1e146b195db5c3edb006aStructure.ToStructure);
return result;
}

}
