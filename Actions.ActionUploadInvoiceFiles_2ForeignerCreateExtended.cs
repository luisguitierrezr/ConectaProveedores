namespace ssConectaProveedores;

public partial class Actions {
public class lcvUploadInvoiceFiles_2ForeignerCreateExtended : VarsBag {
public long inParamInvoiceId;
public ST_6f620840109ac6f721328b723ec0152cStructure inParamInvoiceForeign;
public bool inParamIsStartApproval;
/// <summary>
/// Variable <code>InvoiceExtendedIssuer</code> that represents the Service Studio
///  InvoiceExtendedIssuer <code>InvoiceExtendedIssuer</code> <p>Description: InvoiceExtendedIssue
/// r record to create or modify</p>
/// </summary>
public EN_1ca446167f1a5fee035306f622895668EntityRecord varLcInvoiceExtendedIssuer = new EN_1ca446167f1a5fee035306f622895668EntityRecord();

/// <summary>
/// Variable <code>InvoiceExtendedReceiver</code> that represents the Service Studio
///  InvoiceExtendedReceiver <code>InvoiceExtendedReceiver</code> <p>Description
/// : InvoiceExtendedReceiver record to create or modify</p>
/// </summary>
public EN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord varLcInvoiceExtendedReceiver = new EN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord();

public Actions.lcoInvoiceExtendedIssuerCreateOrUpdate resInvoiceExtendedIssuerCreateOrUpdate =  new Actions.lcoInvoiceExtendedIssuerCreateOrUpdate();
public RL_a675a81d4063c2bba451ee57edc49e99 queryResGetInvoiceExtendedById_outParamList = new RL_a675a81d4063c2bba451ee57edc49e99();
public long queryResGetInvoiceExtendedById_outParamCount = 0L;

public Actions.lcoInvoiceExtendedCreateOrUpdate resInvoiceExtendedCreateOrUpdate =  new Actions.lcoInvoiceExtendedCreateOrUpdate();
public Actions.lcoInvoiceExtendedReceiverCreateOrUpdate resInvoiceExtendedReceiverCreateOrUpdate =  new Actions.lcoInvoiceExtendedReceiverCreateOrUpdate();
public lcvUploadInvoiceFiles_2ForeignerCreateExtended(long inParamInvoiceId, ST_6f620840109ac6f721328b723ec0152cStructure inParamInvoiceForeign, bool inParamIsStartApproval) {
this.inParamInvoiceId = inParamInvoiceId;
this.inParamInvoiceForeign = inParamInvoiceForeign;
this.inParamIsStartApproval = inParamIsStartApproval;
}
}
/// <summary>
/// Action <code>UploadInvoiceFiles_2ForeignerCreateExtended</code> that represents the Service Studio
///  action <code>UploadInvoiceFiles_2ForeignerCreateExtended</code> <p> Description: </p>
/// </summary>
public static async Task ActionUploadInvoiceFiles_2ForeignerCreateExtended(IRequestContext requestContext,long inParamInvoiceId,ST_6f620840109ac6f721328b723ec0152cStructure inParamInvoiceForeign,bool inParamIsStartApproval,CancellationToken cancellationToken) {
lcvUploadInvoiceFiles_2ForeignerCreateExtended localVars = new lcvUploadInvoiceFiles_2ForeignerCreateExtended(inParamInvoiceId, inParamInvoiceForeign, inParamIsStartApproval);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("UploadInvoiceFiles_2ForeignerCreateExtended", "ecd423f4-a575-4840-90a7-0ef952cd00a5"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("UploadInvoiceFiles_2ForeignerCreateExtended", "ecd423f4-a575-4840-90a7-0ef952cd00a5", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetInvoiceExtendedById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceExtendedById_maxRecords = 1;
if (datasetGetInvoiceExtendedById_maxRecords < 1) datasetGetInvoiceExtendedById_maxRecords = 1;
int datasetGetInvoiceExtendedById_startIndex = 0;(localVars.queryResGetInvoiceExtendedById_outParamList,localVars.queryResGetInvoiceExtendedById_outParamCount) = await FuncActionUploadInvoiceFiles_2ForeignerCreateExtended.datasetGetInvoiceExtendedById(requestContext,datasetGetInvoiceExtendedById_maxRecords,datasetGetInvoiceExtendedById_startIndex,IterationMultiplicity.Never,localVars.inParamInvoiceId,cancellationToken);

// GetInvoiceExtendedById.List.Current.InvoiceExtended.FechaEmision = TextToDate
localVars.queryResGetInvoiceExtendedById_outParamList.CurrentRec.ssENInvoiceExtended.ssFechaEmision = BuiltInFunction.DateToText(BuiltInFunction.TextToDate (localVars.inParamInvoiceForeign.ssInvoiceDate));

// GetInvoiceExtendedById.List.Current.InvoiceExtended.Total = TextToDecimal
localVars.queryResGetInvoiceExtendedById_outParamList.CurrentRec.ssENInvoiceExtended.ssTotal = BuiltInFunction.TextToDecimal (localVars.inParamInvoiceForeign.ssTotalAmount);

// GetInvoiceExtendedById.List.Current.InvoiceExtended.Moneda = InvoiceForeign.Currency
localVars.queryResGetInvoiceExtendedById_outParamList.CurrentRec.ssENInvoiceExtended.ssMoneda = localVars.inParamInvoiceForeign.ssCurrency;

// GetInvoiceExtendedById.List.Current.InvoiceExtended.Id = InvoiceId
localVars.queryResGetInvoiceExtendedById_outParamList.CurrentRec.ssENInvoiceExtended.ssId = localVars.inParamInvoiceId;

// GetInvoiceExtendedById.List.Current.InvoiceExtended.Folio = InvoiceForeign.InvoiceNumber
localVars.queryResGetInvoiceExtendedById_outParamList.CurrentRec.ssENInvoiceExtended.ssFolio = localVars.inParamInvoiceForeign.ssInvoiceNumber;

// GetInvoiceExtendedById.List.Current.InvoiceExtended.Subtotal = TextToDecimal
localVars.queryResGetInvoiceExtendedById_outParamList.CurrentRec.ssENInvoiceExtended.ssSubtotal = BuiltInFunction.TextToDecimal (localVars.inParamInvoiceForeign.ssTotalAmount);
// InvoiceExtendedCreateOrUpdate
localVars.resInvoiceExtendedCreateOrUpdate.outParamId = await Actions.ActionInvoiceExtendedCreateOrUpdate(requestContext,localVars.queryResGetInvoiceExtendedById_outParamList.CurrentRec.ssENInvoiceExtended,localVars.inParamInvoiceId,cancellationToken);

if((localVars.inParamIsStartApproval)) {
// InvoiceExtendedIssuer.Id = InvoiceId
localVars.varLcInvoiceExtendedIssuer.ssId = localVars.inParamInvoiceId;

// InvoiceExtendedIssuer.Nombre = InvoiceForeign.SupplierName
localVars.varLcInvoiceExtendedIssuer.ssNombre = localVars.inParamInvoiceForeign.ssSupplierName;

// InvoiceExtendedIssuer.RFC = InvoiceForeign.SupplierTaxId
localVars.varLcInvoiceExtendedIssuer.ssRFC = localVars.inParamInvoiceForeign.ssSupplierTaxId;
// InvoiceExtendedIssuerCreateOrUpdate
localVars.resInvoiceExtendedIssuerCreateOrUpdate.outParamId = await Actions.ActionInvoiceExtendedIssuerCreateOrUpdate(requestContext,localVars.varLcInvoiceExtendedIssuer,localVars.inParamInvoiceId,cancellationToken);

// InvoiceExtendedReceiver.Id = InvoiceId
localVars.varLcInvoiceExtendedReceiver.ssId = localVars.inParamInvoiceId;

// InvoiceExtendedReceiver.RFC = InvoiceForeign.CustomerTaxIdDetected
localVars.varLcInvoiceExtendedReceiver.ssRFC = localVars.inParamInvoiceForeign.ssCustomerTaxIdDetected;

// InvoiceExtendedReceiver.Nombre = InvoiceForeign.CustomerNameDetected
localVars.varLcInvoiceExtendedReceiver.ssNombre = localVars.inParamInvoiceForeign.ssCustomerNameDetected;
// InvoiceExtendedReceiverCreateOrUpdate
localVars.resInvoiceExtendedReceiverCreateOrUpdate.outParamId = await Actions.ActionInvoiceExtendedReceiverCreateOrUpdate(requestContext,localVars.varLcInvoiceExtendedReceiver,localVars.inParamInvoiceId,cancellationToken);

}

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionUploadInvoiceFiles_2ForeignerCreateExtended {

// Query Function "GetInvoiceExtendedById" 2BxhReTqaUyqm5OhajNoWw of Action "UploadInvoiceFiles_2ForeignerCreateExtended"
public static async Task<(RL_a675a81d4063c2bba451ee57edc49e99,long)> datasetGetInvoiceExtendedById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("UploadInvoiceFiles_2ForeignerCreateExtended.GetInvoiceExtendedById", "45611cd8-eae4-4c69-aa9b-93a16a33685b");
using var queryActivity = activitySource.CreateAggregateQueryActivity("UploadInvoiceFiles_2ForeignerCreateExtended.GetInvoiceExtendedById", "45611cd8-eae4-4c69-aa9b-93a16a33685b", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.9CPU7HWlQEiQpw75Us0ApQ/NodesNotShownInESpaceTree.2BxhReTqaUyqm5OhajNoWw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoiceextended17\".\"id\" o0, \"eninvoiceextended17\".\"version\" o1, \"eninvoiceextended17\".\"folio\" o2, \"eninvoiceextended17\".\"serie\" o3, \"eninvoiceextended17\".\"fechaemision\" o4, \"eninvoiceextended17\".\"formapago\" o5, \"eninvoiceextended17\".\"metodopago\" o6, \"eninvoiceextended17\".\"lugarexpedicion\" o7, trim_scale(\"eninvoiceextended17\".\"subtotal\"::numeric) o8, trim_scale(\"eninvoiceextended17\".\"descuento\"::numeric) o9, trim_scale(\"eninvoiceextended17\".\"totaliva\"::numeric) o10, trim_scale(\"eninvoiceextended17\".\"retenciones\"::numeric) o11, trim_scale(\"eninvoiceextended17\".\"total\"::numeric) o12, \"eninvoiceextended17\".\"tipocomprobante\" o13, \"eninvoiceextended17\".\"moneda\" o14, trim_scale(\"eninvoiceextended17\".\"tipocambio\"::numeric) o15, \"eninvoiceextended17\".\"usocfdi\" o16, \"eninvoiceextended17\".\"exportacion\" o17, \"eninvoiceextended17\".\"uuid\" o18");
fromBuilder.Append(" FROM {InvoiceExtended} \"eninvoiceextended17\"");
whereBuilder.Append(" WHERE ");
if (qpinId != 0) {
whereBuilder.Append("((\"eninvoiceextended17\".\"id\" = @qpinId) AND (\"eninvoiceextended17\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinId", DbType.Int64, qpinId);
} else {
whereBuilder.Append("(\"eninvoiceextended17\".\"id\" IS NULL)");
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
RL_a675a81d4063c2bba451ee57edc49e99 outParamList = new RL_a675a81d4063c2bba451ee57edc49e99();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query UploadInvoiceFiles_2ForeignerCreateExtended.GetInvoiceExtendedById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_a675a81d4063c2bba451ee57edc49e99 _tmp = new RL_a675a81d4063c2bba451ee57edc49e99();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query UploadInvoiceFiles_2ForeignerCreateExtended.GetInvoiceExtendedById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_a675a81d4063c2bba451ee57edc49e99)_tmp;
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
