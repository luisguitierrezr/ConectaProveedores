using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_c_Requisitions_Wb_AssignFirstApproverPopup_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetUserById")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_184336c68155ad9e77005f91e8e8b363> ScreenDataSetGetUserById;
[JsonProperty("l_IsBusy")]
public bool? varLcl_IsBusy;
[JsonProperty("l_UserSelected")]
public string varLcl_UserSelected;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_c_Requisitions_Wb_AssignFirstApproverPopup_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_c_Requisitions_Wb_AssignFirstApproverPopup_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_c_Requisitions_Wb_AssignFirstApproverPopup_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_c_Requisitions_Wb_AssignFirstApproverPopup_ScreenModel ToModel() {bool varLcl_IsBusy = variables.varLcl_IsBusy == null ? false : variables.varLcl_IsBusy.Value;
string varLcl_UserSelected = variables.varLcl_UserSelected == null ? "" : variables.varLcl_UserSelected;
AggregateRecord<RL_bc2063fe1d05aa544017f329fb1e030b> _ScreenDataSetGetUserById = (variables.ScreenDataSetGetUserById != null) ? variables.ScreenDataSetGetUserById.FromJS((array) => {
return RL_bc2063fe1d05aa544017f329fb1e030b.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_184336c68155ad9e77005f91e8e8b363.ToStructure);
}
) : null;
ConectaProveedores_c_Requisitions_Wb_AssignFirstApproverPopup_ScreenModel screenModel = new ConectaProveedores_c_Requisitions_Wb_AssignFirstApproverPopup_ScreenModel(varLcl_IsBusy, varLcl_UserSelected, _ScreenDataSetGetUserById, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
