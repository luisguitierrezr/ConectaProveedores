using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_c_Requisitions_Wb_RequisitionInvoices_DataActionGetRequisitionData_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("AdvWithoutInvoice")]
public bool? outParamAdvWithoutInvoice;
[JsonProperty("AllowMultiUpload")]
public bool? outParamAllowMultiUpload;
[JsonProperty("WasAdvWithoutInvoice")]
public bool? outParamWasAdvWithoutInvoice;
[JsonProperty("CostCenterSAPId")]
public long? outParamCostCenterSAPId;
[JsonProperty("CurrencyId")]
public string outParamCurrencyId;
[JsonProperty("DivisionFI")]
public string outParamDivisionFI;
[JsonProperty("Project")]
public string outParamProject;
[JsonProperty("PaymentMethodsId")]
public long? outParamPaymentMethodsId;
[JsonProperty("PaymentTermsId")]
public long? outParamPaymentTermsId;
[JsonProperty("SupplierNr")]
public string outParamSupplierNr;
[JsonProperty("TotalAmount")]
public decimal? outParamTotalAmount;


    public static RESTConectaProveedores_c_Requisitions_Wb_RequisitionInvoices_DataActionGetRequisitionData_Outputs FromOutputs(IBehaviorsConfiguration conf, bool outParamAdvWithoutInvoice, bool outParamAllowMultiUpload, bool outParamWasAdvWithoutInvoice, long outParamCostCenterSAPId, string outParamCurrencyId, string outParamDivisionFI, string outParamProject, long outParamPaymentMethodsId, long outParamPaymentTermsId, string outParamSupplierNr, decimal outParamTotalAmount) {RESTConectaProveedores_c_Requisitions_Wb_RequisitionInvoices_DataActionGetRequisitionData_Outputs result = new RESTConectaProveedores_c_Requisitions_Wb_RequisitionInvoices_DataActionGetRequisitionData_Outputs();
// Write optimized result.outParamAdvWithoutInvoice
result.outParamAdvWithoutInvoice = (bool?) false;
result.outParamAllowMultiUpload = (bool?) outParamAllowMultiUpload;
result.outParamWasAdvWithoutInvoice = (bool?) outParamWasAdvWithoutInvoice;
// Write optimized result.outParamCostCenterSAPId
result.outParamCostCenterSAPId = (long?) 0L;
// Write optimized result.outParamCurrencyId
result.outParamCurrencyId = "";
// Write optimized result.outParamDivisionFI
result.outParamDivisionFI = "";
// Write optimized result.outParamProject
result.outParamProject = "";
// Write optimized result.outParamPaymentMethodsId
result.outParamPaymentMethodsId = (long?) 0L;
// Write optimized result.outParamPaymentTermsId
result.outParamPaymentTermsId = (long?) 0L;
// Write optimized result.outParamSupplierNr
result.outParamSupplierNr = "";
// Write optimized result.outParamTotalAmount
result.outParamTotalAmount = (decimal?) 0.0M;
return result;
}


    public static ConectaProveedores_c_Requisitions_Wb_RequisitionInvoices_DataActionGetRequisitionData_Model ToModel(RESTConectaProveedores_c_Requisitions_Wb_RequisitionInvoices_DataActionGetRequisitionData_Outputs variables) {ConectaProveedores_c_Requisitions_Wb_RequisitionInvoices_DataActionGetRequisitionData_Model result = new ConectaProveedores_c_Requisitions_Wb_RequisitionInvoices_DataActionGetRequisitionData_Model();
result.outParamAdvWithoutInvoice = variables == null || variables.outParamAdvWithoutInvoice == null ? false : variables.outParamAdvWithoutInvoice.Value;
result.outParamAllowMultiUpload = variables == null || variables.outParamAllowMultiUpload == null ? false : variables.outParamAllowMultiUpload.Value;
result.outParamWasAdvWithoutInvoice = variables == null || variables.outParamWasAdvWithoutInvoice == null ? false : variables.outParamWasAdvWithoutInvoice.Value;
result.outParamCostCenterSAPId = variables == null || variables.outParamCostCenterSAPId == null ? 0L : variables.outParamCostCenterSAPId.Value;
result.outParamCurrencyId = variables == null || variables.outParamCurrencyId == null ? "" : variables.outParamCurrencyId;
result.outParamDivisionFI = variables == null || variables.outParamDivisionFI == null ? "" : variables.outParamDivisionFI;
result.outParamProject = variables == null || variables.outParamProject == null ? "" : variables.outParamProject;
result.outParamPaymentMethodsId = variables == null || variables.outParamPaymentMethodsId == null ? 0L : variables.outParamPaymentMethodsId.Value;
result.outParamPaymentTermsId = variables == null || variables.outParamPaymentTermsId == null ? 0L : variables.outParamPaymentTermsId.Value;
result.outParamSupplierNr = variables == null || variables.outParamSupplierNr == null ? "" : variables.outParamSupplierNr;
result.outParamTotalAmount = variables == null || variables.outParamTotalAmount == null ? 0.0M : variables.outParamTotalAmount.Value;
return result;
}


    public static RESTConectaProveedores_c_Requisitions_Wb_RequisitionInvoices_DataActionGetRequisitionData_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_c_Requisitions_Wb_RequisitionInvoices_DataActionGetRequisitionData_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_c_Requisitions_Wb_RequisitionInvoices_DataActionGetRequisitionData_Outputs result = new RESTConectaProveedores_c_Requisitions_Wb_RequisitionInvoices_DataActionGetRequisitionData_Outputs();
result.outParamAdvWithoutInvoice = (bool?) screenModel.outParamAdvWithoutInvoice;
result.outParamAllowMultiUpload = (bool?) screenModel.outParamAllowMultiUpload;
result.outParamWasAdvWithoutInvoice = (bool?) screenModel.outParamWasAdvWithoutInvoice;
result.outParamCostCenterSAPId = (long?) screenModel.outParamCostCenterSAPId;
result.outParamCurrencyId = screenModel.outParamCurrencyId;
result.outParamDivisionFI = screenModel.outParamDivisionFI;
result.outParamProject = screenModel.outParamProject;
result.outParamPaymentMethodsId = (long?) screenModel.outParamPaymentMethodsId;
result.outParamPaymentTermsId = (long?) screenModel.outParamPaymentTermsId;
result.outParamSupplierNr = screenModel.outParamSupplierNr;
result.outParamTotalAmount = (decimal?) screenModel.outParamTotalAmount;
return result;
}

}
