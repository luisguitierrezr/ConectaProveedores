using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_y_Utils_Wb_CancelFolioPopup_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetFolioApprovalLevels")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_e40e190961051a83f0f95a5985af6cdd> ScreenDataSetGetFolioApprovalLevels;
[JsonProperty("GetFolioById")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_b668eee4846e2937101a51355804499d> ScreenDataSetGetFolioById;
[JsonProperty("FolioId")]
public long? inParamFolioId;
[JsonProperty("FolioReject")]
public ssConectaProveedores.RestRecords.RESTST_e54bcdc56c6f092fdfed672ad024bfa4Structure varLcFolioReject;
[JsonProperty("IsExecuting")]
public bool? varLcIsExecuting;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_y_Utils_Wb_CancelFolioPopup_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_y_Utils_Wb_CancelFolioPopup_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_y_Utils_Wb_CancelFolioPopup_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_y_Utils_Wb_CancelFolioPopup_ScreenModel ToModel() {long inParamFolioId = variables.inParamFolioId == null ? 0L : variables.inParamFolioId.Value;
ST_e54bcdc56c6f092fdfed672ad024bfa4Structure varLcFolioReject = ssConectaProveedores.RestRecords.RESTST_e54bcdc56c6f092fdfed672ad024bfa4Structure.ToStructure(variables.varLcFolioReject);
bool varLcIsExecuting = variables.varLcIsExecuting == null ? false : variables.varLcIsExecuting.Value;
AggregateRecord<RL_a811b54d11345a2c46a0dc7830ffa1de> _ScreenDataSetGetFolioApprovalLevels = (variables.ScreenDataSetGetFolioApprovalLevels != null) ? variables.ScreenDataSetGetFolioApprovalLevels.FromJS((array) => {
return RL_a811b54d11345a2c46a0dc7830ffa1de.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_e40e190961051a83f0f95a5985af6cdd.ToStructure);
}
) : null;
AggregateRecord<RL_d94294de88e7b9437b2238f21bdccaff> _ScreenDataSetGetFolioById = (variables.ScreenDataSetGetFolioById != null) ? variables.ScreenDataSetGetFolioById.FromJS((array) => {
return RL_d94294de88e7b9437b2238f21bdccaff.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_b668eee4846e2937101a51355804499d.ToStructure);
}
) : null;
ConectaProveedores_y_Utils_Wb_CancelFolioPopup_ScreenModel screenModel = new ConectaProveedores_y_Utils_Wb_CancelFolioPopup_ScreenModel(inParamFolioId, varLcFolioReject, varLcIsExecuting, _ScreenDataSetGetFolioApprovalLevels, _ScreenDataSetGetFolioById, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
