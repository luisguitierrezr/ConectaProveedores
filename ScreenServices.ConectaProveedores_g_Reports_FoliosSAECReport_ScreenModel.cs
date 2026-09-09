using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_g_Reports_FoliosSAECReport_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_g_Reports_FoliosSAECReport_ScreenModel).Namespace);

    public int varLcStartIndex;
public string varLcTableSort;
public bool varLcIsToEmpty;
public bool varLcLoading;
public string varLcColumnJSONVar;
public int varLcCountAfterFetch;
public bool varLcReInvokeToggler;
public AggregateRecord<RL_ba9fc810801f4aabee0bc4ef3685a9dd> ScreenDataSetGetFolioStatuses;
public AggregateRecord<RL_9895159eebcdcdaed80fbd832f52d838> ScreenDataSetGetTelcelDirections;
public AggregateRecord<RL_ed90a45f2cc96d244d7fc28b114020f0> ScreenDataSetGetFolioSAECItems;
public AggregateRecord<RL_060f887b4f32b5cdb78b49175875565c> ScreenDataSetGetCompanies;
public AggregateRecord<RL_89fdc2de9b4f3c518b096795c532253b> ScreenDataSetGetApplicants;
public AggregateRecord<RL_5d3a02aa993c7474297e33d992f39ad0> ScreenDataSetGetRegions;
public ConectaProveedores_g_Reports_FoliosSAECReport_DataActionGetUserApplicationRoles_Model varLcGetUserApplicationRoles;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_g_Reports_FoliosSAECReport_ScreenModel() {
}



    public ConectaProveedores_g_Reports_FoliosSAECReport_ScreenModel(int varLcStartIndex, string varLcTableSort, bool varLcIsToEmpty, bool varLcLoading, string varLcColumnJSONVar, int varLcCountAfterFetch, bool varLcReInvokeToggler, AggregateRecord<RL_ba9fc810801f4aabee0bc4ef3685a9dd> ScreenDataSetGetFolioStatuses, AggregateRecord<RL_9895159eebcdcdaed80fbd832f52d838> ScreenDataSetGetTelcelDirections, AggregateRecord<RL_ed90a45f2cc96d244d7fc28b114020f0> ScreenDataSetGetFolioSAECItems, AggregateRecord<RL_060f887b4f32b5cdb78b49175875565c> ScreenDataSetGetCompanies, AggregateRecord<RL_89fdc2de9b4f3c518b096795c532253b> ScreenDataSetGetApplicants, AggregateRecord<RL_5d3a02aa993c7474297e33d992f39ad0> ScreenDataSetGetRegions, ConectaProveedores_g_Reports_FoliosSAECReport_DataActionGetUserApplicationRoles_Model varLcGetUserApplicationRoles, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"StartIndex", "TableSort", "IsToEmpty", "Loading", "ColumnJSONVar", "CountAfterFetch", "ReInvokeToggler", "GetFolioStatuses", "GetTelcelDirections", "GetFolioSAECItems", "GetCompanies", "GetApplicants", "GetRegions", "GetUserApplicationRoles", "ClientVars"}, new string[] {"varLcStartIndex", "varLcTableSort", "varLcIsToEmpty", "varLcLoading", "varLcColumnJSONVar", "varLcCountAfterFetch", "varLcReInvokeToggler", "ScreenDataSetGetFolioStatuses", "ScreenDataSetGetTelcelDirections", "ScreenDataSetGetFolioSAECItems", "ScreenDataSetGetCompanies", "ScreenDataSetGetApplicants", "ScreenDataSetGetRegions", "varLcGetUserApplicationRoles", "clientVariables"});
