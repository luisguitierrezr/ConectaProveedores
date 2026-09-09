using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_d_Invoices_Wb_InvoicesFilesPreview_DataActionGetInvoiceFiles_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("FilePDF")]
public long? outParamFilePDF;
[JsonProperty("FileSizePDF")]
public long? outParamFileSizePDF;
[JsonProperty("FileXML")]
public long? outParamFileXML;
[JsonProperty("FileSizeXML")]
public long? outParamFileSizeXML;
[JsonProperty("OtherFiles")]
public RestList<ssConectaProveedores.RestRecords.RESTST_8917d167cfa0f31ec1ed2a0d24e80bccStructure> outParamOtherFiles;


    public static RESTConectaProveedores_d_Invoices_Wb_InvoicesFilesPreview_DataActionGetInvoiceFiles_Outputs FromOutputs(IBehaviorsConfiguration conf, long outParamFilePDF, long outParamFileSizePDF, long outParamFileXML, long outParamFileSizeXML, RL_b48e8aa5377b7b15faec0f07ad9facf2 outParamOtherFiles) {RESTConectaProveedores_d_Invoices_Wb_InvoicesFilesPreview_DataActionGetInvoiceFiles_Outputs result = new RESTConectaProveedores_d_Invoices_Wb_InvoicesFilesPreview_DataActionGetInvoiceFiles_Outputs();
result.outParamFilePDF = (long?) outParamFilePDF;
result.outParamFileSizePDF = (long?) outParamFileSizePDF;
result.outParamFileXML = (long?) outParamFileXML;
result.outParamFileSizeXML = (long?) outParamFileSizeXML;
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


    public static ConectaProveedores_d_Invoices_Wb_InvoicesFilesPreview_DataActionGetInvoiceFiles_Model ToModel(RESTConectaProveedores_d_Invoices_Wb_InvoicesFilesPreview_DataActionGetInvoiceFiles_Outputs variables) {ConectaProveedores_d_Invoices_Wb_InvoicesFilesPreview_DataActionGetInvoiceFiles_Model result = new ConectaProveedores_d_Invoices_Wb_InvoicesFilesPreview_DataActionGetInvoiceFiles_Model();
result.outParamFilePDF = variables == null || variables.outParamFilePDF == null ? 0L : variables.outParamFilePDF.Value;
result.outParamFileSizePDF = variables == null || variables.outParamFileSizePDF == null ? 0L : variables.outParamFileSizePDF.Value;
result.outParamFileXML = variables == null || variables.outParamFileXML == null ? 0L : variables.outParamFileXML.Value;
result.outParamFileSizeXML = variables == null || variables.outParamFileSizeXML == null ? 0L : variables.outParamFileSizeXML.Value;
result.outParamOtherFiles = variables == null ? new RL_b48e8aa5377b7b15faec0f07ad9facf2() : RL_b48e8aa5377b7b15faec0f07ad9facf2.FromRestList(variables.outParamOtherFiles, ssConectaProveedores.RestRecords.RESTST_8917d167cfa0f31ec1ed2a0d24e80bccStructure.ToStructure);
return result;
}


    public static RESTConectaProveedores_d_Invoices_Wb_InvoicesFilesPreview_DataActionGetInvoiceFiles_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_d_Invoices_Wb_InvoicesFilesPreview_DataActionGetInvoiceFiles_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_d_Invoices_Wb_InvoicesFilesPreview_DataActionGetInvoiceFiles_Outputs result = new RESTConectaProveedores_d_Invoices_Wb_InvoicesFilesPreview_DataActionGetInvoiceFiles_Outputs();
result.outParamFilePDF = (long?) screenModel.outParamFilePDF;
result.outParamFileSizePDF = (long?) screenModel.outParamFileSizePDF;
result.outParamFileXML = (long?) screenModel.outParamFileXML;
result.outParamFileSizeXML = (long?) screenModel.outParamFileSizeXML;
result.outParamOtherFiles = screenModel.outParamOtherFiles.ToRestList<ssConectaProveedores.RestRecords.RESTST_8917d167cfa0f31ec1ed2a0d24e80bccStructure>(ssConectaProveedores.RestRecords.RESTST_8917d167cfa0f31ec1ed2a0d24e80bccStructure.FromStructureDelegate(conf));
return result;
}

}
