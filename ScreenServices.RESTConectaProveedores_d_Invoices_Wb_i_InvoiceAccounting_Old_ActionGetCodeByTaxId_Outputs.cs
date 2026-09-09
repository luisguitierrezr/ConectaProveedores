using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_ActionGetCodeByTaxId_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("Code")]
public string outParamCode;


    public static RESTConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_ActionGetCodeByTaxId_Outputs FromOutputs(IBehaviorsConfiguration conf, string outParamCode) {RESTConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_ActionGetCodeByTaxId_Outputs result = new RESTConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_ActionGetCodeByTaxId_Outputs();
conf.IncludeBinariesURL = false;
result.outParamCode = outParamCode;
return result;
}


    

    
}
