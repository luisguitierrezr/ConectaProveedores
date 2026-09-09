namespace ssConectaProveedores;

public partial class Actions {
public class lcvInvoiceManualAccounting : VarsBag {
public long inParamInvoiceId;
public string inParamPolizaSAP;
public string inParamPolizaSAP_CN;
public RL_4f8b259bdd04db22be8fb771f1ad1d4f queryResGetFolioById_outParamList = new RL_4f8b259bdd04db22be8fb771f1ad1d4f();
public long queryResGetFolioById_outParamCount = 0L;

public Actions.lcoInvoiceCreateOrUpdate resInvoiceCreateOrUpdate_CN =  new Actions.lcoInvoiceCreateOrUpdate();
public Actions.lcoInvoiceCreateOrUpdate resInvoiceCreateOrUpdate =  new Actions.lcoInvoiceCreateOrUpdate();
public Actions.lcoFolioCreateOrUpdate resFolioCreateOrUpdate =  new Actions.lcoFolioCreateOrUpdate();
public Actions.lcoInvoiceLogAdd resInvoiceLogAdd_CN =  new Actions.lcoInvoiceLogAdd();
public Actions.lcoFolioLogAdd resFolioLogAdd =  new Actions.lcoFolioLogAdd();
public RL_29ee9e201d1174176a9cb64aac6297ba queryResGetInvoiceById_outParamList = new RL_29ee9e201d1174176a9cb64aac6297ba();
public long queryResGetInvoiceById_outParamCount = 0L;

public Actions.lcoInvoiceLogAdd resInvoiceLogAdd =  new Actions.lcoInvoiceLogAdd();
public lcvInvoiceManualAccounting(long inParamInvoiceId, string inParamPolizaSAP, string inParamPolizaSAP_CN) {
this.inParamInvoiceId = inParamInvoiceId;
this.inParamPolizaSAP = inParamPolizaSAP;
this.inParamPolizaSAP_CN = inParamPolizaSAP_CN;
}
}
public class lcoInvoiceManualAccounting : VarsBag {
public bool outParamSuccess = true;

public string outParamMessage = "";

public lcoInvoiceManualAccounting() {
}
}
/// <summary>
/// Action <code>InvoiceManualAccounting</code> that represents the Service Studio action
///  <code>InvoiceManualAccounting</code> <p> Description: </p>
/// </summary>
public static async Task<(bool,string)> ActionInvoiceManualAccounting(IRequestContext requestContext,long inParamInvoiceId,string inParamPolizaSAP,string inParamPolizaSAP_CN,CancellationToken cancellationToken) {
bool outParamSuccess = default;
string outParamMessage = default;
lcoInvoiceManualAccounting result = new lcoInvoiceManualAccounting();
lcvInvoiceManualAccounting localVars = new lcvInvoiceManualAccounting(inParamInvoiceId, inParamPolizaSAP, inParamPolizaSAP_CN);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InvoiceManualAccounting", "a1d822c6-14ff-4323-8e4e-d6abfe06e828"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InvoiceManualAccounting", "a1d822c6-14ff-4323-8e4e-d6abfe06e828", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetInvoiceById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceById_maxRecords = 1;
if (datasetGetInvoiceById_maxRecords < 1) datasetGetInvoiceById_maxRecords = 1;
int datasetGetInvoiceById_startIndex = 0;(localVars.queryResGetInvoiceById_outParamList,localVars.queryResGetInvoiceById_outParamCount) = await FuncActionInvoiceManualAccounting.datasetGetInvoiceById(requestContext,datasetGetInvoiceById_maxRecords,datasetGetInvoiceById_startIndex,IterationMultiplicity.Never,localVars.inParamInvoiceId,cancellationToken);

// Set Invoice Data
// GetInvoiceById.List.Current.Invoice.InvoiceStatusId = ContabilizationSuccess
localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssInvoiceStatusId = (ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("h+R+u64a50K6vJ2dkkiVXQ"))).ssId;

// GetInvoiceById.List.Current.Invoice.ID_POLIZA = GetInvoiceById.List.Current.Invoice.Id
localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssID_POLIZA = BuiltInFunction.LongIntegerToText(localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssId);

// GetInvoiceById.List.Current.Invoice.ID_POLIZA_SAP = PolizaSAP
localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssID_POLIZA_SAP = localVars.inParamPolizaSAP;

// GetInvoiceById.List.Current.Invoice_CN.InvoiceStatusId = ContabilizationSuccess
localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice_CN.ssInvoiceStatusId = (ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("h+R+u64a50K6vJ2dkkiVXQ"))).ssId;

