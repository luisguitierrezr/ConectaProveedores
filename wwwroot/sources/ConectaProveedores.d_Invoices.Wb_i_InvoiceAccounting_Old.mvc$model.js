import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes, BuiltinFunctions as OS$BuiltinFunctions } from "@outsystems/runtime-core-js";
import { EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord, EN_efc751d189a1545503ba31ced5225e86EntityRecord, EN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord, EN_17720044fda96c0c2d8d0760c429f48aEntityRecord, EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord, EN_31f501c551d210017fcb34b5237e3390EntityRecord } from "./Organization.model.js";
import { EN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord, RC_eac76b624d2264108f6fbeb95d9d43ba, EN_f81a3d226103fd013068b8763798067aEntityRecord, EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord, EN_a9440c310249b67518f0615139b4c690EntityRecord, RC_f4d76e3d3fccb22411e2fbf1d069c4d1, ST_d9cd2417d7f5e39d5d950b6b6b9d1f5cStructure, EN_66fb76d3fab58a693a3c750c022bd4efEntityRecord } from "./ConectaProveedores.model.js";

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

class GetInvoiceRetentionsByInvoiceIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord, {
name: "InvoiceExtendedTax",
attrName: "invoiceExtendedTaxAttr",
nameForJson: "InvoiceExtendedTax",
uniqueId: "965912af-30c7-fbb7-316f-17bf8e331782"
}))));
}
static fromStructure(str) {
return new GetInvoiceRetentionsByInvoiceIdAggrRec(new GetInvoiceRetentionsByInvoiceIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetInvoiceRetentionsByInvoiceIdAggrRec.init();

class GetTaxIndicatorsAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_efc751d189a1545503ba31ced5225e86EntityRecord, {
name: "TaxIndicator",
attrName: "taxIndicatorAttr",
nameForJson: "TaxIndicator",
uniqueId: "680b4f2b-38f7-607d-61fa-f8ef68fd2613"
}))));
}
static fromStructure(str) {
return new GetTaxIndicatorsAggrRec(new GetTaxIndicatorsAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetTaxIndicatorsAggrRec.init();

class GetInvoiceApprovalAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_eac76b624d2264108f6fbeb95d9d43ba));
}
static fromStructure(str) {
return new GetInvoiceApprovalAggrRec(new GetInvoiceApprovalAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetInvoiceApprovalAggrRec.init();

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

class GetInvoiceExtendedByIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_f81a3d226103fd013068b8763798067aEntityRecord, {
name: "InvoiceExtended",
attrName: "invoiceExtendedAttr",
nameForJson: "InvoiceExtended",
uniqueId: "fbe3f105-0ad4-f34f-a0e0-a15f88a56873"
}))));
}
static fromStructure(str) {
return new GetInvoiceExtendedByIdAggrRec(new GetInvoiceExtendedByIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetInvoiceExtendedByIdAggrRec.init();

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

class GetRegionsAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_31f501c551d210017fcb34b5237e3390EntityRecord, {
name: "Region",
attrName: "regionAttr",
nameForJson: "Region",
uniqueId: "deb85dc3-6640-fa92-8dae-5df2493065d0"
}))));
}
static fromStructure(str) {
return new GetRegionsAggrRec(new GetRegionsAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetRegionsAggrRec.init();

class GetInvoiceAccountingsByInvoiceIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord, {
name: "InvoiceAccounting",
attrName: "invoiceAccountingAttr",
nameForJson: "InvoiceAccounting",
uniqueId: "c398a83e-a7d1-0988-6e6b-e693f6d07867"
}))));
}
static fromStructure(str) {
return new GetInvoiceAccountingsByInvoiceIdAggrRec(new GetInvoiceAccountingsByInvoiceIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetInvoiceAccountingsByInvoiceIdAggrRec.init();

class GetInvoiceExtendedMoreChargesByInvoiceIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_a9440c310249b67518f0615139b4c690EntityRecord, {
name: "InvoiceExtendedMoreCharges",
attrName: "invoiceExtendedMoreChargesAttr",
nameForJson: "InvoiceExtendedMoreCharges",
uniqueId: "152a5bcd-bf97-0bfb-a2a0-da40766a2168"
}))));
}
static fromStructure(str) {
return new GetInvoiceExtendedMoreChargesByInvoiceIdAggrRec(new GetInvoiceExtendedMoreChargesByInvoiceIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetInvoiceExtendedMoreChargesByInvoiceIdAggrRec.init();

class GetInvoiceExtendedTaxsByInvoiceIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_f4d76e3d3fccb22411e2fbf1d069c4d1));
}
static fromStructure(str) {
return new GetInvoiceExtendedTaxsByInvoiceIdAggrRec(new GetInvoiceExtendedTaxsByInvoiceIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetInvoiceExtendedTaxsByInvoiceIdAggrRec.init();


class GetDataDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("IsAnticipoWithInv", "isAnticipoWithInvOut", "IsAnticipoWithInv", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("IsLastLevel", "isLastLevelOut", "IsLastLevel", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

}

GetDataDataActRec.init();

class GetInvoiceAccountingDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("o_List", "o_ListOut", "o_List", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_d9cd2417d7f5e39d5d950b6b6b9d1f5cStructure))());
}, true, (OS$GenericTypeCache.getGenericList(ST_d9cd2417d7f5e39d5d950b6b6b9d1f5cStructure))), 
this.attr("o_InvoiceAccountingId", "o_InvoiceAccountingIdOut", "o_InvoiceAccountingId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, true)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

}

