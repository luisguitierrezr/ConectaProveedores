using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_a_Main_DashboardAdmin_DataActionGetActiveProposals_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("ActiveProposals")]
public RestList<ssConectaProveedores.RestRecords.RESTST_bfed96b4bd29e9b06f0b06e901b1508bStructure> outParamActiveProposals;
[JsonProperty("o_TotalCount")]
public int? outParamo_TotalCount;


    public static RESTConectaProveedores_a_Main_DashboardAdmin_DataActionGetActiveProposals_Outputs FromOutputs(IBehaviorsConfiguration conf, RL_496abaeba4975b81a1a9b391230e8099 outParamActiveProposals, int outParamo_TotalCount) {RESTConectaProveedores_a_Main_DashboardAdmin_DataActionGetActiveProposals_Outputs result = new RESTConectaProveedores_a_Main_DashboardAdmin_DataActionGetActiveProposals_Outputs();
// Write the needed fields of the list outParamActiveProposals to the result.outParamActiveProposals
ssConectaProveedores.RestRecords.RESTST_bfed96b4bd29e9b06f0b06e901b1508bStructure tmpoutParamActiveProposalsElement;
if(outParamActiveProposals.Empty) {
// Write the needed fields of the record outParamActiveProposals.CurrentRec to the tmpoutParamActiveProposalsElement
tmpoutParamActiveProposalsElement = new ssConectaProveedores.RestRecords.RESTST_bfed96b4bd29e9b06f0b06e901b1508bStructure();
tmpoutParamActiveProposalsElement.AttrStatusLabel = outParamActiveProposals.CurrentRec.ssStatusLabel;
tmpoutParamActiveProposalsElement.AttrCount = (int?) outParamActiveProposals.CurrentRec.ssCount;
result.outParamActiveProposals = new RestList<ssConectaProveedores.RestRecords.RESTST_bfed96b4bd29e9b06f0b06e901b1508bStructure>(new ssConectaProveedores.RestRecords.RESTST_bfed96b4bd29e9b06f0b06e901b1508bStructure[] {}, tmpoutParamActiveProposalsElement);
} else {
List<ssConectaProveedores.RestRecords.RESTST_bfed96b4bd29e9b06f0b06e901b1508bStructure>
 tmpoutParamActiveProposals1List = new List<ssConectaProveedores.RestRecords.RESTST_bfed96b4bd29e9b06f0b06e901b1508bStructure>
();
try {outParamActiveProposals.StartIteration();
while (!(outParamActiveProposals.Eof)) {
// Write the needed fields of the record outParamActiveProposals.CurrentRec to the tmpoutParamActiveProposalsElement
tmpoutParamActiveProposalsElement = new ssConectaProveedores.RestRecords.RESTST_bfed96b4bd29e9b06f0b06e901b1508bStructure();
tmpoutParamActiveProposalsElement.AttrStatusLabel = outParamActiveProposals.CurrentRec.ssStatusLabel;
tmpoutParamActiveProposalsElement.AttrCount = (int?) outParamActiveProposals.CurrentRec.ssCount;
tmpoutParamActiveProposals1List.Add(tmpoutParamActiveProposalsElement);
outParamActiveProposals.Advance();
}

} finally {
outParamActiveProposals.EndIteration();
}

result.outParamActiveProposals = new RestList<ssConectaProveedores.RestRecords.RESTST_bfed96b4bd29e9b06f0b06e901b1508bStructure>(tmpoutParamActiveProposals1List.ToArray(), default(ssConectaProveedores.RestRecords.RESTST_bfed96b4bd29e9b06f0b06e901b1508bStructure));
}

result.outParamo_TotalCount = (int?) outParamo_TotalCount;
return result;
}


    public static ConectaProveedores_a_Main_DashboardAdmin_DataActionGetActiveProposals_Model ToModel(RESTConectaProveedores_a_Main_DashboardAdmin_DataActionGetActiveProposals_Outputs variables) {ConectaProveedores_a_Main_DashboardAdmin_DataActionGetActiveProposals_Model result = new ConectaProveedores_a_Main_DashboardAdmin_DataActionGetActiveProposals_Model();
result.outParamActiveProposals = variables == null ? new RL_496abaeba4975b81a1a9b391230e8099() : RL_496abaeba4975b81a1a9b391230e8099.FromRestList(variables.outParamActiveProposals, ssConectaProveedores.RestRecords.RESTST_bfed96b4bd29e9b06f0b06e901b1508bStructure.ToStructure);
result.outParamo_TotalCount = variables == null || variables.outParamo_TotalCount == null ? 0 : variables.outParamo_TotalCount.Value;
return result;
}


    public static RESTConectaProveedores_a_Main_DashboardAdmin_DataActionGetActiveProposals_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_a_Main_DashboardAdmin_DataActionGetActiveProposals_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_a_Main_DashboardAdmin_DataActionGetActiveProposals_Outputs result = new RESTConectaProveedores_a_Main_DashboardAdmin_DataActionGetActiveProposals_Outputs();
result.outParamActiveProposals = screenModel.outParamActiveProposals.ToRestList<ssConectaProveedores.RestRecords.RESTST_bfed96b4bd29e9b06f0b06e901b1508bStructure>(ssConectaProveedores.RestRecords.RESTST_bfed96b4bd29e9b06f0b06e901b1508bStructure.FromStructureDelegate(conf));
result.outParamo_TotalCount = (int?) screenModel.outParamo_TotalCount;
return result;
}

}
