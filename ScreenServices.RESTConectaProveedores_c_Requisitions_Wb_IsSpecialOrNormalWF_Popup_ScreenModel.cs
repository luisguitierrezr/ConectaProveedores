using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_c_Requisitions_Wb_IsSpecialOrNormalWF_Popup_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("ProcessTypeCode")]
public string inParamProcessTypeCode;
[JsonProperty("IsDonation")]
public bool? inParamIsDonation;
[JsonProperty("l_IsBusy")]
public bool? varLcl_IsBusy;
[JsonProperty("l_FirstApproverUserId")]
public string varLcl_FirstApproverUserId;
[JsonProperty("l_SpecialWorkflowSelected")]
public ssConectaProveedores.RestRecords.RESTRC_e05385e784b7ab877b391b661988aada varLcl_SpecialWorkflowSelected;
[JsonProperty("GetFirstApproverList")]
public RESTConectaProveedores_c_Requisitions_Wb_IsSpecialOrNormalWF_Popup_DataActionGetFirstApproverList_Outputs varLcGetFirstApproverList;
[JsonProperty("GetSettings")]
public RESTConectaProveedores_c_Requisitions_Wb_IsSpecialOrNormalWF_Popup_DataActionGetSettings_Outputs varLcGetSettings;
[JsonProperty("GetSpecialWorkflows")]
public RESTConectaProveedores_c_Requisitions_Wb_IsSpecialOrNormalWF_Popup_DataActionGetSpecialWorkflows_Outputs varLcGetSpecialWorkflows;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_c_Requisitions_Wb_IsSpecialOrNormalWF_Popup_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_c_Requisitions_Wb_IsSpecialOrNormalWF_Popup_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_c_Requisitions_Wb_IsSpecialOrNormalWF_Popup_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_c_Requisitions_Wb_IsSpecialOrNormalWF_Popup_ScreenModel ToModel() {string inParamProcessTypeCode = variables.inParamProcessTypeCode == null ? "" : variables.inParamProcessTypeCode;
bool inParamIsDonation = variables.inParamIsDonation == null ? false : variables.inParamIsDonation.Value;
bool varLcl_IsBusy = variables.varLcl_IsBusy == null ? false : variables.varLcl_IsBusy.Value;
string varLcl_FirstApproverUserId = variables.varLcl_FirstApproverUserId == null ? "" : variables.varLcl_FirstApproverUserId;
RC_e05385e784b7ab877b391b661988aada varLcl_SpecialWorkflowSelected = ssConectaProveedores.RestRecords.RESTRC_e05385e784b7ab877b391b661988aada.ToStructure(variables.varLcl_SpecialWorkflowSelected);
ConectaProveedores_c_Requisitions_Wb_IsSpecialOrNormalWF_Popup_DataActionGetFirstApproverList_Model _varLcGetFirstApproverList = (variables.varLcGetFirstApproverList != null) ? RESTConectaProveedores_c_Requisitions_Wb_IsSpecialOrNormalWF_Popup_DataActionGetFirstApproverList_Outputs.ToModel(variables.varLcGetFirstApproverList) : null;
ConectaProveedores_c_Requisitions_Wb_IsSpecialOrNormalWF_Popup_DataActionGetSettings_Model _varLcGetSettings = (variables.varLcGetSettings != null) ? RESTConectaProveedores_c_Requisitions_Wb_IsSpecialOrNormalWF_Popup_DataActionGetSettings_Outputs.ToModel(variables.varLcGetSettings) : null;
ConectaProveedores_c_Requisitions_Wb_IsSpecialOrNormalWF_Popup_DataActionGetSpecialWorkflows_Model _varLcGetSpecialWorkflows = (variables.varLcGetSpecialWorkflows != null) ? RESTConectaProveedores_c_Requisitions_Wb_IsSpecialOrNormalWF_Popup_DataActionGetSpecialWorkflows_Outputs.ToModel(variables.varLcGetSpecialWorkflows) : null;
ConectaProveedores_c_Requisitions_Wb_IsSpecialOrNormalWF_Popup_ScreenModel screenModel = new ConectaProveedores_c_Requisitions_Wb_IsSpecialOrNormalWF_Popup_ScreenModel(inParamProcessTypeCode, inParamIsDonation, varLcl_IsBusy, varLcl_FirstApproverUserId, varLcl_SpecialWorkflowSelected, _varLcGetFirstApproverList, _varLcGetSettings, _varLcGetSpecialWorkflows, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
