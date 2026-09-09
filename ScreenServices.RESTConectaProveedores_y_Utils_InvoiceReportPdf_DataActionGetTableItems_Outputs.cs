using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_y_Utils_InvoiceReportPdf_DataActionGetTableItems_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("TableLine")]
public RestList<ssConectaProveedores.RestRecords.RESTST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure> outParamTableLine;


    public static RESTConectaProveedores_y_Utils_InvoiceReportPdf_DataActionGetTableItems_Outputs FromOutputs(IBehaviorsConfiguration conf, RL_f0441ae281d3bacc0d1d0acaed8c2549 outParamTableLine) {RESTConectaProveedores_y_Utils_InvoiceReportPdf_DataActionGetTableItems_Outputs result = new RESTConectaProveedores_y_Utils_InvoiceReportPdf_DataActionGetTableItems_Outputs();
// Write the needed fields of the list outParamTableLine to the result.outParamTableLine
ssConectaProveedores.RestRecords.RESTST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure tmpoutParamTableLineElement;
if(outParamTableLine.Empty) {
// Write the needed fields of the record outParamTableLine.CurrentRec to the tmpoutParamTableLineElement
tmpoutParamTableLineElement = new ssConectaProveedores.RestRecords.RESTST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure();
tmpoutParamTableLineElement.AttrPosition = (int?) outParamTableLine.CurrentRec.ssPosition;
tmpoutParamTableLineElement.AttrArticle = outParamTableLine.CurrentRec.ssArticle;
tmpoutParamTableLineElement.AttrDescription = outParamTableLine.CurrentRec.ssDescription;
tmpoutParamTableLineElement.AttrEntryNumber = (int?) outParamTableLine.CurrentRec.ssEntryNumber;
tmpoutParamTableLineElement.AttrEntryDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(outParamTableLine.CurrentRec.ssEntryDate);
tmpoutParamTableLineElement.AttrMaterialCode = outParamTableLine.CurrentRec.ssMaterialCode;
tmpoutParamTableLineElement.AttrQuantity = (int?) outParamTableLine.CurrentRec.ssQuantity;
tmpoutParamTableLineElement.AttrUnitPrice = outParamTableLine.CurrentRec.ssUnitPrice;
tmpoutParamTableLineElement.AttrTotalAmount = outParamTableLine.CurrentRec.ssTotalAmount;
tmpoutParamTableLineElement.AttrCurrency = outParamTableLine.CurrentRec.ssCurrency;
result.outParamTableLine = new RestList<ssConectaProveedores.RestRecords.RESTST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure>(new ssConectaProveedores.RestRecords.RESTST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure[] {}, tmpoutParamTableLineElement);
} else {
List<ssConectaProveedores.RestRecords.RESTST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure>
 tmpoutParamTableLine1List = new List<ssConectaProveedores.RestRecords.RESTST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure>
();
try {outParamTableLine.StartIteration();
while (!(outParamTableLine.Eof)) {
// Write the needed fields of the record outParamTableLine.CurrentRec to the tmpoutParamTableLineElement
tmpoutParamTableLineElement = new ssConectaProveedores.RestRecords.RESTST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure();
tmpoutParamTableLineElement.AttrPosition = (int?) outParamTableLine.CurrentRec.ssPosition;
tmpoutParamTableLineElement.AttrArticle = outParamTableLine.CurrentRec.ssArticle;
tmpoutParamTableLineElement.AttrDescription = outParamTableLine.CurrentRec.ssDescription;
tmpoutParamTableLineElement.AttrEntryNumber = (int?) outParamTableLine.CurrentRec.ssEntryNumber;
tmpoutParamTableLineElement.AttrEntryDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(outParamTableLine.CurrentRec.ssEntryDate);
tmpoutParamTableLineElement.AttrMaterialCode = outParamTableLine.CurrentRec.ssMaterialCode;
tmpoutParamTableLineElement.AttrQuantity = (int?) outParamTableLine.CurrentRec.ssQuantity;
tmpoutParamTableLineElement.AttrUnitPrice = outParamTableLine.CurrentRec.ssUnitPrice;
tmpoutParamTableLineElement.AttrTotalAmount = outParamTableLine.CurrentRec.ssTotalAmount;
tmpoutParamTableLineElement.AttrCurrency = outParamTableLine.CurrentRec.ssCurrency;
tmpoutParamTableLine1List.Add(tmpoutParamTableLineElement);
outParamTableLine.Advance();
}

} finally {
outParamTableLine.EndIteration();
}

result.outParamTableLine = new RestList<ssConectaProveedores.RestRecords.RESTST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure>(tmpoutParamTableLine1List.ToArray(), default(ssConectaProveedores.RestRecords.RESTST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure));
}

return result;
}


    public static ConectaProveedores_y_Utils_InvoiceReportPdf_DataActionGetTableItems_Model ToModel(RESTConectaProveedores_y_Utils_InvoiceReportPdf_DataActionGetTableItems_Outputs variables) {ConectaProveedores_y_Utils_InvoiceReportPdf_DataActionGetTableItems_Model result = new ConectaProveedores_y_Utils_InvoiceReportPdf_DataActionGetTableItems_Model();
result.outParamTableLine = variables == null ? new RL_f0441ae281d3bacc0d1d0acaed8c2549() : RL_f0441ae281d3bacc0d1d0acaed8c2549.FromRestList(variables.outParamTableLine, ssConectaProveedores.RestRecords.RESTST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure.ToStructure);
return result;
}


    public static RESTConectaProveedores_y_Utils_InvoiceReportPdf_DataActionGetTableItems_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_y_Utils_InvoiceReportPdf_DataActionGetTableItems_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_y_Utils_InvoiceReportPdf_DataActionGetTableItems_Outputs result = new RESTConectaProveedores_y_Utils_InvoiceReportPdf_DataActionGetTableItems_Outputs();
result.outParamTableLine = screenModel.outParamTableLine.ToRestList<ssConectaProveedores.RestRecords.RESTST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure>(ssConectaProveedores.RestRecords.RESTST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure.FromStructureDelegate(conf));
return result;
}

}
