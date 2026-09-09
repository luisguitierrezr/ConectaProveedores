using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalManualUpload_ActionImportFile_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("i_Filename")]
public string inParami_Filename;
[JsonProperty("i_File")]
public byte[] inParami_File;
[JsonProperty("i_CreatedBy")]
public string inParami_CreatedBy;


    public static RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalManualUpload_ActionImportFile_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalManualUpload_ActionImportFile_Inputs result = inputParameters.ToObject<RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalManualUpload_ActionImportFile_Inputs>(settings);
return result;
}


    public ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalManualUpload_ActionImportFile_Model ToModel() {ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalManualUpload_ActionImportFile_Model result = new ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalManualUpload_ActionImportFile_Model();
result.inParami_Filename = inParami_Filename == null ? "" : inParami_Filename;
result.inParami_File = inParami_File == null ? new byte[] {} : inParami_File;
result.inParami_CreatedBy = inParami_CreatedBy == null ? "" : inParami_CreatedBy;
return result;
}

}
