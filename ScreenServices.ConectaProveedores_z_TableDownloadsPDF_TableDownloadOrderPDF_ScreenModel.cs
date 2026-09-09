using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_z_TableDownloadsPDF_TableDownloadOrderPDF_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_z_TableDownloadsPDF_TableDownloadOrderPDF_ScreenModel).Namespace);

    public string inParamStringListIds;
public RLTextList varLcOrderIdList;
public ConectaProveedores_z_TableDownloadsPDF_TableDownloadOrderPDF_DataActionGetOrders_Model varLcGetOrders;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_z_TableDownloadsPDF_TableDownloadOrderPDF_ScreenModel() {
}



    public ConectaProveedores_z_TableDownloadsPDF_TableDownloadOrderPDF_ScreenModel(string inParamStringListIds, RLTextList varLcOrderIdList, ConectaProveedores_z_TableDownloadsPDF_TableDownloadOrderPDF_DataActionGetOrders_Model varLcGetOrders, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"StringListIds", "OrderIdList", "GetOrders", "ClientVars"}, new string[] {"inParamStringListIds", "varLcOrderIdList", "varLcGetOrders", "clientVariables"});
this.inParamStringListIds = inParamStringListIds;
this.varLcOrderIdList = varLcOrderIdList;
this.varLcGetOrders = varLcGetOrders;
this.clientVariables = clientVariables;
}



    

    public class lcvGetOrders : VarsBag {
public RL_e72491aae94589c6bfa425f20599b823 queryResGetOrders_outParamList = new RL_e72491aae94589c6bfa425f20599b823();
public long queryResGetOrders_outParamCount = 0L;

public lcvGetOrders() {
}
}
public class lcoGetOrders : VarsBag {
public RL_68002bbb4e227fd5533d460e5a56bbd4 outParamList = new RL_68002bbb4e227fd5533d460e5a56bbd4();

public lcoGetOrders() {
}
}
/// <summary>
/// Action <code>GetOrders</code> that represents the Service Studio action <code>GetOrders</code> <p>
///  Description: </p>
/// </summary>
public async Task<RL_68002bbb4e227fd5533d460e5a56bbd4> DataActionGetOrders(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_68002bbb4e227fd5533d460e5a56bbd4 outParamList = default;
lcoGetOrders result = new lcoGetOrders();
lcvGetOrders localVars = new lcvGetOrders();
ConectaProveedores_z_TableDownloadsPDF_TableDownloadOrderPDF_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetOrders", "8b6c020e-d5a5-46bc-9928-08057beba9dd"))
using (activitySource.CreateScreenDataActionActivity("TableDownloadOrderPDF", "GetOrders")){
// Foreach OrderIdList
varLcOrderIdList.StartIteration();
try {while (!((varLcOrderIdList.Eof))) {
// Query datasetGetOrders
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrders_maxRecords = 999999999;
if (datasetGetOrders_maxRecords < 1) datasetGetOrders_maxRecords = 1;
int datasetGetOrders_startIndex = 0;(localVars.queryResGetOrders_outParamList,localVars.queryResGetOrders_outParamCount) = await FuncDataActionGetOrders.datasetGetOrders(requestContext,datasetGetOrders_maxRecords,datasetGetOrders_startIndex,IterationMultiplicity.Never,varLcOrderIdList.CurrentRec.ssValue,cancellationToken);

// ListAppend
await ExtendedActions.ListAppend(requestContext,result.outParamList,(await RecordUtils.ConvertAsync(localVars.queryResGetOrders_outParamList.CurrentRec, new ST_00c299856fb2c1322ea33527b24c9dd0Structure(), async (RC_b4754aede4b6751be05d5ea422ed168c source, ST_00c299856fb2c1322ea33527b24c9dd0Structure target, CancellationToken cancellationToken) => {
target.ssOrderMainId = source.ssENOrderMain.ssId;
target.ssApprovalStatus = source.ssENApprovalStatus.ssLabel;
target.ssOrderNumber = source.ssENOrderMain.ssOrderNumber;
target.ssOrderStatus = source.ssENOrderStatus.ssLabelES;
target.ssSupplierName_Number = ((source.ssENSupplier.ssName+" \r\n")+source.ssENSupplier.ssNumber);
target.ssBuyer = source.ssENOrderMain.ssProcurementGroup;
target.ssCompany = ((source.ssENCompany.ssExternalId+" - ")+source.ssENCompany.ssDescription);
target.ssRegion = source.ssENRegion.ssCode;
target.ssCurrency = source.ssENCurrency.ssCode;
target.ssTotalAmount = BuiltInFunction.FormatCurrency (source.ssENOrderMain.ssTotalAmount, "", 2, ".", ",");
return target;
}, cancellationToken)),cancellationToken);

varLcOrderIdList.Advance();
}

} finally {
varLcOrderIdList.EndIteration();
}

} //close CreateActionActivity using block
} // try

