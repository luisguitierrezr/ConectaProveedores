using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_y_Utils_InvoiceReportPdf_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("InvoiceId")]
public long? inParamInvoiceId;
[JsonProperty("Offset")]
public int? varLcOffset;
[JsonProperty("GetMainData")]
public RESTConectaProveedores_y_Utils_InvoiceReportPdf_DataActionGetMainData_Outputs varLcGetMainData;
[JsonProperty("GetTableItems")]
public RESTConectaProveedores_y_Utils_InvoiceReportPdf_DataActionGetTableItems_Outputs varLcGetTableItems;
[JsonProperty("GetInvoiceFiles")]
public RESTConectaProveedores_y_Utils_InvoiceReportPdf_DataActionGetInvoiceFiles_Outputs varLcGetInvoiceFiles;
[JsonProperty("GetEletronicAuthorizations")]
public RESTConectaProveedores_y_Utils_InvoiceReportPdf_DataActionGetEletronicAuthorizations_Outputs varLcGetEletronicAuthorizations;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_y_Utils_InvoiceReportPdf_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_y_Utils_InvoiceReportPdf_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_y_Utils_InvoiceReportPdf_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_y_Utils_InvoiceReportPdf_ScreenModel ToModel() {long inParamInvoiceId = variables.inParamInvoiceId == null ? 0L : variables.inParamInvoiceId.Value;
int varLcOffset = variables.varLcOffset == null ? 0 : variables.varLcOffset.Value;
ConectaProveedores_y_Utils_InvoiceReportPdf_DataActionGetMainData_Model _varLcGetMainData = (variables.varLcGetMainData != null) ? RESTConectaProveedores_y_Utils_InvoiceReportPdf_DataActionGetMainData_Outputs.ToModel(variables.varLcGetMainData) : null;
ConectaProveedores_y_Utils_InvoiceReportPdf_DataActionGetTableItems_Model _varLcGetTableItems = (variables.varLcGetTableItems != null) ? RESTConectaProveedores_y_Utils_InvoiceReportPdf_DataActionGetTableItems_Outputs.ToModel(variables.varLcGetTableItems) : null;
ConectaProveedores_y_Utils_InvoiceReportPdf_DataActionGetInvoiceFiles_Model _varLcGetInvoiceFiles = (variables.varLcGetInvoiceFiles != null) ? RESTConectaProveedores_y_Utils_InvoiceReportPdf_DataActionGetInvoiceFiles_Outputs.ToModel(variables.varLcGetInvoiceFiles) : null;
ConectaProveedores_y_Utils_InvoiceReportPdf_DataActionGetEletronicAuthorizations_Model _varLcGetEletronicAuthorizations = (variables.varLcGetEletronicAuthorizations != null) ? RESTConectaProveedores_y_Utils_InvoiceReportPdf_DataActionGetEletronicAuthorizations_Outputs.ToModel(variables.varLcGetEletronicAuthorizations) : null;
ConectaProveedores_y_Utils_InvoiceReportPdf_ScreenModel screenModel = new ConectaProveedores_y_Utils_InvoiceReportPdf_ScreenModel(inParamInvoiceId, varLcOffset, _varLcGetMainData, _varLcGetTableItems, _varLcGetInvoiceFiles, _varLcGetEletronicAuthorizations, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