// GetInvoiceById.List.Current.Invoice_CN.ID_POLIZA = GetInvoiceById.List.Current.Invoice_CN.Id
localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice_CN.ssID_POLIZA = BuiltInFunction.LongIntegerToText(localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice_CN.ssId);

// GetInvoiceById.List.Current.Invoice_CN.ID_POLIZA_SAP = PolizaSAP_CN
localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice_CN.ssID_POLIZA_SAP = localVars.inParamPolizaSAP_CN;
// InvoiceCreateOrUpdate
localVars.resInvoiceCreateOrUpdate.outParamId = await Actions.ActionInvoiceCreateOrUpdate(requestContext,localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice,false,cancellationToken);

// InvoiceLogAdd
localVars.resInvoiceLogAdd.outParamId = await Actions.ActionInvoiceLogAdd(requestContext,new EN_bf34270fdd0f7785895f41a998e724e8EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssInvoiceId = localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssId, ssMessage = AppUtils.GetStringResource("JjXCd_xAtk+yuWJyM7HG8g#Value.-1560539597.1", "Invoice status changed to contabilization success"), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssCreatedBy = BuiltInFunction.GetUserId () },cancellationToken);

// InvoiceDocumentRelationCreate
await Actions.ActionInvoiceDocumentRelationCreate(requestContext,localVars.inParamInvoiceId,localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssID_POLIZA,localVars.inParamPolizaSAP,((((string)AppUtils.SiteProperties[SitePropertiesModel.spInvoiceWithNoContractTable]))),cancellationToken);

// InvoiceCreateOrUpdate_CN
localVars.resInvoiceCreateOrUpdate_CN.outParamId = await Actions.ActionInvoiceCreateOrUpdate(requestContext,localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice_CN,false,cancellationToken);

// InvoiceLogAdd_CN
localVars.resInvoiceLogAdd_CN.outParamId = await Actions.ActionInvoiceLogAdd(requestContext,new EN_bf34270fdd0f7785895f41a998e724e8EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssInvoiceId = localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice_CN.ssId, ssMessage = AppUtils.GetStringResource("4navdmcK1UaXxmYYgSRw8g#Value.-1560539597.1", "Invoice status changed to contabilization success"), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssCreatedBy = BuiltInFunction.GetUserId () },cancellationToken);

// InvoiceDocumentRelationCreate_CN
await Actions.ActionInvoiceDocumentRelationCreate(requestContext,localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssCreditNoteInvoiceId,localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice_CN.ssID_POLIZA,localVars.inParamPolizaSAP_CN,((((string)AppUtils.SiteProperties[SitePropertiesModel.spInvoiceWithNoContractTable]))),cancellationToken);

// no folio
if((!((localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssFolioId==Convert.ToInt64(BuiltInFunction.NullIdentifier ()))))) {
// Query datasetGetFolioById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioById_maxRecords = 1;
if (datasetGetFolioById_maxRecords < 1) datasetGetFolioById_maxRecords = 1;
int datasetGetFolioById_startIndex = 0;(localVars.queryResGetFolioById_outParamList,localVars.queryResGetFolioById_outParamCount) = await FuncActionInvoiceManualAccounting.datasetGetFolioById(requestContext,datasetGetFolioById_maxRecords,datasetGetFolioById_startIndex,IterationMultiplicity.Never,localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssFolioId,cancellationToken);

// Set Folio Status
// GetFolioById.List.Current.Folio.FolioStatusId = ContabilizationSuccess
localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssFolioStatusId = (ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("Sibqk6dY7UGlZ5CDRDlXsg"))).ssId;
// FolioCreateOrUpdate
localVars.resFolioCreateOrUpdate.outParamId = await Actions.ActionFolioCreateOrUpdate(requestContext,localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio,cancellationToken);

