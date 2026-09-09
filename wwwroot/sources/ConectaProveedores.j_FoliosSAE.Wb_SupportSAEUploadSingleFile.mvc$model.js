import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { RC_187912d0df64c67be181be3d4f7af5f3, ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure, ST_1d6498da9105fbe815a7f766352917c0Structure } from "./ConectaProveedores.model.js";
import ConectaProveedores_y_Utils_Wb_CustomFileUpload_mvcModel from "./ConectaProveedores.y_Utils.Wb_CustomFileUpload.mvc$model.js";

class GetSupplierUsersByUserIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_187912d0df64c67be181be3d4f7af5f3));
}
static fromStructure(str) {
return new GetSupplierUsersByUserIdAggrRec(new GetSupplierUsersByUserIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetSupplierUsersByUserIdAggrRec.init();



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("FilesList", "filesListVar", "FilesList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure))());
}, false, (OS$GenericTypeCache.getGenericList(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure))), 
this.attr("l_File", "l_FileVar", "l_File", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new ST_1d6498da9105fbe815a7f766352917c0Structure());
}, false, ST_1d6498da9105fbe815a7f766352917c0Structure), 
this.attr("AreFilesUploaded", "areFilesUploadedVar", "AreFilesUploaded", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_FileEmpty", "l_FileEmptyVar", "l_FileEmpty", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new ST_1d6498da9105fbe815a7f766352917c0Structure());
}, false, ST_1d6498da9105fbe815a7f766352917c0Structure), 
this.attr("GetSupplierUsersByUserId", "getSupplierUsersByUserIdAggr", "GetSupplierUsersByUserId", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetSupplierUsersByUserIdAggrRec());
}, true, GetSupplierUsersByUserIdAggrRec)
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

static get hasValidationWidgets() {if((Model._hasValidationWidgetsValue === undefined)) {
Model._hasValidationWidgetsValue = ConectaProveedores_y_Utils_Wb_CustomFileUpload_mvcModel.hasValidationWidgets;
}

return Model._hasValidationWidgetsValue;
}
setInputs(inputs) {
}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


