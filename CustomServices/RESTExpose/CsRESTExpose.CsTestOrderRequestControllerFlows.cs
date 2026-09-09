using System.Diagnostics;
using ssConectaProveedores;

namespace ssConectaProveedores.CsRESTExpose.CsTestOrderRequest;

public class CsTestOrderRequestControllerFlows {
    private static readonly ActivitySource activitySource = new(typeof(CsTestOrderRequestControllerFlows).Namespace);
public class lcvGetOrderRequest : VarsBag {
public string inParamOrderNumber;
public RL_3fb912307e41f6b8b38356a7f29b5100 queryResGetOrderMainsByOrderNumber_outParamList = new RL_3fb912307e41f6b8b38356a7f29b5100();
public long queryResGetOrderMainsByOrderNumber_outParamCount = 0L;

public RL_0c15a16c4feb962d6b5de596c77ba175 queryResGetOrderMainItemsByOrderMainId_outParamList = new RL_0c15a16c4feb962d6b5de596c77ba175();
public long queryResGetOrderMainItemsByOrderMainId_outParamCount = 0L;

public lcvGetOrderRequest(string inParamOrderNumber) {
this.inParamOrderNumber = inParamOrderNumber;
}
}
public class lcoGetOrderRequest : VarsBag {
public ST_9c87dd52bd762501ef8a064794927f08Structure outParamResponse = new ST_9c87dd52bd762501ef8a064794927f08Structure();

public lcoGetOrderRequest() {
}
}
/// <summary>
/// Action <code>GetOrderRequest</code> that represents the Service Studio action
///  <code>GetOrderRequest</code> <p> Description: GetOrderRequest</p>
/// </summary>
public static async Task<ST_9c87dd52bd762501ef8a064794927f08Structure> FlowTestOrderRequestActionGetOrderRequest(IRequestContext requestContext,string inParamOrderNumber,CancellationToken cancellationToken) {
ST_9c87dd52bd762501ef8a064794927f08Structure outParamResponse = default;
lcoGetOrderRequest result = new lcoGetOrderRequest();
lcvGetOrderRequest localVars = new lcvGetOrderRequest(inParamOrderNumber);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateRestExposeActionMetric("GetOrderRequest", "3267a900-f08f-4330-aea4-ece3a5e034fb"))
using (activitySource.CreateCustomActionActivity("REST (Expose)", "GetOrderRequest", "3267a900-f08f-4330-aea4-ece3a5e034fb", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828")){
// Query datasetGetOrderMainsByOrderNumber
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderMainsByOrderNumber_maxRecords = 1;
if (datasetGetOrderMainsByOrderNumber_maxRecords < 1) datasetGetOrderMainsByOrderNumber_maxRecords = 1;
int datasetGetOrderMainsByOrderNumber_startIndex = 0;(localVars.queryResGetOrderMainsByOrderNumber_outParamList,localVars.queryResGetOrderMainsByOrderNumber_outParamCount) = await FuncFlowTestOrderRequestActionGetOrderRequest.datasetGetOrderMainsByOrderNumber(requestContext,datasetGetOrderMainsByOrderNumber_maxRecords,datasetGetOrderMainsByOrderNumber_startIndex,IterationMultiplicity.Never,localVars.inParamOrderNumber,cancellationToken);

// Response = GetOrderMainsByOrderNumber.List.Current
result.outParamResponse=(await RecordUtils.ConvertAsync(localVars.queryResGetOrderMainsByOrderNumber_outParamList.CurrentRec, new ST_9c87dd52bd762501ef8a064794927f08Structure(), async (RC_42267450aa26a79fb0f0cba424ccbea3 source, ST_9c87dd52bd762501ef8a064794927f08Structure target, CancellationToken cancellationToken) => {
target.ssOrderNumber = localVars.inParamOrderNumber;
target.ssCompanyCode = source.ssENCompany.ssDescription;
target.ssClassDocument = source.ssENDocumentType.ssClasse;
target.ssDeletedIndicator = ((source.ssENOrderMain.ssIsDeleted) ? ("Y") : ("N"));
target.ssOrderDate = BuiltInFunction.DateToText(source.ssENOrderMain.ssOrderDate);
target.ssSupplierNumber = source.ssENSupplier.ssNumber;
target.ssSupplierName = source.ssENSupplier.ssName;
target.ssProcurementGroup = source.ssENOrderMain.ssProcurementGroup;
target.ssCreatedBy = BuiltInFunction.FormatDateTime (localVars.queryResGetOrderMainsByOrderNumber_outParamList.CurrentRec.ssENOrderMain.ssCreatedOn, "ddMMyyyy");
target.ssCreatedByName = source.ssENUser.ssName;
target.ssCountryCode = source.ssENOrderMain.ssCountry;
target.ssReleased = ((source.ssENOrderMain.ssIsReleased) ? ("S") : ("X"));
target.ssExchangeRate = source.ssENOrderMain.ssExchangeRate;
target.ssCurrencyCode = source.ssENCurrency.ssSymbol;
target.ssSustainabilityCategory = source.ssENOrderMain.ssSustainabilityCategory;
target.ssSustainabilitySubcategory = source.ssENOrderMain.ssSustainabilitySubcategory;
return target;
}, cancellationToken));
// empty
if((!(localVars.queryResGetOrderMainsByOrderNumber_outParamList.Empty))) {
// Query datasetGetOrderMainItemsByOrderMainId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderMainItemsByOrderMainId_maxRecords = 0;
int datasetGetOrderMainItemsByOrderMainId_startIndex = 0;(localVars.queryResGetOrderMainItemsByOrderMainId_outParamList,localVars.queryResGetOrderMainItemsByOrderMainId_outParamCount) = await FuncFlowTestOrderRequestActionGetOrderRequest.datasetGetOrderMainItemsByOrderMainId(requestContext,datasetGetOrderMainItemsByOrderMainId_maxRecords,datasetGetOrderMainItemsByOrderMainId_startIndex,IterationMultiplicity.Single,localVars.queryResGetOrderMainsByOrderNumber_outParamList.CurrentRec.ssENOrderMain.ssId,cancellationToken);

// Response.OrderItems = GetOrderMainItemsByOrderMainId.List
result.outParamResponse.ssOrderItems = (await RL_5a5dc4e5843197429d3408a507236d6a.ConvertAsync(localVars.queryResGetOrderMainItemsByOrderMainId_outParamList, new RL_5a5dc4e5843197429d3408a507236d6a(), async (RC_64471b6df37f8aec653dbc381bfea212 source, ST_602b1becf0e261abf8529c8c55991799Structure target, CancellationToken cancellationToken) => {
target.ssPosition = source.ssENOrderMainItem.ssPosition;
target.ssArticleNr = source.ssENOrderMainItem.ssMaterialCode;
target.ssArticleDescription = source.ssENOrderMainItem.ssMaterialDescription;
target.ssImputationCode = (((source.ssENOrderMainItem.ssAssigmnentCode!="")) ? (source.ssENOrderMainItem.ssAssigmnentCode) : ("N/A"));
target.ssDocumentClass = source.ssENDocumentType.ssClasse;
target.ssDeliveryDate = BuiltInFunction.DateToText(source.ssENOrderMainItem.ssDeliveryDate);
target.ssQuantity = source.ssENOrderMainItem.ssQuantity;
target.ssUnitType = source.ssENOrderMainItem.ssUnitType;
target.ssUnitPrice = source.ssENOrderMainItem.ssUnitPrice;
target.ssBaseQuantity = source.ssENOrderMainItem.ssBaseQuantity;
target.ssChangeIndicator = ((source.ssENOrderMainItem.ssIsDeleted) ? ("X") : (((source.ssENOrderMainItem.ssIsBlocked) ? ("B") : (""))));
target.ssFinalDelivery = ((source.ssENOrderMainItem.ssIsFinalDelivery) ? ("X") : (" "));
target.ssGLAccountNumber = source.ssENAccountingAccounts_ServiceType.ssCC;
target.ssCostCenter = source.ssENCostCenterSAP.ssDenominacion;
target.ssFundsCenter = source.ssENOrderMainItem.ssFundsCenter;
target.ssFund = source.ssENOrderMainItem.ssFund;
target.ssCommitmentItem = source.ssENOrderMainItem.ssCommitmentItem;
target.ssVATIndicator = source.ssENOrderMainItem.ssVATIndicator;
target.ssVATProcedure = source.ssENOrderMainItem.ssVATProcedure;
target.ssVATRate = source.ssENOrderMainItem.ssVATRate;
target.ssPurchaseRequisitionNumber = source.ssENOrderMainItem.ssPurchaseRequisitionNumber;
target.ssPurchaseRequisitionItemNumber = source.ssENOrderMainItem.ssPurchaseRequisitionItemNr;
target.ssPEPElement = (((source.ssENOrderMainItem.ssPEPElement!="")) ? (source.ssENOrderMainItem.ssPEPElement) : ("N/A"));
target.ssDeliveredQuantity = source.ssENOrderMainItem.ssQuantityDelivered;
target.ssApplicant = source.ssENOrderMainItem.ssApplicant;
target.ssDirection = source.ssENOrderMainItem.ssDirection;
target.ssContractNumber = source.ssENOrderMainItem.ssContractNumber;
target.ssContractPosition = source.ssENOrderMainItem.ssContractPosition;
target.ssContractStartDate = BuiltInFunction.DateToText(source.ssENOrderMainItem.ssContractStartDate);
target.ssContractEndDate = BuiltInFunction.DateToText(source.ssENOrderMainItem.ssContractEndDate);
target.ssContractPlannedValue = source.ssENOrderMainItem.ssContractPlannedValue;
target.ssPositionType = source.ssENOrderMainItem.ssPositionType;
target.ssSerialNumberProfile = source.ssENOrderMainItem.ssSerialNumberProfile;
target.ssBatchManaged = source.ssENOrderMainItem.ssBatchManaged;
target.ssMaterialType = source.ssENOrderMainItem.ssMaterialType;
target.ssItemGroup = source.ssENOrderMainItem.ssItemGroup;
return target;
}, cancellationToken));
}

} //close CreateActionActivity using block
} // try

finally {
outParamResponse = result.outParamResponse;
} // inner-finally
RETURN_STATEMENT:
return outParamResponse;
}

