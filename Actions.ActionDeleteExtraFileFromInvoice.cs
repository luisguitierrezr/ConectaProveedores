namespace ssConectaProveedores;

public partial class Actions {
public class lcvDeleteExtraFileFromInvoice : VarsBag {
public long inParami_invoicefileId;
public RL_00a03f803f0d49826089181417370afb queryResGetInvoiceFileById_outParamList = new RL_00a03f803f0d49826089181417370afb();
public long queryResGetInvoiceFileById_outParamCount = 0L;

public lcvDeleteExtraFileFromInvoice(long inParami_invoicefileId) {
this.inParami_invoicefileId = inParami_invoicefileId;
}
}
/// <summary>
/// Action <code>DeleteExtraFileFromInvoice</code> that represents the Service Studio action
///  <code>DeleteExtraFileFromInvoice</code> <p> Description: </p>
/// </summary>
public static async Task ActionDeleteExtraFileFromInvoice(IRequestContext requestContext,long inParami_invoicefileId,CancellationToken cancellationToken) {
lcvDeleteExtraFileFromInvoice localVars = new lcvDeleteExtraFileFromInvoice(inParami_invoicefileId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("DeleteExtraFileFromInvoice", "db67885b-bbbb-404e-9355-c022b109eea6"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("DeleteExtraFileFromInvoice", "db67885b-bbbb-404e-9355-c022b109eea6", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetInvoiceFileById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceFileById_maxRecords = 0;
int datasetGetInvoiceFileById_startIndex = 0;(localVars.queryResGetInvoiceFileById_outParamList,localVars.queryResGetInvoiceFileById_outParamCount) = await FuncActionDeleteExtraFileFromInvoice.datasetGetInvoiceFileById(requestContext,datasetGetInvoiceFileById_maxRecords,datasetGetInvoiceFileById_startIndex,IterationMultiplicity.Never,localVars.inParami_invoicefileId,cancellationToken);

// Is Extra?
if((localVars.queryResGetInvoiceFileById_outParamList.CurrentRec.ssENInvoiceFile.ssIsExtra)) {
// ServiceStorageDelete
await ServiceAPIs.ServiceAPIServiceStorageDelete(requestContext,localVars.queryResGetInvoiceFileById_outParamList.CurrentRec.ssENInvoiceFile.ssStorageId,cancellationToken);

// DeleteInvoiceFile
await ExtendedActions.DeleteInvoiceFile(requestContext,localVars.inParami_invoicefileId,cancellationToken);

} else {
// RaiseError EntityException
throw new Ex_EntityExceptionUserException (AppUtils.GetStringResource("DrJFOJfLpEKzm+y1yNk5_Q#Message.375691431.1", "Cannot delete Invoice File"));

}

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionDeleteExtraFileFromInvoice {

// Query Function "GetInvoiceFileById" NBmfx5hi9karQVuHsAE9vg of Action "DeleteExtraFileFromInvoice"
public static async Task<(RL_00a03f803f0d49826089181417370afb,long)> datasetGetInvoiceFileById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("DeleteExtraFileFromInvoice.GetInvoiceFileById", "c79f1934-6298-46f6-ab41-5b87b0013dbe");
using var queryActivity = activitySource.CreateAggregateQueryActivity("DeleteExtraFileFromInvoice.GetInvoiceFileById", "c79f1934-6298-46f6-ab41-5b87b0013dbe", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.W4hn27u7TkCTVcAisQnupg/NodesNotShownInESpaceTree.NBmfx5hi9karQVuHsAE9vg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, \"eninvoicefile24\".\"isextra\" o3, NULL o4, \"eninvoicefile24\".\"storageid\" o5, NULL o6, NULL o7");
fromBuilder.Append(" FROM {InvoiceFile} \"eninvoicefile24\"");
whereBuilder.Append(" WHERE ");
if (qpinId != 0) {
whereBuilder.Append("((\"eninvoicefile24\".\"id\" = @qpinId) AND (\"eninvoicefile24\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinId", DbType.Int64, qpinId);
} else {
whereBuilder.Append("(\"eninvoicefile24\".\"id\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"eninvoicefile24\".\"filename\" ASC ");
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
RL_00a03f803f0d49826089181417370afb outParamList = new RL_00a03f803f0d49826089181417370afb();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, false, true, false, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query DeleteExtraFileFromInvoice.GetInvoiceFileById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_00a03f803f0d49826089181417370afb _tmp = new RL_00a03f803f0d49826089181417370afb();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query DeleteExtraFileFromInvoice.GetInvoiceFileById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_00a03f803f0d49826089181417370afb)_tmp;
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
