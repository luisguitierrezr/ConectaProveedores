using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_d_InvoiceAudit_InvoicesFilesAudit_DataActionGetInvoices_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("Invoices")]
public RestList<ssConectaProveedores.RestRecords.RESTST_29dc80a5deae2388e31181e1082143cfStructure> outParamInvoices;


    public static RESTConectaProveedores_d_InvoiceAudit_InvoicesFilesAudit_DataActionGetInvoices_Outputs FromOutputs(IBehaviorsConfiguration conf, RL_6da8ac1538224c0a012cd86c7222fe91 outParamInvoices) {RESTConectaProveedores_d_InvoiceAudit_InvoicesFilesAudit_DataActionGetInvoices_Outputs result = new RESTConectaProveedores_d_InvoiceAudit_InvoicesFilesAudit_DataActionGetInvoices_Outputs();
// Write the needed fields of the list outParamInvoices to the result.outParamInvoices
ssConectaProveedores.RestRecords.RESTST_29dc80a5deae2388e31181e1082143cfStructure tmpoutParamInvoicesElement;
if(outParamInvoices.Empty) {
// Write the needed fields of the record outParamInvoices.CurrentRec to the tmpoutParamInvoicesElement
tmpoutParamInvoicesElement = new ssConectaProveedores.RestRecords.RESTST_29dc80a5deae2388e31181e1082143cfStructure();
tmpoutParamInvoicesElement.AttrInvoiceId = (long?) outParamInvoices.CurrentRec.ssInvoiceId;
tmpoutParamInvoicesElement.AttrInvoiceName = outParamInvoices.CurrentRec.ssInvoiceName;
tmpoutParamInvoicesElement.AttrSupplierNr = outParamInvoices.CurrentRec.ssSupplierNr;
tmpoutParamInvoicesElement.AttrInvoiceUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(outParamInvoices.CurrentRec.ssInvoiceUpdatedOn, conf.DateTimeFormat);
result.outParamInvoices = new RestList<ssConectaProveedores.RestRecords.RESTST_29dc80a5deae2388e31181e1082143cfStructure>(new ssConectaProveedores.RestRecords.RESTST_29dc80a5deae2388e31181e1082143cfStructure[] {}, tmpoutParamInvoicesElement);
} else {
List<ssConectaProveedores.RestRecords.RESTST_29dc80a5deae2388e31181e1082143cfStructure>
 tmpoutParamInvoices1List = new List<ssConectaProveedores.RestRecords.RESTST_29dc80a5deae2388e31181e1082143cfStructure>
();
try {outParamInvoices.StartIteration();
while (!(outParamInvoices.Eof)) {
// Write the needed fields of the record outParamInvoices.CurrentRec to the tmpoutParamInvoicesElement
tmpoutParamInvoicesElement = new ssConectaProveedores.RestRecords.RESTST_29dc80a5deae2388e31181e1082143cfStructure();
tmpoutParamInvoicesElement.AttrInvoiceId = (long?) outParamInvoices.CurrentRec.ssInvoiceId;
tmpoutParamInvoicesElement.AttrInvoiceName = outParamInvoices.CurrentRec.ssInvoiceName;
tmpoutParamInvoicesElement.AttrSupplierNr = outParamInvoices.CurrentRec.ssSupplierNr;
tmpoutParamInvoicesElement.AttrInvoiceUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(outParamInvoices.CurrentRec.ssInvoiceUpdatedOn, conf.DateTimeFormat);
tmpoutParamInvoices1List.Add(tmpoutParamInvoicesElement);
outParamInvoices.Advance();
}

} finally {
outParamInvoices.EndIteration();
}

result.outParamInvoices = new RestList<ssConectaProveedores.RestRecords.RESTST_29dc80a5deae2388e31181e1082143cfStructure>(tmpoutParamInvoices1List.ToArray(), default(ssConectaProveedores.RestRecords.RESTST_29dc80a5deae2388e31181e1082143cfStructure));
}

return result;
}


    public static ConectaProveedores_d_InvoiceAudit_InvoicesFilesAudit_DataActionGetInvoices_Model ToModel(RESTConectaProveedores_d_InvoiceAudit_InvoicesFilesAudit_DataActionGetInvoices_Outputs variables) {ConectaProveedores_d_InvoiceAudit_InvoicesFilesAudit_DataActionGetInvoices_Model result = new ConectaProveedores_d_InvoiceAudit_InvoicesFilesAudit_DataActionGetInvoices_Model();
result.outParamInvoices = variables == null ? new RL_6da8ac1538224c0a012cd86c7222fe91() : RL_6da8ac1538224c0a012cd86c7222fe91.FromRestList(variables.outParamInvoices, ssConectaProveedores.RestRecords.RESTST_29dc80a5deae2388e31181e1082143cfStructure.ToStructure);
return result;
}


    public static RESTConectaProveedores_d_InvoiceAudit_InvoicesFilesAudit_DataActionGetInvoices_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_d_InvoiceAudit_InvoicesFilesAudit_DataActionGetInvoices_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_d_InvoiceAudit_InvoicesFilesAudit_DataActionGetInvoices_Outputs result = new RESTConectaProveedores_d_InvoiceAudit_InvoicesFilesAudit_DataActionGetInvoices_Outputs();
result.outParamInvoices = screenModel.outParamInvoices.ToRestList<ssConectaProveedores.RestRecords.RESTST_29dc80a5deae2388e31181e1082143cfStructure>(ssConectaProveedores.RestRecords.RESTST_29dc80a5deae2388e31181e1082143cfStructure.FromStructureDelegate(conf));
return result;
}

}
