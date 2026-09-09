import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { RC_367437e31e499bf19d13607cb372e4f5 } from "./ConectaProveedores.model.js";
import OutSystemsUI_Interaction_Video_mvcModel from "./OutSystemsUI.Interaction.Video.mvc$model.js";
import CloneOfPDFViewerODC_PDFViewrReactive_BinaryPDF_mvcModel from "./CloneOfPDFViewerODC.PDFViewrReactive.BinaryPDF.mvc$model.js";

class GetManualByIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_367437e31e499bf19d13607cb372e4f5));
}
static fromStructure(str) {
return new GetManualByIdAggrRec(new GetManualByIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetManualByIdAggrRec.init();



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("i_ManualId", "i_ManualIdIn", "i_ManualId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_i_ManualIdInDataFetchStatus", "_i_ManualIdInDataFetchStatus", "_i_ManualIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetManualById", "getManualByIdAggr", "GetManualById", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetManualByIdAggrRec());
}, true, GetManualByIdAggrRec)
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
Model._hasValidationWidgetsValue = (OutSystemsUI_Interaction_Video_mvcModel.hasValidationWidgets || CloneOfPDFViewerODC_PDFViewrReactive_BinaryPDF_mvcModel.hasValidationWidgets);
}

return Model._hasValidationWidgetsValue;
}
setInputs(inputs) {
if("i_ManualId" in inputs) {
this.variables.i_ManualIdIn = inputs.i_ManualId;
if("_i_ManualIdInDataFetchStatus" in inputs) {
this.variables._i_ManualIdInDataFetchStatus = inputs._i_ManualIdInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


