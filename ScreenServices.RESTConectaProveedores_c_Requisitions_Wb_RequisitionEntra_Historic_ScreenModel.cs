using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_c_Requisitions_Wb_RequisitionEntra_Historic_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetRequisitionsApprovalLevels")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_8b89674084a8b334109c261c1cd156c4> ScreenDataSetGetRequisitionsApprovalLevels;
[JsonProperty("GetRequisitionById")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_8ada9c8e65e1e09d1e1af032494a5fa8> ScreenDataSetGetRequisitionById;
[JsonProperty("i_RequisitionId")]
public long? inParami_RequisitionId;
[JsonProperty("i_RefreshWB")]
public String inParami_RefreshWB;
[JsonProperty("List")]
public RestList<ssConectaProveedores.RestRecords.RESTST_34625f5643caa3d12448dcec7dd4c7d3Structure> varLcList;
[JsonProperty("GetEntraUserManagerList")]
public RESTConectaProveedores_c_Requisitions_Wb_RequisitionEntra_Historic_DataActionGetEntraUserManagerList_Outputs varLcGetEntraUserManagerList;
[JsonProperty("GetSpecialApprovalLevels")]
public RESTConectaProveedores_c_Requisitions_Wb_RequisitionEntra_Historic_DataActionGetSpecialApprovalLevels_Outputs varLcGetSpecialApprovalLevels;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_c_Requisitions_Wb_RequisitionEntra_Historic_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_c_Requisitions_Wb_RequisitionEntra_Historic_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_c_Requisitions_Wb_RequisitionEntra_Historic_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_c_Requisitions_Wb_RequisitionEntra_Historic_ScreenModel ToModel() {long inParami_RequisitionId = variables.inParami_RequisitionId == null ? 0L : variables.inParami_RequisitionId.Value;
DateTime inParami_RefreshWB = variables.inParami_RefreshWB == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(variables.inParami_RefreshWB, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
RL_4af3045b114dbc57d1481fed5aceb93a varLcList = RL_4af3045b114dbc57d1481fed5aceb93a.FromRestList(variables.varLcList, ssConectaProveedores.RestRecords.RESTST_34625f5643caa3d12448dcec7dd4c7d3Structure.ToStructure);
AggregateRecord<RL_7c4c6843d8ddca100085fd31262966c6> _ScreenDataSetGetRequisitionsApprovalLevels = (variables.ScreenDataSetGetRequisitionsApprovalLevels != null) ? variables.ScreenDataSetGetRequisitionsApprovalLevels.FromJS((array) => {
return RL_7c4c6843d8ddca100085fd31262966c6.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_8b89674084a8b334109c261c1cd156c4.ToStructure);
}
) : null;
AggregateRecord<RL_72dedb526963c58e79ee56edd8352664> _ScreenDataSetGetRequisitionById = (variables.ScreenDataSetGetRequisitionById != null) ? variables.ScreenDataSetGetRequisitionById.FromJS((array) => {
return RL_72dedb526963c58e79ee56edd8352664.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_8ada9c8e65e1e09d1e1af032494a5fa8.ToStructure);
}
) : null;
ConectaProveedores_c_Requisitions_Wb_RequisitionEntra_Historic_DataActionGetEntraUserManagerList_Model _varLcGetEntraUserManagerList = (variables.varLcGetEntraUserManagerList != null) ? RESTConectaProveedores_c_Requisitions_Wb_RequisitionEntra_Historic_DataActionGetEntraUserManagerList_Outputs.ToModel(variables.varLcGetEntraUserManagerList) : null;
ConectaProveedores_c_Requisitions_Wb_RequisitionEntra_Historic_DataActionGetSpecialApprovalLevels_Model _varLcGetSpecialApprovalLevels = (variables.varLcGetSpecialApprovalLevels != null) ? RESTConectaProveedores_c_Requisitions_Wb_RequisitionEntra_Historic_DataActionGetSpecialApprovalLevels_Outputs.ToModel(variables.varLcGetSpecialApprovalLevels) : null;
ConectaProveedores_c_Requisitions_Wb_RequisitionEntra_Historic_ScreenModel screenModel = new ConectaProveedores_c_Requisitions_Wb_RequisitionEntra_Historic_ScreenModel(inParami_RequisitionId, inParami_RefreshWB, varLcList, _ScreenDataSetGetRequisitionsApprovalLevels, _ScreenDataSetGetRequisitionById, _varLcGetEntraUserManagerList, _varLcGetSpecialApprovalLevels, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
