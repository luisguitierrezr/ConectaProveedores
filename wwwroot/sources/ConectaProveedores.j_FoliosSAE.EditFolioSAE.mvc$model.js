import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes, BuiltinFunctions as OS$BuiltinFunctions, DataConversion } from "@outsystems/runtime-core-js";
import { RC_d80dcf5f9effb79b8ba59dd1971d484d, RC_95110bc97f34f4c1561c8cbf2b5015b2, ST_1bddfac19e9b0cef65924aa7568fd106Structure, ST_aa3e6001f162e602247a2e2cc13e2cf8Structure } from "./ConectaProveedores.model.js";

class GetFolioByIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_d80dcf5f9effb79b8ba59dd1971d484d));
}
static fromStructure(str) {
return new GetFolioByIdAggrRec(new GetFolioByIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetFolioByIdAggrRec.init();

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


class GetOrderMainItemsDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("List", "listOut", "List", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_1bddfac19e9b0cef65924aa7568fd106Structure))());
}, true, (OS$GenericTypeCache.getGenericList(ST_1bddfac19e9b0cef65924aa7568fd106Structure)))
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new GetOrderMainItemsDataActRec(new GetOrderMainItemsDataActRec.RecordClass({
listOut: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetOrderMainItemsDataActRec.init();

class GetSettingsDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("IsActiveAmountValidation", "isActiveAmountValidationOut", "IsActiveAmountValidation", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("IsForceForeigner", "isForceForeignerOut", "IsForceForeigner", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("o_ForeignCurrencyMargin", "o_ForeignCurrencyMarginOut", "o_ForeignCurrencyMargin", true, false, OS$DataTypes.DataTypes.Decimal, function () {
return OS$BuiltinFunctions.integerToDecimal(10);
}, true), 
this.attr("o_NationalCurrencyMargin", "o_NationalCurrencyMarginOut", "o_NationalCurrencyMargin", true, false, OS$DataTypes.DataTypes.Decimal, function () {
return OS$BuiltinFunctions.integerToDecimal(10);
}, true), 
this.attr("o_IsActiveDEV_HU13008_Complement", "o_IsActiveDEV_HU13008_ComplementOut", "o_IsActiveDEV_HU13008_Complement", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("o_IsActiveDEV_HU13046", "o_IsActiveDEV_HU13046Out", "o_IsActiveDEV_HU13046", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("o_IsActiveDEV_NumeroDeFolioVisible", "o_IsActiveDEV_NumeroDeFolioVisibleOut", "o_IsActiveDEV_NumeroDeFolioVisible", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

}

GetSettingsDataActRec.init();


class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("l_Step", "l_StepVar", "l_Step", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 2;
}, false), 
this.attr("l_OrderIdSelected", "l_OrderIdSelectedVar", "l_OrderIdSelected", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("IsSelected", "isSelectedVar", "IsSelected", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("LocalSelectedLines", "localSelectedLinesVar", "LocalSelectedLines", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_aa3e6001f162e602247a2e2cc13e2cf8Structure))());
}, false, (OS$GenericTypeCache.getGenericList(ST_aa3e6001f162e602247a2e2cc13e2cf8Structure))), 
this.attr("l_IsSelectAll", "l_IsSelectAllVar", "l_IsSelectAll", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_IsShowSelectAll", "l_IsShowSelectAllVar", "l_IsShowSelectAll", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_OrderIdNumberSelected", "l_OrderIdNumberSelectedVar", "l_OrderIdNumberSelected", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("ShowPopup", "showPopupVar", "ShowPopup", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("FolioId", "folioIdIn", "FolioId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_folioIdInDataFetchStatus", "_folioIdInDataFetchStatus", "_folioIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetFolioById", "getFolioByIdAggr", "GetFolioById", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetFolioByIdAggrRec());
}, true, GetFolioByIdAggrRec), 
this.attr("GetFolioItemsByFolioId", "getFolioItemsByFolioIdAggr", "GetFolioItemsByFolioId", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetFolioItemsByFolioIdAggrRec());
}, true, GetFolioItemsByFolioIdAggrRec), 
this.attr("GetOrderMainItems", "getOrderMainItemsDataAct", "GetOrderMainItems", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetOrderMainItemsDataActRec());
}, true, GetOrderMainItemsDataActRec), 
this.attr("GetSettings", "getSettingsDataAct", "GetSettings", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetSettingsDataActRec());
}, true, GetSettingsDataActRec)
].concat(OS$DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS$Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {
CheckboxIsSelectAll: OS$Model.ValidationWidgetRecord,
CheckboxIsSelected: OS$Model.ValidationWidgetRecord
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
if("FolioId" in inputs) {
this.variables.folioIdIn = DataConversion.ServerDataConverter.from(inputs.FolioId, OS$DataTypes.DataTypes.LongInteger);
}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


