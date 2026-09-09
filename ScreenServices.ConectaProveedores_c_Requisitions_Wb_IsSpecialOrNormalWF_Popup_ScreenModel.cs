using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_c_Requisitions_Wb_IsSpecialOrNormalWF_Popup_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_c_Requisitions_Wb_IsSpecialOrNormalWF_Popup_ScreenModel).Namespace);

    public string inParamProcessTypeCode;
public bool inParamIsDonation;
public bool varLcl_IsBusy;
public string varLcl_FirstApproverUserId;
public RC_e05385e784b7ab877b391b661988aada varLcl_SpecialWorkflowSelected;
public ConectaProveedores_c_Requisitions_Wb_IsSpecialOrNormalWF_Popup_DataActionGetFirstApproverList_Model varLcGetFirstApproverList;
public ConectaProveedores_c_Requisitions_Wb_IsSpecialOrNormalWF_Popup_DataActionGetSettings_Model varLcGetSettings;
public ConectaProveedores_c_Requisitions_Wb_IsSpecialOrNormalWF_Popup_DataActionGetSpecialWorkflows_Model varLcGetSpecialWorkflows;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_c_Requisitions_Wb_IsSpecialOrNormalWF_Popup_ScreenModel() {
}



    public ConectaProveedores_c_Requisitions_Wb_IsSpecialOrNormalWF_Popup_ScreenModel(string inParamProcessTypeCode, bool inParamIsDonation, bool varLcl_IsBusy, string varLcl_FirstApproverUserId, RC_e05385e784b7ab877b391b661988aada varLcl_SpecialWorkflowSelected, ConectaProveedores_c_Requisitions_Wb_IsSpecialOrNormalWF_Popup_DataActionGetFirstApproverList_Model varLcGetFirstApproverList, ConectaProveedores_c_Requisitions_Wb_IsSpecialOrNormalWF_Popup_DataActionGetSettings_Model varLcGetSettings, ConectaProveedores_c_Requisitions_Wb_IsSpecialOrNormalWF_Popup_DataActionGetSpecialWorkflows_Model varLcGetSpecialWorkflows, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"ProcessTypeCode", "IsDonation", "l_IsBusy", "l_FirstApproverUserId", "l_SpecialWorkflowSelected", "GetFirstApproverList", "GetSettings", "GetSpecialWorkflows", "ClientVars"}, new string[] {"inParamProcessTypeCode", "inParamIsDonation", "varLcl_IsBusy", "varLcl_FirstApproverUserId", "varLcl_SpecialWorkflowSelected", "varLcGetFirstApproverList", "varLcGetSettings", "varLcGetSpecialWorkflows", "clientVariables"});
this.inParamProcessTypeCode = inParamProcessTypeCode;
this.inParamIsDonation = inParamIsDonation;
this.varLcl_IsBusy = varLcl_IsBusy;
this.varLcl_FirstApproverUserId = varLcl_FirstApproverUserId;
this.varLcl_SpecialWorkflowSelected = varLcl_SpecialWorkflowSelected;
this.varLcGetFirstApproverList = varLcGetFirstApproverList;
this.varLcGetSettings = varLcGetSettings;
this.varLcGetSpecialWorkflows = varLcGetSpecialWorkflows;
this.clientVariables = clientVariables;
}



    

    public class lcvGetFirstApproverList : VarsBag {
public RL_f518d708e7bb15a03a65b75b9f603096 queryResGetUsers_outParamList = new RL_f518d708e7bb15a03a65b75b9f603096();
public long queryResGetUsers_outParamCount = 0L;

public RL_8dbe9b3349c28479d314d27fe2f03197 queryResGetFirstApproverEntraRoleId_outParamList = new RL_8dbe9b3349c28479d314d27fe2f03197();
public long queryResGetFirstApproverEntraRoleId_outParamCount = 0L;

public lcvGetFirstApproverList() {
}
}
public class lcoGetFirstApproverList : VarsBag {
public RL_1145aac6350efb8c92df9a6bfb52edab outParamUserList = new RL_1145aac6350efb8c92df9a6bfb52edab();

public lcoGetFirstApproverList() {
}
}
/// <summary>
/// Action <code>GetFirstApproverList</code> that represents the Service Studio action
///  <code>GetFirstApproverList</code> <p> Description: </p>
/// </summary>
public async Task<RL_1145aac6350efb8c92df9a6bfb52edab> DataActionGetFirstApproverList(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_1145aac6350efb8c92df9a6bfb52edab outParamUserList = default;
lcoGetFirstApproverList result = new lcoGetFirstApproverList();
lcvGetFirstApproverList localVars = new lcvGetFirstApproverList();
ConectaProveedores_c_Requisitions_Wb_IsSpecialOrNormalWF_Popup_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetFirstApproverList", "70ceae99-e1d3-40cb-9560-77b3a9ab1aa6"))
using (activitySource.CreateScreenDataActionActivity("Wb_IsSpecialOrNormalWF_Popup", "GetFirstApproverList")){
// ListClear
await ExtendedActions.ListClear(requestContext,result.outParamUserList,cancellationToken);

// Query datasetGetFirstApproverEntraRoleId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFirstApproverEntraRoleId_maxRecords = 1;
if (datasetGetFirstApproverEntraRoleId_maxRecords < 1) datasetGetFirstApproverEntraRoleId_maxRecords = 1;
int datasetGetFirstApproverEntraRoleId_startIndex = 0;(localVars.queryResGetFirstApproverEntraRoleId_outParamList,localVars.queryResGetFirstApproverEntraRoleId_outParamCount) = await FuncDataActionGetFirstApproverList.datasetGetFirstApproverEntraRoleId(requestContext,datasetGetFirstApproverEntraRoleId_maxRecords,datasetGetFirstApproverEntraRoleId_startIndex,IterationMultiplicity.Never,varLcl_SpecialWorkflowSelected.ssl_ApprovalProcessId,cancellationToken);

// Empty?
if((!(localVars.queryResGetFirstApproverEntraRoleId_outParamList.Empty))) {
// Query datasetGetUsers
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUsers_maxRecords = 0;
int datasetGetUsers_startIndex = 0;(localVars.queryResGetUsers_outParamList,localVars.queryResGetUsers_outParamCount) = await FuncDataActionGetFirstApproverList.datasetGetUsers(requestContext,datasetGetUsers_maxRecords,datasetGetUsers_startIndex,IterationMultiplicity.Single,localVars.queryResGetFirstApproverEntraRoleId_outParamList.CurrentRec.ssENApprovalProcessLevel.ssDepartmentId,localVars.queryResGetFirstApproverEntraRoleId_outParamList.CurrentRec.ssENApprovalProcessLevel.ssEntraRoleId,localVars.queryResGetFirstApproverEntraRoleId_outParamList.CurrentRec.ssENApprovalProcessLevel.ssManagementId,localVars.queryResGetFirstApproverEntraRoleId_outParamList.CurrentRec.ssENApprovalProcessLevel.ssSubdirectionId,BuiltInFunction.GetUserId (),(await Functions.ActionGetUserRegionId(requestContext,"",cancellationToken)),(await Functions.ActionGetUserTelcelDirectionId(requestContext,"",cancellationToken)),((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsDevEnvironment]))),cancellationToken);

// UserList = GetUsers.List
result.outParamUserList=(await RL_1145aac6350efb8c92df9a6bfb52edab.ConvertAsync(localVars.queryResGetUsers_outParamList, new RL_1145aac6350efb8c92df9a6bfb52edab(), async (RC_77956dae907db5f208e8a848dc366336 source, RC_f4217b217830b749d338ebe1832450a6 target, CancellationToken cancellationToken) => {
target.ssRoleName = source.ssENEntraRole.ssRoleName;
target.ssUserId = source.ssENUser.ssId;
target.ssUserName = source.ssENUser.ssName;
return target;
}, cancellationToken));
}

} //close CreateActionActivity using block
} // try

