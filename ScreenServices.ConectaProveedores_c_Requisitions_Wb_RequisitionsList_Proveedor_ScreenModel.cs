using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Proveedor_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Proveedor_ScreenModel).Namespace);

    public bool varLcl_ShowFilters;
public string varLcl_TableSort;
public int varLcl_StartIndex;
public bool varLcl_ReInvokeToggler;
public string varLcl_ColumnJSONVarGetRequisitions;
public int varLcl_CountAfterFetchGetRequisitions;
public string varLcl_AmountFromText;
public string varLcl_AmountToText;
public AggregateRecord<RL_baa2f1a64337662e74a4097dbb96f0dc> ScreenDataSetGetRequisitionsProveedor;
public AggregateRecord<RL_060f887b4f32b5cdb78b49175875565c> ScreenDataSetGetCompanies;
public AggregateRecord<RL_39dc6f4415ce9196844d0ada601cc72b> ScreenDataSetGetProjectAssetServices;
public ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Proveedor_DataActionGetDistinctRegions_Model varLcGetDistinctRegions;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Proveedor_ScreenModel() {
}



    public ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Proveedor_ScreenModel(bool varLcl_ShowFilters, string varLcl_TableSort, int varLcl_StartIndex, bool varLcl_ReInvokeToggler, string varLcl_ColumnJSONVarGetRequisitions, int varLcl_CountAfterFetchGetRequisitions, string varLcl_AmountFromText, string varLcl_AmountToText, AggregateRecord<RL_baa2f1a64337662e74a4097dbb96f0dc> ScreenDataSetGetRequisitionsProveedor, AggregateRecord<RL_060f887b4f32b5cdb78b49175875565c> ScreenDataSetGetCompanies, AggregateRecord<RL_39dc6f4415ce9196844d0ada601cc72b> ScreenDataSetGetProjectAssetServices, ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Proveedor_DataActionGetDistinctRegions_Model varLcGetDistinctRegions, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"l_ShowFilters", "l_TableSort", "l_StartIndex", "l_ReInvokeToggler", "l_ColumnJSONVarGetRequisitions", "l_CountAfterFetchGetRequisitions", "l_AmountFromText", "l_AmountToText", "GetRequisitionsProveedor", "GetCompanies", "GetProjectAssetServices", "GetDistinctRegions", "ClientVars"}, new string[] {"varLcl_ShowFilters", "varLcl_TableSort", "varLcl_StartIndex", "varLcl_ReInvokeToggler", "varLcl_ColumnJSONVarGetRequisitions", "varLcl_CountAfterFetchGetRequisitions", "varLcl_AmountFromText", "varLcl_AmountToText", "ScreenDataSetGetRequisitionsProveedor", "ScreenDataSetGetCompanies", "ScreenDataSetGetProjectAssetServices", "varLcGetDistinctRegions", "clientVariables"});
