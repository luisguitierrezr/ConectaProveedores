namespace ssConectaProveedores;

public partial class Actions {
public class lcvGenerateInvoicesReport48_Invoices2 : VarsBag {
public int inParami_OffsetUtc;
public BasicTypeList<long> inParamInvoiceIdList;
/// <summary>
/// Variable <code>InvoicesReport48</code> that represents the Service Studio InvoicesReport48List
///  <code>InvoicesReport48</code> <p>Description: </p>
/// </summary>
public RL_36f497358824531a4d0365a750b33706 varLcInvoicesReport48 = new RL_36f497358824531a4d0365a750b33706();

/// <summary>
/// Variable <code>o_InvoicesReport48List</code> that represents the Service Studio
///  InvoicesReport48List <code>o_InvoicesReport48List</code> <p>Description: Invoices Report 4
/// 8 List.</p>
/// </summary>
public RL_36f497358824531a4d0365a750b33706 varLco_InvoicesReport48List = new RL_36f497358824531a4d0365a750b33706();

public Actions.lcoGenerateInvoicesReport48_Invoices0Line resGenerateInvoicesReport48_Invoices0Line =  new Actions.lcoGenerateInvoicesReport48_Invoices0Line();
public byte[] resRecordListToExcel2_outParamOut = new byte[] {};
public byte[] resConvertExcelBinaryToCsvBinary2_outParamConvertExcelBinaryToCsvBinary = new byte[] {};

public RL_96c21cde051426454a34b22eab135a68 queryResGetRequisitionsBySupplierUserId_outParamList = new RL_96c21cde051426454a34b22eab135a68();
public long queryResGetRequisitionsBySupplierUserId_outParamCount = 0L;

public RL_2502f19d25781770de0a97334d85b782 queryResGetUniques_CeBe_CeCo_outParamList = new RL_2502f19d25781770de0a97334d85b782();
public long queryResGetUniques_CeBe_CeCo_outParamCount = 0L;

public lcvGenerateInvoicesReport48_Invoices2(int inParami_OffsetUtc, BasicTypeList<long> inParamInvoiceIdList) {
this.inParami_OffsetUtc = inParami_OffsetUtc;
this.inParamInvoiceIdList = inParamInvoiceIdList;
}
}
public class lcoGenerateInvoicesReport48_Invoices2 : VarsBag {
public ST_a158c76eb93396680623c04244f48b6cStructure outParamFile = new ST_a158c76eb93396680623c04244f48b6cStructure();

public lcoGenerateInvoicesReport48_Invoices2() {
}
}
/// <summary>
/// Action <code>GenerateInvoicesReport48_Invoices2</code> that represents the Service Studio action
///  <code>GenerateInvoicesReport48_Invoices2</code> <p> Description
/// : GenerateInvoiceReport48_Invoices</p>
/// </summary>
public static async Task<ST_a158c76eb93396680623c04244f48b6cStructure> ActionGenerateInvoicesReport48_Invoices2(IRequestContext requestContext,int inParami_OffsetUtc,BasicTypeList<long> inParamInvoiceIdList,CancellationToken cancellationToken) {
ST_a158c76eb93396680623c04244f48b6cStructure outParamFile = default;
lcoGenerateInvoicesReport48_Invoices2 result = new lcoGenerateInvoicesReport48_Invoices2();
lcvGenerateInvoicesReport48_Invoices2 localVars = new lcvGenerateInvoicesReport48_Invoices2(inParami_OffsetUtc, inParamInvoiceIdList);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GenerateInvoicesReport48_Invoices2", "2b2a245d-a053-4686-84db-8fb7f6b504a6"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GenerateInvoicesReport48_Invoices2", "2b2a245d-a053-4686-84db-8fb7f6b504a6", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Foreach InvoiceIdList
localVars.inParamInvoiceIdList.StartIteration();
try {while (!((localVars.inParamInvoiceIdList.Eof))) {
// Query QueryGetUniques_CeBe_CeCo
cancellationToken.ThrowIfCancellationRequested();
int QueryGetUniques_CeBe_CeCo_maxRecords = 0;
int QueryGetUniques_CeBe_CeCo_startIndex = 0;(localVars.queryResGetUniques_CeBe_CeCo_outParamList,localVars.queryResGetUniques_CeBe_CeCo_outParamCount) = await FuncActionGenerateInvoicesReport48_Invoices2.QueryGetUniques_CeBe_CeCo(requestContext,QueryGetUniques_CeBe_CeCo_maxRecords,QueryGetUniques_CeBe_CeCo_startIndex,IterationMultiplicity.Never,localVars.inParamInvoiceIdList.CurrentRec,cancellationToken);

// Assign CeBe and CeCo
// InvoicesReport48.Current.IDCeCo = GetUniques_CeBe_CeCo.List.Current.UniquesCeBeCeCo.CeCo
localVars.varLcInvoicesReport48.CurrentRec.ssIDCeCo = localVars.queryResGetUniques_CeBe_CeCo_outParamList.CurrentRec.ssSTUniquesCeBeCeCo.ssCeCo;

// InvoicesReport48.Current.IDCeBe = GetUniques_CeBe_CeCo.List.Current.UniquesCeBeCeCo.CeBe
localVars.varLcInvoicesReport48.CurrentRec.ssIDCeBe = localVars.queryResGetUniques_CeBe_CeCo_outParamList.CurrentRec.ssSTUniquesCeBeCeCo.ssCeBe;
// Query datasetGetRequisitionsBySupplierUserId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionsBySupplierUserId_maxRecords = 0;
int datasetGetRequisitionsBySupplierUserId_startIndex = 0;(localVars.queryResGetRequisitionsBySupplierUserId_outParamList,localVars.queryResGetRequisitionsBySupplierUserId_outParamCount) = await FuncActionGenerateInvoicesReport48_Invoices2.datasetGetRequisitionsBySupplierUserId(requestContext,datasetGetRequisitionsBySupplierUserId_maxRecords,datasetGetRequisitionsBySupplierUserId_startIndex,IterationMultiplicity.Never,localVars.inParamInvoiceIdList.CurrentRec,cancellationToken);

// GenerateInvoicesReport48_Invoices0Line
localVars.resGenerateInvoicesReport48_Invoices0Line.outParamo_InvoicesReport48 = await Actions.ActionGenerateInvoicesReport48_Invoices0Line(requestContext,localVars.inParamInvoiceIdList.CurrentRec,localVars.queryResGetRequisitionsBySupplierUserId_outParamList.CurrentRec.ssENFrequency.ssLabel,"",localVars.queryResGetRequisitionsBySupplierUserId_outParamList.CurrentRec.ssENProject_Asset_Service.ssDescription,localVars.queryResGetRequisitionsBySupplierUserId_outParamList.CurrentRec.ssENRequisition.ssName,localVars.queryResGetRequisitionsBySupplierUserId_outParamList.CurrentRec.ssENRequisition.ssCreatedOn,localVars.varLcInvoicesReport48.CurrentRec.ssIDCeBe,localVars.varLcInvoicesReport48.CurrentRec.ssIDCeCo,localVars.queryResGetRequisitionsBySupplierUserId_outParamList.CurrentRec.ssENSupplier,localVars.inParami_OffsetUtc,localVars.queryResGetRequisitionsBySupplierUserId_outParamList.CurrentRec.ssENRegion.ssDivisionFI,cancellationToken);

// ListAppend
await ExtendedActions.ListAppend(requestContext,localVars.varLco_InvoicesReport48List,localVars.resGenerateInvoicesReport48_Invoices0Line.outParamo_InvoicesReport48,cancellationToken);

localVars.inParamInvoiceIdList.Advance();
}

} finally {
localVars.inParamInvoiceIdList.EndIteration();
}

// ListAppendAll2
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcInvoicesReport48,localVars.varLco_InvoicesReport48List,cancellationToken);

// RecordListToExcel RLToExcelGenerateInvoicesReport48_Invoices2RecordListToExcel2
localVars.resRecordListToExcel2_outParamOut = await FuncActionGenerateInvoicesReport48_Invoices2.RLToExcelGenerateInvoicesReport48_Invoices2RecordListToExcel2(requestContext,localVars.varLcInvoicesReport48,cancellationToken);

// ConvertExcelBinaryToCsvBinary2
localVars.resConvertExcelBinaryToCsvBinary2_outParamConvertExcelBinaryToCsvBinary = await Actions.ActionConvertExcelBinaryToCsvBinary(requestContext,localVars.resRecordListToExcel2_outParamOut,cancellationToken);

// File.BinaryData = ConvertExcelBinaryToCsvBinary2.ConvertExcelBinaryToCsvBinary
result.outParamFile.ssBinaryData = localVars.resConvertExcelBinaryToCsvBinary2_outParamConvertExcelBinaryToCsvBinary;

// File.Name = "SuppliersWithoutOrderReport" + ".csv"
result.outParamFile.ssName = (AppUtils.GetStringResource("+naM0su6f0C1n6WjJBq2yA#Value.1228814497.1", "SuppliersWithoutOrderReport")+".csv");
} //close CreateActionActivity using block
} // try

