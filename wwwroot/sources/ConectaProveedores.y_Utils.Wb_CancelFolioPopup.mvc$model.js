import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { RC_e40e190961051a83f0f95a5985af6cdd, RC_b668eee4846e2937101a51355804499d, ST_e54bcdc56c6f092fdfed672ad024bfa4Structure } from "./ConectaProveedores.model.js";

class GetFolioApprovalLevelsAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_e40e190961051a83f0f95a5985af6cdd));
}
static fromStructure(str) {
return new GetFolioApprovalLevelsAggrRec(new GetFolioApprovalLevelsAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetFolioApprovalLevelsAggrRec.init();

class GetFolioByIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_b668eee4846e2937101a51355804499d));
}
static fromStructure(str) {
return new GetFolioByIdAggrRec(new GetFolioByIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetFolioByIdAggrRec.init();



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("FolioReject", "folioRejectVar", "FolioReject", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new ST_e54bcdc56c6f092fdfed672ad024bfa4Structure());
}, false, ST_e54bcdc56c6f092fdfed672ad024bfa4Structure), 
this.attr("IsExecuting", "isExecutingVar", "IsExecuting", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("FolioId", "folioIdIn", "FolioId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_folioIdInDataFetchStatus", "_folioIdInDataFetchStatus", "_folioIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetFolioApprovalLevels", "getFolioApprovalLevelsAggr", "GetFolioApprovalLevels", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetFolioApprovalLevelsAggrRec());
}, true, GetFolioApprovalLevelsAggrRec), 
this.attr("GetFolioById", "getFolioByIdAggr", "GetFolioById", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetFolioByIdAggrRec());
}, true, GetFolioByIdAggrRec)
].concat(OS$DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS$Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {
Checkbox1: OS$Model.ValidationWidgetRecord,
Checkbox2: OS$Model.ValidationWidgetRecord,
Checkbox3: OS$Model.ValidationWidgetRecord,
Checkbox4: OS$Model.ValidationWidgetRecord,
TextArea_Reason: OS$Model.ValidationWidgetRecord
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
if("FolioId" in inputs) {
this.variables.folioIdIn = inputs.FolioId;
if("_folioIdInDataFetchStatus" in inputs) {
this.variables._folioIdInDataFetchStatus = inputs._folioIdInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


