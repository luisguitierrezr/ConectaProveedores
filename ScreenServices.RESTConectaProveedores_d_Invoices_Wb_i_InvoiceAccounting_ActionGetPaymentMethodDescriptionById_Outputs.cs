using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_ActionGetPaymentMethodDescriptionById_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("Desc")]
public string outParamDesc;


    public static RESTConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_ActionGetPaymentMethodDescriptionById_Outputs FromOutputs(IBehaviorsConfiguration conf, string outParamDesc) {RESTConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_ActionGetPaymentMethodDescriptionById_Outputs result = new RESTConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_ActionGetPaymentMethodDescriptionById_Outputs();
conf.IncludeBinariesURL = false;
result.outParamDesc = outParamDesc;
return result;
}


    

    
}
