using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_k_Deviations_Wb_CompleteEntry_ActionCompleteEntry_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("i_FolioId")]
public long? inParami_FolioId;
[JsonProperty("i_Year")]
public string inParami_Year;
[JsonProperty("i_EntryNumber")]
public string inParami_EntryNumber;
[JsonProperty("OffsetUtc")]
public int? inParamOffsetUtc;


    public static RESTConectaProveedores_k_Deviations_Wb_CompleteEntry_ActionCompleteEntry_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_k_Deviations_Wb_CompleteEntry_ActionCompleteEntry_Inputs result = inputParameters.ToObject<RESTConectaProveedores_k_Deviations_Wb_CompleteEntry_ActionCompleteEntry_Inputs>(settings);
return result;
}


    public ConectaProveedores_k_Deviations_Wb_CompleteEntry_ActionCompleteEntry_Model ToModel() {ConectaProveedores_k_Deviations_Wb_CompleteEntry_ActionCompleteEntry_Model result = new ConectaProveedores_k_Deviations_Wb_CompleteEntry_ActionCompleteEntry_Model();
result.inParami_FolioId = inParami_FolioId == null ? 0L : inParami_FolioId.Value;
result.inParami_Year = inParami_Year == null ? "" : inParami_Year;
result.inParami_EntryNumber = inParami_EntryNumber == null ? "" : inParami_EntryNumber;
result.inParamOffsetUtc = inParamOffsetUtc == null ? 0 : inParamOffsetUtc.Value;
return result;
}

}
