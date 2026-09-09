import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { EN_269041044ca0bb6901788ecb5d297c5eEntityRecord, EN_1b54b857d541fcb95bf570b0d963f41aEntityRecord, RC_c81aee5ce0504fe68694be6deb703b5e, RC_655f10514459daf453e41f31c05184fc, EN_4687fb2520dfeecb0ed6626cf8701229EntityRecord, RC_16678e1ac2e17d1b5db4a9a7f4681e64, EN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord, ST_c3df6a1f053620bf8d50da58ff4e41bcStructure, EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord, RC_9dc9d00c2e8dcb1797f7869ab9e5a7f9, ST_d9010d115c38fb059bccbc457fe11b18Structure } from "./ConectaProveedores.model.js";
import { EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord, EN_485b44f219737098b3b1029e90069935EntityRecord, EN_b0cf3ee36985920f2fdff1dbd2e94fb9EntityRecord, EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord, EN_f296fc330d9916f9de4aae18321e8388EntityRecord, EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord, EN_4b4c014d751d32313a045df1c34bbf8fEntityRecord, EN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord, EN_17720044fda96c0c2d8d0760c429f48aEntityRecord, EN_236be3b5d3b4417469f4bc1f0f73d781EntityRecord, EN_a6239c65aa61ed4530d18a92034301bbEntityRecord, EN_7a1403ba58c6cea2d2bf07fe0448aa32EntityRecord, EN_16f07ea11d30dfe052ad03e4a9bcc7b8EntityRecord, EN_784c408ed98e561e8741fa0e6e348ddcEntityRecord, EN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord } from "./Organization.model.js";
import { EN_327b52812b8badb247bde4975c10d441EntityRecord } from "./Common.model.js";

class GetSpecialApprovalsAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_269041044ca0bb6901788ecb5d297c5eEntityRecord, {
name: "SpecialApproval",
attrName: "specialApprovalAttr",
nameForJson: "SpecialApproval",
uniqueId: "34acf115-5396-4937-c377-a82c97a2edf5"
}))));
}
static fromStructure(str) {
return new GetSpecialApprovalsAggrRec(new GetSpecialApprovalsAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetSpecialApprovalsAggrRec.init();

class GetAccountingDataTypesAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord, {
name: "AccountingDataType",
attrName: "accountingDataTypeAttr",
nameForJson: "AccountingDataType",
uniqueId: "a222d17a-2b10-e551-d257-fa2f5892499c"
}))));
}
static fromStructure(str) {
return new GetAccountingDataTypesAggrRec(new GetAccountingDataTypesAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetAccountingDataTypesAggrRec.init();

class GetAdvancedPaymentTypesAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_485b44f219737098b3b1029e90069935EntityRecord, {
name: "AdvancePaymentType",
attrName: "advancePaymentTypeAttr",
nameForJson: "AdvancePaymentType",
uniqueId: "ba5df531-07d7-9696-b277-5256d21bdd62"
}))));
}
static fromStructure(str) {
return new GetAdvancedPaymentTypesAggrRec(new GetAdvancedPaymentTypesAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetAdvancedPaymentTypesAggrRec.init();

class GetSpecialPostDeliveryAuthorizationsAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_b0cf3ee36985920f2fdff1dbd2e94fb9EntityRecord, {
name: "SpecialPostDeliveryAuthorization",
attrName: "specialPostDeliveryAuthorizationAttr",
nameForJson: "SpecialPostDeliveryAuthorization",
uniqueId: "a18bcaa9-2353-126e-3b75-741517eabbdb"
}))));
}
static fromStructure(str) {
return new GetSpecialPostDeliveryAuthorizationsAggrRec(new GetSpecialPostDeliveryAuthorizationsAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetSpecialPostDeliveryAuthorizationsAggrRec.init();

class GetContractStatusesAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_1b54b857d541fcb95bf570b0d963f41aEntityRecord, {
name: "ContractStatus",
attrName: "contractStatusAttr",
nameForJson: "ContractStatus",
uniqueId: "64894cdb-6c46-279b-2d01-2a58a7771333"
}))));
}
static fromStructure(str) {
return new GetContractStatusesAggrRec(new GetContractStatusesAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetContractStatusesAggrRec.init();

class GetProjectAssetServiceOtroAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord, {
name: "Project_Asset_Service",
attrName: "project_Asset_ServiceAttr",
nameForJson: "Project_Asset_Service",
uniqueId: "1b08a2c1-cece-f1e3-b300-6a60b97fc68e"
}))));
}
static fromStructure(str) {
return new GetProjectAssetServiceOtroAggrRec(new GetProjectAssetServiceOtroAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetProjectAssetServiceOtroAggrRec.init();

class GetSuppliersAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_c81aee5ce0504fe68694be6deb703b5e));
}
static fromStructure(str) {
return new GetSuppliersAggrRec(new GetSuppliersAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetSuppliersAggrRec.init();

class GetBusinessValueSubcategoriesByCategoryIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_f296fc330d9916f9de4aae18321e8388EntityRecord, {
name: "BusinessValueSubcategory",
attrName: "businessValueSubcategoryAttr",
nameForJson: "BusinessValueSubcategory",
uniqueId: "87a3063e-6674-014b-4b34-5dce21ff4d84"
}))));
}
static fromStructure(str) {
return new GetBusinessValueSubcategoriesByCategoryIdAggrRec(new GetBusinessValueSubcategoriesByCategoryIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetBusinessValueSubcategoriesByCategoryIdAggrRec.init();

class GetSupplierByRequisitionAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord, {
name: "Supplier",
attrName: "supplierAttr",
nameForJson: "Supplier",
uniqueId: "4934ec74-dc6a-8063-7b84-c0985f5b12ce"
}))));
}
static fromStructure(str) {
return new GetSupplierByRequisitionAggrRec(new GetSupplierByRequisitionAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetSupplierByRequisitionAggrRec.init();

class GetOrderMainByIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_655f10514459daf453e41f31c05184fc));
}
static fromStructure(str) {
return new GetOrderMainByIdAggrRec(new GetOrderMainByIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetOrderMainByIdAggrRec.init();

class GetProjectAssetServicesAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord, {
name: "Project_Asset_Service",
attrName: "project_Asset_ServiceAttr",
nameForJson: "Project_Asset_Service",
uniqueId: "1b08a2c1-cece-f1e3-b300-6a60b97fc68e"
}))));
}
static fromStructure(str) {
return new GetProjectAssetServicesAggrRec(new GetProjectAssetServicesAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetProjectAssetServicesAggrRec.init();

class GetInvoiceUsagesAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_4b4c014d751d32313a045df1c34bbf8fEntityRecord, {
name: "InvoiceUsage",
attrName: "invoiceUsageAttr",
nameForJson: "InvoiceUsage",
uniqueId: "2512cd3c-c7f9-86e3-6b4d-5edf290d4383"
}))));
}
static fromStructure(str) {
return new GetInvoiceUsagesAggrRec(new GetInvoiceUsagesAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetInvoiceUsagesAggrRec.init();

class GetOrderRetentionTypesAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_4687fb2520dfeecb0ed6626cf8701229EntityRecord, {
name: "OrderRetentionType",
attrName: "orderRetentionTypeAttr",
nameForJson: "OrderRetentionType",
uniqueId: "59361fc2-fe27-e83d-1af4-7e8e07392a42"
}))));
}
static fromStructure(str) {
return new GetOrderRetentionTypesAggrRec(new GetOrderRetentionTypesAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetOrderRetentionTypesAggrRec.init();

class GetBusinessValueCategoriesAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord, {
name: "BusinessValueCategory",
attrName: "businessValueCategoryAttr",
nameForJson: "BusinessValueCategory",
uniqueId: "c8382e0b-08ee-9d59-65e5-aae5b17d6261"
}))));
}
static fromStructure(str) {
return new GetBusinessValueCategoriesAggrRec(new GetBusinessValueCategoriesAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetBusinessValueCategoriesAggrRec.init();

class GetPaymentTermsAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_17720044fda96c0c2d8d0760c429f48aEntityRecord, {
name: "PaymentTerms",
attrName: "paymentTermsAttr",
nameForJson: "PaymentTerms",
uniqueId: "5526bab1-a997-40bd-870d-de6a69ba3d9a"
}))));
}
static fromStructure(str) {
return new GetPaymentTermsAggrRec(new GetPaymentTermsAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetPaymentTermsAggrRec.init();

class GetInsuranceTypesAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_236be3b5d3b4417469f4bc1f0f73d781EntityRecord, {
name: "InsuranceType",
attrName: "insuranceTypeAttr",
nameForJson: "InsuranceType",
uniqueId: "e16f126a-e5f7-407d-32d4-a429fb32ca9a"
}))));
}
static fromStructure(str) {
return new GetInsuranceTypesAggrRec(new GetInsuranceTypesAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetInsuranceTypesAggrRec.init();

class GetFrequenciesAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_a6239c65aa61ed4530d18a92034301bbEntityRecord, {
name: "Frequency",
attrName: "frequencyAttr",
nameForJson: "Frequency",
uniqueId: "f2c609d8-58f8-411e-75fb-edee60c5dddf"
}))));
}
static fromStructure(str) {
return new GetFrequenciesAggrRec(new GetFrequenciesAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetFrequenciesAggrRec.init();

class GetPaymentOptionsAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_7a1403ba58c6cea2d2bf07fe0448aa32EntityRecord, {
name: "PaymentOptions",
attrName: "paymentOptionsAttr",
nameForJson: "PaymentOptions",
uniqueId: "2813028c-34d1-b3ce-080a-3e2c9febe797"
}))));
}
static fromStructure(str) {
return new GetPaymentOptionsAggrRec(new GetPaymentOptionsAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetPaymentOptionsAggrRec.init();

class GetPaymentWaysAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_16f07ea11d30dfe052ad03e4a9bcc7b8EntityRecord, {
name: "PaymentWays",
attrName: "paymentWaysAttr",
nameForJson: "PaymentWays",
uniqueId: "4a8ab393-337b-8820-18e4-4511f7ddbaa8"
}))));
}
static fromStructure(str) {
return new GetPaymentWaysAggrRec(new GetPaymentWaysAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetPaymentWaysAggrRec.init();

class GetOrderMainItemsByOrderMainIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_16678e1ac2e17d1b5db4a9a7f4681e64));
}
static fromStructure(str) {
return new GetOrderMainItemsByOrderMainIdAggrRec(new GetOrderMainItemsByOrderMainIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetOrderMainItemsByOrderMainIdAggrRec.init();

class GetCurrenciesAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_327b52812b8badb247bde4975c10d441EntityRecord, {
name: "Currency",
attrName: "currencyAttr",
nameForJson: "Currency",
uniqueId: "0468f02f-35e6-ccd6-a092-f321c5d8a88e"
}))));
}
static fromStructure(str) {
return new GetCurrenciesAggrRec(new GetCurrenciesAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetCurrenciesAggrRec.init();

class GetDepositTypesAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_784c408ed98e561e8741fa0e6e348ddcEntityRecord, {
name: "DepositType",
attrName: "depositTypeAttr",
nameForJson: "DepositType",
uniqueId: "a8c523bc-4a14-ce1c-f905-293530597bc7"
}))));
}
static fromStructure(str) {
return new GetDepositTypesAggrRec(new GetDepositTypesAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetDepositTypesAggrRec.init();

class GetPaymentMethodsAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord, {
name: "PaymentMethods",
attrName: "paymentMethodsAttr",
nameForJson: "PaymentMethods",
uniqueId: "45208e18-4b91-2aa1-623c-df19760e8e7e"
}))));
}
static fromStructure(str) {
return new GetPaymentMethodsAggrRec(new GetPaymentMethodsAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetPaymentMethodsAggrRec.init();

class GetRejectCommentAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord, {
name: "OrderComment",
attrName: "orderCommentAttr",
nameForJson: "OrderComment",
uniqueId: "cd61721e-e821-21e7-8e40-55ba4deb1fa6"
}))));
}
static fromStructure(str) {
return new GetRejectCommentAggrRec(new GetRejectCommentAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetRejectCommentAggrRec.init();


class GetOrderFilesListDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("o_FinanceAuthorization", "o_FinanceAuthorizationOut", "o_FinanceAuthorization", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new ST_c3df6a1f053620bf8d50da58ff4e41bcStructure());
}, true, ST_c3df6a1f053620bf8d50da58ff4e41bcStructure), 
this.attr("o_ProofOfForeignResidence", "o_ProofOfForeignResidenceOut", "o_ProofOfForeignResidence", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new ST_c3df6a1f053620bf8d50da58ff4e41bcStructure());
}, true, ST_c3df6a1f053620bf8d50da58ff4e41bcStructure)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

}

