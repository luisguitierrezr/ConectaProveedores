using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_e_Orders_ProviderOrderList_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetOrders")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_d95294610b1c7b76b1445c6a23286bc4> ScreenDataSetGetOrders;
[JsonProperty("l_StartIndex")]
public int? varLcl_StartIndex;
[JsonProperty("l_TableSort")]
public string varLcl_TableSort;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_e_Orders_ProviderOrderList_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_e_Orders_ProviderOrderList_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_e_Orders_ProviderOrderList_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_e_Orders_ProviderOrderList_ScreenModel ToModel() {int varLcl_StartIndex = variables.varLcl_StartIndex == null ? 0 : variables.varLcl_StartIndex.Value;
string varLcl_TableSort = variables.varLcl_TableSort == null ? "" : variables.varLcl_TableSort;
AggregateRecord<RL_22e659721c63481b25b29a0491fd3d7f> _ScreenDataSetGetOrders = (variables.ScreenDataSetGetOrders != null) ? variables.ScreenDataSetGetOrders.FromJS((array) => {
return RL_22e659721c63481b25b29a0491fd3d7f.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_d95294610b1c7b76b1445c6a23286bc4.ToStructure);
}
) : null;
ConectaProveedores_e_Orders_ProviderOrderList_ScreenModel screenModel = new ConectaProveedores_e_Orders_ProviderOrderList_ScreenModel(varLcl_StartIndex, varLcl_TableSort, _ScreenDataSetGetOrders, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
