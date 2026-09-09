using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_d_Invoices_wb_AccSelect_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_d_Invoices_wb_AccSelect_ScreenModel).Namespace);

    public long inParamOrderMainID;
public bool inParamIsFromFolio;
public bool inParamIsEnable;
public AggregateRecord<RL_c78a606a32d5fd9bcd75de1aae614727> ScreenDataSetGetOrderAccountingsByOrderId;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_d_Invoices_wb_AccSelect_ScreenModel() {
}



    public ConectaProveedores_d_Invoices_wb_AccSelect_ScreenModel(long inParamOrderMainID, bool inParamIsFromFolio, bool inParamIsEnable, AggregateRecord<RL_c78a606a32d5fd9bcd75de1aae614727> ScreenDataSetGetOrderAccountingsByOrderId, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"OrderMainID", "IsFromFolio", "IsEnable", "GetOrderAccountingsByOrderId", "ClientVars"}, new string[] {"inParamOrderMainID", "inParamIsFromFolio", "inParamIsEnable", "ScreenDataSetGetOrderAccountingsByOrderId", "clientVariables"});
this.inParamOrderMainID = inParamOrderMainID;
this.inParamIsFromFolio = inParamIsFromFolio;
this.inParamIsEnable = inParamIsEnable;
this.ScreenDataSetGetOrderAccountingsByOrderId = ScreenDataSetGetOrderAccountingsByOrderId;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_ab3c433102000c44a55e713fb2ce955d> datasetGetOrderAccountingsByOrderIdReadDbAsync(RC_ab3c433102000c44a55e713fb2ce955d rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENAccountingDataType.Read( r, ref index);
rec.ssENOrderAccConcepts.Read( r, ref index);
rec.ssENOrderAccounting.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
return rec;
}
// Query Function "GetOrderAccountingsByOrderId" VR7AIQhgF02W8tSlq7exKQ of Action "wb_AccSelect"
public static async Task<(RL_c78a606a32d5fd9bcd75de1aae614727,long)> datasetGetOrderAccountingsByOrderId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboIsFromFolio,long qporOrderAccounting_OrderId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("d_Invoices.wb_AccSelect.GetOrderAccountingsByOrderId", "21c01e55-6008-4d17-96f2-d4a5abb7b129");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("wb_AccSelect","d_Invoices.wb_AccSelect.GetOrderAccountingsByOrderId");
// Query Iterations: Multiple
// Refresh Query fD8jj7qEV0Sh_hgovhw0_w Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.22FlLU0LEUOaUFO_6iGXPQ/NodesShownInESpaceTree.3k+4IpjQokCo_K3JJIDYqg/ScreenDataSets.VR7AIQhgF02W8tSlq7exKQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enaccountingdatatype8\".\"label\" o1, NULL o2, NULL o3, NULL o4, \"enorderaccconcepts11\".\"id\" o5, NULL o6, NULL o7, NULL o8, trim_scale(\"enorderaccconcepts11\".\"amount\"::numeric) o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, \"enorderaccconcepts11\".\"paymentdate\" o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, \"enordermain86\".\"currencyid\" o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66");
fromBuilder.Append(" FROM ((({OrderAccounting} \"enorderaccounting3\" Left JOIN {OrderAccConcepts} \"enorderaccconcepts11\" ON (\"enorderaccounting3\".\"id\" = \"enorderaccconcepts11\".\"orderaccountingid\"))  Left JOIN {AccountingDataType} \"enaccountingdatatype8\" ON (\"enorderaccconcepts11\".\"accountingdatatypeid\" = \"enaccountingdatatype8\".\"id\"))  Left JOIN {OrderMain} \"enordermain86\" ON (\"enorderaccounting3\".\"orderid\" = \"enordermain86\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderAccounting_OrderId != 0) {
whereBuilder.Append("((\"enorderaccounting3\".\"orderid\" = @qporOrderAccounting_OrderId) AND (\"enorderaccounting3\".\"orderid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderAccounting_OrderId", DbType.Int64, qporOrderAccounting_OrderId);
} else {
whereBuilder.Append("(\"enorderaccounting3\".\"orderid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enorderaccconcepts11\".\"orderaccconceptsid\" IS NOT NULL) AND ((CASE WHEN (@qpboIsFromFolio = 1) THEN (CASE WHEN ((((\"enorderaccconcepts11\".\"accountingdatatypeid\" = ");
whereBuilder.Append(1
);
whereBuilder.Append(") OR (\"enorderaccconcepts11\".\"accountingdatatypeid\" = ");
whereBuilder.Append(2
);
whereBuilder.Append(")) OR (\"enorderaccconcepts11\".\"accountingdatatypeid\" = ");
whereBuilder.Append(3
);
whereBuilder.Append(")) OR (\"enorderaccconcepts11\".\"accountingdatatypeid\" = ");
whereBuilder.Append(4
);
whereBuilder.Append(")) THEN 1 ELSE 0 END) ELSE (CASE WHEN (((\"enorderaccconcepts11\".\"accountingdatatypeid\" = ");
whereBuilder.Append(6
);
whereBuilder.Append(") OR (\"enorderaccconcepts11\".\"accountingdatatypeid\" = ");
whereBuilder.Append(5
);
whereBuilder.Append(")) OR (\"enorderaccconcepts11\".\"accountingdatatypeid\" = ");
whereBuilder.Append(8
);
whereBuilder.Append(")) THEN 1 ELSE 0 END) END) = 1)");
sqlCmd.CreateParameterWithoutReplacements("@qpboIsFromFolio", DbType.Boolean, qpboIsFromFolio);
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
RL_c78a606a32d5fd9bcd75de1aae614727 outParamList = new RL_c78a606a32d5fd9bcd75de1aae614727();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderAccountingsByOrderIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[4];
opt[0] = new BitArray(new bool[] {false, true, true, true, false, true, true, true, true, true, true, true, false, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, false, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_Invoices.wb_AccSelect.GetOrderAccountingsByOrderId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_c78a606a32d5fd9bcd75de1aae614727 _tmp = new RL_c78a606a32d5fd9bcd75de1aae614727();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderAccountingsByOrderIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_Invoices.wb_AccSelect.GetOrderAccountingsByOrderId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_c78a606a32d5fd9bcd75de1aae614727)_tmp;
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
