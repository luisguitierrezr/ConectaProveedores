namespace ssConectaProveedores;

public partial class Actions {
public class lcvOrder_SAPSaveFolioEntry : VarsBag {
public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord inParamOrderMain;
public string inParamUUID;
public string inParamEntryDocument;
public string inParamEntryYear;
/// <summary>
/// Variable <code>FolioSAPData</code> that represents the Service Studio FolioSAPData
///  <code>FolioSAPData</code> <p>Description: </p>
/// </summary>
public EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord varLcFolioSAPData = new EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord();

public Actions.lcoFolioSAPData_CreateOrUpdate resFolioSAPData_CreateOrUpdate =  new Actions.lcoFolioSAPData_CreateOrUpdate();
public RL_efc8890c0dc23aed40151f44dac99602 queryResGetInvoicesByOrderMainIdUUID_outParamList = new RL_efc8890c0dc23aed40151f44dac99602();
public long queryResGetInvoicesByOrderMainIdUUID_outParamCount = 0L;

public lcvOrder_SAPSaveFolioEntry(EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord inParamOrderMain, string inParamUUID, string inParamEntryDocument, string inParamEntryYear) {
this.inParamOrderMain = inParamOrderMain;
this.inParamUUID = inParamUUID;
this.inParamEntryDocument = inParamEntryDocument;
this.inParamEntryYear = inParamEntryYear;
}
}
/// <summary>
/// Action <code>Order_SAPSaveFolioEntry</code> that represents the Service Studio action
///  <code>Order_SAPSaveFolioEntry</code> <p> Description: </p>
/// </summary>
public static async Task ActionOrder_SAPSaveFolioEntry(IRequestContext requestContext,EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord inParamOrderMain,string inParamUUID,string inParamEntryDocument,string inParamEntryYear,CancellationToken cancellationToken) {
lcvOrder_SAPSaveFolioEntry localVars = new lcvOrder_SAPSaveFolioEntry(inParamOrderMain, inParamUUID, inParamEntryDocument, inParamEntryYear);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("Order_SAPSaveFolioEntry", "f4dc54c6-89ae-4230-80c3-3e9c5061c6c0"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("Order_SAPSaveFolioEntry", "f4dc54c6-89ae-4230-80c3-3e9c5061c6c0", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetInvoicesByOrderMainIdUUID
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoicesByOrderMainIdUUID_maxRecords = 1;
if (datasetGetInvoicesByOrderMainIdUUID_maxRecords < 1) datasetGetInvoicesByOrderMainIdUUID_maxRecords = 1;
int datasetGetInvoicesByOrderMainIdUUID_startIndex = 0;(localVars.queryResGetInvoicesByOrderMainIdUUID_outParamList,localVars.queryResGetInvoicesByOrderMainIdUUID_outParamCount) = await FuncActionOrder_SAPSaveFolioEntry.datasetGetInvoicesByOrderMainIdUUID(requestContext,datasetGetInvoicesByOrderMainIdUUID_maxRecords,datasetGetInvoicesByOrderMainIdUUID_startIndex,IterationMultiplicity.Never,localVars.inParamOrderMain.ssId,localVars.inParamUUID,cancellationToken);

// empty
if((!(localVars.queryResGetInvoicesByOrderMainIdUUID_outParamList.Empty))) {
// FolioSAPData = GetInvoicesByOrderMainIdUUID.List.Current.FolioSAPData
localVars.varLcFolioSAPData=localVars.queryResGetInvoicesByOrderMainIdUUID_outParamList.CurrentRec.ssENFolioSAPData;

// FolioSAPData.PO_DOCUMENTO_MATERIAL_EM = EntryDocument
localVars.varLcFolioSAPData.ssPO_DOCUMENTO_MATERIAL_EM = localVars.inParamEntryDocument;

// FolioSAPData.PO_EJERCICIO_EM = EntryYear
localVars.varLcFolioSAPData.ssPO_EJERCICIO_EM = localVars.inParamEntryYear;
// new
if(((localVars.queryResGetInvoicesByOrderMainIdUUID_outParamList.CurrentRec.ssENFolioSAPData.ssId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// set new vars
// FolioSAPData.CreatedOn = CurrDateTime
localVars.varLcFolioSAPData.ssCreatedOn = BuiltInFunction.CurrDateTime ();

// FolioSAPData.CreatedBy = GetUserId
localVars.varLcFolioSAPData.ssCreatedBy = BuiltInFunction.GetUserId ();

// FolioSAPData.Service = "SAP Entry Update"
localVars.varLcFolioSAPData.ssService = AppUtils.GetStringResource("Argdm1aIAEim1fGC26BQSQ#Value.1798475797.1", "SAP Entry Update");

// FolioSAPData.FolioId = GetInvoicesByOrderMainIdUUID.List.Current.Invoice.FolioId
localVars.varLcFolioSAPData.ssFolioId = localVars.queryResGetInvoicesByOrderMainIdUUID_outParamList.CurrentRec.ssENInvoice.ssFolioId;
}

// FolioSAPData_CreateOrUpdate
localVars.resFolioSAPData_CreateOrUpdate.outParamId = await Actions.ActionFolioSAPData_CreateOrUpdate(requestContext,localVars.varLcFolioSAPData,cancellationToken);

}

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionOrder_SAPSaveFolioEntry {

private static async Task<RC_93224f6033b2fcf15869e73d67c629f2> datasetGetInvoicesByOrderMainIdUUIDReadDbAsync(RC_93224f6033b2fcf15869e73d67c629f2 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolio.Read( r, ref index);
rec.ssENFolioSAPData.Read( r, ref index);
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceExtended.Read( r, ref index);
return rec;
}
// Query Function "GetInvoicesByOrderMainIdUUID" RcIq5rknnEygYq+51zGyCw of Action "Order_SAPSaveFolioEntry"
public static async Task<(RL_efc8890c0dc23aed40151f44dac99602,long)> datasetGetInvoicesByOrderMainIdUUID(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporInvoice_OrderMainId,string qpteInvoiceExtended_UUID,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("Order_SAPSaveFolioEntry.GetInvoicesByOrderMainIdUUID", "e62ac245-27b9-4c9c-a062-afb9d731b20b");
using var queryActivity = activitySource.CreateAggregateQueryActivity("Order_SAPSaveFolioEntry.GetInvoicesByOrderMainIdUUID", "e62ac245-27b9-4c9c-a062-afb9d731b20b", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.xlTc9K6JMEKAwz6cUGHGwA/NodesNotShownInESpaceTree.RcIq5rknnEygYq+51zGyCw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, \"enfoliosapdata11\".\"id\" o20, \"enfoliosapdata11\".\"folioid\" o21, \"enfoliosapdata11\".\"service\" o22, NULL o23, \"enfoliosapdata11\".\"po_documento_material_sm\" o24, \"enfoliosapdata11\".\"po_documento_material_221\" o25, \"enfoliosapdata11\".\"po_documento_material_415\" o26, NULL o27, \"enfoliosapdata11\".\"po_ejercicio_sm\" o28, \"enfoliosapdata11\".\"po_ejercicio_221\" o29, \"enfoliosapdata11\".\"po_ejercicio_415\" o30, \"enfoliosapdata11\".\"po_folio_agrupados\" o31, \"enfoliosapdata11\".\"po_resultado\" o32, \"enfoliosapdata11\".\"createdby\" o33, \"enfoliosapdata11\".\"createdon\" o34, NULL o35, NULL o36, NULL o37, \"eninvoice75\".\"folioid\" o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77");
fromBuilder.Append(" FROM ((({Invoice} \"eninvoice75\" Left JOIN {InvoiceExtended} \"eninvoiceextended19\" ON (\"eninvoice75\".\"id\" = \"eninvoiceextended19\".\"id\"))  Left JOIN {Folio} \"enfolio56\" ON (\"eninvoice75\".\"folioid\" = \"enfolio56\".\"id\"))  Left JOIN {FolioSAPData} \"enfoliosapdata11\" ON (\"enfolio56\".\"id\" = \"enfoliosapdata11\".\"folioid\")) ");
whereBuilder.Append(" WHERE ");
if (qporInvoice_OrderMainId != 0) {
whereBuilder.Append("((\"eninvoice75\".\"ordermainid\" = @qporInvoice_OrderMainId) AND (\"eninvoice75\".\"ordermainid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporInvoice_OrderMainId", DbType.Int64, qporInvoice_OrderMainId);
} else {
whereBuilder.Append("(\"eninvoice75\".\"ordermainid\" IS NULL)");
}
whereBuilder.Append(" AND (\"eninvoiceextended19\".\"uuid\" = @qpteInvoiceExtended_UUID)");
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
RL_efc8890c0dc23aed40151f44dac99602 outParamList = new RL_efc8890c0dc23aed40151f44dac99602();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoicesByOrderMainIdUUIDReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[4];
opt[0] = new BitArray(new bool[] {false, false, false, true, false, false, false, true, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query Order_SAPSaveFolioEntry.GetInvoicesByOrderMainIdUUID.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_efc8890c0dc23aed40151f44dac99602 _tmp = new RL_efc8890c0dc23aed40151f44dac99602();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoicesByOrderMainIdUUIDReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query Order_SAPSaveFolioEntry.GetInvoicesByOrderMainIdUUID.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_efc8890c0dc23aed40151f44dac99602)_tmp;
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
