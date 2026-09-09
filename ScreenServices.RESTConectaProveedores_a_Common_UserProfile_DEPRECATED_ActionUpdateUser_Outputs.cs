using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_a_Common_UserProfile_DEPRECATED_ActionUpdateUser_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("UpdateUserResult")]
public ssConectaProveedores.RestRecords.RESTST_c57cc6bedbdc9e62046393fa735672cfStructure outParamUpdateUserResult;


    public static RESTConectaProveedores_a_Common_UserProfile_DEPRECATED_ActionUpdateUser_Outputs FromOutputs(IBehaviorsConfiguration conf, ST_c57cc6bedbdc9e62046393fa735672cfStructure outParamUpdateUserResult) {RESTConectaProveedores_a_Common_UserProfile_DEPRECATED_ActionUpdateUser_Outputs result = new RESTConectaProveedores_a_Common_UserProfile_DEPRECATED_ActionUpdateUser_Outputs();
conf.IncludeBinariesURL = false;
// Write the needed fields of the record outParamUpdateUserResult to the result.outParamUpdateUserResult
result.outParamUpdateUserResult = new ssConectaProveedores.RestRecords.RESTST_c57cc6bedbdc9e62046393fa735672cfStructure();
result.outParamUpdateUserResult.AttrSuccess = (bool?) outParamUpdateUserResult.ssSuccess;
// Write optimized result.outParamUpdateUserResult.AttrUserPhotoURL
result.outParamUpdateUserResult.AttrUserPhotoURL = "";
// Write the needed fields of the record outParamUpdateUserResult.ssUpdateUserFailureReason to the result.outParamUpdateUserResult.AttrUpdateUserFailureReason
result.outParamUpdateUserResult.AttrUpdateUserFailureReason = new ssConectaProveedores.RestRecords.RESTST_6f88d6be05f2234ba151435ee8bf2cd4Structure();
result.outParamUpdateUserResult.AttrUpdateUserFailureReason.AttrInvalidCredentials = (bool?) outParamUpdateUserResult.ssUpdateUserFailureReason.ssInvalidCredentials;
result.outParamUpdateUserResult.AttrUpdateUserFailureReason.AttrInvalidName = (bool?) outParamUpdateUserResult.ssUpdateUserFailureReason.ssInvalidName;
result.outParamUpdateUserResult.AttrUpdateUserFailureReason.AttrInvalidPhotoURL = (bool?) outParamUpdateUserResult.ssUpdateUserFailureReason.ssInvalidPhotoURL;
return result;
}


    

    
}
