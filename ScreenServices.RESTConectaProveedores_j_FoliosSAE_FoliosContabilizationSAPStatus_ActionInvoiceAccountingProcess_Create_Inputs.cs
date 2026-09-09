using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_ActionInvoiceAccountingProcess_Create_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("InvoiceId")]
public long? inParamInvoiceId;
[JsonProperty("Comment")]
public string inParamComment;
[JsonProperty("IsFCP")]
public bool? inParamIsFCP;
[JsonProperty("RequisitionId")]
public long? inParamRequisitionId;
[JsonProperty("OffsetUtc")]
public int? inParamOffsetUtc;


    public static RESTConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_ActionInvoiceAccountingProcess_Create_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_ActionInvoiceAccountingProcess_Create_Inputs result = inputParameters.ToObject<RESTConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_ActionInvoiceAccountingProcess_Create_Inputs>(settings);
return result;
}


    public ConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_ActionInvoiceAccountingProcess_Create_Model ToModel() {ConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_ActionInvoiceAccountingProcess_Create_Model result = new ConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_ActionInvoiceAccountingProcess_Create_Model();
result.inParamInvoiceId = inParamInvoiceId == null ? 0L : inParamInvoiceId.Value;
result.inParamComment = inParamComment == null ? "" : inParamComment;
result.inParamIsFCP = inParamIsFCP == null ? false : inParamIsFCP.Value;
result.inParamRequisitionId = inParamRequisitionId == null ? 0L : inParamRequisitionId.Value;
result.inParamOffsetUtc = inParamOffsetUtc == null ? 0 : inParamOffsetUtc.Value;
return result;
}

}