finally {
outParamFile = result.outParamFile;
} // inner-finally
RETURN_STATEMENT:
return outParamFile;
}

public static class FuncActionGenerateInvoicesReport48_Invoices2 {

private static async Task<RC_46132251159224eb7db91a6454426186> datasetGetRequisitionsBySupplierUserIdReadDbAsync(RC_46132251159224eb7db91a6454426186 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFrequency.Read( r, ref index);
rec.ssENInvoice.Read( r, ref index);
rec.ssENProject_Asset_Service.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetRequisitionsBySupplierUserId" fonwxs8c6UmkXYCZTTWBmQ of Action "GenerateInvoicesReport48_Invoices2"
public static async Task<(RL_96c21cde051426454a34b22eab135a68,long)> datasetGetRequisitionsBySupplierUserId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoice_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GenerateInvoicesReport48_Invoices2.GetRequisitionsBySupplierUserId", "c6f0897e-1ccf-49e9-a45d-80994d358199");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GenerateInvoicesReport48_Invoices2.GetRequisitionsBySupplierUserId", "c6f0897e-1ccf-49e9-a45d-80994d358199", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.XSQqK1OghkaE24+39rUEpg/NodesNotShownInESpaceTree.fonwxs8c6UmkXYCZTTWBmQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enfrequency\".\"label\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, \"enproject_asset_service1\".\"description\" o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, \"enregion8\".\"divisionfi\" o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, \"enrequisition10\".\"name\" o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, \"enrequisition10\".\"createdon\" o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, NULL o103, NULL o104, NULL o105, \"ensupplier6\".\"id\" o106, \"ensupplier6\".\"tratamiento\" o107, \"ensupplier6\".\"name\" o108, \"ensupplier6\".\"number\" o109, \"ensupplier6\".\"conceptobusq_1_2\" o110, \"ensupplier6\".\"calle_numero\" o111, \"ensupplier6\".\"distrito\" o112, \"ensupplier6\".\"codigopostal_pobl_\" o113, \"ensupplier6\".\"pais\" o114, \"ensupplier6\".\"region_\" o115, \"ensupplier6\".\"idioma\" o116, \"ensupplier6\".\"telefono\" o117, \"ensupplier6\".\"extension\" o118, \"ensupplier6\".\"fax\" o119, \"ensupplier6\".\"cliente\" o120, \"ensupplier6\".\"soc_glasociada\" o121, \"ensupplier6\".\"clavedegrupo\" o122, \"ensupplier6\".\"n_ident_fis_1\" o123, \"ensupplier6\".\"personafisica\" o124, \"ensupplier6\".\"ramo\" o125, \"ensupplier6\".\"grupodeporte\" o126, \"ensupplier6\".\"email\" o127, \"ensupplier6\".\"isactive\" o128, \"ensupplier6\".\"createdon\" o129, \"ensupplier6\".\"createdby\" o130, \"ensupplier6\".\"updatedon\" o131, \"ensupplier6\".\"updatedby\" o132, \"ensupplier6\".\"regionid\" o133");
fromBuilder.Append(" FROM ((((({Requisition} \"enrequisition10\" Left JOIN {Invoice} \"eninvoice7\" ON (\"enrequisition10\".\"id\" = \"eninvoice7\".\"requisitionid\"))  Left JOIN {Frequency} \"enfrequency\" ON (\"enrequisition10\".\"frequencyid\" = \"enfrequency\".\"id\"))  Left JOIN {Project_Asset_Service} \"enproject_asset_service1\" ON (\"enrequisition10\".\"projectassetserviceid\" = \"enproject_asset_service1\".\"id\"))  Left JOIN {Supplier} \"ensupplier6\" ON (\"enrequisition10\".\"supplierid\" = \"ensupplier6\".\"id\"))  Left JOIN {Region} \"enregion8\" ON (\"enrequisition10\".\"regionid\" = \"enregion8\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoice_Id != 0) {
whereBuilder.Append("((\"eninvoice7\".\"id\" = @qpinInvoice_Id) AND (\"eninvoice7\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoice_Id", DbType.Int64, qpinInvoice_Id);
} else {
whereBuilder.Append("(\"eninvoice7\".\"id\" IS NULL)");
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
RL_96c21cde051426454a34b22eab135a68 outParamList = new RL_96c21cde051426454a34b22eab135a68();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetRequisitionsBySupplierUserIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[6];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[3] = new BitArray(new bool[] {true, false, true, true});
opt[4] = new BitArray(new bool[] {true, false, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GenerateInvoicesReport48_Invoices2.GetRequisitionsBySupplierUserId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_96c21cde051426454a34b22eab135a68 _tmp = new RL_96c21cde051426454a34b22eab135a68();
_tmp.AlternateReadDbMethodAsync = datasetGetRequisitionsBySupplierUserIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GenerateInvoicesReport48_Invoices2.GetRequisitionsBySupplierUserId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_96c21cde051426454a34b22eab135a68)_tmp;
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

// Query Function "GetUniques_CeBe_CeCo" I7FP6ipNG0WlqE_befTitA of Action "GenerateInvoicesReport48_Invoices2"
public static async Task<(RL_2502f19d25781770de0a97334d85b782,long)> QueryGetUniques_CeBe_CeCo(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("GenerateInvoicesReport48_Invoices2.GetUniques_CeBe_CeCo", "ea4fb123-4d2a-451b-a5a8-4fdb79f4e2b4");
using var queryActivity = activitySource.CreateSqlQueryActivity("GenerateInvoicesReport48_Invoices2.GetUniques_CeBe_CeCo", "ea4fb123-4d2a-451b-a5a8-4fdb79f4e2b4", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string entityInvoice = AppUtils.Instance.RuntimeEntityReplace("Invoice");
string entityInvoiceAccounting = AppUtils.Instance.RuntimeEntityReplace("InvoiceAccounting");
string entityInvoiceAccountingServices = AppUtils.Instance.RuntimeEntityReplace("InvoiceAccountingServices");
string entityCostCenterSAP = AppUtils.Instance.RuntimeEntityReplace("CostCenterSAP");
sqlCmd.CreateParameter("@qpinInvoiceId", DbType.Int64, qpinInvoiceId);
string sql = "";
string advSql = "SELECT \n    STRING_AGG(CeCo, ',') AS CeCo, \n    STRING_AGG(CeBe, ',') AS CeBe \nFROM ( \n    SELECT DISTINCT \n        CeCo.\"ce_coste\" AS CeCo, \n        CeBe.\"ce_coste\" AS CeBe \n    FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoice,"") + " \n \n    LEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoiceAccounting,"") + " \n        ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoiceAccounting,".\"invoiceid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoice,".\"id\"") + " \n \n    LEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoiceAccountingServices,"") + " \n        ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoiceAccountingServices,".\"invoiceaccountingid\"") + " = \n            " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoiceAccounting,".\"id\"") + " \n \n    LEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,"") + " CeCo \n        ON CeCo.\"id\" =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoiceAccountingServices,".\"costcenterid\"") + " \n \n    LEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,"") + " CeBe \n        ON CeBe.\"id\" =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoiceAccountingServices,".\"cebecostcenterid\"") + " \n \n    WHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoice,".Id") + " = @qpinInvoiceId \n) AS DistinctValues";
sql = advSql;
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_2502f19d25781770de0a97334d85b782 outParamList = new RL_2502f19d25781770de0a97334d85b782();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GenerateInvoicesReport48_Invoices2.GetUniques_CeBe_CeCo.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_2502f19d25781770de0a97334d85b782 _tmp = new RL_2502f19d25781770de0a97334d85b782();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GenerateInvoicesReport48_Invoices2.GetUniques_CeBe_CeCo.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_2502f19d25781770de0a97334d85b782)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetUniques_CeBe_CeCo in GenerateInvoicesReport48_Invoices2 in ConectaProveedores (SELECT      STRING_AGG(CeCo, ',') AS CeCo,      STRING_AGG(CeBe, ',') AS CeBe  FROM (      SELECT DISTINCT          CeCo.[Ce_Coste] AS CeCo,          CeBe.[Ce_Coste] AS CeBe      FROM {Invoice}        LEFT JOIN {InvoiceAccounting}          ON {InvoiceAccounting}.[InvoiceId] = {Invoice}.[Id]        LEFT JOIN {InvoiceAccountingServices}          ON {InvoiceAccountingServices}.[InvoiceAccountingId] =             {InvoiceAccounting}.[Id]        LEFT JOIN {CostCenterSAP} CeCo          ON CeCo.[Id] = {InvoiceAccountingServices}.[CostCenterId]        LEFT JOIN {CostCenterSAP} CeBe          ON CeBe.[Id] = {InvoiceAccountingServices}.[CeBeCostCenterId]        WHERE {Invoice}.Id = @InvoiceId  ) AS DistinctValues): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetUniques_CeBe_CeCo in GenerateInvoicesReport48_Invoices2 in ConectaProveedores (SELECT      STRING_AGG(CeCo, ',') AS CeCo,      STRING_AGG(CeBe, ',') AS CeBe  FROM (      SELECT DISTINCT          CeCo.[Ce_Coste] AS CeCo,          CeBe.[Ce_Coste] AS CeBe      FROM {Invoice}        LEFT JOIN {InvoiceAccounting}          ON {InvoiceAccounting}.[InvoiceId] = {Invoice}.[Id]        LEFT JOIN {InvoiceAccountingServices}          ON {InvoiceAccountingServices}.[InvoiceAccountingId] =             {InvoiceAccounting}.[Id]        LEFT JOIN {CostCenterSAP} CeCo          ON CeCo.[Id] = {InvoiceAccountingServices}.[CostCenterId]        LEFT JOIN {CostCenterSAP} CeBe          ON CeBe.[Id] = {InvoiceAccountingServices}.[CeBeCostCenterId]        WHERE {Invoice}.Id = @InvoiceId  ) AS DistinctValues): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetUniques_CeBe_CeCo in GenerateInvoicesReport48_Invoices2 in ConectaProveedores (SELECT      STRING_AGG(CeCo, ',') AS CeCo,      STRING_AGG(CeBe, ',') AS CeBe  FROM (      SELECT DISTINCT          CeCo.[Ce_Coste] AS CeCo,          CeBe.[Ce_Coste] AS CeBe      FROM {Invoice}        LEFT JOIN {InvoiceAccounting}          ON {InvoiceAccounting}.[InvoiceId] = {Invoice}.[Id]        LEFT JOIN {InvoiceAccountingServices}          ON {InvoiceAccountingServices}.[InvoiceAccountingId] =             {InvoiceAccounting}.[Id]        LEFT JOIN {CostCenterSAP} CeCo          ON CeCo.[Id] = {InvoiceAccountingServices}.[CostCenterId]        LEFT JOIN {CostCenterSAP} CeBe          ON CeBe.[Id] = {InvoiceAccountingServices}.[CeBeCostCenterId]        WHERE {Invoice}.Id = @InvoiceId  ) AS DistinctValues): " + aqExcep.Message));
}
}
}


