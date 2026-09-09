using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_a_Common_Login_ServiceAPIServiceSupplierCodeValidate_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("UserEmail")]
public string inParamUserEmail;
[JsonProperty("Code")]
public string inParamCode;


    public static RESTConectaProveedores_a_Common_Login_ServiceAPIServiceSupplierCodeValidate_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_a_Common_Login_ServiceAPIServiceSupplierCodeValidate_Inputs result = inputParameters.ToObject<RESTConectaProveedores_a_Common_Login_ServiceAPIServiceSupplierCodeValidate_Inputs>(settings);
return result;
}


    public ConectaProveedores_a_Common_Login_ServiceAPIServiceSupplierCodeValidate_Model ToModel() {ConectaProveedores_a_Common_Login_ServiceAPIServiceSupplierCodeValidate_Model result = new ConectaProveedores_a_Common_Login_ServiceAPIServiceSupplierCodeValidate_Model();
result.inParamUserEmail = inParamUserEmail == null ? "" : inParamUserEmail;
result.inParamCode = inParamCode == null ? "" : inParamCode;
return result;
}

}
