using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetUserApplicationRoles_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("UserRolesList")]
public RestList<ssConectaProveedores.RestRecords.RESTST_e39617f0f094a322d4157f34fe424dadStructure> outParamUserRolesList;
[JsonProperty("ListText")]
public string outParamListText;
[JsonProperty("IsCorporativoCxP")]
public bool? outParamIsCorporativoCxP;
[JsonProperty("CanUploadInvoices")]
public bool? outParamCanUploadInvoices;
[JsonProperty("TelcelDirectionsListText")]
public string outParamTelcelDirectionsListText;
[JsonProperty("IsSegmentationCorporativo")]
public bool? outParamIsSegmentationCorporativo;
[JsonProperty("CorporativoRegionId")]
public long? outParamCorporativoRegionId;


    public static RESTConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetUserApplicationRoles_Outputs FromOutputs(IBehaviorsConfiguration conf, RL_97ac86b141c7934fd96d3cf71793066e outParamUserRolesList, string outParamListText, bool outParamIsCorporativoCxP, bool outParamCanUploadInvoices, string outParamTelcelDirectionsListText, bool outParamIsSegmentationCorporativo, long outParamCorporativoRegionId) {RESTConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetUserApplicationRoles_Outputs result = new RESTConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetUserApplicationRoles_Outputs();
// Write optimized result.outParamUserRolesList
result.outParamUserRolesList = new RL_97ac86b141c7934fd96d3cf71793066e().ToRestList<ssConectaProveedores.RestRecords.RESTST_e39617f0f094a322d4157f34fe424dadStructure>(ssConectaProveedores.RestRecords.RESTST_e39617f0f094a322d4157f34fe424dadStructure.FromStructureDelegate(conf));
// Write optimized result.outParamListText
result.outParamListText = "";
result.outParamIsCorporativoCxP = (bool?) outParamIsCorporativoCxP;
result.outParamCanUploadInvoices = (bool?) outParamCanUploadInvoices;
result.outParamTelcelDirectionsListText = outParamTelcelDirectionsListText;
result.outParamIsSegmentationCorporativo = (bool?) outParamIsSegmentationCorporativo;
result.outParamCorporativoRegionId = (long?) outParamCorporativoRegionId;
return result;
}


    public static ConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetUserApplicationRoles_Model ToModel(RESTConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetUserApplicationRoles_Outputs variables) {ConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetUserApplicationRoles_Model result = new ConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetUserApplicationRoles_Model();
result.outParamUserRolesList = variables == null ? new RL_97ac86b141c7934fd96d3cf71793066e() : RL_97ac86b141c7934fd96d3cf71793066e.FromRestList(variables.outParamUserRolesList, ssConectaProveedores.RestRecords.RESTST_e39617f0f094a322d4157f34fe424dadStructure.ToStructure);
result.outParamListText = variables == null || variables.outParamListText == null ? "" : variables.outParamListText;
result.outParamIsCorporativoCxP = variables == null || variables.outParamIsCorporativoCxP == null ? false : variables.outParamIsCorporativoCxP.Value;
result.outParamCanUploadInvoices = variables == null || variables.outParamCanUploadInvoices == null ? false : variables.outParamCanUploadInvoices.Value;
result.outParamTelcelDirectionsListText = variables == null || variables.outParamTelcelDirectionsListText == null ? "" : variables.outParamTelcelDirectionsListText;
result.outParamIsSegmentationCorporativo = variables == null || variables.outParamIsSegmentationCorporativo == null ? false : variables.outParamIsSegmentationCorporativo.Value;
result.outParamCorporativoRegionId = variables == null || variables.outParamCorporativoRegionId == null ? 0L : variables.outParamCorporativoRegionId.Value;
return result;
}


    public static RESTConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetUserApplicationRoles_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetUserApplicationRoles_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetUserApplicationRoles_Outputs result = new RESTConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetUserApplicationRoles_Outputs();
result.outParamUserRolesList = screenModel.outParamUserRolesList.ToRestList<ssConectaProveedores.RestRecords.RESTST_e39617f0f094a322d4157f34fe424dadStructure>(ssConectaProveedores.RestRecords.RESTST_e39617f0f094a322d4157f34fe424dadStructure.FromStructureDelegate(conf));
result.outParamListText = screenModel.outParamListText;
result.outParamIsCorporativoCxP = (bool?) screenModel.outParamIsCorporativoCxP;
result.outParamCanUploadInvoices = (bool?) screenModel.outParamCanUploadInvoices;
result.outParamTelcelDirectionsListText = screenModel.outParamTelcelDirectionsListText;
result.outParamIsSegmentationCorporativo = (bool?) screenModel.outParamIsSegmentationCorporativo;
result.outParamCorporativoRegionId = (long?) screenModel.outParamCorporativoRegionId;
return result;
}

}
