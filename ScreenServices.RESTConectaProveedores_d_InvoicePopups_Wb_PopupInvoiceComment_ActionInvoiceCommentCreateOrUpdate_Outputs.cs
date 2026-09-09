using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceComment_ActionInvoiceCommentCreateOrUpdate_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("Id")]
public long? outParamId;


    public static RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceComment_ActionInvoiceCommentCreateOrUpdate_Outputs FromOutputs(IBehaviorsConfiguration conf, long outParamId) {RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceComment_ActionInvoiceCommentCreateOrUpdate_Outputs result = new RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceComment_ActionInvoiceCommentCreateOrUpdate_Outputs();
conf.IncludeBinariesURL = false;
// Write optimized result.outParamId
result.outParamId = (long?) 0L;
return result;
}


    

    
}
