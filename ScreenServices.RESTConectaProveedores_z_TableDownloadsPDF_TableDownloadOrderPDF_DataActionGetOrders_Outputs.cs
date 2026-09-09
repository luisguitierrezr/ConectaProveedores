using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_z_TableDownloadsPDF_TableDownloadOrderPDF_DataActionGetOrders_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("List")]
public RestList<ssConectaProveedores.RestRecords.RESTST_00c299856fb2c1322ea33527b24c9dd0Structure> outParamList;


    public static RESTConectaProveedores_z_TableDownloadsPDF_TableDownloadOrderPDF_DataActionGetOrders_Outputs FromOutputs(IBehaviorsConfiguration conf, RL_68002bbb4e227fd5533d460e5a56bbd4 outParamList) {RESTConectaProveedores_z_TableDownloadsPDF_TableDownloadOrderPDF_DataActionGetOrders_Outputs result = new RESTConectaProveedores_z_TableDownloadsPDF_TableDownloadOrderPDF_DataActionGetOrders_Outputs();
// Write the needed fields of the list outParamList to the result.outParamList
ssConectaProveedores.RestRecords.RESTST_00c299856fb2c1322ea33527b24c9dd0Structure tmpoutParamListElement;
if(outParamList.Empty) {
// Write the needed fields of the record outParamList.CurrentRec to the tmpoutParamListElement
tmpoutParamListElement = new ssConectaProveedores.RestRecords.RESTST_00c299856fb2c1322ea33527b24c9dd0Structure();
// Write optimized tmpoutParamListElement.AttrOrderMainId
tmpoutParamListElement.AttrOrderMainId = (long?) 0L;
tmpoutParamListElement.AttrApprovalStatus = outParamList.CurrentRec.ssApprovalStatus;
tmpoutParamListElement.AttrOrderNumber = outParamList.CurrentRec.ssOrderNumber;
tmpoutParamListElement.AttrOrderStatus = outParamList.CurrentRec.ssOrderStatus;
tmpoutParamListElement.AttrSupplierName_Number = outParamList.CurrentRec.ssSupplierName_Number;
tmpoutParamListElement.AttrBuyer = outParamList.CurrentRec.ssBuyer;
tmpoutParamListElement.AttrCompany = outParamList.CurrentRec.ssCompany;
tmpoutParamListElement.AttrRegion = outParamList.CurrentRec.ssRegion;
tmpoutParamListElement.AttrCurrency = outParamList.CurrentRec.ssCurrency;
tmpoutParamListElement.AttrTotalAmount = outParamList.CurrentRec.ssTotalAmount;
result.outParamList = new RestList<ssConectaProveedores.RestRecords.RESTST_00c299856fb2c1322ea33527b24c9dd0Structure>(new ssConectaProveedores.RestRecords.RESTST_00c299856fb2c1322ea33527b24c9dd0Structure[] {}, tmpoutParamListElement);
} else {
List<ssConectaProveedores.RestRecords.RESTST_00c299856fb2c1322ea33527b24c9dd0Structure>
 tmpoutParamList1List = new List<ssConectaProveedores.RestRecords.RESTST_00c299856fb2c1322ea33527b24c9dd0Structure>
();
try {outParamList.StartIteration();
while (!(outParamList.Eof)) {
// Write the needed fields of the record outParamList.CurrentRec to the tmpoutParamListElement
tmpoutParamListElement = new ssConectaProveedores.RestRecords.RESTST_00c299856fb2c1322ea33527b24c9dd0Structure();
// Write optimized tmpoutParamListElement.AttrOrderMainId
tmpoutParamListElement.AttrOrderMainId = (long?) 0L;
tmpoutParamListElement.AttrApprovalStatus = outParamList.CurrentRec.ssApprovalStatus;
tmpoutParamListElement.AttrOrderNumber = outParamList.CurrentRec.ssOrderNumber;
tmpoutParamListElement.AttrOrderStatus = outParamList.CurrentRec.ssOrderStatus;
tmpoutParamListElement.AttrSupplierName_Number = outParamList.CurrentRec.ssSupplierName_Number;
tmpoutParamListElement.AttrBuyer = outParamList.CurrentRec.ssBuyer;
tmpoutParamListElement.AttrCompany = outParamList.CurrentRec.ssCompany;
tmpoutParamListElement.AttrRegion = outParamList.CurrentRec.ssRegion;
tmpoutParamListElement.AttrCurrency = outParamList.CurrentRec.ssCurrency;
tmpoutParamListElement.AttrTotalAmount = outParamList.CurrentRec.ssTotalAmount;
tmpoutParamList1List.Add(tmpoutParamListElement);
outParamList.Advance();
}

} finally {
outParamList.EndIteration();
}

result.outParamList = new RestList<ssConectaProveedores.RestRecords.RESTST_00c299856fb2c1322ea33527b24c9dd0Structure>(tmpoutParamList1List.ToArray(), default(ssConectaProveedores.RestRecords.RESTST_00c299856fb2c1322ea33527b24c9dd0Structure));
}

return result;
}


    public static ConectaProveedores_z_TableDownloadsPDF_TableDownloadOrderPDF_DataActionGetOrders_Model ToModel(RESTConectaProveedores_z_TableDownloadsPDF_TableDownloadOrderPDF_DataActionGetOrders_Outputs variables) {ConectaProveedores_z_TableDownloadsPDF_TableDownloadOrderPDF_DataActionGetOrders_Model result = new ConectaProveedores_z_TableDownloadsPDF_TableDownloadOrderPDF_DataActionGetOrders_Model();
result.outParamList = variables == null ? new RL_68002bbb4e227fd5533d460e5a56bbd4() : RL_68002bbb4e227fd5533d460e5a56bbd4.FromRestList(variables.outParamList, ssConectaProveedores.RestRecords.RESTST_00c299856fb2c1322ea33527b24c9dd0Structure.ToStructure);
return result;
}


    public static RESTConectaProveedores_z_TableDownloadsPDF_TableDownloadOrderPDF_DataActionGetOrders_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_z_TableDownloadsPDF_TableDownloadOrderPDF_DataActionGetOrders_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_z_TableDownloadsPDF_TableDownloadOrderPDF_DataActionGetOrders_Outputs result = new RESTConectaProveedores_z_TableDownloadsPDF_TableDownloadOrderPDF_DataActionGetOrders_Outputs();
result.outParamList = screenModel.outParamList.ToRestList<ssConectaProveedores.RestRecords.RESTST_00c299856fb2c1322ea33527b24c9dd0Structure>(ssConectaProveedores.RestRecords.RESTST_00c299856fb2c1322ea33527b24c9dd0Structure.FromStructureDelegate(conf));
return result;
}

}