// FolioLogAdd
localVars.resFolioLogAdd.outParamId = await Actions.ActionFolioLogAdd(requestContext,new EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssFolioId = localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssId, ssMessage = AppUtils.GetStringResource("Ek5kv7eV1EuoJMT87zK1GQ#Value.1052867887.1", "Folio status changed to contabilization success"), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime () },cancellationToken);

}

} //close CreateActionActivity using block
} // try

catch (Exception ex) {
ApplicationLogger.Error(ex, "Error executing action");
requestContext.LastException = ex;

// Error Handler
await DatabaseAccess.RollbackAllTransactionsAsync(cancellationToken);

// Set Error
// Message = "Invoice had a problem in its saving. Please contact an administrator."
result.outParamMessage=AppUtils.GetStringResource("sHjxH+v8BEKAnwWcN2gUXA#Value.-1974385899.1", "Invoice had a problem in its saving. Please contact an administrator.");

// Success = False
result.outParamSuccess=false;
goto RETURN_STATEMENT;

} // Catch
finally {
outParamSuccess = result.outParamSuccess;
outParamMessage = result.outParamMessage;
cancellationToken.ThrowIfCancellationRequested();
} // inner-finally
RETURN_STATEMENT:
return (outParamSuccess,outParamMessage);
}

