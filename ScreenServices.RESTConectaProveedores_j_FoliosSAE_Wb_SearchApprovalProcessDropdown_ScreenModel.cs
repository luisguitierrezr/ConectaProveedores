using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_Wb_SearchApprovalProcessDropdown_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetApprovalProcesss")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_8cfc2af1075444d3070aa6269dcfdf32> ScreenDataSetGetApprovalProcesss;
[JsonProperty("GetApprovalProcessById")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_f2bd78b86ae9bba0b46cc5d8814834af> ScreenDataSetGetApprovalProcessById;
[JsonProperty("i_IsDisable")]
public bool? inParami_IsDisable;
[JsonProperty("i_ApprovalProcessId")]
public long? inParami_ApprovalProcessId;
[JsonProperty("i_IsValid")]
public bool? inParami_IsValid;
[JsonProperty("i_IsMandatory")]
public bool? inParami_IsMandatory;
[JsonProperty("i_IsFilter")]
public bool? inParami_IsFilter;
[JsonProperty("i_ApprovalProcessTypeId")]
public int? inParami_ApprovalProcessTypeId;
[JsonProperty("l_ApprovalProcessSearchText")]
public string varLcl_ApprovalProcessSearchText;
[JsonProperty("l_ApprovalProcessMaxRecord")]
public int? varLcl_ApprovalProcessMaxRecord;
[JsonProperty("l_IsValid")]
public bool? varLcl_IsValid;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_j_FoliosSAE_Wb_SearchApprovalProcessDropdown_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_j_FoliosSAE_Wb_SearchApprovalProcessDropdown_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_j_FoliosSAE_Wb_SearchApprovalProcessDropdown_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_j_FoliosSAE_Wb_SearchApprovalProcessDropdown_ScreenModel ToModel() {bool inParami_IsDisable = variables.inParami_IsDisable == null ? false : variables.inParami_IsDisable.Value;
long inParami_ApprovalProcessId = variables.inParami_ApprovalProcessId == null ? 0L : variables.inParami_ApprovalProcessId.Value;
bool inParami_IsValid = variables.inParami_IsValid == null ? false : variables.inParami_IsValid.Value;
bool inParami_IsMandatory = variables.inParami_IsMandatory == null ? false : variables.inParami_IsMandatory.Value;
bool inParami_IsFilter = variables.inParami_IsFilter == null ? false : variables.inParami_IsFilter.Value;
int inParami_ApprovalProcessTypeId = variables.inParami_ApprovalProcessTypeId == null ? 0 : variables.inParami_ApprovalProcessTypeId.Value;
string varLcl_ApprovalProcessSearchText = variables.varLcl_ApprovalProcessSearchText == null ? "" : variables.varLcl_ApprovalProcessSearchText;
int varLcl_ApprovalProcessMaxRecord = variables.varLcl_ApprovalProcessMaxRecord == null ? 20 : variables.varLcl_ApprovalProcessMaxRecord.Value;
bool varLcl_IsValid = variables.varLcl_IsValid == null ? true : variables.varLcl_IsValid.Value;
AggregateRecord<RL_5c614a706e3e33b4caf55ba997e805be> _ScreenDataSetGetApprovalProcesss = (variables.ScreenDataSetGetApprovalProcesss != null) ? variables.ScreenDataSetGetApprovalProcesss.FromJS((array) => {
return RL_5c614a706e3e33b4caf55ba997e805be.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_8cfc2af1075444d3070aa6269dcfdf32.ToStructure);
}
) : null;
AggregateRecord<RL_5e0ca6ca9da3af4b1d8149758c39c2cf> _ScreenDataSetGetApprovalProcessById = (variables.ScreenDataSetGetApprovalProcessById != null) ? variables.ScreenDataSetGetApprovalProcessById.FromJS((array) => {
return RL_5e0ca6ca9da3af4b1d8149758c39c2cf.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_f2bd78b86ae9bba0b46cc5d8814834af.ToStructure);
}
) : null;
ConectaProveedores_j_FoliosSAE_Wb_SearchApprovalProcessDropdown_ScreenModel screenModel = new ConectaProveedores_j_FoliosSAE_Wb_SearchApprovalProcessDropdown_ScreenModel(inParami_IsDisable, inParami_ApprovalProcessId, inParami_IsValid, inParami_IsMandatory, inParami_IsFilter, inParami_ApprovalProcessTypeId, varLcl_ApprovalProcessSearchText, varLcl_ApprovalProcessMaxRecord, varLcl_IsValid, _ScreenDataSetGetApprovalProcesss, _ScreenDataSetGetApprovalProcessById, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
