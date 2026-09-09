import { Model as OS$Model, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { ST_26711e61541f079fb4510d8f9bfa1e3dStructure } from "./ConectaProveedores.model.js";


class GetsRequisitionsDataDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("o_RequisitionCreatedLog", "o_RequisitionCreatedLogOut", "o_RequisitionCreatedLog", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new ST_26711e61541f079fb4510d8f9bfa1e3dStructure());
}, true, ST_26711e61541f079fb4510d8f9bfa1e3dStructure)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new GetsRequisitionsDataDataActRec(new GetsRequisitionsDataDataActRec.RecordClass({
o_RequisitionCreatedLogOut: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetsRequisitionsDataDataActRec.init();


class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("RequisitionId", "requisitionIdIn", "RequisitionId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_requisitionIdInDataFetchStatus", "_requisitionIdInDataFetchStatus", "_requisitionIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetsRequisitionsData", "getsRequisitionsDataDataAct", "GetsRequisitionsData", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetsRequisitionsDataDataActRec());
}, true, GetsRequisitionsDataDataActRec)
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
if("RequisitionId" in inputs) {
this.variables.requisitionIdIn = inputs.RequisitionId;
if("_requisitionIdInDataFetchStatus" in inputs) {
this.variables._requisitionIdInDataFetchStatus = inputs._requisitionIdInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


