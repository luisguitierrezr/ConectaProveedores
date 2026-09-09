namespace ssConectaProveedores;

public partial class Actions {
public class lcvCreatePositionContacts : VarsBag {
public BasicTypeList<string> inParamPositionContactList;
public RL_084ec93001d810170970c8007b50b58f queryResGetAllEntraRole_outParamList = new RL_084ec93001d810170970c8007b50b58f();
public long queryResGetAllEntraRole_outParamCount = 0L;

public RL_084ec93001d810170970c8007b50b58f resListFilter_outParamFilteredList = new RL_084ec93001d810170970c8007b50b58f();

public Actions.lcoAddNewRole resAddNewRole =  new Actions.lcoAddNewRole();
public BasicTypeList<string> resGetJustWithNotEmptyValues_outParamFilteredList = new BasicTypeList<string>();

public RL_084ec93001d810170970c8007b50b58f queryResGetLast_outParamList = new RL_084ec93001d810170970c8007b50b58f();
public long queryResGetLast_outParamCount = 0L;

public BasicTypeList<string> resGetDistinctPositionContact_outParamDistinctList = new BasicTypeList<string>();

public lcvCreatePositionContacts(BasicTypeList<string> inParamPositionContactList) {
this.inParamPositionContactList = inParamPositionContactList;
}
}
public class lcoCreatePositionContacts : VarsBag {
public long outParamLastPositionContractId = 0L;

public lcoCreatePositionContacts() {
}
}
/// <summary>
/// Action <code>CreatePositionContacts</code> that represents the Service Studio action
///  <code>CreatePositionContacts</code> <p> Description: </p>
/// </summary>
public static async Task<long> ActionCreatePositionContacts(IRequestContext requestContext,BasicTypeList<string> inParamPositionContactList,CancellationToken cancellationToken) {
long outParamLastPositionContractId = default;
lcoCreatePositionContacts result = new lcoCreatePositionContacts();
lcvCreatePositionContacts localVars = new lcvCreatePositionContacts(inParamPositionContactList);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("CreatePositionContacts", "753ff5cd-a7f8-4590-9efc-e7b30c98914e"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("CreatePositionContacts", "753ff5cd-a7f8-4590-9efc-e7b30c98914e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// GetDistinctPositionContact
localVars.resGetDistinctPositionContact_outParamDistinctList = (((BasicTypeList<string>) localVars.inParamPositionContactList.Distinct()));

// GetJustWithNotEmptyValues
localVars.resGetJustWithNotEmptyValues_outParamFilteredList = (((BasicTypeList<string>)await  localVars.resGetDistinctPositionContact_outParamDistinctList.FilterAsync(async (p, cancellationToken) => (BuiltInFunction.Trim (p)!=""), cancellationToken)));

// Query datasetGetAllEntraRole
cancellationToken.ThrowIfCancellationRequested();
int datasetGetAllEntraRole_maxRecords = 99999;
if (datasetGetAllEntraRole_maxRecords < 1) datasetGetAllEntraRole_maxRecords = 1;
int datasetGetAllEntraRole_startIndex = 0;(localVars.queryResGetAllEntraRole_outParamList,localVars.queryResGetAllEntraRole_outParamCount) = await FuncActionCreatePositionContacts.datasetGetAllEntraRole(requestContext,datasetGetAllEntraRole_maxRecords,datasetGetAllEntraRole_startIndex,IterationMultiplicity.Multiple,cancellationToken);

// Foreach GetJustWithNotEmptyValues.FilteredList
localVars.resGetJustWithNotEmptyValues_outParamFilteredList.StartIteration();
try {while (!((localVars.resGetJustWithNotEmptyValues_outParamFilteredList.Eof))) {
if((!(localVars.queryResGetAllEntraRole_outParamList.Empty))) {
// ListFilter
localVars.resListFilter_outParamFilteredList = (((RL_084ec93001d810170970c8007b50b58f)await  localVars.queryResGetAllEntraRole_outParamList.FilterAsync(async (p, cancellationToken) => (BuiltInFunction.ToUpper (p.ssENEntraRole.ssRoleName)==BuiltInFunction.Trim (BuiltInFunction.ToUpper (localVars.resGetJustWithNotEmptyValues_outParamFilteredList.CurrentRec))), cancellationToken)));

if((!(localVars.resListFilter_outParamFilteredList.Empty))) {
localVars.resGetJustWithNotEmptyValues_outParamFilteredList.Advance();
continue;
}

}

// AddNewRole
localVars.resAddNewRole.outParamIsSuccess = await Actions.ActionAddNewRole(requestContext,BuiltInFunction.Trim (BuiltInFunction.ToUpper (localVars.resGetJustWithNotEmptyValues_outParamFilteredList.CurrentRec)),cancellationToken);

// not IsSuccess?
if(((!localVars.resAddNewRole.outParamIsSuccess))) {
// RaiseError GetNextApprover
throw new Ex_GetNextApproverUserException (AppUtils.GetStringResource("pwYvFanWeUeuZmCsJaXqWw#Message.-709613.1", "New Job Title from Entra detected. Error creating new record."));

}

localVars.resGetJustWithNotEmptyValues_outParamFilteredList.Advance();
}

} finally {
localVars.resGetJustWithNotEmptyValues_outParamFilteredList.EndIteration();
}

// CommitTransaction
await ExtendedActions.CommitTransaction(requestContext,cancellationToken);

// Query datasetGetLast
cancellationToken.ThrowIfCancellationRequested();
int datasetGetLast_maxRecords = 1;
if (datasetGetLast_maxRecords < 1) datasetGetLast_maxRecords = 1;
int datasetGetLast_startIndex = 0;(localVars.queryResGetLast_outParamList,localVars.queryResGetLast_outParamCount) = await FuncActionCreatePositionContacts.datasetGetLast(requestContext,datasetGetLast_maxRecords,datasetGetLast_startIndex,IterationMultiplicity.Never,localVars.resGetJustWithNotEmptyValues_outParamFilteredList.CurrentRec,cancellationToken);

// LastPositionContractId = GetLast.List.Current.EntraRole.Id
result.outParamLastPositionContractId=localVars.queryResGetLast_outParamList.CurrentRec.ssENEntraRole.ssId;
} //close CreateActionActivity using block
} // try

finally {
outParamLastPositionContractId = result.outParamLastPositionContractId;
} // inner-finally
RETURN_STATEMENT:
return outParamLastPositionContractId;
}

public static class FuncActionCreatePositionContacts {

// Query Function "GetAllEntraRole" K31LTRe5PE+MpWRLQeEZ7Q of Action "CreatePositionContacts"
public static async Task<(RL_084ec93001d810170970c8007b50b58f,long)> datasetGetAllEntraRole(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("CreatePositionContacts.GetAllEntraRole", "4d4b7d2b-b917-4f3c-8ca5-644b41e119ed");
using var queryActivity = activitySource.CreateAggregateQueryActivity("CreatePositionContacts.GetAllEntraRole", "4d4b7d2b-b917-4f3c-8ca5-644b41e119ed", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.zfU_dfinkEWe_OezDJiRTg/NodesNotShownInESpaceTree.K31LTRe5PE+MpWRLQeEZ7Q, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enentrarole18\".\"rolename\" o1, NULL o2, NULL o3, NULL o4, NULL o5");
fromBuilder.Append(" FROM {EntraRole} \"enentrarole18\"");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query CreatePositionContacts.GetAllEntraRole.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query CreatePositionContacts.GetAllEntraRole.List", cancellationToken: cancellationToken);
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

// Query Function "GetLast" u2nxyZl64ECRVbHnieZSJw of Action "CreatePositionContacts"
public static async Task<(RL_084ec93001d810170970c8007b50b58f,long)> datasetGetLast(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteRoleName,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("CreatePositionContacts.GetLast", "c9f169bb-7a99-40e0-9155-b1e789e65227");
using var queryActivity = activitySource.CreateAggregateQueryActivity("CreatePositionContacts.GetLast", "c9f169bb-7a99-40e0-9155-b1e789e65227", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.zfU_dfinkEWe_OezDJiRTg/NodesNotShownInESpaceTree.u2nxyZl64ECRVbHnieZSJw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enentrarole19\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5");
fromBuilder.Append(" FROM {EntraRole} \"enentrarole19\"");
whereBuilder.Append(" WHERE ((Upper(\"enentrarole19\".\"rolename\")) = (trim((Upper(@qpteRoleName)))))");
sqlCmd.CreateParameterWithoutReplacements("@qpteRoleName", DbType.String, qpteRoleName);
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
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query CreatePositionContacts.GetLast.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query CreatePositionContacts.GetLast.List", cancellationToken: cancellationToken);
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
