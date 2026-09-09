import { Model as OS$Model, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("i_Value", "i_ValueIn", "i_Value", true, false, OS$DataTypes.DataTypes.Decimal, function () {
return OS$DataTypes.Decimal.defaultValue;
}, false), 
this.attr("_i_ValueInDataFetchStatus", "_i_ValueInDataFetchStatus", "_i_ValueInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_Currency", "i_CurrencyIn", "i_Currency", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_i_CurrencyInDataFetchStatus", "_i_CurrencyInDataFetchStatus", "_i_CurrencyInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
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
if("i_Value" in inputs) {
this.variables.i_ValueIn = inputs.i_Value;
if("_i_ValueInDataFetchStatus" in inputs) {
this.variables._i_ValueInDataFetchStatus = inputs._i_ValueInDataFetchStatus;
}

}

if("i_Currency" in inputs) {
this.variables.i_CurrencyIn = inputs.i_Currency;
if("_i_CurrencyInDataFetchStatus" in inputs) {
this.variables._i_CurrencyInDataFetchStatus = inputs._i_CurrencyInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


