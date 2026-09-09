import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { EN_c75b4bd59e1200fee3175175a6054340EntityRecord } from "./ConectaProveedores.model.js";

class GetCommentsByProposalIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_c75b4bd59e1200fee3175175a6054340EntityRecord, {
name: "ProposalComment",
attrName: "proposalCommentAttr",
nameForJson: "ProposalComment",
uniqueId: "cd5101cd-31ff-d8dc-09ae-caca6d77004a"
}))));
}
static fromStructure(str) {
return new GetCommentsByProposalIdAggrRec(new GetCommentsByProposalIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetCommentsByProposalIdAggrRec.init();



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("i_ProposalId", "i_ProposalIdIn", "i_ProposalId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_i_ProposalIdInDataFetchStatus", "_i_ProposalIdInDataFetchStatus", "_i_ProposalIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetCommentsByProposalId", "getCommentsByProposalIdAggr", "GetCommentsByProposalId", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetCommentsByProposalIdAggrRec());
}, true, GetCommentsByProposalIdAggrRec)
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
if("i_ProposalId" in inputs) {
this.variables.i_ProposalIdIn = inputs.i_ProposalId;
if("_i_ProposalIdInDataFetchStatus" in inputs) {
this.variables._i_ProposalIdInDataFetchStatus = inputs._i_ProposalIdInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


