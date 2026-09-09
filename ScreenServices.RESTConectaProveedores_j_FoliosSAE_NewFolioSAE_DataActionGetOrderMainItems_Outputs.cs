using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_NewFolioSAE_DataActionGetOrderMainItems_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("List")]
public RestList<ssConectaProveedores.RestRecords.RESTST_1bddfac19e9b0cef65924aa7568fd106Structure> outParamList;


    public static RESTConectaProveedores_j_FoliosSAE_NewFolioSAE_DataActionGetOrderMainItems_Outputs FromOutputs(IBehaviorsConfiguration conf, RL_4e1292c876d12cf32f3c04367498157e outParamList) {RESTConectaProveedores_j_FoliosSAE_NewFolioSAE_DataActionGetOrderMainItems_Outputs result = new RESTConectaProveedores_j_FoliosSAE_NewFolioSAE_DataActionGetOrderMainItems_Outputs();
// Write the needed fields of the list outParamList to the result.outParamList
ssConectaProveedores.RestRecords.RESTST_1bddfac19e9b0cef65924aa7568fd106Structure tmpoutParamListElement;
if(outParamList.Empty) {
// Write the needed fields of the record outParamList.CurrentRec to the tmpoutParamListElement
tmpoutParamListElement = new ssConectaProveedores.RestRecords.RESTST_1bddfac19e9b0cef65924aa7568fd106Structure();
tmpoutParamListElement.AttrSelect = (bool?) outParamList.CurrentRec.ssSelect;
tmpoutParamListElement.AttrOrderMainItemId = (long?) outParamList.CurrentRec.ssOrderMainItemId;
tmpoutParamListElement.AttrOrderNumber = outParamList.CurrentRec.ssOrderNumber;
tmpoutParamListElement.AttrPosition = outParamList.CurrentRec.ssPosition;
tmpoutParamListElement.AttrMaterialCode = outParamList.CurrentRec.ssMaterialCode;
tmpoutParamListElement.AttrMaterialDescription = outParamList.CurrentRec.ssMaterialDescription;
tmpoutParamListElement.AttrQuantity = (decimal?) outParamList.CurrentRec.ssQuantity;
tmpoutParamListElement.AttrQuantityDelivered = (decimal?) outParamList.CurrentRec.ssQuantityDelivered;
tmpoutParamListElement.AttrQuantityAvailable = (decimal?) outParamList.CurrentRec.ssQuantityAvailable;
tmpoutParamListElement.AttrOrderUnitOfMeasure = outParamList.CurrentRec.ssOrderUnitOfMeasure;
tmpoutParamListElement.AttrCurrency = outParamList.CurrentRec.ssCurrency;
tmpoutParamListElement.AttrTotalAmount = (decimal?) outParamList.CurrentRec.ssTotalAmount;
tmpoutParamListElement.AttrStatus = outParamList.CurrentRec.ssStatus;
tmpoutParamListElement.AttrStatusClass = outParamList.CurrentRec.ssStatusClass;
tmpoutParamListElement.AttrDeliveryDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(outParamList.CurrentRec.ssDeliveryDate);
tmpoutParamListElement.AttrUnitPrice = (decimal?) outParamList.CurrentRec.ssUnitPrice;
tmpoutParamListElement.AttrAssigmentCode = outParamList.CurrentRec.ssAssigmentCode;
tmpoutParamListElement.AttrVATRate = (decimal?) outParamList.CurrentRec.ssVATRate;
tmpoutParamListElement.AttrImportDelivered = (decimal?) outParamList.CurrentRec.ssImportDelivered;
tmpoutParamListElement.AttrIsDeleted = (bool?) outParamList.CurrentRec.ssIsDeleted;
tmpoutParamListElement.AttrIsBlocked = (bool?) outParamList.CurrentRec.ssIsBlocked;
tmpoutParamListElement.AttrBaseQuantity = (int?) outParamList.CurrentRec.ssBaseQuantity;
tmpoutParamListElement.AttrIsFinalDelivered = (bool?) outParamList.CurrentRec.ssIsFinalDelivered;
tmpoutParamListElement.AttrPEP = outParamList.CurrentRec.ssPEP;
tmpoutParamListElement.AttrIsMultipleImputation = (bool?) outParamList.CurrentRec.ssIsMultipleImputation;
result.outParamList = new RestList<ssConectaProveedores.RestRecords.RESTST_1bddfac19e9b0cef65924aa7568fd106Structure>(new ssConectaProveedores.RestRecords.RESTST_1bddfac19e9b0cef65924aa7568fd106Structure[] {}, tmpoutParamListElement);
} else {
List<ssConectaProveedores.RestRecords.RESTST_1bddfac19e9b0cef65924aa7568fd106Structure>
 tmpoutParamList1List = new List<ssConectaProveedores.RestRecords.RESTST_1bddfac19e9b0cef65924aa7568fd106Structure>
();
try {outParamList.StartIteration();
while (!(outParamList.Eof)) {
// Write the needed fields of the record outParamList.CurrentRec to the tmpoutParamListElement
tmpoutParamListElement = new ssConectaProveedores.RestRecords.RESTST_1bddfac19e9b0cef65924aa7568fd106Structure();
tmpoutParamListElement.AttrSelect = (bool?) outParamList.CurrentRec.ssSelect;
tmpoutParamListElement.AttrOrderMainItemId = (long?) outParamList.CurrentRec.ssOrderMainItemId;
tmpoutParamListElement.AttrOrderNumber = outParamList.CurrentRec.ssOrderNumber;
tmpoutParamListElement.AttrPosition = outParamList.CurrentRec.ssPosition;
tmpoutParamListElement.AttrMaterialCode = outParamList.CurrentRec.ssMaterialCode;
tmpoutParamListElement.AttrMaterialDescription = outParamList.CurrentRec.ssMaterialDescription;
tmpoutParamListElement.AttrQuantity = (decimal?) outParamList.CurrentRec.ssQuantity;
tmpoutParamListElement.AttrQuantityDelivered = (decimal?) outParamList.CurrentRec.ssQuantityDelivered;
tmpoutParamListElement.AttrQuantityAvailable = (decimal?) outParamList.CurrentRec.ssQuantityAvailable;
tmpoutParamListElement.AttrOrderUnitOfMeasure = outParamList.CurrentRec.ssOrderUnitOfMeasure;
tmpoutParamListElement.AttrCurrency = outParamList.CurrentRec.ssCurrency;
tmpoutParamListElement.AttrTotalAmount = (decimal?) outParamList.CurrentRec.ssTotalAmount;
tmpoutParamListElement.AttrStatus = outParamList.CurrentRec.ssStatus;
tmpoutParamListElement.AttrStatusClass = outParamList.CurrentRec.ssStatusClass;
tmpoutParamListElement.AttrDeliveryDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(outParamList.CurrentRec.ssDeliveryDate);
tmpoutParamListElement.AttrUnitPrice = (decimal?) outParamList.CurrentRec.ssUnitPrice;
tmpoutParamListElement.AttrAssigmentCode = outParamList.CurrentRec.ssAssigmentCode;
tmpoutParamListElement.AttrVATRate = (decimal?) outParamList.CurrentRec.ssVATRate;
tmpoutParamListElement.AttrImportDelivered = (decimal?) outParamList.CurrentRec.ssImportDelivered;
tmpoutParamListElement.AttrIsDeleted = (bool?) outParamList.CurrentRec.ssIsDeleted;
tmpoutParamListElement.AttrIsBlocked = (bool?) outParamList.CurrentRec.ssIsBlocked;
tmpoutParamListElement.AttrBaseQuantity = (int?) outParamList.CurrentRec.ssBaseQuantity;
tmpoutParamListElement.AttrIsFinalDelivered = (bool?) outParamList.CurrentRec.ssIsFinalDelivered;
tmpoutParamListElement.AttrPEP = outParamList.CurrentRec.ssPEP;
tmpoutParamListElement.AttrIsMultipleImputation = (bool?) outParamList.CurrentRec.ssIsMultipleImputation;
tmpoutParamList1List.Add(tmpoutParamListElement);
outParamList.Advance();
}

} finally {
outParamList.EndIteration();
}

result.outParamList = new RestList<ssConectaProveedores.RestRecords.RESTST_1bddfac19e9b0cef65924aa7568fd106Structure>(tmpoutParamList1List.ToArray(), default(ssConectaProveedores.RestRecords.RESTST_1bddfac19e9b0cef65924aa7568fd106Structure));
}

return result;
}


    public static ConectaProveedores_j_FoliosSAE_NewFolioSAE_DataActionGetOrderMainItems_Model ToModel(RESTConectaProveedores_j_FoliosSAE_NewFolioSAE_DataActionGetOrderMainItems_Outputs variables) {ConectaProveedores_j_FoliosSAE_NewFolioSAE_DataActionGetOrderMainItems_Model result = new ConectaProveedores_j_FoliosSAE_NewFolioSAE_DataActionGetOrderMainItems_Model();
result.outParamList = variables == null ? new RL_4e1292c876d12cf32f3c04367498157e() : RL_4e1292c876d12cf32f3c04367498157e.FromRestList(variables.outParamList, ssConectaProveedores.RestRecords.RESTST_1bddfac19e9b0cef65924aa7568fd106Structure.ToStructure);
return result;
}


    public static RESTConectaProveedores_j_FoliosSAE_NewFolioSAE_DataActionGetOrderMainItems_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_j_FoliosSAE_NewFolioSAE_DataActionGetOrderMainItems_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_j_FoliosSAE_NewFolioSAE_DataActionGetOrderMainItems_Outputs result = new RESTConectaProveedores_j_FoliosSAE_NewFolioSAE_DataActionGetOrderMainItems_Outputs();
result.outParamList = screenModel.outParamList.ToRestList<ssConectaProveedores.RestRecords.RESTST_1bddfac19e9b0cef65924aa7568fd106Structure>(ssConectaProveedores.RestRecords.RESTST_1bddfac19e9b0cef65924aa7568fd106Structure.FromStructureDelegate(conf));
return result;
}

}
