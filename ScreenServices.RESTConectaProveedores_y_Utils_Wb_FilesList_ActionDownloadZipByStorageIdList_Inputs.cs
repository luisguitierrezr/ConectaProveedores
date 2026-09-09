using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_y_Utils_Wb_FilesList_ActionDownloadZipByStorageIdList_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("StorageIdList")]
public RestList<long> inParamStorageIdList;


    public static RESTConectaProveedores_y_Utils_Wb_FilesList_ActionDownloadZipByStorageIdList_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_y_Utils_Wb_FilesList_ActionDownloadZipByStorageIdList_Inputs result = inputParameters.ToObject<RESTConectaProveedores_y_Utils_Wb_FilesList_ActionDownloadZipByStorageIdList_Inputs>(settings);
return result;
}


    public ConectaProveedores_y_Utils_Wb_FilesList_ActionDownloadZipByStorageIdList_Model ToModel() {ConectaProveedores_y_Utils_Wb_FilesList_ActionDownloadZipByStorageIdList_Model result = new ConectaProveedores_y_Utils_Wb_FilesList_ActionDownloadZipByStorageIdList_Model();
result.inParamStorageIdList = BasicTypeList<long>.FromRestList(inParamStorageIdList);
return result;
}

}
