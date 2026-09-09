using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_d_Invoices_Wb_InvoicesFilesPreview_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("InvoiceId")]
public long? inParamInvoiceId;
[JsonProperty("IsOpenPopupOtherFiles")]
public bool? varLcIsOpenPopupOtherFiles;
[JsonProperty("GetInvoiceFiles")]
public RESTConectaProveedores_d_Invoices_Wb_InvoicesFilesPreview_DataActionGetInvoiceFiles_Outputs varLcGetInvoiceFiles;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_d_Invoices_Wb_InvoicesFilesPreview_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_d_Invoices_Wb_InvoicesFilesPreview_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_d_Invoices_Wb_InvoicesFilesPreview_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_d_Invoices_Wb_InvoicesFilesPreview_ScreenModel ToModel() {long inParamInvoiceId = variables.inParamInvoiceId == null ? 0L : variables.inParamInvoiceId.Value;
bool varLcIsOpenPopupOtherFiles = variables.varLcIsOpenPopupOtherFiles == null ? false : variables.varLcIsOpenPopupOtherFiles.Value;
ConectaProveedores_d_Invoices_Wb_InvoicesFilesPreview_DataActionGetInvoiceFiles_Model _varLcGetInvoiceFiles = (variables.varLcGetInvoiceFiles != null) ? RESTConectaProveedores_d_Invoices_Wb_InvoicesFilesPreview_DataActionGetInvoiceFiles_Outputs.ToModel(variables.varLcGetInvoiceFiles) : null;
ConectaProveedores_d_Invoices_Wb_InvoicesFilesPreview_ScreenModel screenModel = new ConectaProveedores_d_Invoices_Wb_InvoicesFilesPreview_ScreenModel(inParamInvoiceId, varLcIsOpenPopupOtherFiles, _varLcGetInvoiceFiles, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
