import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord, RC_4c9ca09958a3ee4cb990399bb84ebebd } from "./ConectaProveedores.model.js";

class GetFolioStatusAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord, {
name: "FolioStatus",
attrName: "folioStatusAttr",
nameForJson: "FolioStatus",
uniqueId: "c75df7b2-e7c6-e74a-3a45-dda7bd7b93e2"
}))));
}
static fromStructure(str) {
return new GetFolioStatusAggrRec(new GetFolioStatusAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetFolioStatusAggrRec.init();

class GetDataAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_4c9ca09958a3ee4cb990399bb84ebebd));
}
static fromStructure(str) {
return new GetDataAggrRec(new GetDataAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetDataAggrRec.init();



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("i_StartIndex", "i_StartIndexVar", "i_StartIndex", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("i_TableSort", "i_TableSortVar", "i_TableSort", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("i_ReInvokeToggler", "i_ReInvokeTogglerVar", "i_ReInvokeToggler", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("i_ColumnsListInJSON", "i_ColumnsListInJSONVar", "i_ColumnsListInJSON", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("GetFolioStatus", "getFolioStatusAggr", "GetFolioStatus", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetFolioStatusAggrRec());
}, true, GetFolioStatusAggrRec), 
this.attr("GetData", "getDataAggr", "GetData", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetDataAggrRec());
}, true, GetDataAggrRec)
].concat(OS$DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS$Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {
InputSearch_OrderNumber: OS$Model.ValidationWidgetRecord,
InputSearch_FolioNumber: OS$Model.ValidationWidgetRecord,
Dropdown_FolioStatus: OS$Model.ValidationWidgetRecord,
InputSearch_SAPError2: OS$Model.ValidationWidgetRecord
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


