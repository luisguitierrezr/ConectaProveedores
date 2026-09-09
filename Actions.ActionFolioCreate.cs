namespace ssConectaProveedores;

public partial class Actions {
public class lcvFolioCreate : VarsBag {
public RL_123aa03224ec08dab8cbe26021987012 inParamI_SelectedLines;
public long inParamI_OrderMainId;
public string inParamI_FirstApprovalId;
public string inParamI_Comments;
public EN_f81a3d226103fd013068b8763798067aEntityRecord inParamInvoiceExtended;
public RL_1501ee54ff868a67eff67465502ee3d9 inParamFilesListExtra;
public RL_1501ee54ff868a67eff67465502ee3d9 inParamFilesList;
public long inParamInvoiceId;
public ST_6f620840109ac6f721328b723ec0152cStructure inParamInvoiceForeignToCreate;
public int inParamApprovalProcessTypeId;
public RC_1c2482ce6cd4b83ca44ec0510b231d44 inParamConstructionData;
public long inParamApprovalProcessId;
public RC_45d2d2c3c5fe5caa10fa5e20326622ac inParami_SummaryRec;
public bool inParami_IsMassCreate;
public int inParami_MinuteSelected;
public long inParami_OrderAccConceptID;
public RL_1501ee54ff868a67eff67465502ee3d9 inParamCreditNoteFilesList;
public decimal inParamImportAnticipo;
public bool inParamIsNational;
public int inParamOffsetUtc;
/// <summary>
/// Variable <code>Folio</code> that represents the Service Studio Folio <code>Folio</code>
///  <p>Description: </p>
/// </summary>
public EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord varLcFolio = new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord();

/// <summary>
/// Variable <code>TotalAmount</code> that represents the Service Studio Decimal
///  <code>TotalAmount</code> <p>Description: </p>
/// </summary>
public decimal varLcTotalAmount = 0.0M;

/// <summary>
/// Variable <code>TotalAmountIva</code> that represents the Service Studio Decimal
///  <code>TotalAmountIva</code> <p>Description: </p>
/// </summary>
public decimal varLcTotalAmountIva = 0.0M;

public long resCreateFolioExtended_outParamId = 0L;

public Actions.lcoOrderLogAdd resOrderLogAdd =  new Actions.lcoOrderLogAdd();
public Actions.lcoGetFolioName resGetFolioName =  new Actions.lcoGetFolioName();
public long resCreateFolioFiles_outParamId = 0L;

public Actions.lcoInitFolioWF resInitFolioWF =  new Actions.lcoInitFolioWF();
public long resCreateFolioItems_outParamId = 0L;

public Actions.lcoFolioLogAdd resFolioLogAdd =  new Actions.lcoFolioLogAdd();
public Actions.lcoUploadInvoiceFiles_WithCN resUploadInvoiceFiles_WithCN =  new Actions.lcoUploadInvoiceFiles_WithCN();
public long resCreateFolioRegionSeq_outParamId = 0L;

public RL_321dd0d04a3c06ceeabbe51d5902cdbf queryResGetFolioRegionSeqsByRegionId_outParamList = new RL_321dd0d04a3c06ceeabbe51d5902cdbf();
public long queryResGetFolioRegionSeqsByRegionId_outParamCount = 0L;

public RL_0b8b481397d3c2af696e2a2d3956b721 queryResGetOrdersItems_outParamList = new RL_0b8b481397d3c2af696e2a2d3956b721();
public long queryResGetOrdersItems_outParamCount = 0L;

public RL_a5d34dadc1b2a091bffaa2b834b2d48d queryResGetOrder_outParamList = new RL_a5d34dadc1b2a091bffaa2b834b2d48d();
public long queryResGetOrder_outParamCount = 0L;

public long resServiceStorageCreateOrUpdateBigFile_outParamId = 0L;

public long resCreateFolioObservations_outParamId = 0L;

public Actions.lcoGetSettingsMargins resGetSettingsMargins =  new Actions.lcoGetSettingsMargins();
public long resCreateFolio_outParamId = 0L;

public lcvFolioCreate(RL_123aa03224ec08dab8cbe26021987012 inParamI_SelectedLines, long inParamI_OrderMainId, string inParamI_FirstApprovalId, string inParamI_Comments, EN_f81a3d226103fd013068b8763798067aEntityRecord inParamInvoiceExtended, RL_1501ee54ff868a67eff67465502ee3d9 inParamFilesListExtra, RL_1501ee54ff868a67eff67465502ee3d9 inParamFilesList, long inParamInvoiceId, ST_6f620840109ac6f721328b723ec0152cStructure inParamInvoiceForeignToCreate, int inParamApprovalProcessTypeId, RC_1c2482ce6cd4b83ca44ec0510b231d44 inParamConstructionData, long inParamApprovalProcessId, RC_45d2d2c3c5fe5caa10fa5e20326622ac inParami_SummaryRec, bool inParami_IsMassCreate, int inParami_MinuteSelected, long inParami_OrderAccConceptID, RL_1501ee54ff868a67eff67465502ee3d9 inParamCreditNoteFilesList, decimal inParamImportAnticipo, bool inParamIsNational, int inParamOffsetUtc) {
this.inParamI_SelectedLines = inParamI_SelectedLines;
this.inParamI_OrderMainId = inParamI_OrderMainId;
this.inParamI_FirstApprovalId = inParamI_FirstApprovalId;
this.inParamI_Comments = inParamI_Comments;
this.inParamInvoiceExtended = inParamInvoiceExtended;
this.inParamFilesListExtra = inParamFilesListExtra;
this.inParamFilesList = inParamFilesList;
this.inParamInvoiceId = inParamInvoiceId;
this.inParamInvoiceForeignToCreate = inParamInvoiceForeignToCreate;
this.inParamApprovalProcessTypeId = inParamApprovalProcessTypeId;
this.inParamConstructionData = inParamConstructionData;
this.inParamApprovalProcessId = inParamApprovalProcessId;
this.inParami_SummaryRec = inParami_SummaryRec;
this.inParami_IsMassCreate = inParami_IsMassCreate;
this.inParami_MinuteSelected = inParami_MinuteSelected;
this.inParami_OrderAccConceptID = inParami_OrderAccConceptID;
this.inParamCreditNoteFilesList = inParamCreditNoteFilesList;
this.inParamImportAnticipo = inParamImportAnticipo;
this.inParamIsNational = inParamIsNational;
this.inParamOffsetUtc = inParamOffsetUtc;
}
}
public class lcoFolioCreate : VarsBag {
public string outParamo_FolioName = "";

public string outParamErrorMsg = "";

public lcoFolioCreate() {
}
}
/// <summary>
/// Action <code>FolioCreate</code> that represents the Service Studio action <code>FolioCreate</code>
///  <p> Description: </p>
/// </summary>
public static async Task<(string,string)> ActionFolioCreate(IRequestContext requestContext,RL_123aa03224ec08dab8cbe26021987012 inParamI_SelectedLines,long inParamI_OrderMainId,string inParamI_FirstApprovalId,string inParamI_Comments,EN_f81a3d226103fd013068b8763798067aEntityRecord inParamInvoiceExtended,RL_1501ee54ff868a67eff67465502ee3d9 inParamFilesListExtra,RL_1501ee54ff868a67eff67465502ee3d9 inParamFilesList,long inParamInvoiceId,ST_6f620840109ac6f721328b723ec0152cStructure inParamInvoiceForeignToCreate,int inParamApprovalProcessTypeId,RC_1c2482ce6cd4b83ca44ec0510b231d44 inParamConstructionData,long inParamApprovalProcessId,RC_45d2d2c3c5fe5caa10fa5e20326622ac inParami_SummaryRec,bool inParami_IsMassCreate,int inParami_MinuteSelected,long inParami_OrderAccConceptID,RL_1501ee54ff868a67eff67465502ee3d9 inParamCreditNoteFilesList,decimal inParamImportAnticipo,bool inParamIsNational,int inParamOffsetUtc,CancellationToken cancellationToken) {
string outParamo_FolioName = default;
string outParamErrorMsg = default;
lcoFolioCreate result = new lcoFolioCreate();
lcvFolioCreate localVars = new lcvFolioCreate(inParamI_SelectedLines, inParamI_OrderMainId, inParamI_FirstApprovalId, inParamI_Comments, inParamInvoiceExtended, inParamFilesListExtra, inParamFilesList, inParamInvoiceId, inParamInvoiceForeignToCreate, inParamApprovalProcessTypeId, inParamConstructionData, inParamApprovalProcessId, inParami_SummaryRec, inParami_IsMassCreate, inParami_MinuteSelected, inParami_OrderAccConceptID, inParamCreditNoteFilesList, inParamImportAnticipo, inParamIsNational, inParamOffsetUtc);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("FolioCreate", "5287e67b-9bff-4876-8740-efe041dbf4cf"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("FolioCreate", "5287e67b-9bff-4876-8740-efe041dbf4cf", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// GetSettingsMargins
(localVars.resGetSettingsMargins.outParamNationalMargin,localVars.resGetSettingsMargins.outParamForeignMargin) = await Actions.ActionGetSettingsMargins(requestContext,cancellationToken);

// Query datasetGetOrder
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrder_maxRecords = 0;
int datasetGetOrder_startIndex = 0;(localVars.queryResGetOrder_outParamList,localVars.queryResGetOrder_outParamCount) = await FuncActionFolioCreate.datasetGetOrder(requestContext,datasetGetOrder_maxRecords,datasetGetOrder_startIndex,IterationMultiplicity.Never,localVars.inParamI_OrderMainId,cancellationToken);

if((!((localVars.inParami_IsMassCreate||(localVars.inParamApprovalProcessTypeId==1))))) {
if(((((localVars.inParamIsNational) ? ((((localVars.queryResGetOrder_outParamList.CurrentRec.ssENOrderMain.ssCurrencyId=="MXN")) ? ((((localVars.resGetSettingsMargins.outParamNationalMargin==(((decimal)(-1))))) ? (false) : ((!((localVars.inParami_SummaryRec.ssInvoicingAmount>=(localVars.inParamInvoiceExtended.ssSubtotal-localVars.resGetSettingsMargins.outParamNationalMargin))&&(localVars.inParami_SummaryRec.ssInvoicingAmount<=(localVars.inParamInvoiceExtended.ssSubtotal+localVars.resGetSettingsMargins.outParamNationalMargin))))))) : ((((localVars.resGetSettingsMargins.outParamForeignMargin==(((decimal)(-1))))) ? (false) : ((!((localVars.inParami_SummaryRec.ssInvoicingAmount>=(localVars.inParamInvoiceExtended.ssSubtotal-localVars.resGetSettingsMargins.outParamForeignMargin))&&(localVars.inParami_SummaryRec.ssInvoicingAmount<=(localVars.inParamInvoiceExtended.ssSubtotal+localVars.resGetSettingsMargins.outParamForeignMargin))))))))) : ((((localVars.queryResGetOrder_outParamList.CurrentRec.ssENOrderMain.ssCurrencyId=="MXN")) ? ((((localVars.resGetSettingsMargins.outParamNationalMargin==(((decimal)(-1))))) ? (false) : ((!((localVars.inParami_SummaryRec.ssInvoicingAmount>=(BuiltInFunction.TextToDecimal (localVars.inParamInvoiceForeignToCreate.ssTotalAmount)-localVars.resGetSettingsMargins.outParamNationalMargin))&&(localVars.inParami_SummaryRec.ssInvoicingAmount<=(BuiltInFunction.TextToDecimal (localVars.inParamInvoiceForeignToCreate.ssTotalAmount)+localVars.resGetSettingsMargins.outParamNationalMargin))))))) : ((((localVars.resGetSettingsMargins.outParamForeignMargin==(((decimal)(-1))))) ? (false) : ((!((localVars.inParami_SummaryRec.ssInvoicingAmount>=(BuiltInFunction.TextToDecimal (localVars.inParamInvoiceForeignToCreate.ssTotalAmount)-localVars.resGetSettingsMargins.outParamForeignMargin))&&(localVars.inParami_SummaryRec.ssInvoicingAmount<=(BuiltInFunction.TextToDecimal (localVars.inParamInvoiceForeignToCreate.ssTotalAmount)+localVars.resGetSettingsMargins.outParamForeignMargin))))))))))&&((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveXMLValidation_Amount])))))) {
// ErrorMsg = "Amounts are not correct."
result.outParamErrorMsg=AppUtils.GetStringResource("1KLVC1gQnUCp6q5KWEeEkA#Value.704657538.1", "Amounts are not correct.");
goto RETURN_STATEMENT;

}

}

// Foreach I_SelectedLines
localVars.inParamI_SelectedLines.StartIteration();
try {while (!((localVars.inParamI_SelectedLines.Eof))) {
// Query QueryGetOrdersItems
cancellationToken.ThrowIfCancellationRequested();
int QueryGetOrdersItems_maxRecords = 999999999;
if (QueryGetOrdersItems_maxRecords < 1) QueryGetOrdersItems_maxRecords = 1;
int QueryGetOrdersItems_startIndex = 0;(localVars.queryResGetOrdersItems_outParamList,localVars.queryResGetOrdersItems_outParamCount) = await FuncActionFolioCreate.QueryGetOrdersItems(requestContext,QueryGetOrdersItems_maxRecords,QueryGetOrdersItems_startIndex,IterationMultiplicity.Never,localVars.inParamI_SelectedLines.CurrentRec.ssOrderMainId,(ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("cklscJNc0UyOgKXGwg51TQ"))).ssId,(ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("l5OG661dZEe+gAZwnNLhSA"))).ssId,cancellationToken);

if(((localVars.inParamI_SelectedLines.CurrentRec.ssInvoiceQtt>localVars.queryResGetOrdersItems_outParamList.CurrentRec.ssSTDecimal.ssValue))) {
// RaiseError FileInvalid
throw new Ex_FileInvalidUserException (((((AppUtils.GetStringResource("UNjL9U5WikOmjCQls9cHgw#Message.2031416474.1", "The folio could not be created. The amount entered is greater than the available amount.")+" ")+BuiltInFunction.DecimalToText(localVars.inParamI_SelectedLines.CurrentRec.ssInvoiceQtt))+" >")+BuiltInFunction.DecimalToText(localVars.queryResGetOrdersItems_outParamList.CurrentRec.ssSTDecimal.ssValue)));

}

localVars.inParamI_SelectedLines.Advance();
}

} finally {
localVars.inParamI_SelectedLines.EndIteration();
}