finally {
outParamList = result.outParamList;
} // inner-finally
RETURN_STATEMENT:
return outParamList;
}


    public static class FuncDataActionGetOrders {

private static async Task<RC_b4754aede4b6751be05d5ea422ed168c> datasetGetOrdersReadDbAsync(RC_b4754aede4b6751be05d5ea422ed168c rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApprovalStatus.Read( r, ref index);
rec.ssENCompany.Read( r, ref index);
rec.ssENCurrency.Read( r, ref index);
rec.ssENOrderApproval.Read( r, ref index);
rec.ssENOrderApprovalLevel.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssENOrderStatus.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetOrders" fqhEf4jKKkqU24T90n9Cww of Action "GetOrders"
public static async Task<(RL_e72491aae94589c6bfa425f20599b823,long)> datasetGetOrders(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteOrderMain_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("z_TableDownloadsPDF.TableDownloadOrderPDF.GetOrders.GetOrders", "7f44a87e-ca88-4a2a-94db-84fdd27f42c3");
using var queryActivity = activitySource.CreateAggregateQueryActivity("z_TableDownloadsPDF.TableDownloadOrderPDF.GetOrders.GetOrders", "7f44a87e-ca88-4a2a-94db-84fdd27f42c3", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.kLQieB5cx02V9++AAXSp8g/NodesShownInESpaceTree.EuCT+0SwIkWyRP9eWYycYg/DataActions.DgJsi6XVvEaZKAgFe+up3Q/NodesNotShownInESpaceTree.fqhEf4jKKkqU24T90n9Cww, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enapprovalstatus25\".\"label\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, \"encompany58\".\"externalid\" o11, \"encompany58\".\"description\" o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, \"encurrency29\".\"code\" o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, \"enordermain111\".\"id\" o51, \"enordermain111\".\"ordernumber\" o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, \"enordermain111\".\"procurementgroup\" o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, trim_scale(\"enordermain111\".\"totalamount\"::numeric) o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, \"enorderstatus16\".\"labeles\" o85, NULL o86, \"enregion154\".\"code\" o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, \"ensupplier118\".\"name\" o101, \"ensupplier118\".\"number\" o102, NULL o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, NULL o118, NULL o119, NULL o120, NULL o121, NULL o122, NULL o123, NULL o124, NULL o125, NULL o126");
fromBuilder.Append(" FROM (((((((({OrderMain} \"enordermain111\" Left JOIN {OrderStatus} \"enorderstatus16\" ON (\"enordermain111\".\"orderstatusid\" = \"enorderstatus16\".\"id\"))  Left JOIN {Supplier} \"ensupplier118\" ON (\"enordermain111\".\"supplierid\" = \"ensupplier118\".\"id\"))  Left JOIN {Company} \"encompany58\" ON (\"enordermain111\".\"companyid\" = \"encompany58\".\"id\"))  Left JOIN {Currency} \"encurrency29\" ON (\"enordermain111\".\"currencyid\" = \"encurrency29\".\"code\"))  Left JOIN {OrderApproval} \"enorderapproval34\" ON (\"enordermain111\".\"id\" = \"enorderapproval34\".\"orderid\"))  Left JOIN {OrderApprovalLevel} \"enorderapprovallevel33\" ON (\"enorderapproval34\".\"id\" = \"enorderapprovallevel33\".\"orderapprovalid\"))  Left JOIN {ApprovalStatus} \"enapprovalstatus25\" ON (\"enorderapprovallevel33\".\"approvalstatusid\" = \"enapprovalstatus25\".\"id\"))  Left JOIN {Region} \"enregion154\" ON (\"enordermain111\".\"regionid\" = \"enregion154\".\"id\")) ");
whereBuilder.Append(" WHERE (\"enordermain111\".\"id\" = cast(((coalesce(cast(nullif(@qpteOrderMain_Id,'') as integer), 0))) as bigint))");
sqlCmd.CreateParameterWithoutReplacements("@qpteOrderMain_Id", DbType.String, qpteOrderMain_Id);
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
RL_e72491aae94589c6bfa425f20599b823 outParamList = new RL_e72491aae94589c6bfa425f20599b823();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrdersReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[9];
opt[0] = new BitArray(new bool[] {false, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, false});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {false, false, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[6] = new BitArray(new bool[] {true, false, false, true, true, true, true, true, true, true, true});
opt[7] = new BitArray(new bool[] {true, true, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[8] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query z_TableDownloadsPDF.TableDownloadOrderPDF.GetOrders.GetOrders.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_e72491aae94589c6bfa425f20599b823 _tmp = new RL_e72491aae94589c6bfa425f20599b823();
_tmp.AlternateReadDbMethodAsync = datasetGetOrdersReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query z_TableDownloadsPDF.TableDownloadOrderPDF.GetOrders.GetOrders.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_e72491aae94589c6bfa425f20599b823)_tmp;
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
