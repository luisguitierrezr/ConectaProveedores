using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_d_InvoiceAudit_Wb_InvoiceFilesList_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("InvoiceId")]
public long? inParamInvoiceId;
[JsonProperty("InvoiceName")]
public string inParamInvoiceName;
[JsonProperty("IsAllSelected")]
public bool? varLcIsAllSelected;
[JsonProperty("StartIndex")]
public int? varLcStartIndex;
[JsonProperty("TableSort")]
public string varLcTableSort;
[JsonProperty("GetInvoiceFiles")]
public RESTConectaProveedores_d_InvoiceAudit_Wb_InvoiceFilesList_DataActionGetInvoiceFiles_Outputs varLcGetInvoiceFiles;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_d_InvoiceAudit_Wb_InvoiceFilesList_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_d_InvoiceAudit_Wb_InvoiceFilesList_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_d_InvoiceAudit_Wb_InvoiceFilesList_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_d_InvoiceAudit_Wb_InvoiceFilesList_ScreenModel ToModel() {long inParamInvoiceId = variables.inParamInvoiceId == null ? 0L : variables.inParamInvoiceId.Value;
string inParamInvoiceName = variables.inParamInvoiceName == null ? "" : variables.inParamInvoiceName;
bool varLcIsAllSelected = variables.varLcIsAllSelected == null ? false : variables.varLcIsAllSelected.Value;
int varLcStartIndex = variables.varLcStartIndex == null ? 0 : variables.varLcStartIndex.Value;
string varLcTableSort = variables.varLcTableSort == null ? "IsExtra" : variables.varLcTableSort;
ConectaProveedores_d_InvoiceAudit_Wb_InvoiceFilesList_DataActionGetInvoiceFiles_Model _varLcGetInvoiceFiles = (variables.varLcGetInvoiceFiles != null) ? RESTConectaProveedores_d_InvoiceAudit_Wb_InvoiceFilesList_DataActionGetInvoiceFiles_Outputs.ToModel(variables.varLcGetInvoiceFiles) : null;
ConectaProveedores_d_InvoiceAudit_Wb_InvoiceFilesList_ScreenModel screenModel = new ConectaProveedores_d_InvoiceAudit_Wb_InvoiceFilesList_ScreenModel(inParamInvoiceId, inParamInvoiceName, varLcIsAllSelected, varLcStartIndex, varLcTableSort, _varLcGetInvoiceFiles, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
