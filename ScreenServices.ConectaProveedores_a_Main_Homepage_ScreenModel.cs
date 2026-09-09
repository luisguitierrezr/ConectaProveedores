using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_a_Main_Homepage_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_a_Main_Homepage_ScreenModel).Namespace);

    public bool varLcShowPopup;
public long varLcl_ManualId;
public ConectaProveedores_a_Main_Homepage_DataActionGetManuals2_Model varLcGetManuals2;
public ConectaProveedores_a_Main_Homepage_DataActionGetUserApplicationRolesAndMore_Model varLcGetUserApplicationRolesAndMore;
public ConectaProveedores_a_Main_Homepage_DataActionGetRequisitionsKPI_Model varLcGetRequisitionsKPI;
public ConectaProveedores_a_Main_Homepage_DataActionGetInvoicesKPI_Model varLcGetInvoicesKPI;
public ConectaProveedores_a_Main_Homepage_DataActionGetFoliosKPI_Model varLcGetFoliosKPI;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_a_Main_Homepage_ScreenModel() {
}



    public ConectaProveedores_a_Main_Homepage_ScreenModel(bool varLcShowPopup, long varLcl_ManualId, ConectaProveedores_a_Main_Homepage_DataActionGetManuals2_Model varLcGetManuals2, ConectaProveedores_a_Main_Homepage_DataActionGetUserApplicationRolesAndMore_Model varLcGetUserApplicationRolesAndMore, ConectaProveedores_a_Main_Homepage_DataActionGetRequisitionsKPI_Model varLcGetRequisitionsKPI, ConectaProveedores_a_Main_Homepage_DataActionGetInvoicesKPI_Model varLcGetInvoicesKPI, ConectaProveedores_a_Main_Homepage_DataActionGetFoliosKPI_Model varLcGetFoliosKPI, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"ShowPopup", "l_ManualId", "GetManuals2", "GetUserApplicationRolesAndMore", "GetRequisitionsKPI", "GetInvoicesKPI", "GetFoliosKPI", "ClientVars"}, new string[] {"varLcShowPopup", "varLcl_ManualId", "varLcGetManuals2", "varLcGetUserApplicationRolesAndMore", "varLcGetRequisitionsKPI", "varLcGetInvoicesKPI", "varLcGetFoliosKPI", "clientVariables"});
this.varLcShowPopup = varLcShowPopup;
this.varLcl_ManualId = varLcl_ManualId;
this.varLcGetManuals2 = varLcGetManuals2;
this.varLcGetUserApplicationRolesAndMore = varLcGetUserApplicationRolesAndMore;
this.varLcGetRequisitionsKPI = varLcGetRequisitionsKPI;
this.varLcGetInvoicesKPI = varLcGetInvoicesKPI;
this.varLcGetFoliosKPI = varLcGetFoliosKPI;
this.clientVariables = clientVariables;
}



    

    public class lcvGetManuals2 : VarsBag {
public RL_942b1ced293ccdcd219668b20e3afeb8 queryResGetManuals_outParamList = new RL_942b1ced293ccdcd219668b20e3afeb8();
public long queryResGetManuals_outParamCount = 0L;

public lcvGetManuals2() {
}
}
public class lcoGetManuals2 : VarsBag {
public RL_942b1ced293ccdcd219668b20e3afeb8 outParamManualsList = new RL_942b1ced293ccdcd219668b20e3afeb8();

public bool outParamShowViewAll = false;

public lcoGetManuals2() {
}
}
/// <summary>
/// Action <code>GetManuals2</code> that represents the Service Studio action <code>GetManuals2</code>
///  <p> Description: </p>
/// </summary>
public async Task<(RL_942b1ced293ccdcd219668b20e3afeb8,bool)> DataActionGetManuals2(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_942b1ced293ccdcd219668b20e3afeb8 outParamManualsList = default;
bool outParamShowViewAll = default;
lcoGetManuals2 result = new lcoGetManuals2();
lcvGetManuals2 localVars = new lcvGetManuals2();
ConectaProveedores_a_Main_Homepage_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetManuals2", "28d37925-d77b-4d86-8653-7486e0ecc557"))
using (activitySource.CreateScreenDataActionActivity("Homepage", "GetManuals2")){
// Query datasetGetManuals
cancellationToken.ThrowIfCancellationRequested();
int datasetGetManuals_maxRecords = 4;
if (datasetGetManuals_maxRecords < 1) datasetGetManuals_maxRecords = 1;
int datasetGetManuals_startIndex = 0;(localVars.queryResGetManuals_outParamList,localVars.queryResGetManuals_outParamCount) = await FuncDataActionGetManuals2.datasetGetManuals(requestContext,datasetGetManuals_maxRecords,datasetGetManuals_startIndex,IterationMultiplicity.Multiple,(await Functions.ssCheckProveedorRole(requestContext,"",cancellationToken)),varLcGetUserApplicationRolesAndMore.outParamIsAreaCxP,cancellationToken);

// ManualsList = GetManuals.List
result.outParamManualsList=localVars.queryResGetManuals_outParamList;

// ShowViewAll = GetManuals.Count > 4
result.outParamShowViewAll=(localVars.queryResGetManuals_outParamCount>Convert.ToInt64(4));
} //close CreateActionActivity using block
} // try

finally {
outParamManualsList = result.outParamManualsList;
outParamShowViewAll = result.outParamShowViewAll;
} // inner-finally
RETURN_STATEMENT:
return (outParamManualsList,outParamShowViewAll);
}
public class lcvGetUserApplicationRolesAndMore : VarsBag {
public int resFindIsCorporativoCxP_outParamPosition = 0;

public RL_721bdfcca4a4edbce82baece8dfe837b queryResGetRoleConcept_outParamList = new RL_721bdfcca4a4edbce82baece8dfe837b();
public long queryResGetRoleConcept_outParamCount = 0L;

public RL_4b6f9359ce9887bc6f37c96ecf62266d queryResGetSegmentAccGroupTelcelDirectionsByDepartment_outParamList = new RL_4b6f9359ce9887bc6f37c96ecf62266d();
public long queryResGetSegmentAccGroupTelcelDirectionsByDepartment_outParamCount = 0L;

public lcvGetUserApplicationRolesAndMore() {
}
}
public class lcoGetUserApplicationRolesAndMore : VarsBag {
public RL_97ac86b141c7934fd96d3cf71793066e outParamUserRolesList = new RL_97ac86b141c7934fd96d3cf71793066e();

public bool outParamIsCorporativoCxP = false;

public string outParamAppRolesListText = "";

public string outParamTelcelDirectionsListText = "";

public bool outParamIsAreaCxP = false;

public bool outParamIsActiveDEV_Dashboard = false;

public lcoGetUserApplicationRolesAndMore() {
}
}
/// <summary>
/// Action <code>GetUserApplicationRolesAndMore</code> that represents the Service Studio action
///  <code>GetUserApplicationRolesAndMore</code> <p> Description: </p>
/// </summary>
public async Task<(RL_97ac86b141c7934fd96d3cf71793066e,bool,string,string,bool,bool)> DataActionGetUserApplicationRolesAndMore(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_97ac86b141c7934fd96d3cf71793066e outParamUserRolesList = default;
bool outParamIsCorporativoCxP = default;
string outParamAppRolesListText = default;
string outParamTelcelDirectionsListText = default;
bool outParamIsAreaCxP = default;
bool outParamIsActiveDEV_Dashboard = default;
lcoGetUserApplicationRolesAndMore result = new lcoGetUserApplicationRolesAndMore();
lcvGetUserApplicationRolesAndMore localVars = new lcvGetUserApplicationRolesAndMore();
ConectaProveedores_a_Main_Homepage_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetUserApplicationRolesAndMore", "2bad5bf1-ded1-4594-8171-f02fe51b5323"))
using (activitySource.CreateScreenDataActionActivity("Homepage", "GetUserApplicationRolesAndMore")){
// IsActiveDEV_Dashboard = IsActiveDEV_Dashboard
result.outParamIsActiveDEV_Dashboard=((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveDEV_Dashboard])));
// Query datasetGetRoleConcept
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRoleConcept_maxRecords = 0;
int datasetGetRoleConcept_startIndex = 0;(localVars.queryResGetRoleConcept_outParamList,localVars.queryResGetRoleConcept_outParamCount) = await FuncDataActionGetUserApplicationRolesAndMore.datasetGetRoleConcept(requestContext,datasetGetRoleConcept_maxRecords,datasetGetRoleConcept_startIndex,IterationMultiplicity.Multiple,BuiltInFunction.GetUserId (),cancellationToken);

