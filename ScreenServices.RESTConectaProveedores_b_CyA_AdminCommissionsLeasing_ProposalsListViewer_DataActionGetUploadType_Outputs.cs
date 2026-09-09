using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsListViewer_DataActionGetUploadType_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("List")]
public RestList<ssConectaProveedores.RestRecords.RESTST_714c559a98f1e1080cbf60de3228e843Structure> outParamList;


    public static RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsListViewer_DataActionGetUploadType_Outputs FromOutputs(IBehaviorsConfiguration conf, RL_a579a1a05eaaba551100ea61f4cb3f6b outParamList) {RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsListViewer_DataActionGetUploadType_Outputs result = new RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsListViewer_DataActionGetUploadType_Outputs();
// Write the needed fields of the list outParamList to the result.outParamList
ssConectaProveedores.RestRecords.RESTST_714c559a98f1e1080cbf60de3228e843Structure tmpoutParamListElement;
if(outParamList.Empty) {
// Write the needed fields of the record outParamList.CurrentRec to the tmpoutParamListElement
tmpoutParamListElement = new ssConectaProveedores.RestRecords.RESTST_714c559a98f1e1080cbf60de3228e843Structure();
tmpoutParamListElement.AttrKey = (int?) outParamList.CurrentRec.ssKey;
tmpoutParamListElement.AttrValue = outParamList.CurrentRec.ssValue;
result.outParamList = new RestList<ssConectaProveedores.RestRecords.RESTST_714c559a98f1e1080cbf60de3228e843Structure>(new ssConectaProveedores.RestRecords.RESTST_714c559a98f1e1080cbf60de3228e843Structure[] {}, tmpoutParamListElement);
} else {
List<ssConectaProveedores.RestRecords.RESTST_714c559a98f1e1080cbf60de3228e843Structure>
 tmpoutParamList1List = new List<ssConectaProveedores.RestRecords.RESTST_714c559a98f1e1080cbf60de3228e843Structure>
();
try {outParamList.StartIteration();
while (!(outParamList.Eof)) {
// Write the needed fields of the record outParamList.CurrentRec to the tmpoutParamListElement
tmpoutParamListElement = new ssConectaProveedores.RestRecords.RESTST_714c559a98f1e1080cbf60de3228e843Structure();
tmpoutParamListElement.AttrKey = (int?) outParamList.CurrentRec.ssKey;
tmpoutParamListElement.AttrValue = outParamList.CurrentRec.ssValue;
tmpoutParamList1List.Add(tmpoutParamListElement);
outParamList.Advance();
}

} finally {
outParamList.EndIteration();
}

result.outParamList = new RestList<ssConectaProveedores.RestRecords.RESTST_714c559a98f1e1080cbf60de3228e843Structure>(tmpoutParamList1List.ToArray(), default(ssConectaProveedores.RestRecords.RESTST_714c559a98f1e1080cbf60de3228e843Structure));
}

return result;
}


    public static ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsListViewer_DataActionGetUploadType_Model ToModel(RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsListViewer_DataActionGetUploadType_Outputs variables) {ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsListViewer_DataActionGetUploadType_Model result = new ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsListViewer_DataActionGetUploadType_Model();
result.outParamList = variables == null ? new RL_a579a1a05eaaba551100ea61f4cb3f6b() : RL_a579a1a05eaaba551100ea61f4cb3f6b.FromRestList(variables.outParamList, ssConectaProveedores.RestRecords.RESTST_714c559a98f1e1080cbf60de3228e843Structure.ToStructure);
return result;
}


    public static RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsListViewer_DataActionGetUploadType_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsListViewer_DataActionGetUploadType_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsListViewer_DataActionGetUploadType_Outputs result = new RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsListViewer_DataActionGetUploadType_Outputs();
result.outParamList = screenModel.outParamList.ToRestList<ssConectaProveedores.RestRecords.RESTST_714c559a98f1e1080cbf60de3228e843Structure>(ssConectaProveedores.RestRecords.RESTST_714c559a98f1e1080cbf60de3228e843Structure.FromStructureDelegate(conf));
return result;
}

}
