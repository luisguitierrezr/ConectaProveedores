using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_e_Orders_Orders_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetRegions")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_deb85dc36640fa928dae5df2493065d0> ScreenDataSetGetRegions;
[JsonProperty("GetOrderStatuses")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_919d72dc5292e812597af4fac0a808e4> ScreenDataSetGetOrderStatuses;
[JsonProperty("l_TableSort")]
public string varLcl_TableSort;
[JsonProperty("l_StartIndex")]
public int? varLcl_StartIndex;
[JsonProperty("l_ReInvokeToggler")]
public bool? varLcl_ReInvokeToggler;
[JsonProperty("l_ColumnJSONVarGetOrders")]
public string varLcl_ColumnJSONVarGetOrders;
[JsonProperty("l_CountAfterFetchGetOrders")]
public int? varLcl_CountAfterFetchGetOrders;
[JsonProperty("GetOrdersData")]
public RESTConectaProveedores_e_Orders_Orders_DataActionGetOrdersData_Outputs varLcGetOrdersData;
[JsonProperty("CheckUser")]
public RESTConectaProveedores_e_Orders_Orders_DataActionCheckUser_Outputs varLcCheckUser;
[JsonProperty("GetUserApplicationRoles")]
public RESTConectaProveedores_e_Orders_Orders_DataActionGetUserApplicationRoles_Outputs varLcGetUserApplicationRoles;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_e_Orders_Orders_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_e_Orders_Orders_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_e_Orders_Orders_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_e_Orders_Orders_ScreenModel ToModel() {string varLcl_TableSort = variables.varLcl_TableSort == null ? "{OrderMain}.[Id] DESC" : variables.varLcl_TableSort;
int varLcl_StartIndex = variables.varLcl_StartIndex == null ? 0 : variables.varLcl_StartIndex.Value;
bool varLcl_ReInvokeToggler = variables.varLcl_ReInvokeToggler == null ? false : variables.varLcl_ReInvokeToggler.Value;
string varLcl_ColumnJSONVarGetOrders = variables.varLcl_ColumnJSONVarGetOrders == null ? "" : variables.varLcl_ColumnJSONVarGetOrders;
int varLcl_CountAfterFetchGetOrders = variables.varLcl_CountAfterFetchGetOrders == null ? 0 : variables.varLcl_CountAfterFetchGetOrders.Value;
AggregateRecord<RL_5d3a02aa993c7474297e33d992f39ad0> _ScreenDataSetGetRegions = (variables.ScreenDataSetGetRegions != null) ? variables.ScreenDataSetGetRegions.FromJS((array) => {
return RL_5d3a02aa993c7474297e33d992f39ad0.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_deb85dc36640fa928dae5df2493065d0.ToStructure);
}
) : null;
AggregateRecord<RL_cf716c649767b1312d0b25fa52ff2f38> _ScreenDataSetGetOrderStatuses = (variables.ScreenDataSetGetOrderStatuses != null) ? variables.ScreenDataSetGetOrderStatuses.FromJS((array) => {
return RL_cf716c649767b1312d0b25fa52ff2f38.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_919d72dc5292e812597af4fac0a808e4.ToStructure);
}
) : null;
ConectaProveedores_e_Orders_Orders_DataActionGetOrdersData_Model _varLcGetOrdersData = (variables.varLcGetOrdersData != null) ? RESTConectaProveedores_e_Orders_Orders_DataActionGetOrdersData_Outputs.ToModel(variables.varLcGetOrdersData) : null;
ConectaProveedores_e_Orders_Orders_DataActionCheckUser_Model _varLcCheckUser = (variables.varLcCheckUser != null) ? RESTConectaProveedores_e_Orders_Orders_DataActionCheckUser_Outputs.ToModel(variables.varLcCheckUser) : null;
ConectaProveedores_e_Orders_Orders_DataActionGetUserApplicationRoles_Model _varLcGetUserApplicationRoles = (variables.varLcGetUserApplicationRoles != null) ? RESTConectaProveedores_e_Orders_Orders_DataActionGetUserApplicationRoles_Outputs.ToModel(variables.varLcGetUserApplicationRoles) : null;
ConectaProveedores_e_Orders_Orders_ScreenModel screenModel = new ConectaProveedores_e_Orders_Orders_ScreenModel(varLcl_TableSort, varLcl_StartIndex, varLcl_ReInvokeToggler, varLcl_ColumnJSONVarGetOrders, varLcl_CountAfterFetchGetOrders, _ScreenDataSetGetRegions, _ScreenDataSetGetOrderStatuses, _varLcGetOrdersData, _varLcCheckUser, _varLcGetUserApplicationRoles, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
