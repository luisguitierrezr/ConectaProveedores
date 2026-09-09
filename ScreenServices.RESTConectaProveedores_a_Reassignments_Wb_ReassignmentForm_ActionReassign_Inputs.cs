using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_a_Reassignments_Wb_ReassignmentForm_ActionReassign_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("InvList")]
public RestList<ssConectaProveedores.RestRecords.RESTRC_9f414d82ade67cb4131fecd8fda64580> inParamInvList;
[JsonProperty("ReqList")]
public RestList<ssConectaProveedores.RestRecords.RESTRC_da31ba4ed131103eb5a5b5464cca7643> inParamReqList;
[JsonProperty("i_TargetUserAUEntraId")]
public string inParami_TargetUserAUEntraId;
[JsonProperty("i_Reason")]
public string inParami_Reason;
[JsonProperty("i_SourceUserId")]
public string inParami_SourceUserId;


    public static RESTConectaProveedores_a_Reassignments_Wb_ReassignmentForm_ActionReassign_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_a_Reassignments_Wb_ReassignmentForm_ActionReassign_Inputs result = inputParameters.ToObject<RESTConectaProveedores_a_Reassignments_Wb_ReassignmentForm_ActionReassign_Inputs>(settings);
return result;
}


    public ConectaProveedores_a_Reassignments_Wb_ReassignmentForm_ActionReassign_Model ToModel() {ConectaProveedores_a_Reassignments_Wb_ReassignmentForm_ActionReassign_Model result = new ConectaProveedores_a_Reassignments_Wb_ReassignmentForm_ActionReassign_Model();
result.inParamInvList = RL_8c69b09c6d811e27e13cdf810a622fb2.FromRestList(inParamInvList, ssConectaProveedores.RestRecords.RESTRC_9f414d82ade67cb4131fecd8fda64580.ToStructure);
result.inParamReqList = RL_6f013a7f2ef00b964b6e71f1ec07b189.FromRestList(inParamReqList, ssConectaProveedores.RestRecords.RESTRC_da31ba4ed131103eb5a5b5464cca7643.ToStructure);
result.inParami_TargetUserAUEntraId = inParami_TargetUserAUEntraId == null ? "" : inParami_TargetUserAUEntraId;
result.inParami_Reason = inParami_Reason == null ? "" : inParami_Reason;
result.inParami_SourceUserId = inParami_SourceUserId == null ? "" : inParami_SourceUserId;
return result;
}

}
