namespace ssConectaProveedores;

public partial class Actions {
public class lcvFindNextApproverSpecial : VarsBag {
public long inParami_EntraRoleId;
public long inParami_RegionId;
public long inParami_DepartmentId;
public long inParami_ManagementId;
public long inParami_SubdirectionId;
public RL_bc2063fe1d05aa544017f329fb1e030b queryResGetUserWithEntraRoleId_outParamList = new RL_bc2063fe1d05aa544017f329fb1e030b();
public long queryResGetUserWithEntraRoleId_outParamCount = 0L;

public RL_d5b8a84ca389ad87aeb4566f51b893eb queryResGetUserWithEntraRoleId2_outParamList = new RL_d5b8a84ca389ad87aeb4566f51b893eb();
public long queryResGetUserWithEntraRoleId2_outParamCount = 0L;

public Actions.lcoHasActiveSubstitution resHasActiveSubstitution2 =  new Actions.lcoHasActiveSubstitution();
public RL_084ec93001d810170970c8007b50b58f queryResGetEntraRoleById_outParamList = new RL_084ec93001d810170970c8007b50b58f();
public long queryResGetEntraRoleById_outParamCount = 0L;

public Actions.lcoHasActiveSubstitution resHasActiveSubstitution =  new Actions.lcoHasActiveSubstitution();
public lcvFindNextApproverSpecial(long inParami_EntraRoleId, long inParami_RegionId, long inParami_DepartmentId, long inParami_ManagementId, long inParami_SubdirectionId) {
this.inParami_EntraRoleId = inParami_EntraRoleId;
this.inParami_RegionId = inParami_RegionId;
this.inParami_DepartmentId = inParami_DepartmentId;
this.inParami_ManagementId = inParami_ManagementId;
this.inParami_SubdirectionId = inParami_SubdirectionId;
}
}
public class lcoFindNextApproverSpecial : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public string outParamo_UserId = "";

public string outParamo_IsSubstituteFor = "";

public lcoFindNextApproverSpecial() {
}
}
/// <summary>
/// Action <code>FindNextApproverSpecial</code> that represents the Service Studio action
///  <code>FindNextApproverSpecial</code> <p> Description: </p>
/// </summary>
public static async Task<(ST_046fb53ebbe142526d95e87ef1ae9711Structure,string,string)> ActionFindNextApproverSpecial(IRequestContext requestContext,long inParami_EntraRoleId,long inParami_RegionId,long inParami_DepartmentId,long inParami_ManagementId,long inParami_SubdirectionId,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
string outParamo_UserId = default;
string outParamo_IsSubstituteFor = default;
lcoFindNextApproverSpecial result = new lcoFindNextApproverSpecial();
lcvFindNextApproverSpecial localVars = new lcvFindNextApproverSpecial(inParami_EntraRoleId, inParami_RegionId, inParami_DepartmentId, inParami_ManagementId, inParami_SubdirectionId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("FindNextApproverSpecial", "3958fe68-5ac7-4103-b86d-106914e34224"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("FindNextApproverSpecial", "3958fe68-5ac7-4103-b86d-106914e34224", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetEntraRoleById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetEntraRoleById_maxRecords = 1;
if (datasetGetEntraRoleById_maxRecords < 1) datasetGetEntraRoleById_maxRecords = 1;
int datasetGetEntraRoleById_startIndex = 0;(localVars.queryResGetEntraRoleById_outParamList,localVars.queryResGetEntraRoleById_outParamCount) = await FuncActionFindNextApproverSpecial.datasetGetEntraRoleById(requestContext,datasetGetEntraRoleById_maxRecords,datasetGetEntraRoleById_startIndex,IterationMultiplicity.Never,localVars.inParami_EntraRoleId,cancellationToken);

// Query datasetGetUserWithEntraRoleId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserWithEntraRoleId_maxRecords = 1;
if (datasetGetUserWithEntraRoleId_maxRecords < 1) datasetGetUserWithEntraRoleId_maxRecords = 1;
int datasetGetUserWithEntraRoleId_startIndex = 0;(localVars.queryResGetUserWithEntraRoleId_outParamList,localVars.queryResGetUserWithEntraRoleId_outParamCount) = await FuncActionFindNextApproverSpecial.datasetGetUserWithEntraRoleId(requestContext,datasetGetUserWithEntraRoleId_maxRecords,datasetGetUserWithEntraRoleId_startIndex,IterationMultiplicity.Never,localVars.inParami_DepartmentId,localVars.inParami_EntraRoleId,localVars.inParami_ManagementId,localVars.inParami_RegionId,localVars.inParami_SubdirectionId,((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsDevEnvironment]))),cancellationToken);

// Empty?
if((localVars.queryResGetUserWithEntraRoleId_outParamList.Empty)) {
// Query datasetGetUserWithEntraRoleId2
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserWithEntraRoleId2_maxRecords = 1;
if (datasetGetUserWithEntraRoleId2_maxRecords < 1) datasetGetUserWithEntraRoleId2_maxRecords = 1;
int datasetGetUserWithEntraRoleId2_startIndex = 0;(localVars.queryResGetUserWithEntraRoleId2_outParamList,localVars.queryResGetUserWithEntraRoleId2_outParamCount) = await FuncActionFindNextApproverSpecial.datasetGetUserWithEntraRoleId2(requestContext,datasetGetUserWithEntraRoleId2_maxRecords,datasetGetUserWithEntraRoleId2_startIndex,IterationMultiplicity.Never,localVars.inParami_DepartmentId,localVars.inParami_EntraRoleId,localVars.inParami_ManagementId,localVars.inParami_SubdirectionId,((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsDevEnvironment]))),cancellationToken);

// Empty?
if((localVars.queryResGetUserWithEntraRoleId2_outParamList.Empty)) {
// o_Output
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "Cannot determine the next approver! User with JobTitle" + " '" + GetEntraRoleById.List.Current.EntraRole.RoleName + "' " + "not found or the user with such role has not yet logged into the application."
result.outParamo_Output.ssMessage = ((((AppUtils.GetStringResource("kwBSGiNc6EW7BKvzJvsTxA#Value.-2137137384.1", "Cannot determine the next approver! User with JobTitle")+" '")+localVars.queryResGetEntraRoleById_outParamList.CurrentRec.ssENEntraRole.ssRoleName)+"' ")+AppUtils.GetStringResource("kwBSGiNc6EW7BKvzJvsTxA#Value.1160676689.1", "not found or the user with such role has not yet logged into the application."));
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
// HasActiveSubstitution2
(localVars.resHasActiveSubstitution2.outParamo_SubstituteUserId,localVars.resHasActiveSubstitution2.outParamo_IsSubstituteFor) = await Actions.ActionHasActiveSubstitution(requestContext,localVars.queryResGetUserWithEntraRoleId_outParamList.CurrentRec.ssENUser.ssId,cancellationToken);

// o_Output
// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;

// o_UserId = If
result.outParamo_UserId=(((localVars.resHasActiveSubstitution2.outParamo_SubstituteUserId==BuiltInFunction.NullTextIdentifier ())) ? (localVars.queryResGetUserWithEntraRoleId_outParamList.CurrentRec.ssENUser.ssId) : (localVars.resHasActiveSubstitution2.outParamo_SubstituteUserId));

// o_IsSubstituteFor = HasActiveSubstitution2.o_IsSubstituteFor
result.outParamo_IsSubstituteFor=localVars.resHasActiveSubstitution2.outParamo_IsSubstituteFor;
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

public static class FuncActionFindNextApproverSpecial {

private static async Task<RC_184336c68155ad9e77005f91e8e8b363> datasetGetUserWithEntraRoleIdReadDbAsync(RC_184336c68155ad9e77005f91e8e8b363 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
rec.ssENUserExtension.Read( r, ref index);
return rec;
}
// Query Function "GetUserWithEntraRoleId" bEYHeBEHy0CCanoa5u01WQ of Action "FindNextApproverSpecial"
public static async Task<(RL_bc2063fe1d05aa544017f329fb1e030b,long)> datasetGetUserWithEntraRoleId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpdeUser_Extended_Internal_DepartmentId,long qpenUser_Extended_Internal_EntraRoleId,long qpmaUser_Extended_Internal_ManagementId,long qpreUser_Extended_Internal_RegionId,long qpsuUser_Extended_Internal_SubdirectionId,bool qpboIsDevEnvironment,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("FindNextApproverSpecial.GetUserWithEntraRoleId", "7807466c-0711-40cb-826a-7a1ae6ed3559");
using var queryActivity = activitySource.CreateAggregateQueryActivity("FindNextApproverSpecial.GetUserWithEntraRoleId", "7807466c-0711-40cb-826a-7a1ae6ed3559", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.aP5YOcdaA0G4bRBpFONCJA/NodesNotShownInESpaceTree.bEYHeBEHy0CCanoa5u01WQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enuser39\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27");
fromBuilder.Append(" FROM (({User_Extended_Internal} \"enuser_extended_internal23\" Inner JOIN {User} \"enuser39\" ON (\"enuser_extended_internal23\".\"id\" = \"enuser39\".\"id\"))  Left JOIN {UserExtension} \"enuserextension21\" ON (\"enuser39\".\"id\" = \"enuserextension21\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpreUser_Extended_Internal_RegionId != 0) {
whereBuilder.Append("((\"enuser_extended_internal23\".\"regionid\" = @qpreUser_Extended_Internal_RegionId) AND (\"enuser_extended_internal23\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreUser_Extended_Internal_RegionId", DbType.Int64, qpreUser_Extended_Internal_RegionId);
} else {
whereBuilder.Append("(\"enuser_extended_internal23\".\"regionid\" IS NULL)");
}
whereBuilder.Append(" AND ");
if (qpenUser_Extended_Internal_EntraRoleId != 0) {
whereBuilder.Append("((\"enuser_extended_internal23\".\"entraroleid\" = @qpenUser_Extended_Internal_EntraRoleId) AND (\"enuser_extended_internal23\".\"entraroleid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpenUser_Extended_Internal_EntraRoleId", DbType.Int64, qpenUser_Extended_Internal_EntraRoleId);
} else {
whereBuilder.Append("(\"enuser_extended_internal23\".\"entraroleid\" IS NULL)");
}
whereBuilder.Append(" AND ");
if (qpdeUser_Extended_Internal_DepartmentId != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpdeUser_Extended_Internal_DepartmentId != 0) {
whereBuilder.Append("((\"enuser_extended_internal23\".\"departmentid\" = @qpdeUser_Extended_Internal_DepartmentId) AND (\"enuser_extended_internal23\".\"departmentid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpdeUser_Extended_Internal_DepartmentId", DbType.Int64, qpdeUser_Extended_Internal_DepartmentId);
} else {
whereBuilder.Append("(\"enuser_extended_internal23\".\"departmentid\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpmaUser_Extended_Internal_ManagementId != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpmaUser_Extended_Internal_ManagementId != 0) {
whereBuilder.Append("((\"enuser_extended_internal23\".\"managementid\" = @qpmaUser_Extended_Internal_ManagementId) AND (\"enuser_extended_internal23\".\"managementid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpmaUser_Extended_Internal_ManagementId", DbType.Int64, qpmaUser_Extended_Internal_ManagementId);
} else {
whereBuilder.Append("(\"enuser_extended_internal23\".\"managementid\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpsuUser_Extended_Internal_SubdirectionId != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpsuUser_Extended_Internal_SubdirectionId != 0) {
whereBuilder.Append("((\"enuser_extended_internal23\".\"subdirectionid\" = @qpsuUser_Extended_Internal_SubdirectionId) AND (\"enuser_extended_internal23\".\"subdirectionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuUser_Extended_Internal_SubdirectionId", DbType.Int64, qpsuUser_Extended_Internal_SubdirectionId);
} else {
whereBuilder.Append("(\"enuser_extended_internal23\".\"subdirectionid\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
whereBuilder.Append("((CASE WHEN (@qpboIsDevEnvironment = 1) THEN (CASE WHEN (\"enuserextension21\".\"correspondentexternalemail\" <> '') THEN 1 ELSE 0 END) ELSE 1 END) = 1)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query FindNextApproverSpecial.GetUserWithEntraRoleId.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query FindNextApproverSpecial.GetUserWithEntraRoleId.List", cancellationToken: cancellationToken);
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

private static async Task<RC_9cf096dc3084ff2d0c04fe10cfde3141> datasetGetUserWithEntraRoleId2ReadDbAsync(RC_9cf096dc3084ff2d0c04fe10cfde3141 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENRegion.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
rec.ssENUserExtension.Read( r, ref index);
return rec;
}
// Query Function "GetUserWithEntraRoleId2" WeQhxqF1NU6R5HpU1auBMQ of Action "FindNextApproverSpecial"
public static async Task<(RL_d5b8a84ca389ad87aeb4566f51b893eb,long)> datasetGetUserWithEntraRoleId2(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpdeUser_Extended_Internal_DepartmentId,long qpenUser_Extended_Internal_EntraRoleId,long qpmaUser_Extended_Internal_ManagementId,long qpsuUser_Extended_Internal_SubdirectionId,bool qpboIsDevEnvironment,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("FindNextApproverSpecial.GetUserWithEntraRoleId2", "c621e459-75a1-4e35-91e4-7a54d5ab8131");
using var queryActivity = activitySource.CreateAggregateQueryActivity("FindNextApproverSpecial.GetUserWithEntraRoleId2", "c621e459-75a1-4e35-91e4-7a54d5ab8131", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.aP5YOcdaA0G4bRBpFONCJA/NodesNotShownInESpaceTree.WeQhxqF1NU6R5HpU1auBMQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, \"enuser40\".\"id\" o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40");
fromBuilder.Append(" FROM ((({User_Extended_Internal} \"enuser_extended_internal24\" Inner JOIN {User} \"enuser40\" ON (\"enuser_extended_internal24\".\"id\" = \"enuser40\".\"id\"))  Inner JOIN {Region} \"enregion14\" ON (\"enuser_extended_internal24\".\"regionid\" = \"enregion14\".\"id\"))  Left JOIN {UserExtension} \"enuserextension22\" ON (\"enuser40\".\"id\" = \"enuserextension22\".\"id\")) ");
whereBuilder.Append(" WHERE (caseaccent_normalize(\"enregion14\".\"commissionregion\" collate \"default\") like caseaccent_normalize('R0' collate \"default\")) AND ");
if (qpenUser_Extended_Internal_EntraRoleId != 0) {
whereBuilder.Append("((\"enuser_extended_internal24\".\"entraroleid\" = @qpenUser_Extended_Internal_EntraRoleId) AND (\"enuser_extended_internal24\".\"entraroleid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpenUser_Extended_Internal_EntraRoleId", DbType.Int64, qpenUser_Extended_Internal_EntraRoleId);
} else {
whereBuilder.Append("(\"enuser_extended_internal24\".\"entraroleid\" IS NULL)");
}
whereBuilder.Append(" AND ");
if (qpdeUser_Extended_Internal_DepartmentId != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpdeUser_Extended_Internal_DepartmentId != 0) {
whereBuilder.Append("((\"enuser_extended_internal24\".\"departmentid\" = @qpdeUser_Extended_Internal_DepartmentId) AND (\"enuser_extended_internal24\".\"departmentid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpdeUser_Extended_Internal_DepartmentId", DbType.Int64, qpdeUser_Extended_Internal_DepartmentId);
} else {
whereBuilder.Append("(\"enuser_extended_internal24\".\"departmentid\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpmaUser_Extended_Internal_ManagementId != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpmaUser_Extended_Internal_ManagementId != 0) {
whereBuilder.Append("((\"enuser_extended_internal24\".\"managementid\" = @qpmaUser_Extended_Internal_ManagementId) AND (\"enuser_extended_internal24\".\"managementid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpmaUser_Extended_Internal_ManagementId", DbType.Int64, qpmaUser_Extended_Internal_ManagementId);
} else {
whereBuilder.Append("(\"enuser_extended_internal24\".\"managementid\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpsuUser_Extended_Internal_SubdirectionId != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpsuUser_Extended_Internal_SubdirectionId != 0) {
whereBuilder.Append("((\"enuser_extended_internal24\".\"subdirectionid\" = @qpsuUser_Extended_Internal_SubdirectionId) AND (\"enuser_extended_internal24\".\"subdirectionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuUser_Extended_Internal_SubdirectionId", DbType.Int64, qpsuUser_Extended_Internal_SubdirectionId);
} else {
whereBuilder.Append("(\"enuser_extended_internal24\".\"subdirectionid\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
whereBuilder.Append("((CASE WHEN (@qpboIsDevEnvironment = 1) THEN (CASE WHEN (\"enuserextension22\".\"correspondentexternalemail\" <> '') THEN 1 ELSE 0 END) ELSE 1 END) = 1)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query FindNextApproverSpecial.GetUserWithEntraRoleId2.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query FindNextApproverSpecial.GetUserWithEntraRoleId2.List", cancellationToken: cancellationToken);
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

// Query Function "GetEntraRoleById" Kjfc6l27L0OTl5NdV7bQzg of Action "FindNextApproverSpecial"
public static async Task<(RL_084ec93001d810170970c8007b50b58f,long)> datasetGetEntraRoleById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpenId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("FindNextApproverSpecial.GetEntraRoleById", "eadc372a-bb5d-432f-9397-935d57b6d0ce");
using var queryActivity = activitySource.CreateAggregateQueryActivity("FindNextApproverSpecial.GetEntraRoleById", "eadc372a-bb5d-432f-9397-935d57b6d0ce", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.aP5YOcdaA0G4bRBpFONCJA/NodesNotShownInESpaceTree.Kjfc6l27L0OTl5NdV7bQzg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enentrarole4\".\"rolename\" o1, NULL o2, NULL o3, NULL o4, NULL o5");
fromBuilder.Append(" FROM {EntraRole} \"enentrarole4\"");
whereBuilder.Append(" WHERE ");
if (qpenId != 0) {
whereBuilder.Append("((\"enentrarole4\".\"id\" = @qpenId) AND (\"enentrarole4\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpenId", DbType.Int64, qpenId);
} else {
whereBuilder.Append("(\"enentrarole4\".\"id\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query FindNextApproverSpecial.GetEntraRoleById.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query FindNextApproverSpecial.GetEntraRoleById.List", cancellationToken: cancellationToken);
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



}


}
