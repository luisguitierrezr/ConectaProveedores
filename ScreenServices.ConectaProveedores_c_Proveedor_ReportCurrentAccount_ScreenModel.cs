using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_c_Proveedor_ReportCurrentAccount_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_c_Proveedor_ReportCurrentAccount_ScreenModel).Namespace);

    public string inParamI_ACREEDOR;
public DateTime inParamI_ANTICIPOS_HIGH;
public DateTime inParamI_ANTICIPOS_LOW;
public DateTime inParamI_F_PARTABIE;
public DateTime inParamI_PCOMP_HIGH;
public DateTime inParamI_PCOMP_LOW;
public string inParamI_REGION;
public string inParamI_SOCIEDAD;
public long inParamSupplierId;
public AggregateRecord<RL_f647e8c4990b814587d1a017e4c9dd44> ScreenDataSetGetSupplierUserByUserId;
public AggregateRecord<RL_375b9dd8c8b0d6d7bccf4d550f48644d> ScreenDataSetGetPaymentTerms;
public ConectaProveedores_c_Proveedor_ReportCurrentAccount_DataActionGetSapData_Model varLcGetSapData;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_c_Proveedor_ReportCurrentAccount_ScreenModel() {
}



    public ConectaProveedores_c_Proveedor_ReportCurrentAccount_ScreenModel(string inParamI_ACREEDOR, DateTime inParamI_ANTICIPOS_HIGH, DateTime inParamI_ANTICIPOS_LOW, DateTime inParamI_F_PARTABIE, DateTime inParamI_PCOMP_HIGH, DateTime inParamI_PCOMP_LOW, string inParamI_REGION, string inParamI_SOCIEDAD, long inParamSupplierId, AggregateRecord<RL_f647e8c4990b814587d1a017e4c9dd44> ScreenDataSetGetSupplierUserByUserId, AggregateRecord<RL_375b9dd8c8b0d6d7bccf4d550f48644d> ScreenDataSetGetPaymentTerms, ConectaProveedores_c_Proveedor_ReportCurrentAccount_DataActionGetSapData_Model varLcGetSapData, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"I_ACREEDOR", "I_ANTICIPOS_HIGH", "I_ANTICIPOS_LOW", "I_F_PARTABIE", "I_PCOMP_HIGH", "I_PCOMP_LOW", "I_REGION", "I_SOCIEDAD", "SupplierId", "GetSupplierUserByUserId", "GetPaymentTerms", "GetSapData", "ClientVars"}, new string[] {"inParamI_ACREEDOR", "inParamI_ANTICIPOS_HIGH", "inParamI_ANTICIPOS_LOW", "inParamI_F_PARTABIE", "inParamI_PCOMP_HIGH", "inParamI_PCOMP_LOW", "inParamI_REGION", "inParamI_SOCIEDAD", "inParamSupplierId", "ScreenDataSetGetSupplierUserByUserId", "ScreenDataSetGetPaymentTerms", "varLcGetSapData", "clientVariables"});
