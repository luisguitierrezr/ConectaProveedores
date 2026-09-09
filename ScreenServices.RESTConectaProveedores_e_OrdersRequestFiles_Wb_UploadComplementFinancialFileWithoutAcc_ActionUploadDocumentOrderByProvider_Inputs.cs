using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementFinancialFileWithoutAcc_ActionUploadDocumentOrderByProvider_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("i_RequestFileId")]
public long? inParami_RequestFileId;
[JsonProperty("i_OrderMainId")]
public long? inParami_OrderMainId;
[JsonProperty("I_FilesList")]
public RestList<ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure> inParamI_FilesList;
[JsonProperty("i_FilesListExtra")]
public RestList<ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure> inParami_FilesListExtra;
[JsonProperty("i_InvoiceForeign")]
public ssConectaProveedores.RestRecords.RESTST_6f620840109ac6f721328b723ec0152cStructure inParami_InvoiceForeign;
[JsonProperty("i_OrderAccConceptsId")]
public long? inParami_OrderAccConceptsId;
[JsonProperty("i_CreateRequestFile")]
public bool? inParami_CreateRequestFile;
[JsonProperty("OffsetUtc")]
public int? inParamOffsetUtc;


    public static RESTConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementFinancialFileWithoutAcc_ActionUploadDocumentOrderByProvider_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementFinancialFileWithoutAcc_ActionUploadDocumentOrderByProvider_Inputs result = inputParameters.ToObject<RESTConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementFinancialFileWithoutAcc_ActionUploadDocumentOrderByProvider_Inputs>(settings);
return result;
}


    public ConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementFinancialFileWithoutAcc_ActionUploadDocumentOrderByProvider_Model ToModel() {ConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementFinancialFileWithoutAcc_ActionUploadDocumentOrderByProvider_Model result = new ConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementFinancialFileWithoutAcc_ActionUploadDocumentOrderByProvider_Model();
result.inParami_RequestFileId = inParami_RequestFileId == null ? 0L : inParami_RequestFileId.Value;
result.inParami_OrderMainId = inParami_OrderMainId == null ? 0L : inParami_OrderMainId.Value;
result.inParamI_FilesList = RL_1501ee54ff868a67eff67465502ee3d9.FromRestList(inParamI_FilesList, ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure.ToStructure);
result.inParami_FilesListExtra = RL_1501ee54ff868a67eff67465502ee3d9.FromRestList(inParami_FilesListExtra, ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure.ToStructure);
result.inParami_InvoiceForeign = ssConectaProveedores.RestRecords.RESTST_6f620840109ac6f721328b723ec0152cStructure.ToStructure(inParami_InvoiceForeign);
result.inParami_OrderAccConceptsId = inParami_OrderAccConceptsId == null ? 0L : inParami_OrderAccConceptsId.Value;
result.inParami_CreateRequestFile = inParami_CreateRequestFile == null ? false : inParami_CreateRequestFile.Value;
result.inParamOffsetUtc = inParamOffsetUtc == null ? 0 : inParamOffsetUtc.Value;
return result;
}

}
