using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_e_Orders_Orders_DataActionGetOrdersData_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("Orders")]
public RestList<ssConectaProveedores.RestRecords.RESTST_1f6eb08d8d1b200d3c17cf7efe59c4dcStructure> outParamOrders;
[JsonProperty("Count")]
public int? outParamCount;
[JsonProperty("SortClause")]
public string outParamSortClause;


    public static RESTConectaProveedores_e_Orders_Orders_DataActionGetOrdersData_Outputs FromOutputs(IBehaviorsConfiguration conf, RL_e48e3539313f992e2f1ace5c3cb135f5 outParamOrders, int outParamCount, string outParamSortClause) {RESTConectaProveedores_e_Orders_Orders_DataActionGetOrdersData_Outputs result = new RESTConectaProveedores_e_Orders_Orders_DataActionGetOrdersData_Outputs();
// Write the needed fields of the list outParamOrders to the result.outParamOrders
ssConectaProveedores.RestRecords.RESTST_1f6eb08d8d1b200d3c17cf7efe59c4dcStructure tmpoutParamOrdersElement;
if(outParamOrders.Empty) {
// Write the needed fields of the record outParamOrders.CurrentRec to the tmpoutParamOrdersElement
tmpoutParamOrdersElement = new ssConectaProveedores.RestRecords.RESTST_1f6eb08d8d1b200d3c17cf7efe59c4dcStructure();
tmpoutParamOrdersElement.AttrOrderMainId = (long?) outParamOrders.CurrentRec.ssOrderMainId;
tmpoutParamOrdersElement.AttrOrderNumber = outParamOrders.CurrentRec.ssOrderNumber;
tmpoutParamOrdersElement.AttrOrderDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(outParamOrders.CurrentRec.ssOrderDate);
tmpoutParamOrdersElement.AttrOrderStatus = outParamOrders.CurrentRec.ssOrderStatus;
tmpoutParamOrdersElement.AttrOrderStatusClass = outParamOrders.CurrentRec.ssOrderStatusClass;
tmpoutParamOrdersElement.AttrOrderImportDateTime = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(outParamOrders.CurrentRec.ssOrderImportDateTime, conf.DateTimeFormat);
tmpoutParamOrdersElement.AttrRegion = outParamOrders.CurrentRec.ssRegion;
tmpoutParamOrdersElement.AttrTelcelDirection = outParamOrders.CurrentRec.ssTelcelDirection;
tmpoutParamOrdersElement.AttrSupplierName = outParamOrders.CurrentRec.ssSupplierName;
tmpoutParamOrdersElement.AttrSupplierNumber = outParamOrders.CurrentRec.ssSupplierNumber;
tmpoutParamOrdersElement.AttrFirstLevelUserName = outParamOrders.CurrentRec.ssFirstLevelUserName;
tmpoutParamOrdersElement.AttrFirstLevelJobTitle = outParamOrders.CurrentRec.ssFirstLevelJobTitle;
tmpoutParamOrdersElement.AttrFirstEntraRoleName = outParamOrders.CurrentRec.ssFirstEntraRoleName;
tmpoutParamOrdersElement.AttrCurrLevelUserName = outParamOrders.CurrentRec.ssCurrLevelUserName;
tmpoutParamOrdersElement.AttrCurrLevelJobTitle = outParamOrders.CurrentRec.ssCurrLevelJobTitle;
tmpoutParamOrdersElement.AttrCurrEntraRoleName = outParamOrders.CurrentRec.ssCurrEntraRoleName;
tmpoutParamOrdersElement.AttrAssignedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(outParamOrders.CurrentRec.ssAssignedOn, conf.DateTimeFormat);
result.outParamOrders = new RestList<ssConectaProveedores.RestRecords.RESTST_1f6eb08d8d1b200d3c17cf7efe59c4dcStructure>(new ssConectaProveedores.RestRecords.RESTST_1f6eb08d8d1b200d3c17cf7efe59c4dcStructure[] {}, tmpoutParamOrdersElement);
} else {
List<ssConectaProveedores.RestRecords.RESTST_1f6eb08d8d1b200d3c17cf7efe59c4dcStructure>
 tmpoutParamOrders1List = new List<ssConectaProveedores.RestRecords.RESTST_1f6eb08d8d1b200d3c17cf7efe59c4dcStructure>
();
try {outParamOrders.StartIteration();
while (!(outParamOrders.Eof)) {
// Write the needed fields of the record outParamOrders.CurrentRec to the tmpoutParamOrdersElement
tmpoutParamOrdersElement = new ssConectaProveedores.RestRecords.RESTST_1f6eb08d8d1b200d3c17cf7efe59c4dcStructure();
tmpoutParamOrdersElement.AttrOrderMainId = (long?) outParamOrders.CurrentRec.ssOrderMainId;
tmpoutParamOrdersElement.AttrOrderNumber = outParamOrders.CurrentRec.ssOrderNumber;
tmpoutParamOrdersElement.AttrOrderDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(outParamOrders.CurrentRec.ssOrderDate);
tmpoutParamOrdersElement.AttrOrderStatus = outParamOrders.CurrentRec.ssOrderStatus;
tmpoutParamOrdersElement.AttrOrderStatusClass = outParamOrders.CurrentRec.ssOrderStatusClass;
tmpoutParamOrdersElement.AttrOrderImportDateTime = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(outParamOrders.CurrentRec.ssOrderImportDateTime, conf.DateTimeFormat);
tmpoutParamOrdersElement.AttrRegion = outParamOrders.CurrentRec.ssRegion;
tmpoutParamOrdersElement.AttrTelcelDirection = outParamOrders.CurrentRec.ssTelcelDirection;
tmpoutParamOrdersElement.AttrSupplierName = outParamOrders.CurrentRec.ssSupplierName;
tmpoutParamOrdersElement.AttrSupplierNumber = outParamOrders.CurrentRec.ssSupplierNumber;
tmpoutParamOrdersElement.AttrFirstLevelUserName = outParamOrders.CurrentRec.ssFirstLevelUserName;
tmpoutParamOrdersElement.AttrFirstLevelJobTitle = outParamOrders.CurrentRec.ssFirstLevelJobTitle;
tmpoutParamOrdersElement.AttrFirstEntraRoleName = outParamOrders.CurrentRec.ssFirstEntraRoleName;
tmpoutParamOrdersElement.AttrCurrLevelUserName = outParamOrders.CurrentRec.ssCurrLevelUserName;
tmpoutParamOrdersElement.AttrCurrLevelJobTitle = outParamOrders.CurrentRec.ssCurrLevelJobTitle;
tmpoutParamOrdersElement.AttrCurrEntraRoleName = outParamOrders.CurrentRec.ssCurrEntraRoleName;
tmpoutParamOrdersElement.AttrAssignedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(outParamOrders.CurrentRec.ssAssignedOn, conf.DateTimeFormat);
tmpoutParamOrders1List.Add(tmpoutParamOrdersElement);
outParamOrders.Advance();
}

} finally {
outParamOrders.EndIteration();
}

result.outParamOrders = new RestList<ssConectaProveedores.RestRecords.RESTST_1f6eb08d8d1b200d3c17cf7efe59c4dcStructure>(tmpoutParamOrders1List.ToArray(), default(ssConectaProveedores.RestRecords.RESTST_1f6eb08d8d1b200d3c17cf7efe59c4dcStructure));
}

result.outParamCount = (int?) outParamCount;
result.outParamSortClause = outParamSortClause;
return result;
}


    public static ConectaProveedores_e_Orders_Orders_DataActionGetOrdersData_Model ToModel(RESTConectaProveedores_e_Orders_Orders_DataActionGetOrdersData_Outputs variables) {ConectaProveedores_e_Orders_Orders_DataActionGetOrdersData_Model result = new ConectaProveedores_e_Orders_Orders_DataActionGetOrdersData_Model();
result.outParamOrders = variables == null ? new RL_e48e3539313f992e2f1ace5c3cb135f5() : RL_e48e3539313f992e2f1ace5c3cb135f5.FromRestList(variables.outParamOrders, ssConectaProveedores.RestRecords.RESTST_1f6eb08d8d1b200d3c17cf7efe59c4dcStructure.ToStructure);
result.outParamCount = variables == null || variables.outParamCount == null ? 0 : variables.outParamCount.Value;
result.outParamSortClause = variables == null || variables.outParamSortClause == null ? "" : variables.outParamSortClause;
return result;
}


    public static RESTConectaProveedores_e_Orders_Orders_DataActionGetOrdersData_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_e_Orders_Orders_DataActionGetOrdersData_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_e_Orders_Orders_DataActionGetOrdersData_Outputs result = new RESTConectaProveedores_e_Orders_Orders_DataActionGetOrdersData_Outputs();
result.outParamOrders = screenModel.outParamOrders.ToRestList<ssConectaProveedores.RestRecords.RESTST_1f6eb08d8d1b200d3c17cf7efe59c4dcStructure>(ssConectaProveedores.RestRecords.RESTST_1f6eb08d8d1b200d3c17cf7efe59c4dcStructure.FromStructureDelegate(conf));
result.outParamCount = (int?) screenModel.outParamCount;
result.outParamSortClause = screenModel.outParamSortClause;
return result;
}

}
