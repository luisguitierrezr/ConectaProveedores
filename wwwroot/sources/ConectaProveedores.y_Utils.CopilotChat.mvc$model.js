import { Model as OS$Model, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Initiative", "initiativeIn", "Initiative", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_initiativeInDataFetchStatus", "_initiativeInDataFetchStatus", "_initiativeInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false)
].concat(OS$DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS$Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {};
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

static get hasValidationWidgets() {return false;
}
setInputs(inputs) {
if("Initiative" in inputs) {
this.variables.initiativeIn = inputs.Initiative;
if("_initiativeInDataFetchStatus" in inputs) {
this.variables._initiativeInDataFetchStatus = inputs._initiativeInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


