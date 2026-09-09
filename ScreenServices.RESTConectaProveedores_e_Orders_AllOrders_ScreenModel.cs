using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_e_Orders_AllOrders_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetOrderMain")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_cbbe4b608ba4cd678dd3afd544ca547e> ScreenDataSetGetOrderMain;
[JsonProperty("TableSort")]
public string varLcTableSort;
[JsonProperty("StartIndex")]
public int? varLcStartIndex;
[JsonProperty("MaxRecords")]
public int? varLcMaxRecords;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_e_Orders_AllOrders_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_e_Orders_AllOrders_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_e_Orders_AllOrders_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_e_Orders_AllOrders_ScreenModel ToModel() {string varLcTableSort = variables.varLcTableSort == null ? "" : variables.varLcTableSort;
int varLcStartIndex = variables.varLcStartIndex == null ? 0 : variables.varLcStartIndex.Value;
int varLcMaxRecords = variables.varLcMaxRecords == null ? 50 : variables.varLcMaxRecords.Value;
AggregateRecord<RL_823234b28f8a1e65f461ac57ab48bc32> _ScreenDataSetGetOrderMain = (variables.ScreenDataSetGetOrderMain != null) ? variables.ScreenDataSetGetOrderMain.FromJS((array) => {
return RL_823234b28f8a1e65f461ac57ab48bc32.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_cbbe4b608ba4cd678dd3afd544ca547e.ToStructure);
}
) : null;
ConectaProveedores_e_Orders_AllOrders_ScreenModel screenModel = new ConectaProveedores_e_Orders_AllOrders_ScreenModel(varLcTableSort, varLcStartIndex, varLcMaxRecords, _ScreenDataSetGetOrderMain, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
