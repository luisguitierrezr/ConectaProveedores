using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_z_TableDownloadsPDF_TableDownloadFolioScreenPDF_DataActionGetFolios_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("List")]
public RestList<ssConectaProveedores.RestRecords.RESTST_3dc7a528e6a1e146b195db5c3edb006aStructure> outParamList;


    public static RESTConectaProveedores_z_TableDownloadsPDF_TableDownloadFolioScreenPDF_DataActionGetFolios_Outputs FromOutputs(IBehaviorsConfiguration conf, RL_9046748205310553b4766e7b1bf0c997 outParamList) {RESTConectaProveedores_z_TableDownloadsPDF_TableDownloadFolioScreenPDF_DataActionGetFolios_Outputs result = new RESTConectaProveedores_z_TableDownloadsPDF_TableDownloadFolioScreenPDF_DataActionGetFolios_Outputs();
// Write the needed fields of the list outParamList to the result.outParamList
ssConectaProveedores.RestRecords.RESTST_3dc7a528e6a1e146b195db5c3edb006aStructure tmpoutParamListElement;
if(outParamList.Empty) {
// Write the needed fields of the record outParamList.CurrentRec to the tmpoutParamListElement
tmpoutParamListElement = new ssConectaProveedores.RestRecords.RESTST_3dc7a528e6a1e146b195db5c3edb006aStructure();
// Write optimized tmpoutParamListElement.AttrFolioId
tmpoutParamListElement.AttrFolioId = (long?) 0L;
tmpoutParamListElement.AttrFolioNumber = outParamList.CurrentRec.ssFolioNumber;
tmpoutParamListElement.AttrOrderNumber = outParamList.CurrentRec.ssOrderNumber;
tmpoutParamListElement.AttrSupplierName = outParamList.CurrentRec.ssSupplierName;
tmpoutParamListElement.AttrSupplierNumber = outParamList.CurrentRec.ssSupplierNumber;
// Write optimized tmpoutParamListElement.AttrRegion
tmpoutParamListElement.AttrRegion = "";
tmpoutParamListElement.AttrTotalAmount = outParamList.CurrentRec.ssTotalAmount;
tmpoutParamListElement.AttrCurrency = outParamList.CurrentRec.ssCurrency;
tmpoutParamListElement.AttrUploadDate = outParamList.CurrentRec.ssUploadDate;
tmpoutParamListElement.AttrStatus = outParamList.CurrentRec.ssStatus;
result.outParamList = new RestList<ssConectaProveedores.RestRecords.RESTST_3dc7a528e6a1e146b195db5c3edb006aStructure>(new ssConectaProveedores.RestRecords.RESTST_3dc7a528e6a1e146b195db5c3edb006aStructure[] {}, tmpoutParamListElement);
} else {
List<ssConectaProveedores.RestRecords.RESTST_3dc7a528e6a1e146b195db5c3edb006aStructure>
 tmpoutParamList1List = new List<ssConectaProveedores.RestRecords.RESTST_3dc7a528e6a1e146b195db5c3edb006aStructure>
();
try {outParamList.StartIteration();
while (!(outParamList.Eof)) {
// Write the needed fields of the record outParamList.CurrentRec to the tmpoutParamListElement
tmpoutParamListElement = new ssConectaProveedores.RestRecords.RESTST_3dc7a528e6a1e146b195db5c3edb006aStructure();
// Write optimized tmpoutParamListElement.AttrFolioId
tmpoutParamListElement.AttrFolioId = (long?) 0L;
tmpoutParamListElement.AttrFolioNumber = outParamList.CurrentRec.ssFolioNumber;
tmpoutParamListElement.AttrOrderNumber = outParamList.CurrentRec.ssOrderNumber;
tmpoutParamListElement.AttrSupplierName = outParamList.CurrentRec.ssSupplierName;
tmpoutParamListElement.AttrSupplierNumber = outParamList.CurrentRec.ssSupplierNumber;
// Write optimized tmpoutParamListElement.AttrRegion
tmpoutParamListElement.AttrRegion = "";
tmpoutParamListElement.AttrTotalAmount = outParamList.CurrentRec.ssTotalAmount;
tmpoutParamListElement.AttrCurrency = outParamList.CurrentRec.ssCurrency;
tmpoutParamListElement.AttrUploadDate = outParamList.CurrentRec.ssUploadDate;
tmpoutParamListElement.AttrStatus = outParamList.CurrentRec.ssStatus;
tmpoutParamList1List.Add(tmpoutParamListElement);
outParamList.Advance();
}

} finally {
outParamList.EndIteration();
}

result.outParamList = new RestList<ssConectaProveedores.RestRecords.RESTST_3dc7a528e6a1e146b195db5c3edb006aStructure>(tmpoutParamList1List.ToArray(), default(ssConectaProveedores.RestRecords.RESTST_3dc7a528e6a1e146b195db5c3edb006aStructure));
}

return result;
}


    public static ConectaProveedores_z_TableDownloadsPDF_TableDownloadFolioScreenPDF_DataActionGetFolios_Model ToModel(RESTConectaProveedores_z_TableDownloadsPDF_TableDownloadFolioScreenPDF_DataActionGetFolios_Outputs variables) {ConectaProveedores_z_TableDownloadsPDF_TableDownloadFolioScreenPDF_DataActionGetFolios_Model result = new ConectaProveedores_z_TableDownloadsPDF_TableDownloadFolioScreenPDF_DataActionGetFolios_Model();
result.outParamList = variables == null ? new RL_9046748205310553b4766e7b1bf0c997() : RL_9046748205310553b4766e7b1bf0c997.FromRestList(variables.outParamList, ssConectaProveedores.RestRecords.RESTST_3dc7a528e6a1e146b195db5c3edb006aStructure.ToStructure);
return result;
}


    public static RESTConectaProveedores_z_TableDownloadsPDF_TableDownloadFolioScreenPDF_DataActionGetFolios_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_z_TableDownloadsPDF_TableDownloadFolioScreenPDF_DataActionGetFolios_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_z_TableDownloadsPDF_TableDownloadFolioScreenPDF_DataActionGetFolios_Outputs result = new RESTConectaProveedores_z_TableDownloadsPDF_TableDownloadFolioScreenPDF_DataActionGetFolios_Outputs();
result.outParamList = screenModel.outParamList.ToRestList<ssConectaProveedores.RestRecords.RESTST_3dc7a528e6a1e146b195db5c3edb006aStructure>(ssConectaProveedores.RestRecords.RESTST_3dc7a528e6a1e146b195db5c3edb006aStructure.FromStructureDelegate(conf));
return result;
}

}
