import { Model as OS$Model, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { ST_26711e61541f079fb4510d8f9bfa1e3dStructure } from "./ConectaProveedores.model.js";


class GetsOrdersDataDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("o_OrderCreatedLog", "o_OrderCreatedLogOut", "o_OrderCreatedLog", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new ST_26711e61541f079fb4510d8f9bfa1e3dStructure());
}, true, ST_26711e61541f079fb4510d8f9bfa1e3dStructure)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new GetsOrdersDataDataActRec(new GetsOrdersDataDataActRec.RecordClass({
o_OrderCreatedLogOut: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetsOrdersDataDataActRec.init();


class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("OrderMainId", "orderMainIdIn", "OrderMainId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_orderMainIdInDataFetchStatus", "_orderMainIdInDataFetchStatus", "_orderMainIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetsOrdersData", "getsOrdersDataDataAct", "GetsOrdersData", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetsOrdersDataDataActRec());
}, true, GetsOrdersDataDataActRec)
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
if("OrderMainId" in inputs) {
this.variables.orderMainIdIn = inputs.OrderMainId;
if("_orderMainIdInDataFetchStatus" in inputs) {
this.variables._orderMainIdInDataFetchStatus = inputs._orderMainIdInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


