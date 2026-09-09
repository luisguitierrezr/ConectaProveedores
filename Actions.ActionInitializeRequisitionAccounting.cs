namespace ssConectaProveedores;

public partial class Actions {
public class lcvInitializeRequisitionAccounting : VarsBag {
public long inParami_RequisitionId;
public RL_d567d658fa66fc955f880e37985e7f35 queryResGetAccountingDataTypes_outParamList = new RL_d567d658fa66fc955f880e37985e7f35();
public long queryResGetAccountingDataTypes_outParamCount = 0L;

public Actions.lcoRequisitionAccoutingCreateOrUpdate resRequisitionAccoutingCreateOrUpdate =  new Actions.lcoRequisitionAccoutingCreateOrUpdate();
public RL_0ad79b64673379e41188da81c3628c0f queryResGetRequisitionById_outParamList = new RL_0ad79b64673379e41188da81c3628c0f();
public long queryResGetRequisitionById_outParamCount = 0L;

public Actions.lcoRequisitionAccConceptsCreateOrUpdate resRequisitionAccConceptsCreateOrUpdate =  new Actions.lcoRequisitionAccConceptsCreateOrUpdate();
public lcvInitializeRequisitionAccounting(long inParami_RequisitionId) {
this.inParami_RequisitionId = inParami_RequisitionId;
}
}
/// <summary>
/// Action <code>InitializeRequisitionAccounting</code> that represents the Service Studio action
///  <code>InitializeRequisitionAccounting</code> <p> Description: </p>
/// </summary>
public static async Task ActionInitializeRequisitionAccounting(IRequestContext requestContext,long inParami_RequisitionId,CancellationToken cancellationToken) {
lcvInitializeRequisitionAccounting localVars = new lcvInitializeRequisitionAccounting(inParami_RequisitionId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InitializeRequisitionAccounting", "acc9fbbc-8f69-4741-b1a2-fed74a10e9ea"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InitializeRequisitionAccounting", "acc9fbbc-8f69-4741-b1a2-fed74a10e9ea", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetRequisitionById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionById_maxRecords = 1;
if (datasetGetRequisitionById_maxRecords < 1) datasetGetRequisitionById_maxRecords = 1;
int datasetGetRequisitionById_startIndex = 0;(localVars.queryResGetRequisitionById_outParamList,localVars.queryResGetRequisitionById_outParamCount) = await FuncActionInitializeRequisitionAccounting.datasetGetRequisitionById(requestContext,datasetGetRequisitionById_maxRecords,datasetGetRequisitionById_startIndex,IterationMultiplicity.Never,localVars.inParami_RequisitionId,cancellationToken);

// RequisitionAccoutingCreateOrUpdate
localVars.resRequisitionAccoutingCreateOrUpdate.outParamId = await Actions.ActionRequisitionAccoutingCreateOrUpdate(requestContext,new EN_3554712eb61e9f0a2132c551df0f1db5EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssRequisitionId = localVars.inParami_RequisitionId, ssNegociatedExchangeRateAcc = localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssNegotiatedExchangeRate },cancellationToken);

// Query datasetGetAccountingDataTypes
cancellationToken.ThrowIfCancellationRequested();
int datasetGetAccountingDataTypes_maxRecords = 0;
int datasetGetAccountingDataTypes_startIndex = 0;(localVars.queryResGetAccountingDataTypes_outParamList,localVars.queryResGetAccountingDataTypes_outParamCount) = await FuncActionInitializeRequisitionAccounting.datasetGetAccountingDataTypes(requestContext,datasetGetAccountingDataTypes_maxRecords,datasetGetAccountingDataTypes_startIndex,IterationMultiplicity.Single,cancellationToken);

// Foreach GetAccountingDataTypes.List
localVars.queryResGetAccountingDataTypes_outParamList.StartIteration();
try {while (!((localVars.queryResGetAccountingDataTypes_outParamList.Eof))) {
// RequisitionAccConceptsCreateOrUpdate
localVars.resRequisitionAccConceptsCreateOrUpdate.outParamId = await Actions.ActionRequisitionAccConceptsCreateOrUpdate(requestContext,new EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssRequisitionAccountingId = localVars.resRequisitionAccoutingCreateOrUpdate.outParamId, ssAccountingDataTypeId = localVars.queryResGetAccountingDataTypes_outParamList.CurrentRec.ssENAccountingDataType.ssId, ssNumberOfPayments = 0, ssAmount = (((decimal)0)), ssCurrencyId = BuiltInFunction.NullTextIdentifier (), ssRequisitionAccConceptsId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssIsActive = false },cancellationToken);

localVars.queryResGetAccountingDataTypes_outParamList.Advance();
}

} finally {
localVars.queryResGetAccountingDataTypes_outParamList.EndIteration();
}

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionInitializeRequisitionAccounting {

// Query Function "GetAccountingDataTypes" CdGKV95DM0+qe13ujAraQw of Action "InitializeRequisitionAccounting"
public static async Task<(RL_d567d658fa66fc955f880e37985e7f35,long)> datasetGetAccountingDataTypes(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InitializeRequisitionAccounting.GetAccountingDataTypes", "578ad109-43de-4f33-aa7b-5dee8c0ada43");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InitializeRequisitionAccounting.GetAccountingDataTypes", "578ad109-43de-4f33-aa7b-5dee8c0ada43", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.vPvJrGmPQUexov7XShDp6g/NodesNotShownInESpaceTree.CdGKV95DM0+qe13ujAraQw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enaccountingdatatype5\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4");
fromBuilder.Append(" FROM {AccountingDataType} \"enaccountingdatatype5\"");
whereBuilder.Append(" WHERE (\"enaccountingdatatype5\".\"is_active\" = 1) AND (NOT (\"enaccountingdatatype5\".\"isestim_equal_agreed\" = 1))");
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
RL_d567d658fa66fc955f880e37985e7f35 outParamList = new RL_d567d658fa66fc955f880e37985e7f35();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InitializeRequisitionAccounting.GetAccountingDataTypes.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_d567d658fa66fc955f880e37985e7f35 _tmp = new RL_d567d658fa66fc955f880e37985e7f35();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InitializeRequisitionAccounting.GetAccountingDataTypes.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_d567d658fa66fc955f880e37985e7f35)_tmp;
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

// Query Function "GetRequisitionById" wF87fkBnukqUBg7mLqpWsg of Action "InitializeRequisitionAccounting"
public static async Task<(RL_0ad79b64673379e41188da81c3628c0f,long)> datasetGetRequisitionById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InitializeRequisitionAccounting.GetRequisitionById", "7e3b5fc0-6740-4aba-9406-0ee62eaa56b2");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InitializeRequisitionAccounting.GetRequisitionById", "7e3b5fc0-6740-4aba-9406-0ee62eaa56b2", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.vPvJrGmPQUexov7XShDp6g/NodesNotShownInESpaceTree.wF87fkBnukqUBg7mLqpWsg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, trim_scale(\"enrequisition44\".\"negotiatedexchangerate\"::numeric) o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57");
fromBuilder.Append(" FROM {Requisition} \"enrequisition44\"");
whereBuilder.Append(" WHERE ");
if (qpreId != 0) {
whereBuilder.Append("((\"enrequisition44\".\"id\" = @qpreId) AND (\"enrequisition44\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreId", DbType.Int64, qpreId);
} else {
whereBuilder.Append("(\"enrequisition44\".\"id\" IS NULL)");
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
RL_0ad79b64673379e41188da81c3628c0f outParamList = new RL_0ad79b64673379e41188da81c3628c0f();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InitializeRequisitionAccounting.GetRequisitionById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_0ad79b64673379e41188da81c3628c0f _tmp = new RL_0ad79b64673379e41188da81c3628c0f();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InitializeRequisitionAccounting.GetRequisitionById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_0ad79b64673379e41188da81c3628c0f)_tmp;
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
