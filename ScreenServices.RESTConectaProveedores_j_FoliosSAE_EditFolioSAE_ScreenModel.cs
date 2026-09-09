using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_EditFolioSAE_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetFolioById")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_d80dcf5f9effb79b8ba59dd1971d484d> ScreenDataSetGetFolioById;
[JsonProperty("GetFolioItemsByFolioId")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_95110bc97f34f4c1561c8cbf2b5015b2> ScreenDataSetGetFolioItemsByFolioId;
[JsonProperty("FolioId")]
public long? inParamFolioId;
[JsonProperty("l_Step")]
public int? varLcl_Step;
[JsonProperty("l_OrderIdSelected")]
public long? varLcl_OrderIdSelected;
[JsonProperty("IsSelected")]
public bool? varLcIsSelected;
[JsonProperty("LocalSelectedLines")]
public RestList<ssConectaProveedores.RestRecords.RESTST_aa3e6001f162e602247a2e2cc13e2cf8Structure> varLcLocalSelectedLines;
[JsonProperty("l_IsSelectAll")]
public bool? varLcl_IsSelectAll;
[JsonProperty("l_IsShowSelectAll")]
public bool? varLcl_IsShowSelectAll;
[JsonProperty("l_OrderIdNumberSelected")]
public string varLcl_OrderIdNumberSelected;
[JsonProperty("ShowPopup")]
public bool? varLcShowPopup;
[JsonProperty("GetOrderMainItems")]
public RESTConectaProveedores_j_FoliosSAE_EditFolioSAE_DataActionGetOrderMainItems_Outputs varLcGetOrderMainItems;
[JsonProperty("GetSettings")]
public RESTConectaProveedores_j_FoliosSAE_EditFolioSAE_DataActionGetSettings_Outputs varLcGetSettings;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_j_FoliosSAE_EditFolioSAE_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_j_FoliosSAE_EditFolioSAE_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_j_FoliosSAE_EditFolioSAE_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_j_FoliosSAE_EditFolioSAE_ScreenModel ToModel() {long inParamFolioId = variables.inParamFolioId == null ? 0L : variables.inParamFolioId.Value;
int varLcl_Step = variables.varLcl_Step == null ? 2 : variables.varLcl_Step.Value;
long varLcl_OrderIdSelected = variables.varLcl_OrderIdSelected == null ? 0L : variables.varLcl_OrderIdSelected.Value;
bool varLcIsSelected = variables.varLcIsSelected == null ? false : variables.varLcIsSelected.Value;
RL_123aa03224ec08dab8cbe26021987012 varLcLocalSelectedLines = RL_123aa03224ec08dab8cbe26021987012.FromRestList(variables.varLcLocalSelectedLines, ssConectaProveedores.RestRecords.RESTST_aa3e6001f162e602247a2e2cc13e2cf8Structure.ToStructure);
bool varLcl_IsSelectAll = variables.varLcl_IsSelectAll == null ? false : variables.varLcl_IsSelectAll.Value;
bool varLcl_IsShowSelectAll = variables.varLcl_IsShowSelectAll == null ? false : variables.varLcl_IsShowSelectAll.Value;
string varLcl_OrderIdNumberSelected = variables.varLcl_OrderIdNumberSelected == null ? "" : variables.varLcl_OrderIdNumberSelected;
bool varLcShowPopup = variables.varLcShowPopup == null ? false : variables.varLcShowPopup.Value;
AggregateRecord<RL_d93cbaf98e8c7bf91c01ba8ed183bc42> _ScreenDataSetGetFolioById = (variables.ScreenDataSetGetFolioById != null) ? variables.ScreenDataSetGetFolioById.FromJS((array) => {
return RL_d93cbaf98e8c7bf91c01ba8ed183bc42.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_d80dcf5f9effb79b8ba59dd1971d484d.ToStructure);
}
) : null;
AggregateRecord<RL_a968cf9f63475dc9358672149b11245a> _ScreenDataSetGetFolioItemsByFolioId = (variables.ScreenDataSetGetFolioItemsByFolioId != null) ? variables.ScreenDataSetGetFolioItemsByFolioId.FromJS((array) => {
return RL_a968cf9f63475dc9358672149b11245a.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_95110bc97f34f4c1561c8cbf2b5015b2.ToStructure);
}
) : null;
ConectaProveedores_j_FoliosSAE_EditFolioSAE_DataActionGetOrderMainItems_Model _varLcGetOrderMainItems = (variables.varLcGetOrderMainItems != null) ? RESTConectaProveedores_j_FoliosSAE_EditFolioSAE_DataActionGetOrderMainItems_Outputs.ToModel(variables.varLcGetOrderMainItems) : null;
ConectaProveedores_j_FoliosSAE_EditFolioSAE_DataActionGetSettings_Model _varLcGetSettings = (variables.varLcGetSettings != null) ? RESTConectaProveedores_j_FoliosSAE_EditFolioSAE_DataActionGetSettings_Outputs.ToModel(variables.varLcGetSettings) : null;
ConectaProveedores_j_FoliosSAE_EditFolioSAE_ScreenModel screenModel = new ConectaProveedores_j_FoliosSAE_EditFolioSAE_ScreenModel(inParamFolioId, varLcl_Step, varLcl_OrderIdSelected, varLcIsSelected, varLcLocalSelectedLines, varLcl_IsSelectAll, varLcl_IsShowSelectAll, varLcl_OrderIdNumberSelected, varLcShowPopup, _ScreenDataSetGetFolioById, _ScreenDataSetGetFolioItemsByFolioId, _varLcGetOrderMainItems, _varLcGetSettings, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
