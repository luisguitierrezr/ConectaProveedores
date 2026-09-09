using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUpload_ActionFolioInvoiceUpdate_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("ErrorMsg")]
public string outParamErrorMsg;
[JsonProperty("o_FolioName")]
public string outParamo_FolioName;
[JsonProperty("IsMissingCreditNote")]
public bool? outParamIsMissingCreditNote;


    public static RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUpload_ActionFolioInvoiceUpdate_Outputs FromOutputs(IBehaviorsConfiguration conf, string outParamErrorMsg, string outParamo_FolioName, bool outParamIsMissingCreditNote) {RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUpload_ActionFolioInvoiceUpdate_Outputs result = new RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUpload_ActionFolioInvoiceUpdate_Outputs();
conf.IncludeBinariesURL = false;
result.outParamErrorMsg = outParamErrorMsg;
// Write optimized result.outParamo_FolioName
result.outParamo_FolioName = "";
result.outParamIsMissingCreditNote = (bool?) outParamIsMissingCreditNote;
return result;
}


    

    
}
