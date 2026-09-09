using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_d_Invoices_Wb_InvoiceDetails_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetInvoiceExtendedMoreChargesTotal")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_8675220d3fe960c67254ae28d587388e> ScreenDataSetGetInvoiceExtendedMoreChargesTotal;
[JsonProperty("GetInvoiceExtendedRelationsByInvoiceId")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_759c053ad9cffaec26c59da8e40042d4> ScreenDataSetGetInvoiceExtendedRelationsByInvoiceId;
[JsonProperty("GetInvoiceAccountingByInvoiceId")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_f925a49e2decb9ca9ea463dccae74847> ScreenDataSetGetInvoiceAccountingByInvoiceId;
[JsonProperty("GetInvoiceExtendedById")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_2c7478516bbd3eed6a35183496a9f500> ScreenDataSetGetInvoiceExtendedById;
[JsonProperty("GetInvoiceExtendedMoreChargesByInvoiceId")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_152a5bcdbf970bfba2a0da40766a2168> ScreenDataSetGetInvoiceExtendedMoreChargesByInvoiceId;
[JsonProperty("GetInvoiceApproval")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_eac76b624d2264108f6fbeb95d9d43ba> ScreenDataSetGetInvoiceApproval;
[JsonProperty("i_InvoiceId")]
public long? inParami_InvoiceId;
[JsonProperty("i_RequisitionId")]
public long? inParami_RequisitionId;
[JsonProperty("IsActiveUser")]
public bool? inParamIsActiveUser;
[JsonProperty("l_IsBusy")]
public bool? varLcl_IsBusy;
[JsonProperty("l_ShowCancelPopup")]
public bool? varLcl_ShowCancelPopup;
[JsonProperty("l_ShowModifyPopup")]
public bool? varLcl_ShowModifyPopup;
[JsonProperty("l_ShowApproveInvoice")]
public bool? varLcl_ShowApproveInvoice;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_d_Invoices_Wb_InvoiceDetails_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_d_Invoices_Wb_InvoiceDetails_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_d_Invoices_Wb_InvoiceDetails_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_d_Invoices_Wb_InvoiceDetails_ScreenModel ToModel() {long inParami_InvoiceId = variables.inParami_InvoiceId == null ? 0L : variables.inParami_InvoiceId.Value;
long inParami_RequisitionId = variables.inParami_RequisitionId == null ? 0L : variables.inParami_RequisitionId.Value;
bool inParamIsActiveUser = variables.inParamIsActiveUser == null ? false : variables.inParamIsActiveUser.Value;
bool varLcl_IsBusy = variables.varLcl_IsBusy == null ? false : variables.varLcl_IsBusy.Value;
bool varLcl_ShowCancelPopup = variables.varLcl_ShowCancelPopup == null ? false : variables.varLcl_ShowCancelPopup.Value;
bool varLcl_ShowModifyPopup = variables.varLcl_ShowModifyPopup == null ? false : variables.varLcl_ShowModifyPopup.Value;
bool varLcl_ShowApproveInvoice = variables.varLcl_ShowApproveInvoice == null ? false : variables.varLcl_ShowApproveInvoice.Value;
AggregateRecord<RL_84dada5f12004775b86c894b55ae9596> _ScreenDataSetGetInvoiceExtendedMoreChargesTotal = (variables.ScreenDataSetGetInvoiceExtendedMoreChargesTotal != null) ? variables.ScreenDataSetGetInvoiceExtendedMoreChargesTotal.FromJS((array) => {
return RL_84dada5f12004775b86c894b55ae9596.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_8675220d3fe960c67254ae28d587388e.ToStructure);
}
) : null;
AggregateRecord<RL_d07e089b14ae41d13cfd90c5313de016> _ScreenDataSetGetInvoiceExtendedRelationsByInvoiceId = (variables.ScreenDataSetGetInvoiceExtendedRelationsByInvoiceId != null) ? variables.ScreenDataSetGetInvoiceExtendedRelationsByInvoiceId.FromJS((array) => {
return RL_d07e089b14ae41d13cfd90c5313de016.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_759c053ad9cffaec26c59da8e40042d4.ToStructure);
}
) : null;
AggregateRecord<RL_cc406982da8c42dd9f44909f6be7c1b9> _ScreenDataSetGetInvoiceAccountingByInvoiceId = (variables.ScreenDataSetGetInvoiceAccountingByInvoiceId != null) ? variables.ScreenDataSetGetInvoiceAccountingByInvoiceId.FromJS((array) => {
return RL_cc406982da8c42dd9f44909f6be7c1b9.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_f925a49e2decb9ca9ea463dccae74847.ToStructure);
}
) : null;
AggregateRecord<RL_ec81b8a47286cf2b9fe9bbf727e9ade3> _ScreenDataSetGetInvoiceExtendedById = (variables.ScreenDataSetGetInvoiceExtendedById != null) ? variables.ScreenDataSetGetInvoiceExtendedById.FromJS((array) => {
return RL_ec81b8a47286cf2b9fe9bbf727e9ade3.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_2c7478516bbd3eed6a35183496a9f500.ToStructure);
}
) : null;
AggregateRecord<RL_ef088826c46241557fb82e7c7f21d334> _ScreenDataSetGetInvoiceExtendedMoreChargesByInvoiceId = (variables.ScreenDataSetGetInvoiceExtendedMoreChargesByInvoiceId != null) ? variables.ScreenDataSetGetInvoiceExtendedMoreChargesByInvoiceId.FromJS((array) => {
return RL_ef088826c46241557fb82e7c7f21d334.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_152a5bcdbf970bfba2a0da40766a2168.ToStructure);
}
) : null;
AggregateRecord<RL_d62c1f17f6aae94386bfdb54075ff733> _ScreenDataSetGetInvoiceApproval = (variables.ScreenDataSetGetInvoiceApproval != null) ? variables.ScreenDataSetGetInvoiceApproval.FromJS((array) => {
return RL_d62c1f17f6aae94386bfdb54075ff733.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_eac76b624d2264108f6fbeb95d9d43ba.ToStructure);
}
) : null;
ConectaProveedores_d_Invoices_Wb_InvoiceDetails_ScreenModel screenModel = new ConectaProveedores_d_Invoices_Wb_InvoiceDetails_ScreenModel(inParami_InvoiceId, inParami_RequisitionId, inParamIsActiveUser, varLcl_IsBusy, varLcl_ShowCancelPopup, varLcl_ShowModifyPopup, varLcl_ShowApproveInvoice, _ScreenDataSetGetInvoiceExtendedMoreChargesTotal, _ScreenDataSetGetInvoiceExtendedRelationsByInvoiceId, _ScreenDataSetGetInvoiceAccountingByInvoiceId, _ScreenDataSetGetInvoiceExtendedById, _ScreenDataSetGetInvoiceExtendedMoreChargesByInvoiceId, _ScreenDataSetGetInvoiceApproval, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
