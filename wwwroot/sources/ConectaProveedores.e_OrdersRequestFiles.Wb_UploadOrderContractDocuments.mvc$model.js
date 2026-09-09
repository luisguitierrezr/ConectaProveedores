import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { RC_f6cad939346a2d641ae33c13dbcb8a70, ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure, ST_1d6498da9105fbe815a7f766352917c0Structure } from "./ConectaProveedores.model.js";
import { ST_6f620840109ac6f721328b723ec0152cStructure } from "./Extension.ForeignInvoiceTextParserService.model.js";
import ConectaProveedores_y_Utils_Wb_CustomFileUpload_mvcModel from "./ConectaProveedores.y_Utils.Wb_CustomFileUpload.mvc$model.js";

class GetOrderContractFileByIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_f6cad939346a2d641ae33c13dbcb8a70));
}
static fromStructure(str) {
return new GetOrderContractFileByIdAggrRec(new GetOrderContractFileByIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetOrderContractFileByIdAggrRec.init();



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("InvoiceForeign", "invoiceForeignVar", "InvoiceForeign", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new ST_6f620840109ac6f721328b723ec0152cStructure());
}, false, ST_6f620840109ac6f721328b723ec0152cStructure), 
this.attr("AreFilesUploaded", "areFilesUploadedVar", "AreFilesUploaded", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("FilesList", "filesListVar", "FilesList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure))());
}, false, (OS$GenericTypeCache.getGenericList(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure))), 
this.attr("l_File", "l_FileVar", "l_File", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new ST_1d6498da9105fbe815a7f766352917c0Structure());
}, false, ST_1d6498da9105fbe815a7f766352917c0Structure), 
this.attr("l_FileEmpty", "l_FileEmptyVar", "l_FileEmpty", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new ST_1d6498da9105fbe815a7f766352917c0Structure());
}, false, ST_1d6498da9105fbe815a7f766352917c0Structure), 
this.attr("i_OrderMainId", "i_OrderMainIdIn", "i_OrderMainId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_i_OrderMainIdInDataFetchStatus", "_i_OrderMainIdInDataFetchStatus", "_i_OrderMainIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_OrderContractFile", "i_OrderContractFileIn", "i_OrderContractFile", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_i_OrderContractFileInDataFetchStatus", "_i_OrderContractFileInDataFetchStatus", "_i_OrderContractFileInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_OrderRequestFileId", "i_OrderRequestFileIdIn", "i_OrderRequestFileId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_i_OrderRequestFileIdInDataFetchStatus", "_i_OrderRequestFileIdInDataFetchStatus", "_i_OrderRequestFileIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetOrderContractFileById", "getOrderContractFileByIdAggr", "GetOrderContractFileById", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetOrderContractFileByIdAggrRec());
}, true, GetOrderContractFileByIdAggrRec)
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
if("i_OrderMainId" in inputs) {
this.variables.i_OrderMainIdIn = inputs.i_OrderMainId;
if("_i_OrderMainIdInDataFetchStatus" in inputs) {
this.variables._i_OrderMainIdInDataFetchStatus = inputs._i_OrderMainIdInDataFetchStatus;
}

}

if("i_OrderContractFile" in inputs) {
this.variables.i_OrderContractFileIn = inputs.i_OrderContractFile;
if("_i_OrderContractFileInDataFetchStatus" in inputs) {
this.variables._i_OrderContractFileInDataFetchStatus = inputs._i_OrderContractFileInDataFetchStatus;
}

}

if("i_OrderRequestFileId" in inputs) {
this.variables.i_OrderRequestFileIdIn = inputs.i_OrderRequestFileId;
if("_i_OrderRequestFileIdInDataFetchStatus" in inputs) {
this.variables._i_OrderRequestFileIdInDataFetchStatus = inputs._i_OrderRequestFileIdInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


