import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes, BuiltinFunctions as OS$BuiltinFunctions, DataConversion } from "@outsystems/runtime-core-js";
import { EN_a6239c65aa61ed4530d18a92034301bbEntityRecord, EN_17720044fda96c0c2d8d0760c429f48aEntityRecord, EN_b0cf3ee36985920f2fdff1dbd2e94fb9EntityRecord, EN_16f07ea11d30dfe052ad03e4a9bcc7b8EntityRecord, EN_485b44f219737098b3b1029e90069935EntityRecord, EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord, EN_236be3b5d3b4417469f4bc1f0f73d781EntityRecord, EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord, EN_a70d553ce1458b3952d039852f258a76EntityRecord, EN_5330eb9d72d4150e1f1663e553394fb3EntityRecord, EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord, EN_7a1403ba58c6cea2d2bf07fe0448aa32EntityRecord, EN_9a75c3f9d1545f2094763e7c965e9d81EntityRecord, EN_4b4c014d751d32313a045df1c34bbf8fEntityRecord, EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord, EN_90b73a13d9271bc660c79c0da31f8dbbEntityRecord, EN_88460e7eac2a65d244abb23fe44af0adEntityRecord, EN_0578d9e3d7c16250b8bfbc03836e290fEntityRecord, EN_f296fc330d9916f9de4aae18321e8388EntityRecord, EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord, EN_57ee0c02163ab55038103469b2569162EntityRecord, EN_784c408ed98e561e8741fa0e6e348ddcEntityRecord, EN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord } from "./Organization.model.js";
import { RC_21a885f0bb9cdabb4dd12f34282bebba, RC_5df7bb5aa64fe06d5d087faa4a2fd561, RC_cc5b09a13023b24fea23c488b525369e, EN_455768e63ed34ad2746f7c539b65e1caEntityRecord, RC_2d026dc77741fad17a11f0df63aa3b4b, RC_7c130c22cc39a396afe0c98666f27e02, RC_db730a379abf48e3725f395a2176e12f, ST_26b16bea631cbd94cf555acb5c7a4be3Structure, EN_3554712eb61e9f0a2132c551df0f1db5EntityRecord, RC_cdb29de40f41bea5403aac7edb2d6159, RC_f80fde4acf9a7dc465a1d535c05dfb8e, ST_e39617f0f094a322d4157f34fe424dadStructure, RC_ee67c405f78e15f46603b032a29fae74, EN_114fcf95674648310a3efb0d78529a37EntityRecord } from "./ConectaProveedores.model.js";
import { EN_327b52812b8badb247bde4975c10d441EntityRecord } from "./Common.model.js";

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

class GetUserByIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_21a885f0bb9cdabb4dd12f34282bebba));
}
static fromStructure(str) {
return new GetUserByIdAggrRec(new GetUserByIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetUserByIdAggrRec.init();

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

class GetCostCentersAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord, {
name: "CostCenterSAP",
attrName: "costCenterSAPAttr",
nameForJson: "CostCenterSAP",
uniqueId: "515e950f-e4b2-9206-769e-5475135e301d"
}))));
}
static fromStructure(str) {
return new GetCostCentersAggrRec(new GetCostCentersAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetCostCentersAggrRec.init();

class GetDocumentTypeAnticipoKWAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_a70d553ce1458b3952d039852f258a76EntityRecord, {
name: "DocumentType",
attrName: "documentTypeAttr",
nameForJson: "DocumentType",
uniqueId: "10f704d4-de89-99e2-55a0-9f6b1b9b5668"
}))));
}
static fromStructure(str) {
return new GetDocumentTypeAnticipoKWAggrRec(new GetDocumentTypeAnticipoKWAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetDocumentTypeAnticipoKWAggrRec.init();

class GetAccountableGuideAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_5330eb9d72d4150e1f1663e553394fb3EntityRecord, {
name: "AccountableGuide",
attrName: "accountableGuideAttr",
nameForJson: "AccountableGuide",
uniqueId: "5529030b-7e85-f68f-6007-e4d32f650ef7"
}))));
}
static fromStructure(str) {
return new GetAccountableGuideAggrRec(new GetAccountableGuideAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetAccountableGuideAggrRec.init();

class GetAccountingAccountsServiceTypesAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord, {
name: "AccountingAccounts_ServiceType",
attrName: "accountingAccounts_ServiceTypeAttr",
nameForJson: "AccountingAccounts_ServiceType",
uniqueId: "f52b5cef-cfac-4041-2219-5213ce1b53ba"
}))));
}
static fromStructure(str) {
return new GetAccountingAccountsServiceTypesAggrRec(new GetAccountingAccountsServiceTypesAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetAccountingAccountsServiceTypesAggrRec.init();

class GetSupplierSocietiesAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_5df7bb5aa64fe06d5d087faa4a2fd561));
}
static fromStructure(str) {
return new GetSupplierSocietiesAggrRec(new GetSupplierSocietiesAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetSupplierSocietiesAggrRec.init();

class GetProjectAssetByRequisitionAggrRec extends 
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
return new GetProjectAssetByRequisitionAggrRec(new GetProjectAssetByRequisitionAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetProjectAssetByRequisitionAggrRec.init();

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

class GetSustainabilitiesAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_9a75c3f9d1545f2094763e7c965e9d81EntityRecord, {
name: "Sustainability",
attrName: "sustainabilityAttr",
nameForJson: "Sustainability",
uniqueId: "f677954b-3254-ea60-260c-b7baa72dce4f"
}))));
}
static fromStructure(str) {
return new GetSustainabilitiesAggrRec(new GetSustainabilitiesAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetSustainabilitiesAggrRec.init();

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

class GetCostCenterSAPByRequisitionIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_cc5b09a13023b24fea23c488b525369e));
}
static fromStructure(str) {
return new GetCostCenterSAPByRequisitionIdAggrRec(new GetCostCenterSAPByRequisitionIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetCostCenterSAPByRequisitionIdAggrRec.init();

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

class GetPaymentWay99AggrRec extends 
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
return new GetPaymentWay99AggrRec(new GetPaymentWay99AggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetPaymentWay99AggrRec.init();

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

class GetServiceFormatsAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_90b73a13d9271bc660c79c0da31f8dbbEntityRecord, {
name: "ServiceFormat",
attrName: "serviceFormatAttr",
nameForJson: "ServiceFormat",
uniqueId: "1356565a-59d3-7b0a-56b6-1edcf3cae9df"
}))));
}
static fromStructure(str) {
return new GetServiceFormatsAggrRec(new GetServiceFormatsAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetServiceFormatsAggrRec.init();

class GetDistributionsAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_88460e7eac2a65d244abb23fe44af0adEntityRecord, {
name: "Distribution",
attrName: "distributionAttr",
nameForJson: "Distribution",
uniqueId: "a6482208-c24c-e2e6-c9c6-ba16e57b0185"
}))));
}
static fromStructure(str) {
return new GetDistributionsAggrRec(new GetDistributionsAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetDistributionsAggrRec.init();

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

class GetRequisitionServicesByRequisitionIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_455768e63ed34ad2746f7c539b65e1caEntityRecord, {
name: "RequisitionService",
attrName: "requisitionServiceAttr",
nameForJson: "RequisitionService",
uniqueId: "04e72477-5706-0d40-16b4-3102119b0dd6"
}))));
}
static fromStructure(str) {
return new GetRequisitionServicesByRequisitionIdAggrRec(new GetRequisitionServicesByRequisitionIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetRequisitionServicesByRequisitionIdAggrRec.init();

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

class GetEntraRoleAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_2d026dc77741fad17a11f0df63aa3b4b));
}
static fromStructure(str) {
return new GetEntraRoleAggrRec(new GetEntraRoleAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetEntraRoleAggrRec.init();

class GetRequisitionCostCentersByRequisitionIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_7c130c22cc39a396afe0c98666f27e02));
}
static fromStructure(str) {
return new GetRequisitionCostCentersByRequisitionIdAggrRec(new GetRequisitionCostCentersByRequisitionIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetRequisitionCostCentersByRequisitionIdAggrRec.init();

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

class GetDocumentTypeKRAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_a70d553ce1458b3952d039852f258a76EntityRecord, {
name: "DocumentType",
attrName: "documentTypeAttr",
nameForJson: "DocumentType",
uniqueId: "10f704d4-de89-99e2-55a0-9f6b1b9b5668"
}))));
}
static fromStructure(str) {
return new GetDocumentTypeKRAggrRec(new GetDocumentTypeKRAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetDocumentTypeKRAggrRec.init();

class GetSupplierDetailBySocietyAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_57ee0c02163ab55038103469b2569162EntityRecord, {
name: "SupplierDetail",
attrName: "supplierDetailAttr",
nameForJson: "SupplierDetail",
uniqueId: "2a6a47a0-42b2-e84e-ddb6-ad9d86f0a684"
}))));
}
static fromStructure(str) {
return new GetSupplierDetailBySocietyAggrRec(new GetSupplierDetailBySocietyAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetSupplierDetailBySocietyAggrRec.init();

class GetRequisitionByIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_db730a379abf48e3725f395a2176e12f));
}
static fromStructure(str) {
return new GetRequisitionByIdAggrRec(new GetRequisitionByIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetRequisitionByIdAggrRec.init();

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


class GetRequisitionContractDataDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("o_ContractFile", "o_ContractFileOut", "o_ContractFile", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new ST_26b16bea631cbd94cf555acb5c7a4be3Structure());
}, true, ST_26b16bea631cbd94cf555acb5c7a4be3Structure), 
this.attr("o_AttachFilesList", "o_AttachFilesListOut", "o_AttachFilesList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_26b16bea631cbd94cf555acb5c7a4be3Structure))());
}, true, (OS$GenericTypeCache.getGenericList(ST_26b16bea631cbd94cf555acb5c7a4be3Structure))), 
this.attr("o_ContractDepositList", "o_ContractDepositListOut", "o_ContractDepositList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_26b16bea631cbd94cf555acb5c7a4be3Structure))());
}, true, (OS$GenericTypeCache.getGenericList(ST_26b16bea631cbd94cf555acb5c7a4be3Structure))), 
this.attr("o_ContractInsuranceList", "o_ContractInsuranceListOut", "o_ContractInsuranceList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_26b16bea631cbd94cf555acb5c7a4be3Structure))());
}, true, (OS$GenericTypeCache.getGenericList(ST_26b16bea631cbd94cf555acb5c7a4be3Structure))), 
this.attr("o_ContractAdvancePayment", "o_ContractAdvancePaymentOut", "o_ContractAdvancePayment", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new ST_26b16bea631cbd94cf555acb5c7a4be3Structure());
}, true, ST_26b16bea631cbd94cf555acb5c7a4be3Structure), 
this.attr("o_ContractPendingJustification", "o_ContractPendingJustificationOut", "o_ContractPendingJustification", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new ST_26b16bea631cbd94cf555acb5c7a4be3Structure());
}, true, ST_26b16bea631cbd94cf555acb5c7a4be3Structure)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

}

