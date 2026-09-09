using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_ActionFolioUpdate_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("o_FolioName")]
public string outParamo_FolioName;
[JsonProperty("ErrorMsg")]
public string outParamErrorMsg;


    public static RESTConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_ActionFolioUpdate_Outputs FromOutputs(IBehaviorsConfiguration conf, string outParamo_FolioName, string outParamErrorMsg) {RESTConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_ActionFolioUpdate_Outputs result = new RESTConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_ActionFolioUpdate_Outputs();
conf.IncludeBinariesURL = false;
result.outParamo_FolioName = outParamo_FolioName;
result.outParamErrorMsg = outParamErrorMsg;
return result;
}


    

    
}
