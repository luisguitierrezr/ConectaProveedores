import { Model as OS$Model, DataTypes as OS$DataTypes, BuiltinFunctions as OS$BuiltinFunctions } from "@outsystems/runtime-core-js";



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("Sum", "sumVar", "Sum", true, false, OS$DataTypes.DataTypes.Decimal, function () {
return OS$BuiltinFunctions.integerToDecimal(0);
}, false), 
this.attr("ListOfValues", "listOfValuesIn", "ListOfValues", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new OS$DataTypes.DecimalList());
}, false, OS$DataTypes.DecimalList), 
this.attr("_listOfValuesInDataFetchStatus", "_listOfValuesInDataFetchStatus", "_listOfValuesInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
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
if("ListOfValues" in inputs) {
this.variables.listOfValuesIn = inputs.ListOfValues;
if("_listOfValuesInDataFetchStatus" in inputs) {
this.variables._listOfValuesInDataFetchStatus = inputs._listOfValuesInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


