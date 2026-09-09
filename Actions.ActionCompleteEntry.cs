namespace ssConectaProveedores;

public partial class Actions {
public class lcvCompleteEntry : VarsBag {
public long inParami_FolioId;
public string inParami_Year;
public string inParami_EntryNumber;
public int inParamOffsetUtc;
/// <summary>
/// Variable <code>FolioSAPData</code> that represents the Service Studio FolioSAPData
///  <code>FolioSAPData</code> <p>Description: </p>
/// </summary>
public EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord varLcFolioSAPData = new EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord();

public Actions.lcoInvoiceCreateOrUpdate resInvoiceCreateOrUpdate =  new Actions.lcoInvoiceCreateOrUpdate();
public RL_7b3475883ca90ad6eb7fc983e868c456 queryResGetInvoicesByFolioId_outParamList = new RL_7b3475883ca90ad6eb7fc983e868c456();
public long queryResGetInvoicesByFolioId_outParamCount = 0L;

public Actions.lcoFolioCreateOrUpdate resFolioCreateOrUpdate =  new Actions.lcoFolioCreateOrUpdate();
public Actions.lcoFolioLogAdd resFolioLogAdd =  new Actions.lcoFolioLogAdd();
public Actions.lcoFolioLogAdd resFolioLogAdd4 =  new Actions.lcoFolioLogAdd();
public RL_2b9a8ce7bf73dacd0e0e114719f57b83 queryResGetFolioById_outParamList = new RL_2b9a8ce7bf73dacd0e0e114719f57b83();
public long queryResGetFolioById_outParamCount = 0L;

public Actions.lcoFolioSAPData_CreateOrUpdate resFolioSAPData_CreateOrUpdate =  new Actions.lcoFolioSAPData_CreateOrUpdate();
public lcvCompleteEntry(long inParami_FolioId, string inParami_Year, string inParami_EntryNumber, int inParamOffsetUtc) {
this.inParami_FolioId = inParami_FolioId;
this.inParami_Year = inParami_Year;
this.inParami_EntryNumber = inParami_EntryNumber;
this.inParamOffsetUtc = inParamOffsetUtc;
}
}
public class lcoCompleteEntry : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public lcoCompleteEntry() {
}
}
/// <summary>
/// Action <code>CompleteEntry</code> that represents the Service Studio action
///  <code>CompleteEntry</code> <p> Description: </p>
/// </summary>
public static async Task<ST_046fb53ebbe142526d95e87ef1ae9711Structure> ActionCompleteEntry(IRequestContext requestContext,long inParami_FolioId,string inParami_Year,string inParami_EntryNumber,int inParamOffsetUtc,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
lcoCompleteEntry result = new lcoCompleteEntry();
lcvCompleteEntry localVars = new lcvCompleteEntry(inParami_FolioId, inParami_Year, inParami_EntryNumber, inParamOffsetUtc);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("CompleteEntry", "9af2351b-7b13-4e71-bc50-8a8c788b346f"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("CompleteEntry", "9af2351b-7b13-4e71-bc50-8a8c788b346f", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetFolioById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioById_maxRecords = 0;
int datasetGetFolioById_startIndex = 0;(localVars.queryResGetFolioById_outParamList,localVars.queryResGetFolioById_outParamCount) = await FuncActionCompleteEntry.datasetGetFolioById(requestContext,datasetGetFolioById_maxRecords,datasetGetFolioById_startIndex,IterationMultiplicity.Never,localVars.inParami_FolioId,cancellationToken);

// Empty?
if((localVars.queryResGetFolioById_outParamList.Empty)) {
// o_Output
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "Folio not found!"
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("EA3fTlU_oEqlC+NPLQsTfw#Value.1482511939.1", "Folio not found!");
} else {
// FolioSAPData = GetFolioById.List.Current.FolioSAPData
localVars.varLcFolioSAPData=localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioSAPData;
// set entry
// FolioSAPData.PO_DOCUMENTO_MATERIAL_EM = i_EntryNumber
localVars.varLcFolioSAPData.ssPO_DOCUMENTO_MATERIAL_EM = localVars.inParami_EntryNumber;

// FolioSAPData.PO_EJERCICIO_EM = i_Year
localVars.varLcFolioSAPData.ssPO_EJERCICIO_EM = localVars.inParami_Year;
// new
if(((localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioSAPData.ssId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// set new vars
// FolioSAPData.CreatedOn = CurrDateTime
localVars.varLcFolioSAPData.ssCreatedOn = BuiltInFunction.CurrDateTime ();

// FolioSAPData.CreatedBy = GetUserId
localVars.varLcFolioSAPData.ssCreatedBy = BuiltInFunction.GetUserId ();

// FolioSAPData.Service = "Manual complete entry"
localVars.varLcFolioSAPData.ssService = AppUtils.GetStringResource("v_njXC_LFUGdYSaE6f2WTg#Value.-1559745979.1", "Manual complete entry");

// FolioSAPData.FolioId = i_FolioId
localVars.varLcFolioSAPData.ssFolioId = localVars.inParami_FolioId;
}

// FolioSAPData_CreateOrUpdate
localVars.resFolioSAPData_CreateOrUpdate.outParamId = await Actions.ActionFolioSAPData_CreateOrUpdate(requestContext,localVars.varLcFolioSAPData,cancellationToken);

// Folio = Approved
// GetFolioById.List.Current.Folio.FolioStatusId = Approved
localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssFolioStatusId = (ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("sjaNMehoxESZWJutqvvRYA"))).ssId;
// FolioCreateOrUpdate
localVars.resFolioCreateOrUpdate.outParamId = await Actions.ActionFolioCreateOrUpdate(requestContext,localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio,cancellationToken);

// FolioLogAdd
localVars.resFolioLogAdd.outParamId = await Actions.ActionFolioLogAdd(requestContext,new EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssFolioId = localVars.inParami_FolioId, ssMessage = (((((((AppUtils.GetStringResource("fR0lMY0wkEqxjptA5Q7JIw#Value.-1163266653.1", "The entry was manually supplemented with the number")+" ")+localVars.inParami_EntryNumber)+" ")+AppUtils.GetStringResource("fR0lMY0wkEqxjptA5Q7JIw#Value.397926069.1", "and the year"))+" ")+localVars.inParami_Year)+"."), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssIsForSupplier = true },cancellationToken);

// FolioLogAdd4
localVars.resFolioLogAdd4.outParamId = await Actions.ActionFolioLogAdd(requestContext,new EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssFolioId = localVars.inParami_FolioId, ssMessage = (((((AppUtils.GetStringResource("HX1p+63IdkW6OW_bl6VI2Q#Value.68060425.1", "Folio")+" ")+localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssFolioNumber)+" ")+AppUtils.GetStringResource("HX1p+63IdkW6OW_bl6VI2Q#Value.1455861801.1", "has been updated to Approved status"))+"."), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssIsForSupplier = true },cancellationToken);

// SendEmailSupplier_FolioApproved2
await Actions.ActionSendEmailSupplier_FolioApproved(requestContext,localVars.inParami_FolioId,false,cancellationToken);

// Query datasetGetInvoicesByFolioId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoicesByFolioId_maxRecords = 0;
int datasetGetInvoicesByFolioId_startIndex = 0;(localVars.queryResGetInvoicesByFolioId_outParamList,localVars.queryResGetInvoicesByFolioId_outParamCount) = await FuncActionCompleteEntry.datasetGetInvoicesByFolioId(requestContext,datasetGetInvoicesByFolioId_maxRecords,datasetGetInvoicesByFolioId_startIndex,IterationMultiplicity.Never,localVars.inParami_FolioId,cancellationToken);

// accounting
// GetInvoicesByFolioId.List.Current.Invoice.InvoiceStatusId = Accounting
localVars.queryResGetInvoicesByFolioId_outParamList.CurrentRec.ssENInvoice.ssInvoiceStatusId = (ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("Tfj332sYfU6orP6hWpZ2sg"))).ssId;
// InvoiceCreateOrUpdate
localVars.resInvoiceCreateOrUpdate.outParamId = await Actions.ActionInvoiceCreateOrUpdate(requestContext,localVars.queryResGetInvoicesByFolioId_outParamList.CurrentRec.ssENInvoice,false,cancellationToken);

{
    using (AppHealthProvider.CreateGlobalEventTriggerMetric("OnGenerateInvoiceReport", "273f4dd0-00a5-4cce-a3c7-b798d5857b3e"))
    using (activitySource.CreateTriggerEventActivity("OnGenerateInvoiceReport", "273f4dd0-00a5-4cce-a3c7-b798d5857b3e", "87d51710-2b55-47b8-bf1b-f39d8d936a60", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828")) {
        var input = new EventPayloads.GlobalEventOnGenerateInvoiceReportPayload() {inParamInvoiceId = localVars.queryResGetInvoicesByFolioId_outParamList.CurrentRec.ssENInvoice.ssId,inParamInvoiceName = localVars.queryResGetInvoicesByFolioId_outParamList.CurrentRec.ssENInvoice.ssName};

        var eventPublisher = ServiceLocator.GetService<IEventPublisher>();
        await eventPublisher.PublishEventAsync("OnGenerateInvoiceReport", "87d51710-2b55-47b8-bf1b-f39d8d936a60", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828", input, cancellationToken);
    }
}

// InvoiceAccountingProcess_Create
await Actions.ActionInvoiceAccountingProcess_Create(requestContext,localVars.queryResGetInvoicesByFolioId_outParamList.CurrentRec.ssENInvoice.ssId,"",true,Convert.ToInt64(BuiltInFunction.NullIdentifier ()),localVars.inParamOffsetUtc,cancellationToken);

// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
}

} //close CreateActionActivity using block
} // try

finally {
outParamo_Output = result.outParamo_Output;
} // inner-finally
RETURN_STATEMENT:
return outParamo_Output;
}