GetInvoiceAccountingDataActRec.init();


class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("l_Iva", "l_IvaVar", "l_Iva", true, false, OS$DataTypes.DataTypes.Decimal, function () {
return OS$BuiltinFunctions.integerToDecimal(0);
}, false), 
this.attr("l_ShowImportPopup", "l_ShowImportPopupVar", "l_ShowImportPopup", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_ShowApprovalInvoice", "l_ShowApprovalInvoiceVar", "l_ShowApprovalInvoice", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_ShowCancelInvoice", "l_ShowCancelInvoiceVar", "l_ShowCancelInvoice", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_ShowModifyPopup", "l_ShowModifyPopupVar", "l_ShowModifyPopup", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_IsApproval", "l_IsApprovalVar", "l_IsApproval", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_IsImport", "l_IsImportVar", "l_IsImport", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_InvoiceAccountingEntries", "l_InvoiceAccountingEntriesVar", "l_InvoiceAccountingEntries", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(EN_66fb76d3fab58a693a3c750c022bd4efEntityRecord))());
}, false, (OS$GenericTypeCache.getGenericList(EN_66fb76d3fab58a693a3c750c022bd4efEntityRecord))), 
this.attr("i_InvoiceId", "i_InvoiceIdIn", "i_InvoiceId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_i_InvoiceIdInDataFetchStatus", "_i_InvoiceIdInDataFetchStatus", "_i_InvoiceIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_RequisitionId", "i_RequisitionIdIn", "i_RequisitionId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_i_RequisitionIdInDataFetchStatus", "_i_RequisitionIdInDataFetchStatus", "_i_RequisitionIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("IsActiveUser", "isActiveUserIn", "IsActiveUser", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_isActiveUserInDataFetchStatus", "_isActiveUserInDataFetchStatus", "_isActiveUserInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("IsCorp", "isCorpIn", "IsCorp", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_isCorpInDataFetchStatus", "_isCorpInDataFetchStatus", "_isCorpInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("SupplierNumber", "supplierNumberIn", "SupplierNumber", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_supplierNumberInDataFetchStatus", "_supplierNumberInDataFetchStatus", "_supplierNumberInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetCostCenters", "getCostCentersAggr", "GetCostCenters", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetCostCentersAggrRec());
}, true, GetCostCentersAggrRec), 
this.attr("GetInvoiceRetentionsByInvoiceId", "getInvoiceRetentionsByInvoiceIdAggr", "GetInvoiceRetentionsByInvoiceId", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetInvoiceRetentionsByInvoiceIdAggrRec());
}, true, GetInvoiceRetentionsByInvoiceIdAggrRec), 
this.attr("GetTaxIndicators", "getTaxIndicatorsAggr", "GetTaxIndicators", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetTaxIndicatorsAggrRec());
}, true, GetTaxIndicatorsAggrRec), 
this.attr("GetInvoiceApproval", "getInvoiceApprovalAggr", "GetInvoiceApproval", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetInvoiceApprovalAggrRec());
}, true, GetInvoiceApprovalAggrRec), 
this.attr("GetPaymentMethods", "getPaymentMethodsAggr", "GetPaymentMethods", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetPaymentMethodsAggrRec());
}, true, GetPaymentMethodsAggrRec), 
this.attr("GetPaymentTerms", "getPaymentTermsAggr", "GetPaymentTerms", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetPaymentTermsAggrRec());
}, true, GetPaymentTermsAggrRec), 
this.attr("GetInvoiceExtendedById", "getInvoiceExtendedByIdAggr", "GetInvoiceExtendedById", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetInvoiceExtendedByIdAggrRec());
}, true, GetInvoiceExtendedByIdAggrRec), 
this.attr("GetAccountingAccountsServiceTypes", "getAccountingAccountsServiceTypesAggr", "GetAccountingAccountsServiceTypes", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetAccountingAccountsServiceTypesAggrRec());
}, true, GetAccountingAccountsServiceTypesAggrRec), 
this.attr("GetRegions", "getRegionsAggr", "GetRegions", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetRegionsAggrRec());
}, true, GetRegionsAggrRec), 
this.attr("GetInvoiceAccountingsByInvoiceId", "getInvoiceAccountingsByInvoiceIdAggr", "GetInvoiceAccountingsByInvoiceId", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetInvoiceAccountingsByInvoiceIdAggrRec());
}, true, GetInvoiceAccountingsByInvoiceIdAggrRec), 
this.attr("GetInvoiceExtendedMoreChargesByInvoiceId", "getInvoiceExtendedMoreChargesByInvoiceIdAggr", "GetInvoiceExtendedMoreChargesByInvoiceId", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetInvoiceExtendedMoreChargesByInvoiceIdAggrRec());
}, true, GetInvoiceExtendedMoreChargesByInvoiceIdAggrRec), 
this.attr("GetInvoiceExtendedTaxsByInvoiceId", "getInvoiceExtendedTaxsByInvoiceIdAggr", "GetInvoiceExtendedTaxsByInvoiceId", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetInvoiceExtendedTaxsByInvoiceIdAggrRec());
}, true, GetInvoiceExtendedTaxsByInvoiceIdAggrRec), 
this.attr("GetData", "getDataDataAct", "GetData", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetDataDataActRec());
}, true, GetDataDataActRec), 
this.attr("GetInvoiceAccounting", "getInvoiceAccountingDataAct", "GetInvoiceAccounting", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetInvoiceAccountingDataActRec());
}, true, GetInvoiceAccountingDataActRec)
].concat(OS$DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS$Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {
Form1: OS$Model.ValidationWidgetRecord,
TextArea_FreeText2: OS$Model.ValidationWidgetRecord,
TextArea_FreeText: OS$Model.ValidationWidgetRecord,
Dropdown_Divison2: OS$Model.ValidationWidgetRecord,
Dropdown_Divison3: OS$Model.ValidationWidgetRecord,
Dropdown_Iva: OS$Model.ValidationWidgetRecord,
Dropdown_Iva2: OS$Model.ValidationWidgetRecord,
Input_Amount: OS$Model.ValidationWidgetRecord,
Input_ServiceTotalAmount: OS$Model.ValidationWidgetRecord,
Dropdown_PaymentMethodId: OS$Model.ValidationWidgetRecord,
Dropdown_PaymentTermsId: OS$Model.ValidationWidgetRecord,
Input_ICME: OS$Model.ValidationWidgetRecord,
Input_ICME2: OS$Model.ValidationWidgetRecord,
Input_ConceptName: OS$Model.ValidationWidgetRecord,
Input_Iva2: OS$Model.ValidationWidgetRecord,
Input_ConceptOutput: OS$Model.ValidationWidgetRecord,
Input_SubTotal: OS$Model.ValidationWidgetRecord,
Input_Retencions: OS$Model.ValidationWidgetRecord,
Input_TotalAmount: OS$Model.ValidationWidgetRecord
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
if("i_InvoiceId" in inputs) {
this.variables.i_InvoiceIdIn = inputs.i_InvoiceId;
if("_i_InvoiceIdInDataFetchStatus" in inputs) {
this.variables._i_InvoiceIdInDataFetchStatus = inputs._i_InvoiceIdInDataFetchStatus;
}

}

if("i_RequisitionId" in inputs) {
this.variables.i_RequisitionIdIn = inputs.i_RequisitionId;
if("_i_RequisitionIdInDataFetchStatus" in inputs) {
this.variables._i_RequisitionIdInDataFetchStatus = inputs._i_RequisitionIdInDataFetchStatus;
}

}

if("IsActiveUser" in inputs) {
this.variables.isActiveUserIn = inputs.IsActiveUser;
if("_isActiveUserInDataFetchStatus" in inputs) {
this.variables._isActiveUserInDataFetchStatus = inputs._isActiveUserInDataFetchStatus;
}

}

if("IsCorp" in inputs) {
this.variables.isCorpIn = inputs.IsCorp;
if("_isCorpInDataFetchStatus" in inputs) {
this.variables._isCorpInDataFetchStatus = inputs._isCorpInDataFetchStatus;
}

}

if("SupplierNumber" in inputs) {
this.variables.supplierNumberIn = inputs.SupplierNumber;
if("_supplierNumberInDataFetchStatus" in inputs) {
this.variables._supplierNumberInDataFetchStatus = inputs._supplierNumberInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