GetOrderFilesListDataActRec.init();

class GetPaymentTermSpecialDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("Id", "idOut", "Id", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, true), 
this.attr("IsActive", "isActiveOut", "IsActive", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

}

GetPaymentTermSpecialDataActRec.init();

class GetAccountingDataDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("OrderAccounting", "orderAccountingOut", "OrderAccounting", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord());
}, true, EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord), 
this.attr("o_ExchangeRateEvidence", "o_ExchangeRateEvidenceOut", "o_ExchangeRateEvidence", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new ST_c3df6a1f053620bf8d50da58ff4e41bcStructure());
}, true, ST_c3df6a1f053620bf8d50da58ff4e41bcStructure), 
this.attr("o_Estim_Equal_Agreed", "o_Estim_Equal_AgreedOut", "o_Estim_Equal_Agreed", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new RC_9dc9d00c2e8dcb1797f7869ab9e5a7f9());
}, true, RC_9dc9d00c2e8dcb1797f7869ab9e5a7f9), 
this.attr("o_CreditNote", "o_CreditNoteOut", "o_CreditNote", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new RC_9dc9d00c2e8dcb1797f7869ab9e5a7f9());
}, true, RC_9dc9d00c2e8dcb1797f7869ab9e5a7f9), 
this.attr("o_Voucher", "o_VoucherOut", "o_Voucher", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new RC_9dc9d00c2e8dcb1797f7869ab9e5a7f9());
}, true, RC_9dc9d00c2e8dcb1797f7869ab9e5a7f9), 
this.attr("o_Finiquito", "o_FiniquitoOut", "o_Finiquito", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new RC_9dc9d00c2e8dcb1797f7869ab9e5a7f9());
}, true, RC_9dc9d00c2e8dcb1797f7869ab9e5a7f9), 
this.attr("o_Anticipo", "o_AnticipoOut", "o_Anticipo", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new RC_9dc9d00c2e8dcb1797f7869ab9e5a7f9());
}, true, RC_9dc9d00c2e8dcb1797f7869ab9e5a7f9)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

}

