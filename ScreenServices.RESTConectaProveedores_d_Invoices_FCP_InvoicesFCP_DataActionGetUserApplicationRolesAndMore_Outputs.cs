using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_d_Invoices_FCP_InvoicesFCP_DataActionGetUserApplicationRolesAndMore_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("UserRolesList")]
public RestList<ssConectaProveedores.RestRecords.RESTST_e39617f0f094a322d4157f34fe424dadStructure> outParamUserRolesList;
[JsonProperty("IsCorporativoCxP")]
public bool? outParamIsCorporativoCxP;
[JsonProperty("AppRolesListText")]
public string outParamAppRolesListText;
[JsonProperty("TelcelDirectionsListText")]
public string outParamTelcelDirectionsListText;
[JsonProperty("IsSupervisor")]
public bool? outParamIsSupervisor;
[JsonProperty("CorporativoRegionId")]
public long? outParamCorporativoRegionId;
[JsonProperty("TelcelDirectionsListTextForQuery")]
public string outParamTelcelDirectionsListTextForQuery;
[JsonProperty("IsCxP")]
public bool? outParamIsCxP;


    public static RESTConectaProveedores_d_Invoices_FCP_InvoicesFCP_DataActionGetUserApplicationRolesAndMore_Outputs FromOutputs(IBehaviorsConfiguration conf, RL_97ac86b141c7934fd96d3cf71793066e outParamUserRolesList, bool outParamIsCorporativoCxP, string outParamAppRolesListText, string outParamTelcelDirectionsListText, bool outParamIsSupervisor, long outParamCorporativoRegionId, string outParamTelcelDirectionsListTextForQuery, bool outParamIsCxP) {RESTConectaProveedores_d_Invoices_FCP_InvoicesFCP_DataActionGetUserApplicationRolesAndMore_Outputs result = new RESTConectaProveedores_d_Invoices_FCP_InvoicesFCP_DataActionGetUserApplicationRolesAndMore_Outputs();
// Write the needed fields of the list outParamUserRolesList to the result.outParamUserRolesList
ssConectaProveedores.RestRecords.RESTST_e39617f0f094a322d4157f34fe424dadStructure tmpoutParamUserRolesListElement;
if(outParamUserRolesList.Empty) {
// Write the needed fields of the record outParamUserRolesList.CurrentRec to the tmpoutParamUserRolesListElement
tmpoutParamUserRolesListElement = new ssConectaProveedores.RestRecords.RESTST_e39617f0f094a322d4157f34fe424dadStructure();
tmpoutParamUserRolesListElement.AttrApplicationRoleId = (long?) outParamUserRolesList.CurrentRec.ssApplicationRoleId;
tmpoutParamUserRolesListElement.AttrRoleName = outParamUserRolesList.CurrentRec.ssRoleName;
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
tmpoutParamUserRolesListElement.AttrApplicationRoleId = (long?) outParamUserRolesList.CurrentRec.ssApplicationRoleId;
tmpoutParamUserRolesListElement.AttrRoleName = outParamUserRolesList.CurrentRec.ssRoleName;
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

result.outParamIsCorporativoCxP = (bool?) outParamIsCorporativoCxP;
// Write optimized result.outParamAppRolesListText
result.outParamAppRolesListText = "";
// Write optimized result.outParamTelcelDirectionsListText
result.outParamTelcelDirectionsListText = "";
// Write optimized result.outParamIsSupervisor
result.outParamIsSupervisor = (bool?) false;
// Write optimized result.outParamCorporativoRegionId
result.outParamCorporativoRegionId = (long?) 0L;
// Write optimized result.outParamTelcelDirectionsListTextForQuery
result.outParamTelcelDirectionsListTextForQuery = "";
result.outParamIsCxP = (bool?) outParamIsCxP;
return result;
}


    public static ConectaProveedores_d_Invoices_FCP_InvoicesFCP_DataActionGetUserApplicationRolesAndMore_Model ToModel(RESTConectaProveedores_d_Invoices_FCP_InvoicesFCP_DataActionGetUserApplicationRolesAndMore_Outputs variables) {ConectaProveedores_d_Invoices_FCP_InvoicesFCP_DataActionGetUserApplicationRolesAndMore_Model result = new ConectaProveedores_d_Invoices_FCP_InvoicesFCP_DataActionGetUserApplicationRolesAndMore_Model();
result.outParamUserRolesList = variables == null ? new RL_97ac86b141c7934fd96d3cf71793066e() : RL_97ac86b141c7934fd96d3cf71793066e.FromRestList(variables.outParamUserRolesList, ssConectaProveedores.RestRecords.RESTST_e39617f0f094a322d4157f34fe424dadStructure.ToStructure);
result.outParamIsCorporativoCxP = variables == null || variables.outParamIsCorporativoCxP == null ? false : variables.outParamIsCorporativoCxP.Value;
result.outParamAppRolesListText = variables == null || variables.outParamAppRolesListText == null ? "" : variables.outParamAppRolesListText;
result.outParamTelcelDirectionsListText = variables == null || variables.outParamTelcelDirectionsListText == null ? "" : variables.outParamTelcelDirectionsListText;
result.outParamIsSupervisor = variables == null || variables.outParamIsSupervisor == null ? false : variables.outParamIsSupervisor.Value;
result.outParamCorporativoRegionId = variables == null || variables.outParamCorporativoRegionId == null ? 0L : variables.outParamCorporativoRegionId.Value;
result.outParamTelcelDirectionsListTextForQuery = variables == null || variables.outParamTelcelDirectionsListTextForQuery == null ? "" : variables.outParamTelcelDirectionsListTextForQuery;
result.outParamIsCxP = variables == null || variables.outParamIsCxP == null ? false : variables.outParamIsCxP.Value;
return result;
}


    public static RESTConectaProveedores_d_Invoices_FCP_InvoicesFCP_DataActionGetUserApplicationRolesAndMore_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_d_Invoices_FCP_InvoicesFCP_DataActionGetUserApplicationRolesAndMore_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_d_Invoices_FCP_InvoicesFCP_DataActionGetUserApplicationRolesAndMore_Outputs result = new RESTConectaProveedores_d_Invoices_FCP_InvoicesFCP_DataActionGetUserApplicationRolesAndMore_Outputs();
result.outParamUserRolesList = screenModel.outParamUserRolesList.ToRestList<ssConectaProveedores.RestRecords.RESTST_e39617f0f094a322d4157f34fe424dadStructure>(ssConectaProveedores.RestRecords.RESTST_e39617f0f094a322d4157f34fe424dadStructure.FromStructureDelegate(conf));
result.outParamIsCorporativoCxP = (bool?) screenModel.outParamIsCorporativoCxP;
result.outParamAppRolesListText = screenModel.outParamAppRolesListText;
result.outParamTelcelDirectionsListText = screenModel.outParamTelcelDirectionsListText;
result.outParamIsSupervisor = (bool?) screenModel.outParamIsSupervisor;
result.outParamCorporativoRegionId = (long?) screenModel.outParamCorporativoRegionId;
result.outParamTelcelDirectionsListTextForQuery = screenModel.outParamTelcelDirectionsListTextForQuery;
result.outParamIsCxP = (bool?) screenModel.outParamIsCxP;
return result;
}

}