// UserRolesList = GetRoleConcept.List
result.outParamUserRolesList=(await RL_97ac86b141c7934fd96d3cf71793066e.ConvertAsync(localVars.queryResGetRoleConcept_outParamList, new RL_97ac86b141c7934fd96d3cf71793066e(), async (RC_6d4a92ad9e5239e9c12dd070f5b17d69 source, ST_e39617f0f094a322d4157f34fe424dadStructure target, CancellationToken cancellationToken) => {
target.ssApplicationRoleId = source.ssENRoleConcept.ssApplicationRoleId;
target.ssRoleName = source.ssENApplicationRole.ssName;
target.ssCode = source.ssENApplicationRole.ssCode;
target.ssIsSubstitute = false;
return target;
}, cancellationToken));
// FindIsCorporativoCxP
localVars.resFindIsCorporativoCxP_outParamPosition = await ExtendedActions.ListIndexOf(requestContext,localVars.queryResGetRoleConcept_outParamList,async (p, cancellationToken) => ((p.ssENRegion.ssCommissionRegion=="R0")&&p.ssENApplicationRole.ssIsAreaCxP),cancellationToken);

// IsCorporativoCxP = FindIsCorporativoCxP.Position <> -1
result.outParamIsCorporativoCxP=(localVars.resFindIsCorporativoCxP_outParamPosition!=(-1));

// TelcelDirectionsListText = ""
result.outParamTelcelDirectionsListText="";

// IsAreaCxP = GetRoleConcept.List.Current.EntraRole.IsAreaCxP
result.outParamIsAreaCxP=localVars.queryResGetRoleConcept_outParamList.CurrentRec.ssENEntraRole.ssIsAreaCxP;
// Foreach UserRolesList
result.outParamUserRolesList.StartIteration();
try {while (!((result.outParamUserRolesList.Eof))) {
// AppRolesListText = AppRolesListText + "," + UserRolesList.Current.ApplicationRoleId
result.outParamAppRolesListText=((result.outParamAppRolesListText+",")+BuiltInFunction.LongIntegerToText(result.outParamUserRolesList.CurrentRec.ssApplicationRoleId));
result.outParamUserRolesList.Advance();
}

} finally {
result.outParamUserRolesList.EndIteration();
}

// AppRolesListText = Substr
result.outParamAppRolesListText=BuiltInFunction.SubstrSC (result.outParamAppRolesListText, 1, BuiltInFunction.LengthSC (result.outParamAppRolesListText));
if((result.outParamIsCorporativoCxP)) {
// Query datasetGetSegmentAccGroupTelcelDirectionsByDepartment
cancellationToken.ThrowIfCancellationRequested();
int datasetGetSegmentAccGroupTelcelDirectionsByDepartment_maxRecords = 0;
int datasetGetSegmentAccGroupTelcelDirectionsByDepartment_startIndex = 0;(localVars.queryResGetSegmentAccGroupTelcelDirectionsByDepartment_outParamList,localVars.queryResGetSegmentAccGroupTelcelDirectionsByDepartment_outParamCount) = await FuncDataActionGetUserApplicationRolesAndMore.datasetGetSegmentAccGroupTelcelDirectionsByDepartment(requestContext,datasetGetSegmentAccGroupTelcelDirectionsByDepartment_maxRecords,datasetGetSegmentAccGroupTelcelDirectionsByDepartment_startIndex,IterationMultiplicity.Single,(await Functions.ActionGetUserDepartmentName(requestContext,"",cancellationToken)),cancellationToken);

// Foreach GetSegmentAccGroupTelcelDirectionsByDepartment.List
localVars.queryResGetSegmentAccGroupTelcelDirectionsByDepartment_outParamList.StartIteration();
try {while (!((localVars.queryResGetSegmentAccGroupTelcelDirectionsByDepartment_outParamList.Eof))) {
// TelcelDirectionsListText = TelcelDirectionsListText + "," + GetSegmentAccGroupTelcelDirectionsByDepartment.List.Current.SegmentAccGroupTelcelDir.TelcelDirectionId
result.outParamTelcelDirectionsListText=((result.outParamTelcelDirectionsListText+",")+BuiltInFunction.LongIntegerToText(localVars.queryResGetSegmentAccGroupTelcelDirectionsByDepartment_outParamList.CurrentRec.ssENSegmentAccGroupTelcelDir.ssTelcelDirectionId));
localVars.queryResGetSegmentAccGroupTelcelDirectionsByDepartment_outParamList.Advance();
}

} finally {
localVars.queryResGetSegmentAccGroupTelcelDirectionsByDepartment_outParamList.EndIteration();
}

// TelcelDirectionsListText = Substr
result.outParamTelcelDirectionsListText=BuiltInFunction.SubstrSC (result.outParamTelcelDirectionsListText, 1, BuiltInFunction.LengthSC (result.outParamTelcelDirectionsListText));
}

} //close CreateActionActivity using block
} // try

