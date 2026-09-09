using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_a_Common_Wb_AssignTempRolePopup_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetLoggedUserInfo")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_d4fdf5fe986f15577c3a6610348f52f6> ScreenDataSetGetLoggedUserInfo;
[JsonProperty("GetUsersFromSameRegion")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_34272dae45b4de5e1332f46c6e8700b9> ScreenDataSetGetUsersFromSameRegion;
[JsonProperty("l_UserApplicationRoleTemp")]
public ssConectaProveedores.RestRecords.RESTEN_20bdea9cf8f17569719f414a83b584b6EntityRecord inParaml_UserApplicationRoleTemp;
[JsonProperty("l_UserDropdownValid")]
public bool? varLcl_UserDropdownValid;
[JsonProperty("l_UserDropdownValidationMessage")]
public string varLcl_UserDropdownValidationMessage;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_a_Common_Wb_AssignTempRolePopup_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_a_Common_Wb_AssignTempRolePopup_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_a_Common_Wb_AssignTempRolePopup_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_a_Common_Wb_AssignTempRolePopup_ScreenModel ToModel() {EN_20bdea9cf8f17569719f414a83b584b6EntityRecord inParaml_UserApplicationRoleTemp = ssConectaProveedores.RestRecords.RESTEN_20bdea9cf8f17569719f414a83b584b6EntityRecord.ToStructure(variables.inParaml_UserApplicationRoleTemp);
bool varLcl_UserDropdownValid = variables.varLcl_UserDropdownValid == null ? true : variables.varLcl_UserDropdownValid.Value;
string varLcl_UserDropdownValidationMessage = variables.varLcl_UserDropdownValidationMessage == null ? "" : variables.varLcl_UserDropdownValidationMessage;
AggregateRecord<RL_edcb7e1d218607fc80645a6019e669d1> _ScreenDataSetGetLoggedUserInfo = (variables.ScreenDataSetGetLoggedUserInfo != null) ? variables.ScreenDataSetGetLoggedUserInfo.FromJS((array) => {
return RL_edcb7e1d218607fc80645a6019e669d1.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_d4fdf5fe986f15577c3a6610348f52f6.ToStructure);
}
) : null;
AggregateRecord<RL_752c66ffcb633a1081093541635464e7> _ScreenDataSetGetUsersFromSameRegion = (variables.ScreenDataSetGetUsersFromSameRegion != null) ? variables.ScreenDataSetGetUsersFromSameRegion.FromJS((array) => {
return RL_752c66ffcb633a1081093541635464e7.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_34272dae45b4de5e1332f46c6e8700b9.ToStructure);
}
) : null;
ConectaProveedores_a_Common_Wb_AssignTempRolePopup_ScreenModel screenModel = new ConectaProveedores_a_Common_Wb_AssignTempRolePopup_ScreenModel(inParaml_UserApplicationRoleTemp, varLcl_UserDropdownValid, varLcl_UserDropdownValidationMessage, _ScreenDataSetGetLoggedUserInfo, _ScreenDataSetGetUsersFromSameRegion, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
