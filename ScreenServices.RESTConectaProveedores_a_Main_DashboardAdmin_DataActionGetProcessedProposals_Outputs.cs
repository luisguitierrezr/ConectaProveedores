using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_a_Main_DashboardAdmin_DataActionGetProcessedProposals_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("ProcessedProposals")]
public RestList<ssConectaProveedores.RestRecords.RESTST_bfed96b4bd29e9b06f0b06e901b1508bStructure> outParamProcessedProposals;
[JsonProperty("o_TotalCount")]
public int? outParamo_TotalCount;


    public static RESTConectaProveedores_a_Main_DashboardAdmin_DataActionGetProcessedProposals_Outputs FromOutputs(IBehaviorsConfiguration conf, RL_496abaeba4975b81a1a9b391230e8099 outParamProcessedProposals, int outParamo_TotalCount) {RESTConectaProveedores_a_Main_DashboardAdmin_DataActionGetProcessedProposals_Outputs result = new RESTConectaProveedores_a_Main_DashboardAdmin_DataActionGetProcessedProposals_Outputs();
// Write the needed fields of the list outParamProcessedProposals to the result.outParamProcessedProposals
ssConectaProveedores.RestRecords.RESTST_bfed96b4bd29e9b06f0b06e901b1508bStructure tmpoutParamProcessedProposalsElement;
if(outParamProcessedProposals.Empty) {
// Write the needed fields of the record outParamProcessedProposals.CurrentRec to the tmpoutParamProcessedProposalsElement
tmpoutParamProcessedProposalsElement = new ssConectaProveedores.RestRecords.RESTST_bfed96b4bd29e9b06f0b06e901b1508bStructure();
tmpoutParamProcessedProposalsElement.AttrStatusLabel = outParamProcessedProposals.CurrentRec.ssStatusLabel;
tmpoutParamProcessedProposalsElement.AttrCount = (int?) outParamProcessedProposals.CurrentRec.ssCount;
result.outParamProcessedProposals = new RestList<ssConectaProveedores.RestRecords.RESTST_bfed96b4bd29e9b06f0b06e901b1508bStructure>(new ssConectaProveedores.RestRecords.RESTST_bfed96b4bd29e9b06f0b06e901b1508bStructure[] {}, tmpoutParamProcessedProposalsElement);
} else {
List<ssConectaProveedores.RestRecords.RESTST_bfed96b4bd29e9b06f0b06e901b1508bStructure>
 tmpoutParamProcessedProposals1List = new List<ssConectaProveedores.RestRecords.RESTST_bfed96b4bd29e9b06f0b06e901b1508bStructure>
();
try {outParamProcessedProposals.StartIteration();
while (!(outParamProcessedProposals.Eof)) {
// Write the needed fields of the record outParamProcessedProposals.CurrentRec to the tmpoutParamProcessedProposalsElement
tmpoutParamProcessedProposalsElement = new ssConectaProveedores.RestRecords.RESTST_bfed96b4bd29e9b06f0b06e901b1508bStructure();
tmpoutParamProcessedProposalsElement.AttrStatusLabel = outParamProcessedProposals.CurrentRec.ssStatusLabel;
tmpoutParamProcessedProposalsElement.AttrCount = (int?) outParamProcessedProposals.CurrentRec.ssCount;
tmpoutParamProcessedProposals1List.Add(tmpoutParamProcessedProposalsElement);
outParamProcessedProposals.Advance();
}

} finally {
outParamProcessedProposals.EndIteration();
}

result.outParamProcessedProposals = new RestList<ssConectaProveedores.RestRecords.RESTST_bfed96b4bd29e9b06f0b06e901b1508bStructure>(tmpoutParamProcessedProposals1List.ToArray(), default(ssConectaProveedores.RestRecords.RESTST_bfed96b4bd29e9b06f0b06e901b1508bStructure));
}

result.outParamo_TotalCount = (int?) outParamo_TotalCount;
return result;
}


    public static ConectaProveedores_a_Main_DashboardAdmin_DataActionGetProcessedProposals_Model ToModel(RESTConectaProveedores_a_Main_DashboardAdmin_DataActionGetProcessedProposals_Outputs variables) {ConectaProveedores_a_Main_DashboardAdmin_DataActionGetProcessedProposals_Model result = new ConectaProveedores_a_Main_DashboardAdmin_DataActionGetProcessedProposals_Model();
result.outParamProcessedProposals = variables == null ? new RL_496abaeba4975b81a1a9b391230e8099() : RL_496abaeba4975b81a1a9b391230e8099.FromRestList(variables.outParamProcessedProposals, ssConectaProveedores.RestRecords.RESTST_bfed96b4bd29e9b06f0b06e901b1508bStructure.ToStructure);
result.outParamo_TotalCount = variables == null || variables.outParamo_TotalCount == null ? 0 : variables.outParamo_TotalCount.Value;
return result;
}


    public static RESTConectaProveedores_a_Main_DashboardAdmin_DataActionGetProcessedProposals_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_a_Main_DashboardAdmin_DataActionGetProcessedProposals_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_a_Main_DashboardAdmin_DataActionGetProcessedProposals_Outputs result = new RESTConectaProveedores_a_Main_DashboardAdmin_DataActionGetProcessedProposals_Outputs();
result.outParamProcessedProposals = screenModel.outParamProcessedProposals.ToRestList<ssConectaProveedores.RestRecords.RESTST_bfed96b4bd29e9b06f0b06e901b1508bStructure>(ssConectaProveedores.RestRecords.RESTST_bfed96b4bd29e9b06f0b06e901b1508bStructure.FromStructureDelegate(conf));
result.outParamo_TotalCount = (int?) screenModel.outParamo_TotalCount;
return result;
}

}
