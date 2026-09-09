using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_e_OrdersRequestFiles_OrderRequestFilesApproval_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetOrderRequestFileApprovalLevels")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_6fe7a87544f5e670c064f35599cfc737> ScreenDataSetGetOrderRequestFileApprovalLevels;
[JsonProperty("l_ColumnJSONVar")]
public string varLcl_ColumnJSONVar;
[JsonProperty("l_ReInvokeToggler")]
public bool? varLcl_ReInvokeToggler;
[JsonProperty("l_CountAfterFetch")]
public int? varLcl_CountAfterFetch;
[JsonProperty("l_StartIndex")]
public int? varLcl_StartIndex;
[JsonProperty("TableSort")]
public string varLcTableSort;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_e_OrdersRequestFiles_OrderRequestFilesApproval_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_e_OrdersRequestFiles_OrderRequestFilesApproval_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_e_OrdersRequestFiles_OrderRequestFilesApproval_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_e_OrdersRequestFiles_OrderRequestFilesApproval_ScreenModel ToModel() {string varLcl_ColumnJSONVar = variables.varLcl_ColumnJSONVar == null ? "" : variables.varLcl_ColumnJSONVar;
bool varLcl_ReInvokeToggler = variables.varLcl_ReInvokeToggler == null ? false : variables.varLcl_ReInvokeToggler.Value;
int varLcl_CountAfterFetch = variables.varLcl_CountAfterFetch == null ? 0 : variables.varLcl_CountAfterFetch.Value;
int varLcl_StartIndex = variables.varLcl_StartIndex == null ? 0 : variables.varLcl_StartIndex.Value;
string varLcTableSort = variables.varLcTableSort == null ? "" : variables.varLcTableSort;
AggregateRecord<RL_ef17ec11e9847e3aee2e73d3f7420983> _ScreenDataSetGetOrderRequestFileApprovalLevels = (variables.ScreenDataSetGetOrderRequestFileApprovalLevels != null) ? variables.ScreenDataSetGetOrderRequestFileApprovalLevels.FromJS((array) => {
return RL_ef17ec11e9847e3aee2e73d3f7420983.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_6fe7a87544f5e670c064f35599cfc737.ToStructure);
}
) : null;
ConectaProveedores_e_OrdersRequestFiles_OrderRequestFilesApproval_ScreenModel screenModel = new ConectaProveedores_e_OrdersRequestFiles_OrderRequestFilesApproval_ScreenModel(varLcl_ColumnJSONVar, varLcl_ReInvokeToggler, varLcl_CountAfterFetch, varLcl_StartIndex, varLcTableSort, _ScreenDataSetGetOrderRequestFileApprovalLevels, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
