using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_k_Deviations_UnsuccessfulEntries_ActionColumnTogglerPassColumn_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("i_ColumnJSON")]
public string inParami_ColumnJSON;
[JsonProperty("i_TableName")]
public string inParami_TableName;
[JsonProperty("i_UserId")]
public string inParami_UserId;


    public static RESTConectaProveedores_k_Deviations_UnsuccessfulEntries_ActionColumnTogglerPassColumn_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_k_Deviations_UnsuccessfulEntries_ActionColumnTogglerPassColumn_Inputs result = inputParameters.ToObject<RESTConectaProveedores_k_Deviations_UnsuccessfulEntries_ActionColumnTogglerPassColumn_Inputs>(settings);
return result;
}


    public ConectaProveedores_k_Deviations_UnsuccessfulEntries_ActionColumnTogglerPassColumn_Model ToModel() {ConectaProveedores_k_Deviations_UnsuccessfulEntries_ActionColumnTogglerPassColumn_Model result = new ConectaProveedores_k_Deviations_UnsuccessfulEntries_ActionColumnTogglerPassColumn_Model();
result.inParami_ColumnJSON = inParami_ColumnJSON == null ? "" : inParami_ColumnJSON;
result.inParami_TableName = inParami_TableName == null ? "" : inParami_TableName;
result.inParami_UserId = inParami_UserId == null ? "" : inParami_UserId;
return result;
}

}
