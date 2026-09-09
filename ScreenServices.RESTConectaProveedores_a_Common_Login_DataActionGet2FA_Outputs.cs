using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_a_Common_Login_DataActionGet2FA_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("ISactive")]
public bool? outParamISactive;


    public static RESTConectaProveedores_a_Common_Login_DataActionGet2FA_Outputs FromOutputs(IBehaviorsConfiguration conf, bool outParamISactive) {RESTConectaProveedores_a_Common_Login_DataActionGet2FA_Outputs result = new RESTConectaProveedores_a_Common_Login_DataActionGet2FA_Outputs();
result.outParamISactive = (bool?) outParamISactive;
return result;
}


    public static ConectaProveedores_a_Common_Login_DataActionGet2FA_Model ToModel(RESTConectaProveedores_a_Common_Login_DataActionGet2FA_Outputs variables) {ConectaProveedores_a_Common_Login_DataActionGet2FA_Model result = new ConectaProveedores_a_Common_Login_DataActionGet2FA_Model();
result.outParamISactive = variables == null || variables.outParamISactive == null ? false : variables.outParamISactive.Value;
return result;
}


    public static RESTConectaProveedores_a_Common_Login_DataActionGet2FA_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_a_Common_Login_DataActionGet2FA_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_a_Common_Login_DataActionGet2FA_Outputs result = new RESTConectaProveedores_a_Common_Login_DataActionGet2FA_Outputs();
result.outParamISactive = (bool?) screenModel.outParamISactive;
return result;
}

}
