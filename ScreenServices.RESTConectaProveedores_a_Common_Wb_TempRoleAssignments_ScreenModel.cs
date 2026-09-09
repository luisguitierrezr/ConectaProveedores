using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_a_Common_Wb_TempRoleAssignments_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetUserApplicationRoleTempsByUserId")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_284d6b812acb53aa55a28cbe2a22b4ca> ScreenDataSetGetUserApplicationRoleTempsByUserId;
[JsonProperty("GetUserApplicationRoleTempsByAssignedBy")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_284d6b812acb53aa55a28cbe2a22b4ca> ScreenDataSetGetUserApplicationRoleTempsByAssignedBy;
[JsonProperty("l_StartIndex")]
public int? varLcl_StartIndex;
[JsonProperty("l_MaxRecords")]
public int? varLcl_MaxRecords;
[JsonProperty("l_ShowAssignTempRolePopup")]
public bool? varLcl_ShowAssignTempRolePopup;
[JsonProperty("l_ShowConfirmPopup")]
public bool? varLcl_ShowConfirmPopup;
[JsonProperty("l_UserApplicationRoleTemp")]
public ssConectaProveedores.RestRecords.RESTEN_20bdea9cf8f17569719f414a83b584b6EntityRecord varLcl_UserApplicationRoleTemp;
[JsonProperty("l_StartIndexAssigned")]
public int? varLcl_StartIndexAssigned;
[JsonProperty("l_MaxRecordsAssigned")]
public int? varLcl_MaxRecordsAssigned;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_a_Common_Wb_TempRoleAssignments_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_a_Common_Wb_TempRoleAssignments_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_a_Common_Wb_TempRoleAssignments_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_a_Common_Wb_TempRoleAssignments_ScreenModel ToModel() {int varLcl_StartIndex = variables.varLcl_StartIndex == null ? 0 : variables.varLcl_StartIndex.Value;
int varLcl_MaxRecords = variables.varLcl_MaxRecords == null ? 5 : variables.varLcl_MaxRecords.Value;
bool varLcl_ShowAssignTempRolePopup = variables.varLcl_ShowAssignTempRolePopup == null ? false : variables.varLcl_ShowAssignTempRolePopup.Value;
bool varLcl_ShowConfirmPopup = variables.varLcl_ShowConfirmPopup == null ? false : variables.varLcl_ShowConfirmPopup.Value;
EN_20bdea9cf8f17569719f414a83b584b6EntityRecord varLcl_UserApplicationRoleTemp = ssConectaProveedores.RestRecords.RESTEN_20bdea9cf8f17569719f414a83b584b6EntityRecord.ToStructure(variables.varLcl_UserApplicationRoleTemp);
int varLcl_StartIndexAssigned = variables.varLcl_StartIndexAssigned == null ? 0 : variables.varLcl_StartIndexAssigned.Value;
int varLcl_MaxRecordsAssigned = variables.varLcl_MaxRecordsAssigned == null ? 5 : variables.varLcl_MaxRecordsAssigned.Value;
AggregateRecord<RL_bb4d6e713cd7ffbd47871f2337312efa> _ScreenDataSetGetUserApplicationRoleTempsByUserId = (variables.ScreenDataSetGetUserApplicationRoleTempsByUserId != null) ? variables.ScreenDataSetGetUserApplicationRoleTempsByUserId.FromJS((array) => {
return RL_bb4d6e713cd7ffbd47871f2337312efa.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_284d6b812acb53aa55a28cbe2a22b4ca.ToStructure);
}
) : null;
AggregateRecord<RL_bb4d6e713cd7ffbd47871f2337312efa> _ScreenDataSetGetUserApplicationRoleTempsByAssignedBy = (variables.ScreenDataSetGetUserApplicationRoleTempsByAssignedBy != null) ? variables.ScreenDataSetGetUserApplicationRoleTempsByAssignedBy.FromJS((array) => {
return RL_bb4d6e713cd7ffbd47871f2337312efa.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_284d6b812acb53aa55a28cbe2a22b4ca.ToStructure);
}
) : null;
ConectaProveedores_a_Common_Wb_TempRoleAssignments_ScreenModel screenModel = new ConectaProveedores_a_Common_Wb_TempRoleAssignments_ScreenModel(varLcl_StartIndex, varLcl_MaxRecords, varLcl_ShowAssignTempRolePopup, varLcl_ShowConfirmPopup, varLcl_UserApplicationRoleTemp, varLcl_StartIndexAssigned, varLcl_MaxRecordsAssigned, _ScreenDataSetGetUserApplicationRoleTempsByUserId, _ScreenDataSetGetUserApplicationRoleTempsByAssignedBy, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