// Query datasetGetFolioRegionSeqsByRegionId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioRegionSeqsByRegionId_maxRecords = 0;
int datasetGetFolioRegionSeqsByRegionId_startIndex = 0;(localVars.queryResGetFolioRegionSeqsByRegionId_outParamList,localVars.queryResGetFolioRegionSeqsByRegionId_outParamCount) = await FuncActionFolioCreate.datasetGetFolioRegionSeqsByRegionId(requestContext,datasetGetFolioRegionSeqsByRegionId_maxRecords,datasetGetFolioRegionSeqsByRegionId_startIndex,IterationMultiplicity.Never,localVars.queryResGetOrder_outParamList.CurrentRec.ssENOrderMain.ssRegionId,cancellationToken);

// new?
if((localVars.queryResGetFolioRegionSeqsByRegionId_outParamList.Empty)) {
// CreateFolioRegionSeq
localVars.resCreateFolioRegionSeq_outParamId = await ExtendedActions.CreateFolioRegionSeq(requestContext,new RC_ba02c963eabdf75d57d498152c3db2fa(){ ssENFolioRegionSeq = new EN_6d30d3f082837359d34a81528b515a59EntityRecord(){ ssRegionId = localVars.queryResGetOrder_outParamList.CurrentRec.ssENOrderMain.ssRegionId, ssSeqValue = 1 } },cancellationToken);

}

