using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_Wb_ReassignFolio_ActionFolioReassignGeneral_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("i_SourceUserId")]
public string inParami_SourceUserId;
[JsonProperty("i_TargetUserId")]
public string inParami_TargetUserId;
[JsonProperty("i_Motive")]
public string inParami_Motive;
[JsonProperty("i_FolioApprovalLevelList")]
public RestList<long> inParami_FolioApprovalLevelList;
[JsonProperty("i_IsInvoiceApproval")]
public bool? inParami_IsInvoiceApproval;


    public static RESTConectaProveedores_j_FoliosSAE_Wb_ReassignFolio_ActionFolioReassignGeneral_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_j_FoliosSAE_Wb_ReassignFolio_ActionFolioReassignGeneral_Inputs result = inputParameters.ToObject<RESTConectaProveedores_j_FoliosSAE_Wb_ReassignFolio_ActionFolioReassignGeneral_Inputs>(settings);
return result;
}


    public ConectaProveedores_j_FoliosSAE_Wb_ReassignFolio_ActionFolioReassignGeneral_Model ToModel() {ConectaProveedores_j_FoliosSAE_Wb_ReassignFolio_ActionFolioReassignGeneral_Model result = new ConectaProveedores_j_FoliosSAE_Wb_ReassignFolio_ActionFolioReassignGeneral_Model();
result.inParami_SourceUserId = inParami_SourceUserId == null ? "" : inParami_SourceUserId;
result.inParami_TargetUserId = inParami_TargetUserId == null ? "" : inParami_TargetUserId;
result.inParami_Motive = inParami_Motive == null ? "" : inParami_Motive;
result.inParami_FolioApprovalLevelList = BasicTypeList<long>.FromRestList(inParami_FolioApprovalLevelList);
result.inParami_IsInvoiceApproval = inParami_IsInvoiceApproval == null ? false : inParami_IsInvoiceApproval.Value;
return result;
}

}
