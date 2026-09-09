import { Model as OS$Model, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("SupplierType", "supplierTypeVar", "SupplierType", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("i_SupplierCountry", "i_SupplierCountryIn", "i_SupplierCountry", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_i_SupplierCountryInDataFetchStatus", "_i_SupplierCountryInDataFetchStatus", "_i_SupplierCountryInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("I_SupplierId", "i_SupplierIdIn", "I_SupplierId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_i_SupplierIdInDataFetchStatus", "_i_SupplierIdInDataFetchStatus", "_i_SupplierIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false)
].concat(OS$DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS$Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {
Input_SupplierType: OS$Model.ValidationWidgetRecord
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
if("i_SupplierCountry" in inputs) {
this.variables.i_SupplierCountryIn = inputs.i_SupplierCountry;
if("_i_SupplierCountryInDataFetchStatus" in inputs) {
this.variables._i_SupplierCountryInDataFetchStatus = inputs._i_SupplierCountryInDataFetchStatus;
}

}

if("I_SupplierId" in inputs) {
this.variables.i_SupplierIdIn = inputs.I_SupplierId;
if("_i_SupplierIdInDataFetchStatus" in inputs) {
this.variables._i_SupplierIdInDataFetchStatus = inputs._i_SupplierIdInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