// GetFolioName
localVars.resGetFolioName.outParamFolioNumber = await Actions.ActionGetFolioName(requestContext,localVars.queryResGetOrder_outParamList.CurrentRec.ssENOrderMain.ssRegionId,cancellationToken);

// Foreach I_SelectedLines
localVars.inParamI_SelectedLines.StartIteration();
try {while (!((localVars.inParamI_SelectedLines.Eof))) {
// SetTotalPrice
// I_SelectedLines.Current.TotalPrice = I_SelectedLines.Current.InvoiceQtt * I_SelectedLines.Current.UnitPrice / I_SelectedLines.Current.BaseQuantity
localVars.inParamI_SelectedLines.CurrentRec.ssTotalPrice = (localVars.inParamI_SelectedLines.CurrentRec.ssInvoiceQtt*((decimal)localVars.inParamI_SelectedLines.CurrentRec.ssUnitPrice/
(decimal)(((decimal)localVars.inParamI_SelectedLines.CurrentRec.ssBaseQuantity))));
// TotalAmount = TotalAmount + I_SelectedLines.Current.TotalPrice
localVars.varLcTotalAmount=(localVars.varLcTotalAmount+localVars.inParamI_SelectedLines.CurrentRec.ssTotalPrice);

// TotalAmountIva = TotalAmountIva + I_SelectedLines.Current.TotalPrice * I_SelectedLines.Current.VatRate
localVars.varLcTotalAmountIva=(localVars.varLcTotalAmountIva+(localVars.inParamI_SelectedLines.CurrentRec.ssTotalPrice*localVars.inParamI_SelectedLines.CurrentRec.ssVatRate));
localVars.inParamI_SelectedLines.Advance();
}

} finally {
localVars.inParamI_SelectedLines.EndIteration();
}

