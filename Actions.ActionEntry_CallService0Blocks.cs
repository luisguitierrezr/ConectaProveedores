namespace ssConectaProveedores;

public partial class Actions {
public class lcvEntry_CallService0Blocks : VarsBag {
public string inParamImputationCode;
public long inParamGLAccountId;
public int inParamOffsetUtc;
/// <summary>
/// Variable <code>Date</code> that represents the Service Studio Date <code>Date</code>
///  <p>Description: </p>
/// </summary>
public DateTime varLcDate = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);

public RL_da67905e31707902c7c69f546185ad6c queryResGetEntryBlockDatesByImputationCode_outParamList = new RL_da67905e31707902c7c69f546185ad6c();
public long queryResGetEntryBlockDatesByImputationCode_outParamCount = 0L;

public lcvEntry_CallService0Blocks(string inParamImputationCode, long inParamGLAccountId, int inParamOffsetUtc) {
this.inParamImputationCode = inParamImputationCode;
this.inParamGLAccountId = inParamGLAccountId;
this.inParamOffsetUtc = inParamOffsetUtc;
}
}
public class lcoEntry_CallService0Blocks : VarsBag {
public bool outParamIsBlocked = false;

public lcoEntry_CallService0Blocks() {
}
}
/// <summary>
/// Action <code>Entry_CallService0Blocks</code> that represents the Service Studio action
///  <code>Entry_CallService0Blocks</code> <p> Description: </p>
/// </summary>
public static async Task<bool> ActionEntry_CallService0Blocks(IRequestContext requestContext,string inParamImputationCode,long inParamGLAccountId,int inParamOffsetUtc,CancellationToken cancellationToken) {
bool outParamIsBlocked = default;
lcoEntry_CallService0Blocks result = new lcoEntry_CallService0Blocks();
lcvEntry_CallService0Blocks localVars = new lcvEntry_CallService0Blocks(inParamImputationCode, inParamGLAccountId, inParamOffsetUtc);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("Entry_CallService0Blocks", "893c82c1-233c-41dc-922a-8494ebf51240"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("Entry_CallService0Blocks", "893c82c1-233c-41dc-922a-8494ebf51240", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Date = UTCToLocalTime(CurrDateTime, OffsetUtc)
localVars.varLcDate=BuiltInFunction.DateTimeToDate((await Functions.ActionUTCToLocalTime(requestContext,BuiltInFunction.CurrDateTime (),localVars.inParamOffsetUtc,cancellationToken)));
// Query datasetGetEntryBlockDatesByImputationCode
cancellationToken.ThrowIfCancellationRequested();
int datasetGetEntryBlockDatesByImputationCode_maxRecords = 1;
if (datasetGetEntryBlockDatesByImputationCode_maxRecords < 1) datasetGetEntryBlockDatesByImputationCode_maxRecords = 1;
int datasetGetEntryBlockDatesByImputationCode_startIndex = 0;(localVars.queryResGetEntryBlockDatesByImputationCode_outParamList,localVars.queryResGetEntryBlockDatesByImputationCode_outParamCount) = await FuncActionEntry_CallService0Blocks.datasetGetEntryBlockDatesByImputationCode(requestContext,datasetGetEntryBlockDatesByImputationCode_maxRecords,datasetGetEntryBlockDatesByImputationCode_startIndex,IterationMultiplicity.Never,localVars.varLcDate,localVars.inParamGLAccountId,localVars.inParamImputationCode,cancellationToken);

// IsBlocked = notGetEntryBlockDatesByImputationCode.List.Empty or IsActiveForceBlock
result.outParamIsBlocked=((!localVars.queryResGetEntryBlockDatesByImputationCode_outParamList.Empty)||((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveForceBlock]))));
} //close CreateActionActivity using block
} // try

finally {
outParamIsBlocked = result.outParamIsBlocked;
} // inner-finally
RETURN_STATEMENT:
return outParamIsBlocked;
}

public static class FuncActionEntry_CallService0Blocks {

private static async Task<RC_286d2bb37686f509eeb33164e8470439> datasetGetEntryBlockDatesByImputationCodeReadDbAsync(RC_286d2bb37686f509eeb33164e8470439 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENAccountingAccounts_ServiceType.Read( r, ref index);
rec.ssENEntryBlockDates.Read( r, ref index);
return rec;
}
// Query Function "GetEntryBlockDatesByImputationCode" 5FuB773EP0qvstu_IDd2Lg of Action "Entry_CallService0Blocks"
public static async Task<(RL_da67905e31707902c7c69f546185ad6c,long)> datasetGetEntryBlockDatesByImputationCode(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,DateTime qpdaDate,long qpacEntryBlockDates_GLAccountsId,string qpteEntryBlockDates_ImputationCode,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("Entry_CallService0Blocks.GetEntryBlockDatesByImputationCode", "ef815be4-c4bd-4a3f-afb2-dbbf2037762e");
using var queryActivity = activitySource.CreateAggregateQueryActivity("Entry_CallService0Blocks.GetEntryBlockDatesByImputationCode", "ef815be4-c4bd-4a3f-afb2-dbbf2037762e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.wYI8iTwj3EGSKoSU6_USQA/NodesNotShownInESpaceTree.5FuB773EP0qvstu_IDd2Lg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17");
fromBuilder.Append(" FROM ({EntryBlockDates} \"enentryblockdates\" Left JOIN {AccountingAccounts_ServiceType} \"enaccountingaccounts_servicetype2\" ON (\"enentryblockdates\".\"glaccountsid\" = \"enaccountingaccounts_servicetype2\".\"id\")) ");
whereBuilder.Append(" WHERE ((@qpdaDate::date >= \"enentryblockdates\".\"initialdate\"::date) AND (@qpdaDate::date <= \"enentryblockdates\".\"endingdate\"::date)) AND (\"enentryblockdates\".\"imputationcode\" = @qpteEntryBlockDates_ImputationCode) AND ((");
sqlCmd.CreateParameterWithoutReplacements("@qpdaDate", DbType.DateTime, qpdaDate);
sqlCmd.CreateParameterWithoutReplacements("@qpteEntryBlockDates_ImputationCode", DbType.String, qpteEntryBlockDates_ImputationCode);
if (qpacEntryBlockDates_GLAccountsId != 0) {
whereBuilder.Append("((\"enentryblockdates\".\"glaccountsid\" = @qpacEntryBlockDates_GLAccountsId) AND (\"enentryblockdates\".\"glaccountsid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpacEntryBlockDates_GLAccountsId", DbType.Int64, qpacEntryBlockDates_GLAccountsId);
} else {
whereBuilder.Append("(\"enentryblockdates\".\"glaccountsid\" IS NULL)");
}
whereBuilder.Append(" OR (\"enentryblockdates\".\"glaccountsid\" IS NULL)) OR ((trim(\"enaccountingaccounts_servicetype2\".\"cc\")) = '')) AND (\"enentryblockdates\".\"isactive\" = 1)");
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
RL_da67905e31707902c7c69f546185ad6c outParamList = new RL_da67905e31707902c7c69f546185ad6c();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetEntryBlockDatesByImputationCodeReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query Entry_CallService0Blocks.GetEntryBlockDatesByImputationCode.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_da67905e31707902c7c69f546185ad6c _tmp = new RL_da67905e31707902c7c69f546185ad6c();
_tmp.AlternateReadDbMethodAsync = datasetGetEntryBlockDatesByImputationCodeReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query Entry_CallService0Blocks.GetEntryBlockDatesByImputationCode.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_da67905e31707902c7c69f546185ad6c)_tmp;
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