public static class FuncActionInvoiceManualAccounting {

// Query Function "GetFolioById" 6SNuB2wQZkS2W5uUtVs2fg of Action "InvoiceManualAccounting"
public static async Task<(RL_4f8b259bdd04db22be8fb771f1ad1d4f,long)> datasetGetFolioById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvoiceManualAccounting.GetFolioById", "076e23e9-106c-4466-b65b-9b94b55b367e");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvoiceManualAccounting.GetFolioById", "076e23e9-106c-4466-b65b-9b94b55b367e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.xiLYof8UI0OOTtar_gboKA/NodesNotShownInESpaceTree.6SNuB2wQZkS2W5uUtVs2fg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enfolio38\".\"id\" o0, \"enfolio38\".\"isdraft\" o1, \"enfolio38\".\"folionumber\" o2, \"enfolio38\".\"canproveedorcancel\" o3, \"enfolio38\".\"orderid\" o4, \"enfolio38\".\"supplierid\" o5, \"enfolio38\".\"companyid\" o6, \"enfolio38\".\"foliostatusid\" o7, trim_scale(\"enfolio38\".\"totalamount\"::numeric) o8, trim_scale(\"enfolio38\".\"totaliva_amount\"::numeric) o9, trim_scale(\"enfolio38\".\"partialamount\"::numeric) o10, \"enfolio38\".\"currencyid\" o11, \"enfolio38\".\"firstapproveruserid\" o12, \"enfolio38\".\"approvalprocesstypeid\" o13, \"enfolio38\".\"sapentryerror\" o14, \"enfolio38\".\"createdby\" o15, \"enfolio38\".\"createdon\" o16, \"enfolio38\".\"updatedby\" o17, \"enfolio38\".\"updatedon\" o18, \"enfolio38\".\"minuteselected\" o19");
fromBuilder.Append(" FROM {Folio} \"enfolio38\"");
whereBuilder.Append(" WHERE ");
if (qpfoId != 0) {
whereBuilder.Append("((\"enfolio38\".\"id\" = @qpfoId) AND (\"enfolio38\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoId", DbType.Int64, qpfoId);
} else {
whereBuilder.Append("(\"enfolio38\".\"id\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvoiceManualAccounting.GetFolioById.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvoiceManualAccounting.GetFolioById.List", cancellationToken: cancellationToken);
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

private static async Task<RC_986e250fa802967d9a3443950a5e3b6b> datasetGetInvoiceByIdReadDbAsync(RC_986e250fa802967d9a3443950a5e3b6b rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoice_CN.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceById" ZBbisjPGOEK3mv_ux97q5g of Action "InvoiceManualAccounting"
public static async Task<(RL_29ee9e201d1174176a9cb64aac6297ba,long)> datasetGetInvoiceById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoice_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvoiceManualAccounting.GetInvoiceById", "b2e21664-c633-4238-b79a-ffeec7deeae6");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvoiceManualAccounting.GetInvoiceById", "b2e21664-c633-4238-b79a-ffeec7deeae6", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.xiLYof8UI0OOTtar_gboKA/NodesNotShownInESpaceTree.ZBbisjPGOEK3mv_ux97q5g, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoice44\".\"id\" o0, \"eninvoice44\".\"name\" o1, \"eninvoice44\".\"requisitionid\" o2, \"eninvoice44\".\"folioid\" o3, \"eninvoice44\".\"ordermainid\" o4, \"eninvoice44\".\"cfditypeid\" o5, trim_scale(\"eninvoice44\".\"totalamount\"::numeric) o6, \"eninvoice44\".\"currency\" o7, \"eninvoice44\".\"invoicestatusid\" o8, \"eninvoice44\".\"accountingdatetime\" o9, \"eninvoice44\".\"paymentdatetime\" o10, \"eninvoice44\".\"createdon\" o11, \"eninvoice44\".\"createdby\" o12, \"eninvoice44\".\"updatedon\" o13, \"eninvoice44\".\"updatedby\" o14, \"eninvoice44\".\"submittedon\" o15, \"eninvoice44\".\"isnewversion\" o16, \"eninvoice44\".\"id_poliza\" o17, \"eninvoice44\".\"id_poliza_sap\" o18, \"eninvoice44\".\"doc51\" o19, \"eninvoice44\".\"accountingerror\" o20, \"eninvoice44\".\"orderaccconceptsid\" o21, trim_scale(\"eninvoice44\".\"amortization\"::numeric) o22, \"eninvoice44\".\"creditnoteinvoiceid\" o23, \"eninvoice_cn\".\"id\" o24, \"eninvoice_cn\".\"name\" o25, \"eninvoice_cn\".\"requisitionid\" o26, \"eninvoice_cn\".\"folioid\" o27, \"eninvoice_cn\".\"ordermainid\" o28, \"eninvoice_cn\".\"cfditypeid\" o29, trim_scale(\"eninvoice_cn\".\"totalamount\"::numeric) o30, \"eninvoice_cn\".\"currency\" o31, \"eninvoice_cn\".\"invoicestatusid\" o32, \"eninvoice_cn\".\"accountingdatetime\" o33, \"eninvoice_cn\".\"paymentdatetime\" o34, \"eninvoice_cn\".\"createdon\" o35, \"eninvoice_cn\".\"createdby\" o36, \"eninvoice_cn\".\"updatedon\" o37, \"eninvoice_cn\".\"updatedby\" o38, \"eninvoice_cn\".\"submittedon\" o39, \"eninvoice_cn\".\"isnewversion\" o40, \"eninvoice_cn\".\"id_poliza\" o41, \"eninvoice_cn\".\"id_poliza_sap\" o42, \"eninvoice_cn\".\"doc51\" o43, \"eninvoice_cn\".\"accountingerror\" o44, \"eninvoice_cn\".\"orderaccconceptsid\" o45, trim_scale(\"eninvoice_cn\".\"amortization\"::numeric) o46, \"eninvoice_cn\".\"creditnoteinvoiceid\" o47");
fromBuilder.Append(" FROM ({Invoice} \"eninvoice44\" Left JOIN {Invoice} \"eninvoice_cn\" ON (\"eninvoice44\".\"creditnoteinvoiceid\" = \"eninvoice_cn\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoice_Id != 0) {
whereBuilder.Append("((\"eninvoice44\".\"id\" = @qpinInvoice_Id) AND (\"eninvoice44\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoice_Id", DbType.Int64, qpinInvoice_Id);
} else {
whereBuilder.Append("(\"eninvoice44\".\"id\" IS NULL)");
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
RL_29ee9e201d1174176a9cb64aac6297ba outParamList = new RL_29ee9e201d1174176a9cb64aac6297ba();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoiceByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvoiceManualAccounting.GetInvoiceById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_29ee9e201d1174176a9cb64aac6297ba _tmp = new RL_29ee9e201d1174176a9cb64aac6297ba();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoiceByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvoiceManualAccounting.GetInvoiceById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_29ee9e201d1174176a9cb64aac6297ba)_tmp;
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
