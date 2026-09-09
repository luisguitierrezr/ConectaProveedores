namespace ssConectaProveedores;

public partial class Actions {
public class lcvGetCustomSettingsAccounting : VarsBag {
public bool inParamIsBigger;
/// <summary>
/// Variable <code>CustomSettingDB_CR_IND</code> that represents the Service Studio
///  CustomSettingsIdentifier <code>CustomSettingDB_CR_IND</code> <p>Description: </p>
/// </summary>
public int varLcCustomSettingDB_CR_IND = 0;

/// <summary>
/// Variable <code>CustomSettingGL_ACCOUNT</code> that represents the Service Studio
///  CustomSettingsIdentifier <code>CustomSettingGL_ACCOUNT</code> <p>Description: </p>
/// </summary>
public int varLcCustomSettingGL_ACCOUNT = 0;

public RL_78f7eb5628c10c7f234959bf22490881 queryResGetCustomSettingValues_DB_CR_IND_outParamList = new RL_78f7eb5628c10c7f234959bf22490881();
public long queryResGetCustomSettingValues_DB_CR_IND_outParamCount = 0L;

public RL_78f7eb5628c10c7f234959bf22490881 queryResGetCustomSettingValue_GL_ACCOUNT_outParamList = new RL_78f7eb5628c10c7f234959bf22490881();
public long queryResGetCustomSettingValue_GL_ACCOUNT_outParamCount = 0L;

public lcvGetCustomSettingsAccounting(bool inParamIsBigger) {
this.inParamIsBigger = inParamIsBigger;
}
}
public class lcoGetCustomSettingsAccounting : VarsBag {
public string outParamPI_DR_CB_IND = "";

public string outParamPI_GL_ACCOUNT = "";

public lcoGetCustomSettingsAccounting() {
}
}
/// <summary>
/// Action <code>GetCustomSettingsAccounting</code> that represents the Service Studio action
///  <code>GetCustomSettingsAccounting</code> <p> Description: </p>
/// </summary>
public static async Task<(string,string)> ActionGetCustomSettingsAccounting(IRequestContext requestContext,bool inParamIsBigger,CancellationToken cancellationToken) {
string outParamPI_DR_CB_IND = default;
string outParamPI_GL_ACCOUNT = default;
lcoGetCustomSettingsAccounting result = new lcoGetCustomSettingsAccounting();
lcvGetCustomSettingsAccounting localVars = new lcvGetCustomSettingsAccounting(inParamIsBigger);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GetCustomSettingsAccounting", "c653c857-8e68-4623-926c-6bb0449b5a17"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetCustomSettingsAccounting", "c653c857-8e68-4623-926c-6bb0449b5a17", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
if((localVars.inParamIsBigger)) {
// CustomSettingDB_CR_IND = AccountingIndicatorDBCRBigger
localVars.varLcCustomSettingDB_CR_IND=7;

// CustomSettingGL_ACCOUNT = AccountingGLAccountBigger
localVars.varLcCustomSettingGL_ACCOUNT=9;
} else {
// CustomSettingDB_CR_IND = AccountingIndicatorDBCRSmaller
localVars.varLcCustomSettingDB_CR_IND=8;

// CustomSettingGL_ACCOUNT = AccountingGLAccountSmaller
localVars.varLcCustomSettingGL_ACCOUNT=10;
}

// Query datasetGetCustomSettingValues_DB_CR_IND
cancellationToken.ThrowIfCancellationRequested();
int datasetGetCustomSettingValues_DB_CR_IND_maxRecords = 1;
if (datasetGetCustomSettingValues_DB_CR_IND_maxRecords < 1) datasetGetCustomSettingValues_DB_CR_IND_maxRecords = 1;
int datasetGetCustomSettingValues_DB_CR_IND_startIndex = 0;(localVars.queryResGetCustomSettingValues_DB_CR_IND_outParamList,localVars.queryResGetCustomSettingValues_DB_CR_IND_outParamCount) = await FuncActionGetCustomSettingsAccounting.datasetGetCustomSettingValues_DB_CR_IND(requestContext,datasetGetCustomSettingValues_DB_CR_IND_maxRecords,datasetGetCustomSettingValues_DB_CR_IND_startIndex,IterationMultiplicity.Never,localVars.varLcCustomSettingDB_CR_IND,cancellationToken);

// Query datasetGetCustomSettingValue_GL_ACCOUNT
cancellationToken.ThrowIfCancellationRequested();
int datasetGetCustomSettingValue_GL_ACCOUNT_maxRecords = 1;
if (datasetGetCustomSettingValue_GL_ACCOUNT_maxRecords < 1) datasetGetCustomSettingValue_GL_ACCOUNT_maxRecords = 1;
int datasetGetCustomSettingValue_GL_ACCOUNT_startIndex = 0;(localVars.queryResGetCustomSettingValue_GL_ACCOUNT_outParamList,localVars.queryResGetCustomSettingValue_GL_ACCOUNT_outParamCount) = await FuncActionGetCustomSettingsAccounting.datasetGetCustomSettingValue_GL_ACCOUNT(requestContext,datasetGetCustomSettingValue_GL_ACCOUNT_maxRecords,datasetGetCustomSettingValue_GL_ACCOUNT_startIndex,IterationMultiplicity.Never,localVars.varLcCustomSettingGL_ACCOUNT,cancellationToken);

// PI_DR_CB_IND = GetCustomSettingValues_DB_CR_IND.List.Current.CustomSettingValue.Value
result.outParamPI_DR_CB_IND=localVars.queryResGetCustomSettingValues_DB_CR_IND_outParamList.CurrentRec.ssENCustomSettingValue.ssValue;

// PI_GL_ACCOUNT = GetCustomSettingValue_GL_ACCOUNT.List.Current.CustomSettingValue.Value
result.outParamPI_GL_ACCOUNT=localVars.queryResGetCustomSettingValue_GL_ACCOUNT_outParamList.CurrentRec.ssENCustomSettingValue.ssValue;
} //close CreateActionActivity using block
} // try

