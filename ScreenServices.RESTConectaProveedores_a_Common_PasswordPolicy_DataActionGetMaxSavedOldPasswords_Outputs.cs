using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_a_Common_PasswordPolicy_DataActionGetMaxSavedOldPasswords_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("Value")]
public int? outParamValue;


    public static RESTConectaProveedores_a_Common_PasswordPolicy_DataActionGetMaxSavedOldPasswords_Outputs FromOutputs(IBehaviorsConfiguration conf, int outParamValue) {RESTConectaProveedores_a_Common_PasswordPolicy_DataActionGetMaxSavedOldPasswords_Outputs result = new RESTConectaProveedores_a_Common_PasswordPolicy_DataActionGetMaxSavedOldPasswords_Outputs();
result.outParamValue = (int?) outParamValue;
return result;
}


    public static ConectaProveedores_a_Common_PasswordPolicy_DataActionGetMaxSavedOldPasswords_Model ToModel(RESTConectaProveedores_a_Common_PasswordPolicy_DataActionGetMaxSavedOldPasswords_Outputs variables) {ConectaProveedores_a_Common_PasswordPolicy_DataActionGetMaxSavedOldPasswords_Model result = new ConectaProveedores_a_Common_PasswordPolicy_DataActionGetMaxSavedOldPasswords_Model();
result.outParamValue = variables == null || variables.outParamValue == null ? 0 : variables.outParamValue.Value;
return result;
}


    public static RESTConectaProveedores_a_Common_PasswordPolicy_DataActionGetMaxSavedOldPasswords_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_a_Common_PasswordPolicy_DataActionGetMaxSavedOldPasswords_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_a_Common_PasswordPolicy_DataActionGetMaxSavedOldPasswords_Outputs result = new RESTConectaProveedores_a_Common_PasswordPolicy_DataActionGetMaxSavedOldPasswords_Outputs();
result.outParamValue = (int?) screenModel.outParamValue;
return result;
}

}
