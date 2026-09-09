using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_ActionGetCodeByTaxId_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("TaxIndicatorId")]
public long? inParamTaxIndicatorId;


    public static RESTConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_ActionGetCodeByTaxId_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_ActionGetCodeByTaxId_Inputs result = inputParameters.ToObject<RESTConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_ActionGetCodeByTaxId_Inputs>(settings);
return result;
}


    public ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_ActionGetCodeByTaxId_Model ToModel() {ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_ActionGetCodeByTaxId_Model result = new ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_ActionGetCodeByTaxId_Model();
result.inParamTaxIndicatorId = inParamTaxIndicatorId == null ? 0L : inParamTaxIndicatorId.Value;
return result;
}

}
