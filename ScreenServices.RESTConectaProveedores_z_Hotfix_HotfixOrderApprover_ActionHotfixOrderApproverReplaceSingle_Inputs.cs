using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_z_Hotfix_HotfixOrderApprover_ActionHotfixOrderApproverReplaceSingle_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("UserOriginal")]
public string inParamUserOriginal;
[JsonProperty("UserSubstitute")]
public string inParamUserSubstitute;
[JsonProperty("OrderApprovalLevelIdSelected")]
public long? inParamOrderApprovalLevelIdSelected;


    public static RESTConectaProveedores_z_Hotfix_HotfixOrderApprover_ActionHotfixOrderApproverReplaceSingle_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_z_Hotfix_HotfixOrderApprover_ActionHotfixOrderApproverReplaceSingle_Inputs result = inputParameters.ToObject<RESTConectaProveedores_z_Hotfix_HotfixOrderApprover_ActionHotfixOrderApproverReplaceSingle_Inputs>(settings);
return result;
}


    public ConectaProveedores_z_Hotfix_HotfixOrderApprover_ActionHotfixOrderApproverReplaceSingle_Model ToModel() {ConectaProveedores_z_Hotfix_HotfixOrderApprover_ActionHotfixOrderApproverReplaceSingle_Model result = new ConectaProveedores_z_Hotfix_HotfixOrderApprover_ActionHotfixOrderApproverReplaceSingle_Model();
result.inParamUserOriginal = inParamUserOriginal == null ? "" : inParamUserOriginal;
result.inParamUserSubstitute = inParamUserSubstitute == null ? "" : inParamUserSubstitute;
result.inParamOrderApprovalLevelIdSelected = inParamOrderApprovalLevelIdSelected == null ? 0L : inParamOrderApprovalLevelIdSelected.Value;
return result;
}

}
