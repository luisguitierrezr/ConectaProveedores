using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_d_Invoices_Invoices_ActionScreenTableDownloadInvoiceScreen_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("i_IsCSV")]
public bool? inParami_IsCSV;
[JsonProperty("i_IsPDF")]
public bool? inParami_IsPDF;
[JsonProperty("i_IsXLS")]
public bool? inParami_IsXLS;
[JsonProperty("i_InvoicesScreenTableStructure")]
public RestList<ssConectaProveedores.RestRecords.RESTST_3c6142d371d14231f5ddee7b64c28681Structure> inParami_InvoicesScreenTableStructure;


    public static RESTConectaProveedores_d_Invoices_Invoices_ActionScreenTableDownloadInvoiceScreen_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_d_Invoices_Invoices_ActionScreenTableDownloadInvoiceScreen_Inputs result = inputParameters.ToObject<RESTConectaProveedores_d_Invoices_Invoices_ActionScreenTableDownloadInvoiceScreen_Inputs>(settings);
return result;
}


    public ConectaProveedores_d_Invoices_Invoices_ActionScreenTableDownloadInvoiceScreen_Model ToModel() {ConectaProveedores_d_Invoices_Invoices_ActionScreenTableDownloadInvoiceScreen_Model result = new ConectaProveedores_d_Invoices_Invoices_ActionScreenTableDownloadInvoiceScreen_Model();
result.inParami_IsCSV = inParami_IsCSV == null ? false : inParami_IsCSV.Value;
result.inParami_IsPDF = inParami_IsPDF == null ? false : inParami_IsPDF.Value;
result.inParami_IsXLS = inParami_IsXLS == null ? false : inParami_IsXLS.Value;
result.inParami_InvoicesScreenTableStructure = RL_77750b395266828bf78fae563dd1fc3f.FromRestList(inParami_InvoicesScreenTableStructure, ssConectaProveedores.RestRecords.RESTST_3c6142d371d14231f5ddee7b64c28681Structure.ToStructure);
return result;
}

}