// Folio.FolioNumber = GetFolioName.FolioNumber
localVars.varLcFolio.ssFolioNumber = localVars.resGetFolioName.outParamFolioNumber;

// Folio.Id = NullIdentifier
localVars.varLcFolio.ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ());

// Folio.IsDraft = False
localVars.varLcFolio.ssIsDraft = false;

// Folio.OrderId = I_OrderMainId
localVars.varLcFolio.ssOrderId = localVars.inParamI_OrderMainId;

// Folio.SupplierId = GetUserSupplier()
localVars.varLcFolio.ssSupplierId = (await Functions.ActionGetUserSupplier(requestContext,"",cancellationToken));

// Folio.CompanyId = GetOrder.List.Current.OrderMain.CompanyId
localVars.varLcFolio.ssCompanyId = localVars.queryResGetOrder_outParamList.CurrentRec.ssENOrderMain.ssCompanyId;

// Folio.FolioStatusId = PendingApproval
localVars.varLcFolio.ssFolioStatusId = (ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("OLAtbBHfEkWbS1oUJ_NMaQ"))).ssId;

// Folio.TotalAmount = TextToDecimal
localVars.varLcFolio.ssTotalAmount = BuiltInFunction.TextToDecimal (BuiltInFunction.FormatDecimal (localVars.varLcTotalAmount, 2, ".", ""));

// Folio.CurrencyId = GetOrder.List.Current.OrderMain.CurrencyId
localVars.varLcFolio.ssCurrencyId = localVars.queryResGetOrder_outParamList.CurrentRec.ssENOrderMain.ssCurrencyId;

// Folio.CreatedBy = GetUserId
localVars.varLcFolio.ssCreatedBy = BuiltInFunction.GetUserId ();

// Folio.CreatedOn = CurrDateTime
localVars.varLcFolio.ssCreatedOn = BuiltInFunction.CurrDateTime ();

// Folio.TotalIVA_Amount = TextToDecimal
localVars.varLcFolio.ssTotalIVA_Amount = BuiltInFunction.TextToDecimal (BuiltInFunction.FormatDecimal (localVars.varLcTotalAmountIva, 2, ".", ""));

// Folio.FirstApproverUserId = I_FirstApprovalId
localVars.varLcFolio.ssFirstApproverUserId = localVars.inParamI_FirstApprovalId;

// Folio.CanProveedorCancel = True
localVars.varLcFolio.ssCanProveedorCancel = true;

// Folio.ApprovalProcessTypeId = ApprovalProcessTypeId
localVars.varLcFolio.ssApprovalProcessTypeId = localVars.inParamApprovalProcessTypeId;

// Folio.PartialAmount = i_SummaryRec.PartialDeliveryAmount
localVars.varLcFolio.ssPartialAmount = localVars.inParami_SummaryRec.ssPartialDeliveryAmount;

// Folio.MinuteSelected = i_MinuteSelected
localVars.varLcFolio.ssMinuteSelected = localVars.inParami_MinuteSelected;
// CreateFolio
localVars.resCreateFolio_outParamId = await ExtendedActions.CreateFolio(requestContext,(((RC_cfeb2cf80ab683e7d9a9b5d02d9c9526)localVars.varLcFolio)),cancellationToken);

// OrderLogAdd
localVars.resOrderLogAdd.outParamId = await Actions.ActionOrderLogAdd(requestContext,new EN_a8e484428097204171df8a1feecb2534EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssOrderId = localVars.inParamI_OrderMainId, ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssMessage = ((AppUtils.GetStringResource("oI0hHtbyikiZYTYzGZe2Cg#Value.1686549394.1", "The supplier created the folio number: ")+" ")+localVars.resGetFolioName.outParamFolioNumber) },cancellationToken);

// FolioLogAdd
localVars.resFolioLogAdd.outParamId = await Actions.ActionFolioLogAdd(requestContext,new EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssFolioId = localVars.resCreateFolio_outParamId, ssMessage = ((AppUtils.GetStringResource("AVc3yI9P1U2nESIh2RMwcw#Value.1686549394.1", "The supplier created the folio number: ")+" ")+localVars.resGetFolioName.outParamFolioNumber), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssIsForSupplier = true },cancellationToken);

if(((BuiltInFunction.Trim (localVars.inParamI_Comments)!=""))) {
// CreateFolioObservations
localVars.resCreateFolioObservations_outParamId = await ExtendedActions.CreateFolioObservations(requestContext,new RC_017cba02e4fd7f684606081b7269a26b(){ ssENFolioObservations = new EN_171b22187ea6e4b12c9f086502740307EntityRecord(){ ssFolioId = localVars.resCreateFolio_outParamId, ssObservation = localVars.inParamI_Comments, ssCreatedBy = localVars.varLcFolio.ssCreatedBy, ssCreatedOn = localVars.varLcFolio.ssCreatedOn } },cancellationToken);

}

