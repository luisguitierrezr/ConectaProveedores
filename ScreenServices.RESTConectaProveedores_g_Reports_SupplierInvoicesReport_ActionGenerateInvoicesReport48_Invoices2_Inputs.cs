using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_g_Reports_SupplierInvoicesReport_ActionGenerateInvoicesReport48_Invoices2_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("i_OffsetUtc")]
public int? inParami_OffsetUtc;
[JsonProperty("InvoiceIdList")]
public RestList<long> inParamInvoiceIdList;


    public static RESTConectaProveedores_g_Reports_SupplierInvoicesReport_ActionGenerateInvoicesReport48_Invoices2_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_g_Reports_SupplierInvoicesReport_ActionGenerateInvoicesReport48_Invoices2_Inputs result = inputParameters.ToObject<RESTConectaProveedores_g_Reports_SupplierInvoicesReport_ActionGenerateInvoicesReport48_Invoices2_Inputs>(settings);
return result;
}


    public ConectaProveedores_g_Reports_SupplierInvoicesReport_ActionGenerateInvoicesReport48_Invoices2_Model ToModel() {ConectaProveedores_g_Reports_SupplierInvoicesReport_ActionGenerateInvoicesReport48_Invoices2_Model result = new ConectaProveedores_g_Reports_SupplierInvoicesReport_ActionGenerateInvoicesReport48_Invoices2_Model();
result.inParami_OffsetUtc = inParami_OffsetUtc == null ? 0 : inParami_OffsetUtc.Value;
result.inParamInvoiceIdList = BasicTypeList<long>.FromRestList(inParamInvoiceIdList);
return result;
}

}
