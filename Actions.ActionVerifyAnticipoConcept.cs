namespace ssConectaProveedores;

public partial class Actions {
public class lcvVerifyAnticipoConcept : VarsBag {
public long inParamOrderAccConceptsID;
public decimal inParamImportAnticipo;
public RL_f805dfae1f4ccde9f7b0028b80707abe queryResGetOrderAccConceptById_outParamList = new RL_f805dfae1f4ccde9f7b0028b80707abe();
public long queryResGetOrderAccConceptById_outParamCount = 0L;

public lcvVerifyAnticipoConcept(long inParamOrderAccConceptsID, decimal inParamImportAnticipo) {
this.inParamOrderAccConceptsID = inParamOrderAccConceptsID;
this.inParamImportAnticipo = inParamImportAnticipo;
}
}
public class lcoVerifyAnticipoConcept : VarsBag {
public string outParamErrorMsg = "";

public lcoVerifyAnticipoConcept() {
}
}
/// <summary>
/// Action <code>VerifyAnticipoConcept</code> that represents the Service Studio action
///  <code>VerifyAnticipoConcept</code> <p> Description: </p>
/// </summary>
public static async Task<string> ActionVerifyAnticipoConcept(IRequestContext requestContext,long inParamOrderAccConceptsID,decimal inParamImportAnticipo,CancellationToken cancellationToken) {
string outParamErrorMsg = default;
lcoVerifyAnticipoConcept result = new lcoVerifyAnticipoConcept();
lcvVerifyAnticipoConcept localVars = new lcvVerifyAnticipoConcept(inParamOrderAccConceptsID, inParamImportAnticipo);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("VerifyAnticipoConcept", "52dd262e-b718-4adf-a625-3d9a3eb1a424"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("VerifyAnticipoConcept", "52dd262e-b718-4adf-a625-3d9a3eb1a424", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// no anticipo
if((!((localVars.inParamImportAnticipo<=(((decimal)0)))))) {
// Query datasetGetOrderAccConceptById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderAccConceptById_maxRecords = 1;
if (datasetGetOrderAccConceptById_maxRecords < 1) datasetGetOrderAccConceptById_maxRecords = 1;
int datasetGetOrderAccConceptById_startIndex = 0;(localVars.queryResGetOrderAccConceptById_outParamList,localVars.queryResGetOrderAccConceptById_outParamCount) = await FuncActionVerifyAnticipoConcept.datasetGetOrderAccConceptById(requestContext,datasetGetOrderAccConceptById_maxRecords,datasetGetOrderAccConceptById_startIndex,IterationMultiplicity.Never,localVars.inParamOrderAccConceptsID,cancellationToken);

// ok
if((!((!localVars.queryResGetOrderAccConceptById_outParamList.Empty)))) {
// ErrorMsg = "Concept not allowed while Advanced Import exists"
result.outParamErrorMsg=AppUtils.GetStringResource("eGy2pMHclE27LvARVhF9bw#Value.-1861760251.1", "Concept not allowed while Advanced Import exists");
}

}

} //close CreateActionActivity using block
} // try

finally {
outParamErrorMsg = result.outParamErrorMsg;
} // inner-finally
RETURN_STATEMENT:
return outParamErrorMsg;
}

public static class FuncActionVerifyAnticipoConcept {

// Query Function "GetOrderAccConceptById" tqFR+4YjzUyVtGWlBzc4Ug of Action "VerifyAnticipoConcept"
public static async Task<(RL_f805dfae1f4ccde9f7b0028b80707abe,long)> datasetGetOrderAccConceptById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("VerifyAnticipoConcept.GetOrderAccConceptById", "fb51a1b6-2386-4ccd-95b4-65a507373852");
using var queryActivity = activitySource.CreateAggregateQueryActivity("VerifyAnticipoConcept.GetOrderAccConceptById", "fb51a1b6-2386-4ccd-95b4-65a507373852", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.LibdUhi330qmJT2aPrGkJA/NodesNotShownInESpaceTree.tqFR+4YjzUyVtGWlBzc4Ug, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13");
fromBuilder.Append(" FROM {OrderAccConcepts} \"enorderaccconcepts1\"");
whereBuilder.Append(" WHERE ");
if (qporId != 0) {
whereBuilder.Append("((\"enorderaccconcepts1\".\"id\" = @qporId) AND (\"enorderaccconcepts1\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporId", DbType.Int64, qporId);
} else {
whereBuilder.Append("(\"enorderaccconcepts1\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ((\"enorderaccconcepts1\".\"accountingdatatypeid\" = ");
whereBuilder.Append(1
);
whereBuilder.Append(") OR (\"enorderaccconcepts1\".\"accountingdatatypeid\" = ");
whereBuilder.Append(4
);
whereBuilder.Append("))");
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
RL_f805dfae1f4ccde9f7b0028b80707abe outParamList = new RL_f805dfae1f4ccde9f7b0028b80707abe();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query VerifyAnticipoConcept.GetOrderAccConceptById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_f805dfae1f4ccde9f7b0028b80707abe _tmp = new RL_f805dfae1f4ccde9f7b0028b80707abe();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query VerifyAnticipoConcept.GetOrderAccConceptById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_f805dfae1f4ccde9f7b0028b80707abe)_tmp;
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
