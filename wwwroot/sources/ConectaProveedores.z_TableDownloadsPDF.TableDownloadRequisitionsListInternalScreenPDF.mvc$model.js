import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes, DataConversion } from "@outsystems/runtime-core-js";
import { ST_291bf3fef8932fa1af5104e6982c4da9Structure } from "./ConectaProveedores.model.js";
import { TextRec } from "./Extension.Text.model.js";
import UltimatePDF_PrintLayout_ScreenToPDF_mvcModel from "./UltimatePDF.PrintLayout.ScreenToPDF.mvc$model.js";
import UltimatePDF_PrintLayout_PrintLayout_mvcModel from "./UltimatePDF.PrintLayout.PrintLayout.mvc$model.js";


class GetRequisitionsDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("List", "listOut", "List", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_291bf3fef8932fa1af5104e6982c4da9Structure))());
}, true, (OS$GenericTypeCache.getGenericList(ST_291bf3fef8932fa1af5104e6982c4da9Structure)))
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new GetRequisitionsDataActRec(new GetRequisitionsDataActRec.RecordClass({
listOut: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetRequisitionsDataActRec.init();


class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("RequisitionIdList", "requisitionIdListVar", "RequisitionIdList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(TextRec))());
}, false, (OS$GenericTypeCache.getGenericList(TextRec))), 
this.attr("RequisitionLevelIdList", "requisitionLevelIdListVar", "RequisitionLevelIdList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(TextRec))());
}, false, (OS$GenericTypeCache.getGenericList(TextRec))), 
this.attr("StringListIds", "stringListIdsIn", "StringListIds", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_stringListIdsInDataFetchStatus", "_stringListIdsInDataFetchStatus", "_stringListIdsInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("StringListLevelIds", "stringListLevelIdsIn", "StringListLevelIds", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_stringListLevelIdsInDataFetchStatus", "_stringListLevelIdsInDataFetchStatus", "_stringListLevelIdsInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetRequisitions", "getRequisitionsDataAct", "GetRequisitions", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetRequisitionsDataActRec());
}, true, GetRequisitionsDataActRec)
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
Model._hasValidationWidgetsValue = (UltimatePDF_PrintLayout_ScreenToPDF_mvcModel.hasValidationWidgets || UltimatePDF_PrintLayout_PrintLayout_mvcModel.hasValidationWidgets);
}

return Model._hasValidationWidgetsValue;
}
setInputs(inputs) {
if("StringListIds" in inputs) {
this.variables.stringListIdsIn = DataConversion.ServerDataConverter.from(inputs.StringListIds, OS$DataTypes.DataTypes.Text);
}

if("StringListLevelIds" in inputs) {
this.variables.stringListLevelIdsIn = DataConversion.ServerDataConverter.from(inputs.StringListLevelIds, OS$DataTypes.DataTypes.Text);
}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


