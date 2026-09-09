namespace ssConectaProveedores;

public partial class Actions {
public class lcvInvoiceAccountingProcess_Create_Inv : VarsBag {
public long inParamInvoiceId;
public bool inParamIsFCP;
/// <summary>
/// Variable <code>Invoice</code> that represents the Service Studio Invoice <code>Invoice</code>
///  <p>Description: </p>
/// </summary>
public EN_d1d0320db36efbb094ad0082361435a0EntityRecord varLcInvoice = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();

public RL_94dfde238a1e776567d307c1f3f8a94e queryResGetInvoiceById2_outParamList = new RL_94dfde238a1e776567d307c1f3f8a94e();
public long queryResGetInvoiceById2_outParamCount = 0L;

public Actions.lcoInvoiceCreateOrUpdate resInvoiceCreateOrUpdate =  new Actions.lcoInvoiceCreateOrUpdate();
public RL_4d0a053561fa4a3aef04e507b83b31d1 queryResGetInvoiceById_outParamList = new RL_4d0a053561fa4a3aef04e507b83b31d1();
public long queryResGetInvoiceById_outParamCount = 0L;

public Actions.lcoInvoiceStatusHistoryCreateOrUpdate resInvoiceStatusHistoryCreateOrUpdate =  new Actions.lcoInvoiceStatusHistoryCreateOrUpdate();
public Actions.lcoInvoiceLogAdd resInvoiceLogAdd =  new Actions.lcoInvoiceLogAdd();
public lcvInvoiceAccountingProcess_Create_Inv(long inParamInvoiceId, bool inParamIsFCP) {
this.inParamInvoiceId = inParamInvoiceId;
this.inParamIsFCP = inParamIsFCP;
}
}
public class lcoInvoiceAccountingProcess_Create_Inv : VarsBag {
public long outParamSupplierId = 0L;

public lcoInvoiceAccountingProcess_Create_Inv() {
}
}
/// <summary>
/// Action <code>InvoiceAccountingProcess_Create_Inv</code> that represents the Service Studio action
///  <code>InvoiceAccountingProcess_Create_Inv</code> <p> Description: </p>
/// </summary>
public static async Task<long> ActionInvoiceAccountingProcess_Create_Inv(IRequestContext requestContext,long inParamInvoiceId,bool inParamIsFCP,CancellationToken cancellationToken) {
long outParamSupplierId = default;
lcoInvoiceAccountingProcess_Create_Inv result = new lcoInvoiceAccountingProcess_Create_Inv();
lcvInvoiceAccountingProcess_Create_Inv localVars = new lcvInvoiceAccountingProcess_Create_Inv(inParamInvoiceId, inParamIsFCP);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InvoiceAccountingProcess_Create_Inv", "4b56dfa7-3fbe-4010-9060-3f099a043d01"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InvoiceAccountingProcess_Create_Inv", "4b56dfa7-3fbe-4010-9060-3f099a043d01", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
if((localVars.inParamIsFCP)) {
// Query datasetGetInvoiceById2
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceById2_maxRecords = 1;
if (datasetGetInvoiceById2_maxRecords < 1) datasetGetInvoiceById2_maxRecords = 1;
int datasetGetInvoiceById2_startIndex = 0;(localVars.queryResGetInvoiceById2_outParamList,localVars.queryResGetInvoiceById2_outParamCount) = await FuncActionInvoiceAccountingProcess_Create_Inv.datasetGetInvoiceById2(requestContext,datasetGetInvoiceById2_maxRecords,datasetGetInvoiceById2_startIndex,IterationMultiplicity.Never,localVars.inParamInvoiceId,cancellationToken);

// SupplierId = GetInvoiceById2.List.Current.OrderMain.SupplierId
result.outParamSupplierId=localVars.queryResGetInvoiceById2_outParamList.CurrentRec.ssENOrderMain.ssSupplierId;

// Invoice = GetInvoiceById2.List.Current.Invoice
localVars.varLcInvoice=localVars.queryResGetInvoiceById2_outParamList.CurrentRec.ssENInvoice;
} else {
// Query datasetGetInvoiceById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceById_maxRecords = 1;
if (datasetGetInvoiceById_maxRecords < 1) datasetGetInvoiceById_maxRecords = 1;
int datasetGetInvoiceById_startIndex = 0;(localVars.queryResGetInvoiceById_outParamList,localVars.queryResGetInvoiceById_outParamCount) = await FuncActionInvoiceAccountingProcess_Create_Inv.datasetGetInvoiceById(requestContext,datasetGetInvoiceById_maxRecords,datasetGetInvoiceById_startIndex,IterationMultiplicity.Never,localVars.inParamInvoiceId,cancellationToken);

// SupplierId = GetInvoiceById.List.Current.Requisition.SupplierId
result.outParamSupplierId=localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENRequisition.ssSupplierId;

// Invoice = GetInvoiceById.List.Current.Invoice
localVars.varLcInvoice=localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice;
}

// set accounting
// Invoice.InvoiceStatusId = Accounting
localVars.varLcInvoice.ssInvoiceStatusId = (ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("Tfj332sYfU6orP6hWpZ2sg"))).ssId;
// InvoiceCreateOrUpdate
localVars.resInvoiceCreateOrUpdate.outParamId = await Actions.ActionInvoiceCreateOrUpdate(requestContext,localVars.varLcInvoice,false,cancellationToken);

// InvoiceLogAdd
localVars.resInvoiceLogAdd.outParamId = await Actions.ActionInvoiceLogAdd(requestContext,new EN_bf34270fdd0f7785895f41a998e724e8EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssInvoiceId = localVars.inParamInvoiceId, ssMessage = ((((AppUtils.GetStringResource("kas27w4sWU+Nx_qLhom3zQ#Value.-670115059.1", "Invoice")+" ")+localVars.varLcInvoice.ssName)+" ")+AppUtils.GetStringResource("kas27w4sWU+Nx_qLhom3zQ#Value.2068068348.1", "started the accounting process.")), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssCreatedBy = BuiltInFunction.GetUserId () },cancellationToken);

