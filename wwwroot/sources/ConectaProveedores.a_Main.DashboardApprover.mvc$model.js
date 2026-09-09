import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { RC_2a967ca085a7d7066ca851285c363d53, ST_bfed96b4bd29e9b06f0b06e901b1508bStructure } from "./ConectaProveedores.model.js";
import ConectaProveedores_a_Layouts_LayoutTopMenu_mvcModel from "./ConectaProveedores.a_Layouts.LayoutTopMenu.mvc$model.js";
import OutSystemsUI_Adaptive_ColumnsSmallRight_mvcModel from "./OutSystemsUI.Adaptive.ColumnsSmallRight.mvc$model.js";
import OutSystemsUI_Adaptive_Columns2_mvcModel from "./OutSystemsUI.Adaptive.Columns2.mvc$model.js";
import OutSystemsUI_Interaction_ScrollableArea_mvcModel from "./OutSystemsUI.Interaction.ScrollableArea.mvc$model.js";
import ConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_Wb_GetProposalStatusByLevel_mvcModel from "./ConectaProveedores.b_CyA_ApprovalProcessCommissionsLeasing.Wb_GetProposalStatusByLevel.mvc$model.js";

class GetProposalLinesAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_2a967ca085a7d7066ca851285c363d53));
}
static fromStructure(str) {
return new GetProposalLinesAggrRec(new GetProposalLinesAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetProposalLinesAggrRec.init();


class GetApprovedProposalLinesDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("ApprovedProposalLines", "approvedProposalLinesOut", "ApprovedProposalLines", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_bfed96b4bd29e9b06f0b06e901b1508bStructure))());
}, true, (OS$GenericTypeCache.getGenericList(ST_bfed96b4bd29e9b06f0b06e901b1508bStructure))), 
this.attr("o_TotalCount", "o_TotalCountOut", "o_TotalCount", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, true)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

}

GetApprovedProposalLinesDataActRec.init();

class GetNotApprovedProposalLinesDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("NotApprovedProposalLines", "notApprovedProposalLinesOut", "NotApprovedProposalLines", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_bfed96b4bd29e9b06f0b06e901b1508bStructure))());
}, true, (OS$GenericTypeCache.getGenericList(ST_bfed96b4bd29e9b06f0b06e901b1508bStructure))), 
this.attr("o_TotalCount", "o_TotalCountOut", "o_TotalCount", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, true)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

}

GetNotApprovedProposalLinesDataActRec.init();

class GetRejectedProposalLinesDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("RejectedProposalLines", "rejectedProposalLinesOut", "RejectedProposalLines", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_bfed96b4bd29e9b06f0b06e901b1508bStructure))());
}, true, (OS$GenericTypeCache.getGenericList(ST_bfed96b4bd29e9b06f0b06e901b1508bStructure))), 
this.attr("o_TotalCount", "o_TotalCountOut", "o_TotalCount", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, true)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

}

GetRejectedProposalLinesDataActRec.init();


class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("GetProposalLines", "getProposalLinesAggr", "GetProposalLines", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetProposalLinesAggrRec());
}, true, GetProposalLinesAggrRec), 
this.attr("GetApprovedProposalLines", "getApprovedProposalLinesDataAct", "GetApprovedProposalLines", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetApprovedProposalLinesDataActRec());
}, true, GetApprovedProposalLinesDataActRec), 
this.attr("GetNotApprovedProposalLines", "getNotApprovedProposalLinesDataAct", "GetNotApprovedProposalLines", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetNotApprovedProposalLinesDataActRec());
}, true, GetNotApprovedProposalLinesDataActRec), 
this.attr("GetRejectedProposalLines", "getRejectedProposalLinesDataAct", "GetRejectedProposalLines", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetRejectedProposalLinesDataActRec());
}, true, GetRejectedProposalLinesDataActRec)
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
Model._hasValidationWidgetsValue = ((((ConectaProveedores_a_Layouts_LayoutTopMenu_mvcModel.hasValidationWidgets || OutSystemsUI_Adaptive_ColumnsSmallRight_mvcModel.hasValidationWidgets) || OutSystemsUI_Adaptive_Columns2_mvcModel.hasValidationWidgets) || OutSystemsUI_Interaction_ScrollableArea_mvcModel.hasValidationWidgets) || ConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_Wb_GetProposalStatusByLevel_mvcModel.hasValidationWidgets);
}

return Model._hasValidationWidgetsValue;
}
setInputs(inputs) {
}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


