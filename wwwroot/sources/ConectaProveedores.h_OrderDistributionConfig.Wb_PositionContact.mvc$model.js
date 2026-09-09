import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord } from "./SecurityAuth.model.js";

class GetAllPositionContactsAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord, {
name: "EntraRole",
attrName: "entraRoleAttr",
nameForJson: "EntraRole",
uniqueId: "3ae851ff-8b62-d3b4-ff80-41de781ce47d"
}))));
}
static fromStructure(str) {
return new GetAllPositionContactsAggrRec(new GetAllPositionContactsAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetAllPositionContactsAggrRec.init();

class GetPositionContactsByIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord, {
name: "EntraRole",
attrName: "entraRoleAttr",
nameForJson: "EntraRole",
uniqueId: "3ae851ff-8b62-d3b4-ff80-41de781ce47d"
}))));
}
static fromStructure(str) {
return new GetPositionContactsByIdAggrRec(new GetPositionContactsByIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetPositionContactsByIdAggrRec.init();



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("AddNew", "addNewVar", "AddNew", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("Editable", "editableVar", "Editable", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("NewPositionContact", "newPositionContactVar", "NewPositionContact", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("PositionContactId", "positionContactIdIn", "PositionContactId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_positionContactIdInDataFetchStatus", "_positionContactIdInDataFetchStatus", "_positionContactIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("Label", "labelIn", "Label", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_labelInDataFetchStatus", "_labelInDataFetchStatus", "_labelInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("ReadOnly", "readOnlyIn", "ReadOnly", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_readOnlyInDataFetchStatus", "_readOnlyInDataFetchStatus", "_readOnlyInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("ShowLabelFirst", "showLabelFirstIn", "ShowLabelFirst", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return true;
}, false), 
this.attr("_showLabelFirstInDataFetchStatus", "_showLabelFirstInDataFetchStatus", "_showLabelFirstInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("AllowAddNew", "allowAddNewIn", "AllowAddNew", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_allowAddNewInDataFetchStatus", "_allowAddNewInDataFetchStatus", "_allowAddNewInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("IsMandatory", "isMandatoryIn", "IsMandatory", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_isMandatoryInDataFetchStatus", "_isMandatoryInDataFetchStatus", "_isMandatoryInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetAllPositionContacts", "getAllPositionContactsAggr", "GetAllPositionContacts", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetAllPositionContactsAggrRec());
}, true, GetAllPositionContactsAggrRec), 
this.attr("GetPositionContactsById", "getPositionContactsByIdAggr", "GetPositionContactsById", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetPositionContactsByIdAggrRec());
}, true, GetPositionContactsByIdAggrRec)
].concat(OS$DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS$Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {
InputPositionContact: OS$Model.ValidationWidgetRecord
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
if("PositionContactId" in inputs) {
this.variables.positionContactIdIn = inputs.PositionContactId;
if("_positionContactIdInDataFetchStatus" in inputs) {
this.variables._positionContactIdInDataFetchStatus = inputs._positionContactIdInDataFetchStatus;
}

}

if("Label" in inputs) {
this.variables.labelIn = inputs.Label;
if("_labelInDataFetchStatus" in inputs) {
this.variables._labelInDataFetchStatus = inputs._labelInDataFetchStatus;
}

}

if("ReadOnly" in inputs) {
this.variables.readOnlyIn = inputs.ReadOnly;
if("_readOnlyInDataFetchStatus" in inputs) {
this.variables._readOnlyInDataFetchStatus = inputs._readOnlyInDataFetchStatus;
}

}

if("ShowLabelFirst" in inputs) {
this.variables.showLabelFirstIn = inputs.ShowLabelFirst;
if("_showLabelFirstInDataFetchStatus" in inputs) {
this.variables._showLabelFirstInDataFetchStatus = inputs._showLabelFirstInDataFetchStatus;
}

}

if("AllowAddNew" in inputs) {
this.variables.allowAddNewIn = inputs.AllowAddNew;
if("_allowAddNewInDataFetchStatus" in inputs) {
this.variables._allowAddNewInDataFetchStatus = inputs._allowAddNewInDataFetchStatus;
}

}

if("IsMandatory" in inputs) {
this.variables.isMandatoryIn = inputs.IsMandatory;
if("_isMandatoryInDataFetchStatus" in inputs) {
this.variables._isMandatoryInDataFetchStatus = inputs._isMandatoryInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


