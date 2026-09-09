namespace ssConectaProveedores;

public partial class Actions {
public class lcvGenerateCurrentAccountPdf : VarsBag {
public string inParamI_ACREEDOR;
public string inParamI_ANTICIPOS_HIGH;
public string inParamI_ANTICIPOS_LOW;
public string inParamI_F_PARTABIE;
public string inParamI_PCOMP_HIGH;
public string inParamI_PCOMP_LOW;
public string inParamI_REGION;
public long inParamI_SOCIEDAD;
public byte[] resPrintToPDF_outParamPDF = new byte[] {};

public RL_84bdfe424d1eb0223fc2b8cfa9bb96be queryResGetSupplierUsersBySupplierId_outParamList = new RL_84bdfe424d1eb0223fc2b8cfa9bb96be();
public long queryResGetSupplierUsersBySupplierId_outParamCount = 0L;

public RL_060f887b4f32b5cdb78b49175875565c queryResGetCompany_outParamList = new RL_060f887b4f32b5cdb78b49175875565c();
public long queryResGetCompany_outParamCount = 0L;

public lcvGenerateCurrentAccountPdf(string inParamI_ACREEDOR, string inParamI_ANTICIPOS_HIGH, string inParamI_ANTICIPOS_LOW, string inParamI_F_PARTABIE, string inParamI_PCOMP_HIGH, string inParamI_PCOMP_LOW, string inParamI_REGION, long inParamI_SOCIEDAD) {
this.inParamI_ACREEDOR = inParamI_ACREEDOR;
this.inParamI_ANTICIPOS_HIGH = inParamI_ANTICIPOS_HIGH;
this.inParamI_ANTICIPOS_LOW = inParamI_ANTICIPOS_LOW;
this.inParamI_F_PARTABIE = inParamI_F_PARTABIE;
this.inParamI_PCOMP_HIGH = inParamI_PCOMP_HIGH;
this.inParamI_PCOMP_LOW = inParamI_PCOMP_LOW;
this.inParamI_REGION = inParamI_REGION;
this.inParamI_SOCIEDAD = inParamI_SOCIEDAD;
}
}
public class lcoGenerateCurrentAccountPdf : VarsBag {
public byte[] outParamo_file = new byte[] {};

public lcoGenerateCurrentAccountPdf() {
}
}
/// <summary>
/// Action <code>GenerateCurrentAccountPdf</code> that represents the Service Studio action
///  <code>GenerateCurrentAccountPdf</code> <p> Description: </p>
/// </summary>
public static async Task<byte[]> ActionGenerateCurrentAccountPdf(IRequestContext requestContext,string inParamI_ACREEDOR,string inParamI_ANTICIPOS_HIGH,string inParamI_ANTICIPOS_LOW,string inParamI_F_PARTABIE,string inParamI_PCOMP_HIGH,string inParamI_PCOMP_LOW,string inParamI_REGION,long inParamI_SOCIEDAD,CancellationToken cancellationToken) {
byte[] outParamo_file = default;
lcoGenerateCurrentAccountPdf result = new lcoGenerateCurrentAccountPdf();
lcvGenerateCurrentAccountPdf localVars = new lcvGenerateCurrentAccountPdf(inParamI_ACREEDOR, inParamI_ANTICIPOS_HIGH, inParamI_ANTICIPOS_LOW, inParamI_F_PARTABIE, inParamI_PCOMP_HIGH, inParamI_PCOMP_LOW, inParamI_REGION, inParamI_SOCIEDAD);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GenerateCurrentAccountPdf", "630e8900-f486-4b74-8027-8194a8c83ba0"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GenerateCurrentAccountPdf", "630e8900-f486-4b74-8027-8194a8c83ba0", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetCompany
cancellationToken.ThrowIfCancellationRequested();
int datasetGetCompany_maxRecords = 0;
int datasetGetCompany_startIndex = 0;(localVars.queryResGetCompany_outParamList,localVars.queryResGetCompany_outParamCount) = await FuncActionGenerateCurrentAccountPdf.datasetGetCompany(requestContext,datasetGetCompany_maxRecords,datasetGetCompany_startIndex,IterationMultiplicity.Never,localVars.inParamI_SOCIEDAD,cancellationToken);

// Query datasetGetSupplierUsersBySupplierId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetSupplierUsersBySupplierId_maxRecords = 0;
int datasetGetSupplierUsersBySupplierId_startIndex = 0;(localVars.queryResGetSupplierUsersBySupplierId_outParamList,localVars.queryResGetSupplierUsersBySupplierId_outParamCount) = await FuncActionGenerateCurrentAccountPdf.datasetGetSupplierUsersBySupplierId(requestContext,datasetGetSupplierUsersBySupplierId_maxRecords,datasetGetSupplierUsersBySupplierId_startIndex,IterationMultiplicity.Never,BuiltInFunction.GetUserId (),cancellationToken);

// PrintToPDF
localVars.resPrintToPDF_outParamPDF = await Actions.ActionPrintToPDF(requestContext,((((((((((((((((((((((string)AppUtils.SiteProperties[SitePropertiesModel.spCurrentDomain])))+"ConectaProveedores/ReportCurrentAccount?I_ACREEDOR=")+localVars.inParamI_ACREEDOR)+"&I_ANTICIPOS_HIGH=")+localVars.inParamI_ANTICIPOS_HIGH)+"&I_ANTICIPOS_LOW=")+localVars.inParamI_ANTICIPOS_LOW)+"&I_F_PARTABIE=")+localVars.inParamI_F_PARTABIE)+"&I_PCOMP_HIGH=")+localVars.inParamI_PCOMP_HIGH)+"&I_PCOMP_LOW=")+localVars.inParamI_PCOMP_LOW)+"&I_REGION=")+localVars.inParamI_REGION)+"&I_SOCIEDAD=")+localVars.queryResGetCompany_outParamList.CurrentRec.ssENCompany.ssExternalId)+"&SupplierId=")+BuiltInFunction.LongIntegerToText(localVars.queryResGetSupplierUsersBySupplierId_outParamList.CurrentRec.ssENSupplierUser.ssSupplierId)),new ST_201dce7bb255178c132fec4d547942aeStructure(){ ssBaseURL = ((((string)AppUtils.SiteProperties[SitePropertiesModel.spCurrentDomain]))), ssLocale = "es-MX", ssTimezone = "America/Mexico_City" },cancellationToken);

// o_file = PrintToPDF.PDF
result.outParamo_file=localVars.resPrintToPDF_outParamPDF;
} //close CreateActionActivity using block
} // try

