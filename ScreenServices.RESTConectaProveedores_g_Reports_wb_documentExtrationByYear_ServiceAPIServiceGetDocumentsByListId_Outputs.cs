using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_g_Reports_wb_documentExtrationByYear_ServiceAPIServiceGetDocumentsByListId_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("BinaryZip")]
public byte[] outParamBinaryZip;


    public static RESTConectaProveedores_g_Reports_wb_documentExtrationByYear_ServiceAPIServiceGetDocumentsByListId_Outputs FromOutputs(IBehaviorsConfiguration conf, byte[] outParamBinaryZip) {RESTConectaProveedores_g_Reports_wb_documentExtrationByYear_ServiceAPIServiceGetDocumentsByListId_Outputs result = new RESTConectaProveedores_g_Reports_wb_documentExtrationByYear_ServiceAPIServiceGetDocumentsByListId_Outputs();
conf.IncludeBinariesURL = false;
result.outParamBinaryZip = outParamBinaryZip;
return result;
}


    

    
}
