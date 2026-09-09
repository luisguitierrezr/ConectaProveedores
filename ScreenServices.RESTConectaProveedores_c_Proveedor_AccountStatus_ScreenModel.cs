using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_c_Proveedor_AccountStatus_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetSupplierUserByUserId")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_3f6ba4c81bcd03d8108335ecd7631ff4> ScreenDataSetGetSupplierUserByUserId;
[JsonProperty("GetSupplierDetailsBySupplierId")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_5df7bb5aa64fe06d5d087faa4a2fd561> ScreenDataSetGetSupplierDetailsBySupplierId;
[JsonProperty("GetPaymentTerms")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_5526bab1a99740bd870dde6a69ba3d9a> ScreenDataSetGetPaymentTerms;
[JsonProperty("GetRegions")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_deb85dc36640fa928dae5df2493065d0> ScreenDataSetGetRegions;
[JsonProperty("SupplierDetailIdentifier")]
public long? varLcSupplierDetailIdentifier;
[JsonProperty("ViewDetail")]
public bool? varLcViewDetail;
[JsonProperty("RegionSelected")]
public string varLcRegionSelected;
[JsonProperty("MaxRecords")]
public int? varLcMaxRecords;
[JsonProperty("TableSort")]
public string varLcTableSort;
[JsonProperty("StartIndex")]
public int? varLcStartIndex;
[JsonProperty("L_FACTPENPAG")]
public RestList<ssConectaProveedores.RestRecords.RESTST_9f44b824af1405b8fbe038a5a393bb86Structure> varLcL_FACTPENPAG;
[JsonProperty("L_FACTPENPAGFiltered")]
public RestList<ssConectaProveedores.RestRecords.RESTST_9f44b824af1405b8fbe038a5a393bb86Structure> varLcL_FACTPENPAGFiltered;
[JsonProperty("TotalRecords")]
public int? varLcTotalRecords;
[JsonProperty("InvoiceTextNumber")]
public string varLcInvoiceTextNumber;
[JsonProperty("DateTime")]
public String varLcDateTime;
[JsonProperty("l_Tab")]
public int? varLcl_Tab;
[JsonProperty("GetSapData")]
public RESTConectaProveedores_c_Proveedor_AccountStatus_DataActionGetSapData_Outputs varLcGetSapData;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_c_Proveedor_AccountStatus_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_c_Proveedor_AccountStatus_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_c_Proveedor_AccountStatus_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_c_Proveedor_AccountStatus_ScreenModel ToModel() {long varLcSupplierDetailIdentifier = variables.varLcSupplierDetailIdentifier == null ? 0L : variables.varLcSupplierDetailIdentifier.Value;
bool varLcViewDetail = variables.varLcViewDetail == null ? false : variables.varLcViewDetail.Value;
string varLcRegionSelected = variables.varLcRegionSelected == null ? "" : variables.varLcRegionSelected;
int varLcMaxRecords = variables.varLcMaxRecords == null ? 20 : variables.varLcMaxRecords.Value;
string varLcTableSort = variables.varLcTableSort == null ? "" : variables.varLcTableSort;
int varLcStartIndex = variables.varLcStartIndex == null ? 0 : variables.varLcStartIndex.Value;
RL_dd107351023827897d1e9d4f7246e1d9 varLcL_FACTPENPAG = RL_dd107351023827897d1e9d4f7246e1d9.FromRestList(variables.varLcL_FACTPENPAG, ssConectaProveedores.RestRecords.RESTST_9f44b824af1405b8fbe038a5a393bb86Structure.ToStructure);
RL_dd107351023827897d1e9d4f7246e1d9 varLcL_FACTPENPAGFiltered = RL_dd107351023827897d1e9d4f7246e1d9.FromRestList(variables.varLcL_FACTPENPAGFiltered, ssConectaProveedores.RestRecords.RESTST_9f44b824af1405b8fbe038a5a393bb86Structure.ToStructure);
int varLcTotalRecords = variables.varLcTotalRecords == null ? 0 : variables.varLcTotalRecords.Value;
string varLcInvoiceTextNumber = variables.varLcInvoiceTextNumber == null ? "" : variables.varLcInvoiceTextNumber;
DateTime varLcDateTime = variables.varLcDateTime == null ? BuiltInFunction.CurrDateTime () : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(variables.varLcDateTime, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
int varLcl_Tab = variables.varLcl_Tab == null ? 0 : variables.varLcl_Tab.Value;
AggregateRecord<RL_5859a4306a0de95c2b5c534d5cfa7150> _ScreenDataSetGetSupplierUserByUserId = (variables.ScreenDataSetGetSupplierUserByUserId != null) ? variables.ScreenDataSetGetSupplierUserByUserId.FromJS((array) => {
return RL_5859a4306a0de95c2b5c534d5cfa7150.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_3f6ba4c81bcd03d8108335ecd7631ff4.ToStructure);
}
) : null;
AggregateRecord<RL_3c0fa01b89994c3e2eaed82b259c3f66> _ScreenDataSetGetSupplierDetailsBySupplierId = (variables.ScreenDataSetGetSupplierDetailsBySupplierId != null) ? variables.ScreenDataSetGetSupplierDetailsBySupplierId.FromJS((array) => {
return RL_3c0fa01b89994c3e2eaed82b259c3f66.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_5df7bb5aa64fe06d5d087faa4a2fd561.ToStructure);
}
) : null;
AggregateRecord<RL_375b9dd8c8b0d6d7bccf4d550f48644d> _ScreenDataSetGetPaymentTerms = (variables.ScreenDataSetGetPaymentTerms != null) ? variables.ScreenDataSetGetPaymentTerms.FromJS((array) => {
return RL_375b9dd8c8b0d6d7bccf4d550f48644d.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_5526bab1a99740bd870dde6a69ba3d9a.ToStructure);
}
) : null;
AggregateRecord<RL_5d3a02aa993c7474297e33d992f39ad0> _ScreenDataSetGetRegions = (variables.ScreenDataSetGetRegions != null) ? variables.ScreenDataSetGetRegions.FromJS((array) => {
return RL_5d3a02aa993c7474297e33d992f39ad0.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_deb85dc36640fa928dae5df2493065d0.ToStructure);
}
) : null;
ConectaProveedores_c_Proveedor_AccountStatus_DataActionGetSapData_Model _varLcGetSapData = (variables.varLcGetSapData != null) ? RESTConectaProveedores_c_Proveedor_AccountStatus_DataActionGetSapData_Outputs.ToModel(variables.varLcGetSapData) : null;
ConectaProveedores_c_Proveedor_AccountStatus_ScreenModel screenModel = new ConectaProveedores_c_Proveedor_AccountStatus_ScreenModel(varLcSupplierDetailIdentifier, varLcViewDetail, varLcRegionSelected, varLcMaxRecords, varLcTableSort, varLcStartIndex, varLcL_FACTPENPAG, varLcL_FACTPENPAGFiltered, varLcTotalRecords, varLcInvoiceTextNumber, varLcDateTime, varLcl_Tab, _ScreenDataSetGetSupplierUserByUserId, _ScreenDataSetGetSupplierDetailsBySupplierId, _ScreenDataSetGetPaymentTerms, _ScreenDataSetGetRegions, _varLcGetSapData, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
