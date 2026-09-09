using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_c_Requisitions_Wb_RequisitionUploadInv_Internal_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_c_Requisitions_Wb_RequisitionUploadInv_Internal_ScreenModel).Namespace);

    public bool varLcl_ShowFilters;
public string varLcl_TableSort;
public int varLcl_StartIndex;
public bool varLcl_ReInvokeToggler;
public string varLcl_ColumnJSONVarGetRequisitions;
public int varLcl_CountAfterFetchGetRequisitions;
public string varLcl_AmountFromText;
public string varLcl_AmountToText;
public AggregateRecord<RL_39dc6f4415ce9196844d0ada601cc72b> ScreenDataSetGetProjectAssetServices;
public AggregateRecord<RL_39c5627b3bb44cc40b890ccd9b2786b2> ScreenDataSetGetRequisitionsForUpload;
public AggregateRecord<RL_060f887b4f32b5cdb78b49175875565c> ScreenDataSetGetCompanies;
public ConectaProveedores_c_Requisitions_Wb_RequisitionUploadInv_Internal_DataActionGetApprovalProcessIds2_Model varLcGetApprovalProcessIds2;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_c_Requisitions_Wb_RequisitionUploadInv_Internal_ScreenModel() {
}



    public ConectaProveedores_c_Requisitions_Wb_RequisitionUploadInv_Internal_ScreenModel(bool varLcl_ShowFilters, string varLcl_TableSort, int varLcl_StartIndex, bool varLcl_ReInvokeToggler, string varLcl_ColumnJSONVarGetRequisitions, int varLcl_CountAfterFetchGetRequisitions, string varLcl_AmountFromText, string varLcl_AmountToText, AggregateRecord<RL_39dc6f4415ce9196844d0ada601cc72b> ScreenDataSetGetProjectAssetServices, AggregateRecord<RL_39c5627b3bb44cc40b890ccd9b2786b2> ScreenDataSetGetRequisitionsForUpload, AggregateRecord<RL_060f887b4f32b5cdb78b49175875565c> ScreenDataSetGetCompanies, ConectaProveedores_c_Requisitions_Wb_RequisitionUploadInv_Internal_DataActionGetApprovalProcessIds2_Model varLcGetApprovalProcessIds2, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"l_ShowFilters", "l_TableSort", "l_StartIndex", "l_ReInvokeToggler", "l_ColumnJSONVarGetRequisitions", "l_CountAfterFetchGetRequisitions", "l_AmountFromText", "l_AmountToText", "GetProjectAssetServices", "GetRequisitionsForUpload", "GetCompanies", "GetApprovalProcessIds2", "ClientVars"}, new string[] {"varLcl_ShowFilters", "varLcl_TableSort", "varLcl_StartIndex", "varLcl_ReInvokeToggler", "varLcl_ColumnJSONVarGetRequisitions", "varLcl_CountAfterFetchGetRequisitions", "varLcl_AmountFromText", "varLcl_AmountToText", "ScreenDataSetGetProjectAssetServices", "ScreenDataSetGetRequisitionsForUpload", "ScreenDataSetGetCompanies", "varLcGetApprovalProcessIds2", "clientVariables"});