finally {
outParamo_file = result.outParamo_file;
} // inner-finally
RETURN_STATEMENT:
return outParamo_file;
}

public static class FuncActionGenerateCurrentAccountPdf {

// Query Function "GetSupplierUsersBySupplierId" aEBcQCJAJEOkAYKfRkmktA of Action "GenerateCurrentAccountPdf"
public static async Task<(RL_84bdfe424d1eb0223fc2b8cfa9bb96be,long)> datasetGetSupplierUsersBySupplierId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUserId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GenerateCurrentAccountPdf.GetSupplierUsersBySupplierId", "405c4068-4022-4324-a401-829f4649a4b4");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GenerateCurrentAccountPdf.GetSupplierUsersBySupplierId", "405c4068-4022-4324-a401-829f4649a4b4", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.AIkOY4b0dEuAJ4GUqMg7oA/NodesNotShownInESpaceTree.aEBcQCJAJEOkAYKfRkmktA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"ensupplieruser6\".\"supplierid\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14");
fromBuilder.Append(" FROM {SupplierUser} \"ensupplieruser6\"");
whereBuilder.Append(" WHERE ");
if ((qpusUserId.Trim()!="")) {
whereBuilder.Append("((\"ensupplieruser6\".\"userid\" = @qpusUserId) AND (\"ensupplieruser6\".\"userid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUserId", DbType.String, qpusUserId);
} else {
whereBuilder.Append("(\"ensupplieruser6\".\"userid\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"ensupplieruser6\".\"name\" ASC ");
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
RL_84bdfe424d1eb0223fc2b8cfa9bb96be outParamList = new RL_84bdfe424d1eb0223fc2b8cfa9bb96be();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GenerateCurrentAccountPdf.GetSupplierUsersBySupplierId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_84bdfe424d1eb0223fc2b8cfa9bb96be _tmp = new RL_84bdfe424d1eb0223fc2b8cfa9bb96be();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GenerateCurrentAccountPdf.GetSupplierUsersBySupplierId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_84bdfe424d1eb0223fc2b8cfa9bb96be)_tmp;
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

// Query Function "GetCompany" 4U9BmCmhd0iwFtKCcRJOKg of Action "GenerateCurrentAccountPdf"
public static async Task<(RL_060f887b4f32b5cdb78b49175875565c,long)> datasetGetCompany(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpcoId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GenerateCurrentAccountPdf.GetCompany", "98414fe1-a129-4877-b016-d28271124e2a");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GenerateCurrentAccountPdf.GetCompany", "98414fe1-a129-4877-b016-d28271124e2a", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.AIkOY4b0dEuAJ4GUqMg7oA/NodesNotShownInESpaceTree.4U9BmCmhd0iwFtKCcRJOKg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"encompany5\".\"externalid\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10");
fromBuilder.Append(" FROM {Company} \"encompany5\"");
whereBuilder.Append(" WHERE ");
if (qpcoId != 0) {
whereBuilder.Append("((\"encompany5\".\"id\" = @qpcoId) AND (\"encompany5\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpcoId", DbType.Int64, qpcoId);
} else {
whereBuilder.Append("(\"encompany5\".\"id\" IS NULL)");
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
RL_060f887b4f32b5cdb78b49175875565c outParamList = new RL_060f887b4f32b5cdb78b49175875565c();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GenerateCurrentAccountPdf.GetCompany.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_060f887b4f32b5cdb78b49175875565c _tmp = new RL_060f887b4f32b5cdb78b49175875565c();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GenerateCurrentAccountPdf.GetCompany.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_060f887b4f32b5cdb78b49175875565c)_tmp;
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
