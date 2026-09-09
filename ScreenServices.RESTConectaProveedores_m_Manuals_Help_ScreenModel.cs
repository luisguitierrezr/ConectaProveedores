using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_m_Manuals_Help_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetManuals")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_5e1572d574f8fe1e39bbadd50daaa59c> ScreenDataSetGetManuals;
[JsonProperty("Keyword")]
public string varLcKeyword;
[JsonProperty("TableSort")]
public string varLcTableSort;
[JsonProperty("StartIndex")]
public int? varLcStartIndex;
[JsonProperty("MaxRecords")]
public int? varLcMaxRecords;
[JsonProperty("ShowPopup")]
public bool? varLcShowPopup;
[JsonProperty("l_ManualId")]
public long? varLcl_ManualId;
[JsonProperty("GetUserInfo")]
public RESTConectaProveedores_m_Manuals_Help_DataActionGetUserInfo_Outputs varLcGetUserInfo;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_m_Manuals_Help_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_m_Manuals_Help_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_m_Manuals_Help_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_m_Manuals_Help_ScreenModel ToModel() {string varLcKeyword = variables.varLcKeyword == null ? "" : variables.varLcKeyword;
string varLcTableSort = variables.varLcTableSort == null ? "" : variables.varLcTableSort;
int varLcStartIndex = variables.varLcStartIndex == null ? 0 : variables.varLcStartIndex.Value;
int varLcMaxRecords = variables.varLcMaxRecords == null ? 50 : variables.varLcMaxRecords.Value;
bool varLcShowPopup = variables.varLcShowPopup == null ? false : variables.varLcShowPopup.Value;
long varLcl_ManualId = variables.varLcl_ManualId == null ? 0L : variables.varLcl_ManualId.Value;
AggregateRecord<RL_c03a84418d2a4ae38f50fab5e2cc796f> _ScreenDataSetGetManuals = (variables.ScreenDataSetGetManuals != null) ? variables.ScreenDataSetGetManuals.FromJS((array) => {
return RL_c03a84418d2a4ae38f50fab5e2cc796f.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_5e1572d574f8fe1e39bbadd50daaa59c.ToStructure);
}
) : null;
ConectaProveedores_m_Manuals_Help_DataActionGetUserInfo_Model _varLcGetUserInfo = (variables.varLcGetUserInfo != null) ? RESTConectaProveedores_m_Manuals_Help_DataActionGetUserInfo_Outputs.ToModel(variables.varLcGetUserInfo) : null;
ConectaProveedores_m_Manuals_Help_ScreenModel screenModel = new ConectaProveedores_m_Manuals_Help_ScreenModel(varLcKeyword, varLcTableSort, varLcStartIndex, varLcMaxRecords, varLcShowPopup, varLcl_ManualId, _ScreenDataSetGetManuals, _varLcGetUserInfo, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