this.inParamI_ACREEDOR = inParamI_ACREEDOR;
this.inParamI_ANTICIPOS_HIGH = inParamI_ANTICIPOS_HIGH;
this.inParamI_ANTICIPOS_LOW = inParamI_ANTICIPOS_LOW;
this.inParamI_F_PARTABIE = inParamI_F_PARTABIE;
this.inParamI_PCOMP_HIGH = inParamI_PCOMP_HIGH;
this.inParamI_PCOMP_LOW = inParamI_PCOMP_LOW;
this.inParamI_REGION = inParamI_REGION;
this.inParamI_SOCIEDAD = inParamI_SOCIEDAD;
this.inParamSupplierId = inParamSupplierId;
this.ScreenDataSetGetSupplierUserByUserId = ScreenDataSetGetSupplierUserByUserId;
this.ScreenDataSetGetPaymentTerms = ScreenDataSetGetPaymentTerms;
this.varLcGetSapData = varLcGetSapData;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_c81aee5ce0504fe68694be6deb703b5e> datasetGetSupplierUserByUserIdReadDbAsync(RC_c81aee5ce0504fe68694be6deb703b5e rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENRegion.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetSupplierUserByUserId" 1tIXfNJINken88yAcdtqtg of Action "ReportCurrentAccount"
public static async Task<(RL_f647e8c4990b814587d1a017e4c9dd44,long)> datasetGetSupplierUserByUserId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpsuSupplier_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("c_Proveedor.ReportCurrentAccount.GetSupplierUserByUserId", "7c17d2d6-48d2-4736-a7f3-cc8071db6ab6");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("ReportCurrentAccount","c_Proveedor.ReportCurrentAccount.GetSupplierUserByUserId");
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
selectBuilder.Append("/* /NRWebFlows.C1VQREl4LUakdtWZ9kDRuQ/NodesShownInESpaceTree.6lvdNXzlQU2NEXUwmEZdLA/ScreenDataSets.1tIXfNJINken88yAcdtqtg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, \"ensupplier106\".\"name\" o15, \"ensupplier106\".\"number\" o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40");
fromBuilder.Append(" FROM ({Supplier} \"ensupplier106\" Left JOIN {Region} \"enregion131\" ON (\"ensupplier106\".\"regionid\" = \"enregion131\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpsuSupplier_Id != 0) {
whereBuilder.Append("((\"ensupplier106\".\"id\" = @qpsuSupplier_Id) AND (\"ensupplier106\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuSupplier_Id", DbType.Int64, qpsuSupplier_Id);
} else {
whereBuilder.Append("(\"ensupplier106\".\"id\" IS NULL)");
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
RL_f647e8c4990b814587d1a017e4c9dd44 outParamList = new RL_f647e8c4990b814587d1a017e4c9dd44();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetSupplierUserByUserIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Proveedor.ReportCurrentAccount.GetSupplierUserByUserId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_f647e8c4990b814587d1a017e4c9dd44 _tmp = new RL_f647e8c4990b814587d1a017e4c9dd44();
_tmp.AlternateReadDbMethodAsync = datasetGetSupplierUserByUserIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Proveedor.ReportCurrentAccount.GetSupplierUserByUserId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_f647e8c4990b814587d1a017e4c9dd44)_tmp;
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

// Query Function "GetPaymentTerms" o25B5Iq6F0qYhcN+zYIAKg of Action "ReportCurrentAccount"
public static async Task<(RL_375b9dd8c8b0d6d7bccf4d550f48644d,long)> datasetGetPaymentTerms(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("c_Proveedor.ReportCurrentAccount.GetPaymentTerms", "e4416ea3-ba8a-4a17-9885-c37ecd82002a");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("ReportCurrentAccount","c_Proveedor.ReportCurrentAccount.GetPaymentTerms");
// Query Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.C1VQREl4LUakdtWZ9kDRuQ/NodesShownInESpaceTree.6lvdNXzlQU2NEXUwmEZdLA/ScreenDataSets.o25B5Iq6F0qYhcN+zYIAKg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enpaymentterms26\".\"id\" o0, \"enpaymentterms26\".\"description\" o1, \"enpaymentterms26\".\"clcta\" o2, \"enpaymentterms26\".\"classfecha\" o3, \"enpaymentterms26\".\"ctd_dias\" o4, \"enpaymentterms26\".\"estructuradescripcionprop\" o5, \"enpaymentterms26\".\"isspecial\" o6, \"enpaymentterms26\".\"createdon\" o7, \"enpaymentterms26\".\"createdby\" o8, \"enpaymentterms26\".\"updatedon\" o9, \"enpaymentterms26\".\"updatedby\" o10");
fromBuilder.Append(" FROM {PaymentTerms} \"enpaymentterms26\"");
orderByBuilder.Append(" ORDER BY \"enpaymentterms26\".\"description\" ASC ");
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
RL_375b9dd8c8b0d6d7bccf4d550f48644d outParamList = new RL_375b9dd8c8b0d6d7bccf4d550f48644d();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Proveedor.ReportCurrentAccount.GetPaymentTerms.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_375b9dd8c8b0d6d7bccf4d550f48644d _tmp = new RL_375b9dd8c8b0d6d7bccf4d550f48644d();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Proveedor.ReportCurrentAccount.GetPaymentTerms.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_375b9dd8c8b0d6d7bccf4d550f48644d)_tmp;
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


    public class lcvGetSapData : VarsBag {
public ST_382afa1d8361f400b6ea03403d75e294Structure resCall_ZMXMIMMF_ESTD_CUENTA_COSMOZ_outParamResponse = new ST_382afa1d8361f400b6ea03403d75e294Structure();

public lcvGetSapData() {
}
}
public class lcoGetSapData : VarsBag {
public ST_382afa1d8361f400b6ea03403d75e294Structure outParamList = new ST_382afa1d8361f400b6ea03403d75e294Structure();

public decimal outParamTotalenmonedanacional = (((decimal)0));

public decimal outParamImportetotaldefacturasmonedaextranjera = (((decimal)0));

public decimal outParamTotalenmonedanacional2 = (((decimal)0));

public decimal outParamImportetotaldefacturasmonedaextranjera2 = (((decimal)0));

public lcoGetSapData() {
}
}
/// <summary>
/// Action <code>GetSapData</code> that represents the Service Studio action <code>GetSapData</code>
///  <p> Description: </p>
/// </summary>
public async Task<(ST_382afa1d8361f400b6ea03403d75e294Structure,decimal,decimal,decimal,decimal)> DataActionGetSapData(IRequestContext requestContext,CancellationToken cancellationToken) {
ST_382afa1d8361f400b6ea03403d75e294Structure outParamList = default;
decimal outParamTotalenmonedanacional = default;
decimal outParamImportetotaldefacturasmonedaextranjera = default;
decimal outParamTotalenmonedanacional2 = default;
decimal outParamImportetotaldefacturasmonedaextranjera2 = default;
lcoGetSapData result = new lcoGetSapData();
lcvGetSapData localVars = new lcvGetSapData();
ConectaProveedores_c_Proveedor_ReportCurrentAccount_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetSapData", "a52c9622-f23f-450d-bdf5-6b44b62155b3"))
using (activitySource.CreateScreenDataActionActivity("ReportCurrentAccount", "GetSapData")){
// Call_ZMXMIMMF_ESTD_CUENTA_COSMOZ
localVars.resCall_ZMXMIMMF_ESTD_CUENTA_COSMOZ_outParamResponse = await ServiceAPIs.ServiceAPICall_ZMXMIMMF_ESTD_CUENTA_COSMOZ(requestContext,new ST_f53a6d7e4b5e7b5abd0fc13c8d53eb8dStructure(){ ssI_ACREEDOR = inParamI_ACREEDOR, ssI_ANTICIPOS_HIGH = (((((((BuiltInFunction.LengthSC (Convert.ToString(BuiltInFunction.Day (inParamI_ANTICIPOS_HIGH)))==2)) ? (Convert.ToString(BuiltInFunction.Day (inParamI_ANTICIPOS_HIGH))) : (("0"+Convert.ToString(BuiltInFunction.Day (inParamI_ANTICIPOS_HIGH)))))+".")+(((BuiltInFunction.LengthSC (Convert.ToString(BuiltInFunction.Month (inParamI_ANTICIPOS_HIGH)))==2)) ? (Convert.ToString(BuiltInFunction.Month (inParamI_ANTICIPOS_HIGH))) : (("0"+Convert.ToString(BuiltInFunction.Month (inParamI_ANTICIPOS_HIGH))))))+".")+Convert.ToString(BuiltInFunction.Year (inParamI_ANTICIPOS_HIGH))), ssI_ANTICIPOS_LOW = (((((((BuiltInFunction.LengthSC (Convert.ToString(BuiltInFunction.Day (inParamI_ANTICIPOS_LOW)))==2)) ? (Convert.ToString(BuiltInFunction.Day (inParamI_ANTICIPOS_LOW))) : (("0"+Convert.ToString(BuiltInFunction.Day (inParamI_ANTICIPOS_LOW)))))+".")+(((BuiltInFunction.LengthSC (Convert.ToString(BuiltInFunction.Month (inParamI_ANTICIPOS_LOW)))==2)) ? (Convert.ToString(BuiltInFunction.Month (inParamI_ANTICIPOS_LOW))) : (("0"+Convert.ToString(BuiltInFunction.Month (inParamI_ANTICIPOS_LOW))))))+".")+Convert.ToString(BuiltInFunction.Year (inParamI_ANTICIPOS_LOW))), ssI_F_PARTABIE = (((((((BuiltInFunction.LengthSC (Convert.ToString(BuiltInFunction.Day (inParamI_F_PARTABIE)))==2)) ? (Convert.ToString(BuiltInFunction.Day (inParamI_F_PARTABIE))) : (("0"+Convert.ToString(BuiltInFunction.Day (inParamI_F_PARTABIE)))))+".")+(((BuiltInFunction.LengthSC (Convert.ToString(BuiltInFunction.Month (inParamI_F_PARTABIE)))==2)) ? (Convert.ToString(BuiltInFunction.Month (inParamI_F_PARTABIE))) : (("0"+Convert.ToString(BuiltInFunction.Month (inParamI_F_PARTABIE))))))+".")+Convert.ToString(BuiltInFunction.Year (inParamI_F_PARTABIE))), ssI_PCOMP_HIGH = (((((((BuiltInFunction.LengthSC (Convert.ToString(BuiltInFunction.Day (inParamI_PCOMP_HIGH)))==2)) ? (Convert.ToString(BuiltInFunction.Day (inParamI_PCOMP_HIGH))) : (("0"+Convert.ToString(BuiltInFunction.Day (inParamI_PCOMP_HIGH)))))+".")+(((BuiltInFunction.LengthSC (Convert.ToString(BuiltInFunction.Month (inParamI_PCOMP_HIGH)))==2)) ? (Convert.ToString(BuiltInFunction.Month (inParamI_PCOMP_HIGH))) : (("0"+Convert.ToString(BuiltInFunction.Month (inParamI_PCOMP_HIGH))))))+".")+Convert.ToString(BuiltInFunction.Year (inParamI_PCOMP_HIGH))), ssI_PCOMP_LOW = (((((((BuiltInFunction.LengthSC (Convert.ToString(BuiltInFunction.Day (inParamI_PCOMP_LOW)))==2)) ? (Convert.ToString(BuiltInFunction.Day (inParamI_PCOMP_LOW))) : (("0"+Convert.ToString(BuiltInFunction.Day (inParamI_PCOMP_LOW)))))+".")+(((BuiltInFunction.LengthSC (Convert.ToString(BuiltInFunction.Month (inParamI_PCOMP_LOW)))==2)) ? (Convert.ToString(BuiltInFunction.Month (inParamI_PCOMP_LOW))) : (("0"+Convert.ToString(BuiltInFunction.Month (inParamI_PCOMP_LOW))))))+".")+Convert.ToString(BuiltInFunction.Year (inParamI_PCOMP_LOW))), ssI_REGION = inParamI_REGION, ssI_SOCIEDAD = inParamI_SOCIEDAD },cancellationToken);

// Foreach Call_ZMXMIMMF_ESTD_CUENTA_COSMOZ.Response.T_FACT_PEN_PAG_Out
localVars.resCall_ZMXMIMMF_ESTD_CUENTA_COSMOZ_outParamResponse.ssT_FACT_PEN_PAG_Out.StartIteration();
try {while (!((localVars.resCall_ZMXMIMMF_ESTD_CUENTA_COSMOZ_outParamResponse.ssT_FACT_PEN_PAG_Out.Eof))) {
// Totalenmonedanacional = Totalenmonedanacional + Call_ZMXMIMMF_ESTD_CUENTA_COSMOZ.Response.T_FACT_PEN_PAG_Out.Current.WRBT2
result.outParamTotalenmonedanacional=(result.outParamTotalenmonedanacional+localVars.resCall_ZMXMIMMF_ESTD_CUENTA_COSMOZ_outParamResponse.ssT_FACT_PEN_PAG_Out.CurrentRec.ssWRBT2);

// Importetotaldefacturasmonedaextranjera = Importetotaldefacturasmonedaextranjera + Call_ZMXMIMMF_ESTD_CUENTA_COSMOZ.Response.T_FACT_PEN_PAG_Out.Current.WRBT3
result.outParamImportetotaldefacturasmonedaextranjera=(result.outParamImportetotaldefacturasmonedaextranjera+localVars.resCall_ZMXMIMMF_ESTD_CUENTA_COSMOZ_outParamResponse.ssT_FACT_PEN_PAG_Out.CurrentRec.ssWRBT3);
localVars.resCall_ZMXMIMMF_ESTD_CUENTA_COSMOZ_outParamResponse.ssT_FACT_PEN_PAG_Out.Advance();
}

} finally {
localVars.resCall_ZMXMIMMF_ESTD_CUENTA_COSMOZ_outParamResponse.ssT_FACT_PEN_PAG_Out.EndIteration();
}

// Foreach Call_ZMXMIMMF_ESTD_CUENTA_COSMOZ.Response.T_FAC_PAG_Out
localVars.resCall_ZMXMIMMF_ESTD_CUENTA_COSMOZ_outParamResponse.ssT_FAC_PAG_Out.StartIteration();
try {while (!((localVars.resCall_ZMXMIMMF_ESTD_CUENTA_COSMOZ_outParamResponse.ssT_FAC_PAG_Out.Eof))) {
// Totalenmonedanacional2 = Totalenmonedanacional2 + Call_ZMXMIMMF_ESTD_CUENTA_COSMOZ.Response.T_FAC_PAG_Out.Current.WRBT2
result.outParamTotalenmonedanacional2=(result.outParamTotalenmonedanacional2+localVars.resCall_ZMXMIMMF_ESTD_CUENTA_COSMOZ_outParamResponse.ssT_FAC_PAG_Out.CurrentRec.ssWRBT2);

// Importetotaldefacturasmonedaextranjera2 = Importetotaldefacturasmonedaextranjera2 + Call_ZMXMIMMF_ESTD_CUENTA_COSMOZ.Response.T_FAC_PAG_Out.Current.WRBT3
result.outParamImportetotaldefacturasmonedaextranjera2=(result.outParamImportetotaldefacturasmonedaextranjera2+localVars.resCall_ZMXMIMMF_ESTD_CUENTA_COSMOZ_outParamResponse.ssT_FAC_PAG_Out.CurrentRec.ssWRBT3);
localVars.resCall_ZMXMIMMF_ESTD_CUENTA_COSMOZ_outParamResponse.ssT_FAC_PAG_Out.Advance();
}

} finally {
localVars.resCall_ZMXMIMMF_ESTD_CUENTA_COSMOZ_outParamResponse.ssT_FAC_PAG_Out.EndIteration();
}

// List = Call_ZMXMIMMF_ESTD_CUENTA_COSMOZ.Response
result.outParamList=localVars.resCall_ZMXMIMMF_ESTD_CUENTA_COSMOZ_outParamResponse;
} //close CreateActionActivity using block
} // try

finally {
outParamList = result.outParamList;
outParamTotalenmonedanacional = result.outParamTotalenmonedanacional;
outParamImportetotaldefacturasmonedaextranjera = result.outParamImportetotaldefacturasmonedaextranjera;
outParamTotalenmonedanacional2 = result.outParamTotalenmonedanacional2;
outParamImportetotaldefacturasmonedaextranjera2 = result.outParamImportetotaldefacturasmonedaextranjera2;
} // inner-finally
RETURN_STATEMENT:
return (outParamList,outParamTotalenmonedanacional,outParamImportetotaldefacturasmonedaextranjera,outParamTotalenmonedanacional2,outParamImportetotaldefacturasmonedaextranjera2);
}


    public static class FuncDataActionGetSapData {
}


}
