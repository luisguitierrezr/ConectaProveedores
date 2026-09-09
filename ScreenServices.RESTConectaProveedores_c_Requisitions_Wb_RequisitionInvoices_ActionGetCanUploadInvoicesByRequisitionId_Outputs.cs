using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_c_Requisitions_Wb_RequisitionInvoices_ActionGetCanUploadInvoicesByRequisitionId_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("i_CanUpload")]
public bool? outParami_CanUpload;


    public static RESTConectaProveedores_c_Requisitions_Wb_RequisitionInvoices_ActionGetCanUploadInvoicesByRequisitionId_Outputs FromOutputs(IBehaviorsConfiguration conf, bool outParami_CanUpload) {RESTConectaProveedores_c_Requisitions_Wb_RequisitionInvoices_ActionGetCanUploadInvoicesByRequisitionId_Outputs result = new RESTConectaProveedores_c_Requisitions_Wb_RequisitionInvoices_ActionGetCanUploadInvoicesByRequisitionId_Outputs();
conf.IncludeBinariesURL = false;
result.outParami_CanUpload = (bool?) outParami_CanUpload;
return result;
}


    

    
}
