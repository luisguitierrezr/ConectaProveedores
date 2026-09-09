using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_z_TableDownloadsPDF_TableDownloadRequisitionsListInternalScreenPDF_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_z_TableDownloadsPDF_TableDownloadRequisitionsListInternalScreenPDF_ScreenModel).Namespace);

    public string inParamStringListIds;
public string inParamStringListLevelIds;
public RLTextList varLcRequisitionIdList;
public RLTextList varLcRequisitionLevelIdList;
public ConectaProveedores_z_TableDownloadsPDF_TableDownloadRequisitionsListInternalScreenPDF_DataActionGetRequisitions_Model varLcGetRequisitions;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_z_TableDownloadsPDF_TableDownloadRequisitionsListInternalScreenPDF_ScreenModel() {
}



    public ConectaProveedores_z_TableDownloadsPDF_TableDownloadRequisitionsListInternalScreenPDF_ScreenModel(string inParamStringListIds, string inParamStringListLevelIds, RLTextList varLcRequisitionIdList, RLTextList varLcRequisitionLevelIdList, ConectaProveedores_z_TableDownloadsPDF_TableDownloadRequisitionsListInternalScreenPDF_DataActionGetRequisitions_Model varLcGetRequisitions, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"StringListIds", "StringListLevelIds", "RequisitionIdList", "RequisitionLevelIdList", "GetRequisitions", "ClientVars"}, new string[] {"inParamStringListIds", "inParamStringListLevelIds", "varLcRequisitionIdList", "varLcRequisitionLevelIdList", "varLcGetRequisitions", "clientVariables"});
