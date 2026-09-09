namespace ssConectaProveedores;

public partial class Actions {
public class lcvFolioResendEntry : VarsBag {
public long inParami_FolioId;
public int inParamOffsetUtc;
public RL_4f8b259bdd04db22be8fb771f1ad1d4f queryResGetFolioById_outParamList = new RL_4f8b259bdd04db22be8fb771f1ad1d4f();
public long queryResGetFolioById_outParamCount = 0L;

public Actions.lcoCallEntryAccountingFolio resCallEntryAccountingFolio =  new Actions.lcoCallEntryAccountingFolio();
public lcvFolioResendEntry(long inParami_FolioId, int inParamOffsetUtc) {
this.inParami_FolioId = inParami_FolioId;
this.inParamOffsetUtc = inParamOffsetUtc;
}
}
public class lcoFolioResendEntry : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public lcoFolioResendEntry() {
}
}
/// <summary>
/// Action <code>FolioResendEntry</code> that represents the Service Studio action
///  <code>FolioResendEntry</code> <p> Description: Action to Resend Entry Folio.</p>
/// </summary>
public static async Task<ST_046fb53ebbe142526d95e87ef1ae9711Structure> ActionFolioResendEntry(IRequestContext requestContext,long inParami_FolioId,int inParamOffsetUtc,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
lcoFolioResendEntry result = new lcoFolioResendEntry();
lcvFolioResendEntry localVars = new lcvFolioResendEntry(inParami_FolioId, inParamOffsetUtc);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("FolioResendEntry", "436de443-df4f-49a2-a1d5-33a9f6a22cf5"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("FolioResendEntry", "436de443-df4f-49a2-a1d5-33a9f6a22cf5", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetFolioById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioById_maxRecords = 0;
int datasetGetFolioById_startIndex = 0;(localVars.queryResGetFolioById_outParamList,localVars.queryResGetFolioById_outParamCount) = await FuncActionFolioResendEntry.datasetGetFolioById(requestContext,datasetGetFolioById_maxRecords,datasetGetFolioById_startIndex,IterationMultiplicity.Never,localVars.inParami_FolioId,cancellationToken);

// Empty?
if((localVars.queryResGetFolioById_outParamList.Empty)) {
// o_Output
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "Folio not found!"
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("A2U4IxzqiE2eVk2oAG3Tpw#Value.1482511939.1", "Folio not found!");
} else {
// CallEntryAccountingFolio
localVars.resCallEntryAccountingFolio.outParamo_Output = await Actions.ActionCallEntryAccountingFolio(requestContext,localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio,true,localVars.inParamOffsetUtc,cancellationToken);

// o_Output = CallEntryAccountingFolio.o_Output
result.outParamo_Output=localVars.resCallEntryAccountingFolio.outParamo_Output;
}

} //close CreateActionActivity using block
} // try

finally {
outParamo_Output = result.outParamo_Output;
} // inner-finally
RETURN_STATEMENT:
return outParamo_Output;
}

public static class FuncActionFolioResendEntry {

// Query Function "GetFolioById" O16ZQH_PwUK7Ks5nZq9lxg of Action "FolioResendEntry"
public static async Task<(RL_4f8b259bdd04db22be8fb771f1ad1d4f,long)> datasetGetFolioById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("FolioResendEntry.GetFolioById", "40995e3b-cf7f-42c1-bb2a-ce6766af65c6");
using var queryActivity = activitySource.CreateAggregateQueryActivity("FolioResendEntry.GetFolioById", "40995e3b-cf7f-42c1-bb2a-ce6766af65c6", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.Q+RtQ0_fokmh1TOp9qIs9Q/NodesNotShownInESpaceTree.O16ZQH_PwUK7Ks5nZq9lxg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enfolio11\".\"id\" o0, \"enfolio11\".\"isdraft\" o1, \"enfolio11\".\"folionumber\" o2, \"enfolio11\".\"canproveedorcancel\" o3, \"enfolio11\".\"orderid\" o4, \"enfolio11\".\"supplierid\" o5, \"enfolio11\".\"companyid\" o6, \"enfolio11\".\"foliostatusid\" o7, trim_scale(\"enfolio11\".\"totalamount\"::numeric) o8, trim_scale(\"enfolio11\".\"totaliva_amount\"::numeric) o9, trim_scale(\"enfolio11\".\"partialamount\"::numeric) o10, \"enfolio11\".\"currencyid\" o11, \"enfolio11\".\"firstapproveruserid\" o12, \"enfolio11\".\"approvalprocesstypeid\" o13, \"enfolio11\".\"sapentryerror\" o14, \"enfolio11\".\"createdby\" o15, \"enfolio11\".\"createdon\" o16, \"enfolio11\".\"updatedby\" o17, \"enfolio11\".\"updatedon\" o18, \"enfolio11\".\"minuteselected\" o19");
fromBuilder.Append(" FROM {Folio} \"enfolio11\"");
whereBuilder.Append(" WHERE ");
if (qpfoId != 0) {
whereBuilder.Append("((\"enfolio11\".\"id\" = @qpfoId) AND (\"enfolio11\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoId", DbType.Int64, qpfoId);
} else {
whereBuilder.Append("(\"enfolio11\".\"id\" IS NULL)");
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
RL_4f8b259bdd04db22be8fb771f1ad1d4f outParamList = new RL_4f8b259bdd04db22be8fb771f1ad1d4f();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query FolioResendEntry.GetFolioById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_4f8b259bdd04db22be8fb771f1ad1d4f _tmp = new RL_4f8b259bdd04db22be8fb771f1ad1d4f();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query FolioResendEntry.GetFolioById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_4f8b259bdd04db22be8fb771f1ad1d4f)_tmp;
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