this.varLcStartIndex = varLcStartIndex;
this.varLcTableSort = varLcTableSort;
this.varLcIsToEmpty = varLcIsToEmpty;
this.varLcLoading = varLcLoading;
this.varLcColumnJSONVar = varLcColumnJSONVar;
this.varLcCountAfterFetch = varLcCountAfterFetch;
this.varLcReInvokeToggler = varLcReInvokeToggler;
this.ScreenDataSetGetFolioStatuses = ScreenDataSetGetFolioStatuses;
this.ScreenDataSetGetTelcelDirections = ScreenDataSetGetTelcelDirections;
this.ScreenDataSetGetFolioSAECItems = ScreenDataSetGetFolioSAECItems;
this.ScreenDataSetGetCompanies = ScreenDataSetGetCompanies;
this.ScreenDataSetGetApplicants = ScreenDataSetGetApplicants;
this.ScreenDataSetGetRegions = ScreenDataSetGetRegions;
this.varLcGetUserApplicationRoles = varLcGetUserApplicationRoles;
this.clientVariables = clientVariables;
}



    
// Query Function "GetFolioStatuses" vktkG1+FpkC8MlKkH4b8tA of Action "FoliosSAECReport"
public static async Task<(RL_ba9fc810801f4aabee0bc4ef3685a9dd,long)> datasetGetFolioStatuses(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("g_Reports.FoliosSAECReport.GetFolioStatuses", "1b644bbe-855f-40a6-bc32-52a41f86fcb4");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("FoliosSAECReport","g_Reports.FoliosSAECReport.GetFolioStatuses");
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
selectBuilder.Append("/* /NRWebFlows.BM45GkAQfUyFUQyknhK0HA/NodesShownInESpaceTree.hdrki5YmhEqUDt+PxySskg/ScreenDataSets.vktkG1+FpkC8MlKkH4b8tA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enfoliostatus6\".\"id\" o0, \"enfoliostatus6\".\"label\" o1, NULL o2, NULL o3, NULL o4, NULL o5");
fromBuilder.Append(" FROM {FolioStatus} \"enfoliostatus6\"");
whereBuilder.Append(" WHERE ((((((((((\"enfoliostatus6\".\"id\" = ");
whereBuilder.Append((ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("sjaNMehoxESZWJutqvvRYA"))).ssId);
whereBuilder.Append(") OR (\"enfoliostatus6\".\"id\" = ");
whereBuilder.Append((ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("cklscJNc0UyOgKXGwg51TQ"))).ssId);
whereBuilder.Append(")) OR (\"enfoliostatus6\".\"id\" = ");
whereBuilder.Append((ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("WhiUWVQy5E68vtmKmJU0KA"))).ssId);
whereBuilder.Append(")) OR (\"enfoliostatus6\".\"id\" = ");
whereBuilder.Append((ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("cKaejollq0a9gDFyfLxCKg"))).ssId);
whereBuilder.Append(")) OR (\"enfoliostatus6\".\"id\" = ");
whereBuilder.Append((ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("QxrbM7PI8EeSs3w6T0KALg"))).ssId);
whereBuilder.Append(")) OR (\"enfoliostatus6\".\"id\" = ");
whereBuilder.Append((ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("gO793L3rZ06FTArG1lVjpg"))).ssId);
whereBuilder.Append(")) OR (\"enfoliostatus6\".\"id\" = ");
whereBuilder.Append((ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("OLAtbBHfEkWbS1oUJ_NMaQ"))).ssId);
whereBuilder.Append(")) OR (\"enfoliostatus6\".\"id\" = ");
whereBuilder.Append((ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("l5OG661dZEe+gAZwnNLhSA"))).ssId);
whereBuilder.Append(")) OR (\"enfoliostatus6\".\"id\" = ");
whereBuilder.Append((ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("Di5a7BHsfkq06ZPVPBbZxg"))).ssId);
whereBuilder.Append(")) OR (\"enfoliostatus6\".\"id\" = ");
whereBuilder.Append((ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("Sibqk6dY7UGlZ5CDRDlXsg"))).ssId);
whereBuilder.Append("))");
orderByBuilder.Append(" ORDER BY \"enfoliostatus6\".\"label\" ASC ");
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
RL_ba9fc810801f4aabee0bc4ef3685a9dd outParamList = new RL_ba9fc810801f4aabee0bc4ef3685a9dd();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query g_Reports.FoliosSAECReport.GetFolioStatuses.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_ba9fc810801f4aabee0bc4ef3685a9dd _tmp = new RL_ba9fc810801f4aabee0bc4ef3685a9dd();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query g_Reports.FoliosSAECReport.GetFolioStatuses.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_ba9fc810801f4aabee0bc4ef3685a9dd)_tmp;
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

// Query Function "GetTelcelDirections" Ouj4G6d3TUqWtp+KTGcDYQ of Action "FoliosSAECReport"
public static async Task<(RL_9895159eebcdcdaed80fbd832f52d838,long)> datasetGetTelcelDirections(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("g_Reports.FoliosSAECReport.GetTelcelDirections", "1bf8e83a-77a7-4a4d-96b6-9f8a4c670361");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("FoliosSAECReport","g_Reports.FoliosSAECReport.GetTelcelDirections");
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
selectBuilder.Append("/* /NRWebFlows.BM45GkAQfUyFUQyknhK0HA/NodesShownInESpaceTree.hdrki5YmhEqUDt+PxySskg/ScreenDataSets.Ouj4G6d3TUqWtp+KTGcDYQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6");
fromBuilder.Append(" FROM {TelcelDirection} \"entelceldirection11\"");
orderByBuilder.Append(" ORDER BY \"entelceldirection11\".\"name\" ASC ");
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
RL_9895159eebcdcdaed80fbd832f52d838 outParamList = new RL_9895159eebcdcdaed80fbd832f52d838();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query g_Reports.FoliosSAECReport.GetTelcelDirections.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_9895159eebcdcdaed80fbd832f52d838 _tmp = new RL_9895159eebcdcdaed80fbd832f52d838();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query g_Reports.FoliosSAECReport.GetTelcelDirections.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_9895159eebcdcdaed80fbd832f52d838)_tmp;
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