finally {
outParamPI_DR_CB_IND = result.outParamPI_DR_CB_IND;
outParamPI_GL_ACCOUNT = result.outParamPI_GL_ACCOUNT;
} // inner-finally
RETURN_STATEMENT:
return (outParamPI_DR_CB_IND,outParamPI_GL_ACCOUNT);
}

public static class FuncActionGetCustomSettingsAccounting {

// Query Function "GetCustomSettingValues_DB_CR_IND" jIIdnrSNo0qiAs5S7dhOtQ of Action "GetCustomSettingsAccounting"
public static async Task<(RL_78f7eb5628c10c7f234959bf22490881,long)> datasetGetCustomSettingValues_DB_CR_IND(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,int qpcuCustomSettingId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetCustomSettingsAccounting.GetCustomSettingValues_DB_CR_IND", "9e1d828c-8db4-4aa3-a202-ce52edd84eb5");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetCustomSettingsAccounting.GetCustomSettingValues_DB_CR_IND", "9e1d828c-8db4-4aa3-a202-ce52edd84eb5", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.V8hTxmiOI0aSbGuwRJtaFw/NodesNotShownInESpaceTree.jIIdnrSNo0qiAs5S7dhOtQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"encustomsettingvalue\".\"value\" o2, NULL o3, NULL o4");
fromBuilder.Append(" FROM {CustomSettingValue} \"encustomsettingvalue\"");
whereBuilder.Append(" WHERE ");
if (qpcuCustomSettingId != 0) {
whereBuilder.Append("((\"encustomsettingvalue\".\"customsettingid\" = @qpcuCustomSettingId) AND (\"encustomsettingvalue\".\"customsettingid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpcuCustomSettingId", DbType.Int32, qpcuCustomSettingId);
} else {
whereBuilder.Append("(\"encustomsettingvalue\".\"customsettingid\" IS NULL)");
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
RL_78f7eb5628c10c7f234959bf22490881 outParamList = new RL_78f7eb5628c10c7f234959bf22490881();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, false, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetCustomSettingsAccounting.GetCustomSettingValues_DB_CR_IND.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_78f7eb5628c10c7f234959bf22490881 _tmp = new RL_78f7eb5628c10c7f234959bf22490881();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetCustomSettingsAccounting.GetCustomSettingValues_DB_CR_IND.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_78f7eb5628c10c7f234959bf22490881)_tmp;
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

// Query Function "GetCustomSettingValue_GL_ACCOUNT" 9R5U1LpNP0q_2kBkX+mAhg of Action "GetCustomSettingsAccounting"
public static async Task<(RL_78f7eb5628c10c7f234959bf22490881,long)> datasetGetCustomSettingValue_GL_ACCOUNT(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,int qpcuCustomSettingId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetCustomSettingsAccounting.GetCustomSettingValue_GL_ACCOUNT", "d4541ef5-4dba-4a3f-bfda-40645fe98086");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetCustomSettingsAccounting.GetCustomSettingValue_GL_ACCOUNT", "d4541ef5-4dba-4a3f-bfda-40645fe98086", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.V8hTxmiOI0aSbGuwRJtaFw/NodesNotShownInESpaceTree.9R5U1LpNP0q_2kBkX+mAhg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"encustomsettingvalue1\".\"value\" o2, NULL o3, NULL o4");
fromBuilder.Append(" FROM {CustomSettingValue} \"encustomsettingvalue1\"");
whereBuilder.Append(" WHERE ");
if (qpcuCustomSettingId != 0) {
whereBuilder.Append("((\"encustomsettingvalue1\".\"customsettingid\" = @qpcuCustomSettingId) AND (\"encustomsettingvalue1\".\"customsettingid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpcuCustomSettingId", DbType.Int32, qpcuCustomSettingId);
} else {
whereBuilder.Append("(\"encustomsettingvalue1\".\"customsettingid\" IS NULL)");
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
RL_78f7eb5628c10c7f234959bf22490881 outParamList = new RL_78f7eb5628c10c7f234959bf22490881();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, false, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetCustomSettingsAccounting.GetCustomSettingValue_GL_ACCOUNT.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_78f7eb5628c10c7f234959bf22490881 _tmp = new RL_78f7eb5628c10c7f234959bf22490881();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetCustomSettingsAccounting.GetCustomSettingValue_GL_ACCOUNT.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_78f7eb5628c10c7f234959bf22490881)_tmp;
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
