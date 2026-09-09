using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_Wb_SupportSAEUploadSingleFile_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetSupplierUsersByUserId")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_187912d0df64c67be181be3d4f7af5f3> ScreenDataSetGetSupplierUsersByUserId;
[JsonProperty("FilesList")]
public RestList<ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure> varLcFilesList;
[JsonProperty("l_File")]
public ssConectaProveedores.RestRecords.RESTST_1d6498da9105fbe815a7f766352917c0Structure varLcl_File;
[JsonProperty("AreFilesUploaded")]
public bool? varLcAreFilesUploaded;
[JsonProperty("l_FileEmpty")]
public ssConectaProveedores.RestRecords.RESTST_1d6498da9105fbe815a7f766352917c0Structure varLcl_FileEmpty;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_j_FoliosSAE_Wb_SupportSAEUploadSingleFile_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_j_FoliosSAE_Wb_SupportSAEUploadSingleFile_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_j_FoliosSAE_Wb_SupportSAEUploadSingleFile_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_j_FoliosSAE_Wb_SupportSAEUploadSingleFile_ScreenModel ToModel() {RL_1501ee54ff868a67eff67465502ee3d9 varLcFilesList = RL_1501ee54ff868a67eff67465502ee3d9.FromRestList(variables.varLcFilesList, ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure.ToStructure);
ST_1d6498da9105fbe815a7f766352917c0Structure varLcl_File = ssConectaProveedores.RestRecords.RESTST_1d6498da9105fbe815a7f766352917c0Structure.ToStructure(variables.varLcl_File);
bool varLcAreFilesUploaded = variables.varLcAreFilesUploaded == null ? false : variables.varLcAreFilesUploaded.Value;
ST_1d6498da9105fbe815a7f766352917c0Structure varLcl_FileEmpty = ssConectaProveedores.RestRecords.RESTST_1d6498da9105fbe815a7f766352917c0Structure.ToStructure(variables.varLcl_FileEmpty);
AggregateRecord<RL_5a0829a2b3c6573471cd9bfcbf323787> _ScreenDataSetGetSupplierUsersByUserId = (variables.ScreenDataSetGetSupplierUsersByUserId != null) ? variables.ScreenDataSetGetSupplierUsersByUserId.FromJS((array) => {
return RL_5a0829a2b3c6573471cd9bfcbf323787.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_187912d0df64c67be181be3d4f7af5f3.ToStructure);
}
) : null;
ConectaProveedores_j_FoliosSAE_Wb_SupportSAEUploadSingleFile_ScreenModel screenModel = new ConectaProveedores_j_FoliosSAE_Wb_SupportSAEUploadSingleFile_ScreenModel(varLcFilesList, varLcl_File, varLcAreFilesUploaded, varLcl_FileEmpty, _ScreenDataSetGetSupplierUsersByUserId, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
