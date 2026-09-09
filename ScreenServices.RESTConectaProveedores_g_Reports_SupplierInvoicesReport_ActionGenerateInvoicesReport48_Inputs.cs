using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_g_Reports_SupplierInvoicesReport_ActionGenerateInvoicesReport48_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("Filters")]
public ssConectaProveedores.RestRecords.RESTST_4301e782f48f03168dfeb78159c19548Structure inParamFilters;
[JsonProperty("i_OffsetUtc")]
public int? inParami_OffsetUtc;


    public static RESTConectaProveedores_g_Reports_SupplierInvoicesReport_ActionGenerateInvoicesReport48_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_g_Reports_SupplierInvoicesReport_ActionGenerateInvoicesReport48_Inputs result = inputParameters.ToObject<RESTConectaProveedores_g_Reports_SupplierInvoicesReport_ActionGenerateInvoicesReport48_Inputs>(settings);
return result;
}


    public ConectaProveedores_g_Reports_SupplierInvoicesReport_ActionGenerateInvoicesReport48_Model ToModel() {ConectaProveedores_g_Reports_SupplierInvoicesReport_ActionGenerateInvoicesReport48_Model result = new ConectaProveedores_g_Reports_SupplierInvoicesReport_ActionGenerateInvoicesReport48_Model();
result.inParamFilters = ssConectaProveedores.RestRecords.RESTST_4301e782f48f03168dfeb78159c19548Structure.ToStructure(inParamFilters);
result.inParami_OffsetUtc = inParami_OffsetUtc == null ? 0 : inParami_OffsetUtc.Value;
return result;
}

}
