import { Model as OS$Model, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";


class GetSettingsDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("AllowImport", "allowImportOut", "AllowImport", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new GetSettingsDataActRec(new GetSettingsDataActRec.RecordClass({
allowImportOut: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetSettingsDataActRec.init();


class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("l_FileContent", "l_FileContentVar", "l_FileContent", true, false, OS$DataTypes.DataTypes.BinaryData, function () {
return OS$DataTypes.BinaryData.defaultValue;
}, false), 
this.attr("l_FileName", "l_FileNameVar", "l_FileName", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("l_TabNumber", "l_TabNumberVar", "l_TabNumber", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("l_TableSort", "l_TableSortVar", "l_TableSort", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
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
Upload1: OS$Model.ValidationWidgetRecord
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