finally {
outParamUserList = result.outParamUserList;
} // inner-finally
RETURN_STATEMENT:
return outParamUserList;
}
public class lcoGetSettings : VarsBag {
public bool outParamo_IsActiveDEV_FlujoRRHH = false;

public lcoGetSettings() {
}
}
/// <summary>
/// Action <code>GetSettings</code> that represents the Service Studio action <code>GetSettings</code>
///  <p> Description: </p>
/// </summary>
public async Task<bool> DataActionGetSettings(IRequestContext requestContext,CancellationToken cancellationToken) {
bool outParamo_IsActiveDEV_FlujoRRHH = default;
lcoGetSettings result = new lcoGetSettings();
ConectaProveedores_c_Requisitions_Wb_IsSpecialOrNormalWF_Popup_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetSettings", "a5cdfcba-8fbb-4583-a3c9-95c7d38698f9"))
using (activitySource.CreateScreenDataActionActivity("Wb_IsSpecialOrNormalWF_Popup", "GetSettings")){
// o_IsActiveDEV_FlujoRRHH = IsActiveDEV_FlujoRRHH
result.outParamo_IsActiveDEV_FlujoRRHH=((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveDEV_FlujoRRHH])));
} //close CreateActionActivity using block
} // try

finally {
outParamo_IsActiveDEV_FlujoRRHH = result.outParamo_IsActiveDEV_FlujoRRHH;
} // inner-finally
RETURN_STATEMENT:
return outParamo_IsActiveDEV_FlujoRRHH;
}
public class lcvGetSpecialWorkflows : VarsBag {
public RL_50f86c7badf933578e482e000d347a03 queryResGetProcessTypeByCode_outParamList = new RL_50f86c7badf933578e482e000d347a03();
public long queryResGetProcessTypeByCode_outParamCount = 0L;

public RL_8dbe9b3349c28479d314d27fe2f03197 queryResGetApprovalProcess_outParamList = new RL_8dbe9b3349c28479d314d27fe2f03197();
public long queryResGetApprovalProcess_outParamCount = 0L;

public RL_a37f5f153582e24adaea3ae8b54b3101 queryResGetUserExtendedInternalJobTitle_outParamList = new RL_a37f5f153582e24adaea3ae8b54b3101();
public long queryResGetUserExtendedInternalJobTitle_outParamCount = 0L;

public RL_8dbe9b3349c28479d314d27fe2f03197 queryResGetApprovProcPuestoGerSubdir_outParamList = new RL_8dbe9b3349c28479d314d27fe2f03197();
public long queryResGetApprovProcPuestoGerSubdir_outParamCount = 0L;

public RL_8dbe9b3349c28479d314d27fe2f03197 queryResGetApprovProcPuestoSubdir_outParamList = new RL_8dbe9b3349c28479d314d27fe2f03197();
public long queryResGetApprovProcPuestoSubdir_outParamCount = 0L;

public RL_ce09c545b541edeabab89435c34c64f0 resListDistinct_outParamDistinctList = new RL_ce09c545b541edeabab89435c34c64f0();

public RL_8dbe9b3349c28479d314d27fe2f03197 queryResGetApprovProcPuestoGer_outParamList = new RL_8dbe9b3349c28479d314d27fe2f03197();
public long queryResGetApprovProcPuestoGer_outParamCount = 0L;

public lcvGetSpecialWorkflows() {
}
}
public class lcoGetSpecialWorkflows : VarsBag {
public RL_ce09c545b541edeabab89435c34c64f0 outParamApprovalProcessList = new RL_ce09c545b541edeabab89435c34c64f0();

public lcoGetSpecialWorkflows() {
}
}
/// <summary>
/// Action <code>GetSpecialWorkflows</code> that represents the Service Studio action
///  <code>GetSpecialWorkflows</code> <p> Description: </p>
/// </summary>
public async Task<RL_ce09c545b541edeabab89435c34c64f0> DataActionGetSpecialWorkflows(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_ce09c545b541edeabab89435c34c64f0 outParamApprovalProcessList = default;
lcoGetSpecialWorkflows result = new lcoGetSpecialWorkflows();
lcvGetSpecialWorkflows localVars = new lcvGetSpecialWorkflows();
ConectaProveedores_c_Requisitions_Wb_IsSpecialOrNormalWF_Popup_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetSpecialWorkflows", "fa9f62e6-306c-494c-a277-887f69e285cf"))
using (activitySource.CreateScreenDataActionActivity("Wb_IsSpecialOrNormalWF_Popup", "GetSpecialWorkflows")){
// ListClear
await ExtendedActions.ListClear(requestContext,result.outParamApprovalProcessList,cancellationToken);

// Query datasetGetUserExtendedInternalJobTitle
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserExtendedInternalJobTitle_maxRecords = 1;
if (datasetGetUserExtendedInternalJobTitle_maxRecords < 1) datasetGetUserExtendedInternalJobTitle_maxRecords = 1;
int datasetGetUserExtendedInternalJobTitle_startIndex = 0;(localVars.queryResGetUserExtendedInternalJobTitle_outParamList,localVars.queryResGetUserExtendedInternalJobTitle_outParamCount) = await FuncDataActionGetSpecialWorkflows.datasetGetUserExtendedInternalJobTitle(requestContext,datasetGetUserExtendedInternalJobTitle_maxRecords,datasetGetUserExtendedInternalJobTitle_startIndex,IterationMultiplicity.Never,BuiltInFunction.GetUserId (),cancellationToken);

// Query datasetGetProcessTypeByCode
cancellationToken.ThrowIfCancellationRequested();
int datasetGetProcessTypeByCode_maxRecords = 1;
if (datasetGetProcessTypeByCode_maxRecords < 1) datasetGetProcessTypeByCode_maxRecords = 1;
int datasetGetProcessTypeByCode_startIndex = 0;(localVars.queryResGetProcessTypeByCode_outParamList,localVars.queryResGetProcessTypeByCode_outParamCount) = await FuncDataActionGetSpecialWorkflows.datasetGetProcessTypeByCode(requestContext,datasetGetProcessTypeByCode_maxRecords,datasetGetProcessTypeByCode_startIndex,IterationMultiplicity.Never,inParamProcessTypeCode,cancellationToken);

// Empty
if((!(localVars.queryResGetProcessTypeByCode_outParamList.Empty))) {
// Query datasetGetApprovProcPuestoGerSubdir
cancellationToken.ThrowIfCancellationRequested();
int datasetGetApprovProcPuestoGerSubdir_maxRecords = 0;
int datasetGetApprovProcPuestoGerSubdir_startIndex = 0;(localVars.queryResGetApprovProcPuestoGerSubdir_outParamList,localVars.queryResGetApprovProcPuestoGerSubdir_outParamCount) = await FuncDataActionGetSpecialWorkflows.datasetGetApprovProcPuestoGerSubdir(requestContext,datasetGetApprovProcPuestoGerSubdir_maxRecords,datasetGetApprovProcPuestoGerSubdir_startIndex,IterationMultiplicity.Multiple,localVars.queryResGetProcessTypeByCode_outParamList.CurrentRec.ssENProcessType.ssId,localVars.queryResGetUserExtendedInternalJobTitle_outParamList.CurrentRec.ssENEntraRole.ssId,localVars.queryResGetUserExtendedInternalJobTitle_outParamList.CurrentRec.ssENUser_Extended_Internal.ssManagementId,localVars.queryResGetUserExtendedInternalJobTitle_outParamList.CurrentRec.ssENUser_Extended_Internal.ssSubdirectionId,inParamIsDonation,cancellationToken);

// Empty?
if((!(localVars.queryResGetApprovProcPuestoGerSubdir_outParamList.Empty))) {
// ListAppendAll
await ExtendedActions.ListAppendAll(requestContext,result.outParamApprovalProcessList,(await RL_ce09c545b541edeabab89435c34c64f0.ConvertAsync(localVars.queryResGetApprovProcPuestoGerSubdir_outParamList, new RL_ce09c545b541edeabab89435c34c64f0(), async (RC_1c307c6ba13b1609f542644719b6e56b source, EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord target, CancellationToken cancellationToken) => {
target = source.ssENApprovalProcess;
return target;
}, cancellationToken)),cancellationToken);

}

// Query datasetGetApprovProcPuestoGer
cancellationToken.ThrowIfCancellationRequested();
int datasetGetApprovProcPuestoGer_maxRecords = 0;
int datasetGetApprovProcPuestoGer_startIndex = 0;(localVars.queryResGetApprovProcPuestoGer_outParamList,localVars.queryResGetApprovProcPuestoGer_outParamCount) = await FuncDataActionGetSpecialWorkflows.datasetGetApprovProcPuestoGer(requestContext,datasetGetApprovProcPuestoGer_maxRecords,datasetGetApprovProcPuestoGer_startIndex,IterationMultiplicity.Multiple,localVars.queryResGetProcessTypeByCode_outParamList.CurrentRec.ssENProcessType.ssId,localVars.queryResGetUserExtendedInternalJobTitle_outParamList.CurrentRec.ssENEntraRole.ssId,localVars.queryResGetUserExtendedInternalJobTitle_outParamList.CurrentRec.ssENUser_Extended_Internal.ssManagementId,inParamIsDonation,cancellationToken);

// Empty?
if((!(localVars.queryResGetApprovProcPuestoGer_outParamList.Empty))) {
// ListAppendAll2
await ExtendedActions.ListAppendAll(requestContext,result.outParamApprovalProcessList,(await RL_ce09c545b541edeabab89435c34c64f0.ConvertAsync(localVars.queryResGetApprovProcPuestoGer_outParamList, new RL_ce09c545b541edeabab89435c34c64f0(), async (RC_1c307c6ba13b1609f542644719b6e56b source, EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord target, CancellationToken cancellationToken) => {
target = source.ssENApprovalProcess;
return target;
}, cancellationToken)),cancellationToken);

}

// Query datasetGetApprovProcPuestoSubdir
cancellationToken.ThrowIfCancellationRequested();
int datasetGetApprovProcPuestoSubdir_maxRecords = 0;
int datasetGetApprovProcPuestoSubdir_startIndex = 0;(localVars.queryResGetApprovProcPuestoSubdir_outParamList,localVars.queryResGetApprovProcPuestoSubdir_outParamCount) = await FuncDataActionGetSpecialWorkflows.datasetGetApprovProcPuestoSubdir(requestContext,datasetGetApprovProcPuestoSubdir_maxRecords,datasetGetApprovProcPuestoSubdir_startIndex,IterationMultiplicity.Multiple,localVars.queryResGetProcessTypeByCode_outParamList.CurrentRec.ssENProcessType.ssId,localVars.queryResGetUserExtendedInternalJobTitle_outParamList.CurrentRec.ssENEntraRole.ssId,localVars.queryResGetUserExtendedInternalJobTitle_outParamList.CurrentRec.ssENUser_Extended_Internal.ssSubdirectionId,inParamIsDonation,cancellationToken);

// Empty?
if((!(localVars.queryResGetApprovProcPuestoSubdir_outParamList.Empty))) {
// ListAppendAll3
await ExtendedActions.ListAppendAll(requestContext,result.outParamApprovalProcessList,(await RL_ce09c545b541edeabab89435c34c64f0.ConvertAsync(localVars.queryResGetApprovProcPuestoSubdir_outParamList, new RL_ce09c545b541edeabab89435c34c64f0(), async (RC_1c307c6ba13b1609f542644719b6e56b source, EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord target, CancellationToken cancellationToken) => {
target = source.ssENApprovalProcess;
return target;
}, cancellationToken)),cancellationToken);

}

// Query datasetGetApprovalProcess
cancellationToken.ThrowIfCancellationRequested();
int datasetGetApprovalProcess_maxRecords = 0;
int datasetGetApprovalProcess_startIndex = 0;(localVars.queryResGetApprovalProcess_outParamList,localVars.queryResGetApprovalProcess_outParamCount) = await FuncDataActionGetSpecialWorkflows.datasetGetApprovalProcess(requestContext,datasetGetApprovalProcess_maxRecords,datasetGetApprovalProcess_startIndex,IterationMultiplicity.Multiple,localVars.queryResGetProcessTypeByCode_outParamList.CurrentRec.ssENProcessType.ssId,localVars.queryResGetUserExtendedInternalJobTitle_outParamList.CurrentRec.ssENEntraRole.ssId,inParamIsDonation,cancellationToken);

// Empty?
if((!(localVars.queryResGetApprovalProcess_outParamList.Empty))) {
// ListAppendAll4
await ExtendedActions.ListAppendAll(requestContext,result.outParamApprovalProcessList,(await RL_ce09c545b541edeabab89435c34c64f0.ConvertAsync(localVars.queryResGetApprovalProcess_outParamList, new RL_ce09c545b541edeabab89435c34c64f0(), async (RC_1c307c6ba13b1609f542644719b6e56b source, EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord target, CancellationToken cancellationToken) => {
target = source.ssENApprovalProcess;
return target;
}, cancellationToken)),cancellationToken);

}

// ListDistinct
localVars.resListDistinct_outParamDistinctList = (((RL_ce09c545b541edeabab89435c34c64f0) result.outParamApprovalProcessList.Distinct()));

// ApprovalProcessList = ListDistinct.DistinctList
result.outParamApprovalProcessList=localVars.resListDistinct_outParamDistinctList;
}

} //close CreateActionActivity using block
} // try

