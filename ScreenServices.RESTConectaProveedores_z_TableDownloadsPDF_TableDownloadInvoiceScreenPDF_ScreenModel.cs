using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_z_TableDownloadsPDF_TableDownloadInvoiceScreenPDF_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("StringListIds")]
public string inParamStringListIds;
[JsonProperty("StringListLevelIds")]
public string inParamStringListLevelIds;
[JsonProperty("InvoiceIdsList")]
public RestList<ssConectaProveedores.RestRecords.RESTSTTextStructure> varLcInvoiceIdsList;
[JsonProperty("InvoiceLevelIdsList")]
public RestList<ssConectaProveedores.RestRecords.RESTSTTextStructure> varLcInvoiceLevelIdsList;
[JsonProperty("GetInvoices")]
public RESTConectaProveedores_z_TableDownloadsPDF_TableDownloadInvoiceScreenPDF_DataActionGetInvoices_Outputs varLcGetInvoices;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_z_TableDownloadsPDF_TableDownloadInvoiceScreenPDF_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_z_TableDownloadsPDF_TableDownloadInvoiceScreenPDF_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_z_TableDownloadsPDF_TableDownloadInvoiceScreenPDF_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_z_TableDownloadsPDF_TableDownloadInvoiceScreenPDF_ScreenModel ToModel() {string inParamStringListIds = variables.inParamStringListIds == null ? "" : variables.inParamStringListIds;
string inParamStringListLevelIds = variables.inParamStringListLevelIds == null ? "" : variables.inParamStringListLevelIds;
RLTextList varLcInvoiceIdsList = RLTextList.FromRestList(variables.varLcInvoiceIdsList, ssConectaProveedores.RestRecords.RESTSTTextStructure.ToStructure);
RLTextList varLcInvoiceLevelIdsList = RLTextList.FromRestList(variables.varLcInvoiceLevelIdsList, ssConectaProveedores.RestRecords.RESTSTTextStructure.ToStructure);
ConectaProveedores_z_TableDownloadsPDF_TableDownloadInvoiceScreenPDF_DataActionGetInvoices_Model _varLcGetInvoices = (variables.varLcGetInvoices != null) ? RESTConectaProveedores_z_TableDownloadsPDF_TableDownloadInvoiceScreenPDF_DataActionGetInvoices_Outputs.ToModel(variables.varLcGetInvoices) : null;
ConectaProveedores_z_TableDownloadsPDF_TableDownloadInvoiceScreenPDF_ScreenModel screenModel = new ConectaProveedores_z_TableDownloadsPDF_TableDownloadInvoiceScreenPDF_ScreenModel(inParamStringListIds, inParamStringListLevelIds, varLcInvoiceIdsList, varLcInvoiceLevelIdsList, _varLcGetInvoices, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
