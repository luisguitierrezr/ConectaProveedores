using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_Wb_FolioCreateConstruction_DataActionGetMinutesDocuments_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("List")]
public RestList<ssConectaProveedores.RestRecords.RESTST_b2fd0f57faec93f17ef861f417f1cd5cStructure> outParamList;


    public static RESTConectaProveedores_j_FoliosSAE_Wb_FolioCreateConstruction_DataActionGetMinutesDocuments_Outputs FromOutputs(IBehaviorsConfiguration conf, RL_f4c5cb6ef02fae333513cbd4dafd500c outParamList) {RESTConectaProveedores_j_FoliosSAE_Wb_FolioCreateConstruction_DataActionGetMinutesDocuments_Outputs result = new RESTConectaProveedores_j_FoliosSAE_Wb_FolioCreateConstruction_DataActionGetMinutesDocuments_Outputs();
// Write the needed fields of the list outParamList to the result.outParamList
ssConectaProveedores.RestRecords.RESTST_b2fd0f57faec93f17ef861f417f1cd5cStructure tmpoutParamListElement;
if(outParamList.Empty) {
// Write the needed fields of the record outParamList.CurrentRec to the tmpoutParamListElement
tmpoutParamListElement = new ssConectaProveedores.RestRecords.RESTST_b2fd0f57faec93f17ef861f417f1cd5cStructure();
tmpoutParamListElement.AttrKey = (int?) outParamList.CurrentRec.ssKey;
tmpoutParamListElement.AttrValue = outParamList.CurrentRec.ssValue;
tmpoutParamListElement.AttrFileName = outParamList.CurrentRec.ssFileName;
tmpoutParamListElement.AttrMandatory = (bool?) outParamList.CurrentRec.ssMandatory;
tmpoutParamListElement.AttrWithDocument = (bool?) outParamList.CurrentRec.ssWithDocument;
result.outParamList = new RestList<ssConectaProveedores.RestRecords.RESTST_b2fd0f57faec93f17ef861f417f1cd5cStructure>(new ssConectaProveedores.RestRecords.RESTST_b2fd0f57faec93f17ef861f417f1cd5cStructure[] {}, tmpoutParamListElement);
} else {
List<ssConectaProveedores.RestRecords.RESTST_b2fd0f57faec93f17ef861f417f1cd5cStructure>
 tmpoutParamList1List = new List<ssConectaProveedores.RestRecords.RESTST_b2fd0f57faec93f17ef861f417f1cd5cStructure>
();
try {outParamList.StartIteration();
while (!(outParamList.Eof)) {
// Write the needed fields of the record outParamList.CurrentRec to the tmpoutParamListElement
tmpoutParamListElement = new ssConectaProveedores.RestRecords.RESTST_b2fd0f57faec93f17ef861f417f1cd5cStructure();
tmpoutParamListElement.AttrKey = (int?) outParamList.CurrentRec.ssKey;
tmpoutParamListElement.AttrValue = outParamList.CurrentRec.ssValue;
tmpoutParamListElement.AttrFileName = outParamList.CurrentRec.ssFileName;
tmpoutParamListElement.AttrMandatory = (bool?) outParamList.CurrentRec.ssMandatory;
tmpoutParamListElement.AttrWithDocument = (bool?) outParamList.CurrentRec.ssWithDocument;
tmpoutParamList1List.Add(tmpoutParamListElement);
outParamList.Advance();
}

} finally {
outParamList.EndIteration();
}

result.outParamList = new RestList<ssConectaProveedores.RestRecords.RESTST_b2fd0f57faec93f17ef861f417f1cd5cStructure>(tmpoutParamList1List.ToArray(), default(ssConectaProveedores.RestRecords.RESTST_b2fd0f57faec93f17ef861f417f1cd5cStructure));
}

return result;
}


    public static ConectaProveedores_j_FoliosSAE_Wb_FolioCreateConstruction_DataActionGetMinutesDocuments_Model ToModel(RESTConectaProveedores_j_FoliosSAE_Wb_FolioCreateConstruction_DataActionGetMinutesDocuments_Outputs variables) {ConectaProveedores_j_FoliosSAE_Wb_FolioCreateConstruction_DataActionGetMinutesDocuments_Model result = new ConectaProveedores_j_FoliosSAE_Wb_FolioCreateConstruction_DataActionGetMinutesDocuments_Model();
result.outParamList = variables == null ? new RL_f4c5cb6ef02fae333513cbd4dafd500c() : RL_f4c5cb6ef02fae333513cbd4dafd500c.FromRestList(variables.outParamList, ssConectaProveedores.RestRecords.RESTST_b2fd0f57faec93f17ef861f417f1cd5cStructure.ToStructure);
return result;
}


    public static RESTConectaProveedores_j_FoliosSAE_Wb_FolioCreateConstruction_DataActionGetMinutesDocuments_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_j_FoliosSAE_Wb_FolioCreateConstruction_DataActionGetMinutesDocuments_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_j_FoliosSAE_Wb_FolioCreateConstruction_DataActionGetMinutesDocuments_Outputs result = new RESTConectaProveedores_j_FoliosSAE_Wb_FolioCreateConstruction_DataActionGetMinutesDocuments_Outputs();
result.outParamList = screenModel.outParamList.ToRestList<ssConectaProveedores.RestRecords.RESTST_b2fd0f57faec93f17ef861f417f1cd5cStructure>(ssConectaProveedores.RestRecords.RESTST_b2fd0f57faec93f17ef861f417f1cd5cStructure.FromStructureDelegate(conf));
return result;
}

}
