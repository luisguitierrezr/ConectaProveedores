namespace ssConectaProveedores;

public partial class Actions {
public class lcvValidateInvoiceYear : VarsBag {
public int inParamInvoiceYear;
public string inParamInvoiceFolio;
public string inParamInvoiceUUID;
public int inParamOffsetUtc;
public RL_8e032f44e0be6aa532cdb4d35c4de633 queryResGetFiscalYearExceptions_outParamList = new RL_8e032f44e0be6aa532cdb4d35c4de633();
public long queryResGetFiscalYearExceptions_outParamCount = 0L;

public lcvValidateInvoiceYear(int inParamInvoiceYear, string inParamInvoiceFolio, string inParamInvoiceUUID, int inParamOffsetUtc) {
this.inParamInvoiceYear = inParamInvoiceYear;
this.inParamInvoiceFolio = inParamInvoiceFolio;
this.inParamInvoiceUUID = inParamInvoiceUUID;
this.inParamOffsetUtc = inParamOffsetUtc;
}
}
public class lcoValidateInvoiceYear : VarsBag {
public bool outParamIsValid = false;

public lcoValidateInvoiceYear() {
}
}
/// <summary>
/// Action <code>ValidateInvoiceYear</code> that represents the Service Studio action
///  <code>ValidateInvoiceYear</code> <p> Description: </p>
/// </summary>
public static async Task<bool> ActionValidateInvoiceYear(IRequestContext requestContext,int inParamInvoiceYear,string inParamInvoiceFolio,string inParamInvoiceUUID,int inParamOffsetUtc,CancellationToken cancellationToken) {
bool outParamIsValid = default;
lcoValidateInvoiceYear result = new lcoValidateInvoiceYear();
lcvValidateInvoiceYear localVars = new lcvValidateInvoiceYear(inParamInvoiceYear, inParamInvoiceFolio, inParamInvoiceUUID, inParamOffsetUtc);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("ValidateInvoiceYear", "d25e2bda-f87b-4de2-9540-1e7ef745c315"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("ValidateInvoiceYear", "d25e2bda-f87b-4de2-9540-1e7ef745c315", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// CurrYear
if((((localVars.inParamInvoiceYear==BuiltInFunction.Year ((await Functions.ActionUTCToLocalTime(requestContext,BuiltInFunction.CurrDateTime (),(localVars.inParamOffsetUtc*(-1)),cancellationToken))))||(!((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveXMLValidation_Year]))))))) {
// IsValid = True
result.outParamIsValid=true;
} else {
// Query datasetGetFiscalYearExceptions
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFiscalYearExceptions_maxRecords = 1;
if (datasetGetFiscalYearExceptions_maxRecords < 1) datasetGetFiscalYearExceptions_maxRecords = 1;
int datasetGetFiscalYearExceptions_startIndex = 0;(localVars.queryResGetFiscalYearExceptions_outParamList,localVars.queryResGetFiscalYearExceptions_outParamCount) = await FuncActionValidateInvoiceYear.datasetGetFiscalYearExceptions(requestContext,datasetGetFiscalYearExceptions_maxRecords,datasetGetFiscalYearExceptions_startIndex,IterationMultiplicity.Never,localVars.inParamInvoiceFolio,localVars.inParamInvoiceUUID,localVars.inParamInvoiceYear,cancellationToken);

// IsValid = notGetFiscalYearExceptions.List.Empty
result.outParamIsValid=(!localVars.queryResGetFiscalYearExceptions_outParamList.Empty);
}

} //close CreateActionActivity using block
} // try

finally {
outParamIsValid = result.outParamIsValid;
} // inner-finally
RETURN_STATEMENT:
return outParamIsValid;
}

public static class FuncActionValidateInvoiceYear {

// Query Function "GetFiscalYearExceptions" HuXIIlBYk0GAVaoqMzw40g of Action "ValidateInvoiceYear"
public static async Task<(RL_8e032f44e0be6aa532cdb4d35c4de633,long)> datasetGetFiscalYearExceptions(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteInvoiceFolio,string qpteInvoiceUUID,int qpinYear,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ValidateInvoiceYear.GetFiscalYearExceptions", "22c8e51e-5850-4193-8055-aa2a333c38d2");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ValidateInvoiceYear.GetFiscalYearExceptions", "22c8e51e-5850-4193-8055-aa2a333c38d2", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.2ite0nv44k2VQB5+90XDFQ/NodesNotShownInESpaceTree.HuXIIlBYk0GAVaoqMzw40g, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8");
fromBuilder.Append(" FROM {FiscalYearExceptions} \"enfiscalyearexceptions\"");
whereBuilder.Append(" WHERE (\"enfiscalyearexceptions\".\"year\" = @qpinYear) AND (((\"enfiscalyearexceptions\".\"invoicefolio\" = @qpteInvoiceFolio) AND (@qpteInvoiceFolio <> '')) OR ((\"enfiscalyearexceptions\".\"invoiceuuid\" = @qpteInvoiceUUID) AND (@qpteInvoiceUUID <> '')))");
sqlCmd.CreateParameterWithoutReplacements("@qpinYear", DbType.Int32, qpinYear);
sqlCmd.CreateParameterWithoutReplacements("@qpteInvoiceFolio", DbType.String, qpteInvoiceFolio);
sqlCmd.CreateParameterWithoutReplacements("@qpteInvoiceUUID", DbType.String, qpteInvoiceUUID);
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
RL_8e032f44e0be6aa532cdb4d35c4de633 outParamList = new RL_8e032f44e0be6aa532cdb4d35c4de633();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ValidateInvoiceYear.GetFiscalYearExceptions.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_8e032f44e0be6aa532cdb4d35c4de633 _tmp = new RL_8e032f44e0be6aa532cdb4d35c4de633();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ValidateInvoiceYear.GetFiscalYearExceptions.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_8e032f44e0be6aa532cdb4d35c4de633)_tmp;
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
