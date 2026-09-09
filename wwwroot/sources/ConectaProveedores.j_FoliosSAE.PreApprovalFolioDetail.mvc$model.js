import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes, BuiltinFunctions as OS$BuiltinFunctions, DataConversion } from "@outsystems/runtime-core-js";
import { RC_3c4405ea19e4fb66009c54078ab80e28, RC_8e32b78ccc2e260e65e10c5d6c59046d, RC_e40e190961051a83f0f95a5985af6cdd, RC_95110bc97f34f4c1561c8cbf2b5015b2, RC_06b38e19582fc855dd67cd4191332383, ST_e54bcdc56c6f092fdfed672ad024bfa4Structure } from "./ConectaProveedores.model.js";
import { EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord } from "./Organization.model.js";
import { EN_327b52812b8badb247bde4975c10d441EntityRecord } from "./Common.model.js";

class GetFolioByIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_3c4405ea19e4fb66009c54078ab80e28));
}
static fromStructure(str) {
return new GetFolioByIdAggrRec(new GetFolioByIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetFolioByIdAggrRec.init();

class GetOrderMainsAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_8e32b78ccc2e260e65e10c5d6c59046d));
}
static fromStructure(str) {
return new GetOrderMainsAggrRec(new GetOrderMainsAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetOrderMainsAggrRec.init();

class GetSuppliersAggrRec extends 
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
return new GetSuppliersAggrRec(new GetSuppliersAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetSuppliersAggrRec.init();

class GetFolioApprovalLevelsAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_e40e190961051a83f0f95a5985af6cdd));
}
static fromStructure(str) {
return new GetFolioApprovalLevelsAggrRec(new GetFolioApprovalLevelsAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetFolioApprovalLevelsAggrRec.init();

class GetFolioItemsByFolioIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_95110bc97f34f4c1561c8cbf2b5015b2));
}
static fromStructure(str) {
return new GetFolioItemsByFolioIdAggrRec(new GetFolioItemsByFolioIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetFolioItemsByFolioIdAggrRec.init();

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

class GetCompaniesAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_06b38e19582fc855dd67cd4191332383));
}
static fromStructure(str) {
return new GetCompaniesAggrRec(new GetCompaniesAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetCompaniesAggrRec.init();


class GetUserDataDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("o_Region", "o_RegionOut", "o_Region", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("o_IsCXP", "o_IsCXPOut", "o_IsCXP", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

}

GetUserDataDataActRec.init();


class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("l_RefreshOrderEntra_Historic", "l_RefreshOrderEntra_HistoricVar", "l_RefreshOrderEntra_Historic", true, false, OS$DataTypes.DataTypes.DateTime, function () {
return OS$BuiltinFunctions.currDateTime();
}, false), 
this.attr("TableSort", "tableSortVar", "TableSort", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("StartIndex", "startIndexVar", "StartIndex", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("MaxRecords", "maxRecordsVar", "MaxRecords", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 50;
}, false), 
this.attr("TableSort2", "tableSort2Var", "TableSort2", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("IsReadOnly2", "isReadOnly2Var", "IsReadOnly2", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("ShowCancelFolioPopup", "showCancelFolioPopupVar", "ShowCancelFolioPopup", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("IsExecuting", "isExecutingVar", "IsExecuting", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("FolioReject", "folioRejectVar", "FolioReject", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new ST_e54bcdc56c6f092fdfed672ad024bfa4Structure());
}, false, ST_e54bcdc56c6f092fdfed672ad024bfa4Structure), 
this.attr("I_CanReject", "i_CanRejectVar", "I_CanReject", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("I_CanCancelIncoice", "i_CanCancelIncoiceVar", "I_CanCancelIncoice", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("i_FolioId", "i_FolioIdIn", "i_FolioId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_i_FolioIdInDataFetchStatus", "_i_FolioIdInDataFetchStatus", "_i_FolioIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetFolioById", "getFolioByIdAggr", "GetFolioById", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetFolioByIdAggrRec());
}, true, GetFolioByIdAggrRec), 
this.attr("GetOrderMains", "getOrderMainsAggr", "GetOrderMains", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetOrderMainsAggrRec());
}, true, GetOrderMainsAggrRec), 
this.attr("GetSuppliers", "getSuppliersAggr", "GetSuppliers", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetSuppliersAggrRec());
}, true, GetSuppliersAggrRec), 
this.attr("GetFolioApprovalLevels", "getFolioApprovalLevelsAggr", "GetFolioApprovalLevels", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetFolioApprovalLevelsAggrRec());
}, true, GetFolioApprovalLevelsAggrRec), 
this.attr("GetFolioItemsByFolioId", "getFolioItemsByFolioIdAggr", "GetFolioItemsByFolioId", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetFolioItemsByFolioIdAggrRec());
}, true, GetFolioItemsByFolioIdAggrRec), 
this.attr("GetCurrencies", "getCurrenciesAggr", "GetCurrencies", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetCurrenciesAggrRec());
}, true, GetCurrenciesAggrRec), 
this.attr("GetCompanies", "getCompaniesAggr", "GetCompanies", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetCompaniesAggrRec());
}, true, GetCompaniesAggrRec), 
this.attr("GetUserData", "getUserDataDataAct", "GetUserData", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetUserDataDataActRec());
}, true, GetUserDataDataActRec)
].concat(OS$DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS$Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {
Input_FolioNumber2: OS$Model.ValidationWidgetRecord,
Dropdown7: OS$Model.ValidationWidgetRecord,
Dropdown8: OS$Model.ValidationWidgetRecord,
Dropdown9: OS$Model.ValidationWidgetRecord,
Dropdown3: OS$Model.ValidationWidgetRecord,
Input_TotalAmount2: OS$Model.ValidationWidgetRecord,
Input_TotalIVA_Amount2: OS$Model.ValidationWidgetRecord,
Input_FolioNumber: OS$Model.ValidationWidgetRecord,
Dropdown6: OS$Model.ValidationWidgetRecord,
Dropdown5: OS$Model.ValidationWidgetRecord,
Dropdown4: OS$Model.ValidationWidgetRecord,
Dropdown2: OS$Model.ValidationWidgetRecord,
Input_TotalAmount: OS$Model.ValidationWidgetRecord,
Input_TotalIVA_Amount: OS$Model.ValidationWidgetRecord,
Checkbox1: OS$Model.ValidationWidgetRecord,
Checkbox2: OS$Model.ValidationWidgetRecord,
Checkbox3: OS$Model.ValidationWidgetRecord,
Checkbox4: OS$Model.ValidationWidgetRecord,
TextArea_Reason: OS$Model.ValidationWidgetRecord
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
if("i_FolioId" in inputs) {
this.variables.i_FolioIdIn = DataConversion.ServerDataConverter.from(inputs.i_FolioId, OS$DataTypes.DataTypes.LongInteger);
}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