this.inParamStringListIds = inParamStringListIds;
this.inParamStringListLevelIds = inParamStringListLevelIds;
this.varLcRequisitionIdList = varLcRequisitionIdList;
this.varLcRequisitionLevelIdList = varLcRequisitionLevelIdList;
this.varLcGetRequisitions = varLcGetRequisitions;
this.clientVariables = clientVariables;
}



    

    public class lcvGetRequisitions : VarsBag {
public string resString_Join_outParamText = "";

public RL_736d97877f60cf41325c2e16af4510d1 queryResGetRequisitionStructure_outParamList = new RL_736d97877f60cf41325c2e16af4510d1();
public long queryResGetRequisitionStructure_outParamCount = 0L;

public RL_6a483f7b9e172adc49ec70475a3b324d queryResGetLastApprover_outParamList = new RL_6a483f7b9e172adc49ec70475a3b324d();
public long queryResGetLastApprover_outParamCount = 0L;

public RL_f047dac638a0be52385038d9c0d00821 queryResGetInvoicesPolizaSAP_outParamList = new RL_f047dac638a0be52385038d9c0d00821();
public long queryResGetInvoicesPolizaSAP_outParamCount = 0L;

public lcvGetRequisitions() {
}
}
public class lcoGetRequisitions : VarsBag {
public RL_622bdef78070a83f1d39501965da2144 outParamList = new RL_622bdef78070a83f1d39501965da2144();

public lcoGetRequisitions() {
}
}
/// <summary>
/// Action <code>GetRequisitions</code> that represents the Service Studio action
///  <code>GetRequisitions</code> <p> Description: </p>
/// </summary>
public async Task<RL_622bdef78070a83f1d39501965da2144> DataActionGetRequisitions(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_622bdef78070a83f1d39501965da2144 outParamList = default;
lcoGetRequisitions result = new lcoGetRequisitions();
lcvGetRequisitions localVars = new lcvGetRequisitions();
ConectaProveedores_z_TableDownloadsPDF_TableDownloadRequisitionsListInternalScreenPDF_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetRequisitions", "7d8e39fd-d295-4d84-a846-7757f7ae9f19"))
using (activitySource.CreateScreenDataActionActivity("TableDownloadRequisitionsListInternalScreenPDF", "GetRequisitions")){
// Foreach RequisitionIdList
varLcRequisitionIdList.StartIteration();
try {while (!((varLcRequisitionIdList.Eof))) {
// Query datasetGetRequisitionStructure
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionStructure_maxRecords = 0;
int datasetGetRequisitionStructure_startIndex = 0;(localVars.queryResGetRequisitionStructure_outParamList,localVars.queryResGetRequisitionStructure_outParamCount) = await FuncDataActionGetRequisitions.datasetGetRequisitionStructure(requestContext,datasetGetRequisitionStructure_maxRecords,datasetGetRequisitionStructure_startIndex,IterationMultiplicity.Never,varLcRequisitionIdList.CurrentRec.ssValue,varLcRequisitionLevelIdList[varLcRequisitionIdList.CurrentRowNumber].ssValue,cancellationToken);

// Query datasetGetLastApprover
cancellationToken.ThrowIfCancellationRequested();
int datasetGetLastApprover_maxRecords = 1;
if (datasetGetLastApprover_maxRecords < 1) datasetGetLastApprover_maxRecords = 1;
int datasetGetLastApprover_startIndex = 0;(localVars.queryResGetLastApprover_outParamList,localVars.queryResGetLastApprover_outParamCount) = await FuncDataActionGetRequisitions.datasetGetLastApprover(requestContext,datasetGetLastApprover_maxRecords,datasetGetLastApprover_startIndex,IterationMultiplicity.Never,varLcRequisitionIdList.CurrentRec.ssValue,cancellationToken);

// Query datasetGetInvoicesPolizaSAP
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoicesPolizaSAP_maxRecords = 0;
int datasetGetInvoicesPolizaSAP_startIndex = 0;(localVars.queryResGetInvoicesPolizaSAP_outParamList,localVars.queryResGetInvoicesPolizaSAP_outParamCount) = await FuncDataActionGetRequisitions.datasetGetInvoicesPolizaSAP(requestContext,datasetGetInvoicesPolizaSAP_maxRecords,datasetGetInvoicesPolizaSAP_startIndex,IterationMultiplicity.Single,varLcRequisitionIdList.CurrentRec.ssValue,cancellationToken);

// String_Join
localVars.resString_Join_outParamText = await Actions.ActionString_Join(requestContext,(await RLTextRecordList.ConvertAsync(localVars.queryResGetInvoicesPolizaSAP_outParamList, new RLTextRecordList(), async (RC_dc377962308205a06a34e4c0881035f7 source, RCTextRecord target, CancellationToken cancellationToken) => {
target.ssSTText2.ssValue = (((source.ssENInvoicePoliza.ssPolizaSAP+"(")+BuiltInFunction.FormatDateTime (source.ssENInvoicePoliza.ssSentWhen, "dd/MM/yyyy"))+")");
return target;
}, cancellationToken)),", ",cancellationToken);

// ListAppend2
await ExtendedActions.ListAppend(requestContext,result.outParamList,new ST_291bf3fef8932fa1af5104e6982c4da9Structure(){ ssRequisitionId = localVars.queryResGetRequisitionStructure_outParamList.CurrentRec.ssENRequisition.ssId, ssRequisitionApprovalLevelId = localVars.queryResGetRequisitionStructure_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssId, ssRequisitionName = localVars.queryResGetRequisitionStructure_outParamList.CurrentRec.ssENRequisition.ssName, ssRequisitionStatus = localVars.queryResGetRequisitionStructure_outParamList.CurrentRec.ssENRequisitionStatus.ssLabelES, ssCreationDate = BuiltInFunction.FormatDateTime (localVars.queryResGetRequisitionStructure_outParamList.CurrentRec.ssENRequisition.ssCreatedOn, "dd/MM/yyyy"), ssLastChange = ((BuiltInFunction.FormatDateTime (localVars.queryResGetRequisitionStructure_outParamList.CurrentRec.ssENRequisition.ssUpdatedOn, "dd/MM/yyyy")+" ")+localVars.queryResGetRequisitionStructure_outParamList.CurrentRec.ssENUser_UpdateBy.ssName), ssRequester = localVars.queryResGetRequisitionStructure_outParamList.CurrentRec.ssENUser.ssName, ssProject = localVars.queryResGetRequisitionStructure_outParamList.CurrentRec.ssENProject_Asset_Service.ssDescription, ssSupplier = ((localVars.queryResGetRequisitionStructure_outParamList.CurrentRec.ssENSupplier.ssName+" ")+localVars.queryResGetRequisitionStructure_outParamList.CurrentRec.ssENSupplier.ssNumber), ssRegion = localVars.queryResGetRequisitionStructure_outParamList.CurrentRec.ssENRegion.ssCode, ssAmount = BuiltInFunction.FormatCurrency (localVars.queryResGetRequisitionStructure_outParamList.CurrentRec.ssENRequisition.ssTotalAmount, "", 2, ".", ","), ssCurrency = localVars.queryResGetRequisitionStructure_outParamList.CurrentRec.ssENCurrency.ssCode, ssCostCenter = localVars.queryResGetRequisitionStructure_outParamList.CurrentRec.ssENCostCenterSAP.ssDenominacion, ssCompany = localVars.queryResGetRequisitionStructure_outParamList.CurrentRec.ssENCompany.ssDescription, ssLastApprover = localVars.queryResGetLastApprover_outParamList.CurrentRec.ssENLastApprover.ssName, ssLastApproverApprovedOn = (((localVars.queryResGetLastApprover_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssApprovedOn!=BuiltInFunction.NullDate ())) ? (BuiltInFunction.FormatDateTime (localVars.queryResGetLastApprover_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssApprovedOn, "dd/MM/yyyy")) : (" ")), ssPolizaSAP_SentWhen = localVars.resString_Join_outParamText, ssAction = (((((localVars.queryResGetRequisitionStructure_outParamList.CurrentRec.ssENRequisitionStatus.ssId==(ENRequisitionStatusEntity.GetRecordByKey(ObjectKey.Parse("pBDtHOXH_kG10TWqeiPa0A"))).ssId)||(localVars.queryResGetRequisitionStructure_outParamList.CurrentRec.ssENRequisitionStatus.ssId==(ENRequisitionStatusEntity.GetRecordByKey(ObjectKey.Parse("wpdx_Qw3wEmfndGLo0VZ+Q"))).ssId))||((localVars.queryResGetRequisitionStructure_outParamList.CurrentRec.ssENRequisitionStatus.ssId==(ENRequisitionStatusEntity.GetRecordByKey(ObjectKey.Parse("1_RsQxcxokySProxyWT5mw"))).ssId)&&(localVars.queryResGetRequisitionStructure_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssApprovalStatusId==BuiltInFunction.NullIdentifier ())))) ? ("") : ((((((localVars.queryResGetRequisitionStructure_outParamList.CurrentRec.ssENRequisition.ssApplicantId==BuiltInFunction.GetUserId ())&&(localVars.queryResGetRequisitionStructure_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssAssignedTo!=BuiltInFunction.GetUserId ()))&&(!(localVars.queryResGetRequisitionStructure_outParamList.CurrentRec.ssENApprovalStatus.ssId==(ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId)))) ? (AppUtils.GetStringResource("Cv3lNi9klkGMVb29sWQehA#Value.-1942320933.1", "Submitted")) : ((((localVars.queryResGetRequisitionStructure_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssApprovalStatusId!=BuiltInFunction.NullIdentifier ())) ? (((localVars.queryResGetRequisitionStructure_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssIsAccounting) ? ((localVars.queryResGetRequisitionStructure_outParamList.CurrentRec.ssENApprovalStatus.ssLabelES+" CxP")) : ((localVars.queryResGetRequisitionStructure_outParamList.CurrentRec.ssENApprovalStatus.ssLabelES+" AU")))) : ("")))))) },cancellationToken);

varLcRequisitionIdList.Advance();
}

} finally {
varLcRequisitionIdList.EndIteration();
}

} //close CreateActionActivity using block
} // try

finally {
outParamList = result.outParamList;
} // inner-finally
RETURN_STATEMENT:
return outParamList;
}


    public static class FuncDataActionGetRequisitions {

private static async Task<RC_4cb48735c6c0de4a1d3871eb33750007> datasetGetRequisitionStructureReadDbAsync(RC_4cb48735c6c0de4a1d3871eb33750007 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApprovalStatus.Read( r, ref index);
rec.ssENCompany.Read( r, ref index);
rec.ssENCostCenterSAP.Read( r, ref index);
rec.ssENCurrency.Read( r, ref index);
rec.ssENProject_Asset_Service.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
rec.ssENRequisitionApproval.Read( r, ref index);
rec.ssENRequisitionApprovalLevel.Read( r, ref index);
rec.ssENRequisitionStatus.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_UpdateBy.Read( r, ref index);
return rec;
}
// Query Function "GetRequisitionStructure" U5OcLrXtq0WEVPmAjEXAvQ of Action "GetRequisitions"
public static async Task<(RL_736d97877f60cf41325c2e16af4510d1,long)> datasetGetRequisitionStructure(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteRequisition_Id,string qpteRequisitionApprovalLevel_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("z_TableDownloadsPDF.TableDownloadRequisitionsListInternalScreenPDF.GetRequisitions.GetRequisitionStructure", "2e9c9353-edb5-45ab-8454-f9808c45c0bd");
using var queryActivity = activitySource.CreateAggregateQueryActivity("z_TableDownloadsPDF.TableDownloadRequisitionsListInternalScreenPDF.GetRequisitions.GetRequisitionStructure", "2e9c9353-edb5-45ab-8454-f9808c45c0bd", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.kLQieB5cx02V9++AAXSp8g/NodesShownInESpaceTree.Lcj_8KUbPkKCIu632q+zFg/DataActions._TmOfZXShE2oRndX966fGQ/NodesNotShownInESpaceTree.U5OcLrXtq0WEVPmAjEXAvQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enapprovalstatus24\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, \"enapprovalstatus24\".\"labeles\" o9, NULL o10, NULL o11, \"encompany57\".\"description\" o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, \"encostcentersap21\".\"denominacion\" o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, \"encurrency28\".\"code\" o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, \"enproject_asset_service25\".\"description\" o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, \"enregion153\".\"code\" o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, \"enrequisition119\".\"id\" o71, \"enrequisition119\".\"name\" o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, \"enrequisition119\".\"applicantid\" o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, trim_scale(\"enrequisition119\".\"totalamount\"::numeric) o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, NULL o103, NULL o104, NULL o105, NULL o106, NULL o107, \"enrequisition119\".\"createdon\" o108, \"enrequisition119\".\"updatedon\" o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, NULL o118, NULL o119, NULL o120, NULL o121, NULL o122, NULL o123, NULL o124, NULL o125, NULL o126, NULL o127, NULL o128, NULL o129, NULL o130, NULL o131, NULL o132, NULL o133, NULL o134, NULL o135, NULL o136, NULL o137, NULL o138, \"enrequisitionapprovallevel27\".\"id\" o139, NULL o140, NULL o141, NULL o142, NULL o143, NULL o144, NULL o145, NULL o146, NULL o147, NULL o148, \"enrequisitionapprovallevel27\".\"assignedto\" o149, NULL o150, \"enrequisitionapprovallevel27\".\"approvalstatusid\" o151, NULL o152, NULL o153, NULL o154, NULL o155, NULL o156, NULL o157, \"enrequisitionapprovallevel27\".\"isaccounting\" o158, NULL o159, NULL o160, NULL o161, NULL o162, NULL o163, NULL o164, \"enrequisitionstatus6\".\"id\" o165, NULL o166, NULL o167, NULL o168, NULL o169, \"enrequisitionstatus6\".\"labeles\" o170, NULL o171, NULL o172, \"ensupplier117\".\"name\" o173, \"ensupplier117\".\"number\" o174, NULL o175, NULL o176, NULL o177, NULL o178, NULL o179, NULL o180, NULL o181, NULL o182, NULL o183, NULL o184, NULL o185, NULL o186, NULL o187, NULL o188, NULL o189, NULL o190, NULL o191, NULL o192, NULL o193, NULL o194, NULL o195, NULL o196, NULL o197, NULL o198, NULL o199, \"enuser194\".\"name\" o200, NULL o201, NULL o202, NULL o203, NULL o204, \"enuser_updateby\".\"name\" o205, NULL o206, NULL o207, NULL o208");
fromBuilder.Append(" FROM (((((((((((({Requisition} \"enrequisition119\" Left JOIN {RequisitionApproval} \"enrequisitionapproval32\" ON (\"enrequisition119\".\"id\" = \"enrequisitionapproval32\".\"requisitionid\"))  Left JOIN {RequisitionApprovalLevel} \"enrequisitionapprovallevel27\" ON ((\"enrequisitionapprovallevel27\".\"requisitionapprovalid\" = \"enrequisitionapproval32\".\"id\") AND (\"enrequisitionapprovallevel27\".\"id\" = cast(((coalesce(cast(nullif(@qpteRequisitionApprovalLevel_Id,'') as integer), 0))) as bigint))))  Left JOIN {RequisitionStatus} \"enrequisitionstatus6\" ON (\"enrequisition119\".\"requisitionstatusid\" = \"enrequisitionstatus6\".\"id\"))  Left JOIN {User} \"enuser_updateby\" ON (\"enrequisition119\".\"updatedby\" = \"enuser_updateby\".\"id\"))  Left JOIN {User} \"enuser194\" ON (\"enrequisition119\".\"applicantid\" = \"enuser194\".\"id\"))  Left JOIN {Supplier} \"ensupplier117\" ON (\"enrequisition119\".\"supplierid\" = \"ensupplier117\".\"id\"))  Left JOIN {Project_Asset_Service} \"enproject_asset_service25\" ON (\"enrequisition119\".\"projectassetserviceid\" = \"enproject_asset_service25\".\"id\"))  Left JOIN {Region} \"enregion153\" ON (\"enrequisition119\".\"regionid\" = \"enregion153\".\"id\"))  Left JOIN {Currency} \"encurrency28\" ON (\"enrequisition119\".\"currencyid\" = \"encurrency28\".\"code\"))  Left JOIN {Company} \"encompany57\" ON (\"enrequisition119\".\"companyid\" = \"encompany57\".\"id\"))  Left JOIN {CostCenterSAP} \"encostcentersap21\" ON (\"enrequisition119\".\"costcenterid\" = \"encostcentersap21\".\"id\"))  Left JOIN {ApprovalStatus} \"enapprovalstatus24\" ON (\"enrequisitionapprovallevel27\".\"approvalstatusid\" = \"enapprovalstatus24\".\"id\")) ");
whereBuilder.Append(" WHERE (\"enrequisition119\".\"id\" = cast(((coalesce(cast(nullif(@qpteRequisition_Id,'') as integer), 0))) as bigint))");
sqlCmd.CreateParameterWithoutReplacements("@qpteRequisitionApprovalLevel_Id", DbType.String, qpteRequisitionApprovalLevel_Id);
sqlCmd.CreateParameterWithoutReplacements("@qpteRequisition_Id", DbType.String, qpteRequisition_Id);
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
RL_736d97877f60cf41325c2e16af4510d1 outParamList = new RL_736d97877f60cf41325c2e16af4510d1();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetRequisitionStructureReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[13];
opt[0] = new BitArray(new bool[] {false, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true});
opt[2] = new BitArray(new bool[] {true, false, true, true, true});
opt[3] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, false});
opt[4] = new BitArray(new bool[] {false, false, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, false, true, false, true, true, true, true, true, true, false, true, true, true, true, true, true});
opt[6] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
opt[7] = new BitArray(new bool[] {false, true, true, true, true, false});
opt[8] = new BitArray(new bool[] {true, true, false, true, true, true, true, true, true, true, true});
opt[9] = new BitArray(new bool[] {true, true, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[10] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[11] = new BitArray(new bool[] {true, false, true, true, true, true, true});
opt[12] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query z_TableDownloadsPDF.TableDownloadRequisitionsListInternalScreenPDF.GetRequisitions.GetRequisitionStructure.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_736d97877f60cf41325c2e16af4510d1 _tmp = new RL_736d97877f60cf41325c2e16af4510d1();
_tmp.AlternateReadDbMethodAsync = datasetGetRequisitionStructureReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query z_TableDownloadsPDF.TableDownloadRequisitionsListInternalScreenPDF.GetRequisitions.GetRequisitionStructure.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_736d97877f60cf41325c2e16af4510d1)_tmp;
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

private static async Task<RC_853b3dd6b575c6d19eb5343d397a37e7> datasetGetLastApproverReadDbAsync(RC_853b3dd6b575c6d19eb5343d397a37e7 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENLastApprover.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
rec.ssENRequisitionApproval.Read( r, ref index);
rec.ssENRequisitionApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetLastApprover" 4_3fPiPRw02YUMCead3euQ of Action "GetRequisitions"
public static async Task<(RL_6a483f7b9e172adc49ec70475a3b324d,long)> datasetGetLastApprover(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteRequisition_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("z_TableDownloadsPDF.TableDownloadRequisitionsListInternalScreenPDF.GetRequisitions.GetLastApprover", "3edffde3-d123-4dc3-9850-c09e69dddeb9");
using var queryActivity = activitySource.CreateAggregateQueryActivity("z_TableDownloadsPDF.TableDownloadRequisitionsListInternalScreenPDF.GetRequisitions.GetLastApprover", "3edffde3-d123-4dc3-9850-c09e69dddeb9", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.kLQieB5cx02V9++AAXSp8g/NodesShownInESpaceTree.Lcj_8KUbPkKCIu632q+zFg/DataActions._TmOfZXShE2oRndX966fGQ/NodesNotShownInESpaceTree.4_3fPiPRw02YUMCead3euQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enlastapprover\".\"name\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, \"enrequisitionapprovallevel28\".\"approvedon\" o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98");
fromBuilder.Append(" FROM ((({Requisition} \"enrequisition120\" Left JOIN {RequisitionApproval} \"enrequisitionapproval33\" ON (\"enrequisition120\".\"id\" = \"enrequisitionapproval33\".\"requisitionid\"))  Left JOIN {RequisitionApprovalLevel} \"enrequisitionapprovallevel28\" ON (\"enrequisitionapproval33\".\"id\" = \"enrequisitionapprovallevel28\".\"requisitionapprovalid\"))  Left JOIN {User} \"enlastapprover\" ON (\"enrequisitionapprovallevel28\".\"approvedby\" = \"enlastapprover\".\"id\")) ");
whereBuilder.Append(" WHERE (\"enrequisition120\".\"id\" = cast(((coalesce(cast(nullif(@qpteRequisition_Id,'') as integer), 0))) as bigint)) AND (\"enrequisitionapprovallevel28\".\"approvalstatusid\" = ");
whereBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("rkrV30n0cEiW8dttOKG0gw"))).ssId);
whereBuilder.Append(")");
orderByBuilder.Append(" ORDER BY \"enrequisitionapprovallevel28\".\"approvedon\" DESC ");
sqlCmd.CreateParameterWithoutReplacements("@qpteRequisition_Id", DbType.String, qpteRequisition_Id);
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
RL_6a483f7b9e172adc49ec70475a3b324d outParamList = new RL_6a483f7b9e172adc49ec70475a3b324d();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetLastApproverReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[4];
opt[0] = new BitArray(new bool[] {true, false, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query z_TableDownloadsPDF.TableDownloadRequisitionsListInternalScreenPDF.GetRequisitions.GetLastApprover.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_6a483f7b9e172adc49ec70475a3b324d _tmp = new RL_6a483f7b9e172adc49ec70475a3b324d();
_tmp.AlternateReadDbMethodAsync = datasetGetLastApproverReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query z_TableDownloadsPDF.TableDownloadRequisitionsListInternalScreenPDF.GetRequisitions.GetLastApprover.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_6a483f7b9e172adc49ec70475a3b324d)_tmp;
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

private static async Task<RC_dc377962308205a06a34e4c0881035f7> datasetGetInvoicesPolizaSAPReadDbAsync(RC_dc377962308205a06a34e4c0881035f7 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoicePoliza.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
return rec;
}
// Query Function "GetInvoicesPolizaSAP" 7KpFcASYxEuq7k3O6BfGeA of Action "GetRequisitions"
public static async Task<(RL_f047dac638a0be52385038d9c0d00821,long)> datasetGetInvoicesPolizaSAP(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteRequisition_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("z_TableDownloadsPDF.TableDownloadRequisitionsListInternalScreenPDF.GetRequisitions.GetInvoicesPolizaSAP", "7045aaec-9804-4bc4-aaee-4dcee817c678");
using var queryActivity = activitySource.CreateAggregateQueryActivity("z_TableDownloadsPDF.TableDownloadRequisitionsListInternalScreenPDF.GetRequisitions.GetInvoicesPolizaSAP", "7045aaec-9804-4bc4-aaee-4dcee817c678", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.kLQieB5cx02V9++AAXSp8g/NodesShownInESpaceTree.Lcj_8KUbPkKCIu632q+zFg/DataActions._TmOfZXShE2oRndX966fGQ/NodesNotShownInESpaceTree.7KpFcASYxEuq7k3O6BfGeA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, \"eninvoicepoliza4\".\"polizasap\" o26, NULL o27, NULL o28, \"eninvoicepoliza4\".\"sentwhen\" o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90");
fromBuilder.Append(" FROM (({Requisition} \"enrequisition121\" Left JOIN {Invoice} \"eninvoice137\" ON (\"enrequisition121\".\"id\" = \"eninvoice137\".\"requisitionid\"))  Inner JOIN {InvoicePoliza} \"eninvoicepoliza4\" ON (\"eninvoice137\".\"id\" = \"eninvoicepoliza4\".\"id\")) ");
whereBuilder.Append(" WHERE (\"enrequisition121\".\"id\" = cast(((coalesce(cast(nullif(@qpteRequisition_Id,'') as integer), 0))) as bigint)) AND (\"eninvoicepoliza4\".\"sent\" = 1)");
sqlCmd.CreateParameterWithoutReplacements("@qpteRequisition_Id", DbType.String, qpteRequisition_Id);
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
RL_f047dac638a0be52385038d9c0d00821 outParamList = new RL_f047dac638a0be52385038d9c0d00821();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoicesPolizaSAPReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, false, true, true, false, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query z_TableDownloadsPDF.TableDownloadRequisitionsListInternalScreenPDF.GetRequisitions.GetInvoicesPolizaSAP.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_f047dac638a0be52385038d9c0d00821 _tmp = new RL_f047dac638a0be52385038d9c0d00821();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoicesPolizaSAPReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query z_TableDownloadsPDF.TableDownloadRequisitionsListInternalScreenPDF.GetRequisitions.GetInvoicesPolizaSAP.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_f047dac638a0be52385038d9c0d00821)_tmp;
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
