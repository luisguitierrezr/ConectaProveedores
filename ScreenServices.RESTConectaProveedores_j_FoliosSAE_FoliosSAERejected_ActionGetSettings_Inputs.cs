using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_FoliosSAERejected_ActionGetSettings_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("TableName")]
public string inParamTableName;


    public static RESTConectaProveedores_j_FoliosSAE_FoliosSAERejected_ActionGetSettings_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_j_FoliosSAE_FoliosSAERejected_ActionGetSettings_Inputs result = inputParameters.ToObject<RESTConectaProveedores_j_FoliosSAE_FoliosSAERejected_ActionGetSettings_Inputs>(settings);
return result;
}


    public ConectaProveedores_j_FoliosSAE_FoliosSAERejected_ActionGetSettings_Model ToModel() {ConectaProveedores_j_FoliosSAE_FoliosSAERejected_ActionGetSettings_Model result = new ConectaProveedores_j_FoliosSAE_FoliosSAERejected_ActionGetSettings_Model();
result.inParamTableName = inParamTableName == null ? "" : inParamTableName;
return result;
}

}
