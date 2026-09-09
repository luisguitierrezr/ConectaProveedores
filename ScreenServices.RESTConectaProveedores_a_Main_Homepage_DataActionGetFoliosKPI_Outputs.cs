using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_a_Main_Homepage_DataActionGetFoliosKPI_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("o_OrderCounts")]
public RestList<ssConectaProveedores.RestRecords.RESTST_34313c5cf94d7ce3c5404858c22fafd9Structure> outParamo_OrderCounts;


    public static RESTConectaProveedores_a_Main_Homepage_DataActionGetFoliosKPI_Outputs FromOutputs(IBehaviorsConfiguration conf, RL_7d9c239ab2336eba85802eb00151e260 outParamo_OrderCounts) {RESTConectaProveedores_a_Main_Homepage_DataActionGetFoliosKPI_Outputs result = new RESTConectaProveedores_a_Main_Homepage_DataActionGetFoliosKPI_Outputs();
// Write the needed fields of the list outParamo_OrderCounts to the result.outParamo_OrderCounts
ssConectaProveedores.RestRecords.RESTST_34313c5cf94d7ce3c5404858c22fafd9Structure tmpoutParamo_OrderCountsElement;
if(outParamo_OrderCounts.Empty) {
// Write the needed fields of the record outParamo_OrderCounts.CurrentRec to the tmpoutParamo_OrderCountsElement
tmpoutParamo_OrderCountsElement = new ssConectaProveedores.RestRecords.RESTST_34313c5cf94d7ce3c5404858c22fafd9Structure();
tmpoutParamo_OrderCountsElement.AttrValue = (decimal?) outParamo_OrderCounts.CurrentRec.ssValue;
tmpoutParamo_OrderCountsElement.AttrLabel = outParamo_OrderCounts.CurrentRec.ssLabel;
tmpoutParamo_OrderCountsElement.AttrSeriesName = outParamo_OrderCounts.CurrentRec.ssSeriesName;
tmpoutParamo_OrderCountsElement.AttrColor = outParamo_OrderCounts.CurrentRec.ssColor;
tmpoutParamo_OrderCountsElement.AttrTooltip = outParamo_OrderCounts.CurrentRec.ssTooltip;
result.outParamo_OrderCounts = new RestList<ssConectaProveedores.RestRecords.RESTST_34313c5cf94d7ce3c5404858c22fafd9Structure>(new ssConectaProveedores.RestRecords.RESTST_34313c5cf94d7ce3c5404858c22fafd9Structure[] {}, tmpoutParamo_OrderCountsElement);
} else {
List<ssConectaProveedores.RestRecords.RESTST_34313c5cf94d7ce3c5404858c22fafd9Structure>
 tmpoutParamo_OrderCounts1List = new List<ssConectaProveedores.RestRecords.RESTST_34313c5cf94d7ce3c5404858c22fafd9Structure>
();
try {outParamo_OrderCounts.StartIteration();
while (!(outParamo_OrderCounts.Eof)) {
// Write the needed fields of the record outParamo_OrderCounts.CurrentRec to the tmpoutParamo_OrderCountsElement
tmpoutParamo_OrderCountsElement = new ssConectaProveedores.RestRecords.RESTST_34313c5cf94d7ce3c5404858c22fafd9Structure();
tmpoutParamo_OrderCountsElement.AttrValue = (decimal?) outParamo_OrderCounts.CurrentRec.ssValue;
tmpoutParamo_OrderCountsElement.AttrLabel = outParamo_OrderCounts.CurrentRec.ssLabel;
tmpoutParamo_OrderCountsElement.AttrSeriesName = outParamo_OrderCounts.CurrentRec.ssSeriesName;
tmpoutParamo_OrderCountsElement.AttrColor = outParamo_OrderCounts.CurrentRec.ssColor;
tmpoutParamo_OrderCountsElement.AttrTooltip = outParamo_OrderCounts.CurrentRec.ssTooltip;
tmpoutParamo_OrderCounts1List.Add(tmpoutParamo_OrderCountsElement);
outParamo_OrderCounts.Advance();
}

} finally {
outParamo_OrderCounts.EndIteration();
}

result.outParamo_OrderCounts = new RestList<ssConectaProveedores.RestRecords.RESTST_34313c5cf94d7ce3c5404858c22fafd9Structure>(tmpoutParamo_OrderCounts1List.ToArray(), default(ssConectaProveedores.RestRecords.RESTST_34313c5cf94d7ce3c5404858c22fafd9Structure));
}

return result;
}


    public static ConectaProveedores_a_Main_Homepage_DataActionGetFoliosKPI_Model ToModel(RESTConectaProveedores_a_Main_Homepage_DataActionGetFoliosKPI_Outputs variables) {ConectaProveedores_a_Main_Homepage_DataActionGetFoliosKPI_Model result = new ConectaProveedores_a_Main_Homepage_DataActionGetFoliosKPI_Model();
result.outParamo_OrderCounts = variables == null ? new RL_7d9c239ab2336eba85802eb00151e260() : RL_7d9c239ab2336eba85802eb00151e260.FromRestList(variables.outParamo_OrderCounts, ssConectaProveedores.RestRecords.RESTST_34313c5cf94d7ce3c5404858c22fafd9Structure.ToStructure);
return result;
}


    public static RESTConectaProveedores_a_Main_Homepage_DataActionGetFoliosKPI_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_a_Main_Homepage_DataActionGetFoliosKPI_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_a_Main_Homepage_DataActionGetFoliosKPI_Outputs result = new RESTConectaProveedores_a_Main_Homepage_DataActionGetFoliosKPI_Outputs();
result.outParamo_OrderCounts = screenModel.outParamo_OrderCounts.ToRestList<ssConectaProveedores.RestRecords.RESTST_34313c5cf94d7ce3c5404858c22fafd9Structure>(ssConectaProveedores.RestRecords.RESTST_34313c5cf94d7ce3c5404858c22fafd9Structure.FromStructureDelegate(conf));
return result;
}

}
