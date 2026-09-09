using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_Wb_FoliosContabilizationInvoiceSAPStatus_ActionDownloadInvoiceFiles_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("BinaryZIP")]
public byte[] outParamBinaryZIP;
[JsonProperty("ErrorMsg")]
public string outParamErrorMsg;


    public static RESTConectaProveedores_j_FoliosSAE_Wb_FoliosContabilizationInvoiceSAPStatus_ActionDownloadInvoiceFiles_Outputs FromOutputs(IBehaviorsConfiguration conf, byte[] outParamBinaryZIP, string outParamErrorMsg) {RESTConectaProveedores_j_FoliosSAE_Wb_FoliosContabilizationInvoiceSAPStatus_ActionDownloadInvoiceFiles_Outputs result = new RESTConectaProveedores_j_FoliosSAE_Wb_FoliosContabilizationInvoiceSAPStatus_ActionDownloadInvoiceFiles_Outputs();
conf.IncludeBinariesURL = false;
result.outParamBinaryZIP = outParamBinaryZIP;
// Write optimized result.outParamErrorMsg
result.outParamErrorMsg = "";
return result;
}


    

    
}
