using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_y_Utils_Wb_FolioEntra_Historic_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetOrderMainById")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_1583d548420c231ffb93458312800446> ScreenDataSetGetOrderMainById;
[JsonProperty("GetOrderMainApprovalLevels")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_12d88e24134057c9d8b3dfc84a66166f> ScreenDataSetGetOrderMainApprovalLevels;
[JsonProperty("i_OrderMainId")]
public long? inParami_OrderMainId;
[JsonProperty("i_RefreshWB")]
public String inParami_RefreshWB;
[JsonProperty("List")]
public RestList<ssConectaProveedores.RestRecords.RESTST_34625f5643caa3d12448dcec7dd4c7d3Structure> varLcList;
[JsonProperty("GetEntraUserManagerList")]
public RESTConectaProveedores_y_Utils_Wb_FolioEntra_Historic_DataActionGetEntraUserManagerList_Outputs varLcGetEntraUserManagerList;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_y_Utils_Wb_FolioEntra_Historic_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_y_Utils_Wb_FolioEntra_Historic_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_y_Utils_Wb_FolioEntra_Historic_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_y_Utils_Wb_FolioEntra_Historic_ScreenModel ToModel() {long inParami_OrderMainId = variables.inParami_OrderMainId == null ? 0L : variables.inParami_OrderMainId.Value;
DateTime inParami_RefreshWB = variables.inParami_RefreshWB == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(variables.inParami_RefreshWB, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
RL_4af3045b114dbc57d1481fed5aceb93a varLcList = RL_4af3045b114dbc57d1481fed5aceb93a.FromRestList(variables.varLcList, ssConectaProveedores.RestRecords.RESTST_34625f5643caa3d12448dcec7dd4c7d3Structure.ToStructure);
AggregateRecord<RL_339e5fbd74448809f3620bf1c8c54b9a> _ScreenDataSetGetOrderMainById = (variables.ScreenDataSetGetOrderMainById != null) ? variables.ScreenDataSetGetOrderMainById.FromJS((array) => {
return RL_339e5fbd74448809f3620bf1c8c54b9a.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_1583d548420c231ffb93458312800446.ToStructure);
}
) : null;
AggregateRecord<RL_e7b917e1824eb68e8cf92fc307d1415d> _ScreenDataSetGetOrderMainApprovalLevels = (variables.ScreenDataSetGetOrderMainApprovalLevels != null) ? variables.ScreenDataSetGetOrderMainApprovalLevels.FromJS((array) => {
return RL_e7b917e1824eb68e8cf92fc307d1415d.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_12d88e24134057c9d8b3dfc84a66166f.ToStructure);
}
) : null;
ConectaProveedores_y_Utils_Wb_FolioEntra_Historic_DataActionGetEntraUserManagerList_Model _varLcGetEntraUserManagerList = (variables.varLcGetEntraUserManagerList != null) ? RESTConectaProveedores_y_Utils_Wb_FolioEntra_Historic_DataActionGetEntraUserManagerList_Outputs.ToModel(variables.varLcGetEntraUserManagerList) : null;
ConectaProveedores_y_Utils_Wb_FolioEntra_Historic_ScreenModel screenModel = new ConectaProveedores_y_Utils_Wb_FolioEntra_Historic_ScreenModel(inParami_OrderMainId, inParami_RefreshWB, varLcList, _ScreenDataSetGetOrderMainById, _ScreenDataSetGetOrderMainApprovalLevels, _varLcGetEntraUserManagerList, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
