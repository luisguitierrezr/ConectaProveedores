namespace ssConectaProveedores;

public partial class Actions {
public class lcvInitReqWF_CxP : VarsBag {
public long inParami_RequisitionId;
public RL_0ad79b64673379e41188da81c3628c0f queryResGetRequisitionById_outParamList = new RL_0ad79b64673379e41188da81c3628c0f();
public long queryResGetRequisitionById_outParamCount = 0L;

public Actions.lcoRequisitionAccoutingCreateOrUpdate resRequisitionAccoutingCreateOrUpdate =  new Actions.lcoRequisitionAccoutingCreateOrUpdate();
public RL_d567d658fa66fc955f880e37985e7f35 queryResGetAccountingDataTypes_outParamList = new RL_d567d658fa66fc955f880e37985e7f35();
public long queryResGetAccountingDataTypes_outParamCount = 0L;

public Actions.lcoRequisitionAccConceptsCreateOrUpdate resRequisitionAccConceptsCreateOrUpdate =  new Actions.lcoRequisitionAccConceptsCreateOrUpdate();
public lcvInitReqWF_CxP(long inParami_RequisitionId) {
this.inParami_RequisitionId = inParami_RequisitionId;
}
}
/// <summary>
/// Action <code>InitReqWF_CxP</code> that represents the Service Studio action
///  <code>InitReqWF_CxP</code> <p> Description: </p>
/// </summary>
public static async Task ActionInitReqWF_CxP(IRequestContext requestContext,long inParami_RequisitionId,CancellationToken cancellationToken) {
lcvInitReqWF_CxP localVars = new lcvInitReqWF_CxP(inParami_RequisitionId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InitReqWF_CxP", "2d7e27e7-74d7-4982-98d7-d4fd90aff58b"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InitReqWF_CxP", "2d7e27e7-74d7-4982-98d7-d4fd90aff58b", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetRequisitionById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionById_maxRecords = 1;
if (datasetGetRequisitionById_maxRecords < 1) datasetGetRequisitionById_maxRecords = 1;
int datasetGetRequisitionById_startIndex = 0;(localVars.queryResGetRequisitionById_outParamList,localVars.queryResGetRequisitionById_outParamCount) = await FuncActionInitReqWF_CxP.datasetGetRequisitionById(requestContext,datasetGetRequisitionById_maxRecords,datasetGetRequisitionById_startIndex,IterationMultiplicity.Never,localVars.inParami_RequisitionId,cancellationToken);

// RequisitionAccoutingCreateOrUpdate
localVars.resRequisitionAccoutingCreateOrUpdate.outParamId = await Actions.ActionRequisitionAccoutingCreateOrUpdate(requestContext,new EN_3554712eb61e9f0a2132c551df0f1db5EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssRequisitionId = localVars.inParami_RequisitionId, ssNegociatedExchangeRateAcc = localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssNegotiatedExchangeRate },cancellationToken);

// Query datasetGetAccountingDataTypes
cancellationToken.ThrowIfCancellationRequested();
int datasetGetAccountingDataTypes_maxRecords = 0;
int datasetGetAccountingDataTypes_startIndex = 0;(localVars.queryResGetAccountingDataTypes_outParamList,localVars.queryResGetAccountingDataTypes_outParamCount) = await FuncActionInitReqWF_CxP.datasetGetAccountingDataTypes(requestContext,datasetGetAccountingDataTypes_maxRecords,datasetGetAccountingDataTypes_startIndex,IterationMultiplicity.Single,cancellationToken);

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

public static class FuncActionInitReqWF_CxP {

// Query Function "GetRequisitionById" r7LAfydU5UKMPYylQSXDcQ of Action "InitReqWF_CxP"
public static async Task<(RL_0ad79b64673379e41188da81c3628c0f,long)> datasetGetRequisitionById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InitReqWF_CxP.GetRequisitionById", "7fc0b2af-5427-42e5-8c3d-8ca54125c371");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InitReqWF_CxP.GetRequisitionById", "7fc0b2af-5427-42e5-8c3d-8ca54125c371", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.5yd+Ldd0gkmY19T9kK_1iw/NodesNotShownInESpaceTree.r7LAfydU5UKMPYylQSXDcQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, trim_scale(\"enrequisition11\".\"negotiatedexchangerate\"::numeric) o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57");
fromBuilder.Append(" FROM {Requisition} \"enrequisition11\"");
whereBuilder.Append(" WHERE ");
if (qpreId != 0) {
whereBuilder.Append("((\"enrequisition11\".\"id\" = @qpreId) AND (\"enrequisition11\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreId", DbType.Int64, qpreId);
} else {
whereBuilder.Append("(\"enrequisition11\".\"id\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InitReqWF_CxP.GetRequisitionById.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InitReqWF_CxP.GetRequisitionById.List", cancellationToken: cancellationToken);
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

// Query Function "GetAccountingDataTypes" zJ1Rto4kvkmNsoKXFNEbXQ of Action "InitReqWF_CxP"
public static async Task<(RL_d567d658fa66fc955f880e37985e7f35,long)> datasetGetAccountingDataTypes(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InitReqWF_CxP.GetAccountingDataTypes", "b6519dcc-248e-49be-8db2-829714d11b5d");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InitReqWF_CxP.GetAccountingDataTypes", "b6519dcc-248e-49be-8db2-829714d11b5d", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.5yd+Ldd0gkmY19T9kK_1iw/NodesNotShownInESpaceTree.zJ1Rto4kvkmNsoKXFNEbXQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enaccountingdatatype1\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4");
fromBuilder.Append(" FROM {AccountingDataType} \"enaccountingdatatype1\"");
whereBuilder.Append(" WHERE (\"enaccountingdatatype1\".\"is_active\" = 1) AND (NOT (\"enaccountingdatatype1\".\"isestim_equal_agreed\" = 1))");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InitReqWF_CxP.GetAccountingDataTypes.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InitReqWF_CxP.GetAccountingDataTypes.List", cancellationToken: cancellationToken);
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



}


}
