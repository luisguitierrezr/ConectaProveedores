using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_e_Orders_Orders_ActionGetSettings_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("TableName")]
public string inParamTableName;


    public static RESTConectaProveedores_e_Orders_Orders_ActionGetSettings_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_e_Orders_Orders_ActionGetSettings_Inputs result = inputParameters.ToObject<RESTConectaProveedores_e_Orders_Orders_ActionGetSettings_Inputs>(settings);
return result;
}


    public ConectaProveedores_e_Orders_Orders_ActionGetSettings_Model ToModel() {ConectaProveedores_e_Orders_Orders_ActionGetSettings_Model result = new ConectaProveedores_e_Orders_Orders_ActionGetSettings_Model();
result.inParamTableName = inParamTableName == null ? "" : inParamTableName;
return result;
}

}
