using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_h_OrderDistributionConfig_OrderDistributionConfigDetails_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetRegions")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_deb85dc36640fa928dae5df2493065d0> ScreenDataSetGetRegions;
[JsonProperty("GetOrderDistributionConfigById")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_9fc59bda41db740ae87f91f135d24811> ScreenDataSetGetOrderDistributionConfigById;
[JsonProperty("GetTelcelDirections")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_f7c59318074340c0e230babd5ea62fb5> ScreenDataSetGetTelcelDirections;
[JsonProperty("ConfigId")]
public long? inParamConfigId;
[JsonProperty("ShowPopup")]
public bool? varLcShowPopup;
[JsonProperty("OriginalJSON")]
public string varLcOriginalJSON;
[JsonProperty("l_RefeshSideBar")]
public String varLcl_RefeshSideBar;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_h_OrderDistributionConfig_OrderDistributionConfigDetails_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_h_OrderDistributionConfig_OrderDistributionConfigDetails_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_h_OrderDistributionConfig_OrderDistributionConfigDetails_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_h_OrderDistributionConfig_OrderDistributionConfigDetails_ScreenModel ToModel() {long inParamConfigId = variables.inParamConfigId == null ? 0L : variables.inParamConfigId.Value;
bool varLcShowPopup = variables.varLcShowPopup == null ? false : variables.varLcShowPopup.Value;
string varLcOriginalJSON = variables.varLcOriginalJSON == null ? "" : variables.varLcOriginalJSON;
DateTime varLcl_RefeshSideBar = variables.varLcl_RefeshSideBar == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(variables.varLcl_RefeshSideBar, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
AggregateRecord<RL_5d3a02aa993c7474297e33d992f39ad0> _ScreenDataSetGetRegions = (variables.ScreenDataSetGetRegions != null) ? variables.ScreenDataSetGetRegions.FromJS((array) => {
return RL_5d3a02aa993c7474297e33d992f39ad0.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_deb85dc36640fa928dae5df2493065d0.ToStructure);
}
) : null;
AggregateRecord<RL_44cb753cf22fd0b01aa78a5ab2f30079> _ScreenDataSetGetOrderDistributionConfigById = (variables.ScreenDataSetGetOrderDistributionConfigById != null) ? variables.ScreenDataSetGetOrderDistributionConfigById.FromJS((array) => {
return RL_44cb753cf22fd0b01aa78a5ab2f30079.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_9fc59bda41db740ae87f91f135d24811.ToStructure);
}
) : null;
AggregateRecord<RL_9895159eebcdcdaed80fbd832f52d838> _ScreenDataSetGetTelcelDirections = (variables.ScreenDataSetGetTelcelDirections != null) ? variables.ScreenDataSetGetTelcelDirections.FromJS((array) => {
return RL_9895159eebcdcdaed80fbd832f52d838.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_f7c59318074340c0e230babd5ea62fb5.ToStructure);
}
) : null;
ConectaProveedores_h_OrderDistributionConfig_OrderDistributionConfigDetails_ScreenModel screenModel = new ConectaProveedores_h_OrderDistributionConfig_OrderDistributionConfigDetails_ScreenModel(inParamConfigId, varLcShowPopup, varLcOriginalJSON, varLcl_RefeshSideBar, _ScreenDataSetGetRegions, _ScreenDataSetGetOrderDistributionConfigById, _ScreenDataSetGetTelcelDirections, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
