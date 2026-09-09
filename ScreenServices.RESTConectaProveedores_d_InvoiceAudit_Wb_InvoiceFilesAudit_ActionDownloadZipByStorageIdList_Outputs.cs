using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_d_InvoiceAudit_Wb_InvoiceFilesAudit_ActionDownloadZipByStorageIdList_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("BinaryZIP")]
public byte[] outParamBinaryZIP;
[JsonProperty("ErrorMsg")]
public string outParamErrorMsg;


    public static RESTConectaProveedores_d_InvoiceAudit_Wb_InvoiceFilesAudit_ActionDownloadZipByStorageIdList_Outputs FromOutputs(IBehaviorsConfiguration conf, byte[] outParamBinaryZIP, string outParamErrorMsg) {RESTConectaProveedores_d_InvoiceAudit_Wb_InvoiceFilesAudit_ActionDownloadZipByStorageIdList_Outputs result = new RESTConectaProveedores_d_InvoiceAudit_Wb_InvoiceFilesAudit_ActionDownloadZipByStorageIdList_Outputs();
conf.IncludeBinariesURL = false;
result.outParamBinaryZIP = outParamBinaryZIP;
result.outParamErrorMsg = outParamErrorMsg;
return result;
}


    

    
}
