using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_Wb_FolioSAEFilesPreview_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("FolioId")]
public long? inParamFolioId;
[JsonProperty("IsOpenPopupOtherFiles")]
public bool? varLcIsOpenPopupOtherFiles;
[JsonProperty("GetFolioFiles")]
public RESTConectaProveedores_j_FoliosSAE_Wb_FolioSAEFilesPreview_DataActionGetFolioFiles_Outputs varLcGetFolioFiles;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_j_FoliosSAE_Wb_FolioSAEFilesPreview_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_j_FoliosSAE_Wb_FolioSAEFilesPreview_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_j_FoliosSAE_Wb_FolioSAEFilesPreview_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_j_FoliosSAE_Wb_FolioSAEFilesPreview_ScreenModel ToModel() {long inParamFolioId = variables.inParamFolioId == null ? 0L : variables.inParamFolioId.Value;
bool varLcIsOpenPopupOtherFiles = variables.varLcIsOpenPopupOtherFiles == null ? false : variables.varLcIsOpenPopupOtherFiles.Value;
ConectaProveedores_j_FoliosSAE_Wb_FolioSAEFilesPreview_DataActionGetFolioFiles_Model _varLcGetFolioFiles = (variables.varLcGetFolioFiles != null) ? RESTConectaProveedores_j_FoliosSAE_Wb_FolioSAEFilesPreview_DataActionGetFolioFiles_Outputs.ToModel(variables.varLcGetFolioFiles) : null;
ConectaProveedores_j_FoliosSAE_Wb_FolioSAEFilesPreview_ScreenModel screenModel = new ConectaProveedores_j_FoliosSAE_Wb_FolioSAEFilesPreview_ScreenModel(inParamFolioId, varLcIsOpenPopupOtherFiles, _varLcGetFolioFiles, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