// Foreach I_SelectedLines
localVars.inParamI_SelectedLines.StartIteration();
try {while (!((localVars.inParamI_SelectedLines.Eof))) {
// CreateFolioItems
localVars.resCreateFolioItems_outParamId = await ExtendedActions.CreateFolioItems(requestContext,new RC_f861f2b559524d098e0981156af9b7ab(){ ssENFolioItems = new EN_868430b5192a8eb1a739e01247fc2704EntityRecord(){ ssFolioId = localVars.resCreateFolio_outParamId, ssOrderMainItemId = localVars.inParamI_SelectedLines.CurrentRec.ssOrderMainId, ssOrderNumber = localVars.inParamI_SelectedLines.CurrentRec.ssOrderNumber, ssArticleNumber = localVars.inParamI_SelectedLines.CurrentRec.ssArticleNumber, ssDescription = localVars.inParamI_SelectedLines.CurrentRec.ssDescription, ssInputationCode = localVars.inParamI_SelectedLines.CurrentRec.ssInputationCode, ssDeliveryDate = localVars.inParamI_SelectedLines.CurrentRec.ssDeliveryDate, ssInvoiceQtt = localVars.inParamI_SelectedLines.CurrentRec.ssInvoiceQtt, ssRemainingQtt = localVars.inParamI_SelectedLines.CurrentRec.ssRemainingQtt, ssUnitPrice = localVars.inParamI_SelectedLines.CurrentRec.ssUnitPrice, ssTotalPrice = ((decimal)(localVars.inParamI_SelectedLines.CurrentRec.ssInvoiceQtt*localVars.inParamI_SelectedLines.CurrentRec.ssUnitPrice)/
(decimal)(((decimal)localVars.inParamI_SelectedLines.CurrentRec.ssBaseQuantity))), ssQuantity = localVars.inParamI_SelectedLines.CurrentRec.ssQuantity, ssDeliveryQtt = localVars.inParamI_SelectedLines.CurrentRec.ssDeliveryQtt, ssImportdelivery = BuiltInFunction.DecimalToText(localVars.inParamI_SelectedLines.CurrentRec.ssImportdelivery), ssPEP = localVars.inParamI_SelectedLines.CurrentRec.ssPEP, ssPlaceId = localVars.inParamI_SelectedLines.CurrentRec.ssPlaceId, ssPlaceName = localVars.inParamI_SelectedLines.CurrentRec.ssPlaceName } },cancellationToken);

localVars.inParamI_SelectedLines.Advance();
}

} finally {
localVars.inParamI_SelectedLines.EndIteration();
}

