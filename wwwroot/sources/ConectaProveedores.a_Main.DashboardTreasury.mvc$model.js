import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { RC_bb9053a6ea6eec7bc3ffbc5b5de7b452, ST_bfed96b4bd29e9b06f0b06e901b1508bStructure } from "./ConectaProveedores.model.js";
import ConectaProveedores_a_Layouts_LayoutTopMenu_mvcModel from "./ConectaProveedores.a_Layouts.LayoutTopMenu.mvc$model.js";
import OutSystemsUI_Adaptive_ColumnsSmallRight_mvcModel from "./OutSystemsUI.Adaptive.ColumnsSmallRight.mvc$model.js";
import OutSystemsUI_Adaptive_Columns2_mvcModel from "./OutSystemsUI.Adaptive.Columns2.mvc$model.js";
import OutSystemsUI_Interaction_ScrollableArea_mvcModel from "./OutSystemsUI.Interaction.ScrollableArea.mvc$model.js";
import Telcel_Theme_Utils_Wb_ShortText_mvcModel from "./Telcel_Theme.Utils.Wb_ShortText.mvc$model.js";
import ConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_Wb_GetProposalStatusByLevel_mvcModel from "./ConectaProveedores.b_CyA_ApprovalProcessCommissionsLeasing.Wb_GetProposalStatusByLevel.mvc$model.js";

class GetLast10ProposalsAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_bb9053a6ea6eec7bc3ffbc5b5de7b452));
}
static fromStructure(str) {
return new GetLast10ProposalsAggrRec(new GetLast10ProposalsAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetLast10ProposalsAggrRec.init();


class GetPartiallyPaidProposalsDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("PartiallyPaidProposals", "partiallyPaidProposalsOut", "PartiallyPaidProposals", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_bfed96b4bd29e9b06f0b06e901b1508bStructure))());
}, true, (OS$GenericTypeCache.getGenericList(ST_bfed96b4bd29e9b06f0b06e901b1508bStructure))), 
this.attr("o_TotalCount", "o_TotalCountOut", "o_TotalCount", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, true)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

}

GetPartiallyPaidProposalsDataActRec.init();

class GetPaidProposalsDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("PaidProposals", "paidProposalsOut", "PaidProposals", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_bfed96b4bd29e9b06f0b06e901b1508bStructure))());
}, true, (OS$GenericTypeCache.getGenericList(ST_bfed96b4bd29e9b06f0b06e901b1508bStructure))), 
this.attr("o_TotalCount", "o_TotalCountOut", "o_TotalCount", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, true)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

}

GetPaidProposalsDataActRec.init();

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


class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("GetLast10Proposals", "getLast10ProposalsAggr", "GetLast10Proposals", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetLast10ProposalsAggrRec());
}, true, GetLast10ProposalsAggrRec), 
this.attr("GetPartiallyPaidProposals", "getPartiallyPaidProposalsDataAct", "GetPartiallyPaidProposals", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetPartiallyPaidProposalsDataActRec());
}, true, GetPartiallyPaidProposalsDataActRec), 
this.attr("GetPaidProposals", "getPaidProposalsDataAct", "GetPaidProposals", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetPaidProposalsDataActRec());
}, true, GetPaidProposalsDataActRec), 
this.attr("GetActiveProposals", "getActiveProposalsDataAct", "GetActiveProposals", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetActiveProposalsDataActRec());
}, true, GetActiveProposalsDataActRec)
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
Model._hasValidationWidgetsValue = (((((ConectaProveedores_a_Layouts_LayoutTopMenu_mvcModel.hasValidationWidgets || OutSystemsUI_Adaptive_ColumnsSmallRight_mvcModel.hasValidationWidgets) || OutSystemsUI_Adaptive_Columns2_mvcModel.hasValidationWidgets) || OutSystemsUI_Interaction_ScrollableArea_mvcModel.hasValidationWidgets) || Telcel_Theme_Utils_Wb_ShortText_mvcModel.hasValidationWidgets) || ConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_Wb_GetProposalStatusByLevel_mvcModel.hasValidationWidgets);
}

return Model._hasValidationWidgetsValue;
}
setInputs(inputs) {
}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


