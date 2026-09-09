using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_ServiceAPIServiceStorageGetFileByParts_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("o_File")]
public byte[] outParamo_File;
[JsonProperty("o_filename")]
public string outParamo_filename;
[JsonProperty("o_fileInText")]
public string outParamo_fileInText;
[JsonProperty("IsBinary")]
public bool? outParamIsBinary;


    public static RESTConectaProveedores_ServiceAPIServiceStorageGetFileByParts_Outputs FromOutputs(IBehaviorsConfiguration conf, byte[] outParamo_File, string outParamo_filename, string outParamo_fileInText, bool outParamIsBinary) {RESTConectaProveedores_ServiceAPIServiceStorageGetFileByParts_Outputs result = new RESTConectaProveedores_ServiceAPIServiceStorageGetFileByParts_Outputs();
conf.IncludeBinariesURL = false;
// Write optimized result.outParamo_File
result.outParamo_File = new byte[] {};
// Write optimized result.outParamo_filename
result.outParamo_filename = "";
result.outParamo_fileInText = outParamo_fileInText;
// Write optimized result.outParamIsBinary
result.outParamIsBinary = (bool?) false;
return result;
}


    

    
}
