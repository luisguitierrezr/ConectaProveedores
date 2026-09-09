using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_z_TableDownloadsPDF_TableDownloadInvoiceScreenPDF_ActionString_Split_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("Text")]
public string inParamText;
[JsonProperty("Delimiters")]
public string inParamDelimiters;


    public static RESTConectaProveedores_z_TableDownloadsPDF_TableDownloadInvoiceScreenPDF_ActionString_Split_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_z_TableDownloadsPDF_TableDownloadInvoiceScreenPDF_ActionString_Split_Inputs result = inputParameters.ToObject<RESTConectaProveedores_z_TableDownloadsPDF_TableDownloadInvoiceScreenPDF_ActionString_Split_Inputs>(settings);
return result;
}


    public ConectaProveedores_z_TableDownloadsPDF_TableDownloadInvoiceScreenPDF_ActionString_Split_Model ToModel() {ConectaProveedores_z_TableDownloadsPDF_TableDownloadInvoiceScreenPDF_ActionString_Split_Model result = new ConectaProveedores_z_TableDownloadsPDF_TableDownloadInvoiceScreenPDF_ActionString_Split_Model();
result.inParamText = inParamText == null ? "" : inParamText;
result.inParamDelimiters = inParamDelimiters == null ? "" : inParamDelimiters;
return result;
}

}