public static class FuncFlowTestOrderRequestActionGetOrderRequest {

private static async Task<RC_42267450aa26a79fb0f0cba424ccbea3> datasetGetOrderMainsByOrderNumberReadDbAsync(RC_42267450aa26a79fb0f0cba424ccbea3 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENCompany.Read( r, ref index);
rec.ssENCurrency.Read( r, ref index);
rec.ssENDocumentType.Read( r, ref index);
rec.ssENOrderDetail.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
return rec;
}
// Query Function "GetOrderMainsByOrderNumber" 13XPEb8YKkWYHH9l0Tl6Bg of Action "GetOrderRequest"
public static async Task<(RL_3fb912307e41f6b8b38356a7f29b5100,long)> datasetGetOrderMainsByOrderNumber(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteOrderMain_OrderNumber,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("TestOrderRequest.GetOrderRequest.GetOrderMainsByOrderNumber", "11cf75d7-18bf-452a-981c-7f65d1397a06");
using var queryActivity = activitySource.CreateAggregateQueryActivity("TestOrderRequest.GetOrderRequest.GetOrderMainsByOrderNumber", "11cf75d7-18bf-452a-981c-7f65d1397a06", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /CustomServices.ajU7xAfbdUi+AqfMb1DGDg/CustomActionFlows.AKlnMo_wMEOupOzjpeA0+w/NodesNotShownInESpaceTree.13XPEb8YKkWYHH9l0Tl6Bg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"encompany22\".\"description\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, \"encurrency8\".\"symbol\" o13, NULL o14, NULL o15, NULL o16, \"endocumenttype\".\"classe\" o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, \"enordermain78\".\"id\" o62, NULL o63, \"enordermain78\".\"orderdate\" o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, \"enordermain78\".\"procurementgroup\" o73, NULL o74, NULL o75, \"enordermain78\".\"country\" o76, \"enordermain78\".\"isdeleted\" o77, \"enordermain78\".\"isreleased\" o78, trim_scale(\"enordermain78\".\"exchangerate\"::numeric) o79, \"enordermain78\".\"sustainabilitycategory\" o80, \"enordermain78\".\"sustainabilitysubcategory\" o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, \"enordermain78\".\"createdon\" o88, NULL o89, NULL o90, NULL o91, NULL o92, \"ensupplier60\".\"name\" o93, \"ensupplier60\".\"number\" o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, NULL o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, NULL o118, NULL o119, \"enuser149\".\"name\" o120, NULL o121, NULL o122, NULL o123");
fromBuilder.Append(" FROM (((((({OrderMain} \"enordermain78\" Inner JOIN {Company} \"encompany22\" ON (\"enordermain78\".\"companyid\" = \"encompany22\".\"id\"))  Inner JOIN {Supplier} \"ensupplier60\" ON (\"enordermain78\".\"supplierid\" = \"ensupplier60\".\"id\"))  Left JOIN {OrderDetail} \"enorderdetail10\" ON (\"enordermain78\".\"id\" = \"enorderdetail10\".\"orderid\"))  Left JOIN {DocumentType} \"endocumenttype\" ON (\"enordermain78\".\"documenttypeid\" = \"endocumenttype\".\"id\"))  Left JOIN {User} \"enuser149\" ON (\"enordermain78\".\"createdby\" = \"enuser149\".\"id\"))  Left JOIN {Currency} \"encurrency8\" ON (\"enordermain78\".\"currencyid\" = \"encurrency8\".\"code\")) ");
whereBuilder.Append(" WHERE (\"enordermain78\".\"ordernumber\" = @qpteOrderMain_OrderNumber)");
sqlCmd.CreateParameterWithoutReplacements("@qpteOrderMain_OrderNumber", DbType.String, qpteOrderMain_OrderNumber);
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
RL_3fb912307e41f6b8b38356a7f29b5100 outParamList = new RL_3fb912307e41f6b8b38356a7f29b5100();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderMainsByOrderNumberReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[7];
opt[0] = new BitArray(new bool[] {true, true, false, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true});
opt[2] = new BitArray(new bool[] {false, true, false, true, true, true, true, true, true, true, true, false, true, true, false, false, false, false, false, false, true, true, true, true, true, true, false, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, false, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, true, false, true, true, true, true, true, true, true, true});
opt[6] = new BitArray(new bool[] {true, true, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query TestOrderRequest.GetOrderRequest.GetOrderMainsByOrderNumber.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_3fb912307e41f6b8b38356a7f29b5100 _tmp = new RL_3fb912307e41f6b8b38356a7f29b5100();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderMainsByOrderNumberReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query TestOrderRequest.GetOrderRequest.GetOrderMainsByOrderNumber.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_3fb912307e41f6b8b38356a7f29b5100)_tmp;
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

private static async Task<RC_64471b6df37f8aec653dbc381bfea212> datasetGetOrderMainItemsByOrderMainIdReadDbAsync(RC_64471b6df37f8aec653dbc381bfea212 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENAccountingAccounts_ServiceType.Read( r, ref index);
rec.ssENCostCenterSAP.Read( r, ref index);
rec.ssENDocumentType.Read( r, ref index);
rec.ssENOrderCostCenter.Read( r, ref index);
rec.ssENOrderMainItem.Read( r, ref index);
return rec;
}
// Query Function "GetOrderMainItemsByOrderMainId" F19Pv+eSy0Sw2+vOR4jG4g of Action "GetOrderRequest"
public static async Task<(RL_0c15a16c4feb962d6b5de596c77ba175,long)> datasetGetOrderMainItemsByOrderMainId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderMainItem_OrderMainId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("TestOrderRequest.GetOrderRequest.GetOrderMainItemsByOrderMainId", "bf4f5f17-92e7-44cb-b0db-ebce4788c6e2");
using var queryActivity = activitySource.CreateAggregateQueryActivity("TestOrderRequest.GetOrderRequest.GetOrderMainItemsByOrderMainId", "bf4f5f17-92e7-44cb-b0db-ebce4788c6e2", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Single
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
selectBuilder.Append("/* /CustomServices.ajU7xAfbdUi+AqfMb1DGDg/CustomActionFlows.AKlnMo_wMEOupOzjpeA0+w/NodesNotShownInESpaceTree.F19Pv+eSy0Sw2+vOR4jG4g, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enaccountingaccounts_servicetype5\".\"cc\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, \"encostcentersap8\".\"denominacion\" o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, \"endocumenttype1\".\"classe\" o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, \"enordermainitem16\".\"position\" o45, \"enordermainitem16\".\"materialcode\" o46, \"enordermainitem16\".\"materialdescription\" o47, \"enordermainitem16\".\"assigmnentcode\" o48, NULL o49, \"enordermainitem16\".\"deliverydate\" o50, trim_scale(\"enordermainitem16\".\"quantity\"::numeric) o51, \"enordermainitem16\".\"unittype\" o52, trim_scale(\"enordermainitem16\".\"unitprice\"::numeric) o53, \"enordermainitem16\".\"basequantity\" o54, \"enordermainitem16\".\"isdeleted\" o55, \"enordermainitem16\".\"isblocked\" o56, \"enordermainitem16\".\"isfinaldelivery\" o57, NULL o58, NULL o59, \"enordermainitem16\".\"fundscenter\" o60, \"enordermainitem16\".\"fund\" o61, \"enordermainitem16\".\"commitmentitem\" o62, \"enordermainitem16\".\"vatindicator\" o63, \"enordermainitem16\".\"vatprocedure\" o64, trim_scale(\"enordermainitem16\".\"vatrate\"::numeric) o65, \"enordermainitem16\".\"purchaserequisitionnumber\" o66, \"enordermainitem16\".\"purchaserequisitionitemnr\" o67, NULL o68, NULL o69, \"enordermainitem16\".\"pepelement\" o70, trim_scale(\"enordermainitem16\".\"quantitydelivered\"::numeric) o71, NULL o72, \"enordermainitem16\".\"applicant\" o73, \"enordermainitem16\".\"direction\" o74, \"enordermainitem16\".\"contractnumber\" o75, \"enordermainitem16\".\"contractposition\" o76, \"enordermainitem16\".\"contractstartdate\" o77, \"enordermainitem16\".\"contractenddate\" o78, trim_scale(\"enordermainitem16\".\"contractplannedvalue\"::numeric) o79, \"enordermainitem16\".\"positiontype\" o80, \"enordermainitem16\".\"serialnumberprofile\" o81, \"enordermainitem16\".\"batchmanaged\" o82, \"enordermainitem16\".\"materialtype\" o83, \"enordermainitem16\".\"itemgroup\" o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93");
fromBuilder.Append(" FROM (((({OrderMainItem} \"enordermainitem16\" Left JOIN {DocumentType} \"endocumenttype1\" ON (\"enordermainitem16\".\"documentclassid\" = \"endocumenttype1\".\"id\"))  Left JOIN {AccountingAccounts_ServiceType} \"enaccountingaccounts_servicetype5\" ON (\"enordermainitem16\".\"glaccountid\" = \"enaccountingaccounts_servicetype5\".\"id\"))  Left JOIN {CostCenterSAP} \"encostcentersap8\" ON (\"enordermainitem16\".\"costcenterid\" = \"encostcentersap8\".\"id\"))  Left JOIN {OrderCostCenter} \"enordercostcenter\" ON (\"encostcentersap8\".\"id\" = \"enordercostcenter\".\"costcentersap\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderMainItem_OrderMainId != 0) {
whereBuilder.Append("((\"enordermainitem16\".\"ordermainid\" = @qporOrderMainItem_OrderMainId) AND (\"enordermainitem16\".\"ordermainid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderMainItem_OrderMainId", DbType.Int64, qporOrderMainItem_OrderMainId);
} else {
whereBuilder.Append("(\"enordermainitem16\".\"ordermainid\" IS NULL)");
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
RL_0c15a16c4feb962d6b5de596c77ba175 outParamList = new RL_0c15a16c4feb962d6b5de596c77ba175();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderMainItemsByOrderMainIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[5];
opt[0] = new BitArray(new bool[] {true, true, false, false, false, false, true, false, false, false, false, false, false, false, false, true, true, false, false, false, false, false, false, false, false, true, true, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true});
opt[2] = new BitArray(new bool[] {true, false, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, false, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query TestOrderRequest.GetOrderRequest.GetOrderMainItemsByOrderMainId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_0c15a16c4feb962d6b5de596c77ba175 _tmp = new RL_0c15a16c4feb962d6b5de596c77ba175();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderMainItemsByOrderMainIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query TestOrderRequest.GetOrderRequest.GetOrderMainItemsByOrderMainId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_0c15a16c4feb962d6b5de596c77ba175)_tmp;
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

public class lcvDeleteOrderRequest : VarsBag {
public string inParamOrderNumber;
public RL_339e5fbd74448809f3620bf1c8c54b9a queryResGetOrderMainsByOrderNumber_outParamList = new RL_339e5fbd74448809f3620bf1c8c54b9a();
public long queryResGetOrderMainsByOrderNumber_outParamCount = 0L;

public RLAIItemRecordList queryResDeleteAll_outParamList = new RLAIItemRecordList();
public long queryResDeleteAll_outParamCount = 0L;

public lcvDeleteOrderRequest(string inParamOrderNumber) {
this.inParamOrderNumber = inParamOrderNumber;
}
}
public class lcoDeleteOrderRequest : VarsBag {
public string outParamResponse = "";

public lcoDeleteOrderRequest() {
}
}
/// <summary>
/// Action <code>DeleteOrderRequest</code> that represents the Service Studio action
///  <code>DeleteOrderRequest</code> <p> Description: GetOrderRequest</p>
/// </summary>
public static async Task<string> FlowTestOrderRequestActionDeleteOrderRequest(IRequestContext requestContext,string inParamOrderNumber,CancellationToken cancellationToken) {
string outParamResponse = default;
lcoDeleteOrderRequest result = new lcoDeleteOrderRequest();
lcvDeleteOrderRequest localVars = new lcvDeleteOrderRequest(inParamOrderNumber);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateRestExposeActionMetric("DeleteOrderRequest", "4fcf9560-ad35-4521-9c76-b7feb907fb8b"))
using (activitySource.CreateCustomActionActivity("REST (Expose)", "DeleteOrderRequest", "4fcf9560-ad35-4521-9c76-b7feb907fb8b", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828")){
// Query datasetGetOrderMainsByOrderNumber
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderMainsByOrderNumber_maxRecords = 0;
int datasetGetOrderMainsByOrderNumber_startIndex = 0;(localVars.queryResGetOrderMainsByOrderNumber_outParamList,localVars.queryResGetOrderMainsByOrderNumber_outParamCount) = await FuncFlowTestOrderRequestActionDeleteOrderRequest.datasetGetOrderMainsByOrderNumber(requestContext,datasetGetOrderMainsByOrderNumber_maxRecords,datasetGetOrderMainsByOrderNumber_startIndex,IterationMultiplicity.Never,localVars.inParamOrderNumber,cancellationToken);

// Query QueryDeleteAll
cancellationToken.ThrowIfCancellationRequested();
int QueryDeleteAll_maxRecords = 0;
int QueryDeleteAll_startIndex = 0;(localVars.queryResDeleteAll_outParamList,localVars.queryResDeleteAll_outParamCount) = await FuncFlowTestOrderRequestActionDeleteOrderRequest.QueryDeleteAll(requestContext,QueryDeleteAll_maxRecords,QueryDeleteAll_startIndex,IterationMultiplicity.Never,localVars.queryResGetOrderMainsByOrderNumber_outParamList.CurrentRec.ssENOrderMain.ssId,cancellationToken);

// Response = "OK"
result.outParamResponse="OK";
} //close CreateActionActivity using block
} // try

finally {
outParamResponse = result.outParamResponse;
} // inner-finally
RETURN_STATEMENT:
return outParamResponse;
}

public static class FuncFlowTestOrderRequestActionDeleteOrderRequest {

// Query Function "GetOrderMainsByOrderNumber" Pd73XNFg5Ua3IT0fbflAsQ of Action "DeleteOrderRequest"
public static async Task<(RL_339e5fbd74448809f3620bf1c8c54b9a,long)> datasetGetOrderMainsByOrderNumber(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteOrderNumber,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("TestOrderRequest.DeleteOrderRequest.GetOrderMainsByOrderNumber", "5cf7de3d-60d1-46e5-b721-3d1f6df940b1");
using var queryActivity = activitySource.CreateAggregateQueryActivity("TestOrderRequest.DeleteOrderRequest.GetOrderMainsByOrderNumber", "5cf7de3d-60d1-46e5-b721-3d1f6df940b1", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /CustomServices.ajU7xAfbdUi+AqfMb1DGDg/CustomActionFlows.YJXPTzWtIUWcdrf+uQf7iw/NodesNotShownInESpaceTree.Pd73XNFg5Ua3IT0fbflAsQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enordermain79\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28");
fromBuilder.Append(" FROM {OrderMain} \"enordermain79\"");
whereBuilder.Append(" WHERE (\"enordermain79\".\"ordernumber\" = @qpteOrderNumber)");
sqlCmd.CreateParameterWithoutReplacements("@qpteOrderNumber", DbType.String, qpteOrderNumber);
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
RL_339e5fbd74448809f3620bf1c8c54b9a outParamList = new RL_339e5fbd74448809f3620bf1c8c54b9a();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query TestOrderRequest.DeleteOrderRequest.GetOrderMainsByOrderNumber.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_339e5fbd74448809f3620bf1c8c54b9a _tmp = new RL_339e5fbd74448809f3620bf1c8c54b9a();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query TestOrderRequest.DeleteOrderRequest.GetOrderMainsByOrderNumber.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_339e5fbd74448809f3620bf1c8c54b9a)_tmp;
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

// Query Function "DeleteAll" gLt7kfL0h06CfjUihHUoBg of Action "DeleteOrderRequest"
public static async Task<(RLAIItemRecordList,long)> QueryDeleteAll(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderMainId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("TestOrderRequest.DeleteOrderRequest.DeleteAll", "917bbb80-f4f2-4e87-827e-352284752806");
using var queryActivity = activitySource.CreateSqlQueryActivity("TestOrderRequest.DeleteOrderRequest.DeleteAll", "917bbb80-f4f2-4e87-827e-352284752806", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string entityOrderMain = AppUtils.Instance.RuntimeEntityReplace("OrderMain");
sqlCmd.CreateParameter("@qporOrderMainId", DbType.Int64, qporOrderMainId);
string sql = "";
string advSql = "DELETE FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,"") + " WHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"id\"") + " = @qporOrderMainId";
string[] entitiesToCheck = new[] {"OrderMain"};
AppUtils.Instance.RuntimeCheckReadOnlyEntity(entitiesToCheck);
sql = advSql;
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RLAIItemRecordList outParamList = new RLAIItemRecordList();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query TestOrderRequest.DeleteOrderRequest.DeleteAll.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RLAIItemRecordList _tmp = new RLAIItemRecordList();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query TestOrderRequest.DeleteOrderRequest.DeleteAll.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RLAIItemRecordList)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("DeleteAll in DeleteOrderRequest in TestOrderRequest in ConectaProveedores (DELETE FROM {OrderMain} WHERE {OrderMain}.[Id] = @OrderMainId): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("DeleteAll in DeleteOrderRequest in TestOrderRequest in ConectaProveedores (DELETE FROM {OrderMain} WHERE {OrderMain}.[Id] = @OrderMainId): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("DeleteAll in DeleteOrderRequest in TestOrderRequest in ConectaProveedores (DELETE FROM {OrderMain} WHERE {OrderMain}.[Id] = @OrderMainId): " + aqExcep.Message));
}
}
}



}

public class lcvSetOrderRequestReleased : VarsBag {
public string inParamOrderNumber;
public RL_339e5fbd74448809f3620bf1c8c54b9a queryResGetOrderMainsByOrderNumber_outParamList = new RL_339e5fbd74448809f3620bf1c8c54b9a();
public long queryResGetOrderMainsByOrderNumber_outParamCount = 0L;

public Actions.lcoOrderMainCreateOrUpdate resOrderMainCreateOrUpdate =  new Actions.lcoOrderMainCreateOrUpdate();
public lcvSetOrderRequestReleased(string inParamOrderNumber) {
this.inParamOrderNumber = inParamOrderNumber;
}
}
public class lcoSetOrderRequestReleased : VarsBag {
public string outParamResponse = "";

public lcoSetOrderRequestReleased() {
}
}
/// <summary>
/// Action <code>SetOrderRequestReleased</code> that represents the Service Studio action
///  <code>SetOrderRequestReleased</code> <p> Description: GetOrderRequest</p>
/// </summary>
public static async Task<string> FlowTestOrderRequestActionSetOrderRequestReleased(IRequestContext requestContext,string inParamOrderNumber,CancellationToken cancellationToken) {
string outParamResponse = default;
lcoSetOrderRequestReleased result = new lcoSetOrderRequestReleased();
lcvSetOrderRequestReleased localVars = new lcvSetOrderRequestReleased(inParamOrderNumber);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateRestExposeActionMetric("SetOrderRequestReleased", "fc885aca-c11c-4e4e-9a77-9c932b5b99ba"))
using (activitySource.CreateCustomActionActivity("REST (Expose)", "SetOrderRequestReleased", "fc885aca-c11c-4e4e-9a77-9c932b5b99ba", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828")){
// Query datasetGetOrderMainsByOrderNumber
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderMainsByOrderNumber_maxRecords = 0;
int datasetGetOrderMainsByOrderNumber_startIndex = 0;(localVars.queryResGetOrderMainsByOrderNumber_outParamList,localVars.queryResGetOrderMainsByOrderNumber_outParamCount) = await FuncFlowTestOrderRequestActionSetOrderRequestReleased.datasetGetOrderMainsByOrderNumber(requestContext,datasetGetOrderMainsByOrderNumber_maxRecords,datasetGetOrderMainsByOrderNumber_startIndex,IterationMultiplicity.Never,localVars.inParamOrderNumber,cancellationToken);

// GetOrderMainsByOrderNumber.List.Current.OrderMain.IsReleased = True
localVars.queryResGetOrderMainsByOrderNumber_outParamList.CurrentRec.ssENOrderMain.ssIsReleased = true;

// GetOrderMainsByOrderNumber.List.Current.OrderMain.IsDeleted = False
localVars.queryResGetOrderMainsByOrderNumber_outParamList.CurrentRec.ssENOrderMain.ssIsDeleted = false;
// OrderMainCreateOrUpdate
(localVars.resOrderMainCreateOrUpdate.outParamId,localVars.resOrderMainCreateOrUpdate.outParamHasSuccess,localVars.resOrderMainCreateOrUpdate.outParamErrorMessage,localVars.resOrderMainCreateOrUpdate.outParamSource_Out) = await Actions.ActionOrderMainCreateOrUpdate(requestContext,localVars.queryResGetOrderMainsByOrderNumber_outParamList.CurrentRec.ssENOrderMain,cancellationToken);

// Response = "OK"
result.outParamResponse="OK";
} //close CreateActionActivity using block
} // try

finally {
outParamResponse = result.outParamResponse;
} // inner-finally
RETURN_STATEMENT:
return outParamResponse;
}

public static class FuncFlowTestOrderRequestActionSetOrderRequestReleased {

// Query Function "GetOrderMainsByOrderNumber" Yp8_E_IukkekfJjqoh2jUQ of Action "SetOrderRequestReleased"
public static async Task<(RL_339e5fbd74448809f3620bf1c8c54b9a,long)> datasetGetOrderMainsByOrderNumber(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteOrderNumber,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("TestOrderRequest.SetOrderRequestReleased.GetOrderMainsByOrderNumber", "133f9f62-2ef2-4792-a47c-98eaa21da351");
using var queryActivity = activitySource.CreateAggregateQueryActivity("TestOrderRequest.SetOrderRequestReleased.GetOrderMainsByOrderNumber", "133f9f62-2ef2-4792-a47c-98eaa21da351", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /CustomServices.ajU7xAfbdUi+AqfMb1DGDg/CustomActionFlows.ylqI_BzBTk6ad5yTK1uZug/NodesNotShownInESpaceTree.Yp8_E_IukkekfJjqoh2jUQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enordermain80\".\"id\" o0, \"enordermain80\".\"ordernumber\" o1, \"enordermain80\".\"orderdate\" o2, \"enordermain80\".\"orderstatusid\" o3, \"enordermain80\".\"previousorderstatusid\" o4, \"enordermain80\".\"assignmentcode\" o5, \"enordermain80\".\"supplierid\" o6, \"enordermain80\".\"companyid\" o7, \"enordermain80\".\"documenttypeid\" o8, \"enordermain80\".\"currencyid\" o9, \"enordermain80\".\"telceldirectionid\" o10, \"enordermain80\".\"procurementgroup\" o11, \"enordermain80\".\"creatorsapnumber\" o12, \"enordermain80\".\"creatorsapname\" o13, \"enordermain80\".\"country\" o14, \"enordermain80\".\"isdeleted\" o15, \"enordermain80\".\"isreleased\" o16, trim_scale(\"enordermain80\".\"exchangerate\"::numeric) o17, \"enordermain80\".\"sustainabilitycategory\" o18, \"enordermain80\".\"sustainabilitysubcategory\" o19, trim_scale(\"enordermain80\".\"totalamount\"::numeric) o20, \"enordermain80\".\"fromcosmoz\" o21, \"enordermain80\".\"regionid\" o22, \"enordermain80\".\"divisionid\" o23, \"enordermain80\".\"applicant\" o24, \"enordermain80\".\"createdby\" o25, \"enordermain80\".\"createdon\" o26, \"enordermain80\".\"updatedby\" o27, \"enordermain80\".\"updatedon\" o28");
fromBuilder.Append(" FROM {OrderMain} \"enordermain80\"");
whereBuilder.Append(" WHERE (\"enordermain80\".\"ordernumber\" = @qpteOrderNumber)");
sqlCmd.CreateParameterWithoutReplacements("@qpteOrderNumber", DbType.String, qpteOrderNumber);
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
RL_339e5fbd74448809f3620bf1c8c54b9a outParamList = new RL_339e5fbd74448809f3620bf1c8c54b9a();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query TestOrderRequest.SetOrderRequestReleased.GetOrderMainsByOrderNumber.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_339e5fbd74448809f3620bf1c8c54b9a _tmp = new RL_339e5fbd74448809f3620bf1c8c54b9a();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query TestOrderRequest.SetOrderRequestReleased.GetOrderMainsByOrderNumber.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_339e5fbd74448809f3620bf1c8c54b9a)_tmp;
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
