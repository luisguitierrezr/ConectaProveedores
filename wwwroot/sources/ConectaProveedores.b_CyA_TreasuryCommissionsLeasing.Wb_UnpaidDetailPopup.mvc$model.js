import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { RC_781b0cc57cc94effbff3496f8da9c758 } from "./ConectaProveedores.model.js";

class GetProposalLineByIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_781b0cc57cc94effbff3496f8da9c758));
}
static fromStructure(str) {
return new GetProposalLineByIdAggrRec(new GetProposalLineByIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetProposalLineByIdAggrRec.init();



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("i_ProposalLineId", "i_ProposalLineIdIn", "i_ProposalLineId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_i_ProposalLineIdInDataFetchStatus", "_i_ProposalLineIdInDataFetchStatus", "_i_ProposalLineIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetProposalLineById", "getProposalLineByIdAggr", "GetProposalLineById", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetProposalLineByIdAggrRec());
}, true, GetProposalLineByIdAggrRec)
].concat(OS$DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS$Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {
TextArea_Message: OS$Model.ValidationWidgetRecord,
Input_Filename: OS$Model.ValidationWidgetRecord
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
if("i_ProposalLineId" in inputs) {
this.variables.i_ProposalLineIdIn = inputs.i_ProposalLineId;
if("_i_ProposalLineIdInDataFetchStatus" in inputs) {
this.variables._i_ProposalLineIdInDataFetchStatus = inputs._i_ProposalLineIdInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


