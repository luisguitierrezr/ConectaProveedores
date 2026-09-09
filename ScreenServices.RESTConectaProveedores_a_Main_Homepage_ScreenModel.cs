using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_a_Main_Homepage_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("ShowPopup")]
public bool? varLcShowPopup;
[JsonProperty("l_ManualId")]
public long? varLcl_ManualId;
[JsonProperty("GetManuals2")]
public RESTConectaProveedores_a_Main_Homepage_DataActionGetManuals2_Outputs varLcGetManuals2;
[JsonProperty("GetUserApplicationRolesAndMore")]
public RESTConectaProveedores_a_Main_Homepage_DataActionGetUserApplicationRolesAndMore_Outputs varLcGetUserApplicationRolesAndMore;
[JsonProperty("GetRequisitionsKPI")]
public RESTConectaProveedores_a_Main_Homepage_DataActionGetRequisitionsKPI_Outputs varLcGetRequisitionsKPI;
[JsonProperty("GetInvoicesKPI")]
public RESTConectaProveedores_a_Main_Homepage_DataActionGetInvoicesKPI_Outputs varLcGetInvoicesKPI;
[JsonProperty("GetFoliosKPI")]
public RESTConectaProveedores_a_Main_Homepage_DataActionGetFoliosKPI_Outputs varLcGetFoliosKPI;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_a_Main_Homepage_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_a_Main_Homepage_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_a_Main_Homepage_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_a_Main_Homepage_ScreenModel ToModel() {bool varLcShowPopup = variables.varLcShowPopup == null ? false : variables.varLcShowPopup.Value;
long varLcl_ManualId = variables.varLcl_ManualId == null ? 0L : variables.varLcl_ManualId.Value;
ConectaProveedores_a_Main_Homepage_DataActionGetManuals2_Model _varLcGetManuals2 = (variables.varLcGetManuals2 != null) ? RESTConectaProveedores_a_Main_Homepage_DataActionGetManuals2_Outputs.ToModel(variables.varLcGetManuals2) : null;
ConectaProveedores_a_Main_Homepage_DataActionGetUserApplicationRolesAndMore_Model _varLcGetUserApplicationRolesAndMore = (variables.varLcGetUserApplicationRolesAndMore != null) ? RESTConectaProveedores_a_Main_Homepage_DataActionGetUserApplicationRolesAndMore_Outputs.ToModel(variables.varLcGetUserApplicationRolesAndMore) : null;
ConectaProveedores_a_Main_Homepage_DataActionGetRequisitionsKPI_Model _varLcGetRequisitionsKPI = (variables.varLcGetRequisitionsKPI != null) ? RESTConectaProveedores_a_Main_Homepage_DataActionGetRequisitionsKPI_Outputs.ToModel(variables.varLcGetRequisitionsKPI) : null;
ConectaProveedores_a_Main_Homepage_DataActionGetInvoicesKPI_Model _varLcGetInvoicesKPI = (variables.varLcGetInvoicesKPI != null) ? RESTConectaProveedores_a_Main_Homepage_DataActionGetInvoicesKPI_Outputs.ToModel(variables.varLcGetInvoicesKPI) : null;
ConectaProveedores_a_Main_Homepage_DataActionGetFoliosKPI_Model _varLcGetFoliosKPI = (variables.varLcGetFoliosKPI != null) ? RESTConectaProveedores_a_Main_Homepage_DataActionGetFoliosKPI_Outputs.ToModel(variables.varLcGetFoliosKPI) : null;
ConectaProveedores_a_Main_Homepage_ScreenModel screenModel = new ConectaProveedores_a_Main_Homepage_ScreenModel(varLcShowPopup, varLcl_ManualId, _varLcGetManuals2, _varLcGetUserApplicationRolesAndMore, _varLcGetRequisitionsKPI, _varLcGetInvoicesKPI, _varLcGetFoliosKPI, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
