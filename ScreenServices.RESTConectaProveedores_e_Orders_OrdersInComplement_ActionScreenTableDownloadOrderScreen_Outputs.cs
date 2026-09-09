using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_e_Orders_OrdersInComplement_ActionScreenTableDownloadOrderScreen_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("o_File")]
public ssConectaProveedores.RestRecords.RESTST_a158c76eb93396680623c04244f48b6cStructure outParamo_File;
[JsonProperty("o_StringListIds")]
public string outParamo_StringListIds;
[JsonProperty("o_ErrorMsg")]
public string outParamo_ErrorMsg;


    public static RESTConectaProveedores_e_Orders_OrdersInComplement_ActionScreenTableDownloadOrderScreen_Outputs FromOutputs(IBehaviorsConfiguration conf, ST_a158c76eb93396680623c04244f48b6cStructure outParamo_File, string outParamo_StringListIds, string outParamo_ErrorMsg) {RESTConectaProveedores_e_Orders_OrdersInComplement_ActionScreenTableDownloadOrderScreen_Outputs result = new RESTConectaProveedores_e_Orders_OrdersInComplement_ActionScreenTableDownloadOrderScreen_Outputs();
conf.IncludeBinariesURL = false;
// Write the needed fields of the record outParamo_File to the result.outParamo_File
result.outParamo_File = new ssConectaProveedores.RestRecords.RESTST_a158c76eb93396680623c04244f48b6cStructure();
result.outParamo_File.AttrName = outParamo_File.ssName;
result.outParamo_File.AttrBinaryData = outParamo_File.ssBinaryData;
// Write optimized result.outParamo_StringListIds
result.outParamo_StringListIds = "";
result.outParamo_ErrorMsg = outParamo_ErrorMsg;
return result;
}


    

    
}
