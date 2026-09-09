namespace ssConectaProveedores;

public partial class Actions {
public class lcvInvoiceGetIVACodeByTax : VarsBag {
public EN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord inParamInvoiceExtendedTax;
public bool inParamIsNational;
public string inParamSupplierNumber;
public RL_bf188616de0f0f2f6ca06ba5dba27490 queryResGetTaxIndicatorsByExternalId_outParamList = new RL_bf188616de0f0f2f6ca06ba5dba27490();
public long queryResGetTaxIndicatorsByExternalId_outParamCount = 0L;

public Actions.lcoInvoiceGetIVACodeByTaxSupplierExcep resInvoiceGetIVACodeByTaxSupplierExcep =  new Actions.lcoInvoiceGetIVACodeByTaxSupplierExcep();
public lcvInvoiceGetIVACodeByTax(EN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord inParamInvoiceExtendedTax, bool inParamIsNational, string inParamSupplierNumber) {
this.inParamInvoiceExtendedTax = inParamInvoiceExtendedTax;
this.inParamIsNational = inParamIsNational;
this.inParamSupplierNumber = inParamSupplierNumber;
}
}
public class lcoInvoiceGetIVACodeByTax : VarsBag {
public long outParamTaxIndicatorId = 0L;

public string outParamCode = "";

public lcoInvoiceGetIVACodeByTax() {
}
}
/// <summary>
/// Action <code>InvoiceGetIVACodeByTax</code> that represents the Service Studio action
///  <code>InvoiceGetIVACodeByTax</code> <p> Description: </p>
/// </summary>
public static async Task<(long,string)> ActionInvoiceGetIVACodeByTax(IRequestContext requestContext,EN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord inParamInvoiceExtendedTax,bool inParamIsNational,string inParamSupplierNumber,CancellationToken cancellationToken) {
long outParamTaxIndicatorId = default;
string outParamCode = default;
lcoInvoiceGetIVACodeByTax result = new lcoInvoiceGetIVACodeByTax();
lcvInvoiceGetIVACodeByTax localVars = new lcvInvoiceGetIVACodeByTax(inParamInvoiceExtendedTax, inParamIsNational, inParamSupplierNumber);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InvoiceGetIVACodeByTax", "5a4d1e33-1cab-4229-91f3-41f6a6fd4b8b"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InvoiceGetIVACodeByTax", "5a4d1e33-1cab-4229-91f3-41f6a6fd4b8b", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
if(((!localVars.inParamIsNational))) {
// Code = "V5"
result.outParamCode="V5";
} else {
if((localVars.inParamInvoiceExtendedTax.ssTasaOCuota==BuiltInFunction.TextToDecimal ("0.11"))) {
// Code = "M1"
result.outParamCode="M1";
} else {
if(((BuiltInFunction.DecimalToText(localVars.inParamInvoiceExtendedTax.ssTasaOCuota)=="")&&(BuiltInFunction.DecimalToText(localVars.inParamInvoiceExtendedTax.ssBase)=="Exento"))) {
// Code = "M4"
result.outParamCode="M4";
} else {
if((BuiltInFunction.DecimalToText(localVars.inParamInvoiceExtendedTax.ssTasaOCuota)=="")) {
// Code = "M3"
result.outParamCode="M3";
} else {
if((localVars.inParamInvoiceExtendedTax.ssTasaOCuota==BuiltInFunction.TextToDecimal ("0.0"))) {
// Code = "M0"
result.outParamCode="M0";
} else {
if((localVars.inParamInvoiceExtendedTax.ssTasaOCuota==BuiltInFunction.TextToDecimal ("0.08"))) {
// Code = "X8"
result.outParamCode="X8";
} else {
if((localVars.inParamInvoiceExtendedTax.ssTasaOCuota==BuiltInFunction.TextToDecimal ("0.16"))) {
// InvoiceGetIVACodeByTaxSupplierExcep
localVars.resInvoiceGetIVACodeByTaxSupplierExcep.outParamIsM9 = await Actions.ActionInvoiceGetIVACodeByTaxSupplierExcep(requestContext,localVars.inParamSupplierNumber,cancellationToken);

// Code = If
result.outParamCode=((localVars.resInvoiceGetIVACodeByTaxSupplierExcep.outParamIsM9) ? ("M9") : ("M2"));
} else {
goto RETURN_STATEMENT;

}

}

}

}

}

}

}

// Query datasetGetTaxIndicatorsByExternalId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetTaxIndicatorsByExternalId_maxRecords = 1;
if (datasetGetTaxIndicatorsByExternalId_maxRecords < 1) datasetGetTaxIndicatorsByExternalId_maxRecords = 1;
int datasetGetTaxIndicatorsByExternalId_startIndex = 0;(localVars.queryResGetTaxIndicatorsByExternalId_outParamList,localVars.queryResGetTaxIndicatorsByExternalId_outParamCount) = await FuncActionInvoiceGetIVACodeByTax.datasetGetTaxIndicatorsByExternalId(requestContext,datasetGetTaxIndicatorsByExternalId_maxRecords,datasetGetTaxIndicatorsByExternalId_startIndex,IterationMultiplicity.Never,result.outParamCode,cancellationToken);

// TaxIndicatorId = GetTaxIndicatorsByExternalId.List.Current.TaxIndicator.Id
result.outParamTaxIndicatorId=localVars.queryResGetTaxIndicatorsByExternalId_outParamList.CurrentRec.ssENTaxIndicator.ssId;
} //close CreateActionActivity using block
} // try

finally {
outParamTaxIndicatorId = result.outParamTaxIndicatorId;
outParamCode = result.outParamCode;
} // inner-finally
RETURN_STATEMENT:
return (outParamTaxIndicatorId,outParamCode);
}

public static class FuncActionInvoiceGetIVACodeByTax {

// Query Function "GetTaxIndicatorsByExternalId" Ksod2kEn5ECmdX0tOMbuzA of Action "InvoiceGetIVACodeByTax"
public static async Task<(RL_bf188616de0f0f2f6ca06ba5dba27490,long)> datasetGetTaxIndicatorsByExternalId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteExternalId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvoiceGetIVACodeByTax.GetTaxIndicatorsByExternalId", "da1dca2a-2741-40e4-a675-7d2d38c6eecc");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvoiceGetIVACodeByTax.GetTaxIndicatorsByExternalId", "da1dca2a-2741-40e4-a675-7d2d38c6eecc", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.Mx5NWqscKUKR80H2pv1Liw/NodesNotShownInESpaceTree.Ksod2kEn5ECmdX0tOMbuzA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"entaxindicator3\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6");
fromBuilder.Append(" FROM {TaxIndicator} \"entaxindicator3\"");
whereBuilder.Append(" WHERE (\"entaxindicator3\".\"externalid\" = @qpteExternalId)");
sqlCmd.CreateParameterWithoutReplacements("@qpteExternalId", DbType.String, qpteExternalId);
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
RL_bf188616de0f0f2f6ca06ba5dba27490 outParamList = new RL_bf188616de0f0f2f6ca06ba5dba27490();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvoiceGetIVACodeByTax.GetTaxIndicatorsByExternalId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_bf188616de0f0f2f6ca06ba5dba27490 _tmp = new RL_bf188616de0f0f2f6ca06ba5dba27490();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvoiceGetIVACodeByTax.GetTaxIndicatorsByExternalId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_bf188616de0f0f2f6ca06ba5dba27490)_tmp;
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
