using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_z_Hotfix_HotfixOrderApprover_ActionHotfixOrderApproverReplaceAll_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("UserOriginal")]
public string inParamUserOriginal;
[JsonProperty("UserSubstitute")]
public string inParamUserSubstitute;
[JsonProperty("OrderNumberFilter")]
public string inParamOrderNumberFilter;
[JsonProperty("OrderStatusId")]
public int? inParamOrderStatusId;


    public static RESTConectaProveedores_z_Hotfix_HotfixOrderApprover_ActionHotfixOrderApproverReplaceAll_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_z_Hotfix_HotfixOrderApprover_ActionHotfixOrderApproverReplaceAll_Inputs result = inputParameters.ToObject<RESTConectaProveedores_z_Hotfix_HotfixOrderApprover_ActionHotfixOrderApproverReplaceAll_Inputs>(settings);
return result;
}


    public ConectaProveedores_z_Hotfix_HotfixOrderApprover_ActionHotfixOrderApproverReplaceAll_Model ToModel() {ConectaProveedores_z_Hotfix_HotfixOrderApprover_ActionHotfixOrderApproverReplaceAll_Model result = new ConectaProveedores_z_Hotfix_HotfixOrderApprover_ActionHotfixOrderApproverReplaceAll_Model();
result.inParamUserOriginal = inParamUserOriginal == null ? "" : inParamUserOriginal;
result.inParamUserSubstitute = inParamUserSubstitute == null ? "" : inParamUserSubstitute;
result.inParamOrderNumberFilter = inParamOrderNumberFilter == null ? "" : inParamOrderNumberFilter;
result.inParamOrderStatusId = inParamOrderStatusId == null ? 0 : inParamOrderStatusId.Value;
return result;
}

}