GetAccountingDataDataActRec.init();

class GetOrderContractDataDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("o_ContractFile", "o_ContractFileOut", "o_ContractFile", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new ST_c3df6a1f053620bf8d50da58ff4e41bcStructure());
}, true, ST_c3df6a1f053620bf8d50da58ff4e41bcStructure), 
this.attr("o_AttachFilesList", "o_AttachFilesListOut", "o_AttachFilesList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_c3df6a1f053620bf8d50da58ff4e41bcStructure))());
}, true, (OS$GenericTypeCache.getGenericList(ST_c3df6a1f053620bf8d50da58ff4e41bcStructure))), 
this.attr("o_ContractDepositList", "o_ContractDepositListOut", "o_ContractDepositList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_c3df6a1f053620bf8d50da58ff4e41bcStructure))());
}, true, (OS$GenericTypeCache.getGenericList(ST_c3df6a1f053620bf8d50da58ff4e41bcStructure))), 
this.attr("o_ContractInsuranceList", "o_ContractInsuranceListOut", "o_ContractInsuranceList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_c3df6a1f053620bf8d50da58ff4e41bcStructure))());
}, true, (OS$GenericTypeCache.getGenericList(ST_c3df6a1f053620bf8d50da58ff4e41bcStructure))), 
this.attr("o_ContractAdvancePayment", "o_ContractAdvancePaymentOut", "o_ContractAdvancePayment", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new ST_c3df6a1f053620bf8d50da58ff4e41bcStructure());
}, true, ST_c3df6a1f053620bf8d50da58ff4e41bcStructure), 
this.attr("o_ContractPendingJustification", "o_ContractPendingJustificationOut", "o_ContractPendingJustification", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new ST_c3df6a1f053620bf8d50da58ff4e41bcStructure());
}, true, ST_c3df6a1f053620bf8d50da58ff4e41bcStructure)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

}

