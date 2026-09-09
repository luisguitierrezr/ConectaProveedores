using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_e_Orders_WB_OrderFinancialFiles_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_e_Orders_WB_OrderFinancialFiles_ScreenModel).Namespace);

    public long inParami_OrderId;
public bool varLcl_ShowPopupFinancial;
public long varLcl_OrderAccConceptsId;
public int varLcl_AccountingDataTypeId;
public bool varLcl_ShowContractPopup;
public long varLcl_OrderContractFile;
public long varLcl_OrderRequestFileIdSelected;
public AggregateRecord<RL_e127e807f43523243e5e4b1203065583> ScreenDataSetGetOrderAccountingsByOrderId;
public AggregateRecord<RL_924196580a3b015839b6fad505120f41> ScreenDataSetGetOrderFileById;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_e_Orders_WB_OrderFinancialFiles_ScreenModel() {
}



    public ConectaProveedores_e_Orders_WB_OrderFinancialFiles_ScreenModel(long inParami_OrderId, bool varLcl_ShowPopupFinancial, long varLcl_OrderAccConceptsId, int varLcl_AccountingDataTypeId, bool varLcl_ShowContractPopup, long varLcl_OrderContractFile, long varLcl_OrderRequestFileIdSelected, AggregateRecord<RL_e127e807f43523243e5e4b1203065583> ScreenDataSetGetOrderAccountingsByOrderId, AggregateRecord<RL_924196580a3b015839b6fad505120f41> ScreenDataSetGetOrderFileById, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"i_OrderId", "l_ShowPopupFinancial", "l_OrderAccConceptsId", "l_AccountingDataTypeId", "l_ShowContractPopup", "l_OrderContractFile", "l_OrderRequestFileIdSelected", "GetOrderAccountingsByOrderId", "GetOrderFileById", "ClientVars"}, new string[] {"inParami_OrderId", "varLcl_ShowPopupFinancial", "varLcl_OrderAccConceptsId", "varLcl_AccountingDataTypeId", "varLcl_ShowContractPopup", "varLcl_OrderContractFile", "varLcl_OrderRequestFileIdSelected", "ScreenDataSetGetOrderAccountingsByOrderId", "ScreenDataSetGetOrderFileById", "clientVariables"});
