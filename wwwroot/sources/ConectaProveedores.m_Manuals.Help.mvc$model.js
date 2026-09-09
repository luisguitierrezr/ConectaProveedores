import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { RC_5e1572d574f8fe1e39bbadd50daaa59c } from "./ConectaProveedores.model.js";

class GetManualsAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_5e1572d574f8fe1e39bbadd50daaa59c));
}
static fromStructure(str) {
return new GetManualsAggrRec(new GetManualsAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetManualsAggrRec.init();


class GetUserInfoDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("IsAreaCxP", "isAreaCxPOut", "IsAreaCxP", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new GetUserInfoDataActRec(new GetUserInfoDataActRec.RecordClass({
isAreaCxPOut: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetUserInfoDataActRec.init();


class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Keyword", "keywordVar", "Keyword", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
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
this.attr("ShowPopup", "showPopupVar", "ShowPopup", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_ManualId", "l_ManualIdVar", "l_ManualId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("GetManuals", "getManualsAggr", "GetManuals", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetManualsAggrRec());
}, true, GetManualsAggrRec), 
this.attr("GetUserInfo", "getUserInfoDataAct", "GetUserInfo", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetUserInfoDataActRec());
}, true, GetUserInfoDataActRec)
].concat(OS$DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS$Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {
Input_TextVar: OS$Model.ValidationWidgetRecord
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
}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


