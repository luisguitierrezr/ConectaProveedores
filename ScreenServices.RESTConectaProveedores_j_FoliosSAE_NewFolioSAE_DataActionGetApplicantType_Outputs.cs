using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_NewFolioSAE_DataActionGetApplicantType_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("ApprovalProcessTypeId")]
public int? outParamApprovalProcessTypeId;
[JsonProperty("ApplicantId")]
public long? outParamApplicantId;


    public static RESTConectaProveedores_j_FoliosSAE_NewFolioSAE_DataActionGetApplicantType_Outputs FromOutputs(IBehaviorsConfiguration conf, int outParamApprovalProcessTypeId, long outParamApplicantId) {RESTConectaProveedores_j_FoliosSAE_NewFolioSAE_DataActionGetApplicantType_Outputs result = new RESTConectaProveedores_j_FoliosSAE_NewFolioSAE_DataActionGetApplicantType_Outputs();
result.outParamApprovalProcessTypeId = (int?) outParamApprovalProcessTypeId;
result.outParamApplicantId = (long?) outParamApplicantId;
return result;
}


    public static ConectaProveedores_j_FoliosSAE_NewFolioSAE_DataActionGetApplicantType_Model ToModel(RESTConectaProveedores_j_FoliosSAE_NewFolioSAE_DataActionGetApplicantType_Outputs variables) {ConectaProveedores_j_FoliosSAE_NewFolioSAE_DataActionGetApplicantType_Model result = new ConectaProveedores_j_FoliosSAE_NewFolioSAE_DataActionGetApplicantType_Model();
result.outParamApprovalProcessTypeId = variables == null || variables.outParamApprovalProcessTypeId == null ? BuiltInFunction.NullIdentifier () : variables.outParamApprovalProcessTypeId.Value;
result.outParamApplicantId = variables == null || variables.outParamApplicantId == null ? 0L : variables.outParamApplicantId.Value;
return result;
}


    public static RESTConectaProveedores_j_FoliosSAE_NewFolioSAE_DataActionGetApplicantType_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_j_FoliosSAE_NewFolioSAE_DataActionGetApplicantType_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_j_FoliosSAE_NewFolioSAE_DataActionGetApplicantType_Outputs result = new RESTConectaProveedores_j_FoliosSAE_NewFolioSAE_DataActionGetApplicantType_Outputs();
result.outParamApprovalProcessTypeId = (int?) screenModel.outParamApprovalProcessTypeId;
result.outParamApplicantId = (long?) screenModel.outParamApplicantId;
return result;
}

}
