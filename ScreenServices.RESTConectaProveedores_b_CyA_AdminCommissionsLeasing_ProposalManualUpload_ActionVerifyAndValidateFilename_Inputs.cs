using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalManualUpload_ActionVerifyAndValidateFilename_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("i_Filename")]
public string inParami_Filename;
[JsonProperty("i_IsCommission")]
public bool? inParami_IsCommission;
[JsonProperty("i_IsComissionUnknown")]
public bool? inParami_IsComissionUnknown;
[JsonProperty("i_Binary")]
public byte[] inParami_Binary;


    public static RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalManualUpload_ActionVerifyAndValidateFilename_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalManualUpload_ActionVerifyAndValidateFilename_Inputs result = inputParameters.ToObject<RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalManualUpload_ActionVerifyAndValidateFilename_Inputs>(settings);
return result;
}


    public ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalManualUpload_ActionVerifyAndValidateFilename_Model ToModel() {ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalManualUpload_ActionVerifyAndValidateFilename_Model result = new ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalManualUpload_ActionVerifyAndValidateFilename_Model();
result.inParami_Filename = inParami_Filename == null ? "" : inParami_Filename;
result.inParami_IsCommission = inParami_IsCommission == null ? false : inParami_IsCommission.Value;
result.inParami_IsComissionUnknown = inParami_IsComissionUnknown == null ? false : inParami_IsComissionUnknown.Value;
result.inParami_Binary = inParami_Binary == null ? new byte[] {} : inParami_Binary;
return result;
}

}
