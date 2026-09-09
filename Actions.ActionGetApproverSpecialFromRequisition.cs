namespace ssConectaProveedores;

public partial class Actions {
public class lcvGetApproverSpecialFromRequisition : VarsBag {
public long inParami_EntraRoleId;
public long inParami_RegionId;
public long inParami_DepartmentId;
public long inParami_ManagementId;
public long inParami_SubdirectionId;
public long inParami_RequisitionId;
public RL_1f3e9ea72dc7b010c56ee9146ee277c5 queryResGetRequisitionApproverMatch_outParamList = new RL_1f3e9ea72dc7b010c56ee9146ee277c5();
public long queryResGetRequisitionApproverMatch_outParamCount = 0L;

public RL_bc2063fe1d05aa544017f329fb1e030b queryResGetUserWithEntraRoleId_outParamList = new RL_bc2063fe1d05aa544017f329fb1e030b();
public long queryResGetUserWithEntraRoleId_outParamCount = 0L;

public Actions.lcoHasActiveSubstitution resHasActiveSubstitution3 =  new Actions.lcoHasActiveSubstitution();
public RL_084ec93001d810170970c8007b50b58f queryResGetEntraRoleById_outParamList = new RL_084ec93001d810170970c8007b50b58f();
public long queryResGetEntraRoleById_outParamCount = 0L;

public Actions.lcoHasActiveSubstitution resHasActiveSubstitution =  new Actions.lcoHasActiveSubstitution();
public RL_d5b8a84ca389ad87aeb4566f51b893eb queryResGetUserWithEntraRoleId2_outParamList = new RL_d5b8a84ca389ad87aeb4566f51b893eb();
public long queryResGetUserWithEntraRoleId2_outParamCount = 0L;

public Actions.lcoHasActiveSubstitution resHasActiveSubstitution2 =  new Actions.lcoHasActiveSubstitution();
public lcvGetApproverSpecialFromRequisition(long inParami_EntraRoleId, long inParami_RegionId, long inParami_DepartmentId, long inParami_ManagementId, long inParami_SubdirectionId, long inParami_RequisitionId) {
this.inParami_EntraRoleId = inParami_EntraRoleId;
this.inParami_RegionId = inParami_RegionId;
this.inParami_DepartmentId = inParami_DepartmentId;
this.inParami_ManagementId = inParami_ManagementId;
this.inParami_SubdirectionId = inParami_SubdirectionId;
this.inParami_RequisitionId = inParami_RequisitionId;
}
}
public class lcoGetApproverSpecialFromRequisition : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public string outParamo_UserId = "";

public string outParamo_IsSubstituteFor = "";

public lcoGetApproverSpecialFromRequisition() {
}
}
/// <summary>
/// Action <code>GetApproverSpecialFromRequisition</code> that represents the Service Studio action
///  <code>GetApproverSpecialFromRequisition</code> <p> Description: </p>
/// </summary>
public static async Task<(ST_046fb53ebbe142526d95e87ef1ae9711Structure,string,string)> ActionGetApproverSpecialFromRequisition(IRequestContext requestContext,long inParami_EntraRoleId,long inParami_RegionId,long inParami_DepartmentId,long inParami_ManagementId,long inParami_SubdirectionId,long inParami_RequisitionId,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
string outParamo_UserId = default;
string outParamo_IsSubstituteFor = default;
lcoGetApproverSpecialFromRequisition result = new lcoGetApproverSpecialFromRequisition();
lcvGetApproverSpecialFromRequisition localVars = new lcvGetApproverSpecialFromRequisition(inParami_EntraRoleId, inParami_RegionId, inParami_DepartmentId, inParami_ManagementId, inParami_SubdirectionId, inParami_RequisitionId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GetApproverSpecialFromRequisition", "46db2480-df3a-48d0-bb0b-2f94ebab5ece"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetApproverSpecialFromRequisition", "46db2480-df3a-48d0-bb0b-2f94ebab5ece", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetEntraRoleById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetEntraRoleById_maxRecords = 1;
if (datasetGetEntraRoleById_maxRecords < 1) datasetGetEntraRoleById_maxRecords = 1;
int datasetGetEntraRoleById_startIndex = 0;(localVars.queryResGetEntraRoleById_outParamList,localVars.queryResGetEntraRoleById_outParamCount) = await FuncActionGetApproverSpecialFromRequisition.datasetGetEntraRoleById(requestContext,datasetGetEntraRoleById_maxRecords,datasetGetEntraRoleById_startIndex,IterationMultiplicity.Never,localVars.inParami_EntraRoleId,cancellationToken);

// Query datasetGetUserWithEntraRoleId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserWithEntraRoleId_maxRecords = 0;
int datasetGetUserWithEntraRoleId_startIndex = 0;(localVars.queryResGetUserWithEntraRoleId_outParamList,localVars.queryResGetUserWithEntraRoleId_outParamCount) = await FuncActionGetApproverSpecialFromRequisition.datasetGetUserWithEntraRoleId(requestContext,datasetGetUserWithEntraRoleId_maxRecords,datasetGetUserWithEntraRoleId_startIndex,IterationMultiplicity.Single,localVars.inParami_DepartmentId,localVars.inParami_EntraRoleId,localVars.inParami_ManagementId,localVars.inParami_RegionId,localVars.inParami_SubdirectionId,((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsDevEnvironment]))),cancellationToken);

