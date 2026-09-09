namespace ssConectaProveedores;

public partial class Actions {
public class lcvSaveRequisitionAccConcepts : VarsBag {
public long inParami_RequisitionId;
public RL_eb1e4f883a237aab70c23418de71281c inParami_RequisitionAccConceptsList;
public RC_baf165956df9a5eebdc813b129b5fb73 inParami_RequisitionAccConcept_EstimEqualAg;
public Actions.lcoRequisitionAccConceptsCreateOrUpdate resRequisitionAccConceptsCreateOrUpdate =  new Actions.lcoRequisitionAccConceptsCreateOrUpdate();
public Actions.lcoRequisitionAccConceptsCreateOrUpdate resRequisitionAccConceptsCreateOrUpdate2 =  new Actions.lcoRequisitionAccConceptsCreateOrUpdate();
public RL_9913d30c00d0b2d8d5501344f1ce9ceb queryResGetRequisitionAccConceptsByRequisitionId_outParamList = new RL_9913d30c00d0b2d8d5501344f1ce9ceb();
public long queryResGetRequisitionAccConceptsByRequisitionId_outParamCount = 0L;

public Actions.lcoRequisitionAccConceptsCreateOrUpdate resRequisitionAccConceptsCreateOrUpdate3 =  new Actions.lcoRequisitionAccConceptsCreateOrUpdate();
public lcvSaveRequisitionAccConcepts(long inParami_RequisitionId, RL_eb1e4f883a237aab70c23418de71281c inParami_RequisitionAccConceptsList, RC_baf165956df9a5eebdc813b129b5fb73 inParami_RequisitionAccConcept_EstimEqualAg) {
this.inParami_RequisitionId = inParami_RequisitionId;
this.inParami_RequisitionAccConceptsList = inParami_RequisitionAccConceptsList;
this.inParami_RequisitionAccConcept_EstimEqualAg = inParami_RequisitionAccConcept_EstimEqualAg;
}
}
/// <summary>
/// Action <code>SaveRequisitionAccConcepts</code> that represents the Service Studio action
///  <code>SaveRequisitionAccConcepts</code> <p> Description: </p>
/// </summary>
public static async Task ActionSaveRequisitionAccConcepts(IRequestContext requestContext,long inParami_RequisitionId,RL_eb1e4f883a237aab70c23418de71281c inParami_RequisitionAccConceptsList,RC_baf165956df9a5eebdc813b129b5fb73 inParami_RequisitionAccConcept_EstimEqualAg,CancellationToken cancellationToken) {
lcvSaveRequisitionAccConcepts localVars = new lcvSaveRequisitionAccConcepts(inParami_RequisitionId, inParami_RequisitionAccConceptsList, inParami_RequisitionAccConcept_EstimEqualAg);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("SaveRequisitionAccConcepts", "87d57b85-00a2-49b7-9d3d-12772c5ce081"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("SaveRequisitionAccConcepts", "87d57b85-00a2-49b7-9d3d-12772c5ce081", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetRequisitionAccConceptsByRequisitionId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionAccConceptsByRequisitionId_maxRecords = 0;
int datasetGetRequisitionAccConceptsByRequisitionId_startIndex = 0;(localVars.queryResGetRequisitionAccConceptsByRequisitionId_outParamList,localVars.queryResGetRequisitionAccConceptsByRequisitionId_outParamCount) = await FuncActionSaveRequisitionAccConcepts.datasetGetRequisitionAccConceptsByRequisitionId(requestContext,datasetGetRequisitionAccConceptsByRequisitionId_maxRecords,datasetGetRequisitionAccConceptsByRequisitionId_startIndex,IterationMultiplicity.Single,localVars.inParami_RequisitionId,cancellationToken);

// Foreach GetRequisitionAccConceptsByRequisitionId.List
localVars.queryResGetRequisitionAccConceptsByRequisitionId_outParamList.StartIteration();
try {while (!((localVars.queryResGetRequisitionAccConceptsByRequisitionId_outParamList.Eof))) {
// DeleteRequisitionAccConcepts
await ExtendedActions.DeleteRequisitionAccConcepts(requestContext,localVars.queryResGetRequisitionAccConceptsByRequisitionId_outParamList.CurrentRec.ssENRequisitionAccConcepts.ssId,cancellationToken);

localVars.queryResGetRequisitionAccConceptsByRequisitionId_outParamList.Advance();
}

} finally {
localVars.queryResGetRequisitionAccConceptsByRequisitionId_outParamList.EndIteration();
}

// RequisitionAccConceptsCreateOrUpdate3
localVars.resRequisitionAccConceptsCreateOrUpdate3.outParamId = await Actions.ActionRequisitionAccConceptsCreateOrUpdate(requestContext,localVars.inParami_RequisitionAccConcept_EstimEqualAg.ssENMainAccConcepts,cancellationToken);

if((localVars.inParami_RequisitionAccConcept_EstimEqualAg.ssENMainAccConcepts.ssIsActive)) {
// Foreach i_RequisitionAccConcept_EstimEqualAg.SubAccConcepts
localVars.inParami_RequisitionAccConcept_EstimEqualAg.ssRLSubAccConcepts.StartIteration();
try {while (!((localVars.inParami_RequisitionAccConcept_EstimEqualAg.ssRLSubAccConcepts.Eof))) {
// i_RequisitionAccConcept_EstimEqualAg.SubAccConcepts.Current.RequisitionAccountingId = i_RequisitionAccConcept_EstimEqualAg.MainAccConcepts.RequisitionAccountingId
localVars.inParami_RequisitionAccConcept_EstimEqualAg.ssRLSubAccConcepts.CurrentRec.ssRequisitionAccountingId = localVars.inParami_RequisitionAccConcept_EstimEqualAg.ssENMainAccConcepts.ssRequisitionAccountingId;

// i_RequisitionAccConcept_EstimEqualAg.SubAccConcepts.Current.RequisitionAccConceptsId = i_RequisitionAccConcept_EstimEqualAg.MainAccConcepts.Id
localVars.inParami_RequisitionAccConcept_EstimEqualAg.ssRLSubAccConcepts.CurrentRec.ssRequisitionAccConceptsId = localVars.inParami_RequisitionAccConcept_EstimEqualAg.ssENMainAccConcepts.ssId;

// i_RequisitionAccConcept_EstimEqualAg.SubAccConcepts.Current.IsActive = True
localVars.inParami_RequisitionAccConcept_EstimEqualAg.ssRLSubAccConcepts.CurrentRec.ssIsActive = true;
// RequisitionAccConceptsCreateOrUpdate2
localVars.resRequisitionAccConceptsCreateOrUpdate2.outParamId = await Actions.ActionRequisitionAccConceptsCreateOrUpdate(requestContext,localVars.inParami_RequisitionAccConcept_EstimEqualAg.ssRLSubAccConcepts.CurrentRec,cancellationToken);

localVars.inParami_RequisitionAccConcept_EstimEqualAg.ssRLSubAccConcepts.Advance();
}

} finally {
localVars.inParami_RequisitionAccConcept_EstimEqualAg.ssRLSubAccConcepts.EndIteration();
}

}

// Foreach i_RequisitionAccConceptsList
localVars.inParami_RequisitionAccConceptsList.StartIteration();
try {while (!((localVars.inParami_RequisitionAccConceptsList.Eof))) {
if((!(localVars.inParami_RequisitionAccConceptsList.CurrentRec.ssIsActive))) {
// i_RequisitionAccConceptsList.Current.NumberOfPayments = 0
localVars.inParami_RequisitionAccConceptsList.CurrentRec.ssNumberOfPayments = 0;

// i_RequisitionAccConceptsList.Current.Amount = 0
localVars.inParami_RequisitionAccConceptsList.CurrentRec.ssAmount = (((decimal)0));

// i_RequisitionAccConceptsList.Current.CurrencyId = NullTextIdentifier
localVars.inParami_RequisitionAccConceptsList.CurrentRec.ssCurrencyId = BuiltInFunction.NullTextIdentifier ();
}

// RequisitionAccConceptsCreateOrUpdate
localVars.resRequisitionAccConceptsCreateOrUpdate.outParamId = await Actions.ActionRequisitionAccConceptsCreateOrUpdate(requestContext,localVars.inParami_RequisitionAccConceptsList.CurrentRec,cancellationToken);

localVars.inParami_RequisitionAccConceptsList.Advance();
}

} finally {
localVars.inParami_RequisitionAccConceptsList.EndIteration();
}

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionSaveRequisitionAccConcepts {

private static async Task<RC_6b7fc732cea9431ac6d7f95245acde2b> datasetGetRequisitionAccConceptsByRequisitionIdReadDbAsync(RC_6b7fc732cea9431ac6d7f95245acde2b rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENRequisitionAccConcepts.Read( r, ref index);
rec.ssENRequisitionAccounting.Read( r, ref index);
return rec;
}
// Query Function "GetRequisitionAccConceptsByRequisitionId" H4GvXDzoZEy_p3Ucgljjzw of Action "SaveRequisitionAccConcepts"
public static async Task<(RL_9913d30c00d0b2d8d5501344f1ce9ceb,long)> datasetGetRequisitionAccConceptsByRequisitionId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisitionAccounting_RequisitionId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SaveRequisitionAccConcepts.GetRequisitionAccConceptsByRequisitionId", "5caf811f-e83c-4c64-bfa7-751c8258e3cf");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SaveRequisitionAccConcepts.GetRequisitionAccConceptsByRequisitionId", "5caf811f-e83c-4c64-bfa7-751c8258e3cf", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.hXvVh6IAt0mdPRJ3LFzggQ/NodesNotShownInESpaceTree.H4GvXDzoZEy_p3Ucgljjzw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enrequisitionaccconcepts3\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26");
fromBuilder.Append(" FROM ({RequisitionAccounting} \"enrequisitionaccounting4\" Left JOIN {RequisitionAccConcepts} \"enrequisitionaccconcepts3\" ON (\"enrequisitionaccounting4\".\"id\" = \"enrequisitionaccconcepts3\".\"requisitionaccountingid\")) ");
whereBuilder.Append(" WHERE ");
if (qpreRequisitionAccounting_RequisitionId != 0) {
whereBuilder.Append("((\"enrequisitionaccounting4\".\"requisitionid\" = @qpreRequisitionAccounting_RequisitionId) AND (\"enrequisitionaccounting4\".\"requisitionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisitionAccounting_RequisitionId", DbType.Int64, qpreRequisitionAccounting_RequisitionId);
} else {
whereBuilder.Append("(\"enrequisitionaccounting4\".\"requisitionid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enrequisitionaccconcepts3\".\"requisitionaccconceptsid\" IS NOT NULL)");
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
RL_9913d30c00d0b2d8d5501344f1ce9ceb outParamList = new RL_9913d30c00d0b2d8d5501344f1ce9ceb();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetRequisitionAccConceptsByRequisitionIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SaveRequisitionAccConcepts.GetRequisitionAccConceptsByRequisitionId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_9913d30c00d0b2d8d5501344f1ce9ceb _tmp = new RL_9913d30c00d0b2d8d5501344f1ce9ceb();
_tmp.AlternateReadDbMethodAsync = datasetGetRequisitionAccConceptsByRequisitionIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SaveRequisitionAccConcepts.GetRequisitionAccConceptsByRequisitionId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_9913d30c00d0b2d8d5501344f1ce9ceb)_tmp;
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
