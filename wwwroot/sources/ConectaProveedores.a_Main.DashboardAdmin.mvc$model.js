import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { RC_931c5818c70fb94c867f1591b8f8bd0d, ST_bfed96b4bd29e9b06f0b06e901b1508bStructure } from "./ConectaProveedores.model.js";
import ConectaProveedores_a_Layouts_LayoutTopMenu_mvcModel from "./ConectaProveedores.a_Layouts.LayoutTopMenu.mvc$model.js";
import OutSystemsUI_Adaptive_ColumnsSmallRight_mvcModel from "./OutSystemsUI.Adaptive.ColumnsSmallRight.mvc$model.js";
import OutSystemsUI_Adaptive_Columns2_mvcModel from "./OutSystemsUI.Adaptive.Columns2.mvc$model.js";
import OutSystemsUI_Numbers_ProgressBar_mvcModel from "./OutSystemsUI.Numbers.ProgressBar.mvc$model.js";
import OutSystemsUI_Interaction_ScrollableArea_mvcModel from "./OutSystemsUI.Interaction.ScrollableArea.mvc$model.js";
import Telcel_Theme_Utils_Wb_ShortText_mvcModel from "./Telcel_Theme.Utils.Wb_ShortText.mvc$model.js";
import Telcel_Theme_Utils_Wb_Status_mvcModel from "./Telcel_Theme.Utils.Wb_Status.mvc$model.js";

class GetLast10ProposalsAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_931c5818c70fb94c867f1591b8f8bd0d));
}
static fromStructure(str) {
return new GetLast10ProposalsAggrRec(new GetLast10ProposalsAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetLast10ProposalsAggrRec.init();


class GetErrorAPIProposalsDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("ErrorAPIProposals", "errorAPIProposalsOut", "ErrorAPIProposals", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_bfed96b4bd29e9b06f0b06e901b1508bStructure))());
}, true, (OS$GenericTypeCache.getGenericList(ST_bfed96b4bd29e9b06f0b06e901b1508bStructure)))
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new GetErrorAPIProposalsDataActRec(new GetErrorAPIProposalsDataActRec.RecordClass({
errorAPIProposalsOut: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetErrorAPIProposalsDataActRec.init();

class GetActiveProposalsDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("ActiveProposals", "activeProposalsOut", "ActiveProposals", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_bfed96b4bd29e9b06f0b06e901b1508bStructure))());
}, true, (OS$GenericTypeCache.getGenericList(ST_bfed96b4bd29e9b06f0b06e901b1508bStructure))), 
this.attr("o_TotalCount", "o_TotalCountOut", "o_TotalCount", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, true)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

}

GetActiveProposalsDataActRec.init();

class GetProcessedProposalsDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("ProcessedProposals", "processedProposalsOut", "ProcessedProposals", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_bfed96b4bd29e9b06f0b06e901b1508bStructure))());
}, true, (OS$GenericTypeCache.getGenericList(ST_bfed96b4bd29e9b06f0b06e901b1508bStructure))), 
this.attr("o_TotalCount", "o_TotalCountOut", "o_TotalCount", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, true)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

}

GetProcessedProposalsDataActRec.init();


class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("GetLast10Proposals", "getLast10ProposalsAggr", "GetLast10Proposals", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetLast10ProposalsAggrRec());
}, true, GetLast10ProposalsAggrRec), 
this.attr("GetErrorAPIProposals", "getErrorAPIProposalsDataAct", "GetErrorAPIProposals", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetErrorAPIProposalsDataActRec());
}, true, GetErrorAPIProposalsDataActRec), 
this.attr("GetActiveProposals", "getActiveProposalsDataAct", "GetActiveProposals", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetActiveProposalsDataActRec());
}, true, GetActiveProposalsDataActRec), 
this.attr("GetProcessedProposals", "getProcessedProposalsDataAct", "GetProcessedProposals", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetProcessedProposalsDataActRec());
}, true, GetProcessedProposalsDataActRec)
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
Model._hasValidationWidgetsValue = ((((((ConectaProveedores_a_Layouts_LayoutTopMenu_mvcModel.hasValidationWidgets || OutSystemsUI_Adaptive_ColumnsSmallRight_mvcModel.hasValidationWidgets) || OutSystemsUI_Adaptive_Columns2_mvcModel.hasValidationWidgets) || OutSystemsUI_Numbers_ProgressBar_mvcModel.hasValidationWidgets) || OutSystemsUI_Interaction_ScrollableArea_mvcModel.hasValidationWidgets) || Telcel_Theme_Utils_Wb_ShortText_mvcModel.hasValidationWidgets) || Telcel_Theme_Utils_Wb_Status_mvcModel.hasValidationWidgets);
}

return Model._hasValidationWidgetsValue;
}
setInputs(inputs) {
}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