// Empty?
if((localVars.queryResGetUserWithEntraRoleId_outParamList.Empty)) {
// Query datasetGetUserWithEntraRoleId2
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserWithEntraRoleId2_maxRecords = 1;
if (datasetGetUserWithEntraRoleId2_maxRecords < 1) datasetGetUserWithEntraRoleId2_maxRecords = 1;
int datasetGetUserWithEntraRoleId2_startIndex = 0;(localVars.queryResGetUserWithEntraRoleId2_outParamList,localVars.queryResGetUserWithEntraRoleId2_outParamCount) = await FuncActionGetApproverSpecialFromRequisition.datasetGetUserWithEntraRoleId2(requestContext,datasetGetUserWithEntraRoleId2_maxRecords,datasetGetUserWithEntraRoleId2_startIndex,IterationMultiplicity.Never,localVars.inParami_DepartmentId,localVars.inParami_EntraRoleId,localVars.inParami_ManagementId,localVars.inParami_SubdirectionId,((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsDevEnvironment]))),cancellationToken);

// Empty?
if((localVars.queryResGetUserWithEntraRoleId2_outParamList.Empty)) {
// o_Output
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "Cannot determine the next approver! User with JobTitle" + " '" + GetEntraRoleById.List.Current.EntraRole.RoleName + "' " + "not found or the user with such role has not yet logged into the application."
result.outParamo_Output.ssMessage = ((((AppUtils.GetStringResource("JUjSenHCUU6dzCIsHT0YMA#Value.-2137137384.1", "Cannot determine the next approver! User with JobTitle")+" '")+localVars.queryResGetEntraRoleById_outParamList.CurrentRec.ssENEntraRole.ssRoleName)+"' ")+AppUtils.GetStringResource("JUjSenHCUU6dzCIsHT0YMA#Value.1160676689.1", "not found or the user with such role has not yet logged into the application."));
} else {
// HasActiveSubstitution
(localVars.resHasActiveSubstitution.outParamo_SubstituteUserId,localVars.resHasActiveSubstitution.outParamo_IsSubstituteFor) = await Actions.ActionHasActiveSubstitution(requestContext,localVars.queryResGetUserWithEntraRoleId2_outParamList.CurrentRec.ssENUser.ssId,cancellationToken);

// o_Output
// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;

// o_UserId = If
result.outParamo_UserId=(((localVars.resHasActiveSubstitution.outParamo_SubstituteUserId==BuiltInFunction.NullTextIdentifier ())) ? (localVars.queryResGetUserWithEntraRoleId2_outParamList.CurrentRec.ssENUser.ssId) : (localVars.resHasActiveSubstitution.outParamo_SubstituteUserId));

// o_IsSubstituteFor = HasActiveSubstitution.o_IsSubstituteFor
result.outParamo_IsSubstituteFor=localVars.resHasActiveSubstitution.outParamo_IsSubstituteFor;
}

} else {
// Foreach GetUserWithEntraRoleId.List
localVars.queryResGetUserWithEntraRoleId_outParamList.StartIteration();
try {while (!((localVars.queryResGetUserWithEntraRoleId_outParamList.Eof))) {
// Query datasetGetRequisitionApproverMatch
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionApproverMatch_maxRecords = 1;
if (datasetGetRequisitionApproverMatch_maxRecords < 1) datasetGetRequisitionApproverMatch_maxRecords = 1;
int datasetGetRequisitionApproverMatch_startIndex = 0;(localVars.queryResGetRequisitionApproverMatch_outParamList,localVars.queryResGetRequisitionApproverMatch_outParamCount) = await FuncActionGetApproverSpecialFromRequisition.datasetGetRequisitionApproverMatch(requestContext,datasetGetRequisitionApproverMatch_maxRecords,datasetGetRequisitionApproverMatch_startIndex,IterationMultiplicity.Never,localVars.queryResGetUserWithEntraRoleId_outParamList.CurrentRec.ssENUser.ssId,localVars.inParami_RequisitionId,cancellationToken);

// Empty?
if((!(localVars.queryResGetRequisitionApproverMatch_outParamList.Empty))) {
// HasActiveSubstitution2
(localVars.resHasActiveSubstitution2.outParamo_SubstituteUserId,localVars.resHasActiveSubstitution2.outParamo_IsSubstituteFor) = await Actions.ActionHasActiveSubstitution(requestContext,(((localVars.queryResGetRequisitionApproverMatch_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssIsSubstituteFor!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.queryResGetRequisitionApproverMatch_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssIsSubstituteFor) : (localVars.queryResGetRequisitionApproverMatch_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssAssignedTo)),cancellationToken);

// o_Output
// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;

// o_UserId = If
result.outParamo_UserId=(((localVars.resHasActiveSubstitution2.outParamo_SubstituteUserId==BuiltInFunction.NullTextIdentifier ())) ? (localVars.queryResGetUserWithEntraRoleId_outParamList.CurrentRec.ssENUser.ssId) : (localVars.resHasActiveSubstitution2.outParamo_SubstituteUserId));

// o_IsSubstituteFor = HasActiveSubstitution2.o_IsSubstituteFor
result.outParamo_IsSubstituteFor=localVars.resHasActiveSubstitution2.outParamo_IsSubstituteFor;
goto RETURN_STATEMENT;

}

localVars.queryResGetUserWithEntraRoleId_outParamList.Advance();
}

} finally {
localVars.queryResGetUserWithEntraRoleId_outParamList.EndIteration();
}

// HasActiveSubstitution3
(localVars.resHasActiveSubstitution3.outParamo_SubstituteUserId,localVars.resHasActiveSubstitution3.outParamo_IsSubstituteFor) = await Actions.ActionHasActiveSubstitution(requestContext,localVars.queryResGetUserWithEntraRoleId_outParamList.CurrentRec.ssENUser.ssId,cancellationToken);

// o_Output
// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;

// o_UserId = If
result.outParamo_UserId=(((localVars.resHasActiveSubstitution3.outParamo_SubstituteUserId==BuiltInFunction.NullTextIdentifier ())) ? (localVars.queryResGetUserWithEntraRoleId_outParamList.CurrentRec.ssENUser.ssId) : (localVars.resHasActiveSubstitution3.outParamo_SubstituteUserId));

// o_IsSubstituteFor = HasActiveSubstitution3.o_IsSubstituteFor
result.outParamo_IsSubstituteFor=localVars.resHasActiveSubstitution3.outParamo_IsSubstituteFor;
}

} //close CreateActionActivity using block
} // try

