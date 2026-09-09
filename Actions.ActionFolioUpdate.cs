namespace ssConectaProveedores;

public partial class Actions {
public class lcvFolioUpdate : VarsBag {
public long inParamFolioID;
public RL_123aa03224ec08dab8cbe26021987012 inParamI_SelectedLines;
public long inParamI_OrderMainId;
public string inParamI_Comments;
public RL_1501ee54ff868a67eff67465502ee3d9 inParamFilesListExtra;
public RL_1501ee54ff868a67eff67465502ee3d9 inParamFilesList;
public int inParamApprovalProcessTypeId;
public RC_1c2482ce6cd4b83ca44ec0510b231d44 inParamConstructionData;
public RC_45d2d2c3c5fe5caa10fa5e20326622ac inParami_SummaryRec;
public EN_d1d0320db36efbb094ad0082361435a0EntityRecord inParamInvoiceToCreate;
public ST_6f620840109ac6f721328b723ec0152cStructure inParamInvoiceForeignToCreate;
public RL_1501ee54ff868a67eff67465502ee3d9 inParamCreditNoteFilesList;
public decimal inParamImportAnticipo;
public string inParami_UpdateComment;
public bool inParami_HaveNewFiles;
public string inParami_NewFileNamesUploaded;
public int inParamOffsetUtc;
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

public RL_7b3475883ca90ad6eb7fc983e868c456 queryResGetInvoicesByFolioId_outParamList = new RL_7b3475883ca90ad6eb7fc983e868c456();
public long queryResGetInvoicesByFolioId_outParamCount = 0L;

public RL_4f8b259bdd04db22be8fb771f1ad1d4f queryResGetFolioById_outParamList = new RL_4f8b259bdd04db22be8fb771f1ad1d4f();
public long queryResGetFolioById_outParamCount = 0L;

public Actions.lcoFolioEvidenceSend resFolioEvidenceSend =  new Actions.lcoFolioEvidenceSend();
public Actions.lcoFolioLogAdd resFolioLogAdd =  new Actions.lcoFolioLogAdd();
public Actions.lcoSubstituteFolioFiles_v2 resSubstituteFolioFiles_v2 =  new Actions.lcoSubstituteFolioFiles_v2();
public long resCreateFolioItems_outParamId = 0L;

public Actions.lcoOrderLogAdd resOrderLogAdd =  new Actions.lcoOrderLogAdd();
public RL_abf5dc59037dde79c92447e12cf9bfc9 queryResGetFolioExtendedById_outParamList = new RL_abf5dc59037dde79c92447e12cf9bfc9();
public long queryResGetFolioExtendedById_outParamCount = 0L;

public RLAIItemRecordList queryResDeleteAllFolioItems_outParamList = new RLAIItemRecordList();
public long queryResDeleteAllFolioItems_outParamCount = 0L;

public long resCreateFolioObservations_outParamId = 0L;

public lcvFolioUpdate(long inParamFolioID, RL_123aa03224ec08dab8cbe26021987012 inParamI_SelectedLines, long inParamI_OrderMainId, string inParamI_Comments, RL_1501ee54ff868a67eff67465502ee3d9 inParamFilesListExtra, RL_1501ee54ff868a67eff67465502ee3d9 inParamFilesList, int inParamApprovalProcessTypeId, RC_1c2482ce6cd4b83ca44ec0510b231d44 inParamConstructionData, RC_45d2d2c3c5fe5caa10fa5e20326622ac inParami_SummaryRec, EN_d1d0320db36efbb094ad0082361435a0EntityRecord inParamInvoiceToCreate, ST_6f620840109ac6f721328b723ec0152cStructure inParamInvoiceForeignToCreate, RL_1501ee54ff868a67eff67465502ee3d9 inParamCreditNoteFilesList, decimal inParamImportAnticipo, string inParami_UpdateComment, bool inParami_HaveNewFiles, string inParami_NewFileNamesUploaded, int inParamOffsetUtc) {
this.inParamFolioID = inParamFolioID;
this.inParamI_SelectedLines = inParamI_SelectedLines;
this.inParamI_OrderMainId = inParamI_OrderMainId;
this.inParamI_Comments = inParamI_Comments;
this.inParamFilesListExtra = inParamFilesListExtra;
this.inParamFilesList = inParamFilesList;
this.inParamApprovalProcessTypeId = inParamApprovalProcessTypeId;
this.inParamConstructionData = inParamConstructionData;
this.inParami_SummaryRec = inParami_SummaryRec;
this.inParamInvoiceToCreate = inParamInvoiceToCreate;
this.inParamInvoiceForeignToCreate = inParamInvoiceForeignToCreate;
this.inParamCreditNoteFilesList = inParamCreditNoteFilesList;
this.inParamImportAnticipo = inParamImportAnticipo;
this.inParami_UpdateComment = inParami_UpdateComment;
this.inParami_HaveNewFiles = inParami_HaveNewFiles;
this.inParami_NewFileNamesUploaded = inParami_NewFileNamesUploaded;
this.inParamOffsetUtc = inParamOffsetUtc;
}
}
public class lcoFolioUpdate : VarsBag {
public string outParamo_FolioName = "";

public string outParamErrorMsg = "";

public lcoFolioUpdate() {
}
}
/// <summary>
/// Action <code>FolioUpdate</code> that represents the Service Studio action <code>FolioUpdate</code>
///  <p> Description: </p>
/// </summary>
public static async Task<(string,string)> ActionFolioUpdate(IRequestContext requestContext,long inParamFolioID,RL_123aa03224ec08dab8cbe26021987012 inParamI_SelectedLines,long inParamI_OrderMainId,string inParamI_Comments,RL_1501ee54ff868a67eff67465502ee3d9 inParamFilesListExtra,RL_1501ee54ff868a67eff67465502ee3d9 inParamFilesList,int inParamApprovalProcessTypeId,RC_1c2482ce6cd4b83ca44ec0510b231d44 inParamConstructionData,RC_45d2d2c3c5fe5caa10fa5e20326622ac inParami_SummaryRec,EN_d1d0320db36efbb094ad0082361435a0EntityRecord inParamInvoiceToCreate,ST_6f620840109ac6f721328b723ec0152cStructure inParamInvoiceForeignToCreate,RL_1501ee54ff868a67eff67465502ee3d9 inParamCreditNoteFilesList,decimal inParamImportAnticipo,string inParami_UpdateComment,bool inParami_HaveNewFiles,string inParami_NewFileNamesUploaded,int inParamOffsetUtc,CancellationToken cancellationToken) {
string outParamo_FolioName = default;
string outParamErrorMsg = default;
lcoFolioUpdate result = new lcoFolioUpdate();
lcvFolioUpdate localVars = new lcvFolioUpdate(inParamFolioID, inParamI_SelectedLines, inParamI_OrderMainId, inParamI_Comments, inParamFilesListExtra, inParamFilesList, inParamApprovalProcessTypeId, inParamConstructionData, inParami_SummaryRec, inParamInvoiceToCreate, inParamInvoiceForeignToCreate, inParamCreditNoteFilesList, inParamImportAnticipo, inParami_UpdateComment, inParami_HaveNewFiles, inParami_NewFileNamesUploaded, inParamOffsetUtc);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("FolioUpdate", "8f2495ab-f11c-477e-89f8-efe24aa1bea3"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("FolioUpdate", "8f2495ab-f11c-477e-89f8-efe24aa1bea3", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetFolioById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioById_maxRecords = 0;
int datasetGetFolioById_startIndex = 0;(localVars.queryResGetFolioById_outParamList,localVars.queryResGetFolioById_outParamCount) = await FuncActionFolioUpdate.datasetGetFolioById(requestContext,datasetGetFolioById_maxRecords,datasetGetFolioById_startIndex,IterationMultiplicity.Never,localVars.inParamFolioID,(await Functions.ActionGetUserSupplier(requestContext,"",cancellationToken)),cancellationToken);

if((localVars.queryResGetFolioById_outParamList.Empty)) {
// RaiseError EntityException
throw new Ex_EntityExceptionUserException (AppUtils.GetStringResource("x5kr07w5606Y9koLoR0zQQ#Message.-2050112042.1", "This folio is not yours"));

} else {
if(((BuiltInFunction.Trim (localVars.inParamI_Comments)!=""))) {
// CreateFolioObservations
localVars.resCreateFolioObservations_outParamId = await ExtendedActions.CreateFolioObservations(requestContext,new RC_017cba02e4fd7f684606081b7269a26b(){ ssENFolioObservations = new EN_171b22187ea6e4b12c9f086502740307EntityRecord(){ ssFolioId = localVars.inParamFolioID, ssObservation = localVars.inParamI_Comments, ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime () } },cancellationToken);

}

// no Construction?
if(((localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssApprovalProcessTypeId!=1))) {
// Query datasetGetInvoicesByFolioId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoicesByFolioId_maxRecords = 0;
int datasetGetInvoicesByFolioId_startIndex = 0;(localVars.queryResGetInvoicesByFolioId_outParamList,localVars.queryResGetInvoicesByFolioId_outParamCount) = await FuncActionFolioUpdate.datasetGetInvoicesByFolioId(requestContext,datasetGetInvoicesByFolioId_maxRecords,datasetGetInvoicesByFolioId_startIndex,IterationMultiplicity.Never,localVars.inParamFolioID,cancellationToken);

// SubstitutoFolioFiles_v2_Extra
await Actions.ActionSubstitutoFolioFiles_v2_Extra(requestContext,localVars.inParamFolioID,localVars.inParamFilesListExtra,localVars.queryResGetInvoicesByFolioId_outParamList.CurrentRec.ssENInvoice.ssId,cancellationToken);

} else {
// Foreach I_SelectedLines
localVars.inParamI_SelectedLines.StartIteration();
try {while (!((localVars.inParamI_SelectedLines.Eof))) {
// SetTotalPrice
// I_SelectedLines.Current.TotalPrice = I_SelectedLines.Current.InvoiceQtt * I_SelectedLines.Current.UnitPrice / I_SelectedLines.Current.BaseQuantity
localVars.inParamI_SelectedLines.CurrentRec.ssTotalPrice = ((decimal)(localVars.inParamI_SelectedLines.CurrentRec.ssInvoiceQtt*localVars.inParamI_SelectedLines.CurrentRec.ssUnitPrice)/
(decimal)(((decimal)localVars.inParamI_SelectedLines.CurrentRec.ssBaseQuantity)));
// TotalAmount = TotalAmount + I_SelectedLines.Current.TotalPrice
localVars.varLcTotalAmount=(localVars.varLcTotalAmount+localVars.inParamI_SelectedLines.CurrentRec.ssTotalPrice);

// TotalAmountIva = TotalAmountIva + I_SelectedLines.Current.TotalPrice * I_SelectedLines.Current.VatRate
localVars.varLcTotalAmountIva=(localVars.varLcTotalAmountIva+(localVars.inParamI_SelectedLines.CurrentRec.ssTotalPrice*localVars.inParamI_SelectedLines.CurrentRec.ssVatRate));
localVars.inParamI_SelectedLines.Advance();
}

} finally {
localVars.inParamI_SelectedLines.EndIteration();
}

// GetFolioById.List.Current.Folio.FolioStatusId = PendingApproval
localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssFolioStatusId = (ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("OLAtbBHfEkWbS1oUJ_NMaQ"))).ssId;

// GetFolioById.List.Current.Folio.TotalAmount = TextToDecimal
localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssTotalAmount = BuiltInFunction.TextToDecimal (BuiltInFunction.FormatDecimal (localVars.varLcTotalAmount, 2, ".", ""));

// GetFolioById.List.Current.Folio.UpdatedBy = GetUserId
localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssUpdatedBy = BuiltInFunction.GetUserId ();

// GetFolioById.List.Current.Folio.UpdatedOn = CurrDateTime
localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssUpdatedOn = BuiltInFunction.CurrDateTime ();

// GetFolioById.List.Current.Folio.TotalIVA_Amount = TextToDecimal
localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssTotalIVA_Amount = BuiltInFunction.TextToDecimal (BuiltInFunction.FormatDecimal (localVars.varLcTotalAmountIva, 2, ".", ""));

// GetFolioById.List.Current.Folio.CanProveedorCancel = True
localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssCanProveedorCancel = true;

// GetFolioById.List.Current.Folio.PartialAmount = i_SummaryRec.PartialDeliveryAmount
localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssPartialAmount = localVars.inParami_SummaryRec.ssPartialDeliveryAmount;
// UpdateFolio
await ExtendedActions.UpdateFolio(requestContext,localVars.queryResGetFolioById_outParamList.CurrentRec.ChangedAttributes,localVars.queryResGetFolioById_outParamList.CurrentRec,cancellationToken);

// Query QueryDeleteAllFolioItems
cancellationToken.ThrowIfCancellationRequested();
int QueryDeleteAllFolioItems_maxRecords = 0;
int QueryDeleteAllFolioItems_startIndex = 0;(localVars.queryResDeleteAllFolioItems_outParamList,localVars.queryResDeleteAllFolioItems_outParamCount) = await FuncActionFolioUpdate.QueryDeleteAllFolioItems(requestContext,QueryDeleteAllFolioItems_maxRecords,QueryDeleteAllFolioItems_startIndex,IterationMultiplicity.Never,localVars.inParamFolioID,cancellationToken);

// Foreach I_SelectedLines
localVars.inParamI_SelectedLines.StartIteration();
try {while (!((localVars.inParamI_SelectedLines.Eof))) {
// CreateFolioItems
localVars.resCreateFolioItems_outParamId = await ExtendedActions.CreateFolioItems(requestContext,new RC_f861f2b559524d098e0981156af9b7ab(){ ssENFolioItems = new EN_868430b5192a8eb1a739e01247fc2704EntityRecord(){ ssFolioId = localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssId, ssOrderMainItemId = localVars.inParamI_SelectedLines.CurrentRec.ssOrderMainId, ssOrderNumber = localVars.inParamI_SelectedLines.CurrentRec.ssOrderNumber, ssArticleNumber = localVars.inParamI_SelectedLines.CurrentRec.ssArticleNumber, ssDescription = localVars.inParamI_SelectedLines.CurrentRec.ssDescription, ssInputationCode = localVars.inParamI_SelectedLines.CurrentRec.ssInputationCode, ssDeliveryDate = localVars.inParamI_SelectedLines.CurrentRec.ssDeliveryDate, ssInvoiceQtt = localVars.inParamI_SelectedLines.CurrentRec.ssInvoiceQtt, ssRemainingQtt = localVars.inParamI_SelectedLines.CurrentRec.ssRemainingQtt, ssUnitPrice = localVars.inParamI_SelectedLines.CurrentRec.ssUnitPrice, ssTotalPrice = (localVars.inParamI_SelectedLines.CurrentRec.ssUnitPrice*localVars.inParamI_SelectedLines.CurrentRec.ssInvoiceQtt), ssQuantity = localVars.inParamI_SelectedLines.CurrentRec.ssQuantity, ssDeliveryQtt = localVars.inParamI_SelectedLines.CurrentRec.ssDeliveryQtt, ssImportdelivery = BuiltInFunction.DecimalToText(localVars.inParamI_SelectedLines.CurrentRec.ssImportdelivery), ssPEP = localVars.inParamI_SelectedLines.CurrentRec.ssPEP, ssPlaceId = localVars.inParamI_SelectedLines.CurrentRec.ssPlaceId, ssPlaceName = localVars.inParamI_SelectedLines.CurrentRec.ssPlaceName } },cancellationToken);

localVars.inParamI_SelectedLines.Advance();
}

} finally {
localVars.inParamI_SelectedLines.EndIteration();
}

// o_FolioName = GetFolioById.List.Current.Folio.FolioNumber
result.outParamo_FolioName=localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssFolioNumber;
// SubstituteFolioFiles_v2
localVars.resSubstituteFolioFiles_v2.outParamErrorMsg = await Actions.ActionSubstituteFolioFiles_v2(requestContext,localVars.inParamFolioID,(localVars.inParamApprovalProcessTypeId==1),localVars.inParamFilesList,localVars.inParamFilesListExtra,localVars.inParamCreditNoteFilesList,localVars.inParamInvoiceToCreate.ssOrderAccConceptsID,localVars.inParamInvoiceForeignToCreate,localVars.inParamImportAnticipo,localVars.inParamOffsetUtc,cancellationToken);

}

// OrderLogAdd
localVars.resOrderLogAdd.outParamId = await Actions.ActionOrderLogAdd(requestContext,new EN_a8e484428097204171df8a1feecb2534EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssOrderId = localVars.inParamI_OrderMainId, ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssMessage = ((((AppUtils.GetStringResource("irtaB3YbkUGEmFv0o72p0A#Value.-1106119175.1", "The supplier updated the folio number")+": ")+localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssFolioNumber)+".")+(((localVars.inParami_UpdateComment!="")) ? ((((" "+AppUtils.GetStringResource("irtaB3YbkUGEmFv0o72p0A#Value.-1679915457.1", "Comment"))+": ")+localVars.inParami_UpdateComment)) : (""))) },cancellationToken);

// FolioLogAdd
localVars.resFolioLogAdd.outParamId = await Actions.ActionFolioLogAdd(requestContext,new EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssFolioId = localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssId, ssMessage = (((((AppUtils.GetStringResource("fpAUSfB46kWbxvCQ2YIGvA#Value.-1106119175.1", "The supplier updated the folio number")+": ")+localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssFolioNumber)+".")+((localVars.inParami_HaveNewFiles) ? (((((" "+AppUtils.GetStringResource("fpAUSfB46kWbxvCQ2YIGvA#Value.-94572617.1", "New Files"))+": ")+localVars.inParami_NewFileNamesUploaded)+".")) : ("")))+(((localVars.inParami_UpdateComment!="")) ? (((((" "+AppUtils.GetStringResource("fpAUSfB46kWbxvCQ2YIGvA#Value.-1679915457.1", "Comment"))+": ")+localVars.inParami_UpdateComment)+".")) : (""))), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssIsForSupplier = true },cancellationToken);

// Is Construction
if(((localVars.inParamApprovalProcessTypeId==1))) {
// Query datasetGetFolioExtendedById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioExtendedById_maxRecords = 0;
int datasetGetFolioExtendedById_startIndex = 0;(localVars.queryResGetFolioExtendedById_outParamList,localVars.queryResGetFolioExtendedById_outParamCount) = await FuncActionFolioUpdate.datasetGetFolioExtendedById(requestContext,datasetGetFolioExtendedById_maxRecords,datasetGetFolioExtendedById_startIndex,IterationMultiplicity.Never,localVars.inParamFolioID,cancellationToken);

if((!(localVars.queryResGetFolioExtendedById_outParamList.Empty))) {
// DeleteFolioExtended
await ExtendedActions.DeleteFolioExtended(requestContext,localVars.inParamFolioID,cancellationToken);

if((!(localVars.inParamConstructionData.ssNA))) {
// CreateFolioExtended
localVars.resCreateFolioExtended_outParamId = await ExtendedActions.CreateFolioExtended(requestContext,(await RecordUtils.ConvertAsync(localVars.inParamConstructionData, new RC_ad92b2c217228db10c71baf90a615ea5(), async (RC_1c2482ce6cd4b83ca44ec0510b231d44 source, RC_ad92b2c217228db10c71baf90a615ea5 target, CancellationToken cancellationToken) => {
target.ssENFolioExtended.ssId = localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssId;
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

}

// FolioEvidenceSend
localVars.resFolioEvidenceSend.outParamo_Output = await Actions.ActionFolioEvidenceSend(requestContext,localVars.inParamFolioID,cancellationToken);

if((localVars.resFolioEvidenceSend.outParamo_Output.ssIsSuccess)) {
// CommitTransaction
await ExtendedActions.CommitTransaction(requestContext,cancellationToken);

} else {
// ErrorMsg = FolioEvidenceSend.o_Output.Message
result.outParamErrorMsg=localVars.resFolioEvidenceSend.outParamo_Output.ssMessage;
// RaiseError FileInvalid
throw new Ex_FileInvalidUserException (localVars.resFolioEvidenceSend.outParamo_Output.ssMessage);

}

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

public static class FuncActionFolioUpdate {

// Query Function "GetInvoicesByFolioId" 5CBYILkC30yHzGOkpGabGw of Action "FolioUpdate"
public static async Task<(RL_7b3475883ca90ad6eb7fc983e868c456,long)> datasetGetInvoicesByFolioId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolioId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("FolioUpdate.GetInvoicesByFolioId", "205820e4-02b9-4cdf-87cc-63a4a4669b1b");
using var queryActivity = activitySource.CreateAggregateQueryActivity("FolioUpdate.GetInvoicesByFolioId", "205820e4-02b9-4cdf-87cc-63a4a4669b1b", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.q5UkjxzxfkeJ+O_iSqG+ow/NodesNotShownInESpaceTree.5CBYILkC30yHzGOkpGabGw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoice38\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23");
fromBuilder.Append(" FROM {Invoice} \"eninvoice38\"");
whereBuilder.Append(" WHERE ");
if (qpfoFolioId != 0) {
whereBuilder.Append("((\"eninvoice38\".\"folioid\" = @qpfoFolioId) AND (\"eninvoice38\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioId", DbType.Int64, qpfoFolioId);
} else {
whereBuilder.Append("(\"eninvoice38\".\"folioid\" IS NULL)");
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
RL_7b3475883ca90ad6eb7fc983e868c456 outParamList = new RL_7b3475883ca90ad6eb7fc983e868c456();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query FolioUpdate.GetInvoicesByFolioId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_7b3475883ca90ad6eb7fc983e868c456 _tmp = new RL_7b3475883ca90ad6eb7fc983e868c456();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query FolioUpdate.GetInvoicesByFolioId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_7b3475883ca90ad6eb7fc983e868c456)_tmp;
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

// Query Function "GetFolioById" D4gxNBvPV0uo+vrSTM3BJA of Action "FolioUpdate"
public static async Task<(RL_4f8b259bdd04db22be8fb771f1ad1d4f,long)> datasetGetFolioById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoId,long qpsuSupplierId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("FolioUpdate.GetFolioById", "3431880f-cf1b-4b57-a8fa-fad24ccdc124");
using var queryActivity = activitySource.CreateAggregateQueryActivity("FolioUpdate.GetFolioById", "3431880f-cf1b-4b57-a8fa-fad24ccdc124", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.q5UkjxzxfkeJ+O_iSqG+ow/NodesNotShownInESpaceTree.D4gxNBvPV0uo+vrSTM3BJA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enfolio31\".\"id\" o0, NULL o1, \"enfolio31\".\"folionumber\" o2, \"enfolio31\".\"canproveedorcancel\" o3, NULL o4, NULL o5, NULL o6, \"enfolio31\".\"foliostatusid\" o7, trim_scale(\"enfolio31\".\"totalamount\"::numeric) o8, trim_scale(\"enfolio31\".\"totaliva_amount\"::numeric) o9, trim_scale(\"enfolio31\".\"partialamount\"::numeric) o10, NULL o11, NULL o12, \"enfolio31\".\"approvalprocesstypeid\" o13, NULL o14, NULL o15, NULL o16, \"enfolio31\".\"updatedby\" o17, \"enfolio31\".\"updatedon\" o18, NULL o19");
fromBuilder.Append(" FROM {Folio} \"enfolio31\"");
whereBuilder.Append(" WHERE ");
if (qpfoId != 0) {
whereBuilder.Append("((\"enfolio31\".\"id\" = @qpfoId) AND (\"enfolio31\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoId", DbType.Int64, qpfoId);
} else {
whereBuilder.Append("(\"enfolio31\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ");
if (qpsuSupplierId != 0) {
whereBuilder.Append("((\"enfolio31\".\"supplierid\" = @qpsuSupplierId) AND (\"enfolio31\".\"supplierid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuSupplierId", DbType.Int64, qpsuSupplierId);
} else {
whereBuilder.Append("(\"enfolio31\".\"supplierid\" IS NULL)");
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
RL_4f8b259bdd04db22be8fb771f1ad1d4f outParamList = new RL_4f8b259bdd04db22be8fb771f1ad1d4f();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, false, false, true, true, true, false, false, false, false, true, true, false, true, true, true, false, false, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query FolioUpdate.GetFolioById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_4f8b259bdd04db22be8fb771f1ad1d4f _tmp = new RL_4f8b259bdd04db22be8fb771f1ad1d4f();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query FolioUpdate.GetFolioById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_4f8b259bdd04db22be8fb771f1ad1d4f)_tmp;
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

// Query Function "GetFolioExtendedById" wl_noPDuYEy725t8dnUDOQ of Action "FolioUpdate"
public static async Task<(RL_abf5dc59037dde79c92447e12cf9bfc9,long)> datasetGetFolioExtendedById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("FolioUpdate.GetFolioExtendedById", "a0e75fc2-eef0-4c60-bbdb-9b7c76750339");
using var queryActivity = activitySource.CreateAggregateQueryActivity("FolioUpdate.GetFolioExtendedById", "a0e75fc2-eef0-4c60-bbdb-9b7c76750339", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.q5UkjxzxfkeJ+O_iSqG+ow/NodesNotShownInESpaceTree.wl_noPDuYEy725t8dnUDOQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7");
fromBuilder.Append(" FROM {FolioExtended} \"enfolioextended\"");
whereBuilder.Append(" WHERE ");
if (qpfoId != 0) {
whereBuilder.Append("((\"enfolioextended\".\"id\" = @qpfoId) AND (\"enfolioextended\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoId", DbType.Int64, qpfoId);
} else {
whereBuilder.Append("(\"enfolioextended\".\"id\" IS NULL)");
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
RL_abf5dc59037dde79c92447e12cf9bfc9 outParamList = new RL_abf5dc59037dde79c92447e12cf9bfc9();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query FolioUpdate.GetFolioExtendedById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_abf5dc59037dde79c92447e12cf9bfc9 _tmp = new RL_abf5dc59037dde79c92447e12cf9bfc9();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query FolioUpdate.GetFolioExtendedById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_abf5dc59037dde79c92447e12cf9bfc9)_tmp;
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

// Query Function "DeleteAllFolioItems" v0Ie24zRiES_BxmeyroCjg of Action "FolioUpdate"
public static async Task<(RLAIItemRecordList,long)> QueryDeleteAllFolioItems(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolioId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("FolioUpdate.DeleteAllFolioItems", "db1e42bf-d18c-4488-bf07-199ecaba028e");
using var queryActivity = activitySource.CreateSqlQueryActivity("FolioUpdate.DeleteAllFolioItems", "db1e42bf-d18c-4488-bf07-199ecaba028e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string entityFolioItems = AppUtils.Instance.RuntimeEntityReplace("FolioItems");
sqlCmd.CreateParameter("@qpfoFolioId", DbType.Int64, qpfoFolioId);
string sql = "";
string advSql = "delete from  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,"") + " \nwhere  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"folioid\"") + "=   @qpfoFolioId";
string[] entitiesToCheck = new[] {"FolioItems"};
AppUtils.Instance.RuntimeCheckReadOnlyEntity(entitiesToCheck);
sql = advSql;
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RLAIItemRecordList outParamList = new RLAIItemRecordList();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query FolioUpdate.DeleteAllFolioItems.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RLAIItemRecordList _tmp = new RLAIItemRecordList();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query FolioUpdate.DeleteAllFolioItems.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RLAIItemRecordList)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("DeleteAllFolioItems in FolioUpdate in ConectaProveedores (delete from {FolioItems}  where {FolioItems}.[FolioId]=   @FolioId): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("DeleteAllFolioItems in FolioUpdate in ConectaProveedores (delete from {FolioItems}  where {FolioItems}.[FolioId]=   @FolioId): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("DeleteAllFolioItems in FolioUpdate in ConectaProveedores (delete from {FolioItems}  where {FolioItems}.[FolioId]=   @FolioId): " + aqExcep.Message));
}
}
}



}


}
