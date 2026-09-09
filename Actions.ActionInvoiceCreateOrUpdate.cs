namespace ssConectaProveedores;

public partial class Actions {
public class lcvInvoiceCreateOrUpdate : VarsBag {
public EN_d1d0320db36efbb094ad0082361435a0EntityRecord inParamSource;
public bool inParamIsStartApproval;
public RL_7b3475883ca90ad6eb7fc983e868c456 queryResGetInvoiceById_outParamList = new RL_7b3475883ca90ad6eb7fc983e868c456();
public long queryResGetInvoiceById_outParamCount = 0L;

public long resCreateOrUpdateInvoice_outParamId = 0L;

public lcvInvoiceCreateOrUpdate(EN_d1d0320db36efbb094ad0082361435a0EntityRecord inParamSource, bool inParamIsStartApproval) {
this.inParamSource = inParamSource;
this.inParamIsStartApproval = inParamIsStartApproval;
}
}
public class lcoInvoiceCreateOrUpdate : VarsBag {
public long outParamId = 0L;

public lcoInvoiceCreateOrUpdate() {
}
}
/// <summary>
/// Action <code>InvoiceCreateOrUpdate</code> that represents the Service Studio action
///  <code>InvoiceCreateOrUpdate</code> <p> Description: Encapsulates the CreateOrUpdate entity action
/// , enabling logic to run consistently before and after a record is created or modified.</p>
/// </summary>
public static async Task<long> ActionInvoiceCreateOrUpdate(IRequestContext requestContext,EN_d1d0320db36efbb094ad0082361435a0EntityRecord inParamSource,bool inParamIsStartApproval,CancellationToken cancellationToken) {
long outParamId = default;
lcoInvoiceCreateOrUpdate result = new lcoInvoiceCreateOrUpdate();
lcvInvoiceCreateOrUpdate localVars = new lcvInvoiceCreateOrUpdate(inParamSource, inParamIsStartApproval);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InvoiceCreateOrUpdate", "9789bc5c-238b-42f3-9238-b3feffbce62d"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InvoiceCreateOrUpdate", "9789bc5c-238b-42f3-9238-b3feffbce62d", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Is new record?
if(((localVars.inParamSource.ssId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// Set basic audit attributes
// Source.CreatedOn = CurrDateTime
localVars.inParamSource.ssCreatedOn = BuiltInFunction.CurrDateTime ();

// Source.CreatedBy = GetUserId
localVars.inParamSource.ssCreatedBy = BuiltInFunction.GetUserId ();

// Source.InvoiceStatusId = If
localVars.inParamSource.ssInvoiceStatusId = ((localVars.inParamIsStartApproval) ? ((ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("Q66zN8rsbUynn1JzTqzCFA"))).ssId) : ((ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("Wo+LRDF_n0O7Fo8ikSEsSA"))).ssId));

// Source.SubmittedOn = If
localVars.inParamSource.ssSubmittedOn = (((localVars.inParamSource.ssInvoiceStatusId!=(ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("Wo+LRDF_n0O7Fo8ikSEsSA"))).ssId)) ? (BuiltInFunction.CurrDateTime ()) : (BuiltInFunction.NullDate ()));
} else {
// Query datasetGetInvoiceById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceById_maxRecords = 1;
if (datasetGetInvoiceById_maxRecords < 1) datasetGetInvoiceById_maxRecords = 1;
int datasetGetInvoiceById_startIndex = 0;(localVars.queryResGetInvoiceById_outParamList,localVars.queryResGetInvoiceById_outParamCount) = await FuncActionInvoiceCreateOrUpdate.datasetGetInvoiceById(requestContext,datasetGetInvoiceById_maxRecords,datasetGetInvoiceById_startIndex,IterationMultiplicity.Never,localVars.inParamSource.ssId,cancellationToken);

// Source.CreatedOn = GetInvoiceById.List.Current.Invoice.CreatedOn
localVars.inParamSource.ssCreatedOn = localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssCreatedOn;

// Source.CreatedBy = GetInvoiceById.List.Current.Invoice.CreatedBy
localVars.inParamSource.ssCreatedBy = localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssCreatedBy;

// Source.InvoiceStatusId = Source.InvoiceStatusId
localVars.inParamSource.ssInvoiceStatusId = localVars.inParamSource.ssInvoiceStatusId;

// Source.IsNewVersion = GetInvoiceById.List.Current.Invoice.InvoiceStatusId = Modify or Source.IsNewVersion
localVars.inParamSource.ssIsNewVersion = ((localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssInvoiceStatusId==(ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("ASvPCAkuaEyQ8YlZNO_ZcQ"))).ssId)||localVars.inParamSource.ssIsNewVersion);

// Source.SubmittedOn = If
localVars.inParamSource.ssSubmittedOn = (((localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssSubmittedOn!=BuiltInFunction.NullDate ())) ? (localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssSubmittedOn) : ((((localVars.inParamSource.ssInvoiceStatusId!=(ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("Wo+LRDF_n0O7Fo8ikSEsSA"))).ssId)) ? (BuiltInFunction.CurrDateTime ()) : (BuiltInFunction.NullDate ()))));
}