this.varLcl_ShowFilters = varLcl_ShowFilters;
this.varLcl_TableSort = varLcl_TableSort;
this.varLcl_StartIndex = varLcl_StartIndex;
this.varLcl_ReInvokeToggler = varLcl_ReInvokeToggler;
this.varLcl_ColumnJSONVarGetRequisitions = varLcl_ColumnJSONVarGetRequisitions;
this.varLcl_CountAfterFetchGetRequisitions = varLcl_CountAfterFetchGetRequisitions;
this.varLcl_AmountFromText = varLcl_AmountFromText;
this.varLcl_AmountToText = varLcl_AmountToText;
this.ScreenDataSetGetProjectAssetServices = ScreenDataSetGetProjectAssetServices;
this.ScreenDataSetGetRequisitionsForUpload = ScreenDataSetGetRequisitionsForUpload;
this.ScreenDataSetGetCompanies = ScreenDataSetGetCompanies;
this.varLcGetApprovalProcessIds2 = varLcGetApprovalProcessIds2;
this.clientVariables = clientVariables;
}



    
// Query Function "GetProjectAssetServices" 0dIJF2ZpQkaEiDgFso+IvA of Action "Wb_RequisitionUploadInv_Internal"
public static async Task<(RL_39dc6f4415ce9196844d0ada601cc72b,long)> datasetGetProjectAssetServices(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("c_Requisitions.Wb_RequisitionUploadInv_Internal.GetProjectAssetServices", "1709d2d1-6966-4642-8488-3805b28f88bc");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_RequisitionUploadInv_Internal","c_Requisitions.Wb_RequisitionUploadInv_Internal.GetProjectAssetServices");
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
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.5U95CtIKckSUy9+VjK8vfA/ScreenDataSets.0dIJF2ZpQkaEiDgFso+IvA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enproject_asset_service15\".\"id\" o0, \"enproject_asset_service15\".\"description\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6");
fromBuilder.Append(" FROM {Project_Asset_Service} \"enproject_asset_service15\"");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.Wb_RequisitionUploadInv_Internal.GetProjectAssetServices.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.Wb_RequisitionUploadInv_Internal.GetProjectAssetServices.List", cancellationToken: cancellationToken);
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

