using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_g_Reports_SupplierInvoicesReport_DataActionGetUserApplicationRoles_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("UserRolesList")]
public RestList<ssConectaProveedores.RestRecords.RESTST_e39617f0f094a322d4157f34fe424dadStructure> outParamUserRolesList;
[JsonProperty("IsAuditor")]
public bool? outParamIsAuditor;
[JsonProperty("SupplierId")]
public long? outParamSupplierId;
[JsonProperty("UserRegion")]
public long? outParamUserRegion;
[JsonProperty("IsAllRegions")]
public bool? outParamIsAllRegions;


    public static RESTConectaProveedores_g_Reports_SupplierInvoicesReport_DataActionGetUserApplicationRoles_Outputs FromOutputs(IBehaviorsConfiguration conf, RL_97ac86b141c7934fd96d3cf71793066e outParamUserRolesList, bool outParamIsAuditor, long outParamSupplierId, long outParamUserRegion, bool outParamIsAllRegions) {RESTConectaProveedores_g_Reports_SupplierInvoicesReport_DataActionGetUserApplicationRoles_Outputs result = new RESTConectaProveedores_g_Reports_SupplierInvoicesReport_DataActionGetUserApplicationRoles_Outputs();
// Write the needed fields of the list outParamUserRolesList to the result.outParamUserRolesList
ssConectaProveedores.RestRecords.RESTST_e39617f0f094a322d4157f34fe424dadStructure tmpoutParamUserRolesListElement;
if(outParamUserRolesList.Empty) {
// Write the needed fields of the record outParamUserRolesList.CurrentRec to the tmpoutParamUserRolesListElement
tmpoutParamUserRolesListElement = new ssConectaProveedores.RestRecords.RESTST_e39617f0f094a322d4157f34fe424dadStructure();
// Write optimized tmpoutParamUserRolesListElement.AttrApplicationRoleId
tmpoutParamUserRolesListElement.AttrApplicationRoleId = (long?) 0L;
// Write optimized tmpoutParamUserRolesListElement.AttrRoleName
tmpoutParamUserRolesListElement.AttrRoleName = "";
// Write optimized tmpoutParamUserRolesListElement.AttrCode
tmpoutParamUserRolesListElement.AttrCode = "";
// Write optimized tmpoutParamUserRolesListElement.AttrIsSubstitute
tmpoutParamUserRolesListElement.AttrIsSubstitute = (bool?) false;
result.outParamUserRolesList = new RestList<ssConectaProveedores.RestRecords.RESTST_e39617f0f094a322d4157f34fe424dadStructure>(new ssConectaProveedores.RestRecords.RESTST_e39617f0f094a322d4157f34fe424dadStructure[] {}, tmpoutParamUserRolesListElement);
} else {
List<ssConectaProveedores.RestRecords.RESTST_e39617f0f094a322d4157f34fe424dadStructure>
 tmpoutParamUserRolesList1List = new List<ssConectaProveedores.RestRecords.RESTST_e39617f0f094a322d4157f34fe424dadStructure>
();
try {outParamUserRolesList.StartIteration();
while (!(outParamUserRolesList.Eof)) {
// Write the needed fields of the record outParamUserRolesList.CurrentRec to the tmpoutParamUserRolesListElement
tmpoutParamUserRolesListElement = new ssConectaProveedores.RestRecords.RESTST_e39617f0f094a322d4157f34fe424dadStructure();
// Write optimized tmpoutParamUserRolesListElement.AttrApplicationRoleId
tmpoutParamUserRolesListElement.AttrApplicationRoleId = (long?) 0L;
// Write optimized tmpoutParamUserRolesListElement.AttrRoleName
tmpoutParamUserRolesListElement.AttrRoleName = "";
// Write optimized tmpoutParamUserRolesListElement.AttrCode
tmpoutParamUserRolesListElement.AttrCode = "";
// Write optimized tmpoutParamUserRolesListElement.AttrIsSubstitute
tmpoutParamUserRolesListElement.AttrIsSubstitute = (bool?) false;
tmpoutParamUserRolesList1List.Add(tmpoutParamUserRolesListElement);
outParamUserRolesList.Advance();
}

} finally {
outParamUserRolesList.EndIteration();
}

result.outParamUserRolesList = new RestList<ssConectaProveedores.RestRecords.RESTST_e39617f0f094a322d4157f34fe424dadStructure>(tmpoutParamUserRolesList1List.ToArray(), default(ssConectaProveedores.RestRecords.RESTST_e39617f0f094a322d4157f34fe424dadStructure));
}

result.outParamIsAuditor = (bool?) outParamIsAuditor;
// Write optimized result.outParamSupplierId
result.outParamSupplierId = (long?) 0L;
result.outParamUserRegion = (long?) outParamUserRegion;
result.outParamIsAllRegions = (bool?) outParamIsAllRegions;
return result;
}


    public static ConectaProveedores_g_Reports_SupplierInvoicesReport_DataActionGetUserApplicationRoles_Model ToModel(RESTConectaProveedores_g_Reports_SupplierInvoicesReport_DataActionGetUserApplicationRoles_Outputs variables) {ConectaProveedores_g_Reports_SupplierInvoicesReport_DataActionGetUserApplicationRoles_Model result = new ConectaProveedores_g_Reports_SupplierInvoicesReport_DataActionGetUserApplicationRoles_Model();
result.outParamUserRolesList = variables == null ? new RL_97ac86b141c7934fd96d3cf71793066e() : RL_97ac86b141c7934fd96d3cf71793066e.FromRestList(variables.outParamUserRolesList, ssConectaProveedores.RestRecords.RESTST_e39617f0f094a322d4157f34fe424dadStructure.ToStructure);
result.outParamIsAuditor = variables == null || variables.outParamIsAuditor == null ? false : variables.outParamIsAuditor.Value;
result.outParamSupplierId = variables == null || variables.outParamSupplierId == null ? 0L : variables.outParamSupplierId.Value;
result.outParamUserRegion = variables == null || variables.outParamUserRegion == null ? 0L : variables.outParamUserRegion.Value;
result.outParamIsAllRegions = variables == null || variables.outParamIsAllRegions == null ? false : variables.outParamIsAllRegions.Value;
return result;
}


    public static RESTConectaProveedores_g_Reports_SupplierInvoicesReport_DataActionGetUserApplicationRoles_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_g_Reports_SupplierInvoicesReport_DataActionGetUserApplicationRoles_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_g_Reports_SupplierInvoicesReport_DataActionGetUserApplicationRoles_Outputs result = new RESTConectaProveedores_g_Reports_SupplierInvoicesReport_DataActionGetUserApplicationRoles_Outputs();
result.outParamUserRolesList = screenModel.outParamUserRolesList.ToRestList<ssConectaProveedores.RestRecords.RESTST_e39617f0f094a322d4157f34fe424dadStructure>(ssConectaProveedores.RestRecords.RESTST_e39617f0f094a322d4157f34fe424dadStructure.FromStructureDelegate(conf));
result.outParamIsAuditor = (bool?) screenModel.outParamIsAuditor;
result.outParamSupplierId = (long?) screenModel.outParamSupplierId;
result.outParamUserRegion = (long?) screenModel.outParamUserRegion;
result.outParamIsAllRegions = (bool?) screenModel.outParamIsAllRegions;
return result;
}

}
