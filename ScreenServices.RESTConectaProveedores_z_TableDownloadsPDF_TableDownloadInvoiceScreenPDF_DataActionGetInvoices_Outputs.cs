using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_z_TableDownloadsPDF_TableDownloadInvoiceScreenPDF_DataActionGetInvoices_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("List")]
public RestList<ssConectaProveedores.RestRecords.RESTST_3c6142d371d14231f5ddee7b64c28681Structure> outParamList;


    public static RESTConectaProveedores_z_TableDownloadsPDF_TableDownloadInvoiceScreenPDF_DataActionGetInvoices_Outputs FromOutputs(IBehaviorsConfiguration conf, RL_77750b395266828bf78fae563dd1fc3f outParamList) {RESTConectaProveedores_z_TableDownloadsPDF_TableDownloadInvoiceScreenPDF_DataActionGetInvoices_Outputs result = new RESTConectaProveedores_z_TableDownloadsPDF_TableDownloadInvoiceScreenPDF_DataActionGetInvoices_Outputs();
// Write the needed fields of the list outParamList to the result.outParamList
ssConectaProveedores.RestRecords.RESTST_3c6142d371d14231f5ddee7b64c28681Structure tmpoutParamListElement;
if(outParamList.Empty) {
// Write the needed fields of the record outParamList.CurrentRec to the tmpoutParamListElement
tmpoutParamListElement = new ssConectaProveedores.RestRecords.RESTST_3c6142d371d14231f5ddee7b64c28681Structure();
// Write optimized tmpoutParamListElement.AttrInvoiceId
tmpoutParamListElement.AttrInvoiceId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrInvoiceApprovalLevelId
tmpoutParamListElement.AttrInvoiceApprovalLevelId = (long?) 0L;
tmpoutParamListElement.AttrInvoiceName = outParamList.CurrentRec.ssInvoiceName;
tmpoutParamListElement.AttrInvoiceStatus = outParamList.CurrentRec.ssInvoiceStatus;
tmpoutParamListElement.AttrRequisitionName = outParamList.CurrentRec.ssRequisitionName;
tmpoutParamListElement.AttrSupplierName = outParamList.CurrentRec.ssSupplierName;
tmpoutParamListElement.AttrSupplierNumber = outParamList.CurrentRec.ssSupplierNumber;
tmpoutParamListElement.AttrTotalAmount = outParamList.CurrentRec.ssTotalAmount;
tmpoutParamListElement.AttrUploadDate = outParamList.CurrentRec.ssUploadDate;
tmpoutParamListElement.AttrAssignedTo = outParamList.CurrentRec.ssAssignedTo;
tmpoutParamListElement.AttrAction = outParamList.CurrentRec.ssAction;
result.outParamList = new RestList<ssConectaProveedores.RestRecords.RESTST_3c6142d371d14231f5ddee7b64c28681Structure>(new ssConectaProveedores.RestRecords.RESTST_3c6142d371d14231f5ddee7b64c28681Structure[] {}, tmpoutParamListElement);
} else {
List<ssConectaProveedores.RestRecords.RESTST_3c6142d371d14231f5ddee7b64c28681Structure>
 tmpoutParamList1List = new List<ssConectaProveedores.RestRecords.RESTST_3c6142d371d14231f5ddee7b64c28681Structure>
();
try {outParamList.StartIteration();
while (!(outParamList.Eof)) {
// Write the needed fields of the record outParamList.CurrentRec to the tmpoutParamListElement
tmpoutParamListElement = new ssConectaProveedores.RestRecords.RESTST_3c6142d371d14231f5ddee7b64c28681Structure();
// Write optimized tmpoutParamListElement.AttrInvoiceId
tmpoutParamListElement.AttrInvoiceId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrInvoiceApprovalLevelId
tmpoutParamListElement.AttrInvoiceApprovalLevelId = (long?) 0L;
tmpoutParamListElement.AttrInvoiceName = outParamList.CurrentRec.ssInvoiceName;
tmpoutParamListElement.AttrInvoiceStatus = outParamList.CurrentRec.ssInvoiceStatus;
tmpoutParamListElement.AttrRequisitionName = outParamList.CurrentRec.ssRequisitionName;
tmpoutParamListElement.AttrSupplierName = outParamList.CurrentRec.ssSupplierName;
tmpoutParamListElement.AttrSupplierNumber = outParamList.CurrentRec.ssSupplierNumber;
tmpoutParamListElement.AttrTotalAmount = outParamList.CurrentRec.ssTotalAmount;
tmpoutParamListElement.AttrUploadDate = outParamList.CurrentRec.ssUploadDate;
tmpoutParamListElement.AttrAssignedTo = outParamList.CurrentRec.ssAssignedTo;
tmpoutParamListElement.AttrAction = outParamList.CurrentRec.ssAction;
tmpoutParamList1List.Add(tmpoutParamListElement);
outParamList.Advance();
}

} finally {
outParamList.EndIteration();
}

result.outParamList = new RestList<ssConectaProveedores.RestRecords.RESTST_3c6142d371d14231f5ddee7b64c28681Structure>(tmpoutParamList1List.ToArray(), default(ssConectaProveedores.RestRecords.RESTST_3c6142d371d14231f5ddee7b64c28681Structure));
}

return result;
}


    public static ConectaProveedores_z_TableDownloadsPDF_TableDownloadInvoiceScreenPDF_DataActionGetInvoices_Model ToModel(RESTConectaProveedores_z_TableDownloadsPDF_TableDownloadInvoiceScreenPDF_DataActionGetInvoices_Outputs variables) {ConectaProveedores_z_TableDownloadsPDF_TableDownloadInvoiceScreenPDF_DataActionGetInvoices_Model result = new ConectaProveedores_z_TableDownloadsPDF_TableDownloadInvoiceScreenPDF_DataActionGetInvoices_Model();
result.outParamList = variables == null ? new RL_77750b395266828bf78fae563dd1fc3f() : RL_77750b395266828bf78fae563dd1fc3f.FromRestList(variables.outParamList, ssConectaProveedores.RestRecords.RESTST_3c6142d371d14231f5ddee7b64c28681Structure.ToStructure);
return result;
}


    public static RESTConectaProveedores_z_TableDownloadsPDF_TableDownloadInvoiceScreenPDF_DataActionGetInvoices_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_z_TableDownloadsPDF_TableDownloadInvoiceScreenPDF_DataActionGetInvoices_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_z_TableDownloadsPDF_TableDownloadInvoiceScreenPDF_DataActionGetInvoices_Outputs result = new RESTConectaProveedores_z_TableDownloadsPDF_TableDownloadInvoiceScreenPDF_DataActionGetInvoices_Outputs();
result.outParamList = screenModel.outParamList.ToRestList<ssConectaProveedores.RestRecords.RESTST_3c6142d371d14231f5ddee7b64c28681Structure>(ssConectaProveedores.RestRecords.RESTST_3c6142d371d14231f5ddee7b64c28681Structure.FromStructureDelegate(conf));
return result;
}

}
