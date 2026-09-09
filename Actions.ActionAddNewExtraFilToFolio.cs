namespace ssConectaProveedores;

public partial class Actions {
public class lcvAddNewExtraFilToFolio : VarsBag {
public ST_1d6498da9105fbe815a7f766352917c0Structure inParamFile;
public EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord inParamFolio;
public string inParamSupplierNumber;
public EN_d1d0320db36efbb094ad0082361435a0EntityRecord inParamInvoice;
public long resServiceStorageCreate_outParamId = 0L;

public Actions.lcoInvoiceFileCreateOrUpdate resInvoiceFileCreateOrUpdate =  new Actions.lcoInvoiceFileCreateOrUpdate();
public lcvAddNewExtraFilToFolio(ST_1d6498da9105fbe815a7f766352917c0Structure inParamFile, EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord inParamFolio, string inParamSupplierNumber, EN_d1d0320db36efbb094ad0082361435a0EntityRecord inParamInvoice) {
this.inParamFile = inParamFile;
this.inParamFolio = inParamFolio;
this.inParamSupplierNumber = inParamSupplierNumber;
this.inParamInvoice = inParamInvoice;
}
}
/// <summary>
/// Action <code>AddNewExtraFilToFolio</code> that represents the Service Studio action
///  <code>AddNewExtraFilToFolio</code> <p> Description: </p>
/// </summary>
public static async Task ActionAddNewExtraFilToFolio(IRequestContext requestContext,ST_1d6498da9105fbe815a7f766352917c0Structure inParamFile,EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord inParamFolio,string inParamSupplierNumber,EN_d1d0320db36efbb094ad0082361435a0EntityRecord inParamInvoice,CancellationToken cancellationToken) {
lcvAddNewExtraFilToFolio localVars = new lcvAddNewExtraFilToFolio(inParamFile, inParamFolio, inParamSupplierNumber, inParamInvoice);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("AddNewExtraFilToFolio", "63201c97-c8df-4daa-8a94-71cb1aa9fbdc"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("AddNewExtraFilToFolio", "63201c97-c8df-4daa-8a94-71cb1aa9fbdc", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// ServiceStorageCreate
localVars.resServiceStorageCreate_outParamId = await ServiceAPIs.ServiceAPIServiceStorageCreate(requestContext,new EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssConcept = localVars.inParamFolio.ssFolioNumber, ssInternalConceptId = 1, ssFile = localVars.inParamFile.ssFileContent, ssFilename = localVars.inParamFile.ssFileName, ssVendor = localVars.inParamSupplierNumber, ssDoc_Type = (((BuiltInFunction.IndexSC (BuiltInFunction.ToLower (localVars.inParamFile.ssFileName), ".pdf", 0, false, false)!=(-1))) ? (((((string)AppUtils.SiteProperties[SitePropertiesModel.spInvoiceWithNoContractPDF])))) : ((((BuiltInFunction.IndexSC (BuiltInFunction.ToLower (localVars.inParamFile.ssFileName), ".xml", 0, false, false)!=(-1))) ? (((((string)AppUtils.SiteProperties[SitePropertiesModel.spInvoiceWithNoContractXML])))) : (((((string)AppUtils.SiteProperties[SitePropertiesModel.spInvoiceWithNoContractOther]))))))), ssObject_type = ((((string)AppUtils.SiteProperties[SitePropertiesModel.spInvoiceWithNoContractTable]))), ssIstoSendToExternal = true },false,cancellationToken);

// InvoiceFileCreateOrUpdate
localVars.resInvoiceFileCreateOrUpdate.outParamId = await Actions.ActionInvoiceFileCreateOrUpdate(requestContext,new EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssInvoiceId = localVars.inParamInvoice.ssId, ssFilename = localVars.inParamFile.ssFileName, ssIsExtra = true, ssIsReport = false, ssStorageId = localVars.resServiceStorageCreate_outParamId, ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime () },cancellationToken);

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionAddNewExtraFilToFolio {



}


}
