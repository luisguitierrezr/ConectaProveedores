using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_c_Proveedor_AccountStatus_ActionGenerateCurrentAccountCSV_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("file")]
public byte[] outParamfile;


    public static RESTConectaProveedores_c_Proveedor_AccountStatus_ActionGenerateCurrentAccountCSV_Outputs FromOutputs(IBehaviorsConfiguration conf, byte[] outParamfile) {RESTConectaProveedores_c_Proveedor_AccountStatus_ActionGenerateCurrentAccountCSV_Outputs result = new RESTConectaProveedores_c_Proveedor_AccountStatus_ActionGenerateCurrentAccountCSV_Outputs();
conf.IncludeBinariesURL = false;
result.outParamfile = outParamfile;
return result;
}


    

    
}
