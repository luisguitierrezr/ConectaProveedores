using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_ForeignInvoicesForReassignment_ActionGetSettings_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("OutSettingsText")]
public string outParamOutSettingsText;


    public static RESTConectaProveedores_j_FoliosSAE_ForeignInvoicesForReassignment_ActionGetSettings_Outputs FromOutputs(IBehaviorsConfiguration conf, string outParamOutSettingsText) {RESTConectaProveedores_j_FoliosSAE_ForeignInvoicesForReassignment_ActionGetSettings_Outputs result = new RESTConectaProveedores_j_FoliosSAE_ForeignInvoicesForReassignment_ActionGetSettings_Outputs();
conf.IncludeBinariesURL = false;
result.outParamOutSettingsText = outParamOutSettingsText;
return result;
}


    

    
}
