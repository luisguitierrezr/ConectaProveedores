using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_a_Reassignments_Wb_ReassignmentForm_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_a_Reassignments_Wb_ReassignmentForm_ScreenModel).Namespace);

    public bool inParami_IsSidebarOpen;
public string varLcSearch;
public bool varLcl_IsAllowConfirm;
public string varLcl_SourceUserEntraId;
public string varLcl_SourceUserId;
public string varLcl_TargetUserAUEntraId;
public string varLcl_Reason;
public AggregateRecord<RL_3a99147a5a14669e8ced82dd9eebacf0> ScreenDataSetGetSourceUserByEntraId;
public ConectaProveedores_a_Reassignments_Wb_ReassignmentForm_DataActionGetSourceUserContent_Model varLcGetSourceUserContent;
public ConectaProveedores_a_Reassignments_Wb_ReassignmentForm_DataActionGetUsersTarget_Model varLcGetUsersTarget;
public ConectaProveedores_a_Reassignments_Wb_ReassignmentForm_DataActionGetUsersSource_Model varLcGetUsersSource;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_a_Reassignments_Wb_ReassignmentForm_ScreenModel() {
}



    public ConectaProveedores_a_Reassignments_Wb_ReassignmentForm_ScreenModel(bool inParami_IsSidebarOpen, string varLcSearch, bool varLcl_IsAllowConfirm, string varLcl_SourceUserEntraId, string varLcl_SourceUserId, string varLcl_TargetUserAUEntraId, string varLcl_Reason, AggregateRecord<RL_3a99147a5a14669e8ced82dd9eebacf0> ScreenDataSetGetSourceUserByEntraId, ConectaProveedores_a_Reassignments_Wb_ReassignmentForm_DataActionGetSourceUserContent_Model varLcGetSourceUserContent, ConectaProveedores_a_Reassignments_Wb_ReassignmentForm_DataActionGetUsersTarget_Model varLcGetUsersTarget, ConectaProveedores_a_Reassignments_Wb_ReassignmentForm_DataActionGetUsersSource_Model varLcGetUsersSource, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"i_IsSidebarOpen", "Search", "l_IsAllowConfirm", "l_SourceUserEntraId", "l_SourceUserId", "l_TargetUserAUEntraId", "l_Reason", "GetSourceUserByEntraId", "GetSourceUserContent", "GetUsersTarget", "GetUsersSource", "ClientVars"}, new string[] {"inParami_IsSidebarOpen", "varLcSearch", "varLcl_IsAllowConfirm", "varLcl_SourceUserEntraId", "varLcl_SourceUserId", "varLcl_TargetUserAUEntraId", "varLcl_Reason", "ScreenDataSetGetSourceUserByEntraId", "varLcGetSourceUserContent", "varLcGetUsersTarget", "varLcGetUsersSource", "clientVariables"});
this.inParami_IsSidebarOpen = inParami_IsSidebarOpen;
this.varLcSearch = varLcSearch;
this.varLcl_IsAllowConfirm = varLcl_IsAllowConfirm;
this.varLcl_SourceUserEntraId = varLcl_SourceUserEntraId;
this.varLcl_SourceUserId = varLcl_SourceUserId;
this.varLcl_TargetUserAUEntraId = varLcl_TargetUserAUEntraId;
this.varLcl_Reason = varLcl_Reason;
this.ScreenDataSetGetSourceUserByEntraId = ScreenDataSetGetSourceUserByEntraId;
this.varLcGetSourceUserContent = varLcGetSourceUserContent;
this.varLcGetUsersTarget = varLcGetUsersTarget;
this.varLcGetUsersSource = varLcGetUsersSource;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_6783422774b4547f1160d86529102520> datasetGetSourceUserByEntraIdReadDbAsync(RC_6783422774b4547f1160d86529102520 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApplicationRole.Read( r, ref index);
rec.ssENEntraRole.Read( r, ref index);
rec.ssENRoleConcept.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
rec.ssENUserExtension.Read( r, ref index);
return rec;
}
// Query Function "GetSourceUserByEntraId" LNse50hYaEGGHJmKsvZS_Q of Action "Wb_ReassignmentForm"
public static async Task<(RL_3a99147a5a14669e8ced82dd9eebacf0,long)> datasetGetSourceUserByEntraId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteUser_Extended_Internal_EntraId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("a_Reassignments.Wb_ReassignmentForm.GetSourceUserByEntraId", "e71edb2c-5848-4168-861c-998ab2f652fd");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_ReassignmentForm","a_Reassignments.Wb_ReassignmentForm.GetSourceUserByEntraId");
// Query Iterations: Never
// Refresh Query FV4LOYka9EipOQrxMRIdQQ Iterations: Never
// Refresh Query sX7eWxcbWkS754zzXG3mNQ Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.Qvz9+rKa_kOxTGMcUzy7oA/NodesShownInESpaceTree.sRVnucIDYU2+vu44WPBlyw/ScreenDataSets.LNse50hYaEGGHJmKsvZS_Q, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, \"enuser217\".\"id\" o17, NULL o18, \"enuser217\".\"email\" o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, \"enuser_extended_internal127\".\"regionid\" o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, \"enuser_extended_internal127\".\"telceldireccion\" o41, NULL o42, \"enuserextension77\".\"correspondentexternalemail\" o43, NULL o44");
fromBuilder.Append(" FROM ((((({User_Extended_Internal} \"enuser_extended_internal127\" Inner JOIN {User} \"enuser217\" ON (\"enuser_extended_internal127\".\"id\" = \"enuser217\".\"id\"))  Left JOIN {UserExtension} \"enuserextension77\" ON (\"enuser217\".\"id\" = \"enuserextension77\".\"id\"))  Left JOIN {EntraRole} \"enentrarole73\" ON (\"enuser_extended_internal127\".\"entraroleid\" = \"enentrarole73\".\"id\"))  Left JOIN {RoleConcept} \"enroleconcept28\" ON (\"enentrarole73\".\"id\" = \"enroleconcept28\".\"entraroleid\"))  Left JOIN {ApplicationRole} \"enapplicationrole80\" ON (\"enroleconcept28\".\"applicationroleid\" = \"enapplicationrole80\".\"id\")) ");
whereBuilder.Append(" WHERE (\"enuser_extended_internal127\".\"entraid\" = @qpteUser_Extended_Internal_EntraId) AND (\"enapplicationrole80\".\"isareausuaria\" = 1)");
sqlCmd.CreateParameterWithoutReplacements("@qpteUser_Extended_Internal_EntraId", DbType.String, qpteUser_Extended_Internal_EntraId);
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
RL_3a99147a5a14669e8ced82dd9eebacf0 outParamList = new RL_3a99147a5a14669e8ced82dd9eebacf0();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetSourceUserByEntraIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[6];
opt[0] = new BitArray(new bool[] {false, true, false, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, false, true});
opt[5] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query a_Reassignments.Wb_ReassignmentForm.GetSourceUserByEntraId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_3a99147a5a14669e8ced82dd9eebacf0 _tmp = new RL_3a99147a5a14669e8ced82dd9eebacf0();
_tmp.AlternateReadDbMethodAsync = datasetGetSourceUserByEntraIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query a_Reassignments.Wb_ReassignmentForm.GetSourceUserByEntraId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_3a99147a5a14669e8ced82dd9eebacf0)_tmp;
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


    public class lcvGetSourceUserContent : VarsBag {
public RL_1f3e9ea72dc7b010c56ee9146ee277c5 queryResGetRequisitions_outParamList = new RL_1f3e9ea72dc7b010c56ee9146ee277c5();
public long queryResGetRequisitions_outParamCount = 0L;

public RL_e8a2bfdbad62aa404e80d55d80faa387 queryResGetInvoices_outParamList = new RL_e8a2bfdbad62aa404e80d55d80faa387();
public long queryResGetInvoices_outParamCount = 0L;

public lcvGetSourceUserContent() {
}
}
public class lcoGetSourceUserContent : VarsBag {
public RL_6f013a7f2ef00b964b6e71f1ec07b189 outParamReqList = new RL_6f013a7f2ef00b964b6e71f1ec07b189();

public RL_8c69b09c6d811e27e13cdf810a622fb2 outParamInvList = new RL_8c69b09c6d811e27e13cdf810a622fb2();

public lcoGetSourceUserContent() {
}
}
/// <summary>
/// Action <code>GetSourceUserContent</code> that represents the Service Studio action
///  <code>GetSourceUserContent</code> <p> Description: </p>
/// </summary>
public async Task<(RL_6f013a7f2ef00b964b6e71f1ec07b189,RL_8c69b09c6d811e27e13cdf810a622fb2)> DataActionGetSourceUserContent(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_6f013a7f2ef00b964b6e71f1ec07b189 outParamReqList = default;
RL_8c69b09c6d811e27e13cdf810a622fb2 outParamInvList = default;
lcoGetSourceUserContent result = new lcoGetSourceUserContent();
lcvGetSourceUserContent localVars = new lcvGetSourceUserContent();
ConectaProveedores_a_Reassignments_Wb_ReassignmentForm_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetSourceUserContent", "0003791f-5947-4044-8d78-6ad52795fd9c"))
using (activitySource.CreateScreenDataActionActivity("Wb_ReassignmentForm", "GetSourceUserContent")){
// Query datasetGetRequisitions
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitions_maxRecords = 0;
int datasetGetRequisitions_startIndex = 0;(localVars.queryResGetRequisitions_outParamList,localVars.queryResGetRequisitions_outParamCount) = await FuncDataActionGetSourceUserContent.datasetGetRequisitions(requestContext,datasetGetRequisitions_maxRecords,datasetGetRequisitions_startIndex,IterationMultiplicity.Multiple,varLcl_SourceUserId,cancellationToken);

// Query datasetGetInvoices
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoices_maxRecords = 0;
int datasetGetInvoices_startIndex = 0;(localVars.queryResGetInvoices_outParamList,localVars.queryResGetInvoices_outParamCount) = await FuncDataActionGetSourceUserContent.datasetGetInvoices(requestContext,datasetGetInvoices_maxRecords,datasetGetInvoices_startIndex,IterationMultiplicity.Multiple,varLcl_SourceUserId,cancellationToken);

// ReqListClear
await ExtendedActions.ListClear(requestContext,result.outParamReqList,cancellationToken);

// InvListClear
await ExtendedActions.ListClear(requestContext,result.outParamInvList,cancellationToken);

// ListAppendAll
await ExtendedActions.ListAppendAll(requestContext,result.outParamReqList,(await RL_6f013a7f2ef00b964b6e71f1ec07b189.ConvertAsync(localVars.queryResGetRequisitions_outParamList, new RL_6f013a7f2ef00b964b6e71f1ec07b189(), async (RC_11c2ac4c5bdce01960ee8371ad40d262 source, RC_da31ba4ed131103eb5a5b5464cca7643 target, CancellationToken cancellationToken) => {
target.ssIsAccounting = source.ssENRequisitionApprovalLevel.ssIsAccounting;
target.ssIsSelected = false;
target.ssRequisitionApprovalLevelId = source.ssENRequisitionApprovalLevel.ssId;
target.ssRequisitionId = source.ssENRequisitionApproval.ssRequisitionId;
target.ssRequisitionName = source.ssENRequisition.ssName;
return target;
}, cancellationToken)),cancellationToken);

// ListAppendAll2
await ExtendedActions.ListAppendAll(requestContext,result.outParamInvList,(await RL_8c69b09c6d811e27e13cdf810a622fb2.ConvertAsync(localVars.queryResGetInvoices_outParamList, new RL_8c69b09c6d811e27e13cdf810a622fb2(), async (RC_bc68025e789d69992aef27aed0947c65 source, RC_9f414d82ade67cb4131fecd8fda64580 target, CancellationToken cancellationToken) => {
target.ssInvoiceApprovalLevelId = source.ssENInvoiceApprovalLevel.ssId;
target.ssInvoiceId = source.ssENInvoiceApproval.ssInvoiceId;
target.ssInvoiceName = source.ssENInvoice.ssName;
target.ssIsAccounting = source.ssENInvoiceApprovalLevel.ssIsAccounting;
target.ssIsSelected = false;
return target;
}, cancellationToken)),cancellationToken);

} //close CreateActionActivity using block
} // try

