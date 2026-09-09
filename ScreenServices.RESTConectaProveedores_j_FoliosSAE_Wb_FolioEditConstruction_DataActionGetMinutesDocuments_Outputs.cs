using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_DataActionGetMinutesDocuments_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("List")]
public RestList<ssConectaProveedores.RestRecords.RESTST_e2ce4ef6ecd16e4be5db908d06bb6674Structure> outParamList;
[JsonProperty("FilesList2")]
public RestList<ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure> outParamFilesList2;


    public static RESTConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_DataActionGetMinutesDocuments_Outputs FromOutputs(IBehaviorsConfiguration conf, RL_9fb5c5e988576f6c521a9ef779213183 outParamList, RL_1501ee54ff868a67eff67465502ee3d9 outParamFilesList2) {RESTConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_DataActionGetMinutesDocuments_Outputs result = new RESTConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_DataActionGetMinutesDocuments_Outputs();
// Write the needed fields of the list outParamList to the result.outParamList
ssConectaProveedores.RestRecords.RESTST_e2ce4ef6ecd16e4be5db908d06bb6674Structure tmpoutParamListElement;
if(outParamList.Empty) {
// Write the needed fields of the record outParamList.CurrentRec to the tmpoutParamListElement
tmpoutParamListElement = new ssConectaProveedores.RestRecords.RESTST_e2ce4ef6ecd16e4be5db908d06bb6674Structure();
tmpoutParamListElement.AttrKey = (int?) outParamList.CurrentRec.ssKey;
tmpoutParamListElement.AttrValue = outParamList.CurrentRec.ssValue;
tmpoutParamListElement.AttrFileName = outParamList.CurrentRec.ssFileName;
tmpoutParamListElement.AttrMandatory = (bool?) outParamList.CurrentRec.ssMandatory;
tmpoutParamListElement.AttrWithDocument = (bool?) outParamList.CurrentRec.ssWithDocument;
tmpoutParamListElement.AttrStorageId = (long?) outParamList.CurrentRec.ssStorageId;
result.outParamList = new RestList<ssConectaProveedores.RestRecords.RESTST_e2ce4ef6ecd16e4be5db908d06bb6674Structure>(new ssConectaProveedores.RestRecords.RESTST_e2ce4ef6ecd16e4be5db908d06bb6674Structure[] {}, tmpoutParamListElement);
} else {
List<ssConectaProveedores.RestRecords.RESTST_e2ce4ef6ecd16e4be5db908d06bb6674Structure>
 tmpoutParamList1List = new List<ssConectaProveedores.RestRecords.RESTST_e2ce4ef6ecd16e4be5db908d06bb6674Structure>
();
try {outParamList.StartIteration();
while (!(outParamList.Eof)) {
// Write the needed fields of the record outParamList.CurrentRec to the tmpoutParamListElement
tmpoutParamListElement = new ssConectaProveedores.RestRecords.RESTST_e2ce4ef6ecd16e4be5db908d06bb6674Structure();
tmpoutParamListElement.AttrKey = (int?) outParamList.CurrentRec.ssKey;
tmpoutParamListElement.AttrValue = outParamList.CurrentRec.ssValue;
tmpoutParamListElement.AttrFileName = outParamList.CurrentRec.ssFileName;
tmpoutParamListElement.AttrMandatory = (bool?) outParamList.CurrentRec.ssMandatory;
tmpoutParamListElement.AttrWithDocument = (bool?) outParamList.CurrentRec.ssWithDocument;
tmpoutParamListElement.AttrStorageId = (long?) outParamList.CurrentRec.ssStorageId;
tmpoutParamList1List.Add(tmpoutParamListElement);
outParamList.Advance();
}

} finally {
outParamList.EndIteration();
}

result.outParamList = new RestList<ssConectaProveedores.RestRecords.RESTST_e2ce4ef6ecd16e4be5db908d06bb6674Structure>(tmpoutParamList1List.ToArray(), default(ssConectaProveedores.RestRecords.RESTST_e2ce4ef6ecd16e4be5db908d06bb6674Structure));
}

// Write the needed fields of the list outParamFilesList2 to the result.outParamFilesList2
ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure tmpoutParamFilesList2Element;
if(outParamFilesList2.Empty) {
// Write the needed fields of the record outParamFilesList2.CurrentRec to the tmpoutParamFilesList2Element
tmpoutParamFilesList2Element = new ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure();
tmpoutParamFilesList2Element.AttrName = outParamFilesList2.CurrentRec.ssName;
tmpoutParamFilesList2Element.AttrBinaryData = outParamFilesList2.CurrentRec.ssBinaryData;
tmpoutParamFilesList2Element.AttrIsExtra = (bool?) outParamFilesList2.CurrentRec.ssIsExtra;
tmpoutParamFilesList2Element.AttrStorageId = (long?) outParamFilesList2.CurrentRec.ssStorageId;
tmpoutParamFilesList2Element.AttrFileId = (long?) outParamFilesList2.CurrentRec.ssFileId;
result.outParamFilesList2 = new RestList<ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure>(new ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure[] {}, tmpoutParamFilesList2Element);
} else {
List<ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure>
 tmpoutParamFilesList21List = new List<ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure>
();
try {outParamFilesList2.StartIteration();
while (!(outParamFilesList2.Eof)) {
// Write the needed fields of the record outParamFilesList2.CurrentRec to the tmpoutParamFilesList2Element
tmpoutParamFilesList2Element = new ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure();
tmpoutParamFilesList2Element.AttrName = outParamFilesList2.CurrentRec.ssName;
tmpoutParamFilesList2Element.AttrBinaryData = outParamFilesList2.CurrentRec.ssBinaryData;
tmpoutParamFilesList2Element.AttrIsExtra = (bool?) outParamFilesList2.CurrentRec.ssIsExtra;
tmpoutParamFilesList2Element.AttrStorageId = (long?) outParamFilesList2.CurrentRec.ssStorageId;
tmpoutParamFilesList2Element.AttrFileId = (long?) outParamFilesList2.CurrentRec.ssFileId;
tmpoutParamFilesList21List.Add(tmpoutParamFilesList2Element);
outParamFilesList2.Advance();
}

} finally {
outParamFilesList2.EndIteration();
}

result.outParamFilesList2 = new RestList<ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure>(tmpoutParamFilesList21List.ToArray(), default(ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure));
}

return result;
}


    public static ConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_DataActionGetMinutesDocuments_Model ToModel(RESTConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_DataActionGetMinutesDocuments_Outputs variables) {ConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_DataActionGetMinutesDocuments_Model result = new ConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_DataActionGetMinutesDocuments_Model();
result.outParamList = variables == null ? new RL_9fb5c5e988576f6c521a9ef779213183() : RL_9fb5c5e988576f6c521a9ef779213183.FromRestList(variables.outParamList, ssConectaProveedores.RestRecords.RESTST_e2ce4ef6ecd16e4be5db908d06bb6674Structure.ToStructure);
result.outParamFilesList2 = variables == null ? new RL_1501ee54ff868a67eff67465502ee3d9() : RL_1501ee54ff868a67eff67465502ee3d9.FromRestList(variables.outParamFilesList2, ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure.ToStructure);
return result;
}


    public static RESTConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_DataActionGetMinutesDocuments_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_DataActionGetMinutesDocuments_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_DataActionGetMinutesDocuments_Outputs result = new RESTConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_DataActionGetMinutesDocuments_Outputs();
result.outParamList = screenModel.outParamList.ToRestList<ssConectaProveedores.RestRecords.RESTST_e2ce4ef6ecd16e4be5db908d06bb6674Structure>(ssConectaProveedores.RestRecords.RESTST_e2ce4ef6ecd16e4be5db908d06bb6674Structure.FromStructureDelegate(conf));
result.outParamFilesList2 = screenModel.outParamFilesList2.ToRestList<ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure>(ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure.FromStructureDelegate(conf));
return result;
}

}
