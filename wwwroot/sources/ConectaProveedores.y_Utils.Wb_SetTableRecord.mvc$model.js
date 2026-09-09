import { Model as OS$Model, DataTypes as OS$DataTypes, GenericTypeCache as OS$GenericTypeCache } from "@outsystems/runtime-core-js";
import { RC_99fa4277b2264c97bde8f4525bdc92e0 } from "./ConectaProveedores.model.js";



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("RecordsList", "recordsListVar", "RecordsList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(RC_99fa4277b2264c97bde8f4525bdc92e0))());
}, false, (OS$GenericTypeCache.getGenericList(RC_99fa4277b2264c97bde8f4525bdc92e0))), 
this.attr("MaxRecords", "maxRecordsVar", "MaxRecords", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false)
].concat(OS$DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS$Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {
Dropdown1: OS$Model.ValidationWidgetRecord
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


