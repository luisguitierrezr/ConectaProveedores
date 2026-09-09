import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes, DataConversion } from "@outsystems/runtime-core-js";
import { RC_931c5818c70fb94c867f1591b8f8bd0d, EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord, RC_30fde7bd8b6b69ef09faede048f7361d } from "./ConectaProveedores.model.js";

class GetProposalByIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_931c5818c70fb94c867f1591b8f8bd0d));
}
static fromStructure(str) {
return new GetProposalByIdAggrRec(new GetProposalByIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetProposalByIdAggrRec.init();

class GetProposalLinesByProposalIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord, {
name: "ProposalLine",
attrName: "proposalLineAttr",
nameForJson: "ProposalLine",
uniqueId: "cbff3912-7609-a0f8-30b2-d34948d1c019"
}))));
}
static fromStructure(str) {
return new GetProposalLinesByProposalIdAggrRec(new GetProposalLinesByProposalIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetProposalLinesByProposalIdAggrRec.init();

class GetFileImportLogsByFileIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_30fde7bd8b6b69ef09faede048f7361d));
}
static fromStructure(str) {
return new GetFileImportLogsByFileIdAggrRec(new GetFileImportLogsByFileIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetFileImportLogsByFileIdAggrRec.init();



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("TableSort", "tableSortVar", "TableSort", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("StartIndex", "startIndexVar", "StartIndex", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("DateTextFormatted", "dateTextFormattedVar", "DateTextFormatted", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("l_RefeshSideBar", "l_RefeshSideBarVar", "l_RefeshSideBar", true, false, OS$DataTypes.DataTypes.DateTime, function () {
return OS$DataTypes.DateTime.defaultValue;
}, false), 
this.attr("l_ReInvokeToggler", "l_ReInvokeTogglerVar", "l_ReInvokeToggler", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_ColumnJSONVarGetProposalDetailError", "l_ColumnJSONVarGetProposalDetailErrorVar", "l_ColumnJSONVarGetProposalDetailError", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("l_CountAfterFetchGetProposalDetailError", "l_CountAfterFetchGetProposalDetailErrorVar", "l_CountAfterFetchGetProposalDetailError", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("l_Loading", "l_LoadingVar", "l_Loading", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("i_ProposalId", "i_ProposalIdIn", "i_ProposalId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_i_ProposalIdInDataFetchStatus", "_i_ProposalIdInDataFetchStatus", "_i_ProposalIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetProposalById", "getProposalByIdAggr", "GetProposalById", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetProposalByIdAggrRec());
}, true, GetProposalByIdAggrRec), 
this.attr("GetProposalLinesByProposalId", "getProposalLinesByProposalIdAggr", "GetProposalLinesByProposalId", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetProposalLinesByProposalIdAggrRec());
}, true, GetProposalLinesByProposalIdAggrRec), 
this.attr("GetFileImportLogsByFileId", "getFileImportLogsByFileIdAggr", "GetFileImportLogsByFileId", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetFileImportLogsByFileIdAggrRec());
}, true, GetFileImportLogsByFileIdAggrRec)
].concat(OS$DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS$Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {
Input_Filename: OS$Model.ValidationWidgetRecord,
Input_ProposalType: OS$Model.ValidationWidgetRecord,
Input_PaymentDate: OS$Model.ValidationWidgetRecord,
Input_Bank: OS$Model.ValidationWidgetRecord,
Input_Name: OS$Model.ValidationWidgetRecord
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
if("i_ProposalId" in inputs) {
this.variables.i_ProposalIdIn = DataConversion.ServerDataConverter.from(inputs.i_ProposalId, OS$DataTypes.DataTypes.LongInteger);
}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


