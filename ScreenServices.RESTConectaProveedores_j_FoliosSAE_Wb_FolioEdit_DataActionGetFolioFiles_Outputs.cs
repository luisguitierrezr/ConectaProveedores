using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_Wb_FolioEdit_DataActionGetFolioFiles_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("InvoiceMainFiles")]
public RestList<ssConectaProveedores.RestRecords.RESTST_d381fba44897ce4382b17d5149465d51Structure> outParamInvoiceMainFiles;


    public static RESTConectaProveedores_j_FoliosSAE_Wb_FolioEdit_DataActionGetFolioFiles_Outputs FromOutputs(IBehaviorsConfiguration conf, RL_cc11123f1ba1bfd417e2f33be28138e9 outParamInvoiceMainFiles) {RESTConectaProveedores_j_FoliosSAE_Wb_FolioEdit_DataActionGetFolioFiles_Outputs result = new RESTConectaProveedores_j_FoliosSAE_Wb_FolioEdit_DataActionGetFolioFiles_Outputs();
// Write the needed fields of the list outParamInvoiceMainFiles to the result.outParamInvoiceMainFiles
ssConectaProveedores.RestRecords.RESTST_d381fba44897ce4382b17d5149465d51Structure tmpoutParamInvoiceMainFilesElement;
if(outParamInvoiceMainFiles.Empty) {
// Write the needed fields of the record outParamInvoiceMainFiles.CurrentRec to the tmpoutParamInvoiceMainFilesElement
tmpoutParamInvoiceMainFilesElement = new ssConectaProveedores.RestRecords.RESTST_d381fba44897ce4382b17d5149465d51Structure();
// Write optimized tmpoutParamInvoiceMainFilesElement.AttrId
tmpoutParamInvoiceMainFilesElement.AttrId = (long?) 0L;
// Write optimized tmpoutParamInvoiceMainFilesElement.AttrInvoiceId
tmpoutParamInvoiceMainFilesElement.AttrInvoiceId = (long?) 0L;
tmpoutParamInvoiceMainFilesElement.AttrFilename = outParamInvoiceMainFiles.CurrentRec.ssFilename;
// Write optimized tmpoutParamInvoiceMainFilesElement.AttrIsExtra
tmpoutParamInvoiceMainFilesElement.AttrIsExtra = (bool?) false;
tmpoutParamInvoiceMainFilesElement.AttrStorageId = (long?) outParamInvoiceMainFiles.CurrentRec.ssStorageId;
tmpoutParamInvoiceMainFilesElement.AttrCreatedByName = outParamInvoiceMainFiles.CurrentRec.ssCreatedByName;
// Write optimized tmpoutParamInvoiceMainFilesElement.AttrCreatedBy
tmpoutParamInvoiceMainFilesElement.AttrCreatedBy = "";
tmpoutParamInvoiceMainFilesElement.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(outParamInvoiceMainFiles.CurrentRec.ssCreatedOn, conf.DateTimeFormat);
// Write optimized tmpoutParamInvoiceMainFilesElement.AttrInvoiceStatusLabel
tmpoutParamInvoiceMainFilesElement.AttrInvoiceStatusLabel = "";
// Write optimized tmpoutParamInvoiceMainFilesElement.AttrInvoiceStatusClass
tmpoutParamInvoiceMainFilesElement.AttrInvoiceStatusClass = "";
tmpoutParamInvoiceMainFilesElement.AttrSize = (long?) outParamInvoiceMainFiles.CurrentRec.ssSize;
result.outParamInvoiceMainFiles = new RestList<ssConectaProveedores.RestRecords.RESTST_d381fba44897ce4382b17d5149465d51Structure>(new ssConectaProveedores.RestRecords.RESTST_d381fba44897ce4382b17d5149465d51Structure[] {}, tmpoutParamInvoiceMainFilesElement);
} else {
List<ssConectaProveedores.RestRecords.RESTST_d381fba44897ce4382b17d5149465d51Structure>
 tmpoutParamInvoiceMainFiles1List = new List<ssConectaProveedores.RestRecords.RESTST_d381fba44897ce4382b17d5149465d51Structure>
();
try {outParamInvoiceMainFiles.StartIteration();
while (!(outParamInvoiceMainFiles.Eof)) {
// Write the needed fields of the record outParamInvoiceMainFiles.CurrentRec to the tmpoutParamInvoiceMainFilesElement
tmpoutParamInvoiceMainFilesElement = new ssConectaProveedores.RestRecords.RESTST_d381fba44897ce4382b17d5149465d51Structure();
// Write optimized tmpoutParamInvoiceMainFilesElement.AttrId
tmpoutParamInvoiceMainFilesElement.AttrId = (long?) 0L;
// Write optimized tmpoutParamInvoiceMainFilesElement.AttrInvoiceId
tmpoutParamInvoiceMainFilesElement.AttrInvoiceId = (long?) 0L;
tmpoutParamInvoiceMainFilesElement.AttrFilename = outParamInvoiceMainFiles.CurrentRec.ssFilename;
// Write optimized tmpoutParamInvoiceMainFilesElement.AttrIsExtra
tmpoutParamInvoiceMainFilesElement.AttrIsExtra = (bool?) false;
tmpoutParamInvoiceMainFilesElement.AttrStorageId = (long?) outParamInvoiceMainFiles.CurrentRec.ssStorageId;
tmpoutParamInvoiceMainFilesElement.AttrCreatedByName = outParamInvoiceMainFiles.CurrentRec.ssCreatedByName;
// Write optimized tmpoutParamInvoiceMainFilesElement.AttrCreatedBy
tmpoutParamInvoiceMainFilesElement.AttrCreatedBy = "";
tmpoutParamInvoiceMainFilesElement.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(outParamInvoiceMainFiles.CurrentRec.ssCreatedOn, conf.DateTimeFormat);
// Write optimized tmpoutParamInvoiceMainFilesElement.AttrInvoiceStatusLabel
tmpoutParamInvoiceMainFilesElement.AttrInvoiceStatusLabel = "";
// Write optimized tmpoutParamInvoiceMainFilesElement.AttrInvoiceStatusClass
tmpoutParamInvoiceMainFilesElement.AttrInvoiceStatusClass = "";
tmpoutParamInvoiceMainFilesElement.AttrSize = (long?) outParamInvoiceMainFiles.CurrentRec.ssSize;
tmpoutParamInvoiceMainFiles1List.Add(tmpoutParamInvoiceMainFilesElement);
outParamInvoiceMainFiles.Advance();
}

} finally {
outParamInvoiceMainFiles.EndIteration();
}

result.outParamInvoiceMainFiles = new RestList<ssConectaProveedores.RestRecords.RESTST_d381fba44897ce4382b17d5149465d51Structure>(tmpoutParamInvoiceMainFiles1List.ToArray(), default(ssConectaProveedores.RestRecords.RESTST_d381fba44897ce4382b17d5149465d51Structure));
}

return result;
}


    public static ConectaProveedores_j_FoliosSAE_Wb_FolioEdit_DataActionGetFolioFiles_Model ToModel(RESTConectaProveedores_j_FoliosSAE_Wb_FolioEdit_DataActionGetFolioFiles_Outputs variables) {ConectaProveedores_j_FoliosSAE_Wb_FolioEdit_DataActionGetFolioFiles_Model result = new ConectaProveedores_j_FoliosSAE_Wb_FolioEdit_DataActionGetFolioFiles_Model();
result.outParamInvoiceMainFiles = variables == null ? new RL_cc11123f1ba1bfd417e2f33be28138e9() : RL_cc11123f1ba1bfd417e2f33be28138e9.FromRestList(variables.outParamInvoiceMainFiles, ssConectaProveedores.RestRecords.RESTST_d381fba44897ce4382b17d5149465d51Structure.ToStructure);
return result;
}


    public static RESTConectaProveedores_j_FoliosSAE_Wb_FolioEdit_DataActionGetFolioFiles_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_j_FoliosSAE_Wb_FolioEdit_DataActionGetFolioFiles_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_j_FoliosSAE_Wb_FolioEdit_DataActionGetFolioFiles_Outputs result = new RESTConectaProveedores_j_FoliosSAE_Wb_FolioEdit_DataActionGetFolioFiles_Outputs();
result.outParamInvoiceMainFiles = screenModel.outParamInvoiceMainFiles.ToRestList<ssConectaProveedores.RestRecords.RESTST_d381fba44897ce4382b17d5149465d51Structure>(ssConectaProveedores.RestRecords.RESTST_d381fba44897ce4382b17d5149465d51Structure.FromStructureDelegate(conf));
return result;
}

}
