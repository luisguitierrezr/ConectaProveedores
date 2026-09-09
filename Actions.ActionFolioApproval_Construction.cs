namespace ssConectaProveedores;

public partial class Actions {
public class lcvFolioApproval_Construction : VarsBag {
public long inParamFolioId;
public int inParamOffsetUtc;
public Actions.lcoInvoiceCreateOrUpdate resInvoiceCreateOrUpdate =  new Actions.lcoInvoiceCreateOrUpdate();
public Actions.lcoCallEntryAccountingFolio resCallEntryAccountingFolio =  new Actions.lcoCallEntryAccountingFolio();
public RL_d94294de88e7b9437b2238f21bdccaff queryResGetFolioById_outParamList = new RL_d94294de88e7b9437b2238f21bdccaff();
public long queryResGetFolioById_outParamCount = 0L;

public Actions.lcoFolioLogAdd resFolioLogAddInvoice =  new Actions.lcoFolioLogAdd();
public lcvFolioApproval_Construction(long inParamFolioId, int inParamOffsetUtc) {
this.inParamFolioId = inParamFolioId;
this.inParamOffsetUtc = inParamOffsetUtc;
}
}
/// <summary>
/// Action <code>FolioApproval_Construction</code> that represents the Service Studio action
///  <code>FolioApproval_Construction</code> <p> Description: </p>
/// </summary>
public static async Task ActionFolioApproval_Construction(IRequestContext requestContext,long inParamFolioId,int inParamOffsetUtc,CancellationToken cancellationToken) {
lcvFolioApproval_Construction localVars = new lcvFolioApproval_Construction(inParamFolioId, inParamOffsetUtc);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("FolioApproval_Construction", "7ae59225-4de1-4484-a80e-f40459330fca"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("FolioApproval_Construction", "7ae59225-4de1-4484-a80e-f40459330fca", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetFolioById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioById_maxRecords = 0;
int datasetGetFolioById_startIndex = 0;(localVars.queryResGetFolioById_outParamList,localVars.queryResGetFolioById_outParamCount) = await FuncActionFolioApproval_Construction.datasetGetFolioById(requestContext,datasetGetFolioById_maxRecords,datasetGetFolioById_startIndex,IterationMultiplicity.Never,localVars.inParamFolioId,cancellationToken);

// set invoice submitted
// GetFolioById.List.Current.Invoice.InvoiceStatusId = Submitted_FRONTENDPORPUSES
localVars.queryResGetFolioById_outParamList.CurrentRec.ssENInvoice.ssInvoiceStatusId = (ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("+o3LB6D8JEaAPRwNpdwZag"))).ssId;
// InvoiceCreateOrUpdate
localVars.resInvoiceCreateOrUpdate.outParamId = await Actions.ActionInvoiceCreateOrUpdate(requestContext,localVars.queryResGetFolioById_outParamList.CurrentRec.ssENInvoice,false,cancellationToken);

// FolioLogAddInvoice
localVars.resFolioLogAddInvoice.outParamId = await Actions.ActionFolioLogAdd(requestContext,new EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssFolioId = localVars.inParamFolioId, ssMessage = (((((((((AppUtils.GetStringResource("RMH8ne1OI0KNbll8vrKVpg#Value.68060425.1", "Folio")+" ")+localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssFolioNumber)+" ")+AppUtils.GetStringResource("RMH8ne1OI0KNbll8vrKVpg#Value.-877900168.1", "had Invoice"))+" ")+localVars.queryResGetFolioById_outParamList.CurrentRec.ssENInvoice.ssName)+" ")+AppUtils.GetStringResource("RMH8ne1OI0KNbll8vrKVpg#Value.348678395.1", "submitted"))+"."), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssIsError = false },cancellationToken);

// CallEntryAccountingFolio
localVars.resCallEntryAccountingFolio.outParamo_Output = await Actions.ActionCallEntryAccountingFolio(requestContext,localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio,false,localVars.inParamOffsetUtc,cancellationToken);

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionFolioApproval_Construction {

private static async Task<RC_b668eee4846e2937101a51355804499d> datasetGetFolioByIdReadDbAsync(RC_b668eee4846e2937101a51355804499d rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolio.Read( r, ref index);
rec.ssENInvoice.Read( r, ref index);
return rec;
}
// Query Function "GetFolioById" 7dVYqwZmVEiVcTneq6ePsw of Action "FolioApproval_Construction"
public static async Task<(RL_d94294de88e7b9437b2238f21bdccaff,long)> datasetGetFolioById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolio_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("FolioApproval_Construction.GetFolioById", "ab58d5ed-6606-4854-9571-39deaba78fb3");
using var queryActivity = activitySource.CreateAggregateQueryActivity("FolioApproval_Construction.GetFolioById", "ab58d5ed-6606-4854-9571-39deaba78fb3", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.JZLleuFNhESoDvQEWTMPyg/NodesNotShownInESpaceTree.7dVYqwZmVEiVcTneq6ePsw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enfolio23\".\"id\" o0, \"enfolio23\".\"isdraft\" o1, \"enfolio23\".\"folionumber\" o2, \"enfolio23\".\"canproveedorcancel\" o3, \"enfolio23\".\"orderid\" o4, \"enfolio23\".\"supplierid\" o5, \"enfolio23\".\"companyid\" o6, \"enfolio23\".\"foliostatusid\" o7, trim_scale(\"enfolio23\".\"totalamount\"::numeric) o8, trim_scale(\"enfolio23\".\"totaliva_amount\"::numeric) o9, trim_scale(\"enfolio23\".\"partialamount\"::numeric) o10, \"enfolio23\".\"currencyid\" o11, \"enfolio23\".\"firstapproveruserid\" o12, \"enfolio23\".\"approvalprocesstypeid\" o13, \"enfolio23\".\"sapentryerror\" o14, \"enfolio23\".\"createdby\" o15, \"enfolio23\".\"createdon\" o16, \"enfolio23\".\"updatedby\" o17, \"enfolio23\".\"updatedon\" o18, \"enfolio23\".\"minuteselected\" o19, \"eninvoice30\".\"id\" o20, \"eninvoice30\".\"name\" o21, \"eninvoice30\".\"requisitionid\" o22, \"eninvoice30\".\"folioid\" o23, \"eninvoice30\".\"ordermainid\" o24, \"eninvoice30\".\"cfditypeid\" o25, trim_scale(\"eninvoice30\".\"totalamount\"::numeric) o26, \"eninvoice30\".\"currency\" o27, \"eninvoice30\".\"invoicestatusid\" o28, \"eninvoice30\".\"accountingdatetime\" o29, \"eninvoice30\".\"paymentdatetime\" o30, \"eninvoice30\".\"createdon\" o31, \"eninvoice30\".\"createdby\" o32, \"eninvoice30\".\"updatedon\" o33, \"eninvoice30\".\"updatedby\" o34, \"eninvoice30\".\"submittedon\" o35, \"eninvoice30\".\"isnewversion\" o36, \"eninvoice30\".\"id_poliza\" o37, \"eninvoice30\".\"id_poliza_sap\" o38, \"eninvoice30\".\"doc51\" o39, \"eninvoice30\".\"accountingerror\" o40, \"eninvoice30\".\"orderaccconceptsid\" o41, trim_scale(\"eninvoice30\".\"amortization\"::numeric) o42, \"eninvoice30\".\"creditnoteinvoiceid\" o43");
fromBuilder.Append(" FROM ({Folio} \"enfolio23\" Left JOIN {Invoice} \"eninvoice30\" ON (\"enfolio23\".\"id\" = \"eninvoice30\".\"folioid\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoFolio_Id != 0) {
whereBuilder.Append("((\"enfolio23\".\"id\" = @qpfoFolio_Id) AND (\"enfolio23\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolio_Id", DbType.Int64, qpfoFolio_Id);
} else {
whereBuilder.Append("(\"enfolio23\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (\"eninvoice30\".\"invoicestatusid\" <> ");
whereBuilder.Append((ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("RteygpK6NkexqZHONe6zkg"))).ssId);
whereBuilder.Append(")");
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
RL_d94294de88e7b9437b2238f21bdccaff outParamList = new RL_d94294de88e7b9437b2238f21bdccaff();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFolioByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query FolioApproval_Construction.GetFolioById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_d94294de88e7b9437b2238f21bdccaff _tmp = new RL_d94294de88e7b9437b2238f21bdccaff();
_tmp.AlternateReadDbMethodAsync = datasetGetFolioByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query FolioApproval_Construction.GetFolioById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_d94294de88e7b9437b2238f21bdccaff)_tmp;
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
