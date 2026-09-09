namespace ssConectaProveedores;

public partial class Actions {
public class lcvSaveRequisition : VarsBag {
public RC_44742d4360afdf16ff97b37b2eff1760 inParami_Requisition;
public bool inParami_IsFinishCapture;
public bool inParami_IsNewVersion;
public string inParami_CreateForUser;
public long inParamApprovalProcessId;
/// <summary>
/// Variable <code>l_RequisitionId</code> that represents the Service Studio RequisitionIdentifier
///  <code>l_RequisitionId</code> <p>Description: Requisition Identifier</p>
/// </summary>
public long varLcl_RequisitionId = 0L;

public Actions.lcoRequisitonStatusHistoryCreateOrUpdate resRequisitonStatusHistoryCreateOrUpdate =  new Actions.lcoRequisitonStatusHistoryCreateOrUpdate();
public Actions.lcoRequisitionCreateOrUpdate resRequisitionCreateOrUpdate2 =  new Actions.lcoRequisitionCreateOrUpdate();
public Actions.lcoRequisitionLogAdd resRequisitionLogAdd =  new Actions.lcoRequisitionLogAdd();
public Actions.lcoRequisitionCreateOrUpdate resRequisitionCreateOrUpdate4 =  new Actions.lcoRequisitionCreateOrUpdate();
public Actions.lcoRequisitionCreateOrUpdate resRequisitionCreateOrUpdate3 =  new Actions.lcoRequisitionCreateOrUpdate();
public Actions.lcoGetMaxDateFinishCapture resGetMaxDateFinishCapture =  new Actions.lcoGetMaxDateFinishCapture();
public RC_bb81744faa58ae73e7cd8db74cb32155 resGetRequisition_outParamRecord = new RC_bb81744faa58ae73e7cd8db74cb32155();

public RL_216ae81da35dfe5cfaaa600823fb4c79 queryResGetUserRegion_outParamList = new RL_216ae81da35dfe5cfaaa600823fb4c79();
public long queryResGetUserRegion_outParamCount = 0L;

public Actions.lcoGetUserRole resGetUserRole =  new Actions.lcoGetUserRole();
public Actions.lcoRequisitionLogAdd resRequisitionLogAdd4 =  new Actions.lcoRequisitionLogAdd();
public Actions.lcoRequisitionLogAdd resRequisitionLogAdd3 =  new Actions.lcoRequisitionLogAdd();
public Actions.lcoGenerateReqName resGenerateReqName =  new Actions.lcoGenerateReqName();
public Actions.lcoRequisitionLogAdd resRequisitionLogAdd2 =  new Actions.lcoRequisitionLogAdd();
public Actions.lcoRequisitionCreateOrUpdate resRequisitionCreateOrUpdate =  new Actions.lcoRequisitionCreateOrUpdate();
public RL_216ae81da35dfe5cfaaa600823fb4c79 queryResGetUserTelcelDirection_outParamList = new RL_216ae81da35dfe5cfaaa600823fb4c79();
public long queryResGetUserTelcelDirection_outParamCount = 0L;

public Actions.lcoRequisitionCreateOrUpdate resRequisitionCreateOrUpdate5 =  new Actions.lcoRequisitionCreateOrUpdate();
public Actions.lcoRequisitionLogAdd resRequisitionLogAdd6 =  new Actions.lcoRequisitionLogAdd();
public Actions.lcoRequisitionLogAdd resRequisitionLogAdd5 =  new Actions.lcoRequisitionLogAdd();
public Actions.lcoRequisitonStatusHistoryCreateOrUpdate resRequisitonStatusHistoryCreateOrUpdate3 =  new Actions.lcoRequisitonStatusHistoryCreateOrUpdate();
public Actions.lcoRequisitonStatusHistoryCreateOrUpdate resRequisitonStatusHistoryCreateOrUpdate2 =  new Actions.lcoRequisitonStatusHistoryCreateOrUpdate();
public RL_d6ebb6c8f3290a2a99c3f2feed622ea6 queryResGetRequisitionById_outParamList = new RL_d6ebb6c8f3290a2a99c3f2feed622ea6();
public long queryResGetRequisitionById_outParamCount = 0L;

public Actions.lcoRequisitionAccountingCreateOrUpdate resRequisitionAccountingCreateOrUpdate =  new Actions.lcoRequisitionAccountingCreateOrUpdate();
public Actions.lcoSaveRequisition resSaveRequisition =  new Actions.lcoSaveRequisition();
public Actions.lcoInitReqWF resInitReqWF =  new Actions.lcoInitReqWF();
public lcvSaveRequisition(RC_44742d4360afdf16ff97b37b2eff1760 inParami_Requisition, bool inParami_IsFinishCapture, bool inParami_IsNewVersion, string inParami_CreateForUser, long inParamApprovalProcessId) {
this.inParami_Requisition = inParami_Requisition;
this.inParami_IsFinishCapture = inParami_IsFinishCapture;
this.inParami_IsNewVersion = inParami_IsNewVersion;
this.inParami_CreateForUser = inParami_CreateForUser;
this.inParamApprovalProcessId = inParamApprovalProcessId;
}
}
public class lcoSaveRequisition : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public long outParamo_RequisitionId = 0L;

public bool outParamo_HasChangedStatus = false;

public lcoSaveRequisition() {
}
}
/// <summary>
/// Action <code>SaveRequisition</code> that represents the Service Studio action
///  <code>SaveRequisition</code> <p> Description: Action that saves a Requisition.</p>
/// </summary>
public static async Task<(ST_046fb53ebbe142526d95e87ef1ae9711Structure,long,bool)> ActionSaveRequisition(IRequestContext requestContext,RC_44742d4360afdf16ff97b37b2eff1760 inParami_Requisition,bool inParami_IsFinishCapture,bool inParami_IsNewVersion,string inParami_CreateForUser,long inParamApprovalProcessId,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
long outParamo_RequisitionId = default;
bool outParamo_HasChangedStatus = default;
lcoSaveRequisition result = new lcoSaveRequisition();
lcvSaveRequisition localVars = new lcvSaveRequisition(inParami_Requisition, inParami_IsFinishCapture, inParami_IsNewVersion, inParami_CreateForUser, inParamApprovalProcessId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("SaveRequisition", "8712a6e2-f6d8-4f99-93f7-6c2e10a62d8e"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("SaveRequisition", "8712a6e2-f6d8-4f99-93f7-6c2e10a62d8e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
bool block1 = false;
do {
block1 = false;
do {
if((localVars.inParami_IsNewVersion)) {
// Requisition
// i_Requisition.Requisition.RequisitionStatusId = DataCapture
localVars.inParami_Requisition.ssENRequisition.ssRequisitionStatusId = (ENRequisitionStatusEntity.GetRecordByKey(ObjectKey.Parse("pBDtHOXH_kG10TWqeiPa0A"))).ssId;

// i_Requisition.Requisition.MaxDateFinishCapture = NullDate
localVars.inParami_Requisition.ssENRequisition.ssMaxDateFinishCapture = BuiltInFunction.NullDate ();

// i_Requisition.Requisition.SubmittedOn = NullDate
localVars.inParami_Requisition.ssENRequisition.ssSubmittedOn = BuiltInFunction.NullDate ();

// i_Requisition.Requisition.IsCreatedByAnAssistente = i_CreateForUser <> NullTextIdentifier
localVars.inParami_Requisition.ssENRequisition.ssIsCreatedByAnAssistente = (localVars.inParami_CreateForUser!=BuiltInFunction.NullTextIdentifier ());
// RequisitionCreateOrUpdate4
localVars.resRequisitionCreateOrUpdate4.outParamId = await Actions.ActionRequisitionCreateOrUpdate(requestContext,localVars.inParami_Requisition.ssENRequisition,cancellationToken);

// l_RequisitionId = RequisitionCreateOrUpdate4.Id
localVars.varLcl_RequisitionId=localVars.resRequisitionCreateOrUpdate4.outParamId;
// DeleteRequisitionOldData
await Actions.ActionDeleteRequisitionOldData(requestContext,localVars.varLcl_RequisitionId,cancellationToken);

// RequisitionLogAdd6
localVars.resRequisitionLogAdd6.outParamId = await Actions.ActionRequisitionLogAdd(requestContext,new EN_fca813b8ca96d6759e00225744caa7d4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssRequisitionId = localVars.varLcl_RequisitionId, ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssMessage = ((((AppUtils.GetStringResource("qnjyHfqgkEW0_wf61nHfEw#Value.2063792252.1", "Requisition")+" ")+localVars.inParami_Requisition.ssENRequisition.ssName)+" ")+AppUtils.GetStringResource("qnjyHfqgkEW0_wf61nHfEw#Value.857721686.1", "reinitiated Data Capture.")) },cancellationToken);

} else {
// Query datasetGetRequisitionById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionById_maxRecords = 1;
if (datasetGetRequisitionById_maxRecords < 1) datasetGetRequisitionById_maxRecords = 1;
int datasetGetRequisitionById_startIndex = 0;(localVars.queryResGetRequisitionById_outParamList,localVars.queryResGetRequisitionById_outParamCount) = await FuncActionSaveRequisition.datasetGetRequisitionById(requestContext,datasetGetRequisitionById_maxRecords,datasetGetRequisitionById_startIndex,IterationMultiplicity.Never,localVars.inParami_Requisition.ssENRequisition.ssId,cancellationToken);

if((localVars.queryResGetRequisitionById_outParamList.Empty)) {
// Has Region defined?
if((!((localVars.inParami_Requisition.ssENRequisition.ssRegionId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ()))))) {
// Query datasetGetUserRegion
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserRegion_maxRecords = 1;
if (datasetGetUserRegion_maxRecords < 1) datasetGetUserRegion_maxRecords = 1;
int datasetGetUserRegion_startIndex = 0;(localVars.queryResGetUserRegion_outParamList,localVars.queryResGetUserRegion_outParamCount) = await FuncActionSaveRequisition.datasetGetUserRegion(requestContext,datasetGetUserRegion_maxRecords,datasetGetUserRegion_startIndex,IterationMultiplicity.Never,BuiltInFunction.GetUserId (),cancellationToken);

if(((localVars.queryResGetUserRegion_outParamList.CurrentRec.ssENUser_Extended_Internal.ssRegionId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "User has no associated region."
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("Oq7bJic4jE2zUtjyWImLgg#Value.-2002426268.1", "User has no associated region.");
goto RETURN_STATEMENT;

} else {
// RegionId
// i_Requisition.Requisition.RegionId = GetUserRegion.List.Current.User_Extended_Internal.RegionId
localVars.inParami_Requisition.ssENRequisition.ssRegionId = localVars.queryResGetUserRegion_outParamList.CurrentRec.ssENUser_Extended_Internal.ssRegionId;
}

}

// GetUserRole
localVars.resGetUserRole.outParamo_ApplicationRoleId = await Actions.ActionGetUserRole(requestContext,BuiltInFunction.GetUserId (),3,true,false,cancellationToken);

if(((localVars.resGetUserRole.outParamo_ApplicationRoleId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "User doest not have a role in the application!"
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("Qe723h8ezUykuIVhgMLIcQ#Value.-496136223.1", "User doest not have a role in the application!");
goto RETURN_STATEMENT;

} else {
// GenerateReqName
(localVars.resGenerateReqName.outParamo_Name,localVars.resGenerateReqName.outParamo_Counter) = await Actions.ActionGenerateReqName(requestContext,localVars.inParami_Requisition.ssENRequisition.ssRegionId,cancellationToken);

// GetMaxDateFinishCapture
localVars.resGetMaxDateFinishCapture.outParamo_MaxDateTime = await Actions.ActionGetMaxDateFinishCapture(requestContext,cancellationToken);

// Query datasetGetUserTelcelDirection
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserTelcelDirection_maxRecords = 0;
int datasetGetUserTelcelDirection_startIndex = 0;(localVars.queryResGetUserTelcelDirection_outParamList,localVars.queryResGetUserTelcelDirection_outParamCount) = await FuncActionSaveRequisition.datasetGetUserTelcelDirection(requestContext,datasetGetUserTelcelDirection_maxRecords,datasetGetUserTelcelDirection_startIndex,IterationMultiplicity.Never,BuiltInFunction.GetUserId (),cancellationToken);

// i_Requisition.Requisition.RequisitionStatusId = DataCapture
localVars.inParami_Requisition.ssENRequisition.ssRequisitionStatusId = (ENRequisitionStatusEntity.GetRecordByKey(ObjectKey.Parse("pBDtHOXH_kG10TWqeiPa0A"))).ssId;

// i_Requisition.Requisition.Name = GenerateReqName.o_Name
localVars.inParami_Requisition.ssENRequisition.ssName = localVars.resGenerateReqName.outParamo_Name;

// i_Requisition.Requisition.MaxDateFinishCapture = GetMaxDateFinishCapture.o_MaxDateTime
localVars.inParami_Requisition.ssENRequisition.ssMaxDateFinishCapture = localVars.resGetMaxDateFinishCapture.outParamo_MaxDateTime;

// i_Requisition.Requisition.Counter = GenerateReqName.o_Counter
localVars.inParami_Requisition.ssENRequisition.ssCounter = localVars.resGenerateReqName.outParamo_Counter;

// i_Requisition.Requisition.CreatedByApplicationRole = GetUserRole.o_ApplicationRoleId
localVars.inParami_Requisition.ssENRequisition.ssCreatedByApplicationRole = localVars.resGetUserRole.outParamo_ApplicationRoleId;

// i_Requisition.Requisition.IsCreatedByAnAssistente = i_CreateForUser <> NullTextIdentifier
localVars.inParami_Requisition.ssENRequisition.ssIsCreatedByAnAssistente = (localVars.inParami_CreateForUser!=BuiltInFunction.NullTextIdentifier ());

// i_Requisition.Requisition.TelcelDirectionId = GetUserTelcelDirection.List.Current.User_Extended_Internal.TelcelDirectionId
localVars.inParami_Requisition.ssENRequisition.ssTelcelDirectionId = localVars.queryResGetUserTelcelDirection_outParamList.CurrentRec.ssENUser_Extended_Internal.ssTelcelDirectionId;
// RequisitionCreateOrUpdate
localVars.resRequisitionCreateOrUpdate.outParamId = await Actions.ActionRequisitionCreateOrUpdate(requestContext,localVars.inParami_Requisition.ssENRequisition,cancellationToken);

// l_RequisitionId = RequisitionCreateOrUpdate.Id
localVars.varLcl_RequisitionId=localVars.resRequisitionCreateOrUpdate.outParamId;

// i_Requisition.Requisition.Id = RequisitionCreateOrUpdate.Id
localVars.inParami_Requisition.ssENRequisition.ssId = localVars.resRequisitionCreateOrUpdate.outParamId;
// RequisitionLogAdd
localVars.resRequisitionLogAdd.outParamId = await Actions.ActionRequisitionLogAdd(requestContext,new EN_fca813b8ca96d6759e00225744caa7d4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssRequisitionId = localVars.varLcl_RequisitionId, ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssMessage = ((((AppUtils.GetStringResource("N9us9z_8w0iY7Svv_AkcxA#Value.2063792252.1", "Requisition")+" ")+localVars.inParami_Requisition.ssENRequisition.ssName)+" ")+AppUtils.GetStringResource("N9us9z_8w0iY7Svv_AkcxA#Value.-385867031.1", "initiated Data Capture.")) },cancellationToken);

}

} else {
// l_RequisitionId = GetRequisitionById.List.Current.Requisition.Id
localVars.varLcl_RequisitionId=localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssId;
if(((localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssRequisitionStatusId==(ENRequisitionStatusEntity.GetRecordByKey(ObjectKey.Parse("5K2SyCJmtU+vkuFEbRmA_g"))).ssId))) {
// SaveRequisition
(localVars.resSaveRequisition.outParamo_Output,localVars.resSaveRequisition.outParamo_RequisitionId,localVars.resSaveRequisition.outParamo_HasChangedStatus) = await Actions.ActionSaveRequisition(requestContext,localVars.inParami_Requisition,localVars.inParami_IsFinishCapture,true,localVars.inParami_CreateForUser,localVars.inParamApprovalProcessId,cancellationToken);

goto RETURN_STATEMENT;

} else {
if((((localVars.inParami_Requisition.ssENRequisition.ssMaxDateFinishCapture!=BuiltInFunction.NullDate ())&&(BuiltInFunction.CurrDateTime ()>localVars.inParami_Requisition.ssENRequisition.ssMaxDateFinishCapture)))) {
if(((localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssRequisitionStatusId==(ENRequisitionStatusEntity.GetRecordByKey(ObjectKey.Parse("pBDtHOXH_kG10TWqeiPa0A"))).ssId))) {
// GetRequisitionById.List.Current.Requisition.RequisitionStatusId = Expired
localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition.ssRequisitionStatusId = (ENRequisitionStatusEntity.GetRecordByKey(ObjectKey.Parse("wpdx_Qw3wEmfndGLo0VZ+Q"))).ssId;
// RequisitionCreateOrUpdate2
localVars.resRequisitionCreateOrUpdate2.outParamId = await Actions.ActionRequisitionCreateOrUpdate(requestContext,localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisition,cancellationToken);

// RequisitionLogAdd2
localVars.resRequisitionLogAdd2.outParamId = await Actions.ActionRequisitionLogAdd(requestContext,new EN_fca813b8ca96d6759e00225744caa7d4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssRequisitionId = localVars.varLcl_RequisitionId, ssCreatedBy = BuiltInFunction.NullTextIdentifier (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssMessage = AppUtils.GetStringResource("HOOv+pacW0iGE+FdDmD+Yg#Value.1633836077.1", "Requisition automatically updated to Expired Status due to exceeding the 72h limit for submission.") },cancellationToken);

// RequisitonStatusHistoryCreateOrUpdate2
localVars.resRequisitonStatusHistoryCreateOrUpdate2.outParamId = await Actions.ActionRequisitonStatusHistoryCreateOrUpdate(requestContext,new EN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssRequisitionId = localVars.varLcl_RequisitionId, ssRequisitionStatusId = (ENRequisitionStatusEntity.GetRecordByKey(ObjectKey.Parse("wpdx_Qw3wEmfndGLo0VZ+Q"))).ssId, ssTimeStamp = BuiltInFunction.CurrDateTime (), ssCreatedBy = BuiltInFunction.NullTextIdentifier () },cancellationToken);

// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "Requisition automatically updated to Expired Status due to exceeding the 72h limit for submission."
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("Nr2iKlJb00Ckc+VgH1D8xg#Value.1633836077.1", "Requisition automatically updated to Expired Status due to exceeding the 72h limit for submission.");

// o_HasChangedStatus = True
result.outParamo_HasChangedStatus=true;
goto RETURN_STATEMENT;

} else {
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "Updates to this Requisition are not available."
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("yVpoiPVIm0uBKjPHM_nyZg#Value.979795509.1", "Updates to this Requisition are not available.");
goto RETURN_STATEMENT;

}

} else {
// RequisitionCreateOrUpdate5
localVars.resRequisitionCreateOrUpdate5.outParamId = await Actions.ActionRequisitionCreateOrUpdate(requestContext,localVars.inParami_Requisition.ssENRequisition,cancellationToken);

if(((localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRequisitionAccounting.ssId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// RequisitionAccountingCreateOrUpdate
localVars.resRequisitionAccountingCreateOrUpdate.outParamId = await Actions.ActionRequisitionAccountingCreateOrUpdate(requestContext,localVars.inParami_Requisition.ssENRequisitionAccounting,cancellationToken);

// SaveRequisitionAccConcepts
await Actions.ActionSaveRequisitionAccConcepts(requestContext,localVars.varLcl_RequisitionId,(await RL_eb1e4f883a237aab70c23418de71281c.ConvertAsync(localVars.inParami_Requisition.ssRLRequisitionAccConceptsRecordList, new RL_eb1e4f883a237aab70c23418de71281c(), async (RC_f80fde4acf9a7dc465a1d535c05dfb8e source, EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord target, CancellationToken cancellationToken) => {
target = source.ssENRequisitionAccConcepts;
return target;
}, cancellationToken)),(await RecordUtils.ConvertAsync(localVars.inParami_Requisition.ssRCi_RequisitionAccConcept_EstimEqualAg, new RC_baf165956df9a5eebdc813b129b5fb73(), async (RC_cdb29de40f41bea5403aac7edb2d6159 source, RC_baf165956df9a5eebdc813b129b5fb73 target, CancellationToken cancellationToken) => {
target.ssENMainAccConcepts = source.ssENMainAccConcept;
target.ssRLSubAccConcepts = source.ssRLSubAccConcepts;
return target;
}, cancellationToken)),cancellationToken);

// jump to block1
block1 = true;
break;
} else {
break;
}

}

}

}

}

// RequisitonStatusHistoryCreateOrUpdate
localVars.resRequisitonStatusHistoryCreateOrUpdate.outParamId = await Actions.ActionRequisitonStatusHistoryCreateOrUpdate(requestContext,new EN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssRequisitionId = localVars.varLcl_RequisitionId, ssRequisitionStatusId = localVars.inParami_Requisition.ssENRequisition.ssRequisitionStatusId, ssTimeStamp = BuiltInFunction.CurrDateTime (), ssCreatedBy = BuiltInFunction.GetUserId () },cancellationToken);

// ALIGN
} while(false)
;
if(block1) {
break;
}

// ALIGN
// SaveRequisitionServices
await Actions.ActionSaveRequisitionServices(requestContext,localVars.varLcl_RequisitionId,(await RL_f631cdf92d6e85a1d6f52da923631909.ConvertAsync(localVars.inParami_Requisition.ssRLRequisitionServices, new RL_f631cdf92d6e85a1d6f52da923631909(), async (RC_04e7247757060d4016b43102119b0dd6 source, EN_455768e63ed34ad2746f7c539b65e1caEntityRecord target, CancellationToken cancellationToken) => {
target = source;
return target;
}, cancellationToken)),cancellationToken);

// SaveRequisitionCostCenters
await Actions.ActionSaveRequisitionCostCenters(requestContext,localVars.varLcl_RequisitionId,localVars.inParami_Requisition.ssRLRequisitionCostCenters,cancellationToken);

} while(false)
;
// SaveRequisitionFiles
await Actions.ActionSaveRequisitionFiles(requestContext,localVars.varLcl_RequisitionId,(await RecordUtils.ConvertAsync(localVars.inParami_Requisition, new RC_d66b0b09097e5f0bc1ec31076e9aa762(), async (RC_44742d4360afdf16ff97b37b2eff1760 source, RC_d66b0b09097e5f0bc1ec31076e9aa762 target, CancellationToken cancellationToken) => {
target.ssRLAllFiles = source.ssRLAllFiles;
target.ssENRequisition = source.ssENRequisition;
return target;
}, cancellationToken)),cancellationToken);

if((localVars.inParami_IsFinishCapture)) {
// CommitTransaction
await ExtendedActions.CommitTransaction(requestContext,cancellationToken);

// InitReqWF
localVars.resInitReqWF.outParamo_Output = await Actions.ActionInitReqWF(requestContext,localVars.varLcl_RequisitionId,localVars.inParami_CreateForUser,localVars.inParamApprovalProcessId,cancellationToken);

if(((!localVars.resInitReqWF.outParamo_Output.ssIsSuccess))) {
// RequisitionLogAdd4
localVars.resRequisitionLogAdd4.outParamId = await Actions.ActionRequisitionLogAdd(requestContext,new EN_fca813b8ca96d6759e00225744caa7d4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssRequisitionId = localVars.varLcl_RequisitionId, ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssMessage = ((((((AppUtils.GetStringResource("Twjq61OlPEKwkd_xxDFlcw#Value.2063792252.1", "Requisition")+" ")+localVars.inParami_Requisition.ssENRequisition.ssName)+" ")+AppUtils.GetStringResource("Twjq61OlPEKwkd_xxDFlcw#Value.-983246013.1", "failed to initiate approval process:"))+" ")+localVars.resInitReqWF.outParamo_Output.ssMessage), ssIsError = true },cancellationToken);

// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "Requisition failed to initiate approval process:" + " " + InitReqWF.o_Output.Message
result.outParamo_Output.ssMessage = ((AppUtils.GetStringResource("87vwjCyon0CsN0YVpNi8hA#Value.73085031.1", "Requisition failed to initiate approval process:")+" ")+localVars.resInitReqWF.outParamo_Output.ssMessage);

// o_RequisitionId = l_RequisitionId
result.outParamo_RequisitionId=localVars.varLcl_RequisitionId;
} else {
// GetRequisition
localVars.resGetRequisition_outParamRecord = await ExtendedActions.GetRequisition(requestContext,localVars.varLcl_RequisitionId,cancellationToken);

// GetRequisition.Record.Requisition.RequisitionStatusId = InApproval
localVars.resGetRequisition_outParamRecord.ssENRequisition.ssRequisitionStatusId = (ENRequisitionStatusEntity.GetRecordByKey(ObjectKey.Parse("GxzelG_MJUCC7GqpNLMaDw"))).ssId;

// GetRequisition.Record.Requisition.SubmittedOn = CurrDate
localVars.resGetRequisition_outParamRecord.ssENRequisition.ssSubmittedOn = BuiltInFunction.CurrDate ();
// RequisitionCreateOrUpdate3
localVars.resRequisitionCreateOrUpdate3.outParamId = await Actions.ActionRequisitionCreateOrUpdate(requestContext,localVars.resGetRequisition_outParamRecord.ssENRequisition,cancellationToken);

// RequisitionLogAdd3
localVars.resRequisitionLogAdd3.outParamId = await Actions.ActionRequisitionLogAdd(requestContext,new EN_fca813b8ca96d6759e00225744caa7d4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssRequisitionId = localVars.varLcl_RequisitionId, ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssMessage = ((((AppUtils.GetStringResource("YI9dvQc02UqiDGaNQnqyAg#Value.2063792252.1", "Requisition")+" ")+localVars.inParami_Requisition.ssENRequisition.ssName)+" ")+AppUtils.GetStringResource("YI9dvQc02UqiDGaNQnqyAg#Value.476391.1", "initiated approval process.")) },cancellationToken);

// RequisitonStatusHistoryCreateOrUpdate3
localVars.resRequisitonStatusHistoryCreateOrUpdate3.outParamId = await Actions.ActionRequisitonStatusHistoryCreateOrUpdate(requestContext,new EN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssRequisitionId = localVars.varLcl_RequisitionId, ssRequisitionStatusId = localVars.resGetRequisition_outParamRecord.ssENRequisition.ssRequisitionStatusId, ssTimeStamp = BuiltInFunction.CurrDateTime (), ssCreatedBy = BuiltInFunction.GetUserId () },cancellationToken);

// Result
// o_RequisitionId = l_RequisitionId
result.outParamo_RequisitionId=localVars.varLcl_RequisitionId;

// o_HasChangedStatus = True
result.outParamo_HasChangedStatus=true;

// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
// SendReqFirstApproverEmail
await Actions.ActionSendReqFirstApproverEmail(requestContext,localVars.varLcl_RequisitionId,cancellationToken);

}

} else {
// RequisitionLogAdd5
localVars.resRequisitionLogAdd5.outParamId = await Actions.ActionRequisitionLogAdd(requestContext,new EN_fca813b8ca96d6759e00225744caa7d4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssRequisitionId = localVars.varLcl_RequisitionId, ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssMessage = ((((AppUtils.GetStringResource("3RvULEQO3EmifvdSGj+ZQA#Value.2063792252.1", "Requisition")+" ")+localVars.inParami_Requisition.ssENRequisition.ssName)+" ")+AppUtils.GetStringResource("3RvULEQO3EmifvdSGj+ZQA#Value.1322596051.1", "updated.")) },cancellationToken);

// Result
// o_RequisitionId = l_RequisitionId
result.outParamo_RequisitionId=localVars.varLcl_RequisitionId;

// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
}

} //close CreateActionActivity using block
} // try

