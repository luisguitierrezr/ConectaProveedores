using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_e_Orders_OrderDetail_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetRejectComment")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_cd61721ee82121e78e4055ba4deb1fa6> ScreenDataSetGetRejectComment;
[JsonProperty("GetOrdersByContractNumber")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_64337b445a88908182ed34f64cf1399b> ScreenDataSetGetOrdersByContractNumber;
[JsonProperty("GetOrderMainById")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_06eea14cc287e1e6b6d33a1bc97971e2> ScreenDataSetGetOrderMainById;
[JsonProperty("i_OrderId")]
public long? inParami_OrderId;
[JsonProperty("ShowOrderReject_Popup")]
public bool? varLcShowOrderReject_Popup;
[JsonProperty("l_RefreshSideBar")]
public String varLcl_RefreshSideBar;
[JsonProperty("l_ActiveTab")]
public int? varLcl_ActiveTab;
[JsonProperty("IsShowHistoric")]
public bool? varLcIsShowHistoric;
[JsonProperty("l_ForceRefresh")]
public String varLcl_ForceRefresh;
[JsonProperty("GetSettings")]
public RESTConectaProveedores_e_Orders_OrderDetail_DataActionGetSettings_Outputs varLcGetSettings;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_e_Orders_OrderDetail_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_e_Orders_OrderDetail_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_e_Orders_OrderDetail_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_e_Orders_OrderDetail_ScreenModel ToModel() {long inParami_OrderId = variables.inParami_OrderId == null ? 0L : variables.inParami_OrderId.Value;
bool varLcShowOrderReject_Popup = variables.varLcShowOrderReject_Popup == null ? false : variables.varLcShowOrderReject_Popup.Value;
DateTime varLcl_RefreshSideBar = variables.varLcl_RefreshSideBar == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(variables.varLcl_RefreshSideBar, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
int varLcl_ActiveTab = variables.varLcl_ActiveTab == null ? 0 : variables.varLcl_ActiveTab.Value;
bool varLcIsShowHistoric = variables.varLcIsShowHistoric == null ? false : variables.varLcIsShowHistoric.Value;
DateTime varLcl_ForceRefresh = variables.varLcl_ForceRefresh == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(variables.varLcl_ForceRefresh, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
AggregateRecord<RL_17d8289ea48572225dc9530a5725652a> _ScreenDataSetGetRejectComment = (variables.ScreenDataSetGetRejectComment != null) ? variables.ScreenDataSetGetRejectComment.FromJS((array) => {
return RL_17d8289ea48572225dc9530a5725652a.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_cd61721ee82121e78e4055ba4deb1fa6.ToStructure);
}
) : null;
AggregateRecord<RL_9129a40e214c2e67892c6ae5dfbfb7b5> _ScreenDataSetGetOrdersByContractNumber = (variables.ScreenDataSetGetOrdersByContractNumber != null) ? variables.ScreenDataSetGetOrdersByContractNumber.FromJS((array) => {
return RL_9129a40e214c2e67892c6ae5dfbfb7b5.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_64337b445a88908182ed34f64cf1399b.ToStructure);
}
) : null;
AggregateRecord<RL_4f9bb0401ba1a9d16c01e66cc4639c20> _ScreenDataSetGetOrderMainById = (variables.ScreenDataSetGetOrderMainById != null) ? variables.ScreenDataSetGetOrderMainById.FromJS((array) => {
return RL_4f9bb0401ba1a9d16c01e66cc4639c20.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_06eea14cc287e1e6b6d33a1bc97971e2.ToStructure);
}
) : null;
ConectaProveedores_e_Orders_OrderDetail_DataActionGetSettings_Model _varLcGetSettings = (variables.varLcGetSettings != null) ? RESTConectaProveedores_e_Orders_OrderDetail_DataActionGetSettings_Outputs.ToModel(variables.varLcGetSettings) : null;
ConectaProveedores_e_Orders_OrderDetail_ScreenModel screenModel = new ConectaProveedores_e_Orders_OrderDetail_ScreenModel(inParami_OrderId, varLcShowOrderReject_Popup, varLcl_RefreshSideBar, varLcl_ActiveTab, varLcIsShowHistoric, varLcl_ForceRefresh, _ScreenDataSetGetRejectComment, _ScreenDataSetGetOrdersByContractNumber, _ScreenDataSetGetOrderMainById, _varLcGetSettings, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