/// <summary>
/// RecordList To Excel: RLToExcelGenerateInvoicesReport48_Invoices2RecordListToExcel2
///  (KOZcdNRWgF0iJU91iPoRBNw) of Action "GenerateInvoicesReport48_Invoices2"
/// </summary>
public static async Task<byte[]> RLToExcelGenerateInvoicesReport48_Invoices2RecordListToExcel2(IRequestContext requestContext,RL_36f497358824531a4d0365a750b33706 ssRecordList,CancellationToken cancellationToken) {
var service = ServiceLocator.GetService<ISpreadsheetService>();
await using var excel = await service.GetWriterAsync(42, cancellationToken);

//Column headers
await excel.CreateRowAsync(0, cancellationToken);
excel.CreateCell("Región");
excel.CreateCell("No. de Proveedor");
excel.CreateCell("Proveedor");
excel.CreateCell("RFC");
excel.CreateCell("N° de Requisición");
excel.CreateCell("Fecha de Creación de Requisición");
excel.CreateCell("Serie Factura");
excel.CreateCell("Factura");
excel.CreateCell("Fecha de la Factura");
excel.CreateCell("Subtotal");
excel.CreateCell("IVA");
excel.CreateCell("IVA Retención");
excel.CreateCell("ISR Retención");
excel.CreateCell("Erogaciones");
excel.CreateCell("Total Factura");
excel.CreateCell("Moneda");
excel.CreateCell("Estatus");
excel.CreateCell("Usuario Asignado");
excel.CreateCell("Fecha de Carga");
excel.CreateCell("Fecha de Vencimiento");
excel.CreateCell("Fecha de Pago");
excel.CreateCell("Descripción");
excel.CreateCell("Centro de Atención");
excel.CreateCell("Calle");
excel.CreateCell("Num Exterior");
excel.CreateCell("Código Postal");
excel.CreateCell("Importe del Traslado");
excel.CreateCell("Nombre PDF");
excel.CreateCell("Nombre XML");
excel.CreateCell("UUID");
excel.CreateCell("N°DEL CECO");
excel.CreateCell("Centros de Costos");
excel.CreateCell("N°DEL CEBE");
excel.CreateCell("Usuarios Aprobadores");
excel.CreateCell("Fecha de llegada a CxP/Egresos");
excel.CreateCell("Periodo Proyecto");
excel.CreateCell("Proyecto");
excel.CreateCell("Periodicidad");
excel.CreateCell("Póliza SAP");
excel.CreateCell("Fecha de Registro Contable Factura en SAP");
excel.CreateCell("Departamento de quien realiza el registro de la factura");
excel.CreateCell("Analista de CxP/Egresos");


if(!ssRecordList.Empty) {
	try {
		ssRecordList.StartIteration();
		for (int i = 1; !ssRecordList.Eof; i++) {
            await excel.CreateRowAsync(i, cancellationToken);
            excel.CreateCell(ssRecordList.CurrentRec.ssRegion);
excel.CreateCell(ssRecordList.CurrentRec.ssSupplierNumber);
excel.CreateCell(ssRecordList.CurrentRec.ssSupplier);
excel.CreateCell(ssRecordList.CurrentRec.ssSupplierRFC);
excel.CreateCell(ssRecordList.CurrentRec.ssRequisitonName);
excel.CreateCell(ssRecordList.CurrentRec.ssRequisitionCreatedOn);
excel.CreateCell(ssRecordList.CurrentRec.ssInvoiceSerie);
excel.CreateCell(ssRecordList.CurrentRec.ssInvoiceNumber);
excel.CreateCell(ssRecordList.CurrentRec.ssInvoiceEmissionDate);
excel.CreateCell(ssRecordList.CurrentRec.ssSubtotal);
excel.CreateCell(ssRecordList.CurrentRec.ssIVA);
excel.CreateCell(ssRecordList.CurrentRec.ssRetentionIVA);
excel.CreateCell(ssRecordList.CurrentRec.ssISRRetention);
excel.CreateCell(ssRecordList.CurrentRec.ssExpenditures);
excel.CreateCell(ssRecordList.CurrentRec.ssTotalAmount);
excel.CreateCell(ssRecordList.CurrentRec.ssCurrency);
excel.CreateCell(ssRecordList.CurrentRec.ssStatus);
excel.CreateCell(ssRecordList.CurrentRec.ssAssignedUser);
excel.CreateCell(ssRecordList.CurrentRec.ssInvoiceCreationDate);
excel.CreateCell(ssRecordList.CurrentRec.ssInvoiceExpirationDate);
excel.CreateCell(ssRecordList.CurrentRec.ssInvoicePaymentDate);
excel.CreateCell(ssRecordList.CurrentRec.ssDescription);
excel.CreateCell(ssRecordList.CurrentRec.ssCentrodeAtencion);
excel.CreateCell(ssRecordList.CurrentRec.ssStreet);
excel.CreateCell(ssRecordList.CurrentRec.ssDoorNumber);
excel.CreateCell(ssRecordList.CurrentRec.ssPostalCode);
excel.CreateCell(ssRecordList.CurrentRec.ssImportTraslado);
excel.CreateCell(ssRecordList.CurrentRec.ssPdfName);
excel.CreateCell(ssRecordList.CurrentRec.ssXmlName);
excel.CreateCell(ssRecordList.CurrentRec.ssUUID);
excel.CreateCell(ssRecordList.CurrentRec.ssIDCeCo);
excel.CreateCell(ssRecordList.CurrentRec.ssCostCenters);
excel.CreateCell(ssRecordList.CurrentRec.ssIDCeBe);
excel.CreateCell(ssRecordList.CurrentRec.ssApprovingUsers);
excel.CreateCell(ssRecordList.CurrentRec.ssInvoiceApprovalDate);
excel.CreateCell(ssRecordList.CurrentRec.ssProjectPeriod);
excel.CreateCell(ssRecordList.CurrentRec.ssProject);
excel.CreateCell(ssRecordList.CurrentRec.ssFrequency);
excel.CreateCell(ssRecordList.CurrentRec.ssSAPNumber);
excel.CreateCell(ssRecordList.CurrentRec.ssSAPRegisterDate);
excel.CreateCell(ssRecordList.CurrentRec.ssApprovalArea);
excel.CreateCell(ssRecordList.CurrentRec.ssAccountingUser);

            ssRecordList.Advance(); 
		}
	} finally {
		ssRecordList.EndIteration();
	}
}

return await excel.SaveAsync(cancellationToken);
}


}


}
