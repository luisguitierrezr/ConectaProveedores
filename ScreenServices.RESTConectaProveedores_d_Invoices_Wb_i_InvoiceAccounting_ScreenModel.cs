using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetInvoiceRetentionsByInvoiceId")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_965912af30c7fbb7316f17bf8e331782> ScreenDataSetGetInvoiceRetentionsByInvoiceId;
[JsonProperty("GetInvoiceExtendedTaxsByInvoiceId")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_f4d76e3d3fccb22411e2fbf1d069c4d1> ScreenDataSetGetInvoiceExtendedTaxsByInvoiceId;
[JsonProperty("GetPaymentTerms")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_5526bab1a99740bd870dde6a69ba3d9a> ScreenDataSetGetPaymentTerms;
[JsonProperty("GetInvoiceApproval")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_eac76b624d2264108f6fbeb95d9d43ba> ScreenDataSetGetInvoiceApproval;
[JsonProperty("GetPaymentMethods")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_45208e184b912aa1623cdf19760e8e7e> ScreenDataSetGetPaymentMethods;
[JsonProperty("GetInvoiceExtendedById")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_fbe3f1050ad4f34fa0e0a15f88a56873> ScreenDataSetGetInvoiceExtendedById;
[JsonProperty("GetCostCenters")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_515e950fe4b29206769e5475135e301d> ScreenDataSetGetCostCenters;
[JsonProperty("GetRegions")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_deb85dc36640fa928dae5df2493065d0> ScreenDataSetGetRegions;
[JsonProperty("GetTaxIndicators")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_680b4f2b38f7607d61faf8ef68fd2613> ScreenDataSetGetTaxIndicators;
[JsonProperty("GetInvoiceExtendedMoreChargesByInvoiceId")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_152a5bcdbf970bfba2a0da40766a2168> ScreenDataSetGetInvoiceExtendedMoreChargesByInvoiceId;
[JsonProperty("GetInvoiceAccountingsByInvoiceId")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_c398a83ea7d109886e6be693f6d07867> ScreenDataSetGetInvoiceAccountingsByInvoiceId;
[JsonProperty("GetAccountingAccountsServiceTypes")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_f52b5cefcfac404122195213ce1b53ba> ScreenDataSetGetAccountingAccountsServiceTypes;
[JsonProperty("i_InvoiceId")]
public long? inParami_InvoiceId;
[JsonProperty("i_RequisitionId")]
public long? inParami_RequisitionId;
[JsonProperty("IsActiveUser")]
public bool? inParamIsActiveUser;
[JsonProperty("IsCorp")]
public bool? inParamIsCorp;
[JsonProperty("SupplierNumber")]
public string inParamSupplierNumber;
[JsonProperty("l_Iva")]
public decimal? varLcl_Iva;
[JsonProperty("l_ShowImportPopup")]
public bool? varLcl_ShowImportPopup;
[JsonProperty("l_ShowApprovalInvoice")]
public bool? varLcl_ShowApprovalInvoice;
[JsonProperty("l_ShowCancelInvoice")]
public bool? varLcl_ShowCancelInvoice;
[JsonProperty("l_ShowModifyPopup")]
public bool? varLcl_ShowModifyPopup;
[JsonProperty("l_IsApproval")]
public bool? varLcl_IsApproval;
[JsonProperty("l_IsImport")]
public bool? varLcl_IsImport;
[JsonProperty("l_InvoiceAccountingEntries")]
public RestList<ssConectaProveedores.RestRecords.RESTEN_66fb76d3fab58a693a3c750c022bd4efEntityRecord> varLcl_InvoiceAccountingEntries;
[JsonProperty("GetData")]
public RESTConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_DataActionGetData_Outputs varLcGetData;
[JsonProperty("GetSettings")]
public RESTConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_DataActionGetSettings_Outputs varLcGetSettings;
[JsonProperty("GetInvoiceAccounting")]
public RESTConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_DataActionGetInvoiceAccounting_Outputs varLcGetInvoiceAccounting;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_ScreenModel ToModel() {long inParami_InvoiceId = variables.inParami_InvoiceId == null ? 0L : variables.inParami_InvoiceId.Value;
long inParami_RequisitionId = variables.inParami_RequisitionId == null ? 0L : variables.inParami_RequisitionId.Value;
bool inParamIsActiveUser = variables.inParamIsActiveUser == null ? false : variables.inParamIsActiveUser.Value;
bool inParamIsCorp = variables.inParamIsCorp == null ? false : variables.inParamIsCorp.Value;
string inParamSupplierNumber = variables.inParamSupplierNumber == null ? "" : variables.inParamSupplierNumber;
decimal varLcl_Iva = variables.varLcl_Iva == null ? (((decimal)0)) : variables.varLcl_Iva.Value;
bool varLcl_ShowImportPopup = variables.varLcl_ShowImportPopup == null ? false : variables.varLcl_ShowImportPopup.Value;
bool varLcl_ShowApprovalInvoice = variables.varLcl_ShowApprovalInvoice == null ? false : variables.varLcl_ShowApprovalInvoice.Value;
bool varLcl_ShowCancelInvoice = variables.varLcl_ShowCancelInvoice == null ? false : variables.varLcl_ShowCancelInvoice.Value;
bool varLcl_ShowModifyPopup = variables.varLcl_ShowModifyPopup == null ? false : variables.varLcl_ShowModifyPopup.Value;
bool varLcl_IsApproval = variables.varLcl_IsApproval == null ? false : variables.varLcl_IsApproval.Value;
bool varLcl_IsImport = variables.varLcl_IsImport == null ? false : variables.varLcl_IsImport.Value;
RL_0704e14bc1b3305d76f59d709913c287 varLcl_InvoiceAccountingEntries = RL_0704e14bc1b3305d76f59d709913c287.FromRestList(variables.varLcl_InvoiceAccountingEntries, ssConectaProveedores.RestRecords.RESTEN_66fb76d3fab58a693a3c750c022bd4efEntityRecord.ToStructure);
AggregateRecord<RL_9404dc36b913809894c7e4e44e8e1dd8> _ScreenDataSetGetInvoiceRetentionsByInvoiceId = (variables.ScreenDataSetGetInvoiceRetentionsByInvoiceId != null) ? variables.ScreenDataSetGetInvoiceRetentionsByInvoiceId.FromJS((array) => {
return RL_9404dc36b913809894c7e4e44e8e1dd8.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_965912af30c7fbb7316f17bf8e331782.ToStructure);
}
) : null;
AggregateRecord<RL_948a214f011367826beec566f5df17e6> _ScreenDataSetGetInvoiceExtendedTaxsByInvoiceId = (variables.ScreenDataSetGetInvoiceExtendedTaxsByInvoiceId != null) ? variables.ScreenDataSetGetInvoiceExtendedTaxsByInvoiceId.FromJS((array) => {
return RL_948a214f011367826beec566f5df17e6.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_f4d76e3d3fccb22411e2fbf1d069c4d1.ToStructure);
}
) : null;
AggregateRecord<RL_375b9dd8c8b0d6d7bccf4d550f48644d> _ScreenDataSetGetPaymentTerms = (variables.ScreenDataSetGetPaymentTerms != null) ? variables.ScreenDataSetGetPaymentTerms.FromJS((array) => {
return RL_375b9dd8c8b0d6d7bccf4d550f48644d.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_5526bab1a99740bd870dde6a69ba3d9a.ToStructure);
}
) : null;
AggregateRecord<RL_d62c1f17f6aae94386bfdb54075ff733> _ScreenDataSetGetInvoiceApproval = (variables.ScreenDataSetGetInvoiceApproval != null) ? variables.ScreenDataSetGetInvoiceApproval.FromJS((array) => {
return RL_d62c1f17f6aae94386bfdb54075ff733.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_eac76b624d2264108f6fbeb95d9d43ba.ToStructure);
}
) : null;
AggregateRecord<RL_0dcbcba642ca8b22e87f690d4de9d077> _ScreenDataSetGetPaymentMethods = (variables.ScreenDataSetGetPaymentMethods != null) ? variables.ScreenDataSetGetPaymentMethods.FromJS((array) => {
return RL_0dcbcba642ca8b22e87f690d4de9d077.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_45208e184b912aa1623cdf19760e8e7e.ToStructure);
}
) : null;
AggregateRecord<RL_a675a81d4063c2bba451ee57edc49e99> _ScreenDataSetGetInvoiceExtendedById = (variables.ScreenDataSetGetInvoiceExtendedById != null) ? variables.ScreenDataSetGetInvoiceExtendedById.FromJS((array) => {
return RL_a675a81d4063c2bba451ee57edc49e99.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_fbe3f1050ad4f34fa0e0a15f88a56873.ToStructure);
}
) : null;
AggregateRecord<RL_ec55ed22dae89075d036f3a863173164> _ScreenDataSetGetCostCenters = (variables.ScreenDataSetGetCostCenters != null) ? variables.ScreenDataSetGetCostCenters.FromJS((array) => {
return RL_ec55ed22dae89075d036f3a863173164.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_515e950fe4b29206769e5475135e301d.ToStructure);
}
) : null;
AggregateRecord<RL_5d3a02aa993c7474297e33d992f39ad0> _ScreenDataSetGetRegions = (variables.ScreenDataSetGetRegions != null) ? variables.ScreenDataSetGetRegions.FromJS((array) => {
return RL_5d3a02aa993c7474297e33d992f39ad0.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_deb85dc36640fa928dae5df2493065d0.ToStructure);
}
) : null;
AggregateRecord<RL_bf188616de0f0f2f6ca06ba5dba27490> _ScreenDataSetGetTaxIndicators = (variables.ScreenDataSetGetTaxIndicators != null) ? variables.ScreenDataSetGetTaxIndicators.FromJS((array) => {
return RL_bf188616de0f0f2f6ca06ba5dba27490.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_680b4f2b38f7607d61faf8ef68fd2613.ToStructure);
}
) : null;
AggregateRecord<RL_ef088826c46241557fb82e7c7f21d334> _ScreenDataSetGetInvoiceExtendedMoreChargesByInvoiceId = (variables.ScreenDataSetGetInvoiceExtendedMoreChargesByInvoiceId != null) ? variables.ScreenDataSetGetInvoiceExtendedMoreChargesByInvoiceId.FromJS((array) => {
return RL_ef088826c46241557fb82e7c7f21d334.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_152a5bcdbf970bfba2a0da40766a2168.ToStructure);
}
) : null;
AggregateRecord<RL_ccf70f600f06def33a14ca10a1120a68> _ScreenDataSetGetInvoiceAccountingsByInvoiceId = (variables.ScreenDataSetGetInvoiceAccountingsByInvoiceId != null) ? variables.ScreenDataSetGetInvoiceAccountingsByInvoiceId.FromJS((array) => {
return RL_ccf70f600f06def33a14ca10a1120a68.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_c398a83ea7d109886e6be693f6d07867.ToStructure);
}
) : null;
AggregateRecord<RL_60b4efe2937800b54618ed04c4847a05> _ScreenDataSetGetAccountingAccountsServiceTypes = (variables.ScreenDataSetGetAccountingAccountsServiceTypes != null) ? variables.ScreenDataSetGetAccountingAccountsServiceTypes.FromJS((array) => {
return RL_60b4efe2937800b54618ed04c4847a05.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_f52b5cefcfac404122195213ce1b53ba.ToStructure);
}
) : null;
ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_DataActionGetData_Model _varLcGetData = (variables.varLcGetData != null) ? RESTConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_DataActionGetData_Outputs.ToModel(variables.varLcGetData) : null;
ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_DataActionGetSettings_Model _varLcGetSettings = (variables.varLcGetSettings != null) ? RESTConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_DataActionGetSettings_Outputs.ToModel(variables.varLcGetSettings) : null;
ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_DataActionGetInvoiceAccounting_Model _varLcGetInvoiceAccounting = (variables.varLcGetInvoiceAccounting != null) ? RESTConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_DataActionGetInvoiceAccounting_Outputs.ToModel(variables.varLcGetInvoiceAccounting) : null;
ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_ScreenModel screenModel = new ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_ScreenModel(inParami_InvoiceId, inParami_RequisitionId, inParamIsActiveUser, inParamIsCorp, inParamSupplierNumber, varLcl_Iva, varLcl_ShowImportPopup, varLcl_ShowApprovalInvoice, varLcl_ShowCancelInvoice, varLcl_ShowModifyPopup, varLcl_IsApproval, varLcl_IsImport, varLcl_InvoiceAccountingEntries, _ScreenDataSetGetInvoiceRetentionsByInvoiceId, _ScreenDataSetGetInvoiceExtendedTaxsByInvoiceId, _ScreenDataSetGetPaymentTerms, _ScreenDataSetGetInvoiceApproval, _ScreenDataSetGetPaymentMethods, _ScreenDataSetGetInvoiceExtendedById, _ScreenDataSetGetCostCenters, _ScreenDataSetGetRegions, _ScreenDataSetGetTaxIndicators, _ScreenDataSetGetInvoiceExtendedMoreChargesByInvoiceId, _ScreenDataSetGetInvoiceAccountingsByInvoiceId, _ScreenDataSetGetAccountingAccountsServiceTypes, _varLcGetData, _varLcGetSettings, _varLcGetInvoiceAccounting, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
