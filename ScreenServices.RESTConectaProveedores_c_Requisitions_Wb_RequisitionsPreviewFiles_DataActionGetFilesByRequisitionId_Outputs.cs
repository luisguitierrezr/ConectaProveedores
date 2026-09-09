using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewFiles_DataActionGetFilesByRequisitionId_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("FilesPDF")]
public RestList<ssConectaProveedores.RestRecords.RESTST_8917d167cfa0f31ec1ed2a0d24e80bccStructure> outParamFilesPDF;
[JsonProperty("FilesXML")]
public RestList<ssConectaProveedores.RestRecords.RESTST_8917d167cfa0f31ec1ed2a0d24e80bccStructure> outParamFilesXML;
[JsonProperty("OtherFiles")]
public RestList<ssConectaProveedores.RestRecords.RESTST_8917d167cfa0f31ec1ed2a0d24e80bccStructure> outParamOtherFiles;


    public static RESTConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewFiles_DataActionGetFilesByRequisitionId_Outputs FromOutputs(IBehaviorsConfiguration conf, RL_b48e8aa5377b7b15faec0f07ad9facf2 outParamFilesPDF, RL_b48e8aa5377b7b15faec0f07ad9facf2 outParamFilesXML, RL_b48e8aa5377b7b15faec0f07ad9facf2 outParamOtherFiles) {RESTConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewFiles_DataActionGetFilesByRequisitionId_Outputs result = new RESTConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewFiles_DataActionGetFilesByRequisitionId_Outputs();
// Write the needed fields of the list outParamFilesPDF to the result.outParamFilesPDF
ssConectaProveedores.RestRecords.RESTST_8917d167cfa0f31ec1ed2a0d24e80bccStructure tmpoutParamFilesPDFElement;
if(outParamFilesPDF.Empty) {
// Write the needed fields of the record outParamFilesPDF.CurrentRec to the tmpoutParamFilesPDFElement
tmpoutParamFilesPDFElement = new ssConectaProveedores.RestRecords.RESTST_8917d167cfa0f31ec1ed2a0d24e80bccStructure();
tmpoutParamFilesPDFElement.AttrStorageId = (long?) outParamFilesPDF.CurrentRec.ssStorageId;
tmpoutParamFilesPDFElement.AttrFilename = outParamFilesPDF.CurrentRec.ssFilename;
tmpoutParamFilesPDFElement.AttrSize = (long?) outParamFilesPDF.CurrentRec.ssSize;
result.outParamFilesPDF = new RestList<ssConectaProveedores.RestRecords.RESTST_8917d167cfa0f31ec1ed2a0d24e80bccStructure>(new ssConectaProveedores.RestRecords.RESTST_8917d167cfa0f31ec1ed2a0d24e80bccStructure[] {}, tmpoutParamFilesPDFElement);
} else {
List<ssConectaProveedores.RestRecords.RESTST_8917d167cfa0f31ec1ed2a0d24e80bccStructure>
 tmpoutParamFilesPDF1List = new List<ssConectaProveedores.RestRecords.RESTST_8917d167cfa0f31ec1ed2a0d24e80bccStructure>
();
try {outParamFilesPDF.StartIteration();
while (!(outParamFilesPDF.Eof)) {
// Write the needed fields of the record outParamFilesPDF.CurrentRec to the tmpoutParamFilesPDFElement
tmpoutParamFilesPDFElement = new ssConectaProveedores.RestRecords.RESTST_8917d167cfa0f31ec1ed2a0d24e80bccStructure();
tmpoutParamFilesPDFElement.AttrStorageId = (long?) outParamFilesPDF.CurrentRec.ssStorageId;
tmpoutParamFilesPDFElement.AttrFilename = outParamFilesPDF.CurrentRec.ssFilename;
tmpoutParamFilesPDFElement.AttrSize = (long?) outParamFilesPDF.CurrentRec.ssSize;
tmpoutParamFilesPDF1List.Add(tmpoutParamFilesPDFElement);
outParamFilesPDF.Advance();
}

} finally {
outParamFilesPDF.EndIteration();
}

result.outParamFilesPDF = new RestList<ssConectaProveedores.RestRecords.RESTST_8917d167cfa0f31ec1ed2a0d24e80bccStructure>(tmpoutParamFilesPDF1List.ToArray(), default(ssConectaProveedores.RestRecords.RESTST_8917d167cfa0f31ec1ed2a0d24e80bccStructure));
}

// Write the needed fields of the list outParamFilesXML to the result.outParamFilesXML
ssConectaProveedores.RestRecords.RESTST_8917d167cfa0f31ec1ed2a0d24e80bccStructure tmpoutParamFilesXMLElement;
if(outParamFilesXML.Empty) {
// Write the needed fields of the record outParamFilesXML.CurrentRec to the tmpoutParamFilesXMLElement
tmpoutParamFilesXMLElement = new ssConectaProveedores.RestRecords.RESTST_8917d167cfa0f31ec1ed2a0d24e80bccStructure();
tmpoutParamFilesXMLElement.AttrStorageId = (long?) outParamFilesXML.CurrentRec.ssStorageId;
tmpoutParamFilesXMLElement.AttrFilename = outParamFilesXML.CurrentRec.ssFilename;
tmpoutParamFilesXMLElement.AttrSize = (long?) outParamFilesXML.CurrentRec.ssSize;
result.outParamFilesXML = new RestList<ssConectaProveedores.RestRecords.RESTST_8917d167cfa0f31ec1ed2a0d24e80bccStructure>(new ssConectaProveedores.RestRecords.RESTST_8917d167cfa0f31ec1ed2a0d24e80bccStructure[] {}, tmpoutParamFilesXMLElement);
} else {
List<ssConectaProveedores.RestRecords.RESTST_8917d167cfa0f31ec1ed2a0d24e80bccStructure>
 tmpoutParamFilesXML1List = new List<ssConectaProveedores.RestRecords.RESTST_8917d167cfa0f31ec1ed2a0d24e80bccStructure>
();
try {outParamFilesXML.StartIteration();
while (!(outParamFilesXML.Eof)) {
// Write the needed fields of the record outParamFilesXML.CurrentRec to the tmpoutParamFilesXMLElement
tmpoutParamFilesXMLElement = new ssConectaProveedores.RestRecords.RESTST_8917d167cfa0f31ec1ed2a0d24e80bccStructure();
tmpoutParamFilesXMLElement.AttrStorageId = (long?) outParamFilesXML.CurrentRec.ssStorageId;
tmpoutParamFilesXMLElement.AttrFilename = outParamFilesXML.CurrentRec.ssFilename;
tmpoutParamFilesXMLElement.AttrSize = (long?) outParamFilesXML.CurrentRec.ssSize;
tmpoutParamFilesXML1List.Add(tmpoutParamFilesXMLElement);
outParamFilesXML.Advance();
}

} finally {
outParamFilesXML.EndIteration();
}

result.outParamFilesXML = new RestList<ssConectaProveedores.RestRecords.RESTST_8917d167cfa0f31ec1ed2a0d24e80bccStructure>(tmpoutParamFilesXML1List.ToArray(), default(ssConectaProveedores.RestRecords.RESTST_8917d167cfa0f31ec1ed2a0d24e80bccStructure));
}

// Write the needed fields of the list outParamOtherFiles to the result.outParamOtherFiles
ssConectaProveedores.RestRecords.RESTST_8917d167cfa0f31ec1ed2a0d24e80bccStructure tmpoutParamOtherFilesElement;
if(outParamOtherFiles.Empty) {
// Write the needed fields of the record outParamOtherFiles.CurrentRec to the tmpoutParamOtherFilesElement
tmpoutParamOtherFilesElement = new ssConectaProveedores.RestRecords.RESTST_8917d167cfa0f31ec1ed2a0d24e80bccStructure();
tmpoutParamOtherFilesElement.AttrStorageId = (long?) outParamOtherFiles.CurrentRec.ssStorageId;
tmpoutParamOtherFilesElement.AttrFilename = outParamOtherFiles.CurrentRec.ssFilename;
tmpoutParamOtherFilesElement.AttrSize = (long?) outParamOtherFiles.CurrentRec.ssSize;
result.outParamOtherFiles = new RestList<ssConectaProveedores.RestRecords.RESTST_8917d167cfa0f31ec1ed2a0d24e80bccStructure>(new ssConectaProveedores.RestRecords.RESTST_8917d167cfa0f31ec1ed2a0d24e80bccStructure[] {}, tmpoutParamOtherFilesElement);
} else {
List<ssConectaProveedores.RestRecords.RESTST_8917d167cfa0f31ec1ed2a0d24e80bccStructure>
 tmpoutParamOtherFiles1List = new List<ssConectaProveedores.RestRecords.RESTST_8917d167cfa0f31ec1ed2a0d24e80bccStructure>
();
try {outParamOtherFiles.StartIteration();
while (!(outParamOtherFiles.Eof)) {
// Write the needed fields of the record outParamOtherFiles.CurrentRec to the tmpoutParamOtherFilesElement
tmpoutParamOtherFilesElement = new ssConectaProveedores.RestRecords.RESTST_8917d167cfa0f31ec1ed2a0d24e80bccStructure();
tmpoutParamOtherFilesElement.AttrStorageId = (long?) outParamOtherFiles.CurrentRec.ssStorageId;
tmpoutParamOtherFilesElement.AttrFilename = outParamOtherFiles.CurrentRec.ssFilename;
tmpoutParamOtherFilesElement.AttrSize = (long?) outParamOtherFiles.CurrentRec.ssSize;
tmpoutParamOtherFiles1List.Add(tmpoutParamOtherFilesElement);
outParamOtherFiles.Advance();
}

} finally {
outParamOtherFiles.EndIteration();
}

result.outParamOtherFiles = new RestList<ssConectaProveedores.RestRecords.RESTST_8917d167cfa0f31ec1ed2a0d24e80bccStructure>(tmpoutParamOtherFiles1List.ToArray(), default(ssConectaProveedores.RestRecords.RESTST_8917d167cfa0f31ec1ed2a0d24e80bccStructure));
}

return result;
}


    public static ConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewFiles_DataActionGetFilesByRequisitionId_Model ToModel(RESTConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewFiles_DataActionGetFilesByRequisitionId_Outputs variables) {ConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewFiles_DataActionGetFilesByRequisitionId_Model result = new ConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewFiles_DataActionGetFilesByRequisitionId_Model();
result.outParamFilesPDF = variables == null ? new RL_b48e8aa5377b7b15faec0f07ad9facf2() : RL_b48e8aa5377b7b15faec0f07ad9facf2.FromRestList(variables.outParamFilesPDF, ssConectaProveedores.RestRecords.RESTST_8917d167cfa0f31ec1ed2a0d24e80bccStructure.ToStructure);
result.outParamFilesXML = variables == null ? new RL_b48e8aa5377b7b15faec0f07ad9facf2() : RL_b48e8aa5377b7b15faec0f07ad9facf2.FromRestList(variables.outParamFilesXML, ssConectaProveedores.RestRecords.RESTST_8917d167cfa0f31ec1ed2a0d24e80bccStructure.ToStructure);
result.outParamOtherFiles = variables == null ? new RL_b48e8aa5377b7b15faec0f07ad9facf2() : RL_b48e8aa5377b7b15faec0f07ad9facf2.FromRestList(variables.outParamOtherFiles, ssConectaProveedores.RestRecords.RESTST_8917d167cfa0f31ec1ed2a0d24e80bccStructure.ToStructure);
return result;
}


    public static RESTConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewFiles_DataActionGetFilesByRequisitionId_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewFiles_DataActionGetFilesByRequisitionId_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewFiles_DataActionGetFilesByRequisitionId_Outputs result = new RESTConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewFiles_DataActionGetFilesByRequisitionId_Outputs();
result.outParamFilesPDF = screenModel.outParamFilesPDF.ToRestList<ssConectaProveedores.RestRecords.RESTST_8917d167cfa0f31ec1ed2a0d24e80bccStructure>(ssConectaProveedores.RestRecords.RESTST_8917d167cfa0f31ec1ed2a0d24e80bccStructure.FromStructureDelegate(conf));
result.outParamFilesXML = screenModel.outParamFilesXML.ToRestList<ssConectaProveedores.RestRecords.RESTST_8917d167cfa0f31ec1ed2a0d24e80bccStructure>(ssConectaProveedores.RestRecords.RESTST_8917d167cfa0f31ec1ed2a0d24e80bccStructure.FromStructureDelegate(conf));
result.outParamOtherFiles = screenModel.outParamOtherFiles.ToRestList<ssConectaProveedores.RestRecords.RESTST_8917d167cfa0f31ec1ed2a0d24e80bccStructure>(ssConectaProveedores.RestRecords.RESTST_8917d167cfa0f31ec1ed2a0d24e80bccStructure.FromStructureDelegate(conf));
return result;
}

}
