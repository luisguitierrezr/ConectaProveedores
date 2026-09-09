using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_Wb_SearchUserDropdown_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetUserById")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_ced013358a82a813f1d9a5108f17ce79> ScreenDataSetGetUserById;
[JsonProperty("GetUsers")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_77956dae907db5f208e8a848dc366336> ScreenDataSetGetUsers;
[JsonProperty("i_IsDisable")]
public bool? inParami_IsDisable;
[JsonProperty("i_UserId")]
public string inParami_UserId;
[JsonProperty("i_IsValid")]
public bool? inParami_IsValid;
[JsonProperty("i_IsMandatory")]
public bool? inParami_IsMandatory;
[JsonProperty("i_IsFilter")]
public bool? inParami_IsFilter;
[JsonProperty("i_LabelText")]
public string inParami_LabelText;
[JsonProperty("l_UserSearchText")]
public string varLcl_UserSearchText;
[JsonProperty("l_UserMaxRecord")]
public int? varLcl_UserMaxRecord;
[JsonProperty("l_IsValid")]
public bool? varLcl_IsValid;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_j_FoliosSAE_Wb_SearchUserDropdown_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_j_FoliosSAE_Wb_SearchUserDropdown_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_j_FoliosSAE_Wb_SearchUserDropdown_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_j_FoliosSAE_Wb_SearchUserDropdown_ScreenModel ToModel() {bool inParami_IsDisable = variables.inParami_IsDisable == null ? false : variables.inParami_IsDisable.Value;
string inParami_UserId = variables.inParami_UserId == null ? "" : variables.inParami_UserId;
bool inParami_IsValid = variables.inParami_IsValid == null ? false : variables.inParami_IsValid.Value;
bool inParami_IsMandatory = variables.inParami_IsMandatory == null ? false : variables.inParami_IsMandatory.Value;
bool inParami_IsFilter = variables.inParami_IsFilter == null ? false : variables.inParami_IsFilter.Value;
string inParami_LabelText = variables.inParami_LabelText == null ? "" : variables.inParami_LabelText;
string varLcl_UserSearchText = variables.varLcl_UserSearchText == null ? "" : variables.varLcl_UserSearchText;
int varLcl_UserMaxRecord = variables.varLcl_UserMaxRecord == null ? 20 : variables.varLcl_UserMaxRecord.Value;
bool varLcl_IsValid = variables.varLcl_IsValid == null ? true : variables.varLcl_IsValid.Value;
AggregateRecord<RL_8430333e95ceffc00def96d8abb01f75> _ScreenDataSetGetUserById = (variables.ScreenDataSetGetUserById != null) ? variables.ScreenDataSetGetUserById.FromJS((array) => {
return RL_8430333e95ceffc00def96d8abb01f75.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_ced013358a82a813f1d9a5108f17ce79.ToStructure);
}
) : null;
AggregateRecord<RL_f518d708e7bb15a03a65b75b9f603096> _ScreenDataSetGetUsers = (variables.ScreenDataSetGetUsers != null) ? variables.ScreenDataSetGetUsers.FromJS((array) => {
return RL_f518d708e7bb15a03a65b75b9f603096.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_77956dae907db5f208e8a848dc366336.ToStructure);
}
) : null;
ConectaProveedores_j_FoliosSAE_Wb_SearchUserDropdown_ScreenModel screenModel = new ConectaProveedores_j_FoliosSAE_Wb_SearchUserDropdown_ScreenModel(inParami_IsDisable, inParami_UserId, inParami_IsValid, inParami_IsMandatory, inParami_IsFilter, inParami_LabelText, varLcl_UserSearchText, varLcl_UserMaxRecord, varLcl_IsValid, _ScreenDataSetGetUserById, _ScreenDataSetGetUsers, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
