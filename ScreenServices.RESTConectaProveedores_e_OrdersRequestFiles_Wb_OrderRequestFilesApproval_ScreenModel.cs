using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_e_OrdersRequestFiles_Wb_OrderRequestFilesApproval_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetOrderRequestFileApprovalLevels")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_0a31a39e5189fa78e8cbab87cf47752b> ScreenDataSetGetOrderRequestFileApprovalLevels;
[JsonProperty("i_OrderId")]
public long? inParami_OrderId;
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
[JsonProperty("ShowHideOrdReqFileRejectPopup")]
public bool? varLcShowHideOrdReqFileRejectPopup;
[JsonProperty("l_OrderRequestFileApprovalLevelId")]
public long? varLcl_OrderRequestFileApprovalLevelId;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_e_OrdersRequestFiles_Wb_OrderRequestFilesApproval_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_e_OrdersRequestFiles_Wb_OrderRequestFilesApproval_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_e_OrdersRequestFiles_Wb_OrderRequestFilesApproval_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_e_OrdersRequestFiles_Wb_OrderRequestFilesApproval_ScreenModel ToModel() {long inParami_OrderId = variables.inParami_OrderId == null ? 0L : variables.inParami_OrderId.Value;
string varLcl_ColumnJSONVar = variables.varLcl_ColumnJSONVar == null ? "" : variables.varLcl_ColumnJSONVar;
bool varLcl_ReInvokeToggler = variables.varLcl_ReInvokeToggler == null ? false : variables.varLcl_ReInvokeToggler.Value;
int varLcl_CountAfterFetch = variables.varLcl_CountAfterFetch == null ? 0 : variables.varLcl_CountAfterFetch.Value;
int varLcl_StartIndex = variables.varLcl_StartIndex == null ? 0 : variables.varLcl_StartIndex.Value;
string varLcTableSort = variables.varLcTableSort == null ? "" : variables.varLcTableSort;
bool varLcShowHideOrdReqFileRejectPopup = variables.varLcShowHideOrdReqFileRejectPopup == null ? false : variables.varLcShowHideOrdReqFileRejectPopup.Value;
long varLcl_OrderRequestFileApprovalLevelId = variables.varLcl_OrderRequestFileApprovalLevelId == null ? 0L : variables.varLcl_OrderRequestFileApprovalLevelId.Value;
AggregateRecord<RL_973c3440756f350a5cffc50d9d6bb1d9> _ScreenDataSetGetOrderRequestFileApprovalLevels = (variables.ScreenDataSetGetOrderRequestFileApprovalLevels != null) ? variables.ScreenDataSetGetOrderRequestFileApprovalLevels.FromJS((array) => {
return RL_973c3440756f350a5cffc50d9d6bb1d9.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_0a31a39e5189fa78e8cbab87cf47752b.ToStructure);
}
) : null;
ConectaProveedores_e_OrdersRequestFiles_Wb_OrderRequestFilesApproval_ScreenModel screenModel = new ConectaProveedores_e_OrdersRequestFiles_Wb_OrderRequestFilesApproval_ScreenModel(inParami_OrderId, varLcl_ColumnJSONVar, varLcl_ReInvokeToggler, varLcl_CountAfterFetch, varLcl_StartIndex, varLcTableSort, varLcShowHideOrdReqFileRejectPopup, varLcl_OrderRequestFileApprovalLevelId, _ScreenDataSetGetOrderRequestFileApprovalLevels, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