this.inParami_OrderId = inParami_OrderId;
this.varLcl_ShowPopupFinancial = varLcl_ShowPopupFinancial;
this.varLcl_OrderAccConceptsId = varLcl_OrderAccConceptsId;
this.varLcl_AccountingDataTypeId = varLcl_AccountingDataTypeId;
this.varLcl_ShowContractPopup = varLcl_ShowContractPopup;
this.varLcl_OrderContractFile = varLcl_OrderContractFile;
this.varLcl_OrderRequestFileIdSelected = varLcl_OrderRequestFileIdSelected;
this.ScreenDataSetGetOrderAccountingsByOrderId = ScreenDataSetGetOrderAccountingsByOrderId;
this.ScreenDataSetGetOrderFileById = ScreenDataSetGetOrderFileById;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_2563c789f5f898fb1c6cb65b6b599fae> datasetGetOrderAccountingsByOrderIdReadDbAsync(RC_2563c789f5f898fb1c6cb65b6b599fae rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENAccountingDataType.Read( r, ref index);
rec.ssENCurrency.Read( r, ref index);
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceStatus.Read( r, ref index);
rec.ssENOrderAccConcepts.Read( r, ref index);
rec.ssENOrderAccounting.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssENOrderRequestFile.Read( r, ref index);
return rec;
}
// Query Function "GetOrderAccountingsByOrderId" 5Kyc3flO4EmfXs1mOAwzIw of Action "WB_OrderFinancialFiles"
public static async Task<(RL_e127e807f43523243e5e4b1203065583,long)> datasetGetOrderAccountingsByOrderId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderAccounting_OrderId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.WB_OrderFinancialFiles.GetOrderAccountingsByOrderId", "dd9cace4-4ef9-49e0-9f5e-cd66380c3323");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("WB_OrderFinancialFiles","e_Orders.WB_OrderFinancialFiles.GetOrderAccountingsByOrderId");
// Query Iterations: Multiple
// Refresh Query v285JRp_mUeroEaSGMyyaA Iterations: Multiple
// Refresh Query pNIzrgsX6U+3nGCJOIkp3w Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.1Xr7QfvhHU2QT1LDu+YkwQ/ScreenDataSets.5Kyc3flO4EmfXs1mOAwzIw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enaccountingdatatype9\".\"label\" o1, NULL o2, NULL o3, NULL o4, \"encurrency13\".\"code\" o5, NULL o6, NULL o7, NULL o8, NULL o9, \"eninvoice131\".\"id\" o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, \"eninvoice131\".\"invoicestatusid\" o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, \"eninvoicestatus13\".\"label\" o35, \"eninvoicestatus13\".\"class\" o36, NULL o37, NULL o38, NULL o39, NULL o40, \"enorderaccconcepts12\".\"id\" o41, NULL o42, \"enorderaccconcepts12\".\"accountingdatatypeid\" o43, NULL o44, trim_scale(\"enorderaccconcepts12\".\"amount\"::numeric) o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, \"enorderaccconcepts12\".\"paymentdate\" o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, \"enorderrequestfile11\".\"id\" o103, NULL o104, \"enorderrequestfile11\".\"invoiceid\" o105, NULL o106, \"enorderrequestfile11\".\"storageid\" o107, NULL o108, \"enorderrequestfile11\".\"needsapproval\" o109, \"enorderrequestfile11\".\"isapproved\" o110, \"enorderrequestfile11\".\"isrejected\" o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, NULL o118, NULL o119");
fromBuilder.Append(" FROM ((((((({OrderAccounting} \"enorderaccounting4\" Left JOIN {OrderAccConcepts} \"enorderaccconcepts12\" ON (\"enorderaccounting4\".\"id\" = \"enorderaccconcepts12\".\"orderaccountingid\"))  Left JOIN {AccountingDataType} \"enaccountingdatatype9\" ON (\"enorderaccconcepts12\".\"accountingdatatypeid\" = \"enaccountingdatatype9\".\"id\"))  Left JOIN {OrderMain} \"enordermain91\" ON (\"enorderaccounting4\".\"orderid\" = \"enordermain91\".\"id\"))  Left JOIN {OrderRequestFile} \"enorderrequestfile11\" ON (\"enorderaccconcepts12\".\"id\" = \"enorderrequestfile11\".\"orderaccconceptid\"))  Left JOIN {Currency} \"encurrency13\" ON (\"enorderaccconcepts12\".\"currencyid\" = \"encurrency13\".\"code\"))  Left JOIN {Invoice} \"eninvoice131\" ON (\"enorderrequestfile11\".\"invoiceid\" = \"eninvoice131\".\"id\"))  Left JOIN {InvoiceStatus} \"eninvoicestatus13\" ON (\"eninvoice131\".\"invoicestatusid\" = \"eninvoicestatus13\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderAccounting_OrderId != 0) {
whereBuilder.Append("((\"enorderaccounting4\".\"orderid\" = @qporOrderAccounting_OrderId) AND (\"enorderaccounting4\".\"orderid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderAccounting_OrderId", DbType.Int64, qporOrderAccounting_OrderId);
} else {
whereBuilder.Append("(\"enorderaccounting4\".\"orderid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enorderaccconcepts12\".\"orderaccconceptsid\" IS NOT NULL) AND (((\"enorderaccconcepts12\".\"accountingdatatypeid\" = ");
whereBuilder.Append(6
);
whereBuilder.Append(") OR (\"enorderaccconcepts12\".\"accountingdatatypeid\" = ");
whereBuilder.Append(5
);
whereBuilder.Append(")) OR (\"enorderaccconcepts12\".\"accountingdatatypeid\" = ");
whereBuilder.Append(8
);
whereBuilder.Append("))");
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
RL_e127e807f43523243e5e4b1203065583 outParamList = new RL_e127e807f43523243e5e4b1203065583();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderAccountingsByOrderIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[8];
opt[0] = new BitArray(new bool[] {false, true, true, true, true});
opt[1] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, false, false, true, true, true, true});
opt[3] = new BitArray(new bool[] {false, true, false, true, false, true, true, true, true, true, true, true, false, true});
opt[4] = new BitArray(new bool[] {false, true, false, true, false, true, false, false, false, true, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[6] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[7] = new BitArray(new bool[] {true, false, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.WB_OrderFinancialFiles.GetOrderAccountingsByOrderId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_e127e807f43523243e5e4b1203065583 _tmp = new RL_e127e807f43523243e5e4b1203065583();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderAccountingsByOrderIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.WB_OrderFinancialFiles.GetOrderAccountingsByOrderId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_e127e807f43523243e5e4b1203065583)_tmp;
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

private static async Task<RC_47b8b3c05056f6c3d5b8f5b05dd1c032> datasetGetOrderFileByIdReadDbAsync(RC_47b8b3c05056f6c3d5b8f5b05dd1c032 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENContractFileType.Read( r, ref index);
rec.ssENCurrency.Read( r, ref index);
rec.ssENCurrency_2.Read( r, ref index);
rec.ssENOrderContractFile.Read( r, ref index);
rec.ssENOrderDetail.Read( r, ref index);
rec.ssENOrderFile.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssENOrderRequestFile.Read( r, ref index);
return rec;
}
// Query Function "GetOrderFileById" hMfK3yHko0K0tKUdD+WVYg of Action "WB_OrderFinancialFiles"
public static async Task<(RL_924196580a3b015839b6fad505120f41,long)> datasetGetOrderFileById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderContractFile_OrderId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.WB_OrderFinancialFiles.GetOrderFileById", "dfcac784-e421-42a3-b4b4-a51d0fe59562");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("WB_OrderFinancialFiles","e_Orders.WB_OrderFinancialFiles.GetOrderFileById");
// Query Iterations: Multiple
// Refresh Query dgNJyQYwe0mTbfXZ29yLIw Iterations: Multiple
// Refresh Query Sl1Ozb8Jfk+ekqgpyStlGg Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.1Xr7QfvhHU2QT1LDu+YkwQ/ScreenDataSets.hMfK3yHko0K0tKUdD+WVYg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"encontractfiletype1\".\"id\" o0, \"encontractfiletype1\".\"label\" o1, NULL o2, NULL o3, \"encurrency14\".\"code\" o4, NULL o5, NULL o6, NULL o7, NULL o8, \"encurrency_2\".\"code\" o9, NULL o10, NULL o11, NULL o12, NULL o13, \"enordercontractfile5\".\"id\" o14, NULL o15, NULL o16, NULL o17, trim_scale(\"enordercontractfile5\".\"amount\"::numeric) o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, \"enordercontractfile5\".\"startbasedate\" o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, \"enorderdetail13\".\"startbasedate\" o46, \"enorderdetail13\".\"endbasedate\" o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, trim_scale(\"enorderdetail13\".\"contractamount\"::numeric) o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, \"enorderfile5\".\"id\" o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, NULL o103, \"enorderrequestfile12\".\"id\" o104, NULL o105, \"enorderrequestfile12\".\"invoiceid\" o106, NULL o107, \"enorderrequestfile12\".\"storageid\" o108, NULL o109, \"enorderrequestfile12\".\"needsapproval\" o110, \"enorderrequestfile12\".\"isapproved\" o111, \"enorderrequestfile12\".\"isrejected\" o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, NULL o118, NULL o119, NULL o120");
fromBuilder.Append(" FROM ((((((({OrderContractFile} \"enordercontractfile5\" Left JOIN {OrderFile} \"enorderfile5\" ON (\"enordercontractfile5\".\"orderfileid\" = \"enorderfile5\".\"id\"))  Inner JOIN {ContractFileType} \"encontractfiletype1\" ON (\"enordercontractfile5\".\"contractfiletypeid\" = \"encontractfiletype1\".\"id\"))  Left JOIN {OrderRequestFile} \"enorderrequestfile12\" ON (\"enordercontractfile5\".\"id\" = \"enorderrequestfile12\".\"ordercontractfile\"))  Left JOIN {Currency} \"encurrency14\" ON (\"enordercontractfile5\".\"currencyid\" = \"encurrency14\".\"code\"))  Inner JOIN {OrderMain} \"enordermain92\" ON (\"enordermain92\".\"id\" = \"enordercontractfile5\".\"orderid\"))  Left JOIN {OrderDetail} \"enorderdetail13\" ON (\"enordermain92\".\"id\" = \"enorderdetail13\".\"orderid\"))  Left JOIN {Currency} \"encurrency_2\" ON (\"enordermain92\".\"currencyid\" = \"encurrency_2\".\"code\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderContractFile_OrderId != 0) {
whereBuilder.Append("((\"enordercontractfile5\".\"orderid\" = @qporOrderContractFile_OrderId) AND (\"enordercontractfile5\".\"orderid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderContractFile_OrderId", DbType.Int64, qporOrderContractFile_OrderId);
} else {
whereBuilder.Append("(\"enordercontractfile5\".\"orderid\" IS NULL)");
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
RL_924196580a3b015839b6fad505120f41 outParamList = new RL_924196580a3b015839b6fad505120f41();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderFileByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[8];
opt[0] = new BitArray(new bool[] {false, true, true, true, true});
opt[1] = new BitArray(new bool[] {false, true, true, true, true});
opt[2] = new BitArray(new bool[] {false, false, true, true});
opt[3] = new BitArray(new bool[] {false, true, false, true, false, true, false, false, false, true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {false, true, true, true, false, true, true, true, true, true, false, true, true, true});
opt[5] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[6] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, false, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true});
opt[7] = new BitArray(new bool[] {false, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.WB_OrderFinancialFiles.GetOrderFileById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_924196580a3b015839b6fad505120f41 _tmp = new RL_924196580a3b015839b6fad505120f41();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderFileByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.WB_OrderFinancialFiles.GetOrderFileById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_924196580a3b015839b6fad505120f41)_tmp;
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