finally {
outParamReqList = result.outParamReqList;
outParamInvList = result.outParamInvList;
} // inner-finally
RETURN_STATEMENT:
return (outParamReqList,outParamInvList);
}
public class lcvGetUsersTarget : VarsBag {
/// <summary>
/// Variable <code>l_UserTargetListAUTemp</code> that represents the Service Studio
///  EmailEntraIdNameRoleRecordList <code>l_UserTargetListAUTemp</code> <p>Description
/// : UserTargetList</p>
/// </summary>
public RL_144725d7e52a72fc566c148009197c7e varLcl_UserTargetListAUTemp = new RL_144725d7e52a72fc566c148009197c7e();

/// <summary>
/// Variable <code>UserOrigRolesListText</code> that represents the Service Studio Text
///  <code>UserOrigRolesListText</code> <p>Description: UserOrigRolesListText</p>
/// </summary>
public string varLcUserOrigRolesListText = "";

/// <summary>
/// Variable <code>UserLoggedRolesListText</code> that represents the Service Studio Text
///  <code>UserLoggedRolesListText</code> <p>Description: UserOrigRolesListText</p>
/// </summary>
public string varLcUserLoggedRolesListText = "";

public int resListIndexOf_outParamPosition = 0;

public RL_137ca0bd922b82f91f39dd017e999a51 queryResGetRoleConceptUserOrig_outParamList = new RL_137ca0bd922b82f91f39dd017e999a51();
public long queryResGetRoleConceptUserOrig_outParamCount = 0L;

public RL_3a99147a5a14669e8ced82dd9eebacf0 queryResGetUserTargetListAUSameLevelUserOrig_outParamList = new RL_3a99147a5a14669e8ced82dd9eebacf0();
public long queryResGetUserTargetListAUSameLevelUserOrig_outParamCount = 0L;

public RL_137ca0bd922b82f91f39dd017e999a51 queryResGetRoleConceptLoggedUser_outParamList = new RL_137ca0bd922b82f91f39dd017e999a51();
public long queryResGetRoleConceptLoggedUser_outParamCount = 0L;

public RL_c5c32c91f72d14efd2c0ccca15008afa queryResGetUserById_outParamList = new RL_c5c32c91f72d14efd2c0ccca15008afa();
public long queryResGetUserById_outParamCount = 0L;

public int resListIndexOf2_outParamPosition = 0;

public RL_c68f8e92ccdada3f2f3589e091be34b8 resGetUserManagersUntilEmailFound_outParamResponse = new RL_c68f8e92ccdada3f2f3589e091be34b8();
public ST_38509e9fbd36a9b928c2f4e34a1342aeStructure resGetUserManagersUntilEmailFound_outParamResult = new ST_38509e9fbd36a9b928c2f4e34a1342aeStructure();

public RL_3a99147a5a14669e8ced82dd9eebacf0 queryResGetUserTargetListAUSameLevelUserDest_outParamList = new RL_3a99147a5a14669e8ced82dd9eebacf0();
public long queryResGetUserTargetListAUSameLevelUserDest_outParamCount = 0L;

public lcvGetUsersTarget() {
}
}
public class lcoGetUsersTarget : VarsBag {
public RL_144725d7e52a72fc566c148009197c7e outParamo_UserTargetListAU = new RL_144725d7e52a72fc566c148009197c7e();

public lcoGetUsersTarget() {
}
}
/// <summary>
/// Action <code>GetUsersTarget</code> that represents the Service Studio action
///  <code>GetUsersTarget</code> <p> Description: </p>
/// </summary>
public async Task<RL_144725d7e52a72fc566c148009197c7e> DataActionGetUsersTarget(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_144725d7e52a72fc566c148009197c7e outParamo_UserTargetListAU = default;
lcoGetUsersTarget result = new lcoGetUsersTarget();
lcvGetUsersTarget localVars = new lcvGetUsersTarget();
ConectaProveedores_a_Reassignments_Wb_ReassignmentForm_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetUsersTarget", "296b6aa2-90f9-48e2-ba58-605be8df35fb"))
using (activitySource.CreateScreenDataActionActivity("Wb_ReassignmentForm", "GetUsersTarget")){
// ListClear2
await ExtendedActions.ListClear(requestContext,localVars.varLcl_UserTargetListAUTemp,cancellationToken);

// ListClear
await ExtendedActions.ListClear(requestContext,result.outParamo_UserTargetListAU,cancellationToken);

// Query datasetGetUserById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserById_maxRecords = 1;
if (datasetGetUserById_maxRecords < 1) datasetGetUserById_maxRecords = 1;
int datasetGetUserById_startIndex = 0;(localVars.queryResGetUserById_outParamList,localVars.queryResGetUserById_outParamCount) = await FuncDataActionGetUsersTarget.datasetGetUserById(requestContext,datasetGetUserById_maxRecords,datasetGetUserById_startIndex,IterationMultiplicity.Never,BuiltInFunction.GetUserId (),cancellationToken);

// GetUserManagersUntilEmailFound
(localVars.resGetUserManagersUntilEmailFound_outParamResponse,localVars.resGetUserManagersUntilEmailFound_outParamResult) = await Actions.ActionGetUserManagersUntilEmailFound(requestContext,(((ScreenDataSetGetSourceUserByEntraId.List.CurrentRec.ssENUserExtension.ssCorrespondentExternalEmail!="")) ? (ScreenDataSetGetSourceUserByEntraId.List.CurrentRec.ssENUserExtension.ssCorrespondentExternalEmail) : (ScreenDataSetGetSourceUserByEntraId.List.CurrentRec.ssENUser.ssEmail)),false,(((localVars.queryResGetUserById_outParamList.CurrentRec.ssENUserExtension.ssCorrespondentExternalEmail!="")) ? (localVars.queryResGetUserById_outParamList.CurrentRec.ssENUserExtension.ssCorrespondentExternalEmail) : (localVars.queryResGetUserById_outParamList.CurrentRec.ssENUser.ssEmail)),cancellationToken);

// ListAppendAll2
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcl_UserTargetListAUTemp,(await RL_144725d7e52a72fc566c148009197c7e.ConvertAsync(localVars.resGetUserManagersUntilEmailFound_outParamResponse, new RL_144725d7e52a72fc566c148009197c7e(), async (ST_d32097d2629a99529d77b865dae9fb0cStructure source, RC_18c2d75e8e190384e64859e7ed1d4f00 target, CancellationToken cancellationToken) => {
target.ssEmail = source.ssMail;
target.ssEntraId = source.ssId;
target.ssName = source.ssDisplayName;
target.ssRole = source.ssJobTitle;
return target;
}, cancellationToken)),cancellationToken);

// Query datasetGetRoleConceptUserOrig
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRoleConceptUserOrig_maxRecords = 0;
int datasetGetRoleConceptUserOrig_startIndex = 0;(localVars.queryResGetRoleConceptUserOrig_outParamList,localVars.queryResGetRoleConceptUserOrig_outParamCount) = await FuncDataActionGetUsersTarget.datasetGetRoleConceptUserOrig(requestContext,datasetGetRoleConceptUserOrig_maxRecords,datasetGetRoleConceptUserOrig_startIndex,IterationMultiplicity.Single,ScreenDataSetGetSourceUserByEntraId.List.CurrentRec.ssENUser.ssId,cancellationToken);

// Foreach GetRoleConceptUserOrig.List
localVars.queryResGetRoleConceptUserOrig_outParamList.StartIteration();
try {while (!((localVars.queryResGetRoleConceptUserOrig_outParamList.Eof))) {
// UserOrigRolesListText = UserOrigRolesListText + "," + GetRoleConceptUserOrig.List.Current.ApplicationRole.Id
localVars.varLcUserOrigRolesListText=((localVars.varLcUserOrigRolesListText+",")+BuiltInFunction.LongIntegerToText(localVars.queryResGetRoleConceptUserOrig_outParamList.CurrentRec.ssENApplicationRole.ssId));
localVars.queryResGetRoleConceptUserOrig_outParamList.Advance();
}

} finally {
localVars.queryResGetRoleConceptUserOrig_outParamList.EndIteration();
}

// Query datasetGetRoleConceptLoggedUser
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRoleConceptLoggedUser_maxRecords = 0;
int datasetGetRoleConceptLoggedUser_startIndex = 0;(localVars.queryResGetRoleConceptLoggedUser_outParamList,localVars.queryResGetRoleConceptLoggedUser_outParamCount) = await FuncDataActionGetUsersTarget.datasetGetRoleConceptLoggedUser(requestContext,datasetGetRoleConceptLoggedUser_maxRecords,datasetGetRoleConceptLoggedUser_startIndex,IterationMultiplicity.Single,BuiltInFunction.GetUserId (),cancellationToken);

// Foreach GetRoleConceptLoggedUser.List
localVars.queryResGetRoleConceptLoggedUser_outParamList.StartIteration();
try {while (!((localVars.queryResGetRoleConceptLoggedUser_outParamList.Eof))) {
// UserLoggedRolesListText = UserLoggedRolesListText + "," + GetRoleConceptLoggedUser.List.Current.ApplicationRole.Id
localVars.varLcUserLoggedRolesListText=((localVars.varLcUserLoggedRolesListText+",")+BuiltInFunction.LongIntegerToText(localVars.queryResGetRoleConceptLoggedUser_outParamList.CurrentRec.ssENApplicationRole.ssId));
localVars.queryResGetRoleConceptLoggedUser_outParamList.Advance();
}

} finally {
localVars.queryResGetRoleConceptLoggedUser_outParamList.EndIteration();
}

// Query datasetGetUserTargetListAUSameLevelUserOrig
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserTargetListAUSameLevelUserOrig_maxRecords = 0;
int datasetGetUserTargetListAUSameLevelUserOrig_startIndex = 0;(localVars.queryResGetUserTargetListAUSameLevelUserOrig_outParamList,localVars.queryResGetUserTargetListAUSameLevelUserOrig_outParamCount) = await FuncDataActionGetUsersTarget.datasetGetUserTargetListAUSameLevelUserOrig(requestContext,datasetGetUserTargetListAUSameLevelUserOrig_maxRecords,datasetGetUserTargetListAUSameLevelUserOrig_startIndex,IterationMultiplicity.Single,ScreenDataSetGetSourceUserByEntraId.List.CurrentRec.ssENUser_Extended_Internal.ssRegionId,ScreenDataSetGetSourceUserByEntraId.List.CurrentRec.ssENUser_Extended_Internal.ssTelcelDireccion,ScreenDataSetGetSourceUserByEntraId.List.CurrentRec.ssENUser.ssId,localVars.varLcUserOrigRolesListText,cancellationToken);

// Foreach GetUserTargetListAUSameLevelUserOrig.List
localVars.queryResGetUserTargetListAUSameLevelUserOrig_outParamList.StartIteration();
try {while (!((localVars.queryResGetUserTargetListAUSameLevelUserOrig_outParamList.Eof))) {
// ListIndexOf
localVars.resListIndexOf_outParamPosition = await ExtendedActions.ListIndexOf(requestContext,localVars.varLcl_UserTargetListAUTemp,async (p, cancellationToken) => ((p.ssEmail==localVars.queryResGetUserTargetListAUSameLevelUserOrig_outParamList.CurrentRec.ssENUser.ssEmail)||(p.ssEmail==localVars.queryResGetUserTargetListAUSameLevelUserOrig_outParamList.CurrentRec.ssENUserExtension.ssCorrespondentExternalEmail)),cancellationToken);

if(((localVars.resListIndexOf_outParamPosition==(-1)))) {
// ListAppend2
await ExtendedActions.ListAppend(requestContext,localVars.varLcl_UserTargetListAUTemp,(await RecordUtils.ConvertAsync(localVars.queryResGetUserTargetListAUSameLevelUserOrig_outParamList.CurrentRec, new RC_18c2d75e8e190384e64859e7ed1d4f00(), async (RC_6783422774b4547f1160d86529102520 source, RC_18c2d75e8e190384e64859e7ed1d4f00 target, CancellationToken cancellationToken) => {
target.ssEmail = (((source.ssENUserExtension.ssCorrespondentExternalEmail!="")) ? (source.ssENUserExtension.ssCorrespondentExternalEmail) : (source.ssENUser.ssEmail));
target.ssEntraId = source.ssENUser_Extended_Internal.ssEntraId;
target.ssName = source.ssENUser.ssName;
target.ssRole = source.ssENUser_Extended_Internal.ssJobTitle;
return target;
}, cancellationToken)),cancellationToken);

}

localVars.queryResGetUserTargetListAUSameLevelUserOrig_outParamList.Advance();
}

} finally {
localVars.queryResGetUserTargetListAUSameLevelUserOrig_outParamList.EndIteration();
}

// Query datasetGetUserTargetListAUSameLevelUserDest
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserTargetListAUSameLevelUserDest_maxRecords = 0;
int datasetGetUserTargetListAUSameLevelUserDest_startIndex = 0;(localVars.queryResGetUserTargetListAUSameLevelUserDest_outParamList,localVars.queryResGetUserTargetListAUSameLevelUserDest_outParamCount) = await FuncDataActionGetUsersTarget.datasetGetUserTargetListAUSameLevelUserDest(requestContext,datasetGetUserTargetListAUSameLevelUserDest_maxRecords,datasetGetUserTargetListAUSameLevelUserDest_startIndex,IterationMultiplicity.Single,ScreenDataSetGetSourceUserByEntraId.List.CurrentRec.ssENUser_Extended_Internal.ssRegionId,ScreenDataSetGetSourceUserByEntraId.List.CurrentRec.ssENUser_Extended_Internal.ssTelcelDireccion,BuiltInFunction.GetUserId (),localVars.varLcUserLoggedRolesListText,cancellationToken);

// Foreach GetUserTargetListAUSameLevelUserDest.List
localVars.queryResGetUserTargetListAUSameLevelUserDest_outParamList.StartIteration();
try {while (!((localVars.queryResGetUserTargetListAUSameLevelUserDest_outParamList.Eof))) {
// ListIndexOf2
localVars.resListIndexOf2_outParamPosition = await ExtendedActions.ListIndexOf(requestContext,localVars.varLcl_UserTargetListAUTemp,async (p, cancellationToken) => ((p.ssEmail==localVars.queryResGetUserTargetListAUSameLevelUserDest_outParamList.CurrentRec.ssENUser.ssEmail)||(p.ssEmail==localVars.queryResGetUserTargetListAUSameLevelUserDest_outParamList.CurrentRec.ssENUserExtension.ssCorrespondentExternalEmail)),cancellationToken);

if(((localVars.resListIndexOf2_outParamPosition==(-1)))) {
// ListAppend
await ExtendedActions.ListAppend(requestContext,localVars.varLcl_UserTargetListAUTemp,(await RecordUtils.ConvertAsync(localVars.queryResGetUserTargetListAUSameLevelUserDest_outParamList.CurrentRec, new RC_18c2d75e8e190384e64859e7ed1d4f00(), async (RC_6783422774b4547f1160d86529102520 source, RC_18c2d75e8e190384e64859e7ed1d4f00 target, CancellationToken cancellationToken) => {
target.ssEmail = (((source.ssENUserExtension.ssCorrespondentExternalEmail!="")) ? (source.ssENUserExtension.ssCorrespondentExternalEmail) : (source.ssENUser.ssEmail));
target.ssEntraId = source.ssENUser_Extended_Internal.ssEntraId;
target.ssName = source.ssENUser.ssName;
target.ssRole = source.ssENUser_Extended_Internal.ssJobTitle;
return target;
}, cancellationToken)),cancellationToken);

}

localVars.queryResGetUserTargetListAUSameLevelUserDest_outParamList.Advance();
}

} finally {
localVars.queryResGetUserTargetListAUSameLevelUserDest_outParamList.EndIteration();
}

// ListSortUserTargetListAUTemp
await ExtendedActions.ListSort(requestContext,localVars.varLcl_UserTargetListAUTemp,async (p, cancellationToken) => p.ssName,true,cancellationToken);

// ListAppendAll
await ExtendedActions.ListAppendAll(requestContext,result.outParamo_UserTargetListAU,localVars.varLcl_UserTargetListAUTemp,cancellationToken);

} //close CreateActionActivity using block
} // try

