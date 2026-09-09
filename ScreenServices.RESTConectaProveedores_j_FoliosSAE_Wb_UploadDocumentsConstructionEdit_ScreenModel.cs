using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_Wb_UploadDocumentsConstructionEdit_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("List")]
public RestList<ssConectaProveedores.RestRecords.RESTST_e2ce4ef6ecd16e4be5db908d06bb6674Structure> inParamList;
[JsonProperty("OrderNumber")]
public string inParamOrderNumber;
[JsonProperty("FilesList")]
public RestList<ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure> inParamFilesList;
[JsonProperty("i_FolioId")]
public long? inParami_FolioId;
[JsonProperty("ErrorMsg")]
public string varLcErrorMsg;
[JsonProperty("ListAux")]
public RestList<ssConectaProveedores.RestRecords.RESTST_b2fd0f57faec93f17ef861f417f1cd5cStructure> varLcListAux;
[JsonProperty("l_ErrorMsgAlreadySent")]
public bool? varLcl_ErrorMsgAlreadySent;
[JsonProperty("GetApprover")]
public RESTConectaProveedores_j_FoliosSAE_Wb_UploadDocumentsConstructionEdit_DataActionGetApprover_Outputs varLcGetApprover;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_j_FoliosSAE_Wb_UploadDocumentsConstructionEdit_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_j_FoliosSAE_Wb_UploadDocumentsConstructionEdit_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_j_FoliosSAE_Wb_UploadDocumentsConstructionEdit_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_j_FoliosSAE_Wb_UploadDocumentsConstructionEdit_ScreenModel ToModel() {RL_9fb5c5e988576f6c521a9ef779213183 inParamList = RL_9fb5c5e988576f6c521a9ef779213183.FromRestList(variables.inParamList, ssConectaProveedores.RestRecords.RESTST_e2ce4ef6ecd16e4be5db908d06bb6674Structure.ToStructure);
string inParamOrderNumber = variables.inParamOrderNumber == null ? "" : variables.inParamOrderNumber;
RL_1501ee54ff868a67eff67465502ee3d9 inParamFilesList = RL_1501ee54ff868a67eff67465502ee3d9.FromRestList(variables.inParamFilesList, ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure.ToStructure);
long inParami_FolioId = variables.inParami_FolioId == null ? 0L : variables.inParami_FolioId.Value;
string varLcErrorMsg = variables.varLcErrorMsg == null ? "" : variables.varLcErrorMsg;
RL_f4c5cb6ef02fae333513cbd4dafd500c varLcListAux = RL_f4c5cb6ef02fae333513cbd4dafd500c.FromRestList(variables.varLcListAux, ssConectaProveedores.RestRecords.RESTST_b2fd0f57faec93f17ef861f417f1cd5cStructure.ToStructure);
bool varLcl_ErrorMsgAlreadySent = variables.varLcl_ErrorMsgAlreadySent == null ? false : variables.varLcl_ErrorMsgAlreadySent.Value;
ConectaProveedores_j_FoliosSAE_Wb_UploadDocumentsConstructionEdit_DataActionGetApprover_Model _varLcGetApprover = (variables.varLcGetApprover != null) ? RESTConectaProveedores_j_FoliosSAE_Wb_UploadDocumentsConstructionEdit_DataActionGetApprover_Outputs.ToModel(variables.varLcGetApprover) : null;
ConectaProveedores_j_FoliosSAE_Wb_UploadDocumentsConstructionEdit_ScreenModel screenModel = new ConectaProveedores_j_FoliosSAE_Wb_UploadDocumentsConstructionEdit_ScreenModel(inParamList, inParamOrderNumber, inParamFilesList, inParami_FolioId, varLcErrorMsg, varLcListAux, varLcl_ErrorMsgAlreadySent, _varLcGetApprover, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
