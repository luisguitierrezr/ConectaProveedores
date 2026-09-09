import { Model as OS$Model, DataTypes as OS$DataTypes, GenericTypeCache as OS$GenericTypeCache } from "@outsystems/runtime-core-js";
import { ST_37a6487c1fae199ee92f583d495139beStructure } from "./ConectaProveedores.model.js";
import { ST_b1b6df219277397c7c2be747d587880aStructure } from "./Organization.model.js";



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Selection", "selectionVar", "Selection", true, false, OS$DataTypes.DataTypes.Text, function () {
return "1";
}, false), 
this.attr("BinaryDataVar", "binaryDataVarVar", "BinaryDataVar", true, false, OS$DataTypes.DataTypes.BinaryData, function () {
return OS$DataTypes.BinaryData.defaultValue;
}, false), 
this.attr("TextVar", "textVarVar", "TextVar", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("OutputList", "outputListVar", "OutputList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_37a6487c1fae199ee92f583d495139beStructure))());
}, false, (OS$GenericTypeCache.getGenericList(ST_37a6487c1fae199ee92f583d495139beStructure))), 
this.attr("Return", "returnVar", "Return", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new ST_b1b6df219277397c7c2be747d587880aStructure());
}, false, ST_b1b6df219277397c7c2be747d587880aStructure), 
this.attr("StorageId", "storageIdVar", "StorageId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("ShowdownloadPopup", "showdownloadPopupVar", "ShowdownloadPopup", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("IsSelectOne", "isSelectOneVar", "IsSelectOne", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("ForceRefresh", "forceRefreshVar", "ForceRefresh", true, false, OS$DataTypes.DataTypes.DateTime, function () {
return OS$DataTypes.DateTime.defaultValue;
}, false)
].concat(OS$DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS$Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {
RadioGroup2: OS$Model.ValidationWidgetRecord,
Upload1: OS$Model.ValidationWidgetRecord,
Checkbox1: OS$Model.ValidationWidgetRecord
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


