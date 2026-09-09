import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes, DataConversion } from "@outsystems/runtime-core-js";
import { ST_3c6142d371d14231f5ddee7b64c28681Structure } from "./ConectaProveedores.model.js";
import { TextRec } from "./Extension.Text.model.js";
import UltimatePDF_PrintLayout_ScreenToPDF_mvcModel from "./UltimatePDF.PrintLayout.ScreenToPDF.mvc$model.js";
import UltimatePDF_PrintLayout_PrintLayout_mvcModel from "./UltimatePDF.PrintLayout.PrintLayout.mvc$model.js";


class GetInvoicesDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("List", "listOut", "List", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_3c6142d371d14231f5ddee7b64c28681Structure))());
}, true, (OS$GenericTypeCache.getGenericList(ST_3c6142d371d14231f5ddee7b64c28681Structure)))
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new GetInvoicesDataActRec(new GetInvoicesDataActRec.RecordClass({
listOut: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetInvoicesDataActRec.init();


class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("InvoiceIdsList", "invoiceIdsListVar", "InvoiceIdsList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(TextRec))());
}, false, (OS$GenericTypeCache.getGenericList(TextRec))), 
this.attr("InvoiceLevelIdsList", "invoiceLevelIdsListVar", "InvoiceLevelIdsList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
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
this.attr("GetInvoices", "getInvoicesDataAct", "GetInvoices", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetInvoicesDataActRec());
}, true, GetInvoicesDataActRec)
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


