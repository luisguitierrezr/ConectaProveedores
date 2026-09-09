using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_e_Orders_Wb_AssignUserOrderPopup_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("i_IsBulkAssign")]
public bool? inParami_IsBulkAssign;
[JsonProperty("i_OrderList")]
public RestList<ssConectaProveedores.RestRecords.RESTRC_26cbbaf47ee3c0155ebd57237529c97f> inParami_OrderList;
[JsonProperty("l_IsExecuting")]
public bool? varLcl_IsExecuting;
[JsonProperty("l_AssignUserId")]
public string varLcl_AssignUserId;
[JsonProperty("GetUsersList")]
public RESTConectaProveedores_e_Orders_Wb_AssignUserOrderPopup_DataActionGetUsersList_Outputs varLcGetUsersList;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_e_Orders_Wb_AssignUserOrderPopup_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_e_Orders_Wb_AssignUserOrderPopup_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_e_Orders_Wb_AssignUserOrderPopup_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_e_Orders_Wb_AssignUserOrderPopup_ScreenModel ToModel() {bool inParami_IsBulkAssign = variables.inParami_IsBulkAssign == null ? false : variables.inParami_IsBulkAssign.Value;
RL_e86d03b22fb6d164e868d40e92a28f1a inParami_OrderList = RL_e86d03b22fb6d164e868d40e92a28f1a.FromRestList(variables.inParami_OrderList, ssConectaProveedores.RestRecords.RESTRC_26cbbaf47ee3c0155ebd57237529c97f.ToStructure);
bool varLcl_IsExecuting = variables.varLcl_IsExecuting == null ? false : variables.varLcl_IsExecuting.Value;
string varLcl_AssignUserId = variables.varLcl_AssignUserId == null ? "" : variables.varLcl_AssignUserId;
ConectaProveedores_e_Orders_Wb_AssignUserOrderPopup_DataActionGetUsersList_Model _varLcGetUsersList = (variables.varLcGetUsersList != null) ? RESTConectaProveedores_e_Orders_Wb_AssignUserOrderPopup_DataActionGetUsersList_Outputs.ToModel(variables.varLcGetUsersList) : null;
ConectaProveedores_e_Orders_Wb_AssignUserOrderPopup_ScreenModel screenModel = new ConectaProveedores_e_Orders_Wb_AssignUserOrderPopup_ScreenModel(inParami_IsBulkAssign, inParami_OrderList, varLcl_IsExecuting, varLcl_AssignUserId, _varLcGetUsersList, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
