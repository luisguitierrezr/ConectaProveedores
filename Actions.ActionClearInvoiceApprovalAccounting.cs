namespace ssConectaProveedores;

public partial class Actions {
public class lcvClearInvoiceApprovalAccounting : VarsBag {
public long inParami_InvoiceId;
public long inParami_ApprovalProcessId;
/// <summary>
/// Variable <code>l_CurrentLevel</code> that represents the Service Studio Integer
///  <code>l_CurrentLevel</code> <p>Description: </p>
/// </summary>
public int varLcl_CurrentLevel = 0;

/// <summary>
/// Variable <code>l_FirstAccountingApprovalLevel</code> that represents the Service Studio
///  InvoiceApprovalLevel <code>l_FirstAccountingApprovalLevel</code> <p>Description: </p>
/// </summary>
public EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord varLcl_FirstAccountingApprovalLevel = new EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord();

public RL_2fd4ee9249069fb78258eb73022e4cb9 queryResGetANALISTA_CXP_outParamList = new RL_2fd4ee9249069fb78258eb73022e4cb9();
public long queryResGetANALISTA_CXP_outParamCount = 0L;

public Actions.lcoInvoiceCreateOrUpdate resInvoiceCreateOrUpdate3 =  new Actions.lcoInvoiceCreateOrUpdate();
public Actions.lcoInvoiceApprovalLevelCreateOrUpdate resInvoiceApprovalLevelCreateOrUpdate2 =  new Actions.lcoInvoiceApprovalLevelCreateOrUpdate();
public RL_c851528f2bd72df8d6fa01fc1d7dda59 queryResGetInvoiceById_outParamList = new RL_c851528f2bd72df8d6fa01fc1d7dda59();
public long queryResGetInvoiceById_outParamCount = 0L;

public Actions.lcoInvoiceApprovalLevelCreateOrUpdate resInvoiceApprovalLevelCreateOrUpdate3 =  new Actions.lcoInvoiceApprovalLevelCreateOrUpdate();
public RL_5e0ca6ca9da3af4b1d8149758c39c2cf queryResGetApprovalProcess_outParamList = new RL_5e0ca6ca9da3af4b1d8149758c39c2cf();
public long queryResGetApprovalProcess_outParamCount = 0L;

public Actions.lcoGetStartAccounting resGetStartAccounting =  new Actions.lcoGetStartAccounting();
public RL_ccf70f600f06def33a14ca10a1120a68 queryResGetInvoiceAccountingsByInvoiceId_outParamList = new RL_ccf70f600f06def33a14ca10a1120a68();
public long queryResGetInvoiceAccountingsByInvoiceId_outParamCount = 0L;

public Actions.lcoInvoiceApprovalCreateOrUpdate resInvoiceApprovalCreateOrUpdate =  new Actions.lcoInvoiceApprovalCreateOrUpdate();
public Actions.lcoInvoiceCreateOrUpdate resInvoiceCreateOrUpdate4 =  new Actions.lcoInvoiceCreateOrUpdate();
public Actions.lcoInvoiceApprovalCreateOrUpdate resInvoiceApprovalCreateOrUpdate2 =  new Actions.lcoInvoiceApprovalCreateOrUpdate();
public RL_e8a2bfdbad62aa404e80d55d80faa387 queryResGetInvoiceApprovalLevels_outParamList = new RL_e8a2bfdbad62aa404e80d55d80faa387();
public long queryResGetInvoiceApprovalLevels_outParamCount = 0L;

public Actions.lcoInvoiceStatusHistoryCreateOrUpdate resInvoiceStatusHistoryCreateOrUpdate3 =  new Actions.lcoInvoiceStatusHistoryCreateOrUpdate();
public Actions.lcoInvoiceAccountingCreateOrUpdate resInvoiceAccountingCreateOrUpdate =  new Actions.lcoInvoiceAccountingCreateOrUpdate();
public RL_e8a2bfdbad62aa404e80d55d80faa387 resListFilter_outParamFilteredList = new RL_e8a2bfdbad62aa404e80d55d80faa387();

public lcvClearInvoiceApprovalAccounting(long inParami_InvoiceId, long inParami_ApprovalProcessId) {
this.inParami_InvoiceId = inParami_InvoiceId;
this.inParami_ApprovalProcessId = inParami_ApprovalProcessId;
}
}
public class lcoClearInvoiceApprovalAccounting : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public lcoClearInvoiceApprovalAccounting() {
}
}
/// <summary>
/// Action <code>ClearInvoiceApprovalAccounting</code> that represents the Service Studio action
///  <code>ClearInvoiceApprovalAccounting</code> <p> Description: </p>
/// </summary>
public static async Task<ST_046fb53ebbe142526d95e87ef1ae9711Structure> ActionClearInvoiceApprovalAccounting(IRequestContext requestContext,long inParami_InvoiceId,long inParami_ApprovalProcessId,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
lcoClearInvoiceApprovalAccounting result = new lcoClearInvoiceApprovalAccounting();
lcvClearInvoiceApprovalAccounting localVars = new lcvClearInvoiceApprovalAccounting(inParami_InvoiceId, inParami_ApprovalProcessId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("ClearInvoiceApprovalAccounting", "ab260287-b4f5-4029-8e48-17ff4781c3bd"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("ClearInvoiceApprovalAccounting", "ab260287-b4f5-4029-8e48-17ff4781c3bd", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetInvoiceApprovalLevels
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceApprovalLevels_maxRecords = 0;
int datasetGetInvoiceApprovalLevels_startIndex = 0;(localVars.queryResGetInvoiceApprovalLevels_outParamList,localVars.queryResGetInvoiceApprovalLevels_outParamCount) = await FuncActionClearInvoiceApprovalAccounting.datasetGetInvoiceApprovalLevels(requestContext,datasetGetInvoiceApprovalLevels_maxRecords,datasetGetInvoiceApprovalLevels_startIndex,IterationMultiplicity.Multiple,localVars.inParami_InvoiceId,cancellationToken);

// Foreach GetInvoiceApprovalLevels.List
localVars.queryResGetInvoiceApprovalLevels_outParamList.StartIteration();
try {while (!((localVars.queryResGetInvoiceApprovalLevels_outParamList.Eof))) {
// IsAccounting?
if((localVars.queryResGetInvoiceApprovalLevels_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssIsAccounting)) {
if(((localVars.varLcl_FirstAccountingApprovalLevel.ssId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// l_FirstAccountingApprovalLevel = GetInvoiceApprovalLevels.List.Current.InvoiceApprovalLevel
localVars.varLcl_FirstAccountingApprovalLevel=localVars.queryResGetInvoiceApprovalLevels_outParamList.CurrentRec.ssENInvoiceApprovalLevel;
}

} else {
// l_CurrentLevel = GetInvoiceApprovalLevels.List.Current.InvoiceApprovalLevel.LevelNumber
localVars.varLcl_CurrentLevel=localVars.queryResGetInvoiceApprovalLevels_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssLevelNumber;
}

localVars.queryResGetInvoiceApprovalLevels_outParamList.Advance();
}

} finally {
localVars.queryResGetInvoiceApprovalLevels_outParamList.EndIteration();
}

if(((localVars.varLcl_FirstAccountingApprovalLevel.ssId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// Query datasetGetApprovalProcess
cancellationToken.ThrowIfCancellationRequested();
int datasetGetApprovalProcess_maxRecords = 1;
if (datasetGetApprovalProcess_maxRecords < 1) datasetGetApprovalProcess_maxRecords = 1;
int datasetGetApprovalProcess_startIndex = 0;(localVars.queryResGetApprovalProcess_outParamList,localVars.queryResGetApprovalProcess_outParamCount) = await FuncActionClearInvoiceApprovalAccounting.datasetGetApprovalProcess(requestContext,datasetGetApprovalProcess_maxRecords,datasetGetApprovalProcess_startIndex,IterationMultiplicity.Never,localVars.inParami_ApprovalProcessId,cancellationToken);

// ReqApprovalProcess found?
if(((localVars.queryResGetApprovalProcess_outParamList.CurrentRec.ssENApprovalProcess.ssId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// Query datasetGetInvoiceById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceById_maxRecords = 1;
if (datasetGetInvoiceById_maxRecords < 1) datasetGetInvoiceById_maxRecords = 1;
int datasetGetInvoiceById_startIndex = 0;(localVars.queryResGetInvoiceById_outParamList,localVars.queryResGetInvoiceById_outParamCount) = await FuncActionClearInvoiceApprovalAccounting.datasetGetInvoiceById(requestContext,datasetGetInvoiceById_maxRecords,datasetGetInvoiceById_startIndex,IterationMultiplicity.Never,localVars.inParami_InvoiceId,cancellationToken);

// GetStartAccounting
(localVars.resGetStartAccounting.outParami_AssignTo,localVars.resGetStartAccounting.outParamo_ApprovalProcessLevel) = await Actions.ActionGetStartAccounting(requestContext,localVars.queryResGetApprovalProcess_outParamList.CurrentRec.ssENApprovalProcess.ssId,localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENRegion.ssCommissionRegion,localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENRequisition.ssRegionId,cancellationToken);

// Empty?
if(((localVars.resGetStartAccounting.outParamo_ApprovalProcessLevel.ssId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// o_Output
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "No role in the workflow indicates where accounting starts."
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("XsHoiKfZfE6lZbr5rt__Uw#Value.-136829869.1", "No role in the workflow indicates where accounting starts.");
goto RETURN_STATEMENT;

} else {
// l_FirstAccountingApprovalLevel
// l_FirstAccountingApprovalLevel.Id = NullIdentifier
localVars.varLcl_FirstAccountingApprovalLevel.ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ());

// l_FirstAccountingApprovalLevel.InvoiceApprovalId = GetInvoiceApprovalLevels.List.Current.InvoiceApproval.Id
localVars.varLcl_FirstAccountingApprovalLevel.ssInvoiceApprovalId = localVars.queryResGetInvoiceApprovalLevels_outParamList.CurrentRec.ssENInvoiceApproval.ssId;

// l_FirstAccountingApprovalLevel.LevelNumber = GetInvoiceApprovalLevels.List.Current.InvoiceApproval.CurrentLevel + 1
localVars.varLcl_FirstAccountingApprovalLevel.ssLevelNumber = (localVars.queryResGetInvoiceApprovalLevels_outParamList.CurrentRec.ssENInvoiceApproval.ssCurrentLevel+1);

// l_FirstAccountingApprovalLevel.SelectsNextApprover = GetStartAccounting.o_ApprovalProcessLevel.SelectsNextApprover
localVars.varLcl_FirstAccountingApprovalLevel.ssSelectsNextApprover = localVars.resGetStartAccounting.outParamo_ApprovalProcessLevel.ssSelectsNextApprover;

// l_FirstAccountingApprovalLevel.ApprovalStatusId = If
localVars.varLcl_FirstAccountingApprovalLevel.ssApprovalStatusId = ((localVars.resGetStartAccounting.outParamo_ApprovalProcessLevel.ssSelectsNextApprover) ? ((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("BjgcXy0kFU+8e5Ko3emFig"))).ssId) : ((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId));

// l_FirstAccountingApprovalLevel.IsStartAccounting = True
localVars.varLcl_FirstAccountingApprovalLevel.ssIsStartAccounting = true;

// l_FirstAccountingApprovalLevel.IsAccounting = True
localVars.varLcl_FirstAccountingApprovalLevel.ssIsAccounting = true;

// l_FirstAccountingApprovalLevel.AssignedTo = GetStartAccounting.i_AssignTo
localVars.varLcl_FirstAccountingApprovalLevel.ssAssignedTo = localVars.resGetStartAccounting.outParami_AssignTo;

// l_FirstAccountingApprovalLevel.ApplicationRoleId = GetStartAccounting.o_ApprovalProcessLevel.ApplicationRoleId
localVars.varLcl_FirstAccountingApprovalLevel.ssApplicationRoleId = localVars.resGetStartAccounting.outParamo_ApprovalProcessLevel.ssApplicationRoleId;
}

} else {
// Query datasetGetANALISTA_CXP
cancellationToken.ThrowIfCancellationRequested();
int datasetGetANALISTA_CXP_maxRecords = 1;
if (datasetGetANALISTA_CXP_maxRecords < 1) datasetGetANALISTA_CXP_maxRecords = 1;
int datasetGetANALISTA_CXP_startIndex = 0;(localVars.queryResGetANALISTA_CXP_outParamList,localVars.queryResGetANALISTA_CXP_outParamCount) = await FuncActionClearInvoiceApprovalAccounting.datasetGetANALISTA_CXP(requestContext,datasetGetANALISTA_CXP_maxRecords,datasetGetANALISTA_CXP_startIndex,IterationMultiplicity.Never,cancellationToken);

// Empty?
if((localVars.queryResGetANALISTA_CXP_outParamList.Empty)) {
// o_Output
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "ANALISTA_CXP - Analista CxP/Egresos role has not yet been created."
result.outParamo_Output.ssMessage = "ANALISTA_CXP - Analista CxP/Egresos role has not yet been created.";
goto RETURN_STATEMENT;

} else {
// l_FirstAccountingApprovalLevel
// l_FirstAccountingApprovalLevel.Id = NullIdentifier
localVars.varLcl_FirstAccountingApprovalLevel.ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ());

// l_FirstAccountingApprovalLevel.InvoiceApprovalId = GetInvoiceApprovalLevels.List.Current.InvoiceApproval.Id
localVars.varLcl_FirstAccountingApprovalLevel.ssInvoiceApprovalId = localVars.queryResGetInvoiceApprovalLevels_outParamList.CurrentRec.ssENInvoiceApproval.ssId;

// l_FirstAccountingApprovalLevel.LevelNumber = GetInvoiceApprovalLevels.List.Current.InvoiceApproval.CurrentLevel + 1
localVars.varLcl_FirstAccountingApprovalLevel.ssLevelNumber = (localVars.queryResGetInvoiceApprovalLevels_outParamList.CurrentRec.ssENInvoiceApproval.ssCurrentLevel+1);

// l_FirstAccountingApprovalLevel.ApplicationRoleId = GetANALISTA_CXP.List.Current.ApplicationRole.Id
localVars.varLcl_FirstAccountingApprovalLevel.ssApplicationRoleId = localVars.queryResGetANALISTA_CXP_outParamList.CurrentRec.ssENApplicationRole.ssId;

// l_FirstAccountingApprovalLevel.ApprovalStatusId = NotApproved
localVars.varLcl_FirstAccountingApprovalLevel.ssApprovalStatusId = (ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId;

// l_FirstAccountingApprovalLevel.IsAccounting = True
localVars.varLcl_FirstAccountingApprovalLevel.ssIsAccounting = true;

// l_FirstAccountingApprovalLevel.IsStartAccounting = True
localVars.varLcl_FirstAccountingApprovalLevel.ssIsStartAccounting = true;
}

}

// InApproval_CxP
// GetInvoiceApprovalLevels.List.Current.Invoice.InvoiceStatusId = InApproval_CxP
localVars.queryResGetInvoiceApprovalLevels_outParamList.CurrentRec.ssENInvoice.ssInvoiceStatusId = (ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("IImA0NKHIEiNrWap8beugQ"))).ssId;

// GetInvoiceApprovalLevels.List.Current.InvoiceApproval.HasStartedAccounting = True
localVars.queryResGetInvoiceApprovalLevels_outParamList.CurrentRec.ssENInvoiceApproval.ssHasStartedAccounting = true;

// GetInvoiceApprovalLevels.List.Current.InvoiceApproval.CurrentLevel = l_FirstAccountingApprovalLevel.LevelNumber
localVars.queryResGetInvoiceApprovalLevels_outParamList.CurrentRec.ssENInvoiceApproval.ssCurrentLevel = localVars.varLcl_FirstAccountingApprovalLevel.ssLevelNumber;
// InvoiceCreateOrUpdate3
localVars.resInvoiceCreateOrUpdate3.outParamId = await Actions.ActionInvoiceCreateOrUpdate(requestContext,localVars.queryResGetInvoiceApprovalLevels_outParamList.CurrentRec.ssENInvoice,false,cancellationToken);

// InvoiceStatusHistoryCreateOrUpdate3
localVars.resInvoiceStatusHistoryCreateOrUpdate3.outParamId = await Actions.ActionInvoiceStatusHistoryCreateOrUpdate(requestContext,new EN_9edea2a401b6983c9ad50261c300f6d7EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssInvoiceId = localVars.inParami_InvoiceId, ssInvoiceStatusId = localVars.queryResGetInvoiceApprovalLevels_outParamList.CurrentRec.ssENInvoice.ssInvoiceStatusId, ssTimeStamp = BuiltInFunction.CurrDateTime (), ssCreatedBy = BuiltInFunction.GetUserId () },cancellationToken);

// InvoiceApprovalLevelCreateOrUpdate2
localVars.resInvoiceApprovalLevelCreateOrUpdate2.outParamId = await Actions.ActionInvoiceApprovalLevelCreateOrUpdate(requestContext,localVars.varLcl_FirstAccountingApprovalLevel,cancellationToken);

// InvoiceApprovalCreateOrUpdate
localVars.resInvoiceApprovalCreateOrUpdate.outParamId = await Actions.ActionInvoiceApprovalCreateOrUpdate(requestContext,localVars.queryResGetInvoiceApprovalLevels_outParamList.CurrentRec.ssENInvoiceApproval,cancellationToken);

} else {
// l_FirstAccountingApprovalLevel.ApprovalStatusId = If
localVars.varLcl_FirstAccountingApprovalLevel.ssApprovalStatusId = ((localVars.varLcl_FirstAccountingApprovalLevel.ssSelectsNextApprover) ? ((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("BjgcXy0kFU+8e5Ko3emFig"))).ssId) : ((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId));

// l_FirstAccountingApprovalLevel.ApprovedBy = NullTextIdentifier
localVars.varLcl_FirstAccountingApprovalLevel.ssApprovedBy = BuiltInFunction.NullTextIdentifier ();

// l_FirstAccountingApprovalLevel.ApprovedOn = NullDate
localVars.varLcl_FirstAccountingApprovalLevel.ssApprovedOn = BuiltInFunction.NullDate ();

// GetInvoiceApprovalLevels.List.Current.InvoiceApproval.CurrentLevel = l_FirstAccountingApprovalLevel.LevelNumber
localVars.queryResGetInvoiceApprovalLevels_outParamList.CurrentRec.ssENInvoiceApproval.ssCurrentLevel = localVars.varLcl_FirstAccountingApprovalLevel.ssLevelNumber;
// InvoiceApprovalLevelCreateOrUpdate3
localVars.resInvoiceApprovalLevelCreateOrUpdate3.outParamId = await Actions.ActionInvoiceApprovalLevelCreateOrUpdate(requestContext,localVars.varLcl_FirstAccountingApprovalLevel,cancellationToken);

// InvoiceApprovalCreateOrUpdate2
localVars.resInvoiceApprovalCreateOrUpdate2.outParamId = await Actions.ActionInvoiceApprovalCreateOrUpdate(requestContext,localVars.queryResGetInvoiceApprovalLevels_outParamList.CurrentRec.ssENInvoiceApproval,cancellationToken);

// ListFilter
localVars.resListFilter_outParamFilteredList = (((RL_e8a2bfdbad62aa404e80d55d80faa387)await  localVars.queryResGetInvoiceApprovalLevels_outParamList.FilterAsync(async (p, cancellationToken) => (p.ssENInvoiceApprovalLevel.ssIsAccounting&&(p.ssENInvoiceApprovalLevel.ssId!=localVars.varLcl_FirstAccountingApprovalLevel.ssId)), cancellationToken)));

// Foreach ListFilter.FilteredList
localVars.resListFilter_outParamFilteredList.StartIteration();
try {while (!((localVars.resListFilter_outParamFilteredList.Eof))) {
// DeleteInvoiceApprovalLevel
await ExtendedActions.DeleteInvoiceApprovalLevel(requestContext,localVars.resListFilter_outParamFilteredList.CurrentRec.ssENInvoiceApprovalLevel.ssId,cancellationToken);

localVars.resListFilter_outParamFilteredList.Advance();
}

} finally {
localVars.resListFilter_outParamFilteredList.EndIteration();
}

// Query datasetGetInvoiceAccountingsByInvoiceId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceAccountingsByInvoiceId_maxRecords = 0;
int datasetGetInvoiceAccountingsByInvoiceId_startIndex = 0;(localVars.queryResGetInvoiceAccountingsByInvoiceId_outParamList,localVars.queryResGetInvoiceAccountingsByInvoiceId_outParamCount) = await FuncActionClearInvoiceApprovalAccounting.datasetGetInvoiceAccountingsByInvoiceId(requestContext,datasetGetInvoiceAccountingsByInvoiceId_maxRecords,datasetGetInvoiceAccountingsByInvoiceId_startIndex,IterationMultiplicity.Never,localVars.inParami_InvoiceId,cancellationToken);

// not Empty?
if(((!localVars.queryResGetInvoiceAccountingsByInvoiceId_outParamList.Empty))) {
// GetInvoiceAccountingsByInvoiceId.List.Current.InvoiceAccounting.SubmissionOn = NullDate
localVars.queryResGetInvoiceAccountingsByInvoiceId_outParamList.CurrentRec.ssENInvoiceAccounting.ssSubmissionOn = BuiltInFunction.NullDate ();

// GetInvoiceAccountingsByInvoiceId.List.Current.InvoiceAccounting.SubmissionBy = NullTextIdentifier
localVars.queryResGetInvoiceAccountingsByInvoiceId_outParamList.CurrentRec.ssENInvoiceAccounting.ssSubmissionBy = BuiltInFunction.NullTextIdentifier ();
// InvoiceAccountingCreateOrUpdate
localVars.resInvoiceAccountingCreateOrUpdate.outParamId = await Actions.ActionInvoiceAccountingCreateOrUpdate(requestContext,localVars.queryResGetInvoiceAccountingsByInvoiceId_outParamList.CurrentRec.ssENInvoiceAccounting,cancellationToken);

// InApproval_CxP
// GetInvoiceApprovalLevels.List.Current.Invoice.InvoiceStatusId = InApproval_CxP
localVars.queryResGetInvoiceApprovalLevels_outParamList.CurrentRec.ssENInvoice.ssInvoiceStatusId = (ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("IImA0NKHIEiNrWap8beugQ"))).ssId;
// InvoiceCreateOrUpdate4
localVars.resInvoiceCreateOrUpdate4.outParamId = await Actions.ActionInvoiceCreateOrUpdate(requestContext,localVars.queryResGetInvoiceApprovalLevels_outParamList.CurrentRec.ssENInvoice,false,cancellationToken);

} else {
// ALIGN
// ALIGN
}

}

// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
// InvEmailFirstApprov_AccountingErrorFSP
await Actions.ActionInvEmailFirstApprov_AccountingErrorFSP(requestContext,localVars.inParami_InvoiceId,cancellationToken);

} //close CreateActionActivity using block
} // try

finally {
outParamo_Output = result.outParamo_Output;
} // inner-finally
RETURN_STATEMENT:
return outParamo_Output;
}

public static class FuncActionClearInvoiceApprovalAccounting {

// Query Function "GetANALISTA_CXP" LcI3B0e5mEud_NhMQSwwdg of Action "ClearInvoiceApprovalAccounting"
public static async Task<(RL_2fd4ee9249069fb78258eb73022e4cb9,long)> datasetGetANALISTA_CXP(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ClearInvoiceApprovalAccounting.GetANALISTA_CXP", "0737c22d-b947-4b98-9dfc-d84c412c3076");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ClearInvoiceApprovalAccounting.GetANALISTA_CXP", "0737c22d-b947-4b98-9dfc-d84c412c3076", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.hwImq_W0KUCOSBf_R4HDvQ/NodesNotShownInESpaceTree.LcI3B0e5mEud_NhMQSwwdg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enapplicationrole19\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6");
fromBuilder.Append(" FROM {ApplicationRole} \"enapplicationrole19\"");
whereBuilder.Append(" WHERE (caseaccent_normalize((Upper(\"enapplicationrole19\".\"code\")) collate \"default\") like caseaccent_normalize('ANALISTA_CXP' collate \"default\"))");
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
RL_2fd4ee9249069fb78258eb73022e4cb9 outParamList = new RL_2fd4ee9249069fb78258eb73022e4cb9();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ClearInvoiceApprovalAccounting.GetANALISTA_CXP.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_2fd4ee9249069fb78258eb73022e4cb9 _tmp = new RL_2fd4ee9249069fb78258eb73022e4cb9();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ClearInvoiceApprovalAccounting.GetANALISTA_CXP.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_2fd4ee9249069fb78258eb73022e4cb9)_tmp;
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

private static async Task<RC_3336d2630e2646e00d0c2f5c3e5a01ea> datasetGetInvoiceByIdReadDbAsync(RC_3336d2630e2646e00d0c2f5c3e5a01ea rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceById" b9FcNcbic0ypN+0dAdG9fQ of Action "ClearInvoiceApprovalAccounting"
public static async Task<(RL_c851528f2bd72df8d6fa01fc1d7dda59,long)> datasetGetInvoiceById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoice_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ClearInvoiceApprovalAccounting.GetInvoiceById", "355cd16f-e2c6-4c73-a937-ed1d01d1bd7d");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ClearInvoiceApprovalAccounting.GetInvoiceById", "355cd16f-e2c6-4c73-a937-ed1d01d1bd7d", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.hwImq_W0KUCOSBf_R4HDvQ/NodesNotShownInESpaceTree.b9FcNcbic0ypN+0dAdG9fQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, \"enregion40\".\"commissionregion\" o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, \"enrequisition43\".\"regionid\" o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94");
fromBuilder.Append(" FROM (({Invoice} \"eninvoice45\" Left JOIN {Requisition} \"enrequisition43\" ON (\"enrequisition43\".\"id\" = \"eninvoice45\".\"requisitionid\"))  Left JOIN {Region} \"enregion40\" ON (\"enrequisition43\".\"regionid\" = \"enregion40\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoice_Id != 0) {
whereBuilder.Append("((\"eninvoice45\".\"id\" = @qpinInvoice_Id) AND (\"eninvoice45\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoice_Id", DbType.Int64, qpinInvoice_Id);
} else {
whereBuilder.Append("(\"eninvoice45\".\"id\" IS NULL)");
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
RL_c851528f2bd72df8d6fa01fc1d7dda59 outParamList = new RL_c851528f2bd72df8d6fa01fc1d7dda59();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoiceByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, false, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ClearInvoiceApprovalAccounting.GetInvoiceById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_c851528f2bd72df8d6fa01fc1d7dda59 _tmp = new RL_c851528f2bd72df8d6fa01fc1d7dda59();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoiceByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ClearInvoiceApprovalAccounting.GetInvoiceById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_c851528f2bd72df8d6fa01fc1d7dda59)_tmp;
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

// Query Function "GetApprovalProcess" ZJ2DO7ohz02DcQ5t_FMzhw of Action "ClearInvoiceApprovalAccounting"
public static async Task<(RL_5e0ca6ca9da3af4b1d8149758c39c2cf,long)> datasetGetApprovalProcess(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpapId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ClearInvoiceApprovalAccounting.GetApprovalProcess", "3b839d64-21ba-4dcf-8371-0e6dfc533387");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ClearInvoiceApprovalAccounting.GetApprovalProcess", "3b839d64-21ba-4dcf-8371-0e6dfc533387", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.hwImq_W0KUCOSBf_R4HDvQ/NodesNotShownInESpaceTree.ZJ2DO7ohz02DcQ5t_FMzhw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enapprovalprocess25\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18");
fromBuilder.Append(" FROM {ApprovalProcess} \"enapprovalprocess25\"");
whereBuilder.Append(" WHERE ");
if (qpapId != 0) {
whereBuilder.Append("((\"enapprovalprocess25\".\"id\" = @qpapId) AND (\"enapprovalprocess25\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpapId", DbType.Int64, qpapId);
} else {
whereBuilder.Append("(\"enapprovalprocess25\".\"id\" IS NULL)");
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
RL_5e0ca6ca9da3af4b1d8149758c39c2cf outParamList = new RL_5e0ca6ca9da3af4b1d8149758c39c2cf();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ClearInvoiceApprovalAccounting.GetApprovalProcess.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_5e0ca6ca9da3af4b1d8149758c39c2cf _tmp = new RL_5e0ca6ca9da3af4b1d8149758c39c2cf();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ClearInvoiceApprovalAccounting.GetApprovalProcess.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_5e0ca6ca9da3af4b1d8149758c39c2cf)_tmp;
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

// Query Function "GetInvoiceAccountingsByInvoiceId" OnF5d9s3Q0CeX43pNqwVEg of Action "ClearInvoiceApprovalAccounting"
public static async Task<(RL_ccf70f600f06def33a14ca10a1120a68,long)> datasetGetInvoiceAccountingsByInvoiceId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ClearInvoiceApprovalAccounting.GetInvoiceAccountingsByInvoiceId", "7779713a-37db-4043-9e5f-8de936ac1512");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ClearInvoiceApprovalAccounting.GetInvoiceAccountingsByInvoiceId", "7779713a-37db-4043-9e5f-8de936ac1512", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.hwImq_W0KUCOSBf_R4HDvQ/NodesNotShownInESpaceTree.OnF5d9s3Q0CeX43pNqwVEg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoiceaccounting7\".\"id\" o0, \"eninvoiceaccounting7\".\"invoiceid\" o1, \"eninvoiceaccounting7\".\"suppliernumber\" o2, \"eninvoiceaccounting7\".\"servicetypeid\" o3, \"eninvoiceaccounting7\".\"freetext\" o4, \"eninvoiceaccounting7\".\"division\" o5, trim_scale(\"eninvoiceaccounting7\".\"ivaamount\"::numeric) o6, \"eninvoiceaccounting7\".\"iva_old\" o7, \"eninvoiceaccounting7\".\"ivaindicatorid\" o8, trim_scale(\"eninvoiceaccounting7\".\"totalamount\"::numeric) o9, \"eninvoiceaccounting7\".\"paymentmethodid\" o10, \"eninvoiceaccounting7\".\"paymenttermsid\" o11, \"eninvoiceaccounting7\".\"icmeindicator\" o12, \"eninvoiceaccounting7\".\"createdby\" o13, \"eninvoiceaccounting7\".\"createdon\" o14, \"eninvoiceaccounting7\".\"submissionby\" o15, \"eninvoiceaccounting7\".\"submissionon\" o16, \"eninvoiceaccounting7\".\"servicecalledby\" o17, \"eninvoiceaccounting7\".\"servicecalledon\" o18, \"eninvoiceaccounting7\".\"buydocnumber\" o19, \"eninvoiceaccounting7\".\"buydocposition\" o20");
fromBuilder.Append(" FROM {InvoiceAccounting} \"eninvoiceaccounting7\"");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceId != 0) {
whereBuilder.Append("((\"eninvoiceaccounting7\".\"invoiceid\" = @qpinInvoiceId) AND (\"eninvoiceaccounting7\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceId", DbType.Int64, qpinInvoiceId);
} else {
whereBuilder.Append("(\"eninvoiceaccounting7\".\"invoiceid\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"eninvoiceaccounting7\".\"suppliernumber\" ASC ");
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
RL_ccf70f600f06def33a14ca10a1120a68 outParamList = new RL_ccf70f600f06def33a14ca10a1120a68();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ClearInvoiceApprovalAccounting.GetInvoiceAccountingsByInvoiceId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_ccf70f600f06def33a14ca10a1120a68 _tmp = new RL_ccf70f600f06def33a14ca10a1120a68();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ClearInvoiceApprovalAccounting.GetInvoiceAccountingsByInvoiceId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_ccf70f600f06def33a14ca10a1120a68)_tmp;
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

private static async Task<RC_bc68025e789d69992aef27aed0947c65> datasetGetInvoiceApprovalLevelsReadDbAsync(RC_bc68025e789d69992aef27aed0947c65 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceApproval.Read( r, ref index);
rec.ssENInvoiceApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceApprovalLevels" _iFC2ZvXmECUNKQXU8SuFA of Action "ClearInvoiceApprovalAccounting"
public static async Task<(RL_e8a2bfdbad62aa404e80d55d80faa387,long)> datasetGetInvoiceApprovalLevels(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoice_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ClearInvoiceApprovalAccounting.GetInvoiceApprovalLevels", "d94221fe-d79b-4098-9434-a41753c4ae14");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ClearInvoiceApprovalAccounting.GetInvoiceApprovalLevels", "d94221fe-d79b-4098-9434-a41753c4ae14", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.hwImq_W0KUCOSBf_R4HDvQ/NodesNotShownInESpaceTree._iFC2ZvXmECUNKQXU8SuFA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoice46\".\"id\" o0, \"eninvoice46\".\"name\" o1, \"eninvoice46\".\"requisitionid\" o2, \"eninvoice46\".\"folioid\" o3, \"eninvoice46\".\"ordermainid\" o4, \"eninvoice46\".\"cfditypeid\" o5, trim_scale(\"eninvoice46\".\"totalamount\"::numeric) o6, \"eninvoice46\".\"currency\" o7, \"eninvoice46\".\"invoicestatusid\" o8, \"eninvoice46\".\"accountingdatetime\" o9, \"eninvoice46\".\"paymentdatetime\" o10, \"eninvoice46\".\"createdon\" o11, \"eninvoice46\".\"createdby\" o12, \"eninvoice46\".\"updatedon\" o13, \"eninvoice46\".\"updatedby\" o14, \"eninvoice46\".\"submittedon\" o15, \"eninvoice46\".\"isnewversion\" o16, \"eninvoice46\".\"id_poliza\" o17, \"eninvoice46\".\"id_poliza_sap\" o18, \"eninvoice46\".\"doc51\" o19, \"eninvoice46\".\"accountingerror\" o20, \"eninvoice46\".\"orderaccconceptsid\" o21, trim_scale(\"eninvoice46\".\"amortization\"::numeric) o22, \"eninvoice46\".\"creditnoteinvoiceid\" o23, \"eninvoiceapproval16\".\"id\" o24, \"eninvoiceapproval16\".\"invoiceid\" o25, \"eninvoiceapproval16\".\"aprovalprocessid\" o26, \"eninvoiceapproval16\".\"processtypecode\" o27, \"eninvoiceapproval16\".\"approvalprocessversion\" o28, \"eninvoiceapproval16\".\"currentlevel\" o29, \"eninvoiceapproval16\".\"maxlevel\" o30, \"eninvoiceapproval16\".\"startedon\" o31, \"eninvoiceapproval16\".\"finishedon\" o32, \"eninvoiceapproval16\".\"hasstartedaccounting\" o33, \"eninvoiceapprovallevel17\".\"id\" o34, \"eninvoiceapprovallevel17\".\"invoiceapprovalid\" o35, \"eninvoiceapprovallevel17\".\"levelnumber\" o36, \"eninvoiceapprovallevel17\".\"assignedto\" o37, \"eninvoiceapprovallevel17\".\"applicationroleid\" o38, \"eninvoiceapprovallevel17\".\"entrajobtitle\" o39, \"eninvoiceapprovallevel17\".\"departmentid\" o40, \"eninvoiceapprovallevel17\".\"managementid\" o41, \"eninvoiceapprovallevel17\".\"subdirectionid\" o42, \"eninvoiceapprovallevel17\".\"entraroleid\" o43, NULL o44, \"eninvoiceapprovallevel17\".\"canbefirstapprover\" o45, \"eninvoiceapprovallevel17\".\"selectsnextapprover\" o46, \"eninvoiceapprovallevel17\".\"selectsfirstapprover\" o47, \"eninvoiceapprovallevel17\".\"isaccounting\" o48, \"eninvoiceapprovallevel17\".\"isstartaccounting\" o49, \"eninvoiceapprovallevel17\".\"approvedby\" o50, \"eninvoiceapprovallevel17\".\"approvedon\" o51, \"eninvoiceapprovallevel17\".\"requesttomodifyby\" o52, \"eninvoiceapprovallevel17\".\"requesttomodifyon\" o53, \"eninvoiceapprovallevel17\".\"canceledby\" o54, \"eninvoiceapprovallevel17\".\"canceledon\" o55, \"eninvoiceapprovallevel17\".\"needscontract_deprec\" o56, \"eninvoiceapprovallevel17\".\"isreassigned\" o57, \"eninvoiceapprovallevel17\".\"issubstitutefor\" o58");
fromBuilder.Append(" FROM (({Invoice} \"eninvoice46\" Left JOIN {InvoiceApproval} \"eninvoiceapproval16\" ON (\"eninvoice46\".\"id\" = \"eninvoiceapproval16\".\"invoiceid\"))  Left JOIN {InvoiceApprovalLevel} \"eninvoiceapprovallevel17\" ON (\"eninvoiceapproval16\".\"id\" = \"eninvoiceapprovallevel17\".\"invoiceapprovalid\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoice_Id != 0) {
whereBuilder.Append("((\"eninvoice46\".\"id\" = @qpinInvoice_Id) AND (\"eninvoice46\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoice_Id", DbType.Int64, qpinInvoice_Id);
} else {
whereBuilder.Append("(\"eninvoice46\".\"id\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"eninvoiceapprovallevel17\".\"levelnumber\" ASC ");
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
outParamList.AlternateReadDbMethodAsync = datasetGetInvoiceApprovalLevelsReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false});
opt[2] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ClearInvoiceApprovalAccounting.GetInvoiceApprovalLevels.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_e8a2bfdbad62aa404e80d55d80faa387 _tmp = new RL_e8a2bfdbad62aa404e80d55d80faa387();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoiceApprovalLevelsReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ClearInvoiceApprovalAccounting.GetInvoiceApprovalLevels.List", cancellationToken: cancellationToken);
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


}