finally {
outParamApprovalProcessList = result.outParamApprovalProcessList;
} // inner-finally
RETURN_STATEMENT:
return outParamApprovalProcessList;
}


    public static class FuncDataActionGetFirstApproverList {

private static async Task<RC_77956dae907db5f208e8a848dc366336> datasetGetUsersReadDbAsync(RC_77956dae907db5f208e8a848dc366336 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENEntraRole.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
rec.ssENUserExtension.Read( r, ref index);
return rec;
}
// Query Function "GetUsers" H4M+jK669EONq6uLaRI3TA of Action "GetFirstApproverList"
public static async Task<(RL_f518d708e7bb15a03a65b75b9f603096,long)> datasetGetUsers(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpdeUser_Extended_Internal_DepartmentId,long qpenUser_Extended_Internal_EntraRoleId,long qpmaUser_Extended_Internal_ManagementId,long qpsuUser_Extended_Internal_SubdirectionId,string qpusUser_Id,long qpreUser_Extended_Internal_RegionId,long qpteUser_Extended_Internal_TelcelDirectionId,bool qpboIsDevEnvironment,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("c_Requisitions.Wb_IsSpecialOrNormalWF_Popup.GetFirstApproverList.GetUsers", "8c3e831f-baae-43f4-8dab-ab8b6912374c");
using var queryActivity = activitySource.CreateAggregateQueryActivity("c_Requisitions.Wb_IsSpecialOrNormalWF_Popup.GetFirstApproverList.GetUsers", "8c3e831f-baae-43f4-8dab-ab8b6912374c", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.JIeB93KaO0CekhFmmzHOww/DataActions.ma7OcNPhy0CVYHezqasapg/NodesNotShownInESpaceTree.H4M+jK669EONq6uLaRI3TA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enentrarole63\".\"rolename\" o1, NULL o2, NULL o3, NULL o4, NULL o5, \"enuser187\".\"id\" o6, \"enuser187\".\"name\" o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33");
fromBuilder.Append(" FROM ((({User} \"enuser187\" Left JOIN {User_Extended_Internal} \"enuser_extended_internal118\" ON (\"enuser187\".\"id\" = \"enuser_extended_internal118\".\"id\"))  Left JOIN {UserExtension} \"enuserextension75\" ON (\"enuser187\".\"id\" = \"enuserextension75\".\"id\"))  Left JOIN {EntraRole} \"enentrarole63\" ON (\"enuser_extended_internal118\".\"entraroleid\" = \"enentrarole63\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpreUser_Extended_Internal_RegionId != 0) {
whereBuilder.Append("((\"enuser_extended_internal118\".\"regionid\" = @qpreUser_Extended_Internal_RegionId) AND (\"enuser_extended_internal118\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreUser_Extended_Internal_RegionId", DbType.Int64, qpreUser_Extended_Internal_RegionId);
} else {
whereBuilder.Append("(\"enuser_extended_internal118\".\"regionid\" IS NULL)");
}
whereBuilder.Append(" AND ");
if (qpteUser_Extended_Internal_TelcelDirectionId != 0) {
whereBuilder.Append("((\"enuser_extended_internal118\".\"telceldirectionid\" = @qpteUser_Extended_Internal_TelcelDirectionId) AND (\"enuser_extended_internal118\".\"telceldirectionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpteUser_Extended_Internal_TelcelDirectionId", DbType.Int64, qpteUser_Extended_Internal_TelcelDirectionId);
} else {
whereBuilder.Append("(\"enuser_extended_internal118\".\"telceldirectionid\" IS NULL)");
}
whereBuilder.Append(" AND ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser187\".\"id\" <> @qpusUser_Id) OR (\"enuser187\".\"id\" IS NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser187\".\"id\" IS NOT NULL)");
}
whereBuilder.Append(" AND ((CASE WHEN (@qpboIsDevEnvironment = 1) THEN (CASE WHEN (\"enuserextension75\".\"correspondentexternalemail\" <> '') THEN 1 ELSE 0 END) ELSE 1 END) = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboIsDevEnvironment", DbType.Boolean, qpboIsDevEnvironment);
if (qpenUser_Extended_Internal_EntraRoleId != 0) {
whereBuilder.Append("((\"enuser_extended_internal118\".\"entraroleid\" = @qpenUser_Extended_Internal_EntraRoleId) AND (\"enuser_extended_internal118\".\"entraroleid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpenUser_Extended_Internal_EntraRoleId", DbType.Int64, qpenUser_Extended_Internal_EntraRoleId);
} else {
whereBuilder.Append("(\"enuser_extended_internal118\".\"entraroleid\" IS NULL)");
}
whereBuilder.Append(" AND ");
if (qpdeUser_Extended_Internal_DepartmentId != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpdeUser_Extended_Internal_DepartmentId != 0) {
whereBuilder.Append("((\"enuser_extended_internal118\".\"departmentid\" = @qpdeUser_Extended_Internal_DepartmentId) AND (\"enuser_extended_internal118\".\"departmentid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpdeUser_Extended_Internal_DepartmentId", DbType.Int64, qpdeUser_Extended_Internal_DepartmentId);
} else {
whereBuilder.Append("(\"enuser_extended_internal118\".\"departmentid\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpmaUser_Extended_Internal_ManagementId != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpmaUser_Extended_Internal_ManagementId != 0) {
whereBuilder.Append("((\"enuser_extended_internal118\".\"managementid\" = @qpmaUser_Extended_Internal_ManagementId) AND (\"enuser_extended_internal118\".\"managementid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpmaUser_Extended_Internal_ManagementId", DbType.Int64, qpmaUser_Extended_Internal_ManagementId);
} else {
whereBuilder.Append("(\"enuser_extended_internal118\".\"managementid\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpsuUser_Extended_Internal_SubdirectionId != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpsuUser_Extended_Internal_SubdirectionId != 0) {
whereBuilder.Append("((\"enuser_extended_internal118\".\"subdirectionid\" = @qpsuUser_Extended_Internal_SubdirectionId) AND (\"enuser_extended_internal118\".\"subdirectionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuUser_Extended_Internal_SubdirectionId", DbType.Int64, qpsuUser_Extended_Internal_SubdirectionId);
} else {
whereBuilder.Append("(\"enuser_extended_internal118\".\"subdirectionid\" IS NULL)");
}
}
string whereBuilderString = whereBuilder.ToString();
if (whereBuilderString.EndsWith(" AND ")) {
whereBuilder.Remove(whereBuilderString.Length - 5, 5);
}
orderByBuilder.Append(" ORDER BY \"enuser187\".\"name\" ASC ");
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
RL_f518d708e7bb15a03a65b75b9f603096 outParamList = new RL_f518d708e7bb15a03a65b75b9f603096();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetUsersReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[4];
opt[0] = new BitArray(new bool[] {false, false, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.Wb_IsSpecialOrNormalWF_Popup.GetFirstApproverList.GetUsers.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_f518d708e7bb15a03a65b75b9f603096 _tmp = new RL_f518d708e7bb15a03a65b75b9f603096();
_tmp.AlternateReadDbMethodAsync = datasetGetUsersReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.Wb_IsSpecialOrNormalWF_Popup.GetFirstApproverList.GetUsers.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_f518d708e7bb15a03a65b75b9f603096)_tmp;
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

private static async Task<RC_1c307c6ba13b1609f542644719b6e56b> datasetGetFirstApproverEntraRoleIdReadDbAsync(RC_1c307c6ba13b1609f542644719b6e56b rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApprovalProcess.Read( r, ref index);
rec.ssENApprovalProcessLevel.Read( r, ref index);
return rec;
}
// Query Function "GetFirstApproverEntraRoleId" dFMcjm2hgkiok1tX8Ytdbg of Action "GetFirstApproverList"
public static async Task<(RL_8dbe9b3349c28479d314d27fe2f03197,long)> datasetGetFirstApproverEntraRoleId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpapApprovalProcess_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("c_Requisitions.Wb_IsSpecialOrNormalWF_Popup.GetFirstApproverList.GetFirstApproverEntraRoleId", "8e1c5374-a16d-4882-a893-5b57f18b5d6e");
using var queryActivity = activitySource.CreateAggregateQueryActivity("c_Requisitions.Wb_IsSpecialOrNormalWF_Popup.GetFirstApproverList.GetFirstApproverEntraRoleId", "8e1c5374-a16d-4882-a893-5b57f18b5d6e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.JIeB93KaO0CekhFmmzHOww/DataActions.ma7OcNPhy0CVYHezqasapg/NodesNotShownInESpaceTree.dFMcjm2hgkiok1tX8Ytdbg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, \"enapprovalprocesslevel18\".\"entraroleid\" o26, \"enapprovalprocesslevel18\".\"departmentid\" o27, \"enapprovalprocesslevel18\".\"managementid\" o28, \"enapprovalprocesslevel18\".\"subdirectionid\" o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44");
fromBuilder.Append(" FROM ({ApprovalProcess} \"enapprovalprocess46\" Left JOIN {ApprovalProcessLevel} \"enapprovalprocesslevel18\" ON (\"enapprovalprocess46\".\"id\" = \"enapprovalprocesslevel18\".\"approvalprocessid\")) ");
whereBuilder.Append(" WHERE ");
if (qpapApprovalProcess_Id != 0) {
whereBuilder.Append("((\"enapprovalprocess46\".\"id\" = @qpapApprovalProcess_Id) AND (\"enapprovalprocess46\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpapApprovalProcess_Id", DbType.Int64, qpapApprovalProcess_Id);
} else {
whereBuilder.Append("(\"enapprovalprocess46\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (\"enapprovalprocesslevel18\".\"isfirstapprover\" = 1)");
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
RL_8dbe9b3349c28479d314d27fe2f03197 outParamList = new RL_8dbe9b3349c28479d314d27fe2f03197();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFirstApproverEntraRoleIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, false, false, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.Wb_IsSpecialOrNormalWF_Popup.GetFirstApproverList.GetFirstApproverEntraRoleId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_8dbe9b3349c28479d314d27fe2f03197 _tmp = new RL_8dbe9b3349c28479d314d27fe2f03197();
_tmp.AlternateReadDbMethodAsync = datasetGetFirstApproverEntraRoleIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.Wb_IsSpecialOrNormalWF_Popup.GetFirstApproverList.GetFirstApproverEntraRoleId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_8dbe9b3349c28479d314d27fe2f03197)_tmp;
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
public static class FuncDataActionGetSettings {
}
public static class FuncDataActionGetSpecialWorkflows {

// Query Function "GetProcessTypeByCode" v1hzEA0mIUavya8XQk+Kpw of Action "GetSpecialWorkflows"
public static async Task<(RL_50f86c7badf933578e482e000d347a03,long)> datasetGetProcessTypeByCode(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteCode,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("c_Requisitions.Wb_IsSpecialOrNormalWF_Popup.GetSpecialWorkflows.GetProcessTypeByCode", "107358bf-260d-4621-afc9-af17424f8aa7");
using var queryActivity = activitySource.CreateAggregateQueryActivity("c_Requisitions.Wb_IsSpecialOrNormalWF_Popup.GetSpecialWorkflows.GetProcessTypeByCode", "107358bf-260d-4621-afc9-af17424f8aa7", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.JIeB93KaO0CekhFmmzHOww/DataActions.5mKf+mwwTEmid4h_aeKFzw/NodesNotShownInESpaceTree.v1hzEA0mIUavya8XQk+Kpw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enprocesstype14\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4");
fromBuilder.Append(" FROM {ProcessType} \"enprocesstype14\"");
whereBuilder.Append(" WHERE (\"enprocesstype14\".\"is_active\" = 1) AND (\"enprocesstype14\".\"code\" = @qpteCode)");
sqlCmd.CreateParameterWithoutReplacements("@qpteCode", DbType.String, qpteCode);
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
RL_50f86c7badf933578e482e000d347a03 outParamList = new RL_50f86c7badf933578e482e000d347a03();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.Wb_IsSpecialOrNormalWF_Popup.GetSpecialWorkflows.GetProcessTypeByCode.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_50f86c7badf933578e482e000d347a03 _tmp = new RL_50f86c7badf933578e482e000d347a03();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.Wb_IsSpecialOrNormalWF_Popup.GetSpecialWorkflows.GetProcessTypeByCode.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_50f86c7badf933578e482e000d347a03)_tmp;
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

private static async Task<RC_1c307c6ba13b1609f542644719b6e56b> datasetGetApprovalProcessReadDbAsync(RC_1c307c6ba13b1609f542644719b6e56b rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApprovalProcess.Read( r, ref index);
rec.ssENApprovalProcessLevel.Read( r, ref index);
return rec;
}
// Query Function "GetApprovalProcess" hB5XRjNuI0CFB_EO668pVA of Action "GetSpecialWorkflows"
public static async Task<(RL_8dbe9b3349c28479d314d27fe2f03197,long)> datasetGetApprovalProcess(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpprApprovalProcess_ProcessTypeId,long qpenApprovalProcessLevel_EntraRoleId,bool qpboApprovalProcess_IsDonation,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("c_Requisitions.Wb_IsSpecialOrNormalWF_Popup.GetSpecialWorkflows.GetApprovalProcess", "46571e84-6e33-4023-8507-f10eebaf2954");
using var queryActivity = activitySource.CreateAggregateQueryActivity("c_Requisitions.Wb_IsSpecialOrNormalWF_Popup.GetSpecialWorkflows.GetApprovalProcess", "46571e84-6e33-4023-8507-f10eebaf2954", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.JIeB93KaO0CekhFmmzHOww/DataActions.5mKf+mwwTEmid4h_aeKFzw/NodesNotShownInESpaceTree.hB5XRjNuI0CFB_EO668pVA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enapprovalprocess47\".\"id\" o0, \"enapprovalprocess47\".\"processtypeid\" o1, \"enapprovalprocess47\".\"specialworkflowid\" o2, \"enapprovalprocess47\".\"approvalprocesstypeid\" o3, \"enapprovalprocess47\".\"regionid\" o4, \"enapprovalprocess47\".\"accountingregionid\" o5, \"enapprovalprocess47\".\"group\" o6, \"enapprovalprocess47\".\"code\" o7, \"enapprovalprocess47\".\"version\" o8, \"enapprovalprocess47\".\"description\" o9, \"enapprovalprocess47\".\"isactive\" o10, \"enapprovalprocess47\".\"isspecial\" o11, \"enapprovalprocess47\".\"isdonation\" o12, \"enapprovalprocess47\".\"iscxpcorporativo_deprec\" o13, \"enapprovalprocess47\".\"createdby\" o14, \"enapprovalprocess47\".\"createdon\" o15, \"enapprovalprocess47\".\"updatedby\" o16, \"enapprovalprocess47\".\"updatedon\" o17, \"enapprovalprocess47\".\"isselectfirstapprover\" o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44");
fromBuilder.Append(" FROM ({ApprovalProcess} \"enapprovalprocess47\" Left JOIN {ApprovalProcessLevel} \"enapprovalprocesslevel19\" ON (\"enapprovalprocess47\".\"id\" = \"enapprovalprocesslevel19\".\"approvalprocessid\")) ");
whereBuilder.Append(" WHERE ");
if (qpprApprovalProcess_ProcessTypeId != 0) {
whereBuilder.Append("((\"enapprovalprocess47\".\"processtypeid\" = @qpprApprovalProcess_ProcessTypeId) AND (\"enapprovalprocess47\".\"processtypeid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprApprovalProcess_ProcessTypeId", DbType.Int64, qpprApprovalProcess_ProcessTypeId);
} else {
whereBuilder.Append("(\"enapprovalprocess47\".\"processtypeid\" IS NULL)");
}
whereBuilder.Append(" AND ");
if (qpenApprovalProcessLevel_EntraRoleId != 0) {
whereBuilder.Append("((\"enapprovalprocesslevel19\".\"entraroleid\" = @qpenApprovalProcessLevel_EntraRoleId) AND (\"enapprovalprocesslevel19\".\"entraroleid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpenApprovalProcessLevel_EntraRoleId", DbType.Int64, qpenApprovalProcessLevel_EntraRoleId);
} else {
whereBuilder.Append("(\"enapprovalprocesslevel19\".\"entraroleid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enapprovalprocess47\".\"isdonation\" = @qpboApprovalProcess_IsDonation) AND (\"enapprovalprocess47\".\"isactive\" = 1) AND (\"enapprovalprocess47\".\"isspecial\" = 1) AND (\"enapprovalprocesslevel19\".\"isapplicant\" = 1) AND (\"enapprovalprocesslevel19\".\"managementid\" IS NULL) AND (\"enapprovalprocesslevel19\".\"subdirectionid\" IS NULL)");
sqlCmd.CreateParameterWithoutReplacements("@qpboApprovalProcess_IsDonation", DbType.Boolean, qpboApprovalProcess_IsDonation);
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
RL_8dbe9b3349c28479d314d27fe2f03197 outParamList = new RL_8dbe9b3349c28479d314d27fe2f03197();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetApprovalProcessReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.Wb_IsSpecialOrNormalWF_Popup.GetSpecialWorkflows.GetApprovalProcess.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_8dbe9b3349c28479d314d27fe2f03197 _tmp = new RL_8dbe9b3349c28479d314d27fe2f03197();
_tmp.AlternateReadDbMethodAsync = datasetGetApprovalProcessReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.Wb_IsSpecialOrNormalWF_Popup.GetSpecialWorkflows.GetApprovalProcess.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_8dbe9b3349c28479d314d27fe2f03197)_tmp;
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

private static async Task<RC_aad5e0f2e56c05eeddd020d008f4b3d7> datasetGetUserExtendedInternalJobTitleReadDbAsync(RC_aad5e0f2e56c05eeddd020d008f4b3d7 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENEntraRole.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
return rec;
}
// Query Function "GetUserExtendedInternalJobTitle" 9AUTegbYwk6qKSB+XVvMAw of Action "GetSpecialWorkflows"
public static async Task<(RL_a37f5f153582e24adaea3ae8b54b3101,long)> datasetGetUserExtendedInternalJobTitle(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("c_Requisitions.Wb_IsSpecialOrNormalWF_Popup.GetSpecialWorkflows.GetUserExtendedInternalJobTitle", "7a1305f4-d806-4ec2-aa29-207e5d5bcc03");
using var queryActivity = activitySource.CreateAggregateQueryActivity("c_Requisitions.Wb_IsSpecialOrNormalWF_Popup.GetSpecialWorkflows.GetUserExtendedInternalJobTitle", "7a1305f4-d806-4ec2-aa29-207e5d5bcc03", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.JIeB93KaO0CekhFmmzHOww/DataActions.5mKf+mwwTEmid4h_aeKFzw/NodesNotShownInESpaceTree.9AUTegbYwk6qKSB+XVvMAw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enentrarole64\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, \"enuser_extended_internal119\".\"managementid\" o16, \"enuser_extended_internal119\".\"subdirectionid\" o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30");
fromBuilder.Append(" FROM (({User_Extended_Internal} \"enuser_extended_internal119\" Inner JOIN {User} \"enuser188\" ON (\"enuser_extended_internal119\".\"id\" = \"enuser188\".\"id\"))  Left JOIN {EntraRole} \"enentrarole64\" ON (\"enuser_extended_internal119\".\"entraroleid\" = \"enentrarole64\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser188\".\"id\" = @qpusUser_Id) AND (\"enuser188\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser188\".\"id\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"enuser188\".\"name\" ASC ");
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
RL_a37f5f153582e24adaea3ae8b54b3101 outParamList = new RL_a37f5f153582e24adaea3ae8b54b3101();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetUserExtendedInternalJobTitleReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, true, true, true, true});
opt[1] = new BitArray(new bool[] {false, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.Wb_IsSpecialOrNormalWF_Popup.GetSpecialWorkflows.GetUserExtendedInternalJobTitle.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_a37f5f153582e24adaea3ae8b54b3101 _tmp = new RL_a37f5f153582e24adaea3ae8b54b3101();
_tmp.AlternateReadDbMethodAsync = datasetGetUserExtendedInternalJobTitleReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.Wb_IsSpecialOrNormalWF_Popup.GetSpecialWorkflows.GetUserExtendedInternalJobTitle.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_a37f5f153582e24adaea3ae8b54b3101)_tmp;
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

private static async Task<RC_1c307c6ba13b1609f542644719b6e56b> datasetGetApprovProcPuestoGerSubdirReadDbAsync(RC_1c307c6ba13b1609f542644719b6e56b rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApprovalProcess.Read( r, ref index);
rec.ssENApprovalProcessLevel.Read( r, ref index);
return rec;
}
// Query Function "GetApprovProcPuestoGerSubdir" S6XWmFxIikW6z1hxvNQOfw of Action "GetSpecialWorkflows"
public static async Task<(RL_8dbe9b3349c28479d314d27fe2f03197,long)> datasetGetApprovProcPuestoGerSubdir(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpprApprovalProcess_ProcessTypeId,long qpenApprovalProcessLevel_EntraRoleId,long qpmaApprovalProcessLevel_ManagementId,long qpsuApprovalProcessLevel_SubdirectionId,bool qpboApprovalProcess_IsDonation,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("c_Requisitions.Wb_IsSpecialOrNormalWF_Popup.GetSpecialWorkflows.GetApprovProcPuestoGerSubdir", "98d6a54b-485c-458a-bacf-5871bcd40e7f");
using var queryActivity = activitySource.CreateAggregateQueryActivity("c_Requisitions.Wb_IsSpecialOrNormalWF_Popup.GetSpecialWorkflows.GetApprovProcPuestoGerSubdir", "98d6a54b-485c-458a-bacf-5871bcd40e7f", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.JIeB93KaO0CekhFmmzHOww/DataActions.5mKf+mwwTEmid4h_aeKFzw/NodesNotShownInESpaceTree.S6XWmFxIikW6z1hxvNQOfw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enapprovalprocess48\".\"id\" o0, \"enapprovalprocess48\".\"processtypeid\" o1, \"enapprovalprocess48\".\"specialworkflowid\" o2, \"enapprovalprocess48\".\"approvalprocesstypeid\" o3, \"enapprovalprocess48\".\"regionid\" o4, \"enapprovalprocess48\".\"accountingregionid\" o5, \"enapprovalprocess48\".\"group\" o6, \"enapprovalprocess48\".\"code\" o7, \"enapprovalprocess48\".\"version\" o8, \"enapprovalprocess48\".\"description\" o9, \"enapprovalprocess48\".\"isactive\" o10, \"enapprovalprocess48\".\"isspecial\" o11, \"enapprovalprocess48\".\"isdonation\" o12, \"enapprovalprocess48\".\"iscxpcorporativo_deprec\" o13, \"enapprovalprocess48\".\"createdby\" o14, \"enapprovalprocess48\".\"createdon\" o15, \"enapprovalprocess48\".\"updatedby\" o16, \"enapprovalprocess48\".\"updatedon\" o17, \"enapprovalprocess48\".\"isselectfirstapprover\" o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44");
fromBuilder.Append(" FROM ({ApprovalProcess} \"enapprovalprocess48\" Left JOIN {ApprovalProcessLevel} \"enapprovalprocesslevel20\" ON (\"enapprovalprocess48\".\"id\" = \"enapprovalprocesslevel20\".\"approvalprocessid\")) ");
whereBuilder.Append(" WHERE ");
if (qpprApprovalProcess_ProcessTypeId != 0) {
whereBuilder.Append("((\"enapprovalprocess48\".\"processtypeid\" = @qpprApprovalProcess_ProcessTypeId) AND (\"enapprovalprocess48\".\"processtypeid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprApprovalProcess_ProcessTypeId", DbType.Int64, qpprApprovalProcess_ProcessTypeId);
} else {
whereBuilder.Append("(\"enapprovalprocess48\".\"processtypeid\" IS NULL)");
}
whereBuilder.Append(" AND ");
if (qpenApprovalProcessLevel_EntraRoleId != 0) {
whereBuilder.Append("((\"enapprovalprocesslevel20\".\"entraroleid\" = @qpenApprovalProcessLevel_EntraRoleId) AND (\"enapprovalprocesslevel20\".\"entraroleid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpenApprovalProcessLevel_EntraRoleId", DbType.Int64, qpenApprovalProcessLevel_EntraRoleId);
} else {
whereBuilder.Append("(\"enapprovalprocesslevel20\".\"entraroleid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enapprovalprocess48\".\"isdonation\" = @qpboApprovalProcess_IsDonation) AND (\"enapprovalprocess48\".\"isactive\" = 1) AND (\"enapprovalprocess48\".\"isspecial\" = 1) AND (\"enapprovalprocesslevel20\".\"isapplicant\" = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboApprovalProcess_IsDonation", DbType.Boolean, qpboApprovalProcess_IsDonation);
if (qpmaApprovalProcessLevel_ManagementId != 0) {
whereBuilder.Append("((\"enapprovalprocesslevel20\".\"managementid\" = @qpmaApprovalProcessLevel_ManagementId) AND (\"enapprovalprocesslevel20\".\"managementid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpmaApprovalProcessLevel_ManagementId", DbType.Int64, qpmaApprovalProcessLevel_ManagementId);
} else {
whereBuilder.Append("(\"enapprovalprocesslevel20\".\"managementid\" IS NULL)");
}
whereBuilder.Append(" AND ");
if (qpsuApprovalProcessLevel_SubdirectionId != 0) {
whereBuilder.Append("((\"enapprovalprocesslevel20\".\"subdirectionid\" = @qpsuApprovalProcessLevel_SubdirectionId) AND (\"enapprovalprocesslevel20\".\"subdirectionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuApprovalProcessLevel_SubdirectionId", DbType.Int64, qpsuApprovalProcessLevel_SubdirectionId);
} else {
whereBuilder.Append("(\"enapprovalprocesslevel20\".\"subdirectionid\" IS NULL)");
}
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
RL_8dbe9b3349c28479d314d27fe2f03197 outParamList = new RL_8dbe9b3349c28479d314d27fe2f03197();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetApprovProcPuestoGerSubdirReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.Wb_IsSpecialOrNormalWF_Popup.GetSpecialWorkflows.GetApprovProcPuestoGerSubdir.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_8dbe9b3349c28479d314d27fe2f03197 _tmp = new RL_8dbe9b3349c28479d314d27fe2f03197();
_tmp.AlternateReadDbMethodAsync = datasetGetApprovProcPuestoGerSubdirReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.Wb_IsSpecialOrNormalWF_Popup.GetSpecialWorkflows.GetApprovProcPuestoGerSubdir.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_8dbe9b3349c28479d314d27fe2f03197)_tmp;
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

private static async Task<RC_1c307c6ba13b1609f542644719b6e56b> datasetGetApprovProcPuestoSubdirReadDbAsync(RC_1c307c6ba13b1609f542644719b6e56b rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApprovalProcess.Read( r, ref index);
rec.ssENApprovalProcessLevel.Read( r, ref index);
return rec;
}
// Query Function "GetApprovProcPuestoSubdir" E+JSunMSdE2i2uYip+e9ZQ of Action "GetSpecialWorkflows"
public static async Task<(RL_8dbe9b3349c28479d314d27fe2f03197,long)> datasetGetApprovProcPuestoSubdir(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpprApprovalProcess_ProcessTypeId,long qpenApprovalProcessLevel_EntraRoleId,long qpsuApprovalProcessLevel_SubdirectionId,bool qpboApprovalProcess_IsDonation,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("c_Requisitions.Wb_IsSpecialOrNormalWF_Popup.GetSpecialWorkflows.GetApprovProcPuestoSubdir", "ba52e213-1273-4d74-a2da-e622a7e7bd65");
using var queryActivity = activitySource.CreateAggregateQueryActivity("c_Requisitions.Wb_IsSpecialOrNormalWF_Popup.GetSpecialWorkflows.GetApprovProcPuestoSubdir", "ba52e213-1273-4d74-a2da-e622a7e7bd65", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.JIeB93KaO0CekhFmmzHOww/DataActions.5mKf+mwwTEmid4h_aeKFzw/NodesNotShownInESpaceTree.E+JSunMSdE2i2uYip+e9ZQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enapprovalprocess49\".\"id\" o0, \"enapprovalprocess49\".\"processtypeid\" o1, \"enapprovalprocess49\".\"specialworkflowid\" o2, \"enapprovalprocess49\".\"approvalprocesstypeid\" o3, \"enapprovalprocess49\".\"regionid\" o4, \"enapprovalprocess49\".\"accountingregionid\" o5, \"enapprovalprocess49\".\"group\" o6, \"enapprovalprocess49\".\"code\" o7, \"enapprovalprocess49\".\"version\" o8, \"enapprovalprocess49\".\"description\" o9, \"enapprovalprocess49\".\"isactive\" o10, \"enapprovalprocess49\".\"isspecial\" o11, \"enapprovalprocess49\".\"isdonation\" o12, \"enapprovalprocess49\".\"iscxpcorporativo_deprec\" o13, \"enapprovalprocess49\".\"createdby\" o14, \"enapprovalprocess49\".\"createdon\" o15, \"enapprovalprocess49\".\"updatedby\" o16, \"enapprovalprocess49\".\"updatedon\" o17, \"enapprovalprocess49\".\"isselectfirstapprover\" o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44");
fromBuilder.Append(" FROM ({ApprovalProcess} \"enapprovalprocess49\" Left JOIN {ApprovalProcessLevel} \"enapprovalprocesslevel21\" ON (\"enapprovalprocess49\".\"id\" = \"enapprovalprocesslevel21\".\"approvalprocessid\")) ");
whereBuilder.Append(" WHERE ");
if (qpprApprovalProcess_ProcessTypeId != 0) {
whereBuilder.Append("((\"enapprovalprocess49\".\"processtypeid\" = @qpprApprovalProcess_ProcessTypeId) AND (\"enapprovalprocess49\".\"processtypeid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprApprovalProcess_ProcessTypeId", DbType.Int64, qpprApprovalProcess_ProcessTypeId);
} else {
whereBuilder.Append("(\"enapprovalprocess49\".\"processtypeid\" IS NULL)");
}
whereBuilder.Append(" AND ");
if (qpenApprovalProcessLevel_EntraRoleId != 0) {
whereBuilder.Append("((\"enapprovalprocesslevel21\".\"entraroleid\" = @qpenApprovalProcessLevel_EntraRoleId) AND (\"enapprovalprocesslevel21\".\"entraroleid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpenApprovalProcessLevel_EntraRoleId", DbType.Int64, qpenApprovalProcessLevel_EntraRoleId);
} else {
whereBuilder.Append("(\"enapprovalprocesslevel21\".\"entraroleid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enapprovalprocess49\".\"isdonation\" = @qpboApprovalProcess_IsDonation) AND (\"enapprovalprocess49\".\"isactive\" = 1) AND (\"enapprovalprocess49\".\"isspecial\" = 1) AND (\"enapprovalprocesslevel21\".\"isapplicant\" = 1) AND (\"enapprovalprocesslevel21\".\"managementid\" IS NULL) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboApprovalProcess_IsDonation", DbType.Boolean, qpboApprovalProcess_IsDonation);
if (qpsuApprovalProcessLevel_SubdirectionId != 0) {
whereBuilder.Append("((\"enapprovalprocesslevel21\".\"subdirectionid\" = @qpsuApprovalProcessLevel_SubdirectionId) AND (\"enapprovalprocesslevel21\".\"subdirectionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuApprovalProcessLevel_SubdirectionId", DbType.Int64, qpsuApprovalProcessLevel_SubdirectionId);
} else {
whereBuilder.Append("(\"enapprovalprocesslevel21\".\"subdirectionid\" IS NULL)");
}
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
RL_8dbe9b3349c28479d314d27fe2f03197 outParamList = new RL_8dbe9b3349c28479d314d27fe2f03197();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetApprovProcPuestoSubdirReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.Wb_IsSpecialOrNormalWF_Popup.GetSpecialWorkflows.GetApprovProcPuestoSubdir.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_8dbe9b3349c28479d314d27fe2f03197 _tmp = new RL_8dbe9b3349c28479d314d27fe2f03197();
_tmp.AlternateReadDbMethodAsync = datasetGetApprovProcPuestoSubdirReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.Wb_IsSpecialOrNormalWF_Popup.GetSpecialWorkflows.GetApprovProcPuestoSubdir.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_8dbe9b3349c28479d314d27fe2f03197)_tmp;
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

private static async Task<RC_1c307c6ba13b1609f542644719b6e56b> datasetGetApprovProcPuestoGerReadDbAsync(RC_1c307c6ba13b1609f542644719b6e56b rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApprovalProcess.Read( r, ref index);
rec.ssENApprovalProcessLevel.Read( r, ref index);
return rec;
}
// Query Function "GetApprovProcPuestoGer" cLn6ugMSVEekJAyhGQQ21g of Action "GetSpecialWorkflows"
public static async Task<(RL_8dbe9b3349c28479d314d27fe2f03197,long)> datasetGetApprovProcPuestoGer(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpprApprovalProcess_ProcessTypeId,long qpenApprovalProcessLevel_EntraRoleId,long qpmaApprovalProcessLevel_ManagementId,bool qpboApprovalProcess_IsDonation,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("c_Requisitions.Wb_IsSpecialOrNormalWF_Popup.GetSpecialWorkflows.GetApprovProcPuestoGer", "bafab970-1203-4754-a424-0ca1190436d6");
using var queryActivity = activitySource.CreateAggregateQueryActivity("c_Requisitions.Wb_IsSpecialOrNormalWF_Popup.GetSpecialWorkflows.GetApprovProcPuestoGer", "bafab970-1203-4754-a424-0ca1190436d6", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.JIeB93KaO0CekhFmmzHOww/DataActions.5mKf+mwwTEmid4h_aeKFzw/NodesNotShownInESpaceTree.cLn6ugMSVEekJAyhGQQ21g, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enapprovalprocess50\".\"id\" o0, \"enapprovalprocess50\".\"processtypeid\" o1, \"enapprovalprocess50\".\"specialworkflowid\" o2, \"enapprovalprocess50\".\"approvalprocesstypeid\" o3, \"enapprovalprocess50\".\"regionid\" o4, \"enapprovalprocess50\".\"accountingregionid\" o5, \"enapprovalprocess50\".\"group\" o6, \"enapprovalprocess50\".\"code\" o7, \"enapprovalprocess50\".\"version\" o8, \"enapprovalprocess50\".\"description\" o9, \"enapprovalprocess50\".\"isactive\" o10, \"enapprovalprocess50\".\"isspecial\" o11, \"enapprovalprocess50\".\"isdonation\" o12, \"enapprovalprocess50\".\"iscxpcorporativo_deprec\" o13, \"enapprovalprocess50\".\"createdby\" o14, \"enapprovalprocess50\".\"createdon\" o15, \"enapprovalprocess50\".\"updatedby\" o16, \"enapprovalprocess50\".\"updatedon\" o17, \"enapprovalprocess50\".\"isselectfirstapprover\" o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44");
fromBuilder.Append(" FROM ({ApprovalProcess} \"enapprovalprocess50\" Left JOIN {ApprovalProcessLevel} \"enapprovalprocesslevel22\" ON (\"enapprovalprocess50\".\"id\" = \"enapprovalprocesslevel22\".\"approvalprocessid\")) ");
whereBuilder.Append(" WHERE ");
if (qpprApprovalProcess_ProcessTypeId != 0) {
whereBuilder.Append("((\"enapprovalprocess50\".\"processtypeid\" = @qpprApprovalProcess_ProcessTypeId) AND (\"enapprovalprocess50\".\"processtypeid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprApprovalProcess_ProcessTypeId", DbType.Int64, qpprApprovalProcess_ProcessTypeId);
} else {
whereBuilder.Append("(\"enapprovalprocess50\".\"processtypeid\" IS NULL)");
}
whereBuilder.Append(" AND ");
if (qpenApprovalProcessLevel_EntraRoleId != 0) {
whereBuilder.Append("((\"enapprovalprocesslevel22\".\"entraroleid\" = @qpenApprovalProcessLevel_EntraRoleId) AND (\"enapprovalprocesslevel22\".\"entraroleid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpenApprovalProcessLevel_EntraRoleId", DbType.Int64, qpenApprovalProcessLevel_EntraRoleId);
} else {
whereBuilder.Append("(\"enapprovalprocesslevel22\".\"entraroleid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enapprovalprocess50\".\"isdonation\" = @qpboApprovalProcess_IsDonation) AND (\"enapprovalprocess50\".\"isactive\" = 1) AND (\"enapprovalprocess50\".\"isspecial\" = 1) AND (\"enapprovalprocesslevel22\".\"isapplicant\" = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboApprovalProcess_IsDonation", DbType.Boolean, qpboApprovalProcess_IsDonation);
if (qpmaApprovalProcessLevel_ManagementId != 0) {
whereBuilder.Append("((\"enapprovalprocesslevel22\".\"managementid\" = @qpmaApprovalProcessLevel_ManagementId) AND (\"enapprovalprocesslevel22\".\"managementid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpmaApprovalProcessLevel_ManagementId", DbType.Int64, qpmaApprovalProcessLevel_ManagementId);
} else {
whereBuilder.Append("(\"enapprovalprocesslevel22\".\"managementid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enapprovalprocesslevel22\".\"subdirectionid\" IS NULL)");
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
RL_8dbe9b3349c28479d314d27fe2f03197 outParamList = new RL_8dbe9b3349c28479d314d27fe2f03197();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetApprovProcPuestoGerReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.Wb_IsSpecialOrNormalWF_Popup.GetSpecialWorkflows.GetApprovProcPuestoGer.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_8dbe9b3349c28479d314d27fe2f03197 _tmp = new RL_8dbe9b3349c28479d314d27fe2f03197();
_tmp.AlternateReadDbMethodAsync = datasetGetApprovProcPuestoGerReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.Wb_IsSpecialOrNormalWF_Popup.GetSpecialWorkflows.GetApprovProcPuestoGer.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_8dbe9b3349c28479d314d27fe2f03197)_tmp;
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


}
