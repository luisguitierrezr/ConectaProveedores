using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_d_InvoiceAudit_Wb_InvoiceFilesList_DataActionGetInvoiceFiles_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("List")]
public RestList<ssConectaProveedores.RestRecords.RESTST_15467825cb087ac1591b96b0d1989badStructure> outParamList;


    public static RESTConectaProveedores_d_InvoiceAudit_Wb_InvoiceFilesList_DataActionGetInvoiceFiles_Outputs FromOutputs(IBehaviorsConfiguration conf, RL_5582607f6208069586dcaff23f9c5144 outParamList) {RESTConectaProveedores_d_InvoiceAudit_Wb_InvoiceFilesList_DataActionGetInvoiceFiles_Outputs result = new RESTConectaProveedores_d_InvoiceAudit_Wb_InvoiceFilesList_DataActionGetInvoiceFiles_Outputs();
// Write the needed fields of the list outParamList to the result.outParamList
ssConectaProveedores.RestRecords.RESTST_15467825cb087ac1591b96b0d1989badStructure tmpoutParamListElement;
if(outParamList.Empty) {
// Write the needed fields of the record outParamList.CurrentRec to the tmpoutParamListElement
tmpoutParamListElement = new ssConectaProveedores.RestRecords.RESTST_15467825cb087ac1591b96b0d1989badStructure();
tmpoutParamListElement.AttrIsSelected = (bool?) outParamList.CurrentRec.ssIsSelected;
tmpoutParamListElement.AttrFilename = outParamList.CurrentRec.ssFilename;
tmpoutParamListElement.AttrIsExtra = (bool?) outParamList.CurrentRec.ssIsExtra;
// Write optimized tmpoutParamListElement.AttrCreatedBy
tmpoutParamListElement.AttrCreatedBy = "";
tmpoutParamListElement.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(outParamList.CurrentRec.ssCreatedOn, conf.DateTimeFormat);
tmpoutParamListElement.AttrStorageId = (long?) outParamList.CurrentRec.ssStorageId;
tmpoutParamListElement.AttrStorageSize = (long?) outParamList.CurrentRec.ssStorageSize;
tmpoutParamListElement.AttrUserName = outParamList.CurrentRec.ssUserName;
result.outParamList = new RestList<ssConectaProveedores.RestRecords.RESTST_15467825cb087ac1591b96b0d1989badStructure>(new ssConectaProveedores.RestRecords.RESTST_15467825cb087ac1591b96b0d1989badStructure[] {}, tmpoutParamListElement);
} else {
List<ssConectaProveedores.RestRecords.RESTST_15467825cb087ac1591b96b0d1989badStructure>
 tmpoutParamList1List = new List<ssConectaProveedores.RestRecords.RESTST_15467825cb087ac1591b96b0d1989badStructure>
();
try {outParamList.StartIteration();
while (!(outParamList.Eof)) {
// Write the needed fields of the record outParamList.CurrentRec to the tmpoutParamListElement
tmpoutParamListElement = new ssConectaProveedores.RestRecords.RESTST_15467825cb087ac1591b96b0d1989badStructure();
tmpoutParamListElement.AttrIsSelected = (bool?) outParamList.CurrentRec.ssIsSelected;
tmpoutParamListElement.AttrFilename = outParamList.CurrentRec.ssFilename;
tmpoutParamListElement.AttrIsExtra = (bool?) outParamList.CurrentRec.ssIsExtra;
// Write optimized tmpoutParamListElement.AttrCreatedBy
tmpoutParamListElement.AttrCreatedBy = "";
tmpoutParamListElement.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(outParamList.CurrentRec.ssCreatedOn, conf.DateTimeFormat);
tmpoutParamListElement.AttrStorageId = (long?) outParamList.CurrentRec.ssStorageId;
tmpoutParamListElement.AttrStorageSize = (long?) outParamList.CurrentRec.ssStorageSize;
tmpoutParamListElement.AttrUserName = outParamList.CurrentRec.ssUserName;
tmpoutParamList1List.Add(tmpoutParamListElement);
outParamList.Advance();
}

} finally {
outParamList.EndIteration();
}

result.outParamList = new RestList<ssConectaProveedores.RestRecords.RESTST_15467825cb087ac1591b96b0d1989badStructure>(tmpoutParamList1List.ToArray(), default(ssConectaProveedores.RestRecords.RESTST_15467825cb087ac1591b96b0d1989badStructure));
}

return result;
}


    public static ConectaProveedores_d_InvoiceAudit_Wb_InvoiceFilesList_DataActionGetInvoiceFiles_Model ToModel(RESTConectaProveedores_d_InvoiceAudit_Wb_InvoiceFilesList_DataActionGetInvoiceFiles_Outputs variables) {ConectaProveedores_d_InvoiceAudit_Wb_InvoiceFilesList_DataActionGetInvoiceFiles_Model result = new ConectaProveedores_d_InvoiceAudit_Wb_InvoiceFilesList_DataActionGetInvoiceFiles_Model();
result.outParamList = variables == null ? new RL_5582607f6208069586dcaff23f9c5144() : RL_5582607f6208069586dcaff23f9c5144.FromRestList(variables.outParamList, ssConectaProveedores.RestRecords.RESTST_15467825cb087ac1591b96b0d1989badStructure.ToStructure);
return result;
}


    public static RESTConectaProveedores_d_InvoiceAudit_Wb_InvoiceFilesList_DataActionGetInvoiceFiles_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_d_InvoiceAudit_Wb_InvoiceFilesList_DataActionGetInvoiceFiles_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_d_InvoiceAudit_Wb_InvoiceFilesList_DataActionGetInvoiceFiles_Outputs result = new RESTConectaProveedores_d_InvoiceAudit_Wb_InvoiceFilesList_DataActionGetInvoiceFiles_Outputs();
result.outParamList = screenModel.outParamList.ToRestList<ssConectaProveedores.RestRecords.RESTST_15467825cb087ac1591b96b0d1989badStructure>(ssConectaProveedores.RestRecords.RESTST_15467825cb087ac1591b96b0d1989badStructure.FromStructureDelegate(conf));
return result;
}

}
