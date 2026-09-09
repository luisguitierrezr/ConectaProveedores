using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementRequestedFiles_DataActionGetOrderRequestFiles_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("RequestFiles")]
public RestList<ssConectaProveedores.RestRecords.RESTEN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord> outParamRequestFiles;


    public static RESTConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementRequestedFiles_DataActionGetOrderRequestFiles_Outputs FromOutputs(IBehaviorsConfiguration conf, RL_08794d38cc3e746db7e33443c648a0fa outParamRequestFiles) {RESTConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementRequestedFiles_DataActionGetOrderRequestFiles_Outputs result = new RESTConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementRequestedFiles_DataActionGetOrderRequestFiles_Outputs();
// Write the needed fields of the list outParamRequestFiles to the result.outParamRequestFiles
ssConectaProveedores.RestRecords.RESTEN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord tmpoutParamRequestFilesElement;
if(outParamRequestFiles.Empty) {
// Write the needed fields of the record outParamRequestFiles.CurrentRec to the tmpoutParamRequestFilesElement
tmpoutParamRequestFilesElement = new ssConectaProveedores.RestRecords.RESTEN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord();
tmpoutParamRequestFilesElement.AttrId = (long?) outParamRequestFiles.CurrentRec.ssId;
// Write optimized tmpoutParamRequestFilesElement.AttrOrderId
tmpoutParamRequestFilesElement.AttrOrderId = (long?) 0L;
tmpoutParamRequestFilesElement.AttrInvoiceId = (long?) outParamRequestFiles.CurrentRec.ssInvoiceId;
// Write optimized tmpoutParamRequestFilesElement.AttrFilename
tmpoutParamRequestFilesElement.AttrFilename = "";
tmpoutParamRequestFilesElement.AttrStorageId = (long?) outParamRequestFiles.CurrentRec.ssStorageId;
tmpoutParamRequestFilesElement.AttrDescription = outParamRequestFiles.CurrentRec.ssDescription;
tmpoutParamRequestFilesElement.AttrNeedsApproval = (bool?) outParamRequestFiles.CurrentRec.ssNeedsApproval;
tmpoutParamRequestFilesElement.AttrIsApproved = (bool?) outParamRequestFiles.CurrentRec.ssIsApproved;
tmpoutParamRequestFilesElement.AttrIsRejected = (bool?) outParamRequestFiles.CurrentRec.ssIsRejected;
// Write optimized tmpoutParamRequestFilesElement.AttrCreatedBy
tmpoutParamRequestFilesElement.AttrCreatedBy = "";
// Write optimized tmpoutParamRequestFilesElement.AttrCreatedOn
tmpoutParamRequestFilesElement.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamRequestFilesElement.AttrUpdatedBy
tmpoutParamRequestFilesElement.AttrUpdatedBy = "";
// Write optimized tmpoutParamRequestFilesElement.AttrUpdatedOn
tmpoutParamRequestFilesElement.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamRequestFilesElement.AttrOrderAccConceptId
tmpoutParamRequestFilesElement.AttrOrderAccConceptId = (long?) 0L;
// Write optimized tmpoutParamRequestFilesElement.AttrIsFinancialFile
tmpoutParamRequestFilesElement.AttrIsFinancialFile = (bool?) false;
// Write optimized tmpoutParamRequestFilesElement.AttrOrderContractFile
tmpoutParamRequestFilesElement.AttrOrderContractFile = (long?) 0L;
// Write optimized tmpoutParamRequestFilesElement.AttrNeedAccounting
tmpoutParamRequestFilesElement.AttrNeedAccounting = (bool?) false;
result.outParamRequestFiles = new RestList<ssConectaProveedores.RestRecords.RESTEN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord>(new ssConectaProveedores.RestRecords.RESTEN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord[] {}, tmpoutParamRequestFilesElement);
} else {
List<ssConectaProveedores.RestRecords.RESTEN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord>
 tmpoutParamRequestFiles1List = new List<ssConectaProveedores.RestRecords.RESTEN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord>
();
try {outParamRequestFiles.StartIteration();
while (!(outParamRequestFiles.Eof)) {
// Write the needed fields of the record outParamRequestFiles.CurrentRec to the tmpoutParamRequestFilesElement
tmpoutParamRequestFilesElement = new ssConectaProveedores.RestRecords.RESTEN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord();
tmpoutParamRequestFilesElement.AttrId = (long?) outParamRequestFiles.CurrentRec.ssId;
// Write optimized tmpoutParamRequestFilesElement.AttrOrderId
tmpoutParamRequestFilesElement.AttrOrderId = (long?) 0L;
tmpoutParamRequestFilesElement.AttrInvoiceId = (long?) outParamRequestFiles.CurrentRec.ssInvoiceId;
// Write optimized tmpoutParamRequestFilesElement.AttrFilename
tmpoutParamRequestFilesElement.AttrFilename = "";
tmpoutParamRequestFilesElement.AttrStorageId = (long?) outParamRequestFiles.CurrentRec.ssStorageId;
tmpoutParamRequestFilesElement.AttrDescription = outParamRequestFiles.CurrentRec.ssDescription;
tmpoutParamRequestFilesElement.AttrNeedsApproval = (bool?) outParamRequestFiles.CurrentRec.ssNeedsApproval;
tmpoutParamRequestFilesElement.AttrIsApproved = (bool?) outParamRequestFiles.CurrentRec.ssIsApproved;
tmpoutParamRequestFilesElement.AttrIsRejected = (bool?) outParamRequestFiles.CurrentRec.ssIsRejected;
// Write optimized tmpoutParamRequestFilesElement.AttrCreatedBy
tmpoutParamRequestFilesElement.AttrCreatedBy = "";
// Write optimized tmpoutParamRequestFilesElement.AttrCreatedOn
tmpoutParamRequestFilesElement.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamRequestFilesElement.AttrUpdatedBy
tmpoutParamRequestFilesElement.AttrUpdatedBy = "";
// Write optimized tmpoutParamRequestFilesElement.AttrUpdatedOn
tmpoutParamRequestFilesElement.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamRequestFilesElement.AttrOrderAccConceptId
tmpoutParamRequestFilesElement.AttrOrderAccConceptId = (long?) 0L;
// Write optimized tmpoutParamRequestFilesElement.AttrIsFinancialFile
tmpoutParamRequestFilesElement.AttrIsFinancialFile = (bool?) false;
// Write optimized tmpoutParamRequestFilesElement.AttrOrderContractFile
tmpoutParamRequestFilesElement.AttrOrderContractFile = (long?) 0L;
// Write optimized tmpoutParamRequestFilesElement.AttrNeedAccounting
tmpoutParamRequestFilesElement.AttrNeedAccounting = (bool?) false;
tmpoutParamRequestFiles1List.Add(tmpoutParamRequestFilesElement);
outParamRequestFiles.Advance();
}

} finally {
outParamRequestFiles.EndIteration();
}

result.outParamRequestFiles = new RestList<ssConectaProveedores.RestRecords.RESTEN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord>(tmpoutParamRequestFiles1List.ToArray(), default(ssConectaProveedores.RestRecords.RESTEN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord));
}

return result;
}


    public static ConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementRequestedFiles_DataActionGetOrderRequestFiles_Model ToModel(RESTConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementRequestedFiles_DataActionGetOrderRequestFiles_Outputs variables) {ConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementRequestedFiles_DataActionGetOrderRequestFiles_Model result = new ConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementRequestedFiles_DataActionGetOrderRequestFiles_Model();
result.outParamRequestFiles = variables == null ? new RL_08794d38cc3e746db7e33443c648a0fa() : RL_08794d38cc3e746db7e33443c648a0fa.FromRestList(variables.outParamRequestFiles, ssConectaProveedores.RestRecords.RESTEN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord.ToStructure);
return result;
}


    public static RESTConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementRequestedFiles_DataActionGetOrderRequestFiles_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementRequestedFiles_DataActionGetOrderRequestFiles_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementRequestedFiles_DataActionGetOrderRequestFiles_Outputs result = new RESTConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementRequestedFiles_DataActionGetOrderRequestFiles_Outputs();
result.outParamRequestFiles = screenModel.outParamRequestFiles.ToRestList<ssConectaProveedores.RestRecords.RESTEN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord>(ssConectaProveedores.RestRecords.RESTEN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord.FromStructureDelegate(conf));
return result;
}

}
