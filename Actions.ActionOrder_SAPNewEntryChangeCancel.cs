namespace ssConectaProveedores;

public partial class Actions {
public class lcvOrder_SAPNewEntryChangeCancel : VarsBag {
public string inParamUUID;
public bool inParami_IsRejectFolio;
public string inParamEntryDoc;
public string inParamEntryNumberEM;
public string inParamEntryYear;
public long inParamOrderItemEntriesId;
/// <summary>
/// Variable <code>FolioId</code> that represents the Service Studio FolioIdentifier
///  <code>FolioId</code> <p>Description: </p>
/// </summary>
public long varLcFolioId = 0L;

public Actions.lcoFolioCancelFromEntry resFolioCancelFromEntry2 =  new Actions.lcoFolioCancelFromEntry();
public RL_2b9a8ce7bf73dacd0e0e114719f57b83 queryResGetFolioByEntry_outParamList = new RL_2b9a8ce7bf73dacd0e0e114719f57b83();
public long queryResGetFolioByEntry_outParamCount = 0L;

public RL_547e7f54f784bcf7e09ead39e9929460 queryResGetFolioByUUID_outParamList = new RL_547e7f54f784bcf7e09ead39e9929460();
public long queryResGetFolioByUUID_outParamCount = 0L;

public RC_27f9dcc2de814d2d04d4d18f5b8c424b resGetOrderItemEntries_outParamRecord = new RC_27f9dcc2de814d2d04d4d18f5b8c424b();

public lcvOrder_SAPNewEntryChangeCancel(string inParamUUID, bool inParami_IsRejectFolio, string inParamEntryDoc, string inParamEntryNumberEM, string inParamEntryYear, long inParamOrderItemEntriesId) {
this.inParamUUID = inParamUUID;
this.inParami_IsRejectFolio = inParami_IsRejectFolio;
this.inParamEntryDoc = inParamEntryDoc;
this.inParamEntryNumberEM = inParamEntryNumberEM;
this.inParamEntryYear = inParamEntryYear;
this.inParamOrderItemEntriesId = inParamOrderItemEntriesId;
}
}
public class lcoOrder_SAPNewEntryChangeCancel : VarsBag {
public bool outParamo_IsRejectFolio = false;

public lcoOrder_SAPNewEntryChangeCancel() {
}
}
/// <summary>
/// Action <code>Order_SAPNewEntryChangeCancel</code> that represents the Service Studio action
///  <code>Order_SAPNewEntryChangeCancel</code> <p> Description: </p>
/// </summary>
public static async Task<bool> ActionOrder_SAPNewEntryChangeCancel(IRequestContext requestContext,string inParamUUID,bool inParami_IsRejectFolio,string inParamEntryDoc,string inParamEntryNumberEM,string inParamEntryYear,long inParamOrderItemEntriesId,CancellationToken cancellationToken) {
bool outParamo_IsRejectFolio = default;
lcoOrder_SAPNewEntryChangeCancel result = new lcoOrder_SAPNewEntryChangeCancel();
lcvOrder_SAPNewEntryChangeCancel localVars = new lcvOrder_SAPNewEntryChangeCancel(inParamUUID, inParami_IsRejectFolio, inParamEntryDoc, inParamEntryNumberEM, inParamEntryYear, inParamOrderItemEntriesId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("Order_SAPNewEntryChangeCancel", "942af9d2-f943-477b-b8b4-6791c8bdcf35"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("Order_SAPNewEntryChangeCancel", "942af9d2-f943-477b-b8b4-6791c8bdcf35", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
if(((BuiltInFunction.Trim (localVars.inParamUUID)==""))) {
// Query datasetGetFolioByEntry
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioByEntry_maxRecords = 1;
if (datasetGetFolioByEntry_maxRecords < 1) datasetGetFolioByEntry_maxRecords = 1;
int datasetGetFolioByEntry_startIndex = 0;(localVars.queryResGetFolioByEntry_outParamList,localVars.queryResGetFolioByEntry_outParamCount) = await FuncActionOrder_SAPNewEntryChangeCancel.datasetGetFolioByEntry(requestContext,datasetGetFolioByEntry_maxRecords,datasetGetFolioByEntry_startIndex,IterationMultiplicity.Never,localVars.inParamEntryNumberEM,localVars.inParamEntryYear,cancellationToken);

// FolioId = GetFolioByEntry.List.Current.Folio.Id
localVars.varLcFolioId=localVars.queryResGetFolioByEntry_outParamList.CurrentRec.ssENFolio.ssId;
} else {
// Query datasetGetFolioByUUID
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioByUUID_maxRecords = 1;
if (datasetGetFolioByUUID_maxRecords < 1) datasetGetFolioByUUID_maxRecords = 1;
int datasetGetFolioByUUID_startIndex = 0;(localVars.queryResGetFolioByUUID_outParamList,localVars.queryResGetFolioByUUID_outParamCount) = await FuncActionOrder_SAPNewEntryChangeCancel.datasetGetFolioByUUID(requestContext,datasetGetFolioByUUID_maxRecords,datasetGetFolioByUUID_startIndex,IterationMultiplicity.Never,localVars.inParamUUID,cancellationToken);

// FolioId = GetFolioByUUID.List.Current.Folio.Id
localVars.varLcFolioId=localVars.queryResGetFolioByUUID_outParamList.CurrentRec.ssENFolio.ssId;
}

// No Folio Found
if(((localVars.varLcFolioId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
if((!(localVars.inParami_IsRejectFolio))) {
goto RETURN_STATEMENT;

}

} else {
// FolioCancelFromEntry2
localVars.resFolioCancelFromEntry2.outParamo_Output = await Actions.ActionFolioCancelFromEntry(requestContext,localVars.varLcFolioId,localVars.inParamEntryDoc,cancellationToken);

}

// GetOrderItemEntries
localVars.resGetOrderItemEntries_outParamRecord = await ExtendedActions.GetOrderItemEntries(requestContext,localVars.inParamOrderItemEntriesId,cancellationToken);

// Set CancelOrder = true
// GetOrderItemEntries.Record.OrderItemEntries.RejectFolio = True
localVars.resGetOrderItemEntries_outParamRecord.ssENOrderItemEntries.ssRejectFolio = true;
// UpdateOrderItemEntries
await ExtendedActions.UpdateOrderItemEntries(requestContext,localVars.resGetOrderItemEntries_outParamRecord.ChangedAttributes,localVars.resGetOrderItemEntries_outParamRecord,cancellationToken);

// o_IsRejectFolio = True
result.outParamo_IsRejectFolio=true;
} //close CreateActionActivity using block
} // try

finally {
outParamo_IsRejectFolio = result.outParamo_IsRejectFolio;
} // inner-finally
RETURN_STATEMENT:
return outParamo_IsRejectFolio;
}

public static class FuncActionOrder_SAPNewEntryChangeCancel {

private static async Task<RC_77e758d8dd6b0d691548b18323e10e77> datasetGetFolioByEntryReadDbAsync(RC_77e758d8dd6b0d691548b18323e10e77 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolio.Read( r, ref index);
rec.ssENFolioSAPData.Read( r, ref index);
return rec;
}
// Query Function "GetFolioByEntry" mqF6X_lvOEKggGY5itzzDQ of Action "Order_SAPNewEntryChangeCancel"
public static async Task<(RL_2b9a8ce7bf73dacd0e0e114719f57b83,long)> datasetGetFolioByEntry(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteFolioSAPData_PO_DOCUMENTO_MATERIAL_EM,string qpteFolioSAPData_PO_EJERCICIO_EM,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("Order_SAPNewEntryChangeCancel.GetFolioByEntry", "5f7aa19a-6ff9-4238-a080-66398adcf30d");
using var queryActivity = activitySource.CreateAggregateQueryActivity("Order_SAPNewEntryChangeCancel.GetFolioByEntry", "5f7aa19a-6ff9-4238-a080-66398adcf30d", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.0vkqlEP5e0e4tGeRyL3PNQ/NodesNotShownInESpaceTree.mqF6X_lvOEKggGY5itzzDQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enfolio32\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34");
fromBuilder.Append(" FROM ({Folio} \"enfolio32\" Left JOIN {FolioSAPData} \"enfoliosapdata6\" ON (\"enfolio32\".\"id\" = \"enfoliosapdata6\".\"folioid\")) ");
whereBuilder.Append(" WHERE (\"enfoliosapdata6\".\"po_documento_material_em\" = @qpteFolioSAPData_PO_DOCUMENTO_MATERIAL_EM) AND (\"enfoliosapdata6\".\"po_ejercicio_em\" = @qpteFolioSAPData_PO_EJERCICIO_EM) AND ((\"enfolio32\".\"foliostatusid\" <> ");
whereBuilder.Append((ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("cklscJNc0UyOgKXGwg51TQ"))).ssId);
whereBuilder.Append(") AND (\"enfolio32\".\"foliostatusid\" <> ");
whereBuilder.Append((ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("l5OG661dZEe+gAZwnNLhSA"))).ssId);
whereBuilder.Append("))");
sqlCmd.CreateParameterWithoutReplacements("@qpteFolioSAPData_PO_DOCUMENTO_MATERIAL_EM", DbType.String, qpteFolioSAPData_PO_DOCUMENTO_MATERIAL_EM);
sqlCmd.CreateParameterWithoutReplacements("@qpteFolioSAPData_PO_EJERCICIO_EM", DbType.String, qpteFolioSAPData_PO_EJERCICIO_EM);
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
outParamList.AlternateReadDbMethodAsync = datasetGetFolioByEntryReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query Order_SAPNewEntryChangeCancel.GetFolioByEntry.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_2b9a8ce7bf73dacd0e0e114719f57b83 _tmp = new RL_2b9a8ce7bf73dacd0e0e114719f57b83();
_tmp.AlternateReadDbMethodAsync = datasetGetFolioByEntryReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query Order_SAPNewEntryChangeCancel.GetFolioByEntry.List", cancellationToken: cancellationToken);
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

private static async Task<RC_a23c38bc44b370f52521e410e49fc2ac> datasetGetFolioByUUIDReadDbAsync(RC_a23c38bc44b370f52521e410e49fc2ac rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolio.Read( r, ref index);
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceExtended.Read( r, ref index);
return rec;
}
// Query Function "GetFolioByUUID" LecvnS4AnUG+_TF_qKRsDQ of Action "Order_SAPNewEntryChangeCancel"
public static async Task<(RL_547e7f54f784bcf7e09ead39e9929460,long)> datasetGetFolioByUUID(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteInvoiceExtended_UUID,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("Order_SAPNewEntryChangeCancel.GetFolioByUUID", "9d2fe72d-002e-419d-befd-317fa8a46c0d");
using var queryActivity = activitySource.CreateAggregateQueryActivity("Order_SAPNewEntryChangeCancel.GetFolioByUUID", "9d2fe72d-002e-419d-befd-317fa8a46c0d", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.0vkqlEP5e0e4tGeRyL3PNQ/NodesNotShownInESpaceTree.LecvnS4AnUG+_TF_qKRsDQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enfolio33\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62");
fromBuilder.Append(" FROM (({InvoiceExtended} \"eninvoiceextended10\" Inner JOIN {Invoice} \"eninvoice40\" ON (\"eninvoiceextended10\".\"id\" = \"eninvoice40\".\"id\"))  Inner JOIN {Folio} \"enfolio33\" ON (\"eninvoice40\".\"folioid\" = \"enfolio33\".\"id\")) ");
whereBuilder.Append(" WHERE ((trim(\"eninvoiceextended10\".\"uuid\")) = (trim(@qpteInvoiceExtended_UUID))) AND ((\"enfolio33\".\"foliostatusid\" <> ");
whereBuilder.Append((ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("cklscJNc0UyOgKXGwg51TQ"))).ssId);
whereBuilder.Append(") AND (\"enfolio33\".\"foliostatusid\" <> ");
whereBuilder.Append((ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("l5OG661dZEe+gAZwnNLhSA"))).ssId);
whereBuilder.Append("))");
sqlCmd.CreateParameterWithoutReplacements("@qpteInvoiceExtended_UUID", DbType.String, qpteInvoiceExtended_UUID);
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
RL_547e7f54f784bcf7e09ead39e9929460 outParamList = new RL_547e7f54f784bcf7e09ead39e9929460();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFolioByUUIDReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query Order_SAPNewEntryChangeCancel.GetFolioByUUID.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_547e7f54f784bcf7e09ead39e9929460 _tmp = new RL_547e7f54f784bcf7e09ead39e9929460();
_tmp.AlternateReadDbMethodAsync = datasetGetFolioByUUIDReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query Order_SAPNewEntryChangeCancel.GetFolioByUUID.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_547e7f54f784bcf7e09ead39e9929460)_tmp;
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