finally {
outParamo_UserTargetListAU = result.outParamo_UserTargetListAU;
} // inner-finally
RETURN_STATEMENT:
return outParamo_UserTargetListAU;
}
public class lcvGetUsersSource : VarsBag {
public RL_33aa275c739b8b537ec846fb1cac5907 resGetAllReports_outParamDirectReports = new RL_33aa275c739b8b537ec846fb1cac5907();

public RL_c5c32c91f72d14efd2c0ccca15008afa queryResGetUser_outParamList = new RL_c5c32c91f72d14efd2c0ccca15008afa();
public long queryResGetUser_outParamCount = 0L;

public lcvGetUsersSource() {
}
}
public class lcoGetUsersSource : VarsBag {
public RL_33aa275c739b8b537ec846fb1cac5907 outParamo_DirectReportsList = new RL_33aa275c739b8b537ec846fb1cac5907();

public bool outParamo_HasError = false;

public lcoGetUsersSource() {
}
}
/// <summary>
/// Action <code>GetUsersSource</code> that represents the Service Studio action
///  <code>GetUsersSource</code> <p> Description: </p>
/// </summary>
public async Task<(RL_33aa275c739b8b537ec846fb1cac5907,bool)> DataActionGetUsersSource(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_33aa275c739b8b537ec846fb1cac5907 outParamo_DirectReportsList = default;
bool outParamo_HasError = default;
lcoGetUsersSource result = new lcoGetUsersSource();
lcvGetUsersSource localVars = new lcvGetUsersSource();
ConectaProveedores_a_Reassignments_Wb_ReassignmentForm_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetUsersSource", "cdc89d7d-5ea7-44f0-8c7c-0956e37c50e3"))
using (activitySource.CreateScreenDataActionActivity("Wb_ReassignmentForm", "GetUsersSource")){
// Query datasetGetUser
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUser_maxRecords = 1;
if (datasetGetUser_maxRecords < 1) datasetGetUser_maxRecords = 1;
int datasetGetUser_startIndex = 0;(localVars.queryResGetUser_outParamList,localVars.queryResGetUser_outParamCount) = await FuncDataActionGetUsersSource.datasetGetUser(requestContext,datasetGetUser_maxRecords,datasetGetUser_startIndex,IterationMultiplicity.Never,BuiltInFunction.GetUserId (),cancellationToken);

// Empty?
if((!(localVars.queryResGetUser_outParamList.Empty))) {
// GetAllReports
localVars.resGetAllReports_outParamDirectReports = await Actions.ActionGetAllReports(requestContext,(((localVars.queryResGetUser_outParamList.CurrentRec.ssENUserExtension.ssCorrespondentExternalEmail!="")) ? (localVars.queryResGetUser_outParamList.CurrentRec.ssENUserExtension.ssCorrespondentExternalEmail) : (localVars.queryResGetUser_outParamList.CurrentRec.ssENUser.ssEmail)),cancellationToken);

// o_DirectReportsList = GetAllReports.DirectReports
result.outParamo_DirectReportsList=localVars.resGetAllReports_outParamDirectReports;
}

} //close CreateActionActivity using block
} // try

