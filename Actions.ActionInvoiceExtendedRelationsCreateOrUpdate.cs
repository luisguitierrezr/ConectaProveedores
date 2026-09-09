namespace ssConectaProveedores;

public partial class Actions {
public class lcvInvoiceExtendedRelationsCreateOrUpdate : VarsBag {
public RL_1801d41568a41cf6282486c389726e17 inParamInvoiceExtendedRelationsList;
public long inParamInvoiceId;
public long resCreateOrUpdateInvoiceExtendedRelations_outParamId = 0L;

public RL_d07e089b14ae41d13cfd90c5313de016 queryResGetInvoiceExtendedRelationsByInvoiceId_outParamList = new RL_d07e089b14ae41d13cfd90c5313de016();
public long queryResGetInvoiceExtendedRelationsByInvoiceId_outParamCount = 0L;

public Actions.lcoInvoiceExtendedRelationCreateOrUpdate resInvoiceExtendedRelationCreateOrUpdate =  new Actions.lcoInvoiceExtendedRelationCreateOrUpdate();
public lcvInvoiceExtendedRelationsCreateOrUpdate(RL_1801d41568a41cf6282486c389726e17 inParamInvoiceExtendedRelationsList, long inParamInvoiceId) {
this.inParamInvoiceExtendedRelationsList = inParamInvoiceExtendedRelationsList;
this.inParamInvoiceId = inParamInvoiceId;
}
}
/// <summary>
/// Action <code>InvoiceExtendedRelationsCreateOrUpdate</code> that represents the Service Studio
///  action <code>InvoiceExtendedRelationsCreateOrUpdate</code> <p> Description: Encapsulates th
/// e CreateOrUpdate entity action, enabling logic to run consistently before and after a record is
///  created or modified.</p>
/// </summary>
public static async Task ActionInvoiceExtendedRelationsCreateOrUpdate(IRequestContext requestContext,RL_1801d41568a41cf6282486c389726e17 inParamInvoiceExtendedRelationsList,long inParamInvoiceId,CancellationToken cancellationToken) {
lcvInvoiceExtendedRelationsCreateOrUpdate localVars = new lcvInvoiceExtendedRelationsCreateOrUpdate(inParamInvoiceExtendedRelationsList, inParamInvoiceId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InvoiceExtendedRelationsCreateOrUpdate", "b617f5b5-829a-42a7-930d-b091b225ff78"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InvoiceExtendedRelationsCreateOrUpdate", "b617f5b5-829a-42a7-930d-b091b225ff78", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetInvoiceExtendedRelationsByInvoiceId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceExtendedRelationsByInvoiceId_maxRecords = 0;
int datasetGetInvoiceExtendedRelationsByInvoiceId_startIndex = 0;(localVars.queryResGetInvoiceExtendedRelationsByInvoiceId_outParamList,localVars.queryResGetInvoiceExtendedRelationsByInvoiceId_outParamCount) = await FuncActionInvoiceExtendedRelationsCreateOrUpdate.datasetGetInvoiceExtendedRelationsByInvoiceId(requestContext,datasetGetInvoiceExtendedRelationsByInvoiceId_maxRecords,datasetGetInvoiceExtendedRelationsByInvoiceId_startIndex,IterationMultiplicity.Single,localVars.inParamInvoiceId,cancellationToken);

// Foreach GetInvoiceExtendedRelationsByInvoiceId.List
localVars.queryResGetInvoiceExtendedRelationsByInvoiceId_outParamList.StartIteration();
try {while (!((localVars.queryResGetInvoiceExtendedRelationsByInvoiceId_outParamList.Eof))) {
// CreateOrUpdateInvoiceExtendedRelations
localVars.resCreateOrUpdateInvoiceExtendedRelations_outParamId = await ExtendedActions.CreateOrUpdateInvoiceExtendedRelations(requestContext,localVars.queryResGetInvoiceExtendedRelationsByInvoiceId_outParamList.CurrentRec.ChangedAttributes,localVars.queryResGetInvoiceExtendedRelationsByInvoiceId_outParamList.CurrentRec,cancellationToken);

localVars.queryResGetInvoiceExtendedRelationsByInvoiceId_outParamList.Advance();
}

} finally {
localVars.queryResGetInvoiceExtendedRelationsByInvoiceId_outParamList.EndIteration();
}

// Foreach InvoiceExtendedRelationsList
localVars.inParamInvoiceExtendedRelationsList.StartIteration();
try {while (!((localVars.inParamInvoiceExtendedRelationsList.Eof))) {
// InvoiceExtendedRelationsList.Current.InvoiceId = InvoiceId
localVars.inParamInvoiceExtendedRelationsList.CurrentRec.ssInvoiceId = localVars.inParamInvoiceId;
// InvoiceExtendedRelationCreateOrUpdate
localVars.resInvoiceExtendedRelationCreateOrUpdate.outParamId = await Actions.ActionInvoiceExtendedRelationCreateOrUpdate(requestContext,localVars.inParamInvoiceExtendedRelationsList.CurrentRec,cancellationToken);

localVars.inParamInvoiceExtendedRelationsList.Advance();
}

} finally {
localVars.inParamInvoiceExtendedRelationsList.EndIteration();
}

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionInvoiceExtendedRelationsCreateOrUpdate {

// Query Function "GetInvoiceExtendedRelationsByInvoiceId" 3dxBnKQDPUSCYhpM9WZMdw of Action "InvoiceExtendedRelationsCreateOrUpdate"
public static async Task<(RL_d07e089b14ae41d13cfd90c5313de016,long)> datasetGetInvoiceExtendedRelationsByInvoiceId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvoiceExtendedRelationsCreateOrUpdate.GetInvoiceExtendedRelationsByInvoiceId", "9c41dcdd-03a4-443d-8262-1a4cf5664c77");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvoiceExtendedRelationsCreateOrUpdate.GetInvoiceExtendedRelationsByInvoiceId", "9c41dcdd-03a4-443d-8262-1a4cf5664c77", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.tfUXtpqCp0KTDbCRsiX_eA/NodesNotShownInESpaceTree.3dxBnKQDPUSCYhpM9WZMdw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoiceextendedrelations\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4");
fromBuilder.Append(" FROM {InvoiceExtendedRelations} \"eninvoiceextendedrelations\"");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceId != 0) {
whereBuilder.Append("((\"eninvoiceextendedrelations\".\"invoiceid\" = @qpinInvoiceId) AND (\"eninvoiceextendedrelations\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceId", DbType.Int64, qpinInvoiceId);
} else {
whereBuilder.Append("(\"eninvoiceextendedrelations\".\"invoiceid\" IS NULL)");
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
RL_d07e089b14ae41d13cfd90c5313de016 outParamList = new RL_d07e089b14ae41d13cfd90c5313de016();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvoiceExtendedRelationsCreateOrUpdate.GetInvoiceExtendedRelationsByInvoiceId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_d07e089b14ae41d13cfd90c5313de016 _tmp = new RL_d07e089b14ae41d13cfd90c5313de016();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvoiceExtendedRelationsCreateOrUpdate.GetInvoiceExtendedRelationsByInvoiceId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_d07e089b14ae41d13cfd90c5313de016)_tmp;
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
