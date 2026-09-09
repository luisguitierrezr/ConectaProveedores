using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetInvoiceFilesByInvoiceId")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_18990af86f7169e92b712b468e13b947> ScreenDataSetGetInvoiceFilesByInvoiceId;
[JsonProperty("GetInvoiceExtendedForeignerById")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_decbed55750bb4030b04e46c0306e56b> ScreenDataSetGetInvoiceExtendedForeignerById;
[JsonProperty("InvoiceId")]
public long? inParamInvoiceId;
[JsonProperty("InvoiceStatusId")]
public int? inParamInvoiceStatusId;
[JsonProperty("RequisitionId")]
public long? inParamRequisitionId;
[JsonProperty("FolioId")]
public long? inParamFolioId;
[JsonProperty("i_ShowOtherEvidences")]
public bool? inParami_ShowOtherEvidences;
[JsonProperty("ErrorMsg")]
public string varLcErrorMsg;
[JsonProperty("ExtraFilesList")]
public RestList<ssConectaProveedores.RestRecords.RESTST_7837994e68174a4794f15e4233b48555Structure> varLcExtraFilesList;
[JsonProperty("FilesList")]
public RestList<ssConectaProveedores.RestRecords.RESTST_7837994e68174a4794f15e4233b48555Structure> varLcFilesList;
[JsonProperty("HasChanged")]
public bool? varLcHasChanged;
[JsonProperty("IsExecuting")]
public bool? varLcIsExecuting;
[JsonProperty("IsLoading")]
public bool? varLcIsLoading;
[JsonProperty("IsSaving")]
public bool? varLcIsSaving;
[JsonProperty("IsShowForeignInvoice")]
public bool? varLcIsShowForeignInvoice;
[JsonProperty("InvoiceForeign")]
public ssConectaProveedores.RestRecords.RESTST_6f620840109ac6f721328b723ec0152cStructure varLcInvoiceForeign;
[JsonProperty("GetInvoicesByRequisitionOrFolio")]
public RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_DataActionGetInvoicesByRequisitionOrFolio_Outputs varLcGetInvoicesByRequisitionOrFolio;
[JsonProperty("GetSupplier")]
public RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_DataActionGetSupplier_Outputs varLcGetSupplier;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_ScreenModel ToModel() {long inParamInvoiceId = variables.inParamInvoiceId == null ? 0L : variables.inParamInvoiceId.Value;
int inParamInvoiceStatusId = variables.inParamInvoiceStatusId == null ? 0 : variables.inParamInvoiceStatusId.Value;
long inParamRequisitionId = variables.inParamRequisitionId == null ? 0L : variables.inParamRequisitionId.Value;
long inParamFolioId = variables.inParamFolioId == null ? 0L : variables.inParamFolioId.Value;
bool inParami_ShowOtherEvidences = variables.inParami_ShowOtherEvidences == null ? false : variables.inParami_ShowOtherEvidences.Value;
string varLcErrorMsg = variables.varLcErrorMsg == null ? "" : variables.varLcErrorMsg;
RL_7b4ceb84b6a1255d3a42c8932279bc3c varLcExtraFilesList = RL_7b4ceb84b6a1255d3a42c8932279bc3c.FromRestList(variables.varLcExtraFilesList, ssConectaProveedores.RestRecords.RESTST_7837994e68174a4794f15e4233b48555Structure.ToStructure);
RL_7b4ceb84b6a1255d3a42c8932279bc3c varLcFilesList = RL_7b4ceb84b6a1255d3a42c8932279bc3c.FromRestList(variables.varLcFilesList, ssConectaProveedores.RestRecords.RESTST_7837994e68174a4794f15e4233b48555Structure.ToStructure);
bool varLcHasChanged = variables.varLcHasChanged == null ? false : variables.varLcHasChanged.Value;
bool varLcIsExecuting = variables.varLcIsExecuting == null ? false : variables.varLcIsExecuting.Value;
bool varLcIsLoading = variables.varLcIsLoading == null ? true : variables.varLcIsLoading.Value;
bool varLcIsSaving = variables.varLcIsSaving == null ? false : variables.varLcIsSaving.Value;
bool varLcIsShowForeignInvoice = variables.varLcIsShowForeignInvoice == null ? false : variables.varLcIsShowForeignInvoice.Value;
ST_6f620840109ac6f721328b723ec0152cStructure varLcInvoiceForeign = ssConectaProveedores.RestRecords.RESTST_6f620840109ac6f721328b723ec0152cStructure.ToStructure(variables.varLcInvoiceForeign);
AggregateRecord<RL_00a03f803f0d49826089181417370afb> _ScreenDataSetGetInvoiceFilesByInvoiceId = (variables.ScreenDataSetGetInvoiceFilesByInvoiceId != null) ? variables.ScreenDataSetGetInvoiceFilesByInvoiceId.FromJS((array) => {
return RL_00a03f803f0d49826089181417370afb.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_18990af86f7169e92b712b468e13b947.ToStructure);
}
) : null;
AggregateRecord<RL_5198a019df57be180483639cd138aad4> _ScreenDataSetGetInvoiceExtendedForeignerById = (variables.ScreenDataSetGetInvoiceExtendedForeignerById != null) ? variables.ScreenDataSetGetInvoiceExtendedForeignerById.FromJS((array) => {
return RL_5198a019df57be180483639cd138aad4.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_decbed55750bb4030b04e46c0306e56b.ToStructure);
}
) : null;
ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_DataActionGetInvoicesByRequisitionOrFolio_Model _varLcGetInvoicesByRequisitionOrFolio = (variables.varLcGetInvoicesByRequisitionOrFolio != null) ? RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_DataActionGetInvoicesByRequisitionOrFolio_Outputs.ToModel(variables.varLcGetInvoicesByRequisitionOrFolio) : null;
ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_DataActionGetSupplier_Model _varLcGetSupplier = (variables.varLcGetSupplier != null) ? RESTConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_DataActionGetSupplier_Outputs.ToModel(variables.varLcGetSupplier) : null;
ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_ScreenModel screenModel = new ConectaProveedores_d_InvoicePopups_Wb_PopupInvoiceUploadBigFiles_ScreenModel(inParamInvoiceId, inParamInvoiceStatusId, inParamRequisitionId, inParamFolioId, inParami_ShowOtherEvidences, varLcErrorMsg, varLcExtraFilesList, varLcFilesList, varLcHasChanged, varLcIsExecuting, varLcIsLoading, varLcIsSaving, varLcIsShowForeignInvoice, varLcInvoiceForeign, _ScreenDataSetGetInvoiceFilesByInvoiceId, _ScreenDataSetGetInvoiceExtendedForeignerById, _varLcGetInvoicesByRequisitionOrFolio, _varLcGetSupplier, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
