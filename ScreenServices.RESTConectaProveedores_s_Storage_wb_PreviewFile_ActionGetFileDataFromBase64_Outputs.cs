using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_s_Storage_wb_PreviewFile_ActionGetFileDataFromBase64_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("o_Binary")]
public byte[] outParamo_Binary;
[JsonProperty("o_xml")]
public string outParamo_xml;


    public static RESTConectaProveedores_s_Storage_wb_PreviewFile_ActionGetFileDataFromBase64_Outputs FromOutputs(IBehaviorsConfiguration conf, byte[] outParamo_Binary, string outParamo_xml) {RESTConectaProveedores_s_Storage_wb_PreviewFile_ActionGetFileDataFromBase64_Outputs result = new RESTConectaProveedores_s_Storage_wb_PreviewFile_ActionGetFileDataFromBase64_Outputs();
conf.IncludeBinariesURL = false;
result.outParamo_Binary = outParamo_Binary;
result.outParamo_xml = outParamo_xml;
return result;
}


    

    
}
