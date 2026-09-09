import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes, DataConversion } from "@outsystems/runtime-core-js";
import { ST_3dc7a528e6a1e146b195db5c3edb006aStructure } from "./ConectaProveedores.model.js";
import { TextRec } from "./Extension.Text.model.js";
import UltimatePDF_PrintLayout_ScreenToPDF_mvcModel from "./UltimatePDF.PrintLayout.ScreenToPDF.mvc$model.js";
import UltimatePDF_PrintLayout_PrintLayout_mvcModel from "./UltimatePDF.PrintLayout.PrintLayout.mvc$model.js";


class GetFoliosDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("List", "listOut", "List", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_3dc7a528e6a1e146b195db5c3edb006aStructure))());
}, true, (OS$GenericTypeCache.getGenericList(ST_3dc7a528e6a1e146b195db5c3edb006aStructure)))
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new GetFoliosDataActRec(new GetFoliosDataActRec.RecordClass({
listOut: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetFoliosDataActRec.init();


class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("FolioIdsList", "folioIdsListVar", "FolioIdsList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(TextRec))());
}, false, (OS$GenericTypeCache.getGenericList(TextRec))), 
this.attr("StringListIds", "stringListIdsIn", "StringListIds", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_stringListIdsInDataFetchStatus", "_stringListIdsInDataFetchStatus", "_stringListIdsInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetFolios", "getFoliosDataAct", "GetFolios", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetFoliosDataActRec());
}, true, GetFoliosDataActRec)
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

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


