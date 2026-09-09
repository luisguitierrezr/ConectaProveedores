using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_a_Reassignments_Wb_ReassignmentForm_DataActionGetUsersSource_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("o_DirectReportsList")]
public RestList<ssConectaProveedores.RestRecords.RESTST_7d99a0be08bc4d3199f250548e6c4016Structure> outParamo_DirectReportsList;
[JsonProperty("o_HasError")]
public bool? outParamo_HasError;


    public static RESTConectaProveedores_a_Reassignments_Wb_ReassignmentForm_DataActionGetUsersSource_Outputs FromOutputs(IBehaviorsConfiguration conf, RL_33aa275c739b8b537ec846fb1cac5907 outParamo_DirectReportsList, bool outParamo_HasError) {RESTConectaProveedores_a_Reassignments_Wb_ReassignmentForm_DataActionGetUsersSource_Outputs result = new RESTConectaProveedores_a_Reassignments_Wb_ReassignmentForm_DataActionGetUsersSource_Outputs();
// Write the needed fields of the list outParamo_DirectReportsList to the result.outParamo_DirectReportsList
ssConectaProveedores.RestRecords.RESTST_7d99a0be08bc4d3199f250548e6c4016Structure tmpoutParamo_DirectReportsListElement;
if(outParamo_DirectReportsList.Empty) {
// Write the needed fields of the record outParamo_DirectReportsList.CurrentRec to the tmpoutParamo_DirectReportsListElement
tmpoutParamo_DirectReportsListElement = new ssConectaProveedores.RestRecords.RESTST_7d99a0be08bc4d3199f250548e6c4016Structure();
// Write optimized tmpoutParamo_DirectReportsListElement.AttrUserId
tmpoutParamo_DirectReportsListElement.AttrUserId = "";
tmpoutParamo_DirectReportsListElement.AttrName = outParamo_DirectReportsList.CurrentRec.ssName;
tmpoutParamo_DirectReportsListElement.AttrRole = outParamo_DirectReportsList.CurrentRec.ssRole;
tmpoutParamo_DirectReportsListElement.AttrEntraId = outParamo_DirectReportsList.CurrentRec.ssEntraId;
tmpoutParamo_DirectReportsListElement.AttrEmail = outParamo_DirectReportsList.CurrentRec.ssEmail;
// Write optimized tmpoutParamo_DirectReportsListElement.AttrLevel
tmpoutParamo_DirectReportsListElement.AttrLevel = (int?) 0;
result.outParamo_DirectReportsList = new RestList<ssConectaProveedores.RestRecords.RESTST_7d99a0be08bc4d3199f250548e6c4016Structure>(new ssConectaProveedores.RestRecords.RESTST_7d99a0be08bc4d3199f250548e6c4016Structure[] {}, tmpoutParamo_DirectReportsListElement);
} else {
List<ssConectaProveedores.RestRecords.RESTST_7d99a0be08bc4d3199f250548e6c4016Structure>
 tmpoutParamo_DirectReportsList1List = new List<ssConectaProveedores.RestRecords.RESTST_7d99a0be08bc4d3199f250548e6c4016Structure>
();
try {outParamo_DirectReportsList.StartIteration();
while (!(outParamo_DirectReportsList.Eof)) {
// Write the needed fields of the record outParamo_DirectReportsList.CurrentRec to the tmpoutParamo_DirectReportsListElement
tmpoutParamo_DirectReportsListElement = new ssConectaProveedores.RestRecords.RESTST_7d99a0be08bc4d3199f250548e6c4016Structure();
// Write optimized tmpoutParamo_DirectReportsListElement.AttrUserId
tmpoutParamo_DirectReportsListElement.AttrUserId = "";
tmpoutParamo_DirectReportsListElement.AttrName = outParamo_DirectReportsList.CurrentRec.ssName;
tmpoutParamo_DirectReportsListElement.AttrRole = outParamo_DirectReportsList.CurrentRec.ssRole;
tmpoutParamo_DirectReportsListElement.AttrEntraId = outParamo_DirectReportsList.CurrentRec.ssEntraId;
tmpoutParamo_DirectReportsListElement.AttrEmail = outParamo_DirectReportsList.CurrentRec.ssEmail;
// Write optimized tmpoutParamo_DirectReportsListElement.AttrLevel
tmpoutParamo_DirectReportsListElement.AttrLevel = (int?) 0;
tmpoutParamo_DirectReportsList1List.Add(tmpoutParamo_DirectReportsListElement);
outParamo_DirectReportsList.Advance();
}

} finally {
outParamo_DirectReportsList.EndIteration();
}

result.outParamo_DirectReportsList = new RestList<ssConectaProveedores.RestRecords.RESTST_7d99a0be08bc4d3199f250548e6c4016Structure>(tmpoutParamo_DirectReportsList1List.ToArray(), default(ssConectaProveedores.RestRecords.RESTST_7d99a0be08bc4d3199f250548e6c4016Structure));
}

result.outParamo_HasError = (bool?) outParamo_HasError;
return result;
}


    public static ConectaProveedores_a_Reassignments_Wb_ReassignmentForm_DataActionGetUsersSource_Model ToModel(RESTConectaProveedores_a_Reassignments_Wb_ReassignmentForm_DataActionGetUsersSource_Outputs variables) {ConectaProveedores_a_Reassignments_Wb_ReassignmentForm_DataActionGetUsersSource_Model result = new ConectaProveedores_a_Reassignments_Wb_ReassignmentForm_DataActionGetUsersSource_Model();
result.outParamo_DirectReportsList = variables == null ? new RL_33aa275c739b8b537ec846fb1cac5907() : RL_33aa275c739b8b537ec846fb1cac5907.FromRestList(variables.outParamo_DirectReportsList, ssConectaProveedores.RestRecords.RESTST_7d99a0be08bc4d3199f250548e6c4016Structure.ToStructure);
result.outParamo_HasError = variables == null || variables.outParamo_HasError == null ? false : variables.outParamo_HasError.Value;
return result;
}


    public static RESTConectaProveedores_a_Reassignments_Wb_ReassignmentForm_DataActionGetUsersSource_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_a_Reassignments_Wb_ReassignmentForm_DataActionGetUsersSource_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_a_Reassignments_Wb_ReassignmentForm_DataActionGetUsersSource_Outputs result = new RESTConectaProveedores_a_Reassignments_Wb_ReassignmentForm_DataActionGetUsersSource_Outputs();
result.outParamo_DirectReportsList = screenModel.outParamo_DirectReportsList.ToRestList<ssConectaProveedores.RestRecords.RESTST_7d99a0be08bc4d3199f250548e6c4016Structure>(ssConectaProveedores.RestRecords.RESTST_7d99a0be08bc4d3199f250548e6c4016Structure.FromStructureDelegate(conf));
result.outParamo_HasError = (bool?) screenModel.outParamo_HasError;
return result;
}

}
