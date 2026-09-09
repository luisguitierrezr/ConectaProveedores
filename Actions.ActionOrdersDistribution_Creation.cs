namespace ssConectaProveedores;

public partial class Actions {
public class lcvOrdersDistribution_Creation : VarsBag {
public long inParamOrdersImportRequestId;
public RL_96ceba485e5175415cee03a11e0c33fb queryResGetOrders_outParamList = new RL_96ceba485e5175415cee03a11e0c33fb();
public long queryResGetOrders_outParamCount = 0L;

public RL_44cb753cf22fd0b01aa78a5ab2f30079 queryResGetRequestDistributionConfigs_outParamList = new RL_44cb753cf22fd0b01aa78a5ab2f30079();
public long queryResGetRequestDistributionConfigs_outParamCount = 0L;

public lcvOrdersDistribution_Creation(long inParamOrdersImportRequestId) {
this.inParamOrdersImportRequestId = inParamOrdersImportRequestId;
}
}
/// <summary>
/// Action <code>OrdersDistribution_Creation</code> that represents the Service Studio action
///  <code>OrdersDistribution_Creation</code> <p> Description: </p>
/// </summary>
public static async Task ActionOrdersDistribution_Creation(IRequestContext requestContext,long inParamOrdersImportRequestId,CancellationToken cancellationToken) {
lcvOrdersDistribution_Creation localVars = new lcvOrdersDistribution_Creation(inParamOrdersImportRequestId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("OrdersDistribution_Creation", "0fb676f2-a086-45f3-91e7-d0beddca87f8"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("OrdersDistribution_Creation", "0fb676f2-a086-45f3-91e7-d0beddca87f8", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetOrders
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrders_maxRecords = 100;
if (datasetGetOrders_maxRecords < 1) datasetGetOrders_maxRecords = 1;
int datasetGetOrders_startIndex = 0;(localVars.queryResGetOrders_outParamList,localVars.queryResGetOrders_outParamCount) = await FuncActionOrdersDistribution_Creation.datasetGetOrders(requestContext,datasetGetOrders_maxRecords,datasetGetOrders_startIndex,IterationMultiplicity.Multiple,localVars.inParamOrdersImportRequestId,cancellationToken);

// Query datasetGetRequestDistributionConfigs
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequestDistributionConfigs_maxRecords = 0;
int datasetGetRequestDistributionConfigs_startIndex = 0;(localVars.queryResGetRequestDistributionConfigs_outParamList,localVars.queryResGetRequestDistributionConfigs_outParamCount) = await FuncActionOrdersDistribution_Creation.datasetGetRequestDistributionConfigs(requestContext,datasetGetRequestDistributionConfigs_maxRecords,datasetGetRequestDistributionConfigs_startIndex,IterationMultiplicity.Multiple,cancellationToken);

// ControledLogMessage
await Actions.ActionControledLogMessage(requestContext,((((bool)AppUtils.SiteProperties[SitePropertiesModel.spOrdersImportLog_IsActive]))),("OrdersDistribution_Creation »  Automatic Distribution Started » Orders to treat: "+Convert.ToString(localVars.queryResGetOrders_outParamList.Length)),"OrdersDistribution_Creation",cancellationToken);

// Foreach GetOrders.List
localVars.queryResGetOrders_outParamList.StartIteration();
try {while (!((localVars.queryResGetOrders_outParamList.Eof))) {
// OrdersDistribution_CreationByOrder
await Actions.ActionOrdersDistribution_CreationByOrder(requestContext,localVars.queryResGetOrders_outParamList.CurrentRec.ssENOrdersImportRequest,(await RL_9f98927ca09897763d4f4dec24a42220.ConvertAsync(localVars.queryResGetRequestDistributionConfigs_outParamList, new RL_9f98927ca09897763d4f4dec24a42220(), async (RC_9fc59bda41db740ae87f91f135d24811 source, EN_4ad0cdb13562998fda111463f2af9c31EntityRecord target, CancellationToken cancellationToken) => {
target = source;
return target;
}, cancellationToken)),localVars.queryResGetOrders_outParamList.CurrentRec.ssENOrderMain.ssId,localVars.queryResGetOrders_outParamList.CurrentRec.ssENOrderMain.ssOrderNumber,localVars.queryResGetOrders_outParamList.CurrentRec.ssENOrderMain.ssRegionId,localVars.queryResGetOrders_outParamList.CurrentRec.ssENOrderMain.ssApplicant,cancellationToken);

localVars.queryResGetOrders_outParamList.Advance();
}

} finally {
localVars.queryResGetOrders_outParamList.EndIteration();
}

// WakeTimerOrdersDistribution_SendEmails
await ExtendedActions.WakeTimerOrdersDistribution_SendEmails(requestContext,cancellationToken);

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionOrdersDistribution_Creation {

private static async Task<RC_0ac0129639ce616349f284f107640b9e> datasetGetOrdersReadDbAsync(RC_0ac0129639ce616349f284f107640b9e rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENDivision.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssENOrdersImportRequest.Read( r, ref index);
rec.ssENOrderStatus.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENTelcelDirection.Read( r, ref index);
return rec;
}
// Query Function "GetOrders" LiWuKE0sC0u3ufRIX8dSOA of Action "OrdersDistribution_Creation"
public static async Task<(RL_96ceba485e5175415cee03a11e0c33fb,long)> datasetGetOrders(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrdersImportRequest_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("OrdersDistribution_Creation.GetOrders", "28ae252e-2c4d-4b0b-b7b9-f4485fc75238");
using var queryActivity = activitySource.CreateAggregateQueryActivity("OrdersDistribution_Creation.GetOrders", "28ae252e-2c4d-4b0b-b7b9-f4485fc75238", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.8na2D4ag80WR59C+3cqH+A/NodesNotShownInESpaceTree.LiWuKE0sC0u3ufRIX8dSOA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, \"enordermain2\".\"id\" o13, \"enordermain2\".\"ordernumber\" o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, \"enordermain2\".\"regionid\" o35, NULL o36, \"enordermain2\".\"applicant\" o37, NULL o38, NULL o39, NULL o40, NULL o41, \"enordersimportrequest\".\"id\" o42, \"enordersimportrequest\".\"origin\" o43, \"enordersimportrequest\".\"importeddata\" o44, \"enordersimportrequest\".\"ordermainid\" o45, \"enordersimportrequest\".\"status\" o46, \"enordersimportrequest\".\"lastrownumberread\" o47, \"enordersimportrequest\".\"rowswitherror\" o48, \"enordersimportrequest\".\"createdby\" o49, \"enordersimportrequest\".\"createdon\" o50, \"enordersimportrequest\".\"updatedon\" o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77");
fromBuilder.Append(" FROM ((((({OrdersImportRequest} \"enordersimportrequest\" Inner JOIN {OrderMain} \"enordermain2\" ON (\"enordersimportrequest\".\"ordermainid\" = \"enordermain2\".\"id\"))  Left JOIN {OrderStatus} \"enorderstatus\" ON (\"enordermain2\".\"orderstatusid\" = \"enorderstatus\".\"id\"))  Left JOIN {Region} \"enregion3\" ON (\"enregion3\".\"id\" = \"enordermain2\".\"regionid\"))  Left JOIN {Region} \"endivision\" ON (\"enordermain2\".\"divisionid\" = \"endivision\".\"id\"))  Left JOIN {TelcelDirection} \"entelceldirection1\" ON (\"enordermain2\".\"telceldirectionid\" = \"entelceldirection1\".\"id\")) ");
whereBuilder.Append(" WHERE (\"enordermain2\".\"orderstatusid\" = ");
whereBuilder.Append((ENOrderStatusEntity.GetRecordByKey(ObjectKey.Parse("BHvVtSdSlUixsh+41KTCZg"))).ssId);
whereBuilder.Append(") AND ");
if (qporOrdersImportRequest_Id != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qporOrdersImportRequest_Id != 0) {
whereBuilder.Append("((\"enordersimportrequest\".\"id\" = @qporOrdersImportRequest_Id) AND (\"enordersimportrequest\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrdersImportRequest_Id", DbType.Int64, qporOrdersImportRequest_Id);
} else {
whereBuilder.Append("(\"enordersimportrequest\".\"id\" IS NULL)");
}
}
string whereBuilderString = whereBuilder.ToString();
if (whereBuilderString.EndsWith(" AND ")) {
whereBuilder.Remove(whereBuilderString.Length - 5, 5);
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
RL_96ceba485e5175415cee03a11e0c33fb outParamList = new RL_96ceba485e5175415cee03a11e0c33fb();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrdersReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[6];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false});
opt[2] = new BitArray(new bool[] {false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, false, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query OrdersDistribution_Creation.GetOrders.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_96ceba485e5175415cee03a11e0c33fb _tmp = new RL_96ceba485e5175415cee03a11e0c33fb();
_tmp.AlternateReadDbMethodAsync = datasetGetOrdersReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query OrdersDistribution_Creation.GetOrders.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_96ceba485e5175415cee03a11e0c33fb)_tmp;
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

// Query Function "GetRequestDistributionConfigs" yN1mdQRcPE2SvUrMY6Kh7Q of Action "OrdersDistribution_Creation"
public static async Task<(RL_44cb753cf22fd0b01aa78a5ab2f30079,long)> datasetGetRequestDistributionConfigs(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("OrdersDistribution_Creation.GetRequestDistributionConfigs", "7566ddc8-5c04-4d3c-92bd-4acc63a2a1ed");
using var queryActivity = activitySource.CreateAggregateQueryActivity("OrdersDistribution_Creation.GetRequestDistributionConfigs", "7566ddc8-5c04-4d3c-92bd-4acc63a2a1ed", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.8na2D4ag80WR59C+3cqH+A/NodesNotShownInESpaceTree.yN1mdQRcPE2SvUrMY6Kh7Q, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enorderdistributionconfig\".\"id\" o0, \"enorderdistributionconfig\".\"regionid\" o1, \"enorderdistributionconfig\".\"applicant\" o2, \"enorderdistributionconfig\".\"applicantdescription\" o3, \"enorderdistributionconfig\".\"directionid\" o4, \"enorderdistributionconfig\".\"firstcontact_entraroleid\" o5, \"enorderdistributionconfig\".\"secondcontact_entraroleid\" o6, \"enorderdistributionconfig\".\"firstapprover_entraroleid\" o7, \"enorderdistributionconfig\".\"secondapprover_entraroleid\" o8, \"enorderdistributionconfig\".\"createdby\" o9, \"enorderdistributionconfig\".\"createdon\" o10, \"enorderdistributionconfig\".\"updatedby\" o11, \"enorderdistributionconfig\".\"updatedon\" o12");
fromBuilder.Append(" FROM {OrderDistributionConfig} \"enorderdistributionconfig\"");
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
RL_44cb753cf22fd0b01aa78a5ab2f30079 outParamList = new RL_44cb753cf22fd0b01aa78a5ab2f30079();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query OrdersDistribution_Creation.GetRequestDistributionConfigs.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_44cb753cf22fd0b01aa78a5ab2f30079 _tmp = new RL_44cb753cf22fd0b01aa78a5ab2f30079();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query OrdersDistribution_Creation.GetRequestDistributionConfigs.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_44cb753cf22fd0b01aa78a5ab2f30079)_tmp;
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