finally {
outParamUserRolesList = result.outParamUserRolesList;
outParamIsCorporativoCxP = result.outParamIsCorporativoCxP;
outParamAppRolesListText = result.outParamAppRolesListText;
outParamTelcelDirectionsListText = result.outParamTelcelDirectionsListText;
outParamIsAreaCxP = result.outParamIsAreaCxP;
outParamIsActiveDEV_Dashboard = result.outParamIsActiveDEV_Dashboard;
} // inner-finally
RETURN_STATEMENT:
return (outParamUserRolesList,outParamIsCorporativoCxP,outParamAppRolesListText,outParamTelcelDirectionsListText,outParamIsAreaCxP,outParamIsActiveDEV_Dashboard);
}
public class lcvGetRequisitionsKPI : VarsBag {
public RL_11e68f59508e412eaf5b78801dd06b0e queryResGetRequisitionsDataCaptureCount_outParamList = new RL_11e68f59508e412eaf5b78801dd06b0e();
public long queryResGetRequisitionsDataCaptureCount_outParamCount = 0L;

public Actions.lcoGetRequisitionCount resGetRequisitionCount =  new Actions.lcoGetRequisitionCount();
public RL_0b9ed344d44b60e0112a22c99132ee6b queryResGetRequisitionCounts_outParamList = new RL_0b9ed344d44b60e0112a22c99132ee6b();
public long queryResGetRequisitionCounts_outParamCount = 0L;

public lcvGetRequisitionsKPI() {
}
}
public class lcoGetRequisitionsKPI : VarsBag {
public RL_7d9c239ab2336eba85802eb00151e260 outParamo_RequisitionCounts = new RL_7d9c239ab2336eba85802eb00151e260();

public lcoGetRequisitionsKPI() {
}
}
/// <summary>
/// Action <code>GetRequisitionsKPI</code> that represents the Service Studio action
///  <code>GetRequisitionsKPI</code> <p> Description: </p>
/// </summary>
public async Task<RL_7d9c239ab2336eba85802eb00151e260> DataActionGetRequisitionsKPI(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_7d9c239ab2336eba85802eb00151e260 outParamo_RequisitionCounts = default;
lcoGetRequisitionsKPI result = new lcoGetRequisitionsKPI();
lcvGetRequisitionsKPI localVars = new lcvGetRequisitionsKPI();
ConectaProveedores_a_Main_Homepage_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetRequisitionsKPI", "73b69f48-7e8e-4222-a0c2-647c231c8fcb"))
using (activitySource.CreateScreenDataActionActivity("Homepage", "GetRequisitionsKPI")){
// not proveedor
if(((!(await Functions.ssCheckProveedorRole(requestContext,"",cancellationToken))))) {
// GetRequisitionCount
localVars.resGetRequisitionCount.outParamHomepageKPI = await Actions.ActionGetRequisitionCount(requestContext,cancellationToken);

// ListAppendAll2
await ExtendedActions.ListAppendAll(requestContext,result.outParamo_RequisitionCounts,(await RL_7d9c239ab2336eba85802eb00151e260.ConvertAsync(localVars.resGetRequisitionCount.outParamHomepageKPI, new RL_7d9c239ab2336eba85802eb00151e260(), async (ST_0c64d21ad7602c08489bb9a5fcfb0fe0Structure source, ST_34313c5cf94d7ce3c5404858c22fafd9Structure target, CancellationToken cancellationToken) => {
target.ssValue = (((decimal)source.ssCount));
target.ssLabel = ((Convert.ToString(source.ssCount)+" ")+source.ssLabel);
target.ssTooltip = ((source.ssLabel+": ")+Convert.ToString(source.ssCount));
return target;
}, cancellationToken)),cancellationToken);

} else {
// Query QueryGetRequisitionCounts
cancellationToken.ThrowIfCancellationRequested();
int QueryGetRequisitionCounts_maxRecords = 0;
int QueryGetRequisitionCounts_startIndex = 0;(localVars.queryResGetRequisitionCounts_outParamList,localVars.queryResGetRequisitionCounts_outParamCount) = await FuncDataActionGetRequisitionsKPI.QueryGetRequisitionCounts(requestContext,QueryGetRequisitionCounts_maxRecords,QueryGetRequisitionCounts_startIndex,IterationMultiplicity.Multiple,BuiltInFunction.GetUserId (),(ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId,(((varLcGetUserApplicationRolesAndMore.outParamAppRolesListText=="")) ? ("(0)") : ((("("+varLcGetUserApplicationRolesAndMore.outParamAppRolesListText)+")"))),(await Functions.ActionGetUserRegionId(requestContext,"",cancellationToken)),(varLcGetUserApplicationRolesAndMore.outParamAppRolesListText==""),(ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("fEmjvBqEH0eHrf5_YVeo0g"))).ssId,cancellationToken);

// ListAppendAll
await ExtendedActions.ListAppendAll(requestContext,result.outParamo_RequisitionCounts,(await RL_7d9c239ab2336eba85802eb00151e260.ConvertAsync(localVars.queryResGetRequisitionCounts_outParamList, new RL_7d9c239ab2336eba85802eb00151e260(), async (RC_073e413c5402df3d82c2d65d0628594a source, ST_34313c5cf94d7ce3c5404858c22fafd9Structure target, CancellationToken cancellationToken) => {
target.ssValue = (((decimal)source.ssSTHomepageKPI.ssCount));
target.ssLabel = ((Convert.ToString(source.ssSTHomepageKPI.ssCount)+" ")+source.ssSTHomepageKPI.ssLabel);
target.ssTooltip = ((source.ssSTHomepageKPI.ssLabel+": ")+Convert.ToString(source.ssSTHomepageKPI.ssCount));
return target;
}, cancellationToken)),cancellationToken);

}

// Query datasetGetRequisitionsDataCaptureCount
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionsDataCaptureCount_maxRecords = 0;
int datasetGetRequisitionsDataCaptureCount_startIndex = 0;(localVars.queryResGetRequisitionsDataCaptureCount_outParamList,localVars.queryResGetRequisitionsDataCaptureCount_outParamCount) = await FuncDataActionGetRequisitionsKPI.datasetGetRequisitionsDataCaptureCount(requestContext,datasetGetRequisitionsDataCaptureCount_maxRecords,datasetGetRequisitionsDataCaptureCount_startIndex,IterationMultiplicity.Never,BuiltInFunction.GetUserId (),cancellationToken);

if((!((localVars.queryResGetRequisitionsDataCaptureCount_outParamList.CurrentRec.ssCount<=Convert.ToInt64(0))))) {
// ListAppend
await ExtendedActions.ListAppend(requestContext,result.outParamo_RequisitionCounts,new ST_34313c5cf94d7ce3c5404858c22fafd9Structure(){ ssValue = (((decimal)localVars.queryResGetRequisitionsDataCaptureCount_outParamList.CurrentRec.ssCount)), ssLabel = ((BuiltInFunction.LongIntegerToText(localVars.queryResGetRequisitionsDataCaptureCount_outParamList.CurrentRec.ssCount)+" ")+AppUtils.GetStringResource("fPh2My0Kp0qikUy3R975_g#Value.-715459376.1", "Data Capture")), ssTooltip = ((AppUtils.GetStringResource("rijCRjuAaU+8tZsGo093ew#Value.-715459376.1", "Data Capture")+": ")+BuiltInFunction.LongIntegerToText(localVars.queryResGetRequisitionsDataCaptureCount_outParamList.CurrentRec.ssCount)) },cancellationToken);

}

} //close CreateActionActivity using block
} // try