finally {
outParamo_Output = result.outParamo_Output;
outParamo_RequisitionId = result.outParamo_RequisitionId;
outParamo_HasChangedStatus = result.outParamo_HasChangedStatus;
} // inner-finally
RETURN_STATEMENT:
return (outParamo_Output,outParamo_RequisitionId,outParamo_HasChangedStatus);
}

public static class FuncActionSaveRequisition {

// Query Function "GetUserRegion" cqA7VHDQwkiR7uyN1BQPAg of Action "SaveRequisition"
public static async Task<(RL_216ae81da35dfe5cfaaa600823fb4c79,long)> datasetGetUserRegion(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SaveRequisition.GetUserRegion", "543ba072-d070-48c2-91ee-ec8dd4140f02");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SaveRequisition.GetUserRegion", "543ba072-d070-48c2-91ee-ec8dd4140f02", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.4qYSh9j2mU+T92wuEKYtjg/NodesNotShownInESpaceTree.cqA7VHDQwkiR7uyN1BQPAg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, \"enuser_extended_internal51\".\"regionid\" o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19");
fromBuilder.Append(" FROM {User_Extended_Internal} \"enuser_extended_internal51\"");
whereBuilder.Append(" WHERE ");
if ((qpusId.Trim()!="")) {
whereBuilder.Append("((\"enuser_extended_internal51\".\"id\" = @qpusId) AND (\"enuser_extended_internal51\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusId", DbType.String, qpusId);
} else {
whereBuilder.Append("(\"enuser_extended_internal51\".\"id\" IS NULL)");
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
RL_216ae81da35dfe5cfaaa600823fb4c79 outParamList = new RL_216ae81da35dfe5cfaaa600823fb4c79();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SaveRequisition.GetUserRegion.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_216ae81da35dfe5cfaaa600823fb4c79 _tmp = new RL_216ae81da35dfe5cfaaa600823fb4c79();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SaveRequisition.GetUserRegion.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_216ae81da35dfe5cfaaa600823fb4c79)_tmp;
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

// Query Function "GetUserTelcelDirection" rplcroG01kC6zgfuVKD1xQ of Action "SaveRequisition"
public static async Task<(RL_216ae81da35dfe5cfaaa600823fb4c79,long)> datasetGetUserTelcelDirection(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SaveRequisition.GetUserTelcelDirection", "ae5c99ae-b481-40d6-bace-07ee54a0f5c5");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SaveRequisition.GetUserTelcelDirection", "ae5c99ae-b481-40d6-bace-07ee54a0f5c5", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.4qYSh9j2mU+T92wuEKYtjg/NodesNotShownInESpaceTree.rplcroG01kC6zgfuVKD1xQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, \"enuser_extended_internal52\".\"telceldirectionid\" o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19");
fromBuilder.Append(" FROM {User_Extended_Internal} \"enuser_extended_internal52\"");
whereBuilder.Append(" WHERE ");
if ((qpusId.Trim()!="")) {
whereBuilder.Append("((\"enuser_extended_internal52\".\"id\" = @qpusId) AND (\"enuser_extended_internal52\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusId", DbType.String, qpusId);
} else {
whereBuilder.Append("(\"enuser_extended_internal52\".\"id\" IS NULL)");
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
RL_216ae81da35dfe5cfaaa600823fb4c79 outParamList = new RL_216ae81da35dfe5cfaaa600823fb4c79();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SaveRequisition.GetUserTelcelDirection.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_216ae81da35dfe5cfaaa600823fb4c79 _tmp = new RL_216ae81da35dfe5cfaaa600823fb4c79();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SaveRequisition.GetUserTelcelDirection.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_216ae81da35dfe5cfaaa600823fb4c79)_tmp;
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

private static async Task<RC_d44c83c6811c5993da31ecba331d9c39> datasetGetRequisitionByIdReadDbAsync(RC_d44c83c6811c5993da31ecba331d9c39 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENRequisition.Read( r, ref index);
rec.ssENRequisitionAccounting.Read( r, ref index);
return rec;
}
// Query Function "GetRequisitionById" UCQ11EdMqES+o5R9W2Eg2A of Action "SaveRequisition"
public static async Task<(RL_d6ebb6c8f3290a2a99c3f2feed622ea6,long)> datasetGetRequisitionById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisition_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SaveRequisition.GetRequisitionById", "d4352450-4c47-44a8-bea3-947d5b6120d8");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SaveRequisition.GetRequisitionById", "d4352450-4c47-44a8-bea3-947d5b6120d8", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.4qYSh9j2mU+T92wuEKYtjg/NodesNotShownInESpaceTree.UCQ11EdMqES+o5R9W2Eg2A, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enrequisition36\".\"id\" o0, \"enrequisition36\".\"name\" o1, \"enrequisition36\".\"counter\" o2, \"enrequisition36\".\"requisitionstatusid\" o3, \"enrequisition36\".\"supplierid\" o4, \"enrequisition36\".\"regionid\" o5, \"enrequisition36\".\"accountingregionid\" o6, \"enrequisition36\".\"applicantid\" o7, \"enrequisition36\".\"maxdatefinishcapture\" o8, \"enrequisition36\".\"projectassetserviceid\" o9, \"enrequisition36\".\"projectassetservice\" o10, \"enrequisition36\".\"projectdescription\" o11, \"enrequisition36\".\"frequencyid\" o12, \"enrequisition36\".\"issustainability\" o13, \"enrequisition36\".\"sustainabilityid\" o14, \"enrequisition36\".\"businessvaluecategoryid\" o15, \"enrequisition36\".\"businessvaluesubcategoryid\" o16, trim_scale(\"enrequisition36\".\"totalamount\"::numeric) o17, \"enrequisition36\".\"currencyid\" o18, \"enrequisition36\".\"distributionid\" o19, \"enrequisition36\".\"costcenterid\" o20, \"enrequisition36\".\"hascontract\" o21, \"enrequisition36\".\"iscontractpending\" o22, \"enrequisition36\".\"hasdeposit\" o23, \"enrequisition36\".\"hasinsurance\" o24, \"enrequisition36\".\"hasadvancepayment\" o25, \"enrequisition36\".\"accountingservicetypeid_depr\" o26, \"enrequisition36\".\"servicedescription_deprec\" o27, \"enrequisition36\".\"invoiceusageid_deprec\" o28, \"enrequisition36\".\"serviceformatid\" o29, \"enrequisition36\".\"companyid\" o30, trim_scale(\"enrequisition36\".\"retentionrate\"::numeric) o31, trim_scale(\"enrequisition36\".\"negotiatedexchangerate\"::numeric) o32, \"enrequisition36\".\"paymentmethodid\" o33, \"enrequisition36\".\"paymenttermsid\" o34, \"enrequisition36\".\"isautomaticaccounting\" o35, \"enrequisition36\".\"createdby\" o36, \"enrequisition36\".\"createdon\" o37, \"enrequisition36\".\"updatedon\" o38, \"enrequisition36\".\"updatedby\" o39, \"enrequisition36\".\"createdbyapplicationrole\" o40, \"enrequisition36\".\"dateofcommitment\" o41, \"enrequisition36\".\"hascontractfileuploaded\" o42, \"enrequisition36\".\"hasupdateddateofcommitment\" o43, \"enrequisition36\".\"submittedon\" o44, \"enrequisition36\".\"isdonation\" o45, \"enrequisition36\".\"advwithoutinvoice\" o46, \"enrequisition36\".\"wasadvwithoutinvoice\" o47, \"enrequisition36\".\"isadvanced\" o48, \"enrequisition36\".\"documenttypeid\" o49, \"enrequisition36\".\"iscreatedbyanassistente\" o50, \"enrequisition36\".\"telceldirectionid\" o51, \"enrequisition36\".\"hasmultiupload\" o52, \"enrequisition36\".\"accountingdate\" o53, \"enrequisition36\".\"paymentoptionsid\" o54, \"enrequisition36\".\"paymentwaysid\" o55, \"enrequisition36\".\"buydocnumber\" o56, \"enrequisition36\".\"buydocposition\" o57, \"enrequisitionaccounting3\".\"id\" o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76");
fromBuilder.Append(" FROM ({Requisition} \"enrequisition36\" Left JOIN {RequisitionAccounting} \"enrequisitionaccounting3\" ON (\"enrequisition36\".\"id\" = \"enrequisitionaccounting3\".\"requisitionid\")) ");
whereBuilder.Append(" WHERE ");
if (qpreRequisition_Id != 0) {
whereBuilder.Append("((\"enrequisition36\".\"id\" = @qpreRequisition_Id) AND (\"enrequisition36\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisition_Id", DbType.Int64, qpreRequisition_Id);
} else {
whereBuilder.Append("(\"enrequisition36\".\"id\" IS NULL)");
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
RL_d6ebb6c8f3290a2a99c3f2feed622ea6 outParamList = new RL_d6ebb6c8f3290a2a99c3f2feed622ea6();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetRequisitionByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SaveRequisition.GetRequisitionById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_d6ebb6c8f3290a2a99c3f2feed622ea6 _tmp = new RL_d6ebb6c8f3290a2a99c3f2feed622ea6();
_tmp.AlternateReadDbMethodAsync = datasetGetRequisitionByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SaveRequisition.GetRequisitionById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_d6ebb6c8f3290a2a99c3f2feed622ea6)_tmp;
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
