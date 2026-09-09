using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_y_Utils_Wb_FolioEntra_Historic_DataActionGetEntraUserManagerList_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("UserList")]
public RestList<ssConectaProveedores.RestRecords.RESTST_34625f5643caa3d12448dcec7dd4c7d3Structure> outParamUserList;


    public static RESTConectaProveedores_y_Utils_Wb_FolioEntra_Historic_DataActionGetEntraUserManagerList_Outputs FromOutputs(IBehaviorsConfiguration conf, RL_4af3045b114dbc57d1481fed5aceb93a outParamUserList) {RESTConectaProveedores_y_Utils_Wb_FolioEntra_Historic_DataActionGetEntraUserManagerList_Outputs result = new RESTConectaProveedores_y_Utils_Wb_FolioEntra_Historic_DataActionGetEntraUserManagerList_Outputs();
// Write the needed fields of the list outParamUserList to the result.outParamUserList
ssConectaProveedores.RestRecords.RESTST_34625f5643caa3d12448dcec7dd4c7d3Structure tmpoutParamUserListElement;
if(outParamUserList.Empty) {
// Write the needed fields of the record outParamUserList.CurrentRec to the tmpoutParamUserListElement
tmpoutParamUserListElement = new ssConectaProveedores.RestRecords.RESTST_34625f5643caa3d12448dcec7dd4c7d3Structure();
tmpoutParamUserListElement.AttrName = outParamUserList.CurrentRec.ssName;
tmpoutParamUserListElement.AttrRole = outParamUserList.CurrentRec.ssRole;
tmpoutParamUserListElement.AttrCancelMessage = outParamUserList.CurrentRec.ssCancelMessage;
tmpoutParamUserListElement.AttrApprovalStatusId = (int?) outParamUserList.CurrentRec.ssApprovalStatusId;
tmpoutParamUserListElement.AttrApproveAsAreaUsuaria = (bool?) outParamUserList.CurrentRec.ssApproveAsAreaUsuaria;
tmpoutParamUserListElement.AttrModifyMessage = outParamUserList.CurrentRec.ssModifyMessage;
tmpoutParamUserListElement.AttrIsNotMapped = (bool?) outParamUserList.CurrentRec.ssIsNotMapped;
tmpoutParamUserListElement.AttrIsReassigned = (bool?) outParamUserList.CurrentRec.ssIsReassigned;
// Write optimized tmpoutParamUserListElement.AttrIsSubstitute
tmpoutParamUserListElement.AttrIsSubstitute = (bool?) false;
result.outParamUserList = new RestList<ssConectaProveedores.RestRecords.RESTST_34625f5643caa3d12448dcec7dd4c7d3Structure>(new ssConectaProveedores.RestRecords.RESTST_34625f5643caa3d12448dcec7dd4c7d3Structure[] {}, tmpoutParamUserListElement);
} else {
List<ssConectaProveedores.RestRecords.RESTST_34625f5643caa3d12448dcec7dd4c7d3Structure>
 tmpoutParamUserList1List = new List<ssConectaProveedores.RestRecords.RESTST_34625f5643caa3d12448dcec7dd4c7d3Structure>
();
try {outParamUserList.StartIteration();
while (!(outParamUserList.Eof)) {
// Write the needed fields of the record outParamUserList.CurrentRec to the tmpoutParamUserListElement
tmpoutParamUserListElement = new ssConectaProveedores.RestRecords.RESTST_34625f5643caa3d12448dcec7dd4c7d3Structure();
tmpoutParamUserListElement.AttrName = outParamUserList.CurrentRec.ssName;
tmpoutParamUserListElement.AttrRole = outParamUserList.CurrentRec.ssRole;
tmpoutParamUserListElement.AttrCancelMessage = outParamUserList.CurrentRec.ssCancelMessage;
tmpoutParamUserListElement.AttrApprovalStatusId = (int?) outParamUserList.CurrentRec.ssApprovalStatusId;
tmpoutParamUserListElement.AttrApproveAsAreaUsuaria = (bool?) outParamUserList.CurrentRec.ssApproveAsAreaUsuaria;
tmpoutParamUserListElement.AttrModifyMessage = outParamUserList.CurrentRec.ssModifyMessage;
tmpoutParamUserListElement.AttrIsNotMapped = (bool?) outParamUserList.CurrentRec.ssIsNotMapped;
tmpoutParamUserListElement.AttrIsReassigned = (bool?) outParamUserList.CurrentRec.ssIsReassigned;
// Write optimized tmpoutParamUserListElement.AttrIsSubstitute
tmpoutParamUserListElement.AttrIsSubstitute = (bool?) false;
tmpoutParamUserList1List.Add(tmpoutParamUserListElement);
outParamUserList.Advance();
}

} finally {
outParamUserList.EndIteration();
}

result.outParamUserList = new RestList<ssConectaProveedores.RestRecords.RESTST_34625f5643caa3d12448dcec7dd4c7d3Structure>(tmpoutParamUserList1List.ToArray(), default(ssConectaProveedores.RestRecords.RESTST_34625f5643caa3d12448dcec7dd4c7d3Structure));
}

return result;
}


    public static ConectaProveedores_y_Utils_Wb_FolioEntra_Historic_DataActionGetEntraUserManagerList_Model ToModel(RESTConectaProveedores_y_Utils_Wb_FolioEntra_Historic_DataActionGetEntraUserManagerList_Outputs variables) {ConectaProveedores_y_Utils_Wb_FolioEntra_Historic_DataActionGetEntraUserManagerList_Model result = new ConectaProveedores_y_Utils_Wb_FolioEntra_Historic_DataActionGetEntraUserManagerList_Model();
result.outParamUserList = variables == null ? new RL_4af3045b114dbc57d1481fed5aceb93a() : RL_4af3045b114dbc57d1481fed5aceb93a.FromRestList(variables.outParamUserList, ssConectaProveedores.RestRecords.RESTST_34625f5643caa3d12448dcec7dd4c7d3Structure.ToStructure);
return result;
}


    public static RESTConectaProveedores_y_Utils_Wb_FolioEntra_Historic_DataActionGetEntraUserManagerList_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_y_Utils_Wb_FolioEntra_Historic_DataActionGetEntraUserManagerList_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_y_Utils_Wb_FolioEntra_Historic_DataActionGetEntraUserManagerList_Outputs result = new RESTConectaProveedores_y_Utils_Wb_FolioEntra_Historic_DataActionGetEntraUserManagerList_Outputs();
result.outParamUserList = screenModel.outParamUserList.ToRestList<ssConectaProveedores.RestRecords.RESTST_34625f5643caa3d12448dcec7dd4c7d3Structure>(ssConectaProveedores.RestRecords.RESTST_34625f5643caa3d12448dcec7dd4c7d3Structure.FromStructureDelegate(conf));
return result;
}

}
