using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_y_Utils_Wb_CustomFileUpload_ServiceAPIServiceStorageGetFile_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("i_StorageId")]
public long? inParami_StorageId;


    public static RESTConectaProveedores_y_Utils_Wb_CustomFileUpload_ServiceAPIServiceStorageGetFile_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_y_Utils_Wb_CustomFileUpload_ServiceAPIServiceStorageGetFile_Inputs result = inputParameters.ToObject<RESTConectaProveedores_y_Utils_Wb_CustomFileUpload_ServiceAPIServiceStorageGetFile_Inputs>(settings);
return result;
}


    public ConectaProveedores_y_Utils_Wb_CustomFileUpload_ServiceAPIServiceStorageGetFile_Model ToModel() {ConectaProveedores_y_Utils_Wb_CustomFileUpload_ServiceAPIServiceStorageGetFile_Model result = new ConectaProveedores_y_Utils_Wb_CustomFileUpload_ServiceAPIServiceStorageGetFile_Model();
result.inParami_StorageId = inParami_StorageId == null ? 0L : inParami_StorageId.Value;
return result;
}

}
