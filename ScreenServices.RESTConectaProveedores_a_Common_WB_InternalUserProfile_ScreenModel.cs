using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_a_Common_WB_InternalUserProfile_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetUserDetails")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_3435fb4b7e2feceb28dc5478c72a6c4b> ScreenDataSetGetUserDetails;
[JsonProperty("l_IsOpenPopUp")]
public bool? varLcl_IsOpenPopUp;
[JsonProperty("GetEntraManager")]
public RESTConectaProveedores_a_Common_WB_InternalUserProfile_DataActionGetEntraManager_Outputs varLcGetEntraManager;
[JsonProperty("GetUserApplicationRoles")]
public RESTConectaProveedores_a_Common_WB_InternalUserProfile_DataActionGetUserApplicationRoles_Outputs varLcGetUserApplicationRoles;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_a_Common_WB_InternalUserProfile_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_a_Common_WB_InternalUserProfile_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_a_Common_WB_InternalUserProfile_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_a_Common_WB_InternalUserProfile_ScreenModel ToModel() {bool varLcl_IsOpenPopUp = variables.varLcl_IsOpenPopUp == null ? false : variables.varLcl_IsOpenPopUp.Value;
AggregateRecord<RL_8ded51402e95dd8f74345a43f441735c> _ScreenDataSetGetUserDetails = (variables.ScreenDataSetGetUserDetails != null) ? variables.ScreenDataSetGetUserDetails.FromJS((array) => {
return RL_8ded51402e95dd8f74345a43f441735c.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_3435fb4b7e2feceb28dc5478c72a6c4b.ToStructure);
}
) : null;
ConectaProveedores_a_Common_WB_InternalUserProfile_DataActionGetEntraManager_Model _varLcGetEntraManager = (variables.varLcGetEntraManager != null) ? RESTConectaProveedores_a_Common_WB_InternalUserProfile_DataActionGetEntraManager_Outputs.ToModel(variables.varLcGetEntraManager) : null;
ConectaProveedores_a_Common_WB_InternalUserProfile_DataActionGetUserApplicationRoles_Model _varLcGetUserApplicationRoles = (variables.varLcGetUserApplicationRoles != null) ? RESTConectaProveedores_a_Common_WB_InternalUserProfile_DataActionGetUserApplicationRoles_Outputs.ToModel(variables.varLcGetUserApplicationRoles) : null;
ConectaProveedores_a_Common_WB_InternalUserProfile_ScreenModel screenModel = new ConectaProveedores_a_Common_WB_InternalUserProfile_ScreenModel(varLcl_IsOpenPopUp, _ScreenDataSetGetUserDetails, _varLcGetEntraManager, _varLcGetUserApplicationRoles, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
