using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_NewMassiveFolioSAE_ActionFolioMassCreate_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("FolioQList")]
public RestList<ssConectaProveedores.RestRecords.RESTST_118fe20454dd0bf1f0e6d925e7d7544bStructure> inParamFolioQList;
[JsonProperty("FilesList")]
public RestList<ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure> inParamFilesList;
[JsonProperty("OrderAccConceptID")]
public long? inParamOrderAccConceptID;
[JsonProperty("OffsetUtc")]
public int? inParamOffsetUtc;


    public static RESTConectaProveedores_j_FoliosSAE_NewMassiveFolioSAE_ActionFolioMassCreate_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_j_FoliosSAE_NewMassiveFolioSAE_ActionFolioMassCreate_Inputs result = inputParameters.ToObject<RESTConectaProveedores_j_FoliosSAE_NewMassiveFolioSAE_ActionFolioMassCreate_Inputs>(settings);
return result;
}


    public ConectaProveedores_j_FoliosSAE_NewMassiveFolioSAE_ActionFolioMassCreate_Model ToModel() {ConectaProveedores_j_FoliosSAE_NewMassiveFolioSAE_ActionFolioMassCreate_Model result = new ConectaProveedores_j_FoliosSAE_NewMassiveFolioSAE_ActionFolioMassCreate_Model();
result.inParamFolioQList = RL_f4ab0a048438c19ab1537693fa69f7c4.FromRestList(inParamFolioQList, ssConectaProveedores.RestRecords.RESTST_118fe20454dd0bf1f0e6d925e7d7544bStructure.ToStructure);
result.inParamFilesList = RL_1501ee54ff868a67eff67465502ee3d9.FromRestList(inParamFilesList, ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure.ToStructure);
result.inParamOrderAccConceptID = inParamOrderAccConceptID == null ? 0L : inParamOrderAccConceptID.Value;
result.inParamOffsetUtc = inParamOffsetUtc == null ? 0 : inParamOffsetUtc.Value;
return result;
}

}