catch (Exception ex) {
ApplicationLogger.Error(ex, "Error executing action");
requestContext.LastException = ex;

// Error Handler
await DatabaseAccess.RollbackAllTransactionsAsync(cancellationToken);

// o_HasError = True
result.outParamo_HasError=true;
goto RETURN_STATEMENT;

} // Catch
finally {
outParamo_DirectReportsList = result.outParamo_DirectReportsList;
outParamo_HasError = result.outParamo_HasError;
cancellationToken.ThrowIfCancellationRequested();
} // inner-finally
RETURN_STATEMENT:
return (outParamo_DirectReportsList,outParamo_HasError);
}


    public static class FuncDataActionGetSourceUserContent {

private static async Task<RC_11c2ac4c5bdce01960ee8371ad40d262> datasetGetRequisitionsReadDbAsync(RC_11c2ac4c5bdce01960ee8371ad40d262 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENRequisition.Read( r, ref index);
rec.ssENRequisitionApproval.Read( r, ref index);
rec.ssENRequisitionApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetRequisitions" guS6GqvZJUWMtiXfriZaOQ of Action "GetSourceUserContent"
public static async Task<(RL_1f3e9ea72dc7b010c56ee9146ee277c5,long)> datasetGetRequisitions(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusRequisitionApprovalLevel_AssignedTo,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("a_Reassignments.Wb_ReassignmentForm.GetSourceUserContent.GetRequisitions", "1abae482-d9ab-4525-8cb6-25dfae265a39");
using var queryActivity = activitySource.CreateAggregateQueryActivity("a_Reassignments.Wb_ReassignmentForm.GetSourceUserContent.GetRequisitions", "1abae482-d9ab-4525-8cb6-25dfae265a39", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.Qvz9+rKa_kOxTGMcUzy7oA/NodesShownInESpaceTree.sRVnucIDYU2+vu44WPBlyw/DataActions.H3kDAEdZRECNeGrVJ5X9nA/NodesNotShownInESpaceTree.guS6GqvZJUWMtiXfriZaOQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enrequisition128\".\"name\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, \"enrequisitionapproval34\".\"requisitionid\" o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, \"enrequisitionapprovallevel30\".\"id\" o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, \"enrequisitionapprovallevel30\".\"isaccounting\" o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93");
fromBuilder.Append(" FROM (({Requisition} \"enrequisition128\" Left JOIN {RequisitionApproval} \"enrequisitionapproval34\" ON (\"enrequisition128\".\"id\" = \"enrequisitionapproval34\".\"requisitionid\"))  Left JOIN {RequisitionApprovalLevel} \"enrequisitionapprovallevel30\" ON (\"enrequisitionapproval34\".\"id\" = \"enrequisitionapprovallevel30\".\"requisitionapprovalid\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusRequisitionApprovalLevel_AssignedTo.Trim()!="")) {
whereBuilder.Append("((\"enrequisitionapprovallevel30\".\"assignedto\" = @qpusRequisitionApprovalLevel_AssignedTo) AND (\"enrequisitionapprovallevel30\".\"assignedto\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusRequisitionApprovalLevel_AssignedTo", DbType.String, qpusRequisitionApprovalLevel_AssignedTo);
} else {
whereBuilder.Append("(\"enrequisitionapprovallevel30\".\"assignedto\" IS NULL)");
}
whereBuilder.Append(" AND (\"enrequisitionapprovallevel30\".\"approvalstatusid\" = ");
whereBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId);
whereBuilder.Append(")");
orderByBuilder.Append(" ORDER BY \"enrequisition128\".\"name\" ASC ");
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
RL_1f3e9ea72dc7b010c56ee9146ee277c5 outParamList = new RL_1f3e9ea72dc7b010c56ee9146ee277c5();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetRequisitionsReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query a_Reassignments.Wb_ReassignmentForm.GetSourceUserContent.GetRequisitions.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_1f3e9ea72dc7b010c56ee9146ee277c5 _tmp = new RL_1f3e9ea72dc7b010c56ee9146ee277c5();
_tmp.AlternateReadDbMethodAsync = datasetGetRequisitionsReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query a_Reassignments.Wb_ReassignmentForm.GetSourceUserContent.GetRequisitions.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_1f3e9ea72dc7b010c56ee9146ee277c5)_tmp;
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

private static async Task<RC_bc68025e789d69992aef27aed0947c65> datasetGetInvoicesReadDbAsync(RC_bc68025e789d69992aef27aed0947c65 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceApproval.Read( r, ref index);
rec.ssENInvoiceApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetInvoices" Pxbjgrkiyka9OWU_xy_ALg of Action "GetSourceUserContent"
public static async Task<(RL_e8a2bfdbad62aa404e80d55d80faa387,long)> datasetGetInvoices(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusInvoiceApprovalLevel_AssignedTo,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("a_Reassignments.Wb_ReassignmentForm.GetSourceUserContent.GetInvoices", "82e3163f-22b9-46ca-bd39-653fc72fc02e");
using var queryActivity = activitySource.CreateAggregateQueryActivity("a_Reassignments.Wb_ReassignmentForm.GetSourceUserContent.GetInvoices", "82e3163f-22b9-46ca-bd39-653fc72fc02e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.Qvz9+rKa_kOxTGMcUzy7oA/NodesShownInESpaceTree.sRVnucIDYU2+vu44WPBlyw/DataActions.H3kDAEdZRECNeGrVJ5X9nA/NodesNotShownInESpaceTree.Pxbjgrkiyka9OWU_xy_ALg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"eninvoice144\".\"name\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, \"eninvoiceapproval45\".\"invoiceid\" o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, \"eninvoiceapprovallevel44\".\"id\" o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, \"eninvoiceapprovallevel44\".\"isaccounting\" o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58");
fromBuilder.Append(" FROM (({Invoice} \"eninvoice144\" Left JOIN {InvoiceApproval} \"eninvoiceapproval45\" ON (\"eninvoice144\".\"id\" = \"eninvoiceapproval45\".\"invoiceid\"))  Left JOIN {InvoiceApprovalLevel} \"eninvoiceapprovallevel44\" ON (\"eninvoiceapproval45\".\"id\" = \"eninvoiceapprovallevel44\".\"invoiceapprovalid\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusInvoiceApprovalLevel_AssignedTo.Trim()!="")) {
whereBuilder.Append("((\"eninvoiceapprovallevel44\".\"assignedto\" = @qpusInvoiceApprovalLevel_AssignedTo) AND (\"eninvoiceapprovallevel44\".\"assignedto\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusInvoiceApprovalLevel_AssignedTo", DbType.String, qpusInvoiceApprovalLevel_AssignedTo);
} else {
whereBuilder.Append("(\"eninvoiceapprovallevel44\".\"assignedto\" IS NULL)");
}
whereBuilder.Append(" AND (\"eninvoiceapprovallevel44\".\"approvalstatusid\" = ");
whereBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId);
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
RL_e8a2bfdbad62aa404e80d55d80faa387 outParamList = new RL_e8a2bfdbad62aa404e80d55d80faa387();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoicesReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query a_Reassignments.Wb_ReassignmentForm.GetSourceUserContent.GetInvoices.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_e8a2bfdbad62aa404e80d55d80faa387 _tmp = new RL_e8a2bfdbad62aa404e80d55d80faa387();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoicesReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query a_Reassignments.Wb_ReassignmentForm.GetSourceUserContent.GetInvoices.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_e8a2bfdbad62aa404e80d55d80faa387)_tmp;
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
public static class FuncDataActionGetUsersTarget {

private static async Task<RC_7b8200225d1e3acafed4d42f9fce9055> datasetGetRoleConceptUserOrigReadDbAsync(RC_7b8200225d1e3acafed4d42f9fce9055 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApplicationRole.Read( r, ref index);
rec.ssENEntraRole.Read( r, ref index);
rec.ssENRoleConcept.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
return rec;
}
// Query Function "GetRoleConceptUserOrig" l4rAJYPjv0apRK8YgJiBag of Action "GetUsersTarget"
public static async Task<(RL_137ca0bd922b82f91f39dd017e999a51,long)> datasetGetRoleConceptUserOrig(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("a_Reassignments.Wb_ReassignmentForm.GetUsersTarget.GetRoleConceptUserOrig", "25c08a97-e383-46bf-a944-af188098816a");
using var queryActivity = activitySource.CreateAggregateQueryActivity("a_Reassignments.Wb_ReassignmentForm.GetUsersTarget.GetRoleConceptUserOrig", "25c08a97-e383-46bf-a944-af188098816a", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.Qvz9+rKa_kOxTGMcUzy7oA/NodesShownInESpaceTree.sRVnucIDYU2+vu44WPBlyw/DataActions.omprKfmQ4ki6WGBb6N81+w/NodesNotShownInESpaceTree.l4rAJYPjv0apRK8YgJiBag, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enapplicationrole81\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41");
fromBuilder.Append(" FROM (((({User_Extended_Internal} \"enuser_extended_internal128\" Inner JOIN {User} \"enuser218\" ON (\"enuser_extended_internal128\".\"id\" = \"enuser218\".\"id\"))  Inner JOIN {EntraRole} \"enentrarole74\" ON (\"enuser_extended_internal128\".\"entraroleid\" = \"enentrarole74\".\"id\"))  Left JOIN {RoleConcept} \"enroleconcept29\" ON (\"enentrarole74\".\"id\" = \"enroleconcept29\".\"entraroleid\"))  Left JOIN {ApplicationRole} \"enapplicationrole81\" ON (\"enroleconcept29\".\"applicationroleid\" = \"enapplicationrole81\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser218\".\"id\" = @qpusUser_Id) AND (\"enuser218\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser218\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (\"enroleconcept29\".\"conceptid\" = ");
whereBuilder.Append(3
);
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
RL_137ca0bd922b82f91f39dd017e999a51 outParamList = new RL_137ca0bd922b82f91f39dd017e999a51();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetRoleConceptUserOrigReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[5];
opt[0] = new BitArray(new bool[] {true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true});
opt[2] = new BitArray(new bool[] {false, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query a_Reassignments.Wb_ReassignmentForm.GetUsersTarget.GetRoleConceptUserOrig.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_137ca0bd922b82f91f39dd017e999a51 _tmp = new RL_137ca0bd922b82f91f39dd017e999a51();
_tmp.AlternateReadDbMethodAsync = datasetGetRoleConceptUserOrigReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query a_Reassignments.Wb_ReassignmentForm.GetUsersTarget.GetRoleConceptUserOrig.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_137ca0bd922b82f91f39dd017e999a51)_tmp;
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

private static async Task<RC_6783422774b4547f1160d86529102520> datasetGetUserTargetListAUSameLevelUserOrigReadDbAsync(RC_6783422774b4547f1160d86529102520 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApplicationRole.Read( r, ref index);
rec.ssENEntraRole.Read( r, ref index);
rec.ssENRoleConcept.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
rec.ssENUserExtension.Read( r, ref index);
return rec;
}
// Query Function "GetUserTargetListAUSameLevelUserOrig" TgJcUrM7U06fh5c5xHMEOQ of Action "GetUsersTarget"
public static async Task<(RL_3a99147a5a14669e8ced82dd9eebacf0,long)> datasetGetUserTargetListAUSameLevelUserOrig(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreUser_Extended_Internal_RegionId,string qpteUser_Extended_Internal_TelcelDireccion,string qpusUser_Id,string qpteUserOrigRolesListText,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("a_Reassignments.Wb_ReassignmentForm.GetUsersTarget.GetUserTargetListAUSameLevelUserOrig", "525c024e-3bb3-4e53-9f87-9739c4730439");
using var queryActivity = activitySource.CreateAggregateQueryActivity("a_Reassignments.Wb_ReassignmentForm.GetUsersTarget.GetUserTargetListAUSameLevelUserOrig", "525c024e-3bb3-4e53-9f87-9739c4730439", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.Qvz9+rKa_kOxTGMcUzy7oA/NodesShownInESpaceTree.sRVnucIDYU2+vu44WPBlyw/DataActions.omprKfmQ4ki6WGBb6N81+w/NodesNotShownInESpaceTree.TgJcUrM7U06fh5c5xHMEOQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, \"enuser219\".\"name\" o18, \"enuser219\".\"email\" o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, \"enuser_extended_internal129\".\"jobtitle\" o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, \"enuser_extended_internal129\".\"entraid\" o40, NULL o41, NULL o42, \"enuserextension78\".\"correspondentexternalemail\" o43, NULL o44");
fromBuilder.Append(" FROM ((((({User_Extended_Internal} \"enuser_extended_internal129\" Inner JOIN {User} \"enuser219\" ON (\"enuser_extended_internal129\".\"id\" = \"enuser219\".\"id\"))  Inner JOIN {EntraRole} \"enentrarole75\" ON (\"enuser_extended_internal129\".\"entraroleid\" = \"enentrarole75\".\"id\"))  Inner JOIN {RoleConcept} \"enroleconcept30\" ON (\"enentrarole75\".\"id\" = \"enroleconcept30\".\"entraroleid\"))  Inner JOIN {ApplicationRole} \"enapplicationrole82\" ON (\"enroleconcept30\".\"applicationroleid\" = \"enapplicationrole82\".\"id\"))  Left JOIN {UserExtension} \"enuserextension78\" ON (\"enuser219\".\"id\" = \"enuserextension78\".\"id\")) ");
whereBuilder.Append(" WHERE (\"enuser_extended_internal129\".\"telceldireccion\" = @qpteUser_Extended_Internal_TelcelDireccion) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteUser_Extended_Internal_TelcelDireccion", DbType.String, qpteUser_Extended_Internal_TelcelDireccion);
if (qpreUser_Extended_Internal_RegionId != 0) {
whereBuilder.Append("((\"enuser_extended_internal129\".\"regionid\" = @qpreUser_Extended_Internal_RegionId) AND (\"enuser_extended_internal129\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreUser_Extended_Internal_RegionId", DbType.Int64, qpreUser_Extended_Internal_RegionId);
} else {
whereBuilder.Append("(\"enuser_extended_internal129\".\"regionid\" IS NULL)");
}
whereBuilder.Append(" AND (((CASE WHEN char_length(caseaccent_normalize(cast(\"enapplicationrole82\".\"id\" as text) collate \"default\"))=0 THEN -1 ELSE (position(caseaccent_normalize(cast(\"enapplicationrole82\".\"id\" as text) collate \"default\") in caseaccent_normalize(@qpteUserOrigRolesListText collate \"default\"))-1) END)) <> (-1)) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteUserOrigRolesListText", DbType.String, qpteUserOrigRolesListText);
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser219\".\"id\" <> @qpusUser_Id) OR (\"enuser219\".\"id\" IS NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser219\".\"id\" IS NOT NULL)");
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
RL_3a99147a5a14669e8ced82dd9eebacf0 outParamList = new RL_3a99147a5a14669e8ced82dd9eebacf0();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetUserTargetListAUSameLevelUserOrigReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[6];
opt[0] = new BitArray(new bool[] {true, false, false, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, false, true});
opt[5] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, false, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query a_Reassignments.Wb_ReassignmentForm.GetUsersTarget.GetUserTargetListAUSameLevelUserOrig.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_3a99147a5a14669e8ced82dd9eebacf0 _tmp = new RL_3a99147a5a14669e8ced82dd9eebacf0();
_tmp.AlternateReadDbMethodAsync = datasetGetUserTargetListAUSameLevelUserOrigReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query a_Reassignments.Wb_ReassignmentForm.GetUsersTarget.GetUserTargetListAUSameLevelUserOrig.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_3a99147a5a14669e8ced82dd9eebacf0)_tmp;
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

private static async Task<RC_7b8200225d1e3acafed4d42f9fce9055> datasetGetRoleConceptLoggedUserReadDbAsync(RC_7b8200225d1e3acafed4d42f9fce9055 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApplicationRole.Read( r, ref index);
rec.ssENEntraRole.Read( r, ref index);
rec.ssENRoleConcept.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
return rec;
}
// Query Function "GetRoleConceptLoggedUser" OcnTniI8j0atm7Eb12yrpw of Action "GetUsersTarget"
public static async Task<(RL_137ca0bd922b82f91f39dd017e999a51,long)> datasetGetRoleConceptLoggedUser(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("a_Reassignments.Wb_ReassignmentForm.GetUsersTarget.GetRoleConceptLoggedUser", "9ed3c939-3c22-468f-ad9b-b11bd76caba7");
using var queryActivity = activitySource.CreateAggregateQueryActivity("a_Reassignments.Wb_ReassignmentForm.GetUsersTarget.GetRoleConceptLoggedUser", "9ed3c939-3c22-468f-ad9b-b11bd76caba7", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.Qvz9+rKa_kOxTGMcUzy7oA/NodesShownInESpaceTree.sRVnucIDYU2+vu44WPBlyw/DataActions.omprKfmQ4ki6WGBb6N81+w/NodesNotShownInESpaceTree.OcnTniI8j0atm7Eb12yrpw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enapplicationrole83\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41");
fromBuilder.Append(" FROM (((({User_Extended_Internal} \"enuser_extended_internal130\" Inner JOIN {User} \"enuser220\" ON (\"enuser_extended_internal130\".\"id\" = \"enuser220\".\"id\"))  Inner JOIN {EntraRole} \"enentrarole76\" ON (\"enuser_extended_internal130\".\"entraroleid\" = \"enentrarole76\".\"id\"))  Left JOIN {RoleConcept} \"enroleconcept31\" ON (\"enentrarole76\".\"id\" = \"enroleconcept31\".\"entraroleid\"))  Left JOIN {ApplicationRole} \"enapplicationrole83\" ON (\"enroleconcept31\".\"applicationroleid\" = \"enapplicationrole83\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser220\".\"id\" = @qpusUser_Id) AND (\"enuser220\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser220\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (\"enroleconcept31\".\"conceptid\" = ");
whereBuilder.Append(3
);
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
RL_137ca0bd922b82f91f39dd017e999a51 outParamList = new RL_137ca0bd922b82f91f39dd017e999a51();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetRoleConceptLoggedUserReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[5];
opt[0] = new BitArray(new bool[] {true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true});
opt[2] = new BitArray(new bool[] {false, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query a_Reassignments.Wb_ReassignmentForm.GetUsersTarget.GetRoleConceptLoggedUser.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_137ca0bd922b82f91f39dd017e999a51 _tmp = new RL_137ca0bd922b82f91f39dd017e999a51();
_tmp.AlternateReadDbMethodAsync = datasetGetRoleConceptLoggedUserReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query a_Reassignments.Wb_ReassignmentForm.GetUsersTarget.GetRoleConceptLoggedUser.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_137ca0bd922b82f91f39dd017e999a51)_tmp;
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

private static async Task<RC_e6a121d9e10463243528b9fbc6a71f2e> datasetGetUserByIdReadDbAsync(RC_e6a121d9e10463243528b9fbc6a71f2e rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENUser.Read( r, ref index);
rec.ssENUserExtension.Read( r, ref index);
return rec;
}
// Query Function "GetUserById" zYUhslG05EKl+Vf937c7Vw of Action "GetUsersTarget"
public static async Task<(RL_c5c32c91f72d14efd2c0ccca15008afa,long)> datasetGetUserById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("a_Reassignments.Wb_ReassignmentForm.GetUsersTarget.GetUserById", "b22185cd-b451-42e4-a5f9-57fddfb73b57");
using var queryActivity = activitySource.CreateAggregateQueryActivity("a_Reassignments.Wb_ReassignmentForm.GetUsersTarget.GetUserById", "b22185cd-b451-42e4-a5f9-57fddfb73b57", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.Qvz9+rKa_kOxTGMcUzy7oA/NodesShownInESpaceTree.sRVnucIDYU2+vu44WPBlyw/DataActions.omprKfmQ4ki6WGBb6N81+w/NodesNotShownInESpaceTree.zYUhslG05EKl+Vf937c7Vw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"enuser221\".\"email\" o2, NULL o3, NULL o4, NULL o5, \"enuserextension79\".\"correspondentexternalemail\" o6, NULL o7");
fromBuilder.Append(" FROM ({User} \"enuser221\" Left JOIN {UserExtension} \"enuserextension79\" ON (\"enuser221\".\"id\" = \"enuserextension79\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser221\".\"id\" = @qpusUser_Id) AND (\"enuser221\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser221\".\"id\" IS NULL)");
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
RL_c5c32c91f72d14efd2c0ccca15008afa outParamList = new RL_c5c32c91f72d14efd2c0ccca15008afa();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetUserByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, false, true, true});
opt[1] = new BitArray(new bool[] {true, false, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query a_Reassignments.Wb_ReassignmentForm.GetUsersTarget.GetUserById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_c5c32c91f72d14efd2c0ccca15008afa _tmp = new RL_c5c32c91f72d14efd2c0ccca15008afa();
_tmp.AlternateReadDbMethodAsync = datasetGetUserByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query a_Reassignments.Wb_ReassignmentForm.GetUsersTarget.GetUserById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_c5c32c91f72d14efd2c0ccca15008afa)_tmp;
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

private static async Task<RC_6783422774b4547f1160d86529102520> datasetGetUserTargetListAUSameLevelUserDestReadDbAsync(RC_6783422774b4547f1160d86529102520 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApplicationRole.Read( r, ref index);
rec.ssENEntraRole.Read( r, ref index);
rec.ssENRoleConcept.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
rec.ssENUserExtension.Read( r, ref index);
return rec;
}
// Query Function "GetUserTargetListAUSameLevelUserDest" dK8v3LFpuEqOQR7zAo8Yuw of Action "GetUsersTarget"
public static async Task<(RL_3a99147a5a14669e8ced82dd9eebacf0,long)> datasetGetUserTargetListAUSameLevelUserDest(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreUser_Extended_Internal_RegionId,string qpteUser_Extended_Internal_TelcelDireccion,string qpusUser_Id,string qpteUserLoggedRolesListText,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("a_Reassignments.Wb_ReassignmentForm.GetUsersTarget.GetUserTargetListAUSameLevelUserDest", "dc2faf74-69b1-4ab8-8e41-1ef3028f18bb");
using var queryActivity = activitySource.CreateAggregateQueryActivity("a_Reassignments.Wb_ReassignmentForm.GetUsersTarget.GetUserTargetListAUSameLevelUserDest", "dc2faf74-69b1-4ab8-8e41-1ef3028f18bb", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.Qvz9+rKa_kOxTGMcUzy7oA/NodesShownInESpaceTree.sRVnucIDYU2+vu44WPBlyw/DataActions.omprKfmQ4ki6WGBb6N81+w/NodesNotShownInESpaceTree.dK8v3LFpuEqOQR7zAo8Yuw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, \"enuser222\".\"name\" o18, \"enuser222\".\"email\" o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, \"enuser_extended_internal131\".\"jobtitle\" o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, \"enuser_extended_internal131\".\"entraid\" o40, NULL o41, NULL o42, \"enuserextension80\".\"correspondentexternalemail\" o43, NULL o44");
fromBuilder.Append(" FROM ((((({User_Extended_Internal} \"enuser_extended_internal131\" Inner JOIN {User} \"enuser222\" ON (\"enuser_extended_internal131\".\"id\" = \"enuser222\".\"id\"))  Inner JOIN {EntraRole} \"enentrarole77\" ON (\"enuser_extended_internal131\".\"entraroleid\" = \"enentrarole77\".\"id\"))  Inner JOIN {RoleConcept} \"enroleconcept32\" ON (\"enentrarole77\".\"id\" = \"enroleconcept32\".\"entraroleid\"))  Inner JOIN {ApplicationRole} \"enapplicationrole84\" ON (\"enroleconcept32\".\"applicationroleid\" = \"enapplicationrole84\".\"id\"))  Left JOIN {UserExtension} \"enuserextension80\" ON (\"enuser222\".\"id\" = \"enuserextension80\".\"id\")) ");
whereBuilder.Append(" WHERE (\"enuser_extended_internal131\".\"telceldireccion\" = @qpteUser_Extended_Internal_TelcelDireccion) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteUser_Extended_Internal_TelcelDireccion", DbType.String, qpteUser_Extended_Internal_TelcelDireccion);
if (qpreUser_Extended_Internal_RegionId != 0) {
whereBuilder.Append("((\"enuser_extended_internal131\".\"regionid\" = @qpreUser_Extended_Internal_RegionId) AND (\"enuser_extended_internal131\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreUser_Extended_Internal_RegionId", DbType.Int64, qpreUser_Extended_Internal_RegionId);
} else {
whereBuilder.Append("(\"enuser_extended_internal131\".\"regionid\" IS NULL)");
}
whereBuilder.Append(" AND (((CASE WHEN char_length(caseaccent_normalize(cast(\"enapplicationrole84\".\"id\" as text) collate \"default\"))=0 THEN -1 ELSE (position(caseaccent_normalize(cast(\"enapplicationrole84\".\"id\" as text) collate \"default\") in caseaccent_normalize(@qpteUserLoggedRolesListText collate \"default\"))-1) END)) <> (-1)) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteUserLoggedRolesListText", DbType.String, qpteUserLoggedRolesListText);
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser222\".\"id\" <> @qpusUser_Id) OR (\"enuser222\".\"id\" IS NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser222\".\"id\" IS NOT NULL)");
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
RL_3a99147a5a14669e8ced82dd9eebacf0 outParamList = new RL_3a99147a5a14669e8ced82dd9eebacf0();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetUserTargetListAUSameLevelUserDestReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[6];
opt[0] = new BitArray(new bool[] {true, false, false, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, false, true});
opt[5] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, false, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query a_Reassignments.Wb_ReassignmentForm.GetUsersTarget.GetUserTargetListAUSameLevelUserDest.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_3a99147a5a14669e8ced82dd9eebacf0 _tmp = new RL_3a99147a5a14669e8ced82dd9eebacf0();
_tmp.AlternateReadDbMethodAsync = datasetGetUserTargetListAUSameLevelUserDestReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query a_Reassignments.Wb_ReassignmentForm.GetUsersTarget.GetUserTargetListAUSameLevelUserDest.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_3a99147a5a14669e8ced82dd9eebacf0)_tmp;
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
public static class FuncDataActionGetUsersSource {

private static async Task<RC_e6a121d9e10463243528b9fbc6a71f2e> datasetGetUserReadDbAsync(RC_e6a121d9e10463243528b9fbc6a71f2e rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENUser.Read( r, ref index);
rec.ssENUserExtension.Read( r, ref index);
return rec;
}
// Query Function "GetUser" mzPE4NR56kKHclVE0QkAuA of Action "GetUsersSource"
public static async Task<(RL_c5c32c91f72d14efd2c0ccca15008afa,long)> datasetGetUser(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("a_Reassignments.Wb_ReassignmentForm.GetUsersSource.GetUser", "e0c4339b-79d4-42ea-8772-5544d10900b8");
using var queryActivity = activitySource.CreateAggregateQueryActivity("a_Reassignments.Wb_ReassignmentForm.GetUsersSource.GetUser", "e0c4339b-79d4-42ea-8772-5544d10900b8", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.Qvz9+rKa_kOxTGMcUzy7oA/NodesShownInESpaceTree.sRVnucIDYU2+vu44WPBlyw/DataActions.fZ3Izade8ESMfAlW43xQ4w/NodesNotShownInESpaceTree.mzPE4NR56kKHclVE0QkAuA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"enuser223\".\"email\" o2, NULL o3, NULL o4, NULL o5, \"enuserextension81\".\"correspondentexternalemail\" o6, NULL o7");
fromBuilder.Append(" FROM ({User} \"enuser223\" Left JOIN {UserExtension} \"enuserextension81\" ON (\"enuser223\".\"id\" = \"enuserextension81\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser223\".\"id\" = @qpusUser_Id) AND (\"enuser223\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser223\".\"id\" IS NULL)");
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
RL_c5c32c91f72d14efd2c0ccca15008afa outParamList = new RL_c5c32c91f72d14efd2c0ccca15008afa();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetUserReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, false, true, true});
opt[1] = new BitArray(new bool[] {true, false, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query a_Reassignments.Wb_ReassignmentForm.GetUsersSource.GetUser.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_c5c32c91f72d14efd2c0ccca15008afa _tmp = new RL_c5c32c91f72d14efd2c0ccca15008afa();
_tmp.AlternateReadDbMethodAsync = datasetGetUserReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query a_Reassignments.Wb_ReassignmentForm.GetUsersSource.GetUser.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_c5c32c91f72d14efd2c0ccca15008afa)_tmp;
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
