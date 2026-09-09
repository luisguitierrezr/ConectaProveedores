import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { RC_eb264c698175fb3dfb268b531134340c } from "./ConectaProveedores.model.js";

class GetCommentsByProposalLineApprovalLevelIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_eb264c698175fb3dfb268b531134340c));
}
static fromStructure(str) {
return new GetCommentsByProposalLineApprovalLevelIdAggrRec(new GetCommentsByProposalLineApprovalLevelIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetCommentsByProposalLineApprovalLevelIdAggrRec.init();



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("i_ProposalLineApprovalLevelId", "i_ProposalLineApprovalLevelIdIn", "i_ProposalLineApprovalLevelId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_i_ProposalLineApprovalLevelIdInDataFetchStatus", "_i_ProposalLineApprovalLevelIdInDataFetchStatus", "_i_ProposalLineApprovalLevelIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetCommentsByProposalLineApprovalLevelId", "getCommentsByProposalLineApprovalLevelIdAggr", "GetCommentsByProposalLineApprovalLevelId", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetCommentsByProposalLineApprovalLevelIdAggrRec());
}, true, GetCommentsByProposalLineApprovalLevelIdAggrRec)
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
if("i_ProposalLineApprovalLevelId" in inputs) {
this.variables.i_ProposalLineApprovalLevelIdIn = inputs.i_ProposalLineApprovalLevelId;
if("_i_ProposalLineApprovalLevelIdInDataFetchStatus" in inputs) {
this.variables._i_ProposalLineApprovalLevelIdInDataFetchStatus = inputs._i_ProposalLineApprovalLevelIdInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


