using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_h_OrderDistributionConfig_Wb_OrderDistributionConfig_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetOrderDistributionConfig")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_c1e2ad1f67f216fd0b4fb3f61e1c54ad> ScreenDataSetGetOrderDistributionConfig;
[JsonProperty("GetRegions")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_deb85dc36640fa928dae5df2493065d0> ScreenDataSetGetRegions;
[JsonProperty("i_OrderId")]
public long? inParami_OrderId;
[JsonProperty("i_InPopup")]
public bool? inParami_InPopup;
[JsonProperty("l_TabNumber")]
public int? varLcl_TabNumber;
[JsonProperty("l_StartIndex")]
public int? varLcl_StartIndex;
[JsonProperty("l_TableSort")]
public string varLcl_TableSort;
[JsonProperty("l_ShowAudit")]
public bool? varLcl_ShowAudit;
[JsonProperty("l_AuditInitialDateTime")]
public String varLcl_AuditInitialDateTime;
[JsonProperty("l_AuditFinalDateTime")]
public String varLcl_AuditFinalDateTime;
[JsonProperty("l_IsOrderRejected")]
public bool? varLcl_IsOrderRejected;
[JsonProperty("IsOpenPopupConfirmation")]
public bool? varLcIsOpenPopupConfirmation;
[JsonProperty("RequestDistributionConfigId_ToSave")]
public long? varLcRequestDistributionConfigId_ToSave;
[JsonProperty("OrderMainId_ToSave")]
public long? varLcOrderMainId_ToSave;
[JsonProperty("GetOrderMainDataOnInput")]
public RESTConectaProveedores_h_OrderDistributionConfig_Wb_OrderDistributionConfig_DataActionGetOrderMainDataOnInput_Outputs varLcGetOrderMainDataOnInput;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_h_OrderDistributionConfig_Wb_OrderDistributionConfig_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_h_OrderDistributionConfig_Wb_OrderDistributionConfig_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_h_OrderDistributionConfig_Wb_OrderDistributionConfig_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_h_OrderDistributionConfig_Wb_OrderDistributionConfig_ScreenModel ToModel() {long inParami_OrderId = variables.inParami_OrderId == null ? 0L : variables.inParami_OrderId.Value;
bool inParami_InPopup = variables.inParami_InPopup == null ? false : variables.inParami_InPopup.Value;
int varLcl_TabNumber = variables.varLcl_TabNumber == null ? 0 : variables.varLcl_TabNumber.Value;
int varLcl_StartIndex = variables.varLcl_StartIndex == null ? 0 : variables.varLcl_StartIndex.Value;
string varLcl_TableSort = variables.varLcl_TableSort == null ? "" : variables.varLcl_TableSort;
bool varLcl_ShowAudit = variables.varLcl_ShowAudit == null ? false : variables.varLcl_ShowAudit.Value;
DateTime varLcl_AuditInitialDateTime = variables.varLcl_AuditInitialDateTime == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(variables.varLcl_AuditInitialDateTime, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
DateTime varLcl_AuditFinalDateTime = variables.varLcl_AuditFinalDateTime == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(variables.varLcl_AuditFinalDateTime, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
bool varLcl_IsOrderRejected = variables.varLcl_IsOrderRejected == null ? false : variables.varLcl_IsOrderRejected.Value;
bool varLcIsOpenPopupConfirmation = variables.varLcIsOpenPopupConfirmation == null ? false : variables.varLcIsOpenPopupConfirmation.Value;
long varLcRequestDistributionConfigId_ToSave = variables.varLcRequestDistributionConfigId_ToSave == null ? 0L : variables.varLcRequestDistributionConfigId_ToSave.Value;
long varLcOrderMainId_ToSave = variables.varLcOrderMainId_ToSave == null ? 0L : variables.varLcOrderMainId_ToSave.Value;
AggregateRecord<RL_fad66e2f0a5803b0832cea3f3e9146e2> _ScreenDataSetGetOrderDistributionConfig = (variables.ScreenDataSetGetOrderDistributionConfig != null) ? variables.ScreenDataSetGetOrderDistributionConfig.FromJS((array) => {
return RL_fad66e2f0a5803b0832cea3f3e9146e2.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_c1e2ad1f67f216fd0b4fb3f61e1c54ad.ToStructure);
}
) : null;
AggregateRecord<RL_5d3a02aa993c7474297e33d992f39ad0> _ScreenDataSetGetRegions = (variables.ScreenDataSetGetRegions != null) ? variables.ScreenDataSetGetRegions.FromJS((array) => {
return RL_5d3a02aa993c7474297e33d992f39ad0.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_deb85dc36640fa928dae5df2493065d0.ToStructure);
}
) : null;
ConectaProveedores_h_OrderDistributionConfig_Wb_OrderDistributionConfig_DataActionGetOrderMainDataOnInput_Model _varLcGetOrderMainDataOnInput = (variables.varLcGetOrderMainDataOnInput != null) ? RESTConectaProveedores_h_OrderDistributionConfig_Wb_OrderDistributionConfig_DataActionGetOrderMainDataOnInput_Outputs.ToModel(variables.varLcGetOrderMainDataOnInput) : null;
ConectaProveedores_h_OrderDistributionConfig_Wb_OrderDistributionConfig_ScreenModel screenModel = new ConectaProveedores_h_OrderDistributionConfig_Wb_OrderDistributionConfig_ScreenModel(inParami_OrderId, inParami_InPopup, varLcl_TabNumber, varLcl_StartIndex, varLcl_TableSort, varLcl_ShowAudit, varLcl_AuditInitialDateTime, varLcl_AuditFinalDateTime, varLcl_IsOrderRejected, varLcIsOpenPopupConfirmation, varLcRequestDistributionConfigId_ToSave, varLcOrderMainId_ToSave, _ScreenDataSetGetOrderDistributionConfig, _ScreenDataSetGetRegions, _varLcGetOrderMainDataOnInput, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
