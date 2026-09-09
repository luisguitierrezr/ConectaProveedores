import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord, RC_f71d1ebfeb3771da2f91490300d5ded2 } from "./ConectaProveedores.model.js";

class GetFolioStatusesAggrRec extends 
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
return new GetFolioStatusesAggrRec(new GetFolioStatusesAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetFolioStatusesAggrRec.init();

class GetFolioApprovalLevelsByAssignedToAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_f71d1ebfeb3771da2f91490300d5ded2));
}
static fromStructure(str) {
return new GetFolioApprovalLevelsByAssignedToAggrRec(new GetFolioApprovalLevelsByAssignedToAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetFolioApprovalLevelsByAssignedToAggrRec.init();


class GetUserDataDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("o_IsUserCxP", "o_IsUserCxPOut", "o_IsUserCxP", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new GetUserDataDataActRec(new GetUserDataDataActRec.RecordClass({
o_IsUserCxPOut: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetUserDataDataActRec.init();


class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("l_ColumnJSONVar", "l_ColumnJSONVarVar", "l_ColumnJSONVar", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("l_CountAfterFetch", "l_CountAfterFetchVar", "l_CountAfterFetch", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("l_ReInvokeToggler", "l_ReInvokeTogglerVar", "l_ReInvokeToggler", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_StartIndex", "l_StartIndexVar", "l_StartIndex", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("l_TableSort", "l_TableSortVar", "l_TableSort", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("GetFolioStatuses", "getFolioStatusesAggr", "GetFolioStatuses", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetFolioStatusesAggrRec());
}, true, GetFolioStatusesAggrRec), 
this.attr("GetFolioApprovalLevelsByAssignedTo", "getFolioApprovalLevelsByAssignedToAggr", "GetFolioApprovalLevelsByAssignedTo", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetFolioApprovalLevelsByAssignedToAggrRec());
}, true, GetFolioApprovalLevelsByAssignedToAggrRec), 
this.attr("GetUserData", "getUserDataDataAct", "GetUserData", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetUserDataDataActRec());
}, true, GetUserDataDataActRec)
].concat(OS$DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS$Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {
Input_Search: OS$Model.ValidationWidgetRecord,
Input_Search2: OS$Model.ValidationWidgetRecord,
Dropdown_Status: OS$Model.ValidationWidgetRecord
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


