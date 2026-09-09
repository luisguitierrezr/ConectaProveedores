using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementFile_ActionUploadDocumentOrderByProvider_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("InvoiceId")]
public long? outParamInvoiceId;
[JsonProperty("StorageId")]
public long? outParamStorageId;


    public static RESTConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementFile_ActionUploadDocumentOrderByProvider_Outputs FromOutputs(IBehaviorsConfiguration conf, long outParamInvoiceId, long outParamStorageId) {RESTConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementFile_ActionUploadDocumentOrderByProvider_Outputs result = new RESTConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementFile_ActionUploadDocumentOrderByProvider_Outputs();
conf.IncludeBinariesURL = false;
// Write optimized result.outParamInvoiceId
result.outParamInvoiceId = (long?) 0L;
// Write optimized result.outParamStorageId
result.outParamStorageId = (long?) 0L;
return result;
}


    

    
}
