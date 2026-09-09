using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_g_Reports_wb_documentExtrationByFile_ActionFindByAccount_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("List")]
public RestList<ssConectaProveedores.RestRecords.RESTST_37a6487c1fae199ee92f583d495139beStructure> outParamList;
[JsonProperty("return")]
public ssConectaProveedores.RestRecords.RESTST_b1b6df219277397c7c2be747d587880aStructure outParamreturn;


    public static RESTConectaProveedores_g_Reports_wb_documentExtrationByFile_ActionFindByAccount_Outputs FromOutputs(IBehaviorsConfiguration conf, RL_4236ffd993178ba431a66b30d7460972 outParamList, ST_b1b6df219277397c7c2be747d587880aStructure outParamreturn) {RESTConectaProveedores_g_Reports_wb_documentExtrationByFile_ActionFindByAccount_Outputs result = new RESTConectaProveedores_g_Reports_wb_documentExtrationByFile_ActionFindByAccount_Outputs();
conf.IncludeBinariesURL = false;
// Write the needed fields of the list outParamList to the result.outParamList
ssConectaProveedores.RestRecords.RESTST_37a6487c1fae199ee92f583d495139beStructure tmpoutParamListElement;
if(outParamList.Empty) {
// Write the needed fields of the record outParamList.CurrentRec to the tmpoutParamListElement
tmpoutParamListElement = new ssConectaProveedores.RestRecords.RESTST_37a6487c1fae199ee92f583d495139beStructure();
tmpoutParamListElement.AttrSelect = (bool?) outParamList.CurrentRec.ssSelect;
tmpoutParamListElement.AttrSupplierName = outParamList.CurrentRec.ssSupplierName;
tmpoutParamListElement.AttrInvoiceName = outParamList.CurrentRec.ssInvoiceName;
tmpoutParamListElement.AttrRequisitionName = outParamList.CurrentRec.ssRequisitionName;
tmpoutParamListElement.AttrTotalAmount = (decimal?) outParamList.CurrentRec.ssTotalAmount;
tmpoutParamListElement.AttrCurrency = outParamList.CurrentRec.ssCurrency;
tmpoutParamListElement.AttrUUId = outParamList.CurrentRec.ssUUId;
tmpoutParamListElement.AttrFilename = outParamList.CurrentRec.ssFilename;
tmpoutParamListElement.AttrCreateOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(outParamList.CurrentRec.ssCreateOn, conf.DateTimeFormat);
tmpoutParamListElement.AttrAccountDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(outParamList.CurrentRec.ssAccountDate);
tmpoutParamListElement.AttrStorageId = (long?) outParamList.CurrentRec.ssStorageId;
tmpoutParamListElement.AttrSize = (long?) outParamList.CurrentRec.ssSize;
result.outParamList = new RestList<ssConectaProveedores.RestRecords.RESTST_37a6487c1fae199ee92f583d495139beStructure>(new ssConectaProveedores.RestRecords.RESTST_37a6487c1fae199ee92f583d495139beStructure[] {}, tmpoutParamListElement);
} else {
List<ssConectaProveedores.RestRecords.RESTST_37a6487c1fae199ee92f583d495139beStructure>
 tmpoutParamList1List = new List<ssConectaProveedores.RestRecords.RESTST_37a6487c1fae199ee92f583d495139beStructure>
();
try {outParamList.StartIteration();
while (!(outParamList.Eof)) {
// Write the needed fields of the record outParamList.CurrentRec to the tmpoutParamListElement
tmpoutParamListElement = new ssConectaProveedores.RestRecords.RESTST_37a6487c1fae199ee92f583d495139beStructure();
tmpoutParamListElement.AttrSelect = (bool?) outParamList.CurrentRec.ssSelect;
tmpoutParamListElement.AttrSupplierName = outParamList.CurrentRec.ssSupplierName;
tmpoutParamListElement.AttrInvoiceName = outParamList.CurrentRec.ssInvoiceName;
tmpoutParamListElement.AttrRequisitionName = outParamList.CurrentRec.ssRequisitionName;
tmpoutParamListElement.AttrTotalAmount = (decimal?) outParamList.CurrentRec.ssTotalAmount;
tmpoutParamListElement.AttrCurrency = outParamList.CurrentRec.ssCurrency;
tmpoutParamListElement.AttrUUId = outParamList.CurrentRec.ssUUId;
tmpoutParamListElement.AttrFilename = outParamList.CurrentRec.ssFilename;
tmpoutParamListElement.AttrCreateOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(outParamList.CurrentRec.ssCreateOn, conf.DateTimeFormat);
tmpoutParamListElement.AttrAccountDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(outParamList.CurrentRec.ssAccountDate);
tmpoutParamListElement.AttrStorageId = (long?) outParamList.CurrentRec.ssStorageId;
tmpoutParamListElement.AttrSize = (long?) outParamList.CurrentRec.ssSize;
tmpoutParamList1List.Add(tmpoutParamListElement);
outParamList.Advance();
}

} finally {
outParamList.EndIteration();
}

result.outParamList = new RestList<ssConectaProveedores.RestRecords.RESTST_37a6487c1fae199ee92f583d495139beStructure>(tmpoutParamList1List.ToArray(), default(ssConectaProveedores.RestRecords.RESTST_37a6487c1fae199ee92f583d495139beStructure));
}

// Write the needed fields of the record outParamreturn to the result.outParamreturn
result.outParamreturn = new ssConectaProveedores.RestRecords.RESTST_b1b6df219277397c7c2be747d587880aStructure();
result.outParamreturn.AttrIsSuccess = (bool?) outParamreturn.ssIsSuccess;
result.outParamreturn.AttrMessage = outParamreturn.ssMessage;
return result;
}


    

    
}