finally {
outParamo_RequisitionCounts = result.outParamo_RequisitionCounts;
} // inner-finally
RETURN_STATEMENT:
return outParamo_RequisitionCounts;
}
public class lcvGetInvoicesKPI : VarsBag {
public Actions.lcoGetInvoiceCount resGetInvoiceCount =  new Actions.lcoGetInvoiceCount();
public lcvGetInvoicesKPI() {
}
}
public class lcoGetInvoicesKPI : VarsBag {
public RL_7d9c239ab2336eba85802eb00151e260 outParamo_InvoiceCounts = new RL_7d9c239ab2336eba85802eb00151e260();

public lcoGetInvoicesKPI() {
}
}
/// <summary>
/// Action <code>GetInvoicesKPI</code> that represents the Service Studio action
///  <code>GetInvoicesKPI</code> <p> Description: </p>
/// </summary>
public async Task<RL_7d9c239ab2336eba85802eb00151e260> DataActionGetInvoicesKPI(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_7d9c239ab2336eba85802eb00151e260 outParamo_InvoiceCounts = default;
lcoGetInvoicesKPI result = new lcoGetInvoicesKPI();
lcvGetInvoicesKPI localVars = new lcvGetInvoicesKPI();
ConectaProveedores_a_Main_Homepage_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetInvoicesKPI", "757f0ede-ecb8-4ea4-b912-750c1a10d75b"))
using (activitySource.CreateScreenDataActionActivity("Homepage", "GetInvoicesKPI")){
// GetInvoiceCount
localVars.resGetInvoiceCount.outParamHomepageKPI = await Actions.ActionGetInvoiceCount(requestContext,cancellationToken);

// ListAppendAll3
await ExtendedActions.ListAppendAll(requestContext,result.outParamo_InvoiceCounts,(await RL_7d9c239ab2336eba85802eb00151e260.ConvertAsync(localVars.resGetInvoiceCount.outParamHomepageKPI, new RL_7d9c239ab2336eba85802eb00151e260(), async (ST_0c64d21ad7602c08489bb9a5fcfb0fe0Structure source, ST_34313c5cf94d7ce3c5404858c22fafd9Structure target, CancellationToken cancellationToken) => {
target.ssValue = (((decimal)source.ssCount));
target.ssLabel = ((Convert.ToString(source.ssCount)+" ")+source.ssLabel);
target.ssTooltip = ((source.ssLabel+": ")+Convert.ToString(source.ssCount));
return target;
}, cancellationToken)),cancellationToken);

} //close CreateActionActivity using block
} // try

finally {
outParamo_InvoiceCounts = result.outParamo_InvoiceCounts;
} // inner-finally
RETURN_STATEMENT:
return outParamo_InvoiceCounts;
}
public class lcvGetFoliosKPI : VarsBag {
public Actions.lcoGetFolioCount resGetFolioCount =  new Actions.lcoGetFolioCount();
public RL_0b9ed344d44b60e0112a22c99132ee6b queryResGetOrderCounts_outParamList = new RL_0b9ed344d44b60e0112a22c99132ee6b();
public long queryResGetOrderCounts_outParamCount = 0L;

public lcvGetFoliosKPI() {
}
}
public class lcoGetFoliosKPI : VarsBag {
public RL_7d9c239ab2336eba85802eb00151e260 outParamo_OrderCounts = new RL_7d9c239ab2336eba85802eb00151e260();

public lcoGetFoliosKPI() {
}
}
/// <summary>
/// Action <code>GetFoliosKPI</code> that represents the Service Studio action
///  <code>GetFoliosKPI</code> <p> Description: </p>
/// </summary>
public async Task<RL_7d9c239ab2336eba85802eb00151e260> DataActionGetFoliosKPI(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_7d9c239ab2336eba85802eb00151e260 outParamo_OrderCounts = default;
lcoGetFoliosKPI result = new lcoGetFoliosKPI();
lcvGetFoliosKPI localVars = new lcvGetFoliosKPI();
ConectaProveedores_a_Main_Homepage_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetFoliosKPI", "957acbca-e854-4252-92a5-f7e84a67e7d1"))
using (activitySource.CreateScreenDataActionActivity("Homepage", "GetFoliosKPI")){
if((((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveDEV_Dashboard]))))) {
// GetFolioCount
localVars.resGetFolioCount.outParamHomepageKPI = await Actions.ActionGetFolioCount(requestContext,cancellationToken);

// ListAppendFolios
await ExtendedActions.ListAppendAll(requestContext,result.outParamo_OrderCounts,(await RL_7d9c239ab2336eba85802eb00151e260.ConvertAsync(localVars.resGetFolioCount.outParamHomepageKPI, new RL_7d9c239ab2336eba85802eb00151e260(), async (ST_0c64d21ad7602c08489bb9a5fcfb0fe0Structure source, ST_34313c5cf94d7ce3c5404858c22fafd9Structure target, CancellationToken cancellationToken) => {
target.ssValue = (((decimal)source.ssCount));
target.ssLabel = ((Convert.ToString(source.ssCount)+" ")+source.ssLabel);
target.ssTooltip = ((source.ssLabel+": ")+Convert.ToString(source.ssCount));
return target;
}, cancellationToken)),cancellationToken);

} else {
// Query QueryGetOrderCounts
cancellationToken.ThrowIfCancellationRequested();
int QueryGetOrderCounts_maxRecords = 0;
int QueryGetOrderCounts_startIndex = 0;(localVars.queryResGetOrderCounts_outParamList,localVars.queryResGetOrderCounts_outParamCount) = await FuncDataActionGetFoliosKPI.QueryGetOrderCounts(requestContext,QueryGetOrderCounts_maxRecords,QueryGetOrderCounts_startIndex,IterationMultiplicity.Multiple,BuiltInFunction.GetUserId (),(ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId,(await Functions.ActionGetUserRegionId(requestContext,"",cancellationToken)),(ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("fEmjvBqEH0eHrf5_YVeo0g"))).ssId,(await Functions.ActionGetUserEntraRoleId(requestContext,BuiltInFunction.GetUserId (),cancellationToken)),(await Functions.ActionGetUserTelcelDirectionId(requestContext,"",cancellationToken)),(ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("bxcfUQnAU0CWvUsA+ZfAjw"))).ssId,cancellationToken);

// ListAppendAll
await ExtendedActions.ListAppendAll(requestContext,result.outParamo_OrderCounts,(await RL_7d9c239ab2336eba85802eb00151e260.ConvertAsync(localVars.queryResGetOrderCounts_outParamList, new RL_7d9c239ab2336eba85802eb00151e260(), async (RC_073e413c5402df3d82c2d65d0628594a source, ST_34313c5cf94d7ce3c5404858c22fafd9Structure target, CancellationToken cancellationToken) => {
target.ssValue = (((decimal)source.ssSTHomepageKPI.ssCount));
target.ssLabel = ((Convert.ToString(source.ssSTHomepageKPI.ssCount)+" ")+source.ssSTHomepageKPI.ssLabel);
target.ssTooltip = ((source.ssSTHomepageKPI.ssLabel+": ")+Convert.ToString(source.ssSTHomepageKPI.ssCount));
return target;
}, cancellationToken)),cancellationToken);

}

} //close CreateActionActivity using block
} // try

