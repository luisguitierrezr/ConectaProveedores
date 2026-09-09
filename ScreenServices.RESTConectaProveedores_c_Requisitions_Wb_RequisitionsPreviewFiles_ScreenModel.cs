using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewFiles_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("i_RequisitionId")]
public long? inParami_RequisitionId;
[JsonProperty("l_IsOpenPopupOtherFiles")]
public bool? varLcl_IsOpenPopupOtherFiles;
[JsonProperty("GetFilesByRequisitionId")]
public RESTConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewFiles_DataActionGetFilesByRequisitionId_Outputs varLcGetFilesByRequisitionId;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewFiles_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewFiles_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewFiles_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewFiles_ScreenModel ToModel() {long inParami_RequisitionId = variables.inParami_RequisitionId == null ? 0L : variables.inParami_RequisitionId.Value;
bool varLcl_IsOpenPopupOtherFiles = variables.varLcl_IsOpenPopupOtherFiles == null ? false : variables.varLcl_IsOpenPopupOtherFiles.Value;
ConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewFiles_DataActionGetFilesByRequisitionId_Model _varLcGetFilesByRequisitionId = (variables.varLcGetFilesByRequisitionId != null) ? RESTConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewFiles_DataActionGetFilesByRequisitionId_Outputs.ToModel(variables.varLcGetFilesByRequisitionId) : null;
ConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewFiles_ScreenModel screenModel = new ConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewFiles_ScreenModel(inParami_RequisitionId, varLcl_IsOpenPopupOtherFiles, _varLcGetFilesByRequisitionId, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