this.varLcl_ShowFilters = varLcl_ShowFilters;
this.varLcl_TableSort = varLcl_TableSort;
this.varLcl_StartIndex = varLcl_StartIndex;
this.varLcl_ReInvokeToggler = varLcl_ReInvokeToggler;
this.varLcl_ColumnJSONVarGetRequisitions = varLcl_ColumnJSONVarGetRequisitions;
this.varLcl_CountAfterFetchGetRequisitions = varLcl_CountAfterFetchGetRequisitions;
this.varLcl_AmountFromText = varLcl_AmountFromText;
this.varLcl_AmountToText = varLcl_AmountToText;
this.ScreenDataSetGetRequisitionsProveedor = ScreenDataSetGetRequisitionsProveedor;
this.ScreenDataSetGetCompanies = ScreenDataSetGetCompanies;
this.ScreenDataSetGetProjectAssetServices = ScreenDataSetGetProjectAssetServices;
this.varLcGetDistinctRegions = varLcGetDistinctRegions;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_01ef322df050d27e5e0ba635cc767de3> datasetGetRequisitionsProveedorReadDbAsync(RC_01ef322df050d27e5e0ba635cc767de3 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENCompany.Read( r, ref index);
rec.ssENCostCenterSAP.Read( r, ref index);
rec.ssENCurrency.Read( r, ref index);
rec.ssENPaymentTerms.Read( r, ref index);
rec.ssENProject_Asset_Service.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
rec.ssENRequisitionStatus.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetRequisitionsProveedor" LHo0WXottkieZwjRnzSB5g of Action "Wb_RequisitionsList_Proveedor"
public static async Task<(RL_baa2f1a64337662e74a4097dbb96f0dc,long)> datasetGetRequisitionsProveedor(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,int qpinOffsetUtc,decimal qpdeRequisitions_AmountFrom,decimal qpdeRequisitions_AmountTo,long qpcoCompany_Id,long qpcoCostCenterSAP_Id,long qpprRequisition_ProjectAssetServiceId,DateTime qpdaRequisitions_ProveedorFilter_UploadDateFrom,DateTime qpdaRequisitions_ProveedorFilter_UploadDateTo,long qpreRequisition_RegionId,string qpteRequisitions_RequisitionSearch,long qpsuSupplier_Id,string qptel_TableSort,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("c_Requisitions.Wb_RequisitionsList_Proveedor.GetRequisitionsProveedor", "59347a2c-2d7a-48b6-9e67-08d19f3481e6");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_RequisitionsList_Proveedor","c_Requisitions.Wb_RequisitionsList_Proveedor.GetRequisitionsProveedor");
// Query Iterations: Multiple
// Refresh Query zqmEKKnReE26qu4F+fhxlw Iterations: Multiple
// Refresh Query hwkYgSNNXEOeX1JnxG3zdw Iterations: Multiple
// Refresh Query qGjQmYv5_kS4Nq+eO51wNg Iterations: Multiple
// Refresh Query oo0QgY1S9UeeFF6J2Dgbww Iterations: Multiple
// Refresh Query SEGE2qsb4kuJKoqp9qtmWA Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
await using(var sqlCountCmd = trans.CreateCommand()){
string sql = "";
string sqlCount = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.OI1Ifiu5bUqaAVBMMmdBPg/ScreenDataSets.LHo0WXottkieZwjRnzSB5g, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"encompany47\".\"description\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, \"encurrency25\".\"code\" o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, \"enproject_asset_service17\".\"description\" o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, \"enrequisition110\".\"id\" o72, \"enrequisition110\".\"name\" o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, trim_scale(\"enrequisition110\".\"totalamount\"::numeric) o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, NULL o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, \"enrequisition110\".\"advwithoutinvoice\" o118, NULL o119, NULL o120, NULL o121, NULL o122, NULL o123, NULL o124, NULL o125, NULL o126, NULL o127, NULL o128, NULL o129, NULL o130, NULL o131, NULL o132, NULL o133, NULL o134, NULL o135, NULL o136, NULL o137, NULL o138, NULL o139, NULL o140, NULL o141, NULL o142, NULL o143, NULL o144, NULL o145, NULL o146, NULL o147, NULL o148, NULL o149, NULL o150, NULL o151, NULL o152, NULL o153, NULL o154, NULL o155, NULL o156, NULL o157, NULL o158, NULL o159, NULL o160, NULL o161, NULL o162, NULL o163");
fromBuilder.Append(" FROM (((((((({Requisition} \"enrequisition110\" Left JOIN {RequisitionStatus} \"enrequisitionstatus2\" ON (\"enrequisition110\".\"requisitionstatusid\" = \"enrequisitionstatus2\".\"id\"))  Left JOIN {Company} \"encompany47\" ON (\"enrequisition110\".\"companyid\" = \"encompany47\".\"id\"))  Left JOIN {Project_Asset_Service} \"enproject_asset_service17\" ON (\"enrequisition110\".\"projectassetserviceid\" = \"enproject_asset_service17\".\"id\"))  Left JOIN {Region} \"enregion141\" ON (\"enrequisition110\".\"regionid\" = \"enregion141\".\"id\"))  Left JOIN {Currency} \"encurrency25\" ON (\"enrequisition110\".\"currencyid\" = \"encurrency25\".\"code\"))  Left JOIN {CostCenterSAP} \"encostcentersap15\" ON (\"enrequisition110\".\"costcenterid\" = \"encostcentersap15\".\"id\"))  Left JOIN {Supplier} \"ensupplier111\" ON (\"enrequisition110\".\"supplierid\" = \"ensupplier111\".\"id\"))  Left JOIN {PaymentTerms} \"enpaymentterms29\" ON (\"enrequisition110\".\"paymenttermsid\" = \"enpaymentterms29\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpteRequisitions_RequisitionSearch != "" && qpteRequisitions_RequisitionSearch != "") {
whereBuilder.Append("(caseaccent_normalize(\"enrequisition110\".\"name\" collate \"default\") like caseaccent_normalize((('%' || @qpteRequisitions_RequisitionSearch) || '%') collate \"default\")) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteRequisitions_RequisitionSearch", DbType.String, qpteRequisitions_RequisitionSearch);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteRequisitions_RequisitionSearch", DbType.String, qpteRequisitions_RequisitionSearch);
}
if (qpprRequisition_ProjectAssetServiceId != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpprRequisition_ProjectAssetServiceId != 0) {
whereBuilder.Append("((\"enrequisition110\".\"projectassetserviceid\" = @qpprRequisition_ProjectAssetServiceId) AND (\"enrequisition110\".\"projectassetserviceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprRequisition_ProjectAssetServiceId", DbType.Int64, qpprRequisition_ProjectAssetServiceId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpprRequisition_ProjectAssetServiceId", DbType.Int64, qpprRequisition_ProjectAssetServiceId);
} else {
whereBuilder.Append("(\"enrequisition110\".\"projectassetserviceid\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpcoCompany_Id != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
whereBuilder.Append("(@qpcoCompany_Id = @qpcoCompany_Id) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpcoCompany_Id", DbType.Int64, qpcoCompany_Id);
sqlCountCmd.CreateParameterWithoutReplacements("@qpcoCompany_Id", DbType.Int64, qpcoCompany_Id);
}
if (qpdeRequisitions_AmountFrom != (((decimal)0))) {
whereBuilder.Append("(\"enrequisition110\".\"totalamount\" >= @qpdeRequisitions_AmountFrom) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpdeRequisitions_AmountFrom", DbType.Decimal, qpdeRequisitions_AmountFrom);
sqlCountCmd.CreateParameterWithoutReplacements("@qpdeRequisitions_AmountFrom", DbType.Decimal, qpdeRequisitions_AmountFrom);
}
if (qpdeRequisitions_AmountTo != (((decimal)0))) {
whereBuilder.Append("(\"enrequisition110\".\"totalamount\" <= @qpdeRequisitions_AmountTo) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpdeRequisitions_AmountTo", DbType.Decimal, qpdeRequisitions_AmountTo);
sqlCountCmd.CreateParameterWithoutReplacements("@qpdeRequisitions_AmountTo", DbType.Decimal, qpdeRequisitions_AmountTo);
}
if (qpcoCostCenterSAP_Id != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpcoCostCenterSAP_Id != 0) {
whereBuilder.Append("((\"encostcentersap15\".\"id\" = @qpcoCostCenterSAP_Id) AND (\"encostcentersap15\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpcoCostCenterSAP_Id", DbType.Int64, qpcoCostCenterSAP_Id);
sqlCountCmd.CreateParameterWithoutReplacements("@qpcoCostCenterSAP_Id", DbType.Int64, qpcoCostCenterSAP_Id);
} else {
whereBuilder.Append("(\"encostcentersap15\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpdaRequisitions_ProveedorFilter_UploadDateFrom != BuiltInFunction.NullDate()) {
whereBuilder.Append("((cast(((\"enrequisition110\".\"createdon\"::timestamptz + ((cast((@qpinOffsetUtc * (-1)) as integer)) * interval '1 hour'))) as date)::timestamptz) >= @qpdaRequisitions_ProveedorFilter_UploadDateFrom) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpinOffsetUtc", DbType.Int32, qpinOffsetUtc);
sqlCountCmd.CreateParameterWithoutReplacements("@qpinOffsetUtc", DbType.Int32, qpinOffsetUtc);
sqlCmd.CreateParameterWithoutReplacements("@qpdaRequisitions_ProveedorFilter_UploadDateFrom", DbType.DateTime, qpdaRequisitions_ProveedorFilter_UploadDateFrom);
sqlCountCmd.CreateParameterWithoutReplacements("@qpdaRequisitions_ProveedorFilter_UploadDateFrom", DbType.DateTime, qpdaRequisitions_ProveedorFilter_UploadDateFrom);
}
if (qpdaRequisitions_ProveedorFilter_UploadDateTo != BuiltInFunction.NullDate()) {
whereBuilder.Append("((cast(((\"enrequisition110\".\"createdon\"::timestamptz + ((cast((@qpinOffsetUtc * (-1)) as integer)) * interval '1 hour'))) as date)::timestamptz) <= @qpdaRequisitions_ProveedorFilter_UploadDateTo) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpinOffsetUtc", DbType.Int32, qpinOffsetUtc);
sqlCountCmd.CreateParameterWithoutReplacements("@qpinOffsetUtc", DbType.Int32, qpinOffsetUtc);
sqlCmd.CreateParameterWithoutReplacements("@qpdaRequisitions_ProveedorFilter_UploadDateTo", DbType.DateTime, qpdaRequisitions_ProveedorFilter_UploadDateTo);
sqlCountCmd.CreateParameterWithoutReplacements("@qpdaRequisitions_ProveedorFilter_UploadDateTo", DbType.DateTime, qpdaRequisitions_ProveedorFilter_UploadDateTo);
}
if (qpcoCompany_Id != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpcoCompany_Id != 0) {
whereBuilder.Append("((\"encompany47\".\"id\" = @qpcoCompany_Id) AND (\"encompany47\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpcoCompany_Id", DbType.Int64, qpcoCompany_Id);
sqlCountCmd.CreateParameterWithoutReplacements("@qpcoCompany_Id", DbType.Int64, qpcoCompany_Id);
} else {
whereBuilder.Append("(\"encompany47\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
whereBuilder.Append("(@qpboCheckUserSession = 1) AND (\"enrequisition110\".\"requisitionstatusid\" = ");
whereBuilder.Append((ENRequisitionStatusEntity.GetRecordByKey(ObjectKey.Parse("Mh9oh8XO1EONnOOs1HKCZA"))).ssId);
whereBuilder.Append(") AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
sqlCountCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qpsuSupplier_Id != 0) {
whereBuilder.Append("((\"ensupplier111\".\"id\" = @qpsuSupplier_Id) AND (\"ensupplier111\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuSupplier_Id", DbType.Int64, qpsuSupplier_Id);
sqlCountCmd.CreateParameterWithoutReplacements("@qpsuSupplier_Id", DbType.Int64, qpsuSupplier_Id);
} else {
whereBuilder.Append("(\"ensupplier111\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ");
if (qpreRequisition_RegionId != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpreRequisition_RegionId != 0) {
whereBuilder.Append("((\"enrequisition110\".\"regionid\" = @qpreRequisition_RegionId) AND (\"enrequisition110\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisition_RegionId", DbType.Int64, qpreRequisition_RegionId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpreRequisition_RegionId", DbType.Int64, qpreRequisition_RegionId);
} else {
whereBuilder.Append("(\"enrequisition110\".\"regionid\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
whereBuilder.Append("((NOT (\"enrequisition110\".\"wasadvwithoutinvoice\" = 1)) OR ((\"enrequisition110\".\"accountingdate\"::date <> (date '1900-01-01')::date) AND (((to_timestamp(@qepCurrdatetime, 'YYYY-MM-DD HH24:MI:SS'))) > ((\"enrequisition110\".\"accountingdate\"::timestamptz + ((cast((coalesce(cast(nullif(\"enpaymentterms29\".\"ctd_dias\",'') as integer), 0)) as integer)) * interval '1 day'))))))");
orderByBuilder.Append(" ORDER BY ");
List<string> orderByColumns = new List<string>();
orderByColumns.AddRange(BaseAppUtils.ReplaceEntityReferencesAndAttributesInOrderBy(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, qptel_TableSort, new string[] { "CostCenterSAP", "PaymentTerms", "Project_Asset_Service", "Currency", "Region", "Company", "Requisition", "RequisitionStatus", "Supplier" }, new string[] { "ENCostCenterSAP15", "ENPaymentTerms29", "ENProject_Asset_Service17", "ENCurrency25", "ENRegion141", "ENCompany47", "ENRequisition110", "ENRequisitionStatus2", "ENSupplier111" }, new System.Collections.Generic.Dictionary<string, string>[] { ENCostCenterSAPEntity.AttributesToDatabaseNamesMap(), ENPaymentTermsEntity.AttributesToDatabaseNamesMap(), ENProject_Asset_ServiceEntity.AttributesToDatabaseNamesMap(), ENCurrencyEntity.AttributesToDatabaseNamesMap(), ENRegionEntity.AttributesToDatabaseNamesMap(), ENCompanyEntity.AttributesToDatabaseNamesMap(), ENRequisitionEntity.AttributesToDatabaseNamesMap(), ENRequisitionStatusEntity.AttributesToDatabaseNamesMap(), ENSupplierEntity.AttributesToDatabaseNamesMap() }).Split(','));
orderByColumns.Add("\"enrequisition110\".\"createdon\" DESC ");
orderByBuilder.Append(BaseAppUtils.GetOrderByColumnsWithoutDuplicates(orderByColumns));
sqlCmd.CreateParameterWithoutReplacements("@qepCurrdatetime", DbType.String, System.DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss"));
sqlCountCmd.CreateParameterWithoutReplacements("@qepCurrdatetime", DbType.String, System.DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss"));
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
if (startIndex > 0) {
orderByBuilder.Append(" OFFSET ");
orderByBuilder.Append(startIndex);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCount = "SELECT COUNT(1) " + fromBuilder.ToString() + whereBuilder.ToString() + groupByBuilder.ToString() + havingBuilder.ToString();
sqlCount = AppUtils.Instance.ReplaceEntityReferences(requestContext, sqlCount);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
sqlCountCmd.CommandText = sqlCount;
try {
RL_baa2f1a64337662e74a4097dbb96f0dc outParamList = new RL_baa2f1a64337662e74a4097dbb96f0dc();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetRequisitionsProveedorReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[9];
opt[0] = new BitArray(new bool[] {false, true, true, true, true});
opt[1] = new BitArray(new bool[] {false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, false, true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[6] = new BitArray(new bool[] {true, false, true, true, true, true, true});
opt[7] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true});
opt[8] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query c_Requisitions.Wb_RequisitionsList_Proveedor.GetRequisitionsProveedor.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.Wb_RequisitionsList_Proveedor.GetRequisitionsProveedor.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_baa2f1a64337662e74a4097dbb96f0dc _tmp = new RL_baa2f1a64337662e74a4097dbb96f0dc();
_tmp.AlternateReadDbMethodAsync = datasetGetRequisitionsProveedorReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.Wb_RequisitionsList_Proveedor.GetRequisitionsProveedor.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_baa2f1a64337662e74a4097dbb96f0dc)_tmp;
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query c_Requisitions.Wb_RequisitionsList_Proveedor.GetRequisitionsProveedor.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
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

// Query Function "GetCompanies" Ml+9yPD7qkKmqV8DII13GQ of Action "Wb_RequisitionsList_Proveedor"
public static async Task<(RL_060f887b4f32b5cdb78b49175875565c,long)> datasetGetCompanies(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("c_Requisitions.Wb_RequisitionsList_Proveedor.GetCompanies", "c8bd5f32-fbf0-42aa-a6a9-5f03208d7719");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_RequisitionsList_Proveedor","c_Requisitions.Wb_RequisitionsList_Proveedor.GetCompanies");
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
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.OI1Ifiu5bUqaAVBMMmdBPg/ScreenDataSets.Ml+9yPD7qkKmqV8DII13GQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"encompany48\".\"id\" o0, NULL o1, \"encompany48\".\"description\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10");
fromBuilder.Append(" FROM {Company} \"encompany48\"");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1)");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
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
RL_060f887b4f32b5cdb78b49175875565c outParamList = new RL_060f887b4f32b5cdb78b49175875565c();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, false, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.Wb_RequisitionsList_Proveedor.GetCompanies.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_060f887b4f32b5cdb78b49175875565c _tmp = new RL_060f887b4f32b5cdb78b49175875565c();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.Wb_RequisitionsList_Proveedor.GetCompanies.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_060f887b4f32b5cdb78b49175875565c)_tmp;
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

// Query Function "GetProjectAssetServices" QxL5_2ScdEWpUzmXuwcX8Q of Action "Wb_RequisitionsList_Proveedor"
public static async Task<(RL_39dc6f4415ce9196844d0ada601cc72b,long)> datasetGetProjectAssetServices(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("c_Requisitions.Wb_RequisitionsList_Proveedor.GetProjectAssetServices", "fff91243-9c64-4574-a953-3997bb0717f1");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_RequisitionsList_Proveedor","c_Requisitions.Wb_RequisitionsList_Proveedor.GetProjectAssetServices");
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
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.OI1Ifiu5bUqaAVBMMmdBPg/ScreenDataSets.QxL5_2ScdEWpUzmXuwcX8Q, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enproject_asset_service18\".\"id\" o0, \"enproject_asset_service18\".\"description\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6");
fromBuilder.Append(" FROM {Project_Asset_Service} \"enproject_asset_service18\"");
orderByBuilder.Append(" ORDER BY \"enproject_asset_service18\".\"description\" ASC ");
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
RL_39dc6f4415ce9196844d0ada601cc72b outParamList = new RL_39dc6f4415ce9196844d0ada601cc72b();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.Wb_RequisitionsList_Proveedor.GetProjectAssetServices.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_39dc6f4415ce9196844d0ada601cc72b _tmp = new RL_39dc6f4415ce9196844d0ada601cc72b();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.Wb_RequisitionsList_Proveedor.GetProjectAssetServices.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_39dc6f4415ce9196844d0ada601cc72b)_tmp;
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


    public class lcvGetDistinctRegions : VarsBag {
public RL_ef054de7efcbb2333554911096d83023 queryResGetRegions_outParamList = new RL_ef054de7efcbb2333554911096d83023();
public long queryResGetRegions_outParamCount = 0L;

public lcvGetDistinctRegions() {
}
}
public class lcoGetDistinctRegions : VarsBag {
public RL_66e54aa915d6f6db629964a69a34a959 outParamRegionsList = new RL_66e54aa915d6f6db629964a69a34a959();

public lcoGetDistinctRegions() {
}
}
/// <summary>
/// Action <code>GetDistinctRegions</code> that represents the Service Studio action
///  <code>GetDistinctRegions</code> <p> Description: </p>
/// </summary>
public async Task<RL_66e54aa915d6f6db629964a69a34a959> DataActionGetDistinctRegions(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_66e54aa915d6f6db629964a69a34a959 outParamRegionsList = default;
lcoGetDistinctRegions result = new lcoGetDistinctRegions();
lcvGetDistinctRegions localVars = new lcvGetDistinctRegions();
ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Proveedor_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetDistinctRegions", "fbc604e6-4904-4e2f-ab60-638e31d9acc3"))
using (activitySource.CreateScreenDataActionActivity("Wb_RequisitionsList_Proveedor", "GetDistinctRegions")){
// Query QueryGetRegions
cancellationToken.ThrowIfCancellationRequested();
int QueryGetRegions_maxRecords = 0;
int QueryGetRegions_startIndex = 0;(localVars.queryResGetRegions_outParamList,localVars.queryResGetRegions_outParamCount) = await FuncDataActionGetDistinctRegions.QueryGetRegions(requestContext,QueryGetRegions_maxRecords,QueryGetRegions_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionGetUserSupplier(requestContext,"",cancellationToken)),model.clientVariables.ssAccountStatus_RegionId,(ENRequisitionStatusEntity.GetRecordByKey(ObjectKey.Parse("Mh9oh8XO1EONnOOs1HKCZA"))).ssId,Convert.ToInt64(BuiltInFunction.NullIdentifier ()),cancellationToken);

// RegionsList = GetRegions.List
result.outParamRegionsList=(await RL_66e54aa915d6f6db629964a69a34a959.ConvertAsync(localVars.queryResGetRegions_outParamList, new RL_66e54aa915d6f6db629964a69a34a959(), async (RC_961fb69f34436852965350a75ed3c8b8 source, ST_1d2d09c8b788d410a2c7ddc6277e6c9aStructure target, CancellationToken cancellationToken) => {
target = source;
return target;
}, cancellationToken));
} //close CreateActionActivity using block
} // try

finally {
outParamRegionsList = result.outParamRegionsList;
} // inner-finally
RETURN_STATEMENT:
return outParamRegionsList;
}


    public static class FuncDataActionGetDistinctRegions {

// Query Function "GetRegions" IJ4dNoSvmUigndte8kQTDg of Action "GetDistinctRegions"
public static async Task<(RL_ef054de7efcbb2333554911096d83023,long)> QueryGetRegions(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpsui_SupplierId,long qprei_RegionId,int qprei_RequisitionStatusApproved,long qprei_NullIdentifier,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("c_Requisitions.Wb_RequisitionsList_Proveedor.GetDistinctRegions.GetRegions", "361d9e20-af84-4899-a09d-db5ef244130e");
using var queryActivity = activitySource.CreateSqlQueryActivity("c_Requisitions.Wb_RequisitionsList_Proveedor.GetDistinctRegions.GetRegions", "361d9e20-af84-4899-a09d-db5ef244130e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string entityRegion = AppUtils.Instance.RuntimeEntityReplace("Region");
string entityRequisition = AppUtils.Instance.RuntimeEntityReplace("Requisition");
sqlCmd.CreateParameter("@qpsui_SupplierId", DbType.Int64, qpsui_SupplierId);
sqlCmd.CreateParameter("@qprei_RegionId", DbType.Int64, qprei_RegionId);
sqlCmd.CreateParameter("@qprei_NullIdentifier", DbType.Int64, qprei_NullIdentifier);
sqlCmd.CreateParameter("@qprei_RequisitionStatusApproved", DbType.Int32, qprei_RequisitionStatusApproved);
string sql = "";
string advSql = "SELECT DISTINCT  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"id\"") + ",  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"code\"") + ",  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"name\"") + " \nFROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,"") + " \nJOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,"") + " \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + " \nWHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"supplierid\"") + " = @qpsui_SupplierId \nAND (@qprei_RegionId = @qprei_NullIdentifier OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + " = @qprei_RegionId) \nAND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"requisitionstatusid\"") + " = @qprei_RequisitionStatusApproved";
sql = advSql;
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_ef054de7efcbb2333554911096d83023 outParamList = new RL_ef054de7efcbb2333554911096d83023();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.Wb_RequisitionsList_Proveedor.GetDistinctRegions.GetRegions.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_ef054de7efcbb2333554911096d83023 _tmp = new RL_ef054de7efcbb2333554911096d83023();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.Wb_RequisitionsList_Proveedor.GetDistinctRegions.GetRegions.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_ef054de7efcbb2333554911096d83023)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetRegions in GetDistinctRegions in Wb_RequisitionsList_Proveedor in c_Requisitions in ConectaProveedores (SELECT DISTINCT {Region}.[Id], {Region}.[Code], {Region}.[Name]  FROM {Requisition}  JOIN {Region}      ON {Region}.[Id] = {Requisition}.[RegionId]  WHERE {Requisition}.[SupplierId] = @i_SupplierId  AND (@i_RegionId = @i_NullIdentifier OR {Requisition}.[RegionId] = @i_RegionId)  AND {Requisition}.[RequisitionStatusId] = @i_RequisitionStatusApproved): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetRegions in GetDistinctRegions in Wb_RequisitionsList_Proveedor in c_Requisitions in ConectaProveedores (SELECT DISTINCT {Region}.[Id], {Region}.[Code], {Region}.[Name]  FROM {Requisition}  JOIN {Region}      ON {Region}.[Id] = {Requisition}.[RegionId]  WHERE {Requisition}.[SupplierId] = @i_SupplierId  AND (@i_RegionId = @i_NullIdentifier OR {Requisition}.[RegionId] = @i_RegionId)  AND {Requisition}.[RequisitionStatusId] = @i_RequisitionStatusApproved): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetRegions in GetDistinctRegions in Wb_RequisitionsList_Proveedor in c_Requisitions in ConectaProveedores (SELECT DISTINCT {Region}.[Id], {Region}.[Code], {Region}.[Name]  FROM {Requisition}  JOIN {Region}      ON {Region}.[Id] = {Requisition}.[RegionId]  WHERE {Requisition}.[SupplierId] = @i_SupplierId  AND (@i_RegionId = @i_NullIdentifier OR {Requisition}.[RegionId] = @i_RegionId)  AND {Requisition}.[RequisitionStatusId] = @i_RequisitionStatusApproved): " + aqExcep.Message));
}
}
}
}


}
