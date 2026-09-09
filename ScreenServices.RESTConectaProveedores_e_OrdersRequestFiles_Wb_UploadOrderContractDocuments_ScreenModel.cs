using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_e_OrdersRequestFiles_Wb_UploadOrderContractDocuments_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetOrderContractFileById")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_f6cad939346a2d641ae33c13dbcb8a70> ScreenDataSetGetOrderContractFileById;
[JsonProperty("i_OrderMainId")]
public long? inParami_OrderMainId;
[JsonProperty("i_OrderContractFile")]
public long? inParami_OrderContractFile;
[JsonProperty("i_OrderRequestFileId")]
public long? inParami_OrderRequestFileId;
[JsonProperty("InvoiceForeign")]
public ssConectaProveedores.RestRecords.RESTST_6f620840109ac6f721328b723ec0152cStructure varLcInvoiceForeign;
[JsonProperty("AreFilesUploaded")]
public bool? varLcAreFilesUploaded;
[JsonProperty("FilesList")]
public RestList<ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure> varLcFilesList;
[JsonProperty("l_File")]
public ssConectaProveedores.RestRecords.RESTST_1d6498da9105fbe815a7f766352917c0Structure varLcl_File;
[JsonProperty("l_FileEmpty")]
public ssConectaProveedores.RestRecords.RESTST_1d6498da9105fbe815a7f766352917c0Structure varLcl_FileEmpty;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_e_OrdersRequestFiles_Wb_UploadOrderContractDocuments_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_e_OrdersRequestFiles_Wb_UploadOrderContractDocuments_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_e_OrdersRequestFiles_Wb_UploadOrderContractDocuments_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_e_OrdersRequestFiles_Wb_UploadOrderContractDocuments_ScreenModel ToModel() {long inParami_OrderMainId = variables.inParami_OrderMainId == null ? 0L : variables.inParami_OrderMainId.Value;
long inParami_OrderContractFile = variables.inParami_OrderContractFile == null ? 0L : variables.inParami_OrderContractFile.Value;
long inParami_OrderRequestFileId = variables.inParami_OrderRequestFileId == null ? 0L : variables.inParami_OrderRequestFileId.Value;
ST_6f620840109ac6f721328b723ec0152cStructure varLcInvoiceForeign = ssConectaProveedores.RestRecords.RESTST_6f620840109ac6f721328b723ec0152cStructure.ToStructure(variables.varLcInvoiceForeign);
bool varLcAreFilesUploaded = variables.varLcAreFilesUploaded == null ? false : variables.varLcAreFilesUploaded.Value;
RL_1501ee54ff868a67eff67465502ee3d9 varLcFilesList = RL_1501ee54ff868a67eff67465502ee3d9.FromRestList(variables.varLcFilesList, ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure.ToStructure);
ST_1d6498da9105fbe815a7f766352917c0Structure varLcl_File = ssConectaProveedores.RestRecords.RESTST_1d6498da9105fbe815a7f766352917c0Structure.ToStructure(variables.varLcl_File);
ST_1d6498da9105fbe815a7f766352917c0Structure varLcl_FileEmpty = ssConectaProveedores.RestRecords.RESTST_1d6498da9105fbe815a7f766352917c0Structure.ToStructure(variables.varLcl_FileEmpty);
AggregateRecord<RL_978260cdc25ae86bbfc7a02b4fbbd8c3> _ScreenDataSetGetOrderContractFileById = (variables.ScreenDataSetGetOrderContractFileById != null) ? variables.ScreenDataSetGetOrderContractFileById.FromJS((array) => {
return RL_978260cdc25ae86bbfc7a02b4fbbd8c3.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_f6cad939346a2d641ae33c13dbcb8a70.ToStructure);
}
) : null;
ConectaProveedores_e_OrdersRequestFiles_Wb_UploadOrderContractDocuments_ScreenModel screenModel = new ConectaProveedores_e_OrdersRequestFiles_Wb_UploadOrderContractDocuments_ScreenModel(inParami_OrderMainId, inParami_OrderContractFile, inParami_OrderRequestFileId, varLcInvoiceForeign, varLcAreFilesUploaded, varLcFilesList, varLcl_File, varLcl_FileEmpty, _ScreenDataSetGetOrderContractFileById, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