// o_FolioName = GetFolioName.FolioNumber
result.outParamo_FolioName=localVars.resGetFolioName.outParamFolioNumber;
// Is construction
if(((localVars.inParamApprovalProcessTypeId==1))) {
// Foreach FilesListExtra
localVars.inParamFilesListExtra.StartIteration();
try {while (!((localVars.inParamFilesListExtra.Eof))) {
// ServiceStorageCreateOrUpdateBigFile
localVars.resServiceStorageCreateOrUpdateBigFile_outParamId = await ServiceAPIs.ServiceAPIServiceStorageCreateOrUpdateBigFile(requestContext,new EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssConcept = localVars.resGetFolioName.outParamFolioNumber, ssInternalConceptId = 1, ssFile = BuiltInFunction.NullBinary (), ssFilename = localVars.inParamFilesListExtra.CurrentRec.ssName, ssVendor = localVars.queryResGetOrder_outParamList.CurrentRec.ssENSupplier.ssNumber, ssDoc_Type = (((BuiltInFunction.IndexSC (BuiltInFunction.ToLower (localVars.inParamFilesListExtra.CurrentRec.ssName), ".pdf", 0, false, false)!=(-1))) ? (((((string)AppUtils.SiteProperties[SitePropertiesModel.spInvoiceWithNoContractPDF])))) : ((((BuiltInFunction.IndexSC (BuiltInFunction.ToLower (localVars.inParamFilesListExtra.CurrentRec.ssName), ".xml", 0, false, false)!=(-1))) ? (((((string)AppUtils.SiteProperties[SitePropertiesModel.spInvoiceWithNoContractXML])))) : (((((string)AppUtils.SiteProperties[SitePropertiesModel.spInvoiceWithNoContractOther]))))))), ssObject_type = ((((string)AppUtils.SiteProperties[SitePropertiesModel.spInvoiceWithNoContractTable]))), ssIstoSendToExternal = true },false,localVars.inParamFilesListExtra.CurrentRec.ssFileId,cancellationToken);

// CreateFolioFiles
localVars.resCreateFolioFiles_outParamId = await ExtendedActions.CreateFolioFiles(requestContext,new RC_28fdb7a8aef891dc921c5fe34393a569(){ ssENFolioFiles = new EN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord(){ ssFilename = localVars.inParamFilesListExtra.CurrentRec.ssName, ssFolioId = localVars.resCreateFolio_outParamId, ssIsExtra = true, ssStorageId = localVars.resServiceStorageCreateOrUpdateBigFile_outParamId, ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime () } },cancellationToken);

localVars.inParamFilesListExtra.Advance();
}

} finally {
localVars.inParamFilesListExtra.EndIteration();
}

} else {
// UploadInvoiceFiles_WithCN
(localVars.resUploadInvoiceFiles_WithCN.outParamErrorMsg,localVars.resUploadInvoiceFiles_WithCN.outParamo_Invoice,localVars.resUploadInvoiceFiles_WithCN.outParamo_InvoiceExtended,localVars.resUploadInvoiceFiles_WithCN.outParamClaveProdServ,localVars.resUploadInvoiceFiles_WithCN.outParamTipoComprobante,localVars.resUploadInvoiceFiles_WithCN.outParamIsMissingCreditNote) = await Actions.ActionUploadInvoiceFiles_WithCN(requestContext,localVars.inParamInvoiceId,Convert.ToInt64(BuiltInFunction.NullIdentifier ()),localVars.inParamI_OrderMainId,localVars.resCreateFolio_outParamId,(await RL_7b4ceb84b6a1255d3a42c8932279bc3c.ConvertAsync(localVars.inParamFilesList, new RL_7b4ceb84b6a1255d3a42c8932279bc3c(), async (ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure source, ST_7837994e68174a4794f15e4233b48555Structure target, CancellationToken cancellationToken) => {
target.ssName = source.ssName;
target.ssBinaryData = source.ssBinaryData;
target.ssFileId = source.ssFileId;
return target;
}, cancellationToken)),(await RL_7b4ceb84b6a1255d3a42c8932279bc3c.ConvertAsync(localVars.inParamFilesListExtra, new RL_7b4ceb84b6a1255d3a42c8932279bc3c(), async (ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure source, ST_7837994e68174a4794f15e4233b48555Structure target, CancellationToken cancellationToken) => {
target.ssName = source.ssName;
target.ssBinaryData = source.ssBinaryData;
target.ssFileId = source.ssFileId;
return target;
}, cancellationToken)),(await RL_7b4ceb84b6a1255d3a42c8932279bc3c.ConvertAsync(localVars.inParamCreditNoteFilesList, new RL_7b4ceb84b6a1255d3a42c8932279bc3c(), async (ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure source, ST_7837994e68174a4794f15e4233b48555Structure target, CancellationToken cancellationToken) => {
target.ssName = source.ssName;
target.ssBinaryData = source.ssBinaryData;
target.ssFileId = source.ssFileId;
return target;
}, cancellationToken)),false,localVars.inParamInvoiceForeignToCreate,(((decimal)0)),false,false,0,localVars.inParami_OrderAccConceptID,localVars.inParamImportAnticipo,0L,localVars.inParamOffsetUtc,false,cancellationToken);

// error?
if(((localVars.resUploadInvoiceFiles_WithCN.outParamErrorMsg!=""))) {
// ErrorMsg = UploadInvoiceFiles_WithCN.ErrorMsg
result.outParamErrorMsg=localVars.resUploadInvoiceFiles_WithCN.outParamErrorMsg;
// RaiseError FileInvalid
throw new Ex_FileInvalidUserException (localVars.resUploadInvoiceFiles_WithCN.outParamErrorMsg);

} else {
// ErrorMsg = UploadInvoiceFiles_WithCN.ErrorMsg
result.outParamErrorMsg=localVars.resUploadInvoiceFiles_WithCN.outParamErrorMsg;
}

}

// Is Construction
if(((localVars.inParamApprovalProcessTypeId==1))) {
if((!(localVars.inParamConstructionData.ssNA))) {
// CreateFolioExtended
localVars.resCreateFolioExtended_outParamId = await ExtendedActions.CreateFolioExtended(requestContext,(await RecordUtils.ConvertAsync(localVars.inParamConstructionData, new RC_ad92b2c217228db10c71baf90a615ea5(), async (RC_1c2482ce6cd4b83ca44ec0510b231d44 source, RC_ad92b2c217228db10c71baf90a615ea5 target, CancellationToken cancellationToken) => {
target.ssENFolioExtended.ssId = localVars.resCreateFolio_outParamId;
target.ssENFolioExtended.ssIsAdvPayment = source.ssAdvPayment;
target.ssENFolioExtended.ssAdvPaymentValue = source.ssAdvPaymentValue;
target.ssENFolioExtended.ssIsCreditNote = source.ssCreditNote;
target.ssENFolioExtended.ssCreditNoteValue = source.ssCreditNoteValue;
target.ssENFolioExtended.ssIsVoucher = source.ssVoucher;
target.ssENFolioExtended.ssVoucherValue = source.ssVoucherValue;
target.ssENFolioExtended.ssIsNa = source.ssNA;
return target;
}, cancellationToken)),cancellationToken);

}

}

// InitFolioWF
localVars.resInitFolioWF.outParamo_Output = await Actions.ActionInitFolioWF(requestContext,localVars.resCreateFolio_outParamId,localVars.inParamApprovalProcessId,localVars.inParamApprovalProcessTypeId,cancellationToken);

if((!(localVars.resInitFolioWF.outParamo_Output.ssIsSuccess))) {
// RaiseError FileInvalid
throw new Ex_FileInvalidUserException (localVars.resInitFolioWF.outParamo_Output.ssMessage);

}

} //close CreateActionActivity using block
} // try

catch (Ex_FileInvalidUserException ex) {
ApplicationLogger.Error(ex, "Error executing action");
requestContext.LastException = ex;

// Error Handler
await DatabaseAccess.RollbackAllTransactionsAsync(cancellationToken);

// ErrorMsg = FileInvalid.ExceptionMessage
result.outParamErrorMsg=ex.Message;
goto RETURN_STATEMENT;

} // Catch
finally {
outParamo_FolioName = result.outParamo_FolioName;
outParamErrorMsg = result.outParamErrorMsg;
cancellationToken.ThrowIfCancellationRequested();
} // inner-finally
RETURN_STATEMENT:
return (outParamo_FolioName,outParamErrorMsg);
}