// InvoiceStatusHistoryCreateOrUpdate
localVars.resInvoiceStatusHistoryCreateOrUpdate.outParamId = await Actions.ActionInvoiceStatusHistoryCreateOrUpdate(requestContext,new EN_9edea2a401b6983c9ad50261c300f6d7EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssInvoiceId = localVars.inParamInvoiceId, ssInvoiceStatusId = (ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("Tfj332sYfU6orP6hWpZ2sg"))).ssId, ssTimeStamp = BuiltInFunction.CurrDateTime (), ssCreatedBy = BuiltInFunction.GetUserId () },cancellationToken);

} //close CreateActionActivity using block
} // try

finally {
outParamSupplierId = result.outParamSupplierId;
} // inner-finally
RETURN_STATEMENT:
return outParamSupplierId;
}

public static class FuncActionInvoiceAccountingProcess_Create_Inv {

private static async Task<RC_7ea2828a21285060cce33ce8e91b5455> datasetGetInvoiceById2ReadDbAsync(RC_7ea2828a21285060cce33ce8e91b5455 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceById2" eIPCDhKCqkKrWuyGNzmC5Q of Action "InvoiceAccountingProcess_Create_Inv"
public static async Task<(RL_94dfde238a1e776567d307c1f3f8a94e,long)> datasetGetInvoiceById2(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoice_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvoiceAccountingProcess_Create_Inv.GetInvoiceById2", "0ec28378-8212-42aa-ab5a-ec86373982e5");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvoiceAccountingProcess_Create_Inv.GetInvoiceById2", "0ec28378-8212-42aa-ab5a-ec86373982e5", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.p99WS74_EECQYD8JmgQ9AQ/NodesNotShownInESpaceTree.eIPCDhKCqkKrWuyGNzmC5Q, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoice15\".\"id\" o0, \"eninvoice15\".\"name\" o1, \"eninvoice15\".\"requisitionid\" o2, \"eninvoice15\".\"folioid\" o3, \"eninvoice15\".\"ordermainid\" o4, \"eninvoice15\".\"cfditypeid\" o5, trim_scale(\"eninvoice15\".\"totalamount\"::numeric) o6, \"eninvoice15\".\"currency\" o7, NULL o8, \"eninvoice15\".\"accountingdatetime\" o9, \"eninvoice15\".\"paymentdatetime\" o10, \"eninvoice15\".\"createdon\" o11, \"eninvoice15\".\"createdby\" o12, \"eninvoice15\".\"updatedon\" o13, \"eninvoice15\".\"updatedby\" o14, \"eninvoice15\".\"submittedon\" o15, \"eninvoice15\".\"isnewversion\" o16, \"eninvoice15\".\"id_poliza\" o17, \"eninvoice15\".\"id_poliza_sap\" o18, \"eninvoice15\".\"doc51\" o19, \"eninvoice15\".\"accountingerror\" o20, \"eninvoice15\".\"orderaccconceptsid\" o21, trim_scale(\"eninvoice15\".\"amortization\"::numeric) o22, \"eninvoice15\".\"creditnoteinvoiceid\" o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, \"enordermain22\".\"supplierid\" o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52");
fromBuilder.Append(" FROM ({Invoice} \"eninvoice15\" Left JOIN {OrderMain} \"enordermain22\" ON (\"eninvoice15\".\"ordermainid\" = \"enordermain22\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoice_Id != 0) {
whereBuilder.Append("((\"eninvoice15\".\"id\" = @qpinInvoice_Id) AND (\"eninvoice15\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoice_Id", DbType.Int64, qpinInvoice_Id);
} else {
whereBuilder.Append("(\"eninvoice15\".\"id\" IS NULL)");
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
RL_94dfde238a1e776567d307c1f3f8a94e outParamList = new RL_94dfde238a1e776567d307c1f3f8a94e();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoiceById2ReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvoiceAccountingProcess_Create_Inv.GetInvoiceById2.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_94dfde238a1e776567d307c1f3f8a94e _tmp = new RL_94dfde238a1e776567d307c1f3f8a94e();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoiceById2ReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvoiceAccountingProcess_Create_Inv.GetInvoiceById2.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_94dfde238a1e776567d307c1f3f8a94e)_tmp;
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

private static async Task<RC_003d65e5661b449409d67ebedc16a923> datasetGetInvoiceByIdReadDbAsync(RC_003d65e5661b449409d67ebedc16a923 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceById" HT8pN08JKEOj0IYTI2By0g of Action "InvoiceAccountingProcess_Create_Inv"
public static async Task<(RL_4d0a053561fa4a3aef04e507b83b31d1,long)> datasetGetInvoiceById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoice_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvoiceAccountingProcess_Create_Inv.GetInvoiceById", "37293f1d-094f-4328-a3d0-8613236072d2");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvoiceAccountingProcess_Create_Inv.GetInvoiceById", "37293f1d-094f-4328-a3d0-8613236072d2", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.p99WS74_EECQYD8JmgQ9AQ/NodesNotShownInESpaceTree.HT8pN08JKEOj0IYTI2By0g, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoice16\".\"id\" o0, \"eninvoice16\".\"name\" o1, \"eninvoice16\".\"requisitionid\" o2, \"eninvoice16\".\"folioid\" o3, \"eninvoice16\".\"ordermainid\" o4, \"eninvoice16\".\"cfditypeid\" o5, trim_scale(\"eninvoice16\".\"totalamount\"::numeric) o6, \"eninvoice16\".\"currency\" o7, NULL o8, \"eninvoice16\".\"accountingdatetime\" o9, \"eninvoice16\".\"paymentdatetime\" o10, \"eninvoice16\".\"createdon\" o11, \"eninvoice16\".\"createdby\" o12, \"eninvoice16\".\"updatedon\" o13, \"eninvoice16\".\"updatedby\" o14, \"eninvoice16\".\"submittedon\" o15, \"eninvoice16\".\"isnewversion\" o16, \"eninvoice16\".\"id_poliza\" o17, \"eninvoice16\".\"id_poliza_sap\" o18, \"eninvoice16\".\"doc51\" o19, \"eninvoice16\".\"accountingerror\" o20, \"eninvoice16\".\"orderaccconceptsid\" o21, trim_scale(\"eninvoice16\".\"amortization\"::numeric) o22, \"eninvoice16\".\"creditnoteinvoiceid\" o23, NULL o24, NULL o25, NULL o26, NULL o27, \"enrequisition24\".\"supplierid\" o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81");
fromBuilder.Append(" FROM ({Invoice} \"eninvoice16\" Left JOIN {Requisition} \"enrequisition24\" ON (\"eninvoice16\".\"requisitionid\" = \"enrequisition24\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoice_Id != 0) {
whereBuilder.Append("((\"eninvoice16\".\"id\" = @qpinInvoice_Id) AND (\"eninvoice16\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoice_Id", DbType.Int64, qpinInvoice_Id);
} else {
whereBuilder.Append("(\"eninvoice16\".\"id\" IS NULL)");
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
RL_4d0a053561fa4a3aef04e507b83b31d1 outParamList = new RL_4d0a053561fa4a3aef04e507b83b31d1();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoiceByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvoiceAccountingProcess_Create_Inv.GetInvoiceById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_4d0a053561fa4a3aef04e507b83b31d1 _tmp = new RL_4d0a053561fa4a3aef04e507b83b31d1();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoiceByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvoiceAccountingProcess_Create_Inv.GetInvoiceById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_4d0a053561fa4a3aef04e507b83b31d1)_tmp;
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
