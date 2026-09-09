using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_Wb_SAECFilesPreview_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("i_FolioId")]
public long? inParami_FolioId;
[JsonProperty("i_FolioNumber")]
public string inParami_FolioNumber;
[JsonProperty("l_File")]
public ssConectaProveedores.RestRecords.RESTST_a158c76eb93396680623c04244f48b6cStructure varLcl_File;
[JsonProperty("l_ShowPopupUpload")]
public bool? varLcl_ShowPopupUpload;
[JsonProperty("GetFolioFiles")]
public RESTConectaProveedores_j_FoliosSAE_Wb_SAECFilesPreview_DataActionGetFolioFiles_Outputs varLcGetFolioFiles;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_j_FoliosSAE_Wb_SAECFilesPreview_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_j_FoliosSAE_Wb_SAECFilesPreview_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_j_FoliosSAE_Wb_SAECFilesPreview_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_j_FoliosSAE_Wb_SAECFilesPreview_ScreenModel ToModel() {long inParami_FolioId = variables.inParami_FolioId == null ? 0L : variables.inParami_FolioId.Value;
string inParami_FolioNumber = variables.inParami_FolioNumber == null ? "" : variables.inParami_FolioNumber;
ST_a158c76eb93396680623c04244f48b6cStructure varLcl_File = ssConectaProveedores.RestRecords.RESTST_a158c76eb93396680623c04244f48b6cStructure.ToStructure(variables.varLcl_File);
bool varLcl_ShowPopupUpload = variables.varLcl_ShowPopupUpload == null ? false : variables.varLcl_ShowPopupUpload.Value;
ConectaProveedores_j_FoliosSAE_Wb_SAECFilesPreview_DataActionGetFolioFiles_Model _varLcGetFolioFiles = (variables.varLcGetFolioFiles != null) ? RESTConectaProveedores_j_FoliosSAE_Wb_SAECFilesPreview_DataActionGetFolioFiles_Outputs.ToModel(variables.varLcGetFolioFiles) : null;
ConectaProveedores_j_FoliosSAE_Wb_SAECFilesPreview_ScreenModel screenModel = new ConectaProveedores_j_FoliosSAE_Wb_SAECFilesPreview_ScreenModel(inParami_FolioId, inParami_FolioNumber, varLcl_File, varLcl_ShowPopupUpload, _varLcGetFolioFiles, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
