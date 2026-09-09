using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_c_Proveedor_AccountStatus_ActionGenerateCurrentAccountPdf_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("o_file")]
public byte[] outParamo_file;


    public static RESTConectaProveedores_c_Proveedor_AccountStatus_ActionGenerateCurrentAccountPdf_Outputs FromOutputs(IBehaviorsConfiguration conf, byte[] outParamo_file) {RESTConectaProveedores_c_Proveedor_AccountStatus_ActionGenerateCurrentAccountPdf_Outputs result = new RESTConectaProveedores_c_Proveedor_AccountStatus_ActionGenerateCurrentAccountPdf_Outputs();
conf.IncludeBinariesURL = false;
result.outParamo_file = outParamo_file;
return result;
}


    

    
}
