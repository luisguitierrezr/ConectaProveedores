using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsList_DataActionGetProposalStatus_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("List")]
public RestList<ssConectaProveedores.RestRecords.RESTEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord> outParamList;
[JsonProperty("PreSelected")]
public RestList<ssConectaProveedores.RestRecords.RESTEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord> outParamPreSelected;


    public static RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsList_DataActionGetProposalStatus_Outputs FromOutputs(IBehaviorsConfiguration conf, RL_04d8560c4ed76bbcba77135048f4ff7f outParamList, RL_04d8560c4ed76bbcba77135048f4ff7f outParamPreSelected) {RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsList_DataActionGetProposalStatus_Outputs result = new RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsList_DataActionGetProposalStatus_Outputs();
// Write the needed fields of the list outParamList to the result.outParamList
ssConectaProveedores.RestRecords.RESTEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord tmpoutParamListElement;
if(outParamList.Empty) {
// Write the needed fields of the record outParamList.CurrentRec to the tmpoutParamListElement
tmpoutParamListElement = new ssConectaProveedores.RestRecords.RESTEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord();
tmpoutParamListElement.AttrId = (int?) outParamList.CurrentRec.ssId;
tmpoutParamListElement.AttrLabel = outParamList.CurrentRec.ssLabel;
// Write optimized tmpoutParamListElement.AttrClass
tmpoutParamListElement.AttrClass = "";
// Write optimized tmpoutParamListElement.AttrOrder
tmpoutParamListElement.AttrOrder = (int?) 0;
// Write optimized tmpoutParamListElement.AttrIs_Active
tmpoutParamListElement.AttrIs_Active = (bool?) false;
result.outParamList = new RestList<ssConectaProveedores.RestRecords.RESTEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord>(new ssConectaProveedores.RestRecords.RESTEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord[] {}, tmpoutParamListElement);
} else {
List<ssConectaProveedores.RestRecords.RESTEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord>
 tmpoutParamList1List = new List<ssConectaProveedores.RestRecords.RESTEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord>
();
try {outParamList.StartIteration();
while (!(outParamList.Eof)) {
// Write the needed fields of the record outParamList.CurrentRec to the tmpoutParamListElement
tmpoutParamListElement = new ssConectaProveedores.RestRecords.RESTEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord();
tmpoutParamListElement.AttrId = (int?) outParamList.CurrentRec.ssId;
tmpoutParamListElement.AttrLabel = outParamList.CurrentRec.ssLabel;
// Write optimized tmpoutParamListElement.AttrClass
tmpoutParamListElement.AttrClass = "";
// Write optimized tmpoutParamListElement.AttrOrder
tmpoutParamListElement.AttrOrder = (int?) 0;
// Write optimized tmpoutParamListElement.AttrIs_Active
tmpoutParamListElement.AttrIs_Active = (bool?) false;
tmpoutParamList1List.Add(tmpoutParamListElement);
outParamList.Advance();
}

} finally {
outParamList.EndIteration();
}

result.outParamList = new RestList<ssConectaProveedores.RestRecords.RESTEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord>(tmpoutParamList1List.ToArray(), default(ssConectaProveedores.RestRecords.RESTEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord));
}

// Write the needed fields of the list outParamPreSelected to the result.outParamPreSelected
ssConectaProveedores.RestRecords.RESTEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord tmpoutParamPreSelectedElement;
if(outParamPreSelected.Empty) {
// Write the needed fields of the record outParamPreSelected.CurrentRec to the tmpoutParamPreSelectedElement
tmpoutParamPreSelectedElement = new ssConectaProveedores.RestRecords.RESTEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord();
tmpoutParamPreSelectedElement.AttrId = (int?) outParamPreSelected.CurrentRec.ssId;
tmpoutParamPreSelectedElement.AttrLabel = outParamPreSelected.CurrentRec.ssLabel;
// Write optimized tmpoutParamPreSelectedElement.AttrClass
tmpoutParamPreSelectedElement.AttrClass = "";
// Write optimized tmpoutParamPreSelectedElement.AttrOrder
tmpoutParamPreSelectedElement.AttrOrder = (int?) 0;
// Write optimized tmpoutParamPreSelectedElement.AttrIs_Active
tmpoutParamPreSelectedElement.AttrIs_Active = (bool?) false;
result.outParamPreSelected = new RestList<ssConectaProveedores.RestRecords.RESTEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord>(new ssConectaProveedores.RestRecords.RESTEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord[] {}, tmpoutParamPreSelectedElement);
} else {
List<ssConectaProveedores.RestRecords.RESTEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord>
 tmpoutParamPreSelected1List = new List<ssConectaProveedores.RestRecords.RESTEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord>
();
try {outParamPreSelected.StartIteration();
while (!(outParamPreSelected.Eof)) {
// Write the needed fields of the record outParamPreSelected.CurrentRec to the tmpoutParamPreSelectedElement
tmpoutParamPreSelectedElement = new ssConectaProveedores.RestRecords.RESTEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord();
tmpoutParamPreSelectedElement.AttrId = (int?) outParamPreSelected.CurrentRec.ssId;
tmpoutParamPreSelectedElement.AttrLabel = outParamPreSelected.CurrentRec.ssLabel;
// Write optimized tmpoutParamPreSelectedElement.AttrClass
tmpoutParamPreSelectedElement.AttrClass = "";
// Write optimized tmpoutParamPreSelectedElement.AttrOrder
tmpoutParamPreSelectedElement.AttrOrder = (int?) 0;
// Write optimized tmpoutParamPreSelectedElement.AttrIs_Active
tmpoutParamPreSelectedElement.AttrIs_Active = (bool?) false;
tmpoutParamPreSelected1List.Add(tmpoutParamPreSelectedElement);
outParamPreSelected.Advance();
}

} finally {
outParamPreSelected.EndIteration();
}

result.outParamPreSelected = new RestList<ssConectaProveedores.RestRecords.RESTEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord>(tmpoutParamPreSelected1List.ToArray(), default(ssConectaProveedores.RestRecords.RESTEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord));
}

return result;
}


    public static ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsList_DataActionGetProposalStatus_Model ToModel(RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsList_DataActionGetProposalStatus_Outputs variables) {ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsList_DataActionGetProposalStatus_Model result = new ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsList_DataActionGetProposalStatus_Model();
result.outParamList = variables == null ? new RL_04d8560c4ed76bbcba77135048f4ff7f() : RL_04d8560c4ed76bbcba77135048f4ff7f.FromRestList(variables.outParamList, ssConectaProveedores.RestRecords.RESTEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord.ToStructure);
result.outParamPreSelected = variables == null ? new RL_04d8560c4ed76bbcba77135048f4ff7f() : RL_04d8560c4ed76bbcba77135048f4ff7f.FromRestList(variables.outParamPreSelected, ssConectaProveedores.RestRecords.RESTEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord.ToStructure);
return result;
}


    public static RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsList_DataActionGetProposalStatus_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsList_DataActionGetProposalStatus_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsList_DataActionGetProposalStatus_Outputs result = new RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsList_DataActionGetProposalStatus_Outputs();
result.outParamList = screenModel.outParamList.ToRestList<ssConectaProveedores.RestRecords.RESTEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord>(ssConectaProveedores.RestRecords.RESTEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord.FromStructureDelegate(conf));
result.outParamPreSelected = screenModel.outParamPreSelected.ToRestList<ssConectaProveedores.RestRecords.RESTEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord>(ssConectaProveedores.RestRecords.RESTEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord.FromStructureDelegate(conf));
return result;
}

}
