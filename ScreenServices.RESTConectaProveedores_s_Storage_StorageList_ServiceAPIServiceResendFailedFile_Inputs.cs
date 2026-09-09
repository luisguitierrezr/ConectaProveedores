using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_s_Storage_StorageList_ServiceAPIServiceResendFailedFile_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("StorageId")]
public long? inParamStorageId;


    public static RESTConectaProveedores_s_Storage_StorageList_ServiceAPIServiceResendFailedFile_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_s_Storage_StorageList_ServiceAPIServiceResendFailedFile_Inputs result = inputParameters.ToObject<RESTConectaProveedores_s_Storage_StorageList_ServiceAPIServiceResendFailedFile_Inputs>(settings);
return result;
}


    public ConectaProveedores_s_Storage_StorageList_ServiceAPIServiceResendFailedFile_Model ToModel() {ConectaProveedores_s_Storage_StorageList_ServiceAPIServiceResendFailedFile_Model result = new ConectaProveedores_s_Storage_StorageList_ServiceAPIServiceResendFailedFile_Model();
result.inParamStorageId = inParamStorageId == null ? 0L : inParamStorageId.Value;
return result;
}

}
