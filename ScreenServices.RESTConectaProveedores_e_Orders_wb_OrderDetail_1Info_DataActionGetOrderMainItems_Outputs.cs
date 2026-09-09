using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_e_Orders_wb_OrderDetail_1Info_DataActionGetOrderMainItems_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("List")]
public RestList<ssConectaProveedores.RestRecords.RESTST_662e235c01358293d93e19bedad72008Structure> outParamList;
[JsonProperty("Count")]
public int? outParamCount;


    public static RESTConectaProveedores_e_Orders_wb_OrderDetail_1Info_DataActionGetOrderMainItems_Outputs FromOutputs(IBehaviorsConfiguration conf, RL_3e44f5588517fc49ab4a1e35f755766f outParamList, int outParamCount) {RESTConectaProveedores_e_Orders_wb_OrderDetail_1Info_DataActionGetOrderMainItems_Outputs result = new RESTConectaProveedores_e_Orders_wb_OrderDetail_1Info_DataActionGetOrderMainItems_Outputs();
// Write the needed fields of the list outParamList to the result.outParamList
ssConectaProveedores.RestRecords.RESTST_662e235c01358293d93e19bedad72008Structure tmpoutParamListElement;
if(outParamList.Empty) {
// Write the needed fields of the record outParamList.CurrentRec to the tmpoutParamListElement
tmpoutParamListElement = new ssConectaProveedores.RestRecords.RESTST_662e235c01358293d93e19bedad72008Structure();
// Write optimized tmpoutParamListElement.AttrSelect
tmpoutParamListElement.AttrSelect = (bool?) false;
// Write optimized tmpoutParamListElement.AttrOrderMainItemId
tmpoutParamListElement.AttrOrderMainItemId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrOrderNumber
tmpoutParamListElement.AttrOrderNumber = "";
tmpoutParamListElement.AttrPosition = outParamList.CurrentRec.ssPosition;
tmpoutParamListElement.AttrMaterialCode = outParamList.CurrentRec.ssMaterialCode;
tmpoutParamListElement.AttrMaterialDescription = outParamList.CurrentRec.ssMaterialDescription;
tmpoutParamListElement.AttrQuantity = (decimal?) outParamList.CurrentRec.ssQuantity;
tmpoutParamListElement.AttrQuantityDelivered = (decimal?) outParamList.CurrentRec.ssQuantityDelivered;
// Write optimized tmpoutParamListElement.AttrQuantityAvailable
tmpoutParamListElement.AttrQuantityAvailable = (decimal?) 0.0M;
tmpoutParamListElement.AttrOrderUnitOfMeasure = outParamList.CurrentRec.ssOrderUnitOfMeasure;
// Write optimized tmpoutParamListElement.AttrCurrency
tmpoutParamListElement.AttrCurrency = "";
// Write optimized tmpoutParamListElement.AttrTotalAmount
tmpoutParamListElement.AttrTotalAmount = (decimal?) 0.0M;
// Write optimized tmpoutParamListElement.AttrStatus
tmpoutParamListElement.AttrStatus = "";
// Write optimized tmpoutParamListElement.AttrStatusClass
tmpoutParamListElement.AttrStatusClass = "";
// Write optimized tmpoutParamListElement.AttrDeliveryDate
tmpoutParamListElement.AttrDeliveryDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
tmpoutParamListElement.AttrUnitPrice = (decimal?) outParamList.CurrentRec.ssUnitPrice;
// Write optimized tmpoutParamListElement.AttrAssigmentCode
tmpoutParamListElement.AttrAssigmentCode = "";
tmpoutParamListElement.AttrVATRate = (decimal?) outParamList.CurrentRec.ssVATRate;
// Write optimized tmpoutParamListElement.AttrImportDelivered
tmpoutParamListElement.AttrImportDelivered = (decimal?) 0.0M;
tmpoutParamListElement.AttrIsDeleted = (bool?) outParamList.CurrentRec.ssIsDeleted;
tmpoutParamListElement.AttrIsBlocked = (bool?) outParamList.CurrentRec.ssIsBlocked;
tmpoutParamListElement.AttrBaseQuantity = (int?) outParamList.CurrentRec.ssBaseQuantity;
tmpoutParamListElement.AttrIsFinalDelivered = (bool?) outParamList.CurrentRec.ssIsFinalDelivered;
tmpoutParamListElement.AttrCostcenter = outParamList.CurrentRec.ssCostcenter;
tmpoutParamListElement.AttrRegion = outParamList.CurrentRec.ssRegion;
tmpoutParamListElement.AttrVAtIndicator = outParamList.CurrentRec.ssVAtIndicator;
result.outParamList = new RestList<ssConectaProveedores.RestRecords.RESTST_662e235c01358293d93e19bedad72008Structure>(new ssConectaProveedores.RestRecords.RESTST_662e235c01358293d93e19bedad72008Structure[] {}, tmpoutParamListElement);
} else {
List<ssConectaProveedores.RestRecords.RESTST_662e235c01358293d93e19bedad72008Structure>
 tmpoutParamList1List = new List<ssConectaProveedores.RestRecords.RESTST_662e235c01358293d93e19bedad72008Structure>
();
try {outParamList.StartIteration();
while (!(outParamList.Eof)) {
// Write the needed fields of the record outParamList.CurrentRec to the tmpoutParamListElement
tmpoutParamListElement = new ssConectaProveedores.RestRecords.RESTST_662e235c01358293d93e19bedad72008Structure();
// Write optimized tmpoutParamListElement.AttrSelect
tmpoutParamListElement.AttrSelect = (bool?) false;
// Write optimized tmpoutParamListElement.AttrOrderMainItemId
tmpoutParamListElement.AttrOrderMainItemId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrOrderNumber
tmpoutParamListElement.AttrOrderNumber = "";
tmpoutParamListElement.AttrPosition = outParamList.CurrentRec.ssPosition;
tmpoutParamListElement.AttrMaterialCode = outParamList.CurrentRec.ssMaterialCode;
tmpoutParamListElement.AttrMaterialDescription = outParamList.CurrentRec.ssMaterialDescription;
tmpoutParamListElement.AttrQuantity = (decimal?) outParamList.CurrentRec.ssQuantity;
tmpoutParamListElement.AttrQuantityDelivered = (decimal?) outParamList.CurrentRec.ssQuantityDelivered;
// Write optimized tmpoutParamListElement.AttrQuantityAvailable
tmpoutParamListElement.AttrQuantityAvailable = (decimal?) 0.0M;
tmpoutParamListElement.AttrOrderUnitOfMeasure = outParamList.CurrentRec.ssOrderUnitOfMeasure;
// Write optimized tmpoutParamListElement.AttrCurrency
tmpoutParamListElement.AttrCurrency = "";
// Write optimized tmpoutParamListElement.AttrTotalAmount
tmpoutParamListElement.AttrTotalAmount = (decimal?) 0.0M;
// Write optimized tmpoutParamListElement.AttrStatus
tmpoutParamListElement.AttrStatus = "";
// Write optimized tmpoutParamListElement.AttrStatusClass
tmpoutParamListElement.AttrStatusClass = "";
// Write optimized tmpoutParamListElement.AttrDeliveryDate
tmpoutParamListElement.AttrDeliveryDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
tmpoutParamListElement.AttrUnitPrice = (decimal?) outParamList.CurrentRec.ssUnitPrice;
// Write optimized tmpoutParamListElement.AttrAssigmentCode
tmpoutParamListElement.AttrAssigmentCode = "";
tmpoutParamListElement.AttrVATRate = (decimal?) outParamList.CurrentRec.ssVATRate;
// Write optimized tmpoutParamListElement.AttrImportDelivered
tmpoutParamListElement.AttrImportDelivered = (decimal?) 0.0M;
tmpoutParamListElement.AttrIsDeleted = (bool?) outParamList.CurrentRec.ssIsDeleted;
tmpoutParamListElement.AttrIsBlocked = (bool?) outParamList.CurrentRec.ssIsBlocked;
tmpoutParamListElement.AttrBaseQuantity = (int?) outParamList.CurrentRec.ssBaseQuantity;
tmpoutParamListElement.AttrIsFinalDelivered = (bool?) outParamList.CurrentRec.ssIsFinalDelivered;
tmpoutParamListElement.AttrCostcenter = outParamList.CurrentRec.ssCostcenter;
tmpoutParamListElement.AttrRegion = outParamList.CurrentRec.ssRegion;
tmpoutParamListElement.AttrVAtIndicator = outParamList.CurrentRec.ssVAtIndicator;
tmpoutParamList1List.Add(tmpoutParamListElement);
outParamList.Advance();
}

} finally {
outParamList.EndIteration();
}

result.outParamList = new RestList<ssConectaProveedores.RestRecords.RESTST_662e235c01358293d93e19bedad72008Structure>(tmpoutParamList1List.ToArray(), default(ssConectaProveedores.RestRecords.RESTST_662e235c01358293d93e19bedad72008Structure));
}

result.outParamCount = (int?) outParamCount;
return result;
}


    public static ConectaProveedores_e_Orders_wb_OrderDetail_1Info_DataActionGetOrderMainItems_Model ToModel(RESTConectaProveedores_e_Orders_wb_OrderDetail_1Info_DataActionGetOrderMainItems_Outputs variables) {ConectaProveedores_e_Orders_wb_OrderDetail_1Info_DataActionGetOrderMainItems_Model result = new ConectaProveedores_e_Orders_wb_OrderDetail_1Info_DataActionGetOrderMainItems_Model();
result.outParamList = variables == null ? new RL_3e44f5588517fc49ab4a1e35f755766f() : RL_3e44f5588517fc49ab4a1e35f755766f.FromRestList(variables.outParamList, ssConectaProveedores.RestRecords.RESTST_662e235c01358293d93e19bedad72008Structure.ToStructure);
result.outParamCount = variables == null || variables.outParamCount == null ? 0 : variables.outParamCount.Value;
return result;
}


    public static RESTConectaProveedores_e_Orders_wb_OrderDetail_1Info_DataActionGetOrderMainItems_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_e_Orders_wb_OrderDetail_1Info_DataActionGetOrderMainItems_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_e_Orders_wb_OrderDetail_1Info_DataActionGetOrderMainItems_Outputs result = new RESTConectaProveedores_e_Orders_wb_OrderDetail_1Info_DataActionGetOrderMainItems_Outputs();
result.outParamList = screenModel.outParamList.ToRestList<ssConectaProveedores.RestRecords.RESTST_662e235c01358293d93e19bedad72008Structure>(ssConectaProveedores.RestRecords.RESTST_662e235c01358293d93e19bedad72008Structure.FromStructureDelegate(conf));
result.outParamCount = (int?) screenModel.outParamCount;
return result;
}

}
