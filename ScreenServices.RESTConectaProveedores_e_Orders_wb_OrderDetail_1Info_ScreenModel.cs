using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_e_Orders_wb_OrderDetail_1Info_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetOrderById")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_7001c2850e85d9dc361469a649a88466> ScreenDataSetGetOrderById;
[JsonProperty("OrderId")]
public long? inParamOrderId;
[JsonProperty("TableSort")]
public string varLcTableSort;
[JsonProperty("StartIndex")]
public int? varLcStartIndex;
[JsonProperty("MaxRecords")]
public int? varLcMaxRecords;
[JsonProperty("TempValues")]
public ssConectaProveedores.RestRecords.RESTST_9b020d447acc32d28b5e58ce81130d00Structure varLcTempValues;
[JsonProperty("GetOrderMainItems")]
public RESTConectaProveedores_e_Orders_wb_OrderDetail_1Info_DataActionGetOrderMainItems_Outputs varLcGetOrderMainItems;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_e_Orders_wb_OrderDetail_1Info_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_e_Orders_wb_OrderDetail_1Info_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_e_Orders_wb_OrderDetail_1Info_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_e_Orders_wb_OrderDetail_1Info_ScreenModel ToModel() {long inParamOrderId = variables.inParamOrderId == null ? 0L : variables.inParamOrderId.Value;
string varLcTableSort = variables.varLcTableSort == null ? "" : variables.varLcTableSort;
int varLcStartIndex = variables.varLcStartIndex == null ? 0 : variables.varLcStartIndex.Value;
int varLcMaxRecords = variables.varLcMaxRecords == null ? 50 : variables.varLcMaxRecords.Value;
ST_9b020d447acc32d28b5e58ce81130d00Structure varLcTempValues = ssConectaProveedores.RestRecords.RESTST_9b020d447acc32d28b5e58ce81130d00Structure.ToStructure(variables.varLcTempValues);
AggregateRecord<RL_1ded8df557cc19c3bf639ef70eaf909e> _ScreenDataSetGetOrderById = (variables.ScreenDataSetGetOrderById != null) ? variables.ScreenDataSetGetOrderById.FromJS((array) => {
return RL_1ded8df557cc19c3bf639ef70eaf909e.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_7001c2850e85d9dc361469a649a88466.ToStructure);
}
) : null;
ConectaProveedores_e_Orders_wb_OrderDetail_1Info_DataActionGetOrderMainItems_Model _varLcGetOrderMainItems = (variables.varLcGetOrderMainItems != null) ? RESTConectaProveedores_e_Orders_wb_OrderDetail_1Info_DataActionGetOrderMainItems_Outputs.ToModel(variables.varLcGetOrderMainItems) : null;
ConectaProveedores_e_Orders_wb_OrderDetail_1Info_ScreenModel screenModel = new ConectaProveedores_e_Orders_wb_OrderDetail_1Info_ScreenModel(inParamOrderId, varLcTableSort, varLcStartIndex, varLcMaxRecords, varLcTempValues, _ScreenDataSetGetOrderById, _varLcGetOrderMainItems, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