finally {
outParamo_OrderCounts = result.outParamo_OrderCounts;
} // inner-finally
RETURN_STATEMENT:
return outParamo_OrderCounts;
}


    public static class FuncDataActionGetManuals2 {

private static async Task<RC_0601d361b69aac23601da3c9e115bec5> datasetGetManualsReadDbAsync(RC_0601d361b69aac23601da3c9e115bec5 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssDescription = r.ReadText(index++, "DescriptionShortDescriptionTitleStarIdRecord.Description", "");
rec.ssId = r.ReadEntityReferenceLongInteger(index++, "DescriptionShortDescriptionTitleStarIdRecord.Id", 0L);
rec.ssShortDescription = r.ReadText(index++, "DescriptionShortDescriptionTitleStarIdRecord.ShortDescription", "");
rec.ssStar = r.ReadBoolean(index++, "DescriptionShortDescriptionTitleStarIdRecord.Star", false);
rec.ssTitle = r.ReadText(index++, "DescriptionShortDescriptionTitleStarIdRecord.Title", "");
return rec;
}
// Query Function "GetManuals" O0VW+EIM80e4qFSMXwtg3A of Action "GetManuals2"
public static async Task<(RL_942b1ced293ccdcd219668b20e3afeb8,long)> datasetGetManuals(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckProveedorRole,bool qpboIsAreaCxP,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("a_Main.Homepage.GetManuals2.GetManuals", "f856453b-0c42-47f3-b8a8-548c5f0b60dc");
using var queryActivity = activitySource.CreateAggregateQueryActivity("a_Main.Homepage.GetManuals2.GetManuals", "f856453b-0c42-47f3-b8a8-548c5f0b60dc", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /NRWebFlows.DXvJuqeTzUGsVyrZCiDRvQ/NodesShownInESpaceTree.VVhZnupwY02kx5TZqvmuMQ/DataActions.JXnTKHvXhk2GU3SG4OzFVw/NodesNotShownInESpaceTree.O0VW+EIM80e4qFSMXwtg3A, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enmanuals\".\"description\" \"description\", \"enmanuals\".\"id\" \"id\", \"enmanuals\".\"shortdescription\" \"shortdescription\", \"enmanuals\".\"star\" \"star\", \"enmanuals\".\"title\" \"title\"");
fromBuilder.Append(" FROM ((({Manuals} \"enmanuals\" Left JOIN {Concept} \"enconcept\" ON (\"enmanuals\".\"conceptid\" = \"enconcept\".\"id\"))  Left JOIN {AppConcept} \"enappconcept\" ON (\"enmanuals\".\"appconceptid\" = \"enappconcept\".\"id\"))  Left JOIN {ManualUserArea} \"enmanualuserarea\" ON (\"enmanuals\".\"id\" = \"enmanualuserarea\".\"manualid\")) ");
whereBuilder.Append(" WHERE (1 = 1) AND (\"enmanuals\".\"appconceptid\" = ");
whereBuilder.Append(1
);
whereBuilder.Append(") AND (((@qpboCheckProveedorRole = 1) AND (\"enmanualuserarea\".\"userareaid\" = ");
whereBuilder.Append(3
);
whereBuilder.Append(")) OR ((NOT (@qpboCheckProveedorRole = 1)) AND (((@qpboIsAreaCxP = 1) AND (\"enmanualuserarea\".\"userareaid\" = ");
whereBuilder.Append(2
);
whereBuilder.Append(")) OR (\"enmanualuserarea\".\"userareaid\" = ");
whereBuilder.Append(1
);
whereBuilder.Append(")))) AND (\"enmanuals\".\"star\" = 1)");
groupByBuilder.Append(" GROUP BY \"enmanuals\".\"description\", \"enmanuals\".\"star\", \"enmanuals\".\"shortdescription\", \"enmanuals\".\"title\", \"enmanuals\".\"id\"");
orderByBuilder.Append(" ORDER BY \"title\" ASC ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckProveedorRole", DbType.Boolean, qpboCheckProveedorRole);
sqlCmd.CreateParameterWithoutReplacements("@qpboIsAreaCxP", DbType.Boolean, qpboIsAreaCxP);
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_942b1ced293ccdcd219668b20e3afeb8 outParamList = new RL_942b1ced293ccdcd219668b20e3afeb8();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetManualsReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[0];
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query a_Main.Homepage.GetManuals2.GetManuals.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_942b1ced293ccdcd219668b20e3afeb8 _tmp = new RL_942b1ced293ccdcd219668b20e3afeb8();
_tmp.AlternateReadDbMethodAsync = datasetGetManualsReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query a_Main.Homepage.GetManuals2.GetManuals.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_942b1ced293ccdcd219668b20e3afeb8)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}
}
public static class FuncDataActionGetUserApplicationRolesAndMore {

private static async Task<RC_6d4a92ad9e5239e9c12dd070f5b17d69> datasetGetRoleConceptReadDbAsync(RC_6d4a92ad9e5239e9c12dd070f5b17d69 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApplicationRole.Read( r, ref index);
rec.ssENEntraRole.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENRoleConcept.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
return rec;
}
// Query Function "GetRoleConcept" rWEi3DCV8EiZLtSVxOmexg of Action "GetUserApplicationRolesAndMore"
public static async Task<(RL_721bdfcca4a4edbce82baece8dfe837b,long)> datasetGetRoleConcept(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("a_Main.Homepage.GetUserApplicationRolesAndMore.GetRoleConcept", "dc2261ad-9530-48f0-992e-d495c4e99ec6");
using var queryActivity = activitySource.CreateAggregateQueryActivity("a_Main.Homepage.GetUserApplicationRolesAndMore.GetRoleConcept", "dc2261ad-9530-48f0-992e-d495c4e99ec6", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /NRWebFlows.DXvJuqeTzUGsVyrZCiDRvQ/NodesShownInESpaceTree.VVhZnupwY02kx5TZqvmuMQ/DataActions.8VutK9HelEWBcfAv5RtTIw/NodesNotShownInESpaceTree.rWEi3DCV8EiZLtSVxOmexg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enapplicationrole76\".\"code\" o1, \"enapplicationrole76\".\"name\" o2, NULL o3, NULL o4, \"enapplicationrole76\".\"isareacxp\" o5, NULL o6, NULL o7, NULL o8, NULL o9, \"enentrarole69\".\"isareacxp\" o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, \"enregion167\".\"commissionregion\" o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, \"enroleconcept26\".\"applicationroleid\" o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54");
fromBuilder.Append(" FROM ((((({User_Extended_Internal} \"enuser_extended_internal124\" Inner JOIN {User} \"enuser202\" ON (\"enuser_extended_internal124\".\"id\" = \"enuser202\".\"id\"))  Inner JOIN {EntraRole} \"enentrarole69\" ON (\"enuser_extended_internal124\".\"jobtitle\" = \"enentrarole69\".\"rolename\"))  Left JOIN {Region} \"enregion167\" ON (\"enuser_extended_internal124\".\"regionid\" = \"enregion167\".\"id\"))  Left JOIN {RoleConcept} \"enroleconcept26\" ON (\"enentrarole69\".\"id\" = \"enroleconcept26\".\"entraroleid\"))  Left JOIN {ApplicationRole} \"enapplicationrole76\" ON (\"enroleconcept26\".\"applicationroleid\" = \"enapplicationrole76\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser202\".\"id\" = @qpusUser_Id) AND (\"enuser202\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser202\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (\"enroleconcept26\".\"conceptid\" = ");
whereBuilder.Append(3
);
whereBuilder.Append(")");
orderByBuilder.Append(" ORDER BY \"enapplicationrole76\".\"isareacxp\" DESC ");
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_721bdfcca4a4edbce82baece8dfe837b outParamList = new RL_721bdfcca4a4edbce82baece8dfe837b();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetRoleConceptReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[6];
opt[0] = new BitArray(new bool[] {true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true});
opt[2] = new BitArray(new bool[] {true, false, false, true, true, false, true});
opt[3] = new BitArray(new bool[] {true, true, true, false, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, true, true, true, true, false, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query a_Main.Homepage.GetUserApplicationRolesAndMore.GetRoleConcept.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_721bdfcca4a4edbce82baece8dfe837b _tmp = new RL_721bdfcca4a4edbce82baece8dfe837b();
_tmp.AlternateReadDbMethodAsync = datasetGetRoleConceptReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query a_Main.Homepage.GetUserApplicationRolesAndMore.GetRoleConcept.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_721bdfcca4a4edbce82baece8dfe837b)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}

private static async Task<RC_dbac6e35b37e102dd601262a956066d2> datasetGetSegmentAccGroupTelcelDirectionsByDepartmentReadDbAsync(RC_dbac6e35b37e102dd601262a956066d2 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENSegmentAccGroup.Read( r, ref index);
rec.ssENSegmentAccGroupTelcelDir.Read( r, ref index);
return rec;
}
// Query Function "GetSegmentAccGroupTelcelDirectionsByDepartment" y+aa31K64EyfROc5FgcqMw of Action "GetUserApplicationRolesAndMore"
public static async Task<(RL_4b6f9359ce9887bc6f37c96ecf62266d,long)> datasetGetSegmentAccGroupTelcelDirectionsByDepartment(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteSegmentAccGroup_GroupName,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("a_Main.Homepage.GetUserApplicationRolesAndMore.GetSegmentAccGroupTelcelDirectionsByDepartment", "df9ae6cb-ba52-4ce0-9f44-e73916072a33");
using var queryActivity = activitySource.CreateAggregateQueryActivity("a_Main.Homepage.GetUserApplicationRolesAndMore.GetSegmentAccGroupTelcelDirectionsByDepartment", "df9ae6cb-ba52-4ce0-9f44-e73916072a33", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Single
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /NRWebFlows.DXvJuqeTzUGsVyrZCiDRvQ/NodesShownInESpaceTree.VVhZnupwY02kx5TZqvmuMQ/DataActions.8VutK9HelEWBcfAv5RtTIw/NodesNotShownInESpaceTree.y+aa31K64EyfROc5FgcqMw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, \"ensegmentaccgrouptelceldir11\".\"telceldirectionid\" o9, NULL o10, NULL o11");
fromBuilder.Append(" FROM ({SegmentAccGroup} \"ensegmentaccgroup11\" Left JOIN {SegmentAccGroupTelcelDir} \"ensegmentaccgrouptelceldir11\" ON (\"ensegmentaccgroup11\".\"id\" = \"ensegmentaccgrouptelceldir11\".\"segmentaccgroupid\")) ");
whereBuilder.Append(" WHERE (caseaccent_normalize((trim(\"ensegmentaccgroup11\".\"groupname\")) collate \"default\") like caseaccent_normalize(@qpteSegmentAccGroup_GroupName collate \"default\")) AND (\"ensegmentaccgroup11\".\"isactive\" = 1)");
sqlCmd.CreateParameterWithoutReplacements("@qpteSegmentAccGroup_GroupName", DbType.String, qpteSegmentAccGroup_GroupName);
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_4b6f9359ce9887bc6f37c96ecf62266d outParamList = new RL_4b6f9359ce9887bc6f37c96ecf62266d();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetSegmentAccGroupTelcelDirectionsByDepartmentReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, false, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query a_Main.Homepage.GetUserApplicationRolesAndMore.GetSegmentAccGroupTelcelDirectionsByDepartment.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_4b6f9359ce9887bc6f37c96ecf62266d _tmp = new RL_4b6f9359ce9887bc6f37c96ecf62266d();
_tmp.AlternateReadDbMethodAsync = datasetGetSegmentAccGroupTelcelDirectionsByDepartmentReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query a_Main.Homepage.GetUserApplicationRolesAndMore.GetSegmentAccGroupTelcelDirectionsByDepartment.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_4b6f9359ce9887bc6f37c96ecf62266d)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}
}
public static class FuncDataActionGetRequisitionsKPI {

// Query Function "GetRequisitionsDataCaptureCount" Zl4LGzKPm0uVQOD3roEmyw of Action "GetRequisitionsKPI"
public static async Task<(RL_11e68f59508e412eaf5b78801dd06b0e,long)> datasetGetRequisitionsDataCaptureCount(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusCreatedBy,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("a_Main.Homepage.GetRequisitionsKPI.GetRequisitionsDataCaptureCount", "1b0b5e66-8f32-4b9b-9540-e0f7ae8126cb");
using var queryActivity = activitySource.CreateAggregateQueryActivity("a_Main.Homepage.GetRequisitionsKPI.GetRequisitionsDataCaptureCount", "1b0b5e66-8f32-4b9b-9540-e0f7ae8126cb", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /NRWebFlows.DXvJuqeTzUGsVyrZCiDRvQ/NodesShownInESpaceTree.VVhZnupwY02kx5TZqvmuMQ/DataActions.SJ+2c45+IkKgwmR8IxyPyw/NodesNotShownInESpaceTree.Zl4LGzKPm0uVQOD3roEmyw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT Count(\"enrequisition124\".\"id\") \"count\"");
fromBuilder.Append(" FROM {Requisition} \"enrequisition124\"");
whereBuilder.Append(" WHERE ");
if ((qpusCreatedBy.Trim()!="")) {
whereBuilder.Append("((\"enrequisition124\".\"createdby\" = @qpusCreatedBy) AND (\"enrequisition124\".\"createdby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusCreatedBy", DbType.String, qpusCreatedBy);
} else {
whereBuilder.Append("(\"enrequisition124\".\"createdby\" IS NULL)");
}
whereBuilder.Append(" AND (\"enrequisition124\".\"requisitionstatusid\" = ");
whereBuilder.Append((ENRequisitionStatusEntity.GetRecordByKey(ObjectKey.Parse("pBDtHOXH_kG10TWqeiPa0A"))).ssId);
whereBuilder.Append(")");
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_11e68f59508e412eaf5b78801dd06b0e outParamList = new RL_11e68f59508e412eaf5b78801dd06b0e();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[0];
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query a_Main.Homepage.GetRequisitionsKPI.GetRequisitionsDataCaptureCount.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_11e68f59508e412eaf5b78801dd06b0e _tmp = new RL_11e68f59508e412eaf5b78801dd06b0e();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query a_Main.Homepage.GetRequisitionsKPI.GetRequisitionsDataCaptureCount.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_11e68f59508e412eaf5b78801dd06b0e)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}

// Query Function "GetRequisitionCounts" _fviOvT54EKd30m8KW+pVA of Action "GetRequisitionsKPI"
public static async Task<(RL_0b9ed344d44b60e0112a22c99132ee6b,long)> QueryGetRequisitionCounts(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusi_UserId,int qpapi_NotApprovedStatus,string qptei_UserRoles,long qprei_RegionId,bool qpboi_IsUserRolesEmpty,int qpapi_PendingStatus,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("a_Main.Homepage.GetRequisitionsKPI.GetRequisitionCounts", "3ae2fbfd-f9f4-42e0-9ddf-49bc296fa954");
using var queryActivity = activitySource.CreateSqlQueryActivity("a_Main.Homepage.GetRequisitionsKPI.GetRequisitionCounts", "3ae2fbfd-f9f4-42e0-9ddf-49bc296fa954", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string entityRequisitionApprovalLevel = AppUtils.Instance.RuntimeEntityReplace("RequisitionApprovalLevel");
string entityRequisitionApproval = AppUtils.Instance.RuntimeEntityReplace("RequisitionApproval");
string entityRequisition = AppUtils.Instance.RuntimeEntityReplace("Requisition");
string entityApprovalStatus = AppUtils.Instance.RuntimeEntityReplace("ApprovalStatus");
sqlCmd.CreateParameter("@qpusi_UserId", DbType.String, qpusi_UserId);
sqlCmd.CreateParameter("@qpapi_PendingStatus", DbType.Int32, qpapi_PendingStatus);
sqlCmd.CreateParameter("@qpboi_IsUserRolesEmpty", DbType.Boolean, qpboi_IsUserRolesEmpty);
sqlCmd.CreateParameter("@qprei_RegionId", DbType.Int64, qprei_RegionId);
sqlCmd.CreateParameter("@qpapi_NotApprovedStatus", DbType.Int32, qpapi_NotApprovedStatus);
string sql = "";
string advSql = "SELECT  \n    COUNT(ral.Id) AS ApprovalCount, \n    asl.Label AS ApprovalStatusLabel \nFROM \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,"") + " ral \nINNER JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApproval,"") + " ra ON ral.RequisitionApprovalId = ra.Id \nINNER JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,"") + " req ON ra.RequisitionId = req.Id \nINNER JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,"") + " asl ON ral.ApprovalStatusId = asl.Id \nWHERE \n    ( \n        ral.AssignedTo = @qpusi_UserId \n        AND ral.ApprovalStatusId <> @qpapi_PendingStatus \n    ) \n     \n    OR ( \n        @qpboi_IsUserRolesEmpty = 0 \n        AND ral.ApplicationRoleId IN  " + BaseAppUtils.ReplaceEntityReferencesInParameter(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, AppUtils.Instance.ReplaceAttributeReferences(requestContext,qptei_UserRoles)) + " \n        AND req.RegionId = @qprei_RegionId \n        AND (ral.ApprovalStatusId = @qpapi_NotApprovedStatus) \n    ) \nGROUP BY \n    asl.Label, \n    asl.\"order\" \nORDER BY  \n    asl.\"order\" ASC;";
advSql = BaseAppUtils.ReplaceEntityIdentifiers(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers,advSql);
advSql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
AppUtils.Instance.CheckReadOnlyEntityReferences(advSql);
sql = advSql;
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_0b9ed344d44b60e0112a22c99132ee6b outParamList = new RL_0b9ed344d44b60e0112a22c99132ee6b();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query a_Main.Homepage.GetRequisitionsKPI.GetRequisitionCounts.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_0b9ed344d44b60e0112a22c99132ee6b _tmp = new RL_0b9ed344d44b60e0112a22c99132ee6b();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query a_Main.Homepage.GetRequisitionsKPI.GetRequisitionCounts.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_0b9ed344d44b60e0112a22c99132ee6b)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetRequisitionCounts in GetRequisitionsKPI in Homepage in a_Main in ConectaProveedores (-- SELECT  --     COUNT(CASE   --         WHEN ral.AssignedTo = @i_UserId   --          AND ral.ApprovalStatusId IN (@i_NotApprovedStatus, @i_ToAssignStatus)  --         THEN 1 END) AS ToApproveCount,    --     COUNT(CASE   --         WHEN ral.AssignedTo = @i_UserId   --          AND ral.ApprovalStatusId IN (@i_NotApprovedStatus, @i_ToAssignStatus, @i_CanceledStatus, @i_ModifyStatus, @i_AssignedStatus, @i_ApprovedStatus)   --         THEN 1 END) AS TotalCount  -- FROM {RequisitionApprovalLevel} ral;    SELECT       COUNT(ral.Id) AS ApprovalCount,      asl.Label AS ApprovalStatusLabel  FROM      {RequisitionApprovalLevel} ral  INNER JOIN {RequisitionApproval} ra ON ral.RequisitionApprovalId = ra.Id  INNER JOIN {Requisition} req ON ra.RequisitionId = req.Id  INNER JOIN {ApprovalStatus} asl ON ral.ApprovalStatusId = asl.Id  WHERE      (          ral.AssignedTo = @i_UserId          AND ral.ApprovalStatusId <> @i_PendingStatus      )            OR (          @i_IsUserRolesEmpty = 0          ...): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetRequisitionCounts in GetRequisitionsKPI in Homepage in a_Main in ConectaProveedores (-- SELECT  --     COUNT(CASE   --         WHEN ral.AssignedTo = @i_UserId   --          AND ral.ApprovalStatusId IN (@i_NotApprovedStatus, @i_ToAssignStatus)  --         THEN 1 END) AS ToApproveCount,    --     COUNT(CASE   --         WHEN ral.AssignedTo = @i_UserId   --          AND ral.ApprovalStatusId IN (@i_NotApprovedStatus, @i_ToAssignStatus, @i_CanceledStatus, @i_ModifyStatus, @i_AssignedStatus, @i_ApprovedStatus)   --         THEN 1 END) AS TotalCount  -- FROM {RequisitionApprovalLevel} ral;    SELECT       COUNT(ral.Id) AS ApprovalCount,      asl.Label AS ApprovalStatusLabel  FROM      {RequisitionApprovalLevel} ral  INNER JOIN {RequisitionApproval} ra ON ral.RequisitionApprovalId = ra.Id  INNER JOIN {Requisition} req ON ra.RequisitionId = req.Id  INNER JOIN {ApprovalStatus} asl ON ral.ApprovalStatusId = asl.Id  WHERE      (          ral.AssignedTo = @i_UserId          AND ral.ApprovalStatusId <> @i_PendingStatus      )            OR (          @i_IsUserRolesEmpty = 0          ...): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetRequisitionCounts in GetRequisitionsKPI in Homepage in a_Main in ConectaProveedores (-- SELECT  --     COUNT(CASE   --         WHEN ral.AssignedTo = @i_UserId   --          AND ral.ApprovalStatusId IN (@i_NotApprovedStatus, @i_ToAssignStatus)  --         THEN 1 END) AS ToApproveCount,    --     COUNT(CASE   --         WHEN ral.AssignedTo = @i_UserId   --          AND ral.ApprovalStatusId IN (@i_NotApprovedStatus, @i_ToAssignStatus, @i_CanceledStatus, @i_ModifyStatus, @i_AssignedStatus, @i_ApprovedStatus)   --         THEN 1 END) AS TotalCount  -- FROM {RequisitionApprovalLevel} ral;    SELECT       COUNT(ral.Id) AS ApprovalCount,      asl.Label AS ApprovalStatusLabel  FROM      {RequisitionApprovalLevel} ral  INNER JOIN {RequisitionApproval} ra ON ral.RequisitionApprovalId = ra.Id  INNER JOIN {Requisition} req ON ra.RequisitionId = req.Id  INNER JOIN {ApprovalStatus} asl ON ral.ApprovalStatusId = asl.Id  WHERE      (          ral.AssignedTo = @i_UserId          AND ral.ApprovalStatusId <> @i_PendingStatus      )            OR (          @i_IsUserRolesEmpty = 0          ...): " + aqExcep.Message));
}
}
}
}
public static class FuncDataActionGetInvoicesKPI {
}
public static class FuncDataActionGetFoliosKPI {

// Query Function "GetOrderCounts" xyDJjdHFckORQX+3OppRzw of Action "GetFoliosKPI"
public static async Task<(RL_0b9ed344d44b60e0112a22c99132ee6b,long)> QueryGetOrderCounts(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusi_UserId,int qpapi_NotApprovedStatus,long qprei_RegionId,int qpapi_PendingStatus,long qpeni_UserEntraRoleId,long qptei_UserTelcelDirectionId,int qpapi_ToComplementStatus,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("a_Main.Homepage.GetFoliosKPI.GetOrderCounts", "8dc920c7-c5d1-4372-9141-7fb73a9a51cf");
using var queryActivity = activitySource.CreateSqlQueryActivity("a_Main.Homepage.GetFoliosKPI.GetOrderCounts", "8dc920c7-c5d1-4372-9141-7fb73a9a51cf", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string entityOrderApprovalLevel = AppUtils.Instance.RuntimeEntityReplace("OrderApprovalLevel");
string entityOrderApproval = AppUtils.Instance.RuntimeEntityReplace("OrderApproval");
string entityOrderMain = AppUtils.Instance.RuntimeEntityReplace("OrderMain");
string entityApprovalStatus = AppUtils.Instance.RuntimeEntityReplace("ApprovalStatus");
sqlCmd.CreateParameter("@qpusi_UserId", DbType.String, qpusi_UserId);
sqlCmd.CreateParameter("@qpapi_PendingStatus", DbType.Int32, qpapi_PendingStatus);
sqlCmd.CreateParameter("@qpeni_UserEntraRoleId", DbType.Int64, qpeni_UserEntraRoleId);
sqlCmd.CreateParameter("@qprei_RegionId", DbType.Int64, qprei_RegionId);
sqlCmd.CreateParameter("@qptei_UserTelcelDirectionId", DbType.Int64, qptei_UserTelcelDirectionId);
sqlCmd.CreateParameter("@qpapi_NotApprovedStatus", DbType.Int32, qpapi_NotApprovedStatus);
sqlCmd.CreateParameter("@qpapi_ToComplementStatus", DbType.Int32, qpapi_ToComplementStatus);
string sql = "";
string advSql = "SELECT  \n    COUNT(oal.Id) AS ApprovalCount, \n    asl.Label AS ApprovalStatusLabel \nFROM \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApprovalLevel,"") + " oal \nINNER JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderApproval,"") + " oa ON oal.OrderApprovalId = oa.Id \nINNER JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,"") + " ord ON oa.OrderId = ord.Id \nINNER JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,"") + " asl ON oal.ApprovalStatusId = asl.Id \nWHERE \n    ( \n        oal.AssignedTo = @qpusi_UserId \n        AND oal.ApprovalStatusId <> @qpapi_PendingStatus \n    ) \n    OR ( \n        oal.EntraRoleId = @qpeni_UserEntraRoleId \n        AND ord.RegionId = @qprei_RegionId \n        AND ord.TelcelDirectionId = @qptei_UserTelcelDirectionId \n        AND (oal.ApprovalStatusId = @qpapi_NotApprovedStatus OR oal.ApprovalStatusId = @qpapi_ToComplementStatus) \n    ) \nGROUP BY \n    asl.Label, \n    asl.\"order\" \nORDER BY  \n    asl.\"order\" ASC;";
sql = advSql;
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_0b9ed344d44b60e0112a22c99132ee6b outParamList = new RL_0b9ed344d44b60e0112a22c99132ee6b();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query a_Main.Homepage.GetFoliosKPI.GetOrderCounts.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_0b9ed344d44b60e0112a22c99132ee6b _tmp = new RL_0b9ed344d44b60e0112a22c99132ee6b();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query a_Main.Homepage.GetFoliosKPI.GetOrderCounts.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_0b9ed344d44b60e0112a22c99132ee6b)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetOrderCounts in GetFoliosKPI in Homepage in a_Main in ConectaProveedores (SELECT       COUNT(oal.Id) AS ApprovalCount,      asl.Label AS ApprovalStatusLabel  FROM      {OrderApprovalLevel} oal  INNER JOIN {OrderApproval} oa ON oal.OrderApprovalId = oa.Id  INNER JOIN {OrderMain} ord ON oa.OrderId = ord.Id  INNER JOIN {ApprovalStatus} asl ON oal.ApprovalStatusId = asl.Id  WHERE      (          oal.AssignedTo = @i_UserId          AND oal.ApprovalStatusId <> @i_PendingStatus      )      OR (          oal.EntraRoleId = @i_UserEntraRoleId          AND ord.RegionId = @i_RegionId          AND ord.TelcelDirectionId = @i_UserTelcelDirectionId          AND (oal.ApprovalStatusId = @i_NotApprovedStatus OR oal.ApprovalStatusId = @i_ToComplementStatus)      )  GROUP BY      asl.Label,      asl.[Order]  ORDER BY       asl.[Order] ASC;): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetOrderCounts in GetFoliosKPI in Homepage in a_Main in ConectaProveedores (SELECT       COUNT(oal.Id) AS ApprovalCount,      asl.Label AS ApprovalStatusLabel  FROM      {OrderApprovalLevel} oal  INNER JOIN {OrderApproval} oa ON oal.OrderApprovalId = oa.Id  INNER JOIN {OrderMain} ord ON oa.OrderId = ord.Id  INNER JOIN {ApprovalStatus} asl ON oal.ApprovalStatusId = asl.Id  WHERE      (          oal.AssignedTo = @i_UserId          AND oal.ApprovalStatusId <> @i_PendingStatus      )      OR (          oal.EntraRoleId = @i_UserEntraRoleId          AND ord.RegionId = @i_RegionId          AND ord.TelcelDirectionId = @i_UserTelcelDirectionId          AND (oal.ApprovalStatusId = @i_NotApprovedStatus OR oal.ApprovalStatusId = @i_ToComplementStatus)      )  GROUP BY      asl.Label,      asl.[Order]  ORDER BY       asl.[Order] ASC;): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetOrderCounts in GetFoliosKPI in Homepage in a_Main in ConectaProveedores (SELECT       COUNT(oal.Id) AS ApprovalCount,      asl.Label AS ApprovalStatusLabel  FROM      {OrderApprovalLevel} oal  INNER JOIN {OrderApproval} oa ON oal.OrderApprovalId = oa.Id  INNER JOIN {OrderMain} ord ON oa.OrderId = ord.Id  INNER JOIN {ApprovalStatus} asl ON oal.ApprovalStatusId = asl.Id  WHERE      (          oal.AssignedTo = @i_UserId          AND oal.ApprovalStatusId <> @i_PendingStatus      )      OR (          oal.EntraRoleId = @i_UserEntraRoleId          AND ord.RegionId = @i_RegionId          AND ord.TelcelDirectionId = @i_UserTelcelDirectionId          AND (oal.ApprovalStatusId = @i_NotApprovedStatus OR oal.ApprovalStatusId = @i_ToComplementStatus)      )  GROUP BY      asl.Label,      asl.[Order]  ORDER BY       asl.[Order] ASC;): " + aqExcep.Message));
}
}
}
}


}