public static class FuncActionCompleteEntry {

// Query Function "GetInvoicesByFolioId" wsbecbSFr0+rii6mGeRjfA of Action "CompleteEntry"
public static async Task<(RL_7b3475883ca90ad6eb7fc983e868c456,long)> datasetGetInvoicesByFolioId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolioId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("CompleteEntry.GetInvoicesByFolioId", "71dec6c2-85b4-4faf-ab8a-2ea619e4637c");
using var queryActivity = activitySource.CreateAggregateQueryActivity("CompleteEntry.GetInvoicesByFolioId", "71dec6c2-85b4-4faf-ab8a-2ea619e4637c", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.GzXymhN7cU68UIqMeIs0bw/NodesNotShownInESpaceTree.wsbecbSFr0+rii6mGeRjfA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoice43\".\"id\" o0, \"eninvoice43\".\"name\" o1, \"eninvoice43\".\"requisitionid\" o2, \"eninvoice43\".\"folioid\" o3, \"eninvoice43\".\"ordermainid\" o4, \"eninvoice43\".\"cfditypeid\" o5, trim_scale(\"eninvoice43\".\"totalamount\"::numeric) o6, \"eninvoice43\".\"currency\" o7, \"eninvoice43\".\"invoicestatusid\" o8, \"eninvoice43\".\"accountingdatetime\" o9, \"eninvoice43\".\"paymentdatetime\" o10, \"eninvoice43\".\"createdon\" o11, \"eninvoice43\".\"createdby\" o12, \"eninvoice43\".\"updatedon\" o13, \"eninvoice43\".\"updatedby\" o14, \"eninvoice43\".\"submittedon\" o15, \"eninvoice43\".\"isnewversion\" o16, \"eninvoice43\".\"id_poliza\" o17, \"eninvoice43\".\"id_poliza_sap\" o18, \"eninvoice43\".\"doc51\" o19, \"eninvoice43\".\"accountingerror\" o20, \"eninvoice43\".\"orderaccconceptsid\" o21, trim_scale(\"eninvoice43\".\"amortization\"::numeric) o22, \"eninvoice43\".\"creditnoteinvoiceid\" o23");
fromBuilder.Append(" FROM {Invoice} \"eninvoice43\"");
whereBuilder.Append(" WHERE ");
if (qpfoFolioId != 0) {
whereBuilder.Append("((\"eninvoice43\".\"folioid\" = @qpfoFolioId) AND (\"eninvoice43\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioId", DbType.Int64, qpfoFolioId);
} else {
whereBuilder.Append("(\"eninvoice43\".\"folioid\" IS NULL)");
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
RL_7b3475883ca90ad6eb7fc983e868c456 outParamList = new RL_7b3475883ca90ad6eb7fc983e868c456();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query CompleteEntry.GetInvoicesByFolioId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_7b3475883ca90ad6eb7fc983e868c456 _tmp = new RL_7b3475883ca90ad6eb7fc983e868c456();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query CompleteEntry.GetInvoicesByFolioId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_7b3475883ca90ad6eb7fc983e868c456)_tmp;
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

private static async Task<RC_77e758d8dd6b0d691548b18323e10e77> datasetGetFolioByIdReadDbAsync(RC_77e758d8dd6b0d691548b18323e10e77 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolio.Read( r, ref index);
rec.ssENFolioSAPData.Read( r, ref index);
return rec;
}
// Query Function "GetFolioById" lVbX2NDXeEak7031Z93btw of Action "CompleteEntry"
public static async Task<(RL_2b9a8ce7bf73dacd0e0e114719f57b83,long)> datasetGetFolioById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolio_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("CompleteEntry.GetFolioById", "d8d75695-d7d0-4678-a4ef-4df567dddbb7");
using var queryActivity = activitySource.CreateAggregateQueryActivity("CompleteEntry.GetFolioById", "d8d75695-d7d0-4678-a4ef-4df567dddbb7", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.GzXymhN7cU68UIqMeIs0bw/NodesNotShownInESpaceTree.lVbX2NDXeEak7031Z93btw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enfolio36\".\"id\" o0, \"enfolio36\".\"isdraft\" o1, \"enfolio36\".\"folionumber\" o2, \"enfolio36\".\"canproveedorcancel\" o3, \"enfolio36\".\"orderid\" o4, \"enfolio36\".\"supplierid\" o5, \"enfolio36\".\"companyid\" o6, \"enfolio36\".\"foliostatusid\" o7, trim_scale(\"enfolio36\".\"totalamount\"::numeric) o8, trim_scale(\"enfolio36\".\"totaliva_amount\"::numeric) o9, trim_scale(\"enfolio36\".\"partialamount\"::numeric) o10, \"enfolio36\".\"currencyid\" o11, \"enfolio36\".\"firstapproveruserid\" o12, \"enfolio36\".\"approvalprocesstypeid\" o13, \"enfolio36\".\"sapentryerror\" o14, \"enfolio36\".\"createdby\" o15, \"enfolio36\".\"createdon\" o16, \"enfolio36\".\"updatedby\" o17, \"enfolio36\".\"updatedon\" o18, \"enfolio36\".\"minuteselected\" o19, \"enfoliosapdata7\".\"id\" o20, \"enfoliosapdata7\".\"folioid\" o21, \"enfoliosapdata7\".\"service\" o22, NULL o23, \"enfoliosapdata7\".\"po_documento_material_sm\" o24, \"enfoliosapdata7\".\"po_documento_material_221\" o25, \"enfoliosapdata7\".\"po_documento_material_415\" o26, NULL o27, \"enfoliosapdata7\".\"po_ejercicio_sm\" o28, \"enfoliosapdata7\".\"po_ejercicio_221\" o29, \"enfoliosapdata7\".\"po_ejercicio_415\" o30, \"enfoliosapdata7\".\"po_folio_agrupados\" o31, \"enfoliosapdata7\".\"po_resultado\" o32, \"enfoliosapdata7\".\"createdby\" o33, \"enfoliosapdata7\".\"createdon\" o34");
fromBuilder.Append(" FROM ({Folio} \"enfolio36\" Left JOIN {FolioSAPData} \"enfoliosapdata7\" ON (\"enfolio36\".\"id\" = \"enfoliosapdata7\".\"folioid\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoFolio_Id != 0) {
whereBuilder.Append("((\"enfolio36\".\"id\" = @qpfoFolio_Id) AND (\"enfolio36\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolio_Id", DbType.Int64, qpfoFolio_Id);
} else {
whereBuilder.Append("(\"enfolio36\".\"id\" IS NULL)");
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
RL_2b9a8ce7bf73dacd0e0e114719f57b83 outParamList = new RL_2b9a8ce7bf73dacd0e0e114719f57b83();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFolioByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, false, false, true, false, false, false, true, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query CompleteEntry.GetFolioById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_2b9a8ce7bf73dacd0e0e114719f57b83 _tmp = new RL_2b9a8ce7bf73dacd0e0e114719f57b83();
_tmp.AlternateReadDbMethodAsync = datasetGetFolioByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query CompleteEntry.GetFolioById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_2b9a8ce7bf73dacd0e0e114719f57b83)_tmp;
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
