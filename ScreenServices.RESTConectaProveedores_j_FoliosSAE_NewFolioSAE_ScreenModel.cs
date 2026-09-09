using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_NewFolioSAE_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetCompanies")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_99a1fa6df481ec5b1908e770c81b73b1> ScreenDataSetGetCompanies;
[JsonProperty("GerOrderByOrderNumber")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_04c362ab7ba29f051f4f0e5fa0df3577> ScreenDataSetGerOrderByOrderNumber;
[JsonProperty("StartIndex")]
public int? varLcStartIndex;
[JsonProperty("TableSort")]
public string varLcTableSort;
[JsonProperty("l_Step")]
public int? varLcl_Step;
[JsonProperty("l_OrderNumberFilter")]
public string varLcl_OrderNumberFilter;
[JsonProperty("l_CompanyIdFilter")]
public long? varLcl_CompanyIdFilter;
[JsonProperty("l_OrderIdSelected")]
public long? varLcl_OrderIdSelected;
[JsonProperty("IsSelected")]
public bool? varLcIsSelected;
[JsonProperty("LocalSelectedLines")]
public RestList<ssConectaProveedores.RestRecords.RESTST_aa3e6001f162e602247a2e2cc13e2cf8Structure> varLcLocalSelectedLines;
[JsonProperty("l_IsSelectAll")]
public bool? varLcl_IsSelectAll;
[JsonProperty("l_IsShowSelectAll")]
public bool? varLcl_IsShowSelectAll;
[JsonProperty("l_OrderIdNumberSelected")]
public string varLcl_OrderIdNumberSelected;
[JsonProperty("l_IsExcludeFinalDelivery")]
public bool? varLcl_IsExcludeFinalDelivery;
[JsonProperty("l_ShowOnlyAvailable")]
public bool? varLcl_ShowOnlyAvailable;
[JsonProperty("GetOrderMainItems")]
public RESTConectaProveedores_j_FoliosSAE_NewFolioSAE_DataActionGetOrderMainItems_Outputs varLcGetOrderMainItems;
[JsonProperty("GetOrders")]
public RESTConectaProveedores_j_FoliosSAE_NewFolioSAE_DataActionGetOrders_Outputs varLcGetOrders;
[JsonProperty("GetApplicantType")]
public RESTConectaProveedores_j_FoliosSAE_NewFolioSAE_DataActionGetApplicantType_Outputs varLcGetApplicantType;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_j_FoliosSAE_NewFolioSAE_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_j_FoliosSAE_NewFolioSAE_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_j_FoliosSAE_NewFolioSAE_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_j_FoliosSAE_NewFolioSAE_ScreenModel ToModel() {int varLcStartIndex = variables.varLcStartIndex == null ? 0 : variables.varLcStartIndex.Value;
string varLcTableSort = variables.varLcTableSort == null ? "" : variables.varLcTableSort;
int varLcl_Step = variables.varLcl_Step == null ? 1 : variables.varLcl_Step.Value;
string varLcl_OrderNumberFilter = variables.varLcl_OrderNumberFilter == null ? "" : variables.varLcl_OrderNumberFilter;
long varLcl_CompanyIdFilter = variables.varLcl_CompanyIdFilter == null ? 0L : variables.varLcl_CompanyIdFilter.Value;
long varLcl_OrderIdSelected = variables.varLcl_OrderIdSelected == null ? 0L : variables.varLcl_OrderIdSelected.Value;
bool varLcIsSelected = variables.varLcIsSelected == null ? false : variables.varLcIsSelected.Value;
RL_123aa03224ec08dab8cbe26021987012 varLcLocalSelectedLines = RL_123aa03224ec08dab8cbe26021987012.FromRestList(variables.varLcLocalSelectedLines, ssConectaProveedores.RestRecords.RESTST_aa3e6001f162e602247a2e2cc13e2cf8Structure.ToStructure);
bool varLcl_IsSelectAll = variables.varLcl_IsSelectAll == null ? false : variables.varLcl_IsSelectAll.Value;
bool varLcl_IsShowSelectAll = variables.varLcl_IsShowSelectAll == null ? false : variables.varLcl_IsShowSelectAll.Value;
string varLcl_OrderIdNumberSelected = variables.varLcl_OrderIdNumberSelected == null ? "" : variables.varLcl_OrderIdNumberSelected;
bool varLcl_IsExcludeFinalDelivery = variables.varLcl_IsExcludeFinalDelivery == null ? false : variables.varLcl_IsExcludeFinalDelivery.Value;
bool varLcl_ShowOnlyAvailable = variables.varLcl_ShowOnlyAvailable == null ? false : variables.varLcl_ShowOnlyAvailable.Value;
AggregateRecord<RL_060f887b4f32b5cdb78b49175875565c> _ScreenDataSetGetCompanies = (variables.ScreenDataSetGetCompanies != null) ? variables.ScreenDataSetGetCompanies.FromJS((array) => {
return RL_060f887b4f32b5cdb78b49175875565c.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_99a1fa6df481ec5b1908e770c81b73b1.ToStructure);
}
) : null;
AggregateRecord<RL_67e2db3b41beb37bb78f90d8e94803d5> _ScreenDataSetGerOrderByOrderNumber = (variables.ScreenDataSetGerOrderByOrderNumber != null) ? variables.ScreenDataSetGerOrderByOrderNumber.FromJS((array) => {
return RL_67e2db3b41beb37bb78f90d8e94803d5.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_04c362ab7ba29f051f4f0e5fa0df3577.ToStructure);
}
) : null;
ConectaProveedores_j_FoliosSAE_NewFolioSAE_DataActionGetOrderMainItems_Model _varLcGetOrderMainItems = (variables.varLcGetOrderMainItems != null) ? RESTConectaProveedores_j_FoliosSAE_NewFolioSAE_DataActionGetOrderMainItems_Outputs.ToModel(variables.varLcGetOrderMainItems) : null;
ConectaProveedores_j_FoliosSAE_NewFolioSAE_DataActionGetOrders_Model _varLcGetOrders = (variables.varLcGetOrders != null) ? RESTConectaProveedores_j_FoliosSAE_NewFolioSAE_DataActionGetOrders_Outputs.ToModel(variables.varLcGetOrders) : null;
ConectaProveedores_j_FoliosSAE_NewFolioSAE_DataActionGetApplicantType_Model _varLcGetApplicantType = (variables.varLcGetApplicantType != null) ? RESTConectaProveedores_j_FoliosSAE_NewFolioSAE_DataActionGetApplicantType_Outputs.ToModel(variables.varLcGetApplicantType) : null;
ConectaProveedores_j_FoliosSAE_NewFolioSAE_ScreenModel screenModel = new ConectaProveedores_j_FoliosSAE_NewFolioSAE_ScreenModel(varLcStartIndex, varLcTableSort, varLcl_Step, varLcl_OrderNumberFilter, varLcl_CompanyIdFilter, varLcl_OrderIdSelected, varLcIsSelected, varLcLocalSelectedLines, varLcl_IsSelectAll, varLcl_IsShowSelectAll, varLcl_OrderIdNumberSelected, varLcl_IsExcludeFinalDelivery, varLcl_ShowOnlyAvailable, _ScreenDataSetGetCompanies, _ScreenDataSetGerOrderByOrderNumber, _varLcGetOrderMainItems, _varLcGetOrders, _varLcGetApplicantType, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