private static async Task<RC_89c1eb236aae2b02b66345e2ec5e59e9> datasetGetFolioSAECItemsReadDbAsync(RC_89c1eb236aae2b02b66345e2ec5e59e9 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApplicant.Read( r, ref index);
rec.ssENApprovalProcess.Read( r, ref index);
rec.ssENApprovalProcessType.Read( r, ref index);
rec.ssENCompany.Read( r, ref index);
rec.ssENFolio.Read( r, ref index);
rec.ssENFolioApproval.Read( r, ref index);
rec.ssENFolioItems.Read( r, ref index);
rec.ssENFolioSAPData.Read( r, ref index);
rec.ssENFolioStatus.Read( r, ref index);
rec.ssENInvoice.Read( r, ref index);
rec.ssENOrderDetail.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssENOrderMainItem.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
rec.ssENSupplierUser.Read( r, ref index);
return rec;
}
// Query Function "GetFolioSAECItems" irwLN7tLwE2AdBxDnSdCaQ of Action "FoliosSAECReport"
public static async Task<(RL_ed90a45f2cc96d244d7fc28b114020f0,long)> datasetGetFolioSAECItems(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,int qpinOffsetUtc,string qpteOrderMain_Applicant,long qpteOrderMain_TelcelDirectionId,DateTime qpdaReport60_EndDate,string qpteReport60_OrderNumber,long qpreRegion_Id,long qpcoFolio_CompanyId,DateTime qpdaReport60_StartDate,int qpfoFolio_FolioStatusId,long qpsuSupplier_Id,bool qpboIsAllRegions,long qpsuSupplierId,long qpreOrderMain_DivisionId,string qpusSupplierUser_UserId,bool qpboIsToEmpty,string qpteTableSort,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("g_Reports.FoliosSAECReport.GetFolioSAECItems", "370bbc8a-4bbb-4dc0-8074-1c439d274269");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("FoliosSAECReport","g_Reports.FoliosSAECReport.GetFolioSAECItems");
// Query Iterations: Multiple
// Refresh Query XNkvBcidkkyOx1madX9_Pw Iterations: Multiple
// Refresh Query qt0QvOqkg0KtzTOjKNAzmA Iterations: Multiple
// Refresh Query lbcd4OQMJkOE56yp38shSw Iterations: Multiple
// Refresh Query nXgVl1dOokWYI4stI8FcKg Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.BM45GkAQfUyFUQyknhK0HA/NodesShownInESpaceTree.hdrki5YmhEqUDt+PxySskg/ScreenDataSets.irwLN7tLwE2AdBxDnSdCaQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, \"enapprovalprocess42\".\"code\" o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, \"enapprovalprocesstype1\".\"label_es\" o29, NULL o30, NULL o31, NULL o32, NULL o33, \"encompany28\".\"description\" o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, \"enfolio70\".\"id\" o43, NULL o44, \"enfolio70\".\"folionumber\" o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, trim_scale(\"enfolio70\".\"totalamount\"::numeric) o51, NULL o52, NULL o53, \"enfolio70\".\"currencyid\" o54, NULL o55, NULL o56, NULL o57, NULL o58, \"enfolio70\".\"createdon\" o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, \"enfoliosapdata13\".\"po_documento_material_em\" o94, NULL o95, NULL o96, NULL o97, \"enfoliosapdata13\".\"po_ejercicio_em\" o98, NULL o99, NULL o100, NULL o101, NULL o102, NULL o103, NULL o104, NULL o105, NULL o106, \"enfoliostatus7\".\"label\" o107, \"enfoliostatus7\".\"class\" o108, NULL o109, NULL o110, NULL o111, NULL o112, \"eninvoice111\".\"name\" o113, NULL o114, NULL o115, NULL o116, NULL o117, NULL o118, NULL o119, NULL o120, NULL o121, NULL o122, NULL o123, NULL o124, NULL o125, NULL o126, NULL o127, NULL o128, NULL o129, \"eninvoice111\".\"id_poliza_sap\" o130, \"eninvoice111\".\"doc51\" o131, NULL o132, NULL o133, NULL o134, NULL o135, NULL o136, NULL o137, NULL o138, NULL o139, NULL o140, NULL o141, NULL o142, NULL o143, NULL o144, NULL o145, NULL o146, NULL o147, NULL o148, NULL o149, NULL o150, NULL o151, NULL o152, NULL o153, NULL o154, NULL o155, NULL o156, NULL o157, NULL o158, NULL o159, NULL o160, NULL o161, NULL o162, NULL o163, NULL o164, NULL o165, NULL o166, NULL o167, NULL o168, NULL o169, NULL o170, NULL o171, NULL o172, NULL o173, NULL o174, NULL o175, \"enordermain85\".\"ordernumber\" o176, NULL o177, NULL o178, NULL o179, NULL o180, NULL o181, NULL o182, NULL o183, NULL o184, NULL o185, NULL o186, NULL o187, NULL o188, NULL o189, NULL o190, NULL o191, NULL o192, NULL o193, NULL o194, NULL o195, NULL o196, NULL o197, NULL o198, NULL o199, NULL o200, NULL o201, NULL o202, NULL o203, NULL o204, NULL o205, NULL o206, NULL o207, NULL o208, \"enordermainitem17\".\"assigmnentcode\" o209, NULL o210, NULL o211, NULL o212, NULL o213, NULL o214, NULL o215, NULL o216, NULL o217, NULL o218, NULL o219, NULL o220, NULL o221, NULL o222, NULL o223, NULL o224, NULL o225, NULL o226, NULL o227, NULL o228, NULL o229, NULL o230, NULL o231, NULL o232, NULL o233, NULL o234, NULL o235, NULL o236, NULL o237, NULL o238, NULL o239, NULL o240, NULL o241, NULL o242, NULL o243, NULL o244, NULL o245, NULL o246, NULL o247, NULL o248, NULL o249, NULL o250, NULL o251, NULL o252, NULL o253, NULL o254, NULL o255, \"enregion101\".\"code\" o256, NULL o257, NULL o258, NULL o259, NULL o260, NULL o261, NULL o262, NULL o263, NULL o264, NULL o265, NULL o266, NULL o267, NULL o268, NULL o269, \"ensupplier77\".\"name\" o270, \"ensupplier77\".\"number\" o271, NULL o272, NULL o273, NULL o274, NULL o275, NULL o276, NULL o277, NULL o278, NULL o279, NULL o280, NULL o281, NULL o282, NULL o283, NULL o284, \"ensupplier77\".\"n_ident_fis_1\" o285, NULL o286, NULL o287, NULL o288, NULL o289, NULL o290, NULL o291, NULL o292, NULL o293, NULL o294, NULL o295, NULL o296, NULL o297, NULL o298, NULL o299, NULL o300, NULL o301, NULL o302, NULL o303, NULL o304, NULL o305, NULL o306, NULL o307, NULL o308, NULL o309, NULL o310");
fromBuilder.Append(" FROM ((((((((((((((({FolioItems} \"enfolioitems10\" Left JOIN {Folio} \"enfolio70\" ON (\"enfolioitems10\".\"folioid\" = \"enfolio70\".\"id\"))  Left JOIN {OrderMainItem} \"enordermainitem17\" ON (\"enfolioitems10\".\"ordermainitemid\" = \"enordermainitem17\".\"id\"))  Left JOIN {OrderMain} \"enordermain85\" ON (\"enfolio70\".\"orderid\" = \"enordermain85\".\"id\"))  Left JOIN {Supplier} \"ensupplier77\" ON (\"enfolio70\".\"supplierid\" = \"ensupplier77\".\"id\"))  Left JOIN {Company} \"encompany28\" ON (\"enfolio70\".\"companyid\" = \"encompany28\".\"id\"))  Left JOIN {FolioStatus} \"enfoliostatus7\" ON (\"enfolio70\".\"foliostatusid\" = \"enfoliostatus7\".\"id\"))  Left JOIN {Invoice} \"eninvoice111\" ON (\"enfolio70\".\"id\" = \"eninvoice111\".\"folioid\"))  Left JOIN {FolioApproval} \"enfolioapproval37\" ON (\"enfolio70\".\"id\" = \"enfolioapproval37\".\"folioid\"))  Left JOIN {Region} \"enregion101\" ON (\"enordermain85\".\"divisionid\" = \"enregion101\".\"id\"))  Left JOIN {OrderDetail} \"enorderdetail11\" ON (\"enordermain85\".\"id\" = \"enorderdetail11\".\"orderid\"))  Left JOIN {Applicant} \"enapplicant2\" ON (\"enordermain85\".\"applicant\" = \"enapplicant2\".\"applicant\"))  Left JOIN {SupplierUser} \"ensupplieruser18\" ON ((\"ensupplier77\".\"id\" = \"ensupplieruser18\".\"supplierid\") AND (@qpsuSupplierId <> 0)))  Left JOIN {ApprovalProcess} \"enapprovalprocess42\" ON (\"enfolioapproval37\".\"approvalprocessid\" = \"enapprovalprocess42\".\"id\"))  Left JOIN {ApprovalProcessType} \"enapprovalprocesstype1\" ON (\"enfolio70\".\"approvalprocesstypeid\" = \"enapprovalprocesstype1\".\"id\"))  Left JOIN {FolioSAPData} \"enfoliosapdata13\" ON (\"enfolio70\".\"id\" = \"enfoliosapdata13\".\"folioid\")) ");
whereBuilder.Append(" WHERE (NOT (@qpboIsToEmpty = 1)) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpsuSupplierId", DbType.Int64, qpsuSupplierId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpsuSupplierId", DbType.Int64, qpsuSupplierId);
sqlCmd.CreateParameterWithoutReplacements("@qpboIsToEmpty", DbType.Boolean, qpboIsToEmpty);
sqlCountCmd.CreateParameterWithoutReplacements("@qpboIsToEmpty", DbType.Boolean, qpboIsToEmpty);
if (qpsuSupplierId != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if ((qpusSupplierUser_UserId.Trim()!="")) {
whereBuilder.Append("((\"ensupplieruser18\".\"userid\" = @qpusSupplierUser_UserId) AND (\"ensupplieruser18\".\"userid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusSupplierUser_UserId", DbType.String, qpusSupplierUser_UserId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpusSupplierUser_UserId", DbType.String, qpusSupplierUser_UserId);
} else {
whereBuilder.Append("(\"ensupplieruser18\".\"userid\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
whereBuilder.Append("(");
if (qpreOrderMain_DivisionId != 0) {
whereBuilder.Append("((\"enordermain85\".\"divisionid\" = @qpreOrderMain_DivisionId) AND (\"enordermain85\".\"divisionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreOrderMain_DivisionId", DbType.Int64, qpreOrderMain_DivisionId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpreOrderMain_DivisionId", DbType.Int64, qpreOrderMain_DivisionId);
} else {
whereBuilder.Append("(\"enordermain85\".\"divisionid\" IS NULL)");
}
whereBuilder.Append(" OR (@qpboIsAllRegions = 1)) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboIsAllRegions", DbType.Boolean, qpboIsAllRegions);
sqlCountCmd.CreateParameterWithoutReplacements("@qpboIsAllRegions", DbType.Boolean, qpboIsAllRegions);
if (qpteReport60_OrderNumber != "" && qpteReport60_OrderNumber != "") {
whereBuilder.Append("(caseaccent_normalize(\"enordermain85\".\"ordernumber\" collate \"default\") like caseaccent_normalize((('%' || @qpteReport60_OrderNumber) || '%') collate \"default\")) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteReport60_OrderNumber", DbType.String, qpteReport60_OrderNumber);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteReport60_OrderNumber", DbType.String, qpteReport60_OrderNumber);
}
if (qpsuSupplier_Id != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpsuSupplier_Id != 0) {
whereBuilder.Append("((\"ensupplier77\".\"id\" = @qpsuSupplier_Id) AND (\"ensupplier77\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuSupplier_Id", DbType.Int64, qpsuSupplier_Id);
sqlCountCmd.CreateParameterWithoutReplacements("@qpsuSupplier_Id", DbType.Int64, qpsuSupplier_Id);
} else {
whereBuilder.Append("(\"ensupplier77\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpreRegion_Id != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpreRegion_Id != 0) {
whereBuilder.Append("((\"enregion101\".\"id\" = @qpreRegion_Id) AND (\"enregion101\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRegion_Id", DbType.Int64, qpreRegion_Id);
sqlCountCmd.CreateParameterWithoutReplacements("@qpreRegion_Id", DbType.Int64, qpreRegion_Id);
} else {
whereBuilder.Append("(\"enregion101\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpfoFolio_FolioStatusId != BuiltInFunction.NullIdentifier()) {
if (qpfoFolio_FolioStatusId != 0) {
whereBuilder.Append("((\"enfolio70\".\"foliostatusid\" = @qpfoFolio_FolioStatusId) AND (\"enfolio70\".\"foliostatusid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolio_FolioStatusId", DbType.Int32, qpfoFolio_FolioStatusId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpfoFolio_FolioStatusId", DbType.Int32, qpfoFolio_FolioStatusId);
} else {
whereBuilder.Append("(\"enfolio70\".\"foliostatusid\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpcoFolio_CompanyId != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpcoFolio_CompanyId != 0) {
whereBuilder.Append("((\"enfolio70\".\"companyid\" = @qpcoFolio_CompanyId) AND (\"enfolio70\".\"companyid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpcoFolio_CompanyId", DbType.Int64, qpcoFolio_CompanyId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpcoFolio_CompanyId", DbType.Int64, qpcoFolio_CompanyId);
} else {
whereBuilder.Append("(\"enfolio70\".\"companyid\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpteOrderMain_Applicant != BuiltInFunction.NullTextIdentifier()) {
whereBuilder.Append("(\"enordermain85\".\"applicant\" = @qpteOrderMain_Applicant) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteOrderMain_Applicant", DbType.String, qpteOrderMain_Applicant);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteOrderMain_Applicant", DbType.String, qpteOrderMain_Applicant);
}
if (qpteOrderMain_TelcelDirectionId != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpteOrderMain_TelcelDirectionId != 0) {
whereBuilder.Append("((\"enordermain85\".\"telceldirectionid\" = @qpteOrderMain_TelcelDirectionId) AND (\"enordermain85\".\"telceldirectionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpteOrderMain_TelcelDirectionId", DbType.Int64, qpteOrderMain_TelcelDirectionId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteOrderMain_TelcelDirectionId", DbType.Int64, qpteOrderMain_TelcelDirectionId);
} else {
whereBuilder.Append("(\"enordermain85\".\"telceldirectionid\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpdaReport60_StartDate != BuiltInFunction.NullDate()) {
whereBuilder.Append("((cast(((\"enfolio70\".\"createdon\"::timestamptz + ((cast((@qpinOffsetUtc * (-1)) as integer)) * interval '1 hour'))) as date)::timestamptz) >= @qpdaReport60_StartDate) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpinOffsetUtc", DbType.Int32, qpinOffsetUtc);
sqlCountCmd.CreateParameterWithoutReplacements("@qpinOffsetUtc", DbType.Int32, qpinOffsetUtc);
sqlCmd.CreateParameterWithoutReplacements("@qpdaReport60_StartDate", DbType.DateTime, qpdaReport60_StartDate);
sqlCountCmd.CreateParameterWithoutReplacements("@qpdaReport60_StartDate", DbType.DateTime, qpdaReport60_StartDate);
}
if (qpdaReport60_EndDate != BuiltInFunction.NullDate()) {
whereBuilder.Append("((cast(((\"enfolio70\".\"createdon\"::timestamptz + ((cast((@qpinOffsetUtc * (-1)) as integer)) * interval '1 hour'))) as date)::timestamptz) <= @qpdaReport60_EndDate)");
sqlCmd.CreateParameterWithoutReplacements("@qpinOffsetUtc", DbType.Int32, qpinOffsetUtc);
sqlCountCmd.CreateParameterWithoutReplacements("@qpinOffsetUtc", DbType.Int32, qpinOffsetUtc);
sqlCmd.CreateParameterWithoutReplacements("@qpdaReport60_EndDate", DbType.DateTime, qpdaReport60_EndDate);
sqlCountCmd.CreateParameterWithoutReplacements("@qpdaReport60_EndDate", DbType.DateTime, qpdaReport60_EndDate);
}
string whereBuilderString = whereBuilder.ToString();
if (whereBuilderString.EndsWith(" AND ")) {
whereBuilder.Remove(whereBuilderString.Length - 5, 5);
}
orderByBuilder.Append(" ORDER BY ");
List<string> orderByColumns = new List<string>();
orderByColumns.AddRange(BaseAppUtils.ReplaceEntityReferencesAndAttributesInOrderBy(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, qpteTableSort, new string[] { "FolioSAPData", "FolioItems", "FolioStatus", "Invoice", "FolioApproval", "OrderDetail", "Region", "Supplier", "SupplierUser", "OrderMain", "ApprovalProcess", "Company", "Folio", "Applicant", "OrderMainItem", "ApprovalProcessType" }, new string[] { "ENFolioSAPData13", "ENFolioItems10", "ENFolioStatus7", "ENInvoice111", "ENFolioApproval37", "ENOrderDetail11", "ENRegion101", "ENSupplier77", "ENSupplierUser18", "ENOrderMain85", "ENApprovalProcess42", "ENCompany28", "ENFolio70", "ENApplicant2", "ENOrderMainItem17", "ENApprovalProcessType1" }, new System.Collections.Generic.Dictionary<string, string>[] { ENFolioSAPDataEntity.AttributesToDatabaseNamesMap(), ENFolioItemsEntity.AttributesToDatabaseNamesMap(), ENFolioStatusEntity.AttributesToDatabaseNamesMap(), ENInvoiceEntity.AttributesToDatabaseNamesMap(), ENFolioApprovalEntity.AttributesToDatabaseNamesMap(), ENOrderDetailEntity.AttributesToDatabaseNamesMap(), ENRegionEntity.AttributesToDatabaseNamesMap(), ENSupplierEntity.AttributesToDatabaseNamesMap(), ENSupplierUserEntity.AttributesToDatabaseNamesMap(), ENOrderMainEntity.AttributesToDatabaseNamesMap(), ENApprovalProcessEntity.AttributesToDatabaseNamesMap(), ENCompanyEntity.AttributesToDatabaseNamesMap(), ENFolioEntity.AttributesToDatabaseNamesMap(), ENApplicantEntity.AttributesToDatabaseNamesMap(), ENOrderMainItemEntity.AttributesToDatabaseNamesMap(), ENApprovalProcessTypeEntity.AttributesToDatabaseNamesMap() }).Split(','));
orderByColumns.Add("\"enfolioitems10\".\"ordernumber\" ASC ");
orderByColumns.Add("\"enordermainitem17\".\"position\" ASC ");
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
RL_ed90a45f2cc96d244d7fc28b114020f0 outParamList = new RL_ed90a45f2cc96d244d7fc28b114020f0();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFolioSAECItemsReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[16];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, false, true, true, true, false, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, false, false, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, false, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[6] = new BitArray(new bool[] {false, true, false, true, true, true, true, true, false, true, true, false, true, true, true, true, false, true, true, true});
opt[7] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[8] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[9] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[10] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[11] = new BitArray(new bool[] {true, true, false, true, true, true, true, true, true, true, true});
opt[12] = new BitArray(new bool[] {true, true, true, true, true, true, true, true});
opt[13] = new BitArray(new bool[] {true, true, false, true, true});
opt[14] = new BitArray(new bool[] {true, true, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true});
opt[15] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query g_Reports.FoliosSAECReport.GetFolioSAECItems.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query g_Reports.FoliosSAECReport.GetFolioSAECItems.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_ed90a45f2cc96d244d7fc28b114020f0 _tmp = new RL_ed90a45f2cc96d244d7fc28b114020f0();
_tmp.AlternateReadDbMethodAsync = datasetGetFolioSAECItemsReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query g_Reports.FoliosSAECReport.GetFolioSAECItems.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_ed90a45f2cc96d244d7fc28b114020f0)_tmp;
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query g_Reports.FoliosSAECReport.GetFolioSAECItems.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
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

// Query Function "GetCompanies" 5am3N8v7jUCpk+7GUiEaPA of Action "FoliosSAECReport"
public static async Task<(RL_060f887b4f32b5cdb78b49175875565c,long)> datasetGetCompanies(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("g_Reports.FoliosSAECReport.GetCompanies", "37b7a9e5-fbcb-408d-a993-eec652211a3c");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("FoliosSAECReport","g_Reports.FoliosSAECReport.GetCompanies");
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
selectBuilder.Append("/* /NRWebFlows.BM45GkAQfUyFUQyknhK0HA/NodesShownInESpaceTree.hdrki5YmhEqUDt+PxySskg/ScreenDataSets.5am3N8v7jUCpk+7GUiEaPA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"encompany29\".\"id\" o0, \"encompany29\".\"externalid\" o1, \"encompany29\".\"description\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10");
fromBuilder.Append(" FROM {Company} \"encompany29\"");
orderByBuilder.Append(" ORDER BY \"encompany29\".\"description\" ASC ");
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
opt[0] = new BitArray(new bool[] {false, false, false, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query g_Reports.FoliosSAECReport.GetCompanies.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query g_Reports.FoliosSAECReport.GetCompanies.List", cancellationToken: cancellationToken);
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

// Query Function "GetApplicants" oOxDUiOprUO4RV7DsyMdSw of Action "FoliosSAECReport"
public static async Task<(RL_89fdc2de9b4f3c518b096795c532253b,long)> datasetGetApplicants(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("g_Reports.FoliosSAECReport.GetApplicants", "5243eca0-a923-43ad-b845-5ec3b3231d4b");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("FoliosSAECReport","g_Reports.FoliosSAECReport.GetApplicants");
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
selectBuilder.Append("/* /NRWebFlows.BM45GkAQfUyFUQyknhK0HA/NodesShownInESpaceTree.hdrki5YmhEqUDt+PxySskg/ScreenDataSets.oOxDUiOprUO4RV7DsyMdSw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enapplicant3\".\"applicant\" o1, \"enapplicant3\".\"description\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7");
fromBuilder.Append(" FROM {Applicant} \"enapplicant3\"");
orderByBuilder.Append(" ORDER BY \"enapplicant3\".\"description\" ASC ");
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
RL_89fdc2de9b4f3c518b096795c532253b outParamList = new RL_89fdc2de9b4f3c518b096795c532253b();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, false, false, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query g_Reports.FoliosSAECReport.GetApplicants.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_89fdc2de9b4f3c518b096795c532253b _tmp = new RL_89fdc2de9b4f3c518b096795c532253b();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query g_Reports.FoliosSAECReport.GetApplicants.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_89fdc2de9b4f3c518b096795c532253b)_tmp;
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

// Query Function "GetRegions" i_DOhm0EGUKjmNqvI+VZAg of Action "FoliosSAECReport"
public static async Task<(RL_5d3a02aa993c7474297e33d992f39ad0,long)> datasetGetRegions(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("g_Reports.FoliosSAECReport.GetRegions", "86cef08b-046d-4219-a398-daaf23e55902");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("FoliosSAECReport","g_Reports.FoliosSAECReport.GetRegions");
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
selectBuilder.Append("/* /NRWebFlows.BM45GkAQfUyFUQyknhK0HA/NodesShownInESpaceTree.hdrki5YmhEqUDt+PxySskg/ScreenDataSets.i_DOhm0EGUKjmNqvI+VZAg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enregion102\".\"id\" o0, \"enregion102\".\"code\" o1, \"enregion102\".\"name\" o2, \"enregion102\".\"divisionfi\" o3, \"enregion102\".\"centrortp\" o4, \"enregion102\".\"commissionregion\" o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12");
fromBuilder.Append(" FROM {Region} \"enregion102\"");
whereBuilder.Append(" WHERE (\"enregion102\".\"isactive\" = 1)");
orderByBuilder.Append(" ORDER BY \"enregion102\".\"code\" ASC ");
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
RL_5d3a02aa993c7474297e33d992f39ad0 outParamList = new RL_5d3a02aa993c7474297e33d992f39ad0();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query g_Reports.FoliosSAECReport.GetRegions.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_5d3a02aa993c7474297e33d992f39ad0 _tmp = new RL_5d3a02aa993c7474297e33d992f39ad0();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query g_Reports.FoliosSAECReport.GetRegions.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_5d3a02aa993c7474297e33d992f39ad0)_tmp;
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


    public class lcvGetUserApplicationRoles : VarsBag {
public Actions.lcoGetUserRegionId resGetUserRegionId =  new Actions.lcoGetUserRegionId();
public RL_84bdfe424d1eb0223fc2b8cfa9bb96be queryResGetSupplierUsersByUserId_outParamList = new RL_84bdfe424d1eb0223fc2b8cfa9bb96be();
public long queryResGetSupplierUsersByUserId_outParamCount = 0L;

public RL_5d3a02aa993c7474297e33d992f39ad0 queryResGetRegionCorp_outParamList = new RL_5d3a02aa993c7474297e33d992f39ad0();
public long queryResGetRegionCorp_outParamCount = 0L;

public lcvGetUserApplicationRoles() {
}
}
public class lcoGetUserApplicationRoles : VarsBag {
public long outParamUserRegion = 0L;

public long outParamSupplierId = 0L;

public bool outParamIsAllRegions = false;

public lcoGetUserApplicationRoles() {
}
}
/// <summary>
/// Action <code>GetUserApplicationRoles</code> that represents the Service Studio action
///  <code>GetUserApplicationRoles</code> <p> Description: </p>
/// </summary>
public async Task<(long,long,bool)> DataActionGetUserApplicationRoles(IRequestContext requestContext,CancellationToken cancellationToken) {
long outParamUserRegion = default;
long outParamSupplierId = default;
bool outParamIsAllRegions = default;
lcoGetUserApplicationRoles result = new lcoGetUserApplicationRoles();
lcvGetUserApplicationRoles localVars = new lcvGetUserApplicationRoles();
ConectaProveedores_g_Reports_FoliosSAECReport_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetUserApplicationRoles", "b30ae060-f738-4111-8253-bb913ae5e29e"))
using (activitySource.CreateScreenDataActionActivity("FoliosSAECReport", "GetUserApplicationRoles")){
// GetUserRegionId
localVars.resGetUserRegionId.outParamo_RegionId = await Actions.ActionGetUserRegionId(requestContext,"",cancellationToken);

// Query datasetGetSupplierUsersByUserId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetSupplierUsersByUserId_maxRecords = 1;
if (datasetGetSupplierUsersByUserId_maxRecords < 1) datasetGetSupplierUsersByUserId_maxRecords = 1;
int datasetGetSupplierUsersByUserId_startIndex = 0;(localVars.queryResGetSupplierUsersByUserId_outParamList,localVars.queryResGetSupplierUsersByUserId_outParamCount) = await FuncDataActionGetUserApplicationRoles.datasetGetSupplierUsersByUserId(requestContext,datasetGetSupplierUsersByUserId_maxRecords,datasetGetSupplierUsersByUserId_startIndex,IterationMultiplicity.Never,BuiltInFunction.GetUserId (),cancellationToken);

// Query datasetGetRegionCorp
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRegionCorp_maxRecords = 1;
if (datasetGetRegionCorp_maxRecords < 1) datasetGetRegionCorp_maxRecords = 1;
int datasetGetRegionCorp_startIndex = 0;(localVars.queryResGetRegionCorp_outParamList,localVars.queryResGetRegionCorp_outParamCount) = await FuncDataActionGetUserApplicationRoles.datasetGetRegionCorp(requestContext,datasetGetRegionCorp_maxRecords,datasetGetRegionCorp_startIndex,IterationMultiplicity.Never,cancellationToken);

// UserRegion = GetUserRegionId.o_RegionId
result.outParamUserRegion=localVars.resGetUserRegionId.outParamo_RegionId;

// SupplierId = GetSupplierUsersByUserId.List.Current.SupplierUser.SupplierId
result.outParamSupplierId=localVars.queryResGetSupplierUsersByUserId_outParamList.CurrentRec.ssENSupplierUser.ssSupplierId;

// IsAllRegions = GetUserRegionId.o_RegionId = NullIdentifier or GetUserRegionId.o_RegionId = GetRegionCorp.List.Current.Region.Id
result.outParamIsAllRegions=((localVars.resGetUserRegionId.outParamo_RegionId==Convert.ToInt64(BuiltInFunction.NullIdentifier ()))||(localVars.resGetUserRegionId.outParamo_RegionId==localVars.queryResGetRegionCorp_outParamList.CurrentRec.ssENRegion.ssId));
} //close CreateActionActivity using block
} // try

finally {
outParamUserRegion = result.outParamUserRegion;
outParamSupplierId = result.outParamSupplierId;
outParamIsAllRegions = result.outParamIsAllRegions;
} // inner-finally
RETURN_STATEMENT:
return (outParamUserRegion,outParamSupplierId,outParamIsAllRegions);
}


    public static class FuncDataActionGetUserApplicationRoles {

// Query Function "GetSupplierUsersByUserId" PvHDUFSSBkKfygSLFhhJKQ of Action "GetUserApplicationRoles"
public static async Task<(RL_84bdfe424d1eb0223fc2b8cfa9bb96be,long)> datasetGetSupplierUsersByUserId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUserId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("g_Reports.FoliosSAECReport.GetUserApplicationRoles.GetSupplierUsersByUserId", "50c3f13e-9254-4206-9fca-048b16184929");
using var queryActivity = activitySource.CreateAggregateQueryActivity("g_Reports.FoliosSAECReport.GetUserApplicationRoles.GetSupplierUsersByUserId", "50c3f13e-9254-4206-9fca-048b16184929", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.BM45GkAQfUyFUQyknhK0HA/NodesShownInESpaceTree.hdrki5YmhEqUDt+PxySskg/DataActions.YOAKszj3EUGCU7uROuXing/NodesNotShownInESpaceTree.PvHDUFSSBkKfygSLFhhJKQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"ensupplieruser19\".\"supplierid\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14");
fromBuilder.Append(" FROM {SupplierUser} \"ensupplieruser19\"");
whereBuilder.Append(" WHERE ");
if ((qpusUserId.Trim()!="")) {
whereBuilder.Append("((\"ensupplieruser19\".\"userid\" = @qpusUserId) AND (\"ensupplieruser19\".\"userid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUserId", DbType.String, qpusUserId);
} else {
whereBuilder.Append("(\"ensupplieruser19\".\"userid\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"ensupplieruser19\".\"name\" ASC ");
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
RL_84bdfe424d1eb0223fc2b8cfa9bb96be outParamList = new RL_84bdfe424d1eb0223fc2b8cfa9bb96be();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query g_Reports.FoliosSAECReport.GetUserApplicationRoles.GetSupplierUsersByUserId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_84bdfe424d1eb0223fc2b8cfa9bb96be _tmp = new RL_84bdfe424d1eb0223fc2b8cfa9bb96be();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query g_Reports.FoliosSAECReport.GetUserApplicationRoles.GetSupplierUsersByUserId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_84bdfe424d1eb0223fc2b8cfa9bb96be)_tmp;
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

// Query Function "GetRegionCorp" O2B1wqUAcEi93W_OmD_PJg of Action "GetUserApplicationRoles"
public static async Task<(RL_5d3a02aa993c7474297e33d992f39ad0,long)> datasetGetRegionCorp(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("g_Reports.FoliosSAECReport.GetUserApplicationRoles.GetRegionCorp", "c275603b-00a5-4870-bddd-6fce983fcf26");
using var queryActivity = activitySource.CreateAggregateQueryActivity("g_Reports.FoliosSAECReport.GetUserApplicationRoles.GetRegionCorp", "c275603b-00a5-4870-bddd-6fce983fcf26", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.BM45GkAQfUyFUQyknhK0HA/NodesShownInESpaceTree.hdrki5YmhEqUDt+PxySskg/DataActions.YOAKszj3EUGCU7uROuXing/NodesNotShownInESpaceTree.O2B1wqUAcEi93W_OmD_PJg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enregion103\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12");
fromBuilder.Append(" FROM {Region} \"enregion103\"");
whereBuilder.Append(" WHERE (\"enregion103\".\"isactive\" = 1) AND (\"enregion103\".\"centrortp\" = 'MX00')");
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
RL_5d3a02aa993c7474297e33d992f39ad0 outParamList = new RL_5d3a02aa993c7474297e33d992f39ad0();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query g_Reports.FoliosSAECReport.GetUserApplicationRoles.GetRegionCorp.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_5d3a02aa993c7474297e33d992f39ad0 _tmp = new RL_5d3a02aa993c7474297e33d992f39ad0();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query g_Reports.FoliosSAECReport.GetUserApplicationRoles.GetRegionCorp.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_5d3a02aa993c7474297e33d992f39ad0)_tmp;
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