finally {
outParamo_Output = result.outParamo_Output;
outParamo_UserId = result.outParamo_UserId;
outParamo_IsSubstituteFor = result.outParamo_IsSubstituteFor;
} // inner-finally
RETURN_STATEMENT:
return (outParamo_Output,outParamo_UserId,outParamo_IsSubstituteFor);
}

public static class FuncActionGetApproverSpecialFromRequisition {

private static async Task<RC_11c2ac4c5bdce01960ee8371ad40d262> datasetGetRequisitionApproverMatchReadDbAsync(RC_11c2ac4c5bdce01960ee8371ad40d262 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENRequisition.Read( r, ref index);
rec.ssENRequisitionApproval.Read( r, ref index);
rec.ssENRequisitionApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetRequisitionApproverMatch" ZRH+Md3Bh0WUzpSGHqrdJg of Action "GetApproverSpecialFromRequisition"
public static async Task<(RL_1f3e9ea72dc7b010c56ee9146ee277c5,long)> datasetGetRequisitionApproverMatch(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusId,long qpreRequisition_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetApproverSpecialFromRequisition.GetRequisitionApproverMatch", "31fe1165-c1dd-4587-94ce-94861eaadd26");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetApproverSpecialFromRequisition.GetRequisitionApproverMatch", "31fe1165-c1dd-4587-94ce-94861eaadd26", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.gCTbRjrf0Ei7Cy+U66tezg/NodesNotShownInESpaceTree.ZRH+Md3Bh0WUzpSGHqrdJg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, \"enrequisitionapprovallevel6\".\"assignedto\" o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, \"enrequisitionapprovallevel6\".\"issubstitutefor\" o93");
fromBuilder.Append(" FROM (({Requisition} \"enrequisition19\" Left JOIN {RequisitionApproval} \"enrequisitionapproval7\" ON (\"enrequisition19\".\"id\" = \"enrequisitionapproval7\".\"requisitionid\"))  Left JOIN {RequisitionApprovalLevel} \"enrequisitionapprovallevel6\" ON (\"enrequisitionapproval7\".\"id\" = \"enrequisitionapprovallevel6\".\"requisitionapprovalid\")) ");
whereBuilder.Append(" WHERE (");
if ((qpusId.Trim()!="")) {
whereBuilder.Append("((\"enrequisitionapprovallevel6\".\"assignedto\" = @qpusId) AND (\"enrequisitionapprovallevel6\".\"assignedto\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusId", DbType.String, qpusId);
} else {
whereBuilder.Append("(\"enrequisitionapprovallevel6\".\"assignedto\" IS NULL)");
}
whereBuilder.Append(" OR ");
if ((qpusId.Trim()!="")) {
whereBuilder.Append("((\"enrequisitionapprovallevel6\".\"issubstitutefor\" = @qpusId) AND (\"enrequisitionapprovallevel6\".\"issubstitutefor\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusId", DbType.String, qpusId);
} else {
whereBuilder.Append("(\"enrequisitionapprovallevel6\".\"issubstitutefor\" IS NULL)");
}
whereBuilder.Append(") AND ");
if (qpreRequisition_Id != 0) {
whereBuilder.Append("((\"enrequisition19\".\"id\" = @qpreRequisition_Id) AND (\"enrequisition19\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisition_Id", DbType.Int64, qpreRequisition_Id);
} else {
whereBuilder.Append("(\"enrequisition19\".\"id\" IS NULL)");
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
RL_1f3e9ea72dc7b010c56ee9146ee277c5 outParamList = new RL_1f3e9ea72dc7b010c56ee9146ee277c5();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetRequisitionApproverMatchReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetApproverSpecialFromRequisition.GetRequisitionApproverMatch.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_1f3e9ea72dc7b010c56ee9146ee277c5 _tmp = new RL_1f3e9ea72dc7b010c56ee9146ee277c5();
_tmp.AlternateReadDbMethodAsync = datasetGetRequisitionApproverMatchReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetApproverSpecialFromRequisition.GetRequisitionApproverMatch.List", cancellationToken: cancellationToken);
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

private static async Task<RC_184336c68155ad9e77005f91e8e8b363> datasetGetUserWithEntraRoleIdReadDbAsync(RC_184336c68155ad9e77005f91e8e8b363 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
rec.ssENUserExtension.Read( r, ref index);
return rec;
}
// Query Function "GetUserWithEntraRoleId" bNQDPfpeJ0GRiFTFhvRQhA of Action "GetApproverSpecialFromRequisition"
public static async Task<(RL_bc2063fe1d05aa544017f329fb1e030b,long)> datasetGetUserWithEntraRoleId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpdeUser_Extended_Internal_DepartmentId,long qpenUser_Extended_Internal_EntraRoleId,long qpmaUser_Extended_Internal_ManagementId,long qpreUser_Extended_Internal_RegionId,long qpsuUser_Extended_Internal_SubdirectionId,bool qpboIsDevEnvironment,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetApproverSpecialFromRequisition.GetUserWithEntraRoleId", "3d03d46c-5efa-4127-9188-54c586f45084");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetApproverSpecialFromRequisition.GetUserWithEntraRoleId", "3d03d46c-5efa-4127-9188-54c586f45084", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.gCTbRjrf0Ei7Cy+U66tezg/NodesNotShownInESpaceTree.bNQDPfpeJ0GRiFTFhvRQhA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enuser46\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27");
fromBuilder.Append(" FROM (({User_Extended_Internal} \"enuser_extended_internal28\" Inner JOIN {User} \"enuser46\" ON (\"enuser_extended_internal28\".\"id\" = \"enuser46\".\"id\"))  Left JOIN {UserExtension} \"enuserextension26\" ON (\"enuser46\".\"id\" = \"enuserextension26\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpreUser_Extended_Internal_RegionId != 0) {
whereBuilder.Append("((\"enuser_extended_internal28\".\"regionid\" = @qpreUser_Extended_Internal_RegionId) AND (\"enuser_extended_internal28\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreUser_Extended_Internal_RegionId", DbType.Int64, qpreUser_Extended_Internal_RegionId);
} else {
whereBuilder.Append("(\"enuser_extended_internal28\".\"regionid\" IS NULL)");
}
whereBuilder.Append(" AND ");
if (qpenUser_Extended_Internal_EntraRoleId != 0) {
whereBuilder.Append("((\"enuser_extended_internal28\".\"entraroleid\" = @qpenUser_Extended_Internal_EntraRoleId) AND (\"enuser_extended_internal28\".\"entraroleid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpenUser_Extended_Internal_EntraRoleId", DbType.Int64, qpenUser_Extended_Internal_EntraRoleId);
} else {
whereBuilder.Append("(\"enuser_extended_internal28\".\"entraroleid\" IS NULL)");
}
whereBuilder.Append(" AND ");
if (qpdeUser_Extended_Internal_DepartmentId != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpdeUser_Extended_Internal_DepartmentId != 0) {
whereBuilder.Append("((\"enuser_extended_internal28\".\"departmentid\" = @qpdeUser_Extended_Internal_DepartmentId) AND (\"enuser_extended_internal28\".\"departmentid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpdeUser_Extended_Internal_DepartmentId", DbType.Int64, qpdeUser_Extended_Internal_DepartmentId);
} else {
whereBuilder.Append("(\"enuser_extended_internal28\".\"departmentid\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpmaUser_Extended_Internal_ManagementId != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpmaUser_Extended_Internal_ManagementId != 0) {
whereBuilder.Append("((\"enuser_extended_internal28\".\"managementid\" = @qpmaUser_Extended_Internal_ManagementId) AND (\"enuser_extended_internal28\".\"managementid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpmaUser_Extended_Internal_ManagementId", DbType.Int64, qpmaUser_Extended_Internal_ManagementId);
} else {
whereBuilder.Append("(\"enuser_extended_internal28\".\"managementid\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpsuUser_Extended_Internal_SubdirectionId != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpsuUser_Extended_Internal_SubdirectionId != 0) {
whereBuilder.Append("((\"enuser_extended_internal28\".\"subdirectionid\" = @qpsuUser_Extended_Internal_SubdirectionId) AND (\"enuser_extended_internal28\".\"subdirectionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuUser_Extended_Internal_SubdirectionId", DbType.Int64, qpsuUser_Extended_Internal_SubdirectionId);
} else {
whereBuilder.Append("(\"enuser_extended_internal28\".\"subdirectionid\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
whereBuilder.Append("((CASE WHEN (@qpboIsDevEnvironment = 1) THEN (CASE WHEN (\"enuserextension26\".\"correspondentexternalemail\" <> '') THEN 1 ELSE 0 END) ELSE 1 END) = 1)");
sqlCmd.CreateParameterWithoutReplacements("@qpboIsDevEnvironment", DbType.Boolean, qpboIsDevEnvironment);
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
RL_bc2063fe1d05aa544017f329fb1e030b outParamList = new RL_bc2063fe1d05aa544017f329fb1e030b();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetUserWithEntraRoleIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {false, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetApproverSpecialFromRequisition.GetUserWithEntraRoleId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_bc2063fe1d05aa544017f329fb1e030b _tmp = new RL_bc2063fe1d05aa544017f329fb1e030b();
_tmp.AlternateReadDbMethodAsync = datasetGetUserWithEntraRoleIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetApproverSpecialFromRequisition.GetUserWithEntraRoleId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_bc2063fe1d05aa544017f329fb1e030b)_tmp;
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

// Query Function "GetEntraRoleById" Z34GfbT9pUidLCjTOLDPSw of Action "GetApproverSpecialFromRequisition"
public static async Task<(RL_084ec93001d810170970c8007b50b58f,long)> datasetGetEntraRoleById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpenId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetApproverSpecialFromRequisition.GetEntraRoleById", "7d067e67-fdb4-48a5-9d2c-28d338b0cf4b");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetApproverSpecialFromRequisition.GetEntraRoleById", "7d067e67-fdb4-48a5-9d2c-28d338b0cf4b", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.gCTbRjrf0Ei7Cy+U66tezg/NodesNotShownInESpaceTree.Z34GfbT9pUidLCjTOLDPSw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enentrarole6\".\"rolename\" o1, NULL o2, NULL o3, NULL o4, NULL o5");
fromBuilder.Append(" FROM {EntraRole} \"enentrarole6\"");
whereBuilder.Append(" WHERE ");
if (qpenId != 0) {
whereBuilder.Append("((\"enentrarole6\".\"id\" = @qpenId) AND (\"enentrarole6\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpenId", DbType.Int64, qpenId);
} else {
whereBuilder.Append("(\"enentrarole6\".\"id\" IS NULL)");
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
RL_084ec93001d810170970c8007b50b58f outParamList = new RL_084ec93001d810170970c8007b50b58f();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, false, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetApproverSpecialFromRequisition.GetEntraRoleById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_084ec93001d810170970c8007b50b58f _tmp = new RL_084ec93001d810170970c8007b50b58f();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetApproverSpecialFromRequisition.GetEntraRoleById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_084ec93001d810170970c8007b50b58f)_tmp;
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

private static async Task<RC_9cf096dc3084ff2d0c04fe10cfde3141> datasetGetUserWithEntraRoleId2ReadDbAsync(RC_9cf096dc3084ff2d0c04fe10cfde3141 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENRegion.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
rec.ssENUserExtension.Read( r, ref index);
return rec;
}
// Query Function "GetUserWithEntraRoleId2" Pj5a0R2UJ02Jg2PTnWRM5g of Action "GetApproverSpecialFromRequisition"
public static async Task<(RL_d5b8a84ca389ad87aeb4566f51b893eb,long)> datasetGetUserWithEntraRoleId2(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpdeUser_Extended_Internal_DepartmentId,long qpenUser_Extended_Internal_EntraRoleId,long qpmaUser_Extended_Internal_ManagementId,long qpsuUser_Extended_Internal_SubdirectionId,bool qpboIsDevEnvironment,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetApproverSpecialFromRequisition.GetUserWithEntraRoleId2", "d15a3e3e-941d-4d27-8983-63d39d644ce6");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetApproverSpecialFromRequisition.GetUserWithEntraRoleId2", "d15a3e3e-941d-4d27-8983-63d39d644ce6", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.gCTbRjrf0Ei7Cy+U66tezg/NodesNotShownInESpaceTree.Pj5a0R2UJ02Jg2PTnWRM5g, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, \"enuser47\".\"id\" o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40");
fromBuilder.Append(" FROM ((({User_Extended_Internal} \"enuser_extended_internal29\" Inner JOIN {User} \"enuser47\" ON (\"enuser_extended_internal29\".\"id\" = \"enuser47\".\"id\"))  Inner JOIN {Region} \"enregion15\" ON (\"enuser_extended_internal29\".\"regionid\" = \"enregion15\".\"id\"))  Left JOIN {UserExtension} \"enuserextension27\" ON (\"enuser47\".\"id\" = \"enuserextension27\".\"id\")) ");
whereBuilder.Append(" WHERE (caseaccent_normalize(\"enregion15\".\"commissionregion\" collate \"default\") like caseaccent_normalize('R0' collate \"default\")) AND ");
if (qpenUser_Extended_Internal_EntraRoleId != 0) {
whereBuilder.Append("((\"enuser_extended_internal29\".\"entraroleid\" = @qpenUser_Extended_Internal_EntraRoleId) AND (\"enuser_extended_internal29\".\"entraroleid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpenUser_Extended_Internal_EntraRoleId", DbType.Int64, qpenUser_Extended_Internal_EntraRoleId);
} else {
whereBuilder.Append("(\"enuser_extended_internal29\".\"entraroleid\" IS NULL)");
}
whereBuilder.Append(" AND ");
if (qpdeUser_Extended_Internal_DepartmentId != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpdeUser_Extended_Internal_DepartmentId != 0) {
whereBuilder.Append("((\"enuser_extended_internal29\".\"departmentid\" = @qpdeUser_Extended_Internal_DepartmentId) AND (\"enuser_extended_internal29\".\"departmentid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpdeUser_Extended_Internal_DepartmentId", DbType.Int64, qpdeUser_Extended_Internal_DepartmentId);
} else {
whereBuilder.Append("(\"enuser_extended_internal29\".\"departmentid\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpmaUser_Extended_Internal_ManagementId != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpmaUser_Extended_Internal_ManagementId != 0) {
whereBuilder.Append("((\"enuser_extended_internal29\".\"managementid\" = @qpmaUser_Extended_Internal_ManagementId) AND (\"enuser_extended_internal29\".\"managementid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpmaUser_Extended_Internal_ManagementId", DbType.Int64, qpmaUser_Extended_Internal_ManagementId);
} else {
whereBuilder.Append("(\"enuser_extended_internal29\".\"managementid\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpsuUser_Extended_Internal_SubdirectionId != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpsuUser_Extended_Internal_SubdirectionId != 0) {
whereBuilder.Append("((\"enuser_extended_internal29\".\"subdirectionid\" = @qpsuUser_Extended_Internal_SubdirectionId) AND (\"enuser_extended_internal29\".\"subdirectionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuUser_Extended_Internal_SubdirectionId", DbType.Int64, qpsuUser_Extended_Internal_SubdirectionId);
} else {
whereBuilder.Append("(\"enuser_extended_internal29\".\"subdirectionid\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
whereBuilder.Append("((CASE WHEN (@qpboIsDevEnvironment = 1) THEN (CASE WHEN (\"enuserextension27\".\"correspondentexternalemail\" <> '') THEN 1 ELSE 0 END) ELSE 1 END) = 1)");
sqlCmd.CreateParameterWithoutReplacements("@qpboIsDevEnvironment", DbType.Boolean, qpboIsDevEnvironment);
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
RL_d5b8a84ca389ad87aeb4566f51b893eb outParamList = new RL_d5b8a84ca389ad87aeb4566f51b893eb();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetUserWithEntraRoleId2ReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[4];
opt[0] = new BitArray(new bool[] {false, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetApproverSpecialFromRequisition.GetUserWithEntraRoleId2.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_d5b8a84ca389ad87aeb4566f51b893eb _tmp = new RL_d5b8a84ca389ad87aeb4566f51b893eb();
_tmp.AlternateReadDbMethodAsync = datasetGetUserWithEntraRoleId2ReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetApproverSpecialFromRequisition.GetUserWithEntraRoleId2.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_d5b8a84ca389ad87aeb4566f51b893eb)_tmp;
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