GetRequisitionContractDataDataActRec.init();

class GetShowSelectReqPopupDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("IsCorporativo", "isCorporativoOut", "IsCorporativo", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new GetShowSelectReqPopupDataActRec(new GetShowSelectReqPopupDataActRec.RecordClass({
isCorporativoOut: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetShowSelectReqPopupDataActRec.init();

class GetAdvWithoutInvoiceDataDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("o_AdvWithoutInvoice", "o_AdvWithoutInvoiceOut", "o_AdvWithoutInvoice", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new ST_26b16bea631cbd94cf555acb5c7a4be3Structure());
}, true, ST_26b16bea631cbd94cf555acb5c7a4be3Structure)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new GetAdvWithoutInvoiceDataDataActRec(new GetAdvWithoutInvoiceDataDataActRec.RecordClass({
o_AdvWithoutInvoiceOut: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetAdvWithoutInvoiceDataDataActRec.init();

class GetConfigurationDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("UploadContractDateLimit", "uploadContractDateLimitOut", "UploadContractDateLimit", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, true)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new GetConfigurationDataActRec(new GetConfigurationDataActRec.RecordClass({
uploadContractDateLimitOut: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetConfigurationDataActRec.init();

class GetAccountingDataDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("RequisitionAccounting", "requisitionAccountingOut", "RequisitionAccounting", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new EN_3554712eb61e9f0a2132c551df0f1db5EntityRecord());
}, true, EN_3554712eb61e9f0a2132c551df0f1db5EntityRecord), 
this.attr("o_Estim_Equal_Agreed", "o_Estim_Equal_AgreedOut", "o_Estim_Equal_Agreed", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new RC_cdb29de40f41bea5403aac7edb2d6159());
}, true, RC_cdb29de40f41bea5403aac7edb2d6159), 
this.attr("o_Remaining", "o_RemainingOut", "o_Remaining", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(RC_f80fde4acf9a7dc465a1d535c05dfb8e))());
}, true, (OS$GenericTypeCache.getGenericList(RC_f80fde4acf9a7dc465a1d535c05dfb8e))), 
this.attr("ExchangeRateEvidence", "exchangeRateEvidenceOut", "ExchangeRateEvidence", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new ST_26b16bea631cbd94cf555acb5c7a4be3Structure());
}, true, ST_26b16bea631cbd94cf555acb5c7a4be3Structure), 
this.attr("REPSE", "rEPSEOut", "REPSE", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new ST_26b16bea631cbd94cf555acb5c7a4be3Structure());
}, true, ST_26b16bea631cbd94cf555acb5c7a4be3Structure)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

}

GetAccountingDataDataActRec.init();

class GetShowIsDonationDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("o_Show", "o_ShowOut", "o_Show", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new GetShowIsDonationDataActRec(new GetShowIsDonationDataActRec.RecordClass({
o_ShowOut: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetShowIsDonationDataActRec.init();

class GetSettingsDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("o_IsActiveServiceTypeEXP1", "o_IsActiveServiceTypeEXP1Out", "o_IsActiveServiceTypeEXP1", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new GetSettingsDataActRec(new GetSettingsDataActRec.RecordClass({
o_IsActiveServiceTypeEXP1Out: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetSettingsDataActRec.init();

class GetRequisitionFilesDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("o_FinanceAuthorization", "o_FinanceAuthorizationOut", "o_FinanceAuthorization", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new ST_26b16bea631cbd94cf555acb5c7a4be3Structure());
}, true, ST_26b16bea631cbd94cf555acb5c7a4be3Structure), 
this.attr("o_ProofOfForeignResidence", "o_ProofOfForeignResidenceOut", "o_ProofOfForeignResidence", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new ST_26b16bea631cbd94cf555acb5c7a4be3Structure());
}, true, ST_26b16bea631cbd94cf555acb5c7a4be3Structure)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

}

GetRequisitionFilesDataActRec.init();

class GetUserApplicationRolesDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("UserRolesList", "userRolesListOut", "UserRolesList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_e39617f0f094a322d4157f34fe424dadStructure))());
}, true, (OS$GenericTypeCache.getGenericList(ST_e39617f0f094a322d4157f34fe424dadStructure))), 
this.attr("ListText", "listTextOut", "ListText", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("IsCorporativoCxP", "isCorporativoCxPOut", "IsCorporativoCxP", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("CanUploadInvoices", "canUploadInvoicesOut", "CanUploadInvoices", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("TelcelDirectionsListText", "telcelDirectionsListTextOut", "TelcelDirectionsListText", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("IsSegmentationCorporativo", "isSegmentationCorporativoOut", "IsSegmentationCorporativo", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("CorporativoRegionId", "corporativoRegionIdOut", "CorporativoRegionId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, true)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

}

GetUserApplicationRolesDataActRec.init();

class GetPaymentMethodsBySupplierIdDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("List", "listOut", "List", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(EN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord))());
}, true, (OS$GenericTypeCache.getGenericList(EN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord)))
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new GetPaymentMethodsBySupplierIdDataActRec(new GetPaymentMethodsBySupplierIdDataActRec.RecordClass({
listOut: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetPaymentMethodsBySupplierIdDataActRec.init();


class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("l_AllFiles", "l_AllFilesVar", "l_AllFiles", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_26b16bea631cbd94cf555acb5c7a4be3Structure))());
}, false, (OS$GenericTypeCache.getGenericList(ST_26b16bea631cbd94cf555acb5c7a4be3Structure))), 
this.attr("l_Attached_Filename", "l_Attached_FilenameVar", "l_Attached_Filename", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("l_AttachedFile_BinaryData", "l_AttachedFile_BinaryDataVar", "l_AttachedFile_BinaryData", true, false, OS$DataTypes.DataTypes.BinaryData, function () {
return OS$DataTypes.BinaryData.defaultValue;
}, false), 
this.attr("l_CanEditAccounting", "l_CanEditAccountingVar", "l_CanEditAccounting", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_CanEditUserArea", "l_CanEditUserAreaVar", "l_CanEditUserArea", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_FormIsValid", "l_FormIsValidVar", "l_FormIsValid", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_IsBusy", "l_IsBusyVar", "l_IsBusy", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_RefreshSideBar", "l_RefreshSideBarVar", "l_RefreshSideBar", true, false, OS$DataTypes.DataTypes.DateTime, function () {
return OS$DataTypes.DateTime.defaultValue;
}, false), 
this.attr("l_RetentionPercentageList", "l_RetentionPercentageListVar", "l_RetentionPercentageList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(RC_ee67c405f78e15f46603b032a29fae74))());
}, false, (OS$GenericTypeCache.getGenericList(RC_ee67c405f78e15f46603b032a29fae74))), 
this.attr("l_SelectedCostCentersList", "l_SelectedCostCentersListVar", "l_SelectedCostCentersList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(EN_114fcf95674648310a3efb0d78529a37EntityRecord))());
}, false, (OS$GenericTypeCache.getGenericList(EN_114fcf95674648310a3efb0d78529a37EntityRecord))), 
this.attr("l_ShowCancelPopup", "l_ShowCancelPopupVar", "l_ShowCancelPopup", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_ShowModifyPopup", "l_ShowModifyPopupVar", "l_ShowModifyPopup", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_OriginalDateOfCommitment", "l_OriginalDateOfCommitmentVar", "l_OriginalDateOfCommitment", true, false, OS$DataTypes.DataTypes.Date, function () {
return OS$DataTypes.DateTime.defaultValue;
}, false), 
this.attr("l_ShowSavePendingInfoBtn", "l_ShowSavePendingInfoBtnVar", "l_ShowSavePendingInfoBtn", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_RefreshRequisitionEntra_Historic", "l_RefreshRequisitionEntra_HistoricVar", "l_RefreshRequisitionEntra_Historic", true, false, OS$DataTypes.DataTypes.DateTime, function () {
return OS$BuiltinFunctions.currDateTime();
}, false), 
this.attr("l_ShowHideSelectReqRegion_Popup", "l_ShowHideSelectReqRegion_PopupVar", "l_ShowHideSelectReqRegion_Popup", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_RegionId", "l_RegionIdVar", "l_RegionId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("l_ShowAssignFirstApproverPopup", "l_ShowAssignFirstApproverPopupVar", "l_ShowAssignFirstApproverPopup", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_SelectedAccount", "l_SelectedAccountVar", "l_SelectedAccount", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("ProjectAssetSearchText", "projectAssetSearchTextVar", "ProjectAssetSearchText", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("ProjectAssetMaxRecord", "projectAssetMaxRecordVar", "ProjectAssetMaxRecord", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 20;
}, false), 
this.attr("l_ShowHideSpecialOrNormalWorkflow", "l_ShowHideSpecialOrNormalWorkflowVar", "l_ShowHideSpecialOrNormalWorkflow", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_NotValid", "l_NotValidVar", "l_NotValid", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_NotValidPaymentsValue", "l_NotValidPaymentsValueVar", "l_NotValidPaymentsValue", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_NotValidContractValue", "l_NotValidContractValueVar", "l_NotValidContractValue", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_CanSeeAdvanceWithOrWithoutInvoice", "l_CanSeeAdvanceWithOrWithoutInvoiceVar", "l_CanSeeAdvanceWithOrWithoutInvoice", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_IsToExitCapture", "l_IsToExitCaptureVar", "l_IsToExitCapture", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_DropdownSupplierValid", "l_DropdownSupplierValidVar", "l_DropdownSupplierValid", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return true;
}, false), 
this.attr("l_AllowActions", "l_AllowActionsVar", "l_AllowActions", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_PreviousSelectedCostCenter", "l_PreviousSelectedCostCenterVar", "l_PreviousSelectedCostCenter", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("i_RequisitionId", "i_RequisitionIdIn", "i_RequisitionId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_i_RequisitionIdInDataFetchStatus", "_i_RequisitionIdInDataFetchStatus", "_i_RequisitionIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_IsUploadInvoice", "i_IsUploadInvoiceIn", "i_IsUploadInvoice", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_i_IsUploadInvoiceInDataFetchStatus", "_i_IsUploadInvoiceInDataFetchStatus", "_i_IsUploadInvoiceInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetFrequencies", "getFrequenciesAggr", "GetFrequencies", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetFrequenciesAggrRec());
}, true, GetFrequenciesAggrRec), 
this.attr("GetUserById", "getUserByIdAggr", "GetUserById", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetUserByIdAggrRec());
}, true, GetUserByIdAggrRec), 
this.attr("GetPaymentTerms", "getPaymentTermsAggr", "GetPaymentTerms", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetPaymentTermsAggrRec());
}, true, GetPaymentTermsAggrRec), 
this.attr("GetSpecialPostDeliveryAuthorizations", "getSpecialPostDeliveryAuthorizationsAggr", "GetSpecialPostDeliveryAuthorizations", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetSpecialPostDeliveryAuthorizationsAggrRec());
}, true, GetSpecialPostDeliveryAuthorizationsAggrRec), 
this.attr("GetPaymentWays", "getPaymentWaysAggr", "GetPaymentWays", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetPaymentWaysAggrRec());
}, true, GetPaymentWaysAggrRec), 
this.attr("GetAdvancedPaymentTypes", "getAdvancedPaymentTypesAggr", "GetAdvancedPaymentTypes", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetAdvancedPaymentTypesAggrRec());
}, true, GetAdvancedPaymentTypesAggrRec), 
this.attr("GetProjectAssetServices", "getProjectAssetServicesAggr", "GetProjectAssetServices", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetProjectAssetServicesAggrRec());
}, true, GetProjectAssetServicesAggrRec), 
this.attr("GetInsuranceTypes", "getInsuranceTypesAggr", "GetInsuranceTypes", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetInsuranceTypesAggrRec());
}, true, GetInsuranceTypesAggrRec), 
this.attr("GetCostCenters", "getCostCentersAggr", "GetCostCenters", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetCostCentersAggrRec());
}, true, GetCostCentersAggrRec), 
this.attr("GetDocumentTypeAnticipoKW", "getDocumentTypeAnticipoKWAggr", "GetDocumentTypeAnticipoKW", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetDocumentTypeAnticipoKWAggrRec());
}, true, GetDocumentTypeAnticipoKWAggrRec), 
this.attr("GetAccountableGuide", "getAccountableGuideAggr", "GetAccountableGuide", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetAccountableGuideAggrRec());
}, true, GetAccountableGuideAggrRec), 
this.attr("GetAccountingAccountsServiceTypes", "getAccountingAccountsServiceTypesAggr", "GetAccountingAccountsServiceTypes", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetAccountingAccountsServiceTypesAggrRec());
}, true, GetAccountingAccountsServiceTypesAggrRec), 
this.attr("GetSupplierSocieties", "getSupplierSocietiesAggr", "GetSupplierSocieties", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetSupplierSocietiesAggrRec());
}, true, GetSupplierSocietiesAggrRec), 
this.attr("GetProjectAssetByRequisition", "getProjectAssetByRequisitionAggr", "GetProjectAssetByRequisition", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetProjectAssetByRequisitionAggrRec());
}, true, GetProjectAssetByRequisitionAggrRec), 
this.attr("GetCurrencies", "getCurrenciesAggr", "GetCurrencies", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetCurrenciesAggrRec());
}, true, GetCurrenciesAggrRec), 
this.attr("GetPaymentOptions", "getPaymentOptionsAggr", "GetPaymentOptions", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetPaymentOptionsAggrRec());
}, true, GetPaymentOptionsAggrRec), 
this.attr("GetSustainabilities", "getSustainabilitiesAggr", "GetSustainabilities", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetSustainabilitiesAggrRec());
}, true, GetSustainabilitiesAggrRec), 
this.attr("GetInvoiceUsages", "getInvoiceUsagesAggr", "GetInvoiceUsages", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetInvoiceUsagesAggrRec());
}, true, GetInvoiceUsagesAggrRec), 
this.attr("GetCostCenterSAPByRequisitionId", "getCostCenterSAPByRequisitionIdAggr", "GetCostCenterSAPByRequisitionId", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetCostCenterSAPByRequisitionIdAggrRec());
}, true, GetCostCenterSAPByRequisitionIdAggrRec), 
this.attr("GetProjectAssetServiceOtro", "getProjectAssetServiceOtroAggr", "GetProjectAssetServiceOtro", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetProjectAssetServiceOtroAggrRec());
}, true, GetProjectAssetServiceOtroAggrRec), 
this.attr("GetPaymentWay99", "getPaymentWay99Aggr", "GetPaymentWay99", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetPaymentWay99AggrRec());
}, true, GetPaymentWay99AggrRec), 
this.attr("GetAccountingDataTypes", "getAccountingDataTypesAggr", "GetAccountingDataTypes", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetAccountingDataTypesAggrRec());
}, true, GetAccountingDataTypesAggrRec), 
this.attr("GetServiceFormats", "getServiceFormatsAggr", "GetServiceFormats", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetServiceFormatsAggrRec());
}, true, GetServiceFormatsAggrRec), 
this.attr("GetDistributions", "getDistributionsAggr", "GetDistributions", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetDistributionsAggrRec());
}, true, GetDistributionsAggrRec), 
this.attr("GetBusinessValueCategories", "getBusinessValueCategoriesAggr", "GetBusinessValueCategories", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetBusinessValueCategoriesAggrRec());
}, true, GetBusinessValueCategoriesAggrRec), 
this.attr("GetRequisitionServicesByRequisitionId", "getRequisitionServicesByRequisitionIdAggr", "GetRequisitionServicesByRequisitionId", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetRequisitionServicesByRequisitionIdAggrRec());
}, true, GetRequisitionServicesByRequisitionIdAggrRec), 
this.attr("GetBusinessValueSubcategoriesByCategoryId", "getBusinessValueSubcategoriesByCategoryIdAggr", "GetBusinessValueSubcategoriesByCategoryId", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetBusinessValueSubcategoriesByCategoryIdAggrRec());
}, true, GetBusinessValueSubcategoriesByCategoryIdAggrRec), 
this.attr("GetEntraRole", "getEntraRoleAggr", "GetEntraRole", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetEntraRoleAggrRec());
}, true, GetEntraRoleAggrRec), 
this.attr("GetRequisitionCostCentersByRequisitionId", "getRequisitionCostCentersByRequisitionIdAggr", "GetRequisitionCostCentersByRequisitionId", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetRequisitionCostCentersByRequisitionIdAggrRec());
}, true, GetRequisitionCostCentersByRequisitionIdAggrRec), 
this.attr("GetSupplierByRequisition", "getSupplierByRequisitionAggr", "GetSupplierByRequisition", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetSupplierByRequisitionAggrRec());
}, true, GetSupplierByRequisitionAggrRec), 
this.attr("GetDocumentTypeKR", "getDocumentTypeKRAggr", "GetDocumentTypeKR", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetDocumentTypeKRAggrRec());
}, true, GetDocumentTypeKRAggrRec), 
this.attr("GetSupplierDetailBySociety", "getSupplierDetailBySocietyAggr", "GetSupplierDetailBySociety", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetSupplierDetailBySocietyAggrRec());
}, true, GetSupplierDetailBySocietyAggrRec), 
this.attr("GetRequisitionById", "getRequisitionByIdAggr", "GetRequisitionById", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetRequisitionByIdAggrRec());
}, true, GetRequisitionByIdAggrRec), 
this.attr("GetDepositTypes", "getDepositTypesAggr", "GetDepositTypes", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetDepositTypesAggrRec());
}, true, GetDepositTypesAggrRec), 
this.attr("GetRequisitionContractData", "getRequisitionContractDataDataAct", "GetRequisitionContractData", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetRequisitionContractDataDataActRec());
}, true, GetRequisitionContractDataDataActRec), 
this.attr("GetShowSelectReqPopup", "getShowSelectReqPopupDataAct", "GetShowSelectReqPopup", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetShowSelectReqPopupDataActRec());
}, true, GetShowSelectReqPopupDataActRec), 
this.attr("GetAdvWithoutInvoiceData", "getAdvWithoutInvoiceDataDataAct", "GetAdvWithoutInvoiceData", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetAdvWithoutInvoiceDataDataActRec());
}, true, GetAdvWithoutInvoiceDataDataActRec), 
this.attr("GetConfiguration", "getConfigurationDataAct", "GetConfiguration", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetConfigurationDataActRec());
}, true, GetConfigurationDataActRec), 
this.attr("GetAccountingData", "getAccountingDataDataAct", "GetAccountingData", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetAccountingDataDataActRec());
}, true, GetAccountingDataDataActRec), 
this.attr("GetShowIsDonation", "getShowIsDonationDataAct", "GetShowIsDonation", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetShowIsDonationDataActRec());
}, true, GetShowIsDonationDataActRec), 
this.attr("GetSettings", "getSettingsDataAct", "GetSettings", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetSettingsDataActRec());
}, true, GetSettingsDataActRec), 
this.attr("GetRequisitionFiles", "getRequisitionFilesDataAct", "GetRequisitionFiles", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetRequisitionFilesDataActRec());
}, true, GetRequisitionFilesDataActRec), 
this.attr("GetUserApplicationRoles", "getUserApplicationRolesDataAct", "GetUserApplicationRoles", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetUserApplicationRolesDataActRec());
}, true, GetUserApplicationRolesDataActRec), 
this.attr("GetPaymentMethodsBySupplierId", "getPaymentMethodsBySupplierIdDataAct", "GetPaymentMethodsBySupplierId", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetPaymentMethodsBySupplierIdDataActRec());
}, true, GetPaymentMethodsBySupplierIdDataActRec)
].concat(OS$DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS$Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {
Form: OS$Model.ValidationWidgetRecord,
Input_Name: OS$Model.ValidationWidgetRecord,
Input_SupplierName: OS$Model.ValidationWidgetRecord,
Switch_Contract: OS$Model.ValidationWidgetRecord,
Switch_Advanced: OS$Model.ValidationWidgetRecord,
Switch_WasAdvWithoutInvoice_OnlyShow: OS$Model.ValidationWidgetRecord,
Dropdown_AdvancedPaymentType3: OS$Model.ValidationWidgetRecord,
Input_AdvancePayment_Amount3: OS$Model.ValidationWidgetRecord,
Dropdown_AdvancedPayment_Currency3: OS$Model.ValidationWidgetRecord,
Input_SupplierName2: OS$Model.ValidationWidgetRecord,
Input_BuyDocNr: OS$Model.ValidationWidgetRecord,
Input_BuyDocPos: OS$Model.ValidationWidgetRecord,
Switch_IsDonation: OS$Model.ValidationWidgetRecord,
Input_ProjectAssetService: OS$Model.ValidationWidgetRecord,
TextArea_ProjectDescription: OS$Model.ValidationWidgetRecord,
Dropdown_Frequency: OS$Model.ValidationWidgetRecord,
Dropdown_InvoiceUsage: OS$Model.ValidationWidgetRecord,
Input_AmountByServiceType: OS$Model.ValidationWidgetRecord,
TextArea_Description: OS$Model.ValidationWidgetRecord,
Input_CategoryValue3: OS$Model.ValidationWidgetRecord,
Dropdown_Distribution: OS$Model.ValidationWidgetRecord,
Input_SupplierName3: OS$Model.ValidationWidgetRecord,
Switch_Sustainability: OS$Model.ValidationWidgetRecord,
Dropdown_Sustainability: OS$Model.ValidationWidgetRecord,
Dropdown_BusinessCategoryValue: OS$Model.ValidationWidgetRecord,
Dropdown_BusinessCategorySubValue: OS$Model.ValidationWidgetRecord,
Dropdown_PaymentMethod: OS$Model.ValidationWidgetRecord,
Dropdown_PaymentTerm: OS$Model.ValidationWidgetRecord,
Dropdown_ServiceFormat2: OS$Model.ValidationWidgetRecord,
Dropdown_Currency: OS$Model.ValidationWidgetRecord,
Input_NegotiatedExchangeRate: OS$Model.ValidationWidgetRecord,
Dropdown_RetentionPercentage2: OS$Model.ValidationWidgetRecord,
Switch_ContractPending: OS$Model.ValidationWidgetRecord,
Input_DateOfCommitment: OS$Model.ValidationWidgetRecord,
Switch_ContractPending2: OS$Model.ValidationWidgetRecord,
Switch_Deposit2: OS$Model.ValidationWidgetRecord,
Dropdown_DepositType2: OS$Model.ValidationWidgetRecord,
Input_Deposit_Amount2: OS$Model.ValidationWidgetRecord,
Dropdown_Deposit_Currency2: OS$Model.ValidationWidgetRecord,
Switch_Insurance2: OS$Model.ValidationWidgetRecord,
Dropdown_Insurance2: OS$Model.ValidationWidgetRecord,
Input_Insurance_Amount2: OS$Model.ValidationWidgetRecord,
Dropdown_Insurance_Currency2: OS$Model.ValidationWidgetRecord,
Switch_AdvancedPayment2: OS$Model.ValidationWidgetRecord,
Dropdown_AdvancedPaymentType2: OS$Model.ValidationWidgetRecord,
Input_AdvancePayment_Amount2: OS$Model.ValidationWidgetRecord,
Dropdown_AdvancedPayment_Currency2: OS$Model.ValidationWidgetRecord,
Switch_IsActive: OS$Model.ValidationWidgetRecord,
Dropdown_AccountingDataType2: OS$Model.ValidationWidgetRecord,
Input_Estim_Equal_Agreed_Number: OS$Model.ValidationWidgetRecord,
Input_Estim_Equal_Agreed_Amount: OS$Model.ValidationWidgetRecord,
Dropdown_Estim_Equal_Agreed_Currency: OS$Model.ValidationWidgetRecord,
Switch_Concept: OS$Model.ValidationWidgetRecord,
Input_Concept_Amount: OS$Model.ValidationWidgetRecord,
Dropdown_Concept_Currency: OS$Model.ValidationWidgetRecord,
Switch_SpecialAuthorization: OS$Model.ValidationWidgetRecord,
Dropdown_SpecialAuthorization_Currency: OS$Model.ValidationWidgetRecord,
Dropdown_PaymentMethodId: OS$Model.ValidationWidgetRecord,
Dropdown_PaymentTermsId: OS$Model.ValidationWidgetRecord,
Input_NegotiatedExchangeRate_Accounting: OS$Model.ValidationWidgetRecord,
TextArea_ExchangeRateComment: OS$Model.ValidationWidgetRecord,
Switch_REPSE: OS$Model.ValidationWidgetRecord,
Switch_AdvancedPayment: OS$Model.ValidationWidgetRecord,
Switch_PaymentSupplement: OS$Model.ValidationWidgetRecord,
Dropdown_PaymentMethodId2: OS$Model.ValidationWidgetRecord,
Dropdown_PaymentTermsId2: OS$Model.ValidationWidgetRecord,
Input_NegotiatedExchangeRate_Accounting2: OS$Model.ValidationWidgetRecord,
TextArea_ExchangeRateComment2: OS$Model.ValidationWidgetRecord,
FormApplicant: OS$Model.ValidationWidgetRecord,
Input_Applicant: OS$Model.ValidationWidgetRecord,
Input_Society: OS$Model.ValidationWidgetRecord,
Input_Department: OS$Model.ValidationWidgetRecord,
Input_Region: OS$Model.ValidationWidgetRecord,
Input_Email: OS$Model.ValidationWidgetRecord
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
if("i_RequisitionId" in inputs) {
this.variables.i_RequisitionIdIn = DataConversion.ServerDataConverter.from(inputs.i_RequisitionId, OS$DataTypes.DataTypes.LongInteger);
}

if("i_IsUploadInvoice" in inputs) {
this.variables.i_IsUploadInvoiceIn = DataConversion.ServerDataConverter.from(inputs.i_IsUploadInvoice, OS$DataTypes.DataTypes.Boolean);
}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