public static class FuncActionFolioCreate {

// Query Function "GetFolioRegionSeqsByRegionId" URc+qAmyM0GVGkeMPvM4hg of Action "FolioCreate"
public static async Task<(RL_321dd0d04a3c06ceeabbe51d5902cdbf,long)> datasetGetFolioRegionSeqsByRegionId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRegionId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("FolioCreate.GetFolioRegionSeqsByRegionId", "a83e1751-b209-4133-951a-478c3ef33886");
using var queryActivity = activitySource.CreateAggregateQueryActivity("FolioCreate.GetFolioRegionSeqsByRegionId", "a83e1751-b209-4133-951a-478c3ef33886", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.e+aHUv+bdkiHQO_gQdv0zw/NodesNotShownInESpaceTree.URc+qAmyM0GVGkeMPvM4hg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2");
fromBuilder.Append(" FROM {FolioRegionSeq} \"enfolioregionseq\"");
whereBuilder.Append(" WHERE ");
if (qpreRegionId != 0) {
whereBuilder.Append("((\"enfolioregionseq\".\"regionid\" = @qpreRegionId) AND (\"enfolioregionseq\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRegionId", DbType.Int64, qpreRegionId);
} else {
whereBuilder.Append("(\"enfolioregionseq\".\"regionid\" IS NULL)");
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
RL_321dd0d04a3c06ceeabbe51d5902cdbf outParamList = new RL_321dd0d04a3c06ceeabbe51d5902cdbf();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query FolioCreate.GetFolioRegionSeqsByRegionId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_321dd0d04a3c06ceeabbe51d5902cdbf _tmp = new RL_321dd0d04a3c06ceeabbe51d5902cdbf();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query FolioCreate.GetFolioRegionSeqsByRegionId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_321dd0d04a3c06ceeabbe51d5902cdbf)_tmp;
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

// Query Function "GetOrdersItems" X9KCq_dMbUWJ_7FNfbyzog of Action "FolioCreate"
public static async Task<(RL_0b8b481397d3c2af696e2a2d3956b721,long)> QueryGetOrdersItems(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporl_OrderIdSelected,int qpfoi_folioStatusIdCanceled,int qpfoi_folioStatusIdCanceledByProvider,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("FolioCreate.GetOrdersItems", "ab82d25f-4cf7-456d-89ff-b14d7dbcb3a2");
using var queryActivity = activitySource.CreateSqlQueryActivity("FolioCreate.GetOrdersItems", "ab82d25f-4cf7-456d-89ff-b14d7dbcb3a2", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string entityOrderMainItem = AppUtils.Instance.RuntimeEntityReplace("OrderMainItem");
string entityFolioItems = AppUtils.Instance.RuntimeEntityReplace("FolioItems");
string entityFolio = AppUtils.Instance.RuntimeEntityReplace("Folio");
string entityOrderItemEntries = AppUtils.Instance.RuntimeEntityReplace("OrderItemEntries");
sqlCmd.CreateParameter("@qpfoi_folioStatusIdCanceled", DbType.Int32, qpfoi_folioStatusIdCanceled);
sqlCmd.CreateParameter("@qpfoi_folioStatusIdCanceledByProvider", DbType.Int32, qpfoi_folioStatusIdCanceledByProvider);
sqlCmd.CreateParameter("@qporl_OrderIdSelected", DbType.Int64, qporl_OrderIdSelected);
string sql = "";
string advSql = "SELECT  \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"quantity\"") + " - ( \n        COALESCE(( \n            SELECT SUM(CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"invoiceqtt\"") + " AS DECIMAL(18,3))) \n            FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,"") + " \n            INNER JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"folioid\"") + " \n            WHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"ordermainitemid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".Id") + " \n            AND ( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"foliostatusid\"") + " <> @qpfoi_folioStatusIdCanceled  \n            AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"foliostatusid\"") + " <> @qpfoi_folioStatusIdCanceledByProvider) \n        ), 0)  +  COALESCE(( \n            SELECT SUM(CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"quantity_\"") + " AS DECIMAL(18,3))) \n            FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,"") + " \n            WHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"ordermainitemid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".Id") + " \n            AND ( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"quantity_\"") + " > 0 \n            OR ( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"rejectfolio\"") + " = 0 AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"quantity_\"") + " < 0)) \n        ), 0) \n    ) AS QttAvailable \n \nFROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,"") + " \nWHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"id\"") + " = @qporl_OrderIdSelected \nand  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"isblocked\"") + " = 0  \nand  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"isdeleted\"") + " = 0";
sql = advSql;
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_0b8b481397d3c2af696e2a2d3956b721 outParamList = new RL_0b8b481397d3c2af696e2a2d3956b721();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query FolioCreate.GetOrdersItems.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_0b8b481397d3c2af696e2a2d3956b721 _tmp = new RL_0b8b481397d3c2af696e2a2d3956b721();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query FolioCreate.GetOrdersItems.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_0b8b481397d3c2af696e2a2d3956b721)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetOrdersItems in FolioCreate in ConectaProveedores (SELECT       {OrderMainItem}.[Quantity] - (          COALESCE((              SELECT SUM(CAST({FolioItems}.[InvoiceQtt] AS DECIMAL(18,3)))              FROM {FolioItems}              INNER JOIN {Folio} ON {Folio}.[Id] = {FolioItems}.[FolioId]              WHERE {FolioItems}.[OrderMainItemId] = {OrderMainItem}.Id              AND ({Folio}.[FolioStatusId] <> @i_folioStatusIdCanceled               AND {Folio}.[FolioStatusId] <> @i_folioStatusIdCanceledByProvider)          ), 0)  +  COALESCE((              SELECT SUM(CAST({OrderItemEntries}.[Quantity_] AS DECIMAL(18,3)))              FROM {OrderItemEntries}              WHERE {OrderItemEntries}.[OrderMainItemid] = {OrderMainItem}.Id              AND ({OrderItemEntries}.[Quantity_] > 0              OR ({OrderItemEntries}.[RejectFolio] = 0 AND {OrderItemEntries}.[Quantity_] < 0))          ), 0)      ) AS QttAvailable    FROM {OrderMainItem}  WHERE {OrderMainItem}.[Id] = @l_OrderIdSelected  and {OrderMainItem}.[IsBlocked] = 0   and {OrderMainI ...): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetOrdersItems in FolioCreate in ConectaProveedores (SELECT       {OrderMainItem}.[Quantity] - (          COALESCE((              SELECT SUM(CAST({FolioItems}.[InvoiceQtt] AS DECIMAL(18,3)))              FROM {FolioItems}              INNER JOIN {Folio} ON {Folio}.[Id] = {FolioItems}.[FolioId]              WHERE {FolioItems}.[OrderMainItemId] = {OrderMainItem}.Id              AND ({Folio}.[FolioStatusId] <> @i_folioStatusIdCanceled               AND {Folio}.[FolioStatusId] <> @i_folioStatusIdCanceledByProvider)          ), 0)  +  COALESCE((              SELECT SUM(CAST({OrderItemEntries}.[Quantity_] AS DECIMAL(18,3)))              FROM {OrderItemEntries}              WHERE {OrderItemEntries}.[OrderMainItemid] = {OrderMainItem}.Id              AND ({OrderItemEntries}.[Quantity_] > 0              OR ({OrderItemEntries}.[RejectFolio] = 0 AND {OrderItemEntries}.[Quantity_] < 0))          ), 0)      ) AS QttAvailable    FROM {OrderMainItem}  WHERE {OrderMainItem}.[Id] = @l_OrderIdSelected  and {OrderMainItem}.[IsBlocked] = 0   and {OrderMainI ...): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetOrdersItems in FolioCreate in ConectaProveedores (SELECT       {OrderMainItem}.[Quantity] - (          COALESCE((              SELECT SUM(CAST({FolioItems}.[InvoiceQtt] AS DECIMAL(18,3)))              FROM {FolioItems}              INNER JOIN {Folio} ON {Folio}.[Id] = {FolioItems}.[FolioId]              WHERE {FolioItems}.[OrderMainItemId] = {OrderMainItem}.Id              AND ({Folio}.[FolioStatusId] <> @i_folioStatusIdCanceled               AND {Folio}.[FolioStatusId] <> @i_folioStatusIdCanceledByProvider)          ), 0)  +  COALESCE((              SELECT SUM(CAST({OrderItemEntries}.[Quantity_] AS DECIMAL(18,3)))              FROM {OrderItemEntries}              WHERE {OrderItemEntries}.[OrderMainItemid] = {OrderMainItem}.Id              AND ({OrderItemEntries}.[Quantity_] > 0              OR ({OrderItemEntries}.[RejectFolio] = 0 AND {OrderItemEntries}.[Quantity_] < 0))          ), 0)      ) AS QttAvailable    FROM {OrderMainItem}  WHERE {OrderMainItem}.[Id] = @l_OrderIdSelected  and {OrderMainItem}.[IsBlocked] = 0   and {OrderMainI ...): " + aqExcep.Message));
}
}
}