// Set basic audit attributes
// Source.UpdatedOn = CurrDateTime
localVars.inParamSource.ssUpdatedOn = BuiltInFunction.CurrDateTime ();

// Source.UpdatedBy = GetUserId
localVars.inParamSource.ssUpdatedBy = BuiltInFunction.GetUserId ();
// CreateOrUpdateInvoice
localVars.resCreateOrUpdateInvoice_outParamId = await ExtendedActions.CreateOrUpdateInvoice(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_04c5986b32c7822f033c933cf71b96bd)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateOrUpdateInvoice.Id
result.outParamId=localVars.resCreateOrUpdateInvoice_outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionInvoiceCreateOrUpdate {

// Query Function "GetInvoiceById" K03mSUd2ZEWLPCsMfjQFpg of Action "InvoiceCreateOrUpdate"
public static async Task<(RL_7b3475883ca90ad6eb7fc983e868c456,long)> datasetGetInvoiceById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvoiceCreateOrUpdate.GetInvoiceById", "49e64d2b-7647-4564-8b3c-2b0c7e3405a6");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvoiceCreateOrUpdate.GetInvoiceById", "49e64d2b-7647-4564-8b3c-2b0c7e3405a6", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.XLyJl4sj80KSOLP+_7zmLQ/NodesNotShownInESpaceTree.K03mSUd2ZEWLPCsMfjQFpg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, \"eninvoice41\".\"invoicestatusid\" o8, NULL o9, NULL o10, \"eninvoice41\".\"createdon\" o11, \"eninvoice41\".\"createdby\" o12, NULL o13, NULL o14, \"eninvoice41\".\"submittedon\" o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23");
fromBuilder.Append(" FROM {Invoice} \"eninvoice41\"");
whereBuilder.Append(" WHERE ");
if (qpinId != 0) {
whereBuilder.Append("((\"eninvoice41\".\"id\" = @qpinId) AND (\"eninvoice41\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinId", DbType.Int64, qpinId);
} else {
whereBuilder.Append("(\"eninvoice41\".\"id\" IS NULL)");
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
RL_7b3475883ca90ad6eb7fc983e868c456 outParamList = new RL_7b3475883ca90ad6eb7fc983e868c456();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, false, true, true, false, false, true, true, false, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvoiceCreateOrUpdate.GetInvoiceById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_7b3475883ca90ad6eb7fc983e868c456 _tmp = new RL_7b3475883ca90ad6eb7fc983e868c456();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvoiceCreateOrUpdate.GetInvoiceById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_7b3475883ca90ad6eb7fc983e868c456)_tmp;
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
