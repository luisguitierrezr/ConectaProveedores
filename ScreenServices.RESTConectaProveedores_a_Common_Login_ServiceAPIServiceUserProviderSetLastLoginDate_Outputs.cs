using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_a_Common_Login_ServiceAPIServiceUserProviderSetLastLoginDate_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("o_Return")]
public ssConectaProveedores.RestRecords.RESTST_b1b6df219277397c7c2be747d587880aStructure outParamo_Return;


    public static RESTConectaProveedores_a_Common_Login_ServiceAPIServiceUserProviderSetLastLoginDate_Outputs FromOutputs(IBehaviorsConfiguration conf, ST_b1b6df219277397c7c2be747d587880aStructure outParamo_Return) {RESTConectaProveedores_a_Common_Login_ServiceAPIServiceUserProviderSetLastLoginDate_Outputs result = new RESTConectaProveedores_a_Common_Login_ServiceAPIServiceUserProviderSetLastLoginDate_Outputs();
conf.IncludeBinariesURL = false;
// Write the needed fields of the record outParamo_Return to the result.outParamo_Return
result.outParamo_Return = new ssConectaProveedores.RestRecords.RESTST_b1b6df219277397c7c2be747d587880aStructure();
result.outParamo_Return.AttrIsSuccess = (bool?) outParamo_Return.ssIsSuccess;
result.outParamo_Return.AttrMessage = outParamo_Return.ssMessage;
return result;
}


    

    
}
