using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_y_Utils_Wb_CustomFileUpload_ServiceAPIServiceStorageGetFile_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("o_File")]
public byte[] outParamo_File;
[JsonProperty("o_filename")]
public string outParamo_filename;


    public static RESTConectaProveedores_y_Utils_Wb_CustomFileUpload_ServiceAPIServiceStorageGetFile_Outputs FromOutputs(IBehaviorsConfiguration conf, byte[] outParamo_File, string outParamo_filename) {RESTConectaProveedores_y_Utils_Wb_CustomFileUpload_ServiceAPIServiceStorageGetFile_Outputs result = new RESTConectaProveedores_y_Utils_Wb_CustomFileUpload_ServiceAPIServiceStorageGetFile_Outputs();
conf.IncludeBinariesURL = false;
result.outParamo_File = outParamo_File;
result.outParamo_filename = outParamo_filename;
return result;
}


    

    
}
