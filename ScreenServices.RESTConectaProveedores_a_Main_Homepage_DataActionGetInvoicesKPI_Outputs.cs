using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_a_Main_Homepage_DataActionGetInvoicesKPI_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("o_InvoiceCounts")]
public RestList<ssConectaProveedores.RestRecords.RESTST_34313c5cf94d7ce3c5404858c22fafd9Structure> outParamo_InvoiceCounts;


    public static RESTConectaProveedores_a_Main_Homepage_DataActionGetInvoicesKPI_Outputs FromOutputs(IBehaviorsConfiguration conf, RL_7d9c239ab2336eba85802eb00151e260 outParamo_InvoiceCounts) {RESTConectaProveedores_a_Main_Homepage_DataActionGetInvoicesKPI_Outputs result = new RESTConectaProveedores_a_Main_Homepage_DataActionGetInvoicesKPI_Outputs();
// Write the needed fields of the list outParamo_InvoiceCounts to the result.outParamo_InvoiceCounts
ssConectaProveedores.RestRecords.RESTST_34313c5cf94d7ce3c5404858c22fafd9Structure tmpoutParamo_InvoiceCountsElement;
if(outParamo_InvoiceCounts.Empty) {
// Write the needed fields of the record outParamo_InvoiceCounts.CurrentRec to the tmpoutParamo_InvoiceCountsElement
tmpoutParamo_InvoiceCountsElement = new ssConectaProveedores.RestRecords.RESTST_34313c5cf94d7ce3c5404858c22fafd9Structure();
tmpoutParamo_InvoiceCountsElement.AttrValue = (decimal?) outParamo_InvoiceCounts.CurrentRec.ssValue;
tmpoutParamo_InvoiceCountsElement.AttrLabel = outParamo_InvoiceCounts.CurrentRec.ssLabel;
tmpoutParamo_InvoiceCountsElement.AttrSeriesName = outParamo_InvoiceCounts.CurrentRec.ssSeriesName;
tmpoutParamo_InvoiceCountsElement.AttrColor = outParamo_InvoiceCounts.CurrentRec.ssColor;
tmpoutParamo_InvoiceCountsElement.AttrTooltip = outParamo_InvoiceCounts.CurrentRec.ssTooltip;
result.outParamo_InvoiceCounts = new RestList<ssConectaProveedores.RestRecords.RESTST_34313c5cf94d7ce3c5404858c22fafd9Structure>(new ssConectaProveedores.RestRecords.RESTST_34313c5cf94d7ce3c5404858c22fafd9Structure[] {}, tmpoutParamo_InvoiceCountsElement);
} else {
List<ssConectaProveedores.RestRecords.RESTST_34313c5cf94d7ce3c5404858c22fafd9Structure>
 tmpoutParamo_InvoiceCounts1List = new List<ssConectaProveedores.RestRecords.RESTST_34313c5cf94d7ce3c5404858c22fafd9Structure>
();
try {outParamo_InvoiceCounts.StartIteration();
while (!(outParamo_InvoiceCounts.Eof)) {
// Write the needed fields of the record outParamo_InvoiceCounts.CurrentRec to the tmpoutParamo_InvoiceCountsElement
tmpoutParamo_InvoiceCountsElement = new ssConectaProveedores.RestRecords.RESTST_34313c5cf94d7ce3c5404858c22fafd9Structure();
tmpoutParamo_InvoiceCountsElement.AttrValue = (decimal?) outParamo_InvoiceCounts.CurrentRec.ssValue;
tmpoutParamo_InvoiceCountsElement.AttrLabel = outParamo_InvoiceCounts.CurrentRec.ssLabel;
tmpoutParamo_InvoiceCountsElement.AttrSeriesName = outParamo_InvoiceCounts.CurrentRec.ssSeriesName;
tmpoutParamo_InvoiceCountsElement.AttrColor = outParamo_InvoiceCounts.CurrentRec.ssColor;
tmpoutParamo_InvoiceCountsElement.AttrTooltip = outParamo_InvoiceCounts.CurrentRec.ssTooltip;
tmpoutParamo_InvoiceCounts1List.Add(tmpoutParamo_InvoiceCountsElement);
outParamo_InvoiceCounts.Advance();
}

} finally {
outParamo_InvoiceCounts.EndIteration();
}

result.outParamo_InvoiceCounts = new RestList<ssConectaProveedores.RestRecords.RESTST_34313c5cf94d7ce3c5404858c22fafd9Structure>(tmpoutParamo_InvoiceCounts1List.ToArray(), default(ssConectaProveedores.RestRecords.RESTST_34313c5cf94d7ce3c5404858c22fafd9Structure));
}

return result;
}


    public static ConectaProveedores_a_Main_Homepage_DataActionGetInvoicesKPI_Model ToModel(RESTConectaProveedores_a_Main_Homepage_DataActionGetInvoicesKPI_Outputs variables) {ConectaProveedores_a_Main_Homepage_DataActionGetInvoicesKPI_Model result = new ConectaProveedores_a_Main_Homepage_DataActionGetInvoicesKPI_Model();
result.outParamo_InvoiceCounts = variables == null ? new RL_7d9c239ab2336eba85802eb00151e260() : RL_7d9c239ab2336eba85802eb00151e260.FromRestList(variables.outParamo_InvoiceCounts, ssConectaProveedores.RestRecords.RESTST_34313c5cf94d7ce3c5404858c22fafd9Structure.ToStructure);
return result;
}


    public static RESTConectaProveedores_a_Main_Homepage_DataActionGetInvoicesKPI_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_a_Main_Homepage_DataActionGetInvoicesKPI_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_a_Main_Homepage_DataActionGetInvoicesKPI_Outputs result = new RESTConectaProveedores_a_Main_Homepage_DataActionGetInvoicesKPI_Outputs();
result.outParamo_InvoiceCounts = screenModel.outParamo_InvoiceCounts.ToRestList<ssConectaProveedores.RestRecords.RESTST_34313c5cf94d7ce3c5404858c22fafd9Structure>(ssConectaProveedores.RestRecords.RESTST_34313c5cf94d7ce3c5404858c22fafd9Structure.FromStructureDelegate(conf));
return result;
}

}
