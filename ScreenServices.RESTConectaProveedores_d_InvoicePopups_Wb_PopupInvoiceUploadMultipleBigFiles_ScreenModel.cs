using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultipleBigFiles_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("InvoiceStatusId")]
public int? inParamInvoiceStatusId;
[JsonProperty("RequisitionId")]
public long? inParamRequisitionId;
[JsonProperty("FolioId")]
public long? inParamFolioId;
[JsonProperty("ErrorMsg")]
public string varLcErrorMsg;
[JsonProperty("FilesList")]
public RestList<ssConectaProveedores.RestRecords.RESTST_5478c3bb197e3019856d4a634c17d91dStructure> varLcFilesList;
[JsonProperty("HasChanged")]
public bool? varLcHasChanged;
[JsonProperty("IsExecuting")]
public bool? varLcIsExecuting;
[JsonProperty("IsSaving")]
public bool? varLcIsSaving;
[JsonProperty("GetInvoicesByRequisitionOrFolio")]
public RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultipleBigFiles_DataActionGetInvoicesByRequisitionOrFolio_Outputs varLcGetInvoicesByRequisitionOrFolio;
[JsonProperty("GetSupplier")]
public RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultipleBigFiles_DataActionGetSupplier_Outputs varLcGetSupplier;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultipleBigFiles_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultipleBigFiles_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultipleBigFiles_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultipleBigFiles_ScreenModel ToModel() {int inParamInvoiceStatusId = variables.inParamInvoiceStatusId == null ? 0 : variables.inParamInvoiceStatusId.Value;
long inParamRequisitionId = variables.inParamRequisitionId == null ? 0L : variables.inParamRequisitionId.Value;
long inParamFolioId = variables.inParamFolioId == null ? 0L : variables.inParamFolioId.Value;
string varLcErrorMsg = variables.varLcErrorMsg == null ? "" : variables.varLcErrorMsg;
RL_2e76d5be11218f97ffd872b5a7213337 varLcFilesList = RL_2e76d5be11218f97ffd872b5a7213337.FromRestList(variables.varLcFilesList, ssConectaProveedores.RestRecords.RESTST_5478c3bb197e3019856d4a634c17d91dStructure.ToStructure);
bool varLcHasChanged = variables.varLcHasChanged == null ? false : variables.varLcHasChanged.Value;
bool varLcIsExecuting = variables.varLcIsExecuting == null ? false : variables.varLcIsExecuting.Value;
bool varLcIsSaving = variables.varLcIsSaving == null ? false : variables.varLcIsSaving.Value;
ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultipleBigFiles_DataActionGetInvoicesByRequisitionOrFolio_Model _varLcGetInvoicesByRequisitionOrFolio = (variables.varLcGetInvoicesByRequisitionOrFolio != null) ? RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultipleBigFiles_DataActionGetInvoicesByRequisitionOrFolio_Outputs.ToModel(variables.varLcGetInvoicesByRequisitionOrFolio) : null;
ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultipleBigFiles_DataActionGetSupplier_Model _varLcGetSupplier = (variables.varLcGetSupplier != null) ? RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultipleBigFiles_DataActionGetSupplier_Outputs.ToModel(variables.varLcGetSupplier) : null;
ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultipleBigFiles_ScreenModel screenModel = new ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadMultipleBigFiles_ScreenModel(inParamInvoiceStatusId, inParamRequisitionId, inParamFolioId, varLcErrorMsg, varLcFilesList, varLcHasChanged, varLcIsExecuting, varLcIsSaving, _varLcGetInvoicesByRequisitionOrFolio, _varLcGetSupplier, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
