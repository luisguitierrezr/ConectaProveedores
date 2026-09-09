using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_a_Reassignments_Reassignments_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetReassignmentsByCreatedBy")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_cf466c446053e827622ddde1ad0222be> ScreenDataSetGetReassignmentsByCreatedBy;
[JsonProperty("l_StartIndex")]
public int? varLcl_StartIndex;
[JsonProperty("NotifContent")]
public ssConectaProveedores.RestRecords.RESTST_6fc999fa8f6e0055c73f2f167c4bad19Structure varLcNotifContent;
[JsonProperty("l_IsSidebarOpen")]
public bool? varLcl_IsSidebarOpen;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_a_Reassignments_Reassignments_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_a_Reassignments_Reassignments_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_a_Reassignments_Reassignments_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_a_Reassignments_Reassignments_ScreenModel ToModel() {int varLcl_StartIndex = variables.varLcl_StartIndex == null ? 0 : variables.varLcl_StartIndex.Value;
ST_6fc999fa8f6e0055c73f2f167c4bad19Structure varLcNotifContent = ssConectaProveedores.RestRecords.RESTST_6fc999fa8f6e0055c73f2f167c4bad19Structure.ToStructure(variables.varLcNotifContent);
bool varLcl_IsSidebarOpen = variables.varLcl_IsSidebarOpen == null ? false : variables.varLcl_IsSidebarOpen.Value;
AggregateRecord<RL_9b70977d6dab04293e9e952de2a92b65> _ScreenDataSetGetReassignmentsByCreatedBy = (variables.ScreenDataSetGetReassignmentsByCreatedBy != null) ? variables.ScreenDataSetGetReassignmentsByCreatedBy.FromJS((array) => {
return RL_9b70977d6dab04293e9e952de2a92b65.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_cf466c446053e827622ddde1ad0222be.ToStructure);
}
) : null;
ConectaProveedores_a_Reassignments_Reassignments_ScreenModel screenModel = new ConectaProveedores_a_Reassignments_Reassignments_ScreenModel(varLcl_StartIndex, varLcNotifContent, varLcl_IsSidebarOpen, _ScreenDataSetGetReassignmentsByCreatedBy, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
