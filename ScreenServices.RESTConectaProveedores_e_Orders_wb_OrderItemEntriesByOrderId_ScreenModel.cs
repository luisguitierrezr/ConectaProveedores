using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_e_Orders_wb_OrderItemEntriesByOrderId_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetOrderItemEntriesByOrderMainItemid")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_cf58ea0f756ca06745169deb0b41c0eb> ScreenDataSetGetOrderItemEntriesByOrderMainItemid;
[JsonProperty("OrderMainId")]
public long? inParamOrderMainId;
[JsonProperty("StartIndex")]
public int? varLcStartIndex;
[JsonProperty("MaxRecords")]
public int? varLcMaxRecords;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_e_Orders_wb_OrderItemEntriesByOrderId_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_e_Orders_wb_OrderItemEntriesByOrderId_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_e_Orders_wb_OrderItemEntriesByOrderId_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_e_Orders_wb_OrderItemEntriesByOrderId_ScreenModel ToModel() {long inParamOrderMainId = variables.inParamOrderMainId == null ? 0L : variables.inParamOrderMainId.Value;
int varLcStartIndex = variables.varLcStartIndex == null ? 0 : variables.varLcStartIndex.Value;
int varLcMaxRecords = variables.varLcMaxRecords == null ? 4 : variables.varLcMaxRecords.Value;
AggregateRecord<RL_3dd9bb7875fde1313207084bc3e4eb42> _ScreenDataSetGetOrderItemEntriesByOrderMainItemid = (variables.ScreenDataSetGetOrderItemEntriesByOrderMainItemid != null) ? variables.ScreenDataSetGetOrderItemEntriesByOrderMainItemid.FromJS((array) => {
return RL_3dd9bb7875fde1313207084bc3e4eb42.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_cf58ea0f756ca06745169deb0b41c0eb.ToStructure);
}
) : null;
ConectaProveedores_e_Orders_wb_OrderItemEntriesByOrderId_ScreenModel screenModel = new ConectaProveedores_e_Orders_wb_OrderItemEntriesByOrderId_ScreenModel(inParamOrderMainId, varLcStartIndex, varLcMaxRecords, _ScreenDataSetGetOrderItemEntriesByOrderMainItemid, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