private static async Task<RC_5ad46beda6daded312a458bcd914266d> datasetGetOrderReadDbAsync(RC_5ad46beda6daded312a458bcd914266d rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENOrderMain.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetOrder" qbtCtR0p00aYw2GX2K3OHg of Action "FolioCreate"
public static async Task<(RL_a5d34dadc1b2a091bffaa2b834b2d48d,long)> datasetGetOrder(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderMain_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("FolioCreate.GetOrder", "b542bba9-291d-46d3-98c3-6197d8adce1e");
using var queryActivity = activitySource.CreateAggregateQueryActivity("FolioCreate.GetOrder", "b542bba9-291d-46d3-98c3-6197d8adce1e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.e+aHUv+bdkiHQO_gQdv0zw/NodesNotShownInESpaceTree.qbtCtR0p00aYw2GX2K3OHg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, \"enordermain24\".\"companyid\" o7, NULL o8, \"enordermain24\".\"currencyid\" o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, \"enordermain24\".\"regionid\" o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, \"ensupplier13\".\"number\" o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69");
fromBuilder.Append(" FROM (({OrderMain} \"enordermain24\" Inner JOIN {Supplier} \"ensupplier13\" ON (\"enordermain24\".\"supplierid\" = \"ensupplier13\".\"id\"))  Left JOIN {Region} \"enregion18\" ON (\"enordermain24\".\"regionid\" = \"enregion18\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderMain_Id != 0) {
whereBuilder.Append("((\"enordermain24\".\"id\" = @qporOrderMain_Id) AND (\"enordermain24\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderMain_Id", DbType.Int64, qporOrderMain_Id);
} else {
whereBuilder.Append("(\"enordermain24\".\"id\" IS NULL)");
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
RL_a5d34dadc1b2a091bffaa2b834b2d48d outParamList = new RL_a5d34dadc1b2a091bffaa2b834b2d48d();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, false, true, false, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query FolioCreate.GetOrder.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_a5d34dadc1b2a091bffaa2b834b2d48d _tmp = new RL_a5d34dadc1b2a091bffaa2b834b2d48d();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query FolioCreate.GetOrder.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_a5d34dadc1b2a091bffaa2b834b2d48d)_tmp;
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