private static async Task<RC_86423f353b6ff38800cf09bdbbb2131d> datasetGetRequisitionsForUploadReadDbAsync(RC_86423f353b6ff38800cf09bdbbb2131d rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENCompany.Read( r, ref index);
rec.ssENCostCenterSAP.Read( r, ref index);
rec.ssENCurrency.Read( r, ref index);
rec.ssENProject_Asset_Service.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
rec.ssENRequisitionApproval.Read( r, ref index);
rec.ssENRequisitionStatus.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetRequisitionsForUpload" _QB7e5+T4EqwhMnl09rfpQ of Action "Wb_RequisitionUploadInv_Internal"
public static async Task<(RL_39c5627b3bb44cc40b890ccd9b2786b2,long)> datasetGetRequisitionsForUpload(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,decimal qpdeRequisitions_AmountFrom,decimal qpdeRequisitions_AmountTo,long qpcoCompany_Id,long qpcoCostCenterSAP_Id,long qpprRequisition_ProjectAssetServiceId,DateTime qpdaRequisitions_ProveedorFilter_UploadDateFrom,DateTime qpdaRequisitions_ProveedorFilter_UploadDateTo,long qpreRequisition_RegionId,string qpteRequisitions_RequisitionSearch,string qpteo_ApprovalProcessIds,long qpreRequisition_RegionId1,string qptel_TableSort,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("c_Requisitions.Wb_RequisitionUploadInv_Internal.GetRequisitionsForUpload", "7b7b00fd-939f-4ae0-b084-c9e5d3dadfa5");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_RequisitionUploadInv_Internal","c_Requisitions.Wb_RequisitionUploadInv_Internal.GetRequisitionsForUpload");
// Query Iterations: Multiple
// Refresh Query gsZ2XZk5tE+VPskie6ttPA Iterations: Multiple
// Refresh Query EECHqVRE3U+tfpCObouefQ Iterations: Multiple
// Refresh Query m7zbl7zSP0KHCbO0m2r2pg Iterations: Multiple
// Refresh Query DujxX6kFiU2maKoIQqR4+A Iterations: Multiple
// Refresh Query tNw2tNtIB0CSelY5zwuk4g Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.5U95CtIKckSUy9+VjK8vfA/ScreenDataSets._QB7e5+T4EqwhMnl09rfpQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"encompany45\".\"description\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, \"encurrency24\".\"code\" o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, \"enproject_asset_service16\".\"description\" o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, \"enrequisition107\".\"id\" o48, \"enrequisition107\".\"name\" o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, trim_scale(\"enrequisition107\".\"totalamount\"::numeric) o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, \"enrequisition107\".\"advwithoutinvoice\" o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, NULL o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, NULL o118, NULL o119, NULL o120, NULL o121, NULL o122, NULL o123, NULL o124, NULL o125, NULL o126, NULL o127, NULL o128, NULL o129, NULL o130, NULL o131, NULL o132, NULL o133, NULL o134, NULL o135, NULL o136, NULL o137, NULL o138, NULL o139, NULL o140, NULL o141, NULL o142, NULL o143, NULL o144, NULL o145, NULL o146, NULL o147, NULL o148, NULL o149");
fromBuilder.Append(" FROM ((((((({Requisition} \"enrequisition107\" Left JOIN {RequisitionStatus} \"enrequisitionstatus1\" ON (\"enrequisition107\".\"requisitionstatusid\" = \"enrequisitionstatus1\".\"id\"))  Left JOIN {Company} \"encompany45\" ON (\"enrequisition107\".\"companyid\" = \"encompany45\".\"id\"))  Left JOIN {Project_Asset_Service} \"enproject_asset_service16\" ON (\"enrequisition107\".\"projectassetserviceid\" = \"enproject_asset_service16\".\"id\"))  Left JOIN {Currency} \"encurrency24\" ON (\"enrequisition107\".\"currencyid\" = \"encurrency24\".\"code\"))  Left JOIN {CostCenterSAP} \"encostcentersap14\" ON (\"enrequisition107\".\"costcenterid\" = \"encostcentersap14\".\"id\"))  Left JOIN {Supplier} \"ensupplier108\" ON (\"enrequisition107\".\"supplierid\" = \"ensupplier108\".\"id\"))  Left JOIN {RequisitionApproval} \"enrequisitionapproval27\" ON (\"enrequisition107\".\"id\" = \"enrequisitionapproval27\".\"requisitionid\")) ");
whereBuilder.Append(" WHERE ");
if (qpteRequisitions_RequisitionSearch != "" && qpteRequisitions_RequisitionSearch != "") {
whereBuilder.Append("(caseaccent_normalize(\"enrequisition107\".\"name\" collate \"default\") like caseaccent_normalize((('%' || @qpteRequisitions_RequisitionSearch) || '%') collate \"default\")) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteRequisitions_RequisitionSearch", DbType.String, qpteRequisitions_RequisitionSearch);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteRequisitions_RequisitionSearch", DbType.String, qpteRequisitions_RequisitionSearch);
}
if (qpprRequisition_ProjectAssetServiceId != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpprRequisition_ProjectAssetServiceId != 0) {
whereBuilder.Append("((\"enrequisition107\".\"projectassetserviceid\" = @qpprRequisition_ProjectAssetServiceId) AND (\"enrequisition107\".\"projectassetserviceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprRequisition_ProjectAssetServiceId", DbType.Int64, qpprRequisition_ProjectAssetServiceId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpprRequisition_ProjectAssetServiceId", DbType.Int64, qpprRequisition_ProjectAssetServiceId);
} else {
whereBuilder.Append("(\"enrequisition107\".\"projectassetserviceid\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpcoCompany_Id != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
whereBuilder.Append("(@qpcoCompany_Id = @qpcoCompany_Id) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpcoCompany_Id", DbType.Int64, qpcoCompany_Id);
sqlCountCmd.CreateParameterWithoutReplacements("@qpcoCompany_Id", DbType.Int64, qpcoCompany_Id);
}
if (qpdeRequisitions_AmountFrom != (((decimal)0))) {
whereBuilder.Append("(\"enrequisition107\".\"totalamount\" >= @qpdeRequisitions_AmountFrom) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpdeRequisitions_AmountFrom", DbType.Decimal, qpdeRequisitions_AmountFrom);
sqlCountCmd.CreateParameterWithoutReplacements("@qpdeRequisitions_AmountFrom", DbType.Decimal, qpdeRequisitions_AmountFrom);
}
if (qpdeRequisitions_AmountTo != (((decimal)0))) {
whereBuilder.Append("(\"enrequisition107\".\"totalamount\" <= @qpdeRequisitions_AmountTo) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpdeRequisitions_AmountTo", DbType.Decimal, qpdeRequisitions_AmountTo);
sqlCountCmd.CreateParameterWithoutReplacements("@qpdeRequisitions_AmountTo", DbType.Decimal, qpdeRequisitions_AmountTo);
}
if (qpcoCostCenterSAP_Id != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpcoCostCenterSAP_Id != 0) {
whereBuilder.Append("((\"encostcentersap14\".\"id\" = @qpcoCostCenterSAP_Id) AND (\"encostcentersap14\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpcoCostCenterSAP_Id", DbType.Int64, qpcoCostCenterSAP_Id);
sqlCountCmd.CreateParameterWithoutReplacements("@qpcoCostCenterSAP_Id", DbType.Int64, qpcoCostCenterSAP_Id);
} else {
whereBuilder.Append("(\"encostcentersap14\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
whereBuilder.Append("(((@qpdaRequisitions_ProveedorFilter_UploadDateFrom = (date '1900-01-01')) OR ((cast(\"enrequisition107\".\"createdon\" as date)::timestamptz) >= @qpdaRequisitions_ProveedorFilter_UploadDateFrom)) AND ((@qpdaRequisitions_ProveedorFilter_UploadDateTo = (date '1900-01-01')) OR ((cast(\"enrequisition107\".\"createdon\" as date)::timestamptz) <= @qpdaRequisitions_ProveedorFilter_UploadDateTo))) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpdaRequisitions_ProveedorFilter_UploadDateFrom", DbType.DateTime, qpdaRequisitions_ProveedorFilter_UploadDateFrom);
sqlCountCmd.CreateParameterWithoutReplacements("@qpdaRequisitions_ProveedorFilter_UploadDateFrom", DbType.DateTime, qpdaRequisitions_ProveedorFilter_UploadDateFrom);
sqlCmd.CreateParameterWithoutReplacements("@qpdaRequisitions_ProveedorFilter_UploadDateTo", DbType.DateTime, qpdaRequisitions_ProveedorFilter_UploadDateTo);
sqlCountCmd.CreateParameterWithoutReplacements("@qpdaRequisitions_ProveedorFilter_UploadDateTo", DbType.DateTime, qpdaRequisitions_ProveedorFilter_UploadDateTo);
if (qpcoCompany_Id != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpcoCompany_Id != 0) {
whereBuilder.Append("((\"encompany45\".\"id\" = @qpcoCompany_Id) AND (\"encompany45\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpcoCompany_Id", DbType.Int64, qpcoCompany_Id);
sqlCountCmd.CreateParameterWithoutReplacements("@qpcoCompany_Id", DbType.Int64, qpcoCompany_Id);
} else {
whereBuilder.Append("(\"encompany45\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
whereBuilder.Append("(@qpboCheckUserSession = 1) AND (\"enrequisition107\".\"requisitionstatusid\" = ");
whereBuilder.Append((ENRequisitionStatusEntity.GetRecordByKey(ObjectKey.Parse("Mh9oh8XO1EONnOOs1HKCZA"))).ssId);
whereBuilder.Append(") AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
sqlCountCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qpreRequisition_RegionId != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpreRequisition_RegionId != 0) {
whereBuilder.Append("((\"enrequisition107\".\"regionid\" = @qpreRequisition_RegionId) AND (\"enrequisition107\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisition_RegionId", DbType.Int64, qpreRequisition_RegionId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpreRequisition_RegionId", DbType.Int64, qpreRequisition_RegionId);
} else {
whereBuilder.Append("(\"enrequisition107\".\"regionid\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
whereBuilder.Append("(((CASE WHEN char_length(caseaccent_normalize(cast(\"enrequisitionapproval27\".\"aprovalprocessid\" as text) collate \"default\"))=0 THEN -1 ELSE (position(caseaccent_normalize(cast(\"enrequisitionapproval27\".\"aprovalprocessid\" as text) collate \"default\") in caseaccent_normalize(@qpteo_ApprovalProcessIds collate \"default\"))-1) END)) <> (-1)) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteo_ApprovalProcessIds", DbType.String, qpteo_ApprovalProcessIds);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteo_ApprovalProcessIds", DbType.String, qpteo_ApprovalProcessIds);
if (qpreRequisition_RegionId1 != 0) {
whereBuilder.Append("((\"enrequisition107\".\"regionid\" = @qpreRequisition_RegionId1) AND (\"enrequisition107\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisition_RegionId1", DbType.Int64, qpreRequisition_RegionId1);
sqlCountCmd.CreateParameterWithoutReplacements("@qpreRequisition_RegionId1", DbType.Int64, qpreRequisition_RegionId1);
} else {
whereBuilder.Append("(\"enrequisition107\".\"regionid\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY ");
List<string> orderByColumns = new List<string>();
orderByColumns.AddRange(BaseAppUtils.ReplaceEntityReferencesAndAttributesInOrderBy(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, qptel_TableSort, new string[] { "Currency", "RequisitionStatus", "Requisition", "Project_Asset_Service", "RequisitionApproval", "CostCenterSAP", "Company", "Supplier" }, new string[] { "ENCurrency24", "ENRequisitionStatus1", "ENRequisition107", "ENProject_Asset_Service16", "ENRequisitionApproval27", "ENCostCenterSAP14", "ENCompany45", "ENSupplier108" }, new System.Collections.Generic.Dictionary<string, string>[] { ENCurrencyEntity.AttributesToDatabaseNamesMap(), ENRequisitionStatusEntity.AttributesToDatabaseNamesMap(), ENRequisitionEntity.AttributesToDatabaseNamesMap(), ENProject_Asset_ServiceEntity.AttributesToDatabaseNamesMap(), ENRequisitionApprovalEntity.AttributesToDatabaseNamesMap(), ENCostCenterSAPEntity.AttributesToDatabaseNamesMap(), ENCompanyEntity.AttributesToDatabaseNamesMap(), ENSupplierEntity.AttributesToDatabaseNamesMap() }).Split(','));
orderByColumns.Add("\"enrequisition107\".\"createdon\" DESC ");
orderByBuilder.Append(BaseAppUtils.GetOrderByColumnsWithoutDuplicates(orderByColumns));
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
RL_39c5627b3bb44cc40b890ccd9b2786b2 outParamList = new RL_39c5627b3bb44cc40b890ccd9b2786b2();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetRequisitionsForUploadReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[8];
opt[0] = new BitArray(new bool[] {false, true, true, true, true});
opt[1] = new BitArray(new bool[] {false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, false, true, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[6] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[7] = new BitArray(new bool[] {true, false, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query c_Requisitions.Wb_RequisitionUploadInv_Internal.GetRequisitionsForUpload.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.Wb_RequisitionUploadInv_Internal.GetRequisitionsForUpload.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_39c5627b3bb44cc40b890ccd9b2786b2 _tmp = new RL_39c5627b3bb44cc40b890ccd9b2786b2();
_tmp.AlternateReadDbMethodAsync = datasetGetRequisitionsForUploadReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.Wb_RequisitionUploadInv_Internal.GetRequisitionsForUpload.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_39c5627b3bb44cc40b890ccd9b2786b2)_tmp;
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query c_Requisitions.Wb_RequisitionUploadInv_Internal.GetRequisitionsForUpload.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
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

// Query Function "GetCompanies" pFbCqJRHekmtXomTpDKh9Q of Action "Wb_RequisitionUploadInv_Internal"
public static async Task<(RL_060f887b4f32b5cdb78b49175875565c,long)> datasetGetCompanies(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("c_Requisitions.Wb_RequisitionUploadInv_Internal.GetCompanies", "a8c256a4-4794-497a-ad5e-8993a432a1f5");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_RequisitionUploadInv_Internal","c_Requisitions.Wb_RequisitionUploadInv_Internal.GetCompanies");
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
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.5U95CtIKckSUy9+VjK8vfA/ScreenDataSets.pFbCqJRHekmtXomTpDKh9Q, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"encompany46\".\"id\" o0, NULL o1, \"encompany46\".\"description\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10");
fromBuilder.Append(" FROM {Company} \"encompany46\"");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.Wb_RequisitionUploadInv_Internal.GetCompanies.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.Wb_RequisitionUploadInv_Internal.GetCompanies.List", cancellationToken: cancellationToken);
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


    public class lcvGetApprovalProcessIds2 : VarsBag {
public RL_15d34ef3d5d1659033627e8c01970200 queryResGetApprovalProcessIds_outParamList = new RL_15d34ef3d5d1659033627e8c01970200();
public long queryResGetApprovalProcessIds_outParamCount = 0L;

public lcvGetApprovalProcessIds2() {
}
}
public class lcoGetApprovalProcessIds2 : VarsBag {
public string outParamo_ApprovalProcessIds = "";

public lcoGetApprovalProcessIds2() {
}
}
/// <summary>
/// Action <code>GetApprovalProcessIds2</code> that represents the Service Studio action
///  <code>GetApprovalProcessIds2</code> <p> Description: </p>
/// </summary>
public async Task<string> DataActionGetApprovalProcessIds2(IRequestContext requestContext,CancellationToken cancellationToken) {
string outParamo_ApprovalProcessIds = default;
lcoGetApprovalProcessIds2 result = new lcoGetApprovalProcessIds2();
lcvGetApprovalProcessIds2 localVars = new lcvGetApprovalProcessIds2();
ConectaProveedores_c_Requisitions_Wb_RequisitionUploadInv_Internal_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetApprovalProcessIds2", "b3a4f2bb-db93-40db-a70e-bd442f0805a7"))
using (activitySource.CreateScreenDataActionActivity("Wb_RequisitionUploadInv_Internal", "GetApprovalProcessIds2")){
// Query datasetGetApprovalProcessIds
cancellationToken.ThrowIfCancellationRequested();
int datasetGetApprovalProcessIds_maxRecords = 0;
int datasetGetApprovalProcessIds_startIndex = 0;(localVars.queryResGetApprovalProcessIds_outParamList,localVars.queryResGetApprovalProcessIds_outParamCount) = await FuncDataActionGetApprovalProcessIds2.datasetGetApprovalProcessIds(requestContext,datasetGetApprovalProcessIds_maxRecords,datasetGetApprovalProcessIds_startIndex,IterationMultiplicity.Single,(await Functions.ActionGetUserEntraRoleId(requestContext,BuiltInFunction.GetUserId (),cancellationToken)),cancellationToken);

// Foreach GetApprovalProcessIds.List
localVars.queryResGetApprovalProcessIds_outParamList.StartIteration();
try {while (!((localVars.queryResGetApprovalProcessIds_outParamList.Eof))) {
// o_ApprovalProcessIds = o_ApprovalProcessIds + "," + GetApprovalProcessIds.List.Current.ApprovalProcess.Id
result.outParamo_ApprovalProcessIds=((result.outParamo_ApprovalProcessIds+",")+BuiltInFunction.LongIntegerToText(localVars.queryResGetApprovalProcessIds_outParamList.CurrentRec.ssENApprovalProcess.ssId));
localVars.queryResGetApprovalProcessIds_outParamList.Advance();
}

} finally {
localVars.queryResGetApprovalProcessIds_outParamList.EndIteration();
}

} //close CreateActionActivity using block
} // try

finally {
outParamo_ApprovalProcessIds = result.outParamo_ApprovalProcessIds;
} // inner-finally
RETURN_STATEMENT:
return outParamo_ApprovalProcessIds;
}


    public static class FuncDataActionGetApprovalProcessIds2 {

private static async Task<RC_0a46451d8756128c280ededf206b35a5> datasetGetApprovalProcessIdsReadDbAsync(RC_0a46451d8756128c280ededf206b35a5 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApprovalProcess.Read( r, ref index);
rec.ssENSpecialWorkflows.Read( r, ref index);
rec.ssENSpecialWorkflowUploadPuestos.Read( r, ref index);
return rec;
}
// Query Function "GetApprovalProcessIds" Y+JzbiEEwEmGFhKT+Tlt1w of Action "GetApprovalProcessIds2"
public static async Task<(RL_15d34ef3d5d1659033627e8c01970200,long)> datasetGetApprovalProcessIds(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpenSpecialWorkflowUploadPuestos_EntraRoleId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("c_Requisitions.Wb_RequisitionUploadInv_Internal.GetApprovalProcessIds2.GetApprovalProcessIds", "6e73e263-0421-49c0-8616-1293f9396dd7");
using var queryActivity = activitySource.CreateAggregateQueryActivity("c_Requisitions.Wb_RequisitionUploadInv_Internal.GetApprovalProcessIds2.GetApprovalProcessIds", "6e73e263-0421-49c0-8616-1293f9396dd7", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.5U95CtIKckSUy9+VjK8vfA/DataActions.u_Kks5Pb20CnDr1ELwgFpw/NodesNotShownInESpaceTree.Y+JzbiEEwEmGFhKT+Tlt1w, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enapprovalprocess44\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28");
fromBuilder.Append(" FROM (({ApprovalProcess} \"enapprovalprocess44\" Left JOIN {SpecialWorkflows} \"enspecialworkflows2\" ON (\"enapprovalprocess44\".\"specialworkflowid\" = \"enspecialworkflows2\".\"id\"))  Left JOIN {SpecialWorkflowUploadPuestos} \"enspecialworkflowuploadpuestos2\" ON (\"enspecialworkflows2\".\"id\" = \"enspecialworkflowuploadpuestos2\".\"specialworkflowid\")) ");
whereBuilder.Append(" WHERE ");
if (qpenSpecialWorkflowUploadPuestos_EntraRoleId != 0) {
whereBuilder.Append("((\"enspecialworkflowuploadpuestos2\".\"entraroleid\" = @qpenSpecialWorkflowUploadPuestos_EntraRoleId) AND (\"enspecialworkflowuploadpuestos2\".\"entraroleid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpenSpecialWorkflowUploadPuestos_EntraRoleId", DbType.Int64, qpenSpecialWorkflowUploadPuestos_EntraRoleId);
} else {
whereBuilder.Append("(\"enspecialworkflowuploadpuestos2\".\"entraroleid\" IS NULL)");
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
RL_15d34ef3d5d1659033627e8c01970200 outParamList = new RL_15d34ef3d5d1659033627e8c01970200();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetApprovalProcessIdsReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.Wb_RequisitionUploadInv_Internal.GetApprovalProcessIds2.GetApprovalProcessIds.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_15d34ef3d5d1659033627e8c01970200 _tmp = new RL_15d34ef3d5d1659033627e8c01970200();
_tmp.AlternateReadDbMethodAsync = datasetGetApprovalProcessIdsReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.Wb_RequisitionUploadInv_Internal.GetApprovalProcessIds2.GetApprovalProcessIds.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_15d34ef3d5d1659033627e8c01970200)_tmp;
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
