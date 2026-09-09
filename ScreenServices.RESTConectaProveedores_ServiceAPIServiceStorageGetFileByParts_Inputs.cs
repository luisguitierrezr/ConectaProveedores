using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_ServiceAPIServiceStorageGetFileByParts_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("i_StorageId")]
public long? inParami_StorageId;
[JsonProperty("i_ChunkNumber")]
public int? inParami_ChunkNumber;
[JsonProperty("i_TotalChunks")]
public int? inParami_TotalChunks;
[JsonProperty("i_Guid")]
public string inParami_Guid;


    public static RESTConectaProveedores_ServiceAPIServiceStorageGetFileByParts_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_ServiceAPIServiceStorageGetFileByParts_Inputs result = inputParameters.ToObject<RESTConectaProveedores_ServiceAPIServiceStorageGetFileByParts_Inputs>(settings);
return result;
}


    public ConectaProveedores_ServiceAPIServiceStorageGetFileByParts_Model ToModel() {ConectaProveedores_ServiceAPIServiceStorageGetFileByParts_Model result = new ConectaProveedores_ServiceAPIServiceStorageGetFileByParts_Model();
result.inParami_StorageId = inParami_StorageId == null ? 0L : inParami_StorageId.Value;
result.inParami_ChunkNumber = inParami_ChunkNumber == null ? 0 : inParami_ChunkNumber.Value;
result.inParami_TotalChunks = inParami_TotalChunks == null ? 0 : inParami_TotalChunks.Value;
result.inParami_Guid = inParami_Guid == null ? "" : inParami_Guid;
return result;
}

}
