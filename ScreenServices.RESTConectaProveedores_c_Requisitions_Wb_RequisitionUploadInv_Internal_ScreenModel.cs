using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_c_Requisitions_Wb_RequisitionUploadInv_Internal_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetProjectAssetServices")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_1b08a2c1cecef1e3b3006a60b97fc68e> ScreenDataSetGetProjectAssetServices;
[JsonProperty("GetRequisitionsForUpload")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_86423f353b6ff38800cf09bdbbb2131d> ScreenDataSetGetRequisitionsForUpload;
[JsonProperty("GetCompanies")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_99a1fa6df481ec5b1908e770c81b73b1> ScreenDataSetGetCompanies;
[JsonProperty("l_ShowFilters")]
public bool? varLcl_ShowFilters;
[JsonProperty("l_TableSort")]
public string varLcl_TableSort;
[JsonProperty("l_StartIndex")]
public int? varLcl_StartIndex;
[JsonProperty("l_ReInvokeToggler")]
public bool? varLcl_ReInvokeToggler;
[JsonProperty("l_ColumnJSONVarGetRequisitions")]
public string varLcl_ColumnJSONVarGetRequisitions;
[JsonProperty("l_CountAfterFetchGetRequisitions")]
public int? varLcl_CountAfterFetchGetRequisitions;
[JsonProperty("l_AmountFromText")]
public string varLcl_AmountFromText;
[JsonProperty("l_AmountToText")]
public string varLcl_AmountToText;
[JsonProperty("GetApprovalProcessIds2")]
public RESTConectaProveedores_c_Requisitions_Wb_RequisitionUploadInv_Internal_DataActionGetApprovalProcessIds2_Outputs varLcGetApprovalProcessIds2;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_c_Requisitions_Wb_RequisitionUploadInv_Internal_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_c_Requisitions_Wb_RequisitionUploadInv_Internal_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_c_Requisitions_Wb_RequisitionUploadInv_Internal_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_c_Requisitions_Wb_RequisitionUploadInv_Internal_ScreenModel ToModel() {bool varLcl_ShowFilters = variables.varLcl_ShowFilters == null ? false : variables.varLcl_ShowFilters.Value;
string varLcl_TableSort = variables.varLcl_TableSort == null ? "" : variables.varLcl_TableSort;
int varLcl_StartIndex = variables.varLcl_StartIndex == null ? 0 : variables.varLcl_StartIndex.Value;
bool varLcl_ReInvokeToggler = variables.varLcl_ReInvokeToggler == null ? false : variables.varLcl_ReInvokeToggler.Value;
string varLcl_ColumnJSONVarGetRequisitions = variables.varLcl_ColumnJSONVarGetRequisitions == null ? "" : variables.varLcl_ColumnJSONVarGetRequisitions;
int varLcl_CountAfterFetchGetRequisitions = variables.varLcl_CountAfterFetchGetRequisitions == null ? 0 : variables.varLcl_CountAfterFetchGetRequisitions.Value;
string varLcl_AmountFromText = variables.varLcl_AmountFromText == null ? "" : variables.varLcl_AmountFromText;
string varLcl_AmountToText = variables.varLcl_AmountToText == null ? "" : variables.varLcl_AmountToText;
AggregateRecord<RL_39dc6f4415ce9196844d0ada601cc72b> _ScreenDataSetGetProjectAssetServices = (variables.ScreenDataSetGetProjectAssetServices != null) ? variables.ScreenDataSetGetProjectAssetServices.FromJS((array) => {
return RL_39dc6f4415ce9196844d0ada601cc72b.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_1b08a2c1cecef1e3b3006a60b97fc68e.ToStructure);
}
) : null;
AggregateRecord<RL_39c5627b3bb44cc40b890ccd9b2786b2> _ScreenDataSetGetRequisitionsForUpload = (variables.ScreenDataSetGetRequisitionsForUpload != null) ? variables.ScreenDataSetGetRequisitionsForUpload.FromJS((array) => {
return RL_39c5627b3bb44cc40b890ccd9b2786b2.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_86423f353b6ff38800cf09bdbbb2131d.ToStructure);
}
) : null;
AggregateRecord<RL_060f887b4f32b5cdb78b49175875565c> _ScreenDataSetGetCompanies = (variables.ScreenDataSetGetCompanies != null) ? variables.ScreenDataSetGetCompanies.FromJS((array) => {
return RL_060f887b4f32b5cdb78b49175875565c.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_99a1fa6df481ec5b1908e770c81b73b1.ToStructure);
}
) : null;
ConectaProveedores_c_Requisitions_Wb_RequisitionUploadInv_Internal_DataActionGetApprovalProcessIds2_Model _varLcGetApprovalProcessIds2 = (variables.varLcGetApprovalProcessIds2 != null) ? RESTConectaProveedores_c_Requisitions_Wb_RequisitionUploadInv_Internal_DataActionGetApprovalProcessIds2_Outputs.ToModel(variables.varLcGetApprovalProcessIds2) : null;
ConectaProveedores_c_Requisitions_Wb_RequisitionUploadInv_Internal_ScreenModel screenModel = new ConectaProveedores_c_Requisitions_Wb_RequisitionUploadInv_Internal_ScreenModel(varLcl_ShowFilters, varLcl_TableSort, varLcl_StartIndex, varLcl_ReInvokeToggler, varLcl_ColumnJSONVarGetRequisitions, varLcl_CountAfterFetchGetRequisitions, varLcl_AmountFromText, varLcl_AmountToText, _ScreenDataSetGetProjectAssetServices, _ScreenDataSetGetRequisitionsForUpload, _ScreenDataSetGetCompanies, _varLcGetApprovalProcessIds2, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