GetOrderContractDataDataActRec.init();


class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("l_CanEditForm", "l_CanEditFormVar", "l_CanEditForm", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return true;
}, false), 
this.attr("FilesList", "filesListVar", "FilesList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_c3df6a1f053620bf8d50da58ff4e41bcStructure))());
}, false, (OS$GenericTypeCache.getGenericList(ST_c3df6a1f053620bf8d50da58ff4e41bcStructure))), 
this.attr("l_FormIsValid", "l_FormIsValidVar", "l_FormIsValid", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return true;
}, false), 
this.attr("l_OrderRequestFiles", "l_OrderRequestFilesVar", "l_OrderRequestFiles", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_d9010d115c38fb059bccbc457fe11b18Structure))());
}, false, (OS$GenericTypeCache.getGenericList(ST_d9010d115c38fb059bccbc457fe11b18Structure))), 
this.attr("ShowOrderReject_Popup", "showOrderReject_PopupVar", "ShowOrderReject_Popup", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("DependentFoliosText", "dependentFoliosTextVar", "DependentFoliosText", true, false, OS$DataTypes.DataTypes.Text, function () {
return "Según los folios SAEC que cree el proveedor.";
}, false), 
this.attr("l_RequestDocsErrorMessage", "l_RequestDocsErrorMessageVar", "l_RequestDocsErrorMessage", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("l_IsValidReqDoc", "l_IsValidReqDocVar", "l_IsValidReqDoc", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_CanUploadContract", "l_CanUploadContractVar", "l_CanUploadContract", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_IsSavingContractFile", "l_IsSavingContractFileVar", "l_IsSavingContractFile", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_IsMissingEstimEqualAgFiniquito", "l_IsMissingEstimEqualAgFiniquitoVar", "l_IsMissingEstimEqualAgFiniquito", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("i_OrderId", "i_OrderIdIn", "i_OrderId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_i_OrderIdInDataFetchStatus", "_i_OrderIdInDataFetchStatus", "_i_OrderIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_ForceRefresh", "i_ForceRefreshIn", "i_ForceRefresh", true, false, OS$DataTypes.DataTypes.DateTime, function () {
return OS$DataTypes.DateTime.defaultValue;
}, false), 
this.attr("_i_ForceRefreshInDataFetchStatus", "_i_ForceRefreshInDataFetchStatus", "_i_ForceRefreshInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetSpecialApprovals", "getSpecialApprovalsAggr", "GetSpecialApprovals", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetSpecialApprovalsAggrRec());
}, true, GetSpecialApprovalsAggrRec), 
this.attr("GetAccountingDataTypes", "getAccountingDataTypesAggr", "GetAccountingDataTypes", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetAccountingDataTypesAggrRec());
}, true, GetAccountingDataTypesAggrRec), 
this.attr("GetAdvancedPaymentTypes", "getAdvancedPaymentTypesAggr", "GetAdvancedPaymentTypes", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetAdvancedPaymentTypesAggrRec());
}, true, GetAdvancedPaymentTypesAggrRec), 
this.attr("GetSpecialPostDeliveryAuthorizations", "getSpecialPostDeliveryAuthorizationsAggr", "GetSpecialPostDeliveryAuthorizations", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetSpecialPostDeliveryAuthorizationsAggrRec());
}, true, GetSpecialPostDeliveryAuthorizationsAggrRec), 
this.attr("GetContractStatuses", "getContractStatusesAggr", "GetContractStatuses", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetContractStatusesAggrRec());
}, true, GetContractStatusesAggrRec), 
this.attr("GetProjectAssetServiceOtro", "getProjectAssetServiceOtroAggr", "GetProjectAssetServiceOtro", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetProjectAssetServiceOtroAggrRec());
}, true, GetProjectAssetServiceOtroAggrRec), 
this.attr("GetSuppliers", "getSuppliersAggr", "GetSuppliers", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetSuppliersAggrRec());
}, true, GetSuppliersAggrRec), 
this.attr("GetBusinessValueSubcategoriesByCategoryId", "getBusinessValueSubcategoriesByCategoryIdAggr", "GetBusinessValueSubcategoriesByCategoryId", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetBusinessValueSubcategoriesByCategoryIdAggrRec());
}, true, GetBusinessValueSubcategoriesByCategoryIdAggrRec), 
this.attr("GetSupplierByRequisition", "getSupplierByRequisitionAggr", "GetSupplierByRequisition", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetSupplierByRequisitionAggrRec());
}, true, GetSupplierByRequisitionAggrRec), 
this.attr("GetOrderMainById", "getOrderMainByIdAggr", "GetOrderMainById", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetOrderMainByIdAggrRec());
}, true, GetOrderMainByIdAggrRec), 
this.attr("GetProjectAssetServices", "getProjectAssetServicesAggr", "GetProjectAssetServices", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetProjectAssetServicesAggrRec());
}, true, GetProjectAssetServicesAggrRec), 
this.attr("GetInvoiceUsages", "getInvoiceUsagesAggr", "GetInvoiceUsages", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetInvoiceUsagesAggrRec());
}, true, GetInvoiceUsagesAggrRec), 
this.attr("GetOrderRetentionTypes", "getOrderRetentionTypesAggr", "GetOrderRetentionTypes", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetOrderRetentionTypesAggrRec());
}, true, GetOrderRetentionTypesAggrRec), 
this.attr("GetBusinessValueCategories", "getBusinessValueCategoriesAggr", "GetBusinessValueCategories", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetBusinessValueCategoriesAggrRec());
}, true, GetBusinessValueCategoriesAggrRec), 
this.attr("GetPaymentTerms", "getPaymentTermsAggr", "GetPaymentTerms", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetPaymentTermsAggrRec());
}, true, GetPaymentTermsAggrRec), 
this.attr("GetInsuranceTypes", "getInsuranceTypesAggr", "GetInsuranceTypes", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetInsuranceTypesAggrRec());
}, true, GetInsuranceTypesAggrRec), 
this.attr("GetFrequencies", "getFrequenciesAggr", "GetFrequencies", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetFrequenciesAggrRec());
}, true, GetFrequenciesAggrRec), 
this.attr("GetPaymentOptions", "getPaymentOptionsAggr", "GetPaymentOptions", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetPaymentOptionsAggrRec());
}, true, GetPaymentOptionsAggrRec), 
this.attr("GetPaymentWays", "getPaymentWaysAggr", "GetPaymentWays", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetPaymentWaysAggrRec());
}, true, GetPaymentWaysAggrRec), 
this.attr("GetOrderMainItemsByOrderMainId", "getOrderMainItemsByOrderMainIdAggr", "GetOrderMainItemsByOrderMainId", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetOrderMainItemsByOrderMainIdAggrRec());
}, true, GetOrderMainItemsByOrderMainIdAggrRec), 
this.attr("GetCurrencies", "getCurrenciesAggr", "GetCurrencies", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetCurrenciesAggrRec());
}, true, GetCurrenciesAggrRec), 
this.attr("GetDepositTypes", "getDepositTypesAggr", "GetDepositTypes", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetDepositTypesAggrRec());
}, true, GetDepositTypesAggrRec), 
this.attr("GetPaymentMethods", "getPaymentMethodsAggr", "GetPaymentMethods", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetPaymentMethodsAggrRec());
}, true, GetPaymentMethodsAggrRec), 
this.attr("GetRejectComment", "getRejectCommentAggr", "GetRejectComment", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetRejectCommentAggrRec());
}, true, GetRejectCommentAggrRec), 
this.attr("GetOrderFilesList", "getOrderFilesListDataAct", "GetOrderFilesList", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetOrderFilesListDataActRec());
}, true, GetOrderFilesListDataActRec), 
this.attr("GetPaymentTermSpecial", "getPaymentTermSpecialDataAct", "GetPaymentTermSpecial", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetPaymentTermSpecialDataActRec());
}, true, GetPaymentTermSpecialDataActRec), 
this.attr("GetAccountingData", "getAccountingDataDataAct", "GetAccountingData", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetAccountingDataDataActRec());
}, true, GetAccountingDataDataActRec), 
this.attr("GetOrderContractData", "getOrderContractDataDataAct", "GetOrderContractData", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetOrderContractDataDataActRec());
}, true, GetOrderContractDataDataActRec)
].concat(OS$DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS$Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {
Form: OS$Model.ValidationWidgetRecord,
Switch_IsApprovalFromUserArea: OS$Model.ValidationWidgetRecord,
Dropdown_SpecialPostDeliveryAuthId: OS$Model.ValidationWidgetRecord,
Dropdown_projectassetservice: OS$Model.ValidationWidgetRecord,
Input_ProjectAssetService: OS$Model.ValidationWidgetRecord,
TextArea_ProjectDescription: OS$Model.ValidationWidgetRecord,
Dropdown_BusinessCategoryValue2: OS$Model.ValidationWidgetRecord,
Input_Period: OS$Model.ValidationWidgetRecord,
Dropdown_BusinessCategoryValue: OS$Model.ValidationWidgetRecord,
Dropdown_BusinessCategorySubValue: OS$Model.ValidationWidgetRecord,
Input_DocumentNumber: OS$Model.ValidationWidgetRecord,
Input_DocumentNumber2: OS$Model.ValidationWidgetRecord,
Input_DocumentNumber3: OS$Model.ValidationWidgetRecord,
Dropdown_InvoiceUsageItem: OS$Model.ValidationWidgetRecord,
Input_DocumentNumber4: OS$Model.ValidationWidgetRecord,
Dropdown_BusinessCategoryValue3: OS$Model.ValidationWidgetRecord,
Dropdown_BusinessCategorySubValue2: OS$Model.ValidationWidgetRecord,
SwitchIsApprovedFromTheUserArea2: OS$Model.ValidationWidgetRecord,
Dropdown_PaymentMethodId5: OS$Model.ValidationWidgetRecord,
Dropdown_ContractStatus: OS$Model.ValidationWidgetRecord,
Input_DateOfCommitment9: OS$Model.ValidationWidgetRecord,
Input_ContractNumber: OS$Model.ValidationWidgetRecord,
Input_DateOfCommitment2: OS$Model.ValidationWidgetRecord,
Input_DateOfCommitment3: OS$Model.ValidationWidgetRecord,
Input_ContractAmount: OS$Model.ValidationWidgetRecord,
Input_ContractTarif: OS$Model.ValidationWidgetRecord,
TextArea_OrdersContract: OS$Model.ValidationWidgetRecord,
Input_o_AttachFilesList: OS$Model.ValidationWidgetRecord,
Input_DateOfCommitment4: OS$Model.ValidationWidgetRecord,
Input_DateOfCommitment5: OS$Model.ValidationWidgetRecord,
Input_Amount: OS$Model.ValidationWidgetRecord,
Input_Tarif: OS$Model.ValidationWidgetRecord,
Dropdown_Supplier3: OS$Model.ValidationWidgetRecord,
SwitchIsApprovedFromTheUserArea4: OS$Model.ValidationWidgetRecord,
Dropdown_Supplier2: OS$Model.ValidationWidgetRecord,
Input_Retention: OS$Model.ValidationWidgetRecord,
Switch_Deposit2: OS$Model.ValidationWidgetRecord,
Checkbox2: OS$Model.ValidationWidgetRecord,
Dropdown_DepositType2: OS$Model.ValidationWidgetRecord,
Input_Deposit_Amount2: OS$Model.ValidationWidgetRecord,
Dropdown_Deposit_Currency2: OS$Model.ValidationWidgetRecord,
Switch_Insurance2: OS$Model.ValidationWidgetRecord,
Checkbox3: OS$Model.ValidationWidgetRecord,
Dropdown_Insurance2: OS$Model.ValidationWidgetRecord,
Input_Insurance_Amount2: OS$Model.ValidationWidgetRecord,
Dropdown_Insurance_Currency2: OS$Model.ValidationWidgetRecord,
Input_NegotiatedExchangeRate_Accounting: OS$Model.ValidationWidgetRecord,
TextArea_ExchangeRateComment: OS$Model.ValidationWidgetRecord,
Dropdown_SpecialApproval: OS$Model.ValidationWidgetRecord,
Switch_IsActive: OS$Model.ValidationWidgetRecord,
SwitchIsApprovedFromTheUserArea5: OS$Model.ValidationWidgetRecord,
Dropdown_AccountingDataType2: OS$Model.ValidationWidgetRecord,
Input_Estim_Equal_Agreed_Number: OS$Model.ValidationWidgetRecord,
Input_DependentFoliosText: OS$Model.ValidationWidgetRecord,
Input_Estim_Equal_Agreed_Amount: OS$Model.ValidationWidgetRecord,
Input_DateOfCommitment7: OS$Model.ValidationWidgetRecord,
Dropdown_PaymentTermsId2: OS$Model.ValidationWidgetRecord,
Input_Estim_Equal_Agreed_Amount2: OS$Model.ValidationWidgetRecord,
Switch_IsActive2: OS$Model.ValidationWidgetRecord,
Input_Concept_Amount5: OS$Model.ValidationWidgetRecord,
SwitchApplyForRequestProject4: OS$Model.ValidationWidgetRecord,
Dropdown_PaymentTermsId8: OS$Model.ValidationWidgetRecord,
Input_Estim_Equal_Agreed_Amount3: OS$Model.ValidationWidgetRecord,
Input_DateOfCommitment8: OS$Model.ValidationWidgetRecord,
Switch_IsActive3: OS$Model.ValidationWidgetRecord,
Input_Concept_Amount6: OS$Model.ValidationWidgetRecord,
SwitchApplyForRequestProject5: OS$Model.ValidationWidgetRecord,
Dropdown_PaymentTermsId9: OS$Model.ValidationWidgetRecord,
Input_Estim_Equal_Agreed_Amount4: OS$Model.ValidationWidgetRecord,
Switch_IsActive4: OS$Model.ValidationWidgetRecord,
Input_Concept_Amount3: OS$Model.ValidationWidgetRecord,
Dropdown_PaymentTermsId5: OS$Model.ValidationWidgetRecord,
Input_Estim_Equal_Agreed_Amount5: OS$Model.ValidationWidgetRecord,
Switch_IsActive5: OS$Model.ValidationWidgetRecord,
Input_Concept_Amount4: OS$Model.ValidationWidgetRecord,
Dropdown_AccountingDataType5: OS$Model.ValidationWidgetRecord,
Dropdown_PaymentTermsId6: OS$Model.ValidationWidgetRecord,
Input_Estim_Equal_Agreed_Amount6: OS$Model.ValidationWidgetRecord,
Input_DateOfCommitment6: OS$Model.ValidationWidgetRecord
};
}

}

class Model extends 
OS$Model.BaseViewModel {
static getVariablesRecordConstructor() {
return VariablesRecord;
}

static getWidgetsRecordConstructor() {
return WidgetsRecord;
}

static get hasValidationWidgets() {return true;
}
setInputs(inputs) {
if("i_OrderId" in inputs) {
this.variables.i_OrderIdIn = inputs.i_OrderId;
if("_i_OrderIdInDataFetchStatus" in inputs) {
this.variables._i_OrderIdInDataFetchStatus = inputs._i_OrderIdInDataFetchStatus;
}

}

if("i_ForceRefresh" in inputs) {
this.variables.i_ForceRefreshIn = inputs.i_ForceRefresh;
if("_i_ForceRefreshInDataFetchStatus" in inputs) {
this.variables._i_ForceRefreshInDataFetchStatus = inputs._i_ForceRefreshInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


